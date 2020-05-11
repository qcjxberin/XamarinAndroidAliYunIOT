using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLogToFileUtils']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/OSSLogToFileUtils", DoNotGenerateAcw=true)]
	public partial class OSSLogToFileUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/OSSLogToFileUtils", typeof (OSSLogToFileUtils));
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

		protected OSSLogToFileUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Alibaba.Sdk.Android.Oss.Common.OSSLogToFileUtils Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLogToFileUtils']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/alibaba/sdk/android/oss/common/OSSLogToFileUtils;", "")]
			get {
				const string __id = "getInstance.()Lcom/alibaba/sdk/android/oss/common/OSSLogToFileUtils;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.OSSLogToFileUtils> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe long LocalLogFileSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLogToFileUtils']/method[@name='getLocalLogFileSize' and count(parameter)=0]"
			[Register ("getLocalLogFileSize", "()J", "")]
			get {
				const string __id = "getLocalLogFileSize.()J";
				try {
					var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_createNewFile_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetCreateNewFile_Ljava_io_File_Handler ()
		{
			if (cb_createNewFile_Ljava_io_File_ == null)
				cb_createNewFile_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CreateNewFile_Ljava_io_File_);
			return cb_createNewFile_Ljava_io_File_;
		}

		static void n_CreateNewFile_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_logFile)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.OSSLogToFileUtils __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.OSSLogToFileUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File logFile = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_logFile, JniHandleOwnership.DoNotTransfer);
			__this.CreateNewFile (logFile);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLogToFileUtils']/method[@name='createNewFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("createNewFile", "(Ljava/io/File;)V", "GetCreateNewFile_Ljava_io_File_Handler")]
		public virtual unsafe void CreateNewFile (global::Java.IO.File logFile)
		{
			const string __id = "createNewFile.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((logFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logFile).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_deleteLogFile;
#pragma warning disable 0169
		static Delegate GetDeleteLogFileHandler ()
		{
			if (cb_deleteLogFile == null)
				cb_deleteLogFile = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeleteLogFile);
			return cb_deleteLogFile;
		}

		static void n_DeleteLogFile (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.OSSLogToFileUtils __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.OSSLogToFileUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteLogFile ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLogToFileUtils']/method[@name='deleteLogFile' and count(parameter)=0]"
		[Register ("deleteLogFile", "()V", "GetDeleteLogFileHandler")]
		public virtual unsafe void DeleteLogFile ()
		{
			const string __id = "deleteLogFile.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_deleteLogFileDir;
#pragma warning disable 0169
		static Delegate GetDeleteLogFileDirHandler ()
		{
			if (cb_deleteLogFileDir == null)
				cb_deleteLogFileDir = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeleteLogFileDir);
			return cb_deleteLogFileDir;
		}

		static void n_DeleteLogFileDir (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.OSSLogToFileUtils __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.OSSLogToFileUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteLogFileDir ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLogToFileUtils']/method[@name='deleteLogFileDir' and count(parameter)=0]"
		[Register ("deleteLogFileDir", "()V", "GetDeleteLogFileDirHandler")]
		public virtual unsafe void DeleteLogFileDir ()
		{
			const string __id = "deleteLogFileDir.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLogToFileUtils']/method[@name='getLogFileSize' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getLogFileSize", "(Ljava/io/File;)J", "")]
		public static unsafe long GetLogFileSize (global::Java.IO.File file)
		{
			const string __id = "getLogFileSize.(Ljava/io/File;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLogToFileUtils']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.alibaba.sdk.android.oss.ClientConfiguration']]"
		[Register ("init", "(Landroid/content/Context;Lcom/alibaba/sdk/android/oss/ClientConfiguration;)V", "")]
		public static unsafe void Init (global::Android.Content.Context context, global::Com.Alibaba.Sdk.Android.Oss.ClientConfiguration cfg)
		{
			const string __id = "init.(Landroid/content/Context;Lcom/alibaba/sdk/android/oss/ClientConfiguration;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((cfg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cfg).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLogToFileUtils']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public static unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		static Delegate cb_resetLogFile;
#pragma warning disable 0169
		static Delegate GetResetLogFileHandler ()
		{
			if (cb_resetLogFile == null)
				cb_resetLogFile = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetLogFile);
			return cb_resetLogFile;
		}

		static void n_ResetLogFile (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.OSSLogToFileUtils __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.OSSLogToFileUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetLogFile ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLogToFileUtils']/method[@name='resetLogFile' and count(parameter)=0]"
		[Register ("resetLogFile", "()V", "GetResetLogFileHandler")]
		public virtual unsafe void ResetLogFile ()
		{
			const string __id = "resetLogFile.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setUseSdCard_Z;
#pragma warning disable 0169
		static Delegate GetSetUseSdCard_ZHandler ()
		{
			if (cb_setUseSdCard_Z == null)
				cb_setUseSdCard_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUseSdCard_Z);
			return cb_setUseSdCard_Z;
		}

		static void n_SetUseSdCard_Z (IntPtr jnienv, IntPtr native__this, bool useSdCard)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.OSSLogToFileUtils __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.OSSLogToFileUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUseSdCard (useSdCard);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLogToFileUtils']/method[@name='setUseSdCard' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUseSdCard", "(Z)V", "GetSetUseSdCard_ZHandler")]
		public virtual unsafe void SetUseSdCard (bool useSdCard)
		{
			const string __id = "setUseSdCard.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (useSdCard);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_write_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_lang_Object_Handler ()
		{
			if (cb_write_Ljava_lang_Object_ == null)
				cb_write_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Ljava_lang_Object_);
			return cb_write_Ljava_lang_Object_;
		}

		static void n_Write_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.OSSLogToFileUtils __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.OSSLogToFileUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object str = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_str, JniHandleOwnership.DoNotTransfer);
			__this.Write (str);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLogToFileUtils']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("write", "(Ljava/lang/Object;)V", "GetWrite_Ljava_lang_Object_Handler")]
		public virtual unsafe void Write (global::Java.Lang.Object str)
		{
			const string __id = "write.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((str == null) ? IntPtr.Zero : ((global::Java.Lang.Object) str).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
