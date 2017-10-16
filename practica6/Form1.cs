using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace practica6
{
    public partial class Form1 : Form
    {
         private MessageBoxButtons mbbBotones;
         private MessageBoxIcon mbIcon;
        public Form1()
        {
            InitializeComponent();
        }
        private void rbBotones(object sender, EventArgs e)
        {
            if (sender == radioButton1)
                mbbBotones = MessageBoxButtons.OK;
            else if
                (sender == radioButton2)
                mbbBotones = MessageBoxButtons.OKCancel;
            else if
           (sender == radioButton3)
                mbbBotones = MessageBoxButtons.RetryCancel;
            else if
           (sender == radioButton4)
                mbbBotones = MessageBoxButtons.YesNo;
            else if
                (sender == radioButton5)
                mbbBotones = MessageBoxButtons.YesNoCancel;




        }

        private void rbIcons(object sender, EventArgs e)
        {
            if (sender ==radioButton6)
                mbIcon = MessageBoxIcon.Error;
            else if
                   (sender == radioButton7)
                mbIcon = MessageBoxIcon.Information;
            else if
           (sender == radioButton8)
                mbIcon = MessageBoxIcon.None;
            else if
           (sender == radioButton9)
                mbIcon = MessageBoxIcon.Question;
            else if
                (sender == radioButton10)
                mbIcon = MessageBoxIcon.Warning;
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text,textBox2.Text,mbbBotones,mbIcon);
        }
    }
}