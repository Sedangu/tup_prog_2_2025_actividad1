using Ejercicio1_solo.Models.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_solo
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Btn_ConsDescObj_Click(object sender, EventArgs e)
        {
            //construyendo los objetos

            //Cilindro objeto1 = new Cilindro(3, 3);
            //Cubo objeto2 = new Cubo(3);
            Ortoedro objeto3 = new Ortoedro(7, 7, 21);
            //Cilindro objeto4 = new Cilindro(9, 13);
            //Cubo objeto5 = new Cubo(7);
            //Cilindro objeto6 = new Cilindro(13, 23);

            //llamando al mensaje común de todos los objetos figura
            Tbx_Descripcion.Text += $@"[ 
  
  {objeto3.Describir()},]";
  
        }
    }
}
