using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='HttpdnsMini']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/utils/HttpdnsMini", DoNotGenerateAcw=true)]
	public partial class HttpdnsMini : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='HttpdnsMini.HostObject']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/utils/HttpdnsMini$HostObject", DoNotGenerateAcw=true)]
		public partial class HostObject : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/utils/HttpdnsMini$HostObject", typeof (HostObject));
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

			protected HostObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getHostName;
#pragma warning disable 0169
			static Delegate GetGetHostNameHandler ()
			{
				if (cb_getHostName == null)
					cb_getHostName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHostName);
				return cb_getHostName;
			}

			static IntPtr n_GetHostName (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.HostObject __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.HostObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.HostName);
			}
#pragma warning restore 0169

			static Delegate cb_setHostName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetHostName_Ljava_lang_String_Handler ()
			{
				if (cb_setHostName_Ljava_lang_String_ == null)
					cb_setHostName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHostName_Ljava_lang_String_);
				return cb_setHostName_Ljava_lang_String_;
			}

			static void n_SetHostName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_hostName)
			{
				global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.HostObject __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.HostObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string hostName = JNIEnv.GetString (native_hostName, JniHandleOwnership.DoNotTransfer);
				__this.HostName = hostName;
			}
#pragma warning restore 0169

			public virtual unsafe string HostName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='HttpdnsMini.HostObject']/method[@name='getHostName' and count(parameter)=0]"
				[Register ("getHostName", "()Ljava/lang/String;", "GetGetHostNameHandler")]
				get {
					const string __id = "getHostName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='HttpdnsMini.HostObject']/method[@name='setHostName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setHostName", "(Ljava/lang/String;)V", "GetSetHostName_Ljava_lang_String_Handler")]
				set {
					const string __id = "setHostName.(Ljava/lang/String;)V";
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

			static Delegate cb_getIp;
#pragma warning disable 0169
			static Delegate GetGetIpHandler ()
			{
				if (cb_getIp == null)
					cb_getIp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIp);
				return cb_getIp;
			}

			static IntPtr n_GetIp (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.HostObject __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.HostObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Ip);
			}
#pragma warning restore 0169

			static Delegate cb_setIp_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetIp_Ljava_lang_String_Handler ()
			{
				if (cb_setIp_Ljava_lang_String_ == null)
					cb_setIp_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIp_Ljava_lang_String_);
				return cb_setIp_Ljava_lang_String_;
			}

			static void n_SetIp_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ip)
			{
				global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.HostObject __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.HostObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string ip = JNIEnv.GetString (native_ip, JniHandleOwnership.DoNotTransfer);
				__this.Ip = ip;
			}
#pragma warning restore 0169

			public virtual unsafe string Ip {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='HttpdnsMini.HostObject']/method[@name='getIp' and count(parameter)=0]"
				[Register ("getIp", "()Ljava/lang/String;", "GetGetIpHandler")]
				get {
					const string __id = "getIp.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='HttpdnsMini.HostObject']/method[@name='setIp' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setIp", "(Ljava/lang/String;)V", "GetSetIp_Ljava_lang_String_Handler")]
				set {
					const string __id = "setIp.(Ljava/lang/String;)V";
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

			static Delegate cb_isExpired;
#pragma warning disable 0169
			static Delegate GetIsExpiredHandler ()
			{
				if (cb_isExpired == null)
					cb_isExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExpired);
				return cb_isExpired;
			}

			static bool n_IsExpired (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.HostObject __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.HostObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsExpired;
			}
#pragma warning restore 0169

			public virtual unsafe bool IsExpired {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='HttpdnsMini.HostObject']/method[@name='isExpired' and count(parameter)=0]"
				[Register ("isExpired", "()Z", "GetIsExpiredHandler")]
				get {
					const string __id = "isExpired.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_isStillAvailable;
#pragma warning disable 0169
			static Delegate GetIsStillAvailableHandler ()
			{
				if (cb_isStillAvailable == null)
					cb_isStillAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStillAvailable);
				return cb_isStillAvailable;
			}

			static bool n_IsStillAvailable (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.HostObject __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.HostObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsStillAvailable;
			}
#pragma warning restore 0169

			public virtual unsafe bool IsStillAvailable {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='HttpdnsMini.HostObject']/method[@name='isStillAvailable' and count(parameter)=0]"
				[Register ("isStillAvailable", "()Z", "GetIsStillAvailableHandler")]
				get {
					const string __id = "isStillAvailable.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getQueryTime;
#pragma warning disable 0169
			static Delegate GetGetQueryTimeHandler ()
			{
				if (cb_getQueryTime == null)
					cb_getQueryTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetQueryTime);
				return cb_getQueryTime;
			}

			static long n_GetQueryTime (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.HostObject __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.HostObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.QueryTime;
			}
#pragma warning restore 0169

			static Delegate cb_setQueryTime_J;
