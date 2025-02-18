namespace IMS
{
    partial class ManageUsers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.unameTb = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fnameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.UserGD = new System.Windows.Forms.DataGridView();
            this.unameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventorydbDataSet1 = new IMS.InventorydbDataSet1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inventorydbDataSet = new IMS.InventorydbDataSet();
            this.inventorydbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTblTableAdapter = new IMS.InventorydbDataSet1TableAdapters.UserTblTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 100);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(720, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 33);
            this.label6.TabIndex = 3;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(225, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manage Users";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // unameTb
            // 
            this.unameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unameTb.ForeColor = System.Drawing.Color.DarkMagenta;
            this.unameTb.Location = new System.Drawing.Point(24, 136);
            this.unameTb.Name = "unameTb";
            this.unameTb.Size = new System.Drawing.Size(248, 27);
            this.unameTb.TabIndex = 1;
            this.unameTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Crimson;
            this.username.Location = new System.Drawing.Point(21, 117);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(71, 16);
            this.username.TabIndex = 2;
            this.username.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(21, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fullname";
            // 
            // fnameTb
            // 
            this.fnameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTb.ForeColor = System.Drawing.Color.DarkMagenta;
            this.fnameTb.Location = new System.Drawing.Point(24, 200);
            this.fnameTb.Name = "fnameTb";
            this.fnameTb.Size = new System.Drawing.Size(248, 27);
            this.fnameTb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(21, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // PasswordTb
            // 
            this.PasswordTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTb.ForeColor = System.Drawing.Color.DarkMagenta;
            this.PasswordTb.Location = new System.Drawing.Point(24, 271);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(248, 27);
            this.PasswordTb.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(21, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telephone";
            // 
            // PhoneTb
            // 
            this.PhoneTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTb.ForeColor = System.Drawing.Color.DarkMagenta;
            this.PhoneTb.Location = new System.Drawing.Point(24, 345);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(248, 27);
            this.PhoneTb.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(24, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(138, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(180, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 11;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(70, 438);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 12;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // UserGD
            // 
            this.UserGD.AutoGenerateColumns = false;
            this.UserGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unameDataGridViewTextBoxColumn,
            this.ufullnameDataGridViewTextBoxColumn,
            this.upasswordDataGridViewTextBoxColumn,
            this.uphoneDataGridViewTextBoxColumn});
            this.UserGD.DataSource = this.userTblBindingSource;
            this.UserGD.Location = new System.Drawing.Point(294, 159);
            this.UserGD.Name = "UserGD";
            this.UserGD.Size = new System.Drawing.Size(442, 343);
            this.UserGD.TabIndex = 13;
            this.UserGD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserGD_CellContentClick);
            // 
            // unameDataGridViewTextBoxColumn
            // 
            this.unameDataGridViewTextBoxColumn.DataPropertyName = "Uname";
            this.unameDataGridViewTextBoxColumn.HeaderText = "Uname";
            this.unameDataGridViewTextBoxColumn.Name = "unameDataGridViewTextBoxColumn";
            // 
            // ufullnameDataGridViewTextBoxColumn
            // 
            this.ufullnameDataGridViewTextBoxColumn.DataPropertyName = "Ufullname";
            this.ufullnameDataGridViewTextBoxColumn.HeaderText = "Ufullname";
            this.ufullnameDataGridViewTextBoxColumn.Name = "ufullnameDataGridViewTextBoxColumn";
            // 
            // upasswordDataGridViewTextBoxColumn
            // 
            this.upasswordDataGridViewTextBoxColumn.DataPropertyName = "Upassword";
            this.upasswordDataGridViewTextBoxColumn.HeaderText = "Upassword";
            this.upasswordDataGridViewTextBoxColumn.Name = "upasswordDataGridViewTextBoxColumn";
            // 
            // uphoneDataGridViewTextBoxColumn
            // 
            this.uphoneDataGridViewTextBoxColumn.DataPropertyName = "Uphone";
            this.uphoneDataGridViewTextBoxColumn.HeaderText = "Uphone";
            this.uphoneDataGridViewTextBoxColumn.Name = "uphoneDataGridViewTextBoxColumn";
            // 
            // userTblBindingSource
            // 
            this.userTblBindingSource.DataMember = "UserTbl";
            this.userTblBindingSource.DataSource = this.inventorydbDataSet1;
            // 
            // inventorydbDataSet1
            // 
            this.inventorydbDataSet1.DataSetName = "InventorydbDataSet1";
            this.inventorydbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 12);
            this.panel2.TabIndex = 14;
            // 
            // inventorydbDataSet
            // 
            this.inventorydbDataSet.DataSetName = "InventorydbDataSet";
            this.inventorydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventorydbDataSetBindingSource
            // 
            this.inventorydbDataSetBindingSource.DataSource = this.inventorydbDataSet;
            this.inventorydbDataSetBindingSource.Position = 0;
            // 
            // userTblTableAdapter
            // 
            this.userTblTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(453, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 33);
            this.label7.TabIndex = 4;
            this.label7.Text = "USERS LIST";
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 540);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UserGD);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fnameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.unameTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox unameTb;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fnameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView UserGD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource inventorydbDataSetBindingSource;
        private InventorydbDataSet inventorydbDataSet;
        private InventorydbDataSet1 inventorydbDataSet1;
        private System.Windows.Forms.BindingSource userTblBindingSource;
        private InventorydbDataSet1TableAdapters.UserTblTableAdapter userTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn unameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn upasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
    }
}