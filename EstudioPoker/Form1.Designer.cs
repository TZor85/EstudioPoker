namespace EstudioPoker
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
            this.primeraCarta = new System.Windows.Forms.PictureBox();
            this.segundaCarta = new System.Windows.Forms.PictureBox();
            this.btnAction1 = new System.Windows.Forms.RadioButton();
            this.btnAction2 = new System.Windows.Forms.RadioButton();
            this.btnAction3 = new System.Windows.Forms.RadioButton();
            this.btnAction4 = new System.Windows.Forms.RadioButton();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnEmpezar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.primeraCarta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segundaCarta)).BeginInit();
            this.SuspendLayout();
            // 
            // primeraCarta
            // 
            this.primeraCarta.Location = new System.Drawing.Point(25, 414);
            this.primeraCarta.Name = "primeraCarta";
            this.primeraCarta.Size = new System.Drawing.Size(50, 70);
            this.primeraCarta.TabIndex = 0;
            this.primeraCarta.TabStop = false;
            // 
            // segundaCarta
            // 
            this.segundaCarta.Location = new System.Drawing.Point(81, 414);
            this.segundaCarta.Name = "segundaCarta";
            this.segundaCarta.Size = new System.Drawing.Size(50, 70);
            this.segundaCarta.TabIndex = 1;
            this.segundaCarta.TabStop = false;
            // 
            // btnAction1
            // 
            this.btnAction1.AutoSize = true;
            this.btnAction1.Location = new System.Drawing.Point(153, 409);
            this.btnAction1.Name = "btnAction1";
            this.btnAction1.Size = new System.Drawing.Size(52, 19);
            this.btnAction1.TabIndex = 6;
            this.btnAction1.TabStop = true;
            this.btnAction1.Text = "LIMP";
            this.btnAction1.UseVisualStyleBackColor = true;
            // 
            // btnAction2
            // 
            this.btnAction2.AutoSize = true;
            this.btnAction2.Location = new System.Drawing.Point(153, 429);
            this.btnAction2.Name = "btnAction2";
            this.btnAction2.Size = new System.Drawing.Size(78, 19);
            this.btnAction2.TabIndex = 7;
            this.btnAction2.TabStop = true;
            this.btnAction2.Text = "MINRAISE";
            this.btnAction2.UseVisualStyleBackColor = true;
            // 
            // btnAction3
            // 
            this.btnAction3.AutoSize = true;
            this.btnAction3.Location = new System.Drawing.Point(153, 449);
            this.btnAction3.Name = "btnAction3";
            this.btnAction3.Size = new System.Drawing.Size(93, 19);
            this.btnAction3.TabIndex = 8;
            this.btnAction3.TabStop = true;
            this.btnAction3.Text = "OPENSHOVE";
            this.btnAction3.UseVisualStyleBackColor = true;
            // 
            // btnAction4
            // 
            this.btnAction4.AutoSize = true;
            this.btnAction4.Location = new System.Drawing.Point(153, 469);
            this.btnAction4.Name = "btnAction4";
            this.btnAction4.Size = new System.Drawing.Size(54, 19);
            this.btnAction4.TabIndex = 9;
            this.btnAction4.TabStop = true;
            this.btnAction4.Text = "FOLD";
            this.btnAction4.UseVisualStyleBackColor = true;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(40, 515);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 10;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(458, 515);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(75, 23);
            this.btnEmpezar.TabIndex = 11;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 550);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnAction4);
            this.Controls.Add(this.btnAction3);
            this.Controls.Add(this.btnAction2);
            this.Controls.Add(this.btnAction1);
            this.Controls.Add(this.segundaCarta);
            this.Controls.Add(this.primeraCarta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.primeraCarta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segundaCarta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox primeraCarta;
        private PictureBox segundaCarta;
        private RadioButton btnAction1;
        private RadioButton btnAction2;
        private RadioButton btnAction3;
        private RadioButton btnAction4;
        private Button btnVerificar;
        private Button btnEmpezar;
    }
}