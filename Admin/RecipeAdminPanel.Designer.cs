namespace Admin
{
    partial class RecipeAdminPanel
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
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddIngredients = new System.Windows.Forms.Button();
            this.flwIngredients = new System.Windows.Forms.FlowLayoutPanel();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Location = new System.Drawing.Point(12, 52);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(107, 20);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "Recipe name:";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(153, 49);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(635, 26);
            this.txtRecipeName.TabIndex = 1;
            this.txtRecipeName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSave.Location = new System.Drawing.Point(564, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(224, 38);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save and Close";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddIngredients
            // 
            this.btnAddIngredients.Location = new System.Drawing.Point(12, 90);
            this.btnAddIngredients.Name = "btnAddIngredients";
            this.btnAddIngredients.Size = new System.Drawing.Size(124, 46);
            this.btnAddIngredients.TabIndex = 4;
            this.btnAddIngredients.Text = "Add ingredient";
            this.btnAddIngredients.UseVisualStyleBackColor = true;
            this.btnAddIngredients.Click += new System.EventHandler(this.btnAddIngredients_Click);
            // 
            // flwIngredients
            // 
            this.flwIngredients.AutoScroll = true;
            this.flwIngredients.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwIngredients.Location = new System.Drawing.Point(153, 90);
            this.flwIngredients.Margin = new System.Windows.Forms.Padding(0);
            this.flwIngredients.Name = "flwIngredients";
            this.flwIngredients.Size = new System.Drawing.Size(635, 108);
            this.flwIngredients.TabIndex = 5;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(153, 11);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(635, 26);
            this.txtFileName.TabIndex = 7;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(12, 14);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(82, 20);
            this.lblFileName.TabIndex = 6;
            this.lblFileName.Text = "File name:";
            // 
            // RecipeAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.flwIngredients);
            this.Controls.Add(this.btnAddIngredients);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.lblRecipeName);
            this.Name = "RecipeAdminPanel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.RecipeAdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddIngredients;
        private System.Windows.Forms.FlowLayoutPanel flwIngredients;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;
    }
}

