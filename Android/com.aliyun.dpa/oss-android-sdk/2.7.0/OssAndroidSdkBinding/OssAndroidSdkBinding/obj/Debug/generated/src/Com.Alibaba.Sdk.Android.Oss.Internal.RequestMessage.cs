using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/RequestMessage", DoNotGenerateAcw=true)]
	public partial class RequestMessage : global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/RequestMessage", typeof (RequestMessage));
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

		protected RequestMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/constructor[@name='RequestMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RequestMessage ()
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

		static Delegate cb_getBucketName;
#pragma warning disable 0169
		static Delegate GetGetBucketNameHandler ()
		{
			if (cb_getBucketName == null)
				cb_getBucketName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBucketName);
			return cb_getBucketName;
		}

		static IntPtr n_GetBucketName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BucketName);
		}
#pragma warning restore 0169

		static Delegate cb_setBucketName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBucketName_Ljava_lang_String_Handler ()
		{
			if (cb_setBucketName_Ljava_lang_String_ == null)
				cb_setBucketName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBucketName_Ljava_lang_String_);
			return cb_setBucketName_Ljava_lang_String_;
		}

		static void n_SetBucketName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bucketName)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string bucketName = JNIEnv.GetString (native_bucketName, JniHandleOwnership.DoNotTransfer);
			__this.BucketName = bucketName;
		}
#pragma warning restore 0169

		public virtual unsafe string BucketName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='getBucketName' and count(parameter)=0]"
			[Register ("getBucketName", "()Ljava/lang/String;", "GetGetBucketNameHandler")]
			get {
				const string __id = "getBucketName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='setBucketName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBucketName", "(Ljava/lang/String;)V", "GetSetBucketName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBucketName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isCheckCRC64;
#pragma warning disable 0169
		static Delegate GetIsCheckCRC64Handler ()
		{
			if (cb_isCheckCRC64 == null)
				cb_isCheckCRC64 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCheckCRC64);
			return cb_isCheckCRC64;
		}

		static bool n_IsCheckCRC64 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckCRC64;
		}
#pragma warning restore 0169

		static Delegate cb_setCheckCRC64_Z;
#pragma warning disable 0169
		static Delegate GetSetCheckCRC64_ZHandler ()
		{
			if (cb_setCheckCRC64_Z == null)
				cb_setCheckCRC64_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCheckCRC64_Z);
			return cb_setCheckCRC64_Z;
		}

		static void n_SetCheckCRC64_Z (IntPtr jnienv, IntPtr native__this, bool checkCRC64)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckCRC64 = checkCRC64;
		}
#pragma warning restore 0169

		public virtual unsafe bool CheckCRC64 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='isCheckCRC64' and count(parameter)=0]"
			[Register ("isCheckCRC64", "()Z", "GetIsCheckCRC64Handler")]
			get {
				const string __id = "isCheckCRC64.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='setCheckCRC64' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCheckCRC64", "(Z)V", "GetSetCheckCRC64_ZHandler")]
			set {
				const string __id = "setCheckCRC64.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getContent;
#pragma warning disable 0169
		static Delegate GetGetContentHandler ()
		{
			if (cb_getContent == null)
				cb_getContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContent);
			return cb_getContent;
		}

		static IntPtr n_GetContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Content);
		}
#pragma warning restore 0169

		static Delegate cb_setContent_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetSetContent_Ljava_io_InputStream_Handler ()
		{
			if (cb_setContent_Ljava_io_InputStream_ == null)
				cb_setContent_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContent_Ljava_io_InputStream_);
			return cb_setContent_Ljava_io_InputStream_;
		}

		static void n_SetContent_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Content = p0;
		}
