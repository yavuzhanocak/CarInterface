using Syncfusion.Windows.Forms.Gauge;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using cartest2.Serial;
using System.Diagnostics;
using System.IO;

namespace cartest2
{


    public partial class Form1: Form
    {
        long maksm = 30, mimm = 0;
        private readonly Label[] batteryLevels = new Label[24];
        private readonly Label[] batteryTemps = new Label[24];
        public Graphics g;
        public int Speed = 0;
        public double TotalVoltage = 0;
        public int MaxTemp = 0;
        public double CurrentCurrent = 0;
        //public int ChronoTime = 0;
       // public int LapTime = 0;
        //public int ChronoStatus = 0;
        //public int CurrentLap = 1;
       // public int[] Laptimes = new int[31];
        public int[] BatteryPercent = new int[0];
        public string veriler="";              
        public static string secilenPort;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public SerialPortManager _spManager = new SerialPortManager();
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

   

        public Form1()
        {
            InitializeComponent();
            UserInitialization();
           
            //batteryLevels[0] = lblBattLevel1;
            //batteryLevels[1] = lblBattLevel2;
            //batteryLevels[2] = lblBattLevel3;
            //batteryLevels[3] = lblBattLevel4;
            //batteryLevels[4] = lblBattLevel5;
            //batteryLevels[5] = lblBattLevel6;
            //batteryLevels[6] = lblBattLevel7;
            //batteryLevels[7] = lblBattLevel8;
            //batteryLevels[8] = lblBattLevel9;
            //batteryLevels[9] = lblBattLevel10;
            //batteryLevels[10] = lblBattLevel11;
            //batteryLevels[11] = lblBattLevel12;
            //batteryLevels[12] = lblBattLevel13;
            //batteryLevels[13] = lblBattLevel14;
            //batteryLevels[14] = lblBattLevel15;
            //batteryLevels[15] = lblBattLevel16;
            //batteryLevels[16] = lblBattLevel17;
            //batteryLevels[17] = lblBattLevel18;
            //batteryLevels[18] = lblBattLevel19;
            //batteryLevels[19] = lblBattLevel20;
            //batteryLevels[20] = lblBattLevel21;
            //batteryLevels[21] = lblBattLevel22;
            //batteryLevels[22] = lblBattLevel23;
            //batteryLevels[23] = lblBattLevel24;
            //batteryTemps[0] = lblBattTemp1;
            //batteryTemps[1] = lblBattTemp2;
            //batteryTemps[2] = lblBattTemp3;
            //batteryTemps[3] = lblBattTemp4;
            //batteryTemps[4] = lblBattTemp5;
            //batteryTemps[5] = lblBattTemp6;
            //batteryTemps[6] = lblBattTemp7;
            //batteryTemps[7] = lblBattTemp8;
            //batteryTemps[8] = lblBattTemp9;
            //batteryTemps[9] = lblBattTemp10;
            //batteryTemps[10] = lblBattTemp11;
            //batteryTemps[11] = lblBattTemp12;
            //batteryTemps[12] = lblBattTemp13;
            //batteryTemps[13] = lblBattTemp14;
            //batteryTemps[14] = lblBattTemp15;
            //batteryTemps[15] = lblBattTemp16;
            //batteryTemps[16] = lblBattTemp17;
            //batteryTemps[17] = lblBattTemp18;
            //batteryTemps[18] = lblBattTemp19;
            //batteryTemps[19] = lblBattTemp20;
            //batteryTemps[20] = lblBattTemp21;
            //batteryTemps[21] = lblBattTemp22;
            //batteryTemps[22] = lblBattTemp23;
            //batteryTemps[23] = lblBattTemp24;



            //TODO Radial Guage
            RadialGauge radialGauge1 = new RadialGauge();
            this.radialGauge1.MinorDifference = 5;
            this.Controls.Add(radialGauge1);
            this.radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Black;
            this.radialGauge1.MajorDifference = 10F;
            this.radialGauge1.MaximumValue = 150F;
            this.radialGauge1.MinimumValue = 0F;
            this.radialGauge1.MinorDifference = 30F;
            this.radialGauge1.LabelPlacement = Syncfusion.Windows.Forms.Gauge.LabelPlacement.Outside;
            this.radialGauge1.TextOrientation = Syncfusion.Windows.Forms.Gauge.TextOrientation.SlideOver;
            this.radialGauge1.TickPlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            this.radialGauge1.MajorTickMarkColor = System.Drawing.Color.LightYellow;
            this.radialGauge1.MinorTickMarkColor = System.Drawing.Color.Red;
            this.radialGauge1.GaugeArcColor = ColorTranslator.FromHtml("#00a0d1");
            this.radialGauge1.GaugeLableColor = ColorTranslator.FromHtml("#00a0d1");
            this.radialGauge1.InterLinesColor = System.Drawing.Color.Red;
            this.radialGauge1.MinorTickMarkHeight = 55;
            this.radialGauge1.MajorTickMarkHeight = 6;
            this.radialGauge1.MinorInnerLinesHeight = 60;
            this.radialGauge1.BackColor = Color.Transparent;
            CustomRenderer custom1 = new CustomRenderer(this.linearGauge1);
            linearGauge1.Renderer = custom1;
        }
        class CustomRenderer : ILinearGaugeRenderer
        {
            /// </summary>
            /// Gets the Linear gauge
            /// </summary>
            private LinearGauge m_LinearGauge;
            /// <summary>
            /// Gets/Sets the Tick Distance of the Linear gauge.
            /// </summary>
            private float majorTicksDistance;
            /// <summary>
            /// Calculates the Minor Ticks Pixels.
            /// </summary>
            private float m_minorTicksPixels;
            /// <summary>
            /// Start point of the frame
            /// </summary>
            private int start;
            /// <summary>
            /// Counts the Major ticks count for the given range.
            /// </summary>
            private int majorTicksCount;

