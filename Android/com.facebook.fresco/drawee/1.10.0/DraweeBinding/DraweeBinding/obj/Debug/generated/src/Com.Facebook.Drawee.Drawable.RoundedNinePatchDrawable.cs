using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedNinePatchDrawable']"
	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/RoundedNinePatchDrawable", DoNotGenerateAcw=true)]
	public partial class RoundedNinePatchDrawable : global::Com.Facebook.Drawee.Drawable.RoundedDrawable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/RoundedNinePatchDrawable", typeof (RoundedNinePatchDrawable));
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

		protected RoundedNinePatchDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedNinePatchDrawable']/constructor[@name='RoundedNinePatchDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.NinePatchDrawable']]"
		[Register (".ctor", "(Landroid/graphics/drawable/NinePatchDrawable;)V", "")]
		public unsafe RoundedNinePatchDrawable (global::Android.Graphics.Drawables.NinePatchDrawable ninePatchDrawable)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/drawable/NinePatchDrawable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ninePatchDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ninePatchDrawable).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
