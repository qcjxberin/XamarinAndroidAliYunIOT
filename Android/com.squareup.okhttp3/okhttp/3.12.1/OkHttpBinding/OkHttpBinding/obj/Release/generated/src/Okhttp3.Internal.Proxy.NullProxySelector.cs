using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Proxy {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.proxy']/class[@name='NullProxySelector']"
	[global::Android.Runtime.Register ("okhttp3/internal/proxy/NullProxySelector", DoNotGenerateAcw=true)]
	public partial class NullProxySelector : global::Java.Net.ProxySelector {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/proxy/NullProxySelector", typeof (NullProxySelector));
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

		protected NullProxySelector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.proxy']/class[@name='NullProxySelector']/constructor[@name='NullProxySelector' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NullProxySelector ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_connectFailed_Ljava_net_URI_Ljava_net_SocketAddress_Ljava_io_IOException_;
#pragma warning disable 0169
		static Delegate GetConnectFailed_Ljava_net_URI_Ljava_net_SocketAddress_Ljava_io_IOException_Handler ()
		{
			if (cb_connectFailed_Ljava_net_URI_Ljava_net_SocketAddress_Ljava_io_IOException_ == null)
				cb_connectFailed_Ljava_net_URI_Ljava_net_SocketAddress_Ljava_io_IOException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ConnectFailed_Ljava_net_URI_Ljava_net_SocketAddress_Ljava_io_IOException_);
			return cb_connectFailed_Ljava_net_URI_Ljava_net_SocketAddress_Ljava_io_IOException_;
		}

		static void n_ConnectFailed_Ljava_net_URI_Ljava_net_SocketAddress_Ljava_io_IOException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_sa, IntPtr native_ioe)
		{
			global::Okhttp3.Internal.Proxy.NullProxySelector __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Proxy.NullProxySelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URI uri = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (native_uri, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.SocketAddress sa = global::Java.Lang.Object.GetObject<global::Java.Net.SocketAddress> (native_sa, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.IOException ioe = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_ioe, JniHandleOwnership.DoNotTransfer);
			__this.ConnectFailed (uri, sa, ioe);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.proxy']/class[@name='NullProxySelector']/method[@name='connectFailed' and count(parameter)=3 and parameter[1][@type='java.net.URI'] and parameter[2][@type='java.net.SocketAddress'] and parameter[3][@type='java.io.IOException']]"
		[Register ("connectFailed", "(Ljava/net/URI;Ljava/net/SocketAddress;Ljava/io/IOException;)V", "GetConnectFailed_Ljava_net_URI_Ljava_net_SocketAddress_Ljava_io_IOException_Handler")]
		public override unsafe void ConnectFailed (global::Java.Net.URI uri, global::Java.Net.SocketAddress sa, global::Java.IO.IOException ioe)
		{
			const string __id = "connectFailed.(Ljava/net/URI;Ljava/net/SocketAddress;Ljava/io/IOException;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue ((sa == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sa).Handle);
				__args [2] = new JniArgumentValue ((ioe == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) ioe).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_select_Ljava_net_URI_;
#pragma warning disable 0169
		static Delegate GetSelect_Ljava_net_URI_Handler ()
		{
			if (cb_select_Ljava_net_URI_ == null)
				cb_select_Ljava_net_URI_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Select_Ljava_net_URI_);
			return cb_select_Ljava_net_URI_;
		}

		static IntPtr n_Select_Ljava_net_URI_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			global::Okhttp3.Internal.Proxy.NullProxySelector __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Proxy.NullProxySelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URI uri = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Java.Net.Proxy>.ToLocalJniHandle (__this.Select (uri));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.proxy']/class[@name='NullProxySelector']/method[@name='select' and count(parameter)=1 and parameter[1][@type='java.net.URI']]"
		[Register ("select", "(Ljava/net/URI;)Ljava/util/List;", "GetSelect_Ljava_net_URI_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Java.Net.Proxy> Select (global::Java.Net.URI uri)
		{
			const string __id = "select.(Ljava/net/URI;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Java.Net.Proxy>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
