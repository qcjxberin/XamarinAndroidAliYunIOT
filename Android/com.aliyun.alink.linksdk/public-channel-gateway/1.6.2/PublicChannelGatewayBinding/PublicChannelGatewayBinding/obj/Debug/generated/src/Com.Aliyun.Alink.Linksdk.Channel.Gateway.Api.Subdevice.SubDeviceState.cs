using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/class[@name='SubDeviceState']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceState", DoNotGenerateAcw=true)]
	public sealed partial class SubDeviceState : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/class[@name='SubDeviceState']/field[@name='DELETED']"
		[Register ("DELETED")]
		public static global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceState Deleted {
			get {
				const string __id = "DELETED.Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/class[@name='SubDeviceState']/field[@name='DISABLED']"
		[Register ("DISABLED")]
		public static global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceState Disabled {
			get {
				const string __id = "DISABLED.Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/class[@name='SubDeviceState']/field[@name='ENABLED']"
		[Register ("ENABLED")]
		public static global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceState Enabled {
			get {
				const string __id = "ENABLED.Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceState", typeof (SubDeviceState));
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

		internal SubDeviceState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/class[@name='SubDeviceState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceState;", "")]
		public static unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceState ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceState;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/class[@name='SubDeviceState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceState;", "")]
		public static unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceState[] Values ()
		{
			const string __id = "values.()[Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceState;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceState[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceState));
			} finally {
			}
		}

	}
}
