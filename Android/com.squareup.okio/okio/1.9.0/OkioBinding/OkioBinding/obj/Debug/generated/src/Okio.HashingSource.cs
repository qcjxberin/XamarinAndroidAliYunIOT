using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='HashingSource']"
	[global::Android.Runtime.Register ("okio/HashingSource", DoNotGenerateAcw=true)]
	public sealed partial class HashingSource : global::Okio.ForwardingSource {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/HashingSource", typeof (HashingSource));
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

		internal HashingSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='HashingSource']/method[@name='hash' and count(parameter)=0]"
		[Register ("hash", "()Lokio/ByteString;", "")]
		public unsafe global::Okio.ByteString Hash ()
		{
			const string __id = "hash.()Lokio/ByteString;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='HashingSource']/method[@name='md5' and count(parameter)=1 and parameter[1][@type='okio.Source']]"
		[Register ("md5", "(Lokio/Source;)Lokio/HashingSource;", "")]
		public static unsafe global::Okio.HashingSource Md5 (global::Okio.ISource source)
		{
			const string __id = "md5.(Lokio/Source;)Lokio/HashingSource;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.HashingSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='HashingSource']/method[@name='sha1' and count(parameter)=1 and parameter[1][@type='okio.Source']]"
		[Register ("sha1", "(Lokio/Source;)Lokio/HashingSource;", "")]
		public static unsafe global::Okio.HashingSource Sha1 (global::Okio.ISource source)
		{
			const string __id = "sha1.(Lokio/Source;)Lokio/HashingSource;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.HashingSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='HashingSource']/method[@name='sha256' and count(parameter)=1 and parameter[1][@type='okio.Source']]"
		[Register ("sha256", "(Lokio/Source;)Lokio/HashingSource;", "")]
		public static unsafe global::Okio.HashingSource Sha256 (global::Okio.ISource source)
		{
			const string __id = "sha256.(Lokio/Source;)Lokio/HashingSource;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.HashingSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
