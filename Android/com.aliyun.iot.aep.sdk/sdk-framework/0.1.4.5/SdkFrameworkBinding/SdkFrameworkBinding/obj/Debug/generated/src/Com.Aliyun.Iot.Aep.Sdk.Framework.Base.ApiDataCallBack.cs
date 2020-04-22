using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.base']/class[@name='ApiDataCallBack']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class ApiDataCallBack : global::Java.Lang.Object, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Base.IDataCallBack {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack", typeof (ApiDataCallBack));
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

		protected ApiDataCallBack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.base']/class[@name='ApiDataCallBack']/constructor[@name='ApiDataCallBack' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ApiDataCallBack ()
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

		static Delegate cb_onFail_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnFail_ILjava_lang_String_Handler ()
		{
			if (cb_onFail_ILjava_lang_String_ == null)
				cb_onFail_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnFail_ILjava_lang_String_);
			return cb_onFail_ILjava_lang_String_;
		}

		static void n_OnFail_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Base.ApiDataCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Base.ApiDataCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnFail (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.base']/interface[@name='DataCallBack']/method[@name='onFail' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onFail", "(ILjava/lang/String;)V", "GetOnFail_ILjava_lang_String_Handler")]
		public abstract void OnFail (int p0, string p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack", DoNotGenerateAcw=true)]
	internal partial class ApiDataCallBackInvoker : ApiDataCallBack, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Base.IDataCallBack {

		public ApiDataCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack", typeof (ApiDataCallBackInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.base']/interface[@name='DataCallBack']/method[@name='onFail' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onFail", "(ILjava/lang/String;)V", "GetOnFail_ILjava_lang_String_Handler")]
		public override unsafe void OnFail (int p0, string p1)
		{
			const string __id = "onFail.(ILjava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

}
