
namespace SApp01
{
    partial class MainForm
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
            this.resetCounterButton = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MainMenu_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.needNUM = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.counterControl1 = new SApp01.CounterControl();
            this.MainMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetCounterButton
            // 
            this.resetCounterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetCounterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetCounterButton.Location = new System.Drawing.Point(743, 469);
            this.resetCounterButton.Name = "resetCounterButton";
            this.resetCounterButton.Size = new System.Drawing.Size(178, 41);
            this.resetCounterButton.TabIndex = 1;
            this.resetCounterButton.Text = "Сбросить счетчик";
            this.resetCounterButton.UseVisualStyleBackColor = true;
            this.resetCounterButton.Click += new System.EventHandler(this.resetCounterButton_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu_1,
            this.MainMenu_2});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(933, 24);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MainMenu_1
            // 
            this.MainMenu_1.Name = "MainMenu_1";
            this.MainMenu_1.Size = new System.Drawing.Size(57, 20);
            this.MainMenu_1.Text = "Играть";
            this.MainMenu_1.Click += new System.EventHandler(this.MainMenu_1_Click);
            // 
            // MainMenu_2
            // 
            this.MainMenu_2.Name = "MainMenu_2";
            this.MainMenu_2.Size = new System.Drawing.Size(142, 20);
            this.MainMenu_2.Text = "Выйти из приложения";
            // 
            // needNUM
            // 
            this.needNUM.AutoSize = true;
            this.needNUM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.needNUM.Location = new System.Drawing.Point(376, 53);
            this.needNUM.Name = "needNUM";
            this.needNUM.Size = new System.Drawing.Size(180, 26);
            this.needNUM.TabIndex = 3;
            this.needNUM.Text = "Эту цифру нам надо поймать";
            this.needNUM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.needNUM, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 193);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 133);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // counterControl1
            // 
            this.counterControl1.Counter = 0;
            this.counterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.counterControl1.Location = new System.Drawing.Point(0, 24);
            this.counterControl1.Name = "counterControl1";
            this.counterControl1.Size = new System.Drawing.Size(933, 150);
            this.counterControl1.TabIndex = 0;
            this.counterControl1.Target = 0;
            this.counterControl1.CounterEvent += new System.EventHandler<SApp01.CounterEventArgs>(this.counterControl1_CounterEvent);
            this.counterControl1.Load += new System.EventHandler(this.counterControl1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 522);
            this.Controls.Add(this.resetCounterButton);
            this.Controls.Add(this.counterControl1);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CounterControl counterControl1;
        private System.Windows.Forms.Button resetCounterButton;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_1;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_2;
        private System.Windows.Forms.Label needNUM;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}