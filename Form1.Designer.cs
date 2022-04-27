namespace CS311_FinalProject_ASG
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtfDirections = new System.Windows.Forms.RichTextBox();
            this.lblAmountToBeConverted = new System.Windows.Forms.Label();
            this.lblMeasureType = new System.Windows.Forms.Label();
            this.txtAmountToBeConverted = new System.Windows.Forms.TextBox();
            this.cboWhatMeasure = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblConversionOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtfDirections
            // 
            this.rtfDirections.Location = new System.Drawing.Point(128, 54);
            this.rtfDirections.Name = "rtfDirections";
            this.rtfDirections.Size = new System.Drawing.Size(515, 78);
            this.rtfDirections.TabIndex = 0;
            this.rtfDirections.Text = resources.GetString("rtfDirections.Text");
            // 
            // lblAmountToBeConverted
            // 
            this.lblAmountToBeConverted.AutoSize = true;
            this.lblAmountToBeConverted.Location = new System.Drawing.Point(125, 141);
            this.lblAmountToBeConverted.Name = "lblAmountToBeConverted";
            this.lblAmountToBeConverted.Size = new System.Drawing.Size(122, 13);
            this.lblAmountToBeConverted.TabIndex = 1;
            this.lblAmountToBeConverted.Text = "Amount to be Converted";
            // 
            // lblMeasureType
            // 
            this.lblMeasureType.AutoSize = true;
            this.lblMeasureType.Location = new System.Drawing.Point(125, 179);
            this.lblMeasureType.Name = "lblMeasureType";
            this.lblMeasureType.Size = new System.Drawing.Size(135, 13);
            this.lblMeasureType.TabIndex = 2;
            this.lblMeasureType.Text = "What type of measure is it?";
            // 
            // txtAmountToBeConverted
            // 
            this.txtAmountToBeConverted.Location = new System.Drawing.Point(281, 138);
            this.txtAmountToBeConverted.Name = "txtAmountToBeConverted";
            this.txtAmountToBeConverted.Size = new System.Drawing.Size(100, 20);
            this.txtAmountToBeConverted.TabIndex = 3;
            // 
            // cboWhatMeasure
            // 
            this.cboWhatMeasure.FormattingEnabled = true;
            this.cboWhatMeasure.Items.AddRange(new object[] {
            "Temperature",
            "Weight",
            "Length"});
            this.cboWhatMeasure.Location = new System.Drawing.Point(281, 171);
            this.cboWhatMeasure.Name = "cboWhatMeasure";
            this.cboWhatMeasure.Size = new System.Drawing.Size(121, 21);
            this.cboWhatMeasure.TabIndex = 4;
            this.cboWhatMeasure.SelectedIndexChanged += new System.EventHandler(this.cboWhatMeasure_SelectedIndexChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(128, 351);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(188, 68);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblConversionOutput
            // 
            this.lblConversionOutput.AutoSize = true;
            this.lblConversionOutput.Location = new System.Drawing.Point(366, 372);
            this.lblConversionOutput.Name = "lblConversionOutput";
            this.lblConversionOutput.Size = new System.Drawing.Size(37, 13);
            this.lblConversionOutput.TabIndex = 6;
            this.lblConversionOutput.Text = "output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConversionOutput);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cboWhatMeasure);
            this.Controls.Add(this.txtAmountToBeConverted);
            this.Controls.Add(this.lblMeasureType);
            this.Controls.Add(this.lblAmountToBeConverted);
            this.Controls.Add(this.rtfDirections);
            this.Name = "Form1";
            this.Text = "Conversion Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfDirections;
        private System.Windows.Forms.Label lblAmountToBeConverted;
        private System.Windows.Forms.Label lblMeasureType;
        private System.Windows.Forms.TextBox txtAmountToBeConverted;
        private System.Windows.Forms.ComboBox cboWhatMeasure;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblConversionOutput;
    }
}

