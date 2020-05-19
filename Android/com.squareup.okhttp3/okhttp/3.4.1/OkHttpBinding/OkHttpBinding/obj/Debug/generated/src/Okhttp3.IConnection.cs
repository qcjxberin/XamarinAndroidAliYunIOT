using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3']/interface[@name='Connection']"
	[Register ("okhttp3/Connection", "", "Okhttp3.IConnectionInvoker")]
	public partial interface IConnection : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='Connection']/method[@name='handshake' and count(parameter)=0]"
		[Register ("handshake", "()Lokhttp3/Handshake;", "GetHandshakeHandler:Okhttp3.IConnectionInvoker, OkHttpBinding")]
		global::Okhttp3.Handshake Handshake ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='Connection']/method[@name='protocol' and count(parameter)=0]"
		[Register ("protocol", "()Lokhttp3/Protocol;", "GetProtocolHandler:Okhttp3.IConnectionInvoker, OkHttpBinding")]
		global::Okhttp3.Protocol Protocol ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='Connection']/method[@name='route' and count(parameter)=0]"
		[Register ("route", "()Lokhttp3/Route;", "GetRouteHandler:Okhttp3.IConnectionInvoker, OkHttpBinding")]
		global::Okhttp3.Route Route ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='Connection']/method[@name='socket' and count(parameter)=0]"
		[Register ("socket", "()Ljava/net/Socket;", "GetSocketHandler:Okhttp3.IConnectionInvoker, OkHttpBinding")]
		global::Java.Net.Socket Socket ();

	}

	[global::Android.Runtime.Register ("okhttp3/Connection", DoNotGenerateAcw=true)]
	internal partial class IConnectionInvoker : global::Java.Lang.Object, IConnection {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Connection", typeof (IConnectionInvoker));

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

		public static IConnection GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnection> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.Connection"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_handshake;
#pragma warning disable 0169
		static Delegate GetHandshakeHandler ()
		{
			if (cb_handshake == null)
				cb_handshake = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Handshake);
			return cb_handshake;
		}

		static IntPtr n_Handshake (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.IConnection __this = global::Java.Lang.Object.GetObject<global::Okhttp3.IConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Handshake ());
		}
#pragma warning restore 0169

		IntPtr id_handshake;
		public unsafe global::Okhttp3.Handshake Handshake ()
		{
			if (id_handshake == IntPtr.Zero)
				id_handshake = JNIEnv.GetMethodID (class_ref, "handshake", "()Lokhttp3/Handshake;");
			return global::Java.Lang.Object.GetObject<global::Okhttp3.Handshake> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_handshake), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_protocol;
#pragma warning disable 0169
		static Delegate GetProtocolHandler ()
		{
			if (cb_protocol == null)
				cb_protocol = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Protocol);
			return cb_protocol;
		}

		static IntPtr n_Protocol (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.IConnection __this = global::Java.Lang.Object.GetObject<global::Okhttp3.IConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Protocol ());
		}
#pragma warning restore 0169

		IntPtr id_protocol;
		public unsafe global::Okhttp3.Protocol Protocol ()
		{
			if (id_protocol == IntPtr.Zero)
				id_protocol = JNIEnv.GetMethodID (class_ref, "protocol", "()Lokhttp3/Protocol;");
			return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_protocol), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_route;
#pragma warning disable 0169
		static Delegate GetRouteHandler ()
		{
			if (cb_route == null)
				cb_route = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Route);
			return cb_route;
		}

		static IntPtr n_Route (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.IConnection __this = global::Java.Lang.Object.GetObject<global::Okhttp3.IConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Route ());
		}
#pragma warning restore 0169

		IntPtr id_route;
		public unsafe global::Okhttp3.Route Route ()
		{
			if (id_route == IntPtr.Zero)
				id_route = JNIEnv.GetMethodID (class_ref, "route", "()Lokhttp3/Route;");
			return global::Java.Lang.Object.GetObject<global::Okhttp3.Route> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_route), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_socket;
#pragma warning disable 0169
		static Delegate GetSocketHandler ()
		{
			if (cb_socket == null)
				cb_socket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Socket);
			return cb_socket;
		}

		static IntPtr n_Socket (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.IConnection __this = global::Java.Lang.Object.GetObject<global::Okhttp3.IConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Socket ());
		}
#pragma warning restore 0169

		IntPtr id_socket;
		public unsafe global::Java.Net.Socket Socket ()
		{
			if (id_socket == IntPtr.Zero)
				id_socket = JNIEnv.GetMethodID (class_ref, "socket", "()Ljava/net/Socket;");
			return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_socket), JniHandleOwnership.TransferLocalRef);
		}

	}

}
