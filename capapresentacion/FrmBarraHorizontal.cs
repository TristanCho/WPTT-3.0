﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPTT_1._0;

namespace capapresentacion
{
    public partial class FrmBarraHorizontal : Form
    {
        public FrmBarraHorizontal()
        {
            InitializeComponent();
            botonesPrincipal();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Console.WriteLine(FrmParent.frmparent.getFormularioActual().ToString());
            switch (FrmParent.frmparent.getFormularioActual().ToString())
            {
                case "capapresentacion.FrmProyecto, Text: ":
                    FrmProyecto proyecto = (FrmProyecto)FrmParent.frmparent.getFormularioActual();
                    proyecto.nuevoProyecto();
                    visualizaBotonesCambiarFormulario(false);
                    visualizaBotonGuardar(true);
                    break;
                case "capapresentacion.FrmDetalleProyecto, Text: Proyecto":
                    FrmDetalleProyecto dtproyect = (FrmDetalleProyecto)FrmParent.frmparent.getFormularioActual();
                    dtproyect.nuevoClicado();
                     visualizaBotonesCambiarFormulario(false);
                    visualizaBotonGuardar(true);
                    break;
                case "capapresentacion.FrmDetalleTarea, Text: Tarea":
                    FrmDetalleTarea tarea = (FrmDetalleTarea)FrmParent.frmparent.getFormularioActual();
                    break;                
                case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":
                    FrmDetalleTiempos tiempos = (FrmDetalleTiempos)FrmParent.frmparent.getFormularioActual();
                    break;
               
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (FrmParent.frmparent.getFormularioActual().ToString())
            {

                case "capapresentacion.FrmDetalleProyecto, Text: Proyecto":
                    FrmDetalleProyecto proyect = (FrmDetalleProyecto)FrmParent.frmparent.getFormularioActual();
                    proyect.guardarProyecto();
                    break;
                case "capapresentacion.FrmTarea, Text: FrmTarea":

                    break;
                case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":

                    break;

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            switch (FrmParent.frmparent.getFormularioActual().ToString())
            {

                case "capapresentacion.FrmDetalleProyecto, Text: Proyecto":
                    FrmDetalleProyecto proyect = (FrmDetalleProyecto)FrmParent.frmparent.getFormularioActual();
                    proyect.editarProyecto();
                    visualizaBotonesCambiarFormulario(false);
                    visualizaBotonGuardar(true);
                    break;
                case "capapresentacion.FrmDetalleTarea, Text: Tarea":
                    FrmDetalleTarea tarea = (FrmDetalleTarea)FrmParent.frmparent.getFormularioActual();


                    break;
                case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":
                    FrmDetalleTiempos tiempos = (FrmDetalleTiempos)FrmParent.frmparent.getFormularioActual();
                    break;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            switch (FrmParent.frmparent.getFormularioActual().ToString())
            {

                case "capapresentacion.FrmDetalleProyecto, Text: Proyecto":
                    FrmDetalleProyecto proyect = (FrmDetalleProyecto)FrmParent.frmparent.getFormularioActual();
                    visualizaBotonesCambiarFormulario(true);
                    visualizaBotonGuardar(false);
                    proyect.bloqueaProyecto();
                    break;
                case "capapresentacion.FrmTarea, Text: FrmTarea":

                    break;
                case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":

                    break;

            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            switch (FrmParent.frmparent.getFormularioActual().ToString())
            {

                case "capapresentacion.FrmDetalleProyecto, Text: Proyecto":
                    FrmDetalleProyecto proyect = (FrmDetalleProyecto)FrmParent.frmparent.getFormularioActual();
                    proyect.botonPrimero();
                    break;
                case "capapresentacion.FrmTarea, Text: FrmTarea":

                    break;
                case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":

                    break;

            }
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            switch (FrmParent.frmparent.getFormularioActual().ToString())
            {

                case "capapresentacion.FrmDetalleProyecto, Text: Proyecto":
                    FrmDetalleProyecto proyect = (FrmDetalleProyecto)FrmParent.frmparent.getFormularioActual();
                    proyect.botonAtras();
                    break;
                case "capapresentacion.FrmTarea, Text: FrmTarea":

                    break;
                case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":

                    break;

            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            switch (FrmParent.frmparent.getFormularioActual().ToString())
            {

                case "capapresentacion.FrmDetalleProyecto, Text: Proyecto":
                    FrmDetalleProyecto proyect = (FrmDetalleProyecto)FrmParent.frmparent.getFormularioActual();
                    proyect.botonSiguiente();
                    break;
                case "capapresentacion.FrmTarea, Text: FrmTarea":

                    break;
                case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":

                    break;

            }
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            switch (FrmParent.frmparent.getFormularioActual().ToString())
            {

                case "capapresentacion.FrmDetalleProyecto, Text: Proyecto":
                    FrmDetalleProyecto proyect = (FrmDetalleProyecto)FrmParent.frmparent.getFormularioActual();
                    proyect.botonUltimo();
                    break;
                case "capapresentacion.FrmTarea, Text: FrmTarea":

                    break;
                case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":

                    break;

            }
        }

        public void visualizaBotonesCambiarFormulario(bool value)
        {
            btnAtras.Visible = value;
            btnPrimero.Visible = value;
            btnSiguiente.Visible = value;
            btnFinal.Visible = value;

        }
        public void botonesPrincipal()
        {
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            btnNuevo.Visible = false;
            btnEditar.Visible = false;
            visualizaBotonesCambiarFormulario(false);
        }
        public void visualizaBotonGuardar(bool value)
        {
            btnGuardar.Visible = value;
            btnCancelar.Visible = value;
            btnNuevo.Visible = !value;
            btnEditar.Visible = !value;
            if (value)
            {
                btnCancelar.Location = new Point(110, 2);
                btnGuardar.Location = new Point(29, 2);
            }
        }

        private void btnEliminarProyecto_Click(object sender, EventArgs e)
        {
            switch (FrmParent.frmparent.getFormularioActual().ToString())
            {

                case "capapresentacion.FrmeProyecto, Text: ":
                    FrmProyecto proyecto = (FrmProyecto)FrmParent.frmparent.getFormularioActual();
                    //proyecto.

                    break;
                case "capapresentacion.FrmDetalleProyecto, Text: Proyecto":
                    FrmDetalleProyecto detalleProyecto = (FrmDetalleProyecto)FrmParent.frmparent.getFormularioActual();

                    break;
                case "capapresentacion.FrmTarea, Text: FrmTarea":

                    break;
                case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":

                    break;

            }
        }
    }
}