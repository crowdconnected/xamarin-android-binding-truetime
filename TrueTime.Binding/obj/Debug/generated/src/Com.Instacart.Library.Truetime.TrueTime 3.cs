using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Instacart.Library.Truetime {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='TrueTime']"
	[global::Android.Runtime.Register ("com/instacart/library/truetime/TrueTime", DoNotGenerateAcw=true)]
	public partial class TrueTime : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/instacart/library/truetime/TrueTime", typeof (TrueTime));
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

		protected TrueTime (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='TrueTime']/constructor[@name='TrueTime' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TrueTime ()
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

		public static unsafe bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='TrueTime']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "")]
			get {
				const string __id = "isInitialized.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='TrueTime']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/instacart/library/truetime/TrueTime;", "")]
		public static unsafe global::Com.Instacart.Library.Truetime.TrueTime Build ()
		{
			const string __id = "build.()Lcom/instacart/library/truetime/TrueTime;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Instacart.Library.Truetime.TrueTime> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='TrueTime']/method[@name='clearCachedInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearCachedInfo", "(Landroid/content/Context;)V", "")]
		public static unsafe void ClearCachedInfo (global::Android.Content.Context context)
		{
			const string __id = "clearCachedInfo.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_freshInitialize;
#pragma warning disable 0169
		static Delegate GetFreshInitializeHandler ()
		{
			if (cb_freshInitialize == null)
				cb_freshInitialize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FreshInitialize);
			return cb_freshInitialize;
		}

		static void n_FreshInitialize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instacart.Library.Truetime.TrueTime __this = global::Java.Lang.Object.GetObject<global::Com.Instacart.Library.Truetime.TrueTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FreshInitialize ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='TrueTime']/method[@name='freshInitialize' and count(parameter)=0]"
		[Register ("freshInitialize", "()V", "GetFreshInitializeHandler")]
		public virtual unsafe void FreshInitialize ()
		{
			const string __id = "freshInitialize.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_freshInitialize_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFreshInitialize_Ljava_lang_String_Handler ()
		{
			if (cb_freshInitialize_Ljava_lang_String_ == null)
				cb_freshInitialize_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FreshInitialize_Ljava_lang_String_);
			return cb_freshInitialize_Ljava_lang_String_;
		}

		static void n_FreshInitialize_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ntpHost)
		{
			global::Com.Instacart.Library.Truetime.TrueTime __this = global::Java.Lang.Object.GetObject<global::Com.Instacart.Library.Truetime.TrueTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string ntpHost = JNIEnv.GetString (native_ntpHost, JniHandleOwnership.DoNotTransfer);
			__this.FreshInitialize (ntpHost);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='TrueTime']/method[@name='freshInitialize' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("freshInitialize", "(Ljava/lang/String;)V", "GetFreshInitialize_Ljava_lang_String_Handler")]
		protected virtual unsafe void FreshInitialize (string ntpHost)
		{
			const string __id = "freshInitialize.(Ljava/lang/String;)V";
			IntPtr native_ntpHost = JNIEnv.NewString (ntpHost);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ntpHost);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_ntpHost);
			}
		}

		static Delegate cb_initialize;
