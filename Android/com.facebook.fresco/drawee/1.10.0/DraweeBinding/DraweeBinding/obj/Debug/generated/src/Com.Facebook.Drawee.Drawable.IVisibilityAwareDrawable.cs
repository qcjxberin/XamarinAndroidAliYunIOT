using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='VisibilityAwareDrawable']"
	[Register ("com/facebook/drawee/drawable/VisibilityAwareDrawable", "", "Com.Facebook.Drawee.Drawable.IVisibilityAwareDrawableInvoker")]
	public partial interface IVisibilityAwareDrawable : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='VisibilityAwareDrawable']/method[@name='setVisibilityCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.drawable.VisibilityCallback']]"
		[Register ("setVisibilityCallback", "(Lcom/facebook/drawee/drawable/VisibilityCallback;)V", "GetSetVisibilityCallback_Lcom_facebook_drawee_drawable_VisibilityCallback_Handler:Com.Facebook.Drawee.Drawable.IVisibilityAwareDrawableInvoker, DraweeBinding")]
		void SetVisibilityCallback (global::Com.Facebook.Drawee.Drawable.IVisibilityCallback p0);

	}

	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/VisibilityAwareDrawable", DoNotGenerateAcw=true)]
	internal partial class IVisibilityAwareDrawableInvoker : global::Java.Lang.Object, IVisibilityAwareDrawable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/VisibilityAwareDrawable", typeof (IVisibilityAwareDrawableInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IVisibilityAwareDrawable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVisibilityAwareDrawable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.drawee.drawable.VisibilityAwareDrawable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVisibilityAwareDrawableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_setVisibilityCallback_Lcom_facebook_drawee_drawable_VisibilityCallback_;
#pragma warning disable 0169
		static Delegate GetSetVisibilityCallback_Lcom_facebook_drawee_drawable_VisibilityCallback_Handler ()
		{
			if (cb_setVisibilityCallback_Lcom_facebook_drawee_drawable_VisibilityCallback_ == null)
				cb_setVisibilityCallback_Lcom_facebook_drawee_drawable_VisibilityCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVisibilityCallback_Lcom_facebook_drawee_drawable_VisibilityCallback_);
			return cb_setVisibilityCallback_Lcom_facebook_drawee_drawable_VisibilityCallback_;
		}

		static void n_SetVisibilityCallback_Lcom_facebook_drawee_drawable_VisibilityCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Drawable.IVisibilityAwareDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.IVisibilityAwareDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.IVisibilityCallback p0 = (global::Com.Facebook.Drawee.Drawable.IVisibilityCallback)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.IVisibilityCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetVisibilityCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_setVisibilityCallback_Lcom_facebook_drawee_drawable_VisibilityCallback_;
		public unsafe void SetVisibilityCallback (global::Com.Facebook.Drawee.Drawable.IVisibilityCallback p0)
		{
			if (id_setVisibilityCallback_Lcom_facebook_drawee_drawable_VisibilityCallback_ == IntPtr.Zero)
				id_setVisibilityCallback_Lcom_facebook_drawee_drawable_VisibilityCallback_ = JNIEnv.GetMethodID (class_ref, "setVisibilityCallback", "(Lcom/facebook/drawee/drawable/VisibilityCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVisibilityCallback_Lcom_facebook_drawee_drawable_VisibilityCallback_, __args);
		}

	}

}
