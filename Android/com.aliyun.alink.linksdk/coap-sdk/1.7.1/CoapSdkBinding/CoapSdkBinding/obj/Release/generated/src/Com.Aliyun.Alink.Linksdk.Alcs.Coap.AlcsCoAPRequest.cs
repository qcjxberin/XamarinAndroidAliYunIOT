using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Coap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest", DoNotGenerateAcw=true)]
	public partial class AlcsCoAPRequest : global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPMessage {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest", typeof (AlcsCoAPRequest));
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

		protected AlcsCoAPRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/constructor[@name='AlcsCoAPRequest' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPConstant.Code']]"
		[Register (".ctor", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Code;)V", "")]
		public unsafe AlcsCoAPRequest (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Code code)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Code;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/constructor[@name='AlcsCoAPRequest' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPConstant.Code'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPConstant.Type']]"
		[Register (".ctor", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Code;Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type;)V", "")]
		public unsafe AlcsCoAPRequest (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Code code, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type type)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Code;Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((code == null) ? IntPtr.Zero : ((global::Java.Lang.Object) code).Handle);
				__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/constructor[@name='AlcsCoAPRequest' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe AlcsCoAPRequest (int code)
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Code);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Code Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Code;", "GetGetCodeHandler")]
			get {
				const string __id = "getCode.()Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Code;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Code> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsObserve {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/method[@name='isObserve' and count(parameter)=0]"
			[Register ("isObserve", "()Z", "")]
			get {
				const string __id = "isObserve.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RawCode;
		}
#pragma warning restore 0169

		public override unsafe int RawCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/method[@name='getRawCode' and count(parameter)=0]"
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

		static Delegate cb_getScheme;
#pragma warning disable 0169
		static Delegate GetGetSchemeHandler ()
		{
			if (cb_getScheme == null)
				cb_getScheme = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScheme);
			return cb_getScheme;
		}

		static IntPtr n_GetScheme (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Scheme);
		}
#pragma warning restore 0169

		static Delegate cb_setScheme_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetScheme_Ljava_lang_String_Handler ()
		{
			if (cb_setScheme_Ljava_lang_String_ == null)
				cb_setScheme_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScheme_Ljava_lang_String_);
			return cb_setScheme_Ljava_lang_String_;
		}

		static void n_SetScheme_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scheme)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string scheme = JNIEnv.GetString (native_scheme, JniHandleOwnership.DoNotTransfer);
			__this.Scheme = scheme;
		}
#pragma warning restore 0169

		public virtual unsafe string Scheme {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/method[@name='getScheme' and count(parameter)=0]"
			[Register ("getScheme", "()Ljava/lang/String;", "GetGetSchemeHandler")]
			get {
				const string __id = "getScheme.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/method[@name='setScheme' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setScheme", "(Ljava/lang/String;)V", "GetSetScheme_Ljava_lang_String_Handler")]
			set {
				const string __id = "setScheme.(Ljava/lang/String;)V";
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

		static Delegate cb_getSenderIdentity;
#pragma warning disable 0169
		static Delegate GetGetSenderIdentityHandler ()
		{
			if (cb_getSenderIdentity == null)
				cb_getSenderIdentity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSenderIdentity);
			return cb_getSenderIdentity;
		}

		static IntPtr n_GetSenderIdentity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SenderIdentity);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Security.IPrincipal SenderIdentity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/method[@name='getSenderIdentity' and count(parameter)=0]"
			[Register ("getSenderIdentity", "()Ljava/security/Principal;", "GetGetSenderIdentityHandler")]
			get {
				const string __id = "getSenderIdentity.()Ljava/security/Principal;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Security.IPrincipal> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getURI;
#pragma warning disable 0169
		static Delegate GetGetURIHandler ()
		{
			if (cb_getURI == null)
				cb_getURI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetURI);
			return cb_getURI;
		}

		static IntPtr n_GetURI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.URI);
		}