#pragma warning disable 0169
		static Delegate GetInitializeHandler ()
		{
			if (cb_initialize == null)
				cb_initialize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Initialize);
			return cb_initialize;
		}

		static void n_Initialize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instacart.Library.Truetime.TrueTime __this = global::Java.Lang.Object.GetObject<global::Com.Instacart.Library.Truetime.TrueTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Initialize ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='TrueTime']/method[@name='initialize' and count(parameter)=0]"
		[Register ("initialize", "()V", "GetInitializeHandler")]
		public virtual unsafe void Initialize ()
		{
			const string __id = "initialize.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_initialize_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInitialize_Ljava_lang_String_Handler ()
		{
			if (cb_initialize_Ljava_lang_String_ == null)
				cb_initialize_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Initialize_Ljava_lang_String_);
			return cb_initialize_Ljava_lang_String_;
		}

		static void n_Initialize_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ntpHost)
		{
			global::Com.Instacart.Library.Truetime.TrueTime __this = global::Java.Lang.Object.GetObject<global::Com.Instacart.Library.Truetime.TrueTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string ntpHost = JNIEnv.GetString (native_ntpHost, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (ntpHost);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='TrueTime']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("initialize", "(Ljava/lang/String;)V", "GetInitialize_Ljava_lang_String_Handler")]
		protected virtual unsafe void Initialize (string ntpHost)
		{
			const string __id = "initialize.(Ljava/lang/String;)V";
			IntPtr native_ntpHost = JNIEnv.NewString (ntpHost);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ntpHost);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_ntpHost);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='TrueTime']/method[@name='now' and count(parameter)=0]"
		[Register ("now", "()Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date Now ()
		{
			const string __id = "now.()Ljava/util/Date;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withConnectionTimeout_I;
#pragma warning disable 0169
		static Delegate GetWithConnectionTimeout_IHandler ()
		{
			if (cb_withConnectionTimeout_I == null)
				cb_withConnectionTimeout_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithConnectionTimeout_I);
			return cb_withConnectionTimeout_I;
		}

		static IntPtr n_WithConnectionTimeout_I (IntPtr jnienv, IntPtr native__this, int timeoutInMillis)
		{
			global::Com.Instacart.Library.Truetime.TrueTime __this = global::Java.Lang.Object.GetObject<global::Com.Instacart.Library.Truetime.TrueTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithConnectionTimeout (timeoutInMillis));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='TrueTime']/method[@name='withConnectionTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withConnectionTimeout", "(I)Lcom/instacart/library/truetime/TrueTime;", "GetWithConnectionTimeout_IHandler")]
		public virtual unsafe global::Com.Instacart.Library.Truetime.TrueTime WithConnectionTimeout (int timeoutInMillis)
		{
			const string __id = "withConnectionTimeout.(I)Lcom/instacart/library/truetime/TrueTime;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeoutInMillis);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Instacart.Library.Truetime.TrueTime> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withLoggingEnabled_Z;
#pragma warning disable 0169
		static Delegate GetWithLoggingEnabled_ZHandler ()
		{
			if (cb_withLoggingEnabled_Z == null)
				cb_withLoggingEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithLoggingEnabled_Z);
			return cb_withLoggingEnabled_Z;
		}

		static IntPtr n_WithLoggingEnabled_Z (IntPtr jnienv, IntPtr native__this, bool isLoggingEnabled)
		{
			global::Com.Instacart.Library.Truetime.TrueTime __this = global::Java.Lang.Object.GetObject<global::Com.Instacart.Library.Truetime.TrueTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithLoggingEnabled (isLoggingEnabled));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='TrueTime']/method[@name='withLoggingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withLoggingEnabled", "(Z)Lcom/instacart/library/truetime/TrueTime;", "GetWithLoggingEnabled_ZHandler")]
		public virtual unsafe global::Com.Instacart.Library.Truetime.TrueTime WithLoggingEnabled (bool isLoggingEnabled)
		{
			const string __id = "withLoggingEnabled.(Z)Lcom/instacart/library/truetime/TrueTime;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isLoggingEnabled);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Instacart.Library.Truetime.TrueTime> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withNtpHost_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithNtpHost_Ljava_lang_String_Handler ()
		{
			if (cb_withNtpHost_Ljava_lang_String_ == null)
				cb_withNtpHost_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithNtpHost_Ljava_lang_String_);
			return cb_withNtpHost_Ljava_lang_String_;
		}

		static IntPtr n_WithNtpHost_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ntpHost)
		{
			global::Com.Instacart.Library.Truetime.TrueTime __this = global::Java.Lang.Object.GetObject<global::Com.Instacart.Library.Truetime.TrueTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string ntpHost = JNIEnv.GetString (native_ntpHost, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithNtpHost (ntpHost));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='TrueTime']/method[@name='withNtpHost' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withNtpHost", "(Ljava/lang/String;)Lcom/instacart/library/truetime/TrueTime;", "GetWithNtpHost_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Instacart.Library.Truetime.TrueTime WithNtpHost (string ntpHost)
		{
			const string __id = "withNtpHost.(Ljava/lang/String;)Lcom/instacart/library/truetime/TrueTime;";
			IntPtr native_ntpHost = JNIEnv.NewString (ntpHost);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ntpHost);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Instacart.Library.Truetime.TrueTime> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_ntpHost);
			}
		}

		static Delegate cb_withRootDelayMax_F;
