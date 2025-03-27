namespace App5_Triangulos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lado1Txt = new System.Windows.Forms.TextBox();
            this.lado2Txt = new System.Windows.Forms.TextBox();
            this.lado3Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calcularBtn = new System.Windows.Forms.Button();
            this.limparBtn = new System.Windows.Forms.Button();
            this.sairBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.sairBtn);
            this.panel1.Controls.Add(this.limparBtn);
            this.panel1.Controls.Add(this.calcularBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lado3Txt);
            this.panel1.Controls.Add(this.lado2Txt);
            this.panel1.Controls.Add(this.lado1Txt);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 437);
            this.panel1.TabIndex = 0;
            // 
            // lado1Txt
            // 
            this.lado1Txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lado1Txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lado1Txt.Location = new System.Drawing.Point(18, 60);
            this.lado1Txt.Name = "lado1Txt";
            this.lado1Txt.Size = new System.Drawing.Size(152, 39);
            this.lado1Txt.TabIndex = 0;
            // 
            // lado2Txt
            // 
            this.lado2Txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lado2Txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lado2Txt.Location = new System.Drawing.Point(18, 158);
            this.lado2Txt.Name = "lado2Txt";
            this.lado2Txt.Size = new System.Drawing.Size(152, 39);
            this.lado2Txt.TabIndex = 1;
            // 
            // lado3Txt
            // 
            this.lado3Txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lado3Txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lado3Txt.Location = new System.Drawing.Point(18, 262);
            this.lado3Txt.Name = "lado3Txt";
            this.lado3Txt.Size = new System.Drawing.Size(152, 39);
            this.lado3Txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lado A:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lado B:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lado C:";
            // 
            // calcularBtn
            // 
            this.calcularBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcularBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcularBtn.Location = new System.Drawing.Point(18, 362);
            this.calcularBtn.Name = "calcularBtn";
            this.calcularBtn.Size = new System.Drawing.Size(99, 42);
            this.calcularBtn.TabIndex = 6;
            this.calcularBtn.Text = "Calcular";
            this.calcularBtn.UseVisualStyleBackColor = true;
            this.calcularBtn.Click += new System.EventHandler(this.CalcularBtn_Click);
            // 
            // limparBtn
            // 
            this.limparBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.limparBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparBtn.Location = new System.Drawing.Point(123, 362);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(103, 42);
            this.limparBtn.TabIndex = 7;
            this.limparBtn.Text = "Limpar";
            this.limparBtn.UseVisualStyleBackColor = true;
            // 
            // sairBtn
            // 
            this.sairBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sairBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairBtn.Location = new System.Drawing.Point(232, 362);
            this.sairBtn.Name = "sairBtn";
            this.sairBtn.Size = new System.Drawing.Size(96, 42);
            this.sairBtn.TabIndex = 8;
            this.sairBtn.Text = "Sair";
            this.sairBtn.UseVisualStyleBackColor = true;
            this.sairBtn.Click += new System.EventHandler(this.SairBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App5_Triangulos.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sairBtn;
        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.Button calcularBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lado3Txt;
        private System.Windows.Forms.TextBox lado2Txt;
        private System.Windows.Forms.TextBox lado1Txt;
    }
}

