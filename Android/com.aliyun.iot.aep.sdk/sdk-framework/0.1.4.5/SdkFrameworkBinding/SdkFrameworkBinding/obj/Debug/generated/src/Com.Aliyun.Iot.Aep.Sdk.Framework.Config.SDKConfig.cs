using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Config {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='SDKConfig']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/config/SDKConfig", DoNotGenerateAcw=true)]
	public partial class SDKConfig : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='SDKConfig']/field[@name='sdkConfig']"
		[Register ("sdkConfig")]
		public const string SdkConfig = (string) "[\u000a    {\u000a        \"name\": \"\u57fa\u7840\u5305\",\u000a        \"doc\": \"/studiomobile-doc#homelink-base.html\",\u000a        \"classFiles\": [\u000a            {\u000a                \"className\": \"com.aliyun.iot.aep.sdk.init.BaseSDKDelegate\"\u000a            }\u000a        ],\u000a        \"opt\": {\u000a            \"china\": {\u000a                \"hosts\": {\u000a                    \"test\": \"api-performance.aliplus.com\",\u000a                    \"pre\": \"api.link.aliyun.com\",\u000a                    \"release\": \"api.link.aliyun.com\"\u000a                },\u000a                \"language\": \"zh-CN\"\u000a            },\u000a            \"singapore\": {\u000a                \"hosts\": {\u000a                    \"pre\": \"api-iot.ap-southeast-1.aliyuncs.com\",\u000a                    \"release\": \"api-iot.ap-southeast-1.aliyuncs.com\"\u000a                },\u000a                \"language\": \"en-US\"\u000a            },\u000a            \"pre\": {\u000a                \"channelHost\": \"ssl://100.67.80.75:80\",\u000a                \"autoSelectChannelHost\": \"false\",\u000a                \"isCheckChannelRootCrt\": \"false\"\u000a            },\u000a            \"test\": {\u000a                \"channelHost\": \"iot-test-daily.iot-as-mqtt.unify.aliyuncs.com:1883\",\u000a                \"autoSelectChannelHost\": \"false\",\u000a                \"isCheckChannelRootCrt\": \"false\"\u000a            },\u000a            \"release\": {\u000a                \"channelHost\": \"\",\u000a                \"autoSelectChannelHost\": \"false\",\u000a                \"isCheckChannelRootCrt\": \"true\"\u000a            }\u000a        },\u000a        \"submodules\": [\u000a            {\u000a                \"desc\": \"\u57fa\u7840\u5305\u80f6\u6c34\u4ee3\u7801\",\u000a                \"requires\": [],\u000a                \"opt\": {},\u000a                \"dependency\": [],\u000a                \"name\": \"BaseGlue\",\u000a                \"classFiles\": [\u000a                    {\u000a                        \"className\": \"com.aliyun.iot.aep.sdk.submodule.BaseSDKGlue\"\u000a                    }\u000a                ]\u000a            }\u000a        ],\u000a        \"version\": \"0.0.2\",\u000a        \"desc\": \"\u5305\u542b\u5f00\u53d1App\u548c\u5e73\u53f0\u5efa\u7acb\u8fde\u63a5\u7684\u5fc5\u8981SDK\",\u000a        \"identity\": \"\",\u000a        \"sdk_id\": 19,\u000a        \"isDefault\": true\u000a    },\u000a    {\u000a        \"name\": \"\u7528\u6237\u53ca\u8d26\u53f7\",\u000a        \"doc\": \"/studiomobile-doc#homelink-account.html\",\u000a        \"classFiles\": [\u000a            {\u000a                \"className\": \"com.aliyun.iot.aep.sdk.init.OpenAccountSDKDelegate\"\u000a            }\u000a        ],\u000a        \"opt\": {\u000a            \"sgp_host\": \"sgp-sdk.openaccount.aliyun.com\",\u000a            \"oauth_consumer_key_test\": \"\",\u000a            \"oauth_consumer_key_online\": \"\",\u000a            \"oauth_consumer_secret_test\": \"\",\u000a            \"oauth_consumer_secret_online\": \"\",\u000a            \"supportAliYun\": \"false\",\u000a            \"ui_config\": [\u000a                {\u000a                    \"activity\": \"com.aliyun.iot.aep.oa.page.OALoginActivity\",\u000a                    \"layout\": \"ali_sdk_openaccount_login2\",\u000a                    \"is_select_mobile_country\": \"false\",\u000a                    \"params\": {}\u000a                }\u000a            ]\u000a        },\u000a        \"submodules\": [\u000a            {\u000a                \"desc\": \"bone \u63d2\u4ef6\u652f\u6301\",\u000a                \"requires\": [],\u000a                \"opt\": {},\u000a                \"dependency\": [],\u000a                \"name\": \"bonePlugin\",\u000a                \"classFiles\": [\u000a                    {\u000a                        \"className\": \"com.aliyun.iot.aep.sdk.submodule.OpenAccountBoneGlue\"\u000a                    }\u000a                ]\u000a            }\u000a        ],\u000a        \"version\": \"0.0.4.0\",\u000a        \"desc\": \"\u652f\u63012\u79cd\u8d26\u53f7\u4f53\u7cfb: \u5185\u7f6e\u8d26\u53f7\u548c\u81ea\u6709\u8d26\u53f7\u4f53\u7cfb\",\u000a        \"identity\": \"account\",\u000a        \"sdk_id\": 20,\u000a        \"isDefault\": true\u000a    },\u000a    {\u000a        \"name\": \"\u8bbe\u5907\u63a7\u5236\",\u000a        \"doc\": \"/studiomobile-doc#homelink-ctrldevice.html\",\u000a        \"classFiles\": [\u000a            {\u000a                \"className\": \"com.aliyun.iot.aep.sdk.init.ThingModuleSDKDelegate\"\u000a            }\u000a        ],\u000a        \"opt\": {},\u000a        \"submodules\": [\u000a            {\u000a                \"desc\": \"Bone \u63d2\u4ef6\u652f\u6301\",\u000a                \"requires\": [],\u000a                \"opt\": {},\u000a                \"dependency\": [],\u000a                \"name\": \"bonePlugin\",\u000a                \"classFiles\": [\u000a                    {\u000a                        \"className\": \"com.aliyun.iot.aep.sdk.submodule.ThingModuleBoneGlue\"\u000a                    }\u000a                ]\u000a            }\u000a        ],\u000a        \"version\": \"1.3.1.2\",\u000a        \"desc\": \"\u63d0\u4f9b\u4e86\u8bbe\u5907\u72b6\u6001\u611f\u77e5\u53ca\u63a7\u5236\u7684\u80fd\u529b\",\u000a        \"identity\": \"\",\u000a        \"sdk_id\": 22,\u000a        \"isDefault\": true\u000a    },\u000a    {\u000a        \"name\": \"\u6dfb\u52a0\u8bbe\u5907\",\u000a        \"doc\": \"/studiomobile-doc#homelink-adddevice.html\",\u000a        \"classFiles\": [],\u000a        \"opt\": {},\u000a        \"submodules\": [\u000a            {\u000a                \"desc\": \"Bone \u63d2\u4ef6\u652f\u6301\",\u000a                \"requires\": [],\u000a                \"opt\": {},\u000a                \"dependency\": [],\u000a                \"name\": \"bonePlugin\",\u000a                \"classFiles\": [\u000a                    {\u000a                        \"className\": \"com.aliyun.iot.aep.sdk.submodule.DeviceCenterGlue\"\u000a                    }\u000a                ]\u000a            }\u000a        ],\u000a        \"version\": \"1.5.2\",\u000a        \"desc\": \"\u5305\u542b\u4e86\u5f00\u53d1\u914d\u7f51\u754c\u9762 (WiFi, \u84dd\u7259, \u4ee5\u592a\u7f51\u6216\u8702\u7a9d\u7f51\uff09\u6240\u9700\u7684SDK\u548c\u4e00\u5957\u5b8c\u6574\u793a\u4f8b\u754c\u9762\uff0c\u642d\u914d\u8bbe\u5907\u7aef\u6807\u51c6\u914d\u7f51\u65b9\u6848\u4f7f\u7528\",\u000a        \"identity\": \"\",\u000a        \"sdk_id\": 21,\u000a        \"isDefault\": true\u000a    },\u000a    {\u000a        \"name\": \"\u6d88\u606f\u63a8\u9001\",\u000a        \"doc\": \"/studiomobile-doc#homelink-push.html\",\u000a        \"classFiles\": [\u000a            {\u000a                \"className\": \"com.aliyun.iot.aep.sdk.init.PushSDKDelegate\"\u000a            }\u000a        ],\u000a        \"opt\": {\u000a            \"enable_huawei\": false,\u000a            \"enable_xiaomi\": false\u000a        },\u000a        \"submodules\": [\u000a            {\u000a                \"desc\": \"\u548c\u8d26\u53f7\u7ed1\u5b9a\",\u000a                \"requires\": [],\u000a                \"opt\": {},\u000a                \"dependency\": [],\u000a                \"name\": \"bindAccount\",\u000a                \"classFiles\": [\u000a                    {\u000a                        \"className\": \"com.aliyun.iot.aep.sdk.submodule.PushBindAccountGlue\"\u000a                    }\u000a                ]\u000a            }\u000a        ],\u000a        \"version\": \"0.0.2\",\u000a        \"desc\": \"\u63d0\u4f9b\u4e86\u6d88\u606f\u63a8\u9001\u80fd\u529b\",\u000a        \"identity\": \"push\",\u000a        \"sdk_id\": 23,\u000a        \"isDefault\": false,\u000a        \"process\": \"*\"\u000a    }\u000a]";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/config/SDKConfig", typeof (SDKConfig));
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

		protected SDKConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='SDKConfig']/constructor[@name='SDKConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SDKConfig ()
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
