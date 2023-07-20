using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.IO;
namespace pokemonAPP1
{
    public partial class FrmAltaPokemon : Form
    {
        private pokemon pokemon = null;
        public FrmAltaPokemon()
        {
            InitializeComponent();
        }
        public FrmAltaPokemon(pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "modificar pokemon";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //pokemon poke = new pokemon();
            pokemonNegocio negocio = new pokemonNegocio();
            try
            {

                if (pokemon == null)
                    pokemon = new pokemon();

                pokemon.numero = int.Parse(txtNumero.Text);
                pokemon.nombre = txtNombre.Text;
                pokemon.descripcion = txtDescripcion.Text;
                pokemon.urlImagen = txtUrlImagen.Text;
                pokemon.tipo = (elementos)cboTipo.SelectedItem;
                pokemon.debilidad = (elementos)cboDebilidad.SelectedItem;


                if (pokemon.id != 0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("pokemon modificado exitosamente");
                }
                else
                {
                    negocio.agregar(pokemon);
                    MessageBox.Show("pokemon agregado exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                cboTipo.DataSource = elementoNegocio.listar();
                cboTipo.ValueMember = "id";
                cboTipo.DisplayMember = "descripcion";
                cboDebilidad.DataSource = elementoNegocio.listar();
                cboDebilidad.ValueMember = "id";
                cboDebilidad.DisplayMember = "descripcion";

                if (pokemon != null)
                {
                    txtNumero.Text = pokemon.numero.ToString();
                    txtNombre.Text = pokemon.nombre;
                    txtDescripcion.Text = pokemon.descripcion;
                    txtUrlImagen.Text = pokemon.urlImagen;
                    cargarImagen(pokemon.urlImagen);
                    cboTipo.SelectedValue = pokemon.tipo.id;
                    cboDebilidad.SelectedValue = pokemon.debilidad.id;


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAltaimg.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxAltaimg.Load("https://endlessicons.com/wp-content/uploads/2012/11/image-holder-icon.png");

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {

        }
    }
}
