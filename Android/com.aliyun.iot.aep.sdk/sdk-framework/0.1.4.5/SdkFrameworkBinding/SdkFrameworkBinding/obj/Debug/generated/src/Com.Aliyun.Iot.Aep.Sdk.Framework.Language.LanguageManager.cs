using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Language {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.language']/class[@name='LanguageManager']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/language/LanguageManager", DoNotGenerateAcw=true)]
	public partial class LanguageManager : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/language/LanguageManager", typeof (LanguageManager));
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

		protected LanguageManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.language']/class[@name='LanguageManager']/constructor[@name='LanguageManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LanguageManager ()
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

		public static unsafe global::Java.Util.Locale AppLocal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.language']/class[@name='LanguageManager']/method[@name='GetAppLocal' and count(parameter)=0]"
			[Register ("GetAppLocal", "()Ljava/util/Locale;", "")]
			get {
				const string __id = "GetAppLocal.()Ljava/util/Locale;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string DefaultLanguage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.language']/class[@name='LanguageManager']/method[@name='getDefaultLanguage' and count(parameter)=0]"
			[Register ("getDefaultLanguage", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDefaultLanguage.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Java.Util.Locale SysLocale {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.language']/class[@name='LanguageManager']/method[@name='GetSysLocale' and count(parameter)=0]"
			[Register ("GetSysLocale", "()Ljava/util/Locale;", "")]
			get {
				const string __id = "GetSysLocale.()Ljava/util/Locale;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.language']/class[@name='LanguageManager']/method[@name='handleLanguageChanged' and count(parameter)=0]"
		[Register ("handleLanguageChanged", "()V", "")]
		public static unsafe void HandleLanguageChanged ()
		{
			const string __id = "handleLanguageChanged.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.language']/class[@name='LanguageManager']/method[@name='initAppLanguage' and count(parameter)=0]"
		[Register ("initAppLanguage", "()V", "")]
		public static unsafe void InitAppLanguage ()
		{
			const string __id = "initAppLanguage.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.language']/class[@name='LanguageManager']/method[@name='loadAppLanguage' and count(parameter)=0]"
		[Register ("loadAppLanguage", "()Ljava/lang/String;", "")]
		public static unsafe string LoadAppLanguage ()
		{
			const string __id = "loadAppLanguage.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.language']/class[@name='LanguageManager']/method[@name='loadLanguageInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadLanguageInfo", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] LoadLanguageInfo (string language)
		{
			const string __id = "loadLanguageInfo.(Ljava/lang/String;)[Ljava/lang/String;";
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_language);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				JNIEnv.DeleteLocalRef (native_language);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.language']/class[@name='LanguageManager']/method[@name='makeLanguageString' and count(parameter)=1 and parameter[1][@type='java.util.Locale']]"
		[Register ("makeLanguageString", "(Ljava/util/Locale;)Ljava/lang/String;", "")]
		public static unsafe string MakeLanguageString (global::Java.Util.Locale locale)
		{
			const string __id = "makeLanguageString.(Ljava/util/Locale;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((locale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) locale).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.language']/class[@name='LanguageManager']/method[@name='needSwitchLanguage' and count(parameter)=0]"
		[Register ("needSwitchLanguage", "()Z", "")]
		public static unsafe bool NeedSwitchLanguage ()
		{
			const string __id = "needSwitchLanguage.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.language']/class[@name='LanguageManager']/method[@name='replaceLanguage' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("replaceLanguage", "(Landroid/content/Context;)Landroid/content/Context;", "")]
		public static unsafe global::Android.Content.Context ReplaceLanguage (global::Android.Content.Context newBase)
		{
			const string __id = "replaceLanguage.(Landroid/content/Context;)Landroid/content/Context;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newBase == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newBase).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.language']/class[@name='LanguageManager']/method[@name='setLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setLanguage", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetLanguage (string language)
		{
			const string __id = "setLanguage.(Ljava/lang/String;)V";
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_language);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_language);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.language']/class[@name='LanguageManager']/method[@name='updateApplicationLanguage' and count(parameter)=1 and parameter[1][@type='android.content.res.Resources']]"
		[Register ("updateApplicationLanguage", "(Landroid/content/res/Resources;)V", "")]
		public static unsafe void UpdateApplicationLanguage (global::Android.Content.Res.Resources applicationResource)
		{
			const string __id = "updateApplicationLanguage.(Landroid/content/res/Resources;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((applicationResource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) applicationResource).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
