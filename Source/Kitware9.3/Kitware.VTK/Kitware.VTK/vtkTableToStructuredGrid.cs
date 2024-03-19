using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTableToStructuredGrid
	/// </summary>
	/// <remarks>
	///    converts vtkTable to a vtkStructuredGrid.
	///
	/// vtkTableToStructuredGrid is a filter that converts an input
	/// vtkTable to a vtkStructuredGrid. It provides API to select columns to use as
	/// points in the output structured grid. The specified dimensions of the output
	/// (specified using SetWholeExtent()) must match the number of rows in the input
	/// table.
	/// </remarks>
	// Token: 0x020008EE RID: 2286
	public class vtkTableToStructuredGrid : vtkStructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060179BB RID: 96699 RVA: 0x00211BC3 File Offset: 0x0020FDC3
		static vtkTableToStructuredGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTableToStructuredGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableToStructuredGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060179BC RID: 96700 RVA: 0x00211BEB File Offset: 0x0020FDEB
		public vtkTableToStructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060179BD RID: 96701
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToStructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060179BE RID: 96702 RVA: 0x00211BFC File Offset: 0x0020FDFC
		public new static vtkTableToStructuredGrid New()
		{
			vtkTableToStructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToStructuredGrid.vtkTableToStructuredGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060179BF RID: 96703 RVA: 0x00211C50 File Offset: 0x0020FE50
		public vtkTableToStructuredGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTableToStructuredGrid.vtkTableToStructuredGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060179C0 RID: 96704 RVA: 0x00211C94 File Offset: 0x0020FE94
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060179C1 RID: 96705
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableToStructuredGrid_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060179C2 RID: 96706 RVA: 0x00211CA0 File Offset: 0x0020FEA0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060179C3 RID: 96707
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableToStructuredGrid_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060179C4 RID: 96708 RVA: 0x00211CC0 File Offset: 0x0020FEC0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060179C5 RID: 96709
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToStructuredGrid_GetWholeExtent_03(HandleRef pThis);

		/// <summary>
		/// Get/Set the whole extents for the image to produce. The size of the image
		/// must match the number of rows in the input table.
		/// </summary>
		// Token: 0x060179C6 RID: 96710 RVA: 0x00211CDC File Offset: 0x0020FEDC
		public virtual int[] GetWholeExtent()
		{
			IntPtr intPtr = vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetWholeExtent_03(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060179C7 RID: 96711
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToStructuredGrid_GetWholeExtent_04(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Get/Set the whole extents for the image to produce. The size of the image
		/// must match the number of rows in the input table.
		/// </summary>
		// Token: 0x060179C8 RID: 96712 RVA: 0x00211D24 File Offset: 0x0020FF24
		public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetWholeExtent_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x060179C9 RID: 96713
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToStructuredGrid_GetWholeExtent_05(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the whole extents for the image to produce. The size of the image
		/// must match the number of rows in the input table.
		/// </summary>
		// Token: 0x060179CA RID: 96714 RVA: 0x00211D3C File Offset: 0x0020FF3C
		public virtual void GetWholeExtent(IntPtr _arg)
		{
			vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetWholeExtent_05(base.GetCppThis(), _arg);
		}

		// Token: 0x060179CB RID: 96715
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToStructuredGrid_GetXColumn_06(HandleRef pThis);

		/// <summary>
		/// Set the name of the column to use as the X coordinate for the points.
		/// </summary>
		// Token: 0x060179CC RID: 96716 RVA: 0x00211D4C File Offset: 0x0020FF4C
		public virtual string GetXColumn()
		{
			string s = Marshal.PtrToStringAnsi(vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetXColumn_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060179CD RID: 96717
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToStructuredGrid_GetXComponent_07(HandleRef pThis);

		/// <summary>
		/// Specify the component for the column specified using SetXColumn() to
		/// use as the xcoordinate in case the column is a multi-component array.
		/// Default is 0.
		/// </summary>
		// Token: 0x060179CE RID: 96718 RVA: 0x00211D88 File Offset: 0x0020FF88
		public virtual int GetXComponent()
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetXComponent_07(base.GetCppThis());
		}

		// Token: 0x060179CF RID: 96719
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToStructuredGrid_GetXComponentMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Specify the component for the column specified using SetXColumn() to
		/// use as the xcoordinate in case the column is a multi-component array.
		/// Default is 0.
		/// </summary>
		// Token: 0x060179D0 RID: 96720 RVA: 0x00211DA8 File Offset: 0x0020FFA8
		public virtual int GetXComponentMaxValue()
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetXComponentMaxValue_08(base.GetCppThis());
		}

		// Token: 0x060179D1 RID: 96721
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToStructuredGrid_GetXComponentMinValue_09(HandleRef pThis);

		/// <summary>
		/// Specify the component for the column specified using SetXColumn() to
		/// use as the xcoordinate in case the column is a multi-component array.
		/// Default is 0.
		/// </summary>
		// Token: 0x060179D2 RID: 96722 RVA: 0x00211DC8 File Offset: 0x0020FFC8
		public virtual int GetXComponentMinValue()
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetXComponentMinValue_09(base.GetCppThis());
		}

		// Token: 0x060179D3 RID: 96723
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToStructuredGrid_GetYColumn_10(HandleRef pThis);

		/// <summary>
		/// Set the name of the column to use as the Y coordinate for the points.
		/// Default is 0.
		/// </summary>
		// Token: 0x060179D4 RID: 96724 RVA: 0x00211DE8 File Offset: 0x0020FFE8
		public virtual string GetYColumn()
		{
			string s = Marshal.PtrToStringAnsi(vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetYColumn_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060179D5 RID: 96725
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToStructuredGrid_GetYComponent_11(HandleRef pThis);

		/// <summary>
		/// Specify the component for the column specified using SetYColumn() to
		/// use as the Ycoordinate in case the column is a multi-component array.
		/// </summary>
		// Token: 0x060179D6 RID: 96726 RVA: 0x00211E24 File Offset: 0x00210024
		public virtual int GetYComponent()
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetYComponent_11(base.GetCppThis());
		}

		// Token: 0x060179D7 RID: 96727
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToStructuredGrid_GetYComponentMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Specify the component for the column specified using SetYColumn() to
		/// use as the Ycoordinate in case the column is a multi-component array.
		/// </summary>
		// Token: 0x060179D8 RID: 96728 RVA: 0x00211E44 File Offset: 0x00210044
		public virtual int GetYComponentMaxValue()
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetYComponentMaxValue_12(base.GetCppThis());
		}

		// Token: 0x060179D9 RID: 96729
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToStructuredGrid_GetYComponentMinValue_13(HandleRef pThis);

		/// <summary>
		/// Specify the component for the column specified using SetYColumn() to
		/// use as the Ycoordinate in case the column is a multi-component array.
		/// </summary>
		// Token: 0x060179DA RID: 96730 RVA: 0x00211E64 File Offset: 0x00210064
		public virtual int GetYComponentMinValue()
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetYComponentMinValue_13(base.GetCppThis());
		}

		// Token: 0x060179DB RID: 96731
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToStructuredGrid_GetZColumn_14(HandleRef pThis);

		/// <summary>
		/// Set the name of the column to use as the Z coordinate for the points.
		/// Default is 0.
		/// </summary>
		// Token: 0x060179DC RID: 96732 RVA: 0x00211E84 File Offset: 0x00210084
		public virtual string GetZColumn()
		{
			string s = Marshal.PtrToStringAnsi(vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetZColumn_14(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060179DD RID: 96733
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToStructuredGrid_GetZComponent_15(HandleRef pThis);

		/// <summary>
		/// Specify the component for the column specified using SetZColumn() to
		/// use as the Zcoordinate in case the column is a multi-component array.
		/// </summary>
		// Token: 0x060179DE RID: 96734 RVA: 0x00211EC0 File Offset: 0x002100C0
		public virtual int GetZComponent()
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetZComponent_15(base.GetCppThis());
		}

		// Token: 0x060179DF RID: 96735
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToStructuredGrid_GetZComponentMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Specify the component for the column specified using SetZColumn() to
		/// use as the Zcoordinate in case the column is a multi-component array.
		/// </summary>
		// Token: 0x060179E0 RID: 96736 RVA: 0x00211EE0 File Offset: 0x002100E0
		public virtual int GetZComponentMaxValue()
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetZComponentMaxValue_16(base.GetCppThis());
		}

		// Token: 0x060179E1 RID: 96737
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToStructuredGrid_GetZComponentMinValue_17(HandleRef pThis);

		/// <summary>
		/// Specify the component for the column specified using SetZColumn() to
		/// use as the Zcoordinate in case the column is a multi-component array.
		/// </summary>
		// Token: 0x060179E2 RID: 96738 RVA: 0x00211F00 File Offset: 0x00210100
		public virtual int GetZComponentMinValue()
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetZComponentMinValue_17(base.GetCppThis());
		}

		// Token: 0x060179E3 RID: 96739
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToStructuredGrid_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060179E4 RID: 96740 RVA: 0x00211F20 File Offset: 0x00210120
		public override int IsA(string type)
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x060179E5 RID: 96741
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToStructuredGrid_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060179E6 RID: 96742 RVA: 0x00211F40 File Offset: 0x00210140
		public new static int IsTypeOf(string type)
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_IsTypeOf_19(type);
		}

		// Token: 0x060179E7 RID: 96743
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToStructuredGrid_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060179E8 RID: 96744 RVA: 0x00211F5C File Offset: 0x0021015C
		public new vtkTableToStructuredGrid NewInstance()
		{
			vtkTableToStructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToStructuredGrid.vtkTableToStructuredGrid_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060179E9 RID: 96745
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToStructuredGrid_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060179EA RID: 96746 RVA: 0x00211FB8 File Offset: 0x002101B8
		public new static vtkTableToStructuredGrid SafeDownCast(vtkObjectBase o)
		{
			vtkTableToStructuredGrid vtkTableToStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToStructuredGrid.vtkTableToStructuredGrid_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTableToStructuredGrid = (vtkTableToStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTableToStructuredGrid.Register(null);
				}
			}
			return vtkTableToStructuredGrid;
		}

		// Token: 0x060179EB RID: 96747
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToStructuredGrid_SetWholeExtent_23(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Get/Set the whole extents for the image to produce. The size of the image
		/// must match the number of rows in the input table.
		/// </summary>
		// Token: 0x060179EC RID: 96748 RVA: 0x00212037 File Offset: 0x00210237
		public virtual void SetWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkTableToStructuredGrid.vtkTableToStructuredGrid_SetWholeExtent_23(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x060179ED RID: 96749
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToStructuredGrid_SetWholeExtent_24(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the whole extents for the image to produce. The size of the image
		/// must match the number of rows in the input table.
		/// </summary>
		// Token: 0x060179EE RID: 96750 RVA: 0x0021204F File Offset: 0x0021024F
		public virtual void SetWholeExtent(IntPtr _arg)
		{
			vtkTableToStructuredGrid.vtkTableToStructuredGrid_SetWholeExtent_24(base.GetCppThis(), _arg);
		}

		// Token: 0x060179EF RID: 96751
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToStructuredGrid_SetXColumn_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the name of the column to use as the X coordinate for the points.
		/// </summary>
		// Token: 0x060179F0 RID: 96752 RVA: 0x0021205F File Offset: 0x0021025F
		public virtual void SetXColumn(string _arg)
		{
			vtkTableToStructuredGrid.vtkTableToStructuredGrid_SetXColumn_25(base.GetCppThis(), _arg);
		}

		// Token: 0x060179F1 RID: 96753
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToStructuredGrid_SetXComponent_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the component for the column specified using SetXColumn() to
		/// use as the xcoordinate in case the column is a multi-component array.
		/// Default is 0.
		/// </summary>
		// Token: 0x060179F2 RID: 96754 RVA: 0x0021206F File Offset: 0x0021026F
		public virtual void SetXComponent(int _arg)
		{
			vtkTableToStructuredGrid.vtkTableToStructuredGrid_SetXComponent_26(base.GetCppThis(), _arg);
		}

		// Token: 0x060179F3 RID: 96755
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToStructuredGrid_SetYColumn_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the name of the column to use as the Y coordinate for the points.
		/// Default is 0.
		/// </summary>
		// Token: 0x060179F4 RID: 96756 RVA: 0x0021207F File Offset: 0x0021027F
		public virtual void SetYColumn(string _arg)
		{
			vtkTableToStructuredGrid.vtkTableToStructuredGrid_SetYColumn_27(base.GetCppThis(), _arg);
		}

		// Token: 0x060179F5 RID: 96757
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToStructuredGrid_SetYComponent_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the component for the column specified using SetYColumn() to
		/// use as the Ycoordinate in case the column is a multi-component array.
		/// </summary>
		// Token: 0x060179F6 RID: 96758 RVA: 0x0021208F File Offset: 0x0021028F
		public virtual void SetYComponent(int _arg)
		{
			vtkTableToStructuredGrid.vtkTableToStructuredGrid_SetYComponent_28(base.GetCppThis(), _arg);
		}

		// Token: 0x060179F7 RID: 96759
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToStructuredGrid_SetZColumn_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the name of the column to use as the Z coordinate for the points.
		/// Default is 0.
		/// </summary>
		// Token: 0x060179F8 RID: 96760 RVA: 0x0021209F File Offset: 0x0021029F
		public virtual void SetZColumn(string _arg)
		{
			vtkTableToStructuredGrid.vtkTableToStructuredGrid_SetZColumn_29(base.GetCppThis(), _arg);
		}

		// Token: 0x060179F9 RID: 96761
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToStructuredGrid_SetZComponent_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the component for the column specified using SetZColumn() to
		/// use as the Zcoordinate in case the column is a multi-component array.
		/// </summary>
		// Token: 0x060179FA RID: 96762 RVA: 0x002120AF File Offset: 0x002102AF
		public virtual void SetZComponent(int _arg)
		{
			vtkTableToStructuredGrid.vtkTableToStructuredGrid_SetZComponent_30(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A5B RID: 6747
		public new const string MRFullTypeName = "Kitware.VTK.vtkTableToStructuredGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A5C RID: 6748
		public new static readonly string MRClassNameKey = "class vtkTableToStructuredGrid";
	}
}
