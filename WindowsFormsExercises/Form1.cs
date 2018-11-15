using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            Echo e1 = new Echo();
            Echo e2 = new Echo();
            int x = 0;
            while (x < 4)
            {
                result = result + e1.Hello() + "\n";
                e1.Count = e1.Count + 1;
                if (x == 3)
                {
                    e2.Count = e2.Count + 1;
                }
                if (x > 0)
                {
                    e2.Count = e2.Count + e1.Count;
                }
                x = x + 1;
            }
            MessageBox.Show(result + "Count: " + e2.Count);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = "";

            int[] index = new int[4];
            index[0] = 1;
            index[1] = 3;
            index[2] = 0;
            index[3] = 2;

            string[] islands = new string[4];
            islands[0] = "Bermuda";
            islands[1] = "Fiji";
            islands[2] = "Azores";
            islands[3] = "Cozumel";

            int y = 0;
            int refNum;
            while (y < 4)
            {
                refNum = index[y];
                result += "\nisland = ";
                result += islands[refNum];
                y = y + 1;
            }
            MessageBox.Show(result);
        }
    }
}
