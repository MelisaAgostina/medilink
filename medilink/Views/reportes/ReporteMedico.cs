﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using medilink.Models;
using medilink.ViewModels;
using medilink.Views;
using medilink.BD;
using static medilink.BD.Crud;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;


namespace medilink.Views.reportes
{
    public partial class ReporteMedico : Form
    {

        private UsuarioM usuarioLogueado;
        private CrudVM usuarioVM;
         
        public ReporteMedico(UsuarioM usuarioLogueado)
        {
            InitializeComponent(); 
            this.usuarioLogueado = usuarioLogueado;
            usuarioVM = new CrudVM(usuarioLogueado.id_perfil);
            this.Load += new EventHandler(ReporteMedico_Load);

            toolTip1.SetToolTip(BGenerar, "Generar Reporte");
            toolTip2.SetToolTip(BExportar, "Exportar Reporte");
            toolTip3.SetToolTip(BLimpiar, "Limpiar Filtros");
            toolTip4.SetToolTip(PBAyuda, "Seleccione el estado de las citas que desea ver, luego indique el rango de fechas.");

        }

        //cargamos cb
        private void CargarEstados()
        {
            //los estados son exactamente los de la BD, no podemos poner en plural ni mayuscula
            List<string> estados = new List<string> { "Todas", "cancelada", "completada", "activa" };
            CBEstado.DataSource = estados;
        }

        private void ReporteMedico_Load(object sender, EventArgs e)
        {
            CargarEstados();
            //CBEstado.Items.Add("Todas");
            //CBEstado.Items.Add("Activas");
            //CBEstado.Items.Add("Canceladas");
            //CBEstado.SelectedIndex = 0; 
        }

        //botones
        private void BLimpiar_Click(object sender, EventArgs e)
        {
            CBEstado.SelectedIndex = -1;
            DTPInicio.Value = DateTime.Now;
            DTPFin.Value = DateTime.Now;
            chartCitas.Series.Clear();
        }

        private void BExportar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Image Files|*.png;*.jpg;*.bmp|PDF Files|*.pdf|Excel Files|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    if (saveFileDialog.FileName.EndsWith(".png") || saveFileDialog.FileName.EndsWith(".jpg") || saveFileDialog.FileName.EndsWith(".bmp"))
                    {
                        chartCitas.SaveImage(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    
                }
            }
        }

        private int BuscarMedico(int idUsuario)
        {

            using (var conexionBD = new ConexionBD()) // Asegúrate de que `conexionBD` es una instancia válida.
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    if (conexion.State == System.Data.ConnectionState.Open)
                    {
                        string query = "SELECT * FROM medico WHERE id_usuario = @usuario";
                        using (MySqlCommand comando = new MySqlCommand(query, conexion))
                        {
                            comando.Parameters.AddWithValue("@usuario", idUsuario);

                            using (MySqlDataReader reader = comando.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    reader.Read();

                                    return Convert.ToInt32(reader["id_usuario"]);
                                }
                            }

                        }
                    }
                }

            }
            return 0;
        }





        private void BGenerar_Click(object sender, EventArgs e)
        {
            // Obtener el id del médico logueado

            int idMedico = BuscarMedico(usuarioLogueado.id_usuario);


            //filtros
            string estadoSeleccionado = CBEstado.SelectedItem?.ToString() ?? "Todas";
            DateTime fechaInicio = DTPInicio.Value.Date;
            DateTime fechaFin = DTPFin.Value.Date;

            
            List<CitaM> citas = usuarioVM.ListarCitasFiltradas(idMedico, estadoSeleccionado, fechaInicio, fechaFin);

           
            chartCitas.Series.Clear();

            
            var serie = new Series("Citas")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            
            foreach (var cita in citas)
            {
                // usar la fecha como X y algún valor o categoría como Y (ejemplo: 1 para citas canceladas, 2 para reprogramadas, etc.)
                serie.Points.AddXY(cita.fecha.ToShortDateString(), 1); 
            }

            
            chartCitas.Series.Add(serie);
        }







        //por accidente
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartCitas_Click(object sender, EventArgs e)
        {

        }

        private void toolTip4_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
 