#pragma warning restore 0169

		public override unsafe global::System.IO.Stream Content {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='getContent' and count(parameter)=0]"
			[Register ("getContent", "()Ljava/io/InputStream;", "GetGetContentHandler")]
			get {
				const string __id = "getContent.()Ljava/io/InputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='setContent' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register ("setContent", "(Ljava/io/InputStream;)V", "GetSetContent_Ljava_io_InputStream_Handler")]
			set {
				const string __id = "setContent.(Ljava/io/InputStream;)V";
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
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetContentLength_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ContentLength = p0;
		}
#pragma warning restore 0169

		public override unsafe long ContentLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='getContentLength' and count(parameter)=0]"
			[Register ("getContentLength", "()J", "GetGetContentLengthHandler")]
			get {
				const string __id = "getContentLength.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='setContentLength' and count(parameter)=1 and parameter[1][@type='long']]"
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

		static Delegate cb_getCredentialProvider;
#pragma warning disable 0169
		static Delegate GetGetCredentialProviderHandler ()
		{
			if (cb_getCredentialProvider == null)
				cb_getCredentialProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCredentialProvider);
			return cb_getCredentialProvider;
		}

		static IntPtr n_GetCredentialProvider (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CredentialProvider);
		}
#pragma warning restore 0169

		static Delegate cb_setCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_;
#pragma warning disable 0169
		static Delegate GetSetCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_Handler ()
		{
			if (cb_setCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_ == null)
				cb_setCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_);
			return cb_setCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_;
		}

		static void n_SetCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_credentialProvider)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider credentialProvider = (global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider> (native_credentialProvider, JniHandleOwnership.DoNotTransfer);
			__this.CredentialProvider = credentialProvider;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider CredentialProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='getCredentialProvider' and count(parameter)=0]"
			[Register ("getCredentialProvider", "()Lcom/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider;", "GetGetCredentialProviderHandler")]
			get {
				const string __id = "getCredentialProvider.()Lcom/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='setCredentialProvider' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.common.auth.OSSCredentialProvider']]"
			[Register ("setCredentialProvider", "(Lcom/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider;)V", "GetSetCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_Handler")]
			set {
				const string __id = "setCredentialProvider.(Lcom/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEndpoint;
#pragma warning disable 0169
		static Delegate GetGetEndpointHandler ()
		{
			if (cb_getEndpoint == null)
				cb_getEndpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndpoint);
			return cb_getEndpoint;
		}

		static IntPtr n_GetEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Endpoint);
		}
#pragma warning restore 0169

		static Delegate cb_setEndpoint_Ljava_net_URI_;
#pragma warning disable 0169
		static Delegate GetSetEndpoint_Ljava_net_URI_Handler ()
		{
			if (cb_setEndpoint_Ljava_net_URI_ == null)
				cb_setEndpoint_Ljava_net_URI_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEndpoint_Ljava_net_URI_);
			return cb_setEndpoint_Ljava_net_URI_;
		}

		static void n_SetEndpoint_Ljava_net_URI_ (IntPtr jnienv, IntPtr native__this, IntPtr native_endpoint)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URI endpoint = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (native_endpoint, JniHandleOwnership.DoNotTransfer);
			__this.Endpoint = endpoint;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Net.URI Endpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='getEndpoint' and count(parameter)=0]"
			[Register ("getEndpoint", "()Ljava/net/URI;", "GetGetEndpointHandler")]
			get {
				const string __id = "getEndpoint.()Ljava/net/URI;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.URI> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='setEndpoint' and count(parameter)=1 and parameter[1][@type='java.net.URI']]"
			[Register ("setEndpoint", "(Ljava/net/URI;)V", "GetSetEndpoint_Ljava_net_URI_Handler")]
			set {
				const string __id = "setEndpoint.(Ljava/net/URI;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeaders;
#pragma warning disable 0169
		static Delegate GetGetHeadersHandler ()
		{
			if (cb_getHeaders == null)
				cb_getHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaders);
			return cb_getHeaders;
		}

		static IntPtr n_GetHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary.ToLocalJniHandle (__this.Headers);
		}
