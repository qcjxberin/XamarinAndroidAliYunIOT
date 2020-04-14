using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Sdk.Tools.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Record']"
	[global::Android.Runtime.Register ("com/aliyun/iot/sdk/tools/log/Record", DoNotGenerateAcw=true)]
	public partial class Record : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Record']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/sdk/tools/log/Record", typeof (Record));
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

		protected Record (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Record']/constructor[@name='Record' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Record ()
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

		static Delegate cb_getEndTime;
#pragma warning disable 0169
		static Delegate GetGetEndTimeHandler ()
		{
			if (cb_getEndTime == null)
				cb_getEndTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetEndTime);
			return cb_getEndTime;
		}

		static long n_GetEndTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Record __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Record> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EndTime;
		}
#pragma warning restore 0169

		static Delegate cb_setEndTime_J;
#pragma warning disable 0169
		static Delegate GetSetEndTime_JHandler ()
		{
			if (cb_setEndTime_J == null)
				cb_setEndTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetEndTime_J);
			return cb_setEndTime_J;
		}

		static void n_SetEndTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Record __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Record> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndTime = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long EndTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Record']/method[@name='getEndTime' and count(parameter)=0]"
			[Register ("getEndTime", "()J", "GetGetEndTimeHandler")]
			get {
				const string __id = "getEndTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Record']/method[@name='setEndTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setEndTime", "(J)V", "GetSetEndTime_JHandler")]
			set {
				const string __id = "setEndTime.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNodes;
#pragma warning disable 0169
		static Delegate GetGetNodesHandler ()
		{
			if (cb_getNodes == null)
				cb_getNodes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNodes);
			return cb_getNodes;
		}

		static IntPtr n_GetNodes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Record __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Record> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Aliyun.Iot.Sdk.Tools.Log.Node>.ToLocalJniHandle (__this.Nodes);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Aliyun.Iot.Sdk.Tools.Log.Node> Nodes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Record']/method[@name='getNodes' and count(parameter)=0]"
			[Register ("getNodes", "()Ljava/util/Set;", "GetGetNodesHandler")]
			get {
				const string __id = "getNodes.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Com.Aliyun.Iot.Sdk.Tools.Log.Node>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPluginId;
#pragma warning disable 0169
		static Delegate GetGetPluginIdHandler ()
		{
			if (cb_getPluginId == null)
				cb_getPluginId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPluginId);
			return cb_getPluginId;
		}

		static IntPtr n_GetPluginId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Record __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Record> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PluginId);
		}
#pragma warning restore 0169

		static Delegate cb_setPluginId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPluginId_Ljava_lang_String_Handler ()
		{
			if (cb_setPluginId_Ljava_lang_String_ == null)
				cb_setPluginId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPluginId_Ljava_lang_String_);
			return cb_setPluginId_Ljava_lang_String_;
		}

		static void n_SetPluginId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Record __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Record> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PluginId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string PluginId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Record']/method[@name='getPluginId' and count(parameter)=0]"
			[Register ("getPluginId", "()Ljava/lang/String;", "GetGetPluginIdHandler")]
			get {
				const string __id = "getPluginId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Record']/method[@name='setPluginId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPluginId", "(Ljava/lang/String;)V", "GetSetPluginId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setPluginId.(Ljava/lang/String;)V";
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

		static Delegate cb_getStartTime;
#pragma warning disable 0169
		static Delegate GetGetStartTimeHandler ()
		{
			if (cb_getStartTime == null)
				cb_getStartTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetStartTime);
			return cb_getStartTime;
		}

		static long n_GetStartTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Record __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Record> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartTime;
		}
#pragma warning restore 0169

		static Delegate cb_setStartTime_J;
#pragma warning disable 0169
		static Delegate GetSetStartTime_JHandler ()
		{
			if (cb_setStartTime_J == null)
				cb_setStartTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetStartTime_J);
			return cb_setStartTime_J;
		}

		static void n_SetStartTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Record __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Record> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartTime = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long StartTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Record']/method[@name='getStartTime' and count(parameter)=0]"
			[Register ("getStartTime", "()J", "GetGetStartTimeHandler")]
			get {
				const string __id = "getStartTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Record']/method[@name='setStartTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setStartTime", "(J)V", "GetSetStartTime_JHandler")]
			set {
				const string __id = "setStartTime.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Record __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Record> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Record']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_readMessage;
#pragma warning disable 0169
		static Delegate GetReadMessageHandler ()
		{
			if (cb_readMessage == null)
				cb_readMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadMessage);
			return cb_readMessage;
		}

		static IntPtr n_ReadMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Record __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Record> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Aliyun.Iot.Sdk.Tools.Log.LogEntry>.ToLocalJniHandle (__this.ReadMessage ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Record']/method[@name='readMessage' and count(parameter)=0]"
		[Register ("readMessage", "()Ljava/util/List;", "GetReadMessageHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Aliyun.Iot.Sdk.Tools.Log.LogEntry> ReadMessage ()
		{
			const string __id = "readMessage.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Com.Aliyun.Iot.Sdk.Tools.Log.LogEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readNode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReadNode_Ljava_lang_String_Handler ()
		{
			if (cb_readNode_Ljava_lang_String_ == null)
				cb_readNode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReadNode_Ljava_lang_String_);
			return cb_readNode_Ljava_lang_String_;
		}

		static IntPtr n_ReadNode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Record __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Record> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReadNode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Record']/method[@name='readNode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readNode", "(Ljava/lang/String;)Lcom/aliyun/iot/sdk/tools/log/Node;", "GetReadNode_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Iot.Sdk.Tools.Log.Node ReadNode (string p0)
		{
			const string __id = "readNode.(Ljava/lang/String;)Lcom/aliyun/iot/sdk/tools/log/Node;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Node> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_record_BLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeRecord_BLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_record_BLjava_lang_String_Ljava_lang_String_ == null)
				cb_record_BLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, sbyte, IntPtr, IntPtr>) n_InvokeRecord_BLjava_lang_String_Ljava_lang_String_);
			return cb_record_BLjava_lang_String_Ljava_lang_String_;
		}

		static void n_InvokeRecord_BLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Record __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Record> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.InvokeRecord (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Record']/method[@name='record' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("record", "(BLjava/lang/String;Ljava/lang/String;)V", "GetInvokeRecord_BLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void InvokeRecord (sbyte p0, string p1, string p2)
		{
			const string __id = "record.(BLjava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
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
			global::Com.Aliyun.Iot.Sdk.Tools.Log.Record __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Record> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/class[@name='Record']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