            /// <summary>
            ///  Gets the Radial gauge
            /// </summary>
            internal LinearGauge LinearGauge
            {
                get
                {
                    return m_LinearGauge;
                }
            }

            public CustomRenderer(LinearGauge linearGauge)
            {
                m_LinearGauge = linearGauge;
                majorTicksDistance = 0;
                m_minorTicksPixels = 0;
                start = 25;

            }

            public void DrawFrame(System.Drawing.Graphics Graphics)
            {
            }

            [Obsolete]
            public void DrawLines(System.Drawing.Graphics Graphics)
            {
                Pen majorTickPen = new Pen(LinearGauge.MajorTickMarkColor);
                Pen minorTickPen = new Pen(LinearGauge.MinorTickMarkColor);
                Brush brush = new SolidBrush(LinearGauge.ForeColor);
                StringFormat sf = new StringFormat();
                Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                majorTicksDistance = ((LinearGauge.MaximumValue - LinearGauge.MinimumValue) / LinearGauge.MajorDifference);
                majorTicksCount = ((int)(LinearGauge.MaximumValue - LinearGauge.MinimumValue) / (LinearGauge.MajorDifference)) + 1;
                double majorTickValue = LinearGauge.MinimumValue;
                float tickPosition = 25f;
                float temp1 = 0;
                float s = (LinearGauge.MaximumValue - LinearGauge.MinimumValue) % LinearGauge.MajorDifference;
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                float minortickValue = 0;
                float tickPositionMinor = 0;
                GraphicsPath path = new GraphicsPath();
                int minor = LinearGauge.MinorTickCount;
                m_minorTicksPixels = ((this.LinearGauge.Height - 50) / majorTicksDistance);
                int x = this.LinearGauge.Width / 2;
                temp1 = 0;
                for (int L = 1; L <= majorTicksCount; L++)
                {
                    Graphics.DrawLine(majorTickPen, x, this.LinearGauge.Height - tickPosition, x - LinearGauge.MajorTicksHeight, this.LinearGauge.Height - tickPosition);
                    Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                    if (LinearGauge.ShowScaleLabel)
                        Graphics.DrawString(Math.Round(majorTickValue, 2).ToString(),
                                 LinearGauge.Font, brush, new PointF(x - LinearGauge.MajorTicksHeight - 25, this.LinearGauge.Height - tickPosition), sf);
                    if (L == majorTicksCount)
                        minor = (LinearGauge.MinorTickCount * (int)Math.Ceiling(s)) / LinearGauge.MajorDifference;
                    if (majorTickValue < LinearGauge.MaximumValue)
                    {
                        for (int S = 1; S <= minor; S++)
                        {
                            minortickValue = (m_minorTicksPixels / (LinearGauge.MinorTickCount + 1)) * S;
                            tickPositionMinor = this.LinearGauge.Height - (minortickValue + temp1 + 25);
                            Graphics.DrawLine(minorTickPen, x, (float)tickPositionMinor, x - LinearGauge.MinorTickHeight, (float)tickPositionMinor);
                        }
                        temp1 = m_minorTicksPixels * L;
                    }

                    majorTickValue += LinearGauge.MajorDifference;
                    tickPosition += m_minorTicksPixels;
                }
                Graphics.FillRectangle(new SolidBrush(LinearGauge.GaugeBaseColor), this.LinearGauge.Width / 2, start - 1, 1, (((this.majorTicksDistance)) * m_minorTicksPixels) + 2);
                if (this.LinearGauge.MinimumValue > 0)
                    Graphics.FillRectangle(new SolidBrush(LinearGauge.ValueIndicatorColor), this.LinearGauge.Width / 2 + 10, start + (majorTicksDistance * m_minorTicksPixels) - (((LinearGauge.Value / LinearGauge.MajorDifference)) * m_minorTicksPixels), 5, (((LinearGauge.Value / LinearGauge.MajorDifference)) * m_minorTicksPixels) + 2);
                else
                    Graphics.FillRectangle(new SolidBrush(LinearGauge.ValueIndicatorColor), this.LinearGauge.Width / 2 + 10, start + (majorTicksDistance * m_minorTicksPixels) - ((((Math.Abs(this.LinearGauge.MinimumValue) + LinearGauge.Value) / LinearGauge.MajorDifference)) * m_minorTicksPixels), 5, ((((Math.Abs(this.LinearGauge.MinimumValue) + LinearGauge.Value) / LinearGauge.MajorDifference)) * m_minorTicksPixels) + 2);
                brush.Dispose();
                minorTickPen.Dispose();
            }

