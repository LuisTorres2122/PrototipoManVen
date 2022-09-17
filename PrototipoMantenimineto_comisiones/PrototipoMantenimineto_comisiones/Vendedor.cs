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
    public partial class Vendedor : Form
    {
        public Vendedor()
        {
            InitializeComponent();
        }

        private void Dgv_vendedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Vendedores_agregar va = new Vendedores_agregar();
            va.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Vendedor_actualizar va = new Vendedor_actualizar();
                va.Show();
        }
    }
}
