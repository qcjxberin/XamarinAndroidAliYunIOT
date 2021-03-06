using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']"
	[global::Android.Runtime.Register ("okhttp3/internal/Internal", DoNotGenerateAcw=true)]
	public abstract partial class Internal : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/field[@name='instance']"
		[Register ("instance")]
		public static global::Okhttp3.Internal.Internal Instance {
			get {
				const string __id = "instance.Lokhttp3/internal/Internal;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "instance.Lokhttp3/internal/Internal;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/Internal", typeof (Internal));
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

		protected Internal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/constructor[@name='Internal' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Internal ()
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

		static Delegate cb_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Handler ()
		{
			if (cb_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_ == null)
				cb_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_);
			return cb_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_;
		}

		static void n_AddLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Okhttp3.Internal.Internal __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Headers.Builder p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers.Builder> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddLenient (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='addLenient' and count(parameter)=2 and parameter[1][@type='okhttp3.Headers.Builder'] and parameter[2][@type='java.lang.String']]"
		[Register ("addLenient", "(Lokhttp3/Headers$Builder;Ljava/lang/String;)V", "GetAddLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Handler")]
		public abstract void AddLenient (global::Okhttp3.Headers.Builder p0, string p1);

		static Delegate cb_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_);
			return cb_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Okhttp3.Internal.Internal __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Headers.Builder p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers.Builder> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddLenient (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='addLenient' and count(parameter)=3 and parameter[1][@type='okhttp3.Headers.Builder'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("addLenient", "(Lokhttp3/Headers$Builder;Ljava/lang/String;Ljava/lang/String;)V", "GetAddLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract void AddLenient (global::Okhttp3.Headers.Builder p0, string p1, string p2);

		static Delegate cb_apply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_Z;
#pragma warning disable 0169
		static Delegate GetApply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_ZHandler ()
		{
			if (cb_apply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_Z == null)
				cb_apply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Apply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_Z);
			return cb_apply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_Z;
		}

		static void n_Apply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Okhttp3.Internal.Internal __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ConnectionSpec p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.SSLSocket p1 = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocket> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Apply (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='apply' and count(parameter)=3 and parameter[1][@type='okhttp3.ConnectionSpec'] and parameter[2][@type='javax.net.ssl.SSLSocket'] and parameter[3][@type='boolean']]"
		[Register ("apply", "(Lokhttp3/ConnectionSpec;Ljavax/net/ssl/SSLSocket;Z)V", "GetApply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_ZHandler")]
		public abstract void Apply (global::Okhttp3.ConnectionSpec p0, global::Javax.Net.Ssl.SSLSocket p1, bool p2);

		static Delegate cb_code_Lokhttp3_Response_Builder_;
#pragma warning disable 0169
		static Delegate GetCode_Lokhttp3_Response_Builder_Handler ()
		{
			if (cb_code_Lokhttp3_Response_Builder_ == null)
				cb_code_Lokhttp3_Response_Builder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Code_Lokhttp3_Response_Builder_);
			return cb_code_Lokhttp3_Response_Builder_;
		}

		static int n_Code_Lokhttp3_Response_Builder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.Internal __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Response.Builder p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Code (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='code' and count(parameter)=1 and parameter[1][@type='okhttp3.Response.Builder']]"
		[Register ("code", "(Lokhttp3/Response$Builder;)I", "GetCode_Lokhttp3_Response_Builder_Handler")]
		public abstract int Code (global::Okhttp3.Response.Builder p0);

		static Delegate cb_connectionBecameIdle_Lokhttp3_ConnectionPool_Lokhttp3_internal_connection_RealConnection_;
#pragma warning disable 0169
		static Delegate GetConnectionBecameIdle_Lokhttp3_ConnectionPool_Lokhttp3_internal_connection_RealConnection_Handler ()
		{
			if (cb_connectionBecameIdle_Lokhttp3_ConnectionPool_Lokhttp3_internal_connection_RealConnection_ == null)
				cb_connectionBecameIdle_Lokhttp3_ConnectionPool_Lokhttp3_internal_connection_RealConnection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_ConnectionBecameIdle_Lokhttp3_ConnectionPool_Lokhttp3_internal_connection_RealConnection_);
			return cb_connectionBecameIdle_Lokhttp3_ConnectionPool_Lokhttp3_internal_connection_RealConnection_;
		}

		static bool n_ConnectionBecameIdle_Lokhttp3_ConnectionPool_Lokhttp3_internal_connection_RealConnection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Okhttp3.Internal.Internal __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ConnectionPool p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionPool> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Internal.Connection.RealConnection p1 = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Connection.RealConnection> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ConnectionBecameIdle (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='connectionBecameIdle' and count(parameter)=2 and parameter[1][@type='okhttp3.ConnectionPool'] and parameter[2][@type='okhttp3.internal.connection.RealConnection']]"
		[Register ("connectionBecameIdle", "(Lokhttp3/ConnectionPool;Lokhttp3/internal/connection/RealConnection;)Z", "GetConnectionBecameIdle_Lokhttp3_ConnectionPool_Lokhttp3_internal_connection_RealConnection_Handler")]
		public abstract bool ConnectionBecameIdle (global::Okhttp3.ConnectionPool p0, global::Okhttp3.Internal.Connection.RealConnection p1);

		static Delegate cb_deduplicate_Lokhttp3_ConnectionPool_Lokhttp3_Address_Lokhttp3_internal_connection_StreamAllocation_;
#pragma warning disable 0169
		static Delegate GetDeduplicate_Lokhttp3_ConnectionPool_Lokhttp3_Address_Lokhttp3_internal_connection_StreamAllocation_Handler ()
		{
			if (cb_deduplicate_Lokhttp3_ConnectionPool_Lokhttp3_Address_Lokhttp3_internal_connection_StreamAllocation_ == null)
				cb_deduplicate_Lokhttp3_ConnectionPool_Lokhttp3_Address_Lokhttp3_internal_connection_StreamAllocation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Deduplicate_Lokhttp3_ConnectionPool_Lokhttp3_Address_Lokhttp3_internal_connection_StreamAllocation_);
			return cb_deduplicate_Lokhttp3_ConnectionPool_Lokhttp3_Address_Lokhttp3_internal_connection_StreamAllocation_;
		}

		static IntPtr n_Deduplicate_Lokhttp3_ConnectionPool_Lokhttp3_Address_Lokhttp3_internal_connection_StreamAllocation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Okhttp3.Internal.Internal __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ConnectionPool p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionPool> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Address p1 = global::Java.Lang.Object.GetObject<global::Okhttp3.Address> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Internal.Connection.StreamAllocation p2 = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Connection.StreamAllocation> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Deduplicate (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='deduplicate' and count(parameter)=3 and parameter[1][@type='okhttp3.ConnectionPool'] and parameter[2][@type='okhttp3.Address'] and parameter[3][@type='okhttp3.internal.connection.StreamAllocation']]"
		[Register ("deduplicate", "(Lokhttp3/ConnectionPool;Lokhttp3/Address;Lokhttp3/internal/connection/StreamAllocation;)Ljava/net/Socket;", "GetDeduplicate_Lokhttp3_ConnectionPool_Lokhttp3_Address_Lokhttp3_internal_connection_StreamAllocation_Handler")]
		public abstract global::Java.Net.Socket Deduplicate (global::Okhttp3.ConnectionPool p0, global::Okhttp3.Address p1, global::Okhttp3.Internal.Connection.StreamAllocation p2);

		static Delegate cb_equalsNonHost_Lokhttp3_Address_Lokhttp3_Address_;
