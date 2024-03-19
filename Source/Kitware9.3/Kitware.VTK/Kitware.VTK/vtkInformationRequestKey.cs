using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationRequestKey
	/// </summary>
	/// <remarks>
	///    Key for pointer to pointer.
	///
	/// vtkInformationRequestKey is used to represent keys for pointer
	/// to pointer values in vtkInformation.h
	/// </remarks>
	// Token: 0x02000B65 RID: 2917
	public class vtkInformationRequestKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E7B6 RID: 124854 RVA: 0x002B39F4 File Offset: 0x002B1BF4
		static vtkInformationRequestKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationRequestKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationRequestKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E7B7 RID: 124855 RVA: 0x002B3A1C File Offset: 0x002B1C1C
		public vtkInformationRequestKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E7B8 RID: 124856 RVA: 0x002B3A2A File Offset: 0x002B1C2A
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E7B9 RID: 124857
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationRequestKey_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7BA RID: 124858 RVA: 0x002B3A38 File Offset: 0x002B1C38
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationRequestKey.vtkInformationRequestKey_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601E7BB RID: 124859
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationRequestKey_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7BC RID: 124860 RVA: 0x002B3A58 File Offset: 0x002B1C58
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationRequestKey.vtkInformationRequestKey_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601E7BD RID: 124861
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationRequestKey_Has_03(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E7BE RID: 124862 RVA: 0x002B3A74 File Offset: 0x002B1C74
		public override int Has(vtkInformation info)
		{
			return vtkInformationRequestKey.vtkInformationRequestKey_Has_03(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E7BF RID: 124863
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationRequestKey_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7C0 RID: 124864 RVA: 0x002B3AA8 File Offset: 0x002B1CA8
		public override int IsA(string type)
		{
			return vtkInformationRequestKey.vtkInformationRequestKey_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E7C1 RID: 124865
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationRequestKey_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7C2 RID: 124866 RVA: 0x002B3AC8 File Offset: 0x002B1CC8
		public new static int IsTypeOf(string type)
		{
			return vtkInformationRequestKey.vtkInformationRequestKey_IsTypeOf_05(type);
		}

		// Token: 0x0601E7C3 RID: 124867
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationRequestKey_MakeKey_06([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method simply returns a new vtkInformationRequestKey, given a
		/// name and a location. This method is provided for wrappers. Use the
		/// constructor directly from C++ instead.
		/// </summary>
		// Token: 0x0601E7C4 RID: 124868 RVA: 0x002B3AE4 File Offset: 0x002B1CE4
		public static vtkInformationRequestKey MakeKey(string name, string location)
		{
			vtkInformationRequestKey vtkInformationRequestKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationRequestKey.vtkInformationRequestKey_MakeKey_06(name, location, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationRequestKey = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationRequestKey.Register(null);
				}
			}
			return vtkInformationRequestKey;
		}

		// Token: 0x0601E7C5 RID: 124869
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationRequestKey_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7C6 RID: 124870 RVA: 0x002B3B50 File Offset: 0x002B1D50
		public new vtkInformationRequestKey NewInstance()
		{
			vtkInformationRequestKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationRequestKey.vtkInformationRequestKey_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E7C7 RID: 124871
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationRequestKey_Remove_08(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E7C8 RID: 124872 RVA: 0x002B3BAC File Offset: 0x002B1DAC
		public override void Remove(vtkInformation info)
		{
			vtkInformationRequestKey.vtkInformationRequestKey_Remove_08(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E7C9 RID: 124873
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationRequestKey_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7CA RID: 124874 RVA: 0x002B3BDC File Offset: 0x002B1DDC
		public new static vtkInformationRequestKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationRequestKey vtkInformationRequestKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationRequestKey.vtkInformationRequestKey_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationRequestKey = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationRequestKey.Register(null);
				}
			}
			return vtkInformationRequestKey;
		}

		// Token: 0x0601E7CB RID: 124875
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationRequestKey_Set_10(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E7CC RID: 124876 RVA: 0x002B3C5C File Offset: 0x002B1E5C
		public void Set(vtkInformation info)
		{
			vtkInformationRequestKey.vtkInformationRequestKey_Set_10(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E7CD RID: 124877
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationRequestKey_ShallowCopy_11(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601E7CE RID: 124878 RVA: 0x002B3C8C File Offset: 0x002B1E8C
		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationRequestKey.vtkInformationRequestKey_ShallowCopy_11(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020A9 RID: 8361
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationRequestKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020AA RID: 8362
		public new static readonly string MRClassNameKey = "class vtkInformationRequestKey";
	}
}
