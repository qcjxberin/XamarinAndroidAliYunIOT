using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	[Register ("okhttp3/Dns", DoNotGenerateAcw=true)]
	public abstract class Dns : Java.Lang.Object {

		internal Dns ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/interface[@name='Dns']/field[@name='SYSTEM']"
		[Register ("SYSTEM")]
		public static global::Okhttp3.IDns System {
			get {
				const string __id = "SYSTEM.Lokhttp3/Dns;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.IDns> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Dns", typeof (Dns));
	}

	[Register ("okhttp3/Dns", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'Dns' type. This type will be removed in a future release.", error: true)]
	public abstract class DnsConsts : Dns {

		private DnsConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3']/interface[@name='Dns']"
	[Register ("okhttp3/Dns", "", "Okhttp3.IDnsInvoker")]
	public partial interface IDns : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='Dns']/method[@name='lookup' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("lookup", "(Ljava/lang/String;)Ljava/util/List;", "GetLookup_Ljava_lang_String_Handler:Okhttp3.IDnsInvoker, OkHttpBinding")]
		global::System.Collections.Generic.IList<global::Java.Net.InetAddress> Lookup (string p0);

	}

	[global::Android.Runtime.Register ("okhttp3/Dns", DoNotGenerateAcw=true)]
	internal partial class IDnsInvoker : global::Java.Lang.Object, IDns {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Dns", typeof (IDnsInvoker));

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

		public static IDns GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDns> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.Dns"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDnsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_lookup_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLookup_Ljava_lang_String_Handler ()
		{
			if (cb_lookup_Ljava_lang_String_ == null)
				cb_lookup_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Lookup_Ljava_lang_String_);
			return cb_lookup_Ljava_lang_String_;
		}

		static IntPtr n_Lookup_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.IDns __this = global::Java.Lang.Object.GetObject<global::Okhttp3.IDns> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Java.Net.InetAddress>.ToLocalJniHandle (__this.Lookup (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_lookup_Ljava_lang_String_;
		public unsafe global::System.Collections.Generic.IList<global::Java.Net.InetAddress> Lookup (string p0)
		{
			if (id_lookup_Ljava_lang_String_ == IntPtr.Zero)
				id_lookup_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "lookup", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::System.Collections.Generic.IList<global::Java.Net.InetAddress> __ret = global::Android.Runtime.JavaList<global::Java.Net.InetAddress>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_lookup_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
