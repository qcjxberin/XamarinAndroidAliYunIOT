using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline.Info {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfData']"
	[global::Android.Runtime.Register ("com/facebook/drawee/backends/pipeline/info/ImagePerfData", DoNotGenerateAcw=true)]
	public partial class ImagePerfData : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfData']/field[@name='UNSET']"
		[Register ("UNSET")]
		public const int Unset = (int) -1;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/backends/pipeline/info/ImagePerfData", typeof (ImagePerfData));
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

		protected ImagePerfData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCallerContext;
#pragma warning disable 0169
		static Delegate GetGetCallerContextHandler ()
		{
			if (cb_getCallerContext == null)
				cb_getCallerContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallerContext);
			return cb_getCallerContext;
		}

		static IntPtr n_GetCallerContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CallerContext);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object CallerContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfData']/method[@name='getCallerContext' and count(parameter)=0]"
			[Register ("getCallerContext", "()Ljava/lang/Object;", "GetGetCallerContextHandler")]
			get {
				const string __id = "getCallerContext.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getControllerFailureTimeMs;
#pragma warning disable 0169
		static Delegate GetGetControllerFailureTimeMsHandler ()
		{
			if (cb_getControllerFailureTimeMs == null)
				cb_getControllerFailureTimeMs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetControllerFailureTimeMs);
			return cb_getControllerFailureTimeMs;
		}

		static long n_GetControllerFailureTimeMs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ControllerFailureTimeMs;
		}
#pragma warning restore 0169

		public virtual unsafe long ControllerFailureTimeMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfData']/method[@name='getControllerFailureTimeMs' and count(parameter)=0]"
			[Register ("getControllerFailureTimeMs", "()J", "GetGetControllerFailureTimeMsHandler")]
			get {
				const string __id = "getControllerFailureTimeMs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getControllerFinalImageSetTimeMs;
#pragma warning disable 0169
		static Delegate GetGetControllerFinalImageSetTimeMsHandler ()
		{
			if (cb_getControllerFinalImageSetTimeMs == null)
				cb_getControllerFinalImageSetTimeMs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetControllerFinalImageSetTimeMs);
			return cb_getControllerFinalImageSetTimeMs;
		}

		static long n_GetControllerFinalImageSetTimeMs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ControllerFinalImageSetTimeMs;
		}
#pragma warning restore 0169

		public virtual unsafe long ControllerFinalImageSetTimeMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfData']/method[@name='getControllerFinalImageSetTimeMs' and count(parameter)=0]"
			[Register ("getControllerFinalImageSetTimeMs", "()J", "GetGetControllerFinalImageSetTimeMsHandler")]
			get {
				const string __id = "getControllerFinalImageSetTimeMs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getControllerId;
#pragma warning disable 0169
		static Delegate GetGetControllerIdHandler ()
		{
			if (cb_getControllerId == null)
				cb_getControllerId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetControllerId);
			return cb_getControllerId;
		}

		static IntPtr n_GetControllerId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ControllerId);
		}
#pragma warning restore 0169

		public virtual unsafe string ControllerId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfData']/method[@name='getControllerId' and count(parameter)=0]"
			[Register ("getControllerId", "()Ljava/lang/String;", "GetGetControllerIdHandler")]
			get {
				const string __id = "getControllerId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getControllerIntermediateImageSetTimeMs;
#pragma warning disable 0169
		static Delegate GetGetControllerIntermediateImageSetTimeMsHandler ()
		{
			if (cb_getControllerIntermediateImageSetTimeMs == null)
				cb_getControllerIntermediateImageSetTimeMs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetControllerIntermediateImageSetTimeMs);
			return cb_getControllerIntermediateImageSetTimeMs;
		}

		static long n_GetControllerIntermediateImageSetTimeMs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ControllerIntermediateImageSetTimeMs;
		}
#pragma warning restore 0169

		public virtual unsafe long ControllerIntermediateImageSetTimeMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfData']/method[@name='getControllerIntermediateImageSetTimeMs' and count(parameter)=0]"
			[Register ("getControllerIntermediateImageSetTimeMs", "()J", "GetGetControllerIntermediateImageSetTimeMsHandler")]
			get {
				const string __id = "getControllerIntermediateImageSetTimeMs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getControllerSubmitTimeMs;
#pragma warning disable 0169
		static Delegate GetGetControllerSubmitTimeMsHandler ()
		{
			if (cb_getControllerSubmitTimeMs == null)
				cb_getControllerSubmitTimeMs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetControllerSubmitTimeMs);
			return cb_getControllerSubmitTimeMs;
		}

		static long n_GetControllerSubmitTimeMs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ControllerSubmitTimeMs;
		}
