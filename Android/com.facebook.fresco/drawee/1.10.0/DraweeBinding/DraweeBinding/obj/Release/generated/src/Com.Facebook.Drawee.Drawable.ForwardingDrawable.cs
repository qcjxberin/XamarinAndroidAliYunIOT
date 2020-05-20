using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ForwardingDrawable']"
	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/ForwardingDrawable", DoNotGenerateAcw=true)]
	public partial class ForwardingDrawable : global::Android.Graphics.Drawables.Drawable, global::Android.Graphics.Drawables.Drawable.ICallback, global::Com.Facebook.Drawee.Drawable.IDrawableParent, global::Com.Facebook.Drawee.Drawable.ITransformAwareDrawable, global::Com.Facebook.Drawee.Drawable.ITransformCallback {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ForwardingDrawable']/field[@name='mTransformCallback']"
		[Register ("mTransformCallback")]
		protected global::Com.Facebook.Drawee.Drawable.ITransformCallback MTransformCallback {
			get {
				const string __id = "mTransformCallback.Lcom/facebook/drawee/drawable/TransformCallback;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ITransformCallback> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mTransformCallback.Lcom/facebook/drawee/drawable/TransformCallback;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/ForwardingDrawable", typeof (ForwardingDrawable));
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

		protected ForwardingDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ForwardingDrawable']/constructor[@name='ForwardingDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;)V", "")]
		public unsafe ForwardingDrawable (global::Android.Graphics.Drawables.Drawable drawable)
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
			global::Com.Facebook.Drawee.Drawable.ForwardingDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ForwardingDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Drawable);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable Drawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ForwardingDrawable']/method[@name='getDrawable' and count(parameter)=0]"
			[Register ("getDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetDrawableHandler")]
			get {
				const string __id = "getDrawable.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Facebook.Drawee.Drawable.ForwardingDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ForwardingDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Opacity;
		}
#pragma warning restore 0169

		public override unsafe int Opacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ForwardingDrawable']/method[@name='getOpacity' and count(parameter)=0]"
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
			global::Com.Facebook.Drawee.Drawable.ForwardingDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ForwardingDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.Draw (canvas);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ForwardingDrawable']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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

		static Delegate cb_getParentTransform_Landroid_graphics_Matrix_;
