using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Generic {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']"
	[global::Android.Runtime.Register ("com/facebook/drawee/generic/GenericDraweeHierarchyBuilder", DoNotGenerateAcw=true)]
	public partial class GenericDraweeHierarchyBuilder : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/field[@name='DEFAULT_ACTUAL_IMAGE_SCALE_TYPE']"
		[Register ("DEFAULT_ACTUAL_IMAGE_SCALE_TYPE")]
		public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType DefaultActualImageScaleType {
			get {
				const string __id = "DEFAULT_ACTUAL_IMAGE_SCALE_TYPE.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/field[@name='DEFAULT_FADE_DURATION']"
		[Register ("DEFAULT_FADE_DURATION")]
		public const int DefaultFadeDuration = (int) 300;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/field[@name='DEFAULT_SCALE_TYPE']"
		[Register ("DEFAULT_SCALE_TYPE")]
		public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType DefaultScaleType {
			get {
				const string __id = "DEFAULT_SCALE_TYPE.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/generic/GenericDraweeHierarchyBuilder", typeof (GenericDraweeHierarchyBuilder));
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

		protected GenericDraweeHierarchyBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/constructor[@name='GenericDraweeHierarchyBuilder' and count(parameter)=1 and parameter[1][@type='android.content.res.Resources']]"
		[Register (".ctor", "(Landroid/content/res/Resources;)V", "")]
		public unsafe GenericDraweeHierarchyBuilder (global::Android.Content.Res.Resources resources)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/res/Resources;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((resources == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resources).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getActualImageColorFilter;
#pragma warning disable 0169
		static Delegate GetGetActualImageColorFilterHandler ()
		{
			if (cb_getActualImageColorFilter == null)
				cb_getActualImageColorFilter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActualImageColorFilter);
			return cb_getActualImageColorFilter;
		}

		static IntPtr n_GetActualImageColorFilter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActualImageColorFilter);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.ColorFilter ActualImageColorFilter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='getActualImageColorFilter' and count(parameter)=0]"
			[Register ("getActualImageColorFilter", "()Landroid/graphics/ColorFilter;", "GetGetActualImageColorFilterHandler")]
			get {
				const string __id = "getActualImageColorFilter.()Landroid/graphics/ColorFilter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getActualImageFocusPoint;
#pragma warning disable 0169
		static Delegate GetGetActualImageFocusPointHandler ()
		{
			if (cb_getActualImageFocusPoint == null)
				cb_getActualImageFocusPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActualImageFocusPoint);
			return cb_getActualImageFocusPoint;
		}

		static IntPtr n_GetActualImageFocusPoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActualImageFocusPoint);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.PointF ActualImageFocusPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='getActualImageFocusPoint' and count(parameter)=0]"
			[Register ("getActualImageFocusPoint", "()Landroid/graphics/PointF;", "GetGetActualImageFocusPointHandler")]
			get {
				const string __id = "getActualImageFocusPoint.()Landroid/graphics/PointF;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

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
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActualImageScaleType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType ActualImageScaleType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='getActualImageScaleType' and count(parameter)=0]"
			[Register ("getActualImageScaleType", "()Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;", "GetGetActualImageScaleTypeHandler")]
			get {
				const string __id = "getActualImageScaleType.()Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBackground;
#pragma warning disable 0169
		static Delegate GetGetBackgroundHandler ()
		{
			if (cb_getBackground == null)
				cb_getBackground = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBackground);
			return cb_getBackground;
		}

		static IntPtr n_GetBackground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Background);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable Background {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='getBackground' and count(parameter)=0]"
			[Register ("getBackground", "()Landroid/graphics/drawable/Drawable;", "GetGetBackgroundHandler")]
			get {
				const string __id = "getBackground.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDesiredAspectRatio;
#pragma warning disable 0169
		static Delegate GetGetDesiredAspectRatioHandler ()
		{
			if (cb_getDesiredAspectRatio == null)
				cb_getDesiredAspectRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDesiredAspectRatio);
			return cb_getDesiredAspectRatio;
		}

		static float n_GetDesiredAspectRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DesiredAspectRatio;
		}
#pragma warning restore 0169

		public virtual unsafe float DesiredAspectRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='getDesiredAspectRatio' and count(parameter)=0]"
			[Register ("getDesiredAspectRatio", "()F", "GetGetDesiredAspectRatioHandler")]
			get {
				const string __id = "getDesiredAspectRatio.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
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
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FadeDuration;
		}
