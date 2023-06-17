﻿using System.Drawing;
using FriskyMouse.HelpersLib.Extensions;
using FriskyMouse.HelpersLib.Helpers;

namespace FriskyMouse.HelpersLib.Drawing
{
    internal class CircleProfile : RippleProfile 
    {
        private Pen _outlinePen;
        int _baseRadius = 10; // Needs to be parametrized.
        public CircleProfile()
        {
            InitProfileEntries();
        }

        private void InitProfileEntries()
        {
            int opacity = 10;            
            _outlinePen = new Pen(Color.Crimson.ReduceOpacity(opacity), 6);                        
            AddRipple(
                new RippleEntry()
                {
                    Expandable = true,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, _baseRadius),
                    ShapeType = ShapeType.Ellipse,
                    InitialRadius = 10,
                    RadiusMultiplier = 2,
                    OutlinePen = _outlinePen,
                    IsFilled = false,
                });
        }        
    }
}
