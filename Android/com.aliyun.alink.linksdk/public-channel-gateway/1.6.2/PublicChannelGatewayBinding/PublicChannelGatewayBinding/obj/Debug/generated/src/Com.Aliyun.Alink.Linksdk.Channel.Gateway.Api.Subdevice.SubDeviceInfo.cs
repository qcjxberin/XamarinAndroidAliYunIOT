using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/class[@name='SubDeviceInfo']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceInfo", DoNotGenerateAcw=true)]
	public partial class SubDeviceInfo : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/class[@name='SubDeviceInfo']/field[@name='deviceName']"
		[Register ("deviceName")]
		public string DeviceName {
			get {
				const string __id = "deviceName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "deviceName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/class[@name='SubDeviceInfo']/field[@name='deviceState']"
		[Register ("deviceState")]
		public global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceState DeviceState {
			get {
				const string __id = "deviceState.Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceState;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "deviceState.Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceState;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/class[@name='SubDeviceInfo']/field[@name='loginState']"
		[Register ("loginState")]
		public global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceLoginState LoginState {
			get {
				const string __id = "loginState.Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceLoginState;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceLoginState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "loginState.Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceLoginState;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/class[@name='SubDeviceInfo']/field[@name='productKey']"
		[Register ("productKey")]
		public string ProductKey {
			get {
				const string __id = "productKey.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "productKey.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceInfo", typeof (SubDeviceInfo));
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

		protected SubDeviceInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/class[@name='SubDeviceInfo']/constructor[@name='SubDeviceInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SubDeviceInfo ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/class[@name='SubDeviceInfo']/constructor[@name='SubDeviceInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe SubDeviceInfo (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getDeviceId;
#pragma warning disable 0169
		static Delegate GetGetDeviceIdHandler ()
		{
			if (cb_getDeviceId == null)
				cb_getDeviceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceId);
			return cb_getDeviceId;
		}

		static IntPtr n_GetDeviceId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceId);
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/class[@name='SubDeviceInfo']/method[@name='getDeviceId' and count(parameter)=0]"
			[Register ("getDeviceId", "()Ljava/lang/String;", "GetGetDeviceIdHandler")]
			get {
				const string __id = "getDeviceId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_checkValid;
#pragma warning disable 0169
		static Delegate GetCheckValidHandler ()
		{
			if (cb_checkValid == null)
				cb_checkValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CheckValid);
			return cb_checkValid;
		}

		static bool n_CheckValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckValid ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/class[@name='SubDeviceInfo']/method[@name='checkValid' and count(parameter)=0]"
		[Register ("checkValid", "()Z", "GetCheckValidHandler")]
		public virtual unsafe bool CheckValid ()
		{
			const string __id = "checkValid.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
