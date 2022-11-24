using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config; /*Agregamos las librerias para trabajar con firebase*/
using FireSharp.Response; /*Agregamos las librerias para trabajar con firebase*/
using FireSharp.Interfaces; /*Agregamos las librerias para trabajar con firebase*/
using static System.Windows.Forms.VisualStyles.VisualStyleElement; /*No le hagan caso, no se que es pero si lo quitan no sirve el código*/

namespace ProyectoBd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Realizamos la conexion con la base de datos Online
        IFirebaseConfig ifcon = new FirebaseConfig()
        {
            AuthSecret = "mLe9t23Q7CGOXvJz2LR5vy7azdcTvFUu9Gp2YxzV",
            BasePath = "https://proyecto3p-61519-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Les pique por error 
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Les pique por error 
        }

        //Agregamos los datos en la base de datos
        //La clase se encuentra como "Musica", ahi creamos estas variables
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
                
            };
            var setter = client.Set("Musica/" + txtId.Text, std);
            MessageBox.Show("Que buenos gustos ;)");
        }

        //Esto igualmente es para verificar la conexion con la base de datos
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

        //Funcion para actualizar los datos en la base de datos
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
            /*Con el valor del "txtId" podemos realizar la conexion con 
             * un array en especifico para realizar los cambios*/
            var setter = client.Update("Musica/" + txtId.Text, std); 
            MessageBox.Show("Creo que te equivocaste al escribir, no?, No hay problema ;D");
        }

        //Funcion para encontrar un conjunto de datos en la base de datos
        private void Seleccionar_Click(object sender, EventArgs e)
        {
            //Igualmente el "txtId" es nuestra llave primaria para encontrar el array
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

        //Funcion para eliminar datos en la base de datos
        private void Eliminar_Click(object sender, EventArgs e)
        {
            //Igualmente el "txtId" es nuestra llave primaria para eliminar el array
            var resultado = client.Delete("Musica/" + txtId.Text);
            MessageBox.Show("Desarrollamos nuevos gustos 7v7");
        }
    }
}
