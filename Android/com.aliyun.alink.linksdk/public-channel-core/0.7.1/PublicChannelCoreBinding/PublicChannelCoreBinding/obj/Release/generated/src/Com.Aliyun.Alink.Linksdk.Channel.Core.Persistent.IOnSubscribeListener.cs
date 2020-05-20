using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IOnSubscribeListener']"
	[Register ("com/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeListener", "", "Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListenerInvoker")]
	public partial interface IOnSubscribeListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IOnSubscribeListener']/method[@name='needUISafety' and count(parameter)=0]"
		[Register ("needUISafety", "()Z", "GetIOnSubscribeListenerNeedUISafetyHandler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListenerInvoker, PublicChannelCoreBinding")]
		bool IOnSubscribeListenerNeedUISafety ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IOnSubscribeListener']/method[@name='onFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.core.base.AError']]"
		[Register ("onFailed", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/base/AError;)V", "GetOnFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListenerInvoker, PublicChannelCoreBinding")]
		void OnFailed (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IOnSubscribeListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListenerInvoker, PublicChannelCoreBinding")]
		void OnSuccess (string p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeListener", DoNotGenerateAcw=true)]
	internal partial class IOnSubscribeListenerInvoker : global::Java.Lang.Object, IOnSubscribeListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeListener", typeof (IOnSubscribeListenerInvoker));

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

		public static IOnSubscribeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnSubscribeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.channel.core.persistent.IOnSubscribeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnSubscribeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_needUISafety;
#pragma warning disable 0169
		static Delegate GetIOnSubscribeListenerNeedUISafetyHandler ()
		{
			if (cb_needUISafety == null)
				cb_needUISafety = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IOnSubscribeListenerNeedUISafety);
			return cb_needUISafety;
		}

		static bool n_IOnSubscribeListenerNeedUISafety (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IOnSubscribeListenerNeedUISafety ();
		}
#pragma warning restore 0169

		IntPtr id_needUISafety;
		public unsafe bool IOnSubscribeListenerNeedUISafety ()
		{
			if (id_needUISafety == IntPtr.Zero)
				id_needUISafety = JNIEnv.GetMethodID (class_ref, "needUISafety", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_needUISafety);
		}

		static Delegate cb_onFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_;
#pragma warning disable 0169
		static Delegate GetOnFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_Handler ()
		{
			if (cb_onFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_ == null)
				cb_onFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_);
			return cb_onFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_;
		}

		static void n_OnFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_;
		public unsafe void OnFailed (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1)
		{
			if (id_onFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_ == IntPtr.Zero)
				id_onFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_ = JNIEnv.GetMethodID (class_ref, "onFailed", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/base/AError;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailed_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AError_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onSuccess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_String_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_String_ == null)
				cb_onSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_String_);
			return cb_onSuccess_Ljava_lang_String_;
		}

		static void n_OnSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_lang_String_;
		public unsafe void OnSuccess (string p0)
		{
			if (id_onSuccess_Ljava_lang_String_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.aliyun.alink.linksdk.channel.core.persistent.IOnSubscribeListener.needUISafety
	public partial class IOnSubscribeListenerNeedUISafetyEventArgs : global::System.EventArgs {

		public IOnSubscribeListenerNeedUISafetyEventArgs (bool handled)
		{
			this.handled = handled;
		}

		bool handled;
		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}
	}

	// event args for com.aliyun.alink.linksdk.channel.core.persistent.IOnSubscribeListener.onFailed
	public partial class FailedEventArgs : global::System.EventArgs {

		public FailedEventArgs (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1)
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

	// event args for com.aliyun.alink.linksdk.channel.core.persistent.IOnSubscribeListener.onSuccess
	public partial class SuccessEventArgs : global::System.EventArgs {

		public SuccessEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeListenerImplementor")]
	internal sealed partial class IOnSubscribeListenerImplementor : global::Java.Lang.Object, IOnSubscribeListener {

		object sender;

		public IOnSubscribeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<IOnSubscribeListenerNeedUISafetyEventArgs> IOnSubscribeListenerNeedUISafetyHandler;
#pragma warning restore 0649

		public bool IOnSubscribeListenerNeedUISafety ()
		{
			var __h = IOnSubscribeListenerNeedUISafetyHandler;
			if (__h == null)
				return false;
			var __e = new IOnSubscribeListenerNeedUISafetyEventArgs (true);
			__h (sender, __e);
			return __e.Handled;
		}
#pragma warning disable 0649
		public EventHandler<FailedEventArgs> OnFailedHandler;
#pragma warning restore 0649

		public void OnFailed (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1)
		{
			var __h = OnFailedHandler;
			if (__h != null)
				__h (sender, new FailedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<SuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

		public void OnSuccess (string p0)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new SuccessEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnSubscribeListenerImplementor value)
		{
			return value.IOnSubscribeListenerNeedUISafetyHandler == null && value.OnFailedHandler == null && value.OnSuccessHandler == null;
		}
	}

}
