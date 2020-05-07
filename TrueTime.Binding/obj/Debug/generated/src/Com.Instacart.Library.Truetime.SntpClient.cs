using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Instacart.Library.Truetime {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='SntpClient']"
	[global::Android.Runtime.Register ("com/instacart/library/truetime/SntpClient", DoNotGenerateAcw=true)]
	public partial class SntpClient : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='SntpClient']/field[@name='RESPONSE_INDEX_DISPERSION']"
		[Register ("RESPONSE_INDEX_DISPERSION")]
		public const int ResponseIndexDispersion = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='SntpClient']/field[@name='RESPONSE_INDEX_ORIGINATE_TIME']"
		[Register ("RESPONSE_INDEX_ORIGINATE_TIME")]
		public const int ResponseIndexOriginateTime = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='SntpClient']/field[@name='RESPONSE_INDEX_RECEIVE_TIME']"
		[Register ("RESPONSE_INDEX_RECEIVE_TIME")]
		public const int ResponseIndexReceiveTime = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='SntpClient']/field[@name='RESPONSE_INDEX_RESPONSE_TICKS']"
		[Register ("RESPONSE_INDEX_RESPONSE_TICKS")]
		public const int ResponseIndexResponseTicks = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='SntpClient']/field[@name='RESPONSE_INDEX_RESPONSE_TIME']"
		[Register ("RESPONSE_INDEX_RESPONSE_TIME")]
		public const int ResponseIndexResponseTime = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='SntpClient']/field[@name='RESPONSE_INDEX_ROOT_DELAY']"
		[Register ("RESPONSE_INDEX_ROOT_DELAY")]
		public const int ResponseIndexRootDelay = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='SntpClient']/field[@name='RESPONSE_INDEX_SIZE']"
		[Register ("RESPONSE_INDEX_SIZE")]
		public const int ResponseIndexSize = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='SntpClient']/field[@name='RESPONSE_INDEX_STRATUM']"
		[Register ("RESPONSE_INDEX_STRATUM")]
		public const int ResponseIndexStratum = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='SntpClient']/field[@name='RESPONSE_INDEX_TRANSMIT_TIME']"
		[Register ("RESPONSE_INDEX_TRANSMIT_TIME")]
		public const int ResponseIndexTransmitTime = (int) 2;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/instacart/library/truetime/SntpClient", typeof (SntpClient));
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

		protected SntpClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='SntpClient']/constructor[@name='SntpClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SntpClient ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='SntpClient']/method[@name='getClockOffset' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("getClockOffset", "([J)J", "")]
		public static unsafe long GetClockOffset (long[] response)
		{
			const string __id = "getClockOffset.([J)J";
			IntPtr native_response = JNIEnv.NewArray (response);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_response);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				if (response != null) {
					JNIEnv.CopyArray (native_response, response);
					JNIEnv.DeleteLocalRef (native_response);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='SntpClient']/method[@name='getRoundTripDelay' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("getRoundTripDelay", "([J)J", "")]
		public static unsafe long GetRoundTripDelay (long[] response)
		{
			const string __id = "getRoundTripDelay.([J)J";
			IntPtr native_response = JNIEnv.NewArray (response);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_response);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				if (response != null) {
					JNIEnv.CopyArray (native_response, response);
					JNIEnv.DeleteLocalRef (native_response);
				}
			}
		}

	}
}
