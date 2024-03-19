using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlotPie
	/// </summary>
	/// <remarks>
	///    Class for drawing a Pie diagram.
	///
	///
	/// </remarks>
	// Token: 0x02000668 RID: 1640
	public class vtkPlotPie : vtkPlot
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011B17 RID: 72471 RVA: 0x0018BB5E File Offset: 0x00189D5E
		static vtkPlotPie()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotPie.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotPie"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011B18 RID: 72472 RVA: 0x0018BB86 File Offset: 0x00189D86
		public vtkPlotPie(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011B19 RID: 72473
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotPie_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B1A RID: 72474 RVA: 0x0018BB94 File Offset: 0x00189D94
		public new static vtkPlotPie New()
		{
			vtkPlotPie result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotPie.vtkPlotPie_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotPie)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B1B RID: 72475 RVA: 0x0018BBE8 File Offset: 0x00189DE8
		public vtkPlotPie() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlotPie.vtkPlotPie_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011B1C RID: 72476 RVA: 0x0018BC2C File Offset: 0x00189E2C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011B1D RID: 72477
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotPie_GetColorSeries_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the color series used.
		/// </summary>
		// Token: 0x06011B1E RID: 72478 RVA: 0x0018BC38 File Offset: 0x00189E38
		public vtkColorSeries GetColorSeries()
		{
			vtkColorSeries vtkColorSeries = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotPie.vtkPlotPie_GetColorSeries_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorSeries = (vtkColorSeries)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorSeries.Register(null);
				}
			}
			return vtkColorSeries;
		}

		// Token: 0x06011B1F RID: 72479
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotPie_GetDimensions_02(HandleRef pThis);

		/// <summary>
		/// Get the dimensions of the pie, elements 0 and 1 are the x and y coordinate
		/// of the bottom corner. Elements 2 and 3 are the width and height.
		/// </summary>
		// Token: 0x06011B20 RID: 72480 RVA: 0x0018BCA8 File Offset: 0x00189EA8
		public virtual int[] GetDimensions()
		{
			IntPtr intPtr = vtkPlotPie.vtkPlotPie_GetDimensions_02(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06011B21 RID: 72481
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotPie_GetDimensions_03(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4);

		/// <summary>
		/// Get the dimensions of the pie, elements 0 and 1 are the x and y coordinate
		/// of the bottom corner. Elements 2 and 3 are the width and height.
		/// </summary>
		// Token: 0x06011B22 RID: 72482 RVA: 0x0018BCF0 File Offset: 0x00189EF0
		public virtual void GetDimensions(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4)
		{
			vtkPlotPie.vtkPlotPie_GetDimensions_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x06011B23 RID: 72483
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotPie_GetDimensions_04(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the dimensions of the pie, elements 0 and 1 are the x and y coordinate
		/// of the bottom corner. Elements 2 and 3 are the width and height.
		/// </summary>
		// Token: 0x06011B24 RID: 72484 RVA: 0x0018BD04 File Offset: 0x00189F04
		public virtual void GetDimensions(IntPtr _arg)
		{
			vtkPlotPie.vtkPlotPie_GetDimensions_04(base.GetCppThis(), _arg);
		}

		// Token: 0x06011B25 RID: 72485
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotPie_GetNearestPoint_05(HandleRef pThis, HandleRef point, HandleRef tolerance, HandleRef location, IntPtr segmentId);

		/// <summary>
		/// Function to query a plot for the nearest point to the specified coordinate.
		/// Returns the index of the data series with which the point is associated or
		/// -1.
		/// </summary>
		// Token: 0x06011B26 RID: 72486 RVA: 0x0018BD14 File Offset: 0x00189F14
		public override long GetNearestPoint(vtkVector2f point, vtkVector2f tolerance, vtkVector2f location, IntPtr segmentId)
		{
			return vtkPlotPie.vtkPlotPie_GetNearestPoint_05(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis(), (tolerance == null) ? default(HandleRef) : tolerance.GetCppThis(), (location == null) ? default(HandleRef) : location.GetCppThis(), segmentId);
		}

		// Token: 0x06011B27 RID: 72487
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotPie_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B28 RID: 72488 RVA: 0x0018BD74 File Offset: 0x00189F74
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlotPie.vtkPlotPie_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06011B29 RID: 72489
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotPie_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B2A RID: 72490 RVA: 0x0018BD94 File Offset: 0x00189F94
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlotPie.vtkPlotPie_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06011B2B RID: 72491
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotPie_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B2C RID: 72492 RVA: 0x0018BDB0 File Offset: 0x00189FB0
		public override int IsA(string type)
		{
			return vtkPlotPie.vtkPlotPie_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06011B2D RID: 72493
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotPie_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B2E RID: 72494 RVA: 0x0018BDD0 File Offset: 0x00189FD0
		public new static int IsTypeOf(string type)
		{
			return vtkPlotPie.vtkPlotPie_IsTypeOf_09(type);
		}

		// Token: 0x06011B2F RID: 72495
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotPie_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B30 RID: 72496 RVA: 0x0018BDEC File Offset: 0x00189FEC
		public new vtkPlotPie NewInstance()
		{
			vtkPlotPie result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotPie.vtkPlotPie_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotPie)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011B31 RID: 72497
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotPie_Paint_12(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the item.
		/// </summary>
		// Token: 0x06011B32 RID: 72498 RVA: 0x0018BE48 File Offset: 0x0018A048
		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotPie.vtkPlotPie_Paint_12(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06011B33 RID: 72499
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotPie_PaintLegend_13(HandleRef pThis, HandleRef painter, HandleRef rect, int legendIndex);

		/// <summary>
		/// Paint legend event for the XY plot, called whenever the legend needs the
		/// plot items symbol/mark/line drawn. A rect is supplied with the lower left
		/// corner of the rect (elements 0 and 1) and with width x height (elements 2
		/// and 3). The plot can choose how to fill the space supplied.
		/// </summary>
		// Token: 0x06011B34 RID: 72500 RVA: 0x0018BE84 File Offset: 0x0018A084
		public override bool PaintLegend(vtkContext2D painter, vtkRectf rect, int legendIndex)
		{
			return vtkPlotPie.vtkPlotPie_PaintLegend_13(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis(), (rect == null) ? default(HandleRef) : rect.GetCppThis(), legendIndex) != 0;
		}

		// Token: 0x06011B35 RID: 72501
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotPie_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B36 RID: 72502 RVA: 0x0018BED8 File Offset: 0x0018A0D8
		public new static vtkPlotPie SafeDownCast(vtkObjectBase o)
		{
			vtkPlotPie vtkPlotPie = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotPie.vtkPlotPie_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotPie = (vtkPlotPie)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotPie.Register(null);
				}
			}
			return vtkPlotPie;
		}

		// Token: 0x06011B37 RID: 72503
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotPie_SetColorSeries_15(HandleRef pThis, HandleRef colorSeries);

		/// <summary>
		/// Set the color series to use for the Pie.
		/// </summary>
		// Token: 0x06011B38 RID: 72504 RVA: 0x0018BF58 File Offset: 0x0018A158
		public void SetColorSeries(vtkColorSeries colorSeries)
		{
			vtkPlotPie.vtkPlotPie_SetColorSeries_15(base.GetCppThis(), (colorSeries == null) ? default(HandleRef) : colorSeries.GetCppThis());
		}

		// Token: 0x06011B39 RID: 72505
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotPie_SetDimensions_16(HandleRef pThis, int arg1, int arg2, int arg3, int arg4);

		/// <summary>
		/// Set the dimensions of the pie, arguments 1 and 2 are the x and y coordinate
		/// of the bottom corner. Arguments 3 and 4 are the width and height.
		/// </summary>
		// Token: 0x06011B3A RID: 72506 RVA: 0x0018BF87 File Offset: 0x0018A187
		public void SetDimensions(int arg1, int arg2, int arg3, int arg4)
		{
			vtkPlotPie.vtkPlotPie_SetDimensions_16(base.GetCppThis(), arg1, arg2, arg3, arg4);
		}

		// Token: 0x06011B3B RID: 72507
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotPie_SetDimensions_17(HandleRef pThis, IntPtr arg);

		/// <summary>
		/// Set the dimensions of the pie, elements 0 and 1 are the x and y coordinate
		/// of the bottom corner. Elements 2 and 3 are the width and height.
		/// </summary>
		// Token: 0x06011B3C RID: 72508 RVA: 0x0018BF9B File Offset: 0x0018A19B
		public void SetDimensions(IntPtr arg)
		{
			vtkPlotPie.vtkPlotPie_SetDimensions_17(base.GetCppThis(), arg);
		}

		// Token: 0x06011B3D RID: 72509
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotPie_UpdateCache_18(HandleRef pThis);

		/// <summary>
		/// Update the internal cache. Returns true if cache was successfully updated. Default does
		/// nothing.
		/// This method is called by Update() when either the plot's data has changed or
		/// CacheRequiresUpdate() returns true. It is not necessary to call this method explicitly.
		/// </summary>
		// Token: 0x06011B3E RID: 72510 RVA: 0x0018BFAC File Offset: 0x0018A1AC
		public override bool UpdateCache()
		{
			return vtkPlotPie.vtkPlotPie_UpdateCache_18(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001469 RID: 5225
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotPie";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400146A RID: 5226
		public new static readonly string MRClassNameKey = "class vtkPlotPie";
	}
}
