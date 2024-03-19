using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStructuredDataPlaneCutter
	/// </summary>
	/// <remarks>
	///    fast plane cutting of vtkImageData/vtkRectilinearGrid/vtkStructuredGrid
	///
	/// vtkStructuredDataPlaneCutter is a specialized filter that cuts an input
	/// vtkImageData/vtkRectilinearGrid/vtkStructuredGrid. The filter is designed for
	/// high speed.
	///
	/// To use this filter you must specify an input vtkImageData/vtkRectilinearGrid/
	/// vtkStructuredGrid and a plane to cut with.
	///
	/// This algorithm is linear with regard to cells. Tt may build (in a preprocessing step)
	/// a spatial search structure that accelerates the plane cuts. The search structure, which
	/// is typically a sphere tree, is used to quickly cull candidate cells.
	///
	/// @warning
	/// This filter delegates to vtkFlyingEdgesPlaneCutter for vtkImageData if you DON'T
	/// want to generate polygons.
	///
	/// @warning
	/// This class is templated. It may run slower than serial execution if the code
	/// is not optimized during compilation. Build in Release or ReleaseWithDebugInfo.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCutter vtkPlaneCutter vtkFlyingEdgesPlaneCutter vtk3DLinearGridPlaneCutter
	/// vtkPolyDataPlaneCutter
	/// </seealso>
	// Token: 0x0200099E RID: 2462
	public class vtkStructuredDataPlaneCutter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019B51 RID: 105297 RVA: 0x0023BB49 File Offset: 0x00239D49
		static vtkStructuredDataPlaneCutter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredDataPlaneCutter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredDataPlaneCutter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019B52 RID: 105298 RVA: 0x0023BB71 File Offset: 0x00239D71
		public vtkStructuredDataPlaneCutter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019B53 RID: 105299
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredDataPlaneCutter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x06019B54 RID: 105300 RVA: 0x0023BB80 File Offset: 0x00239D80
		public new static vtkStructuredDataPlaneCutter New()
		{
			vtkStructuredDataPlaneCutter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredDataPlaneCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x06019B55 RID: 105301 RVA: 0x0023BBD4 File Offset: 0x00239DD4
		public vtkStructuredDataPlaneCutter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019B56 RID: 105302 RVA: 0x0023BC18 File Offset: 0x00239E18
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019B57 RID: 105303
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredDataPlaneCutter_BuildHierarchyOff_01(HandleRef pThis);

		/// <summary>
		/// Indicate whether to build tree hierarchy. Computing the tree
		/// hierarchy can take some time on the first computation but if
		/// the input does not change, the computation of all further
		/// slice will be faster.
		///
		/// Default is on.
		/// </summary>
		// Token: 0x06019B58 RID: 105304 RVA: 0x0023BC23 File Offset: 0x00239E23
		public virtual void BuildHierarchyOff()
		{
			vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_BuildHierarchyOff_01(base.GetCppThis());
		}

		// Token: 0x06019B59 RID: 105305
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredDataPlaneCutter_BuildHierarchyOn_02(HandleRef pThis);

		/// <summary>
		/// Indicate whether to build tree hierarchy. Computing the tree
		/// hierarchy can take some time on the first computation but if
		/// the input does not change, the computation of all further
		/// slice will be faster.
		///
		/// Default is on.
		/// </summary>
		// Token: 0x06019B5A RID: 105306 RVA: 0x0023BC32 File Offset: 0x00239E32
		public virtual void BuildHierarchyOn()
		{
			vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_BuildHierarchyOn_02(base.GetCppThis());
		}

		// Token: 0x06019B5B RID: 105307
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredDataPlaneCutter_BuildTreeOff_03(HandleRef pThis);

		/// <summary>
		/// Indicate whether to build the sphere tree. Computing the sphere
		/// will take some time on the first computation
		/// but if the input does not change, the computation of all further
		/// slice will be much faster.
		///
		/// Default is on.
		/// </summary>
		// Token: 0x06019B5C RID: 105308 RVA: 0x0023BC41 File Offset: 0x00239E41
		public virtual void BuildTreeOff()
		{
			vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_BuildTreeOff_03(base.GetCppThis());
		}

		// Token: 0x06019B5D RID: 105309
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredDataPlaneCutter_BuildTreeOn_04(HandleRef pThis);

		/// <summary>
		/// Indicate whether to build the sphere tree. Computing the sphere
		/// will take some time on the first computation
		/// but if the input does not change, the computation of all further
		/// slice will be much faster.
		///
		/// Default is on.
		/// </summary>
		// Token: 0x06019B5E RID: 105310 RVA: 0x0023BC50 File Offset: 0x00239E50
		public virtual void BuildTreeOn()
		{
			vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_BuildTreeOn_04(base.GetCppThis());
		}

		// Token: 0x06019B5F RID: 105311
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredDataPlaneCutter_ComputeNormalsOff_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. The normal generated is simply the
		/// cut plane normal.
		///
		/// Default is off.
		/// </summary>
		// Token: 0x06019B60 RID: 105312 RVA: 0x0023BC5F File Offset: 0x00239E5F
		public virtual void ComputeNormalsOff()
		{
			vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_ComputeNormalsOff_05(base.GetCppThis());
		}

		// Token: 0x06019B61 RID: 105313
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredDataPlaneCutter_ComputeNormalsOn_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. The normal generated is simply the
		/// cut plane normal.
		///
		/// Default is off.
		/// </summary>
		// Token: 0x06019B62 RID: 105314 RVA: 0x0023BC6E File Offset: 0x00239E6E
		public virtual void ComputeNormalsOn()
		{
			vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_ComputeNormalsOn_06(base.GetCppThis());
		}

		// Token: 0x06019B63 RID: 105315
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredDataPlaneCutter_GeneratePolygonsOff_07(HandleRef pThis);

		/// <summary>
		/// Indicate whether to generate polygons instead of triangles
		///
		/// Default is on.
		/// </summary>
		// Token: 0x06019B64 RID: 105316 RVA: 0x0023BC7D File Offset: 0x00239E7D
		public virtual void GeneratePolygonsOff()
		{
			vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_GeneratePolygonsOff_07(base.GetCppThis());
		}

		// Token: 0x06019B65 RID: 105317
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredDataPlaneCutter_GeneratePolygonsOn_08(HandleRef pThis);

		/// <summary>
		/// Indicate whether to generate polygons instead of triangles
		///
		/// Default is on.
		/// </summary>
		// Token: 0x06019B66 RID: 105318 RVA: 0x0023BC8C File Offset: 0x00239E8C
		public virtual void GeneratePolygonsOn()
		{
			vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_GeneratePolygonsOn_08(base.GetCppThis());
		}

		// Token: 0x06019B67 RID: 105319
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkStructuredDataPlaneCutter_GetBatchSize_09(HandleRef pThis);

		/// <summary>
		/// Specify the number of input cells in a batch, where a batch defines
		/// a subset of the input cells operated on during threaded
		/// execution. Generally this is only used for debugging or performance
		/// studies (since batch size affects the thread workload).
		///
		/// Default is 1000.
		/// </summary>
		// Token: 0x06019B68 RID: 105320 RVA: 0x0023BC9C File Offset: 0x00239E9C
		public virtual uint GetBatchSize()
		{
			return vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_GetBatchSize_09(base.GetCppThis());
		}

		// Token: 0x06019B69 RID: 105321
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkStructuredDataPlaneCutter_GetBatchSizeMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Specify the number of input cells in a batch, where a batch defines
		/// a subset of the input cells operated on during threaded
		/// execution. Generally this is only used for debugging or performance
		/// studies (since batch size affects the thread workload).
		///
		/// Default is 1000.
		/// </summary>
		// Token: 0x06019B6A RID: 105322 RVA: 0x0023BCBC File Offset: 0x00239EBC
		public virtual uint GetBatchSizeMaxValue()
		{
			return vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_GetBatchSizeMaxValue_10(base.GetCppThis());
		}

		// Token: 0x06019B6B RID: 105323
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkStructuredDataPlaneCutter_GetBatchSizeMinValue_11(HandleRef pThis);

		/// <summary>
		/// Specify the number of input cells in a batch, where a batch defines
		/// a subset of the input cells operated on during threaded
		/// execution. Generally this is only used for debugging or performance
		/// studies (since batch size affects the thread workload).
		///
		/// Default is 1000.
		/// </summary>
		// Token: 0x06019B6C RID: 105324 RVA: 0x0023BCDC File Offset: 0x00239EDC
		public virtual uint GetBatchSizeMinValue()
		{
			return vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_GetBatchSizeMinValue_11(base.GetCppThis());
		}

		// Token: 0x06019B6D RID: 105325
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStructuredDataPlaneCutter_GetBuildHierarchy_12(HandleRef pThis);

		/// <summary>
		/// Indicate whether to build tree hierarchy. Computing the tree
		/// hierarchy can take some time on the first computation but if
		/// the input does not change, the computation of all further
		/// slice will be faster.
		///
		/// Default is on.
		/// </summary>
		// Token: 0x06019B6E RID: 105326 RVA: 0x0023BCFC File Offset: 0x00239EFC
		public virtual bool GetBuildHierarchy()
		{
			return vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_GetBuildHierarchy_12(base.GetCppThis()) != 0;
		}

		// Token: 0x06019B6F RID: 105327
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStructuredDataPlaneCutter_GetBuildTree_13(HandleRef pThis);

		/// <summary>
		/// Indicate whether to build the sphere tree. Computing the sphere
		/// will take some time on the first computation
		/// but if the input does not change, the computation of all further
		/// slice will be much faster.
		///
		/// Default is on.
		/// </summary>
		// Token: 0x06019B70 RID: 105328 RVA: 0x0023BD24 File Offset: 0x00239F24
		public virtual bool GetBuildTree()
		{
			return vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_GetBuildTree_13(base.GetCppThis()) != 0;
		}

		// Token: 0x06019B71 RID: 105329
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStructuredDataPlaneCutter_GetComputeNormals_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. The normal generated is simply the
		/// cut plane normal.
		///
		/// Default is off.
		/// </summary>
		// Token: 0x06019B72 RID: 105330 RVA: 0x0023BD4C File Offset: 0x00239F4C
		public virtual bool GetComputeNormals()
		{
			return vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_GetComputeNormals_14(base.GetCppThis()) != 0;
		}

		// Token: 0x06019B73 RID: 105331
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStructuredDataPlaneCutter_GetGeneratePolygons_15(HandleRef pThis);

		/// <summary>
		/// Indicate whether to generate polygons instead of triangles
		///
		/// Default is on.
		/// </summary>
		// Token: 0x06019B74 RID: 105332 RVA: 0x0023BD74 File Offset: 0x00239F74
		public virtual bool GetGeneratePolygons()
		{
			return vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_GetGeneratePolygons_15(base.GetCppThis()) != 0;
		}

		// Token: 0x06019B75 RID: 105333
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStructuredDataPlaneCutter_GetInterpolateAttributes_16(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate attribute data. Note that both cell data
		/// and point data is interpolated and output
		///
		/// Default is on.
		/// </summary>
		// Token: 0x06019B76 RID: 105334 RVA: 0x0023BD9C File Offset: 0x00239F9C
		public virtual bool GetInterpolateAttributes()
		{
			return vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_GetInterpolateAttributes_16(base.GetCppThis()) != 0;
		}

		// Token: 0x06019B77 RID: 105335
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkStructuredDataPlaneCutter_GetMTime_17(HandleRef pThis);

		/// <summary>
		/// The modified time depends on the delegated cut plane.
		/// </summary>
		// Token: 0x06019B78 RID: 105336 RVA: 0x0023BDC4 File Offset: 0x00239FC4
		public override ulong GetMTime()
		{
			return vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_GetMTime_17(base.GetCppThis());
		}

		// Token: 0x06019B79 RID: 105337
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredDataPlaneCutter_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x06019B7A RID: 105338 RVA: 0x0023BDE4 File Offset: 0x00239FE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x06019B7B RID: 105339
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredDataPlaneCutter_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x06019B7C RID: 105340 RVA: 0x0023BE04 File Offset: 0x0023A004
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x06019B7D RID: 105341
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredDataPlaneCutter_GetOutputPointsPrecision_20(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019B7E RID: 105342 RVA: 0x0023BE20 File Offset: 0x0023A020
		public virtual int GetOutputPointsPrecision()
		{
			return vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_GetOutputPointsPrecision_20(base.GetCppThis());
		}

		// Token: 0x06019B7F RID: 105343
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredDataPlaneCutter_GetOutputPointsPrecisionMaxValue_21(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019B80 RID: 105344 RVA: 0x0023BE40 File Offset: 0x0023A040
		public virtual int GetOutputPointsPrecisionMaxValue()
		{
			return vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_GetOutputPointsPrecisionMaxValue_21(base.GetCppThis());
		}

		// Token: 0x06019B81 RID: 105345
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredDataPlaneCutter_GetOutputPointsPrecisionMinValue_22(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019B82 RID: 105346 RVA: 0x0023BE60 File Offset: 0x0023A060
		public virtual int GetOutputPointsPrecisionMinValue()
		{
			return vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_GetOutputPointsPrecisionMinValue_22(base.GetCppThis());
		}

		// Token: 0x06019B83 RID: 105347
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredDataPlaneCutter_GetPlane_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the plane (an implicit function) to perform the cutting. The
		/// definition of the plane (its origin and normal) is controlled via this
		/// instance of vtkPlane.
		/// </summary>
		// Token: 0x06019B84 RID: 105348 RVA: 0x0023BE80 File Offset: 0x0023A080
		public virtual vtkPlane GetPlane()
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_GetPlane_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlane = (vtkPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlane.Register(null);
				}
			}
			return vtkPlane;
		}

		// Token: 0x06019B85 RID: 105349
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredDataPlaneCutter_GetSphereTree_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the sphere tree object. If defined, the sphere tree will not be built
		/// unless the dataset has changed.
		/// </summary>
		// Token: 0x06019B86 RID: 105350 RVA: 0x0023BEF0 File Offset: 0x0023A0F0
		public virtual vtkSphereTree GetSphereTree()
		{
			vtkSphereTree vtkSphereTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_GetSphereTree_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphereTree = (vtkSphereTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphereTree.Register(null);
				}
			}
			return vtkSphereTree;
		}

		// Token: 0x06019B87 RID: 105351
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredDataPlaneCutter_InterpolateAttributesOff_25(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate attribute data. Note that both cell data
		/// and point data is interpolated and output
		///
		/// Default is on.
		/// </summary>
		// Token: 0x06019B88 RID: 105352 RVA: 0x0023BF5F File Offset: 0x0023A15F
		public virtual void InterpolateAttributesOff()
		{
			vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_InterpolateAttributesOff_25(base.GetCppThis());
		}

		// Token: 0x06019B89 RID: 105353
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredDataPlaneCutter_InterpolateAttributesOn_26(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate attribute data. Note that both cell data
		/// and point data is interpolated and output
		///
		/// Default is on.
		/// </summary>
		// Token: 0x06019B8A RID: 105354 RVA: 0x0023BF6E File Offset: 0x0023A16E
		public virtual void InterpolateAttributesOn()
		{
			vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_InterpolateAttributesOn_26(base.GetCppThis());
		}

		// Token: 0x06019B8B RID: 105355
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredDataPlaneCutter_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x06019B8C RID: 105356 RVA: 0x0023BF80 File Offset: 0x0023A180
		public override int IsA(string type)
		{
			return vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x06019B8D RID: 105357
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredDataPlaneCutter_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x06019B8E RID: 105358 RVA: 0x0023BFA0 File Offset: 0x0023A1A0
		public new static int IsTypeOf(string type)
		{
			return vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_IsTypeOf_28(type);
		}

		// Token: 0x06019B8F RID: 105359
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredDataPlaneCutter_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x06019B90 RID: 105360 RVA: 0x0023BFBC File Offset: 0x0023A1BC
		public new vtkStructuredDataPlaneCutter NewInstance()
		{
			vtkStructuredDataPlaneCutter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredDataPlaneCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019B91 RID: 105361
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredDataPlaneCutter_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x06019B92 RID: 105362 RVA: 0x0023C018 File Offset: 0x0023A218
		public new static vtkStructuredDataPlaneCutter SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredDataPlaneCutter vtkStructuredDataPlaneCutter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredDataPlaneCutter = (vtkStructuredDataPlaneCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredDataPlaneCutter.Register(null);
				}
			}
			return vtkStructuredDataPlaneCutter;
		}

		// Token: 0x06019B93 RID: 105363
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredDataPlaneCutter_SetBatchSize_32(HandleRef pThis, uint _arg);

		/// <summary>
		/// Specify the number of input cells in a batch, where a batch defines
		/// a subset of the input cells operated on during threaded
		/// execution. Generally this is only used for debugging or performance
		/// studies (since batch size affects the thread workload).
		///
		/// Default is 1000.
		/// </summary>
		// Token: 0x06019B94 RID: 105364 RVA: 0x0023C097 File Offset: 0x0023A297
		public virtual void SetBatchSize(uint _arg)
		{
			vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_SetBatchSize_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06019B95 RID: 105365
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredDataPlaneCutter_SetBuildHierarchy_33(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to build tree hierarchy. Computing the tree
		/// hierarchy can take some time on the first computation but if
		/// the input does not change, the computation of all further
		/// slice will be faster.
		///
		/// Default is on.
		/// </summary>
		// Token: 0x06019B96 RID: 105366 RVA: 0x0023C0A7 File Offset: 0x0023A2A7
		public virtual void SetBuildHierarchy(bool _arg)
		{
			vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_SetBuildHierarchy_33(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019B97 RID: 105367
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredDataPlaneCutter_SetBuildTree_34(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to build the sphere tree. Computing the sphere
		/// will take some time on the first computation
		/// but if the input does not change, the computation of all further
		/// slice will be much faster.
		///
		/// Default is on.
		/// </summary>
		// Token: 0x06019B98 RID: 105368 RVA: 0x0023C0BF File Offset: 0x0023A2BF
		public virtual void SetBuildTree(bool _arg)
		{
			vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_SetBuildTree_34(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019B99 RID: 105369
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredDataPlaneCutter_SetComputeNormals_35(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the computation of normals. The normal generated is simply the
		/// cut plane normal.
		///
		/// Default is off.
		/// </summary>
		// Token: 0x06019B9A RID: 105370 RVA: 0x0023C0D7 File Offset: 0x0023A2D7
		public virtual void SetComputeNormals(bool _arg)
		{
			vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_SetComputeNormals_35(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019B9B RID: 105371
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredDataPlaneCutter_SetGeneratePolygons_36(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to generate polygons instead of triangles
		///
		/// Default is on.
		/// </summary>
		// Token: 0x06019B9C RID: 105372 RVA: 0x0023C0EF File Offset: 0x0023A2EF
		public virtual void SetGeneratePolygons(bool _arg)
		{
			vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_SetGeneratePolygons_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019B9D RID: 105373
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredDataPlaneCutter_SetInterpolateAttributes_37(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to interpolate attribute data. Note that both cell data
		/// and point data is interpolated and output
		///
		/// Default is on.
		/// </summary>
		// Token: 0x06019B9E RID: 105374 RVA: 0x0023C107 File Offset: 0x0023A307
		public virtual void SetInterpolateAttributes(bool _arg)
		{
			vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_SetInterpolateAttributes_37(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019B9F RID: 105375
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredDataPlaneCutter_SetOutputPointsPrecision_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019BA0 RID: 105376 RVA: 0x0023C11F File Offset: 0x0023A31F
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_SetOutputPointsPrecision_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06019BA1 RID: 105377
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredDataPlaneCutter_SetPlane_39(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the plane (an implicit function) to perform the cutting. The
		/// definition of the plane (its origin and normal) is controlled via this
		/// instance of vtkPlane.
		/// </summary>
		// Token: 0x06019BA2 RID: 105378 RVA: 0x0023C130 File Offset: 0x0023A330
		public virtual void SetPlane(vtkPlane arg0)
		{
			vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_SetPlane_39(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06019BA3 RID: 105379
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredDataPlaneCutter_SetSphereTree_40(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the sphere tree object. If defined, the sphere tree will not be built
		/// unless the dataset has changed.
		/// </summary>
		// Token: 0x06019BA4 RID: 105380 RVA: 0x0023C160 File Offset: 0x0023A360
		public virtual void SetSphereTree(vtkSphereTree arg0)
		{
			vtkStructuredDataPlaneCutter.vtkStructuredDataPlaneCutter_SetSphereTree_40(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C01 RID: 7169
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredDataPlaneCutter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C02 RID: 7170
		public new static readonly string MRClassNameKey = "class vtkStructuredDataPlaneCutter";
	}
}
