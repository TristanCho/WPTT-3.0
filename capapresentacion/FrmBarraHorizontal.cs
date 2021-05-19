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
            //Console.WriteLine(FrmParent.frmparent.getFormularioActual().ToString());

            controlDeBotones("Nuevo");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            controlDeBotones("Guardar");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlDeBotones("Editar");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            controlDeBotones("Cancelar");
        }
        private void btnEliminarProyecto_Click(object sender, EventArgs e)
        {
            controlDeBotones("Eliminar");
            //Console.WriteLine(FrmParent.frmparent.getFormularioActual().ToString());

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            controlDeBotones("Primero");

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            controlDeBotones("Atras");
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            controlDeBotones("Siguiente");

        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            controlDeBotones("Final");

        }
        private void controlDeBotones(string boton)
        {
            switch (boton)
            {
                case "Nuevo":
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
                        case "capapresentacion.FrmTarea, Text: FrmTarea":
                            FrmTarea tarea = (FrmTarea)FrmParent.frmparent.getFormularioActual();
                            tarea.nuevaTarea();
                            visualizaBotonesCambiarFormulario(false);
                            visualizaBotonGuardar(true);
                            //tarea.
                            break;
                        case "capapresentacion.FrmDetalleTarea, Text: Tarea":
                            FrmDetalleTarea detalleTarea = (FrmDetalleTarea)FrmParent.frmparent.getFormularioActual();
                            break;

                        case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":
                            FrmDetalleTiempos tiempos = (FrmDetalleTiempos)FrmParent.frmparent.getFormularioActual();
                            break;
                        case "capapresentacion.FrmPersonal, Text: Personal":
                            FrmPersonal personal = (FrmPersonal)FrmParent.frmparent.getFormularioActual();

                            break;
                        case "capapresentacion.FrmDetallePersonal, Text: FrmDetallePersonal":
                            FrmDetallePersonal detallePersonal = (FrmDetallePersonal)FrmParent.frmparent.getFormularioActual();
                            break;

                    }
                    break;
                case "Guardar":
                    switch (FrmParent.frmparent.getFormularioActual().ToString())
                    {

                        case "capapresentacion.FrmDetalleProyecto, Text: Proyecto":
                            FrmDetalleProyecto proyect = (FrmDetalleProyecto)FrmParent.frmparent.getFormularioActual();
                            proyect.guardarProyecto();
                            visualizaBotonGuardar(false);
                            break;
                        case "capapresentacion.FrmDetalleTarea, Text: Tarea":
                            FrmDetalleTarea detalleTarea = (FrmDetalleTarea)FrmParent.frmparent.getFormularioActual();
                            detalleTarea.guardarTarea();
                            visualizaBotonGuardar(false);
                            break;
                        case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":

                            break;
                        case "capapresentacion.FrmPersonal, Text: Personal":
                            FrmPersonal personal = (FrmPersonal)FrmParent.frmparent.getFormularioActual();

                            break;
                        case "capapresentacion.FrmDetallePersonal, Text: FrmDetallePersonal":
                            FrmDetallePersonal detallePersonal = (FrmDetallePersonal)FrmParent.frmparent.getFormularioActual();
                            break;
                    }
                    break;
                case "Editar":
                    switch (FrmParent.frmparent.getFormularioActual().ToString())
                    {
                        case "capapresentacion.FrmProyecto, Text: ":
                            FrmProyecto proyecto = (FrmProyecto)FrmParent.frmparent.getFormularioActual();
                            proyecto.editarProyecto();
                            visualizaBotonesCambiarFormulario(false);
                            visualizaBotonGuardar(true);
                            // proyecto.botonEliminarProyectoPrincipal();

                            break;
                        case "capapresentacion.FrmDetalleProyecto, Text: Proyecto":
                            FrmDetalleProyecto detalleProyecto = (FrmDetalleProyecto)FrmParent.frmparent.getFormularioActual();
                            detalleProyecto.editarProyecto();
                            visualizaBotonesCambiarFormulario(false);
                            visualizaBotonGuardar(true);
                            break;
                        case "capapresentacion.FrmTarea, Text: FrmTarea":
                            FrmTarea tarea = (FrmTarea)FrmParent.frmparent.getFormularioActual();
                            tarea.editarTarea();
                            visualizaBotonesCambiarFormulario(false);
                            visualizaBotonGuardar(true);

                            break;
                        case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":
                            FrmDetalleTiempos tiempos = (FrmDetalleTiempos)FrmParent.frmparent.getFormularioActual();
                            break;
                        case "capapresentacion.FrmPersonal, Text: Personal":
                            FrmPersonal personal = (FrmPersonal)FrmParent.frmparent.getFormularioActual();

                            break;
                        case "capapresentacion.FrmDetallePersonal, Text: FrmDetallePersonal":
                            FrmDetallePersonal detallePersonal = (FrmDetallePersonal)FrmParent.frmparent.getFormularioActual();
                            break;

                    }
                    break;
                case "Cancelar":
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
                        case "capapresentacion.FrmPersonal, Text: Personal":
                            FrmPersonal personal = (FrmPersonal)FrmParent.frmparent.getFormularioActual();

                            break;
                        case "capapresentacion.FrmDetallePersonal, Text: FrmDetallePersonal":
                            FrmDetallePersonal detallePersonal = (FrmDetallePersonal)FrmParent.frmparent.getFormularioActual();
                            break;

                    }
                    break;
                case "Eliminar":
                    switch (FrmParent.frmparent.getFormularioActual().ToString())
                    {

                        case "capapresentacion.FrmProyecto, Text: ":
                            FrmProyecto proyecto = (FrmProyecto)FrmParent.frmparent.getFormularioActual();
                            proyecto.botonEliminarProyectoPrincipal();

                            break;
                        case "capapresentacion.FrmDetalleProyecto, Text: Proyecto":
                            FrmDetalleProyecto detalleProyecto = (FrmDetalleProyecto)FrmParent.frmparent.getFormularioActual();
                            detalleProyecto.botonEliminarProyecto();
                            break;
                        case "capapresentacion.FrmTarea, Text: FrmTarea":
                            FrmTarea tarea = (FrmTarea)FrmParent.frmparent.getFormularioActual();
                            tarea.botonEliminarTarea();
                            break;
                        case "capapresentacion.FrmDetalleTarea, Text: Tarea":
                            FrmDetalleTarea detalleTarea = (FrmDetalleTarea)FrmParent.frmparent.getFormularioActual();
                            detalleTarea.botonEliminarTarea();
                            break;
                        case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":

                            break;
                        case "capapresentacion.FrmPersonal, Text: Personal":
                            FrmPersonal personal = (FrmPersonal)FrmParent.frmparent.getFormularioActual();

                            break;
                        case "capapresentacion.FrmDetallePersonal, Text: FrmDetallePersonal":
                            FrmDetallePersonal detallePersonal = (FrmDetallePersonal)FrmParent.frmparent.getFormularioActual();
                            break;

                    }
                    break;
                case "Primero":
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
                        case "capapresentacion.FrmPersonal, Text: Personal":
                            FrmPersonal personal = (FrmPersonal)FrmParent.frmparent.getFormularioActual();

                            break;
                        case "capapresentacion.FrmDetallePersonal, Text: FrmDetallePersonal":
                            FrmDetallePersonal detallePersonal = (FrmDetallePersonal)FrmParent.frmparent.getFormularioActual();
                            break;

                    }
                    break;
                case "Atras":
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
                        case "capapresentacion.FrmPersonal, Text: Personal":
                            FrmPersonal personal = (FrmPersonal)FrmParent.frmparent.getFormularioActual();

                            break;
                        case "capapresentacion.FrmDetallePersonal, Text: FrmDetallePersonal":
                            FrmDetallePersonal detallePersonal = (FrmDetallePersonal)FrmParent.frmparent.getFormularioActual();
                            break;

                    }
                    break;
                case "Siguiente":
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
                        case "capapresentacion.FrmPersonal, Text: Personal":
                            FrmPersonal personal = (FrmPersonal)FrmParent.frmparent.getFormularioActual();

                            break;
                        case "capapresentacion.FrmDetallePersonal, Text: FrmDetallePersonal":
                            FrmDetallePersonal detallePersonal = (FrmDetallePersonal)FrmParent.frmparent.getFormularioActual();
                            break;

                    }
                    break;
                case "Final":
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
                        case "capapresentacion.FrmPersonal, Text: Personal":
                            FrmPersonal personal = (FrmPersonal)FrmParent.frmparent.getFormularioActual();

                            break;
                        case "capapresentacion.FrmDetallePersonal, Text: FrmDetallePersonal":
                            FrmDetallePersonal detallePersonal = (FrmDetallePersonal)FrmParent.frmparent.getFormularioActual();
                            break;

                    }
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
            btnNuevo.Visible = true;
            btnEditar.Visible = true;
            visualizaBotonesCambiarFormulario(false);
        }
        public void visualizaBotonGuardar(bool value)
        {
            btnGuardar.Visible = value;
            btnCancelar.Visible = value;
            btnNuevo.Visible = !value;
            btnEditar.Visible = !value;
            btnEliminarProyecto.Visible = !value;
            if (value)
            {
                btnCancelar.Location = new Point(93, 5);
                btnGuardar.Location = new Point(47, 5);
            }
        }


    }
}
