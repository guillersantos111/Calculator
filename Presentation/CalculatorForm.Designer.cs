namespace Calculator
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
            this.TB_DISPLAY = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_DOT = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BTN_0 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BTN_THREE = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BTN_TWO = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BTN_ONE = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BTN_SIX = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BTN_FIVE = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BTN_FOUR = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BTN_NINE = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BTN_EIGHT = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BTN_SEVEN = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BTN_EQUALS = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BTN_MINOS = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BTN_MULTIPLY = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BTN_PLUS = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BTN_DIVIDE = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BTN_DELETE = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BTN_CLEAR = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.LBL_DISPLAYRESULT = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_DISPLAY
            // 
            this.TB_DISPLAY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_DISPLAY.Location = new System.Drawing.Point(3, 3);
            this.TB_DISPLAY.Multiline = true;
            this.TB_DISPLAY.Name = "TB_DISPLAY";
            this.TB_DISPLAY.Size = new System.Drawing.Size(351, 139);
            this.TB_DISPLAY.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.TB_DISPLAY.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.TB_DISPLAY.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TB_DISPLAY.StateCommon.Border.Rounding = 20;
            this.TB_DISPLAY.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.TB_DISPLAY.StateCommon.Content.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DISPLAY.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 40, -1, -1);
            this.TB_DISPLAY.TabIndex = 1;
            this.TB_DISPLAY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TB_DISPLAY.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.BTN_DOT);
            this.panel1.Controls.Add(this.BTN_0);
            this.panel1.Controls.Add(this.BTN_THREE);
            this.panel1.Controls.Add(this.BTN_TWO);
            this.panel1.Controls.Add(this.BTN_ONE);
            this.panel1.Controls.Add(this.BTN_SIX);
            this.panel1.Controls.Add(this.BTN_FIVE);
            this.panel1.Controls.Add(this.BTN_FOUR);
            this.panel1.Controls.Add(this.BTN_NINE);
            this.panel1.Controls.Add(this.BTN_EIGHT);
            this.panel1.Controls.Add(this.BTN_SEVEN);
            this.panel1.Controls.Add(this.BTN_EQUALS);
            this.panel1.Controls.Add(this.BTN_MINOS);
            this.panel1.Controls.Add(this.BTN_MULTIPLY);
            this.panel1.Controls.Add(this.BTN_PLUS);
            this.panel1.Controls.Add(this.BTN_DIVIDE);
            this.panel1.Controls.Add(this.BTN_DELETE);
            this.panel1.Controls.Add(this.BTN_CLEAR);
            this.panel1.Location = new System.Drawing.Point(1, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 419);
            this.panel1.TabIndex = 2;
            // 
            // BTN_DOT
            // 
            this.BTN_DOT.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.BTN_DOT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_DOT.Location = new System.Drawing.Point(185, 341);
            this.BTN_DOT.Name = "BTN_DOT";
            this.BTN_DOT.Size = new System.Drawing.Size(71, 66);
            this.BTN_DOT.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_DOT.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BTN_DOT.StateCommon.Border.Rounding = 10;
            this.BTN_DOT.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.LightGreen;
            this.BTN_DOT.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DOT.TabIndex = 19;
            this.BTN_DOT.Values.Text = ".";
            this.BTN_DOT.Click += new System.EventHandler(this.BTN_NUMBERANDDOT);
            // 
            // BTN_0
            // 
            this.BTN_0.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.BTN_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_0.Location = new System.Drawing.Point(11, 341);
            this.BTN_0.Name = "BTN_0";
            this.BTN_0.Size = new System.Drawing.Size(158, 66);
            this.BTN_0.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_0.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BTN_0.StateCommon.Border.Rounding = 10;
            this.BTN_0.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.LightGreen;
            this.BTN_0.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_0.TabIndex = 18;
            this.BTN_0.Values.Text = "0";
            this.BTN_0.Click += new System.EventHandler(this.BTN_NUMBERANDDOT);
            // 
            // BTN_THREE
            // 
            this.BTN_THREE.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.BTN_THREE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_THREE.Location = new System.Drawing.Point(185, 259);
            this.BTN_THREE.Name = "BTN_THREE";
            this.BTN_THREE.Size = new System.Drawing.Size(71, 66);
            this.BTN_THREE.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_THREE.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BTN_THREE.StateCommon.Border.Rounding = 10;
            this.BTN_THREE.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.LightGreen;
            this.BTN_THREE.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_THREE.TabIndex = 16;
            this.BTN_THREE.Values.Text = "3";
            this.BTN_THREE.Click += new System.EventHandler(this.BTN_NUMBERANDDOT);
            // 
            // BTN_TWO
            // 
            this.BTN_TWO.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.BTN_TWO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_TWO.Location = new System.Drawing.Point(98, 259);
            this.BTN_TWO.Name = "BTN_TWO";
            this.BTN_TWO.Size = new System.Drawing.Size(71, 66);
            this.BTN_TWO.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_TWO.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BTN_TWO.StateCommon.Border.Rounding = 10;
            this.BTN_TWO.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.LightGreen;
            this.BTN_TWO.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_TWO.TabIndex = 15;
            this.BTN_TWO.Values.Text = "2";
            this.BTN_TWO.Click += new System.EventHandler(this.BTN_NUMBERANDDOT);
            // 
            // BTN_ONE
            // 
            this.BTN_ONE.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.BTN_ONE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ONE.Location = new System.Drawing.Point(11, 259);
            this.BTN_ONE.Name = "BTN_ONE";
            this.BTN_ONE.Size = new System.Drawing.Size(71, 66);
            this.BTN_ONE.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_ONE.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BTN_ONE.StateCommon.Border.Rounding = 10;
            this.BTN_ONE.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.LightGreen;
            this.BTN_ONE.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ONE.TabIndex = 14;
            this.BTN_ONE.Values.Text = "1";
            this.BTN_ONE.Click += new System.EventHandler(this.BTN_NUMBERANDDOT);
            // 
            // BTN_SIX
            // 
            this.BTN_SIX.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.BTN_SIX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SIX.Location = new System.Drawing.Point(185, 176);
            this.BTN_SIX.Name = "BTN_SIX";
            this.BTN_SIX.Size = new System.Drawing.Size(71, 66);
            this.BTN_SIX.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_SIX.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BTN_SIX.StateCommon.Border.Rounding = 10;
            this.BTN_SIX.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.LightGreen;
            this.BTN_SIX.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SIX.TabIndex = 13;
            this.BTN_SIX.Values.Text = "6";
            this.BTN_SIX.Click += new System.EventHandler(this.BTN_NUMBERANDDOT);
            // 
            // BTN_FIVE
            // 
            this.BTN_FIVE.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.BTN_FIVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_FIVE.Location = new System.Drawing.Point(98, 176);
            this.BTN_FIVE.Name = "BTN_FIVE";
            this.BTN_FIVE.Size = new System.Drawing.Size(71, 66);
            this.BTN_FIVE.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_FIVE.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BTN_FIVE.StateCommon.Border.Rounding = 10;
            this.BTN_FIVE.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.LightGreen;
            this.BTN_FIVE.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FIVE.TabIndex = 12;
            this.BTN_FIVE.Values.Text = "5";
            this.BTN_FIVE.Click += new System.EventHandler(this.BTN_NUMBERANDDOT);
            // 
            // BTN_FOUR
            // 
            this.BTN_FOUR.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.BTN_FOUR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_FOUR.Location = new System.Drawing.Point(11, 176);
            this.BTN_FOUR.Name = "BTN_FOUR";
            this.BTN_FOUR.Size = new System.Drawing.Size(71, 66);
            this.BTN_FOUR.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_FOUR.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BTN_FOUR.StateCommon.Border.Rounding = 10;
            this.BTN_FOUR.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.LightGreen;
            this.BTN_FOUR.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FOUR.TabIndex = 11;
            this.BTN_FOUR.Values.Text = "4";
            this.BTN_FOUR.Click += new System.EventHandler(this.BTN_NUMBERANDDOT);
            // 
            // BTN_NINE
            // 
            this.BTN_NINE.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.BTN_NINE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_NINE.Location = new System.Drawing.Point(185, 94);
            this.BTN_NINE.Name = "BTN_NINE";
            this.BTN_NINE.Size = new System.Drawing.Size(71, 66);
            this.BTN_NINE.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_NINE.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BTN_NINE.StateCommon.Border.Rounding = 10;
            this.BTN_NINE.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.LightGreen;
            this.BTN_NINE.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NINE.TabIndex = 10;
            this.BTN_NINE.Values.Text = "9";
            this.BTN_NINE.Click += new System.EventHandler(this.BTN_NUMBERANDDOT);
            // 
            // BTN_EIGHT
            // 
            this.BTN_EIGHT.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.BTN_EIGHT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_EIGHT.Location = new System.Drawing.Point(98, 94);
            this.BTN_EIGHT.Name = "BTN_EIGHT";
            this.BTN_EIGHT.Size = new System.Drawing.Size(71, 66);
            this.BTN_EIGHT.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_EIGHT.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BTN_EIGHT.StateCommon.Border.Rounding = 10;
            this.BTN_EIGHT.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.LightGreen;
            this.BTN_EIGHT.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EIGHT.TabIndex = 9;
            this.BTN_EIGHT.Values.Text = "8";
            this.BTN_EIGHT.Click += new System.EventHandler(this.BTN_NUMBERANDDOT);
            // 
            // BTN_SEVEN
            // 
            this.BTN_SEVEN.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.BTN_SEVEN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SEVEN.Location = new System.Drawing.Point(11, 94);
            this.BTN_SEVEN.Name = "BTN_SEVEN";
            this.BTN_SEVEN.Size = new System.Drawing.Size(71, 66);
            this.BTN_SEVEN.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_SEVEN.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BTN_SEVEN.StateCommon.Border.Rounding = 10;
            this.BTN_SEVEN.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.LightGreen;
            this.BTN_SEVEN.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SEVEN.TabIndex = 8;
            this.BTN_SEVEN.Values.Text = "7";
            this.BTN_SEVEN.Click += new System.EventHandler(this.BTN_NUMBERANDDOT);
            // 
            // BTN_EQUALS
            // 
            this.BTN_EQUALS.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.BTN_EQUALS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_EQUALS.Location = new System.Drawing.Point(272, 341);
            this.BTN_EQUALS.Name = "BTN_EQUALS";
            this.BTN_EQUALS.Size = new System.Drawing.Size(71, 66);
            this.BTN_EQUALS.StateCommon.Back.Color1 = System.Drawing.Color.DarkGreen;
            this.BTN_EQUALS.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BTN_EQUALS.StateCommon.Border.Rounding = 10;
            this.BTN_EQUALS.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.LightGreen;
            this.BTN_EQUALS.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EQUALS.TabIndex = 7;
            this.BTN_EQUALS.Values.Text = "=";
            this.BTN_EQUALS.Click += new System.EventHandler(this.BTN_EQUALS_Click);
            // 
            // BTN_MINOS
            // 
            this.BTN_MINOS.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.BTN_MINOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_MINOS.Location = new System.Drawing.Point(272, 259);
            this.BTN_MINOS.Name = "BTN_MINOS";
            this.BTN_MINOS.Size = new System.Drawing.Size(71, 66);
            this.BTN_MINOS.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_MINOS.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BTN_MINOS.StateCommon.Border.Rounding = 10;
            this.BTN_MINOS.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.LightGreen;
            this.BTN_MINOS.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_MINOS.TabIndex = 6;
            this.BTN_MINOS.Values.Text = "-";
            this.BTN_MINOS.Click += new System.EventHandler(this.BTN_OPERATORS_CLICK);
            // 
            // BTN_MULTIPLY
            // 
            this.BTN_MULTIPLY.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.BTN_MULTIPLY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_MULTIPLY.Location = new System.Drawing.Point(272, 176);
            this.BTN_MULTIPLY.Name = "BTN_MULTIPLY";
            this.BTN_MULTIPLY.Size = new System.Drawing.Size(71, 66);
            this.BTN_MULTIPLY.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_MULTIPLY.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BTN_MULTIPLY.StateCommon.Border.Rounding = 10;
            this.BTN_MULTIPLY.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.LightGreen;
            this.BTN_MULTIPLY.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_MULTIPLY.TabIndex = 5;
            this.BTN_MULTIPLY.Values.Text = "x";
            this.BTN_MULTIPLY.Click += new System.EventHandler(this.BTN_OPERATORS_CLICK);
            // 
            // BTN_PLUS
            // 
            this.BTN_PLUS.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.BTN_PLUS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_PLUS.Location = new System.Drawing.Point(272, 94);
            this.BTN_PLUS.Name = "BTN_PLUS";
            this.BTN_PLUS.Size = new System.Drawing.Size(71, 66);
            this.BTN_PLUS.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_PLUS.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BTN_PLUS.StateCommon.Border.Rounding = 10;
            this.BTN_PLUS.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.LightGreen;
            this.BTN_PLUS.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PLUS.TabIndex = 4;
            this.BTN_PLUS.Values.Text = "+";
            this.BTN_PLUS.Click += new System.EventHandler(this.BTN_OPERATORS_CLICK);
            // 
            // BTN_DIVIDE
            // 
            this.BTN_DIVIDE.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.BTN_DIVIDE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_DIVIDE.Location = new System.Drawing.Point(272, 12);
            this.BTN_DIVIDE.Name = "BTN_DIVIDE";
            this.BTN_DIVIDE.Size = new System.Drawing.Size(71, 66);
            this.BTN_DIVIDE.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_DIVIDE.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BTN_DIVIDE.StateCommon.Border.Rounding = 10;
            this.BTN_DIVIDE.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.LightGreen;
            this.BTN_DIVIDE.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DIVIDE.TabIndex = 3;
            this.BTN_DIVIDE.Values.Text = "÷";
            this.BTN_DIVIDE.Click += new System.EventHandler(this.BTN_OPERATORS_CLICK);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.BTN_DELETE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_DELETE.Location = new System.Drawing.Point(185, 12);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(71, 66);
            this.BTN_DELETE.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_DELETE.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BTN_DELETE.StateCommon.Border.Rounding = 10;
            this.BTN_DELETE.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.LightGreen;
            this.BTN_DELETE.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DELETE.TabIndex = 2;
            this.BTN_DELETE.Values.Image = global::Calculator.Properties.Resources.icons8_home_button_40;
            this.BTN_DELETE.Values.Text = "";
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // BTN_CLEAR
            // 
            this.BTN_CLEAR.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.BTN_CLEAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CLEAR.Location = new System.Drawing.Point(11, 12);
            this.BTN_CLEAR.Name = "BTN_CLEAR";
            this.BTN_CLEAR.Size = new System.Drawing.Size(158, 66);
            this.BTN_CLEAR.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_CLEAR.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BTN_CLEAR.StateCommon.Border.Rounding = 10;
            this.BTN_CLEAR.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.BTN_CLEAR.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLEAR.TabIndex = 0;
            this.BTN_CLEAR.Values.Text = "C";
            this.BTN_CLEAR.Click += new System.EventHandler(this.BTN_CLEAR_Click);
            // 
            // LBL_DISPLAYRESULT
            // 
            this.LBL_DISPLAYRESULT.AutoSize = true;
            this.LBL_DISPLAYRESULT.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DISPLAYRESULT.ForeColor = System.Drawing.Color.White;
            this.LBL_DISPLAYRESULT.Location = new System.Drawing.Point(12, 100);
            this.LBL_DISPLAYRESULT.Name = "LBL_DISPLAYRESULT";
            this.LBL_DISPLAYRESULT.Size = new System.Drawing.Size(0, 32);
            this.LBL_DISPLAYRESULT.TabIndex = 3;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(356, 568);
            this.Controls.Add(this.LBL_DISPLAYRESULT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TB_DISPLAY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TB_DISPLAY;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BTN_CLEAR;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BTN_DIVIDE;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BTN_DELETE;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BTN_DOT;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BTN_0;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BTN_THREE;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BTN_TWO;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BTN_ONE;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BTN_SIX;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BTN_FIVE;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BTN_FOUR;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BTN_NINE;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BTN_EIGHT;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BTN_SEVEN;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BTN_EQUALS;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BTN_MINOS;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BTN_MULTIPLY;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BTN_PLUS;
        private System.Windows.Forms.Label LBL_DISPLAYRESULT;
    }
}

