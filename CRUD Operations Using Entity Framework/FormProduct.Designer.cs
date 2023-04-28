namespace CRUD_Operations_Using_Entity_Framework
{
    partial class FormProduct
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
            this.DgvProducts = new System.Windows.Forms.DataGridView();
            this.BtUpdate = new System.Windows.Forms.Button();
            this.BtDelete = new System.Windows.Forms.Button();
            this.BtInsert = new System.Windows.Forms.Button();
            this.BtList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxProductId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxBrand = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbxState = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbxPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbxCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProducts
            // 
            this.DgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducts.Location = new System.Drawing.Point(276, 12);
            this.DgvProducts.Name = "DgvProducts";
            this.DgvProducts.ReadOnly = true;
            this.DgvProducts.Size = new System.Drawing.Size(505, 218);
            this.DgvProducts.TabIndex = 17;
            this.DgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProducts_CellClick);
            // 
            // BtUpdate
            // 
            this.BtUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtUpdate.Location = new System.Drawing.Point(660, 236);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(119, 37);
            this.BtUpdate.TabIndex = 16;
            this.BtUpdate.Text = "Update";
            this.BtUpdate.UseVisualStyleBackColor = true;
            this.BtUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // BtDelete
            // 
            this.BtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtDelete.Location = new System.Drawing.Point(404, 236);
            this.BtDelete.Name = "BtDelete";
            this.BtDelete.Size = new System.Drawing.Size(119, 37);
            this.BtDelete.TabIndex = 15;
            this.BtDelete.Text = "Delete";
            this.BtDelete.UseVisualStyleBackColor = true;
            this.BtDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // BtInsert
            // 
            this.BtInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtInsert.Location = new System.Drawing.Point(532, 236);
            this.BtInsert.Name = "BtInsert";
            this.BtInsert.Size = new System.Drawing.Size(119, 37);
            this.BtInsert.TabIndex = 14;
            this.BtInsert.Text = "Insert";
            this.BtInsert.UseVisualStyleBackColor = true;
            this.BtInsert.Click += new System.EventHandler(this.BtInsert_Click);
            // 
            // BtList
            // 
            this.BtList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtList.Location = new System.Drawing.Point(276, 236);
            this.BtList.Name = "BtList";
            this.BtList.Size = new System.Drawing.Size(119, 37);
            this.BtList.TabIndex = 13;
            this.BtList.Text = "List";
            this.BtList.UseVisualStyleBackColor = true;
            this.BtList.Click += new System.EventHandler(this.BtList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Product  Name:";
            // 
            // TbxProductName
            // 
            this.TbxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxProductName.Location = new System.Drawing.Point(135, 50);
            this.TbxProductName.Name = "TbxProductName";
            this.TbxProductName.Size = new System.Drawing.Size(120, 26);
            this.TbxProductName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Product Id:";
            // 
            // TbxProductId
            // 
            this.TbxProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxProductId.Location = new System.Drawing.Point(135, 12);
            this.TbxProductId.Name = "TbxProductId";
            this.TbxProductId.Size = new System.Drawing.Size(120, 26);
            this.TbxProductId.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(76, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Stock:";
            // 
            // TbxStock
            // 
            this.TbxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxStock.Location = new System.Drawing.Point(135, 126);
            this.TbxStock.Name = "TbxStock";
            this.TbxStock.Size = new System.Drawing.Size(120, 26);
            this.TbxStock.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(74, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Brand:";
            // 
            // TbxBrand
            // 
            this.TbxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxBrand.Location = new System.Drawing.Point(135, 88);
            this.TbxBrand.Name = "TbxBrand";
            this.TbxBrand.Size = new System.Drawing.Size(120, 26);
            this.TbxBrand.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(78, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "State:";
            // 
            // TbxState
            // 
            this.TbxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxState.Location = new System.Drawing.Point(135, 202);
            this.TbxState.Name = "TbxState";
            this.TbxState.Size = new System.Drawing.Size(120, 26);
            this.TbxState.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(82, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Price:";
            // 
            // TbxPrice
            // 
            this.TbxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxPrice.Location = new System.Drawing.Point(135, 164);
            this.TbxPrice.Name = "TbxPrice";
            this.TbxPrice.Size = new System.Drawing.Size(120, 26);
            this.TbxPrice.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(53, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Category:";
            // 
            // CbxCategory
            // 
            this.CbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CbxCategory.FormattingEnabled = true;
            this.CbxCategory.Location = new System.Drawing.Point(135, 240);
            this.CbxCategory.Name = "CbxCategory";
            this.CbxCategory.Size = new System.Drawing.Size(120, 28);
            this.CbxCategory.TabIndex = 28;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 282);
            this.Controls.Add(this.CbxCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbxState);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbxPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbxBrand);
            this.Controls.Add(this.DgvProducts);
            this.Controls.Add(this.BtUpdate);
            this.Controls.Add(this.BtDelete);
            this.Controls.Add(this.BtInsert);
            this.Controls.Add(this.BtList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxProductId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProduct";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProducts;
        private System.Windows.Forms.Button BtUpdate;
        private System.Windows.Forms.Button BtDelete;
        private System.Windows.Forms.Button BtInsert;
        private System.Windows.Forms.Button BtList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxProductId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbxBrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbxPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbxState;
        private System.Windows.Forms.ComboBox CbxCategory;
    }
}