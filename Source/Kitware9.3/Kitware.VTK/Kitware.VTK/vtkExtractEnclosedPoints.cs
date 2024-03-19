using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractEnclosedPoints
	/// </summary>
	/// <remarks>
	///    extract points inside of a closed polygonal surface
	///
	/// vtkExtractEnclosedPoints is a filter that evaluates all the input points
	/// to determine whether they are contained within an enclosing surface. Those
	/// within the surface are sent to the output. The enclosing surface is
	/// specified through a second input to the filter.
	///
	/// Note: as a derived class of vtkPointCloudFilter, additional methods are
	/// available for generating an in/out mask, and also extracting points
	/// outside of the enclosing surface.
	///
	/// @warning
	/// The filter assumes that the surface is closed and manifold. A boolean flag
	/// can be set to force the filter to first check whether this is true. If false,
	/// all points will be marked outside. Note that if this check is not performed
	/// and the surface is not closed, the results are undefined.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// @warning
	/// The filter vtkSelectEnclosedPoints marks points as to in/out of the
	/// enclosing surface, and operates on any dataset type, producing an output
	/// dataset of the same type as the input. Then, thresholding and masking
	/// filters can be used to extract parts of the dataset. This filter
	/// (vtkExtractEnclosedPoints) is meant to operate on point clouds represented
	/// by vtkPolyData, and produces vtkPolyData on output, so it is more
	/// efficient for point processing. Note that this filter delegates many of
	/// its methods to vtkSelectEnclosedPoints.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSelectEnclosedPoints vtkExtractPoints
	/// </seealso>
	// Token: 0x0200043F RID: 1087
	public class vtkExtractEnclosedPoints : vtkPointCloudFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CB2B RID: 52011 RVA: 0x0011A87B File Offset: 0x00118A7B
		static vtkExtractEnclosedPoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractEnclosedPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractEnclosedPoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CB2C RID: 52012 RVA: 0x0011A8A3 File Offset: 0x00118AA3
		public vtkExtractEnclosedPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CB2D RID: 52013
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractEnclosedPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600CB2E RID: 52014 RVA: 0x0011A8B4 File Offset: 0x00118AB4
		public new static vtkExtractEnclosedPoints New()
		{
			vtkExtractEnclosedPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractEnclosedPoints.vtkExtractEnclosedPoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractEnclosedPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600CB2F RID: 52015 RVA: 0x0011A908 File Offset: 0x00118B08
		public vtkExtractEnclosedPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractEnclosedPoints.vtkExtractEnclosedPoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CB30 RID: 52016 RVA: 0x0011A94C File Offset: 0x00118B4C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CB31 RID: 52017
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractEnclosedPoints_CheckSurfaceOff_01(HandleRef pThis);

		/// <summary>
		/// Specify whether to check the surface for closure. If on, then the
		/// algorithm first checks to see if the surface is closed and manifold.
		/// </summary>
		// Token: 0x0600CB32 RID: 52018 RVA: 0x0011A957 File Offset: 0x00118B57
		public virtual void CheckSurfaceOff()
		{
			vtkExtractEnclosedPoints.vtkExtractEnclosedPoints_CheckSurfaceOff_01(base.GetCppThis());
		}

		// Token: 0x0600CB33 RID: 52019
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractEnclosedPoints_CheckSurfaceOn_02(HandleRef pThis);

		/// <summary>
		/// Specify whether to check the surface for closure. If on, then the
		/// algorithm first checks to see if the surface is closed and manifold.
		/// </summary>
		// Token: 0x0600CB34 RID: 52020 RVA: 0x0011A966 File Offset: 0x00118B66
		public virtual void CheckSurfaceOn()
		{
			vtkExtractEnclosedPoints.vtkExtractEnclosedPoints_CheckSurfaceOn_02(base.GetCppThis());
		}

		// Token: 0x0600CB35 RID: 52021
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractEnclosedPoints_GetCheckSurface_03(HandleRef pThis);

		/// <summary>
		/// Specify whether to check the surface for closure. If on, then the
		/// algorithm first checks to see if the surface is closed and manifold.
		/// </summary>
		// Token: 0x0600CB36 RID: 52022 RVA: 0x0011A978 File Offset: 0x00118B78
		public virtual int GetCheckSurface()
		{
			return vtkExtractEnclosedPoints.vtkExtractEnclosedPoints_GetCheckSurface_03(base.GetCppThis());
		}

		// Token: 0x0600CB37 RID: 52023
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractEnclosedPoints_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600CB38 RID: 52024 RVA: 0x0011A998 File Offset: 0x00118B98
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractEnclosedPoints.vtkExtractEnclosedPoints_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600CB39 RID: 52025
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractEnclosedPoints_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600CB3A RID: 52026 RVA: 0x0011A9B8 File Offset: 0x00118BB8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractEnclosedPoints.vtkExtractEnclosedPoints_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600CB3B RID: 52027
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractEnclosedPoints_GetSurface_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a pointer to the enclosing surface.
		/// </summary>
		// Token: 0x0600CB3C RID: 52028 RVA: 0x0011A9D4 File Offset: 0x00118BD4
		public vtkPolyData GetSurface()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractEnclosedPoints.vtkExtractEnclosedPoints_GetSurface_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600CB3D RID: 52029
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractEnclosedPoints_GetSurface_07(HandleRef pThis, HandleRef sourceInfo, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a pointer to the enclosing surface.
		/// </summary>
		// Token: 0x0600CB3E RID: 52030 RVA: 0x0011AA44 File Offset: 0x00118C44
		public vtkPolyData GetSurface(vtkInformationVector sourceInfo)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractEnclosedPoints.vtkExtractEnclosedPoints_GetSurface_07(base.GetCppThis(), (sourceInfo == null) ? default(HandleRef) : sourceInfo.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600CB3F RID: 52031
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkExtractEnclosedPoints_GetTolerance_08(HandleRef pThis);

		/// <summary>
		/// Specify the tolerance on the intersection. The tolerance is expressed as
		/// a fraction of the diagonal of the bounding box of the enclosing surface.
		/// </summary>
		// Token: 0x0600CB40 RID: 52032 RVA: 0x0011AACC File Offset: 0x00118CCC
		public virtual double GetTolerance()
		{
			return vtkExtractEnclosedPoints.vtkExtractEnclosedPoints_GetTolerance_08(base.GetCppThis());
		}

		// Token: 0x0600CB41 RID: 52033
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkExtractEnclosedPoints_GetToleranceMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Specify the tolerance on the intersection. The tolerance is expressed as
		/// a fraction of the diagonal of the bounding box of the enclosing surface.
		/// </summary>
		// Token: 0x0600CB42 RID: 52034 RVA: 0x0011AAEC File Offset: 0x00118CEC
		public virtual double GetToleranceMaxValue()
		{
			return vtkExtractEnclosedPoints.vtkExtractEnclosedPoints_GetToleranceMaxValue_09(base.GetCppThis());
		}

		// Token: 0x0600CB43 RID: 52035
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkExtractEnclosedPoints_GetToleranceMinValue_10(HandleRef pThis);

		/// <summary>
		/// Specify the tolerance on the intersection. The tolerance is expressed as
		/// a fraction of the diagonal of the bounding box of the enclosing surface.
		/// </summary>
		// Token: 0x0600CB44 RID: 52036 RVA: 0x0011AB0C File Offset: 0x00118D0C
		public virtual double GetToleranceMinValue()
		{
			return vtkExtractEnclosedPoints.vtkExtractEnclosedPoints_GetToleranceMinValue_10(base.GetCppThis());
		}

		// Token: 0x0600CB45 RID: 52037
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractEnclosedPoints_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600CB46 RID: 52038 RVA: 0x0011AB2C File Offset: 0x00118D2C
		public override int IsA(string type)
		{
			return vtkExtractEnclosedPoints.vtkExtractEnclosedPoints_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600CB47 RID: 52039
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractEnclosedPoints_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600CB48 RID: 52040 RVA: 0x0011AB4C File Offset: 0x00118D4C
		public new static int IsTypeOf(string type)
		{
			return vtkExtractEnclosedPoints.vtkExtractEnclosedPoints_IsTypeOf_12(type);
		}

		// Token: 0x0600CB49 RID: 52041
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractEnclosedPoints_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600CB4A RID: 52042 RVA: 0x0011AB68 File Offset: 0x00118D68
		public new vtkExtractEnclosedPoints NewInstance()
		{
			vtkExtractEnclosedPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractEnclosedPoints.vtkExtractEnclosedPoints_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractEnclosedPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CB4B RID: 52043
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractEnclosedPoints_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600CB4C RID: 52044 RVA: 0x0011ABC4 File Offset: 0x00118DC4
		public new static vtkExtractEnclosedPoints SafeDownCast(vtkObjectBase o)
		{
			vtkExtractEnclosedPoints vtkExtractEnclosedPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractEnclosedPoints.vtkExtractEnclosedPoints_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractEnclosedPoints = (vtkExtractEnclosedPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractEnclosedPoints.Register(null);
				}
			}
			return vtkExtractEnclosedPoints;
		}

		// Token: 0x0600CB4D RID: 52045
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractEnclosedPoints_SetCheckSurface_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to check the surface for closure. If on, then the
		/// algorithm first checks to see if the surface is closed and manifold.
		/// </summary>
		// Token: 0x0600CB4E RID: 52046 RVA: 0x0011AC43 File Offset: 0x00118E43
		public virtual void SetCheckSurface(int _arg)
		{
			vtkExtractEnclosedPoints.vtkExtractEnclosedPoints_SetCheckSurface_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CB4F RID: 52047
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractEnclosedPoints_SetSurfaceConnection_17(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Set the surface to be used to test for containment. Two methods are
		/// provided: one directly for vtkPolyData, and one for the output of a
		/// filter.
		/// </summary>
		// Token: 0x0600CB50 RID: 52048 RVA: 0x0011AC54 File Offset: 0x00118E54
		public void SetSurfaceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkExtractEnclosedPoints.vtkExtractEnclosedPoints_SetSurfaceConnection_17(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x0600CB51 RID: 52049
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractEnclosedPoints_SetSurfaceData_18(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Set the surface to be used to test for containment. Two methods are
		/// provided: one directly for vtkPolyData, and one for the output of a
		/// filter.
		/// </summary>
		// Token: 0x0600CB52 RID: 52050 RVA: 0x0011AC84 File Offset: 0x00118E84
		public void SetSurfaceData(vtkPolyData pd)
		{
			vtkExtractEnclosedPoints.vtkExtractEnclosedPoints_SetSurfaceData_18(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600CB53 RID: 52051
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractEnclosedPoints_SetTolerance_19(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the tolerance on the intersection. The tolerance is expressed as
		/// a fraction of the diagonal of the bounding box of the enclosing surface.
		/// </summary>
		// Token: 0x0600CB54 RID: 52052 RVA: 0x0011ACB3 File Offset: 0x00118EB3
		public virtual void SetTolerance(double _arg)
		{
			vtkExtractEnclosedPoints.vtkExtractEnclosedPoints_SetTolerance_19(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F0B RID: 3851
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractEnclosedPoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F0C RID: 3852
		public new static readonly string MRClassNameKey = "class vtkExtractEnclosedPoints";
	}
}
