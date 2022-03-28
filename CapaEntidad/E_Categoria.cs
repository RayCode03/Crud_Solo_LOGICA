using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Categoria
    {
        private int _idCategoria;
        private string _CodigoCategoria;
        private string _NombreCategoria;
        private string _Decripcion;

        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string CodigoCategoria { get => _CodigoCategoria; set => _CodigoCategoria = value; }
        public string NombreCategoria { get => _NombreCategoria; set => _NombreCategoria = value; }
        public string Decripcion { get => _Decripcion; set => _Decripcion = value; }
    }
}
