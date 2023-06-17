using FriskyMouse.HelpersLib;

namespace FriskyMouse.HelpersLib.Animation
{
    /// <summary>
    /// Base class for all Easing classes.
    /// </summary>    
    public abstract partial class Easing : IConstructable
    {
        /// <inheritdoc/>
        public abstract double Ease(double progress);        
    }
}
