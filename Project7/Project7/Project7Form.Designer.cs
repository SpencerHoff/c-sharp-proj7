namespace Project7
{
    partial class Project7Form
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
            this.firstname_box = new System.Windows.Forms.TextBox();
            this.lastname_box = new System.Windows.Forms.TextBox();
            this.state_box = new System.Windows.Forms.TextBox();
            this.customers_label = new System.Windows.Forms.Label();
            this.firstname_label = new System.Windows.Forms.Label();
            this.lastname_label = new System.Windows.Forms.Label();
            this.state_label = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.lastinitial_box = new System.Windows.Forms.TextBox();
            this.lastinitial_label = new System.Windows.Forms.Label();
            this.firstinital_label = new System.Windows.Forms.Label();
            this.firstinitial_box = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.customer_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // firstname_box
            // 
            this.firstname_box.Location = new System.Drawing.Point(193, 76);
            this.firstname_box.Name = "firstname_box";
            this.firstname_box.Size = new System.Drawing.Size(195, 20);
            this.firstname_box.TabIndex = 0;
            // 
            // lastname_box
            // 
            this.lastname_box.Location = new System.Drawing.Point(193, 149);
            this.lastname_box.Name = "lastname_box";
            this.lastname_box.Size = new System.Drawing.Size(195, 20);
            this.lastname_box.TabIndex = 1;
            // 
            // state_box
            // 
            this.state_box.Location = new System.Drawing.Point(193, 220);
            this.state_box.Name = "state_box";
            this.state_box.Size = new System.Drawing.Size(195, 20);
            this.state_box.TabIndex = 2;
            // 
            // customers_label
            // 
            this.customers_label.AutoSize = true;
            this.customers_label.Location = new System.Drawing.Point(461, 45);
            this.customers_label.Name = "customers_label";
            this.customers_label.Size = new System.Drawing.Size(59, 13);
            this.customers_label.TabIndex = 4;
            this.customers_label.Text = "Customers:";
            // 
            // firstname_label
            // 
            this.firstname_label.AutoSize = true;
            this.firstname_label.Location = new System.Drawing.Point(49, 76);
            this.firstname_label.Name = "firstname_label";
            this.firstname_label.Size = new System.Drawing.Size(60, 13);
            this.firstname_label.TabIndex = 5;
            this.firstname_label.Text = "First Name:";
            // 
            // lastname_label
            // 
            this.lastname_label.AutoSize = true;
            this.lastname_label.Location = new System.Drawing.Point(49, 149);
            this.lastname_label.Name = "lastname_label";
            this.lastname_label.Size = new System.Drawing.Size(61, 13);
            this.lastname_label.TabIndex = 6;
            this.lastname_label.Text = "Last Name:";
            // 
            // state_label
            // 
            this.state_label.AutoSize = true;
            this.state_label.Location = new System.Drawing.Point(52, 220);
            this.state_label.Name = "state_label";
            this.state_label.Size = new System.Drawing.Size(35, 13);
            this.state_label.TabIndex = 7;
            this.state_label.Text = "State:";
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(523, 288);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 4;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit_button.Location = new System.Drawing.Point(667, 387);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // lastinitial_box
            // 
            this.lastinitial_box.Location = new System.Drawing.Point(429, 392);
            this.lastinitial_box.Name = "lastinitial_box";
            this.lastinitial_box.Size = new System.Drawing.Size(133, 20);
            this.lastinitial_box.TabIndex = 11;
            this.lastinitial_box.TabStop = false;
            // 
            // lastinitial_label
            // 
            this.lastinitial_label.AutoSize = true;
            this.lastinitial_label.Location = new System.Drawing.Point(353, 392);
            this.lastinitial_label.Name = "lastinitial_label";
            this.lastinitial_label.Size = new System.Drawing.Size(57, 13);
            this.lastinitial_label.TabIndex = 12;
            this.lastinitial_label.Text = "Last Initial:";
            // 
            // firstinital_label
            // 
            this.firstinital_label.AutoSize = true;
            this.firstinital_label.Location = new System.Drawing.Point(52, 392);
            this.firstinital_label.Name = "firstinital_label";
            this.firstinital_label.Size = new System.Drawing.Size(56, 13);
            this.firstinital_label.TabIndex = 13;
            this.firstinital_label.Text = "First Initial:";
            // 
            // firstinitial_box
            // 
            this.firstinitial_box.Location = new System.Drawing.Point(128, 392);
            this.firstinitial_box.Name = "firstinitial_box";
            this.firstinitial_box.Size = new System.Drawing.Size(126, 20);
            this.firstinitial_box.TabIndex = 14;
            this.firstinitial_box.TabStop = false;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(262, 287);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 3;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // customer_listbox
            // 
            this.customer_listbox.FormattingEnabled = true;
            this.customer_listbox.Location = new System.Drawing.Point(464, 67);
            this.customer_listbox.Name = "customer_listbox";
            this.customer_listbox.Size = new System.Drawing.Size(248, 173);
            this.customer_listbox.Sorted = true;
            this.customer_listbox.TabIndex = 16;
            this.customer_listbox.TabStop = false;
            // 
            // Project7Form
            // 
            this.AcceptButton = this.save_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exit_button;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customer_listbox);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.firstinitial_box);
            this.Controls.Add(this.firstinital_label);
            this.Controls.Add(this.lastinitial_label);
            this.Controls.Add(this.lastinitial_box);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.state_label);
            this.Controls.Add(this.lastname_label);
            this.Controls.Add(this.firstname_label);
            this.Controls.Add(this.customers_label);
            this.Controls.Add(this.state_box);
            this.Controls.Add(this.lastname_box);
            this.Controls.Add(this.firstname_box);
            this.Name = "Project7Form";
            this.Text = "Spencer Hoff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstname_box;
        private System.Windows.Forms.TextBox lastname_box;
        private System.Windows.Forms.TextBox state_box;
        private System.Windows.Forms.Label customers_label;
        private System.Windows.Forms.Label firstname_label;
        private System.Windows.Forms.Label lastname_label;
        private System.Windows.Forms.Label state_label;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.TextBox lastinitial_box;
        private System.Windows.Forms.Label lastinitial_label;
        private System.Windows.Forms.Label firstinital_label;
        private System.Windows.Forms.TextBox firstinitial_box;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.ListBox customer_listbox;
    }
}