#pragma warning restore 0169

		public virtual unsafe long ControllerSubmitTimeMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfData']/method[@name='getControllerSubmitTimeMs' and count(parameter)=0]"
			[Register ("getControllerSubmitTimeMs", "()J", "GetGetControllerSubmitTimeMsHandler")]
			get {
				const string __id = "getControllerSubmitTimeMs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getFinalImageLoadTimeMs;
#pragma warning disable 0169
		static Delegate GetGetFinalImageLoadTimeMsHandler ()
		{
			if (cb_getFinalImageLoadTimeMs == null)
				cb_getFinalImageLoadTimeMs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetFinalImageLoadTimeMs);
			return cb_getFinalImageLoadTimeMs;
		}

		static long n_GetFinalImageLoadTimeMs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FinalImageLoadTimeMs;
		}
#pragma warning restore 0169

		public virtual unsafe long FinalImageLoadTimeMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfData']/method[@name='getFinalImageLoadTimeMs' and count(parameter)=0]"
			[Register ("getFinalImageLoadTimeMs", "()J", "GetGetFinalImageLoadTimeMsHandler")]
			get {
				const string __id = "getFinalImageLoadTimeMs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getImageInfo;
#pragma warning disable 0169
		static Delegate GetGetImageInfoHandler ()
		{
			if (cb_getImageInfo == null)
				cb_getImageInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageInfo);
			return cb_getImageInfo;
		}

		static IntPtr n_GetImageInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageInfo);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Imagepipeline.Image.IImageInfo ImageInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfData']/method[@name='getImageInfo' and count(parameter)=0]"
			[Register ("getImageInfo", "()Lcom/facebook/imagepipeline/image/ImageInfo;", "GetGetImageInfoHandler")]
			get {
				const string __id = "getImageInfo.()Lcom/facebook/imagepipeline/image/ImageInfo;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.IImageInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImageOrigin;
#pragma warning disable 0169
		static Delegate GetGetImageOriginHandler ()
		{
			if (cb_getImageOrigin == null)
				cb_getImageOrigin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetImageOrigin);
			return cb_getImageOrigin;
		}

		static int n_GetImageOrigin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageOrigin;
		}
#pragma warning restore 0169

		public virtual unsafe int ImageOrigin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfData']/method[@name='getImageOrigin' and count(parameter)=0]"
			[Register ("getImageOrigin", "()I", "GetGetImageOriginHandler")]
			get {
				const string __id = "getImageOrigin.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getImageRequest;
#pragma warning disable 0169
		static Delegate GetGetImageRequestHandler ()
		{
			if (cb_getImageRequest == null)
				cb_getImageRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageRequest);
			return cb_getImageRequest;
		}

		static IntPtr n_GetImageRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageRequest);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Imagepipeline.Request.ImageRequest ImageRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfData']/method[@name='getImageRequest' and count(parameter)=0]"
			[Register ("getImageRequest", "()Lcom/facebook/imagepipeline/request/ImageRequest;", "GetGetImageRequestHandler")]
			get {
				const string __id = "getImageRequest.()Lcom/facebook/imagepipeline/request/ImageRequest;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Request.ImageRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImageRequestEndTimeMs;
#pragma warning disable 0169
		static Delegate GetGetImageRequestEndTimeMsHandler ()
		{
			if (cb_getImageRequestEndTimeMs == null)
				cb_getImageRequestEndTimeMs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetImageRequestEndTimeMs);
			return cb_getImageRequestEndTimeMs;
		}

		static long n_GetImageRequestEndTimeMs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageRequestEndTimeMs;
		}
