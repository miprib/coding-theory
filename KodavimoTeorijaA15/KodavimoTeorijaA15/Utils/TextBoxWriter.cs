﻿using System;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace KodavimoTeorijaA15.Utils
{
    class TextBoxWriter : TextWriter
    {
        private TextBox _output = null;

        public TextBoxWriter(TextBox output)
        {
            _output = output;
        }

        public override void Write(char value)
        {
            base.Write(value);
            _output.AppendText(value.ToString()); // When character data is written, append it to the text box.
        }

        public override System.Text.Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }
}
