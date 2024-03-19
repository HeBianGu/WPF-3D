using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkArcSource
	/// </summary>
	/// <remarks>
	///    create a circular arc
	///
	///
	/// vtkArcSource is a source object that creates an arc defined by two
	/// endpoints and a center. The number of segments composing the polyline
	/// is controlled by setting the object resolution.
	/// Alternatively, one can use a better API (that does not allow for
	/// inconsistent nor ambiguous inputs), using a starting point (polar vector,
	/// measured from the arc's center), a normal to the plane of the arc,
	/// and an angle defining the arc length.
	/// Since the default API remains the original one, in order to use
	/// the improved API, one must switch the UseNormalAndAngle flag to TRUE.
	///
	/// The development of an improved, consistent API (based on point, normal,
	/// and angle) was supported by CEA/DIF - Commissariat a l'Energie Atomique,
	/// Centre DAM Ile-De-France, BP12, F-91297 Arpajon, France, and implemented
	/// by Philippe Pebay, Kitware SAS 2012.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkEllipseArcSource
	/// </seealso>
	// Token: 0x0200081C RID: 2076
	public class vtkArcSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601562D RID: 87597 RVA: 0x001E464B File Offset: 0x001E284B
		static vtkArcSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArcSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArcSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601562E RID: 87598 RVA: 0x001E4673 File Offset: 0x001E2873
		public vtkArcSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601562F RID: 87599
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArcSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015630 RID: 87600 RVA: 0x001E4684 File Offset: 0x001E2884
		public new static vtkArcSource New()
		{
			vtkArcSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArcSource.vtkArcSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArcSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015631 RID: 87601 RVA: 0x001E46D8 File Offset: 0x001E28D8
		public vtkArcSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkArcSource.vtkArcSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015632 RID: 87602 RVA: 0x001E471C File Offset: 0x001E291C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015633 RID: 87603
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArcSource_GetAngle_01(HandleRef pThis);

		/// <summary>
		/// Arc length (in degrees), beginning at the polar vector.
		/// The direction is counterclockwise by default;
		/// a negative value draws the arc in the clockwise direction.
		/// Note: This is only used when UseNormalAndAngle is ON.
		/// </summary>
		// Token: 0x06015634 RID: 87604 RVA: 0x001E4728 File Offset: 0x001E2928
		public virtual double GetAngle()
		{
			return vtkArcSource.vtkArcSource_GetAngle_01(base.GetCppThis());
		}

		// Token: 0x06015635 RID: 87605
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArcSource_GetAngleMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Arc length (in degrees), beginning at the polar vector.
		/// The direction is counterclockwise by default;
		/// a negative value draws the arc in the clockwise direction.
		/// Note: This is only used when UseNormalAndAngle is ON.
		/// </summary>
		// Token: 0x06015636 RID: 87606 RVA: 0x001E4748 File Offset: 0x001E2948
		public virtual double GetAngleMaxValue()
		{
			return vtkArcSource.vtkArcSource_GetAngleMaxValue_02(base.GetCppThis());
		}

		// Token: 0x06015637 RID: 87607
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArcSource_GetAngleMinValue_03(HandleRef pThis);

		/// <summary>
		/// Arc length (in degrees), beginning at the polar vector.
		/// The direction is counterclockwise by default;
		/// a negative value draws the arc in the clockwise direction.
		/// Note: This is only used when UseNormalAndAngle is ON.
		/// </summary>
		// Token: 0x06015638 RID: 87608 RVA: 0x001E4768 File Offset: 0x001E2968
		public virtual double GetAngleMinValue()
		{
			return vtkArcSource.vtkArcSource_GetAngleMinValue_03(base.GetCppThis());
		}

		// Token: 0x06015639 RID: 87609
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArcSource_GetCenter_04(HandleRef pThis);

		/// <summary>
		/// Set position of the center of the circle that defines the arc.
		/// Note: you can use the function vtkMath::Solve3PointCircle to
		/// find the center from 3 points located on a circle.
		/// </summary>
		// Token: 0x0601563A RID: 87610 RVA: 0x001E4788 File Offset: 0x001E2988
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkArcSource.vtkArcSource_GetCenter_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601563B RID: 87611
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_GetCenter_05(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set position of the center of the circle that defines the arc.
		/// Note: you can use the function vtkMath::Solve3PointCircle to
		/// find the center from 3 points located on a circle.
		/// </summary>
		// Token: 0x0601563C RID: 87612 RVA: 0x001E47D0 File Offset: 0x001E29D0
		public virtual void GetCenter(IntPtr data)
		{
			vtkArcSource.vtkArcSource_GetCenter_05(base.GetCppThis(), data);
		}

		// Token: 0x0601563D RID: 87613
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkArcSource_GetNegative_06(HandleRef pThis);

		/// <summary>
		/// By default the arc spans the shortest angular sector point1 and point2.
		/// By setting this to true, the longest angular sector is used instead
		/// (i.e. the negative coterminal angle to the shortest one).
		/// Note: This is only used when UseNormalAndAngle is OFF. False by default.
		/// </summary>
		// Token: 0x0601563E RID: 87614 RVA: 0x001E47E0 File Offset: 0x001E29E0
		public virtual bool GetNegative()
		{
			return vtkArcSource.vtkArcSource_GetNegative_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0601563F RID: 87615
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArcSource_GetNormal_07(HandleRef pThis);

		/// <summary>
		/// Set the normal vector to the plane of the arc.
		/// By default it points in the positive Z direction.
		/// Note: This is only used when UseNormalAndAngle is ON.
		/// </summary>
		// Token: 0x06015640 RID: 87616 RVA: 0x001E4808 File Offset: 0x001E2A08
		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkArcSource.vtkArcSource_GetNormal_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015641 RID: 87617
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_GetNormal_08(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the normal vector to the plane of the arc.
		/// By default it points in the positive Z direction.
		/// Note: This is only used when UseNormalAndAngle is ON.
		/// </summary>
		// Token: 0x06015642 RID: 87618 RVA: 0x001E4850 File Offset: 0x001E2A50
		public virtual void GetNormal(IntPtr data)
		{
			vtkArcSource.vtkArcSource_GetNormal_08(base.GetCppThis(), data);
		}

		// Token: 0x06015643 RID: 87619
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArcSource_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015644 RID: 87620 RVA: 0x001E4860 File Offset: 0x001E2A60
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkArcSource.vtkArcSource_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06015645 RID: 87621
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArcSource_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015646 RID: 87622 RVA: 0x001E4880 File Offset: 0x001E2A80
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkArcSource.vtkArcSource_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06015647 RID: 87623
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArcSource_GetOutputPointsPrecision_11(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015648 RID: 87624 RVA: 0x001E489C File Offset: 0x001E2A9C
		public virtual int GetOutputPointsPrecision()
		{
			return vtkArcSource.vtkArcSource_GetOutputPointsPrecision_11(base.GetCppThis());
		}

		// Token: 0x06015649 RID: 87625
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArcSource_GetPoint1_12(HandleRef pThis);

		/// <summary>
		/// Set position of the first end point.
		/// </summary>
		// Token: 0x0601564A RID: 87626 RVA: 0x001E48BC File Offset: 0x001E2ABC
		public virtual double[] GetPoint1()
		{
			IntPtr intPtr = vtkArcSource.vtkArcSource_GetPoint1_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601564B RID: 87627
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_GetPoint1_13(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set position of the first end point.
		/// </summary>
		// Token: 0x0601564C RID: 87628 RVA: 0x001E4904 File Offset: 0x001E2B04
		public virtual void GetPoint1(IntPtr data)
		{
			vtkArcSource.vtkArcSource_GetPoint1_13(base.GetCppThis(), data);
		}

		// Token: 0x0601564D RID: 87629
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArcSource_GetPoint2_14(HandleRef pThis);

		/// <summary>
		/// Set position of the other end point.
		/// </summary>
		// Token: 0x0601564E RID: 87630 RVA: 0x001E4914 File Offset: 0x001E2B14
		public virtual double[] GetPoint2()
		{
			IntPtr intPtr = vtkArcSource.vtkArcSource_GetPoint2_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601564F RID: 87631
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_GetPoint2_15(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set position of the other end point.
		/// </summary>
		// Token: 0x06015650 RID: 87632 RVA: 0x001E495C File Offset: 0x001E2B5C
		public virtual void GetPoint2(IntPtr data)
		{
			vtkArcSource.vtkArcSource_GetPoint2_15(base.GetCppThis(), data);
		}

		// Token: 0x06015651 RID: 87633
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArcSource_GetPolarVector_16(HandleRef pThis);

		/// <summary>
		/// Set polar vector (starting point of the arc).
		/// By default it is the unit vector in the positive X direction.
		/// Note: This is only used when UseNormalAndAngle is ON.
		/// </summary>
		// Token: 0x06015652 RID: 87634 RVA: 0x001E496C File Offset: 0x001E2B6C
		public virtual double[] GetPolarVector()
		{
			IntPtr intPtr = vtkArcSource.vtkArcSource_GetPolarVector_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015653 RID: 87635
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_GetPolarVector_17(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set polar vector (starting point of the arc).
		/// By default it is the unit vector in the positive X direction.
		/// Note: This is only used when UseNormalAndAngle is ON.
		/// </summary>
		// Token: 0x06015654 RID: 87636 RVA: 0x001E49B4 File Offset: 0x001E2BB4
		public virtual void GetPolarVector(IntPtr data)
		{
			vtkArcSource.vtkArcSource_GetPolarVector_17(base.GetCppThis(), data);
		}

		// Token: 0x06015655 RID: 87637
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArcSource_GetResolution_18(HandleRef pThis);

		/// <summary>
		/// Define the number of segments of the polyline that draws the arc.
		/// Note: if the resolution is set to 1 (the default value),
		/// the arc is drawn as a straight line.
		/// </summary>
		// Token: 0x06015656 RID: 87638 RVA: 0x001E49C4 File Offset: 0x001E2BC4
		public virtual int GetResolution()
		{
			return vtkArcSource.vtkArcSource_GetResolution_18(base.GetCppThis());
		}

		// Token: 0x06015657 RID: 87639
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArcSource_GetResolutionMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Define the number of segments of the polyline that draws the arc.
		/// Note: if the resolution is set to 1 (the default value),
		/// the arc is drawn as a straight line.
		/// </summary>
		// Token: 0x06015658 RID: 87640 RVA: 0x001E49E4 File Offset: 0x001E2BE4
		public virtual int GetResolutionMaxValue()
		{
			return vtkArcSource.vtkArcSource_GetResolutionMaxValue_19(base.GetCppThis());
		}

		// Token: 0x06015659 RID: 87641
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArcSource_GetResolutionMinValue_20(HandleRef pThis);

		/// <summary>
		/// Define the number of segments of the polyline that draws the arc.
		/// Note: if the resolution is set to 1 (the default value),
		/// the arc is drawn as a straight line.
		/// </summary>
		// Token: 0x0601565A RID: 87642 RVA: 0x001E4A04 File Offset: 0x001E2C04
		public virtual int GetResolutionMinValue()
		{
			return vtkArcSource.vtkArcSource_GetResolutionMinValue_20(base.GetCppThis());
		}

		// Token: 0x0601565B RID: 87643
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkArcSource_GetUseNormalAndAngle_21(HandleRef pThis);

		/// <summary>
		/// Activate the API based on a normal vector, a starting point
		/// (polar vector) and an angle defining the arc length.
		/// The previous API (which remains the default) allows for inputs that are
		/// inconsistent (when Point1 and Point2 are not equidistant from Center)
		/// or ambiguous (when Point1, Point2, and Center are aligned).
		/// Note: false by default.
		/// </summary>
		// Token: 0x0601565C RID: 87644 RVA: 0x001E4A24 File Offset: 0x001E2C24
		public virtual bool GetUseNormalAndAngle()
		{
			return vtkArcSource.vtkArcSource_GetUseNormalAndAngle_21(base.GetCppThis()) != 0;
		}

		// Token: 0x0601565D RID: 87645
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArcSource_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601565E RID: 87646 RVA: 0x001E4A4C File Offset: 0x001E2C4C
		public override int IsA(string type)
		{
			return vtkArcSource.vtkArcSource_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0601565F RID: 87647
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArcSource_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015660 RID: 87648 RVA: 0x001E4A6C File Offset: 0x001E2C6C
		public new static int IsTypeOf(string type)
		{
			return vtkArcSource.vtkArcSource_IsTypeOf_23(type);
		}

		// Token: 0x06015661 RID: 87649
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_NegativeOff_24(HandleRef pThis);

		/// <summary>
		/// By default the arc spans the shortest angular sector point1 and point2.
		/// By setting this to true, the longest angular sector is used instead
		/// (i.e. the negative coterminal angle to the shortest one).
		/// Note: This is only used when UseNormalAndAngle is OFF. False by default.
		/// </summary>
		// Token: 0x06015662 RID: 87650 RVA: 0x001E4A86 File Offset: 0x001E2C86
		public virtual void NegativeOff()
		{
			vtkArcSource.vtkArcSource_NegativeOff_24(base.GetCppThis());
		}

		// Token: 0x06015663 RID: 87651
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_NegativeOn_25(HandleRef pThis);

		/// <summary>
		/// By default the arc spans the shortest angular sector point1 and point2.
		/// By setting this to true, the longest angular sector is used instead
		/// (i.e. the negative coterminal angle to the shortest one).
		/// Note: This is only used when UseNormalAndAngle is OFF. False by default.
		/// </summary>
		// Token: 0x06015664 RID: 87652 RVA: 0x001E4A95 File Offset: 0x001E2C95
		public virtual void NegativeOn()
		{
			vtkArcSource.vtkArcSource_NegativeOn_25(base.GetCppThis());
		}

		// Token: 0x06015665 RID: 87653
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArcSource_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015666 RID: 87654 RVA: 0x001E4AA4 File Offset: 0x001E2CA4
		public new vtkArcSource NewInstance()
		{
			vtkArcSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArcSource.vtkArcSource_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArcSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015667 RID: 87655
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArcSource_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015668 RID: 87656 RVA: 0x001E4B00 File Offset: 0x001E2D00
		public new static vtkArcSource SafeDownCast(vtkObjectBase o)
		{
			vtkArcSource vtkArcSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArcSource.vtkArcSource_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArcSource = (vtkArcSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArcSource.Register(null);
				}
			}
			return vtkArcSource;
		}

		// Token: 0x06015669 RID: 87657
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_SetAngle_29(HandleRef pThis, double _arg);

		/// <summary>
		/// Arc length (in degrees), beginning at the polar vector.
		/// The direction is counterclockwise by default;
		/// a negative value draws the arc in the clockwise direction.
		/// Note: This is only used when UseNormalAndAngle is ON.
		/// </summary>
		// Token: 0x0601566A RID: 87658 RVA: 0x001E4B7F File Offset: 0x001E2D7F
		public virtual void SetAngle(double _arg)
		{
			vtkArcSource.vtkArcSource_SetAngle_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0601566B RID: 87659
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_SetCenter_30(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set position of the center of the circle that defines the arc.
		/// Note: you can use the function vtkMath::Solve3PointCircle to
		/// find the center from 3 points located on a circle.
		/// </summary>
		// Token: 0x0601566C RID: 87660 RVA: 0x001E4B8F File Offset: 0x001E2D8F
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkArcSource.vtkArcSource_SetCenter_30(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601566D RID: 87661
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_SetCenter_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set position of the center of the circle that defines the arc.
		/// Note: you can use the function vtkMath::Solve3PointCircle to
		/// find the center from 3 points located on a circle.
		/// </summary>
		// Token: 0x0601566E RID: 87662 RVA: 0x001E4BA1 File Offset: 0x001E2DA1
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkArcSource.vtkArcSource_SetCenter_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0601566F RID: 87663
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_SetNegative_32(HandleRef pThis, byte _arg);

		/// <summary>
		/// By default the arc spans the shortest angular sector point1 and point2.
		/// By setting this to true, the longest angular sector is used instead
		/// (i.e. the negative coterminal angle to the shortest one).
		/// Note: This is only used when UseNormalAndAngle is OFF. False by default.
		/// </summary>
		// Token: 0x06015670 RID: 87664 RVA: 0x001E4BB1 File Offset: 0x001E2DB1
		public virtual void SetNegative(bool _arg)
		{
			vtkArcSource.vtkArcSource_SetNegative_32(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06015671 RID: 87665
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_SetNormal_33(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the normal vector to the plane of the arc.
		/// By default it points in the positive Z direction.
		/// Note: This is only used when UseNormalAndAngle is ON.
		/// </summary>
		// Token: 0x06015672 RID: 87666 RVA: 0x001E4BC9 File Offset: 0x001E2DC9
		public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkArcSource.vtkArcSource_SetNormal_33(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06015673 RID: 87667
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_SetNormal_34(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the normal vector to the plane of the arc.
		/// By default it points in the positive Z direction.
		/// Note: This is only used when UseNormalAndAngle is ON.
		/// </summary>
		// Token: 0x06015674 RID: 87668 RVA: 0x001E4BDB File Offset: 0x001E2DDB
		public virtual void SetNormal(IntPtr _arg)
		{
			vtkArcSource.vtkArcSource_SetNormal_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06015675 RID: 87669
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_SetOutputPointsPrecision_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015676 RID: 87670 RVA: 0x001E4BEB File Offset: 0x001E2DEB
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkArcSource.vtkArcSource_SetOutputPointsPrecision_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06015677 RID: 87671
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_SetPoint1_36(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set position of the first end point.
		/// </summary>
		// Token: 0x06015678 RID: 87672 RVA: 0x001E4BFB File Offset: 0x001E2DFB
		public virtual void SetPoint1(double _arg1, double _arg2, double _arg3)
		{
			vtkArcSource.vtkArcSource_SetPoint1_36(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06015679 RID: 87673
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_SetPoint1_37(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set position of the first end point.
		/// </summary>
		// Token: 0x0601567A RID: 87674 RVA: 0x001E4C0D File Offset: 0x001E2E0D
		public virtual void SetPoint1(IntPtr _arg)
		{
			vtkArcSource.vtkArcSource_SetPoint1_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0601567B RID: 87675
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_SetPoint2_38(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set position of the other end point.
		/// </summary>
		// Token: 0x0601567C RID: 87676 RVA: 0x001E4C1D File Offset: 0x001E2E1D
		public virtual void SetPoint2(double _arg1, double _arg2, double _arg3)
		{
			vtkArcSource.vtkArcSource_SetPoint2_38(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601567D RID: 87677
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_SetPoint2_39(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set position of the other end point.
		/// </summary>
		// Token: 0x0601567E RID: 87678 RVA: 0x001E4C2F File Offset: 0x001E2E2F
		public virtual void SetPoint2(IntPtr _arg)
		{
			vtkArcSource.vtkArcSource_SetPoint2_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0601567F RID: 87679
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_SetPolarVector_40(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set polar vector (starting point of the arc).
		/// By default it is the unit vector in the positive X direction.
		/// Note: This is only used when UseNormalAndAngle is ON.
		/// </summary>
		// Token: 0x06015680 RID: 87680 RVA: 0x001E4C3F File Offset: 0x001E2E3F
		public virtual void SetPolarVector(double _arg1, double _arg2, double _arg3)
		{
			vtkArcSource.vtkArcSource_SetPolarVector_40(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06015681 RID: 87681
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_SetPolarVector_41(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set polar vector (starting point of the arc).
		/// By default it is the unit vector in the positive X direction.
		/// Note: This is only used when UseNormalAndAngle is ON.
		/// </summary>
		// Token: 0x06015682 RID: 87682 RVA: 0x001E4C51 File Offset: 0x001E2E51
		public virtual void SetPolarVector(IntPtr _arg)
		{
			vtkArcSource.vtkArcSource_SetPolarVector_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06015683 RID: 87683
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_SetResolution_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Define the number of segments of the polyline that draws the arc.
		/// Note: if the resolution is set to 1 (the default value),
		/// the arc is drawn as a straight line.
		/// </summary>
		// Token: 0x06015684 RID: 87684 RVA: 0x001E4C61 File Offset: 0x001E2E61
		public virtual void SetResolution(int _arg)
		{
			vtkArcSource.vtkArcSource_SetResolution_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06015685 RID: 87685
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_SetUseNormalAndAngle_43(HandleRef pThis, byte _arg);

		/// <summary>
		/// Activate the API based on a normal vector, a starting point
		/// (polar vector) and an angle defining the arc length.
		/// The previous API (which remains the default) allows for inputs that are
		/// inconsistent (when Point1 and Point2 are not equidistant from Center)
		/// or ambiguous (when Point1, Point2, and Center are aligned).
		/// Note: false by default.
		/// </summary>
		// Token: 0x06015686 RID: 87686 RVA: 0x001E4C71 File Offset: 0x001E2E71
		public virtual void SetUseNormalAndAngle(bool _arg)
		{
			vtkArcSource.vtkArcSource_SetUseNormalAndAngle_43(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06015687 RID: 87687
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_UseNormalAndAngleOff_44(HandleRef pThis);

		/// <summary>
		/// Activate the API based on a normal vector, a starting point
		/// (polar vector) and an angle defining the arc length.
		/// The previous API (which remains the default) allows for inputs that are
		/// inconsistent (when Point1 and Point2 are not equidistant from Center)
		/// or ambiguous (when Point1, Point2, and Center are aligned).
		/// Note: false by default.
		/// </summary>
		// Token: 0x06015688 RID: 87688 RVA: 0x001E4C89 File Offset: 0x001E2E89
		public virtual void UseNormalAndAngleOff()
		{
			vtkArcSource.vtkArcSource_UseNormalAndAngleOff_44(base.GetCppThis());
		}

		// Token: 0x06015689 RID: 87689
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcSource_UseNormalAndAngleOn_45(HandleRef pThis);

		/// <summary>
		/// Activate the API based on a normal vector, a starting point
		/// (polar vector) and an angle defining the arc length.
		/// The previous API (which remains the default) allows for inputs that are
		/// inconsistent (when Point1 and Point2 are not equidistant from Center)
		/// or ambiguous (when Point1, Point2, and Center are aligned).
		/// Note: false by default.
		/// </summary>
		// Token: 0x0601568A RID: 87690 RVA: 0x001E4C98 File Offset: 0x001E2E98
		public virtual void UseNormalAndAngleOn()
		{
			vtkArcSource.vtkArcSource_UseNormalAndAngleOn_45(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001880 RID: 6272
		public new const string MRFullTypeName = "Kitware.VTK.vtkArcSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001881 RID: 6273
		public new static readonly string MRClassNameKey = "class vtkArcSource";
	}
}
