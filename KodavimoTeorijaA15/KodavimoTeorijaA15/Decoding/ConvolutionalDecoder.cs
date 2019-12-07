using KodavimoTeorijaA15.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodavimoTeorijaA15.Decoding
{
    class ConvolutionalDecoder : IDecoder
    {
        private bool _debuggingIsEnabled;
        private char[] _upperRegisters;
        private char[] _lowerRegisters;

        private char _bit1;
        private char _bit2;

        public ConvolutionalDecoder()
        {
            _upperRegisters = new char[6];
            _lowerRegisters = new char[6];

            CleanRegisters();
        }

        /// <summary>
        /// Dekoduoja dvejetainiu formatu pateikiamą užkoduotą pranešimą pagal tiesioginį sąsūkos kodą.
        /// </summary>
        /// <param name="text">Užkoduotas pranešimas dvejetainiu formatu</param>
        /// <returns>Dekoduotas pranešimas dvejetainiu formatu</returns>
        public string Decode(string text)
        {
            CleanRegisters();

            StringBuilder sb = new StringBuilder("");
            string[] bitPairs = TransformToPairs(text);
            
            for(int i = 0; i < bitPairs.Length; i++)
            {
                _bit1 = bitPairs[i][0];
                _bit2 = bitPairs[i][1];

                char outBit = _upperRegisters[5];

                // Sudedami 2, 5, 6 viršutiniai registrai ir abu input bitai
                char upperSum =
                    BitUtils.AddMod2(
                        BitUtils.AddMod2(_upperRegisters[1], _upperRegisters[4]),
                        BitUtils.AddMod2(_upperRegisters[5], BitUtils.AddMod2(_bit1, _bit2))
                    );

                MoveUpperRegisters(_bit1); // Įstumiame pirmą input bitą į viršutinį registrą

                // Kai praeiname užkodavime pridėtus nulinius bitus, pradedame išsaugoti dekoduotas reikšmes
                if (i >= 6)
                {
                    sb.Append(BitUtils.AddMod2(outBit, MDE(upperSum)));
                }

                // Apatinius registrus perstumiame pačiame iteracijos gale
                MoveLowerRegisters(upperSum);

                if (_debuggingIsEnabled)
                {
                    Console.WriteLine();
                }
            }        
            return sb.ToString();
        }

        /// <summary>
        /// Suranda MDE (majority-decision element). Balsuoja 1, 4, 6 apatiniai registrai ir iš viršaus atėjusi suma.
        /// </summary>
        /// <param name="upperSum">Iš viršaus atėjusi reikšmė</param>
        /// <returns>1, jei 2 arba daugiau balsuotojų lygūs 1</returns>
        private char MDE(char upperSum)
        {
            char[] voters = {_lowerRegisters[0], _lowerRegisters[3], _lowerRegisters[5], upperSum};

            int oneCount = 0;

            foreach (char voter in voters)
            {
                if(voter == '1')
                {
                    oneCount++;
                }
            }

            if (_debuggingIsEnabled) 
            { 
                PrintMDE(voters); 
            }

            return (oneCount > 2) ? '1' : '0';
        }

        /// <summary>
        /// Transformuoja bitų seką į bitų poras, kad kad būtų paprasčiau dekoduoti.
        /// </summary>
        /// <param name="text">Bitų seka</param>
        /// <returns>"text" bitų seka, išskaidytą po 2 bitus</returns>
        private string[] TransformToPairs(string text)
        {
            string[] bitPairs = new string[text.Length / 2];

            for (int i = 0; i < text.Length; i += 2)
            {
                bitPairs[i / 2] = text[i].ToString() + text[i + 1].ToString();
            }

            return bitPairs;
        }

        /// <summary>
        /// Pastumia viršutinius registrus per 1 į dešinę ir į pradžią įterpia naujai atėjusį bitą.
        /// </summary>
        /// <param name="bit">Naujai atėjęs bitas</param>
        private void MoveUpperRegisters(char bit)
        {         
            Array.Copy(_upperRegisters, 0, _upperRegisters, 1, 5);
            _upperRegisters[0] = bit;

            if (_debuggingIsEnabled)
            {
                PrintUpperRegisters();

                Console.WriteLine(
                    "upperSum (2,5,6 registrai + abu input bitai): " +
                    _upperRegisters[1] + "+" +
                    _upperRegisters[4] + "+" +
                    _upperRegisters[5] + "+" +
                    _bit1 + "+" +
                    _bit2
                );
            }
        }

        /// <summary>
        /// Pastumia apatinius registrus per 1 į dešinę ir į pradžią įterpia naujai atėjusį bitą.
        /// </summary>
        /// <param name="bit">Naujai atėjęs bitas</param>
        private void MoveLowerRegisters(char bit)
        {
            Array.Copy(_lowerRegisters, 0, _lowerRegisters, 1, 5);
            _lowerRegisters[0] = bit;

            if (_debuggingIsEnabled)
            {
                PrintLowerRegisters();
            }
        }

        private void PrintUpperRegisters()
        {           
            string message = "Upper registers: ";
            foreach (char register in _upperRegisters)
            {
                message += register + " ";
            }

            Console.WriteLine(message);         
        }

        private void PrintLowerRegisters()
        {
            string message = "Lower registers: ";
            foreach (char register in _lowerRegisters)
            {
                message += register + " ";
            }

            Console.WriteLine(message);
        }

        private void PrintMDE(char[] voters)
        {
            string message = "MDE voters (1,4,6 registrai + upperRegistrySum): ";
            foreach (char voter in voters)
            {
                message += voter + " ";
            }

            Console.WriteLine(message);
        }

        public void EnableDebug(bool state)
        {
            _debuggingIsEnabled = state;
        }

        /// <summary>
        /// Išvalo (užpildo '0') viršutinius ir apatinius registrus.
        /// </summary>
        private void CleanRegisters()
        {
            for (int i = 0; i < 6; i++)
            {
                _upperRegisters[i] = '0';
                _lowerRegisters[i] = '0';
            }
        }
    }
}
