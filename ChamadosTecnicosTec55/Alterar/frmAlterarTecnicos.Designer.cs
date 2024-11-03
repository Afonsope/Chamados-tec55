namespace ChamadosTecnicosTec55.Alterar
{
    partial class frmAlterarTecnicos
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
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEspecialidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(269, 20);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 21;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(148, 415);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 20;
            this.btnOk.Text = "ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(11, 346);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(358, 63);
            this.txtObs.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Obs";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(8, 201);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(358, 33);
            this.txtSenha.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Senha";
            // 
            // txtEspecialidade
            // 
            this.txtEspecialidade.Location = new System.Drawing.Point(8, 138);
            this.txtEspecialidade.Multiline = true;
            this.txtEspecialidade.Name = "txtEspecialidade";
            this.txtEspecialidade.Size = new System.Drawing.Size(358, 30);
            this.txtEspecialidade.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Especialidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(8, 80);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(361, 28);
            this.txtNome.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Alterar Tecnico";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(5, 261);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 22;
            this.Email.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(8, 277);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(358, 33);
            this.txtEmail.TabIndex = 23;
            // 
            // frmAlterarTecnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEspecialidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "frmAlterarTecnicos";
            this.Text = "frmAlterarTecnicos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEspecialidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox txtEmail;
    }
}