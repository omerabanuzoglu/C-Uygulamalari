using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şifreyi Giriniz :");
            string sifre = Console.ReadLine();
            string atilim = "";
            int first = 0;
            int second = 0;
            int third = 0;
            int fourth = 0;
            int fiveth = 0;
            int sixth = 0;
            int seventh = 0;
            int eighth = 0;
            int dokuz = 0;
            int on = 0;
            int onbir = 0;
            int oniki = 0;
            int onuc = 0;
            int ondort = 0;
            int onbes = 0;
            int cracks = 0;

            string[] karakter = new string[92];
            karakter[0] = "";
            karakter[1] = "a";
            karakter[2] = "A";
            karakter[3] = "b";
            karakter[4] = "B";
            karakter[5] = "c";
            karakter[6] = "C";
            karakter[7] = "ç";
            karakter[8] = "Ç";
            karakter[9] = "d";
            karakter[10] = "D";
            karakter[11] = "e";
            karakter[12] = "E";
            karakter[13] = "f";
            karakter[14] = "F";
            karakter[15] = "g";
            karakter[16] = "G";
            karakter[17] = "ğ";
            karakter[18] = "Ğ";
            karakter[19] = "h";
            karakter[20] = "H";
            karakter[21] = "ı";
            karakter[22] = "I";
            karakter[23] = "i";
            karakter[24] = "İ";
            karakter[25] = "j";
            karakter[26] = "J";
            karakter[27] = "k";
            karakter[28] = "K";
            karakter[29] = "l";
            karakter[30] = "L";
            karakter[31] = "m";
            karakter[32] = "M";
            karakter[33] = "n";
            karakter[34] = "N";
            karakter[35] = "o";
            karakter[36] = "O";
            karakter[37] = "ö";
            karakter[38] = "Ö";
            karakter[39] = "p";
            karakter[40] = "P";
            karakter[41] = "r";
            karakter[42] = "R";
            karakter[43] = "s";
            karakter[44] = "S";
            karakter[45] = "ş";
            karakter[46] = "Ş";
            karakter[47] = "t";
            karakter[48] = "T";
            karakter[49] = "u";
            karakter[50] = "U";
            karakter[51] = "ü";
            karakter[52] = "Ü";
            karakter[53] = "v";
            karakter[54] = "V";
            karakter[55] = "y";
            karakter[56] = "Y";
            karakter[57] = "z";
            karakter[58] = "Z";
            karakter[59] = "w";
            karakter[60] = "W";
            karakter[61] = "x";
            karakter[62] = "X";
            karakter[63] = "q";
            karakter[64] = "Q";
            karakter[65] = "Q";
            karakter[66] = ".";
            karakter[67] = ",";
            karakter[68] = "-";
            karakter[69] = "+";
            karakter[70] = "/";
            karakter[71] = "&";
            karakter[72] = "%";
            karakter[73] = "^";
            karakter[74] = "!";
            karakter[75] = "?";
            karakter[76] = "*";
            karakter[77] = "$";
            karakter[78] = "#";
            karakter[79] = "£";
            karakter[80] = "<";
            karakter[81] = ">";
            karakter[82] = "0";
            karakter[83] = "1";
            karakter[84] = "2";
            karakter[85] = "3";
            karakter[86] = "4";
            karakter[87] = "5";
            karakter[88] = "6";
            karakter[89] = "7";
            karakter[90] = "8";
            karakter[91] = "9";
            
            while (!atilim.Equals(sifre))
            {
                //if (first == karakter.Length)
                //{
                //    second++;
                //    first = 0;
                //}
                //if (second == karakter.Length)
                //{
                //    third++;
                //    second = 0;
                //}
                //if (third == karakter.Length)
                //{
                //    fourth++;
                //    third = 0;
                //}
                if (fourth == karakter.Length)
                {
                    fiveth++;
                    fourth = 0;
                }
                if (fiveth == karakter.Length)
                {
                    sixth++;
                    fiveth = 0;
                }
                if (sixth == karakter.Length)
                {
                    seventh++;
                    sixth = 0;
                }
                if (seventh == karakter.Length)
                {
                    eighth++;
                    seventh = 0;
                }
                if (eighth == karakter.Length)
                {
                    dokuz++;
                    eighth = 0;
                }
                if (dokuz == karakter.Length)
                {
                    on++;
                    dokuz = 0;
                }
                if (on == karakter.Length)
                {
                    onbir++;
                    on = 0;
                }
                if (onbir == karakter.Length)
                {
                    oniki++;
                    onbir = 0;
                }
                if (oniki == karakter.Length)
                {
                    onuc++;
                    oniki = 0;
                }
                if (onuc == karakter.Length)
                {
                    ondort++;
                    onuc = 0;
                }
                if (ondort == karakter.Length)
                {
                    onbes++;
                    ondort = 0;
                }
                if (onbes == karakter.Length)
                {
                    break;
                }

                atilim = 
                         karakter[fiveth]+
                         karakter[sixth]+
                         karakter[seventh]+
                         karakter[eighth];
                Console.WriteLine(atilim);
                fiveth++;
                cracks++;
            }
            Console.WriteLine("Şifreniz : {0}",cracks);
            Console.ReadLine();
        }
    }
}
