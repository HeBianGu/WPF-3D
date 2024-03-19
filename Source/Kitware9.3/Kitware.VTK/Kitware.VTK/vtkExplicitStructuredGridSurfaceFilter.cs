using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExplicitStructuredGridSurfaceFilter
	/// </summary>
	/// <remarks>
	///    Filter which creates a surface (polydata) from an explicit structured grid.
	/// </remarks>
	// Token: 0x0200090A RID: 2314
	public class vtkExplicitStructuredGridSurfaceFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017FF6 RID: 98294 RVA: 0x0021941D File Offset: 0x0021761D
		static vtkExplicitStructuredGridSurfaceFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExplicitStructuredGridSurfaceFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExplicitStructuredGridSurfaceFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017FF7 RID: 98295 RVA: 0x00219445 File Offset: 0x00217645
		public vtkExplicitStructuredGridSurfaceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017FF8 RID: 98296
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGridSurfaceFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017FF9 RID: 98297 RVA: 0x00219454 File Offset: 0x00217654
		public new static vtkExplicitStructuredGridSurfaceFilter New()
		{
			vtkExplicitStructuredGridSurfaceFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGridSurfaceFilter.vtkExplicitStructuredGridSurfaceFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExplicitStructuredGridSurfaceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017FFA RID: 98298 RVA: 0x002194A8 File Offset: 0x002176A8
		public vtkExplicitStructuredGridSurfaceFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExplicitStructuredGridSurfaceFilter.vtkExplicitStructuredGridSurfaceFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017FFB RID: 98299 RVA: 0x002194EC File Offset: 0x002176EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017FFC RID: 98300
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExplicitStructuredGridSurfaceFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017FFD RID: 98301 RVA: 0x002194F8 File Offset: 0x002176F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExplicitStructuredGridSurfaceFilter.vtkExplicitStructuredGridSurfaceFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06017FFE RID: 98302
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExplicitStructuredGridSurfaceFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017FFF RID: 98303 RVA: 0x00219518 File Offset: 0x00217718
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExplicitStructuredGridSurfaceFilter.vtkExplicitStructuredGridSurfaceFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06018000 RID: 98304
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGridSurfaceFilter_GetOriginalCellIdsName_03(HandleRef pThis);

		/// <summary>
		/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
		/// control the name given to the field in which the ids are written into.  If
		/// set to NULL, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
		/// is used, respectively.
		/// </summary>
		// Token: 0x06018001 RID: 98305 RVA: 0x00219534 File Offset: 0x00217734
		public virtual string GetOriginalCellIdsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExplicitStructuredGridSurfaceFilter.vtkExplicitStructuredGridSurfaceFilter_GetOriginalCellIdsName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018002 RID: 98306
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGridSurfaceFilter_GetOriginalPointIdsName_04(HandleRef pThis);

		/// <summary>
		/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
		/// control the name given to the field in which the ids are written into.  If
		/// set to NULL, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
		/// is used, respectively.
		/// </summary>
		// Token: 0x06018003 RID: 98307 RVA: 0x00219570 File Offset: 0x00217770
		public virtual string GetOriginalPointIdsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExplicitStructuredGridSurfaceFilter.vtkExplicitStructuredGridSurfaceFilter_GetOriginalPointIdsName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018004 RID: 98308
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExplicitStructuredGridSurfaceFilter_GetPassThroughCellIds_05(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06018005 RID: 98309 RVA: 0x002195AC File Offset: 0x002177AC
		public virtual int GetPassThroughCellIds()
		{
			return vtkExplicitStructuredGridSurfaceFilter.vtkExplicitStructuredGridSurfaceFilter_GetPassThroughCellIds_05(base.GetCppThis());
		}

		// Token: 0x06018006 RID: 98310
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExplicitStructuredGridSurfaceFilter_GetPassThroughPointIds_06(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06018007 RID: 98311 RVA: 0x002195CC File Offset: 0x002177CC
		public virtual int GetPassThroughPointIds()
		{
			return vtkExplicitStructuredGridSurfaceFilter.vtkExplicitStructuredGridSurfaceFilter_GetPassThroughPointIds_06(base.GetCppThis());
		}

		// Token: 0x06018008 RID: 98312
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExplicitStructuredGridSurfaceFilter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018009 RID: 98313 RVA: 0x002195EC File Offset: 0x002177EC
		public override int IsA(string type)
		{
			return vtkExplicitStructuredGridSurfaceFilter.vtkExplicitStructuredGridSurfaceFilter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601800A RID: 98314
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExplicitStructuredGridSurfaceFilter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601800B RID: 98315 RVA: 0x0021960C File Offset: 0x0021780C
		public new static int IsTypeOf(string type)
		{
			return vtkExplicitStructuredGridSurfaceFilter.vtkExplicitStructuredGridSurfaceFilter_IsTypeOf_08(type);
		}

		// Token: 0x0601800C RID: 98316
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGridSurfaceFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601800D RID: 98317 RVA: 0x00219628 File Offset: 0x00217828
		public new vtkExplicitStructuredGridSurfaceFilter NewInstance()
		{
			vtkExplicitStructuredGridSurfaceFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGridSurfaceFilter.vtkExplicitStructuredGridSurfaceFilter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExplicitStructuredGridSurfaceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601800E RID: 98318
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGridSurfaceFilter_PassThroughCellIdsOff_11(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x0601800F RID: 98319 RVA: 0x00219682 File Offset: 0x00217882
		public virtual void PassThroughCellIdsOff()
		{
			vtkExplicitStructuredGridSurfaceFilter.vtkExplicitStructuredGridSurfaceFilter_PassThroughCellIdsOff_11(base.GetCppThis());
		}

		// Token: 0x06018010 RID: 98320
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGridSurfaceFilter_PassThroughCellIdsOn_12(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06018011 RID: 98321 RVA: 0x00219691 File Offset: 0x00217891
		public virtual void PassThroughCellIdsOn()
		{
			vtkExplicitStructuredGridSurfaceFilter.vtkExplicitStructuredGridSurfaceFilter_PassThroughCellIdsOn_12(base.GetCppThis());
		}

		// Token: 0x06018012 RID: 98322
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGridSurfaceFilter_PassThroughPointIdsOff_13(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06018013 RID: 98323 RVA: 0x002196A0 File Offset: 0x002178A0
		public virtual void PassThroughPointIdsOff()
		{
			vtkExplicitStructuredGridSurfaceFilter.vtkExplicitStructuredGridSurfaceFilter_PassThroughPointIdsOff_13(base.GetCppThis());
		}

		// Token: 0x06018014 RID: 98324
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGridSurfaceFilter_PassThroughPointIdsOn_14(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06018015 RID: 98325 RVA: 0x002196AF File Offset: 0x002178AF
		public virtual void PassThroughPointIdsOn()
		{
			vtkExplicitStructuredGridSurfaceFilter.vtkExplicitStructuredGridSurfaceFilter_PassThroughPointIdsOn_14(base.GetCppThis());
		}

		// Token: 0x06018016 RID: 98326
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGridSurfaceFilter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018017 RID: 98327 RVA: 0x002196C0 File Offset: 0x002178C0
		public new static vtkExplicitStructuredGridSurfaceFilter SafeDownCast(vtkObjectBase o)
		{
			vtkExplicitStructuredGridSurfaceFilter vtkExplicitStructuredGridSurfaceFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGridSurfaceFilter.vtkExplicitStructuredGridSurfaceFilter_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExplicitStructuredGridSurfaceFilter = (vtkExplicitStructuredGridSurfaceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExplicitStructuredGridSurfaceFilter.Register(null);
				}
			}
			return vtkExplicitStructuredGridSurfaceFilter;
		}

		// Token: 0x06018018 RID: 98328
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGridSurfaceFilter_SetOriginalCellIdsName_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
		/// control the name given to the field in which the ids are written into.  If
		/// set to NULL, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
		/// is used, respectively.
		/// </summary>
		// Token: 0x06018019 RID: 98329 RVA: 0x0021973F File Offset: 0x0021793F
		public virtual void SetOriginalCellIdsName(string _arg)
		{
			vtkExplicitStructuredGridSurfaceFilter.vtkExplicitStructuredGridSurfaceFilter_SetOriginalCellIdsName_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0601801A RID: 98330
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGridSurfaceFilter_SetOriginalPointIdsName_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
		/// control the name given to the field in which the ids are written into.  If
		/// set to NULL, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
		/// is used, respectively.
		/// </summary>
		// Token: 0x0601801B RID: 98331 RVA: 0x0021974F File Offset: 0x0021794F
		public virtual void SetOriginalPointIdsName(string _arg)
		{
			vtkExplicitStructuredGridSurfaceFilter.vtkExplicitStructuredGridSurfaceFilter_SetOriginalPointIdsName_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0601801C RID: 98332
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGridSurfaceFilter_SetPassThroughCellIds_18(HandleRef pThis, int _arg);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x0601801D RID: 98333 RVA: 0x0021975F File Offset: 0x0021795F
		public virtual void SetPassThroughCellIds(int _arg)
		{
			vtkExplicitStructuredGridSurfaceFilter.vtkExplicitStructuredGridSurfaceFilter_SetPassThroughCellIds_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0601801E RID: 98334
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGridSurfaceFilter_SetPassThroughPointIds_19(HandleRef pThis, int _arg);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x0601801F RID: 98335 RVA: 0x0021976F File Offset: 0x0021796F
		public virtual void SetPassThroughPointIds(int _arg)
		{
			vtkExplicitStructuredGridSurfaceFilter.vtkExplicitStructuredGridSurfaceFilter_SetPassThroughPointIds_19(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ABE RID: 6846
		public new const string MRFullTypeName = "Kitware.VTK.vtkExplicitStructuredGridSurfaceFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ABF RID: 6847
		public new static readonly string MRClassNameKey = "class vtkExplicitStructuredGridSurfaceFilter";
	}
}
