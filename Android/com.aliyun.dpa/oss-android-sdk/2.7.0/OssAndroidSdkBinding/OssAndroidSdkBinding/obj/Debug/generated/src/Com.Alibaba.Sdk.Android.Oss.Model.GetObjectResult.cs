using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetObjectResult']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/GetObjectResult", DoNotGenerateAcw=true)]
	public partial class GetObjectResult : global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/GetObjectResult", typeof (GetObjectResult));
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

		protected GetObjectResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetObjectResult']/constructor[@name='GetObjectResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GetObjectResult ()
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

		static Delegate cb_getContentLength;
#pragma warning disable 0169
		static Delegate GetGetContentLengthHandler ()
		{
			if (cb_getContentLength == null)
				cb_getContentLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetContentLength);
			return cb_getContentLength;
		}

		static long n_GetContentLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentLength;
		}
#pragma warning restore 0169

		static Delegate cb_setContentLength_J;
#pragma warning disable 0169
		static Delegate GetSetContentLength_JHandler ()
		{
			if (cb_setContentLength_J == null)
				cb_setContentLength_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetContentLength_J);
			return cb_setContentLength_J;
		}

		static void n_SetContentLength_J (IntPtr jnienv, IntPtr native__this, long contentLength)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ContentLength = contentLength;
		}
#pragma warning restore 0169

		public virtual unsafe long ContentLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetObjectResult']/method[@name='getContentLength' and count(parameter)=0]"
			[Register ("getContentLength", "()J", "GetGetContentLengthHandler")]
			get {
				const string __id = "getContentLength.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetObjectResult']/method[@name='setContentLength' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setContentLength", "(J)V", "GetSetContentLength_JHandler")]
			set {
				const string __id = "setContentLength.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMetadata;
#pragma warning disable 0169
		static Delegate GetGetMetadataHandler ()
		{
			if (cb_getMetadata == null)
				cb_getMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetadata);
			return cb_getMetadata;
		}

		static IntPtr n_GetMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Metadata);
		}
#pragma warning restore 0169

		static Delegate cb_setMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_;
#pragma warning disable 0169
		static Delegate GetSetMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_Handler ()
		{
			if (cb_setMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_ == null)
				cb_setMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_);
			return cb_setMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_;
		}

		static void n_SetMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_metadata)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata metadata = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (native_metadata, JniHandleOwnership.DoNotTransfer);
			__this.Metadata = metadata;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetObjectResult']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;", "GetGetMetadataHandler")]
			get {
				const string __id = "getMetadata.()Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetObjectResult']/method[@name='setMetadata' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ObjectMetadata']]"
			[Register ("setMetadata", "(Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;)V", "GetSetMetadata_Lcom_alibaba_sdk_android_oss_model_ObjectMetadata_Handler")]
			set {
				const string __id = "setMetadata.(Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getObjectContent;
#pragma warning disable 0169
		static Delegate GetGetObjectContentHandler ()
		{
			if (cb_getObjectContent == null)
				cb_getObjectContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObjectContent);
			return cb_getObjectContent;
		}

		static IntPtr n_GetObjectContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.ObjectContent);
		}
#pragma warning restore 0169

		static Delegate cb_setObjectContent_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetSetObjectContent_Ljava_io_InputStream_Handler ()
		{
			if (cb_setObjectContent_Ljava_io_InputStream_ == null)
				cb_setObjectContent_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetObjectContent_Ljava_io_InputStream_);
			return cb_setObjectContent_Ljava_io_InputStream_;
		}

		static void n_SetObjectContent_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objectContent)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream objectContent = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_objectContent, JniHandleOwnership.DoNotTransfer);
			__this.ObjectContent = objectContent;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.IO.Stream ObjectContent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetObjectResult']/method[@name='getObjectContent' and count(parameter)=0]"
			[Register ("getObjectContent", "()Ljava/io/InputStream;", "GetGetObjectContentHandler")]
			get {
				const string __id = "getObjectContent.()Ljava/io/InputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='GetObjectResult']/method[@name='setObjectContent' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register ("setObjectContent", "(Ljava/io/InputStream;)V", "GetSetObjectContent_Ljava_io_InputStream_Handler")]
			set {
				const string __id = "setObjectContent.(Ljava/io/InputStream;)V";
				IntPtr native_value = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
