using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.UT.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.device']/class[@name='UTDevice']"
	[global::Android.Runtime.Register ("com/ut/device/UTDevice", DoNotGenerateAcw=true)]
	public partial class UTDevice : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ut/device/UTDevice", typeof (UTDevice));
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

		protected UTDevice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.device']/class[@name='UTDevice']/constructor[@name='UTDevice' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UTDevice ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.device']/class[@name='UTDevice']/method[@name='getAid' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.Context']]"
		[Register ("getAid", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAid (string appName, string token, global::Android.Content.Context context)
		{
			const string __id = "getAid.(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;";
			IntPtr native_appName = JNIEnv.NewString (appName);
			IntPtr native_token = JNIEnv.NewString (token);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_appName);
				__args [1] = new JniArgumentValue (native_token);
				__args [2] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_appName);
				JNIEnv.DeleteLocalRef (native_token);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.device']/class[@name='UTDevice']/method[@name='getAidAsync' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.Context'] and parameter[4][@type='com.ut.device.a']]"
		[Register ("getAidAsync", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;Lcom/ut/device/a;)V", "")]
		public static unsafe void GetAidAsync (string appName, string token, global::Android.Content.Context context, global::Com.UT.Device.IA @callback)
		{
			const string __id = "getAidAsync.(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;Lcom/ut/device/a;)V";
			IntPtr native_appName = JNIEnv.NewString (appName);
			IntPtr native_token = JNIEnv.NewString (token);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_appName);
				__args [1] = new JniArgumentValue (native_token);
				__args [2] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_appName);
				JNIEnv.DeleteLocalRef (native_token);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.device']/class[@name='UTDevice']/method[@name='getUtdid' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUtdid", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetUtdid (global::Android.Content.Context context)
		{
			const string __id = "getUtdid.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
