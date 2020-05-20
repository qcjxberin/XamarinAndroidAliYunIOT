using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Internal.Bind.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind.util']/class[@name='ISO8601Utils']"
	[global::Android.Runtime.Register ("com/google/gson/internal/bind/util/ISO8601Utils", DoNotGenerateAcw=true)]
	public partial class ISO8601Utils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/bind/util/ISO8601Utils", typeof (ISO8601Utils));
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

		protected ISO8601Utils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal.bind.util']/class[@name='ISO8601Utils']/constructor[@name='ISO8601Utils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ISO8601Utils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind.util']/class[@name='ISO8601Utils']/method[@name='format' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("format", "(Ljava/util/Date;)Ljava/lang/String;", "")]
		public static unsafe string Format (global::Java.Util.Date date)
		{
			const string __id = "format.(Ljava/util/Date;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((date == null) ? IntPtr.Zero : ((global::Java.Lang.Object) date).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind.util']/class[@name='ISO8601Utils']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='boolean']]"
		[Register ("format", "(Ljava/util/Date;Z)Ljava/lang/String;", "")]
		public static unsafe string Format (global::Java.Util.Date date, bool millis)
		{
			const string __id = "format.(Ljava/util/Date;Z)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((date == null) ? IntPtr.Zero : ((global::Java.Lang.Object) date).Handle);
				__args [1] = new JniArgumentValue (millis);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind.util']/class[@name='ISO8601Utils']/method[@name='format' and count(parameter)=3 and parameter[1][@type='java.util.Date'] and parameter[2][@type='boolean'] and parameter[3][@type='java.util.TimeZone']]"
		[Register ("format", "(Ljava/util/Date;ZLjava/util/TimeZone;)Ljava/lang/String;", "")]
		public static unsafe string Format (global::Java.Util.Date date, bool millis, global::Java.Util.TimeZone tz)
		{
			const string __id = "format.(Ljava/util/Date;ZLjava/util/TimeZone;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((date == null) ? IntPtr.Zero : ((global::Java.Lang.Object) date).Handle);
				__args [1] = new JniArgumentValue (millis);
				__args [2] = new JniArgumentValue ((tz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tz).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind.util']/class[@name='ISO8601Utils']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.text.ParsePosition']]"
		[Register ("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date Parse (string date, global::Java.Text.ParsePosition pos)
		{
			const string __id = "parse.(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;";
			IntPtr native_date = JNIEnv.NewString (date);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_date);
				__args [1] = new JniArgumentValue ((pos == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pos).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_date);
			}
		}

	}
}
