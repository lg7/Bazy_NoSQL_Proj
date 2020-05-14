using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotApi
{
    public partial class Form1 : Form
    {

        static HttpClient client = new HttpClient();
        bool start = false;



        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {




        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            start = true;

            await testmetodyAsync();

        }


        public async Task testmetodyAsync()
        {
            // for (int i = 0; i <= 19; i++)
            Random rnd = new Random();
            int i = 1;
            do
            {
                var position = new Position();

                position.pos_x = Int32.Parse(posxBox3.Text)+ rnd.Next(-10,10);
                position.pos_y = Int32.Parse(posyBox4.Text) + rnd.Next(-10, 10);
                position.rn = rmBox5.Text;
                position.speed = Int32.Parse(speedBox7.Text);
                position.pesel = rmBox5.Text;
                position.date = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);

                var json = JsonConvert.SerializeObject(position);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                string url = textBox1.Text;
                var response = await client.PostAsync(url, data);
                string result = response.Content.ReadAsStringAsync().Result;

                label8.Text = result + " " + i;
                i++;
                Thread.Sleep(5000);

            } while (start == true);

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            start = false;
        }
    }
}
