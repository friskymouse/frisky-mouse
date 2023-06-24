﻿using FriskyMouse.Drawing.Helpers;

namespace FriskyMouse.Drawing.Ripples
{
    internal class StarProfile : BaseRippleProfile
    {
        private Pen _outlinePen;
        public StarProfile()
        {
            CreateProfileEntries();
        }
        private void CreateProfileEntries()
        {            
            _outlinePen = new Pen(Color.Crimson, 4);            
            AddRipple(
                new RippleEntry()
                {
                    IsExpandable = true,
                    ShapeType = ShapeType.Polygon,                    
                    InitialRadius = 10,
                    RadiusMultiplier = 3,
                    OutlinePen = _outlinePen,
                    IsFilled = false,
                    PolygonType = PolygonType.Star,
                    IsStyleable = true
                });
        }
    }
}