using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoMantenimineto_comisiones
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Cliente_agregar ca = new Cliente_agregar();
            ca.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente_actualizar ca = new Cliente_actualizar();
            ca.Show();
        }
    }
}
