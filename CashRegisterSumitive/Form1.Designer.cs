namespace CashRegisterSumitive
{
    partial class cashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashForm));
            this.burgerNumber = new System.Windows.Forms.Label();
            this.friesLabel = new System.Windows.Forms.Label();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.textBoxBurger = new System.Windows.Forms.TextBox();
            this.textBoxfries = new System.Windows.Forms.TextBox();
            this.textBoxdrinks = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalLable = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // burgerNumber
            // 
            this.burgerNumber.Location = new System.Drawing.Point(13, 35);
            this.burgerNumber.Name = "burgerNumber";
            this.burgerNumber.Size = new System.Drawing.Size(105, 25);
            this.burgerNumber.TabIndex = 0;
            this.burgerNumber.Text = "Number of burgers ";
            // 
            // friesLabel
            // 
            this.friesLabel.Location = new System.Drawing.Point(13, 70);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(105, 25);
            this.friesLabel.TabIndex = 1;
            this.friesLabel.Text = "Number of fries";
            // 
            // drinksLabel
            // 
            this.drinksLabel.Location = new System.Drawing.Point(13, 100);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(105, 25);
            this.drinksLabel.TabIndex = 2;
            this.drinksLabel.Text = "Number of drinks";
            // 
            // textBoxBurger
            // 
            this.textBoxBurger.Location = new System.Drawing.Point(124, 35);
            this.textBoxBurger.Name = "textBoxBurger";
            this.textBoxBurger.Size = new System.Drawing.Size(100, 20);
            this.textBoxBurger.TabIndex = 1;
            this.textBoxBurger.Text = "0";
            // 
            // textBoxfries
            // 
            this.textBoxfries.Location = new System.Drawing.Point(124, 70);
            this.textBoxfries.Name = "textBoxfries";
            this.textBoxfries.Size = new System.Drawing.Size(100, 20);
            this.textBoxfries.TabIndex = 2;
            this.textBoxfries.Text = "0";
            // 
            // textBoxdrinks
            // 
            this.textBoxdrinks.Location = new System.Drawing.Point(124, 100);
            this.textBoxdrinks.Name = "textBoxdrinks";
            this.textBoxdrinks.Size = new System.Drawing.Size(100, 20);
            this.textBoxdrinks.TabIndex = 3;
            this.textBoxdrinks.Text = "0";
            // 
            // calculateButton
            // 
            this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Location = new System.Drawing.Point(124, 137);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // totalLable
            // 
            this.totalLable.BackColor = System.Drawing.Color.Red;
            this.totalLable.Location = new System.Drawing.Point(16, 175);
            this.totalLable.Name = "totalLable";
            this.totalLable.Size = new System.Drawing.Size(208, 67);
            this.totalLable.TabIndex = 7;
            // 
            // headerLabel
            // 
            this.headerLabel.BackColor = System.Drawing.Color.Red;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(-2, -2);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(484, 34);
            this.headerLabel.TabIndex = 8;
            this.headerLabel.Text = "Mc Burger ";
            // 
            // changeButton
            // 
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Location = new System.Drawing.Point(124, 271);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(100, 23);
            this.changeButton.TabIndex = 6;
            this.changeButton.Text = "Change ";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // textBoxChange
            // 
            this.textBoxChange.Location = new System.Drawing.Point(124, 245);
            this.textBoxChange.Name = "textBoxChange";
            this.textBoxChange.Size = new System.Drawing.Size(100, 20);
            this.textBoxChange.TabIndex = 5;
            // 
            // changeLabel
            // 
            this.changeLabel.Location = new System.Drawing.Point(124, 314);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(100, 23);
            this.changeLabel.TabIndex = 11;
            this.changeLabel.Click += new System.EventHandler(this.changeLabel_Click);
            // 
            // receiptButton
            // 
            this.receiptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptButton.Location = new System.Drawing.Point(127, 349);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(97, 23);
            this.receiptButton.TabIndex = 7;
            this.receiptButton.Text = "Print";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Visible = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // newButton
            // 
            this.newButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Location = new System.Drawing.Point(341, 349);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(97, 23);
            this.newButton.TabIndex = 8;
            this.newButton.Text = "New Order";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Visible = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // cashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(473, 383);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.textBoxChange);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.totalLable);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.textBoxdrinks);
            this.Controls.Add(this.textBoxfries);
            this.Controls.Add(this.textBoxBurger);
            this.Controls.Add(this.drinksLabel);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.burgerNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cashForm";
            this.Text = "Cash";
            this.Load += new System.EventHandler(this.cashForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label burgerNumber;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.TextBox textBoxBurger;
        private System.Windows.Forms.TextBox textBoxfries;
        private System.Windows.Forms.TextBox textBoxdrinks;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label totalLable;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox textBoxChange;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Button newButton;
    }
}

