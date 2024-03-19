using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSphereTree
	/// </summary>
	/// <remarks>
	///    class to build and traverse sphere trees
	///
	/// vtkSphereTree is a helper class used to build and traverse sphere
	/// trees. Various types of trees can be constructed for different VTK
	/// dataset types, as well well as different approaches to organize
	/// the tree into hierarchies.
	///
	/// Typically building a complete sphere tree consists of two parts: 1)
	/// creating spheres for each cell in the dataset, then 2) creating an
	/// organizing hierarchy. The structure of the hierarchy varies depending on
	/// the topological characteristics of the dataset.
	///
	/// Once the tree is constructed, various geometric operations are available
	/// for quickly selecting cells based on sphere tree operations; for example,
	/// process all cells intersecting a plane (i.e., use the sphere tree to identify
	/// candidate cells for plane intersection).
	///
	/// This class does not necessarily create optimal sphere trees because
	/// some of its requirements (fast build time, provide simple reference
	/// code, a single bounding sphere per cell, etc.) precludes optimal
	/// performance. It is also oriented to computing on cells versus the
	/// classic problem of collision detection for polygonal models. For
	/// more information you want to read Gareth Bradshaw's PhD thesis
	/// "Bounding Volume Hierarchies for Level-of-Detail Collision
	/// Handling" which does a nice job of laying out the challenges and
	/// important algorithms relative to sphere trees and BVH (bounding
	/// volume hierarchies).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSphereTreeFilter vtkPlaneCutter
	/// </seealso>
	// Token: 0x020009E5 RID: 2533
	public class vtkSphereTree : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A5B8 RID: 107960 RVA: 0x0024975B File Offset: 0x0024795B
		static vtkSphereTree()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSphereTree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphereTree"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A5B9 RID: 107961 RVA: 0x00249783 File Offset: 0x00247983
		public vtkSphereTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A5BA RID: 107962
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereTree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the sphere tree.
		/// </summary>
		// Token: 0x0601A5BB RID: 107963 RVA: 0x00249794 File Offset: 0x00247994
		public new static vtkSphereTree New()
		{
			vtkSphereTree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereTree.vtkSphereTree_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the sphere tree.
		/// </summary>
		// Token: 0x0601A5BC RID: 107964 RVA: 0x002497E8 File Offset: 0x002479E8
		public vtkSphereTree() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSphereTree.vtkSphereTree_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A5BD RID: 107965 RVA: 0x0024982C File Offset: 0x00247A2C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A5BE RID: 107966
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTree_Build_01(HandleRef pThis);

		/// <summary>
		/// Build the sphere tree (if necessary) from the data set specified. The
		/// build time is recorded so the sphere tree will only build if something has
		/// changed. An alternative method is available to both set the dataset and
		/// then build the sphere tree.
		/// </summary>
		// Token: 0x0601A5BF RID: 107967 RVA: 0x00249837 File Offset: 0x00247A37
		public void Build()
		{
			vtkSphereTree.vtkSphereTree_Build_01(base.GetCppThis());
		}

		// Token: 0x0601A5C0 RID: 107968
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTree_Build_02(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Build the sphere tree (if necessary) from the data set specified. The
		/// build time is recorded so the sphere tree will only build if something has
		/// changed. An alternative method is available to both set the dataset and
		/// then build the sphere tree.
		/// </summary>
		// Token: 0x0601A5C1 RID: 107969 RVA: 0x00249848 File Offset: 0x00247A48
		public void Build(vtkDataSet input)
		{
			vtkSphereTree.vtkSphereTree_Build_02(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0601A5C2 RID: 107970
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTree_BuildHierarchyOff_03(HandleRef pThis);

		/// <summary>
		/// Control whether the tree hierarchy is built. If not, then just
		/// cell spheres are created (one for each cell).
		/// </summary>
		// Token: 0x0601A5C3 RID: 107971 RVA: 0x00249877 File Offset: 0x00247A77
		public virtual void BuildHierarchyOff()
		{
			vtkSphereTree.vtkSphereTree_BuildHierarchyOff_03(base.GetCppThis());
		}

		// Token: 0x0601A5C4 RID: 107972
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTree_BuildHierarchyOn_04(HandleRef pThis);

		/// <summary>
		/// Control whether the tree hierarchy is built. If not, then just
		/// cell spheres are created (one for each cell).
		/// </summary>
		// Token: 0x0601A5C5 RID: 107973 RVA: 0x00249886 File Offset: 0x00247A86
		public virtual void BuildHierarchyOn()
		{
			vtkSphereTree.vtkSphereTree_BuildHierarchyOn_04(base.GetCppThis());
		}

		// Token: 0x0601A5C6 RID: 107974
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSphereTree_GetBuildHierarchy_05(HandleRef pThis);

		/// <summary>
		/// Control whether the tree hierarchy is built. If not, then just
		/// cell spheres are created (one for each cell).
		/// </summary>
		// Token: 0x0601A5C7 RID: 107975 RVA: 0x00249898 File Offset: 0x00247A98
		public virtual bool GetBuildHierarchy()
		{
			return vtkSphereTree.vtkSphereTree_GetBuildHierarchy_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0601A5C8 RID: 107976
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereTree_GetCellSpheres_06(HandleRef pThis);

		/// <summary>
		/// Special methods to retrieve the sphere tree data. This is
		/// generally used for debugging or with filters like
		/// vtkSphereTreeFilter. Both methods return an array of double*
		/// where four doubles represent a sphere (center + radius). In the
		/// first method a sphere per cell is returned. In the second method
		/// the user must also specify a level in the sphere tree (used to
		/// retrieve the hierarchy of the tree). Note that null pointers can
		/// be returned if the request is not consistent with the state of
		/// the sphere tree.
		/// </summary>
		// Token: 0x0601A5C9 RID: 107977 RVA: 0x002498C0 File Offset: 0x00247AC0
		public IntPtr GetCellSpheres()
		{
			return vtkSphereTree.vtkSphereTree_GetCellSpheres_06(base.GetCppThis());
		}

		// Token: 0x0601A5CA RID: 107978
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereTree_GetDataSet_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the dataset from which to build the sphere tree.
		/// </summary>
		// Token: 0x0601A5CB RID: 107979 RVA: 0x002498E0 File Offset: 0x00247AE0
		public virtual vtkDataSet GetDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereTree.vtkSphereTree_GetDataSet_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x0601A5CC RID: 107980
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereTree_GetMaxLevel_08(HandleRef pThis);

		/// <summary>
		/// Specify the maximum number of levels for the tree. By default, the
		/// number of levels is set to ten. If the number of levels is set to one or
		/// less, then no hierarchy is built (i.e., just the spheres for each cell
		/// are created). Note that the actual level of the tree may be less than
		/// this value depending on the number of cells and Resolution factor.
		/// </summary>
		// Token: 0x0601A5CD RID: 107981 RVA: 0x00249950 File Offset: 0x00247B50
		public virtual int GetMaxLevel()
		{
			return vtkSphereTree.vtkSphereTree_GetMaxLevel_08(base.GetCppThis());
		}

		// Token: 0x0601A5CE RID: 107982
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereTree_GetMaxLevelMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Specify the maximum number of levels for the tree. By default, the
		/// number of levels is set to ten. If the number of levels is set to one or
		/// less, then no hierarchy is built (i.e., just the spheres for each cell
		/// are created). Note that the actual level of the tree may be less than
		/// this value depending on the number of cells and Resolution factor.
		/// </summary>
		// Token: 0x0601A5CF RID: 107983 RVA: 0x00249970 File Offset: 0x00247B70
		public virtual int GetMaxLevelMaxValue()
		{
			return vtkSphereTree.vtkSphereTree_GetMaxLevelMaxValue_09(base.GetCppThis());
		}

		// Token: 0x0601A5D0 RID: 107984
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereTree_GetMaxLevelMinValue_10(HandleRef pThis);

		/// <summary>
		/// Specify the maximum number of levels for the tree. By default, the
		/// number of levels is set to ten. If the number of levels is set to one or
		/// less, then no hierarchy is built (i.e., just the spheres for each cell
		/// are created). Note that the actual level of the tree may be less than
		/// this value depending on the number of cells and Resolution factor.
		/// </summary>
		// Token: 0x0601A5D1 RID: 107985 RVA: 0x00249990 File Offset: 0x00247B90
		public virtual int GetMaxLevelMinValue()
		{
			return vtkSphereTree.vtkSphereTree_GetMaxLevelMinValue_10(base.GetCppThis());
		}

		// Token: 0x0601A5D2 RID: 107986
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphereTree_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A5D3 RID: 107987 RVA: 0x002499B0 File Offset: 0x00247BB0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSphereTree.vtkSphereTree_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0601A5D4 RID: 107988
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphereTree_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A5D5 RID: 107989 RVA: 0x002499D0 File Offset: 0x00247BD0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSphereTree.vtkSphereTree_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0601A5D6 RID: 107990
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereTree_GetNumberOfLevels_13(HandleRef pThis);

		/// <summary>
		/// Get the current depth of the sphere tree. This value may change each
		/// time the sphere tree is built and the branching factor (i.e.,
		/// resolution) changes. Note that after building the sphere tree there are
		/// [0,this-&gt;NumberOfLevels) defined levels.
		/// </summary>
		// Token: 0x0601A5D7 RID: 107991 RVA: 0x002499EC File Offset: 0x00247BEC
		public virtual int GetNumberOfLevels()
		{
			return vtkSphereTree.vtkSphereTree_GetNumberOfLevels_13(base.GetCppThis());
		}

		// Token: 0x0601A5D8 RID: 107992
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereTree_GetResolution_14(HandleRef pThis);

		/// <summary>
		/// Sphere tree creation requires gathering spheres into groups. The
		/// Resolution variable is a rough guide to the size of each group (the size
		/// different meanings depending on the type of data (structured versus
		/// unstructured). For example, in 3D structured data, blocks of resolution
		/// Resolution^3 are created. By default the Resolution is three.
		/// </summary>
		// Token: 0x0601A5D9 RID: 107993 RVA: 0x00249A0C File Offset: 0x00247C0C
		public virtual int GetResolution()
		{
			return vtkSphereTree.vtkSphereTree_GetResolution_14(base.GetCppThis());
		}

		// Token: 0x0601A5DA RID: 107994
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereTree_GetResolutionMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Sphere tree creation requires gathering spheres into groups. The
		/// Resolution variable is a rough guide to the size of each group (the size
		/// different meanings depending on the type of data (structured versus
		/// unstructured). For example, in 3D structured data, blocks of resolution
		/// Resolution^3 are created. By default the Resolution is three.
		/// </summary>
		// Token: 0x0601A5DB RID: 107995 RVA: 0x00249A2C File Offset: 0x00247C2C
		public virtual int GetResolutionMaxValue()
		{
			return vtkSphereTree.vtkSphereTree_GetResolutionMaxValue_15(base.GetCppThis());
		}

		// Token: 0x0601A5DC RID: 107996
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereTree_GetResolutionMinValue_16(HandleRef pThis);

		/// <summary>
		/// Sphere tree creation requires gathering spheres into groups. The
		/// Resolution variable is a rough guide to the size of each group (the size
		/// different meanings depending on the type of data (structured versus
		/// unstructured). For example, in 3D structured data, blocks of resolution
		/// Resolution^3 are created. By default the Resolution is three.
		/// </summary>
		// Token: 0x0601A5DD RID: 107997 RVA: 0x00249A4C File Offset: 0x00247C4C
		public virtual int GetResolutionMinValue()
		{
			return vtkSphereTree.vtkSphereTree_GetResolutionMinValue_16(base.GetCppThis());
		}

		// Token: 0x0601A5DE RID: 107998
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereTree_GetTreeSpheres_17(HandleRef pThis, int level, ref long numSpheres);

		/// <summary>
		/// Special methods to retrieve the sphere tree data. This is
		/// generally used for debugging or with filters like
		/// vtkSphereTreeFilter. Both methods return an array of double*
		/// where four doubles represent a sphere (center + radius). In the
		/// first method a sphere per cell is returned. In the second method
		/// the user must also specify a level in the sphere tree (used to
		/// retrieve the hierarchy of the tree). Note that null pointers can
		/// be returned if the request is not consistent with the state of
		/// the sphere tree.
		/// </summary>
		// Token: 0x0601A5DF RID: 107999 RVA: 0x00249A6C File Offset: 0x00247C6C
		public IntPtr GetTreeSpheres(int level, ref long numSpheres)
		{
			return vtkSphereTree.vtkSphereTree_GetTreeSpheres_17(base.GetCppThis(), level, ref numSpheres);
		}

		// Token: 0x0601A5E0 RID: 108000
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereTree_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A5E1 RID: 108001 RVA: 0x00249A90 File Offset: 0x00247C90
		public override int IsA(string type)
		{
			return vtkSphereTree.vtkSphereTree_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0601A5E2 RID: 108002
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereTree_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A5E3 RID: 108003 RVA: 0x00249AB0 File Offset: 0x00247CB0
		public new static int IsTypeOf(string type)
		{
			return vtkSphereTree.vtkSphereTree_IsTypeOf_19(type);
		}

		// Token: 0x0601A5E4 RID: 108004
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereTree_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A5E5 RID: 108005 RVA: 0x00249ACC File Offset: 0x00247CCC
		public new vtkSphereTree NewInstance()
		{
			vtkSphereTree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereTree.vtkSphereTree_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A5E6 RID: 108006
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereTree_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A5E7 RID: 108007 RVA: 0x00249B28 File Offset: 0x00247D28
		public new static vtkSphereTree SafeDownCast(vtkObjectBase o)
		{
			vtkSphereTree vtkSphereTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereTree.vtkSphereTree_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A5E8 RID: 108008
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereTree_SelectLine_23(HandleRef pThis, IntPtr origin, IntPtr ray, ref long numSelected);

		/// <summary>
		/// Methods for cell selection based on a geometric query. Internally
		/// different methods are used depending on the dataset type. The array
		/// returned is set to non-zero for each cell that intersects the geometric
		/// entity. SelectPoint marks all cells with a non-zero value that may
		/// contain a point. SelectLine marks all cells that may intersect an
		/// infinite line. SelectPlane marks all cells that may intersect with an
		/// infinite plane.
		/// </summary>
		// Token: 0x0601A5E9 RID: 108009 RVA: 0x00249BA8 File Offset: 0x00247DA8
		public IntPtr SelectLine(IntPtr origin, IntPtr ray, ref long numSelected)
		{
			return vtkSphereTree.vtkSphereTree_SelectLine_23(base.GetCppThis(), origin, ray, ref numSelected);
		}

		// Token: 0x0601A5EA RID: 108010
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTree_SelectLine_24(HandleRef pThis, IntPtr origin, IntPtr ray, HandleRef cellIds);

		/// <summary>
		/// Methods for cell selection based on a geometric query. Internally
		/// different methods are used depending on the dataset type. The method
		/// pupulates an vtkIdList with cell ids that may satisfy the geometric
		/// query (the user must provide a vtkLdList which the methods fill in).
		/// SelectPoint lists all cells with a non-zero value that may contain a
		/// point. SelectLine lists all cells that may intersect an infinite
		/// line. SelectPlane lists all cells that may intersect with an infinite
		/// plane.
		/// </summary>
		// Token: 0x0601A5EB RID: 108011 RVA: 0x00249BCC File Offset: 0x00247DCC
		public void SelectLine(IntPtr origin, IntPtr ray, vtkIdList cellIds)
		{
			vtkSphereTree.vtkSphereTree_SelectLine_24(base.GetCppThis(), origin, ray, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0601A5EC RID: 108012
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereTree_SelectPlane_25(HandleRef pThis, IntPtr origin, IntPtr normal, ref long numSelected);

		/// <summary>
		/// Methods for cell selection based on a geometric query. Internally
		/// different methods are used depending on the dataset type. The array
		/// returned is set to non-zero for each cell that intersects the geometric
		/// entity. SelectPoint marks all cells with a non-zero value that may
		/// contain a point. SelectLine marks all cells that may intersect an
		/// infinite line. SelectPlane marks all cells that may intersect with an
		/// infinite plane.
		/// </summary>
		// Token: 0x0601A5ED RID: 108013 RVA: 0x00249C00 File Offset: 0x00247E00
		public IntPtr SelectPlane(IntPtr origin, IntPtr normal, ref long numSelected)
		{
			return vtkSphereTree.vtkSphereTree_SelectPlane_25(base.GetCppThis(), origin, normal, ref numSelected);
		}

		// Token: 0x0601A5EE RID: 108014
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTree_SelectPlane_26(HandleRef pThis, IntPtr origin, IntPtr normal, HandleRef cellIds);

		/// <summary>
		/// Methods for cell selection based on a geometric query. Internally
		/// different methods are used depending on the dataset type. The method
		/// pupulates an vtkIdList with cell ids that may satisfy the geometric
		/// query (the user must provide a vtkLdList which the methods fill in).
		/// SelectPoint lists all cells with a non-zero value that may contain a
		/// point. SelectLine lists all cells that may intersect an infinite
		/// line. SelectPlane lists all cells that may intersect with an infinite
		/// plane.
		/// </summary>
		// Token: 0x0601A5EF RID: 108015 RVA: 0x00249C24 File Offset: 0x00247E24
		public void SelectPlane(IntPtr origin, IntPtr normal, vtkIdList cellIds)
		{
			vtkSphereTree.vtkSphereTree_SelectPlane_26(base.GetCppThis(), origin, normal, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0601A5F0 RID: 108016
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereTree_SelectPoint_27(HandleRef pThis, IntPtr point, ref long numSelected);

		/// <summary>
		/// Methods for cell selection based on a geometric query. Internally
		/// different methods are used depending on the dataset type. The array
		/// returned is set to non-zero for each cell that intersects the geometric
		/// entity. SelectPoint marks all cells with a non-zero value that may
		/// contain a point. SelectLine marks all cells that may intersect an
		/// infinite line. SelectPlane marks all cells that may intersect with an
		/// infinite plane.
		/// </summary>
		// Token: 0x0601A5F1 RID: 108017 RVA: 0x00249C58 File Offset: 0x00247E58
		public IntPtr SelectPoint(IntPtr point, ref long numSelected)
		{
			return vtkSphereTree.vtkSphereTree_SelectPoint_27(base.GetCppThis(), point, ref numSelected);
		}

		// Token: 0x0601A5F2 RID: 108018
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTree_SelectPoint_28(HandleRef pThis, IntPtr point, HandleRef cellIds);

		/// <summary>
		/// Methods for cell selection based on a geometric query. Internally
		/// different methods are used depending on the dataset type. The method
		/// pupulates an vtkIdList with cell ids that may satisfy the geometric
		/// query (the user must provide a vtkLdList which the methods fill in).
		/// SelectPoint lists all cells with a non-zero value that may contain a
		/// point. SelectLine lists all cells that may intersect an infinite
		/// line. SelectPlane lists all cells that may intersect with an infinite
		/// plane.
		/// </summary>
		// Token: 0x0601A5F3 RID: 108019 RVA: 0x00249C7C File Offset: 0x00247E7C
		public void SelectPoint(IntPtr point, vtkIdList cellIds)
		{
			vtkSphereTree.vtkSphereTree_SelectPoint_28(base.GetCppThis(), point, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0601A5F4 RID: 108020
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTree_SetBuildHierarchy_29(HandleRef pThis, byte _arg);

		/// <summary>
		/// Control whether the tree hierarchy is built. If not, then just
		/// cell spheres are created (one for each cell).
		/// </summary>
		// Token: 0x0601A5F5 RID: 108021 RVA: 0x00249CAC File Offset: 0x00247EAC
		public virtual void SetBuildHierarchy(bool _arg)
		{
			vtkSphereTree.vtkSphereTree_SetBuildHierarchy_29(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601A5F6 RID: 108022
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTree_SetDataSet_30(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the dataset from which to build the sphere tree.
		/// </summary>
		// Token: 0x0601A5F7 RID: 108023 RVA: 0x00249CC4 File Offset: 0x00247EC4
		public virtual void SetDataSet(vtkDataSet arg0)
		{
			vtkSphereTree.vtkSphereTree_SetDataSet_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601A5F8 RID: 108024
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTree_SetMaxLevel_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the maximum number of levels for the tree. By default, the
		/// number of levels is set to ten. If the number of levels is set to one or
		/// less, then no hierarchy is built (i.e., just the spheres for each cell
		/// are created). Note that the actual level of the tree may be less than
		/// this value depending on the number of cells and Resolution factor.
		/// </summary>
		// Token: 0x0601A5F9 RID: 108025 RVA: 0x00249CF3 File Offset: 0x00247EF3
		public virtual void SetMaxLevel(int _arg)
		{
			vtkSphereTree.vtkSphereTree_SetMaxLevel_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A5FA RID: 108026
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTree_SetResolution_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Sphere tree creation requires gathering spheres into groups. The
		/// Resolution variable is a rough guide to the size of each group (the size
		/// different meanings depending on the type of data (structured versus
		/// unstructured). For example, in 3D structured data, blocks of resolution
		/// Resolution^3 are created. By default the Resolution is three.
		/// </summary>
		// Token: 0x0601A5FB RID: 108027 RVA: 0x00249D03 File Offset: 0x00247F03
		public virtual void SetResolution(int _arg)
		{
			vtkSphereTree.vtkSphereTree_SetResolution_32(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C9A RID: 7322
		public new const string MRFullTypeName = "Kitware.VTK.vtkSphereTree";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C9B RID: 7323
		public new static readonly string MRClassNameKey = "class vtkSphereTree";
	}
}
