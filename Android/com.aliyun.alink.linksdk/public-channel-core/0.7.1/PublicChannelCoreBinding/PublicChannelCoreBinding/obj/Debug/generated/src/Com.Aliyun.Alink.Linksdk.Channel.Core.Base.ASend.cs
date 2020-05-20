using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Core.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='ASend']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/core/base/ASend", DoNotGenerateAcw=true)]
	public abstract partial class ASend : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/core/base/ASend", typeof (ASend));
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

		protected ASend (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='ASend']/constructor[@name='ASend' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.channel.core.base.ARequest'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.core.base.IOnCallListener']]"
		[Register (".ctor", "(Lcom/aliyun/alink/linksdk/channel/core/base/ARequest;Lcom/aliyun/alink/linksdk/channel/core/base/IOnCallListener;)V", "")]
		public unsafe ASend (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/aliyun/alink/linksdk/channel/core/base/ARequest;Lcom/aliyun/alink/linksdk/channel/core/base/IOnCallListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getListener;
#pragma warning disable 0169
		static Delegate GetGetListenerHandler ()
		{
			if (cb_getListener == null)
				cb_getListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListener);
			return cb_getListener;
		}

		static IntPtr n_GetListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Listener);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener Listener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='ASend']/method[@name='getListener' and count(parameter)=0]"
			[Register ("getListener", "()Lcom/aliyun/alink/linksdk/channel/core/base/IOnCallListener;", "GetGetListenerHandler")]
			get {
				const string __id = "getListener.()Lcom/aliyun/alink/linksdk/channel/core/base/IOnCallListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequest;
#pragma warning disable 0169
		static Delegate GetGetRequestHandler ()
		{
			if (cb_getRequest == null)
				cb_getRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequest);
			return cb_getRequest;
		}

		static IntPtr n_GetRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Request);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='ASend']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lcom/aliyun/alink/linksdk/channel/core/base/ARequest;", "GetGetRequestHandler")]
			get {
				const string __id = "getRequest.()Lcom/aliyun/alink/linksdk/channel/core/base/ARequest;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResponse;
#pragma warning disable 0169
		static Delegate GetGetResponseHandler ()
		{
			if (cb_getResponse == null)
				cb_getResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponse);
			return cb_getResponse;
		}

		static IntPtr n_GetResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Response);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AResponse Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='ASend']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Lcom/aliyun/alink/linksdk/channel/core/base/AResponse;", "GetGetResponseHandler")]
			get {
				const string __id = "getResponse.()Lcom/aliyun/alink/linksdk/channel/core/base/AResponse;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.AResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Status);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ISendStatus Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='ASend']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Lcom/aliyun/alink/linksdk/channel/core/base/ISendStatus;", "GetGetStatusHandler")]
			get {
				const string __id = "getStatus.()Lcom/aliyun/alink/linksdk/channel/core/base/ISendStatus;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ISendStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/core/base/ASend", DoNotGenerateAcw=true)]
	internal partial class ASendInvoker : ASend {

		public ASendInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/core/base/ASend", typeof (ASendInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
