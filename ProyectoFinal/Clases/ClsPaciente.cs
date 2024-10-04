using ProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    internal class ClsPaciente
    {
        public int CodPaciente { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int CodCliente { get; set; }

        public static List<ClsPaciente> ObtenerListaPacientes(int codCliente)
        {
            using (var dc = new MSOFTVETDataContext())
            {
                var consulta = from p in dc.V_Paciente
                               where p.Cod_Cliente == codCliente
                               select new ClsPaciente
                               {
                                   CodPaciente = p.Cod_Paciente,
                                   Nombre = p.Nombre,
                                   Especie = p.Especie,
                                   Raza = p.Raza,
                                   Sexo = p.Sexo,
                                   FechaNacimiento = p.Fecha,
                                   CodCliente = p.Cod_Cliente
                               };
                return consulta.ToList();
            }
        }

        public static ClsPaciente ObtenerPacientePorCodigo(int codPaciente)
        {
            using (var dc = new MSOFTVETDataContext())
            {
                var paciente = dc.V_Paciente.FirstOrDefault(p => p.Cod_Paciente == codPaciente);

                if (paciente != null)
                {
                    return new ClsPaciente
                    {
                        CodPaciente = paciente.Cod_Paciente,
                        Nombre = paciente.Nombre,
                        Especie = paciente.Especie,
                        Raza = paciente.Raza,
                        Sexo = paciente.Sexo,
                        FechaNacimiento = paciente.Fecha,
                        CodCliente = paciente.Cod_Cliente
                    };
                }
                return null;
            }
        }

        public void ModificarEnBaseDeDatos()
        {
            using (var dc = new MSOFTVETDataContext())
            {
                dc.SP_ModificarPaciente(CodPaciente, Nombre, Especie, Raza, Sexo, FechaNacimiento);
            }
        }

        public void EliminarEnBaseDeDatos()
        {
            using (var dc = new MSOFTVETDataContext())
            {
                dc.SP_EliminarPaciente(CodPaciente);
            }
        }

        public void InsertarEnBaseDeDatos()
        {
            using (var dc = new MSOFTVETDataContext())
            {
                dc.SP_AgregarPaciente(Nombre, Especie, Raza, Sexo, FechaNacimiento, CodCliente.ToString());
            }
        }

        public bool ValidarDatos()
        {
            return !string.IsNullOrEmpty(Nombre) && !string.IsNullOrEmpty(Especie) && !string.IsNullOrEmpty(Raza);
        }

        public static List<ClsPaciente> CargarTodo()
        {
            using (var dc = new MSOFTVETDataContext())
            {
                var consulta = from p in dc.V_Paciente
                               select new ClsPaciente
                               {
                                   CodPaciente = p.Cod_Paciente,
                                   Nombre = p.Nombre,
                                   Especie = p.Especie,
                                   Raza = p.Raza,
                                   Sexo = p.Sexo,
                                   FechaNacimiento = p.Fecha,
                                   CodCliente = p.Cod_Cliente
                               };
                return consulta.ToList();
            }
        }
    }
}
