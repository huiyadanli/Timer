namespace Timer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picTime5 = new System.Windows.Forms.PictureBox();
            this.picTime4 = new System.Windows.Forms.PictureBox();
            this.picTime3 = new System.Windows.Forms.PictureBox();
            this.picTime2 = new System.Windows.Forms.PictureBox();
            this.picTime1 = new System.Windows.Forms.PictureBox();
            this.picTime0 = new System.Windows.Forms.PictureBox();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.tmrEffect = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.rbtnCountUp = new System.Windows.Forms.RadioButton();
            this.rbtnCountDown = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.tmrCtrl = new System.Windows.Forms.Timer(this.components);
            this.tmrTimeDown = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picTime5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime0)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picTime5
            // 
            this.picTime5.Location = new System.Drawing.Point(25, 8);
            this.picTime5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTime5.Name = "picTime5";
            this.picTime5.Size = new System.Drawing.Size(83, 102);
            this.picTime5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTime5.TabIndex = 0;
            this.picTime5.TabStop = false;
            // 
            // picTime4
            // 
            this.picTime4.Location = new System.Drawing.Point(85, 8);
            this.picTime4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTime4.Name = "picTime4";
            this.picTime4.Size = new System.Drawing.Size(83, 102);
            this.picTime4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTime4.TabIndex = 0;
            this.picTime4.TabStop = false;
            // 
            // picTime3
            // 
            this.picTime3.Location = new System.Drawing.Point(211, 8);
            this.picTime3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTime3.Name = "picTime3";
            this.picTime3.Size = new System.Drawing.Size(83, 102);
            this.picTime3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTime3.TabIndex = 0;
            this.picTime3.TabStop = false;
            // 
            // picTime2
            // 
            this.picTime2.Location = new System.Drawing.Point(272, 8);
            this.picTime2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTime2.Name = "picTime2";
            this.picTime2.Size = new System.Drawing.Size(83, 102);
            this.picTime2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTime2.TabIndex = 0;
            this.picTime2.TabStop = false;
            // 
            // picTime1
            // 
            this.picTime1.BackColor = System.Drawing.SystemColors.Control;
            this.picTime1.Location = new System.Drawing.Point(399, 8);
            this.picTime1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTime1.Name = "picTime1";
            this.picTime1.Size = new System.Drawing.Size(83, 102);
            this.picTime1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTime1.TabIndex = 0;
            this.picTime1.TabStop = false;
            // 
            // picTime0
            // 
            this.picTime0.BackColor = System.Drawing.Color.Transparent;
            this.picTime0.Location = new System.Drawing.Point(459, 8);
            this.picTime0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTime0.Name = "picTime0";
            this.picTime0.Size = new System.Drawing.Size(83, 102);
            this.picTime0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTime0.TabIndex = 0;
            this.picTime0.TabStop = false;
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // tmrEffect
            // 
            this.tmrEffect.Tick += new System.EventHandler(this.tmrEffect_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(165, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 80);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(353, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 80);
            this.label2.TabIndex = 3;
            this.label2.Text = ":";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(52, 142);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 42);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(227, 142);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(116, 42);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(405, 142);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(116, 42);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // rbtnCountUp
            // 
            this.rbtnCountUp.AutoSize = true;
            this.rbtnCountUp.Checked = true;
            this.rbtnCountUp.Location = new System.Drawing.Point(205, 22);
            this.rbtnCountUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnCountUp.Name = "rbtnCountUp";
            this.rbtnCountUp.Size = new System.Drawing.Size(73, 19);
            this.rbtnCountUp.TabIndex = 0;
            this.rbtnCountUp.TabStop = true;
            this.rbtnCountUp.Text = "顺计时";
            this.rbtnCountUp.UseVisualStyleBackColor = true;
            this.rbtnCountUp.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnCountDown
            // 
            this.rbtnCountDown.AutoSize = true;
            this.rbtnCountDown.Location = new System.Drawing.Point(284, 22);
            this.rbtnCountDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnCountDown.Name = "rbtnCountDown";
            this.rbtnCountDown.Size = new System.Drawing.Size(73, 19);
            this.rbtnCountDown.TabIndex = 1;
            this.rbtnCountDown.Text = "倒计时";
            this.rbtnCountDown.UseVisualStyleBackColor = true;
            this.rbtnCountDown.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.picTime2);
            this.panel1.Controls.Add(this.picTime0);
            this.panel1.Controls.Add(this.picTime3);
            this.panel1.Controls.Add(this.picTime1);
            this.panel1.Controls.Add(this.picTime4);
            this.panel1.Controls.Add(this.picTime5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 216);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSec);
            this.panel2.Controls.Add(this.txtMin);
            this.panel2.Controls.Add(this.txtHour);
            this.panel2.Location = new System.Drawing.Point(5, 59);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 66);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "设定初始时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = ":";
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(373, 18);
            this.txtSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSec.MaxLength = 2;
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(36, 25);
            this.txtSec.TabIndex = 2;
            this.txtSec.Text = "00";
            this.txtSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSec.Click += new System.EventHandler(this.txt_Click);
            this.txtSec.Leave += new System.EventHandler(this.txt_Leave);
            this.txtSec.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            this.txtSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(307, 18);
            this.txtMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMin.MaxLength = 2;
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(36, 25);
            this.txtMin.TabIndex = 1;
            this.txtMin.Text = "00";
            this.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMin.Click += new System.EventHandler(this.txt_Click);
            this.txtMin.Leave += new System.EventHandler(this.txt_Leave);
            this.txtMin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            this.txtMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(241, 18);
            this.txtHour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHour.MaxLength = 2;
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(36, 25);
            this.txtHour.TabIndex = 0;
            this.txtHour.Text = "00";
            this.txtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHour.Click += new System.EventHandler(this.txt_Click);
            this.txtHour.Leave += new System.EventHandler(this.txt_Leave);
            this.txtHour.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            this.txtHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // tmrCtrl
            // 
            this.tmrCtrl.Interval = 10;
            this.tmrCtrl.Tick += new System.EventHandler(this.tmrCtrl_Tick);
            // 
            // tmrTimeDown
            // 
            this.tmrTimeDown.Interval = 1000;
            this.tmrTimeDown.Tick += new System.EventHandler(this.tmrTimeDown_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 259);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbtnCountDown);
            this.Controls.Add(this.rbtnCountUp);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(581, 372);
            this.MinimumSize = new System.Drawing.Size(581, 306);
            this.Name = "Form1";
            this.Text = "ホネホネ・计时器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            ((System.ComponentModel.ISupportInitialize)(this.picTime5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime0)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTime5;
        private System.Windows.Forms.PictureBox picTime4;
        private System.Windows.Forms.PictureBox picTime3;
        private System.Windows.Forms.PictureBox picTime2;
        private System.Windows.Forms.PictureBox picTime1;
        private System.Windows.Forms.PictureBox picTime0;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Timer tmrEffect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RadioButton rbtnCountUp;
        private System.Windows.Forms.RadioButton rbtnCountDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer tmrCtrl;
        private System.Windows.Forms.Timer tmrTimeDown;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

