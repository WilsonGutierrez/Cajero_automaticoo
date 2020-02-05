﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajeroo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            double[] denominaciones = {100,50,20,10,5,1,0.50,0.25,0.10,0.05,0.01 };
            double cantidad = double.Parse(txtCantidad.Text);
            sbyte n = 0;
            String respuesta = "Respuesta: \n";
            foreach(double denominacion in denominaciones) {
               while (denominacion <=Math.Round (cantidad,2)) {
                    n++;
                    cantidad -= denominacion;

                }
                if (n > 0) {
                    respuesta += n + (denominacion > 1 ? " billetes " : " Monedas ")+ denominacion+"\n";
                }
                n = 0;
            }
            lblRespuesta.Text = respuesta;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.50, 0.25, 0.10, 0.05, 0.01 };
            double cantidad = double.Parse(txtCantidadd.Text);
            double cm = double.Parse(txtEfectivo.Text);
            sbyte n = 0;
            double cm2;
            cm2 = cm - cantidad;
            String cambio= "Su cambio es de: \n ";
            foreach(double denominacion in denominaciones)
            {
                while (denominacion <= Math.Round(cm2, 2))
                {
                    n++;
                    cm2 -= denominacion;

                }
                if (n > 0)
                {
                    cambio += n + (denominacion > 1 ? " billetes " : " Monedas ") + denominacion + "\n";
                }
                n = 0;
            }
            lblCambio.Text = cambio;
        }
        }
    }

