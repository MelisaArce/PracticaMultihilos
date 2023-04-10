using NameGenerator.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Multihilos
{
    public partial class Form1 : Form
    {
        private static Random n = new Random();

        private static int num1 = n.Next(10,28);
        private static int num2 = n.Next(10,28);

        private int cantCli1 = 0;
        private int cantCli2 = 0;

        private string[] cli_uno_nombres = new string[num1];
        private string[] cli_dos_nombres = new string[num2];

        private int contadorAtendidos;

        RealNameGenerator nombres = new RealNameGenerator();
         
        public Form1()
        {
            InitializeComponent();

            for(int i= 0; i < cli_uno_nombres.Length ; i++)
            {                
                cli_uno_nombres[i] = nombres.Generate();
                cantCli1++;
            }

            for(int i = 0; i < cli_dos_nombres.Length ; i++)
            {
                cli_dos_nombres[i] = nombres.Generate();
                cantCli2++;
            }

            for (int i = 0; i < 6; i++)
            {
                if (i == 0)
                {
                    lblCli11.Text = cli_uno_nombres[i];
                    lblCli21.Text = cli_dos_nombres[i];
                }
                if (i == 1)
                {
                    lblCli12.Text = cli_uno_nombres[i];
                    lblCli22.Text = cli_dos_nombres[i];
                }
                if (i == 2)
                {
                    lblCli13.Text = cli_uno_nombres[i];
                    lblCli23.Text = cli_dos_nombres[i];
                }
                if (i == 3)
                {
                    lblCli14.Text = cli_uno_nombres[i];
                    lblCli24.Text = cli_dos_nombres[i];
                }
                if (i == 4)
                {
                    lblCli15.Text = cli_uno_nombres[i];
                    lblCli25.Text = cli_dos_nombres[i];
                }
                if (i == 5)
                {
                    lblCli16.Text = cli_uno_nombres[i];
                    lblCli26.Text = cli_dos_nombres[i];
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Thread caja1 = new Thread(new ThreadStart(primer_cajero));
                Thread caja2 = new Thread(new ThreadStart(segundo_cajero));
                
                caja1.Start();
                caja2.Start();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error.");
            }

        }
        public void primer_cajero()
        {
            try
            {
                btnComenzar.Invoke((MethodInvoker)delegate { btnComenzar.Visible = false; });

                lblCliEsp1.Invoke((MethodInvoker)delegate { lblCliEsp1.Text = Convert.ToString(cantCli1); });

                for(int i = 0;i<cli_uno_nombres.Length;i++)
                {
                    if (i == 0 || i == 5 || i == 11 || i == 17)
                    {
                        lblAtendidoCajaUno.Invoke((MethodInvoker)delegate { lblAtendidoCajaUno.Text = cli_uno_nombres[i]; });
                        lblCli11.Invoke((MethodInvoker)delegate { lblCli11.Text = cli_uno_nombres[i+1]; });
                        contadorAtendidos++;
                        lblCliAtendidos.Invoke((MethodInvoker)delegate { lblCliAtendidos.Text = Convert.ToString(contadorAtendidos); });
                        cantCli1--;
                        lblCliEsp1.Invoke((MethodInvoker)delegate { lblCliEsp1.Text = Convert.ToString(cantCli1); });
                        Thread.Sleep(1000);
                    }

                    if (i == 1 || i == 6 || i == 12 || i == 18)
                    {
                        lblAtendidoCajaUno.Invoke((MethodInvoker)delegate { lblAtendidoCajaUno.Text = cli_uno_nombres[i]; });
                        lblCli12.Invoke((MethodInvoker)delegate { lblCli12.Text = cli_uno_nombres[i + 1]; });
                        contadorAtendidos++;
                        lblCliAtendidos.Invoke((MethodInvoker)delegate { lblCliAtendidos.Text = Convert.ToString(contadorAtendidos); });
                        cantCli1--;
                        lblCliEsp1.Invoke((MethodInvoker)delegate { lblCliEsp1.Text = Convert.ToString(cantCli1); });
                        Thread.Sleep(1000);
                    }

                    if (i == 2 || i == 7 || i == 13 || i == 19)
                    {
                        lblAtendidoCajaUno.Invoke((MethodInvoker)delegate { lblAtendidoCajaUno.Text = cli_uno_nombres[i]; });
                        lblCli13.Invoke((MethodInvoker)delegate { lblCli13.Text = cli_uno_nombres[i + 1]; });
                        contadorAtendidos++;
                        lblCliAtendidos.Invoke((MethodInvoker)delegate { lblCliAtendidos.Text = Convert.ToString(contadorAtendidos); });
                        cantCli1--;
                        lblCliEsp1.Invoke((MethodInvoker)delegate { lblCliEsp1.Text = Convert.ToString(cantCli1); });
                        Thread.Sleep(1000);
                    }

                    if (i == 3 || i == 8 || i == 14 || i == 20)
                    {
                        lblAtendidoCajaUno.Invoke((MethodInvoker)delegate { lblAtendidoCajaUno.Text = cli_uno_nombres[i]; });
                        lblCli14.Invoke((MethodInvoker)delegate { lblCli14.Text = cli_uno_nombres[i + 1]; });
                        contadorAtendidos++;
                        lblCliAtendidos.Invoke((MethodInvoker)delegate { lblCliAtendidos.Text = Convert.ToString(contadorAtendidos); });
                        cantCli1--;
                        lblCliEsp1.Invoke((MethodInvoker)delegate { lblCliEsp1.Text = Convert.ToString(cantCli1); });
                        Thread.Sleep(1000);
                    }

                    if (i == 4 || i == 9 || i == 15 || i == 21)
                    {
                        lblAtendidoCajaUno.Invoke((MethodInvoker)delegate { lblAtendidoCajaUno.Text = cli_uno_nombres[i]; });
                        lblCli15.Invoke((MethodInvoker)delegate { lblCli15.Text = cli_uno_nombres[i + 1]; });
                        contadorAtendidos++;
                        lblCliAtendidos.Invoke((MethodInvoker)delegate { lblCliAtendidos.Text = Convert.ToString(contadorAtendidos); });
                        cantCli1--;
                        lblCliEsp1.Invoke((MethodInvoker)delegate { lblCliEsp1.Text = Convert.ToString(cantCli1); });
                        Thread.Sleep(1000);
                    }

                    if (i == 5 || i == 10 || i == 16 || i == 22)
                    {
                        lblAtendidoCajaUno.Invoke((MethodInvoker)delegate { lblAtendidoCajaUno.Text = cli_uno_nombres[i]; });
                        lblCli16.Invoke((MethodInvoker)delegate { lblCli16.Text = cli_uno_nombres[i + 1]; });
                        contadorAtendidos++;
                        lblCliAtendidos.Invoke((MethodInvoker)delegate { lblCliAtendidos.Text = Convert.ToString(contadorAtendidos); });
                        cantCli1--;
                        lblCliEsp1.Invoke((MethodInvoker)delegate { lblCliEsp1.Text = Convert.ToString(cantCli1); });
                    }

                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }

        }

        public void segundo_cajero()
        {
            try
            {
                btnComenzar.Invoke((MethodInvoker)delegate { btnComenzar.Visible = false; });

                lblCliEsp2.Invoke((MethodInvoker)delegate { lblCliEsp2.Text = Convert.ToString(cantCli2); });

                

                Thread.Sleep(300);
                lblAtendidoCajaDos.Invoke((MethodInvoker)delegate { lblAtendidoCajaDos.Text = lblCli21.Text; });
                lblCli21.Invoke((MethodInvoker)delegate { lblCli21.Text = ""; });
                contadorAtendidos++;
                lblCliAtendidos.Invoke((MethodInvoker)delegate { lblCliAtendidos.Text = Convert.ToString(contadorAtendidos); });
                cantCli2--;
                lblCliEsp2.Invoke((MethodInvoker)delegate { lblCliEsp2.Text = Convert.ToString(cantCli2); });
                Thread.Sleep(1500);

                lblAtendidoCajaDos.Invoke((MethodInvoker)delegate { lblAtendidoCajaDos.Text = lblCli22.Text; });
                lblCli22.Invoke((MethodInvoker)delegate { lblCli22.Text = ""; });
                contadorAtendidos++;
                lblCliAtendidos.Invoke((MethodInvoker)delegate { lblCliAtendidos.Text = Convert.ToString(contadorAtendidos); });
                cantCli2--;
                lblCliEsp2.Invoke((MethodInvoker)delegate { lblCliEsp2.Text = Convert.ToString(cantCli2); });
                Thread.Sleep(1500);

                lblAtendidoCajaDos.Invoke((MethodInvoker)delegate { lblAtendidoCajaDos.Text = lblCli23.Text; });
                lblCli23.Invoke((MethodInvoker)delegate { lblCli23.Text = ""; });
                contadorAtendidos++;
                lblCliAtendidos.Invoke((MethodInvoker)delegate { lblCliAtendidos.Text = Convert.ToString(contadorAtendidos); });
                cantCli2--;
                lblCliEsp2.Invoke((MethodInvoker)delegate { lblCliEsp2.Text = Convert.ToString(cantCli2); });
                Thread.Sleep(1500);

                lblAtendidoCajaDos.Invoke((MethodInvoker)delegate { lblAtendidoCajaDos.Text = lblCli24.Text; });
                lblCli24.Invoke((MethodInvoker)delegate { lblCli24.Text = ""; });
                contadorAtendidos++;
                lblCliAtendidos.Invoke((MethodInvoker)delegate { lblCliAtendidos.Text = Convert.ToString(contadorAtendidos); });
                cantCli2--;
                lblCliEsp2.Invoke((MethodInvoker)delegate { lblCliEsp2.Text = Convert.ToString(cantCli2); });
                Thread.Sleep(1500);

                lblAtendidoCajaDos.Invoke((MethodInvoker)delegate { lblAtendidoCajaDos.Text = lblCli25.Text; });
                lblCli25.Invoke((MethodInvoker)delegate { lblCli25.Text = ""; });
                contadorAtendidos++;
                lblCliAtendidos.Invoke((MethodInvoker)delegate { lblCliAtendidos.Text = Convert.ToString(contadorAtendidos); });
                cantCli2--;
                lblCliEsp2.Invoke((MethodInvoker)delegate { lblCliEsp2.Text = Convert.ToString(cantCli2); });
                Thread.Sleep(1500);

                lblAtendidoCajaDos.Invoke((MethodInvoker)delegate { lblAtendidoCajaDos.Text = lblCli26.Text; });
                lblCli26.Invoke((MethodInvoker)delegate { lblCli26.Text = ""; });
                contadorAtendidos++;
                lblCliAtendidos.Invoke((MethodInvoker)delegate { lblCliAtendidos.Text = Convert.ToString(contadorAtendidos); });
                cantCli2--;
                lblCliEsp2.Invoke((MethodInvoker)delegate { lblCliEsp2.Text = Convert.ToString(cantCli2); });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error con los hilos.");
            }

        }

    }
}
