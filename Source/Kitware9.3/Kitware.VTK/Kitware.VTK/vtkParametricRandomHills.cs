using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricRandomHills
	/// </summary>
	/// <remarks>
	///    Generate a surface covered with randomly placed hills.
	///
	/// vtkParametricRandomHills generates a surface covered with randomly placed
	/// hills. Hills will vary in shape and height since the presence
	/// of nearby hills will contribute to the shape and height of a given hill.
	/// An option is provided for placing hills on a regular grid on the surface.
	/// In this case the hills will all have the same shape and height.
	///
	/// For further information about this surface, please consult the
	/// technical description "Parametric surfaces" in http://www.vtk.org/publications
	/// in the "VTK Technical Documents" section in the VTk.org web pages.
	///
	/// @par Thanks:
	/// Andrew Maclean andrew.amaclean@gmail.com for creating and contributing the
	/// class.
	///
	/// </remarks>
	// Token: 0x0200092E RID: 2350
	public class vtkParametricRandomHills : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018502 RID: 99586 RVA: 0x00220593 File Offset: 0x0021E793
		static vtkParametricRandomHills()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricRandomHills.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricRandomHills"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018503 RID: 99587 RVA: 0x002205BB File Offset: 0x0021E7BB
		public vtkParametricRandomHills(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018504 RID: 99588
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricRandomHills_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a surface of random hills with the following parameters:
		/// MinimumU = -10, MaximumU = 10,
		/// MinimumV = -10, MaximumV = 10,
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0;
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 0,
		/// Number of hills = 30,
		/// Variance of the hills 2.5 in both x- and y- directions,
		/// Scaling factor for the variances 1/3 in both x- and y- directions,
		/// Amplitude of each hill = 2,
		/// Scaling factor for the amplitude = 1/3,
		/// RandomSeed = 1,
		/// AllowRandomGeneration = 1.
		/// </summary>
		// Token: 0x06018505 RID: 99589 RVA: 0x002205CC File Offset: 0x0021E7CC
		public new static vtkParametricRandomHills New()
		{
			vtkParametricRandomHills result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricRandomHills.vtkParametricRandomHills_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricRandomHills)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a surface of random hills with the following parameters:
		/// MinimumU = -10, MaximumU = 10,
		/// MinimumV = -10, MaximumV = 10,
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0;
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 0,
		/// Number of hills = 30,
		/// Variance of the hills 2.5 in both x- and y- directions,
		/// Scaling factor for the variances 1/3 in both x- and y- directions,
		/// Amplitude of each hill = 2,
		/// Scaling factor for the amplitude = 1/3,
		/// RandomSeed = 1,
		/// AllowRandomGeneration = 1.
		/// </summary>
		// Token: 0x06018506 RID: 99590 RVA: 0x00220620 File Offset: 0x0021E820
		public vtkParametricRandomHills() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricRandomHills.vtkParametricRandomHills_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018507 RID: 99591 RVA: 0x00220664 File Offset: 0x0021E864
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018508 RID: 99592
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricRandomHills_AllowRandomGenerationOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the random generation flag.
		/// A value of 0 will disable the generation of random hills on the surface
		/// allowing a reproducible number of identically shaped hills to be
		/// generated. If zero, then the number of hills used will be the nearest
		/// perfect square less than or equal to the number of hills.
		/// For example, selecting 30 hills will result in a 5 X 5 array of
		/// hills being generated. Thus a square array of hills will be generated.
		///
		/// Any other value means that the hills will be placed randomly on the
		/// surface.
		/// Default is 1.
		/// </summary>
		// Token: 0x06018509 RID: 99593 RVA: 0x0022066F File Offset: 0x0021E86F
		public virtual void AllowRandomGenerationOff()
		{
			vtkParametricRandomHills.vtkParametricRandomHills_AllowRandomGenerationOff_01(base.GetCppThis());
		}

		// Token: 0x0601850A RID: 99594
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricRandomHills_AllowRandomGenerationOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the random generation flag.
		/// A value of 0 will disable the generation of random hills on the surface
		/// allowing a reproducible number of identically shaped hills to be
		/// generated. If zero, then the number of hills used will be the nearest
		/// perfect square less than or equal to the number of hills.
		/// For example, selecting 30 hills will result in a 5 X 5 array of
		/// hills being generated. Thus a square array of hills will be generated.
		///
		/// Any other value means that the hills will be placed randomly on the
		/// surface.
		/// Default is 1.
		/// </summary>
		// Token: 0x0601850B RID: 99595 RVA: 0x0022067E File Offset: 0x0021E87E
		public virtual void AllowRandomGenerationOn()
		{
			vtkParametricRandomHills.vtkParametricRandomHills_AllowRandomGenerationOn_02(base.GetCppThis());
		}

		// Token: 0x0601850C RID: 99596
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricRandomHills_Evaluate_03(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Construct a terrain consisting of hills on a surface.
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), Du = (dx/du, dy/du, dz/du), Dv = (dx/dv, dy/dv, dz/dv)\f$ .
		/// Then the normal is \f$N = Du X Dv\f$ .
		/// </summary>
		// Token: 0x0601850D RID: 99597 RVA: 0x0022068D File Offset: 0x0021E88D
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricRandomHills.vtkParametricRandomHills_Evaluate_03(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x0601850E RID: 99598
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricRandomHills_EvaluateScalar_04(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Calculate a user defined scalar using one or all of uvw, Pt, Duvw.
		///
		/// uvw are the parameters with Pt being the Cartesian point,
		/// Duvw are the derivatives of this point with respect to u, v and w.
		/// Pt, Duvw are obtained from Evaluate().
		///
		/// This function is only called if the ScalarMode has the value
		/// vtkParametricFunctionSource::SCALAR_FUNCTION_DEFINED
		///
		/// If the user does not need to calculate a scalar, then the
		/// instantiated function should return zero.
		/// </summary>
		// Token: 0x0601850F RID: 99599 RVA: 0x002206A0 File Offset: 0x0021E8A0
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_EvaluateScalar_04(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x06018510 RID: 99600
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricRandomHills_GetAllowRandomGeneration_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the random generation flag.
		/// A value of 0 will disable the generation of random hills on the surface
		/// allowing a reproducible number of identically shaped hills to be
		/// generated. If zero, then the number of hills used will be the nearest
		/// perfect square less than or equal to the number of hills.
		/// For example, selecting 30 hills will result in a 5 X 5 array of
		/// hills being generated. Thus a square array of hills will be generated.
		///
		/// Any other value means that the hills will be placed randomly on the
		/// surface.
		/// Default is 1.
		/// </summary>
		// Token: 0x06018511 RID: 99601 RVA: 0x002206C4 File Offset: 0x0021E8C4
		public virtual int GetAllowRandomGeneration()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetAllowRandomGeneration_05(base.GetCppThis());
		}

		// Token: 0x06018512 RID: 99602
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricRandomHills_GetAllowRandomGenerationMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the random generation flag.
		/// A value of 0 will disable the generation of random hills on the surface
		/// allowing a reproducible number of identically shaped hills to be
		/// generated. If zero, then the number of hills used will be the nearest
		/// perfect square less than or equal to the number of hills.
		/// For example, selecting 30 hills will result in a 5 X 5 array of
		/// hills being generated. Thus a square array of hills will be generated.
		///
		/// Any other value means that the hills will be placed randomly on the
		/// surface.
		/// Default is 1.
		/// </summary>
		// Token: 0x06018513 RID: 99603 RVA: 0x002206E4 File Offset: 0x0021E8E4
		public virtual int GetAllowRandomGenerationMaxValue()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetAllowRandomGenerationMaxValue_06(base.GetCppThis());
		}

		// Token: 0x06018514 RID: 99604
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricRandomHills_GetAllowRandomGenerationMinValue_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the random generation flag.
		/// A value of 0 will disable the generation of random hills on the surface
		/// allowing a reproducible number of identically shaped hills to be
		/// generated. If zero, then the number of hills used will be the nearest
		/// perfect square less than or equal to the number of hills.
		/// For example, selecting 30 hills will result in a 5 X 5 array of
		/// hills being generated. Thus a square array of hills will be generated.
		///
		/// Any other value means that the hills will be placed randomly on the
		/// surface.
		/// Default is 1.
		/// </summary>
		// Token: 0x06018515 RID: 99605 RVA: 0x00220704 File Offset: 0x0021E904
		public virtual int GetAllowRandomGenerationMinValue()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetAllowRandomGenerationMinValue_07(base.GetCppThis());
		}

		// Token: 0x06018516 RID: 99606
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricRandomHills_GetAmplitudeScaleFactor_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the scaling factor for the amplitude.
		/// Default is 1/3.
		/// </summary>
		// Token: 0x06018517 RID: 99607 RVA: 0x00220724 File Offset: 0x0021E924
		public virtual double GetAmplitudeScaleFactor()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetAmplitudeScaleFactor_08(base.GetCppThis());
		}

		// Token: 0x06018518 RID: 99608
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricRandomHills_GetDimension_09(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x06018519 RID: 99609 RVA: 0x00220744 File Offset: 0x0021E944
		public override int GetDimension()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetDimension_09(base.GetCppThis());
		}

		// Token: 0x0601851A RID: 99610
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricRandomHills_GetHillAmplitude_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the hill amplitude (height).
		/// Default is 2.
		/// </summary>
		// Token: 0x0601851B RID: 99611 RVA: 0x00220764 File Offset: 0x0021E964
		public virtual double GetHillAmplitude()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetHillAmplitude_10(base.GetCppThis());
		}

		// Token: 0x0601851C RID: 99612
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricRandomHills_GetHillXVariance_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the hill variance in the x-direction.
		/// Default is 2.5.
		/// </summary>
		// Token: 0x0601851D RID: 99613 RVA: 0x00220784 File Offset: 0x0021E984
		public virtual double GetHillXVariance()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetHillXVariance_11(base.GetCppThis());
		}

		// Token: 0x0601851E RID: 99614
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricRandomHills_GetHillYVariance_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the hill variance in the y-direction.
		/// Default is 2.5.
		/// </summary>
		// Token: 0x0601851F RID: 99615 RVA: 0x002207A4 File Offset: 0x0021E9A4
		public virtual double GetHillYVariance()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetHillYVariance_12(base.GetCppThis());
		}

		// Token: 0x06018520 RID: 99616
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricRandomHills_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018521 RID: 99617 RVA: 0x002207C4 File Offset: 0x0021E9C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x06018522 RID: 99618
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricRandomHills_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018523 RID: 99619 RVA: 0x002207E4 File Offset: 0x0021E9E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x06018524 RID: 99620
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricRandomHills_GetNumberOfHills_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of hills.
		/// Default is 30.
		/// </summary>
		// Token: 0x06018525 RID: 99621 RVA: 0x00220800 File Offset: 0x0021EA00
		public virtual int GetNumberOfHills()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetNumberOfHills_15(base.GetCppThis());
		}

		// Token: 0x06018526 RID: 99622
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricRandomHills_GetRandomSeed_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the Seed for the random number generator,
		/// a value of 1 will initialize the random number generator,
		/// a negative value will initialize it with the system time.
		/// Default is 1.
		/// </summary>
		// Token: 0x06018527 RID: 99623 RVA: 0x00220820 File Offset: 0x0021EA20
		public virtual int GetRandomSeed()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetRandomSeed_16(base.GetCppThis());
		}

		// Token: 0x06018528 RID: 99624
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricRandomHills_GetXVarianceScaleFactor_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the scaling factor for the variance in the x-direction.
		/// Default is 1/3.
		/// </summary>
		// Token: 0x06018529 RID: 99625 RVA: 0x00220840 File Offset: 0x0021EA40
		public virtual double GetXVarianceScaleFactor()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetXVarianceScaleFactor_17(base.GetCppThis());
		}

		// Token: 0x0601852A RID: 99626
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricRandomHills_GetYVarianceScaleFactor_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the scaling factor for the variance in the y-direction.
		/// Default is 1/3.
		/// </summary>
		// Token: 0x0601852B RID: 99627 RVA: 0x00220860 File Offset: 0x0021EA60
		public virtual double GetYVarianceScaleFactor()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetYVarianceScaleFactor_18(base.GetCppThis());
		}

		// Token: 0x0601852C RID: 99628
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricRandomHills_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601852D RID: 99629 RVA: 0x00220880 File Offset: 0x0021EA80
		public override int IsA(string type)
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x0601852E RID: 99630
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricRandomHills_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601852F RID: 99631 RVA: 0x002208A0 File Offset: 0x0021EAA0
		public new static int IsTypeOf(string type)
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_IsTypeOf_20(type);
		}

		// Token: 0x06018530 RID: 99632
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricRandomHills_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018531 RID: 99633 RVA: 0x002208BC File Offset: 0x0021EABC
		public new vtkParametricRandomHills NewInstance()
		{
			vtkParametricRandomHills result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricRandomHills.vtkParametricRandomHills_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricRandomHills)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018532 RID: 99634
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricRandomHills_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018533 RID: 99635 RVA: 0x00220918 File Offset: 0x0021EB18
		public new static vtkParametricRandomHills SafeDownCast(vtkObjectBase o)
		{
			vtkParametricRandomHills vtkParametricRandomHills = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricRandomHills.vtkParametricRandomHills_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricRandomHills = (vtkParametricRandomHills)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricRandomHills.Register(null);
				}
			}
			return vtkParametricRandomHills;
		}

		// Token: 0x06018534 RID: 99636
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricRandomHills_SetAllowRandomGeneration_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the random generation flag.
		/// A value of 0 will disable the generation of random hills on the surface
		/// allowing a reproducible number of identically shaped hills to be
		/// generated. If zero, then the number of hills used will be the nearest
		/// perfect square less than or equal to the number of hills.
		/// For example, selecting 30 hills will result in a 5 X 5 array of
		/// hills being generated. Thus a square array of hills will be generated.
		///
		/// Any other value means that the hills will be placed randomly on the
		/// surface.
		/// Default is 1.
		/// </summary>
		// Token: 0x06018535 RID: 99637 RVA: 0x00220997 File Offset: 0x0021EB97
		public virtual void SetAllowRandomGeneration(int _arg)
		{
			vtkParametricRandomHills.vtkParametricRandomHills_SetAllowRandomGeneration_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06018536 RID: 99638
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricRandomHills_SetAmplitudeScaleFactor_25(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scaling factor for the amplitude.
		/// Default is 1/3.
		/// </summary>
		// Token: 0x06018537 RID: 99639 RVA: 0x002209A7 File Offset: 0x0021EBA7
		public virtual void SetAmplitudeScaleFactor(double _arg)
		{
			vtkParametricRandomHills.vtkParametricRandomHills_SetAmplitudeScaleFactor_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06018538 RID: 99640
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricRandomHills_SetHillAmplitude_26(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the hill amplitude (height).
		/// Default is 2.
		/// </summary>
		// Token: 0x06018539 RID: 99641 RVA: 0x002209B7 File Offset: 0x0021EBB7
		public virtual void SetHillAmplitude(double _arg)
		{
			vtkParametricRandomHills.vtkParametricRandomHills_SetHillAmplitude_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0601853A RID: 99642
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricRandomHills_SetHillXVariance_27(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the hill variance in the x-direction.
		/// Default is 2.5.
		/// </summary>
		// Token: 0x0601853B RID: 99643 RVA: 0x002209C7 File Offset: 0x0021EBC7
		public virtual void SetHillXVariance(double _arg)
		{
			vtkParametricRandomHills.vtkParametricRandomHills_SetHillXVariance_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0601853C RID: 99644
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricRandomHills_SetHillYVariance_28(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the hill variance in the y-direction.
		/// Default is 2.5.
		/// </summary>
		// Token: 0x0601853D RID: 99645 RVA: 0x002209D7 File Offset: 0x0021EBD7
		public virtual void SetHillYVariance(double _arg)
		{
			vtkParametricRandomHills.vtkParametricRandomHills_SetHillYVariance_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0601853E RID: 99646
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricRandomHills_SetNumberOfHills_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of hills.
		/// Default is 30.
		/// </summary>
		// Token: 0x0601853F RID: 99647 RVA: 0x002209E7 File Offset: 0x0021EBE7
		public virtual void SetNumberOfHills(int _arg)
		{
			vtkParametricRandomHills.vtkParametricRandomHills_SetNumberOfHills_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06018540 RID: 99648
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricRandomHills_SetRandomSeed_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the Seed for the random number generator,
		/// a value of 1 will initialize the random number generator,
		/// a negative value will initialize it with the system time.
		/// Default is 1.
		/// </summary>
		// Token: 0x06018541 RID: 99649 RVA: 0x002209F7 File Offset: 0x0021EBF7
		public virtual void SetRandomSeed(int _arg)
		{
			vtkParametricRandomHills.vtkParametricRandomHills_SetRandomSeed_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06018542 RID: 99650
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricRandomHills_SetXVarianceScaleFactor_31(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scaling factor for the variance in the x-direction.
		/// Default is 1/3.
		/// </summary>
		// Token: 0x06018543 RID: 99651 RVA: 0x00220A07 File Offset: 0x0021EC07
		public virtual void SetXVarianceScaleFactor(double _arg)
		{
			vtkParametricRandomHills.vtkParametricRandomHills_SetXVarianceScaleFactor_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06018544 RID: 99652
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricRandomHills_SetYVarianceScaleFactor_32(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scaling factor for the variance in the y-direction.
		/// Default is 1/3.
		/// </summary>
		// Token: 0x06018545 RID: 99653 RVA: 0x00220A17 File Offset: 0x0021EC17
		public virtual void SetYVarianceScaleFactor(double _arg)
		{
			vtkParametricRandomHills.vtkParametricRandomHills_SetYVarianceScaleFactor_32(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B06 RID: 6918
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricRandomHills";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B07 RID: 6919
		public new static readonly string MRClassNameKey = "class vtkParametricRandomHills";
	}
}
