using ProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Clases
{
    public class ClsCita
    {
        MSOFTVETDataContext dc = new MSOFTVETDataContext();

        public List<V_CargarCitas> ObtenerTodasCitas()
        {
            return dc.V_CargarCitas.ToList();
        }

        public List<V_CargarCitas> ObtenerCitasPorFecha(DateTime fecha)
        {
            return dc.V_CargarCitas.Where(c => c.Fecha == fecha).OrderBy(c => c.Fecha).ThenBy(c => c.Hora).ToList();
        }

        public List<V_CargarCitas> ObtenerCitasPorEstado(string estado)
        {
            var citas = dc.V_CargarCitas.Where(c => c.Estado == estado);

            if (estado == "Pendiente")
            {
                citas = citas.OrderBy(c => c.Fecha).ThenBy(c => c.Hora);
            }
            else
            {
                citas = citas.OrderByDescending(c => c.Fecha).ThenByDescending(c => c.Hora);
            }
            return citas.ToList();
        }

        public void CancelarCita(int idCita)
        {
            dc.SP_CancelarCita(idCita);
        }

        public List<V_CargarCitas> Cargar()
        {
            return dc.V_CargarCitas
                     .Where(c => c.Estado == "Pendiente")
                     .OrderBy(c => c.Fecha)
                     .ThenBy(c => c.Hora)
                     .ToList();
        }
    }
}
