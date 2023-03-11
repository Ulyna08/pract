using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HY
{
    internal class Program
    {
        class WER
        {
            private string str;
            private int shift;
            public string GetCipher()
            {
                return str;
            }
            public void SetCipher(string code, int shift)
            {
                this.str = EncryptStr(code, shift);
                this.shift = shift;
            }
            private string EncryptStr(string code, int shift)
            {
                char[] alphabet = { '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�' };
                char a;
                int index;
                string string� = "";
                for (int i = 0; i < code.Length; i++)
                {

                    a = code[i];
                    if (a == ' ')
                    {
                        string� += l;
                        continue;
                    }
                    index = Array.IndexOf(alphabet, a);
                    index += shift;
                    if (index > 32)
                    {
                        index -= 33;
                    } else if (index < 0)
                    {
                        index += 33;
                    }
                    string� += alphabet[index];
                }
                return string�;
            }
        }
        static void Main(string[] args)
        {
            WER myCipher = new WER();
            myCipher.SetCipher("�� ������ �� ���, ��� ���� ������", 11);
            Console.WriteLine(myCipher.GetCipher());
            myCipher.SetCipher("�� ������ �� ���, ��� ���� ������", -11);
            Console.WriteLine(myCipher.GetCipher());
            Console.ReadKey(true);
        }
    }
}