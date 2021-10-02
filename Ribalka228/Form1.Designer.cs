
namespace Ribalka228
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.patternLabel = new System.Windows.Forms.Label();
            this.positionShiftInterval = new System.Windows.Forms.TextBox();
            this.zoneShiftInterval = new System.Windows.Forms.TextBox();
            this.minZone = new System.Windows.Forms.TextBox();
            this.maxZone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.distanceError = new System.Windows.Forms.Label();
            this.prjamougolnik = new System.Windows.Forms.Button();
            this.fishButton = new System.Windows.Forms.Button();
            this.fishingBar = new System.Windows.Forms.ProgressBar();
            this.fishingDot = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dotMS = new System.Windows.Forms.TextBox();
            this.comparisonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(478, 250);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(156, 47);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // patternLabel
            // 
            this.patternLabel.AutoSize = true;
            this.patternLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patternLabel.Location = new System.Drawing.Point(533, 66);
            this.patternLabel.Name = "patternLabel";
            this.patternLabel.Size = new System.Drawing.Size(61, 20);
            this.patternLabel.TabIndex = 2;
            this.patternLabel.Text = "Pattern";
            this.patternLabel.Click += new System.EventHandler(this.patternLabel_Click);
            // 
            // positionShiftInterval
            // 
            this.positionShiftInterval.Location = new System.Drawing.Point(515, 99);
            this.positionShiftInterval.Name = "positionShiftInterval";
            this.positionShiftInterval.Size = new System.Drawing.Size(100, 20);
            this.positionShiftInterval.TabIndex = 3;
            this.positionShiftInterval.TextChanged += new System.EventHandler(this.positionShiftInterval_TextChanged);
            // 
            // zoneShiftInterval
            // 
            this.zoneShiftInterval.Location = new System.Drawing.Point(515, 125);
            this.zoneShiftInterval.Name = "zoneShiftInterval";
            this.zoneShiftInterval.Size = new System.Drawing.Size(100, 20);
            this.zoneShiftInterval.TabIndex = 4;
            this.zoneShiftInterval.TextChanged += new System.EventHandler(this.zoneShiftInterval_TextChanged);
            // 
            // minZone
            // 
            this.minZone.Location = new System.Drawing.Point(515, 151);
            this.minZone.Name = "minZone";
            this.minZone.Size = new System.Drawing.Size(100, 20);
            this.minZone.TabIndex = 5;
            this.minZone.TextChanged += new System.EventHandler(this.minZone_TextChanged);
            // 
            // maxZone
            // 
            this.maxZone.Location = new System.Drawing.Point(515, 177);
            this.maxZone.Name = "maxZone";
            this.maxZone.Size = new System.Drawing.Size(100, 20);
            this.maxZone.TabIndex = 6;
            this.maxZone.TextChanged += new System.EventHandler(this.maxZone_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Position shift interval (ms)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Zone shift interval (ms)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Min zone (> 15)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Max zone";
            // 
            // distanceError
            // 
            this.distanceError.AutoSize = true;
            this.distanceError.Font = new System.Drawing.Font("Segoe Script", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceError.ForeColor = System.Drawing.Color.Red;
            this.distanceError.Location = new System.Drawing.Point(-6, 48);
            this.distanceError.Name = "distanceError";
            this.distanceError.Size = new System.Drawing.Size(655, 106);
            this.distanceError.TabIndex = 11;
            this.distanceError.Text = "ТЫ ЕБЛАН ЧЕЕЛ";
            this.distanceError.Visible = false;
            // 
            // prjamougolnik
            // 
            this.prjamougolnik.Location = new System.Drawing.Point(12, 12);
            this.prjamougolnik.Name = "prjamougolnik";
            this.prjamougolnik.Size = new System.Drawing.Size(75, 23);
            this.prjamougolnik.TabIndex = 12;
            this.prjamougolnik.UseVisualStyleBackColor = true;
            this.prjamougolnik.Visible = false;
            // 
            // fishButton
            // 
            this.fishButton.Location = new System.Drawing.Point(12, 250);
            this.fishButton.Name = "fishButton";
            this.fishButton.Size = new System.Drawing.Size(156, 47);
            this.fishButton.TabIndex = 13;
            this.fishButton.Text = "Fish";
            this.fishButton.UseVisualStyleBackColor = true;
            this.fishButton.Visible = false;
            this.fishButton.Click += new System.EventHandler(this.rndButton_Click);
            // 
            // fishingBar
            // 
            this.fishingBar.Location = new System.Drawing.Point(12, 12);
            this.fishingBar.Name = "fishingBar";
            this.fishingBar.Size = new System.Drawing.Size(622, 23);
            this.fishingBar.TabIndex = 1;
            this.fishingBar.Visible = false;
            this.fishingBar.Click += new System.EventHandler(this.fishingBar_Click);
            // 
            // fishingDot
            // 
            this.fishingDot.AutoSize = true;
            this.fishingDot.BackColor = System.Drawing.Color.Transparent;
            this.fishingDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fishingDot.Location = new System.Drawing.Point(315, 12);
            this.fishingDot.Name = "fishingDot";
            this.fishingDot.Size = new System.Drawing.Size(14, 18);
            this.fishingDot.TabIndex = 14;
            this.fishingDot.Text = "•";
            this.fishingDot.Visible = false;
            this.fishingDot.Click += new System.EventHandler(this.fishingDot_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Dot MS";
            // 
            // dotMS
            // 
            this.dotMS.Location = new System.Drawing.Point(515, 203);
            this.dotMS.Name = "dotMS";
            this.dotMS.Size = new System.Drawing.Size(100, 20);
            this.dotMS.TabIndex = 18;
            this.dotMS.TextChanged += new System.EventHandler(this.dotMS_TextChanged);
            // 
            // comparisonLabel
            // 
            this.comparisonLabel.AutoSize = true;
            this.comparisonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comparisonLabel.ForeColor = System.Drawing.Color.Red;
            this.comparisonLabel.Location = new System.Drawing.Point(21, 134);
            this.comparisonLabel.Name = "comparisonLabel";
            this.comparisonLabel.Size = new System.Drawing.Size(100, 42);
            this.comparisonLabel.TabIndex = 19;
            this.comparisonLabel.Text = "OPA";
            this.comparisonLabel.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(647, 309);
            this.Controls.Add(this.comparisonLabel);
            this.Controls.Add(this.dotMS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fishingDot);
            this.Controls.Add(this.fishButton);
            this.Controls.Add(this.prjamougolnik);
            this.Controls.Add(this.distanceError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxZone);
            this.Controls.Add(this.minZone);
            this.Controls.Add(this.zoneShiftInterval);
            this.Controls.Add(this.positionShiftInterval);
            this.Controls.Add(this.patternLabel);
            this.Controls.Add(this.fishingBar);
            this.Controls.Add(this.startButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Ribalka kruto pog aaa xD xD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label patternLabel;
        private System.Windows.Forms.TextBox positionShiftInterval;
        private System.Windows.Forms.TextBox zoneShiftInterval;
        private System.Windows.Forms.TextBox minZone;
        private System.Windows.Forms.TextBox maxZone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label distanceError;
        private System.Windows.Forms.Button prjamougolnik;
        private System.Windows.Forms.Button fishButton;
        private System.Windows.Forms.ProgressBar fishingBar;
        private System.Windows.Forms.Label fishingDot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dotMS;
        private System.Windows.Forms.Label comparisonLabel;
    }
}

