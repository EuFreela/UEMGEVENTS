using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uemgevent.classes
{
    class Hash
    {
        public string ValueHash;

        public String SetValueHash(string value)
        {
            try
            {
                byte[] buffer = Encoding.Default.GetBytes(value);
                System.Security.Cryptography.SHA1CryptoServiceProvider cryptoTransformSHA1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
                this.ValueHash = BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
            return this.ValueHash.ToLower();
        }      

        public String GetValueHash()
        {
            return this.ValueHash.ToLower();
        }

        public String GerarMatricula(int tamanho)
        {
            int Tamanho = tamanho;
            string senha = string.Empty;
            for (int i = 0; i < Tamanho; i++)
            {
                Random random = new Random();
                int codigo = Convert.ToInt32(random.Next(48, 122).ToString());

                if ((codigo >= 48 && codigo <= 57) || (codigo >= 97 && codigo <= 122))
                {
                    string _char = ((char)codigo).ToString();
                    if (!senha.Contains(_char))
                    {
                        senha += _char;
                    }
                    else
                    {
                        i--;
                    }
                }
                else
                {
                    i--;
                }
            }
            return senha;
        }
    }
}
