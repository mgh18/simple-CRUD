namespace simple_CRUD
{
    partial class Form2
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
            System.Windows.Forms.Label sidLabel;
            System.Windows.Forms.Label snameLabel;
            System.Windows.Forms.Label sfamilyLabel;
            System.Windows.Forms.Label scmeliLabel;
            System.Windows.Forms.Label smobileLabel;
            this.mainDS = new simple_CRUD.mainDS();
            this.stuListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stuListTableAdapter = new simple_CRUD.mainDSTableAdapters.stuListTableAdapter();
            this.tableAdapterManager = new simple_CRUD.mainDSTableAdapters.TableAdapterManager();
            this.sidTextBox = new System.Windows.Forms.TextBox();
            this.snameTextBox = new System.Windows.Forms.TextBox();
            this.sfamilyTextBox = new System.Windows.Forms.TextBox();
            this.scmeliTextBox = new System.Windows.Forms.TextBox();
            this.smobileTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            sidLabel = new System.Windows.Forms.Label();
            snameLabel = new System.Windows.Forms.Label();
            sfamilyLabel = new System.Windows.Forms.Label();
            scmeliLabel = new System.Windows.Forms.Label();
            smobileLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sidLabel
            // 
            sidLabel.AutoSize = true;
            sidLabel.Location = new System.Drawing.Point(16, 15);
            sidLabel.Name = "sidLabel";
            sidLabel.Size = new System.Drawing.Size(23, 13);
            sidLabel.TabIndex = 0;
            sidLabel.Text = "sid:";
            // 
            // snameLabel
            // 
            snameLabel.AutoSize = true;
            snameLabel.Location = new System.Drawing.Point(16, 41);
            snameLabel.Name = "snameLabel";
            snameLabel.Size = new System.Drawing.Size(41, 13);
            snameLabel.TabIndex = 2;
            snameLabel.Text = "sname:";
            // 
            // sfamilyLabel
            // 
            sfamilyLabel.AutoSize = true;
            sfamilyLabel.Location = new System.Drawing.Point(16, 67);
            sfamilyLabel.Name = "sfamilyLabel";
            sfamilyLabel.Size = new System.Drawing.Size(41, 13);
            sfamilyLabel.TabIndex = 4;
            sfamilyLabel.Text = "sfamily:";
            // 
            // scmeliLabel
            // 
            scmeliLabel.AutoSize = true;
            scmeliLabel.Location = new System.Drawing.Point(16, 93);
            scmeliLabel.Name = "scmeliLabel";
            scmeliLabel.Size = new System.Drawing.Size(39, 13);
            scmeliLabel.TabIndex = 6;
            scmeliLabel.Text = "scmeli:";
            // 
            // smobileLabel
            // 
            smobileLabel.AutoSize = true;
            smobileLabel.Location = new System.Drawing.Point(16, 119);
            smobileLabel.Name = "smobileLabel";
            smobileLabel.Size = new System.Drawing.Size(45, 13);
            smobileLabel.TabIndex = 8;
            smobileLabel.Text = "smobile:";
            // 
            // mainDS
            // 
            this.mainDS.DataSetName = "mainDS";
            this.mainDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stuListBindingSource
            // 
            this.stuListBindingSource.DataMember = "stuList";
            this.stuListBindingSource.DataSource = this.mainDS;
            // 
            // stuListTableAdapter
            // 
            this.stuListTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.stuListTableAdapter = this.stuListTableAdapter;
            this.tableAdapterManager.UpdateOrder = simple_CRUD.mainDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sidTextBox
            // 
            this.sidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuListBindingSource, "sid", true));
            this.sidTextBox.Location = new System.Drawing.Point(67, 12);
            this.sidTextBox.Name = "sidTextBox";
            this.sidTextBox.Size = new System.Drawing.Size(100, 20);
            this.sidTextBox.TabIndex = 1;
            // 
            // snameTextBox
            // 
            this.snameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuListBindingSource, "sname", true));
            this.snameTextBox.Location = new System.Drawing.Point(67, 38);
            this.snameTextBox.Name = "snameTextBox";
            this.snameTextBox.Size = new System.Drawing.Size(100, 20);
            this.snameTextBox.TabIndex = 3;
            // 
            // sfamilyTextBox
            // 
            this.sfamilyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuListBindingSource, "sfamily", true));
            this.sfamilyTextBox.Location = new System.Drawing.Point(67, 64);
            this.sfamilyTextBox.Name = "sfamilyTextBox";
            this.sfamilyTextBox.Size = new System.Drawing.Size(100, 20);
            this.sfamilyTextBox.TabIndex = 5;
            // 
            // scmeliTextBox
            // 
            this.scmeliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuListBindingSource, "scmeli", true));
            this.scmeliTextBox.Location = new System.Drawing.Point(67, 90);
            this.scmeliTextBox.Name = "scmeliTextBox";
            this.scmeliTextBox.Size = new System.Drawing.Size(100, 20);
            this.scmeliTextBox.TabIndex = 7;
            // 
            // smobileTextBox
            // 
            this.smobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuListBindingSource, "smobile", true));
            this.smobileTextBox.Location = new System.Drawing.Point(67, 116);
            this.smobileTextBox.Name = "smobileTextBox";
            this.smobileTextBox.Size = new System.Drawing.Size(100, 20);
            this.smobileTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 181);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(sidLabel);
            this.Controls.Add(this.sidTextBox);
            this.Controls.Add(snameLabel);
            this.Controls.Add(this.snameTextBox);
            this.Controls.Add(sfamilyLabel);
            this.Controls.Add(this.sfamilyTextBox);
            this.Controls.Add(scmeliLabel);
            this.Controls.Add(this.scmeliTextBox);
            this.Controls.Add(smobileLabel);
            this.Controls.Add(this.smobileTextBox);
            this.Name = "Form2";
            this.Text = "Add Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mainDS mainDS;
        private System.Windows.Forms.BindingSource stuListBindingSource;
        private mainDSTableAdapters.stuListTableAdapter stuListTableAdapter;
        private mainDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox sidTextBox;
        private System.Windows.Forms.TextBox snameTextBox;
        private System.Windows.Forms.TextBox sfamilyTextBox;
        private System.Windows.Forms.TextBox scmeliTextBox;
        private System.Windows.Forms.TextBox smobileTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}