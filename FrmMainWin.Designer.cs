namespace GroupDataInGrid
{
    partial class FrmMainWin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.chkOrg = new System.Windows.Forms.CheckBox();
            this.chkCity = new System.Windows.Forms.CheckBox();
            this.chkCountry = new System.Windows.Forms.CheckBox();
            this.chkManager = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(833, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Checked = true;
            this.chkDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDate.Location = new System.Drawing.Point(861, 13);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(52, 17);
            this.chkDate.TabIndex = 2;
            this.chkDate.Text = "Дата";
            this.chkDate.UseVisualStyleBackColor = true;
            this.chkDate.CheckedChanged += new System.EventHandler(this.chkDate_CheckedChanged);
            // 
            // chkOrg
            // 
            this.chkOrg.AutoSize = true;
            this.chkOrg.Checked = true;
            this.chkOrg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOrg.Location = new System.Drawing.Point(861, 36);
            this.chkOrg.Name = "chkOrg";
            this.chkOrg.Size = new System.Drawing.Size(93, 17);
            this.chkOrg.TabIndex = 3;
            this.chkOrg.Text = "Организация";
            this.chkOrg.UseVisualStyleBackColor = true;
            this.chkOrg.CheckedChanged += new System.EventHandler(this.chkOrg_CheckedChanged);
            // 
            // chkCity
            // 
            this.chkCity.AutoSize = true;
            this.chkCity.Checked = true;
            this.chkCity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCity.Location = new System.Drawing.Point(861, 59);
            this.chkCity.Name = "chkCity";
            this.chkCity.Size = new System.Drawing.Size(56, 17);
            this.chkCity.TabIndex = 4;
            this.chkCity.Text = "Город";
            this.chkCity.UseVisualStyleBackColor = true;
            this.chkCity.CheckedChanged += new System.EventHandler(this.chkCity_CheckedChanged);
            // 
            // chkCountry
            // 
            this.chkCountry.AutoSize = true;
            this.chkCountry.Checked = true;
            this.chkCountry.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCountry.Location = new System.Drawing.Point(861, 82);
            this.chkCountry.Name = "chkCountry";
            this.chkCountry.Size = new System.Drawing.Size(62, 17);
            this.chkCountry.TabIndex = 5;
            this.chkCountry.Text = "Страна";
            this.chkCountry.UseVisualStyleBackColor = true;
            this.chkCountry.CheckedChanged += new System.EventHandler(this.chkCountry_CheckedChanged);
            // 
            // chkManager
            // 
            this.chkManager.AutoSize = true;
            this.chkManager.Checked = true;
            this.chkManager.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkManager.Location = new System.Drawing.Point(861, 105);
            this.chkManager.Name = "chkManager";
            this.chkManager.Size = new System.Drawing.Size(79, 17);
            this.chkManager.TabIndex = 6;
            this.chkManager.Text = "Менеджер";
            this.chkManager.UseVisualStyleBackColor = true;
            this.chkManager.CheckedChanged += new System.EventHandler(this.chkManager_CheckedChanged);
            // 
            // FrmMainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 227);
            this.Controls.Add(this.chkManager);
            this.Controls.Add(this.chkCountry);
            this.Controls.Add(this.chkCity);
            this.Controls.Add(this.chkOrg);
            this.Controls.Add(this.chkDate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmMainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.CheckBox chkOrg;
        private System.Windows.Forms.CheckBox chkCity;
        private System.Windows.Forms.CheckBox chkCountry;
        private System.Windows.Forms.CheckBox chkManager;
    }
}

