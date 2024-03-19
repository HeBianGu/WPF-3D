using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericCutter
	/// </summary>
	/// <remarks>
	///    cut a vtkGenericDataSet with an implicit function or scalar data
	///
	/// vtkGenericCutter is a filter to cut through data using any subclass of
	/// vtkImplicitFunction. That is, a polygonal surface is created
	/// corresponding to the implicit function F(x,y,z) = value(s), where
	/// you can specify one or more values used to cut with.
	///
	/// In VTK, cutting means reducing a cell of dimension N to a cut surface
	/// of dimension N-1. For example, a tetrahedron when cut by a plane (i.e.,
	/// vtkPlane implicit function) will generate triangles. (In comparison,
	/// clipping takes a N dimensional cell and creates N dimension primitives.)
	///
	/// vtkGenericCutter is generally used to "slice-through" a dataset, generating
	/// a surface that can be visualized. It is also possible to use
	/// vtkGenericCutter to do a form of volume rendering. vtkGenericCutter does
	/// this by generating multiple cut surfaces (usually planes) which are ordered
	/// (and rendered) from back-to-front. The surfaces are set translucent to give
	/// a volumetric rendering effect.
	///
	/// This filter has been implemented to operate on generic datasets, rather
	/// than the typical vtkDataSet (and subclasses). vtkGenericDataSet is a more
	/// complex cousin of vtkDataSet, typically consisting of nonlinear,
	/// higher-order cells. To process this type of data, generic cells are
	/// automatically tessellated into linear cells prior to isocontouring.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCutter vtkImplicitFunction vtkClipPolyData vtkGenericDataSet
	/// </seealso>
	// Token: 0x0200049A RID: 1178
	public class vtkGenericCutter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D8D8 RID: 55512 RVA: 0x0012D4C0 File Offset: 0x0012B6C0
		static vtkGenericCutter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericCutter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericCutter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D8D9 RID: 55513 RVA: 0x0012D4E8 File Offset: 0x0012B6E8
		public vtkGenericCutter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D8DA RID: 55514
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCutter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with user-specified implicit function; initial value of 0.0; and
		/// generating cut scalars turned off.
		/// </summary>
		// Token: 0x0600D8DB RID: 55515 RVA: 0x0012D4F8 File Offset: 0x0012B6F8
		public new static vtkGenericCutter New()
		{
			vtkGenericCutter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericCutter.vtkGenericCutter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with user-specified implicit function; initial value of 0.0; and
		/// generating cut scalars turned off.
		/// </summary>
		// Token: 0x0600D8DC RID: 55516 RVA: 0x0012D54C File Offset: 0x0012B74C
		public vtkGenericCutter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenericCutter.vtkGenericCutter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D8DD RID: 55517 RVA: 0x0012D590 File Offset: 0x0012B790
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D8DE RID: 55518
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCutter_CreateDefaultLocator_01(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is specified. The
		/// locator is used to merge coincident points.
		/// </summary>
		// Token: 0x0600D8DF RID: 55519 RVA: 0x0012D59B File Offset: 0x0012B79B
		public void CreateDefaultLocator()
		{
			vtkGenericCutter.vtkGenericCutter_CreateDefaultLocator_01(base.GetCppThis());
		}

		// Token: 0x0600D8E0 RID: 55520
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCutter_GenerateCutScalarsOff_02(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the input scalar
		/// data.
		/// </summary>
		// Token: 0x0600D8E1 RID: 55521 RVA: 0x0012D5AA File Offset: 0x0012B7AA
		public virtual void GenerateCutScalarsOff()
		{
			vtkGenericCutter.vtkGenericCutter_GenerateCutScalarsOff_02(base.GetCppThis());
		}

		// Token: 0x0600D8E2 RID: 55522
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCutter_GenerateCutScalarsOn_03(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the input scalar
		/// data.
		/// </summary>
		// Token: 0x0600D8E3 RID: 55523 RVA: 0x0012D5B9 File Offset: 0x0012B7B9
		public virtual void GenerateCutScalarsOn()
		{
			vtkGenericCutter.vtkGenericCutter_GenerateCutScalarsOn_03(base.GetCppThis());
		}

		// Token: 0x0600D8E4 RID: 55524
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCutter_GenerateValues_04(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x0600D8E5 RID: 55525 RVA: 0x0012D5C8 File Offset: 0x0012B7C8
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkGenericCutter.vtkGenericCutter_GenerateValues_04(base.GetCppThis(), numContours, range);
		}

		// Token: 0x0600D8E6 RID: 55526
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCutter_GenerateValues_05(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x0600D8E7 RID: 55527 RVA: 0x0012D5D9 File Offset: 0x0012B7D9
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkGenericCutter.vtkGenericCutter_GenerateValues_05(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x0600D8E8 RID: 55528
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCutter_GetCutFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the implicit function to perform the cutting.
		/// </summary>
		// Token: 0x0600D8E9 RID: 55529 RVA: 0x0012D5EC File Offset: 0x0012B7EC
		public virtual vtkImplicitFunction GetCutFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericCutter.vtkGenericCutter_GetCutFunction_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		// Token: 0x0600D8EA RID: 55530
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCutter_GetGenerateCutScalars_07(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the input scalar
		/// data.
		/// </summary>
		// Token: 0x0600D8EB RID: 55531 RVA: 0x0012D65C File Offset: 0x0012B85C
		public virtual int GetGenerateCutScalars()
		{
			return vtkGenericCutter.vtkGenericCutter_GetGenerateCutScalars_07(base.GetCppThis());
		}

		// Token: 0x0600D8EC RID: 55532
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCutter_GetLocator_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a spatial locator for merging points. By default,
		/// an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0600D8ED RID: 55533 RVA: 0x0012D67C File Offset: 0x0012B87C
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericCutter.vtkGenericCutter_GetLocator_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		// Token: 0x0600D8EE RID: 55534
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkGenericCutter_GetMTime_09(HandleRef pThis);

		/// <summary>
		/// Override GetMTime because we delegate to vtkContourValues and refer to
		/// vtkImplicitFunction.
		/// </summary>
		// Token: 0x0600D8EF RID: 55535 RVA: 0x0012D6EC File Offset: 0x0012B8EC
		public override ulong GetMTime()
		{
			return vtkGenericCutter.vtkGenericCutter_GetMTime_09(base.GetCppThis());
		}

		// Token: 0x0600D8F0 RID: 55536
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericCutter_GetNumberOfContours_10(HandleRef pThis);

		/// <summary>
		/// Get the number of contours in the list of contour values.
		/// </summary>
		// Token: 0x0600D8F1 RID: 55537 RVA: 0x0012D70C File Offset: 0x0012B90C
		public long GetNumberOfContours()
		{
			return vtkGenericCutter.vtkGenericCutter_GetNumberOfContours_10(base.GetCppThis());
		}

		// Token: 0x0600D8F2 RID: 55538
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericCutter_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D8F3 RID: 55539 RVA: 0x0012D72C File Offset: 0x0012B92C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericCutter.vtkGenericCutter_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0600D8F4 RID: 55540
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericCutter_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D8F5 RID: 55541 RVA: 0x0012D74C File Offset: 0x0012B94C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericCutter.vtkGenericCutter_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0600D8F6 RID: 55542
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGenericCutter_GetValue_13(HandleRef pThis, int i);

		/// <summary>
		/// Get the ith contour value.
		/// </summary>
		// Token: 0x0600D8F7 RID: 55543 RVA: 0x0012D768 File Offset: 0x0012B968
		public double GetValue(int i)
		{
			return vtkGenericCutter.vtkGenericCutter_GetValue_13(base.GetCppThis(), i);
		}

		// Token: 0x0600D8F8 RID: 55544
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCutter_GetValues_14(HandleRef pThis);

		/// <summary>
		/// Get a pointer to an array of contour values. There will be
		/// GetNumberOfContours() values in the list.
		/// </summary>
		// Token: 0x0600D8F9 RID: 55545 RVA: 0x0012D788 File Offset: 0x0012B988
		public IntPtr GetValues()
		{
			return vtkGenericCutter.vtkGenericCutter_GetValues_14(base.GetCppThis());
		}

		// Token: 0x0600D8FA RID: 55546
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCutter_GetValues_15(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Fill a supplied list with contour values. There will be
		/// GetNumberOfContours() values in the list. Make sure you allocate
		/// enough memory to hold the list.
		/// </summary>
		// Token: 0x0600D8FB RID: 55547 RVA: 0x0012D7A7 File Offset: 0x0012B9A7
		public void GetValues(IntPtr contourValues)
		{
			vtkGenericCutter.vtkGenericCutter_GetValues_15(base.GetCppThis(), contourValues);
		}

		// Token: 0x0600D8FC RID: 55548
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCutter_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D8FD RID: 55549 RVA: 0x0012D7B8 File Offset: 0x0012B9B8
		public override int IsA(string type)
		{
			return vtkGenericCutter.vtkGenericCutter_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0600D8FE RID: 55550
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCutter_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D8FF RID: 55551 RVA: 0x0012D7D8 File Offset: 0x0012B9D8
		public new static int IsTypeOf(string type)
		{
			return vtkGenericCutter.vtkGenericCutter_IsTypeOf_17(type);
		}

		// Token: 0x0600D900 RID: 55552
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCutter_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D901 RID: 55553 RVA: 0x0012D7F4 File Offset: 0x0012B9F4
		public new vtkGenericCutter NewInstance()
		{
			vtkGenericCutter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericCutter.vtkGenericCutter_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D902 RID: 55554
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCutter_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D903 RID: 55555 RVA: 0x0012D850 File Offset: 0x0012BA50
		public new static vtkGenericCutter SafeDownCast(vtkObjectBase o)
		{
			vtkGenericCutter vtkGenericCutter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericCutter.vtkGenericCutter_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericCutter = (vtkGenericCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericCutter.Register(null);
				}
			}
			return vtkGenericCutter;
		}

		// Token: 0x0600D904 RID: 55556
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCutter_SetCutFunction_21(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the implicit function to perform the cutting.
		/// </summary>
		// Token: 0x0600D905 RID: 55557 RVA: 0x0012D8D0 File Offset: 0x0012BAD0
		public virtual void SetCutFunction(vtkImplicitFunction arg0)
		{
			vtkGenericCutter.vtkGenericCutter_SetCutFunction_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600D906 RID: 55558
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCutter_SetGenerateCutScalars_22(HandleRef pThis, int _arg);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the input scalar
		/// data.
		/// </summary>
		// Token: 0x0600D907 RID: 55559 RVA: 0x0012D8FF File Offset: 0x0012BAFF
		public virtual void SetGenerateCutScalars(int _arg)
		{
			vtkGenericCutter.vtkGenericCutter_SetGenerateCutScalars_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D908 RID: 55560
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCutter_SetLocator_23(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a spatial locator for merging points. By default,
		/// an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0600D909 RID: 55561 RVA: 0x0012D910 File Offset: 0x0012BB10
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkGenericCutter.vtkGenericCutter_SetLocator_23(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600D90A RID: 55562
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCutter_SetNumberOfContours_24(HandleRef pThis, int number);

		/// <summary>
		/// Set the number of contours to place into the list. You only really
		/// need to use this method to reduce list size. The method SetValue()
		/// will automatically increase list size as needed.
		/// </summary>
		// Token: 0x0600D90B RID: 55563 RVA: 0x0012D93F File Offset: 0x0012BB3F
		public void SetNumberOfContours(int number)
		{
			vtkGenericCutter.vtkGenericCutter_SetNumberOfContours_24(base.GetCppThis(), number);
		}

		// Token: 0x0600D90C RID: 55564
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCutter_SetValue_25(HandleRef pThis, int i, double value);

		/// <summary>
		/// Set a particular contour value at contour number i. The index i ranges
		/// between 0&lt;=i&lt;NumberOfContours.
		/// </summary>
		// Token: 0x0600D90D RID: 55565 RVA: 0x0012D94F File Offset: 0x0012BB4F
		public void SetValue(int i, double value)
		{
			vtkGenericCutter.vtkGenericCutter_SetValue_25(base.GetCppThis(), i, value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FDC RID: 4060
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericCutter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FDD RID: 4061
		public new static readonly string MRClassNameKey = "class vtkGenericCutter";
	}
}
