using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ServiceException']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/ServiceException", DoNotGenerateAcw=true)]
	public partial class ServiceException : global::Java.Lang.Exception {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/ServiceException", typeof (ServiceException));
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

		protected ServiceException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ServiceException']/constructor[@name='ServiceException' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ServiceException (int statusCode, string message, string errorCode, string requestId, string hostId, string rawMessage)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_errorCode = JNIEnv.NewString (errorCode);
			IntPtr native_requestId = JNIEnv.NewString (requestId);
			IntPtr native_hostId = JNIEnv.NewString (hostId);
			IntPtr native_rawMessage = JNIEnv.NewString (rawMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (statusCode);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue (native_errorCode);
				__args [3] = new JniArgumentValue (native_requestId);
				__args [4] = new JniArgumentValue (native_hostId);
				__args [5] = new JniArgumentValue (native_rawMessage);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				JNIEnv.DeleteLocalRef (native_errorCode);
				JNIEnv.DeleteLocalRef (native_requestId);
				JNIEnv.DeleteLocalRef (native_hostId);
				JNIEnv.DeleteLocalRef (native_rawMessage);
			}
		}

		static Delegate cb_getErrorCode;
#pragma warning disable 0169
		static Delegate GetGetErrorCodeHandler ()
		{
			if (cb_getErrorCode == null)
				cb_getErrorCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorCode);
			return cb_getErrorCode;
		}

		static IntPtr n_GetErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ServiceException __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ServiceException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorCode);
		}
#pragma warning restore 0169

		public virtual unsafe string ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ServiceException']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()Ljava/lang/String;", "GetGetErrorCodeHandler")]
			get {
				const string __id = "getErrorCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHostId;
#pragma warning disable 0169
		static Delegate GetGetHostIdHandler ()
		{
			if (cb_getHostId == null)
				cb_getHostId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHostId);
			return cb_getHostId;
		}

		static IntPtr n_GetHostId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ServiceException __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ServiceException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HostId);
		}
#pragma warning restore 0169

		public virtual unsafe string HostId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ServiceException']/method[@name='getHostId' and count(parameter)=0]"
			[Register ("getHostId", "()Ljava/lang/String;", "GetGetHostIdHandler")]
			get {
				const string __id = "getHostId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRawMessage;
#pragma warning disable 0169
		static Delegate GetGetRawMessageHandler ()
		{
			if (cb_getRawMessage == null)
				cb_getRawMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRawMessage);
			return cb_getRawMessage;
		}

		static IntPtr n_GetRawMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ServiceException __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ServiceException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RawMessage);
		}
#pragma warning restore 0169

		public virtual unsafe string RawMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ServiceException']/method[@name='getRawMessage' and count(parameter)=0]"
			[Register ("getRawMessage", "()Ljava/lang/String;", "GetGetRawMessageHandler")]
			get {
				const string __id = "getRawMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Alibaba.Sdk.Android.Oss.ServiceException __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ServiceException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestId);
		}
#pragma warning restore 0169

		public virtual unsafe string RequestId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ServiceException']/method[@name='getRequestId' and count(parameter)=0]"
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
			global::Com.Alibaba.Sdk.Android.Oss.ServiceException __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ServiceException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusCode;
		}
#pragma warning restore 0169

		public virtual unsafe int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ServiceException']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler")]
			get {
				const string __id = "getStatusCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.ServiceException __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ServiceException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/class[@name='ServiceException']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "GetToStringHandler")]
		public override unsafe string ToString ()
		{
			const string __id = "toString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
