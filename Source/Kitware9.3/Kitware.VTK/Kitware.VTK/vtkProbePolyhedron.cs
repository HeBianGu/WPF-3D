using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProbePolyhedron
	/// </summary>
	/// <remarks>
	///    probe/interpolate data values in the interior,
	/// exterior or of the surface of a closed, manifold polyhedron
	///
	/// vtkProbePolyhedron is a filter that computes point attributes (e.g.,
	/// scalars, vectors, etc.) at specified point positions. The filter has two
	/// inputs: the Input and Source. The Source geometric structure is passed
	/// through the filter. The point attributes are computed at the Input point
	/// positions by interpolating into the source data. In this filter, the
	/// Source is always a closed, non-self-intersecting, polyhedral mesh. For
	/// example, we can compute data values on a plane (plane specified as Input)
	/// from a triangle mesh (e.g., output of marching cubes).
	///
	/// This filter can be used to resample data from a mesh onto a different
	/// dataset type. For example, a polyhedral mesh (vtkPolyData) can be probed
	/// with a volume (three-dimensional vtkImageData), and then volume rendering
	/// techniques can be used to visualize the results. Another example: a line
	/// or curve can be used to probe a mesh to produce x-y plots along that line or
	/// curve.
	///
	/// @warning
	/// Note that cell data is not interpolated from the source. If you need cell data,
	/// you can always use vtkPointDataToCellData and/or vtkCellDataToPointData in
	/// various combinations.
	///
	/// @warning
	/// Note that the filter interpolates from a mesh to points interior, exterior
	/// or on the surface of the mesh. This process is necessarily an
	/// approximation. Currently the approach of Mean Value Coordinates is used,
	/// but this filter may be extended in the future to use other methods.
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkProbeFilter vtkMeanValueCoordinatesInterpolator vtkPolyhedron
	/// </seealso>
	// Token: 0x020008CD RID: 2253
	public class vtkProbePolyhedron : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601745B RID: 95323 RVA: 0x0020AEBB File Offset: 0x002090BB
		static vtkProbePolyhedron()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProbePolyhedron.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProbePolyhedron"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601745C RID: 95324 RVA: 0x0020AEE3 File Offset: 0x002090E3
		public vtkProbePolyhedron(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601745D RID: 95325
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProbePolyhedron_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiable (i.e., concrete) class.
		/// </summary>
		// Token: 0x0601745E RID: 95326 RVA: 0x0020AEF4 File Offset: 0x002090F4
		public new static vtkProbePolyhedron New()
		{
			vtkProbePolyhedron result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProbePolyhedron.vtkProbePolyhedron_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProbePolyhedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiable (i.e., concrete) class.
		/// </summary>
		// Token: 0x0601745F RID: 95327 RVA: 0x0020AF48 File Offset: 0x00209148
		public vtkProbePolyhedron() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProbePolyhedron.vtkProbePolyhedron_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017460 RID: 95328 RVA: 0x0020AF8C File Offset: 0x0020918C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017461 RID: 95329
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProbePolyhedron_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiable (i.e., concrete) class.
		/// </summary>
		// Token: 0x06017462 RID: 95330 RVA: 0x0020AF98 File Offset: 0x00209198
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProbePolyhedron.vtkProbePolyhedron_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06017463 RID: 95331
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProbePolyhedron_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiable (i.e., concrete) class.
		/// </summary>
		// Token: 0x06017464 RID: 95332 RVA: 0x0020AFB8 File Offset: 0x002091B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProbePolyhedron.vtkProbePolyhedron_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06017465 RID: 95333
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProbePolyhedron_GetProbeCellData_03(HandleRef pThis);

		/// <summary>
		/// Specify whether to probe (and hence produce) cell data. The
		/// interpolated point data of the source will produce the output
		/// cell data (output cells are passed from the input cells). Note
		/// that the probing of the input uses the centers of the cells as
		/// the probe position.
		/// </summary>
		// Token: 0x06017466 RID: 95334 RVA: 0x0020AFD4 File Offset: 0x002091D4
		public virtual int GetProbeCellData()
		{
			return vtkProbePolyhedron.vtkProbePolyhedron_GetProbeCellData_03(base.GetCppThis());
		}

		// Token: 0x06017467 RID: 95335
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProbePolyhedron_GetProbePointData_04(HandleRef pThis);

		/// <summary>
		/// Specify whether to probe (and hence produce) point data. The
		/// interpolated point data of the source will produce the output
		/// point data (output points are passed from the input points).
		/// </summary>
		// Token: 0x06017468 RID: 95336 RVA: 0x0020AFF4 File Offset: 0x002091F4
		public virtual int GetProbePointData()
		{
			return vtkProbePolyhedron.vtkProbePolyhedron_GetProbePointData_04(base.GetCppThis());
		}

		// Token: 0x06017469 RID: 95337
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProbePolyhedron_GetSource_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the point locations used to probe input. Any geometry
		/// can be used.
		/// </summary>
		// Token: 0x0601746A RID: 95338 RVA: 0x0020B014 File Offset: 0x00209214
		public vtkPolyData GetSource()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProbePolyhedron.vtkProbePolyhedron_GetSource_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0601746B RID: 95339
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProbePolyhedron_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiable (i.e., concrete) class.
		/// </summary>
		// Token: 0x0601746C RID: 95340 RVA: 0x0020B084 File Offset: 0x00209284
		public override int IsA(string type)
		{
			return vtkProbePolyhedron.vtkProbePolyhedron_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601746D RID: 95341
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProbePolyhedron_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiable (i.e., concrete) class.
		/// </summary>
		// Token: 0x0601746E RID: 95342 RVA: 0x0020B0A4 File Offset: 0x002092A4
		public new static int IsTypeOf(string type)
		{
			return vtkProbePolyhedron.vtkProbePolyhedron_IsTypeOf_07(type);
		}

		// Token: 0x0601746F RID: 95343
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProbePolyhedron_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiable (i.e., concrete) class.
		/// </summary>
		// Token: 0x06017470 RID: 95344 RVA: 0x0020B0C0 File Offset: 0x002092C0
		public new vtkProbePolyhedron NewInstance()
		{
			vtkProbePolyhedron result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProbePolyhedron.vtkProbePolyhedron_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProbePolyhedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017471 RID: 95345
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbePolyhedron_ProbeCellDataOff_10(HandleRef pThis);

		/// <summary>
		/// Specify whether to probe (and hence produce) cell data. The
		/// interpolated point data of the source will produce the output
		/// cell data (output cells are passed from the input cells). Note
		/// that the probing of the input uses the centers of the cells as
		/// the probe position.
		/// </summary>
		// Token: 0x06017472 RID: 95346 RVA: 0x0020B11A File Offset: 0x0020931A
		public virtual void ProbeCellDataOff()
		{
			vtkProbePolyhedron.vtkProbePolyhedron_ProbeCellDataOff_10(base.GetCppThis());
		}

		// Token: 0x06017473 RID: 95347
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbePolyhedron_ProbeCellDataOn_11(HandleRef pThis);

		/// <summary>
		/// Specify whether to probe (and hence produce) cell data. The
		/// interpolated point data of the source will produce the output
		/// cell data (output cells are passed from the input cells). Note
		/// that the probing of the input uses the centers of the cells as
		/// the probe position.
		/// </summary>
		// Token: 0x06017474 RID: 95348 RVA: 0x0020B129 File Offset: 0x00209329
		public virtual void ProbeCellDataOn()
		{
			vtkProbePolyhedron.vtkProbePolyhedron_ProbeCellDataOn_11(base.GetCppThis());
		}

		// Token: 0x06017475 RID: 95349
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbePolyhedron_ProbePointDataOff_12(HandleRef pThis);

		/// <summary>
		/// Specify whether to probe (and hence produce) point data. The
		/// interpolated point data of the source will produce the output
		/// point data (output points are passed from the input points).
		/// </summary>
		// Token: 0x06017476 RID: 95350 RVA: 0x0020B138 File Offset: 0x00209338
		public virtual void ProbePointDataOff()
		{
			vtkProbePolyhedron.vtkProbePolyhedron_ProbePointDataOff_12(base.GetCppThis());
		}

		// Token: 0x06017477 RID: 95351
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbePolyhedron_ProbePointDataOn_13(HandleRef pThis);

		/// <summary>
		/// Specify whether to probe (and hence produce) point data. The
		/// interpolated point data of the source will produce the output
		/// point data (output points are passed from the input points).
		/// </summary>
		// Token: 0x06017478 RID: 95352 RVA: 0x0020B147 File Offset: 0x00209347
		public virtual void ProbePointDataOn()
		{
			vtkProbePolyhedron.vtkProbePolyhedron_ProbePointDataOn_13(base.GetCppThis());
		}

		// Token: 0x06017479 RID: 95353
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProbePolyhedron_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiable (i.e., concrete) class.
		/// </summary>
		// Token: 0x0601747A RID: 95354 RVA: 0x0020B158 File Offset: 0x00209358
		public new static vtkProbePolyhedron SafeDownCast(vtkObjectBase o)
		{
			vtkProbePolyhedron vtkProbePolyhedron = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProbePolyhedron.vtkProbePolyhedron_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProbePolyhedron = (vtkProbePolyhedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProbePolyhedron.Register(null);
				}
			}
			return vtkProbePolyhedron;
		}

		// Token: 0x0601747B RID: 95355
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbePolyhedron_SetProbeCellData_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to probe (and hence produce) cell data. The
		/// interpolated point data of the source will produce the output
		/// cell data (output cells are passed from the input cells). Note
		/// that the probing of the input uses the centers of the cells as
		/// the probe position.
		/// </summary>
		// Token: 0x0601747C RID: 95356 RVA: 0x0020B1D7 File Offset: 0x002093D7
		public virtual void SetProbeCellData(int _arg)
		{
			vtkProbePolyhedron.vtkProbePolyhedron_SetProbeCellData_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0601747D RID: 95357
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbePolyhedron_SetProbePointData_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to probe (and hence produce) point data. The
		/// interpolated point data of the source will produce the output
		/// point data (output points are passed from the input points).
		/// </summary>
		// Token: 0x0601747E RID: 95358 RVA: 0x0020B1E7 File Offset: 0x002093E7
		public virtual void SetProbePointData(int _arg)
		{
			vtkProbePolyhedron.vtkProbePolyhedron_SetProbePointData_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0601747F RID: 95359
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbePolyhedron_SetSourceConnection_17(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify the point locations used to probe input. Any geometry
		/// can be used. New style. Equivalent to SetInputConnection(1, algOutput).
		/// </summary>
		// Token: 0x06017480 RID: 95360 RVA: 0x0020B1F8 File Offset: 0x002093F8
		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkProbePolyhedron.vtkProbePolyhedron_SetSourceConnection_17(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x06017481 RID: 95361
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbePolyhedron_SetSourceData_18(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Specify the point locations used to probe input. Any geometry
		/// can be used.
		/// </summary>
		// Token: 0x06017482 RID: 95362 RVA: 0x0020B228 File Offset: 0x00209428
		public void SetSourceData(vtkPolyData source)
		{
			vtkProbePolyhedron.vtkProbePolyhedron_SetSourceData_18(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A0D RID: 6669
		public new const string MRFullTypeName = "Kitware.VTK.vtkProbePolyhedron";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A0E RID: 6670
		public new static readonly string MRClassNameKey = "class vtkProbePolyhedron";
	}
}
