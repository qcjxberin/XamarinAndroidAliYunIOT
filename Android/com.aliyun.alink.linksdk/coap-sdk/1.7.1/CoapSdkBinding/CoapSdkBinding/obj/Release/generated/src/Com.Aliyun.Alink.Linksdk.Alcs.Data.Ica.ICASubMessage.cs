using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICASubMessage']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/data/ica/ICASubMessage", DoNotGenerateAcw=true)]
	public partial class ICASubMessage : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICASubMessage']/field[@name='deviceInfo']"
		[Register ("deviceInfo")]
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo DeviceInfo {
			get {
				const string __id = "deviceInfo.Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "deviceInfo.Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICASubMessage']/field[@name='payload']"
		[Register ("payload")]
		public IList<byte> Payload {
			get {
				const string __id = "payload.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "payload.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICASubMessage']/field[@name='topic']"
		[Register ("topic")]
		public string Topic {
			get {
				const string __id = "topic.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "topic.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/data/ica/ICASubMessage", typeof (ICASubMessage));
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

		protected ICASubMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICASubMessage']/constructor[@name='ICASubMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ICASubMessage ()
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

		static Delegate cb_getDevId;
#pragma warning disable 0169
		static Delegate GetGetDevIdHandler ()
		{
			if (cb_getDevId == null)
				cb_getDevId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDevId);
			return cb_getDevId;
		}

		static IntPtr n_GetDevId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICASubMessage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICASubMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DevId);
		}
#pragma warning restore 0169

		public virtual unsafe string DevId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICASubMessage']/method[@name='getDevId' and count(parameter)=0]"
			[Register ("getDevId", "()Ljava/lang/String;", "GetGetDevIdHandler")]
			get {
				const string __id = "getDevId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
