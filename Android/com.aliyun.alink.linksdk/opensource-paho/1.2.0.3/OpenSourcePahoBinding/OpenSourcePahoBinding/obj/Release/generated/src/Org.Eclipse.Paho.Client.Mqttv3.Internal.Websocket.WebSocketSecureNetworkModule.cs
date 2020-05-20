using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketSecureNetworkModule']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/websocket/WebSocketSecureNetworkModule", DoNotGenerateAcw=true)]
	public partial class WebSocketSecureNetworkModule : global::Org.Eclipse.Paho.Client.Mqttv3.Internal.SSLNetworkModule {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/websocket/WebSocketSecureNetworkModule", typeof (WebSocketSecureNetworkModule));
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

		protected WebSocketSecureNetworkModule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketSecureNetworkModule']/constructor[@name='WebSocketSecureNetworkModule' and count(parameter)=5 and parameter[1][@type='javax.net.ssl.SSLSocketFactory'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljavax/net/ssl/SSLSocketFactory;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", "")]
		public unsafe WebSocketSecureNetworkModule (global::Javax.Net.Ssl.SSLSocketFactory factory, string uri, string host, int port, string clientId)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljavax/net/ssl/SSLSocketFactory;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_uri = JNIEnv.NewString (uri);
			IntPtr native_host = JNIEnv.NewString (host);
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((factory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) factory).Handle);
				__args [1] = new JniArgumentValue (native_uri);
				__args [2] = new JniArgumentValue (native_host);
				__args [3] = new JniArgumentValue (port);
				__args [4] = new JniArgumentValue (native_clientId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_uri);
				JNIEnv.DeleteLocalRef (native_host);
				JNIEnv.DeleteLocalRef (native_clientId);
			}
		}

	}
}
