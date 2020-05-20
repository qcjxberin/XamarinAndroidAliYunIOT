using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Response']"
	[global::Android.Runtime.Register ("okhttp3/Response", DoNotGenerateAcw=true)]
	public sealed partial class Response : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']"
		[global::Android.Runtime.Register ("okhttp3/Response$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Response$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/constructor[@name='Response.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			static Delegate cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_addHeader_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddHeader_Ljava_lang_String_Ljava_lang_String_);
				return cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_AddHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_value)
			{
				global::Okhttp3.Response.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddHeader (name, value));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Response$Builder;", "GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder AddHeader (string name, string value)
			{
				const string __id = "addHeader.(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Response$Builder;";
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_value);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static Delegate cb_body_Lokhttp3_ResponseBody_;
#pragma warning disable 0169
			static Delegate GetBody_Lokhttp3_ResponseBody_Handler ()
			{
				if (cb_body_Lokhttp3_ResponseBody_ == null)
					cb_body_Lokhttp3_ResponseBody_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Body_Lokhttp3_ResponseBody_);
				return cb_body_Lokhttp3_ResponseBody_;
			}

			static IntPtr n_Body_Lokhttp3_ResponseBody_ (IntPtr jnienv, IntPtr native__this, IntPtr native_body)
			{
				global::Okhttp3.Response.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.ResponseBody body = global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (native_body, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Body (body));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='body' and count(parameter)=1 and parameter[1][@type='okhttp3.ResponseBody']]"
			[Register ("body", "(Lokhttp3/ResponseBody;)Lokhttp3/Response$Builder;", "GetBody_Lokhttp3_ResponseBody_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder Body (global::Okhttp3.ResponseBody body)
			{
				const string __id = "body.(Lokhttp3/ResponseBody;)Lokhttp3/Response$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((body == null) ? IntPtr.Zero : ((global::Java.Lang.Object) body).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Okhttp3.Response.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/Response;", "GetBuildHandler")]
			public virtual unsafe global::Okhttp3.Response Build ()
			{
				const string __id = "build.()Lokhttp3/Response;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_cacheResponse_Lokhttp3_Response_;
#pragma warning disable 0169
			static Delegate GetCacheResponse_Lokhttp3_Response_Handler ()
			{
				if (cb_cacheResponse_Lokhttp3_Response_ == null)
					cb_cacheResponse_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CacheResponse_Lokhttp3_Response_);
				return cb_cacheResponse_Lokhttp3_Response_;
			}

			static IntPtr n_CacheResponse_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cacheResponse)
			{
				global::Okhttp3.Response.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Response cacheResponse = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (native_cacheResponse, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CacheResponse (cacheResponse));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='cacheResponse' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
			[Register ("cacheResponse", "(Lokhttp3/Response;)Lokhttp3/Response$Builder;", "GetCacheResponse_Lokhttp3_Response_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder CacheResponse (global::Okhttp3.Response cacheResponse)
			{
				const string __id = "cacheResponse.(Lokhttp3/Response;)Lokhttp3/Response$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((cacheResponse == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cacheResponse).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_code_I;
#pragma warning disable 0169
			static Delegate GetCode_IHandler ()
			{
				if (cb_code_I == null)
					cb_code_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Code_I);
				return cb_code_I;
			}

			static IntPtr n_Code_I (IntPtr jnienv, IntPtr native__this, int code)
			{
				global::Okhttp3.Response.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Code (code));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='code' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("code", "(I)Lokhttp3/Response$Builder;", "GetCode_IHandler")]
			public virtual unsafe global::Okhttp3.Response.Builder Code (int code)
			{
				const string __id = "code.(I)Lokhttp3/Response$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (code);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_handshake_Lokhttp3_Handshake_;
#pragma warning disable 0169
			static Delegate GetHandshake_Lokhttp3_Handshake_Handler ()
			{
				if (cb_handshake_Lokhttp3_Handshake_ == null)
					cb_handshake_Lokhttp3_Handshake_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Handshake_Lokhttp3_Handshake_);
				return cb_handshake_Lokhttp3_Handshake_;
			}

			static IntPtr n_Handshake_Lokhttp3_Handshake_ (IntPtr jnienv, IntPtr native__this, IntPtr native_handshake)
			{
				global::Okhttp3.Response.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Handshake handshake = global::Java.Lang.Object.GetObject<global::Okhttp3.Handshake> (native_handshake, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Handshake (handshake));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='handshake' and count(parameter)=1 and parameter[1][@type='okhttp3.Handshake']]"
			[Register ("handshake", "(Lokhttp3/Handshake;)Lokhttp3/Response$Builder;", "GetHandshake_Lokhttp3_Handshake_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder Handshake (global::Okhttp3.Handshake handshake)
			{
				const string __id = "handshake.(Lokhttp3/Handshake;)Lokhttp3/Response$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((handshake == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handshake).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_header_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_header_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_header_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Header_Ljava_lang_String_Ljava_lang_String_);
				return cb_header_Ljava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_Header_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_value)
			{
				global::Okhttp3.Response.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Header (name, value));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='header' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("header", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Response$Builder;", "GetHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder Header (string name, string value)
			{
				const string __id = "header.(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Response$Builder;";
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_value);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static Delegate cb_headers_Lokhttp3_Headers_;
#pragma warning disable 0169
			static Delegate GetHeaders_Lokhttp3_Headers_Handler ()
			{
				if (cb_headers_Lokhttp3_Headers_ == null)
					cb_headers_Lokhttp3_Headers_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Headers_Lokhttp3_Headers_);
				return cb_headers_Lokhttp3_Headers_;
			}

			static IntPtr n_Headers_Lokhttp3_Headers_ (IntPtr jnienv, IntPtr native__this, IntPtr native_headers)
			{
				global::Okhttp3.Response.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Headers headers = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (native_headers, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Headers (headers));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='headers' and count(parameter)=1 and parameter[1][@type='okhttp3.Headers']]"
			[Register ("headers", "(Lokhttp3/Headers;)Lokhttp3/Response$Builder;", "GetHeaders_Lokhttp3_Headers_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder Headers (global::Okhttp3.Headers headers)
			{
				const string __id = "headers.(Lokhttp3/Headers;)Lokhttp3/Response$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((headers == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headers).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_message_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetMessage_Ljava_lang_String_Handler ()
			{
				if (cb_message_Ljava_lang_String_ == null)
					cb_message_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Message_Ljava_lang_String_);
				return cb_message_Ljava_lang_String_;
			}

			static IntPtr n_Message_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
			{
				global::Okhttp3.Response.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Message (message));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='message' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("message", "(Ljava/lang/String;)Lokhttp3/Response$Builder;", "GetMessage_Ljava_lang_String_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder Message (string message)
			{
				const string __id = "message.(Ljava/lang/String;)Lokhttp3/Response$Builder;";
				IntPtr native_message = JNIEnv.NewString (message);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_message);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_message);
				}
			}

			static Delegate cb_networkResponse_Lokhttp3_Response_;
#pragma warning disable 0169
			static Delegate GetNetworkResponse_Lokhttp3_Response_Handler ()
			{
				if (cb_networkResponse_Lokhttp3_Response_ == null)
					cb_networkResponse_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NetworkResponse_Lokhttp3_Response_);
				return cb_networkResponse_Lokhttp3_Response_;
			}

			static IntPtr n_NetworkResponse_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_networkResponse)
			{
				global::Okhttp3.Response.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Response networkResponse = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (native_networkResponse, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NetworkResponse (networkResponse));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='networkResponse' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
			[Register ("networkResponse", "(Lokhttp3/Response;)Lokhttp3/Response$Builder;", "GetNetworkResponse_Lokhttp3_Response_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder NetworkResponse (global::Okhttp3.Response networkResponse)
			{
				const string __id = "networkResponse.(Lokhttp3/Response;)Lokhttp3/Response$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((networkResponse == null) ? IntPtr.Zero : ((global::Java.Lang.Object) networkResponse).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_priorResponse_Lokhttp3_Response_;
#pragma warning disable 0169
			static Delegate GetPriorResponse_Lokhttp3_Response_Handler ()
			{
				if (cb_priorResponse_Lokhttp3_Response_ == null)
					cb_priorResponse_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PriorResponse_Lokhttp3_Response_);
				return cb_priorResponse_Lokhttp3_Response_;
			}

			static IntPtr n_PriorResponse_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_priorResponse)
			{
				global::Okhttp3.Response.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Response priorResponse = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (native_priorResponse, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PriorResponse (priorResponse));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='priorResponse' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
			[Register ("priorResponse", "(Lokhttp3/Response;)Lokhttp3/Response$Builder;", "GetPriorResponse_Lokhttp3_Response_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder PriorResponse (global::Okhttp3.Response priorResponse)
			{
				const string __id = "priorResponse.(Lokhttp3/Response;)Lokhttp3/Response$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((priorResponse == null) ? IntPtr.Zero : ((global::Java.Lang.Object) priorResponse).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_protocol_Lokhttp3_Protocol_;
#pragma warning disable 0169
			static Delegate GetProtocol_Lokhttp3_Protocol_Handler ()
			{
				if (cb_protocol_Lokhttp3_Protocol_ == null)
					cb_protocol_Lokhttp3_Protocol_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Protocol_Lokhttp3_Protocol_);
				return cb_protocol_Lokhttp3_Protocol_;
			}

			static IntPtr n_Protocol_Lokhttp3_Protocol_ (IntPtr jnienv, IntPtr native__this, IntPtr native_protocol)
			{
				global::Okhttp3.Response.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Protocol protocol = global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (native_protocol, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Protocol (protocol));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='protocol' and count(parameter)=1 and parameter[1][@type='okhttp3.Protocol']]"
			[Register ("protocol", "(Lokhttp3/Protocol;)Lokhttp3/Response$Builder;", "GetProtocol_Lokhttp3_Protocol_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder Protocol (global::Okhttp3.Protocol protocol)
			{
				const string __id = "protocol.(Lokhttp3/Protocol;)Lokhttp3/Response$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((protocol == null) ? IntPtr.Zero : ((global::Java.Lang.Object) protocol).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_removeHeader_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetRemoveHeader_Ljava_lang_String_Handler ()
			{
				if (cb_removeHeader_Ljava_lang_String_ == null)
					cb_removeHeader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveHeader_Ljava_lang_String_);
				return cb_removeHeader_Ljava_lang_String_;
			}

			static IntPtr n_RemoveHeader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
			{
				global::Okhttp3.Response.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveHeader (name));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='removeHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("removeHeader", "(Ljava/lang/String;)Lokhttp3/Response$Builder;", "GetRemoveHeader_Ljava_lang_String_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder RemoveHeader (string name)
			{
				const string __id = "removeHeader.(Ljava/lang/String;)Lokhttp3/Response$Builder;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static Delegate cb_request_Lokhttp3_Request_;
#pragma warning disable 0169
			static Delegate GetRequest_Lokhttp3_Request_Handler ()
			{
				if (cb_request_Lokhttp3_Request_ == null)
					cb_request_Lokhttp3_Request_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Request_Lokhttp3_Request_);
				return cb_request_Lokhttp3_Request_;
			}

			static IntPtr n_Request_Lokhttp3_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
			{
				global::Okhttp3.Response.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Request request = global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (native_request, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Request (request));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response.Builder']/method[@name='request' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
			[Register ("request", "(Lokhttp3/Request;)Lokhttp3/Response$Builder;", "GetRequest_Lokhttp3_Request_Handler")]
			public virtual unsafe global::Okhttp3.Response.Builder Request (global::Okhttp3.Request request)
			{
				const string __id = "request.(Lokhttp3/Request;)Lokhttp3/Response$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Response", typeof (Response));
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

		internal Response (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe bool IsRedirect {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='isRedirect' and count(parameter)=0]"
			[Register ("isRedirect", "()Z", "")]
			get {
				const string __id = "isRedirect.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsSuccessful {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='isSuccessful' and count(parameter)=0]"
			[Register ("isSuccessful", "()Z", "")]
			get {
				const string __id = "isSuccessful.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='body' and count(parameter)=0]"
		[Register ("body", "()Lokhttp3/ResponseBody;", "")]
		public unsafe global::Okhttp3.ResponseBody Body ()
		{
			const string __id = "body.()Lokhttp3/ResponseBody;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='cacheControl' and count(parameter)=0]"
		[Register ("cacheControl", "()Lokhttp3/CacheControl;", "")]
		public unsafe global::Okhttp3.CacheControl CacheControl ()
		{
			const string __id = "cacheControl.()Lokhttp3/CacheControl;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='cacheResponse' and count(parameter)=0]"
		[Register ("cacheResponse", "()Lokhttp3/Response;", "")]
		public unsafe global::Okhttp3.Response CacheResponse ()
		{
			const string __id = "cacheResponse.()Lokhttp3/Response;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='challenges' and count(parameter)=0]"
		[Register ("challenges", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.Challenge> Challenges ()
		{
			const string __id = "challenges.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Okhttp3.Challenge>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='code' and count(parameter)=0]"
		[Register ("code", "()I", "")]
		public unsafe int Code ()
		{
			const string __id = "code.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='handshake' and count(parameter)=0]"
		[Register ("handshake", "()Lokhttp3/Handshake;", "")]
		public unsafe global::Okhttp3.Handshake Handshake ()
		{
			const string __id = "handshake.()Lokhttp3/Handshake;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Handshake> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='header' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("header", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string Header (string name)
		{
			const string __id = "header.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='header' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("header", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string Header (string name, string defaultValue)
		{
			const string __id = "header.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_defaultValue = JNIEnv.NewString (defaultValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_defaultValue);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='headers' and count(parameter)=0]"
		[Register ("headers", "()Lokhttp3/Headers;", "")]
		public unsafe global::Okhttp3.Headers Headers ()
		{
			const string __id = "headers.()Lokhttp3/Headers;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='headers' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("headers", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<string> Headers (string name)
		{
			const string __id = "headers.(Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='message' and count(parameter)=0]"
		[Register ("message", "()Ljava/lang/String;", "")]
		public unsafe string Message ()
		{
			const string __id = "message.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='networkResponse' and count(parameter)=0]"
		[Register ("networkResponse", "()Lokhttp3/Response;", "")]
		public unsafe global::Okhttp3.Response NetworkResponse ()
		{
			const string __id = "networkResponse.()Lokhttp3/Response;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='newBuilder' and count(parameter)=0]"
		[Register ("newBuilder", "()Lokhttp3/Response$Builder;", "")]
		public unsafe global::Okhttp3.Response.Builder NewBuilder ()
		{
			const string __id = "newBuilder.()Lokhttp3/Response$Builder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='peekBody' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("peekBody", "(J)Lokhttp3/ResponseBody;", "")]
		public unsafe global::Okhttp3.ResponseBody PeekBody (long byteCount)
		{
			const string __id = "peekBody.(J)Lokhttp3/ResponseBody;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (byteCount);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='priorResponse' and count(parameter)=0]"
		[Register ("priorResponse", "()Lokhttp3/Response;", "")]
		public unsafe global::Okhttp3.Response PriorResponse ()
		{
			const string __id = "priorResponse.()Lokhttp3/Response;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='protocol' and count(parameter)=0]"
		[Register ("protocol", "()Lokhttp3/Protocol;", "")]
		public unsafe global::Okhttp3.Protocol Protocol ()
		{
			const string __id = "protocol.()Lokhttp3/Protocol;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Response']/method[@name='request' and count(parameter)=0]"
		[Register ("request", "()Lokhttp3/Request;", "")]
		public unsafe global::Okhttp3.Request Request ()
		{
			const string __id = "request.()Lokhttp3/Request;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
