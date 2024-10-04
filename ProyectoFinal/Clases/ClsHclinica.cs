using ProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    public class ClsHclinica
    {
        MSOFTVETDataContext dc = new MSOFTVETDataContext();

        public int idpaciente { get; set; }


        public List<SP_HvacunacionResult> VerVacunas()
        {


            var consulta = new List<SP_HvacunacionResult>();

            consulta = dc.SP_Hvacunacion(idpaciente).ToList();

            return consulta.ToList();
        }
        public List<SP_HRecetacionResult> VerRecetas()
        {
            var consulta = new List<SP_HRecetacionResult>();

            consulta = dc.SP_HRecetacion(idpaciente).ToList();

            return consulta.ToList();
        }
        public List<SP_HdesparacitacionResult> VerDesparacitaciones()
        {
            var consulta = new List<SP_HdesparacitacionResult>();

            consulta = dc.SP_Hdesparacitacion(idpaciente).ToList();

            return consulta.ToList();
        }
    }
}
