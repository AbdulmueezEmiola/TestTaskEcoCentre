namespace TestTaskEcoCentre
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
            this.openXmlButton = new System.Windows.Forms.Button();
            this.saveXmlButton = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.XmlDisplayDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.XmlDisplayDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // openXmlButton
            // 
            this.openXmlButton.AutoEllipsis = true;
            this.openXmlButton.BackColor = System.Drawing.Color.Gold;
            this.openXmlButton.ForeColor = System.Drawing.Color.White;
            this.openXmlButton.Location = new System.Drawing.Point(41, 27);
            this.openXmlButton.Name = "openXmlButton";
            this.openXmlButton.Size = new System.Drawing.Size(172, 52);
            this.openXmlButton.TabIndex = 0;
            this.openXmlButton.Text = "Open XML";
            this.openXmlButton.UseVisualStyleBackColor = false;
            this.openXmlButton.Click += new System.EventHandler(this.openXmlButton_Click);
            // 
            // saveXmlButton
            // 
            this.saveXmlButton.AutoEllipsis = true;
            this.saveXmlButton.BackColor = System.Drawing.Color.Orange;
            this.saveXmlButton.Enabled = false;
            this.saveXmlButton.ForeColor = System.Drawing.Color.White;
            this.saveXmlButton.Location = new System.Drawing.Point(304, 27);
            this.saveXmlButton.Name = "saveXmlButton";
            this.saveXmlButton.Size = new System.Drawing.Size(172, 52);
            this.saveXmlButton.TabIndex = 1;
            this.saveXmlButton.Text = "Save XML";
            this.saveXmlButton.UseVisualStyleBackColor = false;
            this.saveXmlButton.Click += new System.EventHandler(this.saveXmlButton_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.AutoEllipsis = true;
            this.buttonConvert.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonConvert.Enabled = false;
            this.buttonConvert.ForeColor = System.Drawing.Color.White;
            this.buttonConvert.Location = new System.Drawing.Point(991, 27);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(172, 52);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert To HTML";
            this.buttonConvert.UseVisualStyleBackColor = false;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoEllipsis = true;
            this.buttonDelete.BackColor = System.Drawing.Color.Black;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(41, 504);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(172, 52);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete Entry";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoEllipsis = true;
            this.buttonAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(270, 504);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(172, 52);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add Entry";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // XmlDisplayDataGridView
            // 
            this.XmlDisplayDataGridView.AllowUserToAddRows = false;
            this.XmlDisplayDataGridView.AllowUserToDeleteRows = false;
            this.XmlDisplayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.XmlDisplayDataGridView.Location = new System.Drawing.Point(27, 85);
            this.XmlDisplayDataGridView.Name = "XmlDisplayDataGridView";
            this.XmlDisplayDataGridView.RowHeadersWidth = 62;
            this.XmlDisplayDataGridView.RowTemplate.Height = 28;
            this.XmlDisplayDataGridView.Size = new System.Drawing.Size(1230, 386);
            this.XmlDisplayDataGridView.TabIndex = 5;
            this.XmlDisplayDataGridView.DataSourceChanged += new System.EventHandler(this.XmlDisplayDataGridView_DataSourceChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 568);
            this.Controls.Add(this.XmlDisplayDataGridView);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.saveXmlButton);
            this.Controls.Add(this.openXmlButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XmlDisplayDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openXmlButton;
        private System.Windows.Forms.Button saveXmlButton;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView XmlDisplayDataGridView;
    }
}

