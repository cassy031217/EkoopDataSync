using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EkoopDataSync.Business;
using EkoopDataSync.Model;
using Newtonsoft.Json;

namespace EkoopDataSync
{
    public partial class Member : Form
    {
        private readonly ActionMembers _actionMembers = new ActionMembers();

        private BMembership BMembership { get; } = new BMembership();
        private BClientele BClientele { get; } = new BClientele();

        private MMembership _membership;

        public Member()
        {
            InitializeComponent();

            Load += (s, e) =>
            {
                _membership = new MMembership();
            };
        }

        private async void btnValidate_Click(object sender, EventArgs e)
        {
            //get membership from portal api
            var tempOnlineMemberships = _actionMembers
                .GetMembership("http://localhost:11905/api/Membership")
                .Where(x =>
                    x.LastName.Contains(txtLastname.Text) &&
                    x.FirstName.Contains(txtFirstname.Text) &&
                    x.MiddleName.Contains(txtMiddlename.Text) &&
                    x.IsExists == false)
                .ToList();

            //check if exists offline
            if (tempOnlineMemberships.Count > 0)
            {                
                var tempClientele = BClientele.RetrieveClientele
                .Where(x =>
                    x.LastName == txtLastname.Text &&
                    x.FirstName == txtFirstname.Text &&
                    x.MiddleName == txtMiddlename.Text)
                .ToList();

                if (tempClientele.Count > 0)
                {
                    _membership.LastName = txtLastname.Text;
                    _membership.FirstName = txtFirstname.Text;
                    _membership.MiddleName = txtMiddlename.Text;
                    _membership.BirthDate = Convert.ToDateTime("01/26/1995");                    

                    using (var client = new HttpClient())
                    {
                        var serializedProduct = JsonConvert.SerializeObject(_membership);
                        var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");

                        var response = await client.PostAsync("http://localhost:11905/api/CIFOnlineUser", content);

                        if (response.IsSuccessStatusCode)
                        {
                            //update memebership is exists

                            //_membership = new MMembership();
                            //_membership.IsExists = true;
                            //_membership.id = 9;

                            serializedProduct = JsonConvert.SerializeObject(_membership);
                            content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                            await client.PutAsync("update url here", content);
                        }
                    }
                }
            }
            else
            {
                //diregard
            }
        }
    }
}
