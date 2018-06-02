namespace hangman
{
    partial class WelcomeForm
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
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Source Sans Pro", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.Location = new System.Drawing.Point(355, 328);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(1043, 101);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "¡Bienvenido al Ahorcado Web!";
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.playBtn.Enabled = false;
            this.playBtn.Font = new System.Drawing.Font("Source Sans Pro Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.playBtn.Location = new System.Drawing.Point(737, 610);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(256, 83);
            this.playBtn.TabIndex = 1;
            this.playBtn.Text = "Jugar";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Source Sans Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(668, 540);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(395, 48);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(678, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese su nombre:";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1731, 882);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.welcomeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.Text = "Juego Ahorcado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
    }
}