#pragma warning restore 0169

		static Delegate cb_setHeaders_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetHeaders_Ljava_util_Map_Handler ()
		{
			if (cb_setHeaders_Ljava_util_Map_ == null)
				cb_setHeaders_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeaders_Ljava_util_Map_);
			return cb_setHeaders_Ljava_util_Map_;
		}

		static void n_SetHeaders_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Headers = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.IDictionary Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='getHeaders' and count(parameter)=0]"
			[Register ("getHeaders", "()Ljava/util/Map;", "GetGetHeadersHandler")]
			get {
				const string __id = "getHeaders.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='setHeaders' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
			[Register ("setHeaders", "(Ljava/util/Map;)V", "GetSetHeaders_Ljava_util_Map_Handler")]
			set {
				const string __id = "setHeaders.(Ljava/util/Map;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isHttpDnsEnable;
#pragma warning disable 0169
		static Delegate GetIsHttpDnsEnableHandler ()
		{
			if (cb_isHttpDnsEnable == null)
				cb_isHttpDnsEnable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHttpDnsEnable);
			return cb_isHttpDnsEnable;
		}

		static bool n_IsHttpDnsEnable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HttpDnsEnable;
		}
#pragma warning restore 0169

		static Delegate cb_setHttpDnsEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetHttpDnsEnable_ZHandler ()
		{
			if (cb_setHttpDnsEnable_Z == null)
				cb_setHttpDnsEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHttpDnsEnable_Z);
			return cb_setHttpDnsEnable_Z;
		}

		static void n_SetHttpDnsEnable_Z (IntPtr jnienv, IntPtr native__this, bool httpDnsEnable)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HttpDnsEnable = httpDnsEnable;
		}
#pragma warning restore 0169

		public virtual unsafe bool HttpDnsEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='isHttpDnsEnable' and count(parameter)=0]"
			[Register ("isHttpDnsEnable", "()Z", "GetIsHttpDnsEnableHandler")]
			get {
				const string __id = "isHttpDnsEnable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='setHttpDnsEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHttpDnsEnable", "(Z)V", "GetSetHttpDnsEnable_ZHandler")]
			set {
				const string __id = "setHttpDnsEnable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isAuthorizationRequired;
#pragma warning disable 0169
		static Delegate GetIsAuthorizationRequiredHandler ()
		{
			if (cb_isAuthorizationRequired == null)
				cb_isAuthorizationRequired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAuthorizationRequired);
			return cb_isAuthorizationRequired;
		}

		static bool n_IsAuthorizationRequired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAuthorizationRequired;
		}
#pragma warning restore 0169

		static Delegate cb_setIsAuthorizationRequired_Z;
#pragma warning disable 0169
		static Delegate GetSetIsAuthorizationRequired_ZHandler ()
		{
			if (cb_setIsAuthorizationRequired_Z == null)
				cb_setIsAuthorizationRequired_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsAuthorizationRequired_Z);
			return cb_setIsAuthorizationRequired_Z;
		}

		static void n_SetIsAuthorizationRequired_Z (IntPtr jnienv, IntPtr native__this, bool isAuthorizationRequired)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsAuthorizationRequired = isAuthorizationRequired;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAuthorizationRequired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='isAuthorizationRequired' and count(parameter)=0]"
			[Register ("isAuthorizationRequired", "()Z", "GetIsAuthorizationRequiredHandler")]
			get {
				const string __id = "isAuthorizationRequired.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='setIsAuthorizationRequired' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsAuthorizationRequired", "(Z)V", "GetSetIsAuthorizationRequired_ZHandler")]
			set {
				const string __id = "setIsAuthorizationRequired.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isInCustomCnameExcludeList;
#pragma warning disable 0169
		static Delegate GetIsInCustomCnameExcludeListHandler ()
		{
			if (cb_isInCustomCnameExcludeList == null)
				cb_isInCustomCnameExcludeList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInCustomCnameExcludeList);
			return cb_isInCustomCnameExcludeList;
		}

		static bool n_IsInCustomCnameExcludeList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInCustomCnameExcludeList;
		}
