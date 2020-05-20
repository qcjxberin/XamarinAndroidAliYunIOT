using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Cache']"
	[global::Android.Runtime.Register ("okhttp3/Cache", DoNotGenerateAcw=true)]
	public sealed partial class Cache : global::Java.Lang.Object, global::Java.IO.ICloseable, global::Java.IO.IFlushable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Cache", typeof (Cache));
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

		internal Cache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/constructor[@name='Cache' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='long']]"
		[Register (".ctor", "(Ljava/io/File;J)V", "")]
		public unsafe Cache (global::Java.IO.File directory, long maxSize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/File;J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((directory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) directory).Handle);
				__args [1] = new JniArgumentValue (maxSize);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='isClosed' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "")]
		public unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='directory' and count(parameter)=0]"
		[Register ("directory", "()Ljava/io/File;", "")]
		public unsafe global::Java.IO.File Directory ()
		{
			const string __id = "directory.()Ljava/io/File;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='evictAll' and count(parameter)=0]"
		[Register ("evictAll", "()V", "")]
		public unsafe void EvictAll ()
		{
			const string __id = "evictAll.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='hitCount' and count(parameter)=0]"
		[Register ("hitCount", "()I", "")]
		public unsafe int HitCount ()
		{
			const string __id = "hitCount.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='initialize' and count(parameter)=0]"
		[Register ("initialize", "()V", "")]
		public unsafe void Initialize ()
		{
			const string __id = "initialize.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='maxSize' and count(parameter)=0]"
		[Register ("maxSize", "()J", "")]
		public unsafe long MaxSize ()
		{
			const string __id = "maxSize.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='networkCount' and count(parameter)=0]"
		[Register ("networkCount", "()I", "")]
		public unsafe int NetworkCount ()
		{
			const string __id = "networkCount.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='requestCount' and count(parameter)=0]"
		[Register ("requestCount", "()I", "")]
		public unsafe int RequestCount ()
		{
			const string __id = "requestCount.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='size' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='urls' and count(parameter)=0]"
		[Register ("urls", "()Ljava/util/Iterator;", "")]
		public unsafe global::Java.Util.IIterator Urls ()
		{
			const string __id = "urls.()Ljava/util/Iterator;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='writeAbortCount' and count(parameter)=0]"
		[Register ("writeAbortCount", "()I", "")]
		public unsafe int WriteAbortCount ()
		{
			const string __id = "writeAbortCount.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='writeSuccessCount' and count(parameter)=0]"
		[Register ("writeSuccessCount", "()I", "")]
		public unsafe int WriteSuccessCount ()
		{
			const string __id = "writeSuccessCount.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
