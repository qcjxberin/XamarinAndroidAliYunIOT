using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SettableDraweeHierarchy']"
	[Register ("com/facebook/drawee/interfaces/SettableDraweeHierarchy", "", "Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchyInvoker")]
	public partial interface ISettableDraweeHierarchy : global::Com.Facebook.Drawee.Interfaces.IDraweeHierarchy {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SettableDraweeHierarchy']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler:Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchyInvoker, DraweeBinding")]
		void Reset ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SettableDraweeHierarchy']/method[@name='setControllerOverlay' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setControllerOverlay", "(Landroid/graphics/drawable/Drawable;)V", "GetSetControllerOverlay_Landroid_graphics_drawable_Drawable_Handler:Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchyInvoker, DraweeBinding")]
		void SetControllerOverlay (global::Android.Graphics.Drawables.Drawable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SettableDraweeHierarchy']/method[@name='setFailure' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("setFailure", "(Ljava/lang/Throwable;)V", "GetSetFailure_Ljava_lang_Throwable_Handler:Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchyInvoker, DraweeBinding")]
		void SetFailure (global::Java.Lang.Throwable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SettableDraweeHierarchy']/method[@name='setImage' and count(parameter)=3 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='float'] and parameter[3][@type='boolean']]"
		[Register ("setImage", "(Landroid/graphics/drawable/Drawable;FZ)V", "GetSetImage_Landroid_graphics_drawable_Drawable_FZHandler:Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchyInvoker, DraweeBinding")]
		void SetImage (global::Android.Graphics.Drawables.Drawable p0, float p1, bool p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SettableDraweeHierarchy']/method[@name='setProgress' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='boolean']]"
		[Register ("setProgress", "(FZ)V", "GetSetProgress_FZHandler:Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchyInvoker, DraweeBinding")]
		void SetProgress (float p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SettableDraweeHierarchy']/method[@name='setRetry' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("setRetry", "(Ljava/lang/Throwable;)V", "GetSetRetry_Ljava_lang_Throwable_Handler:Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchyInvoker, DraweeBinding")]
		void SetRetry (global::Java.Lang.Throwable p0);

	}

	[global::Android.Runtime.Register ("com/facebook/drawee/interfaces/SettableDraweeHierarchy", DoNotGenerateAcw=true)]
	internal partial class ISettableDraweeHierarchyInvoker : global::Java.Lang.Object, ISettableDraweeHierarchy {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/interfaces/SettableDraweeHierarchy", typeof (ISettableDraweeHierarchyInvoker));

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

		public static ISettableDraweeHierarchy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISettableDraweeHierarchy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.drawee.interfaces.SettableDraweeHierarchy"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISettableDraweeHierarchyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		IntPtr id_reset;
		public unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
		}

		static Delegate cb_setControllerOverlay_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetControllerOverlay_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setControllerOverlay_Landroid_graphics_drawable_Drawable_ == null)
				cb_setControllerOverlay_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetControllerOverlay_Landroid_graphics_drawable_Drawable_);
			return cb_setControllerOverlay_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetControllerOverlay_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetControllerOverlay (p0);
		}
#pragma warning restore 0169

		IntPtr id_setControllerOverlay_Landroid_graphics_drawable_Drawable_;
		public unsafe void SetControllerOverlay (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setControllerOverlay_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setControllerOverlay_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setControllerOverlay", "(Landroid/graphics/drawable/Drawable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setControllerOverlay_Landroid_graphics_drawable_Drawable_, __args);
		}

		static Delegate cb_setFailure_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetSetFailure_Ljava_lang_Throwable_Handler ()
		{
			if (cb_setFailure_Ljava_lang_Throwable_ == null)
				cb_setFailure_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFailure_Ljava_lang_Throwable_);
			return cb_setFailure_Ljava_lang_Throwable_;
		}

		static void n_SetFailure_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFailure (p0);
		}
#pragma warning restore 0169

		IntPtr id_setFailure_Ljava_lang_Throwable_;
		public unsafe void SetFailure (global::Java.Lang.Throwable p0)
		{
			if (id_setFailure_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_setFailure_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "setFailure", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFailure_Ljava_lang_Throwable_, __args);
		}

		static Delegate cb_setImage_Landroid_graphics_drawable_Drawable_FZ;
#pragma warning disable 0169
		static Delegate GetSetImage_Landroid_graphics_drawable_Drawable_FZHandler ()
		{
			if (cb_setImage_Landroid_graphics_drawable_Drawable_FZ == null)
				cb_setImage_Landroid_graphics_drawable_Drawable_FZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, bool>) n_SetImage_Landroid_graphics_drawable_Drawable_FZ);
			return cb_setImage_Landroid_graphics_drawable_Drawable_FZ;
		}

		static void n_SetImage_Landroid_graphics_drawable_Drawable_FZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, bool p2)
		{
			global::Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetImage (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_setImage_Landroid_graphics_drawable_Drawable_FZ;
		public unsafe void SetImage (global::Android.Graphics.Drawables.Drawable p0, float p1, bool p2)
		{
			if (id_setImage_Landroid_graphics_drawable_Drawable_FZ == IntPtr.Zero)
				id_setImage_Landroid_graphics_drawable_Drawable_FZ = JNIEnv.GetMethodID (class_ref, "setImage", "(Landroid/graphics/drawable/Drawable;FZ)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImage_Landroid_graphics_drawable_Drawable_FZ, __args);
		}

		static Delegate cb_setProgress_FZ;
#pragma warning disable 0169
		static Delegate GetSetProgress_FZHandler ()
		{
			if (cb_setProgress_FZ == null)
				cb_setProgress_FZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, bool>) n_SetProgress_FZ);
			return cb_setProgress_FZ;
		}

		static void n_SetProgress_FZ (IntPtr jnienv, IntPtr native__this, float p0, bool p1)
		{
			global::Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetProgress (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setProgress_FZ;
		public unsafe void SetProgress (float p0, bool p1)
		{
			if (id_setProgress_FZ == IntPtr.Zero)
				id_setProgress_FZ = JNIEnv.GetMethodID (class_ref, "setProgress", "(FZ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProgress_FZ, __args);
		}

		static Delegate cb_setRetry_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetSetRetry_Ljava_lang_Throwable_Handler ()
		{
			if (cb_setRetry_Ljava_lang_Throwable_ == null)
				cb_setRetry_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRetry_Ljava_lang_Throwable_);
			return cb_setRetry_Ljava_lang_Throwable_;
		}

		static void n_SetRetry_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRetry (p0);
		}
#pragma warning restore 0169

		IntPtr id_setRetry_Ljava_lang_Throwable_;
		public unsafe void SetRetry (global::Java.Lang.Throwable p0)
		{
			if (id_setRetry_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_setRetry_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "setRetry", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRetry_Ljava_lang_Throwable_, __args);
		}

		static Delegate cb_getTopLevelDrawable;
#pragma warning disable 0169
		static Delegate GetGetTopLevelDrawableHandler ()
		{
			if (cb_getTopLevelDrawable == null)
				cb_getTopLevelDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTopLevelDrawable);
			return cb_getTopLevelDrawable;
		}

		static IntPtr n_GetTopLevelDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TopLevelDrawable);
		}
#pragma warning restore 0169

		IntPtr id_getTopLevelDrawable;
		public unsafe global::Android.Graphics.Drawables.Drawable TopLevelDrawable {
			get {
				if (id_getTopLevelDrawable == IntPtr.Zero)
					id_getTopLevelDrawable = JNIEnv.GetMethodID (class_ref, "getTopLevelDrawable", "()Landroid/graphics/drawable/Drawable;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTopLevelDrawable), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
