using KodavimoTeorijaA15.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodavimoTeorijaA15.Encoding
{
    class ConvolutionalEncoder : IEncoder
    {
        private char[] _registers;
        private bool _debuggingIsEnabled;

        public ConvolutionalEncoder()
        {
            _registers = new char[6];
            CleanRegisters();
        }

        /// <summary>
        /// Užkoduoja dvejetainiu formatu pateikiamą pranešimą pagal tiesioginį sąsūkos kodą.
        /// </summary>
        /// <param name="text">Pranešimas dvejetainiu formatu</param>
        /// <returns>Užkoduotas pranešimas dvejetainiu formatu</returns>
        public string Encode(string text)
        {
            CleanRegisters();
            text += "000000"; // Užkoduojant pranešimą reikia į galą prirašyti 6 nulius

            StringBuilder sb = new StringBuilder("");

            foreach(char bit in text)
            {            
                sb.Append(bit); // Pirmas užkodavimo bitas yra input bito kopija
               
                //MoveRegisters(bit); // Pirmiausia išstumiame pirmą input bitą į viršutinį registrą

                // Antras užkodavimo bitas yra gaunamas sumuojant 2, 5, 6 registrus ir ipnut bitą
                char result = 
                    BitUtils.AddMod2(
                          BitUtils.AddMod2(_registers[1], _registers[4]),
                          BitUtils.AddMod2(_registers[5], bit)
                    );

                MoveRegisters(bit); // Pirmiausia išstumiame pirmą input bitą į viršutinį registrą

                sb.Append(result);            
            }

            return sb.ToString();
        }

        public void EnableDebug(bool state)
        {
            _debuggingIsEnabled = state;
        }

        /// <summary>
        /// Pastumia apatinius registrus per 1 į dešinę ir į pradžią įterpia naujai atėjusį bitą.
        /// </summary>
        /// <param name="bit">Naujai atėjęs bitas</param>
        private void MoveRegisters(char bit)
        {
            Array.Copy(_registers, 0, _registers, 1, 5);
            _registers[0] = bit;

            if (_debuggingIsEnabled)
            { 
                PrintRegisters();
            }
        }

        private void PrintRegisters()
        {
            string message = "Registers: ";
            foreach (char register in _registers)
            {
                message += register + " ";
            }

            Console.WriteLine(message);
        }

        /// <summary>
        /// Išvalo (užpildo '0') registrus.
        /// </summary>
        private void CleanRegisters()
        {
            for (int i = 0; i < 6; i++)
            {
                _registers[i] = '0';
            }
        }
    }
}
