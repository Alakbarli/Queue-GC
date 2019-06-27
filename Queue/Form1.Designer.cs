namespace Queue
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Novbeler = new System.Windows.Forms.ListBox();
            this.elave = new System.Windows.Forms.Button();
            this.cixar = new System.Windows.Forms.Button();
            this.Novbe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Daxiledilecek = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novbe Cedveli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Novbede olanlar";
            // 
            // Novbeler
            // 
            this.Novbeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Novbeler.FormattingEnabled = true;
            this.Novbeler.ItemHeight = 15;
            this.Novbeler.Location = new System.Drawing.Point(363, 69);
            this.Novbeler.Name = "Novbeler";
            this.Novbeler.Size = new System.Drawing.Size(192, 304);
            this.Novbeler.TabIndex = 2;
            // 
            // elave
            // 
            this.elave.BackColor = System.Drawing.Color.LawnGreen;
            this.elave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elave.Location = new System.Drawing.Point(26, 150);
            this.elave.Name = "elave";
            this.elave.Size = new System.Drawing.Size(138, 33);
            this.elave.TabIndex = 3;
            this.elave.Text = "Novbeye elave et";
            this.elave.UseVisualStyleBackColor = false;
            this.elave.Click += new System.EventHandler(this.Elave_Click);
            // 
            // cixar
            // 
            this.cixar.BackColor = System.Drawing.Color.Red;
            this.cixar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cixar.Location = new System.Drawing.Point(194, 150);
            this.cixar.Name = "cixar";
            this.cixar.Size = new System.Drawing.Size(133, 33);
            this.cixar.TabIndex = 4;
            this.cixar.Text = "Novbeden cixar";
            this.cixar.UseVisualStyleBackColor = false;
            this.cixar.Click += new System.EventHandler(this.Cixar_Click);
            // 
            // Novbe
            // 
            this.Novbe.Location = new System.Drawing.Point(194, 112);
            this.Novbe.Name = "Novbe";
            this.Novbe.Size = new System.Drawing.Size(133, 20);
            this.Novbe.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hal hazirda novbede:";
            // 
            // Daxiledilecek
            // 
            this.Daxiledilecek.Location = new System.Drawing.Point(26, 112);
            this.Daxiledilecek.Name = "Daxiledilecek";
            this.Daxiledilecek.Size = new System.Drawing.Size(138, 20);
            this.Daxiledilecek.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Elave et";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 393);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Daxiledilecek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Novbe);
            this.Controls.Add(this.cixar);
            this.Controls.Add(this.elave);
            this.Controls.Add(this.Novbeler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Novbeler;
        private System.Windows.Forms.Button elave;
        private System.Windows.Forms.Button cixar;
        private System.Windows.Forms.TextBox Novbe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Daxiledilecek;
        private System.Windows.Forms.Label label6;
    }
}

