using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Common.Executors
{
	
	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='HandlerExecutorServiceImpl']"
	[global::Android.Runtime.Register("com/facebook/common/executors/HandlerExecutorServiceImpl", DoNotGenerateAcw = true)]
	public partial class HandlerExecutorServiceImpl : global::Java.Util.Concurrent.AbstractExecutorService, IHandlerExecutorService
	{

		static readonly JniPeerMembers _members = new XAPeerMembers("com/facebook/common/executors/HandlerExecutorServiceImpl", typeof(HandlerExecutorServiceImpl));
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

		protected HandlerExecutorServiceImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='HandlerExecutorServiceImpl']/constructor[@name='HandlerExecutorServiceImpl' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register(".ctor", "(Landroid/os/Handler;)V", "")]
		public unsafe HandlerExecutorServiceImpl(global::Android.OS.Handler handler)
			: base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/os/Handler;)V";

			if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
				return;

			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object)handler).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
				SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance(__id, this, __args);
			}
			finally
			{
			}
		}

		static Delegate cb_isHandlerThread;
#pragma warning disable 0169
		static Delegate GetIsHandlerThreadHandler()
		{
			if (cb_isHandlerThread == null)
				cb_isHandlerThread = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool>)n_IsHandlerThread);
			return cb_isHandlerThread;
		}

		static bool n_IsHandlerThread(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHandlerThread;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsHandlerThread
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='HandlerExecutorServiceImpl']/method[@name='isHandlerThread' and count(parameter)=0]"
			[Register("isHandlerThread", "()Z", "GetIsHandlerThreadHandler")]
			get
			{
				const string __id = "isHandlerThread.()Z";
				try
				{
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod(__id, this, null);
					return __rm;
				}
				finally
				{
				}
			}
		}

		static Delegate cb_isShutdown;
#pragma warning disable 0169
		static Delegate GetIsShutdownHandler()
		{
			if (cb_isShutdown == null)
				cb_isShutdown = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool>)n_IsShutdown);
			return cb_isShutdown;
		}

		static bool n_IsShutdown(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShutdown;
		}
#pragma warning restore 0169

		public override unsafe bool IsShutdown
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='HandlerExecutorServiceImpl']/method[@name='isShutdown' and count(parameter)=0]"
			[Register("isShutdown", "()Z", "GetIsShutdownHandler")]
			get
			{
				const string __id = "isShutdown.()Z";
				try
				{
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod(__id, this, null);
					return __rm;
				}
				finally
				{
				}
			}
		}

		static Delegate cb_isTerminated;
#pragma warning disable 0169
		static Delegate GetIsTerminatedHandler()
		{
			if (cb_isTerminated == null)
				cb_isTerminated = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool>)n_IsTerminated);
			return cb_isTerminated;
		}

		static bool n_IsTerminated(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTerminated;
		}
