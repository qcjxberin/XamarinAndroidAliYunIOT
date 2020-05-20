using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Api.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='ClientAuthHandler']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/api/client/ClientAuthHandler", DoNotGenerateAcw=true)]
	public partial class ClientAuthHandler : global::Java.Lang.Object, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAuthHandler {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='ClientAuthHandler']/field[@name='TAG']"
		[Register ("TAG")]
		protected const string Tag = (string) "ClientAuthHandler";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='ClientAuthHandler']/field[@name='mClientRef']"
		[Register ("mClientRef")]
		protected global::Java.Lang.Ref.WeakReference MClientRef {
			get {
				const string __id = "mClientRef.Ljava/lang/ref/WeakReference;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Ref.WeakReference> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mClientRef.Ljava/lang/ref/WeakReference;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='ClientAuthHandler']/field[@name='mHandler']"
		[Register ("mHandler")]
		protected global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceHandler MHandler {
			get {
				const string __id = "mHandler.Lcom/aliyun/alink/linksdk/alcs/api/client/IDeviceHandler;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceHandler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mHandler.Lcom/aliyun/alink/linksdk/alcs/api/client/IDeviceHandler;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: com.aliyun.alink.linksdk.alcs.coap.IAuthHandler

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/interface[@name='IAuthHandler']/field[@name='AUTH_ACCESS_TOKEN_INVALID']"
			[Register ("AUTH_ACCESS_TOKEN_INVALID")]
			public const int AuthAccessTokenInvalid = (int) 502;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/interface[@name='IAuthHandler']/field[@name='AUTH_ACCESS_TOKEN_REVOKE']"
			[Register ("AUTH_ACCESS_TOKEN_REVOKE")]
			public const int AuthAccessTokenRevoke = (int) 501;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/interface[@name='IAuthHandler']/field[@name='AUTH_AUTH_ILLEGALSIGN']"
			[Register ("AUTH_AUTH_ILLEGALSIGN")]
			public const int AuthAuthIllegalsign = (int) 506;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/interface[@name='IAuthHandler']/field[@name='AUTH_SUCCESS']"
			[Register ("AUTH_SUCCESS")]
			public const int AuthSuccess = (int) 200;
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/api/client/ClientAuthHandler", typeof (ClientAuthHandler));
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

		protected ClientAuthHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='ClientAuthHandler']/constructor[@name='ClientAuthHandler' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.api.client.AlcsClient'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.api.client.IDeviceHandler']]"
		[Register (".ctor", "(Lcom/aliyun/alink/linksdk/alcs/api/client/AlcsClient;Lcom/aliyun/alink/linksdk/alcs/api/client/IDeviceHandler;)V", "")]
		public unsafe ClientAuthHandler (global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient client, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceHandler handler)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/aliyun/alink/linksdk/alcs/api/client/AlcsClient;Lcom/aliyun/alink/linksdk/alcs/api/client/IDeviceHandler;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				__args [1] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onAuthResult_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetOnAuthResult_Ljava_lang_String_IIHandler ()
		{
			if (cb_onAuthResult_Ljava_lang_String_II == null)
				cb_onAuthResult_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnAuthResult_Ljava_lang_String_II);
			return cb_onAuthResult_Ljava_lang_String_II;
		}

		static void n_OnAuthResult_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_ip, int port, int result)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.ClientAuthHandler __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.ClientAuthHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string ip = JNIEnv.GetString (native_ip, JniHandleOwnership.DoNotTransfer);
			__this.OnAuthResult (ip, port, result);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='ClientAuthHandler']/method[@name='onAuthResult' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onAuthResult", "(Ljava/lang/String;II)V", "GetOnAuthResult_Ljava_lang_String_IIHandler")]
		public virtual unsafe void OnAuthResult (string ip, int port, int result)
		{
			const string __id = "onAuthResult.(Ljava/lang/String;II)V";
			IntPtr native_ip = JNIEnv.NewString (ip);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_ip);
				__args [1] = new JniArgumentValue (port);
				__args [2] = new JniArgumentValue (result);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_ip);
			}
		}

	}
}
