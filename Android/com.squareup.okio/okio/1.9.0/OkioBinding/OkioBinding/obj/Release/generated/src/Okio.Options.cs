using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='Options']"
	[global::Android.Runtime.Register ("okio/Options", DoNotGenerateAcw=true)]
	public sealed partial class Options : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/Options", typeof (Options));
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

		internal Options (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Options']/method[@name='of' and count(parameter)=1 and parameter[1][@type='okio.ByteString...']]"
		[Register ("of", "([Lokio/ByteString;)Lokio/Options;", "")]
		public static unsafe global::Okio.Options Of (params global::Okio.ByteString[] byteStrings)
		{
			const string __id = "of.([Lokio/ByteString;)Lokio/Options;";
			IntPtr native_byteStrings = JNIEnv.NewArray (byteStrings);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_byteStrings);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (byteStrings != null) {
					JNIEnv.CopyArray (native_byteStrings, byteStrings);
					JNIEnv.DeleteLocalRef (native_byteStrings);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Options']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "")]
		public override unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
