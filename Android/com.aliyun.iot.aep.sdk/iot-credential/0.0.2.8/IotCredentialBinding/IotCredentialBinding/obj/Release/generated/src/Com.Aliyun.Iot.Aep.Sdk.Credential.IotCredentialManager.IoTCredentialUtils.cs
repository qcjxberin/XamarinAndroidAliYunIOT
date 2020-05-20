using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialUtils']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialUtils", DoNotGenerateAcw=true)]
	public partial class IoTCredentialUtils : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialUtils']/field[@name='CREATE_IOTTOKEN_REQUEST_PATH_ARRAY']"
		[Register ("CREATE_IOTTOKEN_REQUEST_PATH_ARRAY")]
		public static IList<string> CreateIottokenRequestPathArray {
			get {
				const string __id = "CREATE_IOTTOKEN_REQUEST_PATH_ARRAY.[Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialUtils", typeof (IoTCredentialUtils));
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

		protected IoTCredentialUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialUtils']/constructor[@name='IoTCredentialUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IoTCredentialUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialUtils']/method[@name='dataEncrypt' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("dataEncrypt", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string DataEncrypt (global::Android.Content.Context p0, string p1, string p2, string p3)
		{
			const string __id = "dataEncrypt.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialUtils']/method[@name='getIoTCredentialData' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getIoTCredentialData", "(Landroid/content/Context;)Lcom/aliyun/iot/aep/sdk/credential/data/IoTCredentialData;", "")]
		public static unsafe global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData GetIoTCredentialData (global::Android.Content.Context p0)
		{
			const string __id = "getIoTCredentialData.(Landroid/content/Context;)Lcom/aliyun/iot/aep/sdk/credential/data/IoTCredentialData;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialUtils']/method[@name='saveIoTCredentialData' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.aliyun.iot.aep.sdk.credential.data.IoTCredentialData']]"
		[Register ("saveIoTCredentialData", "(Landroid/content/Context;Lcom/aliyun/iot/aep/sdk/credential/data/IoTCredentialData;)V", "")]
		public static unsafe void SaveIoTCredentialData (global::Android.Content.Context p0, global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData p1)
		{
			const string __id = "saveIoTCredentialData.(Landroid/content/Context;Lcom/aliyun/iot/aep/sdk/credential/data/IoTCredentialData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
