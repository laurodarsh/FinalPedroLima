﻿namespace projetofinalPedroLima.Forms
{
    partial class CategoryAllForm
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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.pbxEdit = new System.Windows.Forms.PictureBox();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(12, 87);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(381, 169);
            this.dgvProduct.TabIndex = 19;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(146, 27);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 17;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(53, 27);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(87, 20);
            this.lblSearch.TabIndex = 16;
            this.lblSearch.Text = "Pesquisar :";
            // 
            // pbxDelete
            // 
            this.pbxDelete.BackgroundImage = global::projetofinalPedroLima.Properties.Resources.delete;
            this.pbxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxDelete.Location = new System.Drawing.Point(339, 272);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(54, 50);
            this.pbxDelete.TabIndex = 23;
            this.pbxDelete.TabStop = false;
            // 
            // pbxEdit
            // 
            this.pbxEdit.BackgroundImage = global::projetofinalPedroLima.Properties.Resources.edit;
            this.pbxEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxEdit.Location = new System.Drawing.Point(279, 271);
            this.pbxEdit.Name = "pbxEdit";
            this.pbxEdit.Size = new System.Drawing.Size(54, 50);
            this.pbxEdit.TabIndex = 22;
            this.pbxEdit.TabStop = false;
            // 
            // pbxAdd
            // 
            this.pbxAdd.BackgroundImage = global::projetofinalPedroLima.Properties.Resources.add;
            this.pbxAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxAdd.Location = new System.Drawing.Point(219, 272);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(54, 50);
            this.pbxAdd.TabIndex = 21;
            this.pbxAdd.TabStop = false;
            this.pbxAdd.Click += new System.EventHandler(this.pbxAdd_Click);
            // 
            // pbxBack
            // 
            this.pbxBack.BackgroundImage = global::projetofinalPedroLima.Properties.Resources.back;
            this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxBack.Location = new System.Drawing.Point(12, 272);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(54, 50);
            this.pbxBack.TabIndex = 20;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::projetofinalPedroLima.Properties.Resources.search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(252, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 28);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // CategoryAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 342);
            this.Controls.Add(this.pbxDelete);
            this.Controls.Add(this.pbxEdit);
            this.Controls.Add(this.pbxAdd);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Name = "CategoryAllForm";
            this.Text = "Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.PictureBox pbxEdit;
        private System.Windows.Forms.PictureBox pbxAdd;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}