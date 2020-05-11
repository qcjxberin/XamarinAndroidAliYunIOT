using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/ClientConfiguration", DoNotGenerateAcw=true)]
	public partial class ClientConfiguration : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/ClientConfiguration", typeof (ClientConfiguration));
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

		protected ClientConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/constructor[@name='ClientConfiguration' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ClientConfiguration ()
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
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckCRC64 = checkCRC64;
		}
#pragma warning restore 0169

		public virtual unsafe bool CheckCRC64 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='isCheckCRC64' and count(parameter)=0]"
			[Register ("isCheckCRC64", "()Z", "GetIsCheckCRC64Handler")]
			get {
				const string __id = "isCheckCRC64.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='setCheckCRC64' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_getConnectionTimeout;
#pragma warning disable 0169
		static Delegate GetGetConnectionTimeoutHandler ()
		{
			if (cb_getConnectionTimeout == null)
				cb_getConnectionTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetConnectionTimeout);
			return cb_getConnectionTimeout;
		}

		static int n_GetConnectionTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectionTimeout;
		}
#pragma warning restore 0169

		static Delegate cb_setConnectionTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetConnectionTimeout_IHandler ()
		{
			if (cb_setConnectionTimeout_I == null)
				cb_setConnectionTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetConnectionTimeout_I);
			return cb_setConnectionTimeout_I;
		}

		static void n_SetConnectionTimeout_I (IntPtr jnienv, IntPtr native__this, int connectionTimeout)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectionTimeout = connectionTimeout;
		}
#pragma warning restore 0169

		public virtual unsafe int ConnectionTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='getConnectionTimeout' and count(parameter)=0]"
			[Register ("getConnectionTimeout", "()I", "GetGetConnectionTimeoutHandler")]
			get {
				const string __id = "getConnectionTimeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='setConnectionTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setConnectionTimeout", "(I)V", "GetSetConnectionTimeout_IHandler")]
			set {
				const string __id = "setConnectionTimeout.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCustomCnameExcludeList;
#pragma warning disable 0169
		static Delegate GetGetCustomCnameExcludeListHandler ()
		{
			if (cb_getCustomCnameExcludeList == null)
				cb_getCustomCnameExcludeList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomCnameExcludeList);
			return cb_getCustomCnameExcludeList;
		}

		static IntPtr n_GetCustomCnameExcludeList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.CustomCnameExcludeList);
		}
#pragma warning restore 0169

		static Delegate cb_setCustomCnameExcludeList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetCustomCnameExcludeList_Ljava_util_List_Handler ()
		{
			if (cb_setCustomCnameExcludeList_Ljava_util_List_ == null)
				cb_setCustomCnameExcludeList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomCnameExcludeList_Ljava_util_List_);
			return cb_setCustomCnameExcludeList_Ljava_util_List_;
		}

		static void n_SetCustomCnameExcludeList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_customCnameExcludeList)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var customCnameExcludeList = global::Android.Runtime.JavaList<string>.FromJniHandle (native_customCnameExcludeList, JniHandleOwnership.DoNotTransfer);
			__this.CustomCnameExcludeList = customCnameExcludeList;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> CustomCnameExcludeList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='getCustomCnameExcludeList' and count(parameter)=0]"
			[Register ("getCustomCnameExcludeList", "()Ljava/util/List;", "GetGetCustomCnameExcludeListHandler")]
			get {
				const string __id = "getCustomCnameExcludeList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='setCustomCnameExcludeList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setCustomCnameExcludeList", "(Ljava/util/List;)V", "GetSetCustomCnameExcludeList_Ljava_util_List_Handler")]
			set {
				const string __id = "setCustomCnameExcludeList.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCustomUserMark;
#pragma warning disable 0169
		static Delegate GetGetCustomUserMarkHandler ()
		{
			if (cb_getCustomUserMark == null)
				cb_getCustomUserMark = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomUserMark);
			return cb_getCustomUserMark;
		}

		static IntPtr n_GetCustomUserMark (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CustomUserMark);
		}
