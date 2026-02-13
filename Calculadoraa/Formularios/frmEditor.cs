using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Calculadoraa.Formularios
{

    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }
        bool saved = false;
        string path = "";
        int contadorPalabras = 0;
        string texto = "";
        int contadorLetras = 0;

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opdEditor.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(opdEditor.FileName))
                {
                    rtbEditor.Text = File.ReadAllText(opdEditor.FileName);
                }

            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                Guardar();
                saved = true;
            }
            else
            {
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }

        private void guardarCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
            path = "";
            saved = false;
        }
        private void Guardar()
        {
            if (sfdEditor.ShowDialog() == DialogResult.OK)
            {
                path = sfdEditor.FileName;
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tssStatuss_Click(object sender, EventArgs e)

        {
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            string[] parrafos = texto.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            MessageBox.Show("Estadisticas: \n\n Palabras: " + palabras.Length.ToString() + "\nLetras: " + texto.Length.ToString() + "\n Parrafos: " + parrafos.Length.ToString(), "Contador de Palabras");

        }

        private void rtbEditor_TextChanged(object sender, EventArgs e)
        {
            texto = rtbEditor.Text;
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            contadorLetras = texto.Length;
            contadorPalabras = palabras.Length;

            // tssStatuss.Text = $"{palabras.Length} Palabras"; Otra opcion que convierte a cadena automaticamente
            tssStatuss.Text = palabras.Length.ToString() + "  Palabras";
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ftdEditor.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.Font = ftdEditor.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cldEditor.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.ForeColor = cldEditor.Color;
            }
        }
    }
}
