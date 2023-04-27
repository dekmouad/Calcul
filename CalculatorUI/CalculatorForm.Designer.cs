namespace CalculatorUI
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
            this.lblValue = new System.Windows.Forms.Label();
            this.lstEquals = new System.Windows.Forms.ListBox();
            this.Btnhistory = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnBS = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnOct = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnEx = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnHtan = new System.Windows.Forms.Button();
            this.btn1x = new System.Windows.Forms.Button();
            this.btnBin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnHcos = new System.Windows.Forms.Button();
            this.btnX3 = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnHsin = new System.Windows.Forms.Button();
            this.btnX2 = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientifiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblValue.Location = new System.Drawing.Point(12, 56);
            this.lblValue.Margin = new System.Windows.Forms.Padding(0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(163, 34);
            this.lblValue.TabIndex = 89;
            // 
            // lstEquals
            // 
            this.lstEquals.FormattingEnabled = true;
            this.lstEquals.ItemHeight = 20;
            this.lstEquals.Location = new System.Drawing.Point(15, 160);
            this.lstEquals.Name = "lstEquals";
            this.lstEquals.Size = new System.Drawing.Size(15, 4);
            this.lstEquals.TabIndex = 88;
            this.lstEquals.Visible = false;
            // 
            // Btnhistory
            // 
            this.Btnhistory.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnhistory.Location = new System.Drawing.Point(15, 103);
            this.Btnhistory.Name = "Btnhistory";
            this.Btnhistory.Size = new System.Drawing.Size(52, 55);
            this.Btnhistory.TabIndex = 87;
            this.Btnhistory.Text = "";
            this.Btnhistory.UseVisualStyleBackColor = true;
            this.Btnhistory.Click += new System.EventHandler(this.Btnhistory_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(264, 171);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(77, 76);
            this.btnDiv.TabIndex = 66;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.Actions);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(181, 496);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(77, 76);
            this.btnDot.TabIndex = 65;
            this.btnDot.Text = ",";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(98, 496);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(77, 76);
            this.btn0.TabIndex = 64;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Numbers);
            // 
            // btnPM
            // 
            this.btnPM.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPM.Location = new System.Drawing.Point(15, 496);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(77, 76);
            this.btnPM.TabIndex = 63;
            this.btnPM.Text = "±";
            this.btnPM.UseVisualStyleBackColor = true;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMult.Location = new System.Drawing.Point(264, 253);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(77, 76);
            this.btnMult.TabIndex = 62;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.Actions);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(181, 414);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(77, 76);
            this.btn3.TabIndex = 61;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Numbers);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(98, 414);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(77, 76);
            this.btn2.TabIndex = 60;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Numbers);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(15, 414);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(77, 76);
            this.btn1.TabIndex = 59;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Numbers);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(264, 332);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(77, 76);
            this.btnSub.TabIndex = 58;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.Actions);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(181, 332);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(77, 76);
            this.btn6.TabIndex = 57;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Numbers);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(98, 332);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(77, 76);
            this.btn5.TabIndex = 56;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Numbers);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(15, 332);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(77, 76);
            this.btn4.TabIndex = 55;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Numbers);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(264, 414);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 76);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Actions);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(181, 253);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(77, 76);
            this.btn9.TabIndex = 53;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Numbers);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(98, 253);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(77, 76);
            this.btn8.TabIndex = 52;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Numbers);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(15, 253);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(77, 76);
            this.btn7.TabIndex = 51;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Numbers);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(264, 496);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(77, 76);
            this.btnEquals.TabIndex = 50;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(181, 171);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 76);
            this.btnClear.TabIndex = 49;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEntry.Location = new System.Drawing.Point(98, 171);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(77, 76);
            this.btnClearEntry.TabIndex = 48;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtValue.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.txtValue.Location = new System.Drawing.Point(15, 103);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(726, 61);
            this.txtValue.TabIndex = 47;
            this.txtValue.Text = "0";
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBS
            // 
            this.btnBS.Font = new System.Drawing.Font("Wingdings", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnBS.Location = new System.Drawing.Point(15, 172);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(77, 76);
            this.btnBS.TabIndex = 46;
            this.btnBS.Text = "";
            this.btnBS.UseVisualStyleBackColor = true;
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.Location = new System.Drawing.Point(195, 56);
            this.lblResult.Margin = new System.Windows.Forms.Padding(0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(146, 34);
            this.lblResult.TabIndex = 89;
            // 
            // btnPercent
            // 
            this.btnPercent.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPercent.Location = new System.Drawing.Point(664, 496);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(77, 76);
            this.btnPercent.TabIndex = 109;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnOct
            // 
            this.btnOct.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOct.Location = new System.Drawing.Point(581, 495);
            this.btnOct.Name = "btnOct";
            this.btnOct.Size = new System.Drawing.Size(77, 76);
            this.btnOct.TabIndex = 108;
            this.btnOct.Text = "Oct";
            this.btnOct.UseVisualStyleBackColor = true;
            this.btnOct.Click += new System.EventHandler(this.btnOct_Click);
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMod.Location = new System.Drawing.Point(498, 496);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(77, 76);
            this.btnMod.TabIndex = 107;
            this.btnMod.Text = "!";
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btnEx
            // 
            this.btnEx.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEx.Location = new System.Drawing.Point(415, 496);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(77, 76);
            this.btnEx.TabIndex = 106;
            this.btnEx.Text = "e";
            this.btnEx.UseVisualStyleBackColor = true;
            // 
            // btnLn
            // 
            this.btnLn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLn.Location = new System.Drawing.Point(664, 414);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(77, 76);
            this.btnLn.TabIndex = 105;
            this.btnLn.Text = "ln x";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnHex
            // 
            this.btnHex.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHex.Location = new System.Drawing.Point(581, 414);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(77, 76);
            this.btnHex.TabIndex = 104;
            this.btnHex.Text = "Hex";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // btnTan
            // 
            this.btnTan.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTan.Location = new System.Drawing.Point(498, 414);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(77, 76);
            this.btnTan.TabIndex = 103;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnHtan
            // 
            this.btnHtan.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHtan.Location = new System.Drawing.Point(415, 414);
            this.btnHtan.Name = "btnHtan";
            this.btnHtan.Size = new System.Drawing.Size(77, 76);
            this.btnHtan.TabIndex = 102;
            this.btnHtan.Text = "Tanh";
            this.btnHtan.UseVisualStyleBackColor = true;
            this.btnHtan.Click += new System.EventHandler(this.btnHtan_Click);
            // 
            // btn1x
            // 
            this.btn1x.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1x.Location = new System.Drawing.Point(664, 332);
            this.btn1x.Name = "btn1x";
            this.btn1x.Size = new System.Drawing.Size(77, 76);
            this.btn1x.TabIndex = 101;
            this.btn1x.Text = "1/x";
            this.btn1x.UseVisualStyleBackColor = true;
            this.btn1x.Click += new System.EventHandler(this.btn1x_Click);
            // 
            // btnBin
            // 
            this.btnBin.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBin.Location = new System.Drawing.Point(581, 332);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(77, 76);
            this.btnBin.TabIndex = 100;
            this.btnBin.Text = "Bin";
            this.btnBin.UseVisualStyleBackColor = true;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btnCos
            // 
            this.btnCos.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCos.Location = new System.Drawing.Point(498, 332);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(77, 76);
            this.btnCos.TabIndex = 99;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnHcos
            // 
            this.btnHcos.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHcos.Location = new System.Drawing.Point(415, 332);
            this.btnHcos.Name = "btnHcos";
            this.btnHcos.Size = new System.Drawing.Size(77, 76);
            this.btnHcos.TabIndex = 98;
            this.btnHcos.Text = "Cosh";
            this.btnHcos.UseVisualStyleBackColor = true;
            this.btnHcos.Click += new System.EventHandler(this.btnHcos_Click);
            // 
            // btnX3
            // 
            this.btnX3.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX3.Location = new System.Drawing.Point(664, 252);
            this.btnX3.Name = "btnX3";
            this.btnX3.Size = new System.Drawing.Size(77, 76);
            this.btnX3.TabIndex = 97;
            this.btnX3.Text = "x³";
            this.btnX3.UseVisualStyleBackColor = true;
            this.btnX3.Click += new System.EventHandler(this.btnX3_Click);
            // 
            // btnDec
            // 
            this.btnDec.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDec.Location = new System.Drawing.Point(581, 252);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(77, 76);
            this.btnDec.TabIndex = 96;
            this.btnDec.Text = "Dec";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnSin
            // 
            this.btnSin.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSin.Location = new System.Drawing.Point(498, 252);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(77, 76);
            this.btnSin.TabIndex = 95;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnHsin
            // 
            this.btnHsin.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHsin.Location = new System.Drawing.Point(415, 252);
            this.btnHsin.Name = "btnHsin";
            this.btnHsin.Size = new System.Drawing.Size(77, 76);
            this.btnHsin.TabIndex = 94;
            this.btnHsin.Text = "Sinh";
            this.btnHsin.UseVisualStyleBackColor = true;
            this.btnHsin.Click += new System.EventHandler(this.btnHsin_Click);
            // 
            // btnX2
            // 
            this.btnX2.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX2.Location = new System.Drawing.Point(664, 170);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(77, 76);
            this.btnX2.TabIndex = 93;
            this.btnX2.Text = "x²";
            this.btnX2.UseVisualStyleBackColor = true;
            this.btnX2.Click += new System.EventHandler(this.btnX2_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.Location = new System.Drawing.Point(581, 170);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(77, 76);
            this.btnSqrt.TabIndex = 92;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLog.Location = new System.Drawing.Point(498, 170);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(77, 76);
            this.btnLog.TabIndex = 91;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnPi
            // 
            this.btnPi.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPi.Location = new System.Drawing.Point(415, 170);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(77, 76);
            this.btnPi.TabIndex = 90;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 45);
            this.menuStrip1.TabIndex = 110;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standartToolStripMenuItem,
            this.scientifiqueToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(79, 41);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.standartToolStripMenuItem_Click);
            // 
            // standartToolStripMenuItem
            // 
            this.standartToolStripMenuItem.Name = "standartToolStripMenuItem";
            this.standartToolStripMenuItem.Size = new System.Drawing.Size(269, 46);
            this.standartToolStripMenuItem.Text = "Standart";
            // 
            // scientifiqueToolStripMenuItem
            // 
            this.scientifiqueToolStripMenuItem.Name = "scientifiqueToolStripMenuItem";
            this.scientifiqueToolStripMenuItem.Size = new System.Drawing.Size(269, 46);
            this.scientifiqueToolStripMenuItem.Text = "Scientifique";
            this.scientifiqueToolStripMenuItem.Click += new System.EventHandler(this.scientifiqueToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(269, 46);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(269, 46);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(756, 583);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnOct);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnEx);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnHtan);
            this.Controls.Add(this.btn1x);
            this.Controls.Add(this.btnBin);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnHcos);
            this.Controls.Add(this.btnX3);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnHsin);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lstEquals);
            this.Controls.Add(this.Btnhistory);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnBS);
            this.Name = "CalculatorForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.ListBox lstEquals;
        private System.Windows.Forms.Button Btnhistory;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnBS;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnOct;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnEx;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnHtan;
        private System.Windows.Forms.Button btn1x;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnHcos;
        private System.Windows.Forms.Button btnX3;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnHsin;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientifiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

