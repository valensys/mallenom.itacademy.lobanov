namespace MyPractice.Linq
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
			if(disposing && (components != null))
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
			this.CollectionCapacity = new System.Windows.Forms.NumericUpDown();
			this.CreateCollection = new System.Windows.Forms.Button();
			this.ExtractFromCollection = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.CollectionCapacity)).BeginInit();
			this.SuspendLayout();
			// 
			// CollectionCapacity
			// 
			this.CollectionCapacity.Location = new System.Drawing.Point(29, 122);
			this.CollectionCapacity.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.CollectionCapacity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.CollectionCapacity.Name = "CollectionCapacity";
			this.CollectionCapacity.Size = new System.Drawing.Size(148, 20);
			this.CollectionCapacity.TabIndex = 1;
			this.CollectionCapacity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.CollectionCapacity.ValueChanged += new System.EventHandler(this.CollectionCapacity_ValueChanged);
			// 
			// CreateCollection
			// 
			this.CreateCollection.Location = new System.Drawing.Point(236, 122);
			this.CreateCollection.Name = "CreateCollection";
			this.CreateCollection.Size = new System.Drawing.Size(75, 23);
			this.CreateCollection.TabIndex = 2;
			this.CreateCollection.Text = "Создать";
			this.CreateCollection.UseVisualStyleBackColor = true;
			this.CreateCollection.Click += new System.EventHandler(this.CreateCollectionClick);
			// 
			// ExtractFromCollection
			// 
			this.ExtractFromCollection.Location = new System.Drawing.Point(402, 122);
			this.ExtractFromCollection.Name = "ExtractFromCollection";
			this.ExtractFromCollection.Size = new System.Drawing.Size(75, 23);
			this.ExtractFromCollection.TabIndex = 3;
			this.ExtractFromCollection.Text = "Извлечь";
			this.ExtractFromCollection.UseVisualStyleBackColor = true;
			this.ExtractFromCollection.Click += new System.EventHandler(this.ExtractFromCollectionClick);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(191, 187);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 108);
			this.listBox1.TabIndex = 4;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(357, 187);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(120, 108);
			this.listBox2.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(26, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Размерность коллекции";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(561, 395);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.ExtractFromCollection);
			this.Controls.Add(this.CreateCollection);
			this.Controls.Add(this.CollectionCapacity);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.CollectionCapacity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown CollectionCapacity;
		private System.Windows.Forms.Button CreateCollection;
		private System.Windows.Forms.Button ExtractFromCollection;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label1;
	}
}

