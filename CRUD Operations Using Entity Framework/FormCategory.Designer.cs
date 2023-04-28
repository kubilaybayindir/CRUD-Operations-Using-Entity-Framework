namespace CRUD_Operations_Using_Entity_Framework
{
    partial class FormCategory
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
            this.TbxCategoryId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxCategoryName = new System.Windows.Forms.TextBox();
            this.BtList = new System.Windows.Forms.Button();
            this.BtInsert = new System.Windows.Forms.Button();
            this.BtDelete = new System.Windows.Forms.Button();
            this.BtUpdate = new System.Windows.Forms.Button();
            this.DgvCategories = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // TbxCategoryId
            // 
            this.TbxCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxCategoryId.Location = new System.Drawing.Point(136, 12);
            this.TbxCategoryId.Name = "TbxCategoryId";
            this.TbxCategoryId.Size = new System.Drawing.Size(120, 26);
            this.TbxCategoryId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category Name:";
            // 
            // TbxCategoryName
            // 
            this.TbxCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxCategoryName.Location = new System.Drawing.Point(136, 44);
            this.TbxCategoryName.Name = "TbxCategoryName";
            this.TbxCategoryName.Size = new System.Drawing.Size(120, 26);
            this.TbxCategoryName.TabIndex = 2;
            // 
            // BtList
            // 
            this.BtList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtList.Location = new System.Drawing.Point(12, 92);
            this.BtList.Name = "BtList";
            this.BtList.Size = new System.Drawing.Size(119, 37);
            this.BtList.TabIndex = 4;
            this.BtList.Text = "List";
            this.BtList.UseVisualStyleBackColor = true;
            this.BtList.Click += new System.EventHandler(this.BtList_Click);
            // 
            // BtInsert
            // 
            this.BtInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtInsert.Location = new System.Drawing.Point(12, 134);
            this.BtInsert.Name = "BtInsert";
            this.BtInsert.Size = new System.Drawing.Size(119, 37);
            this.BtInsert.TabIndex = 5;
            this.BtInsert.Text = "Insert";
            this.BtInsert.UseVisualStyleBackColor = true;
            this.BtInsert.Click += new System.EventHandler(this.BtInsert_Click);
            // 
            // BtDelete
            // 
            this.BtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtDelete.Location = new System.Drawing.Point(137, 92);
            this.BtDelete.Name = "BtDelete";
            this.BtDelete.Size = new System.Drawing.Size(119, 37);
            this.BtDelete.TabIndex = 6;
            this.BtDelete.Text = "Delete";
            this.BtDelete.UseVisualStyleBackColor = true;
            this.BtDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // BtUpdate
            // 
            this.BtUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtUpdate.Location = new System.Drawing.Point(137, 134);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(119, 37);
            this.BtUpdate.TabIndex = 7;
            this.BtUpdate.Text = "Update";
            this.BtUpdate.UseVisualStyleBackColor = true;
            this.BtUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // DgvCategories
            // 
            this.DgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategories.Location = new System.Drawing.Point(277, 12);
            this.DgvCategories.Name = "DgvCategories";
            this.DgvCategories.ReadOnly = true;
            this.DgvCategories.Size = new System.Drawing.Size(230, 159);
            this.DgvCategories.TabIndex = 8;
            this.DgvCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCategories_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(519, 182);
            this.Controls.Add(this.DgvCategories);
            this.Controls.Add(this.BtUpdate);
            this.Controls.Add(this.BtDelete);
            this.Controls.Add(this.BtInsert);
            this.Controls.Add(this.BtList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxCategoryName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxCategoryId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxCategoryId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxCategoryName;
        private System.Windows.Forms.Button BtList;
        private System.Windows.Forms.Button BtInsert;
        private System.Windows.Forms.Button BtDelete;
        private System.Windows.Forms.Button BtUpdate;
        private System.Windows.Forms.DataGridView DgvCategories;
    }
}

