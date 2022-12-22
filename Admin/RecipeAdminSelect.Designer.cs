namespace Admin
{
    partial class RecipeAdminSelect
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblSelectRecipe = new System.Windows.Forms.Label();
            this.cboChooseRecipe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEdit.Enabled = false;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEdit.Location = new System.Drawing.Point(344, 251);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(151, 40);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit recipe >>";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblSelectRecipe
            // 
            this.lblSelectRecipe.AutoSize = true;
            this.lblSelectRecipe.Location = new System.Drawing.Point(25, 42);
            this.lblSelectRecipe.Name = "lblSelectRecipe";
            this.lblSelectRecipe.Size = new System.Drawing.Size(153, 20);
            this.lblSelectRecipe.TabIndex = 1;
            this.lblSelectRecipe.Text = "Select recipe to edit:";
            // 
            // cboChooseRecipe
            // 
            this.cboChooseRecipe.FormattingEnabled = true;
            this.cboChooseRecipe.Location = new System.Drawing.Point(203, 42);
            this.cboChooseRecipe.Name = "cboChooseRecipe";
            this.cboChooseRecipe.Size = new System.Drawing.Size(292, 28);
            this.cboChooseRecipe.TabIndex = 2;
            this.cboChooseRecipe.SelectedIndexChanged += new System.EventHandler(this.cboChooseRecipe_SelectedIndexChanged);
            // 
            // RecipeAdminSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 307);
            this.Controls.Add(this.cboChooseRecipe);
            this.Controls.Add(this.lblSelectRecipe);
            this.Controls.Add(this.btnEdit);
            this.Name = "RecipeAdminSelect";
            this.Text = "Select recipe to edit";
            this.Load += new System.EventHandler(this.RecipeAdminSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblSelectRecipe;
        private System.Windows.Forms.ComboBox cboChooseRecipe;
    }
}