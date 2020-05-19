using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Debug {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.debug']/class[@name='DebugControllerOverlayDrawable']"
	[global::Android.Runtime.Register ("com/facebook/drawee/debug/DebugControllerOverlayDrawable", DoNotGenerateAcw=true)]
	public partial class DebugControllerOverlayDrawable : global::Android.Graphics.Drawables.Drawable, global::Com.Facebook.Drawee.Debug.Listener.IImageLoadingTimeListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/debug/DebugControllerOverlayDrawable", typeof (DebugControllerOverlayDrawable));
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

		protected DebugControllerOverlayDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.debug']/class[@name='DebugControllerOverlayDrawable']/constructor[@name='DebugControllerOverlayDrawable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DebugControllerOverlayDrawable ()
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
			global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Opacity;
		}
#pragma warning restore 0169

		public override unsafe int Opacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.debug']/class[@name='DebugControllerOverlayDrawable']/method[@name='getOpacity' and count(parameter)=0]"
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
			global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.Draw (canvas);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.debug']/class[@name='DebugControllerOverlayDrawable']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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

		static Delegate cb_onFinalImageSet_J;
#pragma warning disable 0169
		static Delegate GetOnFinalImageSet_JHandler ()
		{
			if (cb_onFinalImageSet_J == null)
				cb_onFinalImageSet_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnFinalImageSet_J);
			return cb_onFinalImageSet_J;
		}

		static void n_OnFinalImageSet_J (IntPtr jnienv, IntPtr native__this, long finalImageTimeMs)
		{
			global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFinalImageSet (finalImageTimeMs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.debug']/class[@name='DebugControllerOverlayDrawable']/method[@name='onFinalImageSet' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("onFinalImageSet", "(J)V", "GetOnFinalImageSet_JHandler")]
		public virtual unsafe void OnFinalImageSet (long finalImageTimeMs)
		{
			const string __id = "onFinalImageSet.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (finalImageTimeMs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
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
			global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.debug']/class[@name='DebugControllerOverlayDrawable']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlpha (alpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.debug']/class[@name='DebugControllerOverlayDrawable']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_setAnimationInfo_II;
#pragma warning disable 0169
		static Delegate GetSetAnimationInfo_IIHandler ()
		{
			if (cb_setAnimationInfo_II == null)
				cb_setAnimationInfo_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetAnimationInfo_II);
			return cb_setAnimationInfo_II;
		}

		static void n_SetAnimationInfo_II (IntPtr jnienv, IntPtr native__this, int frameCount, int loopCount)
		{
			global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimationInfo (frameCount, loopCount);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.debug']/class[@name='DebugControllerOverlayDrawable']/method[@name='setAnimationInfo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setAnimationInfo", "(II)V", "GetSetAnimationInfo_IIHandler")]
		public virtual unsafe void SetAnimationInfo (int frameCount, int loopCount)
		{
			const string __id = "setAnimationInfo.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (frameCount);
				__args [1] = new JniArgumentValue (loopCount);
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

		static void n_SetColorFilter_Landroid_graphics_ColorFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cf)
		{
			global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.ColorFilter cf = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_cf, JniHandleOwnership.DoNotTransfer);
			__this.SetColorFilter (cf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.debug']/class[@name='DebugControllerOverlayDrawable']/method[@name='setColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
		[Register ("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public override unsafe void SetColorFilter (global::Android.Graphics.ColorFilter cf)
		{
			const string __id = "setColorFilter.(Landroid/graphics/ColorFilter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cf).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setControllerId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetControllerId_Ljava_lang_String_Handler ()
		{
			if (cb_setControllerId_Ljava_lang_String_ == null)
				cb_setControllerId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetControllerId_Ljava_lang_String_);
			return cb_setControllerId_Ljava_lang_String_;
		}

		static void n_SetControllerId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_controllerId)
		{
			global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string controllerId = JNIEnv.GetString (native_controllerId, JniHandleOwnership.DoNotTransfer);
			__this.SetControllerId (controllerId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.debug']/class[@name='DebugControllerOverlayDrawable']/method[@name='setControllerId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setControllerId", "(Ljava/lang/String;)V", "GetSetControllerId_Ljava_lang_String_Handler")]
		public virtual unsafe void SetControllerId (string controllerId)
		{
			const string __id = "setControllerId.(Ljava/lang/String;)V";
			IntPtr native_controllerId = JNIEnv.NewString (controllerId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_controllerId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_controllerId);
			}
		}

		static Delegate cb_setDimensions_II;
#pragma warning disable 0169
		static Delegate GetSetDimensions_IIHandler ()
		{
			if (cb_setDimensions_II == null)
				cb_setDimensions_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetDimensions_II);
			return cb_setDimensions_II;
		}

		static void n_SetDimensions_II (IntPtr jnienv, IntPtr native__this, int widthPx, int heightPx)
		{
			global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDimensions (widthPx, heightPx);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.debug']/class[@name='DebugControllerOverlayDrawable']/method[@name='setDimensions' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setDimensions", "(II)V", "GetSetDimensions_IIHandler")]
		public virtual unsafe void SetDimensions (int widthPx, int heightPx)
		{
			const string __id = "setDimensions.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (widthPx);
				__args [1] = new JniArgumentValue (heightPx);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setFinalImageTimeMs_J;
#pragma warning disable 0169
		static Delegate GetSetFinalImageTimeMs_JHandler ()
		{
			if (cb_setFinalImageTimeMs_J == null)
				cb_setFinalImageTimeMs_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetFinalImageTimeMs_J);
			return cb_setFinalImageTimeMs_J;
		}

		static void n_SetFinalImageTimeMs_J (IntPtr jnienv, IntPtr native__this, long finalImageTimeMs)
		{
			global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFinalImageTimeMs (finalImageTimeMs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.debug']/class[@name='DebugControllerOverlayDrawable']/method[@name='setFinalImageTimeMs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setFinalImageTimeMs", "(J)V", "GetSetFinalImageTimeMs_JHandler")]
		public virtual unsafe void SetFinalImageTimeMs (long finalImageTimeMs)
		{
			const string __id = "setFinalImageTimeMs.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (finalImageTimeMs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setImageFormat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImageFormat_Ljava_lang_String_Handler ()
		{
			if (cb_setImageFormat_Ljava_lang_String_ == null)
				cb_setImageFormat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageFormat_Ljava_lang_String_);
			return cb_setImageFormat_Ljava_lang_String_;
		}

		static void n_SetImageFormat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageFormat)
		{
			global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string imageFormat = JNIEnv.GetString (native_imageFormat, JniHandleOwnership.DoNotTransfer);
			__this.SetImageFormat (imageFormat);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.debug']/class[@name='DebugControllerOverlayDrawable']/method[@name='setImageFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setImageFormat", "(Ljava/lang/String;)V", "GetSetImageFormat_Ljava_lang_String_Handler")]
		public virtual unsafe void SetImageFormat (string imageFormat)
		{
			const string __id = "setImageFormat.(Ljava/lang/String;)V";
			IntPtr native_imageFormat = JNIEnv.NewString (imageFormat);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_imageFormat);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_imageFormat);
			}
		}

		static Delegate cb_setImageId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImageId_Ljava_lang_String_Handler ()
		{
			if (cb_setImageId_Ljava_lang_String_ == null)
				cb_setImageId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageId_Ljava_lang_String_);
			return cb_setImageId_Ljava_lang_String_;
		}

		static void n_SetImageId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageId)
		{
			global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string imageId = JNIEnv.GetString (native_imageId, JniHandleOwnership.DoNotTransfer);
			__this.SetImageId (imageId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.debug']/class[@name='DebugControllerOverlayDrawable']/method[@name='setImageId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setImageId", "(Ljava/lang/String;)V", "GetSetImageId_Ljava_lang_String_Handler")]
		public virtual unsafe void SetImageId (string imageId)
		{
			const string __id = "setImageId.(Ljava/lang/String;)V";
			IntPtr native_imageId = JNIEnv.NewString (imageId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_imageId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_imageId);
			}
		}

		static Delegate cb_setImageSize_I;
#pragma warning disable 0169
		static Delegate GetSetImageSize_IHandler ()
		{
			if (cb_setImageSize_I == null)
				cb_setImageSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetImageSize_I);
			return cb_setImageSize_I;
		}

		static void n_SetImageSize_I (IntPtr jnienv, IntPtr native__this, int imageSizeBytes)
		{
			global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetImageSize (imageSizeBytes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.debug']/class[@name='DebugControllerOverlayDrawable']/method[@name='setImageSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setImageSize", "(I)V", "GetSetImageSize_IHandler")]
		public virtual unsafe void SetImageSize (int imageSizeBytes)
		{
			const string __id = "setImageSize.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (imageSizeBytes);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static void n_SetScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scaleType)
		{
			global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_scaleType, JniHandleOwnership.DoNotTransfer);
			__this.SetScaleType (scaleType);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.debug']/class[@name='DebugControllerOverlayDrawable']/method[@name='setScaleType' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setScaleType", "(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V", "GetSetScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe void SetScaleType (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType)
		{
			const string __id = "setScaleType.(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((scaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleType).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTextGravity_I;
#pragma warning disable 0169
		static Delegate GetSetTextGravity_IHandler ()
		{
			if (cb_setTextGravity_I == null)
				cb_setTextGravity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTextGravity_I);
			return cb_setTextGravity_I;
		}

		static void n_SetTextGravity_I (IntPtr jnienv, IntPtr native__this, int textGravity)
		{
			global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Debug.DebugControllerOverlayDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTextGravity (textGravity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.debug']/class[@name='DebugControllerOverlayDrawable']/method[@name='setTextGravity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTextGravity", "(I)V", "GetSetTextGravity_IHandler")]
		public virtual unsafe void SetTextGravity (int textGravity)
		{
			const string __id = "setTextGravity.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (textGravity);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
