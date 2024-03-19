using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDiscreteFlyingEdgesClipper2D
	/// </summary>
	/// <remarks>
	///    generate filled regions from segmented 2D image data
	///
	/// vtkDiscreteFlyingEdgesClipper2D creates filled polygons from a label map
	/// (e.g., segmented image) using a variation of the flying edges algorithm
	/// adapted for 2D clipping. The input is a 2D image where each pixel is
	/// labeled (integer labels are preferred to real values), and the output data
	/// is polygonal data representing labeled regions. (Note that on output each
	/// region [corresponding to a different contour value] may share points on a
	/// shared boundary.)
	///
	/// While this filter is similar to a contouring operation, label maps do not
	/// provide continuous function values meaning that usual interpolation along
	/// edges is not possible. Instead, when the edge endpoints are labeled in
	/// differing regions, the edge is split at its midpoint. In addition, besides
	/// producing intersection points at the mid-point of edges, the filter may
	/// also generate points interior to the pixel cells. For example, if the four
	/// vertices of a pixel cell are labeled with different regions, then an
	/// interior point is created and four rectangular "regions" are produced.
	///
	/// Note that one nice feature of this filter is that algorithm execution
	/// occurs only one time no matter the number of contour values. In many
	/// contouring-like algorithms, each separate contour value requires an
	/// additional algorithm execution with a new contour value. So in this filter
	/// large numbers of contour values do not significantly affect overall speed.
	///
	/// @warning This filter is specialized to 2D images.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSurfaceNets2D vtkDiscreteFlyingEdges2D vtkDiscreteMarchingCubes
	/// vtkContourLoopExtraction vtkFlyingEdges2D vtkFlyingEdges3D
	/// </seealso>
	// Token: 0x02000896 RID: 2198
	public class vtkDiscreteFlyingEdgesClipper2D : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016D39 RID: 93497 RVA: 0x002015DC File Offset: 0x001FF7DC
		static vtkDiscreteFlyingEdgesClipper2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDiscreteFlyingEdgesClipper2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDiscreteFlyingEdgesClipper2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016D3A RID: 93498 RVA: 0x00201604 File Offset: 0x001FF804
		public vtkDiscreteFlyingEdgesClipper2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016D3B RID: 93499
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiscreteFlyingEdgesClipper2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06016D3C RID: 93500 RVA: 0x00201614 File Offset: 0x001FF814
		public new static vtkDiscreteFlyingEdgesClipper2D New()
		{
			vtkDiscreteFlyingEdgesClipper2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiscreteFlyingEdgesClipper2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06016D3D RID: 93501 RVA: 0x00201668 File Offset: 0x001FF868
		public vtkDiscreteFlyingEdgesClipper2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016D3E RID: 93502 RVA: 0x002016AC File Offset: 0x001FF8AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016D3F RID: 93503
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdgesClipper2D_ComputeScalarsOff_01(HandleRef pThis);

		/// <summary>
		/// Option to set the cell scalars of the output. The scalars will be the
		/// contour values. By default this flag is on.
		/// </summary>
		// Token: 0x06016D40 RID: 93504 RVA: 0x002016B7 File Offset: 0x001FF8B7
		public virtual void ComputeScalarsOff()
		{
			vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_ComputeScalarsOff_01(base.GetCppThis());
		}

		// Token: 0x06016D41 RID: 93505
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdgesClipper2D_ComputeScalarsOn_02(HandleRef pThis);

		/// <summary>
		/// Option to set the cell scalars of the output. The scalars will be the
		/// contour values. By default this flag is on.
		/// </summary>
		// Token: 0x06016D42 RID: 93506 RVA: 0x002016C6 File Offset: 0x001FF8C6
		public virtual void ComputeScalarsOn()
		{
			vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_ComputeScalarsOn_02(base.GetCppThis());
		}

		// Token: 0x06016D43 RID: 93507
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdgesClipper2D_GenerateValues_03(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Generate numContours equally spaced contour values between the specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x06016D44 RID: 93508 RVA: 0x002016D5 File Offset: 0x001FF8D5
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_GenerateValues_03(base.GetCppThis(), numContours, range);
		}

		// Token: 0x06016D45 RID: 93509
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdgesClipper2D_GenerateValues_04(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Generate numContours equally spaced contour values between the specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x06016D46 RID: 93510 RVA: 0x002016E6 File Offset: 0x001FF8E6
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_GenerateValues_04(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x06016D47 RID: 93511
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscreteFlyingEdgesClipper2D_GetArrayComponent_05(HandleRef pThis);

		/// <summary>
		/// Set/get which component of a multi-component scalar array to contour on;
		/// defaults to 0.
		/// </summary>
		// Token: 0x06016D48 RID: 93512 RVA: 0x002016F8 File Offset: 0x001FF8F8
		public virtual int GetArrayComponent()
		{
			return vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_GetArrayComponent_05(base.GetCppThis());
		}

		// Token: 0x06016D49 RID: 93513
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscreteFlyingEdgesClipper2D_GetComputeScalars_06(HandleRef pThis);

		/// <summary>
		/// Option to set the cell scalars of the output. The scalars will be the
		/// contour values. By default this flag is on.
		/// </summary>
		// Token: 0x06016D4A RID: 93514 RVA: 0x00201718 File Offset: 0x001FF918
		public virtual int GetComputeScalars()
		{
			return vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_GetComputeScalars_06(base.GetCppThis());
		}

		// Token: 0x06016D4B RID: 93515
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDiscreteFlyingEdgesClipper2D_GetMTime_07(HandleRef pThis);

		/// <summary>
		/// The modified time is a function of the contour values because we delegate to
		/// vtkContourValues.
		/// </summary>
		// Token: 0x06016D4C RID: 93516 RVA: 0x00201738 File Offset: 0x001FF938
		public override ulong GetMTime()
		{
			return vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_GetMTime_07(base.GetCppThis());
		}

		// Token: 0x06016D4D RID: 93517
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDiscreteFlyingEdgesClipper2D_GetNumberOfContours_08(HandleRef pThis);

		/// <summary>
		/// Get the number of contours in the list of contour values.
		/// </summary>
		// Token: 0x06016D4E RID: 93518 RVA: 0x00201758 File Offset: 0x001FF958
		public long GetNumberOfContours()
		{
			return vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_GetNumberOfContours_08(base.GetCppThis());
		}

		// Token: 0x06016D4F RID: 93519
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDiscreteFlyingEdgesClipper2D_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06016D50 RID: 93520 RVA: 0x00201778 File Offset: 0x001FF978
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06016D51 RID: 93521
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDiscreteFlyingEdgesClipper2D_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06016D52 RID: 93522 RVA: 0x00201798 File Offset: 0x001FF998
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06016D53 RID: 93523
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDiscreteFlyingEdgesClipper2D_GetValue_11(HandleRef pThis, int i);

		/// <summary>
		/// Get the ith contour value.
		/// </summary>
		// Token: 0x06016D54 RID: 93524 RVA: 0x002017B4 File Offset: 0x001FF9B4
		public double GetValue(int i)
		{
			return vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_GetValue_11(base.GetCppThis(), i);
		}

		// Token: 0x06016D55 RID: 93525
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiscreteFlyingEdgesClipper2D_GetValues_12(HandleRef pThis);

		/// <summary>
		/// Get a pointer to an array of contour values. There will be
		/// GetNumberOfContours() values in the list.
		/// </summary>
		// Token: 0x06016D56 RID: 93526 RVA: 0x002017D4 File Offset: 0x001FF9D4
		public IntPtr GetValues()
		{
			return vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_GetValues_12(base.GetCppThis());
		}

		// Token: 0x06016D57 RID: 93527
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdgesClipper2D_GetValues_13(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Fill a supplied list with contour values. There will be
		/// GetNumberOfContours() values in the list. Make sure you allocate
		/// enough memory to hold the list.
		/// </summary>
		// Token: 0x06016D58 RID: 93528 RVA: 0x002017F3 File Offset: 0x001FF9F3
		public void GetValues(IntPtr contourValues)
		{
			vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_GetValues_13(base.GetCppThis(), contourValues);
		}

		// Token: 0x06016D59 RID: 93529
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscreteFlyingEdgesClipper2D_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06016D5A RID: 93530 RVA: 0x00201804 File Offset: 0x001FFA04
		public override int IsA(string type)
		{
			return vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06016D5B RID: 93531
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscreteFlyingEdgesClipper2D_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06016D5C RID: 93532 RVA: 0x00201824 File Offset: 0x001FFA24
		public new static int IsTypeOf(string type)
		{
			return vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_IsTypeOf_15(type);
		}

		// Token: 0x06016D5D RID: 93533
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiscreteFlyingEdgesClipper2D_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06016D5E RID: 93534 RVA: 0x00201840 File Offset: 0x001FFA40
		public new vtkDiscreteFlyingEdgesClipper2D NewInstance()
		{
			vtkDiscreteFlyingEdgesClipper2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiscreteFlyingEdgesClipper2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016D5F RID: 93535
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiscreteFlyingEdgesClipper2D_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06016D60 RID: 93536 RVA: 0x0020189C File Offset: 0x001FFA9C
		public new static vtkDiscreteFlyingEdgesClipper2D SafeDownCast(vtkObjectBase o)
		{
			vtkDiscreteFlyingEdgesClipper2D vtkDiscreteFlyingEdgesClipper2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDiscreteFlyingEdgesClipper2D = (vtkDiscreteFlyingEdgesClipper2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDiscreteFlyingEdgesClipper2D.Register(null);
				}
			}
			return vtkDiscreteFlyingEdgesClipper2D;
		}

		// Token: 0x06016D61 RID: 93537
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdgesClipper2D_SetArrayComponent_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get which component of a multi-component scalar array to contour on;
		/// defaults to 0.
		/// </summary>
		// Token: 0x06016D62 RID: 93538 RVA: 0x0020191B File Offset: 0x001FFB1B
		public virtual void SetArrayComponent(int _arg)
		{
			vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_SetArrayComponent_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06016D63 RID: 93539
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdgesClipper2D_SetComputeScalars_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Option to set the cell scalars of the output. The scalars will be the
		/// contour values. By default this flag is on.
		/// </summary>
		// Token: 0x06016D64 RID: 93540 RVA: 0x0020192B File Offset: 0x001FFB2B
		public virtual void SetComputeScalars(int _arg)
		{
			vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_SetComputeScalars_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06016D65 RID: 93541
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdgesClipper2D_SetNumberOfContours_21(HandleRef pThis, int number);

		/// <summary>
		/// Set the number of contours to place into the list. You only really
		/// need to use this method to reduce list size. The method SetValue()
		/// will automatically increase list size as needed.
		/// </summary>
		// Token: 0x06016D66 RID: 93542 RVA: 0x0020193B File Offset: 0x001FFB3B
		public void SetNumberOfContours(int number)
		{
			vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_SetNumberOfContours_21(base.GetCppThis(), number);
		}

		// Token: 0x06016D67 RID: 93543
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdgesClipper2D_SetValue_22(HandleRef pThis, int i, double value);

		/// <summary>
		/// Set a particular contour value at contour number i. The index i ranges
		/// between 0 &lt;= i &lt;NumberOfContours. (Note: while contour values are
		/// expressed as doubles, the underlying scalar data may be a different
		/// type. During execution the contour values are static cast to the type of
		/// the scalar values.)
		/// </summary>
		// Token: 0x06016D68 RID: 93544 RVA: 0x0020194B File Offset: 0x001FFB4B
		public void SetValue(int i, double value)
		{
			vtkDiscreteFlyingEdgesClipper2D.vtkDiscreteFlyingEdgesClipper2D_SetValue_22(base.GetCppThis(), i, value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400198D RID: 6541
		public new const string MRFullTypeName = "Kitware.VTK.vtkDiscreteFlyingEdgesClipper2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400198E RID: 6542
		public new static readonly string MRClassNameKey = "class vtkDiscreteFlyingEdgesClipper2D";
	}
}
