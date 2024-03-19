using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRegularPolygonSource
	/// </summary>
	/// <remarks>
	///    create a regular, n-sided polygon and/or polyline
	///
	/// vtkRegularPolygonSource is a source object that creates a single n-sided polygon and/or
	/// polyline. The polygon is centered at a specified point, orthogonal to
	/// a specified normal, and with a circumscribing radius set by the user. The user can
	/// also specify the number of sides of the polygon ranging from [3,N].
	///
	/// This object can be used for seeding streamlines or defining regions for clipping/cutting.
	/// </remarks>
	// Token: 0x02000840 RID: 2112
	public class vtkRegularPolygonSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015D5A RID: 89434 RVA: 0x001ECF1F File Offset: 0x001EB11F
		static vtkRegularPolygonSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRegularPolygonSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRegularPolygonSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015D5B RID: 89435 RVA: 0x001ECF47 File Offset: 0x001EB147
		public vtkRegularPolygonSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015D5C RID: 89436
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRegularPolygonSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type and printing instance values.
		/// </summary>
		// Token: 0x06015D5D RID: 89437 RVA: 0x001ECF58 File Offset: 0x001EB158
		public new static vtkRegularPolygonSource New()
		{
			vtkRegularPolygonSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRegularPolygonSource.vtkRegularPolygonSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRegularPolygonSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type and printing instance values.
		/// </summary>
		// Token: 0x06015D5E RID: 89438 RVA: 0x001ECFAC File Offset: 0x001EB1AC
		public vtkRegularPolygonSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRegularPolygonSource.vtkRegularPolygonSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015D5F RID: 89439 RVA: 0x001ECFF0 File Offset: 0x001EB1F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015D60 RID: 89440
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRegularPolygonSource_GeneratePolygonOff_01(HandleRef pThis);

		/// <summary>
		/// Control whether a polygon is produced. By default, GeneratePolygon is enabled.
		/// </summary>
		// Token: 0x06015D61 RID: 89441 RVA: 0x001ECFFB File Offset: 0x001EB1FB
		public virtual void GeneratePolygonOff()
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_GeneratePolygonOff_01(base.GetCppThis());
		}

		// Token: 0x06015D62 RID: 89442
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRegularPolygonSource_GeneratePolygonOn_02(HandleRef pThis);

		/// <summary>
		/// Control whether a polygon is produced. By default, GeneratePolygon is enabled.
		/// </summary>
		// Token: 0x06015D63 RID: 89443 RVA: 0x001ED00A File Offset: 0x001EB20A
		public virtual void GeneratePolygonOn()
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_GeneratePolygonOn_02(base.GetCppThis());
		}

		// Token: 0x06015D64 RID: 89444
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRegularPolygonSource_GeneratePolylineOff_03(HandleRef pThis);

		/// <summary>
		/// Control whether a polyline is produced. By default, GeneratePolyline is enabled.
		/// </summary>
		// Token: 0x06015D65 RID: 89445 RVA: 0x001ED019 File Offset: 0x001EB219
		public virtual void GeneratePolylineOff()
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_GeneratePolylineOff_03(base.GetCppThis());
		}

		// Token: 0x06015D66 RID: 89446
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRegularPolygonSource_GeneratePolylineOn_04(HandleRef pThis);

		/// <summary>
		/// Control whether a polyline is produced. By default, GeneratePolyline is enabled.
		/// </summary>
		// Token: 0x06015D67 RID: 89447 RVA: 0x001ED028 File Offset: 0x001EB228
		public virtual void GeneratePolylineOn()
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_GeneratePolylineOn_04(base.GetCppThis());
		}

		// Token: 0x06015D68 RID: 89448
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRegularPolygonSource_GetCenter_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the center of the polygon. By default, the center is set at the
		/// origin (0,0,0).
		/// </summary>
		// Token: 0x06015D69 RID: 89449 RVA: 0x001ED038 File Offset: 0x001EB238
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkRegularPolygonSource.vtkRegularPolygonSource_GetCenter_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015D6A RID: 89450
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRegularPolygonSource_GetCenter_06(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the center of the polygon. By default, the center is set at the
		/// origin (0,0,0).
		/// </summary>
		// Token: 0x06015D6B RID: 89451 RVA: 0x001ED080 File Offset: 0x001EB280
		public virtual void GetCenter(IntPtr data)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_GetCenter_06(base.GetCppThis(), data);
		}

		// Token: 0x06015D6C RID: 89452
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRegularPolygonSource_GetGeneratePolygon_07(HandleRef pThis);

		/// <summary>
		/// Control whether a polygon is produced. By default, GeneratePolygon is enabled.
		/// </summary>
		// Token: 0x06015D6D RID: 89453 RVA: 0x001ED090 File Offset: 0x001EB290
		public virtual int GetGeneratePolygon()
		{
			return vtkRegularPolygonSource.vtkRegularPolygonSource_GetGeneratePolygon_07(base.GetCppThis());
		}

		// Token: 0x06015D6E RID: 89454
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRegularPolygonSource_GetGeneratePolyline_08(HandleRef pThis);

		/// <summary>
		/// Control whether a polyline is produced. By default, GeneratePolyline is enabled.
		/// </summary>
		// Token: 0x06015D6F RID: 89455 RVA: 0x001ED0B0 File Offset: 0x001EB2B0
		public virtual int GetGeneratePolyline()
		{
			return vtkRegularPolygonSource.vtkRegularPolygonSource_GetGeneratePolyline_08(base.GetCppThis());
		}

		// Token: 0x06015D70 RID: 89456
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRegularPolygonSource_GetNormal_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the normal to the polygon. The ordering of the polygon will be
		/// counter-clockwise around the normal (i.e., using the right-hand rule).
		/// By default, the normal is set to (0,0,1).
		/// </summary>
		// Token: 0x06015D71 RID: 89457 RVA: 0x001ED0D0 File Offset: 0x001EB2D0
		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkRegularPolygonSource.vtkRegularPolygonSource_GetNormal_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015D72 RID: 89458
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRegularPolygonSource_GetNormal_10(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the normal to the polygon. The ordering of the polygon will be
		/// counter-clockwise around the normal (i.e., using the right-hand rule).
		/// By default, the normal is set to (0,0,1).
		/// </summary>
		// Token: 0x06015D73 RID: 89459 RVA: 0x001ED118 File Offset: 0x001EB318
		public virtual void GetNormal(IntPtr data)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_GetNormal_10(base.GetCppThis(), data);
		}

		// Token: 0x06015D74 RID: 89460
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRegularPolygonSource_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type and printing instance values.
		/// </summary>
		// Token: 0x06015D75 RID: 89461 RVA: 0x001ED128 File Offset: 0x001EB328
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRegularPolygonSource.vtkRegularPolygonSource_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x06015D76 RID: 89462
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRegularPolygonSource_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type and printing instance values.
		/// </summary>
		// Token: 0x06015D77 RID: 89463 RVA: 0x001ED148 File Offset: 0x001EB348
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRegularPolygonSource.vtkRegularPolygonSource_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x06015D78 RID: 89464
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRegularPolygonSource_GetNumberOfSides_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of sides of the polygon. By default, the number of sides
		/// is set to six.
		/// </summary>
		// Token: 0x06015D79 RID: 89465 RVA: 0x001ED164 File Offset: 0x001EB364
		public virtual int GetNumberOfSides()
		{
			return vtkRegularPolygonSource.vtkRegularPolygonSource_GetNumberOfSides_13(base.GetCppThis());
		}

		// Token: 0x06015D7A RID: 89466
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRegularPolygonSource_GetNumberOfSidesMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of sides of the polygon. By default, the number of sides
		/// is set to six.
		/// </summary>
		// Token: 0x06015D7B RID: 89467 RVA: 0x001ED184 File Offset: 0x001EB384
		public virtual int GetNumberOfSidesMaxValue()
		{
			return vtkRegularPolygonSource.vtkRegularPolygonSource_GetNumberOfSidesMaxValue_14(base.GetCppThis());
		}

		// Token: 0x06015D7C RID: 89468
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRegularPolygonSource_GetNumberOfSidesMinValue_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of sides of the polygon. By default, the number of sides
		/// is set to six.
		/// </summary>
		// Token: 0x06015D7D RID: 89469 RVA: 0x001ED1A4 File Offset: 0x001EB3A4
		public virtual int GetNumberOfSidesMinValue()
		{
			return vtkRegularPolygonSource.vtkRegularPolygonSource_GetNumberOfSidesMinValue_15(base.GetCppThis());
		}

		// Token: 0x06015D7E RID: 89470
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRegularPolygonSource_GetOutputPointsPrecision_16(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015D7F RID: 89471 RVA: 0x001ED1C4 File Offset: 0x001EB3C4
		public virtual int GetOutputPointsPrecision()
		{
			return vtkRegularPolygonSource.vtkRegularPolygonSource_GetOutputPointsPrecision_16(base.GetCppThis());
		}

		// Token: 0x06015D80 RID: 89472
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRegularPolygonSource_GetRadius_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the radius of the polygon. By default, the radius is set to 0.5.
		/// </summary>
		// Token: 0x06015D81 RID: 89473 RVA: 0x001ED1E4 File Offset: 0x001EB3E4
		public virtual double GetRadius()
		{
			return vtkRegularPolygonSource.vtkRegularPolygonSource_GetRadius_17(base.GetCppThis());
		}

		// Token: 0x06015D82 RID: 89474
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRegularPolygonSource_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type and printing instance values.
		/// </summary>
		// Token: 0x06015D83 RID: 89475 RVA: 0x001ED204 File Offset: 0x001EB404
		public override int IsA(string type)
		{
			return vtkRegularPolygonSource.vtkRegularPolygonSource_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x06015D84 RID: 89476
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRegularPolygonSource_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type and printing instance values.
		/// </summary>
		// Token: 0x06015D85 RID: 89477 RVA: 0x001ED224 File Offset: 0x001EB424
		public new static int IsTypeOf(string type)
		{
			return vtkRegularPolygonSource.vtkRegularPolygonSource_IsTypeOf_19(type);
		}

		// Token: 0x06015D86 RID: 89478
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRegularPolygonSource_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type and printing instance values.
		/// </summary>
		// Token: 0x06015D87 RID: 89479 RVA: 0x001ED240 File Offset: 0x001EB440
		public new vtkRegularPolygonSource NewInstance()
		{
			vtkRegularPolygonSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRegularPolygonSource.vtkRegularPolygonSource_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRegularPolygonSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015D88 RID: 89480
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRegularPolygonSource_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type and printing instance values.
		/// </summary>
		// Token: 0x06015D89 RID: 89481 RVA: 0x001ED29C File Offset: 0x001EB49C
		public new static vtkRegularPolygonSource SafeDownCast(vtkObjectBase o)
		{
			vtkRegularPolygonSource vtkRegularPolygonSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRegularPolygonSource.vtkRegularPolygonSource_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRegularPolygonSource = (vtkRegularPolygonSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRegularPolygonSource.Register(null);
				}
			}
			return vtkRegularPolygonSource;
		}

		// Token: 0x06015D8A RID: 89482
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRegularPolygonSource_SetCenter_23(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the center of the polygon. By default, the center is set at the
		/// origin (0,0,0).
		/// </summary>
		// Token: 0x06015D8B RID: 89483 RVA: 0x001ED31B File Offset: 0x001EB51B
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_SetCenter_23(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06015D8C RID: 89484
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRegularPolygonSource_SetCenter_24(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the center of the polygon. By default, the center is set at the
		/// origin (0,0,0).
		/// </summary>
		// Token: 0x06015D8D RID: 89485 RVA: 0x001ED32D File Offset: 0x001EB52D
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_SetCenter_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06015D8E RID: 89486
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRegularPolygonSource_SetGeneratePolygon_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether a polygon is produced. By default, GeneratePolygon is enabled.
		/// </summary>
		// Token: 0x06015D8F RID: 89487 RVA: 0x001ED33D File Offset: 0x001EB53D
		public virtual void SetGeneratePolygon(int _arg)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_SetGeneratePolygon_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06015D90 RID: 89488
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRegularPolygonSource_SetGeneratePolyline_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether a polyline is produced. By default, GeneratePolyline is enabled.
		/// </summary>
		// Token: 0x06015D91 RID: 89489 RVA: 0x001ED34D File Offset: 0x001EB54D
		public virtual void SetGeneratePolyline(int _arg)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_SetGeneratePolyline_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06015D92 RID: 89490
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRegularPolygonSource_SetNormal_27(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the normal to the polygon. The ordering of the polygon will be
		/// counter-clockwise around the normal (i.e., using the right-hand rule).
		/// By default, the normal is set to (0,0,1).
		/// </summary>
		// Token: 0x06015D93 RID: 89491 RVA: 0x001ED35D File Offset: 0x001EB55D
		public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_SetNormal_27(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06015D94 RID: 89492
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRegularPolygonSource_SetNormal_28(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the normal to the polygon. The ordering of the polygon will be
		/// counter-clockwise around the normal (i.e., using the right-hand rule).
		/// By default, the normal is set to (0,0,1).
		/// </summary>
		// Token: 0x06015D95 RID: 89493 RVA: 0x001ED36F File Offset: 0x001EB56F
		public virtual void SetNormal(IntPtr _arg)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_SetNormal_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06015D96 RID: 89494
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRegularPolygonSource_SetNumberOfSides_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of sides of the polygon. By default, the number of sides
		/// is set to six.
		/// </summary>
		// Token: 0x06015D97 RID: 89495 RVA: 0x001ED37F File Offset: 0x001EB57F
		public virtual void SetNumberOfSides(int _arg)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_SetNumberOfSides_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06015D98 RID: 89496
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRegularPolygonSource_SetOutputPointsPrecision_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015D99 RID: 89497 RVA: 0x001ED38F File Offset: 0x001EB58F
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_SetOutputPointsPrecision_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06015D9A RID: 89498
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRegularPolygonSource_SetRadius_31(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the radius of the polygon. By default, the radius is set to 0.5.
		/// </summary>
		// Token: 0x06015D9B RID: 89499 RVA: 0x001ED39F File Offset: 0x001EB59F
		public virtual void SetRadius(double _arg)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_SetRadius_31(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018D3 RID: 6355
		public new const string MRFullTypeName = "Kitware.VTK.vtkRegularPolygonSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018D4 RID: 6356
		public new static readonly string MRClassNameKey = "class vtkRegularPolygonSource";
	}
}
