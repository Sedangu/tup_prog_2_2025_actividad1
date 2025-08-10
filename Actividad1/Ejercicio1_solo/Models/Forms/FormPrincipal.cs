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
            Ortoedro objeto3 = new Ortoedro(7, 7, 21);
            
            Tbx_Descripcion.Text += $@"[ 
  
  {objeto3.Describir()},]";
  
        }
    }
}
