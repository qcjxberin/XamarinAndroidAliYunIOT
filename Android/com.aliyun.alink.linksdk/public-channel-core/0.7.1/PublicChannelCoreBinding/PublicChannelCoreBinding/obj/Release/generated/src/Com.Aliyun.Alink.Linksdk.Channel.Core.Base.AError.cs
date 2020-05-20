using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Core.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/core/base/AError", DoNotGenerateAcw=true)]
	public partial class AError : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/field[@name='AKErrorInvokeNetError']"
		[Register ("AKErrorInvokeNetError")]
		public const int AKErrorInvokeNetError = (int) 4101;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/field[@name='AKErrorInvokeServerError']"
		[Register ("AKErrorInvokeServerError")]
		public const int AKErrorInvokeServerError = (int) 4102;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/field[@name='AKErrorLoginTokenIllegalError']"
		[Register ("AKErrorLoginTokenIllegalError")]
		public const int AKErrorLoginTokenIllegalError = (int) 4001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/field[@name='AKErrorServerBusinessError']"
		[Register ("AKErrorServerBusinessError")]
		public const int AKErrorServerBusinessError = (int) 4103;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/field[@name='AKErrorSuccess']"
		[Register ("AKErrorSuccess")]
		public const int AKErrorSuccess = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/field[@name='AKErrorUnknownError']"
		[Register ("AKErrorUnknownError")]
		public const int AKErrorUnknownError = (int) 4201;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/field[@name='ERR_DOMAIN_NAME_ALINK']"
		[Register ("ERR_DOMAIN_NAME_ALINK")]
		public const string ErrDomainNameAlink = (string) "alinkErrorDomain";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/core/base/AError", typeof (AError));
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

		protected AError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/constructor[@name='AError' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AError ()
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

		static Delegate cb_getCode;
#pragma warning disable 0169
		static Delegate GetGetCodeHandler ()
		{
			if (cb_getCode == null)
				cb_getCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCode);
			return cb_getCode;
		}

		static int n_GetCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Code;
		}
#pragma warning restore 0169

		static Delegate cb_setCode_I;
#pragma warning disable 0169
		static Delegate GetSetCode_IHandler ()
		{
			if (cb_setCode_I == null)
				cb_setCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCode_I);
			return cb_setCode_I;
		}

		static void n_SetCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Code = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()I", "GetGetCodeHandler")]
			get {
				const string __id = "getCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/method[@name='setCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCode", "(I)V", "GetSetCode_IHandler")]
			set {
				const string __id = "setCode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDomain;
#pragma warning disable 0169
		static Delegate GetGetDomainHandler ()
		{
			if (cb_getDomain == null)
				cb_getDomain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDomain);
			return cb_getDomain;
		}

		static IntPtr n_GetDomain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Domain);
		}
#pragma warning restore 0169

		static Delegate cb_setDomain_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDomain_Ljava_lang_String_Handler ()
		{
			if (cb_setDomain_Ljava_lang_String_ == null)
				cb_setDomain_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDomain_Ljava_lang_String_);
			return cb_setDomain_Ljava_lang_String_;
		}

		static void n_SetDomain_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Domain = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Domain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/method[@name='getDomain' and count(parameter)=0]"
			[Register ("getDomain", "()Ljava/lang/String;", "GetGetDomainHandler")]
			get {
				const string __id = "getDomain.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/method[@name='setDomain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDomain", "(Ljava/lang/String;)V", "GetSetDomain_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDomain.(Ljava/lang/String;)V";
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

		static Delegate cb_getMsg;
#pragma warning disable 0169
		static Delegate GetGetMsgHandler ()
		{
			if (cb_getMsg == null)
				cb_getMsg = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMsg);
			return cb_getMsg;
		}

		static IntPtr n_GetMsg (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Msg);
		}
#pragma warning restore 0169

		static Delegate cb_setMsg_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMsg_Ljava_lang_String_Handler ()
		{
			if (cb_setMsg_Ljava_lang_String_ == null)
				cb_setMsg_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMsg_Ljava_lang_String_);
			return cb_setMsg_Ljava_lang_String_;
		}

		static void n_SetMsg_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Msg = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Msg {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/method[@name='getMsg' and count(parameter)=0]"
			[Register ("getMsg", "()Ljava/lang/String;", "GetGetMsgHandler")]
			get {
				const string __id = "getMsg.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/method[@name='setMsg' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMsg", "(Ljava/lang/String;)V", "GetSetMsg_Ljava_lang_String_Handler")]
			set {
				const string __id = "setMsg.(Ljava/lang/String;)V";
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

		static Delegate cb_getOriginResponseObject;
#pragma warning disable 0169
		static Delegate GetGetOriginResponseObjectHandler ()
		{
			if (cb_getOriginResponseObject == null)
				cb_getOriginResponseObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOriginResponseObject);
			return cb_getOriginResponseObject;
		}

		static IntPtr n_GetOriginResponseObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OriginResponseObject);
		}
