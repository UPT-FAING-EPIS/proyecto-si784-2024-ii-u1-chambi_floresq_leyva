using ProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    internal class ClsEmpleado
    {
        public int CodEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Cargo { get; set; }
        public string Horario { get; set; }
        public int Sueldo { get; set; }

        public static List<ClsEmpleado> ObtenerListaEmpleados()
        {
            using (var dc = new MSOFTVETDataContext())
            {
                var consulta = from e in dc.V_Empleado
                               select new ClsEmpleado
                               {
                                   CodEmpleado = e.Cod_Empleado,
                                   Nombre = e.Nombre,
                                   Apellido = e.Apellido,
                                   DNI = e.DNI,
                                   FechaNacimiento = e.FechaNacimiento,
                                   Genero = e.Sexo,
                                   Telefono = e.Telefono,
                                   FechaInicio = e.Fecha_Ingreso,
                                   Cargo = e.Cargo,
                                   Horario = e.Horario,
                                   Sueldo = (int)e.Sueldo
                               };
                return consulta.ToList();
            }
        }

        public void InsertarEnBaseDeDatos()
        {
            using (var dc = new MSOFTVETDataContext())
            {
                dc.SP_AgregarEmpleado(Nombre, Apellido, DNI, Convert.ToString(FechaNacimiento), Genero, Telefono, Convert.ToString(FechaInicio), Cargo, Horario, Sueldo.ToString());
            }
        }

        public static bool ExisteEmpleadoPorDNI(string dni)
        {
            using (var dc = new MSOFTVETDataContext())
            {
                return dc.V_Empleado.Any(x => x.DNI == dni);
            }
        }


        public void ModificarEnBaseDeDatos()
        {
            using (var dc = new MSOFTVETDataContext())
            {
                dc.SP_ModificarEmpleado(CodEmpleado, Nombre, Apellido, DNI, FechaNacimiento, Genero, Telefono, FechaInicio, Cargo, Horario, Sueldo);
            }
        }

        public void EliminarEnBaseDeDatos()
        {
            using (var dc = new MSOFTVETDataContext())
            {
                dc.SP_EliminarEmpleado(CodEmpleado);
            }
        }

        public bool ValidarDatos()
        {
            return !string.IsNullOrEmpty(Nombre) && !string.IsNullOrEmpty(Apellido) && !string.IsNullOrEmpty(DNI) && Sueldo > 0;
        }
    }
}
