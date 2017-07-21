using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    struct Converting
    {
        public static string Encrypt(int key, string message)
        {
            string result = string.Empty;

            for (int i = 0; i < message.Length; ++i)
            {
                char ch = message[i];

                if (ch >= 'a' && ch <= 'z')
                {
                    ch = Convert.ToChar(ch + key);

                    if (ch > 'z')
                    {
                        ch = Convert.ToChar(ch - 'z' + 'a' - 1);
                    }

                    result += ch;
                }
                else if (ch >= 'A' && ch <= 'Z')
                {
                    ch = Convert.ToChar(ch + key);

                    if (ch > 'Z')
                    {
                        ch = Convert.ToChar(ch - 'Z' + 'A' - 1);
                    }

                    result += ch;
                }
                else if (ch >= 'а' && ch <= 'п' || ch >= 'р' && ch <= 'я')
                {
                    ch = Convert.ToChar(ch + key);

                    if (ch > 'я')
                    {
                        ch = Convert.ToChar(ch - 'я' + 'а' - 1);
                    }

                    result += ch;
                }
                else if (ch >= 'А' && ch <= 'Я')
                {
                    ch = Convert.ToChar(ch + key);

                    if (ch > 'Я')
                    {
                        ch = Convert.ToChar(ch - 'Я' + 'А' - 1);
                    }

                    result += ch;
                }
            }
            return result;
        }

        public static string Decrypt(int key, string message)
        {
            string result = string.Empty;

            for (int i = 0; i < message.Length; ++i)
            {
                char ch = message[i];

                if (ch >= 'a' && ch <= 'z')
                {
                    ch = Convert.ToChar(ch - key);

                    if (ch < 'a')
                    {
                        ch = Convert.ToChar(ch + 'z' - 'a' + 1);
                    }

                    result += ch;
                }
                else if (ch >= 'A' && ch <= 'Z')
                {
                    ch = Convert.ToChar(ch - key);

                    if (ch < 'A')
                    {
                        ch = Convert.ToChar(ch + 'Z' - 'A' + 1);
                    }

                    result += ch;
                }
                else if (ch >= 'а' && ch <= 'п' || ch >= 'р' && ch <= 'я')
                {
                    ch = Convert.ToChar(ch - key);

                    if (ch < 'а')
                    {
                        ch = Convert.ToChar(ch + 'я' - 'а' + 1);
                    }

                    result += ch;
                }
                else if (ch >= 'А' && ch <= 'Я')
                {
                    ch = Convert.ToChar(ch - key);

                    if (ch < 'А')
                    {
                        ch = Convert.ToChar(ch + 'Я' - 'А' + 1);
                    }

                    result += ch;
                }
            }
            return result;
        }
    }
}
