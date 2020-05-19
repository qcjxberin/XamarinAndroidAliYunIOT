using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='WebSocketListener']"
	[global::Android.Runtime.Register ("okhttp3/WebSocketListener", DoNotGenerateAcw=true)]
	public abstract partial class WebSocketListener : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/WebSocketListener", typeof (WebSocketListener));
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

		protected WebSocketListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='WebSocketListener']/constructor[@name='WebSocketListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WebSocketListener ()
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

		static Delegate cb_onClosed_Lokhttp3_WebSocket_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnClosed_Lokhttp3_WebSocket_ILjava_lang_String_Handler ()
		{
			if (cb_onClosed_Lokhttp3_WebSocket_ILjava_lang_String_ == null)
				cb_onClosed_Lokhttp3_WebSocket_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnClosed_Lokhttp3_WebSocket_ILjava_lang_String_);
			return cb_onClosed_Lokhttp3_WebSocket_ILjava_lang_String_;
		}

		static void n_OnClosed_Lokhttp3_WebSocket_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_webSocket, int code, IntPtr native_reason)
		{
			global::Okhttp3.WebSocketListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.WebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.IWebSocket webSocket = (global::Okhttp3.IWebSocket)global::Java.Lang.Object.GetObject<global::Okhttp3.IWebSocket> (native_webSocket, JniHandleOwnership.DoNotTransfer);
			string reason = JNIEnv.GetString (native_reason, JniHandleOwnership.DoNotTransfer);
			__this.OnClosed (webSocket, code, reason);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='WebSocketListener']/method[@name='onClosed' and count(parameter)=3 and parameter[1][@type='okhttp3.WebSocket'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onClosed", "(Lokhttp3/WebSocket;ILjava/lang/String;)V", "GetOnClosed_Lokhttp3_WebSocket_ILjava_lang_String_Handler")]
		public virtual unsafe void OnClosed (global::Okhttp3.IWebSocket webSocket, int code, string reason)
		{
			const string __id = "onClosed.(Lokhttp3/WebSocket;ILjava/lang/String;)V";
			IntPtr native_reason = JNIEnv.NewString (reason);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((webSocket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) webSocket).Handle);
				__args [1] = new JniArgumentValue (code);
				__args [2] = new JniArgumentValue (native_reason);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_reason);
			}
		}

		static Delegate cb_onClosing_Lokhttp3_WebSocket_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnClosing_Lokhttp3_WebSocket_ILjava_lang_String_Handler ()
		{
			if (cb_onClosing_Lokhttp3_WebSocket_ILjava_lang_String_ == null)
				cb_onClosing_Lokhttp3_WebSocket_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnClosing_Lokhttp3_WebSocket_ILjava_lang_String_);
			return cb_onClosing_Lokhttp3_WebSocket_ILjava_lang_String_;
		}

		static void n_OnClosing_Lokhttp3_WebSocket_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_webSocket, int code, IntPtr native_reason)
		{
			global::Okhttp3.WebSocketListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.WebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.IWebSocket webSocket = (global::Okhttp3.IWebSocket)global::Java.Lang.Object.GetObject<global::Okhttp3.IWebSocket> (native_webSocket, JniHandleOwnership.DoNotTransfer);
			string reason = JNIEnv.GetString (native_reason, JniHandleOwnership.DoNotTransfer);
			__this.OnClosing (webSocket, code, reason);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='WebSocketListener']/method[@name='onClosing' and count(parameter)=3 and parameter[1][@type='okhttp3.WebSocket'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onClosing", "(Lokhttp3/WebSocket;ILjava/lang/String;)V", "GetOnClosing_Lokhttp3_WebSocket_ILjava_lang_String_Handler")]
		public virtual unsafe void OnClosing (global::Okhttp3.IWebSocket webSocket, int code, string reason)
		{
			const string __id = "onClosing.(Lokhttp3/WebSocket;ILjava/lang/String;)V";
			IntPtr native_reason = JNIEnv.NewString (reason);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((webSocket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) webSocket).Handle);
				__args [1] = new JniArgumentValue (code);
				__args [2] = new JniArgumentValue (native_reason);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_reason);
			}
		}

		static Delegate cb_onFailure_Lokhttp3_WebSocket_Ljava_lang_Throwable_Lokhttp3_Response_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Lokhttp3_WebSocket_Ljava_lang_Throwable_Lokhttp3_Response_Handler ()
		{
			if (cb_onFailure_Lokhttp3_WebSocket_Ljava_lang_Throwable_Lokhttp3_Response_ == null)
				cb_onFailure_Lokhttp3_WebSocket_Ljava_lang_Throwable_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailure_Lokhttp3_WebSocket_Ljava_lang_Throwable_Lokhttp3_Response_);
			return cb_onFailure_Lokhttp3_WebSocket_Ljava_lang_Throwable_Lokhttp3_Response_;
		}

		static void n_OnFailure_Lokhttp3_WebSocket_Ljava_lang_Throwable_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_webSocket, IntPtr native_t, IntPtr native_response)
		{
			global::Okhttp3.WebSocketListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.WebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.IWebSocket webSocket = (global::Okhttp3.IWebSocket)global::Java.Lang.Object.GetObject<global::Okhttp3.IWebSocket> (native_webSocket, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Response response = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (native_response, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (webSocket, t, response);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='WebSocketListener']/method[@name='onFailure' and count(parameter)=3 and parameter[1][@type='okhttp3.WebSocket'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='okhttp3.Response']]"
		[Register ("onFailure", "(Lokhttp3/WebSocket;Ljava/lang/Throwable;Lokhttp3/Response;)V", "GetOnFailure_Lokhttp3_WebSocket_Ljava_lang_Throwable_Lokhttp3_Response_Handler")]
		public virtual unsafe void OnFailure (global::Okhttp3.IWebSocket webSocket, global::Java.Lang.Throwable t, global::Okhttp3.Response response)
		{
			const string __id = "onFailure.(Lokhttp3/WebSocket;Ljava/lang/Throwable;Lokhttp3/Response;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((webSocket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) webSocket).Handle);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				__args [2] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onMessage_Lokhttp3_WebSocket_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnMessage_Lokhttp3_WebSocket_Ljava_lang_String_Handler ()
		{
			if (cb_onMessage_Lokhttp3_WebSocket_Ljava_lang_String_ == null)
				cb_onMessage_Lokhttp3_WebSocket_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMessage_Lokhttp3_WebSocket_Ljava_lang_String_);
			return cb_onMessage_Lokhttp3_WebSocket_Ljava_lang_String_;
		}

		static void n_OnMessage_Lokhttp3_WebSocket_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_webSocket, IntPtr native_text)
		{
			global::Okhttp3.WebSocketListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.WebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.IWebSocket webSocket = (global::Okhttp3.IWebSocket)global::Java.Lang.Object.GetObject<global::Okhttp3.IWebSocket> (native_webSocket, JniHandleOwnership.DoNotTransfer);
			string text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			__this.OnMessage (webSocket, text);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='WebSocketListener']/method[@name='onMessage' and count(parameter)=2 and parameter[1][@type='okhttp3.WebSocket'] and parameter[2][@type='java.lang.String']]"
		[Register ("onMessage", "(Lokhttp3/WebSocket;Ljava/lang/String;)V", "GetOnMessage_Lokhttp3_WebSocket_Ljava_lang_String_Handler")]
		public virtual unsafe void OnMessage (global::Okhttp3.IWebSocket webSocket, string text)
		{
			const string __id = "onMessage.(Lokhttp3/WebSocket;Ljava/lang/String;)V";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((webSocket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) webSocket).Handle);
				__args [1] = new JniArgumentValue (native_text);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_onOpen_Lokhttp3_WebSocket_Lokhttp3_Response_;
#pragma warning disable 0169
		static Delegate GetOnOpen_Lokhttp3_WebSocket_Lokhttp3_Response_Handler ()
		{
			if (cb_onOpen_Lokhttp3_WebSocket_Lokhttp3_Response_ == null)
				cb_onOpen_Lokhttp3_WebSocket_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnOpen_Lokhttp3_WebSocket_Lokhttp3_Response_);
			return cb_onOpen_Lokhttp3_WebSocket_Lokhttp3_Response_;
		}

		static void n_OnOpen_Lokhttp3_WebSocket_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_webSocket, IntPtr native_response)
		{
			global::Okhttp3.WebSocketListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.WebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.IWebSocket webSocket = (global::Okhttp3.IWebSocket)global::Java.Lang.Object.GetObject<global::Okhttp3.IWebSocket> (native_webSocket, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Response response = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (native_response, JniHandleOwnership.DoNotTransfer);
			__this.OnOpen (webSocket, response);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='WebSocketListener']/method[@name='onOpen' and count(parameter)=2 and parameter[1][@type='okhttp3.WebSocket'] and parameter[2][@type='okhttp3.Response']]"
		[Register ("onOpen", "(Lokhttp3/WebSocket;Lokhttp3/Response;)V", "GetOnOpen_Lokhttp3_WebSocket_Lokhttp3_Response_Handler")]
		public virtual unsafe void OnOpen (global::Okhttp3.IWebSocket webSocket, global::Okhttp3.Response response)
		{
			const string __id = "onOpen.(Lokhttp3/WebSocket;Lokhttp3/Response;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((webSocket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) webSocket).Handle);
				__args [1] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("okhttp3/WebSocketListener", DoNotGenerateAcw=true)]
	internal partial class WebSocketListenerInvoker : WebSocketListener {

		public WebSocketListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/WebSocketListener", typeof (WebSocketListenerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
