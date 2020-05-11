using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='DateUtil']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/utils/DateUtil", DoNotGenerateAcw=true)]
	public partial class DateUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/utils/DateUtil", typeof (DateUtil));
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

		protected DateUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='DateUtil']/constructor[@name='DateUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DateUtil ()
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

		public static unsafe long FixedSkewedTimeMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='DateUtil']/method[@name='getFixedSkewedTimeMillis' and count(parameter)=0]"
			[Register ("getFixedSkewedTimeMillis", "()J", "")]
			get {
				const string __id = "getFixedSkewedTimeMillis.()J";
				try {
					var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='DateUtil']/method[@name='currentFixedSkewedTimeInRFC822Format' and count(parameter)=0]"
		[Register ("currentFixedSkewedTimeInRFC822Format", "()Ljava/lang/String;", "")]
		public static unsafe string CurrentFixedSkewedTimeInRFC822Format ()
		{
			const string __id = "currentFixedSkewedTimeInRFC822Format.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='DateUtil']/method[@name='formatAlternativeIso8601Date' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("formatAlternativeIso8601Date", "(Ljava/util/Date;)Ljava/lang/String;", "")]
		public static unsafe string FormatAlternativeIso8601Date (global::Java.Util.Date date)
		{
			const string __id = "formatAlternativeIso8601Date.(Ljava/util/Date;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((date == null) ? IntPtr.Zero : ((global::Java.Lang.Object) date).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='DateUtil']/method[@name='formatIso8601Date' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("formatIso8601Date", "(Ljava/util/Date;)Ljava/lang/String;", "")]
		public static unsafe string FormatIso8601Date (global::Java.Util.Date date)
		{
			const string __id = "formatIso8601Date.(Ljava/util/Date;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((date == null) ? IntPtr.Zero : ((global::Java.Lang.Object) date).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='DateUtil']/method[@name='formatRfc822Date' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("formatRfc822Date", "(Ljava/util/Date;)Ljava/lang/String;", "")]
		public static unsafe string FormatRfc822Date (global::Java.Util.Date date)
		{
			const string __id = "formatRfc822Date.(Ljava/util/Date;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((date == null) ? IntPtr.Zero : ((global::Java.Lang.Object) date).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='DateUtil']/method[@name='parseIso8601Date' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseIso8601Date", "(Ljava/lang/String;)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date ParseIso8601Date (string dateString)
		{
			const string __id = "parseIso8601Date.(Ljava/lang/String;)Ljava/util/Date;";
			IntPtr native_dateString = JNIEnv.NewString (dateString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_dateString);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_dateString);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='DateUtil']/method[@name='parseRfc822Date' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseRfc822Date", "(Ljava/lang/String;)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date ParseRfc822Date (string dateString)
		{
			const string __id = "parseRfc822Date.(Ljava/lang/String;)Ljava/util/Date;";
			IntPtr native_dateString = JNIEnv.NewString (dateString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_dateString);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_dateString);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='DateUtil']/method[@name='setCurrentServerTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setCurrentServerTime", "(J)V", "")]
		public static unsafe void SetCurrentServerTime (long serverTime)
		{
			const string __id = "setCurrentServerTime.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (serverTime);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
