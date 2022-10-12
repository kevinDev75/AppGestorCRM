using AppKST.Models.ProductModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppKST.Models.ClientModule
{
    public class ClienteSubcripcionesDTO
    {
        public ClienteDTO cliente { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string apellido_Materno { get; set; }

        public string apellido_Paterno { get; set; }
        public string desccoleccion { get; set; }
        public string descEditorial { set; get; }
        public string fecha_subcripcion { get; set; }
        public string fecha_salida { get; set; }
        public string flg_estado { get; set; }
        public string flg_wsp { get; set; }
        public string motivo { get; set; }
        public ColeccionDTO Coleccion { get; set; }
        public EditorialDTO editorial { get; set; }

    }
}
