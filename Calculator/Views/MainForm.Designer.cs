using Calculator.UserControls.CalcButtons;

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
            btnZero = new CalcButton();
            btnOne = new CalcButton();
            btnTwo = new CalcButton();
            btnThree = new CalcButton();
            btnFour = new CalcButton();
            btnFive = new CalcButton();
            btnSix = new CalcButton();
            btnSeven = new CalcButton();
            btnEight = new CalcButton();
            btnNine = new CalcButton();
            btnDividedby = new CalcButton();
            btnTimes = new CalcButton();
            btnMinus = new CalcButton();
            btnPlus = new CalcButton();
            btnEquals = new CalcButton();
            btnDecimalPoint = new CalcButton();
            panel1 = new Panel();
            btnClearEntry = new CalcButton();
            btnClearAll = new CalcButton();
            lblFormula = new Label();
            viewModelBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtResult.Font = new Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.Location = new Point(3, 31);
            txtResult.Margin = new Padding(3, 4, 3, 4);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(247, 31);
            txtResult.TabIndex = 0;
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnZero
            // 
            btnZero.ButtonText = ButtonTextEnum.Zero;
            btnZero.FlatStyle = FlatStyle.Flat;
            btnZero.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnZero.Location = new Point(65, 172);
            btnZero.Margin = new Padding(1);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(60, 40);
            btnZero.TabIndex = 1;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            // 
            // btnOne
            // 
            btnOne.ButtonText = ButtonTextEnum.One;
            btnOne.FlatStyle = FlatStyle.Flat;
            btnOne.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOne.Location = new Point(3, 130);
            btnOne.Margin = new Padding(1);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(60, 40);
            btnOne.TabIndex = 2;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            // 
            // btnTwo
            // 
            btnTwo.ButtonText = ButtonTextEnum.Two;
            btnTwo.FlatStyle = FlatStyle.Flat;
            btnTwo.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTwo.Location = new Point(65, 130);
            btnTwo.Margin = new Padding(1);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(60, 40);
            btnTwo.TabIndex = 3;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnThree
            // 
            btnThree.ButtonText = ButtonTextEnum.Three;
            btnThree.FlatStyle = FlatStyle.Flat;
            btnThree.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnThree.Location = new Point(127, 130);
            btnThree.Margin = new Padding(1);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(60, 40);
            btnThree.TabIndex = 4;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            // 
            // btnFour
            // 
            btnFour.ButtonText = ButtonTextEnum.Four;
            btnFour.FlatStyle = FlatStyle.Flat;
            btnFour.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFour.Location = new Point(3, 88);
            btnFour.Margin = new Padding(1);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(60, 40);
            btnFour.TabIndex = 5;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            // 
            // btnFive
            // 
            btnFive.ButtonText = ButtonTextEnum.Five;
            btnFive.FlatStyle = FlatStyle.Flat;
            btnFive.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFive.Location = new Point(65, 88);
            btnFive.Margin = new Padding(1);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(60, 40);
            btnFive.TabIndex = 6;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            // 
            // btnSix
            // 
            btnSix.ButtonText = ButtonTextEnum.Six;
            btnSix.FlatStyle = FlatStyle.Flat;
            btnSix.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSix.Location = new Point(127, 88);
            btnSix.Margin = new Padding(1);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(60, 40);
            btnSix.TabIndex = 7;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            // 
            // btnSeven
            // 
            btnSeven.ButtonText = ButtonTextEnum.Seven;
            btnSeven.FlatStyle = FlatStyle.Flat;
            btnSeven.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeven.Location = new Point(3, 46);
            btnSeven.Margin = new Padding(1);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(60, 40);
            btnSeven.TabIndex = 8;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            // 
            // btnEight
            // 
            btnEight.ButtonText = ButtonTextEnum.Eight;
            btnEight.FlatStyle = FlatStyle.Flat;
            btnEight.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEight.Location = new Point(65, 46);
            btnEight.Margin = new Padding(1);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(60, 40);
            btnEight.TabIndex = 9;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            // 
            // btnNine
            // 
            btnNine.ButtonText = ButtonTextEnum.Nine;
            btnNine.FlatStyle = FlatStyle.Flat;
            btnNine.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNine.Location = new Point(127, 46);
            btnNine.Margin = new Padding(1);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(60, 40);
            btnNine.TabIndex = 10;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            // 
            // btnDividedby
            // 
            btnDividedby.ButtonText = ButtonTextEnum.DividedBy;
            btnDividedby.FlatStyle = FlatStyle.Flat;
            btnDividedby.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDividedby.Location = new Point(189, 4);
            btnDividedby.Margin = new Padding(1);
            btnDividedby.Name = "btnDividedby";
            btnDividedby.Size = new Size(60, 40);
            btnDividedby.TabIndex = 11;
            btnDividedby.Text = "÷";
            btnDividedby.UseVisualStyleBackColor = true;
            // 
            // btnTimes
            // 
            btnTimes.ButtonText = ButtonTextEnum.Times;
            btnTimes.FlatStyle = FlatStyle.Flat;
            btnTimes.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimes.Location = new Point(189, 46);
            btnTimes.Margin = new Padding(1);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(60, 40);
            btnTimes.TabIndex = 12;
            btnTimes.Text = "×";
            btnTimes.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            btnMinus.ButtonText = ButtonTextEnum.Minus;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinus.Location = new Point(189, 88);
            btnMinus.Margin = new Padding(1);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(60, 40);
            btnMinus.TabIndex = 13;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            btnPlus.ButtonText = ButtonTextEnum.Plus;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlus.Location = new Point(189, 130);
            btnPlus.Margin = new Padding(1);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(60, 40);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "＋";
            btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnEquals
            // 
            btnEquals.ButtonText = ButtonTextEnum.Equals;
            btnEquals.FlatStyle = FlatStyle.Flat;
            btnEquals.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEquals.Location = new Point(189, 172);
            btnEquals.Margin = new Padding(1);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(60, 40);
            btnEquals.TabIndex = 15;
            btnEquals.Text = "＝";
            btnEquals.UseVisualStyleBackColor = true;
            // 
            // btnDecimalPoint
            // 
            btnDecimalPoint.ButtonText = ButtonTextEnum.DecimalPoint;
            btnDecimalPoint.FlatStyle = FlatStyle.Flat;
            btnDecimalPoint.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDecimalPoint.Location = new Point(127, 172);
            btnDecimalPoint.Margin = new Padding(1);
            btnDecimalPoint.Name = "btnDecimalPoint";
            btnDecimalPoint.Size = new Size(60, 40);
            btnDecimalPoint.TabIndex = 16;
            btnDecimalPoint.Text = ".";
            btnDecimalPoint.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClearEntry);
            panel1.Controls.Add(btnClearAll);
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
            panel1.Location = new Point(0, 64);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 215);
            panel1.TabIndex = 17;
            // 
            // btnClearEntry
            // 
            btnClearEntry.ButtonText = ButtonTextEnum.ClearEntry;
            btnClearEntry.FlatStyle = FlatStyle.Flat;
            btnClearEntry.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearEntry.Location = new Point(65, 4);
            btnClearEntry.Margin = new Padding(1);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(60, 40);
            btnClearEntry.TabIndex = 20;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            btnClearAll.ButtonText = ButtonTextEnum.ClearAll;
            btnClearAll.FlatStyle = FlatStyle.Flat;
            btnClearAll.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearAll.Location = new Point(127, 4);
            btnClearAll.Margin = new Padding(1);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(60, 40);
            btnClearAll.TabIndex = 19;
            btnClearAll.Text = "C";
            btnClearAll.UseVisualStyleBackColor = true;
            // 
            // lblFormula
            // 
            lblFormula.Location = new Point(3, 9);
            lblFormula.Name = "lblFormula";
            lblFormula.Size = new Size(249, 18);
            lblFormula.TabIndex = 18;
            lblFormula.Text = "label1";
            lblFormula.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 279);
            Controls.Add(lblFormula);
            Controls.Add(panel1);
            Controls.Add(txtResult);
            Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "電卓";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private CalcButton btnZero;
        private CalcButton btnOne;
        private CalcButton btnTwo;
        private CalcButton btnThree;
        private CalcButton btnFour;
        private CalcButton btnFive;
        private CalcButton btnSix;
        private CalcButton btnSeven;
        private CalcButton btnEight;
        private CalcButton btnNine;
        private CalcButton btnDividedby;
        private CalcButton btnTimes;
        private CalcButton btnMinus;
        private CalcButton btnPlus;
        private CalcButton btnEquals;
        private CalcButton btnDecimalPoint;
        private Panel panel1;
        private Label lblFormula;
        private BindingSource viewModelBindingSource;
        private CalcButton btnClearEntry;
        private CalcButton btnClearAll;
    }
}
