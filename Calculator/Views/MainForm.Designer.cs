namespace Calculator.Views
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
            components = new System.ComponentModel.Container();
            txtResult = new TextBox();
            btnZero = new UserControls.CalcButton();
            btnOne = new UserControls.CalcButton();
            btnTwo = new UserControls.CalcButton();
            btnThree = new UserControls.CalcButton();
            btnFour = new UserControls.CalcButton();
            btnFive = new UserControls.CalcButton();
            btnSix = new UserControls.CalcButton();
            btnSeven = new UserControls.CalcButton();
            btnEight = new UserControls.CalcButton();
            btnNine = new UserControls.CalcButton();
            btnDividedby = new UserControls.CalcButton();
            btnTimes = new UserControls.CalcButton();
            btnMinus = new UserControls.CalcButton();
            btnPlus = new UserControls.CalcButton();
            btnEquals = new UserControls.CalcButton();
            btnDecimalPoint = new UserControls.CalcButton();
            panel1 = new Panel();
            lblFormula = new Label();
            viewModelBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtResult.Font = new Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.Location = new Point(3, 33);
            txtResult.Margin = new Padding(3, 4, 3, 4);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(258, 31);
            txtResult.TabIndex = 0;
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnZero
            // 
            btnZero.ButtonText = UserControls.CalcButton.ButtonTextEnum.Zero;
            btnZero.FlatStyle = FlatStyle.Flat;
            btnZero.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnZero.Location = new Point(69, 141);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(60, 40);
            btnZero.TabIndex = 1;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            // 
            // btnOne
            // 
            btnOne.ButtonText = UserControls.CalcButton.ButtonTextEnum.One;
            btnOne.FlatStyle = FlatStyle.Flat;
            btnOne.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOne.Location = new Point(3, 95);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(60, 40);
            btnOne.TabIndex = 2;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            // 
            // btnTwo
            // 
            btnTwo.ButtonText = UserControls.CalcButton.ButtonTextEnum.Two;
            btnTwo.FlatStyle = FlatStyle.Flat;
            btnTwo.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTwo.Location = new Point(69, 95);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(60, 40);
            btnTwo.TabIndex = 3;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            // 
            // btnThree
            // 
            btnThree.ButtonText = UserControls.CalcButton.ButtonTextEnum.Three;
            btnThree.FlatStyle = FlatStyle.Flat;
            btnThree.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnThree.Location = new Point(135, 95);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(60, 40);
            btnThree.TabIndex = 4;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            // 
            // btnFour
            // 
            btnFour.ButtonText = UserControls.CalcButton.ButtonTextEnum.Four;
            btnFour.FlatStyle = FlatStyle.Flat;
            btnFour.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFour.Location = new Point(3, 49);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(60, 40);
            btnFour.TabIndex = 5;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            // 
            // btnFive
            // 
            btnFive.ButtonText = UserControls.CalcButton.ButtonTextEnum.Five;
            btnFive.FlatStyle = FlatStyle.Flat;
            btnFive.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFive.Location = new Point(69, 49);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(60, 40);
            btnFive.TabIndex = 6;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            // 
            // btnSix
            // 
            btnSix.ButtonText = UserControls.CalcButton.ButtonTextEnum.Six;
            btnSix.FlatStyle = FlatStyle.Flat;
            btnSix.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSix.Location = new Point(135, 49);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(60, 40);
            btnSix.TabIndex = 7;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            // 
            // btnSeven
            // 
            btnSeven.ButtonText = UserControls.CalcButton.ButtonTextEnum.Seven;
            btnSeven.FlatStyle = FlatStyle.Flat;
            btnSeven.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeven.Location = new Point(3, 3);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(60, 40);
            btnSeven.TabIndex = 8;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            // 
            // btnEight
            // 
            btnEight.ButtonText = UserControls.CalcButton.ButtonTextEnum.Eight;
            btnEight.FlatStyle = FlatStyle.Flat;
            btnEight.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEight.Location = new Point(69, 3);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(60, 40);
            btnEight.TabIndex = 9;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            // 
            // btnNine
            // 
            btnNine.ButtonText = UserControls.CalcButton.ButtonTextEnum.Nine;
            btnNine.FlatStyle = FlatStyle.Flat;
            btnNine.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNine.Location = new Point(135, 3);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(60, 40);
            btnNine.TabIndex = 10;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            // 
            // btnDividedby
            // 
            btnDividedby.ButtonText = UserControls.CalcButton.ButtonTextEnum.DividedBy;
            btnDividedby.FlatStyle = FlatStyle.Flat;
            btnDividedby.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDividedby.Location = new Point(201, 3);
            btnDividedby.Name = "btnDividedby";
            btnDividedby.Size = new Size(60, 40);
            btnDividedby.TabIndex = 11;
            btnDividedby.Text = "÷";
            btnDividedby.UseVisualStyleBackColor = true;
            // 
            // btnTimes
            // 
            btnTimes.ButtonText = UserControls.CalcButton.ButtonTextEnum.Times;
            btnTimes.FlatStyle = FlatStyle.Flat;
            btnTimes.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimes.Location = new Point(201, 49);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(60, 40);
            btnTimes.TabIndex = 12;
            btnTimes.Text = "×";
            btnTimes.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            btnMinus.ButtonText = UserControls.CalcButton.ButtonTextEnum.Minus;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinus.Location = new Point(201, 95);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(60, 40);
            btnMinus.TabIndex = 13;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            btnPlus.ButtonText = UserControls.CalcButton.ButtonTextEnum.Plus;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlus.Location = new Point(201, 141);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(60, 40);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "＋";
            btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnEquals
            // 
            btnEquals.ButtonText = UserControls.CalcButton.ButtonTextEnum.Equals;
            btnEquals.FlatStyle = FlatStyle.Flat;
            btnEquals.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEquals.Location = new Point(135, 141);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(60, 40);
            btnEquals.TabIndex = 15;
            btnEquals.Text = "＝";
            btnEquals.UseVisualStyleBackColor = true;
            // 
            // btnDecimalPoint
            // 
            btnDecimalPoint.ButtonText = UserControls.CalcButton.ButtonTextEnum.DecimalPoint;
            btnDecimalPoint.FlatStyle = FlatStyle.Flat;
            btnDecimalPoint.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDecimalPoint.Location = new Point(3, 141);
            btnDecimalPoint.Name = "btnDecimalPoint";
            btnDecimalPoint.Size = new Size(60, 40);
            btnDecimalPoint.TabIndex = 16;
            btnDecimalPoint.Text = ".";
            btnDecimalPoint.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSeven);
            panel1.Controls.Add(btnDecimalPoint);
            panel1.Controls.Add(btnZero);
            panel1.Controls.Add(btnEquals);
            panel1.Controls.Add(btnOne);
            panel1.Controls.Add(btnPlus);
            panel1.Controls.Add(btnTwo);
            panel1.Controls.Add(btnMinus);
            panel1.Controls.Add(btnThree);
            panel1.Controls.Add(btnTimes);
            panel1.Controls.Add(btnFour);
            panel1.Controls.Add(btnDividedby);
            panel1.Controls.Add(btnFive);
            panel1.Controls.Add(btnNine);
            panel1.Controls.Add(btnSix);
            panel1.Controls.Add(btnEight);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 80);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 185);
            panel1.TabIndex = 17;
            // 
            // lblFormula
            // 
            lblFormula.AutoSize = true;
            lblFormula.Location = new Point(210, 9);
            lblFormula.Name = "lblFormula";
            lblFormula.Size = new Size(42, 18);
            lblFormula.TabIndex = 18;
            lblFormula.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 265);
            Controls.Add(lblFormula);
            Controls.Add(panel1);
            Controls.Add(txtResult);
            Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private UserControls.CalcButton btnZero;
        private UserControls.CalcButton btnOne;
        private UserControls.CalcButton btnTwo;
        private UserControls.CalcButton btnThree;
        private UserControls.CalcButton btnFour;
        private UserControls.CalcButton btnFive;
        private UserControls.CalcButton btnSix;
        private UserControls.CalcButton btnSeven;
        private UserControls.CalcButton btnEight;
        private UserControls.CalcButton btnNine;
        private UserControls.CalcButton btnDividedby;
        private UserControls.CalcButton btnTimes;
        private UserControls.CalcButton btnMinus;
        private UserControls.CalcButton btnPlus;
        private UserControls.CalcButton btnEquals;
        private UserControls.CalcButton btnDecimalPoint;
        private Panel panel1;
        private Label lblFormula;
        private BindingSource viewModelBindingSource;
    }
}
