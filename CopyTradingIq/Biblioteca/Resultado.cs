namespace CopyTradingIq.Biblioteca
{
    public class Resultado
    {
        public bool Success { set; get; } = false;
        public string Messages { set; get; } = string.Empty;
        public dynamic Result { set; get; } = false;

        public static Resultado No(string msj)
        {
            Resultado resultado = new Resultado();
            resultado.Success = false;
            resultado.Messages = msj;
            resultado.Result = null;
            return resultado;
        }

        public static Resultado Si()
        {
            Resultado resultado = new Resultado();
            resultado.Success = true;
            resultado.Messages = "";
            resultado.Result = null;
            return resultado;
        }

        public static Resultado Si(object obj)
        {
            Resultado resultado = new Resultado();
            resultado.Success = true;
            resultado.Messages = "";
            resultado.Result = obj;
            return resultado;
        }

        public static Resultado Si(string msj, object obj)
        {
            Resultado resultado = new Resultado();
            resultado.Success = true;
            resultado.Messages = msj;
            resultado.Result = obj;
            return resultado;
        }
    }
}
