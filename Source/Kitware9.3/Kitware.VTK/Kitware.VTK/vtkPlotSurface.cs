using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlotSurface
	/// </summary>
	/// <remarks>
	///    3D surface plot.
	///
	///
	/// 3D surface plot.
	///
	/// </remarks>
	// Token: 0x0200066A RID: 1642
	public class vtkPlotSurface : vtkPlot3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011B6F RID: 72559 RVA: 0x0018C4F2 File Offset: 0x0018A6F2
		static vtkPlotSurface()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotSurface.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotSurface"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011B70 RID: 72560 RVA: 0x0018C51A File Offset: 0x0018A71A
		public vtkPlotSurface(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011B71 RID: 72561
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotSurface_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B72 RID: 72562 RVA: 0x0018C528 File Offset: 0x0018A728
		public new static vtkPlotSurface New()
		{
			vtkPlotSurface result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotSurface.vtkPlotSurface_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotSurface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B73 RID: 72563 RVA: 0x0018C57C File Offset: 0x0018A77C
		public vtkPlotSurface() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlotSurface.vtkPlotSurface_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011B74 RID: 72564 RVA: 0x0018C5C0 File Offset: 0x0018A7C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011B75 RID: 72565
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotSurface_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B76 RID: 72566 RVA: 0x0018C5CC File Offset: 0x0018A7CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlotSurface.vtkPlotSurface_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06011B77 RID: 72567
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotSurface_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B78 RID: 72568 RVA: 0x0018C5EC File Offset: 0x0018A7EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlotSurface.vtkPlotSurface_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06011B79 RID: 72569
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotSurface_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B7A RID: 72570 RVA: 0x0018C608 File Offset: 0x0018A808
		public override int IsA(string type)
		{
			return vtkPlotSurface.vtkPlotSurface_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06011B7B RID: 72571
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotSurface_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B7C RID: 72572 RVA: 0x0018C628 File Offset: 0x0018A828
		public new static int IsTypeOf(string type)
		{
			return vtkPlotSurface.vtkPlotSurface_IsTypeOf_04(type);
		}

		// Token: 0x06011B7D RID: 72573
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotSurface_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B7E RID: 72574 RVA: 0x0018C644 File Offset: 0x0018A844
		public new vtkPlotSurface NewInstance()
		{
			vtkPlotSurface result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotSurface.vtkPlotSurface_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotSurface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011B7F RID: 72575
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotSurface_Paint_07(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the XY plot, called whenever the chart needs to be drawn
		/// </summary>
		// Token: 0x06011B80 RID: 72576 RVA: 0x0018C6A0 File Offset: 0x0018A8A0
		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotSurface.vtkPlotSurface_Paint_07(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06011B81 RID: 72577
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotSurface_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B82 RID: 72578 RVA: 0x0018C6DC File Offset: 0x0018A8DC
		public new static vtkPlotSurface SafeDownCast(vtkObjectBase o)
		{
			vtkPlotSurface vtkPlotSurface = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotSurface.vtkPlotSurface_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotSurface = (vtkPlotSurface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotSurface.Register(null);
				}
			}
			return vtkPlotSurface;
		}

		// Token: 0x06011B83 RID: 72579
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotSurface_SetInputData_09(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set the input to the surface plot.
		/// </summary>
		// Token: 0x06011B84 RID: 72580 RVA: 0x0018C75C File Offset: 0x0018A95C
		public override void SetInputData(vtkTable input)
		{
			vtkPlotSurface.vtkPlotSurface_SetInputData_09(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06011B85 RID: 72581
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotSurface_SetInputData_10(HandleRef pThis, HandleRef input, [MarshalAs(UnmanagedType.LPUTF8Str)] string xName, [MarshalAs(UnmanagedType.LPUTF8Str)] string yName, [MarshalAs(UnmanagedType.LPUTF8Str)] string zName);

		/// <summary>
		/// Set the input to the surface plot.
		/// Do not use these versions of SetInputData, as all the parameters
		/// beyond the vtkTable are ignored.
		/// </summary>
		// Token: 0x06011B86 RID: 72582 RVA: 0x0018C78C File Offset: 0x0018A98C
		public override void SetInputData(vtkTable input, string xName, string yName, string zName)
		{
			vtkPlotSurface.vtkPlotSurface_SetInputData_10(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), xName, yName, zName);
		}

		// Token: 0x06011B87 RID: 72583
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotSurface_SetInputData_11(HandleRef pThis, HandleRef input, [MarshalAs(UnmanagedType.LPUTF8Str)] string xName, [MarshalAs(UnmanagedType.LPUTF8Str)] string yName, [MarshalAs(UnmanagedType.LPUTF8Str)] string zName, [MarshalAs(UnmanagedType.LPUTF8Str)] string colorName);

		/// <summary>
		/// Set the input to the surface plot.
		/// Do not use these versions of SetInputData, as all the parameters
		/// beyond the vtkTable are ignored.
		/// </summary>
		// Token: 0x06011B88 RID: 72584 RVA: 0x0018C7C0 File Offset: 0x0018A9C0
		public override void SetInputData(vtkTable input, string xName, string yName, string zName, string colorName)
		{
			vtkPlotSurface.vtkPlotSurface_SetInputData_11(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), xName, yName, zName, colorName);
		}

		// Token: 0x06011B89 RID: 72585
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotSurface_SetInputData_12(HandleRef pThis, HandleRef input, long xColumn, long yColumn, long zColumn);

		/// <summary>
		/// Set the input to the surface plot.
		/// Do not use these versions of SetInputData, as all the parameters
		/// beyond the vtkTable are ignored.
		/// </summary>
		// Token: 0x06011B8A RID: 72586 RVA: 0x0018C7F8 File Offset: 0x0018A9F8
		public override void SetInputData(vtkTable input, long xColumn, long yColumn, long zColumn)
		{
			vtkPlotSurface.vtkPlotSurface_SetInputData_12(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), xColumn, yColumn, zColumn);
		}

		// Token: 0x06011B8B RID: 72587
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotSurface_SetXRange_13(HandleRef pThis, float min, float max);

		/// <summary>
		/// Set the range of the input data for the X dimension.  By default it is
		/// (1, NumberOfColumns).  Calling this method after SetInputData() results
		/// in recomputation of the plot's data.  Therefore, it is more efficient
		/// to call it before SetInputData() when possible.
		/// </summary>
		// Token: 0x06011B8C RID: 72588 RVA: 0x0018C82B File Offset: 0x0018AA2B
		public void SetXRange(float min, float max)
		{
			vtkPlotSurface.vtkPlotSurface_SetXRange_13(base.GetCppThis(), min, max);
		}

		// Token: 0x06011B8D RID: 72589
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotSurface_SetYRange_14(HandleRef pThis, float min, float max);

		/// <summary>
		/// Set the range of the input data for the Y dimension.  By default it is
		/// (1, NumberOfRows).  Calling this method after SetInputData() results
		/// in recomputation of the plot's data.  Therefore, it is more efficient
		/// to call it before SetInputData() when possible.
		/// </summary>
		// Token: 0x06011B8E RID: 72590 RVA: 0x0018C83C File Offset: 0x0018AA3C
		public void SetYRange(float min, float max)
		{
			vtkPlotSurface.vtkPlotSurface_SetYRange_14(base.GetCppThis(), min, max);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400146D RID: 5229
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotSurface";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400146E RID: 5230
		public new static readonly string MRClassNameKey = "class vtkPlotSurface";
	}
}
