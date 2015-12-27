using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Directorio
{
    public partial class Form1 : Form
    {
        // OJO La clase persona se definio en un archivo de clase 
        // Ver en el explorador de la solucion
        private List<PersonaDirectorio> Contactos;

        

        public Form1()
        {
	  // OjO se instancia la lista de personas PersonaDirectorio
	  Contactos = new List<PersonaDirectorio>();

	  InitializeComponent();
        }
        
        // Boton Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
	  if (Validacion())
	      GuardarDatos();	  
        }
        
        private void GuardarDatos() {
	  // Instancio un objeto de tipo persona
	  PersonaDirectorio persona = new PersonaDirectorio();
	  persona.Nombre = txtNombre.Text;
	  persona.Apellido = txtApellido.Text;
	  persona.Celular = txtCelular.Text;
	  persona.Favorito = checkBoxFavorito.Checked ? true : false;

	  // Instanciando utilizando el otro constructor
	  // PersonaDirectorio persona2 = new PersonaDirectorio(
	  //    txtNombre.Text,
	  //    txtApellido.Text,
	  //    txtCelular.Text,
	  //    checkBoxFavorito.Checked ? true : false);

	  // Adicionamos la persona creada a la lista de contactos
	  Contactos.Add(persona);
	  // imprimimos los contactos en la grilla 
	  ImprimirContactos();
	  // Limpiar campos
	  Limpiar();
        }

        private void ImprimirContactos()
        {
	  var bindingList = new BindingList<PersonaDirectorio>(Contactos);
	  var source = new BindingSource(bindingList, null);
	  dataGrid.DataSource = source;
        }
        
        // Metodo para realizar la validacion.
        private bool Validacion()
        {
	  bool validador = true;
	  string mensajeError = "";

	  if (txtNombre.Text == String.Empty)
	  {
	      mensajeError += "\nEl Campo Nombre no puede estar vacio.";
	      validador = false;	      
	  }
	  if (txtApellido.Text == String.Empty)
	  {
	      mensajeError += "\nEl Campo Apellido no puede estar vacio";
	      validador = false;
	  }
	  if (txtCelular.Text == String.Empty)
	  {
	      mensajeError += "\nEl Campo Celular no puede estar vacio";
	      validador = false;
	  }

	  lblInformation.Text = mensajeError;
	  return validador;
        }

        private void Limpiar()
        {
	  txtNombre.Text = "";
	  txtApellido.Text = "";
	  txtCelular.Text = "";
	  checkBoxFavorito.CheckState = CheckState.Unchecked;
        }
    }
}
