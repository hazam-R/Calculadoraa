using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Calculadoraa.Formularios
{
    public partial class frmXMLAcces : Form
    {

        
        public frmXMLAcces()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            XElement xml = new XElement("Directorio");

              
                for (int i=0; i<dgvPersonas.Rows.Count;i++)
                {
                    xml.Add(
                        new XElement("Personas",
                            new XAttribute("Id", dgvPersonas.Rows[i].Cells[0].Value),
                                new XElement("Nombre", dgvPersonas.Rows[i].Cells[1]),
                                new XElement("Telefono", dgvPersonas.Rows[i].Cells[2].Value)));
                }
            try
            {


                xml.Save("Archivo.xml");
                MessageBox.Show("Guardo", "Sistema ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
