using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkQuantizePolyDataPoints
	/// </summary>
	/// <remarks>
	///    quantizes x,y,z coordinates of points
	///
	/// vtkQuantizePolyDataPoints is a subclass of vtkCleanPolyData and
	/// inherits the functionality of vtkCleanPolyData with the addition that
	/// it quantizes the point coordinates before inserting into the point list.
	/// The user should set QFactor to a positive value (0.25 by default) and all
	/// {x,y,z} coordinates will be quantized to that grain size.
	///
	/// A tolerance of zero is expected, though positive values may be used, the
	/// quantization will take place before the tolerance is applied.
	///
	/// @warning
	/// Merging points can alter topology, including introducing non-manifold
	/// forms. Handling of degenerate cells is controlled by switches in
	/// vtkCleanPolyData.
	///
	/// @warning
	/// If you wish to operate on a set of coordinates that has no cells, you must
	/// add a vtkPolyVertex cell with all of the points to the PolyData
	/// (or use a vtkVertexGlyphFilter) before using the vtkCleanPolyData filter.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCleanPolyData
	/// </seealso>
	// Token: 0x020008D2 RID: 2258
	public class vtkQuantizePolyDataPoints : vtkCleanPolyData
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601751D RID: 95517 RVA: 0x0020BF1D File Offset: 0x0020A11D
		static vtkQuantizePolyDataPoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuantizePolyDataPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuantizePolyDataPoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601751E RID: 95518 RVA: 0x0020BF45 File Offset: 0x0020A145
		public vtkQuantizePolyDataPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601751F RID: 95519
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuantizePolyDataPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017520 RID: 95520 RVA: 0x0020BF54 File Offset: 0x0020A154
		public new static vtkQuantizePolyDataPoints New()
		{
			vtkQuantizePolyDataPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuantizePolyDataPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017521 RID: 95521 RVA: 0x0020BFA8 File Offset: 0x0020A1A8
		public vtkQuantizePolyDataPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017522 RID: 95522 RVA: 0x0020BFEC File Offset: 0x0020A1EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017523 RID: 95523
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuantizePolyDataPoints_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017524 RID: 95524 RVA: 0x0020BFF8 File Offset: 0x0020A1F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06017525 RID: 95525
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuantizePolyDataPoints_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017526 RID: 95526 RVA: 0x0020C018 File Offset: 0x0020A218
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06017527 RID: 95527
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuantizePolyDataPoints_GetQFactor_03(HandleRef pThis);

		/// <summary>
		/// Specify quantization grain size. Default is 0.25
		/// </summary>
		// Token: 0x06017528 RID: 95528 RVA: 0x0020C034 File Offset: 0x0020A234
		public virtual double GetQFactor()
		{
			return vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_GetQFactor_03(base.GetCppThis());
		}

		// Token: 0x06017529 RID: 95529
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuantizePolyDataPoints_GetQFactorMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Specify quantization grain size. Default is 0.25
		/// </summary>
		// Token: 0x0601752A RID: 95530 RVA: 0x0020C054 File Offset: 0x0020A254
		public virtual double GetQFactorMaxValue()
		{
			return vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_GetQFactorMaxValue_04(base.GetCppThis());
		}

		// Token: 0x0601752B RID: 95531
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuantizePolyDataPoints_GetQFactorMinValue_05(HandleRef pThis);

		/// <summary>
		/// Specify quantization grain size. Default is 0.25
		/// </summary>
		// Token: 0x0601752C RID: 95532 RVA: 0x0020C074 File Offset: 0x0020A274
		public virtual double GetQFactorMinValue()
		{
			return vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_GetQFactorMinValue_05(base.GetCppThis());
		}

		// Token: 0x0601752D RID: 95533
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuantizePolyDataPoints_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601752E RID: 95534 RVA: 0x0020C094 File Offset: 0x0020A294
		public override int IsA(string type)
		{
			return vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601752F RID: 95535
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuantizePolyDataPoints_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017530 RID: 95536 RVA: 0x0020C0B4 File Offset: 0x0020A2B4
		public new static int IsTypeOf(string type)
		{
			return vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_IsTypeOf_07(type);
		}

		// Token: 0x06017531 RID: 95537
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuantizePolyDataPoints_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017532 RID: 95538 RVA: 0x0020C0D0 File Offset: 0x0020A2D0
		public new vtkQuantizePolyDataPoints NewInstance()
		{
			vtkQuantizePolyDataPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuantizePolyDataPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017533 RID: 95539
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuantizePolyDataPoints_OperateOnBounds_10(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// Perform quantization on bounds
		/// </summary>
		// Token: 0x06017534 RID: 95540 RVA: 0x0020C12A File Offset: 0x0020A32A
		public override void OperateOnBounds(IntPtr arg0, IntPtr arg1)
		{
			vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_OperateOnBounds_10(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x06017535 RID: 95541
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuantizePolyDataPoints_OperateOnPoint_11(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// Perform quantization on a point
		/// </summary>
		// Token: 0x06017536 RID: 95542 RVA: 0x0020C13B File Offset: 0x0020A33B
		public override void OperateOnPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_OperateOnPoint_11(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x06017537 RID: 95543
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuantizePolyDataPoints_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017538 RID: 95544 RVA: 0x0020C14C File Offset: 0x0020A34C
		public new static vtkQuantizePolyDataPoints SafeDownCast(vtkObjectBase o)
		{
			vtkQuantizePolyDataPoints vtkQuantizePolyDataPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuantizePolyDataPoints = (vtkQuantizePolyDataPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuantizePolyDataPoints.Register(null);
				}
			}
			return vtkQuantizePolyDataPoints;
		}

		// Token: 0x06017539 RID: 95545
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuantizePolyDataPoints_SetQFactor_13(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify quantization grain size. Default is 0.25
		/// </summary>
		// Token: 0x0601753A RID: 95546 RVA: 0x0020C1CB File Offset: 0x0020A3CB
		public virtual void SetQFactor(double _arg)
		{
			vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_SetQFactor_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A17 RID: 6679
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuantizePolyDataPoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A18 RID: 6680
		public new static readonly string MRClassNameKey = "class vtkQuantizePolyDataPoints";
	}
}
