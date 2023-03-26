namespace ConsultaCEP
{
    partial class ConsultaCEP
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
            lblEndereco = new Label();
            txtEndereco = new TextBox();
            txtBairro = new TextBox();
            lblBairro = new Label();
            txtCidade = new TextBox();
            lblCidade = new Label();
            txtEstado = new TextBox();
            lblEstado = new Label();
            btnBuscar = new Button();
            lblCEP = new Label();
            btnLimpar = new Button();
            mskCEP = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEndereco.Location = new Point(12, 78);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(74, 21);
            lblEndereco.TabIndex = 1;
            lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            txtEndereco.Enabled = false;
            txtEndereco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereco.Location = new Point(12, 102);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(312, 29);
            txtEndereco.TabIndex = 3;
            // 
            // txtBairro
            // 
            txtBairro.Enabled = false;
            txtBairro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBairro.Location = new Point(12, 158);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(312, 29);
            txtBairro.TabIndex = 4;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBairro.Location = new Point(12, 134);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(52, 21);
            lblBairro.TabIndex = 7;
            lblBairro.Text = "Bairro";
            // 
            // txtCidade
            // 
            txtCidade.Enabled = false;
            txtCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.Location = new Point(12, 214);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(174, 29);
            txtCidade.TabIndex = 5;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCidade.Location = new Point(12, 190);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(58, 21);
            lblCidade.TabIndex = 9;
            lblCidade.Text = "Cidade";
            // 
            // txtEstado
            // 
            txtEstado.Enabled = false;
            txtEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEstado.Location = new Point(199, 214);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(56, 29);
            txtEstado.TabIndex = 6;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstado.Location = new Point(199, 190);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(56, 21);
            lblEstado.TabIndex = 11;
            lblEstado.Text = "Estado";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(155, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(169, 35);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCEP.Location = new Point(12, 9);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(37, 21);
            lblCEP.TabIndex = 12;
            lblCEP.Text = "CEP";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(156, 53);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(169, 35);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // mskCEP
            // 
            mskCEP.Location = new Point(12, 33);
            mskCEP.Mask = "00000-999";
            mskCEP.Name = "mskCEP";
            mskCEP.Size = new Size(103, 23);
            mskCEP.TabIndex = 14;
            // 
            // ConsultaCEP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 262);
            Controls.Add(mskCEP);
            Controls.Add(btnLimpar);
            Controls.Add(lblCEP);
            Controls.Add(btnBuscar);
            Controls.Add(txtEstado);
            Controls.Add(lblEstado);
            Controls.Add(txtCidade);
            Controls.Add(lblCidade);
            Controls.Add(txtBairro);
            Controls.Add(lblBairro);
            Controls.Add(txtEndereco);
            Controls.Add(lblEndereco);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ConsultaCEP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta CEP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblEndereco;
        private TextBox txtEndereco;
        private TextBox txtBairro;
        private Label lblBairro;
        private TextBox txtCidade;
        private Label lblCidade;
        private TextBox txtEstado;
        private Label lblEstado;
        private Button btnBuscar;
        private Label lblCEP;
        private Button btnLimpar;
        private MaskedTextBox mskCEP;
    }
}