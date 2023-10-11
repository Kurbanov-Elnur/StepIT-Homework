namespace _12
{
    partial class Calculator
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            Main = new Panel();
            SumPanel = new Panel();
            ResultBox = new TextBox();
            CalculatorPanel = new TableLayoutPanel();
            Number4 = new Button();
            Number1 = new Button();
            Number5 = new Button();
            Number2 = new Button();
            Number8 = new Button();
            Number9 = new Button();
            Number6 = new Button();
            Number0 = new Button();
            Minus = new Button();
            Point = new Button();
            Number3 = new Button();
            Multiplication = new Button();
            Subtraction = new Button();
            Addition = new Button();
            Backspace = new Button();
            C = new Button();
            Equally = new Button();
            Number7 = new Button();
            Mugivara = new PictureBox();
            Division = new Button();
            Main.SuspendLayout();
            SumPanel.SuspendLayout();
            CalculatorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Mugivara).BeginInit();
            SuspendLayout();
            // 
            // Main
            // 
            Main.BackColor = Color.White;
            Main.Controls.Add(SumPanel);
            Main.Controls.Add(CalculatorPanel);
            Main.Dock = DockStyle.Fill;
            Main.Location = new Point(0, 0);
            Main.Name = "Main";
            Main.Size = new Size(559, 572);
            Main.TabIndex = 0;
            // 
            // SumPanel
            // 
            SumPanel.BackColor = SystemColors.ActiveCaption;
            SumPanel.Controls.Add(ResultBox);
            SumPanel.Dock = DockStyle.Fill;
            SumPanel.Location = new Point(0, 0);
            SumPanel.Name = "SumPanel";
            SumPanel.Size = new Size(559, 118);
            SumPanel.TabIndex = 2;
            // 
            // ResultBox
            // 
            ResultBox.BackColor = Color.White;
            ResultBox.BorderStyle = BorderStyle.None;
            ResultBox.Dock = DockStyle.Fill;
            ResultBox.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            ResultBox.Location = new Point(0, 0);
            ResultBox.Multiline = true;
            ResultBox.Name = "ResultBox";
            ResultBox.ReadOnly = true;
            ResultBox.Size = new Size(559, 118);
            ResultBox.TabIndex = 0;
            ResultBox.TextAlign = HorizontalAlignment.Right;
            // 
            // CalculatorPanel
            // 
            CalculatorPanel.BackColor = Color.White;
            CalculatorPanel.ColumnCount = 4;
            CalculatorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.6377945F));
            CalculatorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.3622055F));
            CalculatorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 143F));
            CalculatorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            CalculatorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            CalculatorPanel.Controls.Add(Number4, 0, 2);
            CalculatorPanel.Controls.Add(Number1, 0, 3);
            CalculatorPanel.Controls.Add(Number5, 1, 2);
            CalculatorPanel.Controls.Add(Number2, 1, 3);
            CalculatorPanel.Controls.Add(Number8, 1, 1);
            CalculatorPanel.Controls.Add(Number9, 2, 1);
            CalculatorPanel.Controls.Add(Number6, 2, 2);
            CalculatorPanel.Controls.Add(Number0, 1, 4);
            CalculatorPanel.Controls.Add(Minus, 0, 4);
            CalculatorPanel.Controls.Add(Point, 2, 4);
            CalculatorPanel.Controls.Add(Number3, 2, 3);
            CalculatorPanel.Controls.Add(Multiplication, 3, 1);
            CalculatorPanel.Controls.Add(Subtraction, 3, 2);
            CalculatorPanel.Controls.Add(Addition, 3, 3);
            CalculatorPanel.Controls.Add(Backspace, 3, 0);
            CalculatorPanel.Controls.Add(C, 2, 0);
            CalculatorPanel.Controls.Add(Equally, 3, 4);
            CalculatorPanel.Controls.Add(Number7, 0, 1);
            CalculatorPanel.Controls.Add(Mugivara, 1, 0);
            CalculatorPanel.Controls.Add(Division, 0, 0);
            CalculatorPanel.Dock = DockStyle.Bottom;
            CalculatorPanel.Location = new Point(0, 118);
            CalculatorPanel.Name = "CalculatorPanel";
            CalculatorPanel.RowCount = 5;
            CalculatorPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 52.12766F));
            CalculatorPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 47.87234F));
            CalculatorPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            CalculatorPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 89F));
            CalculatorPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            CalculatorPanel.Size = new Size(559, 454);
            CalculatorPanel.TabIndex = 0;
            // 
            // Number4
            // 
            Number4.BackColor = Color.White;
            Number4.Dock = DockStyle.Fill;
            Number4.Location = new Point(3, 191);
            Number4.Name = "Number4";
            Number4.Size = new Size(132, 91);
            Number4.TabIndex = 3;
            Number4.Text = "4";
            Number4.UseVisualStyleBackColor = false;
            Number4.Click += Number4_Click;
            // 
            // Number1
            // 
            Number1.BackColor = Color.White;
            Number1.Dock = DockStyle.Fill;
            Number1.Location = new Point(3, 288);
            Number1.Name = "Number1";
            Number1.Size = new Size(132, 83);
            Number1.TabIndex = 4;
            Number1.Text = "1";
            Number1.UseVisualStyleBackColor = false;
            Number1.Click += Number1_Click;
            // 
            // Number5
            // 
            Number5.BackColor = Color.White;
            Number5.Dock = DockStyle.Fill;
            Number5.Location = new Point(141, 191);
            Number5.Name = "Number5";
            Number5.Size = new Size(146, 91);
            Number5.TabIndex = 5;
            Number5.Text = "5";
            Number5.UseMnemonic = false;
            Number5.UseVisualStyleBackColor = false;
            Number5.UseWaitCursor = true;
            Number5.Click += Number5_Click;
            // 
            // Number2
            // 
            Number2.BackColor = Color.White;
            Number2.Dock = DockStyle.Fill;
            Number2.Location = new Point(141, 288);
            Number2.Name = "Number2";
            Number2.Size = new Size(146, 83);
            Number2.TabIndex = 6;
            Number2.Text = "2";
            Number2.UseVisualStyleBackColor = false;
            Number2.Click += Number2_Click;
            // 
            // Number8
            // 
            Number8.BackColor = Color.White;
            Number8.Dock = DockStyle.Fill;
            Number8.Location = new Point(141, 101);
            Number8.Name = "Number8";
            Number8.Size = new Size(146, 84);
            Number8.TabIndex = 7;
            Number8.Text = "8";
            Number8.UseVisualStyleBackColor = false;
            Number8.Click += Number8_Click;
            // 
            // Number9
            // 
            Number9.BackColor = Color.White;
            Number9.Dock = DockStyle.Fill;
            Number9.Location = new Point(293, 101);
            Number9.Name = "Number9";
            Number9.Size = new Size(137, 84);
            Number9.TabIndex = 8;
            Number9.Text = "9";
            Number9.UseVisualStyleBackColor = false;
            Number9.Click += Number9_Click;
            // 
            // Number6
            // 
            Number6.BackColor = Color.White;
            Number6.Dock = DockStyle.Fill;
            Number6.Location = new Point(293, 191);
            Number6.Name = "Number6";
            Number6.Size = new Size(137, 91);
            Number6.TabIndex = 9;
            Number6.Text = "6";
            Number6.UseVisualStyleBackColor = false;
            Number6.Click += Number6_Click;
            // 
            // Number0
            // 
            Number0.BackColor = Color.White;
            Number0.Dock = DockStyle.Fill;
            Number0.Location = new Point(141, 377);
            Number0.Name = "Number0";
            Number0.Size = new Size(146, 74);
            Number0.TabIndex = 11;
            Number0.Text = "0";
            Number0.UseVisualStyleBackColor = false;
            Number0.Click += Number0_Click;
            // 
            // Minus
            // 
            Minus.BackColor = Color.White;
            Minus.Dock = DockStyle.Fill;
            Minus.Location = new Point(3, 377);
            Minus.Name = "Minus";
            Minus.Size = new Size(132, 74);
            Minus.TabIndex = 10;
            Minus.Text = "+/-";
            Minus.UseVisualStyleBackColor = false;
            Minus.Click += Minus_Click;
            // 
            // Point
            // 
            Point.BackColor = Color.White;
            Point.Dock = DockStyle.Fill;
            Point.Location = new Point(293, 377);
            Point.Name = "Point";
            Point.Size = new Size(137, 74);
            Point.TabIndex = 12;
            Point.Text = ".";
            Point.UseVisualStyleBackColor = false;
            Point.Click += Point_Click;
            // 
            // Number3
            // 
            Number3.BackColor = Color.White;
            Number3.Dock = DockStyle.Fill;
            Number3.Location = new Point(293, 288);
            Number3.Name = "Number3";
            Number3.Size = new Size(137, 83);
            Number3.TabIndex = 13;
            Number3.Text = "3";
            Number3.UseVisualStyleBackColor = false;
            Number3.Click += Number3_Click;
            // 
            // Multiplication
            // 
            Multiplication.BackColor = Color.White;
            Multiplication.Dock = DockStyle.Fill;
            Multiplication.Location = new Point(436, 101);
            Multiplication.Name = "Multiplication";
            Multiplication.Size = new Size(120, 84);
            Multiplication.TabIndex = 14;
            Multiplication.Text = "*";
            Multiplication.UseVisualStyleBackColor = false;
            Multiplication.Click += Multiplication_Click;
            // 
            // Subtraction
            // 
            Subtraction.BackColor = Color.White;
            Subtraction.Dock = DockStyle.Fill;
            Subtraction.Location = new Point(436, 191);
            Subtraction.Name = "Subtraction";
            Subtraction.Size = new Size(120, 91);
            Subtraction.TabIndex = 15;
            Subtraction.Text = "-";
            Subtraction.UseVisualStyleBackColor = false;
            Subtraction.Click += Subtraction_Click;
            // 
            // Addition
            // 
            Addition.BackColor = Color.White;
            Addition.Dock = DockStyle.Fill;
            Addition.Location = new Point(436, 288);
            Addition.Name = "Addition";
            Addition.Size = new Size(120, 83);
            Addition.TabIndex = 16;
            Addition.Text = "+";
            Addition.UseVisualStyleBackColor = false;
            Addition.Click += Addition_Click;
            // 
            // Backspace
            // 
            Backspace.BackColor = Color.White;
            Backspace.Dock = DockStyle.Fill;
            Backspace.Location = new Point(436, 3);
            Backspace.Name = "Backspace";
            Backspace.Size = new Size(120, 92);
            Backspace.TabIndex = 20;
            Backspace.Text = "Backspace";
            Backspace.UseVisualStyleBackColor = false;
            Backspace.Click += Backspace_Click;
            // 
            // C
            // 
            C.BackColor = Color.White;
            C.Dock = DockStyle.Fill;
            C.Location = new Point(293, 3);
            C.Name = "C";
            C.Size = new Size(137, 92);
            C.TabIndex = 18;
            C.Text = "C";
            C.UseVisualStyleBackColor = false;
            C.Click += C_Click;
            // 
            // Equally
            // 
            Equally.BackColor = Color.White;
            Equally.Dock = DockStyle.Fill;
            Equally.Location = new Point(436, 377);
            Equally.Name = "Equally";
            Equally.Size = new Size(120, 74);
            Equally.TabIndex = 22;
            Equally.Text = "=";
            Equally.UseVisualStyleBackColor = false;
            Equally.Click += Equally_Click;
            // 
            // Number7
            // 
            Number7.BackColor = Color.White;
            Number7.Dock = DockStyle.Fill;
            Number7.Location = new Point(3, 101);
            Number7.Name = "Number7";
            Number7.Size = new Size(132, 84);
            Number7.TabIndex = 2;
            Number7.Text = "7";
            Number7.UseVisualStyleBackColor = false;
            Number7.Click += Number7_Click;
            // 
            // Mugivara
            // 
            Mugivara.Dock = DockStyle.Fill;
            Mugivara.ErrorImage = (Image)resources.GetObject("Mugivara.ErrorImage");
            Mugivara.Image = (Image)resources.GetObject("Mugivara.Image");
            Mugivara.InitialImage = null;
            Mugivara.Location = new Point(141, 3);
            Mugivara.Name = "Mugivara";
            Mugivara.Size = new Size(146, 92);
            Mugivara.SizeMode = PictureBoxSizeMode.StretchImage;
            Mugivara.TabIndex = 23;
            Mugivara.TabStop = false;
            Mugivara.Click += Mugivara_Click;
            // 
            // Division
            // 
            Division.BackColor = Color.White;
            Division.Dock = DockStyle.Fill;
            Division.Location = new Point(3, 3);
            Division.Name = "Division";
            Division.Size = new Size(132, 92);
            Division.TabIndex = 24;
            Division.Text = "/";
            Division.UseVisualStyleBackColor = false;
            Division.Click += Division_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(559, 572);
            Controls.Add(Main);
            Name = "Calculator";
            Text = "Calculator";
            Main.ResumeLayout(false);
            SumPanel.ResumeLayout(false);
            SumPanel.PerformLayout();
            CalculatorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Mugivara).EndInit();
            ResumeLayout(false);
        }

        private Panel Main;
        private TableLayoutPanel CalculatorPanel;
        private Button Number7;
        private Button Number4;
        private Button Number1;
        private Button Number5;
        private Button Number2;
        private Button Backspace;
        private Button C;
        private Button Number8;
        private Button Number9;
        private Button Number6;
        private Button Number0;
        private Button Minus;
        private Button Point;
        private Button Number3;
        private Button Multiplication;
        private Button Subtraction;
        private Button Addition;
        private Panel SumPanel;
        private Button Equally;
        private TextBox ResultBox;
        private PictureBox Mugivara;
        private Button Division;
    }
}