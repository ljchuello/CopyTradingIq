using System.Windows.Forms;

namespace CopyTradingIq.Biblioteca
{
    public class Notificacion
    {
        public static void Info(string msg)
        {
            MessageBox.Show(msg, "Importante!.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Err(string msg)
        {
            MessageBox.Show(msg, "Ah ocurrido un error =(", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
