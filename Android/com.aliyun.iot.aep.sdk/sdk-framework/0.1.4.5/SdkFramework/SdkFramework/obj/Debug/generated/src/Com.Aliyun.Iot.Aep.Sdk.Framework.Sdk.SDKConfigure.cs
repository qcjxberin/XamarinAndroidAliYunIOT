using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKConfigure']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/sdk/SDKConfigure", DoNotGenerateAcw=true)]
	public sealed partial class SDKConfigure : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKConfigure']/field[@name='classFiles']"
		[Register ("classFiles")]
		public global::Org.Json.JSONArray ClassFiles {
			get {
				const string __id = "classFiles.Lorg/json/JSONArray;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "classFiles.Lorg/json/JSONArray;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKConfigure']/field[@name='description']"
		[Register ("description")]
		public string Description {
			get {
				const string __id = "description.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "description.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKConfigure']/field[@name='doc']"
		[Register ("doc")]
		public string Doc {
			get {
				const string __id = "doc.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "doc.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKConfigure']/field[@name='initializedInUIThread']"
		[Register ("initializedInUIThread")]
		public bool InitializedInUIThread {
			get {
				const string __id = "initializedInUIThread.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "initializedInUIThread.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKConfigure']/field[@name='name']"
		[Register ("name")]
		public string Name {
			get {
				const string __id = "name.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "name.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKConfigure']/field[@name='needIoTToken']"
		[Register ("needIoTToken")]
		public bool NeedIoTToken {
			get {
				const string __id = "needIoTToken.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "needIoTToken.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKConfigure']/field[@name='opts']"
		[Register ("opts")]
		public global::Org.Json.JSONObject Opts {
			get {
				const string __id = "opts.Lorg/json/JSONObject;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "opts.Lorg/json/JSONObject;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKConfigure']/field[@name='process']"
		[Register ("process")]
		public string Process {
			get {
				const string __id = "process.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "process.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKConfigure']/field[@name='submodules']"
		[Register ("submodules")]
		public global::System.Collections.IList Submodules {
			get {
				const string __id = "submodules.Ljava/util/ArrayList;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "submodules.Ljava/util/ArrayList;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKConfigure']/field[@name='version']"
		[Register ("version")]
		public string Version {
			get {
				const string __id = "version.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "version.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/sdk/SDKConfigure", typeof (SDKConfigure));
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

		internal SDKConfigure (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKConfigure']/constructor[@name='SDKConfigure' and count(parameter)=10 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='org.json.JSONArray'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean'] and parameter[8][@type='org.json.JSONObject'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.util.ArrayList&lt;com.aliyun.iot.aep.sdk.framework.sdk.SDKConfigure&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONArray;ZZLorg/json/JSONObject;Ljava/lang/String;Ljava/util/ArrayList;)V", "")]
		public unsafe SDKConfigure (string name, string version, string description, string doc, global::Org.Json.JSONArray classFiles, bool initializedInUIThread, bool needIoTToken, global::Org.Json.JSONObject opt, string process, global::System.Collections.Generic.IList<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure> submodules)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONArray;ZZLorg/json/JSONObject;Ljava/lang/String;Ljava/util/ArrayList;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_version = JNIEnv.NewString (version);
			IntPtr native_description = JNIEnv.NewString (description);
			IntPtr native_doc = JNIEnv.NewString (doc);
			IntPtr native_process = JNIEnv.NewString (process);
			IntPtr native_submodules = global::Android.Runtime.JavaList<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure>.ToLocalJniHandle (submodules);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_version);
				__args [2] = new JniArgumentValue (native_description);
				__args [3] = new JniArgumentValue (native_doc);
				__args [4] = new JniArgumentValue ((classFiles == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classFiles).Handle);
				__args [5] = new JniArgumentValue (initializedInUIThread);
				__args [6] = new JniArgumentValue (needIoTToken);
				__args [7] = new JniArgumentValue ((opt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) opt).Handle);
				__args [8] = new JniArgumentValue (native_process);
				__args [9] = new JniArgumentValue (native_submodules);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_version);
				JNIEnv.DeleteLocalRef (native_description);
				JNIEnv.DeleteLocalRef (native_doc);
				JNIEnv.DeleteLocalRef (native_process);
				JNIEnv.DeleteLocalRef (native_submodules);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SDKConfigure']/constructor[@name='SDKConfigure' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='org.json.JSONArray'] and parameter[6][@type='boolean'] and parameter[7][@type='org.json.JSONObject'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.util.ArrayList&lt;com.aliyun.iot.aep.sdk.framework.sdk.SDKConfigure&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONArray;ZLorg/json/JSONObject;Ljava/lang/String;Ljava/util/ArrayList;)V", "")]
		public unsafe SDKConfigure (string name, string version, string description, string doc, global::Org.Json.JSONArray classFiles, bool needIoTToken, global::Org.Json.JSONObject opt, string process, global::System.Collections.Generic.IList<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure> submodules)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONArray;ZLorg/json/JSONObject;Ljava/lang/String;Ljava/util/ArrayList;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_version = JNIEnv.NewString (version);
			IntPtr native_description = JNIEnv.NewString (description);
			IntPtr native_doc = JNIEnv.NewString (doc);
			IntPtr native_process = JNIEnv.NewString (process);
			IntPtr native_submodules = global::Android.Runtime.JavaList<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure>.ToLocalJniHandle (submodules);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_version);
				__args [2] = new JniArgumentValue (native_description);
				__args [3] = new JniArgumentValue (native_doc);
				__args [4] = new JniArgumentValue ((classFiles == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classFiles).Handle);
				__args [5] = new JniArgumentValue (needIoTToken);
				__args [6] = new JniArgumentValue ((opt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) opt).Handle);
				__args [7] = new JniArgumentValue (native_process);
				__args [8] = new JniArgumentValue (native_submodules);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_version);
				JNIEnv.DeleteLocalRef (native_description);
				JNIEnv.DeleteLocalRef (native_doc);
				JNIEnv.DeleteLocalRef (native_process);
				JNIEnv.DeleteLocalRef (native_submodules);
			}
		}

	}
}
