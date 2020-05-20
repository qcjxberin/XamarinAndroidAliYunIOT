using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalConst']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/api/AlcsPalConst", DoNotGenerateAcw=true)]
	public partial class AlcsPalConst : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalConst']/field[@name='DATA_FORMAT_ALINK']"
		[Register ("DATA_FORMAT_ALINK")]
		public const string DataFormatAlink = (string) "ALINK_FORMAT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalConst']/field[@name='DATA_FORMAT_CUNSTOM']"
		[Register ("DATA_FORMAT_CUNSTOM")]
		public const string DataFormatCunstom = (string) "CUSTOM_FORMAT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalConst']/field[@name='DATA_FORMAT_UNKNOWN']"
		[Register ("DATA_FORMAT_UNKNOWN")]
		public const string DataFormatUnknown = (string) "UNKNOWN_FORMAT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalConst']/field[@name='ICA_PAL_ID']"
		[Register ("ICA_PAL_ID")]
		public const string IcaPalId = (string) "LPBSBridgeImplIca";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalConst']/field[@name='ICA_PLUGIN_ID']"
		[Register ("ICA_PLUGIN_ID")]
		public const string IcaPluginId = (string) "iot_ica";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalConst']/field[@name='MODEL_TYPE_ALI_BREEZE']"
		[Register ("MODEL_TYPE_ALI_BREEZE")]
		public const string ModelTypeAliBreeze = (string) "2";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalConst']/field[@name='MODEL_TYPE_ALI_THIRD_PART']"
		[Register ("MODEL_TYPE_ALI_THIRD_PART")]
		public const string ModelTypeAliThirdPart = (string) "3";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalConst']/field[@name='MODEL_TYPE_ALI_WIFI']"
		[Register ("MODEL_TYPE_ALI_WIFI")]
		public const string ModelTypeAliWifi = (string) "1";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalConst']/field[@name='MODEL_TYPE_UNKNOWN']"
		[Register ("MODEL_TYPE_UNKNOWN")]
		public const string ModelTypeUnknown = (string) "0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalConst']/field[@name='PAL_RESULT_DUPLICATE']"
		[Register ("PAL_RESULT_DUPLICATE")]
		public const int PalResultDuplicate = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalConst']/field[@name='PAL_RESULT_FAIL']"
		[Register ("PAL_RESULT_FAIL")]
		public const int PalResultFail = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalConst']/field[@name='PAL_RESULT_INSUFFICIENT_MEM']"
		[Register ("PAL_RESULT_INSUFFICIENT_MEM")]
		public const int PalResultInsufficientMem = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalConst']/field[@name='PAL_RESULT_INVALIDPARAM']"
		[Register ("PAL_RESULT_INVALIDPARAM")]
		public const int PalResultInvalidparam = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalConst']/field[@name='PAL_RESULT_NOTFOUND']"
		[Register ("PAL_RESULT_NOTFOUND")]
		public const int PalResultNotfound = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalConst']/field[@name='PAL_RESULT_OK']"
		[Register ("PAL_RESULT_OK")]
		public const int PalResultOk = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalConst']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "[AlcsLPBS]";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/api/AlcsPalConst", typeof (AlcsPalConst));
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

		protected AlcsPalConst (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalConst']/constructor[@name='AlcsPalConst' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AlcsPalConst ()
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
