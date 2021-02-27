using System;
using System.Linq;
using System.Threading.Tasks;
using IqOptionApiDotNet;
using IqOptionApiDotNet.Models;
using Newtonsoft.Json;

namespace CopyTradingIq.Biblioteca
{
    public class IqOptionWs
    {
        /// <summary>
        /// Indica si fué efectivo o no el inicio de sesión
        /// </summary>
        /// <param name="usr"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public async Task<Resultado> ValidarDatos(string usr, string pass)
        {
            return await Task.Run(async () =>
            {
                try
                {
                    // Iniciamos sesion
                    IqOptionApiDotNetClient iqOptionApiDotNetClient = new IqOptionApiDotNetClient(usr, pass);

                    // Esperamos
                    if (await iqOptionApiDotNetClient.ConnectAsync())
                    {
                        // Libre de pecados
                        return Resultado.Si(iqOptionApiDotNetClient);

                    }
                    else
                    {
                        return Resultado.No("No se ha podido iniciar sesión, usuario ó contraseña incorrecta");
                    }
                }
                catch (Exception ex)
                {
                    return Resultado.No($"Inicio de sesión no fué válido; {ex.Message}");
                }
            });
        }

        /// <summary>
        /// Se ejecuta esta función para que mantenga activa la sesión
        /// </summary>
        /// <param name="iqOptionApiDotNetClient"></param>
        /// <returns></returns>
        public async Task MantenerActivo(IqOptionApiDotNetClient iqOptionApiDotNetClient)
        {
            await Task.Run(async () =>
            {
                CandleCollections candleCollections = await iqOptionApiDotNetClient.GetCandlesAsync(Cadena.GenerarToken(), ActivePair.EURUSD, TimeFrame.Sec15, 1, DateTimeOffset.Now);
                CandleInfo candleInfo = candleCollections.Infos.FirstOrDefault() ?? new CandleInfo();
                Fichero.Guardar($"{Fichero.Ruta}\\{ActivePair.EURUSD}-test.json", JsonConvert.SerializeObject(candleInfo, Formatting.Indented));
            });
        }
    }
}