#pragma warning disable 0169
		static Delegate GetGetParentTransform_Landroid_graphics_Matrix_Handler ()
		{
			if (cb_getParentTransform_Landroid_graphics_Matrix_ == null)
				cb_getParentTransform_Landroid_graphics_Matrix_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetParentTransform_Landroid_graphics_Matrix_);
			return cb_getParentTransform_Landroid_graphics_Matrix_;
		}

		static void n_GetParentTransform_Landroid_graphics_Matrix_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transform)
		{
			global::Com.Facebook.Drawee.Drawable.ForwardingDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ForwardingDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix transform = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_transform, JniHandleOwnership.DoNotTransfer);
			__this.GetParentTransform (transform);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ForwardingDrawable']/method[@name='getParentTransform' and count(parameter)=1 and parameter[1][@type='android.graphics.Matrix']]"
		[Register ("getParentTransform", "(Landroid/graphics/Matrix;)V", "GetGetParentTransform_Landroid_graphics_Matrix_Handler")]
		protected virtual unsafe void GetParentTransform (global::Android.Graphics.Matrix transform)
		{
			const string __id = "getParentTransform.(Landroid/graphics/Matrix;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((transform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transform).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Facebook.Drawee.Drawable.ForwardingDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ForwardingDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF bounds = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_bounds, JniHandleOwnership.DoNotTransfer);
			__this.GetRootBounds (bounds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ForwardingDrawable']/method[@name='getRootBounds' and count(parameter)=1 and parameter[1][@type='android.graphics.RectF']]"
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
			global::Com.Facebook.Drawee.Drawable.ForwardingDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ForwardingDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix transform = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_transform, JniHandleOwnership.DoNotTransfer);
			__this.GetTransform (transform);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ForwardingDrawable']/method[@name='getTransform' and count(parameter)=1 and parameter[1][@type='android.graphics.Matrix']]"
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

		static Delegate cb_getTransformedBounds_Landroid_graphics_RectF_;
#pragma warning disable 0169
		static Delegate GetGetTransformedBounds_Landroid_graphics_RectF_Handler ()
		{
			if (cb_getTransformedBounds_Landroid_graphics_RectF_ == null)
				cb_getTransformedBounds_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetTransformedBounds_Landroid_graphics_RectF_);
			return cb_getTransformedBounds_Landroid_graphics_RectF_;
		}

		static void n_GetTransformedBounds_Landroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_outBounds)
		{
			global::Com.Facebook.Drawee.Drawable.ForwardingDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ForwardingDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF outBounds = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_outBounds, JniHandleOwnership.DoNotTransfer);
			__this.GetTransformedBounds (outBounds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ForwardingDrawable']/method[@name='getTransformedBounds' and count(parameter)=1 and parameter[1][@type='android.graphics.RectF']]"
		[Register ("getTransformedBounds", "(Landroid/graphics/RectF;)V", "GetGetTransformedBounds_Landroid_graphics_RectF_Handler")]
		public virtual unsafe void GetTransformedBounds (global::Android.Graphics.RectF outBounds)
		{
			const string __id = "getTransformedBounds.(Landroid/graphics/RectF;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((outBounds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outBounds).Handle);
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
			global::Com.Facebook.Drawee.Drawable.ForwardingDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ForwardingDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable who = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_who, JniHandleOwnership.DoNotTransfer);
			__this.InvalidateDrawable (who);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ForwardingDrawable']/method[@name='invalidateDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
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
			global::Com.Facebook.Drawee.Drawable.ForwardingDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ForwardingDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable who = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_who, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable what = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_what, JniHandleOwnership.DoNotTransfer);
			__this.ScheduleDrawable (who, what, when);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ForwardingDrawable']/method[@name='scheduleDrawable' and count(parameter)=3 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='java.lang.Runnable'] and parameter[3][@type='long']]"
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
			global::Com.Facebook.Drawee.Drawable.ForwardingDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ForwardingDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlpha (alpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ForwardingDrawable']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Facebook.Drawee.Drawable.ForwardingDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ForwardingDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.ColorFilter colorFilter = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_colorFilter, JniHandleOwnership.DoNotTransfer);
			__this.SetColorFilter (colorFilter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ForwardingDrawable']/method[@name='setColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
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

		static Delegate cb_setCurrent_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetCurrent_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setCurrent_Landroid_graphics_drawable_Drawable_ == null)
				cb_setCurrent_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCurrent_Landroid_graphics_drawable_Drawable_);
			return cb_setCurrent_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_SetCurrent_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newDelegate)
		{
			global::Com.Facebook.Drawee.Drawable.ForwardingDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ForwardingDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable newDelegate = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_newDelegate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCurrent (newDelegate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ForwardingDrawable']/method[@name='setCurrent' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setCurrent", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;", "GetSetCurrent_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Android.Graphics.Drawables.Drawable SetCurrent (global::Android.Graphics.Drawables.Drawable newDelegate)
		{
			const string __id = "setCurrent.(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newDelegate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newDelegate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCurrentWithoutInvalidate_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetCurrentWithoutInvalidate_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setCurrentWithoutInvalidate_Landroid_graphics_drawable_Drawable_ == null)
				cb_setCurrentWithoutInvalidate_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCurrentWithoutInvalidate_Landroid_graphics_drawable_Drawable_);
			return cb_setCurrentWithoutInvalidate_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_SetCurrentWithoutInvalidate_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newDelegate)
		{
			global::Com.Facebook.Drawee.Drawable.ForwardingDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ForwardingDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable newDelegate = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_newDelegate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCurrentWithoutInvalidate (newDelegate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ForwardingDrawable']/method[@name='setCurrentWithoutInvalidate' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setCurrentWithoutInvalidate", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;", "GetSetCurrentWithoutInvalidate_Landroid_graphics_drawable_Drawable_Handler")]
		protected virtual unsafe global::Android.Graphics.Drawables.Drawable SetCurrentWithoutInvalidate (global::Android.Graphics.Drawables.Drawable newDelegate)
		{
			const string __id = "setCurrentWithoutInvalidate.(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newDelegate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newDelegate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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

		static IntPtr n_SetDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newDrawable)
		{
			global::Com.Facebook.Drawee.Drawable.ForwardingDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ForwardingDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable newDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_newDrawable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDrawable (newDrawable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ForwardingDrawable']/method[@name='setDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setDrawable", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;", "GetSetDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Android.Graphics.Drawables.Drawable SetDrawable (global::Android.Graphics.Drawables.Drawable newDrawable)
		{
			const string __id = "setDrawable.(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newDrawable).Handle);
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
			global::Com.Facebook.Drawee.Drawable.ForwardingDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ForwardingDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ITransformCallback transformCallback = (global::Com.Facebook.Drawee.Drawable.ITransformCallback)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ITransformCallback> (native_transformCallback, JniHandleOwnership.DoNotTransfer);
			__this.SetTransformCallback (transformCallback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ForwardingDrawable']/method[@name='setTransformCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.drawable.TransformCallback']]"
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
			global::Com.Facebook.Drawee.Drawable.ForwardingDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ForwardingDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable who = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_who, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable what = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_what, JniHandleOwnership.DoNotTransfer);
			__this.UnscheduleDrawable (who, what);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ForwardingDrawable']/method[@name='unscheduleDrawable' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='java.lang.Runnable']]"
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
