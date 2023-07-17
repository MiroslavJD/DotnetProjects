namespace Login
{
    partial class Maid
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Cleaning = new System.Windows.Forms.ListBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Name: Ana, Telephone (08854030241)",
            "Name: Katia, Telephone (08854030241)",
            "Name: Sara, Telephone (08854030241)",
            "Name: Maria, Telephone (0886432341)",
            "Name: Teodora, Telephone (0888842359)",
            "Name: Roza, Telephone (0884241231)",
            "Name: Nicole, Telephone (0887444221)",
            "Name: Margarita, Telephone (088426211)",
            "Name: Ivana, Telephone (0887421231)",
            "Name: Iva, Telephone (0887542545)",
            "Name: Zara, Telephone (0887513211)",
            "Name: Minka, Telehpone (0885123425)"});
            this.listBox1.Location = new System.Drawing.Point(13, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 238);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maids";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select Maid";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SelecdMaid);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(619, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Close);
            // 
            // Cleaning
            // 
            this.Cleaning.FormattingEnabled = true;
            this.Cleaning.Location = new System.Drawing.Point(273, 11);
            this.Cleaning.Name = "Cleaning";
            this.Cleaning.Size = new System.Drawing.Size(430, 199);
            this.Cleaning.TabIndex = 5;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(333, 292);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 34);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.Text = "CheckMaid";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.Check);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(523, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 33);
            this.button4.TabIndex = 8;
            this.button4.Text = "Check Rooms";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Clean);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(233, 293);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(85, 33);
            this.button.TabIndex = 10;
            this.button.Text = "Maid Location";
            this.button.UseVisualStyleBackColor = true;
            this.button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MaidMove);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 34);
            this.button2.TabIndex = 11;
            this.button2.Text = "Show Cleaning";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ShowCleaning);
            // 
            // Maid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 333);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.Cleaning);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Maid";
            this.Text = "Maid";
            this.Load += new System.EventHandler(this.Maid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox Cleaning;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button2;
    }
}