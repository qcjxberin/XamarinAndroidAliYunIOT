using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Core.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='ASendStatus']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/core/base/ASendStatus", DoNotGenerateAcw=true)]
	public sealed partial class ASendStatus : global::Java.Lang.Enum, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ISendStatus {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='ASendStatus']/field[@name='completed']"
		[Register ("completed")]
		public static global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASendStatus Completed {
			get {
				const string __id = "completed.Lcom/aliyun/alink/linksdk/channel/core/base/ASendStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASendStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='ASendStatus']/field[@name='waitingToComplete']"
		[Register ("waitingToComplete")]
		public static global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASendStatus WaitingToComplete {
			get {
				const string __id = "waitingToComplete.Lcom/aliyun/alink/linksdk/channel/core/base/ASendStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASendStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='ASendStatus']/field[@name='waitingToSend']"
		[Register ("waitingToSend")]
		public static global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASendStatus WaitingToSend {
			get {
				const string __id = "waitingToSend.Lcom/aliyun/alink/linksdk/channel/core/base/ASendStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASendStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/core/base/ASendStatus", typeof (ASendStatus));
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

		internal ASendStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='ASendStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/channel/core/base/ASendStatus;", "")]
		public static unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASendStatus ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/channel/core/base/ASendStatus;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASendStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.base']/class[@name='ASendStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/aliyun/alink/linksdk/channel/core/base/ASendStatus;", "")]
		public static unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASendStatus[] Values ()
		{
			const string __id = "values.()[Lcom/aliyun/alink/linksdk/channel/core/base/ASendStatus;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASendStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASendStatus));
			} finally {
			}
		}

	}
}
