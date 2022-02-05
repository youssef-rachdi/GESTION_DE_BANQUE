
namespace GESTION_DE_BANQUE
{
    partial class les_Operation
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
            this.btn_versement = new System.Windows.Forms.Button();
            this.btn_retraie = new System.Windows.Forms.Button();
            this.btn_Transfere = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Etats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_versement
            // 
            this.btn_versement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_versement.Location = new System.Drawing.Point(151, 112);
            this.btn_versement.Name = "btn_versement";
            this.btn_versement.Size = new System.Drawing.Size(216, 53);
            this.btn_versement.TabIndex = 0;
            this.btn_versement.Text = "Versement";
            this.btn_versement.UseVisualStyleBackColor = true;
            this.btn_versement.Click += new System.EventHandler(this.btn_versement_Click);
            // 
            // btn_retraie
            // 
            this.btn_retraie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retraie.Location = new System.Drawing.Point(435, 112);
            this.btn_retraie.Name = "btn_retraie";
            this.btn_retraie.Size = new System.Drawing.Size(205, 53);
            this.btn_retraie.TabIndex = 1;
            this.btn_retraie.Text = "Retraie";
            this.btn_retraie.UseVisualStyleBackColor = true;
            this.btn_retraie.Click += new System.EventHandler(this.btn_retraie_Click);
            // 
            // btn_Transfere
            // 
            this.btn_Transfere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Transfere.Location = new System.Drawing.Point(151, 199);
            this.btn_Transfere.Name = "btn_Transfere";
            this.btn_Transfere.Size = new System.Drawing.Size(216, 46);
            this.btn_Transfere.TabIndex = 2;
            this.btn_Transfere.Text = "Transfere";
            this.btn_Transfere.UseVisualStyleBackColor = true;
            this.btn_Transfere.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modifier.Location = new System.Drawing.Point(435, 199);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(201, 48);
            this.btn_Modifier.TabIndex = 3;
            this.btn_Modifier.Text = "Modifier Mot de Passe";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Etats
            // 
            this.btn_Etats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Etats.Location = new System.Drawing.Point(296, 281);
            this.btn_Etats.Name = "btn_Etats";
            this.btn_Etats.Size = new System.Drawing.Size(207, 52);
            this.btn_Etats.TabIndex = 4;
            this.btn_Etats.Text = "Etats";
            this.btn_Etats.UseVisualStyleBackColor = true;
            this.btn_Etats.Click += new System.EventHandler(this.btn_Etats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Operation de Client";
            // 
            // les_Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Etats);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Transfere);
            this.Controls.Add(this.btn_retraie);
            this.Controls.Add(this.btn_versement);
            this.Name = "les_Operation";
            this.Text = "les_Operation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_versement;
        private System.Windows.Forms.Button btn_retraie;
        private System.Windows.Forms.Button btn_Transfere;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Etats;
        private System.Windows.Forms.Label label1;
    }
}