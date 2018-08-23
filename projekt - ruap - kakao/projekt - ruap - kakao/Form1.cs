using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace projekt___ruap___kakao
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_rev_date_Click(object sender, EventArgs e)
        {

        }

        public class StringTable
        {
            public string[] ColumnNames { get; set; }
            public string[,] Values { get; set; }
        }

        private async void btn_predict_Click(object sender, EventArgs e)
        {
            string reviewDate = txt_rev_date.Text;
            string companyLocation = txt_comp_loc.Text;
            string rating = txt_rating.Text;
            string cocoaPercent = txt_coc_perc.Text;

            StringBuilder cocoaAddres = new StringBuilder();
            cocoaAddres.Append("http://maps.google.com/maps?q=");
            if (companyLocation != string.Empty)
            {
                cocoaAddres.Append(companyLocation + ",");
            }
            webBrowser1.Navigate(cocoaAddres.ToString());
            lbl_perc.Text = cocoaPercent.ToString();
            lbl_score_perc.Text = await InvokeRequestResponseService(reviewDate, companyLocation, rating, cocoaPercent);
            
        }
        static async Task<String> InvokeRequestResponseService(string revD, string cL, string r, string cP)
        {
            using (var client = new HttpClient())
            {
                var scoreRequest = new
                {

                    Inputs = new Dictionary<string, StringTable>() {
                        {
                            "input1",
                            new StringTable()
                            {
                                ColumnNames = new string[] {"Company (Maker-if known)", "Specific Bean Origin or Bar Name", "REF", "Review Date", "Cocoa Percent", "Company Location", "Rating", "Bean Type", "Broad Bean Origin"},
                                Values = new string[,] {  { "value", "value", "0", revD, cP, cL, r,"value", "value" },  { "value", "value", "0", revD, cP, cL, r, "value", "value" },  }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };
                const string apiKey = "YFmfNrt1eCzaGBpC4H6rZB5LWeHq/Q4o58AYhe9tGjQmCrS4PjDxhi4ZOixHxIb+sEU8sjvlIUCeoMDaK5o9ww=="; // Replace this with the API key for the web service
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/96624a90e0be4887b237b7ed57562064/services/1a8ab16c37f14c8ebda0c2f57cabcf19/execute?api-version=2.0&details=true");

                // WARNING: The 'await' statement below can result in a deadlock if you are calling this code from the UI thread of an ASP.Net application.
                // One way to address this would be to call ConfigureAwait(false) so that the execution does not attempt to resume on the original context.
                // For instance, replace code such as:
                //      result = await DoSomeTask()
                // with the following:
                //      result = await DoSomeTask().ConfigureAwait(false)

                HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    JObject o = JObject.Parse(result); //čita JSON datoteku results
                    
                    double lbl2 = (double)o["Results"]["output1"]["value"]["Values"][0][1]; //uzima vrijednost scored labels

                    return lbl2.ToString(); //vraća vrijednost iz JSON datoteke
                }
                else
                {
                    Console.WriteLine(string.Format("The request failed with status code: {0}", response.StatusCode));

                    // Print the headers - they include the requert ID and the timestamp, which are useful for debugging the failure

                    Console.WriteLine(response.Headers.ToString());

                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);

                    return "greška";
                }
            }
        }

        private void lbl_perc_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
