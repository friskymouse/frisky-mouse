#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

namespace FriskyMouse.Drawing.Animation
{
    /// <summary>
    /// Eases a <see cref="double"/> value 
    /// using a piece-wise quartic equation.
    /// </summary>
    public class QuinticEaseInOut : Easing
    {
        /// <inheritdoc/>
        public override double Ease(double progress)
        {
            double p = progress;
            if (p < 0.5d)
            {
                double p2 = p * p;
                return 16d * p2 * p2 * p;
            }
            else
            {
                double f = 2d * p - 2d;
                double f2 = f * f;
                return 0.5d * f2 * f2 * f + 1d;
            }
        }
    }
}
