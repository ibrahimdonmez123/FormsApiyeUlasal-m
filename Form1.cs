using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApiyeUlasalım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:8090/");
                HttpResponseMessage response = await client.GetAsync("api/sehir");
                string result = await response.Content.ReadAsStringAsync();
                label1.Text = result;
            


        }
    }
}
