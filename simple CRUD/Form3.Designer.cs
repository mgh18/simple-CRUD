namespace simple_CRUD
{
    partial class Form3
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
            this.sidTextBox = new System.Windows.Forms.TextBox();
            this.snameTextBox = new System.Windows.Forms.TextBox();
            this.sfamilyTextBox = new System.Windows.Forms.TextBox();
            this.scmeliTextBox = new System.Windows.Forms.TextBox();
            this.smobileTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.stuListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDS = new simple_CRUD.mainDS();
            this.stuListTableAdapter = new simple_CRUD.mainDSTableAdapters.stuListTableAdapter();
            this.tableAdapterManager = new simple_CRUD.mainDSTableAdapters.TableAdapterManager();
            sidLabel = new System.Windows.Forms.Label();
            snameLabel = new System.Windows.Forms.Label();
            sfamilyLabel = new System.Windows.Forms.Label();
            scmeliLabel = new System.Windows.Forms.Label();
            smobileLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stuListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDS)).BeginInit();
            this.SuspendLayout();
            // 
            // sidLabel
            // 
            sidLabel.AutoSize = true;
            sidLabel.Location = new System.Drawing.Point(18, 27);
            sidLabel.Name = "sidLabel";
            sidLabel.Size = new System.Drawing.Size(23, 13);
            sidLabel.TabIndex = 1;
            sidLabel.Text = "sid:";
            // 
            // sidTextBox
            // 
            this.sidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuListBindingSource, "sid", true));
            this.sidTextBox.Location = new System.Drawing.Point(69, 24);
            this.sidTextBox.Name = "sidTextBox";
            this.sidTextBox.Size = new System.Drawing.Size(100, 20);
            this.sidTextBox.TabIndex = 2;
            // 
            // snameLabel
            // 
            snameLabel.AutoSize = true;
            snameLabel.Location = new System.Drawing.Point(18, 53);
            snameLabel.Name = "snameLabel";
            snameLabel.Size = new System.Drawing.Size(41, 13);
            snameLabel.TabIndex = 3;
            snameLabel.Text = "sname:";
            // 
            // snameTextBox
            // 
            this.snameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuListBindingSource, "sname", true));
            this.snameTextBox.Location = new System.Drawing.Point(69, 50);
            this.snameTextBox.Name = "snameTextBox";
            this.snameTextBox.Size = new System.Drawing.Size(100, 20);
            this.snameTextBox.TabIndex = 4;
            // 
            // sfamilyLabel
            // 
            sfamilyLabel.AutoSize = true;
            sfamilyLabel.Location = new System.Drawing.Point(18, 79);
            sfamilyLabel.Name = "sfamilyLabel";
            sfamilyLabel.Size = new System.Drawing.Size(41, 13);
            sfamilyLabel.TabIndex = 5;
            sfamilyLabel.Text = "sfamily:";
            // 
            // sfamilyTextBox
            // 
            this.sfamilyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuListBindingSource, "sfamily", true));
            this.sfamilyTextBox.Location = new System.Drawing.Point(69, 76);
            this.sfamilyTextBox.Name = "sfamilyTextBox";
            this.sfamilyTextBox.Size = new System.Drawing.Size(100, 20);
            this.sfamilyTextBox.TabIndex = 6;
            // 
            // scmeliLabel
            // 
            scmeliLabel.AutoSize = true;
            scmeliLabel.Location = new System.Drawing.Point(18, 105);
            scmeliLabel.Name = "scmeliLabel";
            scmeliLabel.Size = new System.Drawing.Size(39, 13);
            scmeliLabel.TabIndex = 7;
            scmeliLabel.Text = "scmeli:";
            // 
            // scmeliTextBox
            // 
            this.scmeliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuListBindingSource, "scmeli", true));
            this.scmeliTextBox.Location = new System.Drawing.Point(69, 102);
            this.scmeliTextBox.Name = "scmeliTextBox";
            this.scmeliTextBox.Size = new System.Drawing.Size(100, 20);
            this.scmeliTextBox.TabIndex = 8;
            // 
            // smobileLabel
            // 
            smobileLabel.AutoSize = true;
            smobileLabel.Location = new System.Drawing.Point(18, 131);
            smobileLabel.Name = "smobileLabel";
            smobileLabel.Size = new System.Drawing.Size(45, 13);
            smobileLabel.TabIndex = 9;
            smobileLabel.Text = "smobile:";
            // 
            // smobileTextBox
            // 
            this.smobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuListBindingSource, "smobile", true));
            this.smobileTextBox.Location = new System.Drawing.Point(69, 128);
            this.smobileTextBox.Name = "smobileTextBox";
            this.smobileTextBox.Size = new System.Drawing.Size(100, 20);
            this.smobileTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // stuListBindingSource
            // 
            this.stuListBindingSource.DataMember = "stuList";
            this.stuListBindingSource.DataSource = this.mainDS;
            // 
            // mainDS
            // 
            this.mainDS.DataSetName = "mainDS";
            this.mainDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 217);
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
            this.Name = "Form3";
            this.Text = "Edit Form";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stuListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDS)).EndInit();
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