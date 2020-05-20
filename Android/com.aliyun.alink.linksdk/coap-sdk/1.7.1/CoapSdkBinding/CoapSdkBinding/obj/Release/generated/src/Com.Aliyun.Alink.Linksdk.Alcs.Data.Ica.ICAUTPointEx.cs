using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAUTPointEx']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/data/ica/ICAUTPointEx", DoNotGenerateAcw=true)]
	public partial class ICAUTPointEx : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAUTPointEx']/field[@name='UNKNOWN_ERRORCODE']"
		[Register ("UNKNOWN_ERRORCODE")]
		public const int UnknownErrorcode = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAUTPointEx']/field[@name='UTVALUE_ALCS']"
		[Register ("UTVALUE_ALCS")]
		public const string UtvalueAlcs = (string) "alcs";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAUTPointEx']/field[@name='mUtProperties']"
		[Register ("mUtProperties")]
		protected global::System.Collections.IDictionary MUtProperties {
			get {
				const string __id = "mUtProperties.Ljava/util/Map;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mUtProperties.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/data/ica/ICAUTPointEx", typeof (ICAUTPointEx));
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

		protected ICAUTPointEx (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAUTPointEx']/constructor[@name='ICAUTPointEx' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ICAUTPointEx (string productKey, string deviceName)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_productKey = JNIEnv.NewString (productKey);
			IntPtr native_deviceName = JNIEnv.NewString (deviceName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_productKey);
				__args [1] = new JniArgumentValue (native_deviceName);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_productKey);
				JNIEnv.DeleteLocalRef (native_deviceName);
			}
		}

		static Delegate cb_trackEnd_I;
#pragma warning disable 0169
		static Delegate GetTrackEnd_IHandler ()
		{
			if (cb_trackEnd_I == null)
				cb_trackEnd_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_TrackEnd_I);
			return cb_trackEnd_I;
		}

		static void n_TrackEnd_I (IntPtr jnienv, IntPtr native__this, int errorCode)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAUTPointEx __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAUTPointEx> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrackEnd (errorCode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAUTPointEx']/method[@name='trackEnd' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("trackEnd", "(I)V", "GetTrackEnd_IHandler")]
		public virtual unsafe void TrackEnd (int errorCode)
		{
			const string __id = "trackEnd.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (errorCode);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_trackStart;
#pragma warning disable 0169
		static Delegate GetTrackStartHandler ()
		{
			if (cb_trackStart == null)
				cb_trackStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TrackStart);
			return cb_trackStart;
		}

		static void n_TrackStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAUTPointEx __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICAUTPointEx> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrackStart ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.data.ica']/class[@name='ICAUTPointEx']/method[@name='trackStart' and count(parameter)=0]"
		[Register ("trackStart", "()V", "GetTrackStartHandler")]
		public virtual unsafe void TrackStart ()
		{
			const string __id = "trackStart.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
