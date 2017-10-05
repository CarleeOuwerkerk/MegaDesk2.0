namespace MegaDesk_3_CarleeMurphy
{
    partial class GetQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetQuote));
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.DrawersLabel = new System.Windows.Forms.Label();
            this.WidthField = new System.Windows.Forms.NumericUpDown();
            this.DepthField = new System.Windows.Forms.NumericUpDown();
            this.DrawerField = new System.Windows.Forms.NumericUpDown();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.ShippingLabel = new System.Windows.Forms.Label();
            this.deskImage = new System.Windows.Forms.PictureBox();
            this.AddNewQuote = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.MaterialBox = new System.Windows.Forms.ComboBox();
            this.ShippingBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.WidthField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawerField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskImage)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(34, 56);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(53, 17);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name: ";
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(90, 56);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(205, 22);
            this.NameField.TabIndex = 1;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLabel.Location = new System.Drawing.Point(48, 91);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(108, 17);
            this.WidthLabel.TabIndex = 4;
            this.WidthLabel.Text = "Width in Inches:";
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthLabel.Location = new System.Drawing.Point(47, 125);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(110, 17);
            this.DepthLabel.TabIndex = 5;
            this.DepthLabel.Text = "Depth in Inches:";
            // 
            // DrawersLabel
            // 
            this.DrawersLabel.AutoSize = true;
            this.DrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawersLabel.Location = new System.Drawing.Point(93, 161);
            this.DrawersLabel.Name = "DrawersLabel";
            this.DrawersLabel.Size = new System.Drawing.Size(64, 17);
            this.DrawersLabel.TabIndex = 7;
            this.DrawersLabel.Text = "Drawers:";
            // 
            // WidthField
            // 
            this.WidthField.Location = new System.Drawing.Point(159, 89);
            this.WidthField.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.WidthField.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.WidthField.Name = "WidthField";
            this.WidthField.Size = new System.Drawing.Size(136, 22);
            this.WidthField.TabIndex = 2;
            this.WidthField.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.WidthField.Validating += new System.ComponentModel.CancelEventHandler(this.WidthField_Validating);
            // 
            // DepthField
            // 
            this.DepthField.Location = new System.Drawing.Point(159, 123);
            this.DepthField.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.DepthField.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DepthField.Name = "DepthField";
            this.DepthField.Size = new System.Drawing.Size(136, 22);
            this.DepthField.TabIndex = 3;
            this.DepthField.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DepthField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthField_KeyPress);
            // 
            // DrawerField
            // 
            this.DrawerField.Location = new System.Drawing.Point(159, 159);
            this.DrawerField.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.DrawerField.Name = "DrawerField";
            this.DrawerField.Size = new System.Drawing.Size(136, 22);
            this.DrawerField.TabIndex = 4;
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialLabel.Location = new System.Drawing.Point(95, 197);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(62, 17);
            this.MaterialLabel.TabIndex = 11;
            this.MaterialLabel.Text = "Material:";
            // 
            // ShippingLabel
            // 
            this.ShippingLabel.AutoSize = true;
            this.ShippingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShippingLabel.Location = new System.Drawing.Point(86, 234);
            this.ShippingLabel.Name = "ShippingLabel";
            this.ShippingLabel.Size = new System.Drawing.Size(67, 17);
            this.ShippingLabel.TabIndex = 13;
            this.ShippingLabel.Text = "Shipping:";
            // 
            // deskImage
            // 
            this.deskImage.Image = ((System.Drawing.Image)(resources.GetObject("deskImage.Image")));
            this.deskImage.Location = new System.Drawing.Point(299, 58);
            this.deskImage.Name = "deskImage";
            this.deskImage.Size = new System.Drawing.Size(281, 217);
            this.deskImage.TabIndex = 2;
            this.deskImage.TabStop = false;
            // 
            // AddNewQuote
            // 
            this.AddNewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewQuote.Location = new System.Drawing.Point(116, 294);
            this.AddNewQuote.Name = "AddNewQuote";
            this.AddNewQuote.Size = new System.Drawing.Size(182, 48);
            this.AddNewQuote.TabIndex = 15;
            this.AddNewQuote.Text = "Get Quote";
            this.AddNewQuote.UseVisualStyleBackColor = true;
            this.AddNewQuote.Click += new System.EventHandler(this.AddNewQuote_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(12, 314);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(78, 28);
            this.BackButton.TabIndex = 16;
            this.BackButton.Text = "<< Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MaterialBox
            // 
            this.MaterialBox.FormattingEnabled = true;
            this.MaterialBox.Location = new System.Drawing.Point(159, 195);
            this.MaterialBox.Name = "MaterialBox";
            this.MaterialBox.Size = new System.Drawing.Size(136, 24);
            this.MaterialBox.TabIndex = 5;
            // 
            // ShippingBox
            // 
            this.ShippingBox.FormattingEnabled = true;
            this.ShippingBox.Items.AddRange(new object[] {
            "3 Day",
            "5 Day",
            "7 Day"});
            this.ShippingBox.Location = new System.Drawing.Point(159, 231);
            this.ShippingBox.Name = "ShippingBox";
            this.ShippingBox.Size = new System.Drawing.Size(136, 24);
            this.ShippingBox.TabIndex = 6;
            // 
            // GetQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.ShippingBox);
            this.Controls.Add(this.MaterialBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddNewQuote);
            this.Controls.Add(this.ShippingLabel);
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.DrawerField);
            this.Controls.Add(this.DepthField);
            this.Controls.Add(this.WidthField);
            this.Controls.Add(this.DrawersLabel);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.deskImage);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.NameLabel);
            this.Name = "GetQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.WidthField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawerField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.Label DrawersLabel;
        private System.Windows.Forms.NumericUpDown WidthField;
        private System.Windows.Forms.NumericUpDown DepthField;
        private System.Windows.Forms.NumericUpDown DrawerField;
        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.Label ShippingLabel;
        private System.Windows.Forms.PictureBox deskImage;
        private System.Windows.Forms.Button AddNewQuote;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox MaterialBox;
        private System.Windows.Forms.ComboBox ShippingBox;
    }
}