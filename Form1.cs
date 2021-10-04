using System;  
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeAssesmentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            String username = textBox1.Text + " " + textBox2.Text;
            //function here that reverses string
            ReversedName.Text = NameReverse(username);
            CharacterCount.Text = username.Length.ToString();
        }

        private string NameReverse(string name)
        {
            char[] charArray = name.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}


