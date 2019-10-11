namespace Select
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.practiceDataSet = new Select.PracticeDataSet();
            this.practiceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practiceDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.practiceDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.practiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(398, 89);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // practiceDataSet
            // 
            this.practiceDataSet.DataSetName = "PracticeDataSet";
            this.practiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // practiceDataSetBindingSource
            // 
            this.practiceDataSetBindingSource.DataSource = this.practiceDataSet;
            this.practiceDataSetBindingSource.Position = 0;
            // 
            // practiceDataSetBindingSource1
            // 
            this.practiceDataSetBindingSource1.DataSource = this.practiceDataSet;
            this.practiceDataSetBindingSource1.Position = 0;
            // 
            // practiceDataSetBindingSource2
            // 
            this.practiceDataSetBindingSource2.DataSource = typeof(Select.PracticeDataSet);
            this.practiceDataSetBindingSource2.Position = 0;
            // 
            // itemComboBox
            // 
            this.itemComboBox.DataSource = this.itemBindingSource;
            this.itemComboBox.DisplayMember = "Name";
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(263, 90);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(121, 21);
            this.itemComboBox.TabIndex = 3;
            this.itemComboBox.ValueMember = "Id";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(Select.Form1);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(Select.Model.Item);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.practiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.BindingSource practiceDataSetBindingSource;
        private PracticeDataSet practiceDataSet;
        private System.Windows.Forms.BindingSource practiceDataSetBindingSource1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource practiceDataSetBindingSource2;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.BindingSource itemBindingSource;
    }
}

