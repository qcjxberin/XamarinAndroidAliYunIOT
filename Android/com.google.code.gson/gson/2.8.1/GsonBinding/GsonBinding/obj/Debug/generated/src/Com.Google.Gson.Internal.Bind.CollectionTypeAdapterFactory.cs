using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Internal.Bind {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='CollectionTypeAdapterFactory']"
	[global::Android.Runtime.Register ("com/google/gson/internal/bind/CollectionTypeAdapterFactory", DoNotGenerateAcw=true)]
	public sealed partial class CollectionTypeAdapterFactory : global::Java.Lang.Object, global::Com.Google.Gson.ITypeAdapterFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/bind/CollectionTypeAdapterFactory", typeof (CollectionTypeAdapterFactory));
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

		internal CollectionTypeAdapterFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='CollectionTypeAdapterFactory']/constructor[@name='CollectionTypeAdapterFactory' and count(parameter)=1 and parameter[1][@type='com.google.gson.internal.ConstructorConstructor']]"
		[Register (".ctor", "(Lcom/google/gson/internal/ConstructorConstructor;)V", "")]
		public unsafe CollectionTypeAdapterFactory (global::Com.Google.Gson.Internal.ConstructorConstructor constructorConstructor)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/google/gson/internal/ConstructorConstructor;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((constructorConstructor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) constructorConstructor).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='CollectionTypeAdapterFactory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='com.google.gson.Gson'] and parameter[2][@type='com.google.gson.reflect.TypeToken&lt;T&gt;']]"
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
