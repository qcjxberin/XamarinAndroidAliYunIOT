using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Generic {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']"
	[global::Android.Runtime.Register ("com/facebook/drawee/generic/GenericDraweeHierarchy", DoNotGenerateAcw=true)]
	public partial class GenericDraweeHierarchy : global::Java.Lang.Object, global::Com.Facebook.Drawee.Interfaces.ISettableDraweeHierarchy {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/generic/GenericDraweeHierarchy", typeof (GenericDraweeHierarchy));
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

		protected GenericDraweeHierarchy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getActualImageScaleType;
#pragma warning disable 0169
		static Delegate GetGetActualImageScaleTypeHandler ()
		{
			if (cb_getActualImageScaleType == null)
				cb_getActualImageScaleType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActualImageScaleType);
			return cb_getActualImageScaleType;
		}

		static IntPtr n_GetActualImageScaleType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActualImageScaleType);
		}
#pragma warning restore 0169

		static Delegate cb_setActualImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetActualImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setActualImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setActualImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActualImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setActualImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static void n_SetActualImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_scaleType, JniHandleOwnership.DoNotTransfer);
			__this.ActualImageScaleType = scaleType;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType ActualImageScaleType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='getActualImageScaleType' and count(parameter)=0]"
			[Register ("getActualImageScaleType", "()Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;", "GetGetActualImageScaleTypeHandler")]
			get {
				const string __id = "getActualImageScaleType.()Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setActualImageScaleType' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
			[Register ("setActualImageScaleType", "(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V", "GetSetActualImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
			set {
				const string __id = "setActualImageScaleType.(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFadeDuration;
#pragma warning disable 0169
		static Delegate GetGetFadeDurationHandler ()
		{
			if (cb_getFadeDuration == null)
				cb_getFadeDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFadeDuration);
			return cb_getFadeDuration;
		}

		static int n_GetFadeDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FadeDuration;
		}
#pragma warning restore 0169

		static Delegate cb_setFadeDuration_I;
#pragma warning disable 0169
		static Delegate GetSetFadeDuration_IHandler ()
		{
			if (cb_setFadeDuration_I == null)
				cb_setFadeDuration_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFadeDuration_I);
			return cb_setFadeDuration_I;
		}

		static void n_SetFadeDuration_I (IntPtr jnienv, IntPtr native__this, int durationMs)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FadeDuration = durationMs;
		}
#pragma warning restore 0169

		public virtual unsafe int FadeDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='getFadeDuration' and count(parameter)=0]"
			[Register ("getFadeDuration", "()I", "GetGetFadeDurationHandler")]
			get {
				const string __id = "getFadeDuration.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setFadeDuration' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFadeDuration", "(I)V", "GetSetFadeDuration_IHandler")]
			set {
				const string __id = "setFadeDuration.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_hasImage;
#pragma warning disable 0169
		static Delegate GetHasImageHandler ()
		{
			if (cb_hasImage == null)
				cb_hasImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasImage);
			return cb_hasImage;
		}

		static bool n_HasImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasImage;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='hasImage' and count(parameter)=0]"
			[Register ("hasImage", "()Z", "GetHasImageHandler")]
			get {
				const string __id = "hasImage.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasPlaceholderImage;
#pragma warning disable 0169
		static Delegate GetHasPlaceholderImageHandler ()
		{
			if (cb_hasPlaceholderImage == null)
				cb_hasPlaceholderImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasPlaceholderImage);
			return cb_hasPlaceholderImage;
		}

		static bool n_HasPlaceholderImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPlaceholderImage;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasPlaceholderImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='hasPlaceholderImage' and count(parameter)=0]"
			[Register ("hasPlaceholderImage", "()Z", "GetHasPlaceholderImageHandler")]
			get {
				const string __id = "hasPlaceholderImage.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRoundingParams;
#pragma warning disable 0169
		static Delegate GetGetRoundingParamsHandler ()
		{
			if (cb_getRoundingParams == null)
				cb_getRoundingParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRoundingParams);
			return cb_getRoundingParams;
		}

		static IntPtr n_GetRoundingParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RoundingParams);
		}
#pragma warning restore 0169

		static Delegate cb_setRoundingParams_Lcom_facebook_drawee_generic_RoundingParams_;
