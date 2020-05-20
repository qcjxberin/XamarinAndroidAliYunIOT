using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']"
	[global::Android.Runtime.Register ("okhttp3/CacheControl", DoNotGenerateAcw=true)]
	public sealed partial class CacheControl : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/field[@name='FORCE_CACHE']"
		[Register ("FORCE_CACHE")]
		public static global::Okhttp3.CacheControl ForceCache {
			get {
				const string __id = "FORCE_CACHE.Lokhttp3/CacheControl;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/field[@name='FORCE_NETWORK']"
		[Register ("FORCE_NETWORK")]
		public static global::Okhttp3.CacheControl ForceNetwork {
			get {
				const string __id = "FORCE_NETWORK.Lokhttp3/CacheControl;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']"
		[global::Android.Runtime.Register ("okhttp3/CacheControl$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/CacheControl$Builder", typeof (Builder));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']/constructor[@name='CacheControl.Builder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/CacheControl;", "")]
			public unsafe global::Okhttp3.CacheControl Build ()
			{
				const string __id = "build.()Lokhttp3/CacheControl;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']/method[@name='immutable' and count(parameter)=0]"
			[Register ("immutable", "()Lokhttp3/CacheControl$Builder;", "")]
			public unsafe global::Okhttp3.CacheControl.Builder Immutable ()
			{
				const string __id = "immutable.()Lokhttp3/CacheControl$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']/method[@name='maxAge' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
			[Register ("maxAge", "(ILjava/util/concurrent/TimeUnit;)Lokhttp3/CacheControl$Builder;", "")]
			public unsafe global::Okhttp3.CacheControl.Builder MaxAge (int maxAge, global::Java.Util.Concurrent.TimeUnit timeUnit)
			{
				const string __id = "maxAge.(ILjava/util/concurrent/TimeUnit;)Lokhttp3/CacheControl$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (maxAge);
					__args [1] = new JniArgumentValue ((timeUnit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeUnit).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']/method[@name='maxStale' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
			[Register ("maxStale", "(ILjava/util/concurrent/TimeUnit;)Lokhttp3/CacheControl$Builder;", "")]
			public unsafe global::Okhttp3.CacheControl.Builder MaxStale (int maxStale, global::Java.Util.Concurrent.TimeUnit timeUnit)
			{
				const string __id = "maxStale.(ILjava/util/concurrent/TimeUnit;)Lokhttp3/CacheControl$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (maxStale);
					__args [1] = new JniArgumentValue ((timeUnit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeUnit).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']/method[@name='minFresh' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
			[Register ("minFresh", "(ILjava/util/concurrent/TimeUnit;)Lokhttp3/CacheControl$Builder;", "")]
			public unsafe global::Okhttp3.CacheControl.Builder MinFresh (int minFresh, global::Java.Util.Concurrent.TimeUnit timeUnit)
			{
				const string __id = "minFresh.(ILjava/util/concurrent/TimeUnit;)Lokhttp3/CacheControl$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (minFresh);
					__args [1] = new JniArgumentValue ((timeUnit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeUnit).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']/method[@name='noCache' and count(parameter)=0]"
			[Register ("noCache", "()Lokhttp3/CacheControl$Builder;", "")]
			public unsafe global::Okhttp3.CacheControl.Builder NoCache ()
			{
				const string __id = "noCache.()Lokhttp3/CacheControl$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']/method[@name='noStore' and count(parameter)=0]"
			[Register ("noStore", "()Lokhttp3/CacheControl$Builder;", "")]
			public unsafe global::Okhttp3.CacheControl.Builder NoStore ()
			{
				const string __id = "noStore.()Lokhttp3/CacheControl$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']/method[@name='noTransform' and count(parameter)=0]"
			[Register ("noTransform", "()Lokhttp3/CacheControl$Builder;", "")]
			public unsafe global::Okhttp3.CacheControl.Builder NoTransform ()
			{
				const string __id = "noTransform.()Lokhttp3/CacheControl$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl.Builder']/method[@name='onlyIfCached' and count(parameter)=0]"
			[Register ("onlyIfCached", "()Lokhttp3/CacheControl$Builder;", "")]
			public unsafe global::Okhttp3.CacheControl.Builder OnlyIfCached ()
			{
				const string __id = "onlyIfCached.()Lokhttp3/CacheControl$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/CacheControl", typeof (CacheControl));
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

		internal CacheControl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe bool IsPrivate {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='isPrivate' and count(parameter)=0]"
			[Register ("isPrivate", "()Z", "")]
			get {
				const string __id = "isPrivate.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsPublic {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='isPublic' and count(parameter)=0]"
			[Register ("isPublic", "()Z", "")]
			get {
				const string __id = "isPublic.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='immutable' and count(parameter)=0]"
		[Register ("immutable", "()Z", "")]
		public unsafe bool Immutable ()
		{
			const string __id = "immutable.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='maxAgeSeconds' and count(parameter)=0]"
		[Register ("maxAgeSeconds", "()I", "")]
		public unsafe int MaxAgeSeconds ()
		{
			const string __id = "maxAgeSeconds.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='maxStaleSeconds' and count(parameter)=0]"
		[Register ("maxStaleSeconds", "()I", "")]
		public unsafe int MaxStaleSeconds ()
		{
			const string __id = "maxStaleSeconds.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='minFreshSeconds' and count(parameter)=0]"
		[Register ("minFreshSeconds", "()I", "")]
		public unsafe int MinFreshSeconds ()
		{
			const string __id = "minFreshSeconds.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='mustRevalidate' and count(parameter)=0]"
		[Register ("mustRevalidate", "()Z", "")]
		public unsafe bool MustRevalidate ()
		{
			const string __id = "mustRevalidate.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='noCache' and count(parameter)=0]"
		[Register ("noCache", "()Z", "")]
		public unsafe bool NoCache ()
		{
			const string __id = "noCache.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='noStore' and count(parameter)=0]"
		[Register ("noStore", "()Z", "")]
		public unsafe bool NoStore ()
		{
			const string __id = "noStore.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='noTransform' and count(parameter)=0]"
		[Register ("noTransform", "()Z", "")]
		public unsafe bool NoTransform ()
		{
			const string __id = "noTransform.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='onlyIfCached' and count(parameter)=0]"
		[Register ("onlyIfCached", "()Z", "")]
		public unsafe bool OnlyIfCached ()
		{
			const string __id = "onlyIfCached.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='okhttp3.Headers']]"
		[Register ("parse", "(Lokhttp3/Headers;)Lokhttp3/CacheControl;", "")]
		public static unsafe global::Okhttp3.CacheControl Parse (global::Okhttp3.Headers headers)
		{
			const string __id = "parse.(Lokhttp3/Headers;)Lokhttp3/CacheControl;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((headers == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headers).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CacheControl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='CacheControl']/method[@name='sMaxAgeSeconds' and count(parameter)=0]"
		[Register ("sMaxAgeSeconds", "()I", "")]
		public unsafe int SMaxAgeSeconds ()
		{
			const string __id = "sMaxAgeSeconds.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
