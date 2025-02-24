namespace AS2425._3G.Prof.Voti
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
            txtVoto = new TextBox();
            label2 = new Label();
            txtPeso = new TextBox();
            label3 = new Label();
            txtMateria = new TextBox();
            groupBox1 = new GroupBox();
            btnAggiungiVoto = new Button();
            lstDettagli = new ListBox();
            cmbVisualizzazioni = new ComboBox();
            btnVisualizza = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 26);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "Voto";
            // 
            // txtVoto
            // 
            txtVoto.Location = new Point(65, 26);
            txtVoto.Name = "txtVoto";
            txtVoto.Size = new Size(99, 27);
            txtVoto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 26);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 0;
            label2.Text = "Peso";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(245, 26);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(63, 27);
            txtPeso.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 26);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 0;
            label3.Text = "Materia";
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(407, 26);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(215, 27);
            txtMateria.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAggiungiVoto);
            groupBox1.Controls.Add(txtMateria);
            groupBox1.Controls.Add(txtPeso);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtVoto);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(29, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 139);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dati voto";
            // 
            // btnAggiungiVoto
            // 
            btnAggiungiVoto.Location = new Point(249, 88);
            btnAggiungiVoto.Name = "btnAggiungiVoto";
            btnAggiungiVoto.Size = new Size(143, 29);
            btnAggiungiVoto.TabIndex = 2;
            btnAggiungiVoto.Text = "Aggiungi voto";
            btnAggiungiVoto.UseVisualStyleBackColor = true;
            // 
            // lstDettagli
            // 
            lstDettagli.FormattingEnabled = true;
            lstDettagli.Location = new Point(115, 222);
            lstDettagli.Name = "lstDettagli";
            lstDettagli.Size = new Size(483, 224);
            lstDettagli.TabIndex = 3;
            // 
            // cmbVisualizzazioni
            // 
            cmbVisualizzazioni.FormattingEnabled = true;
            cmbVisualizzazioni.Location = new Point(78, 180);
            cmbVisualizzazioni.Name = "cmbVisualizzazioni";
            cmbVisualizzazioni.Size = new Size(443, 28);
            cmbVisualizzazioni.TabIndex = 4;
            // 
            // btnVisualizza
            // 
            btnVisualizza.Location = new Point(537, 179);
            btnVisualizza.Name = "btnVisualizza";
            btnVisualizza.Size = new Size(94, 29);
            btnVisualizza.TabIndex = 5;
            btnVisualizza.Text = "Visualizza";
            btnVisualizza.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 479);
            Controls.Add(btnVisualizza);
            Controls.Add(cmbVisualizzazioni);
            Controls.Add(lstDettagli);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Prof;Lab2.12;24/02/25; Pesi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtVoto;
        private Label label2;
        private TextBox txtPeso;
        private Label label3;
        private TextBox txtMateria;
        private GroupBox groupBox1;
        private Button btnAggiungiVoto;
        private ListBox lstDettagli;
        private ComboBox cmbVisualizzazioni;
        private Button btnVisualizza;
    }
}
