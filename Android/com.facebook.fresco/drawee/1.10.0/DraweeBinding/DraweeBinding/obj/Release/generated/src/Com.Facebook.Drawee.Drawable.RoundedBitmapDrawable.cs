using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedBitmapDrawable']"
	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/RoundedBitmapDrawable", DoNotGenerateAcw=true)]
	public partial class RoundedBitmapDrawable : global::Com.Facebook.Drawee.Drawable.RoundedDrawable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/RoundedBitmapDrawable", typeof (RoundedBitmapDrawable));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected RoundedBitmapDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedBitmapDrawable']/constructor[@name='RoundedBitmapDrawable' and count(parameter)=2 and parameter[1][@type='android.content.res.Resources'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;)V", "")]
		public unsafe RoundedBitmapDrawable (global::Android.Content.Res.Resources res, global::Android.Graphics.Bitmap bitmap)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((res == null) ? IntPtr.Zero : ((global::Java.Lang.Object) res).Handle);
				__args [1] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedBitmapDrawable']/constructor[@name='RoundedBitmapDrawable' and count(parameter)=3 and parameter[1][@type='android.content.res.Resources'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='android.graphics.Paint']]"
		[Register (".ctor", "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;Landroid/graphics/Paint;)V", "")]
		public unsafe RoundedBitmapDrawable (global::Android.Content.Res.Resources res, global::Android.Graphics.Bitmap bitmap, global::Android.Graphics.Paint paint)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;Landroid/graphics/Paint;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((res == null) ? IntPtr.Zero : ((global::Java.Lang.Object) res).Handle);
				__args [1] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				__args [2] = new JniArgumentValue ((paint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paint).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedBitmapDrawable']/method[@name='fromBitmapDrawable' and count(parameter)=2 and parameter[1][@type='android.content.res.Resources'] and parameter[2][@type='android.graphics.drawable.BitmapDrawable']]"
		[Register ("fromBitmapDrawable", "(Landroid/content/res/Resources;Landroid/graphics/drawable/BitmapDrawable;)Lcom/facebook/drawee/drawable/RoundedBitmapDrawable;", "")]
		public static unsafe global::Com.Facebook.Drawee.Drawable.RoundedBitmapDrawable FromBitmapDrawable (global::Android.Content.Res.Resources res, global::Android.Graphics.Drawables.BitmapDrawable bitmapDrawable)
		{
			const string __id = "fromBitmapDrawable.(Landroid/content/res/Resources;Landroid/graphics/drawable/BitmapDrawable;)Lcom/facebook/drawee/drawable/RoundedBitmapDrawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((res == null) ? IntPtr.Zero : ((global::Java.Lang.Object) res).Handle);
				__args [1] = new JniArgumentValue ((bitmapDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmapDrawable).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedBitmapDrawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
