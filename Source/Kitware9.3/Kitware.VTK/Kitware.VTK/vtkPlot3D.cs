using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlot3D
	/// </summary>
	/// <remarks>
	///    Abstract class for 3D plots.
	///
	///
	/// The base class for all plot types used in vtkChart derived charts.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPlot3DPoints vtkPlot3DLine vtkPlot3DBar vtkChart vtkChartXY
	/// </seealso>
	// Token: 0x02000655 RID: 1621
	public class vtkPlot3D : vtkContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601185A RID: 71770 RVA: 0x0018760F File Offset: 0x0018580F
		static vtkPlot3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlot3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlot3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601185B RID: 71771 RVA: 0x00187637 File Offset: 0x00185837
		public vtkPlot3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601185C RID: 71772 RVA: 0x00187645 File Offset: 0x00185845
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601185D RID: 71773
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot3D_GetChart_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/set the chart for this plot.
		/// </summary>
		// Token: 0x0601185E RID: 71774 RVA: 0x00187650 File Offset: 0x00185850
		public virtual vtkChartXYZ GetChart()
		{
			vtkChartXYZ vtkChartXYZ = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot3D.vtkPlot3D_GetChart_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChartXYZ = (vtkChartXYZ)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChartXYZ.Register(null);
				}
			}
			return vtkChartXYZ;
		}

		// Token: 0x0601185F RID: 71775
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlot3D_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011860 RID: 71776 RVA: 0x001876C0 File Offset: 0x001858C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlot3D.vtkPlot3D_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06011861 RID: 71777
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlot3D_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011862 RID: 71778 RVA: 0x001876E0 File Offset: 0x001858E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlot3D.vtkPlot3D_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06011863 RID: 71779
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot3D_GetPen_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the vtkPen object that controls how this plot draws (out)lines.
		/// </summary>
		// Token: 0x06011864 RID: 71780 RVA: 0x001876FC File Offset: 0x001858FC
		public vtkPen GetPen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot3D.vtkPlot3D_GetPen_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011865 RID: 71781
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot3D_GetSelection_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the selection array for the plot.
		/// </summary>
		// Token: 0x06011866 RID: 71782 RVA: 0x0018776C File Offset: 0x0018596C
		public virtual vtkIdTypeArray GetSelection()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot3D.vtkPlot3D_GetSelection_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x06011867 RID: 71783
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot3D_GetSelectionPen_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the vtkPen object that controls how this plot draws (out)lines.
		/// </summary>
		// Token: 0x06011868 RID: 71784 RVA: 0x001877DC File Offset: 0x001859DC
		public vtkPen GetSelectionPen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot3D.vtkPlot3D_GetSelectionPen_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011869 RID: 71785
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot3D_GetVTKPoints_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get all the data points within this plot.
		/// </summary>
		// Token: 0x0601186A RID: 71786 RVA: 0x0018784C File Offset: 0x00185A4C
		public vtkPoints GetVTKPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot3D.vtkPlot3D_GetVTKPoints_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x0601186B RID: 71787
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPlot3D_GetXAxisLabel_08(HandleRef pThis);

		/// <summary>
		/// Get the label for the X axis.
		/// </summary>
		// Token: 0x0601186C RID: 71788 RVA: 0x001878BC File Offset: 0x00185ABC
		public string GetXAxisLabel()
		{
			return vtkPlot3D.vtkPlot3D_GetXAxisLabel_08(base.GetCppThis());
		}

		// Token: 0x0601186D RID: 71789
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPlot3D_GetYAxisLabel_09(HandleRef pThis);

		/// <summary>
		/// Get the label for the Y axis.
		/// </summary>
		// Token: 0x0601186E RID: 71790 RVA: 0x001878DC File Offset: 0x00185ADC
		public string GetYAxisLabel()
		{
			return vtkPlot3D.vtkPlot3D_GetYAxisLabel_09(base.GetCppThis());
		}

		// Token: 0x0601186F RID: 71791
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPlot3D_GetZAxisLabel_10(HandleRef pThis);

		/// <summary>
		/// Get the label for the Z axis.
		/// </summary>
		// Token: 0x06011870 RID: 71792 RVA: 0x001878FC File Offset: 0x00185AFC
		public string GetZAxisLabel()
		{
			return vtkPlot3D.vtkPlot3D_GetZAxisLabel_10(base.GetCppThis());
		}

		// Token: 0x06011871 RID: 71793
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlot3D_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011872 RID: 71794 RVA: 0x0018791C File Offset: 0x00185B1C
		public override int IsA(string type)
		{
			return vtkPlot3D.vtkPlot3D_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06011873 RID: 71795
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlot3D_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011874 RID: 71796 RVA: 0x0018793C File Offset: 0x00185B3C
		public new static int IsTypeOf(string type)
		{
			return vtkPlot3D.vtkPlot3D_IsTypeOf_12(type);
		}

		// Token: 0x06011875 RID: 71797
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot3D_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011876 RID: 71798 RVA: 0x00187958 File Offset: 0x00185B58
		public new vtkPlot3D NewInstance()
		{
			vtkPlot3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot3D.vtkPlot3D_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlot3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011877 RID: 71799
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot3D_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011878 RID: 71800 RVA: 0x001879B4 File Offset: 0x00185BB4
		public new static vtkPlot3D SafeDownCast(vtkObjectBase o)
		{
			vtkPlot3D vtkPlot3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot3D.vtkPlot3D_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlot3D = (vtkPlot3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlot3D.Register(null);
				}
			}
			return vtkPlot3D;
		}

		// Token: 0x06011879 RID: 71801
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot3D_SetChart_15(HandleRef pThis, HandleRef chart);

		/// <summary>
		/// Get/set the chart for this plot.
		/// </summary>
		// Token: 0x0601187A RID: 71802 RVA: 0x00187A34 File Offset: 0x00185C34
		public virtual void SetChart(vtkChartXYZ chart)
		{
			vtkPlot3D.vtkPlot3D_SetChart_15(base.GetCppThis(), (chart == null) ? default(HandleRef) : chart.GetCppThis());
		}

		// Token: 0x0601187B RID: 71803
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot3D_SetColors_16(HandleRef pThis, HandleRef colorArr);

		/// <summary>
		/// Set the color of each point in the plot.  The input is a single component
		/// scalar array.  The values of this array will be passed through a lookup
		/// table to generate the color for each data point in the plot.
		/// </summary>
		// Token: 0x0601187C RID: 71804 RVA: 0x00187A64 File Offset: 0x00185C64
		public virtual void SetColors(vtkDataArray colorArr)
		{
			vtkPlot3D.vtkPlot3D_SetColors_16(base.GetCppThis(), (colorArr == null) ? default(HandleRef) : colorArr.GetCppThis());
		}

		// Token: 0x0601187D RID: 71805
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot3D_SetInputData_17(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set the input to the plot.
		/// </summary>
		// Token: 0x0601187E RID: 71806 RVA: 0x00187A94 File Offset: 0x00185C94
		public virtual void SetInputData(vtkTable input)
		{
			vtkPlot3D.vtkPlot3D_SetInputData_17(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0601187F RID: 71807
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot3D_SetInputData_18(HandleRef pThis, HandleRef input, [MarshalAs(UnmanagedType.LPUTF8Str)] string xName, [MarshalAs(UnmanagedType.LPUTF8Str)] string yName, [MarshalAs(UnmanagedType.LPUTF8Str)] string zName);

		/// <summary>
		/// Set the input to the plot.
		/// </summary>
		// Token: 0x06011880 RID: 71808 RVA: 0x00187AC4 File Offset: 0x00185CC4
		public virtual void SetInputData(vtkTable input, string xName, string yName, string zName)
		{
			vtkPlot3D.vtkPlot3D_SetInputData_18(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), xName, yName, zName);
		}

		// Token: 0x06011881 RID: 71809
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot3D_SetInputData_19(HandleRef pThis, HandleRef input, [MarshalAs(UnmanagedType.LPUTF8Str)] string xName, [MarshalAs(UnmanagedType.LPUTF8Str)] string yName, [MarshalAs(UnmanagedType.LPUTF8Str)] string zName, [MarshalAs(UnmanagedType.LPUTF8Str)] string colorName);

		/// <summary>
		/// Set the input to the plot.
		/// </summary>
		// Token: 0x06011882 RID: 71810 RVA: 0x00187AF8 File Offset: 0x00185CF8
		public virtual void SetInputData(vtkTable input, string xName, string yName, string zName, string colorName)
		{
			vtkPlot3D.vtkPlot3D_SetInputData_19(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), xName, yName, zName, colorName);
		}

		// Token: 0x06011883 RID: 71811
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot3D_SetInputData_20(HandleRef pThis, HandleRef input, long xColumn, long yColumn, long zColumn);

		/// <summary>
		/// Set the input to the plot.
		/// </summary>
		// Token: 0x06011884 RID: 71812 RVA: 0x00187B30 File Offset: 0x00185D30
		public virtual void SetInputData(vtkTable input, long xColumn, long yColumn, long zColumn)
		{
			vtkPlot3D.vtkPlot3D_SetInputData_20(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), xColumn, yColumn, zColumn);
		}

		// Token: 0x06011885 RID: 71813
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot3D_SetPen_21(HandleRef pThis, HandleRef pen);

		/// <summary>
		/// Set/get the vtkPen object that controls how this plot draws (out)lines.
		/// </summary>
		// Token: 0x06011886 RID: 71814 RVA: 0x00187B64 File Offset: 0x00185D64
		public void SetPen(vtkPen pen)
		{
			vtkPlot3D.vtkPlot3D_SetPen_21(base.GetCppThis(), (pen == null) ? default(HandleRef) : pen.GetCppThis());
		}

		// Token: 0x06011887 RID: 71815
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot3D_SetSelection_22(HandleRef pThis, HandleRef id);

		/// <summary>
		/// Set/get the selection array for the plot.
		/// </summary>
		// Token: 0x06011888 RID: 71816 RVA: 0x00187B94 File Offset: 0x00185D94
		public virtual void SetSelection(vtkIdTypeArray id)
		{
			vtkPlot3D.vtkPlot3D_SetSelection_22(base.GetCppThis(), (id == null) ? default(HandleRef) : id.GetCppThis());
		}

		// Token: 0x06011889 RID: 71817
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot3D_SetSelectionPen_23(HandleRef pThis, HandleRef pen);

		/// <summary>
		/// Set/get the vtkPen object that controls how this plot draws (out)lines.
		/// </summary>
		// Token: 0x0601188A RID: 71818 RVA: 0x00187BC4 File Offset: 0x00185DC4
		public void SetSelectionPen(vtkPen pen)
		{
			vtkPlot3D.vtkPlot3D_SetSelectionPen_23(base.GetCppThis(), (pen == null) ? default(HandleRef) : pen.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400143A RID: 5178
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlot3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400143B RID: 5179
		public new static readonly string MRClassNameKey = "class vtkPlot3D";
	}
}