#pragma warning disable 0169
		static Delegate GetEqualsNonHost_Lokhttp3_Address_Lokhttp3_Address_Handler ()
		{
			if (cb_equalsNonHost_Lokhttp3_Address_Lokhttp3_Address_ == null)
				cb_equalsNonHost_Lokhttp3_Address_Lokhttp3_Address_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_EqualsNonHost_Lokhttp3_Address_Lokhttp3_Address_);
			return cb_equalsNonHost_Lokhttp3_Address_Lokhttp3_Address_;
		}

		static bool n_EqualsNonHost_Lokhttp3_Address_Lokhttp3_Address_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Okhttp3.Internal.Internal __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Address p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Address> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Address p1 = global::Java.Lang.Object.GetObject<global::Okhttp3.Address> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.EqualsNonHost (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='equalsNonHost' and count(parameter)=2 and parameter[1][@type='okhttp3.Address'] and parameter[2][@type='okhttp3.Address']]"
		[Register ("equalsNonHost", "(Lokhttp3/Address;Lokhttp3/Address;)Z", "GetEqualsNonHost_Lokhttp3_Address_Lokhttp3_Address_Handler")]
		public abstract bool EqualsNonHost (global::Okhttp3.Address p0, global::Okhttp3.Address p1);

		static Delegate cb_get_Lokhttp3_ConnectionPool_Lokhttp3_Address_Lokhttp3_internal_connection_StreamAllocation_Lokhttp3_Route_;
