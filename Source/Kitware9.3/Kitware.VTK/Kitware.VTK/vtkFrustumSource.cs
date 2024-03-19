using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFrustumSource
	/// </summary>
	/// <remarks>
	///    create a polygonal representation of a frustum
	///
	/// vtkFrustumSource creates a frustum defines by a set of planes. The frustum
	/// is represented with four-sided polygons. It is possible to specify extra
	/// lines to better visualize the field of view.
	///
	/// @par Usage:
	/// Typical use consists of 3 steps:
	/// 1. get the planes coefficients from a vtkCamera with
	/// vtkCamera::GetFrustumPlanes()
	/// 2. initialize the planes with vtkPlanes::SetFrustumPlanes() with the planes
	/// coefficients
	/// 3. pass the vtkPlanes to a vtkFrustumSource.
	/// </remarks>
	// Token: 0x0200082A RID: 2090
	public class vtkFrustumSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015986 RID: 88454 RVA: 0x001E81F7 File Offset: 0x001E63F7
		static vtkFrustumSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFrustumSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFrustumSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015987 RID: 88455 RVA: 0x001E821F File Offset: 0x001E641F
		public vtkFrustumSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015988 RID: 88456
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFrustumSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015989 RID: 88457 RVA: 0x001E8230 File Offset: 0x001E6430
		public new static vtkFrustumSource New()
		{
			vtkFrustumSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFrustumSource.vtkFrustumSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFrustumSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601598A RID: 88458 RVA: 0x001E8284 File Offset: 0x001E6484
		public vtkFrustumSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFrustumSource.vtkFrustumSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601598B RID: 88459 RVA: 0x001E82C8 File Offset: 0x001E64C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601598C RID: 88460
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFrustumSource_GetLinesLength_01(HandleRef pThis);

		/// <summary>
		/// Length of the extra lines. This a strictly positive value.
		/// Initial value is 1.0.
		/// </summary>
		// Token: 0x0601598D RID: 88461 RVA: 0x001E82D4 File Offset: 0x001E64D4
		public virtual double GetLinesLength()
		{
			return vtkFrustumSource.vtkFrustumSource_GetLinesLength_01(base.GetCppThis());
		}

		// Token: 0x0601598E RID: 88462
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkFrustumSource_GetMTime_02(HandleRef pThis);

		/// <summary>
		/// Modified GetMTime because of Planes.
		/// </summary>
		// Token: 0x0601598F RID: 88463 RVA: 0x001E82F4 File Offset: 0x001E64F4
		public override ulong GetMTime()
		{
			return vtkFrustumSource.vtkFrustumSource_GetMTime_02(base.GetCppThis());
		}

		// Token: 0x06015990 RID: 88464
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFrustumSource_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015991 RID: 88465 RVA: 0x001E8314 File Offset: 0x001E6514
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFrustumSource.vtkFrustumSource_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06015992 RID: 88466
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFrustumSource_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015993 RID: 88467 RVA: 0x001E8334 File Offset: 0x001E6534
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFrustumSource.vtkFrustumSource_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06015994 RID: 88468
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFrustumSource_GetOutputPointsPrecision_05(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015995 RID: 88469 RVA: 0x001E8350 File Offset: 0x001E6550
		public virtual int GetOutputPointsPrecision()
		{
			return vtkFrustumSource.vtkFrustumSource_GetOutputPointsPrecision_05(base.GetCppThis());
		}

		// Token: 0x06015996 RID: 88470
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFrustumSource_GetPlanes_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the 6 planes defining the frustum. Initial value is nullptr.
		/// The 6 planes are defined in this order: left,right,bottom,top,far,near.
		/// If Planes==nullptr or if Planes-&gt;GetNumberOfPlanes()!=6 when RequestData()
		/// is called, an error message will be emitted and RequestData() will
		/// return right away.
		/// </summary>
		// Token: 0x06015997 RID: 88471 RVA: 0x001E8370 File Offset: 0x001E6570
		public virtual vtkPlanes GetPlanes()
		{
			vtkPlanes vtkPlanes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFrustumSource.vtkFrustumSource_GetPlanes_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlanes = (vtkPlanes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlanes.Register(null);
				}
			}
			return vtkPlanes;
		}

		// Token: 0x06015998 RID: 88472
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFrustumSource_GetShowLines_07(HandleRef pThis);

		/// <summary>
		/// Tells if some extra lines will be generated. Initial value is true.
		/// </summary>
		// Token: 0x06015999 RID: 88473 RVA: 0x001E83E0 File Offset: 0x001E65E0
		public virtual bool GetShowLines()
		{
			return vtkFrustumSource.vtkFrustumSource_GetShowLines_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0601599A RID: 88474
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFrustumSource_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601599B RID: 88475 RVA: 0x001E8408 File Offset: 0x001E6608
		public override int IsA(string type)
		{
			return vtkFrustumSource.vtkFrustumSource_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601599C RID: 88476
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFrustumSource_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601599D RID: 88477 RVA: 0x001E8428 File Offset: 0x001E6628
		public new static int IsTypeOf(string type)
		{
			return vtkFrustumSource.vtkFrustumSource_IsTypeOf_09(type);
		}

		// Token: 0x0601599E RID: 88478
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFrustumSource_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601599F RID: 88479 RVA: 0x001E8444 File Offset: 0x001E6644
		public new vtkFrustumSource NewInstance()
		{
			vtkFrustumSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFrustumSource.vtkFrustumSource_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFrustumSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060159A0 RID: 88480
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFrustumSource_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060159A1 RID: 88481 RVA: 0x001E84A0 File Offset: 0x001E66A0
		public new static vtkFrustumSource SafeDownCast(vtkObjectBase o)
		{
			vtkFrustumSource vtkFrustumSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFrustumSource.vtkFrustumSource_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFrustumSource = (vtkFrustumSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFrustumSource.Register(null);
				}
			}
			return vtkFrustumSource;
		}

		// Token: 0x060159A2 RID: 88482
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFrustumSource_SetLinesLength_13(HandleRef pThis, double _arg);

		/// <summary>
		/// Length of the extra lines. This a strictly positive value.
		/// Initial value is 1.0.
		/// </summary>
		// Token: 0x060159A3 RID: 88483 RVA: 0x001E851F File Offset: 0x001E671F
		public virtual void SetLinesLength(double _arg)
		{
			vtkFrustumSource.vtkFrustumSource_SetLinesLength_13(base.GetCppThis(), _arg);
		}

		// Token: 0x060159A4 RID: 88484
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFrustumSource_SetOutputPointsPrecision_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x060159A5 RID: 88485 RVA: 0x001E852F File Offset: 0x001E672F
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkFrustumSource.vtkFrustumSource_SetOutputPointsPrecision_14(base.GetCppThis(), _arg);
		}

		// Token: 0x060159A6 RID: 88486
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFrustumSource_SetPlanes_15(HandleRef pThis, HandleRef planes);

		/// <summary>
		/// Set the 6 planes defining the frustum.
		/// </summary>
		// Token: 0x060159A7 RID: 88487 RVA: 0x001E8540 File Offset: 0x001E6740
		public virtual void SetPlanes(vtkPlanes planes)
		{
			vtkFrustumSource.vtkFrustumSource_SetPlanes_15(base.GetCppThis(), (planes == null) ? default(HandleRef) : planes.GetCppThis());
		}

		// Token: 0x060159A8 RID: 88488
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFrustumSource_SetShowLines_16(HandleRef pThis, byte _arg);

		/// <summary>
		/// Tells if some extra lines will be generated. Initial value is true.
		/// </summary>
		// Token: 0x060159A9 RID: 88489 RVA: 0x001E856F File Offset: 0x001E676F
		public virtual void SetShowLines(bool _arg)
		{
			vtkFrustumSource.vtkFrustumSource_SetShowLines_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060159AA RID: 88490
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFrustumSource_ShowLinesOff_17(HandleRef pThis);

		/// <summary>
		/// Tells if some extra lines will be generated. Initial value is true.
		/// </summary>
		// Token: 0x060159AB RID: 88491 RVA: 0x001E8587 File Offset: 0x001E6787
		public virtual void ShowLinesOff()
		{
			vtkFrustumSource.vtkFrustumSource_ShowLinesOff_17(base.GetCppThis());
		}

		// Token: 0x060159AC RID: 88492
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFrustumSource_ShowLinesOn_18(HandleRef pThis);

		/// <summary>
		/// Tells if some extra lines will be generated. Initial value is true.
		/// </summary>
		// Token: 0x060159AD RID: 88493 RVA: 0x001E8596 File Offset: 0x001E6796
		public virtual void ShowLinesOn()
		{
			vtkFrustumSource.vtkFrustumSource_ShowLinesOn_18(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400189E RID: 6302
		public new const string MRFullTypeName = "Kitware.VTK.vtkFrustumSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400189F RID: 6303
		public new static readonly string MRClassNameKey = "class vtkFrustumSource";
	}
}
