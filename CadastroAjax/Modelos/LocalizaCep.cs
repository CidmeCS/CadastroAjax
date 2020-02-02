using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using CadastroAjax.Entidades;
using System.Windows.Forms;

namespace CadastroAjax.Modelos
{
    internal class LocalizaCep
    {
        static readonly HttpClient client = new HttpClient();
        public LocalizaCep()
        {

        }
        internal static async Task<Empresa> StartAsync(string cep)
        {
            Empresa adress = new Empresa();
            HttpResponseMessage response = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
            if (response.StatusCode.ToString() == "OK")
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                adress = (Empresa)JsonConvert.DeserializeObject(responseBody,typeof(Empresa));
            }
            else
            {
                MessageBox.Show("Cep invalido");
            }
            return adress;
        }
    }
}