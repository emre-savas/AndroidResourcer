namespace DotNetResourcer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.btnPaste = new System.Windows.Forms.Button();
            this.pnlTextWithPadding = new System.Windows.Forms.Panel();
            this.pnlTextbox = new System.Windows.Forms.Panel();
            this.lblTextMaxLength = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.xmlOpen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlTextWithPadding.SuspendLayout();
            this.pnlTextbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtText.Location = new System.Drawing.Point(4, 0);
            this.txtText.Margin = new System.Windows.Forms.Padding(0);
            this.txtText.MaxLength = 500;
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(686, 45);
            this.txtText.TabIndex = 0;
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            this.txtText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtText_KeyDown);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblText.Location = new System.Drawing.Point(12, 15);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(39, 20);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Text";
            // 
            // txtKey
            // 
            this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKey.Location = new System.Drawing.Point(50, 154);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKey.MaxLength = 500;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(421, 23);
            this.txtKey.TabIndex = 0;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKey.Location = new System.Drawing.Point(11, 157);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(35, 20);
            this.lblKey.TabIndex = 1;
            this.lblKey.Text = "Key";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrefix.Location = new System.Drawing.Point(543, 154);
            this.txtPrefix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(202, 23);
            this.txtPrefix.TabIndex = 0;
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(488, 154);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(48, 20);
            this.lblPrefix.TabIndex = 1;
            this.lblPrefix.Text = "Prefix";
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.SystemColors.Control;
            this.btnPaste.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPaste.Image = global::DotNetResourcer.Properties.Resources.clipboard;
            this.btnPaste.Location = new System.Drawing.Point(3, 3);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(35, 45);
            this.btnPaste.TabIndex = 2;
            this.btnPaste.UseVisualStyleBackColor = false;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // pnlTextWithPadding
            // 
            this.pnlTextWithPadding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTextWithPadding.BackColor = System.Drawing.Color.White;
            this.pnlTextWithPadding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTextWithPadding.Controls.Add(this.pnlTextbox);
            this.pnlTextWithPadding.Controls.Add(this.btnPaste);
            this.pnlTextWithPadding.Location = new System.Drawing.Point(12, 56);
            this.pnlTextWithPadding.Name = "pnlTextWithPadding";
            this.pnlTextWithPadding.Padding = new System.Windows.Forms.Padding(3);
            this.pnlTextWithPadding.Size = new System.Drawing.Size(733, 53);
            this.pnlTextWithPadding.TabIndex = 5;
            // 
            // pnlTextbox
            // 
            this.pnlTextbox.Controls.Add(this.txtText);
            this.pnlTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTextbox.Location = new System.Drawing.Point(38, 3);
            this.pnlTextbox.Name = "pnlTextbox";
            this.pnlTextbox.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.pnlTextbox.Size = new System.Drawing.Size(690, 45);
            this.pnlTextbox.TabIndex = 3;
            // 
            // lblTextMaxLength
            // 
            this.lblTextMaxLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextMaxLength.AutoSize = true;
            this.lblTextMaxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTextMaxLength.Location = new System.Drawing.Point(782, 122);
            this.lblTextMaxLength.Name = "lblTextMaxLength";
            this.lblTextMaxLength.Size = new System.Drawing.Size(28, 13);
            this.lblTextMaxLength.TabIndex = 1;
            this.lblTextMaxLength.Text = "Text";
            this.lblTextMaxLength.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Image = global::DotNetResourcer.Properties.Resources.copy;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(176, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "javaCopy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xmlOpen
            // 
            this.xmlOpen.Image = global::DotNetResourcer.Properties.Resources.copy;
            this.xmlOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xmlOpen.Location = new System.Drawing.Point(543, 115);
            this.xmlOpen.Name = "xmlOpen";
            this.xmlOpen.Size = new System.Drawing.Size(202, 30);
            this.xmlOpen.TabIndex = 8;
            this.xmlOpen.Text = "Xml Layout To Strings";
            this.xmlOpen.UseVisualStyleBackColor = true;
            this.xmlOpen.Click += new System.EventHandler(this.xmlOpen_Click);
            // 
            // button2
            // 
            this.button2.Image = global::DotNetResourcer.Properties.Resources.copy;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "xmlCopy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Image = global::DotNetResourcer.Properties.Resources.settings;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(601, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 30);
            this.button4.TabIndex = 11;
            this.button4.Text = "File Path";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(436, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 29);
            this.button3.TabIndex = 12;
            this.button3.Text = "Strings => Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 201);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.xmlOpen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlTextWithPadding);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.lblPrefix);
            this.Controls.Add(this.lblTextMaxLength);
            this.Controls.Add(this.lblText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 50);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1048);
            this.MinimumSize = new System.Drawing.Size(713, 240);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = ".Net Resourcer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTextWithPadding.ResumeLayout(false);
            this.pnlTextbox.ResumeLayout(false);
            this.pnlTextbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Panel pnlTextWithPadding;
        private System.Windows.Forms.Panel pnlTextbox;
        private System.Windows.Forms.Label lblTextMaxLength;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button xmlOpen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

