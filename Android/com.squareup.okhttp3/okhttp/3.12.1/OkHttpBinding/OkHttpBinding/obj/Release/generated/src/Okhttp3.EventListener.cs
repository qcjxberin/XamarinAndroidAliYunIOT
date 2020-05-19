using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']"
	[global::Android.Runtime.Register ("okhttp3/EventListener", DoNotGenerateAcw=true)]
	public abstract partial class EventListener : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Okhttp3.EventListener None {
			get {
				const string __id = "NONE.Lokhttp3/EventListener;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3']/interface[@name='EventListener.Factory']"
		[Register ("okhttp3/EventListener$Factory", "", "Okhttp3.EventListener/IFactoryInvoker")]
		public partial interface IFactory : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='EventListener.Factory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='okhttp3.Call']]"
			[Register ("create", "(Lokhttp3/Call;)Lokhttp3/EventListener;", "GetCreate_Lokhttp3_Call_Handler:Okhttp3.EventListener/IFactoryInvoker, OkHttpBinding")]
			global::Okhttp3.EventListener Create (global::Okhttp3.ICall p0);

		}

		[global::Android.Runtime.Register ("okhttp3/EventListener$Factory", DoNotGenerateAcw=true)]
		internal partial class IFactoryInvoker : global::Java.Lang.Object, IFactory {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/EventListener$Factory", typeof (IFactoryInvoker));

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

			public static IFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFactory> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "okhttp3.EventListener.Factory"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_create_Lokhttp3_Call_;
#pragma warning disable 0169
			static Delegate GetCreate_Lokhttp3_Call_Handler ()
			{
				if (cb_create_Lokhttp3_Call_ == null)
					cb_create_Lokhttp3_Call_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Create_Lokhttp3_Call_);
				return cb_create_Lokhttp3_Call_;
			}

			static IntPtr n_Create_Lokhttp3_Call_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Okhttp3.EventListener.IFactory __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener.IFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.ICall p0 = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_create_Lokhttp3_Call_;
			public unsafe global::Okhttp3.EventListener Create (global::Okhttp3.ICall p0)
			{
				if (id_create_Lokhttp3_Call_ == IntPtr.Zero)
					id_create_Lokhttp3_Call_ = JNIEnv.GetMethodID (class_ref, "create", "(Lokhttp3/Call;)Lokhttp3/EventListener;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				global::Okhttp3.EventListener __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Lokhttp3_Call_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/EventListener", typeof (EventListener));
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

		protected EventListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/constructor[@name='EventListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventListener ()
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

		static Delegate cb_callEnd_Lokhttp3_Call_;
#pragma warning disable 0169
		static Delegate GetCallEnd_Lokhttp3_Call_Handler ()
		{
			if (cb_callEnd_Lokhttp3_Call_ == null)
				cb_callEnd_Lokhttp3_Call_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CallEnd_Lokhttp3_Call_);
			return cb_callEnd_Lokhttp3_Call_;
		}

		static void n_CallEnd_Lokhttp3_Call_ (IntPtr jnienv, IntPtr native__this, IntPtr native_call)
		{
			global::Okhttp3.EventListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			__this.CallEnd (call);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/method[@name='callEnd' and count(parameter)=1 and parameter[1][@type='okhttp3.Call']]"
		[Register ("callEnd", "(Lokhttp3/Call;)V", "GetCallEnd_Lokhttp3_Call_Handler")]
		public virtual unsafe void CallEnd (global::Okhttp3.ICall call)
		{
			const string __id = "callEnd.(Lokhttp3/Call;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_callFailed_Lokhttp3_Call_Ljava_io_IOException_;
#pragma warning disable 0169
		static Delegate GetCallFailed_Lokhttp3_Call_Ljava_io_IOException_Handler ()
		{
			if (cb_callFailed_Lokhttp3_Call_Ljava_io_IOException_ == null)
				cb_callFailed_Lokhttp3_Call_Ljava_io_IOException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CallFailed_Lokhttp3_Call_Ljava_io_IOException_);
			return cb_callFailed_Lokhttp3_Call_Ljava_io_IOException_;
		}

		static void n_CallFailed_Lokhttp3_Call_Ljava_io_IOException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_call, IntPtr native_ioe)
		{
			global::Okhttp3.EventListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.IOException ioe = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_ioe, JniHandleOwnership.DoNotTransfer);
			__this.CallFailed (call, ioe);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/method[@name='callFailed' and count(parameter)=2 and parameter[1][@type='okhttp3.Call'] and parameter[2][@type='java.io.IOException']]"
		[Register ("callFailed", "(Lokhttp3/Call;Ljava/io/IOException;)V", "GetCallFailed_Lokhttp3_Call_Ljava_io_IOException_Handler")]
		public virtual unsafe void CallFailed (global::Okhttp3.ICall call, global::Java.IO.IOException ioe)
		{
			const string __id = "callFailed.(Lokhttp3/Call;Ljava/io/IOException;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				__args [1] = new JniArgumentValue ((ioe == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) ioe).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_callStart_Lokhttp3_Call_;
#pragma warning disable 0169
		static Delegate GetCallStart_Lokhttp3_Call_Handler ()
		{
			if (cb_callStart_Lokhttp3_Call_ == null)
				cb_callStart_Lokhttp3_Call_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CallStart_Lokhttp3_Call_);
			return cb_callStart_Lokhttp3_Call_;
		}

		static void n_CallStart_Lokhttp3_Call_ (IntPtr jnienv, IntPtr native__this, IntPtr native_call)
		{
			global::Okhttp3.EventListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			__this.CallStart (call);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/method[@name='callStart' and count(parameter)=1 and parameter[1][@type='okhttp3.Call']]"
		[Register ("callStart", "(Lokhttp3/Call;)V", "GetCallStart_Lokhttp3_Call_Handler")]
		public virtual unsafe void CallStart (global::Okhttp3.ICall call)
		{
			const string __id = "callStart.(Lokhttp3/Call;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_connectEnd_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_Lokhttp3_Protocol_;
#pragma warning disable 0169
		static Delegate GetConnectEnd_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_Lokhttp3_Protocol_Handler ()
		{
			if (cb_connectEnd_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_Lokhttp3_Protocol_ == null)
				cb_connectEnd_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_Lokhttp3_Protocol_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ConnectEnd_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_Lokhttp3_Protocol_);
			return cb_connectEnd_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_Lokhttp3_Protocol_;
		}

		static void n_ConnectEnd_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_Lokhttp3_Protocol_ (IntPtr jnienv, IntPtr native__this, IntPtr native_call, IntPtr native_inetSocketAddress, IntPtr native_proxy, IntPtr native_protocol)
		{
			global::Okhttp3.EventListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.InetSocketAddress inetSocketAddress = global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (native_inetSocketAddress, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.Proxy proxy = global::Java.Lang.Object.GetObject<global::Java.Net.Proxy> (native_proxy, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Protocol protocol = global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (native_protocol, JniHandleOwnership.DoNotTransfer);
			__this.ConnectEnd (call, inetSocketAddress, proxy, protocol);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/method[@name='connectEnd' and count(parameter)=4 and parameter[1][@type='okhttp3.Call'] and parameter[2][@type='java.net.InetSocketAddress'] and parameter[3][@type='java.net.Proxy'] and parameter[4][@type='okhttp3.Protocol']]"
		[Register ("connectEnd", "(Lokhttp3/Call;Ljava/net/InetSocketAddress;Ljava/net/Proxy;Lokhttp3/Protocol;)V", "GetConnectEnd_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_Lokhttp3_Protocol_Handler")]
		public virtual unsafe void ConnectEnd (global::Okhttp3.ICall call, global::Java.Net.InetSocketAddress inetSocketAddress, global::Java.Net.Proxy proxy, global::Okhttp3.Protocol protocol)
		{
			const string __id = "connectEnd.(Lokhttp3/Call;Ljava/net/InetSocketAddress;Ljava/net/Proxy;Lokhttp3/Protocol;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				__args [1] = new JniArgumentValue ((inetSocketAddress == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inetSocketAddress).Handle);
				__args [2] = new JniArgumentValue ((proxy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) proxy).Handle);
				__args [3] = new JniArgumentValue ((protocol == null) ? IntPtr.Zero : ((global::Java.Lang.Object) protocol).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_connectFailed_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_Lokhttp3_Protocol_Ljava_io_IOException_;
#pragma warning disable 0169
		static Delegate GetConnectFailed_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_Lokhttp3_Protocol_Ljava_io_IOException_Handler ()
		{
			if (cb_connectFailed_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_Lokhttp3_Protocol_Ljava_io_IOException_ == null)
				cb_connectFailed_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_Lokhttp3_Protocol_Ljava_io_IOException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ConnectFailed_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_Lokhttp3_Protocol_Ljava_io_IOException_);
			return cb_connectFailed_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_Lokhttp3_Protocol_Ljava_io_IOException_;
		}

		static void n_ConnectFailed_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_Lokhttp3_Protocol_Ljava_io_IOException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_call, IntPtr native_inetSocketAddress, IntPtr native_proxy, IntPtr native_protocol, IntPtr native_ioe)
		{
			global::Okhttp3.EventListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.InetSocketAddress inetSocketAddress = global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (native_inetSocketAddress, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.Proxy proxy = global::Java.Lang.Object.GetObject<global::Java.Net.Proxy> (native_proxy, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Protocol protocol = global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (native_protocol, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.IOException ioe = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_ioe, JniHandleOwnership.DoNotTransfer);
			__this.ConnectFailed (call, inetSocketAddress, proxy, protocol, ioe);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/method[@name='connectFailed' and count(parameter)=5 and parameter[1][@type='okhttp3.Call'] and parameter[2][@type='java.net.InetSocketAddress'] and parameter[3][@type='java.net.Proxy'] and parameter[4][@type='okhttp3.Protocol'] and parameter[5][@type='java.io.IOException']]"
		[Register ("connectFailed", "(Lokhttp3/Call;Ljava/net/InetSocketAddress;Ljava/net/Proxy;Lokhttp3/Protocol;Ljava/io/IOException;)V", "GetConnectFailed_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_Lokhttp3_Protocol_Ljava_io_IOException_Handler")]
		public virtual unsafe void ConnectFailed (global::Okhttp3.ICall call, global::Java.Net.InetSocketAddress inetSocketAddress, global::Java.Net.Proxy proxy, global::Okhttp3.Protocol protocol, global::Java.IO.IOException ioe)
		{
			const string __id = "connectFailed.(Lokhttp3/Call;Ljava/net/InetSocketAddress;Ljava/net/Proxy;Lokhttp3/Protocol;Ljava/io/IOException;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				__args [1] = new JniArgumentValue ((inetSocketAddress == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inetSocketAddress).Handle);
				__args [2] = new JniArgumentValue ((proxy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) proxy).Handle);
				__args [3] = new JniArgumentValue ((protocol == null) ? IntPtr.Zero : ((global::Java.Lang.Object) protocol).Handle);
				__args [4] = new JniArgumentValue ((ioe == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) ioe).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_connectStart_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_;
#pragma warning disable 0169
		static Delegate GetConnectStart_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_Handler ()
		{
			if (cb_connectStart_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_ == null)
				cb_connectStart_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ConnectStart_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_);
			return cb_connectStart_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_;
		}

		static void n_ConnectStart_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_call, IntPtr native_inetSocketAddress, IntPtr native_proxy)
		{
			global::Okhttp3.EventListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.InetSocketAddress inetSocketAddress = global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (native_inetSocketAddress, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.Proxy proxy = global::Java.Lang.Object.GetObject<global::Java.Net.Proxy> (native_proxy, JniHandleOwnership.DoNotTransfer);
			__this.ConnectStart (call, inetSocketAddress, proxy);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/method[@name='connectStart' and count(parameter)=3 and parameter[1][@type='okhttp3.Call'] and parameter[2][@type='java.net.InetSocketAddress'] and parameter[3][@type='java.net.Proxy']]"
		[Register ("connectStart", "(Lokhttp3/Call;Ljava/net/InetSocketAddress;Ljava/net/Proxy;)V", "GetConnectStart_Lokhttp3_Call_Ljava_net_InetSocketAddress_Ljava_net_Proxy_Handler")]
		public virtual unsafe void ConnectStart (global::Okhttp3.ICall call, global::Java.Net.InetSocketAddress inetSocketAddress, global::Java.Net.Proxy proxy)
		{
			const string __id = "connectStart.(Lokhttp3/Call;Ljava/net/InetSocketAddress;Ljava/net/Proxy;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				__args [1] = new JniArgumentValue ((inetSocketAddress == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inetSocketAddress).Handle);
				__args [2] = new JniArgumentValue ((proxy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) proxy).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_connectionAcquired_Lokhttp3_Call_Lokhttp3_Connection_;
#pragma warning disable 0169
		static Delegate GetConnectionAcquired_Lokhttp3_Call_Lokhttp3_Connection_Handler ()
		{
			if (cb_connectionAcquired_Lokhttp3_Call_Lokhttp3_Connection_ == null)
				cb_connectionAcquired_Lokhttp3_Call_Lokhttp3_Connection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ConnectionAcquired_Lokhttp3_Call_Lokhttp3_Connection_);
			return cb_connectionAcquired_Lokhttp3_Call_Lokhttp3_Connection_;
		}

		static void n_ConnectionAcquired_Lokhttp3_Call_Lokhttp3_Connection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_call, IntPtr native_connection)
		{
			global::Okhttp3.EventListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.IConnection connection = (global::Okhttp3.IConnection)global::Java.Lang.Object.GetObject<global::Okhttp3.IConnection> (native_connection, JniHandleOwnership.DoNotTransfer);
			__this.ConnectionAcquired (call, connection);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/method[@name='connectionAcquired' and count(parameter)=2 and parameter[1][@type='okhttp3.Call'] and parameter[2][@type='okhttp3.Connection']]"
		[Register ("connectionAcquired", "(Lokhttp3/Call;Lokhttp3/Connection;)V", "GetConnectionAcquired_Lokhttp3_Call_Lokhttp3_Connection_Handler")]
		public virtual unsafe void ConnectionAcquired (global::Okhttp3.ICall call, global::Okhttp3.IConnection connection)
		{
			const string __id = "connectionAcquired.(Lokhttp3/Call;Lokhttp3/Connection;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				__args [1] = new JniArgumentValue ((connection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connection).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_connectionReleased_Lokhttp3_Call_Lokhttp3_Connection_;
#pragma warning disable 0169
		static Delegate GetConnectionReleased_Lokhttp3_Call_Lokhttp3_Connection_Handler ()
		{
			if (cb_connectionReleased_Lokhttp3_Call_Lokhttp3_Connection_ == null)
				cb_connectionReleased_Lokhttp3_Call_Lokhttp3_Connection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ConnectionReleased_Lokhttp3_Call_Lokhttp3_Connection_);
			return cb_connectionReleased_Lokhttp3_Call_Lokhttp3_Connection_;
		}

		static void n_ConnectionReleased_Lokhttp3_Call_Lokhttp3_Connection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_call, IntPtr native_connection)
		{
			global::Okhttp3.EventListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.IConnection connection = (global::Okhttp3.IConnection)global::Java.Lang.Object.GetObject<global::Okhttp3.IConnection> (native_connection, JniHandleOwnership.DoNotTransfer);
			__this.ConnectionReleased (call, connection);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/method[@name='connectionReleased' and count(parameter)=2 and parameter[1][@type='okhttp3.Call'] and parameter[2][@type='okhttp3.Connection']]"
		[Register ("connectionReleased", "(Lokhttp3/Call;Lokhttp3/Connection;)V", "GetConnectionReleased_Lokhttp3_Call_Lokhttp3_Connection_Handler")]
		public virtual unsafe void ConnectionReleased (global::Okhttp3.ICall call, global::Okhttp3.IConnection connection)
		{
			const string __id = "connectionReleased.(Lokhttp3/Call;Lokhttp3/Connection;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				__args [1] = new JniArgumentValue ((connection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connection).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dnsEnd_Lokhttp3_Call_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDnsEnd_Lokhttp3_Call_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_dnsEnd_Lokhttp3_Call_Ljava_lang_String_Ljava_util_List_ == null)
				cb_dnsEnd_Lokhttp3_Call_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DnsEnd_Lokhttp3_Call_Ljava_lang_String_Ljava_util_List_);
			return cb_dnsEnd_Lokhttp3_Call_Ljava_lang_String_Ljava_util_List_;
		}

		static void n_DnsEnd_Lokhttp3_Call_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_call, IntPtr native_domainName, IntPtr native_inetAddressList)
		{
			global::Okhttp3.EventListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			string domainName = JNIEnv.GetString (native_domainName, JniHandleOwnership.DoNotTransfer);
			var inetAddressList = global::Android.Runtime.JavaList<global::Java.Net.InetAddress>.FromJniHandle (native_inetAddressList, JniHandleOwnership.DoNotTransfer);
			__this.DnsEnd (call, domainName, inetAddressList);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/method[@name='dnsEnd' and count(parameter)=3 and parameter[1][@type='okhttp3.Call'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;java.net.InetAddress&gt;']]"
		[Register ("dnsEnd", "(Lokhttp3/Call;Ljava/lang/String;Ljava/util/List;)V", "GetDnsEnd_Lokhttp3_Call_Ljava_lang_String_Ljava_util_List_Handler")]
		public virtual unsafe void DnsEnd (global::Okhttp3.ICall call, string domainName, global::System.Collections.Generic.IList<global::Java.Net.InetAddress> inetAddressList)
		{
			const string __id = "dnsEnd.(Lokhttp3/Call;Ljava/lang/String;Ljava/util/List;)V";
			IntPtr native_domainName = JNIEnv.NewString (domainName);
			IntPtr native_inetAddressList = global::Android.Runtime.JavaList<global::Java.Net.InetAddress>.ToLocalJniHandle (inetAddressList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				__args [1] = new JniArgumentValue (native_domainName);
				__args [2] = new JniArgumentValue (native_inetAddressList);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_domainName);
				JNIEnv.DeleteLocalRef (native_inetAddressList);
			}
		}

		static Delegate cb_dnsStart_Lokhttp3_Call_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDnsStart_Lokhttp3_Call_Ljava_lang_String_Handler ()
		{
			if (cb_dnsStart_Lokhttp3_Call_Ljava_lang_String_ == null)
				cb_dnsStart_Lokhttp3_Call_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DnsStart_Lokhttp3_Call_Ljava_lang_String_);
			return cb_dnsStart_Lokhttp3_Call_Ljava_lang_String_;
		}

		static void n_DnsStart_Lokhttp3_Call_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_call, IntPtr native_domainName)
		{
			global::Okhttp3.EventListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			string domainName = JNIEnv.GetString (native_domainName, JniHandleOwnership.DoNotTransfer);
			__this.DnsStart (call, domainName);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/method[@name='dnsStart' and count(parameter)=2 and parameter[1][@type='okhttp3.Call'] and parameter[2][@type='java.lang.String']]"
		[Register ("dnsStart", "(Lokhttp3/Call;Ljava/lang/String;)V", "GetDnsStart_Lokhttp3_Call_Ljava_lang_String_Handler")]
		public virtual unsafe void DnsStart (global::Okhttp3.ICall call, string domainName)
		{
			const string __id = "dnsStart.(Lokhttp3/Call;Ljava/lang/String;)V";
			IntPtr native_domainName = JNIEnv.NewString (domainName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				__args [1] = new JniArgumentValue (native_domainName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_domainName);
			}
		}

		static Delegate cb_requestBodyEnd_Lokhttp3_Call_J;
#pragma warning disable 0169
		static Delegate GetRequestBodyEnd_Lokhttp3_Call_JHandler ()
		{
			if (cb_requestBodyEnd_Lokhttp3_Call_J == null)
				cb_requestBodyEnd_Lokhttp3_Call_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_RequestBodyEnd_Lokhttp3_Call_J);
			return cb_requestBodyEnd_Lokhttp3_Call_J;
		}

		static void n_RequestBodyEnd_Lokhttp3_Call_J (IntPtr jnienv, IntPtr native__this, IntPtr native_call, long byteCount)
		{
			global::Okhttp3.EventListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			__this.RequestBodyEnd (call, byteCount);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/method[@name='requestBodyEnd' and count(parameter)=2 and parameter[1][@type='okhttp3.Call'] and parameter[2][@type='long']]"
		[Register ("requestBodyEnd", "(Lokhttp3/Call;J)V", "GetRequestBodyEnd_Lokhttp3_Call_JHandler")]
		public virtual unsafe void RequestBodyEnd (global::Okhttp3.ICall call, long byteCount)
		{
			const string __id = "requestBodyEnd.(Lokhttp3/Call;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				__args [1] = new JniArgumentValue (byteCount);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_requestBodyStart_Lokhttp3_Call_;
#pragma warning disable 0169
		static Delegate GetRequestBodyStart_Lokhttp3_Call_Handler ()
		{
			if (cb_requestBodyStart_Lokhttp3_Call_ == null)
				cb_requestBodyStart_Lokhttp3_Call_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RequestBodyStart_Lokhttp3_Call_);
			return cb_requestBodyStart_Lokhttp3_Call_;
		}

		static void n_RequestBodyStart_Lokhttp3_Call_ (IntPtr jnienv, IntPtr native__this, IntPtr native_call)
		{
			global::Okhttp3.EventListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			__this.RequestBodyStart (call);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/method[@name='requestBodyStart' and count(parameter)=1 and parameter[1][@type='okhttp3.Call']]"
		[Register ("requestBodyStart", "(Lokhttp3/Call;)V", "GetRequestBodyStart_Lokhttp3_Call_Handler")]
		public virtual unsafe void RequestBodyStart (global::Okhttp3.ICall call)
		{
			const string __id = "requestBodyStart.(Lokhttp3/Call;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_requestHeadersEnd_Lokhttp3_Call_Lokhttp3_Request_;
#pragma warning disable 0169
		static Delegate GetRequestHeadersEnd_Lokhttp3_Call_Lokhttp3_Request_Handler ()
		{
			if (cb_requestHeadersEnd_Lokhttp3_Call_Lokhttp3_Request_ == null)
				cb_requestHeadersEnd_Lokhttp3_Call_Lokhttp3_Request_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestHeadersEnd_Lokhttp3_Call_Lokhttp3_Request_);
			return cb_requestHeadersEnd_Lokhttp3_Call_Lokhttp3_Request_;
		}

		static void n_RequestHeadersEnd_Lokhttp3_Call_Lokhttp3_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_call, IntPtr native_request)
		{
			global::Okhttp3.EventListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Request request = global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (native_request, JniHandleOwnership.DoNotTransfer);
			__this.RequestHeadersEnd (call, request);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/method[@name='requestHeadersEnd' and count(parameter)=2 and parameter[1][@type='okhttp3.Call'] and parameter[2][@type='okhttp3.Request']]"
		[Register ("requestHeadersEnd", "(Lokhttp3/Call;Lokhttp3/Request;)V", "GetRequestHeadersEnd_Lokhttp3_Call_Lokhttp3_Request_Handler")]
		public virtual unsafe void RequestHeadersEnd (global::Okhttp3.ICall call, global::Okhttp3.Request request)
		{
			const string __id = "requestHeadersEnd.(Lokhttp3/Call;Lokhttp3/Request;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				__args [1] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_requestHeadersStart_Lokhttp3_Call_;
#pragma warning disable 0169
		static Delegate GetRequestHeadersStart_Lokhttp3_Call_Handler ()
		{
			if (cb_requestHeadersStart_Lokhttp3_Call_ == null)
				cb_requestHeadersStart_Lokhttp3_Call_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RequestHeadersStart_Lokhttp3_Call_);
			return cb_requestHeadersStart_Lokhttp3_Call_;
		}

		static void n_RequestHeadersStart_Lokhttp3_Call_ (IntPtr jnienv, IntPtr native__this, IntPtr native_call)
		{
			global::Okhttp3.EventListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			__this.RequestHeadersStart (call);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/method[@name='requestHeadersStart' and count(parameter)=1 and parameter[1][@type='okhttp3.Call']]"
		[Register ("requestHeadersStart", "(Lokhttp3/Call;)V", "GetRequestHeadersStart_Lokhttp3_Call_Handler")]
		public virtual unsafe void RequestHeadersStart (global::Okhttp3.ICall call)
		{
			const string __id = "requestHeadersStart.(Lokhttp3/Call;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_responseBodyEnd_Lokhttp3_Call_J;
#pragma warning disable 0169
		static Delegate GetResponseBodyEnd_Lokhttp3_Call_JHandler ()
		{
			if (cb_responseBodyEnd_Lokhttp3_Call_J == null)
				cb_responseBodyEnd_Lokhttp3_Call_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_ResponseBodyEnd_Lokhttp3_Call_J);
			return cb_responseBodyEnd_Lokhttp3_Call_J;
		}

		static void n_ResponseBodyEnd_Lokhttp3_Call_J (IntPtr jnienv, IntPtr native__this, IntPtr native_call, long byteCount)
		{
			global::Okhttp3.EventListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			__this.ResponseBodyEnd (call, byteCount);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/method[@name='responseBodyEnd' and count(parameter)=2 and parameter[1][@type='okhttp3.Call'] and parameter[2][@type='long']]"
		[Register ("responseBodyEnd", "(Lokhttp3/Call;J)V", "GetResponseBodyEnd_Lokhttp3_Call_JHandler")]
		public virtual unsafe void ResponseBodyEnd (global::Okhttp3.ICall call, long byteCount)
		{
			const string __id = "responseBodyEnd.(Lokhttp3/Call;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				__args [1] = new JniArgumentValue (byteCount);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_responseBodyStart_Lokhttp3_Call_;
#pragma warning disable 0169
		static Delegate GetResponseBodyStart_Lokhttp3_Call_Handler ()
		{
			if (cb_responseBodyStart_Lokhttp3_Call_ == null)
				cb_responseBodyStart_Lokhttp3_Call_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ResponseBodyStart_Lokhttp3_Call_);
			return cb_responseBodyStart_Lokhttp3_Call_;
		}

		static void n_ResponseBodyStart_Lokhttp3_Call_ (IntPtr jnienv, IntPtr native__this, IntPtr native_call)
		{
			global::Okhttp3.EventListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			__this.ResponseBodyStart (call);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/method[@name='responseBodyStart' and count(parameter)=1 and parameter[1][@type='okhttp3.Call']]"
		[Register ("responseBodyStart", "(Lokhttp3/Call;)V", "GetResponseBodyStart_Lokhttp3_Call_Handler")]
		public virtual unsafe void ResponseBodyStart (global::Okhttp3.ICall call)
		{
			const string __id = "responseBodyStart.(Lokhttp3/Call;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_responseHeadersEnd_Lokhttp3_Call_Lokhttp3_Response_;
#pragma warning disable 0169
		static Delegate GetResponseHeadersEnd_Lokhttp3_Call_Lokhttp3_Response_Handler ()
		{
			if (cb_responseHeadersEnd_Lokhttp3_Call_Lokhttp3_Response_ == null)
				cb_responseHeadersEnd_Lokhttp3_Call_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ResponseHeadersEnd_Lokhttp3_Call_Lokhttp3_Response_);
			return cb_responseHeadersEnd_Lokhttp3_Call_Lokhttp3_Response_;
		}

		static void n_ResponseHeadersEnd_Lokhttp3_Call_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_call, IntPtr native_response)
		{
			global::Okhttp3.EventListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Response response = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (native_response, JniHandleOwnership.DoNotTransfer);
			__this.ResponseHeadersEnd (call, response);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/method[@name='responseHeadersEnd' and count(parameter)=2 and parameter[1][@type='okhttp3.Call'] and parameter[2][@type='okhttp3.Response']]"
		[Register ("responseHeadersEnd", "(Lokhttp3/Call;Lokhttp3/Response;)V", "GetResponseHeadersEnd_Lokhttp3_Call_Lokhttp3_Response_Handler")]
		public virtual unsafe void ResponseHeadersEnd (global::Okhttp3.ICall call, global::Okhttp3.Response response)
		{
			const string __id = "responseHeadersEnd.(Lokhttp3/Call;Lokhttp3/Response;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				__args [1] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_responseHeadersStart_Lokhttp3_Call_;
#pragma warning disable 0169
		static Delegate GetResponseHeadersStart_Lokhttp3_Call_Handler ()
		{
			if (cb_responseHeadersStart_Lokhttp3_Call_ == null)
				cb_responseHeadersStart_Lokhttp3_Call_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ResponseHeadersStart_Lokhttp3_Call_);
			return cb_responseHeadersStart_Lokhttp3_Call_;
		}

		static void n_ResponseHeadersStart_Lokhttp3_Call_ (IntPtr jnienv, IntPtr native__this, IntPtr native_call)
		{
			global::Okhttp3.EventListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			__this.ResponseHeadersStart (call);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/method[@name='responseHeadersStart' and count(parameter)=1 and parameter[1][@type='okhttp3.Call']]"
		[Register ("responseHeadersStart", "(Lokhttp3/Call;)V", "GetResponseHeadersStart_Lokhttp3_Call_Handler")]
		public virtual unsafe void ResponseHeadersStart (global::Okhttp3.ICall call)
		{
			const string __id = "responseHeadersStart.(Lokhttp3/Call;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_secureConnectEnd_Lokhttp3_Call_Lokhttp3_Handshake_;
#pragma warning disable 0169
		static Delegate GetSecureConnectEnd_Lokhttp3_Call_Lokhttp3_Handshake_Handler ()
		{
			if (cb_secureConnectEnd_Lokhttp3_Call_Lokhttp3_Handshake_ == null)
				cb_secureConnectEnd_Lokhttp3_Call_Lokhttp3_Handshake_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SecureConnectEnd_Lokhttp3_Call_Lokhttp3_Handshake_);
			return cb_secureConnectEnd_Lokhttp3_Call_Lokhttp3_Handshake_;
		}

		static void n_SecureConnectEnd_Lokhttp3_Call_Lokhttp3_Handshake_ (IntPtr jnienv, IntPtr native__this, IntPtr native_call, IntPtr native_handshake)
		{
			global::Okhttp3.EventListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Handshake handshake = global::Java.Lang.Object.GetObject<global::Okhttp3.Handshake> (native_handshake, JniHandleOwnership.DoNotTransfer);
			__this.SecureConnectEnd (call, handshake);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/method[@name='secureConnectEnd' and count(parameter)=2 and parameter[1][@type='okhttp3.Call'] and parameter[2][@type='okhttp3.Handshake']]"
		[Register ("secureConnectEnd", "(Lokhttp3/Call;Lokhttp3/Handshake;)V", "GetSecureConnectEnd_Lokhttp3_Call_Lokhttp3_Handshake_Handler")]
		public virtual unsafe void SecureConnectEnd (global::Okhttp3.ICall call, global::Okhttp3.Handshake handshake)
		{
			const string __id = "secureConnectEnd.(Lokhttp3/Call;Lokhttp3/Handshake;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				__args [1] = new JniArgumentValue ((handshake == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handshake).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_secureConnectStart_Lokhttp3_Call_;
#pragma warning disable 0169
		static Delegate GetSecureConnectStart_Lokhttp3_Call_Handler ()
		{
			if (cb_secureConnectStart_Lokhttp3_Call_ == null)
				cb_secureConnectStart_Lokhttp3_Call_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SecureConnectStart_Lokhttp3_Call_);
			return cb_secureConnectStart_Lokhttp3_Call_;
		}

		static void n_SecureConnectStart_Lokhttp3_Call_ (IntPtr jnienv, IntPtr native__this, IntPtr native_call)
		{
			global::Okhttp3.EventListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			__this.SecureConnectStart (call);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='EventListener']/method[@name='secureConnectStart' and count(parameter)=1 and parameter[1][@type='okhttp3.Call']]"
		[Register ("secureConnectStart", "(Lokhttp3/Call;)V", "GetSecureConnectStart_Lokhttp3_Call_Handler")]
		public virtual unsafe void SecureConnectStart (global::Okhttp3.ICall call)
		{
			const string __id = "secureConnectStart.(Lokhttp3/Call;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("okhttp3/EventListener", DoNotGenerateAcw=true)]
	internal partial class EventListenerInvoker : EventListener {

		public EventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/EventListener", typeof (EventListenerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
