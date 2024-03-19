using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProjectPointsToPlane
	/// </summary>
	/// <remarks>
	///    project all input points to a plane
	///
	/// vtkProjectPointsToPlane is a filter that operates on a vtkPointSet (and
	/// its subclasses), projecting all input points to a plane. There are
	/// multiple options as to what plane to project to: The user may specify one
	/// of the x-y-z planes, the best coordinate plane, a user-defined plane, or
	/// the closest fitting plane (using a least-squares method). On output, the
	/// points will lie on the specified plane, and any cells connected to the
	/// points (if any) will be deformed accordingly. On output, the filter will
	/// not modify dataset topology, nor modify point or cell attributes. Only the
	/// point coordinates (geometry) will be modified. (Note that the filter will
	/// operate on input point sets with or without cells.)
	///
	/// @warning
	/// It is possible that cells connected to the projected points will become
	/// invalid after the projection operation.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPlane
	/// </seealso>
	// Token: 0x02000459 RID: 1113
	public class vtkProjectPointsToPlane : vtkPointSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CF03 RID: 52995 RVA: 0x0011FE8F File Offset: 0x0011E08F
		static vtkProjectPointsToPlane()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProjectPointsToPlane.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProjectPointsToPlane"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CF04 RID: 52996 RVA: 0x0011FEB7 File Offset: 0x0011E0B7
		public vtkProjectPointsToPlane(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CF05 RID: 52997
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectPointsToPlane_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CF06 RID: 52998 RVA: 0x0011FEC8 File Offset: 0x0011E0C8
		public new static vtkProjectPointsToPlane New()
		{
			vtkProjectPointsToPlane result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProjectPointsToPlane.vtkProjectPointsToPlane_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProjectPointsToPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CF07 RID: 52999 RVA: 0x0011FF1C File Offset: 0x0011E11C
		public vtkProjectPointsToPlane() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProjectPointsToPlane.vtkProjectPointsToPlane_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CF08 RID: 53000 RVA: 0x0011FF60 File Offset: 0x0011E160
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CF09 RID: 53001
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectPointsToPlane_GetNormal_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the plane normal and origin. On input, these methods are used to specify
		/// the plane to use for projection (if the ProjectionType==SpecifiedPlane); and
		/// on output the methods return the plane on which the points were projected.
		/// </summary>
		// Token: 0x0600CF0A RID: 53002 RVA: 0x0011FF6C File Offset: 0x0011E16C
		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkProjectPointsToPlane.vtkProjectPointsToPlane_GetNormal_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600CF0B RID: 53003
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectPointsToPlane_GetNormal_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the plane normal and origin. On input, these methods are used to specify
		/// the plane to use for projection (if the ProjectionType==SpecifiedPlane); and
		/// on output the methods return the plane on which the points were projected.
		/// </summary>
		// Token: 0x0600CF0C RID: 53004 RVA: 0x0011FFB4 File Offset: 0x0011E1B4
		public virtual void GetNormal(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkProjectPointsToPlane.vtkProjectPointsToPlane_GetNormal_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600CF0D RID: 53005
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectPointsToPlane_GetNormal_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the plane normal and origin. On input, these methods are used to specify
		/// the plane to use for projection (if the ProjectionType==SpecifiedPlane); and
		/// on output the methods return the plane on which the points were projected.
		/// </summary>
		// Token: 0x0600CF0E RID: 53006 RVA: 0x0011FFC6 File Offset: 0x0011E1C6
		public virtual void GetNormal(IntPtr _arg)
		{
			vtkProjectPointsToPlane.vtkProjectPointsToPlane_GetNormal_03(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CF0F RID: 53007
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProjectPointsToPlane_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CF10 RID: 53008 RVA: 0x0011FFD8 File Offset: 0x0011E1D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProjectPointsToPlane.vtkProjectPointsToPlane_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600CF11 RID: 53009
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProjectPointsToPlane_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CF12 RID: 53010 RVA: 0x0011FFF8 File Offset: 0x0011E1F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProjectPointsToPlane.vtkProjectPointsToPlane_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600CF13 RID: 53011
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectPointsToPlane_GetOrigin_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the plane normal and origin. On input, these methods are used to specify
		/// the plane to use for projection (if the ProjectionType==SpecifiedPlane); and
		/// on output the methods return the plane on which the points were projected.
		/// </summary>
		// Token: 0x0600CF14 RID: 53012 RVA: 0x00120014 File Offset: 0x0011E214
		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkProjectPointsToPlane.vtkProjectPointsToPlane_GetOrigin_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600CF15 RID: 53013
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectPointsToPlane_GetOrigin_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the plane normal and origin. On input, these methods are used to specify
		/// the plane to use for projection (if the ProjectionType==SpecifiedPlane); and
		/// on output the methods return the plane on which the points were projected.
		/// </summary>
		// Token: 0x0600CF16 RID: 53014 RVA: 0x0012005C File Offset: 0x0011E25C
		public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkProjectPointsToPlane.vtkProjectPointsToPlane_GetOrigin_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600CF17 RID: 53015
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectPointsToPlane_GetOrigin_08(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the plane normal and origin. On input, these methods are used to specify
		/// the plane to use for projection (if the ProjectionType==SpecifiedPlane); and
		/// on output the methods return the plane on which the points were projected.
		/// </summary>
		// Token: 0x0600CF18 RID: 53016 RVA: 0x0012006E File Offset: 0x0011E26E
		public virtual void GetOrigin(IntPtr _arg)
		{
			vtkProjectPointsToPlane.vtkProjectPointsToPlane_GetOrigin_08(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CF19 RID: 53017
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProjectPointsToPlane_GetOutputPointsPrecision_09(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points. See the
		/// documentation for the vtkAlgorithm::Precision enum for an explanation of
		/// the available precision settings. By default, the output precision is
		/// DEFAULT_PRECISION (i.e., the input and output types are the same) - this
		/// can cause issues if projecting integral point types.
		/// </summary>
		// Token: 0x0600CF1A RID: 53018 RVA: 0x00120080 File Offset: 0x0011E280
		public virtual int GetOutputPointsPrecision()
		{
			return vtkProjectPointsToPlane.vtkProjectPointsToPlane_GetOutputPointsPrecision_09(base.GetCppThis());
		}

		// Token: 0x0600CF1B RID: 53019
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProjectPointsToPlane_GetProjectionType_10(HandleRef pThis);

		/// <summary>
		/// Specify the type of projection to perform. Points may be projected to
		/// the 1) x-plane; 2) y-plane; 3) z-plane; 4) user-specified plane; 5) the
		/// plane most orthogonal to one of the coordinate axes x, y, or z; or 6)
		/// best fitting plane. For option #4, the user must also specify a plane
		/// Origin and Normal. For all options, after filter execution, the plane
		/// onto which the points are projected is returned in the Origin and Normal
		/// data members. Note that the BEST_COORDINATE_PLANE first performs a plane
		/// fitting, and then selects the x, y, or z coordinate plane most orthogonal
		/// to the fitted plane normal.
		/// </summary>
		// Token: 0x0600CF1C RID: 53020 RVA: 0x001200A0 File Offset: 0x0011E2A0
		public virtual int GetProjectionType()
		{
			return vtkProjectPointsToPlane.vtkProjectPointsToPlane_GetProjectionType_10(base.GetCppThis());
		}

		// Token: 0x0600CF1D RID: 53021
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProjectPointsToPlane_GetProjectionTypeMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Specify the type of projection to perform. Points may be projected to
		/// the 1) x-plane; 2) y-plane; 3) z-plane; 4) user-specified plane; 5) the
		/// plane most orthogonal to one of the coordinate axes x, y, or z; or 6)
		/// best fitting plane. For option #4, the user must also specify a plane
		/// Origin and Normal. For all options, after filter execution, the plane
		/// onto which the points are projected is returned in the Origin and Normal
		/// data members. Note that the BEST_COORDINATE_PLANE first performs a plane
		/// fitting, and then selects the x, y, or z coordinate plane most orthogonal
		/// to the fitted plane normal.
		/// </summary>
		// Token: 0x0600CF1E RID: 53022 RVA: 0x001200C0 File Offset: 0x0011E2C0
		public virtual int GetProjectionTypeMaxValue()
		{
			return vtkProjectPointsToPlane.vtkProjectPointsToPlane_GetProjectionTypeMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0600CF1F RID: 53023
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProjectPointsToPlane_GetProjectionTypeMinValue_12(HandleRef pThis);

		/// <summary>
		/// Specify the type of projection to perform. Points may be projected to
		/// the 1) x-plane; 2) y-plane; 3) z-plane; 4) user-specified plane; 5) the
		/// plane most orthogonal to one of the coordinate axes x, y, or z; or 6)
		/// best fitting plane. For option #4, the user must also specify a plane
		/// Origin and Normal. For all options, after filter execution, the plane
		/// onto which the points are projected is returned in the Origin and Normal
		/// data members. Note that the BEST_COORDINATE_PLANE first performs a plane
		/// fitting, and then selects the x, y, or z coordinate plane most orthogonal
		/// to the fitted plane normal.
		/// </summary>
		// Token: 0x0600CF20 RID: 53024 RVA: 0x001200E0 File Offset: 0x0011E2E0
		public virtual int GetProjectionTypeMinValue()
		{
			return vtkProjectPointsToPlane.vtkProjectPointsToPlane_GetProjectionTypeMinValue_12(base.GetCppThis());
		}

		// Token: 0x0600CF21 RID: 53025
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProjectPointsToPlane_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CF22 RID: 53026 RVA: 0x00120100 File Offset: 0x0011E300
		public override int IsA(string type)
		{
			return vtkProjectPointsToPlane.vtkProjectPointsToPlane_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0600CF23 RID: 53027
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProjectPointsToPlane_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CF24 RID: 53028 RVA: 0x00120120 File Offset: 0x0011E320
		public new static int IsTypeOf(string type)
		{
			return vtkProjectPointsToPlane.vtkProjectPointsToPlane_IsTypeOf_14(type);
		}

		// Token: 0x0600CF25 RID: 53029
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectPointsToPlane_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CF26 RID: 53030 RVA: 0x0012013C File Offset: 0x0011E33C
		public new vtkProjectPointsToPlane NewInstance()
		{
			vtkProjectPointsToPlane result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProjectPointsToPlane.vtkProjectPointsToPlane_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProjectPointsToPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CF27 RID: 53031
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectPointsToPlane_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CF28 RID: 53032 RVA: 0x00120198 File Offset: 0x0011E398
		public new static vtkProjectPointsToPlane SafeDownCast(vtkObjectBase o)
		{
			vtkProjectPointsToPlane vtkProjectPointsToPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProjectPointsToPlane.vtkProjectPointsToPlane_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProjectPointsToPlane = (vtkProjectPointsToPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProjectPointsToPlane.Register(null);
				}
			}
			return vtkProjectPointsToPlane;
		}

		// Token: 0x0600CF29 RID: 53033
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectPointsToPlane_SetNormal_18(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the plane normal and origin. On input, these methods are used to specify
		/// the plane to use for projection (if the ProjectionType==SpecifiedPlane); and
		/// on output the methods return the plane on which the points were projected.
		/// </summary>
		// Token: 0x0600CF2A RID: 53034 RVA: 0x00120217 File Offset: 0x0011E417
		public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkProjectPointsToPlane.vtkProjectPointsToPlane_SetNormal_18(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600CF2B RID: 53035
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectPointsToPlane_SetNormal_19(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the plane normal and origin. On input, these methods are used to specify
		/// the plane to use for projection (if the ProjectionType==SpecifiedPlane); and
		/// on output the methods return the plane on which the points were projected.
		/// </summary>
		// Token: 0x0600CF2C RID: 53036 RVA: 0x00120229 File Offset: 0x0011E429
		public virtual void SetNormal(IntPtr _arg)
		{
			vtkProjectPointsToPlane.vtkProjectPointsToPlane_SetNormal_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CF2D RID: 53037
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectPointsToPlane_SetOrigin_20(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the plane normal and origin. On input, these methods are used to specify
		/// the plane to use for projection (if the ProjectionType==SpecifiedPlane); and
		/// on output the methods return the plane on which the points were projected.
		/// </summary>
		// Token: 0x0600CF2E RID: 53038 RVA: 0x00120239 File Offset: 0x0011E439
		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkProjectPointsToPlane.vtkProjectPointsToPlane_SetOrigin_20(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600CF2F RID: 53039
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectPointsToPlane_SetOrigin_21(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the plane normal and origin. On input, these methods are used to specify
		/// the plane to use for projection (if the ProjectionType==SpecifiedPlane); and
		/// on output the methods return the plane on which the points were projected.
		/// </summary>
		// Token: 0x0600CF30 RID: 53040 RVA: 0x0012024B File Offset: 0x0011E44B
		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkProjectPointsToPlane.vtkProjectPointsToPlane_SetOrigin_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CF31 RID: 53041
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectPointsToPlane_SetOutputPointsPrecision_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points. See the
		/// documentation for the vtkAlgorithm::Precision enum for an explanation of
		/// the available precision settings. By default, the output precision is
		/// DEFAULT_PRECISION (i.e., the input and output types are the same) - this
		/// can cause issues if projecting integral point types.
		/// </summary>
		// Token: 0x0600CF32 RID: 53042 RVA: 0x0012025B File Offset: 0x0011E45B
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkProjectPointsToPlane.vtkProjectPointsToPlane_SetOutputPointsPrecision_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CF33 RID: 53043
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectPointsToPlane_SetProjectionType_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the type of projection to perform. Points may be projected to
		/// the 1) x-plane; 2) y-plane; 3) z-plane; 4) user-specified plane; 5) the
		/// plane most orthogonal to one of the coordinate axes x, y, or z; or 6)
		/// best fitting plane. For option #4, the user must also specify a plane
		/// Origin and Normal. For all options, after filter execution, the plane
		/// onto which the points are projected is returned in the Origin and Normal
		/// data members. Note that the BEST_COORDINATE_PLANE first performs a plane
		/// fitting, and then selects the x, y, or z coordinate plane most orthogonal
		/// to the fitted plane normal.
		/// </summary>
		// Token: 0x0600CF34 RID: 53044 RVA: 0x0012026B File Offset: 0x0011E46B
		public virtual void SetProjectionType(int _arg)
		{
			vtkProjectPointsToPlane.vtkProjectPointsToPlane_SetProjectionType_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CF35 RID: 53045
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectPointsToPlane_SetProjectionTypeToBestCoordinatePlane_24(HandleRef pThis);

		/// <summary>
		/// Specify the type of projection to perform. Points may be projected to
		/// the 1) x-plane; 2) y-plane; 3) z-plane; 4) user-specified plane; 5) the
		/// plane most orthogonal to one of the coordinate axes x, y, or z; or 6)
		/// best fitting plane. For option #4, the user must also specify a plane
		/// Origin and Normal. For all options, after filter execution, the plane
		/// onto which the points are projected is returned in the Origin and Normal
		/// data members. Note that the BEST_COORDINATE_PLANE first performs a plane
		/// fitting, and then selects the x, y, or z coordinate plane most orthogonal
		/// to the fitted plane normal.
		/// </summary>
		// Token: 0x0600CF36 RID: 53046 RVA: 0x0012027B File Offset: 0x0011E47B
		public void SetProjectionTypeToBestCoordinatePlane()
		{
			vtkProjectPointsToPlane.vtkProjectPointsToPlane_SetProjectionTypeToBestCoordinatePlane_24(base.GetCppThis());
		}

		// Token: 0x0600CF37 RID: 53047
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectPointsToPlane_SetProjectionTypeToBestFitPlane_25(HandleRef pThis);

		/// <summary>
		/// Specify the type of projection to perform. Points may be projected to
		/// the 1) x-plane; 2) y-plane; 3) z-plane; 4) user-specified plane; 5) the
		/// plane most orthogonal to one of the coordinate axes x, y, or z; or 6)
		/// best fitting plane. For option #4, the user must also specify a plane
		/// Origin and Normal. For all options, after filter execution, the plane
		/// onto which the points are projected is returned in the Origin and Normal
		/// data members. Note that the BEST_COORDINATE_PLANE first performs a plane
		/// fitting, and then selects the x, y, or z coordinate plane most orthogonal
		/// to the fitted plane normal.
		/// </summary>
		// Token: 0x0600CF38 RID: 53048 RVA: 0x0012028A File Offset: 0x0011E48A
		public void SetProjectionTypeToBestFitPlane()
		{
			vtkProjectPointsToPlane.vtkProjectPointsToPlane_SetProjectionTypeToBestFitPlane_25(base.GetCppThis());
		}

		// Token: 0x0600CF39 RID: 53049
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectPointsToPlane_SetProjectionTypeToSpecifiedPlane_26(HandleRef pThis);

		/// <summary>
		/// Specify the type of projection to perform. Points may be projected to
		/// the 1) x-plane; 2) y-plane; 3) z-plane; 4) user-specified plane; 5) the
		/// plane most orthogonal to one of the coordinate axes x, y, or z; or 6)
		/// best fitting plane. For option #4, the user must also specify a plane
		/// Origin and Normal. For all options, after filter execution, the plane
		/// onto which the points are projected is returned in the Origin and Normal
		/// data members. Note that the BEST_COORDINATE_PLANE first performs a plane
		/// fitting, and then selects the x, y, or z coordinate plane most orthogonal
		/// to the fitted plane normal.
		/// </summary>
		// Token: 0x0600CF3A RID: 53050 RVA: 0x00120299 File Offset: 0x0011E499
		public void SetProjectionTypeToSpecifiedPlane()
		{
			vtkProjectPointsToPlane.vtkProjectPointsToPlane_SetProjectionTypeToSpecifiedPlane_26(base.GetCppThis());
		}

		// Token: 0x0600CF3B RID: 53051
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectPointsToPlane_SetProjectionTypeToXPlane_27(HandleRef pThis);

		/// <summary>
		/// Specify the type of projection to perform. Points may be projected to
		/// the 1) x-plane; 2) y-plane; 3) z-plane; 4) user-specified plane; 5) the
		/// plane most orthogonal to one of the coordinate axes x, y, or z; or 6)
		/// best fitting plane. For option #4, the user must also specify a plane
		/// Origin and Normal. For all options, after filter execution, the plane
		/// onto which the points are projected is returned in the Origin and Normal
		/// data members. Note that the BEST_COORDINATE_PLANE first performs a plane
		/// fitting, and then selects the x, y, or z coordinate plane most orthogonal
		/// to the fitted plane normal.
		/// </summary>
		// Token: 0x0600CF3C RID: 53052 RVA: 0x001202A8 File Offset: 0x0011E4A8
		public void SetProjectionTypeToXPlane()
		{
			vtkProjectPointsToPlane.vtkProjectPointsToPlane_SetProjectionTypeToXPlane_27(base.GetCppThis());
		}

		// Token: 0x0600CF3D RID: 53053
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectPointsToPlane_SetProjectionTypeToYPlane_28(HandleRef pThis);

		/// <summary>
		/// Specify the type of projection to perform. Points may be projected to
		/// the 1) x-plane; 2) y-plane; 3) z-plane; 4) user-specified plane; 5) the
		/// plane most orthogonal to one of the coordinate axes x, y, or z; or 6)
		/// best fitting plane. For option #4, the user must also specify a plane
		/// Origin and Normal. For all options, after filter execution, the plane
		/// onto which the points are projected is returned in the Origin and Normal
		/// data members. Note that the BEST_COORDINATE_PLANE first performs a plane
		/// fitting, and then selects the x, y, or z coordinate plane most orthogonal
		/// to the fitted plane normal.
		/// </summary>
		// Token: 0x0600CF3E RID: 53054 RVA: 0x001202B7 File Offset: 0x0011E4B7
		public void SetProjectionTypeToYPlane()
		{
			vtkProjectPointsToPlane.vtkProjectPointsToPlane_SetProjectionTypeToYPlane_28(base.GetCppThis());
		}

		// Token: 0x0600CF3F RID: 53055
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectPointsToPlane_SetProjectionTypeToZPlane_29(HandleRef pThis);

		/// <summary>
		/// Specify the type of projection to perform. Points may be projected to
		/// the 1) x-plane; 2) y-plane; 3) z-plane; 4) user-specified plane; 5) the
		/// plane most orthogonal to one of the coordinate axes x, y, or z; or 6)
		/// best fitting plane. For option #4, the user must also specify a plane
		/// Origin and Normal. For all options, after filter execution, the plane
		/// onto which the points are projected is returned in the Origin and Normal
		/// data members. Note that the BEST_COORDINATE_PLANE first performs a plane
		/// fitting, and then selects the x, y, or z coordinate plane most orthogonal
		/// to the fitted plane normal.
		/// </summary>
		// Token: 0x0600CF40 RID: 53056 RVA: 0x001202C6 File Offset: 0x0011E4C6
		public void SetProjectionTypeToZPlane()
		{
			vtkProjectPointsToPlane.vtkProjectPointsToPlane_SetProjectionTypeToZPlane_29(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F4B RID: 3915
		public new const string MRFullTypeName = "Kitware.VTK.vtkProjectPointsToPlane";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F4C RID: 3916
		public new static readonly string MRClassNameKey = "class vtkProjectPointsToPlane";

		/// <summary>
		/// Define the options available for point projection. By default,
		/// the filter projects to the z-plane.
		/// </summary>
		// Token: 0x0200045A RID: 1114
		public enum PlaneProjectionType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000F4E RID: 3918
			BEST_COORDINATE_PLANE = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000F4F RID: 3919
			BEST_FIT_PLANE,
			/// <summary>enum member</summary>
			// Token: 0x04000F50 RID: 3920
			SPECIFIED_PLANE = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000F51 RID: 3921
			X_PLANE = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000F52 RID: 3922
			Y_PLANE,
			/// <summary>enum member</summary>
			// Token: 0x04000F53 RID: 3923
			Z_PLANE
		}
	}
}
