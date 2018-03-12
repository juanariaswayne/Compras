
namespace StaCatalina.Clases
{
    class Usuario
    {
        public class UsuarioLogeado
        {
            private static string _usuario = string.Empty ;
            private static int _IdUsuario = 0;
            private static int _id_sector;
            private static string _email = string.Empty;
            private static string _empresaAutorizada = string.Empty;
            public static string usuario_Logeado
            {
             get {return _usuario;}
             set {_usuario = value;}
            }

            public static int id_usuario_Logeado
            {
                get { return _IdUsuario; }
                set { _IdUsuario = value; }
            }
            public static int Id_Sector
            {
                get { return _id_sector; }
                set { _id_sector = value; }
            }

            public static string Email
            {
                get { return _email;}

                set { _email = value;}
            }

            public static string EmpresaAutorizada
            {
                get
                {
                    return _empresaAutorizada;
                }

                set
                {
                    _empresaAutorizada = value;
                }
            }
        }
        public class EmpresaLogeada
        {
            private static string _empresaIngresada = string.Empty;
            private static string _nombreEmpresaIngresada = string.Empty;

            public static string EmpresaIngresada
            {
                get { return _empresaIngresada; }
                set { _empresaIngresada = value; }

            }

            public static string NombreEmpresaIngresada
            {
                get => _nombreEmpresaIngresada;
                set => _nombreEmpresaIngresada = value;
            }
        }

 

    }
}

