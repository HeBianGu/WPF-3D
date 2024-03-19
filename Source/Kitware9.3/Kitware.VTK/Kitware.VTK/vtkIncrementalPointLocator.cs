using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkIncrementalPointLocator
	/// </summary>
	/// <remarks>
	///    Abstract class in support of both
	///  point location and point insertion.
	///
	///
	///  Compared to a static point locator for pure location functionalities
	///  through some search structure established from a fixed set of points,
	///  an incremental point locator allows for, in addition, point insertion
	///  capabilities, with the search structure maintaining a dynamically
	///  increasing number of points. There are two incremental point locators,
	///  i.e., vtkPointLocator and vtkIncrementalOctreePointLocator. As opposed
	///  to the uniform bin-based search structure (adopted in vtkPointLocator)
	///  with a fixed spatial resolution, an octree mechanism (employed in
	///  vtkIncrementalOctreePointlocator) resorts to a hierarchy of tree-like
	///  sub-division of the 3D data domain. Thus it enables data-aware multi-
	///  resolution and accordingly accelerated point location as well as point
	///  insertion, particularly when handling a radically imbalanced layout of
	///  points as not uncommon in datasets defined on adaptive meshes. In other
	///  words, vtkIncrementalOctreePointLocator is an octree-based accelerated
	///  implementation of all functionalities of vtkPointLocator.
	///
	/// </remarks>
	/// <seealso>
	///
	///  vtkLocator, vtkIncrementalOctreePointLocator, vtkPointLocator,
	///  vtkMergePoints vtkStaticPointLocator
	/// </seealso>
	// Token: 0x02000421 RID: 1057
	public abstract class vtkIncrementalPointLocator : vtkAbstractPointLocator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C73E RID: 51006 RVA: 0x0011512B File Offset: 0x0011332B
		static vtkIncrementalPointLocator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIncrementalPointLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIncrementalPointLocator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C73F RID: 51007 RVA: 0x00115153 File Offset: 0x00113353
		public vtkIncrementalPointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C740 RID: 51008 RVA: 0x00115161 File Offset: 0x00113361
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C741 RID: 51009
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalPointLocator_FindClosestInsertedPoint_01(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Given a point x assumed to be covered by the search structure, return the
		/// index of the closest point (already inserted to the search structure)
		/// regardless of the associated minimum squared distance relative to the
		/// squared insertion-tolerance distance. This method is used when performing
		/// incremental point insertion. Note -1 indicates that no point is found.
		/// InitPointInsertion() should have been called in advance.
		/// </summary>
		// Token: 0x0600C742 RID: 51010 RVA: 0x0011516C File Offset: 0x0011336C
		public virtual long FindClosestInsertedPoint(IntPtr x)
		{
			return vtkIncrementalPointLocator.vtkIncrementalPointLocator_FindClosestInsertedPoint_01(base.GetCppThis(), x);
		}

		// Token: 0x0600C743 RID: 51011
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalPointLocator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C744 RID: 51012 RVA: 0x0011518C File Offset: 0x0011338C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkIncrementalPointLocator.vtkIncrementalPointLocator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600C745 RID: 51013
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalPointLocator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C746 RID: 51014 RVA: 0x001151AC File Offset: 0x001133AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkIncrementalPointLocator.vtkIncrementalPointLocator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600C747 RID: 51015
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalPointLocator_InitPointInsertion_04(HandleRef pThis, HandleRef newPts, IntPtr bounds);

		/// <summary>
		/// Initialize the point insertion process. newPts is an object, storing 3D
		/// point coordinates, to which incremental point insertion puts coordinates.
		/// It is created and provided by an external VTK class. Argument bounds
		/// represents the spatial bounding box, into which the points fall.
		/// </summary>
		// Token: 0x0600C748 RID: 51016 RVA: 0x001151C8 File Offset: 0x001133C8
		public virtual int InitPointInsertion(vtkPoints newPts, IntPtr bounds)
		{
			return vtkIncrementalPointLocator.vtkIncrementalPointLocator_InitPointInsertion_04(base.GetCppThis(), (newPts == null) ? default(HandleRef) : newPts.GetCppThis(), bounds);
		}

		// Token: 0x0600C749 RID: 51017
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalPointLocator_InitPointInsertion_05(HandleRef pThis, HandleRef newPts, IntPtr bounds, long estSize);

		/// <summary>
		/// Initialize the point insertion process. newPts is an object, storing 3D
		/// point coordinates, to which incremental point insertion puts coordinates.
		/// It is created and provided by an external VTK class. Argument bounds
		/// represents the spatial bounding box, into which the points fall.
		/// </summary>
		// Token: 0x0600C74A RID: 51018 RVA: 0x00115200 File Offset: 0x00113400
		public virtual int InitPointInsertion(vtkPoints newPts, IntPtr bounds, long estSize)
		{
			return vtkIncrementalPointLocator.vtkIncrementalPointLocator_InitPointInsertion_05(base.GetCppThis(), (newPts == null) ? default(HandleRef) : newPts.GetCppThis(), bounds, estSize);
		}

		// Token: 0x0600C74B RID: 51019
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalPointLocator_InsertNextPoint_06(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Insert a given point and return the point index. InitPointInsertion()
		/// should have been called prior to this function. Also, IsInsertedPoint()
		/// should have been called in advance to ensure that the given point has not
		/// been inserted unless point duplication is allowed.
		/// </summary>
		// Token: 0x0600C74C RID: 51020 RVA: 0x00115238 File Offset: 0x00113438
		public virtual long InsertNextPoint(IntPtr x)
		{
			return vtkIncrementalPointLocator.vtkIncrementalPointLocator_InsertNextPoint_06(base.GetCppThis(), x);
		}

		// Token: 0x0600C74D RID: 51021
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalPointLocator_InsertPoint_07(HandleRef pThis, long ptId, IntPtr x);

		/// <summary>
		/// Insert a given point with a specified point index ptId. InitPointInsertion()
		/// should have been called prior to this function. Also, IsInsertedPoint()
		/// should have been called in advance to ensure that the given point has not
		/// been inserted unless point duplication is allowed.
		/// </summary>
		// Token: 0x0600C74E RID: 51022 RVA: 0x00115258 File Offset: 0x00113458
		public virtual void InsertPoint(long ptId, IntPtr x)
		{
			vtkIncrementalPointLocator.vtkIncrementalPointLocator_InsertPoint_07(base.GetCppThis(), ptId, x);
		}

		// Token: 0x0600C74F RID: 51023
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalPointLocator_InsertUniquePoint_08(HandleRef pThis, IntPtr x, ref long ptId);

		/// <summary>
		/// Insert a point unless there has been a duplicate in the search structure.
		/// Return 0 if the point was already in the list, otherwise return 1. If the
		/// point was not in the list, it will be ADDED.  In either case, the id of
		/// the point (newly inserted or not) is returned in the ptId argument.
		/// This method is not thread safe.
		/// </summary>
		// Token: 0x0600C750 RID: 51024 RVA: 0x0011526C File Offset: 0x0011346C
		public virtual int InsertUniquePoint(IntPtr x, ref long ptId)
		{
			return vtkIncrementalPointLocator.vtkIncrementalPointLocator_InsertUniquePoint_08(base.GetCppThis(), x, ref ptId);
		}

		// Token: 0x0600C751 RID: 51025
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalPointLocator_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C752 RID: 51026 RVA: 0x00115290 File Offset: 0x00113490
		public override int IsA(string type)
		{
			return vtkIncrementalPointLocator.vtkIncrementalPointLocator_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600C753 RID: 51027
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalPointLocator_IsInsertedPoint_10(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Determine whether or not a given point has been inserted. Return the id of
		/// the already inserted point if true, else return -1. InitPointInsertion()
		/// should have been called in advance.
		/// </summary>
		// Token: 0x0600C754 RID: 51028 RVA: 0x001152B0 File Offset: 0x001134B0
		public virtual long IsInsertedPoint(double x, double y, double z)
		{
			return vtkIncrementalPointLocator.vtkIncrementalPointLocator_IsInsertedPoint_10(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600C755 RID: 51029
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalPointLocator_IsInsertedPoint_11(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Determine whether or not a given point has been inserted. Return the id of
		/// the already inserted point if true, else return -1. InitPointInsertion()
		/// should have been called in advance.
		/// </summary>
		// Token: 0x0600C756 RID: 51030 RVA: 0x001152D4 File Offset: 0x001134D4
		public virtual long IsInsertedPoint(IntPtr x)
		{
			return vtkIncrementalPointLocator.vtkIncrementalPointLocator_IsInsertedPoint_11(base.GetCppThis(), x);
		}

		// Token: 0x0600C757 RID: 51031
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalPointLocator_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C758 RID: 51032 RVA: 0x001152F4 File Offset: 0x001134F4
		public new static int IsTypeOf(string type)
		{
			return vtkIncrementalPointLocator.vtkIncrementalPointLocator_IsTypeOf_12(type);
		}

		// Token: 0x0600C759 RID: 51033
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalPointLocator_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C75A RID: 51034 RVA: 0x00115310 File Offset: 0x00113510
		public new vtkIncrementalPointLocator NewInstance()
		{
			vtkIncrementalPointLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIncrementalPointLocator.vtkIncrementalPointLocator_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C75B RID: 51035
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalPointLocator_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C75C RID: 51036 RVA: 0x0011536C File Offset: 0x0011356C
		public new static vtkIncrementalPointLocator SafeDownCast(vtkObjectBase o)
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIncrementalPointLocator.vtkIncrementalPointLocator_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ED3 RID: 3795
		public new const string MRFullTypeName = "Kitware.VTK.vtkIncrementalPointLocator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ED4 RID: 3796
		public new static readonly string MRClassNameKey = "class vtkIncrementalPointLocator";
	}
}
