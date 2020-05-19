using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache']"
	[global::Android.Runtime.Register ("okhttp3/internal/DiskLruCache", DoNotGenerateAcw=true)]
	public sealed partial class DiskLruCache : global::Java.Lang.Object, global::Java.IO.ICloseable, global::Java.IO.IFlushable {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache.Editor']"
		[global::Android.Runtime.Register ("okhttp3/internal/DiskLruCache$Editor", DoNotGenerateAcw=true)]
		public sealed partial class Editor : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/DiskLruCache$Editor", typeof (Editor));
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

			internal Editor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache.Editor']/method[@name='abort' and count(parameter)=0]"
			[Register ("abort", "()V", "")]
			public unsafe void Abort ()
			{
				const string __id = "abort.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache.Editor']/method[@name='abortUnlessCommitted' and count(parameter)=0]"
			[Register ("abortUnlessCommitted", "()V", "")]
			public unsafe void AbortUnlessCommitted ()
			{
				const string __id = "abortUnlessCommitted.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache.Editor']/method[@name='commit' and count(parameter)=0]"
			[Register ("commit", "()V", "")]
			public unsafe void Commit ()
			{
				const string __id = "commit.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache.Snapshot']"
		[global::Android.Runtime.Register ("okhttp3/internal/DiskLruCache$Snapshot", DoNotGenerateAcw=true)]
		public sealed partial class Snapshot : global::Java.Lang.Object, global::Java.IO.ICloseable {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/DiskLruCache$Snapshot", typeof (Snapshot));
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

			internal Snapshot (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache.Snapshot']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "")]
			public unsafe void Close ()
			{
				const string __id = "close.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache.Snapshot']/method[@name='edit' and count(parameter)=0]"
			[Register ("edit", "()Lokhttp3/internal/DiskLruCache$Editor;", "")]
			public unsafe global::Okhttp3.Internal.DiskLruCache.Editor Edit ()
			{
				const string __id = "edit.()Lokhttp3/internal/DiskLruCache$Editor;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.DiskLruCache.Editor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache.Snapshot']/method[@name='getLength' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getLength", "(I)J", "")]
			public unsafe long GetLength (int index)
			{
				const string __id = "getLength.(I)J";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (index);
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache.Snapshot']/method[@name='key' and count(parameter)=0]"
			[Register ("key", "()Ljava/lang/String;", "")]
			public unsafe string Key ()
			{
				const string __id = "key.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/DiskLruCache", typeof (DiskLruCache));
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

		internal DiskLruCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::Java.IO.File Directory {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache']/method[@name='getDirectory' and count(parameter)=0]"
			[Register ("getDirectory", "()Ljava/io/File;", "")]
			get {
				const string __id = "getDirectory.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "")]
			get {
				const string __id = "isClosed.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long MaxSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache']/method[@name='getMaxSize' and count(parameter)=0]"
			[Register ("getMaxSize", "()J", "")]
			get {
				const string __id = "getMaxSize.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache']/method[@name='setMaxSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMaxSize", "(J)V", "")]
			set {
				const string __id = "setMaxSize.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache']/method[@name='create' and count(parameter)=5 and parameter[1][@type='okhttp3.internal.io.FileSystem'] and parameter[2][@type='java.io.File'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='long']]"
		[Register ("create", "(Lokhttp3/internal/io/FileSystem;Ljava/io/File;IIJ)Lokhttp3/internal/DiskLruCache;", "")]
		public static unsafe global::Okhttp3.Internal.DiskLruCache Create (global::Okhttp3.Internal.IO.IFileSystem fileSystem, global::Java.IO.File directory, int appVersion, int valueCount, long maxSize)
		{
			const string __id = "create.(Lokhttp3/internal/io/FileSystem;Ljava/io/File;IIJ)Lokhttp3/internal/DiskLruCache;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((fileSystem == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fileSystem).Handle);
				__args [1] = new JniArgumentValue ((directory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) directory).Handle);
				__args [2] = new JniArgumentValue (appVersion);
				__args [3] = new JniArgumentValue (valueCount);
				__args [4] = new JniArgumentValue (maxSize);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.DiskLruCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "")]
		public unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache']/method[@name='edit' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("edit", "(Ljava/lang/String;)Lokhttp3/internal/DiskLruCache$Editor;", "")]
		public unsafe global::Okhttp3.Internal.DiskLruCache.Editor Edit (string key)
		{
			const string __id = "edit.(Ljava/lang/String;)Lokhttp3/internal/DiskLruCache$Editor;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.DiskLruCache.Editor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache']/method[@name='evictAll' and count(parameter)=0]"
		[Register ("evictAll", "()V", "")]
		public unsafe void EvictAll ()
		{
			const string __id = "evictAll.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lokhttp3/internal/DiskLruCache$Snapshot;", "")]
		public unsafe global::Okhttp3.Internal.DiskLruCache.Snapshot Get (string key)
		{
			const string __id = "get.(Ljava/lang/String;)Lokhttp3/internal/DiskLruCache$Snapshot;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.DiskLruCache.Snapshot> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache']/method[@name='initialize' and count(parameter)=0]"
		[Register ("initialize", "()V", "")]
		public unsafe void Initialize ()
		{
			const string __id = "initialize.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)Z", "")]
		public unsafe bool Remove (string key)
		{
			const string __id = "remove.(Ljava/lang/String;)Z";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()J", "")]
		public unsafe long Size ()
		{
			const string __id = "size.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='DiskLruCache']/method[@name='snapshots' and count(parameter)=0]"
		[Register ("snapshots", "()Ljava/util/Iterator;", "")]
		public unsafe global::Java.Util.IIterator Snapshots ()
		{
			const string __id = "snapshots.()Ljava/util/Iterator;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
