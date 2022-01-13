namespace XMLWriter
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBxDatiTrasmissione = new System.Windows.Forms.GroupBox();
            this.grpBxCedentePrestatore = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pg1txtIdPaese = new System.Windows.Forms.TextBox();
            this.pg1txtIdCodice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pg1txtProgressivoInvio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pg1txtFormatoTrasmissione = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pg1txtCodiceDestinatario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpBxDatiTrasmissione.SuspendLayout();
            this.grpBxCedentePrestatore.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(694, 409);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Avanti";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(594, 409);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Indietro";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Header";
            // 
            // grpBxDatiTrasmissione
            // 
            this.grpBxDatiTrasmissione.Controls.Add(this.pg1txtCodiceDestinatario);
            this.grpBxDatiTrasmissione.Controls.Add(this.label7);
            this.grpBxDatiTrasmissione.Controls.Add(this.pg1txtFormatoTrasmissione);
            this.grpBxDatiTrasmissione.Controls.Add(this.label5);
            this.grpBxDatiTrasmissione.Controls.Add(this.pg1txtProgressivoInvio);
            this.grpBxDatiTrasmissione.Controls.Add(this.label4);
            this.grpBxDatiTrasmissione.Controls.Add(this.pg1txtIdCodice);
            this.grpBxDatiTrasmissione.Controls.Add(this.label3);
            this.grpBxDatiTrasmissione.Controls.Add(this.pg1txtIdPaese);
            this.grpBxDatiTrasmissione.Controls.Add(this.label2);
            this.grpBxDatiTrasmissione.Location = new System.Drawing.Point(12, 32);
            this.grpBxDatiTrasmissione.Name = "grpBxDatiTrasmissione";
            this.grpBxDatiTrasmissione.Size = new System.Drawing.Size(776, 371);
            this.grpBxDatiTrasmissione.TabIndex = 3;
            this.grpBxDatiTrasmissione.TabStop = false;
            this.grpBxDatiTrasmissione.Text = "S";
            // 
            // grpBxCedentePrestatore
            // 
            this.grpBxCedentePrestatore.Controls.Add(this.textBox5);
            this.grpBxCedentePrestatore.Controls.Add(this.label6);
            this.grpBxCedentePrestatore.Controls.Add(this.button4);
            this.grpBxCedentePrestatore.Location = new System.Drawing.Point(12, 444);
            this.grpBxCedentePrestatore.Name = "grpBxCedentePrestatore";
            this.grpBxCedentePrestatore.Size = new System.Drawing.Size(776, 371);
            this.grpBxCedentePrestatore.TabIndex = 4;
            this.grpBxCedentePrestatore.TabStop = false;
            this.grpBxCedentePrestatore.Text = "Cedente Prestatore";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(275, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 0;
            this.button4.Text = "test";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "IdPaese:";
            // 
            // pg1txtIdPaese
            // 
            this.pg1txtIdPaese.Location = new System.Drawing.Point(244, 36);
            this.pg1txtIdPaese.Name = "pg1txtIdPaese";
            this.pg1txtIdPaese.Size = new System.Drawing.Size(125, 27);
            this.pg1txtIdPaese.TabIndex = 1;
            // 
            // pg1txtIdCodice
            // 
            this.pg1txtIdCodice.Location = new System.Drawing.Point(244, 69);
            this.pg1txtIdCodice.Name = "pg1txtIdCodice";
            this.pg1txtIdCodice.Size = new System.Drawing.Size(125, 27);
            this.pg1txtIdCodice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "IdCodice:";
            // 
            // pg1txtProgressivoInvio
            // 
            this.pg1txtProgressivoInvio.Location = new System.Drawing.Point(244, 102);
            this.pg1txtProgressivoInvio.Name = "pg1txtProgressivoInvio";
            this.pg1txtProgressivoInvio.Size = new System.Drawing.Size(125, 27);
            this.pg1txtProgressivoInvio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Progressivo Invio:";
            // 
            // pg1txtFormatoTrasmissione
            // 
            this.pg1txtFormatoTrasmissione.Location = new System.Drawing.Point(244, 135);
            this.pg1txtFormatoTrasmissione.Name = "pg1txtFormatoTrasmissione";
            this.pg1txtFormatoTrasmissione.Size = new System.Drawing.Size(125, 27);
            this.pg1txtFormatoTrasmissione.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Formato Trasmissione: ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(364, 172);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 27);
            this.textBox5.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "IdCodice:";
            // 
            // pg1txtCodiceDestinatario
            // 
            this.pg1txtCodiceDestinatario.Location = new System.Drawing.Point(244, 168);
            this.pg1txtCodiceDestinatario.Name = "pg1txtCodiceDestinatario";
            this.pg1txtCodiceDestinatario.Size = new System.Drawing.Size(125, 27);
            this.pg1txtCodiceDestinatario.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Codice Destinatario:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 698);
            this.Controls.Add(this.grpBxCedentePrestatore);
            this.Controls.Add(this.grpBxDatiTrasmissione);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBxDatiTrasmissione.ResumeLayout(false);
            this.grpBxDatiTrasmissione.PerformLayout();
            this.grpBxCedentePrestatore.ResumeLayout(false);
            this.grpBxCedentePrestatore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNext;
        private Button btnBack;
        private Label label1;
        private GroupBox grpBxDatiTrasmissione;
        private GroupBox grpBxCedentePrestatore;
        private Button button4;
        private TextBox pg1txtCodiceDestinatario;
        private Label label7;
        private TextBox pg1txtFormatoTrasmissione;
        private Label label5;
        private TextBox pg1txtProgressivoInvio;
        private Label label4;
        private TextBox pg1txtIdCodice;
        private Label label3;
        private TextBox pg1txtIdPaese;
        private Label label2;
        private TextBox textBox5;
        private Label label6;
    }
}