using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSResult']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/OSSResult", DoNotGenerateAcw=true)]
	public partial class OSSResult : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/OSSResult", typeof (OSSResult));
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

		protected OSSResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSResult']/constructor[@name='OSSResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OSSResult ()
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

		static Delegate cb_getClientCRC;
#pragma warning disable 0169
		static Delegate GetGetClientCRCHandler ()
		{
			if (cb_getClientCRC == null)
				cb_getClientCRC = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientCRC);
			return cb_getClientCRC;
		}

		static IntPtr n_GetClientCRC (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClientCRC);
		}
#pragma warning restore 0169

		static Delegate cb_setClientCRC_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetClientCRC_Ljava_lang_Long_Handler ()
		{
			if (cb_setClientCRC_Ljava_lang_Long_ == null)
				cb_setClientCRC_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClientCRC_Ljava_lang_Long_);
			return cb_setClientCRC_Ljava_lang_Long_;
		}

		static void n_SetClientCRC_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientCRC)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long clientCRC = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_clientCRC, JniHandleOwnership.DoNotTransfer);
			__this.ClientCRC = clientCRC;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Long ClientCRC {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSResult']/method[@name='getClientCRC' and count(parameter)=0]"
			[Register ("getClientCRC", "()Ljava/lang/Long;", "GetGetClientCRCHandler")]
			get {
				const string __id = "getClientCRC.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSResult']/method[@name='setClientCRC' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setClientCRC", "(Ljava/lang/Long;)V", "GetSetClientCRC_Ljava_lang_Long_Handler")]
			set {
				const string __id = "setClientCRC.(Ljava/lang/Long;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestId);
		}
#pragma warning restore 0169

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
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string requestId = JNIEnv.GetString (native_requestId, JniHandleOwnership.DoNotTransfer);
			__this.RequestId = requestId;
		}
#pragma warning restore 0169

		public virtual unsafe string RequestId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSResult']/method[@name='getRequestId' and count(parameter)=0]"
			[Register ("getRequestId", "()Ljava/lang/String;", "GetGetRequestIdHandler")]
			get {
				const string __id = "getRequestId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSResult']/method[@name='setRequestId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRequestId", "(Ljava/lang/String;)V", "GetSetRequestId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRequestId.(Ljava/lang/String;)V";
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

		static Delegate cb_getResponseHeader;
#pragma warning disable 0169
		static Delegate GetGetResponseHeaderHandler ()
		{
			if (cb_getResponseHeader == null)
				cb_getResponseHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseHeader);
			return cb_getResponseHeader;
		}

		static IntPtr n_GetResponseHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ResponseHeader);
		}
#pragma warning restore 0169

		static Delegate cb_setResponseHeader_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetResponseHeader_Ljava_util_Map_Handler ()
		{
			if (cb_setResponseHeader_Ljava_util_Map_ == null)
				cb_setResponseHeader_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponseHeader_Ljava_util_Map_);
			return cb_setResponseHeader_Ljava_util_Map_;
		}

		static void n_SetResponseHeader_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_responseHeader)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var responseHeader = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_responseHeader, JniHandleOwnership.DoNotTransfer);
			__this.ResponseHeader = responseHeader;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> ResponseHeader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSResult']/method[@name='getResponseHeader' and count(parameter)=0]"
			[Register ("getResponseHeader", "()Ljava/util/Map;", "GetGetResponseHeaderHandler")]
			get {
				const string __id = "getResponseHeader.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSResult']/method[@name='setResponseHeader' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setResponseHeader", "(Ljava/util/Map;)V", "GetSetResponseHeader_Ljava_util_Map_Handler")]
			set {
				const string __id = "setResponseHeader.(Ljava/util/Map;)V";
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

		static Delegate cb_getServerCRC;
#pragma warning disable 0169
		static Delegate GetGetServerCRCHandler ()
		{
			if (cb_getServerCRC == null)
				cb_getServerCRC = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServerCRC);
			return cb_getServerCRC;
		}

		static IntPtr n_GetServerCRC (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ServerCRC);
		}
#pragma warning restore 0169

		static Delegate cb_setServerCRC_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetServerCRC_Ljava_lang_Long_Handler ()
		{
			if (cb_setServerCRC_Ljava_lang_Long_ == null)
				cb_setServerCRC_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetServerCRC_Ljava_lang_Long_);
			return cb_setServerCRC_Ljava_lang_Long_;
		}

		static void n_SetServerCRC_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverCRC)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long serverCRC = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_serverCRC, JniHandleOwnership.DoNotTransfer);
			__this.ServerCRC = serverCRC;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Long ServerCRC {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSResult']/method[@name='getServerCRC' and count(parameter)=0]"
			[Register ("getServerCRC", "()Ljava/lang/Long;", "GetGetServerCRCHandler")]
			get {
				const string __id = "getServerCRC.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSResult']/method[@name='setServerCRC' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setServerCRC", "(Ljava/lang/Long;)V", "GetSetServerCRC_Ljava_lang_Long_Handler")]
			set {
				const string __id = "setServerCRC.(Ljava/lang/Long;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStatusCode;
#pragma warning disable 0169
		static Delegate GetGetStatusCodeHandler ()
		{
			if (cb_getStatusCode == null)
				cb_getStatusCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatusCode);
			return cb_getStatusCode;
		}

		static int n_GetStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusCode;
		}
#pragma warning restore 0169

		static Delegate cb_setStatusCode_I;
#pragma warning disable 0169
		static Delegate GetSetStatusCode_IHandler ()
		{
			if (cb_setStatusCode_I == null)
				cb_setStatusCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStatusCode_I);
			return cb_setStatusCode_I;
		}

		static void n_SetStatusCode_I (IntPtr jnienv, IntPtr native__this, int statusCode)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StatusCode = statusCode;
		}
#pragma warning restore 0169

		public virtual unsafe int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSResult']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler")]
			get {
				const string __id = "getStatusCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='OSSResult']/method[@name='setStatusCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStatusCode", "(I)V", "GetSetStatusCode_IHandler")]
			set {
				const string __id = "setStatusCode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
