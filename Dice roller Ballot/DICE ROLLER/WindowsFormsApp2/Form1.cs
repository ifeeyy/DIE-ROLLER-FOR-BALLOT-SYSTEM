using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Image Nothing { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }



        private void cmdROLL_click(object sender, EventArgs e)
        {//Call built-in System.Random lives in System namespace in .Net!
            Random r = new Random();

            //Declare new data to get random value from object r.
            int iRnd = new int();//Data must be initialized before use.

            iRnd = r.Next(0, 6);//Counting randomly from 0 to 5.

            //Compare the data with each random number.
            if (iRnd == 0)
                pictureBox7.Image = pictureBox1.Image;else if (iRnd == 1)
                pictureBox7.Image = pictureBox2.Image;

            else if (iRnd == 2)
                pictureBox7.Image = pictureBox3.Image;
            else if (iRnd == 3)
                pictureBox7.Image = pictureBox4.Image;
            else if (iRnd == 4)
                pictureBox7.Image = pictureBox5.Image;
            else if (iRnd == 5)
                pictureBox7.Image = pictureBox6.Image;

            KeyValuePair<string, string> kvp = (KeyValuePair<string, string>)comboBox1.SelectedItem;
            string key = kvp.Key.ToString();
            string value = kvp.Value.ToString();

            label1.Text = key + " " + value;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            comboBox1.Items.Add(new KeyValuePair<string, string>("Dr ABIMBOLA", "YOUR NUMBER IS"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("Dr BANJO", "YOUR NUMBER IS"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("Dr OGUNBOWALE", "YOUR NUMBER IS"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("Dr ADEKOYA", "YOUR NUMBER IS"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("Dr AKINBAJO", "YOUR NUMBER IS"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("Dr SAYO IDOWU", "YOUR NUMBER IS"));

            comboBox1.DisplayMember = "key";
            comboBox1.ValueMember = "value";





        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
