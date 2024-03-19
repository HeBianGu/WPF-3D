using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtk2DHistogramItem
	/// </summary>
	/// <remarks>
	///    2D histogram item.
	///
	///
	///
	/// </remarks>
	// Token: 0x02000663 RID: 1635
	public class vtkPlotHistogram2D : vtkPlot
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011A5F RID: 72287 RVA: 0x0018A877 File Offset: 0x00188A77
		static vtkPlotHistogram2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotHistogram2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotHistogram2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011A60 RID: 72288 RVA: 0x0018A89F File Offset: 0x00188A9F
		public vtkPlotHistogram2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011A61 RID: 72289
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotHistogram2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a new object.
		/// </summary>
		// Token: 0x06011A62 RID: 72290 RVA: 0x0018A8B0 File Offset: 0x00188AB0
		public new static vtkPlotHistogram2D New()
		{
			vtkPlotHistogram2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotHistogram2D.vtkPlotHistogram2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotHistogram2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a new object.
		/// </summary>
		// Token: 0x06011A63 RID: 72291 RVA: 0x0018A904 File Offset: 0x00188B04
		public vtkPlotHistogram2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlotHistogram2D.vtkPlotHistogram2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011A64 RID: 72292 RVA: 0x0018A948 File Offset: 0x00188B48
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011A65 RID: 72293
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPlotHistogram2D_GetArrayName_01(HandleRef pThis);

		/// <summary>
		/// Set/get the selected array name.
		/// When empty, plot using SCALARS attribute.
		/// Default: empty string (use SCALARS).
		/// </summary>
		// Token: 0x06011A66 RID: 72294 RVA: 0x0018A954 File Offset: 0x00188B54
		public virtual string GetArrayName()
		{
			return vtkPlotHistogram2D.vtkPlotHistogram2D_GetArrayName_01(base.GetCppThis());
		}

		// Token: 0x06011A67 RID: 72295
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotHistogram2D_GetBounds_02(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the color transfer function that is used to generate the histogram.
		/// </summary>
		// Token: 0x06011A68 RID: 72296 RVA: 0x0018A973 File Offset: 0x00188B73
		public override void GetBounds(IntPtr bounds)
		{
			vtkPlotHistogram2D.vtkPlotHistogram2D_GetBounds_02(base.GetCppThis(), bounds);
		}

		// Token: 0x06011A69 RID: 72297
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotHistogram2D_GetInputImageData_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input table used by the plot.
		/// </summary>
		// Token: 0x06011A6A RID: 72298 RVA: 0x0018A984 File Offset: 0x00188B84
		public vtkImageData GetInputImageData()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotHistogram2D.vtkPlotHistogram2D_GetInputImageData_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x06011A6B RID: 72299
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotHistogram2D_GetNearestPoint_04(HandleRef pThis, HandleRef point, HandleRef tolerance, HandleRef location, IntPtr segmentId);

		/// <summary>
		/// Function to query a plot for the nearest point to the specified coordinate.
		/// Returns an index between 0 and (number of histogram cells - 1), or -1.
		/// The index 0 is at cell x=0, y=0 of the histogram, and the index increases
		/// in a minor fashion with x and in a major fashion with y.
		/// The referent of "location" is set to the x and y integer indices of the
		/// histogram cell.
		/// </summary>
		// Token: 0x06011A6C RID: 72300 RVA: 0x0018A9F4 File Offset: 0x00188BF4
		public override long GetNearestPoint(vtkVector2f point, vtkVector2f tolerance, vtkVector2f location, IntPtr segmentId)
		{
			return vtkPlotHistogram2D.vtkPlotHistogram2D_GetNearestPoint_04(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis(), (tolerance == null) ? default(HandleRef) : tolerance.GetCppThis(), (location == null) ? default(HandleRef) : location.GetCppThis(), segmentId);
		}

		// Token: 0x06011A6D RID: 72301
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotHistogram2D_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A6E RID: 72302 RVA: 0x0018AA54 File Offset: 0x00188C54
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlotHistogram2D.vtkPlotHistogram2D_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06011A6F RID: 72303
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotHistogram2D_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A70 RID: 72304 RVA: 0x0018AA74 File Offset: 0x00188C74
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlotHistogram2D.vtkPlotHistogram2D_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06011A71 RID: 72305
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotHistogram2D_GetPosition_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the color transfer function that is used to generate the histogram.
		/// </summary>
		// Token: 0x06011A72 RID: 72306 RVA: 0x0018AA90 File Offset: 0x00188C90
		public virtual vtkRectf GetPosition()
		{
			vtkRectf result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotHistogram2D.vtkPlotHistogram2D_GetPosition_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectf)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011A73 RID: 72307
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPlotHistogram2D_GetTooltipLabel_08(HandleRef pThis, HandleRef plotPos, long seriesIndex, long segmentIndex);

		/// <summary>
		/// Generate and return the tooltip label string for this plot
		/// The segmentIndex parameter is ignored.
		/// The member variable TooltipLabelFormat can be set as a
		/// printf-style string to build custom tooltip labels from,
		/// and may contain:
		/// An empty string generates the default tooltip labels.
		/// The following case-sensitive format tags (without quotes) are recognized:
		/// '%x' The X position of the histogram cell
		/// '%y' The Y position of the histogram cell
		/// '%v' The scalar value of the histogram cell
		/// '%i' The X axis tick label for the histogram cell
		/// '%j' The Y axis tick label for the histogram cell
		/// Any other characters or unrecognized format tags are printed in the
		/// tooltip label verbatim.
		/// </summary>
		// Token: 0x06011A74 RID: 72308 RVA: 0x0018AAEC File Offset: 0x00188CEC
		public override string GetTooltipLabel(vtkVector2d plotPos, long seriesIndex, long segmentIndex)
		{
			return vtkPlotHistogram2D.vtkPlotHistogram2D_GetTooltipLabel_08(base.GetCppThis(), (plotPos == null) ? default(HandleRef) : plotPos.GetCppThis(), seriesIndex, segmentIndex);
		}

		// Token: 0x06011A75 RID: 72309
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotHistogram2D_GetTransferFunction_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the color transfer function that is used to generate the histogram.
		/// </summary>
		// Token: 0x06011A76 RID: 72310 RVA: 0x0018AB24 File Offset: 0x00188D24
		public vtkScalarsToColors GetTransferFunction()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotHistogram2D.vtkPlotHistogram2D_GetTransferFunction_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		// Token: 0x06011A77 RID: 72311
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotHistogram2D_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A78 RID: 72312 RVA: 0x0018AB94 File Offset: 0x00188D94
		public override int IsA(string type)
		{
			return vtkPlotHistogram2D.vtkPlotHistogram2D_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06011A79 RID: 72313
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotHistogram2D_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A7A RID: 72314 RVA: 0x0018ABB4 File Offset: 0x00188DB4
		public new static int IsTypeOf(string type)
		{
			return vtkPlotHistogram2D.vtkPlotHistogram2D_IsTypeOf_11(type);
		}

		// Token: 0x06011A7B RID: 72315
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotHistogram2D_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A7C RID: 72316 RVA: 0x0018ABD0 File Offset: 0x00188DD0
		public new vtkPlotHistogram2D NewInstance()
		{
			vtkPlotHistogram2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotHistogram2D.vtkPlotHistogram2D_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotHistogram2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011A7D RID: 72317
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotHistogram2D_Paint_14(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the item, called whenever it needs to be drawn.
		/// </summary>
		// Token: 0x06011A7E RID: 72318 RVA: 0x0018AC2C File Offset: 0x00188E2C
		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotHistogram2D.vtkPlotHistogram2D_Paint_14(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06011A7F RID: 72319
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotHistogram2D_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A80 RID: 72320 RVA: 0x0018AC68 File Offset: 0x00188E68
		public new static vtkPlotHistogram2D SafeDownCast(vtkObjectBase o)
		{
			vtkPlotHistogram2D vtkPlotHistogram2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotHistogram2D.vtkPlotHistogram2D_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotHistogram2D = (vtkPlotHistogram2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotHistogram2D.Register(null);
				}
			}
			return vtkPlotHistogram2D;
		}

		// Token: 0x06011A81 RID: 72321
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotHistogram2D_SetArrayName_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the selected array name.
		/// When empty, plot using SCALARS attribute.
		/// Default: empty string (use SCALARS).
		/// </summary>
		// Token: 0x06011A82 RID: 72322 RVA: 0x0018ACE7 File Offset: 0x00188EE7
		public virtual void SetArrayName(string _arg)
		{
			vtkPlotHistogram2D.vtkPlotHistogram2D_SetArrayName_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06011A83 RID: 72323
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotHistogram2D_SetInputData_17(HandleRef pThis, HandleRef data, long z);

		/// <summary>
		/// Set the input. The image data is supposed to have scalars attribute set,
		/// if no array name is set.
		/// </summary>
		// Token: 0x06011A84 RID: 72324 RVA: 0x0018ACF8 File Offset: 0x00188EF8
		public virtual void SetInputData(vtkImageData data, long z)
		{
			vtkPlotHistogram2D.vtkPlotHistogram2D_SetInputData_17(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), z);
		}

		// Token: 0x06011A85 RID: 72325
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotHistogram2D_SetInputData_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the input. The image data is supposed to have scalars attribute set,
		/// if no array name is set.
		/// </summary>
		// Token: 0x06011A86 RID: 72326 RVA: 0x0018AD28 File Offset: 0x00188F28
		public override void SetInputData(vtkTable arg0)
		{
			vtkPlotHistogram2D.vtkPlotHistogram2D_SetInputData_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06011A87 RID: 72327
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotHistogram2D_SetInputData_19(HandleRef pThis, HandleRef arg0, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg2);

		/// <summary>
		/// Set the input. The image data is supposed to have scalars attribute set,
		/// if no array name is set.
		/// </summary>
		// Token: 0x06011A88 RID: 72328 RVA: 0x0018AD58 File Offset: 0x00188F58
		public override void SetInputData(vtkTable arg0, string arg1, string arg2)
		{
			vtkPlotHistogram2D.vtkPlotHistogram2D_SetInputData_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), arg1, arg2);
		}

		// Token: 0x06011A89 RID: 72329
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotHistogram2D_SetPosition_20(HandleRef pThis, HandleRef pos);

		/// <summary>
		/// Get the color transfer function that is used to generate the histogram.
		/// </summary>
		// Token: 0x06011A8A RID: 72330 RVA: 0x0018AD8C File Offset: 0x00188F8C
		public virtual void SetPosition(vtkRectf pos)
		{
			vtkPlotHistogram2D.vtkPlotHistogram2D_SetPosition_20(base.GetCppThis(), (pos == null) ? default(HandleRef) : pos.GetCppThis());
		}

		// Token: 0x06011A8B RID: 72331
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotHistogram2D_SetTransferFunction_21(HandleRef pThis, HandleRef transfer);

		/// <summary>
		/// Set the color transfer function that will be used to generate the 2D
		/// histogram.
		/// </summary>
		// Token: 0x06011A8C RID: 72332 RVA: 0x0018ADBC File Offset: 0x00188FBC
		public void SetTransferFunction(vtkScalarsToColors transfer)
		{
			vtkPlotHistogram2D.vtkPlotHistogram2D_SetTransferFunction_21(base.GetCppThis(), (transfer == null) ? default(HandleRef) : transfer.GetCppThis());
		}

		// Token: 0x06011A8D RID: 72333
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotHistogram2D_Update_22(HandleRef pThis);

		/// <summary>
		/// Perform any updates to the item that may be necessary before rendering.
		/// The scene should take care of calling this on all items before their
		/// Paint function is invoked.
		/// </summary>
		// Token: 0x06011A8E RID: 72334 RVA: 0x0018ADEB File Offset: 0x00188FEB
		public override void Update()
		{
			vtkPlotHistogram2D.vtkPlotHistogram2D_Update_22(base.GetCppThis());
		}

		// Token: 0x06011A8F RID: 72335
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotHistogram2D_UpdateCache_23(HandleRef pThis);

		/// <summary>
		/// Update the internal cache. Returns true if cache was successfully updated. Default does
		/// nothing.
		/// This method is called by Update() when either the plot's data has changed or
		/// CacheRequiresUpdate() returns true. It is not necessary to call this method explicitly.
		/// </summary>
		// Token: 0x06011A90 RID: 72336 RVA: 0x0018ADFC File Offset: 0x00188FFC
		public override bool UpdateCache()
		{
			return vtkPlotHistogram2D.vtkPlotHistogram2D_UpdateCache_23(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400145F RID: 5215
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotHistogram2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001460 RID: 5216
		public new static readonly string MRClassNameKey = "class vtkPlotHistogram2D";
	}
}
