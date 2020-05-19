using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Route']"
	[global::Android.Runtime.Register ("okhttp3/Route", DoNotGenerateAcw=true)]
	public sealed partial class Route : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Route", typeof (Route));
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

		internal Route (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Route']/constructor[@name='Route' and count(parameter)=3 and parameter[1][@type='okhttp3.Address'] and parameter[2][@type='java.net.Proxy'] and parameter[3][@type='java.net.InetSocketAddress']]"
		[Register (".ctor", "(Lokhttp3/Address;Ljava/net/Proxy;Ljava/net/InetSocketAddress;)V", "")]
		public unsafe Route (global::Okhttp3.Address address, global::Java.Net.Proxy proxy, global::Java.Net.InetSocketAddress inetSocketAddress)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokhttp3/Address;Ljava/net/Proxy;Ljava/net/InetSocketAddress;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((address == null) ? IntPtr.Zero : ((global::Java.Lang.Object) address).Handle);
				__args [1] = new JniArgumentValue ((proxy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) proxy).Handle);
				__args [2] = new JniArgumentValue ((inetSocketAddress == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inetSocketAddress).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Route']/method[@name='address' and count(parameter)=0]"
		[Register ("address", "()Lokhttp3/Address;", "")]
		public unsafe global::Okhttp3.Address Address ()
		{
			const string __id = "address.()Lokhttp3/Address;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Address> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Route']/method[@name='proxy' and count(parameter)=0]"
		[Register ("proxy", "()Ljava/net/Proxy;", "")]
		public unsafe global::Java.Net.Proxy Proxy ()
		{
			const string __id = "proxy.()Ljava/net/Proxy;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Net.Proxy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Route']/method[@name='requiresTunnel' and count(parameter)=0]"
		[Register ("requiresTunnel", "()Z", "")]
		public unsafe bool RequiresTunnel ()
		{
			const string __id = "requiresTunnel.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Route']/method[@name='socketAddress' and count(parameter)=0]"
		[Register ("socketAddress", "()Ljava/net/InetSocketAddress;", "")]
		public unsafe global::Java.Net.InetSocketAddress SocketAddress ()
		{
			const string __id = "socketAddress.()Ljava/net/InetSocketAddress;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
