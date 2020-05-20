using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']"
	[global::Android.Runtime.Register ("com/google/gson/JsonArray", DoNotGenerateAcw=true)]
	public sealed partial class JsonArray : global::Com.Google.Gson.JsonElement, global::Java.Lang.IIterable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/JsonArray", typeof (JsonArray));
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

		internal JsonArray (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/constructor[@name='JsonArray' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JsonArray ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/constructor[@name='JsonArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe JsonArray (int capacity)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (capacity);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.google.gson.JsonElement']]"
		[Register ("add", "(Lcom/google/gson/JsonElement;)V", "")]
		public unsafe void Add (global::Com.Google.Gson.JsonElement element)
		{
			const string __id = "add.(Lcom/google/gson/JsonElement;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((element == null) ? IntPtr.Zero : ((global::Java.Lang.Object) element).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("add", "(Ljava/lang/Boolean;)V", "")]
		public unsafe void Add (global::Java.Lang.Boolean @bool)
		{
			const string __id = "add.(Ljava/lang/Boolean;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@bool == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @bool).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.Character']]"
		[Register ("add", "(Ljava/lang/Character;)V", "")]
		public unsafe void Add (global::Java.Lang.Character character)
		{
			const string __id = "add.(Ljava/lang/Character;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((character == null) ? IntPtr.Zero : ((global::Java.Lang.Object) character).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("add", "(Ljava/lang/Number;)V", "")]
		public unsafe void Add (global::Java.Lang.Number number)
		{
			const string __id = "add.(Ljava/lang/Number;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("add", "(Ljava/lang/String;)V", "")]
		public unsafe void Add (string @string)
		{
			const string __id = "add.(Ljava/lang/String;)V";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__string);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='com.google.gson.JsonArray']]"
		[Register ("addAll", "(Lcom/google/gson/JsonArray;)V", "")]
		public unsafe void AddAll (global::Com.Google.Gson.JsonArray array)
		{
			const string __id = "addAll.(Lcom/google/gson/JsonArray;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((array == null) ? IntPtr.Zero : ((global::Java.Lang.Object) array).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='com.google.gson.JsonElement']]"
		[Register ("contains", "(Lcom/google/gson/JsonElement;)Z", "")]
		public unsafe bool Contains (global::Com.Google.Gson.JsonElement element)
		{
			const string __id = "contains.(Lcom/google/gson/JsonElement;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((element == null) ? IntPtr.Zero : ((global::Java.Lang.Object) element).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement Get (int i)
		{
			const string __id = "get.(I)Lcom/google/gson/JsonElement;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "")]
		public unsafe global::Java.Util.IIterator Iterator ()
		{
			const string __id = "iterator.()Ljava/util/Iterator;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='com.google.gson.JsonElement']]"
		[Register ("remove", "(Lcom/google/gson/JsonElement;)Z", "")]
		public unsafe bool Remove (global::Com.Google.Gson.JsonElement element)
		{
			const string __id = "remove.(Lcom/google/gson/JsonElement;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((element == null) ? IntPtr.Zero : ((global::Java.Lang.Object) element).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("remove", "(I)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement Remove (int index)
		{
			const string __id = "remove.(I)Lcom/google/gson/JsonElement;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.gson.JsonElement']]"
		[Register ("set", "(ILcom/google/gson/JsonElement;)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement Set (int index, global::Com.Google.Gson.JsonElement element)
		{
			const string __id = "set.(ILcom/google/gson/JsonElement;)Lcom/google/gson/JsonElement;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue ((element == null) ? IntPtr.Zero : ((global::Java.Lang.Object) element).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "")]
		public unsafe int Size ()
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
