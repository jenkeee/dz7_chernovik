
namespace SApp01
{
    partial class CounterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnplus = new System.Windows.Forms.Button();
            this.counter = new System.Windows.Forms.Label();
            this.counterChanger = new System.Windows.Forms.TextBox();
            this.btnX2 = new System.Windows.Forms.Button();
            this.steps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnplus
            // 
            this.btnplus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnplus.Location = new System.Drawing.Point(267, 10);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(138, 56);
            this.btnplus.TabIndex = 0;
            this.btnplus.Text = "Увеличить";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counter.Location = new System.Drawing.Point(3, 26);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(213, 26);
            this.counter.TabIndex = 1;
            this.counter.Text = "Текущее значение :";
            // 
            // counterChanger
            // 
            this.counterChanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counterChanger.Location = new System.Drawing.Point(17, 103);
            this.counterChanger.Name = "counterChanger";
            this.counterChanger.Size = new System.Drawing.Size(129, 31);
            this.counterChanger.TabIndex = 2;
            this.counterChanger.TextChanged += new System.EventHandler(this.textBoxCounter_TextChanged);
            // 
            // btnX2
            // 
            this.btnX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnX2.Location = new System.Drawing.Point(267, 78);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(138, 56);
            this.btnX2.TabIndex = 3;
            this.btnX2.Text = "Увеличить";
            this.btnX2.UseVisualStyleBackColor = true;
            this.btnX2.Click += new System.EventHandler(this.button1_Click);
            // 
            // steps
            // 
            this.steps.AutoSize = true;
            this.steps.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.steps.Location = new System.Drawing.Point(36, 52);
            this.steps.Name = "steps";
            this.steps.Size = new System.Drawing.Size(180, 26);
            this.steps.TabIndex = 4;
            this.steps.Text = "Сделано ходов :";
            this.steps.Click += new System.EventHandler(this.label1_Click);
            // 
            // CounterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.steps);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.counterChanger);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.btnplus);
            this.Name = "CounterControl";
            this.Size = new System.Drawing.Size(422, 155);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.TextBox counterChanger;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Label steps;
    }
}
