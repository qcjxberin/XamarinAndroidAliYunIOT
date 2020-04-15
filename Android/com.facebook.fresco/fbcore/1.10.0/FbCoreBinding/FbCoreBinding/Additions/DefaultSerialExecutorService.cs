using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Common.Executors
{
	
	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='DefaultSerialExecutorService']"
	[global::Android.Runtime.Register("com/facebook/common/executors/DefaultSerialExecutorService", DoNotGenerateAcw = true)]
	public partial class DefaultSerialExecutorService : global::Com.Facebook.Common.Executors.ConstrainedExecutorService, ISerialExecutorService
	{

		static readonly JniPeerMembers _members = new XAPeerMembers("com/facebook/common/executors/DefaultSerialExecutorService", typeof(DefaultSerialExecutorService));
		internal static new IntPtr class_ref
		{
			get
			{
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers
		{
			get { return _members; }
		}

		protected override IntPtr ThresholdClass
		{
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType
		{
			get { return _members.ManagedPeerType; }
		}

		protected DefaultSerialExecutorService(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='DefaultSerialExecutorService']/constructor[@name='DefaultSerialExecutorService' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Executor']]"
		[Register(".ctor", "(Ljava/util/concurrent/Executor;)V", "")]
		public unsafe DefaultSerialExecutorService(global::Java.Util.Concurrent.IExecutor executor)
			: base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/concurrent/Executor;)V";

			if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
				return;

			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue((executor == null) ? IntPtr.Zero : ((global::Java.Lang.Object)executor).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
				SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance(__id, this, __args);
			}
			finally
			{
			}
		}

	}
}
