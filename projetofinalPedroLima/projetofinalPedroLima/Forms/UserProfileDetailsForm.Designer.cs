namespace projetofinalPedroLima.Forms
{
    partial class UserProfileDetailsForm
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
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.pbxSave = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.cbxActive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxDelete
            // 
            this.pbxDelete.BackgroundImage = global::projetofinalPedroLima.Properties.Resources.delete;
            this.pbxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDelete.Location = new System.Drawing.Point(279, 221);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(77, 50);
            this.pbxDelete.TabIndex = 13;
            this.pbxDelete.TabStop = false;
            // 
            // pbxSave
            // 
            this.pbxSave.BackgroundImage = global::projetofinalPedroLima.Properties.Resources.save;
            this.pbxSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSave.Location = new System.Drawing.Point(196, 221);
            this.pbxSave.Name = "pbxSave";
            this.pbxSave.Size = new System.Drawing.Size(77, 50);
            this.pbxSave.TabIndex = 12;
            this.pbxSave.TabStop = false;
            this.pbxSave.Click += new System.EventHandler(this.pbxSave_Click);
            // 
            // pbxBack
            // 
            this.pbxBack.BackgroundImage = global::projetofinalPedroLima.Properties.Resources.back;
            this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBack.Location = new System.Drawing.Point(48, 221);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(77, 50);
            this.pbxBack.TabIndex = 11;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(157, 71);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 9;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.Location = new System.Drawing.Point(73, 129);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(52, 20);
            this.lblActive.TabIndex = 8;
            this.lblActive.Text = "Ativo :";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(73, 71);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(59, 20);
            this.lblname.TabIndex = 7;
            this.lblname.Text = "Nome :";
            // 
            // cbxActive
            // 
            this.cbxActive.AutoSize = true;
            this.cbxActive.Location = new System.Drawing.Point(157, 131);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(15, 14);
            this.cbxActive.TabIndex = 14;
            this.cbxActive.UseVisualStyleBackColor = true;
            // 
            // UserProfileDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 342);
            this.Controls.Add(this.cbxActive);
            this.Controls.Add(this.pbxDelete);
            this.Controls.Add(this.pbxSave);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblname);
            this.Name = "UserProfileDetailsForm";
            this.Text = "Perfil de usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.PictureBox pbxSave;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.CheckBox cbxActive;
    }
}