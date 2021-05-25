using System;
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
                            detalleTarea.crearNuevo();
                            visualizaBotonesCambiarFormulario(false);
                            visualizaBotonGuardar(true);
                            break;

                        case "capapresentacion.FrmTiempos, Text: ":
                            FrmTiempos tiempos = (FrmTiempos)FrmParent.frmparent.getFormularioActual();
                            tiempos.nuevoTiempo();
                            visualizaBotonGuardar(true);
                            break;
                        case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":
                            FrmDetalleTiempos detalleTiempos = (FrmDetalleTiempos)FrmParent.frmparent.getFormularioActual();
                            detalleTiempos.nuevoClicado();
                            visualizaBotonesCambiarFormulario(false);
                            visualizaBotonGuardar(true);
                            break;
                        case "capapresentacion.FrmPersonal, Text: Personal":
                            FrmPersonal personal = (FrmPersonal)FrmParent.frmparent.getFormularioActual();
                            personal.nuevaPersonal();
                            visualizaBotonesCambiarFormulario(false);
                            visualizaBotonGuardar(true);
                            break;
                        case "capapresentacion.FrmDetallePersonal, Text: FrmDetallePersonal":
                            FrmDetallePersonal detallePersonal = (FrmDetallePersonal)FrmParent.frmparent.getFormularioActual();
                            detallePersonal.crearNuevo();
                            visualizaBotonesCambiarFormulario(false);
                            visualizaBotonGuardar(true);
                            break;
                        case "capapresentacion.FrmAplicaciones, Text: ":
                            FrmAplicaciones aplicaciones = (FrmAplicaciones)FrmParent.frmparent.getFormularioActual();
                            aplicaciones.nuevaAplicacion();
                            visualizaBotonesCambiarFormulario(false);
                            visualizaBotonGuardar(true);
                            break;
                        case "capapresentacion.FrmDetalleAplicacion, Text: FrmDetalleAplicacion":
                            FrmDetalleAplicacion detalleAplicacion = (FrmDetalleAplicacion)FrmParent.frmparent.getFormularioActual();
                            detalleAplicacion.nuevaAplicacion();
                            visualizaBotonesCambiarFormulario(false);
                            visualizaBotonGuardar(true);
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
                            visualizaBotonesCambiarFormulario(false);
                            break;
                        case "capapresentacion.FrmDetalleTarea, Text: Tarea":
                            FrmDetalleTarea detalleTarea = (FrmDetalleTarea)FrmParent.frmparent.getFormularioActual();
                            detalleTarea.guardarTarea();
                            // detalleTarea.cancelar();
                            visualizaBotonGuardar(false);
                            visualizaBotonesCambiarFormulario(false);
                            break;
                        case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":
                            FrmDetalleTiempos detalleTiempos = (FrmDetalleTiempos)FrmParent.frmparent.getFormularioActual();
                            detalleTiempos.guardar();
                            visualizaBotonGuardar(false);
                            visualizaBotonesCambiarFormulario(false);
                            break;
                        case "capapresentacion.FrmDetallePersonal, Text: FrmDetallePersonal":
                            FrmDetallePersonal detallePersonal = (FrmDetallePersonal)FrmParent.frmparent.getFormularioActual();

                            detallePersonal.guardar();
                            visualizaBotonGuardar(false);
                            visualizaBotonesCambiarFormulario(false);

                            break;                      
                        case "capapresentacion.FrmDetalleAplicacion, Text: FrmDetalleAplicacion":
                            FrmDetalleAplicacion detalleAplicacion = (FrmDetalleAplicacion)FrmParent.frmparent.getFormularioActual();
                            detalleAplicacion.esNuevo();
                            detalleAplicacion.guardar();

                            break;
                        //case "capapresentacion.FrmDetallePersonal, Text: FrmDetallePersonal":
                        //    FrmDetallePersonal detallePersonal = (FrmDetallePersonal)FrmParent.frmparent.getFormularioActual();
                        //    break;
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
                        case "capapresentacion.FrmDetalleTarea, Text: Tarea":
                            FrmDetalleTarea detalleTarea = (FrmDetalleTarea)FrmParent.frmparent.getFormularioActual();
                            detalleTarea.activarEdicion(true);
                            //detalleTarea.cancelar();
                            visualizaBotonesCambiarFormulario(false);
                            visualizaBotonGuardar(true);
                            break;
                        case "capapresentacion.FrmTiempos, Text: ":
                            FrmTiempos tiempos = (FrmTiempos)FrmParent.frmparent.getFormularioActual();
                            tiempos.editarTiempo();
                            visualizaBotonesCambiarFormulario(false);
                            visualizaBotonGuardar(true);
                            break;                        
                        case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":
                            FrmDetalleTiempos detalleTiempos = (FrmDetalleTiempos)FrmParent.frmparent.getFormularioActual();
                            detalleTiempos.botonEditar();
                            visualizaBotonesCambiarFormulario(false);
                            visualizaBotonGuardar(true);
                            break;
                        case "capapresentacion.FrmPersonal, Text: Personal":
                            FrmPersonal personal = (FrmPersonal)FrmParent.frmparent.getFormularioActual();

                            break;
                        case "capapresentacion.FrmDetallePersonal, Text: FrmDetallePersonal":
                            FrmDetallePersonal detallePersonal = (FrmDetallePersonal)FrmParent.frmparent.getFormularioActual();
                            break;
                        case "capapresentacion.FrmAplicaciones, Text: ":
                            FrmAplicaciones aplicaciones = (FrmAplicaciones)FrmParent.frmparent.getFormularioActual();
                            aplicaciones.botonEditar();
                            break;
                        case "capapresentacion.FrmDetalleAplicacion, Text: FrmDetalleAplicacion":
                            FrmDetalleAplicacion detalleAplicacion = (FrmDetalleAplicacion)FrmParent.frmparent.getFormularioActual();
                            detalleAplicacion.botonEditar();
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
                            proyect.setModo("LECTURA");
                            break;
                        case "capapresentacion.FrmDetalleTarea, Text: Tarea":
                            FrmDetalleTarea detalleTarea = (FrmDetalleTarea)FrmParent.frmparent.getFormularioActual();
                            visualizaBotonesCambiarFormulario(true);
                            visualizaBotonGuardar(false);
                            detalleTarea.cancelar();
                            break;
                        case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":
                            FrmDetalleTiempos detalleTiempos = (FrmDetalleTiempos)FrmParent.frmparent.getFormularioActual();
                            visualizaBotonesCambiarFormulario(true);
                            visualizaBotonGuardar(false);
                            detalleTiempos.cancelar();
                            break;
                        case "capapresentacion.FrmPersonal, Text: Personal":
                            FrmPersonal personal = (FrmPersonal)FrmParent.frmparent.getFormularioActual();
                            visualizaBotonesCambiarFormulario(true);
                            visualizaBotonGuardar(false);
                            //personal.cancelar();
                            break;
                        case "capapresentacion.FrmDetallePersonal, Text: FrmDetallePersonal":
                            FrmDetallePersonal detallePersonal = (FrmDetallePersonal)FrmParent.frmparent.getFormularioActual();
                            break;
                        case "capapresentacion.FrmDetalleAplicacion, Text: FrmDetalleAplicacion":
                            FrmDetalleAplicacion detalleAplicacion = (FrmDetalleAplicacion)FrmParent.frmparent.getFormularioActual();
                            visualizaBotonesCambiarFormulario(true);
                            visualizaBotonGuardar(false);
                            detalleAplicacion.cancelar();
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
                        case "capapresentacion.FrmTiempos, Text: ":
                            FrmTiempos tiempos = (FrmTiempos)FrmParent.frmparent.getFormularioActual();
                            tiempos.botonEliminarTiempo();
                            break;
                        case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":
                            FrmDetalleTiempos detalleTiempos = (FrmDetalleTiempos)FrmParent.frmparent.getFormularioActual();
                            detalleTiempos.botonEliminarTiempo();
                            visualizaBotonGuardar(false);
                            visualizaBotonesCambiarFormulario(false);
                            break;
                        case "capapresentacion.FrmPersonal, Text: Personal":
                            FrmPersonal personal = (FrmPersonal)FrmParent.frmparent.getFormularioActual();

                            break;
                        case "capapresentacion.FrmDetallePersonal, Text: FrmDetallePersonal":
                            FrmDetallePersonal detallePersonal = (FrmDetallePersonal)FrmParent.frmparent.getFormularioActual();
                            break;
                        case "capapresentacion.FrmAplicaciones, Text: ":
                            FrmAplicaciones aplicaciones = (FrmAplicaciones)FrmParent.frmparent.getFormularioActual();
                            aplicaciones.botonEliminarAplicacionPrincipal();
                            break;
                        case "capapresentacion.FrmDetalleAplicacion, Text: FrmDetalleAplicacion":
                            FrmDetalleAplicacion detalleAplicacion = (FrmDetalleAplicacion)FrmParent.frmparent.getFormularioActual();
                            detalleAplicacion.botonEliminar();
                            visualizaBotonGuardar(false);
                            visualizaBotonesCambiarFormulario(false);
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
                        case "capapresentacion.FrmDetalleTarea, Text: Tarea":
                            FrmDetalleTarea detalleTarea = (FrmDetalleTarea)FrmParent.frmparent.getFormularioActual();
                            detalleTarea.primero();
                            break;
                        case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":
                            FrmDetalleTiempos detalleTiempos = (FrmDetalleTiempos)FrmParent.frmparent.getFormularioActual();
                            detalleTiempos.botonPrimero();
                            break;
                        case "capapresentacion.FrmPersonal, Text: Personal":
                            FrmPersonal personal = (FrmPersonal)FrmParent.frmparent.getFormularioActual();

                            break;
                        case "capapresentacion.FrmDetallePersonal, Text: FrmDetallePersonal":
                            FrmDetallePersonal detallePersonal = (FrmDetallePersonal)FrmParent.frmparent.getFormularioActual();
                            break;
                        case "capapresentacion.FrmDetalleAplicacion, Text: FrmDetalleAplicacion":
                            FrmDetalleAplicacion detalleAplicacion = (FrmDetalleAplicacion)FrmParent.frmparent.getFormularioActual();
                            detalleAplicacion.botonPrimero();
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
                        case "capapresentacion.FrmDetalleTarea, Text: Tarea":
                            FrmDetalleTarea detalleTarea = (FrmDetalleTarea)FrmParent.frmparent.getFormularioActual();
                            detalleTarea.atras();
                            break;
                        case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":
                            FrmDetalleTiempos detalleTiempos = (FrmDetalleTiempos)FrmParent.frmparent.getFormularioActual();
                            detalleTiempos.botonAtras();
                            break;
                        case "capapresentacion.FrmPersonal, Text: Personal":
                            FrmPersonal personal = (FrmPersonal)FrmParent.frmparent.getFormularioActual();

                            break;
                        case "capapresentacion.FrmDetallePersonal, Text: FrmDetallePersonal":
                            FrmDetallePersonal detallePersonal = (FrmDetallePersonal)FrmParent.frmparent.getFormularioActual();
                            break;
                        case "capapresentacion.FrmDetalleAplicacion, Text: FrmDetalleAplicacion":
                            FrmDetalleAplicacion detalleAplicacion = (FrmDetalleAplicacion)FrmParent.frmparent.getFormularioActual();
                            detalleAplicacion.botonAtras();
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
                        case "capapresentacion.FrmDetalleTarea, Text: Tarea":
                            FrmDetalleTarea detalleTarea = (FrmDetalleTarea)FrmParent.frmparent.getFormularioActual();
                            detalleTarea.siguiente();
                            break;
                        case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":
                            FrmDetalleTiempos detalleTiempos = (FrmDetalleTiempos)FrmParent.frmparent.getFormularioActual();
                            detalleTiempos.botonSiguiente();
                            break;
                        case "capapresentacion.FrmPersonal, Text: Personal":
                            FrmPersonal personal = (FrmPersonal)FrmParent.frmparent.getFormularioActual();

                            break;
                        case "capapresentacion.FrmDetallePersonal, Text: FrmDetallePersonal":
                            FrmDetallePersonal detallePersonal = (FrmDetallePersonal)FrmParent.frmparent.getFormularioActual();
                            break;
                        case "capapresentacion.FrmDetalleAplicacion, Text: FrmDetalleAplicacion":
                            FrmDetalleAplicacion detalleAplicacion = (FrmDetalleAplicacion)FrmParent.frmparent.getFormularioActual();
                            detalleAplicacion.botonSiguiente();
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
                        case "capapresentacion.FrmDetalleTarea, Text: Tarea":
                            FrmDetalleTarea detalleTarea = (FrmDetalleTarea)FrmParent.frmparent.getFormularioActual();
                            detalleTarea.botonUltimo();
                            break;
                        case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":
                            FrmDetalleTiempos detalleTiempos = (FrmDetalleTiempos)FrmParent.frmparent.getFormularioActual();
                            detalleTiempos.botonFinal();
                            break;
                        case "capapresentacion.FrmPersonal, Text: Personal":
                            FrmPersonal personal = (FrmPersonal)FrmParent.frmparent.getFormularioActual();

                            break;
                        case "capapresentacion.FrmDetallePersonal, Text: FrmDetallePersonal":
                            FrmDetallePersonal detallePersonal = (FrmDetallePersonal)FrmParent.frmparent.getFormularioActual();
                            break;
                        case "capapresentacion.FrmDetalleAplicacion, Text: FrmDetalleAplicacion":
                            FrmDetalleAplicacion detalleAplicacion = (FrmDetalleAplicacion)FrmParent.frmparent.getFormularioActual();
                            detalleAplicacion.botonFinal();
                            break;
                    }
                    break;
                case "Volver":
                    switch (FrmParent.frmparent.getFormularioActual().ToString())
                    {
                        case "capapresentacion.FrmDetalleProyecto, Text: Proyecto":
                            FrmDetalleProyecto proyect = (FrmDetalleProyecto)FrmParent.frmparent.getFormularioActual();
                            proyect.volver();
                            break;
                        case "capapresentacion.FrmDetalleTarea, Text: Tarea":
                            FrmDetalleTarea detalleTarea = (FrmDetalleTarea)FrmParent.frmparent.getFormularioActual();
                            detalleTarea.volver();
                            break;
                        case "capapresentacion.FrmDetalleTiempos, Text: FrmDetalleTiempos":
                            FrmDetalleTiempos detalleTiempos = (FrmDetalleTiempos)FrmParent.frmparent.getFormularioActual();
                            detalleTiempos.volver();
                            break;
                        case "capapresentacion.FrmDetallePersonal, Text: FrmDetallePersonal":
                            FrmDetallePersonal detallePersonal = (FrmDetallePersonal)FrmParent.frmparent.getFormularioActual();
                            detallePersonal.volver();
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
            btnEliminarProyecto.Visible = true;
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

        private void btn_volver_Click(object sender, EventArgs e)
        {
            controlDeBotones("Volver");
            //activaBarraHorizontal();
            StaticBarraHorizontal.horizontalParent.botonesPrincipal();
        }
    }
}
