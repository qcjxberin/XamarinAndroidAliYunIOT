using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal']/class[@name='JavaNetHeaders']"
	[global::Android.Runtime.Register ("okhttp3/internal/JavaNetHeaders", DoNotGenerateAcw=true)]
	public sealed partial class JavaNetHeaders : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/JavaNetHeaders", typeof (JavaNetHeaders));
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

		internal JavaNetHeaders (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='JavaNetHeaders']/method[@name='toMultimap' and count(parameter)=2 and parameter[1][@type='okhttp3.Headers'] and parameter[2][@type='java.lang.String']]"
		[Register ("toMultimap", "(Lokhttp3/Headers;Ljava/lang/String;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> ToMultimap (global::Okhttp3.Headers headers, string valueForNullKey)
		{
			const string __id = "toMultimap.(Lokhttp3/Headers;Ljava/lang/String;)Ljava/util/Map;";
			IntPtr native_valueForNullKey = JNIEnv.NewString (valueForNullKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((headers == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headers).Handle);
				__args [1] = new JniArgumentValue (native_valueForNullKey);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_valueForNullKey);
			}
		}

	}
}
