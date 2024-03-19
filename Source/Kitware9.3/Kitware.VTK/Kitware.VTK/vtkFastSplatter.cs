using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFastSplatter
	/// </summary>
	/// <remarks>
	///    A splatter optimized for splatting single kernels.
	///
	///
	///
	/// vtkFastSplatter takes any vtkPointSet as input (of which vtkPolyData and
	/// vtkUnstructuredGrid inherit).  Each point in the data set is considered to be
	/// an impulse.  These impulses are convolved with a given splat image.  In other
	/// words, the splat image is added to the final image at every place where there
	/// is an input point.
	///
	/// Note that point and cell data are thrown away.  If you want a sampling
	/// of unstructured points consider vtkGaussianSplatter or vtkShepardMethod.
	///
	/// Use input port 0 for the impulse data (vtkPointSet), and input port 1 for
	/// the splat image (vtkImageData)
	///
	///
	/// @bug
	/// Any point outside of the extents of the image is thrown away, even if it is
	/// close enough such that it's convolution with the splat image would overlap
	/// the extents.
	///
	/// </remarks>
	// Token: 0x020003DF RID: 991
	public class vtkFastSplatter : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600BDEE RID: 48622 RVA: 0x00108F12 File Offset: 0x00107112
		static vtkFastSplatter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFastSplatter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFastSplatter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600BDEF RID: 48623 RVA: 0x00108F3A File Offset: 0x0010713A
		public vtkFastSplatter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600BDF0 RID: 48624
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFastSplatter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BDF1 RID: 48625 RVA: 0x00108F48 File Offset: 0x00107148
		public new static vtkFastSplatter New()
		{
			vtkFastSplatter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFastSplatter.vtkFastSplatter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFastSplatter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BDF2 RID: 48626 RVA: 0x00108F9C File Offset: 0x0010719C
		public vtkFastSplatter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFastSplatter.vtkFastSplatter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600BDF3 RID: 48627 RVA: 0x00108FE0 File Offset: 0x001071E0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600BDF4 RID: 48628
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFastSplatter_GetLimitMode_01(HandleRef pThis);

		/// <summary>
		/// Set/get the way voxel values will be limited.  If this is set to None (the
		/// default), the output can have arbitrarily large values.  If set to clamp,
		/// the output will be clamped to [MinValue,MaxValue].  If set to scale, the
		/// output will be linearly scaled between MinValue and MaxValue.
		/// </summary>
		// Token: 0x0600BDF5 RID: 48629 RVA: 0x00108FEC File Offset: 0x001071EC
		public virtual int GetLimitMode()
		{
			return vtkFastSplatter.vtkFastSplatter_GetLimitMode_01(base.GetCppThis());
		}

		// Token: 0x0600BDF6 RID: 48630
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFastSplatter_GetMaxValue_02(HandleRef pThis);

		/// <summary>
		/// See the LimitMode method.
		/// </summary>
		// Token: 0x0600BDF7 RID: 48631 RVA: 0x0010900C File Offset: 0x0010720C
		public virtual double GetMaxValue()
		{
			return vtkFastSplatter.vtkFastSplatter_GetMaxValue_02(base.GetCppThis());
		}

		// Token: 0x0600BDF8 RID: 48632
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFastSplatter_GetMinValue_03(HandleRef pThis);

		/// <summary>
		/// See the LimitMode method.
		/// </summary>
		// Token: 0x0600BDF9 RID: 48633 RVA: 0x0010902C File Offset: 0x0010722C
		public virtual double GetMinValue()
		{
			return vtkFastSplatter.vtkFastSplatter_GetMinValue_03(base.GetCppThis());
		}

		// Token: 0x0600BDFA RID: 48634
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFastSplatter_GetModelBounds_04(HandleRef pThis);

		/// <summary>
		/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
		/// the sampling is performed. If any of the (min,max) bounds values are
		/// min &gt;= max, then the bounds will be computed automatically from the input
		/// data. Otherwise, the user-specified bounds will be used.
		/// </summary>
		// Token: 0x0600BDFB RID: 48635 RVA: 0x0010904C File Offset: 0x0010724C
		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkFastSplatter.vtkFastSplatter_GetModelBounds_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BDFC RID: 48636
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFastSplatter_GetModelBounds_05(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
		/// the sampling is performed. If any of the (min,max) bounds values are
		/// min &gt;= max, then the bounds will be computed automatically from the input
		/// data. Otherwise, the user-specified bounds will be used.
		/// </summary>
		// Token: 0x0600BDFD RID: 48637 RVA: 0x00109094 File Offset: 0x00107294
		public virtual void GetModelBounds(IntPtr data)
		{
			vtkFastSplatter.vtkFastSplatter_GetModelBounds_05(base.GetCppThis(), data);
		}

		// Token: 0x0600BDFE RID: 48638
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFastSplatter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BDFF RID: 48639 RVA: 0x001090A4 File Offset: 0x001072A4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFastSplatter.vtkFastSplatter_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600BE00 RID: 48640
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFastSplatter_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BE01 RID: 48641 RVA: 0x001090C4 File Offset: 0x001072C4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFastSplatter.vtkFastSplatter_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600BE02 RID: 48642
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFastSplatter_GetNumberOfPointsSplatted_08(HandleRef pThis);

		/// <summary>
		/// This returns the number of points splatted (as opposed to
		/// discarded for being outside the image) during the previous pass.
		/// </summary>
		// Token: 0x0600BE03 RID: 48643 RVA: 0x001090E0 File Offset: 0x001072E0
		public virtual int GetNumberOfPointsSplatted()
		{
			return vtkFastSplatter.vtkFastSplatter_GetNumberOfPointsSplatted_08(base.GetCppThis());
		}

		// Token: 0x0600BE04 RID: 48644
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFastSplatter_GetOutputDimensions_09(HandleRef pThis);

		/// <summary>
		/// Set/get the dimensions of the output image
		/// </summary>
		// Token: 0x0600BE05 RID: 48645 RVA: 0x00109100 File Offset: 0x00107300
		public virtual int[] GetOutputDimensions()
		{
			IntPtr intPtr = vtkFastSplatter.vtkFastSplatter_GetOutputDimensions_09(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BE06 RID: 48646
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFastSplatter_GetOutputDimensions_10(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Set/get the dimensions of the output image
		/// </summary>
		// Token: 0x0600BE07 RID: 48647 RVA: 0x00109148 File Offset: 0x00107348
		public virtual void GetOutputDimensions(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkFastSplatter.vtkFastSplatter_GetOutputDimensions_10(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600BE08 RID: 48648
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFastSplatter_GetOutputDimensions_11(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the dimensions of the output image
		/// </summary>
		// Token: 0x0600BE09 RID: 48649 RVA: 0x0010915A File Offset: 0x0010735A
		public virtual void GetOutputDimensions(IntPtr _arg)
		{
			vtkFastSplatter.vtkFastSplatter_GetOutputDimensions_11(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BE0A RID: 48650
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFastSplatter_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BE0B RID: 48651 RVA: 0x0010916C File Offset: 0x0010736C
		public override int IsA(string type)
		{
			return vtkFastSplatter.vtkFastSplatter_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0600BE0C RID: 48652
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFastSplatter_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BE0D RID: 48653 RVA: 0x0010918C File Offset: 0x0010738C
		public new static int IsTypeOf(string type)
		{
			return vtkFastSplatter.vtkFastSplatter_IsTypeOf_13(type);
		}

		// Token: 0x0600BE0E RID: 48654
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFastSplatter_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BE0F RID: 48655 RVA: 0x001091A8 File Offset: 0x001073A8
		public new vtkFastSplatter NewInstance()
		{
			vtkFastSplatter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFastSplatter.vtkFastSplatter_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFastSplatter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600BE10 RID: 48656
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFastSplatter_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BE11 RID: 48657 RVA: 0x00109204 File Offset: 0x00107404
		public new static vtkFastSplatter SafeDownCast(vtkObjectBase o)
		{
			vtkFastSplatter vtkFastSplatter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFastSplatter.vtkFastSplatter_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFastSplatter = (vtkFastSplatter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFastSplatter.Register(null);
				}
			}
			return vtkFastSplatter;
		}

		// Token: 0x0600BE12 RID: 48658
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFastSplatter_SetLimitMode_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the way voxel values will be limited.  If this is set to None (the
		/// default), the output can have arbitrarily large values.  If set to clamp,
		/// the output will be clamped to [MinValue,MaxValue].  If set to scale, the
		/// output will be linearly scaled between MinValue and MaxValue.
		/// </summary>
		// Token: 0x0600BE13 RID: 48659 RVA: 0x00109283 File Offset: 0x00107483
		public virtual void SetLimitMode(int _arg)
		{
			vtkFastSplatter.vtkFastSplatter_SetLimitMode_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BE14 RID: 48660
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFastSplatter_SetLimitModeToClamp_18(HandleRef pThis);

		/// <summary>
		/// Set/get the way voxel values will be limited.  If this is set to None (the
		/// default), the output can have arbitrarily large values.  If set to clamp,
		/// the output will be clamped to [MinValue,MaxValue].  If set to scale, the
		/// output will be linearly scaled between MinValue and MaxValue.
		/// </summary>
		// Token: 0x0600BE15 RID: 48661 RVA: 0x00109293 File Offset: 0x00107493
		public void SetLimitModeToClamp()
		{
			vtkFastSplatter.vtkFastSplatter_SetLimitModeToClamp_18(base.GetCppThis());
		}

		// Token: 0x0600BE16 RID: 48662
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFastSplatter_SetLimitModeToFreezeScale_19(HandleRef pThis);

		/// <summary>
		/// Set/get the way voxel values will be limited.  If this is set to None (the
		/// default), the output can have arbitrarily large values.  If set to clamp,
		/// the output will be clamped to [MinValue,MaxValue].  If set to scale, the
		/// output will be linearly scaled between MinValue and MaxValue.
		/// </summary>
		// Token: 0x0600BE17 RID: 48663 RVA: 0x001092A2 File Offset: 0x001074A2
		public void SetLimitModeToFreezeScale()
		{
			vtkFastSplatter.vtkFastSplatter_SetLimitModeToFreezeScale_19(base.GetCppThis());
		}

		// Token: 0x0600BE18 RID: 48664
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFastSplatter_SetLimitModeToNone_20(HandleRef pThis);

		/// <summary>
		/// Set/get the way voxel values will be limited.  If this is set to None (the
		/// default), the output can have arbitrarily large values.  If set to clamp,
		/// the output will be clamped to [MinValue,MaxValue].  If set to scale, the
		/// output will be linearly scaled between MinValue and MaxValue.
		/// </summary>
		// Token: 0x0600BE19 RID: 48665 RVA: 0x001092B1 File Offset: 0x001074B1
		public void SetLimitModeToNone()
		{
			vtkFastSplatter.vtkFastSplatter_SetLimitModeToNone_20(base.GetCppThis());
		}

		// Token: 0x0600BE1A RID: 48666
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFastSplatter_SetLimitModeToScale_21(HandleRef pThis);

		/// <summary>
		/// Set/get the way voxel values will be limited.  If this is set to None (the
		/// default), the output can have arbitrarily large values.  If set to clamp,
		/// the output will be clamped to [MinValue,MaxValue].  If set to scale, the
		/// output will be linearly scaled between MinValue and MaxValue.
		/// </summary>
		// Token: 0x0600BE1B RID: 48667 RVA: 0x001092C0 File Offset: 0x001074C0
		public void SetLimitModeToScale()
		{
			vtkFastSplatter.vtkFastSplatter_SetLimitModeToScale_21(base.GetCppThis());
		}

		// Token: 0x0600BE1C RID: 48668
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFastSplatter_SetMaxValue_22(HandleRef pThis, double _arg);

		/// <summary>
		/// See the LimitMode method.
		/// </summary>
		// Token: 0x0600BE1D RID: 48669 RVA: 0x001092CF File Offset: 0x001074CF
		public virtual void SetMaxValue(double _arg)
		{
			vtkFastSplatter.vtkFastSplatter_SetMaxValue_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BE1E RID: 48670
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFastSplatter_SetMinValue_23(HandleRef pThis, double _arg);

		/// <summary>
		/// See the LimitMode method.
		/// </summary>
		// Token: 0x0600BE1F RID: 48671 RVA: 0x001092DF File Offset: 0x001074DF
		public virtual void SetMinValue(double _arg)
		{
			vtkFastSplatter.vtkFastSplatter_SetMinValue_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BE20 RID: 48672
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFastSplatter_SetModelBounds_24(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
		/// the sampling is performed. If any of the (min,max) bounds values are
		/// min &gt;= max, then the bounds will be computed automatically from the input
		/// data. Otherwise, the user-specified bounds will be used.
		/// </summary>
		// Token: 0x0600BE21 RID: 48673 RVA: 0x001092EF File Offset: 0x001074EF
		public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkFastSplatter.vtkFastSplatter_SetModelBounds_24(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600BE22 RID: 48674
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFastSplatter_SetModelBounds_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
		/// the sampling is performed. If any of the (min,max) bounds values are
		/// min &gt;= max, then the bounds will be computed automatically from the input
		/// data. Otherwise, the user-specified bounds will be used.
		/// </summary>
		// Token: 0x0600BE23 RID: 48675 RVA: 0x00109307 File Offset: 0x00107507
		public virtual void SetModelBounds(IntPtr _arg)
		{
			vtkFastSplatter.vtkFastSplatter_SetModelBounds_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BE24 RID: 48676
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFastSplatter_SetOutputDimensions_26(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Set/get the dimensions of the output image
		/// </summary>
		// Token: 0x0600BE25 RID: 48677 RVA: 0x00109317 File Offset: 0x00107517
		public virtual void SetOutputDimensions(int _arg1, int _arg2, int _arg3)
		{
			vtkFastSplatter.vtkFastSplatter_SetOutputDimensions_26(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600BE26 RID: 48678
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFastSplatter_SetOutputDimensions_27(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the dimensions of the output image
		/// </summary>
		// Token: 0x0600BE27 RID: 48679 RVA: 0x00109329 File Offset: 0x00107529
		public virtual void SetOutputDimensions(IntPtr _arg)
		{
			vtkFastSplatter.vtkFastSplatter_SetOutputDimensions_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BE28 RID: 48680
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFastSplatter_SetSplatConnection_28(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Convenience function for connecting the splat algorithm source.
		/// This is provided mainly for convenience using the filter with
		/// ParaView, VTK users should prefer SetInputConnection(1, splat) instead.
		/// </summary>
		// Token: 0x0600BE29 RID: 48681 RVA: 0x0010933C File Offset: 0x0010753C
		public void SetSplatConnection(vtkAlgorithmOutput arg0)
		{
			vtkFastSplatter.vtkFastSplatter_SetSplatConnection_28(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E28 RID: 3624
		public new const string MRFullTypeName = "Kitware.VTK.vtkFastSplatter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E29 RID: 3625
		public new static readonly string MRClassNameKey = "class vtkFastSplatter";

		/// <summary>
		/// Set/get the dimensions of the output image
		/// </summary>
		// Token: 0x020003E0 RID: 992
		public enum ClampLimit_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000E2B RID: 3627
			ClampLimit = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000E2C RID: 3628
			FreezeScaleLimit = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000E2D RID: 3629
			NoneLimit = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000E2E RID: 3630
			ScaleLimit = 2
		}
	}
}