#pragma warning restore 0169

		static Delegate cb_setOriginResponseObject_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetOriginResponseObject_Ljava_lang_Object_Handler ()
		{
			if (cb_setOriginResponseObject_Ljava_lang_Object_ == null)
				cb_setOriginResponseObject_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOriginResponseObject_Ljava_lang_Object_);
			return cb_setOriginResponseObject_Ljava_lang_Object_;
		}

		static void n_SetOriginResponseObject_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OriginResponseObject = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object OriginResponseObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/method[@name='getOriginResponseObject' and count(parameter)=0]"
			[Register ("getOriginResponseObject", "()Ljava/lang/Object;", "GetGetOriginResponseObjectHandler")]
			get {
				const string __id = "getOriginResponseObject.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/method[@name='setOriginResponseObject' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setOriginResponseObject", "(Ljava/lang/Object;)V", "GetSetOriginResponseObject_Ljava_lang_Object_Handler")]
			set {
				const string __id = "setOriginResponseObject.(Ljava/lang/Object;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSubCode;
#pragma warning disable 0169
		static Delegate GetGetSubCodeHandler ()
		{
			if (cb_getSubCode == null)
				cb_getSubCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSubCode);
			return cb_getSubCode;
		}

		static int n_GetSubCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SubCode;
		}
#pragma warning restore 0169

		static Delegate cb_setSubCode_I;
#pragma warning disable 0169
		static Delegate GetSetSubCode_IHandler ()
		{
			if (cb_setSubCode_I == null)
				cb_setSubCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSubCode_I);
			return cb_setSubCode_I;
		}

		static void n_SetSubCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SubCode = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int SubCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/method[@name='getSubCode' and count(parameter)=0]"
			[Register ("getSubCode", "()I", "GetGetSubCodeHandler")]
			get {
				const string __id = "getSubCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/method[@name='setSubCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSubCode", "(I)V", "GetSetSubCode_IHandler")]
			set {
				const string __id = "setSubCode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSubDomain;
#pragma warning disable 0169
		static Delegate GetGetSubDomainHandler ()
		{
			if (cb_getSubDomain == null)
				cb_getSubDomain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubDomain);
			return cb_getSubDomain;
		}

		static IntPtr n_GetSubDomain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SubDomain);
		}
#pragma warning restore 0169

		static Delegate cb_setSubDomain_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSubDomain_Ljava_lang_String_Handler ()
		{
			if (cb_setSubDomain_Ljava_lang_String_ == null)
				cb_setSubDomain_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSubDomain_Ljava_lang_String_);
			return cb_setSubDomain_Ljava_lang_String_;
		}

		static void n_SetSubDomain_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SubDomain = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string SubDomain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/method[@name='getSubDomain' and count(parameter)=0]"
			[Register ("getSubDomain", "()Ljava/lang/String;", "GetGetSubDomainHandler")]
			get {
				const string __id = "getSubDomain.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/method[@name='setSubDomain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSubDomain", "(Ljava/lang/String;)V", "GetSetSubDomain_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSubDomain.(Ljava/lang/String;)V";
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

		static Delegate cb_getSubMsg;
#pragma warning disable 0169
		static Delegate GetGetSubMsgHandler ()
		{
			if (cb_getSubMsg == null)
				cb_getSubMsg = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubMsg);
			return cb_getSubMsg;
		}

		static IntPtr n_GetSubMsg (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SubMsg);
		}
#pragma warning restore 0169

		static Delegate cb_setSubMsg_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSubMsg_Ljava_lang_String_Handler ()
		{
			if (cb_setSubMsg_Ljava_lang_String_ == null)
				cb_setSubMsg_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSubMsg_Ljava_lang_String_);
			return cb_setSubMsg_Ljava_lang_String_;
		}

		static void n_SetSubMsg_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SubMsg = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string SubMsg {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/method[@name='getSubMsg' and count(parameter)=0]"
			[Register ("getSubMsg", "()Ljava/lang/String;", "GetGetSubMsgHandler")]
			get {
				const string __id = "getSubMsg.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='AError']/method[@name='setSubMsg' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSubMsg", "(Ljava/lang/String;)V", "GetSetSubMsg_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSubMsg.(Ljava/lang/String;)V";
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
