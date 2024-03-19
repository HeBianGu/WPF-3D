using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFlyingEdges2D
	/// </summary>
	/// <remarks>
	///    generate isoline(s) from a structured points (image) dataset
	///
	/// vtkFlyingEdges2D is a reference implementation of the 2D version of the
	/// flying edges algorithm. It is designed to be highly scalable (i.e.,
	/// parallelizable) for large data. It implements certain performance
	/// optimizations including computational trimming to rapidly eliminate
	/// processing of data regions, packed bit representation of case table
	/// values, single edge intersection, elimination of point merging, and
	/// elimination of any reallocs (due to dynamic data insertion). Note that
	/// computational trimming is a method to reduce total computational cost in
	/// which partial computational results can be used to eliminate future
	/// computations.
	///
	/// This is a four-pass algorithm. The first pass processes all x-edges and
	/// builds x-edge case values (which, when the two x-edges defining a pixel
	/// are combined, are equivalent to vertex-based case table except edge-based
	/// approaches are separable to parallel computing). Next x-pixel rows are
	/// processed to gather information from y-edges (basically to count the
	/// number of edge intersections and lines generated). In the third pass a
	/// prefix sum is used to count and allocate memory for the output
	/// primitives. Finally in the fourth pass output primitives are generated into
	/// pre-allocated arrays. This implementation uses pixel cell axes (a x-y dyad
	/// located at the pixel origin) to ensure that each edge is intersected at
	/// most one time.
	///
	/// See the paper "Flying Edges: A High-Performance Scalable Isocontouring
	/// Algorithm" by Schroeder, Maynard, Geveci. Proc. of LDAV 2015. Chicago, IL.
	///
	/// @warning
	/// This filter is specialized to 2D images. This implementation can produce
	/// degenerate line segments (i.e., zero-length line segments).
	///
	/// @warning
	/// If you are interested in extracting segmented regions from a label mask,
	/// consider using vtkDiscreteFlyingEdges2D.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFlyingEdges3D vtkContourFilter vtkSynchronizedTemplates2D
	/// vtkMarchingSquares vtkDiscreteFlyingEdges2D
	/// </seealso>
	// Token: 0x02000969 RID: 2409
	public class vtkFlyingEdges2D : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601914E RID: 102734 RVA: 0x0022F8EF File Offset: 0x0022DAEF
		static vtkFlyingEdges2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFlyingEdges2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFlyingEdges2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601914F RID: 102735 RVA: 0x0022F917 File Offset: 0x0022DB17
		public vtkFlyingEdges2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019150 RID: 102736
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFlyingEdges2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019151 RID: 102737 RVA: 0x0022F928 File Offset: 0x0022DB28
		public new static vtkFlyingEdges2D New()
		{
			vtkFlyingEdges2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFlyingEdges2D.vtkFlyingEdges2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFlyingEdges2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019152 RID: 102738 RVA: 0x0022F97C File Offset: 0x0022DB7C
		public vtkFlyingEdges2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFlyingEdges2D.vtkFlyingEdges2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019153 RID: 102739 RVA: 0x0022F9C0 File Offset: 0x0022DBC0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019154 RID: 102740
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges2D_ComputeScalarsOff_01(HandleRef pThis);

		/// <summary>
		/// Option to set the point scalars of the output.  The scalars will be the
		/// iso value of course.  By default this flag is on.
		/// </summary>
		// Token: 0x06019155 RID: 102741 RVA: 0x0022F9CB File Offset: 0x0022DBCB
		public virtual void ComputeScalarsOff()
		{
			vtkFlyingEdges2D.vtkFlyingEdges2D_ComputeScalarsOff_01(base.GetCppThis());
		}

		// Token: 0x06019156 RID: 102742
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges2D_ComputeScalarsOn_02(HandleRef pThis);

		/// <summary>
		/// Option to set the point scalars of the output.  The scalars will be the
		/// iso value of course.  By default this flag is on.
		/// </summary>
		// Token: 0x06019157 RID: 102743 RVA: 0x0022F9DA File Offset: 0x0022DBDA
		public virtual void ComputeScalarsOn()
		{
			vtkFlyingEdges2D.vtkFlyingEdges2D_ComputeScalarsOn_02(base.GetCppThis());
		}

		// Token: 0x06019158 RID: 102744
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges2D_GenerateValues_03(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x06019159 RID: 102745 RVA: 0x0022F9E9 File Offset: 0x0022DBE9
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkFlyingEdges2D.vtkFlyingEdges2D_GenerateValues_03(base.GetCppThis(), numContours, range);
		}

		// Token: 0x0601915A RID: 102746
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges2D_GenerateValues_04(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x0601915B RID: 102747 RVA: 0x0022F9FA File Offset: 0x0022DBFA
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkFlyingEdges2D.vtkFlyingEdges2D_GenerateValues_04(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x0601915C RID: 102748
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlyingEdges2D_GetArrayComponent_05(HandleRef pThis);

		/// <summary>
		/// Set/get which component of the scalar array to contour on; defaults to 0.
		/// </summary>
		// Token: 0x0601915D RID: 102749 RVA: 0x0022FA0C File Offset: 0x0022DC0C
		public virtual int GetArrayComponent()
		{
			return vtkFlyingEdges2D.vtkFlyingEdges2D_GetArrayComponent_05(base.GetCppThis());
		}

		// Token: 0x0601915E RID: 102750
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlyingEdges2D_GetComputeScalars_06(HandleRef pThis);

		/// <summary>
		/// Option to set the point scalars of the output.  The scalars will be the
		/// iso value of course.  By default this flag is on.
		/// </summary>
		// Token: 0x0601915F RID: 102751 RVA: 0x0022FA2C File Offset: 0x0022DC2C
		public virtual int GetComputeScalars()
		{
			return vtkFlyingEdges2D.vtkFlyingEdges2D_GetComputeScalars_06(base.GetCppThis());
		}

		// Token: 0x06019160 RID: 102752
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkFlyingEdges2D_GetMTime_07(HandleRef pThis);

		/// <summary>
		/// Because we delegate to vtkContourValues.
		/// </summary>
		// Token: 0x06019161 RID: 102753 RVA: 0x0022FA4C File Offset: 0x0022DC4C
		public override ulong GetMTime()
		{
			return vtkFlyingEdges2D.vtkFlyingEdges2D_GetMTime_07(base.GetCppThis());
		}

		// Token: 0x06019162 RID: 102754
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFlyingEdges2D_GetNumberOfContours_08(HandleRef pThis);

		/// <summary>
		/// Get the number of contours in the list of contour values.
		/// </summary>
		// Token: 0x06019163 RID: 102755 RVA: 0x0022FA6C File Offset: 0x0022DC6C
		public long GetNumberOfContours()
		{
			return vtkFlyingEdges2D.vtkFlyingEdges2D_GetNumberOfContours_08(base.GetCppThis());
		}

		// Token: 0x06019164 RID: 102756
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFlyingEdges2D_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019165 RID: 102757 RVA: 0x0022FA8C File Offset: 0x0022DC8C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFlyingEdges2D.vtkFlyingEdges2D_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06019166 RID: 102758
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFlyingEdges2D_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019167 RID: 102759 RVA: 0x0022FAAC File Offset: 0x0022DCAC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFlyingEdges2D.vtkFlyingEdges2D_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06019168 RID: 102760
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFlyingEdges2D_GetValue_11(HandleRef pThis, int i);

		/// <summary>
		/// Get the ith contour value.
		/// </summary>
		// Token: 0x06019169 RID: 102761 RVA: 0x0022FAC8 File Offset: 0x0022DCC8
		public double GetValue(int i)
		{
			return vtkFlyingEdges2D.vtkFlyingEdges2D_GetValue_11(base.GetCppThis(), i);
		}

		// Token: 0x0601916A RID: 102762
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFlyingEdges2D_GetValues_12(HandleRef pThis);

		/// <summary>
		/// Get a pointer to an array of contour values. There will be
		/// GetNumberOfContours() values in the list.
		/// </summary>
		// Token: 0x0601916B RID: 102763 RVA: 0x0022FAE8 File Offset: 0x0022DCE8
		public IntPtr GetValues()
		{
			return vtkFlyingEdges2D.vtkFlyingEdges2D_GetValues_12(base.GetCppThis());
		}

		// Token: 0x0601916C RID: 102764
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges2D_GetValues_13(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Fill a supplied list with contour values. There will be
		/// GetNumberOfContours() values in the list. Make sure you allocate
		/// enough memory to hold the list.
		/// </summary>
		// Token: 0x0601916D RID: 102765 RVA: 0x0022FB07 File Offset: 0x0022DD07
		public void GetValues(IntPtr contourValues)
		{
			vtkFlyingEdges2D.vtkFlyingEdges2D_GetValues_13(base.GetCppThis(), contourValues);
		}

		// Token: 0x0601916E RID: 102766
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlyingEdges2D_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601916F RID: 102767 RVA: 0x0022FB18 File Offset: 0x0022DD18
		public override int IsA(string type)
		{
			return vtkFlyingEdges2D.vtkFlyingEdges2D_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06019170 RID: 102768
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlyingEdges2D_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019171 RID: 102769 RVA: 0x0022FB38 File Offset: 0x0022DD38
		public new static int IsTypeOf(string type)
		{
			return vtkFlyingEdges2D.vtkFlyingEdges2D_IsTypeOf_15(type);
		}

		// Token: 0x06019172 RID: 102770
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFlyingEdges2D_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019173 RID: 102771 RVA: 0x0022FB54 File Offset: 0x0022DD54
		public new vtkFlyingEdges2D NewInstance()
		{
			vtkFlyingEdges2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFlyingEdges2D.vtkFlyingEdges2D_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFlyingEdges2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019174 RID: 102772
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFlyingEdges2D_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019175 RID: 102773 RVA: 0x0022FBB0 File Offset: 0x0022DDB0
		public new static vtkFlyingEdges2D SafeDownCast(vtkObjectBase o)
		{
			vtkFlyingEdges2D vtkFlyingEdges2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFlyingEdges2D.vtkFlyingEdges2D_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFlyingEdges2D = (vtkFlyingEdges2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFlyingEdges2D.Register(null);
				}
			}
			return vtkFlyingEdges2D;
		}

		// Token: 0x06019176 RID: 102774
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges2D_SetArrayComponent_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get which component of the scalar array to contour on; defaults to 0.
		/// </summary>
		// Token: 0x06019177 RID: 102775 RVA: 0x0022FC2F File Offset: 0x0022DE2F
		public virtual void SetArrayComponent(int _arg)
		{
			vtkFlyingEdges2D.vtkFlyingEdges2D_SetArrayComponent_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06019178 RID: 102776
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges2D_SetComputeScalars_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Option to set the point scalars of the output.  The scalars will be the
		/// iso value of course.  By default this flag is on.
		/// </summary>
		// Token: 0x06019179 RID: 102777 RVA: 0x0022FC3F File Offset: 0x0022DE3F
		public virtual void SetComputeScalars(int _arg)
		{
			vtkFlyingEdges2D.vtkFlyingEdges2D_SetComputeScalars_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0601917A RID: 102778
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges2D_SetNumberOfContours_21(HandleRef pThis, int number);

		/// <summary>
		/// Set the number of contours to place into the list. You only really
		/// need to use this method to reduce list size. The method SetValue()
		/// will automatically increase list size as needed.
		/// </summary>
		// Token: 0x0601917B RID: 102779 RVA: 0x0022FC4F File Offset: 0x0022DE4F
		public void SetNumberOfContours(int number)
		{
			vtkFlyingEdges2D.vtkFlyingEdges2D_SetNumberOfContours_21(base.GetCppThis(), number);
		}

		// Token: 0x0601917C RID: 102780
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges2D_SetValue_22(HandleRef pThis, int i, double value);

		/// <summary>
		/// Set a particular contour value at contour number i. The index i ranges
		/// between 0&lt;=i&lt;NumberOfContours.
		/// </summary>
		// Token: 0x0601917D RID: 102781 RVA: 0x0022FC5F File Offset: 0x0022DE5F
		public void SetValue(int i, double value)
		{
			vtkFlyingEdges2D.vtkFlyingEdges2D_SetValue_22(base.GetCppThis(), i, value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B8B RID: 7051
		public new const string MRFullTypeName = "Kitware.VTK.vtkFlyingEdges2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B8C RID: 7052
		public new static readonly string MRClassNameKey = "class vtkFlyingEdges2D";
	}
}
