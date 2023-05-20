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
    public partial class dgtlDiagram : Form
    {
        public dgtlDiagram()
        {
            InitializeComponent();
        }
        public string digitalData="0";
        // zState: 0 means RZ, 1 Means NRZ
        //polarity: 1 means unipolar, 2 means bipolar
        public int zState,polarity;



        private void dgtlDiagram_Load(object sender, EventArgs e)
        {

        }

        private void dgtlDiagram_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            PointF amp0, amp1;
            PointF time0, time1;
            PointF fiveV, negativeFiveV, zeroV;
            PointF bitTextPointF;
            Pen maroon3 = new Pen(Color.Maroon, 2);
            Pen black3= new Pen(Color.Black, 3);
            Pen Blue5 = new Pen(Color.Blue,5);
            amp0 = new PointF(10, 10);
            amp1 = new PointF(10, this.Height-60);
            time0 = new PointF(10, (this.Height-70)/2);
            time1 = new PointF(this.Width - 60, (this.Height - 70) / 2);
            fiveV = new PointF(amp0.X, amp0.Y+(amp1.Y-amp0.Y)/4);
            negativeFiveV = new PointF(amp0.X, amp0.Y + (amp1.Y - amp0.Y) * 3 / 4);
            zeroV = new PointF(time0.X, time0.Y);
            g.DrawLine(black3, amp0, amp1);
            g.DrawLine(black3, time0, time1);
            int numBits = digitalData.Length;
            float distanceLines = (time1.X-time0.X)/numBits;
            bitTextPointF = new PointF(fiveV.X + (distanceLines/2), fiveV.Y - 30);
            PointF line0, line1;
            line0 = new PointF(amp0.X+distanceLines,amp0.Y);
            line1 = new PointF(amp1.X+distanceLines,amp1.Y);
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
            ampText = new PointF(amp0.X, amp0.Y-5);
            timeText = new PointF(time1.X+5, time1.Y);
            g.DrawString("5V",font,brush,fiveV.X+5,fiveV.Y);
            g.DrawString("0V", font, brush, zeroV.X + 5, zeroV.Y);
            g.DrawString("-5V", font, brush, negativeFiveV.X + 5, negativeFiveV.Y);
            g.DrawString("Amplitude", font, brush, ampText);
            g.DrawString("Time", font, brush, timeText);
            //Uni-Polar RZ
            if (zState == 0 && polarity == 1)
            {
                PointF[] bitPointFs = new PointF[numBits*4];
                int j=0;
                for (int i = 0; i < numBits; i++)
                {
                    if (digitalData[i] == '0')
                    {
                        try
                        {
                            bitPointFs[j] = new PointF(bitPointFs[j - 1].X + distanceLines, zeroV.Y);
                        }
                        catch
                        {
                            bitPointFs[j] = zeroV;
                            bitPointFs[j+1] = new PointF(zeroV.X+distanceLines, zeroV.Y);
                            j++;
                        }
                        j++;
                        
                        
                    }
                    else
                    {
                        try
                        {
                            bitPointFs[j] = new PointF(bitPointFs[j - 1].X, fiveV.Y);
                        }
                        catch
                        {
                            bitPointFs[j] = fiveV;
                        }
                        bitPointFs[j+1]=new PointF(bitPointFs[j].X + (distanceLines / 2), fiveV.Y);
                        bitPointFs[j+2]=new PointF(bitPointFs[j + 1].X, zeroV.Y);
                        bitPointFs[j+3]=new PointF(bitPointFs[j + 2].X + (distanceLines / 2), zeroV.Y);
                        j += 4;
                        
                    }
                }
                for (int i = 0; i<j-1 ; i++)
                {
                    g.DrawLine(Blue5, bitPointFs[i],bitPointFs[i+1]);
                }
                
                
            }
            //Uni-Polar NRZ
            else if(zState == 1 && polarity == 1)
            {
                PointF[] bitPointFs = new PointF[numBits * 2];
                int j = 0;
                for (int i = 0; i < numBits ; i++)
                {
                    if (digitalData[i] == '0')
                    {
                        bitPointFs[j] = new PointF(zeroV.X + (distanceLines * i), zeroV.Y);
                        bitPointFs[j+1] = new PointF(zeroV.X + (distanceLines * (i+1)), zeroV.Y);
                        
                    }
                    else
                    {
                        bitPointFs[j] = new PointF(fiveV.X+(distanceLines * i), fiveV.Y);
                        bitPointFs[j+1] = new PointF(fiveV.X + (distanceLines * (i+1)), fiveV.Y);
                    }
                    j += 2;
                }
                g.DrawLines(Blue5,bitPointFs);
                
            }
            //Bi-Polar RZ
            else if (zState == 0 && polarity == 2)
            {
                PointF[] bitPointFs = new PointF[numBits * 4];
                int j = 0;
                for (int i = 0; i < numBits; i++)
                {
                    if (digitalData[i] == '0')
                    {
                        bitPointFs[j] = new PointF(negativeFiveV.X+(distanceLines*i), negativeFiveV.Y);
                        bitPointFs[j + 1] = new PointF(negativeFiveV.X+(distanceLines * i + (distanceLines / 2)), negativeFiveV.Y);
                        bitPointFs[j+2] = new PointF(zeroV.X+(distanceLines * i) + (distanceLines / 2), zeroV.Y);
                        bitPointFs[j + 3] = new PointF(zeroV.X + (distanceLines * (i + 1)), zeroV.Y);
                    }
                    else
                    {
                        bitPointFs[j] = new PointF(fiveV.X+(distanceLines*i), fiveV.Y);
                        bitPointFs[j+1] = new PointF(fiveV.X + (distanceLines * i)+ (distanceLines / 2), fiveV.Y);
                        bitPointFs[j+2] = new PointF(zeroV.X+ (distanceLines * i) + (distanceLines / 2), zeroV.Y);
                        bitPointFs[j + 3] = new PointF(zeroV.X+ (distanceLines * (i + 1)), zeroV.Y);
                    }
                    j += 4;
                }
                g.DrawLines(Blue5, bitPointFs);
            }
            //Bi-Polar NRZ
            else if (zState == 1 && polarity == 2)
            {
                PointF[] bitPointFs = new PointF[numBits * 2];
                int j = 0;
                for (int i = 0; i < numBits ; i++)
                {
                    if (digitalData[i] == '0')
                    {
                        bitPointFs[j] = new PointF(negativeFiveV.X+(distanceLines * i), negativeFiveV.Y);
                        bitPointFs[j+1] = new PointF(negativeFiveV.X+(distanceLines * (i + 1)), negativeFiveV.Y);
                    }
                    else
                    { 
                        bitPointFs[j] = new PointF(fiveV.X+(distanceLines * i), fiveV.Y);
                        bitPointFs[j+1] = new PointF(fiveV.X+(distanceLines * (i + 1)), fiveV.Y);

                    }
                    j += 2;
                }
                g.DrawLines(Blue5, bitPointFs);
            }
        }
    }
}