#pragma warning restore 0169

		public virtual unsafe string CustomUserMark {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='getCustomUserMark' and count(parameter)=0]"
			[Register ("getCustomUserMark", "()Ljava/lang/String;", "GetGetCustomUserMarkHandler")]
			get {
				const string __id = "getCustomUserMark.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration DefaultConf {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='getDefaultConf' and count(parameter)=0]"
			[Register ("getDefaultConf", "()Lcom/alibaba/sdk/android/oss/ClientConfiguration;", "")]
			get {
				const string __id = "getDefaultConf.()Lcom/alibaba/sdk/android/oss/ClientConfiguration;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetHttpDnsEnable_Z (IntPtr jnienv, IntPtr native__this, bool httpdnsEnable)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HttpDnsEnable = httpdnsEnable;
		}
#pragma warning restore 0169

		public virtual unsafe bool HttpDnsEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='isHttpDnsEnable' and count(parameter)=0]"
			[Register ("isHttpDnsEnable", "()Z", "GetIsHttpDnsEnableHandler")]
			get {
				const string __id = "isHttpDnsEnable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='setHttpDnsEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_getMaxConcurrentRequest;
#pragma warning disable 0169
		static Delegate GetGetMaxConcurrentRequestHandler ()
		{
			if (cb_getMaxConcurrentRequest == null)
				cb_getMaxConcurrentRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxConcurrentRequest);
			return cb_getMaxConcurrentRequest;
		}

		static int n_GetMaxConcurrentRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxConcurrentRequest;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxConcurrentRequest_I;
#pragma warning disable 0169
		static Delegate GetSetMaxConcurrentRequest_IHandler ()
		{
			if (cb_setMaxConcurrentRequest_I == null)
				cb_setMaxConcurrentRequest_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxConcurrentRequest_I);
			return cb_setMaxConcurrentRequest_I;
		}

		static void n_SetMaxConcurrentRequest_I (IntPtr jnienv, IntPtr native__this, int maxConcurrentRequest)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxConcurrentRequest = maxConcurrentRequest;
		}
#pragma warning restore 0169

		public virtual unsafe int MaxConcurrentRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='getMaxConcurrentRequest' and count(parameter)=0]"
			[Register ("getMaxConcurrentRequest", "()I", "GetGetMaxConcurrentRequestHandler")]
			get {
				const string __id = "getMaxConcurrentRequest.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='setMaxConcurrentRequest' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxConcurrentRequest", "(I)V", "GetSetMaxConcurrentRequest_IHandler")]
			set {
				const string __id = "setMaxConcurrentRequest.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxErrorRetry;
#pragma warning disable 0169
		static Delegate GetGetMaxErrorRetryHandler ()
		{
			if (cb_getMaxErrorRetry == null)
				cb_getMaxErrorRetry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxErrorRetry);
			return cb_getMaxErrorRetry;
		}

		static int n_GetMaxErrorRetry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxErrorRetry;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxErrorRetry_I;
#pragma warning disable 0169
		static Delegate GetSetMaxErrorRetry_IHandler ()
		{
			if (cb_setMaxErrorRetry_I == null)
				cb_setMaxErrorRetry_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxErrorRetry_I);
			return cb_setMaxErrorRetry_I;
		}

		static void n_SetMaxErrorRetry_I (IntPtr jnienv, IntPtr native__this, int maxErrorRetry)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxErrorRetry = maxErrorRetry;
		}
#pragma warning restore 0169

		public virtual unsafe int MaxErrorRetry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='getMaxErrorRetry' and count(parameter)=0]"
			[Register ("getMaxErrorRetry", "()I", "GetGetMaxErrorRetryHandler")]
			get {
				const string __id = "getMaxErrorRetry.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='setMaxErrorRetry' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxErrorRetry", "(I)V", "GetSetMaxErrorRetry_IHandler")]
			set {
				const string __id = "setMaxErrorRetry.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxLogSize;
#pragma warning disable 0169
		static Delegate GetGetMaxLogSizeHandler ()
		{
			if (cb_getMaxLogSize == null)
				cb_getMaxLogSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMaxLogSize);
			return cb_getMaxLogSize;
		}

		static long n_GetMaxLogSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxLogSize;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxLogSize_J;
#pragma warning disable 0169
		static Delegate GetSetMaxLogSize_JHandler ()
		{
			if (cb_setMaxLogSize_J == null)
				cb_setMaxLogSize_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetMaxLogSize_J);
			return cb_setMaxLogSize_J;
		}

		static void n_SetMaxLogSize_J (IntPtr jnienv, IntPtr native__this, long max_log_size)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxLogSize = max_log_size;
		}
#pragma warning restore 0169

		public virtual unsafe long MaxLogSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='getMaxLogSize' and count(parameter)=0]"
			[Register ("getMaxLogSize", "()J", "GetGetMaxLogSizeHandler")]
			get {
				const string __id = "getMaxLogSize.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='setMaxLogSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMaxLogSize", "(J)V", "GetSetMaxLogSize_JHandler")]
			set {
				const string __id = "setMaxLogSize.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getProxyHost;
#pragma warning disable 0169
		static Delegate GetGetProxyHostHandler ()
		{
			if (cb_getProxyHost == null)
				cb_getProxyHost = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProxyHost);
			return cb_getProxyHost;
		}

		static IntPtr n_GetProxyHost (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProxyHost);
		}
