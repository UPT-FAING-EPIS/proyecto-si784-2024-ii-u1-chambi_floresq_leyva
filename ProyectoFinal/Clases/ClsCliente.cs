using ProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Clases
{
    public class ClsCliente
    {
        public int CodCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Genero { get; set; }
        public string Correo { get; set; }

        public bool ValidarDatos()
        {
            return !string.IsNullOrEmpty(Nombre) && !string.IsNullOrEmpty(DNI) && DNI.Length == 8;
        }

        public static bool ExisteClientePorDNI(string dni)
        {
            using (var dc = new MSOFTVETDataContext())
            {
                return dc.V_Cliente.Any(x => x.DNI == dni);
            }
        }

        public void InsertarEnBaseDeDatos()
        {
            using (var dc = new MSOFTVETDataContext())
            {
                dc.SP_AgregarCliente(Nombre, Apellido, Telefono, Genero, DNI, Direccion,Correo);
            }
        }

        public void ModificarEnBaseDeDatos()
        {
            using (var dc = new MSOFTVETDataContext())
            {
                var clienteExistente = dc.V_Cliente.FirstOrDefault(x => x.DNI == DNI && x.Cod_Cliente == CodCliente);

                if (clienteExistente != null)
                {
                    dc.SP_ModificarCliente(CodCliente, Nombre, Apellido, Telefono, Genero, DNI, Direccion,Correo);
                }
            }
        }

        public void EliminarEnBaseDeDatos()
        {
            using (var dc = new MSOFTVETDataContext())
            {
                var clienteExistente = dc.V_Cliente.FirstOrDefault(x => x.Cod_Cliente == CodCliente);

                if (clienteExistente != null)
                {
                    dc.SP_EliminarCliente(CodCliente);
                }
            }
        }

        public static List<ClsCliente> ObtenerListaClientes()
        {
            using (var dc = new MSOFTVETDataContext())
            {
                var consulta = from x in dc.V_Cliente
                               select new ClsCliente
                               {
                                   CodCliente = x.Cod_Cliente,
                                   Nombre = x.Nombre,
                                   Apellido = x.Apellido,
                                   DNI = x.DNI,
                                   Telefono = x.Telefono,
                                   Direccion = x.Dirección,
                                   Genero = x.Género,
                                   Correo = x.Correo
                               };

                return consulta.ToList();
            }
        }
    }
}
