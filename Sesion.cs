using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cupediarum
{
    public static class Sesion
    {
        public static int IdUsuario { get; set; } = 0;
        public static string NombreUsuario { get; set; } = "";
        public static int IdRol { get; set; } = 0;

        public static bool HaySesionActiva()
        {
            return IdUsuario != 0;
        }

        public static void Cerrar()
        {
            IdUsuario = 0;
            NombreUsuario = "";
            IdRol = 0;
        }

        public static string NombreRol
        {
            get
            {
                switch (IdRol)
                {
                    case 1: return "ADMIN";
                    case 2: return "CAJERO";
                    case 3: return "MESERO";
                    default: return "USUARIO";
                }
            }
        }
    }
}

