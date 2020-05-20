using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/option/OptionNumberRegistry", DoNotGenerateAcw=true)]
	public partial class OptionNumberRegistry : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='ACCEPT']"
		[Register ("ACCEPT")]
		public const int Accept = (int) 17;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='BLOCK1']"
		[Register ("BLOCK1")]
		public const int Block1 = (int) 27;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='BLOCK2']"
		[Register ("BLOCK2")]
		public const int Block2 = (int) 23;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='CONTENT_FORMAT']"
		[Register ("CONTENT_FORMAT")]
		public const int ContentFormat = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='ETAG']"
		[Register ("ETAG")]
		public const int Etag = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='IF_MATCH']"
		[Register ("IF_MATCH")]
		public const int IfMatch = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='IF_NONE_MATCH']"
		[Register ("IF_NONE_MATCH")]
		public const int IfNoneMatch = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='LOCATION_PATH']"
		[Register ("LOCATION_PATH")]
		public const int LocationPath = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='LOCATION_QUERY']"
		[Register ("LOCATION_QUERY")]
		public const int LocationQuery = (int) 20;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='MAX_AGE']"
		[Register ("MAX_AGE")]
		public const int MaxAge = (int) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='OBSERVE']"
		[Register ("OBSERVE")]
		public const int Observe = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='PROXY_SCHEME']"
		[Register ("PROXY_SCHEME")]
		public const int ProxyScheme = (int) 39;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='PROXY_URI']"
		[Register ("PROXY_URI")]
		public const int ProxyUri = (int) 35;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='RESERVED_0']"
		[Register ("RESERVED_0")]
		public const int Reserved0 = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='RESERVED_1']"
		[Register ("RESERVED_1")]
		public const int Reserved1 = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='RESERVED_2']"
		[Register ("RESERVED_2")]
		public const int Reserved2 = (int) 132;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='RESERVED_3']"
		[Register ("RESERVED_3")]
		public const int Reserved3 = (int) 136;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='RESERVED_4']"
		[Register ("RESERVED_4")]
		public const int Reserved4 = (int) 140;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='SIZE1']"
		[Register ("SIZE1")]
		public const int Size1 = (int) 60;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='SIZE2']"
		[Register ("SIZE2")]
		public const int Size2 = (int) 28;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public const int Unknown = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='URI_HOST']"
		[Register ("URI_HOST")]
		public const int UriHost = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='URI_PATH']"
		[Register ("URI_PATH")]
		public const int UriPath = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='URI_PORT']"
		[Register ("URI_PORT")]
		public const int UriPort = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/field[@name='URI_QUERY']"
		[Register ("URI_QUERY")]
		public const int UriQuery = (int) 15;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Defaults']"
		[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/option/OptionNumberRegistry$Defaults", DoNotGenerateAcw=true)]
		public partial class Defaults : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Defaults']/field[@name='MAX_AGE']"
			[Register ("MAX_AGE")]
			public const long MaxAge = (long) 60;
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/option/OptionNumberRegistry$Defaults", typeof (Defaults));
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

			protected Defaults (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Defaults']/constructor[@name='OptionNumberRegistry.Defaults' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Defaults ()
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']"
		[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/option/OptionNumberRegistry$Names", DoNotGenerateAcw=true)]
		public partial class Names : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/field[@name='Accept']"
			[Register ("Accept")]
			public const string Accept = (string) "Accept";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/field[@name='Block1']"
			[Register ("Block1")]
			public const string Block1 = (string) "Block1";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/field[@name='Block2']"
			[Register ("Block2")]
			public const string Block2 = (string) "Block2";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/field[@name='Content_Format']"
			[Register ("Content_Format")]
			public const string ContentFormat = (string) "Content-Format";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/field[@name='ETag']"
			[Register ("ETag")]
			public const string ETag = (string) "ETag";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/field[@name='If_Match']"
			[Register ("If_Match")]
			public const string IfMatch = (string) "If-Match";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/field[@name='If_None_Match']"
			[Register ("If_None_Match")]
			public const string IfNoneMatch = (string) "If-None-Match";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/field[@name='Location_Path']"
			[Register ("Location_Path")]
			public const string LocationPath = (string) "Location-Path";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/field[@name='Location_Query']"
			[Register ("Location_Query")]
			public const string LocationQuery = (string) "Location-Query";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/field[@name='Max_Age']"
			[Register ("Max_Age")]
			public const string MaxAge = (string) "Max-Age";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/field[@name='Observe']"
			[Register ("Observe")]
			public const string Observe = (string) "Observe";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/field[@name='Proxy_Scheme']"
			[Register ("Proxy_Scheme")]
			public const string ProxyScheme = (string) "Proxy-Scheme";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/field[@name='Proxy_Uri']"
			[Register ("Proxy_Uri")]
			public const string ProxyUri = (string) "Proxy-Uri";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/field[@name='Reserved']"
			[Register ("Reserved")]
			public const string Reserved = (string) "Reserved";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/field[@name='Size1']"
			[Register ("Size1")]
			public const string Size1 = (string) "Size1";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/field[@name='Size2']"
			[Register ("Size2")]
			public const string Size2 = (string) "Size2";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/field[@name='Uri_Host']"
			[Register ("Uri_Host")]
			public const string UriHost = (string) "Uri-Host";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/field[@name='Uri_Path']"
			[Register ("Uri_Path")]
			public const string UriPath = (string) "Uri-Path";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/field[@name='Uri_Port']"
			[Register ("Uri_Port")]
			public const string UriPort = (string) "Uri-Port";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/field[@name='Uri_Query']"
			[Register ("Uri_Query")]
			public const string UriQuery = (string) "Uri-Query";
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/option/OptionNumberRegistry$Names", typeof (Names));
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

			protected Names (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.Names']/constructor[@name='OptionNumberRegistry.Names' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Names ()
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.optionFormats']"
		[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/option/OptionNumberRegistry$optionFormats", DoNotGenerateAcw=true)]
		public sealed partial class OptionFormats : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.optionFormats']/field[@name='INTEGER']"
			[Register ("INTEGER")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionNumberRegistry.OptionFormats Integer {
				get {
					const string __id = "INTEGER.Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionNumberRegistry$optionFormats;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionNumberRegistry.OptionFormats> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.optionFormats']/field[@name='OPAQUE']"
			[Register ("OPAQUE")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionNumberRegistry.OptionFormats Opaque {
				get {
					const string __id = "OPAQUE.Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionNumberRegistry$optionFormats;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionNumberRegistry.OptionFormats> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.optionFormats']/field[@name='STRING']"
			[Register ("STRING")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionNumberRegistry.OptionFormats String {
				get {
					const string __id = "STRING.Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionNumberRegistry$optionFormats;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionNumberRegistry.OptionFormats> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.optionFormats']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionNumberRegistry.OptionFormats Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionNumberRegistry$optionFormats;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionNumberRegistry.OptionFormats> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/option/OptionNumberRegistry$optionFormats", typeof (OptionFormats));
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

			internal OptionFormats (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.optionFormats']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionNumberRegistry$optionFormats;", "")]
			public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionNumberRegistry.OptionFormats ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionNumberRegistry$optionFormats;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionNumberRegistry.OptionFormats> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry.optionFormats']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionNumberRegistry$optionFormats;", "")]
			public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionNumberRegistry.OptionFormats[] Values ()
			{
				const string __id = "values.()[Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionNumberRegistry$optionFormats;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionNumberRegistry.OptionFormats[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionNumberRegistry.OptionFormats));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/option/OptionNumberRegistry", typeof (OptionNumberRegistry));
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

		protected OptionNumberRegistry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/method[@name='getFormatByNr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFormatByNr", "(I)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionNumberRegistry$optionFormats;", "")]
		public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionNumberRegistry.OptionFormats GetFormatByNr (int optionNumber)
		{
			const string __id = "getFormatByNr.(I)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionNumberRegistry$optionFormats;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (optionNumber);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionNumberRegistry.OptionFormats> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/method[@name='isCacheKey' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isCacheKey", "(I)Z", "")]
		public static unsafe bool IsCacheKey (int optionNumber)
		{
			const string __id = "isCacheKey.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (optionNumber);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/method[@name='isCritical' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isCritical", "(I)Z", "")]
		public static unsafe bool IsCritical (int optionNumber)
		{
			const string __id = "isCritical.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (optionNumber);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/method[@name='isElective' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isElective", "(I)Z", "")]
		public static unsafe bool IsElective (int optionNumber)
		{
			const string __id = "isElective.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (optionNumber);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/method[@name='isNoCacheKey' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isNoCacheKey", "(I)Z", "")]
		public static unsafe bool IsNoCacheKey (int optionNumber)
		{
			const string __id = "isNoCacheKey.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (optionNumber);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/method[@name='isSafe' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isSafe", "(I)Z", "")]
		public static unsafe bool IsSafe (int optionNumber)
		{
			const string __id = "isSafe.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (optionNumber);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/method[@name='isSingleValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isSingleValue", "(I)Z", "")]
		public static unsafe bool IsSingleValue (int optionNumber)
		{
			const string __id = "isSingleValue.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (optionNumber);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/method[@name='isUnsafe' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isUnsafe", "(I)Z", "")]
		public static unsafe bool IsUnsafe (int optionNumber)
		{
			const string __id = "isUnsafe.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (optionNumber);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/method[@name='isUriOption' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isUriOption", "(I)Z", "")]
		public static unsafe bool IsUriOption (int optionNumber)
		{
			const string __id = "isUriOption.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (optionNumber);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/method[@name='toNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toNumber", "(Ljava/lang/String;)I", "")]
		public static unsafe int ToNumber (string name)
		{
			const string __id = "toNumber.(Ljava/lang/String;)I";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionNumberRegistry']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toString", "(I)Ljava/lang/String;", "")]
		public static new unsafe string ToString (int optionNumber)
		{
			const string __id = "toString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (optionNumber);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
