using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Instacart.Library.Truetime {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='InvalidNtpServerResponseException']"
	[global::Android.Runtime.Register ("com/instacart/library/truetime/InvalidNtpServerResponseException", DoNotGenerateAcw=true)]
	public partial class InvalidNtpServerResponseException : global::Java.IO.IOException {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='InvalidNtpServerResponseException']/field[@name='actualValue']"
		[Register ("actualValue")]
		public float ActualValue {
			get {
				const string __id = "actualValue.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "actualValue.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='InvalidNtpServerResponseException']/field[@name='expectedValue']"
		[Register ("expectedValue")]
		public float ExpectedValue {
			get {
				const string __id = "expectedValue.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "expectedValue.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.instacart.library.truetime']/class[@name='InvalidNtpServerResponseException']/field[@name='property']"
		[Register ("property")]
		public string Property {
			get {
				const string __id = "property.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "property.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/instacart/library/truetime/InvalidNtpServerResponseException", typeof (InvalidNtpServerResponseException));
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

		protected InvalidNtpServerResponseException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
