namespace afleveringsopgave2
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
            this.textNavnBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddName = new System.Windows.Forms.Button();
            this.textArrayPosition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deletePosition = new System.Windows.Forms.Button();
            this.textDisplayNavne = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sortAscending = new System.Windows.Forms.Button();
            this.sortDescending = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNavnBox
            // 
            this.textNavnBox.Location = new System.Drawing.Point(109, 93);
            this.textNavnBox.Name = "textNavnBox";
            this.textNavnBox.Size = new System.Drawing.Size(255, 22);
            this.textNavnBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Navn:";
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(109, 131);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(112, 28);
            this.AddName.TabIndex = 2;
            this.AddName.Text = "Tilføj navn";
            this.AddName.UseVisualStyleBackColor = true;
            this.AddName.Click += new System.EventHandler(this.AddName_Click);
            // 
            // textArrayPosition
            // 
            this.textArrayPosition.Location = new System.Drawing.Point(109, 197);
            this.textArrayPosition.Name = "textArrayPosition";
            this.textArrayPosition.Size = new System.Drawing.Size(112, 22);
            this.textArrayPosition.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Position:";
            // 
            // deletePosition
            // 
            this.deletePosition.Location = new System.Drawing.Point(109, 235);
            this.deletePosition.Name = "deletePosition";
            this.deletePosition.Size = new System.Drawing.Size(112, 28);
            this.deletePosition.TabIndex = 5;
            this.deletePosition.Text = "Slet position";
            this.deletePosition.UseVisualStyleBackColor = true;
            this.deletePosition.Click += new System.EventHandler(this.DeletePosition_Click);
            // 
            // textDisplayNavne
            // 
            this.textDisplayNavne.BackColor = System.Drawing.SystemColors.Window;
            this.textDisplayNavne.Location = new System.Drawing.Point(418, 93);
            this.textDisplayNavne.Multiline = true;
            this.textDisplayNavne.Name = "textDisplayNavne";
            this.textDisplayNavne.Size = new System.Drawing.Size(204, 395);
            this.textDisplayNavne.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Navne:";
            // 
            // sortAscending
            // 
            this.sortAscending.Location = new System.Drawing.Point(644, 245);
            this.sortAscending.Name = "sortAscending";
            this.sortAscending.Size = new System.Drawing.Size(144, 36);
            this.sortAscending.TabIndex = 8;
            this.sortAscending.Text = "Sortér stigende";
            this.sortAscending.UseVisualStyleBackColor = true;
            this.sortAscending.Click += new System.EventHandler(this.SortAscending_Click);
            // 
            // sortDescending
            // 
            this.sortDescending.Location = new System.Drawing.Point(644, 307);
            this.sortDescending.Name = "sortDescending";
            this.sortDescending.Size = new System.Drawing.Size(144, 36);
            this.sortDescending.TabIndex = 9;
            this.sortDescending.Text = "Sortér faldende";
            this.sortDescending.UseVisualStyleBackColor = true;
            this.sortDescending.Click += new System.EventHandler(this.SortDescending_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 584);
            this.Controls.Add(this.sortDescending);
            this.Controls.Add(this.sortAscending);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDisplayNavne);
            this.Controls.Add(this.deletePosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textArrayPosition);
            this.Controls.Add(this.AddName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNavnBox);
            this.Name = "Form1";
            this.Text = "Arrays and Exception handling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNavnBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddName;
        private System.Windows.Forms.TextBox textArrayPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deletePosition;
        private System.Windows.Forms.TextBox textDisplayNavne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sortAscending;
        private System.Windows.Forms.Button sortDescending;
    }
}

