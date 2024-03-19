using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTransformInterpolator
	/// </summary>
	/// <remarks>
	///    interpolate a series of transformation matrices
	///
	/// This class is used to interpolate a series of 4x4 transformation
	/// matrices. Position, scale and orientation (i.e., rotations) are
	/// interpolated separately, and can be interpolated linearly or with a spline
	/// function. Note that orientation is interpolated using quaternions via
	/// SLERP (spherical linear interpolation) or the special vtkQuaternionSpline
	/// class.
	///
	/// To use this class, specify at least two pairs of (t,transformation matrix)
	/// with the AddTransform() method.  Then interpolated the transforms with the
	/// InterpolateTransform(t,transform) method, where "t" must be in the range
	/// of (min,max) times specified by the AddTransform() method.
	///
	/// By default, spline interpolation is used for the interpolation of the
	/// transformation matrices. The position, scale and orientation of the
	/// matrices are interpolated with instances of the classes
	/// vtkTupleInterpolator (position,scale) and vtkQuaternionInterpolator
	/// (rotation). The user can override the interpolation behavior by gaining
	/// access to these separate interpolation classes.  These interpolator
	/// classes (vtkTupleInterpolator and vtkQuaternionInterpolator) can be
	/// modified to perform linear versus spline interpolation, and/or different
	/// spline basis functions can be specified.
	///
	/// @warning
	/// The interpolator classes are initialized when the InterpolateTransform()
	/// is called. Any changes to the interpolators, or additions to the list of
	/// transforms to be interpolated, causes a reinitialization of the
	/// interpolators the next time InterpolateTransform() is invoked. Thus the
	/// best performance is obtained by 1) configuring the interpolators, 2) adding
	/// all the transforms, and 3) finally performing interpolation.
	/// </remarks>
	// Token: 0x02000802 RID: 2050
	public class vtkTransformInterpolator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060150FF RID: 86271 RVA: 0x001DCE4B File Offset: 0x001DB04B
		static vtkTransformInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransformInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransformInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015100 RID: 86272 RVA: 0x001DCE73 File Offset: 0x001DB073
		public vtkTransformInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015101 RID: 86273
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06015102 RID: 86274 RVA: 0x001DCE84 File Offset: 0x001DB084
		public new static vtkTransformInterpolator New()
		{
			vtkTransformInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformInterpolator.vtkTransformInterpolator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06015103 RID: 86275 RVA: 0x001DCED8 File Offset: 0x001DB0D8
		public vtkTransformInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTransformInterpolator.vtkTransformInterpolator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015104 RID: 86276 RVA: 0x001DCF1C File Offset: 0x001DB11C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015105 RID: 86277
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformInterpolator_AddTransform_01(HandleRef pThis, double t, HandleRef xform);

		/// <summary>
		/// Add another transform to the list of transformations defining
		/// the transform function. Note that using the same time t value
		/// more than once replaces the previous transform value at t.
		/// At least two transforms must be added to define a function.
		/// There are variants to this method depending on whether you are
		/// adding a vtkTransform, vtkMaxtirx4x4, and/or vtkProp3D.
		/// </summary>
		// Token: 0x06015106 RID: 86278 RVA: 0x001DCF28 File Offset: 0x001DB128
		public void AddTransform(double t, vtkTransform xform)
		{
			vtkTransformInterpolator.vtkTransformInterpolator_AddTransform_01(base.GetCppThis(), t, (xform == null) ? default(HandleRef) : xform.GetCppThis());
		}

		// Token: 0x06015107 RID: 86279
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformInterpolator_AddTransform_02(HandleRef pThis, double t, HandleRef matrix);

		/// <summary>
		/// Add another transform to the list of transformations defining
		/// the transform function. Note that using the same time t value
		/// more than once replaces the previous transform value at t.
		/// At least two transforms must be added to define a function.
		/// There are variants to this method depending on whether you are
		/// adding a vtkTransform, vtkMaxtirx4x4, and/or vtkProp3D.
		/// </summary>
		// Token: 0x06015108 RID: 86280 RVA: 0x001DCF58 File Offset: 0x001DB158
		public void AddTransform(double t, vtkMatrix4x4 matrix)
		{
			vtkTransformInterpolator.vtkTransformInterpolator_AddTransform_02(base.GetCppThis(), t, (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x06015109 RID: 86281
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformInterpolator_AddTransform_03(HandleRef pThis, double t, HandleRef prop3D);

		/// <summary>
		/// Add another transform to the list of transformations defining
		/// the transform function. Note that using the same time t value
		/// more than once replaces the previous transform value at t.
		/// At least two transforms must be added to define a function.
		/// There are variants to this method depending on whether you are
		/// adding a vtkTransform, vtkMaxtirx4x4, and/or vtkProp3D.
		/// </summary>
		// Token: 0x0601510A RID: 86282 RVA: 0x001DCF88 File Offset: 0x001DB188
		public void AddTransform(double t, vtkProp3D prop3D)
		{
			vtkTransformInterpolator.vtkTransformInterpolator_AddTransform_03(base.GetCppThis(), t, (prop3D == null) ? default(HandleRef) : prop3D.GetCppThis());
		}

		// Token: 0x0601510B RID: 86283
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformInterpolator_GetInterpolationType_04(HandleRef pThis);

		/// <summary>
		/// These are convenience methods to switch between linear and spline
		/// interpolation. The methods simply forward the request for linear or
		/// spline interpolation to the position, scale and orientation
		/// interpolators. Note that if the InterpolationType is set to "Manual",
		/// then the interpolators are expected to be directly manipulated and
		/// this class does not forward the request for interpolation type to its
		/// interpolators.
		/// </summary>
		// Token: 0x0601510C RID: 86284 RVA: 0x001DCFB8 File Offset: 0x001DB1B8
		public virtual int GetInterpolationType()
		{
			return vtkTransformInterpolator.vtkTransformInterpolator_GetInterpolationType_04(base.GetCppThis());
		}

		// Token: 0x0601510D RID: 86285
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformInterpolator_GetInterpolationTypeMaxValue_05(HandleRef pThis);

		/// <summary>
		/// These are convenience methods to switch between linear and spline
		/// interpolation. The methods simply forward the request for linear or
		/// spline interpolation to the position, scale and orientation
		/// interpolators. Note that if the InterpolationType is set to "Manual",
		/// then the interpolators are expected to be directly manipulated and
		/// this class does not forward the request for interpolation type to its
		/// interpolators.
		/// </summary>
		// Token: 0x0601510E RID: 86286 RVA: 0x001DCFD8 File Offset: 0x001DB1D8
		public virtual int GetInterpolationTypeMaxValue()
		{
			return vtkTransformInterpolator.vtkTransformInterpolator_GetInterpolationTypeMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0601510F RID: 86287
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformInterpolator_GetInterpolationTypeMinValue_06(HandleRef pThis);

		/// <summary>
		/// These are convenience methods to switch between linear and spline
		/// interpolation. The methods simply forward the request for linear or
		/// spline interpolation to the position, scale and orientation
		/// interpolators. Note that if the InterpolationType is set to "Manual",
		/// then the interpolators are expected to be directly manipulated and
		/// this class does not forward the request for interpolation type to its
		/// interpolators.
		/// </summary>
		// Token: 0x06015110 RID: 86288 RVA: 0x001DCFF8 File Offset: 0x001DB1F8
		public virtual int GetInterpolationTypeMinValue()
		{
			return vtkTransformInterpolator.vtkTransformInterpolator_GetInterpolationTypeMinValue_06(base.GetCppThis());
		}

		// Token: 0x06015111 RID: 86289
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkTransformInterpolator_GetMTime_07(HandleRef pThis);

		/// <summary>
		/// Override GetMTime() because we depend on the interpolators which may be
		/// modified outside of this class.
		/// </summary>
		// Token: 0x06015112 RID: 86290 RVA: 0x001DD018 File Offset: 0x001DB218
		public override ulong GetMTime()
		{
			return vtkTransformInterpolator.vtkTransformInterpolator_GetMTime_07(base.GetCppThis());
		}

		// Token: 0x06015113 RID: 86291
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTransformInterpolator_GetMaximumT_08(HandleRef pThis);

		/// <summary>
		/// Obtain some information about the interpolation range. The numbers
		/// returned (corresponding to parameter t, usually thought of as time)
		/// are undefined if the list of transforms is empty.
		/// </summary>
		// Token: 0x06015114 RID: 86292 RVA: 0x001DD038 File Offset: 0x001DB238
		public double GetMaximumT()
		{
			return vtkTransformInterpolator.vtkTransformInterpolator_GetMaximumT_08(base.GetCppThis());
		}

		// Token: 0x06015115 RID: 86293
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTransformInterpolator_GetMinimumT_09(HandleRef pThis);

		/// <summary>
		/// Obtain some information about the interpolation range. The numbers
		/// returned (corresponding to parameter t, usually thought of as time)
		/// are undefined if the list of transforms is empty.
		/// </summary>
		// Token: 0x06015116 RID: 86294 RVA: 0x001DD058 File Offset: 0x001DB258
		public double GetMinimumT()
		{
			return vtkTransformInterpolator.vtkTransformInterpolator_GetMinimumT_09(base.GetCppThis());
		}

		// Token: 0x06015117 RID: 86295
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransformInterpolator_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015118 RID: 86296 RVA: 0x001DD078 File Offset: 0x001DB278
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTransformInterpolator.vtkTransformInterpolator_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06015119 RID: 86297
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransformInterpolator_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601511A RID: 86298 RVA: 0x001DD098 File Offset: 0x001DB298
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTransformInterpolator.vtkTransformInterpolator_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0601511B RID: 86299
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformInterpolator_GetNumberOfTransforms_12(HandleRef pThis);

		/// <summary>
		/// Return the number of transforms in the list of transforms.
		/// </summary>
		// Token: 0x0601511C RID: 86300 RVA: 0x001DD0B4 File Offset: 0x001DB2B4
		public int GetNumberOfTransforms()
		{
			return vtkTransformInterpolator.vtkTransformInterpolator_GetNumberOfTransforms_12(base.GetCppThis());
		}

		// Token: 0x0601511D RID: 86301
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformInterpolator_GetPositionInterpolator_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the tuple interpolator used to interpolate the position portion
		/// of the transformation matrix. Note that you can modify the behavior of
		/// the interpolator (linear vs spline interpolation; change spline basis)
		/// by manipulating the interpolator instances.
		/// </summary>
		// Token: 0x0601511E RID: 86302 RVA: 0x001DD0D4 File Offset: 0x001DB2D4
		public virtual vtkTupleInterpolator GetPositionInterpolator()
		{
			vtkTupleInterpolator vtkTupleInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformInterpolator.vtkTransformInterpolator_GetPositionInterpolator_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601511F RID: 86303
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformInterpolator_GetRotationInterpolator_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the tuple interpolator used to interpolate the orientation portion
		/// of the transformation matrix. Note that you can modify the behavior of
		/// the interpolator (linear vs spline interpolation; change spline basis)
		/// by manipulating the interpolator instances.
		/// </summary>
		// Token: 0x06015120 RID: 86304 RVA: 0x001DD144 File Offset: 0x001DB344
		public virtual vtkQuaternionInterpolator GetRotationInterpolator()
		{
			vtkQuaternionInterpolator vtkQuaternionInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformInterpolator.vtkTransformInterpolator_GetRotationInterpolator_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuaternionInterpolator = (vtkQuaternionInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuaternionInterpolator.Register(null);
				}
			}
			return vtkQuaternionInterpolator;
		}

		// Token: 0x06015121 RID: 86305
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformInterpolator_GetScaleInterpolator_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the tuple interpolator used to interpolate the scale portion
		/// of the transformation matrix. Note that you can modify the behavior of
		/// the interpolator (linear vs spline interpolation; change spline basis)
		/// by manipulating the interpolator instances.
		/// </summary>
		// Token: 0x06015122 RID: 86306 RVA: 0x001DD1B4 File Offset: 0x001DB3B4
		public virtual vtkTupleInterpolator GetScaleInterpolator()
		{
			vtkTupleInterpolator vtkTupleInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformInterpolator.vtkTransformInterpolator_GetScaleInterpolator_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06015123 RID: 86307
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformInterpolator_Initialize_16(HandleRef pThis);

		/// <summary>
		/// Clear the list of transforms.
		/// </summary>
		// Token: 0x06015124 RID: 86308 RVA: 0x001DD223 File Offset: 0x001DB423
		public void Initialize()
		{
			vtkTransformInterpolator.vtkTransformInterpolator_Initialize_16(base.GetCppThis());
		}

		// Token: 0x06015125 RID: 86309
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformInterpolator_InterpolateTransform_17(HandleRef pThis, double t, HandleRef xform);

		/// <summary>
		/// Interpolate the list of transforms and determine a new transform (i.e.,
		/// fill in the transformation provided). If t is outside the range of
		/// (min,max) values, then t is clamped.
		/// </summary>
		// Token: 0x06015126 RID: 86310 RVA: 0x001DD234 File Offset: 0x001DB434
		public void InterpolateTransform(double t, vtkTransform xform)
		{
			vtkTransformInterpolator.vtkTransformInterpolator_InterpolateTransform_17(base.GetCppThis(), t, (xform == null) ? default(HandleRef) : xform.GetCppThis());
		}

		// Token: 0x06015127 RID: 86311
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformInterpolator_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015128 RID: 86312 RVA: 0x001DD264 File Offset: 0x001DB464
		public override int IsA(string type)
		{
			return vtkTransformInterpolator.vtkTransformInterpolator_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x06015129 RID: 86313
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformInterpolator_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601512A RID: 86314 RVA: 0x001DD284 File Offset: 0x001DB484
		public new static int IsTypeOf(string type)
		{
			return vtkTransformInterpolator.vtkTransformInterpolator_IsTypeOf_19(type);
		}

		// Token: 0x0601512B RID: 86315
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformInterpolator_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601512C RID: 86316 RVA: 0x001DD2A0 File Offset: 0x001DB4A0
		public new vtkTransformInterpolator NewInstance()
		{
			vtkTransformInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformInterpolator.vtkTransformInterpolator_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601512D RID: 86317
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformInterpolator_RemoveTransform_22(HandleRef pThis, double t);

		/// <summary>
		/// Delete the transform at a particular parameter t. If there is no
		/// transform defined at location t, then the method does nothing.
		/// </summary>
		// Token: 0x0601512E RID: 86318 RVA: 0x001DD2FA File Offset: 0x001DB4FA
		public void RemoveTransform(double t)
		{
			vtkTransformInterpolator.vtkTransformInterpolator_RemoveTransform_22(base.GetCppThis(), t);
		}

		// Token: 0x0601512F RID: 86319
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformInterpolator_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015130 RID: 86320 RVA: 0x001DD30C File Offset: 0x001DB50C
		public new static vtkTransformInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkTransformInterpolator vtkTransformInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformInterpolator.vtkTransformInterpolator_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransformInterpolator = (vtkTransformInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransformInterpolator.Register(null);
				}
			}
			return vtkTransformInterpolator;
		}

		// Token: 0x06015131 RID: 86321
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformInterpolator_SetInterpolationType_24(HandleRef pThis, int _arg);

		/// <summary>
		/// These are convenience methods to switch between linear and spline
		/// interpolation. The methods simply forward the request for linear or
		/// spline interpolation to the position, scale and orientation
		/// interpolators. Note that if the InterpolationType is set to "Manual",
		/// then the interpolators are expected to be directly manipulated and
		/// this class does not forward the request for interpolation type to its
		/// interpolators.
		/// </summary>
		// Token: 0x06015132 RID: 86322 RVA: 0x001DD38B File Offset: 0x001DB58B
		public virtual void SetInterpolationType(int _arg)
		{
			vtkTransformInterpolator.vtkTransformInterpolator_SetInterpolationType_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06015133 RID: 86323
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformInterpolator_SetInterpolationTypeToLinear_25(HandleRef pThis);

		/// <summary>
		/// These are convenience methods to switch between linear and spline
		/// interpolation. The methods simply forward the request for linear or
		/// spline interpolation to the position, scale and orientation
		/// interpolators. Note that if the InterpolationType is set to "Manual",
		/// then the interpolators are expected to be directly manipulated and
		/// this class does not forward the request for interpolation type to its
		/// interpolators.
		/// </summary>
		// Token: 0x06015134 RID: 86324 RVA: 0x001DD39B File Offset: 0x001DB59B
		public void SetInterpolationTypeToLinear()
		{
			vtkTransformInterpolator.vtkTransformInterpolator_SetInterpolationTypeToLinear_25(base.GetCppThis());
		}

		// Token: 0x06015135 RID: 86325
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformInterpolator_SetInterpolationTypeToManual_26(HandleRef pThis);

		/// <summary>
		/// These are convenience methods to switch between linear and spline
		/// interpolation. The methods simply forward the request for linear or
		/// spline interpolation to the position, scale and orientation
		/// interpolators. Note that if the InterpolationType is set to "Manual",
		/// then the interpolators are expected to be directly manipulated and
		/// this class does not forward the request for interpolation type to its
		/// interpolators.
		/// </summary>
		// Token: 0x06015136 RID: 86326 RVA: 0x001DD3AA File Offset: 0x001DB5AA
		public void SetInterpolationTypeToManual()
		{
			vtkTransformInterpolator.vtkTransformInterpolator_SetInterpolationTypeToManual_26(base.GetCppThis());
		}

		// Token: 0x06015137 RID: 86327
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformInterpolator_SetInterpolationTypeToSpline_27(HandleRef pThis);

		/// <summary>
		/// These are convenience methods to switch between linear and spline
		/// interpolation. The methods simply forward the request for linear or
		/// spline interpolation to the position, scale and orientation
		/// interpolators. Note that if the InterpolationType is set to "Manual",
		/// then the interpolators are expected to be directly manipulated and
		/// this class does not forward the request for interpolation type to its
		/// interpolators.
		/// </summary>
		// Token: 0x06015138 RID: 86328 RVA: 0x001DD3B9 File Offset: 0x001DB5B9
		public void SetInterpolationTypeToSpline()
		{
			vtkTransformInterpolator.vtkTransformInterpolator_SetInterpolationTypeToSpline_27(base.GetCppThis());
		}

		// Token: 0x06015139 RID: 86329
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformInterpolator_SetPositionInterpolator_28(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the tuple interpolator used to interpolate the position portion
		/// of the transformation matrix. Note that you can modify the behavior of
		/// the interpolator (linear vs spline interpolation; change spline basis)
		/// by manipulating the interpolator instances.
		/// </summary>
		// Token: 0x0601513A RID: 86330 RVA: 0x001DD3C8 File Offset: 0x001DB5C8
		public virtual void SetPositionInterpolator(vtkTupleInterpolator arg0)
		{
			vtkTransformInterpolator.vtkTransformInterpolator_SetPositionInterpolator_28(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601513B RID: 86331
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformInterpolator_SetRotationInterpolator_29(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the tuple interpolator used to interpolate the orientation portion
		/// of the transformation matrix. Note that you can modify the behavior of
		/// the interpolator (linear vs spline interpolation; change spline basis)
		/// by manipulating the interpolator instances.
		/// </summary>
		// Token: 0x0601513C RID: 86332 RVA: 0x001DD3F8 File Offset: 0x001DB5F8
		public virtual void SetRotationInterpolator(vtkQuaternionInterpolator arg0)
		{
			vtkTransformInterpolator.vtkTransformInterpolator_SetRotationInterpolator_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601513D RID: 86333
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformInterpolator_SetScaleInterpolator_30(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the tuple interpolator used to interpolate the scale portion
		/// of the transformation matrix. Note that you can modify the behavior of
		/// the interpolator (linear vs spline interpolation; change spline basis)
		/// by manipulating the interpolator instances.
		/// </summary>
		// Token: 0x0601513E RID: 86334 RVA: 0x001DD428 File Offset: 0x001DB628
		public virtual void SetScaleInterpolator(vtkTupleInterpolator arg0)
		{
			vtkTransformInterpolator.vtkTransformInterpolator_SetScaleInterpolator_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001848 RID: 6216
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransformInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001849 RID: 6217
		public new static readonly string MRClassNameKey = "class vtkTransformInterpolator";

		/// <summary>
		/// Enums to control the type of interpolation to use.
		/// </summary>
		// Token: 0x02000803 RID: 2051
		public enum INTERPOLATION_TYPE_LINEAR_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400184B RID: 6219
			INTERPOLATION_TYPE_LINEAR,
			/// <summary>enum member</summary>
			// Token: 0x0400184C RID: 6220
			INTERPOLATION_TYPE_MANUAL = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400184D RID: 6221
			INTERPOLATION_TYPE_SPLINE = 1
		}
	}
}
