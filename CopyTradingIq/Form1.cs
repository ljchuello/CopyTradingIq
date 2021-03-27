using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CopyTradingIq.Biblioteca;
using MetroFramework.Forms;

namespace CopyTradingIq
{
    public partial class Form1 : MetroForm
    {
        // Bitacora
        private Bitacora bitacora = new Bitacora();
        private List<Bitacora> bitacoras = new List<Bitacora>();

        public Form1()
        {
            // Iniciamos
            InitializeComponent();

            // Seteamos nos paramos en el tab 1
            TabControl.SelectedTab = tabStatus;

            // Deshabilitamos el error multiTask
            CheckForIllegalCrossThreadCalls = false;

            // Ocultamos los botones
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;

            // No ReSize
            Resizable = false;

            // Título
            Text = "Iq Option (Copy Trading)";

            // Añadimos a la bitacora
            bitacora.Add(bitacoras, "Open program (Not started)");

            // Bitacora
            Bitacora_Refrescar_Async();
        }

        // Cerrar programa
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        #region Bitacora

        async Task Bitacora_Refrescar_Async()
        {
            await Task.Run(async () =>
            {
                while (true)
                {
                    try
                    {
                        // Seteamos a sólo 500
                        bitacoras = bitacoras.OrderByDescending(x => x.Exe).Take(500).ToList();

                        // Generamos
                        txtLogs.Text = await bitacora.Gen_Async(bitacoras);

                        // Esperamos
                        Thread.Sleep(25);
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }
            });
        }

        #endregion
    }
}
