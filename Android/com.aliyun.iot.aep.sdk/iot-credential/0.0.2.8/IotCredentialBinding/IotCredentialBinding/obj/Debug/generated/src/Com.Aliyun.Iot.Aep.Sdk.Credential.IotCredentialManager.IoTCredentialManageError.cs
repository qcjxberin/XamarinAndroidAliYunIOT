using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageError']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialManageError", DoNotGenerateAcw=true)]
	public partial class IoTCredentialManageError : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageError']/field[@name='RESULT_CODE_ACCOUNT_TYPE_INVALID']"
		[Register ("RESULT_CODE_ACCOUNT_TYPE_INVALID")]
		public const int ResultCodeAccountTypeInvalid = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageError']/field[@name='RESULT_CODE_AUTHCODE_CHECK_FAILED']"
		[Register ("RESULT_CODE_AUTHCODE_CHECK_FAILED")]
		public const int ResultCodeAuthcodeCheckFailed = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageError']/field[@name='RESULT_CODE_AUTHCODE_INVALID']"
		[Register ("RESULT_CODE_AUTHCODE_INVALID")]
		public const int ResultCodeAuthcodeInvalid = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageError']/field[@name='RESULT_CODE_COMPANYID_PARAMS_CHECK_FAILED']"
		[Register ("RESULT_CODE_COMPANYID_PARAMS_CHECK_FAILED")]
		public const int ResultCodeCompanyidParamsCheckFailed = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageError']/field[@name='RESULT_CODE_NOT_LOGIN']"
		[Register ("RESULT_CODE_NOT_LOGIN")]
		public const int ResultCodeNotLogin = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageError']/field[@name='RESULT_CODE_OHTER']"
		[Register ("RESULT_CODE_OHTER")]
		public const int ResultCodeOhter = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageError']/field[@name='RESULT_CODE_REFRESHTOKEN_INVALID']"
		[Register ("RESULT_CODE_REFRESHTOKEN_INVALID")]
		public const int ResultCodeRefreshtokenInvalid = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageError']/field[@name='RESULT_CODE_WRONG_RESPONSE_FORMAT']"
		[Register ("RESULT_CODE_WRONG_RESPONSE_FORMAT")]
		public const int ResultCodeWrongResponseFormat = (int) 4;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageError']/field[@name='detail']"
		[Register ("detail")]
		public global::Java.Lang.Object Detail {
			get {
				const string __id = "detail.Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "detail.Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageError']/field[@name='errorCode']"
		[Register ("errorCode")]
		public int ErrorCode {
			get {
				const string __id = "errorCode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "errorCode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialManageError", typeof (IoTCredentialManageError));
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

		protected IoTCredentialManageError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageError']/constructor[@name='IoTCredentialManageError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register (".ctor", "(ILjava/lang/Object;)V", "")]
		public unsafe IoTCredentialManageError (int p0, global::Java.Lang.Object p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
