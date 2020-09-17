using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPPO_01_CSharp
{
    public partial class Form1 : Form
    {
        static string text;
        static List<string> listNumbers = new List<string>();
        string[] arraySeparators;

        public Form1()
        {
            InitializeComponent();
        }

        private void fileSeparatorClick(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            arraySeparators = System.IO.File.ReadAllText(@filePath).Split('\n');
            LB_Separator.Items.AddRange(arraySeparators);
        }

        private void fileSTextClick(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            text = System.IO.File.ReadAllText(@filePath);
            RTB_Text.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] textSeparator = text.Split(arraySeparators, System.StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in textSeparator)
            {
                int res;
                if (Int32.TryParse(s, out res))
                {
                    listNumbers.Add(s);
                }
            }

            /*LB_Number.Items.AddRange(listNumbers.ToArray());
            LB_Number.Items.Add("ListNumbers = " + listNumbers.Count);
            LB_Number.Items.Add("textSeparator = " + textSeparator.Length);
            LB_Number.Items.AddRange(textSeparator);*/

        }

    }

}
