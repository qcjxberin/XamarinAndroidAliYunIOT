using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline.Info {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']"
	[global::Android.Runtime.Register ("com/facebook/drawee/backends/pipeline/info/ImagePerfState", DoNotGenerateAcw=true)]
	public partial class ImagePerfState : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/backends/pipeline/info/ImagePerfState", typeof (ImagePerfState));
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

		protected ImagePerfState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/constructor[@name='ImagePerfState' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImagePerfState ()
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

		static Delegate cb_getImageLoadStatus;
#pragma warning disable 0169
		static Delegate GetGetImageLoadStatusHandler ()
		{
			if (cb_getImageLoadStatus == null)
				cb_getImageLoadStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetImageLoadStatus);
			return cb_getImageLoadStatus;
		}

		static int n_GetImageLoadStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageLoadStatus;
		}
#pragma warning restore 0169

		static Delegate cb_setImageLoadStatus_I;
#pragma warning disable 0169
		static Delegate GetSetImageLoadStatus_IHandler ()
		{
			if (cb_setImageLoadStatus_I == null)
				cb_setImageLoadStatus_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetImageLoadStatus_I);
			return cb_setImageLoadStatus_I;
		}

		static void n_SetImageLoadStatus_I (IntPtr jnienv, IntPtr native__this, int imageLoadStatus)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ImageLoadStatus = imageLoadStatus;
		}
