using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IOnRrpcResponseHandle']"
	[Register ("com/aliyun/alink/linksdk/channel/core/persistent/IOnRrpcResponseHandle", "", "Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnRrpcResponseHandleInvoker")]
	public partial interface IOnRrpcResponseHandle : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IOnRrpcResponseHandle']/method[@name='onRrpcResponse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.core.base.AResponse']]"
		[Register ("onRrpcResponse", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/base/AResponse;)V", "GetOnRrpcResponse_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnRrpcResponseHandleInvoker, PublicChannelCoreBinding")]
		void OnRrpcResponse (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AResponse p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/core/persistent/IOnRrpcResponseHandle", DoNotGenerateAcw=true)]
	internal partial class IOnRrpcResponseHandleInvoker : global::Java.Lang.Object, IOnRrpcResponseHandle {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/core/persistent/IOnRrpcResponseHandle", typeof (IOnRrpcResponseHandleInvoker));

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

		public static IOnRrpcResponseHandle GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnRrpcResponseHandle> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.channel.core.persistent.IOnRrpcResponseHandle"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnRrpcResponseHandleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRrpcResponse_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_;
#pragma warning disable 0169
		static Delegate GetOnRrpcResponse_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_Handler ()
		{
			if (cb_onRrpcResponse_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_ == null)
				cb_onRrpcResponse_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRrpcResponse_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_);
			return cb_onRrpcResponse_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_;
		}

		static void n_OnRrpcResponse_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnRrpcResponseHandle __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnRrpcResponseHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AResponse p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AResponse> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRrpcResponse (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onRrpcResponse_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_;
		public unsafe void OnRrpcResponse (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AResponse p1)
		{
			if (id_onRrpcResponse_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_ == IntPtr.Zero)
				id_onRrpcResponse_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_ = JNIEnv.GetMethodID (class_ref, "onRrpcResponse", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/base/AResponse;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRrpcResponse_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_base_AResponse_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
