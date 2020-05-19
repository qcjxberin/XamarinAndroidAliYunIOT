using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='TransformAwareDrawable']"
	[Register ("com/facebook/drawee/drawable/TransformAwareDrawable", "", "Com.Facebook.Drawee.Drawable.ITransformAwareDrawableInvoker")]
	public partial interface ITransformAwareDrawable : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='TransformAwareDrawable']/method[@name='setTransformCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.drawable.TransformCallback']]"
		[Register ("setTransformCallback", "(Lcom/facebook/drawee/drawable/TransformCallback;)V", "GetSetTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_Handler:Com.Facebook.Drawee.Drawable.ITransformAwareDrawableInvoker, DraweeBinding")]
		void SetTransformCallback (global::Com.Facebook.Drawee.Drawable.ITransformCallback p0);

	}

	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/TransformAwareDrawable", DoNotGenerateAcw=true)]
	internal partial class ITransformAwareDrawableInvoker : global::Java.Lang.Object, ITransformAwareDrawable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/TransformAwareDrawable", typeof (ITransformAwareDrawableInvoker));

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

		public static ITransformAwareDrawable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITransformAwareDrawable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.drawee.drawable.TransformAwareDrawable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITransformAwareDrawableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_setTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_;
#pragma warning disable 0169
		static Delegate GetSetTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_Handler ()
		{
			if (cb_setTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_ == null)
				cb_setTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_);
			return cb_setTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_;
		}

		static void n_SetTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Drawable.ITransformAwareDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ITransformAwareDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ITransformCallback p0 = (global::Com.Facebook.Drawee.Drawable.ITransformCallback)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ITransformCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTransformCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_setTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_;
		public unsafe void SetTransformCallback (global::Com.Facebook.Drawee.Drawable.ITransformCallback p0)
		{
			if (id_setTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_ == IntPtr.Zero)
				id_setTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_ = JNIEnv.GetMethodID (class_ref, "setTransformCallback", "(Lcom/facebook/drawee/drawable/TransformCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_, __args);
		}

	}

}
