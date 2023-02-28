using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FlyweightLibrary
{
    public class PorgramLogic
    {
        private readonly float MaxRenderHeight;
        private readonly float MaxRenderWidth;
        private readonly byte MaxBirdCount;
        private Image Field;

        public PorgramLogic(float maxRenderHeight, float maxRenderWidth, byte maxBirdCount)
        {
            MaxRenderHeight = maxRenderHeight;
            MaxRenderWidth = maxRenderWidth;
            MaxBirdCount = maxBirdCount;
        }

        public void SetImageToSpawnBidrs(Image image)
        {
            Field = image;
        }

    }
}
