using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/option/OptionSet", DoNotGenerateAcw=true)]
	public partial class OptionSet : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/option/OptionSet", typeof (OptionSet));
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

		protected OptionSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/constructor[@name='OptionSet' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OptionSet ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/constructor[@name='OptionSet' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.option.OptionSet']]"
		[Register (".ctor", "(Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;)V", "")]
		public unsafe OptionSet (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet origin)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((origin == null) ? IntPtr.Zero : ((global::Java.Lang.Object) origin).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getAccept;
#pragma warning disable 0169
		static Delegate GetGetAcceptHandler ()
		{
			if (cb_getAccept == null)
				cb_getAccept = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAccept);
			return cb_getAccept;
		}

		static int n_GetAccept (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Accept;
		}
#pragma warning restore 0169

		public virtual unsafe int Accept {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getAccept' and count(parameter)=0]"
			[Register ("getAccept", "()I", "GetGetAcceptHandler")]
			get {
				const string __id = "getAccept.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getBlock1;
#pragma warning disable 0169
		static Delegate GetGetBlock1Handler ()
		{
			if (cb_getBlock1 == null)
				cb_getBlock1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBlock1);
			return cb_getBlock1;
		}

		static IntPtr n_GetBlock1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Block1);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption Block1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getBlock1' and count(parameter)=0]"
			[Register ("getBlock1", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/BlockOption;", "GetGetBlock1Handler")]
			get {
				const string __id = "getBlock1.()Lcom/aliyun/alink/linksdk/alcs/coap/option/BlockOption;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBlock2;
#pragma warning disable 0169
		static Delegate GetGetBlock2Handler ()
		{
			if (cb_getBlock2 == null)
				cb_getBlock2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBlock2);
			return cb_getBlock2;
		}

		static IntPtr n_GetBlock2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Block2);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption Block2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getBlock2' and count(parameter)=0]"
			[Register ("getBlock2", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/BlockOption;", "GetGetBlock2Handler")]
			get {
				const string __id = "getBlock2.()Lcom/aliyun/alink/linksdk/alcs/coap/option/BlockOption;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContentFormat;
#pragma warning disable 0169
		static Delegate GetGetContentFormatHandler ()
		{
			if (cb_getContentFormat == null)
				cb_getContentFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetContentFormat);
			return cb_getContentFormat;
		}

		static int n_GetContentFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentFormat;
		}
#pragma warning restore 0169

		public virtual unsafe int ContentFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getContentFormat' and count(parameter)=0]"
			[Register ("getContentFormat", "()I", "GetGetContentFormatHandler")]
			get {
				const string __id = "getContentFormat.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getETagCount;
#pragma warning disable 0169
		static Delegate GetGetETagCountHandler ()
		{
			if (cb_getETagCount == null)
				cb_getETagCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetETagCount);
			return cb_getETagCount;
		}

		static int n_GetETagCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ETagCount;
		}
#pragma warning restore 0169

		public virtual unsafe int ETagCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getETagCount' and count(parameter)=0]"
			[Register ("getETagCount", "()I", "GetGetETagCountHandler")]
			get {
				const string __id = "getETagCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getETags;
#pragma warning disable 0169
		static Delegate GetGetETagsHandler ()
		{
			if (cb_getETags == null)
				cb_getETags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetETags);
			return cb_getETags;
		}

		static IntPtr n_GetETags (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (__this.ETags);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<byte[]> ETags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getETags' and count(parameter)=0]"
			[Register ("getETags", "()Ljava/util/List;", "GetGetETagsHandler")]
			get {
				const string __id = "getETags.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<byte[]>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasAccept;
#pragma warning disable 0169
		static Delegate GetHasAcceptHandler ()
		{
			if (cb_hasAccept == null)
				cb_hasAccept = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAccept);
			return cb_hasAccept;
		}

		static bool n_HasAccept (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAccept;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasAccept {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='hasAccept' and count(parameter)=0]"
			[Register ("hasAccept", "()Z", "GetHasAcceptHandler")]
			get {
				const string __id = "hasAccept.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasBlock1;
#pragma warning disable 0169
		static Delegate GetHasBlock1Handler ()
		{
			if (cb_hasBlock1 == null)
				cb_hasBlock1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasBlock1);
			return cb_hasBlock1;
		}

		static bool n_HasBlock1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBlock1;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasBlock1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='hasBlock1' and count(parameter)=0]"
			[Register ("hasBlock1", "()Z", "GetHasBlock1Handler")]
			get {
				const string __id = "hasBlock1.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasBlock2;
#pragma warning disable 0169
		static Delegate GetHasBlock2Handler ()
		{
			if (cb_hasBlock2 == null)
				cb_hasBlock2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasBlock2);
			return cb_hasBlock2;
		}

		static bool n_HasBlock2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBlock2;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasBlock2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='hasBlock2' and count(parameter)=0]"
			[Register ("hasBlock2", "()Z", "GetHasBlock2Handler")]
			get {
				const string __id = "hasBlock2.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasContentFormat;
#pragma warning disable 0169
		static Delegate GetHasContentFormatHandler ()
		{
			if (cb_hasContentFormat == null)
				cb_hasContentFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasContentFormat);
			return cb_hasContentFormat;
		}

		static bool n_HasContentFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasContentFormat;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasContentFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='hasContentFormat' and count(parameter)=0]"
			[Register ("hasContentFormat", "()Z", "GetHasContentFormatHandler")]
			get {
				const string __id = "hasContentFormat.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasIfNoneMatch;
#pragma warning disable 0169
		static Delegate GetHasIfNoneMatchHandler ()
		{
			if (cb_hasIfNoneMatch == null)
				cb_hasIfNoneMatch = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasIfNoneMatch);
			return cb_hasIfNoneMatch;
		}

		static bool n_HasIfNoneMatch (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasIfNoneMatch;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasIfNoneMatch {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='hasIfNoneMatch' and count(parameter)=0]"
			[Register ("hasIfNoneMatch", "()Z", "GetHasIfNoneMatchHandler")]
			get {
				const string __id = "hasIfNoneMatch.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasMaxAge;
#pragma warning disable 0169
		static Delegate GetHasMaxAgeHandler ()
		{
			if (cb_hasMaxAge == null)
				cb_hasMaxAge = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasMaxAge);
			return cb_hasMaxAge;
		}

		static bool n_HasMaxAge (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasMaxAge;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasMaxAge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='hasMaxAge' and count(parameter)=0]"
			[Register ("hasMaxAge", "()Z", "GetHasMaxAgeHandler")]
			get {
				const string __id = "hasMaxAge.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasObserve;
#pragma warning disable 0169
		static Delegate GetHasObserveHandler ()
		{
			if (cb_hasObserve == null)
				cb_hasObserve = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasObserve);
			return cb_hasObserve;
		}

		static bool n_HasObserve (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasObserve;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasObserve {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='hasObserve' and count(parameter)=0]"
			[Register ("hasObserve", "()Z", "GetHasObserveHandler")]
			get {
				const string __id = "hasObserve.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasProxyScheme;
#pragma warning disable 0169
		static Delegate GetHasProxySchemeHandler ()
		{
			if (cb_hasProxyScheme == null)
				cb_hasProxyScheme = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasProxyScheme);
			return cb_hasProxyScheme;
		}

		static bool n_HasProxyScheme (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasProxyScheme;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasProxyScheme {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='hasProxyScheme' and count(parameter)=0]"
			[Register ("hasProxyScheme", "()Z", "GetHasProxySchemeHandler")]
			get {
				const string __id = "hasProxyScheme.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasProxyUri;
#pragma warning disable 0169
		static Delegate GetHasProxyUriHandler ()
		{
			if (cb_hasProxyUri == null)
				cb_hasProxyUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasProxyUri);
			return cb_hasProxyUri;
		}

		static bool n_HasProxyUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasProxyUri;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasProxyUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='hasProxyUri' and count(parameter)=0]"
			[Register ("hasProxyUri", "()Z", "GetHasProxyUriHandler")]
			get {
				const string __id = "hasProxyUri.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasSize1;
#pragma warning disable 0169
		static Delegate GetHasSize1Handler ()
		{
			if (cb_hasSize1 == null)
				cb_hasSize1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasSize1);
			return cb_hasSize1;
		}

		static bool n_HasSize1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasSize1;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasSize1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='hasSize1' and count(parameter)=0]"
			[Register ("hasSize1", "()Z", "GetHasSize1Handler")]
			get {
				const string __id = "hasSize1.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasSize2;
#pragma warning disable 0169
		static Delegate GetHasSize2Handler ()
		{
			if (cb_hasSize2 == null)
				cb_hasSize2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasSize2);
			return cb_hasSize2;
		}

		static bool n_HasSize2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasSize2;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasSize2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='hasSize2' and count(parameter)=0]"
			[Register ("hasSize2", "()Z", "GetHasSize2Handler")]
			get {
				const string __id = "hasSize2.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasUriHost;
#pragma warning disable 0169
		static Delegate GetHasUriHostHandler ()
		{
			if (cb_hasUriHost == null)
				cb_hasUriHost = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasUriHost);
			return cb_hasUriHost;
		}

		static bool n_HasUriHost (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasUriHost;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasUriHost {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='hasUriHost' and count(parameter)=0]"
			[Register ("hasUriHost", "()Z", "GetHasUriHostHandler")]
			get {
				const string __id = "hasUriHost.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasUriPort;
#pragma warning disable 0169
		static Delegate GetHasUriPortHandler ()
		{
			if (cb_hasUriPort == null)
				cb_hasUriPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasUriPort);
			return cb_hasUriPort;
		}

		static bool n_HasUriPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasUriPort;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasUriPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='hasUriPort' and count(parameter)=0]"
			[Register ("hasUriPort", "()Z", "GetHasUriPortHandler")]
			get {
				const string __id = "hasUriPort.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIfMatch;
#pragma warning disable 0169
		static Delegate GetGetIfMatchHandler ()
		{
			if (cb_getIfMatch == null)
				cb_getIfMatch = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIfMatch);
			return cb_getIfMatch;
		}

		static IntPtr n_GetIfMatch (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (__this.IfMatch);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<byte[]> IfMatch {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getIfMatch' and count(parameter)=0]"
			[Register ("getIfMatch", "()Ljava/util/List;", "GetGetIfMatchHandler")]
			get {
				const string __id = "getIfMatch.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<byte[]>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIfMatchCount;
#pragma warning disable 0169
		static Delegate GetGetIfMatchCountHandler ()
		{
			if (cb_getIfMatchCount == null)
				cb_getIfMatchCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIfMatchCount);
			return cb_getIfMatchCount;
		}

		static int n_GetIfMatchCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IfMatchCount;
		}
#pragma warning restore 0169

		public virtual unsafe int IfMatchCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getIfMatchCount' and count(parameter)=0]"
			[Register ("getIfMatchCount", "()I", "GetGetIfMatchCountHandler")]
			get {
				const string __id = "getIfMatchCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLocationPath;
#pragma warning disable 0169
		static Delegate GetGetLocationPathHandler ()
		{
			if (cb_getLocationPath == null)
				cb_getLocationPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocationPath);
			return cb_getLocationPath;
		}

		static IntPtr n_GetLocationPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.LocationPath);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> LocationPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getLocationPath' and count(parameter)=0]"
			[Register ("getLocationPath", "()Ljava/util/List;", "GetGetLocationPathHandler")]
			get {
				const string __id = "getLocationPath.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLocationPathCount;
#pragma warning disable 0169
		static Delegate GetGetLocationPathCountHandler ()
		{
			if (cb_getLocationPathCount == null)
				cb_getLocationPathCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLocationPathCount);
			return cb_getLocationPathCount;
		}

		static int n_GetLocationPathCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocationPathCount;
		}
#pragma warning restore 0169

		public virtual unsafe int LocationPathCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getLocationPathCount' and count(parameter)=0]"
			[Register ("getLocationPathCount", "()I", "GetGetLocationPathCountHandler")]
			get {
				const string __id = "getLocationPathCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLocationPathString;
#pragma warning disable 0169
		static Delegate GetGetLocationPathStringHandler ()
		{
			if (cb_getLocationPathString == null)
				cb_getLocationPathString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocationPathString);
			return cb_getLocationPathString;
		}

		static IntPtr n_GetLocationPathString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocationPathString);
		}
