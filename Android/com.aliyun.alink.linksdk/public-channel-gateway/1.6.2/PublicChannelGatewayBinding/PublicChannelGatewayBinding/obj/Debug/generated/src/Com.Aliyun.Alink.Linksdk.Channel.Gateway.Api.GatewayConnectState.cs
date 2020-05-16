using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/class[@name='GatewayConnectState']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/gateway/api/GatewayConnectState", DoNotGenerateAcw=true)]
	public sealed partial class GatewayConnectState : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/class[@name='GatewayConnectState']/field[@name='CONNECTED']"
		[Register ("CONNECTED")]
		public static global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState Connected {
			get {
				const string __id = "CONNECTED.Lcom/aliyun/alink/linksdk/channel/gateway/api/GatewayConnectState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/class[@name='GatewayConnectState']/field[@name='CONNECTFAIL']"
		[Register ("CONNECTFAIL")]
		public static global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState Connectfail {
			get {
				const string __id = "CONNECTFAIL.Lcom/aliyun/alink/linksdk/channel/gateway/api/GatewayConnectState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/class[@name='GatewayConnectState']/field[@name='CONNECTING']"
		[Register ("CONNECTING")]
		public static global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState Connecting {
			get {
				const string __id = "CONNECTING.Lcom/aliyun/alink/linksdk/channel/gateway/api/GatewayConnectState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/class[@name='GatewayConnectState']/field[@name='DISCONNECTED']"
		[Register ("DISCONNECTED")]
		public static global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState Disconnected {
			get {
				const string __id = "DISCONNECTED.Lcom/aliyun/alink/linksdk/channel/gateway/api/GatewayConnectState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/gateway/api/GatewayConnectState", typeof (GatewayConnectState));
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

		internal GatewayConnectState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/class[@name='GatewayConnectState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/channel/gateway/api/GatewayConnectState;", "")]
		public static unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/channel/gateway/api/GatewayConnectState;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/class[@name='GatewayConnectState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/aliyun/alink/linksdk/channel/gateway/api/GatewayConnectState;", "")]
		public static unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState[] Values ()
		{
			const string __id = "values.()[Lcom/aliyun/alink/linksdk/channel/gateway/api/GatewayConnectState;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState));
			} finally {
			}
		}

	}
}
