using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='TCPNetworkModule']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/TCPNetworkModule", DoNotGenerateAcw=true)]
	public partial class TCPNetworkModule : global::Java.Lang.Object, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='TCPNetworkModule']/field[@name='socket']"
		[Register ("socket")]
		protected global::Java.Net.Socket Socket {
			get {
				const string __id = "socket.Ljava/net/Socket;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "socket.Ljava/net/Socket;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/TCPNetworkModule", typeof (TCPNetworkModule));
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

		protected TCPNetworkModule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='TCPNetworkModule']/constructor[@name='TCPNetworkModule' and count(parameter)=4 and parameter[1][@type='javax.net.SocketFactory'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljavax/net/SocketFactory;Ljava/lang/String;ILjava/lang/String;)V", "")]
		public unsafe TCPNetworkModule (global::Javax.Net.SocketFactory factory, string host, int port, string resourceContext)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljavax/net/SocketFactory;Ljava/lang/String;ILjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_host = JNIEnv.NewString (host);
			IntPtr native_resourceContext = JNIEnv.NewString (resourceContext);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((factory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) factory).Handle);
				__args [1] = new JniArgumentValue (native_host);
				__args [2] = new JniArgumentValue (port);
				__args [3] = new JniArgumentValue (native_resourceContext);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
				JNIEnv.DeleteLocalRef (native_resourceContext);
			}
		}

		static Delegate cb_getInputStream;
#pragma warning disable 0169
		static Delegate GetGetInputStreamHandler ()
		{
			if (cb_getInputStream == null)
				cb_getInputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputStream);
			return cb_getInputStream;
		}

		static IntPtr n_GetInputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.TCPNetworkModule __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.TCPNetworkModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='TCPNetworkModule']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")]
			get {
				const string __id = "getInputStream.()Ljava/io/InputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOutputStream;
#pragma warning disable 0169
		static Delegate GetGetOutputStreamHandler ()
		{
			if (cb_getOutputStream == null)
				cb_getOutputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutputStream);
			return cb_getOutputStream;
		}

		static IntPtr n_GetOutputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.TCPNetworkModule __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.TCPNetworkModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OutputStream);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.IO.Stream OutputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='TCPNetworkModule']/method[@name='getOutputStream' and count(parameter)=0]"
			[Register ("getOutputStream", "()Ljava/io/OutputStream;", "GetGetOutputStreamHandler")]
			get {
				const string __id = "getOutputStream.()Ljava/io/OutputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServerURI;
#pragma warning disable 0169
		static Delegate GetGetServerURIHandler ()
		{
			if (cb_getServerURI == null)
				cb_getServerURI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServerURI);
			return cb_getServerURI;
		}

		static IntPtr n_GetServerURI (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.TCPNetworkModule __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.TCPNetworkModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServerURI);
		}
#pragma warning restore 0169

		public virtual unsafe string ServerURI {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='TCPNetworkModule']/method[@name='getServerURI' and count(parameter)=0]"
			[Register ("getServerURI", "()Ljava/lang/String;", "GetGetServerURIHandler")]
			get {
				const string __id = "getServerURI.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setConnectTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetConnectTimeout_IHandler ()
		{
			if (cb_setConnectTimeout_I == null)
				cb_setConnectTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetConnectTimeout_I);
			return cb_setConnectTimeout_I;
		}

		static void n_SetConnectTimeout_I (IntPtr jnienv, IntPtr native__this, int timeout)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.TCPNetworkModule __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.TCPNetworkModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetConnectTimeout (timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='TCPNetworkModule']/method[@name='setConnectTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setConnectTimeout", "(I)V", "GetSetConnectTimeout_IHandler")]
		public virtual unsafe void SetConnectTimeout (int timeout)
		{
			const string __id = "setConnectTimeout.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeout);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.TCPNetworkModule __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.TCPNetworkModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='TCPNetworkModule']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.TCPNetworkModule __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.TCPNetworkModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='TCPNetworkModule']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
