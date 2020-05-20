using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.Group {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.group']/class[@name='PalGroupInfo']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/data/group/PalGroupInfo", DoNotGenerateAcw=true)]
	public partial class PalGroupInfo : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.group']/class[@name='PalGroupInfo']/field[@name='deviceArray']"
		[Register ("deviceArray")]
		public IList<Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> DeviceArray {
			get {
				const string __id = "deviceArray.[Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "deviceArray.[Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;";

				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.group']/class[@name='PalGroupInfo']/field[@name='groupId']"
		[Register ("groupId")]
		public string GroupId {
			get {
				const string __id = "groupId.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "groupId.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/data/group/PalGroupInfo", typeof (PalGroupInfo));
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

		protected PalGroupInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.group']/class[@name='PalGroupInfo']/constructor[@name='PalGroupInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PalGroupInfo ()
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

		static Delegate cb_getIcaGroupInfo;
#pragma warning disable 0169
		static Delegate GetGetIcaGroupInfoHandler ()
		{
			if (cb_getIcaGroupInfo == null)
				cb_getIcaGroupInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIcaGroupInfo);
			return cb_getIcaGroupInfo;
		}

		static IntPtr n_GetIcaGroupInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.Group.PalGroupInfo __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.Group.PalGroupInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetIcaGroupInfo ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.group']/class[@name='PalGroupInfo']/method[@name='getIcaGroupInfo' and count(parameter)=0]"
		[Register ("getIcaGroupInfo", "()[Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;", "GetGetIcaGroupInfoHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo[] GetIcaGroupInfo ()
		{
			const string __id = "getIcaGroupInfo.()[Lcom/aliyun/alink/linksdk/alcs/data/ica/ICADeviceInfo;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICADeviceInfo));
			} finally {
			}
		}

	}
}
