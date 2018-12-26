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

namespace PetCare
{
    public sealed class BackGroundSetting
    {
        public static string music;
        public static string color;
        public static int fh1 = 0;

        public static int fm1 = 0;

        public static int fh2 = 0;
        public static int fm2 = 0;
        public static int fh3 = 0;
        public static int fm3 = 0;
        //public static int f1 = 0;

        public static void SaveSetting()
        {

            int u = 1;
            TextWriter writer = new StreamWriter("Setting.txt");
           
            writer.WriteLine(music);
   

            writer.Close();
            return;
        }

        public static void ReadSetting()
        {
            StreamReader r = new StreamReader("Setting.txt");
            string line = "";
            int l = 1;
            while ((line = r.ReadLine()) != null)
            {
                music = line;               
            }               
            r.Close();
        }






    }
}
