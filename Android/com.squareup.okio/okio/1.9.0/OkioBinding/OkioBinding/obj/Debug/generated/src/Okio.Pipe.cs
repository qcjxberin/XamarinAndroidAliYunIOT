using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='Pipe']"
	[global::Android.Runtime.Register ("okio/Pipe", DoNotGenerateAcw=true)]
	public sealed partial class Pipe : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='Pipe.PipeSink']"
		[global::Android.Runtime.Register ("okio/Pipe$PipeSink", DoNotGenerateAcw=true)]
		public sealed partial class PipeSink : global::Java.Lang.Object, global::Okio.ISink {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okio/Pipe$PipeSink", typeof (PipeSink));
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

			internal PipeSink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Pipe.PipeSink']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "")]
			public unsafe void Close ()
			{
				const string __id = "close.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Pipe.PipeSink']/method[@name='flush' and count(parameter)=0]"
			[Register ("flush", "()V", "")]
			public unsafe void Flush ()
			{
				const string __id = "flush.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Pipe.PipeSink']/method[@name='timeout' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Pipe.PipeSink']/method[@name='write' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='Pipe.PipeSource']"
		[global::Android.Runtime.Register ("okio/Pipe$PipeSource", DoNotGenerateAcw=true)]
		public sealed partial class PipeSource : global::Java.Lang.Object, global::Okio.ISource {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okio/Pipe$PipeSource", typeof (PipeSource));
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

			internal PipeSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Pipe.PipeSource']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "")]
			public unsafe void Close ()
			{
				const string __id = "close.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Pipe.PipeSource']/method[@name='read' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Pipe.PipeSource']/method[@name='timeout' and count(parameter)=0]"
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/Pipe", typeof (Pipe));
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

		internal Pipe (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okio']/class[@name='Pipe']/constructor[@name='Pipe' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe Pipe (long maxBufferSize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxBufferSize);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Pipe']/method[@name='sink' and count(parameter)=0]"
		[Register ("sink", "()Lokio/Sink;", "")]
		public unsafe global::Okio.ISink Sink ()
		{
			const string __id = "sink.()Lokio/Sink;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.ISink> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Pipe']/method[@name='source' and count(parameter)=0]"
		[Register ("source", "()Lokio/Source;", "")]
		public unsafe global::Okio.ISource Source ()
		{
			const string __id = "source.()Lokio/Source;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.ISource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
