namespace УП_1
{
    partial class Form4
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
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amusement_parkDataSet = new УП_1.Amusement_parkDataSet();
            this.staffTableAdapter = new УП_1.Amusement_parkDataSetTableAdapters.staffTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.attractioncodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.safetyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attractionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attractionsTableAdapter = new УП_1.Amusement_parkDataSetTableAdapters.attractionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amusement_parkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.amusement_parkDataSet;
            // 
            // amusement_parkDataSet
            // 
            this.amusement_parkDataSet.DataSetName = "Amusement_parkDataSet";
            this.amusement_parkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Удалить аттракцион";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить аттракцион";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(12, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(636, 407);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 31);
            this.button4.TabIndex = 4;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attractioncodeDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.limitationsDataGridViewTextBoxColumn,
            this.safetyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.locusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attractionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 339);
            this.dataGridView1.TabIndex = 5;
            // 
            // attractioncodeDataGridViewTextBoxColumn
            // 
            this.attractioncodeDataGridViewTextBoxColumn.DataPropertyName = "attraction_code";
            this.attractioncodeDataGridViewTextBoxColumn.HeaderText = "attraction_code";
            this.attractioncodeDataGridViewTextBoxColumn.Name = "attractioncodeDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // limitationsDataGridViewTextBoxColumn
            // 
            this.limitationsDataGridViewTextBoxColumn.DataPropertyName = "limitations";
            this.limitationsDataGridViewTextBoxColumn.HeaderText = "limitations";
            this.limitationsDataGridViewTextBoxColumn.Name = "limitationsDataGridViewTextBoxColumn";
            // 
            // safetyDataGridViewTextBoxColumn
            // 
            this.safetyDataGridViewTextBoxColumn.DataPropertyName = "safety";
            this.safetyDataGridViewTextBoxColumn.HeaderText = "safety";
            this.safetyDataGridViewTextBoxColumn.Name = "safetyDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // locusDataGridViewTextBoxColumn
            // 
            this.locusDataGridViewTextBoxColumn.DataPropertyName = "locus";
            this.locusDataGridViewTextBoxColumn.HeaderText = "locus";
            this.locusDataGridViewTextBoxColumn.Name = "locusDataGridViewTextBoxColumn";
            // 
            // attractionsBindingSource
            // 
            this.attractionsBindingSource.DataMember = "attractions";
            this.attractionsBindingSource.DataSource = this.amusement_parkDataSet;
            // 
            // attractionsTableAdapter
            // 
            this.attractionsTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "База данных";
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amusement_parkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Amusement_parkDataSet amusement_parkDataSet;
        public System.Windows.Forms.BindingSource staffBindingSource;
        public Amusement_parkDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource attractionsBindingSource;
        private Amusement_parkDataSetTableAdapters.attractionsTableAdapter attractionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn attractioncodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn safetyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locusDataGridViewTextBoxColumn;
    }
}