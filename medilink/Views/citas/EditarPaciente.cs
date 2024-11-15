﻿using medilink.Models;
using medilink.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medilink.Views.citas
{
    public partial class EditarPaciente : Form
    {
        private PacienteM pacienteOriginal;
        private UsuarioM usuarioLogueado;
        private CrudVM usuarioVM;
        public EditarPaciente(PacienteM paciente, UsuarioM usuario)
        {
            InitializeComponent();
            pacienteOriginal = paciente;
            this.usuarioLogueado = usuario; 
            usuarioVM = new CrudVM(usuarioLogueado.id_perfil);
            CargarCombobox();

            // Cargar los datos en los controles
            comboBoxObraSocial.SelectedValue = paciente.id_obra_social;
            textBoxEditDomicilio.Text = paciente.direccion;
            textBoxCorreo.Text = paciente.correo;
            textBoxEditTelefono.Text = paciente.telefono;
        }

        private void CargarCombobox()
        {
            try
            {
                comboBoxObraSocial.DataSource = usuarioVM.ObtenerObrasSociales();
                comboBoxObraSocial.DisplayMember = "nombre";
                comboBoxObraSocial.ValueMember = "id_obra_social";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el ComboBox: " + ex.Message);
            }
        }
        private void EditarPaciente_Load(object sender, EventArgs e)
        {
            //no
        }

        private void buttonGuardarCambios_Click(object sender, EventArgs e)
        {
            // validaciones
            if (string.IsNullOrWhiteSpace(textBoxEditDomicilio.Text) ||
                string.IsNullOrWhiteSpace(textBoxCorreo.Text) ||
                string.IsNullOrWhiteSpace(textBoxEditTelefono.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            
            if (textBoxEditTelefono.Text.Length != 10 || !long.TryParse(textBoxEditTelefono.Text, out _))
            {
                MessageBox.Show("El teléfono debe tener 10 caracteres numéricos.");
                return;
            }

            //actualiza
            pacienteOriginal.id_obra_social = Convert.ToInt32(comboBoxObraSocial.SelectedValue);
            pacienteOriginal.direccion = textBoxEditDomicilio.Text;
            pacienteOriginal.correo = textBoxCorreo.Text;
            pacienteOriginal.telefono = textBoxEditTelefono.Text;

            
            bool resultado = usuarioVM.EditarPaciente(pacienteOriginal);

            if (resultado)
            {
                MessageBox.Show("Paciente actualizado exitosamente.");
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar el paciente. Verifique que el correo y teléfono sean únicos.");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
              "¿Estás seguro de que deseas cancelar los cambios?",
              "Confirmar cancelación",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
