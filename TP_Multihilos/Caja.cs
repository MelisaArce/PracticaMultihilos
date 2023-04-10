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
    public partial class Caja : Form
    {
        private static Random n = new Random();

        private static int num1 = n.Next(10,28);
        private static int num2 = n.Next(10,28);

        private int cantCli1 = 0;
        private int cantCli2 = 0;

        private int cantItemsUno;
        private int cantItemsDos;

        private string[] cli_uno_nombres = new string[num1];
        private string[] cli_dos_nombres = new string[num2];

        private int contadorAtendidos;

        RealNameGenerator nombres = new RealNameGenerator();
         
        public Caja()
        {
            InitializeComponent();

            string nombreCli1;
            string nombreCli2;

            for(int i= 0; i < cli_uno_nombres.Length ; i++)
            {
                nombreCli1 = nombres.Generate();
                lbClientesUno.Items.Add(nombreCli1);
                cantCli1++;
            }

            for(int i = 0; i < cli_dos_nombres.Length ; i++)
            {
                nombreCli2 = nombres.Generate();
                lbClientesDos.Items.Add(nombreCli2);
                cantCli2++;
            }

            lblCliEsp1.Text = Convert.ToString(cantCli1);
            lblCliEsp2.Text = Convert.ToString(cantCli2);

        }


        private void BtnComenzar_Click(object sender, EventArgs e)
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

                do
                {

                    if (lbClientesUno.Items.Count == 0)
                    {
                        lbClientesUno.Invoke((MethodInvoker)delegate
                        {
                            lblAtendidoCajaUno.Text = "TODOS ATENDIDOS";
                        });

                        break;
                    }

                    lbClientesUno.Invoke((MethodInvoker)delegate
                    {
                        cantItemsUno = lbClientesUno.Items.Count;
                        lblAtendidoCajaUno.Text = lbClientesUno.Items[0].ToString();
                        lbClientesUno.Items.RemoveAt(0);
                        contadorAtendidos++;

                    });

                    lblCliEsp1.Invoke((MethodInvoker)delegate
                    {
                        lblCliEsp1.Text = Convert.ToString(cantCli1-1);
                        cantCli1--;
                    });

                    lblCliAtendidos.Invoke((MethodInvoker)delegate
                    {
                        lblCliAtendidos.Text = Convert.ToString(contadorAtendidos);
                    });


                    Thread.Sleep(1500);

                } while (cantItemsUno != 0);

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
                do
                {

                    if (lbClientesDos.Items.Count == 0)
                    {
                        lbClientesDos.Invoke((MethodInvoker)delegate
                        {
                            lblAtendidoCajaDos.Text = "TODOS ATENDIDOS";
                        });

                        break;
                    }

                    lbClientesDos.Invoke((MethodInvoker)delegate
                    {
                        cantItemsDos = lbClientesDos.Items.Count;
                        lblAtendidoCajaDos.Text = lbClientesDos.Items[0].ToString();
                        lbClientesDos.Items.RemoveAt(0);
                        contadorAtendidos++;

                    });

                    lblCliEsp2.Invoke((MethodInvoker)delegate
                    {
                        lblCliEsp2.Text = Convert.ToString(cantCli2 - 1);
                        cantCli2--;
                    });

                    lblCliAtendidos.Invoke((MethodInvoker)delegate
                    {
                        lblCliAtendidos.Text = Convert.ToString(contadorAtendidos);
                    });


                    Thread.Sleep(1000);

                } while (cantItemsDos != 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error con los hilos.");
            }

        }

    }
}
