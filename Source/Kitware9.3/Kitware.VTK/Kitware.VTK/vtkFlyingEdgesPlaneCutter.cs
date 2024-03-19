using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFlyingEdgesPlaneCutter
	/// </summary>
	/// <remarks>
	///    cut a volume with a plane and generate a
	/// polygonal cut surface
	///
	/// vtkFlyingEdgesPlaneCutter is a specialization of the FlyingEdges algorithm
	/// to cut a volume with a single plane. It is designed for performance and
	/// an exploratory, fast workflow. The filter handles oriented volumes.
	///
	/// This algorithm is not only fast because it uses flying edges, but also
	/// because it plays some "tricks" during processing. For example, rather
	/// than evaluate the cut (plane) function on all volume points like vtkCutter
	/// and its ilk do, this algorithm intersects the volume x-edges against the
	/// plane to (potentially) generate the single intersection point. It then
	/// quickly classifies the voxel edges as above, below, or straddling the cut
	/// plane. Thus the number of plane evaluations is greatly reduced.
	///
	/// For more information see vtkFlyingEdges3D and/or the paper "Flying Edges:
	/// A High-Performance Scalable Isocontouring Algorithm" by Schroeder,
	/// Maynard, Geveci. Proc. of LDAV 2015. Chicago, IL.
	///
	/// The filter interpolates the input scalar field across the vtkPlane provided.
	/// If additional point and cell attribute data is to be interpolated, enable
	/// InterpolateAttributes.
	///
	/// @warning
	/// This filter is specialized to 3D volumes. This implementation can produce
	/// degenerate triangles (i.e., zero-area triangles).
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFlyingEdges2D vtkFlyingEdges3D
	/// </seealso>
	// Token: 0x0200096B RID: 2411
	public class vtkFlyingEdgesPlaneCutter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060191C6 RID: 102854 RVA: 0x002300DC File Offset: 0x0022E2DC
		static vtkFlyingEdgesPlaneCutter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFlyingEdgesPlaneCutter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFlyingEdgesPlaneCutter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060191C7 RID: 102855 RVA: 0x00230104 File Offset: 0x0022E304
		public vtkFlyingEdgesPlaneCutter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060191C8 RID: 102856
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFlyingEdgesPlaneCutter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x060191C9 RID: 102857 RVA: 0x00230114 File Offset: 0x0022E314
		public new static vtkFlyingEdgesPlaneCutter New()
		{
			vtkFlyingEdgesPlaneCutter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFlyingEdgesPlaneCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x060191CA RID: 102858 RVA: 0x00230168 File Offset: 0x0022E368
		public vtkFlyingEdgesPlaneCutter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060191CB RID: 102859 RVA: 0x002301AC File Offset: 0x0022E3AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060191CC RID: 102860
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdgesPlaneCutter_ComputeNormalsOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. The normal generated is simply the
		/// cut plane normal. By default this is disabled.
		/// </summary>
		// Token: 0x060191CD RID: 102861 RVA: 0x002301B7 File Offset: 0x0022E3B7
		public virtual void ComputeNormalsOff()
		{
			vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_ComputeNormalsOff_01(base.GetCppThis());
		}

		// Token: 0x060191CE RID: 102862
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdgesPlaneCutter_ComputeNormalsOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. The normal generated is simply the
		/// cut plane normal. By default this is disabled.
		/// </summary>
		// Token: 0x060191CF RID: 102863 RVA: 0x002301C6 File Offset: 0x0022E3C6
		public virtual void ComputeNormalsOn()
		{
			vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_ComputeNormalsOn_02(base.GetCppThis());
		}

		// Token: 0x060191D0 RID: 102864
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlyingEdgesPlaneCutter_GetArrayComponent_03(HandleRef pThis);

		/// <summary>
		/// Set/get which component of the point data scalar array to contour on; defaults to 0.
		/// </summary>
		// Token: 0x060191D1 RID: 102865 RVA: 0x002301D8 File Offset: 0x0022E3D8
		public virtual int GetArrayComponent()
		{
			return vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_GetArrayComponent_03(base.GetCppThis());
		}

		// Token: 0x060191D2 RID: 102866
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlyingEdgesPlaneCutter_GetComputeNormals_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. The normal generated is simply the
		/// cut plane normal. By default this is disabled.
		/// </summary>
		// Token: 0x060191D3 RID: 102867 RVA: 0x002301F8 File Offset: 0x0022E3F8
		public virtual int GetComputeNormals()
		{
			return vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_GetComputeNormals_04(base.GetCppThis());
		}

		// Token: 0x060191D4 RID: 102868
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlyingEdgesPlaneCutter_GetInterpolateAttributes_05(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate additional point data (beyond the point
		/// scalars which are always interpolated) and cell attribute data. By
		/// default this is disabled (for reasons of performance).
		/// </summary>
		// Token: 0x060191D5 RID: 102869 RVA: 0x00230218 File Offset: 0x0022E418
		public virtual int GetInterpolateAttributes()
		{
			return vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_GetInterpolateAttributes_05(base.GetCppThis());
		}

		// Token: 0x060191D6 RID: 102870
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkFlyingEdgesPlaneCutter_GetMTime_06(HandleRef pThis);

		/// <summary>
		/// The modified time depends on the delegated cut plane.
		/// </summary>
		// Token: 0x060191D7 RID: 102871 RVA: 0x00230238 File Offset: 0x0022E438
		public override ulong GetMTime()
		{
			return vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_GetMTime_06(base.GetCppThis());
		}

		// Token: 0x060191D8 RID: 102872
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFlyingEdgesPlaneCutter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x060191D9 RID: 102873 RVA: 0x00230258 File Offset: 0x0022E458
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x060191DA RID: 102874
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFlyingEdgesPlaneCutter_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x060191DB RID: 102875 RVA: 0x00230278 File Offset: 0x0022E478
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x060191DC RID: 102876
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFlyingEdgesPlaneCutter_GetPlane_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the plane (an implicit function) to perform the cutting. The
		/// definition of the plane (its origin and normal) is controlled via this
		/// instance of vtkPlane.
		/// </summary>
		// Token: 0x060191DD RID: 102877 RVA: 0x00230294 File Offset: 0x0022E494
		public virtual vtkPlane GetPlane()
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_GetPlane_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060191DE RID: 102878
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdgesPlaneCutter_InterpolateAttributesOff_10(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate additional point data (beyond the point
		/// scalars which are always interpolated) and cell attribute data. By
		/// default this is disabled (for reasons of performance).
		/// </summary>
		// Token: 0x060191DF RID: 102879 RVA: 0x00230303 File Offset: 0x0022E503
		public virtual void InterpolateAttributesOff()
		{
			vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_InterpolateAttributesOff_10(base.GetCppThis());
		}

		// Token: 0x060191E0 RID: 102880
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdgesPlaneCutter_InterpolateAttributesOn_11(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate additional point data (beyond the point
		/// scalars which are always interpolated) and cell attribute data. By
		/// default this is disabled (for reasons of performance).
		/// </summary>
		// Token: 0x060191E1 RID: 102881 RVA: 0x00230312 File Offset: 0x0022E512
		public virtual void InterpolateAttributesOn()
		{
			vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_InterpolateAttributesOn_11(base.GetCppThis());
		}

		// Token: 0x060191E2 RID: 102882
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlyingEdgesPlaneCutter_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x060191E3 RID: 102883 RVA: 0x00230324 File Offset: 0x0022E524
		public override int IsA(string type)
		{
			return vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x060191E4 RID: 102884
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlyingEdgesPlaneCutter_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x060191E5 RID: 102885 RVA: 0x00230344 File Offset: 0x0022E544
		public new static int IsTypeOf(string type)
		{
			return vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_IsTypeOf_13(type);
		}

		// Token: 0x060191E6 RID: 102886
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFlyingEdgesPlaneCutter_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x060191E7 RID: 102887 RVA: 0x00230360 File Offset: 0x0022E560
		public new vtkFlyingEdgesPlaneCutter NewInstance()
		{
			vtkFlyingEdgesPlaneCutter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFlyingEdgesPlaneCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060191E8 RID: 102888
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFlyingEdgesPlaneCutter_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x060191E9 RID: 102889 RVA: 0x002303BC File Offset: 0x0022E5BC
		public new static vtkFlyingEdgesPlaneCutter SafeDownCast(vtkObjectBase o)
		{
			vtkFlyingEdgesPlaneCutter vtkFlyingEdgesPlaneCutter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFlyingEdgesPlaneCutter = (vtkFlyingEdgesPlaneCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFlyingEdgesPlaneCutter.Register(null);
				}
			}
			return vtkFlyingEdgesPlaneCutter;
		}

		// Token: 0x060191EA RID: 102890
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdgesPlaneCutter_SetArrayComponent_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get which component of the point data scalar array to contour on; defaults to 0.
		/// </summary>
		// Token: 0x060191EB RID: 102891 RVA: 0x0023043B File Offset: 0x0022E63B
		public virtual void SetArrayComponent(int _arg)
		{
			vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_SetArrayComponent_17(base.GetCppThis(), _arg);
		}

		// Token: 0x060191EC RID: 102892
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdgesPlaneCutter_SetComputeNormals_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of normals. The normal generated is simply the
		/// cut plane normal. By default this is disabled.
		/// </summary>
		// Token: 0x060191ED RID: 102893 RVA: 0x0023044B File Offset: 0x0022E64B
		public virtual void SetComputeNormals(int _arg)
		{
			vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_SetComputeNormals_18(base.GetCppThis(), _arg);
		}

		// Token: 0x060191EE RID: 102894
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdgesPlaneCutter_SetInterpolateAttributes_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether to interpolate additional point data (beyond the point
		/// scalars which are always interpolated) and cell attribute data. By
		/// default this is disabled (for reasons of performance).
		/// </summary>
		// Token: 0x060191EF RID: 102895 RVA: 0x0023045B File Offset: 0x0022E65B
		public virtual void SetInterpolateAttributes(int _arg)
		{
			vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_SetInterpolateAttributes_19(base.GetCppThis(), _arg);
		}

		// Token: 0x060191F0 RID: 102896
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdgesPlaneCutter_SetPlane_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the plane (an implicit function) to perform the cutting. The
		/// definition of the plane (its origin and normal) is controlled via this
		/// instance of vtkPlane.
		/// </summary>
		// Token: 0x060191F1 RID: 102897 RVA: 0x0023046C File Offset: 0x0022E66C
		public virtual void SetPlane(vtkPlane arg0)
		{
			vtkFlyingEdgesPlaneCutter.vtkFlyingEdgesPlaneCutter_SetPlane_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B8F RID: 7055
		public new const string MRFullTypeName = "Kitware.VTK.vtkFlyingEdgesPlaneCutter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B90 RID: 7056
		public new static readonly string MRClassNameKey = "class vtkFlyingEdgesPlaneCutter";
	}
}
