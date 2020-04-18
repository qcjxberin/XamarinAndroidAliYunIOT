using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='BaseApiClient']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/network/BaseApiClient", DoNotGenerateAcw=true)]
	public partial class BaseApiClient : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/network/BaseApiClient", typeof (BaseApiClient));
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

		protected BaseApiClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='BaseApiClient']/constructor[@name='BaseApiClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseApiClient ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='BaseApiClient']/method[@name='send' and count(parameter)=2 and parameter[1][@type='com.aliyun.iot.aep.sdk.framework.network.ILopRequest'] and parameter[2][@type='com.aliyun.iot.aep.sdk.framework.base.ApiDataCallBack']]"
		[Register ("send", "(Lcom/aliyun/iot/aep/sdk/framework/network/ILopRequest;Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V", "")]
		public static unsafe void Send (global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest req, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Base.ApiDataCallBack dataCallBack)
		{
			const string __id = "send.(Lcom/aliyun/iot/aep/sdk/framework/network/ILopRequest;Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((req == null) ? IntPtr.Zero : ((global::Java.Lang.Object) req).Handle);
				__args [1] = new JniArgumentValue ((dataCallBack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataCallBack).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='BaseApiClient']/method[@name='send' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.aliyun.iot.aep.sdk.framework.network.BaseRequest'] and parameter[4][@type='com.aliyun.iot.aep.sdk.framework.base.ApiDataCallBack']]"
		[Register ("send", "(Ljava/lang/String;Ljava/lang/String;Lcom/aliyun/iot/aep/sdk/framework/network/BaseRequest;Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V", "")]
		public static unsafe void Send (string path, string version, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.BaseRequest req, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Base.ApiDataCallBack dataCallBack)
		{
			const string __id = "send.(Ljava/lang/String;Ljava/lang/String;Lcom/aliyun/iot/aep/sdk/framework/network/BaseRequest;Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			IntPtr native_version = JNIEnv.NewString (version);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (native_version);
				__args [2] = new JniArgumentValue ((req == null) ? IntPtr.Zero : ((global::Java.Lang.Object) req).Handle);
				__args [3] = new JniArgumentValue ((dataCallBack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataCallBack).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				JNIEnv.DeleteLocalRef (native_version);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='BaseApiClient']/method[@name='send' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.aliyun.iot.aep.sdk.framework.network.BaseRequest'] and parameter[6][@type='com.aliyun.iot.aep.sdk.framework.base.ApiDataCallBack']]"
		[Register ("send", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/aliyun/iot/aep/sdk/framework/network/BaseRequest;Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V", "")]
		public static unsafe void Send (string host, string path, string version, string authType, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.BaseRequest req, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Base.ApiDataCallBack dataCallBack)
		{
			const string __id = "send.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/aliyun/iot/aep/sdk/framework/network/BaseRequest;Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V";
			IntPtr native_host = JNIEnv.NewString (host);
			IntPtr native_path = JNIEnv.NewString (path);
			IntPtr native_version = JNIEnv.NewString (version);
			IntPtr native_authType = JNIEnv.NewString (authType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_host);
				__args [1] = new JniArgumentValue (native_path);
				__args [2] = new JniArgumentValue (native_version);
				__args [3] = new JniArgumentValue (native_authType);
				__args [4] = new JniArgumentValue ((req == null) ? IntPtr.Zero : ((global::Java.Lang.Object) req).Handle);
				__args [5] = new JniArgumentValue ((dataCallBack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataCallBack).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
				JNIEnv.DeleteLocalRef (native_path);
				JNIEnv.DeleteLocalRef (native_version);
				JNIEnv.DeleteLocalRef (native_authType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='BaseApiClient']/method[@name='send' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[4][@type='com.aliyun.iot.aep.sdk.framework.base.ApiDataCallBack']]"
		[Register ("send", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V", "")]
		public static unsafe void Send (string path, string apiVersion, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> @params, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Base.ApiDataCallBack dataCallBack)
		{
			const string __id = "send.(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			IntPtr native_apiVersion = JNIEnv.NewString (apiVersion);
			IntPtr native__params = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (@params);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (native_apiVersion);
				__args [2] = new JniArgumentValue (native__params);
				__args [3] = new JniArgumentValue ((dataCallBack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataCallBack).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				JNIEnv.DeleteLocalRef (native_apiVersion);
				JNIEnv.DeleteLocalRef (native__params);
			}
		}

	}
}
