using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAB_Verificador_Codigos_Gemelos_Twins
{
    internal class Actividades_Codigos
    {
        Datos_Codigos datosCodigos = new Datos_Codigos();

        internal List<CodBar> getCodBarList(string fecha)
        {
            return datosCodigos.getCodBarList(fecha);
        }

        internal List<CodBar> searchRepeatedCodBars(List<CodBar> list)
        {
            List<CodBar> repeatedCodbars = new List<CodBar>();
            for (int i = 0; i < list.Count-1; i++)
            {
                if (list[i].peso == list[i + 1].peso 
                    && list[i].codProducto != "3000" 
                    && list[i].estado != "S" 
                    && list[i].estado != "101"
                    && list[i].estado != "102"
                    && list[i+1].estado != "S" 
                    && list[i+1].estado != "101"
                    && list[i+1].estado != "102") 
                {
                    repeatedCodbars.Add(list[i]);
                    repeatedCodbars.Add(list[i+1]);
                }
            }
            return repeatedCodbars;
        }

        internal List<CodBar> getCodBarSandwich(long suspected_CodBar)
        {
            return datosCodigos.getCodBarSandwich(suspected_CodBar);
        }

        internal List<string> CargarCodigosDesdeTxt(OpenFileDialog ofd)
        {
            List<string> codigos = new List<string>();

            foreach (string linea in File.ReadAllLines(ofd.FileName))
            {
                string cod = linea.Trim();

                if (!string.IsNullOrEmpty(cod))
                    codigos.Add(cod);
            }

            return codigos;
        }

       internal List<CodBar> getCodbarsGemelos(List<string> codigos)
       {
            List<CodBar> codBarsAux;
            List<CodBar> codbarsGemelos = new List<CodBar>();

            foreach (string codigo in codigos)
            {
                codBarsAux = getCodBarSandwich(Convert.ToInt64(codigo));

                if (codBarsAux[1].peso == codBarsAux[0].peso
                    && codBarsAux[0].codProducto != "3000"
                    && codBarsAux[0].estado != "S"
                    && codBarsAux[0].estado != "101"
                    && codBarsAux[0].estado != "102")
                    {
                        codbarsGemelos.Add(codBarsAux[0]);
                    }

                if (codBarsAux[1].peso == codBarsAux[2].peso
                        && codBarsAux[2].codProducto != "3000"
                        && codBarsAux[2].estado != "S"
                        && codBarsAux[2].estado != "101"
                        && codBarsAux[2].estado != "102")
                    {
                    codbarsGemelos.Add(codBarsAux[2]);
                }
            }

            return codbarsGemelos;
       }
    }
}
