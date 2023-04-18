namespace WinCEP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnconsu = new Button();
            txtCEP = new MaskedTextBox();
            txtendereco = new TextBox();
            txtbairro = new TextBox();
            txtCidade = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 54);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "CEP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 54);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // btnconsu
            // 
            btnconsu.Location = new Point(337, 51);
            btnconsu.Name = "btnconsu";
            btnconsu.Size = new Size(75, 23);
            btnconsu.TabIndex = 5;
            btnconsu.Text = "consultar";
            btnconsu.UseVisualStyleBackColor = true;
            btnconsu.Click += btnconsu_Click;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(68, 51);
            txtCEP.Mask = "00000-999";
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(117, 23);
            txtCEP.TabIndex = 6;
            // 
            // txtendereco
            // 
            txtendereco.Location = new Point(68, 106);
            txtendereco.Name = "txtendereco";
            txtendereco.Size = new Size(183, 23);
            txtendereco.TabIndex = 7;
            txtendereco.TextChanged += txtendereco_TextChanged;
            // 
            // txtbairro
            // 
            txtbairro.Location = new Point(68, 148);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(183, 23);
            txtbairro.TabIndex = 8;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(68, 194);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(183, 23);
            txtCidade.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 156);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 11;
            label3.Text = "Bairro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 114);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 12;
            label4.Text = "Endereço";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 197);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 13;
            label5.Text = "Cidade";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 229);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCidade);
            Controls.Add(txtbairro);
            Controls.Add(txtendereco);
            Controls.Add(txtCEP);
            Controls.Add(btnconsu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "qqq";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnconsu;
        private MaskedTextBox txtCEP;
        private TextBox txtendereco;
        private TextBox txtbairro;
        private TextBox txtCidade;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}