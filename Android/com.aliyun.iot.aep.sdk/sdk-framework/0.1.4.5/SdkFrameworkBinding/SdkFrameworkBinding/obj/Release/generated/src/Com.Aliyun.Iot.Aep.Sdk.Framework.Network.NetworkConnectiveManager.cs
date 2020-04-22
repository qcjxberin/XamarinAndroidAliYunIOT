using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='NetworkConnectiveManager']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/network/NetworkConnectiveManager", DoNotGenerateAcw=true)]
	public partial class NetworkConnectiveManager : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/interface[@name='NetworkConnectiveManager.INetworkChangeListener']"
		[Register ("com/aliyun/iot/aep/sdk/framework/network/NetworkConnectiveManager$INetworkChangeListener", "", "Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager/INetworkChangeListenerInvoker")]
		public partial interface INetworkChangeListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/interface[@name='NetworkConnectiveManager.INetworkChangeListener']/method[@name='onNetworkStateChange' and count(parameter)=2 and parameter[1][@type='android.net.NetworkInfo'] and parameter[2][@type='android.net.Network']]"
			[Register ("onNetworkStateChange", "(Landroid/net/NetworkInfo;Landroid/net/Network;)V", "GetOnNetworkStateChange_Landroid_net_NetworkInfo_Landroid_net_Network_Handler:Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager/INetworkChangeListenerInvoker, SdkFramework")]
			void OnNetworkStateChange (global::Android.Net.NetworkInfo p0, global::Android.Net.Network p1);

		}

		[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/network/NetworkConnectiveManager$INetworkChangeListener", DoNotGenerateAcw=true)]
		internal partial class INetworkChangeListenerInvoker : global::Java.Lang.Object, INetworkChangeListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/network/NetworkConnectiveManager$INetworkChangeListener", typeof (INetworkChangeListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static INetworkChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<INetworkChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.aep.sdk.framework.network.NetworkConnectiveManager.INetworkChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public INetworkChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onNetworkStateChange_Landroid_net_NetworkInfo_Landroid_net_Network_;
#pragma warning disable 0169
			static Delegate GetOnNetworkStateChange_Landroid_net_NetworkInfo_Landroid_net_Network_Handler ()
			{
				if (cb_onNetworkStateChange_Landroid_net_NetworkInfo_Landroid_net_Network_ == null)
					cb_onNetworkStateChange_Landroid_net_NetworkInfo_Landroid_net_Network_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnNetworkStateChange_Landroid_net_NetworkInfo_Landroid_net_Network_);
				return cb_onNetworkStateChange_Landroid_net_NetworkInfo_Landroid_net_Network_;
			}

			static void n_OnNetworkStateChange_Landroid_net_NetworkInfo_Landroid_net_Network_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager.INetworkChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager.INetworkChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.NetworkInfo p0 = global::Java.Lang.Object.GetObject<global::Android.Net.NetworkInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Network p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Network> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnNetworkStateChange (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onNetworkStateChange_Landroid_net_NetworkInfo_Landroid_net_Network_;
			public unsafe void OnNetworkStateChange (global::Android.Net.NetworkInfo p0, global::Android.Net.Network p1)
			{
				if (id_onNetworkStateChange_Landroid_net_NetworkInfo_Landroid_net_Network_ == IntPtr.Zero)
					id_onNetworkStateChange_Landroid_net_NetworkInfo_Landroid_net_Network_ = JNIEnv.GetMethodID (class_ref, "onNetworkStateChange", "(Landroid/net/NetworkInfo;Landroid/net/Network;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNetworkStateChange_Landroid_net_NetworkInfo_Landroid_net_Network_, __args);
			}

		}

		// event args for com.aliyun.iot.aep.sdk.framework.network.NetworkConnectiveManager.INetworkChangeListener.onNetworkStateChange
		public partial class NetworkChangeEventArgs : global::System.EventArgs {

			public NetworkChangeEventArgs (global::Android.Net.NetworkInfo p0, global::Android.Net.Network p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Android.Net.NetworkInfo p0;
			public global::Android.Net.NetworkInfo P0 {
				get { return p0; }
			}

			global::Android.Net.Network p1;
			public global::Android.Net.Network P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/aliyun/iot/aep/sdk/framework/network/NetworkConnectiveManager_INetworkChangeListenerImplementor")]
		internal sealed partial class INetworkChangeListenerImplementor : global::Java.Lang.Object, INetworkChangeListener {

			object sender;

			public INetworkChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/iot/aep/sdk/framework/network/NetworkConnectiveManager_INetworkChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<NetworkChangeEventArgs> Handler;
#pragma warning restore 0649

			public void OnNetworkStateChange (global::Android.Net.NetworkInfo p0, global::Android.Net.Network p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new NetworkChangeEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (INetworkChangeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/network/NetworkConnectiveManager", typeof (NetworkConnectiveManager));
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

		protected NetworkConnectiveManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='NetworkConnectiveManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/aliyun/iot/aep/sdk/framework/network/NetworkConnectiveManager;", "")]
			get {
				const string __id = "getInstance.()Lcom/aliyun/iot/aep/sdk/framework/network/NetworkConnectiveManager;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_deinitNetworkConnectiveManager;
#pragma warning disable 0169
		static Delegate GetDeinitNetworkConnectiveManagerHandler ()
		{
			if (cb_deinitNetworkConnectiveManager == null)
				cb_deinitNetworkConnectiveManager = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeinitNetworkConnectiveManager);
			return cb_deinitNetworkConnectiveManager;
		}

		static void n_DeinitNetworkConnectiveManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeinitNetworkConnectiveManager ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='NetworkConnectiveManager']/method[@name='deinitNetworkConnectiveManager' and count(parameter)=0]"
		[Register ("deinitNetworkConnectiveManager", "()V", "GetDeinitNetworkConnectiveManagerHandler")]
		public virtual unsafe void DeinitNetworkConnectiveManager ()
		{
			const string __id = "deinitNetworkConnectiveManager.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_dispatch_Landroid_net_NetworkInfo_Landroid_net_Network_;
#pragma warning disable 0169
		static Delegate GetDispatch_Landroid_net_NetworkInfo_Landroid_net_Network_Handler ()
		{
			if (cb_dispatch_Landroid_net_NetworkInfo_Landroid_net_Network_ == null)
				cb_dispatch_Landroid_net_NetworkInfo_Landroid_net_Network_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Dispatch_Landroid_net_NetworkInfo_Landroid_net_Network_);
			return cb_dispatch_Landroid_net_NetworkInfo_Landroid_net_Network_;
		}

		static void n_Dispatch_Landroid_net_NetworkInfo_Landroid_net_Network_ (IntPtr jnienv, IntPtr native__this, IntPtr native_networkInfo, IntPtr native_network)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.NetworkInfo networkInfo = global::Java.Lang.Object.GetObject<global::Android.Net.NetworkInfo> (native_networkInfo, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Network network = global::Java.Lang.Object.GetObject<global::Android.Net.Network> (native_network, JniHandleOwnership.DoNotTransfer);
			__this.Dispatch (networkInfo, network);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='NetworkConnectiveManager']/method[@name='dispatch' and count(parameter)=2 and parameter[1][@type='android.net.NetworkInfo'] and parameter[2][@type='android.net.Network']]"
		[Register ("dispatch", "(Landroid/net/NetworkInfo;Landroid/net/Network;)V", "GetDispatch_Landroid_net_NetworkInfo_Landroid_net_Network_Handler")]
		protected virtual unsafe void Dispatch (global::Android.Net.NetworkInfo networkInfo, global::Android.Net.Network network)
		{
			const string __id = "dispatch.(Landroid/net/NetworkInfo;Landroid/net/Network;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((networkInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) networkInfo).Handle);
				__args [1] = new JniArgumentValue ((network == null) ? IntPtr.Zero : ((global::Java.Lang.Object) network).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_initNetworkConnectiveManager_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInitNetworkConnectiveManager_Landroid_content_Context_Handler ()
		{
			if (cb_initNetworkConnectiveManager_Landroid_content_Context_ == null)
				cb_initNetworkConnectiveManager_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitNetworkConnectiveManager_Landroid_content_Context_);
			return cb_initNetworkConnectiveManager_Landroid_content_Context_;
		}

		static void n_InitNetworkConnectiveManager_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.InitNetworkConnectiveManager (context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='NetworkConnectiveManager']/method[@name='initNetworkConnectiveManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initNetworkConnectiveManager", "(Landroid/content/Context;)V", "GetInitNetworkConnectiveManager_Landroid_content_Context_Handler")]
		public virtual unsafe void InitNetworkConnectiveManager (global::Android.Content.Context context)
		{
			const string __id = "initNetworkConnectiveManager.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_registerConnectiveListener_Lcom_aliyun_iot_aep_sdk_framework_network_NetworkConnectiveManager_INetworkChangeListener_;
#pragma warning disable 0169
		static Delegate GetRegisterConnectiveListener_Lcom_aliyun_iot_aep_sdk_framework_network_NetworkConnectiveManager_INetworkChangeListener_Handler ()
		{
			if (cb_registerConnectiveListener_Lcom_aliyun_iot_aep_sdk_framework_network_NetworkConnectiveManager_INetworkChangeListener_ == null)
				cb_registerConnectiveListener_Lcom_aliyun_iot_aep_sdk_framework_network_NetworkConnectiveManager_INetworkChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterConnectiveListener_Lcom_aliyun_iot_aep_sdk_framework_network_NetworkConnectiveManager_INetworkChangeListener_);
			return cb_registerConnectiveListener_Lcom_aliyun_iot_aep_sdk_framework_network_NetworkConnectiveManager_INetworkChangeListener_;
		}

		static void n_RegisterConnectiveListener_Lcom_aliyun_iot_aep_sdk_framework_network_NetworkConnectiveManager_INetworkChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager.INetworkChangeListener listener = (global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager.INetworkChangeListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager.INetworkChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RegisterConnectiveListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='NetworkConnectiveManager']/method[@name='registerConnectiveListener' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.framework.network.NetworkConnectiveManager.INetworkChangeListener']]"
		[Register ("registerConnectiveListener", "(Lcom/aliyun/iot/aep/sdk/framework/network/NetworkConnectiveManager$INetworkChangeListener;)V", "GetRegisterConnectiveListener_Lcom_aliyun_iot_aep_sdk_framework_network_NetworkConnectiveManager_INetworkChangeListener_Handler")]
		public virtual unsafe void RegisterConnectiveListener (global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager.INetworkChangeListener listener)
		{
			const string __id = "registerConnectiveListener.(Lcom/aliyun/iot/aep/sdk/framework/network/NetworkConnectiveManager$INetworkChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unregisterConnectiveListener_Lcom_aliyun_iot_aep_sdk_framework_network_NetworkConnectiveManager_INetworkChangeListener_;
#pragma warning disable 0169
		static Delegate GetUnregisterConnectiveListener_Lcom_aliyun_iot_aep_sdk_framework_network_NetworkConnectiveManager_INetworkChangeListener_Handler ()
		{
			if (cb_unregisterConnectiveListener_Lcom_aliyun_iot_aep_sdk_framework_network_NetworkConnectiveManager_INetworkChangeListener_ == null)
				cb_unregisterConnectiveListener_Lcom_aliyun_iot_aep_sdk_framework_network_NetworkConnectiveManager_INetworkChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterConnectiveListener_Lcom_aliyun_iot_aep_sdk_framework_network_NetworkConnectiveManager_INetworkChangeListener_);
			return cb_unregisterConnectiveListener_Lcom_aliyun_iot_aep_sdk_framework_network_NetworkConnectiveManager_INetworkChangeListener_;
		}

		static void n_UnregisterConnectiveListener_Lcom_aliyun_iot_aep_sdk_framework_network_NetworkConnectiveManager_INetworkChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager.INetworkChangeListener listener = (global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager.INetworkChangeListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager.INetworkChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterConnectiveListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='NetworkConnectiveManager']/method[@name='unregisterConnectiveListener' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.framework.network.NetworkConnectiveManager.INetworkChangeListener']]"
		[Register ("unregisterConnectiveListener", "(Lcom/aliyun/iot/aep/sdk/framework/network/NetworkConnectiveManager$INetworkChangeListener;)V", "GetUnregisterConnectiveListener_Lcom_aliyun_iot_aep_sdk_framework_network_NetworkConnectiveManager_INetworkChangeListener_Handler")]
		public virtual unsafe void UnregisterConnectiveListener (global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.NetworkConnectiveManager.INetworkChangeListener listener)
		{
			const string __id = "unregisterConnectiveListener.(Lcom/aliyun/iot/aep/sdk/framework/network/NetworkConnectiveManager$INetworkChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
