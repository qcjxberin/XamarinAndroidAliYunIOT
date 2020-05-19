using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='InflaterSource']"
	[global::Android.Runtime.Register ("okio/InflaterSource", DoNotGenerateAcw=true)]
	public sealed partial class InflaterSource : global::Java.Lang.Object, global::Okio.ISource {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/InflaterSource", typeof (InflaterSource));
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

		internal InflaterSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okio']/class[@name='InflaterSource']/constructor[@name='InflaterSource' and count(parameter)=2 and parameter[1][@type='okio.Source'] and parameter[2][@type='java.util.zip.Inflater']]"
		[Register (".ctor", "(Lokio/Source;Ljava/util/zip/Inflater;)V", "")]
		public unsafe InflaterSource (global::Okio.ISource source, global::Java.Util.Zip.Inflater inflater)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokio/Source;Ljava/util/zip/Inflater;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				__args [1] = new JniArgumentValue ((inflater == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inflater).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='InflaterSource']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='InflaterSource']/method[@name='read' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
		[Register ("read", "(Lokio/Buffer;J)J", "")]
		public unsafe long Read (global::Okio.Buffer sink, long byteCount)
		{
			const string __id = "read.(Lokio/Buffer;J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sink).Handle);
				__args [1] = new JniArgumentValue (byteCount);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='InflaterSource']/method[@name='refill' and count(parameter)=0]"
		[Register ("refill", "()Z", "")]
		public unsafe bool Refill ()
		{
			const string __id = "refill.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='InflaterSource']/method[@name='timeout' and count(parameter)=0]"
		[Register ("timeout", "()Lokio/Timeout;", "")]
		public unsafe global::Okio.Timeout Timeout ()
		{
			const string __id = "timeout.()Lokio/Timeout;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
