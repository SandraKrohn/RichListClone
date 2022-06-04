
namespace TheRichList {
    partial class frmHowToPlay {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblHowToPlay = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnInfoPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHowToPlay
            // 
            this.lblHowToPlay.AutoSize = true;
            this.lblHowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowToPlay.Location = new System.Drawing.Point(62, 145);
            this.lblHowToPlay.Name = "lblHowToPlay";
            this.lblHowToPlay.Size = new System.Drawing.Size(697, 100);
            this.lblHowToPlay.TabIndex = 0;
            this.lblHowToPlay.Text = "The program will randomly choose a category for you that has a fixed number of\r\np" +
    "ossible replies (for example the US states).\r\n\r\nTry to find all answers before t" +
    "he time runs out (:";
            this.lblHowToPlay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(143, 326);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 33);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnInfoPlay
            // 
            this.btnInfoPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoPlay.Location = new System.Drawing.Point(576, 326);
            this.btnInfoPlay.Name = "btnInfoPlay";
            this.btnInfoPlay.Size = new System.Drawing.Size(75, 33);
            this.btnInfoPlay.TabIndex = 1;
            this.btnInfoPlay.Text = "Play";
            this.btnInfoPlay.UseVisualStyleBackColor = true;
            // 
            // frmHowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInfoPlay);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHowToPlay);
            this.Name = "frmHowToPlay";
            this.Text = "How to play";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHowToPlay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnInfoPlay;
    }
}