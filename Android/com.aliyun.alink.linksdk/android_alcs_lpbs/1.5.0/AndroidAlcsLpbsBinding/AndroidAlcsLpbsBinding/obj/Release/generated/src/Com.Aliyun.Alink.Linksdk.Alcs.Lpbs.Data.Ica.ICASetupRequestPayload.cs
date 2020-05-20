using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.Ica {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica']/class[@name='ICASetupRequestPayload']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/data/ica/ICASetupRequestPayload", DoNotGenerateAcw=true)]
	public partial class ICASetupRequestPayload : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica']/class[@name='ICASetupRequestPayload']/field[@name='id']"
		[Register ("id")]
		public string Id {
			get {
				const string __id = "id.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "id.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica']/class[@name='ICASetupRequestPayload']/field[@name='method']"
		[Register ("method")]
		public string Method {
			get {
				const string __id = "method.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "method.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica']/class[@name='ICASetupRequestPayload']/field[@name='params']"
		[Register ("params")]
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.Ica.ICASetupRequestPayload.ICASetupData Params {
			get {
				const string __id = "params.Lcom/aliyun/alink/linksdk/alcs/lpbs/data/ica/ICASetupRequestPayload$ICASetupData;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.Ica.ICASetupRequestPayload.ICASetupData> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "params.Lcom/aliyun/alink/linksdk/alcs/lpbs/data/ica/ICASetupRequestPayload$ICASetupData;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica']/class[@name='ICASetupRequestPayload']/field[@name='version']"
		[Register ("version")]
		public string Version {
			get {
				const string __id = "version.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "version.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica']/class[@name='ICASetupRequestPayload.ICAProvisionAuthData']"
		[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/data/ica/ICASetupRequestPayload$ICAProvisionAuthData", DoNotGenerateAcw=true)]
		public partial class ICAProvisionAuthData : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica']/class[@name='ICASetupRequestPayload.ICAProvisionAuthData']/field[@name='accessKey']"
			[Register ("accessKey")]
			public string AccessKey {
				get {
					const string __id = "accessKey.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "accessKey.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica']/class[@name='ICASetupRequestPayload.ICAProvisionAuthData']/field[@name='accessToken']"
			[Register ("accessToken")]
			public string AccessToken {
				get {
					const string __id = "accessToken.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "accessToken.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica']/class[@name='ICASetupRequestPayload.ICAProvisionAuthData']/field[@name='authCode']"
			[Register ("authCode")]
			public string AuthCode {
				get {
					const string __id = "authCode.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "authCode.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica']/class[@name='ICASetupRequestPayload.ICAProvisionAuthData']/field[@name='authSecret']"
			[Register ("authSecret")]
			public string AuthSecret {
				get {
					const string __id = "authSecret.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "authSecret.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica']/class[@name='ICASetupRequestPayload.ICAProvisionAuthData']/field[@name='deviceName']"
			[Register ("deviceName")]
			public string DeviceName {
				get {
					const string __id = "deviceName.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "deviceName.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica']/class[@name='ICASetupRequestPayload.ICAProvisionAuthData']/field[@name='productKey']"
			[Register ("productKey")]
			public string ProductKey {
				get {
					const string __id = "productKey.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "productKey.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/data/ica/ICASetupRequestPayload$ICAProvisionAuthData", typeof (ICAProvisionAuthData));
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

			protected ICAProvisionAuthData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica']/class[@name='ICASetupRequestPayload.ICAProvisionAuthData']/constructor[@name='ICASetupRequestPayload.ICAProvisionAuthData' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ICAProvisionAuthData ()
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica']/class[@name='ICASetupRequestPayload.ICASetupData']"
		[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/data/ica/ICASetupRequestPayload$ICASetupData", DoNotGenerateAcw=true)]
		public partial class ICASetupData : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica']/class[@name='ICASetupRequestPayload.ICASetupData']/field[@name='configType']"
			[Register ("configType")]
			public string ConfigType {
				get {
					const string __id = "configType.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "configType.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica']/class[@name='ICASetupRequestPayload.ICASetupData']/field[@name='configValue']"
			[Register ("configValue")]
			public global::System.Collections.IList ConfigValue {
				get {
					const string __id = "configValue.Ljava/util/List;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "configValue.Ljava/util/List;";

					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/data/ica/ICASetupRequestPayload$ICASetupData", typeof (ICASetupData));
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

			protected ICASetupData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica']/class[@name='ICASetupRequestPayload.ICASetupData']/constructor[@name='ICASetupRequestPayload.ICASetupData' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ICASetupData ()
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

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/data/ica/ICASetupRequestPayload", typeof (ICASetupRequestPayload));
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

		protected ICASetupRequestPayload (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica']/class[@name='ICASetupRequestPayload']/constructor[@name='ICASetupRequestPayload' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ICASetupRequestPayload ()
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

	}
}
