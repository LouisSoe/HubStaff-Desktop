using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Net.Http.Formatting;
using MySqlX.XDevAPI;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Hubstaf
{
    public partial class Form1 : Form
    {
       
        System.Timers.Timer t;
        int h, m, s;
        public Form1()
        {
            InitializeComponent();
            shows();
            populateitem();
            //loadgrid();
            //getData();
        }


        void timer()
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
        }

        void shows() 
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }
        void hideS()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }
        private void getData()
        {
            try
            {
                string url = "https://23a3-158-140-172-123.ap.ngrok.io/api/project";
                var webrequest = (HttpWebRequest)WebRequest.Create(url);
                var webrespon = (HttpWebResponse)webrequest.GetResponse();
                if ((webrespon.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webrespon.GetResponseStream());
                    string data = reader.ReadToEnd();
                    string id = "Data";
                    var obj = JObject.Parse(data);
                    var getdata = obj["Data"];

                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(getdata.ToString(), (typeof(DataTable)));
                  ////  MessageBox.Show((string)dt.Rows[1]["nameProject"].ToString());
                    foreach (DataRow dr in dt.Rows)
                    {
                        //dt.Rows[1].ToString();
                    }

                     ////   MessageBox.Show(dt.Rows.Count.ToString());
                    //     MessageBox.Show(getdata.ToString());
                    //foreach(DataRow row in dt.Rows)
                    //{
                    //    MessageBox.Show(dt);
                    //}
                    //var arr = JsonConvert.DeserializeObject<JArray>(getdata.ToString());
                    //gunaDataGridView1.ReadOnly = true;
                    //gunaDataGridView1.DataSource = getdata;
                  ////  MessageBox.Show(String.Format("berhasil"));
                }
                else
                {
                    MessageBox.Show(String.Format("Status code = {0}", webrespon.StatusCode));
                    MessageBox.Show(String.Format("gagal"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void loadgrid()
        {
            HttpClient clint= new HttpClient();
             clint.BaseAddress = new Uri("https://23a3-158-140-172-123.ap.ngrok.io/");
            HttpResponseMessage response = clint.GetAsync("api/project").Result;
            var project = response.Content.ReadAsAsync<IEnumerable<Model.ModelPro>>().Result;
           // gunaDataGridView1.DataSource=project;
        }

        private void populateitem()
        {
            try
            {
                string url = "https://a3da-158-140-172-123.ap.ngrok.io/api/project";
                var webrequest = (HttpWebRequest)WebRequest.Create(url);
                var webrespon = (HttpWebResponse)webrequest.GetResponse();
                if ((webrespon.StatusCode == HttpStatusCode.OK))
                {

                    var reader = new StreamReader(webrespon.GetResponseStream());
                    string data = reader.ReadToEnd();
                    string id = "Data";
                    var obj = JObject.Parse(data);
                    var getdata = obj["Data"];

                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(getdata.ToString(), (typeof(DataTable)));
                    for(int i = 0; i < dt.Rows.Count; i++)
                    {
                        MessageBox.Show((string)dt.Rows[i]["nameProject"].ToString());
                    }

                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    //dt.Rows[1].ToString();
                    //}
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


                projectcontainer[] projectcontainerss = new projectcontainer[20];
            for (int i = 0; i < projectcontainerss.Length; i++)
            {
                projectcontainerss[i] = new projectcontainer();
                projectcontainerss[i].Name = "nameProject";
                //if (flowLayoutPanel1.Controls.Count >0)
                //{
                //    flowLayoutPanel1.Controls.Clear();
                //}
                //else

                //    flowLayoutPanel1.Controls.Add(projectcontainerss[i]);
            }

        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {

                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                txtresult.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));

            }));
            
        }

        private void CaptureMyScreen()
        {
            try
            {
               
                Bitmap captureBitmap = new Bitmap(1024, 768, PixelFormat.Format32bppArgb);
                
                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
            
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
              
                captureBitmap.Save(@"D:\Capture.jpg", ImageFormat.Jpeg);
               
                MessageBox.Show("Screen Captured");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaTextBox2_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text == "Search Project")
            {
                gunaTextBox2.Text = "";

                gunaTextBox2.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox2_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text == "")
            {
                gunaTextBox2.Text = "Search Project";

                gunaTextBox2.ForeColor = Color.DimGray;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
           AddDialog d = new AddDialog();
            d.Show();
        }

        private void gunaTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer();
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
            t.Start();
            hideS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            t.Stop();
            shows();
        }

        private void gunaTextBox4_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox4.Text == "Create a to-do")
            {
                gunaTextBox4.Text = "";

                gunaTextBox4.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox4_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox4.Text == "")
            {
                gunaTextBox4.Text = "Create a to-do";

                gunaTextBox4.ForeColor = Color.DimGray;
            }
        }

        private void gunaTextBox3_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox3.Text == "Create a to-do")
            {
                gunaTextBox3.Text = "";

                gunaTextBox3.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox3_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox3.Text == "")
            {
                gunaTextBox3.Text = "Create a to-do";

                gunaTextBox3.ForeColor = Color.DimGray;
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            CaptureMyScreen();
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
           // MessageBox.Show("Helo");
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("info");
        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void projectcontainer1_Load(object sender, EventArgs e)
        {

        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
