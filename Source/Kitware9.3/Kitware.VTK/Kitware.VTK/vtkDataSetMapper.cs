using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataSetMapper
	/// </summary>
	/// <remarks>
	///    map vtkDataSet and derived classes to graphics primitives
	///
	/// vtkDataSetMapper is a mapper to map data sets (i.e., vtkDataSet and
	/// all derived classes) to graphics primitives. The mapping procedure
	/// is as follows: all 0D, 1D, and 2D cells are converted into points,
	/// lines, and polygons/triangle strips and then mapped to the graphics
	/// system. The 2D faces of 3D cells are mapped only if they are used by
	/// only one cell, i.e., on the boundary of the data set.
	/// </remarks>
	// Token: 0x020007D9 RID: 2009
	public class vtkDataSetMapper : vtkMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060149EE RID: 84462 RVA: 0x001D321F File Offset: 0x001D141F
		static vtkDataSetMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060149EF RID: 84463 RVA: 0x001D3247 File Offset: 0x001D1447
		public vtkDataSetMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060149F0 RID: 84464
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149F1 RID: 84465 RVA: 0x001D3258 File Offset: 0x001D1458
		public new static vtkDataSetMapper New()
		{
			vtkDataSetMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetMapper.vtkDataSetMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149F2 RID: 84466 RVA: 0x001D32AC File Offset: 0x001D14AC
		public vtkDataSetMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataSetMapper.vtkDataSetMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060149F3 RID: 84467 RVA: 0x001D32F0 File Offset: 0x001D14F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060149F4 RID: 84468
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetMapper_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the Input of this mapper.
		/// </summary>
		// Token: 0x060149F5 RID: 84469 RVA: 0x001D32FC File Offset: 0x001D14FC
		public new vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetMapper.vtkDataSetMapper_GetInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x060149F6 RID: 84470
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDataSetMapper_GetMTime_02(HandleRef pThis);

		/// <summary>
		/// Get the mtime also considering the lookup table.
		/// </summary>
		// Token: 0x060149F7 RID: 84471 RVA: 0x001D336C File Offset: 0x001D156C
		public override ulong GetMTime()
		{
			return vtkDataSetMapper.vtkDataSetMapper_GetMTime_02(base.GetCppThis());
		}

		// Token: 0x060149F8 RID: 84472
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetMapper_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149F9 RID: 84473 RVA: 0x001D338C File Offset: 0x001D158C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataSetMapper.vtkDataSetMapper_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060149FA RID: 84474
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetMapper_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149FB RID: 84475 RVA: 0x001D33AC File Offset: 0x001D15AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataSetMapper.vtkDataSetMapper_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060149FC RID: 84476
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetMapper_GetPolyDataMapper_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the internal poly data mapper used to map data set to graphics system.
		/// </summary>
		// Token: 0x060149FD RID: 84477 RVA: 0x001D33C8 File Offset: 0x001D15C8
		public virtual vtkPolyDataMapper GetPolyDataMapper()
		{
			vtkPolyDataMapper vtkPolyDataMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetMapper.vtkDataSetMapper_GetPolyDataMapper_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataMapper = (vtkPolyDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataMapper.Register(null);
				}
			}
			return vtkPolyDataMapper;
		}

		// Token: 0x060149FE RID: 84478
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetMapper_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149FF RID: 84479 RVA: 0x001D3438 File Offset: 0x001D1638
		public override int IsA(string type)
		{
			return vtkDataSetMapper.vtkDataSetMapper_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06014A00 RID: 84480
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetMapper_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014A01 RID: 84481 RVA: 0x001D3458 File Offset: 0x001D1658
		public new static int IsTypeOf(string type)
		{
			return vtkDataSetMapper.vtkDataSetMapper_IsTypeOf_07(type);
		}

		// Token: 0x06014A02 RID: 84482
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetMapper_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014A03 RID: 84483 RVA: 0x001D3474 File Offset: 0x001D1674
		public new vtkDataSetMapper NewInstance()
		{
			vtkDataSetMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetMapper.vtkDataSetMapper_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014A04 RID: 84484
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetMapper_ReleaseGraphicsResources_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06014A05 RID: 84485 RVA: 0x001D34D0 File Offset: 0x001D16D0
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkDataSetMapper.vtkDataSetMapper_ReleaseGraphicsResources_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06014A06 RID: 84486
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetMapper_Render_11(HandleRef pThis, HandleRef ren, HandleRef act);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014A07 RID: 84487 RVA: 0x001D3500 File Offset: 0x001D1700
		public override void Render(vtkRenderer ren, vtkActor act)
		{
			vtkDataSetMapper.vtkDataSetMapper_Render_11(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		// Token: 0x06014A08 RID: 84488
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetMapper_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014A09 RID: 84489 RVA: 0x001D3544 File Offset: 0x001D1744
		public new static vtkDataSetMapper SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetMapper vtkDataSetMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetMapper.vtkDataSetMapper_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetMapper = (vtkDataSetMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetMapper.Register(null);
				}
			}
			return vtkDataSetMapper;
		}

		// Token: 0x06014A0A RID: 84490
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetMapper_SetInputData_13(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set the Input of this mapper.
		/// </summary>
		// Token: 0x06014A0B RID: 84491 RVA: 0x001D35C4 File Offset: 0x001D17C4
		public void SetInputData(vtkDataSet input)
		{
			vtkDataSetMapper.vtkDataSetMapper_SetInputData_13(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017D8 RID: 6104
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017D9 RID: 6105
		public new static readonly string MRClassNameKey = "class vtkDataSetMapper";
	}
}
