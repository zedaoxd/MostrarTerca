namespace MostrarTerca
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.BarTitle = new System.Windows.Forms.Panel();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.PictureBox();
            this.ButtonMinimize = new System.Windows.Forms.PictureBox();
            this.BarTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // BarTitle
            // 
            this.BarTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarTitle.Controls.Add(this.ButtonMinimize);
            this.BarTitle.Controls.Add(this.buttonClose);
            this.BarTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarTitle.Location = new System.Drawing.Point(0, 0);
            this.BarTitle.Name = "BarTitle";
            this.BarTitle.Size = new System.Drawing.Size(1284, 35);
            this.BarTitle.TabIndex = 0;
            this.BarTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarTitle_MouseDown);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 35);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 576);
            this.MenuVertical.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(220, 35);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1064, 576);
            this.panelContent.TabIndex = 2;
            // 
            // buttonClose
            // 
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(1256, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(25, 25);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.TabStop = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMinimize.Image")));
            this.ButtonMinimize.Location = new System.Drawing.Point(1225, 4);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(25, 25);
            this.ButtonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonMinimize.TabIndex = 1;
            this.ButtonMinimize.TabStop = false;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.BarTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarTitle;
        private System.Windows.Forms.PictureBox buttonClose;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.PictureBox ButtonMinimize;
    }
}

