using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ArrayDrawable']"
	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/ArrayDrawable", DoNotGenerateAcw=true)]
	public partial class ArrayDrawable : global::Android.Graphics.Drawables.Drawable, global::Android.Graphics.Drawables.Drawable.ICallback, global::Com.Facebook.Drawee.Drawable.ITransformAwareDrawable, global::Com.Facebook.Drawee.Drawable.ITransformCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/ArrayDrawable", typeof (ArrayDrawable));
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

		protected ArrayDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ArrayDrawable']/constructor[@name='ArrayDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable[]']]"
		[Register (".ctor", "([Landroid/graphics/drawable/Drawable;)V", "")]
		public unsafe ArrayDrawable (global::Android.Graphics.Drawables.Drawable[] layers)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Landroid/graphics/drawable/Drawable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_layers = JNIEnv.NewArray (layers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_layers);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (layers != null) {
					JNIEnv.CopyArray (native_layers, layers);
					JNIEnv.DeleteLocalRef (native_layers);
				}
			}
		}

		static Delegate cb_getNumberOfLayers;
#pragma warning disable 0169
		static Delegate GetGetNumberOfLayersHandler ()
		{
			if (cb_getNumberOfLayers == null)
				cb_getNumberOfLayers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumberOfLayers);
			return cb_getNumberOfLayers;
		}

		static int n_GetNumberOfLayers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.ArrayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ArrayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumberOfLayers;
		}
#pragma warning restore 0169

		public virtual unsafe int NumberOfLayers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ArrayDrawable']/method[@name='getNumberOfLayers' and count(parameter)=0]"
			[Register ("getNumberOfLayers", "()I", "GetGetNumberOfLayersHandler")]
			get {
				const string __id = "getNumberOfLayers.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOpacity;
#pragma warning disable 0169
		static Delegate GetGetOpacityHandler ()
		{
			if (cb_getOpacity == null)
				cb_getOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOpacity);
			return cb_getOpacity;
		}

		static int n_GetOpacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.ArrayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ArrayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Opacity;
		}
