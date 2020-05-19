using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='TransformCallback']"
	[Register ("com/facebook/drawee/drawable/TransformCallback", "", "Com.Facebook.Drawee.Drawable.ITransformCallbackInvoker")]
	public partial interface ITransformCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='TransformCallback']/method[@name='getRootBounds' and count(parameter)=1 and parameter[1][@type='android.graphics.RectF']]"
		[Register ("getRootBounds", "(Landroid/graphics/RectF;)V", "GetGetRootBounds_Landroid_graphics_RectF_Handler:Com.Facebook.Drawee.Drawable.ITransformCallbackInvoker, DraweeBinding")]
		void GetRootBounds (global::Android.Graphics.RectF p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='TransformCallback']/method[@name='getTransform' and count(parameter)=1 and parameter[1][@type='android.graphics.Matrix']]"
		[Register ("getTransform", "(Landroid/graphics/Matrix;)V", "GetGetTransform_Landroid_graphics_Matrix_Handler:Com.Facebook.Drawee.Drawable.ITransformCallbackInvoker, DraweeBinding")]
		void GetTransform (global::Android.Graphics.Matrix p0);

	}

	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/TransformCallback", DoNotGenerateAcw=true)]
	internal partial class ITransformCallbackInvoker : global::Java.Lang.Object, ITransformCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/TransformCallback", typeof (ITransformCallbackInvoker));

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

		public static ITransformCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITransformCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.drawee.drawable.TransformCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITransformCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getRootBounds_Landroid_graphics_RectF_;
#pragma warning disable 0169
		static Delegate GetGetRootBounds_Landroid_graphics_RectF_Handler ()
		{
			if (cb_getRootBounds_Landroid_graphics_RectF_ == null)
				cb_getRootBounds_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetRootBounds_Landroid_graphics_RectF_);
			return cb_getRootBounds_Landroid_graphics_RectF_;
		}

		static void n_GetRootBounds_Landroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Drawable.ITransformCallback __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ITransformCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetRootBounds (p0);
		}
#pragma warning restore 0169

		IntPtr id_getRootBounds_Landroid_graphics_RectF_;
		public unsafe void GetRootBounds (global::Android.Graphics.RectF p0)
		{
			if (id_getRootBounds_Landroid_graphics_RectF_ == IntPtr.Zero)
				id_getRootBounds_Landroid_graphics_RectF_ = JNIEnv.GetMethodID (class_ref, "getRootBounds", "(Landroid/graphics/RectF;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getRootBounds_Landroid_graphics_RectF_, __args);
		}

		static Delegate cb_getTransform_Landroid_graphics_Matrix_;
#pragma warning disable 0169
		static Delegate GetGetTransform_Landroid_graphics_Matrix_Handler ()
		{
			if (cb_getTransform_Landroid_graphics_Matrix_ == null)
				cb_getTransform_Landroid_graphics_Matrix_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetTransform_Landroid_graphics_Matrix_);
			return cb_getTransform_Landroid_graphics_Matrix_;
		}

		static void n_GetTransform_Landroid_graphics_Matrix_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Drawable.ITransformCallback __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ITransformCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetTransform (p0);
		}
#pragma warning restore 0169

		IntPtr id_getTransform_Landroid_graphics_Matrix_;
		public unsafe void GetTransform (global::Android.Graphics.Matrix p0)
		{
			if (id_getTransform_Landroid_graphics_Matrix_ == IntPtr.Zero)
				id_getTransform_Landroid_graphics_Matrix_ = JNIEnv.GetMethodID (class_ref, "getTransform", "(Landroid/graphics/Matrix;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getTransform_Landroid_graphics_Matrix_, __args);
		}

	}

}
