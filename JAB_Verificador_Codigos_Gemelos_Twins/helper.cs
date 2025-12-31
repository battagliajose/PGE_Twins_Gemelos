using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAB_Verificador_Codigos_Gemelos_Twins
{
    internal static class helper
    {
    public static void ExportarDataGridViewACsv(DataGridView dgv)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Archivo Excel (*.csv)|*.csv",
                FileName = "exportacion.csv"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            StringBuilder sb = new StringBuilder();

            // Encabezados
            /*for (int i = 0; i < dgv.Columns.Count; i++)
            {
                sb.Append(dgv.Columns[i].HeaderText);
                if (i < dgv.Columns.Count - 1)
                    sb.Append(",");
            }
            sb.AppendLine();*/

            // Filas
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    var value = row.Cells[i].Value?.ToString()?.Replace(",", " ");
                    sb.Append(value);
                    if (i < dgv.Columns.Count - 1)
                        sb.Append(",");
                }
                sb.AppendLine();
            }

            File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

            MessageBox.Show("Archivo exportado correctamente.", "Exportación",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
