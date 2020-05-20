using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='DrawableProperties']"
	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/DrawableProperties", DoNotGenerateAcw=true)]
	public partial class DrawableProperties : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/DrawableProperties", typeof (DrawableProperties));
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

		protected DrawableProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='DrawableProperties']/constructor[@name='DrawableProperties' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DrawableProperties ()
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

		static Delegate cb_applyTo_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetApplyTo_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_applyTo_Landroid_graphics_drawable_Drawable_ == null)
				cb_applyTo_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ApplyTo_Landroid_graphics_drawable_Drawable_);
			return cb_applyTo_Landroid_graphics_drawable_Drawable_;
		}

		static void n_ApplyTo_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			global::Com.Facebook.Drawee.Drawable.DrawableProperties __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.DrawableProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.ApplyTo (drawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='DrawableProperties']/method[@name='applyTo' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("applyTo", "(Landroid/graphics/drawable/Drawable;)V", "GetApplyTo_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void ApplyTo (global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "applyTo.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetAlpha_IHandler ()
		{
			if (cb_setAlpha_I == null)
				cb_setAlpha_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAlpha_I);
			return cb_setAlpha_I;
		}

		static void n_SetAlpha_I (IntPtr jnienv, IntPtr native__this, int alpha)
		{
			global::Com.Facebook.Drawee.Drawable.DrawableProperties __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.DrawableProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlpha (alpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='DrawableProperties']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
		public virtual unsafe void SetAlpha (int alpha)
		{
			const string __id = "setAlpha.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (alpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;
#pragma warning disable 0169
		static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler ()
		{
			if (cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
				cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorFilter_Landroid_graphics_ColorFilter_);
			return cb_setColorFilter_Landroid_graphics_ColorFilter_;
		}

		static void n_SetColorFilter_Landroid_graphics_ColorFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colorFilter)
		{
			global::Com.Facebook.Drawee.Drawable.DrawableProperties __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.DrawableProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.ColorFilter colorFilter = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_colorFilter, JniHandleOwnership.DoNotTransfer);
			__this.SetColorFilter (colorFilter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='DrawableProperties']/method[@name='setColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
		[Register ("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public virtual unsafe void SetColorFilter (global::Android.Graphics.ColorFilter colorFilter)
		{
			const string __id = "setColorFilter.(Landroid/graphics/ColorFilter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((colorFilter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) colorFilter).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDither_Z;
#pragma warning disable 0169
		static Delegate GetSetDither_ZHandler ()
		{
			if (cb_setDither_Z == null)
				cb_setDither_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDither_Z);
			return cb_setDither_Z;
		}

		static void n_SetDither_Z (IntPtr jnienv, IntPtr native__this, bool dither)
		{
			global::Com.Facebook.Drawee.Drawable.DrawableProperties __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.DrawableProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDither (dither);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='DrawableProperties']/method[@name='setDither' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDither", "(Z)V", "GetSetDither_ZHandler")]
		public virtual unsafe void SetDither (bool dither)
		{
			const string __id = "setDither.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dither);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setFilterBitmap_Z;
#pragma warning disable 0169
		static Delegate GetSetFilterBitmap_ZHandler ()
		{
			if (cb_setFilterBitmap_Z == null)
				cb_setFilterBitmap_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFilterBitmap_Z);
			return cb_setFilterBitmap_Z;
		}

		static void n_SetFilterBitmap_Z (IntPtr jnienv, IntPtr native__this, bool filterBitmap)
		{
			global::Com.Facebook.Drawee.Drawable.DrawableProperties __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.DrawableProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFilterBitmap (filterBitmap);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='DrawableProperties']/method[@name='setFilterBitmap' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFilterBitmap", "(Z)V", "GetSetFilterBitmap_ZHandler")]
		public virtual unsafe void SetFilterBitmap (bool filterBitmap)
		{
			const string __id = "setFilterBitmap.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (filterBitmap);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
