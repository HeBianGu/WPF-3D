using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointSource
	/// </summary>
	/// <remarks>
	///    create a random cloud of points
	///
	/// vtkPointSource is a source object that creates a user-specified number of
	/// points within a specified radius about a specified center point.  By
	/// default the location of the points is random within the sphere. It is also
	/// possible to generate random points only on the surface of the sphere; or a
	/// exponential distribution weighted towards the center point. The output
	/// PolyData has the specified number of points and a single cell - a
	/// vtkPolyVertex cell referencing all of the points.
	///
	/// @note
	/// If Lambda set to zero, a uniform distribution is used. Negative lambda
	/// values are allowed, but the distribution function becomes inverted.
	///
	/// @note
	/// If you desire to create complex point clouds (e.g., stellar distributions)
	/// then use multiple point sources and then append them together using the
	/// an append filter (e.g., vtkAppendPolyData).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAppendPolyData
	/// </seealso>
	// Token: 0x02000838 RID: 2104
	public class vtkPointSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015C50 RID: 89168 RVA: 0x001EB703 File Offset: 0x001E9903
		static vtkPointSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015C51 RID: 89169 RVA: 0x001EB72B File Offset: 0x001E992B
		public vtkPointSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015C52 RID: 89170
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06015C53 RID: 89171 RVA: 0x001EB73C File Offset: 0x001E993C
		public new static vtkPointSource New()
		{
			vtkPointSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSource.vtkPointSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06015C54 RID: 89172 RVA: 0x001EB790 File Offset: 0x001E9990
		public vtkPointSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointSource.vtkPointSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015C55 RID: 89173 RVA: 0x001EB7D4 File Offset: 0x001E99D4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015C56 RID: 89174
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSource_GetCenter_01(HandleRef pThis);

		/// <summary>
		/// Set the center of the point cloud.
		/// </summary>
		// Token: 0x06015C57 RID: 89175 RVA: 0x001EB7E0 File Offset: 0x001E99E0
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkPointSource.vtkPointSource_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015C58 RID: 89176
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSource_GetCenter_02(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the center of the point cloud.
		/// </summary>
		// Token: 0x06015C59 RID: 89177 RVA: 0x001EB828 File Offset: 0x001E9A28
		public virtual void GetCenter(IntPtr data)
		{
			vtkPointSource.vtkPointSource_GetCenter_02(base.GetCppThis(), data);
		}

		// Token: 0x06015C5A RID: 89178
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSource_GetDistribution_03(HandleRef pThis);

		/// <summary>
		/// Specify the point distribution to use.  The default is a uniform
		/// distribution.  The shell distribution produces random points on the
		/// surface of the sphere Radius=constant, no points in the interior.  The
		/// exponential distribution creates more points towards the center point
		/// weighted by the exponential function.
		/// </summary>
		// Token: 0x06015C5B RID: 89179 RVA: 0x001EB838 File Offset: 0x001E9A38
		public virtual int GetDistribution()
		{
			return vtkPointSource.vtkPointSource_GetDistribution_03(base.GetCppThis());
		}

		// Token: 0x06015C5C RID: 89180
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSource_GetDistributionMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Specify the point distribution to use.  The default is a uniform
		/// distribution.  The shell distribution produces random points on the
		/// surface of the sphere Radius=constant, no points in the interior.  The
		/// exponential distribution creates more points towards the center point
		/// weighted by the exponential function.
		/// </summary>
		// Token: 0x06015C5D RID: 89181 RVA: 0x001EB858 File Offset: 0x001E9A58
		public virtual int GetDistributionMaxValue()
		{
			return vtkPointSource.vtkPointSource_GetDistributionMaxValue_04(base.GetCppThis());
		}

		// Token: 0x06015C5E RID: 89182
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSource_GetDistributionMinValue_05(HandleRef pThis);

		/// <summary>
		/// Specify the point distribution to use.  The default is a uniform
		/// distribution.  The shell distribution produces random points on the
		/// surface of the sphere Radius=constant, no points in the interior.  The
		/// exponential distribution creates more points towards the center point
		/// weighted by the exponential function.
		/// </summary>
		// Token: 0x06015C5F RID: 89183 RVA: 0x001EB878 File Offset: 0x001E9A78
		public virtual int GetDistributionMinValue()
		{
			return vtkPointSource.vtkPointSource_GetDistributionMinValue_05(base.GetCppThis());
		}

		// Token: 0x06015C60 RID: 89184
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSource_GetLambda_06(HandleRef pThis);

		/// <summary>
		/// If the distribution is set to exponential, then Lambda is used to
		/// scale the exponential distribution defined by
		/// f(x) = Lambda*exp(-Lambda*radius) where the radius is the distance
		/// from the Center of the point source. By default, the value of Lambda
		/// is Lambda=1.0.
		/// </summary>
		// Token: 0x06015C61 RID: 89185 RVA: 0x001EB898 File Offset: 0x001E9A98
		public virtual double GetLambda()
		{
			return vtkPointSource.vtkPointSource_GetLambda_06(base.GetCppThis());
		}

		// Token: 0x06015C62 RID: 89186
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSource_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06015C63 RID: 89187 RVA: 0x001EB8B8 File Offset: 0x001E9AB8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointSource.vtkPointSource_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06015C64 RID: 89188
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSource_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06015C65 RID: 89189 RVA: 0x001EB8D8 File Offset: 0x001E9AD8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointSource.vtkPointSource_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06015C66 RID: 89190
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSource_GetNumberOfPoints_09(HandleRef pThis);

		/// <summary>
		/// Set the number of points to generate.
		/// </summary>
		// Token: 0x06015C67 RID: 89191 RVA: 0x001EB8F4 File Offset: 0x001E9AF4
		public virtual long GetNumberOfPoints()
		{
			return vtkPointSource.vtkPointSource_GetNumberOfPoints_09(base.GetCppThis());
		}

		// Token: 0x06015C68 RID: 89192
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSource_GetNumberOfPointsMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Set the number of points to generate.
		/// </summary>
		// Token: 0x06015C69 RID: 89193 RVA: 0x001EB914 File Offset: 0x001E9B14
		public virtual long GetNumberOfPointsMaxValue()
		{
			return vtkPointSource.vtkPointSource_GetNumberOfPointsMaxValue_10(base.GetCppThis());
		}

		// Token: 0x06015C6A RID: 89194
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSource_GetNumberOfPointsMinValue_11(HandleRef pThis);

		/// <summary>
		/// Set the number of points to generate.
		/// </summary>
		// Token: 0x06015C6B RID: 89195 RVA: 0x001EB934 File Offset: 0x001E9B34
		public virtual long GetNumberOfPointsMinValue()
		{
			return vtkPointSource.vtkPointSource_GetNumberOfPointsMinValue_11(base.GetCppThis());
		}

		// Token: 0x06015C6C RID: 89196
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSource_GetOutputPointsPrecision_12(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015C6D RID: 89197 RVA: 0x001EB954 File Offset: 0x001E9B54
		public virtual int GetOutputPointsPrecision()
		{
			return vtkPointSource.vtkPointSource_GetOutputPointsPrecision_12(base.GetCppThis());
		}

		// Token: 0x06015C6E RID: 89198
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSource_GetRadius_13(HandleRef pThis);

		/// <summary>
		/// Set the radius of the point cloud.  If you are
		/// generating a Gaussian distribution, then this is
		/// the standard deviation for each of x, y, and z.
		/// </summary>
		// Token: 0x06015C6F RID: 89199 RVA: 0x001EB974 File Offset: 0x001E9B74
		public virtual double GetRadius()
		{
			return vtkPointSource.vtkPointSource_GetRadius_13(base.GetCppThis());
		}

		// Token: 0x06015C70 RID: 89200
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSource_GetRadiusMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Set the radius of the point cloud.  If you are
		/// generating a Gaussian distribution, then this is
		/// the standard deviation for each of x, y, and z.
		/// </summary>
		// Token: 0x06015C71 RID: 89201 RVA: 0x001EB994 File Offset: 0x001E9B94
		public virtual double GetRadiusMaxValue()
		{
			return vtkPointSource.vtkPointSource_GetRadiusMaxValue_14(base.GetCppThis());
		}

		// Token: 0x06015C72 RID: 89202
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSource_GetRadiusMinValue_15(HandleRef pThis);

		/// <summary>
		/// Set the radius of the point cloud.  If you are
		/// generating a Gaussian distribution, then this is
		/// the standard deviation for each of x, y, and z.
		/// </summary>
		// Token: 0x06015C73 RID: 89203 RVA: 0x001EB9B4 File Offset: 0x001E9BB4
		public virtual double GetRadiusMinValue()
		{
			return vtkPointSource.vtkPointSource_GetRadiusMinValue_15(base.GetCppThis());
		}

		// Token: 0x06015C74 RID: 89204
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSource_GetRandomSequence_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get a random sequence generator.
		/// By default, the generator in vtkMath is used to maintain backwards
		/// compatibility.
		/// </summary>
		// Token: 0x06015C75 RID: 89205 RVA: 0x001EB9D4 File Offset: 0x001E9BD4
		public virtual vtkRandomSequence GetRandomSequence()
		{
			vtkRandomSequence vtkRandomSequence = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSource.vtkPointSource_GetRandomSequence_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRandomSequence = (vtkRandomSequence)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRandomSequence.Register(null);
				}
			}
			return vtkRandomSequence;
		}

		// Token: 0x06015C76 RID: 89206
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSource_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06015C77 RID: 89207 RVA: 0x001EBA44 File Offset: 0x001E9C44
		public override int IsA(string type)
		{
			return vtkPointSource.vtkPointSource_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x06015C78 RID: 89208
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSource_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06015C79 RID: 89209 RVA: 0x001EBA64 File Offset: 0x001E9C64
		public new static int IsTypeOf(string type)
		{
			return vtkPointSource.vtkPointSource_IsTypeOf_18(type);
		}

		// Token: 0x06015C7A RID: 89210
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSource_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06015C7B RID: 89211 RVA: 0x001EBA80 File Offset: 0x001E9C80
		public new vtkPointSource NewInstance()
		{
			vtkPointSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSource.vtkPointSource_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015C7C RID: 89212
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSource_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06015C7D RID: 89213 RVA: 0x001EBADC File Offset: 0x001E9CDC
		public new static vtkPointSource SafeDownCast(vtkObjectBase o)
		{
			vtkPointSource vtkPointSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSource.vtkPointSource_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointSource = (vtkPointSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointSource.Register(null);
				}
			}
			return vtkPointSource;
		}

		// Token: 0x06015C7E RID: 89214
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSource_SetCenter_22(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the center of the point cloud.
		/// </summary>
		// Token: 0x06015C7F RID: 89215 RVA: 0x001EBB5B File Offset: 0x001E9D5B
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkPointSource.vtkPointSource_SetCenter_22(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06015C80 RID: 89216
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSource_SetCenter_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the center of the point cloud.
		/// </summary>
		// Token: 0x06015C81 RID: 89217 RVA: 0x001EBB6D File Offset: 0x001E9D6D
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkPointSource.vtkPointSource_SetCenter_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06015C82 RID: 89218
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSource_SetDistribution_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the point distribution to use.  The default is a uniform
		/// distribution.  The shell distribution produces random points on the
		/// surface of the sphere Radius=constant, no points in the interior.  The
		/// exponential distribution creates more points towards the center point
		/// weighted by the exponential function.
		/// </summary>
		// Token: 0x06015C83 RID: 89219 RVA: 0x001EBB7D File Offset: 0x001E9D7D
		public virtual void SetDistribution(int _arg)
		{
			vtkPointSource.vtkPointSource_SetDistribution_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06015C84 RID: 89220
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSource_SetDistributionToExponential_25(HandleRef pThis);

		/// <summary>
		/// Specify the point distribution to use.  The default is a uniform
		/// distribution.  The shell distribution produces random points on the
		/// surface of the sphere Radius=constant, no points in the interior.  The
		/// exponential distribution creates more points towards the center point
		/// weighted by the exponential function.
		/// </summary>
		// Token: 0x06015C85 RID: 89221 RVA: 0x001EBB8D File Offset: 0x001E9D8D
		public void SetDistributionToExponential()
		{
			vtkPointSource.vtkPointSource_SetDistributionToExponential_25(base.GetCppThis());
		}

		// Token: 0x06015C86 RID: 89222
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSource_SetDistributionToShell_26(HandleRef pThis);

		/// <summary>
		/// Specify the point distribution to use.  The default is a uniform
		/// distribution.  The shell distribution produces random points on the
		/// surface of the sphere Radius=constant, no points in the interior.  The
		/// exponential distribution creates more points towards the center point
		/// weighted by the exponential function.
		/// </summary>
		// Token: 0x06015C87 RID: 89223 RVA: 0x001EBB9C File Offset: 0x001E9D9C
		public void SetDistributionToShell()
		{
			vtkPointSource.vtkPointSource_SetDistributionToShell_26(base.GetCppThis());
		}

		// Token: 0x06015C88 RID: 89224
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSource_SetDistributionToUniform_27(HandleRef pThis);

		/// <summary>
		/// Specify the point distribution to use.  The default is a uniform
		/// distribution.  The shell distribution produces random points on the
		/// surface of the sphere Radius=constant, no points in the interior.  The
		/// exponential distribution creates more points towards the center point
		/// weighted by the exponential function.
		/// </summary>
		// Token: 0x06015C89 RID: 89225 RVA: 0x001EBBAB File Offset: 0x001E9DAB
		public void SetDistributionToUniform()
		{
			vtkPointSource.vtkPointSource_SetDistributionToUniform_27(base.GetCppThis());
		}

		// Token: 0x06015C8A RID: 89226
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSource_SetLambda_28(HandleRef pThis, double _arg);

		/// <summary>
		/// If the distribution is set to exponential, then Lambda is used to
		/// scale the exponential distribution defined by
		/// f(x) = Lambda*exp(-Lambda*radius) where the radius is the distance
		/// from the Center of the point source. By default, the value of Lambda
		/// is Lambda=1.0.
		/// </summary>
		// Token: 0x06015C8B RID: 89227 RVA: 0x001EBBBA File Offset: 0x001E9DBA
		public virtual void SetLambda(double _arg)
		{
			vtkPointSource.vtkPointSource_SetLambda_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06015C8C RID: 89228
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSource_SetNumberOfPoints_29(HandleRef pThis, long _arg);

		/// <summary>
		/// Set the number of points to generate.
		/// </summary>
		// Token: 0x06015C8D RID: 89229 RVA: 0x001EBBCA File Offset: 0x001E9DCA
		public virtual void SetNumberOfPoints(long _arg)
		{
			vtkPointSource.vtkPointSource_SetNumberOfPoints_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06015C8E RID: 89230
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSource_SetOutputPointsPrecision_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015C8F RID: 89231 RVA: 0x001EBBDA File Offset: 0x001E9DDA
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkPointSource.vtkPointSource_SetOutputPointsPrecision_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06015C90 RID: 89232
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSource_SetRadius_31(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the radius of the point cloud.  If you are
		/// generating a Gaussian distribution, then this is
		/// the standard deviation for each of x, y, and z.
		/// </summary>
		// Token: 0x06015C91 RID: 89233 RVA: 0x001EBBEA File Offset: 0x001E9DEA
		public virtual void SetRadius(double _arg)
		{
			vtkPointSource.vtkPointSource_SetRadius_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06015C92 RID: 89234
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSource_SetRandomSequence_32(HandleRef pThis, HandleRef randomSequence);

		/// <summary>
		/// Set/Get a random sequence generator.
		/// By default, the generator in vtkMath is used to maintain backwards
		/// compatibility.
		/// </summary>
		// Token: 0x06015C93 RID: 89235 RVA: 0x001EBBFC File Offset: 0x001E9DFC
		public virtual void SetRandomSequence(vtkRandomSequence randomSequence)
		{
			vtkPointSource.vtkPointSource_SetRandomSequence_32(base.GetCppThis(), (randomSequence == null) ? default(HandleRef) : randomSequence.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018C7 RID: 6343
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018C8 RID: 6344
		public new static readonly string MRClassNameKey = "class vtkPointSource";
	}
}
