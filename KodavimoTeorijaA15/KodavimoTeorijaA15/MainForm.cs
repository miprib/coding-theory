using KodavimoTeorijaA15.Channel;
using KodavimoTeorijaA15.Encoding;
using KodavimoTeorijaA15.Decoding;
using KodavimoTeorijaA15.Utils;
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

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

        private void ButtonRunImage_Click(object sender, EventArgs e)
        {
            if (pictureBoxUploadedImage == null || pictureBoxUploadedImage.Image == null)
            {
                MessageBox.Show("Upload an image first");
                return;
            }

            string binaryUserInput = BitUtils.ImageToBinaryString(pictureBoxUploadedImage.Image);

            // ---------------------------------
            string encoderOutput = _convolutionalEncoder.Encode(binaryUserInput);

            _simpleChannel.SetNoiseLevel((double)numericUpDownNoiseLevel.Value);

            int headerSize =
                binaryUserInput.Length -
                Image.GetPixelFormatSize(pictureBoxUploadedImage.Image.PixelFormat) * (pictureBoxUploadedImage.Image.Width * pictureBoxUploadedImage.Image.Height);

            string channelOutput = _simpleChannel.AddNoise(encoderOutput, headerSize);
            string decoderOutput = _convolutionalDecoder.Decode(channelOutput);

            pictureBoxDecoderOutput.Image = BitUtils.BinaryStringToImage(decoderOutput);

            // -----------------------------------
            channelOutput = _simpleChannel.AddNoise(binaryUserInput, headerSize);
            pictureBoxChannelOutput.Image = BitUtils.BinaryStringToImage(channelOutput);
        }

        private void ButtonRunText_Click(object sender, EventArgs e)
        {
            string binaryUserInput = BitUtils.StringToBinaryString(textBoxUserInput.Text);

            //-----------
            string encoderOutput = _convolutionalEncoder.Encode(binaryUserInput);

            _simpleChannel.SetNoiseLevel((double)numericUpDownNoiseLevel.Value);
            string channelOutput = _simpleChannel.AddNoise(encoderOutput, 0);
            string decoderOutput = _convolutionalDecoder.Decode(channelOutput);

            textBoxTextFromDecoder.Text = BitUtils.BinaryStringToString(decoderOutput);

            //-----------
            channelOutput = _simpleChannel.AddNoise(binaryUserInput, 0);
            textBoxTextFromChannel.Text = BitUtils.BinaryStringToString(channelOutput);
        }
        /*
        private void GetFullResult(string binaryUserInput)
        {
            string encoderOutput = _convolutionalEncoder.Encode(binaryUserInput);

            _simpleChannel.SetNoiseLevel((int)numericUpDownNoiseLevel.Value);
            string channelOutput = "";
            if (radioButtonImage.Checked)
            {
                int headerSize =
                    binaryUserInput.Length -
                    Image.GetPixelFormatSize(pictureBoxUploadedImage.Image.PixelFormat) * (pictureBoxUploadedImage.Image.Width * pictureBoxUploadedImage.Image.Height);

                channelOutput = _simpleChannel.AddNoise(encoderOutput, headerSize);
                string decoderOutput = _convolutionalDecoder.Decode(channelOutput);

                pictureBoxDecoderOutput.Image = BitUtils.BinaryStringToImage(decoderOutput);
            }
            else
            {
                channelOutput = _simpleChannel.AddNoise(encoderOutput, 0);
                string decoderOutput = _convolutionalDecoder.Decode(channelOutput);

                textBoxTextFromDecoder.Text = BitUtils.BinaryStringToString(decoderOutput);
            }
        }

        private void GetChannelResult(string binaryUserInput)
        {
            string channelOutput = "";
            if (radioButtonImage.Checked)
            {
                int headerSize =
                    binaryUserInput.Length -
                    Image.GetPixelFormatSize(pictureBoxUploadedImage.Image.PixelFormat) * (pictureBoxUploadedImage.Image.Width * pictureBoxUploadedImage.Image.Height);

                channelOutput = _simpleChannel.AddNoise(binaryUserInput, headerSize);
                pictureBoxChannelOutput.Image = BitUtils.BinaryStringToImage(channelOutput);
            }
            else
            {
                channelOutput = _simpleChannel.AddNoise(binaryUserInput, 0);
                textBoxTextFromChannel.Text = BitUtils.BinaryStringToString(channelOutput);
            }
        }
        */
        private void ButtonEncode_Click(object sender, EventArgs e)
        {
            textBoxDecoderOutput.Text = String.Empty;
            textBoxChannelOutput.Text = String.Empty;
            buttonShowMistakes.Enabled = false;

            string error = ValidateBinary(textBoxEncoderInput.Text.Trim());
            if(error != null)
            {
                textBoxEncoderOutput.Text =
                    "\"" + textBoxEncoderInput.Text.Trim() + "\"" +
                    " is an invalid encoder input. " +
                    "Encoder input " +
                    error;

                return;
            }         
            
            string encodedText = _convolutionalEncoder.Encode(textBoxEncoderInput.Text.Trim());    
            textBoxEncoderOutput.Text = encodedText;

            if (checkBoxDebug.Checked)
            {
                Console.WriteLine("---------------------------------------------------------------------------");
            }
        }

        private void ButtonSendToChannel_Click(object sender, EventArgs e)
        {
            _simpleChannel.SetNoiseLevel((double)numericUpDownNoiseLevel.Value);
            textBoxChannelOutput.Text = _simpleChannel.AddNoise(textBoxEncoderOutput.Text.Trim(), 0);

            buttonShowMistakes.Enabled = true;
        }

        private string ValidateBinary(string text)
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

            string error = ValidateBinary(textBoxChannelOutput.Text.Trim());
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

        private void buttonRunBinary_Click(object sender, EventArgs e)
        {
            if (textBoxEncoderInput.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Encoder input cannot be empty");
                return;
            }

            ButtonEncode_Click(sender, e);
            ButtonSendToChannel_Click(sender, e);
            ButtonDecode_Click(sender, e);
            buttonShowMistakes_Click(sender, e);
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

        /// <summary>
        /// Pažymi klaidas, kurios atsirado enkoderio išeities reikšmei išėjus iš kanalo.
        /// </summary>
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

        /// <summary>
        /// Pažymi reikšmes, kurios atsirado reikšmei išėjus iš dekoderio (lyginant su enkoderio įeitimi).
        /// </summary>
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

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {           
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.bmp)|*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (pictureBoxUploadedImage.Image != null)
                {
                    pictureBoxDecoderOutput.Image = null;
                    pictureBoxChannelOutput.Image = null;
                }

                pictureBoxUploadedImage.Image = new Bitmap(open.FileName);
                pictureBoxUploadedImage.Text = open.FileName;
            }
        }     
    }
}
