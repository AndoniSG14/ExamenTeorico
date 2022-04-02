using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenTeorico
{
    public partial class Form1 : Form
    {
        int codigo, edad,semestres;
        string nombre, apellidos, nacionalidad, genero, ciudad, estado, universidad, carrera,deporte, main, jugador, estadocivil;

        private void txtsemestre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '0')) // Solo permite el ingreso de numeros

            {
                e.Handled = true; //si recibe numeros los agrega al txt
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtcodigo.Enabled = false; //desactiva el txt
            txtNombre.Enabled = false; 
            txtapellidos.Enabled = false; 
            txtedad.Enabled = false; 
            txtnacionalidad.Enabled = false; 
            txtGebero.Enabled = false; 
            txtciudad.Enabled = false; 
            txtestado.Enabled = false; 
            txtuniversidad.Enabled = false; 
            txtcarrera.Enabled = false; 
            txtsemestre.Enabled = false; 
            txtdeporte.Enabled = false; 
            txtmain.Enabled = false; 
            txtJugador.Enabled = false; 
            txtCivil.Enabled = false;

            btnNuevo.Text = "Nuevo";


            txtcodigo.Clear();
            txtNombre.Clear();
            txtapellidos.Clear();
            txtedad.Clear();
            txtnacionalidad.Clear();
            txtGebero.Clear();
            txtciudad.Clear();
            txtestado.Clear();
            txtuniversidad.Clear();
            txtcarrera.Clear();
            txtsemestre.Clear();
            txtdeporte.Clear();
            txtmain.Clear();
            txtJugador.Clear();
            txtCivil.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcodigo.Enabled = true; //Activa el txt
            txtNombre.Enabled = true; //Activa el txt
            txtapellidos.Enabled = true; //Activa el txt
            txtedad.Enabled = true; //Activa el txt
            txtnacionalidad.Enabled = true; //Activa el txt
            txtGebero.Enabled = true; //Activa el txt
            txtciudad.Enabled = true; //Activa el txt
            txtestado.Enabled = true; //Activa el txt
            txtuniversidad.Enabled = true; //Activa el txt
            txtcarrera.Enabled = true; //Activa el txt
            txtsemestre.Enabled = true; //Activa el txt
            txtdeporte.Enabled = true; //Activa el txt
            txtmain.Enabled = true; //Activa el txt
            txtJugador.Enabled = true; //Activa el txt
            txtCivil.Enabled = true; //Activa el txt

            btnNuevo.Text = "Guardar"; //Cambia el texto del boton "Nuevo" a "Guardar"

            if (btnNuevo.Text == "Guardar")
            {

                

                if (txtcodigo.Text.Length < 9)
                {
                    MessageBox.Show("Ingrese un codigo con el formato correcto", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtcodigo.Focus();
                    txtcodigo.SelectAll();
                }
                else if (txtcodigo.Text == "")
                {
                    MessageBox.Show("Ingrese su Codigo", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtcodigo.Focus();
                    txtcodigo.SelectAll();
                }
                else
                {
                    bool esNumero;
                    esNumero = int.TryParse(txtcodigo.Text, out codigo);

                    if (txtNombre.Text == "")
                    {
                        MessageBox.Show("Ingrese su nombre", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNombre.Focus();
                        txtNombre.SelectAll();
                    }
                    else
                    {
                        nombre = txtNombre.Text;

                        if (txtapellidos.Text == "")
                        {
                            MessageBox.Show("Ingrese sus Apellidos", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtapellidos.Focus();
                            txtapellidos.SelectAll();
                        }
                        else
                        {
                            apellidos = txtapellidos.Text;


                            if (txtedad.Text == "")
                            {
                                MessageBox.Show("Ingrese su edad", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtedad.Focus();
                                txtedad.Select();
                            }
                            else
                            {
                                bool esnum;
                                esnum = int.TryParse(txtedad.Text, out edad);


                                if (txtnacionalidad.Text == "")
                                {
                                    MessageBox.Show("Ingrese su Nacionalidad", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtnacionalidad.Focus();
                                    txtnacionalidad.SelectAll();

                                }
                                else
                                {
                                    nacionalidad = txtnacionalidad.Text;

                                    if (txtGebero.Text == "")
                                    {
                                        MessageBox.Show("Ingrese su Genero", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        txtGebero.Focus();
                                        txtGebero.SelectAll();
                                    }
                                    else
                                    {
                                        genero = txtGebero.Text;


                                        if (txtciudad.Text == "")
                                        {
                                            MessageBox.Show("Ingrese su ciudad", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            txtciudad.Focus();
                                            txtciudad.SelectAll();
                                        }
                                        else
                                        {
                                            ciudad = txtciudad.Text;

                                            if (txtestado.Text=="")
                                            {
                                                MessageBox.Show("Ingrese su estado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                txtestado.Focus();
                                                txtestado.SelectAll();
                                            }
                                            else
                                            {
                                                estado = txtestado.Text;

                                                if (txtuniversidad.Text =="")
                                                {
                                                    MessageBox.Show("Ingrese su Universidad", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                    txtuniversidad.Focus();
                                                    txtuniversidad.SelectAll();
                                                }
                                                else
                                                {
                                                    universidad = txtuniversidad.Text;


                                                    if (txtcarrera.Text=="")
                                                    {
                                                        MessageBox.Show("Ingrese su Carrera", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                        txtcarrera.Focus();
                                                        txtcarrera.SelectAll();
                                                    }
                                                    else
                                                    {
                                                        carrera = txtcarrera.Text;

                                                        if (txtsemestre.Text == "")
                                                        {
                                                            MessageBox.Show("Ingrese su Semestre", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                            txtsemestre.Focus();
                                                            txtsemestre.SelectAll();
                                                        }
                                                        else
                                                        {
                                                            bool esNum;
                                                            esNum = int.TryParse(txtsemestre.Text, out semestres);

                                                            if (txtdeporte.Text =="")
                                                            {
                                                                MessageBox.Show("Ingrese su Deporte Favorito", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                txtdeporte.Focus();
                                                                txtdeporte.SelectAll();
                                                            }
                                                            else
                                                            {
                                                                deporte = txtdeporte.Text;

                                                                if (txtmain.Text == "")
                                                                {
                                                                    MessageBox.Show("Ingrese su Main Favorito", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                    txtmain.Focus();
                                                                    txtmain.SelectAll();
                                                                }
                                                                else
                                                                {
                                                                    main = txtmain.Text;

                                                                    if (txtJugador.Text == "")
                                                                    {
                                                                        MessageBox.Show("Ingrese su Jugador Favorito de futbol", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                        txtJugador.Focus();
                                                                        txtJugador.SelectAll();
                                                                    }
                                                                    else
                                                                    {
                                                                        jugador = txtJugador.Text;

                                                                        if (txtCivil.Text == "")
                                                                        {
                                                                            MessageBox.Show("Ingrese su Estado Civil", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                            txtCivil.Focus();
                                                                            txtCivil.SelectAll();
                                                                        }
                                                                        else
                                                                        {
                                                                            estadocivil = txtCivil.Text;

                                                                        }
                                                                    }
                                                                }
                                                            
                                                            }
                                                        }
                                                    }
                                                }


                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }

                }
            }           
                   
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e) //validacion de numeros
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '0')) // Solo permite el ingreso de numeros
                
            {
                e.Handled = true; //si recibe numeros los agrega al txt
            }           
           
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Length < 9)//cuenta si el txt tiene menos de 9 digitos
            {
                txtcodigo.ForeColor = Color.Red;// si tiene menos los numero se hacen rojos

            }
            else
            {
                txtcodigo.ForeColor = Color.Black; //si tiene 9 digitos los numeros se hacen negros
            }
        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '0')) // Solo permite el ingreso de numeros

            {
                e.Handled = true; //si recibe numeros los agrega al txt
            }
        }
    }
}
