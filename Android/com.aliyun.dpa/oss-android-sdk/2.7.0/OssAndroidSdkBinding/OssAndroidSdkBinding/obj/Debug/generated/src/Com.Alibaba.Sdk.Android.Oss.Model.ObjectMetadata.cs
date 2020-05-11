using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/ObjectMetadata", DoNotGenerateAcw=true)]
	public partial class ObjectMetadata : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/field[@name='AES_256_SERVER_SIDE_ENCRYPTION']"
		[Register ("AES_256_SERVER_SIDE_ENCRYPTION")]
		public const string Aes256ServerSideEncryption = (string) "AES256";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/ObjectMetadata", typeof (ObjectMetadata));
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

		protected ObjectMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/constructor[@name='ObjectMetadata' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ObjectMetadata ()
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

		static Delegate cb_getCacheControl;
#pragma warning disable 0169
		static Delegate GetGetCacheControlHandler ()
		{
			if (cb_getCacheControl == null)
				cb_getCacheControl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCacheControl);
			return cb_getCacheControl;
		}

		static IntPtr n_GetCacheControl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CacheControl);
		}
#pragma warning restore 0169

		static Delegate cb_setCacheControl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCacheControl_Ljava_lang_String_Handler ()
		{
			if (cb_setCacheControl_Ljava_lang_String_ == null)
				cb_setCacheControl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCacheControl_Ljava_lang_String_);
			return cb_setCacheControl_Ljava_lang_String_;
		}

		static void n_SetCacheControl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cacheControl)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string cacheControl = JNIEnv.GetString (native_cacheControl, JniHandleOwnership.DoNotTransfer);
			__this.CacheControl = cacheControl;
		}
#pragma warning restore 0169

		public virtual unsafe string CacheControl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='getCacheControl' and count(parameter)=0]"
			[Register ("getCacheControl", "()Ljava/lang/String;", "GetGetCacheControlHandler")]
			get {
				const string __id = "getCacheControl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='setCacheControl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCacheControl", "(Ljava/lang/String;)V", "GetSetCacheControl_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCacheControl.(Ljava/lang/String;)V";
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

		static Delegate cb_getContentDisposition;
#pragma warning disable 0169
		static Delegate GetGetContentDispositionHandler ()
		{
			if (cb_getContentDisposition == null)
				cb_getContentDisposition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentDisposition);
			return cb_getContentDisposition;
		}

		static IntPtr n_GetContentDisposition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentDisposition);
		}
#pragma warning restore 0169

		static Delegate cb_setContentDisposition_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentDisposition_Ljava_lang_String_Handler ()
		{
			if (cb_setContentDisposition_Ljava_lang_String_ == null)
				cb_setContentDisposition_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentDisposition_Ljava_lang_String_);
			return cb_setContentDisposition_Ljava_lang_String_;
		}

		static void n_SetContentDisposition_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_disposition)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string disposition = JNIEnv.GetString (native_disposition, JniHandleOwnership.DoNotTransfer);
			__this.ContentDisposition = disposition;
		}
#pragma warning restore 0169

		public virtual unsafe string ContentDisposition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='getContentDisposition' and count(parameter)=0]"
			[Register ("getContentDisposition", "()Ljava/lang/String;", "GetGetContentDispositionHandler")]
			get {
				const string __id = "getContentDisposition.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='setContentDisposition' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentDisposition", "(Ljava/lang/String;)V", "GetSetContentDisposition_Ljava_lang_String_Handler")]
			set {
				const string __id = "setContentDisposition.(Ljava/lang/String;)V";
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

		static Delegate cb_getContentEncoding;
#pragma warning disable 0169
		static Delegate GetGetContentEncodingHandler ()
		{
			if (cb_getContentEncoding == null)
				cb_getContentEncoding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentEncoding);
			return cb_getContentEncoding;
		}

		static IntPtr n_GetContentEncoding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentEncoding);
		}
#pragma warning restore 0169

		static Delegate cb_setContentEncoding_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentEncoding_Ljava_lang_String_Handler ()
		{
			if (cb_setContentEncoding_Ljava_lang_String_ == null)
				cb_setContentEncoding_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentEncoding_Ljava_lang_String_);
			return cb_setContentEncoding_Ljava_lang_String_;
		}

		static void n_SetContentEncoding_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_encoding)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string encoding = JNIEnv.GetString (native_encoding, JniHandleOwnership.DoNotTransfer);
			__this.ContentEncoding = encoding;
		}
