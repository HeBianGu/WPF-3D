using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRectilinearSynchronizedTemplates
	/// </summary>
	/// <remarks>
	///    generate isosurface from rectilinear grid
	///
	///
	/// vtkRectilinearSynchronizedTemplates is a 3D implementation (for rectilinear
	/// grids) of the synchronized template algorithm. Note that vtkContourFilter
	/// will automatically use this class when appropriate.
	///
	/// @warning
	/// This filter is specialized to rectilinear grids.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkContourFilter vtkSynchronizedTemplates2D vtkSynchronizedTemplates3D
	/// </seealso>
	// Token: 0x02000995 RID: 2453
	public class vtkRectilinearSynchronizedTemplates : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019961 RID: 104801 RVA: 0x00239577 File Offset: 0x00237777
		static vtkRectilinearSynchronizedTemplates()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectilinearSynchronizedTemplates.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearSynchronizedTemplates"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019962 RID: 104802 RVA: 0x0023959F File Offset: 0x0023779F
		public vtkRectilinearSynchronizedTemplates(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019963 RID: 104803
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearSynchronizedTemplates_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019964 RID: 104804 RVA: 0x002395B0 File Offset: 0x002377B0
		public new static vtkRectilinearSynchronizedTemplates New()
		{
			vtkRectilinearSynchronizedTemplates result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearSynchronizedTemplates)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019965 RID: 104805 RVA: 0x00239604 File Offset: 0x00237804
		public vtkRectilinearSynchronizedTemplates() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019966 RID: 104806 RVA: 0x00239648 File Offset: 0x00237848
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019967 RID: 104807
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearSynchronizedTemplates_ComputeGradientsOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06019968 RID: 104808 RVA: 0x00239653 File Offset: 0x00237853
		public virtual void ComputeGradientsOff()
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_ComputeGradientsOff_01(base.GetCppThis());
		}

		// Token: 0x06019969 RID: 104809
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearSynchronizedTemplates_ComputeGradientsOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x0601996A RID: 104810 RVA: 0x00239662 File Offset: 0x00237862
		public virtual void ComputeGradientsOn()
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_ComputeGradientsOn_02(base.GetCppThis());
		}

		// Token: 0x0601996B RID: 104811
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearSynchronizedTemplates_ComputeNormalsOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x0601996C RID: 104812 RVA: 0x00239671 File Offset: 0x00237871
		public virtual void ComputeNormalsOff()
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_ComputeNormalsOff_03(base.GetCppThis());
		}

		// Token: 0x0601996D RID: 104813
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearSynchronizedTemplates_ComputeNormalsOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x0601996E RID: 104814 RVA: 0x00239680 File Offset: 0x00237880
		public virtual void ComputeNormalsOn()
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_ComputeNormalsOn_04(base.GetCppThis());
		}

		// Token: 0x0601996F RID: 104815
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearSynchronizedTemplates_ComputeScalarsOff_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06019970 RID: 104816 RVA: 0x0023968F File Offset: 0x0023788F
		public virtual void ComputeScalarsOff()
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_ComputeScalarsOff_05(base.GetCppThis());
		}

		// Token: 0x06019971 RID: 104817
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearSynchronizedTemplates_ComputeScalarsOn_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06019972 RID: 104818 RVA: 0x0023969E File Offset: 0x0023789E
		public virtual void ComputeScalarsOn()
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_ComputeScalarsOn_06(base.GetCppThis());
		}

		// Token: 0x06019973 RID: 104819
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearSynchronizedTemplates_ComputeSpacing_07(HandleRef pThis, HandleRef data, int i, int j, int k, IntPtr extent, IntPtr spacing);

		/// <summary>
		/// Compute the spacing between this point and its 6 neighbors.  This method
		/// needs to be public so it can be accessed from a templated function.
		/// </summary>
		// Token: 0x06019974 RID: 104820 RVA: 0x002396B0 File Offset: 0x002378B0
		public void ComputeSpacing(vtkRectilinearGrid data, int i, int j, int k, IntPtr extent, IntPtr spacing)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_ComputeSpacing_07(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), i, j, k, extent, spacing);
		}

		// Token: 0x06019975 RID: 104821
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearSynchronizedTemplates_GenerateTrianglesOff_08(HandleRef pThis);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles
		/// otherwise, the output will be the intersection polygons
		/// </summary>
		// Token: 0x06019976 RID: 104822 RVA: 0x002396E7 File Offset: 0x002378E7
		public virtual void GenerateTrianglesOff()
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GenerateTrianglesOff_08(base.GetCppThis());
		}

		// Token: 0x06019977 RID: 104823
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearSynchronizedTemplates_GenerateTrianglesOn_09(HandleRef pThis);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles
		/// otherwise, the output will be the intersection polygons
		/// </summary>
		// Token: 0x06019978 RID: 104824 RVA: 0x002396F6 File Offset: 0x002378F6
		public virtual void GenerateTrianglesOn()
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GenerateTrianglesOn_09(base.GetCppThis());
		}

		// Token: 0x06019979 RID: 104825
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearSynchronizedTemplates_GenerateValues_10(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x0601997A RID: 104826 RVA: 0x00239705 File Offset: 0x00237905
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GenerateValues_10(base.GetCppThis(), numContours, range);
		}

		// Token: 0x0601997B RID: 104827
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearSynchronizedTemplates_GenerateValues_11(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x0601997C RID: 104828 RVA: 0x00239716 File Offset: 0x00237916
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GenerateValues_11(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x0601997D RID: 104829
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearSynchronizedTemplates_GetArrayComponent_12(HandleRef pThis);

		/// <summary>
		/// Set/get which component of the scalar array to contour on; defaults to 0.
		/// </summary>
		// Token: 0x0601997E RID: 104830 RVA: 0x00239728 File Offset: 0x00237928
		public virtual int GetArrayComponent()
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetArrayComponent_12(base.GetCppThis());
		}

		// Token: 0x0601997F RID: 104831
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearSynchronizedTemplates_GetComputeGradients_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06019980 RID: 104832 RVA: 0x00239748 File Offset: 0x00237948
		public virtual int GetComputeGradients()
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetComputeGradients_13(base.GetCppThis());
		}

		// Token: 0x06019981 RID: 104833
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearSynchronizedTemplates_GetComputeNormals_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06019982 RID: 104834 RVA: 0x00239768 File Offset: 0x00237968
		public virtual int GetComputeNormals()
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetComputeNormals_14(base.GetCppThis());
		}

		// Token: 0x06019983 RID: 104835
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearSynchronizedTemplates_GetComputeScalars_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06019984 RID: 104836 RVA: 0x00239788 File Offset: 0x00237988
		public virtual int GetComputeScalars()
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetComputeScalars_15(base.GetCppThis());
		}

		// Token: 0x06019985 RID: 104837
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearSynchronizedTemplates_GetGenerateTriangles_16(HandleRef pThis);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles
		/// otherwise, the output will be the intersection polygons
		/// </summary>
		// Token: 0x06019986 RID: 104838 RVA: 0x002397A8 File Offset: 0x002379A8
		public virtual int GetGenerateTriangles()
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetGenerateTriangles_16(base.GetCppThis());
		}

		// Token: 0x06019987 RID: 104839
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkRectilinearSynchronizedTemplates_GetMTime_17(HandleRef pThis);

		/// <summary>
		/// Because we delegate to vtkContourValues
		/// </summary>
		// Token: 0x06019988 RID: 104840 RVA: 0x002397C8 File Offset: 0x002379C8
		public override ulong GetMTime()
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetMTime_17(base.GetCppThis());
		}

		// Token: 0x06019989 RID: 104841
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearSynchronizedTemplates_GetNumberOfContours_18(HandleRef pThis);

		/// <summary>
		/// Get the number of contours in the list of contour values.
		/// </summary>
		// Token: 0x0601998A RID: 104842 RVA: 0x002397E8 File Offset: 0x002379E8
		public long GetNumberOfContours()
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetNumberOfContours_18(base.GetCppThis());
		}

		// Token: 0x0601998B RID: 104843
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearSynchronizedTemplates_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601998C RID: 104844 RVA: 0x00239808 File Offset: 0x00237A08
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x0601998D RID: 104845
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearSynchronizedTemplates_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601998E RID: 104846 RVA: 0x00239828 File Offset: 0x00237A28
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x0601998F RID: 104847
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectilinearSynchronizedTemplates_GetValue_21(HandleRef pThis, int i);

		/// <summary>
		/// Get the ith contour value.
		/// </summary>
		// Token: 0x06019990 RID: 104848 RVA: 0x00239844 File Offset: 0x00237A44
		public double GetValue(int i)
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetValue_21(base.GetCppThis(), i);
		}

		// Token: 0x06019991 RID: 104849
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearSynchronizedTemplates_GetValues_22(HandleRef pThis);

		/// <summary>
		/// Get a pointer to an array of contour values. There will be
		/// GetNumberOfContours() values in the list.
		/// </summary>
		// Token: 0x06019992 RID: 104850 RVA: 0x00239864 File Offset: 0x00237A64
		public IntPtr GetValues()
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetValues_22(base.GetCppThis());
		}

		// Token: 0x06019993 RID: 104851
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearSynchronizedTemplates_GetValues_23(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Fill a supplied list with contour values. There will be
		/// GetNumberOfContours() values in the list. Make sure you allocate
		/// enough memory to hold the list.
		/// </summary>
		// Token: 0x06019994 RID: 104852 RVA: 0x00239883 File Offset: 0x00237A83
		public void GetValues(IntPtr contourValues)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetValues_23(base.GetCppThis(), contourValues);
		}

		// Token: 0x06019995 RID: 104853
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearSynchronizedTemplates_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019996 RID: 104854 RVA: 0x00239894 File Offset: 0x00237A94
		public override int IsA(string type)
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x06019997 RID: 104855
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearSynchronizedTemplates_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019998 RID: 104856 RVA: 0x002398B4 File Offset: 0x00237AB4
		public new static int IsTypeOf(string type)
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_IsTypeOf_25(type);
		}

		// Token: 0x06019999 RID: 104857
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearSynchronizedTemplates_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601999A RID: 104858 RVA: 0x002398D0 File Offset: 0x00237AD0
		public new vtkRectilinearSynchronizedTemplates NewInstance()
		{
			vtkRectilinearSynchronizedTemplates result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearSynchronizedTemplates)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601999B RID: 104859
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearSynchronizedTemplates_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601999C RID: 104860 RVA: 0x0023992C File Offset: 0x00237B2C
		public new static vtkRectilinearSynchronizedTemplates SafeDownCast(vtkObjectBase o)
		{
			vtkRectilinearSynchronizedTemplates vtkRectilinearSynchronizedTemplates = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearSynchronizedTemplates = (vtkRectilinearSynchronizedTemplates)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearSynchronizedTemplates.Register(null);
				}
			}
			return vtkRectilinearSynchronizedTemplates;
		}

		// Token: 0x0601999D RID: 104861
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearSynchronizedTemplates_SetArrayComponent_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get which component of the scalar array to contour on; defaults to 0.
		/// </summary>
		// Token: 0x0601999E RID: 104862 RVA: 0x002399AB File Offset: 0x00237BAB
		public virtual void SetArrayComponent(int _arg)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_SetArrayComponent_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0601999F RID: 104863
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearSynchronizedTemplates_SetComputeGradients_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x060199A0 RID: 104864 RVA: 0x002399BB File Offset: 0x00237BBB
		public virtual void SetComputeGradients(int _arg)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_SetComputeGradients_30(base.GetCppThis(), _arg);
		}

		// Token: 0x060199A1 RID: 104865
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearSynchronizedTemplates_SetComputeNormals_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x060199A2 RID: 104866 RVA: 0x002399CB File Offset: 0x00237BCB
		public virtual void SetComputeNormals(int _arg)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_SetComputeNormals_31(base.GetCppThis(), _arg);
		}

		// Token: 0x060199A3 RID: 104867
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearSynchronizedTemplates_SetComputeScalars_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x060199A4 RID: 104868 RVA: 0x002399DB File Offset: 0x00237BDB
		public virtual void SetComputeScalars(int _arg)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_SetComputeScalars_32(base.GetCppThis(), _arg);
		}

		// Token: 0x060199A5 RID: 104869
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearSynchronizedTemplates_SetGenerateTriangles_33(HandleRef pThis, int _arg);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles
		/// otherwise, the output will be the intersection polygons
		/// </summary>
		// Token: 0x060199A6 RID: 104870 RVA: 0x002399EB File Offset: 0x00237BEB
		public virtual void SetGenerateTriangles(int _arg)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_SetGenerateTriangles_33(base.GetCppThis(), _arg);
		}

		// Token: 0x060199A7 RID: 104871
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearSynchronizedTemplates_SetNumberOfContours_34(HandleRef pThis, int number);

		/// <summary>
		/// Set the number of contours to place into the list. You only really
		/// need to use this method to reduce list size. The method SetValue()
		/// will automatically increase list size as needed.
		/// </summary>
		// Token: 0x060199A8 RID: 104872 RVA: 0x002399FB File Offset: 0x00237BFB
		public void SetNumberOfContours(int number)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_SetNumberOfContours_34(base.GetCppThis(), number);
		}

		// Token: 0x060199A9 RID: 104873
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearSynchronizedTemplates_SetValue_35(HandleRef pThis, int i, double value);

		/// <summary>
		/// Set a particular contour value at contour number i. The index i ranges
		/// between 0&lt;=i&lt;NumberOfContours.
		/// </summary>
		// Token: 0x060199AA RID: 104874 RVA: 0x00239A0B File Offset: 0x00237C0B
		public void SetValue(int i, double value)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_SetValue_35(base.GetCppThis(), i, value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BEF RID: 7151
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearSynchronizedTemplates";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BF0 RID: 7152
		public new static readonly string MRClassNameKey = "class vtkRectilinearSynchronizedTemplates";
	}
}