#pragma warning restore 0169

		public virtual unsafe string LocationPathString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getLocationPathString' and count(parameter)=0]"
			[Register ("getLocationPathString", "()Ljava/lang/String;", "GetGetLocationPathStringHandler")]
			get {
				const string __id = "getLocationPathString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLocationQuery;
#pragma warning disable 0169
		static Delegate GetGetLocationQueryHandler ()
		{
			if (cb_getLocationQuery == null)
				cb_getLocationQuery = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocationQuery);
			return cb_getLocationQuery;
		}

		static IntPtr n_GetLocationQuery (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.LocationQuery);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> LocationQuery {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getLocationQuery' and count(parameter)=0]"
			[Register ("getLocationQuery", "()Ljava/util/List;", "GetGetLocationQueryHandler")]
			get {
				const string __id = "getLocationQuery.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLocationQueryCount;
#pragma warning disable 0169
		static Delegate GetGetLocationQueryCountHandler ()
		{
			if (cb_getLocationQueryCount == null)
				cb_getLocationQueryCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLocationQueryCount);
			return cb_getLocationQueryCount;
		}

		static int n_GetLocationQueryCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocationQueryCount;
		}
#pragma warning restore 0169

		public virtual unsafe int LocationQueryCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getLocationQueryCount' and count(parameter)=0]"
			[Register ("getLocationQueryCount", "()I", "GetGetLocationQueryCountHandler")]
			get {
				const string __id = "getLocationQueryCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLocationQueryString;
#pragma warning disable 0169
		static Delegate GetGetLocationQueryStringHandler ()
		{
			if (cb_getLocationQueryString == null)
				cb_getLocationQueryString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocationQueryString);
			return cb_getLocationQueryString;
		}

		static IntPtr n_GetLocationQueryString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocationQueryString);
		}
#pragma warning restore 0169

		public virtual unsafe string LocationQueryString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getLocationQueryString' and count(parameter)=0]"
			[Register ("getLocationQueryString", "()Ljava/lang/String;", "GetGetLocationQueryStringHandler")]
			get {
				const string __id = "getLocationQueryString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLocationString;
#pragma warning disable 0169
		static Delegate GetGetLocationStringHandler ()
		{
			if (cb_getLocationString == null)
				cb_getLocationString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocationString);
			return cb_getLocationString;
		}

		static IntPtr n_GetLocationString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocationString);
		}
