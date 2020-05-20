using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketHandshake']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/websocket/WebSocketHandshake", DoNotGenerateAcw=true)]
	public partial class WebSocketHandshake : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/websocket/WebSocketHandshake", typeof (WebSocketHandshake));
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

		protected WebSocketHandshake (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketHandshake']/constructor[@name='WebSocketHandshake' and count(parameter)=5 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Ljava/io/InputStream;Ljava/io/OutputStream;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe WebSocketHandshake (global::System.IO.Stream input, global::System.IO.Stream output, string uri, string host, int port)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;Ljava/io/OutputStream;Ljava/lang/String;Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_input = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (input);
			IntPtr native_output = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (output);
			IntPtr native_uri = JNIEnv.NewString (uri);
			IntPtr native_host = JNIEnv.NewString (host);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_input);
				__args [1] = new JniArgumentValue (native_output);
				__args [2] = new JniArgumentValue (native_uri);
				__args [3] = new JniArgumentValue (native_host);
				__args [4] = new JniArgumentValue (port);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
				JNIEnv.DeleteLocalRef (native_output);
				JNIEnv.DeleteLocalRef (native_uri);
				JNIEnv.DeleteLocalRef (native_host);
			}
		}

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Execute);
			return cb_execute;
		}

		static void n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketHandshake __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketHandshake> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketHandshake']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler")]
		public virtual unsafe void Execute ()
		{
			const string __id = "execute.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
