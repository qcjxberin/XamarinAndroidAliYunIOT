using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Api.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/api/utils/ErrorCode", DoNotGenerateAcw=true)]
	public partial class ErrorCode : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/field[@name='ERROR_CODE']"
		[Register ("ERROR_CODE")]
		public const int TheErrorCode = (int) 300;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/field[@name='ERROR_CODE_SESSIONINVALID']"
		[Register ("ERROR_CODE_SESSIONINVALID")]
		public const int ErrorCodeSessioninvalid = (int) 301;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/field[@name='ERROR_MSG']"
		[Register ("ERROR_MSG")]
		public const string ErrorMsg = (string) "errror";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/field[@name='ERROR_MSG_SESSIONINVALID']"
		[Register ("ERROR_MSG_SESSIONINVALID")]
		public const string ErrorMsgSessioninvalid = (string) "session invalid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/field[@name='PARAM_ERR']"
		[Register ("PARAM_ERR")]
		public const string ParamErr = (string) "1000.01";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/field[@name='PARAM_ERR_DESC']"
		[Register ("PARAM_ERR_DESC")]
		public const string ParamErrDesc = (string) "param is invalid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/field[@name='PEER_ILLEGAL_ERR']"
		[Register ("PEER_ILLEGAL_ERR")]
		public const string PeerIllegalErr = (string) "1000.03";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/field[@name='PEER_ILLEGAL_ERR_DESC']"
		[Register ("PEER_ILLEGAL_ERR_DESC")]
		public const string PeerIllegalErrDesc = (string) "peer illegal";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/field[@name='REQUEST_ERR']"
		[Register ("REQUEST_ERR")]
		public const string RequestErr = (string) "1000.02";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/field[@name='REQUEST_ERR_DESC']"
		[Register ("REQUEST_ERR_DESC")]
		public const string RequestErrDesc = (string) "request error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/field[@name='RESPONSE_ERR']"
		[Register ("RESPONSE_ERR")]
		public const string ResponseErr = (string) "1000.04";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/field[@name='RESPONSE_ERR_DESC']"
		[Register ("RESPONSE_ERR_DESC")]
		public const string ResponseErrDesc = (string) "response error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/field[@name='SUCCESS_CODE']"
		[Register ("SUCCESS_CODE")]
		public const int SuccessCode = (int) 200;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/field[@name='SUCCESS_MSG']"
		[Register ("SUCCESS_MSG")]
		public const string SuccessMsg = (string) "success";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/field[@name='TASKFLOW_ERR']"
		[Register ("TASKFLOW_ERR")]
		public const string TaskflowErr = (string) "1000.05";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/field[@name='TASKFLOW_ERR_DESC']"
		[Register ("TASKFLOW_ERR_DESC")]
		public const string TaskflowErrDesc = (string) "task flow error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/field[@name='UNKNOWN_ERR']"
		[Register ("UNKNOWN_ERR")]
		public const string UnknownErr = (string) "1000.00";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/field[@name='UNKNOWN_ERROR_CODE']"
		[Register ("UNKNOWN_ERROR_CODE")]
		public const string UnknownErrorCode = (string) "300";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/field[@name='UNKNOWN_ERR_DESC']"
		[Register ("UNKNOWN_ERR_DESC")]
		public const string UnknownErrDesc = (string) "unknown error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/field[@name='UNKNOWN_SUCCESS_CODE']"
		[Register ("UNKNOWN_SUCCESS_CODE")]
		public const string UnknownSuccessCode = (string) "200";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/api/utils/ErrorCode", typeof (ErrorCode));
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

		protected ErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='ErrorCode']/constructor[@name='ErrorCode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ErrorCode ()
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