#pragma warning restore 0169

		public virtual unsafe string LocationString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getLocationString' and count(parameter)=0]"
			[Register ("getLocationString", "()Ljava/lang/String;", "GetGetLocationStringHandler")]
			get {
				const string __id = "getLocationString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxAge;
#pragma warning disable 0169
		static Delegate GetGetMaxAgeHandler ()
		{
			if (cb_getMaxAge == null)
				cb_getMaxAge = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMaxAge);
			return cb_getMaxAge;
		}

		static IntPtr n_GetMaxAge (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MaxAge);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Long MaxAge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getMaxAge' and count(parameter)=0]"
			[Register ("getMaxAge", "()Ljava/lang/Long;", "GetGetMaxAgeHandler")]
			get {
				const string __id = "getMaxAge.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getObserve;
#pragma warning disable 0169
		static Delegate GetGetObserveHandler ()
		{
			if (cb_getObserve == null)
				cb_getObserve = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObserve);
			return cb_getObserve;
		}

		static IntPtr n_GetObserve (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Observe);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer Observe {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getObserve' and count(parameter)=0]"
			[Register ("getObserve", "()Ljava/lang/Integer;", "GetGetObserveHandler")]
			get {
				const string __id = "getObserve.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOthers;
#pragma warning disable 0169
		static Delegate GetGetOthersHandler ()
		{
			if (cb_getOthers == null)
				cb_getOthers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOthers);
			return cb_getOthers;
		}

		static IntPtr n_GetOthers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option>.ToLocalJniHandle (__this.Others);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option> Others {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getOthers' and count(parameter)=0]"
			[Register ("getOthers", "()Ljava/util/List;", "GetGetOthersHandler")]
			get {
				const string __id = "getOthers.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProxyScheme;
#pragma warning disable 0169
		static Delegate GetGetProxySchemeHandler ()
		{
			if (cb_getProxyScheme == null)
				cb_getProxyScheme = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProxyScheme);
			return cb_getProxyScheme;
		}

		static IntPtr n_GetProxyScheme (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProxyScheme);
		}
#pragma warning restore 0169

		public virtual unsafe string ProxyScheme {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getProxyScheme' and count(parameter)=0]"
			[Register ("getProxyScheme", "()Ljava/lang/String;", "GetGetProxySchemeHandler")]
			get {
				const string __id = "getProxyScheme.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProxyUri;
#pragma warning disable 0169
		static Delegate GetGetProxyUriHandler ()
		{
			if (cb_getProxyUri == null)
				cb_getProxyUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProxyUri);
			return cb_getProxyUri;
		}

		static IntPtr n_GetProxyUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProxyUri);
		}
#pragma warning restore 0169

		public virtual unsafe string ProxyUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getProxyUri' and count(parameter)=0]"
			[Register ("getProxyUri", "()Ljava/lang/String;", "GetGetProxyUriHandler")]
			get {
				const string __id = "getProxyUri.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSize1;
#pragma warning disable 0169
		static Delegate GetGetSize1Handler ()
		{
			if (cb_getSize1 == null)
				cb_getSize1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSize1);
			return cb_getSize1;
		}

		static IntPtr n_GetSize1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Size1);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer Size1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getSize1' and count(parameter)=0]"
			[Register ("getSize1", "()Ljava/lang/Integer;", "GetGetSize1Handler")]
			get {
				const string __id = "getSize1.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSize2;
#pragma warning disable 0169
		static Delegate GetGetSize2Handler ()
		{
			if (cb_getSize2 == null)
				cb_getSize2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSize2);
			return cb_getSize2;
		}

		static IntPtr n_GetSize2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Size2);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer Size2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getSize2' and count(parameter)=0]"
			[Register ("getSize2", "()Ljava/lang/Integer;", "GetGetSize2Handler")]
			get {
				const string __id = "getSize2.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getURIPathCount;
#pragma warning disable 0169
		static Delegate GetGetURIPathCountHandler ()
		{
			if (cb_getURIPathCount == null)
				cb_getURIPathCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetURIPathCount);
			return cb_getURIPathCount;
		}

		static int n_GetURIPathCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.URIPathCount;
		}
#pragma warning restore 0169

		public virtual unsafe int URIPathCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getURIPathCount' and count(parameter)=0]"
			[Register ("getURIPathCount", "()I", "GetGetURIPathCountHandler")]
			get {
				const string __id = "getURIPathCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getURIQueryCount;
#pragma warning disable 0169
		static Delegate GetGetURIQueryCountHandler ()
		{
			if (cb_getURIQueryCount == null)
				cb_getURIQueryCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetURIQueryCount);
			return cb_getURIQueryCount;
		}

		static int n_GetURIQueryCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.URIQueryCount;
		}
#pragma warning restore 0169

		public virtual unsafe int URIQueryCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getURIQueryCount' and count(parameter)=0]"
			[Register ("getURIQueryCount", "()I", "GetGetURIQueryCountHandler")]
			get {
				const string __id = "getURIQueryCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getUriHost;
#pragma warning disable 0169
		static Delegate GetGetUriHostHandler ()
		{
			if (cb_getUriHost == null)
				cb_getUriHost = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUriHost);
			return cb_getUriHost;
		}

		static IntPtr n_GetUriHost (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UriHost);
		}
#pragma warning restore 0169

		public virtual unsafe string UriHost {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getUriHost' and count(parameter)=0]"
			[Register ("getUriHost", "()Ljava/lang/String;", "GetGetUriHostHandler")]
			get {
				const string __id = "getUriHost.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUriPath;
#pragma warning disable 0169
		static Delegate GetGetUriPathHandler ()
		{
			if (cb_getUriPath == null)
				cb_getUriPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUriPath);
			return cb_getUriPath;
		}

		static IntPtr n_GetUriPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.UriPath);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> UriPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getUriPath' and count(parameter)=0]"
			[Register ("getUriPath", "()Ljava/util/List;", "GetGetUriPathHandler")]
			get {
				const string __id = "getUriPath.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUriPathString;
#pragma warning disable 0169
		static Delegate GetGetUriPathStringHandler ()
		{
			if (cb_getUriPathString == null)
				cb_getUriPathString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUriPathString);
			return cb_getUriPathString;
		}

		static IntPtr n_GetUriPathString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UriPathString);
		}
#pragma warning restore 0169

		public virtual unsafe string UriPathString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getUriPathString' and count(parameter)=0]"
			[Register ("getUriPathString", "()Ljava/lang/String;", "GetGetUriPathStringHandler")]
			get {
				const string __id = "getUriPathString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUriPort;
#pragma warning disable 0169
		static Delegate GetGetUriPortHandler ()
		{
			if (cb_getUriPort == null)
				cb_getUriPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUriPort);
			return cb_getUriPort;
		}

		static IntPtr n_GetUriPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UriPort);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer UriPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getUriPort' and count(parameter)=0]"
			[Register ("getUriPort", "()Ljava/lang/Integer;", "GetGetUriPortHandler")]
			get {
				const string __id = "getUriPort.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUriQuery;
#pragma warning disable 0169
		static Delegate GetGetUriQueryHandler ()
		{
			if (cb_getUriQuery == null)
				cb_getUriQuery = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUriQuery);
			return cb_getUriQuery;
		}

		static IntPtr n_GetUriQuery (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.UriQuery);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> UriQuery {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getUriQuery' and count(parameter)=0]"
			[Register ("getUriQuery", "()Ljava/util/List;", "GetGetUriQueryHandler")]
			get {
				const string __id = "getUriQuery.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUriQueryString;
#pragma warning disable 0169
		static Delegate GetGetUriQueryStringHandler ()
		{
			if (cb_getUriQueryString == null)
				cb_getUriQueryString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUriQueryString);
			return cb_getUriQueryString;
		}

		static IntPtr n_GetUriQueryString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UriQueryString);
		}
