using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Generic {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RootDrawable']"
	[global::Android.Runtime.Register ("com/facebook/drawee/generic/RootDrawable", DoNotGenerateAcw=true)]
	public partial class RootDrawable : global::Com.Facebook.Drawee.Drawable.ForwardingDrawable, global::Com.Facebook.Drawee.Drawable.IVisibilityAwareDrawable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/generic/RootDrawable", typeof (RootDrawable));
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

		protected RootDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RootDrawable']/constructor[@name='RootDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;)V", "")]
		public unsafe RootDrawable (global::Android.Graphics.Drawables.Drawable drawable)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/drawable/Drawable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setControllerOverlay_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetControllerOverlay_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setControllerOverlay_Landroid_graphics_drawable_Drawable_ == null)
				cb_setControllerOverlay_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetControllerOverlay_Landroid_graphics_drawable_Drawable_);
			return cb_setControllerOverlay_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetControllerOverlay_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_controllerOverlay)
		{
			global::Com.Facebook.Drawee.Generic.RootDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RootDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable controllerOverlay = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_controllerOverlay, JniHandleOwnership.DoNotTransfer);
			__this.SetControllerOverlay (controllerOverlay);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RootDrawable']/method[@name='setControllerOverlay' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setControllerOverlay", "(Landroid/graphics/drawable/Drawable;)V", "GetSetControllerOverlay_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetControllerOverlay (global::Android.Graphics.Drawables.Drawable controllerOverlay)
		{
			const string __id = "setControllerOverlay.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((controllerOverlay == null) ? IntPtr.Zero : ((global::Java.Lang.Object) controllerOverlay).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setVisibilityCallback_Lcom_facebook_drawee_drawable_VisibilityCallback_;
#pragma warning disable 0169
		static Delegate GetSetVisibilityCallback_Lcom_facebook_drawee_drawable_VisibilityCallback_Handler ()
		{
			if (cb_setVisibilityCallback_Lcom_facebook_drawee_drawable_VisibilityCallback_ == null)
				cb_setVisibilityCallback_Lcom_facebook_drawee_drawable_VisibilityCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVisibilityCallback_Lcom_facebook_drawee_drawable_VisibilityCallback_);
			return cb_setVisibilityCallback_Lcom_facebook_drawee_drawable_VisibilityCallback_;
		}

		static void n_SetVisibilityCallback_Lcom_facebook_drawee_drawable_VisibilityCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_visibilityCallback)
		{
			global::Com.Facebook.Drawee.Generic.RootDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RootDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.IVisibilityCallback visibilityCallback = (global::Com.Facebook.Drawee.Drawable.IVisibilityCallback)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.IVisibilityCallback> (native_visibilityCallback, JniHandleOwnership.DoNotTransfer);
			__this.SetVisibilityCallback (visibilityCallback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RootDrawable']/method[@name='setVisibilityCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.drawable.VisibilityCallback']]"
		[Register ("setVisibilityCallback", "(Lcom/facebook/drawee/drawable/VisibilityCallback;)V", "GetSetVisibilityCallback_Lcom_facebook_drawee_drawable_VisibilityCallback_Handler")]
		public virtual unsafe void SetVisibilityCallback (global::Com.Facebook.Drawee.Drawable.IVisibilityCallback visibilityCallback)
		{
			const string __id = "setVisibilityCallback.(Lcom/facebook/drawee/drawable/VisibilityCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((visibilityCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) visibilityCallback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
