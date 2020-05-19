using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Imagepipeline.Backends.Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.imagepipeline.backends.okhttp3']/class[@name='OkHttpNetworkFetcher']"
	[global::Android.Runtime.Register ("com/facebook/imagepipeline/backends/okhttp3/OkHttpNetworkFetcher", DoNotGenerateAcw=true)]
	public partial class OkHttpNetworkFetcher : global::Com.Facebook.Imagepipeline.Producers.BaseNetworkFetcher {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.imagepipeline.backends.okhttp3']/class[@name='OkHttpNetworkFetcher.OkHttpNetworkFetchState']"
		[global::Android.Runtime.Register ("com/facebook/imagepipeline/backends/okhttp3/OkHttpNetworkFetcher$OkHttpNetworkFetchState", DoNotGenerateAcw=true)]
		public partial class OkHttpNetworkFetchState : global::Com.Facebook.Imagepipeline.Producers.FetchState {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.imagepipeline.backends.okhttp3']/class[@name='OkHttpNetworkFetcher.OkHttpNetworkFetchState']/field[@name='fetchCompleteTime']"
			[Register ("fetchCompleteTime")]
			public long FetchCompleteTime {
				get {
					const string __id = "fetchCompleteTime.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "fetchCompleteTime.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.imagepipeline.backends.okhttp3']/class[@name='OkHttpNetworkFetcher.OkHttpNetworkFetchState']/field[@name='responseTime']"
			[Register ("responseTime")]
			public long ResponseTime {
				get {
					const string __id = "responseTime.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "responseTime.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.imagepipeline.backends.okhttp3']/class[@name='OkHttpNetworkFetcher.OkHttpNetworkFetchState']/field[@name='submitTime']"
			[Register ("submitTime")]
			public long SubmitTime {
				get {
					const string __id = "submitTime.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "submitTime.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/imagepipeline/backends/okhttp3/OkHttpNetworkFetcher$OkHttpNetworkFetchState", typeof (OkHttpNetworkFetchState));
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

			protected OkHttpNetworkFetchState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.imagepipeline.backends.okhttp3']/class[@name='OkHttpNetworkFetcher.OkHttpNetworkFetchState']/constructor[@name='OkHttpNetworkFetcher.OkHttpNetworkFetchState' and count(parameter)=2 and parameter[1][@type='com.facebook.imagepipeline.producers.Consumer&lt;com.facebook.imagepipeline.image.EncodedImage&gt;'] and parameter[2][@type='com.facebook.imagepipeline.producers.ProducerContext']]"
			[Register (".ctor", "(Lcom/facebook/imagepipeline/producers/Consumer;Lcom/facebook/imagepipeline/producers/ProducerContext;)V", "")]
			public unsafe OkHttpNetworkFetchState (global::Com.Facebook.Imagepipeline.Producers.IConsumer consumer, global::Com.Facebook.Imagepipeline.Producers.IProducerContext producerContext)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/facebook/imagepipeline/producers/Consumer;Lcom/facebook/imagepipeline/producers/ProducerContext;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
					__args [1] = new JniArgumentValue ((producerContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) producerContext).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/imagepipeline/backends/okhttp3/OkHttpNetworkFetcher", typeof (OkHttpNetworkFetcher));
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

		protected OkHttpNetworkFetcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.imagepipeline.backends.okhttp3']/class[@name='OkHttpNetworkFetcher']/constructor[@name='OkHttpNetworkFetcher' and count(parameter)=2 and parameter[1][@type='okhttp3.Call.Factory'] and parameter[2][@type='java.util.concurrent.Executor']]"
		[Register (".ctor", "(Lokhttp3/Call$Factory;Ljava/util/concurrent/Executor;)V", "")]
		public unsafe OkHttpNetworkFetcher (global::Okhttp3.ICallFactory callFactory, global::Java.Util.Concurrent.IExecutor cancellationExecutor)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokhttp3/Call$Factory;Ljava/util/concurrent/Executor;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((callFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callFactory).Handle);
				__args [1] = new JniArgumentValue ((cancellationExecutor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cancellationExecutor).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.imagepipeline.backends.okhttp3']/class[@name='OkHttpNetworkFetcher']/constructor[@name='OkHttpNetworkFetcher' and count(parameter)=1 and parameter[1][@type='okhttp3.OkHttpClient']]"
		[Register (".ctor", "(Lokhttp3/OkHttpClient;)V", "")]
		public unsafe OkHttpNetworkFetcher (global::Okhttp3.OkHttpClient okHttpClient)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokhttp3/OkHttpClient;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((okHttpClient == null) ? IntPtr.Zero : ((global::Java.Lang.Object) okHttpClient).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_createFetchState_Lcom_facebook_imagepipeline_producers_Consumer_Lcom_facebook_imagepipeline_producers_ProducerContext_;
#pragma warning disable 0169
		static Delegate GetCreateFetchState_Lcom_facebook_imagepipeline_producers_Consumer_Lcom_facebook_imagepipeline_producers_ProducerContext_Handler ()
		{
			if (cb_createFetchState_Lcom_facebook_imagepipeline_producers_Consumer_Lcom_facebook_imagepipeline_producers_ProducerContext_ == null)
				cb_createFetchState_Lcom_facebook_imagepipeline_producers_Consumer_Lcom_facebook_imagepipeline_producers_ProducerContext_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateFetchState_Lcom_facebook_imagepipeline_producers_Consumer_Lcom_facebook_imagepipeline_producers_ProducerContext_);
			return cb_createFetchState_Lcom_facebook_imagepipeline_producers_Consumer_Lcom_facebook_imagepipeline_producers_ProducerContext_;
		}

		static IntPtr n_CreateFetchState_Lcom_facebook_imagepipeline_producers_Consumer_Lcom_facebook_imagepipeline_producers_ProducerContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_consumer, IntPtr native_context)
		{
			global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Producers.IConsumer consumer = (global::Com.Facebook.Imagepipeline.Producers.IConsumer)global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Producers.IConsumer> (native_consumer, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Producers.IProducerContext context = (global::Com.Facebook.Imagepipeline.Producers.IProducerContext)global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Producers.IProducerContext> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateFetchState (consumer, context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.imagepipeline.backends.okhttp3']/class[@name='OkHttpNetworkFetcher']/method[@name='createFetchState' and count(parameter)=2 and parameter[1][@type='com.facebook.imagepipeline.producers.Consumer&lt;com.facebook.imagepipeline.image.EncodedImage&gt;'] and parameter[2][@type='com.facebook.imagepipeline.producers.ProducerContext']]"
		[Register ("createFetchState", "(Lcom/facebook/imagepipeline/producers/Consumer;Lcom/facebook/imagepipeline/producers/ProducerContext;)Lcom/facebook/imagepipeline/backends/okhttp3/OkHttpNetworkFetcher$OkHttpNetworkFetchState;", "GetCreateFetchState_Lcom_facebook_imagepipeline_producers_Consumer_Lcom_facebook_imagepipeline_producers_ProducerContext_Handler")]
		public virtual unsafe global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher.OkHttpNetworkFetchState CreateFetchState (global::Com.Facebook.Imagepipeline.Producers.IConsumer consumer, global::Com.Facebook.Imagepipeline.Producers.IProducerContext context)
		{
			const string __id = "createFetchState.(Lcom/facebook/imagepipeline/producers/Consumer;Lcom/facebook/imagepipeline/producers/ProducerContext;)Lcom/facebook/imagepipeline/backends/okhttp3/OkHttpNetworkFetcher$OkHttpNetworkFetchState;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher.OkHttpNetworkFetchState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_fetch_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_Lcom_facebook_imagepipeline_producers_NetworkFetcher_Callback_;
#pragma warning disable 0169
		static Delegate GetFetch_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_Lcom_facebook_imagepipeline_producers_NetworkFetcher_Callback_Handler ()
		{
			if (cb_fetch_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_Lcom_facebook_imagepipeline_producers_NetworkFetcher_Callback_ == null)
				cb_fetch_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_Lcom_facebook_imagepipeline_producers_NetworkFetcher_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Fetch_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_Lcom_facebook_imagepipeline_producers_NetworkFetcher_Callback_);
			return cb_fetch_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_Lcom_facebook_imagepipeline_producers_NetworkFetcher_Callback_;
		}

		static void n_Fetch_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_Lcom_facebook_imagepipeline_producers_NetworkFetcher_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fetchState, IntPtr native__callback)
		{
			global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher.OkHttpNetworkFetchState fetchState = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher.OkHttpNetworkFetchState> (native_fetchState, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Producers.INetworkFetcherCallback @callback = (global::Com.Facebook.Imagepipeline.Producers.INetworkFetcherCallback)global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Producers.INetworkFetcherCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Fetch (fetchState, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.imagepipeline.backends.okhttp3']/class[@name='OkHttpNetworkFetcher']/method[@name='fetch' and count(parameter)=2 and parameter[1][@type='com.facebook.imagepipeline.backends.okhttp3.OkHttpNetworkFetcher.OkHttpNetworkFetchState'] and parameter[2][@type='com.facebook.imagepipeline.producers.NetworkFetcher.Callback']]"
		[Register ("fetch", "(Lcom/facebook/imagepipeline/backends/okhttp3/OkHttpNetworkFetcher$OkHttpNetworkFetchState;Lcom/facebook/imagepipeline/producers/NetworkFetcher$Callback;)V", "GetFetch_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_Lcom_facebook_imagepipeline_producers_NetworkFetcher_Callback_Handler")]
		public virtual unsafe void Fetch (global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher.OkHttpNetworkFetchState fetchState, global::Com.Facebook.Imagepipeline.Producers.INetworkFetcherCallback @callback)
		{
			const string __id = "fetch.(Lcom/facebook/imagepipeline/backends/okhttp3/OkHttpNetworkFetcher$OkHttpNetworkFetchState;Lcom/facebook/imagepipeline/producers/NetworkFetcher$Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((fetchState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fetchState).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_fetchWithRequest_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_Lcom_facebook_imagepipeline_producers_NetworkFetcher_Callback_Lokhttp3_Request_;
#pragma warning disable 0169
		static Delegate GetFetchWithRequest_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_Lcom_facebook_imagepipeline_producers_NetworkFetcher_Callback_Lokhttp3_Request_Handler ()
		{
			if (cb_fetchWithRequest_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_Lcom_facebook_imagepipeline_producers_NetworkFetcher_Callback_Lokhttp3_Request_ == null)
				cb_fetchWithRequest_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_Lcom_facebook_imagepipeline_producers_NetworkFetcher_Callback_Lokhttp3_Request_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_FetchWithRequest_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_Lcom_facebook_imagepipeline_producers_NetworkFetcher_Callback_Lokhttp3_Request_);
			return cb_fetchWithRequest_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_Lcom_facebook_imagepipeline_producers_NetworkFetcher_Callback_Lokhttp3_Request_;
		}

		static void n_FetchWithRequest_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_Lcom_facebook_imagepipeline_producers_NetworkFetcher_Callback_Lokhttp3_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fetchState, IntPtr native__callback, IntPtr native_request)
		{
			global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher.OkHttpNetworkFetchState fetchState = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher.OkHttpNetworkFetchState> (native_fetchState, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Producers.INetworkFetcherCallback @callback = (global::Com.Facebook.Imagepipeline.Producers.INetworkFetcherCallback)global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Producers.INetworkFetcherCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Request request = global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (native_request, JniHandleOwnership.DoNotTransfer);
			__this.FetchWithRequest (fetchState, @callback, request);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.imagepipeline.backends.okhttp3']/class[@name='OkHttpNetworkFetcher']/method[@name='fetchWithRequest' and count(parameter)=3 and parameter[1][@type='com.facebook.imagepipeline.backends.okhttp3.OkHttpNetworkFetcher.OkHttpNetworkFetchState'] and parameter[2][@type='com.facebook.imagepipeline.producers.NetworkFetcher.Callback'] and parameter[3][@type='okhttp3.Request']]"
		[Register ("fetchWithRequest", "(Lcom/facebook/imagepipeline/backends/okhttp3/OkHttpNetworkFetcher$OkHttpNetworkFetchState;Lcom/facebook/imagepipeline/producers/NetworkFetcher$Callback;Lokhttp3/Request;)V", "GetFetchWithRequest_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_Lcom_facebook_imagepipeline_producers_NetworkFetcher_Callback_Lokhttp3_Request_Handler")]
		protected virtual unsafe void FetchWithRequest (global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher.OkHttpNetworkFetchState fetchState, global::Com.Facebook.Imagepipeline.Producers.INetworkFetcherCallback @callback, global::Okhttp3.Request request)
		{
			const string __id = "fetchWithRequest.(Lcom/facebook/imagepipeline/backends/okhttp3/OkHttpNetworkFetcher$OkHttpNetworkFetchState;Lcom/facebook/imagepipeline/producers/NetworkFetcher$Callback;Lokhttp3/Request;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((fetchState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fetchState).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [2] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getExtraMap_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_I;
#pragma warning disable 0169
		static Delegate GetGetExtraMap_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_IHandler ()
		{
			if (cb_getExtraMap_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_I == null)
				cb_getExtraMap_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetExtraMap_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_I);
			return cb_getExtraMap_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_I;
		}

		static IntPtr n_GetExtraMap_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_I (IntPtr jnienv, IntPtr native__this, IntPtr native_fetchState, int byteSize)
		{
			global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher.OkHttpNetworkFetchState fetchState = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher.OkHttpNetworkFetchState> (native_fetchState, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.GetExtraMap (fetchState, byteSize));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.imagepipeline.backends.okhttp3']/class[@name='OkHttpNetworkFetcher']/method[@name='getExtraMap' and count(parameter)=2 and parameter[1][@type='com.facebook.imagepipeline.backends.okhttp3.OkHttpNetworkFetcher.OkHttpNetworkFetchState'] and parameter[2][@type='int']]"
		[Register ("getExtraMap", "(Lcom/facebook/imagepipeline/backends/okhttp3/OkHttpNetworkFetcher$OkHttpNetworkFetchState;I)Ljava/util/Map;", "GetGetExtraMap_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_IHandler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> GetExtraMap (global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher.OkHttpNetworkFetchState fetchState, int byteSize)
		{
			const string __id = "getExtraMap.(Lcom/facebook/imagepipeline/backends/okhttp3/OkHttpNetworkFetcher$OkHttpNetworkFetchState;I)Ljava/util/Map;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((fetchState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fetchState).Handle);
				__args [1] = new JniArgumentValue (byteSize);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onFetchCompletion_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_I;
#pragma warning disable 0169
		static Delegate GetOnFetchCompletion_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_IHandler ()
		{
			if (cb_onFetchCompletion_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_I == null)
				cb_onFetchCompletion_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnFetchCompletion_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_I);
			return cb_onFetchCompletion_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_I;
		}

		static void n_OnFetchCompletion_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_I (IntPtr jnienv, IntPtr native__this, IntPtr native_fetchState, int byteSize)
		{
			global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher.OkHttpNetworkFetchState fetchState = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher.OkHttpNetworkFetchState> (native_fetchState, JniHandleOwnership.DoNotTransfer);
			__this.OnFetchCompletion (fetchState, byteSize);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.imagepipeline.backends.okhttp3']/class[@name='OkHttpNetworkFetcher']/method[@name='onFetchCompletion' and count(parameter)=2 and parameter[1][@type='com.facebook.imagepipeline.backends.okhttp3.OkHttpNetworkFetcher.OkHttpNetworkFetchState'] and parameter[2][@type='int']]"
		[Register ("onFetchCompletion", "(Lcom/facebook/imagepipeline/backends/okhttp3/OkHttpNetworkFetcher$OkHttpNetworkFetchState;I)V", "GetOnFetchCompletion_Lcom_facebook_imagepipeline_backends_okhttp3_OkHttpNetworkFetcher_OkHttpNetworkFetchState_IHandler")]
		public virtual unsafe void OnFetchCompletion (global::Com.Facebook.Imagepipeline.Backends.Okhttp3.OkHttpNetworkFetcher.OkHttpNetworkFetchState fetchState, int byteSize)
		{
			const string __id = "onFetchCompletion.(Lcom/facebook/imagepipeline/backends/okhttp3/OkHttpNetworkFetcher$OkHttpNetworkFetchState;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((fetchState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fetchState).Handle);
				__args [1] = new JniArgumentValue (byteSize);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