#pragma warning restore 0169

		public virtual unsafe string UriQueryString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='getUriQueryString' and count(parameter)=0]"
			[Register ("getUriQueryString", "()Ljava/lang/String;", "GetGetUriQueryStringHandler")]
			get {
				const string __id = "getUriQueryString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addETag_arrayB;
#pragma warning disable 0169
		static Delegate GetAddETag_arrayBHandler ()
		{
			if (cb_addETag_arrayB == null)
				cb_addETag_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddETag_arrayB);
			return cb_addETag_arrayB;
		}

		static IntPtr n_AddETag_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_etag)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] etag = (byte[]) JNIEnv.GetArray (native_etag, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddETag (etag));
			if (etag != null)
				JNIEnv.CopyArray (etag, native_etag);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='addETag' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("addETag", "([B)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetAddETag_arrayBHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet AddETag (byte[] etag)
		{
			const string __id = "addETag.([B)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			IntPtr native_etag = JNIEnv.NewArray (etag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_etag);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (etag != null) {
					JNIEnv.CopyArray (native_etag, etag);
					JNIEnv.DeleteLocalRef (native_etag);
				}
			}
		}

		static Delegate cb_addIfMatch_arrayB;
#pragma warning disable 0169
		static Delegate GetAddIfMatch_arrayBHandler ()
		{
			if (cb_addIfMatch_arrayB == null)
				cb_addIfMatch_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddIfMatch_arrayB);
			return cb_addIfMatch_arrayB;
		}

		static IntPtr n_AddIfMatch_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_etag)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] etag = (byte[]) JNIEnv.GetArray (native_etag, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddIfMatch (etag));
			if (etag != null)
				JNIEnv.CopyArray (etag, native_etag);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='addIfMatch' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("addIfMatch", "([B)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetAddIfMatch_arrayBHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet AddIfMatch (byte[] etag)
		{
			const string __id = "addIfMatch.([B)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			IntPtr native_etag = JNIEnv.NewArray (etag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_etag);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (etag != null) {
					JNIEnv.CopyArray (native_etag, etag);
					JNIEnv.DeleteLocalRef (native_etag);
				}
			}
		}

		static Delegate cb_addLocationPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddLocationPath_Ljava_lang_String_Handler ()
		{
			if (cb_addLocationPath_Ljava_lang_String_ == null)
				cb_addLocationPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddLocationPath_Ljava_lang_String_);
			return cb_addLocationPath_Ljava_lang_String_;
		}

		static IntPtr n_AddLocationPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_segment)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string segment = JNIEnv.GetString (native_segment, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddLocationPath (segment));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='addLocationPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addLocationPath", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetAddLocationPath_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet AddLocationPath (string segment)
		{
			const string __id = "addLocationPath.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			IntPtr native_segment = JNIEnv.NewString (segment);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_segment);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_segment);
			}
		}

		static Delegate cb_addLocationQuery_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddLocationQuery_Ljava_lang_String_Handler ()
		{
			if (cb_addLocationQuery_Ljava_lang_String_ == null)
				cb_addLocationQuery_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddLocationQuery_Ljava_lang_String_);
			return cb_addLocationQuery_Ljava_lang_String_;
		}

		static IntPtr n_AddLocationQuery_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_argument)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string argument = JNIEnv.GetString (native_argument, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddLocationQuery (argument));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='addLocationQuery' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addLocationQuery", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetAddLocationQuery_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet AddLocationQuery (string argument)
		{
			const string __id = "addLocationQuery.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			IntPtr native_argument = JNIEnv.NewString (argument);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_argument);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_argument);
			}
		}

		static Delegate cb_addOption_Lcom_aliyun_alink_linksdk_alcs_coap_option_Option_;
#pragma warning disable 0169
		static Delegate GetAddOption_Lcom_aliyun_alink_linksdk_alcs_coap_option_Option_Handler ()
		{
			if (cb_addOption_Lcom_aliyun_alink_linksdk_alcs_coap_option_Option_ == null)
				cb_addOption_Lcom_aliyun_alink_linksdk_alcs_coap_option_Option_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddOption_Lcom_aliyun_alink_linksdk_alcs_coap_option_Option_);
			return cb_addOption_Lcom_aliyun_alink_linksdk_alcs_coap_option_Option_;
		}

		static IntPtr n_AddOption_Lcom_aliyun_alink_linksdk_alcs_coap_option_Option_ (IntPtr jnienv, IntPtr native__this, IntPtr native_option)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option option = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option> (native_option, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddOption (option));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='addOption' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.option.Option']]"
		[Register ("addOption", "(Lcom/aliyun/alink/linksdk/alcs/coap/option/Option;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetAddOption_Lcom_aliyun_alink_linksdk_alcs_coap_option_Option_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet AddOption (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option option)
		{
			const string __id = "addOption.(Lcom/aliyun/alink/linksdk/alcs/coap/option/Option;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((option == null) ? IntPtr.Zero : ((global::Java.Lang.Object) option).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addOption_IarrayB;
#pragma warning disable 0169
		static Delegate GetAddOption_IarrayBHandler ()
		{
			if (cb_addOption_IarrayB == null)
				cb_addOption_IarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AddOption_IarrayB);
			return cb_addOption_IarrayB;
		}

		static void n_AddOption_IarrayB (IntPtr jnienv, IntPtr native__this, int number, IntPtr native_value)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.AddOption (number, value);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='addOption' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("addOption", "(I[B)V", "GetAddOption_IarrayBHandler")]
		public virtual unsafe void AddOption (int number, byte[] value)
		{
			const string __id = "addOption.(I[B)V";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (number);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_addUriPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddUriPath_Ljava_lang_String_Handler ()
		{
			if (cb_addUriPath_Ljava_lang_String_ == null)
				cb_addUriPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddUriPath_Ljava_lang_String_);
			return cb_addUriPath_Ljava_lang_String_;
		}

		static IntPtr n_AddUriPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_segment)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string segment = JNIEnv.GetString (native_segment, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddUriPath (segment));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='addUriPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addUriPath", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetAddUriPath_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet AddUriPath (string segment)
		{
			const string __id = "addUriPath.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			IntPtr native_segment = JNIEnv.NewString (segment);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_segment);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_segment);
			}
		}

		static Delegate cb_addUriQuery_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddUriQuery_Ljava_lang_String_Handler ()
		{
			if (cb_addUriQuery_Ljava_lang_String_ == null)
				cb_addUriQuery_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddUriQuery_Ljava_lang_String_);
			return cb_addUriQuery_Ljava_lang_String_;
		}

		static IntPtr n_AddUriQuery_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_argument)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string argument = JNIEnv.GetString (native_argument, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddUriQuery (argument));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='addUriQuery' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addUriQuery", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetAddUriQuery_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet AddUriQuery (string argument)
		{
			const string __id = "addUriQuery.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			IntPtr native_argument = JNIEnv.NewString (argument);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_argument);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_argument);
			}
		}

		static Delegate cb_asSortedList;