#pragma warning restore 0169

		static Delegate cb_setIsInCustomCnameExcludeList_Z;
#pragma warning disable 0169
		static Delegate GetSetIsInCustomCnameExcludeList_ZHandler ()
		{
			if (cb_setIsInCustomCnameExcludeList_Z == null)
				cb_setIsInCustomCnameExcludeList_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsInCustomCnameExcludeList_Z);
			return cb_setIsInCustomCnameExcludeList_Z;
		}

		static void n_SetIsInCustomCnameExcludeList_Z (IntPtr jnienv, IntPtr native__this, bool isInExcludeCnameList)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsInCustomCnameExcludeList = isInExcludeCnameList;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsInCustomCnameExcludeList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='isInCustomCnameExcludeList' and count(parameter)=0]"
			[Register ("isInCustomCnameExcludeList", "()Z", "GetIsInCustomCnameExcludeListHandler")]
			get {
				const string __id = "isInCustomCnameExcludeList.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='setIsInCustomCnameExcludeList' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsInCustomCnameExcludeList", "(Z)V", "GetSetIsInCustomCnameExcludeList_ZHandler")]
			set {
				const string __id = "setIsInCustomCnameExcludeList.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMethod;
#pragma warning disable 0169
		static Delegate GetGetMethodHandler ()
		{
			if (cb_getMethod == null)
				cb_getMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMethod);
			return cb_getMethod;
		}

		static IntPtr n_GetMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Method);
		}
#pragma warning restore 0169

		static Delegate cb_setMethod_Lcom_alibaba_sdk_android_oss_common_HttpMethod_;
#pragma warning disable 0169
		static Delegate GetSetMethod_Lcom_alibaba_sdk_android_oss_common_HttpMethod_Handler ()
		{
			if (cb_setMethod_Lcom_alibaba_sdk_android_oss_common_HttpMethod_ == null)
				cb_setMethod_Lcom_alibaba_sdk_android_oss_common_HttpMethod_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMethod_Lcom_alibaba_sdk_android_oss_common_HttpMethod_);
			return cb_setMethod_Lcom_alibaba_sdk_android_oss_common_HttpMethod_;
		}

		static void n_SetMethod_Lcom_alibaba_sdk_android_oss_common_HttpMethod_ (IntPtr jnienv, IntPtr native__this, IntPtr native_method)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod method = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod> (native_method, JniHandleOwnership.DoNotTransfer);
			__this.Method = method;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod Method {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='getMethod' and count(parameter)=0]"
			[Register ("getMethod", "()Lcom/alibaba/sdk/android/oss/common/HttpMethod;", "GetGetMethodHandler")]
			get {
				const string __id = "getMethod.()Lcom/alibaba/sdk/android/oss/common/HttpMethod;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='setMethod' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.common.HttpMethod']]"
			[Register ("setMethod", "(Lcom/alibaba/sdk/android/oss/common/HttpMethod;)V", "GetSetMethod_Lcom_alibaba_sdk_android_oss_common_HttpMethod_Handler")]
			set {
				const string __id = "setMethod.(Lcom/alibaba/sdk/android/oss/common/HttpMethod;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getObjectKey;
#pragma warning disable 0169
		static Delegate GetGetObjectKeyHandler ()
		{
			if (cb_getObjectKey == null)
				cb_getObjectKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObjectKey);
			return cb_getObjectKey;
		}

		static IntPtr n_GetObjectKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ObjectKey);
		}
#pragma warning restore 0169

		static Delegate cb_setObjectKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetObjectKey_Ljava_lang_String_Handler ()
		{
			if (cb_setObjectKey_Ljava_lang_String_ == null)
				cb_setObjectKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetObjectKey_Ljava_lang_String_);
			return cb_setObjectKey_Ljava_lang_String_;
		}

		static void n_SetObjectKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objectKey)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string objectKey = JNIEnv.GetString (native_objectKey, JniHandleOwnership.DoNotTransfer);
			__this.ObjectKey = objectKey;
		}
