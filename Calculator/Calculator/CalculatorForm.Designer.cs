namespace Calculator
{
    partial class CalculatorForm
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
            InputTable = new TableLayoutPanel();
            divideButton = new Button();
            calculateButton = new Button();
            changeSignButton = new Button();
            multiplyButton = new Button();
            minusButton = new Button();
            zeroButton = new Button();
            oneButton = new Button();
            twoButton = new Button();
            threeButton = new Button();
            sixButton = new Button();
            fiveButton = new Button();
            fourButton = new Button();
            nineButton = new Button();
            eightButton = new Button();
            sevenButton = new Button();
            plusButton = new Button();
            ClearButton = new Button();
            result = new TextBox();
            InputTable.SuspendLayout();
            SuspendLayout();
            // 
            // InputTable
            // 
            InputTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InputTable.BackColor = Color.FromArgb(32, 32, 32);
            InputTable.ColumnCount = 4;
            InputTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            InputTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            InputTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            InputTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            InputTable.Controls.Add(divideButton, 3, 3);
            InputTable.Controls.Add(calculateButton, 2, 3);
            InputTable.Controls.Add(changeSignButton, 1, 3);
            InputTable.Controls.Add(multiplyButton, 3, 2);
            InputTable.Controls.Add(minusButton, 3, 1);
            InputTable.Controls.Add(zeroButton, 0, 3);
            InputTable.Controls.Add(oneButton, 0, 2);
            InputTable.Controls.Add(twoButton, 0, 2);
            InputTable.Controls.Add(threeButton, 1, 2);
            InputTable.Controls.Add(sixButton, 1, 1);
            InputTable.Controls.Add(fiveButton, 1, 1);
            InputTable.Controls.Add(fourButton, 0, 1);
            InputTable.Controls.Add(nineButton, 2, 0);
            InputTable.Controls.Add(eightButton, 1, 0);
            InputTable.Controls.Add(sevenButton, 0, 0);
            InputTable.Controls.Add(plusButton, 3, 0);
            InputTable.Location = new Point(14, 338);
            InputTable.Margin = new Padding(4);
            InputTable.Name = "InputTable";
            InputTable.RowCount = 4;
            InputTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            InputTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            InputTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            InputTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            InputTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            InputTable.Size = new Size(477, 288);
            InputTable.TabIndex = 2;
            // 
            // divideButton
            // 
            divideButton.BackColor = Color.FromArgb(255, 149, 0);
            divideButton.Dock = DockStyle.Fill;
            divideButton.FlatAppearance.BorderSize = 0;
            divideButton.FlatStyle = FlatStyle.Flat;
            divideButton.Font = new Font("Gadugi", 22F, FontStyle.Bold);
            divideButton.ForeColor = Color.White;
            divideButton.Location = new Point(361, 220);
            divideButton.Margin = new Padding(4);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(112, 64);
            divideButton.TabIndex = 13;
            divideButton.Text = "/";
            divideButton.UseVisualStyleBackColor = false;
            divideButton.Click += OnOperationButtonClick;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.FromArgb(255, 149, 0);
            calculateButton.Dock = DockStyle.Fill;
            calculateButton.FlatAppearance.BorderSize = 0;
            calculateButton.FlatStyle = FlatStyle.Flat;
            calculateButton.Font = new Font("Gadugi", 22F, FontStyle.Bold);
            calculateButton.ForeColor = Color.White;
            calculateButton.Location = new Point(242, 220);
            calculateButton.Margin = new Padding(4);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(111, 64);
            calculateButton.TabIndex = 14;
            calculateButton.Text = "=";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += OnCalculateButtonClick;
            // 
            // changeSignButton
            // 
            changeSignButton.BackColor = Color.FromArgb(212, 212, 210);
            changeSignButton.Dock = DockStyle.Fill;
            changeSignButton.FlatAppearance.BorderSize = 0;
            changeSignButton.FlatStyle = FlatStyle.Flat;
            changeSignButton.Font = new Font("Gadugi", 22F, FontStyle.Bold);
            changeSignButton.ForeColor = Color.FromArgb(28, 28, 28);
            changeSignButton.ImageAlign = ContentAlignment.BottomCenter;
            changeSignButton.Location = new Point(123, 220);
            changeSignButton.Margin = new Padding(4);
            changeSignButton.Name = "changeSignButton";
            changeSignButton.Size = new Size(111, 64);
            changeSignButton.TabIndex = 0;
            changeSignButton.Text = "+/-";
            changeSignButton.UseVisualStyleBackColor = false;
            changeSignButton.Click += OnOperationButtonClick;
            // 
            // multiplyButton
            // 
            multiplyButton.BackColor = Color.FromArgb(255, 149, 0);
            multiplyButton.Dock = DockStyle.Fill;
            multiplyButton.FlatAppearance.BorderSize = 0;
            multiplyButton.FlatStyle = FlatStyle.Flat;
            multiplyButton.Font = new Font("Gadugi", 22F, FontStyle.Bold);
            multiplyButton.ForeColor = Color.White;
            multiplyButton.Location = new Point(361, 148);
            multiplyButton.Margin = new Padding(4);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(112, 64);
            multiplyButton.TabIndex = 12;
            multiplyButton.Text = "*";
            multiplyButton.UseVisualStyleBackColor = false;
            multiplyButton.Click += OnOperationButtonClick;
            // 
            // minusButton
            // 
            minusButton.BackColor = Color.FromArgb(255, 149, 0);
            minusButton.Dock = DockStyle.Fill;
            minusButton.FlatAppearance.BorderSize = 0;
            minusButton.FlatStyle = FlatStyle.Flat;
            minusButton.Font = new Font("Gadugi", 22F, FontStyle.Bold);
            minusButton.ForeColor = Color.White;
            minusButton.Location = new Point(361, 76);
            minusButton.Margin = new Padding(4);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(112, 64);
            minusButton.TabIndex = 11;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = false;
            minusButton.Click += OnOperationButtonClick;
            // 
            // zeroButton
            // 
            zeroButton.BackColor = Color.FromArgb(80, 80, 80);
            zeroButton.Dock = DockStyle.Fill;
            zeroButton.FlatAppearance.BorderSize = 0;
            zeroButton.FlatStyle = FlatStyle.Flat;
            zeroButton.Font = new Font("Gadugi", 22F, FontStyle.Bold);
            zeroButton.ForeColor = Color.White;
            zeroButton.Location = new Point(4, 220);
            zeroButton.Margin = new Padding(4);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(111, 64);
            zeroButton.TabIndex = 1;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = false;
            zeroButton.Click += OnDigitButtonClick;
            // 
            // oneButton
            // 
            oneButton.BackColor = Color.FromArgb(80, 80, 80);
            oneButton.Dock = DockStyle.Fill;
            oneButton.FlatAppearance.BorderSize = 0;
            oneButton.FlatStyle = FlatStyle.Flat;
            oneButton.Font = new Font("Gadugi", 22F, FontStyle.Bold);
            oneButton.ForeColor = Color.White;
            oneButton.Location = new Point(4, 148);
            oneButton.Margin = new Padding(4);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(111, 64);
            oneButton.TabIndex = 2;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = false;
            oneButton.Click += OnDigitButtonClick;
            // 
            // twoButton
            // 
            twoButton.BackColor = Color.FromArgb(80, 80, 80);
            twoButton.Dock = DockStyle.Fill;
            twoButton.FlatAppearance.BorderSize = 0;
            twoButton.FlatStyle = FlatStyle.Flat;
            twoButton.Font = new Font("Gadugi", 22F, FontStyle.Bold);
            twoButton.ForeColor = Color.White;
            twoButton.Location = new Point(123, 148);
            twoButton.Margin = new Padding(4);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(111, 64);
            twoButton.TabIndex = 2;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = false;
            twoButton.Click += OnDigitButtonClick;
            // 
            // threeButton
            // 
            threeButton.BackColor = Color.FromArgb(80, 80, 80);
            threeButton.Dock = DockStyle.Fill;
            threeButton.FlatAppearance.BorderSize = 0;
            threeButton.FlatStyle = FlatStyle.Flat;
            threeButton.Font = new Font("Gadugi", 22F, FontStyle.Bold);
            threeButton.ForeColor = Color.White;
            threeButton.Location = new Point(242, 148);
            threeButton.Margin = new Padding(4);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(111, 64);
            threeButton.TabIndex = 3;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = false;
            threeButton.Click += OnDigitButtonClick;
            // 
            // sixButton
            // 
            sixButton.BackColor = Color.FromArgb(80, 80, 80);
            sixButton.Dock = DockStyle.Fill;
            sixButton.FlatAppearance.BorderSize = 0;
            sixButton.FlatStyle = FlatStyle.Flat;
            sixButton.Font = new Font("Gadugi", 22F, FontStyle.Bold);
            sixButton.ForeColor = Color.White;
            sixButton.Location = new Point(242, 76);
            sixButton.Margin = new Padding(4);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(111, 64);
            sixButton.TabIndex = 6;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = false;
            sixButton.Click += OnDigitButtonClick;
            // 
            // fiveButton
            // 
            fiveButton.BackColor = Color.FromArgb(80, 80, 80);
            fiveButton.Dock = DockStyle.Fill;
            fiveButton.FlatAppearance.BorderSize = 0;
            fiveButton.FlatStyle = FlatStyle.Flat;
            fiveButton.Font = new Font("Gadugi", 22F, FontStyle.Bold);
            fiveButton.ForeColor = Color.White;
            fiveButton.Location = new Point(123, 76);
            fiveButton.Margin = new Padding(4);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(111, 64);
            fiveButton.TabIndex = 5;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = false;
            fiveButton.Click += OnDigitButtonClick;
            // 
            // fourButton
            // 
            fourButton.BackColor = Color.FromArgb(80, 80, 80);
            fourButton.Dock = DockStyle.Fill;
            fourButton.FlatAppearance.BorderSize = 0;
            fourButton.FlatStyle = FlatStyle.Flat;
            fourButton.Font = new Font("Gadugi", 22F, FontStyle.Bold);
            fourButton.ForeColor = Color.White;
            fourButton.Location = new Point(4, 76);
            fourButton.Margin = new Padding(4);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(111, 64);
            fourButton.TabIndex = 4;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = false;
            fourButton.Click += OnDigitButtonClick;
            // 
            // nineButton
            // 
            nineButton.BackColor = Color.FromArgb(80, 80, 80);
            nineButton.Dock = DockStyle.Fill;
            nineButton.FlatAppearance.BorderSize = 0;
            nineButton.FlatStyle = FlatStyle.Flat;
            nineButton.Font = new Font("Gadugi", 22F, FontStyle.Bold);
            nineButton.ForeColor = Color.White;
            nineButton.Location = new Point(242, 4);
            nineButton.Margin = new Padding(4);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(111, 64);
            nineButton.TabIndex = 9;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = false;
            nineButton.Click += OnDigitButtonClick;
            // 
            // eightButton
            // 
            eightButton.BackColor = Color.FromArgb(80, 80, 80);
            eightButton.Dock = DockStyle.Fill;
            eightButton.FlatAppearance.BorderSize = 0;
            eightButton.FlatStyle = FlatStyle.Flat;
            eightButton.Font = new Font("Gadugi", 22F, FontStyle.Bold);
            eightButton.ForeColor = Color.White;
            eightButton.Location = new Point(123, 4);
            eightButton.Margin = new Padding(4);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(111, 64);
            eightButton.TabIndex = 8;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = false;
            eightButton.Click += OnDigitButtonClick;
            // 
            // sevenButton
            // 
            sevenButton.BackColor = Color.FromArgb(80, 80, 80);
            sevenButton.Dock = DockStyle.Fill;
            sevenButton.FlatAppearance.BorderSize = 0;
            sevenButton.FlatStyle = FlatStyle.Flat;
            sevenButton.Font = new Font("Gadugi", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sevenButton.ForeColor = Color.White;
            sevenButton.Location = new Point(4, 4);
            sevenButton.Margin = new Padding(4);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(111, 64);
            sevenButton.TabIndex = 7;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = false;
            sevenButton.Click += OnDigitButtonClick;
            // 
            // plusButton
            // 
            plusButton.BackColor = Color.FromArgb(255, 149, 0);
            plusButton.Dock = DockStyle.Fill;
            plusButton.FlatAppearance.BorderSize = 0;
            plusButton.FlatStyle = FlatStyle.Flat;
            plusButton.Font = new Font("Gadugi", 22F, FontStyle.Bold);
            plusButton.ForeColor = Color.White;
            plusButton.Location = new Point(361, 4);
            plusButton.Margin = new Padding(4);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(112, 64);
            plusButton.TabIndex = 10;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = false;
            plusButton.Click += OnOperationButtonClick;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.FromArgb(212, 212, 210);
            ClearButton.FlatAppearance.BorderSize = 0;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Font = new Font("Calibri", 24F, FontStyle.Bold);
            ClearButton.ForeColor = Color.FromArgb(28, 28, 28);
            ClearButton.Location = new Point(18, 266);
            ClearButton.Margin = new Padding(4);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(113, 68);
            ClearButton.TabIndex = 15;
            ClearButton.Text = "C";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += OnClearButtonClick;
            // 
            // result
            // 
            result.BackColor = Color.FromArgb(28, 28, 28);
            result.BorderStyle = BorderStyle.None;
            result.Font = new Font("Gadugi", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            result.ForeColor = Color.White;
            result.Location = new Point(18, 140);
            result.Name = "result";
            result.Size = new Size(469, 80);
            result.TabIndex = 16;
            result.TextAlign = HorizontalAlignment.Right;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(506, 640);
            Controls.Add(result);
            Controls.Add(ClearButton);
            Controls.Add(InputTable);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MinimumSize = new Size(528, 696);
            Name = "CalculatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            InputTable.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox chain;
        private TableLayoutPanel InputTable;
        private Button sevenButton;
        private Button nineButton;
        private Button eightButton;
        private Button zeroButton;
        private Button oneButton;
        private Button twoButton;
        private Button threeButton;
        private Button sixButton;
        private Button fiveButton;
        private Button fourButton;
        private Button plusButton;
        private Button divideButton;
        private Button calculateButton;
        private Button multiplyButton;
        private Button minusButton;
        private Button ClearButton;
        private TextBox result;
        private Button changeSignButton;
    }
}
