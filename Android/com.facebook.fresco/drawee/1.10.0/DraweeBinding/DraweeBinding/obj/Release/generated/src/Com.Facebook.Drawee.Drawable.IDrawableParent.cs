using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='DrawableParent']"
	[Register ("com/facebook/drawee/drawable/DrawableParent", "", "Com.Facebook.Drawee.Drawable.IDrawableParentInvoker")]
	public partial interface IDrawableParent : IJavaObject, IJavaPeerable {

		global::Android.Graphics.Drawables.Drawable Drawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='DrawableParent']/method[@name='getDrawable' and count(parameter)=0]"
			[Register ("getDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetDrawableHandler:Com.Facebook.Drawee.Drawable.IDrawableParentInvoker, DraweeBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='DrawableParent']/method[@name='setDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setDrawable", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;", "GetSetDrawable_Landroid_graphics_drawable_Drawable_Handler:Com.Facebook.Drawee.Drawable.IDrawableParentInvoker, DraweeBinding")]
		global::Android.Graphics.Drawables.Drawable SetDrawable (global::Android.Graphics.Drawables.Drawable p0);

	}

	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/DrawableParent", DoNotGenerateAcw=true)]
	internal partial class IDrawableParentInvoker : global::Java.Lang.Object, IDrawableParent {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/DrawableParent", typeof (IDrawableParentInvoker));

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

		public static IDrawableParent GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDrawableParent> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.drawee.drawable.DrawableParent"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDrawableParentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getDrawable;
#pragma warning disable 0169
		static Delegate GetGetDrawableHandler ()
		{
			if (cb_getDrawable == null)
				cb_getDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDrawable);
			return cb_getDrawable;
		}

		static IntPtr n_GetDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.IDrawableParent __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.IDrawableParent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Drawable);
		}
#pragma warning restore 0169

		IntPtr id_getDrawable;
		public unsafe global::Android.Graphics.Drawables.Drawable Drawable {
			get {
				if (id_getDrawable == IntPtr.Zero)
					id_getDrawable = JNIEnv.GetMethodID (class_ref, "getDrawable", "()Landroid/graphics/drawable/Drawable;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDrawable), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_setDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_SetDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Drawable.IDrawableParent __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.IDrawableParent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDrawable (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setDrawable_Landroid_graphics_drawable_Drawable_;
		public unsafe global::Android.Graphics.Drawables.Drawable SetDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setDrawable", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Android.Graphics.Drawables.Drawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDrawable_Landroid_graphics_drawable_Drawable_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
