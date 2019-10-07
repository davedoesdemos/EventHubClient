using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Security.Cryptography;
using System.Globalization;
using System.Net.Http;
using System.Threading;
namespace EventHubClient
{
    public partial class FormEventHubClient : Form
    {
        public FormEventHubClient()
        {
            InitializeComponent();
            //ThreadPool.SetMaxThreads(10, 10);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int worker;
            int io;
            ThreadPool.GetAvailableThreads(out worker, out io);
            if (worker > 0)
            {
                ThreadPool.QueueUserWorkItem(SendEventToHub);
            }
        }

        private void NumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(numericUpDownTimerInterval.Value);
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            panel1.BackColor = Color.Green;
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            panel1.BackColor = Color.Red;
            
        }

        private void SetURI(object sender, EventArgs e)
        {
            textBoxURL.Text = "https://" + textBoxNamespace.Text + ".servicebus.windows.net/" + textBoxEventHub.Text + "/publishers/" + textBoxPublisher.Text + "/messages";
        }

        private void TextBoxURL_TextChanged(object sender, EventArgs e)
        {
               TimeSpan sinceEpoch = DateTime.UtcNow - new DateTime(1970, 1, 1);
               var week = 60 * 60 * 24 * 7;
               var expiry = Convert.ToString((int)sinceEpoch.TotalSeconds + week);

               string stringToSign = HttpUtility.UrlEncode(textBoxURL.Text) + "\n" + expiry;
               HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(textBoxSASKey.Text));
               var signature = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(stringToSign)));
               textBoxSASToken.Text = String.Format(CultureInfo.InvariantCulture, "SharedAccessSignature sr={0}&sig={1}&se={2}&skn={3}", HttpUtility.UrlEncode(textBoxURL.Text), HttpUtility.UrlEncode(signature), expiry, textBoxSASKeyName.Text);
        }

        private void SendEventToHub(object state)
        {
            var rand = new Random();
            var randomnumber = new Int32();
            randomnumber = rand.Next(Convert.ToInt32(numericUpDownRangeMin.Value), Convert.ToInt32(numericUpDownRangeMax.Value) + 1);

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                // Set the method to GET
                request.Method = HttpMethod.Post;

                // Construct the full URI
                request.RequestUri = new Uri(textBoxURL.Text);
                
                // Add the authorization header
                request.Headers.Add("Authorization", textBoxSASToken.Text);

                request.Properties.Add("number", randomnumber);

                // Send request, get response
                var response = client.SendAsync(request).Result;
            }
        }
    }
}
