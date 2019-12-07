using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace KodavimoTeorijaA15.Utils
{
    static class BitUtils
    {
        private static UTF8Encoding _encoding = new UTF8Encoding();

        /// <summary>
        /// Patikrina ar simbolis yra bitas.
        /// </summary>
        /// <param name="c">Tikrinamas simbolis</param>
        /// <returns>Ar "c" yra bitas</returns>
        public static bool IsBit(char c)
        {
            if (c == '1' || c == '0')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Invertuoja bito reikšmę (iš 0 padaro 1, o iš 1 padaro 0)
        /// </summary>
        /// <param name="bit">invertuojamas bitas</param>
        /// <returns>
        /// 0, jei bit = 1 
        /// 1, jei bit = 0
        /// </returns>
        public static char InvertBit(char bit)
        {
            if (bit == '0')
            {
                return '1';
            }
            else
            {
                return '0';
            }
        }

        /// <summary>
        /// Atlieka sudėtį moduliu 2
        /// </summary>
        /// <param name="a">Pirmas bitas</param>
        /// <param name="b">Antras bitas</param>
        /// <returns>"a" + "b" moduliu 2</returns>
        public static char AddMod2(char a, char b)
        {
            if ((a == '1' && b == '1') || (a == '0' && b == '0'))
            {
                return '0';
            }
            else
            {
                return '1';
            }
        }

        /// <summary>
        /// Iš teksto sukonstruoja bitų seką (pagal UTF-8), išreikštą string formatu. 
        /// </summary>
        /// <param name="str">Tekstas</param>
        /// <returns></returns>
        public static string StringToBinaryString(string str)
        {        
            byte[] byteArray = _encoding.GetBytes(str);
            string binaryString = string.Join("", byteArray.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));

            return binaryString;
        }

        /// <summary>
        /// Iš bitų sekos, išreikštos string formatu, sukonstruoja tekstą (pagal UTF-8).
        /// </summary>
        /// <param name="binaryStr">Bitai išreikšti per string</param>
        /// <returns></returns>
        public static string BinaryStringToString(string binaryStr)
        {
            byte[] byteArray = new byte[binaryStr.Length / 8];
            
            for (int i = 0; i < binaryStr.Length; i += 8)
            {
                byteArray[i / 8] = Convert.ToByte(binaryStr.Substring(i, 8), 2);
            }           
            
            return _encoding.GetString(byteArray);
        }

        /// <summary>
        /// Iš paveiksliuko sukonstruoja bitų seką, išreikštą string formatu.
        /// </summary>
        /// <param name="img">Paveiksliukas</param>
        /// <returns></returns>
        public static string ImageToBinaryString(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);
            byte[] byteArray = ms.ToArray();
            BitArray bitArray = new BitArray(byteArray);

            StringBuilder binaryString = new StringBuilder();
            
            foreach (bool bit in bitArray)
            {
                binaryString.Append(bit? '1' : '0');
            }
            
            return binaryString.ToString();
        }

        /// <summary>
        /// Iš bitų sekos, išreikštos string formatu, sukonstruoja paveiksliuką.
        /// </summary>
        /// <param name="binaryStr">Bitai išreikšti per string</param>
        /// <returns></returns>
        public static Image BinaryStringToImage(string binaryStr)
        {
            BitArray bitArray = new BitArray(binaryStr.Length);
            for(int i = 0; i < binaryStr.Length; i++)
            {
                bitArray[i] = binaryStr[i] == '1' ? true : false;
            }

            byte[] byteArray = new byte[bitArray.Length];
            bitArray.CopyTo(byteArray, 0);

            MemoryStream imageMemoryStream = new MemoryStream(byteArray);
            Image imgFromStream = Image.FromStream(imageMemoryStream);

            return imgFromStream;
        }
    }
}
