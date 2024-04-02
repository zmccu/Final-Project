
namespace Final_Project
{
    partial class frmUpdates
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
            this.webJS = new System.Windows.Forms.WebBrowser();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webJS
            // 
            this.webJS.Location = new System.Drawing.Point(12, 12);
            this.webJS.MinimumSize = new System.Drawing.Size(20, 20);
            this.webJS.Name = "webJS";
            this.webJS.Size = new System.Drawing.Size(382, 426);
            this.webJS.TabIndex = 1;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(400, 204);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(150, 36);
            this.btnGetInfo.TabIndex = 2;
            this.btnGetInfo.Text = "Get Information";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // frmUpdates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.webJS);
            this.Name = "frmUpdates";
            this.Text = "Metacritic Reviews | Update Reviews";
            this.Load += new System.EventHandler(this.frmUpdates_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser webJS;
        private System.Windows.Forms.Button btnGetInfo;
    }
}