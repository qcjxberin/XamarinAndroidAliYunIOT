using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAAuthPairs']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/data/ica/ICAAuthPairs", DoNotGenerateAcw=true)]
	public partial class ICAAuthPairs : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAAuthPairs']/field[@name='authParams']"
		[Register ("authParams")]
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAAuthParams AuthParams {
			get {
				const string __id = "authParams.Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAAuthParams;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAAuthParams> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "authParams.Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAAuthParams;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAAuthPairs']/field[@name='authServerParams']"
		[Register ("authServerParams")]
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAAuthServerParams AuthServerParams {
			get {
				const string __id = "authServerParams.Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAAuthServerParams;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAAuthServerParams> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "authServerParams.Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAAuthServerParams;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/data/ica/ICAAuthPairs", typeof (ICAAuthPairs));
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

		protected ICAAuthPairs (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAAuthPairs']/constructor[@name='ICAAuthPairs' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ICAAuthPairs (string ak, string at, string ac, string @as)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_ak = JNIEnv.NewString (ak);
			IntPtr native_at = JNIEnv.NewString (at);
			IntPtr native_ac = JNIEnv.NewString (ac);
			IntPtr native__as = JNIEnv.NewString (@as);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_ak);
				__args [1] = new JniArgumentValue (native_at);
				__args [2] = new JniArgumentValue (native_ac);
				__args [3] = new JniArgumentValue (native__as);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_ak);
				JNIEnv.DeleteLocalRef (native_at);
				JNIEnv.DeleteLocalRef (native_ac);
				JNIEnv.DeleteLocalRef (native__as);
			}
		}

	}
}
