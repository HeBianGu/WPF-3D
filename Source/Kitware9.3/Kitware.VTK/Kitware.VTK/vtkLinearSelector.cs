using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLinearSelector
	/// </summary>
	/// <remarks>
	///    select cells intersecting a line (possibly broken)
	///
	///
	/// This filter takes a vtkCompositeDataSet as input and a line segment as parameter.
	/// It outputs a vtkSelection identifying all the cells intersecting the given line segment.
	///
	/// @par Thanks:
	/// This class has been initially developed in the frame of CEA's Love visualization software
	/// development &lt;br&gt; CEA/DIF - Commissariat a l'Energie Atomique, Centre DAM Ile-De-France &lt;br&gt; BP12,
	/// F-91297 Arpajon, France. &lt;br&gt; Modified and integrated into VTK, Kitware SAS 2012 This class was
	/// implemented by Thierry Carrard, Charles Pignerol, and Philippe Pebay.
	/// </remarks>
	// Token: 0x0200041C RID: 1052
	public class vtkLinearSelector : vtkSelectionAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C630 RID: 50736 RVA: 0x00113C6D File Offset: 0x00111E6D
		static vtkLinearSelector()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLinearSelector.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinearSelector"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C631 RID: 50737 RVA: 0x00113C95 File Offset: 0x00111E95
		public vtkLinearSelector(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C632 RID: 50738
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearSelector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C633 RID: 50739 RVA: 0x00113CA4 File Offset: 0x00111EA4
		public new static vtkLinearSelector New()
		{
			vtkLinearSelector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearSelector.vtkLinearSelector_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C634 RID: 50740 RVA: 0x00113CF8 File Offset: 0x00111EF8
		public vtkLinearSelector() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLinearSelector.vtkLinearSelector_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C635 RID: 50741 RVA: 0x00113D3C File Offset: 0x00111F3C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C636 RID: 50742
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearSelector_GetEndPoint_01(HandleRef pThis);

		/// <summary>
		/// Set/Get end point of intersecting segment
		/// </summary>
		// Token: 0x0600C637 RID: 50743 RVA: 0x00113D48 File Offset: 0x00111F48
		public virtual double[] GetEndPoint()
		{
			IntPtr intPtr = vtkLinearSelector.vtkLinearSelector_GetEndPoint_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C638 RID: 50744
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearSelector_GetEndPoint_02(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get end point of intersecting segment
		/// </summary>
		// Token: 0x0600C639 RID: 50745 RVA: 0x00113D90 File Offset: 0x00111F90
		public virtual void GetEndPoint(IntPtr data)
		{
			vtkLinearSelector.vtkLinearSelector_GetEndPoint_02(base.GetCppThis(), data);
		}

		// Token: 0x0600C63A RID: 50746
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLinearSelector_GetIncludeVertices_03(HandleRef pThis);

		/// <summary>
		/// Set/Get whether lines vertice are included in selection
		/// </summary>
		// Token: 0x0600C63B RID: 50747 RVA: 0x00113DA0 File Offset: 0x00111FA0
		public virtual bool GetIncludeVertices()
		{
			return vtkLinearSelector.vtkLinearSelector_GetIncludeVertices_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600C63C RID: 50748
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinearSelector_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C63D RID: 50749 RVA: 0x00113DC8 File Offset: 0x00111FC8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLinearSelector.vtkLinearSelector_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600C63E RID: 50750
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinearSelector_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C63F RID: 50751 RVA: 0x00113DE8 File Offset: 0x00111FE8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLinearSelector.vtkLinearSelector_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600C640 RID: 50752
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearSelector_GetPoints_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the list of points defining the intersecting broken line
		/// </summary>
		// Token: 0x0600C641 RID: 50753 RVA: 0x00113E04 File Offset: 0x00112004
		public virtual vtkPoints GetPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearSelector.vtkLinearSelector_GetPoints_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600C642 RID: 50754
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearSelector_GetStartPoint_07(HandleRef pThis);

		/// <summary>
		/// Set/Get starting point of intersecting segment
		/// </summary>
		// Token: 0x0600C643 RID: 50755 RVA: 0x00113E74 File Offset: 0x00112074
		public virtual double[] GetStartPoint()
		{
			IntPtr intPtr = vtkLinearSelector.vtkLinearSelector_GetStartPoint_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C644 RID: 50756
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearSelector_GetStartPoint_08(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get starting point of intersecting segment
		/// </summary>
		// Token: 0x0600C645 RID: 50757 RVA: 0x00113EBC File Offset: 0x001120BC
		public virtual void GetStartPoint(IntPtr data)
		{
			vtkLinearSelector.vtkLinearSelector_GetStartPoint_08(base.GetCppThis(), data);
		}

		// Token: 0x0600C646 RID: 50758
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLinearSelector_GetTolerance_09(HandleRef pThis);

		/// <summary>
		/// Set/Get tolerance to be used by intersection algorithm
		/// </summary>
		// Token: 0x0600C647 RID: 50759 RVA: 0x00113ECC File Offset: 0x001120CC
		public virtual double GetTolerance()
		{
			return vtkLinearSelector.vtkLinearSelector_GetTolerance_09(base.GetCppThis());
		}

		// Token: 0x0600C648 RID: 50760
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLinearSelector_GetVertexEliminationTolerance_10(HandleRef pThis);

		/// <summary>
		/// Set/Get relative tolerance for vertex elimination
		/// </summary>
		// Token: 0x0600C649 RID: 50761 RVA: 0x00113EEC File Offset: 0x001120EC
		public virtual double GetVertexEliminationTolerance()
		{
			return vtkLinearSelector.vtkLinearSelector_GetVertexEliminationTolerance_10(base.GetCppThis());
		}

		// Token: 0x0600C64A RID: 50762
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLinearSelector_GetVertexEliminationToleranceMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get relative tolerance for vertex elimination
		/// </summary>
		// Token: 0x0600C64B RID: 50763 RVA: 0x00113F0C File Offset: 0x0011210C
		public virtual double GetVertexEliminationToleranceMaxValue()
		{
			return vtkLinearSelector.vtkLinearSelector_GetVertexEliminationToleranceMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0600C64C RID: 50764
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLinearSelector_GetVertexEliminationToleranceMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set/Get relative tolerance for vertex elimination
		/// </summary>
		// Token: 0x0600C64D RID: 50765 RVA: 0x00113F2C File Offset: 0x0011212C
		public virtual double GetVertexEliminationToleranceMinValue()
		{
			return vtkLinearSelector.vtkLinearSelector_GetVertexEliminationToleranceMinValue_12(base.GetCppThis());
		}

		// Token: 0x0600C64E RID: 50766
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearSelector_IncludeVerticesOff_13(HandleRef pThis);

		/// <summary>
		/// Set/Get whether lines vertice are included in selection
		/// </summary>
		// Token: 0x0600C64F RID: 50767 RVA: 0x00113F4B File Offset: 0x0011214B
		public virtual void IncludeVerticesOff()
		{
			vtkLinearSelector.vtkLinearSelector_IncludeVerticesOff_13(base.GetCppThis());
		}

		// Token: 0x0600C650 RID: 50768
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearSelector_IncludeVerticesOn_14(HandleRef pThis);

		/// <summary>
		/// Set/Get whether lines vertice are included in selection
		/// </summary>
		// Token: 0x0600C651 RID: 50769 RVA: 0x00113F5A File Offset: 0x0011215A
		public virtual void IncludeVerticesOn()
		{
			vtkLinearSelector.vtkLinearSelector_IncludeVerticesOn_14(base.GetCppThis());
		}

		// Token: 0x0600C652 RID: 50770
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinearSelector_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C653 RID: 50771 RVA: 0x00113F6C File Offset: 0x0011216C
		public override int IsA(string type)
		{
			return vtkLinearSelector.vtkLinearSelector_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x0600C654 RID: 50772
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinearSelector_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C655 RID: 50773 RVA: 0x00113F8C File Offset: 0x0011218C
		public new static int IsTypeOf(string type)
		{
			return vtkLinearSelector.vtkLinearSelector_IsTypeOf_16(type);
		}

		// Token: 0x0600C656 RID: 50774
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearSelector_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C657 RID: 50775 RVA: 0x00113FA8 File Offset: 0x001121A8
		public new vtkLinearSelector NewInstance()
		{
			vtkLinearSelector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearSelector.vtkLinearSelector_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C658 RID: 50776
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearSelector_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C659 RID: 50777 RVA: 0x00114004 File Offset: 0x00112204
		public new static vtkLinearSelector SafeDownCast(vtkObjectBase o)
		{
			vtkLinearSelector vtkLinearSelector = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearSelector.vtkLinearSelector_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLinearSelector = (vtkLinearSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLinearSelector.Register(null);
				}
			}
			return vtkLinearSelector;
		}

		// Token: 0x0600C65A RID: 50778
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearSelector_SetEndPoint_20(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get end point of intersecting segment
		/// </summary>
		// Token: 0x0600C65B RID: 50779 RVA: 0x00114083 File Offset: 0x00112283
		public virtual void SetEndPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkLinearSelector.vtkLinearSelector_SetEndPoint_20(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600C65C RID: 50780
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearSelector_SetEndPoint_21(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get end point of intersecting segment
		/// </summary>
		// Token: 0x0600C65D RID: 50781 RVA: 0x00114095 File Offset: 0x00112295
		public virtual void SetEndPoint(IntPtr _arg)
		{
			vtkLinearSelector.vtkLinearSelector_SetEndPoint_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C65E RID: 50782
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearSelector_SetIncludeVertices_22(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether lines vertice are included in selection
		/// </summary>
		// Token: 0x0600C65F RID: 50783 RVA: 0x001140A5 File Offset: 0x001122A5
		public virtual void SetIncludeVertices(bool _arg)
		{
			vtkLinearSelector.vtkLinearSelector_SetIncludeVertices_22(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600C660 RID: 50784
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearSelector_SetPoints_23(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the list of points defining the intersecting broken line
		/// </summary>
		// Token: 0x0600C661 RID: 50785 RVA: 0x001140C0 File Offset: 0x001122C0
		public virtual void SetPoints(vtkPoints arg0)
		{
			vtkLinearSelector.vtkLinearSelector_SetPoints_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600C662 RID: 50786
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearSelector_SetStartPoint_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get starting point of intersecting segment
		/// </summary>
		// Token: 0x0600C663 RID: 50787 RVA: 0x001140EF File Offset: 0x001122EF
		public virtual void SetStartPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkLinearSelector.vtkLinearSelector_SetStartPoint_24(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600C664 RID: 50788
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearSelector_SetStartPoint_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get starting point of intersecting segment
		/// </summary>
		// Token: 0x0600C665 RID: 50789 RVA: 0x00114101 File Offset: 0x00112301
		public virtual void SetStartPoint(IntPtr _arg)
		{
			vtkLinearSelector.vtkLinearSelector_SetStartPoint_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C666 RID: 50790
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearSelector_SetTolerance_26(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get tolerance to be used by intersection algorithm
		/// </summary>
		// Token: 0x0600C667 RID: 50791 RVA: 0x00114111 File Offset: 0x00112311
		public virtual void SetTolerance(double _arg)
		{
			vtkLinearSelector.vtkLinearSelector_SetTolerance_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C668 RID: 50792
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearSelector_SetVertexEliminationTolerance_27(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get relative tolerance for vertex elimination
		/// </summary>
		// Token: 0x0600C669 RID: 50793 RVA: 0x00114121 File Offset: 0x00112321
		public virtual void SetVertexEliminationTolerance(double _arg)
		{
			vtkLinearSelector.vtkLinearSelector_SetVertexEliminationTolerance_27(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EC9 RID: 3785
		public new const string MRFullTypeName = "Kitware.VTK.vtkLinearSelector";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ECA RID: 3786
		public new static readonly string MRClassNameKey = "class vtkLinearSelector";
	}
}
