using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='HttpMessage']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/HttpMessage", DoNotGenerateAcw=true)]
	public abstract partial class HttpMessage : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/HttpMessage", typeof (HttpMessage));
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

		protected HttpMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getContent;
#pragma warning disable 0169
		static Delegate GetGetContentHandler ()
		{
			if (cb_getContent == null)
				cb_getContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContent);
			return cb_getContent;
		}

		static IntPtr n_GetContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Content);
		}
#pragma warning restore 0169

		static Delegate cb_setContent_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetSetContent_Ljava_io_InputStream_Handler ()
		{
			if (cb_setContent_Ljava_io_InputStream_ == null)
				cb_setContent_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContent_Ljava_io_InputStream_);
			return cb_setContent_Ljava_io_InputStream_;
		}

		static void n_SetContent_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_content)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream content = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_content, JniHandleOwnership.DoNotTransfer);
			__this.Content = content;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.IO.Stream Content {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='HttpMessage']/method[@name='getContent' and count(parameter)=0]"
			[Register ("getContent", "()Ljava/io/InputStream;", "GetGetContentHandler")]
			get {
				const string __id = "getContent.()Ljava/io/InputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='HttpMessage']/method[@name='setContent' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register ("setContent", "(Ljava/io/InputStream;)V", "GetSetContent_Ljava_io_InputStream_Handler")]
			set {
				const string __id = "setContent.(Ljava/io/InputStream;)V";
				IntPtr native_value = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getContentLength;
#pragma warning disable 0169
		static Delegate GetGetContentLengthHandler ()
		{
			if (cb_getContentLength == null)
				cb_getContentLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetContentLength);
			return cb_getContentLength;
		}

		static long n_GetContentLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentLength;
		}
#pragma warning restore 0169

		static Delegate cb_setContentLength_J;
#pragma warning disable 0169
		static Delegate GetSetContentLength_JHandler ()
		{
			if (cb_setContentLength_J == null)
				cb_setContentLength_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetContentLength_J);
			return cb_setContentLength_J;
		}

		static void n_SetContentLength_J (IntPtr jnienv, IntPtr native__this, long contentLength)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ContentLength = contentLength;
		}
#pragma warning restore 0169

		public virtual unsafe long ContentLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='HttpMessage']/method[@name='getContentLength' and count(parameter)=0]"
			[Register ("getContentLength", "()J", "GetGetContentLengthHandler")]
			get {
				const string __id = "getContentLength.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='HttpMessage']/method[@name='setContentLength' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setContentLength", "(J)V", "GetSetContentLength_JHandler")]
			set {
				const string __id = "setContentLength.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStringBody;
#pragma warning disable 0169
		static Delegate GetGetStringBodyHandler ()
		{
			if (cb_getStringBody == null)
				cb_getStringBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStringBody);
			return cb_getStringBody;
		}

		static IntPtr n_GetStringBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StringBody);
		}
#pragma warning restore 0169

		static Delegate cb_setStringBody_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStringBody_Ljava_lang_String_Handler ()
		{
			if (cb_setStringBody_Ljava_lang_String_ == null)
				cb_setStringBody_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStringBody_Ljava_lang_String_);
			return cb_setStringBody_Ljava_lang_String_;
		}

		static void n_SetStringBody_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_stringBody)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string stringBody = JNIEnv.GetString (native_stringBody, JniHandleOwnership.DoNotTransfer);
			__this.StringBody = stringBody;
		}
#pragma warning restore 0169

		public virtual unsafe string StringBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='HttpMessage']/method[@name='getStringBody' and count(parameter)=0]"
			[Register ("getStringBody", "()Ljava/lang/String;", "GetGetStringBodyHandler")]
			get {
				const string __id = "getStringBody.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='HttpMessage']/method[@name='setStringBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStringBody", "(Ljava/lang/String;)V", "GetSetStringBody_Ljava_lang_String_Handler")]
			set {
				const string __id = "setStringBody.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addHeader_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddHeader_Ljava_lang_String_Ljava_lang_String_);
			return cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AddHeader (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='HttpMessage']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddHeader (string key, string value)
		{
			const string __id = "addHeader.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='HttpMessage']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getHeaders;
#pragma warning disable 0169
		static Delegate GetGetHeadersHandler ()
		{
			if (cb_getHeaders == null)
				cb_getHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaders);
			return cb_getHeaders;
		}

		static IntPtr n_GetHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.GetHeaders ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='HttpMessage']/method[@name='getHeaders' and count(parameter)=0]"
		[Register ("getHeaders", "()Ljava/util/Map;", "GetGetHeadersHandler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> GetHeaders ()
		{
			const string __id = "getHeaders.()Ljava/util/Map;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setHeaders_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetHeaders_Ljava_util_Map_Handler ()
		{
			if (cb_setHeaders_Ljava_util_Map_ == null)
				cb_setHeaders_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeaders_Ljava_util_Map_);
			return cb_setHeaders_Ljava_util_Map_;
		}

		static void n_SetHeaders_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_headers)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.HttpMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			__this.SetHeaders (headers);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='HttpMessage']/method[@name='setHeaders' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setHeaders", "(Ljava/util/Map;)V", "GetSetHeaders_Ljava_util_Map_Handler")]
		public virtual unsafe void SetHeaders (global::System.Collections.Generic.IDictionary<string, string> headers)
		{
			const string __id = "setHeaders.(Ljava/util/Map;)V";
			IntPtr native_headers = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_headers);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

	}

	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/HttpMessage", DoNotGenerateAcw=true)]
	internal partial class HttpMessageInvoker : HttpMessage {

		public HttpMessageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/HttpMessage", typeof (HttpMessageInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
