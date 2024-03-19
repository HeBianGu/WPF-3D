using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDistancePolyDataFilter
	///
	///
	/// Computes the signed distance from one vtkPolyData to another. The
	/// signed distance to the second input is computed at every point in
	/// the first input using vtkImplicitPolyDataDistance. Optionally, the signed
	/// distance to the first input at every point in the second input can
	/// be computed. This may be enabled by calling
	/// ComputeSecondDistanceOn().
	///
	/// If the signed distance is not desired, the unsigned distance can be
	/// computed by calling SignedDistanceOff(). The signed distance field
	/// may be negated by calling NegateDistanceOn();
	///
	/// Directions can be computed in conjunction with distances by calling
	/// ComputeDirectionsOn().
	///
	/// This code was contributed in the VTK Journal paper:
	/// "Boolean Operations on Surfaces in VTK Without External Libraries"
	/// by Cory Quammen, Chris Weigle C., Russ Taylor
	/// http://hdl.handle.net/10380/3262
	/// http://www.midasjournal.org/browse/publication/797
	/// </summary>
	// Token: 0x02000899 RID: 2201
	public class vtkDistancePolyDataFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016DC5 RID: 93637 RVA: 0x00202077 File Offset: 0x00200277
		static vtkDistancePolyDataFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDistancePolyDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistancePolyDataFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016DC6 RID: 93638 RVA: 0x0020209F File Offset: 0x0020029F
		public vtkDistancePolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016DC7 RID: 93639
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistancePolyDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016DC8 RID: 93640 RVA: 0x002020B0 File Offset: 0x002002B0
		public new static vtkDistancePolyDataFilter New()
		{
			vtkDistancePolyDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistancePolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016DC9 RID: 93641 RVA: 0x00202104 File Offset: 0x00200304
		public vtkDistancePolyDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016DCA RID: 93642 RVA: 0x00202148 File Offset: 0x00200348
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016DCB RID: 93643
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistancePolyDataFilter_ComputeCellCenterDistanceOff_01(HandleRef pThis);

		/// <summary>
		/// Enable/disable computation of cell-center distance to the
		/// second poly data. Defaults to on for backwards compatibility.
		///
		/// If the first poly data consists of just vertex cells,
		/// computing point and cell-center distances is redundant.
		/// </summary>
		// Token: 0x06016DCC RID: 93644 RVA: 0x00202153 File Offset: 0x00200353
		public virtual void ComputeCellCenterDistanceOff()
		{
			vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_ComputeCellCenterDistanceOff_01(base.GetCppThis());
		}

		// Token: 0x06016DCD RID: 93645
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistancePolyDataFilter_ComputeCellCenterDistanceOn_02(HandleRef pThis);

		/// <summary>
		/// Enable/disable computation of cell-center distance to the
		/// second poly data. Defaults to on for backwards compatibility.
		///
		/// If the first poly data consists of just vertex cells,
		/// computing point and cell-center distances is redundant.
		/// </summary>
		// Token: 0x06016DCE RID: 93646 RVA: 0x00202162 File Offset: 0x00200362
		public virtual void ComputeCellCenterDistanceOn()
		{
			vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_ComputeCellCenterDistanceOn_02(base.GetCppThis());
		}

		// Token: 0x06016DCF RID: 93647
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistancePolyDataFilter_ComputeDirectionOff_03(HandleRef pThis);

		/// <summary>
		/// Enable/disable computation of unit directions for the distances.
		/// Defaults to off for backwards compatibility.
		/// </summary>
		// Token: 0x06016DD0 RID: 93648 RVA: 0x00202171 File Offset: 0x00200371
		public virtual void ComputeDirectionOff()
		{
			vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_ComputeDirectionOff_03(base.GetCppThis());
		}

		// Token: 0x06016DD1 RID: 93649
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistancePolyDataFilter_ComputeDirectionOn_04(HandleRef pThis);

		/// <summary>
		/// Enable/disable computation of unit directions for the distances.
		/// Defaults to off for backwards compatibility.
		/// </summary>
		// Token: 0x06016DD2 RID: 93650 RVA: 0x00202180 File Offset: 0x00200380
		public virtual void ComputeDirectionOn()
		{
			vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_ComputeDirectionOn_04(base.GetCppThis());
		}

		// Token: 0x06016DD3 RID: 93651
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistancePolyDataFilter_ComputeSecondDistanceOff_05(HandleRef pThis);

		/// <summary>
		/// Enable/disable computation of a second output poly data with the
		/// distance from the first poly data at each point. Defaults to on.
		/// </summary>
		// Token: 0x06016DD4 RID: 93652 RVA: 0x0020218F File Offset: 0x0020038F
		public virtual void ComputeSecondDistanceOff()
		{
			vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_ComputeSecondDistanceOff_05(base.GetCppThis());
		}

		// Token: 0x06016DD5 RID: 93653
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistancePolyDataFilter_ComputeSecondDistanceOn_06(HandleRef pThis);

		/// <summary>
		/// Enable/disable computation of a second output poly data with the
		/// distance from the first poly data at each point. Defaults to on.
		/// </summary>
		// Token: 0x06016DD6 RID: 93654 RVA: 0x0020219E File Offset: 0x0020039E
		public virtual void ComputeSecondDistanceOn()
		{
			vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_ComputeSecondDistanceOn_06(base.GetCppThis());
		}

		// Token: 0x06016DD7 RID: 93655
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistancePolyDataFilter_GetComputeCellCenterDistance_07(HandleRef pThis);

		/// <summary>
		/// Enable/disable computation of cell-center distance to the
		/// second poly data. Defaults to on for backwards compatibility.
		///
		/// If the first poly data consists of just vertex cells,
		/// computing point and cell-center distances is redundant.
		/// </summary>
		// Token: 0x06016DD8 RID: 93656 RVA: 0x002021B0 File Offset: 0x002003B0
		public virtual int GetComputeCellCenterDistance()
		{
			return vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_GetComputeCellCenterDistance_07(base.GetCppThis());
		}

		// Token: 0x06016DD9 RID: 93657
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistancePolyDataFilter_GetComputeDirection_08(HandleRef pThis);

		/// <summary>
		/// Enable/disable computation of unit directions for the distances.
		/// Defaults to off for backwards compatibility.
		/// </summary>
		// Token: 0x06016DDA RID: 93658 RVA: 0x002021D0 File Offset: 0x002003D0
		public virtual int GetComputeDirection()
		{
			return vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_GetComputeDirection_08(base.GetCppThis());
		}

		// Token: 0x06016DDB RID: 93659
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistancePolyDataFilter_GetComputeSecondDistance_09(HandleRef pThis);

		/// <summary>
		/// Enable/disable computation of a second output poly data with the
		/// distance from the first poly data at each point. Defaults to on.
		/// </summary>
		// Token: 0x06016DDC RID: 93660 RVA: 0x002021F0 File Offset: 0x002003F0
		public virtual int GetComputeSecondDistance()
		{
			return vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_GetComputeSecondDistance_09(base.GetCppThis());
		}

		// Token: 0x06016DDD RID: 93661
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistancePolyDataFilter_GetNegateDistance_10(HandleRef pThis);

		/// <summary>
		/// Enable/disable negation of the distance values. Defaults to
		/// off. Has no effect if SignedDistance is off.
		/// </summary>
		// Token: 0x06016DDE RID: 93662 RVA: 0x00202210 File Offset: 0x00200410
		public virtual int GetNegateDistance()
		{
			return vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_GetNegateDistance_10(base.GetCppThis());
		}

		// Token: 0x06016DDF RID: 93663
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistancePolyDataFilter_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016DE0 RID: 93664 RVA: 0x00202230 File Offset: 0x00200430
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x06016DE1 RID: 93665
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistancePolyDataFilter_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016DE2 RID: 93666 RVA: 0x00202250 File Offset: 0x00200450
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x06016DE3 RID: 93667
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistancePolyDataFilter_GetSecondDistanceOutput_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the second output, which is a copy of the second input with an
		/// additional distance scalar field.
		/// Note this will return a valid data object only after this-&gt;Update() is
		/// called.
		/// </summary>
		// Token: 0x06016DE4 RID: 93668 RVA: 0x0020226C File Offset: 0x0020046C
		public vtkPolyData GetSecondDistanceOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_GetSecondDistanceOutput_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06016DE5 RID: 93669
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistancePolyDataFilter_GetSignedDistance_14(HandleRef pThis);

		/// <summary>
		/// Enable/disable computation of the signed distance between
		/// the first poly data and the second poly data. Defaults to on.
		/// </summary>
		// Token: 0x06016DE6 RID: 93670 RVA: 0x002022DC File Offset: 0x002004DC
		public virtual int GetSignedDistance()
		{
			return vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_GetSignedDistance_14(base.GetCppThis());
		}

		// Token: 0x06016DE7 RID: 93671
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistancePolyDataFilter_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016DE8 RID: 93672 RVA: 0x002022FC File Offset: 0x002004FC
		public override int IsA(string type)
		{
			return vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x06016DE9 RID: 93673
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistancePolyDataFilter_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016DEA RID: 93674 RVA: 0x0020231C File Offset: 0x0020051C
		public new static int IsTypeOf(string type)
		{
			return vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_IsTypeOf_16(type);
		}

		// Token: 0x06016DEB RID: 93675
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistancePolyDataFilter_NegateDistanceOff_17(HandleRef pThis);

		/// <summary>
		/// Enable/disable negation of the distance values. Defaults to
		/// off. Has no effect if SignedDistance is off.
		/// </summary>
		// Token: 0x06016DEC RID: 93676 RVA: 0x00202336 File Offset: 0x00200536
		public virtual void NegateDistanceOff()
		{
			vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_NegateDistanceOff_17(base.GetCppThis());
		}

		// Token: 0x06016DED RID: 93677
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistancePolyDataFilter_NegateDistanceOn_18(HandleRef pThis);

		/// <summary>
		/// Enable/disable negation of the distance values. Defaults to
		/// off. Has no effect if SignedDistance is off.
		/// </summary>
		// Token: 0x06016DEE RID: 93678 RVA: 0x00202345 File Offset: 0x00200545
		public virtual void NegateDistanceOn()
		{
			vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_NegateDistanceOn_18(base.GetCppThis());
		}

		// Token: 0x06016DEF RID: 93679
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistancePolyDataFilter_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016DF0 RID: 93680 RVA: 0x00202354 File Offset: 0x00200554
		public new vtkDistancePolyDataFilter NewInstance()
		{
			vtkDistancePolyDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistancePolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016DF1 RID: 93681
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistancePolyDataFilter_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016DF2 RID: 93682 RVA: 0x002023B0 File Offset: 0x002005B0
		public new static vtkDistancePolyDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkDistancePolyDataFilter vtkDistancePolyDataFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistancePolyDataFilter = (vtkDistancePolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistancePolyDataFilter.Register(null);
				}
			}
			return vtkDistancePolyDataFilter;
		}

		// Token: 0x06016DF3 RID: 93683
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistancePolyDataFilter_SetComputeCellCenterDistance_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable computation of cell-center distance to the
		/// second poly data. Defaults to on for backwards compatibility.
		///
		/// If the first poly data consists of just vertex cells,
		/// computing point and cell-center distances is redundant.
		/// </summary>
		// Token: 0x06016DF4 RID: 93684 RVA: 0x0020242F File Offset: 0x0020062F
		public virtual void SetComputeCellCenterDistance(int _arg)
		{
			vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_SetComputeCellCenterDistance_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06016DF5 RID: 93685
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistancePolyDataFilter_SetComputeDirection_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable computation of unit directions for the distances.
		/// Defaults to off for backwards compatibility.
		/// </summary>
		// Token: 0x06016DF6 RID: 93686 RVA: 0x0020243F File Offset: 0x0020063F
		public virtual void SetComputeDirection(int _arg)
		{
			vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_SetComputeDirection_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06016DF7 RID: 93687
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistancePolyDataFilter_SetComputeSecondDistance_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable computation of a second output poly data with the
		/// distance from the first poly data at each point. Defaults to on.
		/// </summary>
		// Token: 0x06016DF8 RID: 93688 RVA: 0x0020244F File Offset: 0x0020064F
		public virtual void SetComputeSecondDistance(int _arg)
		{
			vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_SetComputeSecondDistance_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06016DF9 RID: 93689
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistancePolyDataFilter_SetNegateDistance_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable negation of the distance values. Defaults to
		/// off. Has no effect if SignedDistance is off.
		/// </summary>
		// Token: 0x06016DFA RID: 93690 RVA: 0x0020245F File Offset: 0x0020065F
		public virtual void SetNegateDistance(int _arg)
		{
			vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_SetNegateDistance_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06016DFB RID: 93691
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistancePolyDataFilter_SetSignedDistance_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable computation of the signed distance between
		/// the first poly data and the second poly data. Defaults to on.
		/// </summary>
		// Token: 0x06016DFC RID: 93692 RVA: 0x0020246F File Offset: 0x0020066F
		public virtual void SetSignedDistance(int _arg)
		{
			vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_SetSignedDistance_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06016DFD RID: 93693
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistancePolyDataFilter_SignedDistanceOff_27(HandleRef pThis);

		/// <summary>
		/// Enable/disable computation of the signed distance between
		/// the first poly data and the second poly data. Defaults to on.
		/// </summary>
		// Token: 0x06016DFE RID: 93694 RVA: 0x0020247F File Offset: 0x0020067F
		public virtual void SignedDistanceOff()
		{
			vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_SignedDistanceOff_27(base.GetCppThis());
		}

		// Token: 0x06016DFF RID: 93695
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistancePolyDataFilter_SignedDistanceOn_28(HandleRef pThis);

		/// <summary>
		/// Enable/disable computation of the signed distance between
		/// the first poly data and the second poly data. Defaults to on.
		/// </summary>
		// Token: 0x06016E00 RID: 93696 RVA: 0x0020248E File Offset: 0x0020068E
		public virtual void SignedDistanceOn()
		{
			vtkDistancePolyDataFilter.vtkDistancePolyDataFilter_SignedDistanceOn_28(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001993 RID: 6547
		public new const string MRFullTypeName = "Kitware.VTK.vtkDistancePolyDataFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001994 RID: 6548
		public new static readonly string MRClassNameKey = "class vtkDistancePolyDataFilter";
	}
}
