using Bunifu.Framework.UI;

namespace cartest2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.DigitalClockRenderer digitalClockRenderer1 = new Syncfusion.Windows.Forms.Tools.DigitalClockRenderer();
            Syncfusion.Windows.Forms.Tools.ClockRenderer clockRenderer1 = new Syncfusion.Windows.Forms.Tools.ClockRenderer();
            Syncfusion.Windows.Forms.Tools.DigitalClockRenderer digitalClockRenderer2 = new Syncfusion.Windows.Forms.Tools.DigitalClockRenderer();
            Syncfusion.Windows.Forms.Tools.ClockRenderer clockRenderer2 = new Syncfusion.Windows.Forms.Tools.ClockRenderer();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.clock2 = new Syncfusion.Windows.Forms.Tools.Clock();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabelTemp = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.clock1 = new Syncfusion.Windows.Forms.Tools.Clock();
            this.bunifuCustomLabelVolt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabelSpeed = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.radialGauge1 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.splashControl1 = new Syncfusion.Windows.Forms.Tools.SplashControl();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.pictureSagSig = new System.Windows.Forms.PictureBox();
            this.pictureSolSig = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureSol = new System.Windows.Forms.PictureBox();
            this.pictureSag = new System.Windows.Forms.PictureBox();
            this.pictureSolGif = new System.Windows.Forms.PictureBox();
            this.pictureSagGif = new System.Windows.Forms.PictureBox();
            this.labelError = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label26 = new System.Windows.Forms.Label();
            this.linearGauge1 = new Syncfusion.Windows.Forms.Gauge.LinearGauge();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCircleProgressbar3 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar4 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar5 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar6 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar7 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar8 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar9 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar10 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar11 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar12 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar13 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar14 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar15 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar16 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar17 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar18 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar19 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar20 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar21 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar26 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar27 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar28 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar29 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar30 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar31 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar32 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar33 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar34 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar35 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar36 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSagSig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSolSig)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSolGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSagGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel4
            // 
            this.panel4.AllowDrop = true;
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.clock2);
            this.panel4.Controls.Add(this.bunifuCustomLabel2);
            this.panel4.Controls.Add(this.bunifuCustomLabelTemp);
            this.panel4.Controls.Add(this.bunifuCustomLabel6);
            this.panel4.Controls.Add(this.clock1);
            this.panel4.Controls.Add(this.bunifuCustomLabelVolt);
            this.panel4.Controls.Add(this.bunifuCustomLabelSpeed);
            this.panel4.Controls.Add(this.bunifuCustomLabel3);
            this.panel4.Location = new System.Drawing.Point(396, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(939, 70);
            this.panel4.TabIndex = 10;
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel4_MouseMove);
            // 
            // clock2
            // 
            this.clock2.BackgroundColor = System.Drawing.Color.Transparent;
            this.clock2.BeforeTouchSize = new System.Drawing.Size(164, 82);
            this.clock2.BorderColor = System.Drawing.Color.Transparent;
            this.clock2.ClockFormat = "HH:mm:ss";
            this.clock2.ClockFrame = Syncfusion.Windows.Forms.Tools.ClockFrames.RectangularFrame;
            this.clock2.ClockShape = Syncfusion.Windows.Forms.Tools.ClockShapes.Rectangle;
            this.clock2.ClockType = Syncfusion.Windows.Forms.Tools.ClockTypes.Digital;
            this.clock2.CurrentDateTime = new System.DateTime(2019, 7, 23, 17, 41, 43, 342);
            this.clock2.CustomTime = new System.DateTime(2019, 8, 4, 2, 10, 1, 530);
            this.clock2.DigitalRenderer = digitalClockRenderer1;
            this.clock2.DisplayDates = true;
            this.clock2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clock2.Location = new System.Drawing.Point(0, -4);
            this.clock2.MinimumSize = new System.Drawing.Size(75, 75);
            this.clock2.Name = "clock2";
            this.clock2.Now = new System.DateTime(((long)(0)));
            this.clock2.Remainder = new System.DateTime(2019, 7, 23, 17, 41, 43, 342);
            this.clock2.Renderer = clockRenderer1;
            this.clock2.ShowClockFrame = false;
            this.clock2.ShowCustomTimeClock = false;
            this.clock2.ShowHourDesignator = false;
            this.clock2.Size = new System.Drawing.Size(164, 82);
            this.clock2.StopTimer = false;
            this.clock2.TabIndex = 29;
            this.clock2.Text = "clock2";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(518, 42);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(60, 20);
            this.bunifuCustomLabel2.TabIndex = 24;
            this.bunifuCustomLabel2.Text = "Sıcaklık";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.BunifuCustomLabel2_Click);
            // 
            // bunifuCustomLabelTemp
            // 
            this.bunifuCustomLabelTemp.AutoSize = true;
            this.bunifuCustomLabelTemp.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabelTemp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabelTemp.Location = new System.Drawing.Point(514, 0);
            this.bunifuCustomLabelTemp.Name = "bunifuCustomLabelTemp";
            this.bunifuCustomLabelTemp.Size = new System.Drawing.Size(83, 45);
            this.bunifuCustomLabelTemp.TabIndex = 23;
            this.bunifuCustomLabelTemp.Text = "%92";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(438, 42);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(35, 20);
            this.bunifuCustomLabel6.TabIndex = 7;
            this.bunifuCustomLabel6.Text = "Güç";
            // 
            // clock1
            // 
            this.clock1.BackgroundColor = System.Drawing.Color.Black;
            this.clock1.BeforeTouchSize = new System.Drawing.Size(165, 82);
            this.clock1.BorderColor = System.Drawing.Color.Transparent;
            this.clock1.ClockFormat = "HH:mm:ss";
            this.clock1.ClockFrame = Syncfusion.Windows.Forms.Tools.ClockFrames.RectangularFrame;
            this.clock1.ClockShape = Syncfusion.Windows.Forms.Tools.ClockShapes.Rectangle;
            this.clock1.ClockType = Syncfusion.Windows.Forms.Tools.ClockTypes.Digital;
            this.clock1.CurrentDateTime = new System.DateTime(2019, 5, 8, 23, 10, 57, 45);
            this.clock1.CustomTime = new System.DateTime(2019, 8, 4, 2, 10, 1, 576);
            this.clock1.DigitalRenderer = digitalClockRenderer2;
            this.clock1.DisplayDates = true;
            this.clock1.EndGradientBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clock1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clock1.Location = new System.Drawing.Point(773, -9);
            this.clock1.MinimumSize = new System.Drawing.Size(75, 75);
            this.clock1.Name = "clock1";
            this.clock1.Now = new System.DateTime(((long)(0)));
            this.clock1.Remainder = new System.DateTime(2019, 5, 8, 23, 10, 57, 44);
            this.clock1.Renderer = clockRenderer2;
            this.clock1.ShowClockFrame = false;
            this.clock1.ShowCustomTimeClock = false;
            this.clock1.ShowHourDesignator = false;
            this.clock1.Size = new System.Drawing.Size(165, 82);
            this.clock1.StartGradientBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.clock1.StopTimer = false;
            this.clock1.TabIndex = 8;
            this.clock1.Text = "clock1";
            // 
            // bunifuCustomLabelVolt
            // 
            this.bunifuCustomLabelVolt.AutoSize = true;
            this.bunifuCustomLabelVolt.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabelVolt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabelVolt.Location = new System.Drawing.Point(412, 0);
            this.bunifuCustomLabelVolt.Name = "bunifuCustomLabelVolt";
            this.bunifuCustomLabelVolt.Size = new System.Drawing.Size(83, 45);
            this.bunifuCustomLabelVolt.TabIndex = 6;
            this.bunifuCustomLabelVolt.Text = "%92";
            // 
            // bunifuCustomLabelSpeed
            // 
            this.bunifuCustomLabelSpeed.AutoSize = true;
            this.bunifuCustomLabelSpeed.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabelSpeed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabelSpeed.Location = new System.Drawing.Point(326, 0);
            this.bunifuCustomLabelSpeed.Name = "bunifuCustomLabelSpeed";
            this.bunifuCustomLabelSpeed.Size = new System.Drawing.Size(56, 45);
            this.bunifuCustomLabelSpeed.TabIndex = 2;
            this.bunifuCustomLabelSpeed.Text = "85";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(318, 45);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(64, 20);
            this.bunifuCustomLabel3.TabIndex = 3;
            this.bunifuCustomLabel3.Text = "Km/saat";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Kayıtları Göster";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 10;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 100D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(4, 370);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(14, 4, 4, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(383, 103);
            this.bunifuFlatButton2.TabIndex = 30;
            this.bunifuFlatButton2.Text = "Kayıtları Göster";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Başla";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::cartest2.Properties.Resources.button;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 10;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 90D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 100D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(4, 246);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(14, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(387, 98);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "Başla";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.BackSecondaryColor = System.Drawing.Color.Black;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.BlanchedAlmond;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(8, 501);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.WhiteSmoke;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Black;
            series1.MarkerColor = System.Drawing.Color.WhiteSmoke;
            series1.MarkerSize = 8;
            series1.MarkerStep = 10;
            series1.Name = "Series1";
            series2.BackImageTransparentColor = System.Drawing.Color.White;
            series2.BorderColor = System.Drawing.Color.WhiteSmoke;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Black;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(367, 336);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(4, 137);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(90, 20);
            this.bunifuCustomLabel9.TabIndex = 3;
            this.bunifuCustomLabel9.Text = "BOUD RATE";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 57);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(84, 20);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "COM PORT";
            // 
            // radialGauge1
            // 
            this.radialGauge1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.radialGauge1.ArcThickness = 2F;
            this.radialGauge1.EnableCustomNeedles = false;
            this.radialGauge1.GaugeArcColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.radialGauge1.GaugeLabel = "Km/saat";
            this.radialGauge1.GaugeLableColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.radialGauge1.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.Location = new System.Drawing.Point(273, 0);
            this.radialGauge1.Margin = new System.Windows.Forms.Padding(5);
            this.radialGauge1.MinimumSize = new System.Drawing.Size(125, 125);
            this.radialGauge1.Name = "radialGauge1";
            this.radialGauge1.Padding = new System.Windows.Forms.Padding(5);
            this.radialGauge1.ShowTicks = true;
            this.radialGauge1.Size = new System.Drawing.Size(372, 372);
            this.radialGauge1.TabIndex = 14;
            this.radialGauge1.Value = 88F;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = null;
            this.bunifuDragControl3.Vertical = true;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // splashControl1
            // 
            this.splashControl1.AutoModeDisableOwner = true;
            this.splashControl1.CloseSplashForm = true;
            this.splashControl1.HideHostForm = true;
            this.splashControl1.HostForm = this;
            this.splashControl1.SplashImage = ((System.Drawing.Image)(resources.GetObject("splashControl1.SplashImage")));
            this.splashControl1.Text = "";
            this.splashControl1.TimerInterval = 1000;
            this.splashControl1.TransparentColor = System.Drawing.Color.Transparent;
            this.splashControl1.UseCustomSplashPanel = true;
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.Timer4_Tick);
            // 
            // pictureSagSig
            // 
            this.pictureSagSig.Enabled = false;
            this.pictureSagSig.Image = ((System.Drawing.Image)(resources.GetObject("pictureSagSig.Image")));
            this.pictureSagSig.Location = new System.Drawing.Point(100, 162);
            this.pictureSagSig.Name = "pictureSagSig";
            this.pictureSagSig.Size = new System.Drawing.Size(161, 137);
            this.pictureSagSig.TabIndex = 29;
            this.pictureSagSig.TabStop = false;
            // 
            // pictureSolSig
            // 
            this.pictureSolSig.Enabled = false;
            this.pictureSolSig.Image = ((System.Drawing.Image)(resources.GetObject("pictureSolSig.Image")));
            this.pictureSolSig.Location = new System.Drawing.Point(663, 162);
            this.pictureSolSig.Name = "pictureSolSig";
            this.pictureSolSig.Size = new System.Drawing.Size(161, 137);
            this.pictureSolSig.TabIndex = 30;
            this.pictureSolSig.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.pictureSol);
            this.panel5.Controls.Add(this.pictureSag);
            this.panel5.Controls.Add(this.pictureSolGif);
            this.panel5.Controls.Add(this.pictureSagGif);
            this.panel5.Controls.Add(this.pictureSolSig);
            this.panel5.Controls.Add(this.pictureSagSig);
            this.panel5.Controls.Add(this.radialGauge1);
            this.panel5.Controls.Add(this.labelError);
            this.panel5.Location = new System.Drawing.Point(396, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(938, 568);
            this.panel5.TabIndex = 32;
            // 
            // pictureSol
            // 
            this.pictureSol.Image = ((System.Drawing.Image)(resources.GetObject("pictureSol.Image")));
            this.pictureSol.Location = new System.Drawing.Point(463, 305);
            this.pictureSol.Name = "pictureSol";
            this.pictureSol.Size = new System.Drawing.Size(358, 240);
            this.pictureSol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSol.TabIndex = 35;
            this.pictureSol.TabStop = false;
            // 
            // pictureSag
            // 
            this.pictureSag.Image = ((System.Drawing.Image)(resources.GetObject("pictureSag.Image")));
            this.pictureSag.Location = new System.Drawing.Point(104, 305);
            this.pictureSag.Name = "pictureSag";
            this.pictureSag.Size = new System.Drawing.Size(358, 240);
            this.pictureSag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSag.TabIndex = 34;
            this.pictureSag.TabStop = false;
            // 
            // pictureSolGif
            // 
            this.pictureSolGif.Enabled = false;
            this.pictureSolGif.Image = ((System.Drawing.Image)(resources.GetObject("pictureSolGif.Image")));
            this.pictureSolGif.Location = new System.Drawing.Point(466, 305);
            this.pictureSolGif.Name = "pictureSolGif";
            this.pictureSolGif.Size = new System.Drawing.Size(358, 240);
            this.pictureSolGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSolGif.TabIndex = 33;
            this.pictureSolGif.TabStop = false;
            this.pictureSolGif.Visible = false;
            // 
            // pictureSagGif
            // 
            this.pictureSagGif.Enabled = false;
            this.pictureSagGif.Image = ((System.Drawing.Image)(resources.GetObject("pictureSagGif.Image")));
            this.pictureSagGif.Location = new System.Drawing.Point(104, 305);
            this.pictureSagGif.Name = "pictureSagGif";
            this.pictureSagGif.Size = new System.Drawing.Size(358, 240);
            this.pictureSagGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSagGif.TabIndex = 32;
            this.pictureSagGif.TabStop = false;
            this.pictureSagGif.Visible = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelError.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelError.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelError.ForeColor = System.Drawing.Color.White;
            this.labelError.Location = new System.Drawing.Point(852, 539);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(63, 21);
            this.labelError.TabIndex = 28;
            this.labelError.Text = "Durum:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(380, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(382, 382);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 34;
            this.pictureBox6.TabStop = false;
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = true;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 6;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(387, 636);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar1.TabIndex = 54;
            this.bunifuCircleProgressbar1.Value = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(398, 713);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "label3";
            // 
            // bunifuCircleProgressbar2
            // 
            this.bunifuCircleProgressbar2.animated = true;
            this.bunifuCircleProgressbar2.animationIterval = 5;
            this.bunifuCircleProgressbar2.animationSpeed = 300;
            this.bunifuCircleProgressbar2.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar2.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar2.BackgroundImage")));
            this.bunifuCircleProgressbar2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar2.LabelVisible = true;
            this.bunifuCircleProgressbar2.LineProgressThickness = 8;
            this.bunifuCircleProgressbar2.LineThickness = 6;
            this.bunifuCircleProgressbar2.Location = new System.Drawing.Point(386, 752);
            this.bunifuCircleProgressbar2.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar2.MaxValue = 100;
            this.bunifuCircleProgressbar2.Name = "bunifuCircleProgressbar2";
            this.bunifuCircleProgressbar2.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar2.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar2.TabIndex = 83;
            this.bunifuCircleProgressbar2.Value = 87;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219))))), System.Drawing.Color.Black);
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.comboBoxAdv2);
            this.gradientPanel1.Controls.Add(this.comboBoxAdv1);
            this.gradientPanel1.Controls.Add(this.bunifuFlatButton3);
            this.gradientPanel1.Controls.Add(this.bunifuFlatButton2);
            this.gradientPanel1.Controls.Add(this.chart1);
            this.gradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.gradientPanel1.Controls.Add(this.bunifuCustomLabel9);
            this.gradientPanel1.Controls.Add(this.bunifuFlatButton1);
            this.gradientPanel1.Location = new System.Drawing.Point(-5, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(391, 888);
            this.gradientPanel1.TabIndex = 28;
            this.gradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GradientPanel1_MouseMove);
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBoxAdv2.BeforeTouchSize = new System.Drawing.Size(366, 46);
            this.comboBoxAdv2.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold);
            this.comboBoxAdv2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.comboBoxAdv2.Location = new System.Drawing.Point(9, 175);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(366, 46);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Black;
            this.comboBoxAdv2.TabIndex = 40;
            this.comboBoxAdv2.Text = "comboBoxAdv2";
            this.comboBoxAdv2.ThemeName = "Office2016Black";
            this.comboBoxAdv2.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAdv2_SelectedIndexChanged);
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(366, 46);
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold);
            this.comboBoxAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.comboBoxAdv1.Location = new System.Drawing.Point(9, 80);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(366, 46);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Black;
            this.comboBoxAdv1.TabIndex = 39;
            this.comboBoxAdv1.Text = "comboBoxAdv1";
            this.comboBoxAdv1.ThemeName = "Office2016Black";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAdv1_SelectedIndexChanged);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.BackgroundImage")));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 1;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(4, 0);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Padding = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(73, 52);
            this.bunifuFlatButton3.TabIndex = 38;
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.BunifuFlatButton3_Click_1);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label26.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label26.Location = new System.Drawing.Point(392, 819);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 20);
            this.label26.TabIndex = 71;
            this.label26.Text = "label26";
            // 
            // linearGauge1
            // 
            this.linearGauge1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.linearGauge1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.linearGauge1.GaugelabelFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linearGauge1.InnerFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.linearGauge1.LinearFrameType = Syncfusion.Windows.Forms.Gauge.LinearFrameType.Horizontal;
            this.linearGauge1.Location = new System.Drawing.Point(102, 26);
            this.linearGauge1.MajorDifference = 10;
            this.linearGauge1.MajorTickMarkColor = System.Drawing.Color.WhiteSmoke;
            this.linearGauge1.MajorTicksHeight = 15;
            this.linearGauge1.MaximumValue = 100F;
            this.linearGauge1.MinimumSize = new System.Drawing.Size(100, 50);
            this.linearGauge1.MinorTickCount = 10;
            this.linearGauge1.MinorTickHeight = 10;
            this.linearGauge1.MinorTickMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.linearGauge1.Name = "linearGauge1";
            this.linearGauge1.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.linearGauge1.OuterFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.linearGauge1.PointerPlacement = Syncfusion.Windows.Forms.Gauge.Placement.Center;
            this.linearGauge1.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.linearGauge1.ScaleLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.linearGauge1.Size = new System.Drawing.Size(171, 675);
            this.linearGauge1.TabIndex = 16;
            this.linearGauge1.Text = "linearGauge1";
            this.linearGauge1.ThemeStyle.ChannelHeight = 8;
            this.linearGauge1.ThemeStyle.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linearGauge1.ThemeStyle.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(52)))), ((int)(((byte)(113)))));
            this.linearGauge1.ThemeStyle.MinorTickMarkColor = System.Drawing.Color.Red;
            this.linearGauge1.ThemeStyle.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(52)))), ((int)(((byte)(113)))));
            this.linearGauge1.ThemeStyle.OuterFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(52)))), ((int)(((byte)(113)))));
            this.linearGauge1.ThemeStyle.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(52)))), ((int)(((byte)(113)))));
            this.linearGauge1.ThemeStyle.ValueIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(52)))), ((int)(((byte)(113)))));
            this.linearGauge1.Value = 60F;
            this.linearGauge1.ValueIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219))))));
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel2.Controls.Add(this.linearGauge1);
            this.gradientPanel2.Controls.Add(this.label21);
            this.gradientPanel2.Controls.Add(this.pictureBox1);
            this.gradientPanel2.Location = new System.Drawing.Point(1340, -5);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(374, 893);
            this.gradientPanel2.TabIndex = 31;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Courier New", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label21.Location = new System.Drawing.Point(122, 826);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(134, 18);
            this.label21.TabIndex = 21;
            this.label21.Text = "TürkMekatronik";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::cartest2.Properties.Resources._4qUFy_8w_400x400_removebg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 651);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 298);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCircleProgressbar3
            // 
            this.bunifuCircleProgressbar3.animated = true;
            this.bunifuCircleProgressbar3.animationIterval = 5;
            this.bunifuCircleProgressbar3.animationSpeed = 300;
            this.bunifuCircleProgressbar3.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar3.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar3.BackgroundImage")));
            this.bunifuCircleProgressbar3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar3.LabelVisible = true;
            this.bunifuCircleProgressbar3.LineProgressThickness = 8;
            this.bunifuCircleProgressbar3.LineThickness = 6;
            this.bunifuCircleProgressbar3.Location = new System.Drawing.Point(450, 637);
            this.bunifuCircleProgressbar3.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar3.MaxValue = 100;
            this.bunifuCircleProgressbar3.Name = "bunifuCircleProgressbar3";
            this.bunifuCircleProgressbar3.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar3.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar3.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar3.TabIndex = 106;
            this.bunifuCircleProgressbar3.Value = 87;
            // 
            // bunifuCircleProgressbar4
            // 
            this.bunifuCircleProgressbar4.animated = true;
            this.bunifuCircleProgressbar4.animationIterval = 5;
            this.bunifuCircleProgressbar4.animationSpeed = 300;
            this.bunifuCircleProgressbar4.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar4.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar4.BackgroundImage")));
            this.bunifuCircleProgressbar4.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar4.LabelVisible = true;
            this.bunifuCircleProgressbar4.LineProgressThickness = 8;
            this.bunifuCircleProgressbar4.LineThickness = 6;
            this.bunifuCircleProgressbar4.Location = new System.Drawing.Point(450, 747);
            this.bunifuCircleProgressbar4.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar4.MaxValue = 100;
            this.bunifuCircleProgressbar4.Name = "bunifuCircleProgressbar4";
            this.bunifuCircleProgressbar4.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar4.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar4.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar4.TabIndex = 109;
            this.bunifuCircleProgressbar4.Value = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(455, 820);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 108;
            this.label1.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(461, 714);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 107;
            this.label4.Text = "label4";
            // 
            // bunifuCircleProgressbar5
            // 
            this.bunifuCircleProgressbar5.animated = true;
            this.bunifuCircleProgressbar5.animationIterval = 5;
            this.bunifuCircleProgressbar5.animationSpeed = 300;
            this.bunifuCircleProgressbar5.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar5.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar5.BackgroundImage")));
            this.bunifuCircleProgressbar5.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar5.LabelVisible = true;
            this.bunifuCircleProgressbar5.LineProgressThickness = 8;
            this.bunifuCircleProgressbar5.LineThickness = 6;
            this.bunifuCircleProgressbar5.Location = new System.Drawing.Point(576, 638);
            this.bunifuCircleProgressbar5.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar5.MaxValue = 100;
            this.bunifuCircleProgressbar5.Name = "bunifuCircleProgressbar5";
            this.bunifuCircleProgressbar5.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar5.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.bunifuCircleProgressbar5.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar5.TabIndex = 114;
            this.bunifuCircleProgressbar5.Value = 87;
            // 
            // bunifuCircleProgressbar6
            // 
            this.bunifuCircleProgressbar6.animated = true;
            this.bunifuCircleProgressbar6.animationIterval = 5;
            this.bunifuCircleProgressbar6.animationSpeed = 300;
            this.bunifuCircleProgressbar6.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar6.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar6.BackgroundImage")));
            this.bunifuCircleProgressbar6.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar6.LabelVisible = true;
            this.bunifuCircleProgressbar6.LineProgressThickness = 8;
            this.bunifuCircleProgressbar6.LineThickness = 6;
            this.bunifuCircleProgressbar6.Location = new System.Drawing.Point(576, 746);
            this.bunifuCircleProgressbar6.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar6.MaxValue = 100;
            this.bunifuCircleProgressbar6.Name = "bunifuCircleProgressbar6";
            this.bunifuCircleProgressbar6.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar6.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar6.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar6.TabIndex = 117;
            this.bunifuCircleProgressbar6.Value = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(581, 821);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 116;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(587, 715);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 115;
            this.label6.Text = "label6";
            // 
            // bunifuCircleProgressbar7
            // 
            this.bunifuCircleProgressbar7.animated = true;
            this.bunifuCircleProgressbar7.animationIterval = 5;
            this.bunifuCircleProgressbar7.animationSpeed = 300;
            this.bunifuCircleProgressbar7.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar7.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar7.BackgroundImage")));
            this.bunifuCircleProgressbar7.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar7.LabelVisible = true;
            this.bunifuCircleProgressbar7.LineProgressThickness = 8;
            this.bunifuCircleProgressbar7.LineThickness = 6;
            this.bunifuCircleProgressbar7.Location = new System.Drawing.Point(513, 637);
            this.bunifuCircleProgressbar7.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar7.MaxValue = 100;
            this.bunifuCircleProgressbar7.Name = "bunifuCircleProgressbar7";
            this.bunifuCircleProgressbar7.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar7.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar7.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar7.TabIndex = 110;
            this.bunifuCircleProgressbar7.Value = 87;
            // 
            // bunifuCircleProgressbar8
            // 
            this.bunifuCircleProgressbar8.animated = true;
            this.bunifuCircleProgressbar8.animationIterval = 5;
            this.bunifuCircleProgressbar8.animationSpeed = 300;
            this.bunifuCircleProgressbar8.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar8.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar8.BackgroundImage")));
            this.bunifuCircleProgressbar8.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar8.LabelVisible = true;
            this.bunifuCircleProgressbar8.LineProgressThickness = 8;
            this.bunifuCircleProgressbar8.LineThickness = 6;
            this.bunifuCircleProgressbar8.Location = new System.Drawing.Point(513, 745);
            this.bunifuCircleProgressbar8.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar8.MaxValue = 100;
            this.bunifuCircleProgressbar8.Name = "bunifuCircleProgressbar8";
            this.bunifuCircleProgressbar8.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar8.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar8.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar8.TabIndex = 113;
            this.bunifuCircleProgressbar8.Value = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(518, 820);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 112;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(524, 714);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 111;
            this.label8.Text = "label8";
            // 
            // bunifuCircleProgressbar9
            // 
            this.bunifuCircleProgressbar9.animated = true;
            this.bunifuCircleProgressbar9.animationIterval = 5;
            this.bunifuCircleProgressbar9.animationSpeed = 300;
            this.bunifuCircleProgressbar9.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar9.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar9.BackgroundImage")));
            this.bunifuCircleProgressbar9.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar9.LabelVisible = true;
            this.bunifuCircleProgressbar9.LineProgressThickness = 8;
            this.bunifuCircleProgressbar9.LineThickness = 6;
            this.bunifuCircleProgressbar9.Location = new System.Drawing.Point(766, 636);
            this.bunifuCircleProgressbar9.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar9.MaxValue = 100;
            this.bunifuCircleProgressbar9.Name = "bunifuCircleProgressbar9";
            this.bunifuCircleProgressbar9.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar9.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar9.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar9.TabIndex = 132;
            this.bunifuCircleProgressbar9.Value = 87;
            // 
            // bunifuCircleProgressbar10
            // 
            this.bunifuCircleProgressbar10.animated = true;
            this.bunifuCircleProgressbar10.animationIterval = 5;
            this.bunifuCircleProgressbar10.animationSpeed = 300;
            this.bunifuCircleProgressbar10.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar10.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar10.BackgroundImage")));
            this.bunifuCircleProgressbar10.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar10.LabelVisible = true;
            this.bunifuCircleProgressbar10.LineProgressThickness = 8;
            this.bunifuCircleProgressbar10.LineThickness = 6;
            this.bunifuCircleProgressbar10.Location = new System.Drawing.Point(766, 744);
            this.bunifuCircleProgressbar10.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar10.MaxValue = 100;
            this.bunifuCircleProgressbar10.Name = "bunifuCircleProgressbar10";
            this.bunifuCircleProgressbar10.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar10.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar10.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar10.TabIndex = 135;
            this.bunifuCircleProgressbar10.Value = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(771, 819);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 134;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(777, 713);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 133;
            this.label10.Text = "label10";
            // 
            // bunifuCircleProgressbar11
            // 
            this.bunifuCircleProgressbar11.animated = true;
            this.bunifuCircleProgressbar11.animationIterval = 5;
            this.bunifuCircleProgressbar11.animationSpeed = 300;
            this.bunifuCircleProgressbar11.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar11.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar11.BackgroundImage")));
            this.bunifuCircleProgressbar11.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar11.LabelVisible = true;
            this.bunifuCircleProgressbar11.LineProgressThickness = 8;
            this.bunifuCircleProgressbar11.LineThickness = 6;
            this.bunifuCircleProgressbar11.Location = new System.Drawing.Point(703, 635);
            this.bunifuCircleProgressbar11.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar11.MaxValue = 100;
            this.bunifuCircleProgressbar11.Name = "bunifuCircleProgressbar11";
            this.bunifuCircleProgressbar11.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar11.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar11.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar11.TabIndex = 128;
            this.bunifuCircleProgressbar11.Value = 87;
            // 
            // bunifuCircleProgressbar12
            // 
            this.bunifuCircleProgressbar12.animated = true;
            this.bunifuCircleProgressbar12.animationIterval = 5;
            this.bunifuCircleProgressbar12.animationSpeed = 300;
            this.bunifuCircleProgressbar12.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar12.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar12.BackgroundImage")));
            this.bunifuCircleProgressbar12.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar12.LabelVisible = true;
            this.bunifuCircleProgressbar12.LineProgressThickness = 8;
            this.bunifuCircleProgressbar12.LineThickness = 6;
            this.bunifuCircleProgressbar12.Location = new System.Drawing.Point(703, 743);
            this.bunifuCircleProgressbar12.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar12.MaxValue = 100;
            this.bunifuCircleProgressbar12.Name = "bunifuCircleProgressbar12";
            this.bunifuCircleProgressbar12.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar12.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar12.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar12.TabIndex = 131;
            this.bunifuCircleProgressbar12.Value = 87;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(708, 818);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 130;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(714, 712);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 129;
            this.label12.Text = "label12";
            // 
            // bunifuCircleProgressbar13
            // 
            this.bunifuCircleProgressbar13.animated = true;
            this.bunifuCircleProgressbar13.animationIterval = 5;
            this.bunifuCircleProgressbar13.animationSpeed = 300;
            this.bunifuCircleProgressbar13.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar13.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar13.BackgroundImage")));
            this.bunifuCircleProgressbar13.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar13.LabelVisible = true;
            this.bunifuCircleProgressbar13.LineProgressThickness = 8;
            this.bunifuCircleProgressbar13.LineThickness = 6;
            this.bunifuCircleProgressbar13.Location = new System.Drawing.Point(640, 635);
            this.bunifuCircleProgressbar13.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar13.MaxValue = 100;
            this.bunifuCircleProgressbar13.Name = "bunifuCircleProgressbar13";
            this.bunifuCircleProgressbar13.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar13.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar13.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar13.TabIndex = 124;
            this.bunifuCircleProgressbar13.Value = 87;
            // 
            // bunifuCircleProgressbar14
            // 
            this.bunifuCircleProgressbar14.animated = true;
            this.bunifuCircleProgressbar14.animationIterval = 5;
            this.bunifuCircleProgressbar14.animationSpeed = 300;
            this.bunifuCircleProgressbar14.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar14.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar14.BackgroundImage")));
            this.bunifuCircleProgressbar14.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar14.LabelVisible = true;
            this.bunifuCircleProgressbar14.LineProgressThickness = 8;
            this.bunifuCircleProgressbar14.LineThickness = 6;
            this.bunifuCircleProgressbar14.Location = new System.Drawing.Point(640, 743);
            this.bunifuCircleProgressbar14.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar14.MaxValue = 100;
            this.bunifuCircleProgressbar14.Name = "bunifuCircleProgressbar14";
            this.bunifuCircleProgressbar14.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar14.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar14.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar14.TabIndex = 127;
            this.bunifuCircleProgressbar14.Value = 87;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Location = new System.Drawing.Point(645, 818);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 20);
            this.label17.TabIndex = 126;
            this.label17.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Black;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label18.Location = new System.Drawing.Point(651, 712);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 20);
            this.label18.TabIndex = 125;
            this.label18.Text = "label18";
            // 
            // bunifuCircleProgressbar15
            // 
            this.bunifuCircleProgressbar15.animated = true;
            this.bunifuCircleProgressbar15.animationIterval = 5;
            this.bunifuCircleProgressbar15.animationSpeed = 300;
            this.bunifuCircleProgressbar15.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar15.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar15.BackgroundImage")));
            this.bunifuCircleProgressbar15.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar15.LabelVisible = true;
            this.bunifuCircleProgressbar15.LineProgressThickness = 8;
            this.bunifuCircleProgressbar15.LineThickness = 6;
            this.bunifuCircleProgressbar15.Location = new System.Drawing.Point(577, 634);
            this.bunifuCircleProgressbar15.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar15.MaxValue = 100;
            this.bunifuCircleProgressbar15.Name = "bunifuCircleProgressbar15";
            this.bunifuCircleProgressbar15.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar15.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar15.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar15.TabIndex = 120;
            this.bunifuCircleProgressbar15.Value = 87;
            // 
            // bunifuCircleProgressbar16
            // 
            this.bunifuCircleProgressbar16.animated = true;
            this.bunifuCircleProgressbar16.animationIterval = 5;
            this.bunifuCircleProgressbar16.animationSpeed = 300;
            this.bunifuCircleProgressbar16.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar16.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar16.BackgroundImage")));
            this.bunifuCircleProgressbar16.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar16.LabelVisible = true;
            this.bunifuCircleProgressbar16.LineProgressThickness = 8;
            this.bunifuCircleProgressbar16.LineThickness = 6;
            this.bunifuCircleProgressbar16.Location = new System.Drawing.Point(577, 742);
            this.bunifuCircleProgressbar16.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar16.MaxValue = 100;
            this.bunifuCircleProgressbar16.Name = "bunifuCircleProgressbar16";
            this.bunifuCircleProgressbar16.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar16.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar16.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar16.TabIndex = 123;
            this.bunifuCircleProgressbar16.Value = 87;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label19.Location = new System.Drawing.Point(582, 817);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 20);
            this.label19.TabIndex = 122;
            this.label19.Text = "label19";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Black;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label20.Location = new System.Drawing.Point(588, 711);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 20);
            this.label20.TabIndex = 121;
            this.label20.Text = "label20";
            // 
            // bunifuCircleProgressbar17
            // 
            this.bunifuCircleProgressbar17.animated = true;
            this.bunifuCircleProgressbar17.animationIterval = 5;
            this.bunifuCircleProgressbar17.animationSpeed = 300;
            this.bunifuCircleProgressbar17.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar17.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar17.BackgroundImage")));
            this.bunifuCircleProgressbar17.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar17.LabelVisible = true;
            this.bunifuCircleProgressbar17.LineProgressThickness = 8;
            this.bunifuCircleProgressbar17.LineThickness = 6;
            this.bunifuCircleProgressbar17.Location = new System.Drawing.Point(1018, 639);
            this.bunifuCircleProgressbar17.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar17.MaxValue = 100;
            this.bunifuCircleProgressbar17.Name = "bunifuCircleProgressbar17";
            this.bunifuCircleProgressbar17.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar17.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar17.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar17.TabIndex = 148;
            this.bunifuCircleProgressbar17.Value = 87;
            // 
            // bunifuCircleProgressbar18
            // 
            this.bunifuCircleProgressbar18.animated = true;
            this.bunifuCircleProgressbar18.animationIterval = 5;
            this.bunifuCircleProgressbar18.animationSpeed = 300;
            this.bunifuCircleProgressbar18.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar18.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar18.BackgroundImage")));
            this.bunifuCircleProgressbar18.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar18.LabelVisible = true;
            this.bunifuCircleProgressbar18.LineProgressThickness = 8;
            this.bunifuCircleProgressbar18.LineThickness = 6;
            this.bunifuCircleProgressbar18.Location = new System.Drawing.Point(1018, 747);
            this.bunifuCircleProgressbar18.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar18.MaxValue = 100;
            this.bunifuCircleProgressbar18.Name = "bunifuCircleProgressbar18";
            this.bunifuCircleProgressbar18.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar18.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar18.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar18.TabIndex = 151;
            this.bunifuCircleProgressbar18.Value = 87;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label22.Location = new System.Drawing.Point(1023, 822);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 20);
            this.label22.TabIndex = 150;
            this.label22.Text = "label22";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Black;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label23.Location = new System.Drawing.Point(1029, 716);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 20);
            this.label23.TabIndex = 149;
            this.label23.Text = "label23";
            // 
            // bunifuCircleProgressbar19
            // 
            this.bunifuCircleProgressbar19.animated = true;
            this.bunifuCircleProgressbar19.animationIterval = 5;
            this.bunifuCircleProgressbar19.animationSpeed = 300;
            this.bunifuCircleProgressbar19.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar19.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar19.BackgroundImage")));
            this.bunifuCircleProgressbar19.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar19.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar19.LabelVisible = true;
            this.bunifuCircleProgressbar19.LineProgressThickness = 8;
            this.bunifuCircleProgressbar19.LineThickness = 6;
            this.bunifuCircleProgressbar19.Location = new System.Drawing.Point(955, 638);
            this.bunifuCircleProgressbar19.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar19.MaxValue = 100;
            this.bunifuCircleProgressbar19.Name = "bunifuCircleProgressbar19";
            this.bunifuCircleProgressbar19.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar19.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar19.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar19.TabIndex = 144;
            this.bunifuCircleProgressbar19.Value = 87;
            // 
            // bunifuCircleProgressbar20
            // 
            this.bunifuCircleProgressbar20.animated = true;
            this.bunifuCircleProgressbar20.animationIterval = 5;
            this.bunifuCircleProgressbar20.animationSpeed = 300;
            this.bunifuCircleProgressbar20.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar20.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar20.BackgroundImage")));
            this.bunifuCircleProgressbar20.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar20.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar20.LabelVisible = true;
            this.bunifuCircleProgressbar20.LineProgressThickness = 8;
            this.bunifuCircleProgressbar20.LineThickness = 6;
            this.bunifuCircleProgressbar20.Location = new System.Drawing.Point(955, 746);
            this.bunifuCircleProgressbar20.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar20.MaxValue = 100;
            this.bunifuCircleProgressbar20.Name = "bunifuCircleProgressbar20";
            this.bunifuCircleProgressbar20.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar20.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar20.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar20.TabIndex = 147;
            this.bunifuCircleProgressbar20.Value = 87;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label24.Location = new System.Drawing.Point(960, 821);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 20);
            this.label24.TabIndex = 146;
            this.label24.Text = "label24";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Black;
            this.label25.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label25.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label25.Location = new System.Drawing.Point(966, 715);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 20);
            this.label25.TabIndex = 145;
            this.label25.Text = "label25";
            // 
            // bunifuCircleProgressbar21
            // 
            this.bunifuCircleProgressbar21.animated = true;
            this.bunifuCircleProgressbar21.animationIterval = 5;
            this.bunifuCircleProgressbar21.animationSpeed = 300;
            this.bunifuCircleProgressbar21.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar21.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar21.BackgroundImage")));
            this.bunifuCircleProgressbar21.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar21.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar21.LabelVisible = true;
            this.bunifuCircleProgressbar21.LineProgressThickness = 8;
            this.bunifuCircleProgressbar21.LineThickness = 6;
            this.bunifuCircleProgressbar21.Location = new System.Drawing.Point(892, 638);
            this.bunifuCircleProgressbar21.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar21.MaxValue = 100;
            this.bunifuCircleProgressbar21.Name = "bunifuCircleProgressbar21";
            this.bunifuCircleProgressbar21.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar21.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar21.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar21.TabIndex = 140;
            this.bunifuCircleProgressbar21.Value = 87;
            // 
            // bunifuCircleProgressbar26
            // 
            this.bunifuCircleProgressbar26.animated = true;
            this.bunifuCircleProgressbar26.animationIterval = 5;
            this.bunifuCircleProgressbar26.animationSpeed = 300;
            this.bunifuCircleProgressbar26.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar26.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar26.BackgroundImage")));
            this.bunifuCircleProgressbar26.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar26.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar26.LabelVisible = true;
            this.bunifuCircleProgressbar26.LineProgressThickness = 8;
            this.bunifuCircleProgressbar26.LineThickness = 6;
            this.bunifuCircleProgressbar26.Location = new System.Drawing.Point(892, 746);
            this.bunifuCircleProgressbar26.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar26.MaxValue = 100;
            this.bunifuCircleProgressbar26.Name = "bunifuCircleProgressbar26";
            this.bunifuCircleProgressbar26.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar26.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar26.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar26.TabIndex = 143;
            this.bunifuCircleProgressbar26.Value = 87;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label27.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label27.Location = new System.Drawing.Point(897, 821);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(58, 20);
            this.label27.TabIndex = 142;
            this.label27.Text = "label27";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Black;
            this.label28.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label28.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label28.Location = new System.Drawing.Point(903, 715);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(58, 20);
            this.label28.TabIndex = 141;
            this.label28.Text = "label28";
            // 
            // bunifuCircleProgressbar27
            // 
            this.bunifuCircleProgressbar27.animated = true;
            this.bunifuCircleProgressbar27.animationIterval = 5;
            this.bunifuCircleProgressbar27.animationSpeed = 300;
            this.bunifuCircleProgressbar27.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar27.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar27.BackgroundImage")));
            this.bunifuCircleProgressbar27.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar27.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar27.LabelVisible = true;
            this.bunifuCircleProgressbar27.LineProgressThickness = 8;
            this.bunifuCircleProgressbar27.LineThickness = 6;
            this.bunifuCircleProgressbar27.Location = new System.Drawing.Point(829, 637);
            this.bunifuCircleProgressbar27.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar27.MaxValue = 100;
            this.bunifuCircleProgressbar27.Name = "bunifuCircleProgressbar27";
            this.bunifuCircleProgressbar27.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar27.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar27.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar27.TabIndex = 136;
            this.bunifuCircleProgressbar27.Value = 87;
            // 
            // bunifuCircleProgressbar28
            // 
            this.bunifuCircleProgressbar28.animated = true;
            this.bunifuCircleProgressbar28.animationIterval = 5;
            this.bunifuCircleProgressbar28.animationSpeed = 300;
            this.bunifuCircleProgressbar28.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar28.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar28.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar28.BackgroundImage")));
            this.bunifuCircleProgressbar28.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar28.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar28.LabelVisible = true;
            this.bunifuCircleProgressbar28.LineProgressThickness = 8;
            this.bunifuCircleProgressbar28.LineThickness = 6;
            this.bunifuCircleProgressbar28.Location = new System.Drawing.Point(829, 745);
            this.bunifuCircleProgressbar28.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar28.MaxValue = 100;
            this.bunifuCircleProgressbar28.Name = "bunifuCircleProgressbar28";
            this.bunifuCircleProgressbar28.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar28.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar28.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar28.TabIndex = 139;
            this.bunifuCircleProgressbar28.Value = 87;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label29.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label29.Location = new System.Drawing.Point(834, 820);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(58, 20);
            this.label29.TabIndex = 138;
            this.label29.Text = "label29";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Black;
            this.label30.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label30.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label30.Location = new System.Drawing.Point(840, 714);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(58, 20);
            this.label30.TabIndex = 137;
            this.label30.Text = "label30";
            // 
            // bunifuCircleProgressbar29
            // 
            this.bunifuCircleProgressbar29.animated = true;
            this.bunifuCircleProgressbar29.animationIterval = 5;
            this.bunifuCircleProgressbar29.animationSpeed = 300;
            this.bunifuCircleProgressbar29.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar29.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar29.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar29.BackgroundImage")));
            this.bunifuCircleProgressbar29.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar29.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar29.LabelVisible = true;
            this.bunifuCircleProgressbar29.LineProgressThickness = 8;
            this.bunifuCircleProgressbar29.LineThickness = 6;
            this.bunifuCircleProgressbar29.Location = new System.Drawing.Point(1273, 644);
            this.bunifuCircleProgressbar29.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar29.MaxValue = 100;
            this.bunifuCircleProgressbar29.Name = "bunifuCircleProgressbar29";
            this.bunifuCircleProgressbar29.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar29.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar29.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar29.TabIndex = 164;
            this.bunifuCircleProgressbar29.Value = 87;
            // 
            // bunifuCircleProgressbar30
            // 
            this.bunifuCircleProgressbar30.animated = true;
            this.bunifuCircleProgressbar30.animationIterval = 5;
            this.bunifuCircleProgressbar30.animationSpeed = 300;
            this.bunifuCircleProgressbar30.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar30.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar30.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar30.BackgroundImage")));
            this.bunifuCircleProgressbar30.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar30.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar30.LabelVisible = true;
            this.bunifuCircleProgressbar30.LineProgressThickness = 8;
            this.bunifuCircleProgressbar30.LineThickness = 6;
            this.bunifuCircleProgressbar30.Location = new System.Drawing.Point(1273, 752);
            this.bunifuCircleProgressbar30.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar30.MaxValue = 100;
            this.bunifuCircleProgressbar30.Name = "bunifuCircleProgressbar30";
            this.bunifuCircleProgressbar30.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar30.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar30.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar30.TabIndex = 167;
            this.bunifuCircleProgressbar30.Value = 87;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label31.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label31.Location = new System.Drawing.Point(1278, 827);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(58, 20);
            this.label31.TabIndex = 166;
            this.label31.Text = "label31";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Black;
            this.label32.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label32.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label32.Location = new System.Drawing.Point(1284, 721);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(58, 20);
            this.label32.TabIndex = 165;
            this.label32.Text = "label32";
            // 
            // bunifuCircleProgressbar31
            // 
            this.bunifuCircleProgressbar31.animated = true;
            this.bunifuCircleProgressbar31.animationIterval = 5;
            this.bunifuCircleProgressbar31.animationSpeed = 300;
            this.bunifuCircleProgressbar31.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar31.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar31.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar31.BackgroundImage")));
            this.bunifuCircleProgressbar31.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar31.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar31.LabelVisible = true;
            this.bunifuCircleProgressbar31.LineProgressThickness = 8;
            this.bunifuCircleProgressbar31.LineThickness = 6;
            this.bunifuCircleProgressbar31.Location = new System.Drawing.Point(1210, 643);
            this.bunifuCircleProgressbar31.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar31.MaxValue = 100;
            this.bunifuCircleProgressbar31.Name = "bunifuCircleProgressbar31";
            this.bunifuCircleProgressbar31.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar31.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar31.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar31.TabIndex = 160;
            this.bunifuCircleProgressbar31.Value = 87;
            // 
            // bunifuCircleProgressbar32
            // 
            this.bunifuCircleProgressbar32.animated = true;
            this.bunifuCircleProgressbar32.animationIterval = 5;
            this.bunifuCircleProgressbar32.animationSpeed = 300;
            this.bunifuCircleProgressbar32.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar32.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar32.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar32.BackgroundImage")));
            this.bunifuCircleProgressbar32.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar32.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar32.LabelVisible = true;
            this.bunifuCircleProgressbar32.LineProgressThickness = 8;
            this.bunifuCircleProgressbar32.LineThickness = 6;
            this.bunifuCircleProgressbar32.Location = new System.Drawing.Point(1210, 751);
            this.bunifuCircleProgressbar32.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar32.MaxValue = 100;
            this.bunifuCircleProgressbar32.Name = "bunifuCircleProgressbar32";
            this.bunifuCircleProgressbar32.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar32.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar32.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar32.TabIndex = 163;
            this.bunifuCircleProgressbar32.Value = 87;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label33.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label33.Location = new System.Drawing.Point(1215, 826);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(58, 20);
            this.label33.TabIndex = 162;
            this.label33.Text = "label33";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Black;
            this.label34.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label34.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label34.Location = new System.Drawing.Point(1221, 720);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(58, 20);
            this.label34.TabIndex = 161;
            this.label34.Text = "label34";
            // 
            // bunifuCircleProgressbar33
            // 
            this.bunifuCircleProgressbar33.animated = true;
            this.bunifuCircleProgressbar33.animationIterval = 5;
            this.bunifuCircleProgressbar33.animationSpeed = 300;
            this.bunifuCircleProgressbar33.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar33.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar33.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar33.BackgroundImage")));
            this.bunifuCircleProgressbar33.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar33.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar33.LabelVisible = true;
            this.bunifuCircleProgressbar33.LineProgressThickness = 8;
            this.bunifuCircleProgressbar33.LineThickness = 6;
            this.bunifuCircleProgressbar33.Location = new System.Drawing.Point(1147, 643);
            this.bunifuCircleProgressbar33.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar33.MaxValue = 100;
            this.bunifuCircleProgressbar33.Name = "bunifuCircleProgressbar33";
            this.bunifuCircleProgressbar33.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar33.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar33.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar33.TabIndex = 156;
            this.bunifuCircleProgressbar33.Value = 87;
            // 
            // bunifuCircleProgressbar34
            // 
            this.bunifuCircleProgressbar34.animated = true;
            this.bunifuCircleProgressbar34.animationIterval = 5;
            this.bunifuCircleProgressbar34.animationSpeed = 300;
            this.bunifuCircleProgressbar34.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar34.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar34.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar34.BackgroundImage")));
            this.bunifuCircleProgressbar34.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar34.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar34.LabelVisible = true;
            this.bunifuCircleProgressbar34.LineProgressThickness = 8;
            this.bunifuCircleProgressbar34.LineThickness = 6;
            this.bunifuCircleProgressbar34.Location = new System.Drawing.Point(1147, 751);
            this.bunifuCircleProgressbar34.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar34.MaxValue = 100;
            this.bunifuCircleProgressbar34.Name = "bunifuCircleProgressbar34";
            this.bunifuCircleProgressbar34.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar34.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar34.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar34.TabIndex = 159;
            this.bunifuCircleProgressbar34.Value = 87;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label35.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label35.Location = new System.Drawing.Point(1152, 826);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(58, 20);
            this.label35.TabIndex = 158;
            this.label35.Text = "label35";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Black;
            this.label36.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label36.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label36.Location = new System.Drawing.Point(1158, 720);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(58, 20);
            this.label36.TabIndex = 157;
            this.label36.Text = "label36";
            // 
            // bunifuCircleProgressbar35
            // 
            this.bunifuCircleProgressbar35.animated = true;
            this.bunifuCircleProgressbar35.animationIterval = 5;
            this.bunifuCircleProgressbar35.animationSpeed = 300;
            this.bunifuCircleProgressbar35.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar35.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar35.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar35.BackgroundImage")));
            this.bunifuCircleProgressbar35.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar35.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar35.LabelVisible = true;
            this.bunifuCircleProgressbar35.LineProgressThickness = 8;
            this.bunifuCircleProgressbar35.LineThickness = 6;
            this.bunifuCircleProgressbar35.Location = new System.Drawing.Point(1084, 642);
            this.bunifuCircleProgressbar35.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar35.MaxValue = 100;
            this.bunifuCircleProgressbar35.Name = "bunifuCircleProgressbar35";
            this.bunifuCircleProgressbar35.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar35.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar35.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar35.TabIndex = 152;
            this.bunifuCircleProgressbar35.Value = 87;
            // 
            // bunifuCircleProgressbar36
            // 
            this.bunifuCircleProgressbar36.animated = true;
            this.bunifuCircleProgressbar36.animationIterval = 5;
            this.bunifuCircleProgressbar36.animationSpeed = 300;
            this.bunifuCircleProgressbar36.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCircleProgressbar36.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar36.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar36.BackgroundImage")));
            this.bunifuCircleProgressbar36.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCircleProgressbar36.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar36.LabelVisible = true;
            this.bunifuCircleProgressbar36.LineProgressThickness = 8;
            this.bunifuCircleProgressbar36.LineThickness = 6;
            this.bunifuCircleProgressbar36.Location = new System.Drawing.Point(1084, 750);
            this.bunifuCircleProgressbar36.Margin = new System.Windows.Forms.Padding(6, 1, 6, 7);
            this.bunifuCircleProgressbar36.MaxValue = 100;
            this.bunifuCircleProgressbar36.Name = "bunifuCircleProgressbar36";
            this.bunifuCircleProgressbar36.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar36.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuCircleProgressbar36.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgressbar36.TabIndex = 155;
            this.bunifuCircleProgressbar36.Value = 87;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label37.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label37.Location = new System.Drawing.Point(1089, 825);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(58, 20);
            this.label37.TabIndex = 154;
            this.label37.Text = "label37";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Black;
            this.label38.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label38.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label38.Location = new System.Drawing.Point(1095, 719);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(58, 20);
            this.label38.TabIndex = 153;
            this.label38.Text = "label38";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(386, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1263, 875);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1644, 863);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bunifuCircleProgressbar29);
            this.Controls.Add(this.bunifuCircleProgressbar30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.bunifuCircleProgressbar31);
            this.Controls.Add(this.bunifuCircleProgressbar32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.bunifuCircleProgressbar33);
            this.Controls.Add(this.bunifuCircleProgressbar34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.bunifuCircleProgressbar35);
            this.Controls.Add(this.bunifuCircleProgressbar36);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.bunifuCircleProgressbar17);
            this.Controls.Add(this.bunifuCircleProgressbar18);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.bunifuCircleProgressbar19);
            this.Controls.Add(this.bunifuCircleProgressbar20);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.bunifuCircleProgressbar21);
            this.Controls.Add(this.bunifuCircleProgressbar26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.bunifuCircleProgressbar27);
            this.Controls.Add(this.bunifuCircleProgressbar28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.bunifuCircleProgressbar9);
            this.Controls.Add(this.bunifuCircleProgressbar10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bunifuCircleProgressbar11);
            this.Controls.Add(this.bunifuCircleProgressbar12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bunifuCircleProgressbar13);
            this.Controls.Add(this.bunifuCircleProgressbar14);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.bunifuCircleProgressbar15);
            this.Controls.Add(this.bunifuCircleProgressbar16);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.bunifuCircleProgressbar5);
            this.Controls.Add(this.bunifuCircleProgressbar6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bunifuCircleProgressbar7);
            this.Controls.Add(this.bunifuCircleProgressbar8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bunifuCircleProgressbar3);
            this.Controls.Add(this.bunifuCircleProgressbar4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.Controls.Add(this.bunifuCircleProgressbar2);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSagSig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSolSig)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSolGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSagGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelVolt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelSpeed;
        private Syncfusion.Windows.Forms.Tools.Clock clock1;
        public Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        internal System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Timer timer2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private BunifuDragControl bunifuDragControl3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BunifuCustomLabel bunifuCustomLabel9;
        private BunifuCustomLabel bunifuCustomLabel1;
        private BunifuCustomLabel bunifuCustomLabel2;
        private BunifuCustomLabel bunifuCustomLabelTemp;
        private System.Windows.Forms.Timer timer3;
        private Syncfusion.Windows.Forms.Tools.SplashControl splashControl1;
        private Syncfusion.Windows.Forms.Tools.Clock clock2;
        internal System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.PictureBox pictureSagSig;
        private System.Windows.Forms.PictureBox pictureSolSig;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureSagGif;
        private System.Windows.Forms.PictureBox pictureSolGif;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label labelError;
        public BunifuCircleProgressbar bunifuCircleProgressbar1;
        private System.Windows.Forms.PictureBox pictureSag;
        private System.Windows.Forms.PictureBox pictureSol;
        private BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Label label3;
        public BunifuCircleProgressbar bunifuCircleProgressbar2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        public BunifuCircleProgressbar bunifuCircleProgressbar29;
        public BunifuCircleProgressbar bunifuCircleProgressbar30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        public BunifuCircleProgressbar bunifuCircleProgressbar31;
        public BunifuCircleProgressbar bunifuCircleProgressbar32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Gauge.LinearGauge linearGauge1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox1;
        public BunifuCircleProgressbar bunifuCircleProgressbar33;
        public BunifuCircleProgressbar bunifuCircleProgressbar34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        public BunifuCircleProgressbar bunifuCircleProgressbar35;
        public BunifuCircleProgressbar bunifuCircleProgressbar36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        public BunifuCircleProgressbar bunifuCircleProgressbar17;
        public BunifuCircleProgressbar bunifuCircleProgressbar18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        public BunifuCircleProgressbar bunifuCircleProgressbar19;
        public BunifuCircleProgressbar bunifuCircleProgressbar20;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        public BunifuCircleProgressbar bunifuCircleProgressbar21;
        public BunifuCircleProgressbar bunifuCircleProgressbar26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        public BunifuCircleProgressbar bunifuCircleProgressbar27;
        public BunifuCircleProgressbar bunifuCircleProgressbar28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        public BunifuCircleProgressbar bunifuCircleProgressbar9;
        public BunifuCircleProgressbar bunifuCircleProgressbar10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public BunifuCircleProgressbar bunifuCircleProgressbar11;
        public BunifuCircleProgressbar bunifuCircleProgressbar12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public BunifuCircleProgressbar bunifuCircleProgressbar13;
        public BunifuCircleProgressbar bunifuCircleProgressbar14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        public BunifuCircleProgressbar bunifuCircleProgressbar15;
        public BunifuCircleProgressbar bunifuCircleProgressbar16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        public BunifuCircleProgressbar bunifuCircleProgressbar5;
        public BunifuCircleProgressbar bunifuCircleProgressbar6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public BunifuCircleProgressbar bunifuCircleProgressbar7;
        public BunifuCircleProgressbar bunifuCircleProgressbar8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public BunifuCircleProgressbar bunifuCircleProgressbar3;
        public BunifuCircleProgressbar bunifuCircleProgressbar4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pictureBox2;
        private BunifuFlatButton bunifuFlatButton3;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv2;
    }
}