#pragma warning restore 0169

		public virtual unsafe string ContentEncoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='getContentEncoding' and count(parameter)=0]"
			[Register ("getContentEncoding", "()Ljava/lang/String;", "GetGetContentEncodingHandler")]
			get {
				const string __id = "getContentEncoding.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='setContentEncoding' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentEncoding", "(Ljava/lang/String;)V", "GetSetContentEncoding_Ljava_lang_String_Handler")]
			set {
				const string __id = "setContentEncoding.(Ljava/lang/String;)V";
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ContentLength = contentLength;
		}
#pragma warning restore 0169

		public virtual unsafe long ContentLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='getContentLength' and count(parameter)=0]"
			[Register ("getContentLength", "()J", "GetGetContentLengthHandler")]
			get {
				const string __id = "getContentLength.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='setContentLength' and count(parameter)=1 and parameter[1][@type='long']]"
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

		static Delegate cb_getContentMD5;
#pragma warning disable 0169
		static Delegate GetGetContentMD5Handler ()
		{
			if (cb_getContentMD5 == null)
				cb_getContentMD5 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentMD5);
			return cb_getContentMD5;
		}

		static IntPtr n_GetContentMD5 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentMD5);
		}
#pragma warning restore 0169

		static Delegate cb_setContentMD5_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentMD5_Ljava_lang_String_Handler ()
		{
			if (cb_setContentMD5_Ljava_lang_String_ == null)
				cb_setContentMD5_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentMD5_Ljava_lang_String_);
			return cb_setContentMD5_Ljava_lang_String_;
		}

		static void n_SetContentMD5_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_contentMD5)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string contentMD5 = JNIEnv.GetString (native_contentMD5, JniHandleOwnership.DoNotTransfer);
			__this.ContentMD5 = contentMD5;
		}
#pragma warning restore 0169

		public virtual unsafe string ContentMD5 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='getContentMD5' and count(parameter)=0]"
			[Register ("getContentMD5", "()Ljava/lang/String;", "GetGetContentMD5Handler")]
			get {
				const string __id = "getContentMD5.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='setContentMD5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentMD5", "(Ljava/lang/String;)V", "GetSetContentMD5_Ljava_lang_String_Handler")]
			set {
				const string __id = "setContentMD5.(Ljava/lang/String;)V";
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

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		static Delegate cb_setContentType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentType_Ljava_lang_String_Handler ()
		{
			if (cb_setContentType_Ljava_lang_String_ == null)
				cb_setContentType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentType_Ljava_lang_String_);
			return cb_setContentType_Ljava_lang_String_;
		}

		static void n_SetContentType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_contentType)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string contentType = JNIEnv.GetString (native_contentType, JniHandleOwnership.DoNotTransfer);
			__this.ContentType = contentType;
		}
#pragma warning restore 0169

		public virtual unsafe string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler")]
			get {
				const string __id = "getContentType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='setContentType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentType", "(Ljava/lang/String;)V", "GetSetContentType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setContentType.(Ljava/lang/String;)V";
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

		static Delegate cb_getETag;
#pragma warning disable 0169
		static Delegate GetGetETagHandler ()
		{
			if (cb_getETag == null)
				cb_getETag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetETag);
			return cb_getETag;
		}

		static IntPtr n_GetETag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ETag);
		}
#pragma warning restore 0169

		public virtual unsafe string ETag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='getETag' and count(parameter)=0]"
			[Register ("getETag", "()Ljava/lang/String;", "GetGetETagHandler")]
			get {
				const string __id = "getETag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExpirationTime;
#pragma warning disable 0169
		static Delegate GetGetExpirationTimeHandler ()
		{
			if (cb_getExpirationTime == null)
				cb_getExpirationTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpirationTime);
			return cb_getExpirationTime;
		}

		static IntPtr n_GetExpirationTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExpirationTime);
		}
