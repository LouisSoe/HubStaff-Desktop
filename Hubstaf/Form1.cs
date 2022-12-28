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
using Hubstaf.Resources;

namespace Hubstaf
{
    public partial class Form1 : Form
    {
       
        System.Timers.Timer t;
        int h, m, s;
        public static Panel todoContainers;
        public Form1()
        {
            InitializeComponent();
            shows();
            showProject();
            todoContainers = todoContainer;
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
        

        private void showProject()
        {
            try
            {
                string url = "http://127.0.0.1:8000/api/project/";
                var webrequest = (HttpWebRequest)WebRequest.Create(url);
                var webrespon = (HttpWebResponse)webrequest.GetResponse();
                if ((webrespon.StatusCode == HttpStatusCode.OK))
                {

                    var reader = new StreamReader(webrespon.GetResponseStream());
                    string data = reader.ReadToEnd();
                    var obj = JObject.Parse(data);
                    var getdata = obj["Data"];

                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(getdata.ToString(), (typeof(DataTable)));

                    int dataCount = dt.Rows.Count;
                    projects[] projectList = new projects[dataCount];
                    for (int i = 0; i < projectList.Length; i++)
                    {
                        projectList[i] = new projects();
                        projectList[i].projectName = getdata[i]["nameProject"].ToString();
                        projectList[i].Id = getdata[i]["idProject"].ToString();
                        if (projectContainer.Controls.Count < 0)
                        {
                            projectContainer.Controls.Clear();
                        }
                        else
                            projectContainer.Controls.Add(projectList[i]);
                    }

                }
            }catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
