namespace KodavimoTeorijaA15
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDecode = new System.Windows.Forms.Button();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.textBoxEncoderInput = new System.Windows.Forms.TextBox();
            this.textBoxChannelOutput = new System.Windows.Forms.RichTextBox();
            this.textBoxDecoderOutput = new System.Windows.Forms.RichTextBox();
            this.groupBoxBinary = new System.Windows.Forms.GroupBox();
            this.buttonSendToChannel = new System.Windows.Forms.Button();
            this.buttonShowMistakes = new System.Windows.Forms.Button();
            this.numericUpDownNoiseLevel = new System.Windows.Forms.NumericUpDown();
            this.labelNoiseLevel = new System.Windows.Forms.Label();
            this.checkBoxDebug = new System.Windows.Forms.CheckBox();
            this.labelEncoderOutput = new System.Windows.Forms.Label();
            this.textBoxEncoderOutput = new System.Windows.Forms.TextBox();
            this.textBoxDebug = new System.Windows.Forms.TextBox();
            this.labelDebug = new System.Windows.Forms.Label();
            this.labelDecoderOutput = new System.Windows.Forms.Label();
            this.labelChannelOutput = new System.Windows.Forms.Label();
            this.labelEncoderInput = new System.Windows.Forms.Label();
            this.groupBoxImage = new System.Windows.Forms.GroupBox();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.labelUploadedImage = new System.Windows.Forms.Label();
            this.pictureBoxUploadedImage = new System.Windows.Forms.PictureBox();
            this.labelImageFromDecoder = new System.Windows.Forms.Label();
            this.labelImageFromChannel = new System.Windows.Forms.Label();
            this.pictureBoxDecoderOutput = new System.Windows.Forms.PictureBox();
            this.pictureBoxChannelOutput = new System.Windows.Forms.PictureBox();
            this.buttonRunImage = new System.Windows.Forms.Button();
            this.labelTextFromDecoder = new System.Windows.Forms.Label();
            this.textBoxTextFromChannel = new System.Windows.Forms.TextBox();
            this.labelTextFromChannel = new System.Windows.Forms.Label();
            this.textBoxTextFromDecoder = new System.Windows.Forms.TextBox();
            this.textBoxUserInput = new System.Windows.Forms.TextBox();
            this.groupBoxText = new System.Windows.Forms.GroupBox();
            this.labelUserInputText = new System.Windows.Forms.Label();
            this.buttonRunText = new System.Windows.Forms.Button();
            this.buttonRunBinary = new System.Windows.Forms.Button();
            this.groupBoxBinary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoiseLevel)).BeginInit();
            this.groupBoxImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUploadedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecoderOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChannelOutput)).BeginInit();
            this.groupBoxText.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(659, 170);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(330, 23);
            this.buttonDecode.TabIndex = 0;
            this.buttonDecode.Text = "Decode";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.ButtonDecode_Click);
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(6, 170);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(291, 23);
            this.buttonEncode.TabIndex = 1;
            this.buttonEncode.Text = "Encode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.ButtonEncode_Click);
            // 
            // textBoxEncoderInput
            // 
            this.textBoxEncoderInput.Location = new System.Drawing.Point(6, 38);
            this.textBoxEncoderInput.Multiline = true;
            this.textBoxEncoderInput.Name = "textBoxEncoderInput";
            this.textBoxEncoderInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEncoderInput.Size = new System.Drawing.Size(291, 126);
            this.textBoxEncoderInput.TabIndex = 2;
            // 
            // textBoxChannelOutput
            // 
            this.textBoxChannelOutput.Location = new System.Drawing.Point(659, 38);
            this.textBoxChannelOutput.Name = "textBoxChannelOutput";
            this.textBoxChannelOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBoxChannelOutput.Size = new System.Drawing.Size(330, 126);
            this.textBoxChannelOutput.TabIndex = 3;
            this.textBoxChannelOutput.Text = "";
            // 
            // textBoxDecoderOutput
            // 
            this.textBoxDecoderOutput.Location = new System.Drawing.Point(995, 38);
            this.textBoxDecoderOutput.Name = "textBoxDecoderOutput";
            this.textBoxDecoderOutput.ReadOnly = true;
            this.textBoxDecoderOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBoxDecoderOutput.Size = new System.Drawing.Size(291, 126);
            this.textBoxDecoderOutput.TabIndex = 4;
            this.textBoxDecoderOutput.Text = "";
            // 
            // groupBoxBinary
            // 
            this.groupBoxBinary.Controls.Add(this.buttonRunBinary);
            this.groupBoxBinary.Controls.Add(this.buttonSendToChannel);
            this.groupBoxBinary.Controls.Add(this.buttonShowMistakes);
            this.groupBoxBinary.Controls.Add(this.numericUpDownNoiseLevel);
            this.groupBoxBinary.Controls.Add(this.labelNoiseLevel);
            this.groupBoxBinary.Controls.Add(this.checkBoxDebug);
            this.groupBoxBinary.Controls.Add(this.labelEncoderOutput);
            this.groupBoxBinary.Controls.Add(this.textBoxEncoderOutput);
            this.groupBoxBinary.Controls.Add(this.textBoxDebug);
            this.groupBoxBinary.Controls.Add(this.labelDebug);
            this.groupBoxBinary.Controls.Add(this.labelDecoderOutput);
            this.groupBoxBinary.Controls.Add(this.labelChannelOutput);
            this.groupBoxBinary.Controls.Add(this.labelEncoderInput);
            this.groupBoxBinary.Controls.Add(this.textBoxChannelOutput);
            this.groupBoxBinary.Controls.Add(this.textBoxDecoderOutput);
            this.groupBoxBinary.Controls.Add(this.buttonDecode);
            this.groupBoxBinary.Controls.Add(this.buttonEncode);
            this.groupBoxBinary.Controls.Add(this.textBoxEncoderInput);
            this.groupBoxBinary.Location = new System.Drawing.Point(12, 616);
            this.groupBoxBinary.Name = "groupBoxBinary";
            this.groupBoxBinary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxBinary.Size = new System.Drawing.Size(1292, 438);
            this.groupBoxBinary.TabIndex = 5;
            this.groupBoxBinary.TabStop = false;
            this.groupBoxBinary.Text = "Binary";
            // 
            // buttonSendToChannel
            // 
            this.buttonSendToChannel.Location = new System.Drawing.Point(303, 170);
            this.buttonSendToChannel.Name = "buttonSendToChannel";
            this.buttonSendToChannel.Size = new System.Drawing.Size(330, 23);
            this.buttonSendToChannel.TabIndex = 17;
            this.buttonSendToChannel.Text = "Send To Channel";
            this.buttonSendToChannel.UseVisualStyleBackColor = true;
            this.buttonSendToChannel.Click += new System.EventHandler(this.ButtonSendToChannel_Click);
            // 
            // buttonShowMistakes
            // 
            this.buttonShowMistakes.Enabled = false;
            this.buttonShowMistakes.Location = new System.Drawing.Point(995, 170);
            this.buttonShowMistakes.Name = "buttonShowMistakes";
            this.buttonShowMistakes.Size = new System.Drawing.Size(291, 23);
            this.buttonShowMistakes.TabIndex = 16;
            this.buttonShowMistakes.Text = "Show Mistakes";
            this.buttonShowMistakes.UseVisualStyleBackColor = true;
            this.buttonShowMistakes.Click += new System.EventHandler(this.buttonShowMistakes_Click);
            // 
            // numericUpDownNoiseLevel
            // 
            this.numericUpDownNoiseLevel.DecimalPlaces = 6;
            this.numericUpDownNoiseLevel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.numericUpDownNoiseLevel.Location = new System.Drawing.Point(424, 202);
            this.numericUpDownNoiseLevel.Name = "numericUpDownNoiseLevel";
            this.numericUpDownNoiseLevel.Size = new System.Drawing.Size(209, 20);
            this.numericUpDownNoiseLevel.TabIndex = 15;
            // 
            // labelNoiseLevel
            // 
            this.labelNoiseLevel.AutoSize = true;
            this.labelNoiseLevel.Location = new System.Drawing.Point(303, 204);
            this.labelNoiseLevel.Name = "labelNoiseLevel";
            this.labelNoiseLevel.Size = new System.Drawing.Size(115, 13);
            this.labelNoiseLevel.TabIndex = 13;
            this.labelNoiseLevel.Text = "Channel Noise (0-100):";
            // 
            // checkBoxDebug
            // 
            this.checkBoxDebug.AutoSize = true;
            this.checkBoxDebug.Location = new System.Drawing.Point(5, 245);
            this.checkBoxDebug.Name = "checkBoxDebug";
            this.checkBoxDebug.Size = new System.Drawing.Size(129, 17);
            this.checkBoxDebug.TabIndex = 12;
            this.checkBoxDebug.Text = "Enable Debug Output";
            this.checkBoxDebug.UseVisualStyleBackColor = true;
            this.checkBoxDebug.CheckedChanged += new System.EventHandler(this.CheckBoxDebug_CheckedChanged);
            // 
            // labelEncoderOutput
            // 
            this.labelEncoderOutput.AutoSize = true;
            this.labelEncoderOutput.Location = new System.Drawing.Point(300, 22);
            this.labelEncoderOutput.Name = "labelEncoderOutput";
            this.labelEncoderOutput.Size = new System.Drawing.Size(82, 13);
            this.labelEncoderOutput.TabIndex = 11;
            this.labelEncoderOutput.Text = "Encoder Output";
            // 
            // textBoxEncoderOutput
            // 
            this.textBoxEncoderOutput.Location = new System.Drawing.Point(303, 38);
            this.textBoxEncoderOutput.Multiline = true;
            this.textBoxEncoderOutput.Name = "textBoxEncoderOutput";
            this.textBoxEncoderOutput.ReadOnly = true;
            this.textBoxEncoderOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEncoderOutput.Size = new System.Drawing.Size(330, 126);
            this.textBoxEncoderOutput.TabIndex = 10;
            // 
            // textBoxDebug
            // 
            this.textBoxDebug.Location = new System.Drawing.Point(5, 281);
            this.textBoxDebug.Multiline = true;
            this.textBoxDebug.Name = "textBoxDebug";
            this.textBoxDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDebug.Size = new System.Drawing.Size(1280, 144);
            this.textBoxDebug.TabIndex = 9;
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Location = new System.Drawing.Point(6, 265);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(39, 13);
            this.labelDebug.TabIndex = 8;
            this.labelDebug.Text = "Debug";
            // 
            // labelDecoderOutput
            // 
            this.labelDecoderOutput.AutoSize = true;
            this.labelDecoderOutput.Location = new System.Drawing.Point(992, 22);
            this.labelDecoderOutput.Name = "labelDecoderOutput";
            this.labelDecoderOutput.Size = new System.Drawing.Size(83, 13);
            this.labelDecoderOutput.TabIndex = 7;
            this.labelDecoderOutput.Text = "Decoder Output";
            // 
            // labelChannelOutput
            // 
            this.labelChannelOutput.AutoSize = true;
            this.labelChannelOutput.Location = new System.Drawing.Point(656, 22);
            this.labelChannelOutput.Name = "labelChannelOutput";
            this.labelChannelOutput.Size = new System.Drawing.Size(81, 13);
            this.labelChannelOutput.TabIndex = 6;
            this.labelChannelOutput.Text = "Channel Output";
            // 
            // labelEncoderInput
            // 
            this.labelEncoderInput.AutoSize = true;
            this.labelEncoderInput.Location = new System.Drawing.Point(6, 22);
            this.labelEncoderInput.Name = "labelEncoderInput";
            this.labelEncoderInput.Size = new System.Drawing.Size(74, 13);
            this.labelEncoderInput.TabIndex = 5;
            this.labelEncoderInput.Text = "Encoder Input";
            // 
            // groupBoxImage
            // 
            this.groupBoxImage.Controls.Add(this.buttonUploadImage);
            this.groupBoxImage.Controls.Add(this.labelUploadedImage);
            this.groupBoxImage.Controls.Add(this.pictureBoxUploadedImage);
            this.groupBoxImage.Controls.Add(this.labelImageFromDecoder);
            this.groupBoxImage.Controls.Add(this.labelImageFromChannel);
            this.groupBoxImage.Controls.Add(this.pictureBoxDecoderOutput);
            this.groupBoxImage.Controls.Add(this.pictureBoxChannelOutput);
            this.groupBoxImage.Controls.Add(this.buttonRunImage);
            this.groupBoxImage.Location = new System.Drawing.Point(12, 12);
            this.groupBoxImage.Name = "groupBoxImage";
            this.groupBoxImage.Size = new System.Drawing.Size(1292, 340);
            this.groupBoxImage.TabIndex = 17;
            this.groupBoxImage.TabStop = false;
            this.groupBoxImage.Text = "Image";
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.Location = new System.Drawing.Point(6, 311);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(630, 23);
            this.buttonUploadImage.TabIndex = 15;
            this.buttonUploadImage.Text = "Upload Image";
            this.buttonUploadImage.UseVisualStyleBackColor = true;
            this.buttonUploadImage.Click += new System.EventHandler(this.ButtonUploadImage_Click);
            // 
            // labelUploadedImage
            // 
            this.labelUploadedImage.AutoSize = true;
            this.labelUploadedImage.Location = new System.Drawing.Point(6, 16);
            this.labelUploadedImage.Name = "labelUploadedImage";
            this.labelUploadedImage.Size = new System.Drawing.Size(85, 13);
            this.labelUploadedImage.TabIndex = 14;
            this.labelUploadedImage.Text = "Uploaded Image";
            // 
            // pictureBoxUploadedImage
            // 
            this.pictureBoxUploadedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUploadedImage.Location = new System.Drawing.Point(9, 32);
            this.pictureBoxUploadedImage.Name = "pictureBoxUploadedImage";
            this.pictureBoxUploadedImage.Size = new System.Drawing.Size(412, 273);
            this.pictureBoxUploadedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUploadedImage.TabIndex = 13;
            this.pictureBoxUploadedImage.TabStop = false;
            // 
            // labelImageFromDecoder
            // 
            this.labelImageFromDecoder.AutoSize = true;
            this.labelImageFromDecoder.Location = new System.Drawing.Point(868, 16);
            this.labelImageFromDecoder.Name = "labelImageFromDecoder";
            this.labelImageFromDecoder.Size = new System.Drawing.Size(106, 13);
            this.labelImageFromDecoder.TabIndex = 12;
            this.labelImageFromDecoder.Text = "Image From Decoder";
            // 
            // labelImageFromChannel
            // 
            this.labelImageFromChannel.AutoSize = true;
            this.labelImageFromChannel.Location = new System.Drawing.Point(436, 16);
            this.labelImageFromChannel.Name = "labelImageFromChannel";
            this.labelImageFromChannel.Size = new System.Drawing.Size(104, 13);
            this.labelImageFromChannel.TabIndex = 11;
            this.labelImageFromChannel.Text = "Image From Channel";
            // 
            // pictureBoxDecoderOutput
            // 
            this.pictureBoxDecoderOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDecoderOutput.Location = new System.Drawing.Point(871, 32);
            this.pictureBoxDecoderOutput.Name = "pictureBoxDecoderOutput";
            this.pictureBoxDecoderOutput.Size = new System.Drawing.Size(414, 273);
            this.pictureBoxDecoderOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDecoderOutput.TabIndex = 10;
            this.pictureBoxDecoderOutput.TabStop = false;
            // 
            // pictureBoxChannelOutput
            // 
            this.pictureBoxChannelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxChannelOutput.Location = new System.Drawing.Point(439, 32);
            this.pictureBoxChannelOutput.Name = "pictureBoxChannelOutput";
            this.pictureBoxChannelOutput.Size = new System.Drawing.Size(415, 273);
            this.pictureBoxChannelOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChannelOutput.TabIndex = 9;
            this.pictureBoxChannelOutput.TabStop = false;
            // 
            // buttonRunImage
            // 
            this.buttonRunImage.Location = new System.Drawing.Point(655, 311);
            this.buttonRunImage.Name = "buttonRunImage";
            this.buttonRunImage.Size = new System.Drawing.Size(630, 23);
            this.buttonRunImage.TabIndex = 4;
            this.buttonRunImage.Text = "Run";
            this.buttonRunImage.UseVisualStyleBackColor = true;
            this.buttonRunImage.Click += new System.EventHandler(this.ButtonRunImage_Click);
            // 
            // labelTextFromDecoder
            // 
            this.labelTextFromDecoder.AutoSize = true;
            this.labelTextFromDecoder.Location = new System.Drawing.Point(868, 16);
            this.labelTextFromDecoder.Name = "labelTextFromDecoder";
            this.labelTextFromDecoder.Size = new System.Drawing.Size(98, 13);
            this.labelTextFromDecoder.TabIndex = 8;
            this.labelTextFromDecoder.Text = "Text From Decoder";
            // 
            // textBoxTextFromChannel
            // 
            this.textBoxTextFromChannel.Location = new System.Drawing.Point(439, 32);
            this.textBoxTextFromChannel.Multiline = true;
            this.textBoxTextFromChannel.Name = "textBoxTextFromChannel";
            this.textBoxTextFromChannel.ReadOnly = true;
            this.textBoxTextFromChannel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTextFromChannel.Size = new System.Drawing.Size(415, 185);
            this.textBoxTextFromChannel.TabIndex = 7;
            // 
            // labelTextFromChannel
            // 
            this.labelTextFromChannel.AutoSize = true;
            this.labelTextFromChannel.Location = new System.Drawing.Point(436, 16);
            this.labelTextFromChannel.Name = "labelTextFromChannel";
            this.labelTextFromChannel.Size = new System.Drawing.Size(96, 13);
            this.labelTextFromChannel.TabIndex = 6;
            this.labelTextFromChannel.Text = "Text From Channel";
            // 
            // textBoxTextFromDecoder
            // 
            this.textBoxTextFromDecoder.Location = new System.Drawing.Point(871, 32);
            this.textBoxTextFromDecoder.Multiline = true;
            this.textBoxTextFromDecoder.Name = "textBoxTextFromDecoder";
            this.textBoxTextFromDecoder.ReadOnly = true;
            this.textBoxTextFromDecoder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTextFromDecoder.Size = new System.Drawing.Size(415, 185);
            this.textBoxTextFromDecoder.TabIndex = 5;
            // 
            // textBoxUserInput
            // 
            this.textBoxUserInput.Location = new System.Drawing.Point(6, 32);
            this.textBoxUserInput.Multiline = true;
            this.textBoxUserInput.Name = "textBoxUserInput";
            this.textBoxUserInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUserInput.Size = new System.Drawing.Size(415, 185);
            this.textBoxUserInput.TabIndex = 0;
            // 
            // groupBoxText
            // 
            this.groupBoxText.Controls.Add(this.labelUserInputText);
            this.groupBoxText.Controls.Add(this.buttonRunText);
            this.groupBoxText.Controls.Add(this.textBoxUserInput);
            this.groupBoxText.Controls.Add(this.textBoxTextFromChannel);
            this.groupBoxText.Controls.Add(this.textBoxTextFromDecoder);
            this.groupBoxText.Controls.Add(this.labelTextFromChannel);
            this.groupBoxText.Controls.Add(this.labelTextFromDecoder);
            this.groupBoxText.Location = new System.Drawing.Point(12, 358);
            this.groupBoxText.Name = "groupBoxText";
            this.groupBoxText.Size = new System.Drawing.Size(1292, 252);
            this.groupBoxText.TabIndex = 18;
            this.groupBoxText.TabStop = false;
            this.groupBoxText.Text = "Text";
            // 
            // labelUserInputText
            // 
            this.labelUserInputText.AutoSize = true;
            this.labelUserInputText.Location = new System.Drawing.Point(6, 16);
            this.labelUserInputText.Name = "labelUserInputText";
            this.labelUserInputText.Size = new System.Drawing.Size(80, 13);
            this.labelUserInputText.TabIndex = 9;
            this.labelUserInputText.Text = "User Input Text";
            // 
            // buttonRunText
            // 
            this.buttonRunText.Location = new System.Drawing.Point(6, 223);
            this.buttonRunText.Name = "buttonRunText";
            this.buttonRunText.Size = new System.Drawing.Size(1280, 23);
            this.buttonRunText.TabIndex = 8;
            this.buttonRunText.Text = "Run";
            this.buttonRunText.UseVisualStyleBackColor = true;
            this.buttonRunText.Click += new System.EventHandler(this.ButtonRunText_Click);
            // 
            // buttonRunBinary
            // 
            this.buttonRunBinary.Location = new System.Drawing.Point(6, 199);
            this.buttonRunBinary.Name = "buttonRunBinary";
            this.buttonRunBinary.Size = new System.Drawing.Size(291, 23);
            this.buttonRunBinary.TabIndex = 18;
            this.buttonRunBinary.Text = "Run";
            this.buttonRunBinary.UseVisualStyleBackColor = true;
            this.buttonRunBinary.Click += new System.EventHandler(this.buttonRunBinary_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 1053);
            this.Controls.Add(this.groupBoxText);
            this.Controls.Add(this.groupBoxImage);
            this.Controls.Add(this.groupBoxBinary);
            this.Name = "MainForm";
            this.Text = "Direct Convolutional Code";
            this.groupBoxBinary.ResumeLayout(false);
            this.groupBoxBinary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoiseLevel)).EndInit();
            this.groupBoxImage.ResumeLayout(false);
            this.groupBoxImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUploadedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecoderOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChannelOutput)).EndInit();
            this.groupBoxText.ResumeLayout(false);
            this.groupBoxText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.TextBox textBoxEncoderInput;
        private System.Windows.Forms.RichTextBox textBoxChannelOutput;
        private System.Windows.Forms.RichTextBox textBoxDecoderOutput;
        private System.Windows.Forms.GroupBox groupBoxBinary;
        private System.Windows.Forms.Label labelEncoderInput;
        private System.Windows.Forms.Label labelDecoderOutput;
        private System.Windows.Forms.Label labelChannelOutput;
        private System.Windows.Forms.TextBox textBoxDebug;
        private System.Windows.Forms.Label labelDebug;
        private System.Windows.Forms.Label labelEncoderOutput;
        private System.Windows.Forms.TextBox textBoxEncoderOutput;
        private System.Windows.Forms.CheckBox checkBoxDebug;
        private System.Windows.Forms.Label labelNoiseLevel;
        private System.Windows.Forms.NumericUpDown numericUpDownNoiseLevel;
        private System.Windows.Forms.Button buttonShowMistakes;
        private System.Windows.Forms.GroupBox groupBoxImage;
        private System.Windows.Forms.TextBox textBoxUserInput;
        private System.Windows.Forms.Button buttonRunImage;
        private System.Windows.Forms.TextBox textBoxTextFromDecoder;
        private System.Windows.Forms.Label labelTextFromChannel;
        private System.Windows.Forms.Label labelTextFromDecoder;
        private System.Windows.Forms.TextBox textBoxTextFromChannel;
        private System.Windows.Forms.PictureBox pictureBoxChannelOutput;
        private System.Windows.Forms.PictureBox pictureBoxDecoderOutput;
        private System.Windows.Forms.Label labelUploadedImage;
        private System.Windows.Forms.PictureBox pictureBoxUploadedImage;
        private System.Windows.Forms.Label labelImageFromDecoder;
        private System.Windows.Forms.Label labelImageFromChannel;
        private System.Windows.Forms.Button buttonUploadImage;
        private System.Windows.Forms.GroupBox groupBoxText;
        private System.Windows.Forms.Button buttonRunText;
        private System.Windows.Forms.Label labelUserInputText;
        private System.Windows.Forms.Button buttonSendToChannel;
        private System.Windows.Forms.Button buttonRunBinary;
    }
}

