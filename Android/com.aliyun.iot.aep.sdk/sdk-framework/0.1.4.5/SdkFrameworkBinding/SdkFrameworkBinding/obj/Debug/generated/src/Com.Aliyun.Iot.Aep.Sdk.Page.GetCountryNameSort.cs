using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Page {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='GetCountryNameSort']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/page/GetCountryNameSort", DoNotGenerateAcw=true)]
	public partial class GetCountryNameSort : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/page/GetCountryNameSort", typeof (GetCountryNameSort));
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

		protected GetCountryNameSort (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='GetCountryNameSort']/constructor[@name='GetCountryNameSort' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GetCountryNameSort ()
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

		static Delegate cb_getSortLetter_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSortLetter_Ljava_lang_String_Handler ()
		{
			if (cb_getSortLetter_Ljava_lang_String_ == null)
				cb_getSortLetter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSortLetter_Ljava_lang_String_);
			return cb_getSortLetter_Ljava_lang_String_;
		}

		static IntPtr n_GetSortLetter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Page.GetCountryNameSort __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Page.GetCountryNameSort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetSortLetter (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='GetCountryNameSort']/method[@name='getSortLetter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSortLetter", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetSortLetter_Ljava_lang_String_Handler")]
		public virtual unsafe string GetSortLetter (string name)
		{
			const string __id = "getSortLetter.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getSortLetterBySortKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSortLetterBySortKey_Ljava_lang_String_Handler ()
		{
			if (cb_getSortLetterBySortKey_Ljava_lang_String_ == null)
				cb_getSortLetterBySortKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSortLetterBySortKey_Ljava_lang_String_);
			return cb_getSortLetterBySortKey_Ljava_lang_String_;
		}

		static IntPtr n_GetSortLetterBySortKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sortKey)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Page.GetCountryNameSort __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Page.GetCountryNameSort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sortKey = JNIEnv.GetString (native_sortKey, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetSortLetterBySortKey (sortKey));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='GetCountryNameSort']/method[@name='getSortLetterBySortKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSortLetterBySortKey", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetSortLetterBySortKey_Ljava_lang_String_Handler")]
		public virtual unsafe string GetSortLetterBySortKey (string sortKey)
		{
			const string __id = "getSortLetterBySortKey.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_sortKey = JNIEnv.NewString (sortKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sortKey);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_sortKey);
			}
		}

	}
}
