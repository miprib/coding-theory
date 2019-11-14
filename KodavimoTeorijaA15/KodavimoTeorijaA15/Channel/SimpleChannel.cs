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
                    sb.Append(InvertBit(bit));
                }
                else
                {
                    sb.Append(bit);
                }
            }

            return sb.ToString();
        }

        public void SetNoiseLevel(double percentage)
        {
            _noisePercentage = percentage;
        }

        private char InvertBit(char bit)
        {
            if(bit == '0')
            {
                return '1';
            }
            else
            {
                return '0';
            }
        }
    }
}