#pragma warning restore 0169

		public virtual unsafe long ImageRequestEndTimeMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfData']/method[@name='getImageRequestEndTimeMs' and count(parameter)=0]"
			[Register ("getImageRequestEndTimeMs", "()J", "GetGetImageRequestEndTimeMsHandler")]
			get {
				const string __id = "getImageRequestEndTimeMs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getImageRequestStartTimeMs;
#pragma warning disable 0169
		static Delegate GetGetImageRequestStartTimeMsHandler ()
		{
			if (cb_getImageRequestStartTimeMs == null)
				cb_getImageRequestStartTimeMs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetImageRequestStartTimeMs);
			return cb_getImageRequestStartTimeMs;
		}

		static long n_GetImageRequestStartTimeMs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageRequestStartTimeMs;
		}
#pragma warning restore 0169

		public virtual unsafe long ImageRequestStartTimeMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfData']/method[@name='getImageRequestStartTimeMs' and count(parameter)=0]"
			[Register ("getImageRequestStartTimeMs", "()J", "GetGetImageRequestStartTimeMsHandler")]
			get {
				const string __id = "getImageRequestStartTimeMs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIntermediateImageLoadTimeMs;
#pragma warning disable 0169
		static Delegate GetGetIntermediateImageLoadTimeMsHandler ()
		{
			if (cb_getIntermediateImageLoadTimeMs == null)
				cb_getIntermediateImageLoadTimeMs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetIntermediateImageLoadTimeMs);
			return cb_getIntermediateImageLoadTimeMs;
		}

		static long n_GetIntermediateImageLoadTimeMs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IntermediateImageLoadTimeMs;
		}
#pragma warning restore 0169

		public virtual unsafe long IntermediateImageLoadTimeMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfData']/method[@name='getIntermediateImageLoadTimeMs' and count(parameter)=0]"
			[Register ("getIntermediateImageLoadTimeMs", "()J", "GetGetIntermediateImageLoadTimeMsHandler")]
			get {
				const string __id = "getIntermediateImageLoadTimeMs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isCanceled;
#pragma warning disable 0169
		static Delegate GetIsCanceledHandler ()
		{
			if (cb_isCanceled == null)
				cb_isCanceled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCanceled);
			return cb_isCanceled;
		}

		static bool n_IsCanceled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCanceled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCanceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfData']/method[@name='isCanceled' and count(parameter)=0]"
			[Register ("isCanceled", "()Z", "GetIsCanceledHandler")]
			get {
				const string __id = "isCanceled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isPrefetch;
#pragma warning disable 0169
		static Delegate GetIsPrefetchHandler ()
		{
			if (cb_isPrefetch == null)
				cb_isPrefetch = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPrefetch);
			return cb_isPrefetch;
		}

		static bool n_IsPrefetch (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPrefetch;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPrefetch {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfData']/method[@name='isPrefetch' and count(parameter)=0]"
			[Register ("isPrefetch", "()Z", "GetIsPrefetchHandler")]
			get {
				const string __id = "isPrefetch.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isSuccessful;
#pragma warning disable 0169
		static Delegate GetIsSuccessfulHandler ()
		{
			if (cb_isSuccessful == null)
				cb_isSuccessful = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSuccessful);
			return cb_isSuccessful;
		}

		static bool n_IsSuccessful (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSuccessful;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSuccessful {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfData']/method[@name='isSuccessful' and count(parameter)=0]"
			[Register ("isSuccessful", "()Z", "GetIsSuccessfulHandler")]
			get {
				const string __id = "isSuccessful.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRequestId;
#pragma warning disable 0169
		static Delegate GetGetRequestIdHandler ()
		{
			if (cb_getRequestId == null)
				cb_getRequestId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestId);
			return cb_getRequestId;
		}

		static IntPtr n_GetRequestId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestId);
		}
#pragma warning restore 0169

		public virtual unsafe string RequestId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfData']/method[@name='getRequestId' and count(parameter)=0]"
			[Register ("getRequestId", "()Ljava/lang/String;", "GetGetRequestIdHandler")]
			get {
				const string __id = "getRequestId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createDebugString;
#pragma warning disable 0169
		static Delegate GetCreateDebugStringHandler ()
		{
			if (cb_createDebugString == null)
				cb_createDebugString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateDebugString);
			return cb_createDebugString;
		}

		static IntPtr n_CreateDebugString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreateDebugString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfData']/method[@name='createDebugString' and count(parameter)=0]"
		[Register ("createDebugString", "()Ljava/lang/String;", "GetCreateDebugStringHandler")]
		public virtual unsafe string CreateDebugString ()
		{
			const string __id = "createDebugString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
