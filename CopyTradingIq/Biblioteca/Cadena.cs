﻿using System;

namespace CopyTradingIq.Biblioteca
{
    public static class Cadena
    {
        public static string Depurar(string cadena)
        {
            //cadena = HttpUtility.HtmlDecode(cadena);
            cadena = cadena.Replace("&#160;", "");
            cadena = cadena.Replace("&nbsp;", "");
            cadena = cadena.Trim();
            return cadena;
        }

        public static bool Vacia(string a)
        {
            try
            {
                // Es nulo??
                if (a == null)
                {
                    return true;
                }

                // Depuramos
                a = Depurar(a);

                // IsNullOrEmpty
                if (string.IsNullOrEmpty(a))
                {
                    return true;
                }

                // IsNullOrWhiteSpace
                if (string.IsNullOrWhiteSpace(a))
                {
                    return true;
                }

                // Vacio
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string Aleatoria(int largo)
        {
            Random random = new Random();
            string combinaciones = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            int longitud = combinaciones.Length;
            string nuevacadena = null;
            for (int i = 0; i < largo; i++)
            {
                char letra = combinaciones[random.Next(longitud)];
                nuevacadena += letra.ToString();
            }
            return nuevacadena;
        }

        public static string GenerarToken()
        {
            return Guid.NewGuid().ToString();
        }
    }
}