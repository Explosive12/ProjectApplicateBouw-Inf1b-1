﻿namespace Project1._4.RoundedItems
{
    class RoundTextBox : TextBox
    {
        // TODO, Explain how it all works
        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // X-coordinate of upper-left corner or padding at start
            int nTopRect,// Y-coordinate of upper-left corner or padding at the top of the textbox
            int nRightRect, // X-coordinate of lower-right corner or Width of the object
            int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
                            //RADIUS, how round do you want it to be?
            int nheightRect, //height of ellipse 
            int nweightRect //width of ellipse
        );
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            IntPtr makeCoolShape = CreateRoundRectRgn(2, 3, Width, Height, 15, 15);
            Region = Region.FromHrgn(makeCoolShape); //play with these values till you are happy
        }
    }
}