#pragma warning restore 0169

		public virtual unsafe string URI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/method[@name='getURI' and count(parameter)=0]"
			[Register ("getURI", "()Ljava/lang/String;", "GetGetURIHandler")]
			get {
				const string __id = "getURI.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserContext;
#pragma warning disable 0169
		static Delegate GetGetUserContextHandler ()
		{
			if (cb_getUserContext == null)
				cb_getUserContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserContext);
			return cb_getUserContext;
		}

		static IntPtr n_GetUserContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.UserContext);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> UserContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/method[@name='getUserContext' and count(parameter)=0]"
			[Register ("getUserContext", "()Ljava/util/Map;", "GetGetUserContextHandler")]
			get {
				const string __id = "getUserContext.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/method[@name='newDelete' and count(parameter)=0]"
		[Register ("newDelete", "()Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;", "")]
		public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest NewDelete ()
		{
			const string __id = "newDelete.()Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/method[@name='newGet' and count(parameter)=0]"
		[Register ("newGet", "()Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;", "")]
		public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest NewGet ()
		{
			const string __id = "newGet.()Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/method[@name='newPost' and count(parameter)=0]"
		[Register ("newPost", "()Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;", "")]
		public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest NewPost ()
		{
			const string __id = "newPost.()Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/method[@name='newPut' and count(parameter)=0]"
		[Register ("newPut", "()Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;", "")]
		public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest NewPut ()
		{
			const string __id = "newPut.()Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/method[@name='setObserve' and count(parameter)=0]"
		[Register ("setObserve", "()Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;", "")]
		public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest SetObserve ()
		{
			const string __id = "setObserve.()Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/method[@name='setObserveCancel' and count(parameter)=0]"
		[Register ("setObserveCancel", "()Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;", "")]
		public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest SetObserveCancel ()
		{
			const string __id = "setObserveCancel.()Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOptions_Ljava_net_URI_;
#pragma warning disable 0169
		static Delegate GetSetOptions_Ljava_net_URI_Handler ()
		{
			if (cb_setOptions_Ljava_net_URI_ == null)
				cb_setOptions_Ljava_net_URI_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOptions_Ljava_net_URI_);
			return cb_setOptions_Ljava_net_URI_;
		}

		static IntPtr n_SetOptions_Ljava_net_URI_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URI uri = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOptions (uri));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='java.net.URI']]"
		[Register ("setOptions", "(Ljava/net/URI;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;", "GetSetOptions_Ljava_net_URI_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest SetOptions (global::Java.Net.URI uri)
		{
			const string __id = "setOptions.(Ljava/net/URI;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRequestCode_I;
#pragma warning disable 0169
		static Delegate GetSetRequestCode_IHandler ()
		{
			if (cb_setRequestCode_I == null)
				cb_setRequestCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRequestCode_I);
			return cb_setRequestCode_I;
		}

		static void n_SetRequestCode_I (IntPtr jnienv, IntPtr native__this, int code)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestCode (code);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/method[@name='setRequestCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRequestCode", "(I)V", "GetSetRequestCode_IHandler")]
		public virtual unsafe void SetRequestCode (int code)
		{
			const string __id = "setRequestCode.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSenderIdentity_Ljava_security_Principal_;
#pragma warning disable 0169
		static Delegate GetSetSenderIdentity_Ljava_security_Principal_Handler ()
		{
			if (cb_setSenderIdentity_Ljava_security_Principal_ == null)
				cb_setSenderIdentity_Ljava_security_Principal_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSenderIdentity_Ljava_security_Principal_);
			return cb_setSenderIdentity_Ljava_security_Principal_;
		}

		static IntPtr n_SetSenderIdentity_Ljava_security_Principal_ (IntPtr jnienv, IntPtr native__this, IntPtr native_senderIdentity)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.IPrincipal senderIdentity = (global::Java.Security.IPrincipal)global::Java.Lang.Object.GetObject<global::Java.Security.IPrincipal> (native_senderIdentity, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSenderIdentity (senderIdentity));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/method[@name='setSenderIdentity' and count(parameter)=1 and parameter[1][@type='java.security.Principal']]"
		[Register ("setSenderIdentity", "(Ljava/security/Principal;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;", "GetSetSenderIdentity_Ljava_security_Principal_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest SetSenderIdentity (global::Java.Security.IPrincipal senderIdentity)
		{
			const string __id = "setSenderIdentity.(Ljava/security/Principal;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((senderIdentity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) senderIdentity).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setURI_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetURI_Ljava_lang_String_Handler ()
		{
			if (cb_setURI_Ljava_lang_String_ == null)
				cb_setURI_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetURI_Ljava_lang_String_);
			return cb_setURI_Ljava_lang_String_;
		}

		static IntPtr n_SetURI_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetURI (uri));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/method[@name='setURI' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setURI", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;", "GetSetURI_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest SetURI (string uri)
		{
			const string __id = "setURI.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;";
			IntPtr native_uri = JNIEnv.NewString (uri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_uri);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_uri);
			}
		}

		static Delegate cb_setURI_Ljava_net_URI_;
#pragma warning disable 0169
		static Delegate GetSetURI_Ljava_net_URI_Handler ()
		{
			if (cb_setURI_Ljava_net_URI_ == null)
				cb_setURI_Ljava_net_URI_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetURI_Ljava_net_URI_);
			return cb_setURI_Ljava_net_URI_;
		}

		static IntPtr n_SetURI_Ljava_net_URI_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URI uri = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetURI (uri));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/method[@name='setURI' and count(parameter)=1 and parameter[1][@type='java.net.URI']]"
		[Register ("setURI", "(Ljava/net/URI;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;", "GetSetURI_Ljava_net_URI_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest SetURI (global::Java.Net.URI uri)
		{
			const string __id = "setURI.(Ljava/net/URI;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setUserContext_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetUserContext_Ljava_util_Map_Handler ()
		{
			if (cb_setUserContext_Ljava_util_Map_ == null)
				cb_setUserContext_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUserContext_Ljava_util_Map_);
			return cb_setUserContext_Ljava_util_Map_;
		}

		static IntPtr n_SetUserContext_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userContext)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var userContext = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_userContext, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUserContext (userContext));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPRequest']/method[@name='setUserContext' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setUserContext", "(Ljava/util/Map;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;", "GetSetUserContext_Ljava_util_Map_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest SetUserContext (global::System.Collections.Generic.IDictionary<string, string> userContext)
		{
			const string __id = "setUserContext.(Ljava/util/Map;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;";
			IntPtr native_userContext = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (userContext);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_userContext);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_userContext);
			}
		}

	}
}
