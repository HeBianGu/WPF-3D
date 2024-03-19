using System;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// Custom marshaller for conversion to/from a System.IntPtr.
	/// </summary>
	// Token: 0x02000B75 RID: 2933
	public class vtkObjectMarshaler : ICustomMarshaler
	{
		// Token: 0x0601E9ED RID: 125421 RVA: 0x002B6B92 File Offset: 0x002B4D92
		void ICustomMarshaler.CleanUpManagedData(object ManagedObj)
		{
		}

		// Token: 0x0601E9EE RID: 125422 RVA: 0x002B6B95 File Offset: 0x002B4D95
		void ICustomMarshaler.CleanUpNativeData(IntPtr pNativeData)
		{
		}

		// Token: 0x0601E9EF RID: 125423 RVA: 0x002B6B98 File Offset: 0x002B4D98
		int ICustomMarshaler.GetNativeDataSize()
		{
			return IntPtr.Size;
		}

		// Token: 0x0601E9F0 RID: 125424 RVA: 0x002B6BB0 File Offset: 0x002B4DB0
		IntPtr ICustomMarshaler.MarshalManagedToNative(object ManagedObj)
		{
			return ((vtkObject)ManagedObj).GetCppThis().Handle;
		}

		// Token: 0x0601E9F1 RID: 125425 RVA: 0x002B6BD8 File Offset: 0x002B4DD8
		object ICustomMarshaler.MarshalNativeToManaged(IntPtr pNativeData)
		{
			bool flag;
			object obj = Methods.CreateWrappedObject(0U, uint.MaxValue, 4294967208U, pNativeData, true, out flag);
			if (obj == null)
			{
				Console.Error.WriteLine("error: *DID NOT FIND* o in MarshalNativeToManaged");
				obj = new vtkObject(pNativeData, false, false);
			}
			return obj;
		}

		/// <summary>
		/// Get the custom marshaller for vtkObject objects.
		/// </summary>
		// Token: 0x0601E9F2 RID: 125426 RVA: 0x002B6C20 File Offset: 0x002B4E20
		public static ICustomMarshaler GetInstance(string cookie)
		{
			return vtkObjectMarshaler.TheInstance;
		}

		// Token: 0x040020CF RID: 8399
		private static ICustomMarshaler TheInstance = new vtkObjectMarshaler();
	}
}
