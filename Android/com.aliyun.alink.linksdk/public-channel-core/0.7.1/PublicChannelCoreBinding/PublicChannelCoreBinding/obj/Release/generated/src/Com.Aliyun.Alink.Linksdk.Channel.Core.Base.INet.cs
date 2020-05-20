using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Core.Base {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/interface[@name='INet']"
	[Register ("com/aliyun/alink/linksdk/channel/core/base/INet", "", "Com.Aliyun.Alink.Linksdk.Channel.Core.Base.INetInvoker")]
	public partial interface INet : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/interface[@name='INet']/method[@name='asyncSend' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.channel.core.base.ARequest'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.core.base.IOnCallListener']]"
		[Register ("asyncSend", "(Lcom/aliyun/alink/linksdk/channel/core/base/ARequest;Lcom/aliyun/alink/linksdk/channel/core/base/IOnCallListener;)Lcom/aliyun/alink/linksdk/channel/core/base/ASend;", "GetAsyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Base.INetInvoker, PublicChannelCoreBinding")]
		global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend AsyncSend (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/interface[@name='INet']/method[@name='retry' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.channel.core.base.ASend']]"
		[Register ("retry", "(Lcom/aliyun/alink/linksdk/channel/core/base/ASend;)V", "GetRetry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Base.INetInvoker, PublicChannelCoreBinding")]
		void Retry (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/core/base/INet", DoNotGenerateAcw=true)]
	internal partial class INetInvoker : global::Java.Lang.Object, INet {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/core/base/INet", typeof (INetInvoker));

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

		public static INet GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INet> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.channel.core.base.INet"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_;
#pragma warning disable 0169
		static Delegate GetAsyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_Handler ()
		{
			if (cb_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_ == null)
				cb_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_);
			return cb_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_;
		}

		static IntPtr n_AsyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.INet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.INet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener p1 = (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncSend (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_;
		public unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend AsyncSend (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener p1)
		{
			if (id_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_ == IntPtr.Zero)
				id_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_ = JNIEnv.GetMethodID (class_ref, "asyncSend", "(Lcom/aliyun/alink/linksdk/channel/core/base/ARequest;Lcom/aliyun/alink/linksdk/channel/core/base/IOnCallListener;)Lcom/aliyun/alink/linksdk/channel/core/base/ASend;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend __ret = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_retry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_;
#pragma warning disable 0169
		static Delegate GetRetry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_Handler ()
		{
			if (cb_retry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_ == null)
				cb_retry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Retry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_);
			return cb_retry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_;
		}

		static void n_Retry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.INet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.INet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Retry (p0);
		}
#pragma warning restore 0169

		IntPtr id_retry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_;
		public unsafe void Retry (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend p0)
		{
			if (id_retry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_ == IntPtr.Zero)
				id_retry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_ = JNIEnv.GetMethodID (class_ref, "retry", "(Lcom/aliyun/alink/linksdk/channel/core/base/ASend;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_retry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_, __args);
		}

	}

}