#pragma warning disable 0169
		static Delegate GetGet_Lokhttp3_ConnectionPool_Lokhttp3_Address_Lokhttp3_internal_connection_StreamAllocation_Lokhttp3_Route_Handler ()
		{
			if (cb_get_Lokhttp3_ConnectionPool_Lokhttp3_Address_Lokhttp3_internal_connection_StreamAllocation_Lokhttp3_Route_ == null)
				cb_get_Lokhttp3_ConnectionPool_Lokhttp3_Address_Lokhttp3_internal_connection_StreamAllocation_Lokhttp3_Route_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Lokhttp3_ConnectionPool_Lokhttp3_Address_Lokhttp3_internal_connection_StreamAllocation_Lokhttp3_Route_);
			return cb_get_Lokhttp3_ConnectionPool_Lokhttp3_Address_Lokhttp3_internal_connection_StreamAllocation_Lokhttp3_Route_;
		}

		static IntPtr n_Get_Lokhttp3_ConnectionPool_Lokhttp3_Address_Lokhttp3_internal_connection_StreamAllocation_Lokhttp3_Route_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Okhttp3.Internal.Internal __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ConnectionPool p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionPool> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Address p1 = global::Java.Lang.Object.GetObject<global::Okhttp3.Address> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Internal.Connection.StreamAllocation p2 = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Connection.StreamAllocation> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Route p3 = global::Java.Lang.Object.GetObject<global::Okhttp3.Route> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='get' and count(parameter)=4 and parameter[1][@type='okhttp3.ConnectionPool'] and parameter[2][@type='okhttp3.Address'] and parameter[3][@type='okhttp3.internal.connection.StreamAllocation'] and parameter[4][@type='okhttp3.Route']]"
		[Register ("get", "(Lokhttp3/ConnectionPool;Lokhttp3/Address;Lokhttp3/internal/connection/StreamAllocation;Lokhttp3/Route;)Lokhttp3/internal/connection/RealConnection;", "GetGet_Lokhttp3_ConnectionPool_Lokhttp3_Address_Lokhttp3_internal_connection_StreamAllocation_Lokhttp3_Route_Handler")]
		public abstract global::Okhttp3.Internal.Connection.RealConnection Get (global::Okhttp3.ConnectionPool p0, global::Okhttp3.Address p1, global::Okhttp3.Internal.Connection.StreamAllocation p2, global::Okhttp3.Route p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='initializeInstanceForTests' and count(parameter)=0]"
		[Register ("initializeInstanceForTests", "()V", "")]
		public static unsafe void InitializeInstanceForTests ()
		{
			const string __id = "initializeInstanceForTests.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		static Delegate cb_isInvalidHttpUrlHost_Ljava_lang_IllegalArgumentException_;
#pragma warning disable 0169
		static Delegate GetIsInvalidHttpUrlHost_Ljava_lang_IllegalArgumentException_Handler ()
		{
			if (cb_isInvalidHttpUrlHost_Ljava_lang_IllegalArgumentException_ == null)
				cb_isInvalidHttpUrlHost_Ljava_lang_IllegalArgumentException_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsInvalidHttpUrlHost_Ljava_lang_IllegalArgumentException_);
			return cb_isInvalidHttpUrlHost_Ljava_lang_IllegalArgumentException_;
		}

		static bool n_IsInvalidHttpUrlHost_Ljava_lang_IllegalArgumentException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.Internal __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IllegalArgumentException p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.IllegalArgumentException> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsInvalidHttpUrlHost (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='isInvalidHttpUrlHost' and count(parameter)=1 and parameter[1][@type='java.lang.IllegalArgumentException']]"
		[Register ("isInvalidHttpUrlHost", "(Ljava/lang/IllegalArgumentException;)Z", "GetIsInvalidHttpUrlHost_Ljava_lang_IllegalArgumentException_Handler")]
		public abstract bool IsInvalidHttpUrlHost (global::Java.Lang.IllegalArgumentException p0);

		static Delegate cb_newWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_;
