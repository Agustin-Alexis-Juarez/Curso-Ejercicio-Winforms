using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_app_repaso
{
    public partial class Form1 : Form
    {
        private List<Pokemon> listaPokemon;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemon = negocio.listar();
            dgvPokemons.DataSource = listaPokemon;
            dgvPokemons.Columns["UrlImagen"].Visible = false;
           imgPokemon(listaPokemon[0].UrlImagen);
           
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            imgPokemon(seleccionado.UrlImagen);
        }
    public void imgPokemon(string imagen)
    {
        try
        {

            pbxImagen.Load(imagen);

             
        }
        catch (Exception ex)
        {

          pbxImagen.Load("https://www.slntechnologies.com/wp-content/uploads/2017/08/ef3-placeholder-image.jpg");
        }


    }
    }


}
