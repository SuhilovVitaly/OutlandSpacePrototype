
namespace OutlandSpace.Client
{
    partial class ScreenMainMenu
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
            this.cmdStartNewGameSession = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdStartNewGameSession
            // 
            this.cmdStartNewGameSession.Location = new System.Drawing.Point(35, 30);
            this.cmdStartNewGameSession.Name = "cmdStartNewGameSession";
            this.cmdStartNewGameSession.Size = new System.Drawing.Size(162, 23);
            this.cmdStartNewGameSession.TabIndex = 0;
            this.cmdStartNewGameSession.Text = "Start new game session";
            this.cmdStartNewGameSession.UseVisualStyleBackColor = true;
            this.cmdStartNewGameSession.Click += new System.EventHandler(this.cmdStartNewGameSession_Click);
            // 
            // ScreenMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdStartNewGameSession);
            this.Name = "ScreenMainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdStartNewGameSession;
    }
}

