
namespace AdoNetDemo
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
            this.Data_Grid_View_Products = new System.Windows.Forms.DataGridView();
            this.Add_Group = new System.Windows.Forms.GroupBox();
            this.Add_Stock_Text = new System.Windows.Forms.TextBox();
            this.Add_Stock_Label = new System.Windows.Forms.Label();
            this.Add_Price_Text = new System.Windows.Forms.TextBox();
            this.Add_Price_Label = new System.Windows.Forms.Label();
            this.Add_Name_Text = new System.Windows.Forms.TextBox();
            this.Add_Name_Label = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Update_Group = new System.Windows.Forms.GroupBox();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Update_Stock_Text = new System.Windows.Forms.TextBox();
            this.Update_Stock_Label = new System.Windows.Forms.Label();
            this.Update_Price_Text = new System.Windows.Forms.TextBox();
            this.Update_Price_Label = new System.Windows.Forms.Label();
            this.Update_Name_Text = new System.Windows.Forms.TextBox();
            this.Update_Name_Label = new System.Windows.Forms.Label();
            this.Delete_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Grid_View_Products)).BeginInit();
            this.Add_Group.SuspendLayout();
            this.Update_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // Data_Grid_View_Products
            // 
            this.Data_Grid_View_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Grid_View_Products.Location = new System.Drawing.Point(12, 12);
            this.Data_Grid_View_Products.Name = "Data_Grid_View_Products";
            this.Data_Grid_View_Products.Size = new System.Drawing.Size(400, 194);
            this.Data_Grid_View_Products.TabIndex = 0;
            this.Data_Grid_View_Products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Grid_View_Products_CellClick);
            this.Data_Grid_View_Products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Grid_View_Products_CellContentClick);
            // 
            // Add_Group
            // 
            this.Add_Group.Controls.Add(this.Add_Stock_Text);
            this.Add_Group.Controls.Add(this.Add_Stock_Label);
            this.Add_Group.Controls.Add(this.Add_Price_Text);
            this.Add_Group.Controls.Add(this.Add_Price_Label);
            this.Add_Group.Controls.Add(this.Add_Name_Text);
            this.Add_Group.Controls.Add(this.Add_Name_Label);
            this.Add_Group.Location = new System.Drawing.Point(12, 232);
            this.Add_Group.Name = "Add_Group";
            this.Add_Group.Size = new System.Drawing.Size(200, 139);
            this.Add_Group.TabIndex = 1;
            this.Add_Group.TabStop = false;
            this.Add_Group.Text = "Add Product";
            // 
            // Add_Stock_Text
            // 
            this.Add_Stock_Text.Location = new System.Drawing.Point(48, 72);
            this.Add_Stock_Text.Name = "Add_Stock_Text";
            this.Add_Stock_Text.Size = new System.Drawing.Size(146, 20);
            this.Add_Stock_Text.TabIndex = 6;
            // 
            // Add_Stock_Label
            // 
            this.Add_Stock_Label.AutoSize = true;
            this.Add_Stock_Label.Location = new System.Drawing.Point(7, 75);
            this.Add_Stock_Label.Name = "Add_Stock_Label";
            this.Add_Stock_Label.Size = new System.Drawing.Size(35, 13);
            this.Add_Stock_Label.TabIndex = 5;
            this.Add_Stock_Label.Text = "Stock";
            // 
            // Add_Price_Text
            // 
            this.Add_Price_Text.Location = new System.Drawing.Point(48, 44);
            this.Add_Price_Text.Name = "Add_Price_Text";
            this.Add_Price_Text.Size = new System.Drawing.Size(146, 20);
            this.Add_Price_Text.TabIndex = 4;
            // 
            // Add_Price_Label
            // 
            this.Add_Price_Label.AutoSize = true;
            this.Add_Price_Label.Location = new System.Drawing.Point(7, 47);
            this.Add_Price_Label.Name = "Add_Price_Label";
            this.Add_Price_Label.Size = new System.Drawing.Size(31, 13);
            this.Add_Price_Label.TabIndex = 3;
            this.Add_Price_Label.Text = "Price";
            // 
            // Add_Name_Text
            // 
            this.Add_Name_Text.Location = new System.Drawing.Point(48, 17);
            this.Add_Name_Text.Name = "Add_Name_Text";
            this.Add_Name_Text.Size = new System.Drawing.Size(146, 20);
            this.Add_Name_Text.TabIndex = 2;
            // 
            // Add_Name_Label
            // 
            this.Add_Name_Label.AutoSize = true;
            this.Add_Name_Label.Location = new System.Drawing.Point(7, 20);
            this.Add_Name_Label.Name = "Add_Name_Label";
            this.Add_Name_Label.Size = new System.Drawing.Size(35, 13);
            this.Add_Name_Label.TabIndex = 0;
            this.Add_Name_Label.Text = "Name";
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(60, 339);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(146, 23);
            this.Add_Button.TabIndex = 2;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Update_Group
            // 
            this.Update_Group.Controls.Add(this.Update_Button);
            this.Update_Group.Controls.Add(this.Update_Stock_Text);
            this.Update_Group.Controls.Add(this.Update_Stock_Label);
            this.Update_Group.Controls.Add(this.Update_Price_Text);
            this.Update_Group.Controls.Add(this.Update_Price_Label);
            this.Update_Group.Controls.Add(this.Update_Name_Text);
            this.Update_Group.Controls.Add(this.Update_Name_Label);
            this.Update_Group.Location = new System.Drawing.Point(218, 232);
            this.Update_Group.Name = "Update_Group";
            this.Update_Group.Size = new System.Drawing.Size(200, 139);
            this.Update_Group.TabIndex = 3;
            this.Update_Group.TabStop = false;
            this.Update_Group.Text = "Update";
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(48, 107);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(146, 23);
            this.Update_Button.TabIndex = 7;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Update_Stock_Text
            // 
            this.Update_Stock_Text.Location = new System.Drawing.Point(48, 72);
            this.Update_Stock_Text.Name = "Update_Stock_Text";
            this.Update_Stock_Text.Size = new System.Drawing.Size(146, 20);
            this.Update_Stock_Text.TabIndex = 6;
            // 
            // Update_Stock_Label
            // 
            this.Update_Stock_Label.AutoSize = true;
            this.Update_Stock_Label.Location = new System.Drawing.Point(7, 75);
            this.Update_Stock_Label.Name = "Update_Stock_Label";
            this.Update_Stock_Label.Size = new System.Drawing.Size(35, 13);
            this.Update_Stock_Label.TabIndex = 5;
            this.Update_Stock_Label.Text = "Stock";
            // 
            // Update_Price_Text
            // 
            this.Update_Price_Text.Location = new System.Drawing.Point(48, 44);
            this.Update_Price_Text.Name = "Update_Price_Text";
            this.Update_Price_Text.Size = new System.Drawing.Size(146, 20);
            this.Update_Price_Text.TabIndex = 4;
            // 
            // Update_Price_Label
            // 
            this.Update_Price_Label.AutoSize = true;
            this.Update_Price_Label.Location = new System.Drawing.Point(7, 47);
            this.Update_Price_Label.Name = "Update_Price_Label";
            this.Update_Price_Label.Size = new System.Drawing.Size(31, 13);
            this.Update_Price_Label.TabIndex = 3;
            this.Update_Price_Label.Text = "Price";
            // 
            // Update_Name_Text
            // 
            this.Update_Name_Text.Location = new System.Drawing.Point(48, 17);
            this.Update_Name_Text.Name = "Update_Name_Text";
            this.Update_Name_Text.Size = new System.Drawing.Size(146, 20);
            this.Update_Name_Text.TabIndex = 2;
            // 
            // Update_Name_Label
            // 
            this.Update_Name_Label.AutoSize = true;
            this.Update_Name_Label.Location = new System.Drawing.Point(7, 20);
            this.Update_Name_Label.Name = "Update_Name_Label";
            this.Update_Name_Label.Size = new System.Drawing.Size(35, 13);
            this.Update_Name_Label.TabIndex = 0;
            this.Update_Name_Label.Text = "Name";
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(145, 377);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(146, 23);
            this.Delete_Button.TabIndex = 7;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 529);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Update_Group);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Add_Group);
            this.Controls.Add(this.Data_Grid_View_Products);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Grid_View_Products)).EndInit();
            this.Add_Group.ResumeLayout(false);
            this.Add_Group.PerformLayout();
            this.Update_Group.ResumeLayout(false);
            this.Update_Group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Data_Grid_View_Products;
        private System.Windows.Forms.GroupBox Add_Group;
        private System.Windows.Forms.TextBox Add_Stock_Text;
        private System.Windows.Forms.Label Add_Stock_Label;
        private System.Windows.Forms.TextBox Add_Price_Text;
        private System.Windows.Forms.Label Add_Price_Label;
        private System.Windows.Forms.TextBox Add_Name_Text;
        private System.Windows.Forms.Label Add_Name_Label;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.GroupBox Update_Group;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.TextBox Update_Stock_Text;
        private System.Windows.Forms.Label Update_Stock_Label;
        private System.Windows.Forms.TextBox Update_Price_Text;
        private System.Windows.Forms.Label Update_Price_Label;
        private System.Windows.Forms.TextBox Update_Name_Text;
        private System.Windows.Forms.Label Update_Name_Label;
        private System.Windows.Forms.Button Delete_Button;
    }
}

