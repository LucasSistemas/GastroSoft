using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace Entidad.Empleados_y_Usuarios
{
    public class Empleados
    {
        public int IdEmpleado {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string Sexo { get; set; }
        public string Genero { get; set; }
        public DateTime Fecha_Nac {  get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public int IdDireccion {  get; set; }
        public bool Activo { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public DateTime Fecha_Alta { get; set; }
        public string CodigoAcceso { get; set; }
        public DateTime VencimientoCodigo { get; set; }
    }
}
