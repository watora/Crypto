using System;
using System.Windows.Forms;

namespace CryptoTest
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void GenerateKeyPair_Click(object sender, EventArgs e)
        {
            (string publicKey, string privateKey) = CryptoUtils.RSAUtil.generateRSAKeyPair();
            privateKeyText.Text = privateKey;
            publicKeyText.Text = publicKey;
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            string data = DataText.Text;
            string publicKey = publicKeyText.Text;
            if (!string.IsNullOrEmpty(data) && !string.IsNullOrEmpty(publicKey))
            {
                ContentText.Text = CryptoUtils.RSAUtil.Encrypt(data, publicKey);
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            string content = ContentText.Text;
            string privateKey = privateKeyText.Text;
            if (!string.IsNullOrEmpty(content) && !string.IsNullOrEmpty(privateKey))
            {
                DataText.Text = CryptoUtils.RSAUtil.Decrypt(content, privateKey);
            }
        }
    }
}
