using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);
            string txt, sensor;
            text(out txt, out sensor);
            string NivelTanque = text2();
            char b;
            string cadena1;
            cadena1 = Convert.ToString(num, 2);
            string refi = cadena1;
            int tamaño = cadena1.Length;
            int contador = 0;
            for (int i = tamaño; i <= 7; i++)
            {
                contador++;
                txt += "0";
            }
            txt += refi;
            lbl3.Text = txt;
            for (int j = 0; j <= 7; j++)
            {
                b = txt[j];
                if (j == 2 || j == 3)
                {
                    sensor += txt[j];
                }
                else
                {
                    if (j >= 4 && j < 7)
                    {
                        NivelTanque += txt[j];
                    }
                    if (j == 0)
                    {
                        if (b == '1')
                        {
                            lbl7.Text += "Encendido";
                        }
                        else
                        {
                            if (b == '0')
                            {
                                lbl7.Text += "Apagado";
                            }

                        }
                    }
                    if (j == 1)
                    {
                        if (b == '1')
                        {
                            lbl6.Text += "Encendido";
                        }
                        else
                        {
                            if (b == '0')
                            {
                                lbl6.Text += "Apagado";
                            }

                        }

                    }

                    switch (sensor)
                    {
                        case "00":
                            lblNivel.Text = "Vacio";
                            break;
                        case "01":
                            lblNivel.Text = "Medio";
                            break;
                        case "10":
                            lblNivel.Text = "lleno";
                            break;
                        case "11":
                            lblNivel.Text = "En proceso de llenado";
                            break;
                    }

                    switch (NivelTanque)
                    {
                        case "000":
                            lblDirec.Text = "N";
                            break;
                        case "001":
                            lblDirec.Text = "NE";
                            break;
                        case "010":
                            lblDirec.Text = "E";
                            break;
                        case "011":
                            lblDirec.Text = "SE";
                            break;
                        case "100":
                            lblDirec.Text = "S";
                            break;
                        case "101":
                            lblDirec.Text = "SO";
                            break;
                        case "110":
                            lblDirec.Text = "O";
                            break;
                        default:
                            if (NivelTanque == "111")
                            {
                                lblDirec.Text = "NO";
                            }

                            break;
                    }
                }

            }

        }

        private static string text2()
        {
            return "";
        }

        private static void text(out string txt, out string sensor)
        {
            txt = "";
            sensor = "";
        }
    }
}