#pragma warning disable 0169
		static Delegate GetAsSortedListHandler ()
		{
			if (cb_asSortedList == null)
				cb_asSortedList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsSortedList);
			return cb_asSortedList;
		}

		static IntPtr n_AsSortedList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option>.ToLocalJniHandle (__this.AsSortedList ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='asSortedList' and count(parameter)=0]"
		[Register ("asSortedList", "()Ljava/util/List;", "GetAsSortedListHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option> AsSortedList ()
		{
			const string __id = "asSortedList.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clearETags;
#pragma warning disable 0169
		static Delegate GetClearETagsHandler ()
		{
			if (cb_clearETags == null)
				cb_clearETags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ClearETags);
			return cb_clearETags;
		}

		static IntPtr n_ClearETags (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClearETags ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='clearETags' and count(parameter)=0]"
		[Register ("clearETags", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetClearETagsHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet ClearETags ()
		{
			const string __id = "clearETags.()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_clearIfMatchs;
#pragma warning disable 0169
		static Delegate GetClearIfMatchsHandler ()
		{
			if (cb_clearIfMatchs == null)
				cb_clearIfMatchs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ClearIfMatchs);
			return cb_clearIfMatchs;
		}

		static IntPtr n_ClearIfMatchs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClearIfMatchs ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='clearIfMatchs' and count(parameter)=0]"
		[Register ("clearIfMatchs", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetClearIfMatchsHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet ClearIfMatchs ()
		{
			const string __id = "clearIfMatchs.()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_clearLocationPath;
#pragma warning disable 0169
		static Delegate GetClearLocationPathHandler ()
		{
			if (cb_clearLocationPath == null)
				cb_clearLocationPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ClearLocationPath);
			return cb_clearLocationPath;
		}

		static IntPtr n_ClearLocationPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClearLocationPath ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='clearLocationPath' and count(parameter)=0]"
		[Register ("clearLocationPath", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetClearLocationPathHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet ClearLocationPath ()
		{
			const string __id = "clearLocationPath.()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_clearLocationQuery;
#pragma warning disable 0169
		static Delegate GetClearLocationQueryHandler ()
		{
			if (cb_clearLocationQuery == null)
				cb_clearLocationQuery = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ClearLocationQuery);
			return cb_clearLocationQuery;
		}

		static IntPtr n_ClearLocationQuery (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClearLocationQuery ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='clearLocationQuery' and count(parameter)=0]"
		[Register ("clearLocationQuery", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetClearLocationQueryHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet ClearLocationQuery ()
		{
			const string __id = "clearLocationQuery.()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_clearUriPath;
#pragma warning disable 0169
		static Delegate GetClearUriPathHandler ()
		{
			if (cb_clearUriPath == null)
				cb_clearUriPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ClearUriPath);
			return cb_clearUriPath;
		}

		static IntPtr n_ClearUriPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClearUriPath ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='clearUriPath' and count(parameter)=0]"
		[Register ("clearUriPath", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetClearUriPathHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet ClearUriPath ()
		{
			const string __id = "clearUriPath.()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_clearUriQuery;
#pragma warning disable 0169
		static Delegate GetClearUriQueryHandler ()
		{
			if (cb_clearUriQuery == null)
				cb_clearUriQuery = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ClearUriQuery);
			return cb_clearUriQuery;
		}

		static IntPtr n_ClearUriQuery (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClearUriQuery ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='clearUriQuery' and count(parameter)=0]"
		[Register ("clearUriQuery", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetClearUriQueryHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet ClearUriQuery ()
		{
			const string __id = "clearUriQuery.()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_containsETag_arrayB;
#pragma warning disable 0169
		static Delegate GetContainsETag_arrayBHandler ()
		{
			if (cb_containsETag_arrayB == null)
				cb_containsETag_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsETag_arrayB);
			return cb_containsETag_arrayB;
		}

		static bool n_ContainsETag_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_check)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] check = (byte[]) JNIEnv.GetArray (native_check, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.ContainsETag (check);
			if (check != null)
				JNIEnv.CopyArray (check, native_check);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='containsETag' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("containsETag", "([B)Z", "GetContainsETag_arrayBHandler")]
		public virtual unsafe bool ContainsETag (byte[] check)
		{
			const string __id = "containsETag.([B)Z";
			IntPtr native_check = JNIEnv.NewArray (check);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_check);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (check != null) {
					JNIEnv.CopyArray (native_check, check);
					JNIEnv.DeleteLocalRef (native_check);
				}
			}
		}

		static Delegate cb_hasOption_I;
#pragma warning disable 0169
		static Delegate GetHasOption_IHandler ()
		{
			if (cb_hasOption_I == null)
				cb_hasOption_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_HasOption_I);
			return cb_hasOption_I;
		}

		static bool n_HasOption_I (IntPtr jnienv, IntPtr native__this, int number)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasOption (number);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='hasOption' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hasOption", "(I)Z", "GetHasOption_IHandler")]
		public virtual unsafe bool HasOption (int number)
		{
			const string __id = "hasOption.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (number);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isAccept_I;
#pragma warning disable 0169
		static Delegate GetIsAccept_IHandler ()
		{
			if (cb_isAccept_I == null)
				cb_isAccept_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsAccept_I);
			return cb_isAccept_I;
		}

		static bool n_IsAccept_I (IntPtr jnienv, IntPtr native__this, int format)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAccept (format);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='isAccept' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isAccept", "(I)Z", "GetIsAccept_IHandler")]
		public virtual unsafe bool IsAccept (int format)
		{
			const string __id = "isAccept.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (format);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isContentFormat_I;
#pragma warning disable 0169
		static Delegate GetIsContentFormat_IHandler ()
		{
			if (cb_isContentFormat_I == null)
				cb_isContentFormat_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsContentFormat_I);
			return cb_isContentFormat_I;
		}

		static bool n_IsContentFormat_I (IntPtr jnienv, IntPtr native__this, int format)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsContentFormat (format);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='isContentFormat' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isContentFormat", "(I)Z", "GetIsContentFormat_IHandler")]
		public virtual unsafe bool IsContentFormat (int format)
		{
			const string __id = "isContentFormat.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (format);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isIfMatch_arrayB;
#pragma warning disable 0169
		static Delegate GetIsIfMatch_arrayBHandler ()
		{
			if (cb_isIfMatch_arrayB == null)
				cb_isIfMatch_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsIfMatch_arrayB);
			return cb_isIfMatch_arrayB;
		}

		static bool n_IsIfMatch_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_check)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] check = (byte[]) JNIEnv.GetArray (native_check, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.IsIfMatch (check);
			if (check != null)
				JNIEnv.CopyArray (check, native_check);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='isIfMatch' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("isIfMatch", "([B)Z", "GetIsIfMatch_arrayBHandler")]
		public virtual unsafe bool IsIfMatch (byte[] check)
		{
			const string __id = "isIfMatch.([B)Z";
			IntPtr native_check = JNIEnv.NewArray (check);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_check);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (check != null) {
					JNIEnv.CopyArray (native_check, check);
					JNIEnv.DeleteLocalRef (native_check);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='isValidObserveOption' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isValidObserveOption", "(I)Z", "")]
		public static unsafe bool IsValidObserveOption (int value)
		{
			const string __id = "isValidObserveOption.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_removeAccept;
#pragma warning disable 0169
		static Delegate GetRemoveAcceptHandler ()
		{
			if (cb_removeAccept == null)
				cb_removeAccept = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveAccept);
			return cb_removeAccept;
		}

		static IntPtr n_RemoveAccept (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveAccept ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='removeAccept' and count(parameter)=0]"
		[Register ("removeAccept", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetRemoveAcceptHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet RemoveAccept ()
		{
			const string __id = "removeAccept.()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeBlock1;
#pragma warning disable 0169
		static Delegate GetRemoveBlock1Handler ()
		{
			if (cb_removeBlock1 == null)
				cb_removeBlock1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveBlock1);
			return cb_removeBlock1;
		}

		static IntPtr n_RemoveBlock1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveBlock1 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='removeBlock1' and count(parameter)=0]"
		[Register ("removeBlock1", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetRemoveBlock1Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet RemoveBlock1 ()
		{
			const string __id = "removeBlock1.()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeBlock2;
#pragma warning disable 0169
		static Delegate GetRemoveBlock2Handler ()
		{
			if (cb_removeBlock2 == null)
				cb_removeBlock2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveBlock2);
			return cb_removeBlock2;
		}

		static IntPtr n_RemoveBlock2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveBlock2 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='removeBlock2' and count(parameter)=0]"
		[Register ("removeBlock2", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetRemoveBlock2Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet RemoveBlock2 ()
		{
			const string __id = "removeBlock2.()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeContentFormat;
#pragma warning disable 0169
		static Delegate GetRemoveContentFormatHandler ()
		{
			if (cb_removeContentFormat == null)
				cb_removeContentFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveContentFormat);
			return cb_removeContentFormat;
		}

		static IntPtr n_RemoveContentFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveContentFormat ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='removeContentFormat' and count(parameter)=0]"
		[Register ("removeContentFormat", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetRemoveContentFormatHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet RemoveContentFormat ()
		{
			const string __id = "removeContentFormat.()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeETag_arrayB;
#pragma warning disable 0169
		static Delegate GetRemoveETag_arrayBHandler ()
		{
			if (cb_removeETag_arrayB == null)
				cb_removeETag_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveETag_arrayB);
			return cb_removeETag_arrayB;
		}

		static IntPtr n_RemoveETag_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_etag)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] etag = (byte[]) JNIEnv.GetArray (native_etag, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveETag (etag));
			if (etag != null)
				JNIEnv.CopyArray (etag, native_etag);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='removeETag' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("removeETag", "([B)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetRemoveETag_arrayBHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet RemoveETag (byte[] etag)
		{
			const string __id = "removeETag.([B)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			IntPtr native_etag = JNIEnv.NewArray (etag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_etag);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (etag != null) {
					JNIEnv.CopyArray (native_etag, etag);
					JNIEnv.DeleteLocalRef (native_etag);
				}
			}
		}

		static Delegate cb_removeIfMatch_arrayB;
#pragma warning disable 0169
		static Delegate GetRemoveIfMatch_arrayBHandler ()
		{
			if (cb_removeIfMatch_arrayB == null)
				cb_removeIfMatch_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveIfMatch_arrayB);
			return cb_removeIfMatch_arrayB;
		}

		static IntPtr n_RemoveIfMatch_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_etag)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] etag = (byte[]) JNIEnv.GetArray (native_etag, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveIfMatch (etag));
			if (etag != null)
				JNIEnv.CopyArray (etag, native_etag);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='removeIfMatch' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("removeIfMatch", "([B)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetRemoveIfMatch_arrayBHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet RemoveIfMatch (byte[] etag)
		{
			const string __id = "removeIfMatch.([B)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			IntPtr native_etag = JNIEnv.NewArray (etag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_etag);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (etag != null) {
					JNIEnv.CopyArray (native_etag, etag);
					JNIEnv.DeleteLocalRef (native_etag);
				}
			}
		}

		static Delegate cb_removeLocationQuery_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveLocationQuery_Ljava_lang_String_Handler ()
		{
			if (cb_removeLocationQuery_Ljava_lang_String_ == null)
				cb_removeLocationQuery_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveLocationQuery_Ljava_lang_String_);
			return cb_removeLocationQuery_Ljava_lang_String_;
		}

		static IntPtr n_RemoveLocationQuery_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_argument)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string argument = JNIEnv.GetString (native_argument, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveLocationQuery (argument));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='removeLocationQuery' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeLocationQuery", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetRemoveLocationQuery_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet RemoveLocationQuery (string argument)
		{
			const string __id = "removeLocationQuery.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			IntPtr native_argument = JNIEnv.NewString (argument);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_argument);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_argument);
			}
		}

		static Delegate cb_removeMaxAge;
