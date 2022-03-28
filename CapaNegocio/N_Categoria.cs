using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Categoria
    {

        D_Categoria obj_Datos = new D_Categoria();

        public List<E_Categoria> ListarCategoria(string buscar)
        {
            return obj_Datos.ListarCategoria(buscar);
        }

        public void InsertarCategoria(E_Categoria categoria)
        {
            obj_Datos.InsertarCateria(categoria);
        }

        public void EditandoCategoria(E_Categoria categoria)
        {
            obj_Datos.IditarCategoria(categoria);
        }

        public void EliminarCategoria(E_Categoria categoria)
        {
            obj_Datos.EliminarCategoria(categoria);
        }


    }
}
