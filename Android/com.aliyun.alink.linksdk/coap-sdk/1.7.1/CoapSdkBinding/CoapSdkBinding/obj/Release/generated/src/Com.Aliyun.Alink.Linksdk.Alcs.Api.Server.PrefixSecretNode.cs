using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Api.Server {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='PrefixSecretNode']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/api/server/PrefixSecretNode", DoNotGenerateAcw=true)]
	public partial class PrefixSecretNode : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='PrefixSecretNode']/field[@name='mPrefix']"
		[Register ("mPrefix")]
		protected string MPrefix {
			get {
				const string __id = "mPrefix.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPrefix.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='PrefixSecretNode']/field[@name='mSecret']"
		[Register ("mSecret")]
		protected string MSecret {
			get {
				const string __id = "mSecret.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mSecret.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/api/server/PrefixSecretNode", typeof (PrefixSecretNode));
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

		protected PrefixSecretNode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='PrefixSecretNode']/constructor[@name='PrefixSecretNode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe PrefixSecretNode (string prefix, string secret)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_prefix = JNIEnv.NewString (prefix);
			IntPtr native_secret = JNIEnv.NewString (secret);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_prefix);
				__args [1] = new JniArgumentValue (native_secret);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
				JNIEnv.DeleteLocalRef (native_secret);
			}
		}

		static Delegate cb_getPrefix;
#pragma warning disable 0169
		static Delegate GetGetPrefixHandler ()
		{
			if (cb_getPrefix == null)
				cb_getPrefix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrefix);
			return cb_getPrefix;
		}

		static IntPtr n_GetPrefix (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.PrefixSecretNode __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.PrefixSecretNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Prefix);
		}
#pragma warning restore 0169

		static Delegate cb_setPrefix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPrefix_Ljava_lang_String_Handler ()
		{
			if (cb_setPrefix_Ljava_lang_String_ == null)
				cb_setPrefix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPrefix_Ljava_lang_String_);
			return cb_setPrefix_Ljava_lang_String_;
		}

		static void n_SetPrefix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mPrefix)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.PrefixSecretNode __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.PrefixSecretNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string mPrefix = JNIEnv.GetString (native_mPrefix, JniHandleOwnership.DoNotTransfer);
			__this.Prefix = mPrefix;
		}
#pragma warning restore 0169

		public virtual unsafe string Prefix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='PrefixSecretNode']/method[@name='getPrefix' and count(parameter)=0]"
			[Register ("getPrefix", "()Ljava/lang/String;", "GetGetPrefixHandler")]
			get {
				const string __id = "getPrefix.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='PrefixSecretNode']/method[@name='setPrefix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPrefix", "(Ljava/lang/String;)V", "GetSetPrefix_Ljava_lang_String_Handler")]
			set {
				const string __id = "setPrefix.(Ljava/lang/String;)V";
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

		static Delegate cb_getSecret;
#pragma warning disable 0169
		static Delegate GetGetSecretHandler ()
		{
			if (cb_getSecret == null)
				cb_getSecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecret);
			return cb_getSecret;
		}

		static IntPtr n_GetSecret (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.PrefixSecretNode __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.PrefixSecretNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Secret);
		}
#pragma warning restore 0169

		static Delegate cb_setSecret_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSecret_Ljava_lang_String_Handler ()
		{
			if (cb_setSecret_Ljava_lang_String_ == null)
				cb_setSecret_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSecret_Ljava_lang_String_);
			return cb_setSecret_Ljava_lang_String_;
		}

		static void n_SetSecret_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mSecret)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.PrefixSecretNode __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.PrefixSecretNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string mSecret = JNIEnv.GetString (native_mSecret, JniHandleOwnership.DoNotTransfer);
			__this.Secret = mSecret;
		}
#pragma warning restore 0169

		public virtual unsafe string Secret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='PrefixSecretNode']/method[@name='getSecret' and count(parameter)=0]"
			[Register ("getSecret", "()Ljava/lang/String;", "GetGetSecretHandler")]
			get {
				const string __id = "getSecret.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='PrefixSecretNode']/method[@name='setSecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSecret", "(Ljava/lang/String;)V", "GetSetSecret_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSecret.(Ljava/lang/String;)V";
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
