namespace Demo
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			createButton = new Button();
			SuspendLayout();
			// 
			// createButton
			// 
			createButton.Location = new Point(126, 71);
			createButton.Name = "createButton";
			createButton.Size = new Size(115, 40);
			createButton.TabIndex = 0;
			createButton.Text = "Create";
			createButton.UseVisualStyleBackColor = true;
			createButton.Click += CreateButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(368, 193);
			Controls.Add(createButton);
			Name = "Form1";
			Text = "SwiftExcelHelper Demo";
			ResumeLayout(false);
		}

		#endregion

		private Button createButton;
	}
}
