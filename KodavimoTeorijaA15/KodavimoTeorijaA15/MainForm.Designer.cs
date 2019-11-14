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
            this.buttonSendToChannel = new System.Windows.Forms.Button();
            this.textBoxEncoderInput = new System.Windows.Forms.TextBox();
            this.textBoxChannelOutput = new System.Windows.Forms.RichTextBox();
            this.textBoxDecoderOutput = new System.Windows.Forms.RichTextBox();
            this.groupBoxDirectConvolutionalCode = new System.Windows.Forms.GroupBox();
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
            this.groupBoxDirectConvolutionalCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoiseLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(334, 137);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(78, 23);
            this.buttonDecode.TabIndex = 0;
            this.buttonDecode.Text = "Decode";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.ButtonDecode_Click);
            // 
            // buttonSendToChannel
            // 
            this.buttonSendToChannel.Location = new System.Drawing.Point(6, 137);
            this.buttonSendToChannel.Name = "buttonSendToChannel";
            this.buttonSendToChannel.Size = new System.Drawing.Size(120, 23);
            this.buttonSendToChannel.TabIndex = 1;
            this.buttonSendToChannel.Text = "Send To Channel";
            this.buttonSendToChannel.UseVisualStyleBackColor = true;
            this.buttonSendToChannel.Click += new System.EventHandler(this.ButtonSendToChannel_Click);
            // 
            // textBoxEncoderInput
            // 
            this.textBoxEncoderInput.Location = new System.Drawing.Point(6, 38);
            this.textBoxEncoderInput.Multiline = true;
            this.textBoxEncoderInput.Name = "textBoxEncoderInput";
            this.textBoxEncoderInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEncoderInput.Size = new System.Drawing.Size(120, 93);
            this.textBoxEncoderInput.TabIndex = 2;
            // 
            // textBoxChannelOutput
            // 
            this.textBoxChannelOutput.Location = new System.Drawing.Point(334, 38);
            this.textBoxChannelOutput.Name = "textBoxChannelOutput";
            this.textBoxChannelOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBoxChannelOutput.Size = new System.Drawing.Size(189, 93);
            this.textBoxChannelOutput.TabIndex = 3;
            this.textBoxChannelOutput.Text = "";
            // 
            // textBoxDecoderOutput
            // 
            this.textBoxDecoderOutput.Location = new System.Drawing.Point(529, 38);
            this.textBoxDecoderOutput.Name = "textBoxDecoderOutput";
            this.textBoxDecoderOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBoxDecoderOutput.Size = new System.Drawing.Size(120, 93);
            this.textBoxDecoderOutput.TabIndex = 4;
            this.textBoxDecoderOutput.Text = "";
            // 
            // groupBoxDirectConvolutionalCode
            // 
            this.groupBoxDirectConvolutionalCode.Controls.Add(this.buttonShowMistakes);
            this.groupBoxDirectConvolutionalCode.Controls.Add(this.numericUpDownNoiseLevel);
            this.groupBoxDirectConvolutionalCode.Controls.Add(this.labelNoiseLevel);
            this.groupBoxDirectConvolutionalCode.Controls.Add(this.checkBoxDebug);
            this.groupBoxDirectConvolutionalCode.Controls.Add(this.labelEncoderOutput);
            this.groupBoxDirectConvolutionalCode.Controls.Add(this.textBoxEncoderOutput);
            this.groupBoxDirectConvolutionalCode.Controls.Add(this.textBoxDebug);
            this.groupBoxDirectConvolutionalCode.Controls.Add(this.labelDebug);
            this.groupBoxDirectConvolutionalCode.Controls.Add(this.labelDecoderOutput);
            this.groupBoxDirectConvolutionalCode.Controls.Add(this.labelChannelOutput);
            this.groupBoxDirectConvolutionalCode.Controls.Add(this.labelEncoderInput);
            this.groupBoxDirectConvolutionalCode.Controls.Add(this.textBoxChannelOutput);
            this.groupBoxDirectConvolutionalCode.Controls.Add(this.textBoxDecoderOutput);
            this.groupBoxDirectConvolutionalCode.Controls.Add(this.buttonDecode);
            this.groupBoxDirectConvolutionalCode.Controls.Add(this.buttonSendToChannel);
            this.groupBoxDirectConvolutionalCode.Controls.Add(this.textBoxEncoderInput);
            this.groupBoxDirectConvolutionalCode.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDirectConvolutionalCode.Name = "groupBoxDirectConvolutionalCode";
            this.groupBoxDirectConvolutionalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxDirectConvolutionalCode.Size = new System.Drawing.Size(655, 535);
            this.groupBoxDirectConvolutionalCode.TabIndex = 5;
            this.groupBoxDirectConvolutionalCode.TabStop = false;
            this.groupBoxDirectConvolutionalCode.Text = "Direct Convolutional Code";
            // 
            // buttonShowMistakes
            // 
            this.buttonShowMistakes.Enabled = false;
            this.buttonShowMistakes.Location = new System.Drawing.Point(529, 137);
            this.buttonShowMistakes.Name = "buttonShowMistakes";
            this.buttonShowMistakes.Size = new System.Drawing.Size(120, 23);
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
            this.numericUpDownNoiseLevel.Location = new System.Drawing.Point(127, 167);
            this.numericUpDownNoiseLevel.Name = "numericUpDownNoiseLevel";
            this.numericUpDownNoiseLevel.Size = new System.Drawing.Size(84, 20);
            this.numericUpDownNoiseLevel.TabIndex = 15;
            // 
            // labelNoiseLevel
            // 
            this.labelNoiseLevel.AutoSize = true;
            this.labelNoiseLevel.Location = new System.Drawing.Point(6, 169);
            this.labelNoiseLevel.Name = "labelNoiseLevel";
            this.labelNoiseLevel.Size = new System.Drawing.Size(115, 13);
            this.labelNoiseLevel.TabIndex = 13;
            this.labelNoiseLevel.Text = "Channel Noise (0-100):";
            // 
            // checkBoxDebug
            // 
            this.checkBoxDebug.AutoSize = true;
            this.checkBoxDebug.Location = new System.Drawing.Point(9, 197);
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
            this.labelEncoderOutput.Location = new System.Drawing.Point(129, 22);
            this.labelEncoderOutput.Name = "labelEncoderOutput";
            this.labelEncoderOutput.Size = new System.Drawing.Size(82, 13);
            this.labelEncoderOutput.TabIndex = 11;
            this.labelEncoderOutput.Text = "Encoder Output";
            // 
            // textBoxEncoderOutput
            // 
            this.textBoxEncoderOutput.Location = new System.Drawing.Point(132, 38);
            this.textBoxEncoderOutput.Multiline = true;
            this.textBoxEncoderOutput.Name = "textBoxEncoderOutput";
            this.textBoxEncoderOutput.ReadOnly = true;
            this.textBoxEncoderOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEncoderOutput.Size = new System.Drawing.Size(189, 93);
            this.textBoxEncoderOutput.TabIndex = 10;
            // 
            // textBoxDebug
            // 
            this.textBoxDebug.Location = new System.Drawing.Point(6, 233);
            this.textBoxDebug.Multiline = true;
            this.textBoxDebug.Name = "textBoxDebug";
            this.textBoxDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDebug.Size = new System.Drawing.Size(643, 283);
            this.textBoxDebug.TabIndex = 9;
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Location = new System.Drawing.Point(6, 217);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(39, 13);
            this.labelDebug.TabIndex = 8;
            this.labelDebug.Text = "Debug";
            // 
            // labelDecoderOutput
            // 
            this.labelDecoderOutput.AutoSize = true;
            this.labelDecoderOutput.Location = new System.Drawing.Point(526, 22);
            this.labelDecoderOutput.Name = "labelDecoderOutput";
            this.labelDecoderOutput.Size = new System.Drawing.Size(83, 13);
            this.labelDecoderOutput.TabIndex = 7;
            this.labelDecoderOutput.Text = "Decoder Output";
            // 
            // labelChannelOutput
            // 
            this.labelChannelOutput.AutoSize = true;
            this.labelChannelOutput.Location = new System.Drawing.Point(331, 22);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 570);
            this.Controls.Add(this.groupBoxDirectConvolutionalCode);
            this.Name = "MainForm";
            this.Text = "A15";
            this.groupBoxDirectConvolutionalCode.ResumeLayout(false);
            this.groupBoxDirectConvolutionalCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoiseLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Button buttonSendToChannel;
        private System.Windows.Forms.TextBox textBoxEncoderInput;
        private System.Windows.Forms.RichTextBox textBoxChannelOutput;
        private System.Windows.Forms.RichTextBox textBoxDecoderOutput;
        private System.Windows.Forms.GroupBox groupBoxDirectConvolutionalCode;
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
    }
}

