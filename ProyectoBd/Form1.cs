using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoBd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifcon = new FirebaseConfig()
        {
            AuthSecret = "mLe9t23Q7CGOXvJz2LR5vy7azdcTvFUu9Gp2YxzV",
            BasePath = "https://proyecto3p-61519-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            Musica std = new Musica
            {
                Id = txtId.Text,
                Nombre = txtNombre.Text,
                Album = txtAlbum.Text,
                Artista = txtArtista.Text,
                FechaLanz = txtFecha.Text,
                Duracion = txtDuracion.Text,
                Disquera = txtDisquera.Text,
                //Imagen a realizar
            };
            var setter = client.Set("Musica/" + txtId.Text, std);
            MessageBox.Show("Que buenos gustos ;)");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifcon);
            }
            catch
            {
                MessageBox.Show("Tenemos un problema en nuestras comunicaciones");
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            Musica std = new Musica
            {
                Id = txtId.Text,
                Nombre = txtNombre.Text,
                Album = txtAlbum.Text,
                Artista = txtArtista.Text,
                FechaLanz = txtFecha.Text,
                Duracion = txtDuracion.Text,
                Disquera = txtDisquera.Text,
            };
            var setter = client.Update("Musica/" + txtId.Text, std);
            MessageBox.Show("Creo que te equivocaste al escribir, no?, No hay problema ;D");
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            var test = client.Get("Musica/" + txtId.Text);
            Musica std = test.ResultAs<Musica>();
            txtNombre.Text = std.Nombre;
            txtAlbum.Text = std.Album;
            txtDuracion.Text = std.Duracion;
            txtDisquera.Text = std.Disquera;
            txtArtista.Text = std.Artista;
            txtFecha.Text = std.FechaLanz;
            MessageBox.Show("Lo agregaras a Spotify? :0");
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            var resultado = client.Delete("Musica/" + txtId.Text);
            MessageBox.Show("Desarrollamos nuevos gustos 7v7");
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);
                ImgAlbum.Image = image;
            }
        }
    }
}
