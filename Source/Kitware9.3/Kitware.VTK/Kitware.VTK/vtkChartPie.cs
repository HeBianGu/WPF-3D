using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkChartPie
	/// </summary>
	/// <remarks>
	///    Factory class for drawing pie charts
	///
	///
	/// This class implements an pie chart.
	/// </remarks>
	// Token: 0x02000641 RID: 1601
	public class vtkChartPie : vtkChart
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011523 RID: 70947 RVA: 0x0018264A File Offset: 0x0018084A
		static vtkChartPie()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkChartPie.MRClassNameKey, Type.GetType("Kitware.VTK.vtkChartPie"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011524 RID: 70948 RVA: 0x00182672 File Offset: 0x00180872
		public vtkChartPie(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011525 RID: 70949
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartPie_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a 2D Chart object.
		/// </summary>
		// Token: 0x06011526 RID: 70950 RVA: 0x00182680 File Offset: 0x00180880
		public new static vtkChartPie New()
		{
			vtkChartPie result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartPie.vtkChartPie_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartPie)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a 2D Chart object.
		/// </summary>
		// Token: 0x06011527 RID: 70951 RVA: 0x001826D4 File Offset: 0x001808D4
		public vtkChartPie() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkChartPie.vtkChartPie_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011528 RID: 70952 RVA: 0x00182718 File Offset: 0x00180918
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011529 RID: 70953
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartPie_AddPlot_01(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Add a plot to the chart.
		/// </summary>
		// Token: 0x0601152A RID: 70954 RVA: 0x00182724 File Offset: 0x00180924
		public override vtkPlot AddPlot(int type)
		{
			vtkPlot vtkPlot = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartPie.vtkChartPie_AddPlot_01(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlot = (vtkPlot)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlot.Register(null);
				}
			}
			return vtkPlot;
		}

		// Token: 0x0601152B RID: 70955
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartPie_GetLegend_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the legend for the chart, if available. Can return nullptr if there is no
		/// legend.
		/// </summary>
		// Token: 0x0601152C RID: 70956 RVA: 0x00182794 File Offset: 0x00180994
		public override vtkChartLegend GetLegend()
		{
			vtkChartLegend vtkChartLegend = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartPie.vtkChartPie_GetLegend_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChartLegend = (vtkChartLegend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChartLegend.Register(null);
				}
			}
			return vtkChartLegend;
		}

		// Token: 0x0601152D RID: 70957
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartPie_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601152E RID: 70958 RVA: 0x00182804 File Offset: 0x00180A04
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkChartPie.vtkChartPie_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601152F RID: 70959
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartPie_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011530 RID: 70960 RVA: 0x00182824 File Offset: 0x00180A24
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkChartPie.vtkChartPie_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06011531 RID: 70961
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartPie_GetNumberOfPlots_05(HandleRef pThis);

		/// <summary>
		/// Get the number of plots the chart contains.
		/// </summary>
		// Token: 0x06011532 RID: 70962 RVA: 0x00182840 File Offset: 0x00180A40
		public override long GetNumberOfPlots()
		{
			return vtkChartPie.vtkChartPie_GetNumberOfPlots_05(base.GetCppThis());
		}

		// Token: 0x06011533 RID: 70963
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartPie_GetPlot_06(HandleRef pThis, long index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plot at the specified index, returns null if the index is invalid.
		/// </summary>
		// Token: 0x06011534 RID: 70964 RVA: 0x00182860 File Offset: 0x00180A60
		public override vtkPlot GetPlot(long index)
		{
			vtkPlot vtkPlot = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartPie.vtkChartPie_GetPlot_06(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlot = (vtkPlot)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlot.Register(null);
				}
			}
			return vtkPlot;
		}

		// Token: 0x06011535 RID: 70965
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartPie_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011536 RID: 70966 RVA: 0x001828D0 File Offset: 0x00180AD0
		public override int IsA(string type)
		{
			return vtkChartPie.vtkChartPie_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06011537 RID: 70967
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartPie_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011538 RID: 70968 RVA: 0x001828F0 File Offset: 0x00180AF0
		public new static int IsTypeOf(string type)
		{
			return vtkChartPie.vtkChartPie_IsTypeOf_08(type);
		}

		// Token: 0x06011539 RID: 70969
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartPie_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601153A RID: 70970 RVA: 0x0018290C File Offset: 0x00180B0C
		public new vtkChartPie NewInstance()
		{
			vtkChartPie result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartPie.vtkChartPie_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartPie)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601153B RID: 70971
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartPie_Paint_11(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the chart, called whenever the chart needs to be drawn
		/// </summary>
		// Token: 0x0601153C RID: 70972 RVA: 0x00182968 File Offset: 0x00180B68
		public override bool Paint(vtkContext2D painter)
		{
			return vtkChartPie.vtkChartPie_Paint_11(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x0601153D RID: 70973
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartPie_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601153E RID: 70974 RVA: 0x001829A4 File Offset: 0x00180BA4
		public new static vtkChartPie SafeDownCast(vtkObjectBase o)
		{
			vtkChartPie vtkChartPie = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartPie.vtkChartPie_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChartPie = (vtkChartPie)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChartPie.Register(null);
				}
			}
			return vtkChartPie;
		}

		// Token: 0x0601153F RID: 70975
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartPie_SetPlot_13(HandleRef pThis, HandleRef plot);

		/// <summary>
		/// Set plot to use for the chart. Since this type of chart can
		/// only contain one plot, this will replace the previous plot.
		/// </summary>
		// Token: 0x06011540 RID: 70976 RVA: 0x00182A24 File Offset: 0x00180C24
		public virtual void SetPlot(vtkPlotPie plot)
		{
			vtkChartPie.vtkChartPie_SetPlot_13(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis());
		}

		// Token: 0x06011541 RID: 70977
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartPie_SetScene_14(HandleRef pThis, HandleRef scene);

		/// <summary>
		/// Set the vtkContextScene for the item, always set for an item in a scene.
		/// </summary>
		// Token: 0x06011542 RID: 70978 RVA: 0x00182A54 File Offset: 0x00180C54
		public override void SetScene(vtkContextScene scene)
		{
			vtkChartPie.vtkChartPie_SetScene_14(base.GetCppThis(), (scene == null) ? default(HandleRef) : scene.GetCppThis());
		}

		// Token: 0x06011543 RID: 70979
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartPie_SetShowLegend_15(HandleRef pThis, byte visible);

		/// <summary>
		/// Set whether the chart should draw a legend.
		/// </summary>
		// Token: 0x06011544 RID: 70980 RVA: 0x00182A83 File Offset: 0x00180C83
		public override void SetShowLegend(bool visible)
		{
			vtkChartPie.vtkChartPie_SetShowLegend_15(base.GetCppThis(), visible ? (byte)1 : (byte)0);
		}

		// Token: 0x06011545 RID: 70981
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartPie_Update_16(HandleRef pThis);

		/// <summary>
		/// Perform any updates to the item that may be necessary before rendering.
		/// The scene should take care of calling this on all items before their
		/// Paint function is invoked.
		/// </summary>
		// Token: 0x06011546 RID: 70982 RVA: 0x00182A9B File Offset: 0x00180C9B
		public override void Update()
		{
			vtkChartPie.vtkChartPie_Update_16(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400140B RID: 5131
		public new const string MRFullTypeName = "Kitware.VTK.vtkChartPie";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400140C RID: 5132
		public new static readonly string MRClassNameKey = "class vtkChartPie";
	}
}
