using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLoopSubdivisionFilter
	/// </summary>
	/// <remarks>
	///    generate a subdivision surface using the Loop Scheme
	///
	/// vtkLoopSubdivisionFilter is an approximating subdivision scheme that
	/// creates four new triangles for each triangle in the mesh. The user can
	/// specify the NumberOfSubdivisions. Loop's subdivision scheme is
	/// described in: Loop, C., "Smooth Subdivision surfaces based on
	/// triangles,", Masters Thesis, University of Utah, August 1987.
	/// For a nice summary of the technique see, Hoppe, H., et. al,
	/// "Piecewise Smooth Surface Reconstruction,:, Proceedings of Siggraph 94
	/// (Orlando, Florida, July 24-29, 1994). In Computer Graphics
	/// Proceedings, Annual Conference Series, 1994, ACM SIGGRAPH,
	/// pp. 295-302.
	/// &lt;P&gt;
	/// The filter only operates on triangles. Users should use the
	/// vtkTriangleFilter to triangulate meshes that contain polygons or
	/// triangle strips.
	/// &lt;P&gt;
	/// The filter approximates point data using the same scheme. New
	/// triangles create at a subdivision step will have the cell data of
	/// their parent cell.
	///
	/// @par Thanks:
	/// This work was supported by PHS Research Grant No. 1 P41 RR13218-01
	/// from the National Center for Research Resources.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkApproximatingSubdivisionFilter
	/// </seealso>
	// Token: 0x02000562 RID: 1378
	public class vtkLoopSubdivisionFilter : vtkApproximatingSubdivisionFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F408 RID: 62472 RVA: 0x00153E0B File Offset: 0x0015200B
		static vtkLoopSubdivisionFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLoopSubdivisionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLoopSubdivisionFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F409 RID: 62473 RVA: 0x00153E33 File Offset: 0x00152033
		public vtkLoopSubdivisionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F40A RID: 62474
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLoopSubdivisionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F40B RID: 62475 RVA: 0x00153E44 File Offset: 0x00152044
		public new static vtkLoopSubdivisionFilter New()
		{
			vtkLoopSubdivisionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLoopSubdivisionFilter.vtkLoopSubdivisionFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLoopSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F40C RID: 62476 RVA: 0x00153E98 File Offset: 0x00152098
		public vtkLoopSubdivisionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLoopSubdivisionFilter.vtkLoopSubdivisionFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F40D RID: 62477 RVA: 0x00153EDC File Offset: 0x001520DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F40E RID: 62478
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLoopSubdivisionFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F40F RID: 62479 RVA: 0x00153EE8 File Offset: 0x001520E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLoopSubdivisionFilter.vtkLoopSubdivisionFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600F410 RID: 62480
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLoopSubdivisionFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F411 RID: 62481 RVA: 0x00153F08 File Offset: 0x00152108
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLoopSubdivisionFilter.vtkLoopSubdivisionFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600F412 RID: 62482
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLoopSubdivisionFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F413 RID: 62483 RVA: 0x00153F24 File Offset: 0x00152124
		public override int IsA(string type)
		{
			return vtkLoopSubdivisionFilter.vtkLoopSubdivisionFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600F414 RID: 62484
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLoopSubdivisionFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F415 RID: 62485 RVA: 0x00153F44 File Offset: 0x00152144
		public new static int IsTypeOf(string type)
		{
			return vtkLoopSubdivisionFilter.vtkLoopSubdivisionFilter_IsTypeOf_04(type);
		}

		// Token: 0x0600F416 RID: 62486
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLoopSubdivisionFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F417 RID: 62487 RVA: 0x00153F60 File Offset: 0x00152160
		public new vtkLoopSubdivisionFilter NewInstance()
		{
			vtkLoopSubdivisionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLoopSubdivisionFilter.vtkLoopSubdivisionFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLoopSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F418 RID: 62488
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLoopSubdivisionFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F419 RID: 62489 RVA: 0x00153FBC File Offset: 0x001521BC
		public new static vtkLoopSubdivisionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkLoopSubdivisionFilter vtkLoopSubdivisionFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLoopSubdivisionFilter.vtkLoopSubdivisionFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLoopSubdivisionFilter = (vtkLoopSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLoopSubdivisionFilter.Register(null);
				}
			}
			return vtkLoopSubdivisionFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011CF RID: 4559
		public new const string MRFullTypeName = "Kitware.VTK.vtkLoopSubdivisionFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011D0 RID: 4560
		public new static readonly string MRClassNameKey = "class vtkLoopSubdivisionFilter";
	}
}