            public void DrawRanges(System.Drawing.Graphics Graphics)
            {
                Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                foreach (LinearRange ptrRange in this.LinearGauge.Ranges)
                {
                    int value = (int)Math.Ceiling(LinearGauge.MaximumValue - ptrRange.EndValue) / LinearGauge.MajorDifference;
                    if (ptrRange.EndValue > ptrRange.StartValue && ptrRange.EndValue <= this.LinearGauge.MaximumValue)
                    {
                        if (this.LinearGauge.MinimumValue >= 0 && ptrRange.StartValue < 0)
                        {
                            return;
                        }
                        float startValue = (float)ptrRange.StartValue;
                        float end = (float)ptrRange.EndValue;
                        if (this.LinearGauge.MinimumValue < 0)
                        {
                            startValue = this.LinearGauge.MinimumValue + Math.Abs(ptrRange.StartValue);
                        }
                        if (this.LinearGauge.MinimumValue < 0 && ptrRange.StartValue > 0)
                        {
                            startValue = Math.Abs(this.LinearGauge.MinimumValue) + Math.Abs(ptrRange.StartValue);
                        }
                        if (this.LinearGauge.MinimumValue < 0 && ptrRange.StartValue == 0)
                        {
                            startValue = Math.Abs(this.LinearGauge.MinimumValue) + Math.Abs(ptrRange.StartValue);
                            startValue = (((startValue / LinearGauge.MajorDifference)) * m_minorTicksPixels);
                        }

                        float height = (ptrRange.EndValue / LinearGauge.MajorDifference) * m_minorTicksPixels;
                        float endValueRangeHeight = 0f;
                        if (this.LinearGauge.MinimumValue < 0)
                        {
                            height = ((Math.Abs(this.LinearGauge.MinimumValue) + ptrRange.EndValue) / LinearGauge.MajorDifference) * m_minorTicksPixels;
                        }
                        endValueRangeHeight = height;
                        if (this.LinearGauge.MinimumValue < 0 && ptrRange.StartValue == 0)
                        {
                            endValueRangeHeight = (((ptrRange.EndValue - ptrRange.StartValue) / LinearGauge.MajorDifference) * m_minorTicksPixels);
                        }
                        if (ptrRange.StartValue == 0)
                            Graphics.FillRectangle(new SolidBrush(ptrRange.Color), this.LinearGauge.Width / 2 + 10, start + (majorTicksDistance * m_minorTicksPixels) - height, 8, endValueRangeHeight);
                        else if (ptrRange.StartValue > 0)
                            Graphics.FillRectangle(new SolidBrush(ptrRange.Color), this.LinearGauge.Width / 2 + 10, start + (majorTicksDistance * m_minorTicksPixels) - height, 8, (((ptrRange.EndValue - ptrRange.StartValue) / LinearGauge.MajorDifference) * m_minorTicksPixels));
                        else if (ptrRange.StartValue < 0)
                        {
                            Graphics.FillRectangle(new SolidBrush(ptrRange.Color), this.LinearGauge.Width / 2 + 10, start + (majorTicksDistance * m_minorTicksPixels) - height, 8, (((ptrRange.EndValue - ptrRange.StartValue) / LinearGauge.MajorDifference) * m_minorTicksPixels));
                        }
                    }
                }
            }

