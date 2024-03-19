using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSphereSource
	/// </summary>
	/// <remarks>
	///    create a polygonal sphere centered at the origin
	///
	/// vtkSphereSource creates a sphere (represented by polygons) of specified
	/// radius centered at the origin. The resolution (polygonal discretization)
	/// in both the latitude (phi) and longitude (theta) directions can be
	/// specified. It also is possible to create partial spheres by specifying
	/// maximum phi and theta angles. By default, the surface tessellation of
	/// the sphere uses triangles; however you can set LatLongTessellation to
	/// produce a tessellation using quadrilaterals.
	///
	/// @warning
	/// Resolution means the number of latitude or longitude lines for a complete
	/// sphere. If you create partial spheres the number of latitude/longitude
	/// lines may be off by one.
	/// </remarks>
	// Token: 0x02000532 RID: 1330
	public class vtkSphereSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600ED49 RID: 60745 RVA: 0x0014ADC5 File Offset: 0x00148FC5
		static vtkSphereSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSphereSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphereSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600ED4A RID: 60746 RVA: 0x0014ADED File Offset: 0x00148FED
		public vtkSphereSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600ED4B RID: 60747
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct sphere with radius=0.5 and default resolution 8 in both Phi
		/// and Theta directions. Theta ranges from (0,360) and phi (0,180) degrees.
		/// </summary>
		// Token: 0x0600ED4C RID: 60748 RVA: 0x0014ADFC File Offset: 0x00148FFC
		public new static vtkSphereSource New()
		{
			vtkSphereSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereSource.vtkSphereSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct sphere with radius=0.5 and default resolution 8 in both Phi
		/// and Theta directions. Theta ranges from (0,360) and phi (0,180) degrees.
		/// </summary>
		// Token: 0x0600ED4D RID: 60749 RVA: 0x0014AE50 File Offset: 0x00149050
		public vtkSphereSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSphereSource.vtkSphereSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600ED4E RID: 60750 RVA: 0x0014AE94 File Offset: 0x00149094
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600ED4F RID: 60751
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereSource_GenerateNormalsOff_01(HandleRef pThis);

		/// <summary>
		/// Specify whether to generate output point normals. By default this is
		/// enabled.
		/// </summary>
		// Token: 0x0600ED50 RID: 60752 RVA: 0x0014AE9F File Offset: 0x0014909F
		public virtual void GenerateNormalsOff()
		{
			vtkSphereSource.vtkSphereSource_GenerateNormalsOff_01(base.GetCppThis());
		}

		// Token: 0x0600ED51 RID: 60753
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereSource_GenerateNormalsOn_02(HandleRef pThis);

		/// <summary>
		/// Specify whether to generate output point normals. By default this is
		/// enabled.
		/// </summary>
		// Token: 0x0600ED52 RID: 60754 RVA: 0x0014AEAE File Offset: 0x001490AE
		public virtual void GenerateNormalsOn()
		{
			vtkSphereSource.vtkSphereSource_GenerateNormalsOn_02(base.GetCppThis());
		}

		// Token: 0x0600ED53 RID: 60755
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereSource_GetCenter_03(HandleRef pThis);

		/// <summary>
		/// Set the center of the sphere. Default is (0,0,0).
		/// </summary>
		// Token: 0x0600ED54 RID: 60756 RVA: 0x0014AEC0 File Offset: 0x001490C0
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkSphereSource.vtkSphereSource_GetCenter_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600ED55 RID: 60757
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereSource_GetCenter_04(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the center of the sphere. Default is (0,0,0).
		/// </summary>
		// Token: 0x0600ED56 RID: 60758 RVA: 0x0014AF08 File Offset: 0x00149108
		public virtual void GetCenter(IntPtr data)
		{
			vtkSphereSource.vtkSphereSource_GetCenter_04(base.GetCppThis(), data);
		}

		// Token: 0x0600ED57 RID: 60759
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereSource_GetEndPhi_05(HandleRef pThis);

		/// <summary>
		/// Set the ending latitude angle. By default EndPhi=180 degrees.
		/// </summary>
		// Token: 0x0600ED58 RID: 60760 RVA: 0x0014AF18 File Offset: 0x00149118
		public virtual double GetEndPhi()
		{
			return vtkSphereSource.vtkSphereSource_GetEndPhi_05(base.GetCppThis());
		}

		// Token: 0x0600ED59 RID: 60761
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereSource_GetEndPhiMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Set the ending latitude angle. By default EndPhi=180 degrees.
		/// </summary>
		// Token: 0x0600ED5A RID: 60762 RVA: 0x0014AF38 File Offset: 0x00149138
		public virtual double GetEndPhiMaxValue()
		{
			return vtkSphereSource.vtkSphereSource_GetEndPhiMaxValue_06(base.GetCppThis());
		}

		// Token: 0x0600ED5B RID: 60763
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereSource_GetEndPhiMinValue_07(HandleRef pThis);

		/// <summary>
		/// Set the ending latitude angle. By default EndPhi=180 degrees.
		/// </summary>
		// Token: 0x0600ED5C RID: 60764 RVA: 0x0014AF58 File Offset: 0x00149158
		public virtual double GetEndPhiMinValue()
		{
			return vtkSphereSource.vtkSphereSource_GetEndPhiMinValue_07(base.GetCppThis());
		}

		// Token: 0x0600ED5D RID: 60765
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereSource_GetEndTheta_08(HandleRef pThis);

		/// <summary>
		/// Set the ending longitude angle. By default EndTheta=360 degrees.
		/// </summary>
		// Token: 0x0600ED5E RID: 60766 RVA: 0x0014AF78 File Offset: 0x00149178
		public virtual double GetEndTheta()
		{
			return vtkSphereSource.vtkSphereSource_GetEndTheta_08(base.GetCppThis());
		}

		// Token: 0x0600ED5F RID: 60767
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereSource_GetEndThetaMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Set the ending longitude angle. By default EndTheta=360 degrees.
		/// </summary>
		// Token: 0x0600ED60 RID: 60768 RVA: 0x0014AF98 File Offset: 0x00149198
		public virtual double GetEndThetaMaxValue()
		{
			return vtkSphereSource.vtkSphereSource_GetEndThetaMaxValue_09(base.GetCppThis());
		}

		// Token: 0x0600ED61 RID: 60769
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereSource_GetEndThetaMinValue_10(HandleRef pThis);

		/// <summary>
		/// Set the ending longitude angle. By default EndTheta=360 degrees.
		/// </summary>
		// Token: 0x0600ED62 RID: 60770 RVA: 0x0014AFB8 File Offset: 0x001491B8
		public virtual double GetEndThetaMinValue()
		{
			return vtkSphereSource.vtkSphereSource_GetEndThetaMinValue_10(base.GetCppThis());
		}

		// Token: 0x0600ED63 RID: 60771
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereSource_GetGenerateNormals_11(HandleRef pThis);

		/// <summary>
		/// Specify whether to generate output point normals. By default this is
		/// enabled.
		/// </summary>
		// Token: 0x0600ED64 RID: 60772 RVA: 0x0014AFD8 File Offset: 0x001491D8
		public virtual int GetGenerateNormals()
		{
			return vtkSphereSource.vtkSphereSource_GetGenerateNormals_11(base.GetCppThis());
		}

		// Token: 0x0600ED65 RID: 60773
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereSource_GetLatLongTessellation_12(HandleRef pThis);

		/// <summary>
		/// Cause the sphere to be tessellated with edges along the latitude
		/// and longitude lines. If off, triangles are generated at non-polar
		/// regions, which results in edges that are not parallel to latitude and
		/// longitude lines. If on, quadrilaterals are generated everywhere
		/// except at the poles. This can be useful for generating a wireframe
		/// sphere with natural latitude and longitude lines.
		/// </summary>
		// Token: 0x0600ED66 RID: 60774 RVA: 0x0014AFF8 File Offset: 0x001491F8
		public virtual int GetLatLongTessellation()
		{
			return vtkSphereSource.vtkSphereSource_GetLatLongTessellation_12(base.GetCppThis());
		}

		// Token: 0x0600ED67 RID: 60775
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphereSource_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600ED68 RID: 60776 RVA: 0x0014B018 File Offset: 0x00149218
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSphereSource.vtkSphereSource_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0600ED69 RID: 60777
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphereSource_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600ED6A RID: 60778 RVA: 0x0014B038 File Offset: 0x00149238
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSphereSource.vtkSphereSource_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0600ED6B RID: 60779
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereSource_GetOutputPointsPrecision_15(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x0600ED6C RID: 60780 RVA: 0x0014B054 File Offset: 0x00149254
		public virtual int GetOutputPointsPrecision()
		{
			return vtkSphereSource.vtkSphereSource_GetOutputPointsPrecision_15(base.GetCppThis());
		}

		// Token: 0x0600ED6D RID: 60781
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereSource_GetPhiResolution_16(HandleRef pThis);

		/// <summary>
		/// Set the number of points in the latitude direction (ranging
		/// from StartPhi to EndPhi).
		/// </summary>
		// Token: 0x0600ED6E RID: 60782 RVA: 0x0014B074 File Offset: 0x00149274
		public virtual int GetPhiResolution()
		{
			return vtkSphereSource.vtkSphereSource_GetPhiResolution_16(base.GetCppThis());
		}

		// Token: 0x0600ED6F RID: 60783
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereSource_GetPhiResolutionMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Set the number of points in the latitude direction (ranging
		/// from StartPhi to EndPhi).
		/// </summary>
		// Token: 0x0600ED70 RID: 60784 RVA: 0x0014B094 File Offset: 0x00149294
		public virtual int GetPhiResolutionMaxValue()
		{
			return vtkSphereSource.vtkSphereSource_GetPhiResolutionMaxValue_17(base.GetCppThis());
		}

		// Token: 0x0600ED71 RID: 60785
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereSource_GetPhiResolutionMinValue_18(HandleRef pThis);

		/// <summary>
		/// Set the number of points in the latitude direction (ranging
		/// from StartPhi to EndPhi).
		/// </summary>
		// Token: 0x0600ED72 RID: 60786 RVA: 0x0014B0B4 File Offset: 0x001492B4
		public virtual int GetPhiResolutionMinValue()
		{
			return vtkSphereSource.vtkSphereSource_GetPhiResolutionMinValue_18(base.GetCppThis());
		}

		// Token: 0x0600ED73 RID: 60787
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereSource_GetRadius_19(HandleRef pThis);

		/// <summary>
		/// Set the radius of sphere. Default is 0.5.
		/// </summary>
		// Token: 0x0600ED74 RID: 60788 RVA: 0x0014B0D4 File Offset: 0x001492D4
		public virtual double GetRadius()
		{
			return vtkSphereSource.vtkSphereSource_GetRadius_19(base.GetCppThis());
		}

		// Token: 0x0600ED75 RID: 60789
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereSource_GetRadiusMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Set the radius of sphere. Default is 0.5.
		/// </summary>
		// Token: 0x0600ED76 RID: 60790 RVA: 0x0014B0F4 File Offset: 0x001492F4
		public virtual double GetRadiusMaxValue()
		{
			return vtkSphereSource.vtkSphereSource_GetRadiusMaxValue_20(base.GetCppThis());
		}

		// Token: 0x0600ED77 RID: 60791
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereSource_GetRadiusMinValue_21(HandleRef pThis);

		/// <summary>
		/// Set the radius of sphere. Default is 0.5.
		/// </summary>
		// Token: 0x0600ED78 RID: 60792 RVA: 0x0014B114 File Offset: 0x00149314
		public virtual double GetRadiusMinValue()
		{
			return vtkSphereSource.vtkSphereSource_GetRadiusMinValue_21(base.GetCppThis());
		}

		// Token: 0x0600ED79 RID: 60793
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereSource_GetStartPhi_22(HandleRef pThis);

		/// <summary>
		/// Set the starting latitude angle (0 is at north pole). By default
		/// StartPhi=0 degrees.
		/// </summary>
		// Token: 0x0600ED7A RID: 60794 RVA: 0x0014B134 File Offset: 0x00149334
		public virtual double GetStartPhi()
		{
			return vtkSphereSource.vtkSphereSource_GetStartPhi_22(base.GetCppThis());
		}

		// Token: 0x0600ED7B RID: 60795
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereSource_GetStartPhiMaxValue_23(HandleRef pThis);

		/// <summary>
		/// Set the starting latitude angle (0 is at north pole). By default
		/// StartPhi=0 degrees.
		/// </summary>
		// Token: 0x0600ED7C RID: 60796 RVA: 0x0014B154 File Offset: 0x00149354
		public virtual double GetStartPhiMaxValue()
		{
			return vtkSphereSource.vtkSphereSource_GetStartPhiMaxValue_23(base.GetCppThis());
		}

		// Token: 0x0600ED7D RID: 60797
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereSource_GetStartPhiMinValue_24(HandleRef pThis);

		/// <summary>
		/// Set the starting latitude angle (0 is at north pole). By default
		/// StartPhi=0 degrees.
		/// </summary>
		// Token: 0x0600ED7E RID: 60798 RVA: 0x0014B174 File Offset: 0x00149374
		public virtual double GetStartPhiMinValue()
		{
			return vtkSphereSource.vtkSphereSource_GetStartPhiMinValue_24(base.GetCppThis());
		}

		// Token: 0x0600ED7F RID: 60799
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereSource_GetStartTheta_25(HandleRef pThis);

		/// <summary>
		/// Set the starting longitude angle. By default StartTheta=0 degrees.
		/// </summary>
		// Token: 0x0600ED80 RID: 60800 RVA: 0x0014B194 File Offset: 0x00149394
		public virtual double GetStartTheta()
		{
			return vtkSphereSource.vtkSphereSource_GetStartTheta_25(base.GetCppThis());
		}

		// Token: 0x0600ED81 RID: 60801
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereSource_GetStartThetaMaxValue_26(HandleRef pThis);

		/// <summary>
		/// Set the starting longitude angle. By default StartTheta=0 degrees.
		/// </summary>
		// Token: 0x0600ED82 RID: 60802 RVA: 0x0014B1B4 File Offset: 0x001493B4
		public virtual double GetStartThetaMaxValue()
		{
			return vtkSphereSource.vtkSphereSource_GetStartThetaMaxValue_26(base.GetCppThis());
		}

		// Token: 0x0600ED83 RID: 60803
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereSource_GetStartThetaMinValue_27(HandleRef pThis);

		/// <summary>
		/// Set the starting longitude angle. By default StartTheta=0 degrees.
		/// </summary>
		// Token: 0x0600ED84 RID: 60804 RVA: 0x0014B1D4 File Offset: 0x001493D4
		public virtual double GetStartThetaMinValue()
		{
			return vtkSphereSource.vtkSphereSource_GetStartThetaMinValue_27(base.GetCppThis());
		}

		// Token: 0x0600ED85 RID: 60805
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereSource_GetThetaResolution_28(HandleRef pThis);

		/// <summary>
		/// Set the number of points in the longitude direction (ranging from
		/// StartTheta to EndTheta).
		/// </summary>
		// Token: 0x0600ED86 RID: 60806 RVA: 0x0014B1F4 File Offset: 0x001493F4
		public virtual int GetThetaResolution()
		{
			return vtkSphereSource.vtkSphereSource_GetThetaResolution_28(base.GetCppThis());
		}

		// Token: 0x0600ED87 RID: 60807
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereSource_GetThetaResolutionMaxValue_29(HandleRef pThis);

		/// <summary>
		/// Set the number of points in the longitude direction (ranging from
		/// StartTheta to EndTheta).
		/// </summary>
		// Token: 0x0600ED88 RID: 60808 RVA: 0x0014B214 File Offset: 0x00149414
		public virtual int GetThetaResolutionMaxValue()
		{
			return vtkSphereSource.vtkSphereSource_GetThetaResolutionMaxValue_29(base.GetCppThis());
		}

		// Token: 0x0600ED89 RID: 60809
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereSource_GetThetaResolutionMinValue_30(HandleRef pThis);

		/// <summary>
		/// Set the number of points in the longitude direction (ranging from
		/// StartTheta to EndTheta).
		/// </summary>
		// Token: 0x0600ED8A RID: 60810 RVA: 0x0014B234 File Offset: 0x00149434
		public virtual int GetThetaResolutionMinValue()
		{
			return vtkSphereSource.vtkSphereSource_GetThetaResolutionMinValue_30(base.GetCppThis());
		}

		// Token: 0x0600ED8B RID: 60811
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereSource_IsA_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600ED8C RID: 60812 RVA: 0x0014B254 File Offset: 0x00149454
		public override int IsA(string type)
		{
			return vtkSphereSource.vtkSphereSource_IsA_31(base.GetCppThis(), type);
		}

		// Token: 0x0600ED8D RID: 60813
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereSource_IsTypeOf_32([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600ED8E RID: 60814 RVA: 0x0014B274 File Offset: 0x00149474
		public new static int IsTypeOf(string type)
		{
			return vtkSphereSource.vtkSphereSource_IsTypeOf_32(type);
		}

		// Token: 0x0600ED8F RID: 60815
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereSource_LatLongTessellationOff_33(HandleRef pThis);

		/// <summary>
		/// Cause the sphere to be tessellated with edges along the latitude
		/// and longitude lines. If off, triangles are generated at non-polar
		/// regions, which results in edges that are not parallel to latitude and
		/// longitude lines. If on, quadrilaterals are generated everywhere
		/// except at the poles. This can be useful for generating a wireframe
		/// sphere with natural latitude and longitude lines.
		/// </summary>
		// Token: 0x0600ED90 RID: 60816 RVA: 0x0014B28E File Offset: 0x0014948E
		public virtual void LatLongTessellationOff()
		{
			vtkSphereSource.vtkSphereSource_LatLongTessellationOff_33(base.GetCppThis());
		}

		// Token: 0x0600ED91 RID: 60817
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereSource_LatLongTessellationOn_34(HandleRef pThis);

		/// <summary>
		/// Cause the sphere to be tessellated with edges along the latitude
		/// and longitude lines. If off, triangles are generated at non-polar
		/// regions, which results in edges that are not parallel to latitude and
		/// longitude lines. If on, quadrilaterals are generated everywhere
		/// except at the poles. This can be useful for generating a wireframe
		/// sphere with natural latitude and longitude lines.
		/// </summary>
		// Token: 0x0600ED92 RID: 60818 RVA: 0x0014B29D File Offset: 0x0014949D
		public virtual void LatLongTessellationOn()
		{
			vtkSphereSource.vtkSphereSource_LatLongTessellationOn_34(base.GetCppThis());
		}

		// Token: 0x0600ED93 RID: 60819
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereSource_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600ED94 RID: 60820 RVA: 0x0014B2AC File Offset: 0x001494AC
		public new vtkSphereSource NewInstance()
		{
			vtkSphereSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereSource.vtkSphereSource_NewInstance_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600ED95 RID: 60821
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereSource_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600ED96 RID: 60822 RVA: 0x0014B308 File Offset: 0x00149508
		public new static vtkSphereSource SafeDownCast(vtkObjectBase o)
		{
			vtkSphereSource vtkSphereSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereSource.vtkSphereSource_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphereSource = (vtkSphereSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphereSource.Register(null);
				}
			}
			return vtkSphereSource;
		}

		// Token: 0x0600ED97 RID: 60823
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereSource_SetCenter_38(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the center of the sphere. Default is (0,0,0).
		/// </summary>
		// Token: 0x0600ED98 RID: 60824 RVA: 0x0014B387 File Offset: 0x00149587
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkSphereSource.vtkSphereSource_SetCenter_38(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600ED99 RID: 60825
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereSource_SetCenter_39(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the center of the sphere. Default is (0,0,0).
		/// </summary>
		// Token: 0x0600ED9A RID: 60826 RVA: 0x0014B399 File Offset: 0x00149599
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkSphereSource.vtkSphereSource_SetCenter_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ED9B RID: 60827
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereSource_SetEndPhi_40(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the ending latitude angle. By default EndPhi=180 degrees.
		/// </summary>
		// Token: 0x0600ED9C RID: 60828 RVA: 0x0014B3A9 File Offset: 0x001495A9
		public virtual void SetEndPhi(double _arg)
		{
			vtkSphereSource.vtkSphereSource_SetEndPhi_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ED9D RID: 60829
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereSource_SetEndTheta_41(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the ending longitude angle. By default EndTheta=360 degrees.
		/// </summary>
		// Token: 0x0600ED9E RID: 60830 RVA: 0x0014B3B9 File Offset: 0x001495B9
		public virtual void SetEndTheta(double _arg)
		{
			vtkSphereSource.vtkSphereSource_SetEndTheta_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ED9F RID: 60831
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereSource_SetGenerateNormals_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to generate output point normals. By default this is
		/// enabled.
		/// </summary>
		// Token: 0x0600EDA0 RID: 60832 RVA: 0x0014B3C9 File Offset: 0x001495C9
		public virtual void SetGenerateNormals(int _arg)
		{
			vtkSphereSource.vtkSphereSource_SetGenerateNormals_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EDA1 RID: 60833
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereSource_SetLatLongTessellation_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Cause the sphere to be tessellated with edges along the latitude
		/// and longitude lines. If off, triangles are generated at non-polar
		/// regions, which results in edges that are not parallel to latitude and
		/// longitude lines. If on, quadrilaterals are generated everywhere
		/// except at the poles. This can be useful for generating a wireframe
		/// sphere with natural latitude and longitude lines.
		/// </summary>
		// Token: 0x0600EDA2 RID: 60834 RVA: 0x0014B3D9 File Offset: 0x001495D9
		public virtual void SetLatLongTessellation(int _arg)
		{
			vtkSphereSource.vtkSphereSource_SetLatLongTessellation_43(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EDA3 RID: 60835
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereSource_SetOutputPointsPrecision_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x0600EDA4 RID: 60836 RVA: 0x0014B3E9 File Offset: 0x001495E9
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkSphereSource.vtkSphereSource_SetOutputPointsPrecision_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EDA5 RID: 60837
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereSource_SetPhiResolution_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of points in the latitude direction (ranging
		/// from StartPhi to EndPhi).
		/// </summary>
		// Token: 0x0600EDA6 RID: 60838 RVA: 0x0014B3F9 File Offset: 0x001495F9
		public virtual void SetPhiResolution(int _arg)
		{
			vtkSphereSource.vtkSphereSource_SetPhiResolution_45(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EDA7 RID: 60839
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereSource_SetRadius_46(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the radius of sphere. Default is 0.5.
		/// </summary>
		// Token: 0x0600EDA8 RID: 60840 RVA: 0x0014B409 File Offset: 0x00149609
		public virtual void SetRadius(double _arg)
		{
			vtkSphereSource.vtkSphereSource_SetRadius_46(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EDA9 RID: 60841
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereSource_SetStartPhi_47(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the starting latitude angle (0 is at north pole). By default
		/// StartPhi=0 degrees.
		/// </summary>
		// Token: 0x0600EDAA RID: 60842 RVA: 0x0014B419 File Offset: 0x00149619
		public virtual void SetStartPhi(double _arg)
		{
			vtkSphereSource.vtkSphereSource_SetStartPhi_47(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EDAB RID: 60843
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereSource_SetStartTheta_48(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the starting longitude angle. By default StartTheta=0 degrees.
		/// </summary>
		// Token: 0x0600EDAC RID: 60844 RVA: 0x0014B429 File Offset: 0x00149629
		public virtual void SetStartTheta(double _arg)
		{
			vtkSphereSource.vtkSphereSource_SetStartTheta_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EDAD RID: 60845
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereSource_SetThetaResolution_49(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of points in the longitude direction (ranging from
		/// StartTheta to EndTheta).
		/// </summary>
		// Token: 0x0600EDAE RID: 60846 RVA: 0x0014B439 File Offset: 0x00149639
		public virtual void SetThetaResolution(int _arg)
		{
			vtkSphereSource.vtkSphereSource_SetThetaResolution_49(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400115C RID: 4444
		public new const string MRFullTypeName = "Kitware.VTK.vtkSphereSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400115D RID: 4445
		public new static readonly string MRClassNameKey = "class vtkSphereSource";
	}
}
