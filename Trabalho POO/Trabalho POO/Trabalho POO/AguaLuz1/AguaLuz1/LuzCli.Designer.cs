namespace AguaLuz1
{
    partial class LuzCli
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CONSULTA1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(202, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 74);
            this.button5.TabIndex = 34;
            this.button5.Text = "MAIOR VALOR E MAIOR CONSUMO";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(38, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 74);
            this.button4.TabIndex = 33;
            this.button4.Text = "VALOR MÉDIO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(202, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 74);
            this.button3.TabIndex = 32;
            this.button3.Text = "VARIAÇÃO DE VALOR ENTRE DOIS MESES";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(38, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 74);
            this.button2.TabIndex = 31;
            this.button2.Text = "VARIAÇÃO DE CONSUMO ENTRE DOIS MESES";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(202, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 74);
            this.button1.TabIndex = 30;
            this.button1.Text = "VALOR TOTAL ULTIMA CONTA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CONSULTA1
            // 
            this.CONSULTA1.BackColor = System.Drawing.Color.Transparent;
            this.CONSULTA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONSULTA1.Location = new System.Drawing.Point(38, 70);
            this.CONSULTA1.Name = "CONSULTA1";
            this.CONSULTA1.Size = new System.Drawing.Size(158, 74);
            this.CONSULTA1.TabIndex = 29;
            this.CONSULTA1.Text = "CONSULTAR CONSUMO ULTIMO MÊS";
            this.CONSULTA1.UseVisualStyleBackColor = false;
            this.CONSULTA1.Click += new System.EventHandler(this.CONSULTA1_Click);
            // 
            // LuzCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AguaLuz1.Properties.Resources.energia21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(398, 375);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CONSULTA1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LuzCli";
            this.Text = "LuzCli";
            this.Load += new System.EventHandler(this.LuzCli_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CONSULTA1;
    }
}