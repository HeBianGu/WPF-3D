using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTransformToGrid
	/// </summary>
	/// <remarks>
	///    create a grid for a vtkGridTransform
	///
	/// vtkTransformToGrid takes any transform as input and produces a grid
	/// for use by a vtkGridTransform.  This can be used, for example, to
	/// invert a grid transform, concatenate two grid transforms, or to
	/// convert a thin plate spline transform into a grid transform.
	/// </remarks>
	/// <seealso>
	///
	/// vtkGridTransform vtkThinPlateSplineTransform vtkAbstractTransform
	/// </seealso>
	// Token: 0x0200061E RID: 1566
	public class vtkTransformToGrid : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010FD4 RID: 69588 RVA: 0x0017AA04 File Offset: 0x00178C04
		static vtkTransformToGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransformToGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransformToGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010FD5 RID: 69589 RVA: 0x0017AA2C File Offset: 0x00178C2C
		public vtkTransformToGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010FD6 RID: 69590
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformToGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FD7 RID: 69591 RVA: 0x0017AA3C File Offset: 0x00178C3C
		public new static vtkTransformToGrid New()
		{
			vtkTransformToGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformToGrid.vtkTransformToGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformToGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FD8 RID: 69592 RVA: 0x0017AA90 File Offset: 0x00178C90
		public vtkTransformToGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTransformToGrid.vtkTransformToGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010FD9 RID: 69593 RVA: 0x0017AAD4 File Offset: 0x00178CD4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010FDA RID: 69594
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTransformToGrid_GetDisplacementScale_01(HandleRef pThis);

		/// <summary>
		/// Get the scale and shift to convert integer grid elements into
		/// real values:  dx = scale*di + shift.  If the grid is of double type,
		/// then scale = 1 and shift = 0.
		/// </summary>
		// Token: 0x06010FDB RID: 69595 RVA: 0x0017AAE0 File Offset: 0x00178CE0
		public double GetDisplacementScale()
		{
			return vtkTransformToGrid.vtkTransformToGrid_GetDisplacementScale_01(base.GetCppThis());
		}

		// Token: 0x06010FDC RID: 69596
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTransformToGrid_GetDisplacementShift_02(HandleRef pThis);

		/// <summary>
		/// Get the scale and shift to convert integer grid elements into
		/// real values:  dx = scale*di + shift.  If the grid is of double type,
		/// then scale = 1 and shift = 0.
		/// </summary>
		// Token: 0x06010FDD RID: 69597 RVA: 0x0017AB00 File Offset: 0x00178D00
		public double GetDisplacementShift()
		{
			return vtkTransformToGrid.vtkTransformToGrid_GetDisplacementShift_02(base.GetCppThis());
		}

		// Token: 0x06010FDE RID: 69598
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformToGrid_GetGridExtent_03(HandleRef pThis);

		/// <summary>
		/// Get/Set the extent of the grid.
		/// </summary>
		// Token: 0x06010FDF RID: 69599 RVA: 0x0017AB20 File Offset: 0x00178D20
		public virtual int[] GetGridExtent()
		{
			IntPtr intPtr = vtkTransformToGrid.vtkTransformToGrid_GetGridExtent_03(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06010FE0 RID: 69600
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformToGrid_GetGridExtent_04(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Get/Set the extent of the grid.
		/// </summary>
		// Token: 0x06010FE1 RID: 69601 RVA: 0x0017AB68 File Offset: 0x00178D68
		public virtual void GetGridExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkTransformToGrid.vtkTransformToGrid_GetGridExtent_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06010FE2 RID: 69602
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformToGrid_GetGridExtent_05(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the extent of the grid.
		/// </summary>
		// Token: 0x06010FE3 RID: 69603 RVA: 0x0017AB80 File Offset: 0x00178D80
		public virtual void GetGridExtent(IntPtr _arg)
		{
			vtkTransformToGrid.vtkTransformToGrid_GetGridExtent_05(base.GetCppThis(), _arg);
		}

		// Token: 0x06010FE4 RID: 69604
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformToGrid_GetGridOrigin_06(HandleRef pThis);

		/// <summary>
		/// Get/Set the origin of the grid.
		/// </summary>
		// Token: 0x06010FE5 RID: 69605 RVA: 0x0017AB90 File Offset: 0x00178D90
		public virtual double[] GetGridOrigin()
		{
			IntPtr intPtr = vtkTransformToGrid.vtkTransformToGrid_GetGridOrigin_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06010FE6 RID: 69606
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformToGrid_GetGridOrigin_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get/Set the origin of the grid.
		/// </summary>
		// Token: 0x06010FE7 RID: 69607 RVA: 0x0017ABD8 File Offset: 0x00178DD8
		public virtual void GetGridOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkTransformToGrid.vtkTransformToGrid_GetGridOrigin_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06010FE8 RID: 69608
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformToGrid_GetGridOrigin_08(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the origin of the grid.
		/// </summary>
		// Token: 0x06010FE9 RID: 69609 RVA: 0x0017ABEA File Offset: 0x00178DEA
		public virtual void GetGridOrigin(IntPtr _arg)
		{
			vtkTransformToGrid.vtkTransformToGrid_GetGridOrigin_08(base.GetCppThis(), _arg);
		}

		// Token: 0x06010FEA RID: 69610
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformToGrid_GetGridScalarType_09(HandleRef pThis);

		/// <summary>
		/// Get/Set the scalar type of the grid.  The default is float.
		/// </summary>
		// Token: 0x06010FEB RID: 69611 RVA: 0x0017ABFC File Offset: 0x00178DFC
		public virtual int GetGridScalarType()
		{
			return vtkTransformToGrid.vtkTransformToGrid_GetGridScalarType_09(base.GetCppThis());
		}

		// Token: 0x06010FEC RID: 69612
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformToGrid_GetGridSpacing_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the spacing between samples in the grid.
		/// </summary>
		// Token: 0x06010FED RID: 69613 RVA: 0x0017AC1C File Offset: 0x00178E1C
		public virtual double[] GetGridSpacing()
		{
			IntPtr intPtr = vtkTransformToGrid.vtkTransformToGrid_GetGridSpacing_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06010FEE RID: 69614
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformToGrid_GetGridSpacing_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get/Set the spacing between samples in the grid.
		/// </summary>
		// Token: 0x06010FEF RID: 69615 RVA: 0x0017AC64 File Offset: 0x00178E64
		public virtual void GetGridSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkTransformToGrid.vtkTransformToGrid_GetGridSpacing_11(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06010FF0 RID: 69616
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformToGrid_GetGridSpacing_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the spacing between samples in the grid.
		/// </summary>
		// Token: 0x06010FF1 RID: 69617 RVA: 0x0017AC76 File Offset: 0x00178E76
		public virtual void GetGridSpacing(IntPtr _arg)
		{
			vtkTransformToGrid.vtkTransformToGrid_GetGridSpacing_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06010FF2 RID: 69618
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformToGrid_GetInput_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the transform which will be converted into a grid.
		/// </summary>
		// Token: 0x06010FF3 RID: 69619 RVA: 0x0017AC88 File Offset: 0x00178E88
		public virtual vtkAbstractTransform GetInput()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformToGrid.vtkTransformToGrid_GetInput_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		// Token: 0x06010FF4 RID: 69620
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransformToGrid_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FF5 RID: 69621 RVA: 0x0017ACF8 File Offset: 0x00178EF8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTransformToGrid.vtkTransformToGrid_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x06010FF6 RID: 69622
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransformToGrid_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FF7 RID: 69623 RVA: 0x0017AD18 File Offset: 0x00178F18
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTransformToGrid.vtkTransformToGrid_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x06010FF8 RID: 69624
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformToGrid_GetOutput_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06010FF9 RID: 69625 RVA: 0x0017AD34 File Offset: 0x00178F34
		public vtkImageData GetOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformToGrid.vtkTransformToGrid_GetOutput_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06010FFA RID: 69626
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformToGrid_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FFB RID: 69627 RVA: 0x0017ADA4 File Offset: 0x00178FA4
		public override int IsA(string type)
		{
			return vtkTransformToGrid.vtkTransformToGrid_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x06010FFC RID: 69628
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformToGrid_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FFD RID: 69629 RVA: 0x0017ADC4 File Offset: 0x00178FC4
		public new static int IsTypeOf(string type)
		{
			return vtkTransformToGrid.vtkTransformToGrid_IsTypeOf_18(type);
		}

		// Token: 0x06010FFE RID: 69630
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformToGrid_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FFF RID: 69631 RVA: 0x0017ADE0 File Offset: 0x00178FE0
		public new vtkTransformToGrid NewInstance()
		{
			vtkTransformToGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformToGrid.vtkTransformToGrid_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformToGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011000 RID: 69632
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformToGrid_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011001 RID: 69633 RVA: 0x0017AE3C File Offset: 0x0017903C
		public new static vtkTransformToGrid SafeDownCast(vtkObjectBase o)
		{
			vtkTransformToGrid vtkTransformToGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformToGrid.vtkTransformToGrid_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransformToGrid = (vtkTransformToGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransformToGrid.Register(null);
				}
			}
			return vtkTransformToGrid;
		}

		// Token: 0x06011002 RID: 69634
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformToGrid_SetGridExtent_22(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Get/Set the extent of the grid.
		/// </summary>
		// Token: 0x06011003 RID: 69635 RVA: 0x0017AEBB File Offset: 0x001790BB
		public virtual void SetGridExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridExtent_22(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06011004 RID: 69636
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformToGrid_SetGridExtent_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the extent of the grid.
		/// </summary>
		// Token: 0x06011005 RID: 69637 RVA: 0x0017AED3 File Offset: 0x001790D3
		public virtual void SetGridExtent(IntPtr _arg)
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridExtent_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06011006 RID: 69638
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformToGrid_SetGridOrigin_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Get/Set the origin of the grid.
		/// </summary>
		// Token: 0x06011007 RID: 69639 RVA: 0x0017AEE3 File Offset: 0x001790E3
		public virtual void SetGridOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridOrigin_24(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06011008 RID: 69640
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformToGrid_SetGridOrigin_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the origin of the grid.
		/// </summary>
		// Token: 0x06011009 RID: 69641 RVA: 0x0017AEF5 File Offset: 0x001790F5
		public virtual void SetGridOrigin(IntPtr _arg)
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridOrigin_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0601100A RID: 69642
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformToGrid_SetGridScalarType_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the scalar type of the grid.  The default is float.
		/// </summary>
		// Token: 0x0601100B RID: 69643 RVA: 0x0017AF05 File Offset: 0x00179105
		public virtual void SetGridScalarType(int _arg)
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridScalarType_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0601100C RID: 69644
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformToGrid_SetGridScalarTypeToChar_27(HandleRef pThis);

		/// <summary>
		/// Get/Set the scalar type of the grid.  The default is float.
		/// </summary>
		// Token: 0x0601100D RID: 69645 RVA: 0x0017AF15 File Offset: 0x00179115
		public void SetGridScalarTypeToChar()
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridScalarTypeToChar_27(base.GetCppThis());
		}

		// Token: 0x0601100E RID: 69646
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformToGrid_SetGridScalarTypeToDouble_28(HandleRef pThis);

		/// <summary>
		/// Get/Set the scalar type of the grid.  The default is float.
		/// </summary>
		// Token: 0x0601100F RID: 69647 RVA: 0x0017AF24 File Offset: 0x00179124
		public void SetGridScalarTypeToDouble()
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridScalarTypeToDouble_28(base.GetCppThis());
		}

		// Token: 0x06011010 RID: 69648
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformToGrid_SetGridScalarTypeToFloat_29(HandleRef pThis);

		/// <summary>
		/// Get/Set the scalar type of the grid.  The default is float.
		/// </summary>
		// Token: 0x06011011 RID: 69649 RVA: 0x0017AF33 File Offset: 0x00179133
		public void SetGridScalarTypeToFloat()
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridScalarTypeToFloat_29(base.GetCppThis());
		}

		// Token: 0x06011012 RID: 69650
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformToGrid_SetGridScalarTypeToShort_30(HandleRef pThis);

		/// <summary>
		/// Get/Set the scalar type of the grid.  The default is float.
		/// </summary>
		// Token: 0x06011013 RID: 69651 RVA: 0x0017AF42 File Offset: 0x00179142
		public void SetGridScalarTypeToShort()
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridScalarTypeToShort_30(base.GetCppThis());
		}

		// Token: 0x06011014 RID: 69652
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformToGrid_SetGridScalarTypeToUnsignedChar_31(HandleRef pThis);

		/// <summary>
		/// Get/Set the scalar type of the grid.  The default is float.
		/// </summary>
		// Token: 0x06011015 RID: 69653 RVA: 0x0017AF51 File Offset: 0x00179151
		public void SetGridScalarTypeToUnsignedChar()
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridScalarTypeToUnsignedChar_31(base.GetCppThis());
		}

		// Token: 0x06011016 RID: 69654
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformToGrid_SetGridScalarTypeToUnsignedShort_32(HandleRef pThis);

		/// <summary>
		/// Get/Set the scalar type of the grid.  The default is float.
		/// </summary>
		// Token: 0x06011017 RID: 69655 RVA: 0x0017AF60 File Offset: 0x00179160
		public void SetGridScalarTypeToUnsignedShort()
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridScalarTypeToUnsignedShort_32(base.GetCppThis());
		}

		// Token: 0x06011018 RID: 69656
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformToGrid_SetGridSpacing_33(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Get/Set the spacing between samples in the grid.
		/// </summary>
		// Token: 0x06011019 RID: 69657 RVA: 0x0017AF6F File Offset: 0x0017916F
		public virtual void SetGridSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridSpacing_33(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601101A RID: 69658
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformToGrid_SetGridSpacing_34(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the spacing between samples in the grid.
		/// </summary>
		// Token: 0x0601101B RID: 69659 RVA: 0x0017AF81 File Offset: 0x00179181
		public virtual void SetGridSpacing(IntPtr _arg)
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridSpacing_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0601101C RID: 69660
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformToGrid_SetInput_35(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the transform which will be converted into a grid.
		/// </summary>
		// Token: 0x0601101D RID: 69661 RVA: 0x0017AF94 File Offset: 0x00179194
		public virtual void SetInput(vtkAbstractTransform arg0)
		{
			vtkTransformToGrid.vtkTransformToGrid_SetInput_35(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013A0 RID: 5024
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransformToGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013A1 RID: 5025
		public new static readonly string MRClassNameKey = "class vtkTransformToGrid";
	}
}
