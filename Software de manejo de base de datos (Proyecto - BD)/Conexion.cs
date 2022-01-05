﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    public partial class Conexion : Form
    {
        public Conexion()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Botones.cerrarAplicacion();
        }

        private void txt_NombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros_Entrada.soloNumeros(e);
        }

        private void txt_NombreUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txt_NombreUsuario.Text.Equals(""))
            {
                lb_Nombre_Usuario_Retro.Text = "Ingrese un nombre de usuario valido.";
                lb_Nombre_Usuario_Retro.ForeColor = Color.Black;
            }
            else
            {
                if (Filtros_Entrada.validarLongitudEntrada(txt_NombreUsuario.Text,8))
                {
                    lb_Nombre_Usuario_Retro.Text = "Nombre de usuario valido.";
                    lb_Nombre_Usuario_Retro.ForeColor = Color.Green;
                }
                else
                {
                    lb_Nombre_Usuario_Retro.Text = "Nombre de usuario invalido.";
                    lb_Nombre_Usuario_Retro.ForeColor = Color.Red;
                }
            }
        }

        private void txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros_Entrada.soloNumeros(e);
        }

        private void txt_Contraseña_TextChanged(object sender, EventArgs e)
        {
            if (txt_Contraseña.Text.Equals(""))
            {
                lb_Contraseña_Retro.Text = "Ingrese su contraseña.";
                lb_Contraseña_Retro.ForeColor = Color.Black;
            }
            else
            {
                lb_Contraseña_Retro.Text = "Contraseña aceptada.";
                lb_Contraseña_Retro.ForeColor = Color.Green;
            }
        }
    }
}
