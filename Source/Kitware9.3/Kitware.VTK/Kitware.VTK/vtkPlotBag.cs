using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlotBag
	/// </summary>
	/// <remarks>
	///    Class for drawing an a bagplot.
	///
	///
	/// This class allows to draw a bagplot given three columns from
	/// a vtkTable. The first two columns will represent X,Y as it is for
	/// vtkPlotPoints. The third one will have to specify if the density
	/// assigned to each point (generally obtained by the
	/// vtkHighestDensityRegionsStatistics filter).
	/// Points are drawn in a plot points fashion and 2 convex hull polygons
	/// are drawn around the median and the 3 quartile of the density field.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHighestDensityRegionsStatistics
	/// </seealso>
	// Token: 0x02000659 RID: 1625
	public class vtkPlotBag : vtkPlotPoints
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060118F5 RID: 71925 RVA: 0x0018857E File Offset: 0x0018677E
		static vtkPlotBag()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotBag.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotBag"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060118F6 RID: 71926 RVA: 0x001885A6 File Offset: 0x001867A6
		public vtkPlotBag(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060118F7 RID: 71927
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBag_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a new Bag Plot object.
		/// </summary>
		// Token: 0x060118F8 RID: 71928 RVA: 0x001885B4 File Offset: 0x001867B4
		public new static vtkPlotBag New()
		{
			vtkPlotBag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBag.vtkPlotBag_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotBag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a new Bag Plot object.
		/// </summary>
		// Token: 0x060118F9 RID: 71929 RVA: 0x00188608 File Offset: 0x00186808
		public vtkPlotBag() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlotBag.vtkPlotBag_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060118FA RID: 71930 RVA: 0x0018864C File Offset: 0x0018684C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060118FB RID: 71931
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotBag_GetBagVisible_01(HandleRef pThis);

		/// <summary>
		/// Set/get the visibility of the bags.
		/// True by default.
		/// </summary>
		// Token: 0x060118FC RID: 71932 RVA: 0x00188658 File Offset: 0x00186858
		public virtual bool GetBagVisible()
		{
			return vtkPlotBag.vtkPlotBag_GetBagVisible_01(base.GetCppThis()) != 0;
		}

		// Token: 0x060118FD RID: 71933
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBag_GetLabels_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plot labels. If this array has a length greater than 1 the index
		/// refers to the stacked objects in the plot. See vtkPlotBar for example.
		/// </summary>
		// Token: 0x060118FE RID: 71934 RVA: 0x00188680 File Offset: 0x00186880
		public override vtkStringArray GetLabels()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBag.vtkPlotBag_GetLabels_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x060118FF RID: 71935
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBag_GetLinePen_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the vtkPen object that controls how this plot draws boundary lines.
		/// </summary>
		// Token: 0x06011900 RID: 71936 RVA: 0x001886F0 File Offset: 0x001868F0
		public virtual vtkPen GetLinePen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBag.vtkPlotBag_GetLinePen_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPen = (vtkPen)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPen.Register(null);
				}
			}
			return vtkPen;
		}

		// Token: 0x06011901 RID: 71937
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotBag_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011902 RID: 71938 RVA: 0x00188760 File Offset: 0x00186960
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlotBag.vtkPlotBag_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06011903 RID: 71939
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotBag_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011904 RID: 71940 RVA: 0x00188780 File Offset: 0x00186980
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlotBag.vtkPlotBag_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06011905 RID: 71941
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBag_GetPointPen_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the vtkPen object that controls how this plot draws points.
		/// Those are just helpers functions:
		/// this pen is actually the default Plot pen.
		/// </summary>
		// Token: 0x06011906 RID: 71942 RVA: 0x0018879C File Offset: 0x0018699C
		public vtkPen GetPointPen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBag.vtkPlotBag_GetPointPen_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPen = (vtkPen)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPen.Register(null);
				}
			}
			return vtkPen;
		}

		// Token: 0x06011907 RID: 71943
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPlotBag_GetTooltipLabel_07(HandleRef pThis, HandleRef plotPos, long seriesIndex, long segmentIndex);

		/// <summary>
		/// Generate and return the tooltip label string for this plot
		/// The segmentIndex parameter is ignored, except for vtkPlotBar
		/// </summary>
		// Token: 0x06011908 RID: 71944 RVA: 0x0018880C File Offset: 0x00186A0C
		public override string GetTooltipLabel(vtkVector2d plotPos, long seriesIndex, long segmentIndex)
		{
			return vtkPlotBag.vtkPlotBag_GetTooltipLabel_07(base.GetCppThis(), (plotPos == null) ? default(HandleRef) : plotPos.GetCppThis(), seriesIndex, segmentIndex);
		}

		// Token: 0x06011909 RID: 71945
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotBag_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601190A RID: 71946 RVA: 0x00188844 File Offset: 0x00186A44
		public override int IsA(string type)
		{
			return vtkPlotBag.vtkPlotBag_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601190B RID: 71947
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotBag_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601190C RID: 71948 RVA: 0x00188864 File Offset: 0x00186A64
		public new static int IsTypeOf(string type)
		{
			return vtkPlotBag.vtkPlotBag_IsTypeOf_09(type);
		}

		// Token: 0x0601190D RID: 71949
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBag_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601190E RID: 71950 RVA: 0x00188880 File Offset: 0x00186A80
		public new vtkPlotBag NewInstance()
		{
			vtkPlotBag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBag.vtkPlotBag_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotBag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601190F RID: 71951
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotBag_Paint_12(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the XY plot, called whenever the chart needs to be drawn.
		/// </summary>
		// Token: 0x06011910 RID: 71952 RVA: 0x001888DC File Offset: 0x00186ADC
		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotBag.vtkPlotBag_Paint_12(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06011911 RID: 71953
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotBag_PaintLegend_13(HandleRef pThis, HandleRef painter, HandleRef rect, int legendIndex);

		/// <summary>
		/// Paint legend event for the XY plot, called whenever the legend needs the
		/// plot items symbol/mark/line drawn. A rect is supplied with the lower left
		/// corner of the rect (elements 0 and 1) and with width x height (elements 2
		/// and 3). The plot can choose how to fill the space supplied.
		/// </summary>
		// Token: 0x06011912 RID: 71954 RVA: 0x00188918 File Offset: 0x00186B18
		public override bool PaintLegend(vtkContext2D painter, vtkRectf rect, int legendIndex)
		{
			return vtkPlotBag.vtkPlotBag_PaintLegend_13(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis(), (rect == null) ? default(HandleRef) : rect.GetCppThis(), legendIndex) != 0;
		}

		// Token: 0x06011913 RID: 71955
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBag_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011914 RID: 71956 RVA: 0x0018896C File Offset: 0x00186B6C
		public new static vtkPlotBag SafeDownCast(vtkObjectBase o)
		{
			vtkPlotBag vtkPlotBag = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBag.vtkPlotBag_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotBag = (vtkPlotBag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotBag.Register(null);
				}
			}
			return vtkPlotBag;
		}

		// Token: 0x06011915 RID: 71957
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBag_SetBagVisible_15(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/get the visibility of the bags.
		/// True by default.
		/// </summary>
		// Token: 0x06011916 RID: 71958 RVA: 0x001889EB File Offset: 0x00186BEB
		public virtual void SetBagVisible(bool _arg)
		{
			vtkPlotBag.vtkPlotBag_SetBagVisible_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011917 RID: 71959
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBag_SetInputData_16(HandleRef pThis, HandleRef table);

		/// <summary>
		/// Set the input, we are expecting a vtkTable with three columns. The first
		/// column and the second represent the x,y position . The five others
		/// columns represent the quartiles used to display the box.
		/// Inherited method will call the last SetInputData method with default
		/// parameters.
		/// </summary>
		// Token: 0x06011918 RID: 71960 RVA: 0x00188A04 File Offset: 0x00186C04
		public override void SetInputData(vtkTable table)
		{
			vtkPlotBag.vtkPlotBag_SetInputData_16(base.GetCppThis(), (table == null) ? default(HandleRef) : table.GetCppThis());
		}

		// Token: 0x06011919 RID: 71961
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBag_SetInputData_17(HandleRef pThis, HandleRef table, [MarshalAs(UnmanagedType.LPUTF8Str)] string yColumn, [MarshalAs(UnmanagedType.LPUTF8Str)] string densityColumn);

		/// <summary>
		/// Set the input, we are expecting a vtkTable with three columns. The first
		/// column and the second represent the x,y position . The five others
		/// columns represent the quartiles used to display the box.
		/// Inherited method will call the last SetInputData method with default
		/// parameters.
		/// </summary>
		// Token: 0x0601191A RID: 71962 RVA: 0x00188A34 File Offset: 0x00186C34
		public override void SetInputData(vtkTable table, string yColumn, string densityColumn)
		{
			vtkPlotBag.vtkPlotBag_SetInputData_17(base.GetCppThis(), (table == null) ? default(HandleRef) : table.GetCppThis(), yColumn, densityColumn);
		}

		// Token: 0x0601191B RID: 71963
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBag_SetInputData_18(HandleRef pThis, HandleRef table, [MarshalAs(UnmanagedType.LPUTF8Str)] string xColumn, [MarshalAs(UnmanagedType.LPUTF8Str)] string yColumn, [MarshalAs(UnmanagedType.LPUTF8Str)] string densityColumn);

		/// <summary>
		/// Set the input, we are expecting a vtkTable with three columns. The first
		/// column and the second represent the x,y position . The five others
		/// columns represent the quartiles used to display the box.
		/// Inherited method will call the last SetInputData method with default
		/// parameters.
		/// </summary>
		// Token: 0x0601191C RID: 71964 RVA: 0x00188A68 File Offset: 0x00186C68
		public virtual void SetInputData(vtkTable table, string xColumn, string yColumn, string densityColumn)
		{
			vtkPlotBag.vtkPlotBag_SetInputData_18(base.GetCppThis(), (table == null) ? default(HandleRef) : table.GetCppThis(), xColumn, yColumn, densityColumn);
		}

		// Token: 0x0601191D RID: 71965
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBag_SetInputData_19(HandleRef pThis, HandleRef table, long xColumn, long yColumn, long densityColumn);

		/// <summary>
		/// Set the input, we are expecting a vtkTable with three columns. The first
		/// column and the second represent the x,y position . The five others
		/// columns represent the quartiles used to display the box.
		/// Inherited method will call the last SetInputData method with default
		/// parameters.
		/// </summary>
		// Token: 0x0601191E RID: 71966 RVA: 0x00188A9C File Offset: 0x00186C9C
		public virtual void SetInputData(vtkTable table, long xColumn, long yColumn, long densityColumn)
		{
			vtkPlotBag.vtkPlotBag_SetInputData_19(base.GetCppThis(), (table == null) ? default(HandleRef) : table.GetCppThis(), xColumn, yColumn, densityColumn);
		}

		// Token: 0x0601191F RID: 71967
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBag_SetLinePen_20(HandleRef pThis, HandleRef pen);

		/// <summary>
		/// Set/get the vtkPen object that controls how this plot draws boundary lines.
		/// </summary>
		// Token: 0x06011920 RID: 71968 RVA: 0x00188AD0 File Offset: 0x00186CD0
		public void SetLinePen(vtkPen pen)
		{
			vtkPlotBag.vtkPlotBag_SetLinePen_20(base.GetCppThis(), (pen == null) ? default(HandleRef) : pen.GetCppThis());
		}

		// Token: 0x06011921 RID: 71969
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBag_SetPointPen_21(HandleRef pThis, HandleRef pen);

		/// <summary>
		/// Set/get the vtkPen object that controls how this plot draws points.
		/// Those are just helpers functions:
		/// this pen is actually the default Plot pen.
		/// </summary>
		// Token: 0x06011922 RID: 71970 RVA: 0x00188B00 File Offset: 0x00186D00
		public void SetPointPen(vtkPen pen)
		{
			vtkPlotBag.vtkPlotBag_SetPointPen_21(base.GetCppThis(), (pen == null) ? default(HandleRef) : pen.GetCppThis());
		}

		// Token: 0x06011923 RID: 71971
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotBag_UpdateCache_22(HandleRef pThis);

		/// <summary>
		/// Update the internal cache. Returns true if cache was successfully updated. Default does
		/// nothing.
		/// This method is called by Update() when either the plot's data has changed or
		/// CacheRequiresUpdate() returns true. It is not necessary to call this method explicitly.
		/// </summary>
		// Token: 0x06011924 RID: 71972 RVA: 0x00188B30 File Offset: 0x00186D30
		public override bool UpdateCache()
		{
			return vtkPlotBag.vtkPlotBag_UpdateCache_22(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001447 RID: 5191
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotBag";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001448 RID: 5192
		public new static readonly string MRClassNameKey = "class vtkPlotBag";
	}
}