            public void DrawPointer(System.Drawing.Graphics Graphics)
            {
                Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                GraphicsPath path = new GraphicsPath();
                int a = 0;
                if (this.LinearGauge.MinimumValue < 0)
                    a = (int)Math.Ceiling((((Math.Abs(this.LinearGauge.MinimumValue) + LinearGauge.Value) / (float)LinearGauge.MajorDifference) * m_minorTicksPixels));
                else
                    a = (int)Math.Ceiling(((LinearGauge.Value / (float)LinearGauge.MajorDifference) * m_minorTicksPixels));
                int y = (this.LinearGauge.Height / 2 + 5 + LinearGauge.MajorTicksHeight) - LinearGauge.MajorTicksHeight;
                a = 10 + (int)Math.Ceiling((majorTicksDistance * m_minorTicksPixels)) - a;
                Rectangle rect = new Rectangle(new Point(this.LinearGauge.Width / 2 + 28, a), new Size(32, 32));
                SizeF sf = Graphics.MeasureString(this.LinearGauge.Value.ToString(), this.LinearGauge.GaugelabelFont);
                PointF point = new PointF(rect.X + rect.Width / 2 - sf.Width / 2, rect.Y + rect.Height / 2 - sf.Height / 2);
                Graphics.FillEllipse(new SolidBrush(LinearGauge.NeedleColor), rect);
                Graphics.DrawEllipse(new Pen(ColorTranslator.FromHtml("#00a0d1")), rect);
                Graphics.DrawLine(new Pen(ColorTranslator.FromHtml("#00a0d1")), rect.X, rect.Y + rect.Height / 2, rect.X - 18, rect.Y + rect.Height / 2);
                Graphics.DrawString(Math.Round(LinearGauge.Value, 2).ToString(), this.LinearGauge.GaugelabelFont, new SolidBrush(ColorTranslator.FromHtml("#ffffff")), point);
            }

