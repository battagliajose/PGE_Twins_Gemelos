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
    public partial class frmGemelosPorFecha : Form
    {
        Actividades_Codigos actividadesCodigos = new Actividades_Codigos();
        List<CodBar> listaCodbar = new List<CodBar>();

        public frmGemelosPorFecha()
        {
            InitializeComponent();
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            string fecha = dateTimePicker1.Value.Year.ToString() + dateTimePicker1.Value.Month.ToString("00") + dateTimePicker1.Value.Day.ToString("00");
            listaCodbar = actividadesCodigos.getCodBarList(fecha);

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

        private void btnFindRepeated_Click(object sender, EventArgs e)
        {
            List<CodBar> repeatedCodes = actividadesCodigos.searchRepeatedCodBars(listaCodbar);

            //This will create a custom datasource for the DataGridView.
            var transactionsDataSource = repeatedCodes.Select(x => new
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

        private void dgvCodbars_DataSourceChanged(object sender, EventArgs e)
        {
            lblStatus.Text = dgvCodbars.RowCount.ToString();
        }
    }
}
