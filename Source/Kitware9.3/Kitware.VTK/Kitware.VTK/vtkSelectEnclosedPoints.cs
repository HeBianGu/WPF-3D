using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSelectEnclosedPoints
	/// </summary>
	/// <remarks>
	///    mark points as to whether they are inside a closed surface
	///
	/// vtkSelectEnclosedPoints is a filter that evaluates all the input points to
	/// determine whether they are in an enclosed surface. The filter produces a
	/// (0,1) mask (in the form of a vtkDataArray) that indicates whether points
	/// are outside (mask value=0) or inside (mask value=1) a provided surface.
	/// (The name of the output vtkDataArray is "SelectedPoints".)
	///
	/// After running the filter, it is possible to query it as to whether a point
	/// is inside/outside by invoking the IsInside(ptId) method.
	///
	/// @warning
	/// The filter assumes that the surface is closed and manifold. A boolean flag
	/// can be set to force the filter to first check whether this is true. If false,
	/// all points will be marked outside. Note that if this check is not performed
	/// and the surface is not closed, the results are undefined.
	///
	/// @warning
	/// This filter produces and output data array, but does not modify the input
	/// dataset. If you wish to extract cells or points, various threshold filters
	/// are available (i.e., threshold the output array). Also, see the filter
	/// vtkExtractEnclosedPoints which operates on point clouds.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMaskPoints vtkExtractEnclosedPoints
	/// </seealso>
	// Token: 0x0200056E RID: 1390
	public class vtkSelectEnclosedPoints : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F65C RID: 63068 RVA: 0x0015674B File Offset: 0x0015494B
		static vtkSelectEnclosedPoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSelectEnclosedPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSelectEnclosedPoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F65D RID: 63069 RVA: 0x00156773 File Offset: 0x00154973
		public vtkSelectEnclosedPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F65E RID: 63070
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectEnclosedPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600F65F RID: 63071 RVA: 0x00156784 File Offset: 0x00154984
		public new static vtkSelectEnclosedPoints New()
		{
			vtkSelectEnclosedPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelectEnclosedPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600F660 RID: 63072 RVA: 0x001567D8 File Offset: 0x001549D8
		public vtkSelectEnclosedPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F661 RID: 63073 RVA: 0x0015681C File Offset: 0x00154A1C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F662 RID: 63074
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectEnclosedPoints_CheckSurfaceOff_01(HandleRef pThis);

		/// <summary>
		/// Specify whether to check the surface for closure. If on, then the
		/// algorithm first checks to see if the surface is closed and manifold.
		/// </summary>
		// Token: 0x0600F663 RID: 63075 RVA: 0x00156827 File Offset: 0x00154A27
		public virtual void CheckSurfaceOff()
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_CheckSurfaceOff_01(base.GetCppThis());
		}

		// Token: 0x0600F664 RID: 63076
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectEnclosedPoints_CheckSurfaceOn_02(HandleRef pThis);

		/// <summary>
		/// Specify whether to check the surface for closure. If on, then the
		/// algorithm first checks to see if the surface is closed and manifold.
		/// </summary>
		// Token: 0x0600F665 RID: 63077 RVA: 0x00156836 File Offset: 0x00154A36
		public virtual void CheckSurfaceOn()
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_CheckSurfaceOn_02(base.GetCppThis());
		}

		// Token: 0x0600F666 RID: 63078
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectEnclosedPoints_Complete_03(HandleRef pThis);

		/// <summary>
		/// This is a backdoor that can be used to test many points for containment.
		/// First initialize the instance, then repeated calls to IsInsideSurface()
		/// can be used without rebuilding the search structures. The Complete()
		/// method releases memory.
		/// </summary>
		// Token: 0x0600F667 RID: 63079 RVA: 0x00156845 File Offset: 0x00154A45
		public void Complete()
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_Complete_03(base.GetCppThis());
		}

		// Token: 0x0600F668 RID: 63080
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectEnclosedPoints_GetCheckSurface_04(HandleRef pThis);

		/// <summary>
		/// Specify whether to check the surface for closure. If on, then the
		/// algorithm first checks to see if the surface is closed and manifold.
		/// </summary>
		// Token: 0x0600F669 RID: 63081 RVA: 0x00156854 File Offset: 0x00154A54
		public virtual int GetCheckSurface()
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_GetCheckSurface_04(base.GetCppThis());
		}

		// Token: 0x0600F66A RID: 63082
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectEnclosedPoints_GetInsideOut_05(HandleRef pThis);

		/// <summary>
		/// By default, points inside the surface are marked inside or sent to
		/// the output. If InsideOut is on, then the points outside the surface
		/// are marked inside.
		/// </summary>
		// Token: 0x0600F66B RID: 63083 RVA: 0x00156874 File Offset: 0x00154A74
		public virtual int GetInsideOut()
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_GetInsideOut_05(base.GetCppThis());
		}

		// Token: 0x0600F66C RID: 63084
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSelectEnclosedPoints_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600F66D RID: 63085 RVA: 0x00156894 File Offset: 0x00154A94
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600F66E RID: 63086
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSelectEnclosedPoints_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600F66F RID: 63087 RVA: 0x001568B4 File Offset: 0x00154AB4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600F670 RID: 63088
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectEnclosedPoints_GetSurface_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a pointer to the enclosing surface.
		/// </summary>
		// Token: 0x0600F671 RID: 63089 RVA: 0x001568D0 File Offset: 0x00154AD0
		public vtkPolyData GetSurface()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_GetSurface_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0600F672 RID: 63090
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectEnclosedPoints_GetSurface_09(HandleRef pThis, HandleRef sourceInfo, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a pointer to the enclosing surface.
		/// </summary>
		// Token: 0x0600F673 RID: 63091 RVA: 0x00156940 File Offset: 0x00154B40
		public vtkPolyData GetSurface(vtkInformationVector sourceInfo)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_GetSurface_09(base.GetCppThis(), (sourceInfo == null) ? default(HandleRef) : sourceInfo.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0600F674 RID: 63092
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSelectEnclosedPoints_GetTolerance_10(HandleRef pThis);

		/// <summary>
		/// Specify the tolerance on the intersection. The tolerance is expressed as
		/// a fraction of the diagonal of the bounding box of the enclosing surface.
		/// </summary>
		// Token: 0x0600F675 RID: 63093 RVA: 0x001569C8 File Offset: 0x00154BC8
		public virtual double GetTolerance()
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_GetTolerance_10(base.GetCppThis());
		}

		// Token: 0x0600F676 RID: 63094
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSelectEnclosedPoints_GetToleranceMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Specify the tolerance on the intersection. The tolerance is expressed as
		/// a fraction of the diagonal of the bounding box of the enclosing surface.
		/// </summary>
		// Token: 0x0600F677 RID: 63095 RVA: 0x001569E8 File Offset: 0x00154BE8
		public virtual double GetToleranceMaxValue()
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_GetToleranceMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0600F678 RID: 63096
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSelectEnclosedPoints_GetToleranceMinValue_12(HandleRef pThis);

		/// <summary>
		/// Specify the tolerance on the intersection. The tolerance is expressed as
		/// a fraction of the diagonal of the bounding box of the enclosing surface.
		/// </summary>
		// Token: 0x0600F679 RID: 63097 RVA: 0x00156A08 File Offset: 0x00154C08
		public virtual double GetToleranceMinValue()
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_GetToleranceMinValue_12(base.GetCppThis());
		}

		// Token: 0x0600F67A RID: 63098
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectEnclosedPoints_Initialize_13(HandleRef pThis, HandleRef surface);

		/// <summary>
		/// This is a backdoor that can be used to test many points for containment.
		/// First initialize the instance, then repeated calls to IsInsideSurface()
		/// can be used without rebuilding the search structures. The Complete()
		/// method releases memory.
		/// </summary>
		// Token: 0x0600F67B RID: 63099 RVA: 0x00156A28 File Offset: 0x00154C28
		public void Initialize(vtkPolyData surface)
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_Initialize_13(base.GetCppThis(), (surface == null) ? default(HandleRef) : surface.GetCppThis());
		}

		// Token: 0x0600F67C RID: 63100
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectEnclosedPoints_InsideOutOff_14(HandleRef pThis);

		/// <summary>
		/// By default, points inside the surface are marked inside or sent to
		/// the output. If InsideOut is on, then the points outside the surface
		/// are marked inside.
		/// </summary>
		// Token: 0x0600F67D RID: 63101 RVA: 0x00156A57 File Offset: 0x00154C57
		public virtual void InsideOutOff()
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_InsideOutOff_14(base.GetCppThis());
		}

		// Token: 0x0600F67E RID: 63102
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectEnclosedPoints_InsideOutOn_15(HandleRef pThis);

		/// <summary>
		/// By default, points inside the surface are marked inside or sent to
		/// the output. If InsideOut is on, then the points outside the surface
		/// are marked inside.
		/// </summary>
		// Token: 0x0600F67F RID: 63103 RVA: 0x00156A66 File Offset: 0x00154C66
		public virtual void InsideOutOn()
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_InsideOutOn_15(base.GetCppThis());
		}

		// Token: 0x0600F680 RID: 63104
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectEnclosedPoints_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600F681 RID: 63105 RVA: 0x00156A78 File Offset: 0x00154C78
		public override int IsA(string type)
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0600F682 RID: 63106
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectEnclosedPoints_IsInside_17(HandleRef pThis, long inputPtId);

		/// <summary>
		/// Query an input point id as to whether it is inside or outside. Note that
		/// the result requires that the filter execute first.
		/// </summary>
		// Token: 0x0600F683 RID: 63107 RVA: 0x00156A98 File Offset: 0x00154C98
		public int IsInside(long inputPtId)
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_IsInside_17(base.GetCppThis(), inputPtId);
		}

		// Token: 0x0600F684 RID: 63108
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectEnclosedPoints_IsInsideSurface_18(HandleRef pThis, IntPtr x);

		/// <summary>
		/// This is a backdoor that can be used to test many points for containment.
		/// First initialize the instance, then repeated calls to IsInsideSurface()
		/// can be used without rebuilding the search structures. The Complete()
		/// method releases memory.
		/// </summary>
		// Token: 0x0600F685 RID: 63109 RVA: 0x00156AB8 File Offset: 0x00154CB8
		public int IsInsideSurface(IntPtr x)
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_IsInsideSurface_18(base.GetCppThis(), x);
		}

		// Token: 0x0600F686 RID: 63110
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectEnclosedPoints_IsInsideSurface_19(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// This is a backdoor that can be used to test many points for containment.
		/// First initialize the instance, then repeated calls to IsInsideSurface()
		/// can be used without rebuilding the search structures. The Complete()
		/// method releases memory.
		/// </summary>
		// Token: 0x0600F687 RID: 63111 RVA: 0x00156AD8 File Offset: 0x00154CD8
		public int IsInsideSurface(double x, double y, double z)
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_IsInsideSurface_19(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600F688 RID: 63112
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectEnclosedPoints_IsInsideSurface_20(IntPtr x, HandleRef surface, IntPtr bds, double length, double tol, HandleRef locator, HandleRef cellIds, HandleRef genCell, vtkIntersectionCounter counter, HandleRef poole, long seqIdx);

		/// <summary>
		/// A static method for determining whether a point is inside a
		/// surface. This is the heart of the algorithm and is thread safe. The user
		/// must provide an input point x, the enclosing surface, the bounds of the
		/// enclosing surface, the diagonal length of the enclosing surface, an
		/// intersection tolerance, a cell locator for the surface, and two working
		/// objects (cellIds, genCell) to support computation. Finally, in threaded
		/// execution, generating random numbers is hard, so a precomputed random
		/// sequence can be provided with an index into the sequence.
		/// </summary>
		// Token: 0x0600F689 RID: 63113 RVA: 0x00156AFC File Offset: 0x00154CFC
		public static int IsInsideSurface(IntPtr x, vtkPolyData surface, IntPtr bds, double length, double tol, vtkAbstractCellLocator locator, vtkIdList cellIds, vtkGenericCell genCell, vtkIntersectionCounter counter, vtkRandomPool poole, long seqIdx)
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_IsInsideSurface_20(x, (surface == null) ? default(HandleRef) : surface.GetCppThis(), bds, length, tol, (locator == null) ? default(HandleRef) : locator.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis(), (genCell == null) ? default(HandleRef) : genCell.GetCppThis(), counter, (poole == null) ? default(HandleRef) : poole.GetCppThis(), seqIdx);
		}

		// Token: 0x0600F68A RID: 63114
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectEnclosedPoints_IsSurfaceClosed_21(HandleRef surface);

		/// <summary>
		/// A static method for determining whether a surface is closed. Provide as input
		/// a vtkPolyData. The method returns &gt;0 is the surface is closed and manifold.
		/// </summary>
		// Token: 0x0600F68B RID: 63115 RVA: 0x00156B90 File Offset: 0x00154D90
		public static int IsSurfaceClosed(vtkPolyData surface)
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_IsSurfaceClosed_21((surface == null) ? default(HandleRef) : surface.GetCppThis());
		}

		// Token: 0x0600F68C RID: 63116
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectEnclosedPoints_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600F68D RID: 63117 RVA: 0x00156BC0 File Offset: 0x00154DC0
		public new static int IsTypeOf(string type)
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_IsTypeOf_22(type);
		}

		// Token: 0x0600F68E RID: 63118
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectEnclosedPoints_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600F68F RID: 63119 RVA: 0x00156BDC File Offset: 0x00154DDC
		public new vtkSelectEnclosedPoints NewInstance()
		{
			vtkSelectEnclosedPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelectEnclosedPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F690 RID: 63120
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectEnclosedPoints_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600F691 RID: 63121 RVA: 0x00156C38 File Offset: 0x00154E38
		public new static vtkSelectEnclosedPoints SafeDownCast(vtkObjectBase o)
		{
			vtkSelectEnclosedPoints vtkSelectEnclosedPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelectEnclosedPoints = (vtkSelectEnclosedPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelectEnclosedPoints.Register(null);
				}
			}
			return vtkSelectEnclosedPoints;
		}

		// Token: 0x0600F692 RID: 63122
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectEnclosedPoints_SetCheckSurface_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to check the surface for closure. If on, then the
		/// algorithm first checks to see if the surface is closed and manifold.
		/// </summary>
		// Token: 0x0600F693 RID: 63123 RVA: 0x00156CB7 File Offset: 0x00154EB7
		public virtual void SetCheckSurface(int _arg)
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_SetCheckSurface_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F694 RID: 63124
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectEnclosedPoints_SetInsideOut_27(HandleRef pThis, int _arg);

		/// <summary>
		/// By default, points inside the surface are marked inside or sent to
		/// the output. If InsideOut is on, then the points outside the surface
		/// are marked inside.
		/// </summary>
		// Token: 0x0600F695 RID: 63125 RVA: 0x00156CC7 File Offset: 0x00154EC7
		public virtual void SetInsideOut(int _arg)
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_SetInsideOut_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F696 RID: 63126
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectEnclosedPoints_SetSurfaceConnection_28(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Set the surface to be used to test for containment. Two methods are
		/// provided: one directly for vtkPolyData, and one for the output of a
		/// filter.
		/// </summary>
		// Token: 0x0600F697 RID: 63127 RVA: 0x00156CD8 File Offset: 0x00154ED8
		public void SetSurfaceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_SetSurfaceConnection_28(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x0600F698 RID: 63128
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectEnclosedPoints_SetSurfaceData_29(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Set the surface to be used to test for containment. Two methods are
		/// provided: one directly for vtkPolyData, and one for the output of a
		/// filter.
		/// </summary>
		// Token: 0x0600F699 RID: 63129 RVA: 0x00156D08 File Offset: 0x00154F08
		public void SetSurfaceData(vtkPolyData pd)
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_SetSurfaceData_29(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600F69A RID: 63130
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectEnclosedPoints_SetTolerance_30(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the tolerance on the intersection. The tolerance is expressed as
		/// a fraction of the diagonal of the bounding box of the enclosing surface.
		/// </summary>
		// Token: 0x0600F69B RID: 63131 RVA: 0x00156D37 File Offset: 0x00154F37
		public virtual void SetTolerance(double _arg)
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_SetTolerance_30(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011ED RID: 4589
		public new const string MRFullTypeName = "Kitware.VTK.vtkSelectEnclosedPoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011EE RID: 4590
		public new static readonly string MRClassNameKey = "class vtkSelectEnclosedPoints";
	}
}