#pragma warning disable 0169
		static Delegate GetNewWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_Handler ()
		{
			if (cb_newWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_ == null)
				cb_newWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_NewWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_);
			return cb_newWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_;
		}

		static IntPtr n_NewWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Okhttp3.Internal.Internal __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.OkHttpClient p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Request p1 = global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewWebSocketCall (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='newWebSocketCall' and count(parameter)=2 and parameter[1][@type='okhttp3.OkHttpClient'] and parameter[2][@type='okhttp3.Request']]"
		[Register ("newWebSocketCall", "(Lokhttp3/OkHttpClient;Lokhttp3/Request;)Lokhttp3/Call;", "GetNewWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_Handler")]
		public abstract global::Okhttp3.ICall NewWebSocketCall (global::Okhttp3.OkHttpClient p0, global::Okhttp3.Request p1);

		static Delegate cb_put_Lokhttp3_ConnectionPool_Lokhttp3_internal_connection_RealConnection_;
#pragma warning disable 0169
		static Delegate GetPut_Lokhttp3_ConnectionPool_Lokhttp3_internal_connection_RealConnection_Handler ()
		{
			if (cb_put_Lokhttp3_ConnectionPool_Lokhttp3_internal_connection_RealConnection_ == null)
				cb_put_Lokhttp3_ConnectionPool_Lokhttp3_internal_connection_RealConnection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Lokhttp3_ConnectionPool_Lokhttp3_internal_connection_RealConnection_);
			return cb_put_Lokhttp3_ConnectionPool_Lokhttp3_internal_connection_RealConnection_;
		}

		static void n_Put_Lokhttp3_ConnectionPool_Lokhttp3_internal_connection_RealConnection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Okhttp3.Internal.Internal __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ConnectionPool p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionPool> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Internal.Connection.RealConnection p1 = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Connection.RealConnection> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='put' and count(parameter)=2 and parameter[1][@type='okhttp3.ConnectionPool'] and parameter[2][@type='okhttp3.internal.connection.RealConnection']]"
		[Register ("put", "(Lokhttp3/ConnectionPool;Lokhttp3/internal/connection/RealConnection;)V", "GetPut_Lokhttp3_ConnectionPool_Lokhttp3_internal_connection_RealConnection_Handler")]
		public abstract void Put (global::Okhttp3.ConnectionPool p0, global::Okhttp3.Internal.Connection.RealConnection p1);

		static Delegate cb_routeDatabase_Lokhttp3_ConnectionPool_;
