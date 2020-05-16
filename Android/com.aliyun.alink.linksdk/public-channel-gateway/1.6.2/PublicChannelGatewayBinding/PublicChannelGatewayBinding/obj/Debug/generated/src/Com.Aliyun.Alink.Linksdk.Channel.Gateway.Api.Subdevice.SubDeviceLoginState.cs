using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/class[@name='SubDeviceLoginState']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceLoginState", DoNotGenerateAcw=true)]
	public sealed partial class SubDeviceLoginState : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/class[@name='SubDeviceLoginState']/field[@name='OFFLINE']"
		[Register ("OFFLINE")]
		public static global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceLoginState Offline {
			get {
				const string __id = "OFFLINE.Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceLoginState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceLoginState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/class[@name='SubDeviceLoginState']/field[@name='ONLINE']"
		[Register ("ONLINE")]
		public static global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceLoginState Online {
			get {
				const string __id = "ONLINE.Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceLoginState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceLoginState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceLoginState", typeof (SubDeviceLoginState));
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

		internal SubDeviceLoginState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/class[@name='SubDeviceLoginState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceLoginState;", "")]
		public static unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceLoginState ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceLoginState;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceLoginState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/class[@name='SubDeviceLoginState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceLoginState;", "")]
		public static unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceLoginState[] Values ()
		{
			const string __id = "values.()[Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceLoginState;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceLoginState[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceLoginState));
			} finally {
			}
		}

	}
}
