using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectResult']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/CopyObjectResult", DoNotGenerateAcw=true)]
	public partial class CopyObjectResult : global::Com.Alibaba.Sdk.Android.Oss.Model.OSSResult {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/CopyObjectResult", typeof (CopyObjectResult));
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

		protected CopyObjectResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectResult']/constructor[@name='CopyObjectResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CopyObjectResult ()
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ETag);
		}
#pragma warning restore 0169

		public virtual unsafe string ETag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectResult']/method[@name='getETag' and count(parameter)=0]"
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date lastModified = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_lastModified, JniHandleOwnership.DoNotTransfer);
			__this.LastModified = lastModified;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Date LastModified {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectResult']/method[@name='getLastModified' and count(parameter)=0]"
			[Register ("getLastModified", "()Ljava/util/Date;", "GetGetLastModifiedHandler")]
			get {
				const string __id = "getLastModified.()Ljava/util/Date;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectResult']/method[@name='setLastModified' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
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

		static Delegate cb_setEtag_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEtag_Ljava_lang_String_Handler ()
		{
			if (cb_setEtag_Ljava_lang_String_ == null)
				cb_setEtag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEtag_Ljava_lang_String_);
			return cb_setEtag_Ljava_lang_String_;
		}

		static void n_SetEtag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_etag)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectResult __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string etag = JNIEnv.GetString (native_etag, JniHandleOwnership.DoNotTransfer);
			__this.SetEtag (etag);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CopyObjectResult']/method[@name='setEtag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setEtag", "(Ljava/lang/String;)V", "GetSetEtag_Ljava_lang_String_Handler")]
		public virtual unsafe void SetEtag (string etag)
		{
			const string __id = "setEtag.(Ljava/lang/String;)V";
			IntPtr native_etag = JNIEnv.NewString (etag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_etag);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_etag);
			}
		}

	}
}
