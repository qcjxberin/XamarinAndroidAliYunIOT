using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='AspectRatioMeasure']"
	[global::Android.Runtime.Register ("com/facebook/drawee/view/AspectRatioMeasure", DoNotGenerateAcw=true)]
	public partial class AspectRatioMeasure : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='AspectRatioMeasure.Spec']"
		[global::Android.Runtime.Register ("com/facebook/drawee/view/AspectRatioMeasure$Spec", DoNotGenerateAcw=true)]
		public partial class Spec : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='AspectRatioMeasure.Spec']/field[@name='height']"
			[Register ("height")]
			public int Height {
				get {
					const string __id = "height.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "height.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='AspectRatioMeasure.Spec']/field[@name='width']"
			[Register ("width")]
			public int Width {
				get {
					const string __id = "width.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "width.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/view/AspectRatioMeasure$Spec", typeof (Spec));
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

			protected Spec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='AspectRatioMeasure.Spec']/constructor[@name='AspectRatioMeasure.Spec' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Spec ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/view/AspectRatioMeasure", typeof (AspectRatioMeasure));
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

		protected AspectRatioMeasure (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='AspectRatioMeasure']/constructor[@name='AspectRatioMeasure' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AspectRatioMeasure ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='AspectRatioMeasure']/method[@name='updateMeasureSpec' and count(parameter)=5 and parameter[1][@type='com.facebook.drawee.view.AspectRatioMeasure.Spec'] and parameter[2][@type='float'] and parameter[3][@type='android.view.ViewGroup.LayoutParams'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("updateMeasureSpec", "(Lcom/facebook/drawee/view/AspectRatioMeasure$Spec;FLandroid/view/ViewGroup$LayoutParams;II)V", "")]
		public static unsafe void UpdateMeasureSpec (global::Com.Facebook.Drawee.View.AspectRatioMeasure.Spec spec, float aspectRatio, global::Android.Views.ViewGroup.LayoutParams layoutParams, int widthPadding, int heightPadding)
		{
			const string __id = "updateMeasureSpec.(Lcom/facebook/drawee/view/AspectRatioMeasure$Spec;FLandroid/view/ViewGroup$LayoutParams;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((spec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) spec).Handle);
				__args [1] = new JniArgumentValue (aspectRatio);
				__args [2] = new JniArgumentValue ((layoutParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layoutParams).Handle);
				__args [3] = new JniArgumentValue (widthPadding);
				__args [4] = new JniArgumentValue (heightPadding);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
