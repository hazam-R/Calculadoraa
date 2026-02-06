using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadoraa.Formularios
{
    public partial class frmBurbuja : Form
    {
        public frmBurbuja()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int[] ordenado = new int[dgvDesordenado.RowCount-1];
            for (int i = 0; i < ordenado.Length; i++)
            {
                ordenado[i]= Convert.ToInt32(dgvOrdenado.Rows[i].Cells[0].Value);
            }
        }
    }
}