#pragma warning disable 0169
		static Delegate GetRemoveMaxAgeHandler ()
		{
			if (cb_removeMaxAge == null)
				cb_removeMaxAge = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveMaxAge);
			return cb_removeMaxAge;
		}

		static IntPtr n_RemoveMaxAge (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveMaxAge ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='removeMaxAge' and count(parameter)=0]"
		[Register ("removeMaxAge", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetRemoveMaxAgeHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet RemoveMaxAge ()
		{
			const string __id = "removeMaxAge.()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeObserve;
#pragma warning disable 0169
		static Delegate GetRemoveObserveHandler ()
		{
			if (cb_removeObserve == null)
				cb_removeObserve = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveObserve);
			return cb_removeObserve;
		}

		static IntPtr n_RemoveObserve (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveObserve ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='removeObserve' and count(parameter)=0]"
		[Register ("removeObserve", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetRemoveObserveHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet RemoveObserve ()
		{
			const string __id = "removeObserve.()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeProxyScheme;
#pragma warning disable 0169
		static Delegate GetRemoveProxySchemeHandler ()
		{
			if (cb_removeProxyScheme == null)
				cb_removeProxyScheme = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveProxyScheme);
			return cb_removeProxyScheme;
		}

		static IntPtr n_RemoveProxyScheme (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveProxyScheme ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='removeProxyScheme' and count(parameter)=0]"
		[Register ("removeProxyScheme", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetRemoveProxySchemeHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet RemoveProxyScheme ()
		{
			const string __id = "removeProxyScheme.()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeProxyUri;
#pragma warning disable 0169
		static Delegate GetRemoveProxyUriHandler ()
		{
			if (cb_removeProxyUri == null)
				cb_removeProxyUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveProxyUri);
			return cb_removeProxyUri;
		}

		static IntPtr n_RemoveProxyUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveProxyUri ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='removeProxyUri' and count(parameter)=0]"
		[Register ("removeProxyUri", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetRemoveProxyUriHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet RemoveProxyUri ()
		{
			const string __id = "removeProxyUri.()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeSize1;
#pragma warning disable 0169
		static Delegate GetRemoveSize1Handler ()
		{
			if (cb_removeSize1 == null)
				cb_removeSize1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveSize1);
			return cb_removeSize1;
		}

		static IntPtr n_RemoveSize1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveSize1 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='removeSize1' and count(parameter)=0]"
		[Register ("removeSize1", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetRemoveSize1Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet RemoveSize1 ()
		{
			const string __id = "removeSize1.()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeSize2;
#pragma warning disable 0169
		static Delegate GetRemoveSize2Handler ()
		{
			if (cb_removeSize2 == null)
				cb_removeSize2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveSize2);
			return cb_removeSize2;
		}

		static IntPtr n_RemoveSize2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveSize2 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='removeSize2' and count(parameter)=0]"
		[Register ("removeSize2", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetRemoveSize2Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet RemoveSize2 ()
		{
			const string __id = "removeSize2.()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeUriHost;
#pragma warning disable 0169
		static Delegate GetRemoveUriHostHandler ()
		{
			if (cb_removeUriHost == null)
				cb_removeUriHost = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveUriHost);
			return cb_removeUriHost;
		}

		static IntPtr n_RemoveUriHost (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveUriHost ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='removeUriHost' and count(parameter)=0]"
		[Register ("removeUriHost", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetRemoveUriHostHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet RemoveUriHost ()
		{
			const string __id = "removeUriHost.()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeUriPort;
#pragma warning disable 0169
		static Delegate GetRemoveUriPortHandler ()
		{
			if (cb_removeUriPort == null)
				cb_removeUriPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveUriPort);
			return cb_removeUriPort;
		}

		static IntPtr n_RemoveUriPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveUriPort ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='removeUriPort' and count(parameter)=0]"
		[Register ("removeUriPort", "()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetRemoveUriPortHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet RemoveUriPort ()
		{
			const string __id = "removeUriPort.()Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeUriQuery_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveUriQuery_Ljava_lang_String_Handler ()
		{
			if (cb_removeUriQuery_Ljava_lang_String_ == null)
				cb_removeUriQuery_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveUriQuery_Ljava_lang_String_);
			return cb_removeUriQuery_Ljava_lang_String_;
		}

		static IntPtr n_RemoveUriQuery_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_argument)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string argument = JNIEnv.GetString (native_argument, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveUriQuery (argument));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='removeUriQuery' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeUriQuery", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetRemoveUriQuery_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet RemoveUriQuery (string argument)
		{
			const string __id = "removeUriQuery.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			IntPtr native_argument = JNIEnv.NewString (argument);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_argument);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_argument);
			}
		}

		static Delegate cb_setAccept_I;
#pragma warning disable 0169
		static Delegate GetSetAccept_IHandler ()
		{
			if (cb_setAccept_I == null)
				cb_setAccept_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetAccept_I);
			return cb_setAccept_I;
		}

		static IntPtr n_SetAccept_I (IntPtr jnienv, IntPtr native__this, int format)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAccept (format));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setAccept' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAccept", "(I)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetAccept_IHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetAccept (int format)
		{
			const string __id = "setAccept.(I)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (format);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setBlock1_arrayB;
#pragma warning disable 0169
		static Delegate GetSetBlock1_arrayBHandler ()
		{
			if (cb_setBlock1_arrayB == null)
				cb_setBlock1_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetBlock1_arrayB);
			return cb_setBlock1_arrayB;
		}

		static IntPtr n_SetBlock1_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBlock1 (value));
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setBlock1' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setBlock1", "([B)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetBlock1_arrayBHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetBlock1 (byte[] value)
		{
			const string __id = "setBlock1.([B)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_setBlock1_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_;
#pragma warning disable 0169
		static Delegate GetSetBlock1_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_Handler ()
		{
			if (cb_setBlock1_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_ == null)
				cb_setBlock1_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetBlock1_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_);
			return cb_setBlock1_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_;
		}

		static IntPtr n_SetBlock1_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_ (IntPtr jnienv, IntPtr native__this, IntPtr native_block)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption block = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption> (native_block, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBlock1 (block));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setBlock1' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.option.BlockOption']]"
		[Register ("setBlock1", "(Lcom/aliyun/alink/linksdk/alcs/coap/option/BlockOption;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetBlock1_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetBlock1 (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption block)
		{
			const string __id = "setBlock1.(Lcom/aliyun/alink/linksdk/alcs/coap/option/BlockOption;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((block == null) ? IntPtr.Zero : ((global::Java.Lang.Object) block).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setBlock1_IZI;
#pragma warning disable 0169
		static Delegate GetSetBlock1_IZIHandler ()
		{
			if (cb_setBlock1_IZI == null)
				cb_setBlock1_IZI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, int, IntPtr>) n_SetBlock1_IZI);
			return cb_setBlock1_IZI;
		}

		static IntPtr n_SetBlock1_IZI (IntPtr jnienv, IntPtr native__this, int szx, bool m, int num)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetBlock1 (szx, m, num));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setBlock1' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register ("setBlock1", "(IZI)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetBlock1_IZIHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetBlock1 (int szx, bool m, int num)
		{
			const string __id = "setBlock1.(IZI)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (szx);
				__args [1] = new JniArgumentValue (m);
				__args [2] = new JniArgumentValue (num);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setBlock2_arrayB;
#pragma warning disable 0169
		static Delegate GetSetBlock2_arrayBHandler ()
		{
			if (cb_setBlock2_arrayB == null)
				cb_setBlock2_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetBlock2_arrayB);
			return cb_setBlock2_arrayB;
		}

		static IntPtr n_SetBlock2_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBlock2 (value));
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setBlock2' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setBlock2", "([B)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetBlock2_arrayBHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetBlock2 (byte[] value)
		{
			const string __id = "setBlock2.([B)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_setBlock2_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_;
#pragma warning disable 0169
		static Delegate GetSetBlock2_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_Handler ()
		{
			if (cb_setBlock2_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_ == null)
				cb_setBlock2_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetBlock2_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_);
			return cb_setBlock2_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_;
		}

		static IntPtr n_SetBlock2_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_ (IntPtr jnienv, IntPtr native__this, IntPtr native_block)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption block = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption> (native_block, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBlock2 (block));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setBlock2' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.option.BlockOption']]"
		[Register ("setBlock2", "(Lcom/aliyun/alink/linksdk/alcs/coap/option/BlockOption;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetBlock2_Lcom_aliyun_alink_linksdk_alcs_coap_option_BlockOption_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetBlock2 (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption block)
		{
			const string __id = "setBlock2.(Lcom/aliyun/alink/linksdk/alcs/coap/option/BlockOption;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((block == null) ? IntPtr.Zero : ((global::Java.Lang.Object) block).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setBlock2_IZI;
#pragma warning disable 0169
		static Delegate GetSetBlock2_IZIHandler ()
		{
			if (cb_setBlock2_IZI == null)
				cb_setBlock2_IZI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, int, IntPtr>) n_SetBlock2_IZI);
			return cb_setBlock2_IZI;
		}

		static IntPtr n_SetBlock2_IZI (IntPtr jnienv, IntPtr native__this, int szx, bool m, int num)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetBlock2 (szx, m, num));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setBlock2' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register ("setBlock2", "(IZI)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetBlock2_IZIHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetBlock2 (int szx, bool m, int num)
		{
			const string __id = "setBlock2.(IZI)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (szx);
				__args [1] = new JniArgumentValue (m);
				__args [2] = new JniArgumentValue (num);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setContentFormat_I;
#pragma warning disable 0169
		static Delegate GetSetContentFormat_IHandler ()
		{
			if (cb_setContentFormat_I == null)
				cb_setContentFormat_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetContentFormat_I);
			return cb_setContentFormat_I;
		}

		static IntPtr n_SetContentFormat_I (IntPtr jnienv, IntPtr native__this, int format)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetContentFormat (format));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setContentFormat' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setContentFormat", "(I)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetContentFormat_IHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetContentFormat (int format)
		{
			const string __id = "setContentFormat.(I)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (format);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setIfNoneMatch_Z;
#pragma warning disable 0169
		static Delegate GetSetIfNoneMatch_ZHandler ()
		{
			if (cb_setIfNoneMatch_Z == null)
				cb_setIfNoneMatch_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetIfNoneMatch_Z);
			return cb_setIfNoneMatch_Z;
		}

		static IntPtr n_SetIfNoneMatch_Z (IntPtr jnienv, IntPtr native__this, bool present)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetIfNoneMatch (present));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setIfNoneMatch' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIfNoneMatch", "(Z)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetIfNoneMatch_ZHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetIfNoneMatch (bool present)
		{
			const string __id = "setIfNoneMatch.(Z)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (present);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setLocationPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLocationPath_Ljava_lang_String_Handler ()
		{
			if (cb_setLocationPath_Ljava_lang_String_ == null)
				cb_setLocationPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLocationPath_Ljava_lang_String_);
			return cb_setLocationPath_Ljava_lang_String_;
		}

		static IntPtr n_SetLocationPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLocationPath (path));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setLocationPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setLocationPath", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetLocationPath_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetLocationPath (string path)
		{
			const string __id = "setLocationPath.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_setLocationQuery_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLocationQuery_Ljava_lang_String_Handler ()
		{
			if (cb_setLocationQuery_Ljava_lang_String_ == null)
				cb_setLocationQuery_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLocationQuery_Ljava_lang_String_);
			return cb_setLocationQuery_Ljava_lang_String_;
		}

		static IntPtr n_SetLocationQuery_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_query)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string query = JNIEnv.GetString (native_query, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLocationQuery (query));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setLocationQuery' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setLocationQuery", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetLocationQuery_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetLocationQuery (string query)
		{
			const string __id = "setLocationQuery.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			IntPtr native_query = JNIEnv.NewString (query);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_query);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_query);
			}
		}

		static Delegate cb_setMaxAge_J;
