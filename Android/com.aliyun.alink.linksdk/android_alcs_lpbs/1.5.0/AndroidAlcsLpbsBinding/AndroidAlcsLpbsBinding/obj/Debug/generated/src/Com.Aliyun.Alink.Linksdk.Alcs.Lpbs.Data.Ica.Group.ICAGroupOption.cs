using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.Ica.Group {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica.group']/class[@name='ICAGroupOption']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/data/ica/group/ICAGroupOption", DoNotGenerateAcw=true)]
	public partial class ICAGroupOption : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica.group']/class[@name='ICAGroupOption']/field[@name='icaAuthParams']"
		[Register ("icaAuthParams")]
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAAuthParams IcaAuthParams {
			get {
				const string __id = "icaAuthParams.Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAAuthParams;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAAuthParams> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "icaAuthParams.Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAAuthParams;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica.group']/class[@name='ICAGroupOption']/field[@name='icaOptions']"
		[Register ("icaOptions")]
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAOptions IcaOptions {
			get {
				const string __id = "icaOptions.Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAOptions;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAOptions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "icaOptions.Lcom/aliyun/alink/linksdk/alcs/data/ica/ICAOptions;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/data/ica/group/ICAGroupOption", typeof (ICAGroupOption));
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

		protected ICAGroupOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica.group']/class[@name='ICAGroupOption']/constructor[@name='ICAGroupOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ICAGroupOption ()
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
