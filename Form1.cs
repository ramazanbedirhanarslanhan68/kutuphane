namespace kutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void kt_ek_Click(object sender, EventArgs e)
        {
            // ktp_ekl_form adýndaki formun bir örneðini oluþturun
            ktp_ekl_form ktpEklForm = new ktp_ekl_form();

            // ktp_ekl_form'u gösterin
            ktpEklForm.Show();
            // Ýstediðiniz þekilde mevcut formu gizleyebilir veya kapatabilirsiniz
            this.Hide();
        }

        private void emn_ver_Click(object sender, EventArgs e)
        {

        }
    }
}