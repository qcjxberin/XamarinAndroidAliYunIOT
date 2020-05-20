using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAConnectParams']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/data/ica/ICAConnectParams", DoNotGenerateAcw=true)]
	public partial class ICAConnectParams : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAConnectParams']/field[@name='authInfo']"
		[Register ("authInfo")]
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAAuthParams AuthInfo {
			get {
				const string __id = "authInfo.Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAAuthParams;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAAuthParams> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "authInfo.Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAAuthParams;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAConnectParams']/field[@name='deviceInfo']"
		[Register ("deviceInfo")]
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo DeviceInfo {
			get {
				const string __id = "deviceInfo.Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "deviceInfo.Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAConnectParams']/field[@name='pal']"
		[Register ("pal")]
		public string Pal {
			get {
				const string __id = "pal.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pal.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/data/ica/ICAConnectParams", typeof (ICAConnectParams));
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

		protected ICAConnectParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAConnectParams']/constructor[@name='ICAConnectParams' and count(parameter)=3 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICADeviceInfo'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICAAuthParams']]"
		[Register (".ctor", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;Ljava/lang/String;Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAAuthParams;)V", "")]
		public unsafe ICAConnectParams (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo deviceInfo, string pal, global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAAuthParams authInfo)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;Ljava/lang/String;Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAAuthParams;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_pal = JNIEnv.NewString (pal);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((deviceInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deviceInfo).Handle);
				__args [1] = new JniArgumentValue (native_pal);
				__args [2] = new JniArgumentValue ((authInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authInfo).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pal);
			}
		}

	}
}
