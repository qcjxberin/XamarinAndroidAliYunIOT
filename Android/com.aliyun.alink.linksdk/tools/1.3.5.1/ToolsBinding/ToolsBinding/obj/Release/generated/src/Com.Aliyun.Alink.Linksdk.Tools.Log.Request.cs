using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Tools.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='Request']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/tools/log/Request", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class Request : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='Request']/field[@name='id']"
		[Register ("id")]
		public string Id {
			get {
				const string __id = "id.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "id.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='Request']/field[@name='method']"
		[Register ("method")]
		public string Method {
			get {
				const string __id = "method.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "method.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='Request']/field[@name='params']"
		[Register ("params")]
		public global::Java.Lang.Object Params {
			get {
				const string __id = "params.Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "params.Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='Request']/field[@name='version']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='Request.Builder']"
		[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/tools/log/Request$Builder", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K"})]
		public sealed partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/tools/log/Request$Builder", typeof (Builder));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='Request.Builder']/constructor[@name='Request.Builder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='Request.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/aliyun/alink/linksdk/tools/log/Request;", "")]
			public unsafe global::Com.Aliyun.Alink.Linksdk.Tools.Log.Request Build ()
			{
				const string __id = "build.()Lcom/aliyun/alink/linksdk/tools/log/Request;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.Request> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='Request.Builder']/method[@name='method' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("method", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/tools/log/Request$Builder;", "")]
			public unsafe global::Com.Aliyun.Alink.Linksdk.Tools.Log.Request.Builder Method (string val)
			{
				const string __id = "method.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/tools/log/Request$Builder;";
				IntPtr native_val = JNIEnv.NewString (val);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_val);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_val);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='Request.Builder']/method[@name='params' and count(parameter)=1 and parameter[1][@type='K']]"
			[Register ("params", "(Ljava/lang/Object;)Lcom/aliyun/alink/linksdk/tools/log/Request$Builder;", "")]
			public unsafe global::Com.Aliyun.Alink.Linksdk.Tools.Log.Request.Builder Params (global::Java.Lang.Object val)
			{
				const string __id = "params.(Ljava/lang/Object;)Lcom/aliyun/alink/linksdk/tools/log/Request$Builder;";
				IntPtr native_val = JNIEnv.ToLocalJniHandle (val);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_val);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_val);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='Request.Builder']/method[@name='version' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("version", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/tools/log/Request$Builder;", "")]
			public unsafe global::Com.Aliyun.Alink.Linksdk.Tools.Log.Request.Builder Version (string val)
			{
				const string __id = "version.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/tools/log/Request$Builder;";
				IntPtr native_val = JNIEnv.NewString (val);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_val);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_val);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/tools/log/Request", typeof (Request));
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

		protected Request (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
