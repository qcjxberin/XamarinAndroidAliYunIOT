using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Sdk.Tools.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='LogEntry']"
	[global::Android.Runtime.Register ("com/aliyun/iot/sdk/tools/log/LogEntry", DoNotGenerateAcw=true)]
	public partial class LogEntry : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='LogEntry']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/sdk/tools/log/LogEntry", typeof (LogEntry));
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

		protected LogEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='LogEntry']/constructor[@name='LogEntry' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe LogEntry (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/os/Parcel;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='LogEntry']/constructor[@name='LogEntry' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(BLjava/lang/String;)V", "")]
		public unsafe LogEntry (sbyte p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(BLjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getContent;
#pragma warning disable 0169
		static Delegate GetGetContentHandler ()
		{
			if (cb_getContent == null)
				cb_getContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContent);
			return cb_getContent;
		}

		static IntPtr n_GetContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.LogEntry __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.LogEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Content);
		}
#pragma warning restore 0169

		public virtual unsafe string Content {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='LogEntry']/method[@name='getContent' and count(parameter)=0]"
			[Register ("getContent", "()Ljava/lang/String;", "GetGetContentHandler")]
			get {
				const string __id = "getContent.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLevel;
#pragma warning disable 0169
		static Delegate GetGetLevelHandler ()
		{
			if (cb_getLevel == null)
				cb_getLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLevel);
			return cb_getLevel;
		}

		static int n_GetLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.LogEntry __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.LogEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Level;
		}
#pragma warning restore 0169

		public virtual unsafe int Level {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='LogEntry']/method[@name='getLevel' and count(parameter)=0]"
			[Register ("getLevel", "()I", "GetGetLevelHandler")]
			get {
				const string __id = "getLevel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPid;
#pragma warning disable 0169
		static Delegate GetGetPidHandler ()
		{
			if (cb_getPid == null)
				cb_getPid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPid);
			return cb_getPid;
		}

		static int n_GetPid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.LogEntry __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.LogEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Pid;
		}
#pragma warning restore 0169

		public virtual unsafe int Pid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='LogEntry']/method[@name='getPid' and count(parameter)=0]"
			[Register ("getPid", "()I", "GetGetPidHandler")]
			get {
				const string __id = "getPid.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTid;
#pragma warning disable 0169
		static Delegate GetGetTidHandler ()
		{
			if (cb_getTid == null)
				cb_getTid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTid);
			return cb_getTid;
		}

		static int n_GetTid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.LogEntry __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.LogEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Tid;
		}
#pragma warning restore 0169

		public virtual unsafe int Tid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='LogEntry']/method[@name='getTid' and count(parameter)=0]"
			[Register ("getTid", "()I", "GetGetTidHandler")]
			get {
				const string __id = "getTid.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTime;
#pragma warning disable 0169
		static Delegate GetGetTimeHandler ()
		{
			if (cb_getTime == null)
				cb_getTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTime);
			return cb_getTime;
		}

		static long n_GetTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.LogEntry __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.LogEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Time;
		}
#pragma warning restore 0169

		public virtual unsafe long Time {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='LogEntry']/method[@name='getTime' and count(parameter)=0]"
			[Register ("getTime", "()J", "GetGetTimeHandler")]
			get {
				const string __id = "getTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.LogEntry __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.LogEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='LogEntry']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.LogEntry __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.LogEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='LogEntry']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((int) p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
