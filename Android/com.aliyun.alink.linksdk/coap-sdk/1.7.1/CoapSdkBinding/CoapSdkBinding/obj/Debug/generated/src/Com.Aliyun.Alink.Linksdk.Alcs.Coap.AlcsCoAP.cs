using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Coap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAP", DoNotGenerateAcw=true)]
	public partial class AlcsCoAP : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/field[@name='TAG']"
		[Register ("TAG")]
		protected const string Tag = (string) "[alcs_coap_sdk]AlcsCoAP";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/field[@name='mAuthHandlerList']"
		[Register ("mAuthHandlerList")]
		protected static global::Android.Util.SparseArray MAuthHandlerList {
			get {
				const string __id = "mAuthHandlerList.Landroid/util/SparseArray;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Util.SparseArray> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAuthHandlerList.Landroid/util/SparseArray;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/field[@name='mContextList']"
		[Register ("mContextList")]
		protected static global::System.Collections.IDictionary MContextList {
			get {
				const string __id = "mContextList.Ljava/util/Map;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mContextList.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/field[@name='mReqHandlerList']"
		[Register ("mReqHandlerList")]
		protected static global::System.Collections.IDictionary MReqHandlerList {
			get {
				const string __id = "mReqHandlerList.Ljava/util/Map;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mReqHandlerList.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/field[@name='mResourceList']"
		[Register ("mResourceList")]
		protected static global::System.Collections.IDictionary MResourceList {
			get {
				const string __id = "mResourceList.Ljava/util/Map;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mResourceList.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/field[@name='mUserData']"
		[Register ("mUserData")]
		protected static global::Java.Util.Concurrent.Atomic.AtomicInteger MUserData {
			get {
				const string __id = "mUserData.Ljava/util/concurrent/atomic/AtomicInteger;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.Atomic.AtomicInteger> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mUserData.Ljava/util/concurrent/atomic/AtomicInteger;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAP", typeof (AlcsCoAP));
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

		protected AlcsCoAP (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/constructor[@name='AlcsCoAP' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AlcsCoAP ()
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

		static Delegate cb_addAlcsSvrAccessKey_JLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddAlcsSvrAccessKey_JLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addAlcsSvrAccessKey_JLjava_lang_String_Ljava_lang_String_ == null)
				cb_addAlcsSvrAccessKey_JLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, bool>) n_AddAlcsSvrAccessKey_JLjava_lang_String_Ljava_lang_String_);
			return cb_addAlcsSvrAccessKey_JLjava_lang_String_Ljava_lang_String_;
		}

		static bool n_AddAlcsSvrAccessKey_JLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long coapContextId, IntPtr native_prefix, IntPtr native_secret)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string prefix = JNIEnv.GetString (native_prefix, JniHandleOwnership.DoNotTransfer);
			string secret = JNIEnv.GetString (native_secret, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAlcsSvrAccessKey (coapContextId, prefix, secret);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='addAlcsSvrAccessKey' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("addAlcsSvrAccessKey", "(JLjava/lang/String;Ljava/lang/String;)Z", "GetAddAlcsSvrAccessKey_JLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool AddAlcsSvrAccessKey (long coapContextId, string prefix, string secret)
		{
			const string __id = "addAlcsSvrAccessKey.(JLjava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_prefix = JNIEnv.NewString (prefix);
			IntPtr native_secret = JNIEnv.NewString (secret);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (coapContextId);
				__args [1] = new JniArgumentValue (native_prefix);
				__args [2] = new JniArgumentValue (native_secret);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
				JNIEnv.DeleteLocalRef (native_secret);
			}
		}

		static Delegate cb_addIntOption_JJII;
#pragma warning disable 0169
		static Delegate GetAddIntOption_JJIIHandler ()
		{
			if (cb_addIntOption_JJII == null)
				cb_addIntOption_JJII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long, int, int>) n_AddIntOption_JJII);
			return cb_addIntOption_JJII;
		}

		static void n_AddIntOption_JJII (IntPtr jnienv, IntPtr native__this, long p0, long p1, int p2, int p3)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddIntOption (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='addIntOption' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("addIntOption", "(JJII)V", "GetAddIntOption_JJIIHandler")]
		protected virtual unsafe void AddIntOption (long p0, long p1, int p2, int p3)
		{
			const string __id = "addIntOption.(JJII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addKey_Ljava_lang_String_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddKey_Ljava_lang_String_IILjava_lang_String_Handler ()
		{
			if (cb_addKey_Ljava_lang_String_IILjava_lang_String_ == null)
				cb_addKey_Ljava_lang_String_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr, bool>) n_AddKey_Ljava_lang_String_IILjava_lang_String_);
			return cb_addKey_Ljava_lang_String_IILjava_lang_String_;
		}

		static bool n_AddKey_Ljava_lang_String_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddKey (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='addKey' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("addKey", "(Ljava/lang/String;IILjava/lang/String;)Z", "GetAddKey_Ljava_lang_String_IILjava_lang_String_Handler")]
		protected virtual unsafe bool AddKey (string p0, int p1, int p2, string p3)
		{
			const string __id = "addKey.(Ljava/lang/String;IILjava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_addStringOption_JJILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddStringOption_JJILjava_lang_String_Handler ()
		{
			if (cb_addStringOption_JJILjava_lang_String_ == null)
				cb_addStringOption_JJILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long, int, IntPtr>) n_AddStringOption_JJILjava_lang_String_);
			return cb_addStringOption_JJILjava_lang_String_;
		}

		static void n_AddStringOption_JJILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, long p1, int p2, IntPtr native_p3)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.AddStringOption (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='addStringOption' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("addStringOption", "(JJILjava/lang/String;)V", "GetAddStringOption_JJILjava_lang_String_Handler")]
		protected virtual unsafe void AddStringOption (long p0, long p1, int p2, string p3)
		{
			const string __id = "addStringOption.(JJILjava/lang/String;)V";
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_addSvrAccessKey_JLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddSvrAccessKey_JLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addSvrAccessKey_JLjava_lang_String_Ljava_lang_String_ == null)
				cb_addSvrAccessKey_JLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, bool>) n_AddSvrAccessKey_JLjava_lang_String_Ljava_lang_String_);
			return cb_addSvrAccessKey_JLjava_lang_String_Ljava_lang_String_;
		}

		static bool n_AddSvrAccessKey_JLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddSvrAccessKey (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='addSvrAccessKey' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("addSvrAccessKey", "(JLjava/lang/String;Ljava/lang/String;)Z", "GetAddSvrAccessKey_JLjava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe bool AddSvrAccessKey (long p0, string p1, string p2)
		{
			const string __id = "addSvrAccessKey.(JLjava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_alcsStart_J;
#pragma warning disable 0169
		static Delegate GetAlcsStart_JHandler ()
		{
			if (cb_alcsStart_J == null)
				cb_alcsStart_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_AlcsStart_J);
			return cb_alcsStart_J;
		}

		static void n_AlcsStart_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AlcsStart (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='alcsStart' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("alcsStart", "(J)V", "GetAlcsStart_JHandler")]
		public virtual unsafe void AlcsStart (long p0)
		{
			const string __id = "alcsStart.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_alcsStop_J;
#pragma warning disable 0169
		static Delegate GetAlcsStop_JHandler ()
		{
			if (cb_alcsStop_J == null)
				cb_alcsStop_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_AlcsStop_J);
			return cb_alcsStop_J;
		}

		static void n_AlcsStop_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AlcsStop (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='alcsStop' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("alcsStop", "(J)V", "GetAlcsStop_JHandler")]
		public virtual unsafe void AlcsStop (long p0)
		{
			const string __id = "alcsStop.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_authHasKey_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_coap_IAuthHandler_;
#pragma warning disable 0169
		static Delegate GetAuthHasKey_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_coap_IAuthHandler_Handler ()
		{
			if (cb_authHasKey_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_coap_IAuthHandler_ == null)
				cb_authHasKey_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_coap_IAuthHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_AuthHasKey_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_coap_IAuthHandler_);
			return cb_authHasKey_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_coap_IAuthHandler_;
		}

		static bool n_AuthHasKey_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_coap_IAuthHandler_ (IntPtr jnienv, IntPtr native__this, long coapContextId, IntPtr native_ip, int port, IntPtr native_productKey, IntPtr native_deviceName, IntPtr native_accessKey, IntPtr native_accessToken, IntPtr native_handler)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string ip = JNIEnv.GetString (native_ip, JniHandleOwnership.DoNotTransfer);
			string productKey = JNIEnv.GetString (native_productKey, JniHandleOwnership.DoNotTransfer);
			string deviceName = JNIEnv.GetString (native_deviceName, JniHandleOwnership.DoNotTransfer);
			string accessKey = JNIEnv.GetString (native_accessKey, JniHandleOwnership.DoNotTransfer);
			string accessToken = JNIEnv.GetString (native_accessToken, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAuthHandler handler = (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAuthHandler)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAuthHandler> (native_handler, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AuthHasKey (coapContextId, ip, port, productKey, deviceName, accessKey, accessToken, handler);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='authHasKey' and count(parameter)=8 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='com.aliyun.alink.linksdk.alcs.coap.IAuthHandler']]"
		[Register ("authHasKey", "(JLjava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/aliyun/alink/linksdk/alcs/coap/IAuthHandler;)Z", "GetAuthHasKey_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_coap_IAuthHandler_Handler")]
		public virtual unsafe bool AuthHasKey (long coapContextId, string ip, int port, string productKey, string deviceName, string accessKey, string accessToken, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAuthHandler handler)
		{
			const string __id = "authHasKey.(JLjava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/aliyun/alink/linksdk/alcs/coap/IAuthHandler;)Z";
			IntPtr native_ip = JNIEnv.NewString (ip);
			IntPtr native_productKey = JNIEnv.NewString (productKey);
			IntPtr native_deviceName = JNIEnv.NewString (deviceName);
			IntPtr native_accessKey = JNIEnv.NewString (accessKey);
			IntPtr native_accessToken = JNIEnv.NewString (accessToken);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (coapContextId);
				__args [1] = new JniArgumentValue (native_ip);
				__args [2] = new JniArgumentValue (port);
				__args [3] = new JniArgumentValue (native_productKey);
				__args [4] = new JniArgumentValue (native_deviceName);
				__args [5] = new JniArgumentValue (native_accessKey);
				__args [6] = new JniArgumentValue (native_accessToken);
				__args [7] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_ip);
				JNIEnv.DeleteLocalRef (native_productKey);
				JNIEnv.DeleteLocalRef (native_deviceName);
				JNIEnv.DeleteLocalRef (native_accessKey);
				JNIEnv.DeleteLocalRef (native_accessToken);
			}
		}

		static Delegate cb_authHasKey_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetAuthHasKey_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_authHasKey_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_authHasKey_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_AuthHasKey_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I);
			return cb_authHasKey_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		}

		static bool n_AuthHasKey_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, int p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, int p7)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AuthHasKey (p0, p1, p2, p3, p4, p5, p6, p7);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='authHasKey' and count(parameter)=8 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='int']]"
		[Register ("authHasKey", "(JLjava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Z", "GetAuthHasKey_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler")]
		protected virtual unsafe bool AuthHasKey (long p0, string p1, int p2, string p3, string p4, string p5, string p6, int p7)
		{
			const string __id = "authHasKey.(JLjava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue (native_p6);
				__args [7] = new JniArgumentValue (p7);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_cancelMessage_JJ;
#pragma warning disable 0169
		static Delegate GetCancelMessage_JJHandler ()
		{
			if (cb_cancelMessage_JJ == null)
				cb_cancelMessage_JJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, bool>) n_CancelMessage_JJ);
			return cb_cancelMessage_JJ;
		}

		static bool n_CancelMessage_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CancelMessage (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='cancelMessage' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("cancelMessage", "(JJ)Z", "GetCancelMessage_JJHandler")]
		public virtual unsafe bool CancelMessage (long p0, long p1)
		{
			const string __id = "cancelMessage.(JJ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_createCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_;
#pragma warning disable 0169
		static Delegate GetCreateCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Handler ()
		{
			if (cb_createCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_ == null)
				cb_createCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_CreateCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_);
			return cb_createCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_;
		}

		static long n_CreateCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.CreateCoAPContext (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='createCoAPContext' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPContext']]"
		[Register ("createCoAPContext", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPContext;)J", "GetCreateCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Handler")]
		protected virtual unsafe long CreateCoAPContext (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext p0)
		{
			const string __id = "createCoAPContext.(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPContext;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_createCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_;
#pragma warning disable 0169
		static Delegate GetCreateCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Handler ()
		{
			if (cb_createCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_ == null)
				cb_createCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_CreateCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_);
			return cb_createCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_;
		}

		static long n_CreateCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_rootResource)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext context = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource rootResource = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (native_rootResource, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.CreateCoAPContext (context, rootResource);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='createCoAPContext' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPContext'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.resources.AlcsCoAPResource']]"
		[Register ("createCoAPContext", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPContext;Lcom/aliyun/alink/linksdk/alcs/coap/resources/AlcsCoAPResource;)J", "GetCreateCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Handler")]
		public virtual unsafe long CreateCoAPContext (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext context, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource rootResource)
		{
			const string __id = "createCoAPContext.(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPContext;Lcom/aliyun/alink/linksdk/alcs/coap/resources/AlcsCoAPResource;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((rootResource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rootResource).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_createNewCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_;
#pragma warning disable 0169
		static Delegate GetCreateNewCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Handler ()
		{
			if (cb_createNewCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_ == null)
				cb_createNewCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_CreateNewCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_);
			return cb_createNewCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_;
		}

		static long n_CreateNewCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext context = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext> (native_context, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.CreateNewCoAPContext (context);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='createNewCoAPContext' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPContext']]"
		[Register ("createNewCoAPContext", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPContext;)J", "GetCreateNewCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Handler")]
		public virtual unsafe long CreateNewCoAPContext (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext context)
		{
			const string __id = "createNewCoAPContext.(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPContext;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_freeCoAPContext_J;
#pragma warning disable 0169
		static Delegate GetFreeCoAPContext_JHandler ()
		{
			if (cb_freeCoAPContext_J == null)
				cb_freeCoAPContext_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long>) n_FreeCoAPContext_J);
			return cb_freeCoAPContext_J;
		}

		static long n_FreeCoAPContext_J (IntPtr jnienv, IntPtr native__this, long coapContextId)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FreeCoAPContext (coapContextId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='freeCoAPContext' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("freeCoAPContext", "(J)J", "GetFreeCoAPContext_JHandler")]
		public virtual unsafe long FreeCoAPContext (long coapContextId)
		{
			const string __id = "freeCoAPContext.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (coapContextId);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_freeContext_J;
#pragma warning disable 0169
		static Delegate GetFreeContext_JHandler ()
		{
			if (cb_freeContext_J == null)
				cb_freeContext_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_FreeContext_J);
			return cb_freeContext_J;
		}

		static void n_FreeContext_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FreeContext (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='freeContext' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("freeContext", "(J)V", "GetFreeContext_JHandler")]
		protected virtual unsafe void FreeContext (long p0)
		{
			const string __id = "freeContext.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getContextByPort_I;
#pragma warning disable 0169
		static Delegate GetGetContextByPort_IHandler ()
		{
			if (cb_getContextByPort_I == null)
				cb_getContextByPort_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetContextByPort_I);
			return cb_getContextByPort_I;
		}

		static long n_GetContextByPort_I (IntPtr jnienv, IntPtr native__this, int port)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetContextByPort (port);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='getContextByPort' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getContextByPort", "(I)J", "GetGetContextByPort_IHandler")]
		protected virtual unsafe long GetContextByPort (int port)
		{
			const string __id = "getContextByPort.(I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (port);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='getRequestCallback' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("getRequestCallback", "(JJ)Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;", "")]
		protected static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler GetRequestCallback (long coapContextId, long msgId)
		{
			const string __id = "getRequestCallback.(JJ)Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (coapContextId);
				__args [1] = new JniArgumentValue (msgId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_initAuth_JLjava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetInitAuth_JLjava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_initAuth_JLjava_lang_String_Ljava_lang_String_I == null)
				cb_initAuth_JLjava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, int, bool>) n_InitAuth_JLjava_lang_String_Ljava_lang_String_I);
			return cb_initAuth_JLjava_lang_String_Ljava_lang_String_I;
		}

		static bool n_InitAuth_JLjava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InitAuth (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='initAuth' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("initAuth", "(JLjava/lang/String;Ljava/lang/String;I)Z", "GetInitAuth_JLjava_lang_String_Ljava_lang_String_IHandler")]
		public virtual unsafe bool InitAuth (long p0, string p1, string p2, int p3)
		{
			const string __id = "initAuth.(JLjava/lang/String;Ljava/lang/String;I)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_initOptionSet_JJLcom_aliyun_alink_linksdk_alcs_coap_option_OptionSet_;
#pragma warning disable 0169
		static Delegate GetInitOptionSet_JJLcom_aliyun_alink_linksdk_alcs_coap_option_OptionSet_Handler ()
		{
			if (cb_initOptionSet_JJLcom_aliyun_alink_linksdk_alcs_coap_option_OptionSet_ == null)
				cb_initOptionSet_JJLcom_aliyun_alink_linksdk_alcs_coap_option_OptionSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long, IntPtr>) n_InitOptionSet_JJLcom_aliyun_alink_linksdk_alcs_coap_option_OptionSet_);
			return cb_initOptionSet_JJLcom_aliyun_alink_linksdk_alcs_coap_option_OptionSet_;
		}

		static void n_InitOptionSet_JJLcom_aliyun_alink_linksdk_alcs_coap_option_OptionSet_ (IntPtr jnienv, IntPtr native__this, long contextId, long msgId, IntPtr native_optionSet)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet optionSet = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (native_optionSet, JniHandleOwnership.DoNotTransfer);
			__this.InitOptionSet (contextId, msgId, optionSet);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='initOptionSet' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.coap.option.OptionSet']]"
		[Register ("initOptionSet", "(JJLcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;)V", "GetInitOptionSet_JJLcom_aliyun_alink_linksdk_alcs_coap_option_OptionSet_Handler")]
		protected virtual unsafe void InitOptionSet (long contextId, long msgId, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet optionSet)
		{
			const string __id = "initOptionSet.(JJLcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (contextId);
				__args [1] = new JniArgumentValue (msgId);
				__args [2] = new JniArgumentValue ((optionSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) optionSet).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_initRequest_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_;
#pragma warning disable 0169
		static Delegate GetInitRequest_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Handler ()
		{
			if (cb_initRequest_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_ == null)
				cb_initRequest_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, long>) n_InitRequest_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_);
			return cb_initRequest_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_;
		}

		static long n_InitRequest_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.InitRequest (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='initRequest' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPRequest']]"
		[Register ("initRequest", "(JLcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;)J", "GetInitRequest_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Handler")]
		protected virtual unsafe long InitRequest (long p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest p1)
		{
			const string __id = "initRequest.(JLcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_initResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_;
#pragma warning disable 0169
		static Delegate GetInitResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Handler ()
		{
			if (cb_initResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ == null)
				cb_initResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, long>) n_InitResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_);
			return cb_initResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_;
		}

		static long n_InitResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse> (native_p1, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.InitResponse (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='initResponse' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPResponse']]"
		[Register ("initResponse", "(JLcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;)J", "GetInitResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Handler")]
		protected virtual unsafe long InitResponse (long p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse p1)
		{
			const string __id = "initResponse.(JLcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isServerDevOnline_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsServerDevOnline_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_isServerDevOnline_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_isServerDevOnline_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, int, IntPtr, IntPtr, bool>) n_IsServerDevOnline_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_);
			return cb_isServerDevOnline_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_;
		}

		static bool n_IsServerDevOnline_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long coapContextId, IntPtr native_ip, int port, IntPtr native_pk, IntPtr native_dn)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string ip = JNIEnv.GetString (native_ip, JniHandleOwnership.DoNotTransfer);
			string pk = JNIEnv.GetString (native_pk, JniHandleOwnership.DoNotTransfer);
			string dn = JNIEnv.GetString (native_dn, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsServerDevOnline (coapContextId, ip, port, pk, dn);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='isServerDevOnline' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("isServerDevOnline", "(JLjava/lang/String;ILjava/lang/String;Ljava/lang/String;)Z", "GetIsServerDevOnline_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsServerDevOnline (long coapContextId, string ip, int port, string pk, string dn)
		{
			const string __id = "isServerDevOnline.(JLjava/lang/String;ILjava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_ip = JNIEnv.NewString (ip);
			IntPtr native_pk = JNIEnv.NewString (pk);
			IntPtr native_dn = JNIEnv.NewString (dn);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (coapContextId);
				__args [1] = new JniArgumentValue (native_ip);
				__args [2] = new JniArgumentValue (port);
				__args [3] = new JniArgumentValue (native_pk);
				__args [4] = new JniArgumentValue (native_dn);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_ip);
				JNIEnv.DeleteLocalRef (native_pk);
				JNIEnv.DeleteLocalRef (native_dn);
			}
		}

		static Delegate cb_isServerOnLine_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsServerOnLine_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_isServerOnLine_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_isServerOnLine_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, int, IntPtr, IntPtr, bool>) n_IsServerOnLine_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_);
			return cb_isServerOnLine_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_;
		}

		static bool n_IsServerOnLine_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsServerOnLine (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='isServerOnLine' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("isServerOnLine", "(JLjava/lang/String;ILjava/lang/String;Ljava/lang/String;)Z", "GetIsServerOnLine_JLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe bool IsServerOnLine (long p0, string p1, int p2, string p3, string p4)
		{
			const string __id = "isServerOnLine.(JLjava/lang/String;ILjava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_notifyObserve_JLjava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetNotifyObserve_JLjava_lang_String_arrayBHandler ()
		{
			if (cb_notifyObserve_JLjava_lang_String_arrayB == null)
				cb_notifyObserve_JLjava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, bool>) n_NotifyObserve_JLjava_lang_String_arrayB);
			return cb_notifyObserve_JLjava_lang_String_arrayB;
		}

		static bool n_NotifyObserve_JLjava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.NotifyObserve (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='notifyObserve' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
		[Register ("notifyObserve", "(JLjava/lang/String;[B)Z", "GetNotifyObserve_JLjava_lang_String_arrayBHandler")]
		public virtual unsafe bool NotifyObserve (long p0, string p1, byte[] p2)
		{
			const string __id = "notifyObserve.(JLjava/lang/String;[B)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='onClientAuthComplete' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onClientAuthComplete", "(JLjava/lang/String;III)V", "")]
		public static unsafe void OnClientAuthComplete (long contextId, string ip, int port, int userdata, int result)
		{
			const string __id = "onClientAuthComplete.(JLjava/lang/String;III)V";
			IntPtr native_ip = JNIEnv.NewString (ip);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (contextId);
				__args [1] = new JniArgumentValue (native_ip);
				__args [2] = new JniArgumentValue (port);
				__args [3] = new JniArgumentValue (userdata);
				__args [4] = new JniArgumentValue (result);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_ip);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='onRecvRequestHandler' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPRequest']]"
		[Register ("onRecvRequestHandler", "(JLjava/lang/String;Ljava/lang/String;ILcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;)V", "")]
		public static unsafe void OnRecvRequestHandler (long contextId, string resourceId, string ip, int port, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request)
		{
			const string __id = "onRecvRequestHandler.(JLjava/lang/String;Ljava/lang/String;ILcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;)V";
			IntPtr native_resourceId = JNIEnv.NewString (resourceId);
			IntPtr native_ip = JNIEnv.NewString (ip);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (contextId);
				__args [1] = new JniArgumentValue (native_resourceId);
				__args [2] = new JniArgumentValue (native_ip);
				__args [3] = new JniArgumentValue (port);
				__args [4] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_resourceId);
				JNIEnv.DeleteLocalRef (native_ip);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='onSendRequestComplete' and count(parameter)=6 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPResponse']]"
		[Register ("onSendRequestComplete", "(JJLjava/lang/String;IILcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;)V", "")]
		public static unsafe void OnSendRequestComplete (long contextId, long msgId, string ip, int port, int result, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse response)
		{
			const string __id = "onSendRequestComplete.(JJLjava/lang/String;IILcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;)V";
			IntPtr native_ip = JNIEnv.NewString (ip);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (contextId);
				__args [1] = new JniArgumentValue (msgId);
				__args [2] = new JniArgumentValue (native_ip);
				__args [3] = new JniArgumentValue (port);
				__args [4] = new JniArgumentValue (result);
				__args [5] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_ip);
			}
		}

		static Delegate cb_putRequestCallback_JJLcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_;
