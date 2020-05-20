using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Core.Base {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/interface[@name='IOnCallListener']"
	[Register ("com/aliyun/alink/linksdk/channel/core/base/IOnCallListener", "", "Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListenerInvoker")]
	public partial interface IOnCallListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/interface[@name='IOnCallListener']/method[@name='needUISafety' and count(parameter)=0]"
		[Register ("needUISafety", "()Z", "GetNeedUISafetyHandler:Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListenerInvoker, PublicChannelCoreBinding")]
		bool NeedUISafety ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/interface[@name='IOnCallListener']/method[@name='onFailed' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.channel.core.base.ARequest'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.core.base.AError']]"
		[Register ("onFailed", "(Lcom/aliyun/alink/linksdk/channel/core/base/ARequest;Lcom/aliyun/alink/linksdk/channel/core/base/AError;)V", "GetOnFailed_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AError_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListenerInvoker, PublicChannelCoreBinding")]
		void OnFailed (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/interface[@name='IOnCallListener']/method[@name='onSuccess' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.channel.core.base.ARequest'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.core.base.AResponse']]"
		[Register ("onSuccess", "(Lcom/aliyun/alink/linksdk/channel/core/base/ARequest;Lcom/aliyun/alink/linksdk/channel/core/base/AResponse;)V", "GetOnSuccess_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListenerInvoker, PublicChannelCoreBinding")]
		void OnSuccess (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AResponse p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/core/base/IOnCallListener", DoNotGenerateAcw=true)]
	internal partial class IOnCallListenerInvoker : global::Java.Lang.Object, IOnCallListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/core/base/IOnCallListener", typeof (IOnCallListenerInvoker));

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

		public static IOnCallListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnCallListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.channel.core.base.IOnCallListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnCallListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_needUISafety;
#pragma warning disable 0169
		static Delegate GetNeedUISafetyHandler ()
		{
			if (cb_needUISafety == null)
				cb_needUISafety = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_NeedUISafety);
			return cb_needUISafety;
		}

		static bool n_NeedUISafety (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedUISafety ();
		}
#pragma warning restore 0169

		IntPtr id_needUISafety;
		public unsafe bool NeedUISafety ()
		{
			if (id_needUISafety == IntPtr.Zero)
				id_needUISafety = JNIEnv.GetMethodID (class_ref, "needUISafety", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_needUISafety);
		}

		static Delegate cb_onFailed_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AError_;
#pragma warning disable 0169
		static Delegate GetOnFailed_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AError_Handler ()
		{
			if (cb_onFailed_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AError_ == null)
				cb_onFailed_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailed_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AError_);
			return cb_onFailed_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AError_;
		}

		static void n_OnFailed_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onFailed_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AError_;
		public unsafe void OnFailed (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1)
		{
			if (id_onFailed_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AError_ == IntPtr.Zero)
				id_onFailed_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AError_ = JNIEnv.GetMethodID (class_ref, "onFailed", "(Lcom/aliyun/alink/linksdk/channel/core/base/ARequest;Lcom/aliyun/alink/linksdk/channel/core/base/AError;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailed_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AError_, __args);
		}

		static Delegate cb_onSuccess_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_Handler ()
		{
			if (cb_onSuccess_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_ == null)
				cb_onSuccess_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSuccess_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_);
			return cb_onSuccess_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_;
		}

		static void n_OnSuccess_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AResponse p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AResponse> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_;
		public unsafe void OnSuccess (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AResponse p1)
		{
			if (id_onSuccess_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_ == IntPtr.Zero)
				id_onSuccess_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/aliyun/alink/linksdk/channel/core/base/ARequest;Lcom/aliyun/alink/linksdk/channel/core/base/AResponse;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_, __args);
		}

	}

	// event args for com.aliyun.alink.linksdk.channel.core.base.IOnCallListener.needUISafety
	public partial class NeedUISafetyEventArgs : global::System.EventArgs {

		public NeedUISafetyEventArgs (bool handled)
		{
			this.handled = handled;
		}

		bool handled;
		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}
	}

	// event args for com.aliyun.alink.linksdk.channel.core.base.IOnCallListener.onFailed
	public partial class FailedEventArgs : global::System.EventArgs {

		public FailedEventArgs (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest p0;
		public global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest P0 {
			get { return p0; }
		}

		global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1;
		public global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError P1 {
			get { return p1; }
		}
	}

	// event args for com.aliyun.alink.linksdk.channel.core.base.IOnCallListener.onSuccess
	public partial class SuccessEventArgs : global::System.EventArgs {

		public SuccessEventArgs (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AResponse p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest p0;
		public global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest P0 {
			get { return p0; }
		}

		global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AResponse p1;
		public global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AResponse P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/channel/core/base/IOnCallListenerImplementor")]
	internal sealed partial class IOnCallListenerImplementor : global::Java.Lang.Object, IOnCallListener {

		object sender;

		public IOnCallListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/channel/core/base/IOnCallListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<NeedUISafetyEventArgs> NeedUISafetyHandler;
#pragma warning restore 0649

		public bool NeedUISafety ()
		{
			var __h = NeedUISafetyHandler;
			if (__h == null)
				return false;
			var __e = new NeedUISafetyEventArgs (true);
			__h (sender, __e);
			return __e.Handled;
		}
#pragma warning disable 0649
		public EventHandler<FailedEventArgs> OnFailedHandler;
#pragma warning restore 0649

		public void OnFailed (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AError p1)
		{
			var __h = OnFailedHandler;
			if (__h != null)
				__h (sender, new FailedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<SuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

		public void OnSuccess (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AResponse p1)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new SuccessEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnCallListenerImplementor value)
		{
			return value.NeedUISafetyHandler == null && value.OnFailedHandler == null && value.OnSuccessHandler == null;
		}
	}

}
