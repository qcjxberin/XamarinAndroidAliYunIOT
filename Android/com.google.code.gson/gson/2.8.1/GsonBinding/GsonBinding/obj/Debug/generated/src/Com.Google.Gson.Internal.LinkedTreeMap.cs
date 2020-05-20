using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LinkedTreeMap']"
	[global::Android.Runtime.Register ("com/google/gson/internal/LinkedTreeMap", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
	public sealed partial class LinkedTreeMap : global::Java.Util.AbstractMap, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LinkedTreeMap.Node']"
		[global::Android.Runtime.Register ("com/google/gson/internal/LinkedTreeMap$Node", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public sealed partial class Node : global::Java.Lang.Object, global::Java.Util.IMapEntry {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/LinkedTreeMap$Node", typeof (Node));
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

			internal Node (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe global::Java.Lang.Object Key {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LinkedTreeMap.Node']/method[@name='getKey' and count(parameter)=0]"
				[Register ("getKey", "()Ljava/lang/Object;", "")]
				get {
					const string __id = "getKey.()Ljava/lang/Object;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Object Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LinkedTreeMap.Node']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/Object;", "")]
				get {
					const string __id = "getValue.()Ljava/lang/Object;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LinkedTreeMap.Node']/method[@name='first' and count(parameter)=0]"
			[Register ("first", "()Ljava/lang/Object;", "")]
			public unsafe global::Java.Lang.Object First ()
			{
				const string __id = "first.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LinkedTreeMap.Node']/method[@name='last' and count(parameter)=0]"
			[Register ("last", "()Ljava/lang/Object;", "")]
			public unsafe global::Java.Lang.Object Last ()
			{
				const string __id = "last.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LinkedTreeMap.Node']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='V']]"
			[Register ("setValue", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
			public unsafe global::Java.Lang.Object SetValue (global::Java.Lang.Object value)
			{
				const string __id = "setValue.(Ljava/lang/Object;)Ljava/lang/Object;";
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/LinkedTreeMap", typeof (LinkedTreeMap));
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

		internal LinkedTreeMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LinkedTreeMap']/constructor[@name='LinkedTreeMap' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LinkedTreeMap ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LinkedTreeMap']/constructor[@name='LinkedTreeMap' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;? super K&gt;']]"
		[Register (".ctor", "(Ljava/util/Comparator;)V", "")]
		public unsafe LinkedTreeMap (global::Java.Util.IComparator comparator)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Comparator;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((comparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comparator).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LinkedTreeMap']/method[@name='entrySet' and count(parameter)=0]"
		[Register ("entrySet", "()Ljava/util/Set;", "")]
		public override unsafe global::System.Collections.Generic.ICollection<global::Java.Util.IMapEntry> EntrySet ()
		{
			const string __id = "entrySet.()Ljava/util/Set;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaSet<global::Java.Util.IMapEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LinkedTreeMap']/method[@name='put' and count(parameter)=2 and parameter[1][@type='K'] and parameter[2][@type='V']]"
		[Register ("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public override unsafe global::Java.Lang.Object Put (global::Java.Lang.Object key, global::Java.Lang.Object value)
		{
			const string __id = "put.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.ToLocalJniHandle (key);
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
