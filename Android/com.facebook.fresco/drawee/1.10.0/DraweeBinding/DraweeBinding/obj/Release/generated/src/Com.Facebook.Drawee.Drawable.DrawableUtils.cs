using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='DrawableUtils']"
	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/DrawableUtils", DoNotGenerateAcw=true)]
	public partial class DrawableUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/DrawableUtils", typeof (DrawableUtils));
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

		protected DrawableUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='DrawableUtils']/constructor[@name='DrawableUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DrawableUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='DrawableUtils']/method[@name='cloneDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("cloneDrawable", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable CloneDrawable (global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "cloneDrawable.(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='DrawableUtils']/method[@name='copyProperties' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("copyProperties", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V", "")]
		public static unsafe void CopyProperties (global::Android.Graphics.Drawables.Drawable to, global::Android.Graphics.Drawables.Drawable from)
		{
			const string __id = "copyProperties.(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((to == null) ? IntPtr.Zero : ((global::Java.Lang.Object) to).Handle);
				__args [1] = new JniArgumentValue ((from == null) ? IntPtr.Zero : ((global::Java.Lang.Object) from).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='DrawableUtils']/method[@name='getOpacityFromColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getOpacityFromColor", "(I)I", "")]
		public static unsafe int GetOpacityFromColor (int color)
		{
			const string __id = "getOpacityFromColor.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='DrawableUtils']/method[@name='multiplyColorAlpha' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("multiplyColorAlpha", "(II)I", "")]
		public static unsafe int MultiplyColorAlpha (int color, int alpha)
		{
			const string __id = "multiplyColorAlpha.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (color);
				__args [1] = new JniArgumentValue (alpha);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='DrawableUtils']/method[@name='setCallbacks' and count(parameter)=3 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='android.graphics.drawable.Drawable.Callback'] and parameter[3][@type='com.facebook.drawee.drawable.TransformCallback']]"
		[Register ("setCallbacks", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable$Callback;Lcom/facebook/drawee/drawable/TransformCallback;)V", "")]
		public static unsafe void SetCallbacks (global::Android.Graphics.Drawables.Drawable drawable, global::Android.Graphics.Drawables.Drawable.ICallback @callback, global::Com.Facebook.Drawee.Drawable.ITransformCallback transformCallback)
		{
			const string __id = "setCallbacks.(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable$Callback;Lcom/facebook/drawee/drawable/TransformCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [2] = new JniArgumentValue ((transformCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transformCallback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='DrawableUtils']/method[@name='setDrawableProperties' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='com.facebook.drawee.drawable.DrawableProperties']]"
		[Register ("setDrawableProperties", "(Landroid/graphics/drawable/Drawable;Lcom/facebook/drawee/drawable/DrawableProperties;)V", "")]
		public static unsafe void SetDrawableProperties (global::Android.Graphics.Drawables.Drawable drawable, global::Com.Facebook.Drawee.Drawable.DrawableProperties properties)
		{
			const string __id = "setDrawableProperties.(Landroid/graphics/drawable/Drawable;Lcom/facebook/drawee/drawable/DrawableProperties;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				__args [1] = new JniArgumentValue ((properties == null) ? IntPtr.Zero : ((global::Java.Lang.Object) properties).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
