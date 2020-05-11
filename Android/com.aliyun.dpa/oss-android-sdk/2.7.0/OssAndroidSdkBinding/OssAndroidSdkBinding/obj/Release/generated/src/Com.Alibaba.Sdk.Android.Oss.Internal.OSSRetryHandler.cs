using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='OSSRetryHandler']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/OSSRetryHandler", DoNotGenerateAcw=true)]
	public partial class OSSRetryHandler : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/OSSRetryHandler", typeof (OSSRetryHandler));
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

		protected OSSRetryHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='OSSRetryHandler']/constructor[@name='OSSRetryHandler' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe OSSRetryHandler (int maxRetryCount)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxRetryCount);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMaxRetryCount_I;
#pragma warning disable 0169
		static Delegate GetSetMaxRetryCount_IHandler ()
		{
			if (cb_setMaxRetryCount_I == null)
				cb_setMaxRetryCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxRetryCount_I);
			return cb_setMaxRetryCount_I;
		}

		static void n_SetMaxRetryCount_I (IntPtr jnienv, IntPtr native__this, int maxRetryCount)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSRetryHandler __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSRetryHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxRetryCount (maxRetryCount);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='OSSRetryHandler']/method[@name='setMaxRetryCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxRetryCount", "(I)V", "GetSetMaxRetryCount_IHandler")]
		public virtual unsafe void SetMaxRetryCount (int maxRetryCount)
		{
			const string __id = "setMaxRetryCount.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxRetryCount);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_shouldRetry_Ljava_lang_Exception_I;
#pragma warning disable 0169
		static Delegate GetShouldRetry_Ljava_lang_Exception_IHandler ()
		{
			if (cb_shouldRetry_Ljava_lang_Exception_I == null)
				cb_shouldRetry_Ljava_lang_Exception_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_ShouldRetry_Ljava_lang_Exception_I);
			return cb_shouldRetry_Ljava_lang_Exception_I;
		}

		static IntPtr n_ShouldRetry_Ljava_lang_Exception_I (IntPtr jnienv, IntPtr native__this, IntPtr native_e, int currentRetryCount)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSRetryHandler __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSRetryHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception e = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_e, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShouldRetry (e, currentRetryCount));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='OSSRetryHandler']/method[@name='shouldRetry' and count(parameter)=2 and parameter[1][@type='java.lang.Exception'] and parameter[2][@type='int']]"
		[Register ("shouldRetry", "(Ljava/lang/Exception;I)Lcom/alibaba/sdk/android/oss/internal/OSSRetryType;", "GetShouldRetry_Ljava_lang_Exception_IHandler")]
		public virtual unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSRetryType ShouldRetry (global::Java.Lang.Exception e, int currentRetryCount)
		{
			const string __id = "shouldRetry.(Ljava/lang/Exception;I)Lcom/alibaba/sdk/android/oss/internal/OSSRetryType;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				__args [1] = new JniArgumentValue (currentRetryCount);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSRetryType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
