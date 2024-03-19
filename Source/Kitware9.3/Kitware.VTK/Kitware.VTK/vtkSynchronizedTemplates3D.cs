using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSynchronizedTemplates3D
	/// </summary>
	/// <remarks>
	///    generate isosurface from structured points
	///
	/// vtkSynchronizedTemplates3D is a 3D implementation of the synchronized
	/// template algorithm. Note that vtkContourFilter will automatically
	/// use this class when appropriate.
	///
	/// @warning
	/// This filter is specialized to 3D images (aka volumes).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkContourFilter vtkFlyingEdges3D vtkMarchingCubes
	/// vtkSynchronizedTemplates2D vtkDiscreteFlyingEdges3D
	/// </seealso>
	// Token: 0x020009B0 RID: 2480
	public class vtkSynchronizedTemplates3D : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019E6B RID: 106091 RVA: 0x0023F09C File Offset: 0x0023D29C
		static vtkSynchronizedTemplates3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSynchronizedTemplates3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSynchronizedTemplates3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019E6C RID: 106092 RVA: 0x0023F0C4 File Offset: 0x0023D2C4
		public vtkSynchronizedTemplates3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019E6D RID: 106093
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSynchronizedTemplates3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019E6E RID: 106094 RVA: 0x0023F0D4 File Offset: 0x0023D2D4
		public new static vtkSynchronizedTemplates3D New()
		{
			vtkSynchronizedTemplates3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSynchronizedTemplates3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019E6F RID: 106095 RVA: 0x0023F128 File Offset: 0x0023D328
		public vtkSynchronizedTemplates3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019E70 RID: 106096 RVA: 0x0023F16C File Offset: 0x0023D36C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019E71 RID: 106097
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates3D_ComputeGradientsOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06019E72 RID: 106098 RVA: 0x0023F177 File Offset: 0x0023D377
		public virtual void ComputeGradientsOff()
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_ComputeGradientsOff_01(base.GetCppThis());
		}

		// Token: 0x06019E73 RID: 106099
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates3D_ComputeGradientsOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06019E74 RID: 106100 RVA: 0x0023F186 File Offset: 0x0023D386
		public virtual void ComputeGradientsOn()
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_ComputeGradientsOn_02(base.GetCppThis());
		}

		// Token: 0x06019E75 RID: 106101
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates3D_ComputeNormalsOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06019E76 RID: 106102 RVA: 0x0023F195 File Offset: 0x0023D395
		public virtual void ComputeNormalsOff()
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_ComputeNormalsOff_03(base.GetCppThis());
		}

		// Token: 0x06019E77 RID: 106103
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates3D_ComputeNormalsOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06019E78 RID: 106104 RVA: 0x0023F1A4 File Offset: 0x0023D3A4
		public virtual void ComputeNormalsOn()
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_ComputeNormalsOn_04(base.GetCppThis());
		}

		// Token: 0x06019E79 RID: 106105
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates3D_ComputeScalarsOff_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06019E7A RID: 106106 RVA: 0x0023F1B3 File Offset: 0x0023D3B3
		public virtual void ComputeScalarsOff()
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_ComputeScalarsOff_05(base.GetCppThis());
		}

		// Token: 0x06019E7B RID: 106107
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates3D_ComputeScalarsOn_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06019E7C RID: 106108 RVA: 0x0023F1C2 File Offset: 0x0023D3C2
		public virtual void ComputeScalarsOn()
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_ComputeScalarsOn_06(base.GetCppThis());
		}

		// Token: 0x06019E7D RID: 106109
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates3D_GenerateTrianglesOff_07(HandleRef pThis);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles
		/// otherwise, the output will be the intersection polygons
		/// </summary>
		// Token: 0x06019E7E RID: 106110 RVA: 0x0023F1D1 File Offset: 0x0023D3D1
		public virtual void GenerateTrianglesOff()
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GenerateTrianglesOff_07(base.GetCppThis());
		}

		// Token: 0x06019E7F RID: 106111
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates3D_GenerateTrianglesOn_08(HandleRef pThis);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles
		/// otherwise, the output will be the intersection polygons
		/// </summary>
		// Token: 0x06019E80 RID: 106112 RVA: 0x0023F1E0 File Offset: 0x0023D3E0
		public virtual void GenerateTrianglesOn()
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GenerateTrianglesOn_08(base.GetCppThis());
		}

		// Token: 0x06019E81 RID: 106113
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates3D_GenerateValues_09(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x06019E82 RID: 106114 RVA: 0x0023F1EF File Offset: 0x0023D3EF
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GenerateValues_09(base.GetCppThis(), numContours, range);
		}

		// Token: 0x06019E83 RID: 106115
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates3D_GenerateValues_10(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x06019E84 RID: 106116 RVA: 0x0023F200 File Offset: 0x0023D400
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GenerateValues_10(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x06019E85 RID: 106117
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSynchronizedTemplates3D_GetArrayComponent_11(HandleRef pThis);

		/// <summary>
		/// Set/get which component of the scalar array to contour on; defaults to 0.
		/// </summary>
		// Token: 0x06019E86 RID: 106118 RVA: 0x0023F214 File Offset: 0x0023D414
		public virtual int GetArrayComponent()
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetArrayComponent_11(base.GetCppThis());
		}

		// Token: 0x06019E87 RID: 106119
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSynchronizedTemplates3D_GetComputeGradients_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06019E88 RID: 106120 RVA: 0x0023F234 File Offset: 0x0023D434
		public virtual int GetComputeGradients()
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetComputeGradients_12(base.GetCppThis());
		}

		// Token: 0x06019E89 RID: 106121
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSynchronizedTemplates3D_GetComputeNormals_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06019E8A RID: 106122 RVA: 0x0023F254 File Offset: 0x0023D454
		public virtual int GetComputeNormals()
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetComputeNormals_13(base.GetCppThis());
		}

		// Token: 0x06019E8B RID: 106123
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSynchronizedTemplates3D_GetComputeScalars_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06019E8C RID: 106124 RVA: 0x0023F274 File Offset: 0x0023D474
		public virtual int GetComputeScalars()
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetComputeScalars_14(base.GetCppThis());
		}

		// Token: 0x06019E8D RID: 106125
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSynchronizedTemplates3D_GetGenerateTriangles_15(HandleRef pThis);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles
		/// otherwise, the output will be the intersection polygons
		/// </summary>
		// Token: 0x06019E8E RID: 106126 RVA: 0x0023F294 File Offset: 0x0023D494
		public virtual int GetGenerateTriangles()
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetGenerateTriangles_15(base.GetCppThis());
		}

		// Token: 0x06019E8F RID: 106127
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkSynchronizedTemplates3D_GetInputMemoryLimit_16(HandleRef pThis);

		/// <summary>
		/// Determines the chunk size for streaming.  This filter will act like a
		/// collector: ask for many input pieces, but generate one output.  Limit is
		/// in KBytes
		/// </summary>
		// Token: 0x06019E90 RID: 106128 RVA: 0x0023F2B4 File Offset: 0x0023D4B4
		public uint GetInputMemoryLimit()
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetInputMemoryLimit_16(base.GetCppThis());
		}

		// Token: 0x06019E91 RID: 106129
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkSynchronizedTemplates3D_GetMTime_17(HandleRef pThis);

		/// <summary>
		/// Because we delegate to vtkContourValues
		/// </summary>
		// Token: 0x06019E92 RID: 106130 RVA: 0x0023F2D4 File Offset: 0x0023D4D4
		public override ulong GetMTime()
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetMTime_17(base.GetCppThis());
		}

		// Token: 0x06019E93 RID: 106131
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSynchronizedTemplates3D_GetNumberOfContours_18(HandleRef pThis);

		/// <summary>
		/// Get the number of contours in the list of contour values.
		/// </summary>
		// Token: 0x06019E94 RID: 106132 RVA: 0x0023F2F4 File Offset: 0x0023D4F4
		public long GetNumberOfContours()
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetNumberOfContours_18(base.GetCppThis());
		}

		// Token: 0x06019E95 RID: 106133
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSynchronizedTemplates3D_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019E96 RID: 106134 RVA: 0x0023F314 File Offset: 0x0023D514
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x06019E97 RID: 106135
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSynchronizedTemplates3D_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019E98 RID: 106136 RVA: 0x0023F334 File Offset: 0x0023D534
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x06019E99 RID: 106137
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSynchronizedTemplates3D_GetValue_21(HandleRef pThis, int i);

		/// <summary>
		/// Get the ith contour value.
		/// </summary>
		// Token: 0x06019E9A RID: 106138 RVA: 0x0023F350 File Offset: 0x0023D550
		public double GetValue(int i)
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetValue_21(base.GetCppThis(), i);
		}

		// Token: 0x06019E9B RID: 106139
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSynchronizedTemplates3D_GetValues_22(HandleRef pThis);

		/// <summary>
		/// Get a pointer to an array of contour values. There will be
		/// GetNumberOfContours() values in the list.
		/// </summary>
		// Token: 0x06019E9C RID: 106140 RVA: 0x0023F370 File Offset: 0x0023D570
		public IntPtr GetValues()
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetValues_22(base.GetCppThis());
		}

		// Token: 0x06019E9D RID: 106141
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates3D_GetValues_23(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Fill a supplied list with contour values. There will be
		/// GetNumberOfContours() values in the list. Make sure you allocate
		/// enough memory to hold the list.
		/// </summary>
		// Token: 0x06019E9E RID: 106142 RVA: 0x0023F38F File Offset: 0x0023D58F
		public void GetValues(IntPtr contourValues)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetValues_23(base.GetCppThis(), contourValues);
		}

		// Token: 0x06019E9F RID: 106143
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSynchronizedTemplates3D_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019EA0 RID: 106144 RVA: 0x0023F3A0 File Offset: 0x0023D5A0
		public override int IsA(string type)
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x06019EA1 RID: 106145
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSynchronizedTemplates3D_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019EA2 RID: 106146 RVA: 0x0023F3C0 File Offset: 0x0023D5C0
		public new static int IsTypeOf(string type)
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_IsTypeOf_25(type);
		}

		// Token: 0x06019EA3 RID: 106147
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSynchronizedTemplates3D_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019EA4 RID: 106148 RVA: 0x0023F3DC File Offset: 0x0023D5DC
		public new vtkSynchronizedTemplates3D NewInstance()
		{
			vtkSynchronizedTemplates3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSynchronizedTemplates3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019EA5 RID: 106149
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSynchronizedTemplates3D_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019EA6 RID: 106150 RVA: 0x0023F438 File Offset: 0x0023D638
		public new static vtkSynchronizedTemplates3D SafeDownCast(vtkObjectBase o)
		{
			vtkSynchronizedTemplates3D vtkSynchronizedTemplates3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSynchronizedTemplates3D = (vtkSynchronizedTemplates3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSynchronizedTemplates3D.Register(null);
				}
			}
			return vtkSynchronizedTemplates3D;
		}

		// Token: 0x06019EA7 RID: 106151
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates3D_SetArrayComponent_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get which component of the scalar array to contour on; defaults to 0.
		/// </summary>
		// Token: 0x06019EA8 RID: 106152 RVA: 0x0023F4B7 File Offset: 0x0023D6B7
		public virtual void SetArrayComponent(int _arg)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_SetArrayComponent_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06019EA9 RID: 106153
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates3D_SetComputeGradients_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06019EAA RID: 106154 RVA: 0x0023F4C7 File Offset: 0x0023D6C7
		public virtual void SetComputeGradients(int _arg)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_SetComputeGradients_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06019EAB RID: 106155
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates3D_SetComputeNormals_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06019EAC RID: 106156 RVA: 0x0023F4D7 File Offset: 0x0023D6D7
		public virtual void SetComputeNormals(int _arg)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_SetComputeNormals_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06019EAD RID: 106157
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates3D_SetComputeScalars_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06019EAE RID: 106158 RVA: 0x0023F4E7 File Offset: 0x0023D6E7
		public virtual void SetComputeScalars(int _arg)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_SetComputeScalars_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06019EAF RID: 106159
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates3D_SetGenerateTriangles_33(HandleRef pThis, int _arg);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles
		/// otherwise, the output will be the intersection polygons
		/// </summary>
		// Token: 0x06019EB0 RID: 106160 RVA: 0x0023F4F7 File Offset: 0x0023D6F7
		public virtual void SetGenerateTriangles(int _arg)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_SetGenerateTriangles_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06019EB1 RID: 106161
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates3D_SetInputMemoryLimit_34(HandleRef pThis, uint limit);

		/// <summary>
		/// Determines the chunk size for streaming.  This filter will act like a
		/// collector: ask for many input pieces, but generate one output.  Limit is
		/// in KBytes
		/// </summary>
		// Token: 0x06019EB2 RID: 106162 RVA: 0x0023F507 File Offset: 0x0023D707
		public void SetInputMemoryLimit(uint limit)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_SetInputMemoryLimit_34(base.GetCppThis(), limit);
		}

		// Token: 0x06019EB3 RID: 106163
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates3D_SetNumberOfContours_35(HandleRef pThis, int number);

		/// <summary>
		/// Set the number of contours to place into the list. You only really
		/// need to use this method to reduce list size. The method SetValue()
		/// will automatically increase list size as needed.
		/// </summary>
		// Token: 0x06019EB4 RID: 106164 RVA: 0x0023F517 File Offset: 0x0023D717
		public void SetNumberOfContours(int number)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_SetNumberOfContours_35(base.GetCppThis(), number);
		}

		// Token: 0x06019EB5 RID: 106165
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates3D_SetValue_36(HandleRef pThis, int i, double value);

		/// <summary>
		/// Set a particular contour value at contour number i. The index i ranges
		/// between 0&lt;=i&lt;NumberOfContours.
		/// </summary>
		// Token: 0x06019EB6 RID: 106166 RVA: 0x0023F527 File Offset: 0x0023D727
		public void SetValue(int i, double value)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_SetValue_36(base.GetCppThis(), i, value);
		}

		// Token: 0x06019EB7 RID: 106167
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates3D_ThreadedExecute_37(HandleRef pThis, HandleRef data, HandleRef inInfo, HandleRef outInfo, HandleRef inScalars);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x06019EB8 RID: 106168 RVA: 0x0023F538 File Offset: 0x0023D738
		public void ThreadedExecute(vtkImageData data, vtkInformation inInfo, vtkInformation outInfo, vtkDataArray inScalars)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_ThreadedExecute_37(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), (inInfo == null) ? default(HandleRef) : inInfo.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis(), (inScalars == null) ? default(HandleRef) : inScalars.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C23 RID: 7203
		public new const string MRFullTypeName = "Kitware.VTK.vtkSynchronizedTemplates3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C24 RID: 7204
		public new static readonly string MRClassNameKey = "class vtkSynchronizedTemplates3D";
	}
}
