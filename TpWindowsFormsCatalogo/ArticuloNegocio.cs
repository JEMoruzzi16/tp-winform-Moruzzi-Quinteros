using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace TpWindowsFormsCatalogo
{
    class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select ar.Id, ar.Codigo,ar.Nombre,ar.Descripcion,ar.ImagenUrl,ar.Precio, ma.Descripcion as Marca, ca.Descripcion as Categoria from ARTICULOS as ar inner join MARCAS as ma on ar.IdMarca = ma.Id inner join CATEGORIAS as ca on ar.IdCategoria = ca.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector=comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux= new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.IdMarca = new Marca(); 
                    aux.IdMarca.Descripcion = (string)lector["Marca"];
                    aux.IdCategoria = new Categoria(); 
                    aux.IdCategoria.Descripcion = (string)lector["Categoria"];
                    aux.ImagenUrl = (string)lector["ImagenUrl"];
                    aux.Precio = (decimal)lector["Precio"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
                
            }
        }
    }
}
