using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Internal.Bind {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='MapTypeAdapterFactory']"
	[global::Android.Runtime.Register ("com/google/gson/internal/bind/MapTypeAdapterFactory", DoNotGenerateAcw=true)]
	public sealed partial class MapTypeAdapterFactory : global::Java.Lang.Object, global::Com.Google.Gson.ITypeAdapterFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/bind/MapTypeAdapterFactory", typeof (MapTypeAdapterFactory));
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

		internal MapTypeAdapterFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='MapTypeAdapterFactory']/constructor[@name='MapTypeAdapterFactory' and count(parameter)=2 and parameter[1][@type='com.google.gson.internal.ConstructorConstructor'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Lcom/google/gson/internal/ConstructorConstructor;Z)V", "")]
		public unsafe MapTypeAdapterFactory (global::Com.Google.Gson.Internal.ConstructorConstructor constructorConstructor, bool complexMapKeySerialization)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/google/gson/internal/ConstructorConstructor;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((constructorConstructor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) constructorConstructor).Handle);
				__args [1] = new JniArgumentValue (complexMapKeySerialization);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='MapTypeAdapterFactory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='com.google.gson.Gson'] and parameter[2][@type='com.google.gson.reflect.TypeToken&lt;T&gt;']]"
		[Register ("create", "(Lcom/google/gson/Gson;Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Com.Google.Gson.TypeAdapter Create (global::Com.Google.Gson.Gson gson, global::Com.Google.Gson.Reflect.TypeToken typeToken)
		{
			const string __id = "create.(Lcom/google/gson/Gson;Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((gson == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gson).Handle);
				__args [1] = new JniArgumentValue ((typeToken == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeToken).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
