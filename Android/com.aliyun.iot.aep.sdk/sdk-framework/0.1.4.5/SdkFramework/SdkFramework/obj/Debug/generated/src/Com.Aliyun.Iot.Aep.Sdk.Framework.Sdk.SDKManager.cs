using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/sdk/SDKManager", DoNotGenerateAcw=true)]
	public sealed partial class SDKManager : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager.InitResultHolder']"
		[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/sdk/SDKManager$InitResultHolder", DoNotGenerateAcw=true)]
		public partial class InitResultHolder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/sdk/SDKManager$InitResultHolder", typeof (InitResultHolder));
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

			protected InitResultHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager.InitResultHolder']/constructor[@name='SDKManager.InitResultHolder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe InitResultHolder ()
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

			public static unsafe global::System.Collections.Generic.IDictionary<string, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKManager.Result> Delegates {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager.InitResultHolder']/method[@name='getDelegates' and count(parameter)=0]"
				[Register ("getDelegates", "()Ljava/util/Map;", "")]
				get {
					const string __id = "getDelegates.()Ljava/util/Map;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Android.Runtime.JavaDictionary<string, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKManager.Result>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager.InitResultHolder']/method[@name='dump' and count(parameter)=0]"
			[Register ("dump", "()V", "")]
			public static unsafe void Dump ()
			{
				const string __id = "dump.()V";
				try {
					_members.StaticMethods.InvokeVoidMethod (__id, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager.InitResultHolder']/method[@name='getInitResultCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getInitResultCode", "(Ljava/lang/String;)I", "")]
			public static unsafe int GetInitResultCode (string initializerClass)
			{
				const string __id = "getInitResultCode.(Ljava/lang/String;)I";
				IntPtr native_initializerClass = JNIEnv.NewString (initializerClass);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_initializerClass);
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_initializerClass);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager.InitResultHolder']/method[@name='isInitialized' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("isInitialized", "(Ljava/lang/String;)Z", "")]
			public static unsafe bool IsInitialized (string initializerClass)
			{
				const string __id = "isInitialized.(Ljava/lang/String;)Z";
				IntPtr native_initializerClass = JNIEnv.NewString (initializerClass);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_initializerClass);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_initializerClass);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager.InitResultHolder']/method[@name='updateResult' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.iot.aep.sdk.framework.sdk.SDKManager.Result']]"
			[Register ("updateResult", "(Ljava/lang/String;Lcom/aliyun/iot/aep/sdk/framework/sdk/SDKManager$Result;)Z", "")]
			public static unsafe bool UpdateResult (string initializerClass, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKManager.Result result)
			{
				const string __id = "updateResult.(Ljava/lang/String;Lcom/aliyun/iot/aep/sdk/framework/sdk/SDKManager$Result;)Z";
				IntPtr native_initializerClass = JNIEnv.NewString (initializerClass);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_initializerClass);
					__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_initializerClass);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager.Result']"
		[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/sdk/SDKManager$Result", DoNotGenerateAcw=true)]
		public partial class Result : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/sdk/SDKManager$Result", typeof (Result));
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

			protected Result (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager.Result']/constructor[@name='SDKManager.Result' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Result ()
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/sdk/SDKManager", typeof (SDKManager));
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

		internal SDKManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager']/constructor[@name='SDKManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SDKManager ()
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

		public static unsafe bool IsDeviceCenterAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager']/method[@name='isDeviceCenterAvailable' and count(parameter)=0]"
			[Register ("isDeviceCenterAvailable", "()Z", "")]
			get {
				const string __id = "isDeviceCenterAvailable.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsGatewayConnectAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager']/method[@name='isGatewayConnectAvailable' and count(parameter)=0]"
			[Register ("isGatewayConnectAvailable", "()Z", "")]
			get {
				const string __id = "isGatewayConnectAvailable.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsOAAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager']/method[@name='isOAAvailable' and count(parameter)=0]"
			[Register ("isOAAvailable", "()Z", "")]
			get {
				const string __id = "isOAAvailable.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsPushAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager']/method[@name='isPushAvailable' and count(parameter)=0]"
			[Register ("isPushAvailable", "()Z", "")]
			get {
				const string __id = "isPushAvailable.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsRNAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager']/method[@name='isRNAvailable' and count(parameter)=0]"
			[Register ("isRNAvailable", "()Z", "")]
			get {
				const string __id = "isRNAvailable.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsTMPAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager']/method[@name='isTMPAvailable' and count(parameter)=0]"
			[Register ("isTMPAvailable", "()Z", "")]
			get {
				const string __id = "isTMPAvailable.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe global::System.Collections.Generic.IList<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure> SDKConfigures {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager']/method[@name='getSDKConfigures' and count(parameter)=0]"
			[Register ("getSDKConfigures", "()Ljava/util/ArrayList;", "")]
			get {
				const string __id = "getSDKConfigures.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaList<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager']/method[@name='_initSdkDelegates' and count(parameter)=3 and parameter[1][@type='android.app.Application'] and parameter[2][@type='com.aliyun.iot.aep.sdk.framework.sdk.SDKConfigure'] and parameter[3][@type='java.util.List&lt;com.aliyun.iot.aep.sdk.framework.sdk.ISDKDelegate&gt;']]"
		[Register ("_initSdkDelegates", "(Landroid/app/Application;Lcom/aliyun/iot/aep/sdk/framework/sdk/SDKConfigure;Ljava/util/List;)V", "")]
		public static unsafe void _initSdkDelegates (global::Android.App.Application app, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure configure, global::System.Collections.Generic.IList<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.ISDKDelegate> delegates)
		{
			const string __id = "_initSdkDelegates.(Landroid/app/Application;Lcom/aliyun/iot/aep/sdk/framework/sdk/SDKConfigure;Ljava/util/List;)V";
			IntPtr native_delegates = global::Android.Runtime.JavaList<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.ISDKDelegate>.ToLocalJniHandle (delegates);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((app == null) ? IntPtr.Zero : ((global::Java.Lang.Object) app).Handle);
				__args [1] = new JniArgumentValue ((configure == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configure).Handle);
				__args [2] = new JniArgumentValue (native_delegates);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_delegates);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager']/method[@name='_parseToSDKConfigure' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("_parseToSDKConfigure", "(Lorg/json/JSONObject;)Lcom/aliyun/iot/aep/sdk/framework/sdk/SDKConfigure;", "")]
		public static unsafe global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure _parseToSDKConfigure (global::Org.Json.JSONObject jsonObject)
		{
			const string __id = "_parseToSDKConfigure.(Lorg/json/JSONObject;)Lcom/aliyun/iot/aep/sdk/framework/sdk/SDKConfigure;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((jsonObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonObject).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager']/method[@name='_prepareSdkDelegateClassName' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("_prepareSdkDelegateClassName", "(Lorg/json/JSONObject;)Ljava/lang/String;", "")]
		public static unsafe string _prepareSdkDelegateClassName (global::Org.Json.JSONObject @object)
		{
			const string __id = "_prepareSdkDelegateClassName.(Lorg/json/JSONObject;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager']/method[@name='_prepareSdkDelegates' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.framework.sdk.SDKConfigure']]"
		[Register ("_prepareSdkDelegates", "(Lcom/aliyun/iot/aep/sdk/framework/sdk/SDKConfigure;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.ISDKDelegate> _prepareSdkDelegates (global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure configure)
		{
			const string __id = "_prepareSdkDelegates.(Lcom/aliyun/iot/aep/sdk/framework/sdk/SDKConfigure;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((configure == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configure).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.ISDKDelegate>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("init", "(Landroid/app/Application;)V", "")]
		public static unsafe void Init (global::Android.App.Application app)
		{
			const string __id = "init.(Landroid/app/Application;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((app == null) ? IntPtr.Zero : ((global::Java.Lang.Object) app).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager']/method[@name='init_underUiThread' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("init_underUiThread", "(Landroid/app/Application;)V", "")]
		public static unsafe void Init_underUiThread (global::Android.App.Application app)
		{
			const string __id = "init_underUiThread.(Landroid/app/Application;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((app == null) ? IntPtr.Zero : ((global::Java.Lang.Object) app).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKManager']/method[@name='prepareForInitSdk' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("prepareForInitSdk", "(Landroid/app/Application;)V", "")]
		public static unsafe void PrepareForInitSdk (global::Android.App.Application app)
		{
			const string __id = "prepareForInitSdk.(Landroid/app/Application;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((app == null) ? IntPtr.Zero : ((global::Java.Lang.Object) app).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
