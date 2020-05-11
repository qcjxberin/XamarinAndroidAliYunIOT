using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PartSummary']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/PartSummary", DoNotGenerateAcw=true)]
	public partial class PartSummary : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/PartSummary", typeof (PartSummary));
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

		protected PartSummary (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PartSummary']/constructor[@name='PartSummary' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PartSummary ()
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string eTag = JNIEnv.GetString (native_eTag, JniHandleOwnership.DoNotTransfer);
			__this.ETag = eTag;
		}
#pragma warning restore 0169

		public virtual unsafe string ETag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PartSummary']/method[@name='getETag' and count(parameter)=0]"
			[Register ("getETag", "()Ljava/lang/String;", "GetGetETagHandler")]
			get {
				const string __id = "getETag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PartSummary']/method[@name='setETag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date lastModified = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_lastModified, JniHandleOwnership.DoNotTransfer);
			__this.LastModified = lastModified;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Date LastModified {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PartSummary']/method[@name='getLastModified' and count(parameter)=0]"
			[Register ("getLastModified", "()Ljava/util/Date;", "GetGetLastModifiedHandler")]
			get {
				const string __id = "getLastModified.()Ljava/util/Date;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PartSummary']/method[@name='setLastModified' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
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

		static Delegate cb_getPartNumber;
#pragma warning disable 0169
		static Delegate GetGetPartNumberHandler ()
		{
			if (cb_getPartNumber == null)
				cb_getPartNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPartNumber);
			return cb_getPartNumber;
		}

		static int n_GetPartNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PartNumber;
		}
#pragma warning restore 0169

		static Delegate cb_setPartNumber_I;
#pragma warning disable 0169
		static Delegate GetSetPartNumber_IHandler ()
		{
			if (cb_setPartNumber_I == null)
				cb_setPartNumber_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPartNumber_I);
			return cb_setPartNumber_I;
		}

		static void n_SetPartNumber_I (IntPtr jnienv, IntPtr native__this, int partNumber)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PartNumber = partNumber;
		}
#pragma warning restore 0169

		public virtual unsafe int PartNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PartSummary']/method[@name='getPartNumber' and count(parameter)=0]"
			[Register ("getPartNumber", "()I", "GetGetPartNumberHandler")]
			get {
				const string __id = "getPartNumber.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PartSummary']/method[@name='setPartNumber' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPartNumber", "(I)V", "GetSetPartNumber_IHandler")]
			set {
				const string __id = "setPartNumber.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSize);
			return cb_getSize;
		}

		static long n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		static Delegate cb_setSize_J;
#pragma warning disable 0169
		static Delegate GetSetSize_JHandler ()
		{
			if (cb_setSize_J == null)
				cb_setSize_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetSize_J);
			return cb_setSize_J;
		}

		static void n_SetSize_J (IntPtr jnienv, IntPtr native__this, long size)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PartSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Size = size;
		}
#pragma warning restore 0169

		public virtual unsafe long Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PartSummary']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()J", "GetGetSizeHandler")]
			get {
				const string __id = "getSize.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PartSummary']/method[@name='setSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setSize", "(J)V", "GetSetSize_JHandler")]
			set {
				const string __id = "setSize.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
