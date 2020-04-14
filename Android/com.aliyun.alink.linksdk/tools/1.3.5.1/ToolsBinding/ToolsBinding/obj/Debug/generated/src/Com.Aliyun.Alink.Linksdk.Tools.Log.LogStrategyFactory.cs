using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Tools.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogStrategyFactory']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/tools/log/LogStrategyFactory", DoNotGenerateAcw=true)]
	public partial class LogStrategyFactory : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/tools/log/LogStrategyFactory", typeof (LogStrategyFactory));
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

		protected LogStrategyFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogStrategyFactory Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogStrategyFactory']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/aliyun/alink/linksdk/tools/log/LogStrategyFactory;", "")]
			get {
				const string __id = "getInstance.()Lcom/aliyun/alink/linksdk/tools/log/LogStrategyFactory;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogStrategyFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createStrategy_Lcom_aliyun_alink_linksdk_tools_log_LogStrategyType_;
#pragma warning disable 0169
		static Delegate GetCreateStrategy_Lcom_aliyun_alink_linksdk_tools_log_LogStrategyType_Handler ()
		{
			if (cb_createStrategy_Lcom_aliyun_alink_linksdk_tools_log_LogStrategyType_ == null)
				cb_createStrategy_Lcom_aliyun_alink_linksdk_tools_log_LogStrategyType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateStrategy_Lcom_aliyun_alink_linksdk_tools_log_LogStrategyType_);
			return cb_createStrategy_Lcom_aliyun_alink_linksdk_tools_log_LogStrategyType_;
		}

		static IntPtr n_CreateStrategy_Lcom_aliyun_alink_linksdk_tools_log_LogStrategyType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogStrategyFactory __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogStrategyFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogStrategyType type = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogStrategyType> (native_type, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateStrategy (type));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogStrategyFactory']/method[@name='createStrategy' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.tools.log.LogStrategyType']]"
		[Register ("createStrategy", "(Lcom/aliyun/alink/linksdk/tools/log/LogStrategyType;)Lcom/aliyun/alink/linksdk/tools/log/ILogStrategy;", "GetCreateStrategy_Lcom_aliyun_alink_linksdk_tools_log_LogStrategyType_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogStrategy CreateStrategy (global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogStrategyType type)
		{
			const string __id = "createStrategy.(Lcom/aliyun/alink/linksdk/tools/log/LogStrategyType;)Lcom/aliyun/alink/linksdk/tools/log/ILogStrategy;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
