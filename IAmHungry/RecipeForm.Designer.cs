namespace IAmHungry
{
    partial class RecipeForm
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
            this.pbRecipePic = new System.Windows.Forms.PictureBox();
            this.btbChangeSearch = new System.Windows.Forms.Button();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblIngredientList = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnKeepSearching = new System.Windows.Forms.Button();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.txtInstruction = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecipePic)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRecipePic
            // 
            this.pbRecipePic.Location = new System.Drawing.Point(25, 91);
            this.pbRecipePic.Name = "pbRecipePic";
            this.pbRecipePic.Size = new System.Drawing.Size(483, 453);
            this.pbRecipePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRecipePic.TabIndex = 0;
            this.pbRecipePic.TabStop = false;
            // 
            // btbChangeSearch
            // 
            this.btbChangeSearch.Location = new System.Drawing.Point(25, 633);
            this.btbChangeSearch.Name = "btbChangeSearch";
            this.btbChangeSearch.Size = new System.Drawing.Size(185, 43);
            this.btbChangeSearch.TabIndex = 4;
            this.btbChangeSearch.Text = "<< Change search";
            this.btbChangeSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbChangeSearch.UseVisualStyleBackColor = true;
            this.btbChangeSearch.Click += new System.EventHandler(this.btbChangeSearch_Click);
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(526, 14);
            this.lblIngredients.MaximumSize = new System.Drawing.Size(1000, 0);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(144, 29);
            this.lblIngredients.TabIndex = 5;
            this.lblIngredients.Text = "Ingredients";
            // 
            // lblIngredientList
            // 
            this.lblIngredientList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIngredientList.Location = new System.Drawing.Point(531, 53);
            this.lblIngredientList.Name = "lblIngredientList";
            this.lblIngredientList.Size = new System.Drawing.Size(517, 180);
            this.lblIngredientList.TabIndex = 6;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(526, 248);
            this.lblInstruction.MaximumSize = new System.Drawing.Size(1000, 0);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(133, 29);
            this.lblInstruction.TabIndex = 8;
            this.lblInstruction.Text = "Instruction";
            // 
            // btnKeepSearching
            // 
            this.btnKeepSearching.Location = new System.Drawing.Point(863, 633);
            this.btnKeepSearching.Name = "btnKeepSearching";
            this.btnKeepSearching.Size = new System.Drawing.Size(185, 43);
            this.btnKeepSearching.TabIndex = 9;
            this.btnKeepSearching.Text = "Keep searching >>";
            this.btnKeepSearching.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKeepSearching.UseVisualStyleBackColor = true;
            this.btnKeepSearching.Click += new System.EventHandler(this.btnKeepSearching_Click);
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeName.Location = new System.Drawing.Point(20, 14);
            this.lblRecipeName.MaximumSize = new System.Drawing.Size(1000, 0);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(167, 29);
            this.lblRecipeName.TabIndex = 10;
            this.lblRecipeName.Text = "Recipe name";
            // 
            // txtInstruction
            // 
            this.txtInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstruction.Location = new System.Drawing.Point(531, 291);
            this.txtInstruction.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.txtInstruction.Multiline = true;
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.ReadOnly = true;
            this.txtInstruction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInstruction.Size = new System.Drawing.Size(517, 253);
            this.txtInstruction.TabIndex = 11;
            this.txtInstruction.Text = "Recipe instructions";
            // 
            // RecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 688);
            this.Controls.Add(this.txtInstruction);
            this.Controls.Add(this.lblRecipeName);
            this.Controls.Add(this.btnKeepSearching);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblIngredientList);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.btbChangeSearch);
            this.Controls.Add(this.pbRecipePic);
            this.Name = "RecipeForm";
            this.Text = "Recipe";
            this.Load += new System.EventHandler(this.RecipeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRecipePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRecipePic;
        private System.Windows.Forms.Button btbChangeSearch;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblIngredientList;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnKeepSearching;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.TextBox txtInstruction;
    }
}