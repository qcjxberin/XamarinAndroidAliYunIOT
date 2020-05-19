using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='CancellationHandler']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/network/CancellationHandler", DoNotGenerateAcw=true)]
	public partial class CancellationHandler : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/network/CancellationHandler", typeof (CancellationHandler));
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

		protected CancellationHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='CancellationHandler']/constructor[@name='CancellationHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CancellationHandler ()
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

		static Delegate cb_isCancelled;
#pragma warning disable 0169
		static Delegate GetIsCancelledHandler ()
		{
			if (cb_isCancelled == null)
				cb_isCancelled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCancelled);
			return cb_isCancelled;
		}

		static bool n_IsCancelled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Network.CancellationHandler __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Network.CancellationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCancelled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCancelled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='CancellationHandler']/method[@name='isCancelled' and count(parameter)=0]"
			[Register ("isCancelled", "()Z", "GetIsCancelledHandler")]
			get {
				const string __id = "isCancelled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Network.CancellationHandler __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Network.CancellationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='CancellationHandler']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setCall_Lokhttp3_Call_;
#pragma warning disable 0169
		static Delegate GetSetCall_Lokhttp3_Call_Handler ()
		{
			if (cb_setCall_Lokhttp3_Call_ == null)
				cb_setCall_Lokhttp3_Call_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCall_Lokhttp3_Call_);
			return cb_setCall_Lokhttp3_Call_;
		}

		static void n_SetCall_Lokhttp3_Call_ (IntPtr jnienv, IntPtr native__this, IntPtr native_call)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Network.CancellationHandler __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Network.CancellationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICall call = (global::Okhttp3.ICall)global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (native_call, JniHandleOwnership.DoNotTransfer);
			__this.SetCall (call);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='CancellationHandler']/method[@name='setCall' and count(parameter)=1 and parameter[1][@type='okhttp3.Call']]"
		[Register ("setCall", "(Lokhttp3/Call;)V", "GetSetCall_Lokhttp3_Call_Handler")]
		public virtual unsafe void SetCall (global::Okhttp3.ICall call)
		{
			const string __id = "setCall.(Lokhttp3/Call;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}