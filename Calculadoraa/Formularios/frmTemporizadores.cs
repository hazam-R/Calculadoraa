using CSCore.SoundOut;
using Microsoft.VisualBasic; //para usar el input box
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Calculadoraa.Formularios
{
    public partial class frmTemporizadores : Form
    {
        String alarma1 = null;
        public frmTemporizadores()
        {
            InitializeComponent();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            if (lblHora.Text == alarma1)
            {
                SoundPlayer player = new SoundPlayer(@"C:\Users\emili\source\repos\Calculadoraa\Calculadoraa\Sonidos");
                player.Play();
                
            }
        }

        private void alarma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarma1 = Interaction.InputBox("Ingrese la Hora: ", "Sistema", "00:00:00 x.x");

        }
    }
}
