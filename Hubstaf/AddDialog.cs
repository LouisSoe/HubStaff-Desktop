using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hubstaf
{
    public partial class AddDialog : Form
    {
        SqlConnection con = new SqlConnection(utils.con);
        SqlCommand cmd;

        public AddDialog()
        {
            InitializeComponent();
            btndone.Enabled = false;
        }

        private void btndone_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into ");
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succes inserted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDialog_Load(object sender, EventArgs e)
        {
           
        }

        private void txttodo_TextChanged(object sender, EventArgs e)
        {
            if (txttodo.TextLength > 0)
            {
                btndone.Enabled = true;

            }
            else
            {
                btndone.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure to exit ?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}
