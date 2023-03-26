using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;

namespace ConsultaCEP
{
    public partial class ConsultaCEP : Form
    {

        public ConsultaCEP()
        {
            //Inicialize the coponents of WF
            InitializeComponent();
        }

        //Allows just numbers in the CEP masked text box
        private void mskCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Checks if the masked text box have a CEP to search
            if (mskCEP.Text.Trim() == "-")
            {
                MessageBox.Show("Digite um CEP para realizar a busca!");
            }
            else
            {
                //Assign the value of CEP input into variable cepText
                String cepText = mskCEP.Text;
                //Define the chars to trim in the response of API
                char[] charsToTrim = { ',', ' ', '\'', '"' };

                //Creat a new HttpClient
                using var client = new HttpClient();
                //Creat the base adress of API
                client.BaseAddress = new Uri("https://viacep.com.br/ws/");
                //Define the type response API
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    //Assign to the "response" variable the response of API
                    HttpResponseMessage response = client.GetAsync(cepText + "/json").Result;
                    response.EnsureSuccessStatusCode();

                    //Checks if the API it sent a response
                    if (response.IsSuccessStatusCode)
                    {
                        //Assign to the "result" variable the response of API
                        var result = response.Content.ReadAsStringAsync().Result;

                        //Split the response between lines
                        String[] splitResult = result.Split('\n');

                        //Checking if the response is a error
                        String erro = splitResult[1].Split(":")[1];
                        String erroTrimmed = erro.Trim(charsToTrim);
                        if (erroTrimmed == "true")
                        {
                            MessageBox.Show("CEP Inválido!");
                        }
                        else
                        {
                            //Aassigning values ​​to labels
                            String end = splitResult[2].Split(":")[1];
                            String endTrimmed = end.Trim(charsToTrim);
                            txtEndereco.Text = endTrimmed;
                            txtEndereco.Enabled = true;

                            String bairro = splitResult[4].Split(":")[1];
                            String bairroTrimmed = bairro.Trim(charsToTrim);
                            txtBairro.Text = bairroTrimmed;
                            txtBairro.Enabled = true;

                            String cidade = splitResult[5].Split(":")[1];
                            String cidadeTrimmed = cidade.Trim(charsToTrim);
                            txtCidade.Text = cidadeTrimmed;
                            txtCidade.Enabled = true;

                            String estado = splitResult[6].Split(":")[1];
                            String estadoTrimmed = estado.Trim(charsToTrim);
                            txtEstado.Text = estadoTrimmed;
                            txtEstado.Enabled = true;
                        }
                    }

                }
                //Exception message
                catch (HttpRequestException ex)
                {
                    if (ex.StatusCode == HttpStatusCode.BadRequest)
                    {
                        MessageBox.Show("O servidor retornou um erro do tipo: HTTP 400 (Bad Request). \n" +
                            "Verifique o CEP digitado e tente novamente! \n" +
                            "Se o erro persistir, entre em contato com o suporte.");
                    }
                    else
                    {
                        MessageBox.Show($"O servidor retornou uma exceção do tipo: {ex.Message}");
                    }
                }

            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
                txtEndereco.Text = null;
                txtBairro.Text = null;
                txtCidade.Text = null;
                txtEstado.Text = null;
                mskCEP.Text = null;
                txtEstado.Enabled = false;
                txtEndereco.Enabled = false;
                txtBairro.Enabled = false;
                txtCidade.Enabled = false;
            }
    }
}