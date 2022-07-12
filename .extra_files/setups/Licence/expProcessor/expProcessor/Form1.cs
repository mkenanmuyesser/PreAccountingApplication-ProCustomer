using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Security.Cryptography;
using System.IO;
using System.Net.NetworkInformation;
using Microsoft.Win32;
using System.Data.SqlClient;

namespace expProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NetworkInterface[] arayuz;
            arayuz = NetworkInterface.GetAllNetworkInterfaces();
            NetworkInterfaceType type;
            type = arayuz[0].NetworkInterfaceType;
            PhysicalAddress mac;
            mac = arayuz[0].GetPhysicalAddress();
            String mac2 = mac.ToString();
            string sifre = Crypto.EncryptStringAES(mac2, "10081008");
            string cozulen = Crypto.DecryptStringAES(sifre, "10081008");
            textBox1.Text = sifre;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kategoriler = "";
            foreach (var item in checkedListBox1.CheckedItems)
            {
                kategoriler += item.ToString() + ";";
            }
            RegistryKey MyReg = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AtolyaTeknoloji\ProgramKey");
            MyReg.SetValue("ky", textBox1.Text);
            MyReg.SetValue("kategori", kategoriler);
            MyReg.SetValue("firma", textBox5.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                SqlConnection cnn = new SqlConnection(@"server=.\SQLEXPRESS;database=master;trusted_connection=true");
                try
                {
                    string dosyaadi = openFileDialog1.FileName;
                    
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnn;
                    if (dosyaadi.Contains("logistic"))
                    {
                        cmd.CommandText = "restore database ProLogisticDB from disk='" + dosyaadi + "'";
                    }
                    else if (dosyaadi.Contains("beauty"))
                    {
                        cmd.CommandText = "restore database ProBeautyDB from disk='" + dosyaadi + "'";
                    }
                    else if (dosyaadi.Contains("customer"))
                    {
                        cmd.CommandText = "restore database ProCustomerDB from disk='" + dosyaadi + "'";
                    }
                    else if (dosyaadi.Contains("pet"))
                    {
                        cmd.CommandText = "restore database ProPetDB from disk='" + dosyaadi + "'";
                    }
                    else if (dosyaadi.Contains("gold"))
                    {
                        cmd.CommandText = "restore database ProGoldDB from disk='" + dosyaadi + "'";
                    }
                    else if (dosyaadi.Contains("health"))
                    {
                        cmd.CommandText = "restore database ProHealthDB from disk='" + dosyaadi + "'";
                    }
                    else if (dosyaadi.Contains("manager"))
                    {
                        cmd.CommandText = "restore database ProManagerDB from disk='" + dosyaadi + "'";
                    }
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("İşlem başarılı.");
                }
                catch
                {
                    cnn.Close();
                    MessageBox.Show("İşlem başarısız.");
                }
            }
        }

    }

    public class Crypto
    {
        private static byte[] _salt = Encoding.ASCII.GetBytes("o6806642kbM7c5");

        /// <summary>
        /// Encrypt the given string using AES.  The string can be decrypted using 
        /// DecryptStringAES().  The sharedSecret parameters must match.
        /// </summary>
        /// <param name="plainText">The text to encrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for encryption.</param>
        public static string EncryptStringAES(string plainText, string sharedSecret)
        {
            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentNullException("plainText");
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException("sharedSecret");

            string outStr = null;                       // Encrypted string to return
            RijndaelManaged aesAlg = null;              // RijndaelManaged object used to encrypt the data.

            try
            {
                // generate the key from the shared secret and the salt
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);

                // Create a RijndaelManaged object
                aesAlg = new RijndaelManaged();
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    // prepend the IV
                    msEncrypt.Write(BitConverter.GetBytes(aesAlg.IV.Length), 0, sizeof(int));
                    msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                    }
                    outStr = Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
            finally
            {
                // Clear the RijndaelManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }

            // Return the encrypted bytes from the memory stream.
            return outStr;
        }

        /// <summary>
        /// Decrypt the given string.  Assumes the string was encrypted using 
        /// EncryptStringAES(), using an identical sharedSecret.
        /// </summary>
        /// <param name="cipherText">The text to decrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for decryption.</param>
        public static string DecryptStringAES(string cipherText, string sharedSecret)
        {
            if (string.IsNullOrEmpty(cipherText))
                throw new ArgumentNullException("cipherText");
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException("sharedSecret");

            // Declare the RijndaelManaged object
            // used to decrypt the data.
            RijndaelManaged aesAlg = null;

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            try
            {
                // generate the key from the shared secret and the salt
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);

                // Create the streams used for decryption.                
                byte[] bytes = Convert.FromBase64String(cipherText);
                using (MemoryStream msDecrypt = new MemoryStream(bytes))
                {
                    // Create a RijndaelManaged object
                    // with the specified key and IV.
                    aesAlg = new RijndaelManaged();
                    aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                    // Get the initialization vector from the encrypted stream
                    aesAlg.IV = ReadByteArray(msDecrypt);
                    // Create a decrytor to perform the stream transform.
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                    }
                }
            }
            finally
            {
                // Clear the RijndaelManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }

            return plaintext;
        }

        private static byte[] ReadByteArray(Stream s)
        {
            byte[] rawLength = new byte[sizeof(int)];
            if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
            {
                throw new SystemException("Stream did not contain properly formatted byte array");
            }

            byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
            if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
            {
                throw new SystemException("Did not read byte array properly");
            }

            return buffer;
        }
    }
}
