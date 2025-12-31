using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAB_Verificador_Codigos_Gemelos_Twins
{
    public partial class frmSelector : Form
    {
        public frmSelector()
        {
            InitializeComponent();
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            using (frmGemelosPorFecha frm = new frmGemelosPorFecha())
            {
                frm.ShowDialog();
            }
        }

        private void btnCodbarList_Click(object sender, EventArgs e)
        {
            using (frmGemelosPorLista frm = new frmGemelosPorLista())
            {
                frm.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show(
                    "¿Desea salir de la aplicación?",
                    "Confirmar salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
);

            if (r == DialogResult.Yes)
                Application.Exit();
        }
    }
}
