using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PartETag']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/PartETag", DoNotGenerateAcw=true)]
	public partial class PartETag : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/PartETag", typeof (PartETag));
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

		protected PartETag (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PartETag']/constructor[@name='PartETag' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe PartETag (int partNumber, string eTag)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_eTag = JNIEnv.NewString (eTag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (partNumber);
				__args [1] = new JniArgumentValue (native_eTag);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_eTag);
			}
		}

		static Delegate cb_getCRC64;
#pragma warning disable 0169
		static Delegate GetGetCRC64Handler ()
		{
			if (cb_getCRC64 == null)
				cb_getCRC64 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCRC64);
			return cb_getCRC64;
		}

		static long n_GetCRC64 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CRC64;
		}
#pragma warning restore 0169

		static Delegate cb_setCRC64_J;
#pragma warning disable 0169
		static Delegate GetSetCRC64_JHandler ()
		{
			if (cb_setCRC64_J == null)
				cb_setCRC64_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetCRC64_J);
			return cb_setCRC64_J;
		}

		static void n_SetCRC64_J (IntPtr jnienv, IntPtr native__this, long crc64)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CRC64 = crc64;
		}
#pragma warning restore 0169

		public virtual unsafe long CRC64 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PartETag']/method[@name='getCRC64' and count(parameter)=0]"
			[Register ("getCRC64", "()J", "GetGetCRC64Handler")]
			get {
				const string __id = "getCRC64.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PartETag']/method[@name='setCRC64' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setCRC64", "(J)V", "GetSetCRC64_JHandler")]
			set {
				const string __id = "setCRC64.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string eTag = JNIEnv.GetString (native_eTag, JniHandleOwnership.DoNotTransfer);
			__this.ETag = eTag;
		}
#pragma warning restore 0169

		public virtual unsafe string ETag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PartETag']/method[@name='getETag' and count(parameter)=0]"
			[Register ("getETag", "()Ljava/lang/String;", "GetGetETagHandler")]
			get {
				const string __id = "getETag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PartETag']/method[@name='setETag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PartNumber = partNumber;
		}
#pragma warning restore 0169

		public virtual unsafe int PartNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PartETag']/method[@name='getPartNumber' and count(parameter)=0]"
			[Register ("getPartNumber", "()I", "GetGetPartNumberHandler")]
			get {
				const string __id = "getPartNumber.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PartETag']/method[@name='setPartNumber' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getPartSize;
#pragma warning disable 0169
		static Delegate GetGetPartSizeHandler ()
		{
			if (cb_getPartSize == null)
				cb_getPartSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPartSize);
			return cb_getPartSize;
		}

		static long n_GetPartSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PartSize;
		}
#pragma warning restore 0169

		static Delegate cb_setPartSize_J;
#pragma warning disable 0169
		static Delegate GetSetPartSize_JHandler ()
		{
			if (cb_setPartSize_J == null)
				cb_setPartSize_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetPartSize_J);
			return cb_setPartSize_J;
		}

		static void n_SetPartSize_J (IntPtr jnienv, IntPtr native__this, long partSize)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PartSize = partSize;
		}
#pragma warning restore 0169

		public virtual unsafe long PartSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PartETag']/method[@name='getPartSize' and count(parameter)=0]"
			[Register ("getPartSize", "()J", "GetGetPartSizeHandler")]
			get {
				const string __id = "getPartSize.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='PartETag']/method[@name='setPartSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setPartSize", "(J)V", "GetSetPartSize_JHandler")]
			set {
				const string __id = "setPartSize.(J)V";
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