#pragma warning disable 0169
		static Delegate GetRouteDatabase_Lokhttp3_ConnectionPool_Handler ()
		{
			if (cb_routeDatabase_Lokhttp3_ConnectionPool_ == null)
				cb_routeDatabase_Lokhttp3_ConnectionPool_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RouteDatabase_Lokhttp3_ConnectionPool_);
			return cb_routeDatabase_Lokhttp3_ConnectionPool_;
		}

		static IntPtr n_RouteDatabase_Lokhttp3_ConnectionPool_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.Internal __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ConnectionPool p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionPool> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RouteDatabase (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='routeDatabase' and count(parameter)=1 and parameter[1][@type='okhttp3.ConnectionPool']]"
		[Register ("routeDatabase", "(Lokhttp3/ConnectionPool;)Lokhttp3/internal/connection/RouteDatabase;", "GetRouteDatabase_Lokhttp3_ConnectionPool_Handler")]
		public abstract global::Okhttp3.Internal.Connection.RouteDatabase RouteDatabase (global::Okhttp3.ConnectionPool p0);

		static Delegate cb_setCache_Lokhttp3_OkHttpClient_Builder_Lokhttp3_internal_cache_InternalCache_;
#pragma warning disable 0169
		static Delegate GetSetCache_Lokhttp3_OkHttpClient_Builder_Lokhttp3_internal_cache_InternalCache_Handler ()
		{
			if (cb_setCache_Lokhttp3_OkHttpClient_Builder_Lokhttp3_internal_cache_InternalCache_ == null)
				cb_setCache_Lokhttp3_OkHttpClient_Builder_Lokhttp3_internal_cache_InternalCache_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCache_Lokhttp3_OkHttpClient_Builder_Lokhttp3_internal_cache_InternalCache_);
			return cb_setCache_Lokhttp3_OkHttpClient_Builder_Lokhttp3_internal_cache_InternalCache_;
		}

		static void n_SetCache_Lokhttp3_OkHttpClient_Builder_Lokhttp3_internal_cache_InternalCache_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Okhttp3.Internal.Internal __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.OkHttpClient.Builder p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Internal.Cache.IInternalCache p1 = (global::Okhttp3.Internal.Cache.IInternalCache)global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Cache.IInternalCache> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetCache (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='setCache' and count(parameter)=2 and parameter[1][@type='okhttp3.OkHttpClient.Builder'] and parameter[2][@type='okhttp3.internal.cache.InternalCache']]"
		[Register ("setCache", "(Lokhttp3/OkHttpClient$Builder;Lokhttp3/internal/cache/InternalCache;)V", "GetSetCache_Lokhttp3_OkHttpClient_Builder_Lokhttp3_internal_cache_InternalCache_Handler")]
		public abstract void SetCache (global::Okhttp3.OkHttpClient.Builder p0, global::Okhttp3.Internal.Cache.IInternalCache p1);

		static Delegate cb_streamAllocation_Lokhttp3_Call_;
#pragma warning disable 0169
		static Delegate GetStreamAllocation_Lokhttp3_Call_Handler ()
		{
			if (cb_streamAllocation_Lokhttp3_Call_ == null)
				cb_streamAllocation_Lokhttp3_Call_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_StreamAllocation_Lokhttp3_Call_);
			return cb_streamAllocation_Lokhttp3_Call_;
		}

		static IntPtr n_StreamAllocation_Lokhttp3_Call_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.Internal __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall p0 = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StreamAllocation (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='streamAllocation' and count(parameter)=1 and parameter[1][@type='okhttp3.Call']]"
		[Register ("streamAllocation", "(Lokhttp3/Call;)Lokhttp3/internal/connection/StreamAllocation;", "GetStreamAllocation_Lokhttp3_Call_Handler")]
		public abstract global::Okhttp3.Internal.Connection.StreamAllocation StreamAllocation (global::Okhttp3.ICall p0);

		static Delegate cb_timeoutExit_Lokhttp3_Call_Ljava_io_IOException_;
