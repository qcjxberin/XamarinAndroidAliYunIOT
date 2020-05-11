using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PutObjectResult']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/PutObjectResult", DoNotGenerateAcw=true)]
	public partial class PutObjectResult : global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/PutObjectResult", typeof (PutObjectResult));
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

		protected PutObjectResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PutObjectResult']/constructor[@name='PutObjectResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PutObjectResult ()
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ETag);
		}
#pragma warning restore 0169

		static Delegate cb_setETag_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetETag_Ljava_lang_String_Handler ()
		{
			if (cb_setETag_Ljava_lang_String_ == null)
				cb_setETag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetETag_Ljava_lang_String_);
			return cb_setETag_Ljava_lang_String_;
		}

		static void n_SetETag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eTag)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string eTag = JNIEnv.GetString (native_eTag, JniHandleOwnership.DoNotTransfer);
			__this.ETag = eTag;
		}
#pragma warning restore 0169

		public virtual unsafe string ETag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PutObjectResult']/method[@name='getETag' and count(parameter)=0]"
			[Register ("getETag", "()Ljava/lang/String;", "GetGetETagHandler")]
			get {
				const string __id = "getETag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PutObjectResult']/method[@name='setETag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setETag", "(Ljava/lang/String;)V", "GetSetETag_Ljava_lang_String_Handler")]
			set {
				const string __id = "setETag.(Ljava/lang/String;)V";
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

		static Delegate cb_getServerCallbackReturnBody;
#pragma warning disable 0169
		static Delegate GetGetServerCallbackReturnBodyHandler ()
		{
			if (cb_getServerCallbackReturnBody == null)
				cb_getServerCallbackReturnBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServerCallbackReturnBody);
			return cb_getServerCallbackReturnBody;
		}

		static IntPtr n_GetServerCallbackReturnBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServerCallbackReturnBody);
		}
#pragma warning restore 0169

		static Delegate cb_setServerCallbackReturnBody_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetServerCallbackReturnBody_Ljava_lang_String_Handler ()
		{
			if (cb_setServerCallbackReturnBody_Ljava_lang_String_ == null)
				cb_setServerCallbackReturnBody_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetServerCallbackReturnBody_Ljava_lang_String_);
			return cb_setServerCallbackReturnBody_Ljava_lang_String_;
		}

		static void n_SetServerCallbackReturnBody_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverCallbackReturnBody)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string serverCallbackReturnBody = JNIEnv.GetString (native_serverCallbackReturnBody, JniHandleOwnership.DoNotTransfer);
			__this.ServerCallbackReturnBody = serverCallbackReturnBody;
		}
#pragma warning restore 0169

		public virtual unsafe string ServerCallbackReturnBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PutObjectResult']/method[@name='getServerCallbackReturnBody' and count(parameter)=0]"
			[Register ("getServerCallbackReturnBody", "()Ljava/lang/String;", "GetGetServerCallbackReturnBodyHandler")]
			get {
				const string __id = "getServerCallbackReturnBody.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PutObjectResult']/method[@name='setServerCallbackReturnBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setServerCallbackReturnBody", "(Ljava/lang/String;)V", "GetSetServerCallbackReturnBody_Ljava_lang_String_Handler")]
			set {
				const string __id = "setServerCallbackReturnBody.(Ljava/lang/String;)V";
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

	}
}
