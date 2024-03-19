using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRectilinearGridGeometryFilter
	/// </summary>
	/// <remarks>
	///    extract geometry for a rectilinear grid
	///
	/// vtkRectilinearGridGeometryFilter is a filter that extracts geometry from a
	/// rectilinear grid. By specifying appropriate i-j-k indices, it is possible
	/// to extract a point, a curve, a surface, or a "volume". The volume
	/// is actually a (n x m x o) region of points.
	///
	/// The extent specification is zero-offset. That is, the first k-plane in
	/// a 50x50x50 rectilinear grid is given by (0,49, 0,49, 0,0).
	///
	/// @warning
	/// If you don't know the dimensions of the input dataset, you can use a large
	/// number to specify extent (the number will be clamped appropriately). For
	/// example, if the dataset dimensions are 50x50x50, and you want a the fifth
	/// k-plane, you can use the extents (0,100, 0,100, 4,4). The 100 will
	/// automatically be clamped to 49.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGeometryFilter vtkExtractGrid
	/// </seealso>
	// Token: 0x02000911 RID: 2321
	public class vtkRectilinearGridGeometryFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060180DA RID: 98522 RVA: 0x0021A8CF File Offset: 0x00218ACF
		static vtkRectilinearGridGeometryFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectilinearGridGeometryFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGridGeometryFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060180DB RID: 98523 RVA: 0x0021A8F7 File Offset: 0x00218AF7
		public vtkRectilinearGridGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060180DC RID: 98524
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with initial extent (0,100, 0,100, 0,0) (i.e., a k-plane).
		/// </summary>
		// Token: 0x060180DD RID: 98525 RVA: 0x0021A908 File Offset: 0x00218B08
		public new static vtkRectilinearGridGeometryFilter New()
		{
			vtkRectilinearGridGeometryFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridGeometryFilter.vtkRectilinearGridGeometryFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with initial extent (0,100, 0,100, 0,0) (i.e., a k-plane).
		/// </summary>
		// Token: 0x060180DE RID: 98526 RVA: 0x0021A95C File Offset: 0x00218B5C
		public vtkRectilinearGridGeometryFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRectilinearGridGeometryFilter.vtkRectilinearGridGeometryFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060180DF RID: 98527 RVA: 0x0021A9A0 File Offset: 0x00218BA0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060180E0 RID: 98528
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridGeometryFilter_GetExtent_01(HandleRef pThis);

		/// <summary>
		/// Get the extent in topological coordinate range (imin,imax, jmin,jmax,
		/// kmin,kmax).
		/// </summary>
		// Token: 0x060180E1 RID: 98529 RVA: 0x0021A9AC File Offset: 0x00218BAC
		public virtual int[] GetExtent()
		{
			IntPtr intPtr = vtkRectilinearGridGeometryFilter.vtkRectilinearGridGeometryFilter_GetExtent_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060180E2 RID: 98530
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridGeometryFilter_GetExtent_02(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Get the extent in topological coordinate range (imin,imax, jmin,jmax,
		/// kmin,kmax).
		/// </summary>
		// Token: 0x060180E3 RID: 98531 RVA: 0x0021A9F4 File Offset: 0x00218BF4
		public virtual void GetExtent(IntPtr data)
		{
			vtkRectilinearGridGeometryFilter.vtkRectilinearGridGeometryFilter_GetExtent_02(base.GetCppThis(), data);
		}

		// Token: 0x060180E4 RID: 98532
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGridGeometryFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060180E5 RID: 98533 RVA: 0x0021AA04 File Offset: 0x00218C04
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRectilinearGridGeometryFilter.vtkRectilinearGridGeometryFilter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060180E6 RID: 98534
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGridGeometryFilter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060180E7 RID: 98535 RVA: 0x0021AA24 File Offset: 0x00218C24
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRectilinearGridGeometryFilter.vtkRectilinearGridGeometryFilter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060180E8 RID: 98536
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridGeometryFilter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060180E9 RID: 98537 RVA: 0x0021AA40 File Offset: 0x00218C40
		public override int IsA(string type)
		{
			return vtkRectilinearGridGeometryFilter.vtkRectilinearGridGeometryFilter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060180EA RID: 98538
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridGeometryFilter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060180EB RID: 98539 RVA: 0x0021AA60 File Offset: 0x00218C60
		public new static int IsTypeOf(string type)
		{
			return vtkRectilinearGridGeometryFilter.vtkRectilinearGridGeometryFilter_IsTypeOf_06(type);
		}

		// Token: 0x060180EC RID: 98540
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridGeometryFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060180ED RID: 98541 RVA: 0x0021AA7C File Offset: 0x00218C7C
		public new vtkRectilinearGridGeometryFilter NewInstance()
		{
			vtkRectilinearGridGeometryFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridGeometryFilter.vtkRectilinearGridGeometryFilter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060180EE RID: 98542
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridGeometryFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060180EF RID: 98543 RVA: 0x0021AAD8 File Offset: 0x00218CD8
		public new static vtkRectilinearGridGeometryFilter SafeDownCast(vtkObjectBase o)
		{
			vtkRectilinearGridGeometryFilter vtkRectilinearGridGeometryFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridGeometryFilter.vtkRectilinearGridGeometryFilter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGridGeometryFilter = (vtkRectilinearGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGridGeometryFilter.Register(null);
				}
			}
			return vtkRectilinearGridGeometryFilter;
		}

		// Token: 0x060180F0 RID: 98544
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridGeometryFilter_SetExtent_10(HandleRef pThis, int iMin, int iMax, int jMin, int jMax, int kMin, int kMax);

		/// <summary>
		/// Specify (imin,imax, jmin,jmax, kmin,kmax) indices.
		/// </summary>
		// Token: 0x060180F1 RID: 98545 RVA: 0x0021AB57 File Offset: 0x00218D57
		public void SetExtent(int iMin, int iMax, int jMin, int jMax, int kMin, int kMax)
		{
			vtkRectilinearGridGeometryFilter.vtkRectilinearGridGeometryFilter_SetExtent_10(base.GetCppThis(), iMin, iMax, jMin, jMax, kMin, kMax);
		}

		// Token: 0x060180F2 RID: 98546
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridGeometryFilter_SetExtent_11(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Specify (imin,imax, jmin,jmax, kmin,kmax) indices in array form.
		/// </summary>
		// Token: 0x060180F3 RID: 98547 RVA: 0x0021AB6F File Offset: 0x00218D6F
		public void SetExtent(IntPtr extent)
		{
			vtkRectilinearGridGeometryFilter.vtkRectilinearGridGeometryFilter_SetExtent_11(base.GetCppThis(), extent);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ACC RID: 6860
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGridGeometryFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ACD RID: 6861
		public new static readonly string MRClassNameKey = "class vtkRectilinearGridGeometryFilter";
	}
}
