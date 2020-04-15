using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Common.Executors
{
	
	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='UiThreadImmediateExecutorService']"
	[global::Android.Runtime.Register("com/facebook/common/executors/UiThreadImmediateExecutorService", DoNotGenerateAcw = true)]
	public partial class UiThreadImmediateExecutorService : global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl
	{

		static readonly JniPeerMembers _members = new XAPeerMembers("com/facebook/common/executors/UiThreadImmediateExecutorService", typeof(UiThreadImmediateExecutorService));
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

		protected UiThreadImmediateExecutorService(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

		public static unsafe global::Com.Facebook.Common.Executors.UiThreadImmediateExecutorService Instance
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='UiThreadImmediateExecutorService']/method[@name='getInstance' and count(parameter)=0]"
			[Register("getInstance", "()Lcom/facebook/common/executors/UiThreadImmediateExecutorService;", "")]
			get
			{
				const string __id = "getInstance.()Lcom/facebook/common/executors/UiThreadImmediateExecutorService;";
				try
				{
					var __rm = _members.StaticMethods.InvokeObjectMethod(__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.UiThreadImmediateExecutorService>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

	}
}
