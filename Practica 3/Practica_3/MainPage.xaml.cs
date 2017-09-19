using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica_3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void obtener(Object sender,EventArgs e)
        {
            var nombre = txtNombre.Text;
            var apellidos =txtApellidos.Text;
            var direccion = txtDireecion.Text;
            var telefono = txtTelefono.Text;
            var carrera = txtCarrera.Text;
            var semestre = txtCarrera.Text;
            var matricula = txtMatricula.Text;
            var correo = txtCorreo.Text;
            var gek = txtGetHub.Text;
            DisplayAlert("Recoleccion de los Datos ","Datos Personales \n"+"Nombre: "+ nombre + "\n"+"Apellidos: "+ apellidos + "\n" + "Direccion: " + direccion
                + "\n" + "Telefono: " + telefono + "\n" + "Datos Escolares \n" + "Carrera: " + carrera + "\n" + "Semestre : " + semestre
                + "\n" + "Matricula: " + matricula + "\n" + "Datos Sociales \n" + "Correo: " + correo + "\n" + "Gek Hub: " + gek , "Aceptar");



        }

       
    }
}
