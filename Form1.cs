using System.IO;
using System.Collections.Concurrent;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEncrypt
{
    public partial class Form1 : Form
    {

        public class TripleDes
        {



            public static string Encrypt(string TextToEncrypt, string securityKEY)
            {
                var desCryptoProvider = TripleDES.Create();
                var hashMD5Provider=MD5.Create();

                byte[] byteHash;
                byte[] byteBuff;

                byteHash=hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(securityKEY));
                desCryptoProvider.Key = byteHash;
                desCryptoProvider.Mode = CipherMode.ECB;
                byteBuff=Encoding.UTF8.GetBytes(TextToEncrypt);

                string encoded =
                    Convert.ToBase64String(desCryptoProvider.CreateEncryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
                return encoded;


            }

            public static string Decrypt(string TextToDecrypt, string securityKEY)
            {
                var desCryptoProvider = TripleDES.Create();
                var hashMD5Provider = MD5.Create();

                byte[] byteHash;
                byte[] byteBuff;

                byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(securityKEY));
                desCryptoProvider.Key = byteHash;
                desCryptoProvider.Mode = CipherMode.ECB;
                byteBuff = Convert.FromBase64String(TextToDecrypt);

                string plaintext = Encoding.UTF8.GetString(desCryptoProvider.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));

                return plaintext;

            }








        }


        public Form1()
        {
            InitializeComponent();
        }

        private void bttn_SelectKeyDOC_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                label_docName.Text = dlg.FileName;
                textbox_selection.Text = dlg.FileName;

            }
        }

        public void bttn_takeyourKEY_Click(object sender, EventArgs e)
        {
            byte[] DOC = File.ReadAllBytes(label_docName.Text);
            for (int i = 0; i < DOC.Length; i++)
            {
                DOC[i] = (byte)(((int)DOC[i] - 5) * 11);
                if (DOC[i] > 0)
                {
                    DOC[i] = 255;
                }
            }
            File.WriteAllBytes(label_docName.Text, DOC);
            string key = System.IO.File.ReadAllText(textbox_selection.Text);
            MessageBox.Show("Key Taking SUCCESFULL..!/n Please be sure take to right key document..!!");
            DOC = File.ReadAllBytes(label_docName.Text);
            for (int i = 0; i < DOC.Length; i++)
            {
                DOC[i] = (byte)(((int)DOC[i] + 5) / 11);
                if (DOC[i] > 255)
                {
                    DOC[i] = 0;
                }
            }
        }

        private void bttn_createKEY_Click(object sender, EventArgs e)
        {
            int pathSelectOK = 0;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string SelectedPath = fbd.SelectedPath;
                label_selectionPath.Text = SelectedPath;
                pathSelectOK = 1;
            }
            Random rand = new Random();
            int RandomKey = rand.Next(100000000, 1000000000);
            if (pathSelectOK == 1)
            {
                FileStream fs = new FileStream(label_selectionPath.Text + "\\KEY.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(RandomKey);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
            pathSelectOK = 0;
            byte[] keyDOC = File.ReadAllBytes(label_selectionPath.Text + "\\KEY.txt");
            for (int i = 0; i < keyDOC.Length; i++)
            {

                keyDOC[i] = (byte)(((int)keyDOC[i] + 5) / 11);
                if (keyDOC[i] > 255)
                {
                    keyDOC[i] = 0;
                }

            }
            File.WriteAllBytes(label_selectionPath.Text + "\\KEY.txt", keyDOC);
        }

        public void bttn_Encrypt_Click(object sender, EventArgs e)
        {

            if (label_docName != "Selection")
            {

                byte[] DOC = File.ReadAllBytes(label_docName.Text);
                for (int i = 0; i < DOC.Length; i++)
                {
                    DOC[i] = (byte)(((int)DOC[i] - 5) * 11);
                    if (DOC[i] > 0)
                    {
                        DOC[i] = 255;
                    }
                }
                File.WriteAllBytes(label_docName.Text, DOC);
                string key = System.IO.File.ReadAllText(textbox_selection.Text);
                MessageBox.Show("Key Taking SUCCESFULL..!/n Please be sure take to right key document..!!");
                DOC = File.ReadAllBytes(label_docName.Text);
                for (int i = 0; i < DOC.Length; i++)
                {
                    DOC[i] = (byte)(((int)DOC[i] + 5) / 11);
                    if (DOC[i] > 255)
                    {
                        DOC[i] = 0;
                    }
                }
                textBox_ResultMessage.Text = TripleDes.Encrypt(textBox_message.Text, Convert.ToString(key));
            }
            else
                MessageBox.Show("Please Select a Path for Key Document...!!!");

        }

        private void bttn_DeCrypt_Click(object sender, EventArgs e)
        {
            byte[] DOC = File.ReadAllBytes(label_docName.Text);
            for (int i = 0; i < DOC.Length; i++)
            {
                DOC[i] = (byte)(((int)DOC[i] - 5) * 11);
                if (DOC[i] > 0)
                {
                    DOC[i] = 255;
                }
            }
            File.WriteAllBytes(label_docName.Text, DOC);
            string key = System.IO.File.ReadAllText(textbox_selection.Text);
            MessageBox.Show("Key Taking SUCCESFULL..!/n Please be sure take to right key document..!!");
            DOC = File.ReadAllBytes(label_docName.Text);
            for (int i = 0; i < DOC.Length; i++)
            {
                DOC[i] = (byte)(((int)DOC[i] + 5) / 11);
                if (DOC[i] > 255)
                {
                    DOC[i] = 0;
                }
            }
            textBox_ResultMessage.Text = TripleDes.Decrypt(textBox_message.Text, Convert.ToString(key));

        }
    }
}