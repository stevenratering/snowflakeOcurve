namespace Snowflake
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.myShapeO = new System.Windows.Forms.RadioButton();
            this.myShapeSnow = new System.Windows.Forms.RadioButton();
            this.myLevel = new System.Windows.Forms.TextBox();
            this.myColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.Panel();
            this.myNested = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.myNested);
            this.panel1.Controls.Add(this.myShapeO);
            this.panel1.Controls.Add(this.myShapeSnow);
            this.panel1.Controls.Add(this.myLevel);
            this.panel1.Controls.Add(this.myColor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 63);
            this.panel1.TabIndex = 0;
            // 
            // myShapeO
            // 
            this.myShapeO.AutoSize = true;
            this.myShapeO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myShapeO.Location = new System.Drawing.Point(135, 11);
            this.myShapeO.Name = "myShapeO";
            this.myShapeO.Size = new System.Drawing.Size(81, 20);
            this.myShapeO.TabIndex = 6;
            this.myShapeO.Text = "O Curve";
            this.myShapeO.UseVisualStyleBackColor = true;
            this.myShapeO.CheckedChanged += new System.EventHandler(this.myShapeO_CheckedChanged);
            // 
            // myShapeSnow
            // 
            this.myShapeSnow.AutoSize = true;
            this.myShapeSnow.Checked = true;
            this.myShapeSnow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myShapeSnow.Location = new System.Drawing.Point(32, 11);
            this.myShapeSnow.Name = "myShapeSnow";
            this.myShapeSnow.Size = new System.Drawing.Size(97, 20);
            this.myShapeSnow.TabIndex = 5;
            this.myShapeSnow.TabStop = true;
            this.myShapeSnow.Text = "Snowflake";
            this.myShapeSnow.UseVisualStyleBackColor = true;
            this.myShapeSnow.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // myLevel
            // 
            this.myLevel.Location = new System.Drawing.Point(452, 27);
            this.myLevel.Name = "myLevel";
            this.myLevel.Size = new System.Drawing.Size(51, 20);
            this.myLevel.TabIndex = 3;
            this.myLevel.Text = "0";
            this.myLevel.TextChanged += new System.EventHandler(this.myLevel_TextChanged);
            this.myLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.myLevel_KeyDown);
            this.myLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.myLevel_KeyPress);
            // 
            // myColor
            // 
            this.myColor.Location = new System.Drawing.Point(317, 27);
            this.myColor.Name = "myColor";
            this.myColor.Size = new System.Drawing.Size(51, 20);
            this.myColor.TabIndex = 2;
            this.myColor.Text = "Blue";
            this.myColor.TextChanged += new System.EventHandler(this.color_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "level";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "color";
            // 
            // canvas
            // 
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 63);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(800, 387);
            this.canvas.TabIndex = 1;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // myNested
            // 
            this.myNested.AutoSize = true;
            this.myNested.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myNested.Location = new System.Drawing.Point(32, 40);
            this.myNested.Name = "myNested";
            this.myNested.Size = new System.Drawing.Size(74, 20);
            this.myNested.TabIndex = 7;
            this.myNested.Text = "nested";
            this.myNested.UseVisualStyleBackColor = true;
            this.myNested.CheckedChanged += new System.EventHandler(this.myNested_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.TextBox myLevel;
        private System.Windows.Forms.TextBox myColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton myShapeSnow;
        private System.Windows.Forms.RadioButton myShapeO;
        private System.Windows.Forms.CheckBox myNested;
    }
}

