using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStructuredGridGeometryFilter
	/// </summary>
	/// <remarks>
	///    extract geometry for structured grid
	///
	/// vtkStructuredGridGeometryFilter is a filter that extracts geometry from a
	/// structured grid. By specifying appropriate i-j-k indices, it is possible
	/// to extract a point, a curve, a surface, or a "volume". Depending upon the
	/// type of data, the curve and surface may be curved or planar. (The volume
	/// is actually a (n x m x o) region of points.)
	///
	/// The extent specification is zero-offset. That is, the first k-plane in
	/// a 50x50x50 structured grid is given by (0,49, 0,49, 0,0).
	///
	/// The output of this filter is affected by the structured grid blanking.
	/// If blanking is on, and a blanking array defined, then those cells
	/// attached to blanked points are not output. (Blanking is a property of
	/// the input vtkStructuredGrid.)
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
	/// vtkGeometryFilter vtkExtractGrid vtkStructuredGrid
	/// </seealso>
	// Token: 0x02000915 RID: 2325
	public class vtkStructuredGridGeometryFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018174 RID: 98676 RVA: 0x0021B790 File Offset: 0x00219990
		static vtkStructuredGridGeometryFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredGridGeometryFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGridGeometryFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018175 RID: 98677 RVA: 0x0021B7B8 File Offset: 0x002199B8
		public vtkStructuredGridGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018176 RID: 98678
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018177 RID: 98679 RVA: 0x0021B7C8 File Offset: 0x002199C8
		public new static vtkStructuredGridGeometryFilter New()
		{
			vtkStructuredGridGeometryFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018178 RID: 98680 RVA: 0x0021B81C File Offset: 0x00219A1C
		public vtkStructuredGridGeometryFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018179 RID: 98681 RVA: 0x0021B860 File Offset: 0x00219A60
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601817A RID: 98682
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridGeometryFilter_GetExtent_01(HandleRef pThis);

		/// <summary>
		/// Get the extent in topological coordinate range (imin,imax, jmin,jmax,
		/// kmin,kmax).
		/// </summary>
		// Token: 0x0601817B RID: 98683 RVA: 0x0021B86C File Offset: 0x00219A6C
		public virtual int[] GetExtent()
		{
			IntPtr intPtr = vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_GetExtent_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601817C RID: 98684
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridGeometryFilter_GetExtent_02(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Get the extent in topological coordinate range (imin,imax, jmin,jmax,
		/// kmin,kmax).
		/// </summary>
		// Token: 0x0601817D RID: 98685 RVA: 0x0021B8B4 File Offset: 0x00219AB4
		public virtual void GetExtent(IntPtr data)
		{
			vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_GetExtent_02(base.GetCppThis(), data);
		}

		// Token: 0x0601817E RID: 98686
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGridGeometryFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601817F RID: 98687 RVA: 0x0021B8C4 File Offset: 0x00219AC4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06018180 RID: 98688
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGridGeometryFilter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018181 RID: 98689 RVA: 0x0021B8E4 File Offset: 0x00219AE4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06018182 RID: 98690
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridGeometryFilter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018183 RID: 98691 RVA: 0x0021B900 File Offset: 0x00219B00
		public override int IsA(string type)
		{
			return vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06018184 RID: 98692
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridGeometryFilter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018185 RID: 98693 RVA: 0x0021B920 File Offset: 0x00219B20
		public new static int IsTypeOf(string type)
		{
			return vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_IsTypeOf_06(type);
		}

		// Token: 0x06018186 RID: 98694
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridGeometryFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018187 RID: 98695 RVA: 0x0021B93C File Offset: 0x00219B3C
		public new vtkStructuredGridGeometryFilter NewInstance()
		{
			vtkStructuredGridGeometryFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018188 RID: 98696
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridGeometryFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018189 RID: 98697 RVA: 0x0021B998 File Offset: 0x00219B98
		public new static vtkStructuredGridGeometryFilter SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredGridGeometryFilter vtkStructuredGridGeometryFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGridGeometryFilter = (vtkStructuredGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGridGeometryFilter.Register(null);
				}
			}
			return vtkStructuredGridGeometryFilter;
		}

		// Token: 0x0601818A RID: 98698
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridGeometryFilter_SetExtent_10(HandleRef pThis, int iMin, int iMax, int jMin, int jMax, int kMin, int kMax);

		/// <summary>
		/// Specify (imin,imax, jmin,jmax, kmin,kmax) indices.
		/// </summary>
		// Token: 0x0601818B RID: 98699 RVA: 0x0021BA17 File Offset: 0x00219C17
		public void SetExtent(int iMin, int iMax, int jMin, int jMax, int kMin, int kMax)
		{
			vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_SetExtent_10(base.GetCppThis(), iMin, iMax, jMin, jMax, kMin, kMax);
		}

		// Token: 0x0601818C RID: 98700
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridGeometryFilter_SetExtent_11(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Specify (imin,imax, jmin,jmax, kmin,kmax) indices in array form.
		/// </summary>
		// Token: 0x0601818D RID: 98701 RVA: 0x0021BA2F File Offset: 0x00219C2F
		public void SetExtent(IntPtr extent)
		{
			vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_SetExtent_11(base.GetCppThis(), extent);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AD4 RID: 6868
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGridGeometryFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AD5 RID: 6869
		public new static readonly string MRClassNameKey = "class vtkStructuredGridGeometryFilter";
	}
}
