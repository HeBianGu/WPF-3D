using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkShepardMethod
	/// </summary>
	/// <remarks>
	///    interpolate points and associated scalars onto volume
	/// using the method of Shepard
	///
	///
	/// vtkShepardMethod is a filter used to interpolate point scalar values using
	/// Shepard's method. The method works by resampling the scalars associated
	/// with points defined on an arbitrary dataset onto a volume (i.e.,
	/// structured points) dataset. The influence functions are described as
	/// "inverse distance weighted". Once the interpolation is performed across
	/// the volume, the usual volume visualization techniques (e.g.,
	/// iso-contouring or volume rendering) can be used.
	///
	/// Note that this implementation also provides the ability to specify the
	/// power parameter p. Given the generalized Inverse Distance Weighting (IDW)
	/// function with distance between points measured as d(x,xi), p is defined
	/// as:
	/// &lt;pre&gt;
	/// u(x) = Sum(wi(x) * ui) / Sum(wi(x)) if d(x,xi) != 0
	/// u(x) = ui                           if d(x,xi) == 0
	///
	/// where wi(x) = 1 / (d(x,xi)^p
	/// &lt;/pre&gt;
	/// Typically p=2, so the weights wi(x) are the inverse of the distance
	/// squared. However, power parameters &gt; 2 can be used which assign higher
	/// weights for data closer to the interpolated point; or &lt;2 which assigns
	/// greater weight to points further away. (Note that if p!=2, performance may
	/// be significantly impacted as the algorithm is tuned for p=2.)
	///
	/// @warning
	/// Strictly speaking, this is a modified Shepard's methodsince only points
	/// within the MaxiumDistance are used for interpolation. By setting the
	/// maximum distance to include the entire bounding box and therefore all
	/// points, the class executes much slower but incorporates all points into
	/// the interpolation process (i.e., a pure Shepard method).
	///
	/// @warning
	/// The input to this filter is any dataset type. This filter can be used to
	/// resample the points of any type of dataset onto the output volume; i.e.,
	/// the input data need not be unstructured with explicit point
	/// representations.
	///
	/// @warning
	/// The bounds of the data (i.e., the sample space) is automatically computed
	/// if not set by the user.
	///
	/// @warning
	/// If you use a maximum distance less than 1.0 (i.e., using a modified
	/// Shephard's method), some output points may never receive a
	/// contribution. The final value of these points can be specified with the
	/// "NullValue" instance variable.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGaussianSplatter vtkCheckerboardSplatter
	/// </seealso>
	// Token: 0x020003E8 RID: 1000
	public class vtkShepardMethod : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600BFB9 RID: 49081 RVA: 0x0010B147 File Offset: 0x00109347
		static vtkShepardMethod()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkShepardMethod.MRClassNameKey, Type.GetType("Kitware.VTK.vtkShepardMethod"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600BFBA RID: 49082 RVA: 0x0010B16F File Offset: 0x0010936F
		public vtkShepardMethod(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600BFBB RID: 49083
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShepardMethod_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with sample dimensions=(50,50,50) and so that model bounds are
		/// automatically computed from the input. The null value for each unvisited
		/// output point is 0.0. Maximum distance is 0.25. Power parameter p=2.
		/// </summary>
		// Token: 0x0600BFBC RID: 49084 RVA: 0x0010B180 File Offset: 0x00109380
		public new static vtkShepardMethod New()
		{
			vtkShepardMethod result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShepardMethod.vtkShepardMethod_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShepardMethod)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with sample dimensions=(50,50,50) and so that model bounds are
		/// automatically computed from the input. The null value for each unvisited
		/// output point is 0.0. Maximum distance is 0.25. Power parameter p=2.
		/// </summary>
		// Token: 0x0600BFBD RID: 49085 RVA: 0x0010B1D4 File Offset: 0x001093D4
		public vtkShepardMethod() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkShepardMethod.vtkShepardMethod_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600BFBE RID: 49086 RVA: 0x0010B218 File Offset: 0x00109418
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600BFBF RID: 49087
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkShepardMethod_ComputeModelBounds_01(HandleRef pThis, IntPtr origin, IntPtr spacing);

		/// <summary>
		/// Compute ModelBounds from the input geometry.
		/// </summary>
		// Token: 0x0600BFC0 RID: 49088 RVA: 0x0010B224 File Offset: 0x00109424
		public double ComputeModelBounds(IntPtr origin, IntPtr spacing)
		{
			return vtkShepardMethod.vtkShepardMethod_ComputeModelBounds_01(base.GetCppThis(), origin, spacing);
		}

		// Token: 0x0600BFC1 RID: 49089
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkShepardMethod_GetMaximumDistance_02(HandleRef pThis);

		/// <summary>
		/// Specify the maximum influence distance of each input point. This
		/// distance is a fraction of the length of the diagonal of the sample
		/// space. Thus, values of 1.0 will cause each input point to influence all
		/// points in the volume dataset. Values less than 1.0 can improve
		/// performance significantly. By default the maximum distance is 0.25.
		/// </summary>
		// Token: 0x0600BFC2 RID: 49090 RVA: 0x0010B248 File Offset: 0x00109448
		public virtual double GetMaximumDistance()
		{
			return vtkShepardMethod.vtkShepardMethod_GetMaximumDistance_02(base.GetCppThis());
		}

		// Token: 0x0600BFC3 RID: 49091
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkShepardMethod_GetMaximumDistanceMaxValue_03(HandleRef pThis);

		/// <summary>
		/// Specify the maximum influence distance of each input point. This
		/// distance is a fraction of the length of the diagonal of the sample
		/// space. Thus, values of 1.0 will cause each input point to influence all
		/// points in the volume dataset. Values less than 1.0 can improve
		/// performance significantly. By default the maximum distance is 0.25.
		/// </summary>
		// Token: 0x0600BFC4 RID: 49092 RVA: 0x0010B268 File Offset: 0x00109468
		public virtual double GetMaximumDistanceMaxValue()
		{
			return vtkShepardMethod.vtkShepardMethod_GetMaximumDistanceMaxValue_03(base.GetCppThis());
		}

		// Token: 0x0600BFC5 RID: 49093
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkShepardMethod_GetMaximumDistanceMinValue_04(HandleRef pThis);

		/// <summary>
		/// Specify the maximum influence distance of each input point. This
		/// distance is a fraction of the length of the diagonal of the sample
		/// space. Thus, values of 1.0 will cause each input point to influence all
		/// points in the volume dataset. Values less than 1.0 can improve
		/// performance significantly. By default the maximum distance is 0.25.
		/// </summary>
		// Token: 0x0600BFC6 RID: 49094 RVA: 0x0010B288 File Offset: 0x00109488
		public virtual double GetMaximumDistanceMinValue()
		{
			return vtkShepardMethod.vtkShepardMethod_GetMaximumDistanceMinValue_04(base.GetCppThis());
		}

		// Token: 0x0600BFC7 RID: 49095
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShepardMethod_GetModelBounds_05(HandleRef pThis);

		/// <summary>
		/// Specify the position in space to perform the sampling. The ModelBounds
		/// and SampleDimensions together define the output volume. (Note: if the
		/// ModelBounds are set to an invalid state [zero or negative volume] then
		/// the bounds are computed automatically.)
		/// </summary>
		// Token: 0x0600BFC8 RID: 49096 RVA: 0x0010B2A8 File Offset: 0x001094A8
		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkShepardMethod.vtkShepardMethod_GetModelBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BFC9 RID: 49097
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShepardMethod_GetModelBounds_06(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the position in space to perform the sampling. The ModelBounds
		/// and SampleDimensions together define the output volume. (Note: if the
		/// ModelBounds are set to an invalid state [zero or negative volume] then
		/// the bounds are computed automatically.)
		/// </summary>
		// Token: 0x0600BFCA RID: 49098 RVA: 0x0010B2F0 File Offset: 0x001094F0
		public virtual void GetModelBounds(IntPtr data)
		{
			vtkShepardMethod.vtkShepardMethod_GetModelBounds_06(base.GetCppThis(), data);
		}

		// Token: 0x0600BFCB RID: 49099
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkShepardMethod_GetNullValue_07(HandleRef pThis);

		/// <summary>
		/// Set the value for output points not receiving a contribution from any
		/// input point(s). Output points may not receive a contribution when the
		/// MaximumDistance &lt; 1.
		/// </summary>
		// Token: 0x0600BFCC RID: 49100 RVA: 0x0010B300 File Offset: 0x00109500
		public virtual double GetNullValue()
		{
			return vtkShepardMethod.vtkShepardMethod_GetNullValue_07(base.GetCppThis());
		}

		// Token: 0x0600BFCD RID: 49101
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShepardMethod_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0600BFCE RID: 49102 RVA: 0x0010B320 File Offset: 0x00109520
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkShepardMethod.vtkShepardMethod_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600BFCF RID: 49103
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShepardMethod_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0600BFD0 RID: 49104 RVA: 0x0010B340 File Offset: 0x00109540
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkShepardMethod.vtkShepardMethod_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600BFD1 RID: 49105
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkShepardMethod_GetPowerParameter_10(HandleRef pThis);

		/// <summary>
		/// Set / Get the power parameter p. By default p=2. Values (which must be
		/// a positive, real value) != 2 may affect performance significantly.
		/// </summary>
		// Token: 0x0600BFD2 RID: 49106 RVA: 0x0010B35C File Offset: 0x0010955C
		public virtual double GetPowerParameter()
		{
			return vtkShepardMethod.vtkShepardMethod_GetPowerParameter_10(base.GetCppThis());
		}

		// Token: 0x0600BFD3 RID: 49107
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkShepardMethod_GetPowerParameterMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set / Get the power parameter p. By default p=2. Values (which must be
		/// a positive, real value) != 2 may affect performance significantly.
		/// </summary>
		// Token: 0x0600BFD4 RID: 49108 RVA: 0x0010B37C File Offset: 0x0010957C
		public virtual double GetPowerParameterMaxValue()
		{
			return vtkShepardMethod.vtkShepardMethod_GetPowerParameterMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0600BFD5 RID: 49109
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkShepardMethod_GetPowerParameterMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set / Get the power parameter p. By default p=2. Values (which must be
		/// a positive, real value) != 2 may affect performance significantly.
		/// </summary>
		// Token: 0x0600BFD6 RID: 49110 RVA: 0x0010B39C File Offset: 0x0010959C
		public virtual double GetPowerParameterMinValue()
		{
			return vtkShepardMethod.vtkShepardMethod_GetPowerParameterMinValue_12(base.GetCppThis());
		}

		// Token: 0x0600BFD7 RID: 49111
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShepardMethod_GetSampleDimensions_13(HandleRef pThis);

		/// <summary>
		/// Retrieve the i-j-k dimensions on which to interpolate the input points.
		/// </summary>
		// Token: 0x0600BFD8 RID: 49112 RVA: 0x0010B3BC File Offset: 0x001095BC
		public virtual int[] GetSampleDimensions()
		{
			IntPtr intPtr = vtkShepardMethod.vtkShepardMethod_GetSampleDimensions_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BFD9 RID: 49113
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShepardMethod_GetSampleDimensions_14(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Retrieve the i-j-k dimensions on which to interpolate the input points.
		/// </summary>
		// Token: 0x0600BFDA RID: 49114 RVA: 0x0010B404 File Offset: 0x00109604
		public virtual void GetSampleDimensions(IntPtr data)
		{
			vtkShepardMethod.vtkShepardMethod_GetSampleDimensions_14(base.GetCppThis(), data);
		}

		// Token: 0x0600BFDB RID: 49115
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShepardMethod_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0600BFDC RID: 49116 RVA: 0x0010B414 File Offset: 0x00109614
		public override int IsA(string type)
		{
			return vtkShepardMethod.vtkShepardMethod_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x0600BFDD RID: 49117
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShepardMethod_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0600BFDE RID: 49118 RVA: 0x0010B434 File Offset: 0x00109634
		public new static int IsTypeOf(string type)
		{
			return vtkShepardMethod.vtkShepardMethod_IsTypeOf_16(type);
		}

		// Token: 0x0600BFDF RID: 49119
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShepardMethod_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0600BFE0 RID: 49120 RVA: 0x0010B450 File Offset: 0x00109650
		public new vtkShepardMethod NewInstance()
		{
			vtkShepardMethod result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShepardMethod.vtkShepardMethod_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShepardMethod)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600BFE1 RID: 49121
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShepardMethod_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0600BFE2 RID: 49122 RVA: 0x0010B4AC File Offset: 0x001096AC
		public new static vtkShepardMethod SafeDownCast(vtkObjectBase o)
		{
			vtkShepardMethod vtkShepardMethod = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShepardMethod.vtkShepardMethod_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShepardMethod = (vtkShepardMethod)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShepardMethod.Register(null);
				}
			}
			return vtkShepardMethod;
		}

		// Token: 0x0600BFE3 RID: 49123
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShepardMethod_SetMaximumDistance_20(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the maximum influence distance of each input point. This
		/// distance is a fraction of the length of the diagonal of the sample
		/// space. Thus, values of 1.0 will cause each input point to influence all
		/// points in the volume dataset. Values less than 1.0 can improve
		/// performance significantly. By default the maximum distance is 0.25.
		/// </summary>
		// Token: 0x0600BFE4 RID: 49124 RVA: 0x0010B52B File Offset: 0x0010972B
		public virtual void SetMaximumDistance(double _arg)
		{
			vtkShepardMethod.vtkShepardMethod_SetMaximumDistance_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BFE5 RID: 49125
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShepardMethod_SetModelBounds_21(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Specify the position in space to perform the sampling. The ModelBounds
		/// and SampleDimensions together define the output volume. (Note: if the
		/// ModelBounds are set to an invalid state [zero or negative volume] then
		/// the bounds are computed automatically.)
		/// </summary>
		// Token: 0x0600BFE6 RID: 49126 RVA: 0x0010B53B File Offset: 0x0010973B
		public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkShepardMethod.vtkShepardMethod_SetModelBounds_21(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600BFE7 RID: 49127
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShepardMethod_SetModelBounds_22(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the position in space to perform the sampling. The ModelBounds
		/// and SampleDimensions together define the output volume. (Note: if the
		/// ModelBounds are set to an invalid state [zero or negative volume] then
		/// the bounds are computed automatically.)
		/// </summary>
		// Token: 0x0600BFE8 RID: 49128 RVA: 0x0010B553 File Offset: 0x00109753
		public virtual void SetModelBounds(IntPtr _arg)
		{
			vtkShepardMethod.vtkShepardMethod_SetModelBounds_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BFE9 RID: 49129
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShepardMethod_SetNullValue_23(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the value for output points not receiving a contribution from any
		/// input point(s). Output points may not receive a contribution when the
		/// MaximumDistance &lt; 1.
		/// </summary>
		// Token: 0x0600BFEA RID: 49130 RVA: 0x0010B563 File Offset: 0x00109763
		public virtual void SetNullValue(double _arg)
		{
			vtkShepardMethod.vtkShepardMethod_SetNullValue_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BFEB RID: 49131
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShepardMethod_SetPowerParameter_24(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / Get the power parameter p. By default p=2. Values (which must be
		/// a positive, real value) != 2 may affect performance significantly.
		/// </summary>
		// Token: 0x0600BFEC RID: 49132 RVA: 0x0010B573 File Offset: 0x00109773
		public virtual void SetPowerParameter(double _arg)
		{
			vtkShepardMethod.vtkShepardMethod_SetPowerParameter_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BFED RID: 49133
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShepardMethod_SetSampleDimensions_25(HandleRef pThis, int i, int j, int k);

		/// <summary>
		/// Set the i-j-k dimensions on which to interpolate the input points.
		/// </summary>
		// Token: 0x0600BFEE RID: 49134 RVA: 0x0010B583 File Offset: 0x00109783
		public void SetSampleDimensions(int i, int j, int k)
		{
			vtkShepardMethod.vtkShepardMethod_SetSampleDimensions_25(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0600BFEF RID: 49135
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShepardMethod_SetSampleDimensions_26(HandleRef pThis, IntPtr dim);

		/// <summary>
		/// Set the i-j-k dimensions on which to sample the input points.
		/// </summary>
		// Token: 0x0600BFF0 RID: 49136 RVA: 0x0010B595 File Offset: 0x00109795
		public void SetSampleDimensions(IntPtr dim)
		{
			vtkShepardMethod.vtkShepardMethod_SetSampleDimensions_26(base.GetCppThis(), dim);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E3D RID: 3645
		public new const string MRFullTypeName = "Kitware.VTK.vtkShepardMethod";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E3E RID: 3646
		public new static readonly string MRClassNameKey = "class vtkShepardMethod";
	}
}