#pragma warning restore 0169

		public virtual unsafe string ObjectKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='getObjectKey' and count(parameter)=0]"
			[Register ("getObjectKey", "()Ljava/lang/String;", "GetGetObjectKeyHandler")]
			get {
				const string __id = "getObjectKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='setObjectKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setObjectKey", "(Ljava/lang/String;)V", "GetSetObjectKey_Ljava_lang_String_Handler")]
			set {
				const string __id = "setObjectKey.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getParameters;
#pragma warning disable 0169
		static Delegate GetGetParametersHandler ()
		{
			if (cb_getParameters == null)
				cb_getParameters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParameters);
			return cb_getParameters;
		}

		static IntPtr n_GetParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Parameters);
		}
#pragma warning restore 0169

		static Delegate cb_setParameters_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetParameters_Ljava_util_Map_Handler ()
		{
			if (cb_setParameters_Ljava_util_Map_ == null)
				cb_setParameters_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParameters_Ljava_util_Map_);
			return cb_setParameters_Ljava_util_Map_;
		}

		static void n_SetParameters_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_parameters, JniHandleOwnership.DoNotTransfer);
			__this.Parameters = parameters;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Parameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='getParameters' and count(parameter)=0]"
			[Register ("getParameters", "()Ljava/util/Map;", "GetGetParametersHandler")]
			get {
				const string __id = "getParameters.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='setParameters' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setParameters", "(Ljava/util/Map;)V", "GetSetParameters_Ljava_util_Map_Handler")]
			set {
				const string __id = "setParameters.(Ljava/util/Map;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStringBody;
#pragma warning disable 0169
		static Delegate GetGetStringBodyHandler ()
		{
			if (cb_getStringBody == null)
				cb_getStringBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStringBody);
			return cb_getStringBody;
		}

		static IntPtr n_GetStringBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StringBody);
		}
#pragma warning restore 0169

		static Delegate cb_setStringBody_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStringBody_Ljava_lang_String_Handler ()
		{
			if (cb_setStringBody_Ljava_lang_String_ == null)
				cb_setStringBody_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStringBody_Ljava_lang_String_);
			return cb_setStringBody_Ljava_lang_String_;
		}

		static void n_SetStringBody_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StringBody = p0;
		}
#pragma warning restore 0169

		public override unsafe string StringBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='getStringBody' and count(parameter)=0]"
			[Register ("getStringBody", "()Ljava/lang/String;", "GetGetStringBodyHandler")]
			get {
				const string __id = "getStringBody.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='setStringBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStringBody", "(Ljava/lang/String;)V", "GetSetStringBody_Ljava_lang_String_Handler")]
			set {
				const string __id = "setStringBody.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUploadFilePath;
#pragma warning disable 0169
		static Delegate GetGetUploadFilePathHandler ()
		{
			if (cb_getUploadFilePath == null)
				cb_getUploadFilePath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUploadFilePath);
			return cb_getUploadFilePath;
		}

		static IntPtr n_GetUploadFilePath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UploadFilePath);
		}
#pragma warning restore 0169

		static Delegate cb_setUploadFilePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUploadFilePath_Ljava_lang_String_Handler ()
		{
			if (cb_setUploadFilePath_Ljava_lang_String_ == null)
				cb_setUploadFilePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUploadFilePath_Ljava_lang_String_);
			return cb_setUploadFilePath_Ljava_lang_String_;
		}

		static void n_SetUploadFilePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uploadFilePath)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uploadFilePath = JNIEnv.GetString (native_uploadFilePath, JniHandleOwnership.DoNotTransfer);
			__this.UploadFilePath = uploadFilePath;
		}
