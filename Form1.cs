using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using PetCare.Featured_Tabs.Setting;

namespace PetCare
{
    public partial class Form1 : Form
    {
        public HOME stg = new HOME();

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            readfile();
            //panel2.Hide();
            label18.Hide();
            label17.Hide();
            label19.Hide();
            pictureBox4.Hide();
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = this.BackColor;
        }

        public void readfile()
        {
            StreamReader sr = new StreamReader("CatBreed.txt");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                //comboBox3.Items.Add(line);
            }

            sr.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // panel2.Show();
           // panel3.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //stg.Close();
            //pictureBox6.Image = null;
            label18.Show();
            label17.Hide();
            label19.Hide();
            ActiveMdiChild.Close();
            HOME stg = new HOME();
            stg.MdiParent = this;
            stg.Show();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //pictureBox6.Image = null;
            label18.Hide();
            label19.Hide();
            label17.Show();
            ActiveMdiChild.Close();
            CARE stg = new CARE();
            stg.MdiParent = this;
            stg.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //pictureBox6.Image =null;
            ActiveMdiChild.Close();
            MEDICAL stg = new MEDICAL();
            stg.MdiParent = this;
            stg.Show();
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            stg.MdiParent = this;
            stg.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            label1.Text = hh + ":" + mm + ":" + ss;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           // label15.Text = comboBox3.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // label12.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //label16.Text = textBox2.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // label13.Text = comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label14.Text = comboBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // panel2.Hide();
           // panel3.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //pictureBox6.Image = null;
            label18.Hide();
            label17.Hide();
            label19.Show();
            ActiveMdiChild.Close();
            SETTING stg = new SETTING();
            stg.MdiParent = this;
            stg.Show();
        }

        /*public void LoadEverything()
        {
            //------------------------------------------------
            CARE            care            = new CARE();
            //------------------------------------------------
            Hygiene         hygiene         = new Hygiene();
            Vaccincation    vaccincation    = new Vaccincation();
            Medication      medication      = new Medication();
            Measurement     measurement     = new Measurement();
            Incident        incident        = new Incident();
            Food            food            = new Food();
            //------------------------------------------------
            MEDICAL         medical         = new MEDICAL();
            //------------------------------------------------
            Lab_Document    document        = new Lab_Document();
            Diagnostic      diagnostic      = new Diagnostic();
            Genetic         genetic         = new Genetic();
            Condition       condition       = new Condition();
            Surgery         surgery         = new Surgery();
            Visit           visit           = new Visit();
            //------------------------------------------------
            care.MdiParent          = this;
            hygiene.MdiParent       = this;
            vaccincation.MdiParent  = this;
            medication.MdiParent    = this;
            measurement.MdiParent   = this;
            incident.MdiParent      = this;
            food.MdiParent          = this;
            medical.MdiParent       = this;
            document.MdiParent      = this;
            diagnostic.MdiParent    = this;
            genetic.MdiParent       = this;
            condition.MdiParent     = this;
            surgery.MdiParent       = this;
            visit.MdiParent         = this;
        }

        public void HideEverything()
        {

            care.Hide();
            hygiene.Hide();
            vaccincation.Hide();
            medication.Hide();
            measurement.Hide();
            incident.Hide();
            food.Hide();
            medical.Hide();
            document.Hide();
            diagnostic.Hide();
            genetic.Hide();
            condition.Hide();
            surgery.Hide();
            visit.Hide();
        }*/
    }
}
