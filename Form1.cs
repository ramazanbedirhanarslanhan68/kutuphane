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
            // ktp_ekl_form ad�ndaki formun bir �rne�ini olu�turun
            ktp_ekl_form ktpEklForm = new ktp_ekl_form();

            // ktp_ekl_form'u g�sterin
            ktpEklForm.Show();
            // �stedi�iniz �ekilde mevcut formu gizleyebilir veya kapatabilirsiniz
            this.Hide();
        }

        private void emn_ver_Click(object sender, EventArgs e)
        {

        }
    }
}