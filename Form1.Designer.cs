namespace Aula_Forms_2
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
            lblCategoria = new Label();
            lblCategoriaAluno = new Label();
            lblAnoAniversario = new Label();
            lblAnoNascimento = new Label();
            lblNome = new Label();
            btnVerificar = new Button();
            txtNome = new TextBox();
            txtAnoNascimento = new TextBox();
            txtAnoAniversario = new TextBox();
            SuspendLayout();
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(552, 381);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 0;
            lblCategoria.Text = "Categoria:";
            // 
            // lblCategoriaAluno
            // 
            lblCategoriaAluno.BackColor = Color.Yellow;
            lblCategoriaAluno.BorderStyle = BorderStyle.Fixed3D;
            lblCategoriaAluno.Location = new Point(631, 371);
            lblCategoriaAluno.Name = "lblCategoriaAluno";
            lblCategoriaAluno.Size = new Size(118, 35);
            lblCategoriaAluno.TabIndex = 1;
            lblCategoriaAluno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAnoAniversario
            // 
            lblAnoAniversario.AutoSize = true;
            lblAnoAniversario.Location = new Point(512, 221);
            lblAnoAniversario.Name = "lblAnoAniversario";
            lblAnoAniversario.Size = new Size(133, 15);
            lblAnoAniversario.TabIndex = 2;
            lblAnoAniversario.Text = "Ano Último Aniversário:";
            // 
            // lblAnoNascimento
            // 
            lblAnoNascimento.AutoSize = true;
            lblAnoNascimento.Location = new Point(31, 224);
            lblAnoNascimento.Name = "lblAnoNascimento";
            lblAnoNascimento.Size = new Size(115, 15);
            lblAnoNascimento.TabIndex = 3;
            lblAnoNascimento.Text = "Ano de Nascimento:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(31, 78);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(48, 361);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(178, 35);
            btnVerificar.TabIndex = 5;
            btnVerificar.Text = "Identificar Categoria";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(80, 75);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(681, 23);
            txtNome.TabIndex = 6;
            // 
            // txtAnoNascimento
            // 
            txtAnoNascimento.Location = new Point(152, 221);
            txtAnoNascimento.Name = "txtAnoNascimento";
            txtAnoNascimento.Size = new Size(100, 23);
            txtAnoNascimento.TabIndex = 7;
            // 
            // txtAnoAniversario
            // 
            txtAnoAniversario.Location = new Point(661, 218);
            txtAnoAniversario.Name = "txtAnoAniversario";
            txtAnoAniversario.Size = new Size(100, 23);
            txtAnoAniversario.TabIndex = 8;
            txtAnoAniversario.Enter += textBox3_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAnoAniversario);
            Controls.Add(txtAnoNascimento);
            Controls.Add(txtNome);
            Controls.Add(btnVerificar);
            Controls.Add(lblNome);
            Controls.Add(lblAnoNascimento);
            Controls.Add(lblAnoAniversario);
            Controls.Add(lblCategoriaAluno);
            Controls.Add(lblCategoria);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoria;
        private Label lblCategoriaAluno;
        private Label lblAnoAniversario;
        private Label lblAnoNascimento;
        private Label lblNome;
        private Button btnVerificar;
        private TextBox txtNome;
        private TextBox txtAnoNascimento;
        private TextBox txtAnoAniversario;
    }
}
