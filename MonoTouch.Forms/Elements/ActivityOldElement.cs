using System;
using System.Drawing;
using MonoTouch.UIKit;
using MonoTouch.Dialog;

namespace MonoTouch.Forms.Elements
{
	public class ActivityOldElement : UIViewElement, IElementSizing {
		public ActivityOldElement () : base ("", new UIActivityIndicatorView (UIActivityIndicatorViewStyle.Gray), false)
		{
			var sbounds = UIScreen.MainScreen.Bounds;			
			var uia = View as UIActivityIndicatorView;
			
			uia.StartAnimating ();
			
			var vbounds = View.Bounds;
			View.Frame = new RectangleF ((sbounds.Width-vbounds.Width)/2, 4, vbounds.Width, vbounds.Height + 0);
			View.AutoresizingMask = UIViewAutoresizing.FlexibleLeftMargin | UIViewAutoresizing.FlexibleRightMargin;
		}
		
		public bool Animating {
			get {
				return ((UIActivityIndicatorView) View).IsAnimating;
			}
			set {
				var activity = View as UIActivityIndicatorView;
				if (value)
					activity.StartAnimating ();
				else
					activity.StopAnimating ();
			}
		}
		
		public new float GetHeight (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			return base.GetHeight (tableView, indexPath)+ 8;
		}
		
	}
}
