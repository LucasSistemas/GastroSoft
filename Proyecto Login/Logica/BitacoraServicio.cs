using Datos;
using Entidad;
using Sesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//para registrar eventos 

namespace Logica
{
    public class BitacoraServicio
    {
        private BitacoraDatos datos = new BitacoraDatos();

        public void Registrar(string accion, string descripcion, string tipo, string nivel)
        {
            Bitacora bitacora = new Bitacora();

            bitacora.NombreUsuario = UsuarioSesion.ObtenerNombreUsuario(); //usuario logueado

            bitacora.Accion = accion; //datos del formulario

            bitacora.Descripcion = descripcion;

            bitacora.Tipo = tipo;

            bitacora.Nivel = nivel;

            datos.Registrar(bitacora); //envia inf a la capa de datos
        }

    }
}
