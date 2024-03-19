using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataSetTriangleFilter
	/// </summary>
	/// <remarks>
	///    triangulate any type of dataset
	///
	/// vtkDataSetTriangleFilter generates n-dimensional simplices from any input
	/// dataset. That is, 3D cells are converted to tetrahedral meshes, 2D cells
	/// to triangles, and so on. The triangulation is guaranteed to be compatible.
	///
	/// This filter uses simple 1D and 2D triangulation techniques for cells
	/// that are of topological dimension 2 or less. For 3D cells--due to the
	/// issue of face compatibility across quadrilateral faces (which way to
	/// orient the diagonal?)--a fancier ordered Delaunay triangulation is used.
	/// This approach produces templates on the fly for triangulating the
	/// cells. The templates are then used to do the actual triangulation.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkOrderedTriangulator vtkTriangleFilter
	/// </seealso>
	// Token: 0x0200088E RID: 2190
	public class vtkDataSetTriangleFilter : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016BF4 RID: 93172 RVA: 0x001FFC0F File Offset: 0x001FDE0F
		static vtkDataSetTriangleFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetTriangleFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetTriangleFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016BF5 RID: 93173 RVA: 0x001FFC37 File Offset: 0x001FDE37
		public vtkDataSetTriangleFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016BF6 RID: 93174
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetTriangleFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BF7 RID: 93175 RVA: 0x001FFC48 File Offset: 0x001FDE48
		public new static vtkDataSetTriangleFilter New()
		{
			vtkDataSetTriangleFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetTriangleFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BF8 RID: 93176 RVA: 0x001FFC9C File Offset: 0x001FDE9C
		public vtkDataSetTriangleFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016BF9 RID: 93177 RVA: 0x001FFCE0 File Offset: 0x001FDEE0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016BFA RID: 93178
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetTriangleFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BFB RID: 93179 RVA: 0x001FFCEC File Offset: 0x001FDEEC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016BFC RID: 93180
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetTriangleFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BFD RID: 93181 RVA: 0x001FFD0C File Offset: 0x001FDF0C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06016BFE RID: 93182
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetTriangleFilter_GetTetrahedraOnly_03(HandleRef pThis);

		/// <summary>
		/// When On this filter will cull all 1D and 2D cells from the output.
		/// The default is Off.
		/// </summary>
		// Token: 0x06016BFF RID: 93183 RVA: 0x001FFD28 File Offset: 0x001FDF28
		public virtual int GetTetrahedraOnly()
		{
			return vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_GetTetrahedraOnly_03(base.GetCppThis());
		}

		// Token: 0x06016C00 RID: 93184
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetTriangleFilter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C01 RID: 93185 RVA: 0x001FFD48 File Offset: 0x001FDF48
		public override int IsA(string type)
		{
			return vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06016C02 RID: 93186
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetTriangleFilter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C03 RID: 93187 RVA: 0x001FFD68 File Offset: 0x001FDF68
		public new static int IsTypeOf(string type)
		{
			return vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_IsTypeOf_05(type);
		}

		// Token: 0x06016C04 RID: 93188
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetTriangleFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C05 RID: 93189 RVA: 0x001FFD84 File Offset: 0x001FDF84
		public new vtkDataSetTriangleFilter NewInstance()
		{
			vtkDataSetTriangleFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetTriangleFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016C06 RID: 93190
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetTriangleFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C07 RID: 93191 RVA: 0x001FFDE0 File Offset: 0x001FDFE0
		public new static vtkDataSetTriangleFilter SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetTriangleFilter vtkDataSetTriangleFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetTriangleFilter = (vtkDataSetTriangleFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetTriangleFilter.Register(null);
				}
			}
			return vtkDataSetTriangleFilter;
		}

		// Token: 0x06016C08 RID: 93192
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetTriangleFilter_SetTetrahedraOnly_09(HandleRef pThis, int _arg);

		/// <summary>
		/// When On this filter will cull all 1D and 2D cells from the output.
		/// The default is Off.
		/// </summary>
		// Token: 0x06016C09 RID: 93193 RVA: 0x001FFE5F File Offset: 0x001FE05F
		public virtual void SetTetrahedraOnly(int _arg)
		{
			vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_SetTetrahedraOnly_09(base.GetCppThis(), _arg);
		}

		// Token: 0x06016C0A RID: 93194
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetTriangleFilter_TetrahedraOnlyOff_10(HandleRef pThis);

		/// <summary>
		/// When On this filter will cull all 1D and 2D cells from the output.
		/// The default is Off.
		/// </summary>
		// Token: 0x06016C0B RID: 93195 RVA: 0x001FFE6F File Offset: 0x001FE06F
		public virtual void TetrahedraOnlyOff()
		{
			vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_TetrahedraOnlyOff_10(base.GetCppThis());
		}

		// Token: 0x06016C0C RID: 93196
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetTriangleFilter_TetrahedraOnlyOn_11(HandleRef pThis);

		/// <summary>
		/// When On this filter will cull all 1D and 2D cells from the output.
		/// The default is Off.
		/// </summary>
		// Token: 0x06016C0D RID: 93197 RVA: 0x001FFE7E File Offset: 0x001FE07E
		public virtual void TetrahedraOnlyOn()
		{
			vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_TetrahedraOnlyOn_11(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400197D RID: 6525
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetTriangleFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400197E RID: 6526
		public new static readonly string MRClassNameKey = "class vtkDataSetTriangleFilter";
	}
}
