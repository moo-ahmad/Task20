namespace Task20
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
            this.playerText = new System.Windows.Forms.TextBox();
            this.labelTextBox = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // playerText
            // 
            this.playerText.Location = new System.Drawing.Point(293, 118);
            this.playerText.Name = "playerText";
            this.playerText.Size = new System.Drawing.Size(146, 20);
            this.playerText.TabIndex = 0;
            // 
            // labelTextBox
            // 
            this.labelTextBox.AutoSize = true;
            this.labelTextBox.Location = new System.Drawing.Point(290, 102);
            this.labelTextBox.Name = "labelTextBox";
            this.labelTextBox.Size = new System.Drawing.Size(125, 13);
            this.labelTextBox.TabIndex = 1;
            this.labelTextBox.Text = "Enter Player\'s Last Name";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(230, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(316, 33);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Baseball Database App";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(321, 144);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(85, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search Player";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(81, 204);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.Size = new System.Drawing.Size(299, 305);
            this.dataGridViewTable.TabIndex = 4;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(435, 204);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(267, 281);
            this.dataGridViewResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 510);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.labelTextBox);
            this.Controls.Add(this.playerText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playerText;
        private System.Windows.Forms.Label labelTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.DataGridView dataGridViewResult;
    }
}