#pragma warning disable 0169
		static Delegate GetSetMaxAge_JHandler ()
		{
			if (cb_setMaxAge_J == null)
				cb_setMaxAge_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetMaxAge_J);
			return cb_setMaxAge_J;
		}

		static IntPtr n_SetMaxAge_J (IntPtr jnienv, IntPtr native__this, long age)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMaxAge (age));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setMaxAge' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setMaxAge", "(J)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetMaxAge_JHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetMaxAge (long age)
		{
			const string __id = "setMaxAge.(J)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (age);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setObserve_I;
#pragma warning disable 0169
		static Delegate GetSetObserve_IHandler ()
		{
			if (cb_setObserve_I == null)
				cb_setObserve_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetObserve_I);
			return cb_setObserve_I;
		}

		static IntPtr n_SetObserve_I (IntPtr jnienv, IntPtr native__this, int seqnum)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetObserve (seqnum));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setObserve' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setObserve", "(I)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetObserve_IHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetObserve (int seqnum)
		{
			const string __id = "setObserve.(I)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (seqnum);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setProxyScheme_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProxyScheme_Ljava_lang_String_Handler ()
		{
			if (cb_setProxyScheme_Ljava_lang_String_ == null)
				cb_setProxyScheme_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetProxyScheme_Ljava_lang_String_);
			return cb_setProxyScheme_Ljava_lang_String_;
		}

		static IntPtr n_SetProxyScheme_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scheme)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string scheme = JNIEnv.GetString (native_scheme, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProxyScheme (scheme));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setProxyScheme' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setProxyScheme", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetProxyScheme_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetProxyScheme (string scheme)
		{
			const string __id = "setProxyScheme.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			IntPtr native_scheme = JNIEnv.NewString (scheme);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_scheme);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_scheme);
			}
		}

		static Delegate cb_setProxyUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProxyUri_Ljava_lang_String_Handler ()
		{
			if (cb_setProxyUri_Ljava_lang_String_ == null)
				cb_setProxyUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetProxyUri_Ljava_lang_String_);
			return cb_setProxyUri_Ljava_lang_String_;
		}

		static IntPtr n_SetProxyUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProxyUri (uri));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setProxyUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setProxyUri", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetProxyUri_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetProxyUri (string uri)
		{
			const string __id = "setProxyUri.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			IntPtr native_uri = JNIEnv.NewString (uri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_uri);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_uri);
			}
		}

		static Delegate cb_setSize1_I;
