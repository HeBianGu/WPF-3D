using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageThresholdConnectivity
	/// </summary>
	/// <remarks>
	///    Flood fill an image region.
	///
	/// vtkImageThresholdConnectivity will perform a flood fill on an image,
	/// given upper and lower pixel intensity thresholds. It works similarly
	/// to vtkImageThreshold, but also allows the user to set seed points
	/// to limit the threshold operation to contiguous regions of the image.
	/// The filled region, or the "inside", will be passed through to the
	/// output by default, while the "outside" will be replaced with zeros.
	/// This behavior can be changed by using the ReplaceIn() and ReplaceOut()
	/// methods.  The scalar type of the output is the same as the input.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageThreshold
	/// @par Thanks:
	/// Thanks to David Gobbi for contributing this class to VTK.
	/// </seealso>
	// Token: 0x02000251 RID: 593
	public class vtkImageThresholdConnectivity : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006D9A RID: 28058 RVA: 0x0009E2A3 File Offset: 0x0009C4A3
		static vtkImageThresholdConnectivity()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageThresholdConnectivity.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageThresholdConnectivity"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006D9B RID: 28059 RVA: 0x0009E2CB File Offset: 0x0009C4CB
		public vtkImageThresholdConnectivity(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006D9C RID: 28060
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageThresholdConnectivity_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D9D RID: 28061 RVA: 0x0009E2DC File Offset: 0x0009C4DC
		public new static vtkImageThresholdConnectivity New()
		{
			vtkImageThresholdConnectivity result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageThresholdConnectivity)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D9E RID: 28062 RVA: 0x0009E330 File Offset: 0x0009C530
		public vtkImageThresholdConnectivity() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006D9F RID: 28063 RVA: 0x0009E374 File Offset: 0x0009C574
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006DA0 RID: 28064
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageThresholdConnectivity_GetActiveComponent_01(HandleRef pThis);

		/// <summary>
		/// For multi-component images, you can set which component will be
		/// used for the threshold checks.
		/// </summary>
		// Token: 0x06006DA1 RID: 28065 RVA: 0x0009E380 File Offset: 0x0009C580
		public virtual int GetActiveComponent()
		{
			return vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetActiveComponent_01(base.GetCppThis());
		}

		// Token: 0x06006DA2 RID: 28066
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageThresholdConnectivity_GetInValue_02(HandleRef pThis);

		/// <summary>
		/// If ReplaceIn is set, the filled region will be replaced by this value.
		/// </summary>
		// Token: 0x06006DA3 RID: 28067 RVA: 0x0009E3A0 File Offset: 0x0009C5A0
		public virtual double GetInValue()
		{
			return vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetInValue_02(base.GetCppThis());
		}

		// Token: 0x06006DA4 RID: 28068
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageThresholdConnectivity_GetLowerThreshold_03(HandleRef pThis);

		/// <summary>
		/// Get the Upper and Lower thresholds.
		/// </summary>
		// Token: 0x06006DA5 RID: 28069 RVA: 0x0009E3C0 File Offset: 0x0009C5C0
		public virtual double GetLowerThreshold()
		{
			return vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetLowerThreshold_03(base.GetCppThis());
		}

		// Token: 0x06006DA6 RID: 28070
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImageThresholdConnectivity_GetMTime_04(HandleRef pThis);

		/// <summary>
		/// Override the MTime to account for the seed points.
		/// </summary>
		// Token: 0x06006DA7 RID: 28071 RVA: 0x0009E3E0 File Offset: 0x0009C5E0
		public override ulong GetMTime()
		{
			return vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetMTime_04(base.GetCppThis());
		}

		// Token: 0x06006DA8 RID: 28072
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageThresholdConnectivity_GetNeighborhoodFraction_05(HandleRef pThis);

		/// <summary>
		/// The fraction of the neighborhood that must be within the thresholds.
		/// The default value is 0.5.
		/// </summary>
		// Token: 0x06006DA9 RID: 28073 RVA: 0x0009E400 File Offset: 0x0009C600
		public virtual double GetNeighborhoodFraction()
		{
			return vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetNeighborhoodFraction_05(base.GetCppThis());
		}

		// Token: 0x06006DAA RID: 28074
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageThresholdConnectivity_GetNeighborhoodFractionMaxValue_06(HandleRef pThis);

		/// <summary>
		/// The fraction of the neighborhood that must be within the thresholds.
		/// The default value is 0.5.
		/// </summary>
		// Token: 0x06006DAB RID: 28075 RVA: 0x0009E420 File Offset: 0x0009C620
		public virtual double GetNeighborhoodFractionMaxValue()
		{
			return vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetNeighborhoodFractionMaxValue_06(base.GetCppThis());
		}

		// Token: 0x06006DAC RID: 28076
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageThresholdConnectivity_GetNeighborhoodFractionMinValue_07(HandleRef pThis);

		/// <summary>
		/// The fraction of the neighborhood that must be within the thresholds.
		/// The default value is 0.5.
		/// </summary>
		// Token: 0x06006DAD RID: 28077 RVA: 0x0009E440 File Offset: 0x0009C640
		public virtual double GetNeighborhoodFractionMinValue()
		{
			return vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetNeighborhoodFractionMinValue_07(base.GetCppThis());
		}

		// Token: 0x06006DAE RID: 28078
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageThresholdConnectivity_GetNeighborhoodRadius_08(HandleRef pThis);

		/// <summary>
		/// The radius of the neighborhood that must be within the threshold
		/// values in order for the voxel to be included in the mask.  The
		/// default radius is zero (one single voxel).  The radius is measured
		/// in voxels.
		/// </summary>
		// Token: 0x06006DAF RID: 28079 RVA: 0x0009E460 File Offset: 0x0009C660
		public virtual double[] GetNeighborhoodRadius()
		{
			IntPtr intPtr = vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetNeighborhoodRadius_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006DB0 RID: 28080
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_GetNeighborhoodRadius_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// The radius of the neighborhood that must be within the threshold
		/// values in order for the voxel to be included in the mask.  The
		/// default radius is zero (one single voxel).  The radius is measured
		/// in voxels.
		/// </summary>
		// Token: 0x06006DB1 RID: 28081 RVA: 0x0009E4A8 File Offset: 0x0009C6A8
		public virtual void GetNeighborhoodRadius(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetNeighborhoodRadius_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06006DB2 RID: 28082
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_GetNeighborhoodRadius_10(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The radius of the neighborhood that must be within the threshold
		/// values in order for the voxel to be included in the mask.  The
		/// default radius is zero (one single voxel).  The radius is measured
		/// in voxels.
		/// </summary>
		// Token: 0x06006DB3 RID: 28083 RVA: 0x0009E4BA File Offset: 0x0009C6BA
		public virtual void GetNeighborhoodRadius(IntPtr _arg)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetNeighborhoodRadius_10(base.GetCppThis(), _arg);
		}

		// Token: 0x06006DB4 RID: 28084
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageThresholdConnectivity_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006DB5 RID: 28085 RVA: 0x0009E4CC File Offset: 0x0009C6CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x06006DB6 RID: 28086
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageThresholdConnectivity_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006DB7 RID: 28087 RVA: 0x0009E4EC File Offset: 0x0009C6EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x06006DB8 RID: 28088
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageThresholdConnectivity_GetNumberOfInVoxels_13(HandleRef pThis);

		/// <summary>
		/// After the filter has executed, use GetNumberOfVoxels() to find
		/// out how many voxels were filled.
		/// </summary>
		// Token: 0x06006DB9 RID: 28089 RVA: 0x0009E508 File Offset: 0x0009C708
		public virtual int GetNumberOfInVoxels()
		{
			return vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetNumberOfInVoxels_13(base.GetCppThis());
		}

		// Token: 0x06006DBA RID: 28090
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageThresholdConnectivity_GetOutValue_14(HandleRef pThis);

		/// <summary>
		/// If ReplaceOut is set, outside the fill will be replaced by this value.
		/// </summary>
		// Token: 0x06006DBB RID: 28091 RVA: 0x0009E528 File Offset: 0x0009C728
		public virtual double GetOutValue()
		{
			return vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetOutValue_14(base.GetCppThis());
		}

		// Token: 0x06006DBC RID: 28092
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageThresholdConnectivity_GetReplaceIn_15(HandleRef pThis);

		/// <summary>
		/// Replace the filled region by the value set by SetInValue().
		/// </summary>
		// Token: 0x06006DBD RID: 28093 RVA: 0x0009E548 File Offset: 0x0009C748
		public virtual int GetReplaceIn()
		{
			return vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetReplaceIn_15(base.GetCppThis());
		}

		// Token: 0x06006DBE RID: 28094
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageThresholdConnectivity_GetReplaceOut_16(HandleRef pThis);

		/// <summary>
		/// Replace the filled region by the value set by SetInValue().
		/// </summary>
		// Token: 0x06006DBF RID: 28095 RVA: 0x0009E568 File Offset: 0x0009C768
		public virtual int GetReplaceOut()
		{
			return vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetReplaceOut_16(base.GetCppThis());
		}

		// Token: 0x06006DC0 RID: 28096
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageThresholdConnectivity_GetSeedPoints_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the seeds.  The seeds are in real data coordinates, not in
		/// voxel index locations.
		/// </summary>
		// Token: 0x06006DC1 RID: 28097 RVA: 0x0009E588 File Offset: 0x0009C788
		public virtual vtkPoints GetSeedPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetSeedPoints_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06006DC2 RID: 28098
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageThresholdConnectivity_GetSliceRangeX_18(HandleRef pThis);

		/// <summary>
		/// Limit the flood to a range of slices in the specified direction.
		/// </summary>
		// Token: 0x06006DC3 RID: 28099 RVA: 0x0009E5F8 File Offset: 0x0009C7F8
		public virtual int[] GetSliceRangeX()
		{
			IntPtr intPtr = vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetSliceRangeX_18(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006DC4 RID: 28100
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_GetSliceRangeX_19(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Limit the flood to a range of slices in the specified direction.
		/// </summary>
		// Token: 0x06006DC5 RID: 28101 RVA: 0x0009E640 File Offset: 0x0009C840
		public virtual void GetSliceRangeX(ref int _arg1, ref int _arg2)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetSliceRangeX_19(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06006DC6 RID: 28102
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_GetSliceRangeX_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Limit the flood to a range of slices in the specified direction.
		/// </summary>
		// Token: 0x06006DC7 RID: 28103 RVA: 0x0009E651 File Offset: 0x0009C851
		public virtual void GetSliceRangeX(IntPtr _arg)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetSliceRangeX_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06006DC8 RID: 28104
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageThresholdConnectivity_GetSliceRangeY_21(HandleRef pThis);

		/// <summary>
		/// Limit the flood to a range of slices in the specified direction.
		/// </summary>
		// Token: 0x06006DC9 RID: 28105 RVA: 0x0009E664 File Offset: 0x0009C864
		public virtual int[] GetSliceRangeY()
		{
			IntPtr intPtr = vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetSliceRangeY_21(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006DCA RID: 28106
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_GetSliceRangeY_22(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Limit the flood to a range of slices in the specified direction.
		/// </summary>
		// Token: 0x06006DCB RID: 28107 RVA: 0x0009E6AC File Offset: 0x0009C8AC
		public virtual void GetSliceRangeY(ref int _arg1, ref int _arg2)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetSliceRangeY_22(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06006DCC RID: 28108
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_GetSliceRangeY_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Limit the flood to a range of slices in the specified direction.
		/// </summary>
		// Token: 0x06006DCD RID: 28109 RVA: 0x0009E6BD File Offset: 0x0009C8BD
		public virtual void GetSliceRangeY(IntPtr _arg)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetSliceRangeY_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06006DCE RID: 28110
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageThresholdConnectivity_GetSliceRangeZ_24(HandleRef pThis);

		/// <summary>
		/// Limit the flood to a range of slices in the specified direction.
		/// </summary>
		// Token: 0x06006DCF RID: 28111 RVA: 0x0009E6D0 File Offset: 0x0009C8D0
		public virtual int[] GetSliceRangeZ()
		{
			IntPtr intPtr = vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetSliceRangeZ_24(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006DD0 RID: 28112
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_GetSliceRangeZ_25(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Limit the flood to a range of slices in the specified direction.
		/// </summary>
		// Token: 0x06006DD1 RID: 28113 RVA: 0x0009E718 File Offset: 0x0009C918
		public virtual void GetSliceRangeZ(ref int _arg1, ref int _arg2)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetSliceRangeZ_25(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06006DD2 RID: 28114
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_GetSliceRangeZ_26(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Limit the flood to a range of slices in the specified direction.
		/// </summary>
		// Token: 0x06006DD3 RID: 28115 RVA: 0x0009E729 File Offset: 0x0009C929
		public virtual void GetSliceRangeZ(IntPtr _arg)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetSliceRangeZ_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06006DD4 RID: 28116
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageThresholdConnectivity_GetStencil_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a stencil that will be used to limit the flood fill to
		/// an arbitrarily-shaped region of the image.
		/// </summary>
		// Token: 0x06006DD5 RID: 28117 RVA: 0x0009E73C File Offset: 0x0009C93C
		public vtkImageStencilData GetStencil()
		{
			vtkImageStencilData vtkImageStencilData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetStencil_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilData = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilData.Register(null);
				}
			}
			return vtkImageStencilData;
		}

		// Token: 0x06006DD6 RID: 28118
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageThresholdConnectivity_GetUpperThreshold_28(HandleRef pThis);

		/// <summary>
		/// Get the Upper and Lower thresholds.
		/// </summary>
		// Token: 0x06006DD7 RID: 28119 RVA: 0x0009E7AC File Offset: 0x0009C9AC
		public virtual double GetUpperThreshold()
		{
			return vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_GetUpperThreshold_28(base.GetCppThis());
		}

		// Token: 0x06006DD8 RID: 28120
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageThresholdConnectivity_IsA_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006DD9 RID: 28121 RVA: 0x0009E7CC File Offset: 0x0009C9CC
		public override int IsA(string type)
		{
			return vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_IsA_29(base.GetCppThis(), type);
		}

		// Token: 0x06006DDA RID: 28122
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageThresholdConnectivity_IsTypeOf_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006DDB RID: 28123 RVA: 0x0009E7EC File Offset: 0x0009C9EC
		public new static int IsTypeOf(string type)
		{
			return vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_IsTypeOf_30(type);
		}

		// Token: 0x06006DDC RID: 28124
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageThresholdConnectivity_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006DDD RID: 28125 RVA: 0x0009E808 File Offset: 0x0009CA08
		public new vtkImageThresholdConnectivity NewInstance()
		{
			vtkImageThresholdConnectivity result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageThresholdConnectivity)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006DDE RID: 28126
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_ReplaceInOff_33(HandleRef pThis);

		/// <summary>
		/// Replace the filled region by the value set by SetInValue().
		/// </summary>
		// Token: 0x06006DDF RID: 28127 RVA: 0x0009E862 File Offset: 0x0009CA62
		public virtual void ReplaceInOff()
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_ReplaceInOff_33(base.GetCppThis());
		}

		// Token: 0x06006DE0 RID: 28128
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_ReplaceInOn_34(HandleRef pThis);

		/// <summary>
		/// Replace the filled region by the value set by SetInValue().
		/// </summary>
		// Token: 0x06006DE1 RID: 28129 RVA: 0x0009E871 File Offset: 0x0009CA71
		public virtual void ReplaceInOn()
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_ReplaceInOn_34(base.GetCppThis());
		}

		// Token: 0x06006DE2 RID: 28130
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_ReplaceOutOff_35(HandleRef pThis);

		/// <summary>
		/// Replace the filled region by the value set by SetInValue().
		/// </summary>
		// Token: 0x06006DE3 RID: 28131 RVA: 0x0009E880 File Offset: 0x0009CA80
		public virtual void ReplaceOutOff()
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_ReplaceOutOff_35(base.GetCppThis());
		}

		// Token: 0x06006DE4 RID: 28132
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_ReplaceOutOn_36(HandleRef pThis);

		/// <summary>
		/// Replace the filled region by the value set by SetInValue().
		/// </summary>
		// Token: 0x06006DE5 RID: 28133 RVA: 0x0009E88F File Offset: 0x0009CA8F
		public virtual void ReplaceOutOn()
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_ReplaceOutOn_36(base.GetCppThis());
		}

		// Token: 0x06006DE6 RID: 28134
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageThresholdConnectivity_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006DE7 RID: 28135 RVA: 0x0009E8A0 File Offset: 0x0009CAA0
		public new static vtkImageThresholdConnectivity SafeDownCast(vtkObjectBase o)
		{
			vtkImageThresholdConnectivity vtkImageThresholdConnectivity = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageThresholdConnectivity = (vtkImageThresholdConnectivity)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageThresholdConnectivity.Register(null);
				}
			}
			return vtkImageThresholdConnectivity;
		}

		// Token: 0x06006DE8 RID: 28136
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_SetActiveComponent_38(HandleRef pThis, int _arg);

		/// <summary>
		/// For multi-component images, you can set which component will be
		/// used for the threshold checks.
		/// </summary>
		// Token: 0x06006DE9 RID: 28137 RVA: 0x0009E91F File Offset: 0x0009CB1F
		public virtual void SetActiveComponent(int _arg)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_SetActiveComponent_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06006DEA RID: 28138
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_SetInValue_39(HandleRef pThis, double val);

		/// <summary>
		/// If ReplaceIn is set, the filled region will be replaced by this value.
		/// </summary>
		// Token: 0x06006DEB RID: 28139 RVA: 0x0009E92F File Offset: 0x0009CB2F
		public void SetInValue(double val)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_SetInValue_39(base.GetCppThis(), val);
		}

		// Token: 0x06006DEC RID: 28140
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_SetNeighborhoodFraction_40(HandleRef pThis, double _arg);

		/// <summary>
		/// The fraction of the neighborhood that must be within the thresholds.
		/// The default value is 0.5.
		/// </summary>
		// Token: 0x06006DED RID: 28141 RVA: 0x0009E93F File Offset: 0x0009CB3F
		public virtual void SetNeighborhoodFraction(double _arg)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_SetNeighborhoodFraction_40(base.GetCppThis(), _arg);
		}

		// Token: 0x06006DEE RID: 28142
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_SetNeighborhoodRadius_41(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// The radius of the neighborhood that must be within the threshold
		/// values in order for the voxel to be included in the mask.  The
		/// default radius is zero (one single voxel).  The radius is measured
		/// in voxels.
		/// </summary>
		// Token: 0x06006DEF RID: 28143 RVA: 0x0009E94F File Offset: 0x0009CB4F
		public virtual void SetNeighborhoodRadius(double _arg1, double _arg2, double _arg3)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_SetNeighborhoodRadius_41(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06006DF0 RID: 28144
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_SetNeighborhoodRadius_42(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The radius of the neighborhood that must be within the threshold
		/// values in order for the voxel to be included in the mask.  The
		/// default radius is zero (one single voxel).  The radius is measured
		/// in voxels.
		/// </summary>
		// Token: 0x06006DF1 RID: 28145 RVA: 0x0009E961 File Offset: 0x0009CB61
		public virtual void SetNeighborhoodRadius(IntPtr _arg)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_SetNeighborhoodRadius_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06006DF2 RID: 28146
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_SetOutValue_43(HandleRef pThis, double val);

		/// <summary>
		/// If ReplaceOut is set, outside the fill will be replaced by this value.
		/// </summary>
		// Token: 0x06006DF3 RID: 28147 RVA: 0x0009E971 File Offset: 0x0009CB71
		public void SetOutValue(double val)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_SetOutValue_43(base.GetCppThis(), val);
		}

		// Token: 0x06006DF4 RID: 28148
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_SetReplaceIn_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Replace the filled region by the value set by SetInValue().
		/// </summary>
		// Token: 0x06006DF5 RID: 28149 RVA: 0x0009E981 File Offset: 0x0009CB81
		public virtual void SetReplaceIn(int _arg)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_SetReplaceIn_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06006DF6 RID: 28150
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_SetReplaceOut_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Replace the filled region by the value set by SetInValue().
		/// </summary>
		// Token: 0x06006DF7 RID: 28151 RVA: 0x0009E991 File Offset: 0x0009CB91
		public virtual void SetReplaceOut(int _arg)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_SetReplaceOut_45(base.GetCppThis(), _arg);
		}

		// Token: 0x06006DF8 RID: 28152
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_SetSeedPoints_46(HandleRef pThis, HandleRef points);

		/// <summary>
		/// Set the seeds.  The seeds are in real data coordinates, not in
		/// voxel index locations.
		/// </summary>
		// Token: 0x06006DF9 RID: 28153 RVA: 0x0009E9A4 File Offset: 0x0009CBA4
		public void SetSeedPoints(vtkPoints points)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_SetSeedPoints_46(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x06006DFA RID: 28154
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_SetSliceRangeX_47(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Limit the flood to a range of slices in the specified direction.
		/// </summary>
		// Token: 0x06006DFB RID: 28155 RVA: 0x0009E9D3 File Offset: 0x0009CBD3
		public virtual void SetSliceRangeX(int _arg1, int _arg2)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_SetSliceRangeX_47(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06006DFC RID: 28156
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_SetSliceRangeX_48(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Limit the flood to a range of slices in the specified direction.
		/// </summary>
		// Token: 0x06006DFD RID: 28157 RVA: 0x0009E9E4 File Offset: 0x0009CBE4
		public void SetSliceRangeX(IntPtr _arg)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_SetSliceRangeX_48(base.GetCppThis(), _arg);
		}

		// Token: 0x06006DFE RID: 28158
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_SetSliceRangeY_49(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Limit the flood to a range of slices in the specified direction.
		/// </summary>
		// Token: 0x06006DFF RID: 28159 RVA: 0x0009E9F4 File Offset: 0x0009CBF4
		public virtual void SetSliceRangeY(int _arg1, int _arg2)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_SetSliceRangeY_49(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06006E00 RID: 28160
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_SetSliceRangeY_50(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Limit the flood to a range of slices in the specified direction.
		/// </summary>
		// Token: 0x06006E01 RID: 28161 RVA: 0x0009EA05 File Offset: 0x0009CC05
		public void SetSliceRangeY(IntPtr _arg)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_SetSliceRangeY_50(base.GetCppThis(), _arg);
		}

		// Token: 0x06006E02 RID: 28162
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_SetSliceRangeZ_51(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Limit the flood to a range of slices in the specified direction.
		/// </summary>
		// Token: 0x06006E03 RID: 28163 RVA: 0x0009EA15 File Offset: 0x0009CC15
		public virtual void SetSliceRangeZ(int _arg1, int _arg2)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_SetSliceRangeZ_51(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06006E04 RID: 28164
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_SetSliceRangeZ_52(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Limit the flood to a range of slices in the specified direction.
		/// </summary>
		// Token: 0x06006E05 RID: 28165 RVA: 0x0009EA26 File Offset: 0x0009CC26
		public void SetSliceRangeZ(IntPtr _arg)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_SetSliceRangeZ_52(base.GetCppThis(), _arg);
		}

		// Token: 0x06006E06 RID: 28166
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_SetStencilData_53(HandleRef pThis, HandleRef stencil);

		/// <summary>
		/// Specify a stencil that will be used to limit the flood fill to
		/// an arbitrarily-shaped region of the image.
		/// </summary>
		// Token: 0x06006E07 RID: 28167 RVA: 0x0009EA38 File Offset: 0x0009CC38
		public virtual void SetStencilData(vtkImageStencilData stencil)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_SetStencilData_53(base.GetCppThis(), (stencil == null) ? default(HandleRef) : stencil.GetCppThis());
		}

		// Token: 0x06006E08 RID: 28168
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_ThresholdBetween_54(HandleRef pThis, double lower, double upper);

		/// <summary>
		/// Values within this range will be filled, where the range includes
		/// values that are exactly equal to the lower and upper thresholds.
		/// </summary>
		// Token: 0x06006E09 RID: 28169 RVA: 0x0009EA67 File Offset: 0x0009CC67
		public void ThresholdBetween(double lower, double upper)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_ThresholdBetween_54(base.GetCppThis(), lower, upper);
		}

		// Token: 0x06006E0A RID: 28170
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_ThresholdByLower_55(HandleRef pThis, double thresh);

		/// <summary>
		/// Values less than or equal to this threshold will be filled.
		/// </summary>
		// Token: 0x06006E0B RID: 28171 RVA: 0x0009EA78 File Offset: 0x0009CC78
		public void ThresholdByLower(double thresh)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_ThresholdByLower_55(base.GetCppThis(), thresh);
		}

		// Token: 0x06006E0C RID: 28172
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThresholdConnectivity_ThresholdByUpper_56(HandleRef pThis, double thresh);

		/// <summary>
		/// Values greater than or equal to this threshold will be filled.
		/// </summary>
		// Token: 0x06006E0D RID: 28173 RVA: 0x0009EA88 File Offset: 0x0009CC88
		public void ThresholdByUpper(double thresh)
		{
			vtkImageThresholdConnectivity.vtkImageThresholdConnectivity_ThresholdByUpper_56(base.GetCppThis(), thresh);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000997 RID: 2455
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageThresholdConnectivity";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000998 RID: 2456
		public new static readonly string MRClassNameKey = "class vtkImageThresholdConnectivity";
	}
}