#pragma warning restore 0169

		static Delegate cb_setExpirationTime_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetExpirationTime_Ljava_util_Date_Handler ()
		{
			if (cb_setExpirationTime_Ljava_util_Date_ == null)
				cb_setExpirationTime_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExpirationTime_Ljava_util_Date_);
			return cb_setExpirationTime_Ljava_util_Date_;
		}

		static void n_SetExpirationTime_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_expirationTime)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date expirationTime = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_expirationTime, JniHandleOwnership.DoNotTransfer);
			__this.ExpirationTime = expirationTime;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Date ExpirationTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='getExpirationTime' and count(parameter)=0]"
			[Register ("getExpirationTime", "()Ljava/util/Date;", "GetGetExpirationTimeHandler")]
			get {
				const string __id = "getExpirationTime.()Ljava/util/Date;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='setExpirationTime' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setExpirationTime", "(Ljava/util/Date;)V", "GetSetExpirationTime_Ljava_util_Date_Handler")]
			set {
				const string __id = "setExpirationTime.(Ljava/util/Date;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLastModified;
#pragma warning disable 0169
		static Delegate GetGetLastModifiedHandler ()
		{
			if (cb_getLastModified == null)
				cb_getLastModified = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastModified);
			return cb_getLastModified;
		}

		static IntPtr n_GetLastModified (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastModified);
		}
#pragma warning restore 0169

		static Delegate cb_setLastModified_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetLastModified_Ljava_util_Date_Handler ()
		{
			if (cb_setLastModified_Ljava_util_Date_ == null)
				cb_setLastModified_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastModified_Ljava_util_Date_);
			return cb_setLastModified_Ljava_util_Date_;
		}

		static void n_SetLastModified_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lastModified)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date lastModified = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_lastModified, JniHandleOwnership.DoNotTransfer);
			__this.LastModified = lastModified;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Date LastModified {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='getLastModified' and count(parameter)=0]"
			[Register ("getLastModified", "()Ljava/util/Date;", "GetGetLastModifiedHandler")]
			get {
				const string __id = "getLastModified.()Ljava/util/Date;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='setLastModified' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setLastModified", "(Ljava/util/Date;)V", "GetSetLastModified_Ljava_util_Date_Handler")]
			set {
				const string __id = "setLastModified.(Ljava/util/Date;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getObjectType;
#pragma warning disable 0169
		static Delegate GetGetObjectTypeHandler ()
		{
			if (cb_getObjectType == null)
				cb_getObjectType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObjectType);
			return cb_getObjectType;
		}

		static IntPtr n_GetObjectType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ObjectType);
		}
#pragma warning restore 0169

		public virtual unsafe string ObjectType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='getObjectType' and count(parameter)=0]"
			[Register ("getObjectType", "()Ljava/lang/String;", "GetGetObjectTypeHandler")]
			get {
				const string __id = "getObjectType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRawExpiresValue;
#pragma warning disable 0169
		static Delegate GetGetRawExpiresValueHandler ()
		{
			if (cb_getRawExpiresValue == null)
				cb_getRawExpiresValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRawExpiresValue);
			return cb_getRawExpiresValue;
		}

		static IntPtr n_GetRawExpiresValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RawExpiresValue);
		}
#pragma warning restore 0169

		public virtual unsafe string RawExpiresValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='getRawExpiresValue' and count(parameter)=0]"
			[Register ("getRawExpiresValue", "()Ljava/lang/String;", "GetGetRawExpiresValueHandler")]
			get {
				const string __id = "getRawExpiresValue.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRawMetadata;
#pragma warning disable 0169
		static Delegate GetGetRawMetadataHandler ()
		{
			if (cb_getRawMetadata == null)
				cb_getRawMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRawMetadata);
			return cb_getRawMetadata;
		}

		static IntPtr n_GetRawMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.RawMetadata);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> RawMetadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='getRawMetadata' and count(parameter)=0]"
			[Register ("getRawMetadata", "()Ljava/util/Map;", "GetGetRawMetadataHandler")]
			get {
				const string __id = "getRawMetadata.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSHA1;
#pragma warning disable 0169
		static Delegate GetGetSHA1Handler ()
		{
			if (cb_getSHA1 == null)
				cb_getSHA1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSHA1);
			return cb_getSHA1;
		}

		static IntPtr n_GetSHA1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SHA1);
		}
#pragma warning restore 0169

		static Delegate cb_setSHA1_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSHA1_Ljava_lang_String_Handler ()
		{
			if (cb_setSHA1_Ljava_lang_String_ == null)
				cb_setSHA1_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSHA1_Ljava_lang_String_);
			return cb_setSHA1_Ljava_lang_String_;
		}

		static void n_SetSHA1_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SHA1 = value;
		}
