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
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblFileNameText = new System.Windows.Forms.Label();
            this.lblMealType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMealType = new System.Windows.Forms.ComboBox();
            this.clbTaste = new System.Windows.Forms.CheckedListBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Location = new System.Drawing.Point(12, 41);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(107, 20);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "Recipe name:";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(153, 38);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(635, 26);
            this.txtRecipeName.TabIndex = 1;
            this.txtRecipeName.TextChanged += new System.EventHandler(this.txtRecipeName_TextChanged);
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
            this.btnAddIngredients.Location = new System.Drawing.Point(12, 123);
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
            this.flwIngredients.Location = new System.Drawing.Point(153, 123);
            this.flwIngredients.Margin = new System.Windows.Forms.Padding(0);
            this.flwIngredients.Name = "flwIngredients";
            this.flwIngredients.Size = new System.Drawing.Size(635, 226);
            this.flwIngredients.TabIndex = 5;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(12, 6);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(82, 20);
            this.lblFileName.TabIndex = 6;
            this.lblFileName.Text = "File name:";
            // 
            // lblFileNameText
            // 
            this.lblFileNameText.AutoSize = true;
            this.lblFileNameText.Location = new System.Drawing.Point(153, 5);
            this.lblFileNameText.Name = "lblFileNameText";
            this.lblFileNameText.Size = new System.Drawing.Size(21, 20);
            this.lblFileNameText.TabIndex = 7;
            this.lblFileNameText.Text = "...";
            // 
            // lblMealType
            // 
            this.lblMealType.AutoSize = true;
            this.lblMealType.Location = new System.Drawing.Point(447, 353);
            this.lblMealType.Name = "lblMealType";
            this.lblMealType.Size = new System.Drawing.Size(81, 20);
            this.lblMealType.TabIndex = 8;
            this.lblMealType.Text = "Meal type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Taste tags:";
            // 
            // cboMealType
            // 
            this.cboMealType.FormattingEnabled = true;
            this.cboMealType.Location = new System.Drawing.Point(588, 353);
            this.cboMealType.Name = "cboMealType";
            this.cboMealType.Size = new System.Drawing.Size(121, 28);
            this.cboMealType.TabIndex = 10;
            this.cboMealType.SelectedIndexChanged += new System.EventHandler(this.cboMealType_SelectedIndexChanged);
            // 
            // clbTaste
            // 
            this.clbTaste.CheckOnClick = true;
            this.clbTaste.FormattingEnabled = true;
            this.clbTaste.Location = new System.Drawing.Point(153, 352);
            this.clbTaste.Name = "clbTaste";
            this.clbTaste.Size = new System.Drawing.Size(237, 73);
            this.clbTaste.TabIndex = 12;
            this.clbTaste.SelectedIndexChanged += new System.EventHandler(this.clbTaste_SelectedIndexChanged);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 74);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(87, 20);
            this.lblUrl.TabIndex = 13;
            this.lblUrl.Text = "Recipe pic:";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(153, 74);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(635, 26);
            this.txtUrl.TabIndex = 14;
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // RecipeAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.clbTaste);
            this.Controls.Add(this.cboMealType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMealType);
            this.Controls.Add(this.lblFileNameText);
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
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblFileNameText;
        private System.Windows.Forms.Label lblMealType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMealType;
        private System.Windows.Forms.CheckedListBox clbTaste;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
    }
}

