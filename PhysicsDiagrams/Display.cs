using System;
using UIKit;

namespace PhysicsDiagrams
{
    public class Display : UIView
    {
        public Display()
        {
            var image = new UIImageView();
            image.Image = UIImage.FromFile("waterfront.jpg");



        }
    }
}
