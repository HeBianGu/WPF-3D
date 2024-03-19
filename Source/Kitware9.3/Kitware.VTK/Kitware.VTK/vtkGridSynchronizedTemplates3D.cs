using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGridSynchronizedTemplates3D
	/// </summary>
	/// <remarks>
	///    generate isosurface from structured grids
	///
	///
	/// vtkGridSynchronizedTemplates3D is a 3D implementation of the synchronized
	/// template algorithm.
	///
	/// @warning
	/// This filter is specialized to 3D grids.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkContourFilter vtkSynchronizedTemplates3D
	/// </seealso>
	// Token: 0x0200096E RID: 2414
	public class vtkGridSynchronizedTemplates3D : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060192A4 RID: 103076 RVA: 0x0023111F File Offset: 0x0022F31F
		static vtkGridSynchronizedTemplates3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGridSynchronizedTemplates3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGridSynchronizedTemplates3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060192A5 RID: 103077 RVA: 0x00231147 File Offset: 0x0022F347
		public vtkGridSynchronizedTemplates3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060192A6 RID: 103078
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGridSynchronizedTemplates3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060192A7 RID: 103079 RVA: 0x00231158 File Offset: 0x0022F358
		public new static vtkGridSynchronizedTemplates3D New()
		{
			vtkGridSynchronizedTemplates3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGridSynchronizedTemplates3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060192A8 RID: 103080 RVA: 0x002311AC File Offset: 0x0022F3AC
		public vtkGridSynchronizedTemplates3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060192A9 RID: 103081 RVA: 0x002311F0 File Offset: 0x0022F3F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060192AA RID: 103082
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridSynchronizedTemplates3D_ComputeGradientsOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x060192AB RID: 103083 RVA: 0x002311FB File Offset: 0x0022F3FB
		public virtual void ComputeGradientsOff()
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_ComputeGradientsOff_01(base.GetCppThis());
		}

		// Token: 0x060192AC RID: 103084
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridSynchronizedTemplates3D_ComputeGradientsOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x060192AD RID: 103085 RVA: 0x0023120A File Offset: 0x0022F40A
		public virtual void ComputeGradientsOn()
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_ComputeGradientsOn_02(base.GetCppThis());
		}

		// Token: 0x060192AE RID: 103086
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridSynchronizedTemplates3D_ComputeNormalsOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x060192AF RID: 103087 RVA: 0x00231219 File Offset: 0x0022F419
		public virtual void ComputeNormalsOff()
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_ComputeNormalsOff_03(base.GetCppThis());
		}

		// Token: 0x060192B0 RID: 103088
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridSynchronizedTemplates3D_ComputeNormalsOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x060192B1 RID: 103089 RVA: 0x00231228 File Offset: 0x0022F428
		public virtual void ComputeNormalsOn()
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_ComputeNormalsOn_04(base.GetCppThis());
		}

		// Token: 0x060192B2 RID: 103090
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridSynchronizedTemplates3D_ComputeScalarsOff_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x060192B3 RID: 103091 RVA: 0x00231237 File Offset: 0x0022F437
		public virtual void ComputeScalarsOff()
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_ComputeScalarsOff_05(base.GetCppThis());
		}

		// Token: 0x060192B4 RID: 103092
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridSynchronizedTemplates3D_ComputeScalarsOn_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x060192B5 RID: 103093 RVA: 0x00231246 File Offset: 0x0022F446
		public virtual void ComputeScalarsOn()
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_ComputeScalarsOn_06(base.GetCppThis());
		}

		// Token: 0x060192B6 RID: 103094
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridSynchronizedTemplates3D_GenerateTrianglesOff_07(HandleRef pThis);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles
		/// otherwise, the output will be the intersection polygons
		/// </summary>
		// Token: 0x060192B7 RID: 103095 RVA: 0x00231255 File Offset: 0x0022F455
		public virtual void GenerateTrianglesOff()
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GenerateTrianglesOff_07(base.GetCppThis());
		}

		// Token: 0x060192B8 RID: 103096
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridSynchronizedTemplates3D_GenerateTrianglesOn_08(HandleRef pThis);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles
		/// otherwise, the output will be the intersection polygons
		/// </summary>
		// Token: 0x060192B9 RID: 103097 RVA: 0x00231264 File Offset: 0x0022F464
		public virtual void GenerateTrianglesOn()
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GenerateTrianglesOn_08(base.GetCppThis());
		}

		// Token: 0x060192BA RID: 103098
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridSynchronizedTemplates3D_GenerateValues_09(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x060192BB RID: 103099 RVA: 0x00231273 File Offset: 0x0022F473
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GenerateValues_09(base.GetCppThis(), numContours, range);
		}

		// Token: 0x060192BC RID: 103100
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridSynchronizedTemplates3D_GenerateValues_10(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x060192BD RID: 103101 RVA: 0x00231284 File Offset: 0x0022F484
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GenerateValues_10(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x060192BE RID: 103102
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGridSynchronizedTemplates3D_GetComputeGradients_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x060192BF RID: 103103 RVA: 0x00231298 File Offset: 0x0022F498
		public virtual int GetComputeGradients()
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetComputeGradients_11(base.GetCppThis());
		}

		// Token: 0x060192C0 RID: 103104
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGridSynchronizedTemplates3D_GetComputeNormals_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x060192C1 RID: 103105 RVA: 0x002312B8 File Offset: 0x0022F4B8
		public virtual int GetComputeNormals()
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetComputeNormals_12(base.GetCppThis());
		}

		// Token: 0x060192C2 RID: 103106
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGridSynchronizedTemplates3D_GetComputeScalars_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x060192C3 RID: 103107 RVA: 0x002312D8 File Offset: 0x0022F4D8
		public virtual int GetComputeScalars()
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetComputeScalars_13(base.GetCppThis());
		}

		// Token: 0x060192C4 RID: 103108
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGridSynchronizedTemplates3D_GetGenerateTriangles_14(HandleRef pThis);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles
		/// otherwise, the output will be the intersection polygons
		/// </summary>
		// Token: 0x060192C5 RID: 103109 RVA: 0x002312F8 File Offset: 0x0022F4F8
		public virtual int GetGenerateTriangles()
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetGenerateTriangles_14(base.GetCppThis());
		}

		// Token: 0x060192C6 RID: 103110
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkGridSynchronizedTemplates3D_GetMTime_15(HandleRef pThis);

		/// <summary>
		/// Because we delegate to vtkContourValues
		/// </summary>
		// Token: 0x060192C7 RID: 103111 RVA: 0x00231318 File Offset: 0x0022F518
		public override ulong GetMTime()
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetMTime_15(base.GetCppThis());
		}

		// Token: 0x060192C8 RID: 103112
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGridSynchronizedTemplates3D_GetNumberOfContours_16(HandleRef pThis);

		/// <summary>
		/// Get the number of contours in the list of contour values.
		/// </summary>
		// Token: 0x060192C9 RID: 103113 RVA: 0x00231338 File Offset: 0x0022F538
		public long GetNumberOfContours()
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetNumberOfContours_16(base.GetCppThis());
		}

		// Token: 0x060192CA RID: 103114
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGridSynchronizedTemplates3D_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060192CB RID: 103115 RVA: 0x00231358 File Offset: 0x0022F558
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x060192CC RID: 103116
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGridSynchronizedTemplates3D_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060192CD RID: 103117 RVA: 0x00231378 File Offset: 0x0022F578
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x060192CE RID: 103118
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGridSynchronizedTemplates3D_GetOutputPointsPrecision_19(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x060192CF RID: 103119 RVA: 0x00231394 File Offset: 0x0022F594
		public virtual int GetOutputPointsPrecision()
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetOutputPointsPrecision_19(base.GetCppThis());
		}

		// Token: 0x060192D0 RID: 103120
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGridSynchronizedTemplates3D_GetOutputPointsPrecisionMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x060192D1 RID: 103121 RVA: 0x002313B4 File Offset: 0x0022F5B4
		public virtual int GetOutputPointsPrecisionMaxValue()
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetOutputPointsPrecisionMaxValue_20(base.GetCppThis());
		}

		// Token: 0x060192D2 RID: 103122
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGridSynchronizedTemplates3D_GetOutputPointsPrecisionMinValue_21(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x060192D3 RID: 103123 RVA: 0x002313D4 File Offset: 0x0022F5D4
		public virtual int GetOutputPointsPrecisionMinValue()
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetOutputPointsPrecisionMinValue_21(base.GetCppThis());
		}

		// Token: 0x060192D4 RID: 103124
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGridSynchronizedTemplates3D_GetValue_22(HandleRef pThis, int i);

		/// <summary>
		/// Get the ith contour value.
		/// </summary>
		// Token: 0x060192D5 RID: 103125 RVA: 0x002313F4 File Offset: 0x0022F5F4
		public double GetValue(int i)
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetValue_22(base.GetCppThis(), i);
		}

		// Token: 0x060192D6 RID: 103126
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGridSynchronizedTemplates3D_GetValues_23(HandleRef pThis);

		/// <summary>
		/// Get a pointer to an array of contour values. There will be
		/// GetNumberOfContours() values in the list.
		/// </summary>
		// Token: 0x060192D7 RID: 103127 RVA: 0x00231414 File Offset: 0x0022F614
		public IntPtr GetValues()
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetValues_23(base.GetCppThis());
		}

		// Token: 0x060192D8 RID: 103128
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridSynchronizedTemplates3D_GetValues_24(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Fill a supplied list with contour values. There will be
		/// GetNumberOfContours() values in the list. Make sure you allocate
		/// enough memory to hold the list.
		/// </summary>
		// Token: 0x060192D9 RID: 103129 RVA: 0x00231433 File Offset: 0x0022F633
		public void GetValues(IntPtr contourValues)
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetValues_24(base.GetCppThis(), contourValues);
		}

		// Token: 0x060192DA RID: 103130
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGridSynchronizedTemplates3D_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060192DB RID: 103131 RVA: 0x00231444 File Offset: 0x0022F644
		public override int IsA(string type)
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x060192DC RID: 103132
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGridSynchronizedTemplates3D_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060192DD RID: 103133 RVA: 0x00231464 File Offset: 0x0022F664
		public new static int IsTypeOf(string type)
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_IsTypeOf_26(type);
		}

		// Token: 0x060192DE RID: 103134
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGridSynchronizedTemplates3D_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060192DF RID: 103135 RVA: 0x00231480 File Offset: 0x0022F680
		public new vtkGridSynchronizedTemplates3D NewInstance()
		{
			vtkGridSynchronizedTemplates3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGridSynchronizedTemplates3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060192E0 RID: 103136
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGridSynchronizedTemplates3D_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060192E1 RID: 103137 RVA: 0x002314DC File Offset: 0x0022F6DC
		public new static vtkGridSynchronizedTemplates3D SafeDownCast(vtkObjectBase o)
		{
			vtkGridSynchronizedTemplates3D vtkGridSynchronizedTemplates3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGridSynchronizedTemplates3D = (vtkGridSynchronizedTemplates3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGridSynchronizedTemplates3D.Register(null);
				}
			}
			return vtkGridSynchronizedTemplates3D;
		}

		// Token: 0x060192E2 RID: 103138
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridSynchronizedTemplates3D_SetComputeGradients_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x060192E3 RID: 103139 RVA: 0x0023155B File Offset: 0x0022F75B
		public virtual void SetComputeGradients(int _arg)
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_SetComputeGradients_30(base.GetCppThis(), _arg);
		}

		// Token: 0x060192E4 RID: 103140
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridSynchronizedTemplates3D_SetComputeNormals_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x060192E5 RID: 103141 RVA: 0x0023156B File Offset: 0x0022F76B
		public virtual void SetComputeNormals(int _arg)
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_SetComputeNormals_31(base.GetCppThis(), _arg);
		}

		// Token: 0x060192E6 RID: 103142
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridSynchronizedTemplates3D_SetComputeScalars_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x060192E7 RID: 103143 RVA: 0x0023157B File Offset: 0x0022F77B
		public virtual void SetComputeScalars(int _arg)
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_SetComputeScalars_32(base.GetCppThis(), _arg);
		}

		// Token: 0x060192E8 RID: 103144
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridSynchronizedTemplates3D_SetGenerateTriangles_33(HandleRef pThis, int _arg);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles
		/// otherwise, the output will be the intersection polygons
		/// </summary>
		// Token: 0x060192E9 RID: 103145 RVA: 0x0023158B File Offset: 0x0022F78B
		public virtual void SetGenerateTriangles(int _arg)
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_SetGenerateTriangles_33(base.GetCppThis(), _arg);
		}

		// Token: 0x060192EA RID: 103146
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridSynchronizedTemplates3D_SetInputMemoryLimit_34(HandleRef pThis, int limit);

		/// <summary>
		/// This filter will initiate streaming so that no piece requested
		/// from the input will be larger than this value (KiloBytes).
		/// </summary>
		// Token: 0x060192EB RID: 103147 RVA: 0x0023159B File Offset: 0x0022F79B
		public void SetInputMemoryLimit(int limit)
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_SetInputMemoryLimit_34(base.GetCppThis(), limit);
		}

		// Token: 0x060192EC RID: 103148
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridSynchronizedTemplates3D_SetNumberOfContours_35(HandleRef pThis, int number);

		/// <summary>
		/// Set the number of contours to place into the list. You only really
		/// need to use this method to reduce list size. The method SetValue()
		/// will automatically increase list size as needed.
		/// </summary>
		// Token: 0x060192ED RID: 103149 RVA: 0x002315AB File Offset: 0x0022F7AB
		public void SetNumberOfContours(int number)
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_SetNumberOfContours_35(base.GetCppThis(), number);
		}

		// Token: 0x060192EE RID: 103150
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridSynchronizedTemplates3D_SetOutputPointsPrecision_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x060192EF RID: 103151 RVA: 0x002315BB File Offset: 0x0022F7BB
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_SetOutputPointsPrecision_36(base.GetCppThis(), _arg);
		}

		// Token: 0x060192F0 RID: 103152
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridSynchronizedTemplates3D_SetValue_37(HandleRef pThis, int i, double value);

		/// <summary>
		/// Set a particular contour value at contour number i. The index i ranges
		/// between 0&lt;=i&lt;NumberOfContours.
		/// </summary>
		// Token: 0x060192F1 RID: 103153 RVA: 0x002315CB File Offset: 0x0022F7CB
		public void SetValue(int i, double value)
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_SetValue_37(base.GetCppThis(), i, value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B95 RID: 7061
		public new const string MRFullTypeName = "Kitware.VTK.vtkGridSynchronizedTemplates3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B96 RID: 7062
		public new static readonly string MRClassNameKey = "class vtkGridSynchronizedTemplates3D";
	}
}
