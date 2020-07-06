using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shubham_Bill_System
{
    public partial class MainScreen : Form
    {
        private object pdfdocumet;

        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

            Time.Text = DateTime.Now.ToString();




        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbPaniPuri_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPaniPuri.Checked)
            {
                tbPaniPuri.Enabled = true;
            }
            else
            {
                tbPaniPuri.Enabled = false;
                tbPaniPuri.Text= "0";
            }
        }

        private void cbDhosa_CheckedChanged(object sender, EventArgs e)
        {
            if(cbDhosa.Checked)
            {
                tbDhosa.Enabled = true;
            }
            else
            {
                tbDhosa.Enabled = false;
                tbDhosa.Text = "0";

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
           int panipuri =  Convert.ToInt32(tbPaniPuri.Text);
           int dhosa = Convert.ToInt32(tbDhosa.Text);
           int dabeli = Convert.ToInt32(tbDabeli.Text);
            int pawbhaji = Convert.ToInt32(tbPawBhaji.Text);
            int idali = Convert.ToInt32(tbIdali.Text);
            int panjabi = Convert.ToInt32(tbPanjabi.Text);
            int chainise = Convert.ToInt32(tbChainise.Text);
            int dalrise = Convert.ToInt32(tbDalRise.Text);

            int total = (panipuri * 20) + (dhosa * 50) + (dabeli * 30) + (pawbhaji * 70) + (idali * 30) + (panjabi * 70) + (chainise * 70) + (dalrise * 50);

            lblTotal.Text = total.ToString();



        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void cbDabeli_CheckedChanged(object sender, EventArgs e)
        {

            if(cbDabeli.Checked)
            {
                tbDabeli.Enabled = true;
            }
            else
            {
                tbDabeli.Enabled = false;
                tbDabeli.Text = "0";
            }


        }

        private void cbPawBhaji_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPawBhaji.Checked)
            {
                tbPawBhaji.Enabled = true;
            }
            else
            {
                tbPawBhaji.Enabled = false;
                tbPawBhaji.Text = "0";
            }
        }

        private void cbIdali_CheckedChanged(object sender, EventArgs e)
        {
            if(cbIdali.Checked)
            {
                tbIdali.Enabled = true;
            }
            else
            {
                tbIdali.Enabled = false;
                tbIdali.Text = "0";
            }
        }

        private void cbPanjabi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPanjabi.Checked)
            {
                tbPanjabi.Enabled = true;
            }
            else
            {
                tbPanjabi.Enabled = false;
                tbPanjabi.Text = "0";
            }
        }

        private void cbchinise_CheckedChanged(object sender, EventArgs e)
        {
            if(cbchinise.Checked)
            {
                tbChainise.Enabled = true;

            }
            else
            {
                tbChainise.Enabled = false;
                tbChainise.Text = "0";
            }
        }

        private void cbDalRise_CheckedChanged(object sender, EventArgs e)
        {
            if(cbDalRise.Checked)
            {
                tbDalRise.Enabled = true;
            }
            else
            {
                tbDalRise.Enabled = false;
                tbDalRise.Text = "0";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {


            btnRecept.Enabled = true;
            Time.Text = DateTime.Now.ToString();
            lblTotal.Text = "Total";

            cbPaniPuri.Checked= false;
            cbDhosa.Checked = false;
            cbDabeli.Checked = false;
            cbPawBhaji.Checked = false;
            cbIdali.Checked = false;
            cbPanjabi.Checked = false;
            cbchinise.Checked = false;
            cbDalRise.Checked = false;


            tbRecept.Text = "";
        }

        private void btnRecept_Click(object sender, EventArgs e)
        {

            tbRecept.AppendText("=====================================" + Environment.NewLine);
            tbRecept.AppendText("\t Hotel Auspicious"+Environment.NewLine);
            tbRecept.AppendText("=====================================" + Environment.NewLine);
            tbRecept.AppendText(Environment.NewLine);
            tbRecept.AppendText(Environment.NewLine);
            tbRecept.AppendText("Item\t\tQuntity\tPrice");
            tbRecept.AppendText(Environment.NewLine);
            tbRecept.AppendText(Environment.NewLine);
            tbRecept.AppendText("PaniPuri\t\t" +tbPaniPuri.Text+ "\t"+20+Environment.NewLine);
            tbRecept.AppendText("Dhosa\t\t" +tbDhosa.Text+ "\t"+50+Environment.NewLine);
            tbRecept.AppendText("Dabeli\t\t" +tbDabeli.Text+ "\t"+30+Environment.NewLine);
            tbRecept.AppendText("PawBhaji\t\t" +tbPawBhaji.Text+ "\t"+70+Environment.NewLine);
            tbRecept.AppendText("Idali\t\t" +tbIdali.Text+ "\t"+30+Environment.NewLine);
            tbRecept.AppendText("Panjabi\t\t" +tbPanjabi.Text+ "\t"+70+Environment.NewLine);
            tbRecept.AppendText("Chainise\t\t" +tbChainise.Text+ "\t"+70+Environment.NewLine);
            tbRecept.AppendText("Dal Rise\t\t" +tbDalRise.Text+ "\t"+50+Environment.NewLine);

            tbRecept.AppendText(Environment.NewLine);
            tbRecept.AppendText("=====================================" + Environment.NewLine);
            tbRecept.AppendText("=====================================" + Environment.NewLine);
            tbRecept.AppendText("Service Charge\t\t0" + Environment.NewLine);
            tbRecept.AppendText("=====================================" + Environment.NewLine);
            tbRecept.AppendText("=====================================" + Environment.NewLine);
            tbRecept.AppendText("Total Bill\t\t\t"+lblTotal.Text+Environment.NewLine);





            btnRecept.Enabled = false;

        }

        private void tbPaniPuri_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

  
}