#pragma warning restore 0169

		static Delegate cb_setProxyHost_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProxyHost_Ljava_lang_String_Handler ()
		{
			if (cb_setProxyHost_Ljava_lang_String_ == null)
				cb_setProxyHost_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProxyHost_Ljava_lang_String_);
			return cb_setProxyHost_Ljava_lang_String_;
		}

		static void n_SetProxyHost_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_proxyHost)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string proxyHost = JNIEnv.GetString (native_proxyHost, JniHandleOwnership.DoNotTransfer);
			__this.ProxyHost = proxyHost;
		}
#pragma warning restore 0169

		public virtual unsafe string ProxyHost {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='getProxyHost' and count(parameter)=0]"
			[Register ("getProxyHost", "()Ljava/lang/String;", "GetGetProxyHostHandler")]
			get {
				const string __id = "getProxyHost.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='setProxyHost' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProxyHost", "(Ljava/lang/String;)V", "GetSetProxyHost_Ljava_lang_String_Handler")]
			set {
				const string __id = "setProxyHost.(Ljava/lang/String;)V";
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

		static Delegate cb_getProxyPort;
#pragma warning disable 0169
		static Delegate GetGetProxyPortHandler ()
		{
			if (cb_getProxyPort == null)
				cb_getProxyPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetProxyPort);
			return cb_getProxyPort;
		}

		static int n_GetProxyPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProxyPort;
		}
#pragma warning restore 0169

		static Delegate cb_setProxyPort_I;
#pragma warning disable 0169
		static Delegate GetSetProxyPort_IHandler ()
		{
			if (cb_setProxyPort_I == null)
				cb_setProxyPort_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetProxyPort_I);
			return cb_setProxyPort_I;
		}

		static void n_SetProxyPort_I (IntPtr jnienv, IntPtr native__this, int proxyPort)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProxyPort = proxyPort;
		}
#pragma warning restore 0169

		public virtual unsafe int ProxyPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='getProxyPort' and count(parameter)=0]"
			[Register ("getProxyPort", "()I", "GetGetProxyPortHandler")]
			get {
				const string __id = "getProxyPort.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='setProxyPort' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setProxyPort", "(I)V", "GetSetProxyPort_IHandler")]
			set {
				const string __id = "setProxyPort.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSocketTimeout;
#pragma warning disable 0169
		static Delegate GetGetSocketTimeoutHandler ()
		{
			if (cb_getSocketTimeout == null)
				cb_getSocketTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSocketTimeout);
			return cb_getSocketTimeout;
		}

		static int n_GetSocketTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SocketTimeout;
		}
#pragma warning restore 0169

		static Delegate cb_setSocketTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetSocketTimeout_IHandler ()
		{
			if (cb_setSocketTimeout_I == null)
				cb_setSocketTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSocketTimeout_I);
			return cb_setSocketTimeout_I;
		}

		static void n_SetSocketTimeout_I (IntPtr jnienv, IntPtr native__this, int socketTimeout)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SocketTimeout = socketTimeout;
		}
#pragma warning restore 0169

		public virtual unsafe int SocketTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='getSocketTimeout' and count(parameter)=0]"
			[Register ("getSocketTimeout", "()I", "GetGetSocketTimeoutHandler")]
			get {
				const string __id = "getSocketTimeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='setSocketTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSocketTimeout", "(I)V", "GetSetSocketTimeout_IHandler")]
			set {
				const string __id = "setSocketTimeout.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_setUserAgentMark_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserAgentMark_Ljava_lang_String_Handler ()
		{
			if (cb_setUserAgentMark_Ljava_lang_String_ == null)
				cb_setUserAgentMark_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserAgentMark_Ljava_lang_String_);
			return cb_setUserAgentMark_Ljava_lang_String_;
		}

		static void n_SetUserAgentMark_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mark)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string mark = JNIEnv.GetString (native_mark, JniHandleOwnership.DoNotTransfer);
			__this.SetUserAgentMark (mark);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ClientConfiguration']/method[@name='setUserAgentMark' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUserAgentMark", "(Ljava/lang/String;)V", "GetSetUserAgentMark_Ljava_lang_String_Handler")]
		public virtual unsafe void SetUserAgentMark (string mark)
		{
			const string __id = "setUserAgentMark.(Ljava/lang/String;)V";
			IntPtr native_mark = JNIEnv.NewString (mark);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mark);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mark);
			}
		}

	}
}
