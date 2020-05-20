using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='ISendExecutor']"
	[Register ("com/aliyun/alink/linksdk/channel/core/persistent/ISendExecutor", "", "Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.ISendExecutorInvoker")]
	public partial interface ISendExecutor : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='ISendExecutor']/method[@name='asyncSend' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.channel.core.base.ASend']]"
		[Register ("asyncSend", "(Lcom/aliyun/alink/linksdk/channel/core/base/ASend;)V", "GetAsyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.ISendExecutorInvoker, PublicChannelCoreBinding")]
		void AsyncSend (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/core/persistent/ISendExecutor", DoNotGenerateAcw=true)]
	internal partial class ISendExecutorInvoker : global::Java.Lang.Object, ISendExecutor {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/core/persistent/ISendExecutor", typeof (ISendExecutorInvoker));

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

		public static ISendExecutor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISendExecutor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.channel.core.persistent.ISendExecutor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISendExecutorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_;
#pragma warning disable 0169
		static Delegate GetAsyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_Handler ()
		{
			if (cb_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_ == null)
				cb_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AsyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_);
			return cb_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_;
		}

		static void n_AsyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.ISendExecutor __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.ISendExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AsyncSend (p0);
		}
#pragma warning restore 0169

		IntPtr id_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_;
		public unsafe void AsyncSend (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend p0)
		{
			if (id_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_ == IntPtr.Zero)
				id_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_ = JNIEnv.GetMethodID (class_ref, "asyncSend", "(Lcom/aliyun/alink/linksdk/channel/core/base/ASend;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_, __args);
		}

	}

}
