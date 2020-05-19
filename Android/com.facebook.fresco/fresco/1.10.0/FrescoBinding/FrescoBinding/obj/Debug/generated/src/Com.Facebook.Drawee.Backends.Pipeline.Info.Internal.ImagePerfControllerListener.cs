using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline.Info.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info.internal']/class[@name='ImagePerfControllerListener']"
	[global::Android.Runtime.Register ("com/facebook/drawee/backends/pipeline/info/internal/ImagePerfControllerListener", DoNotGenerateAcw=true)]
	public partial class ImagePerfControllerListener : global::Com.Facebook.Drawee.Controller.BaseControllerListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/backends/pipeline/info/internal/ImagePerfControllerListener", typeof (ImagePerfControllerListener));
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

		protected ImagePerfControllerListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info.internal']/class[@name='ImagePerfControllerListener']/constructor[@name='ImagePerfControllerListener' and count(parameter)=3 and parameter[1][@type='com.facebook.common.time.MonotonicClock'] and parameter[2][@type='com.facebook.drawee.backends.pipeline.info.ImagePerfState'] and parameter[3][@type='com.facebook.drawee.backends.pipeline.info.ImagePerfMonitor']]"
		[Register (".ctor", "(Lcom/facebook/common/time/MonotonicClock;Lcom/facebook/drawee/backends/pipeline/info/ImagePerfState;Lcom/facebook/drawee/backends/pipeline/info/ImagePerfMonitor;)V", "")]
		public unsafe ImagePerfControllerListener (global::Com.Facebook.Common.Time.IMonotonicClock clock, global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState imagePerfState, global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfMonitor imagePerfMonitor)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/facebook/common/time/MonotonicClock;Lcom/facebook/drawee/backends/pipeline/info/ImagePerfState;Lcom/facebook/drawee/backends/pipeline/info/ImagePerfMonitor;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clock == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clock).Handle);
				__args [1] = new JniArgumentValue ((imagePerfState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imagePerfState).Handle);
				__args [2] = new JniArgumentValue ((imagePerfMonitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imagePerfMonitor).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onFinalImageSet_Ljava_lang_String_Lcom_facebook_imagepipeline_image_ImageInfo_Landroid_graphics_drawable_Animatable_;
#pragma warning disable 0169
		static Delegate GetOnFinalImageSet_Ljava_lang_String_Lcom_facebook_imagepipeline_image_ImageInfo_Landroid_graphics_drawable_Animatable_Handler ()
		{
			if (cb_onFinalImageSet_Ljava_lang_String_Lcom_facebook_imagepipeline_image_ImageInfo_Landroid_graphics_drawable_Animatable_ == null)
				cb_onFinalImageSet_Ljava_lang_String_Lcom_facebook_imagepipeline_image_ImageInfo_Landroid_graphics_drawable_Animatable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFinalImageSet_Ljava_lang_String_Lcom_facebook_imagepipeline_image_ImageInfo_Landroid_graphics_drawable_Animatable_);
			return cb_onFinalImageSet_Ljava_lang_String_Lcom_facebook_imagepipeline_image_ImageInfo_Landroid_graphics_drawable_Animatable_;
		}

		static void n_OnFinalImageSet_Ljava_lang_String_Lcom_facebook_imagepipeline_image_ImageInfo_Landroid_graphics_drawable_Animatable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_imageInfo, IntPtr native_animatable)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.Internal.ImagePerfControllerListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.Internal.ImagePerfControllerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Image.IImageInfo imageInfo = (global::Com.Facebook.Imagepipeline.Image.IImageInfo)global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.IImageInfo> (native_imageInfo, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.IAnimatable animatable = (global::Android.Graphics.Drawables.IAnimatable)global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.IAnimatable> (native_animatable, JniHandleOwnership.DoNotTransfer);
			__this.OnFinalImageSet (id, imageInfo, animatable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info.internal']/class[@name='ImagePerfControllerListener']/method[@name='onFinalImageSet' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.facebook.imagepipeline.image.ImageInfo'] and parameter[3][@type='android.graphics.drawable.Animatable']]"
		[Register ("onFinalImageSet", "(Ljava/lang/String;Lcom/facebook/imagepipeline/image/ImageInfo;Landroid/graphics/drawable/Animatable;)V", "GetOnFinalImageSet_Ljava_lang_String_Lcom_facebook_imagepipeline_image_ImageInfo_Landroid_graphics_drawable_Animatable_Handler")]
		public virtual unsafe void OnFinalImageSet (string id, global::Com.Facebook.Imagepipeline.Image.IImageInfo imageInfo, global::Android.Graphics.Drawables.IAnimatable animatable)
		{
			const string __id = "onFinalImageSet.(Ljava/lang/String;Lcom/facebook/imagepipeline/image/ImageInfo;Landroid/graphics/drawable/Animatable;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((imageInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageInfo).Handle);
				__args [2] = new JniArgumentValue ((animatable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animatable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		static Delegate cb_onIntermediateImageSet_Ljava_lang_String_Lcom_facebook_imagepipeline_image_ImageInfo_;
#pragma warning disable 0169
		static Delegate GetOnIntermediateImageSet_Ljava_lang_String_Lcom_facebook_imagepipeline_image_ImageInfo_Handler ()
		{
			if (cb_onIntermediateImageSet_Ljava_lang_String_Lcom_facebook_imagepipeline_image_ImageInfo_ == null)
				cb_onIntermediateImageSet_Ljava_lang_String_Lcom_facebook_imagepipeline_image_ImageInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnIntermediateImageSet_Ljava_lang_String_Lcom_facebook_imagepipeline_image_ImageInfo_);
			return cb_onIntermediateImageSet_Ljava_lang_String_Lcom_facebook_imagepipeline_image_ImageInfo_;
		}

		static void n_OnIntermediateImageSet_Ljava_lang_String_Lcom_facebook_imagepipeline_image_ImageInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_imageInfo)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.Internal.ImagePerfControllerListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.Internal.ImagePerfControllerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Image.IImageInfo imageInfo = (global::Com.Facebook.Imagepipeline.Image.IImageInfo)global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.IImageInfo> (native_imageInfo, JniHandleOwnership.DoNotTransfer);
			__this.OnIntermediateImageSet (id, imageInfo);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info.internal']/class[@name='ImagePerfControllerListener']/method[@name='onIntermediateImageSet' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.facebook.imagepipeline.image.ImageInfo']]"
		[Register ("onIntermediateImageSet", "(Ljava/lang/String;Lcom/facebook/imagepipeline/image/ImageInfo;)V", "GetOnIntermediateImageSet_Ljava_lang_String_Lcom_facebook_imagepipeline_image_ImageInfo_Handler")]
		public virtual unsafe void OnIntermediateImageSet (string id, global::Com.Facebook.Imagepipeline.Image.IImageInfo imageInfo)
		{
			const string __id = "onIntermediateImageSet.(Ljava/lang/String;Lcom/facebook/imagepipeline/image/ImageInfo;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((imageInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageInfo).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

	}
}
