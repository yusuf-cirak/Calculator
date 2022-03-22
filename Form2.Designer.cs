namespace Calculator
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bOpPlusMinus = new System.Windows.Forms.Button();
            this.bNumber0 = new System.Windows.Forms.Button();
            this.bPoint = new System.Windows.Forms.Button();
            this.bEquals = new System.Windows.Forms.Button();
            this.bOpPlus = new System.Windows.Forms.Button();
            this.bNumber3 = new System.Windows.Forms.Button();
            this.bNumber2 = new System.Windows.Forms.Button();
            this.bNumber1 = new System.Windows.Forms.Button();
            this.bOpMinus = new System.Windows.Forms.Button();
            this.bNumber6 = new System.Windows.Forms.Button();
            this.bNumber5 = new System.Windows.Forms.Button();
            this.bNumber4 = new System.Windows.Forms.Button();
            this.bOpMultiplication = new System.Windows.Forms.Button();
            this.bNumber9 = new System.Windows.Forms.Button();
            this.bNumber8 = new System.Windows.Forms.Button();
            this.bNumber7 = new System.Windows.Forms.Button();
            this.bOpDivide = new System.Windows.Forms.Button();
            this.bOpSquareRoot = new System.Windows.Forms.Button();
            this.bOpExponent = new System.Windows.Forms.Button();
            this.bOpBackspace = new System.Windows.Forms.Button();
            this.bOpClear = new System.Windows.Forms.Button();
            this.bOpOff = new System.Windows.Forms.Button();
            this.bOpPercent = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.bOpDivideX = new System.Windows.Forms.Button();
            this.bOpMemoryClear = new System.Windows.Forms.Button();
            this.bOpMemoryRead = new System.Windows.Forms.Button();
            this.bOpMemoryMinus = new System.Windows.Forms.Button();
            this.bOpMemoryPlus = new System.Windows.Forms.Button();
            this.bOpMemoryList = new System.Windows.Forms.Button();
            this.bOpMemorySave = new System.Windows.Forms.Button();
            this.lblOp = new System.Windows.Forms.Label();
            this.listBoxMemory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bOpPlusMinus
            // 
            this.bOpPlusMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.bOpPlusMinus.FlatAppearance.BorderSize = 0;
            this.bOpPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bOpPlusMinus.Location = new System.Drawing.Point(1, 438);
            this.bOpPlusMinus.Name = "bOpPlusMinus";
            this.bOpPlusMinus.Size = new System.Drawing.Size(77, 52);
            this.bOpPlusMinus.TabIndex = 0;
            this.bOpPlusMinus.Text = "±";
            this.bOpPlusMinus.UseVisualStyleBackColor = false;
            this.bOpPlusMinus.Click += new System.EventHandler(this.SingleNumber_Operations);
            this.bOpPlusMinus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bNumber0
            // 
            this.bNumber0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.bNumber0.FlatAppearance.BorderSize = 0;
            this.bNumber0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNumber0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bNumber0.Location = new System.Drawing.Point(84, 438);
            this.bNumber0.Name = "bNumber0";
            this.bNumber0.Size = new System.Drawing.Size(77, 52);
            this.bNumber0.TabIndex = 2;
            this.bNumber0.Text = "0";
            this.bNumber0.UseVisualStyleBackColor = false;
            this.bNumber0.Click += new System.EventHandler(this.Numeric_Values);
            this.bNumber0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bPoint
            // 
            this.bPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.bPoint.FlatAppearance.BorderSize = 0;
            this.bPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bPoint.Location = new System.Drawing.Point(167, 438);
            this.bPoint.Name = "bPoint";
            this.bPoint.Size = new System.Drawing.Size(77, 52);
            this.bPoint.TabIndex = 3;
            this.bPoint.Text = ",";
            this.bPoint.UseVisualStyleBackColor = false;
            this.bPoint.Click += new System.EventHandler(this.Numeric_Values);
            this.bPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bEquals
            // 
            this.bEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(174)))), ((int)(((byte)(197)))));
            this.bEquals.FlatAppearance.BorderSize = 0;
            this.bEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bEquals.Location = new System.Drawing.Point(250, 438);
            this.bEquals.Name = "bEquals";
            this.bEquals.Size = new System.Drawing.Size(77, 52);
            this.bEquals.TabIndex = 4;
            this.bEquals.Text = "=";
            this.bEquals.UseVisualStyleBackColor = false;
            this.bEquals.Click += new System.EventHandler(this.OpEquals_Click);
            this.bEquals.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bOpPlus
            // 
            this.bOpPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(216)))));
            this.bOpPlus.FlatAppearance.BorderSize = 0;
            this.bOpPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bOpPlus.Location = new System.Drawing.Point(250, 380);
            this.bOpPlus.Name = "bOpPlus";
            this.bOpPlus.Size = new System.Drawing.Size(77, 52);
            this.bOpPlus.TabIndex = 8;
            this.bOpPlus.Text = "+";
            this.bOpPlus.UseVisualStyleBackColor = false;
            this.bOpPlus.Click += new System.EventHandler(this.Operational_Function);
            this.bOpPlus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bNumber3
            // 
            this.bNumber3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.bNumber3.FlatAppearance.BorderSize = 0;
            this.bNumber3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bNumber3.Location = new System.Drawing.Point(167, 380);
            this.bNumber3.Name = "bNumber3";
            this.bNumber3.Size = new System.Drawing.Size(77, 52);
            this.bNumber3.TabIndex = 7;
            this.bNumber3.Text = "3";
            this.bNumber3.UseVisualStyleBackColor = false;
            this.bNumber3.Click += new System.EventHandler(this.Numeric_Values);
            this.bNumber3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bNumber2
            // 
            this.bNumber2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.bNumber2.FlatAppearance.BorderSize = 0;
            this.bNumber2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bNumber2.Location = new System.Drawing.Point(84, 380);
            this.bNumber2.Name = "bNumber2";
            this.bNumber2.Size = new System.Drawing.Size(77, 52);
            this.bNumber2.TabIndex = 6;
            this.bNumber2.Text = "2";
            this.bNumber2.UseVisualStyleBackColor = false;
            this.bNumber2.Click += new System.EventHandler(this.Numeric_Values);
            this.bNumber2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bNumber1
            // 
            this.bNumber1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.bNumber1.FlatAppearance.BorderSize = 0;
            this.bNumber1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bNumber1.Location = new System.Drawing.Point(1, 380);
            this.bNumber1.Name = "bNumber1";
            this.bNumber1.Size = new System.Drawing.Size(77, 52);
            this.bNumber1.TabIndex = 5;
            this.bNumber1.Text = "1";
            this.bNumber1.UseVisualStyleBackColor = false;
            this.bNumber1.Click += new System.EventHandler(this.Numeric_Values);
            this.bNumber1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bOpMinus
            // 
            this.bOpMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(216)))));
            this.bOpMinus.FlatAppearance.BorderSize = 0;
            this.bOpMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bOpMinus.Location = new System.Drawing.Point(250, 322);
            this.bOpMinus.Name = "bOpMinus";
            this.bOpMinus.Size = new System.Drawing.Size(77, 52);
            this.bOpMinus.TabIndex = 12;
            this.bOpMinus.Text = "-";
            this.bOpMinus.UseVisualStyleBackColor = false;
            this.bOpMinus.Click += new System.EventHandler(this.Operational_Function);
            this.bOpMinus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bNumber6
            // 
            this.bNumber6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.bNumber6.FlatAppearance.BorderSize = 0;
            this.bNumber6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNumber6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bNumber6.Location = new System.Drawing.Point(167, 322);
            this.bNumber6.Name = "bNumber6";
            this.bNumber6.Size = new System.Drawing.Size(77, 52);
            this.bNumber6.TabIndex = 11;
            this.bNumber6.Text = "6";
            this.bNumber6.UseVisualStyleBackColor = false;
            this.bNumber6.Click += new System.EventHandler(this.Numeric_Values);
            this.bNumber6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bNumber5
            // 
            this.bNumber5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.bNumber5.FlatAppearance.BorderSize = 0;
            this.bNumber5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNumber5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bNumber5.Location = new System.Drawing.Point(84, 322);
            this.bNumber5.Name = "bNumber5";
            this.bNumber5.Size = new System.Drawing.Size(77, 52);
            this.bNumber5.TabIndex = 10;
            this.bNumber5.Text = "5";
            this.bNumber5.UseVisualStyleBackColor = false;
            this.bNumber5.Click += new System.EventHandler(this.Numeric_Values);
            this.bNumber5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bNumber4
            // 
            this.bNumber4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.bNumber4.FlatAppearance.BorderSize = 0;
            this.bNumber4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.bNumber4.Location = new System.Drawing.Point(1, 322);
            this.bNumber4.Name = "bNumber4";
            this.bNumber4.Size = new System.Drawing.Size(77, 52);
            this.bNumber4.TabIndex = 9;
            this.bNumber4.Text = "4";
            this.bNumber4.UseVisualStyleBackColor = false;
            this.bNumber4.Click += new System.EventHandler(this.Numeric_Values);
            this.bNumber4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bOpMultiplication
            // 
            this.bOpMultiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(216)))));
            this.bOpMultiplication.FlatAppearance.BorderSize = 0;
            this.bOpMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bOpMultiplication.Location = new System.Drawing.Point(250, 264);
            this.bOpMultiplication.Name = "bOpMultiplication";
            this.bOpMultiplication.Size = new System.Drawing.Size(77, 52);
            this.bOpMultiplication.TabIndex = 16;
            this.bOpMultiplication.Text = "x";
            this.bOpMultiplication.UseVisualStyleBackColor = false;
            this.bOpMultiplication.Click += new System.EventHandler(this.Operational_Function);
            this.bOpMultiplication.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bNumber9
            // 
            this.bNumber9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.bNumber9.FlatAppearance.BorderSize = 0;
            this.bNumber9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNumber9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bNumber9.Location = new System.Drawing.Point(167, 264);
            this.bNumber9.Name = "bNumber9";
            this.bNumber9.Size = new System.Drawing.Size(77, 52);
            this.bNumber9.TabIndex = 15;
            this.bNumber9.Text = "9";
            this.bNumber9.UseVisualStyleBackColor = false;
            this.bNumber9.Click += new System.EventHandler(this.Numeric_Values);
            this.bNumber9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bNumber8
            // 
            this.bNumber8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.bNumber8.FlatAppearance.BorderSize = 0;
            this.bNumber8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNumber8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bNumber8.Location = new System.Drawing.Point(84, 264);
            this.bNumber8.Name = "bNumber8";
            this.bNumber8.Size = new System.Drawing.Size(77, 52);
            this.bNumber8.TabIndex = 14;
            this.bNumber8.Text = "8";
            this.bNumber8.UseVisualStyleBackColor = false;
            this.bNumber8.Click += new System.EventHandler(this.Numeric_Values);
            this.bNumber8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bNumber7
            // 
            this.bNumber7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.bNumber7.FlatAppearance.BorderSize = 0;
            this.bNumber7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNumber7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bNumber7.Location = new System.Drawing.Point(1, 264);
            this.bNumber7.Name = "bNumber7";
            this.bNumber7.Size = new System.Drawing.Size(77, 52);
            this.bNumber7.TabIndex = 13;
            this.bNumber7.Text = "7";
            this.bNumber7.UseVisualStyleBackColor = false;
            this.bNumber7.Click += new System.EventHandler(this.Numeric_Values);
            this.bNumber7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bOpDivide
            // 
            this.bOpDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(216)))));
            this.bOpDivide.FlatAppearance.BorderSize = 0;
            this.bOpDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bOpDivide.Location = new System.Drawing.Point(250, 206);
            this.bOpDivide.Name = "bOpDivide";
            this.bOpDivide.Size = new System.Drawing.Size(77, 52);
            this.bOpDivide.TabIndex = 20;
            this.bOpDivide.Text = "÷";
            this.bOpDivide.UseVisualStyleBackColor = false;
            this.bOpDivide.Click += new System.EventHandler(this.Operational_Function);
            this.bOpDivide.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bOpSquareRoot
            // 
            this.bOpSquareRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(216)))));
            this.bOpSquareRoot.FlatAppearance.BorderSize = 0;
            this.bOpSquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpSquareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch);
            this.bOpSquareRoot.Image = ((System.Drawing.Image)(resources.GetObject("bOpSquareRoot.Image")));
            this.bOpSquareRoot.Location = new System.Drawing.Point(167, 206);
            this.bOpSquareRoot.Name = "bOpSquareRoot";
            this.bOpSquareRoot.Size = new System.Drawing.Size(77, 52);
            this.bOpSquareRoot.TabIndex = 19;
            this.bOpSquareRoot.Text = "√";
            this.bOpSquareRoot.UseVisualStyleBackColor = false;
            this.bOpSquareRoot.Click += new System.EventHandler(this.SingleNumber_Operations);
            this.bOpSquareRoot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bOpExponent
            // 
            this.bOpExponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(216)))));
            this.bOpExponent.FlatAppearance.BorderSize = 0;
            this.bOpExponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpExponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch);
            this.bOpExponent.Image = ((System.Drawing.Image)(resources.GetObject("bOpExponent.Image")));
            this.bOpExponent.Location = new System.Drawing.Point(84, 206);
            this.bOpExponent.Name = "bOpExponent";
            this.bOpExponent.Size = new System.Drawing.Size(77, 52);
            this.bOpExponent.TabIndex = 18;
            this.bOpExponent.Text = "x²";
            this.bOpExponent.UseVisualStyleBackColor = false;
            this.bOpExponent.Click += new System.EventHandler(this.SingleNumber_Operations);
            this.bOpExponent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bOpBackspace
            // 
            this.bOpBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(216)))));
            this.bOpBackspace.FlatAppearance.BorderSize = 0;
            this.bOpBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bOpBackspace.Location = new System.Drawing.Point(250, 148);
            this.bOpBackspace.Name = "bOpBackspace";
            this.bOpBackspace.Size = new System.Drawing.Size(77, 52);
            this.bOpBackspace.TabIndex = 24;
            this.bOpBackspace.Text = "⌫";
            this.bOpBackspace.UseVisualStyleBackColor = false;
            this.bOpBackspace.Click += new System.EventHandler(this.SingleNumber_Operations);
            this.bOpBackspace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bOpClear
            // 
            this.bOpClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(216)))));
            this.bOpClear.FlatAppearance.BorderSize = 0;
            this.bOpClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bOpClear.Location = new System.Drawing.Point(167, 148);
            this.bOpClear.Name = "bOpClear";
            this.bOpClear.Size = new System.Drawing.Size(77, 52);
            this.bOpClear.TabIndex = 23;
            this.bOpClear.Text = "CE/C";
            this.bOpClear.UseVisualStyleBackColor = false;
            this.bOpClear.Click += new System.EventHandler(this.OpClear);
            this.bOpClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Buttons_KeyDown);
            this.bOpClear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bOpOff
            // 
            this.bOpOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(216)))));
            this.bOpOff.FlatAppearance.BorderSize = 0;
            this.bOpOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bOpOff.Location = new System.Drawing.Point(84, 148);
            this.bOpOff.Name = "bOpOff";
            this.bOpOff.Size = new System.Drawing.Size(77, 52);
            this.bOpOff.TabIndex = 22;
            this.bOpOff.Text = "OFF";
            this.bOpOff.UseVisualStyleBackColor = false;
            this.bOpOff.Click += new System.EventHandler(this.Off_Operation);
            this.bOpOff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bOpPercent
            // 
            this.bOpPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(216)))));
            this.bOpPercent.FlatAppearance.BorderSize = 0;
            this.bOpPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bOpPercent.Location = new System.Drawing.Point(1, 148);
            this.bOpPercent.Name = "bOpPercent";
            this.bOpPercent.Size = new System.Drawing.Size(77, 52);
            this.bOpPercent.TabIndex = 21;
            this.bOpPercent.Text = "%";
            this.bOpPercent.UseVisualStyleBackColor = false;
            this.bOpPercent.Click += new System.EventHandler(this.Operational_Function);
            this.bOpPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(190)))));
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDisplay.Location = new System.Drawing.Point(15, 64);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(304, 41);
            this.txtDisplay.TabIndex = 25;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bOpDivideX
            // 
            this.bOpDivideX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(216)))));
            this.bOpDivideX.FlatAppearance.BorderSize = 0;
            this.bOpDivideX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpDivideX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch);
            this.bOpDivideX.Image = ((System.Drawing.Image)(resources.GetObject("bOpDivideX.Image")));
            this.bOpDivideX.Location = new System.Drawing.Point(1, 206);
            this.bOpDivideX.Name = "bOpDivideX";
            this.bOpDivideX.Size = new System.Drawing.Size(77, 52);
            this.bOpDivideX.TabIndex = 26;
            this.bOpDivideX.Text = "1/x";
            this.bOpDivideX.UseVisualStyleBackColor = false;
            this.bOpDivideX.Click += new System.EventHandler(this.SingleNumber_Operations);
            this.bOpDivideX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bOpMemoryClear
            // 
            this.bOpMemoryClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(190)))));
            this.bOpMemoryClear.Enabled = false;
            this.bOpMemoryClear.FlatAppearance.BorderSize = 0;
            this.bOpMemoryClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpMemoryClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bOpMemoryClear.Location = new System.Drawing.Point(1, 112);
            this.bOpMemoryClear.Name = "bOpMemoryClear";
            this.bOpMemoryClear.Size = new System.Drawing.Size(49, 30);
            this.bOpMemoryClear.TabIndex = 27;
            this.bOpMemoryClear.Text = "MC";
            this.bOpMemoryClear.UseVisualStyleBackColor = false;
            this.bOpMemoryClear.Click += new System.EventHandler(this.Memory_Operations);
            // 
            // bOpMemoryRead
            // 
            this.bOpMemoryRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(190)))));
            this.bOpMemoryRead.Enabled = false;
            this.bOpMemoryRead.FlatAppearance.BorderSize = 0;
            this.bOpMemoryRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpMemoryRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bOpMemoryRead.Location = new System.Drawing.Point(56, 112);
            this.bOpMemoryRead.Name = "bOpMemoryRead";
            this.bOpMemoryRead.Size = new System.Drawing.Size(49, 30);
            this.bOpMemoryRead.TabIndex = 28;
            this.bOpMemoryRead.Text = "MR";
            this.bOpMemoryRead.UseVisualStyleBackColor = false;
            this.bOpMemoryRead.Click += new System.EventHandler(this.Memory_Operations);
            // 
            // bOpMemoryMinus
            // 
            this.bOpMemoryMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(190)))));
            this.bOpMemoryMinus.FlatAppearance.BorderSize = 0;
            this.bOpMemoryMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpMemoryMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bOpMemoryMinus.Location = new System.Drawing.Point(166, 112);
            this.bOpMemoryMinus.Name = "bOpMemoryMinus";
            this.bOpMemoryMinus.Size = new System.Drawing.Size(49, 30);
            this.bOpMemoryMinus.TabIndex = 30;
            this.bOpMemoryMinus.Text = "M-";
            this.bOpMemoryMinus.UseVisualStyleBackColor = false;
            this.bOpMemoryMinus.Click += new System.EventHandler(this.Memory_Operations);
            // 
            // bOpMemoryPlus
            // 
            this.bOpMemoryPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(190)))));
            this.bOpMemoryPlus.FlatAppearance.BorderSize = 0;
            this.bOpMemoryPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpMemoryPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bOpMemoryPlus.Location = new System.Drawing.Point(111, 112);
            this.bOpMemoryPlus.Name = "bOpMemoryPlus";
            this.bOpMemoryPlus.Size = new System.Drawing.Size(49, 30);
            this.bOpMemoryPlus.TabIndex = 29;
            this.bOpMemoryPlus.Text = "M+";
            this.bOpMemoryPlus.UseVisualStyleBackColor = false;
            this.bOpMemoryPlus.Click += new System.EventHandler(this.Memory_Operations);
            // 
            // bOpMemoryList
            // 
            this.bOpMemoryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(190)))));
            this.bOpMemoryList.Enabled = false;
            this.bOpMemoryList.FlatAppearance.BorderSize = 0;
            this.bOpMemoryList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpMemoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bOpMemoryList.Location = new System.Drawing.Point(276, 112);
            this.bOpMemoryList.Name = "bOpMemoryList";
            this.bOpMemoryList.Size = new System.Drawing.Size(49, 30);
            this.bOpMemoryList.TabIndex = 32;
            this.bOpMemoryList.Text = "M↓";
            this.bOpMemoryList.UseVisualStyleBackColor = false;
            this.bOpMemoryList.Click += new System.EventHandler(this.Memory_Operations);
            this.bOpMemoryList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buttons_KeyPress);
            // 
            // bOpMemorySave
            // 
            this.bOpMemorySave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(190)))));
            this.bOpMemorySave.FlatAppearance.BorderSize = 0;
            this.bOpMemorySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpMemorySave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bOpMemorySave.Location = new System.Drawing.Point(221, 112);
            this.bOpMemorySave.Name = "bOpMemorySave";
            this.bOpMemorySave.Size = new System.Drawing.Size(49, 30);
            this.bOpMemorySave.TabIndex = 31;
            this.bOpMemorySave.Text = "MS";
            this.bOpMemorySave.UseVisualStyleBackColor = false;
            this.bOpMemorySave.Click += new System.EventHandler(this.Memory_Operations);
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(95)))));
            this.lblOp.Location = new System.Drawing.Point(270, 40);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 15);
            this.lblOp.TabIndex = 33;
            // 
            // listBoxMemory
            // 
            this.listBoxMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(190)))));
            this.listBoxMemory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxMemory.Enabled = false;
            this.listBoxMemory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxMemory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(95)))));
            this.listBoxMemory.FormattingEnabled = true;
            this.listBoxMemory.ItemHeight = 15;
            this.listBoxMemory.Location = new System.Drawing.Point(1, 9);
            this.listBoxMemory.Name = "listBoxMemory";
            this.listBoxMemory.Size = new System.Drawing.Size(120, 90);
            this.listBoxMemory.TabIndex = 35;
            this.listBoxMemory.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(328, 493);
            this.Controls.Add(this.listBoxMemory);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.bOpMemoryList);
            this.Controls.Add(this.bOpMemorySave);
            this.Controls.Add(this.bOpMemoryMinus);
            this.Controls.Add(this.bOpMemoryPlus);
            this.Controls.Add(this.bOpMemoryRead);
            this.Controls.Add(this.bOpMemoryClear);
            this.Controls.Add(this.bOpDivideX);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.bOpBackspace);
            this.Controls.Add(this.bOpClear);
            this.Controls.Add(this.bOpOff);
            this.Controls.Add(this.bOpPercent);
            this.Controls.Add(this.bOpDivide);
            this.Controls.Add(this.bOpSquareRoot);
            this.Controls.Add(this.bOpExponent);
            this.Controls.Add(this.bOpMultiplication);
            this.Controls.Add(this.bNumber9);
            this.Controls.Add(this.bNumber8);
            this.Controls.Add(this.bNumber7);
            this.Controls.Add(this.bOpMinus);
            this.Controls.Add(this.bNumber6);
            this.Controls.Add(this.bNumber5);
            this.Controls.Add(this.bNumber4);
            this.Controls.Add(this.bOpPlus);
            this.Controls.Add(this.bNumber3);
            this.Controls.Add(this.bNumber2);
            this.Controls.Add(this.bNumber1);
            this.Controls.Add(this.bEquals);
            this.Controls.Add(this.bPoint);
            this.Controls.Add(this.bNumber0);
            this.Controls.Add(this.bOpPlusMinus);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form2";
            this.Text = "Standart Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bOpPlusMinus;
        private Button bNumber0;
        private Button bPoint;
        private Button bEquals;
        private Button bOpPlus;
        private Button bNumber3;
        private Button bNumber2;
        private Button bNumber1;
        private Button bOpMinus;
        private Button bNumber6;
        private Button bNumber5;
        private Button bNumber4;
        private Button bOpMultiplication;
        private Button bNumber9;
        private Button bNumber8;
        private Button bNumber7;
        private Button bOpDivide;
        private Button bOpSquareRoot;
        private Button bOpExponent;
        private Button bOpBackspace;
        private Button bOpClear;
        private Button bOpOff;
        private Button bOpPercent;
        private TextBox txtDisplay;
        private Button bOpDivideX;
        private Button bOpMemoryClear;
        private Button bOpMemoryRead;
        private Button bOpMemoryMinus;
        private Button bOpMemoryPlus;
        private Button bOpMemoryList;
        private Button bOpMemorySave;
        private Label lblOp;
        private ListBox listBoxMemory;
    }
}