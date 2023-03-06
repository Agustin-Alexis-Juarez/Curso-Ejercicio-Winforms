using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Winform_app_repaso
{
    internal class PokemonNegocio
    {
        public List<Pokemon> listar()
        {
			List<Pokemon> lista = new List<Pokemon>();
			try
			{
				SqlConnection conexion = new SqlConnection();
				SqlCommand comando = new SqlCommand();
				SqlDataReader lector;

				conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad from POKEMONS P, ELEMENTOS E, ELEMENTOS D where P.IdTipo = E.Id AND P.IdDebilidad = D.Id";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					Pokemon aux = new Pokemon();
					aux.Numero = (int)lector["Numero"];
					aux.Nombre = (string)lector["Nombre"];
					aux.Descripcion = (string)lector["Descripcion"];
					aux.UrlImagen = (string)lector["UrlImagen"];
					aux.Tipo = new Elemento();
					aux.Debilidad = new Elemento();
					aux.Tipo.Descripcion = (string)lector["Tipo"];
					aux.Debilidad.Descripcion = (string)lector["Debilidad"];
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
