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
    public partial class DTADiagram : Form
    {
        public DTADiagram()
        {
            InitializeComponent();
        }
        //sK = 1 : ASK, sK=2 : FSK, sK=3 : PSK
        public int sK;
        public string digitalData="";
        private void DTADiagram_Load(object sender, EventArgs e)
        {

        }

        private void DTADiagram_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            PointF amp0, amp1;
            PointF time0, time1;
            PointF fiveV, negativeFiveV, zeroV;
            PointF bitTextPointF;
            Pen maroon3 = new Pen(Color.Maroon, 2);
            Pen black3 = new Pen(Color.Black, 3);
            Pen Blue5 = new Pen(Color.Blue, 5);
            amp0 = new PointF(10, 10);
            amp1 = new PointF(10, this.Height - 60);
            time0 = new PointF(10, (this.Height - 70) / 2);
            time1 = new PointF(this.Width - 60, (this.Height - 70) / 2);
            fiveV = new PointF(amp0.X, amp0.Y + (amp1.Y - amp0.Y) / 4);
            negativeFiveV = new PointF(amp0.X, amp0.Y + (amp1.Y - amp0.Y) * 3 / 4);
            zeroV = new PointF(time0.X, time0.Y);
            g.DrawLine(black3, amp0, amp1);
            g.DrawLine(black3, time0, time1);
            int numBits = digitalData.Length;
            float distanceLines = (time1.X - time0.X) / numBits;
            bitTextPointF = new PointF(fiveV.X + (distanceLines / 2), fiveV.Y - 30);
            PointF line0, line1;
            line0 = new PointF(amp0.X + distanceLines, amp0.Y);
            line1 = new PointF(amp1.X + distanceLines, amp1.Y);
            Font font = new Font("Arial", 8);
            SolidBrush brush = new SolidBrush(Color.Black);

            for (int i = 0; i < numBits; i++)
            {
                g.DrawLine(maroon3, line0, line1);
                line0.X += distanceLines;
                line1.X += distanceLines;
                if (digitalData[i] == '1')
                {
                    g.DrawString("1", Font, brush, bitTextPointF);
                    bitTextPointF= new PointF(bitTextPointF.X+distanceLines, bitTextPointF.Y);
                }
                else
                {
                    g.DrawString("0", Font, brush, bitTextPointF);
                    bitTextPointF = new PointF(bitTextPointF.X + distanceLines, bitTextPointF.Y);
                }
            }

            PointF ampText, timeText;
            ampText = new PointF(amp0.X, amp0.Y - 5);
            timeText = new PointF(time1.X + 5, time1.Y);
            g.DrawString("5V", font, brush, fiveV.X + 5, fiveV.Y);
            g.DrawString("0V", font, brush, zeroV.X + 5, zeroV.Y);
            g.DrawString("-5V", font, brush, negativeFiveV.X + 5, negativeFiveV.Y);
            g.DrawString("Amplitude", font, brush, ampText);
            g.DrawString("Time", font, brush, timeText);
            int hZ;
            //ASK
            if (sK == 1)
            {
                hZ = 5;
                PointF []curvePointFs=new PointF[numBits*8*hZ];
                int j = 0;
                for (int i = 0; i < numBits; i++)
                {
                    if (digitalData[i] == '0')
                    {

                        curvePointFs[j] = new PointF(zeroV.X + (distanceLines*i), zeroV.Y);
                        curvePointFs[j+1] = curvePointFs[j+2] = new PointF(zeroV.X + (distanceLines*i) + (distanceLines / 2), zeroV.Y);
                        curvePointFs[j+3] = new PointF(zeroV.X + distanceLines *(i+1), zeroV.Y);
                        j += 4;
                    }
                    else
                    {
                        
                        for (int r = 0; r < hZ; r++)
                        {
                            try
                            {
                                curvePointFs[j] = new PointF(curvePointFs[j - 1].X, zeroV.Y);
                            }
                            catch
                            {
                                curvePointFs[j] = new PointF(zeroV.X, zeroV.Y);
                            }
                            curvePointFs[j + 1] = curvePointFs[j + 2] = new PointF(curvePointFs[j].X + (distanceLines / (4*hZ)), fiveV.Y);
                            curvePointFs[j + 3] = new PointF(curvePointFs[j + 2].X + (distanceLines / (4*hZ)), zeroV.Y);
                            curvePointFs[j + 4] = curvePointFs[j + 3];
                            curvePointFs[j + 5] = curvePointFs[j + 6] = new PointF(curvePointFs[j + 4].X + (distanceLines / (4*hZ)), negativeFiveV.Y);
                            curvePointFs[j + 7] = new PointF(curvePointFs[j + 6].X + (distanceLines / (4*hZ)), zeroV.Y);
                            j += 8;
                        }
                        
                    }
                    
                }
                for (int i = 0; i < j; i += 4)
                {
                    g.DrawBezier(Blue5, curvePointFs[i], curvePointFs[i + 1], curvePointFs[i + 2], curvePointFs[i + 3]);
                }
            }
            //FSK
            else if(sK == 2)
            {
                hZ = 7;
                PointF[] curvePointFs = new PointF[numBits * 8 * hZ];
                int j = 0;
                for (int i = 0; i < numBits; i++)
                {
                    if (digitalData[i] == '0')
                    {
                        hZ = 2;
                        for (int r = 0; r < hZ; r++)
                        {
                            try
                            {
                                curvePointFs[j] = new PointF(curvePointFs[j - 1].X, zeroV.Y);
                            }
                            catch
                            {
                                curvePointFs[j] = new PointF(zeroV.X, zeroV.Y);
                            }
                            curvePointFs[j + 1] = curvePointFs[j + 2] = new PointF(curvePointFs[j].X + (distanceLines / (4 * hZ)), fiveV.Y);
                            curvePointFs[j + 3] = new PointF(curvePointFs[j + 2].X + (distanceLines / (4 * hZ)), zeroV.Y);
                            curvePointFs[j + 4] = curvePointFs[j + 3];
                            curvePointFs[j + 5] = curvePointFs[j + 6] = new PointF(curvePointFs[j + 4].X + (distanceLines / (4 * hZ)), negativeFiveV.Y);
                            curvePointFs[j + 7] = new PointF(curvePointFs[j + 6].X + (distanceLines / (4 * hZ)), zeroV.Y);
                            j += 8;
                        }
                    }
                    else
                    {
                        hZ = 7;
                        for (int r = 0; r < hZ; r++)
                        {
                            try
                            {
                                curvePointFs[j] = new PointF(curvePointFs[j - 1].X, zeroV.Y);
                            }
                            catch
                            {
                                curvePointFs[j] = new PointF(zeroV.X, zeroV.Y);
                            }
                            curvePointFs[j + 1] = curvePointFs[j + 2] = new PointF(curvePointFs[j].X + (distanceLines / (4 * hZ)), fiveV.Y);
                            curvePointFs[j + 3] = new PointF(curvePointFs[j + 2].X + (distanceLines / (4 * hZ)), zeroV.Y);
                            curvePointFs[j + 4] = curvePointFs[j + 3];
                            curvePointFs[j + 5] = curvePointFs[j + 6] = new PointF(curvePointFs[j + 4].X + (distanceLines / (4 * hZ)), negativeFiveV.Y);
                            curvePointFs[j + 7] = new PointF(curvePointFs[j + 6].X + (distanceLines / (4 * hZ)), zeroV.Y);
                            j += 8;
                        }

                    }

                }
                for (int i = 0; i < j; i += 4)
                {
                    g.DrawBezier(Blue5, curvePointFs[i], curvePointFs[i + 1], curvePointFs[i + 2], curvePointFs[i + 3]);
                }

            }
            //PSK
            else if (sK == 3)
            {
                hZ = 4;
                PointF[] curvePointFs = new PointF[numBits * 8 * hZ];
                int j = 0;
                for (int i = 0; i < numBits; i++)
                {
                    if (digitalData[i] == '0')
                    {

                        for (int r = 0; r < hZ; r++)
                        {
                            try
                            {
                                curvePointFs[j] = new PointF(curvePointFs[j - 1].X, zeroV.Y);
                            }
                            catch
                            {
                                curvePointFs[j] = new PointF(zeroV.X, zeroV.Y);
                            }
                            curvePointFs[j + 1] = curvePointFs[j + 2] = new PointF(curvePointFs[j].X + (distanceLines / (4 * hZ)), negativeFiveV.Y);
                            curvePointFs[j + 3] = new PointF(curvePointFs[j + 2].X + (distanceLines / (4 * hZ)), zeroV.Y);
                            curvePointFs[j + 4] = curvePointFs[j + 3];
                            curvePointFs[j + 5] = curvePointFs[j + 6] = new PointF(curvePointFs[j + 4].X + (distanceLines / (4 * hZ)), fiveV.Y);
                            curvePointFs[j + 7] = new PointF(curvePointFs[j + 6].X + (distanceLines / (4 * hZ)), zeroV.Y);
                            j += 8;
                        }
                    }
                    else
                    {

                        for (int r = 0; r < hZ; r++)
                        {
                            try
                            {
                                curvePointFs[j] = new PointF(curvePointFs[j - 1].X, zeroV.Y);
                            }
                            catch
                            {
                                curvePointFs[j] = new PointF(zeroV.X, zeroV.Y);
                            }
                            curvePointFs[j + 1] = curvePointFs[j + 2] = new PointF(curvePointFs[j].X + (distanceLines / (4 * hZ)), fiveV.Y);
                            curvePointFs[j + 3] = new PointF(curvePointFs[j + 2].X + (distanceLines / (4 * hZ)), zeroV.Y);
                            curvePointFs[j + 4] = curvePointFs[j + 3];
                            curvePointFs[j + 5] = curvePointFs[j + 6] = new PointF(curvePointFs[j + 4].X + (distanceLines / (4 * hZ)), negativeFiveV.Y);
                            curvePointFs[j + 7] = new PointF(curvePointFs[j + 6].X + (distanceLines / (4 * hZ)), zeroV.Y);
                            j += 8;
                        }

                    }

                }
                for (int i = 0; i < j; i += 4)
                {
                    g.DrawBezier(Blue5, curvePointFs[i], curvePointFs[i + 1], curvePointFs[i + 2], curvePointFs[i + 3]);
                }
            }
        }
    }
}
