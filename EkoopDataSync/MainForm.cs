using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EkoopDataSync.Model;

namespace EkoopDataSync
{
    public partial class  MainForm : Form
    {
        private Action _act = new Action();
        //private string _url_ApprovedMembership = "http://localhost:11905/Api/ApprovedMembership";
        private string _url_Region = "http://localhost:11905/Api/Region";
        //private string _
        //separator = "/";
        private string xid;


        private int _id
        {
            get
            {
                xid = txtID.Text;
                return Convert.ToInt32(xid);
            }
            set => txtID.Text = value.ToString();
        }

        private string _Lastname
        {
            get => txtLastname.Text;
            set => txtLastname.Text = value.ToString();
        }


        private string _Firstname
        {
            get => txtFirstname.Text;
            set => txtFirstname.Text = value.ToString();
        }

        private string _Middlename
        {
            get => txtMiddlename.Text;
            set => txtMiddlename.Text = value.ToString();
        }


        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            EkoopDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EkoopDataGrid.DataSource = _act.GetAllRegion(_url_Region);
            EkoopDataGrid.Refresh();
        }

        private void btnGET_Click(object sender, EventArgs e)
        {
            Model.Region r = new Model.Region();
            //r = _act.GetRegion(_urlGet + _separator, _regCode);
            //r = _act.GetRegion(_urlGet + _separator, _id);
            //r = _act.GetRegion(_url_Region); 

            //txtLastname.Text = r.psgcCode;
            //txtFirstname.Text = r.shortname;
            //txtMiddlename.Text = r.Description;
        }

        //private void EkoopDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex > 0)
        //    {
        //        var row = EkoopDataGrid.CurrentRow;
        //        //_regCode = (row?.Cells[3].Value.ToString());
        //        _id = (row?.Cells[3].Value.ToString());
        //    }
        //}

        //private void btnRefresh_Click(object sender, EventArgs e)
        //{
        //    EkoopDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    //EkoopDataGrid.DataSource = _act.GetRegions(_urlGet);
        //    EkoopDataGrid.DataSource = _act.GetMembershipPaymentFee(_urlGet);
        //    EkoopDataGrid.Refresh();

        //    ClearControls();

        //    //EkoopDataGrid.DataSource = _act.GetRegions(_urlGet);
        //    EkoopDataGrid.DataSource = _act.GetMembershipPaymentFee(_urlGet);
        //}

        //private void btnPOST_Click(object sender, EventArgs e)
        //{
        //    _act.Post(_urlGet,
        //         //_psgcCode,
        //         //_shortname,
        //         //_Description,
        //         //_regCode);
        //         _Amount,
        //         _Remarks,
        //         _Description
        //        );

        //    ClearControls();

        //    EkoopDataGrid.DataSource = _act.GetMembershipPaymentFee(_urlGet);

        //}


        private void ClearControls()
        {
           foreach (Control x in Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }
        }

        private void txtBaseURL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
