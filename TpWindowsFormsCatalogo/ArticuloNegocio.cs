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
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select ar.Id, ar.Codigo, ar.Nombre, ar.Descripcion, ar.ImagenUrl, ar.Precio, ma.Descripcion as Marca, ca.Descripcion as Categoria from ARTICULOS as ar inner join MARCAS as ma on ar.IdMarca = ma.Id inner join CATEGORIAS as ca on ar.IdCategoria = ca.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.IdMarca = new Marca();
                    aux.IdMarca.Descripcion = (string)datos.Lector["Marca"];
                    aux.IdCategoria = new Categoria();
                    aux.IdCategoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexxion();
            }
        }
    }
}
