namespace WinCEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconsu_Click(object sender, EventArgs e)
        {
            ConsultaCEP consultaCEP = new ConsultaCEP();
            CEP cep = consultaCEP.Consultar(txtCEP.Text);
            txtendereco.Text = cep.Lagradouro;
            txtCidade.Text = $"{cep.localidade} {cep.Uf}";
            txtbairro.Text = cep.bairro;    

        }
    }
}