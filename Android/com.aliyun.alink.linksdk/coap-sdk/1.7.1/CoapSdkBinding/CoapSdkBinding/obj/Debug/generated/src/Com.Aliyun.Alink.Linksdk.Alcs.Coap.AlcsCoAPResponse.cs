using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Coap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPResponse']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse", DoNotGenerateAcw=true)]
	public partial class AlcsCoAPResponse : global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse", typeof (AlcsCoAPResponse));
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

		protected AlcsCoAPResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPResponse']/constructor[@name='AlcsCoAPResponse' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPConstant.ResponseCode']]"
		[Register (".ctor", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;)V", "")]
		public unsafe AlcsCoAPResponse (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode code)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((code == null) ? IntPtr.Zero : ((global::Java.Lang.Object) code).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPResponse']/constructor[@name='AlcsCoAPResponse' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe AlcsCoAPResponse (int code)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getCode;
#pragma warning disable 0169
		static Delegate GetGetCodeHandler ()
		{
			if (cb_getCode == null)
				cb_getCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCode);
			return cb_getCode;
		}

		static IntPtr n_GetCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Code);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPResponse']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;", "GetGetCodeHandler")]
			get {
				const string __id = "getCode.()Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasBlockOption;
#pragma warning disable 0169
		static Delegate GetHasBlockOptionHandler ()
		{
			if (cb_hasBlockOption == null)
				cb_hasBlockOption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasBlockOption);
			return cb_hasBlockOption;
		}

		static bool n_HasBlockOption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBlockOption;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasBlockOption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPResponse']/method[@name='hasBlockOption' and count(parameter)=0]"
			[Register ("hasBlockOption", "()Z", "GetHasBlockOptionHandler")]
			get {
				const string __id = "hasBlockOption.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsClientError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPResponse']/method[@name='isClientError' and count(parameter)=0]"
			[Register ("isClientError", "()Z", "")]
			get {
				const string __id = "isClientError.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPResponse']/method[@name='isError' and count(parameter)=0]"
			[Register ("isError", "()Z", "")]
			get {
				const string __id = "isError.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isNotification;
#pragma warning disable 0169
		static Delegate GetIsNotificationHandler ()
		{
			if (cb_isNotification == null)
				cb_isNotification = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNotification);
			return cb_isNotification;
		}

		static bool n_IsNotification (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNotification;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsNotification {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPResponse']/method[@name='isNotification' and count(parameter)=0]"
			[Register ("isNotification", "()Z", "GetIsNotificationHandler")]
			get {
				const string __id = "isNotification.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsServerError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPResponse']/method[@name='isServerError' and count(parameter)=0]"
			[Register ("isServerError", "()Z", "")]
			get {
				const string __id = "isServerError.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isLast;
#pragma warning disable 0169
		static Delegate GetIsLastHandler ()
		{
			if (cb_isLast == null)
				cb_isLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLast);
			return cb_isLast;
		}

		static bool n_IsLast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Last;
		}
#pragma warning restore 0169

		static Delegate cb_setLast_Z;
#pragma warning disable 0169
		static Delegate GetSetLast_ZHandler ()
		{
			if (cb_setLast_Z == null)
				cb_setLast_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetLast_Z);
			return cb_setLast_Z;
		}

		static void n_SetLast_Z (IntPtr jnienv, IntPtr native__this, bool last)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Last = last;
		}
#pragma warning restore 0169

		public virtual unsafe bool Last {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPResponse']/method[@name='isLast' and count(parameter)=0]"
			[Register ("isLast", "()Z", "GetIsLastHandler")]
			get {
				const string __id = "isLast.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPResponse']/method[@name='setLast' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLast", "(Z)V", "GetSetLast_ZHandler")]
			set {
				const string __id = "setLast.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRTT;
#pragma warning disable 0169
		static Delegate GetGetRTTHandler ()
		{
			if (cb_getRTT == null)
				cb_getRTT = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRTT);
			return cb_getRTT;
		}

		static long n_GetRTT (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RTT;
		}
#pragma warning restore 0169

		static Delegate cb_setRTT_J;
#pragma warning disable 0169
		static Delegate GetSetRTT_JHandler ()
		{
			if (cb_setRTT_J == null)
				cb_setRTT_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetRTT_J);
			return cb_setRTT_J;
		}

		static void n_SetRTT_J (IntPtr jnienv, IntPtr native__this, long rtt)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RTT = rtt;
		}
#pragma warning restore 0169

		public virtual unsafe long RTT {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPResponse']/method[@name='getRTT' and count(parameter)=0]"
			[Register ("getRTT", "()J", "GetGetRTTHandler")]
			get {
				const string __id = "getRTT.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPResponse']/method[@name='setRTT' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setRTT", "(J)V", "GetSetRTT_JHandler")]
			set {
				const string __id = "setRTT.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRawCode;
#pragma warning disable 0169
		static Delegate GetGetRawCodeHandler ()
		{
			if (cb_getRawCode == null)
				cb_getRawCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRawCode);
			return cb_getRawCode;
		}

		static int n_GetRawCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RawCode;
		}
#pragma warning restore 0169

		public override unsafe int RawCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPResponse']/method[@name='getRawCode' and count(parameter)=0]"
			[Register ("getRawCode", "()I", "GetGetRawCodeHandler")]
			get {
				const string __id = "getRawCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPResponse']/method[@name='createResponse' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPRequest'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPConstant.ResponseCode']]"
		[Register ("createResponse", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;", "")]
		public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse CreateResponse (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode code)
		{
			const string __id = "createResponse.(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((code == null) ? IntPtr.Zero : ((global::Java.Lang.Object) code).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPResponse']/method[@name='setObserve' and count(parameter)=0]"
		[Register ("setObserve", "()Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;", "")]
		public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse SetObserve ()
		{
			const string __id = "setObserve.()Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setResponseCode_I;
#pragma warning disable 0169
		static Delegate GetSetResponseCode_IHandler ()
		{
			if (cb_setResponseCode_I == null)
				cb_setResponseCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetResponseCode_I);
			return cb_setResponseCode_I;
		}

		static void n_SetResponseCode_I (IntPtr jnienv, IntPtr native__this, int code)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetResponseCode (code);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPResponse']/method[@name='setResponseCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setResponseCode", "(I)V", "GetSetResponseCode_IHandler")]
		public virtual unsafe void SetResponseCode (int code)
		{
			const string __id = "setResponseCode.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