#pragma warning disable 0169
		static Delegate GetWithRootDelayMax_FHandler ()
		{
			if (cb_withRootDelayMax_F == null)
				cb_withRootDelayMax_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_WithRootDelayMax_F);
			return cb_withRootDelayMax_F;
		}

		static IntPtr n_WithRootDelayMax_F (IntPtr jnienv, IntPtr native__this, float rootDelayMax)
		{
			global::Com.Instacart.Library.Truetime.TrueTime __this = global::Java.Lang.Object.GetObject<global::Com.Instacart.Library.Truetime.TrueTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithRootDelayMax (rootDelayMax));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='TrueTime']/method[@name='withRootDelayMax' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("withRootDelayMax", "(F)Lcom/instacart/library/truetime/TrueTime;", "GetWithRootDelayMax_FHandler")]
		public virtual unsafe global::Com.Instacart.Library.Truetime.TrueTime WithRootDelayMax (float rootDelayMax)
		{
			const string __id = "withRootDelayMax.(F)Lcom/instacart/library/truetime/TrueTime;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rootDelayMax);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Instacart.Library.Truetime.TrueTime> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withRootDispersionMax_F;
#pragma warning disable 0169
		static Delegate GetWithRootDispersionMax_FHandler ()
		{
			if (cb_withRootDispersionMax_F == null)
				cb_withRootDispersionMax_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_WithRootDispersionMax_F);
			return cb_withRootDispersionMax_F;
		}

		static IntPtr n_WithRootDispersionMax_F (IntPtr jnienv, IntPtr native__this, float rootDispersionMax)
		{
			global::Com.Instacart.Library.Truetime.TrueTime __this = global::Java.Lang.Object.GetObject<global::Com.Instacart.Library.Truetime.TrueTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithRootDispersionMax (rootDispersionMax));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='TrueTime']/method[@name='withRootDispersionMax' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("withRootDispersionMax", "(F)Lcom/instacart/library/truetime/TrueTime;", "GetWithRootDispersionMax_FHandler")]
		public virtual unsafe global::Com.Instacart.Library.Truetime.TrueTime WithRootDispersionMax (float rootDispersionMax)
		{
			const string __id = "withRootDispersionMax.(F)Lcom/instacart/library/truetime/TrueTime;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rootDispersionMax);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Instacart.Library.Truetime.TrueTime> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withServerResponseDelayMax_I;
#pragma warning disable 0169
		static Delegate GetWithServerResponseDelayMax_IHandler ()
		{
			if (cb_withServerResponseDelayMax_I == null)
				cb_withServerResponseDelayMax_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithServerResponseDelayMax_I);
			return cb_withServerResponseDelayMax_I;
		}

		static IntPtr n_WithServerResponseDelayMax_I (IntPtr jnienv, IntPtr native__this, int serverResponseDelayInMillis)
		{
			global::Com.Instacart.Library.Truetime.TrueTime __this = global::Java.Lang.Object.GetObject<global::Com.Instacart.Library.Truetime.TrueTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithServerResponseDelayMax (serverResponseDelayInMillis));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='TrueTime']/method[@name='withServerResponseDelayMax' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withServerResponseDelayMax", "(I)Lcom/instacart/library/truetime/TrueTime;", "GetWithServerResponseDelayMax_IHandler")]
		public virtual unsafe global::Com.Instacart.Library.Truetime.TrueTime WithServerResponseDelayMax (int serverResponseDelayInMillis)
		{
			const string __id = "withServerResponseDelayMax.(I)Lcom/instacart/library/truetime/TrueTime;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (serverResponseDelayInMillis);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Instacart.Library.Truetime.TrueTime> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withSharedPreferences_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetWithSharedPreferences_Landroid_content_Context_Handler ()
		{
			if (cb_withSharedPreferences_Landroid_content_Context_ == null)
				cb_withSharedPreferences_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSharedPreferences_Landroid_content_Context_);
			return cb_withSharedPreferences_Landroid_content_Context_;
		}

		static IntPtr n_WithSharedPreferences_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Instacart.Library.Truetime.TrueTime __this = global::Java.Lang.Object.GetObject<global::Com.Instacart.Library.Truetime.TrueTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSharedPreferences (context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='TrueTime']/method[@name='withSharedPreferences' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("withSharedPreferences", "(Landroid/content/Context;)Lcom/instacart/library/truetime/TrueTime;", "GetWithSharedPreferences_Landroid_content_Context_Handler")]
		public virtual unsafe global::Com.Instacart.Library.Truetime.TrueTime WithSharedPreferences (global::Android.Content.Context context)
		{
			const string __id = "withSharedPreferences.(Landroid/content/Context;)Lcom/instacart/library/truetime/TrueTime;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Instacart.Library.Truetime.TrueTime> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
