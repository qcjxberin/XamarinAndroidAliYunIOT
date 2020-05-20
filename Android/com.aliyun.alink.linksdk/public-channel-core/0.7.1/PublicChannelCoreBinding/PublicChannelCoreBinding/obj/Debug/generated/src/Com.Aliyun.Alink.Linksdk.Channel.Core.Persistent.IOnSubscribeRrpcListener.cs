using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IOnSubscribeRrpcListener']"
	[Register ("com/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeRrpcListener", "", "Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListenerInvoker")]
	public partial interface IOnSubscribeRrpcListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IOnSubscribeRrpcListener']/method[@name='needUISafety' and count(parameter)=0]"
		[Register ("needUISafety", "()Z", "GetIOnSubscribeRrpcListenerNeedUISafetyHandler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListenerInvoker, PublicChannelCoreBinding")]
		bool IOnSubscribeRrpcListenerNeedUISafety ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IOnSubscribeRrpcListener']/method[@name='onReceived' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.core.persistent.PersistentRequest'] and parameter[3][@type='com.aliyun.alink.linksdk.channel.core.persistent.IOnRrpcResponseHandle']]"
		[Register ("onReceived", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/persistent/PersistentRequest;Lcom/aliyun/alink/linksdk/channel/core/persistent/IOnRrpcResponseHandle;)V", "GetOnReceived_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentRequest_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnRrpcResponseHandle_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListenerInvoker, PublicChannelCoreBinding")]
		void OnReceived (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentRequest p1, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnRrpcResponseHandle p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IOnSubscribeRrpcListener']/method[@name='onResponseFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.core.base.AError']]"
		[Register ("onResponseFailed", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/base/AError;)V", "GetOnResponseFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListenerInvoker, PublicChannelCoreBinding")]
		void OnResponseFailed (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IOnSubscribeRrpcListener']/method[@name='onResponseSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onResponseSuccess", "(Ljava/lang/String;)V", "GetOnResponseSuccess_Ljava_lang_String_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListenerInvoker, PublicChannelCoreBinding")]
		void OnResponseSuccess (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IOnSubscribeRrpcListener']/method[@name='onSubscribeFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.core.base.AError']]"
		[Register ("onSubscribeFailed", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/base/AError;)V", "GetOnSubscribeFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListenerInvoker, PublicChannelCoreBinding")]
		void OnSubscribeFailed (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IOnSubscribeRrpcListener']/method[@name='onSubscribeSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSubscribeSuccess", "(Ljava/lang/String;)V", "GetOnSubscribeSuccess_Ljava_lang_String_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListenerInvoker, PublicChannelCoreBinding")]
		void OnSubscribeSuccess (string p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeRrpcListener", DoNotGenerateAcw=true)]
	internal partial class IOnSubscribeRrpcListenerInvoker : global::Java.Lang.Object, IOnSubscribeRrpcListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeRrpcListener", typeof (IOnSubscribeRrpcListenerInvoker));

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

		public static IOnSubscribeRrpcListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnSubscribeRrpcListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.channel.core.persistent.IOnSubscribeRrpcListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnSubscribeRrpcListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_needUISafety;
#pragma warning disable 0169
		static Delegate GetIOnSubscribeRrpcListenerNeedUISafetyHandler ()
		{
			if (cb_needUISafety == null)
				cb_needUISafety = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IOnSubscribeRrpcListenerNeedUISafety);
			return cb_needUISafety;
		}

		static bool n_IOnSubscribeRrpcListenerNeedUISafety (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IOnSubscribeRrpcListenerNeedUISafety ();
		}
#pragma warning restore 0169

		IntPtr id_needUISafety;
		public unsafe bool IOnSubscribeRrpcListenerNeedUISafety ()
		{
			if (id_needUISafety == IntPtr.Zero)
				id_needUISafety = JNIEnv.GetMethodID (class_ref, "needUISafety", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_needUISafety);
		}

		static Delegate cb_onReceived_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentRequest_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnRrpcResponseHandle_;
#pragma warning disable 0169
		static Delegate GetOnReceived_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentRequest_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnRrpcResponseHandle_Handler ()
		{
			if (cb_onReceived_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentRequest_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnRrpcResponseHandle_ == null)
				cb_onReceived_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentRequest_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnRrpcResponseHandle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceived_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentRequest_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnRrpcResponseHandle_);
			return cb_onReceived_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentRequest_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnRrpcResponseHandle_;
		}

		static void n_OnReceived_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentRequest_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnRrpcResponseHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentRequest p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnRrpcResponseHandle p2 = (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnRrpcResponseHandle)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnRrpcResponseHandle> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnReceived (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onReceived_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentRequest_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnRrpcResponseHandle_;
		public unsafe void OnReceived (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentRequest p1, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnRrpcResponseHandle p2)
		{
			if (id_onReceived_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentRequest_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnRrpcResponseHandle_ == IntPtr.Zero)
				id_onReceived_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentRequest_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnRrpcResponseHandle_ = JNIEnv.GetMethodID (class_ref, "onReceived", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/persistent/PersistentRequest;Lcom/aliyun/alink/linksdk/channel/core/persistent/IOnRrpcResponseHandle;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceived_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentRequest_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnRrpcResponseHandle_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onResponseFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_;
#pragma warning disable 0169
		static Delegate GetOnResponseFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_Handler ()
		{
			if (cb_onResponseFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_ == null)
				cb_onResponseFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnResponseFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_);
			return cb_onResponseFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_;
		}

		static void n_OnResponseFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnResponseFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onResponseFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_;
		public unsafe void OnResponseFailed (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1)
		{
			if (id_onResponseFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_ == IntPtr.Zero)
				id_onResponseFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_ = JNIEnv.GetMethodID (class_ref, "onResponseFailed", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/base/AError;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResponseFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onResponseSuccess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnResponseSuccess_Ljava_lang_String_Handler ()
		{
			if (cb_onResponseSuccess_Ljava_lang_String_ == null)
				cb_onResponseSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResponseSuccess_Ljava_lang_String_);
			return cb_onResponseSuccess_Ljava_lang_String_;
		}

		static void n_OnResponseSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResponseSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onResponseSuccess_Ljava_lang_String_;
		public unsafe void OnResponseSuccess (string p0)
		{
			if (id_onResponseSuccess_Ljava_lang_String_ == IntPtr.Zero)
				id_onResponseSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onResponseSuccess", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResponseSuccess_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onSubscribeFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_;
#pragma warning disable 0169
		static Delegate GetOnSubscribeFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_Handler ()
		{
			if (cb_onSubscribeFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_ == null)
				cb_onSubscribeFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSubscribeFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_);
			return cb_onSubscribeFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_;
		}

		static void n_OnSubscribeFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSubscribeFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSubscribeFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_;
		public unsafe void OnSubscribeFailed (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1)
		{
			if (id_onSubscribeFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_ == IntPtr.Zero)
				id_onSubscribeFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_ = JNIEnv.GetMethodID (class_ref, "onSubscribeFailed", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/base/AError;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSubscribeFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onSubscribeSuccess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSubscribeSuccess_Ljava_lang_String_Handler ()
		{
			if (cb_onSubscribeSuccess_Ljava_lang_String_ == null)
				cb_onSubscribeSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSubscribeSuccess_Ljava_lang_String_);
			return cb_onSubscribeSuccess_Ljava_lang_String_;
		}

		static void n_OnSubscribeSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSubscribeSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSubscribeSuccess_Ljava_lang_String_;
		public unsafe void OnSubscribeSuccess (string p0)
		{
			if (id_onSubscribeSuccess_Ljava_lang_String_ == IntPtr.Zero)
				id_onSubscribeSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSubscribeSuccess", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSubscribeSuccess_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.aliyun.alink.linksdk.channel.core.persistent.IOnSubscribeRrpcListener.needUISafety
	public partial class IOnSubscribeRrpcListenerNeedUISafetyEventArgs : global::System.EventArgs {

		public IOnSubscribeRrpcListenerNeedUISafetyEventArgs (bool handled)
		{
			this.handled = handled;
		}

		bool handled;
		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}
	}

	// event args for com.aliyun.alink.linksdk.channel.core.persistent.IOnSubscribeRrpcListener.onReceived
	public partial class ReceivedEventArgs : global::System.EventArgs {

		public ReceivedEventArgs (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentRequest p1, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnRrpcResponseHandle p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentRequest p1;
		public global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentRequest P1 {
			get { return p1; }
		}

		global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnRrpcResponseHandle p2;
		public global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnRrpcResponseHandle P2 {
			get { return p2; }
		}
	}

	// event args for com.aliyun.alink.linksdk.channel.core.persistent.IOnSubscribeRrpcListener.onResponseFailed
	public partial class ResponseFailedEventArgs : global::System.EventArgs {

		public ResponseFailedEventArgs (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1;
		public global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError P1 {
			get { return p1; }
		}
	}

	// event args for com.aliyun.alink.linksdk.channel.core.persistent.IOnSubscribeRrpcListener.onResponseSuccess
	public partial class ResponseSuccessEventArgs : global::System.EventArgs {

		public ResponseSuccessEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	// event args for com.aliyun.alink.linksdk.channel.core.persistent.IOnSubscribeRrpcListener.onSubscribeFailed
	public partial class SubscribeFailedEventArgs : global::System.EventArgs {

		public SubscribeFailedEventArgs (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1;
		public global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError P1 {
			get { return p1; }
		}
	}

	// event args for com.aliyun.alink.linksdk.channel.core.persistent.IOnSubscribeRrpcListener.onSubscribeSuccess
	public partial class SubscribeSuccessEventArgs : global::System.EventArgs {

		public SubscribeSuccessEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeRrpcListenerImplementor")]
	internal sealed partial class IOnSubscribeRrpcListenerImplementor : global::Java.Lang.Object, IOnSubscribeRrpcListener {

		object sender;

		public IOnSubscribeRrpcListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeRrpcListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<IOnSubscribeRrpcListenerNeedUISafetyEventArgs> IOnSubscribeRrpcListenerNeedUISafetyHandler;
#pragma warning restore 0649

		public bool IOnSubscribeRrpcListenerNeedUISafety ()
		{
			var __h = IOnSubscribeRrpcListenerNeedUISafetyHandler;
			if (__h == null)
				return false;
			var __e = new IOnSubscribeRrpcListenerNeedUISafetyEventArgs (true);
			__h (sender, __e);
			return __e.Handled;
		}
#pragma warning disable 0649
		public EventHandler<ReceivedEventArgs> OnReceivedHandler;
#pragma warning restore 0649

		public void OnReceived (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentRequest p1, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnRrpcResponseHandle p2)
		{
			var __h = OnReceivedHandler;
			if (__h != null)
				__h (sender, new ReceivedEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public EventHandler<ResponseFailedEventArgs> OnResponseFailedHandler;
#pragma warning restore 0649

		public void OnResponseFailed (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1)
		{
			var __h = OnResponseFailedHandler;
			if (__h != null)
				__h (sender, new ResponseFailedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<ResponseSuccessEventArgs> OnResponseSuccessHandler;
#pragma warning restore 0649

		public void OnResponseSuccess (string p0)
		{
			var __h = OnResponseSuccessHandler;
			if (__h != null)
				__h (sender, new ResponseSuccessEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<SubscribeFailedEventArgs> OnSubscribeFailedHandler;
#pragma warning restore 0649

		public void OnSubscribeFailed (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1)
		{
			var __h = OnSubscribeFailedHandler;
			if (__h != null)
				__h (sender, new SubscribeFailedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<SubscribeSuccessEventArgs> OnSubscribeSuccessHandler;
#pragma warning restore 0649

		public void OnSubscribeSuccess (string p0)
		{
			var __h = OnSubscribeSuccessHandler;
			if (__h != null)
				__h (sender, new SubscribeSuccessEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnSubscribeRrpcListenerImplementor value)
		{
			return value.IOnSubscribeRrpcListenerNeedUISafetyHandler == null && value.OnReceivedHandler == null && value.OnResponseFailedHandler == null && value.OnResponseSuccessHandler == null && value.OnSubscribeFailedHandler == null && value.OnSubscribeSuccessHandler == null;
		}
	}

}