            [Obsolete]
            public void UpdateRenderer(System.Windows.Forms.PaintEventArgs PaintEventArgs)
            {
                DrawLines(PaintEventArgs.Graphics);
                DrawRanges(PaintEventArgs.Graphics);
                DrawPointer(PaintEventArgs.Graphics);
            }
        }
        private void UserInitialization()
        {
            SerialSettings mySerialSettings = _spManager.CurrentSerialSettings;
            bindingSource1.DataSource = mySerialSettings;           
            comboBoxAdv1.DataSource=mySerialSettings.PortNameCollection;
            comboBoxAdv2.DataSource = mySerialSettings.BaudRateCollection;           
            _spManager.NewSerialDataRecieved += _spManager_NewSerialDataRecieved;        
        }


        List<byte> j = new List<byte>();    

        void _spManager_NewSerialDataRecieved(object sender, SerialDataEventArgs e)
        {
            if (this.InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                this.BeginInvoke(new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved), new object[] { sender, e });
                return;
            }
            // This application is connected to a GPS sending ASCCI characters, so data is converted to text           
            try
            {   
                string str = Encoding.ASCII.GetString(e.Data);
                //byte[] ascii = Encoding.ASCII.GetBytes(str);
                //foreach (byte b in ascii)
                //{
                //    j.Add(b);
                //    veriler += (char)(b);
                //}
                if (str == "")
                   labelError.Text += "Veri akışı yok.";
                else
                {

                    //str="#ES1*#s43*"
                    //int indexX = str.IndexOf('*');
                    //int indexSalsh = str.IndexOf('#');
                    String RXData = str.Substring(1);
                    String Command = RXData.Substring(0, 1);
                    String dataInfo = RXData.Substring(1);

                    // Array.Clear(datasplit, 0, datasplit.Length-3);
                    Debug.WriteLine("RXData: " + RXData);
                    switch (Command)
                    {
                        case "T":
                            Int32.TryParse(dataInfo, out MaxTemp);
                            break;
                        case "V":
                            Double.TryParse(dataInfo, out TotalVoltage);
                            TotalVoltage /= 100;
                            break;
                        case "c":
                            Double.TryParse(dataInfo, out CurrentCurrent);
                            CurrentCurrent /= 100;
                            break;
                        case "s":
                            double s;
                            Double.TryParse(dataInfo, out s);
                            Speed = (int)Math.Ceiling(s);
                            break;
                        case "v":
                            String[] cv = dataInfo.Split('/');
                            if (cv.Length == 2 && cv[1].Length > 0)
                            {
                                int i = Int32.Parse(cv[0]);
                                double v;
                                Double.TryParse(cv[1], out v);
                                int percent = (int)(v * 100 / 4.2);
                                batteryLevels[i].Text = String.Format("{0:0.00} V", v / 100);
                                BatteryPercent[i] = percent;
                            }
                            break;
                        case "t":
                            String[] temp = dataInfo.Split('/');

                            if (temp.Length == 2 && temp[1].Length > 0)
                            {
                                int i;
                                Int32.TryParse(temp[0], out i);
                                batteryTemps[i].Text = temp[1].Substring(0, 4) + "°C";
                            }
                            break;
                        case "E":
                          switch (dataInfo)
                            {   
                                case "S0":
                                    labelError.Text += "    |-HIZ";
                                    break;
                                case "S1":
                                    labelError.Text += "    |-HIZ Ölçülemiyor.     ";
                                    break;
                                case "B0":
                                    labelError.Text += "    |-BMS";
                                    break;
                                case "B1":
                                    labelError.Text += "    |-BMS değerleri ölçülemiyor.      ";
                                    break;
                                case "T0":
                                    labelError.Text += "    |-SICAKLIK";
                                    break;
                                case "T1":
                                    labelError.Text += "    |-SICAKLIK Ölçülemiyor.        ";
                                    break;
                                case "C0":
                                    labelError.Text += "    |-AKIM";
                                    break;
                                case "C1":
                                    labelError.Text += "    |-AKIM Ölçülemiyor.        ";
                                    break;
                                case "L0":
                                    labelError.Text += "    |-AYDINLATMA      ";
                                    break;
                                case "L1":
                                    labelError.Text += "    |-AYDINLATMA Hatası.      ";
                                    break;
                            }

                            break;
                        case "l":

                            if (dataInfo.Substring(0, 1) == "1")
                            {                               
                                pictureSagSig.Visible = true;
                                pictureSolSig.Visible = true;
                            }
                            else if (dataInfo.Substring(0, 1) == "2")
                            {
                               
                                pictureSagSig.Visible = true;
                                pictureSolSig.Visible = false;
                            }
                            else if (dataInfo.Substring(0, 1) == "3")
                            {
                               
                                pictureSagSig.Visible = false;
                                pictureSolSig.Visible = true;
                            }
                            else if (dataInfo.Substring(0, 1) == "0")
                            {
                              
                                pictureSagSig.Visible = false;
                                pictureSolSig.Visible = false;
                            }
                            else if (dataInfo.Substring(1, 1) == "1") {
                                pictureSag.Visible = false;
                                pictureSol.Visible = false;
                                pictureSagGif.Visible = true;
                                pictureSolGif.Visible = true;
                                pictureSagGif.Enabled = true;
                                pictureSolGif.Enabled = true;
                            }
                           
                                                  
                            
                            else if( dataInfo.Substring(3, 1) == "1")
                            { 
                            pictureSag.Visible = false;
                            pictureSol.Visible = false;
                            pictureSagGif.Visible = true;
                            pictureSolGif.Visible = true;
                            pictureSagGif.Enabled = true;
                            pictureSolGif.Enabled = true;
                            }                
                   
                    break;
                        default:
                            Debug.WriteLine("Undefined chracter: " + RXData);
                            break;
                    }
                }
            }
            catch (Exception hata )         {
                Debug.WriteLine(hata);
            }
        }