#pragma warning disable 0169
		static Delegate GetSetRoundingParams_Lcom_facebook_drawee_generic_RoundingParams_Handler ()
		{
			if (cb_setRoundingParams_Lcom_facebook_drawee_generic_RoundingParams_ == null)
				cb_setRoundingParams_Lcom_facebook_drawee_generic_RoundingParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRoundingParams_Lcom_facebook_drawee_generic_RoundingParams_);
			return cb_setRoundingParams_Lcom_facebook_drawee_generic_RoundingParams_;
		}

		static void n_SetRoundingParams_Lcom_facebook_drawee_generic_RoundingParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_roundingParams)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Generic.RoundingParams roundingParams = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (native_roundingParams, JniHandleOwnership.DoNotTransfer);
			__this.RoundingParams = roundingParams;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Drawee.Generic.RoundingParams RoundingParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='getRoundingParams' and count(parameter)=0]"
			[Register ("getRoundingParams", "()Lcom/facebook/drawee/generic/RoundingParams;", "GetGetRoundingParamsHandler")]
			get {
				const string __id = "getRoundingParams.()Lcom/facebook/drawee/generic/RoundingParams;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setRoundingParams' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.generic.RoundingParams']]"
			[Register ("setRoundingParams", "(Lcom/facebook/drawee/generic/RoundingParams;)V", "GetSetRoundingParams_Lcom_facebook_drawee_generic_RoundingParams_Handler")]
			set {
				const string __id = "setRoundingParams.(Lcom/facebook/drawee/generic/RoundingParams;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
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
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TopLevelDrawable);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable TopLevelDrawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='getTopLevelDrawable' and count(parameter)=0]"
			[Register ("getTopLevelDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetTopLevelDrawableHandler")]
			get {
				const string __id = "getTopLevelDrawable.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getActualImageBounds_Landroid_graphics_RectF_;
#pragma warning disable 0169
		static Delegate GetGetActualImageBounds_Landroid_graphics_RectF_Handler ()
		{
			if (cb_getActualImageBounds_Landroid_graphics_RectF_ == null)
				cb_getActualImageBounds_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetActualImageBounds_Landroid_graphics_RectF_);
			return cb_getActualImageBounds_Landroid_graphics_RectF_;
		}

		static void n_GetActualImageBounds_Landroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_outBounds)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF outBounds = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_outBounds, JniHandleOwnership.DoNotTransfer);
			__this.GetActualImageBounds (outBounds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='getActualImageBounds' and count(parameter)=1 and parameter[1][@type='android.graphics.RectF']]"
		[Register ("getActualImageBounds", "(Landroid/graphics/RectF;)V", "GetGetActualImageBounds_Landroid_graphics_RectF_Handler")]
		public virtual unsafe void GetActualImageBounds (global::Android.Graphics.RectF outBounds)
		{
			const string __id = "getActualImageBounds.(Landroid/graphics/RectF;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((outBounds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outBounds).Handle);
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
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setActualImageColorFilter_Landroid_graphics_ColorFilter_;
#pragma warning disable 0169
		static Delegate GetSetActualImageColorFilter_Landroid_graphics_ColorFilter_Handler ()
		{
			if (cb_setActualImageColorFilter_Landroid_graphics_ColorFilter_ == null)
				cb_setActualImageColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActualImageColorFilter_Landroid_graphics_ColorFilter_);
			return cb_setActualImageColorFilter_Landroid_graphics_ColorFilter_;
		}

		static void n_SetActualImageColorFilter_Landroid_graphics_ColorFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colorfilter)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.ColorFilter colorfilter = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_colorfilter, JniHandleOwnership.DoNotTransfer);
			__this.SetActualImageColorFilter (colorfilter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setActualImageColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
		[Register ("setActualImageColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetActualImageColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public virtual unsafe void SetActualImageColorFilter (global::Android.Graphics.ColorFilter colorfilter)
		{
			const string __id = "setActualImageColorFilter.(Landroid/graphics/ColorFilter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((colorfilter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) colorfilter).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setActualImageFocusPoint_Landroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetSetActualImageFocusPoint_Landroid_graphics_PointF_Handler ()
		{
			if (cb_setActualImageFocusPoint_Landroid_graphics_PointF_ == null)
				cb_setActualImageFocusPoint_Landroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActualImageFocusPoint_Landroid_graphics_PointF_);
			return cb_setActualImageFocusPoint_Landroid_graphics_PointF_;
		}

		static void n_SetActualImageFocusPoint_Landroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_focusPoint)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF focusPoint = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (native_focusPoint, JniHandleOwnership.DoNotTransfer);
			__this.SetActualImageFocusPoint (focusPoint);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setActualImageFocusPoint' and count(parameter)=1 and parameter[1][@type='android.graphics.PointF']]"
		[Register ("setActualImageFocusPoint", "(Landroid/graphics/PointF;)V", "GetSetActualImageFocusPoint_Landroid_graphics_PointF_Handler")]
		public virtual unsafe void SetActualImageFocusPoint (global::Android.Graphics.PointF focusPoint)
		{
			const string __id = "setActualImageFocusPoint.(Landroid/graphics/PointF;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((focusPoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) focusPoint).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setBackgroundImage_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetBackgroundImage_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setBackgroundImage_Landroid_graphics_drawable_Drawable_ == null)
				cb_setBackgroundImage_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBackgroundImage_Landroid_graphics_drawable_Drawable_);
			return cb_setBackgroundImage_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetBackgroundImage_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.SetBackgroundImage (drawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setBackgroundImage' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setBackgroundImage", "(Landroid/graphics/drawable/Drawable;)V", "GetSetBackgroundImage_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetBackgroundImage (global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "setBackgroundImage.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		static void n_SetControllerOverlay_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.SetControllerOverlay (drawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setControllerOverlay' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setControllerOverlay", "(Landroid/graphics/drawable/Drawable;)V", "GetSetControllerOverlay_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetControllerOverlay (global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "setControllerOverlay.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setFailure_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetSetFailure_Ljava_lang_Throwable_Handler ()
		{
			if (cb_setFailure_Ljava_lang_Throwable_ == null)
				cb_setFailure_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFailure_Ljava_lang_Throwable_);
			return cb_setFailure_Ljava_lang_Throwable_;
		}

		static void n_SetFailure_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_throwable)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable throwable = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_throwable, JniHandleOwnership.DoNotTransfer);
			__this.SetFailure (throwable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setFailure' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("setFailure", "(Ljava/lang/Throwable;)V", "GetSetFailure_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void SetFailure (global::Java.Lang.Throwable throwable)
		{
			const string __id = "setFailure.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setFailureImage_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetFailureImage_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setFailureImage_Landroid_graphics_drawable_Drawable_ == null)
				cb_setFailureImage_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFailureImage_Landroid_graphics_drawable_Drawable_);
			return cb_setFailureImage_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetFailureImage_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.SetFailureImage (drawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setFailureImage' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setFailureImage", "(Landroid/graphics/drawable/Drawable;)V", "GetSetFailureImage_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetFailureImage (global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "setFailureImage.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setFailureImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetFailureImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setFailureImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setFailureImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFailureImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setFailureImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static void n_SetFailureImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable, IntPtr native_scaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_scaleType, JniHandleOwnership.DoNotTransfer);
			__this.SetFailureImage (drawable, scaleType);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setFailureImage' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setFailureImage", "(Landroid/graphics/drawable/Drawable;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V", "GetSetFailureImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe void SetFailureImage (global::Android.Graphics.Drawables.Drawable drawable, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType)
		{
			const string __id = "setFailureImage.(Landroid/graphics/drawable/Drawable;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				__args [1] = new JniArgumentValue ((scaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleType).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setFailureImage_I;
#pragma warning disable 0169
		static Delegate GetSetFailureImage_IHandler ()
		{
			if (cb_setFailureImage_I == null)
				cb_setFailureImage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFailureImage_I);
			return cb_setFailureImage_I;
		}

		static void n_SetFailureImage_I (IntPtr jnienv, IntPtr native__this, int resourceId)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFailureImage (resourceId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setFailureImage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFailureImage", "(I)V", "GetSetFailureImage_IHandler")]
		public virtual unsafe void SetFailureImage (int resourceId)
		{
			const string __id = "setFailureImage.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resourceId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setFailureImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetFailureImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setFailureImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setFailureImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetFailureImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setFailureImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static void n_SetFailureImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, int resourceId, IntPtr native_scaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_scaleType, JniHandleOwnership.DoNotTransfer);
			__this.SetFailureImage (resourceId, scaleType);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setFailureImage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setFailureImage", "(ILcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V", "GetSetFailureImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe void SetFailureImage (int resourceId, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType)
		{
			const string __id = "setFailureImage.(ILcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (resourceId);
				__args [1] = new JniArgumentValue ((scaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleType).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setImage_Landroid_graphics_drawable_Drawable_FZ;
#pragma warning disable 0169
		static Delegate GetSetImage_Landroid_graphics_drawable_Drawable_FZHandler ()
		{
			if (cb_setImage_Landroid_graphics_drawable_Drawable_FZ == null)
				cb_setImage_Landroid_graphics_drawable_Drawable_FZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, bool>) n_SetImage_Landroid_graphics_drawable_Drawable_FZ);
			return cb_setImage_Landroid_graphics_drawable_Drawable_FZ;
		}

		static void n_SetImage_Landroid_graphics_drawable_Drawable_FZ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable, float progress, bool immediate)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.SetImage (drawable, progress, immediate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setImage' and count(parameter)=3 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='float'] and parameter[3][@type='boolean']]"
		[Register ("setImage", "(Landroid/graphics/drawable/Drawable;FZ)V", "GetSetImage_Landroid_graphics_drawable_Drawable_FZHandler")]
		public virtual unsafe void SetImage (global::Android.Graphics.Drawables.Drawable drawable, float progress, bool immediate)
		{
			const string __id = "setImage.(Landroid/graphics/drawable/Drawable;FZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				__args [1] = new JniArgumentValue (progress);
				__args [2] = new JniArgumentValue (immediate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOverlayImage_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetOverlayImage_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setOverlayImage_Landroid_graphics_drawable_Drawable_ == null)
				cb_setOverlayImage_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOverlayImage_Landroid_graphics_drawable_Drawable_);
			return cb_setOverlayImage_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetOverlayImage_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.SetOverlayImage (drawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setOverlayImage' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setOverlayImage", "(Landroid/graphics/drawable/Drawable;)V", "GetSetOverlayImage_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetOverlayImage (global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "setOverlayImage.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOverlayImage_ILandroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetOverlayImage_ILandroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setOverlayImage_ILandroid_graphics_drawable_Drawable_ == null)
				cb_setOverlayImage_ILandroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetOverlayImage_ILandroid_graphics_drawable_Drawable_);
			return cb_setOverlayImage_ILandroid_graphics_drawable_Drawable_;
		}

		static void n_SetOverlayImage_ILandroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_drawable)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.SetOverlayImage (index, drawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setOverlayImage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("setOverlayImage", "(ILandroid/graphics/drawable/Drawable;)V", "GetSetOverlayImage_ILandroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetOverlayImage (int index, global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "setOverlayImage.(ILandroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPlaceholderImage_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetPlaceholderImage_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setPlaceholderImage_Landroid_graphics_drawable_Drawable_ == null)
				cb_setPlaceholderImage_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlaceholderImage_Landroid_graphics_drawable_Drawable_);
			return cb_setPlaceholderImage_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetPlaceholderImage_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.SetPlaceholderImage (drawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setPlaceholderImage' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setPlaceholderImage", "(Landroid/graphics/drawable/Drawable;)V", "GetSetPlaceholderImage_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetPlaceholderImage (global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "setPlaceholderImage.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPlaceholderImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetPlaceholderImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setPlaceholderImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setPlaceholderImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPlaceholderImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setPlaceholderImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static void n_SetPlaceholderImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable, IntPtr native_scaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_scaleType, JniHandleOwnership.DoNotTransfer);
			__this.SetPlaceholderImage (drawable, scaleType);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setPlaceholderImage' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setPlaceholderImage", "(Landroid/graphics/drawable/Drawable;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V", "GetSetPlaceholderImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe void SetPlaceholderImage (global::Android.Graphics.Drawables.Drawable drawable, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType)
		{
			const string __id = "setPlaceholderImage.(Landroid/graphics/drawable/Drawable;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				__args [1] = new JniArgumentValue ((scaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleType).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPlaceholderImage_I;
#pragma warning disable 0169
		static Delegate GetSetPlaceholderImage_IHandler ()
		{
			if (cb_setPlaceholderImage_I == null)
				cb_setPlaceholderImage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPlaceholderImage_I);
			return cb_setPlaceholderImage_I;
		}

		static void n_SetPlaceholderImage_I (IntPtr jnienv, IntPtr native__this, int resourceId)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPlaceholderImage (resourceId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setPlaceholderImage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPlaceholderImage", "(I)V", "GetSetPlaceholderImage_IHandler")]
		public virtual unsafe void SetPlaceholderImage (int resourceId)
		{
			const string __id = "setPlaceholderImage.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resourceId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPlaceholderImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetPlaceholderImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setPlaceholderImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setPlaceholderImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetPlaceholderImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setPlaceholderImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static void n_SetPlaceholderImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, int resourceId, IntPtr native_scaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_scaleType, JniHandleOwnership.DoNotTransfer);
			__this.SetPlaceholderImage (resourceId, scaleType);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setPlaceholderImage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setPlaceholderImage", "(ILcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V", "GetSetPlaceholderImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe void SetPlaceholderImage (int resourceId, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType)
		{
			const string __id = "setPlaceholderImage.(ILcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (resourceId);
				__args [1] = new JniArgumentValue ((scaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleType).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPlaceholderImageFocusPoint_Landroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetSetPlaceholderImageFocusPoint_Landroid_graphics_PointF_Handler ()
		{
			if (cb_setPlaceholderImageFocusPoint_Landroid_graphics_PointF_ == null)
				cb_setPlaceholderImageFocusPoint_Landroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlaceholderImageFocusPoint_Landroid_graphics_PointF_);
			return cb_setPlaceholderImageFocusPoint_Landroid_graphics_PointF_;
		}

		static void n_SetPlaceholderImageFocusPoint_Landroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_focusPoint)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF focusPoint = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (native_focusPoint, JniHandleOwnership.DoNotTransfer);
			__this.SetPlaceholderImageFocusPoint (focusPoint);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setPlaceholderImageFocusPoint' and count(parameter)=1 and parameter[1][@type='android.graphics.PointF']]"
		[Register ("setPlaceholderImageFocusPoint", "(Landroid/graphics/PointF;)V", "GetSetPlaceholderImageFocusPoint_Landroid_graphics_PointF_Handler")]
		public virtual unsafe void SetPlaceholderImageFocusPoint (global::Android.Graphics.PointF focusPoint)
		{
			const string __id = "setPlaceholderImageFocusPoint.(Landroid/graphics/PointF;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((focusPoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) focusPoint).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setProgress_FZ;
#pragma warning disable 0169
		static Delegate GetSetProgress_FZHandler ()
		{
			if (cb_setProgress_FZ == null)
				cb_setProgress_FZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, bool>) n_SetProgress_FZ);
			return cb_setProgress_FZ;
		}

		static void n_SetProgress_FZ (IntPtr jnienv, IntPtr native__this, float progress, bool immediate)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetProgress (progress, immediate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setProgress' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='boolean']]"
		[Register ("setProgress", "(FZ)V", "GetSetProgress_FZHandler")]
		public virtual unsafe void SetProgress (float progress, bool immediate)
		{
			const string __id = "setProgress.(FZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (progress);
				__args [1] = new JniArgumentValue (immediate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setProgressBarImage_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetProgressBarImage_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setProgressBarImage_Landroid_graphics_drawable_Drawable_ == null)
				cb_setProgressBarImage_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProgressBarImage_Landroid_graphics_drawable_Drawable_);
			return cb_setProgressBarImage_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetProgressBarImage_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.SetProgressBarImage (drawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setProgressBarImage' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setProgressBarImage", "(Landroid/graphics/drawable/Drawable;)V", "GetSetProgressBarImage_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetProgressBarImage (global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "setProgressBarImage.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setProgressBarImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetProgressBarImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setProgressBarImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setProgressBarImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetProgressBarImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setProgressBarImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static void n_SetProgressBarImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable, IntPtr native_scaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_scaleType, JniHandleOwnership.DoNotTransfer);
			__this.SetProgressBarImage (drawable, scaleType);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setProgressBarImage' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setProgressBarImage", "(Landroid/graphics/drawable/Drawable;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V", "GetSetProgressBarImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe void SetProgressBarImage (global::Android.Graphics.Drawables.Drawable drawable, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType)
		{
			const string __id = "setProgressBarImage.(Landroid/graphics/drawable/Drawable;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				__args [1] = new JniArgumentValue ((scaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleType).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setProgressBarImage_I;
#pragma warning disable 0169
		static Delegate GetSetProgressBarImage_IHandler ()
		{
			if (cb_setProgressBarImage_I == null)
				cb_setProgressBarImage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetProgressBarImage_I);
			return cb_setProgressBarImage_I;
		}

		static void n_SetProgressBarImage_I (IntPtr jnienv, IntPtr native__this, int resourceId)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetProgressBarImage (resourceId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setProgressBarImage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setProgressBarImage", "(I)V", "GetSetProgressBarImage_IHandler")]
		public virtual unsafe void SetProgressBarImage (int resourceId)
		{
			const string __id = "setProgressBarImage.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resourceId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setProgressBarImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetProgressBarImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setProgressBarImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setProgressBarImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetProgressBarImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setProgressBarImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static void n_SetProgressBarImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, int resourceId, IntPtr native_scaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_scaleType, JniHandleOwnership.DoNotTransfer);
			__this.SetProgressBarImage (resourceId, scaleType);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setProgressBarImage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setProgressBarImage", "(ILcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V", "GetSetProgressBarImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe void SetProgressBarImage (int resourceId, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType)
		{
			const string __id = "setProgressBarImage.(ILcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (resourceId);
				__args [1] = new JniArgumentValue ((scaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleType).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRetry_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetSetRetry_Ljava_lang_Throwable_Handler ()
		{
			if (cb_setRetry_Ljava_lang_Throwable_ == null)
				cb_setRetry_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRetry_Ljava_lang_Throwable_);
			return cb_setRetry_Ljava_lang_Throwable_;
		}

		static void n_SetRetry_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_throwable)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable throwable = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_throwable, JniHandleOwnership.DoNotTransfer);
			__this.SetRetry (throwable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setRetry' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("setRetry", "(Ljava/lang/Throwable;)V", "GetSetRetry_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void SetRetry (global::Java.Lang.Throwable throwable)
		{
			const string __id = "setRetry.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRetryImage_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetRetryImage_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setRetryImage_Landroid_graphics_drawable_Drawable_ == null)
				cb_setRetryImage_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRetryImage_Landroid_graphics_drawable_Drawable_);
			return cb_setRetryImage_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetRetryImage_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.SetRetryImage (drawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setRetryImage' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setRetryImage", "(Landroid/graphics/drawable/Drawable;)V", "GetSetRetryImage_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetRetryImage (global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "setRetryImage.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRetryImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetRetryImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setRetryImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setRetryImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRetryImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setRetryImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static void n_SetRetryImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable, IntPtr native_scaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_scaleType, JniHandleOwnership.DoNotTransfer);
			__this.SetRetryImage (drawable, scaleType);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setRetryImage' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setRetryImage", "(Landroid/graphics/drawable/Drawable;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V", "GetSetRetryImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe void SetRetryImage (global::Android.Graphics.Drawables.Drawable drawable, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType)
		{
			const string __id = "setRetryImage.(Landroid/graphics/drawable/Drawable;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				__args [1] = new JniArgumentValue ((scaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleType).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRetryImage_I;
#pragma warning disable 0169
		static Delegate GetSetRetryImage_IHandler ()
		{
			if (cb_setRetryImage_I == null)
				cb_setRetryImage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRetryImage_I);
			return cb_setRetryImage_I;
		}

		static void n_SetRetryImage_I (IntPtr jnienv, IntPtr native__this, int resourceId)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRetryImage (resourceId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setRetryImage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRetryImage", "(I)V", "GetSetRetryImage_IHandler")]
		public virtual unsafe void SetRetryImage (int resourceId)
		{
			const string __id = "setRetryImage.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resourceId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRetryImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetRetryImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setRetryImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setRetryImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetRetryImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setRetryImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static void n_SetRetryImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, int resourceId, IntPtr native_scaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_scaleType, JniHandleOwnership.DoNotTransfer);
			__this.SetRetryImage (resourceId, scaleType);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchy']/method[@name='setRetryImage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setRetryImage", "(ILcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V", "GetSetRetryImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe void SetRetryImage (int resourceId, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType)
		{
			const string __id = "setRetryImage.(ILcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (resourceId);
				__args [1] = new JniArgumentValue ((scaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleType).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
