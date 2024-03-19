using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDeformPointSet
	/// </summary>
	/// <remarks>
	///    use a control polyhedron to deform an input vtkPointSet
	///
	/// vtkDeformPointSet is a filter that uses a control polyhdron to deform an
	/// input dataset of type vtkPointSet. The control polyhedron (or mesh) must
	/// be a closed, manifold surface.
	///
	/// The filter executes as follows. In initial pipeline execution, the control
	/// mesh and input vtkPointSet are assumed in undeformed position, and an
	/// initial set of interpolation weights are computed for each point in the
	/// vtkPointSet (one interpolation weight value for each point in the control
	/// mesh). The filter then stores these interpolation weights after filter
	/// execution. The next time the filter executes, assuming that the number of
	/// points/cells in the control mesh and vtkPointSet have not changed, the
	/// points in the vtkPointSet are recomputed based on the original
	/// weights. Hence if the control mesh has been deformed, it will in turn
	/// cause deformation in the vtkPointSet. This can be used to animate or edit
	/// the geometry of the vtkPointSet.
	///
	/// @warning
	/// Note that a set of interpolation weights per point in the vtkPointSet is
	/// maintained. The number of interpolation weights is the number of points
	/// in the control mesh. Hence keep the control mesh small in size or a n^2
	/// data explostion will occur.
	///
	/// @warning
	/// The filter maintains interpolation weights between executions (after the
	/// initial execution pass computes the interpolation weights). You can
	/// explicitly cause the filter to reinitialize by setting the
	/// InitializeWeights boolean to true. By default, the filter will execute and
	/// then set InitializeWeights to false.
	///
	/// @warning
	/// This work was motivated by the work of Tao Ju et al in "Mesh Value Coordinates
	/// for Closed Triangular Meshes." The MVC algorithm is currently used to generate
	/// interpolation weights. However, in the future this filter may be extended to
	/// provide other interpolation functions.
	///
	/// @warning
	/// A final note: point data and cell data are passed from the input to the output.
	/// Only the point coordinates of the input vtkPointSet are modified.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMeanValueCoordinatesInterpolator vtkProbePolyhedron vtkPolyhedron
	/// </seealso>
	// Token: 0x02000891 RID: 2193
	public class vtkDeformPointSet : vtkPointSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016C4C RID: 93260 RVA: 0x00200453 File Offset: 0x001FE653
		static vtkDeformPointSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDeformPointSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDeformPointSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016C4D RID: 93261 RVA: 0x0020047B File Offset: 0x001FE67B
		public vtkDeformPointSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016C4E RID: 93262
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDeformPointSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiable (i.e., concrete) class.
		/// </summary>
		// Token: 0x06016C4F RID: 93263 RVA: 0x0020048C File Offset: 0x001FE68C
		public new static vtkDeformPointSet New()
		{
			vtkDeformPointSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDeformPointSet.vtkDeformPointSet_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDeformPointSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiable (i.e., concrete) class.
		/// </summary>
		// Token: 0x06016C50 RID: 93264 RVA: 0x002004E0 File Offset: 0x001FE6E0
		public vtkDeformPointSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDeformPointSet.vtkDeformPointSet_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016C51 RID: 93265 RVA: 0x00200524 File Offset: 0x001FE724
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016C52 RID: 93266
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDeformPointSet_GetControlMeshData_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the control mesh to deform the input vtkPointSet. The control
		/// mesh must be a closed, non-self-intersecting, manifold mesh.
		/// </summary>
		// Token: 0x06016C53 RID: 93267 RVA: 0x00200530 File Offset: 0x001FE730
		public vtkPolyData GetControlMeshData()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDeformPointSet.vtkDeformPointSet_GetControlMeshData_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06016C54 RID: 93268
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDeformPointSet_GetInitializeWeights_02(HandleRef pThis);

		/// <summary>
		/// Specify whether to regenerate interpolation weights or not. Initially
		/// the filter will reexecute no matter what this flag is set to (initial
		/// weights must be computed). Also, this flag is ignored if the number of
		/// input points/cells or the number of control mesh points/cells changes
		/// between executions. Thus flag is used to force reexecution and
		/// recomputation of weights.
		/// </summary>
		// Token: 0x06016C55 RID: 93269 RVA: 0x002005A0 File Offset: 0x001FE7A0
		public virtual int GetInitializeWeights()
		{
			return vtkDeformPointSet.vtkDeformPointSet_GetInitializeWeights_02(base.GetCppThis());
		}

		// Token: 0x06016C56 RID: 93270
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDeformPointSet_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiable (i.e., concrete) class.
		/// </summary>
		// Token: 0x06016C57 RID: 93271 RVA: 0x002005C0 File Offset: 0x001FE7C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDeformPointSet.vtkDeformPointSet_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06016C58 RID: 93272
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDeformPointSet_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiable (i.e., concrete) class.
		/// </summary>
		// Token: 0x06016C59 RID: 93273 RVA: 0x002005E0 File Offset: 0x001FE7E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDeformPointSet.vtkDeformPointSet_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06016C5A RID: 93274
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDeformPointSet_InitializeWeightsOff_05(HandleRef pThis);

		/// <summary>
		/// Specify whether to regenerate interpolation weights or not. Initially
		/// the filter will reexecute no matter what this flag is set to (initial
		/// weights must be computed). Also, this flag is ignored if the number of
		/// input points/cells or the number of control mesh points/cells changes
		/// between executions. Thus flag is used to force reexecution and
		/// recomputation of weights.
		/// </summary>
		// Token: 0x06016C5B RID: 93275 RVA: 0x002005FA File Offset: 0x001FE7FA
		public virtual void InitializeWeightsOff()
		{
			vtkDeformPointSet.vtkDeformPointSet_InitializeWeightsOff_05(base.GetCppThis());
		}

		// Token: 0x06016C5C RID: 93276
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDeformPointSet_InitializeWeightsOn_06(HandleRef pThis);

		/// <summary>
		/// Specify whether to regenerate interpolation weights or not. Initially
		/// the filter will reexecute no matter what this flag is set to (initial
		/// weights must be computed). Also, this flag is ignored if the number of
		/// input points/cells or the number of control mesh points/cells changes
		/// between executions. Thus flag is used to force reexecution and
		/// recomputation of weights.
		/// </summary>
		// Token: 0x06016C5D RID: 93277 RVA: 0x00200609 File Offset: 0x001FE809
		public virtual void InitializeWeightsOn()
		{
			vtkDeformPointSet.vtkDeformPointSet_InitializeWeightsOn_06(base.GetCppThis());
		}

		// Token: 0x06016C5E RID: 93278
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDeformPointSet_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiable (i.e., concrete) class.
		/// </summary>
		// Token: 0x06016C5F RID: 93279 RVA: 0x00200618 File Offset: 0x001FE818
		public override int IsA(string type)
		{
			return vtkDeformPointSet.vtkDeformPointSet_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06016C60 RID: 93280
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDeformPointSet_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiable (i.e., concrete) class.
		/// </summary>
		// Token: 0x06016C61 RID: 93281 RVA: 0x00200638 File Offset: 0x001FE838
		public new static int IsTypeOf(string type)
		{
			return vtkDeformPointSet.vtkDeformPointSet_IsTypeOf_08(type);
		}

		// Token: 0x06016C62 RID: 93282
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDeformPointSet_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiable (i.e., concrete) class.
		/// </summary>
		// Token: 0x06016C63 RID: 93283 RVA: 0x00200654 File Offset: 0x001FE854
		public new vtkDeformPointSet NewInstance()
		{
			vtkDeformPointSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDeformPointSet.vtkDeformPointSet_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDeformPointSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016C64 RID: 93284
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDeformPointSet_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiable (i.e., concrete) class.
		/// </summary>
		// Token: 0x06016C65 RID: 93285 RVA: 0x002006B0 File Offset: 0x001FE8B0
		public new static vtkDeformPointSet SafeDownCast(vtkObjectBase o)
		{
			vtkDeformPointSet vtkDeformPointSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDeformPointSet.vtkDeformPointSet_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDeformPointSet = (vtkDeformPointSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDeformPointSet.Register(null);
				}
			}
			return vtkDeformPointSet;
		}

		// Token: 0x06016C66 RID: 93286
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDeformPointSet_SetControlMeshConnection_12(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify the point locations used to probe input. Any geometry
		/// can be used. New style. Equivalent to SetInputConnection(1, algOutput).
		/// </summary>
		// Token: 0x06016C67 RID: 93287 RVA: 0x00200730 File Offset: 0x001FE930
		public void SetControlMeshConnection(vtkAlgorithmOutput algOutput)
		{
			vtkDeformPointSet.vtkDeformPointSet_SetControlMeshConnection_12(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x06016C68 RID: 93288
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDeformPointSet_SetControlMeshData_13(HandleRef pThis, HandleRef controlMesh);

		/// <summary>
		/// Specify the control mesh to deform the input vtkPointSet. The control
		/// mesh must be a closed, non-self-intersecting, manifold mesh.
		/// </summary>
		// Token: 0x06016C69 RID: 93289 RVA: 0x00200760 File Offset: 0x001FE960
		public void SetControlMeshData(vtkPolyData controlMesh)
		{
			vtkDeformPointSet.vtkDeformPointSet_SetControlMeshData_13(base.GetCppThis(), (controlMesh == null) ? default(HandleRef) : controlMesh.GetCppThis());
		}

		// Token: 0x06016C6A RID: 93290
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDeformPointSet_SetInitializeWeights_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to regenerate interpolation weights or not. Initially
		/// the filter will reexecute no matter what this flag is set to (initial
		/// weights must be computed). Also, this flag is ignored if the number of
		/// input points/cells or the number of control mesh points/cells changes
		/// between executions. Thus flag is used to force reexecution and
		/// recomputation of weights.
		/// </summary>
		// Token: 0x06016C6B RID: 93291 RVA: 0x0020078F File Offset: 0x001FE98F
		public virtual void SetInitializeWeights(int _arg)
		{
			vtkDeformPointSet.vtkDeformPointSet_SetInitializeWeights_14(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001983 RID: 6531
		public new const string MRFullTypeName = "Kitware.VTK.vtkDeformPointSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001984 RID: 6532
		public new static readonly string MRClassNameKey = "class vtkDeformPointSet";
	}
}
