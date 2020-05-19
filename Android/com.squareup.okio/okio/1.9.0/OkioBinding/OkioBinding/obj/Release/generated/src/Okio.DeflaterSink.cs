using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='DeflaterSink']"
	[global::Android.Runtime.Register ("okio/DeflaterSink", DoNotGenerateAcw=true)]
	public sealed partial class DeflaterSink : global::Java.Lang.Object, global::Okio.ISink {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/DeflaterSink", typeof (DeflaterSink));
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

		internal DeflaterSink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okio']/class[@name='DeflaterSink']/constructor[@name='DeflaterSink' and count(parameter)=2 and parameter[1][@type='okio.Sink'] and parameter[2][@type='java.util.zip.Deflater']]"
		[Register (".ctor", "(Lokio/Sink;Ljava/util/zip/Deflater;)V", "")]
		public unsafe DeflaterSink (global::Okio.ISink sink, global::Java.Util.Zip.Deflater deflater)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokio/Sink;Ljava/util/zip/Deflater;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sink).Handle);
				__args [1] = new JniArgumentValue ((deflater == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deflater).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='DeflaterSink']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='DeflaterSink']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='DeflaterSink']/method[@name='timeout' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='DeflaterSink']/method[@name='write' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
		[Register ("write", "(Lokio/Buffer;J)V", "")]
		public unsafe void Write (global::Okio.Buffer source, long byteCount)
		{
			const string __id = "write.(Lokio/Buffer;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				__args [1] = new JniArgumentValue (byteCount);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
