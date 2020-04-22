using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Region {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionManager']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/region/RegionManager", DoNotGenerateAcw=true)]
	public partial class RegionManager : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/region/RegionManager", typeof (RegionManager));
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

		protected RegionManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionManager']/constructor[@name='RegionManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RegionManager ()
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

		public static unsafe string StoredApiAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionManager']/method[@name='getStoredApiAddress' and count(parameter)=0]"
			[Register ("getStoredApiAddress", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getStoredApiAddress.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string StoredMqttAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionManager']/method[@name='getStoredMqttAddress' and count(parameter)=0]"
			[Register ("getStoredMqttAddress", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getStoredMqttAddress.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string StoredOAAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionManager']/method[@name='getStoredOAAddress' and count(parameter)=0]"
			[Register ("getStoredOAAddress", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getStoredOAAddress.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string StoredPushAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionManager']/method[@name='getStoredPushAddress' and count(parameter)=0]"
			[Register ("getStoredPushAddress", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getStoredPushAddress.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionInfo StoredRegion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionManager']/method[@name='getStoredRegion' and count(parameter)=0]"
			[Register ("getStoredRegion", "()Lcom/aliyun/iot/aep/sdk/framework/region/RegionInfo;", "")]
			get {
				const string __id = "getStoredRegion.()Lcom/aliyun/iot/aep/sdk/framework/region/RegionInfo;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string StoredRegionName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionManager']/method[@name='getStoredRegionName' and count(parameter)=0]"
			[Register ("getStoredRegionName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getStoredRegionName.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionManager']/method[@name='doInitAfterRegionChange' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.framework.region.RegionInfo']]"
		[Register ("doInitAfterRegionChange", "(Lcom/aliyun/iot/aep/sdk/framework/region/RegionInfo;)V", "")]
		public static unsafe void DoInitAfterRegionChange (global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionInfo region)
		{
			const string __id = "doInitAfterRegionChange.(Lcom/aliyun/iot/aep/sdk/framework/region/RegionInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((region == null) ? IntPtr.Zero : ((global::Java.Lang.Object) region).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionManager']/method[@name='queryLoginRegion' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.aliyun.iot.aep.sdk.framework.base.ApiDataCallBack']]"
		[Register ("queryLoginRegion", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V", "")]
		public static unsafe void QueryLoginRegion (string type, string id, string phoneLocationCode, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Base.ApiDataCallBack callBack)
		{
			const string __id = "queryLoginRegion.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V";
			IntPtr native_type = JNIEnv.NewString (type);
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_phoneLocationCode = JNIEnv.NewString (phoneLocationCode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_type);
				__args [1] = new JniArgumentValue (native_id);
				__args [2] = new JniArgumentValue (native_phoneLocationCode);
				__args [3] = new JniArgumentValue ((callBack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callBack).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_type);
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_phoneLocationCode);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionManager']/method[@name='queryRegRegion' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.framework.base.ApiDataCallBack']]"
		[Register ("queryRegRegion", "(Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V", "")]
		public static unsafe void QueryRegRegion (global::Com.Aliyun.Iot.Aep.Sdk.Framework.Base.ApiDataCallBack callBack)
		{
			const string __id = "queryRegRegion.(Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((callBack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callBack).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionManager']/method[@name='queryThirdLoginRegion' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.aliyun.iot.aep.sdk.framework.base.ApiDataCallBack']]"
		[Register ("queryThirdLoginRegion", "(Ljava/lang/String;Ljava/lang/String;Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V", "")]
		public static unsafe void QueryThirdLoginRegion (string type, string authCode, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Base.ApiDataCallBack callBack)
		{
			const string __id = "queryThirdLoginRegion.(Ljava/lang/String;Ljava/lang/String;Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V";
			IntPtr native_type = JNIEnv.NewString (type);
			IntPtr native_authCode = JNIEnv.NewString (authCode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_type);
				__args [1] = new JniArgumentValue (native_authCode);
				__args [2] = new JniArgumentValue ((callBack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callBack).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_type);
				JNIEnv.DeleteLocalRef (native_authCode);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionManager']/method[@name='registerOAApiHook' and count(parameter)=0]"
		[Register ("registerOAApiHook", "()V", "")]
		public static unsafe void RegisterOAApiHook ()
		{
			const string __id = "registerOAApiHook.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionManager']/method[@name='setRegionChina' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.framework.base.ApiDataCallBack']]"
		[Register ("setRegionChina", "(Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V", "")]
		public static unsafe void SetRegionChina (global::Com.Aliyun.Iot.Aep.Sdk.Framework.Base.ApiDataCallBack callBack)
		{
			const string __id = "setRegionChina.(Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((callBack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callBack).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionManager']/method[@name='setRegionSingapore' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.framework.base.ApiDataCallBack']]"
		[Register ("setRegionSingapore", "(Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V", "")]
		public static unsafe void SetRegionSingapore (global::Com.Aliyun.Iot.Aep.Sdk.Framework.Base.ApiDataCallBack callBack)
		{
			const string __id = "setRegionSingapore.(Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((callBack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callBack).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
