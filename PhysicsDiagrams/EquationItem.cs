using System;
using UIKit;
using System.Drawing;

namespace PhysicsDiagrams
{
    public class EquationItem : UIView
    {
        private UIView itemView;

        private float width = (float) UIScreen.MainScreen.Bounds.Width;
        private float height = (float) UIScreen.MainScreen.Bounds.Height;

        public EquationItem(float x, float y, string label, string equation)
        {
            
            itemView = new UIView(new RectangleF(x, y, width, height));
            itemView.BackgroundColor = UIColor.LightGray;

            var itemLabel = new UILabel(new RectangleF(0, 0, width, height / 5));
            itemLabel.Text = label;
            itemView.AddSubview(itemLabel);

            // Diagram image will probably be here between the two

            var itemEquation = new UILabel(new RectangleF(0, height * 4 / 5, width, height / 5));
            itemEquation.Text = equation;
            itemView.AddSubview(itemEquation);

        }
    }
}
