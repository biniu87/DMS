using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using System.Windows.Forms;

namespace DocumentsManagerRU
{
    [ToolboxBitmap(typeof (ProgressBar))]
    [Description("ProgressBar z tekstem")]
    public sealed class ProgressBarWithText : ProgressBar
    {
        private ProgressBarDisplayStyle _displayStyle = ProgressBarDisplayStyle.Percentage;

        public ProgressBarWithText()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            Font = new Font(Font.FontFamily, 12, FontStyle.Bold);

            ForeColor = Color.White;
            BackColor = Color.Black;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var result = base.CreateParams;
                if (Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 6)
                {
                    result.ExStyle |= 0x02000000; // WS_EX_COMPOSITED 
                }
                return result;
            }
        }

        //Property to set to decide whether to print a % or Text
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public ProgressBarDisplayStyle DisplayStyle
        {
            get { return _displayStyle; }
            set
            {
                if (_displayStyle == value) return;
                _displayStyle = value;
                Refresh();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                Refresh();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                Refresh();
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg != 0x000F) return;

            using (var graphics = CreateGraphics())
            {
                using (var brush = new SolidBrush(ForeColor))
                {
                    var text = string.Empty;

                    switch (DisplayStyle)
                    {
                        case ProgressBarDisplayStyle.ValueAndMax:
                            text = string.Format("{0}/{1}", Value, Maximum);
                            break;
                        case ProgressBarDisplayStyle.Text:
                            text = Text;
                            break;
                        case ProgressBarDisplayStyle.Percentage:
                            text = Math.Floor(((float) Value/Maximum)*100).ToString(CultureInfo.InvariantCulture) + '%';
                            break;
                    }

                    //SizeF textSize = graphics.MeasureString(text, Font);

                    using (var path = new GraphicsPath())
                    {
                        using (var format = new StringFormat
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center,
                            Trimming = StringTrimming.None,
                            FormatFlags = StringFormatFlags.NoWrap
                        })
                        {
                            var emSize = graphics.DpiY*Font.Size/72;

                            path.AddString(
                                text,
                                Font.FontFamily,
                                (int) Font.Style,
                                emSize, //!!!
                                ClientRectangle, // !!!
                                format); // !!!
                        }
                        //path.AddString(
                        //    text,
                        //    Font.FontFamily,
                        //    (int) Font.Style,
                        //    Font.Height,
                        //    new Point(0,0),  
                        //    //new Point((int) ((Width - textSize.Width) / 2 ), (int) ((Height - textSize.Height) / 2)),
                        //    StringFormat.GenericDefault);


                        //var pb = path.GetBounds();

                        //Matrix translateMatrix = new Matrix();
                        //translateMatrix.Translate((Width - pb.Width) / 2 - pb.X, (Height - pb.Height) / 2 - pb.Y);
                        //path.Transform(translateMatrix);

                        graphics.InterpolationMode = InterpolationMode.High;
                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                        graphics.CompositingQuality = CompositingQuality.HighQuality;

                        graphics.FillPath(brush, path);
                        using (var p = new Pen(BackColor, 1))
                        {
                            graphics.DrawPath(p, path);
                        }
                    }

                    //graphics.DrawString(text, Font, brush, (Width - textSize.Width)/2, (Height - textSize.Height)/2);
                }
            }
        }
    }

    public enum ProgressBarDisplayStyle
    {
        Percentage,
        ValueAndMax,
        Text
    }
}