using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHierarchicalDataSetGeometryFilter
	/// </summary>
	/// <remarks>
	///    extract geometry from hierarchical data
	///
	/// Legacy class. Use vtkCompositeDataGeometryFilter instead.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCompositeDataGeometryFilter
	/// </seealso>
	// Token: 0x0200090B RID: 2315
	public class vtkHierarchicalDataSetGeometryFilter : vtkCompositeDataGeometryFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018020 RID: 98336 RVA: 0x0021977F File Offset: 0x0021797F
		static vtkHierarchicalDataSetGeometryFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalDataSetGeometryFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalDataSetGeometryFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018021 RID: 98337 RVA: 0x002197A7 File Offset: 0x002179A7
		public vtkHierarchicalDataSetGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018022 RID: 98338
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalDataSetGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018023 RID: 98339 RVA: 0x002197B8 File Offset: 0x002179B8
		public new static vtkHierarchicalDataSetGeometryFilter New()
		{
			vtkHierarchicalDataSetGeometryFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalDataSetGeometryFilter.vtkHierarchicalDataSetGeometryFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalDataSetGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018024 RID: 98340 RVA: 0x0021980C File Offset: 0x00217A0C
		public vtkHierarchicalDataSetGeometryFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHierarchicalDataSetGeometryFilter.vtkHierarchicalDataSetGeometryFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018025 RID: 98341 RVA: 0x00219850 File Offset: 0x00217A50
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018026 RID: 98342
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalDataSetGeometryFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018027 RID: 98343 RVA: 0x0021985C File Offset: 0x00217A5C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHierarchicalDataSetGeometryFilter.vtkHierarchicalDataSetGeometryFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06018028 RID: 98344
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalDataSetGeometryFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018029 RID: 98345 RVA: 0x0021987C File Offset: 0x00217A7C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHierarchicalDataSetGeometryFilter.vtkHierarchicalDataSetGeometryFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601802A RID: 98346
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalDataSetGeometryFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601802B RID: 98347 RVA: 0x00219898 File Offset: 0x00217A98
		public override int IsA(string type)
		{
			return vtkHierarchicalDataSetGeometryFilter.vtkHierarchicalDataSetGeometryFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601802C RID: 98348
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalDataSetGeometryFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601802D RID: 98349 RVA: 0x002198B8 File Offset: 0x00217AB8
		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalDataSetGeometryFilter.vtkHierarchicalDataSetGeometryFilter_IsTypeOf_04(type);
		}

		// Token: 0x0601802E RID: 98350
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalDataSetGeometryFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601802F RID: 98351 RVA: 0x002198D4 File Offset: 0x00217AD4
		public new vtkHierarchicalDataSetGeometryFilter NewInstance()
		{
			vtkHierarchicalDataSetGeometryFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalDataSetGeometryFilter.vtkHierarchicalDataSetGeometryFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalDataSetGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018030 RID: 98352
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalDataSetGeometryFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018031 RID: 98353 RVA: 0x00219930 File Offset: 0x00217B30
		public new static vtkHierarchicalDataSetGeometryFilter SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalDataSetGeometryFilter vtkHierarchicalDataSetGeometryFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalDataSetGeometryFilter.vtkHierarchicalDataSetGeometryFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalDataSetGeometryFilter = (vtkHierarchicalDataSetGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalDataSetGeometryFilter.Register(null);
				}
			}
			return vtkHierarchicalDataSetGeometryFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AC0 RID: 6848
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalDataSetGeometryFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AC1 RID: 6849
		public new static readonly string MRClassNameKey = "class vtkHierarchicalDataSetGeometryFilter";
	}
}