#pragma warning restore 0169

		public virtual unsafe string UploadFilePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='getUploadFilePath' and count(parameter)=0]"
			[Register ("getUploadFilePath", "()Ljava/lang/String;", "GetGetUploadFilePathHandler")]
			get {
				const string __id = "getUploadFilePath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='setUploadFilePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUploadFilePath", "(Ljava/lang/String;)V", "GetSetUploadFilePath_Ljava_lang_String_Handler")]
			set {
				const string __id = "setUploadFilePath.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addHeader_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddHeader_Ljava_lang_String_Ljava_lang_String_);
			return cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddHeader (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void AddHeader (string p0, string p1)
		{
			const string __id = "addHeader.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_buildCanonicalURL;
#pragma warning disable 0169
		static Delegate GetBuildCanonicalURLHandler ()
		{
			if (cb_buildCanonicalURL == null)
				cb_buildCanonicalURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BuildCanonicalURL);
			return cb_buildCanonicalURL;
		}

		static IntPtr n_BuildCanonicalURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BuildCanonicalURL ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='buildCanonicalURL' and count(parameter)=0]"
		[Register ("buildCanonicalURL", "()Ljava/lang/String;", "GetBuildCanonicalURLHandler")]
		public virtual unsafe string BuildCanonicalURL ()
		{
			const string __id = "buildCanonicalURL.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_createBucketRequestBodyMarshall_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateBucketRequestBodyMarshall_Ljava_lang_String_Handler ()
		{
			if (cb_createBucketRequestBodyMarshall_Ljava_lang_String_ == null)
				cb_createBucketRequestBodyMarshall_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CreateBucketRequestBodyMarshall_Ljava_lang_String_);
			return cb_createBucketRequestBodyMarshall_Ljava_lang_String_;
		}

		static void n_CreateBucketRequestBodyMarshall_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_locationConstraint)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string locationConstraint = JNIEnv.GetString (native_locationConstraint, JniHandleOwnership.DoNotTransfer);
			__this.CreateBucketRequestBodyMarshall (locationConstraint);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='createBucketRequestBodyMarshall' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createBucketRequestBodyMarshall", "(Ljava/lang/String;)V", "GetCreateBucketRequestBodyMarshall_Ljava_lang_String_Handler")]
		public virtual unsafe void CreateBucketRequestBodyMarshall (string locationConstraint)
		{
			const string __id = "createBucketRequestBodyMarshall.(Ljava/lang/String;)V";
			IntPtr native_locationConstraint = JNIEnv.NewString (locationConstraint);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_locationConstraint);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_locationConstraint);
			}
		}

		static Delegate cb_getUploadData;
#pragma warning disable 0169
		static Delegate GetGetUploadDataHandler ()
		{
			if (cb_getUploadData == null)
				cb_getUploadData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUploadData);
			return cb_getUploadData;
		}

		static IntPtr n_GetUploadData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetUploadData ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='getUploadData' and count(parameter)=0]"
		[Register ("getUploadData", "()[B", "GetGetUploadDataHandler")]
		public virtual unsafe byte[] GetUploadData ()
		{
			const string __id = "getUploadData.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_setUploadData_arrayB;
#pragma warning disable 0169
		static Delegate GetSetUploadData_arrayBHandler ()
		{
			if (cb_setUploadData_arrayB == null)
				cb_setUploadData_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUploadData_arrayB);
			return cb_setUploadData_arrayB;
		}

		static void n_SetUploadData_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_uploadData)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] uploadData = (byte[]) JNIEnv.GetArray (native_uploadData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetUploadData (uploadData);
			if (uploadData != null)
				JNIEnv.CopyArray (uploadData, native_uploadData);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='RequestMessage']/method[@name='setUploadData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setUploadData", "([B)V", "GetSetUploadData_arrayBHandler")]
		public virtual unsafe void SetUploadData (byte[] uploadData)
		{
			const string __id = "setUploadData.([B)V";
			IntPtr native_uploadData = JNIEnv.NewArray (uploadData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_uploadData);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (uploadData != null) {
					JNIEnv.CopyArray (native_uploadData, uploadData);
					JNIEnv.DeleteLocalRef (native_uploadData);
				}
			}
		}

	}
}
