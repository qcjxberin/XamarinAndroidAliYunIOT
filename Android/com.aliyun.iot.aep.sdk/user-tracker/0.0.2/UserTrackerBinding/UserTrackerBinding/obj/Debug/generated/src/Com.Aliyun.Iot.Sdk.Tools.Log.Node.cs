using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Sdk.Tools.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Node']"
	[global::Android.Runtime.Register ("com/aliyun/iot/sdk/tools/log/Node", DoNotGenerateAcw=true)]
	public partial class Node : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Node']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/sdk/tools/log/Node", typeof (Node));
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

		protected Node (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Node']/constructor[@name='Node' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Node (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getDatas;
#pragma warning disable 0169
		static Delegate GetGetDatasHandler ()
		{
			if (cb_getDatas == null)
				cb_getDatas = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDatas);
			return cb_getDatas;
		}

		static IntPtr n_GetDatas (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Node __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Aliyun.Iot.Sdk.Tools.Log.LogEntry>.ToLocalJniHandle (__this.Datas);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Aliyun.Iot.Sdk.Tools.Log.LogEntry> Datas {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Node']/method[@name='getDatas' and count(parameter)=0]"
			[Register ("getDatas", "()Ljava/util/List;", "GetGetDatasHandler")]
			get {
				const string __id = "getDatas.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Aliyun.Iot.Sdk.Tools.Log.LogEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Node __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Status);
		}
#pragma warning restore 0169

		static Delegate cb_setStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStatus_Ljava_lang_String_Handler ()
		{
			if (cb_setStatus_Ljava_lang_String_ == null)
				cb_setStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatus_Ljava_lang_String_);
			return cb_setStatus_Ljava_lang_String_;
		}

		static void n_SetStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Node __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Status = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Node']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Ljava/lang/String;", "GetGetStatusHandler")]
			get {
				const string __id = "getStatus.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Node']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStatus", "(Ljava/lang/String;)V", "GetSetStatus_Ljava_lang_String_Handler")]
			set {
				const string __id = "setStatus.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTag;
#pragma warning disable 0169
		static Delegate GetGetTagHandler ()
		{
			if (cb_getTag == null)
				cb_getTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTag);
			return cb_getTag;
		}

		static IntPtr n_GetTag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Node __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Tag);
		}
#pragma warning restore 0169

		public virtual unsafe string Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Node']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/String;", "GetGetTagHandler")]
			get {
				const string __id = "getTag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Node __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Node']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_duration;
#pragma warning disable 0169
		static Delegate GetDurationHandler ()
		{
			if (cb_duration == null)
				cb_duration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Duration);
			return cb_duration;
		}

		static long n_Duration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Node __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Node']/method[@name='duration' and count(parameter)=0]"
		[Register ("duration", "()J", "GetDurationHandler")]
		public virtual unsafe long Duration ()
		{
			const string __id = "duration.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_end;
#pragma warning disable 0169
		static Delegate GetEndHandler ()
		{
			if (cb_end == null)
				cb_end = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_End);
			return cb_end;
		}

		static void n_End (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Node __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.End ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Node']/method[@name='end' and count(parameter)=0]"
		[Register ("end", "()V", "GetEndHandler")]
		public virtual unsafe void End ()
		{
			const string __id = "end.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_record_BLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRecord_BLjava_lang_String_Handler ()
		{
			if (cb_record_BLjava_lang_String_ == null)
				cb_record_BLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, sbyte, IntPtr>) n_Record_BLjava_lang_String_);
			return cb_record_BLjava_lang_String_;
		}

		static void n_Record_BLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Node __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Record (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Node']/method[@name='record' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='java.lang.String']]"
		[Register ("record", "(BLjava/lang/String;)V", "GetRecord_BLjava_lang_String_Handler")]
		public virtual unsafe void Record (sbyte p0, string p1)
		{
			const string __id = "record.(BLjava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Node __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Node']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Node __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Node']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
