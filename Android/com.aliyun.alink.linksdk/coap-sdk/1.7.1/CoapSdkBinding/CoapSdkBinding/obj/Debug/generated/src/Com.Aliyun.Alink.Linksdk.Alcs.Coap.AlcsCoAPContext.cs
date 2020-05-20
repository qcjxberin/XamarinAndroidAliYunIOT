using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Coap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPContext']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPContext", DoNotGenerateAcw=true)]
	public partial class AlcsCoAPContext : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPContext']/field[@name='mAddress']"
		[Register ("mAddress")]
		protected string MAddress {
			get {
				const string __id = "mAddress.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAddress.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPContext']/field[@name='mContextId']"
		[Register ("mContextId")]
		protected long MContextId {
			get {
				const string __id = "mContextId.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mContextId.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPContext']/field[@name='mPort']"
		[Register ("mPort")]
		protected int MPort {
			get {
				const string __id = "mPort.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mPort.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPContext']/field[@name='mWaitTime']"
		[Register ("mWaitTime")]
		protected int MWaitTime {
			get {
				const string __id = "mWaitTime.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mWaitTime.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPContext", typeof (AlcsCoAPContext));
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

		protected AlcsCoAPContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPContext']/constructor[@name='AlcsCoAPContext' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AlcsCoAPContext ()
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

		static Delegate cb_getAddress;
#pragma warning disable 0169
		static Delegate GetGetAddressHandler ()
		{
			if (cb_getAddress == null)
				cb_getAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddress);
			return cb_getAddress;
		}

		static IntPtr n_GetAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Address);
		}
#pragma warning restore 0169

		static Delegate cb_setAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAddress_Ljava_lang_String_Handler ()
		{
			if (cb_setAddress_Ljava_lang_String_ == null)
				cb_setAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAddress_Ljava_lang_String_);
			return cb_setAddress_Ljava_lang_String_;
		}

		static void n_SetAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mAddress)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string mAddress = JNIEnv.GetString (native_mAddress, JniHandleOwnership.DoNotTransfer);
			__this.Address = mAddress;
		}
#pragma warning restore 0169

		public virtual unsafe string Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPContext']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Ljava/lang/String;", "GetGetAddressHandler")]
			get {
				const string __id = "getAddress.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPContext']/method[@name='setAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAddress", "(Ljava/lang/String;)V", "GetSetAddress_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAddress.(Ljava/lang/String;)V";
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

		static Delegate cb_getContextId;
#pragma warning disable 0169
		static Delegate GetGetContextIdHandler ()
		{
			if (cb_getContextId == null)
				cb_getContextId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetContextId);
			return cb_getContextId;
		}

		static long n_GetContextId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContextId;
		}
#pragma warning restore 0169

		static Delegate cb_setContextId_J;
#pragma warning disable 0169
		static Delegate GetSetContextId_JHandler ()
		{
			if (cb_setContextId_J == null)
				cb_setContextId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetContextId_J);
			return cb_setContextId_J;
		}

		static void n_SetContextId_J (IntPtr jnienv, IntPtr native__this, long mContextId)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ContextId = mContextId;
		}
#pragma warning restore 0169

		public virtual unsafe long ContextId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPContext']/method[@name='getContextId' and count(parameter)=0]"
			[Register ("getContextId", "()J", "GetGetContextIdHandler")]
			get {
				const string __id = "getContextId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPContext']/method[@name='setContextId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setContextId", "(J)V", "GetSetContextId_JHandler")]
			set {
				const string __id = "setContextId.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPort;
#pragma warning disable 0169
		static Delegate GetGetPortHandler ()
		{
			if (cb_getPort == null)
				cb_getPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPort);
			return cb_getPort;
		}

		static int n_GetPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Port;
		}
#pragma warning restore 0169

		static Delegate cb_setPort_I;
#pragma warning disable 0169
		static Delegate GetSetPort_IHandler ()
		{
			if (cb_setPort_I == null)
				cb_setPort_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPort_I);
			return cb_setPort_I;
		}

		static void n_SetPort_I (IntPtr jnienv, IntPtr native__this, int mPort)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Port = mPort;
		}
#pragma warning restore 0169

		public virtual unsafe int Port {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPContext']/method[@name='getPort' and count(parameter)=0]"
			[Register ("getPort", "()I", "GetGetPortHandler")]
			get {
				const string __id = "getPort.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPContext']/method[@name='setPort' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPort", "(I)V", "GetSetPort_IHandler")]
			set {
				const string __id = "setPort.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWaitTime;
#pragma warning disable 0169
		static Delegate GetGetWaitTimeHandler ()
		{
			if (cb_getWaitTime == null)
				cb_getWaitTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWaitTime);
			return cb_getWaitTime;
		}

		static int n_GetWaitTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WaitTime;
		}
#pragma warning restore 0169

		static Delegate cb_setWaitTime_I;
#pragma warning disable 0169
		static Delegate GetSetWaitTime_IHandler ()
		{
			if (cb_setWaitTime_I == null)
				cb_setWaitTime_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWaitTime_I);
			return cb_setWaitTime_I;
		}

		static void n_SetWaitTime_I (IntPtr jnienv, IntPtr native__this, int mWaitTime)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaitTime = mWaitTime;
		}
#pragma warning restore 0169

		public virtual unsafe int WaitTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPContext']/method[@name='getWaitTime' and count(parameter)=0]"
			[Register ("getWaitTime", "()I", "GetGetWaitTimeHandler")]
			get {
				const string __id = "getWaitTime.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPContext']/method[@name='setWaitTime' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWaitTime", "(I)V", "GetSetWaitTime_IHandler")]
			set {
				const string __id = "setWaitTime.(I)V";
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
