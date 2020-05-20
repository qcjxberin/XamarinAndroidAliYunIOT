using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/interface[@name='INetSessionStateListener']"
	[Register ("com/aliyun/alink/linksdk/channel/core/persistent/event/INetSessionStateListener", "", "Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.INetSessionStateListenerInvoker")]
	public partial interface INetSessionStateListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/interface[@name='INetSessionStateListener']/method[@name='onNeedLogin' and count(parameter)=0]"
		[Register ("onNeedLogin", "()V", "GetOnNeedLoginHandler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.INetSessionStateListenerInvoker, PublicChannelCoreBinding")]
		void OnNeedLogin ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/interface[@name='INetSessionStateListener']/method[@name='onSessionEffective' and count(parameter)=0]"
		[Register ("onSessionEffective", "()V", "GetOnSessionEffectiveHandler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.INetSessionStateListenerInvoker, PublicChannelCoreBinding")]
		void OnSessionEffective ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.event']/interface[@name='INetSessionStateListener']/method[@name='onSessionInvalid' and count(parameter)=0]"
		[Register ("onSessionInvalid", "()V", "GetOnSessionInvalidHandler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.INetSessionStateListenerInvoker, PublicChannelCoreBinding")]
		void OnSessionInvalid ();

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/core/persistent/event/INetSessionStateListener", DoNotGenerateAcw=true)]
	internal partial class INetSessionStateListenerInvoker : global::Java.Lang.Object, INetSessionStateListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/core/persistent/event/INetSessionStateListener", typeof (INetSessionStateListenerInvoker));

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

		public static INetSessionStateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetSessionStateListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.channel.core.persistent.event.INetSessionStateListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetSessionStateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onNeedLogin;
#pragma warning disable 0169
		static Delegate GetOnNeedLoginHandler ()
		{
			if (cb_onNeedLogin == null)
				cb_onNeedLogin = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnNeedLogin);
			return cb_onNeedLogin;
		}

		static void n_OnNeedLogin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.INetSessionStateListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.INetSessionStateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNeedLogin ();
		}
#pragma warning restore 0169

		IntPtr id_onNeedLogin;
		public unsafe void OnNeedLogin ()
		{
			if (id_onNeedLogin == IntPtr.Zero)
				id_onNeedLogin = JNIEnv.GetMethodID (class_ref, "onNeedLogin", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNeedLogin);
		}

		static Delegate cb_onSessionEffective;
#pragma warning disable 0169
		static Delegate GetOnSessionEffectiveHandler ()
		{
			if (cb_onSessionEffective == null)
				cb_onSessionEffective = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSessionEffective);
			return cb_onSessionEffective;
		}

		static void n_OnSessionEffective (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.INetSessionStateListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.INetSessionStateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSessionEffective ();
		}
#pragma warning restore 0169

		IntPtr id_onSessionEffective;
		public unsafe void OnSessionEffective ()
		{
			if (id_onSessionEffective == IntPtr.Zero)
				id_onSessionEffective = JNIEnv.GetMethodID (class_ref, "onSessionEffective", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSessionEffective);
		}

		static Delegate cb_onSessionInvalid;
#pragma warning disable 0169
		static Delegate GetOnSessionInvalidHandler ()
		{
			if (cb_onSessionInvalid == null)
				cb_onSessionInvalid = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSessionInvalid);
			return cb_onSessionInvalid;
		}

		static void n_OnSessionInvalid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.INetSessionStateListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Event.INetSessionStateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSessionInvalid ();
		}
#pragma warning restore 0169

		IntPtr id_onSessionInvalid;
		public unsafe void OnSessionInvalid ()
		{
			if (id_onSessionInvalid == IntPtr.Zero)
				id_onSessionInvalid = JNIEnv.GetMethodID (class_ref, "onSessionInvalid", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSessionInvalid);
		}

	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/channel/core/persistent/event/INetSessionStateListenerImplementor")]
	internal sealed partial class INetSessionStateListenerImplementor : global::Java.Lang.Object, INetSessionStateListener {

		object sender;

		public INetSessionStateListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/channel/core/persistent/event/INetSessionStateListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnNeedLoginHandler;
#pragma warning restore 0649

		public void OnNeedLogin ()
		{
			var __h = OnNeedLoginHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnSessionEffectiveHandler;
#pragma warning restore 0649

		public void OnSessionEffective ()
		{
			var __h = OnSessionEffectiveHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnSessionInvalidHandler;
#pragma warning restore 0649

		public void OnSessionInvalid ()
		{
			var __h = OnSessionInvalidHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (INetSessionStateListenerImplementor value)
		{
			return value.OnNeedLoginHandler == null && value.OnSessionEffectiveHandler == null && value.OnSessionInvalidHandler == null;
		}
	}

}
