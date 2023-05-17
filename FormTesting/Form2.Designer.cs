namespace FormTesting
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
            this.label1 = new System.Windows.Forms.Label();
            this.customerTable = new System.Windows.Forms.DataGridView();
            this.customer_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drink_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.customer_label = new System.Windows.Forms.Label();
            this.customerBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_domestic = new System.Windows.Forms.RadioButton();
            this.radio_import = new System.Windows.Forms.RadioButton();
            this.radio_shot = new System.Windows.Forms.RadioButton();
            this.radio_doubleshot = new System.Windows.Forms.RadioButton();
            this.radio_cocktail = new System.Windows.Forms.RadioButton();
            this.radio_cooler = new System.Windows.Forms.RadioButton();
            this.radio_draft = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tab Tracker";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // customerTable
            // 
            this.customerTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_col,
            this.drink_col,
            this.price_col});
            this.customerTable.Location = new System.Drawing.Point(12, 202);
            this.customerTable.Name = "customerTable";
            this.customerTable.Size = new System.Drawing.Size(576, 295);
            this.customerTable.TabIndex = 1;
            this.customerTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // customer_col
            // 
            this.customer_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.customer_col.HeaderText = "Customer";
            this.customer_col.Name = "customer_col";
            this.customer_col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customer_col.Width = 76;
            // 
            // drink_col
            // 
            this.drink_col.HeaderText = "Drink";
            this.drink_col.Name = "drink_col";
            this.drink_col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // price_col
            // 
            this.price_col.HeaderText = "Price";
            this.price_col.Name = "price_col";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customer_label
            // 
            this.customer_label.AutoSize = true;
            this.customer_label.Location = new System.Drawing.Point(289, 22);
            this.customer_label.Name = "customer_label";
            this.customer_label.Size = new System.Drawing.Size(54, 13);
            this.customer_label.TabIndex = 1;
            this.customer_label.Text = "Customer:";
            // 
            // customerBox
            // 
            this.customerBox.Location = new System.Drawing.Point(346, 19);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(241, 20);
            this.customerBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_draft);
            this.groupBox1.Controls.Add(this.radio_cooler);
            this.groupBox1.Controls.Add(this.radio_cocktail);
            this.groupBox1.Controls.Add(this.radio_doubleshot);
            this.groupBox1.Controls.Add(this.radio_shot);
            this.groupBox1.Controls.Add(this.radio_import);
            this.groupBox1.Controls.Add(this.radio_domestic);
            this.groupBox1.Location = new System.Drawing.Point(289, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drink:";
            // 
            // radio_domestic
            // 
            this.radio_domestic.AutoSize = true;
            this.radio_domestic.Location = new System.Drawing.Point(6, 28);
            this.radio_domestic.Name = "radio_domestic";
            this.radio_domestic.Size = new System.Drawing.Size(69, 17);
            this.radio_domestic.TabIndex = 0;
            this.radio_domestic.TabStop = true;
            this.radio_domestic.Text = "Domestic";
            this.radio_domestic.UseVisualStyleBackColor = true;
            this.radio_domestic.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radio_import
            // 
            this.radio_import.AutoSize = true;
            this.radio_import.Location = new System.Drawing.Point(152, 28);
            this.radio_import.Name = "radio_import";
            this.radio_import.Size = new System.Drawing.Size(54, 17);
            this.radio_import.TabIndex = 1;
            this.radio_import.TabStop = true;
            this.radio_import.Text = "Import";
            this.radio_import.UseVisualStyleBackColor = true;
            // 
            // radio_shot
            // 
            this.radio_shot.AutoSize = true;
            this.radio_shot.Location = new System.Drawing.Point(6, 52);
            this.radio_shot.Name = "radio_shot";
            this.radio_shot.Size = new System.Drawing.Size(47, 17);
            this.radio_shot.TabIndex = 2;
            this.radio_shot.TabStop = true;
            this.radio_shot.Text = "Shot";
            this.radio_shot.UseVisualStyleBackColor = true;
            this.radio_shot.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radio_doubleshot
            // 
            this.radio_doubleshot.AutoSize = true;
            this.radio_doubleshot.Location = new System.Drawing.Point(152, 52);
            this.radio_doubleshot.Name = "radio_doubleshot";
            this.radio_doubleshot.Size = new System.Drawing.Size(84, 17);
            this.radio_doubleshot.TabIndex = 3;
            this.radio_doubleshot.TabStop = true;
            this.radio_doubleshot.Text = "Double Shot";
            this.radio_doubleshot.UseVisualStyleBackColor = true;
            // 
            // radio_cocktail
            // 
            this.radio_cocktail.AutoSize = true;
            this.radio_cocktail.Location = new System.Drawing.Point(6, 76);
            this.radio_cocktail.Name = "radio_cocktail";
            this.radio_cocktail.Size = new System.Drawing.Size(63, 17);
            this.radio_cocktail.TabIndex = 4;
            this.radio_cocktail.TabStop = true;
            this.radio_cocktail.Text = "Cocktail";
            this.radio_cocktail.UseVisualStyleBackColor = true;
            // 
            // radio_cooler
            // 
            this.radio_cooler.AutoSize = true;
            this.radio_cooler.Location = new System.Drawing.Point(152, 76);
            this.radio_cooler.Name = "radio_cooler";
            this.radio_cooler.Size = new System.Drawing.Size(55, 17);
            this.radio_cooler.TabIndex = 5;
            this.radio_cooler.TabStop = true;
            this.radio_cooler.Text = "Cooler";
            this.radio_cooler.UseVisualStyleBackColor = true;
            // 
            // radio_draft
            // 
            this.radio_draft.AutoSize = true;
            this.radio_draft.Location = new System.Drawing.Point(6, 100);
            this.radio_draft.Name = "radio_draft";
            this.radio_draft.Size = new System.Drawing.Size(48, 17);
            this.radio_draft.TabIndex = 6;
            this.radio_draft.TabStop = true;
            this.radio_draft.Text = "Draft";
            this.radio_draft.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customerBox);
            this.Controls.Add(this.customer_label);
            this.Controls.Add(this.customerTable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView customerTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn drink_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_col;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label customer_label;
        private System.Windows.Forms.TextBox customerBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_domestic;
        private System.Windows.Forms.RadioButton radio_import;
        private System.Windows.Forms.RadioButton radio_shot;
        private System.Windows.Forms.RadioButton radio_draft;
        private System.Windows.Forms.RadioButton radio_cooler;
        private System.Windows.Forms.RadioButton radio_cocktail;
        private System.Windows.Forms.RadioButton radio_doubleshot;
    }
}