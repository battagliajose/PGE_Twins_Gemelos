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
    public partial class frmGemelosPorLista : Form
    {
        Actividades_Codigos actividadesCodigos = new Actividades_Codigos();
        List<String>CodigosTXT = new List<String>();
        List<CodBar> listaCodbar = new List<CodBar>();

        public frmGemelosPorLista()
        {
            InitializeComponent();
        }

        private void btnGetSand_Click(object sender, EventArgs e)
        {
            listaCodbar = actividadesCodigos.getCodBarSandwich(Convert.ToInt64(txtGetSand.Text));

            //This will create a custom datasource for the DataGridView.
            var transactionsDataSource = listaCodbar.Select(x => new
            {
                CodBar = x.codBarras,
                Producto = x.codProducto,
                Descripcion = x.descripcion,
                Peso = x.peso,
                Lote = x.lote,
                Fecha = x.fecha,
                Hora = x.hora,
                Estado = x.estado,
                Usuario = x.usuario
            }).ToList();

            //This will assign the datasource. All the columns you listed will show up, and every row
            //of data in the list will populate into the DataGridView.
            dgvCodbars.DataSource = transactionsDataSource;
        }

        private void btnCargarTXT_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Seleccionar archivo de códigos",
                Filter = "Archivos de texto (*.txt)|*.txt",
                Multiselect = false
            };

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            CodigosTXT = actividadesCodigos.CargarCodigosDesdeTxt(ofd);
            MessageBox.Show($"Se han cargado {CodigosTXT.Count} códigos desde el archivo.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaCodbar = actividadesCodigos.getCodbarsGemelos(CodigosTXT);

            //This will create a custom datasource for the DataGridView.
            var transactionsDataSource = listaCodbar.Select(x => new
            {
                CodBar = x.codBarras,
                Producto = x.codProducto,
                Grupo = x.grupo,
                Descripcion = x.descripcion,
                Cantidad = x.cantidad,
                Unidad = 1,
                Peso = x.peso,
                Lote = x.lote,
                FechaFaena = x.fechaFaena,
                FechaProduccion = x.fechaProduccion,
                Estado = "Presunto Duplicado"
                //Estado = x.estado,
                //Usuario = x.usuario
            }).ToList();

            //This will assign the datasource. All the columns you listed will show up, and every row
            //of data in the list will populate into the DataGridView.
            dgvCodbars.DataSource = transactionsDataSource;
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            helper.ExportarDataGridViewACsv(dgvCodbars);
        }
    }
}
