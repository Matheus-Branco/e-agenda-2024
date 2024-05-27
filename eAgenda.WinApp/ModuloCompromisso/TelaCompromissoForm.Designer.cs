namespace eAgenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            lblId = new Label();
            lblAssunto = new Label();
            lblData = new Label();
            lblInicio = new Label();
            lblTermino = new Label();
            txtboxId = new TextBox();
            txtboxAssunto = new TextBox();
            dtpData = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            dtpTermino = new DateTimePicker();
            chckbxContatoCompromisso = new CheckBox();
            lblContatoCompromisso = new Label();
            cmbbxContatoCompromisso = new ComboBox();
            gpbxLocal = new GroupBox();
            radiobtnRemoto = new RadioButton();
            radiobtnPresencial = new RadioButton();
            txtbxRemoto = new TextBox();
            txtbxPesencial = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            gpbxLocal.SuspendLayout();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(73, 58);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // lblAssunto
            // 
            lblAssunto.AutoSize = true;
            lblAssunto.Location = new Point(40, 90);
            lblAssunto.Name = "lblAssunto";
            lblAssunto.Size = new Size(53, 15);
            lblAssunto.TabIndex = 1;
            lblAssunto.Text = "Assunto:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(59, 122);
            lblData.Name = "lblData";
            lblData.Size = new Size(34, 15);
            lblData.TabIndex = 2;
            lblData.Text = "Data:";
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(54, 155);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(39, 15);
            lblInicio.TabIndex = 3;
            lblInicio.Text = "Início:";
            // 
            // lblTermino
            // 
            lblTermino.AutoSize = true;
            lblTermino.Location = new Point(205, 155);
            lblTermino.Name = "lblTermino";
            lblTermino.Size = new Size(53, 15);
            lblTermino.TabIndex = 4;
            lblTermino.Text = "Término:";
            // 
            // txtboxId
            // 
            txtboxId.Location = new Point(99, 57);
            txtboxId.Name = "txtboxId";
            txtboxId.Size = new Size(100, 23);
            txtboxId.TabIndex = 1;
            // 
            // txtboxAssunto
            // 
            txtboxAssunto.Location = new Point(99, 86);
            txtboxAssunto.Name = "txtboxAssunto";
            txtboxAssunto.Size = new Size(265, 23);
            txtboxAssunto.TabIndex = 2;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(99, 118);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(265, 23);
            dtpData.TabIndex = 3;
            dtpData.Value = new DateTime(2024, 5, 23, 0, 0, 0, 0);
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(99, 152);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(100, 23);
            dtpInicio.TabIndex = 4;
            dtpInicio.Value = new DateTime(2024, 5, 22, 14, 32, 5, 0);
            // 
            // dtpTermino
            // 
            dtpTermino.Location = new Point(264, 152);
            dtpTermino.Name = "dtpTermino";
            dtpTermino.Size = new Size(100, 23);
            dtpTermino.TabIndex = 5;
            dtpTermino.Value = new DateTime(2024, 5, 22, 14, 50, 0, 0);
            // 
            // chckbxContatoCompromisso
            // 
            chckbxContatoCompromisso.AutoSize = true;
            chckbxContatoCompromisso.Location = new Point(99, 191);
            chckbxContatoCompromisso.Name = "chckbxContatoCompromisso";
            chckbxContatoCompromisso.Size = new Size(15, 14);
            chckbxContatoCompromisso.TabIndex = 6;
            chckbxContatoCompromisso.UseVisualStyleBackColor = true;
            // 
            // lblContatoCompromisso
            // 
            lblContatoCompromisso.AutoSize = true;
            lblContatoCompromisso.Location = new Point(120, 190);
            lblContatoCompromisso.Name = "lblContatoCompromisso";
            lblContatoCompromisso.Size = new Size(293, 15);
            lblContatoCompromisso.TabIndex = 7;
            lblContatoCompromisso.Text = "Deeseja relacionar algum contato à esse compromisso";
            // 
            // cmbbxContatoCompromisso
            // 
            cmbbxContatoCompromisso.FormattingEnabled = true;
            cmbbxContatoCompromisso.Location = new Point(99, 211);
            cmbbxContatoCompromisso.Name = "cmbbxContatoCompromisso";
            cmbbxContatoCompromisso.Size = new Size(121, 23);
            cmbbxContatoCompromisso.TabIndex = 8;
            // 
            // gpbxLocal
            // 
            gpbxLocal.Controls.Add(txtbxPesencial);
            gpbxLocal.Controls.Add(txtbxRemoto);
            gpbxLocal.Controls.Add(radiobtnPresencial);
            gpbxLocal.Controls.Add(radiobtnRemoto);
            gpbxLocal.Location = new Point(99, 258);
            gpbxLocal.Name = "gpbxLocal";
            gpbxLocal.Size = new Size(291, 122);
            gpbxLocal.TabIndex = 9;
            gpbxLocal.TabStop = false;
            gpbxLocal.Text = "Localização";
            // 
            // radiobtnRemoto
            // 
            radiobtnRemoto.AutoSize = true;
            radiobtnRemoto.Location = new Point(21, 40);
            radiobtnRemoto.Name = "radiobtnRemoto";
            radiobtnRemoto.Size = new Size(70, 19);
            radiobtnRemoto.TabIndex = 2;
            radiobtnRemoto.TabStop = true;
            radiobtnRemoto.Text = "Remoto:";
            radiobtnRemoto.UseVisualStyleBackColor = true;
            // 
            // radiobtnPresencial
            // 
            radiobtnPresencial.AutoSize = true;
            radiobtnPresencial.Location = new Point(21, 77);
            radiobtnPresencial.Name = "radiobtnPresencial";
            radiobtnPresencial.Size = new Size(81, 19);
            radiobtnPresencial.TabIndex = 3;
            radiobtnPresencial.TabStop = true;
            radiobtnPresencial.Text = "Presencial:";
            radiobtnPresencial.UseVisualStyleBackColor = true;
            // 
            // txtbxRemoto
            // 
            txtbxRemoto.Location = new Point(106, 36);
            txtbxRemoto.Name = "txtbxRemoto";
            txtbxRemoto.Size = new Size(159, 23);
            txtbxRemoto.TabIndex = 4;
            // 
            // txtbxPesencial
            // 
            txtbxPesencial.Location = new Point(106, 73);
            txtbxPesencial.Name = "txtbxPesencial";
            txtbxPesencial.Size = new Size(159, 23);
            txtbxPesencial.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(248, 405);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(84, 33);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(338, 405);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 33);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 456);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(gpbxLocal);
            Controls.Add(cmbbxContatoCompromisso);
            Controls.Add(lblContatoCompromisso);
            Controls.Add(chckbxContatoCompromisso);
            Controls.Add(dtpTermino);
            Controls.Add(dtpInicio);
            Controls.Add(dtpData);
            Controls.Add(txtboxAssunto);
            Controls.Add(txtboxId);
            Controls.Add(lblTermino);
            Controls.Add(lblInicio);
            Controls.Add(lblData);
            Controls.Add(lblAssunto);
            Controls.Add(lblId);
            Name = "TelaCompromissoForm";
            Text = "TelaCompromissoForm";
            gpbxLocal.ResumeLayout(false);
            gpbxLocal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblAssunto;
        private Label lblData;
        private Label lblInicio;
        private Label lblTermino;
        private TextBox txtboxId;
        private TextBox txtboxAssunto;
        private DateTimePicker dtpData;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpTermino;
        private CheckBox chckbxContatoCompromisso;
        private Label lblContatoCompromisso;
        private ComboBox cmbbxContatoCompromisso;
        private GroupBox gpbxLocal;
        private RadioButton radiobtnPresencial;
        private RadioButton radiobtnRemoto;
        private TextBox txtbxPesencial;
        private TextBox txtbxRemoto;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}