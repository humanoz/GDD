﻿using System;
using System.Drawing;
using System.Windows.Forms;
using newGDD.Controlador;
using newGDD.Vista.Personaje;

namespace newGDD.Vista.Componentes
{
    public partial class ItemDocumento : UserControl
    {
        DocumentoDeJuego documento;
        public ItemDocumento()
        {
            InitializeComponent();
        }

        public ItemDocumento(string nc, string fc, string nd, string imagen)
        {
            InitializeComponent();
            //lblCreadores.Text = nc;
            //lblFechaCreacion.Text = fc;
            lblNombreDoc.Text = nd;
            //imgDoc.Image = Image.FromFile(@imagen);
        }

        private void btnFichaTecnica_Click(object sender, System.EventArgs e)
        {

        }

        private void btnPersonajes_Click(object sender, System.EventArgs e)
        {
            VPersonaje personajeVista = new VPersonaje(this.documento);
            personajeVista.Show();
            personajeVista.FormClosed += new FormClosedEventHandler(ejemplo);
        }

        private void ejemplo(object sender, EventArgs e)
        {
            MessageBox.Show(sender.GetType().ToString());
        }
    }
}