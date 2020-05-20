using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Api.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorInfo']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/api/utils/ErrorInfo", DoNotGenerateAcw=true)]
	public partial class ErrorInfo : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorInfo']/field[@name='mErrorCode']"
		[Register ("mErrorCode")]
		protected int MErrorCode {
			get {
				const string __id = "mErrorCode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mErrorCode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorInfo']/field[@name='mErrorMsg']"
		[Register ("mErrorMsg")]
		protected string MErrorMsg {
			get {
				const string __id = "mErrorMsg.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mErrorMsg.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/api/utils/ErrorInfo", typeof (ErrorInfo));
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

		protected ErrorInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorInfo']/constructor[@name='ErrorInfo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe ErrorInfo (int errorCode, string errorMsg)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_errorMsg = JNIEnv.NewString (errorMsg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (errorCode);
				__args [1] = new JniArgumentValue (native_errorMsg);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorMsg);
			}
		}

		static Delegate cb_getErrorCode;
#pragma warning disable 0169
		static Delegate GetGetErrorCodeHandler ()
		{
			if (cb_getErrorCode == null)
				cb_getErrorCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetErrorCode);
			return cb_getErrorCode;
		}

		static int n_GetErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Utils.ErrorInfo __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Utils.ErrorInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ErrorCode;
		}
#pragma warning restore 0169

		static Delegate cb_setErrorCode_I;
#pragma warning disable 0169
		static Delegate GetSetErrorCode_IHandler ()
		{
			if (cb_setErrorCode_I == null)
				cb_setErrorCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetErrorCode_I);
			return cb_setErrorCode_I;
		}

		static void n_SetErrorCode_I (IntPtr jnienv, IntPtr native__this, int errorCode)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Utils.ErrorInfo __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Utils.ErrorInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ErrorCode = errorCode;
		}
#pragma warning restore 0169

		public virtual unsafe int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorInfo']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()I", "GetGetErrorCodeHandler")]
			get {
				const string __id = "getErrorCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorInfo']/method[@name='setErrorCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setErrorCode", "(I)V", "GetSetErrorCode_IHandler")]
			set {
				const string __id = "setErrorCode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getErrorMsg;
#pragma warning disable 0169
		static Delegate GetGetErrorMsgHandler ()
		{
			if (cb_getErrorMsg == null)
				cb_getErrorMsg = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorMsg);
			return cb_getErrorMsg;
		}

		static IntPtr n_GetErrorMsg (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Utils.ErrorInfo __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Utils.ErrorInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorMsg);
		}
#pragma warning restore 0169

		static Delegate cb_setErrorMsg_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetErrorMsg_Ljava_lang_String_Handler ()
		{
			if (cb_setErrorMsg_Ljava_lang_String_ == null)
				cb_setErrorMsg_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetErrorMsg_Ljava_lang_String_);
			return cb_setErrorMsg_Ljava_lang_String_;
		}

		static void n_SetErrorMsg_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_errorMsg)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Utils.ErrorInfo __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Utils.ErrorInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string errorMsg = JNIEnv.GetString (native_errorMsg, JniHandleOwnership.DoNotTransfer);
			__this.ErrorMsg = errorMsg;
		}
#pragma warning restore 0169

		public virtual unsafe string ErrorMsg {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorInfo']/method[@name='getErrorMsg' and count(parameter)=0]"
			[Register ("getErrorMsg", "()Ljava/lang/String;", "GetGetErrorMsgHandler")]
			get {
				const string __id = "getErrorMsg.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorInfo']/method[@name='setErrorMsg' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setErrorMsg", "(Ljava/lang/String;)V", "GetSetErrorMsg_Ljava_lang_String_Handler")]
			set {
				const string __id = "setErrorMsg.(Ljava/lang/String;)V";
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

	}
}
