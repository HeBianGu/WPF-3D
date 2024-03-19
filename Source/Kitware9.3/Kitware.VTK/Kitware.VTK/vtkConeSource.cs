using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkConeSource
	/// </summary>
	/// <remarks>
	///    generate polygonal cone
	///
	/// vtkConeSource creates a cone centered at a specified point and pointing in
	/// a specified direction. (By default, the center is the origin and the
	/// direction is the x-axis.) Depending upon the resolution of this object,
	/// different representations are created. If resolution=0 a line is created;
	/// if resolution=1, a single triangle is created; if resolution=2, two
	/// crossed triangles are created. For resolution &gt; 2, a 3D cone (with
	/// resolution number of sides) is created. It also is possible to control
	/// whether the bottom of the cone is capped with a (resolution-sided)
	/// polygon, and to specify the height and radius of the cone.
	/// </remarks>
	// Token: 0x02000822 RID: 2082
	public class vtkConeSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601579A RID: 87962 RVA: 0x001E5F3D File Offset: 0x001E413D
		static vtkConeSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConeSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConeSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601579B RID: 87963 RVA: 0x001E5F65 File Offset: 0x001E4165
		public vtkConeSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601579C RID: 87964
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConeSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with default resolution 6, height 1.0, radius 0.5, and
		/// capping on. The cone is centered at the origin and points down
		/// the x-axis.
		/// </summary>
		// Token: 0x0601579D RID: 87965 RVA: 0x001E5F74 File Offset: 0x001E4174
		public new static vtkConeSource New()
		{
			vtkConeSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConeSource.vtkConeSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConeSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with default resolution 6, height 1.0, radius 0.5, and
		/// capping on. The cone is centered at the origin and points down
		/// the x-axis.
		/// </summary>
		// Token: 0x0601579E RID: 87966 RVA: 0x001E5FC8 File Offset: 0x001E41C8
		public vtkConeSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkConeSource.vtkConeSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601579F RID: 87967 RVA: 0x001E600C File Offset: 0x001E420C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060157A0 RID: 87968
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConeSource_CappingOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether to cap the base of the cone with a polygon.
		/// </summary>
		// Token: 0x060157A1 RID: 87969 RVA: 0x001E6017 File Offset: 0x001E4217
		public virtual void CappingOff()
		{
			vtkConeSource.vtkConeSource_CappingOff_01(base.GetCppThis());
		}

		// Token: 0x060157A2 RID: 87970
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConeSource_CappingOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether to cap the base of the cone with a polygon.
		/// </summary>
		// Token: 0x060157A3 RID: 87971 RVA: 0x001E6026 File Offset: 0x001E4226
		public virtual void CappingOn()
		{
			vtkConeSource.vtkConeSource_CappingOn_02(base.GetCppThis());
		}

		// Token: 0x060157A4 RID: 87972
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConeSource_GetAngle_03(HandleRef pThis);

		/// <summary>
		/// Set the angle of the cone. This is the angle between the axis of the cone
		/// and a generatrix. Warning: this is not the aperture! The aperture is
		/// twice this angle.
		/// As a side effect, the angle plus height sets the base radius of the cone.
		/// Angle is expressed in degrees.
		/// </summary>
		// Token: 0x060157A5 RID: 87973 RVA: 0x001E6038 File Offset: 0x001E4238
		public double GetAngle()
		{
			return vtkConeSource.vtkConeSource_GetAngle_03(base.GetCppThis());
		}

		// Token: 0x060157A6 RID: 87974
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConeSource_GetCapping_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether to cap the base of the cone with a polygon.
		/// </summary>
		// Token: 0x060157A7 RID: 87975 RVA: 0x001E6058 File Offset: 0x001E4258
		public virtual int GetCapping()
		{
			return vtkConeSource.vtkConeSource_GetCapping_04(base.GetCppThis());
		}

		// Token: 0x060157A8 RID: 87976
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConeSource_GetCenter_05(HandleRef pThis);

		/// <summary>
		/// Set the center of the cone. It is located at the middle of the axis of
		/// the cone. Warning: this is not the center of the base of the cone!
		/// The default is 0,0,0.
		/// </summary>
		// Token: 0x060157A9 RID: 87977 RVA: 0x001E6078 File Offset: 0x001E4278
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkConeSource.vtkConeSource_GetCenter_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060157AA RID: 87978
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConeSource_GetCenter_06(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the center of the cone. It is located at the middle of the axis of
		/// the cone. Warning: this is not the center of the base of the cone!
		/// The default is 0,0,0.
		/// </summary>
		// Token: 0x060157AB RID: 87979 RVA: 0x001E60C0 File Offset: 0x001E42C0
		public virtual void GetCenter(IntPtr data)
		{
			vtkConeSource.vtkConeSource_GetCenter_06(base.GetCppThis(), data);
		}

		// Token: 0x060157AC RID: 87980
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConeSource_GetDirection_07(HandleRef pThis);

		/// <summary>
		/// Set the orientation vector of the cone. The vector does not have
		/// to be normalized. The direction goes from the center of the base toward
		/// the apex. The default is (1,0,0).
		/// </summary>
		// Token: 0x060157AD RID: 87981 RVA: 0x001E60D0 File Offset: 0x001E42D0
		public virtual double[] GetDirection()
		{
			IntPtr intPtr = vtkConeSource.vtkConeSource_GetDirection_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060157AE RID: 87982
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConeSource_GetDirection_08(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the orientation vector of the cone. The vector does not have
		/// to be normalized. The direction goes from the center of the base toward
		/// the apex. The default is (1,0,0).
		/// </summary>
		// Token: 0x060157AF RID: 87983 RVA: 0x001E6118 File Offset: 0x001E4318
		public virtual void GetDirection(IntPtr data)
		{
			vtkConeSource.vtkConeSource_GetDirection_08(base.GetCppThis(), data);
		}

		// Token: 0x060157B0 RID: 87984
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConeSource_GetHeight_09(HandleRef pThis);

		/// <summary>
		/// Set the height of the cone. This is the height along the cone in
		/// its specified direction.
		/// </summary>
		// Token: 0x060157B1 RID: 87985 RVA: 0x001E6128 File Offset: 0x001E4328
		public virtual double GetHeight()
		{
			return vtkConeSource.vtkConeSource_GetHeight_09(base.GetCppThis());
		}

		// Token: 0x060157B2 RID: 87986
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConeSource_GetHeightMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Set the height of the cone. This is the height along the cone in
		/// its specified direction.
		/// </summary>
		// Token: 0x060157B3 RID: 87987 RVA: 0x001E6148 File Offset: 0x001E4348
		public virtual double GetHeightMaxValue()
		{
			return vtkConeSource.vtkConeSource_GetHeightMaxValue_10(base.GetCppThis());
		}

		// Token: 0x060157B4 RID: 87988
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConeSource_GetHeightMinValue_11(HandleRef pThis);

		/// <summary>
		/// Set the height of the cone. This is the height along the cone in
		/// its specified direction.
		/// </summary>
		// Token: 0x060157B5 RID: 87989 RVA: 0x001E6168 File Offset: 0x001E4368
		public virtual double GetHeightMinValue()
		{
			return vtkConeSource.vtkConeSource_GetHeightMinValue_11(base.GetCppThis());
		}

		// Token: 0x060157B6 RID: 87990
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConeSource_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060157B7 RID: 87991 RVA: 0x001E6188 File Offset: 0x001E4388
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkConeSource.vtkConeSource_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x060157B8 RID: 87992
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConeSource_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060157B9 RID: 87993 RVA: 0x001E61A8 File Offset: 0x001E43A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkConeSource.vtkConeSource_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x060157BA RID: 87994
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConeSource_GetOutputPointsPrecision_14(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x060157BB RID: 87995 RVA: 0x001E61C4 File Offset: 0x001E43C4
		public virtual int GetOutputPointsPrecision()
		{
			return vtkConeSource.vtkConeSource_GetOutputPointsPrecision_14(base.GetCppThis());
		}

		// Token: 0x060157BC RID: 87996
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConeSource_GetRadius_15(HandleRef pThis);

		/// <summary>
		/// Set the base radius of the cone.
		/// </summary>
		// Token: 0x060157BD RID: 87997 RVA: 0x001E61E4 File Offset: 0x001E43E4
		public virtual double GetRadius()
		{
			return vtkConeSource.vtkConeSource_GetRadius_15(base.GetCppThis());
		}

		// Token: 0x060157BE RID: 87998
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConeSource_GetRadiusMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Set the base radius of the cone.
		/// </summary>
		// Token: 0x060157BF RID: 87999 RVA: 0x001E6204 File Offset: 0x001E4404
		public virtual double GetRadiusMaxValue()
		{
			return vtkConeSource.vtkConeSource_GetRadiusMaxValue_16(base.GetCppThis());
		}

		// Token: 0x060157C0 RID: 88000
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConeSource_GetRadiusMinValue_17(HandleRef pThis);

		/// <summary>
		/// Set the base radius of the cone.
		/// </summary>
		// Token: 0x060157C1 RID: 88001 RVA: 0x001E6224 File Offset: 0x001E4424
		public virtual double GetRadiusMinValue()
		{
			return vtkConeSource.vtkConeSource_GetRadiusMinValue_17(base.GetCppThis());
		}

		// Token: 0x060157C2 RID: 88002
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConeSource_GetResolution_18(HandleRef pThis);

		/// <summary>
		/// Set the number of facets used to represent the cone.
		/// </summary>
		// Token: 0x060157C3 RID: 88003 RVA: 0x001E6244 File Offset: 0x001E4444
		public virtual int GetResolution()
		{
			return vtkConeSource.vtkConeSource_GetResolution_18(base.GetCppThis());
		}

		// Token: 0x060157C4 RID: 88004
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConeSource_GetResolutionMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Set the number of facets used to represent the cone.
		/// </summary>
		// Token: 0x060157C5 RID: 88005 RVA: 0x001E6264 File Offset: 0x001E4464
		public virtual int GetResolutionMaxValue()
		{
			return vtkConeSource.vtkConeSource_GetResolutionMaxValue_19(base.GetCppThis());
		}

		// Token: 0x060157C6 RID: 88006
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConeSource_GetResolutionMinValue_20(HandleRef pThis);

		/// <summary>
		/// Set the number of facets used to represent the cone.
		/// </summary>
		// Token: 0x060157C7 RID: 88007 RVA: 0x001E6284 File Offset: 0x001E4484
		public virtual int GetResolutionMinValue()
		{
			return vtkConeSource.vtkConeSource_GetResolutionMinValue_20(base.GetCppThis());
		}

		// Token: 0x060157C8 RID: 88008
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConeSource_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060157C9 RID: 88009 RVA: 0x001E62A4 File Offset: 0x001E44A4
		public override int IsA(string type)
		{
			return vtkConeSource.vtkConeSource_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x060157CA RID: 88010
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConeSource_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060157CB RID: 88011 RVA: 0x001E62C4 File Offset: 0x001E44C4
		public new static int IsTypeOf(string type)
		{
			return vtkConeSource.vtkConeSource_IsTypeOf_22(type);
		}

		// Token: 0x060157CC RID: 88012
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConeSource_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060157CD RID: 88013 RVA: 0x001E62E0 File Offset: 0x001E44E0
		public new vtkConeSource NewInstance()
		{
			vtkConeSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConeSource.vtkConeSource_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConeSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060157CE RID: 88014
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConeSource_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060157CF RID: 88015 RVA: 0x001E633C File Offset: 0x001E453C
		public new static vtkConeSource SafeDownCast(vtkObjectBase o)
		{
			vtkConeSource vtkConeSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConeSource.vtkConeSource_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConeSource = (vtkConeSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConeSource.Register(null);
				}
			}
			return vtkConeSource;
		}

		// Token: 0x060157D0 RID: 88016
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConeSource_SetAngle_26(HandleRef pThis, double angle);

		/// <summary>
		/// Set the angle of the cone. This is the angle between the axis of the cone
		/// and a generatrix. Warning: this is not the aperture! The aperture is
		/// twice this angle.
		/// As a side effect, the angle plus height sets the base radius of the cone.
		/// Angle is expressed in degrees.
		/// </summary>
		// Token: 0x060157D1 RID: 88017 RVA: 0x001E63BB File Offset: 0x001E45BB
		public void SetAngle(double angle)
		{
			vtkConeSource.vtkConeSource_SetAngle_26(base.GetCppThis(), angle);
		}

		// Token: 0x060157D2 RID: 88018
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConeSource_SetCapping_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off whether to cap the base of the cone with a polygon.
		/// </summary>
		// Token: 0x060157D3 RID: 88019 RVA: 0x001E63CB File Offset: 0x001E45CB
		public virtual void SetCapping(int _arg)
		{
			vtkConeSource.vtkConeSource_SetCapping_27(base.GetCppThis(), _arg);
		}

		// Token: 0x060157D4 RID: 88020
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConeSource_SetCenter_28(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the center of the cone. It is located at the middle of the axis of
		/// the cone. Warning: this is not the center of the base of the cone!
		/// The default is 0,0,0.
		/// </summary>
		// Token: 0x060157D5 RID: 88021 RVA: 0x001E63DB File Offset: 0x001E45DB
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkConeSource.vtkConeSource_SetCenter_28(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060157D6 RID: 88022
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConeSource_SetCenter_29(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the center of the cone. It is located at the middle of the axis of
		/// the cone. Warning: this is not the center of the base of the cone!
		/// The default is 0,0,0.
		/// </summary>
		// Token: 0x060157D7 RID: 88023 RVA: 0x001E63ED File Offset: 0x001E45ED
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkConeSource.vtkConeSource_SetCenter_29(base.GetCppThis(), _arg);
		}

		// Token: 0x060157D8 RID: 88024
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConeSource_SetDirection_30(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the orientation vector of the cone. The vector does not have
		/// to be normalized. The direction goes from the center of the base toward
		/// the apex. The default is (1,0,0).
		/// </summary>
		// Token: 0x060157D9 RID: 88025 RVA: 0x001E63FD File Offset: 0x001E45FD
		public virtual void SetDirection(double _arg1, double _arg2, double _arg3)
		{
			vtkConeSource.vtkConeSource_SetDirection_30(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060157DA RID: 88026
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConeSource_SetDirection_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the orientation vector of the cone. The vector does not have
		/// to be normalized. The direction goes from the center of the base toward
		/// the apex. The default is (1,0,0).
		/// </summary>
		// Token: 0x060157DB RID: 88027 RVA: 0x001E640F File Offset: 0x001E460F
		public virtual void SetDirection(IntPtr _arg)
		{
			vtkConeSource.vtkConeSource_SetDirection_31(base.GetCppThis(), _arg);
		}

		// Token: 0x060157DC RID: 88028
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConeSource_SetHeight_32(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the height of the cone. This is the height along the cone in
		/// its specified direction.
		/// </summary>
		// Token: 0x060157DD RID: 88029 RVA: 0x001E641F File Offset: 0x001E461F
		public virtual void SetHeight(double _arg)
		{
			vtkConeSource.vtkConeSource_SetHeight_32(base.GetCppThis(), _arg);
		}

		// Token: 0x060157DE RID: 88030
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConeSource_SetOutputPointsPrecision_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x060157DF RID: 88031 RVA: 0x001E642F File Offset: 0x001E462F
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkConeSource.vtkConeSource_SetOutputPointsPrecision_33(base.GetCppThis(), _arg);
		}

		// Token: 0x060157E0 RID: 88032
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConeSource_SetRadius_34(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the base radius of the cone.
		/// </summary>
		// Token: 0x060157E1 RID: 88033 RVA: 0x001E643F File Offset: 0x001E463F
		public virtual void SetRadius(double _arg)
		{
			vtkConeSource.vtkConeSource_SetRadius_34(base.GetCppThis(), _arg);
		}

		// Token: 0x060157E2 RID: 88034
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConeSource_SetResolution_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of facets used to represent the cone.
		/// </summary>
		// Token: 0x060157E3 RID: 88035 RVA: 0x001E644F File Offset: 0x001E464F
		public virtual void SetResolution(int _arg)
		{
			vtkConeSource.vtkConeSource_SetResolution_35(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400188D RID: 6285
		public new const string MRFullTypeName = "Kitware.VTK.vtkConeSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400188E RID: 6286
		public new static readonly string MRClassNameKey = "class vtkConeSource";
	}
}
