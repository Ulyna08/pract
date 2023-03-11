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
                char[] alphabet = { 'à', 'á', 'â', 'ã', 'ä', 'å', '¸', 'æ', 'ç', 'è', 'é', 'ê', 'ë', 'ì', 'í', 'î', 'ï', 'ð', 'ñ', 'ò', 'ó', 'ô', 'õ', 'ö', '÷', 'ø', 'ù', 'ú', 'û', 'ü', 'ý', 'þ', 'ÿ' };
                char a;
                int index;
                string stringÑ = "";
                for (int i = 0; i < code.Length; i++)
                {

                    a = code[i];
                    if (a == ' ')
                    {
                        stringÑ += l;
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
                    stringÑ += alphabet[index];
                }
                return stringÑ;
            }
        }
        static void Main(string[] args)
        {
            WER myCipher = new WER();
            myCipher.SetCipher("íå ãîíèñü çà òåì, ÷òî ñàìî óõîäèò", 11);
            Console.WriteLine(myCipher.GetCipher());
            myCipher.SetCipher("øï íùøóüæ òê ýï÷, âýù üê÷ù þàùîóý", -11);
            Console.WriteLine(myCipher.GetCipher());
            Console.ReadKey(true);
        }
    }
}