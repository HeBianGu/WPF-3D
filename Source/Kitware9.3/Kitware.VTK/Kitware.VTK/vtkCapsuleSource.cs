using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCapsuleSource
	/// </summary>
	/// <remarks>
	///    Generate a capsule centered at the origin
	///
	/// vtkCapsuleSource creates a capsule (represented by polygons) of specified
	/// radius centered at the origin. The resolution (polygonal discretization) in
	/// both the latitude (phi) and longitude (theta) directions can be specified as
	/// well as the length of the capsule cylinder (CylinderLength). By default, the
	/// surface tessellation of the sphere uses triangles; however you can set
	/// LatLongTessellation to produce a tessellation using quadrilaterals (except
	/// at the poles of the capsule).
	/// </remarks>
	// Token: 0x02000820 RID: 2080
	public class vtkCapsuleSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015716 RID: 87830 RVA: 0x001E55DB File Offset: 0x001E37DB
		static vtkCapsuleSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCapsuleSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCapsuleSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015717 RID: 87831 RVA: 0x001E5603 File Offset: 0x001E3803
		public vtkCapsuleSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015718 RID: 87832
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCapsuleSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a capsule with radius 0.5 and resolution 8 in both the Phi and Theta directions and a
		/// cylinder of length 1.0.
		/// </summary>
		// Token: 0x06015719 RID: 87833 RVA: 0x001E5614 File Offset: 0x001E3814
		public new static vtkCapsuleSource New()
		{
			vtkCapsuleSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCapsuleSource.vtkCapsuleSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCapsuleSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a capsule with radius 0.5 and resolution 8 in both the Phi and Theta directions and a
		/// cylinder of length 1.0.
		/// </summary>
		// Token: 0x0601571A RID: 87834 RVA: 0x001E5668 File Offset: 0x001E3868
		public vtkCapsuleSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCapsuleSource.vtkCapsuleSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601571B RID: 87835 RVA: 0x001E56AC File Offset: 0x001E38AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601571C RID: 87836
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCapsuleSource_GetCenter_01(HandleRef pThis);

		/// <summary>
		/// Set/get the center of the capsule. The initial value is (0.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x0601571D RID: 87837 RVA: 0x001E56B8 File Offset: 0x001E38B8
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkCapsuleSource.vtkCapsuleSource_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601571E RID: 87838
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCapsuleSource_GetCenter_02(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/get the center of the capsule. The initial value is (0.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x0601571F RID: 87839 RVA: 0x001E5700 File Offset: 0x001E3900
		public virtual void GetCenter(IntPtr data)
		{
			vtkCapsuleSource.vtkCapsuleSource_GetCenter_02(base.GetCppThis(), data);
		}

		// Token: 0x06015720 RID: 87840
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCapsuleSource_GetCylinderLength_03(HandleRef pThis);

		/// <summary>
		/// Set/get the length of the cylinder. The initial value is 1.0.
		/// </summary>
		// Token: 0x06015721 RID: 87841 RVA: 0x001E5710 File Offset: 0x001E3910
		public virtual double GetCylinderLength()
		{
			return vtkCapsuleSource.vtkCapsuleSource_GetCylinderLength_03(base.GetCppThis());
		}

		// Token: 0x06015722 RID: 87842
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCapsuleSource_GetCylinderLengthMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Set/get the length of the cylinder. The initial value is 1.0.
		/// </summary>
		// Token: 0x06015723 RID: 87843 RVA: 0x001E5730 File Offset: 0x001E3930
		public virtual double GetCylinderLengthMaxValue()
		{
			return vtkCapsuleSource.vtkCapsuleSource_GetCylinderLengthMaxValue_04(base.GetCppThis());
		}

		// Token: 0x06015724 RID: 87844
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCapsuleSource_GetCylinderLengthMinValue_05(HandleRef pThis);

		/// <summary>
		/// Set/get the length of the cylinder. The initial value is 1.0.
		/// </summary>
		// Token: 0x06015725 RID: 87845 RVA: 0x001E5750 File Offset: 0x001E3950
		public virtual double GetCylinderLengthMinValue()
		{
			return vtkCapsuleSource.vtkCapsuleSource_GetCylinderLengthMinValue_05(base.GetCppThis());
		}

		// Token: 0x06015726 RID: 87846
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCapsuleSource_GetLatLongTessellation_06(HandleRef pThis);

		/// <summary>
		/// Cause the spheres to be tessellated with edges along the latitude and longitude lines. If off,
		/// triangles are generated at non-polar regions, which results in edges that are not parallel to
		/// latitude and longitude lines. If on, quadrilaterals are generated everywhere except at the
		/// poles. This can be useful for generating wireframe spheres with natural latitude and longitude
		/// lines.
		/// </summary>
		// Token: 0x06015727 RID: 87847 RVA: 0x001E5770 File Offset: 0x001E3970
		public virtual int GetLatLongTessellation()
		{
			return vtkCapsuleSource.vtkCapsuleSource_GetLatLongTessellation_06(base.GetCppThis());
		}

		// Token: 0x06015728 RID: 87848
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCapsuleSource_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015729 RID: 87849 RVA: 0x001E5790 File Offset: 0x001E3990
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCapsuleSource.vtkCapsuleSource_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601572A RID: 87850
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCapsuleSource_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601572B RID: 87851 RVA: 0x001E57B0 File Offset: 0x001E39B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCapsuleSource.vtkCapsuleSource_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601572C RID: 87852
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCapsuleSource_GetOutputPointsPrecision_09(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x0601572D RID: 87853 RVA: 0x001E57CC File Offset: 0x001E39CC
		public virtual int GetOutputPointsPrecision()
		{
			return vtkCapsuleSource.vtkCapsuleSource_GetOutputPointsPrecision_09(base.GetCppThis());
		}

		// Token: 0x0601572E RID: 87854
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCapsuleSource_GetPhiResolution_10(HandleRef pThis);

		/// <summary>
		/// Set/get the number of points in the latitude direction for the spheres. The initial value is 8.
		/// </summary>
		// Token: 0x0601572F RID: 87855 RVA: 0x001E57EC File Offset: 0x001E39EC
		public virtual int GetPhiResolution()
		{
			return vtkCapsuleSource.vtkCapsuleSource_GetPhiResolution_10(base.GetCppThis());
		}

		// Token: 0x06015730 RID: 87856
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCapsuleSource_GetPhiResolutionMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set/get the number of points in the latitude direction for the spheres. The initial value is 8.
		/// </summary>
		// Token: 0x06015731 RID: 87857 RVA: 0x001E580C File Offset: 0x001E3A0C
		public virtual int GetPhiResolutionMaxValue()
		{
			return vtkCapsuleSource.vtkCapsuleSource_GetPhiResolutionMaxValue_11(base.GetCppThis());
		}

		// Token: 0x06015732 RID: 87858
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCapsuleSource_GetPhiResolutionMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set/get the number of points in the latitude direction for the spheres. The initial value is 8.
		/// </summary>
		// Token: 0x06015733 RID: 87859 RVA: 0x001E582C File Offset: 0x001E3A2C
		public virtual int GetPhiResolutionMinValue()
		{
			return vtkCapsuleSource.vtkCapsuleSource_GetPhiResolutionMinValue_12(base.GetCppThis());
		}

		// Token: 0x06015734 RID: 87860
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCapsuleSource_GetRadius_13(HandleRef pThis);

		/// <summary>
		/// Set/get the radius of the capsule. The initial value is 0.5.
		/// </summary>
		// Token: 0x06015735 RID: 87861 RVA: 0x001E584C File Offset: 0x001E3A4C
		public virtual double GetRadius()
		{
			return vtkCapsuleSource.vtkCapsuleSource_GetRadius_13(base.GetCppThis());
		}

		// Token: 0x06015736 RID: 87862
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCapsuleSource_GetRadiusMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Set/get the radius of the capsule. The initial value is 0.5.
		/// </summary>
		// Token: 0x06015737 RID: 87863 RVA: 0x001E586C File Offset: 0x001E3A6C
		public virtual double GetRadiusMaxValue()
		{
			return vtkCapsuleSource.vtkCapsuleSource_GetRadiusMaxValue_14(base.GetCppThis());
		}

		// Token: 0x06015738 RID: 87864
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCapsuleSource_GetRadiusMinValue_15(HandleRef pThis);

		/// <summary>
		/// Set/get the radius of the capsule. The initial value is 0.5.
		/// </summary>
		// Token: 0x06015739 RID: 87865 RVA: 0x001E588C File Offset: 0x001E3A8C
		public virtual double GetRadiusMinValue()
		{
			return vtkCapsuleSource.vtkCapsuleSource_GetRadiusMinValue_15(base.GetCppThis());
		}

		// Token: 0x0601573A RID: 87866
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCapsuleSource_GetThetaResolution_16(HandleRef pThis);

		/// <summary>
		/// Set/get the number of points in the longitude direction for the spheres. The initial value
		/// is 8.
		/// </summary>
		// Token: 0x0601573B RID: 87867 RVA: 0x001E58AC File Offset: 0x001E3AAC
		public virtual int GetThetaResolution()
		{
			return vtkCapsuleSource.vtkCapsuleSource_GetThetaResolution_16(base.GetCppThis());
		}

		// Token: 0x0601573C RID: 87868
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCapsuleSource_GetThetaResolutionMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Set/get the number of points in the longitude direction for the spheres. The initial value
		/// is 8.
		/// </summary>
		// Token: 0x0601573D RID: 87869 RVA: 0x001E58CC File Offset: 0x001E3ACC
		public virtual int GetThetaResolutionMaxValue()
		{
			return vtkCapsuleSource.vtkCapsuleSource_GetThetaResolutionMaxValue_17(base.GetCppThis());
		}

		// Token: 0x0601573E RID: 87870
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCapsuleSource_GetThetaResolutionMinValue_18(HandleRef pThis);

		/// <summary>
		/// Set/get the number of points in the longitude direction for the spheres. The initial value
		/// is 8.
		/// </summary>
		// Token: 0x0601573F RID: 87871 RVA: 0x001E58EC File Offset: 0x001E3AEC
		public virtual int GetThetaResolutionMinValue()
		{
			return vtkCapsuleSource.vtkCapsuleSource_GetThetaResolutionMinValue_18(base.GetCppThis());
		}

		// Token: 0x06015740 RID: 87872
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCapsuleSource_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015741 RID: 87873 RVA: 0x001E590C File Offset: 0x001E3B0C
		public override int IsA(string type)
		{
			return vtkCapsuleSource.vtkCapsuleSource_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x06015742 RID: 87874
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCapsuleSource_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015743 RID: 87875 RVA: 0x001E592C File Offset: 0x001E3B2C
		public new static int IsTypeOf(string type)
		{
			return vtkCapsuleSource.vtkCapsuleSource_IsTypeOf_20(type);
		}

		// Token: 0x06015744 RID: 87876
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCapsuleSource_LatLongTessellationOff_21(HandleRef pThis);

		/// <summary>
		/// Cause the spheres to be tessellated with edges along the latitude and longitude lines. If off,
		/// triangles are generated at non-polar regions, which results in edges that are not parallel to
		/// latitude and longitude lines. If on, quadrilaterals are generated everywhere except at the
		/// poles. This can be useful for generating wireframe spheres with natural latitude and longitude
		/// lines.
		/// </summary>
		// Token: 0x06015745 RID: 87877 RVA: 0x001E5946 File Offset: 0x001E3B46
		public virtual void LatLongTessellationOff()
		{
			vtkCapsuleSource.vtkCapsuleSource_LatLongTessellationOff_21(base.GetCppThis());
		}

		// Token: 0x06015746 RID: 87878
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCapsuleSource_LatLongTessellationOn_22(HandleRef pThis);

		/// <summary>
		/// Cause the spheres to be tessellated with edges along the latitude and longitude lines. If off,
		/// triangles are generated at non-polar regions, which results in edges that are not parallel to
		/// latitude and longitude lines. If on, quadrilaterals are generated everywhere except at the
		/// poles. This can be useful for generating wireframe spheres with natural latitude and longitude
		/// lines.
		/// </summary>
		// Token: 0x06015747 RID: 87879 RVA: 0x001E5955 File Offset: 0x001E3B55
		public virtual void LatLongTessellationOn()
		{
			vtkCapsuleSource.vtkCapsuleSource_LatLongTessellationOn_22(base.GetCppThis());
		}

		// Token: 0x06015748 RID: 87880
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCapsuleSource_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015749 RID: 87881 RVA: 0x001E5964 File Offset: 0x001E3B64
		public new vtkCapsuleSource NewInstance()
		{
			vtkCapsuleSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCapsuleSource.vtkCapsuleSource_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCapsuleSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601574A RID: 87882
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCapsuleSource_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601574B RID: 87883 RVA: 0x001E59C0 File Offset: 0x001E3BC0
		public new static vtkCapsuleSource SafeDownCast(vtkObjectBase o)
		{
			vtkCapsuleSource vtkCapsuleSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCapsuleSource.vtkCapsuleSource_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCapsuleSource = (vtkCapsuleSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCapsuleSource.Register(null);
				}
			}
			return vtkCapsuleSource;
		}

		// Token: 0x0601574C RID: 87884
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCapsuleSource_SetCenter_26(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/get the center of the capsule. The initial value is (0.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x0601574D RID: 87885 RVA: 0x001E5A3F File Offset: 0x001E3C3F
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkCapsuleSource.vtkCapsuleSource_SetCenter_26(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601574E RID: 87886
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCapsuleSource_SetCenter_27(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the center of the capsule. The initial value is (0.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x0601574F RID: 87887 RVA: 0x001E5A51 File Offset: 0x001E3C51
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkCapsuleSource.vtkCapsuleSource_SetCenter_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06015750 RID: 87888
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCapsuleSource_SetCylinderLength_28(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the length of the cylinder. The initial value is 1.0.
		/// </summary>
		// Token: 0x06015751 RID: 87889 RVA: 0x001E5A61 File Offset: 0x001E3C61
		public virtual void SetCylinderLength(double _arg)
		{
			vtkCapsuleSource.vtkCapsuleSource_SetCylinderLength_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06015752 RID: 87890
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCapsuleSource_SetLatLongTessellation_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Cause the spheres to be tessellated with edges along the latitude and longitude lines. If off,
		/// triangles are generated at non-polar regions, which results in edges that are not parallel to
		/// latitude and longitude lines. If on, quadrilaterals are generated everywhere except at the
		/// poles. This can be useful for generating wireframe spheres with natural latitude and longitude
		/// lines.
		/// </summary>
		// Token: 0x06015753 RID: 87891 RVA: 0x001E5A71 File Offset: 0x001E3C71
		public virtual void SetLatLongTessellation(int _arg)
		{
			vtkCapsuleSource.vtkCapsuleSource_SetLatLongTessellation_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06015754 RID: 87892
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCapsuleSource_SetOutputPointsPrecision_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015755 RID: 87893 RVA: 0x001E5A81 File Offset: 0x001E3C81
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkCapsuleSource.vtkCapsuleSource_SetOutputPointsPrecision_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06015756 RID: 87894
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCapsuleSource_SetPhiResolution_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the number of points in the latitude direction for the spheres. The initial value is 8.
		/// </summary>
		// Token: 0x06015757 RID: 87895 RVA: 0x001E5A91 File Offset: 0x001E3C91
		public virtual void SetPhiResolution(int _arg)
		{
			vtkCapsuleSource.vtkCapsuleSource_SetPhiResolution_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06015758 RID: 87896
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCapsuleSource_SetRadius_32(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the radius of the capsule. The initial value is 0.5.
		/// </summary>
		// Token: 0x06015759 RID: 87897 RVA: 0x001E5AA1 File Offset: 0x001E3CA1
		public virtual void SetRadius(double _arg)
		{
			vtkCapsuleSource.vtkCapsuleSource_SetRadius_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0601575A RID: 87898
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCapsuleSource_SetThetaResolution_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the number of points in the longitude direction for the spheres. The initial value
		/// is 8.
		/// </summary>
		// Token: 0x0601575B RID: 87899 RVA: 0x001E5AB1 File Offset: 0x001E3CB1
		public virtual void SetThetaResolution(int _arg)
		{
			vtkCapsuleSource.vtkCapsuleSource_SetThetaResolution_33(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001889 RID: 6281
		public new const string MRFullTypeName = "Kitware.VTK.vtkCapsuleSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400188A RID: 6282
		public new static readonly string MRClassNameKey = "class vtkCapsuleSource";
	}
}
