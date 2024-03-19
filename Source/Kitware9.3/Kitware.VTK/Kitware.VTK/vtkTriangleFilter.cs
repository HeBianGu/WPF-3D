using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTriangleFilter
	/// </summary>
	/// <remarks>
	///    convert input polygons and strips to triangles
	///
	/// vtkTriangleFilter generates triangles from input polygons and triangle
	/// strips.  It also generates line segments from polylines unless PassLines
	/// is off, and generates individual vertex cells from vtkVertex point lists
	/// unless PassVerts is off.
	/// </remarks>
	// Token: 0x020009B8 RID: 2488
	public class vtkTriangleFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019FE1 RID: 106465 RVA: 0x00240B3D File Offset: 0x0023ED3D
		static vtkTriangleFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTriangleFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTriangleFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019FE2 RID: 106466 RVA: 0x00240B65 File Offset: 0x0023ED65
		public vtkTriangleFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019FE3 RID: 106467
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangleFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019FE4 RID: 106468 RVA: 0x00240B74 File Offset: 0x0023ED74
		public new static vtkTriangleFilter New()
		{
			vtkTriangleFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangleFilter.vtkTriangleFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriangleFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019FE5 RID: 106469 RVA: 0x00240BC8 File Offset: 0x0023EDC8
		public vtkTriangleFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTriangleFilter.vtkTriangleFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019FE6 RID: 106470 RVA: 0x00240C0C File Offset: 0x0023EE0C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019FE7 RID: 106471
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTriangleFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019FE8 RID: 106472 RVA: 0x00240C18 File Offset: 0x0023EE18
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTriangleFilter.vtkTriangleFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06019FE9 RID: 106473
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTriangleFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019FEA RID: 106474 RVA: 0x00240C38 File Offset: 0x0023EE38
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTriangleFilter.vtkTriangleFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06019FEB RID: 106475
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangleFilter_GetPassLines_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off passing lines through filter (default: on).
		/// If this is on, then the input polylines will be broken
		/// into line segments.  If it is off, then the input lines
		/// will be ignored and the output will have no lines.
		/// </summary>
		// Token: 0x06019FEC RID: 106476 RVA: 0x00240C54 File Offset: 0x0023EE54
		public virtual int GetPassLines()
		{
			return vtkTriangleFilter.vtkTriangleFilter_GetPassLines_03(base.GetCppThis());
		}

		// Token: 0x06019FED RID: 106477
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangleFilter_GetPassVerts_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off passing vertices through filter (default: on).
		/// If this is on, then the input vertex cells will be broken
		/// into individual vertex cells (one point per cell).  If it
		/// is off, the input vertex cells will be ignored.
		/// </summary>
		// Token: 0x06019FEE RID: 106478 RVA: 0x00240C74 File Offset: 0x0023EE74
		public virtual int GetPassVerts()
		{
			return vtkTriangleFilter.vtkTriangleFilter_GetPassVerts_04(base.GetCppThis());
		}

		// Token: 0x06019FEF RID: 106479
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTriangleFilter_GetTolerance_05(HandleRef pThis);

		/// <summary>
		/// Optionally specify the polygon triangulation tolerance to use.  This
		/// simply passes the tolerance to the internal vtkPolygon::Tolerance used
		/// for triangulation of polygons.  This is for advanced usage, and
		/// generally does not need to be set unless tessellation of n-sided
		/// polygons with n&gt;4 is required, and special accuracy requirements are
		/// needed.  Note that by default if a value &lt;=0 is specified, then the
		/// default vtkPolygon::Tolerance is used.
		/// </summary>
		// Token: 0x06019FF0 RID: 106480 RVA: 0x00240C94 File Offset: 0x0023EE94
		public virtual double GetTolerance()
		{
			return vtkTriangleFilter.vtkTriangleFilter_GetTolerance_05(base.GetCppThis());
		}

		// Token: 0x06019FF1 RID: 106481
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangleFilter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019FF2 RID: 106482 RVA: 0x00240CB4 File Offset: 0x0023EEB4
		public override int IsA(string type)
		{
			return vtkTriangleFilter.vtkTriangleFilter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06019FF3 RID: 106483
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangleFilter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019FF4 RID: 106484 RVA: 0x00240CD4 File Offset: 0x0023EED4
		public new static int IsTypeOf(string type)
		{
			return vtkTriangleFilter.vtkTriangleFilter_IsTypeOf_07(type);
		}

		// Token: 0x06019FF5 RID: 106485
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangleFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019FF6 RID: 106486 RVA: 0x00240CF0 File Offset: 0x0023EEF0
		public new vtkTriangleFilter NewInstance()
		{
			vtkTriangleFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangleFilter.vtkTriangleFilter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriangleFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019FF7 RID: 106487
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangleFilter_PassLinesOff_10(HandleRef pThis);

		/// <summary>
		/// Turn on/off passing lines through filter (default: on).
		/// If this is on, then the input polylines will be broken
		/// into line segments.  If it is off, then the input lines
		/// will be ignored and the output will have no lines.
		/// </summary>
		// Token: 0x06019FF8 RID: 106488 RVA: 0x00240D4A File Offset: 0x0023EF4A
		public virtual void PassLinesOff()
		{
			vtkTriangleFilter.vtkTriangleFilter_PassLinesOff_10(base.GetCppThis());
		}

		// Token: 0x06019FF9 RID: 106489
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangleFilter_PassLinesOn_11(HandleRef pThis);

		/// <summary>
		/// Turn on/off passing lines through filter (default: on).
		/// If this is on, then the input polylines will be broken
		/// into line segments.  If it is off, then the input lines
		/// will be ignored and the output will have no lines.
		/// </summary>
		// Token: 0x06019FFA RID: 106490 RVA: 0x00240D59 File Offset: 0x0023EF59
		public virtual void PassLinesOn()
		{
			vtkTriangleFilter.vtkTriangleFilter_PassLinesOn_11(base.GetCppThis());
		}

		// Token: 0x06019FFB RID: 106491
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangleFilter_PassVertsOff_12(HandleRef pThis);

		/// <summary>
		/// Turn on/off passing vertices through filter (default: on).
		/// If this is on, then the input vertex cells will be broken
		/// into individual vertex cells (one point per cell).  If it
		/// is off, the input vertex cells will be ignored.
		/// </summary>
		// Token: 0x06019FFC RID: 106492 RVA: 0x00240D68 File Offset: 0x0023EF68
		public virtual void PassVertsOff()
		{
			vtkTriangleFilter.vtkTriangleFilter_PassVertsOff_12(base.GetCppThis());
		}

		// Token: 0x06019FFD RID: 106493
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangleFilter_PassVertsOn_13(HandleRef pThis);

		/// <summary>
		/// Turn on/off passing vertices through filter (default: on).
		/// If this is on, then the input vertex cells will be broken
		/// into individual vertex cells (one point per cell).  If it
		/// is off, the input vertex cells will be ignored.
		/// </summary>
		// Token: 0x06019FFE RID: 106494 RVA: 0x00240D77 File Offset: 0x0023EF77
		public virtual void PassVertsOn()
		{
			vtkTriangleFilter.vtkTriangleFilter_PassVertsOn_13(base.GetCppThis());
		}

		// Token: 0x06019FFF RID: 106495
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangleFilter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A000 RID: 106496 RVA: 0x00240D88 File Offset: 0x0023EF88
		public new static vtkTriangleFilter SafeDownCast(vtkObjectBase o)
		{
			vtkTriangleFilter vtkTriangleFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangleFilter.vtkTriangleFilter_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTriangleFilter = (vtkTriangleFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTriangleFilter.Register(null);
				}
			}
			return vtkTriangleFilter;
		}

		// Token: 0x0601A001 RID: 106497
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangleFilter_SetPassLines_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off passing lines through filter (default: on).
		/// If this is on, then the input polylines will be broken
		/// into line segments.  If it is off, then the input lines
		/// will be ignored and the output will have no lines.
		/// </summary>
		// Token: 0x0601A002 RID: 106498 RVA: 0x00240E07 File Offset: 0x0023F007
		public virtual void SetPassLines(int _arg)
		{
			vtkTriangleFilter.vtkTriangleFilter_SetPassLines_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A003 RID: 106499
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangleFilter_SetPassVerts_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off passing vertices through filter (default: on).
		/// If this is on, then the input vertex cells will be broken
		/// into individual vertex cells (one point per cell).  If it
		/// is off, the input vertex cells will be ignored.
		/// </summary>
		// Token: 0x0601A004 RID: 106500 RVA: 0x00240E17 File Offset: 0x0023F017
		public virtual void SetPassVerts(int _arg)
		{
			vtkTriangleFilter.vtkTriangleFilter_SetPassVerts_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A005 RID: 106501
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangleFilter_SetTolerance_17(HandleRef pThis, double _arg);

		/// <summary>
		/// Optionally specify the polygon triangulation tolerance to use.  This
		/// simply passes the tolerance to the internal vtkPolygon::Tolerance used
		/// for triangulation of polygons.  This is for advanced usage, and
		/// generally does not need to be set unless tessellation of n-sided
		/// polygons with n&gt;4 is required, and special accuracy requirements are
		/// needed.  Note that by default if a value &lt;=0 is specified, then the
		/// default vtkPolygon::Tolerance is used.
		/// </summary>
		// Token: 0x0601A006 RID: 106502 RVA: 0x00240E27 File Offset: 0x0023F027
		public virtual void SetTolerance(double _arg)
		{
			vtkTriangleFilter.vtkTriangleFilter_SetTolerance_17(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C36 RID: 7222
		public new const string MRFullTypeName = "Kitware.VTK.vtkTriangleFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C37 RID: 7223
		public new static readonly string MRClassNameKey = "class vtkTriangleFilter";
	}
}
