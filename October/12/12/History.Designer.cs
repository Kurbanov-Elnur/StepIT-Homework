namespace _12
{
    partial class History
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
            Expressions = new ListBox();
            SuspendLayout();
            // 
            // Expressions
            // 
            Expressions.Dock = DockStyle.Fill;
            Expressions.FormattingEnabled = true;
            Expressions.ItemHeight = 20;
            Expressions.Location = new Point(0, 0);
            Expressions.Name = "Expressions";
            Expressions.Size = new Size(370, 450);
            Expressions.TabIndex = 0;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 450);
            Controls.Add(Expressions);
            Name = "History";
            Text = "History";
            ResumeLayout(false);
        }

        private ListBox Expressions;
    }
}