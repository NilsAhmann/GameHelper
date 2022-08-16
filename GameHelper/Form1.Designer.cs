
namespace GameHelper
{
    partial class formGameHelper
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tp1_lblMoveModFiles = new System.Windows.Forms.Label();
            this.tp1_btnMove = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tp1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(775, 425);
            this.tabControl.TabIndex = 0;
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.tp1_btnMove);
            this.tp1.Controls.Add(this.tp1_lblMoveModFiles);
            this.tp1.Location = new System.Drawing.Point(4, 22);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(767, 399);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Sims Allgemein";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tp1_lblMoveModFiles
            // 
            this.tp1_lblMoveModFiles.AutoSize = true;
            this.tp1_lblMoveModFiles.Location = new System.Drawing.Point(6, 12);
            this.tp1_lblMoveModFiles.Name = "tp1_lblMoveModFiles";
            this.tp1_lblMoveModFiles.Size = new System.Drawing.Size(165, 13);
            this.tp1_lblMoveModFiles.TabIndex = 0;
            this.tp1_lblMoveModFiles.Text = "Move Sims ModFiles (all versions)";
            // 
            // tp1_btnMove
            // 
            this.tp1_btnMove.Location = new System.Drawing.Point(178, 7);
            this.tp1_btnMove.Name = "tp1_btnMove";
            this.tp1_btnMove.Size = new System.Drawing.Size(75, 23);
            this.tp1_btnMove.TabIndex = 1;
            this.tp1_btnMove.Text = "Move";
            this.tp1_btnMove.UseVisualStyleBackColor = true;
            this.tp1_btnMove.Click += new System.EventHandler(this.tp1_btnMove_Click);
            // 
            // formGameHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "formGameHelper";
            this.Text = "GameHelper";
            this.tabControl.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label tp1_lblMoveModFiles;
        private System.Windows.Forms.Button tp1_btnMove;
    }
}