#pragma warning restore 0169

		public override unsafe int Opacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ArrayDrawable']/method[@name='getOpacity' and count(parameter)=0]"
			[Register ("getOpacity", "()I", "GetGetOpacityHandler")]
			get {
				const string __id = "getOpacity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_ == null)
				cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_);
			return cb_draw_Landroid_graphics_Canvas_;
		}

		static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas)
		{
			global::Com.Facebook.Drawee.Drawable.ArrayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ArrayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.Draw (canvas);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ArrayDrawable']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public override unsafe void Draw (global::Android.Graphics.Canvas canvas)
		{
			const string __id = "draw.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getDrawable_I;
#pragma warning disable 0169
		static Delegate GetGetDrawable_IHandler ()
		{
			if (cb_getDrawable_I == null)
				cb_getDrawable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetDrawable_I);
			return cb_getDrawable_I;
		}

		static IntPtr n_GetDrawable_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Com.Facebook.Drawee.Drawable.ArrayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ArrayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDrawable (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ArrayDrawable']/method[@name='getDrawable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDrawable", "(I)Landroid/graphics/drawable/Drawable;", "GetGetDrawable_IHandler")]
		public virtual unsafe global::Android.Graphics.Drawables.Drawable GetDrawable (int index)
		{
			const string __id = "getDrawable.(I)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getDrawableParentForIndex_I;
#pragma warning disable 0169
		static Delegate GetGetDrawableParentForIndex_IHandler ()
		{
			if (cb_getDrawableParentForIndex_I == null)
				cb_getDrawableParentForIndex_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetDrawableParentForIndex_I);
			return cb_getDrawableParentForIndex_I;
		}

		static IntPtr n_GetDrawableParentForIndex_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Com.Facebook.Drawee.Drawable.ArrayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ArrayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDrawableParentForIndex (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ArrayDrawable']/method[@name='getDrawableParentForIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDrawableParentForIndex", "(I)Lcom/facebook/drawee/drawable/DrawableParent;", "GetGetDrawableParentForIndex_IHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Drawable.IDrawableParent GetDrawableParentForIndex (int index)
		{
			const string __id = "getDrawableParentForIndex.(I)Lcom/facebook/drawee/drawable/DrawableParent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.IDrawableParent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getRootBounds_Landroid_graphics_RectF_;
#pragma warning disable 0169
		static Delegate GetGetRootBounds_Landroid_graphics_RectF_Handler ()
		{
			if (cb_getRootBounds_Landroid_graphics_RectF_ == null)
				cb_getRootBounds_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetRootBounds_Landroid_graphics_RectF_);
			return cb_getRootBounds_Landroid_graphics_RectF_;
		}

		static void n_GetRootBounds_Landroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bounds)
		{
			global::Com.Facebook.Drawee.Drawable.ArrayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ArrayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF bounds = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_bounds, JniHandleOwnership.DoNotTransfer);
			__this.GetRootBounds (bounds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ArrayDrawable']/method[@name='getRootBounds' and count(parameter)=1 and parameter[1][@type='android.graphics.RectF']]"
		[Register ("getRootBounds", "(Landroid/graphics/RectF;)V", "GetGetRootBounds_Landroid_graphics_RectF_Handler")]
		public virtual unsafe void GetRootBounds (global::Android.Graphics.RectF bounds)
		{
			const string __id = "getRootBounds.(Landroid/graphics/RectF;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bounds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bounds).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getTransform_Landroid_graphics_Matrix_;
#pragma warning disable 0169
		static Delegate GetGetTransform_Landroid_graphics_Matrix_Handler ()
		{
			if (cb_getTransform_Landroid_graphics_Matrix_ == null)
				cb_getTransform_Landroid_graphics_Matrix_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetTransform_Landroid_graphics_Matrix_);
			return cb_getTransform_Landroid_graphics_Matrix_;
		}

		static void n_GetTransform_Landroid_graphics_Matrix_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transform)
		{
			global::Com.Facebook.Drawee.Drawable.ArrayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ArrayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix transform = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_transform, JniHandleOwnership.DoNotTransfer);
			__this.GetTransform (transform);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ArrayDrawable']/method[@name='getTransform' and count(parameter)=1 and parameter[1][@type='android.graphics.Matrix']]"
		[Register ("getTransform", "(Landroid/graphics/Matrix;)V", "GetGetTransform_Landroid_graphics_Matrix_Handler")]
		public virtual unsafe void GetTransform (global::Android.Graphics.Matrix transform)
		{
			const string __id = "getTransform.(Landroid/graphics/Matrix;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((transform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transform).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetInvalidateDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InvalidateDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_InvalidateDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_who)
		{
			global::Com.Facebook.Drawee.Drawable.ArrayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ArrayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable who = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_who, JniHandleOwnership.DoNotTransfer);
			__this.InvalidateDrawable (who);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ArrayDrawable']/method[@name='invalidateDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetInvalidateDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void InvalidateDrawable (global::Android.Graphics.Drawables.Drawable who)
		{
			const string __id = "invalidateDrawable.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((who == null) ? IntPtr.Zero : ((global::Java.Lang.Object) who).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J;
#pragma warning disable 0169
		static Delegate GetScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_JHandler ()
		{
			if (cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J == null)
				cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_ScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J);
			return cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J;
		}

		static void n_ScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J (IntPtr jnienv, IntPtr native__this, IntPtr native_who, IntPtr native_what, long when)
		{
			global::Com.Facebook.Drawee.Drawable.ArrayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ArrayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable who = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_who, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable what = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_what, JniHandleOwnership.DoNotTransfer);
			__this.ScheduleDrawable (who, what, when);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ArrayDrawable']/method[@name='scheduleDrawable' and count(parameter)=3 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='java.lang.Runnable'] and parameter[3][@type='long']]"
		[Register ("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", "GetScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_JHandler")]
		public virtual unsafe void ScheduleDrawable (global::Android.Graphics.Drawables.Drawable who, global::Java.Lang.IRunnable what, long when)
		{
			const string __id = "scheduleDrawable.(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((who == null) ? IntPtr.Zero : ((global::Java.Lang.Object) who).Handle);
				__args [1] = new JniArgumentValue ((what == null) ? IntPtr.Zero : ((global::Java.Lang.Object) what).Handle);
				__args [2] = new JniArgumentValue (when);
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
			global::Com.Facebook.Drawee.Drawable.ArrayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ArrayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlpha (alpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ArrayDrawable']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
		public override unsafe void SetAlpha (int alpha)
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
			global::Com.Facebook.Drawee.Drawable.ArrayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ArrayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.ColorFilter colorFilter = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_colorFilter, JniHandleOwnership.DoNotTransfer);
			__this.SetColorFilter (colorFilter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ArrayDrawable']/method[@name='setColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
		[Register ("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public override unsafe void SetColorFilter (global::Android.Graphics.ColorFilter colorFilter)
		{
			const string __id = "setColorFilter.(Landroid/graphics/ColorFilter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((colorFilter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) colorFilter).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawable_ILandroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetDrawable_ILandroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setDrawable_ILandroid_graphics_drawable_Drawable_ == null)
				cb_setDrawable_ILandroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetDrawable_ILandroid_graphics_drawable_Drawable_);
			return cb_setDrawable_ILandroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_SetDrawable_ILandroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_drawable)
		{
			global::Com.Facebook.Drawee.Drawable.ArrayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ArrayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDrawable (index, drawable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ArrayDrawable']/method[@name='setDrawable' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("setDrawable", "(ILandroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;", "GetSetDrawable_ILandroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Android.Graphics.Drawables.Drawable SetDrawable (int index, global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "setDrawable.(ILandroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_;
#pragma warning disable 0169
		static Delegate GetSetTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_Handler ()
		{
			if (cb_setTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_ == null)
				cb_setTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_);
			return cb_setTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_;
		}

		static void n_SetTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transformCallback)
		{
			global::Com.Facebook.Drawee.Drawable.ArrayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ArrayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ITransformCallback transformCallback = (global::Com.Facebook.Drawee.Drawable.ITransformCallback)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ITransformCallback> (native_transformCallback, JniHandleOwnership.DoNotTransfer);
			__this.SetTransformCallback (transformCallback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ArrayDrawable']/method[@name='setTransformCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.drawable.TransformCallback']]"
		[Register ("setTransformCallback", "(Lcom/facebook/drawee/drawable/TransformCallback;)V", "GetSetTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_Handler")]
		public virtual unsafe void SetTransformCallback (global::Com.Facebook.Drawee.Drawable.ITransformCallback transformCallback)
		{
			const string __id = "setTransformCallback.(Lcom/facebook/drawee/drawable/TransformCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((transformCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transformCallback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetUnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_Handler ()
		{
			if (cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_ == null)
				cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_);
			return cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_;
		}

		static void n_UnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_who, IntPtr native_what)
		{
			global::Com.Facebook.Drawee.Drawable.ArrayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ArrayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable who = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_who, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable what = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_what, JniHandleOwnership.DoNotTransfer);
			__this.UnscheduleDrawable (who, what);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ArrayDrawable']/method[@name='unscheduleDrawable' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='java.lang.Runnable']]"
		[Register ("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", "GetUnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void UnscheduleDrawable (global::Android.Graphics.Drawables.Drawable who, global::Java.Lang.IRunnable what)
		{
			const string __id = "unscheduleDrawable.(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((who == null) ? IntPtr.Zero : ((global::Java.Lang.Object) who).Handle);
				__args [1] = new JniArgumentValue ((what == null) ? IntPtr.Zero : ((global::Java.Lang.Object) what).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
