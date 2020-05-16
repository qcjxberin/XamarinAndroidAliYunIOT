using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/interface[@name='ISubDeviceConnectListener']"
	[Register ("com/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceConnectListener", "", "Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListenerInvoker")]
	public partial interface ISubDeviceConnectListener : IJavaObject, IJavaPeerable {

		string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/interface[@name='ISubDeviceConnectListener']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListenerInvoker, PublicChannelGatewayBinding")] get;
		}

		global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> SignExtraData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/interface[@name='ISubDeviceConnectListener']/method[@name='getSignExtraData' and count(parameter)=0]"
			[Register ("getSignExtraData", "()Ljava/util/Map;", "GetGetSignExtraDataHandler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListenerInvoker, PublicChannelGatewayBinding")] get;
		}

		string SignMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/interface[@name='ISubDeviceConnectListener']/method[@name='getSignMethod' and count(parameter)=0]"
			[Register ("getSignMethod", "()Ljava/lang/String;", "GetGetSignMethodHandler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListenerInvoker, PublicChannelGatewayBinding")] get;
		}

		string SignValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/interface[@name='ISubDeviceConnectListener']/method[@name='getSignValue' and count(parameter)=0]"
			[Register ("getSignValue", "()Ljava/lang/String;", "GetGetSignValueHandler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListenerInvoker, PublicChannelGatewayBinding")] get;
		}

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceConnectListener", DoNotGenerateAcw=true)]
	internal partial class ISubDeviceConnectListenerInvoker : global::Java.Lang.Object, ISubDeviceConnectListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceConnectListener", typeof (ISubDeviceConnectListenerInvoker));

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

		public static ISubDeviceConnectListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISubDeviceConnectListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.channel.gateway.api.subdevice.ISubDeviceConnectListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISubDeviceConnectListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getClientId;
#pragma warning disable 0169
		static Delegate GetGetClientIdHandler ()
		{
			if (cb_getClientId == null)
				cb_getClientId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientId);
			return cb_getClientId;
		}

		static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		IntPtr id_getClientId;
		public unsafe string ClientId {
			get {
				if (id_getClientId == IntPtr.Zero)
					id_getClientId = JNIEnv.GetMethodID (class_ref, "getClientId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSignExtraData;
#pragma warning disable 0169
		static Delegate GetGetSignExtraDataHandler ()
		{
			if (cb_getSignExtraData == null)
				cb_getSignExtraData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSignExtraData);
			return cb_getSignExtraData;
		}

		static IntPtr n_GetSignExtraData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.SignExtraData);
		}
#pragma warning restore 0169

		IntPtr id_getSignExtraData;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> SignExtraData {
			get {
				if (id_getSignExtraData == IntPtr.Zero)
					id_getSignExtraData = JNIEnv.GetMethodID (class_ref, "getSignExtraData", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSignExtraData), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSignMethod;
#pragma warning disable 0169
		static Delegate GetGetSignMethodHandler ()
		{
			if (cb_getSignMethod == null)
				cb_getSignMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSignMethod);
			return cb_getSignMethod;
		}

		static IntPtr n_GetSignMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SignMethod);
		}
#pragma warning restore 0169

		IntPtr id_getSignMethod;
		public unsafe string SignMethod {
			get {
				if (id_getSignMethod == IntPtr.Zero)
					id_getSignMethod = JNIEnv.GetMethodID (class_ref, "getSignMethod", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSignMethod), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSignValue;
#pragma warning disable 0169
		static Delegate GetGetSignValueHandler ()
		{
			if (cb_getSignValue == null)
				cb_getSignValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSignValue);
			return cb_getSignValue;
		}

		static IntPtr n_GetSignValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SignValue);
		}
#pragma warning restore 0169

		IntPtr id_getSignValue;
		public unsafe string SignValue {
			get {
				if (id_getSignValue == IntPtr.Zero)
					id_getSignValue = JNIEnv.GetMethodID (class_ref, "getSignValue", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSignValue), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
