using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Headers']"
	[global::Android.Runtime.Register ("okhttp3/Headers", DoNotGenerateAcw=true)]
	public sealed partial class Headers : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Headers.Builder']"
		[global::Android.Runtime.Register ("okhttp3/Headers$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Headers$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Headers.Builder']/constructor[@name='Headers.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers.Builder']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("add", "(Ljava/lang/String;)Lokhttp3/Headers$Builder;", "")]
			public unsafe global::Okhttp3.Headers.Builder Add (string line)
			{
				const string __id = "add.(Ljava/lang/String;)Lokhttp3/Headers$Builder;";
				IntPtr native_line = JNIEnv.NewString (line);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_line);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_line);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers.Builder']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("add", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Headers$Builder;", "")]
			public unsafe global::Okhttp3.Headers.Builder Add (string name, string value)
			{
				const string __id = "add.(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Headers$Builder;";
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_value);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/Headers;", "")]
			public unsafe global::Okhttp3.Headers Build ()
			{
				const string __id = "build.()Lokhttp3/Headers;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers.Builder']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("get", "(Ljava/lang/String;)Ljava/lang/String;", "")]
			public unsafe string Get (string name)
			{
				const string __id = "get.(Ljava/lang/String;)Ljava/lang/String;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers.Builder']/method[@name='removeAll' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("removeAll", "(Ljava/lang/String;)Lokhttp3/Headers$Builder;", "")]
			public unsafe global::Okhttp3.Headers.Builder RemoveAll (string name)
			{
				const string __id = "removeAll.(Ljava/lang/String;)Lokhttp3/Headers$Builder;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers.Builder']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("set", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Headers$Builder;", "")]
			public unsafe global::Okhttp3.Headers.Builder Set (string name, string value)
			{
				const string __id = "set.(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Headers$Builder;";
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_value);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Headers", typeof (Headers));
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

		internal Headers (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string Get (string name)
		{
			const string __id = "get.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='getDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDate", "(Ljava/lang/String;)Ljava/util/Date;", "")]
		public unsafe global::Java.Util.Date GetDate (string name)
		{
			const string __id = "getDate.(Ljava/lang/String;)Ljava/util/Date;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='name' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("name", "(I)Ljava/lang/String;", "")]
		public unsafe string Name (int index)
		{
			const string __id = "name.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='names' and count(parameter)=0]"
		[Register ("names", "()Ljava/util/Set;", "")]
		public unsafe global::System.Collections.Generic.ICollection<string> Names ()
		{
			const string __id = "names.()Ljava/util/Set;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='newBuilder' and count(parameter)=0]"
		[Register ("newBuilder", "()Lokhttp3/Headers$Builder;", "")]
		public unsafe global::Okhttp3.Headers.Builder NewBuilder ()
		{
			const string __id = "newBuilder.()Lokhttp3/Headers$Builder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='of' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("of", "([Ljava/lang/String;)Lokhttp3/Headers;", "")]
		public static unsafe global::Okhttp3.Headers Of (params string[] namesAndValues)
		{
			const string __id = "of.([Ljava/lang/String;)Lokhttp3/Headers;";
			IntPtr native_namesAndValues = JNIEnv.NewArray (namesAndValues);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_namesAndValues);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (namesAndValues != null) {
					JNIEnv.CopyArray (native_namesAndValues, namesAndValues);
					JNIEnv.DeleteLocalRef (native_namesAndValues);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='of' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("of", "(Ljava/util/Map;)Lokhttp3/Headers;", "")]
		public static unsafe global::Okhttp3.Headers Of (global::System.Collections.Generic.IDictionary<string, string> headers)
		{
			const string __id = "of.(Ljava/util/Map;)Lokhttp3/Headers;";
			IntPtr native_headers = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_headers);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='size' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='toMultimap' and count(parameter)=0]"
		[Register ("toMultimap", "()Ljava/util/Map;", "")]
		public unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> ToMultimap ()
		{
			const string __id = "toMultimap.()Ljava/util/Map;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='value' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("value", "(I)Ljava/lang/String;", "")]
		public unsafe string Value (int index)
		{
			const string __id = "value.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='values' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("values", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<string> Values (string name)
		{
			const string __id = "values.(Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}
