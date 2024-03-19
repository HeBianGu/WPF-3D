using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkButterflySubdivisionFilter
	/// </summary>
	/// <remarks>
	///    generate a subdivision surface using the Butterfly Scheme
	///
	/// vtkButterflySubdivisionFilter is an interpolating subdivision scheme
	/// that creates four new triangles for each triangle in the mesh. The
	/// user can specify the NumberOfSubdivisions. This filter implements the
	/// 8-point butterfly scheme described in: Zorin, D., Schroder, P., and
	/// Sweldens, W., "Interpolating Subdivisions for Meshes with Arbitrary
	/// Topology," Computer Graphics Proceedings, Annual Conference Series,
	/// 1996, ACM SIGGRAPH, pp.189-192. This scheme improves previous
	/// butterfly subdivisions with special treatment of vertices with valence
	/// other than 6.
	///
	/// Currently, the filter only operates on triangles. Users should use the
	/// vtkTriangleFilter to triangulate meshes that contain polygons or
	/// triangle strips.
	///
	/// The filter interpolates point data using the same scheme. New
	/// triangles created at a subdivision step will have the cell data of
	/// their parent cell.
	///
	/// @par Thanks:
	/// This work was supported by PHS Research Grant No. 1 P41 RR13218-01
	/// from the National Center for Research Resources.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInterpolatingSubdivisionFilter vtkLinearSubdivisionFilter
	/// </seealso>
	// Token: 0x0200054A RID: 1354
	public class vtkButterflySubdivisionFilter : vtkInterpolatingSubdivisionFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F115 RID: 61717 RVA: 0x0014FDD7 File Offset: 0x0014DFD7
		static vtkButterflySubdivisionFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkButterflySubdivisionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkButterflySubdivisionFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F116 RID: 61718 RVA: 0x0014FDFF File Offset: 0x0014DFFF
		public vtkButterflySubdivisionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F117 RID: 61719
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkButterflySubdivisionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F118 RID: 61720 RVA: 0x0014FE10 File Offset: 0x0014E010
		public new static vtkButterflySubdivisionFilter New()
		{
			vtkButterflySubdivisionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkButterflySubdivisionFilter.vtkButterflySubdivisionFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkButterflySubdivisionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F119 RID: 61721 RVA: 0x0014FE64 File Offset: 0x0014E064
		public vtkButterflySubdivisionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkButterflySubdivisionFilter.vtkButterflySubdivisionFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F11A RID: 61722 RVA: 0x0014FEA8 File Offset: 0x0014E0A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F11B RID: 61723
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkButterflySubdivisionFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F11C RID: 61724 RVA: 0x0014FEB4 File Offset: 0x0014E0B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkButterflySubdivisionFilter.vtkButterflySubdivisionFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600F11D RID: 61725
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkButterflySubdivisionFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F11E RID: 61726 RVA: 0x0014FED4 File Offset: 0x0014E0D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkButterflySubdivisionFilter.vtkButterflySubdivisionFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600F11F RID: 61727
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkButterflySubdivisionFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F120 RID: 61728 RVA: 0x0014FEF0 File Offset: 0x0014E0F0
		public override int IsA(string type)
		{
			return vtkButterflySubdivisionFilter.vtkButterflySubdivisionFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600F121 RID: 61729
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkButterflySubdivisionFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F122 RID: 61730 RVA: 0x0014FF10 File Offset: 0x0014E110
		public new static int IsTypeOf(string type)
		{
			return vtkButterflySubdivisionFilter.vtkButterflySubdivisionFilter_IsTypeOf_04(type);
		}

		// Token: 0x0600F123 RID: 61731
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkButterflySubdivisionFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F124 RID: 61732 RVA: 0x0014FF2C File Offset: 0x0014E12C
		public new vtkButterflySubdivisionFilter NewInstance()
		{
			vtkButterflySubdivisionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkButterflySubdivisionFilter.vtkButterflySubdivisionFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkButterflySubdivisionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F125 RID: 61733
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkButterflySubdivisionFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F126 RID: 61734 RVA: 0x0014FF88 File Offset: 0x0014E188
		public new static vtkButterflySubdivisionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkButterflySubdivisionFilter vtkButterflySubdivisionFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkButterflySubdivisionFilter.vtkButterflySubdivisionFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkButterflySubdivisionFilter = (vtkButterflySubdivisionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkButterflySubdivisionFilter.Register(null);
				}
			}
			return vtkButterflySubdivisionFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400118C RID: 4492
		public new const string MRFullTypeName = "Kitware.VTK.vtkButterflySubdivisionFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400118D RID: 4493
		public new static readonly string MRClassNameKey = "class vtkButterflySubdivisionFilter";
	}
}
