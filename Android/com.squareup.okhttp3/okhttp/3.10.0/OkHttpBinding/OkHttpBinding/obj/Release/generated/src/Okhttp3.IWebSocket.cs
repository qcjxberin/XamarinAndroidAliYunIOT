using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3']/interface[@name='WebSocket.Factory']"
	[Register ("okhttp3/WebSocket$Factory", "", "Okhttp3.IWebSocketFactoryInvoker")]
	public partial interface IWebSocketFactory : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='WebSocket.Factory']/method[@name='newWebSocket' and count(parameter)=2 and parameter[1][@type='okhttp3.Request'] and parameter[2][@type='okhttp3.WebSocketListener']]"
		[Register ("newWebSocket", "(Lokhttp3/Request;Lokhttp3/WebSocketListener;)Lokhttp3/WebSocket;", "GetNewWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_Handler:Okhttp3.IWebSocketFactoryInvoker, OkHttpBinding")]
		global::Okhttp3.IWebSocket NewWebSocket (global::Okhttp3.Request p0, global::Okhttp3.WebSocketListener p1);

	}

	[global::Android.Runtime.Register ("okhttp3/WebSocket$Factory", DoNotGenerateAcw=true)]
	internal partial class IWebSocketFactoryInvoker : global::Java.Lang.Object, IWebSocketFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/WebSocket$Factory", typeof (IWebSocketFactoryInvoker));

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

		public static IWebSocketFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWebSocketFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.WebSocket.Factory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWebSocketFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_newWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_;
#pragma warning disable 0169
		static Delegate GetNewWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_Handler ()
		{
			if (cb_newWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_ == null)
				cb_newWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_NewWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_);
			return cb_newWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_;
		}

		static IntPtr n_NewWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Okhttp3.IWebSocketFactory __this = global::Java.Lang.Object.GetObject<global::Okhttp3.IWebSocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Request p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.WebSocketListener p1 = global::Java.Lang.Object.GetObject<global::Okhttp3.WebSocketListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewWebSocket (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_newWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_;
		public unsafe global::Okhttp3.IWebSocket NewWebSocket (global::Okhttp3.Request p0, global::Okhttp3.WebSocketListener p1)
		{
			if (id_newWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_ == IntPtr.Zero)
				id_newWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_ = JNIEnv.GetMethodID (class_ref, "newWebSocket", "(Lokhttp3/Request;Lokhttp3/WebSocketListener;)Lokhttp3/WebSocket;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Okhttp3.IWebSocket __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.IWebSocket> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3']/interface[@name='WebSocket']"
	[Register ("okhttp3/WebSocket", "", "Okhttp3.IWebSocketInvoker")]
	public partial interface IWebSocket : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='WebSocket']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler:Okhttp3.IWebSocketInvoker, OkHttpBinding")]
		void Cancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='WebSocket']/method[@name='close' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("close", "(ILjava/lang/String;)Z", "GetClose_ILjava_lang_String_Handler:Okhttp3.IWebSocketInvoker, OkHttpBinding")]
		bool Close (int p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='WebSocket']/method[@name='queueSize' and count(parameter)=0]"
		[Register ("queueSize", "()J", "GetQueueSizeHandler:Okhttp3.IWebSocketInvoker, OkHttpBinding")]
		long QueueSize ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='WebSocket']/method[@name='request' and count(parameter)=0]"
		[Register ("request", "()Lokhttp3/Request;", "GetRequestHandler:Okhttp3.IWebSocketInvoker, OkHttpBinding")]
		global::Okhttp3.Request Request ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='WebSocket']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("send", "(Ljava/lang/String;)Z", "GetSend_Ljava_lang_String_Handler:Okhttp3.IWebSocketInvoker, OkHttpBinding")]
		bool Send (string p0);

	}

	[global::Android.Runtime.Register ("okhttp3/WebSocket", DoNotGenerateAcw=true)]
	internal partial class IWebSocketInvoker : global::Java.Lang.Object, IWebSocket {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/WebSocket", typeof (IWebSocketInvoker));

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

		public static IWebSocket GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWebSocket> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.WebSocket"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWebSocketInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Okhttp3.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		IntPtr id_cancel;
		public unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
		}

		static Delegate cb_close_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClose_ILjava_lang_String_Handler ()
		{
			if (cb_close_ILjava_lang_String_ == null)
				cb_close_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_Close_ILjava_lang_String_);
			return cb_close_ILjava_lang_String_;
		}

		static bool n_Close_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Okhttp3.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Okhttp3.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Close (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_close_ILjava_lang_String_;
		public unsafe bool Close (int p0, string p1)
		{
			if (id_close_ILjava_lang_String_ == IntPtr.Zero)
				id_close_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "close", "(ILjava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_close_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_queueSize;
#pragma warning disable 0169
		static Delegate GetQueueSizeHandler ()
		{
			if (cb_queueSize == null)
				cb_queueSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_QueueSize);
			return cb_queueSize;
		}

		static long n_QueueSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Okhttp3.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.QueueSize ();
		}
#pragma warning restore 0169

		IntPtr id_queueSize;
		public unsafe long QueueSize ()
		{
			if (id_queueSize == IntPtr.Zero)
				id_queueSize = JNIEnv.GetMethodID (class_ref, "queueSize", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_queueSize);
		}

		static Delegate cb_request;
#pragma warning disable 0169
		static Delegate GetRequestHandler ()
		{
			if (cb_request == null)
				cb_request = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Request);
			return cb_request;
		}

		static IntPtr n_Request (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Okhttp3.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Request ());
		}
#pragma warning restore 0169

		IntPtr id_request;
		public unsafe global::Okhttp3.Request Request ()
		{
			if (id_request == IntPtr.Zero)
				id_request = JNIEnv.GetMethodID (class_ref, "request", "()Lokhttp3/Request;");
			return global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_request), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_send_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSend_Ljava_lang_String_Handler ()
		{
			if (cb_send_Ljava_lang_String_ == null)
				cb_send_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Send_Ljava_lang_String_);
			return cb_send_Ljava_lang_String_;
		}

		static bool n_Send_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Okhttp3.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Send (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_send_Ljava_lang_String_;
		public unsafe bool Send (string p0)
		{
			if (id_send_Ljava_lang_String_ == IntPtr.Zero)
				id_send_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_send_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
