using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.IO {

	[Register ("okhttp3/internal/io/FileSystem", DoNotGenerateAcw=true)]
	public abstract class FileSystem : Java.Lang.Object {

		internal FileSystem ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.io']/interface[@name='FileSystem']/field[@name='SYSTEM']"
		[Register ("SYSTEM")]
		public static global::Okhttp3.Internal.IO.IFileSystem System {
			get {
				const string __id = "SYSTEM.Lokhttp3/internal/io/FileSystem;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.IO.IFileSystem> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/io/FileSystem", typeof (FileSystem));
	}

	[Register ("okhttp3/internal/io/FileSystem", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'FileSystem' type. This type will be removed in a future release.", error: true)]
	public abstract class FileSystemConsts : FileSystem {

		private FileSystemConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3.internal.io']/interface[@name='FileSystem']"
	[Register ("okhttp3/internal/io/FileSystem", "", "Okhttp3.Internal.IO.IFileSystemInvoker")]
	public partial interface IFileSystem : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.io']/interface[@name='FileSystem']/method[@name='appendingSink' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("appendingSink", "(Ljava/io/File;)Lokio/Sink;", "GetAppendingSink_Ljava_io_File_Handler:Okhttp3.Internal.IO.IFileSystemInvoker, OkHttpBinding")]
		global::Okio.ISink AppendingSink (global::Java.IO.File p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.io']/interface[@name='FileSystem']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("delete", "(Ljava/io/File;)V", "GetDelete_Ljava_io_File_Handler:Okhttp3.Internal.IO.IFileSystemInvoker, OkHttpBinding")]
		void Delete (global::Java.IO.File p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.io']/interface[@name='FileSystem']/method[@name='deleteContents' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("deleteContents", "(Ljava/io/File;)V", "GetDeleteContents_Ljava_io_File_Handler:Okhttp3.Internal.IO.IFileSystemInvoker, OkHttpBinding")]
		void DeleteContents (global::Java.IO.File p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.io']/interface[@name='FileSystem']/method[@name='exists' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("exists", "(Ljava/io/File;)Z", "GetExists_Ljava_io_File_Handler:Okhttp3.Internal.IO.IFileSystemInvoker, OkHttpBinding")]
		bool Exists (global::Java.IO.File p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.io']/interface[@name='FileSystem']/method[@name='rename' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.io.File']]"
		[Register ("rename", "(Ljava/io/File;Ljava/io/File;)V", "GetRename_Ljava_io_File_Ljava_io_File_Handler:Okhttp3.Internal.IO.IFileSystemInvoker, OkHttpBinding")]
		void Rename (global::Java.IO.File p0, global::Java.IO.File p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.io']/interface[@name='FileSystem']/method[@name='sink' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("sink", "(Ljava/io/File;)Lokio/Sink;", "GetSink_Ljava_io_File_Handler:Okhttp3.Internal.IO.IFileSystemInvoker, OkHttpBinding")]
		global::Okio.ISink Sink (global::Java.IO.File p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.io']/interface[@name='FileSystem']/method[@name='size' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("size", "(Ljava/io/File;)J", "GetSize_Ljava_io_File_Handler:Okhttp3.Internal.IO.IFileSystemInvoker, OkHttpBinding")]
		long Size (global::Java.IO.File p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.io']/interface[@name='FileSystem']/method[@name='source' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("source", "(Ljava/io/File;)Lokio/Source;", "GetSource_Ljava_io_File_Handler:Okhttp3.Internal.IO.IFileSystemInvoker, OkHttpBinding")]
		global::Okio.ISource Source (global::Java.IO.File p0);

	}

	[global::Android.Runtime.Register ("okhttp3/internal/io/FileSystem", DoNotGenerateAcw=true)]
	internal partial class IFileSystemInvoker : global::Java.Lang.Object, IFileSystem {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/io/FileSystem", typeof (IFileSystemInvoker));

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

		public static IFileSystem GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFileSystem> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.internal.io.FileSystem"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFileSystemInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_appendingSink_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetAppendingSink_Ljava_io_File_Handler ()
		{
			if (cb_appendingSink_Ljava_io_File_ == null)
				cb_appendingSink_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AppendingSink_Ljava_io_File_);
			return cb_appendingSink_Ljava_io_File_;
		}

		static IntPtr n_AppendingSink_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.IO.IFileSystem __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.IO.IFileSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AppendingSink (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_appendingSink_Ljava_io_File_;
		public unsafe global::Okio.ISink AppendingSink (global::Java.IO.File p0)
		{
			if (id_appendingSink_Ljava_io_File_ == IntPtr.Zero)
				id_appendingSink_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "appendingSink", "(Ljava/io/File;)Lokio/Sink;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Okio.ISink __ret = global::Java.Lang.Object.GetObject<global::Okio.ISink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendingSink_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_delete_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetDelete_Ljava_io_File_Handler ()
		{
			if (cb_delete_Ljava_io_File_ == null)
				cb_delete_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Delete_Ljava_io_File_);
			return cb_delete_Ljava_io_File_;
		}

		static void n_Delete_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.IO.IFileSystem __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.IO.IFileSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Delete (p0);
		}
#pragma warning restore 0169

		IntPtr id_delete_Ljava_io_File_;
		public unsafe void Delete (global::Java.IO.File p0)
		{
			if (id_delete_Ljava_io_File_ == IntPtr.Zero)
				id_delete_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "delete", "(Ljava/io/File;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_Ljava_io_File_, __args);
		}

		static Delegate cb_deleteContents_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetDeleteContents_Ljava_io_File_Handler ()
		{
			if (cb_deleteContents_Ljava_io_File_ == null)
				cb_deleteContents_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteContents_Ljava_io_File_);
			return cb_deleteContents_Ljava_io_File_;
		}

		static void n_DeleteContents_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.IO.IFileSystem __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.IO.IFileSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteContents (p0);
		}
#pragma warning restore 0169

		IntPtr id_deleteContents_Ljava_io_File_;
		public unsafe void DeleteContents (global::Java.IO.File p0)
		{
			if (id_deleteContents_Ljava_io_File_ == IntPtr.Zero)
				id_deleteContents_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "deleteContents", "(Ljava/io/File;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteContents_Ljava_io_File_, __args);
		}

		static Delegate cb_exists_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetExists_Ljava_io_File_Handler ()
		{
			if (cb_exists_Ljava_io_File_ == null)
				cb_exists_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Exists_Ljava_io_File_);
			return cb_exists_Ljava_io_File_;
		}

		static bool n_Exists_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.IO.IFileSystem __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.IO.IFileSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Exists (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_exists_Ljava_io_File_;
		public unsafe bool Exists (global::Java.IO.File p0)
		{
			if (id_exists_Ljava_io_File_ == IntPtr.Zero)
				id_exists_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "exists", "(Ljava/io/File;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_exists_Ljava_io_File_, __args);
			return __ret;
		}

		static Delegate cb_rename_Ljava_io_File_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetRename_Ljava_io_File_Ljava_io_File_Handler ()
		{
			if (cb_rename_Ljava_io_File_Ljava_io_File_ == null)
				cb_rename_Ljava_io_File_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Rename_Ljava_io_File_Ljava_io_File_);
			return cb_rename_Ljava_io_File_Ljava_io_File_;
		}

		static void n_Rename_Ljava_io_File_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Okhttp3.Internal.IO.IFileSystem __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.IO.IFileSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p1 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Rename (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_rename_Ljava_io_File_Ljava_io_File_;
		public unsafe void Rename (global::Java.IO.File p0, global::Java.IO.File p1)
		{
			if (id_rename_Ljava_io_File_Ljava_io_File_ == IntPtr.Zero)
				id_rename_Ljava_io_File_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "rename", "(Ljava/io/File;Ljava/io/File;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_rename_Ljava_io_File_Ljava_io_File_, __args);
		}

		static Delegate cb_sink_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSink_Ljava_io_File_Handler ()
		{
			if (cb_sink_Ljava_io_File_ == null)
				cb_sink_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Sink_Ljava_io_File_);
			return cb_sink_Ljava_io_File_;
		}

		static IntPtr n_Sink_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.IO.IFileSystem __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.IO.IFileSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Sink (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sink_Ljava_io_File_;
		public unsafe global::Okio.ISink Sink (global::Java.IO.File p0)
		{
			if (id_sink_Ljava_io_File_ == IntPtr.Zero)
				id_sink_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "sink", "(Ljava/io/File;)Lokio/Sink;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Okio.ISink __ret = global::Java.Lang.Object.GetObject<global::Okio.ISink> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sink_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_size_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSize_Ljava_io_File_Handler ()
		{
			if (cb_size_Ljava_io_File_ == null)
				cb_size_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_Size_Ljava_io_File_);
			return cb_size_Ljava_io_File_;
		}

		static long n_Size_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.IO.IFileSystem __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.IO.IFileSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Size (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_size_Ljava_io_File_;
		public unsafe long Size (global::Java.IO.File p0)
		{
			if (id_size_Ljava_io_File_ == IntPtr.Zero)
				id_size_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "size", "(Ljava/io/File;)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_size_Ljava_io_File_, __args);
			return __ret;
		}

		static Delegate cb_source_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSource_Ljava_io_File_Handler ()
		{
			if (cb_source_Ljava_io_File_ == null)
				cb_source_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Source_Ljava_io_File_);
			return cb_source_Ljava_io_File_;
		}

		static IntPtr n_Source_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.IO.IFileSystem __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.IO.IFileSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Source (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_source_Ljava_io_File_;
		public unsafe global::Okio.ISource Source (global::Java.IO.File p0)
		{
			if (id_source_Ljava_io_File_ == IntPtr.Zero)
				id_source_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "source", "(Ljava/io/File;)Lokio/Source;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Okio.ISource __ret = global::Java.Lang.Object.GetObject<global::Okio.ISource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_source_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
