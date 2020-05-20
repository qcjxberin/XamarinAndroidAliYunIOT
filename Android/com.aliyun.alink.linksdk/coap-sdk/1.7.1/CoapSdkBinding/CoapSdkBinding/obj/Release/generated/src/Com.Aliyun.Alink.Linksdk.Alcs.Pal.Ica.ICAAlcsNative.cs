using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Pal.Ica {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/pal/ica/ICAAlcsNative", DoNotGenerateAcw=true)]
	public partial class ICAAlcsNative : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/field[@name='ALCS_DISCOVERY_TYPE_FINISH']"
		[Register ("ALCS_DISCOVERY_TYPE_FINISH")]
		public const int AlcsDiscoveryTypeFinish = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/field[@name='ALCS_DISCOVERY_TYPE_FOUND']"
		[Register ("ALCS_DISCOVERY_TYPE_FOUND")]
		public const int AlcsDiscoveryTypeFound = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/field[@name='ALCS_MSG_CODE_DELETE']"
		[Register ("ALCS_MSG_CODE_DELETE")]
		public const int AlcsMsgCodeDelete = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/field[@name='ALCS_MSG_CODE_GET']"
		[Register ("ALCS_MSG_CODE_GET")]
		public const int AlcsMsgCodeGet = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/field[@name='ALCS_MSG_CODE_POST']"
		[Register ("ALCS_MSG_CODE_POST")]
		public const int AlcsMsgCodePost = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/field[@name='ALCS_MSG_CODE_PUT']"
		[Register ("ALCS_MSG_CODE_PUT")]
		public const int AlcsMsgCodePut = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/field[@name='ALCS_MSG_TYPE_ACK']"
		[Register ("ALCS_MSG_TYPE_ACK")]
		public const int AlcsMsgTypeAck = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/field[@name='ALCS_MSG_TYPE_CON']"
		[Register ("ALCS_MSG_TYPE_CON")]
		public const int AlcsMsgTypeCon = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/field[@name='ALCS_MSG_TYPE_NON']"
		[Register ("ALCS_MSG_TYPE_NON")]
		public const int AlcsMsgTypeNon = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/field[@name='ALCS_MSG_TYPE_RST']"
		[Register ("ALCS_MSG_TYPE_RST")]
		public const int AlcsMsgTypeRst = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/field[@name='ALCS_RESULT_DUPLICATE']"
		[Register ("ALCS_RESULT_DUPLICATE")]
		public const int AlcsResultDuplicate = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/field[@name='ALCS_RESULT_FAIL']"
		[Register ("ALCS_RESULT_FAIL")]
		public const int AlcsResultFail = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/field[@name='ALCS_RESULT_INSUFFICIENT_MEM']"
		[Register ("ALCS_RESULT_INSUFFICIENT_MEM")]
		public const int AlcsResultInsufficientMem = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/field[@name='ALCS_RESULT_INVALIDPARAM']"
		[Register ("ALCS_RESULT_INVALIDPARAM")]
		public const int AlcsResultInvalidparam = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/field[@name='ALCS_RESULT_NOTFOUND']"
		[Register ("ALCS_RESULT_NOTFOUND")]
		public const int AlcsResultNotfound = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/field[@name='ALCS_RESULT_OK']"
		[Register ("ALCS_RESULT_OK")]
		public const int AlcsResultOk = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/field[@name='ALCS_ROLE_BOTH']"
		[Register ("ALCS_ROLE_BOTH")]
		public const int AlcsRoleBoth = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/field[@name='ALCS_ROLE_CLIENT']"
		[Register ("ALCS_ROLE_CLIENT")]
		public const int AlcsRoleClient = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/field[@name='ALCS_ROLE_SERVER']"
		[Register ("ALCS_ROLE_SERVER")]
		public const int AlcsRoleServer = (int) 1;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/pal/ica/ICAAlcsNative", typeof (ICAAlcsNative));
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

		protected ICAAlcsNative (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/constructor[@name='ICAAlcsNative' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ICAAlcsNative ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='connectDevice' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICAConnectParams'] and parameter[4][@type='com.aliyun.alink.linksdk.alcs.api.ICAConnectListener']]"
		[Register ("connectDevice", "(Ljava/lang/String;ILcom/aliyun/alink/linksdk/alcs/data/ica/ICAConnectParams;Lcom/aliyun/alink/linksdk/alcs/api/ICAConnectListener;)V", "")]
		public static unsafe void ConnectDevice (string address, int port, global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAConnectParams @params, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAConnectListener listener)
		{
			const string __id = "connectDevice.(Ljava/lang/String;ILcom/aliyun/alink/linksdk/alcs/data/ica/ICAConnectParams;Lcom/aliyun/alink/linksdk/alcs/api/ICAConnectListener;)V";
			IntPtr native_address = JNIEnv.NewString (address);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_address);
				__args [1] = new JniArgumentValue (port);
				__args [2] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
				__args [3] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_address);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='connectDeviceNative' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICADeviceInfo'] and parameter[4][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICAAuthParams'] and parameter[5][@type='com.aliyun.alink.linksdk.alcs.api.ICAConnectListener']]"
		[Register ("connectDeviceNative", "(Ljava/lang/String;ILcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAAuthParams;Lcom/aliyun/alink/linksdk/alcs/api/ICAConnectListener;)I", "")]
		protected static unsafe int ConnectDeviceNative (string p0, int p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p2, global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAAuthParams p3, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAConnectListener p4)
		{
			const string __id = "connectDeviceNative.(Ljava/lang/String;ILcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAAuthParams;Lcom/aliyun/alink/linksdk/alcs/api/ICAConnectListener;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='deInitPal' and count(parameter)=0]"
		[Register ("deInitPal", "()V", "")]
		public static unsafe void DeInitPal ()
		{
			const string __id = "deInitPal.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='deInitPalNative' and count(parameter)=0]"
		[Register ("deInitPalNative", "()V", "")]
		protected static unsafe void DeInitPalNative ()
		{
			const string __id = "deInitPalNative.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='disConnectDevice' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICADeviceInfo']]"
		[Register ("disConnectDevice", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;)V", "")]
		public static unsafe void DisConnectDevice (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo deviceInfo)
		{
			const string __id = "disConnectDevice.(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((deviceInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deviceInfo).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='disConnectDeviceNative' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICADeviceInfo']]"
		[Register ("disConnectDeviceNative", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;)I", "")]
		protected static unsafe int DisConnectDeviceNative (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p0)
		{
			const string __id = "disConnectDeviceNative.(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='discoveryDevice' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.pal.ica.ICADiscoveryListener']]"
		[Register ("discoveryDevice", "(ILcom/aliyun/alink/linksdk/alcs/pal/ica/ICADiscoveryListener;)Z", "")]
		public static unsafe bool DiscoveryDevice (int timeOut, global::Com.Aliyun.Alink.Linksdk.Alcs.Pal.Ica.ICADiscoveryListener listener)
		{
			const string __id = "discoveryDevice.(ILcom/aliyun/alink/linksdk/alcs/pal/ica/ICADiscoveryListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (timeOut);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='discoveryDeviceNative' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.pal.ica.ICADiscoveryListener']]"
		[Register ("discoveryDeviceNative", "(ILcom/aliyun/alink/linksdk/alcs/pal/ica/ICADiscoveryListener;)I", "")]
		protected static unsafe int DiscoveryDeviceNative (int p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Pal.Ica.ICADiscoveryListener p1)
		{
			const string __id = "discoveryDeviceNative.(ILcom/aliyun/alink/linksdk/alcs/pal/ica/ICADiscoveryListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='initPal' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICAInitData']]"
		[Register ("initPal", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAInitData;)V", "")]
		public static unsafe void InitPal (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAInitData initData)
		{
			const string __id = "initPal.(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAInitData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((initData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) initData).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='initPalNative' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICADeviceInfo'] and parameter[2][@type='int']]"
		[Register ("initPalNative", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;I)I", "")]
		protected static unsafe int InitPalNative (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p0, int p1)
		{
			const string __id = "initPalNative.(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='isDeviceOnline' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICADeviceInfo']]"
		[Register ("isDeviceOnline", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;)Z", "")]
		public static unsafe bool IsDeviceOnline (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo deviceInfo)
		{
			const string __id = "isDeviceOnline.(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((deviceInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deviceInfo).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='isDeviceOnlineNative' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICADeviceInfo']]"
		[Register ("isDeviceOnlineNative", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;)Z", "")]
		protected static unsafe bool IsDeviceOnlineNative (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p0)
		{
			const string __id = "isDeviceOnlineNative.(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='probeDevice' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICADeviceInfo'] and parameter[4][@type='com.aliyun.alink.linksdk.alcs.api.ICAProbeListener']]"
		[Register ("probeDevice", "(Ljava/lang/String;ILcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;Lcom/aliyun/alink/linksdk/alcs/api/ICAProbeListener;)V", "")]
		public static unsafe void ProbeDevice (string address, int port, global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo deviceInfo, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAProbeListener listener)
		{
			const string __id = "probeDevice.(Ljava/lang/String;ILcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;Lcom/aliyun/alink/linksdk/alcs/api/ICAProbeListener;)V";
			IntPtr native_address = JNIEnv.NewString (address);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_address);
				__args [1] = new JniArgumentValue (port);
				__args [2] = new JniArgumentValue ((deviceInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deviceInfo).Handle);
				__args [3] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_address);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='probeDeviceNative' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICADeviceInfo'] and parameter[4][@type='com.aliyun.alink.linksdk.alcs.api.ICAProbeListener']]"
		[Register ("probeDeviceNative", "(Ljava/lang/String;ILcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;Lcom/aliyun/alink/linksdk/alcs/api/ICAProbeListener;)I", "")]
		protected static unsafe int ProbeDeviceNative (string p0, int p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p2, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAProbeListener p3)
		{
			const string __id = "probeDeviceNative.(Ljava/lang/String;ILcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;Lcom/aliyun/alink/linksdk/alcs/api/ICAProbeListener;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='regDeviceNotifyListener' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.pal.ica.ICADiscoveryListener']]"
		[Register ("regDeviceNotifyListener", "(Lcom/aliyun/alink/linksdk/alcs/pal/ica/ICADiscoveryListener;)Z", "")]
		public static unsafe bool RegDeviceNotifyListener (global::Com.Aliyun.Alink.Linksdk.Alcs.Pal.Ica.ICADiscoveryListener listener)
		{
			const string __id = "regDeviceNotifyListener.(Lcom/aliyun/alink/linksdk/alcs/pal/ica/ICADiscoveryListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='regDeviceNotifyListenerNative' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.pal.ica.ICADiscoveryListener']]"
		[Register ("regDeviceNotifyListenerNative", "(Lcom/aliyun/alink/linksdk/alcs/pal/ica/ICADiscoveryListener;)I", "")]
		protected static unsafe int RegDeviceNotifyListenerNative (global::Com.Aliyun.Alink.Linksdk.Alcs.Pal.Ica.ICADiscoveryListener p0)
		{
			const string __id = "regDeviceNotifyListenerNative.(Lcom/aliyun/alink/linksdk/alcs/pal/ica/ICADiscoveryListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='removeDeviceDisconnectListener' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICADeviceInfo']]"
		[Register ("removeDeviceDisconnectListener", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;)Z", "")]
		public static unsafe bool RemoveDeviceDisconnectListener (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo deviceInfo)
		{
			const string __id = "removeDeviceDisconnectListener.(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((deviceInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deviceInfo).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='removeDeviceDisconnectListenerNative' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICADeviceInfo']]"
		[Register ("removeDeviceDisconnectListenerNative", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;)Z", "")]
		protected static unsafe bool RemoveDeviceDisconnectListenerNative (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p0)
		{
			const string __id = "removeDeviceDisconnectListenerNative.(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='sendGroupRequest' and count(parameter)=3 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICAGroupReqMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICAAuthParams'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.api.ICAMsgListener']]"
		[Register ("sendGroupRequest", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAGroupReqMessage;Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAAuthParams;Lcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;)Z", "")]
		public static unsafe bool SendGroupRequest (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAGroupReqMessage groupReqMessage, global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAAuthParams authInfo, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAMsgListener @callback)
		{
			const string __id = "sendGroupRequest.(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAGroupReqMessage;Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAAuthParams;Lcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((groupReqMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) groupReqMessage).Handle);
				__args [1] = new JniArgumentValue ((authInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authInfo).Handle);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='sendGroupRequestNative' and count(parameter)=3 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICAGroupReqMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICAAuthParams'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.api.ICAMsgListener']]"
		[Register ("sendGroupRequestNative", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAGroupReqMessage;Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAAuthParams;Lcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;)I", "")]
		protected static unsafe int SendGroupRequestNative (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAGroupReqMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAAuthParams p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAMsgListener p2)
		{
			const string __id = "sendGroupRequestNative.(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAGroupReqMessage;Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAAuthParams;Lcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='sendRequest' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICAReqMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.api.ICAMsgListener']]"
		[Register ("sendRequest", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAReqMessage;Lcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;)Z", "")]
		public static unsafe bool SendRequest (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAReqMessage reqMessageInfo, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAMsgListener @callback)
		{
			const string __id = "sendRequest.(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAReqMessage;Lcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((reqMessageInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reqMessageInfo).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='sendRequestNative' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICAReqMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.api.ICAMsgListener']]"
		[Register ("sendRequestNative", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAReqMessage;Lcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;)I", "")]
		protected static unsafe int SendRequestNative (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAReqMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAMsgListener p1)
		{
			const string __id = "sendRequestNative.(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAReqMessage;Lcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='sendResponse' and count(parameter)=3 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICARspMessage'] and parameter[2][@type='int'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.api.ICAMsgListener']]"
		[Register ("sendResponse", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICARspMessage;ILcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;)Z", "")]
		public static unsafe bool SendResponse (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICARspMessage reqMessageInfoint, int cbCtx, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAMsgListener @callback)
		{
			const string __id = "sendResponse.(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICARspMessage;ILcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((reqMessageInfoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reqMessageInfoint).Handle);
				__args [1] = new JniArgumentValue (cbCtx);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='sendResponseNative' and count(parameter)=3 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICARspMessage'] and parameter[2][@type='int'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.api.ICAMsgListener']]"
		[Register ("sendResponseNative", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICARspMessage;ILcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;)I", "")]
		protected static unsafe int SendResponseNative (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICARspMessage p0, int p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAMsgListener p2)
		{
			const string __id = "sendResponseNative.(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICARspMessage;ILcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='setDeviceDisconnectListener' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICADeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.api.ICADisconnectListener']]"
		[Register ("setDeviceDisconnectListener", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;Lcom/aliyun/alink/linksdk/alcs/api/ICADisconnectListener;)Z", "")]
		public static unsafe bool SetDeviceDisconnectListener (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo deviceInfo, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICADisconnectListener listener)
		{
			const string __id = "setDeviceDisconnectListener.(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;Lcom/aliyun/alink/linksdk/alcs/api/ICADisconnectListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((deviceInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deviceInfo).Handle);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='setDeviceDisconnectListenerNative' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICADeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.api.ICADisconnectListener']]"
		[Register ("setDeviceDisconnectListenerNative", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;Lcom/aliyun/alink/linksdk/alcs/api/ICADisconnectListener;)Z", "")]
		protected static unsafe bool SetDeviceDisconnectListenerNative (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICADisconnectListener p1)
		{
			const string __id = "setDeviceDisconnectListenerNative.(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;Lcom/aliyun/alink/linksdk/alcs/api/ICADisconnectListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='stopDiscoveryDevice' and count(parameter)=0]"
		[Register ("stopDiscoveryDevice", "()Z", "")]
		public static unsafe bool StopDiscoveryDevice ()
		{
			const string __id = "stopDiscoveryDevice.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='stopDiscoveryDeviceNative' and count(parameter)=0]"
		[Register ("stopDiscoveryDeviceNative", "()I", "")]
		protected static unsafe int StopDiscoveryDeviceNative ()
		{
			const string __id = "stopDiscoveryDeviceNative.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='subcribe' and count(parameter)=3 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICASubMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.api.ICAMsgListener'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.api.ICAMsgListener']]"
		[Register ("subcribe", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICASubMessage;Lcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;Lcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;)Z", "")]
		public static unsafe bool Subcribe (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICASubMessage subMessageInfo, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAMsgListener @callback, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAMsgListener eventListener)
		{
			const string __id = "subcribe.(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICASubMessage;Lcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;Lcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((subMessageInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subMessageInfo).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [2] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='subcribeNative' and count(parameter)=3 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICASubMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.api.ICAMsgListener'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.api.ICAMsgListener']]"
		[Register ("subcribeNative", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICASubMessage;Lcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;Lcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;)I", "")]
		protected static unsafe int SubcribeNative (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICASubMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAMsgListener p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAMsgListener p2)
		{
			const string __id = "subcribeNative.(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICASubMessage;Lcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;Lcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='unregDeviceNotifyListener' and count(parameter)=0]"
		[Register ("unregDeviceNotifyListener", "()Z", "")]
		public static unsafe bool UnregDeviceNotifyListener ()
		{
			const string __id = "unregDeviceNotifyListener.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='unsubcribe' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICASubMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.api.ICAMsgListener']]"
		[Register ("unsubcribe", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICASubMessage;Lcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;)Z", "")]
		public static unsafe bool Unsubcribe (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICASubMessage subMessageInfo, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAMsgListener @callback)
		{
			const string __id = "unsubcribe.(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICASubMessage;Lcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((subMessageInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subMessageInfo).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.pal.ica']/class[@name='ICAAlcsNative']/method[@name='unsubcribeNative' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICASubMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.api.ICAMsgListener']]"
		[Register ("unsubcribeNative", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICASubMessage;Lcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;)I", "")]
		protected static unsafe int UnsubcribeNative (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICASubMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAMsgListener p1)
		{
			const string __id = "unsubcribeNative.(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICASubMessage;Lcom/aliyun/alink/linksdk/alcs/api/ICAMsgListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
