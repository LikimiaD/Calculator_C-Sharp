
namespace Calculator_WinForm
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
            this.Percent = new System.Windows.Forms.Button();
            this.CurrentClear = new System.Windows.Forms.Button();
            this.GlobalClear = new System.Windows.Forms.Button();
            this.RemoveSymbol = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Root = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Negate = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Percent
            // 
            this.Percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Percent.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Percent.ForeColor = System.Drawing.SystemColors.Control;
            this.Percent.Location = new System.Drawing.Point(8, 143);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(84, 56);
            this.Percent.TabIndex = 1;
            this.Percent.Text = "%";
            this.Percent.UseVisualStyleBackColor = false;
            this.Percent.Click += new System.EventHandler(this.Add_Click);
            // 
            // CurrentClear
            // 
            this.CurrentClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.CurrentClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.CurrentClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentClear.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentClear.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrentClear.Location = new System.Drawing.Point(92, 143);
            this.CurrentClear.Name = "CurrentClear";
            this.CurrentClear.Size = new System.Drawing.Size(84, 56);
            this.CurrentClear.TabIndex = 2;
            this.CurrentClear.Text = "CE";
            this.CurrentClear.UseVisualStyleBackColor = false;
            this.CurrentClear.Click += new System.EventHandler(this.CurrentClear_Click);
            // 
            // GlobalClear
            // 
            this.GlobalClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.GlobalClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.GlobalClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GlobalClear.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GlobalClear.ForeColor = System.Drawing.SystemColors.Control;
            this.GlobalClear.Location = new System.Drawing.Point(176, 143);
            this.GlobalClear.Name = "GlobalClear";
            this.GlobalClear.Size = new System.Drawing.Size(84, 56);
            this.GlobalClear.TabIndex = 3;
            this.GlobalClear.Text = "C";
            this.GlobalClear.UseVisualStyleBackColor = false;
            this.GlobalClear.Click += new System.EventHandler(this.GlobalClear_Click);
            // 
            // RemoveSymbol
            // 
            this.RemoveSymbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.RemoveSymbol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.RemoveSymbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSymbol.Font = new System.Drawing.Font("Segoe UI Symbol", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveSymbol.ForeColor = System.Drawing.SystemColors.Control;
            this.RemoveSymbol.Location = new System.Drawing.Point(260, 143);
            this.RemoveSymbol.Name = "RemoveSymbol";
            this.RemoveSymbol.Size = new System.Drawing.Size(84, 56);
            this.RemoveSymbol.TabIndex = 4;
            this.RemoveSymbol.Text = "⎚";
            this.RemoveSymbol.UseVisualStyleBackColor = false;
            this.RemoveSymbol.Click += new System.EventHandler(this.RemoveSymbol_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(8, 199);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 56);
            this.button5.TabIndex = 5;
            this.button5.Text = "⅟x";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Square
            // 
            this.Square.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Square.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Square.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Square.ForeColor = System.Drawing.SystemColors.Control;
            this.Square.Location = new System.Drawing.Point(92, 199);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(84, 56);
            this.Square.TabIndex = 6;
            this.Square.Text = "x²";
            this.Square.UseVisualStyleBackColor = false;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Root
            // 
            this.Root.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Root.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Root.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Root.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Root.ForeColor = System.Drawing.SystemColors.Control;
            this.Root.Location = new System.Drawing.Point(176, 199);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(84, 56);
            this.Root.TabIndex = 7;
            this.Root.Text = "√x";
            this.Root.UseVisualStyleBackColor = false;
            this.Root.Click += new System.EventHandler(this.Root_Click);
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Division.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Division.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Division.ForeColor = System.Drawing.SystemColors.Control;
            this.Division.Location = new System.Drawing.Point(260, 199);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(84, 56);
            this.Division.TabIndex = 8;
            this.Division.Text = "÷";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.Add_Click);
            // 
            // Num7
            // 
            this.Num7.BackColor = System.Drawing.Color.Black;
            this.Num7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num7.ForeColor = System.Drawing.SystemColors.Control;
            this.Num7.Location = new System.Drawing.Point(8, 255);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(84, 56);
            this.Num7.TabIndex = 9;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = false;
            this.Num7.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Num8
            // 
            this.Num8.BackColor = System.Drawing.Color.Black;
            this.Num8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num8.ForeColor = System.Drawing.SystemColors.Control;
            this.Num8.Location = new System.Drawing.Point(92, 255);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(84, 56);
            this.Num8.TabIndex = 10;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = false;
            this.Num8.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Num9
            // 
            this.Num9.BackColor = System.Drawing.Color.Black;
            this.Num9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num9.ForeColor = System.Drawing.SystemColors.Control;
            this.Num9.Location = new System.Drawing.Point(176, 255);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(84, 56);
            this.Num9.TabIndex = 11;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = false;
            this.Num9.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Multiply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multiply.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Multiply.ForeColor = System.Drawing.SystemColors.Control;
            this.Multiply.Location = new System.Drawing.Point(260, 255);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(84, 56);
            this.Multiply.TabIndex = 12;
            this.Multiply.Text = "✕";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.Click += new System.EventHandler(this.Add_Click);
            // 
            // Num4
            // 
            this.Num4.BackColor = System.Drawing.Color.Black;
            this.Num4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num4.ForeColor = System.Drawing.SystemColors.Control;
            this.Num4.Location = new System.Drawing.Point(8, 311);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(84, 56);
            this.Num4.TabIndex = 13;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = false;
            this.Num4.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Num5
            // 
            this.Num5.BackColor = System.Drawing.Color.Black;
            this.Num5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num5.ForeColor = System.Drawing.SystemColors.Control;
            this.Num5.Location = new System.Drawing.Point(92, 311);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(84, 56);
            this.Num5.TabIndex = 14;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = false;
            this.Num5.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Num6
            // 
            this.Num6.BackColor = System.Drawing.Color.Black;
            this.Num6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num6.ForeColor = System.Drawing.SystemColors.Control;
            this.Num6.Location = new System.Drawing.Point(176, 311);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(84, 56);
            this.Num6.TabIndex = 15;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = false;
            this.Num6.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Subtraction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subtraction.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Subtraction.ForeColor = System.Drawing.SystemColors.Control;
            this.Subtraction.Location = new System.Drawing.Point(260, 311);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(84, 56);
            this.Subtraction.TabIndex = 16;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = false;
            this.Subtraction.Click += new System.EventHandler(this.Add_Click);
            // 
            // Num1
            // 
            this.Num1.BackColor = System.Drawing.Color.Black;
            this.Num1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num1.ForeColor = System.Drawing.SystemColors.Control;
            this.Num1.Location = new System.Drawing.Point(8, 367);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(84, 56);
            this.Num1.TabIndex = 17;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = false;
            this.Num1.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Num2
            // 
            this.Num2.BackColor = System.Drawing.Color.Black;
            this.Num2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num2.ForeColor = System.Drawing.SystemColors.Control;
            this.Num2.Location = new System.Drawing.Point(92, 367);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(84, 56);
            this.Num2.TabIndex = 18;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = false;
            this.Num2.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Num3
            // 
            this.Num3.BackColor = System.Drawing.Color.Black;
            this.Num3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num3.ForeColor = System.Drawing.SystemColors.Control;
            this.Num3.Location = new System.Drawing.Point(176, 367);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(84, 56);
            this.Num3.TabIndex = 19;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = false;
            this.Num3.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add.ForeColor = System.Drawing.SystemColors.Control;
            this.Add.Location = new System.Drawing.Point(260, 367);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(84, 56);
            this.Add.TabIndex = 20;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Negate
            // 
            this.Negate.BackColor = System.Drawing.Color.Black;
            this.Negate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Negate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Negate.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Negate.ForeColor = System.Drawing.SystemColors.Control;
            this.Negate.Location = new System.Drawing.Point(8, 423);
            this.Negate.Name = "Negate";
            this.Negate.Size = new System.Drawing.Size(84, 56);
            this.Negate.TabIndex = 21;
            this.Negate.Text = "⁺/-";
            this.Negate.UseVisualStyleBackColor = false;
            this.Negate.Click += new System.EventHandler(this.Negate_Click);
            // 
            // Num0
            // 
            this.Num0.BackColor = System.Drawing.Color.Black;
            this.Num0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num0.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num0.ForeColor = System.Drawing.SystemColors.Control;
            this.Num0.Location = new System.Drawing.Point(92, 423);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(84, 56);
            this.Num0.TabIndex = 22;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = false;
            this.Num0.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Dot
            // 
            this.Dot.BackColor = System.Drawing.Color.Black;
            this.Dot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dot.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dot.ForeColor = System.Drawing.SystemColors.Control;
            this.Dot.Location = new System.Drawing.Point(176, 423);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(84, 56);
            this.Dot.TabIndex = 23;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = false;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Equals
            // 
            this.Equals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.Equals.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Equals.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Equals.ForeColor = System.Drawing.SystemColors.Control;
            this.Equals.Location = new System.Drawing.Point(260, 423);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(84, 56);
            this.Equals.TabIndex = 24;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = false;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // button33
            // 
            this.button33.FlatAppearance.BorderSize = 0;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button33.ForeColor = System.Drawing.SystemColors.Control;
            this.button33.Location = new System.Drawing.Point(1, 1);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(48, 47);
            this.button33.TabIndex = 26;
            this.button33.Text = "≡";
            this.button33.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(3, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 83);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(350, 487);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Num0);
            this.Controls.Add(this.Negate);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Num9);
            this.Controls.Add(this.Num8);
            this.Controls.Add(this.Num7);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Root);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.RemoveSymbol);
            this.Controls.Add(this.GlobalClear);
            this.Controls.Add(this.CurrentClear);
            this.Controls.Add(this.Percent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LikimiaD Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Percent;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button CurrentClear;
        private System.Windows.Forms.Button GlobalClear;
        private System.Windows.Forms.Button RemoveSymbol;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Root;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Num7;
        private System.Windows.Forms.Button Num8;
        private System.Windows.Forms.Button Num9;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Num4;
        private System.Windows.Forms.Button Num5;
        private System.Windows.Forms.Button Num6;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Num1;
        private System.Windows.Forms.Button Num2;
        private System.Windows.Forms.Button Num3;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Negate;
        private System.Windows.Forms.Button Num0;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Button button33;
    }
}

