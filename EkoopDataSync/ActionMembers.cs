using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EkoopDataSync.Model;
using Newtonsoft.Json;

namespace EkoopDataSync
{
    public class ActionMembers
    {
        public List<MMembership> GetMembership(string url)
        {
            List<MMembership> mEmployees = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                        mEmployees = JsonConvert.DeserializeObject<List<MMembership>>(reader.ReadToEnd());
                    }
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                        string errorText = reader.ReadToEnd();

                        MessageBox.Show(errorText, @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                throw;
            }

            return mEmployees;
        }
    }   
}
