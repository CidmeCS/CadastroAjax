using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CadastroAjax.Modelos
{
    internal class MaisTelefone : Form1
    {
        static int espaco = 30;
        internal static void Add(Control tabFornecedor)
        {
            
                if (espaco <= 90)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        MaskedTextBox x = new MaskedTextBox
                        {
                            Location = new System.Drawing.Point(491, 73 + espaco),
                            Mask = "(99) 0000-0000",
                            Name = "mtbTelefone" + espaco,
                            TabIndex = 70 + espaco,
                            Size = new System.Drawing.Size(88, 20)

                        };
                        tabFornecedor.Controls.Add(x);

                    }
                    espaco += 30;
                }
           
        }
    }
}
