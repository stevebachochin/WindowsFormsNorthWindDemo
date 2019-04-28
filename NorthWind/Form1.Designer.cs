namespace NorthWind
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
            this.buttonSelectedValue = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonNewPage = new System.Windows.Forms.Button();
            this.txtAPIGavity = new System.Windows.Forms.TextBox();
            this.buttonGetAPIGravity = new System.Windows.Forms.Button();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGravity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSelectedValue
            // 
            this.buttonSelectedValue.Location = new System.Drawing.Point(256, 186);
            this.buttonSelectedValue.Name = "buttonSelectedValue";
            this.buttonSelectedValue.Size = new System.Drawing.Size(129, 23);
            this.buttonSelectedValue.TabIndex = 1;
            this.buttonSelectedValue.TabStop = false;
            this.buttonSelectedValue.Text = "Selected Value";
            this.buttonSelectedValue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSelectedValue.UseVisualStyleBackColor = true;
            this.buttonSelectedValue.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(146, 186);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "buttonSave";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // buttonNewPage
            // 
            this.buttonNewPage.Location = new System.Drawing.Point(33, 186);
            this.buttonNewPage.Name = "buttonNewPage";
            this.buttonNewPage.Size = new System.Drawing.Size(75, 23);
            this.buttonNewPage.TabIndex = 4;
            this.buttonNewPage.Text = "New Page";
            this.buttonNewPage.UseVisualStyleBackColor = true;
            this.buttonNewPage.Click += new System.EventHandler(this.buttonNewPage_Click);
            // 
            // txtAPIGavity
            // 
            this.txtAPIGavity.Location = new System.Drawing.Point(417, 299);
            this.txtAPIGavity.Name = "txtAPIGavity";
            this.txtAPIGavity.ReadOnly = true;
            this.txtAPIGavity.Size = new System.Drawing.Size(100, 20);
            this.txtAPIGavity.TabIndex = 5;
            // 
            // buttonGetAPIGravity
            // 
            this.buttonGetAPIGravity.Location = new System.Drawing.Point(325, 299);
            this.buttonGetAPIGravity.Name = "buttonGetAPIGravity";
            this.buttonGetAPIGravity.Size = new System.Drawing.Size(75, 23);
            this.buttonGetAPIGravity.TabIndex = 6;
            this.buttonGetAPIGravity.Text = "get API Gravity";
            this.buttonGetAPIGravity.UseVisualStyleBackColor = true;
            this.buttonGetAPIGravity.Click += new System.EventHandler(this.buttonGetAPIGravity_Click);
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(208, 302);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(100, 20);
            this.txtTemperature.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Observed Temperature in F";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Observed Gravity";
            // 
            // txtGravity
            // 
            this.txtGravity.Location = new System.Drawing.Point(208, 339);
            this.txtGravity.Name = "txtGravity";
            this.txtGravity.Size = new System.Drawing.Size(100, 20);
            this.txtGravity.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGravity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.buttonGetAPIGravity);
            this.Controls.Add(this.txtAPIGavity);
            this.Controls.Add(this.buttonNewPage);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonSelectedValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSelectedValue;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.BindingSource bindingSource1;

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonNewPage;
        private System.Windows.Forms.TextBox txtAPIGavity;
        private System.Windows.Forms.Button buttonGetAPIGravity;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGravity;
    }
}

