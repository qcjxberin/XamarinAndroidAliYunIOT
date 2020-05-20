using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/interface[@name='NetworkModule']"
	[Register ("org/eclipse/paho/client/mqttv3/internal/NetworkModule", "", "Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModuleInvoker")]
	public partial interface INetworkModule : IJavaObject, IJavaPeerable {

		global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/interface[@name='NetworkModule']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler:Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModuleInvoker, OpenSourcePahoBinding")] get;
		}

		global::System.IO.Stream OutputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/interface[@name='NetworkModule']/method[@name='getOutputStream' and count(parameter)=0]"
			[Register ("getOutputStream", "()Ljava/io/OutputStream;", "GetGetOutputStreamHandler:Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModuleInvoker, OpenSourcePahoBinding")] get;
		}

		string ServerURI {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/interface[@name='NetworkModule']/method[@name='getServerURI' and count(parameter)=0]"
			[Register ("getServerURI", "()Ljava/lang/String;", "GetGetServerURIHandler:Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModuleInvoker, OpenSourcePahoBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/interface[@name='NetworkModule']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler:Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModuleInvoker, OpenSourcePahoBinding")]
		void Start ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/interface[@name='NetworkModule']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler:Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModuleInvoker, OpenSourcePahoBinding")]
		void Stop ();

	}

	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/NetworkModule", DoNotGenerateAcw=true)]
	internal partial class INetworkModuleInvoker : global::Java.Lang.Object, INetworkModule {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/NetworkModule", typeof (INetworkModuleInvoker));

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

		public static INetworkModule GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetworkModule> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.eclipse.paho.client.mqttv3.internal.NetworkModule"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetworkModuleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		IntPtr id_getInputStream;
		public unsafe global::System.IO.Stream InputStream {
			get {
				if (id_getInputStream == IntPtr.Zero)
					id_getInputStream = JNIEnv.GetMethodID (class_ref, "getInputStream", "()Ljava/io/InputStream;");
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInputStream), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OutputStream);
		}
#pragma warning restore 0169

		IntPtr id_getOutputStream;
		public unsafe global::System.IO.Stream OutputStream {
			get {
				if (id_getOutputStream == IntPtr.Zero)
					id_getOutputStream = JNIEnv.GetMethodID (class_ref, "getOutputStream", "()Ljava/io/OutputStream;");
				return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOutputStream), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServerURI);
		}
#pragma warning restore 0169

		IntPtr id_getServerURI;
		public unsafe string ServerURI {
			get {
				if (id_getServerURI == IntPtr.Zero)
					id_getServerURI = JNIEnv.GetMethodID (class_ref, "getServerURI", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServerURI), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		IntPtr id_start;
		public unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		IntPtr id_stop;
		public unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
		}

	}

}
