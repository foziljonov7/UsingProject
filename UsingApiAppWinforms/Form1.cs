using Autofac.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsingApiAppData.Models;

namespace UsingApiAppWinforms
{
    public partial class Form1 : Form
    {
        private object kursItem;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = comboBox1.Items[0];
        }
        private void FillDatas()
        {
            //List<KursUserControl> kursUserControls = new List<KursUserControl>();
            //foreach (var kurs in service.GetAllToday())
            //{
            //    kursItem kursitem = new kursItem()
            //    {
            //        itemName = kurs.Name,
            //        itemValue = kurs.Rate
            //    };
                
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string url = "https://localhost:44384/api/Kurs/getall";
            //HttpClient client = new HttpClient();
            //var response = client.GetStringAsync(url).Result;
            //var result = JsonConvert.DeserializeObject<List<Kurs>>(response);
            //foreach(var item in result)
            //{
            //    kursItem = item.Name,
            //    kursItem = item.Rate
            //};
            //flowLayoutPanel1.Controls.Add(kursItem);
        }
    }
}
