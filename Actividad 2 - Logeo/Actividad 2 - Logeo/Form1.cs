﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_2___Logeo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Textabc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string contre;
            string nombre;
            nombre = textUsuario.Text;
            contre = textabc.Text;
            if(nombre == "juancho"&&contre=="123frijoles")
            {
                MessageBox.Show("Su sesion de minecreft es correcta");
            }
            else 
            {
                MessageBox.Show("Su sesion de minecreft es incorrecta");
            }

        }

      
       
    }
}
