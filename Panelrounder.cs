﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskSystem
{
    class Panelrounder: Panel
    {

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
  (
      int nLeftRect, 
      int nTopRect,
      int nRightRect, // X-coordinate of lower-right corner or Width of the object
      int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
                      //RADIUS, how round do you want it to be?
      int nheightRect, 
      int nweightRect // 
            );
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 15, 15)); //play with these values till you are happy
        }
    }
}