#pragma warning disable 0169
		static Delegate GetPutRequestCallback_JJLcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_Handler ()
		{
			if (cb_putRequestCallback_JJLcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ == null)
				cb_putRequestCallback_JJLcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long, IntPtr>) n_PutRequestCallback_JJLcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_);
			return cb_putRequestCallback_JJLcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_;
		}

		static void n_PutRequestCallback_JJLcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ (IntPtr jnienv, IntPtr native__this, long coapContextId, long msgId, IntPtr native_requestCallback)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler requestCallback = (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler> (native_requestCallback, JniHandleOwnership.DoNotTransfer);
			__this.PutRequestCallback (coapContextId, msgId, requestCallback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='putRequestCallback' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.coap.IAlcsCoAPReqHandler']]"
		[Register ("putRequestCallback", "(JJLcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;)V", "GetPutRequestCallback_JJLcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_Handler")]
		protected virtual unsafe void PutRequestCallback (long coapContextId, long msgId, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler requestCallback)
		{
			const string __id = "putRequestCallback.(JJLcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (coapContextId);
				__args [1] = new JniArgumentValue (msgId);
				__args [2] = new JniArgumentValue ((requestCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestCallback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_registerAllResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_;
#pragma warning disable 0169
		static Delegate GetRegisterAllResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Handler ()
		{
			if (cb_registerAllResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_ == null)
				cb_registerAllResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_RegisterAllResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_);
			return cb_registerAllResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_;
		}

		static void n_RegisterAllResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_ (IntPtr jnienv, IntPtr native__this, long contextId, IntPtr native_resource)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource resource = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (native_resource, JniHandleOwnership.DoNotTransfer);
			__this.RegisterAllResource (contextId, resource);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='registerAllResource' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.resources.AlcsCoAPResource']]"
		[Register ("registerAllResource", "(JLcom/aliyun/alink/linksdk/alcs/coap/resources/AlcsCoAPResource;)V", "GetRegisterAllResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Handler")]
		public virtual unsafe void RegisterAllResource (long contextId, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource resource)
		{
			const string __id = "registerAllResource.(JLcom/aliyun/alink/linksdk/alcs/coap/resources/AlcsCoAPResource;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (contextId);
				__args [1] = new JniArgumentValue ((resource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resource).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_registerAllResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterAllResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_registerAllResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_registerAllResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr>) n_RegisterAllResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Ljava_lang_String_Ljava_lang_String_);
			return cb_registerAllResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RegisterAllResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long contextId, IntPtr native_resource, IntPtr native_pk, IntPtr native_dn)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource resource = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (native_resource, JniHandleOwnership.DoNotTransfer);
			string pk = JNIEnv.GetString (native_pk, JniHandleOwnership.DoNotTransfer);
			string dn = JNIEnv.GetString (native_dn, JniHandleOwnership.DoNotTransfer);
			__this.RegisterAllResource (contextId, resource, pk, dn);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='registerAllResource' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.resources.AlcsCoAPResource'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("registerAllResource", "(JLcom/aliyun/alink/linksdk/alcs/coap/resources/AlcsCoAPResource;Ljava/lang/String;Ljava/lang/String;)V", "GetRegisterAllResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void RegisterAllResource (long contextId, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource resource, string pk, string dn)
		{
			const string __id = "registerAllResource.(JLcom/aliyun/alink/linksdk/alcs/coap/resources/AlcsCoAPResource;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_pk = JNIEnv.NewString (pk);
			IntPtr native_dn = JNIEnv.NewString (dn);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (contextId);
				__args [1] = new JniArgumentValue ((resource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resource).Handle);
				__args [2] = new JniArgumentValue (native_pk);
				__args [3] = new JniArgumentValue (native_dn);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pk);
				JNIEnv.DeleteLocalRef (native_dn);
			}
		}

		static Delegate cb_registerResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_registerResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_registerResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr, long>) n_RegisterResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Ljava_lang_String_Ljava_lang_String_);
			return cb_registerResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Ljava_lang_String_Ljava_lang_String_;
		}

		static long n_RegisterResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.RegisterResource (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='registerResource' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.resources.AlcsCoAPResource'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("registerResource", "(JLcom/aliyun/alink/linksdk/alcs/coap/resources/AlcsCoAPResource;Ljava/lang/String;Ljava/lang/String;)J", "GetRegisterResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe long RegisterResource (long p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource p1, string p2, string p3)
		{
			const string __id = "registerResource.(JLcom/aliyun/alink/linksdk/alcs/coap/resources/AlcsCoAPResource;Ljava/lang/String;Ljava/lang/String;)J";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_removeAlcsSvrKey_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveAlcsSvrKey_JLjava_lang_String_Handler ()
		{
			if (cb_removeAlcsSvrKey_JLjava_lang_String_ == null)
				cb_removeAlcsSvrKey_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_RemoveAlcsSvrKey_JLjava_lang_String_);
			return cb_removeAlcsSvrKey_JLjava_lang_String_;
		}

		static bool n_RemoveAlcsSvrKey_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long coapContextId, IntPtr native_prefix)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string prefix = JNIEnv.GetString (native_prefix, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveAlcsSvrKey (coapContextId, prefix);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='removeAlcsSvrKey' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeAlcsSvrKey", "(JLjava/lang/String;)Z", "GetRemoveAlcsSvrKey_JLjava_lang_String_Handler")]
		public virtual unsafe bool RemoveAlcsSvrKey (long coapContextId, string prefix)
		{
			const string __id = "removeAlcsSvrKey.(JLjava/lang/String;)Z";
			IntPtr native_prefix = JNIEnv.NewString (prefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (coapContextId);
				__args [1] = new JniArgumentValue (native_prefix);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
			}
		}

		static Delegate cb_removeKey_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetRemoveKey_Ljava_lang_String_IIHandler ()
		{
			if (cb_removeKey_Ljava_lang_String_II == null)
				cb_removeKey_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool>) n_RemoveKey_Ljava_lang_String_II);
			return cb_removeKey_Ljava_lang_String_II;
		}

		static bool n_RemoveKey_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveKey (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='removeKey' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("removeKey", "(Ljava/lang/String;II)Z", "GetRemoveKey_Ljava_lang_String_IIHandler")]
		protected virtual unsafe bool RemoveKey (string p0, int p1, int p2)
		{
			const string __id = "removeKey.(Ljava/lang/String;II)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_removeSvrKey_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveSvrKey_JLjava_lang_String_Handler ()
		{
			if (cb_removeSvrKey_JLjava_lang_String_ == null)
				cb_removeSvrKey_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_RemoveSvrKey_JLjava_lang_String_);
			return cb_removeSvrKey_JLjava_lang_String_;
		}

		static bool n_RemoveSvrKey_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveSvrKey (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='removeSvrKey' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeSvrKey", "(JLjava/lang/String;)Z", "GetRemoveSvrKey_JLjava_lang_String_Handler")]
		protected virtual unsafe bool RemoveSvrKey (long p0, string p1)
		{
			const string __id = "removeSvrKey.(JLjava/lang/String;)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_sendAlcsRequest_JJLjava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSendAlcsRequest_JJLjava_lang_String_IHandler ()
		{
			if (cb_sendAlcsRequest_JJLjava_lang_String_I == null)
				cb_sendAlcsRequest_JJLjava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, IntPtr, int, bool>) n_SendAlcsRequest_JJLjava_lang_String_I);
			return cb_sendAlcsRequest_JJLjava_lang_String_I;
		}

		static bool n_SendAlcsRequest_JJLjava_lang_String_I (IntPtr jnienv, IntPtr native__this, long p0, long p1, IntPtr native_p2, int p3)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendAlcsRequest (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='sendAlcsRequest' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("sendAlcsRequest", "(JJLjava/lang/String;I)Z", "GetSendAlcsRequest_JJLjava_lang_String_IHandler")]
		protected virtual unsafe bool SendAlcsRequest (long p0, long p1, string p2, int p3)
		{
			const string __id = "sendAlcsRequest.(JJLjava/lang/String;I)Z";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_sendAlcsRequestSecure_JJLjava_lang_String_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendAlcsRequestSecure_JJLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sendAlcsRequestSecure_JJLjava_lang_String_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_sendAlcsRequestSecure_JJLjava_lang_String_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, IntPtr, int, IntPtr, IntPtr, bool>) n_SendAlcsRequestSecure_JJLjava_lang_String_ILjava_lang_String_Ljava_lang_String_);
			return cb_sendAlcsRequestSecure_JJLjava_lang_String_ILjava_lang_String_Ljava_lang_String_;
		}

		static bool n_SendAlcsRequestSecure_JJLjava_lang_String_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, long p1, IntPtr native_p2, int p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendAlcsRequestSecure (p0, p1, p2, p3, p4, p5);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='sendAlcsRequestSecure' and count(parameter)=6 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("sendAlcsRequestSecure", "(JJLjava/lang/String;ILjava/lang/String;Ljava/lang/String;)Z", "GetSendAlcsRequestSecure_JJLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe bool SendAlcsRequestSecure (long p0, long p1, string p2, int p3, string p4, string p5)
		{
			const string __id = "sendAlcsRequestSecure.(JJLjava/lang/String;ILjava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_sendAlcsResponse_JJLjava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSendAlcsResponse_JJLjava_lang_String_IHandler ()
		{
			if (cb_sendAlcsResponse_JJLjava_lang_String_I == null)
				cb_sendAlcsResponse_JJLjava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, IntPtr, int, bool>) n_SendAlcsResponse_JJLjava_lang_String_I);
			return cb_sendAlcsResponse_JJLjava_lang_String_I;
		}

		static bool n_SendAlcsResponse_JJLjava_lang_String_I (IntPtr jnienv, IntPtr native__this, long p0, long p1, IntPtr native_p2, int p3)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendAlcsResponse (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='sendAlcsResponse' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("sendAlcsResponse", "(JJLjava/lang/String;I)Z", "GetSendAlcsResponse_JJLjava_lang_String_IHandler")]
		protected virtual unsafe bool SendAlcsResponse (long p0, long p1, string p2, int p3)
		{
			const string __id = "sendAlcsResponse.(JJLjava/lang/String;I)Z";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_sendAlcsResponseSecure_JJLjava_lang_String_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendAlcsResponseSecure_JJLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sendAlcsResponseSecure_JJLjava_lang_String_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_sendAlcsResponseSecure_JJLjava_lang_String_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, IntPtr, int, IntPtr, IntPtr, bool>) n_SendAlcsResponseSecure_JJLjava_lang_String_ILjava_lang_String_Ljava_lang_String_);
			return cb_sendAlcsResponseSecure_JJLjava_lang_String_ILjava_lang_String_Ljava_lang_String_;
		}

		static bool n_SendAlcsResponseSecure_JJLjava_lang_String_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, long p1, IntPtr native_p2, int p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendAlcsResponseSecure (p0, p1, p2, p3, p4, p5);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='sendAlcsResponseSecure' and count(parameter)=6 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("sendAlcsResponseSecure", "(JJLjava/lang/String;ILjava/lang/String;Ljava/lang/String;)Z", "GetSendAlcsResponseSecure_JJLjava_lang_String_ILjava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe bool SendAlcsResponseSecure (long p0, long p1, string p2, int p3, string p4, string p5)
		{
			const string __id = "sendAlcsResponseSecure.(JJLjava/lang/String;ILjava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_sendObserveResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_;
#pragma warning disable 0169
		static Delegate GetSendObserveResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Handler ()
		{
			if (cb_sendObserveResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ == null)
				cb_sendObserveResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, bool>) n_SendObserveResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_);
			return cb_sendObserveResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_;
		}

		static bool n_SendObserveResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ (IntPtr jnienv, IntPtr native__this, long coapContextId, IntPtr native_request, IntPtr native_response)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse response = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse> (native_response, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendObserveResponse (coapContextId, request, response);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='sendObserveResponse' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPRequest'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPResponse']]"
		[Register ("sendObserveResponse", "(JLcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;)Z", "GetSendObserveResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Handler")]
		public virtual unsafe bool SendObserveResponse (long coapContextId, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse response)
		{
			const string __id = "sendObserveResponse.(JLcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (coapContextId);
				__args [1] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [2] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_sendRequest_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_;
#pragma warning disable 0169
		static Delegate GetSendRequest_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_Handler ()
		{
			if (cb_sendRequest_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ == null)
				cb_sendRequest_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, long>) n_SendRequest_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_);
			return cb_sendRequest_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_;
		}

		static long n_SendRequest_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ (IntPtr jnienv, IntPtr native__this, long coapContextId, IntPtr native_request, IntPtr native_requestCallback)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler requestCallback = (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler> (native_requestCallback, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.SendRequest (coapContextId, request, requestCallback);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='sendRequest' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPRequest'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.coap.IAlcsCoAPReqHandler']]"
		[Register ("sendRequest", "(JLcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;)J", "GetSendRequest_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_Handler")]
		public virtual unsafe long SendRequest (long coapContextId, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler requestCallback)
		{
			const string __id = "sendRequest.(JLcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (coapContextId);
				__args [1] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [2] = new JniArgumentValue ((requestCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_sendRequestS_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_;
#pragma warning disable 0169
		static Delegate GetSendRequestS_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_Handler ()
		{
			if (cb_sendRequestS_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ == null)
				cb_sendRequestS_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr, IntPtr, long>) n_SendRequestS_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_);
			return cb_sendRequestS_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_;
		}

		static long n_SendRequestS_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ (IntPtr jnienv, IntPtr native__this, long coapContextId, IntPtr native_request, IntPtr native_pk, IntPtr native_dn, IntPtr native_requestCallback)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			string pk = JNIEnv.GetString (native_pk, JniHandleOwnership.DoNotTransfer);
			string dn = JNIEnv.GetString (native_dn, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler requestCallback = (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler> (native_requestCallback, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.SendRequestS (coapContextId, request, pk, dn, requestCallback);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='sendRequestS' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPRequest'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.aliyun.alink.linksdk.alcs.coap.IAlcsCoAPReqHandler']]"
		[Register ("sendRequestS", "(JLcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Ljava/lang/String;Ljava/lang/String;Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;)J", "GetSendRequestS_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_Handler")]
		public virtual unsafe long SendRequestS (long coapContextId, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request, string pk, string dn, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler requestCallback)
		{
			const string __id = "sendRequestS.(JLcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Ljava/lang/String;Ljava/lang/String;Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;)J";
			IntPtr native_pk = JNIEnv.NewString (pk);
			IntPtr native_dn = JNIEnv.NewString (dn);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (coapContextId);
				__args [1] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [2] = new JniArgumentValue (native_pk);
				__args [3] = new JniArgumentValue (native_dn);
				__args [4] = new JniArgumentValue ((requestCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_pk);
				JNIEnv.DeleteLocalRef (native_dn);
			}
		}

		static Delegate cb_sendResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_;
#pragma warning disable 0169
		static Delegate GetSendResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Handler ()
		{
			if (cb_sendResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ == null)
				cb_sendResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_SendResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_);
			return cb_sendResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_;
		}

		static bool n_SendResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ (IntPtr jnienv, IntPtr native__this, long coapContextId, IntPtr native_response)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse response = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse> (native_response, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendResponse (coapContextId, response);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='sendResponse' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPResponse']]"
		[Register ("sendResponse", "(JLcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;)Z", "GetSendResponse_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Handler")]
		public virtual unsafe bool SendResponse (long coapContextId, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse response)
		{
			const string __id = "sendResponse.(JLcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (coapContextId);
				__args [1] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_sendResponseS_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendResponseS_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sendResponseS_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_sendResponseS_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr, bool>) n_SendResponseS_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Ljava_lang_String_Ljava_lang_String_);
			return cb_sendResponseS_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_SendResponseS_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long coapContextId, IntPtr native_response, IntPtr native_pk, IntPtr native_dn)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse response = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse> (native_response, JniHandleOwnership.DoNotTransfer);
			string pk = JNIEnv.GetString (native_pk, JniHandleOwnership.DoNotTransfer);
			string dn = JNIEnv.GetString (native_dn, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendResponseS (coapContextId, response, pk, dn);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='sendResponseS' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPResponse'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("sendResponseS", "(JLcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;Ljava/lang/String;Ljava/lang/String;)Z", "GetSendResponseS_JLcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool SendResponseS (long coapContextId, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse response, string pk, string dn)
		{
			const string __id = "sendResponseS.(JLcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_pk = JNIEnv.NewString (pk);
			IntPtr native_dn = JNIEnv.NewString (dn);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (coapContextId);
				__args [1] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				__args [2] = new JniArgumentValue (native_pk);
				__args [3] = new JniArgumentValue (native_dn);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_pk);
				JNIEnv.DeleteLocalRef (native_dn);
			}
		}

		static Delegate cb_setLogLevel_I;
