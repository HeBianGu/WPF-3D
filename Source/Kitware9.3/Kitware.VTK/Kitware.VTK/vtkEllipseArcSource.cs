using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEllipseArcSource
	/// </summary>
	/// <remarks>
	///    create an elliptical arc
	///
	///
	/// vtkEllipseArcSource is a source object that creates an elliptical arc
	/// defined by a normal, a center and the major radius vector.
	/// You can define an angle to draw only a section of the ellipse. The number of
	/// segments composing the polyline is controlled by setting the object
	/// resolution.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkArcSource
	/// </seealso>
	// Token: 0x02000828 RID: 2088
	public class vtkEllipseArcSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060158E2 RID: 88290 RVA: 0x001E769B File Offset: 0x001E589B
		static vtkEllipseArcSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEllipseArcSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEllipseArcSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060158E3 RID: 88291 RVA: 0x001E76C3 File Offset: 0x001E58C3
		public vtkEllipseArcSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060158E4 RID: 88292
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEllipseArcSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060158E5 RID: 88293 RVA: 0x001E76D4 File Offset: 0x001E58D4
		public new static vtkEllipseArcSource New()
		{
			vtkEllipseArcSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEllipseArcSource.vtkEllipseArcSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEllipseArcSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060158E6 RID: 88294 RVA: 0x001E7728 File Offset: 0x001E5928
		public vtkEllipseArcSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEllipseArcSource.vtkEllipseArcSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060158E7 RID: 88295 RVA: 0x001E776C File Offset: 0x001E596C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060158E8 RID: 88296
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipseArcSource_CloseOff_01(HandleRef pThis);

		/// <summary>
		/// Set/get whether to close the arc with a final line segment connecting the first
		/// and last points in the arc. Off by default
		/// </summary>
		// Token: 0x060158E9 RID: 88297 RVA: 0x001E7777 File Offset: 0x001E5977
		public virtual void CloseOff()
		{
			vtkEllipseArcSource.vtkEllipseArcSource_CloseOff_01(base.GetCppThis());
		}

		// Token: 0x060158EA RID: 88298
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipseArcSource_CloseOn_02(HandleRef pThis);

		/// <summary>
		/// Set/get whether to close the arc with a final line segment connecting the first
		/// and last points in the arc. Off by default
		/// </summary>
		// Token: 0x060158EB RID: 88299 RVA: 0x001E7786 File Offset: 0x001E5986
		public virtual void CloseOn()
		{
			vtkEllipseArcSource.vtkEllipseArcSource_CloseOn_02(base.GetCppThis());
		}

		// Token: 0x060158EC RID: 88300
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEllipseArcSource_GetCenter_03(HandleRef pThis);

		/// <summary>
		/// Set position of the center of the ellipse that define the arc.
		/// Default is 0, 0, 0.
		/// </summary>
		// Token: 0x060158ED RID: 88301 RVA: 0x001E7798 File Offset: 0x001E5998
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkEllipseArcSource.vtkEllipseArcSource_GetCenter_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060158EE RID: 88302
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipseArcSource_GetCenter_04(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set position of the center of the ellipse that define the arc.
		/// Default is 0, 0, 0.
		/// </summary>
		// Token: 0x060158EF RID: 88303 RVA: 0x001E77E0 File Offset: 0x001E59E0
		public virtual void GetCenter(IntPtr data)
		{
			vtkEllipseArcSource.vtkEllipseArcSource_GetCenter_04(base.GetCppThis(), data);
		}

		// Token: 0x060158F0 RID: 88304
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkEllipseArcSource_GetClose_05(HandleRef pThis);

		/// <summary>
		/// Set/get whether to close the arc with a final line segment connecting the first
		/// and last points in the arc. Off by default
		/// </summary>
		// Token: 0x060158F1 RID: 88305 RVA: 0x001E77F0 File Offset: 0x001E59F0
		public virtual bool GetClose()
		{
			return vtkEllipseArcSource.vtkEllipseArcSource_GetClose_05(base.GetCppThis()) != 0;
		}

		// Token: 0x060158F2 RID: 88306
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEllipseArcSource_GetMajorRadiusVector_06(HandleRef pThis);

		/// <summary>
		/// Set Major Radius Vector. It defines the origin of polar angle and the major
		/// radius size.
		/// Default is 1, 0, 0.
		/// </summary>
		// Token: 0x060158F3 RID: 88307 RVA: 0x001E7818 File Offset: 0x001E5A18
		public virtual double[] GetMajorRadiusVector()
		{
			IntPtr intPtr = vtkEllipseArcSource.vtkEllipseArcSource_GetMajorRadiusVector_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060158F4 RID: 88308
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipseArcSource_GetMajorRadiusVector_07(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set Major Radius Vector. It defines the origin of polar angle and the major
		/// radius size.
		/// Default is 1, 0, 0.
		/// </summary>
		// Token: 0x060158F5 RID: 88309 RVA: 0x001E7860 File Offset: 0x001E5A60
		public virtual void GetMajorRadiusVector(IntPtr data)
		{
			vtkEllipseArcSource.vtkEllipseArcSource_GetMajorRadiusVector_07(base.GetCppThis(), data);
		}

		// Token: 0x060158F6 RID: 88310
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEllipseArcSource_GetNormal_08(HandleRef pThis);

		/// <summary>
		/// Set normal vector. Represents the plane in which the ellipse will be drawn.
		/// Default 0, 0, 1.
		/// </summary>
		// Token: 0x060158F7 RID: 88311 RVA: 0x001E7870 File Offset: 0x001E5A70
		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkEllipseArcSource.vtkEllipseArcSource_GetNormal_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060158F8 RID: 88312
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipseArcSource_GetNormal_09(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set normal vector. Represents the plane in which the ellipse will be drawn.
		/// Default 0, 0, 1.
		/// </summary>
		// Token: 0x060158F9 RID: 88313 RVA: 0x001E78B8 File Offset: 0x001E5AB8
		public virtual void GetNormal(IntPtr data)
		{
			vtkEllipseArcSource.vtkEllipseArcSource_GetNormal_09(base.GetCppThis(), data);
		}

		// Token: 0x060158FA RID: 88314
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEllipseArcSource_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060158FB RID: 88315 RVA: 0x001E78C8 File Offset: 0x001E5AC8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEllipseArcSource.vtkEllipseArcSource_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x060158FC RID: 88316
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEllipseArcSource_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060158FD RID: 88317 RVA: 0x001E78E8 File Offset: 0x001E5AE8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEllipseArcSource.vtkEllipseArcSource_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x060158FE RID: 88318
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipseArcSource_GetOutputPointsPrecision_12(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point,
		/// This is the default.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x060158FF RID: 88319 RVA: 0x001E7904 File Offset: 0x001E5B04
		public virtual int GetOutputPointsPrecision()
		{
			return vtkEllipseArcSource.vtkEllipseArcSource_GetOutputPointsPrecision_12(base.GetCppThis());
		}

		// Token: 0x06015900 RID: 88320
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipseArcSource_GetRatio_13(HandleRef pThis);

		/// <summary>
		/// Set the ratio of the ellipse, i.e. the ratio b/a _ b: minor radius;
		/// a: major radius
		/// default is 1.
		/// </summary>
		// Token: 0x06015901 RID: 88321 RVA: 0x001E7924 File Offset: 0x001E5B24
		public virtual double GetRatio()
		{
			return vtkEllipseArcSource.vtkEllipseArcSource_GetRatio_13(base.GetCppThis());
		}

		// Token: 0x06015902 RID: 88322
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipseArcSource_GetRatioMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Set the ratio of the ellipse, i.e. the ratio b/a _ b: minor radius;
		/// a: major radius
		/// default is 1.
		/// </summary>
		// Token: 0x06015903 RID: 88323 RVA: 0x001E7944 File Offset: 0x001E5B44
		public virtual double GetRatioMaxValue()
		{
			return vtkEllipseArcSource.vtkEllipseArcSource_GetRatioMaxValue_14(base.GetCppThis());
		}

		// Token: 0x06015904 RID: 88324
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipseArcSource_GetRatioMinValue_15(HandleRef pThis);

		/// <summary>
		/// Set the ratio of the ellipse, i.e. the ratio b/a _ b: minor radius;
		/// a: major radius
		/// default is 1.
		/// </summary>
		// Token: 0x06015905 RID: 88325 RVA: 0x001E7964 File Offset: 0x001E5B64
		public virtual double GetRatioMinValue()
		{
			return vtkEllipseArcSource.vtkEllipseArcSource_GetRatioMinValue_15(base.GetCppThis());
		}

		// Token: 0x06015906 RID: 88326
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipseArcSource_GetResolution_16(HandleRef pThis);

		/// <summary>
		/// Divide line into resolution number of pieces.
		/// Note: if Resolution is set to 1 the arc is a
		/// straight line. Default is 100.
		/// </summary>
		// Token: 0x06015907 RID: 88327 RVA: 0x001E7984 File Offset: 0x001E5B84
		public virtual int GetResolution()
		{
			return vtkEllipseArcSource.vtkEllipseArcSource_GetResolution_16(base.GetCppThis());
		}

		// Token: 0x06015908 RID: 88328
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipseArcSource_GetResolutionMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Divide line into resolution number of pieces.
		/// Note: if Resolution is set to 1 the arc is a
		/// straight line. Default is 100.
		/// </summary>
		// Token: 0x06015909 RID: 88329 RVA: 0x001E79A4 File Offset: 0x001E5BA4
		public virtual int GetResolutionMaxValue()
		{
			return vtkEllipseArcSource.vtkEllipseArcSource_GetResolutionMaxValue_17(base.GetCppThis());
		}

		// Token: 0x0601590A RID: 88330
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipseArcSource_GetResolutionMinValue_18(HandleRef pThis);

		/// <summary>
		/// Divide line into resolution number of pieces.
		/// Note: if Resolution is set to 1 the arc is a
		/// straight line. Default is 100.
		/// </summary>
		// Token: 0x0601590B RID: 88331 RVA: 0x001E79C4 File Offset: 0x001E5BC4
		public virtual int GetResolutionMinValue()
		{
			return vtkEllipseArcSource.vtkEllipseArcSource_GetResolutionMinValue_18(base.GetCppThis());
		}

		// Token: 0x0601590C RID: 88332
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipseArcSource_GetSegmentAngle_19(HandleRef pThis);

		/// <summary>
		/// Angular sector occupied by the arc, beginning at Start Angle
		/// Default is 90.
		/// </summary>
		// Token: 0x0601590D RID: 88333 RVA: 0x001E79E4 File Offset: 0x001E5BE4
		public virtual double GetSegmentAngle()
		{
			return vtkEllipseArcSource.vtkEllipseArcSource_GetSegmentAngle_19(base.GetCppThis());
		}

		// Token: 0x0601590E RID: 88334
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipseArcSource_GetSegmentAngleMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Angular sector occupied by the arc, beginning at Start Angle
		/// Default is 90.
		/// </summary>
		// Token: 0x0601590F RID: 88335 RVA: 0x001E7A04 File Offset: 0x001E5C04
		public virtual double GetSegmentAngleMaxValue()
		{
			return vtkEllipseArcSource.vtkEllipseArcSource_GetSegmentAngleMaxValue_20(base.GetCppThis());
		}

		// Token: 0x06015910 RID: 88336
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipseArcSource_GetSegmentAngleMinValue_21(HandleRef pThis);

		/// <summary>
		/// Angular sector occupied by the arc, beginning at Start Angle
		/// Default is 90.
		/// </summary>
		// Token: 0x06015911 RID: 88337 RVA: 0x001E7A24 File Offset: 0x001E5C24
		public virtual double GetSegmentAngleMinValue()
		{
			return vtkEllipseArcSource.vtkEllipseArcSource_GetSegmentAngleMinValue_21(base.GetCppThis());
		}

		// Token: 0x06015912 RID: 88338
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipseArcSource_GetStartAngle_22(HandleRef pThis);

		/// <summary>
		/// Set the start angle. The angle where the plot begins.
		/// Default is 0.
		/// </summary>
		// Token: 0x06015913 RID: 88339 RVA: 0x001E7A44 File Offset: 0x001E5C44
		public virtual double GetStartAngle()
		{
			return vtkEllipseArcSource.vtkEllipseArcSource_GetStartAngle_22(base.GetCppThis());
		}

		// Token: 0x06015914 RID: 88340
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipseArcSource_GetStartAngleMaxValue_23(HandleRef pThis);

		/// <summary>
		/// Set the start angle. The angle where the plot begins.
		/// Default is 0.
		/// </summary>
		// Token: 0x06015915 RID: 88341 RVA: 0x001E7A64 File Offset: 0x001E5C64
		public virtual double GetStartAngleMaxValue()
		{
			return vtkEllipseArcSource.vtkEllipseArcSource_GetStartAngleMaxValue_23(base.GetCppThis());
		}

		// Token: 0x06015916 RID: 88342
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipseArcSource_GetStartAngleMinValue_24(HandleRef pThis);

		/// <summary>
		/// Set the start angle. The angle where the plot begins.
		/// Default is 0.
		/// </summary>
		// Token: 0x06015917 RID: 88343 RVA: 0x001E7A84 File Offset: 0x001E5C84
		public virtual double GetStartAngleMinValue()
		{
			return vtkEllipseArcSource.vtkEllipseArcSource_GetStartAngleMinValue_24(base.GetCppThis());
		}

		// Token: 0x06015918 RID: 88344
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipseArcSource_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015919 RID: 88345 RVA: 0x001E7AA4 File Offset: 0x001E5CA4
		public override int IsA(string type)
		{
			return vtkEllipseArcSource.vtkEllipseArcSource_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x0601591A RID: 88346
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipseArcSource_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601591B RID: 88347 RVA: 0x001E7AC4 File Offset: 0x001E5CC4
		public new static int IsTypeOf(string type)
		{
			return vtkEllipseArcSource.vtkEllipseArcSource_IsTypeOf_26(type);
		}

		// Token: 0x0601591C RID: 88348
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEllipseArcSource_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601591D RID: 88349 RVA: 0x001E7AE0 File Offset: 0x001E5CE0
		public new vtkEllipseArcSource NewInstance()
		{
			vtkEllipseArcSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEllipseArcSource.vtkEllipseArcSource_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEllipseArcSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601591E RID: 88350
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEllipseArcSource_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601591F RID: 88351 RVA: 0x001E7B3C File Offset: 0x001E5D3C
		public new static vtkEllipseArcSource SafeDownCast(vtkObjectBase o)
		{
			vtkEllipseArcSource vtkEllipseArcSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEllipseArcSource.vtkEllipseArcSource_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEllipseArcSource = (vtkEllipseArcSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEllipseArcSource.Register(null);
				}
			}
			return vtkEllipseArcSource;
		}

		// Token: 0x06015920 RID: 88352
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipseArcSource_SetCenter_30(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set position of the center of the ellipse that define the arc.
		/// Default is 0, 0, 0.
		/// </summary>
		// Token: 0x06015921 RID: 88353 RVA: 0x001E7BBB File Offset: 0x001E5DBB
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkEllipseArcSource.vtkEllipseArcSource_SetCenter_30(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06015922 RID: 88354
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipseArcSource_SetCenter_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set position of the center of the ellipse that define the arc.
		/// Default is 0, 0, 0.
		/// </summary>
		// Token: 0x06015923 RID: 88355 RVA: 0x001E7BCD File Offset: 0x001E5DCD
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkEllipseArcSource.vtkEllipseArcSource_SetCenter_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06015924 RID: 88356
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipseArcSource_SetClose_32(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/get whether to close the arc with a final line segment connecting the first
		/// and last points in the arc. Off by default
		/// </summary>
		// Token: 0x06015925 RID: 88357 RVA: 0x001E7BDD File Offset: 0x001E5DDD
		public virtual void SetClose(bool _arg)
		{
			vtkEllipseArcSource.vtkEllipseArcSource_SetClose_32(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06015926 RID: 88358
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipseArcSource_SetMajorRadiusVector_33(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set Major Radius Vector. It defines the origin of polar angle and the major
		/// radius size.
		/// Default is 1, 0, 0.
		/// </summary>
		// Token: 0x06015927 RID: 88359 RVA: 0x001E7BF5 File Offset: 0x001E5DF5
		public virtual void SetMajorRadiusVector(double _arg1, double _arg2, double _arg3)
		{
			vtkEllipseArcSource.vtkEllipseArcSource_SetMajorRadiusVector_33(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06015928 RID: 88360
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipseArcSource_SetMajorRadiusVector_34(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set Major Radius Vector. It defines the origin of polar angle and the major
		/// radius size.
		/// Default is 1, 0, 0.
		/// </summary>
		// Token: 0x06015929 RID: 88361 RVA: 0x001E7C07 File Offset: 0x001E5E07
		public virtual void SetMajorRadiusVector(IntPtr _arg)
		{
			vtkEllipseArcSource.vtkEllipseArcSource_SetMajorRadiusVector_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0601592A RID: 88362
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipseArcSource_SetNormal_35(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set normal vector. Represents the plane in which the ellipse will be drawn.
		/// Default 0, 0, 1.
		/// </summary>
		// Token: 0x0601592B RID: 88363 RVA: 0x001E7C17 File Offset: 0x001E5E17
		public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkEllipseArcSource.vtkEllipseArcSource_SetNormal_35(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601592C RID: 88364
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipseArcSource_SetNormal_36(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set normal vector. Represents the plane in which the ellipse will be drawn.
		/// Default 0, 0, 1.
		/// </summary>
		// Token: 0x0601592D RID: 88365 RVA: 0x001E7C29 File Offset: 0x001E5E29
		public virtual void SetNormal(IntPtr _arg)
		{
			vtkEllipseArcSource.vtkEllipseArcSource_SetNormal_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0601592E RID: 88366
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipseArcSource_SetOutputPointsPrecision_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point,
		/// This is the default.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x0601592F RID: 88367 RVA: 0x001E7C39 File Offset: 0x001E5E39
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkEllipseArcSource.vtkEllipseArcSource_SetOutputPointsPrecision_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06015930 RID: 88368
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipseArcSource_SetRatio_38(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the ratio of the ellipse, i.e. the ratio b/a _ b: minor radius;
		/// a: major radius
		/// default is 1.
		/// </summary>
		// Token: 0x06015931 RID: 88369 RVA: 0x001E7C49 File Offset: 0x001E5E49
		public virtual void SetRatio(double _arg)
		{
			vtkEllipseArcSource.vtkEllipseArcSource_SetRatio_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06015932 RID: 88370
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipseArcSource_SetResolution_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Divide line into resolution number of pieces.
		/// Note: if Resolution is set to 1 the arc is a
		/// straight line. Default is 100.
		/// </summary>
		// Token: 0x06015933 RID: 88371 RVA: 0x001E7C59 File Offset: 0x001E5E59
		public virtual void SetResolution(int _arg)
		{
			vtkEllipseArcSource.vtkEllipseArcSource_SetResolution_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06015934 RID: 88372
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipseArcSource_SetSegmentAngle_40(HandleRef pThis, double _arg);

		/// <summary>
		/// Angular sector occupied by the arc, beginning at Start Angle
		/// Default is 90.
		/// </summary>
		// Token: 0x06015935 RID: 88373 RVA: 0x001E7C69 File Offset: 0x001E5E69
		public virtual void SetSegmentAngle(double _arg)
		{
			vtkEllipseArcSource.vtkEllipseArcSource_SetSegmentAngle_40(base.GetCppThis(), _arg);
		}

		// Token: 0x06015936 RID: 88374
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipseArcSource_SetStartAngle_41(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the start angle. The angle where the plot begins.
		/// Default is 0.
		/// </summary>
		// Token: 0x06015937 RID: 88375 RVA: 0x001E7C79 File Offset: 0x001E5E79
		public virtual void SetStartAngle(double _arg)
		{
			vtkEllipseArcSource.vtkEllipseArcSource_SetStartAngle_41(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400189A RID: 6298
		public new const string MRFullTypeName = "Kitware.VTK.vtkEllipseArcSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400189B RID: 6299
		public new static readonly string MRClassNameKey = "class vtkEllipseArcSource";
	}
}
