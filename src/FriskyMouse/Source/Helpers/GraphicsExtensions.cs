﻿using FriskyMouse.Drawing.Helpers;
using MaterialSkin;
using System.Drawing.Drawing2D;


namespace FriskyMouse.Core
{
    internal static class GraphicsExtensions
    {
        public static void DrawHighlighter(this Graphics graphics, Rectangle rect, HighlighterOptions options)
        {
            graphics.SetAntiAliasing();

            if (options.IsFilled)
            {
                // Apply the selected opacity on the color to be used in the _settings. 
                Color selectedColor = Color.FromArgb(options.Opacity, options.FillColor);
                using SolidBrush brush = new SolidBrush(selectedColor);
                graphics.FillEllipse(brush, rect);
                if (options.IsOutlined)
                {
                    // Add an outline to the spotlight if enabled.
                    graphics.DrawOutline(options);
                }
            }
            else
            {
                graphics.DrawOutline(options);
            }
            if (options.HasShadow)
            {
                graphics.DrawRoundShadow(options);
                //GraphicsPath gp =  DrawingHelper.CreateCircle(100, 100, options.Radius + options.OutlineWidth+2);
                //DrawingHelper.DrawShadow(graphics, gp, 7, Color.Blue);                
            }
        }

        public static void DrawOutline(this Graphics graphics, HighlighterOptions options)
        {
            Rectangle outlineRect = DrawingHelper.CreateRectangle(options.Width, options.Height, options.Radius + 2);
            //using Pen pen = new Pen(Color.Red, options.OutlineWidth);
            using Pen pen = new Pen(options.OutlineColor, options.OutlineWidth);
            pen.DashStyle = options.OutlineStyle;
            graphics.DrawEllipse(pen, outlineRect);
        }

        public static void DrawRoundShadow(this Graphics graphics, HighlighterOptions options)
        {
            int radius = options.Radius + (options.IsOutlined ? options.OutlineWidth + 1 : 3);
            int opacity = 60;
            Rectangle shadowRect = DrawingHelper.CreateRectangle(options.Width, options.Height, radius);
            Color color = Color.FromArgb(opacity, options.ShadowColor);
            using Pen pen = new Pen(color, options.ShadowDepth);
            graphics.DrawEllipse(pen, shadowRect);
        }
        public static void SetAntiAliasing(this Graphics graphics)
        {
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
        }
    }
}
