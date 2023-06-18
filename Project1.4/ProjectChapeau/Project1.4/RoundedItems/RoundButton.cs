namespace Project1._4.RoundedItems
{
    
    class RoundButton : Button
    {

        // stolen from stackOverflow: https://stackoverflow.com/questions/58613713/how-to-make-a-textbox-with-rounded-corner-in-c

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, 
            int nTopRect,
            int nRightRect, 
            int nBottomRect,
     
            int nheightRect, 
            int nweightRect 
        );
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            IntPtr makeCoolShape = CreateRoundRectRgn(2, 3, Width, Height, 15, 15);
            Region = Region.FromHrgn(makeCoolShape); //play with these values till me happy
        }
    }
}