#pragma warning restore 0169

		public virtual unsafe string SHA1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='getSHA1' and count(parameter)=0]"
			[Register ("getSHA1", "()Ljava/lang/String;", "GetGetSHA1Handler")]
			get {
				const string __id = "getSHA1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='setSHA1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSHA1", "(Ljava/lang/String;)V", "GetSetSHA1_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSHA1.(Ljava/lang/String;)V";
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

		static Delegate cb_getServerSideEncryption;
#pragma warning disable 0169
		static Delegate GetGetServerSideEncryptionHandler ()
		{
			if (cb_getServerSideEncryption == null)
				cb_getServerSideEncryption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServerSideEncryption);
			return cb_getServerSideEncryption;
		}

		static IntPtr n_GetServerSideEncryption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServerSideEncryption);
		}
#pragma warning restore 0169

		static Delegate cb_setServerSideEncryption_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetServerSideEncryption_Ljava_lang_String_Handler ()
		{
			if (cb_setServerSideEncryption_Ljava_lang_String_ == null)
				cb_setServerSideEncryption_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetServerSideEncryption_Ljava_lang_String_);
			return cb_setServerSideEncryption_Ljava_lang_String_;
		}

		static void n_SetServerSideEncryption_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverSideEncryption)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string serverSideEncryption = JNIEnv.GetString (native_serverSideEncryption, JniHandleOwnership.DoNotTransfer);
			__this.ServerSideEncryption = serverSideEncryption;
		}
#pragma warning restore 0169

		public virtual unsafe string ServerSideEncryption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='getServerSideEncryption' and count(parameter)=0]"
			[Register ("getServerSideEncryption", "()Ljava/lang/String;", "GetGetServerSideEncryptionHandler")]
			get {
				const string __id = "getServerSideEncryption.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='setServerSideEncryption' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setServerSideEncryption", "(Ljava/lang/String;)V", "GetSetServerSideEncryption_Ljava_lang_String_Handler")]
			set {
				const string __id = "setServerSideEncryption.(Ljava/lang/String;)V";
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

		static Delegate cb_getUserMetadata;
#pragma warning disable 0169
		static Delegate GetGetUserMetadataHandler ()
		{
			if (cb_getUserMetadata == null)
				cb_getUserMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserMetadata);
			return cb_getUserMetadata;
		}

		static IntPtr n_GetUserMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.UserMetadata);
		}
#pragma warning restore 0169

		static Delegate cb_setUserMetadata_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetUserMetadata_Ljava_util_Map_Handler ()
		{
			if (cb_setUserMetadata_Ljava_util_Map_ == null)
				cb_setUserMetadata_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserMetadata_Ljava_util_Map_);
			return cb_setUserMetadata_Ljava_util_Map_;
		}

		static void n_SetUserMetadata_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userMetadata)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var userMetadata = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_userMetadata, JniHandleOwnership.DoNotTransfer);
			__this.UserMetadata = userMetadata;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> UserMetadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='getUserMetadata' and count(parameter)=0]"
			[Register ("getUserMetadata", "()Ljava/util/Map;", "GetGetUserMetadataHandler")]
			get {
				const string __id = "getUserMetadata.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='setUserMetadata' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setUserMetadata", "(Ljava/util/Map;)V", "GetSetUserMetadata_Ljava_util_Map_Handler")]
			set {
				const string __id = "setUserMetadata.(Ljava/util/Map;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_addUserMetadata_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddUserMetadata_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addUserMetadata_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addUserMetadata_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddUserMetadata_Ljava_lang_String_Ljava_lang_String_);
			return cb_addUserMetadata_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddUserMetadata_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AddUserMetadata (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='addUserMetadata' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addUserMetadata", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddUserMetadata_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddUserMetadata (string key, string value)
		{
			const string __id = "addUserMetadata.(Ljava/lang/String;Ljava/lang/String;)V";
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

		static Delegate cb_setHeader_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetHeader_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_setHeader_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_setHeader_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetHeader_Ljava_lang_String_Ljava_lang_Object_);
			return cb_setHeader_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_SetHeader_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetHeader (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ObjectMetadata']/method[@name='setHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setHeader", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSetHeader_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void SetHeader (string key, global::Java.Lang.Object value)
		{
			const string __id = "setHeader.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

	}
}
