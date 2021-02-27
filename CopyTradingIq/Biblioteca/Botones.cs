using System.Windows.Forms;

namespace CopyTradingIq.Biblioteca
{
    public class Botones
    {
        public static void Bloq(Button button)
        {
            button.Enabled = false;
        }
        public static void UnBloq(Button button)
        {
            button.Enabled = true;
        }
    }
}
