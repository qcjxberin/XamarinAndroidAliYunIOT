using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Api.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/api/client/AlcsClient", DoNotGenerateAcw=true)]
	public partial class AlcsClient : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/field[@name='mAlcsCoap']"
		[Register ("mAlcsCoap")]
		protected global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP MAlcsCoap {
			get {
				const string __id = "mAlcsCoap.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAP;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAlcsCoap.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAP;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/field[@name='mAlcsContext']"
		[Register ("mAlcsContext")]
		protected global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext MAlcsContext {
			get {
				const string __id = "mAlcsContext.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPContext;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAlcsContext.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPContext;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/field[@name='mConfig']"
		[Register ("mConfig")]
		protected global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig MConfig {
			get {
				const string __id = "mConfig.Lcom/aliyun/alink/linksdk/alcs/api/client/AlcsClientConfig;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mConfig.Lcom/aliyun/alink/linksdk/alcs/api/client/AlcsClientConfig;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/field[@name='mHBListener']"
		[Register ("mHBListener")]
		protected global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IHeartBeatHandler MHBListener {
			get {
				const string __id = "mHBListener.Lcom/aliyun/alink/linksdk/alcs/api/client/IHeartBeatHandler;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IHeartBeatHandler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mHBListener.Lcom/aliyun/alink/linksdk/alcs/api/client/IHeartBeatHandler;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/field[@name='mHbRun']"
		[Register ("mHbRun")]
		protected global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient.HBRun MHbRun {
			get {
				const string __id = "mHbRun.Lcom/aliyun/alink/linksdk/alcs/api/client/AlcsClient$HBRun;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient.HBRun> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mHbRun.Lcom/aliyun/alink/linksdk/alcs/api/client/AlcsClient$HBRun;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/field[@name='mIsIniting']"
		[Register ("mIsIniting")]
		protected bool MIsIniting {
			get {
				const string __id = "mIsIniting.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mIsIniting.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/field[@name='mStateListener']"
		[Register ("mStateListener")]
		protected global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceStateListener MStateListener {
			get {
				const string __id = "mStateListener.Lcom/aliyun/alink/linksdk/alcs/api/client/IDeviceStateListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceStateListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mStateListener.Lcom/aliyun/alink/linksdk/alcs/api/client/IDeviceStateListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient.HBRun']"
		[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/api/client/AlcsClient$HBRun", DoNotGenerateAcw=true)]
		protected internal partial class HBRun : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/api/client/AlcsClient$HBRun", typeof (HBRun));
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

			protected HBRun (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient.HBRun']/constructor[@name='AlcsClient.HBRun' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.api.client.AlcsClient']]"
			[Register (".ctor", "(Lcom/aliyun/alink/linksdk/alcs/api/client/AlcsClient;)V", "")]
			public unsafe HBRun (global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient client)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/aliyun/alink/linksdk/alcs/api/client/AlcsClient;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient.HBRun __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient.HBRun> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient.HBRun']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				const string __id = "run.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient.MessageHandler']"
		[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/api/client/AlcsClient$MessageHandler", DoNotGenerateAcw=true)]
		protected internal partial class MessageHandler : global::Android.OS.Handler {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/api/client/AlcsClient$MessageHandler", typeof (MessageHandler));
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

			protected MessageHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient.MessageHandler']/constructor[@name='AlcsClient.MessageHandler' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			protected unsafe MessageHandler ()
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

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/api/client/AlcsClient", typeof (AlcsClient));
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

		protected AlcsClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/constructor[@name='AlcsClient' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.api.client.AlcsClientConfig']]"
		[Register (".ctor", "(Lcom/aliyun/alink/linksdk/alcs/api/client/AlcsClientConfig;)V", "")]
		public unsafe AlcsClient (global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig config)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/aliyun/alink/linksdk/alcs/api/client/AlcsClientConfig;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isInit;
#pragma warning disable 0169
		static Delegate GetIsInitHandler ()
		{
			if (cb_isInit == null)
				cb_isInit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInit);
			return cb_isInit;
		}

		static bool n_IsInit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInit;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsInit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/method[@name='isInit' and count(parameter)=0]"
			[Register ("isInit", "()Z", "GetIsInitHandler")]
			get {
				const string __id = "isInit.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isServerOnline;
#pragma warning disable 0169
		static Delegate GetIsServerOnlineHandler ()
		{
			if (cb_isServerOnline == null)
				cb_isServerOnline = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsServerOnline);
			return cb_isServerOnline;
		}

		static bool n_IsServerOnline (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsServerOnline;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsServerOnline {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/method[@name='isServerOnline' and count(parameter)=0]"
			[Register ("isServerOnline", "()Z", "GetIsServerOnlineHandler")]
			get {
				const string __id = "isServerOnline.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_cancelRequest_J;
#pragma warning disable 0169
		static Delegate GetCancelRequest_JHandler ()
		{
			if (cb_cancelRequest_J == null)
				cb_cancelRequest_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_CancelRequest_J);
			return cb_cancelRequest_J;
		}

		static bool n_CancelRequest_J (IntPtr jnienv, IntPtr native__this, long msgId)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CancelRequest (msgId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/method[@name='cancelRequest' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("cancelRequest", "(J)Z", "GetCancelRequest_JHandler")]
		public virtual unsafe bool CancelRequest (long msgId)
		{
			const string __id = "cancelRequest.(J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (msgId);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		protected virtual unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_init_Lcom_aliyun_alink_linksdk_alcs_api_client_IDeviceHandler_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_aliyun_alink_linksdk_alcs_api_client_IDeviceHandler_Handler ()
		{
			if (cb_init_Lcom_aliyun_alink_linksdk_alcs_api_client_IDeviceHandler_ == null)
				cb_init_Lcom_aliyun_alink_linksdk_alcs_api_client_IDeviceHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Lcom_aliyun_alink_linksdk_alcs_api_client_IDeviceHandler_);
			return cb_init_Lcom_aliyun_alink_linksdk_alcs_api_client_IDeviceHandler_;
		}

		static void n_Init_Lcom_aliyun_alink_linksdk_alcs_api_client_IDeviceHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceHandler @callback = (global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceHandler)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceHandler> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Init (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.api.client.IDeviceHandler']]"
		[Register ("init", "(Lcom/aliyun/alink/linksdk/alcs/api/client/IDeviceHandler;)V", "GetInit_Lcom_aliyun_alink_linksdk_alcs_api_client_IDeviceHandler_Handler")]
		public virtual unsafe void Init (global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceHandler @callback)
		{
			const string __id = "init.(Lcom/aliyun/alink/linksdk/alcs/api/client/IDeviceHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onAuth_ZILcom_aliyun_alink_linksdk_alcs_api_client_IDeviceHandler_;
#pragma warning disable 0169
		static Delegate GetOnAuth_ZILcom_aliyun_alink_linksdk_alcs_api_client_IDeviceHandler_Handler ()
		{
			if (cb_onAuth_ZILcom_aliyun_alink_linksdk_alcs_api_client_IDeviceHandler_ == null)
				cb_onAuth_ZILcom_aliyun_alink_linksdk_alcs_api_client_IDeviceHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, IntPtr>) n_OnAuth_ZILcom_aliyun_alink_linksdk_alcs_api_client_IDeviceHandler_);
			return cb_onAuth_ZILcom_aliyun_alink_linksdk_alcs_api_client_IDeviceHandler_;
		}

		static void n_OnAuth_ZILcom_aliyun_alink_linksdk_alcs_api_client_IDeviceHandler_ (IntPtr jnienv, IntPtr native__this, bool isSuccess, int errorCode, IntPtr native__callback)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceHandler @callback = (global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceHandler)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceHandler> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.OnAuth (isSuccess, errorCode, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/method[@name='onAuth' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.api.client.IDeviceHandler']]"
		[Register ("onAuth", "(ZILcom/aliyun/alink/linksdk/alcs/api/client/IDeviceHandler;)V", "GetOnAuth_ZILcom_aliyun_alink_linksdk_alcs_api_client_IDeviceHandler_Handler")]
		public virtual unsafe void OnAuth (bool isSuccess, int errorCode, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceHandler @callback)
		{
			const string __id = "onAuth.(ZILcom/aliyun/alink/linksdk/alcs/api/client/IDeviceHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (isSuccess);
				__args [1] = new JniArgumentValue (errorCode);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_registerAllResource_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_;
#pragma warning disable 0169
		static Delegate GetRegisterAllResource_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Handler ()
		{
			if (cb_registerAllResource_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_ == null)
				cb_registerAllResource_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterAllResource_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_);
			return cb_registerAllResource_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_;
		}

		static bool n_RegisterAllResource_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_resource)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource resource = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (native_resource, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterAllResource (resource);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/method[@name='registerAllResource' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.resources.AlcsCoAPResource']]"
		[Register ("registerAllResource", "(Lcom/aliyun/alink/linksdk/alcs/coap/resources/AlcsCoAPResource;)Z", "GetRegisterAllResource_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Handler")]
		public virtual unsafe bool RegisterAllResource (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource resource)
		{
			const string __id = "registerAllResource.(Lcom/aliyun/alink/linksdk/alcs/coap/resources/AlcsCoAPResource;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((resource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resource).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_sendRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_;
#pragma warning disable 0169
		static Delegate GetSendRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_Handler ()
		{
			if (cb_sendRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ == null)
				cb_sendRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_SendRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_);
			return cb_sendRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_;
		}

		static long n_SendRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_requestCallback)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler requestCallback = (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler> (native_requestCallback, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.SendRequest (request, requestCallback);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/method[@name='sendRequest' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPRequest'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.IAlcsCoAPReqHandler']]"
		[Register ("sendRequest", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;)J", "GetSendRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_Handler")]
		public virtual unsafe long SendRequest (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler requestCallback)
		{
			const string __id = "sendRequest.(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((requestCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_sendRequestSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_;
#pragma warning disable 0169
		static Delegate GetSendRequestSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_Handler ()
		{
			if (cb_sendRequestSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ == null)
				cb_sendRequestSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_SendRequestSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_);
			return cb_sendRequestSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_;
		}

		static long n_SendRequestSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_requestCallback)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler requestCallback = (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler> (native_requestCallback, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.SendRequestSecure (request, requestCallback);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/method[@name='sendRequestSecure' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPRequest'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.IAlcsCoAPReqHandler']]"
		[Register ("sendRequestSecure", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;)J", "GetSendRequestSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_Handler")]
		public virtual unsafe long SendRequestSecure (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler requestCallback)
		{
			const string __id = "sendRequestSecure.(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((requestCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_sendResponse_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_;
#pragma warning disable 0169
		static Delegate GetSendResponse_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Handler ()
		{
			if (cb_sendResponse_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ == null)
				cb_sendResponse_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SendResponse_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_);
			return cb_sendResponse_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_;
		}

		static bool n_SendResponse_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_response)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse response = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse> (native_response, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendResponse (response);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/method[@name='sendResponse' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPResponse']]"
		[Register ("sendResponse", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;)Z", "GetSendResponse_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Handler")]
		public virtual unsafe bool SendResponse (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse response)
		{
			const string __id = "sendResponse.(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_sendResponseSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_;
#pragma warning disable 0169
		static Delegate GetSendResponseSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Handler ()
		{
			if (cb_sendResponseSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ == null)
				cb_sendResponseSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SendResponseSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_);
			return cb_sendResponseSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_;
		}

		static bool n_SendResponseSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_response)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse response = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse> (native_response, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendResponseSecure (response);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/method[@name='sendResponseSecure' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPResponse']]"
		[Register ("sendResponseSecure", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;)Z", "GetSendResponseSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Handler")]
		public virtual unsafe bool SendResponseSecure (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse response)
		{
			const string __id = "sendResponseSecure.(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_api_client_IDeviceStateListener_;
#pragma warning disable 0169
		static Delegate GetSetDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_api_client_IDeviceStateListener_Handler ()
		{
			if (cb_setDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_api_client_IDeviceStateListener_ == null)
				cb_setDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_api_client_IDeviceStateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_api_client_IDeviceStateListener_);
			return cb_setDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_api_client_IDeviceStateListener_;
		}

		static void n_SetDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_api_client_IDeviceStateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceStateListener listener = (global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceStateListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceStateListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetDeviceStateListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/method[@name='setDeviceStateListener' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.api.client.IDeviceStateListener']]"
		[Register ("setDeviceStateListener", "(Lcom/aliyun/alink/linksdk/alcs/api/client/IDeviceStateListener;)V", "GetSetDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_api_client_IDeviceStateListener_Handler")]
		public virtual unsafe void SetDeviceStateListener (global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceStateListener listener)
		{
			const string __id = "setDeviceStateListener.(Lcom/aliyun/alink/linksdk/alcs/api/client/IDeviceStateListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setHBListener_Lcom_aliyun_alink_linksdk_alcs_api_client_IHeartBeatHandler_;
#pragma warning disable 0169
		static Delegate GetSetHBListener_Lcom_aliyun_alink_linksdk_alcs_api_client_IHeartBeatHandler_Handler ()
		{
			if (cb_setHBListener_Lcom_aliyun_alink_linksdk_alcs_api_client_IHeartBeatHandler_ == null)
				cb_setHBListener_Lcom_aliyun_alink_linksdk_alcs_api_client_IHeartBeatHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHBListener_Lcom_aliyun_alink_linksdk_alcs_api_client_IHeartBeatHandler_);
			return cb_setHBListener_Lcom_aliyun_alink_linksdk_alcs_api_client_IHeartBeatHandler_;
		}

		static void n_SetHBListener_Lcom_aliyun_alink_linksdk_alcs_api_client_IHeartBeatHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_handler)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IHeartBeatHandler handler = (global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IHeartBeatHandler)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IHeartBeatHandler> (native_handler, JniHandleOwnership.DoNotTransfer);
			__this.SetHBListener (handler);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/method[@name='setHBListener' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.api.client.IHeartBeatHandler']]"
		[Register ("setHBListener", "(Lcom/aliyun/alink/linksdk/alcs/api/client/IHeartBeatHandler;)V", "GetSetHBListener_Lcom_aliyun_alink_linksdk_alcs_api_client_IHeartBeatHandler_Handler")]
		public virtual unsafe void SetHBListener (global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IHeartBeatHandler handler)
		{
			const string __id = "setHBListener.(Lcom/aliyun/alink/linksdk/alcs/api/client/IHeartBeatHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startDiscover_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_;
#pragma warning disable 0169
		static Delegate GetStartDiscover_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_Handler ()
		{
			if (cb_startDiscover_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ == null)
				cb_startDiscover_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_StartDiscover_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_);
			return cb_startDiscover_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_;
		}

		static long n_StartDiscover_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_requestCallback)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler requestCallback = (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler> (native_requestCallback, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.StartDiscover (request, requestCallback);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/method[@name='startDiscover' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPRequest'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.IAlcsCoAPReqHandler']]"
		[Register ("startDiscover", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;)J", "GetStartDiscover_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_Handler")]
		public virtual unsafe long StartDiscover (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler requestCallback)
		{
			const string __id = "startDiscover.(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((requestCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_startHb;
#pragma warning disable 0169
		static Delegate GetStartHbHandler ()
		{
			if (cb_startHb == null)
				cb_startHb = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartHb);
			return cb_startHb;
		}

		static void n_StartHb (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartHb ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/method[@name='startHb' and count(parameter)=0]"
		[Register ("startHb", "()V", "GetStartHbHandler")]
		public virtual unsafe void StartHb ()
		{
			const string __id = "startHb.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stopDiscover_J;
#pragma warning disable 0169
		static Delegate GetStopDiscover_JHandler ()
		{
			if (cb_stopDiscover_J == null)
				cb_stopDiscover_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_StopDiscover_J);
			return cb_stopDiscover_J;
		}

		static bool n_StopDiscover_J (IntPtr jnienv, IntPtr native__this, long msgId)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StopDiscover (msgId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/method[@name='stopDiscover' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("stopDiscover", "(J)Z", "GetStopDiscover_JHandler")]
		public virtual unsafe bool StopDiscover (long msgId)
		{
			const string __id = "stopDiscover.(J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (msgId);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_subscribe_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_Handler ()
		{
			if (cb_subscribe_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ == null)
				cb_subscribe_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_Subscribe_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_);
			return cb_subscribe_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_;
		}

		static long n_Subscribe_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_requestCallback)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler requestCallback = (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler> (native_requestCallback, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Subscribe (request, requestCallback);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPRequest'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.IAlcsCoAPReqHandler']]"
		[Register ("subscribe", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;)J", "GetSubscribe_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_Handler")]
		public virtual unsafe long Subscribe (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler requestCallback)
		{
			const string __id = "subscribe.(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((requestCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_unRegisterResource_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnRegisterResource_Ljava_lang_String_Handler ()
		{
			if (cb_unRegisterResource_Ljava_lang_String_ == null)
				cb_unRegisterResource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_UnRegisterResource_Ljava_lang_String_);
			return cb_unRegisterResource_Ljava_lang_String_;
		}

		static bool n_UnRegisterResource_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UnRegisterResource (path);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/method[@name='unRegisterResource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unRegisterResource", "(Ljava/lang/String;)Z", "GetUnRegisterResource_Ljava_lang_String_Handler")]
		public virtual unsafe bool UnRegisterResource (string path)
		{
			const string __id = "unRegisterResource.(Ljava/lang/String;)Z";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_unSubscribe_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_;
#pragma warning disable 0169
		static Delegate GetUnSubscribe_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_Handler ()
		{
			if (cb_unSubscribe_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ == null)
				cb_unSubscribe_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_UnSubscribe_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_);
			return cb_unSubscribe_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_;
		}

		static long n_UnSubscribe_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_requestCallback)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler requestCallback = (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler> (native_requestCallback, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.UnSubscribe (request, requestCallback);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClient']/method[@name='unSubscribe' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPRequest'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.IAlcsCoAPReqHandler']]"
		[Register ("unSubscribe", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;)J", "GetUnSubscribe_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_Handler")]
		public virtual unsafe long UnSubscribe (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler requestCallback)
		{
			const string __id = "unSubscribe.(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((requestCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

#region "Event implementation for Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceStateListener"
		public event EventHandler<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.DeviceStateEventArgs> DeviceState {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceStateListener, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceStateListenerImplementor>(
						ref weak_implementor_SetDeviceStateListener,
						__CreateIDeviceStateListenerImplementor,
						SetDeviceStateListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceStateListener, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceStateListenerImplementor>(
						ref weak_implementor_SetDeviceStateListener,
						global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceStateListenerImplementor.__IsEmpty,
						__v => SetDeviceStateListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetDeviceStateListener;

		global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceStateListenerImplementor __CreateIDeviceStateListenerImplementor ()
		{
			return new global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceStateListenerImplementor (this);
		}
#endregion
	}
}