#pragma warning disable 0169
		static Delegate GetSetSize1_IHandler ()
		{
			if (cb_setSize1_I == null)
				cb_setSize1_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetSize1_I);
			return cb_setSize1_I;
		}

		static IntPtr n_SetSize1_I (IntPtr jnienv, IntPtr native__this, int size)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSize1 (size));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setSize1' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSize1", "(I)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetSize1_IHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetSize1 (int size)
		{
			const string __id = "setSize1.(I)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (size);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSize2_I;
#pragma warning disable 0169
		static Delegate GetSetSize2_IHandler ()
		{
			if (cb_setSize2_I == null)
				cb_setSize2_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetSize2_I);
			return cb_setSize2_I;
		}

		static IntPtr n_SetSize2_I (IntPtr jnienv, IntPtr native__this, int size)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSize2 (size));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setSize2' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSize2", "(I)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetSize2_IHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetSize2 (int size)
		{
			const string __id = "setSize2.(I)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (size);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setUriHost_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUriHost_Ljava_lang_String_Handler ()
		{
			if (cb_setUriHost_Ljava_lang_String_ == null)
				cb_setUriHost_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUriHost_Ljava_lang_String_);
			return cb_setUriHost_Ljava_lang_String_;
		}

		static IntPtr n_SetUriHost_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_host)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string host = JNIEnv.GetString (native_host, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUriHost (host));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setUriHost' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUriHost", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetUriHost_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetUriHost (string host)
		{
			const string __id = "setUriHost.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			IntPtr native_host = JNIEnv.NewString (host);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_host);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
			}
		}

		static Delegate cb_setUriPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUriPath_Ljava_lang_String_Handler ()
		{
			if (cb_setUriPath_Ljava_lang_String_ == null)
				cb_setUriPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUriPath_Ljava_lang_String_);
			return cb_setUriPath_Ljava_lang_String_;
		}

		static IntPtr n_SetUriPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUriPath (path));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setUriPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUriPath", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetUriPath_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetUriPath (string path)
		{
			const string __id = "setUriPath.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_setUriPort_I;
#pragma warning disable 0169
		static Delegate GetSetUriPort_IHandler ()
		{
			if (cb_setUriPort_I == null)
				cb_setUriPort_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetUriPort_I);
			return cb_setUriPort_I;
		}

		static IntPtr n_SetUriPort_I (IntPtr jnienv, IntPtr native__this, int port)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetUriPort (port));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setUriPort' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setUriPort", "(I)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetUriPort_IHandler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetUriPort (int port)
		{
			const string __id = "setUriPort.(I)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (port);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setUriQuery_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUriQuery_Ljava_lang_String_Handler ()
		{
			if (cb_setUriQuery_Ljava_lang_String_ == null)
				cb_setUriQuery_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUriQuery_Ljava_lang_String_);
			return cb_setUriQuery_Ljava_lang_String_;
		}

		static IntPtr n_SetUriQuery_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_query)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string query = JNIEnv.GetString (native_query, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUriQuery (query));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='OptionSet']/method[@name='setUriQuery' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUriQuery", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;", "GetSetUriQuery_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet SetUriQuery (string query)
		{
			const string __id = "setUriQuery.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/option/OptionSet;";
			IntPtr native_query = JNIEnv.NewString (query);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_query);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.OptionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_query);
			}
		}

	}
}
