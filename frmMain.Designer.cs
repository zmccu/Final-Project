
namespace Final_Project
{
    partial class frmMain
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
            this.btnUpdateReviews = new System.Windows.Forms.Button();
            this.btnViewReviews = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdateReviews
            // 
            this.btnUpdateReviews.Location = new System.Drawing.Point(12, 12);
            this.btnUpdateReviews.Name = "btnUpdateReviews";
            this.btnUpdateReviews.Size = new System.Drawing.Size(131, 32);
            this.btnUpdateReviews.TabIndex = 0;
            this.btnUpdateReviews.Text = "Check for Updates";
            this.btnUpdateReviews.UseVisualStyleBackColor = true;
            this.btnUpdateReviews.Click += new System.EventHandler(this.btnUpdateReviews_Click);
            // 
            // btnViewReviews
            // 
            this.btnViewReviews.Location = new System.Drawing.Point(149, 12);
            this.btnViewReviews.Name = "btnViewReviews";
            this.btnViewReviews.Size = new System.Drawing.Size(131, 32);
            this.btnViewReviews.TabIndex = 0;
            this.btnViewReviews.Text = "View Reviews";
            this.btnViewReviews.UseVisualStyleBackColor = true;
            this.btnViewReviews.Click += new System.EventHandler(this.btnViewReviews_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 459);
            this.Controls.Add(this.btnViewReviews);
            this.Controls.Add(this.btnUpdateReviews);
            this.Name = "frmMain";
            this.Text = "Metacritic Reviews | Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateReviews;
        private System.Windows.Forms.Button btnViewReviews;
    }
}

