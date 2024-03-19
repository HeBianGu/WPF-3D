using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCameraInterpolator
	/// </summary>
	/// <remarks>
	///    interpolate a series of cameras to update a new camera
	///
	/// This class is used to interpolate a series of cameras to update a
	/// specified camera. Either linear interpolation or spline interpolation may
	/// be used. The instance variables currently interpolated include position,
	/// focal point, view up, view angle, parallel scale, and clipping range.
	///
	/// To use this class, specify the type of interpolation to use, and add a
	/// series of cameras at various times "t" to the list of cameras from which to
	/// interpolate. Then to interpolate in between cameras, simply invoke the
	/// function InterpolateCamera(t,camera) where "camera" is the camera to be
	/// updated with interpolated values. Note that "t" should be in the range
	/// (min,max) times specified with the AddCamera() method. If outside this
	/// range, the interpolation is clamped. This class copies the camera information
	/// (as compared to referencing the cameras) so you do not need to keep separate
	/// instances of the camera around for each camera added to the list of cameras
	/// to interpolate.
	///
	/// @warning
	/// The interpolator classes are initialized the first time InterpolateCamera()
	/// is called. Any later changes to the interpolators, or additions to the list of
	/// cameras to be interpolated, causes a reinitialization of the
	/// interpolators the next time InterpolateCamera() is invoked. Thus the
	/// best performance is obtained by 1) configuring the interpolators, 2) adding
	/// all the cameras, and 3) finally performing interpolation.
	///
	/// @warning
	/// Currently position, focal point and view up are interpolated to define
	/// the orientation of the camera. Quaternion interpolation may be added in the
	/// future as an alternative interpolation method for camera orientation.
	/// </remarks>
	// Token: 0x020007CB RID: 1995
	public class vtkCameraInterpolator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014692 RID: 83602 RVA: 0x001CE51F File Offset: 0x001CC71F
		static vtkCameraInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCameraInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014693 RID: 83603 RVA: 0x001CE547 File Offset: 0x001CC747
		public vtkCameraInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014694 RID: 83604
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06014695 RID: 83605 RVA: 0x001CE558 File Offset: 0x001CC758
		public new static vtkCameraInterpolator New()
		{
			vtkCameraInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraInterpolator.vtkCameraInterpolator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06014696 RID: 83606 RVA: 0x001CE5AC File Offset: 0x001CC7AC
		public vtkCameraInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCameraInterpolator.vtkCameraInterpolator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014697 RID: 83607 RVA: 0x001CE5F0 File Offset: 0x001CC7F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014698 RID: 83608
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraInterpolator_AddCamera_01(HandleRef pThis, double t, HandleRef camera);

		/// <summary>
		/// Add another camera to the list of cameras defining
		/// the camera function. Note that using the same time t value
		/// more than once replaces the previous camera value at t.
		/// At least one camera must be added to define a function.
		/// </summary>
		// Token: 0x06014699 RID: 83609 RVA: 0x001CE5FC File Offset: 0x001CC7FC
		public void AddCamera(double t, vtkCamera camera)
		{
			vtkCameraInterpolator.vtkCameraInterpolator_AddCamera_01(base.GetCppThis(), t, (camera == null) ? default(HandleRef) : camera.GetCppThis());
		}

		// Token: 0x0601469A RID: 83610
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraInterpolator_GetClippingRangeInterpolator_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the tuple interpolator used to interpolate the clipping range portion
		/// of the camera. Note that you can modify the behavior of the interpolator
		/// (linear vs spline interpolation; change spline basis) by manipulating
		/// the interpolator instances directly.
		/// </summary>
		// Token: 0x0601469B RID: 83611 RVA: 0x001CE62C File Offset: 0x001CC82C
		public virtual vtkTupleInterpolator GetClippingRangeInterpolator()
		{
			vtkTupleInterpolator vtkTupleInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraInterpolator.vtkCameraInterpolator_GetClippingRangeInterpolator_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTupleInterpolator = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTupleInterpolator.Register(null);
				}
			}
			return vtkTupleInterpolator;
		}

		// Token: 0x0601469C RID: 83612
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraInterpolator_GetFocalPointInterpolator_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the tuple interpolator used to interpolate the focal point portion
		/// of the camera. Note that you can modify the behavior of the interpolator
		/// (linear vs spline interpolation; change spline basis) by manipulating
		/// the interpolator instances directly.
		/// </summary>
		// Token: 0x0601469D RID: 83613 RVA: 0x001CE69C File Offset: 0x001CC89C
		public virtual vtkTupleInterpolator GetFocalPointInterpolator()
		{
			vtkTupleInterpolator vtkTupleInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraInterpolator.vtkCameraInterpolator_GetFocalPointInterpolator_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTupleInterpolator = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTupleInterpolator.Register(null);
				}
			}
			return vtkTupleInterpolator;
		}

		// Token: 0x0601469E RID: 83614
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraInterpolator_GetInterpolationType_04(HandleRef pThis);

		/// <summary>
		/// These are convenience methods to switch between linear and spline
		/// interpolation. The methods simply forward the request for linear or
		/// spline interpolation to the instance variable interpolators (i.e.,
		/// position, focal point, clipping range, orientation, etc.)
		/// interpolators. Note that if the InterpolationType is set to "Manual",
		/// then the interpolators are expected to be directly manipulated and this
		/// class does not forward the request for interpolation type to its
		/// interpolators.
		/// </summary>
		// Token: 0x0601469F RID: 83615 RVA: 0x001CE70C File Offset: 0x001CC90C
		public virtual int GetInterpolationType()
		{
			return vtkCameraInterpolator.vtkCameraInterpolator_GetInterpolationType_04(base.GetCppThis());
		}

		// Token: 0x060146A0 RID: 83616
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraInterpolator_GetInterpolationTypeMaxValue_05(HandleRef pThis);

		/// <summary>
		/// These are convenience methods to switch between linear and spline
		/// interpolation. The methods simply forward the request for linear or
		/// spline interpolation to the instance variable interpolators (i.e.,
		/// position, focal point, clipping range, orientation, etc.)
		/// interpolators. Note that if the InterpolationType is set to "Manual",
		/// then the interpolators are expected to be directly manipulated and this
		/// class does not forward the request for interpolation type to its
		/// interpolators.
		/// </summary>
		// Token: 0x060146A1 RID: 83617 RVA: 0x001CE72C File Offset: 0x001CC92C
		public virtual int GetInterpolationTypeMaxValue()
		{
			return vtkCameraInterpolator.vtkCameraInterpolator_GetInterpolationTypeMaxValue_05(base.GetCppThis());
		}

		// Token: 0x060146A2 RID: 83618
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraInterpolator_GetInterpolationTypeMinValue_06(HandleRef pThis);

		/// <summary>
		/// These are convenience methods to switch between linear and spline
		/// interpolation. The methods simply forward the request for linear or
		/// spline interpolation to the instance variable interpolators (i.e.,
		/// position, focal point, clipping range, orientation, etc.)
		/// interpolators. Note that if the InterpolationType is set to "Manual",
		/// then the interpolators are expected to be directly manipulated and this
		/// class does not forward the request for interpolation type to its
		/// interpolators.
		/// </summary>
		// Token: 0x060146A3 RID: 83619 RVA: 0x001CE74C File Offset: 0x001CC94C
		public virtual int GetInterpolationTypeMinValue()
		{
			return vtkCameraInterpolator.vtkCameraInterpolator_GetInterpolationTypeMinValue_06(base.GetCppThis());
		}

		// Token: 0x060146A4 RID: 83620
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkCameraInterpolator_GetMTime_07(HandleRef pThis);

		/// <summary>
		/// Override GetMTime() because we depend on the interpolators which may be
		/// modified outside of this class.
		/// </summary>
		// Token: 0x060146A5 RID: 83621 RVA: 0x001CE76C File Offset: 0x001CC96C
		public override ulong GetMTime()
		{
			return vtkCameraInterpolator.vtkCameraInterpolator_GetMTime_07(base.GetCppThis());
		}

		// Token: 0x060146A6 RID: 83622
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCameraInterpolator_GetMaximumT_08(HandleRef pThis);

		/// <summary>
		/// Obtain some information about the interpolation range. The numbers
		/// returned are undefined if the list of cameras is empty.
		/// </summary>
		// Token: 0x060146A7 RID: 83623 RVA: 0x001CE78C File Offset: 0x001CC98C
		public double GetMaximumT()
		{
			return vtkCameraInterpolator.vtkCameraInterpolator_GetMaximumT_08(base.GetCppThis());
		}

		// Token: 0x060146A8 RID: 83624
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCameraInterpolator_GetMinimumT_09(HandleRef pThis);

		/// <summary>
		/// Obtain some information about the interpolation range. The numbers
		/// returned are undefined if the list of cameras is empty.
		/// </summary>
		// Token: 0x060146A9 RID: 83625 RVA: 0x001CE7AC File Offset: 0x001CC9AC
		public double GetMinimumT()
		{
			return vtkCameraInterpolator.vtkCameraInterpolator_GetMinimumT_09(base.GetCppThis());
		}

		// Token: 0x060146AA RID: 83626
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraInterpolator_GetNumberOfCameras_10(HandleRef pThis);

		/// <summary>
		/// Return the number of cameras in the list of cameras.
		/// </summary>
		// Token: 0x060146AB RID: 83627 RVA: 0x001CE7CC File Offset: 0x001CC9CC
		public int GetNumberOfCameras()
		{
			return vtkCameraInterpolator.vtkCameraInterpolator_GetNumberOfCameras_10(base.GetCppThis());
		}

		// Token: 0x060146AC RID: 83628
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraInterpolator_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060146AD RID: 83629 RVA: 0x001CE7EC File Offset: 0x001CC9EC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCameraInterpolator.vtkCameraInterpolator_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x060146AE RID: 83630
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraInterpolator_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060146AF RID: 83631 RVA: 0x001CE80C File Offset: 0x001CCA0C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCameraInterpolator.vtkCameraInterpolator_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x060146B0 RID: 83632
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraInterpolator_GetParallelScaleInterpolator_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the tuple interpolator used to interpolate the parallel scale portion
		/// of the camera. Note that you can modify the behavior of the interpolator
		/// (linear vs spline interpolation; change spline basis) by manipulating
		/// the interpolator instances directly.
		/// </summary>
		// Token: 0x060146B1 RID: 83633 RVA: 0x001CE828 File Offset: 0x001CCA28
		public virtual vtkTupleInterpolator GetParallelScaleInterpolator()
		{
			vtkTupleInterpolator vtkTupleInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraInterpolator.vtkCameraInterpolator_GetParallelScaleInterpolator_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTupleInterpolator = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTupleInterpolator.Register(null);
				}
			}
			return vtkTupleInterpolator;
		}

		// Token: 0x060146B2 RID: 83634
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraInterpolator_GetPositionInterpolator_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the tuple interpolator used to interpolate the position portion
		/// of the camera. Note that you can modify the behavior of the interpolator
		/// (linear vs spline interpolation; change spline basis) by manipulating
		/// the interpolator instances directly.
		/// </summary>
		// Token: 0x060146B3 RID: 83635 RVA: 0x001CE898 File Offset: 0x001CCA98
		public virtual vtkTupleInterpolator GetPositionInterpolator()
		{
			vtkTupleInterpolator vtkTupleInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraInterpolator.vtkCameraInterpolator_GetPositionInterpolator_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTupleInterpolator = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTupleInterpolator.Register(null);
				}
			}
			return vtkTupleInterpolator;
		}

		// Token: 0x060146B4 RID: 83636
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraInterpolator_GetViewAngleInterpolator_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the tuple interpolator used to interpolate the view angle portion
		/// of the camera. Note that you can modify the behavior of the interpolator
		/// (linear vs spline interpolation; change spline basis) by manipulating
		/// the interpolator instances directly.
		/// </summary>
		// Token: 0x060146B5 RID: 83637 RVA: 0x001CE908 File Offset: 0x001CCB08
		public virtual vtkTupleInterpolator GetViewAngleInterpolator()
		{
			vtkTupleInterpolator vtkTupleInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraInterpolator.vtkCameraInterpolator_GetViewAngleInterpolator_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTupleInterpolator = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTupleInterpolator.Register(null);
				}
			}
			return vtkTupleInterpolator;
		}

		// Token: 0x060146B6 RID: 83638
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraInterpolator_GetViewUpInterpolator_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the tuple interpolator used to interpolate the view up portion
		/// of the camera. Note that you can modify the behavior of the interpolator
		/// (linear vs spline interpolation; change spline basis) by manipulating
		/// the interpolator instances directly.
		/// </summary>
		// Token: 0x060146B7 RID: 83639 RVA: 0x001CE978 File Offset: 0x001CCB78
		public virtual vtkTupleInterpolator GetViewUpInterpolator()
		{
			vtkTupleInterpolator vtkTupleInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraInterpolator.vtkCameraInterpolator_GetViewUpInterpolator_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTupleInterpolator = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTupleInterpolator.Register(null);
				}
			}
			return vtkTupleInterpolator;
		}

		// Token: 0x060146B8 RID: 83640
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraInterpolator_Initialize_17(HandleRef pThis);

		/// <summary>
		/// Clear the list of cameras.
		/// </summary>
		// Token: 0x060146B9 RID: 83641 RVA: 0x001CE9E7 File Offset: 0x001CCBE7
		public void Initialize()
		{
			vtkCameraInterpolator.vtkCameraInterpolator_Initialize_17(base.GetCppThis());
		}

		// Token: 0x060146BA RID: 83642
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraInterpolator_InterpolateCamera_18(HandleRef pThis, double t, HandleRef camera);

		/// <summary>
		/// Interpolate the list of cameras and determine a new camera (i.e.,
		/// fill in the camera provided). If t is outside the range of
		/// (min,max) values, then t is clamped to lie within this range.
		/// </summary>
		// Token: 0x060146BB RID: 83643 RVA: 0x001CE9F8 File Offset: 0x001CCBF8
		public void InterpolateCamera(double t, vtkCamera camera)
		{
			vtkCameraInterpolator.vtkCameraInterpolator_InterpolateCamera_18(base.GetCppThis(), t, (camera == null) ? default(HandleRef) : camera.GetCppThis());
		}

		// Token: 0x060146BC RID: 83644
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraInterpolator_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060146BD RID: 83645 RVA: 0x001CEA28 File Offset: 0x001CCC28
		public override int IsA(string type)
		{
			return vtkCameraInterpolator.vtkCameraInterpolator_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x060146BE RID: 83646
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraInterpolator_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060146BF RID: 83647 RVA: 0x001CEA48 File Offset: 0x001CCC48
		public new static int IsTypeOf(string type)
		{
			return vtkCameraInterpolator.vtkCameraInterpolator_IsTypeOf_20(type);
		}

		// Token: 0x060146C0 RID: 83648
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraInterpolator_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060146C1 RID: 83649 RVA: 0x001CEA64 File Offset: 0x001CCC64
		public new vtkCameraInterpolator NewInstance()
		{
			vtkCameraInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraInterpolator.vtkCameraInterpolator_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060146C2 RID: 83650
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraInterpolator_RemoveCamera_23(HandleRef pThis, double t);

		/// <summary>
		/// Delete the camera at a particular parameter t. If there is no
		/// camera defined at location t, then the method does nothing.
		/// </summary>
		// Token: 0x060146C3 RID: 83651 RVA: 0x001CEABE File Offset: 0x001CCCBE
		public void RemoveCamera(double t)
		{
			vtkCameraInterpolator.vtkCameraInterpolator_RemoveCamera_23(base.GetCppThis(), t);
		}

		// Token: 0x060146C4 RID: 83652
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraInterpolator_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060146C5 RID: 83653 RVA: 0x001CEAD0 File Offset: 0x001CCCD0
		public new static vtkCameraInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkCameraInterpolator vtkCameraInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraInterpolator.vtkCameraInterpolator_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCameraInterpolator = (vtkCameraInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCameraInterpolator.Register(null);
				}
			}
			return vtkCameraInterpolator;
		}

		// Token: 0x060146C6 RID: 83654
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraInterpolator_SetClippingRangeInterpolator_25(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the tuple interpolator used to interpolate the clipping range portion
		/// of the camera. Note that you can modify the behavior of the interpolator
		/// (linear vs spline interpolation; change spline basis) by manipulating
		/// the interpolator instances directly.
		/// </summary>
		// Token: 0x060146C7 RID: 83655 RVA: 0x001CEB50 File Offset: 0x001CCD50
		public virtual void SetClippingRangeInterpolator(vtkTupleInterpolator arg0)
		{
			vtkCameraInterpolator.vtkCameraInterpolator_SetClippingRangeInterpolator_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060146C8 RID: 83656
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraInterpolator_SetFocalPointInterpolator_26(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the tuple interpolator used to interpolate the focal point portion
		/// of the camera. Note that you can modify the behavior of the interpolator
		/// (linear vs spline interpolation; change spline basis) by manipulating
		/// the interpolator instances directly.
		/// </summary>
		// Token: 0x060146C9 RID: 83657 RVA: 0x001CEB80 File Offset: 0x001CCD80
		public virtual void SetFocalPointInterpolator(vtkTupleInterpolator arg0)
		{
			vtkCameraInterpolator.vtkCameraInterpolator_SetFocalPointInterpolator_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060146CA RID: 83658
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraInterpolator_SetInterpolationType_27(HandleRef pThis, int _arg);

		/// <summary>
		/// These are convenience methods to switch between linear and spline
		/// interpolation. The methods simply forward the request for linear or
		/// spline interpolation to the instance variable interpolators (i.e.,
		/// position, focal point, clipping range, orientation, etc.)
		/// interpolators. Note that if the InterpolationType is set to "Manual",
		/// then the interpolators are expected to be directly manipulated and this
		/// class does not forward the request for interpolation type to its
		/// interpolators.
		/// </summary>
		// Token: 0x060146CB RID: 83659 RVA: 0x001CEBAF File Offset: 0x001CCDAF
		public virtual void SetInterpolationType(int _arg)
		{
			vtkCameraInterpolator.vtkCameraInterpolator_SetInterpolationType_27(base.GetCppThis(), _arg);
		}

		// Token: 0x060146CC RID: 83660
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraInterpolator_SetInterpolationTypeToLinear_28(HandleRef pThis);

		/// <summary>
		/// These are convenience methods to switch between linear and spline
		/// interpolation. The methods simply forward the request for linear or
		/// spline interpolation to the instance variable interpolators (i.e.,
		/// position, focal point, clipping range, orientation, etc.)
		/// interpolators. Note that if the InterpolationType is set to "Manual",
		/// then the interpolators are expected to be directly manipulated and this
		/// class does not forward the request for interpolation type to its
		/// interpolators.
		/// </summary>
		// Token: 0x060146CD RID: 83661 RVA: 0x001CEBBF File Offset: 0x001CCDBF
		public void SetInterpolationTypeToLinear()
		{
			vtkCameraInterpolator.vtkCameraInterpolator_SetInterpolationTypeToLinear_28(base.GetCppThis());
		}

		// Token: 0x060146CE RID: 83662
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraInterpolator_SetInterpolationTypeToManual_29(HandleRef pThis);

		/// <summary>
		/// These are convenience methods to switch between linear and spline
		/// interpolation. The methods simply forward the request for linear or
		/// spline interpolation to the instance variable interpolators (i.e.,
		/// position, focal point, clipping range, orientation, etc.)
		/// interpolators. Note that if the InterpolationType is set to "Manual",
		/// then the interpolators are expected to be directly manipulated and this
		/// class does not forward the request for interpolation type to its
		/// interpolators.
		/// </summary>
		// Token: 0x060146CF RID: 83663 RVA: 0x001CEBCE File Offset: 0x001CCDCE
		public void SetInterpolationTypeToManual()
		{
			vtkCameraInterpolator.vtkCameraInterpolator_SetInterpolationTypeToManual_29(base.GetCppThis());
		}

		// Token: 0x060146D0 RID: 83664
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraInterpolator_SetInterpolationTypeToSpline_30(HandleRef pThis);

		/// <summary>
		/// These are convenience methods to switch between linear and spline
		/// interpolation. The methods simply forward the request for linear or
		/// spline interpolation to the instance variable interpolators (i.e.,
		/// position, focal point, clipping range, orientation, etc.)
		/// interpolators. Note that if the InterpolationType is set to "Manual",
		/// then the interpolators are expected to be directly manipulated and this
		/// class does not forward the request for interpolation type to its
		/// interpolators.
		/// </summary>
		// Token: 0x060146D1 RID: 83665 RVA: 0x001CEBDD File Offset: 0x001CCDDD
		public void SetInterpolationTypeToSpline()
		{
			vtkCameraInterpolator.vtkCameraInterpolator_SetInterpolationTypeToSpline_30(base.GetCppThis());
		}

		// Token: 0x060146D2 RID: 83666
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraInterpolator_SetParallelScaleInterpolator_31(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the tuple interpolator used to interpolate the parallel scale portion
		/// of the camera. Note that you can modify the behavior of the interpolator
		/// (linear vs spline interpolation; change spline basis) by manipulating
		/// the interpolator instances directly.
		/// </summary>
		// Token: 0x060146D3 RID: 83667 RVA: 0x001CEBEC File Offset: 0x001CCDEC
		public virtual void SetParallelScaleInterpolator(vtkTupleInterpolator arg0)
		{
			vtkCameraInterpolator.vtkCameraInterpolator_SetParallelScaleInterpolator_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060146D4 RID: 83668
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraInterpolator_SetPositionInterpolator_32(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the tuple interpolator used to interpolate the position portion
		/// of the camera. Note that you can modify the behavior of the interpolator
		/// (linear vs spline interpolation; change spline basis) by manipulating
		/// the interpolator instances directly.
		/// </summary>
		// Token: 0x060146D5 RID: 83669 RVA: 0x001CEC1C File Offset: 0x001CCE1C
		public virtual void SetPositionInterpolator(vtkTupleInterpolator arg0)
		{
			vtkCameraInterpolator.vtkCameraInterpolator_SetPositionInterpolator_32(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060146D6 RID: 83670
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraInterpolator_SetViewAngleInterpolator_33(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the tuple interpolator used to interpolate the view angle portion
		/// of the camera. Note that you can modify the behavior of the interpolator
		/// (linear vs spline interpolation; change spline basis) by manipulating
		/// the interpolator instances directly.
		/// </summary>
		// Token: 0x060146D7 RID: 83671 RVA: 0x001CEC4C File Offset: 0x001CCE4C
		public virtual void SetViewAngleInterpolator(vtkTupleInterpolator arg0)
		{
			vtkCameraInterpolator.vtkCameraInterpolator_SetViewAngleInterpolator_33(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060146D8 RID: 83672
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraInterpolator_SetViewUpInterpolator_34(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the tuple interpolator used to interpolate the view up portion
		/// of the camera. Note that you can modify the behavior of the interpolator
		/// (linear vs spline interpolation; change spline basis) by manipulating
		/// the interpolator instances directly.
		/// </summary>
		// Token: 0x060146D9 RID: 83673 RVA: 0x001CEC7C File Offset: 0x001CCE7C
		public virtual void SetViewUpInterpolator(vtkTupleInterpolator arg0)
		{
			vtkCameraInterpolator.vtkCameraInterpolator_SetViewUpInterpolator_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017B4 RID: 6068
		public new const string MRFullTypeName = "Kitware.VTK.vtkCameraInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017B5 RID: 6069
		public new static readonly string MRClassNameKey = "class vtkCameraInterpolator";

		/// <summary>
		/// Enums to control the type of interpolation to use.
		/// </summary>
		// Token: 0x020007CC RID: 1996
		public enum INTERPOLATION_TYPE_LINEAR_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040017B7 RID: 6071
			INTERPOLATION_TYPE_LINEAR,
			/// <summary>enum member</summary>
			// Token: 0x040017B8 RID: 6072
			INTERPOLATION_TYPE_MANUAL = 2,
			/// <summary>enum member</summary>
			// Token: 0x040017B9 RID: 6073
			INTERPOLATION_TYPE_SPLINE = 1
		}
	}
}
