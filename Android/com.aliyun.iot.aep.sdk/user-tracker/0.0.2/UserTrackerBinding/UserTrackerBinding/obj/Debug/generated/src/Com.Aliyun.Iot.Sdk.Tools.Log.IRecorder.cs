using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Sdk.Tools.Log {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/interface[@name='Recorder']"
	[Register ("com/aliyun/iot/sdk/tools/log/Recorder", "", "Com.Aliyun.Iot.Sdk.Tools.Log.IRecorderInvoker")]
	public partial interface IRecorder : IJavaObject, IJavaPeerable {

		global::System.Collections.Generic.IList<global::Com.Aliyun.Iot.Sdk.Tools.Log.Record> AllRecords {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/interface[@name='Recorder']/method[@name='getAllRecords' and count(parameter)=0]"
			[Register ("getAllRecords", "()Ljava/util/List;", "GetGetAllRecordsHandler:Com.Aliyun.Iot.Sdk.Tools.Log.IRecorderInvoker, UserTrackerBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/interface[@name='Recorder']/method[@name='currentRecord' and count(parameter)=0]"
		[Register ("currentRecord", "()Lcom/aliyun/iot/sdk/tools/log/Record;", "GetCurrentRecordHandler:Com.Aliyun.Iot.Sdk.Tools.Log.IRecorderInvoker, UserTrackerBinding")]
		global::Com.Aliyun.Iot.Sdk.Tools.Log.Record CurrentRecord ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/interface[@name='Recorder']/method[@name='endRecord' and count(parameter)=0]"
		[Register ("endRecord", "()V", "GetEndRecordHandler:Com.Aliyun.Iot.Sdk.Tools.Log.IRecorderInvoker, UserTrackerBinding")]
		void EndRecord ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/interface[@name='Recorder']/method[@name='record' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("record", "(BLjava/lang/String;Ljava/lang/String;)V", "GetRecord_BLjava_lang_String_Ljava_lang_String_Handler:Com.Aliyun.Iot.Sdk.Tools.Log.IRecorderInvoker, UserTrackerBinding")]
		void Record (sbyte p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.log']/interface[@name='Recorder']/method[@name='startRecord' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("startRecord", "(Ljava/lang/String;)V", "GetStartRecord_Ljava_lang_String_Handler:Com.Aliyun.Iot.Sdk.Tools.Log.IRecorderInvoker, UserTrackerBinding")]
		void StartRecord (string p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/iot/sdk/tools/log/Recorder", DoNotGenerateAcw=true)]
	internal partial class IRecorderInvoker : global::Java.Lang.Object, IRecorder {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/sdk/tools/log/Recorder", typeof (IRecorderInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IRecorder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRecorder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.sdk.tools.log.Recorder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRecorderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAllRecords;
#pragma warning disable 0169
		static Delegate GetGetAllRecordsHandler ()
		{
			if (cb_getAllRecords == null)
				cb_getAllRecords = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllRecords);
			return cb_getAllRecords;
		}

		static IntPtr n_GetAllRecords (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.IRecorder __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.IRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Aliyun.Iot.Sdk.Tools.Log.Record>.ToLocalJniHandle (__this.AllRecords);
		}
#pragma warning restore 0169

		IntPtr id_getAllRecords;
		public unsafe global::System.Collections.Generic.IList<global::Com.Aliyun.Iot.Sdk.Tools.Log.Record> AllRecords {
			get {
				if (id_getAllRecords == IntPtr.Zero)
					id_getAllRecords = JNIEnv.GetMethodID (class_ref, "getAllRecords", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Aliyun.Iot.Sdk.Tools.Log.Record>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllRecords), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_currentRecord;
#pragma warning disable 0169
		static Delegate GetCurrentRecordHandler ()
		{
			if (cb_currentRecord == null)
				cb_currentRecord = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CurrentRecord);
			return cb_currentRecord;
		}

		static IntPtr n_CurrentRecord (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.IRecorder __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.IRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentRecord ());
		}
#pragma warning restore 0169

		IntPtr id_currentRecord;
		public unsafe global::Com.Aliyun.Iot.Sdk.Tools.Log.Record CurrentRecord ()
		{
			if (id_currentRecord == IntPtr.Zero)
				id_currentRecord = JNIEnv.GetMethodID (class_ref, "currentRecord", "()Lcom/aliyun/iot/sdk/tools/log/Record;");
			return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.Record> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_currentRecord), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_endRecord;
#pragma warning disable 0169
		static Delegate GetEndRecordHandler ()
		{
			if (cb_endRecord == null)
				cb_endRecord = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EndRecord);
			return cb_endRecord;
		}

		static void n_EndRecord (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.IRecorder __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.IRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndRecord ();
		}
#pragma warning restore 0169

		IntPtr id_endRecord;
		public unsafe void EndRecord ()
		{
			if (id_endRecord == IntPtr.Zero)
				id_endRecord = JNIEnv.GetMethodID (class_ref, "endRecord", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_endRecord);
		}

		static Delegate cb_record_BLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRecord_BLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_record_BLjava_lang_String_Ljava_lang_String_ == null)
				cb_record_BLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, sbyte, IntPtr, IntPtr>) n_Record_BLjava_lang_String_Ljava_lang_String_);
			return cb_record_BLjava_lang_String_Ljava_lang_String_;
		}

		static void n_Record_BLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.IRecorder __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.IRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Record (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_record_BLjava_lang_String_Ljava_lang_String_;
		public unsafe void Record (sbyte p0, string p1, string p2)
		{
			if (id_record_BLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_record_BLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "record", "(BLjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_record_BLjava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_startRecord_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStartRecord_Ljava_lang_String_Handler ()
		{
			if (cb_startRecord_Ljava_lang_String_ == null)
				cb_startRecord_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartRecord_Ljava_lang_String_);
			return cb_startRecord_Ljava_lang_String_;
		}

		static void n_StartRecord_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Iot.Sdk.Tools.Log.IRecorder __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Log.IRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartRecord (p0);
		}
#pragma warning restore 0169

		IntPtr id_startRecord_Ljava_lang_String_;
		public unsafe void StartRecord (string p0)
		{
			if (id_startRecord_Ljava_lang_String_ == IntPtr.Zero)
				id_startRecord_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "startRecord", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startRecord_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
