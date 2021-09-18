using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace servicio
{
    public class ArticuloServicio
    {
        public List<Articulo> listar()
        {

            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select ar.Id, ar.Codigo, ar.Nombre, ar.Descripcion, ar.ImagenUrl, ar.Precio,ma.Id as IdMarca, ma.Descripcion as Marca, ca.Id as IdCategoria, ca.Descripcion as Categoria from ARTICULOS as ar inner join MARCAS as ma on ar.IdMarca = ma.Id inner join CATEGORIAS as ca on ar.IdCategoria = ca.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
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

        public void agregar(Articulo nuevo)
        {
            AccesoDatos data = new AccesoDatos();
            try
            {
                data.setearConsulta("INSERT INTO ARTICULOS(Codigo, Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) values ('" + nuevo.Codigo + "','" + nuevo.Nombre + "','" + nuevo.Descripcion + "',@idMarca,@idCategoria,'" + nuevo.ImagenUrl + "'," + nuevo.Precio + ")");
                data.setearParametro("@idMarca", nuevo.Marca.Id);
                data.setearParametro("@idCategoria", nuevo.Categoria.Id);

                data.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.cerrarConexxion();
            }
        }

        public void modificar(Articulo modificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @cod, Nombre = @nom, Descripcion = @des, IdMarca = @idM, IdCategoria = @idC, ImagenUrl = @img, Precio = @pre where id = @ID");
                datos.setearParametro("@ID", modificado.Id);
                datos.setearParametro("@cod", modificado.Codigo);
                datos.setearParametro("@nom", modificado.Nombre);
                datos.setearParametro("@des", modificado.Descripcion);
                datos.setearParametro("@idM", modificado.Marca.Id);
                datos.setearParametro("@idC", modificado.Categoria.Id);
                datos.setearParametro("@img", modificado.ImagenUrl);
                datos.setearParametro("@Pre", modificado.Precio);


                datos.ejecutarAccion();
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

        public void eliminar(Articulo eliminado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from ARTICULOS where Codigo = @cod");
                datos.setearParametro("@cod", eliminado.Codigo);
                datos.ejecutarAccion();
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

        public void buscar(Articulo busquedo, int valor)
        {

            Marca marca = new Marca();
            Categoria categoria = new Categoria();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                if (valor == 1)
                {
                    //De codigo
                    datos.setearConsulta("select @Codi, @Nom, @Des, @img, @DesMa Marca, @DesCa Categoria from ARTICULOS as AR inner join MARCAS as MA on @IdMar = @MarId inner join CATEGORIAS as CA on @IdCat = @CatId where(Codigo=@Cod)");
                    datos.setearParametro("@Cod", busquedo.Codigo);
                    datos.setearParametro("@Codi", busquedo.Codigo);
                    datos.setearParametro("@Nom", busquedo.Codigo);
                    datos.setearParametro("@Des", busquedo.Codigo);
                    datos.setearParametro("@Img", busquedo.Codigo);
                    datos.setearParametro("@DesMa", busquedo.Marca.Descripcion);
                    datos.setearParametro("@DesCa", categoria.Descripcion);
                    datos.setearParametro("@IdMar", busquedo.Marca.Id);
                    datos.setearParametro("@MarId", marca.Id);
                    datos.setearParametro("@IdCat", busquedo.Categoria.Id);
                    datos.setearParametro("@CatId", categoria.Id);
                    
                    /*datos.setearParametro("@Des", busquedo.Descripcion);
                    datos.setearParametro("@Img", busquedo.ImagenUrl);*/

                    datos.ejecutarLectura();
                    datos.Lector.Read();

                }
                else if (valor == 2)
                { 
                    //Por categoria
                    datos.setearConsulta("");
                }
                else
                {
                    //Por marca
                    datos.setearConsulta("");
                }
                    
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
