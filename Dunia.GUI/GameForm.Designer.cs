namespace Dunia.GUI
{
    partial class GameForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameView1 = new Dunia.Core.GameView();
            this.SuspendLayout();
            // 
            // gameView1
            // 
            this.gameView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameView1.Location = new System.Drawing.Point(0, 0);
            this.gameView1.Name = "gameView1";
            this.gameView1.Size = new System.Drawing.Size(644, 613);
            this.gameView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 613);
            this.Controls.Add(this.gameView1);
            this.Name = "MainForm";
            this.Text = "Dunia";
            this.ResumeLayout(false);

        }

        #endregion

        private Core.GameView gameView1;
    }
}

