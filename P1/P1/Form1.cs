using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace P1
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e) {
            TextWriter txt = new StreamWriter("C:\\Users\\charles.sharpe\\OneDrive - Global Graphics PLC\\Documents\\CS\\CRC\\P1\\demo.txt");
            txt.Write(textBox1.Text);
            txt.Close();

            // MessageBox.Show("Thanks!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            TextReader tr = new StreamReader("C:\\Users\\charles.sharpe\\OneDrive - Global Graphics PLC\\Documents\\CS\\CRC\\P1\\demo.txt");

        }

        private void button2_Click(object sender, EventArgs e) {
            using (StreamReader streamReader = new StreamReader(@"C:\\Users\\charles.sharpe\\OneDrive - Global Graphics PLC\\Documents\\CS\\CRC\\P1\\demo.txt")) {
                string line = string.Empty;
                while ((line = streamReader.ReadLine()) != null) {
                    string[] tempArray = line.Split(' ');
                //    textBox1.Text = tempArray[0];
                    textBox2.Text = tempArray[1];
               //     textBox3.Text = tempArray[2];
                }
            }
        }
    }
}
