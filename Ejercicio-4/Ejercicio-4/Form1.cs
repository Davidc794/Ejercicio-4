using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        ArrayList Nombre;
        ArrayList Edad;
        public Form1()
        {
            InitializeComponent();
            Nombre = new ArrayList();
            Edad = new ArrayList();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {

            int i;
            for (i = 0; i < Nombre.Count; i++)
            {
                comboBox1.Items.Add(Nombre[i]);
            }
            int y;
            for (y = 0; y < Edad.Count; y++)
            {
                comboBox1.Items.Add(Edad[y]);
            }
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            Nombre.Add(NombretextBox.Text.ToString());
            Edad.Add(EdadtextBox.Text.ToString());
        }

        private void Ordenarbutton_Click(object sender, EventArgs e)
        {

            int i;
            for (i = 0; i < Nombre.Count; i++)
            {
                OrdenarLixbox.Items.Add(Nombre[i]);
            }
            int y;
            for (y = 0; y < Edad.Count; y++)
            {
                OrdenarLixbox.Items.Add(Edad[y]);
            }

        }
        
          
       
}
        
    }

