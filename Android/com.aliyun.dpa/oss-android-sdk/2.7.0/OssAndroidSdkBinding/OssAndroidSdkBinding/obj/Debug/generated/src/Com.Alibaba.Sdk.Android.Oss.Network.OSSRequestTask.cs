using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='OSSRequestTask']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/network/OSSRequestTask", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.alibaba.sdk.android.oss.model.OSSResult"})]
	public partial class OSSRequestTask : global::Java.Lang.Object, global::Java.Util.Concurrent.ICallable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/network/OSSRequestTask", typeof (OSSRequestTask));
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

		protected OSSRequestTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='OSSRequestTask']/constructor[@name='OSSRequestTask' and count(parameter)=4 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.RequestMessage'] and parameter[2][@type='com.alibaba.sdk.android.oss.internal.ResponseParser'] and parameter[3][@type='com.alibaba.sdk.android.oss.network.ExecutionContext'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Lcom/alibaba/sdk/android/oss/internal/RequestMessage;Lcom/alibaba/sdk/android/oss/internal/ResponseParser;Lcom/alibaba/sdk/android/oss/network/ExecutionContext;I)V", "")]
		public unsafe OSSRequestTask (global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage message, global::Com.Alibaba.Sdk.Android.Oss.Internal.IResponseParser parser, global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext context, int maxRetry)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/alibaba/sdk/android/oss/internal/RequestMessage;Lcom/alibaba/sdk/android/oss/internal/ResponseParser;Lcom/alibaba/sdk/android/oss/network/ExecutionContext;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				__args [1] = new JniArgumentValue ((parser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parser).Handle);
				__args [2] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [3] = new JniArgumentValue (maxRetry);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_call;
#pragma warning disable 0169
		static Delegate GetCallHandler ()
		{
			if (cb_call == null)
				cb_call = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Call);
			return cb_call;
		}

		static IntPtr n_Call (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Network.OSSRequestTask __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Network.OSSRequestTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='OSSRequestTask']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lcom/alibaba/sdk/android/oss/model/OSSResult;", "GetCallHandler")]
		public virtual unsafe global::Java.Lang.Object Call ()
		{
			const string __id = "call.()Lcom/alibaba/sdk/android/oss/model/OSSResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
