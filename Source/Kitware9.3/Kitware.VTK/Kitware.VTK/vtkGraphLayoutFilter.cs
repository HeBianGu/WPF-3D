using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGraphLayoutFilter
	/// </summary>
	/// <remarks>
	///    nice layout of undirected graphs in 3D
	///
	/// vtkGraphLayoutFilter will reposition a network of nodes, connected by
	/// lines or polylines, into a more pleasing arrangement. The class
	/// implements a simple force-directed placement algorithm
	/// (Fruchterman &amp; Reingold "Graph Drawing by Force-directed Placement"
	/// Software-Practice and Experience 21(11) 1991).
	///
	/// The input to the filter is a vtkPolyData representing the undirected
	/// graphs. A graph is represented by a set of polylines and/or lines.
	/// The output is also a vtkPolyData, where the point positions have been
	/// modified. To use the filter, specify whether you wish the layout to
	/// occur in 2D or 3D; the bounds in which the graph should lie (note that you
	/// can just use automatic bounds computation); and modify the cool down
	/// rate (controls the final process of simulated annealing).
	/// </remarks>
	// Token: 0x020008A3 RID: 2211
	public class vtkGraphLayoutFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016F0F RID: 93967 RVA: 0x00203BC9 File Offset: 0x00201DC9
		static vtkGraphLayoutFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphLayoutFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphLayoutFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016F10 RID: 93968 RVA: 0x00203BF1 File Offset: 0x00201DF1
		public vtkGraphLayoutFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016F11 RID: 93969
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F12 RID: 93970 RVA: 0x00203C00 File Offset: 0x00201E00
		public new static vtkGraphLayoutFilter New()
		{
			vtkGraphLayoutFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphLayoutFilter.vtkGraphLayoutFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphLayoutFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F13 RID: 93971 RVA: 0x00203C54 File Offset: 0x00201E54
		public vtkGraphLayoutFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGraphLayoutFilter.vtkGraphLayoutFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016F14 RID: 93972 RVA: 0x00203C98 File Offset: 0x00201E98
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016F15 RID: 93973
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutFilter_AutomaticBoundsComputationOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic graph bounds calculation. If this
		/// boolean is off, then the manually specified GraphBounds is used.
		/// If on, then the input's bounds us used as the graph bounds.
		/// </summary>
		// Token: 0x06016F16 RID: 93974 RVA: 0x00203CA3 File Offset: 0x00201EA3
		public virtual void AutomaticBoundsComputationOff()
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_AutomaticBoundsComputationOff_01(base.GetCppThis());
		}

		// Token: 0x06016F17 RID: 93975
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutFilter_AutomaticBoundsComputationOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic graph bounds calculation. If this
		/// boolean is off, then the manually specified GraphBounds is used.
		/// If on, then the input's bounds us used as the graph bounds.
		/// </summary>
		// Token: 0x06016F18 RID: 93976 RVA: 0x00203CB2 File Offset: 0x00201EB2
		public virtual void AutomaticBoundsComputationOn()
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_AutomaticBoundsComputationOn_02(base.GetCppThis());
		}

		// Token: 0x06016F19 RID: 93977
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayoutFilter_GetAutomaticBoundsComputation_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic graph bounds calculation. If this
		/// boolean is off, then the manually specified GraphBounds is used.
		/// If on, then the input's bounds us used as the graph bounds.
		/// </summary>
		// Token: 0x06016F1A RID: 93978 RVA: 0x00203CC4 File Offset: 0x00201EC4
		public virtual int GetAutomaticBoundsComputation()
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetAutomaticBoundsComputation_03(base.GetCppThis());
		}

		// Token: 0x06016F1B RID: 93979
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGraphLayoutFilter_GetCoolDownRate_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified.
		/// </summary>
		// Token: 0x06016F1C RID: 93980 RVA: 0x00203CE4 File Offset: 0x00201EE4
		public virtual double GetCoolDownRate()
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetCoolDownRate_04(base.GetCppThis());
		}

		// Token: 0x06016F1D RID: 93981
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGraphLayoutFilter_GetCoolDownRateMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified.
		/// </summary>
		// Token: 0x06016F1E RID: 93982 RVA: 0x00203D04 File Offset: 0x00201F04
		public virtual double GetCoolDownRateMaxValue()
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetCoolDownRateMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06016F1F RID: 93983
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGraphLayoutFilter_GetCoolDownRateMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified.
		/// </summary>
		// Token: 0x06016F20 RID: 93984 RVA: 0x00203D24 File Offset: 0x00201F24
		public virtual double GetCoolDownRateMinValue()
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetCoolDownRateMinValue_06(base.GetCppThis());
		}

		// Token: 0x06016F21 RID: 93985
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutFilter_GetGraphBounds_07(HandleRef pThis);

		/// <summary>
		/// Set / get the region in space in which to place the final graph.
		/// The GraphBounds only affects the results if AutomaticBoundsComputation
		/// is off.
		/// </summary>
		// Token: 0x06016F22 RID: 93986 RVA: 0x00203D44 File Offset: 0x00201F44
		public virtual double[] GetGraphBounds()
		{
			IntPtr intPtr = vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetGraphBounds_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06016F23 RID: 93987
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutFilter_GetGraphBounds_08(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / get the region in space in which to place the final graph.
		/// The GraphBounds only affects the results if AutomaticBoundsComputation
		/// is off.
		/// </summary>
		// Token: 0x06016F24 RID: 93988 RVA: 0x00203D8C File Offset: 0x00201F8C
		public virtual void GetGraphBounds(IntPtr data)
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetGraphBounds_08(base.GetCppThis(), data);
		}

		// Token: 0x06016F25 RID: 93989
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayoutFilter_GetMaxNumberOfIterations_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// </summary>
		// Token: 0x06016F26 RID: 93990 RVA: 0x00203D9C File Offset: 0x00201F9C
		public virtual int GetMaxNumberOfIterations()
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetMaxNumberOfIterations_09(base.GetCppThis());
		}

		// Token: 0x06016F27 RID: 93991
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayoutFilter_GetMaxNumberOfIterationsMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// </summary>
		// Token: 0x06016F28 RID: 93992 RVA: 0x00203DBC File Offset: 0x00201FBC
		public virtual int GetMaxNumberOfIterationsMaxValue()
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetMaxNumberOfIterationsMaxValue_10(base.GetCppThis());
		}

		// Token: 0x06016F29 RID: 93993
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayoutFilter_GetMaxNumberOfIterationsMinValue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// </summary>
		// Token: 0x06016F2A RID: 93994 RVA: 0x00203DDC File Offset: 0x00201FDC
		public virtual int GetMaxNumberOfIterationsMinValue()
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetMaxNumberOfIterationsMinValue_11(base.GetCppThis());
		}

		// Token: 0x06016F2B RID: 93995
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphLayoutFilter_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F2C RID: 93996 RVA: 0x00203DFC File Offset: 0x00201FFC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x06016F2D RID: 93997
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphLayoutFilter_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F2E RID: 93998 RVA: 0x00203E1C File Offset: 0x0020201C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x06016F2F RID: 93999
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayoutFilter_GetThreeDimensionalLayout_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified.
		/// </summary>
		// Token: 0x06016F30 RID: 94000 RVA: 0x00203E38 File Offset: 0x00202038
		public virtual int GetThreeDimensionalLayout()
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetThreeDimensionalLayout_14(base.GetCppThis());
		}

		// Token: 0x06016F31 RID: 94001
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayoutFilter_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F32 RID: 94002 RVA: 0x00203E58 File Offset: 0x00202058
		public override int IsA(string type)
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x06016F33 RID: 94003
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayoutFilter_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F34 RID: 94004 RVA: 0x00203E78 File Offset: 0x00202078
		public new static int IsTypeOf(string type)
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_IsTypeOf_16(type);
		}

		// Token: 0x06016F35 RID: 94005
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutFilter_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F36 RID: 94006 RVA: 0x00203E94 File Offset: 0x00202094
		public new vtkGraphLayoutFilter NewInstance()
		{
			vtkGraphLayoutFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphLayoutFilter.vtkGraphLayoutFilter_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphLayoutFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016F37 RID: 94007
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutFilter_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F38 RID: 94008 RVA: 0x00203EF0 File Offset: 0x002020F0
		public new static vtkGraphLayoutFilter SafeDownCast(vtkObjectBase o)
		{
			vtkGraphLayoutFilter vtkGraphLayoutFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphLayoutFilter.vtkGraphLayoutFilter_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphLayoutFilter = (vtkGraphLayoutFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphLayoutFilter.Register(null);
				}
			}
			return vtkGraphLayoutFilter;
		}

		// Token: 0x06016F39 RID: 94009
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutFilter_SetAutomaticBoundsComputation_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off automatic graph bounds calculation. If this
		/// boolean is off, then the manually specified GraphBounds is used.
		/// If on, then the input's bounds us used as the graph bounds.
		/// </summary>
		// Token: 0x06016F3A RID: 94010 RVA: 0x00203F6F File Offset: 0x0020216F
		public virtual void SetAutomaticBoundsComputation(int _arg)
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_SetAutomaticBoundsComputation_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06016F3B RID: 94011
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutFilter_SetCoolDownRate_21(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified.
		/// </summary>
		// Token: 0x06016F3C RID: 94012 RVA: 0x00203F7F File Offset: 0x0020217F
		public virtual void SetCoolDownRate(double _arg)
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_SetCoolDownRate_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06016F3D RID: 94013
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutFilter_SetGraphBounds_22(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set / get the region in space in which to place the final graph.
		/// The GraphBounds only affects the results if AutomaticBoundsComputation
		/// is off.
		/// </summary>
		// Token: 0x06016F3E RID: 94014 RVA: 0x00203F8F File Offset: 0x0020218F
		public virtual void SetGraphBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_SetGraphBounds_22(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06016F3F RID: 94015
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutFilter_SetGraphBounds_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / get the region in space in which to place the final graph.
		/// The GraphBounds only affects the results if AutomaticBoundsComputation
		/// is off.
		/// </summary>
		// Token: 0x06016F40 RID: 94016 RVA: 0x00203FA7 File Offset: 0x002021A7
		public virtual void SetGraphBounds(IntPtr _arg)
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_SetGraphBounds_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06016F41 RID: 94017
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutFilter_SetMaxNumberOfIterations_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// </summary>
		// Token: 0x06016F42 RID: 94018 RVA: 0x00203FB7 File Offset: 0x002021B7
		public virtual void SetMaxNumberOfIterations(int _arg)
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_SetMaxNumberOfIterations_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06016F43 RID: 94019
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutFilter_SetThreeDimensionalLayout_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified.
		/// </summary>
		// Token: 0x06016F44 RID: 94020 RVA: 0x00203FC7 File Offset: 0x002021C7
		public virtual void SetThreeDimensionalLayout(int _arg)
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_SetThreeDimensionalLayout_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06016F45 RID: 94021
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutFilter_ThreeDimensionalLayoutOff_26(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified.
		/// </summary>
		// Token: 0x06016F46 RID: 94022 RVA: 0x00203FD7 File Offset: 0x002021D7
		public virtual void ThreeDimensionalLayoutOff()
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_ThreeDimensionalLayoutOff_26(base.GetCppThis());
		}

		// Token: 0x06016F47 RID: 94023
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutFilter_ThreeDimensionalLayoutOn_27(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified.
		/// </summary>
		// Token: 0x06016F48 RID: 94024 RVA: 0x00203FE6 File Offset: 0x002021E6
		public virtual void ThreeDimensionalLayoutOn()
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_ThreeDimensionalLayoutOn_27(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019AC RID: 6572
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphLayoutFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019AD RID: 6573
		public new static readonly string MRClassNameKey = "class vtkGraphLayoutFilter";
	}
}
