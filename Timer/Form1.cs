/**********************************************
 *
 *    Created by huiyadanli at 2015.3.22
 *
 *        E-mail:huiyadanli@126.com
 *
 **********************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        #region 变量及初始化

        List<PictureBox> allPicBox = new List<PictureBox>(); //picturebox泛型声明
        Bitmap[] numPic = new Bitmap[320]; //存放动画素材
        System.Windows.Forms.Timer[] tmr = new System.Windows.Forms.Timer[6]; //6个Timer用于播放动画


        int[] startFrame = new int[6]; //储存动画的开始帧
        int[] endFrame = new int[6]; //储存动画的结束帧

        int[] frames = new int[20];  //保存各个数字所在的帧数
        int[] frameInterval = new int[20];  //两个数字之间间隔多少帧

        int[] myTime = new int[6]; //存放时间
        int timeCount = 6; //用于程序打开时的开场特效
        int elapsed = 0;  //用于窗体特效(下拉窗体)
        bool first = true;  //判断是否第一次进行计时
        bool[] tmrIsRuning = new bool[6];  //控制动画的Timer是否在运行

        Point formLocationNow;

        public Form1()
        {
            InitializeComponent();
            //myTime[0] = 8;
            //myTime[1] = 5;
            //myTime[2] = 9;
            //myTime[3] = 5;
            //myTime[4] = 9;
            //myTime[5] = 9;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formLocationNow = this.Location;

            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;

            //pictruebox组初始化
            allPicBox.AddRange(new PictureBox[] { picTime0, picTime1, picTime2, picTime3, picTime4, picTime5 });
            //计算好帧数
            FrameInit();

            for (int i = 0; i < 198; i++) //载入素材
            {
                numPic[i] = new Bitmap(Application.StartupPath + "\\Frame\\Frame_" + i.ToString() + ".png");
                numPic[i].MakeTransparent(numPic[i].GetPixel(0, 0)); //背景透明化
            }
            for (int i = 198; i < 320; i++) //载入素材
            {
                numPic[i] = numPic[i - 151];
            }
            //开场效果
            tmrEffect.Interval = 100;
            tmrEffect.Enabled = true;

            tmrCtrl.Enabled = true;
        }

        private void FrameInit() //写入帧数数据
        {
            frames[0] = 0;
            frames[1] = 46;
            frames[2] = 62;
            frames[3] = 72;
            frames[4] = 91;
            frames[5] = 117;
            frames[6] = 127;
            frames[7] = 147;
            frames[8] = 156;
            frames[9] = 168;
            frames[10] = 179;
            frames[11] = 197;
            for (int i = 1; i < 11; i++)
            {
                frameInterval[i] = frames[i + 1] - frames[i];
            }
            frameInterval[0] = frameInterval[10];
            for (int i = 12; i < 20; i++)
            {
                frames[i] = frames[i - 1] + frameInterval[(i - 1) % 10];
            }
        }

        #endregion

        #region 动画播放

        //为了加快播放动画前的计算过程,以及特别动画效果的实现,对动画类型进行了细分

        private void PlayAnimationNext(int num, int index)  //播放前一个数字到这个数字的动画
        {
            if (num == 1)
            {
                startFrame[index] = frames[10];
                endFrame[index] = frames[11];
            }
            else
            {
                startFrame[index] = frames[num - 1];
                endFrame[index] = frames[num];
            }

            //实例化一个新的timer
            tmr[index] = new System.Windows.Forms.Timer();
            tmr[index].Tick += new EventHandler((st, et) => tmrPlayAnimationA_Tick(st, et, index));
            tmr[index].Interval = 20;
            tmr[index].Enabled = true;
            tmrIsRuning[index] = true;
        }

        private void PlayAnimationToZero(int num, int index) //播放数字到0的动画(用于好看的地方)
        {
            startFrame[index] = frames[num];
            endFrame[index] = frames[10];

            //实例化一个新的timer
            tmr[index] = new System.Windows.Forms.Timer();
            tmr[index].Tick += new EventHandler((st, et) => tmrPlayAnimationA_Tick(st, et, index));
            tmr[index].Interval = 10;
            tmr[index].Enabled = true;
            tmrIsRuning[index] = true;
        }

        private void PlayAnimationPrev(int num, int index) //播放后一个数字到这个数字的动画
        {
            if (num == 0)
            {
                startFrame[index] = frames[11];
                endFrame[index] = frames[10];
            }
            else
            {
                startFrame[index] = frames[num + 1];
                endFrame[index] = frames[num];
            }

            //实例化一个新的timer
            tmr[index] = new System.Windows.Forms.Timer();
            tmr[index].Tick += new EventHandler((st, et) => tmrPlayAnimationB_Tick(st, et, index));
            tmr[index].Interval = 20;
            tmr[index].Enabled = true;
            tmrIsRuning[index] = true;
        }

        private void PlayAnimationNumToNum(int startNum, int endNum, bool rightToLeft, int speed, int index) //播放数字到数字的动画
        {
            //这个方法的内容估计没人看得懂了吧....
            if (startNum == endNum)
            {
                return;
            }

            int tmp;

            if (!rightToLeft)
            {
                tmp = startNum;
                startNum = endNum;
                endNum = tmp;
            }

            if (startNum == 0)
            {
                startNum = 10;
            }
            if (startNum > endNum)
            {
                startFrame[index] = frames[startNum];
                endFrame[index] = frames[endNum + 10];
            }
            else
            {
                startFrame[index] = frames[startNum];
                endFrame[index] = frames[endNum];
            }

            tmr[index] = new System.Windows.Forms.Timer(); //实例化一个新的timer
            if (rightToLeft)
            {
                tmr[index].Tick += new EventHandler((st, et) => tmrPlayAnimationA_Tick(st, et, index));
            }
            else
            {
                tmp = startFrame[index];
                startFrame[index] = endFrame[index];
                endFrame[index] = tmp;
                tmr[index].Tick += new EventHandler((st, et) => tmrPlayAnimationB_Tick(st, et, index));
            }

            tmr[index].Interval = speed;
            tmr[index].Enabled = true;
            tmrIsRuning[index] = true;
        }

        private void tmrPlayAnimationA_Tick(object sender, EventArgs e, int index) //动画播放
        {
            if (startFrame[index] <= endFrame[index])
            {
                allPicBox[index].Image = numPic[startFrame[index]];
                startFrame[index]++;
            }
            else
            {
                ((System.Windows.Forms.Timer)sender).Enabled = false;
                tmrIsRuning[index] = false;
                tmr[index].Dispose(); //保证动画的流畅播放,释放timer
            }
        }

        private void tmrPlayAnimationB_Tick(object sender, EventArgs e, int index) //动画播放(逆向)
        {
            if (startFrame[index] >= endFrame[index])
            {
                allPicBox[index].Image = numPic[startFrame[index]];
                startFrame[index]--;
            }
            else
            {
                ((System.Windows.Forms.Timer)sender).Enabled = false;
                tmrIsRuning[index] = false;
                tmr[index].Dispose(); //保证动画的流畅播放,释放timer
            }
        }

        #endregion

        #region 计时与倒计时Timer

        private void tmrTime_Tick(object sender, EventArgs e) //计时
        {
            if (first)
            {
                tmrTime.Interval = 1000;
                first = false;
            }
            myTime[0]++;
            PlayAnimationNext(myTime[0], 0);
            if (myTime[0] == 10)
            {
                myTime[0] = 0;
                myTime[1]++;
                PlayAnimationNumToNum(9, 0, true, 20, 0);
                PlayAnimationNext(myTime[1], 1);
            }
            if (myTime[1] == 6)
            {
                myTime[1] = 0;
                myTime[2]++;
                PlayAnimationNumToNum(6, 0, true, 20, 1);
                PlayAnimationNext(myTime[2], 2);
            }
            if (myTime[2] == 10)
            {
                myTime[2] = 0;
                myTime[3]++;
                PlayAnimationNumToNum(9, 0, true, 20, 2);
                PlayAnimationNext(myTime[3], 3);
            }
            if (myTime[3] == 6)
            {
                myTime[3] = 0;
                myTime[4]++;
                PlayAnimationNumToNum(6, 0, true, 20, 3);
                PlayAnimationNext(myTime[4], 4);
            }
            if (myTime[4] == 10)
            {
                myTime[4] = 0;
                myTime[5]++;
                PlayAnimationNumToNum(9, 0, true, 20, 4);
                PlayAnimationNext(myTime[5], 5);
            }
            if (myTime[5] == 10)
            {
                for (int i = 0; i < 6; i++)
                {
                    PlayAnimationNumToNum(myTime[i], 0, true, 20, i);
                    myTime[i] = 0;
                }
            }
        }

        private void tmrTimeDown_Tick(object sender, EventArgs e) //倒计时
        {
            if (first)
            {
                tmrTime.Interval = 1000;
                first = false;
            }

            if (myTime[0] == 0)
            {
                if (myTime[1] == 0)
                {
                    if (myTime[2] == 0)
                    {
                        if (myTime[3] == 0)
                        {
                            if (myTime[4] == 0)
                            {
                                if (myTime[5] == 0)
                                {
                                    btnStop_Click(sender, e);
                                    MessageBox.Show("倒计时完毕!", "提示");
                                }
                                else
                                {
                                    myTime[5]--;
                                    myTime[4] = 9;
                                    myTime[3] = 5;
                                    myTime[2] = 9;
                                    myTime[1] = 5;
                                    myTime[0] = 9;
                                    PlayAnimationNumToNum(0, 9, false, 20, 4);
                                    PlayAnimationNumToNum(0, 5, false, 20, 3);
                                    PlayAnimationNumToNum(0, 9, false, 20, 2);
                                    PlayAnimationNumToNum(0, 5, false, 20, 1);
                                    PlayAnimationNumToNum(0, 9, false, 20, 0);
                                    PlayAnimationPrev(myTime[5], 5);

                                }
                            }
                            else
                            {
                                myTime[4]--;
                                myTime[3] = 5;
                                myTime[2] = 9;
                                myTime[1] = 5;
                                myTime[0] = 9;
                                PlayAnimationNumToNum(0, 5, false, 20, 3);
                                PlayAnimationNumToNum(0, 9, false, 20, 2);
                                PlayAnimationNumToNum(0, 5, false, 20, 1);
                                PlayAnimationNumToNum(0, 9, false, 20, 0);
                                PlayAnimationPrev(myTime[4], 4);
                            }
                        }
                        else
                        {
                            myTime[3]--;
                            myTime[2] = 9;
                            myTime[1] = 5;
                            myTime[0] = 9;
                            PlayAnimationNumToNum(0, 9, false, 20, 2);
                            PlayAnimationNumToNum(0, 5, false, 20, 1);
                            PlayAnimationNumToNum(0, 9, false, 20, 0);
                            PlayAnimationPrev(myTime[3], 3);
                        }
                    }
                    else
                    {
                        myTime[2]--;
                        myTime[1] = 5;
                        myTime[0] = 9;
                        PlayAnimationNumToNum(0, 5, false, 20, 1);
                        PlayAnimationNumToNum(0, 9, false, 20, 0);
                        PlayAnimationPrev(myTime[2], 2);
                    }
                }
                else
                {
                    myTime[1]--;
                    myTime[0] = 9;
                    PlayAnimationNumToNum(0, 9, false, 20, 0);
                    PlayAnimationPrev(myTime[1], 1);
                }
            }
            else
            {
                myTime[0]--;
                PlayAnimationPrev(myTime[0], 0);
            }
        }

        #endregion

        #region 特效控制,按钮控制

        private void tmrEffect_Tick(object sender, EventArgs e) //开场特效
        {
            if (timeCount > 0)
            {
                timeCount--;
                PlayAnimationToZero(0, timeCount);
            }
            else
            {
                ((System.Windows.Forms.Timer)sender).Enabled = false;
            }
        }

        private void tmrCtrl_Tick(object sender, EventArgs e)
        {
            int tmp = 0;
            for (int i = 0; i < 6; i++)
            {
                if (tmrIsRuning[i] == true)
                {
                    tmp++;
                }
            }
            if (tmp == 0)
            {
                btnStart.Enabled = true;
            }
            else
            {
                btnStart.Enabled = false;
            }
        }

        #endregion

        #region 按钮事件

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rbtnCountUp.Checked == true)
            {
                tmrTime.Interval = 1000 - frameInterval[myTime[0]] * 20; //减去动画播放时间,提高精度
                tmrTime.Enabled = true;
                tmrTimeDown.Enabled = false;
            }
            else
            {
                if ((myTime[0] + myTime[1] * 10) > 59)
                {
                    toolTip1.Show("请输入正确时间!", txtSec, 0, -40, 500);
                    return;
                }
                if ((myTime[2] + myTime[3] * 10) > 59)
                {
                    toolTip1.Show("请输入正确时间!", txtMin, 0, -40, 500);
                    return;
                }
                tmrTime.Interval = 1000 - frameInterval[myTime[0] + 9] * 20; //减去动画播放时间,提高精度
                tmrTimeDown.Enabled = true;
                tmrTime.Enabled = false;
            }

            txtHour.Enabled = false;
            txtMin.Enabled = false;
            txtSec.Enabled = false;

            first = true;

            btnStart.Enabled = false;
            btnPause.Enabled = true;
            btnStop.Enabled = true;

            tmrCtrl.Enabled = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            tmrTime.Enabled = false;
            tmrTimeDown.Enabled = false;
            first = true;

            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = true;

            tmrCtrl.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrTime.Enabled = false;
            tmrTimeDown.Enabled = false;
            first = true;
            for (int i = 0; i < 6; i++)
            {
                tmr[i].Dispose();
            }
            for (int i = 0; i < 6; i++)
            {
                PlayAnimationToZero(myTime[i], i);
                myTime[i] = 0;
            }

            txtHour.Enabled = true;
            txtMin.Enabled = true;
            txtSec.Enabled = true;

            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;

            tmrCtrl.Enabled = true;
        }

        #endregion

        #region 窗体特效及文本框人性化设置

        private void Form1_Move(object sender, EventArgs e)
        {
            int leftOrRight = this.Location.X - formLocationNow.X;
            int upperOrLower = this.Location.Y - formLocationNow.Y;
            formLocationNow = this.Location;
            if (Math.Abs(this.Left) < 50 && leftOrRight < 0)  //←
            {
                this.Left = 0;
            }
            if (Math.Abs(Screen.PrimaryScreen.Bounds.Right - this.Left - this.Size.Width)<50&&leftOrRight>0) //→
            {
                this.Left = Screen.PrimaryScreen.Bounds.Right- this.Size.Width;
            }
            if (Math.Abs(this.Top) < 50 && upperOrLower < 0)  //上
            {
                this.Top = 0;
            }
            if (Math.Abs(Screen.PrimaryScreen.Bounds.Bottom - this.Top - this.Size.Height) < 50 && upperOrLower>0)  //下
            {
                this.Top = Screen.PrimaryScreen.Bounds.Bottom - this.Size.Height;
            }
        }

        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            btnStop_Click(sender, e);
            txtHour.Text = "00";
            txtMin.Text = "00";
            txtSec.Text = "00";

            elapsed = 0;
            System.Windows.Forms.Timer tmrFormEffect = new System.Windows.Forms.Timer();
            tmrFormEffect.Interval = 20;
            tmrFormEffect.Tick += new EventHandler((st, et) => tmrFormEffect_Tick(st, et, rbtnCountDown.Checked));
            tmrFormEffect.Enabled = true;

            CountDownInit();
        }

        private void tmrFormEffect_Tick(object sender, EventArgs e, bool bigger) //窗体特效
        {
            if (bigger)
            {
                if (elapsed < 11)
                {
                    elapsed++;
                    this.Height += elapsed;
                }
                else
                {
                    ((System.Windows.Forms.Timer)sender).Enabled = false;
                }
            }
            else
            {
                if (elapsed < 11)
                {
                    this.Height -= 11 - elapsed;
                    elapsed++;
                }
                else
                {
                    ((System.Windows.Forms.Timer)sender).Enabled = false;
                }
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e) //只允许数字和Backspace输入
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_KeyUp(object sender, KeyEventArgs e) //自动跳转到下一个文本框
        {
            if (((TextBox)sender).Text.Length == 2 && ((TextBox)sender).SelectionLength != 2)
            {
                if (((TextBox)sender).Name == "txtHour")
                {
                    txtMin.Focus();
                    txtMin.SelectAll();
                }
                else if (((TextBox)sender).Name == "txtMin")
                {
                    txtSec.Focus();
                    txtSec.SelectAll();
                }
                else if (((TextBox)sender).Name == "txtSec")
                {
                    txtSec.Focus();
                    CountDownInit();
                }
            }
        }

        private void txt_Click(object sender, EventArgs e) //格式化文本框内内容
        {
            if (txtHour.Text == "")
            {
                txtHour.Text = "00";
            }
            else if (txtHour.Text.Length == 1)
            {
                txtHour.Text = "0" + txtHour.Text;
            }
            if (txtMin.Text == "")
            {
                txtMin.Text = "00";
            }
            else if (txtMin.Text.Length == 1)
            {
                txtMin.Text = "0" + txtMin.Text;
            }
            if (txtSec.Text == "")
            {
                txtSec.Text = "00";
            }
            else if (txtSec.Text.Length == 1)
            {
                txtSec.Text = "0" + txtSec.Text;
            }

            ((TextBox)sender).SelectAll();
        }

        private void txt_Leave(object sender, EventArgs e)  //失去焦点时格式化
        {
            if (((TextBox)sender).Text.Length == 0)
            {
                ((TextBox)sender).Text = "00";
            }
            else if (((TextBox)sender).Text.Length == 1)
            {
                ((TextBox)sender).Text = "0" + ((TextBox)sender).Text;
            }

            CountDownInit();
        }

        private void CountDownInit()
        {
            if (rbtnCountDown.Checked == false)
            {
                return;
            }

            int[] myTimeOld = new int[6];

            for (int i = 0; i < 6; i++) //记录原先的数
            {
                myTimeOld[i] = myTime[i];
            }
            myTime[0] = Convert.ToInt32(txtSec.Text) % 10;
            myTime[1] = Convert.ToInt32(txtSec.Text) / 10;
            myTime[2] = Convert.ToInt32(txtMin.Text) % 10;
            myTime[3] = Convert.ToInt32(txtMin.Text) / 10;
            myTime[4] = Convert.ToInt32(txtHour.Text) % 10;
            myTime[5] = Convert.ToInt32(txtHour.Text) / 10;
            for (int i = 0; i < 6; i++)
            {
                if (myTimeOld[i] < myTime[i])
                {
                    PlayAnimationNumToNum(myTimeOld[i], myTime[i], true, 15, i);
                }
                if (myTimeOld[i] > myTime[i])
                {
                    PlayAnimationNumToNum(myTimeOld[i], myTime[i], false, 15, i);
                }
            }
        }

        #endregion

    }
}
