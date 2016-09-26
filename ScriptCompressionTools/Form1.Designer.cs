namespace ScriptCompressionTools
{
    partial class Form1
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
            this.txtOld = new System.Windows.Forms.TextBox();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOld
            // 
            this.txtOld.Font = new System.Drawing.Font("Arial", 12F);
            this.txtOld.Location = new System.Drawing.Point(46, 41);
            this.txtOld.Name = "txtOld";
            this.txtOld.Size = new System.Drawing.Size(432, 26);
            this.txtOld.TabIndex = 0;
            this.txtOld.TextChanged += new System.EventHandler(this.txtOld_TextChanged);
            this.txtOld.DoubleClick += new System.EventHandler(this.txtOld_DoubleClick);
            // 
            // txtNew
            // 
            this.txtNew.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNew.Location = new System.Drawing.Point(46, 85);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(432, 26);
            this.txtNew.TabIndex = 1;
            this.txtNew.DoubleClick += new System.EventHandler(this.txtNew_DoubleClick);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Arial", 15F);
            this.btnStart.Location = new System.Drawing.Point(46, 145);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(432, 41);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开       始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 227);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.txtOld);
            this.Font = new System.Drawing.Font("Arial", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "脚本压缩工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOld;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Button btnStart;
    }
}