#pragma warning disable 0169
		static Delegate GetSetLogLevel_IHandler ()
		{
			if (cb_setLogLevel_I == null)
				cb_setLogLevel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLogLevel_I);
			return cb_setLogLevel_I;
		}

		static void n_SetLogLevel_I (IntPtr jnienv, IntPtr native__this, int logLevel)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLogLevel (logLevel);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='setLogLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLogLevel", "(I)V", "GetSetLogLevel_IHandler")]
		public virtual unsafe void SetLogLevel (int logLevel)
		{
			const string __id = "setLogLevel.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (logLevel);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='setLogLevelEx' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLogLevelEx", "(I)V", "")]
		public static unsafe void SetLogLevelEx (int logLevel)
		{
			const string __id = "setLogLevelEx.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (logLevel);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='setLogLevelNative' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLogLevelNative", "(I)V", "")]
		protected static unsafe void SetLogLevelNative (int p0)
		{
			const string __id = "setLogLevelNative.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_unInitMessage_JJ;
#pragma warning disable 0169
		static Delegate GetUnInitMessage_JJHandler ()
		{
			if (cb_unInitMessage_JJ == null)
				cb_unInitMessage_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long>) n_UnInitMessage_JJ);
			return cb_unInitMessage_JJ;
		}

		static void n_UnInitMessage_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnInitMessage (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='unInitMessage' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("unInitMessage", "(JJ)V", "GetUnInitMessage_JJHandler")]
		protected virtual unsafe void UnInitMessage (long p0, long p1)
		{
			const string __id = "unInitMessage.(JJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unRegisterResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_;
#pragma warning disable 0169
		static Delegate GetUnRegisterResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Handler ()
		{
			if (cb_unRegisterResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_ == null)
				cb_unRegisterResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_UnRegisterResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_);
			return cb_unRegisterResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_;
		}

		static void n_UnRegisterResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_ (IntPtr jnienv, IntPtr native__this, long contextId, IntPtr native_resource)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource resource = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (native_resource, JniHandleOwnership.DoNotTransfer);
			__this.UnRegisterResource (contextId, resource);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='unRegisterResource' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.resources.AlcsCoAPResource']]"
		[Register ("unRegisterResource", "(JLcom/aliyun/alink/linksdk/alcs/coap/resources/AlcsCoAPResource;)V", "GetUnRegisterResource_JLcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Handler")]
		public virtual unsafe void UnRegisterResource (long contextId, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource resource)
		{
			const string __id = "unRegisterResource.(JLcom/aliyun/alink/linksdk/alcs/coap/resources/AlcsCoAPResource;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (contextId);
				__args [1] = new JniArgumentValue ((resource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resource).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unRegisterResource_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnRegisterResource_JLjava_lang_String_Handler ()
		{
			if (cb_unRegisterResource_JLjava_lang_String_ == null)
				cb_unRegisterResource_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, long>) n_UnRegisterResource_JLjava_lang_String_);
			return cb_unRegisterResource_JLjava_lang_String_;
		}

		static long n_UnRegisterResource_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.UnRegisterResource (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='unRegisterResource' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("unRegisterResource", "(JLjava/lang/String;)J", "GetUnRegisterResource_JLjava_lang_String_Handler")]
		protected virtual unsafe long UnRegisterResource (long p0, string p1)
		{
			const string __id = "unRegisterResource.(JLjava/lang/String;)J";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_unRegisterResourceByPath_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnRegisterResourceByPath_JLjava_lang_String_Handler ()
		{
			if (cb_unRegisterResourceByPath_JLjava_lang_String_ == null)
				cb_unRegisterResourceByPath_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, long>) n_UnRegisterResourceByPath_JLjava_lang_String_);
			return cb_unRegisterResourceByPath_JLjava_lang_String_;
		}

		static long n_UnRegisterResourceByPath_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long contextId, IntPtr native_path)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.UnRegisterResourceByPath (contextId, path);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='unRegisterResourceByPath' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("unRegisterResourceByPath", "(JLjava/lang/String;)J", "GetUnRegisterResourceByPath_JLjava_lang_String_Handler")]
		public virtual unsafe long UnRegisterResourceByPath (long contextId, string path)
		{
			const string __id = "unRegisterResourceByPath.(JLjava/lang/String;)J";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (contextId);
				__args [1] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_updateAlcsSvrBlackList_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateAlcsSvrBlackList_JLjava_lang_String_Handler ()
		{
			if (cb_updateAlcsSvrBlackList_JLjava_lang_String_ == null)
				cb_updateAlcsSvrBlackList_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_UpdateAlcsSvrBlackList_JLjava_lang_String_);
			return cb_updateAlcsSvrBlackList_JLjava_lang_String_;
		}

		static bool n_UpdateAlcsSvrBlackList_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long coapContextId, IntPtr native_blackList)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string blackList = JNIEnv.GetString (native_blackList, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateAlcsSvrBlackList (coapContextId, blackList);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='updateAlcsSvrBlackList' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateAlcsSvrBlackList", "(JLjava/lang/String;)Z", "GetUpdateAlcsSvrBlackList_JLjava_lang_String_Handler")]
		public virtual unsafe bool UpdateAlcsSvrBlackList (long coapContextId, string blackList)
		{
			const string __id = "updateAlcsSvrBlackList.(JLjava/lang/String;)Z";
			IntPtr native_blackList = JNIEnv.NewString (blackList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (coapContextId);
				__args [1] = new JniArgumentValue (native_blackList);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_blackList);
			}
		}

		static Delegate cb_updateSvrBlackList_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateSvrBlackList_JLjava_lang_String_Handler ()
		{
			if (cb_updateSvrBlackList_JLjava_lang_String_ == null)
				cb_updateSvrBlackList_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_UpdateSvrBlackList_JLjava_lang_String_);
			return cb_updateSvrBlackList_JLjava_lang_String_;
		}

		static bool n_UpdateSvrBlackList_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateSvrBlackList (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAP']/method[@name='updateSvrBlackList' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateSvrBlackList", "(JLjava/lang/String;)Z", "GetUpdateSvrBlackList_JLjava_lang_String_Handler")]
		protected virtual unsafe bool UpdateSvrBlackList (long p0, string p1)
		{
			const string __id = "updateSvrBlackList.(JLjava/lang/String;)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
