namespace projetofinalPedroLima.Forms
{
    partial class CategoryDetailsForm
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.pbxSave = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.cbxActive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(37, 44);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(59, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Nome :";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.Location = new System.Drawing.Point(37, 102);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(52, 20);
            this.lblActive.TabIndex = 1;
            this.lblActive.Text = "Ativo :";
            this.lblActive.Click += new System.EventHandler(this.lblActive_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(121, 44);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 2;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // pbxDelete
            // 
            this.pbxDelete.BackgroundImage = global::projetofinalPedroLima.Properties.Resources.delete;
            this.pbxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDelete.Location = new System.Drawing.Point(243, 194);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(77, 50);
            this.pbxDelete.TabIndex = 6;
            this.pbxDelete.TabStop = false;
            this.pbxDelete.Click += new System.EventHandler(this.pbxDelete_Click);
            // 
            // pbxSave
            // 
            this.pbxSave.BackgroundImage = global::projetofinalPedroLima.Properties.Resources.save;
            this.pbxSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSave.Location = new System.Drawing.Point(160, 194);
            this.pbxSave.Name = "pbxSave";
            this.pbxSave.Size = new System.Drawing.Size(77, 50);
            this.pbxSave.TabIndex = 5;
            this.pbxSave.TabStop = false;
            this.pbxSave.Click += new System.EventHandler(this.pbxSave_Click);
            // 
            // pbxBack
            // 
            this.pbxBack.BackgroundImage = global::projetofinalPedroLima.Properties.Resources.back;
            this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBack.Location = new System.Drawing.Point(12, 194);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(77, 50);
            this.pbxBack.TabIndex = 4;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // cbxActive
            // 
            this.cbxActive.AutoSize = true;
            this.cbxActive.Location = new System.Drawing.Point(121, 104);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(15, 14);
            this.cbxActive.TabIndex = 7;
            this.cbxActive.UseVisualStyleBackColor = true;
            // 
            // CategoryDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 279);
            this.Controls.Add(this.cbxActive);
            this.Controls.Add(this.pbxDelete);
            this.Controls.Add(this.pbxSave);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblname);
            this.Name = "CategoryDetailsForm";
            this.Text = "Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.PictureBox pbxSave;
        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.CheckBox cbxActive;
    }
}