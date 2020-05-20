using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAInitData']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/data/ica/ICAInitData", DoNotGenerateAcw=true)]
	public partial class ICAInitData : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAInitData']/field[@name='deviceInfo']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAInitData']/field[@name='role']"
		[Register ("role")]
		public int Role {
			get {
				const string __id = "role.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "role.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/data/ica/ICAInitData", typeof (ICAInitData));
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

		protected ICAInitData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAInitData']/constructor[@name='ICAInitData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe ICAInitData (string productKey, string deviceName, int role)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_productKey = JNIEnv.NewString (productKey);
			IntPtr native_deviceName = JNIEnv.NewString (deviceName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_productKey);
				__args [1] = new JniArgumentValue (native_deviceName);
				__args [2] = new JniArgumentValue (role);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_productKey);
				JNIEnv.DeleteLocalRef (native_deviceName);
			}
		}

	}
}
