namespace TS3ChromaHeadset
{
    partial class FrmMain
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
            this.pnlMain = new MetroFramework.Controls.MetroPanel();
            this.lblTextMessage = new MetroFramework.Controls.MetroLabel();
            this.lblPoke = new MetroFramework.Controls.MetroLabel();
            this.toggleTextMessage = new MetroFramework.Controls.MetroToggle();
            this.togglePoke = new MetroFramework.Controls.MetroToggle();
            this.btnPoke = new System.Windows.Forms.Button();
            this.btnTextMessage = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnTextMessage);
            this.pnlMain.Controls.Add(this.btnPoke);
            this.pnlMain.Controls.Add(this.lblTextMessage);
            this.pnlMain.Controls.Add(this.lblPoke);
            this.pnlMain.Controls.Add(this.toggleTextMessage);
            this.pnlMain.Controls.Add(this.togglePoke);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.HorizontalScrollbarBarColor = true;
            this.pnlMain.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMain.HorizontalScrollbarSize = 10;
            this.pnlMain.Location = new System.Drawing.Point(20, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(260, 85);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.VerticalScrollbarBarColor = true;
            this.pnlMain.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMain.VerticalScrollbarSize = 10;
            // 
            // lblTextMessage
            // 
            this.lblTextMessage.AutoSize = true;
            this.lblTextMessage.Location = new System.Drawing.Point(15, 50);
            this.lblTextMessage.Name = "lblTextMessage";
            this.lblTextMessage.Size = new System.Drawing.Size(85, 19);
            this.lblTextMessage.TabIndex = 5;
            this.lblTextMessage.Text = "TextMessage:";
            // 
            // lblPoke
            // 
            this.lblPoke.AutoSize = true;
            this.lblPoke.Location = new System.Drawing.Point(15, 15);
            this.lblPoke.Name = "lblPoke";
            this.lblPoke.Size = new System.Drawing.Size(40, 19);
            this.lblPoke.TabIndex = 4;
            this.lblPoke.Text = "Poke:";
            // 
            // toggleTextMessage
            // 
            this.toggleTextMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleTextMessage.AutoSize = true;
            this.toggleTextMessage.DisplayStatus = false;
            this.toggleTextMessage.Location = new System.Drawing.Point(166, 50);
            this.toggleTextMessage.Name = "toggleTextMessage";
            this.toggleTextMessage.Size = new System.Drawing.Size(50, 17);
            this.toggleTextMessage.TabIndex = 3;
            this.toggleTextMessage.Text = "Aus";
            this.toggleTextMessage.UseVisualStyleBackColor = true;
            this.toggleTextMessage.CheckedChanged += new System.EventHandler(this.toggleTextMessage_CheckedChanged);
            // 
            // togglePoke
            // 
            this.togglePoke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.togglePoke.AutoSize = true;
            this.togglePoke.DisplayStatus = false;
            this.togglePoke.Location = new System.Drawing.Point(166, 15);
            this.togglePoke.Name = "togglePoke";
            this.togglePoke.Size = new System.Drawing.Size(50, 17);
            this.togglePoke.TabIndex = 2;
            this.togglePoke.Text = "Aus";
            this.togglePoke.UseVisualStyleBackColor = true;
            this.togglePoke.CheckedChanged += new System.EventHandler(this.togglePoke_CheckedChanged);
            // 
            // btnPoke
            // 
            this.btnPoke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoke.Location = new System.Drawing.Point(222, 15);
            this.btnPoke.Name = "btnPoke";
            this.btnPoke.Size = new System.Drawing.Size(17, 17);
            this.btnPoke.TabIndex = 6;
            this.btnPoke.UseVisualStyleBackColor = true;
            this.btnPoke.Click += new System.EventHandler(this.btnPoke_Click);
            // 
            // btnTextMessage
            // 
            this.btnTextMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTextMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTextMessage.Location = new System.Drawing.Point(222, 50);
            this.btnTextMessage.Name = "btnTextMessage";
            this.btnTextMessage.Size = new System.Drawing.Size(17, 17);
            this.btnTextMessage.TabIndex = 7;
            this.btnTextMessage.UseVisualStyleBackColor = true;
            this.btnTextMessage.Click += new System.EventHandler(this.btnTextMessage_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 165);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 165);
            this.Name = "FrmMain";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "TS3ChromaHeadset";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMain;
        private MetroFramework.Controls.MetroLabel lblTextMessage;
        private MetroFramework.Controls.MetroLabel lblPoke;
        private MetroFramework.Controls.MetroToggle toggleTextMessage;
        private MetroFramework.Controls.MetroToggle togglePoke;
        private System.Windows.Forms.Button btnTextMessage;
        private System.Windows.Forms.Button btnPoke;
    }
}

