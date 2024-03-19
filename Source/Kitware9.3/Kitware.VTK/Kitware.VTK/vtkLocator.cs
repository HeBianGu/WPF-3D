using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLocator
	/// </summary>
	/// <remarks>
	///    abstract base class for objects that accelerate spatial searches
	///
	/// vtkLocator is an abstract base class for spatial search objects, or
	/// locators. The principle behind locators is that they divide 3-space into
	/// small regions (or "buckets") that can be quickly found in response to
	/// queries about point location, line intersection, or object-object
	/// intersection.
	///
	/// The purpose of this base class is to provide data members and methods
	/// shared by all locators. The GenerateRepresentation() is one such
	/// interesting method.  This method works in conjunction with
	/// vtkLocatorFilter to create polygonal representations for the locator. For
	/// example, if the locator is an OBB tree (i.e., vtkOBBTree.h), then the
	/// representation is a set of one or more oriented bounding boxes, depending
	/// upon the specified level.
	///
	/// Locators typically work as follows. One or more "entities", such as points
	/// or cells, are inserted into the locator structure. These entities are
	/// associated with one or more buckets. Then, when performing geometric
	/// operations, the operations are performed first on the buckets, and then if
	/// the operation tests positive, then on the entities in the bucket. For
	/// example, during collision tests, the locators are collided first to
	/// identify intersecting buckets. If an intersection is found, more expensive
	/// operations are then carried out on the entities in the bucket.
	///
	/// To obtain good performance, locators are often organized in a tree
	/// structure.  In such a structure, there are frequently multiple "levels"
	/// corresponding to different nodes in the tree. So the word level (in the
	/// context of the locator) can be used to specify a particular representation
	/// in the tree.  For example, in an octree (which is a tree with 8 children),
	/// level 0 is the bounding box, or root octant, and level 1 consists of its
	/// eight children.
	///
	/// @warning
	/// There is a concept of static and incremental locators. Static locators are
	/// constructed one time, and then support appropriate queries. Incremental
	/// locators may have data inserted into them over time (e.g., adding new
	/// points during the process of isocontouring).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointLocator vtkCellLocator vtkOBBTree vtkMergePoints
	/// </seealso>
	// Token: 0x0200041F RID: 1055
	public abstract class vtkLocator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C6D6 RID: 50902 RVA: 0x00114973 File Offset: 0x00112B73
		static vtkLocator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLocator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C6D7 RID: 50903 RVA: 0x0011499B File Offset: 0x00112B9B
		public vtkLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C6D8 RID: 50904 RVA: 0x001149A9 File Offset: 0x00112BA9
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C6D9 RID: 50905
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLocator_AutomaticOff_01(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether locator depth/resolution of locator is computed
		/// automatically from average number of entities in bucket. If not set,
		/// there will be an explicit method to control the construction of the
		/// locator (found in the subclass).
		/// </summary>
		// Token: 0x0600C6DA RID: 50906 RVA: 0x001149B4 File Offset: 0x00112BB4
		public virtual void AutomaticOff()
		{
			vtkLocator.vtkLocator_AutomaticOff_01(base.GetCppThis());
		}

		// Token: 0x0600C6DB RID: 50907
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLocator_AutomaticOn_02(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether locator depth/resolution of locator is computed
		/// automatically from average number of entities in bucket. If not set,
		/// there will be an explicit method to control the construction of the
		/// locator (found in the subclass).
		/// </summary>
		// Token: 0x0600C6DC RID: 50908 RVA: 0x001149C3 File Offset: 0x00112BC3
		public virtual void AutomaticOn()
		{
			vtkLocator.vtkLocator_AutomaticOn_02(base.GetCppThis());
		}

		// Token: 0x0600C6DD RID: 50909
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLocator_BuildLocator_03(HandleRef pThis);

		/// <summary>
		/// Build the locator from the input dataset. This will NOT do anything if
		/// UseExistingSearchStructure is on.
		/// </summary>
		// Token: 0x0600C6DE RID: 50910 RVA: 0x001149D2 File Offset: 0x00112BD2
		public virtual void BuildLocator()
		{
			vtkLocator.vtkLocator_BuildLocator_03(base.GetCppThis());
		}

		// Token: 0x0600C6DF RID: 50911
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLocator_ForceBuildLocator_04(HandleRef pThis);

		/// <summary>
		/// Build the locator from the input dataset (even if UseExistingSearchStructure is on).
		///
		/// This function is not pure virtual to maintain backwards compatibility.
		/// </summary>
		// Token: 0x0600C6E0 RID: 50912 RVA: 0x001149E1 File Offset: 0x00112BE1
		public virtual void ForceBuildLocator()
		{
			vtkLocator.vtkLocator_ForceBuildLocator_04(base.GetCppThis());
		}

		// Token: 0x0600C6E1 RID: 50913
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLocator_FreeSearchStructure_05(HandleRef pThis);

		/// <summary>
		/// Free the memory required for the spatial data structure.
		/// </summary>
		// Token: 0x0600C6E2 RID: 50914 RVA: 0x001149F0 File Offset: 0x00112BF0
		public virtual void FreeSearchStructure()
		{
			vtkLocator.vtkLocator_FreeSearchStructure_05(base.GetCppThis());
		}

		// Token: 0x0600C6E3 RID: 50915
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLocator_GenerateRepresentation_06(HandleRef pThis, int level, HandleRef pd);

		/// <summary>
		/// Method to build a representation at a particular level. Note that the
		/// method GetLevel() returns the maximum number of levels available for
		/// the tree. You must provide a vtkPolyData object into which to place the
		/// data.
		/// </summary>
		// Token: 0x0600C6E4 RID: 50916 RVA: 0x00114A00 File Offset: 0x00112C00
		public virtual void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkLocator.vtkLocator_GenerateRepresentation_06(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600C6E5 RID: 50917
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLocator_GetAutomatic_07(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether locator depth/resolution of locator is computed
		/// automatically from average number of entities in bucket. If not set,
		/// there will be an explicit method to control the construction of the
		/// locator (found in the subclass).
		/// </summary>
		// Token: 0x0600C6E6 RID: 50918 RVA: 0x00114A30 File Offset: 0x00112C30
		public virtual int GetAutomatic()
		{
			return vtkLocator.vtkLocator_GetAutomatic_07(base.GetCppThis());
		}

		// Token: 0x0600C6E7 RID: 50919
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkLocator_GetBuildTime_08(HandleRef pThis);

		/// <summary>
		/// Return the time of the last data structure build.
		/// </summary>
		// Token: 0x0600C6E8 RID: 50920 RVA: 0x00114A50 File Offset: 0x00112C50
		public virtual ulong GetBuildTime()
		{
			return vtkLocator.vtkLocator_GetBuildTime_08(base.GetCppThis());
		}

		// Token: 0x0600C6E9 RID: 50921
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLocator_GetDataSet_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Build the locator from the points/cells defining this dataset.
		/// </summary>
		// Token: 0x0600C6EA RID: 50922 RVA: 0x00114A70 File Offset: 0x00112C70
		public virtual vtkDataSet GetDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLocator.vtkLocator_GetDataSet_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600C6EB RID: 50923
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLocator_GetLevel_10(HandleRef pThis);

		/// <summary>
		/// Get the level of the locator (determined automatically if Automatic is
		/// true). The value of this ivar may change each time the locator is built.
		/// Initial value is 8.
		/// </summary>
		// Token: 0x0600C6EC RID: 50924 RVA: 0x00114AE0 File Offset: 0x00112CE0
		public virtual int GetLevel()
		{
			return vtkLocator.vtkLocator_GetLevel_10(base.GetCppThis());
		}

		// Token: 0x0600C6ED RID: 50925
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLocator_GetMaxLevel_11(HandleRef pThis);

		/// <summary>
		/// Set the maximum allowable level for the tree. If the Automatic ivar is
		/// off, this will be the target depth of the locator.
		/// Initial value is 8.
		/// </summary>
		// Token: 0x0600C6EE RID: 50926 RVA: 0x00114B00 File Offset: 0x00112D00
		public virtual int GetMaxLevel()
		{
			return vtkLocator.vtkLocator_GetMaxLevel_11(base.GetCppThis());
		}

		// Token: 0x0600C6EF RID: 50927
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLocator_GetMaxLevelMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Set the maximum allowable level for the tree. If the Automatic ivar is
		/// off, this will be the target depth of the locator.
		/// Initial value is 8.
		/// </summary>
		// Token: 0x0600C6F0 RID: 50928 RVA: 0x00114B20 File Offset: 0x00112D20
		public virtual int GetMaxLevelMaxValue()
		{
			return vtkLocator.vtkLocator_GetMaxLevelMaxValue_12(base.GetCppThis());
		}

		// Token: 0x0600C6F1 RID: 50929
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLocator_GetMaxLevelMinValue_13(HandleRef pThis);

		/// <summary>
		/// Set the maximum allowable level for the tree. If the Automatic ivar is
		/// off, this will be the target depth of the locator.
		/// Initial value is 8.
		/// </summary>
		// Token: 0x0600C6F2 RID: 50930 RVA: 0x00114B40 File Offset: 0x00112D40
		public virtual int GetMaxLevelMinValue()
		{
			return vtkLocator.vtkLocator_GetMaxLevelMinValue_13(base.GetCppThis());
		}

		// Token: 0x0600C6F3 RID: 50931
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLocator_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0600C6F4 RID: 50932 RVA: 0x00114B60 File Offset: 0x00112D60
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLocator.vtkLocator_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x0600C6F5 RID: 50933
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLocator_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0600C6F6 RID: 50934 RVA: 0x00114B80 File Offset: 0x00112D80
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLocator.vtkLocator_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x0600C6F7 RID: 50935
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLocator_GetTolerance_16(HandleRef pThis);

		/// <summary>
		/// Specify absolute tolerance (in world coordinates) for performing
		/// geometric operations.
		/// </summary>
		// Token: 0x0600C6F8 RID: 50936 RVA: 0x00114B9C File Offset: 0x00112D9C
		public virtual double GetTolerance()
		{
			return vtkLocator.vtkLocator_GetTolerance_16(base.GetCppThis());
		}

		// Token: 0x0600C6F9 RID: 50937
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLocator_GetToleranceMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Specify absolute tolerance (in world coordinates) for performing
		/// geometric operations.
		/// </summary>
		// Token: 0x0600C6FA RID: 50938 RVA: 0x00114BBC File Offset: 0x00112DBC
		public virtual double GetToleranceMaxValue()
		{
			return vtkLocator.vtkLocator_GetToleranceMaxValue_17(base.GetCppThis());
		}

		// Token: 0x0600C6FB RID: 50939
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLocator_GetToleranceMinValue_18(HandleRef pThis);

		/// <summary>
		/// Specify absolute tolerance (in world coordinates) for performing
		/// geometric operations.
		/// </summary>
		// Token: 0x0600C6FC RID: 50940 RVA: 0x00114BDC File Offset: 0x00112DDC
		public virtual double GetToleranceMinValue()
		{
			return vtkLocator.vtkLocator_GetToleranceMinValue_18(base.GetCppThis());
		}

		// Token: 0x0600C6FD RID: 50941
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLocator_GetUseExistingSearchStructure_19(HandleRef pThis);

		/// <summary>
		/// Get/Set UseExistingSearchStructure, which when enabled it allows the locator to NOT be
		/// built again. This is useful when you have a dataset that either changes because
		/// the FieldData (PointData/CellData) changed or the actual dataset object changed
		/// but it's actually the same geometry (useful when a dataset has timesteps).
		///
		/// When this flag is on you need to use ForceBuildLocator() to rebuild the locator,
		/// if your dataset changes.
		///
		/// Default is off.
		/// </summary>
		// Token: 0x0600C6FE RID: 50942 RVA: 0x00114BFC File Offset: 0x00112DFC
		public virtual int GetUseExistingSearchStructure()
		{
			return vtkLocator.vtkLocator_GetUseExistingSearchStructure_19(base.GetCppThis());
		}

		// Token: 0x0600C6FF RID: 50943
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLocator_Initialize_20(HandleRef pThis);

		/// <summary>
		/// Initialize locator. Frees memory and resets object as appropriate.
		/// </summary>
		// Token: 0x0600C700 RID: 50944 RVA: 0x00114C1B File Offset: 0x00112E1B
		public virtual void Initialize()
		{
			vtkLocator.vtkLocator_Initialize_20(base.GetCppThis());
		}

		// Token: 0x0600C701 RID: 50945
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLocator_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0600C702 RID: 50946 RVA: 0x00114C2C File Offset: 0x00112E2C
		public override int IsA(string type)
		{
			return vtkLocator.vtkLocator_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x0600C703 RID: 50947
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLocator_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0600C704 RID: 50948 RVA: 0x00114C4C File Offset: 0x00112E4C
		public new static int IsTypeOf(string type)
		{
			return vtkLocator.vtkLocator_IsTypeOf_22(type);
		}

		// Token: 0x0600C705 RID: 50949
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLocator_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0600C706 RID: 50950 RVA: 0x00114C68 File Offset: 0x00112E68
		public new vtkLocator NewInstance()
		{
			vtkLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLocator.vtkLocator_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C707 RID: 50951
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLocator_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0600C708 RID: 50952 RVA: 0x00114CC4 File Offset: 0x00112EC4
		public new static vtkLocator SafeDownCast(vtkObjectBase o)
		{
			vtkLocator vtkLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLocator.vtkLocator_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLocator = (vtkLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLocator.Register(null);
				}
			}
			return vtkLocator;
		}

		// Token: 0x0600C709 RID: 50953
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLocator_SetAutomatic_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether locator depth/resolution of locator is computed
		/// automatically from average number of entities in bucket. If not set,
		/// there will be an explicit method to control the construction of the
		/// locator (found in the subclass).
		/// </summary>
		// Token: 0x0600C70A RID: 50954 RVA: 0x00114D43 File Offset: 0x00112F43
		public virtual void SetAutomatic(int _arg)
		{
			vtkLocator.vtkLocator_SetAutomatic_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C70B RID: 50955
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLocator_SetDataSet_26(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Build the locator from the points/cells defining this dataset.
		/// </summary>
		// Token: 0x0600C70C RID: 50956 RVA: 0x00114D54 File Offset: 0x00112F54
		public virtual void SetDataSet(vtkDataSet arg0)
		{
			vtkLocator.vtkLocator_SetDataSet_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600C70D RID: 50957
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLocator_SetMaxLevel_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the maximum allowable level for the tree. If the Automatic ivar is
		/// off, this will be the target depth of the locator.
		/// Initial value is 8.
		/// </summary>
		// Token: 0x0600C70E RID: 50958 RVA: 0x00114D83 File Offset: 0x00112F83
		public virtual void SetMaxLevel(int _arg)
		{
			vtkLocator.vtkLocator_SetMaxLevel_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C70F RID: 50959
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLocator_SetTolerance_28(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify absolute tolerance (in world coordinates) for performing
		/// geometric operations.
		/// </summary>
		// Token: 0x0600C710 RID: 50960 RVA: 0x00114D93 File Offset: 0x00112F93
		public virtual void SetTolerance(double _arg)
		{
			vtkLocator.vtkLocator_SetTolerance_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C711 RID: 50961
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLocator_SetUseExistingSearchStructure_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set UseExistingSearchStructure, which when enabled it allows the locator to NOT be
		/// built again. This is useful when you have a dataset that either changes because
		/// the FieldData (PointData/CellData) changed or the actual dataset object changed
		/// but it's actually the same geometry (useful when a dataset has timesteps).
		///
		/// When this flag is on you need to use ForceBuildLocator() to rebuild the locator,
		/// if your dataset changes.
		///
		/// Default is off.
		/// </summary>
		// Token: 0x0600C712 RID: 50962 RVA: 0x00114DA3 File Offset: 0x00112FA3
		public virtual void SetUseExistingSearchStructure(int _arg)
		{
			vtkLocator.vtkLocator_SetUseExistingSearchStructure_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C713 RID: 50963
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLocator_Update_30(HandleRef pThis);

		/// <summary>
		/// Cause the locator to rebuild itself if it or its input dataset has
		/// changed.
		/// </summary>
		// Token: 0x0600C714 RID: 50964 RVA: 0x00114DB3 File Offset: 0x00112FB3
		public virtual void Update()
		{
			vtkLocator.vtkLocator_Update_30(base.GetCppThis());
		}

		// Token: 0x0600C715 RID: 50965
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLocator_UseExistingSearchStructureOff_31(HandleRef pThis);

		/// <summary>
		/// Get/Set UseExistingSearchStructure, which when enabled it allows the locator to NOT be
		/// built again. This is useful when you have a dataset that either changes because
		/// the FieldData (PointData/CellData) changed or the actual dataset object changed
		/// but it's actually the same geometry (useful when a dataset has timesteps).
		///
		/// When this flag is on you need to use ForceBuildLocator() to rebuild the locator,
		/// if your dataset changes.
		///
		/// Default is off.
		/// </summary>
		// Token: 0x0600C716 RID: 50966 RVA: 0x00114DC2 File Offset: 0x00112FC2
		public virtual void UseExistingSearchStructureOff()
		{
			vtkLocator.vtkLocator_UseExistingSearchStructureOff_31(base.GetCppThis());
		}

		// Token: 0x0600C717 RID: 50967
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLocator_UseExistingSearchStructureOn_32(HandleRef pThis);

		/// <summary>
		/// Get/Set UseExistingSearchStructure, which when enabled it allows the locator to NOT be
		/// built again. This is useful when you have a dataset that either changes because
		/// the FieldData (PointData/CellData) changed or the actual dataset object changed
		/// but it's actually the same geometry (useful when a dataset has timesteps).
		///
		/// When this flag is on you need to use ForceBuildLocator() to rebuild the locator,
		/// if your dataset changes.
		///
		/// Default is off.
		/// </summary>
		// Token: 0x0600C718 RID: 50968 RVA: 0x00114DD1 File Offset: 0x00112FD1
		public virtual void UseExistingSearchStructureOn()
		{
			vtkLocator.vtkLocator_UseExistingSearchStructureOn_32(base.GetCppThis());
		}

		// Token: 0x0600C719 RID: 50969
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLocator_UsesGarbageCollector_33(HandleRef pThis);

		/// <summary>
		/// Handle the PointSet &lt;-&gt; Locator loop.
		/// </summary>
		// Token: 0x0600C71A RID: 50970 RVA: 0x00114DE0 File Offset: 0x00112FE0
		public override bool UsesGarbageCollector()
		{
			return vtkLocator.vtkLocator_UsesGarbageCollector_33(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ECF RID: 3791
		public new const string MRFullTypeName = "Kitware.VTK.vtkLocator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ED0 RID: 3792
		public new static readonly string MRClassNameKey = "class vtkLocator";
	}
}