#pragma warning disable 0169
		static Delegate GetTimeoutExit_Lokhttp3_Call_Ljava_io_IOException_Handler ()
		{
			if (cb_timeoutExit_Lokhttp3_Call_Ljava_io_IOException_ == null)
				cb_timeoutExit_Lokhttp3_Call_Ljava_io_IOException_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_TimeoutExit_Lokhttp3_Call_Ljava_io_IOException_);
			return cb_timeoutExit_Lokhttp3_Call_Ljava_io_IOException_;
		}

		static IntPtr n_TimeoutExit_Lokhttp3_Call_Ljava_io_IOException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Okhttp3.Internal.Internal __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall p0 = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.IOException p1 = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TimeoutExit (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='timeoutExit' and count(parameter)=2 and parameter[1][@type='okhttp3.Call'] and parameter[2][@type='java.io.IOException']]"
		[Register ("timeoutExit", "(Lokhttp3/Call;Ljava/io/IOException;)Ljava/io/IOException;", "GetTimeoutExit_Lokhttp3_Call_Ljava_io_IOException_Handler")]
		public abstract global::Java.IO.IOException TimeoutExit (global::Okhttp3.ICall p0, global::Java.IO.IOException p1);

	}

	[global::Android.Runtime.Register ("okhttp3/internal/Internal", DoNotGenerateAcw=true)]
	internal partial class InternalInvoker : Internal {

		public InternalInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/Internal", typeof (InternalInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='addLenient' and count(parameter)=2 and parameter[1][@type='okhttp3.Headers.Builder'] and parameter[2][@type='java.lang.String']]"
		[Register ("addLenient", "(Lokhttp3/Headers$Builder;Ljava/lang/String;)V", "GetAddLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Handler")]
		public override unsafe void AddLenient (global::Okhttp3.Headers.Builder p0, string p1)
		{
			const string __id = "addLenient.(Lokhttp3/Headers$Builder;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='addLenient' and count(parameter)=3 and parameter[1][@type='okhttp3.Headers.Builder'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("addLenient", "(Lokhttp3/Headers$Builder;Ljava/lang/String;Ljava/lang/String;)V", "GetAddLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void AddLenient (global::Okhttp3.Headers.Builder p0, string p1, string p2)
		{
			const string __id = "addLenient.(Lokhttp3/Headers$Builder;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='apply' and count(parameter)=3 and parameter[1][@type='okhttp3.ConnectionSpec'] and parameter[2][@type='javax.net.ssl.SSLSocket'] and parameter[3][@type='boolean']]"
		[Register ("apply", "(Lokhttp3/ConnectionSpec;Ljavax/net/ssl/SSLSocket;Z)V", "GetApply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_ZHandler")]
		public override unsafe void Apply (global::Okhttp3.ConnectionSpec p0, global::Javax.Net.Ssl.SSLSocket p1, bool p2)
		{
			const string __id = "apply.(Lokhttp3/ConnectionSpec;Ljavax/net/ssl/SSLSocket;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='code' and count(parameter)=1 and parameter[1][@type='okhttp3.Response.Builder']]"
		[Register ("code", "(Lokhttp3/Response$Builder;)I", "GetCode_Lokhttp3_Response_Builder_Handler")]
		public override unsafe int Code (global::Okhttp3.Response.Builder p0)
		{
			const string __id = "code.(Lokhttp3/Response$Builder;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='connectionBecameIdle' and count(parameter)=2 and parameter[1][@type='okhttp3.ConnectionPool'] and parameter[2][@type='okhttp3.internal.connection.RealConnection']]"
		[Register ("connectionBecameIdle", "(Lokhttp3/ConnectionPool;Lokhttp3/internal/connection/RealConnection;)Z", "GetConnectionBecameIdle_Lokhttp3_ConnectionPool_Lokhttp3_internal_connection_RealConnection_Handler")]
		public override unsafe bool ConnectionBecameIdle (global::Okhttp3.ConnectionPool p0, global::Okhttp3.Internal.Connection.RealConnection p1)
		{
			const string __id = "connectionBecameIdle.(Lokhttp3/ConnectionPool;Lokhttp3/internal/connection/RealConnection;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='deduplicate' and count(parameter)=3 and parameter[1][@type='okhttp3.ConnectionPool'] and parameter[2][@type='okhttp3.Address'] and parameter[3][@type='okhttp3.internal.connection.StreamAllocation']]"
		[Register ("deduplicate", "(Lokhttp3/ConnectionPool;Lokhttp3/Address;Lokhttp3/internal/connection/StreamAllocation;)Ljava/net/Socket;", "GetDeduplicate_Lokhttp3_ConnectionPool_Lokhttp3_Address_Lokhttp3_internal_connection_StreamAllocation_Handler")]
		public override unsafe global::Java.Net.Socket Deduplicate (global::Okhttp3.ConnectionPool p0, global::Okhttp3.Address p1, global::Okhttp3.Internal.Connection.StreamAllocation p2)
		{
			const string __id = "deduplicate.(Lokhttp3/ConnectionPool;Lokhttp3/Address;Lokhttp3/internal/connection/StreamAllocation;)Ljava/net/Socket;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='equalsNonHost' and count(parameter)=2 and parameter[1][@type='okhttp3.Address'] and parameter[2][@type='okhttp3.Address']]"
		[Register ("equalsNonHost", "(Lokhttp3/Address;Lokhttp3/Address;)Z", "GetEqualsNonHost_Lokhttp3_Address_Lokhttp3_Address_Handler")]
		public override unsafe bool EqualsNonHost (global::Okhttp3.Address p0, global::Okhttp3.Address p1)
		{
			const string __id = "equalsNonHost.(Lokhttp3/Address;Lokhttp3/Address;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='get' and count(parameter)=4 and parameter[1][@type='okhttp3.ConnectionPool'] and parameter[2][@type='okhttp3.Address'] and parameter[3][@type='okhttp3.internal.connection.StreamAllocation'] and parameter[4][@type='okhttp3.Route']]"
		[Register ("get", "(Lokhttp3/ConnectionPool;Lokhttp3/Address;Lokhttp3/internal/connection/StreamAllocation;Lokhttp3/Route;)Lokhttp3/internal/connection/RealConnection;", "GetGet_Lokhttp3_ConnectionPool_Lokhttp3_Address_Lokhttp3_internal_connection_StreamAllocation_Lokhttp3_Route_Handler")]
		public override unsafe global::Okhttp3.Internal.Connection.RealConnection Get (global::Okhttp3.ConnectionPool p0, global::Okhttp3.Address p1, global::Okhttp3.Internal.Connection.StreamAllocation p2, global::Okhttp3.Route p3)
		{
			const string __id = "get.(Lokhttp3/ConnectionPool;Lokhttp3/Address;Lokhttp3/internal/connection/StreamAllocation;Lokhttp3/Route;)Lokhttp3/internal/connection/RealConnection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Connection.RealConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='isInvalidHttpUrlHost' and count(parameter)=1 and parameter[1][@type='java.lang.IllegalArgumentException']]"
		[Register ("isInvalidHttpUrlHost", "(Ljava/lang/IllegalArgumentException;)Z", "GetIsInvalidHttpUrlHost_Ljava_lang_IllegalArgumentException_Handler")]
		public override unsafe bool IsInvalidHttpUrlHost (global::Java.Lang.IllegalArgumentException p0)
		{
			const string __id = "isInvalidHttpUrlHost.(Ljava/lang/IllegalArgumentException;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='newWebSocketCall' and count(parameter)=2 and parameter[1][@type='okhttp3.OkHttpClient'] and parameter[2][@type='okhttp3.Request']]"
		[Register ("newWebSocketCall", "(Lokhttp3/OkHttpClient;Lokhttp3/Request;)Lokhttp3/Call;", "GetNewWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_Handler")]
		public override unsafe global::Okhttp3.ICall NewWebSocketCall (global::Okhttp3.OkHttpClient p0, global::Okhttp3.Request p1)
		{
			const string __id = "newWebSocketCall.(Lokhttp3/OkHttpClient;Lokhttp3/Request;)Lokhttp3/Call;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='put' and count(parameter)=2 and parameter[1][@type='okhttp3.ConnectionPool'] and parameter[2][@type='okhttp3.internal.connection.RealConnection']]"
		[Register ("put", "(Lokhttp3/ConnectionPool;Lokhttp3/internal/connection/RealConnection;)V", "GetPut_Lokhttp3_ConnectionPool_Lokhttp3_internal_connection_RealConnection_Handler")]
		public override unsafe void Put (global::Okhttp3.ConnectionPool p0, global::Okhttp3.Internal.Connection.RealConnection p1)
		{
			const string __id = "put.(Lokhttp3/ConnectionPool;Lokhttp3/internal/connection/RealConnection;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='routeDatabase' and count(parameter)=1 and parameter[1][@type='okhttp3.ConnectionPool']]"
		[Register ("routeDatabase", "(Lokhttp3/ConnectionPool;)Lokhttp3/internal/connection/RouteDatabase;", "GetRouteDatabase_Lokhttp3_ConnectionPool_Handler")]
		public override unsafe global::Okhttp3.Internal.Connection.RouteDatabase RouteDatabase (global::Okhttp3.ConnectionPool p0)
		{
			const string __id = "routeDatabase.(Lokhttp3/ConnectionPool;)Lokhttp3/internal/connection/RouteDatabase;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Connection.RouteDatabase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='setCache' and count(parameter)=2 and parameter[1][@type='okhttp3.OkHttpClient.Builder'] and parameter[2][@type='okhttp3.internal.cache.InternalCache']]"
		[Register ("setCache", "(Lokhttp3/OkHttpClient$Builder;Lokhttp3/internal/cache/InternalCache;)V", "GetSetCache_Lokhttp3_OkHttpClient_Builder_Lokhttp3_internal_cache_InternalCache_Handler")]
		public override unsafe void SetCache (global::Okhttp3.OkHttpClient.Builder p0, global::Okhttp3.Internal.Cache.IInternalCache p1)
		{
			const string __id = "setCache.(Lokhttp3/OkHttpClient$Builder;Lokhttp3/internal/cache/InternalCache;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='streamAllocation' and count(parameter)=1 and parameter[1][@type='okhttp3.Call']]"
		[Register ("streamAllocation", "(Lokhttp3/Call;)Lokhttp3/internal/connection/StreamAllocation;", "GetStreamAllocation_Lokhttp3_Call_Handler")]
		public override unsafe global::Okhttp3.Internal.Connection.StreamAllocation StreamAllocation (global::Okhttp3.ICall p0)
		{
			const string __id = "streamAllocation.(Lokhttp3/Call;)Lokhttp3/internal/connection/StreamAllocation;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Connection.StreamAllocation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='timeoutExit' and count(parameter)=2 and parameter[1][@type='okhttp3.Call'] and parameter[2][@type='java.io.IOException']]"
		[Register ("timeoutExit", "(Lokhttp3/Call;Ljava/io/IOException;)Ljava/io/IOException;", "GetTimeoutExit_Lokhttp3_Call_Ljava_io_IOException_Handler")]
		public override unsafe global::Java.IO.IOException TimeoutExit (global::Okhttp3.ICall p0, global::Java.IO.IOException p1)
		{
			const string __id = "timeoutExit.(Lokhttp3/Call;Ljava/io/IOException;)Ljava/io/IOException;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
