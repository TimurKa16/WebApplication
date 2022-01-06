

    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net.Http;
using Newtonsoft.Json;
using RestSharp;
using System.Threading;

namespace RestSharpClientWinForms
{
    public partial class RestClientForm : Form
    {
        string url = "https://webapp20211225154702.azurewebsites.net/api";
        //string url = "https://localhost:44350/api";
        //string url = "https://api.ebay.com/sell/account/v1/custom_policy";

        public RestClientForm()
        {
            InitializeComponent();
        }


        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            PostMessage postMessage = new PostMessage()
            {
                FromWhom = fromWhomTextBox.Text,
                ToWhom = toWhomTextBox.Text,
                Message = requestMessageTextBox.Text
            };

            
            MakeRequest(postMessage);



        }

        private IRestResponse MakeRequest(PostMessage postMessage)
        {
            var client = new RestClient(url);
            var request = new RestRequest();
            request.AddJsonBody(postMessage);
            var response = client.Post(request);
            //"{"Id":0,"FromWhom":"1","ToWhom":"2","Message":"1"}"
            if (response.Content != "{\"id\":0,\"fromWhom\":null,\"toWhom\":null,\"message\":null}" &&
                response.Content != "")
            {
                response = CorrectResponse(response);
                postMessage = JsonConvert.DeserializeObject<PostMessage>(response.Content.ToString());
                responseMessageTextBox.Text += "От " + postMessage.FromWhom + ": " +
                    postMessage.Message + Environment.NewLine;
            }
            //responseMessageTextBox.Text += response.StatusCode.ToString();
            //responseMessageTextBox.Text += response.Content.ToString();

            return response;
        }

        private IRestResponse CorrectResponse(IRestResponse response)
        {
            string jsonString = response.Content;

            response.Content = response.Content.Replace("id", "Id");
            response.Content = response.Content.Replace("fromWhom", "FromWhom");
            response.Content = response.Content.Replace("toWhom", "ToWhom");
            response.Content = response.Content.Replace("message", "Message");

            return response;
        }

        Thread connectionThread;
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            connectionThread = new Thread(ListenResponse);
            connectionThread.IsBackground = true;
            connectionThread.Start();
        }

        private void ListenResponse()
        {
            while (true)
            {
                PostMessage postMessage = new PostMessage()
                {
                    FromWhom = fromWhomTextBox.Text,
                    ToWhom = toWhomTextBox.Text,
                    Message = ""
                };

                
                

                Thread.Sleep(1000);
                try
                {
                    Invoke((MethodInvoker)delegate ()
                    {
                        MakeRequest(postMessage);
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            connectionThread.Abort();
        }

        private void RestClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
