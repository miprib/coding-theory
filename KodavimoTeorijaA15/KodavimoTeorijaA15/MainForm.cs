using KodavimoTeorijaA15.Channel;
using KodavimoTeorijaA15.Encoding;
using KodavimoTeorijaA15.Decoding;
using KodavimoTeorijaA15.Utils;
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace KodavimoTeorijaA15
{
    public partial class MainForm : Form
    {
        private IEncoder _convolutionalEncoder;
        private IChannel _simpleChannel;
        private IDecoder _convolutionalDecoder;

        private TextWriter _writer;

        public MainForm()
        {
            InitializeComponent();

            _convolutionalEncoder = new ConvolutionalEncoder();
            _simpleChannel = new SimpleChannel();
            _convolutionalDecoder = new ConvolutionalDecoder();

            // Redirect the out Console stream
            _writer = new TextBoxWriter(textBoxDebug);
            Console.SetOut(_writer);
        }

        private void ButtonSendToChannel_Click(object sender, EventArgs e)
        {
            textBoxDecoderOutput.Text = String.Empty;
            textBoxChannelOutput.Text = String.Empty;
            buttonShowMistakes.Enabled = false;

            string error = Validate(textBoxEncoderInput.Text.Trim());
            if(error != null)
            {
                textBoxEncoderOutput.Text =
                    "\"" + textBoxEncoderInput.Text.Trim() + "\"" +
                    " is an invalid encoder input. " +
                    "Encoder input " +
                    error;

                return;
            }

            buttonShowMistakes.Enabled = true;

            string encodedText = _convolutionalEncoder.Encode(textBoxEncoderInput.Text.Trim());    
            textBoxEncoderOutput.Text = encodedText;

            _simpleChannel.SetNoiseLevel((int)numericUpDownNoiseLevel.Value);
            textBoxChannelOutput.Text = _simpleChannel.AddNoise(encodedText.Trim());
         
            if (checkBoxDebug.Checked)
            {
                Console.WriteLine("---------------------------------------------------------------------------");
            }
        }

        private string Validate(string text)
        {
            if(text == null || text == "")
            {
                return "is empty";
            }

            foreach (char bit in text)
            {
                if (!BitUtils.IsBit(bit))
                {
                    return "is not binary";
                }
            }

            return null;
        }

        private void ButtonDecode_Click(object sender, EventArgs e)
        {
            buttonShowMistakes.Enabled = false;

            string error = Validate(textBoxChannelOutput.Text.Trim());
            if (error != null)
            {
                textBoxDecoderOutput.Text = 
                    "\"" + textBoxChannelOutput.Text.Trim() + "\"" +
                    " is an invalid decoder input. " + 
                    "Channel output " +
                    error;

                return;
            }
            else if (textBoxChannelOutput.Text.Trim().Length <= 12 || textBoxChannelOutput.Text.Trim().Length % 2 != 0)
            {
                textBoxDecoderOutput.Text =
                    "\"" + textBoxChannelOutput.Text.Trim() + "\"" +
                    " is an invalid decoder input. " +
                    "Channel output " +
                    "has invalid length";

                return;
            }

            buttonShowMistakes.Enabled = true;

            textBoxDecoderOutput.Text =  _convolutionalDecoder.Decode(textBoxChannelOutput.Text.Trim());

            if (checkBoxDebug.Checked)
            {
                Console.WriteLine("---------------------------------------------------------------------------");
            }
        }

        private void CheckBoxDebug_CheckedChanged(object sender, EventArgs e)
        {
            _convolutionalEncoder.EnableDebug(checkBoxDebug.Checked);
            _convolutionalDecoder.EnableDebug(checkBoxDebug.Checked);
        }

        private void buttonShowMistakes_Click(object sender, EventArgs e)
        {
            // RichTextbox negali pazymeti pirmo simbolio, todel reikia prideti kazka i pradzia
            textBoxChannelOutput.Text = " " + textBoxChannelOutput.Text.Trim();
            textBoxEncoderOutput.Text = " " + textBoxEncoderOutput.Text.Trim();
            textBoxEncoderInput.Text = " " + textBoxEncoderInput.Text.Trim();
            textBoxDecoderOutput.Text = " " + textBoxDecoderOutput.Text.Trim();

            HighlightChannelOutputMistakes();
            HighlightDecoderOutputMistakes();

            if (checkBoxDebug.Checked)
            {
                Console.WriteLine("---------------------------------------------------------------------------");
            }
        }

        private void HighlightChannelOutputMistakes()
        {
            int mistakes = 0;
            if (textBoxChannelOutput.Text.Length != textBoxEncoderOutput.Text.Length)
            {
                return;
            }

            for (int i = 0; i < textBoxChannelOutput.Text.Length; i++)
            {               
                if (textBoxChannelOutput.Text[i] != textBoxEncoderOutput.Text[i])
                {
                    textBoxChannelOutput.SelectionColor = Color.White;
                    textBoxChannelOutput.SelectionBackColor = Color.Red;
                    textBoxChannelOutput.Select(i + 1, 1);

                    mistakes++;
                }
                else
                {
                    textBoxChannelOutput.SelectionColor = Color.White;
                    textBoxChannelOutput.SelectionBackColor = Color.Green;
                    textBoxChannelOutput.Select(i + 1, 1);
                }
            }

            if (checkBoxDebug.Checked)
            {
                Console.WriteLine("Mistakes found after adding noise: " + mistakes);
            }
        }

        private void HighlightDecoderOutputMistakes()
        {
            int mistakes = 0;
            if (textBoxEncoderInput.Text.Length != textBoxDecoderOutput.Text.Length)
            {
                return;
            }

            for (int i = 0; i < textBoxDecoderOutput.Text.Length; i++)
            {
                if (textBoxDecoderOutput.Text[i] != textBoxEncoderInput.Text[i])
                {
                    textBoxDecoderOutput.SelectionColor = Color.White;
                    textBoxDecoderOutput.SelectionBackColor = Color.Red;
                    textBoxDecoderOutput.Select(i + 1, 1);

                    mistakes++;
                }
                else
                {
                    textBoxDecoderOutput.SelectionColor = Color.White;
                    textBoxDecoderOutput.SelectionBackColor = Color.Green;
                    textBoxDecoderOutput.Select(i + 1, 1);
                }
            }

            if (checkBoxDebug.Checked)
            {
                Console.WriteLine("Mistakes found after decoding: " + mistakes);
            }
        }
    }
}
