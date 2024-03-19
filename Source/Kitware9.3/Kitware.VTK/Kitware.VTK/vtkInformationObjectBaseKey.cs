using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationObjectBaseKey
	/// </summary>
	/// <remarks>
	///    Key for vtkObjectBase values.
	///
	/// vtkInformationObjectBaseKey is used to represent keys in
	/// vtkInformation for values that are vtkObjectBase instances.
	/// </remarks>
	// Token: 0x02000B63 RID: 2915
	public class vtkInformationObjectBaseKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E778 RID: 124792 RVA: 0x002B3204 File Offset: 0x002B1404
		static vtkInformationObjectBaseKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationObjectBaseKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationObjectBaseKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E779 RID: 124793 RVA: 0x002B322C File Offset: 0x002B142C
		public vtkInformationObjectBaseKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E77A RID: 124794 RVA: 0x002B323A File Offset: 0x002B143A
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E77B RID: 124795
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationObjectBaseKey_Get_01(HandleRef pThis, HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E77C RID: 124796 RVA: 0x002B3248 File Offset: 0x002B1448
		public vtkObjectBase Get(vtkInformation info)
		{
			vtkObjectBase vtkObjectBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationObjectBaseKey.vtkInformationObjectBaseKey_Get_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601E77D RID: 124797
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationObjectBaseKey_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E77E RID: 124798 RVA: 0x002B32D0 File Offset: 0x002B14D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationObjectBaseKey.vtkInformationObjectBaseKey_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601E77F RID: 124799
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationObjectBaseKey_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E780 RID: 124800 RVA: 0x002B32F0 File Offset: 0x002B14F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationObjectBaseKey.vtkInformationObjectBaseKey_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601E781 RID: 124801
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationObjectBaseKey_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E782 RID: 124802 RVA: 0x002B330C File Offset: 0x002B150C
		public override int IsA(string type)
		{
			return vtkInformationObjectBaseKey.vtkInformationObjectBaseKey_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E783 RID: 124803
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationObjectBaseKey_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E784 RID: 124804 RVA: 0x002B332C File Offset: 0x002B152C
		public new static int IsTypeOf(string type)
		{
			return vtkInformationObjectBaseKey.vtkInformationObjectBaseKey_IsTypeOf_05(type);
		}

		// Token: 0x0601E785 RID: 124805
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationObjectBaseKey_MakeKey_06([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, [MarshalAs(UnmanagedType.LPUTF8Str)] string requiredClass, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method simply returns a new vtkInformationObjectBaseKey, given a
		/// name, location and optionally a required class (a classname to restrict
		/// which class types can be set with this key). This method is provided
		/// for wrappers. Use the constructor directly from C++ instead.
		/// </summary>
		// Token: 0x0601E786 RID: 124806 RVA: 0x002B3348 File Offset: 0x002B1548
		public static vtkInformationObjectBaseKey MakeKey(string name, string location, string requiredClass)
		{
			vtkInformationObjectBaseKey vtkInformationObjectBaseKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationObjectBaseKey.vtkInformationObjectBaseKey_MakeKey_06(name, location, requiredClass, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationObjectBaseKey = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationObjectBaseKey.Register(null);
				}
			}
			return vtkInformationObjectBaseKey;
		}

		// Token: 0x0601E787 RID: 124807
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationObjectBaseKey_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E788 RID: 124808 RVA: 0x002B33B4 File Offset: 0x002B15B4
		public new vtkInformationObjectBaseKey NewInstance()
		{
			vtkInformationObjectBaseKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationObjectBaseKey.vtkInformationObjectBaseKey_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E789 RID: 124809
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationObjectBaseKey_Report_08(HandleRef pThis, HandleRef info, HandleRef collector);

		/// <summary>
		/// Report a reference this key has in the given information object.
		/// </summary>
		// Token: 0x0601E78A RID: 124810 RVA: 0x002B3410 File Offset: 0x002B1610
		public override void Report(vtkInformation info, vtkGarbageCollector collector)
		{
			vtkInformationObjectBaseKey.vtkInformationObjectBaseKey_Report_08(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (collector == null) ? default(HandleRef) : collector.GetCppThis());
		}

		// Token: 0x0601E78B RID: 124811
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationObjectBaseKey_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E78C RID: 124812 RVA: 0x002B3454 File Offset: 0x002B1654
		public new static vtkInformationObjectBaseKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationObjectBaseKey vtkInformationObjectBaseKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationObjectBaseKey.vtkInformationObjectBaseKey_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationObjectBaseKey = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationObjectBaseKey.Register(null);
				}
			}
			return vtkInformationObjectBaseKey;
		}

		// Token: 0x0601E78D RID: 124813
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationObjectBaseKey_Set_10(HandleRef pThis, HandleRef info, HandleRef arg1);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E78E RID: 124814 RVA: 0x002B34D4 File Offset: 0x002B16D4
		public void Set(vtkInformation info, vtkObjectBase arg1)
		{
			vtkInformationObjectBaseKey.vtkInformationObjectBaseKey_Set_10(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601E78F RID: 124815
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationObjectBaseKey_ShallowCopy_11(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601E790 RID: 124816 RVA: 0x002B3518 File Offset: 0x002B1718
		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationObjectBaseKey.vtkInformationObjectBaseKey_ShallowCopy_11(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020A5 RID: 8357
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationObjectBaseKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020A6 RID: 8358
		public new static readonly string MRClassNameKey = "class vtkInformationObjectBaseKey";
	}
}
