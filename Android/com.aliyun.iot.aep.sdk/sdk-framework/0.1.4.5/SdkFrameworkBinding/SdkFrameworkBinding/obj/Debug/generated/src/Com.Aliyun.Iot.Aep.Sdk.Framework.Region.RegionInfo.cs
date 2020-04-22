using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Region {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionInfo']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/region/RegionInfo", DoNotGenerateAcw=true)]
	public partial class RegionInfo : global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.BaseResponse {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionInfo']/field[@name='apiGatewayEndpoint']"
		[Register ("apiGatewayEndpoint")]
		public string ApiGatewayEndpoint {
			get {
				const string __id = "apiGatewayEndpoint.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "apiGatewayEndpoint.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionInfo']/field[@name='mqttEndpoint']"
		[Register ("mqttEndpoint")]
		public string MqttEndpoint {
			get {
				const string __id = "mqttEndpoint.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mqttEndpoint.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionInfo']/field[@name='oaApiGatewayEndpoint']"
		[Register ("oaApiGatewayEndpoint")]
		public string OaApiGatewayEndpoint {
			get {
				const string __id = "oaApiGatewayEndpoint.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "oaApiGatewayEndpoint.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionInfo']/field[@name='pushChannelEndpoint']"
		[Register ("pushChannelEndpoint")]
		public string PushChannelEndpoint {
			get {
				const string __id = "pushChannelEndpoint.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pushChannelEndpoint.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionInfo']/field[@name='regionEnglishName']"
		[Register ("regionEnglishName")]
		public string RegionEnglishName {
			get {
				const string __id = "regionEnglishName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "regionEnglishName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionInfo']/field[@name='regionId']"
		[Register ("regionId")]
		public string RegionId {
			get {
				const string __id = "regionId.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "regionId.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/region/RegionInfo", typeof (RegionInfo));
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

		protected RegionInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionInfo']/constructor[@name='RegionInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RegionInfo ()
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

		static Delegate cb_isEqual_Lcom_aliyun_iot_aep_sdk_framework_region_RegionInfo_;
#pragma warning disable 0169
		static Delegate GetIsEqual_Lcom_aliyun_iot_aep_sdk_framework_region_RegionInfo_Handler ()
		{
			if (cb_isEqual_Lcom_aliyun_iot_aep_sdk_framework_region_RegionInfo_ == null)
				cb_isEqual_Lcom_aliyun_iot_aep_sdk_framework_region_RegionInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsEqual_Lcom_aliyun_iot_aep_sdk_framework_region_RegionInfo_);
			return cb_isEqual_Lcom_aliyun_iot_aep_sdk_framework_region_RegionInfo_;
		}

		static bool n_IsEqual_Lcom_aliyun_iot_aep_sdk_framework_region_RegionInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_regionInfo)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionInfo __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionInfo regionInfo = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionInfo> (native_regionInfo, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsEqual (regionInfo);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionInfo']/method[@name='isEqual' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.framework.region.RegionInfo']]"
		[Register ("isEqual", "(Lcom/aliyun/iot/aep/sdk/framework/region/RegionInfo;)Z", "GetIsEqual_Lcom_aliyun_iot_aep_sdk_framework_region_RegionInfo_Handler")]
		public virtual unsafe bool IsEqual (global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionInfo regionInfo)
		{
			const string __id = "isEqual.(Lcom/aliyun/iot/aep/sdk/framework/region/RegionInfo;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((regionInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) regionInfo).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
