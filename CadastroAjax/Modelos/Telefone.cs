using System;
using System.Text;
using System.Windows.Forms;

namespace CadastroAjax.Modelos
{
    internal class Telefone
    {
        
        internal static StringBuilder Buscar(TabPage tabFornecedor)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Control controle in tabFornecedor.Controls)
            {
                if (controle.Name.Contains("mtbTelefone"))
                {
                    sb.Append(controle.Text + "; ");
                }
                
            }
            sb.Remove(sb.Length - 2,2);
            return sb;
        }
    }
}