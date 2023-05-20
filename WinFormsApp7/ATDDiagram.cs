using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class ATDDiagram : Form
    {
        public ATDDiagram()
        {
            InitializeComponent();
        }
        public int shift;
        // 0 = PCM , 1 = DM
        public bool modulation;

        private void ATDDiagram_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            PointF amp0, amp1;
            PointF time0, time1;
            PointF fiveV, negativeFiveV, zeroV;
            Pen maroon3 = new Pen(Color.Maroon, 2);
            Pen black3 = new Pen(Color.Black, 3);
            Pen Blue5 = new Pen(Color.Blue, 5);
            Pen darkCyan4 = new Pen(Color.DarkCyan, 4);
            Pen blackDashPen = new Pen(Color.Black, 2);
            blackDashPen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
            blackDashPen.DashPattern = new float[] { 4.0F, 4.0F};
            amp0 = new PointF(10, 10);
            amp1 = new PointF(10, this.Height - 60);
            time0 = new PointF(10, (this.Height - 70) / 2);
            time1 = new PointF(this.Width - 60, (this.Height - 70) / 2);
            fiveV = new PointF(amp0.X, amp0.Y + (amp1.Y - amp0.Y) / 12);
            negativeFiveV = new PointF(amp0.X, amp0.Y + (amp1.Y - amp0.Y) * 11 / 12);
            zeroV = new PointF(time0.X, time0.Y);
            g.DrawLine(black3, amp0, amp1);
            g.DrawLine(black3, time0, time1);
            Font font = new Font("Arial", 8);
            SolidBrush brush = new SolidBrush(Color.Black);
            PointF ampText, timeText;
            ampText = new PointF(amp0.X, amp0.Y - 5);
            timeText = new PointF(time1.X + 5, time1.Y);
            g.DrawString("5V", font, brush, fiveV.X + 5, fiveV.Y);
            g.DrawString("0V", font, brush, zeroV.X + 5, zeroV.Y);
            g.DrawString("-5V", font, brush, negativeFiveV.X + 5, negativeFiveV.Y);
            g.DrawString("Amplitude", font, brush, ampText);
            g.DrawString("Time", font, brush, timeText);
            
            //PCM
            if (modulation == false)
            {
                PointF[] curvePointFs = new PointF[(int)(10*(time1.X-time0.X))+1];
                int j = 0;
                int numLevels = 8;
                double xCoord;
                double radianShift=((double)shift/360)*2*Math.PI;
                for (float i = zeroV.X; i < time1.X; i+=0.1F)
                {
                    xCoord = ((i - zeroV.X) * Math.PI * 2) / (time1.X - time0.X);
                    curvePointFs[j] = new PointF(i, (float)Math.Sin(xCoord+(radianShift))*(fiveV.Y-zeroV.Y) + zeroV.Y);
                    j++;
                }
                string levelBinary = "";
                for (int i = 0; i < j-1; i++)
                {
                    g.DrawLine(Blue5, curvePointFs[i], curvePointFs[i + 1]);
                }
                float stepLength = (negativeFiveV.Y - fiveV.Y) / (numLevels);
                float[] levelY = new float[numLevels]; 
                for (int i = 0; i < numLevels ; i++)
                {
                    levelY[i] = negativeFiveV.Y - (stepLength * (i + 1)) + 10;
                    g.DrawLine(blackDashPen, new PointF(time0.X, levelY[i]), new PointF(time1.X, levelY[i]));
                    levelBinary = Convert.ToString(i, 2);
                    if (levelBinary.Length == 2)
                    {
                        levelBinary = levelBinary.Insert(0, "0");
                    }
                    else if(levelBinary.Length == 1)
                    {
                        levelBinary = levelBinary.Insert(0, "00");
                    }
                    g.DrawString(levelBinary, font, brush, new PointF(time1.X+10, negativeFiveV.Y - (stepLength * (i+1))+10));
                }
                int samplingNum=10;
                float sampleDistance = (time1.X - time0.X) / (samplingNum - 1);
                PointF[] samplingPoints = new PointF[2 * samplingNum];
                j = 0;
                for (int i = 0; i < samplingNum; i++)
                {
                    samplingPoints[j]= new PointF(zeroV.X+(sampleDistance*i), zeroV.Y);
                    xCoord = (samplingPoints[j].X * Math.PI * 2) / (time1.X - time0.X);
                    samplingPoints[j+1]= new PointF(samplingPoints[j].X, (float)Math.Sin(xCoord + (radianShift)) * (fiveV.Y - zeroV.Y) + zeroV.Y);
                    j += 2;
                }
                
                j=0;
                for (int i = 0; i < samplingNum; i++)
                {
                    g.DrawLine(darkCyan4, samplingPoints[j], samplingPoints[j + 1]);
                    j+=2;
                }
                string digitalData="Digital Data:";
                for (int i = 1; i < samplingPoints.Length; i += 2)
                {
                    //level 111
                    if (samplingPoints[i].Y < levelY[7])
                    {
                        digitalData += "  111";
                    }
                    //level 110
                    else if (samplingPoints[i].Y < levelY[6])
                    {
                        digitalData += "  110";
                    }
                    //level 101
                    else if(samplingPoints[i].Y < levelY[5])
                    {
                        digitalData += "  101";
                    }
                    //level 100
                    else if(samplingPoints[i].Y < levelY[4])
                    {
                        digitalData += "  100";
                    }
                    //level 011
                    else if (samplingPoints[i].Y < levelY[3])
                    {
                        digitalData += "  011";
                    }
                    //level 010
                    else if(samplingPoints[i].Y < levelY[2])
                    {
                        digitalData += "  010";
                    }
                    //level 001
                    else if(samplingPoints[i].Y < levelY[1])
                    {
                        digitalData += "  001";
                    }
                    //level 000
                    else
                    {
                        digitalData += "  000";
                    }
                }
                Font font1 = new Font("arial", 16);
                SolidBrush brush1 = new SolidBrush(Color.SteelBlue);
                g.DrawString(digitalData, font1, brush1, new PointF(amp1.X+10,amp1.Y-20));

            }
            //DM
            else
            {
                PointF[] curvePointFs = new PointF[(int)(2 * (time1.X - time0.X))];
                int j = 0;
                double xCoord;
                double radianShift = ((double)shift / 360) * 2 * Math.PI;
                for (float i = zeroV.X; i < time1.X; i += 0.5F)
                {
                    xCoord = ((i - zeroV.X) * Math.PI * 2) / (time1.X - time0.X);
                    curvePointFs[j] = new PointF(i, (float)Math.Sin(xCoord + (radianShift)) * (fiveV.Y - zeroV.Y) + zeroV.Y);
                    j++;
                }
                for (int i = 0; i < j - 1; i++)
                {
                    g.DrawLine(Blue5, curvePointFs[i], curvePointFs[i + 1]);
                }
                string digitalData="";
                int k=0;
                int numBits = 16;
                for (int i = 0; i < numBits; i++)
                {
                   if(curvePointFs[k+(curvePointFs.Length/numBits)].Y > curvePointFs[k].Y)
                    {
                        digitalData += "0";
                    }
                    else
                    {
                        digitalData += "1";
                    }
                    k+= (curvePointFs.Length / numBits);
                }
                PointF[] digitalStair = new PointF[numBits * 2];
                float bitlength = (time1.X - time0.X) / numBits;
                int r = 0;
                for (int i = 0; i < digitalData.Length ; i++)
                {
                    try
                    {
                        if(digitalData[i] == '0')
                        {
                            digitalStair[r] = new PointF(digitalStair[r - 1].X, digitalStair[r - 1].Y + bitlength);
                        }
                        else
                        {
                            digitalStair[r] = new PointF(digitalStair[r - 1].X, digitalStair[r - 1].Y - bitlength);
                        }
                        digitalStair[r+1] = new PointF(digitalStair[r].X+bitlength, digitalStair[r].Y);
                        r += 2;
                    }
                    catch
                    {
                        if (digitalData[0] == '0')
                        {
                            digitalStair[0] = new PointF(curvePointFs[0].X, curvePointFs[0].Y + bitlength);
                        }
                        else
                        {
                            digitalStair[0] = new PointF(curvePointFs[0].X, curvePointFs[0].Y - bitlength);
                        }
                        digitalStair[1] = new PointF(digitalStair[0].X+bitlength,digitalStair[0].Y);
                        r += 2;
                    }
                }
                j=0;
                g.DrawLines(darkCyan4, digitalStair);
                for (int i = 0; i < numBits; i++)
                {
                    if(digitalData[i] == '0')
                    {
                        g.DrawString("0", font, brush, new PointF(digitalStair[j].X + (bitlength / 2), digitalStair[j].Y + 10));
                    }
                    else
                    {
                        g.DrawString("1", font, brush, new PointF(digitalStair[j].X + (bitlength / 2), digitalStair[j].Y + 10));
                    }
                    j += 2;
                }
            }
        }
    }
}