#pragma warning restore 0169

		public virtual unsafe int FadeDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='getFadeDuration' and count(parameter)=0]"
			[Register ("getFadeDuration", "()I", "GetGetFadeDurationHandler")]
			get {
				const string __id = "getFadeDuration.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getFailureImage;
#pragma warning disable 0169
		static Delegate GetGetFailureImageHandler ()
		{
			if (cb_getFailureImage == null)
				cb_getFailureImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFailureImage);
			return cb_getFailureImage;
		}

		static IntPtr n_GetFailureImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FailureImage);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable FailureImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='getFailureImage' and count(parameter)=0]"
			[Register ("getFailureImage", "()Landroid/graphics/drawable/Drawable;", "GetGetFailureImageHandler")]
			get {
				const string __id = "getFailureImage.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFailureImageScaleType;
#pragma warning disable 0169
		static Delegate GetGetFailureImageScaleTypeHandler ()
		{
			if (cb_getFailureImageScaleType == null)
				cb_getFailureImageScaleType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFailureImageScaleType);
			return cb_getFailureImageScaleType;
		}

		static IntPtr n_GetFailureImageScaleType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FailureImageScaleType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType FailureImageScaleType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='getFailureImageScaleType' and count(parameter)=0]"
			[Register ("getFailureImageScaleType", "()Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;", "GetGetFailureImageScaleTypeHandler")]
			get {
				const string __id = "getFailureImageScaleType.()Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOverlays;
#pragma warning disable 0169
		static Delegate GetGetOverlaysHandler ()
		{
			if (cb_getOverlays == null)
				cb_getOverlays = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOverlays);
			return cb_getOverlays;
		}

		static IntPtr n_GetOverlays (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Graphics.Drawables.Drawable>.ToLocalJniHandle (__this.Overlays);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Graphics.Drawables.Drawable> Overlays {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='getOverlays' and count(parameter)=0]"
			[Register ("getOverlays", "()Ljava/util/List;", "GetGetOverlaysHandler")]
			get {
				const string __id = "getOverlays.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Android.Graphics.Drawables.Drawable>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPlaceholderImage;
#pragma warning disable 0169
		static Delegate GetGetPlaceholderImageHandler ()
		{
			if (cb_getPlaceholderImage == null)
				cb_getPlaceholderImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlaceholderImage);
			return cb_getPlaceholderImage;
		}

		static IntPtr n_GetPlaceholderImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PlaceholderImage);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable PlaceholderImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='getPlaceholderImage' and count(parameter)=0]"
			[Register ("getPlaceholderImage", "()Landroid/graphics/drawable/Drawable;", "GetGetPlaceholderImageHandler")]
			get {
				const string __id = "getPlaceholderImage.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPlaceholderImageScaleType;
#pragma warning disable 0169
		static Delegate GetGetPlaceholderImageScaleTypeHandler ()
		{
			if (cb_getPlaceholderImageScaleType == null)
				cb_getPlaceholderImageScaleType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlaceholderImageScaleType);
			return cb_getPlaceholderImageScaleType;
		}

		static IntPtr n_GetPlaceholderImageScaleType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PlaceholderImageScaleType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType PlaceholderImageScaleType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='getPlaceholderImageScaleType' and count(parameter)=0]"
			[Register ("getPlaceholderImageScaleType", "()Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;", "GetGetPlaceholderImageScaleTypeHandler")]
			get {
				const string __id = "getPlaceholderImageScaleType.()Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPressedStateOverlay;
#pragma warning disable 0169
		static Delegate GetGetPressedStateOverlayHandler ()
		{
			if (cb_getPressedStateOverlay == null)
				cb_getPressedStateOverlay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPressedStateOverlay);
			return cb_getPressedStateOverlay;
		}

		static IntPtr n_GetPressedStateOverlay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PressedStateOverlay);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable PressedStateOverlay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='getPressedStateOverlay' and count(parameter)=0]"
			[Register ("getPressedStateOverlay", "()Landroid/graphics/drawable/Drawable;", "GetGetPressedStateOverlayHandler")]
			get {
				const string __id = "getPressedStateOverlay.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProgressBarImage;
#pragma warning disable 0169
		static Delegate GetGetProgressBarImageHandler ()
		{
			if (cb_getProgressBarImage == null)
				cb_getProgressBarImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProgressBarImage);
			return cb_getProgressBarImage;
		}

		static IntPtr n_GetProgressBarImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProgressBarImage);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable ProgressBarImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='getProgressBarImage' and count(parameter)=0]"
			[Register ("getProgressBarImage", "()Landroid/graphics/drawable/Drawable;", "GetGetProgressBarImageHandler")]
			get {
				const string __id = "getProgressBarImage.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProgressBarImageScaleType;
#pragma warning disable 0169
		static Delegate GetGetProgressBarImageScaleTypeHandler ()
		{
			if (cb_getProgressBarImageScaleType == null)
				cb_getProgressBarImageScaleType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProgressBarImageScaleType);
			return cb_getProgressBarImageScaleType;
		}

		static IntPtr n_GetProgressBarImageScaleType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProgressBarImageScaleType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType ProgressBarImageScaleType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='getProgressBarImageScaleType' and count(parameter)=0]"
			[Register ("getProgressBarImageScaleType", "()Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;", "GetGetProgressBarImageScaleTypeHandler")]
			get {
				const string __id = "getProgressBarImageScaleType.()Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResources;
#pragma warning disable 0169
		static Delegate GetGetResourcesHandler ()
		{
			if (cb_getResources == null)
				cb_getResources = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResources);
			return cb_getResources;
		}

		static IntPtr n_GetResources (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Resources);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Res.Resources Resources {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='getResources' and count(parameter)=0]"
			[Register ("getResources", "()Landroid/content/res/Resources;", "GetGetResourcesHandler")]
			get {
				const string __id = "getResources.()Landroid/content/res/Resources;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRetryImage;
#pragma warning disable 0169
		static Delegate GetGetRetryImageHandler ()
		{
			if (cb_getRetryImage == null)
				cb_getRetryImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRetryImage);
			return cb_getRetryImage;
		}

		static IntPtr n_GetRetryImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RetryImage);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable RetryImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='getRetryImage' and count(parameter)=0]"
			[Register ("getRetryImage", "()Landroid/graphics/drawable/Drawable;", "GetGetRetryImageHandler")]
			get {
				const string __id = "getRetryImage.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRetryImageScaleType;
#pragma warning disable 0169
		static Delegate GetGetRetryImageScaleTypeHandler ()
		{
			if (cb_getRetryImageScaleType == null)
				cb_getRetryImageScaleType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRetryImageScaleType);
			return cb_getRetryImageScaleType;
		}

		static IntPtr n_GetRetryImageScaleType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RetryImageScaleType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType RetryImageScaleType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='getRetryImageScaleType' and count(parameter)=0]"
			[Register ("getRetryImageScaleType", "()Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;", "GetGetRetryImageScaleTypeHandler")]
			get {
				const string __id = "getRetryImageScaleType.()Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RoundingParams);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Drawee.Generic.RoundingParams RoundingParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='getRoundingParams' and count(parameter)=0]"
			[Register ("getRoundingParams", "()Lcom/facebook/drawee/generic/RoundingParams;", "GetGetRoundingParamsHandler")]
			get {
				const string __id = "getRoundingParams.()Lcom/facebook/drawee/generic/RoundingParams;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/facebook/drawee/generic/GenericDraweeHierarchy;", "GetBuildHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy Build ()
		{
			const string __id = "build.()Lcom/facebook/drawee/generic/GenericDraweeHierarchy;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='android.content.res.Resources']]"
		[Register ("newInstance", "(Landroid/content/res/Resources;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "")]
		public static unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder NewInstance (global::Android.Content.Res.Resources resources)
		{
			const string __id = "newInstance.(Landroid/content/res/Resources;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((resources == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resources).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static IntPtr n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Reset ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetResetHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder Reset ()
		{
			const string __id = "reset.()Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setActualImageColorFilter_Landroid_graphics_ColorFilter_;
#pragma warning disable 0169
		static Delegate GetSetActualImageColorFilter_Landroid_graphics_ColorFilter_Handler ()
		{
			if (cb_setActualImageColorFilter_Landroid_graphics_ColorFilter_ == null)
				cb_setActualImageColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetActualImageColorFilter_Landroid_graphics_ColorFilter_);
			return cb_setActualImageColorFilter_Landroid_graphics_ColorFilter_;
		}

		static IntPtr n_SetActualImageColorFilter_Landroid_graphics_ColorFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colorFilter)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.ColorFilter colorFilter = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_colorFilter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetActualImageColorFilter (colorFilter));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setActualImageColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
		[Register ("setActualImageColorFilter", "(Landroid/graphics/ColorFilter;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetActualImageColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetActualImageColorFilter (global::Android.Graphics.ColorFilter colorFilter)
		{
			const string __id = "setActualImageColorFilter.(Landroid/graphics/ColorFilter;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((colorFilter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) colorFilter).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setActualImageFocusPoint_Landroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetSetActualImageFocusPoint_Landroid_graphics_PointF_Handler ()
		{
			if (cb_setActualImageFocusPoint_Landroid_graphics_PointF_ == null)
				cb_setActualImageFocusPoint_Landroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetActualImageFocusPoint_Landroid_graphics_PointF_);
			return cb_setActualImageFocusPoint_Landroid_graphics_PointF_;
		}

		static IntPtr n_SetActualImageFocusPoint_Landroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_focusPoint)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF focusPoint = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (native_focusPoint, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetActualImageFocusPoint (focusPoint));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setActualImageFocusPoint' and count(parameter)=1 and parameter[1][@type='android.graphics.PointF']]"
		[Register ("setActualImageFocusPoint", "(Landroid/graphics/PointF;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetActualImageFocusPoint_Landroid_graphics_PointF_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetActualImageFocusPoint (global::Android.Graphics.PointF focusPoint)
		{
			const string __id = "setActualImageFocusPoint.(Landroid/graphics/PointF;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((focusPoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) focusPoint).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setActualImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetActualImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setActualImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setActualImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetActualImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setActualImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static IntPtr n_SetActualImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_actualImageScaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType actualImageScaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_actualImageScaleType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetActualImageScaleType (actualImageScaleType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setActualImageScaleType' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setActualImageScaleType", "(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetActualImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetActualImageScaleType (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType actualImageScaleType)
		{
			const string __id = "setActualImageScaleType.(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((actualImageScaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actualImageScaleType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setBackground_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetBackground_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setBackground_Landroid_graphics_drawable_Drawable_ == null)
				cb_setBackground_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetBackground_Landroid_graphics_drawable_Drawable_);
			return cb_setBackground_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_SetBackground_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_background)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable background = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_background, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBackground (background));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setBackground' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setBackground", "(Landroid/graphics/drawable/Drawable;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetBackground_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetBackground (global::Android.Graphics.Drawables.Drawable background)
		{
			const string __id = "setBackground.(Landroid/graphics/drawable/Drawable;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((background == null) ? IntPtr.Zero : ((global::Java.Lang.Object) background).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDesiredAspectRatio_F;
#pragma warning disable 0169
		static Delegate GetSetDesiredAspectRatio_FHandler ()
		{
			if (cb_setDesiredAspectRatio_F == null)
				cb_setDesiredAspectRatio_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetDesiredAspectRatio_F);
			return cb_setDesiredAspectRatio_F;
		}

		static IntPtr n_SetDesiredAspectRatio_F (IntPtr jnienv, IntPtr native__this, float desiredAspectRatio)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDesiredAspectRatio (desiredAspectRatio));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setDesiredAspectRatio' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setDesiredAspectRatio", "(F)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetDesiredAspectRatio_FHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetDesiredAspectRatio (float desiredAspectRatio)
		{
			const string __id = "setDesiredAspectRatio.(F)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (desiredAspectRatio);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFadeDuration_I;
#pragma warning disable 0169
		static Delegate GetSetFadeDuration_IHandler ()
		{
			if (cb_setFadeDuration_I == null)
				cb_setFadeDuration_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetFadeDuration_I);
			return cb_setFadeDuration_I;
		}

		static IntPtr n_SetFadeDuration_I (IntPtr jnienv, IntPtr native__this, int fadeDuration)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetFadeDuration (fadeDuration));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setFadeDuration' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFadeDuration", "(I)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetFadeDuration_IHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetFadeDuration (int fadeDuration)
		{
			const string __id = "setFadeDuration.(I)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (fadeDuration);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFailureImage_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetFailureImage_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setFailureImage_Landroid_graphics_drawable_Drawable_ == null)
				cb_setFailureImage_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFailureImage_Landroid_graphics_drawable_Drawable_);
			return cb_setFailureImage_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_SetFailureImage_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_failureDrawable)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable failureDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_failureDrawable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFailureImage (failureDrawable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setFailureImage' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setFailureImage", "(Landroid/graphics/drawable/Drawable;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetFailureImage_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetFailureImage (global::Android.Graphics.Drawables.Drawable failureDrawable)
		{
			const string __id = "setFailureImage.(Landroid/graphics/drawable/Drawable;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((failureDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) failureDrawable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFailureImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetFailureImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setFailureImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setFailureImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFailureImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setFailureImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static IntPtr n_SetFailureImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_failureDrawable, IntPtr native_failureImageScaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable failureDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_failureDrawable, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType failureImageScaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_failureImageScaleType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFailureImage (failureDrawable, failureImageScaleType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setFailureImage' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setFailureImage", "(Landroid/graphics/drawable/Drawable;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetFailureImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetFailureImage (global::Android.Graphics.Drawables.Drawable failureDrawable, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType failureImageScaleType)
		{
			const string __id = "setFailureImage.(Landroid/graphics/drawable/Drawable;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((failureDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) failureDrawable).Handle);
				__args [1] = new JniArgumentValue ((failureImageScaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) failureImageScaleType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFailureImage_I;
#pragma warning disable 0169
		static Delegate GetSetFailureImage_IHandler ()
		{
			if (cb_setFailureImage_I == null)
				cb_setFailureImage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetFailureImage_I);
			return cb_setFailureImage_I;
		}

		static IntPtr n_SetFailureImage_I (IntPtr jnienv, IntPtr native__this, int resourceId)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetFailureImage (resourceId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setFailureImage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFailureImage", "(I)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetFailureImage_IHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetFailureImage (int resourceId)
		{
			const string __id = "setFailureImage.(I)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resourceId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFailureImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetFailureImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setFailureImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setFailureImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetFailureImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setFailureImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static IntPtr n_SetFailureImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, int resourceId, IntPtr native_failureImageScaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType failureImageScaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_failureImageScaleType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFailureImage (resourceId, failureImageScaleType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setFailureImage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setFailureImage", "(ILcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetFailureImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetFailureImage (int resourceId, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType failureImageScaleType)
		{
			const string __id = "setFailureImage.(ILcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (resourceId);
				__args [1] = new JniArgumentValue ((failureImageScaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) failureImageScaleType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFailureImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetFailureImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setFailureImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setFailureImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFailureImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setFailureImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static IntPtr n_SetFailureImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_failureImageScaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType failureImageScaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_failureImageScaleType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFailureImageScaleType (failureImageScaleType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setFailureImageScaleType' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setFailureImageScaleType", "(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetFailureImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetFailureImageScaleType (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType failureImageScaleType)
		{
			const string __id = "setFailureImageScaleType.(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((failureImageScaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) failureImageScaleType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOverlay_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetOverlay_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setOverlay_Landroid_graphics_drawable_Drawable_ == null)
				cb_setOverlay_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOverlay_Landroid_graphics_drawable_Drawable_);
			return cb_setOverlay_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_SetOverlay_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_overlay)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable overlay = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_overlay, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOverlay (overlay));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setOverlay' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setOverlay", "(Landroid/graphics/drawable/Drawable;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetOverlay_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetOverlay (global::Android.Graphics.Drawables.Drawable overlay)
		{
			const string __id = "setOverlay.(Landroid/graphics/drawable/Drawable;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((overlay == null) ? IntPtr.Zero : ((global::Java.Lang.Object) overlay).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOverlays_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetOverlays_Ljava_util_List_Handler ()
		{
			if (cb_setOverlays_Ljava_util_List_ == null)
				cb_setOverlays_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOverlays_Ljava_util_List_);
			return cb_setOverlays_Ljava_util_List_;
		}

		static IntPtr n_SetOverlays_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_overlays)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var overlays = global::Android.Runtime.JavaList<global::Android.Graphics.Drawables.Drawable>.FromJniHandle (native_overlays, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOverlays (overlays));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setOverlays' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;android.graphics.drawable.Drawable&gt;']]"
		[Register ("setOverlays", "(Ljava/util/List;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetOverlays_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetOverlays (global::System.Collections.Generic.IList<global::Android.Graphics.Drawables.Drawable> overlays)
		{
			const string __id = "setOverlays.(Ljava/util/List;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			IntPtr native_overlays = global::Android.Runtime.JavaList<global::Android.Graphics.Drawables.Drawable>.ToLocalJniHandle (overlays);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_overlays);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_overlays);
			}
		}

		static Delegate cb_setPlaceholderImage_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetPlaceholderImage_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setPlaceholderImage_Landroid_graphics_drawable_Drawable_ == null)
				cb_setPlaceholderImage_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPlaceholderImage_Landroid_graphics_drawable_Drawable_);
			return cb_setPlaceholderImage_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_SetPlaceholderImage_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_placeholderDrawable)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable placeholderDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_placeholderDrawable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPlaceholderImage (placeholderDrawable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setPlaceholderImage' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setPlaceholderImage", "(Landroid/graphics/drawable/Drawable;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetPlaceholderImage_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetPlaceholderImage (global::Android.Graphics.Drawables.Drawable placeholderDrawable)
		{
			const string __id = "setPlaceholderImage.(Landroid/graphics/drawable/Drawable;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((placeholderDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) placeholderDrawable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPlaceholderImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetPlaceholderImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setPlaceholderImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setPlaceholderImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPlaceholderImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setPlaceholderImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static IntPtr n_SetPlaceholderImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_placeholderDrawable, IntPtr native_placeholderImageScaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable placeholderDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_placeholderDrawable, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType placeholderImageScaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_placeholderImageScaleType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPlaceholderImage (placeholderDrawable, placeholderImageScaleType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setPlaceholderImage' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setPlaceholderImage", "(Landroid/graphics/drawable/Drawable;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetPlaceholderImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetPlaceholderImage (global::Android.Graphics.Drawables.Drawable placeholderDrawable, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType placeholderImageScaleType)
		{
			const string __id = "setPlaceholderImage.(Landroid/graphics/drawable/Drawable;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((placeholderDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) placeholderDrawable).Handle);
				__args [1] = new JniArgumentValue ((placeholderImageScaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) placeholderImageScaleType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPlaceholderImage_I;
#pragma warning disable 0169
		static Delegate GetSetPlaceholderImage_IHandler ()
		{
			if (cb_setPlaceholderImage_I == null)
				cb_setPlaceholderImage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetPlaceholderImage_I);
			return cb_setPlaceholderImage_I;
		}

		static IntPtr n_SetPlaceholderImage_I (IntPtr jnienv, IntPtr native__this, int resourceId)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetPlaceholderImage (resourceId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setPlaceholderImage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPlaceholderImage", "(I)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetPlaceholderImage_IHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetPlaceholderImage (int resourceId)
		{
			const string __id = "setPlaceholderImage.(I)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resourceId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPlaceholderImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetPlaceholderImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setPlaceholderImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setPlaceholderImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetPlaceholderImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setPlaceholderImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static IntPtr n_SetPlaceholderImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, int resourceId, IntPtr native_placeholderImageScaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType placeholderImageScaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_placeholderImageScaleType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPlaceholderImage (resourceId, placeholderImageScaleType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setPlaceholderImage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setPlaceholderImage", "(ILcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetPlaceholderImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetPlaceholderImage (int resourceId, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType placeholderImageScaleType)
		{
			const string __id = "setPlaceholderImage.(ILcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (resourceId);
				__args [1] = new JniArgumentValue ((placeholderImageScaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) placeholderImageScaleType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPlaceholderImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetPlaceholderImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setPlaceholderImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setPlaceholderImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPlaceholderImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setPlaceholderImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static IntPtr n_SetPlaceholderImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_placeholderImageScaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType placeholderImageScaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_placeholderImageScaleType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPlaceholderImageScaleType (placeholderImageScaleType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setPlaceholderImageScaleType' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setPlaceholderImageScaleType", "(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetPlaceholderImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetPlaceholderImageScaleType (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType placeholderImageScaleType)
		{
			const string __id = "setPlaceholderImageScaleType.(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((placeholderImageScaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) placeholderImageScaleType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPressedStateOverlay_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetPressedStateOverlay_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setPressedStateOverlay_Landroid_graphics_drawable_Drawable_ == null)
				cb_setPressedStateOverlay_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPressedStateOverlay_Landroid_graphics_drawable_Drawable_);
			return cb_setPressedStateOverlay_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_SetPressedStateOverlay_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPressedStateOverlay (drawable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setPressedStateOverlay' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setPressedStateOverlay", "(Landroid/graphics/drawable/Drawable;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetPressedStateOverlay_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetPressedStateOverlay (global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "setPressedStateOverlay.(Landroid/graphics/drawable/Drawable;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setProgressBarImage_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetProgressBarImage_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setProgressBarImage_Landroid_graphics_drawable_Drawable_ == null)
				cb_setProgressBarImage_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetProgressBarImage_Landroid_graphics_drawable_Drawable_);
			return cb_setProgressBarImage_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_SetProgressBarImage_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_progressBarDrawable)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable progressBarDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_progressBarDrawable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProgressBarImage (progressBarDrawable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setProgressBarImage' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setProgressBarImage", "(Landroid/graphics/drawable/Drawable;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetProgressBarImage_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetProgressBarImage (global::Android.Graphics.Drawables.Drawable progressBarDrawable)
		{
			const string __id = "setProgressBarImage.(Landroid/graphics/drawable/Drawable;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((progressBarDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) progressBarDrawable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setProgressBarImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetProgressBarImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setProgressBarImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setProgressBarImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetProgressBarImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setProgressBarImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static IntPtr n_SetProgressBarImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_progressBarDrawable, IntPtr native_progressBarImageScaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable progressBarDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_progressBarDrawable, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType progressBarImageScaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_progressBarImageScaleType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProgressBarImage (progressBarDrawable, progressBarImageScaleType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setProgressBarImage' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setProgressBarImage", "(Landroid/graphics/drawable/Drawable;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetProgressBarImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetProgressBarImage (global::Android.Graphics.Drawables.Drawable progressBarDrawable, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType progressBarImageScaleType)
		{
			const string __id = "setProgressBarImage.(Landroid/graphics/drawable/Drawable;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((progressBarDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) progressBarDrawable).Handle);
				__args [1] = new JniArgumentValue ((progressBarImageScaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) progressBarImageScaleType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setProgressBarImage_I;
#pragma warning disable 0169
		static Delegate GetSetProgressBarImage_IHandler ()
		{
			if (cb_setProgressBarImage_I == null)
				cb_setProgressBarImage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetProgressBarImage_I);
			return cb_setProgressBarImage_I;
		}

		static IntPtr n_SetProgressBarImage_I (IntPtr jnienv, IntPtr native__this, int resourceId)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetProgressBarImage (resourceId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setProgressBarImage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setProgressBarImage", "(I)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetProgressBarImage_IHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetProgressBarImage (int resourceId)
		{
			const string __id = "setProgressBarImage.(I)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resourceId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setProgressBarImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetProgressBarImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setProgressBarImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setProgressBarImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetProgressBarImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setProgressBarImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static IntPtr n_SetProgressBarImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, int resourceId, IntPtr native_progressBarImageScaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType progressBarImageScaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_progressBarImageScaleType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProgressBarImage (resourceId, progressBarImageScaleType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setProgressBarImage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setProgressBarImage", "(ILcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetProgressBarImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetProgressBarImage (int resourceId, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType progressBarImageScaleType)
		{
			const string __id = "setProgressBarImage.(ILcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (resourceId);
				__args [1] = new JniArgumentValue ((progressBarImageScaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) progressBarImageScaleType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setProgressBarImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetProgressBarImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setProgressBarImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setProgressBarImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetProgressBarImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setProgressBarImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static IntPtr n_SetProgressBarImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_progressBarImageScaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType progressBarImageScaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_progressBarImageScaleType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProgressBarImageScaleType (progressBarImageScaleType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setProgressBarImageScaleType' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setProgressBarImageScaleType", "(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetProgressBarImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetProgressBarImageScaleType (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType progressBarImageScaleType)
		{
			const string __id = "setProgressBarImageScaleType.(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((progressBarImageScaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) progressBarImageScaleType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRetryImage_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetRetryImage_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setRetryImage_Landroid_graphics_drawable_Drawable_ == null)
				cb_setRetryImage_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRetryImage_Landroid_graphics_drawable_Drawable_);
			return cb_setRetryImage_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_SetRetryImage_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_retryDrawable)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable retryDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_retryDrawable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRetryImage (retryDrawable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setRetryImage' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setRetryImage", "(Landroid/graphics/drawable/Drawable;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetRetryImage_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetRetryImage (global::Android.Graphics.Drawables.Drawable retryDrawable)
		{
			const string __id = "setRetryImage.(Landroid/graphics/drawable/Drawable;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((retryDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) retryDrawable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRetryImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetRetryImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setRetryImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setRetryImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRetryImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setRetryImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static IntPtr n_SetRetryImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_retryDrawable, IntPtr native_retryImageScaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable retryDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_retryDrawable, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType retryImageScaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_retryImageScaleType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRetryImage (retryDrawable, retryImageScaleType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setRetryImage' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setRetryImage", "(Landroid/graphics/drawable/Drawable;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetRetryImage_Landroid_graphics_drawable_Drawable_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetRetryImage (global::Android.Graphics.Drawables.Drawable retryDrawable, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType retryImageScaleType)
		{
			const string __id = "setRetryImage.(Landroid/graphics/drawable/Drawable;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((retryDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) retryDrawable).Handle);
				__args [1] = new JniArgumentValue ((retryImageScaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) retryImageScaleType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRetryImage_I;
#pragma warning disable 0169
		static Delegate GetSetRetryImage_IHandler ()
		{
			if (cb_setRetryImage_I == null)
				cb_setRetryImage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetRetryImage_I);
			return cb_setRetryImage_I;
		}

		static IntPtr n_SetRetryImage_I (IntPtr jnienv, IntPtr native__this, int resourceId)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetRetryImage (resourceId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setRetryImage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRetryImage", "(I)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetRetryImage_IHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetRetryImage (int resourceId)
		{
			const string __id = "setRetryImage.(I)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resourceId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRetryImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetRetryImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setRetryImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setRetryImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetRetryImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setRetryImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static IntPtr n_SetRetryImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, int resourceId, IntPtr native_retryImageScaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType retryImageScaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_retryImageScaleType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRetryImage (resourceId, retryImageScaleType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setRetryImage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setRetryImage", "(ILcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetRetryImage_ILcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetRetryImage (int resourceId, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType retryImageScaleType)
		{
			const string __id = "setRetryImage.(ILcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (resourceId);
				__args [1] = new JniArgumentValue ((retryImageScaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) retryImageScaleType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRetryImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetRetryImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setRetryImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setRetryImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRetryImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setRetryImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static IntPtr n_SetRetryImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_retryImageScaleType)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType retryImageScaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_retryImageScaleType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRetryImageScaleType (retryImageScaleType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setRetryImageScaleType' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("setRetryImageScaleType", "(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetRetryImageScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetRetryImageScaleType (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType retryImageScaleType)
		{
			const string __id = "setRetryImageScaleType.(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((retryImageScaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) retryImageScaleType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRoundingParams_Lcom_facebook_drawee_generic_RoundingParams_;
#pragma warning disable 0169
		static Delegate GetSetRoundingParams_Lcom_facebook_drawee_generic_RoundingParams_Handler ()
		{
			if (cb_setRoundingParams_Lcom_facebook_drawee_generic_RoundingParams_ == null)
				cb_setRoundingParams_Lcom_facebook_drawee_generic_RoundingParams_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRoundingParams_Lcom_facebook_drawee_generic_RoundingParams_);
			return cb_setRoundingParams_Lcom_facebook_drawee_generic_RoundingParams_;
		}

		static IntPtr n_SetRoundingParams_Lcom_facebook_drawee_generic_RoundingParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_roundingParams)
		{
			global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Generic.RoundingParams roundingParams = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (native_roundingParams, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRoundingParams (roundingParams));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyBuilder']/method[@name='setRoundingParams' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.generic.RoundingParams']]"
		[Register ("setRoundingParams", "(Lcom/facebook/drawee/generic/RoundingParams;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "GetSetRoundingParams_Lcom_facebook_drawee_generic_RoundingParams_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder SetRoundingParams (global::Com.Facebook.Drawee.Generic.RoundingParams roundingParams)
		{
			const string __id = "setRoundingParams.(Lcom/facebook/drawee/generic/RoundingParams;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((roundingParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) roundingParams).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
