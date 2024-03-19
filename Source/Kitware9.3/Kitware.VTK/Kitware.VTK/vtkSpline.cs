using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSpline
	/// </summary>
	/// <remarks>
	///    spline abstract class for interpolating splines
	///
	/// vtkSpline interpolates a set of data points (i.e., interpolation means
	/// that the spline passes through the points).  vtkSpline is an abstract
	/// class: its subclasses vtkCardinalSpline and vtkKochanekSpline do the
	/// interpolation. Note that this spline maps the 1D parametric coordinate
	/// t into a single value x. Thus if you want to use the spline to
	/// interpolate points (i.e. x[3]), you have to create three splines for
	/// each of the x-y-z coordinates. Fortunately, the vtkParametricSpline
	/// class does this for you.
	///
	/// Typically a spline is used by adding a sequence of parametric coordinate /
	/// data (t,x) values followed by use of an evaluation function (e.g.,
	/// vtkCardinalSpline::Evaluate()).  Since these splines are 1D, a point in
	/// this context is an independent / dependent variable pair.
	///
	/// Splines can also be set up to be closed or open. Closed splines continue
	/// from the last point to the first point with continuous function and
	/// derivative values. (You don't need to duplicate the first point to close
	/// the spline, just set ClosedOn.)
	///
	/// This implementation of splines does not use a normalized parametric
	/// coordinate. If the spline is open, then the parameter space is (tMin &lt;= t
	/// &lt;= tMax) where tMin and tMax are the minimum and maximum parametric values
	/// seen when performing AddPoint(). If the spline is closed, then the
	/// parameter space is (tMin &lt;= t &lt;= (tMax+1)) where tMin and tMax are the
	/// minimum and maximum parametric values seen when performing AddPoint().
	/// Note, however, that this behavior can be changed by explicitly setting
	/// the ParametricRange(tMin,tMax). If set, the parameter space remains
	/// (tMin &lt;= t &lt;= tMax), except that additions of data with parametric
	/// values outside this range are clamped within this range.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCardinalSpline vtkKochanekSpline vtkParametricSpline
	/// vtkParametricFunctionSource
	/// </seealso>
	// Token: 0x02000085 RID: 133
	public abstract class vtkSpline : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001A00 RID: 6656 RVA: 0x00029B09 File Offset: 0x00027D09
		static vtkSpline()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSpline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpline"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001A01 RID: 6657 RVA: 0x00029B31 File Offset: 0x00027D31
		public vtkSpline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001A02 RID: 6658 RVA: 0x00029B3F File Offset: 0x00027D3F
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001A03 RID: 6659
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpline_AddPoint_01(HandleRef pThis, double t, double x);

		/// <summary>
		/// Add a pair of points to be fit with the spline.
		/// </summary>
		// Token: 0x06001A04 RID: 6660 RVA: 0x00029B4A File Offset: 0x00027D4A
		public void AddPoint(double t, double x)
		{
			vtkSpline.vtkSpline_AddPoint_01(base.GetCppThis(), t, x);
		}

		// Token: 0x06001A05 RID: 6661
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpline_ClampValueOff_02(HandleRef pThis);

		/// <summary>
		/// Set/Get ClampValue. If On, results of the interpolation will be
		/// clamped to the min/max of the input data.
		/// </summary>
		// Token: 0x06001A06 RID: 6662 RVA: 0x00029B5B File Offset: 0x00027D5B
		public virtual void ClampValueOff()
		{
			vtkSpline.vtkSpline_ClampValueOff_02(base.GetCppThis());
		}

		// Token: 0x06001A07 RID: 6663
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpline_ClampValueOn_03(HandleRef pThis);

		/// <summary>
		/// Set/Get ClampValue. If On, results of the interpolation will be
		/// clamped to the min/max of the input data.
		/// </summary>
		// Token: 0x06001A08 RID: 6664 RVA: 0x00029B6A File Offset: 0x00027D6A
		public virtual void ClampValueOn()
		{
			vtkSpline.vtkSpline_ClampValueOn_03(base.GetCppThis());
		}

		// Token: 0x06001A09 RID: 6665
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpline_ClosedOff_04(HandleRef pThis);

		/// <summary>
		/// Control whether the spline is open or closed. A closed spline forms
		/// a continuous loop: the first and last points are the same, and
		/// derivatives are continuous.
		/// </summary>
		// Token: 0x06001A0A RID: 6666 RVA: 0x00029B79 File Offset: 0x00027D79
		public virtual void ClosedOff()
		{
			vtkSpline.vtkSpline_ClosedOff_04(base.GetCppThis());
		}

		// Token: 0x06001A0B RID: 6667
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpline_ClosedOn_05(HandleRef pThis);

		/// <summary>
		/// Control whether the spline is open or closed. A closed spline forms
		/// a continuous loop: the first and last points are the same, and
		/// derivatives are continuous.
		/// </summary>
		// Token: 0x06001A0C RID: 6668 RVA: 0x00029B88 File Offset: 0x00027D88
		public virtual void ClosedOn()
		{
			vtkSpline.vtkSpline_ClosedOn_05(base.GetCppThis());
		}

		// Token: 0x06001A0D RID: 6669
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpline_Compute_06(HandleRef pThis);

		/// <summary>
		/// Compute the coefficients for the spline.
		/// </summary>
		// Token: 0x06001A0E RID: 6670 RVA: 0x00029B97 File Offset: 0x00027D97
		public virtual void Compute()
		{
			vtkSpline.vtkSpline_Compute_06(base.GetCppThis());
		}

		// Token: 0x06001A0F RID: 6671
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpline_DeepCopy_07(HandleRef pThis, HandleRef s);

		/// <summary>
		/// Deep copy of spline data.
		/// </summary>
		// Token: 0x06001A10 RID: 6672 RVA: 0x00029BA8 File Offset: 0x00027DA8
		public virtual void DeepCopy(vtkSpline s)
		{
			vtkSpline.vtkSpline_DeepCopy_07(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		// Token: 0x06001A11 RID: 6673
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSpline_Evaluate_08(HandleRef pThis, double t);

		/// <summary>
		/// Interpolate the value of the spline at parametric location of t.
		/// </summary>
		// Token: 0x06001A12 RID: 6674 RVA: 0x00029BD8 File Offset: 0x00027DD8
		public virtual double Evaluate(double t)
		{
			return vtkSpline.vtkSpline_Evaluate_08(base.GetCppThis(), t);
		}

		// Token: 0x06001A13 RID: 6675
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpline_FillFromDataPointer_09(HandleRef pThis, int nb, IntPtr data);

		/// <summary>
		/// Add all the points to the list of points in one time,
		/// and then sort them only once. Much faster than using
		/// AddPoint for each point.
		///
		/// Note that the data is copied and this method does not
		/// take ownership of the parameter array.
		/// </summary>
		// Token: 0x06001A14 RID: 6676 RVA: 0x00029BF8 File Offset: 0x00027DF8
		public void FillFromDataPointer(int nb, IntPtr data)
		{
			vtkSpline.vtkSpline_FillFromDataPointer_09(base.GetCppThis(), nb, data);
		}

		// Token: 0x06001A15 RID: 6677
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpline_GetClampValue_10(HandleRef pThis);

		/// <summary>
		/// Set/Get ClampValue. If On, results of the interpolation will be
		/// clamped to the min/max of the input data.
		/// </summary>
		// Token: 0x06001A16 RID: 6678 RVA: 0x00029C0C File Offset: 0x00027E0C
		public virtual int GetClampValue()
		{
			return vtkSpline.vtkSpline_GetClampValue_10(base.GetCppThis());
		}

		// Token: 0x06001A17 RID: 6679
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpline_GetClosed_11(HandleRef pThis);

		/// <summary>
		/// Control whether the spline is open or closed. A closed spline forms
		/// a continuous loop: the first and last points are the same, and
		/// derivatives are continuous.
		/// </summary>
		// Token: 0x06001A18 RID: 6680 RVA: 0x00029C2C File Offset: 0x00027E2C
		public virtual int GetClosed()
		{
			return vtkSpline.vtkSpline_GetClosed_11(base.GetCppThis());
		}

		// Token: 0x06001A19 RID: 6681
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpline_GetLeftConstraint_12(HandleRef pThis);

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
		// Token: 0x06001A1A RID: 6682 RVA: 0x00029C4C File Offset: 0x00027E4C
		public virtual int GetLeftConstraint()
		{
			return vtkSpline.vtkSpline_GetLeftConstraint_12(base.GetCppThis());
		}

		// Token: 0x06001A1B RID: 6683
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpline_GetLeftConstraintMaxValue_13(HandleRef pThis);

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
		// Token: 0x06001A1C RID: 6684 RVA: 0x00029C6C File Offset: 0x00027E6C
		public virtual int GetLeftConstraintMaxValue()
		{
			return vtkSpline.vtkSpline_GetLeftConstraintMaxValue_13(base.GetCppThis());
		}

		// Token: 0x06001A1D RID: 6685
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpline_GetLeftConstraintMinValue_14(HandleRef pThis);

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
		// Token: 0x06001A1E RID: 6686 RVA: 0x00029C8C File Offset: 0x00027E8C
		public virtual int GetLeftConstraintMinValue()
		{
			return vtkSpline.vtkSpline_GetLeftConstraintMinValue_14(base.GetCppThis());
		}

		// Token: 0x06001A1F RID: 6687
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSpline_GetLeftValue_15(HandleRef pThis);

		/// <summary>
		/// The values of the derivative on the left and right sides. The value
		/// is used only if the left(right) constraint is type 1-3.
		/// </summary>
		// Token: 0x06001A20 RID: 6688 RVA: 0x00029CAC File Offset: 0x00027EAC
		public virtual double GetLeftValue()
		{
			return vtkSpline.vtkSpline_GetLeftValue_15(base.GetCppThis());
		}

		// Token: 0x06001A21 RID: 6689
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkSpline_GetMTime_16(HandleRef pThis);

		/// <summary>
		/// Return the MTime also considering the Piecewise function.
		/// </summary>
		// Token: 0x06001A22 RID: 6690 RVA: 0x00029CCC File Offset: 0x00027ECC
		public override ulong GetMTime()
		{
			return vtkSpline.vtkSpline_GetMTime_16(base.GetCppThis());
		}

		// Token: 0x06001A23 RID: 6691
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpline_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A24 RID: 6692 RVA: 0x00029CEC File Offset: 0x00027EEC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSpline.vtkSpline_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x06001A25 RID: 6693
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpline_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A26 RID: 6694 RVA: 0x00029D0C File Offset: 0x00027F0C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSpline.vtkSpline_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x06001A27 RID: 6695
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpline_GetNumberOfPoints_19(HandleRef pThis);

		/// <summary>
		/// Return the number of points inserted thus far.
		/// </summary>
		// Token: 0x06001A28 RID: 6696 RVA: 0x00029D28 File Offset: 0x00027F28
		public int GetNumberOfPoints()
		{
			return vtkSpline.vtkSpline_GetNumberOfPoints_19(base.GetCppThis());
		}

		// Token: 0x06001A29 RID: 6697
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpline_GetParametricRange_20(HandleRef pThis, IntPtr tRange);

		/// <summary>
		/// Set/Get the parametric range. If not set, the range is determined
		/// implicitly by keeping track of the (min,max) parameter values for
		/// t. If set, the AddPoint() method will clamp the t value to lie
		/// within the specified range.
		/// </summary>
		// Token: 0x06001A2A RID: 6698 RVA: 0x00029D47 File Offset: 0x00027F47
		public void GetParametricRange(IntPtr tRange)
		{
			vtkSpline.vtkSpline_GetParametricRange_20(base.GetCppThis(), tRange);
		}

		// Token: 0x06001A2B RID: 6699
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpline_GetRightConstraint_21(HandleRef pThis);

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
		// Token: 0x06001A2C RID: 6700 RVA: 0x00029D58 File Offset: 0x00027F58
		public virtual int GetRightConstraint()
		{
			return vtkSpline.vtkSpline_GetRightConstraint_21(base.GetCppThis());
		}

		// Token: 0x06001A2D RID: 6701
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpline_GetRightConstraintMaxValue_22(HandleRef pThis);

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
		// Token: 0x06001A2E RID: 6702 RVA: 0x00029D78 File Offset: 0x00027F78
		public virtual int GetRightConstraintMaxValue()
		{
			return vtkSpline.vtkSpline_GetRightConstraintMaxValue_22(base.GetCppThis());
		}

		// Token: 0x06001A2F RID: 6703
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpline_GetRightConstraintMinValue_23(HandleRef pThis);

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
		// Token: 0x06001A30 RID: 6704 RVA: 0x00029D98 File Offset: 0x00027F98
		public virtual int GetRightConstraintMinValue()
		{
			return vtkSpline.vtkSpline_GetRightConstraintMinValue_23(base.GetCppThis());
		}

		// Token: 0x06001A31 RID: 6705
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSpline_GetRightValue_24(HandleRef pThis);

		/// <summary>
		/// The values of the derivative on the left and right sides. The value
		/// is used only if the left(right) constraint is type 1-3.
		/// </summary>
		// Token: 0x06001A32 RID: 6706 RVA: 0x00029DB8 File Offset: 0x00027FB8
		public virtual double GetRightValue()
		{
			return vtkSpline.vtkSpline_GetRightValue_24(base.GetCppThis());
		}

		// Token: 0x06001A33 RID: 6707
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpline_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A34 RID: 6708 RVA: 0x00029DD8 File Offset: 0x00027FD8
		public override int IsA(string type)
		{
			return vtkSpline.vtkSpline_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x06001A35 RID: 6709
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpline_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A36 RID: 6710 RVA: 0x00029DF8 File Offset: 0x00027FF8
		public new static int IsTypeOf(string type)
		{
			return vtkSpline.vtkSpline_IsTypeOf_26(type);
		}

		// Token: 0x06001A37 RID: 6711
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpline_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A38 RID: 6712 RVA: 0x00029E14 File Offset: 0x00028014
		public new vtkSpline NewInstance()
		{
			vtkSpline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpline.vtkSpline_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001A39 RID: 6713
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpline_RemoveAllPoints_28(HandleRef pThis);

		/// <summary>
		/// Remove all points from the data.
		/// </summary>
		// Token: 0x06001A3A RID: 6714 RVA: 0x00029E6E File Offset: 0x0002806E
		public void RemoveAllPoints()
		{
			vtkSpline.vtkSpline_RemoveAllPoints_28(base.GetCppThis());
		}

		// Token: 0x06001A3B RID: 6715
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpline_RemovePoint_29(HandleRef pThis, double t);

		/// <summary>
		/// Remove a point from the data to be fit with the spline.
		/// </summary>
		// Token: 0x06001A3C RID: 6716 RVA: 0x00029E7D File Offset: 0x0002807D
		public void RemovePoint(double t)
		{
			vtkSpline.vtkSpline_RemovePoint_29(base.GetCppThis(), t);
		}

		// Token: 0x06001A3D RID: 6717
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpline_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A3E RID: 6718 RVA: 0x00029E90 File Offset: 0x00028090
		public new static vtkSpline SafeDownCast(vtkObjectBase o)
		{
			vtkSpline vtkSpline = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpline.vtkSpline_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06001A3F RID: 6719
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpline_SetClampValue_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get ClampValue. If On, results of the interpolation will be
		/// clamped to the min/max of the input data.
		/// </summary>
		// Token: 0x06001A40 RID: 6720 RVA: 0x00029F0F File Offset: 0x0002810F
		public virtual void SetClampValue(int _arg)
		{
			vtkSpline.vtkSpline_SetClampValue_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06001A41 RID: 6721
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpline_SetClosed_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether the spline is open or closed. A closed spline forms
		/// a continuous loop: the first and last points are the same, and
		/// derivatives are continuous.
		/// </summary>
		// Token: 0x06001A42 RID: 6722 RVA: 0x00029F1F File Offset: 0x0002811F
		public virtual void SetClosed(int _arg)
		{
			vtkSpline.vtkSpline_SetClosed_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06001A43 RID: 6723
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpline_SetLeftConstraint_33(HandleRef pThis, int _arg);

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
		// Token: 0x06001A44 RID: 6724 RVA: 0x00029F2F File Offset: 0x0002812F
		public virtual void SetLeftConstraint(int _arg)
		{
			vtkSpline.vtkSpline_SetLeftConstraint_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06001A45 RID: 6725
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpline_SetLeftValue_34(HandleRef pThis, double _arg);

		/// <summary>
		/// The values of the derivative on the left and right sides. The value
		/// is used only if the left(right) constraint is type 1-3.
		/// </summary>
		// Token: 0x06001A46 RID: 6726 RVA: 0x00029F3F File Offset: 0x0002813F
		public virtual void SetLeftValue(double _arg)
		{
			vtkSpline.vtkSpline_SetLeftValue_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06001A47 RID: 6727
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpline_SetParametricRange_35(HandleRef pThis, double tMin, double tMax);

		/// <summary>
		/// Set/Get the parametric range. If not set, the range is determined
		/// implicitly by keeping track of the (min,max) parameter values for
		/// t. If set, the AddPoint() method will clamp the t value to lie
		/// within the specified range.
		/// </summary>
		// Token: 0x06001A48 RID: 6728 RVA: 0x00029F4F File Offset: 0x0002814F
		public void SetParametricRange(double tMin, double tMax)
		{
			vtkSpline.vtkSpline_SetParametricRange_35(base.GetCppThis(), tMin, tMax);
		}

		// Token: 0x06001A49 RID: 6729
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpline_SetParametricRange_36(HandleRef pThis, IntPtr tRange);

		/// <summary>
		/// Set/Get the parametric range. If not set, the range is determined
		/// implicitly by keeping track of the (min,max) parameter values for
		/// t. If set, the AddPoint() method will clamp the t value to lie
		/// within the specified range.
		/// </summary>
		// Token: 0x06001A4A RID: 6730 RVA: 0x00029F60 File Offset: 0x00028160
		public void SetParametricRange(IntPtr tRange)
		{
			vtkSpline.vtkSpline_SetParametricRange_36(base.GetCppThis(), tRange);
		}

		// Token: 0x06001A4B RID: 6731
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpline_SetRightConstraint_37(HandleRef pThis, int _arg);

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
		// Token: 0x06001A4C RID: 6732 RVA: 0x00029F70 File Offset: 0x00028170
		public virtual void SetRightConstraint(int _arg)
		{
			vtkSpline.vtkSpline_SetRightConstraint_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06001A4D RID: 6733
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpline_SetRightValue_38(HandleRef pThis, double _arg);

		/// <summary>
		/// The values of the derivative on the left and right sides. The value
		/// is used only if the left(right) constraint is type 1-3.
		/// </summary>
		// Token: 0x06001A4E RID: 6734 RVA: 0x00029F80 File Offset: 0x00028180
		public virtual void SetRightValue(double _arg)
		{
			vtkSpline.vtkSpline_SetRightValue_38(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004A8 RID: 1192
		public new const string MRFullTypeName = "Kitware.VTK.vtkSpline";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004A9 RID: 1193
		public new static readonly string MRClassNameKey = "class vtkSpline";
	}
}
