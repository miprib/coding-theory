using KodavimoTeorijaA15.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KodavimoTeorijaA15.Channel
{
    class SimpleChannel : IChannel
    {
        private double _noisePercentage = 0;

        public string AddNoise(string text)
        {
            StringBuilder sb = new StringBuilder("");
            Random random = new Random();

            foreach (char bit in text)
            {
                double value = random.NextDouble() * 100;

                if(value < _noisePercentage)
                {                 
                    sb.Append(BitUtils.InvertBit(bit));
                }
                else
                {
                    sb.Append(bit);
                }
            }

            return sb.ToString();
        }
        public string AddNoise(string text, int beginIndex)
        {
            StringBuilder sb = new StringBuilder("");
            Random random = new Random();

            // Iki nurodyto indekso nieko neinvertuojame
            for (int i = 0; i < beginIndex; i++)
            {
                sb.Append(text[i]);
            }

            for (int i = beginIndex; i < text.Length; i++)
            {
                double value = random.NextDouble() * 100;

                if (value < _noisePercentage)
                {
                    sb.Append(BitUtils.InvertBit(text[i]));
                }
                else
                {
                    sb.Append(text[i]);
                }
            }

            return sb.ToString();
        }

        public void SetNoiseLevel(double percentage)
        {
            _noisePercentage = percentage;
        }
    }
}
