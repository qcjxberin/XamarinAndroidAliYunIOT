using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Tools.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogStrategyType']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/tools/log/LogStrategyType", DoNotGenerateAcw=true)]
	public sealed partial class LogStrategyType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogStrategyType']/field[@name='FILE_STRATEGY']"
		[Register ("FILE_STRATEGY")]
		public static global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogStrategyType FileStrategy {
			get {
				const string __id = "FILE_STRATEGY.Lcom/aliyun/alink/linksdk/tools/log/LogStrategyType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogStrategyType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogStrategyType']/field[@name='LOGCAT_STRATEGY']"
		[Register ("LOGCAT_STRATEGY")]
		public static global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogStrategyType LogcatStrategy {
			get {
				const string __id = "LOGCAT_STRATEGY.Lcom/aliyun/alink/linksdk/tools/log/LogStrategyType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogStrategyType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogStrategyType']/field[@name='REALTIME_STRATEGY']"
		[Register ("REALTIME_STRATEGY")]
		public static global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogStrategyType RealtimeStrategy {
			get {
				const string __id = "REALTIME_STRATEGY.Lcom/aliyun/alink/linksdk/tools/log/LogStrategyType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogStrategyType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/tools/log/LogStrategyType", typeof (LogStrategyType));
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

		internal LogStrategyType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogStrategyType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/tools/log/LogStrategyType;", "")]
		public static unsafe global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogStrategyType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/tools/log/LogStrategyType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogStrategyType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogStrategyType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/aliyun/alink/linksdk/tools/log/LogStrategyType;", "")]
		public static unsafe global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogStrategyType[] Values ()
		{
			const string __id = "values.()[Lcom/aliyun/alink/linksdk/tools/log/LogStrategyType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogStrategyType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogStrategyType));
			} finally {
			}
		}

	}
}
