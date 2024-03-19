using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDiscreteFlyingEdges2D
	/// </summary>
	/// <remarks>
	///    generate isoline(s) from 2D image data
	///
	/// vtkDiscreteFlyingEdges2D creates output representations of label maps
	/// (e.g., segmented images) using a variation of the flying edges
	/// algorithm. The input is a 2D image where each point is labeled (integer
	/// labels are preferred to real values), and the output data is polygonal
	/// data representing labeled regions. (Note that on output each region
	/// [corresponding to a different contour value] is represented independently;
	/// i.e., points are not shared between regions even if they are coincident.)
	///
	/// @warning
	/// This filter is specialized to 2D images. This implementation can produce
	/// degenerate line segments (i.e., zero-length line segments).
	///
	/// @warning
	/// Use vtkContourLoopExtraction if you wish to create polygons from the line
	/// segments.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDiscreteMarchingCubes vtkContourLoopExtraction
	/// </seealso>
	// Token: 0x02000894 RID: 2196
	public class vtkDiscreteFlyingEdges2D : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016CC1 RID: 93377 RVA: 0x00200DF0 File Offset: 0x001FEFF0
		static vtkDiscreteFlyingEdges2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDiscreteFlyingEdges2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDiscreteFlyingEdges2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016CC2 RID: 93378 RVA: 0x00200E18 File Offset: 0x001FF018
		public vtkDiscreteFlyingEdges2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016CC3 RID: 93379
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiscreteFlyingEdges2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06016CC4 RID: 93380 RVA: 0x00200E28 File Offset: 0x001FF028
		public new static vtkDiscreteFlyingEdges2D New()
		{
			vtkDiscreteFlyingEdges2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiscreteFlyingEdges2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06016CC5 RID: 93381 RVA: 0x00200E7C File Offset: 0x001FF07C
		public vtkDiscreteFlyingEdges2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016CC6 RID: 93382 RVA: 0x00200EC0 File Offset: 0x001FF0C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016CC7 RID: 93383
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges2D_ComputeScalarsOff_01(HandleRef pThis);

		/// <summary>
		/// Option to set the point scalars of the output.  The scalars will be the
		/// label values.  By default this flag is on.
		/// </summary>
		// Token: 0x06016CC8 RID: 93384 RVA: 0x00200ECB File Offset: 0x001FF0CB
		public virtual void ComputeScalarsOff()
		{
			vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_ComputeScalarsOff_01(base.GetCppThis());
		}

		// Token: 0x06016CC9 RID: 93385
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges2D_ComputeScalarsOn_02(HandleRef pThis);

		/// <summary>
		/// Option to set the point scalars of the output.  The scalars will be the
		/// label values.  By default this flag is on.
		/// </summary>
		// Token: 0x06016CCA RID: 93386 RVA: 0x00200EDA File Offset: 0x001FF0DA
		public virtual void ComputeScalarsOn()
		{
			vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_ComputeScalarsOn_02(base.GetCppThis());
		}

		// Token: 0x06016CCB RID: 93387
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges2D_GenerateValues_03(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x06016CCC RID: 93388 RVA: 0x00200EE9 File Offset: 0x001FF0E9
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_GenerateValues_03(base.GetCppThis(), numContours, range);
		}

		// Token: 0x06016CCD RID: 93389
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges2D_GenerateValues_04(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x06016CCE RID: 93390 RVA: 0x00200EFA File Offset: 0x001FF0FA
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_GenerateValues_04(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x06016CCF RID: 93391
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscreteFlyingEdges2D_GetArrayComponent_05(HandleRef pThis);

		/// <summary>
		/// Set/get which component of the scalar array to contour on; defaults to 0.
		/// </summary>
		// Token: 0x06016CD0 RID: 93392 RVA: 0x00200F0C File Offset: 0x001FF10C
		public virtual int GetArrayComponent()
		{
			return vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_GetArrayComponent_05(base.GetCppThis());
		}

		// Token: 0x06016CD1 RID: 93393
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscreteFlyingEdges2D_GetComputeScalars_06(HandleRef pThis);

		/// <summary>
		/// Option to set the point scalars of the output.  The scalars will be the
		/// label values.  By default this flag is on.
		/// </summary>
		// Token: 0x06016CD2 RID: 93394 RVA: 0x00200F2C File Offset: 0x001FF12C
		public virtual int GetComputeScalars()
		{
			return vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_GetComputeScalars_06(base.GetCppThis());
		}

		// Token: 0x06016CD3 RID: 93395
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDiscreteFlyingEdges2D_GetMTime_07(HandleRef pThis);

		/// <summary>
		/// Because we delegate to vtkContourValues.
		/// </summary>
		// Token: 0x06016CD4 RID: 93396 RVA: 0x00200F4C File Offset: 0x001FF14C
		public override ulong GetMTime()
		{
			return vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_GetMTime_07(base.GetCppThis());
		}

		// Token: 0x06016CD5 RID: 93397
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDiscreteFlyingEdges2D_GetNumberOfContours_08(HandleRef pThis);

		/// <summary>
		/// Get the number of contours in the list of contour values.
		/// </summary>
		// Token: 0x06016CD6 RID: 93398 RVA: 0x00200F6C File Offset: 0x001FF16C
		public long GetNumberOfContours()
		{
			return vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_GetNumberOfContours_08(base.GetCppThis());
		}

		// Token: 0x06016CD7 RID: 93399
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDiscreteFlyingEdges2D_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06016CD8 RID: 93400 RVA: 0x00200F8C File Offset: 0x001FF18C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06016CD9 RID: 93401
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDiscreteFlyingEdges2D_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06016CDA RID: 93402 RVA: 0x00200FAC File Offset: 0x001FF1AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06016CDB RID: 93403
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDiscreteFlyingEdges2D_GetValue_11(HandleRef pThis, int i);

		/// <summary>
		/// Get the ith contour value.
		/// </summary>
		// Token: 0x06016CDC RID: 93404 RVA: 0x00200FC8 File Offset: 0x001FF1C8
		public double GetValue(int i)
		{
			return vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_GetValue_11(base.GetCppThis(), i);
		}

		// Token: 0x06016CDD RID: 93405
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiscreteFlyingEdges2D_GetValues_12(HandleRef pThis);

		/// <summary>
		/// Get a pointer to an array of contour values. There will be
		/// GetNumberOfContours() values in the list.
		/// </summary>
		// Token: 0x06016CDE RID: 93406 RVA: 0x00200FE8 File Offset: 0x001FF1E8
		public IntPtr GetValues()
		{
			return vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_GetValues_12(base.GetCppThis());
		}

		// Token: 0x06016CDF RID: 93407
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges2D_GetValues_13(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Fill a supplied list with contour values. There will be
		/// GetNumberOfContours() values in the list. Make sure you allocate
		/// enough memory to hold the list.
		/// </summary>
		// Token: 0x06016CE0 RID: 93408 RVA: 0x00201007 File Offset: 0x001FF207
		public void GetValues(IntPtr contourValues)
		{
			vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_GetValues_13(base.GetCppThis(), contourValues);
		}

		// Token: 0x06016CE1 RID: 93409
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscreteFlyingEdges2D_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06016CE2 RID: 93410 RVA: 0x00201018 File Offset: 0x001FF218
		public override int IsA(string type)
		{
			return vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06016CE3 RID: 93411
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscreteFlyingEdges2D_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06016CE4 RID: 93412 RVA: 0x00201038 File Offset: 0x001FF238
		public new static int IsTypeOf(string type)
		{
			return vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_IsTypeOf_15(type);
		}

		// Token: 0x06016CE5 RID: 93413
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiscreteFlyingEdges2D_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06016CE6 RID: 93414 RVA: 0x00201054 File Offset: 0x001FF254
		public new vtkDiscreteFlyingEdges2D NewInstance()
		{
			vtkDiscreteFlyingEdges2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiscreteFlyingEdges2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016CE7 RID: 93415
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiscreteFlyingEdges2D_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06016CE8 RID: 93416 RVA: 0x002010B0 File Offset: 0x001FF2B0
		public new static vtkDiscreteFlyingEdges2D SafeDownCast(vtkObjectBase o)
		{
			vtkDiscreteFlyingEdges2D vtkDiscreteFlyingEdges2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDiscreteFlyingEdges2D = (vtkDiscreteFlyingEdges2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDiscreteFlyingEdges2D.Register(null);
				}
			}
			return vtkDiscreteFlyingEdges2D;
		}

		// Token: 0x06016CE9 RID: 93417
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges2D_SetArrayComponent_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get which component of the scalar array to contour on; defaults to 0.
		/// </summary>
		// Token: 0x06016CEA RID: 93418 RVA: 0x0020112F File Offset: 0x001FF32F
		public virtual void SetArrayComponent(int _arg)
		{
			vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_SetArrayComponent_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06016CEB RID: 93419
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges2D_SetComputeScalars_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Option to set the point scalars of the output.  The scalars will be the
		/// label values.  By default this flag is on.
		/// </summary>
		// Token: 0x06016CEC RID: 93420 RVA: 0x0020113F File Offset: 0x001FF33F
		public virtual void SetComputeScalars(int _arg)
		{
			vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_SetComputeScalars_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06016CED RID: 93421
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges2D_SetNumberOfContours_21(HandleRef pThis, int number);

		/// <summary>
		/// Set the number of contours to place into the list. You only really
		/// need to use this method to reduce list size. The method SetValue()
		/// will automatically increase list size as needed.
		/// </summary>
		// Token: 0x06016CEE RID: 93422 RVA: 0x0020114F File Offset: 0x001FF34F
		public void SetNumberOfContours(int number)
		{
			vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_SetNumberOfContours_21(base.GetCppThis(), number);
		}

		// Token: 0x06016CEF RID: 93423
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges2D_SetValue_22(HandleRef pThis, int i, double value);

		/// <summary>
		/// Set a particular contour value at contour number i. The index i ranges
		/// between 0&lt;=i&lt;NumberOfContours.
		/// </summary>
		// Token: 0x06016CF0 RID: 93424 RVA: 0x0020115F File Offset: 0x001FF35F
		public void SetValue(int i, double value)
		{
			vtkDiscreteFlyingEdges2D.vtkDiscreteFlyingEdges2D_SetValue_22(base.GetCppThis(), i, value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001989 RID: 6537
		public new const string MRFullTypeName = "Kitware.VTK.vtkDiscreteFlyingEdges2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400198A RID: 6538
		public new static readonly string MRClassNameKey = "class vtkDiscreteFlyingEdges2D";
	}
}