#pragma warning restore 0169

		public virtual unsafe int ImageLoadStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/method[@name='getImageLoadStatus' and count(parameter)=0]"
			[Register ("getImageLoadStatus", "()I", "GetGetImageLoadStatusHandler")]
			get {
				const string __id = "getImageLoadStatus.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/method[@name='setImageLoadStatus' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setImageLoadStatus", "(I)V", "GetSetImageLoadStatus_IHandler")]
			set {
				const string __id = "setImageLoadStatus.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setCallerContext_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetCallerContext_Ljava_lang_Object_Handler ()
		{
			if (cb_setCallerContext_Ljava_lang_Object_ == null)
				cb_setCallerContext_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallerContext_Ljava_lang_Object_);
			return cb_setCallerContext_Ljava_lang_Object_;
		}

		static void n_SetCallerContext_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_callerContext)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object callerContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_callerContext, JniHandleOwnership.DoNotTransfer);
			__this.SetCallerContext (callerContext);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/method[@name='setCallerContext' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("setCallerContext", "(Ljava/lang/Object;)V", "GetSetCallerContext_Ljava_lang_Object_Handler")]
		public virtual unsafe void SetCallerContext (global::Java.Lang.Object callerContext)
		{
			const string __id = "setCallerContext.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((callerContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callerContext).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCanceled_Z;
#pragma warning disable 0169
		static Delegate GetSetCanceled_ZHandler ()
		{
			if (cb_setCanceled_Z == null)
				cb_setCanceled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCanceled_Z);
			return cb_setCanceled_Z;
		}

		static void n_SetCanceled_Z (IntPtr jnienv, IntPtr native__this, bool canceled)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCanceled (canceled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/method[@name='setCanceled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCanceled", "(Z)V", "GetSetCanceled_ZHandler")]
		public virtual unsafe void SetCanceled (bool canceled)
		{
			const string __id = "setCanceled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (canceled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setControllerCancelTimeMs_J;
#pragma warning disable 0169
		static Delegate GetSetControllerCancelTimeMs_JHandler ()
		{
			if (cb_setControllerCancelTimeMs_J == null)
				cb_setControllerCancelTimeMs_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetControllerCancelTimeMs_J);
			return cb_setControllerCancelTimeMs_J;
		}

		static void n_SetControllerCancelTimeMs_J (IntPtr jnienv, IntPtr native__this, long controllerCancelTimeMs)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetControllerCancelTimeMs (controllerCancelTimeMs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/method[@name='setControllerCancelTimeMs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setControllerCancelTimeMs", "(J)V", "GetSetControllerCancelTimeMs_JHandler")]
		public virtual unsafe void SetControllerCancelTimeMs (long controllerCancelTimeMs)
		{
			const string __id = "setControllerCancelTimeMs.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (controllerCancelTimeMs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setControllerFailureTimeMs_J;
#pragma warning disable 0169
		static Delegate GetSetControllerFailureTimeMs_JHandler ()
		{
			if (cb_setControllerFailureTimeMs_J == null)
				cb_setControllerFailureTimeMs_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetControllerFailureTimeMs_J);
			return cb_setControllerFailureTimeMs_J;
		}

		static void n_SetControllerFailureTimeMs_J (IntPtr jnienv, IntPtr native__this, long controllerFailureTimeMs)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetControllerFailureTimeMs (controllerFailureTimeMs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/method[@name='setControllerFailureTimeMs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setControllerFailureTimeMs", "(J)V", "GetSetControllerFailureTimeMs_JHandler")]
		public virtual unsafe void SetControllerFailureTimeMs (long controllerFailureTimeMs)
		{
			const string __id = "setControllerFailureTimeMs.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (controllerFailureTimeMs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setControllerFinalImageSetTimeMs_J;
#pragma warning disable 0169
		static Delegate GetSetControllerFinalImageSetTimeMs_JHandler ()
		{
			if (cb_setControllerFinalImageSetTimeMs_J == null)
				cb_setControllerFinalImageSetTimeMs_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetControllerFinalImageSetTimeMs_J);
			return cb_setControllerFinalImageSetTimeMs_J;
		}

		static void n_SetControllerFinalImageSetTimeMs_J (IntPtr jnienv, IntPtr native__this, long controllerFinalImageSetTimeMs)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetControllerFinalImageSetTimeMs (controllerFinalImageSetTimeMs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/method[@name='setControllerFinalImageSetTimeMs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setControllerFinalImageSetTimeMs", "(J)V", "GetSetControllerFinalImageSetTimeMs_JHandler")]
		public virtual unsafe void SetControllerFinalImageSetTimeMs (long controllerFinalImageSetTimeMs)
		{
			const string __id = "setControllerFinalImageSetTimeMs.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (controllerFinalImageSetTimeMs);
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
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string controllerId = JNIEnv.GetString (native_controllerId, JniHandleOwnership.DoNotTransfer);
			__this.SetControllerId (controllerId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/method[@name='setControllerId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_setControllerIntermediateImageSetTimeMs_J;
#pragma warning disable 0169
		static Delegate GetSetControllerIntermediateImageSetTimeMs_JHandler ()
		{
			if (cb_setControllerIntermediateImageSetTimeMs_J == null)
				cb_setControllerIntermediateImageSetTimeMs_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetControllerIntermediateImageSetTimeMs_J);
			return cb_setControllerIntermediateImageSetTimeMs_J;
		}

		static void n_SetControllerIntermediateImageSetTimeMs_J (IntPtr jnienv, IntPtr native__this, long controllerIntermediateImageSetTimeMs)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetControllerIntermediateImageSetTimeMs (controllerIntermediateImageSetTimeMs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/method[@name='setControllerIntermediateImageSetTimeMs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setControllerIntermediateImageSetTimeMs", "(J)V", "GetSetControllerIntermediateImageSetTimeMs_JHandler")]
		public virtual unsafe void SetControllerIntermediateImageSetTimeMs (long controllerIntermediateImageSetTimeMs)
		{
			const string __id = "setControllerIntermediateImageSetTimeMs.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (controllerIntermediateImageSetTimeMs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setControllerSubmitTimeMs_J;
#pragma warning disable 0169
		static Delegate GetSetControllerSubmitTimeMs_JHandler ()
		{
			if (cb_setControllerSubmitTimeMs_J == null)
				cb_setControllerSubmitTimeMs_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetControllerSubmitTimeMs_J);
			return cb_setControllerSubmitTimeMs_J;
		}

		static void n_SetControllerSubmitTimeMs_J (IntPtr jnienv, IntPtr native__this, long controllerSubmitTimeMs)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetControllerSubmitTimeMs (controllerSubmitTimeMs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/method[@name='setControllerSubmitTimeMs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setControllerSubmitTimeMs", "(J)V", "GetSetControllerSubmitTimeMs_JHandler")]
		public virtual unsafe void SetControllerSubmitTimeMs (long controllerSubmitTimeMs)
		{
			const string __id = "setControllerSubmitTimeMs.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (controllerSubmitTimeMs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setImageInfo_Lcom_facebook_imagepipeline_image_ImageInfo_;
#pragma warning disable 0169
		static Delegate GetSetImageInfo_Lcom_facebook_imagepipeline_image_ImageInfo_Handler ()
		{
			if (cb_setImageInfo_Lcom_facebook_imagepipeline_image_ImageInfo_ == null)
				cb_setImageInfo_Lcom_facebook_imagepipeline_image_ImageInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageInfo_Lcom_facebook_imagepipeline_image_ImageInfo_);
			return cb_setImageInfo_Lcom_facebook_imagepipeline_image_ImageInfo_;
		}

		static void n_SetImageInfo_Lcom_facebook_imagepipeline_image_ImageInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageInfo)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Image.IImageInfo imageInfo = (global::Com.Facebook.Imagepipeline.Image.IImageInfo)global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.IImageInfo> (native_imageInfo, JniHandleOwnership.DoNotTransfer);
			__this.SetImageInfo (imageInfo);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/method[@name='setImageInfo' and count(parameter)=1 and parameter[1][@type='com.facebook.imagepipeline.image.ImageInfo']]"
		[Register ("setImageInfo", "(Lcom/facebook/imagepipeline/image/ImageInfo;)V", "GetSetImageInfo_Lcom_facebook_imagepipeline_image_ImageInfo_Handler")]
		public virtual unsafe void SetImageInfo (global::Com.Facebook.Imagepipeline.Image.IImageInfo imageInfo)
		{
			const string __id = "setImageInfo.(Lcom/facebook/imagepipeline/image/ImageInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((imageInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageInfo).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setImageOrigin_I;
#pragma warning disable 0169
		static Delegate GetSetImageOrigin_IHandler ()
		{
			if (cb_setImageOrigin_I == null)
				cb_setImageOrigin_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetImageOrigin_I);
			return cb_setImageOrigin_I;
		}

		static void n_SetImageOrigin_I (IntPtr jnienv, IntPtr native__this, int imageOrigin)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetImageOrigin (imageOrigin);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/method[@name='setImageOrigin' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setImageOrigin", "(I)V", "GetSetImageOrigin_IHandler")]
		public virtual unsafe void SetImageOrigin ([global::Android.Runtime.IntDef (Type = "Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOrigin", Fields = new string [] {"Unknown", "Network", "Disk", "MemoryEncoded", "MemoryBitmap"})]int imageOrigin)
		{
			const string __id = "setImageOrigin.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (imageOrigin);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setImageRequest_Lcom_facebook_imagepipeline_request_ImageRequest_;
#pragma warning disable 0169
		static Delegate GetSetImageRequest_Lcom_facebook_imagepipeline_request_ImageRequest_Handler ()
		{
			if (cb_setImageRequest_Lcom_facebook_imagepipeline_request_ImageRequest_ == null)
				cb_setImageRequest_Lcom_facebook_imagepipeline_request_ImageRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageRequest_Lcom_facebook_imagepipeline_request_ImageRequest_);
			return cb_setImageRequest_Lcom_facebook_imagepipeline_request_ImageRequest_;
		}

		static void n_SetImageRequest_Lcom_facebook_imagepipeline_request_ImageRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageRequest)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Request.ImageRequest imageRequest = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Request.ImageRequest> (native_imageRequest, JniHandleOwnership.DoNotTransfer);
			__this.SetImageRequest (imageRequest);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/method[@name='setImageRequest' and count(parameter)=1 and parameter[1][@type='com.facebook.imagepipeline.request.ImageRequest']]"
		[Register ("setImageRequest", "(Lcom/facebook/imagepipeline/request/ImageRequest;)V", "GetSetImageRequest_Lcom_facebook_imagepipeline_request_ImageRequest_Handler")]
		public virtual unsafe void SetImageRequest (global::Com.Facebook.Imagepipeline.Request.ImageRequest imageRequest)
		{
			const string __id = "setImageRequest.(Lcom/facebook/imagepipeline/request/ImageRequest;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((imageRequest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageRequest).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setImageRequestEndTimeMs_J;
#pragma warning disable 0169
		static Delegate GetSetImageRequestEndTimeMs_JHandler ()
		{
			if (cb_setImageRequestEndTimeMs_J == null)
				cb_setImageRequestEndTimeMs_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetImageRequestEndTimeMs_J);
			return cb_setImageRequestEndTimeMs_J;
		}

		static void n_SetImageRequestEndTimeMs_J (IntPtr jnienv, IntPtr native__this, long imageRequestEndTimeMs)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetImageRequestEndTimeMs (imageRequestEndTimeMs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/method[@name='setImageRequestEndTimeMs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setImageRequestEndTimeMs", "(J)V", "GetSetImageRequestEndTimeMs_JHandler")]
		public virtual unsafe void SetImageRequestEndTimeMs (long imageRequestEndTimeMs)
		{
			const string __id = "setImageRequestEndTimeMs.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (imageRequestEndTimeMs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setImageRequestStartTimeMs_J;
#pragma warning disable 0169
		static Delegate GetSetImageRequestStartTimeMs_JHandler ()
		{
			if (cb_setImageRequestStartTimeMs_J == null)
				cb_setImageRequestStartTimeMs_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetImageRequestStartTimeMs_J);
			return cb_setImageRequestStartTimeMs_J;
		}

		static void n_SetImageRequestStartTimeMs_J (IntPtr jnienv, IntPtr native__this, long imageRequestStartTimeMs)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetImageRequestStartTimeMs (imageRequestStartTimeMs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/method[@name='setImageRequestStartTimeMs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setImageRequestStartTimeMs", "(J)V", "GetSetImageRequestStartTimeMs_JHandler")]
		public virtual unsafe void SetImageRequestStartTimeMs (long imageRequestStartTimeMs)
		{
			const string __id = "setImageRequestStartTimeMs.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (imageRequestStartTimeMs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPrefetch_Z;
#pragma warning disable 0169
		static Delegate GetSetPrefetch_ZHandler ()
		{
			if (cb_setPrefetch_Z == null)
				cb_setPrefetch_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPrefetch_Z);
			return cb_setPrefetch_Z;
		}

		static void n_SetPrefetch_Z (IntPtr jnienv, IntPtr native__this, bool prefetch)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPrefetch (prefetch);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/method[@name='setPrefetch' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPrefetch", "(Z)V", "GetSetPrefetch_ZHandler")]
		public virtual unsafe void SetPrefetch (bool prefetch)
		{
			const string __id = "setPrefetch.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (prefetch);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRequestId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRequestId_Ljava_lang_String_Handler ()
		{
			if (cb_setRequestId_Ljava_lang_String_ == null)
				cb_setRequestId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRequestId_Ljava_lang_String_);
			return cb_setRequestId_Ljava_lang_String_;
		}

		static void n_SetRequestId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestId)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string requestId = JNIEnv.GetString (native_requestId, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestId (requestId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/method[@name='setRequestId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setRequestId", "(Ljava/lang/String;)V", "GetSetRequestId_Ljava_lang_String_Handler")]
		public virtual unsafe void SetRequestId (string requestId)
		{
			const string __id = "setRequestId.(Ljava/lang/String;)V";
			IntPtr native_requestId = JNIEnv.NewString (requestId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_requestId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestId);
			}
		}

		static Delegate cb_setSuccessful_Z;
#pragma warning disable 0169
		static Delegate GetSetSuccessful_ZHandler ()
		{
			if (cb_setSuccessful_Z == null)
				cb_setSuccessful_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSuccessful_Z);
			return cb_setSuccessful_Z;
		}

		static void n_SetSuccessful_Z (IntPtr jnienv, IntPtr native__this, bool successful)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSuccessful (successful);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/method[@name='setSuccessful' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSuccessful", "(Z)V", "GetSetSuccessful_ZHandler")]
		public virtual unsafe void SetSuccessful (bool successful)
		{
			const string __id = "setSuccessful.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (successful);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_snapshot;
#pragma warning disable 0169
		static Delegate GetSnapshotHandler ()
		{
			if (cb_snapshot == null)
				cb_snapshot = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Snapshot);
			return cb_snapshot;
		}

		static IntPtr n_Snapshot (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Snapshot ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfState']/method[@name='snapshot' and count(parameter)=0]"
		[Register ("snapshot", "()Lcom/facebook/drawee/backends/pipeline/info/ImagePerfData;", "GetSnapshotHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData Snapshot ()
		{
			const string __id = "snapshot.()Lcom/facebook/drawee/backends/pipeline/info/ImagePerfData;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
