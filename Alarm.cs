using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PetCare
{
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();

            Sub.title = "VISIT";
            Sub.note = "CONDITION";
            Sub.hour = "10";
            Sub.min = "20";
        }


        SoundPlayer player = new SoundPlayer();
        private void Alarm_Load(object sender, EventArgs e)
        {
            switch (Sub.title)
            {
                case "FOOD":
                    pictureBox1.Image = global::PetCare.Properties.Resources.FOOD;
                    label2.Text = "FOOD";
                    break;
                case "HAIR":
                    pictureBox1.Image = global::PetCare.Properties.Resources.HAIR;
                    label2.Text = "HAIR";
                    break;
                case "NAIL":
                    pictureBox1.Image = global::PetCare.Properties.Resources.NAIL;
                    label2.Text = "NAIL";
                    break;
                case "VISIT":
                    pictureBox1.Image = global::PetCare.Properties.Resources.VISIT;
                    label2.Text = "PET VISIT";
                    break;
                case "VACCINATION":
                    pictureBox1.Image = global::PetCare.Properties.Resources.VACCINATION;
                    label2.Text = "VACCINATION";
                    break;
            }

            label1.Text = Sub.title;




            try
            {

                player.SoundLocation = @BackGroundSetting.music;
                player.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label1.Text = Sub.title;
            int u = Int32.Parse(Sub.hour);
            //circularProgressBar1.Text = Sub.hour + ":" + Sub.min;

        }

        private void Alarm_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.Stop();
        }
    }
}
