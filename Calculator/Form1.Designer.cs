namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PnlHistory = new System.Windows.Forms.Panel();
            this.BtnClearHistory = new System.Windows.Forms.Button();
            this.RtBoxDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.TxtDisplay2 = new System.Windows.Forms.TextBox();
            this.TxtDisplay1 = new System.Windows.Forms.TextBox();
            this.Btn9 = new Calculator.ArtanButton();
            this.BtnEquals = new Calculator.ArtanButton();
            this.BtnDecimal = new Calculator.ArtanButton();
            this.Btn0 = new Calculator.ArtanButton();
            this.BtnPM = new Calculator.ArtanButton();
            this.Btn3 = new Calculator.ArtanButton();
            this.Btn2 = new Calculator.ArtanButton();
            this.Btn1 = new Calculator.ArtanButton();
            this.BtnAdd = new Calculator.ArtanButton();
            this.Btn6 = new Calculator.ArtanButton();
            this.Btn5 = new Calculator.ArtanButton();
            this.Btn4 = new Calculator.ArtanButton();
            this.BtnSub = new Calculator.ArtanButton();
            this.Btn8 = new Calculator.ArtanButton();
            this.Btn7 = new Calculator.ArtanButton();
            this.BtnMultiply = new Calculator.ArtanButton();
            this.BtnSquare = new Calculator.ArtanButton();
            this.BtnX2 = new Calculator.ArtanButton();
            this.Btn1X = new Calculator.ArtanButton();
            this.BtnDivision = new Calculator.ArtanButton();
            this.BtnC = new Calculator.ArtanButton();
            this.BtnCE = new Calculator.ArtanButton();
            this.BtnPercent = new Calculator.ArtanButton();
            this.artanButton7 = new Calculator.ArtanButton();
            this.artanButton6 = new Calculator.ArtanButton();
            this.artanButton5 = new Calculator.ArtanButton();
            this.artanButton4 = new Calculator.ArtanButton();
            this.artanButton3 = new Calculator.ArtanButton();
            this.artanButton2 = new Calculator.ArtanButton();
            this.BtnBackSpace = new Calculator.ArtanButton();
            this.ElipseForm = new Calculator.ArtanElipseControl();
            this.PnlTitle.SuspendLayout();
            this.PnlHistory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitle
            // 
            this.PnlTitle.Controls.Add(this.button2);
            this.PnlTitle.Controls.Add(this.button1);
            this.PnlTitle.Controls.Add(this.BtnExit);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(352, 40);
            this.PnlTitle.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(202, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 40);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(252, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 40);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(302, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(50, 40);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PnlHistory
            // 
            this.PnlHistory.Controls.Add(this.BtnClearHistory);
            this.PnlHistory.Controls.Add(this.RtBoxDisplayHistory);
            this.PnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlHistory.Location = new System.Drawing.Point(0, 554);
            this.PnlHistory.Margin = new System.Windows.Forms.Padding(0);
            this.PnlHistory.Name = "PnlHistory";
            this.PnlHistory.Size = new System.Drawing.Size(352, 5);
            this.PnlHistory.TabIndex = 1;
            // 
            // BtnClearHistory
            // 
            this.BtnClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnClearHistory.FlatAppearance.BorderSize = 0;
            this.BtnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnClearHistory.Image")));
            this.BtnClearHistory.Location = new System.Drawing.Point(0, -35);
            this.BtnClearHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClearHistory.Name = "BtnClearHistory";
            this.BtnClearHistory.Size = new System.Drawing.Size(352, 40);
            this.BtnClearHistory.TabIndex = 3;
            this.BtnClearHistory.UseVisualStyleBackColor = true;
            this.BtnClearHistory.Click += new System.EventHandler(this.BtnClearHistory_Click);
            // 
            // RtBoxDisplayHistory
            // 
            this.RtBoxDisplayHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.RtBoxDisplayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtBoxDisplayHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtBoxDisplayHistory.ForeColor = System.Drawing.Color.Silver;
            this.RtBoxDisplayHistory.Location = new System.Drawing.Point(0, 0);
            this.RtBoxDisplayHistory.Margin = new System.Windows.Forms.Padding(0);
            this.RtBoxDisplayHistory.Name = "RtBoxDisplayHistory";
            this.RtBoxDisplayHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.RtBoxDisplayHistory.Size = new System.Drawing.Size(352, 5);
            this.RtBoxDisplayHistory.TabIndex = 4;
            this.RtBoxDisplayHistory.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnMenu);
            this.panel1.Controls.Add(this.BtnHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 49);
            this.panel1.TabIndex = 2;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.Location = new System.Drawing.Point(0, 0);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(50, 49);
            this.BtnMenu.TabIndex = 2;
            this.BtnMenu.UseVisualStyleBackColor = true;
            // 
            // BtnHistory
            // 
            this.BtnHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnHistory.FlatAppearance.BorderSize = 0;
            this.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnHistory.Image")));
            this.BtnHistory.Location = new System.Drawing.Point(302, 0);
            this.BtnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(50, 49);
            this.BtnHistory.TabIndex = 0;
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // TxtDisplay2
            // 
            this.TxtDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay2.Font = new System.Drawing.Font("Gadugi", 16F);
            this.TxtDisplay2.ForeColor = System.Drawing.Color.Silver;
            this.TxtDisplay2.Location = new System.Drawing.Point(0, 89);
            this.TxtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay2.Multiline = true;
            this.TxtDisplay2.Name = "TxtDisplay2";
            this.TxtDisplay2.Size = new System.Drawing.Size(352, 25);
            this.TxtDisplay2.TabIndex = 3;
            this.TxtDisplay2.Text = "0";
            this.TxtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtDisplay1
            // 
            this.TxtDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay1.Font = new System.Drawing.Font("Gadugi", 32F, System.Drawing.FontStyle.Bold);
            this.TxtDisplay1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDisplay1.Location = new System.Drawing.Point(0, 114);
            this.TxtDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay1.Multiline = true;
            this.TxtDisplay1.Name = "TxtDisplay1";
            this.TxtDisplay1.Size = new System.Drawing.Size(352, 50);
            this.TxtDisplay1.TabIndex = 4;
            this.TxtDisplay1.Text = "0";
            this.TxtDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn9.BorderRadius = 20;
            this.Btn9.BorderSize = 0;
            this.Btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn9.FlatAppearance.BorderSize = 0;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn9.Location = new System.Drawing.Point(176, 331);
            this.Btn9.Margin = new System.Windows.Forms.Padding(0);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(85, 55);
            this.Btn9.TabIndex = 22;
            this.Btn9.Text = "9";
            this.Btn9.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnEquals.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.BtnEquals.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnEquals.BorderRadius = 20;
            this.BtnEquals.BorderSize = 0;
            this.BtnEquals.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnEquals.FlatAppearance.BorderSize = 0;
            this.BtnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquals.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold);
            this.BtnEquals.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEquals.Location = new System.Drawing.Point(261, 496);
            this.BtnEquals.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(85, 55);
            this.BtnEquals.TabIndex = 31;
            this.BtnEquals.Text = "=";
            this.BtnEquals.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEquals.UseVisualStyleBackColor = false;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // BtnDecimal
            // 
            this.BtnDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnDecimal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnDecimal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnDecimal.BorderRadius = 20;
            this.BtnDecimal.BorderSize = 0;
            this.BtnDecimal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnDecimal.FlatAppearance.BorderSize = 0;
            this.BtnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDecimal.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.BtnDecimal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDecimal.Location = new System.Drawing.Point(176, 496);
            this.BtnDecimal.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDecimal.Name = "BtnDecimal";
            this.BtnDecimal.Size = new System.Drawing.Size(85, 55);
            this.BtnDecimal.TabIndex = 34;
            this.BtnDecimal.Text = ",";
            this.BtnDecimal.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDecimal.UseVisualStyleBackColor = false;
            this.BtnDecimal.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn0.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn0.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn0.BorderRadius = 20;
            this.Btn0.BorderSize = 0;
            this.Btn0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn0.FlatAppearance.BorderSize = 0;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn0.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn0.Location = new System.Drawing.Point(91, 496);
            this.Btn0.Margin = new System.Windows.Forms.Padding(0);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(85, 55);
            this.Btn0.TabIndex = 33;
            this.Btn0.Text = "0";
            this.Btn0.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnPM
            // 
            this.BtnPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnPM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnPM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnPM.BorderRadius = 20;
            this.BtnPM.BorderSize = 0;
            this.BtnPM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnPM.FlatAppearance.BorderSize = 0;
            this.BtnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPM.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.BtnPM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPM.Location = new System.Drawing.Point(6, 496);
            this.BtnPM.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPM.Name = "BtnPM";
            this.BtnPM.Size = new System.Drawing.Size(85, 55);
            this.BtnPM.TabIndex = 32;
            this.BtnPM.Text = "+/-";
            this.BtnPM.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPM.UseVisualStyleBackColor = false;
            this.BtnPM.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn3.BorderRadius = 20;
            this.Btn3.BorderSize = 0;
            this.Btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn3.FlatAppearance.BorderSize = 0;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn3.Location = new System.Drawing.Point(176, 441);
            this.Btn3.Margin = new System.Windows.Forms.Padding(0);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(85, 55);
            this.Btn3.TabIndex = 30;
            this.Btn3.Text = "3";
            this.Btn3.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn2.BorderRadius = 20;
            this.Btn2.BorderSize = 0;
            this.Btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn2.Location = new System.Drawing.Point(91, 441);
            this.Btn2.Margin = new System.Windows.Forms.Padding(0);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(85, 55);
            this.Btn2.TabIndex = 29;
            this.Btn2.Text = "2";
            this.Btn2.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn1.BorderRadius = 20;
            this.Btn1.BorderSize = 0;
            this.Btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn1.FlatAppearance.BorderSize = 0;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn1.Location = new System.Drawing.Point(6, 441);
            this.Btn1.Margin = new System.Windows.Forms.Padding(0);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(85, 55);
            this.Btn1.TabIndex = 28;
            this.Btn1.Text = "1";
            this.Btn1.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnAdd.BorderRadius = 20;
            this.BtnAdd.BorderSize = 0;
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold);
            this.BtnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAdd.Location = new System.Drawing.Point(261, 441);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(85, 55);
            this.BtnAdd.TabIndex = 27;
            this.BtnAdd.Text = "+";
            this.BtnAdd.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnMathOpetation_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn6.BorderRadius = 20;
            this.Btn6.BorderSize = 0;
            this.Btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn6.FlatAppearance.BorderSize = 0;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn6.Location = new System.Drawing.Point(176, 386);
            this.Btn6.Margin = new System.Windows.Forms.Padding(0);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(85, 55);
            this.Btn6.TabIndex = 26;
            this.Btn6.Text = "6";
            this.Btn6.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn5.BorderRadius = 20;
            this.Btn5.BorderSize = 0;
            this.Btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn5.FlatAppearance.BorderSize = 0;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn5.Location = new System.Drawing.Point(91, 386);
            this.Btn5.Margin = new System.Windows.Forms.Padding(0);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(85, 55);
            this.Btn5.TabIndex = 25;
            this.Btn5.Text = "5";
            this.Btn5.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn4.BorderRadius = 20;
            this.Btn4.BorderSize = 0;
            this.Btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn4.FlatAppearance.BorderSize = 0;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn4.Location = new System.Drawing.Point(6, 386);
            this.Btn4.Margin = new System.Windows.Forms.Padding(0);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(85, 55);
            this.Btn4.TabIndex = 24;
            this.Btn4.Text = "4";
            this.Btn4.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnSub.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnSub.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnSub.BorderRadius = 20;
            this.BtnSub.BorderSize = 0;
            this.BtnSub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnSub.FlatAppearance.BorderSize = 0;
            this.BtnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSub.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold);
            this.BtnSub.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSub.Location = new System.Drawing.Point(261, 386);
            this.BtnSub.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(85, 55);
            this.BtnSub.TabIndex = 23;
            this.BtnSub.Text = "-";
            this.BtnSub.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSub.UseVisualStyleBackColor = false;
            this.BtnSub.Click += new System.EventHandler(this.BtnMathOpetation_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn8.BorderRadius = 20;
            this.Btn8.BorderSize = 0;
            this.Btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn8.FlatAppearance.BorderSize = 0;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn8.Location = new System.Drawing.Point(91, 331);
            this.Btn8.Margin = new System.Windows.Forms.Padding(0);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(85, 55);
            this.Btn8.TabIndex = 21;
            this.Btn8.Text = "8";
            this.Btn8.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn7.BorderRadius = 20;
            this.Btn7.BorderSize = 0;
            this.Btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn7.FlatAppearance.BorderSize = 0;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn7.Location = new System.Drawing.Point(6, 331);
            this.Btn7.Margin = new System.Windows.Forms.Padding(0);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(85, 55);
            this.Btn7.TabIndex = 20;
            this.Btn7.Text = "7";
            this.Btn7.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnMultiply.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnMultiply.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnMultiply.BorderRadius = 20;
            this.BtnMultiply.BorderSize = 0;
            this.BtnMultiply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnMultiply.FlatAppearance.BorderSize = 0;
            this.BtnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiply.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold);
            this.BtnMultiply.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMultiply.Location = new System.Drawing.Point(261, 331);
            this.BtnMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(85, 55);
            this.BtnMultiply.TabIndex = 19;
            this.BtnMultiply.Text = "X";
            this.BtnMultiply.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMultiply.UseVisualStyleBackColor = false;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMathOpetation_Click);
            // 
            // BtnSquare
            // 
            this.BtnSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnSquare.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnSquare.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnSquare.BorderRadius = 20;
            this.BtnSquare.BorderSize = 0;
            this.BtnSquare.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnSquare.FlatAppearance.BorderSize = 0;
            this.BtnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSquare.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSquare.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSquare.Location = new System.Drawing.Point(176, 276);
            this.BtnSquare.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSquare.Name = "BtnSquare";
            this.BtnSquare.Size = new System.Drawing.Size(85, 55);
            this.BtnSquare.TabIndex = 18;
            this.BtnSquare.Text = "√a";
            this.BtnSquare.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSquare.UseVisualStyleBackColor = false;
            this.BtnSquare.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // BtnX2
            // 
            this.BtnX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnX2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnX2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnX2.BorderRadius = 20;
            this.BtnX2.BorderSize = 0;
            this.BtnX2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnX2.FlatAppearance.BorderSize = 0;
            this.BtnX2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnX2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnX2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnX2.Location = new System.Drawing.Point(91, 276);
            this.BtnX2.Margin = new System.Windows.Forms.Padding(0);
            this.BtnX2.Name = "BtnX2";
            this.BtnX2.Size = new System.Drawing.Size(85, 55);
            this.BtnX2.TabIndex = 17;
            this.BtnX2.Text = "^2";
            this.BtnX2.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnX2.UseVisualStyleBackColor = false;
            this.BtnX2.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // Btn1X
            // 
            this.Btn1X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn1X.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn1X.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn1X.BorderRadius = 20;
            this.Btn1X.BorderSize = 0;
            this.Btn1X.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn1X.FlatAppearance.BorderSize = 0;
            this.Btn1X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1X.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1X.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn1X.Location = new System.Drawing.Point(6, 276);
            this.Btn1X.Margin = new System.Windows.Forms.Padding(0);
            this.Btn1X.Name = "Btn1X";
            this.Btn1X.Size = new System.Drawing.Size(85, 55);
            this.Btn1X.TabIndex = 16;
            this.Btn1X.Text = "1/x";
            this.Btn1X.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn1X.UseVisualStyleBackColor = false;
            this.Btn1X.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnDivision.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnDivision.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnDivision.BorderRadius = 20;
            this.BtnDivision.BorderSize = 0;
            this.BtnDivision.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnDivision.FlatAppearance.BorderSize = 0;
            this.BtnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDivision.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold);
            this.BtnDivision.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDivision.Location = new System.Drawing.Point(261, 276);
            this.BtnDivision.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(85, 55);
            this.BtnDivision.TabIndex = 15;
            this.BtnDivision.Text = "÷";
            this.BtnDivision.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDivision.UseVisualStyleBackColor = false;
            this.BtnDivision.Click += new System.EventHandler(this.BtnMathOpetation_Click);
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnC.BorderRadius = 20;
            this.BtnC.BorderSize = 0;
            this.BtnC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnC.FlatAppearance.BorderSize = 0;
            this.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnC.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnC.Location = new System.Drawing.Point(176, 221);
            this.BtnC.Margin = new System.Windows.Forms.Padding(0);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(85, 55);
            this.BtnC.TabIndex = 14;
            this.BtnC.Text = "C";
            this.BtnC.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnCE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnCE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnCE.BorderRadius = 20;
            this.BtnCE.BorderSize = 0;
            this.BtnCE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnCE.FlatAppearance.BorderSize = 0;
            this.BtnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCE.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCE.Location = new System.Drawing.Point(91, 221);
            this.BtnCE.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(85, 55);
            this.BtnCE.TabIndex = 13;
            this.BtnCE.Text = "CE";
            this.BtnCE.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCE.UseVisualStyleBackColor = false;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnPercent
            // 
            this.BtnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnPercent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnPercent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnPercent.BorderRadius = 20;
            this.BtnPercent.BorderSize = 0;
            this.BtnPercent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnPercent.FlatAppearance.BorderSize = 0;
            this.BtnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPercent.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPercent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPercent.Location = new System.Drawing.Point(6, 221);
            this.BtnPercent.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(85, 55);
            this.BtnPercent.TabIndex = 12;
            this.BtnPercent.Text = "%";
            this.BtnPercent.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPercent.UseVisualStyleBackColor = false;
            this.BtnPercent.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // artanButton7
            // 
            this.artanButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton7.BorderRadius = 15;
            this.artanButton7.BorderSize = 0;
            this.artanButton7.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.artanButton7.FlatAppearance.BorderSize = 0;
            this.artanButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton7.ForeColor = System.Drawing.Color.DarkGray;
            this.artanButton7.Location = new System.Drawing.Point(6, 185);
            this.artanButton7.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton7.Name = "artanButton7";
            this.artanButton7.Size = new System.Drawing.Size(50, 30);
            this.artanButton7.TabIndex = 11;
            this.artanButton7.Text = "MC";
            this.artanButton7.TextColor = System.Drawing.Color.DarkGray;
            this.artanButton7.UseVisualStyleBackColor = false;
            // 
            // artanButton6
            // 
            this.artanButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton6.BorderRadius = 15;
            this.artanButton6.BorderSize = 0;
            this.artanButton6.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.artanButton6.FlatAppearance.BorderSize = 0;
            this.artanButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton6.ForeColor = System.Drawing.Color.DarkGray;
            this.artanButton6.Location = new System.Drawing.Point(63, 185);
            this.artanButton6.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton6.Name = "artanButton6";
            this.artanButton6.Size = new System.Drawing.Size(50, 30);
            this.artanButton6.TabIndex = 10;
            this.artanButton6.Text = "MR";
            this.artanButton6.TextColor = System.Drawing.Color.DarkGray;
            this.artanButton6.UseVisualStyleBackColor = false;
            // 
            // artanButton5
            // 
            this.artanButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton5.BorderRadius = 15;
            this.artanButton5.BorderSize = 0;
            this.artanButton5.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.artanButton5.FlatAppearance.BorderSize = 0;
            this.artanButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton5.ForeColor = System.Drawing.Color.DarkGray;
            this.artanButton5.Location = new System.Drawing.Point(120, 185);
            this.artanButton5.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton5.Name = "artanButton5";
            this.artanButton5.Size = new System.Drawing.Size(50, 30);
            this.artanButton5.TabIndex = 9;
            this.artanButton5.Text = "M+";
            this.artanButton5.TextColor = System.Drawing.Color.DarkGray;
            this.artanButton5.UseVisualStyleBackColor = false;
            // 
            // artanButton4
            // 
            this.artanButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton4.BorderRadius = 15;
            this.artanButton4.BorderSize = 0;
            this.artanButton4.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.artanButton4.FlatAppearance.BorderSize = 0;
            this.artanButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton4.ForeColor = System.Drawing.Color.DarkGray;
            this.artanButton4.Location = new System.Drawing.Point(177, 185);
            this.artanButton4.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton4.Name = "artanButton4";
            this.artanButton4.Size = new System.Drawing.Size(50, 30);
            this.artanButton4.TabIndex = 8;
            this.artanButton4.Text = "M-";
            this.artanButton4.TextColor = System.Drawing.Color.DarkGray;
            this.artanButton4.UseVisualStyleBackColor = false;
            // 
            // artanButton3
            // 
            this.artanButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton3.BorderRadius = 15;
            this.artanButton3.BorderSize = 0;
            this.artanButton3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.artanButton3.FlatAppearance.BorderSize = 0;
            this.artanButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton3.ForeColor = System.Drawing.Color.DarkGray;
            this.artanButton3.Location = new System.Drawing.Point(234, 185);
            this.artanButton3.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton3.Name = "artanButton3";
            this.artanButton3.Size = new System.Drawing.Size(50, 30);
            this.artanButton3.TabIndex = 7;
            this.artanButton3.Text = "MS";
            this.artanButton3.TextColor = System.Drawing.Color.DarkGray;
            this.artanButton3.UseVisualStyleBackColor = false;
            // 
            // artanButton2
            // 
            this.artanButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton2.BorderRadius = 15;
            this.artanButton2.BorderSize = 0;
            this.artanButton2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.artanButton2.FlatAppearance.BorderSize = 0;
            this.artanButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton2.ForeColor = System.Drawing.Color.DarkGray;
            this.artanButton2.Location = new System.Drawing.Point(291, 185);
            this.artanButton2.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton2.Name = "artanButton2";
            this.artanButton2.Size = new System.Drawing.Size(50, 30);
            this.artanButton2.TabIndex = 6;
            this.artanButton2.Text = "M~";
            this.artanButton2.TextColor = System.Drawing.Color.DarkGray;
            this.artanButton2.UseVisualStyleBackColor = false;
            // 
            // BtnBackSpace
            // 
            this.BtnBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnBackSpace.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnBackSpace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnBackSpace.BorderRadius = 20;
            this.BtnBackSpace.BorderSize = 0;
            this.BtnBackSpace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnBackSpace.FlatAppearance.BorderSize = 0;
            this.BtnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackSpace.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackSpace.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBackSpace.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackSpace.Image")));
            this.BtnBackSpace.Location = new System.Drawing.Point(261, 221);
            this.BtnBackSpace.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBackSpace.Name = "BtnBackSpace";
            this.BtnBackSpace.Size = new System.Drawing.Size(85, 55);
            this.BtnBackSpace.TabIndex = 5;
            this.BtnBackSpace.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBackSpace.UseVisualStyleBackColor = false;
            this.BtnBackSpace.Click += new System.EventHandler(this.BtnBackSpace_Click);
            // 
            // ElipseForm
            // 
            this.ElipseForm.CornerRedius = 20;
            this.ElipseForm.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(352, 559);
            this.Controls.Add(this.PnlHistory);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.BtnDecimal);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnPM);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnSub);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.BtnSquare);
            this.Controls.Add(this.BtnX2);
            this.Controls.Add(this.Btn1X);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.artanButton7);
            this.Controls.Add(this.artanButton6);
            this.Controls.Add(this.artanButton5);
            this.Controls.Add(this.artanButton4);
            this.Controls.Add(this.artanButton3);
            this.Controls.Add(this.artanButton2);
            this.Controls.Add(this.BtnBackSpace);
            this.Controls.Add(this.TxtDisplay1);
            this.Controls.Add(this.TxtDisplay2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlTitle);
            this.Controls.Add(this.Btn5);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlTitle.ResumeLayout(false);
            this.PnlHistory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Panel PnlHistory;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.TextBox TxtDisplay2;
        private System.Windows.Forms.TextBox TxtDisplay1;
        private System.Windows.Forms.Button BtnClearHistory;
        private System.Windows.Forms.RichTextBox RtBoxDisplayHistory;
        private ArtanElipseControl ElipseForm;
        private ArtanButton BtnBackSpace;
        private ArtanButton artanButton7;
        private ArtanButton artanButton6;
        private ArtanButton artanButton5;
        private ArtanButton artanButton4;
        private ArtanButton artanButton3;
        private ArtanButton artanButton2;
        private ArtanButton BtnC;
        private ArtanButton BtnCE;
        private ArtanButton BtnPercent;
        private ArtanButton BtnSquare;
        private ArtanButton BtnX2;
        private ArtanButton Btn1X;
        private ArtanButton BtnDivision;
        private ArtanButton Btn6;
        private ArtanButton Btn5;
        private ArtanButton Btn4;
        private ArtanButton BtnSub;
        private ArtanButton Btn9;
        private ArtanButton Btn8;
        private ArtanButton Btn7;
        private ArtanButton BtnMultiply;
        private ArtanButton BtnDecimal;
        private ArtanButton Btn0;
        private ArtanButton BtnPM;
        private ArtanButton BtnEquals;
        private ArtanButton Btn3;
        private ArtanButton Btn2;
        private ArtanButton Btn1;
        private ArtanButton BtnAdd;
    }
}

