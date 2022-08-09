namespace HerancaProfessorAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCadAluno = new System.Windows.Forms.Button();
            this.radProfessor = new System.Windows.Forms.RadioButton();
            this.radAluno = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCadProf = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(85, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMedia.Location = new System.Drawing.Point(85, 148);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(62, 21);
            this.lblMedia.TabIndex = 2;
            this.lblMedia.Text = "Média:";
            this.lblMedia.Visible = false;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalario.Location = new System.Drawing.Point(85, 149);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(67, 21);
            this.lblSalario.TabIndex = 3;
            this.lblSalario.Text = "Salário:";
            this.lblSalario.Visible = false;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatricula.Location = new System.Drawing.Point(173, 48);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(241, 29);
            this.txtMatricula.TabIndex = 7;
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(173, 93);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(241, 29);
            this.txtNome.TabIndex = 8;
            // 
            // txtMedia
            // 
            this.txtMedia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMedia.Location = new System.Drawing.Point(173, 146);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(241, 29);
            this.txtMedia.TabIndex = 9;
            this.txtMedia.Visible = false;
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalario.Location = new System.Drawing.Point(173, 146);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(241, 29);
            this.txtSalario.TabIndex = 10;
            this.txtSalario.Visible = false;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // btnCadAluno
            // 
            this.btnCadAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadAluno.Location = new System.Drawing.Point(259, 405);
            this.btnCadAluno.Name = "btnCadAluno";
            this.btnCadAluno.Size = new System.Drawing.Size(122, 57);
            this.btnCadAluno.TabIndex = 15;
            this.btnCadAluno.Text = "CADASTRAR ALUNO";
            this.btnCadAluno.UseVisualStyleBackColor = true;
            this.btnCadAluno.Click += new System.EventHandler(this.btnCadAluno_Click);
            // 
            // radProfessor
            // 
            this.radProfessor.AutoSize = true;
            this.radProfessor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radProfessor.Location = new System.Drawing.Point(127, 301);
            this.radProfessor.Name = "radProfessor";
            this.radProfessor.Size = new System.Drawing.Size(117, 25);
            this.radProfessor.TabIndex = 16;
            this.radProfessor.TabStop = true;
            this.radProfessor.Text = "PROFESSOR";
            this.radProfessor.UseVisualStyleBackColor = true;
            this.radProfessor.CheckedChanged += new System.EventHandler(this.radProfessor_CheckedChanged);
            // 
            // radAluno
            // 
            this.radAluno.AutoSize = true;
            this.radAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radAluno.Location = new System.Drawing.Point(127, 344);
            this.radAluno.Name = "radAluno";
            this.radAluno.Size = new System.Drawing.Size(84, 25);
            this.radAluno.TabIndex = 17;
            this.radAluno.TabStop = true;
            this.radAluno.Text = "ALUNO";
            this.radAluno.UseVisualStyleBackColor = true;
            this.radAluno.CheckedChanged += new System.EventHandler(this.radAluno_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCadProf);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(45, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 251);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deseja Cadastrar?";
            // 
            // btnCadProf
            // 
            this.btnCadProf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadProf.Location = new System.Drawing.Point(40, 142);
            this.btnCadProf.Name = "btnCadProf";
            this.btnCadProf.Size = new System.Drawing.Size(122, 57);
            this.btnCadProf.TabIndex = 19;
            this.btnCadProf.Text = "CADASTRAR PROFESSOR";
            this.btnCadProf.UseVisualStyleBackColor = true;
            this.btnCadProf.Click += new System.EventHandler(this.btnCadProf_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(523, 100);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 15);
            this.lblResposta.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 603);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.radAluno);
            this.Controls.Add(this.radProfessor);
            this.Controls.Add(this.btnCadAluno);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblMedia;
        private Label lblSalario;
        private TextBox txtMatricula;
        private TextBox txtNome;
        private TextBox txtMedia;
        private TextBox txtSalario;
        private Button btnCadAluno;
        private RadioButton radProfessor;
        private RadioButton radAluno;
        private GroupBox groupBox1;
        private Button btnCadProf;
        private Label lblResposta;
    }
}