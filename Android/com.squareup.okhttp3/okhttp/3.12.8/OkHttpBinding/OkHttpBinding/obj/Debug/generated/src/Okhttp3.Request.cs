using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Request']"
	[global::Android.Runtime.Register ("okhttp3/Request", DoNotGenerateAcw=true)]
	public sealed partial class Request : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']"
		[global::Android.Runtime.Register ("okhttp3/Request$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Request$Builder", typeof (Builder));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/constructor[@name='Request.Builder' and count(parameter)=0]"
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
				global::Okhttp3.Request.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddHeader (name, value));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Request$Builder;", "GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder AddHeader (string name, string value)
			{
				const string __id = "addHeader.(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Request$Builder;";
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_value);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
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
				global::Okhttp3.Request.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/Request;", "GetBuildHandler")]
			public virtual unsafe global::Okhttp3.Request Build ()
			{
				const string __id = "build.()Lokhttp3/Request;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_cacheControl_Lokhttp3_CacheControl_;
#pragma warning disable 0169
			static Delegate GetCacheControl_Lokhttp3_CacheControl_Handler ()
			{
				if (cb_cacheControl_Lokhttp3_CacheControl_ == null)
					cb_cacheControl_Lokhttp3_CacheControl_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CacheControl_Lokhttp3_CacheControl_);
				return cb_cacheControl_Lokhttp3_CacheControl_;
			}

			static IntPtr n_CacheControl_Lokhttp3_CacheControl_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cacheControl)
			{
				global::Okhttp3.Request.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.CacheControl cacheControl = global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl> (native_cacheControl, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CacheControl (cacheControl));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='cacheControl' and count(parameter)=1 and parameter[1][@type='okhttp3.CacheControl']]"
			[Register ("cacheControl", "(Lokhttp3/CacheControl;)Lokhttp3/Request$Builder;", "GetCacheControl_Lokhttp3_CacheControl_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder CacheControl (global::Okhttp3.CacheControl cacheControl)
			{
				const string __id = "cacheControl.(Lokhttp3/CacheControl;)Lokhttp3/Request$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((cacheControl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cacheControl).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_delete;
#pragma warning disable 0169
			static Delegate GetDeleteHandler ()
			{
				if (cb_delete == null)
					cb_delete = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Delete);
				return cb_delete;
			}

			static IntPtr n_Delete (IntPtr jnienv, IntPtr native__this)
			{
				global::Okhttp3.Request.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Delete ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='delete' and count(parameter)=0]"
			[Register ("delete", "()Lokhttp3/Request$Builder;", "GetDeleteHandler")]
			public virtual unsafe global::Okhttp3.Request.Builder Delete ()
			{
				const string __id = "delete.()Lokhttp3/Request$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_delete_Lokhttp3_RequestBody_;
#pragma warning disable 0169
			static Delegate GetDelete_Lokhttp3_RequestBody_Handler ()
			{
				if (cb_delete_Lokhttp3_RequestBody_ == null)
					cb_delete_Lokhttp3_RequestBody_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Delete_Lokhttp3_RequestBody_);
				return cb_delete_Lokhttp3_RequestBody_;
			}

			static IntPtr n_Delete_Lokhttp3_RequestBody_ (IntPtr jnienv, IntPtr native__this, IntPtr native_body)
			{
				global::Okhttp3.Request.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.RequestBody body = global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (native_body, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Delete (body));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='okhttp3.RequestBody']]"
			[Register ("delete", "(Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;", "GetDelete_Lokhttp3_RequestBody_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Delete (global::Okhttp3.RequestBody body)
			{
				const string __id = "delete.(Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((body == null) ? IntPtr.Zero : ((global::Java.Lang.Object) body).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_get;
#pragma warning disable 0169
			static Delegate GetGetHandler ()
			{
				if (cb_get == null)
					cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get);
				return cb_get;
			}

			static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
			{
				global::Okhttp3.Request.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Get ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='get' and count(parameter)=0]"
			[Register ("get", "()Lokhttp3/Request$Builder;", "GetGetHandler")]
			public virtual unsafe global::Okhttp3.Request.Builder Get ()
			{
				const string __id = "get.()Lokhttp3/Request$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_head;
#pragma warning disable 0169
			static Delegate GetHeadHandler ()
			{
				if (cb_head == null)
					cb_head = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Head);
				return cb_head;
			}

			static IntPtr n_Head (IntPtr jnienv, IntPtr native__this)
			{
				global::Okhttp3.Request.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Head ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='head' and count(parameter)=0]"
			[Register ("head", "()Lokhttp3/Request$Builder;", "GetHeadHandler")]
			public virtual unsafe global::Okhttp3.Request.Builder Head ()
			{
				const string __id = "head.()Lokhttp3/Request$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				global::Okhttp3.Request.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Header (name, value));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='header' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("header", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Request$Builder;", "GetHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Header (string name, string value)
			{
				const string __id = "header.(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Request$Builder;";
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_value);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				global::Okhttp3.Request.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Headers headers = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (native_headers, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Headers (headers));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='headers' and count(parameter)=1 and parameter[1][@type='okhttp3.Headers']]"
			[Register ("headers", "(Lokhttp3/Headers;)Lokhttp3/Request$Builder;", "GetHeaders_Lokhttp3_Headers_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Headers (global::Okhttp3.Headers headers)
			{
				const string __id = "headers.(Lokhttp3/Headers;)Lokhttp3/Request$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((headers == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headers).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_method_Ljava_lang_String_Lokhttp3_RequestBody_;
#pragma warning disable 0169
			static Delegate GetMethod_Ljava_lang_String_Lokhttp3_RequestBody_Handler ()
			{
				if (cb_method_Ljava_lang_String_Lokhttp3_RequestBody_ == null)
					cb_method_Ljava_lang_String_Lokhttp3_RequestBody_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Method_Ljava_lang_String_Lokhttp3_RequestBody_);
				return cb_method_Ljava_lang_String_Lokhttp3_RequestBody_;
			}

			static IntPtr n_Method_Ljava_lang_String_Lokhttp3_RequestBody_ (IntPtr jnienv, IntPtr native__this, IntPtr native_method, IntPtr native_body)
			{
				global::Okhttp3.Request.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string method = JNIEnv.GetString (native_method, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.RequestBody body = global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (native_body, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Method (method, body));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='method' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='okhttp3.RequestBody']]"
			[Register ("method", "(Ljava/lang/String;Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;", "GetMethod_Ljava_lang_String_Lokhttp3_RequestBody_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Method (string method, global::Okhttp3.RequestBody body)
			{
				const string __id = "method.(Ljava/lang/String;Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;";
				IntPtr native_method = JNIEnv.NewString (method);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_method);
					__args [1] = new JniArgumentValue ((body == null) ? IntPtr.Zero : ((global::Java.Lang.Object) body).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_method);
				}
			}

			static Delegate cb_patch_Lokhttp3_RequestBody_;
#pragma warning disable 0169
			static Delegate GetPatch_Lokhttp3_RequestBody_Handler ()
			{
				if (cb_patch_Lokhttp3_RequestBody_ == null)
					cb_patch_Lokhttp3_RequestBody_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Patch_Lokhttp3_RequestBody_);
				return cb_patch_Lokhttp3_RequestBody_;
			}

			static IntPtr n_Patch_Lokhttp3_RequestBody_ (IntPtr jnienv, IntPtr native__this, IntPtr native_body)
			{
				global::Okhttp3.Request.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.RequestBody body = global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (native_body, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Patch (body));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='patch' and count(parameter)=1 and parameter[1][@type='okhttp3.RequestBody']]"
			[Register ("patch", "(Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;", "GetPatch_Lokhttp3_RequestBody_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Patch (global::Okhttp3.RequestBody body)
			{
				const string __id = "patch.(Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((body == null) ? IntPtr.Zero : ((global::Java.Lang.Object) body).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_post_Lokhttp3_RequestBody_;
#pragma warning disable 0169
			static Delegate GetPost_Lokhttp3_RequestBody_Handler ()
			{
				if (cb_post_Lokhttp3_RequestBody_ == null)
					cb_post_Lokhttp3_RequestBody_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Post_Lokhttp3_RequestBody_);
				return cb_post_Lokhttp3_RequestBody_;
			}

			static IntPtr n_Post_Lokhttp3_RequestBody_ (IntPtr jnienv, IntPtr native__this, IntPtr native_body)
			{
				global::Okhttp3.Request.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.RequestBody body = global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (native_body, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Post (body));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='post' and count(parameter)=1 and parameter[1][@type='okhttp3.RequestBody']]"
			[Register ("post", "(Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;", "GetPost_Lokhttp3_RequestBody_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Post (global::Okhttp3.RequestBody body)
			{
				const string __id = "post.(Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((body == null) ? IntPtr.Zero : ((global::Java.Lang.Object) body).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_put_Lokhttp3_RequestBody_;
#pragma warning disable 0169
			static Delegate GetPut_Lokhttp3_RequestBody_Handler ()
			{
				if (cb_put_Lokhttp3_RequestBody_ == null)
					cb_put_Lokhttp3_RequestBody_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Lokhttp3_RequestBody_);
				return cb_put_Lokhttp3_RequestBody_;
			}

			static IntPtr n_Put_Lokhttp3_RequestBody_ (IntPtr jnienv, IntPtr native__this, IntPtr native_body)
			{
				global::Okhttp3.Request.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.RequestBody body = global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (native_body, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (body));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='put' and count(parameter)=1 and parameter[1][@type='okhttp3.RequestBody']]"
			[Register ("put", "(Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;", "GetPut_Lokhttp3_RequestBody_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Put (global::Okhttp3.RequestBody body)
			{
				const string __id = "put.(Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((body == null) ? IntPtr.Zero : ((global::Java.Lang.Object) body).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				global::Okhttp3.Request.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveHeader (name));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='removeHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("removeHeader", "(Ljava/lang/String;)Lokhttp3/Request$Builder;", "GetRemoveHeader_Ljava_lang_String_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder RemoveHeader (string name)
			{
				const string __id = "removeHeader.(Ljava/lang/String;)Lokhttp3/Request$Builder;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static Delegate cb_tag_Ljava_lang_Class_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetTag_Ljava_lang_Class_Ljava_lang_Object_Handler ()
			{
				if (cb_tag_Ljava_lang_Class_Ljava_lang_Object_ == null)
					cb_tag_Ljava_lang_Class_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Tag_Ljava_lang_Class_Ljava_lang_Object_);
				return cb_tag_Ljava_lang_Class_Ljava_lang_Object_;
			}

			static IntPtr n_Tag_Ljava_lang_Class_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type, IntPtr native_tag)
			{
				global::Okhttp3.Request.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Class type = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_type, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object tag = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_tag, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Tag (type, tag));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='tag' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;? super T&gt;'] and parameter[2][@type='T']]"
			[Register ("tag", "(Ljava/lang/Class;Ljava/lang/Object;)Lokhttp3/Request$Builder;", "GetTag_Ljava_lang_Class_Ljava_lang_Object_Handler")]
			[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
			public virtual unsafe global::Okhttp3.Request.Builder Tag (global::Java.Lang.Class type, global::Java.Lang.Object tag)
			{
				const string __id = "tag.(Ljava/lang/Class;Ljava/lang/Object;)Lokhttp3/Request$Builder;";
				IntPtr native_tag = JNIEnv.ToLocalJniHandle (tag);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					__args [1] = new JniArgumentValue (native_tag);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_tag);
				}
			}

			static Delegate cb_tag_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetTag_Ljava_lang_Object_Handler ()
			{
				if (cb_tag_Ljava_lang_Object_ == null)
					cb_tag_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Tag_Ljava_lang_Object_);
				return cb_tag_Ljava_lang_Object_;
			}

			static IntPtr n_Tag_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tag)
			{
				global::Okhttp3.Request.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object tag = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_tag, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Tag (tag));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='tag' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("tag", "(Ljava/lang/Object;)Lokhttp3/Request$Builder;", "GetTag_Ljava_lang_Object_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Tag (global::Java.Lang.Object tag)
			{
				const string __id = "tag.(Ljava/lang/Object;)Lokhttp3/Request$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_url_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetUrl_Ljava_lang_String_Handler ()
			{
				if (cb_url_Ljava_lang_String_ == null)
					cb_url_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Url_Ljava_lang_String_);
				return cb_url_Ljava_lang_String_;
			}

			static IntPtr n_Url_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
			{
				global::Okhttp3.Request.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Url (url));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='url' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("url", "(Ljava/lang/String;)Lokhttp3/Request$Builder;", "GetUrl_Ljava_lang_String_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Url (string url)
			{
				const string __id = "url.(Ljava/lang/String;)Lokhttp3/Request$Builder;";
				IntPtr native_url = JNIEnv.NewString (url);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_url);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_url);
				}
			}

			static Delegate cb_url_Ljava_net_URL_;
#pragma warning disable 0169
			static Delegate GetUrl_Ljava_net_URL_Handler ()
			{
				if (cb_url_Ljava_net_URL_ == null)
					cb_url_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Url_Ljava_net_URL_);
				return cb_url_Ljava_net_URL_;
			}

			static IntPtr n_Url_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
			{
				global::Okhttp3.Request.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Net.URL url = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_url, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Url (url));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='url' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
			[Register ("url", "(Ljava/net/URL;)Lokhttp3/Request$Builder;", "GetUrl_Ljava_net_URL_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Url (global::Java.Net.URL url)
			{
				const string __id = "url.(Ljava/net/URL;)Lokhttp3/Request$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_url_Lokhttp3_HttpUrl_;
#pragma warning disable 0169
			static Delegate GetUrl_Lokhttp3_HttpUrl_Handler ()
			{
				if (cb_url_Lokhttp3_HttpUrl_ == null)
					cb_url_Lokhttp3_HttpUrl_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Url_Lokhttp3_HttpUrl_);
				return cb_url_Lokhttp3_HttpUrl_;
			}

			static IntPtr n_Url_Lokhttp3_HttpUrl_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
			{
				global::Okhttp3.Request.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.HttpUrl url = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl> (native_url, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Url (url));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request.Builder']/method[@name='url' and count(parameter)=1 and parameter[1][@type='okhttp3.HttpUrl']]"
			[Register ("url", "(Lokhttp3/HttpUrl;)Lokhttp3/Request$Builder;", "GetUrl_Lokhttp3_HttpUrl_Handler")]
			public virtual unsafe global::Okhttp3.Request.Builder Url (global::Okhttp3.HttpUrl url)
			{
				const string __id = "url.(Lokhttp3/HttpUrl;)Lokhttp3/Request$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Request", typeof (Request));
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

		internal Request (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe bool IsHttps {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='isHttps' and count(parameter)=0]"
			[Register ("isHttps", "()Z", "")]
			get {
				const string __id = "isHttps.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='body' and count(parameter)=0]"
		[Register ("body", "()Lokhttp3/RequestBody;", "")]
		public unsafe global::Okhttp3.RequestBody Body ()
		{
			const string __id = "body.()Lokhttp3/RequestBody;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='cacheControl' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='header' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='headers' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='headers' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='method' and count(parameter)=0]"
		[Register ("method", "()Ljava/lang/String;", "")]
		public unsafe string Method ()
		{
			const string __id = "method.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='newBuilder' and count(parameter)=0]"
		[Register ("newBuilder", "()Lokhttp3/Request$Builder;", "")]
		public unsafe global::Okhttp3.Request.Builder NewBuilder ()
		{
			const string __id = "newBuilder.()Lokhttp3/Request$Builder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='tag' and count(parameter)=0]"
		[Register ("tag", "()Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Tag ()
		{
			const string __id = "tag.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='tag' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends T&gt;']]"
		[Register ("tag", "(Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object Tag (global::Java.Lang.Class type)
		{
			const string __id = "tag.(Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Request']/method[@name='url' and count(parameter)=0]"
		[Register ("url", "()Lokhttp3/HttpUrl;", "")]
		public unsafe global::Okhttp3.HttpUrl Url ()
		{
			const string __id = "url.()Lokhttp3/HttpUrl;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
