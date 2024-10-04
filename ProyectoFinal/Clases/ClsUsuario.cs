using ProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Clases
{
    public class ClsUsuario
    {

        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string categoria { get; set; }
        public string idemp { get; set; }

        MSOFTVETDataContext dc = new MSOFTVETDataContext();

        public void AgregarUsuario()
        {
            try
            {
                using (var dc = new MSOFTVETDataContext())
                {
                    // Llamar al procedimiento almacenado
                    dc.SP_AgregarUsuario(usuario, contraseña,categoria,idemp);
                    MessageBox.Show("Se ha registrado el Usuario satisfactoriamente", "Registrar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Error al registrar usuario...\r\nComplete los datos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
