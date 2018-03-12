using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaCatalina.Clases
{
    static public class General
    {
        public class ArticulosVencimientos
        {
            private string _articuloId;
            private DateTime _fVto;
            decimal _cantidad;

            public string ArticuloId
            {
                get
                {
                    return _articuloId;
                }

                set
                {
                    _articuloId = value;
                }
            }

            public DateTime FVto
            {
                get
                {
                    return _fVto;
                }

                set
                {
                    _fVto = value;
                }
            }


            public decimal Cantidad
            {
                get
                {
                    return _cantidad;
                }

                set
                {
                    _cantidad = value;
                }
            }
        }

    }
}
