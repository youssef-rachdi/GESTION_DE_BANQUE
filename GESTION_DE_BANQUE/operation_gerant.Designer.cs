
namespace GESTION_DE_BANQUE
{
    partial class operation_gerant
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
            this.btn_inscriptin = new System.Windows.Forms.Button();
            this.btn_GestionGerant = new System.Windows.Forms.Button();
            this.btn_Etats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_inscriptin
            // 
            this.btn_inscriptin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inscriptin.Location = new System.Drawing.Point(55, 187);
            this.btn_inscriptin.Name = "btn_inscriptin";
            this.btn_inscriptin.Size = new System.Drawing.Size(188, 68);
            this.btn_inscriptin.TabIndex = 0;
            this.btn_inscriptin.Text = "Inscription des Clients";
            this.btn_inscriptin.UseVisualStyleBackColor = true;
            this.btn_inscriptin.Click += new System.EventHandler(this.btn_inscriptin_Click);
            // 
            // btn_GestionGerant
            // 
            this.btn_GestionGerant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GestionGerant.Location = new System.Drawing.Point(312, 195);
            this.btn_GestionGerant.Name = "btn_GestionGerant";
            this.btn_GestionGerant.Size = new System.Drawing.Size(198, 60);
            this.btn_GestionGerant.TabIndex = 4;
            this.btn_GestionGerant.Text = "Gestion Gerant";
            this.btn_GestionGerant.UseVisualStyleBackColor = true;
            this.btn_GestionGerant.Click += new System.EventHandler(this.btn_GestionGerant_Click);
            // 
            // btn_Etats
            // 
            this.btn_Etats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Etats.Location = new System.Drawing.Point(569, 195);
            this.btn_Etats.Name = "btn_Etats";
            this.btn_Etats.Size = new System.Drawing.Size(189, 60);
            this.btn_Etats.TabIndex = 5;
            this.btn_Etats.Text = "Etats";
            this.btn_Etats.UseVisualStyleBackColor = true;
            this.btn_Etats.Click += new System.EventHandler(this.btn_Etats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Operation de Gerant";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // operation_gerant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Etats);
            this.Controls.Add(this.btn_GestionGerant);
            this.Controls.Add(this.btn_inscriptin);
            this.Name = "operation_gerant";
            this.Text = "operation_gerant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inscriptin;
        private System.Windows.Forms.Button btn_GestionGerant;
        private System.Windows.Forms.Button btn_Etats;
        private System.Windows.Forms.Label label1;
    }
}