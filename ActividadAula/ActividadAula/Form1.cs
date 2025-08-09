using ActividadAula.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadAula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerarJson_Click(object sender, EventArgs e)
        {
            Ortoedro objetoOrtoedro = new Ortoedro(7, 7, 21);

            txtListar.Text += $@"
            [ 
                {objetoOrtoedro.Describir()},
            ]";

        }
    }
}
