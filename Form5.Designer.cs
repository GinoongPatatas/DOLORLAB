namespace Laboratory01
{
    partial class FrmStudentRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.lsShow = new System.Windows.Forms.ListView();
            this.btnReg = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Records";
            // 
            // lsShow
            // 
            this.lsShow.HideSelection = false;
            this.lsShow.Location = new System.Drawing.Point(53, 77);
            this.lsShow.Name = "lsShow";
            this.lsShow.Size = new System.Drawing.Size(541, 286);
            this.lsShow.TabIndex = 1;
            this.lsShow.UseCompatibleStateImageBehavior = false;
            this.lsShow.View = System.Windows.Forms.View.List;
            this.lsShow.SelectedIndexChanged += new System.EventHandler(this.lsShow_SelectedIndexChanged);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(600, 88);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(91, 48);
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(600, 163);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(91, 54);
            this.Find.TabIndex = 3;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(600, 248);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(91, 49);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // FrmStudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.lsShow);
            this.Controls.Add(this.label1);
            this.Name = "FrmStudentRegistration";
            this.Text = "FrmStudentRegistration";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsShow;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}