#pragma warning disable 0169
			static Delegate GetSetQueryTime_JHandler ()
			{
				if (cb_setQueryTime_J == null)
					cb_setQueryTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetQueryTime_J);
				return cb_setQueryTime_J;
			}

			static void n_SetQueryTime_J (IntPtr jnienv, IntPtr native__this, long queryTime)
			{
				global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.HostObject __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.HostObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.QueryTime = queryTime;
			}
#pragma warning restore 0169

			public virtual unsafe long QueryTime {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='HttpdnsMini.HostObject']/method[@name='getQueryTime' and count(parameter)=0]"
				[Register ("getQueryTime", "()J", "GetGetQueryTimeHandler")]
				get {
					const string __id = "getQueryTime.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='HttpdnsMini.HostObject']/method[@name='setQueryTime' and count(parameter)=1 and parameter[1][@type='long']]"
				[Register ("setQueryTime", "(J)V", "GetSetQueryTime_JHandler")]
				set {
					const string __id = "setQueryTime.(J)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (value);
						_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
					} finally {
					}
				}
			}

			static Delegate cb_getTtl;
#pragma warning disable 0169
			static Delegate GetGetTtlHandler ()
			{
				if (cb_getTtl == null)
					cb_getTtl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTtl);
				return cb_getTtl;
			}

			static long n_GetTtl (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.HostObject __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.HostObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Ttl;
			}
#pragma warning restore 0169

			static Delegate cb_setTtl_J;
#pragma warning disable 0169
			static Delegate GetSetTtl_JHandler ()
			{
				if (cb_setTtl_J == null)
					cb_setTtl_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTtl_J);
				return cb_setTtl_J;
			}

			static void n_SetTtl_J (IntPtr jnienv, IntPtr native__this, long ttl)
			{
				global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.HostObject __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.HostObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Ttl = ttl;
			}
#pragma warning restore 0169

			public virtual unsafe long Ttl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='HttpdnsMini.HostObject']/method[@name='getTtl' and count(parameter)=0]"
				[Register ("getTtl", "()J", "GetGetTtlHandler")]
				get {
					const string __id = "getTtl.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='HttpdnsMini.HostObject']/method[@name='setTtl' and count(parameter)=1 and parameter[1][@type='long']]"
				[Register ("setTtl", "(J)V", "GetSetTtl_JHandler")]
				set {
					const string __id = "setTtl.(J)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (value);
						_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='HttpdnsMini.QueryHostTask']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/utils/HttpdnsMini$QueryHostTask", DoNotGenerateAcw=true)]
		public partial class QueryHostTask : global::Java.Lang.Object, global::Java.Util.Concurrent.ICallable {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/utils/HttpdnsMini$QueryHostTask", typeof (QueryHostTask));
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

			protected QueryHostTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='HttpdnsMini.QueryHostTask']/constructor[@name='HttpdnsMini.QueryHostTask' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.common.utils.HttpdnsMini'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/alibaba/sdk/android/oss/common/utils/HttpdnsMini;Ljava/lang/String;)V", "")]
			public unsafe QueryHostTask (global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini __self, string hostToQuery)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_hostToQuery = JNIEnv.NewString (hostToQuery);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					__args [1] = new JniArgumentValue (native_hostToQuery);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_hostToQuery);
				}
			}

			static Delegate cb_call;
#pragma warning disable 0169
			static Delegate GetRawCallHandler ()
			{
				if (cb_call == null)
					cb_call = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RawCall);
				return cb_call;
			}

			static IntPtr n_RawCall (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.QueryHostTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini.QueryHostTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.RawCall ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='HttpdnsMini.QueryHostTask']/method[@name='call' and count(parameter)=0]"
			[Register ("call", "()Ljava/lang/String;", "GetRawCallHandler")]
			public virtual unsafe string RawCall ()
			{
				const string __id = "call.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/utils/HttpdnsMini", typeof (HttpdnsMini));
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

		protected HttpdnsMini (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='HttpdnsMini']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/alibaba/sdk/android/oss/common/utils/HttpdnsMini;", "")]
			get {
				const string __id = "getInstance.()Lcom/alibaba/sdk/android/oss/common/utils/HttpdnsMini;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIpByHostAsync_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetIpByHostAsync_Ljava_lang_String_Handler ()
		{
			if (cb_getIpByHostAsync_Ljava_lang_String_ == null)
				cb_getIpByHostAsync_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetIpByHostAsync_Ljava_lang_String_);
			return cb_getIpByHostAsync_Ljava_lang_String_;
		}

		static IntPtr n_GetIpByHostAsync_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_hostName)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.HttpdnsMini> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string hostName = JNIEnv.GetString (native_hostName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetIpByHostAsync (hostName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='HttpdnsMini']/method[@name='getIpByHostAsync' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getIpByHostAsync", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetIpByHostAsync_Ljava_lang_String_Handler")]
		public virtual unsafe string GetIpByHostAsync (string hostName)
		{
			const string __id = "getIpByHostAsync.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_hostName = JNIEnv.NewString (hostName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hostName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_hostName);
			}
		}

	}
}
