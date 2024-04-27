namespace Programming_2_Project__Calculator_
{
    partial class CalculatorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ImageOfApp = new System.Windows.Forms.PictureBox();
            this.NameOfAppLavel = new System.Windows.Forms.Label();
            this.TextBoxPanel = new System.Windows.Forms.Panel();
            this.MainTextBox = new System.Windows.Forms.RichTextBox();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.PanelOfCalcButtons = new System.Windows.Forms.Panel();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MultiplyByNegativeOneButton = new System.Windows.Forms.Button();
            this.LnButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.InverseNumberButton = new System.Windows.Forms.Button();
            this.EButton = new System.Windows.Forms.Button();
            this.PiButton = new System.Windows.Forms.Button();
            this.SinButton = new System.Windows.Forms.Button();
            this.CosButton = new System.Windows.Forms.Button();
            this.TanButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.PercentageButton = new System.Windows.Forms.Button();
            this.ModButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.FactorialButton = new System.Windows.Forms.Button();
            this.CloseParenthesisButton = new System.Windows.Forms.Button();
            this.OpenParenthesisButton = new System.Windows.Forms.Button();
            this.SQRTButton = new System.Windows.Forms.Button();
            this.XPoweYButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.TenPowerXButton = new System.Windows.Forms.Button();
            this.LogButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ToolTipHistory = new System.Windows.Forms.ToolTip(this.components);
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOfApp)).BeginInit();
            this.TextBoxPanel.SuspendLayout();
            this.PanelOfCalcButtons.SuspendLayout();
            this.MainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.MinimizeButton);
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Controls.Add(this.ImageOfApp);
            this.MainPanel.Controls.Add(this.NameOfAppLavel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(407, 62);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinimizeButton.Location = new System.Drawing.Point(309, 11);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(35, 35);
            this.MinimizeButton.TabIndex = 9999;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Text = "ـــ";
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.DarkRed;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(359, 11);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 35);
            this.CloseButton.TabIndex = 299;
            this.CloseButton.TabStop = false;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ImageOfApp
            // 
            this.ImageOfApp.Image = global::Programming_2_Project__Calculator_.Properties.Resources._171352_calculator_icon;
            this.ImageOfApp.Location = new System.Drawing.Point(9, 9);
            this.ImageOfApp.Name = "ImageOfApp";
            this.ImageOfApp.Size = new System.Drawing.Size(43, 46);
            this.ImageOfApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageOfApp.TabIndex = 1;
            this.ImageOfApp.TabStop = false;
            // 
            // NameOfAppLavel
            // 
            this.NameOfAppLavel.AutoSize = true;
            this.NameOfAppLavel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameOfAppLavel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfAppLavel.ForeColor = System.Drawing.Color.White;
            this.NameOfAppLavel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NameOfAppLavel.Location = new System.Drawing.Point(56, 19);
            this.NameOfAppLavel.Name = "NameOfAppLavel";
            this.NameOfAppLavel.Size = new System.Drawing.Size(108, 28);
            this.NameOfAppLavel.TabIndex = 9999;
            this.NameOfAppLavel.Text = "Calculator";
            this.NameOfAppLavel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxPanel
            // 
            this.TextBoxPanel.Controls.Add(this.MainTextBox);
            this.TextBoxPanel.Controls.Add(this.HistoryLabel);
            this.TextBoxPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxPanel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxPanel.Location = new System.Drawing.Point(0, 62);
            this.TextBoxPanel.Name = "TextBoxPanel";
            this.TextBoxPanel.Size = new System.Drawing.Size(407, 115);
            this.TextBoxPanel.TabIndex = 1;
            // 
            // MainTextBox
            // 
            this.MainTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.MainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTextBox.ForeColor = System.Drawing.Color.White;
            this.MainTextBox.Location = new System.Drawing.Point(12, 51);
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.ReadOnly = true;
            this.MainTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainTextBox.Size = new System.Drawing.Size(383, 48);
            this.MainTextBox.TabIndex = 953;
            this.MainTextBox.Text = "0";
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HistoryLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HistoryLabel.Location = new System.Drawing.Point(0, 0);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.HistoryLabel.Size = new System.Drawing.Size(407, 43);
            this.HistoryLabel.TabIndex = 952;
            this.HistoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HistoryLabel.TextChanged += new System.EventHandler(this.HistoryLabel_TextChanged);
            // 
            // PanelOfCalcButtons
            // 
            this.PanelOfCalcButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.PanelOfCalcButtons.Controls.Add(this.MainTableLayoutPanel);
            this.PanelOfCalcButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelOfCalcButtons.Location = new System.Drawing.Point(0, 177);
            this.PanelOfCalcButtons.Name = "PanelOfCalcButtons";
            this.PanelOfCalcButtons.Size = new System.Drawing.Size(407, 401);
            this.PanelOfCalcButtons.TabIndex = 2;
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 5;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTableLayoutPanel.Controls.Add(this.MultiplyByNegativeOneButton, 0, 6);
            this.MainTableLayoutPanel.Controls.Add(this.LnButton, 0, 6);
            this.MainTableLayoutPanel.Controls.Add(this.ZeroButton, 0, 6);
            this.MainTableLayoutPanel.Controls.Add(this.EqualButton, 0, 6);
            this.MainTableLayoutPanel.Controls.Add(this.DotButton, 0, 6);
            this.MainTableLayoutPanel.Controls.Add(this.InverseNumberButton, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.EButton, 2, 0);
            this.MainTableLayoutPanel.Controls.Add(this.PiButton, 1, 0);
            this.MainTableLayoutPanel.Controls.Add(this.SinButton, 0, 1);
            this.MainTableLayoutPanel.Controls.Add(this.CosButton, 1, 1);
            this.MainTableLayoutPanel.Controls.Add(this.TanButton, 2, 1);
            this.MainTableLayoutPanel.Controls.Add(this.ClearButton, 3, 0);
            this.MainTableLayoutPanel.Controls.Add(this.DeleteButton, 4, 0);
            this.MainTableLayoutPanel.Controls.Add(this.PercentageButton, 3, 1);
            this.MainTableLayoutPanel.Controls.Add(this.ModButton, 4, 1);
            this.MainTableLayoutPanel.Controls.Add(this.DivideButton, 4, 2);
            this.MainTableLayoutPanel.Controls.Add(this.MultiplyButton, 4, 3);
            this.MainTableLayoutPanel.Controls.Add(this.MinusButton, 4, 4);
            this.MainTableLayoutPanel.Controls.Add(this.PlusButton, 4, 5);
            this.MainTableLayoutPanel.Controls.Add(this.ThreeButton, 3, 5);
            this.MainTableLayoutPanel.Controls.Add(this.SixButton, 3, 4);
            this.MainTableLayoutPanel.Controls.Add(this.NineButton, 3, 3);
            this.MainTableLayoutPanel.Controls.Add(this.FactorialButton, 3, 2);
            this.MainTableLayoutPanel.Controls.Add(this.CloseParenthesisButton, 2, 2);
            this.MainTableLayoutPanel.Controls.Add(this.OpenParenthesisButton, 1, 2);
            this.MainTableLayoutPanel.Controls.Add(this.SQRTButton, 0, 2);
            this.MainTableLayoutPanel.Controls.Add(this.XPoweYButton, 0, 3);
            this.MainTableLayoutPanel.Controls.Add(this.SevenButton, 1, 3);
            this.MainTableLayoutPanel.Controls.Add(this.EightButton, 2, 3);
            this.MainTableLayoutPanel.Controls.Add(this.FiveButton, 2, 4);
            this.MainTableLayoutPanel.Controls.Add(this.FourButton, 1, 4);
            this.MainTableLayoutPanel.Controls.Add(this.TenPowerXButton, 0, 4);
            this.MainTableLayoutPanel.Controls.Add(this.LogButton, 0, 5);
            this.MainTableLayoutPanel.Controls.Add(this.OneButton, 1, 5);
            this.MainTableLayoutPanel.Controls.Add(this.TwoButton, 2, 5);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 7;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(407, 401);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // MultiplyByNegativeOneButton
            // 
            this.MultiplyByNegativeOneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.MultiplyByNegativeOneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiplyByNegativeOneButton.FlatAppearance.BorderSize = 0;
            this.MultiplyByNegativeOneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MultiplyByNegativeOneButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyByNegativeOneButton.ForeColor = System.Drawing.Color.White;
            this.MultiplyByNegativeOneButton.Location = new System.Drawing.Point(88, 349);
            this.MultiplyByNegativeOneButton.Margin = new System.Windows.Forms.Padding(7);
            this.MultiplyByNegativeOneButton.Name = "MultiplyByNegativeOneButton";
            this.MultiplyByNegativeOneButton.Size = new System.Drawing.Size(67, 45);
            this.MultiplyByNegativeOneButton.TabIndex = 9;
            this.MultiplyByNegativeOneButton.UseVisualStyleBackColor = false;
            this.MultiplyByNegativeOneButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // LnButton
            // 
            this.LnButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LnButton.FlatAppearance.BorderSize = 0;
            this.LnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LnButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnButton.ForeColor = System.Drawing.Color.White;
            this.LnButton.Location = new System.Drawing.Point(7, 349);
            this.LnButton.Margin = new System.Windows.Forms.Padding(7);
            this.LnButton.Name = "LnButton";
            this.LnButton.Size = new System.Drawing.Size(67, 45);
            this.LnButton.TabIndex = 8;
            this.LnButton.Text = "ln";
            this.LnButton.UseVisualStyleBackColor = true;
            this.LnButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.FlatAppearance.BorderSize = 0;
            this.ZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZeroButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.ForeColor = System.Drawing.Color.White;
            this.ZeroButton.Location = new System.Drawing.Point(169, 349);
            this.ZeroButton.Margin = new System.Windows.Forms.Padding(7);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(67, 45);
            this.ZeroButton.TabIndex = 7;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.NumberClick);
            // 
            // EqualButton
            // 
            this.EqualButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(11)))));
            this.EqualButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualButton.FlatAppearance.BorderSize = 0;
            this.EqualButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EqualButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualButton.ForeColor = System.Drawing.Color.White;
            this.EqualButton.Location = new System.Drawing.Point(331, 349);
            this.EqualButton.Margin = new System.Windows.Forms.Padding(7);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(69, 45);
            this.EqualButton.TabIndex = 6;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = false;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.DotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DotButton.FlatAppearance.BorderSize = 0;
            this.DotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DotButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotButton.ForeColor = System.Drawing.Color.White;
            this.DotButton.Location = new System.Drawing.Point(250, 349);
            this.DotButton.Margin = new System.Windows.Forms.Padding(7);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(67, 45);
            this.DotButton.TabIndex = 5;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = false;
            this.DotButton.Click += new System.EventHandler(this.NumberClick);
            // 
            // InverseNumberButton
            // 
            this.InverseNumberButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InverseNumberButton.FlatAppearance.BorderSize = 0;
            this.InverseNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InverseNumberButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InverseNumberButton.ForeColor = System.Drawing.Color.White;
            this.InverseNumberButton.Location = new System.Drawing.Point(7, 7);
            this.InverseNumberButton.Margin = new System.Windows.Forms.Padding(7);
            this.InverseNumberButton.Name = "InverseNumberButton";
            this.InverseNumberButton.Size = new System.Drawing.Size(67, 43);
            this.InverseNumberButton.TabIndex = 2;
            this.InverseNumberButton.Text = "1/x";
            this.InverseNumberButton.UseVisualStyleBackColor = true;
            this.InverseNumberButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // EButton
            // 
            this.EButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EButton.FlatAppearance.BorderSize = 0;
            this.EButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EButton.ForeColor = System.Drawing.Color.White;
            this.EButton.Location = new System.Drawing.Point(169, 7);
            this.EButton.Margin = new System.Windows.Forms.Padding(7);
            this.EButton.Name = "EButton";
            this.EButton.Size = new System.Drawing.Size(67, 43);
            this.EButton.TabIndex = 4;
            this.EButton.Text = "e";
            this.EButton.UseVisualStyleBackColor = true;
            this.EButton.Click += new System.EventHandler(this.EButton_Click);
            // 
            // PiButton
            // 
            this.PiButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PiButton.FlatAppearance.BorderSize = 0;
            this.PiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PiButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PiButton.ForeColor = System.Drawing.Color.White;
            this.PiButton.Location = new System.Drawing.Point(88, 7);
            this.PiButton.Margin = new System.Windows.Forms.Padding(7);
            this.PiButton.Name = "PiButton";
            this.PiButton.Size = new System.Drawing.Size(67, 43);
            this.PiButton.TabIndex = 4;
            this.PiButton.UseVisualStyleBackColor = true;
            this.PiButton.Click += new System.EventHandler(this.PiButton_Click);
            // 
            // SinButton
            // 
            this.SinButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SinButton.FlatAppearance.BorderSize = 0;
            this.SinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SinButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinButton.ForeColor = System.Drawing.Color.White;
            this.SinButton.Location = new System.Drawing.Point(7, 64);
            this.SinButton.Margin = new System.Windows.Forms.Padding(7);
            this.SinButton.Name = "SinButton";
            this.SinButton.Size = new System.Drawing.Size(67, 43);
            this.SinButton.TabIndex = 4;
            this.SinButton.Text = "sin";
            this.SinButton.UseVisualStyleBackColor = true;
            this.SinButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // CosButton
            // 
            this.CosButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CosButton.FlatAppearance.BorderSize = 0;
            this.CosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CosButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CosButton.ForeColor = System.Drawing.Color.White;
            this.CosButton.Location = new System.Drawing.Point(88, 64);
            this.CosButton.Margin = new System.Windows.Forms.Padding(7);
            this.CosButton.Name = "CosButton";
            this.CosButton.Size = new System.Drawing.Size(67, 43);
            this.CosButton.TabIndex = 4;
            this.CosButton.Text = "cos";
            this.CosButton.UseVisualStyleBackColor = true;
            this.CosButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // TanButton
            // 
            this.TanButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TanButton.FlatAppearance.BorderSize = 0;
            this.TanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TanButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TanButton.ForeColor = System.Drawing.Color.White;
            this.TanButton.Location = new System.Drawing.Point(169, 64);
            this.TanButton.Margin = new System.Windows.Forms.Padding(7);
            this.TanButton.Name = "TanButton";
            this.TanButton.Size = new System.Drawing.Size(67, 43);
            this.TanButton.TabIndex = 4;
            this.TanButton.Text = "tan";
            this.TanButton.UseVisualStyleBackColor = true;
            this.TanButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // ClearButton
            // 
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(250, 7);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(7);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(67, 43);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(331, 7);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(7);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(69, 43);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // PercentageButton
            // 
            this.PercentageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PercentageButton.FlatAppearance.BorderSize = 0;
            this.PercentageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PercentageButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentageButton.ForeColor = System.Drawing.Color.White;
            this.PercentageButton.Location = new System.Drawing.Point(250, 64);
            this.PercentageButton.Margin = new System.Windows.Forms.Padding(7);
            this.PercentageButton.Name = "PercentageButton";
            this.PercentageButton.Size = new System.Drawing.Size(67, 43);
            this.PercentageButton.TabIndex = 4;
            this.PercentageButton.UseVisualStyleBackColor = true;
            this.PercentageButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // ModButton
            // 
            this.ModButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModButton.FlatAppearance.BorderSize = 0;
            this.ModButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModButton.ForeColor = System.Drawing.Color.White;
            this.ModButton.Location = new System.Drawing.Point(331, 64);
            this.ModButton.Margin = new System.Windows.Forms.Padding(7);
            this.ModButton.Name = "ModButton";
            this.ModButton.Size = new System.Drawing.Size(69, 43);
            this.ModButton.TabIndex = 4;
            this.ModButton.Text = "mod";
            this.ModButton.UseVisualStyleBackColor = true;
            this.ModButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // DivideButton
            // 
            this.DivideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivideButton.FlatAppearance.BorderSize = 0;
            this.DivideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivideButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideButton.ForeColor = System.Drawing.Color.White;
            this.DivideButton.Location = new System.Drawing.Point(331, 121);
            this.DivideButton.Margin = new System.Windows.Forms.Padding(7);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(69, 43);
            this.DivideButton.TabIndex = 4;
            this.DivideButton.Text = "÷";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiplyButton.FlatAppearance.BorderSize = 0;
            this.MultiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MultiplyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyButton.ForeColor = System.Drawing.Color.White;
            this.MultiplyButton.Location = new System.Drawing.Point(331, 178);
            this.MultiplyButton.Margin = new System.Windows.Forms.Padding(7);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(69, 43);
            this.MultiplyButton.TabIndex = 4;
            this.MultiplyButton.Text = "x";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // MinusButton
            // 
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinusButton.FlatAppearance.BorderSize = 0;
            this.MinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusButton.ForeColor = System.Drawing.Color.White;
            this.MinusButton.Location = new System.Drawing.Point(331, 235);
            this.MinusButton.Margin = new System.Windows.Forms.Padding(7);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(69, 43);
            this.MinusButton.TabIndex = 4;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // PlusButton
            // 
            this.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusButton.FlatAppearance.BorderSize = 0;
            this.PlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusButton.ForeColor = System.Drawing.Color.White;
            this.PlusButton.Location = new System.Drawing.Point(331, 292);
            this.PlusButton.Margin = new System.Windows.Forms.Padding(7);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(69, 43);
            this.PlusButton.TabIndex = 4;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.FlatAppearance.BorderSize = 0;
            this.ThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.ForeColor = System.Drawing.Color.White;
            this.ThreeButton.Location = new System.Drawing.Point(250, 292);
            this.ThreeButton.Margin = new System.Windows.Forms.Padding(7);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(67, 43);
            this.ThreeButton.TabIndex = 4;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.NumberClick);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.FlatAppearance.BorderSize = 0;
            this.SixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SixButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.ForeColor = System.Drawing.Color.White;
            this.SixButton.Location = new System.Drawing.Point(250, 235);
            this.SixButton.Margin = new System.Windows.Forms.Padding(7);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(67, 43);
            this.SixButton.TabIndex = 4;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.NumberClick);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.NineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NineButton.FlatAppearance.BorderSize = 0;
            this.NineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NineButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.ForeColor = System.Drawing.Color.White;
            this.NineButton.Location = new System.Drawing.Point(250, 178);
            this.NineButton.Margin = new System.Windows.Forms.Padding(7);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(67, 43);
            this.NineButton.TabIndex = 4;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.NumberClick);
            // 
            // FactorialButton
            // 
            this.FactorialButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FactorialButton.FlatAppearance.BorderSize = 0;
            this.FactorialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FactorialButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactorialButton.ForeColor = System.Drawing.Color.White;
            this.FactorialButton.Location = new System.Drawing.Point(250, 121);
            this.FactorialButton.Margin = new System.Windows.Forms.Padding(7);
            this.FactorialButton.Name = "FactorialButton";
            this.FactorialButton.Size = new System.Drawing.Size(67, 43);
            this.FactorialButton.TabIndex = 4;
            this.FactorialButton.Text = "n!";
            this.FactorialButton.UseVisualStyleBackColor = true;
            this.FactorialButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // CloseParenthesisButton
            // 
            this.CloseParenthesisButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseParenthesisButton.FlatAppearance.BorderSize = 0;
            this.CloseParenthesisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseParenthesisButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseParenthesisButton.ForeColor = System.Drawing.Color.White;
            this.CloseParenthesisButton.Location = new System.Drawing.Point(169, 121);
            this.CloseParenthesisButton.Margin = new System.Windows.Forms.Padding(7);
            this.CloseParenthesisButton.Name = "CloseParenthesisButton";
            this.CloseParenthesisButton.Size = new System.Drawing.Size(67, 43);
            this.CloseParenthesisButton.TabIndex = 4;
            this.CloseParenthesisButton.Text = ")";
            this.CloseParenthesisButton.UseVisualStyleBackColor = true;
            this.CloseParenthesisButton.Click += new System.EventHandler(this.CloseParenthesisButton_Click);
            // 
            // OpenParenthesisButton
            // 
            this.OpenParenthesisButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenParenthesisButton.FlatAppearance.BorderSize = 0;
            this.OpenParenthesisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenParenthesisButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenParenthesisButton.ForeColor = System.Drawing.Color.White;
            this.OpenParenthesisButton.Location = new System.Drawing.Point(88, 121);
            this.OpenParenthesisButton.Margin = new System.Windows.Forms.Padding(7);
            this.OpenParenthesisButton.Name = "OpenParenthesisButton";
            this.OpenParenthesisButton.Size = new System.Drawing.Size(67, 43);
            this.OpenParenthesisButton.TabIndex = 4;
            this.OpenParenthesisButton.Text = "(";
            this.OpenParenthesisButton.UseVisualStyleBackColor = true;
            this.OpenParenthesisButton.Click += new System.EventHandler(this.OpenParenthesisButton_Click);
            // 
            // SQRTButton
            // 
            this.SQRTButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SQRTButton.FlatAppearance.BorderSize = 0;
            this.SQRTButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SQRTButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQRTButton.ForeColor = System.Drawing.Color.White;
            this.SQRTButton.Location = new System.Drawing.Point(7, 121);
            this.SQRTButton.Margin = new System.Windows.Forms.Padding(7);
            this.SQRTButton.Name = "SQRTButton";
            this.SQRTButton.Size = new System.Drawing.Size(67, 43);
            this.SQRTButton.TabIndex = 4;
            this.SQRTButton.UseVisualStyleBackColor = true;
            this.SQRTButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // XPoweYButton
            // 
            this.XPoweYButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XPoweYButton.FlatAppearance.BorderSize = 0;
            this.XPoweYButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XPoweYButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XPoweYButton.ForeColor = System.Drawing.Color.White;
            this.XPoweYButton.Location = new System.Drawing.Point(7, 178);
            this.XPoweYButton.Margin = new System.Windows.Forms.Padding(7);
            this.XPoweYButton.Name = "XPoweYButton";
            this.XPoweYButton.Size = new System.Drawing.Size(67, 43);
            this.XPoweYButton.TabIndex = 4;
            this.XPoweYButton.UseVisualStyleBackColor = true;
            this.XPoweYButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.FlatAppearance.BorderSize = 0;
            this.SevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SevenButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.ForeColor = System.Drawing.Color.White;
            this.SevenButton.Location = new System.Drawing.Point(88, 178);
            this.SevenButton.Margin = new System.Windows.Forms.Padding(7);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(67, 43);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.NumberClick);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.FlatAppearance.BorderSize = 0;
            this.EightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EightButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.ForeColor = System.Drawing.Color.White;
            this.EightButton.Location = new System.Drawing.Point(169, 178);
            this.EightButton.Margin = new System.Windows.Forms.Padding(7);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(67, 43);
            this.EightButton.TabIndex = 4;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.NumberClick);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.FlatAppearance.BorderSize = 0;
            this.FiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.ForeColor = System.Drawing.Color.White;
            this.FiveButton.Location = new System.Drawing.Point(169, 235);
            this.FiveButton.Margin = new System.Windows.Forms.Padding(7);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(67, 43);
            this.FiveButton.TabIndex = 4;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.NumberClick);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.FlatAppearance.BorderSize = 0;
            this.FourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.ForeColor = System.Drawing.Color.White;
            this.FourButton.Location = new System.Drawing.Point(88, 235);
            this.FourButton.Margin = new System.Windows.Forms.Padding(7);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(67, 43);
            this.FourButton.TabIndex = 4;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.NumberClick);
            // 
            // TenPowerXButton
            // 
            this.TenPowerXButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TenPowerXButton.FlatAppearance.BorderSize = 0;
            this.TenPowerXButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TenPowerXButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenPowerXButton.ForeColor = System.Drawing.Color.White;
            this.TenPowerXButton.Location = new System.Drawing.Point(7, 235);
            this.TenPowerXButton.Margin = new System.Windows.Forms.Padding(7);
            this.TenPowerXButton.Name = "TenPowerXButton";
            this.TenPowerXButton.Size = new System.Drawing.Size(67, 43);
            this.TenPowerXButton.TabIndex = 4;
            this.TenPowerXButton.UseVisualStyleBackColor = true;
            this.TenPowerXButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // LogButton
            // 
            this.LogButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogButton.FlatAppearance.BorderSize = 0;
            this.LogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogButton.ForeColor = System.Drawing.Color.White;
            this.LogButton.Location = new System.Drawing.Point(7, 292);
            this.LogButton.Margin = new System.Windows.Forms.Padding(7);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(67, 43);
            this.LogButton.TabIndex = 4;
            this.LogButton.Text = "log";
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.FlatAppearance.BorderSize = 0;
            this.OneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.ForeColor = System.Drawing.Color.White;
            this.OneButton.Location = new System.Drawing.Point(88, 292);
            this.OneButton.Margin = new System.Windows.Forms.Padding(7);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(67, 43);
            this.OneButton.TabIndex = 4;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.NumberClick);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.FlatAppearance.BorderSize = 0;
            this.TwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.ForeColor = System.Drawing.Color.White;
            this.TwoButton.Location = new System.Drawing.Point(169, 292);
            this.TwoButton.Margin = new System.Windows.Forms.Padding(7);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(67, 43);
            this.TwoButton.TabIndex = 4;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.NumberClick);
            // 
            // ToolTipHistory
            // 
            this.ToolTipHistory.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTipHistory.ToolTipTitle = "Full History";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(407, 578);
            this.Controls.Add(this.PanelOfCalcButtons);
            this.Controls.Add(this.TextBoxPanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalculatorForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorForm_KeyPress);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOfApp)).EndInit();
            this.TextBoxPanel.ResumeLayout(false);
            this.PanelOfCalcButtons.ResumeLayout(false);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label NameOfAppLavel;
        private System.Windows.Forms.Panel TextBoxPanel;
        private System.Windows.Forms.Panel PanelOfCalcButtons;
        private System.Windows.Forms.PictureBox ImageOfApp;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label HistoryLabel;
        private System.Windows.Forms.ToolTip ToolTipHistory;
        private System.Windows.Forms.RichTextBox MainTextBox;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Button MultiplyByNegativeOneButton;
        private System.Windows.Forms.Button LnButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button InverseNumberButton;
        private System.Windows.Forms.Button EButton;
        private System.Windows.Forms.Button PiButton;
        private System.Windows.Forms.Button SinButton;
        private System.Windows.Forms.Button CosButton;
        private System.Windows.Forms.Button TanButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button PercentageButton;
        private System.Windows.Forms.Button ModButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button FactorialButton;
        private System.Windows.Forms.Button CloseParenthesisButton;
        private System.Windows.Forms.Button OpenParenthesisButton;
        private System.Windows.Forms.Button SQRTButton;
        private System.Windows.Forms.Button XPoweYButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button TenPowerXButton;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button TwoButton;
    }
}

