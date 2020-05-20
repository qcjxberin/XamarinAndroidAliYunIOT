using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgrConfig']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/api/PluginMgrConfig", DoNotGenerateAcw=true)]
	public partial class PluginMgrConfig : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgrConfig']/field[@name='cloudChannelFactory']"
		[Register ("cloudChannelFactory")]
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactory CloudChannelFactory {
			get {
				const string __id = "cloudChannelFactory.Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/ICloudChannelFactory;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactory> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cloudChannelFactory.Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/ICloudChannelFactory;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgrConfig']/field[@name='context']"
		[Register ("context")]
		public global::Android.Content.Context Context {
			get {
				const string __id = "context.Landroid/content/Context;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "context.Landroid/content/Context;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgrConfig']/field[@name='devInfoTrans']"
		[Register ("devInfoTrans")]
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTrans DevInfoTrans {
			get {
				const string __id = "devInfoTrans.Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDevInfoTrans;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTrans> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "devInfoTrans.Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDevInfoTrans;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgrConfig']/field[@name='initData']"
		[Register ("initData")]
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalInitData InitData {
			get {
				const string __id = "initData.Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalInitData;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalInitData> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "initData.Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalInitData;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgrConfig']/field[@name='jsEngine']"
		[Register ("jsEngine")]
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Jsengine.IJSEngine JsEngine {
			get {
				const string __id = "jsEngine.Lcom/aliyun/alink/linksdk/alcs/lpbs/component/jsengine/IJSEngine;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Jsengine.IJSEngine> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "jsEngine.Lcom/aliyun/alink/linksdk/alcs/lpbs/component/jsengine/IJSEngine;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgrConfig']/field[@name='jsProvider']"
		[Register ("jsProvider")]
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IJsProvider JsProvider {
			get {
				const string __id = "jsProvider.Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IJsProvider;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IJsProvider> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "jsProvider.Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IJsProvider;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/api/PluginMgrConfig", typeof (PluginMgrConfig));
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

		protected PluginMgrConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgrConfig']/constructor[@name='PluginMgrConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PluginMgrConfig ()
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
