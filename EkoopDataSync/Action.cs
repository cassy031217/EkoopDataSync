using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EkoopDataSync.Model;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;


namespace EkoopDataSync
{
    public class Action
    {
        //Get List
        public List<ApprovedMembership> GetAllApprovedMembership(string url)
        //{
        //    List<ApprovedMembership> ApprovedMemberships = null;
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

        //    try
        //    {
        //        WebResponse response = request.GetResponse();
        //        using (Stream responseStream = response.GetResponseStream())
        //        {
        //            if (responseStream != null)
        //            {
        //                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
        //                ApprovedMemberships = JsonConvert.DeserializeObject<List<ApprovedMembership>>(reader.ReadToEnd());
        //            }
        //        }
        //    }
        //    catch (WebException ex)
        //    {
        //        WebResponse errorResponse = ex.Response;
        //        using (Stream responseStream = errorResponse.GetResponseStream())
        //        {
        //            if (responseStream != null)
        //            {
        //                StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
        //                string errorText = reader.ReadToEnd();

        //                MessageBox.Show(errorText, @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            }
        //        }
        //        throw;
        //    }
        //    return ApprovedMemberships;
        //}



        //Get by Id
        //public ApprovedMembership GetApprovedMembership(string url, string id)
        //{
        //    ApprovedMembership ApprovedMembership = null;
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + id);

        //    try
        //    {
        //        WebResponse response = request.GetResponse();
        //        using (Stream responseStream = response.GetResponseStream())
        //        {
        //            if (responseStream != null)
        //            {
        //                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
        //                ApprovedMembership = JsonConvert.DeserializeObject<ApprovedMembership>(reader.ReadToEnd());
        //            }
        //        }
        //    }
        //    catch (WebException ex)
        //    {
        //        WebResponse errorResponse = ex.Response;
        //        using (Stream responseStream = errorResponse.GetResponseStream())
        //        {
        //            if (responseStream != null)
        //            {
        //                StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
        //                string errorText = reader.ReadToEnd();

        //                MessageBox.Show(errorText, @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            }
        //        }
        //        throw;
        //    }
        //    return ApprovedMembership;
        //}




        //Get List Region
        public List<Region> GetAllRegion(string url)
        {
            List<Region> Regions = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                        Regions = JsonConvert.DeserializeObject<List<Region>>(reader.ReadToEnd());
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
            return Regions;
        }




        //Get Region by Id
        public Region GetRegion(string url, string id)
        {
            Region DatApprovedMembership = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + id);

            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                        DatApprovedMembership = JsonConvert.DeserializeObject<Region>(reader.ReadToEnd());
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
            return DatApprovedMembership;
        }









        //Post
        //public async void Post(string url, string str1, string str2, string str3, string str4)
        //public async void Post(string url, decimal str1, string str2, string str3)
        //{
        //    //Region r = new Region
        //    //{
        //    //    psgcCode = str1,
        //    //    shortname = str2,
        //    //    Description = str3,
        //    //    regCode = str4
        //    //};

        //    MembershipPaymentFee r = new MembershipPaymentFee
        //    {
        //        Amount = str1,
        //        Remarks = str2,
        //        Description = str3,

        //    };





        //    using (var client = new HttpClient())
        //    {
        //        var serializedProduct = JsonConvert.SerializeObject(r);
        //        var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
        //        var RegionResult = await client.PostAsync(url, content);
        //    }
        //}







    }
}
