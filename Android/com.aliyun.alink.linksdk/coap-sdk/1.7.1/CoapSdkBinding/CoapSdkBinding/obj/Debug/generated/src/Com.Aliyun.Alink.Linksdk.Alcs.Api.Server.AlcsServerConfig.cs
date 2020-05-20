using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Api.Server {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig", DoNotGenerateAcw=true)]
	public sealed partial class AlcsServerConfig : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig']/field[@name='mBlacklist']"
		[Register ("mBlacklist")]
		protected string MBlacklist {
			get {
				const string __id = "mBlacklist.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mBlacklist.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig']/field[@name='mDeviceName']"
		[Register ("mDeviceName")]
		protected string MDeviceName {
			get {
				const string __id = "mDeviceName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDeviceName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig']/field[@name='mHeartBeatTimeout']"
		[Register ("mHeartBeatTimeout")]
		protected int MHeartBeatTimeout {
			get {
				const string __id = "mHeartBeatTimeout.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mHeartBeatTimeout.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig']/field[@name='mIsSecurityPost']"
		[Register ("mIsSecurityPost")]
		protected bool MIsSecurityPost {
			get {
				const string __id = "mIsSecurityPost.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mIsSecurityPost.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig']/field[@name='mPreSecList']"
		[Register ("mPreSecList")]
		protected global::System.Collections.IList MPreSecList {
			get {
				const string __id = "mPreSecList.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPreSecList.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig']/field[@name='mProductKey']"
		[Register ("mProductKey")]
		protected string MProductKey {
			get {
				const string __id = "mProductKey.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mProductKey.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig']/field[@name='mSafePort']"
		[Register ("mSafePort")]
		protected int MSafePort {
			get {
				const string __id = "mSafePort.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mSafePort.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig']/field[@name='mUnSafePort']"
		[Register ("mUnSafePort")]
		protected int MUnSafePort {
			get {
				const string __id = "mUnSafePort.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mUnSafePort.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig.Builder']"
		[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig.Builder']/constructor[@name='AlcsServerConfig.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig.Builder']/method[@name='addPrefixSec' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addPrefixSec", "(Ljava/lang/String;Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig$Builder;", "")]
			public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig.Builder AddPrefixSec (string prefix, string secret)
			{
				const string __id = "addPrefixSec.(Ljava/lang/String;Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig$Builder;";
				IntPtr native_prefix = JNIEnv.NewString (prefix);
				IntPtr native_secret = JNIEnv.NewString (secret);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_prefix);
					__args [1] = new JniArgumentValue (native_secret);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_prefix);
					JNIEnv.DeleteLocalRef (native_secret);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig;", "")]
			public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig Build ()
			{
				const string __id = "build.()Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig.Builder']/method[@name='setBlackList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBlackList", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig$Builder;", "")]
			public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig.Builder SetBlackList (string blackList)
			{
				const string __id = "setBlackList.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig$Builder;";
				IntPtr native_blackList = JNIEnv.NewString (blackList);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_blackList);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_blackList);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig.Builder']/method[@name='setDevcieName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDevcieName", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig$Builder;", "")]
			public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig.Builder SetDevcieName (string name)
			{
				const string __id = "setDevcieName.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig$Builder;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig.Builder']/method[@name='setHeartBeatTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHeartBeatTimeout", "(I)Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig$Builder;", "")]
			public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig.Builder SetHeartBeatTimeout (int timeout)
			{
				const string __id = "setHeartBeatTimeout.(I)Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (timeout);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig.Builder']/method[@name='setIsSecurityPort' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Obsolete (@"deprecated")]
			[Register ("setIsSecurityPort", "(Z)Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig$Builder;", "")]
			public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig.Builder SetIsSecurityPort (bool isSecurityPort)
			{
				const string __id = "setIsSecurityPort.(Z)Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (isSecurityPort);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig.Builder']/method[@name='setProdKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProdKey", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig$Builder;", "")]
			public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig.Builder SetProdKey (string key)
			{
				const string __id = "setProdKey.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig$Builder;";
				IntPtr native_key = JNIEnv.NewString (key);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_key);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_key);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig.Builder']/method[@name='setSafePort' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSafePort", "(I)Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig$Builder;", "")]
			public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig.Builder SetSafePort (int port)
			{
				const string __id = "setSafePort.(I)Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (port);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig.Builder']/method[@name='setSessionExpireValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSessionExpireValue", "(I)Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig$Builder;", "")]
			public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig.Builder SetSessionExpireValue (int value)
			{
				const string __id = "setSessionExpireValue.(I)Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig.Builder']/method[@name='setUnsafePort' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUnsafePort", "(I)Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig$Builder;", "")]
			public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig.Builder SetUnsafePort (int port)
			{
				const string __id = "setUnsafePort.(I)Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (port);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig", typeof (AlcsServerConfig));
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

		internal AlcsServerConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig']/method[@name='getDeviceName' and count(parameter)=0]"
			[Register ("getDeviceName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDeviceName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int HeartBeatTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig']/method[@name='getHeartBeatTimeout' and count(parameter)=0]"
			[Register ("getHeartBeatTimeout", "()I", "")]
			get {
				const string __id = "getHeartBeatTimeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		[Obsolete (@"deprecated")]
		public unsafe bool IsSecurityPost {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig']/method[@name='isSecurityPost' and count(parameter)=0]"
			[Register ("isSecurityPost", "()Z", "")]
			get {
				const string __id = "isSecurityPost.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.PrefixSecretNode> PreSecList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig']/method[@name='getPreSecList' and count(parameter)=0]"
			[Register ("getPreSecList", "()Ljava/util/List;", "")]
			get {
				const string __id = "getPreSecList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.PrefixSecretNode>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string ProductKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig']/method[@name='getProductKey' and count(parameter)=0]"
			[Register ("getProductKey", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getProductKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int SafePort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig']/method[@name='getSafePort' and count(parameter)=0]"
			[Register ("getSafePort", "()I", "")]
			get {
				const string __id = "getSafePort.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int SessionExpireValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig']/method[@name='getSessionExpireValue' and count(parameter)=0]"
			[Register ("getSessionExpireValue", "()I", "")]
			get {
				const string __id = "getSessionExpireValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int UnSafePort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServerConfig']/method[@name='getUnSafePort' and count(parameter)=0]"
			[Register ("getUnSafePort", "()I", "")]
			get {
				const string __id = "getUnSafePort.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
