using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricSpline
	/// </summary>
	/// <remarks>
	///    parametric function for 1D interpolating splines
	///
	/// vtkParametricSpline is a parametric function for 1D interpolating splines.
	/// vtkParametricSpline maps the single parameter u into a 3D point (x,y,z)
	/// using three instances of interpolating splines.  This family of 1D splines
	/// is guaranteed to be parameterized in the interval [0,1].  Attempting to
	/// evaluate outside this interval will cause the parameter u to be clamped in
	/// the range [0,1].
	///
	/// When constructed, this class creates instances of vtkCardinalSpline for
	/// each of the x-y-z coordinates. The user may choose to replace these with
	/// their own instances of subclasses of vtkSpline.
	///
	/// @warning
	/// If you wish to tessellate the spline, use the class
	/// vtkParametricFunctionSource.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSpline vtkKochanekSpline vtkCardinalSpline
	/// </seealso>
	// Token: 0x02000930 RID: 2352
	public class vtkParametricSpline : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018562 RID: 99682 RVA: 0x00220CDF File Offset: 0x0021EEDF
		static vtkParametricSpline()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricSpline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricSpline"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018563 RID: 99683 RVA: 0x00220D07 File Offset: 0x0021EF07
		public vtkParametricSpline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018564 RID: 99684
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricSpline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct the spline with the following parameters:
		/// MinimumU = 0, MaximumU = 1, JoinU = 0 (unless the spline is
		/// closed, then JoinU = 1), TwistU = 0, DerivativesSupplied = 0
		/// (the other vtkParametricFunction parameters are ignored).
		/// </summary>
		// Token: 0x06018565 RID: 99685 RVA: 0x00220D18 File Offset: 0x0021EF18
		public new static vtkParametricSpline New()
		{
			vtkParametricSpline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricSpline.vtkParametricSpline_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricSpline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct the spline with the following parameters:
		/// MinimumU = 0, MaximumU = 1, JoinU = 0 (unless the spline is
		/// closed, then JoinU = 1), TwistU = 0, DerivativesSupplied = 0
		/// (the other vtkParametricFunction parameters are ignored).
		/// </summary>
		// Token: 0x06018566 RID: 99686 RVA: 0x00220D6C File Offset: 0x0021EF6C
		public vtkParametricSpline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricSpline.vtkParametricSpline_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018567 RID: 99687 RVA: 0x00220DB0 File Offset: 0x0021EFB0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018568 RID: 99688
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSpline_ClosedOff_01(HandleRef pThis);

		/// <summary>
		/// Control whether the spline is open or closed. A closed spline forms
		/// a continuous loop: the first and last points are the same, and
		/// derivatives are continuous.
		/// </summary>
		// Token: 0x06018569 RID: 99689 RVA: 0x00220DBB File Offset: 0x0021EFBB
		public virtual void ClosedOff()
		{
			vtkParametricSpline.vtkParametricSpline_ClosedOff_01(base.GetCppThis());
		}

		// Token: 0x0601856A RID: 99690
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSpline_ClosedOn_02(HandleRef pThis);

		/// <summary>
		/// Control whether the spline is open or closed. A closed spline forms
		/// a continuous loop: the first and last points are the same, and
		/// derivatives are continuous.
		/// </summary>
		// Token: 0x0601856B RID: 99691 RVA: 0x00220DCA File Offset: 0x0021EFCA
		public virtual void ClosedOn()
		{
			vtkParametricSpline.vtkParametricSpline_ClosedOn_02(base.GetCppThis());
		}

		// Token: 0x0601856C RID: 99692
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSpline_Evaluate_03(HandleRef pThis, IntPtr u, IntPtr Pt, IntPtr Du);

		/// <summary>
		/// Evaluate the spline at parametric coordinate u[0] returning
		/// the point coordinate Pt[3].
		/// </summary>
		// Token: 0x0601856D RID: 99693 RVA: 0x00220DD9 File Offset: 0x0021EFD9
		public override void Evaluate(IntPtr u, IntPtr Pt, IntPtr Du)
		{
			vtkParametricSpline.vtkParametricSpline_Evaluate_03(base.GetCppThis(), u, Pt, Du);
		}

		// Token: 0x0601856E RID: 99694
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricSpline_EvaluateScalar_04(HandleRef pThis, IntPtr u, IntPtr Pt, IntPtr Du);

		/// <summary>
		/// Evaluate a scalar value at parametric coordinate u[0] and Pt[3].
		/// The scalar value is just the parameter u[0].
		/// </summary>
		// Token: 0x0601856F RID: 99695 RVA: 0x00220DEC File Offset: 0x0021EFEC
		public override double EvaluateScalar(IntPtr u, IntPtr Pt, IntPtr Du)
		{
			return vtkParametricSpline.vtkParametricSpline_EvaluateScalar_04(base.GetCppThis(), u, Pt, Du);
		}

		// Token: 0x06018570 RID: 99696
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricSpline_GetClosed_05(HandleRef pThis);

		/// <summary>
		/// Control whether the spline is open or closed. A closed spline forms
		/// a continuous loop: the first and last points are the same, and
		/// derivatives are continuous.
		/// </summary>
		// Token: 0x06018571 RID: 99697 RVA: 0x00220E10 File Offset: 0x0021F010
		public virtual int GetClosed()
		{
			return vtkParametricSpline.vtkParametricSpline_GetClosed_05(base.GetCppThis());
		}

		// Token: 0x06018572 RID: 99698
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricSpline_GetDimension_06(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x06018573 RID: 99699 RVA: 0x00220E30 File Offset: 0x0021F030
		public override int GetDimension()
		{
			return vtkParametricSpline.vtkParametricSpline_GetDimension_06(base.GetCppThis());
		}

		// Token: 0x06018574 RID: 99700
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricSpline_GetLeftConstraint_07(HandleRef pThis);

		/// <summary>
		/// Set the type of constraint of the left(right) end points. Four
		/// constraints are available:
		///
		/// 0: the first derivative at left(right) most point is determined
		/// from the line defined from the first(last) two points.
		///
		/// 1: the first derivative at left(right) most point is set to
		/// Left(Right)Value.
		///
		/// 2: the second derivative at left(right) most point is set to
		/// Left(Right)Value.
		///
		/// 3: the second derivative at left(right)most points is Left(Right)Value
		/// times second derivative at first interior point.
		/// </summary>
		// Token: 0x06018575 RID: 99701 RVA: 0x00220E50 File Offset: 0x0021F050
		public virtual int GetLeftConstraint()
		{
			return vtkParametricSpline.vtkParametricSpline_GetLeftConstraint_07(base.GetCppThis());
		}

		// Token: 0x06018576 RID: 99702
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricSpline_GetLeftConstraintMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set the type of constraint of the left(right) end points. Four
		/// constraints are available:
		///
		/// 0: the first derivative at left(right) most point is determined
		/// from the line defined from the first(last) two points.
		///
		/// 1: the first derivative at left(right) most point is set to
		/// Left(Right)Value.
		///
		/// 2: the second derivative at left(right) most point is set to
		/// Left(Right)Value.
		///
		/// 3: the second derivative at left(right)most points is Left(Right)Value
		/// times second derivative at first interior point.
		/// </summary>
		// Token: 0x06018577 RID: 99703 RVA: 0x00220E70 File Offset: 0x0021F070
		public virtual int GetLeftConstraintMaxValue()
		{
			return vtkParametricSpline.vtkParametricSpline_GetLeftConstraintMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06018578 RID: 99704
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricSpline_GetLeftConstraintMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set the type of constraint of the left(right) end points. Four
		/// constraints are available:
		///
		/// 0: the first derivative at left(right) most point is determined
		/// from the line defined from the first(last) two points.
		///
		/// 1: the first derivative at left(right) most point is set to
		/// Left(Right)Value.
		///
		/// 2: the second derivative at left(right) most point is set to
		/// Left(Right)Value.
		///
		/// 3: the second derivative at left(right)most points is Left(Right)Value
		/// times second derivative at first interior point.
		/// </summary>
		// Token: 0x06018579 RID: 99705 RVA: 0x00220E90 File Offset: 0x0021F090
		public virtual int GetLeftConstraintMinValue()
		{
			return vtkParametricSpline.vtkParametricSpline_GetLeftConstraintMinValue_09(base.GetCppThis());
		}

		// Token: 0x0601857A RID: 99706
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricSpline_GetLeftValue_10(HandleRef pThis);

		/// <summary>
		/// The values of the derivative on the left and right sides. The value
		/// is used only if the left(right) constraint is type 1-3.
		/// </summary>
		// Token: 0x0601857B RID: 99707 RVA: 0x00220EB0 File Offset: 0x0021F0B0
		public virtual double GetLeftValue()
		{
			return vtkParametricSpline.vtkParametricSpline_GetLeftValue_10(base.GetCppThis());
		}

		// Token: 0x0601857C RID: 99708
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricSpline_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601857D RID: 99709 RVA: 0x00220ED0 File Offset: 0x0021F0D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricSpline.vtkParametricSpline_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0601857E RID: 99710
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricSpline_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601857F RID: 99711 RVA: 0x00220EF0 File Offset: 0x0021F0F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricSpline.vtkParametricSpline_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x06018580 RID: 99712
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricSpline_GetParameterizeByLength_13(HandleRef pThis);

		/// <summary>
		/// Control whether the spline is parameterized by length or by point index.
		/// Default is by length.
		/// </summary>
		// Token: 0x06018581 RID: 99713 RVA: 0x00220F0C File Offset: 0x0021F10C
		public virtual int GetParameterizeByLength()
		{
			return vtkParametricSpline.vtkParametricSpline_GetParameterizeByLength_13(base.GetCppThis());
		}

		// Token: 0x06018582 RID: 99714
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricSpline_GetPoints_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the list of points defining the spline. Do this by
		/// specifying a vtkPoints array containing the points. Note that
		/// the order of the points in vtkPoints is the order that the
		/// splines will be fit.
		/// </summary>
		// Token: 0x06018583 RID: 99715 RVA: 0x00220F2C File Offset: 0x0021F12C
		public virtual vtkPoints GetPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricSpline.vtkParametricSpline_GetPoints_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06018584 RID: 99716
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricSpline_GetRightConstraint_15(HandleRef pThis);

		/// <summary>
		/// Set the type of constraint of the left(right) end points. Four
		/// constraints are available:
		///
		/// 0: the first derivative at left(right) most point is determined
		/// from the line defined from the first(last) two points.
		///
		/// 1: the first derivative at left(right) most point is set to
		/// Left(Right)Value.
		///
		/// 2: the second derivative at left(right) most point is set to
		/// Left(Right)Value.
		///
		/// 3: the second derivative at left(right)most points is Left(Right)Value
		/// times second derivative at first interior point.
		/// </summary>
		// Token: 0x06018585 RID: 99717 RVA: 0x00220F9C File Offset: 0x0021F19C
		public virtual int GetRightConstraint()
		{
			return vtkParametricSpline.vtkParametricSpline_GetRightConstraint_15(base.GetCppThis());
		}

		// Token: 0x06018586 RID: 99718
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricSpline_GetRightConstraintMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Set the type of constraint of the left(right) end points. Four
		/// constraints are available:
		///
		/// 0: the first derivative at left(right) most point is determined
		/// from the line defined from the first(last) two points.
		///
		/// 1: the first derivative at left(right) most point is set to
		/// Left(Right)Value.
		///
		/// 2: the second derivative at left(right) most point is set to
		/// Left(Right)Value.
		///
		/// 3: the second derivative at left(right)most points is Left(Right)Value
		/// times second derivative at first interior point.
		/// </summary>
		// Token: 0x06018587 RID: 99719 RVA: 0x00220FBC File Offset: 0x0021F1BC
		public virtual int GetRightConstraintMaxValue()
		{
			return vtkParametricSpline.vtkParametricSpline_GetRightConstraintMaxValue_16(base.GetCppThis());
		}

		// Token: 0x06018588 RID: 99720
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricSpline_GetRightConstraintMinValue_17(HandleRef pThis);

		/// <summary>
		/// Set the type of constraint of the left(right) end points. Four
		/// constraints are available:
		///
		/// 0: the first derivative at left(right) most point is determined
		/// from the line defined from the first(last) two points.
		///
		/// 1: the first derivative at left(right) most point is set to
		/// Left(Right)Value.
		///
		/// 2: the second derivative at left(right) most point is set to
		/// Left(Right)Value.
		///
		/// 3: the second derivative at left(right)most points is Left(Right)Value
		/// times second derivative at first interior point.
		/// </summary>
		// Token: 0x06018589 RID: 99721 RVA: 0x00220FDC File Offset: 0x0021F1DC
		public virtual int GetRightConstraintMinValue()
		{
			return vtkParametricSpline.vtkParametricSpline_GetRightConstraintMinValue_17(base.GetCppThis());
		}

		// Token: 0x0601858A RID: 99722
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricSpline_GetRightValue_18(HandleRef pThis);

		/// <summary>
		/// The values of the derivative on the left and right sides. The value
		/// is used only if the left(right) constraint is type 1-3.
		/// </summary>
		// Token: 0x0601858B RID: 99723 RVA: 0x00220FFC File Offset: 0x0021F1FC
		public virtual double GetRightValue()
		{
			return vtkParametricSpline.vtkParametricSpline_GetRightValue_18(base.GetCppThis());
		}

		// Token: 0x0601858C RID: 99724
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricSpline_GetXSpline_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// By default, this class is constructed with three instances of
		/// vtkCardinalSpline (for each of the x-y-z coordinate axes). The user may
		/// choose to create and assign their own instances of vtkSpline.
		/// </summary>
		// Token: 0x0601858D RID: 99725 RVA: 0x0022101C File Offset: 0x0021F21C
		public virtual vtkSpline GetXSpline()
		{
			vtkSpline vtkSpline = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricSpline.vtkParametricSpline_GetXSpline_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpline = (vtkSpline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpline.Register(null);
				}
			}
			return vtkSpline;
		}

		// Token: 0x0601858E RID: 99726
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricSpline_GetYSpline_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// By default, this class is constructed with three instances of
		/// vtkCardinalSpline (for each of the x-y-z coordinate axes). The user may
		/// choose to create and assign their own instances of vtkSpline.
		/// </summary>
		// Token: 0x0601858F RID: 99727 RVA: 0x0022108C File Offset: 0x0021F28C
		public virtual vtkSpline GetYSpline()
		{
			vtkSpline vtkSpline = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricSpline.vtkParametricSpline_GetYSpline_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpline = (vtkSpline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpline.Register(null);
				}
			}
			return vtkSpline;
		}

		// Token: 0x06018590 RID: 99728
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricSpline_GetZSpline_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// By default, this class is constructed with three instances of
		/// vtkCardinalSpline (for each of the x-y-z coordinate axes). The user may
		/// choose to create and assign their own instances of vtkSpline.
		/// </summary>
		// Token: 0x06018591 RID: 99729 RVA: 0x002210FC File Offset: 0x0021F2FC
		public virtual vtkSpline GetZSpline()
		{
			vtkSpline vtkSpline = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricSpline.vtkParametricSpline_GetZSpline_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpline = (vtkSpline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpline.Register(null);
				}
			}
			return vtkSpline;
		}

		// Token: 0x06018592 RID: 99730
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricSpline_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018593 RID: 99731 RVA: 0x0022116C File Offset: 0x0021F36C
		public override int IsA(string type)
		{
			return vtkParametricSpline.vtkParametricSpline_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x06018594 RID: 99732
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricSpline_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018595 RID: 99733 RVA: 0x0022118C File Offset: 0x0021F38C
		public new static int IsTypeOf(string type)
		{
			return vtkParametricSpline.vtkParametricSpline_IsTypeOf_23(type);
		}

		// Token: 0x06018596 RID: 99734
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricSpline_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018597 RID: 99735 RVA: 0x002211A8 File Offset: 0x0021F3A8
		public new vtkParametricSpline NewInstance()
		{
			vtkParametricSpline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricSpline.vtkParametricSpline_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricSpline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018598 RID: 99736
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSpline_ParameterizeByLengthOff_26(HandleRef pThis);

		/// <summary>
		/// Control whether the spline is parameterized by length or by point index.
		/// Default is by length.
		/// </summary>
		// Token: 0x06018599 RID: 99737 RVA: 0x00221202 File Offset: 0x0021F402
		public virtual void ParameterizeByLengthOff()
		{
			vtkParametricSpline.vtkParametricSpline_ParameterizeByLengthOff_26(base.GetCppThis());
		}

		// Token: 0x0601859A RID: 99738
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSpline_ParameterizeByLengthOn_27(HandleRef pThis);

		/// <summary>
		/// Control whether the spline is parameterized by length or by point index.
		/// Default is by length.
		/// </summary>
		// Token: 0x0601859B RID: 99739 RVA: 0x00221211 File Offset: 0x0021F411
		public virtual void ParameterizeByLengthOn()
		{
			vtkParametricSpline.vtkParametricSpline_ParameterizeByLengthOn_27(base.GetCppThis());
		}

		// Token: 0x0601859C RID: 99740
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricSpline_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601859D RID: 99741 RVA: 0x00221220 File Offset: 0x0021F420
		public new static vtkParametricSpline SafeDownCast(vtkObjectBase o)
		{
			vtkParametricSpline vtkParametricSpline = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricSpline.vtkParametricSpline_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricSpline = (vtkParametricSpline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricSpline.Register(null);
				}
			}
			return vtkParametricSpline;
		}

		// Token: 0x0601859E RID: 99742
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSpline_SetClosed_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether the spline is open or closed. A closed spline forms
		/// a continuous loop: the first and last points are the same, and
		/// derivatives are continuous.
		/// </summary>
		// Token: 0x0601859F RID: 99743 RVA: 0x0022129F File Offset: 0x0021F49F
		public virtual void SetClosed(int _arg)
		{
			vtkParametricSpline.vtkParametricSpline_SetClosed_29(base.GetCppThis(), _arg);
		}

		// Token: 0x060185A0 RID: 99744
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSpline_SetLeftConstraint_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the type of constraint of the left(right) end points. Four
		/// constraints are available:
		///
		/// 0: the first derivative at left(right) most point is determined
		/// from the line defined from the first(last) two points.
		///
		/// 1: the first derivative at left(right) most point is set to
		/// Left(Right)Value.
		///
		/// 2: the second derivative at left(right) most point is set to
		/// Left(Right)Value.
		///
		/// 3: the second derivative at left(right)most points is Left(Right)Value
		/// times second derivative at first interior point.
		/// </summary>
		// Token: 0x060185A1 RID: 99745 RVA: 0x002212AF File Offset: 0x0021F4AF
		public virtual void SetLeftConstraint(int _arg)
		{
			vtkParametricSpline.vtkParametricSpline_SetLeftConstraint_30(base.GetCppThis(), _arg);
		}

		// Token: 0x060185A2 RID: 99746
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSpline_SetLeftValue_31(HandleRef pThis, double _arg);

		/// <summary>
		/// The values of the derivative on the left and right sides. The value
		/// is used only if the left(right) constraint is type 1-3.
		/// </summary>
		// Token: 0x060185A3 RID: 99747 RVA: 0x002212BF File Offset: 0x0021F4BF
		public virtual void SetLeftValue(double _arg)
		{
			vtkParametricSpline.vtkParametricSpline_SetLeftValue_31(base.GetCppThis(), _arg);
		}

		// Token: 0x060185A4 RID: 99748
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSpline_SetNumberOfPoints_32(HandleRef pThis, long numPts);

		/// <summary>
		/// Another API to set the points. Set the number of points and then set the
		/// individual point coordinates.
		/// </summary>
		// Token: 0x060185A5 RID: 99749 RVA: 0x002212CF File Offset: 0x0021F4CF
		public void SetNumberOfPoints(long numPts)
		{
			vtkParametricSpline.vtkParametricSpline_SetNumberOfPoints_32(base.GetCppThis(), numPts);
		}

		// Token: 0x060185A6 RID: 99750
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSpline_SetParameterizeByLength_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether the spline is parameterized by length or by point index.
		/// Default is by length.
		/// </summary>
		// Token: 0x060185A7 RID: 99751 RVA: 0x002212DF File Offset: 0x0021F4DF
		public virtual void SetParameterizeByLength(int _arg)
		{
			vtkParametricSpline.vtkParametricSpline_SetParameterizeByLength_33(base.GetCppThis(), _arg);
		}

		// Token: 0x060185A8 RID: 99752
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSpline_SetPoint_34(HandleRef pThis, long index, double x, double y, double z);

		/// <summary>
		/// Another API to set the points. Set the number of points and then set the
		/// individual point coordinates.
		/// </summary>
		// Token: 0x060185A9 RID: 99753 RVA: 0x002212EF File Offset: 0x0021F4EF
		public void SetPoint(long index, double x, double y, double z)
		{
			vtkParametricSpline.vtkParametricSpline_SetPoint_34(base.GetCppThis(), index, x, y, z);
		}

		// Token: 0x060185AA RID: 99754
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSpline_SetPoints_35(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the list of points defining the spline. Do this by
		/// specifying a vtkPoints array containing the points. Note that
		/// the order of the points in vtkPoints is the order that the
		/// splines will be fit.
		/// </summary>
		// Token: 0x060185AB RID: 99755 RVA: 0x00221304 File Offset: 0x0021F504
		public void SetPoints(vtkPoints arg0)
		{
			vtkParametricSpline.vtkParametricSpline_SetPoints_35(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060185AC RID: 99756
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSpline_SetRightConstraint_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the type of constraint of the left(right) end points. Four
		/// constraints are available:
		///
		/// 0: the first derivative at left(right) most point is determined
		/// from the line defined from the first(last) two points.
		///
		/// 1: the first derivative at left(right) most point is set to
		/// Left(Right)Value.
		///
		/// 2: the second derivative at left(right) most point is set to
		/// Left(Right)Value.
		///
		/// 3: the second derivative at left(right)most points is Left(Right)Value
		/// times second derivative at first interior point.
		/// </summary>
		// Token: 0x060185AD RID: 99757 RVA: 0x00221333 File Offset: 0x0021F533
		public virtual void SetRightConstraint(int _arg)
		{
			vtkParametricSpline.vtkParametricSpline_SetRightConstraint_36(base.GetCppThis(), _arg);
		}

		// Token: 0x060185AE RID: 99758
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSpline_SetRightValue_37(HandleRef pThis, double _arg);

		/// <summary>
		/// The values of the derivative on the left and right sides. The value
		/// is used only if the left(right) constraint is type 1-3.
		/// </summary>
		// Token: 0x060185AF RID: 99759 RVA: 0x00221343 File Offset: 0x0021F543
		public virtual void SetRightValue(double _arg)
		{
			vtkParametricSpline.vtkParametricSpline_SetRightValue_37(base.GetCppThis(), _arg);
		}

		// Token: 0x060185B0 RID: 99760
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSpline_SetXSpline_38(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// By default, this class is constructed with three instances of
		/// vtkCardinalSpline (for each of the x-y-z coordinate axes). The user may
		/// choose to create and assign their own instances of vtkSpline.
		/// </summary>
		// Token: 0x060185B1 RID: 99761 RVA: 0x00221354 File Offset: 0x0021F554
		public void SetXSpline(vtkSpline arg0)
		{
			vtkParametricSpline.vtkParametricSpline_SetXSpline_38(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060185B2 RID: 99762
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSpline_SetYSpline_39(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// By default, this class is constructed with three instances of
		/// vtkCardinalSpline (for each of the x-y-z coordinate axes). The user may
		/// choose to create and assign their own instances of vtkSpline.
		/// </summary>
		// Token: 0x060185B3 RID: 99763 RVA: 0x00221384 File Offset: 0x0021F584
		public void SetYSpline(vtkSpline arg0)
		{
			vtkParametricSpline.vtkParametricSpline_SetYSpline_39(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060185B4 RID: 99764
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSpline_SetZSpline_40(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// By default, this class is constructed with three instances of
		/// vtkCardinalSpline (for each of the x-y-z coordinate axes). The user may
		/// choose to create and assign their own instances of vtkSpline.
		/// </summary>
		// Token: 0x060185B5 RID: 99765 RVA: 0x002213B4 File Offset: 0x0021F5B4
		public void SetZSpline(vtkSpline arg0)
		{
			vtkParametricSpline.vtkParametricSpline_SetZSpline_40(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B0A RID: 6922
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricSpline";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B0B RID: 6923
		public new static readonly string MRClassNameKey = "class vtkParametricSpline";
	}
}
