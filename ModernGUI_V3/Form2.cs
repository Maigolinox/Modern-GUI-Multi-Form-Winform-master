﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernGUI_V3
{
    public partial class Form2 : Form
    {
        int bandera = 0, time = 0;
        string lectura;
        public Form2()
        {
            InitializeComponent();
            button3.Enabled = false;
            button2.Enabled = true;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
    }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            try { serialPort1.Open(); } catch (Exception msg) { MessageBox.Show(msg.ToString()); }

            bandera = 1;
            button3.Enabled = true;
            button2.Enabled = false;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            label2.Text = "Estado: "+Convert.ToString(bandera);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bandera = 0;
            button2.Enabled = true;
            button3.Enabled = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            serialPort1.Write("2");
            serialPort1.Write("4");
            serialPort1.Write("6");
            serialPort1.Write("8");
            label2.Text = "Estado: " + Convert.ToString(bandera);



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (bandera == 1)
            {
                if (checkBox1.Checked == true)
                {
                    serialPort1.Write("1");//AL ENCENDER SE ENVIA UN 1
                }
                else
                {
                    serialPort1.Write("2");//AL APAGAR SE ENVIA UN 2
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (bandera == 1)
            {
                if (checkBox3.Checked == true)
                {
                    serialPort1.Write("5");//AL ENCENDER SE ENVIA UN 1
                }
                else
                {
                    serialPort1.Write("6");//AL APAGAR SE ENVIA UN 2
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (bandera == 1)
            {
                if (checkBox2.Checked == true)
                {
                    serialPort1.Write("3");//AL ENCENDER SE ENVIA UN 1
                }
                else
                {
                    serialPort1.Write("4");//AL APAGAR SE ENVIA UN 2
                }
            }



        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (bandera == 1)
            {
                if (checkBox3.Checked == true)
                {
                    serialPort1.Write("7");//AL ENCENDER SE ENVIA UN 1
                }
                else
                {
                    serialPort1.Write("8");//AL APAGAR SE ENVIA UN 2
                }
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (bandera==1)
            {
                lectura = serialPort1.ReadLine();
                //Invoke(new EventHandler());
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bandera == 1)
            {
                //serialPort1.Write("9");
                time++;
                if (time == 100)
                {
                    time = 0;
                }
            }
            if (bandera==0)
            {
                //serialPort1.
                
            }
        }


    }
}