        private void Panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

      
        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ReadArduino();
            pictureBox2.Visible = false;
          
        }
        public  void ReadArduino()
        {
            try
            {                               
                label1.Text = "Bağlanıyor..";                    
                _spManager.StartListening();
                label1.Text = "Bağlandı.";
                bunifuFlatButton1.Text = "Kontrol Sende";               
                bunifuCircleProgressbar3.Value = 100;
                pictureSagSig.Enabled = true;
                pictureSolSig.Enabled = true;
                pictureSag.Visible = false;
                pictureSol.Visible = false;
                pictureSolSig.Enabled = true;
                pictureSolSig.Enabled = true;
                pictureSagGif.Visible = true;
                pictureSolGif.Visible = true;
                pictureSagGif.Enabled = true;
                pictureSolGif.Enabled = true;                
                Thread.Sleep(500);
                timer1.Start();
                timer2.Start();
                timer4.Start();
               
            }
            catch (Exception)
            {
                label1.Text = "Bağlantı yok.";               
                bunifuFlatButton1.Text = "Tekrar Dene";
                bunifuCircleProgressbar3.Value = 20;
                pictureSag.Visible = false;
                pictureSol.Visible = false;
                pictureSagGif.Visible = true;
                pictureSolGif.Visible = true;
                pictureSagGif.Enabled = true;
                pictureSolGif.Enabled = true;

                pictureSagSig.Enabled = true;
                pictureSolSig.Enabled = true;

                timer2.Start();
            }
        }

        private  void Timer1_Tick(object sender, EventArgs e)
        {
            linearGauge1.Value = MaxTemp;
            radialGauge1.Value= Speed;
            bunifuCustomLabelSpeed.Text = Speed.ToString();
            bunifuCustomLabelTemp.Text = MaxTemp.ToString();
            bunifuCustomLabelVolt.Text = TotalVoltage.ToString();        }
           

        private  void Timer2_Tick(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Minimum = mimm;
            chart1.ChartAreas[0].AxisX.Maximum = maksm;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 200;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(mimm, maksm);
            this.chart1.Series[0].Points.AddXY((maksm), Speed);
            this.chart1.Series[1].Points.AddXY((maksm), MaxTemp);
            maksm++;
            mimm++;

            String logString = "";

            logString = "Saat: " + DateTime.Now.ToString() + " ";
            logString += "Toplam gerilim: " + TotalVoltage.ToString() + "V ";
            logString += "En yüksek Sıccaklık: " + MaxTemp.ToString() + "C ";
            logString += "Akım: " + CurrentCurrent.ToString() + "A ";
            logString += "Hız: " + Speed.ToString() + " km/h";

            for (int i = 0; i < 24; i++)
            {
                logString += i % 8 == 0 ? "\r\n" : "";
                logString += "Hücre1V: " + "0" + " Hücre1T: " +"0"+ "  ";
            }

            logString += "\r\n\r\n";

           
            this.SaveLog(logString);
        }    
             

        
       

        private void Timer3_Tick(object sender, EventArgs e)
        {
            
            // labelError.Text = labelError.Text.Substring(1) + labelError.Text.Substring(0, 1);
            if (labelError.Left > 0)
            {
                labelError.Left -= 16;
            }
            else
            {
                labelError.Left = 1511;
            }
            
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            this.clock2.CustomTime = this.clock2.CustomTime.AddSeconds(+1);
            
        }

      
        Process LogProcess;
        Boolean durum = false;
        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (durum == true)
                {
                    LogProcess.CloseMainWindow();
                    LogProcess.Close();
                    bunifuFlatButton2.Text = "KAYITLARI GÖSTER";
                    durum = false;
                }
                else if (durum == false)
                {
                    LogProcess = Process.Start(this.LogFilename);                    
                    bunifuFlatButton2.Text = "KAYITLARI KAPAT";
                    durum = true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                bunifuFlatButton2.Text = "KAYITLARI GÖSTER";
                durum = false;
            }
            finally
            {
            }
        }
        private String LogFolder = @"C:\TM";
        private String LogFilename = @"C:\TM\TM.log";

        private void SaveLog(String s)
        {
            if (!Directory.Exists(this.LogFolder))
            {
                DirectoryInfo di = Directory.CreateDirectory(this.LogFolder);
                File.WriteAllText(this.LogFilename, "TÜRK MEKATRONİK\n\r\n\r");
            }

            File.AppendAllText(this.LogFilename, s);
        }

        private void BunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer4.Stop();
            _spManager.Dispose();
            Application.Exit();
        }

        private void ComboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SerialSettings mySerialSettings = _spManager.CurrentSerialSettings;
             //mySerialSettings.PortName = comboBoxAdv1.SelectedItem.ToString();
        }

        private void ComboBoxAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SerialSettings mySerialSettings = _spManager.CurrentSerialSettings;
           // mySerialSettings.BaudRate = Convert.ToInt32(comboBoxAdv2.SelectedItem);
        }

        private void GradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer3.Start();
            this.clock2.ShowCustomTimeClock = true;
            // To hide Dates in Digital Clock   
            this.clock2.DisplayDates = false;
            //To set the Custom time / Reset the clock   
            this.clock2.CustomTime = new DateTime();
            // To Freeze and Un Freeze the Clock   
            this.clock2.StopTimer = false;
            this.radialGauge1.BringToFront();
            this.linearGauge1.BringToFront();
            pictureSolGif.Enabled = false;
            //this.pictureBox2.BringToFront();
           
        }
    }
        
    }
    