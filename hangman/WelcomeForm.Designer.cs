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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.highscoresBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.Location = new System.Drawing.Point(237, 168);
            this.welcomeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(753, 63);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "¡Bienvenido al Ahorcado Web!";
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.playBtn.Enabled = false;
            this.playBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.playBtn.Location = new System.Drawing.Point(491, 351);
            this.playBtn.Margin = new System.Windows.Forms.Padding(2);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(171, 54);
            this.playBtn.TabIndex = 1;
            this.playBtn.Text = "Jugar";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(445, 306);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(265, 32);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese su nombre:";
            // 
            // highscoresBtn
            // 
            this.highscoresBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.highscoresBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.highscoresBtn.Location = new System.Drawing.Point(929, 508);
            this.highscoresBtn.Margin = new System.Windows.Forms.Padding(2);
            this.highscoresBtn.Name = "highscoresBtn";
            this.highscoresBtn.Size = new System.Drawing.Size(214, 54);
            this.highscoresBtn.TabIndex = 4;
            this.highscoresBtn.Text = "Highscores";
            this.highscoresBtn.UseVisualStyleBackColor = false;
            this.highscoresBtn.Click += new System.EventHandler(this.highscores_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.exitBtn.Location = new System.Drawing.Point(11, 508);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(156, 54);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Salir";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 573);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.highscoresBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.welcomeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1170, 612);
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego Ahorcado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button highscoresBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

