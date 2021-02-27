using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyTradingIq.Biblioteca
{
    class Bitacora
    {
        public DateTime Exe { set; get; } = new DateTime(1900, 01, 01);
        public string Message { set; get; } = string.Empty;

        /// <summary>
        /// Add bitacora
        /// </summary>
        /// <param name="list"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public List<Bitacora> Add(List<Bitacora> list, string message)
        {
            // Insertamos
            list.Add(new Bitacora { Exe = DateTime.Now, Message = message });

            // Ordenamos
            list = list.OrderByDescending(x => x.Exe).ToList();

            // Sólo 500
            list = list.Take(150).ToList();

            // Libre de pecados
            return list;
        }

        /// <summary>
        /// Devuelve la lista en string
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public async Task<string> Gen_Async(List<Bitacora> list)
        {
            return await Task.Run(() =>
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (var row in list.OrderByDescending(x => x.Exe))
                {
                    stringBuilder.AppendLine($"{row.Exe} - {row.Message}");
                }

                return $"{stringBuilder}";
            });
        }
    }
}
