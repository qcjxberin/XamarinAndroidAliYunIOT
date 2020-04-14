using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Tools.UT {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.ut']/class[@name='AUserTrack']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/tools/ut/AUserTrack", DoNotGenerateAcw=true)]
	public partial class AUserTrack : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.ut']/class[@name='AUserTrack']/field[@name='UTKEY_DEVICE_IOTID']"
		[Register ("UTKEY_DEVICE_IOTID")]
		public const string UtkeyDeviceIotid = (string) "deviceIotId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.ut']/class[@name='AUserTrack']/field[@name='UTKEY_END_TIME']"
		[Register ("UTKEY_END_TIME")]
		public const string UtkeyEndTime = (string) "endTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.ut']/class[@name='AUserTrack']/field[@name='UTKEY_ERROR_CODE']"
		[Register ("UTKEY_ERROR_CODE")]
		public const string UtkeyErrorCode = (string) "errorCode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.ut']/class[@name='AUserTrack']/field[@name='UTKEY_EVENT_NAME']"
		[Register ("UTKEY_EVENT_NAME")]
		public const string UtkeyEventName = (string) "eventName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.ut']/class[@name='AUserTrack']/field[@name='UTKEY_MODULE']"
		[Register ("UTKEY_MODULE")]
		public const string UtkeyModule = (string) "module";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.ut']/class[@name='AUserTrack']/field[@name='UTKEY_PAGE_NAME']"
		[Register ("UTKEY_PAGE_NAME")]
		public const string UtkeyPageName = (string) "pageName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.ut']/class[@name='AUserTrack']/field[@name='UTKEY_PERFORMANCEID']"
		[Register ("UTKEY_PERFORMANCEID")]
		public const string UtkeyPerformanceid = (string) "performanceId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.ut']/class[@name='AUserTrack']/field[@name='UTKEY_START_TIME']"
		[Register ("UTKEY_START_TIME")]
		public const string UtkeyStartTime = (string) "startTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.ut']/class[@name='AUserTrack']/field[@name='UTKEY_SUB_ERROR_CODE']"
		[Register ("UTKEY_SUB_ERROR_CODE")]
		public const string UtkeySubErrorCode = (string) "subErrorCode";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.ut']/class[@name='AUserTrack']/field[@name='mDispatch']"
		[Register ("mDispatch")]
		protected static global::Com.Aliyun.Alink.Linksdk.Tools.UT.IUserTrackDispatch MDispatch {
			get {
				const string __id = "mDispatch.Lcom/aliyun/alink/linksdk/tools/ut/IUserTrackDispatch;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.UT.IUserTrackDispatch> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDispatch.Lcom/aliyun/alink/linksdk/tools/ut/IUserTrackDispatch;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/tools/ut/AUserTrack", typeof (AUserTrack));
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

		protected AUserTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.ut']/class[@name='AUserTrack']/constructor[@name='AUserTrack' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AUserTrack ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.ut']/class[@name='AUserTrack']/method[@name='record' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("record", "(Ljava/lang/String;Ljava/lang/String;JJ)V", "")]
		public static unsafe void Record (string eventName, string pageName, long startTime, long endTime)
		{
			const string __id = "record.(Ljava/lang/String;Ljava/lang/String;JJ)V";
			IntPtr native_eventName = JNIEnv.NewString (eventName);
			IntPtr native_pageName = JNIEnv.NewString (pageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_eventName);
				__args [1] = new JniArgumentValue (native_pageName);
				__args [2] = new JniArgumentValue (startTime);
				__args [3] = new JniArgumentValue (endTime);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_eventName);
				JNIEnv.DeleteLocalRef (native_pageName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.ut']/class[@name='AUserTrack']/method[@name='record' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("record", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public static unsafe void Record (string eventName, global::System.Collections.Generic.IDictionary<string, string> data)
		{
			const string __id = "record.(Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_eventName = JNIEnv.NewString (eventName);
			IntPtr native_data = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_eventName);
				__args [1] = new JniArgumentValue (native_data);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_eventName);
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.ut']/class[@name='AUserTrack']/method[@name='record' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("record", "(Ljava/lang/String;JJ)V", "")]
		public static unsafe void Record (string eventName, long startTime, long endTime)
		{
			const string __id = "record.(Ljava/lang/String;JJ)V";
			IntPtr native_eventName = JNIEnv.NewString (eventName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_eventName);
				__args [1] = new JniArgumentValue (startTime);
				__args [2] = new JniArgumentValue (endTime);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_eventName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.ut']/class[@name='AUserTrack']/method[@name='record' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String']]"
		[Register ("record", "(Ljava/lang/String;JJLjava/lang/String;)V", "")]
		public static unsafe void Record (string eventName, long startTime, long endTime, string errorCode)
		{
			const string __id = "record.(Ljava/lang/String;JJLjava/lang/String;)V";
			IntPtr native_eventName = JNIEnv.NewString (eventName);
			IntPtr native_errorCode = JNIEnv.NewString (errorCode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_eventName);
				__args [1] = new JniArgumentValue (startTime);
				__args [2] = new JniArgumentValue (endTime);
				__args [3] = new JniArgumentValue (native_errorCode);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_eventName);
				JNIEnv.DeleteLocalRef (native_errorCode);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.ut']/class[@name='AUserTrack']/method[@name='setDispatch' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.tools.ut.IUserTrackDispatch']]"
		[Register ("setDispatch", "(Lcom/aliyun/alink/linksdk/tools/ut/IUserTrackDispatch;)V", "")]
		public static unsafe void SetDispatch (global::Com.Aliyun.Alink.Linksdk.Tools.UT.IUserTrackDispatch dispatch)
		{
			const string __id = "setDispatch.(Lcom/aliyun/alink/linksdk/tools/ut/IUserTrackDispatch;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dispatch == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dispatch).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
