using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace cli_shared {
	class ObjectMarshal : ICustomMarshaler {
		HashSet<IntPtr> AllocatedData;

		[DebuggerStepThrough]
		public ObjectMarshal() {
			AllocatedData = new HashSet<IntPtr>();
		}

		[DebuggerStepThrough]
		public void CleanUpManagedData(object ManagedObj) {
		}

		[DebuggerStepThrough]
		public void CleanUpNativeData(IntPtr pNativeData) {
			if (AllocatedData.Contains(pNativeData)) {
				AllocatedData.Remove(pNativeData);
				Marshal.FreeHGlobal(pNativeData);
			}
		}

		[DebuggerStepThrough]
		public int GetNativeDataSize() {
			return -1;
		}

		[DebuggerStepThrough]
		public IntPtr MarshalManagedToNative(object ManagedObj) {
			if (ManagedObj == null)
				return IntPtr.Zero;

			if (ManagedObj is string) {
				IntPtr NativeData = Marshal.StringToHGlobalAnsi((string)ManagedObj);
				AllocatedData.Add(NativeData);
				return NativeData;
			} else if (ManagedObj is int)
				return (IntPtr)(int)ManagedObj;
			else if (ManagedObj is uint)
				return (IntPtr)(uint)ManagedObj;
			else if (ManagedObj is IntPtr)
				return (IntPtr)ManagedObj;

			return (IntPtr)(uint)Convert.ChangeType(ManagedObj, typeof(uint));
		}

		[DebuggerStepThrough]
		public object MarshalNativeToManaged(IntPtr pNativeData) {
			throw new NotImplementedException();
		}

		internal static ObjectMarshal Singleton;

		[DebuggerStepThrough]
		public static ICustomMarshaler GetInstance(string Cookie) {
			if (Singleton == null)
				Singleton = new ObjectMarshal();
			return Singleton;
		}
	}
}