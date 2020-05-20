using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginHelper']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/api/PluginHelper", DoNotGenerateAcw=true)]
	public partial class PluginHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/api/PluginHelper", typeof (PluginHelper));
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

		protected PluginHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginHelper']/constructor[@name='PluginHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PluginHelper ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginHelper']/method[@name='asyncGroupSendRequest' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.group.PalGroupReqMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalMsgListener']]"
		[Register ("asyncGroupSendRequest", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/group/PalGroupReqMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z", "")]
		public static unsafe bool AsyncGroupSendRequest (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.Group.PalGroupReqMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1)
		{
			const string __id = "asyncGroupSendRequest.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/group/PalGroupReqMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
