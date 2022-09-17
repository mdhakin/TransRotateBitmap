namespace transrotate_test
{
    partial class Form3
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
            CodeArtEng.Gauge.Themes.ThemeColors themeColors1 = new CodeArtEng.Gauge.Themes.ThemeColors();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors2 = new CodeArtEng.Gauge.Themes.ThemeColors();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors3 = new CodeArtEng.Gauge.Themes.ThemeColors();
            this.linearGauge1 = new CodeArtEng.Gauge.LinearGauge();
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.gaugePanel1 = new CodeArtEng.Gauge.PanelGauges.GaugePanel();
            this.panelGaugeValue1 = new CodeArtEng.Gauge.PanelGauges.PanelGaugeValue();
            this.panelGaugeSymbol1 = new CodeArtEng.Gauge.PanelGauges.PanelGaugeSymbol();
            this.panelGaugeLinearIndicator1 = new CodeArtEng.Gauge.PanelGauges.PanelGaugeLinearIndicator();
            this.panelGaugeCircularIndicator1 = new CodeArtEng.Gauge.PanelGauges.PanelGaugeCircularIndicator();
            this.panelGaugeLabel1 = new CodeArtEng.Gauge.PanelGauges.PanelGaugeLabel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.gaugePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linearGauge1
            // 
            this.linearGauge1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linearGauge1.BottomBarHeight = 5;
            this.linearGauge1.Demo = true;
            this.linearGauge1.Location = new System.Drawing.Point(-1, 469);
            this.linearGauge1.Name = "linearGauge1";
            this.linearGauge1.ScaleFactor = 1D;
            this.linearGauge1.SegmentGap = 1;
            this.linearGauge1.Size = new System.Drawing.Size(502, 30);
            this.linearGauge1.TabIndex = 0;
            this.linearGauge1.Title = "";
            this.linearGauge1.Unit = "km/h";
            this.linearGauge1.UserDefinedColors.Base = themeColors1;
            themeColors2.PointerColor = System.Drawing.Color.Red;
            this.linearGauge1.UserDefinedColors.Error = themeColors2;
            themeColors3.PointerColor = System.Drawing.Color.Orange;
            this.linearGauge1.UserDefinedColors.Warning = themeColors3;
            // 
            // aGauge1
            // 
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Center = new System.Drawing.Point(100, 100);
            this.aGauge1.Location = new System.Drawing.Point(12, 12);
            this.aGauge1.MaxValue = 400F;
            this.aGauge1.MinValue = -100F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 50F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorTicks = 9;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(205, 180);
            this.aGauge1.TabIndex = 1;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // gaugePanel1
            // 
            this.gaugePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gaugePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gaugePanel1.Controls.Add(this.panelGaugeLabel1);
            this.gaugePanel1.Controls.Add(this.panelGaugeCircularIndicator1);
            this.gaugePanel1.Controls.Add(this.panelGaugeLinearIndicator1);
            this.gaugePanel1.Controls.Add(this.panelGaugeSymbol1);
            this.gaugePanel1.Controls.Add(this.panelGaugeValue1);
            this.gaugePanel1.Controls.Add(this.linearGauge1);
            this.gaugePanel1.Demo = true;
            this.gaugePanel1.Location = new System.Drawing.Point(542, 177);
            this.gaugePanel1.Name = "gaugePanel1";
            this.gaugePanel1.Size = new System.Drawing.Size(506, 504);
            this.gaugePanel1.TabIndex = 2;
            // 
            // panelGaugeValue1
            // 
            this.panelGaugeValue1.BackColor = System.Drawing.Color.Black;
            this.panelGaugeValue1.Location = new System.Drawing.Point(3, 3);
            this.panelGaugeValue1.Name = "panelGaugeValue1";
            this.panelGaugeValue1.ScaleFactor = 1D;
            this.panelGaugeValue1.Size = new System.Drawing.Size(70, 20);
            this.panelGaugeValue1.TabIndex = 1;
            this.panelGaugeValue1.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.panelGaugeValue1.Title = "";
            this.panelGaugeValue1.Unit = "km/h";
            // 
            // panelGaugeSymbol1
            // 
            this.panelGaugeSymbol1.ActiveOn = CodeArtEng.Gauge.GaugeValueState.OK;
            this.panelGaugeSymbol1.Image = null;
            this.panelGaugeSymbol1.Location = new System.Drawing.Point(20, 70);
            this.panelGaugeSymbol1.Name = "panelGaugeSymbol1";
            this.panelGaugeSymbol1.ScaleFactor = 1D;
            this.panelGaugeSymbol1.Size = new System.Drawing.Size(145, 110);
            this.panelGaugeSymbol1.TabIndex = 2;
            this.panelGaugeSymbol1.Title = "";
            this.panelGaugeSymbol1.Unit = "km/h";
            // 
            // panelGaugeLinearIndicator1
            // 
            this.panelGaugeLinearIndicator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGaugeLinearIndicator1.Location = new System.Drawing.Point(3, 448);
            this.panelGaugeLinearIndicator1.Name = "panelGaugeLinearIndicator1";
            this.panelGaugeLinearIndicator1.ScaleFactor = 1D;
            this.panelGaugeLinearIndicator1.SegmentGap = 1;
            this.panelGaugeLinearIndicator1.Size = new System.Drawing.Size(498, 15);
            this.panelGaugeLinearIndicator1.TabIndex = 3;
            this.panelGaugeLinearIndicator1.Title = "";
            this.panelGaugeLinearIndicator1.Unit = "km/h";
            // 
            // panelGaugeCircularIndicator1
            // 
            this.panelGaugeCircularIndicator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelGaugeCircularIndicator1.Location = new System.Drawing.Point(20, 329);
            this.panelGaugeCircularIndicator1.Name = "panelGaugeCircularIndicator1";
            this.panelGaugeCircularIndicator1.ScaleFactor = 1D;
            this.panelGaugeCircularIndicator1.Size = new System.Drawing.Size(105, 85);
            this.panelGaugeCircularIndicator1.TabIndex = 4;
            this.panelGaugeCircularIndicator1.Title = "";
            this.panelGaugeCircularIndicator1.Unit = "km/h";
            this.panelGaugeCircularIndicator1.Value = 20D;
            // 
            // panelGaugeLabel1
            // 
            this.panelGaugeLabel1.Location = new System.Drawing.Point(3, 29);
            this.panelGaugeLabel1.Name = "panelGaugeLabel1";
            this.panelGaugeLabel1.ScaleFactor = 1D;
            this.panelGaugeLabel1.Size = new System.Drawing.Size(110, 20);
            this.panelGaugeLabel1.TabIndex = 5;
            this.panelGaugeLabel1.Text = "panelGaugeLabel1";
            this.panelGaugeLabel1.Title = "";
            this.panelGaugeLabel1.Unit = "km/h";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.propertyGrid1.Location = new System.Drawing.Point(12, 243);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(306, 429);
            this.propertyGrid1.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 684);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.gaugePanel1);
            this.Controls.Add(this.aGauge1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gaugePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CodeArtEng.Gauge.LinearGauge linearGauge1;
        private System.Windows.Forms.AGauge aGauge1;
        private CodeArtEng.Gauge.PanelGauges.GaugePanel gaugePanel1;
        private CodeArtEng.Gauge.PanelGauges.PanelGaugeValue panelGaugeValue1;
        private CodeArtEng.Gauge.PanelGauges.PanelGaugeLabel panelGaugeLabel1;
        private CodeArtEng.Gauge.PanelGauges.PanelGaugeCircularIndicator panelGaugeCircularIndicator1;
        private CodeArtEng.Gauge.PanelGauges.PanelGaugeLinearIndicator panelGaugeLinearIndicator1;
        private CodeArtEng.Gauge.PanelGauges.PanelGaugeSymbol panelGaugeSymbol1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}