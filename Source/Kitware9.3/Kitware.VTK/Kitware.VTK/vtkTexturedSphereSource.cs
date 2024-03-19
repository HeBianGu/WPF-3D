using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTexturedSphereSource
	/// </summary>
	/// <remarks>
	///    create a sphere centered at the origin
	///
	/// vtkTexturedSphereSource creates a polygonal sphere of specified radius
	/// centered at the origin. The resolution (polygonal discretization) in both
	/// the latitude (phi) and longitude (theta) directions can be specified.
	/// It also is possible to create partial sphere by specifying maximum phi and
	/// theta angles.
	/// </remarks>
	// Token: 0x02000847 RID: 2119
	public class vtkTexturedSphereSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015F76 RID: 89974 RVA: 0x001EF17F File Offset: 0x001ED37F
		static vtkTexturedSphereSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTexturedSphereSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTexturedSphereSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015F77 RID: 89975 RVA: 0x001EF1A7 File Offset: 0x001ED3A7
		public vtkTexturedSphereSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015F78 RID: 89976
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedSphereSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct sphere with radius=0.5 and default resolution 8 in both Phi
		/// and Theta directions.
		/// </summary>
		// Token: 0x06015F79 RID: 89977 RVA: 0x001EF1B8 File Offset: 0x001ED3B8
		public new static vtkTexturedSphereSource New()
		{
			vtkTexturedSphereSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedSphereSource.vtkTexturedSphereSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTexturedSphereSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct sphere with radius=0.5 and default resolution 8 in both Phi
		/// and Theta directions.
		/// </summary>
		// Token: 0x06015F7A RID: 89978 RVA: 0x001EF20C File Offset: 0x001ED40C
		public vtkTexturedSphereSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTexturedSphereSource.vtkTexturedSphereSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015F7B RID: 89979 RVA: 0x001EF250 File Offset: 0x001ED450
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015F7C RID: 89980
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTexturedSphereSource_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015F7D RID: 89981 RVA: 0x001EF25C File Offset: 0x001ED45C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06015F7E RID: 89982
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTexturedSphereSource_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015F7F RID: 89983 RVA: 0x001EF27C File Offset: 0x001ED47C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06015F80 RID: 89984
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedSphereSource_GetOutputPointsPrecision_03(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015F81 RID: 89985 RVA: 0x001EF298 File Offset: 0x001ED498
		public virtual int GetOutputPointsPrecision()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetOutputPointsPrecision_03(base.GetCppThis());
		}

		// Token: 0x06015F82 RID: 89986
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTexturedSphereSource_GetPhi_04(HandleRef pThis);

		/// <summary>
		/// Set the maximum latitude angle (0 is at north pole).
		/// </summary>
		// Token: 0x06015F83 RID: 89987 RVA: 0x001EF2B8 File Offset: 0x001ED4B8
		public virtual double GetPhi()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetPhi_04(base.GetCppThis());
		}

		// Token: 0x06015F84 RID: 89988
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTexturedSphereSource_GetPhiMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set the maximum latitude angle (0 is at north pole).
		/// </summary>
		// Token: 0x06015F85 RID: 89989 RVA: 0x001EF2D8 File Offset: 0x001ED4D8
		public virtual double GetPhiMaxValue()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetPhiMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06015F86 RID: 89990
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTexturedSphereSource_GetPhiMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set the maximum latitude angle (0 is at north pole).
		/// </summary>
		// Token: 0x06015F87 RID: 89991 RVA: 0x001EF2F8 File Offset: 0x001ED4F8
		public virtual double GetPhiMinValue()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetPhiMinValue_06(base.GetCppThis());
		}

		// Token: 0x06015F88 RID: 89992
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedSphereSource_GetPhiResolution_07(HandleRef pThis);

		/// <summary>
		/// Set the number of points in the latitude direction.
		/// </summary>
		// Token: 0x06015F89 RID: 89993 RVA: 0x001EF318 File Offset: 0x001ED518
		public virtual int GetPhiResolution()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetPhiResolution_07(base.GetCppThis());
		}

		// Token: 0x06015F8A RID: 89994
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedSphereSource_GetPhiResolutionMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set the number of points in the latitude direction.
		/// </summary>
		// Token: 0x06015F8B RID: 89995 RVA: 0x001EF338 File Offset: 0x001ED538
		public virtual int GetPhiResolutionMaxValue()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetPhiResolutionMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06015F8C RID: 89996
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedSphereSource_GetPhiResolutionMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set the number of points in the latitude direction.
		/// </summary>
		// Token: 0x06015F8D RID: 89997 RVA: 0x001EF358 File Offset: 0x001ED558
		public virtual int GetPhiResolutionMinValue()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetPhiResolutionMinValue_09(base.GetCppThis());
		}

		// Token: 0x06015F8E RID: 89998
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTexturedSphereSource_GetRadius_10(HandleRef pThis);

		/// <summary>
		/// Set radius of sphere.
		/// </summary>
		// Token: 0x06015F8F RID: 89999 RVA: 0x001EF378 File Offset: 0x001ED578
		public virtual double GetRadius()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetRadius_10(base.GetCppThis());
		}

		// Token: 0x06015F90 RID: 90000
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTexturedSphereSource_GetRadiusMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set radius of sphere.
		/// </summary>
		// Token: 0x06015F91 RID: 90001 RVA: 0x001EF398 File Offset: 0x001ED598
		public virtual double GetRadiusMaxValue()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetRadiusMaxValue_11(base.GetCppThis());
		}

		// Token: 0x06015F92 RID: 90002
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTexturedSphereSource_GetRadiusMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set radius of sphere.
		/// </summary>
		// Token: 0x06015F93 RID: 90003 RVA: 0x001EF3B8 File Offset: 0x001ED5B8
		public virtual double GetRadiusMinValue()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetRadiusMinValue_12(base.GetCppThis());
		}

		// Token: 0x06015F94 RID: 90004
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTexturedSphereSource_GetTheta_13(HandleRef pThis);

		/// <summary>
		/// Set the maximum longitude angle.
		/// </summary>
		// Token: 0x06015F95 RID: 90005 RVA: 0x001EF3D8 File Offset: 0x001ED5D8
		public virtual double GetTheta()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetTheta_13(base.GetCppThis());
		}

		// Token: 0x06015F96 RID: 90006
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTexturedSphereSource_GetThetaMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Set the maximum longitude angle.
		/// </summary>
		// Token: 0x06015F97 RID: 90007 RVA: 0x001EF3F8 File Offset: 0x001ED5F8
		public virtual double GetThetaMaxValue()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetThetaMaxValue_14(base.GetCppThis());
		}

		// Token: 0x06015F98 RID: 90008
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTexturedSphereSource_GetThetaMinValue_15(HandleRef pThis);

		/// <summary>
		/// Set the maximum longitude angle.
		/// </summary>
		// Token: 0x06015F99 RID: 90009 RVA: 0x001EF418 File Offset: 0x001ED618
		public virtual double GetThetaMinValue()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetThetaMinValue_15(base.GetCppThis());
		}

		// Token: 0x06015F9A RID: 90010
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedSphereSource_GetThetaResolution_16(HandleRef pThis);

		/// <summary>
		/// Set the number of points in the longitude direction.
		/// </summary>
		// Token: 0x06015F9B RID: 90011 RVA: 0x001EF438 File Offset: 0x001ED638
		public virtual int GetThetaResolution()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetThetaResolution_16(base.GetCppThis());
		}

		// Token: 0x06015F9C RID: 90012
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedSphereSource_GetThetaResolutionMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Set the number of points in the longitude direction.
		/// </summary>
		// Token: 0x06015F9D RID: 90013 RVA: 0x001EF458 File Offset: 0x001ED658
		public virtual int GetThetaResolutionMaxValue()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetThetaResolutionMaxValue_17(base.GetCppThis());
		}

		// Token: 0x06015F9E RID: 90014
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedSphereSource_GetThetaResolutionMinValue_18(HandleRef pThis);

		/// <summary>
		/// Set the number of points in the longitude direction.
		/// </summary>
		// Token: 0x06015F9F RID: 90015 RVA: 0x001EF478 File Offset: 0x001ED678
		public virtual int GetThetaResolutionMinValue()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetThetaResolutionMinValue_18(base.GetCppThis());
		}

		// Token: 0x06015FA0 RID: 90016
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedSphereSource_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015FA1 RID: 90017 RVA: 0x001EF498 File Offset: 0x001ED698
		public override int IsA(string type)
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x06015FA2 RID: 90018
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedSphereSource_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015FA3 RID: 90019 RVA: 0x001EF4B8 File Offset: 0x001ED6B8
		public new static int IsTypeOf(string type)
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_IsTypeOf_20(type);
		}

		// Token: 0x06015FA4 RID: 90020
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedSphereSource_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015FA5 RID: 90021 RVA: 0x001EF4D4 File Offset: 0x001ED6D4
		public new vtkTexturedSphereSource NewInstance()
		{
			vtkTexturedSphereSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedSphereSource.vtkTexturedSphereSource_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTexturedSphereSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015FA6 RID: 90022
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedSphereSource_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015FA7 RID: 90023 RVA: 0x001EF530 File Offset: 0x001ED730
		public new static vtkTexturedSphereSource SafeDownCast(vtkObjectBase o)
		{
			vtkTexturedSphereSource vtkTexturedSphereSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedSphereSource.vtkTexturedSphereSource_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexturedSphereSource = (vtkTexturedSphereSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexturedSphereSource.Register(null);
				}
			}
			return vtkTexturedSphereSource;
		}

		// Token: 0x06015FA8 RID: 90024
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedSphereSource_SetOutputPointsPrecision_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015FA9 RID: 90025 RVA: 0x001EF5AF File Offset: 0x001ED7AF
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkTexturedSphereSource.vtkTexturedSphereSource_SetOutputPointsPrecision_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06015FAA RID: 90026
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedSphereSource_SetPhi_25(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the maximum latitude angle (0 is at north pole).
		/// </summary>
		// Token: 0x06015FAB RID: 90027 RVA: 0x001EF5BF File Offset: 0x001ED7BF
		public virtual void SetPhi(double _arg)
		{
			vtkTexturedSphereSource.vtkTexturedSphereSource_SetPhi_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06015FAC RID: 90028
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedSphereSource_SetPhiResolution_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of points in the latitude direction.
		/// </summary>
		// Token: 0x06015FAD RID: 90029 RVA: 0x001EF5CF File Offset: 0x001ED7CF
		public virtual void SetPhiResolution(int _arg)
		{
			vtkTexturedSphereSource.vtkTexturedSphereSource_SetPhiResolution_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06015FAE RID: 90030
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedSphereSource_SetRadius_27(HandleRef pThis, double _arg);

		/// <summary>
		/// Set radius of sphere.
		/// </summary>
		// Token: 0x06015FAF RID: 90031 RVA: 0x001EF5DF File Offset: 0x001ED7DF
		public virtual void SetRadius(double _arg)
		{
			vtkTexturedSphereSource.vtkTexturedSphereSource_SetRadius_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06015FB0 RID: 90032
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedSphereSource_SetTheta_28(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the maximum longitude angle.
		/// </summary>
		// Token: 0x06015FB1 RID: 90033 RVA: 0x001EF5EF File Offset: 0x001ED7EF
		public virtual void SetTheta(double _arg)
		{
			vtkTexturedSphereSource.vtkTexturedSphereSource_SetTheta_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06015FB2 RID: 90034
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedSphereSource_SetThetaResolution_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of points in the longitude direction.
		/// </summary>
		// Token: 0x06015FB3 RID: 90035 RVA: 0x001EF5FF File Offset: 0x001ED7FF
		public virtual void SetThetaResolution(int _arg)
		{
			vtkTexturedSphereSource.vtkTexturedSphereSource_SetThetaResolution_29(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018E2 RID: 6370
		public new const string MRFullTypeName = "Kitware.VTK.vtkTexturedSphereSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018E3 RID: 6371
		public new static readonly string MRClassNameKey = "class vtkTexturedSphereSource";
	}
}
