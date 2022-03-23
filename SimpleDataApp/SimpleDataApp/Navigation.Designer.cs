
namespace SimpleDataApp
{
    partial class Navigation
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
            this.btnGoToAdd = new System.Windows.Forms.Button();
            this.btnGoToFillOrCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoToAdd
            // 
            this.btnGoToAdd.Location = new System.Drawing.Point(165, 46);
            this.btnGoToAdd.Name = "btnGoToAdd";
            this.btnGoToAdd.Size = new System.Drawing.Size(189, 74);
            this.btnGoToAdd.TabIndex = 0;
            this.btnGoToAdd.Text = "Add an account";
            this.btnGoToAdd.UseVisualStyleBackColor = true;
            this.btnGoToAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGoToFillOrCancel
            // 
            this.btnGoToFillOrCancel.Location = new System.Drawing.Point(165, 126);
            this.btnGoToFillOrCancel.Name = "btnGoToFillOrCancel";
            this.btnGoToFillOrCancel.Size = new System.Drawing.Size(189, 75);
            this.btnGoToFillOrCancel.TabIndex = 1;
            this.btnGoToFillOrCancel.Text = "Fill or Cancel Order";
            this.btnGoToFillOrCancel.UseVisualStyleBackColor = true;
            this.btnGoToFillOrCancel.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(381, 231);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 46);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 312);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoToFillOrCancel);
            this.Controls.Add(this.btnGoToAdd);
            this.Name = "Navigation";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Navigation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoToAdd;
        private System.Windows.Forms.Button btnGoToFillOrCancel;
        private System.Windows.Forms.Button btnExit;
    }
}

