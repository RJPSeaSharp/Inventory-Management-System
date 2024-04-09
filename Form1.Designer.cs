namespace IMSv4
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
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitProce = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtStockNumber = new System.Windows.Forms.TextBox();
            this.lblStockNumber = new System.Windows.Forms.Label();
            this.btnSubmitNew = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnRefreshRecord = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnSelectToUpdate = new System.Windows.Forms.Button();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtdept = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(76, 597);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(123, 25);
            this.lblDepartment.TabIndex = 33;
            this.lblDepartment.Text = "Department";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(32, 545);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(215, 23);
            this.txtUnitPrice.TabIndex = 32;
            // 
            // lblUnitProce
            // 
            this.lblUnitProce.AutoSize = true;
            this.lblUnitProce.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitProce.Location = new System.Drawing.Point(76, 517);
            this.lblUnitProce.Name = "lblUnitProce";
            this.lblUnitProce.Size = new System.Drawing.Size(105, 25);
            this.lblUnitProce.TabIndex = 31;
            this.lblUnitProce.Text = "Unit Price";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(32, 468);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(215, 23);
            this.txtDescription.TabIndex = 30;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(76, 440);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(120, 25);
            this.lblDescription.TabIndex = 29;
            this.lblDescription.Text = "Description";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(32, 393);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(215, 23);
            this.txtQuantity.TabIndex = 28;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(88, 365);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(93, 25);
            this.lblQuantity.TabIndex = 27;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(32, 301);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 23);
            this.txtName.TabIndex = 26;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(97, 273);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 25);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Name";
            // 
            // txtStockNumber
            // 
            this.txtStockNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockNumber.Location = new System.Drawing.Point(29, 233);
            this.txtStockNumber.Name = "txtStockNumber";
            this.txtStockNumber.Size = new System.Drawing.Size(215, 23);
            this.txtStockNumber.TabIndex = 24;
            // 
            // lblStockNumber
            // 
            this.lblStockNumber.AutoSize = true;
            this.lblStockNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockNumber.Location = new System.Drawing.Point(61, 205);
            this.lblStockNumber.Name = "lblStockNumber";
            this.lblStockNumber.Size = new System.Drawing.Size(148, 25);
            this.lblStockNumber.TabIndex = 23;
            this.lblStockNumber.Text = "Stock Number";
            // 
            // btnSubmitNew
            // 
            this.btnSubmitNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitNew.Location = new System.Drawing.Point(454, 634);
            this.btnSubmitNew.Name = "btnSubmitNew";
            this.btnSubmitNew.Size = new System.Drawing.Size(121, 25);
            this.btnSubmitNew.TabIndex = 40;
            this.btnSubmitNew.Text = "Submit New Item";
            this.btnSubmitNew.UseVisualStyleBackColor = true;
            this.btnSubmitNew.Click += new System.EventHandler(this.btnSubmitNew_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Location = new System.Drawing.Point(1003, 634);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(121, 25);
            this.btnDeleteItem.TabIndex = 39;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            // 
            // btnRefreshRecord
            // 
            this.btnRefreshRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshRecord.Location = new System.Drawing.Point(867, 634);
            this.btnRefreshRecord.Name = "btnRefreshRecord";
            this.btnRefreshRecord.Size = new System.Drawing.Size(121, 25);
            this.btnRefreshRecord.TabIndex = 38;
            this.btnRefreshRecord.Text = "Refresh Records";
            this.btnRefreshRecord.UseVisualStyleBackColor = true;
            this.btnRefreshRecord.Click += new System.EventHandler(this.btnRefreshRecord_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItem.Location = new System.Drawing.Point(730, 634);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(121, 25);
            this.btnUpdateItem.TabIndex = 37;
            this.btnUpdateItem.Text = "Update Item";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // btnSelectToUpdate
            // 
            this.btnSelectToUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectToUpdate.Location = new System.Drawing.Point(594, 634);
            this.btnSelectToUpdate.Name = "btnSelectToUpdate";
            this.btnSelectToUpdate.Size = new System.Drawing.Size(121, 25);
            this.btnSelectToUpdate.TabIndex = 36;
            this.btnSelectToUpdate.Text = "Select To Update";
            this.btnSelectToUpdate.UseVisualStyleBackColor = true;
            this.btnSelectToUpdate.Click += new System.EventHandler(this.btnSelectToUpdate_Click);
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewItem.Location = new System.Drawing.Point(313, 634);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(121, 25);
            this.btnAddNewItem.TabIndex = 35;
            this.btnAddNewItem.Text = "Add New Item";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(295, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(828, 408);
            this.dataGridView1.TabIndex = 41;
            // 
            // txtdept
            // 
            this.txtdept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdept.Location = new System.Drawing.Point(32, 636);
            this.txtdept.Name = "txtdept";
            this.txtdept.Size = new System.Drawing.Size(215, 23);
            this.txtdept.TabIndex = 42;
            this.txtdept.TextChanged += new System.EventHandler(this.txtdept_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 696);
            this.Controls.Add(this.txtdept);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSubmitNew);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnRefreshRecord);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.btnSelectToUpdate);
            this.Controls.Add(this.btnAddNewItem);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.lblUnitProce);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtStockNumber);
            this.Controls.Add(this.lblStockNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitProce;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtStockNumber;
        private System.Windows.Forms.Label lblStockNumber;
        private System.Windows.Forms.Button btnSubmitNew;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnRefreshRecord;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnSelectToUpdate;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtdept;
    }
}

