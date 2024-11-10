
namespace hsr_relic_probability_calculator
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing )
		{
			if ( disposing && ( components != null ) )
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
		private void InitializeComponent ( )
		{
			relicSelector = new ComboBox();
			relicImage = new PictureBox();
			warningLabel = new Label();
			pieceTypeSelector = new ComboBox();
			mainStatSelector = new ComboBox();
			label2 = new Label();
			subStat1 = new ComboBox();
			subStat2 = new ComboBox();
			subStat3 = new ComboBox();
			subStat4 = new ComboBox();
			label3 = new Label();
			subStat1Dec = new Button();
			subStat1Rolls = new TextBox();
			subStat1Inc = new Button();
			subStat2Inc = new Button();
			subStat2Rolls = new TextBox();
			subStat2Dec = new Button();
			subStat3Inc = new Button();
			subStat3Rolls = new TextBox();
			subStat3Dec = new Button();
			subStat4Inc = new Button();
			subStat4Rolls = new TextBox();
			subStat4Dec = new Button();
			calcButton = new Button();
			calculationResults = new Label();
			label1 = new Label();
			label4 = new Label();
			( (System.ComponentModel.ISupportInitialize) relicImage ).BeginInit();
			SuspendLayout();
			// 
			// relicSelector
			// 
			relicSelector.FormattingEnabled = true;
			relicSelector.Location = new Point(40, 200);
			relicSelector.Name = "relicSelector";
			relicSelector.Size = new Size(300, 28);
			relicSelector.TabIndex = 0;
			relicSelector.SelectedIndexChanged +=  relicSelector_SelectedIndexChanged ;
			// 
			// relicImage
			// 
			relicImage.Location = new Point(40, 40);
			relicImage.Name = "relicImage";
			relicImage.Size = new Size(150, 150);
			relicImage.SizeMode = PictureBoxSizeMode.CenterImage;
			relicImage.TabIndex = 1;
			relicImage.TabStop = false;
			relicImage.Click +=  relicImage_Click ;
			// 
			// warningLabel
			// 
			warningLabel.AutoSize = true;
			warningLabel.Location = new Point(126, 467);
			warningLabel.Name = "warningLabel";
			warningLabel.Size = new Size(0, 20);
			warningLabel.TabIndex = 2;
			warningLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pieceTypeSelector
			// 
			pieceTypeSelector.FormattingEnabled = true;
			pieceTypeSelector.Location = new Point(210, 40);
			pieceTypeSelector.Name = "pieceTypeSelector";
			pieceTypeSelector.Size = new Size(130, 28);
			pieceTypeSelector.TabIndex = 3;
			pieceTypeSelector.SelectedIndexChanged +=  pieceTypeSelector_SelectedIndexChanged ;
			// 
			// mainStatSelector
			// 
			mainStatSelector.FormattingEnabled = true;
			mainStatSelector.Location = new Point(40, 255);
			mainStatSelector.Name = "mainStatSelector";
			mainStatSelector.Size = new Size(151, 28);
			mainStatSelector.TabIndex = 4;
			mainStatSelector.SelectedIndexChanged +=  mainStatSelector_SelectedIndexChanged ;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point,  0);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(40, 231);
			label2.Name = "label2";
			label2.Size = new Size(86, 25);
			label2.TabIndex = 5;
			label2.Text = "Main Stat";
			// 
			// subStat1
			// 
			subStat1.FormattingEnabled = true;
			subStat1.Location = new Point(40, 325);
			subStat1.Name = "subStat1";
			subStat1.Size = new Size(151, 28);
			subStat1.TabIndex = 6;
			subStat1.SelectedIndexChanged +=  subStat1_SelectedIndexChanged ;
			// 
			// subStat2
			// 
			subStat2.FormattingEnabled = true;
			subStat2.Location = new Point(40, 360);
			subStat2.Name = "subStat2";
			subStat2.Size = new Size(151, 28);
			subStat2.TabIndex = 7;
			subStat2.SelectedIndexChanged +=  subStat2_SelectedIndexChanged ;
			// 
			// subStat3
			// 
			subStat3.FormattingEnabled = true;
			subStat3.Location = new Point(40, 395);
			subStat3.Name = "subStat3";
			subStat3.Size = new Size(151, 28);
			subStat3.TabIndex = 8;
			subStat3.SelectedIndexChanged +=  subStat3_SelectedIndexChanged ;
			// 
			// subStat4
			// 
			subStat4.FormattingEnabled = true;
			subStat4.Location = new Point(40, 430);
			subStat4.Name = "subStat4";
			subStat4.Size = new Size(151, 28);
			subStat4.TabIndex = 9;
			subStat4.SelectedIndexChanged +=  subStat4_SelectedIndexChanged ;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(40, 305);
			label3.Name = "label3";
			label3.Size = new Size(64, 20);
			label3.TabIndex = 10;
			label3.Text = "Substats";
			// 
			// subStat1Dec
			// 
			subStat1Dec.Font = new Font("Segoe UI", 9F);
			subStat1Dec.Location = new Point(197, 323);
			subStat1Dec.Name = "subStat1Dec";
			subStat1Dec.Size = new Size(30, 30);
			subStat1Dec.TabIndex = 11;
			subStat1Dec.Text = "–";
			subStat1Dec.UseVisualStyleBackColor = true;
			subStat1Dec.Click +=  subStat1Dec_Click ;
			// 
			// subStat1Rolls
			// 
			subStat1Rolls.Location = new Point(233, 325);
			subStat1Rolls.Name = "subStat1Rolls";
			subStat1Rolls.Size = new Size(30, 27);
			subStat1Rolls.TabIndex = 12;
			subStat1Rolls.TextChanged +=  subStat1Rolls_TextChanged ;
			// 
			// subStat1Inc
			// 
			subStat1Inc.Font = new Font("Segoe UI", 9F);
			subStat1Inc.Location = new Point(269, 323);
			subStat1Inc.Name = "subStat1Inc";
			subStat1Inc.Size = new Size(30, 30);
			subStat1Inc.TabIndex = 13;
			subStat1Inc.Text = "+";
			subStat1Inc.UseVisualStyleBackColor = true;
			subStat1Inc.Click +=  subStat1Inc_Click ;
			// 
			// subStat2Inc
			// 
			subStat2Inc.Font = new Font("Segoe UI", 9F);
			subStat2Inc.Location = new Point(269, 359);
			subStat2Inc.Name = "subStat2Inc";
			subStat2Inc.Size = new Size(30, 30);
			subStat2Inc.TabIndex = 16;
			subStat2Inc.Text = "+";
			subStat2Inc.UseVisualStyleBackColor = true;
			subStat2Inc.Click +=  subStat2Inc_Click ;
			// 
			// subStat2Rolls
			// 
			subStat2Rolls.Location = new Point(233, 361);
			subStat2Rolls.Name = "subStat2Rolls";
			subStat2Rolls.Size = new Size(30, 27);
			subStat2Rolls.TabIndex = 15;
			subStat2Rolls.TextChanged +=  subStat2Rolls_TextChanged ;
			// 
			// subStat2Dec
			// 
			subStat2Dec.Font = new Font("Segoe UI", 9F);
			subStat2Dec.Location = new Point(197, 359);
			subStat2Dec.Name = "subStat2Dec";
			subStat2Dec.Size = new Size(30, 30);
			subStat2Dec.TabIndex = 14;
			subStat2Dec.Text = "–";
			subStat2Dec.UseVisualStyleBackColor = true;
			subStat2Dec.Click +=  subStat2Dec_Click ;
			// 
			// subStat3Inc
			// 
			subStat3Inc.Font = new Font("Segoe UI", 9F);
			subStat3Inc.Location = new Point(269, 394);
			subStat3Inc.Name = "subStat3Inc";
			subStat3Inc.Size = new Size(30, 30);
			subStat3Inc.TabIndex = 19;
			subStat3Inc.Text = "+";
			subStat3Inc.UseVisualStyleBackColor = true;
			subStat3Inc.Click +=  subStat3Inc_Click ;
			// 
			// subStat3Rolls
			// 
			subStat3Rolls.Location = new Point(233, 396);
			subStat3Rolls.Name = "subStat3Rolls";
			subStat3Rolls.Size = new Size(30, 27);
			subStat3Rolls.TabIndex = 18;
			subStat3Rolls.TextChanged +=  subStat3Rolls_TextChanged ;
			// 
			// subStat3Dec
			// 
			subStat3Dec.Font = new Font("Segoe UI", 9F);
			subStat3Dec.Location = new Point(197, 394);
			subStat3Dec.Name = "subStat3Dec";
			subStat3Dec.Size = new Size(30, 30);
			subStat3Dec.TabIndex = 17;
			subStat3Dec.Text = "–";
			subStat3Dec.UseVisualStyleBackColor = true;
			subStat3Dec.Click +=  subStat3Dec_Click ;
			// 
			// subStat4Inc
			// 
			subStat4Inc.Font = new Font("Segoe UI", 9F);
			subStat4Inc.Location = new Point(269, 428);
			subStat4Inc.Name = "subStat4Inc";
			subStat4Inc.Size = new Size(30, 30);
			subStat4Inc.TabIndex = 22;
			subStat4Inc.Text = "+";
			subStat4Inc.UseVisualStyleBackColor = true;
			subStat4Inc.Click +=  subStat4Inc_Click ;
			// 
			// subStat4Rolls
			// 
			subStat4Rolls.Location = new Point(233, 430);
			subStat4Rolls.Name = "subStat4Rolls";
			subStat4Rolls.Size = new Size(30, 27);
			subStat4Rolls.TabIndex = 21;
			subStat4Rolls.TextChanged +=  subStat4Rolls_TextChanged ;
			// 
			// subStat4Dec
			// 
			subStat4Dec.Font = new Font("Segoe UI", 9F);
			subStat4Dec.Location = new Point(197, 428);
			subStat4Dec.Name = "subStat4Dec";
			subStat4Dec.Size = new Size(30, 30);
			subStat4Dec.TabIndex = 20;
			subStat4Dec.Text = "–";
			subStat4Dec.UseVisualStyleBackColor = true;
			subStat4Dec.Click +=  subStat4Dec_Click ;
			// 
			// calcButton
			// 
			calcButton.Location = new Point(58, 490);
			calcButton.Name = "calcButton";
			calcButton.Size = new Size(220, 29);
			calcButton.TabIndex = 23;
			calcButton.Text = "Tell me how rare this is";
			calcButton.UseVisualStyleBackColor = true;
			calcButton.Click +=  calcButton_Click ;
			// 
			// calculationResults
			// 
			calculationResults.AutoSize = true;
			calculationResults.Location = new Point(420, 40);
			calculationResults.Name = "calculationResults";
			calculationResults.Size = new Size(136, 20);
			calculationResults.TabIndex = 24;
			calculationResults.Text = "Calculation Results:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(211, 20);
			label1.Name = "label1";
			label1.Size = new Size(44, 20);
			label1.TabIndex = 25;
			label1.Text = "Piece";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point,  0);
			label4.Location = new Point(40, 11);
			label4.Name = "label4";
			label4.Size = new Size(46, 31);
			label4.TabIndex = 26;
			label4.Text = "Set";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(795, 550);
			Controls.Add(label4);
			Controls.Add(label1);
			Controls.Add(calculationResults);
			Controls.Add(calcButton);
			Controls.Add(subStat4Inc);
			Controls.Add(subStat4Rolls);
			Controls.Add(subStat4Dec);
			Controls.Add(subStat3Inc);
			Controls.Add(subStat3Rolls);
			Controls.Add(subStat3Dec);
			Controls.Add(subStat2Inc);
			Controls.Add(subStat2Rolls);
			Controls.Add(subStat2Dec);
			Controls.Add(subStat1Inc);
			Controls.Add(subStat1Rolls);
			Controls.Add(subStat1Dec);
			Controls.Add(label3);
			Controls.Add(subStat4);
			Controls.Add(subStat3);
			Controls.Add(subStat2);
			Controls.Add(subStat1);
			Controls.Add(label2);
			Controls.Add(mainStatSelector);
			Controls.Add(pieceTypeSelector);
			Controls.Add(warningLabel);
			Controls.Add(relicImage);
			Controls.Add(relicSelector);
			Name = "Form1";
			Text = "Form1";
			Load +=  Form1_Load ;
			( (System.ComponentModel.ISupportInitialize) relicImage ).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox relicSelector;
		private PictureBox relicImage;
		private Label warningLabel;
		private ComboBox pieceTypeSelector;
		private ComboBox mainStatSelector;
		private Label label2;
		private ComboBox subStat1;
		private ComboBox subStat2;
		private ComboBox subStat3;
		private ComboBox subStat4;
		private Label label3;
		private Button subStat1Dec;
		private TextBox subStat1Rolls;
		private Button subStat1Inc;
		private Button subStat2Inc;
		private TextBox subStat2Rolls;
		private Button subStat2Dec;
		private Button subStat3Inc;
		private TextBox subStat3Rolls;
		private Button subStat3Dec;
		private Button subStat4Inc;
		private TextBox subStat4Rolls;
		private Button subStat4Dec;
		private Button calcButton;
		private Label calculationResults;
		private Label label1;
		private Label label4;
	}
}
