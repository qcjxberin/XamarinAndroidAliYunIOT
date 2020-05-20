using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/interface[@name='IConnectionStateListener']"
	[Register ("com/aliyun/alink/linksdk/channel/core/persistent/event/IConnectionStateListener", "", "Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IConnectionStateListenerInvoker")]
	public partial interface IConnectionStateListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/interface[@name='IConnectionStateListener']/method[@name='onConnectFail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onConnectFail", "(Ljava/lang/String;)V", "GetOnConnectFail_Ljava_lang_String_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IConnectionStateListenerInvoker, PublicChannelCoreBinding")]
		void OnConnectFail (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/interface[@name='IConnectionStateListener']/method[@name='onConnected' and count(parameter)=0]"
		[Register ("onConnected", "()V", "GetOnConnectedHandler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IConnectionStateListenerInvoker, PublicChannelCoreBinding")]
		void OnConnected ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/interface[@name='IConnectionStateListener']/method[@name='onDisconnect' and count(parameter)=0]"
		[Register ("onDisconnect", "()V", "GetOnDisconnectHandler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IConnectionStateListenerInvoker, PublicChannelCoreBinding")]
		void OnDisconnect ();

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/core/persistent/event/IConnectionStateListener", DoNotGenerateAcw=true)]
	internal partial class IConnectionStateListenerInvoker : global::Java.Lang.Object, IConnectionStateListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/core/persistent/event/IConnectionStateListener", typeof (IConnectionStateListenerInvoker));

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

		public static IConnectionStateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectionStateListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.channel.core.persistent.event.IConnectionStateListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectionStateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onConnectFail_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnConnectFail_Ljava_lang_String_Handler ()
		{
			if (cb_onConnectFail_Ljava_lang_String_ == null)
				cb_onConnectFail_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectFail_Ljava_lang_String_);
			return cb_onConnectFail_Ljava_lang_String_;
		}

		static void n_OnConnectFail_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IConnectionStateListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IConnectionStateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectFail (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConnectFail_Ljava_lang_String_;
		public unsafe void OnConnectFail (string p0)
		{
			if (id_onConnectFail_Ljava_lang_String_ == IntPtr.Zero)
				id_onConnectFail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onConnectFail", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectFail_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onConnected;
#pragma warning disable 0169
		static Delegate GetOnConnectedHandler ()
		{
			if (cb_onConnected == null)
				cb_onConnected = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnConnected);
			return cb_onConnected;
		}

		static void n_OnConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IConnectionStateListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IConnectionStateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnected ();
		}
#pragma warning restore 0169

		IntPtr id_onConnected;
		public unsafe void OnConnected ()
		{
			if (id_onConnected == IntPtr.Zero)
				id_onConnected = JNIEnv.GetMethodID (class_ref, "onConnected", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnected);
		}

		static Delegate cb_onDisconnect;
#pragma warning disable 0169
		static Delegate GetOnDisconnectHandler ()
		{
			if (cb_onDisconnect == null)
				cb_onDisconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDisconnect);
			return cb_onDisconnect;
		}

		static void n_OnDisconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IConnectionStateListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.IConnectionStateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnect ();
		}
#pragma warning restore 0169

		IntPtr id_onDisconnect;
		public unsafe void OnDisconnect ()
		{
			if (id_onDisconnect == IntPtr.Zero)
				id_onDisconnect = JNIEnv.GetMethodID (class_ref, "onDisconnect", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDisconnect);
		}

	}

	// event args for com.aliyun.alink.linksdk.channel.core.persistent.event.IConnectionStateListener.onConnectFail
	public partial class ConnectFailEventArgs : global::System.EventArgs {

		public ConnectFailEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/channel/core/persistent/event/IConnectionStateListenerImplementor")]
	internal sealed partial class IConnectionStateListenerImplementor : global::Java.Lang.Object, IConnectionStateListener {

		object sender;

		public IConnectionStateListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/channel/core/persistent/event/IConnectionStateListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ConnectFailEventArgs> OnConnectFailHandler;
#pragma warning restore 0649

		public void OnConnectFail (string p0)
		{
			var __h = OnConnectFailHandler;
			if (__h != null)
				__h (sender, new ConnectFailEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler OnConnectedHandler;
#pragma warning restore 0649

		public void OnConnected ()
		{
			var __h = OnConnectedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnDisconnectHandler;
#pragma warning restore 0649

		public void OnDisconnect ()
		{
			var __h = OnDisconnectHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IConnectionStateListenerImplementor value)
		{
			return value.OnConnectFailHandler == null && value.OnConnectedHandler == null && value.OnDisconnectHandler == null;
		}
	}

}
