using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='UnsafeAllocator']"
	[global::Android.Runtime.Register ("com/google/gson/internal/UnsafeAllocator", DoNotGenerateAcw=true)]
	public abstract partial class UnsafeAllocator : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/UnsafeAllocator", typeof (UnsafeAllocator));
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

		protected UnsafeAllocator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal']/class[@name='UnsafeAllocator']/constructor[@name='UnsafeAllocator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UnsafeAllocator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='UnsafeAllocator']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/google/gson/internal/UnsafeAllocator;", "")]
		public static unsafe global::Com.Google.Gson.Internal.UnsafeAllocator Create ()
		{
			const string __id = "create.()Lcom/google/gson/internal/UnsafeAllocator;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.UnsafeAllocator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_newInstance_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetNewInstance_Ljava_lang_Class_Handler ()
		{
			if (cb_newInstance_Ljava_lang_Class_ == null)
				cb_newInstance_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewInstance_Ljava_lang_Class_);
			return cb_newInstance_Ljava_lang_Class_;
		}

		static IntPtr n_NewInstance_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.Internal.UnsafeAllocator __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.UnsafeAllocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewInstance (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='UnsafeAllocator']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("newInstance", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetNewInstance_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public abstract global::Java.Lang.Object NewInstance (global::Java.Lang.Class p0);

	}

	[global::Android.Runtime.Register ("com/google/gson/internal/UnsafeAllocator", DoNotGenerateAcw=true)]
	internal partial class UnsafeAllocatorInvoker : UnsafeAllocator {

		public UnsafeAllocatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/UnsafeAllocator", typeof (UnsafeAllocatorInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='UnsafeAllocator']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("newInstance", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetNewInstance_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public override unsafe global::Java.Lang.Object NewInstance (global::Java.Lang.Class p0)
		{
			const string __id = "newInstance.(Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
