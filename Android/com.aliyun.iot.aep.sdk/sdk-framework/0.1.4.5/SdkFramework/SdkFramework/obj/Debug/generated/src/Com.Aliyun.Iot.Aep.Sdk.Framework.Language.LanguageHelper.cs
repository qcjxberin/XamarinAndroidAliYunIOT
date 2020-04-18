using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Language {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.language']/class[@name='LanguageHelper']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/language/LanguageHelper", DoNotGenerateAcw=true)]
	public partial class LanguageHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/language/LanguageHelper", typeof (LanguageHelper));
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

		protected LanguageHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.language']/class[@name='LanguageHelper']/constructor[@name='LanguageHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LanguageHelper ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.language']/class[@name='LanguageHelper']/method[@name='LoadLanguageInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("LoadLanguageInfo", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] LoadLanguageInfo (string var0)
		{
			const string __id = "LoadLanguageInfo.(Ljava/lang/String;)[Ljava/lang/String;";
			IntPtr native_var0 = JNIEnv.NewString (var0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_var0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				JNIEnv.DeleteLocalRef (native_var0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.language']/class[@name='LanguageHelper']/method[@name='MakeLanguageString' and count(parameter)=1 and parameter[1][@type='java.util.Locale']]"
		[Register ("MakeLanguageString", "(Ljava/util/Locale;)Ljava/lang/String;", "")]
		public static unsafe string MakeLanguageString (global::Java.Util.Locale var0)
		{
			const string __id = "MakeLanguageString.(Ljava/util/Locale;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((var0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) var0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