#pragma warning restore 0169

		public override unsafe bool IsTerminated
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='HandlerExecutorServiceImpl']/method[@name='isTerminated' and count(parameter)=0]"
			[Register("isTerminated", "()Z", "GetIsTerminatedHandler")]
			get
			{
				const string __id = "isTerminated.()Z";
				try
				{
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod(__id, this, null);
					return __rm;
				}
				finally
				{
				}
			}
		}

		static Delegate cb_awaitTermination_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetAwaitTermination_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (cb_awaitTermination_JLjava_util_concurrent_TimeUnit_ == null)
				cb_awaitTermination_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, long, IntPtr, bool>)n_AwaitTermination_JLjava_util_concurrent_TimeUnit_);
			return cb_awaitTermination_JLjava_util_concurrent_TimeUnit_;
		}

		static bool n_AwaitTermination_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, long timeout, IntPtr native_unit)
		{
			global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AwaitTermination(timeout, unit);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='HandlerExecutorServiceImpl']/method[@name='awaitTermination' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register("awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z", "GetAwaitTermination_JLjava_util_concurrent_TimeUnit_Handler")]
		public override unsafe bool AwaitTermination(long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			const string __id = "awaitTermination.(JLjava/util/concurrent/TimeUnit;)Z";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[2];
				__args[0] = new JniArgumentValue(timeout);
				__args[1] = new JniArgumentValue((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object)unit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod(__id, this, __args);
				return __rm;
			}
			finally
			{
			}
		}

		static Delegate cb_execute_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetExecute_Ljava_lang_Runnable_Handler()
		{
			if (cb_execute_Ljava_lang_Runnable_ == null)
				cb_execute_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_Execute_Ljava_lang_Runnable_);
			return cb_execute_Ljava_lang_Runnable_;
		}

		static void n_Execute_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_command)
		{
			global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable command = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable>(native_command, JniHandleOwnership.DoNotTransfer);
			__this.Execute(command);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='HandlerExecutorServiceImpl']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register("execute", "(Ljava/lang/Runnable;)V", "GetExecute_Ljava_lang_Runnable_Handler")]
		public override unsafe void Execute(global::Java.Lang.IRunnable command)
		{
			const string __id = "execute.(Ljava/lang/Runnable;)V";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue((command == null) ? IntPtr.Zero : ((global::Java.Lang.Object)command).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
			}
			finally
			{
			}
		}

		static Delegate cb_newTaskFor_Ljava_lang_Runnable_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetNewTaskFor_Ljava_lang_Runnable_Ljava_lang_Object_Handler()
		{
			if (cb_newTaskFor_Ljava_lang_Runnable_Ljava_lang_Object_ == null)
				cb_newTaskFor_Ljava_lang_Runnable_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>)n_NewTaskFor_Ljava_lang_Runnable_Ljava_lang_Object_);
			return cb_newTaskFor_Ljava_lang_Runnable_Ljava_lang_Object_;
		}

		static IntPtr n_NewTaskFor_Ljava_lang_Runnable_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_runnable, IntPtr native_value)
		{
			global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable runnable = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable>(native_runnable, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.NewTaskFor(runnable, value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='HandlerExecutorServiceImpl']/method[@name='newTaskFor' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='T']]"
		[Register("newTaskFor", "(Ljava/lang/Runnable;Ljava/lang/Object;)Lcom/facebook/common/executors/ScheduledFutureImpl;", "GetNewTaskFor_Ljava_lang_Runnable_Ljava_lang_Object_Handler")]
		[global::Java.Interop.JavaTypeParameters(new string[] { "T" })]
		protected virtual unsafe global::Com.Facebook.Common.Executors.ScheduledFutureImpl NewTaskFor(global::Java.Lang.IRunnable runnable, global::Java.Lang.Object value)
		{
			const string __id = "newTaskFor.(Ljava/lang/Runnable;Ljava/lang/Object;)Lcom/facebook/common/executors/ScheduledFutureImpl;";
			IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[2];
				__args[0] = new JniArgumentValue((runnable == null) ? IntPtr.Zero : ((global::Java.Lang.Object)runnable).Handle);
				__args[1] = new JniArgumentValue(native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ScheduledFutureImpl>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(native_value);
			}
		}

		static Delegate cb_newTaskFor_Ljava_util_concurrent_Callable_;
#pragma warning disable 0169
		static Delegate GetNewTaskFor_Ljava_util_concurrent_Callable_Handler()
		{
			if (cb_newTaskFor_Ljava_util_concurrent_Callable_ == null)
				cb_newTaskFor_Ljava_util_concurrent_Callable_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_NewTaskFor_Ljava_util_concurrent_Callable_);
			return cb_newTaskFor_Ljava_util_concurrent_Callable_;
		}

		static IntPtr n_NewTaskFor_Ljava_util_concurrent_Callable_(IntPtr jnienv, IntPtr native__this, IntPtr native_callable)
		{
			global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.ICallable callable = (global::Java.Util.Concurrent.ICallable)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable>(native_callable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.NewTaskFor(callable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='HandlerExecutorServiceImpl']/method[@name='newTaskFor' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;T&gt;']]"
		[Register("newTaskFor", "(Ljava/util/concurrent/Callable;)Lcom/facebook/common/executors/ScheduledFutureImpl;", "GetNewTaskFor_Ljava_util_concurrent_Callable_Handler")]
		[global::Java.Interop.JavaTypeParameters(new string[] { "T" })]
		protected virtual unsafe global::Com.Facebook.Common.Executors.ScheduledFutureImpl NewTaskFor(global::Java.Util.Concurrent.ICallable callable)
		{
			const string __id = "newTaskFor.(Ljava/util/concurrent/Callable;)Lcom/facebook/common/executors/ScheduledFutureImpl;";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue((callable == null) ? IntPtr.Zero : ((global::Java.Lang.Object)callable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ScheduledFutureImpl>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_quit;
#pragma warning disable 0169
		static Delegate GetQuitHandler()
		{
			if (cb_quit == null)
				cb_quit = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr>)n_Quit);
			return cb_quit;
		}

		static void n_Quit(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Quit();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='HandlerExecutorServiceImpl']/method[@name='quit' and count(parameter)=0]"
		[Register("quit", "()V", "GetQuitHandler")]
		public virtual unsafe void Quit()
		{
			const string __id = "quit.()V";
			try
			{
				_members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, null);
			}
			finally
			{
			}
		}

		static Delegate cb_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetSchedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (cb_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ == null)
				cb_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr>)n_Schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_);
			return cb_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_Schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_command, long delay, IntPtr native_unit)
		{
			global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable command = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable>(native_command, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Schedule(command, delay, unit));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='HandlerExecutorServiceImpl']/method[@name='schedule' and count(parameter)=3 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register("schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", "GetSchedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IScheduledFuture Schedule(global::Java.Lang.IRunnable command, long delay, global::Java.Util.Concurrent.TimeUnit unit)
		{
			const string __id = "schedule.(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[3];
				__args[0] = new JniArgumentValue((command == null) ? IntPtr.Zero : ((global::Java.Lang.Object)command).Handle);
				__args[1] = new JniArgumentValue(delay);
				__args[2] = new JniArgumentValue((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object)unit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledFuture>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetSchedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (cb_schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_ == null)
				cb_schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr>)n_Schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_);
			return cb_schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_Schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_callable, long delay, IntPtr native_unit)
		{
			global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.ICallable callable = (global::Java.Util.Concurrent.ICallable)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable>(native_callable, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Schedule(callable, delay, unit));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='HandlerExecutorServiceImpl']/method[@name='schedule' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.Callable&lt;V&gt;'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register("schedule", "(Ljava/util/concurrent/Callable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", "GetSchedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_Handler")]
		[global::Java.Interop.JavaTypeParameters(new string[] { "V" })]
		public virtual unsafe global::Java.Util.Concurrent.IScheduledFuture Schedule(global::Java.Util.Concurrent.ICallable callable, long delay, global::Java.Util.Concurrent.TimeUnit unit)
		{
			const string __id = "schedule.(Ljava/util/concurrent/Callable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[3];
				__args[0] = new JniArgumentValue((callable == null) ? IntPtr.Zero : ((global::Java.Lang.Object)callable).Handle);
				__args[1] = new JniArgumentValue(delay);
				__args[2] = new JniArgumentValue((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object)unit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledFuture>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_scheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetScheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_Handler()
		{
			if (cb_scheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ == null)
				cb_scheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, long, long, IntPtr, IntPtr>)n_ScheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_);
			return cb_scheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_ScheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_command, long initialDelay, long period, IntPtr native_unit)
		{
			global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable command = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable>(native_command, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.ScheduleAtFixedRate(command, initialDelay, period, unit));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='HandlerExecutorServiceImpl']/method[@name='scheduleAtFixedRate' and count(parameter)=4 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.util.concurrent.TimeUnit']]"
		[Register("scheduleAtFixedRate", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", "GetScheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IScheduledFuture ScheduleAtFixedRate(global::Java.Lang.IRunnable command, long initialDelay, long period, global::Java.Util.Concurrent.TimeUnit unit)
		{
			const string __id = "scheduleAtFixedRate.(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[4];
				__args[0] = new JniArgumentValue((command == null) ? IntPtr.Zero : ((global::Java.Lang.Object)command).Handle);
				__args[1] = new JniArgumentValue(initialDelay);
				__args[2] = new JniArgumentValue(period);
				__args[3] = new JniArgumentValue((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object)unit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledFuture>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_scheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetScheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_Handler()
		{
			if (cb_scheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ == null)
				cb_scheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, long, long, IntPtr, IntPtr>)n_ScheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_);
			return cb_scheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_ScheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_command, long initialDelay, long delay, IntPtr native_unit)
		{
			global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable command = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable>(native_command, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.ScheduleWithFixedDelay(command, initialDelay, delay, unit));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='HandlerExecutorServiceImpl']/method[@name='scheduleWithFixedDelay' and count(parameter)=4 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.util.concurrent.TimeUnit']]"
		[Register("scheduleWithFixedDelay", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", "GetScheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IScheduledFuture ScheduleWithFixedDelay(global::Java.Lang.IRunnable command, long initialDelay, long delay, global::Java.Util.Concurrent.TimeUnit unit)
		{
			const string __id = "scheduleWithFixedDelay.(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[4];
				__args[0] = new JniArgumentValue((command == null) ? IntPtr.Zero : ((global::Java.Lang.Object)command).Handle);
				__args[1] = new JniArgumentValue(initialDelay);
				__args[2] = new JniArgumentValue(delay);
				__args[3] = new JniArgumentValue((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object)unit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledFuture>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_shutdown;
#pragma warning disable 0169
		static Delegate GetShutdownHandler()
		{
			if (cb_shutdown == null)
				cb_shutdown = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr>)n_Shutdown);
			return cb_shutdown;
		}

		static void n_Shutdown(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='HandlerExecutorServiceImpl']/method[@name='shutdown' and count(parameter)=0]"
		[Register("shutdown", "()V", "GetShutdownHandler")]
		public override unsafe void Shutdown()
		{
			const string __id = "shutdown.()V";
			try
			{
				_members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, null);
			}
			finally
			{
			}
		}

		static Delegate cb_shutdownNow;
#pragma warning disable 0169
		static Delegate GetShutdownNowHandler()
		{
			if (cb_shutdownNow == null)
				cb_shutdownNow = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_ShutdownNow);
			return cb_shutdownNow;
		}

		static IntPtr n_ShutdownNow(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.IRunnable>.ToLocalJniHandle(__this.ShutdownNow());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='HandlerExecutorServiceImpl']/method[@name='shutdownNow' and count(parameter)=0]"
		[Register("shutdownNow", "()Ljava/util/List;", "GetShutdownNowHandler")]
		public override unsafe global::System.Collections.Generic.IList<global::Java.Lang.IRunnable> ShutdownNow()
		{
			const string __id = "shutdownNow.()Ljava/util/List;";
			try
			{
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
				return global::Android.Runtime.JavaList<global::Java.Lang.IRunnable>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSubmit_Ljava_lang_Runnable_Ljava_lang_Object_Handler()
		{
			if (cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_ == null)
				cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>)n_Submit_Ljava_lang_Runnable_Ljava_lang_Object_);
			return cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_;
		}

		static IntPtr n_Submit_Ljava_lang_Runnable_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_task, IntPtr native_result)
		{
			global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable task = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable>(native_task, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object result = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_result, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Submit(task, result));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='HandlerExecutorServiceImpl']/method[@name='submit' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='T']]"
		[Register("submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/ScheduledFuture;", "GetSubmit_Ljava_lang_Runnable_Ljava_lang_Object_Handler")]
		[global::Java.Interop.JavaTypeParameters(new string[] { "T" })]
		public virtual unsafe global::Java.Util.Concurrent.IScheduledFuture Submit(global::Java.Lang.IRunnable task, global::Java.Lang.Object result)
		{
			const string __id = "submit.(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/ScheduledFuture;";
			IntPtr native_result = JNIEnv.ToLocalJniHandle(result);
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[2];
				__args[0] = new JniArgumentValue((task == null) ? IntPtr.Zero : ((global::Java.Lang.Object)task).Handle);
				__args[1] = new JniArgumentValue(native_result);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledFuture>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(native_result);
			}
		}

		static Delegate cb_submit_Ljava_util_concurrent_Callable_;
#pragma warning disable 0169
		static Delegate GetSubmit_Ljava_util_concurrent_Callable_Handler()
		{
			if (cb_submit_Ljava_util_concurrent_Callable_ == null)
				cb_submit_Ljava_util_concurrent_Callable_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_Submit_Ljava_util_concurrent_Callable_);
			return cb_submit_Ljava_util_concurrent_Callable_;
		}

		static IntPtr n_Submit_Ljava_util_concurrent_Callable_(IntPtr jnienv, IntPtr native__this, IntPtr native_task)
		{
			global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.HandlerExecutorServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.ICallable task = (global::Java.Util.Concurrent.ICallable)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable>(native_task, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Submit(task));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.common.executors']/class[@name='HandlerExecutorServiceImpl']/method[@name='submit' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;T&gt;']]"
		[Register("submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/ScheduledFuture;", "GetSubmit_Ljava_util_concurrent_Callable_Handler")]
		[global::Java.Interop.JavaTypeParameters(new string[] { "T" })]
		public virtual unsafe global::Java.Util.Concurrent.IScheduledFuture Submit(global::Java.Util.Concurrent.ICallable task)
		{
			const string __id = "submit.(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/ScheduledFuture;";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue((task == null) ? IntPtr.Zero : ((global::Java.Lang.Object)task).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledFuture>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

	}
}
