using System.Net;
using System.Text.RegularExpressions;

namespace ConsultaCEP
{
    public partial class Form1 : Form
    {
        HttpClient client = null;
        public Form1()
        {
            //Inicialize the coponents of WF
            InitializeComponent();
            //Creat a new HttpClient
            client = new HttpClient();
            //Creat the base adress of API
            client.BaseAddress = new Uri("https://viacep.com.br/ws/");
            //Define the type response API
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            //Assign the value of CEP input into variable cepText
            String cepText = txtCEP.Text.Trim();
            //Define the chars to trim in the response of API
            char[] charsToTrim = { ',', ' ', '\'', '"' };

            //Assign to the "response" variable the response of API
            HttpResponseMessage response = client.GetAsync(cepText + "/json").Result;
            //Check if the API it sent a response
            if (response.IsSuccessStatusCode)
            {
                //Assign to the "result" variable the response of API
                var result = response.Content.ReadAsStringAsync().Result;
                
                String[] splitResult = result.Split('\n');
                String erro = splitResult[1].Split(":")[1];
                String erroTrimmed = erro.Trim(charsToTrim);
                
                if(erroTrimmed == "true")
                {
                    MessageBox.Show("CPF Inv�lido!");
                }
                else
                {
                    String end = splitResult[2].Split(":")[1];
                    String endTrimmed = end.Trim(charsToTrim);
                    txtEndereco.Text = endTrimmed;

                    String bairro = splitResult[4].Split(":")[1];
                    String bairroTrimmed = bairro.Trim(charsToTrim);
                    txtBairro.Text = bairroTrimmed;

                    String cidade = splitResult[5].Split(":")[1];
                    String cidadeTrimmed = cidade.Trim(charsToTrim);
                    txtCidade.Text = cidadeTrimmed;

                    String estado = splitResult[6].Split(":")[1];
                    String estadoTrimmed = estado.Trim(charsToTrim);
                    txtEstado.Text = estadoTrimmed;
                }
            }
        }
    }
}