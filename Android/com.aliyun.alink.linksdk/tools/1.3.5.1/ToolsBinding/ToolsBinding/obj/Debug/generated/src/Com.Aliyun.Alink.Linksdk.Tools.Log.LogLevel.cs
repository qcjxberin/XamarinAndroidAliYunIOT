using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Tools.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogLevel']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/tools/log/LogLevel", DoNotGenerateAcw=true)]
	public sealed partial class LogLevel : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogLevel']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public static global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogLevel Debug {
			get {
				const string __id = "DEBUG.Lcom/aliyun/alink/linksdk/tools/log/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogLevel']/field[@name='ERROR']"
		[Register ("ERROR")]
		public static global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogLevel Error {
			get {
				const string __id = "ERROR.Lcom/aliyun/alink/linksdk/tools/log/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogLevel']/field[@name='INFO']"
		[Register ("INFO")]
		public static global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogLevel Info {
			get {
				const string __id = "INFO.Lcom/aliyun/alink/linksdk/tools/log/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogLevel']/field[@name='WRAN']"
		[Register ("WRAN")]
		public static global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogLevel Wran {
			get {
				const string __id = "WRAN.Lcom/aliyun/alink/linksdk/tools/log/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/tools/log/LogLevel", typeof (LogLevel));
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

		internal LogLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe string Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogLevel']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/tools/log/LogLevel;", "")]
		public static unsafe global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogLevel ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/tools/log/LogLevel;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogLevel']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/aliyun/alink/linksdk/tools/log/LogLevel;", "")]
		public static unsafe global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogLevel[] Values ()
		{
			const string __id = "values.()[Lcom/aliyun/alink/linksdk/tools/log/LogLevel;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogLevel[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogLevel));
			} finally {
			}
		}

	}
}
