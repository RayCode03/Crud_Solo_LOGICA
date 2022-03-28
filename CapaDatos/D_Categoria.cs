using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
    public class D_Categoria
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Categoria> ListarCategoria(string buscar)
        {
            SqlDataReader LeerFila;
            SqlCommand cmd = new SqlCommand("SP_BUSCARCATEGORIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("BUSCAR", buscar);

            LeerFila = cmd.ExecuteReader();

            List<E_Categoria> Listar = new List<E_Categoria>();
            while (LeerFila.Read())
            {
                Listar.Add(new E_Categoria
                {
                    IdCategoria = LeerFila.GetInt32(0),
                    CodigoCategoria = LeerFila.GetString(1),
                    NombreCategoria = LeerFila.GetString(2),
                    Decripcion = LeerFila.GetString(3)
                });
            }
            conexion.Close();
            LeerFila.Close();
            return Listar;
        }

        public void InsertarCateria(E_Categoria categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARCATEGORIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", categoria.NombreCategoria);
            cmd.Parameters.AddWithValue("@DESCRIPCION", categoria.Decripcion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void IditarCategoria(E_Categoria categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_IDITARCATEGORIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCATEGORIA", categoria.IdCategoria);
            cmd.Parameters.AddWithValue("@NOMBRE", categoria.NombreCategoria);
            cmd.Parameters.AddWithValue("@DECRIPCION", categoria.Decripcion);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EliminarCategoria(E_Categoria categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARCATEGORIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCATEGORIA", categoria.IdCategoria);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }


    }
}
