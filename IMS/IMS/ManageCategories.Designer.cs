namespace IMS
{
    partial class ManageCategories
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
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.CustomerIDTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CustomerGD = new System.Windows.Forms.DataGridView();
            this.catIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventorydbDataSet3 = new IMS.InventorydbDataSet3();
            this.categoriesTblTableAdapter = new IMS.InventorydbDataSet3TableAdapters.CategoriesTblTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(747, 100);
            this.panel4.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(713, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 33);
            this.label10.TabIndex = 3;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(225, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(288, 33);
            this.label11.TabIndex = 2;
            this.label11.Text = "Manage Categories ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(63, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(545, 39);
            this.label12.TabIndex = 1;
            this.label12.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Crimson;
            this.username.Location = new System.Drawing.Point(23, 133);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(87, 16);
            this.username.TabIndex = 6;
            this.username.Text = "CategoriesID";
            // 
            // CustomerIDTb
            // 
            this.CustomerIDTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDTb.ForeColor = System.Drawing.Color.DarkMagenta;
            this.CustomerIDTb.Location = new System.Drawing.Point(26, 161);
            this.CustomerIDTb.Name = "CustomerIDTb";
            this.CustomerIDTb.Size = new System.Drawing.Size(248, 27);
            this.CustomerIDTb.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(23, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "CategoriesName";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.textBox1.Location = new System.Drawing.Point(26, 243);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 27);
            this.textBox1.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label15.Location = new System.Drawing.Point(446, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(226, 33);
            this.label15.TabIndex = 10;
            this.label15.Text = "CATEGORIES LIST";
            // 
            // CustomerGD
            // 
            this.CustomerGD.AutoGenerateColumns = false;
            this.CustomerGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catIDDataGridViewTextBoxColumn,
            this.catNameDataGridViewTextBoxColumn});
            this.CustomerGD.DataSource = this.categoriesTblBindingSource;
            this.CustomerGD.Location = new System.Drawing.Point(441, 161);
            this.CustomerGD.Name = "CustomerGD";
            this.CustomerGD.Size = new System.Drawing.Size(243, 297);
            this.CustomerGD.TabIndex = 15;
            // 
            // catIDDataGridViewTextBoxColumn
            // 
            this.catIDDataGridViewTextBoxColumn.DataPropertyName = "CatID";
            this.catIDDataGridViewTextBoxColumn.HeaderText = "CatID";
            this.catIDDataGridViewTextBoxColumn.Name = "catIDDataGridViewTextBoxColumn";
            // 
            // catNameDataGridViewTextBoxColumn
            // 
            this.catNameDataGridViewTextBoxColumn.DataPropertyName = "CatName";
            this.catNameDataGridViewTextBoxColumn.HeaderText = "CatName";
            this.catNameDataGridViewTextBoxColumn.Name = "catNameDataGridViewTextBoxColumn";
            // 
            // categoriesTblBindingSource
            // 
            this.categoriesTblBindingSource.DataMember = "CategoriesTbl";
            this.categoriesTblBindingSource.DataSource = this.inventorydbDataSet3;
            // 
            // inventorydbDataSet3
            // 
            this.inventorydbDataSet3.DataSetName = "InventorydbDataSet3";
            this.inventorydbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTblTableAdapter
            // 
            this.categoriesTblTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(26, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(160, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 17;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(295, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 18;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 501);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CustomerGD);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerIDTb);
            this.Controls.Add(this.username);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCategories";
            this.Text = "ManageCategories";
            this.Load += new System.EventHandler(this.ManageCategories_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox CustomerIDTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView CustomerGD;
        private InventorydbDataSet3 inventorydbDataSet3;
        private System.Windows.Forms.BindingSource categoriesTblBindingSource;
        private InventorydbDataSet3TableAdapters.CategoriesTblTableAdapter categoriesTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}