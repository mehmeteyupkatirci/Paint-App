namespace MyPaint
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnRectangle = new System.Windows.Forms.RadioButton();
            this.rbtnCircle = new System.Windows.Forms.RadioButton();
            this.rbtnSquare = new System.Windows.Forms.RadioButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnFill = new FontAwesome.Sharp.IconButton();
            this.btnBorder = new FontAwesome.Sharp.IconButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.rchtPanel = new System.Windows.Forms.RichTextBox();
            this.btnPerimeter = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.bunifuSeparator2);
            this.groupBox1.Controls.Add(this.btnArea);
            this.groupBox1.Controls.Add(this.btnPerimeter);
            this.groupBox1.Controls.Add(this.rbtnRectangle);
            this.groupBox1.Controls.Add(this.rbtnCircle);
            this.groupBox1.Controls.Add(this.rbtnSquare);
            this.groupBox1.Controls.Add(this.bunifuSeparator1);
            this.groupBox1.Controls.Add(this.btnFill);
            this.groupBox1.Controls.Add(this.btnBorder);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Kutusu";
            // 
            // rbtnRectangle
            // 
            this.rbtnRectangle.AutoSize = true;
            this.rbtnRectangle.Location = new System.Drawing.Point(10, 168);
            this.rbtnRectangle.Name = "rbtnRectangle";
            this.rbtnRectangle.Size = new System.Drawing.Size(77, 17);
            this.rbtnRectangle.TabIndex = 5;
            this.rbtnRectangle.TabStop = true;
            this.rbtnRectangle.Text = "Dikdörtgen";
            this.rbtnRectangle.UseVisualStyleBackColor = true;
            this.rbtnRectangle.CheckedChanged += new System.EventHandler(this.rbtnRectangle_CheckedChanged);
            // 
            // rbtnCircle
            // 
            this.rbtnCircle.AutoSize = true;
            this.rbtnCircle.Location = new System.Drawing.Point(10, 135);
            this.rbtnCircle.Name = "rbtnCircle";
            this.rbtnCircle.Size = new System.Drawing.Size(50, 17);
            this.rbtnCircle.TabIndex = 4;
            this.rbtnCircle.TabStop = true;
            this.rbtnCircle.Text = "Daire";
            this.rbtnCircle.UseVisualStyleBackColor = true;
            this.rbtnCircle.CheckedChanged += new System.EventHandler(this.rbtnCircle_CheckedChanged);
            // 
            // rbtnSquare
            // 
            this.rbtnSquare.AutoSize = true;
            this.rbtnSquare.Location = new System.Drawing.Point(10, 98);
            this.rbtnSquare.Name = "rbtnSquare";
            this.rbtnSquare.Size = new System.Drawing.Size(47, 17);
            this.rbtnSquare.TabIndex = 3;
            this.rbtnSquare.TabStop = true;
            this.rbtnSquare.Text = "Kare";
            this.rbtnSquare.UseVisualStyleBackColor = true;
            this.rbtnSquare.CheckedChanged += new System.EventHandler(this.rbtnSquare_CheckedChanged);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-6, 57);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(107, 35);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnFill
            // 
            this.btnFill.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFill.IconChar = FontAwesome.Sharp.IconChar.FillDrip;
            this.btnFill.IconColor = System.Drawing.Color.Black;
            this.btnFill.IconSize = 24;
            this.btnFill.Location = new System.Drawing.Point(53, 19);
            this.btnFill.Name = "btnFill";
            this.btnFill.Rotation = 0D;
            this.btnFill.Size = new System.Drawing.Size(37, 33);
            this.btnFill.TabIndex = 1;
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnBorder
            // 
            this.btnBorder.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBorder.IconChar = FontAwesome.Sharp.IconChar.Palette;
            this.btnBorder.IconColor = System.Drawing.Color.Black;
            this.btnBorder.IconSize = 24;
            this.btnBorder.Location = new System.Drawing.Point(10, 19);
            this.btnBorder.Name = "btnBorder";
            this.btnBorder.Rotation = 0D;
            this.btnBorder.Size = new System.Drawing.Size(37, 33);
            this.btnBorder.TabIndex = 0;
            this.btnBorder.UseVisualStyleBackColor = true;
            this.btnBorder.Click += new System.EventHandler(this.btnBorder_Click);
            // 
            // rchtPanel
            // 
            this.rchtPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rchtPanel.Location = new System.Drawing.Point(101, 404);
            this.rchtPanel.Name = "rchtPanel";
            this.rchtPanel.Size = new System.Drawing.Size(699, 46);
            this.rchtPanel.TabIndex = 1;
            this.rchtPanel.Text = "";
            // 
            // btnPerimeter
            // 
            this.btnPerimeter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPerimeter.Location = new System.Drawing.Point(3, 424);
            this.btnPerimeter.Name = "btnPerimeter";
            this.btnPerimeter.Size = new System.Drawing.Size(95, 23);
            this.btnPerimeter.TabIndex = 6;
            this.btnPerimeter.Text = "Çevre";
            this.btnPerimeter.UseVisualStyleBackColor = true;
            this.btnPerimeter.Click += new System.EventHandler(this.btnPerimeter_Click);
            // 
            // btnArea
            // 
            this.btnArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnArea.Location = new System.Drawing.Point(3, 401);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(95, 23);
            this.btnArea.TabIndex = 7;
            this.btnArea.Text = "Alan";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClear.Location = new System.Drawing.Point(3, 378);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 191);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(107, 35);
            this.bunifuSeparator2.TabIndex = 8;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rchtPanel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnFill;
        private FontAwesome.Sharp.IconButton btnBorder;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.RadioButton rbtnRectangle;
        private System.Windows.Forms.RadioButton rbtnCircle;
        private System.Windows.Forms.RadioButton rbtnSquare;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.RichTextBox rchtPanel;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnPerimeter;
        private System.Windows.Forms.Button btnClear;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
    }
}

