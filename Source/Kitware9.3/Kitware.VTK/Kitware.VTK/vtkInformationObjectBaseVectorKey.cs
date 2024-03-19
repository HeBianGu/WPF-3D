using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationObjectBaseVectorKey
	/// </summary>
	/// <remarks>
	///    Key for vtkObjectBase vector values.
	///
	/// vtkInformationObjectBaseVectorKey is used to represent keys for double
	/// vector values in vtkInformation.h. NOTE the interface in this key differs
	/// from that in other similar keys because of our internal use of smart
	/// pointers.
	/// </remarks>
	// Token: 0x02000B64 RID: 2916
	public class vtkInformationObjectBaseVectorKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E791 RID: 124817 RVA: 0x002B355C File Offset: 0x002B175C
		static vtkInformationObjectBaseVectorKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationObjectBaseVectorKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationObjectBaseVectorKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E792 RID: 124818 RVA: 0x002B3584 File Offset: 0x002B1784
		public vtkInformationObjectBaseVectorKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E793 RID: 124819 RVA: 0x002B3592 File Offset: 0x002B1792
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E794 RID: 124820
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationObjectBaseVectorKey_Append_01(HandleRef pThis, HandleRef info, HandleRef value);

		/// <summary>
		/// Put the value on the back of the vector, with ref counting.
		/// </summary>
		// Token: 0x0601E795 RID: 124821 RVA: 0x002B35A0 File Offset: 0x002B17A0
		public void Append(vtkInformation info, vtkObjectBase value)
		{
			vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_Append_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E796 RID: 124822
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationObjectBaseVectorKey_Clear_02(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Clear the vector.
		/// </summary>
		// Token: 0x0601E797 RID: 124823 RVA: 0x002B35E4 File Offset: 0x002B17E4
		public void Clear(vtkInformation info)
		{
			vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_Clear_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E798 RID: 124824
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationObjectBaseVectorKey_Get_03(HandleRef pThis, HandleRef info, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkObjectBase at a specific location in the vector.
		/// </summary>
		// Token: 0x0601E799 RID: 124825 RVA: 0x002B3614 File Offset: 0x002B1814
		public vtkObjectBase Get(vtkInformation info, int idx)
		{
			vtkObjectBase vtkObjectBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_Get_03(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObjectBase = (vtkObjectBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObjectBase.Register(null);
				}
			}
			return vtkObjectBase;
		}

		// Token: 0x0601E79A RID: 124826
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationObjectBaseVectorKey_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E79B RID: 124827 RVA: 0x002B369C File Offset: 0x002B189C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E79C RID: 124828
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationObjectBaseVectorKey_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E79D RID: 124829 RVA: 0x002B36BC File Offset: 0x002B18BC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601E79E RID: 124830
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationObjectBaseVectorKey_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E79F RID: 124831 RVA: 0x002B36D8 File Offset: 0x002B18D8
		public override int IsA(string type)
		{
			return vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601E7A0 RID: 124832
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationObjectBaseVectorKey_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7A1 RID: 124833 RVA: 0x002B36F8 File Offset: 0x002B18F8
		public new static int IsTypeOf(string type)
		{
			return vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_IsTypeOf_07(type);
		}

		// Token: 0x0601E7A2 RID: 124834
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationObjectBaseVectorKey_Length_08(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get the vector's length.
		/// </summary>
		// Token: 0x0601E7A3 RID: 124835 RVA: 0x002B3714 File Offset: 0x002B1914
		public int Length(vtkInformation info)
		{
			return vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_Length_08(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E7A4 RID: 124836
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationObjectBaseVectorKey_MakeKey_09([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, [MarshalAs(UnmanagedType.LPUTF8Str)] string requiredClass, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method simply returns a new vtkInformationObjectBaseVectorKey, given a
		/// name, location and optionally a required class (a classname to restrict
		/// which class types can be set with this key). This method is provided
		/// for wrappers. Use the constructor directly from C++ instead.
		/// </summary>
		// Token: 0x0601E7A5 RID: 124837 RVA: 0x002B3748 File Offset: 0x002B1948
		public static vtkInformationObjectBaseVectorKey MakeKey(string name, string location, string requiredClass)
		{
			vtkInformationObjectBaseVectorKey vtkInformationObjectBaseVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_MakeKey_09(name, location, requiredClass, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationObjectBaseVectorKey = (vtkInformationObjectBaseVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationObjectBaseVectorKey.Register(null);
				}
			}
			return vtkInformationObjectBaseVectorKey;
		}

		// Token: 0x0601E7A6 RID: 124838
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationObjectBaseVectorKey_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7A7 RID: 124839 RVA: 0x002B37B4 File Offset: 0x002B19B4
		public new vtkInformationObjectBaseVectorKey NewInstance()
		{
			vtkInformationObjectBaseVectorKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationObjectBaseVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E7A8 RID: 124840
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationObjectBaseVectorKey_Remove_11(HandleRef pThis, HandleRef info, HandleRef val);

		/// <summary>
		/// Remove all instances of val from the list. If using the indexed overload,
		/// the object at the specified position is removed.
		/// </summary>
		// Token: 0x0601E7A9 RID: 124841 RVA: 0x002B3810 File Offset: 0x002B1A10
		public void Remove(vtkInformation info, vtkObjectBase val)
		{
			vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_Remove_11(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (val == null) ? default(HandleRef) : val.GetCppThis());
		}

		// Token: 0x0601E7AA RID: 124842
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationObjectBaseVectorKey_Remove_12(HandleRef pThis, HandleRef info, int idx);

		/// <summary>
		/// Remove all instances of val from the list. If using the indexed overload,
		/// the object at the specified position is removed.
		/// </summary>
		// Token: 0x0601E7AB RID: 124843 RVA: 0x002B3854 File Offset: 0x002B1A54
		public void Remove(vtkInformation info, int idx)
		{
			vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_Remove_12(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), idx);
		}

		// Token: 0x0601E7AC RID: 124844
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationObjectBaseVectorKey_Resize_13(HandleRef pThis, HandleRef info, int size);

		/// <summary>
		/// Resize (extend) the vector to hold size objects. Any new elements
		/// created will be null initialized.
		/// </summary>
		// Token: 0x0601E7AD RID: 124845 RVA: 0x002B3884 File Offset: 0x002B1A84
		public void Resize(vtkInformation info, int size)
		{
			vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_Resize_13(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), size);
		}

		// Token: 0x0601E7AE RID: 124846
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationObjectBaseVectorKey_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7AF RID: 124847 RVA: 0x002B38B4 File Offset: 0x002B1AB4
		public new static vtkInformationObjectBaseVectorKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationObjectBaseVectorKey vtkInformationObjectBaseVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationObjectBaseVectorKey = (vtkInformationObjectBaseVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationObjectBaseVectorKey.Register(null);
				}
			}
			return vtkInformationObjectBaseVectorKey;
		}

		// Token: 0x0601E7B0 RID: 124848
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationObjectBaseVectorKey_Set_15(HandleRef pThis, HandleRef info, HandleRef value, int i);

		/// <summary>
		/// Set element i of the vector to value. Resizes the vector
		/// if needed.
		/// </summary>
		// Token: 0x0601E7B1 RID: 124849 RVA: 0x002B3934 File Offset: 0x002B1B34
		public void Set(vtkInformation info, vtkObjectBase value, int i)
		{
			vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_Set_15(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis(), i);
		}

		// Token: 0x0601E7B2 RID: 124850
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationObjectBaseVectorKey_ShallowCopy_16(HandleRef pThis, HandleRef source, HandleRef dest);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601E7B3 RID: 124851 RVA: 0x002B397C File Offset: 0x002B1B7C
		public override void ShallowCopy(vtkInformation source, vtkInformation dest)
		{
			vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_ShallowCopy_16(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis(), (dest == null) ? default(HandleRef) : dest.GetCppThis());
		}

		// Token: 0x0601E7B4 RID: 124852
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationObjectBaseVectorKey_Size_17(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get the vector's length.
		/// </summary>
		// Token: 0x0601E7B5 RID: 124853 RVA: 0x002B39C0 File Offset: 0x002B1BC0
		public int Size(vtkInformation info)
		{
			return vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_Size_17(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020A7 RID: 8359
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationObjectBaseVectorKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020A8 RID: 8360
		public new static readonly string MRClassNameKey = "class vtkInformationObjectBaseVectorKey";
	}
}
