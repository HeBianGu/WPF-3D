using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBSPCuts
	/// </summary>
	/// <remarks>
	///    This class represents an axis-aligned Binary Spatial
	///    Partitioning of a 3D space.
	///
	///
	///    This class converts between the vtkKdTree
	///    representation of a tree of vtkKdNodes (used by vtkDistributedDataFilter)
	///    and a compact array representation that might be provided by a
	///    graph partitioning library like Zoltan.  Such a representation
	///    could be used in message passing.
	///
	/// </remarks>
	/// <seealso>
	///
	///      vtkKdTree vtkKdNode vtkDistributedDataFilter
	/// </seealso>
	// Token: 0x020009FB RID: 2555
	public class vtkBSPCuts : vtkDataObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A808 RID: 108552 RVA: 0x0024D35F File Offset: 0x0024B55F
		static vtkBSPCuts()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBSPCuts.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBSPCuts"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A809 RID: 108553 RVA: 0x0024D387 File Offset: 0x0024B587
		public vtkBSPCuts(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A80A RID: 108554
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBSPCuts_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A80B RID: 108555 RVA: 0x0024D398 File Offset: 0x0024B598
		public new static vtkBSPCuts New()
		{
			vtkBSPCuts result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBSPCuts.vtkBSPCuts_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A80C RID: 108556 RVA: 0x0024D3EC File Offset: 0x0024B5EC
		public vtkBSPCuts() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBSPCuts.vtkBSPCuts_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A80D RID: 108557 RVA: 0x0024D430 File Offset: 0x0024B630
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A80E RID: 108558
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBSPCuts_CreateCuts_01(HandleRef pThis, IntPtr bounds, int ncuts, IntPtr dim, IntPtr coord, IntPtr lower, IntPtr upper, IntPtr lowerDataCoord, IntPtr upperDataCoord, IntPtr npoints);

		/// <summary>
		/// Initialize the cuts with arrays of information.  This type of
		/// information would be obtained from a graph partitioning software
		/// package like Zoltan.
		///
		/// bounds - the bounds (xmin, xmax, ymin, ymax, zmin, zmax) of the
		/// space being partitioned
		/// ncuts - the number cuts, also the size of the following arrays
		/// dim   - the dimension along which the cut is made (x/y/z - 0/1/2)
		/// coord - the location of the cut along the axis
		/// lower - array index for the lower region bounded by the cut
		/// upper - array index for the upper region bounded by the cut
		/// lowerDataCoord - optional upper bound of the data in the lower region
		/// upperDataCoord - optional lower bound of the data in the upper region
		/// npoints - optional number of points in the spatial region
		/// </summary>
		// Token: 0x0601A80F RID: 108559 RVA: 0x0024D43C File Offset: 0x0024B63C
		public void CreateCuts(IntPtr bounds, int ncuts, IntPtr dim, IntPtr coord, IntPtr lower, IntPtr upper, IntPtr lowerDataCoord, IntPtr upperDataCoord, IntPtr npoints)
		{
			vtkBSPCuts.vtkBSPCuts_CreateCuts_01(base.GetCppThis(), bounds, ncuts, dim, coord, lower, upper, lowerDataCoord, upperDataCoord, npoints);
		}

		// Token: 0x0601A810 RID: 108560
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBSPCuts_CreateCuts_02(HandleRef pThis, HandleRef kd);

		/// <summary>
		/// Initialize the cuts from a tree of vtkKdNode's
		/// </summary>
		// Token: 0x0601A811 RID: 108561 RVA: 0x0024D468 File Offset: 0x0024B668
		public void CreateCuts(vtkKdNode kd)
		{
			vtkBSPCuts.vtkBSPCuts_CreateCuts_02(base.GetCppThis(), (kd == null) ? default(HandleRef) : kd.GetCppThis());
		}

		// Token: 0x0601A812 RID: 108562
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBSPCuts_DeepCopy_03(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow copy.  These copy the data, but not any of the
		/// pipeline connections.
		/// </summary>
		// Token: 0x0601A813 RID: 108563 RVA: 0x0024D498 File Offset: 0x0024B698
		public override void DeepCopy(vtkDataObject src)
		{
			vtkBSPCuts.vtkBSPCuts_DeepCopy_03(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601A814 RID: 108564
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPCuts_Equals_04(HandleRef pThis, HandleRef other, double tolerance);

		/// <summary>
		/// Compare these cuts with those of the other tree.  Returns true if
		/// the two trees are the same.
		/// </summary>
		// Token: 0x0601A815 RID: 108565 RVA: 0x0024D4C8 File Offset: 0x0024B6C8
		public int EqualsWrapper(vtkBSPCuts other, double tolerance)
		{
			return vtkBSPCuts.vtkBSPCuts_Equals_04(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis(), tolerance);
		}

		// Token: 0x0601A816 RID: 108566
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPCuts_GetArrays_05(HandleRef pThis, int len, IntPtr dim, IntPtr coord, IntPtr lower, IntPtr upper, IntPtr lowerDataCoord, IntPtr upperDataCoord, IntPtr npoints);

		/// <summary>
		/// Get the arrays representing the cuts in the partitioning.
		/// </summary>
		// Token: 0x0601A817 RID: 108567 RVA: 0x0024D500 File Offset: 0x0024B700
		public int GetArrays(int len, IntPtr dim, IntPtr coord, IntPtr lower, IntPtr upper, IntPtr lowerDataCoord, IntPtr upperDataCoord, IntPtr npoints)
		{
			return vtkBSPCuts.vtkBSPCuts_GetArrays_05(base.GetCppThis(), len, dim, coord, lower, upper, lowerDataCoord, upperDataCoord, npoints);
		}

		// Token: 0x0601A818 RID: 108568
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBSPCuts_GetData_06(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601A819 RID: 108569 RVA: 0x0024D52C File Offset: 0x0024B72C
		public new static vtkBSPCuts GetData(vtkInformation info)
		{
			vtkBSPCuts vtkBSPCuts = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBSPCuts.vtkBSPCuts_GetData_06((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBSPCuts = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBSPCuts.Register(null);
				}
			}
			return vtkBSPCuts;
		}

		// Token: 0x0601A81A RID: 108570
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBSPCuts_GetData_07(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601A81B RID: 108571 RVA: 0x0024D5AC File Offset: 0x0024B7AC
		public new static vtkBSPCuts GetData(vtkInformationVector v, int i)
		{
			vtkBSPCuts vtkBSPCuts = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBSPCuts.vtkBSPCuts_GetData_07((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBSPCuts = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBSPCuts.Register(null);
				}
			}
			return vtkBSPCuts;
		}

		// Token: 0x0601A81C RID: 108572
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPCuts_GetDataObjectType_08(HandleRef pThis);

		/// <summary>
		/// Returns VTK_BSP_CUTS.
		/// </summary>
		// Token: 0x0601A81D RID: 108573 RVA: 0x0024D62C File Offset: 0x0024B82C
		public override int GetDataObjectType()
		{
			return vtkBSPCuts.vtkBSPCuts_GetDataObjectType_08(base.GetCppThis());
		}

		// Token: 0x0601A81E RID: 108574
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBSPCuts_GetKdNodeTree_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a tree of vtkKdNode's representing the cuts specified
		/// in this object.  This is our copy, don't delete it.
		/// </summary>
		// Token: 0x0601A81F RID: 108575 RVA: 0x0024D64C File Offset: 0x0024B84C
		public vtkKdNode GetKdNodeTree()
		{
			vtkKdNode vtkKdNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBSPCuts.vtkBSPCuts_GetKdNodeTree_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKdNode = (vtkKdNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKdNode.Register(null);
				}
			}
			return vtkKdNode;
		}

		// Token: 0x0601A820 RID: 108576
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPCuts_GetNumberOfCuts_10(HandleRef pThis);

		/// <summary>
		/// Get the number of cuts in the partitioning, which also the size of
		/// the arrays in the array representation of the partitioning.
		/// </summary>
		// Token: 0x0601A821 RID: 108577 RVA: 0x0024D6BC File Offset: 0x0024B8BC
		public virtual int GetNumberOfCuts()
		{
			return vtkBSPCuts.vtkBSPCuts_GetNumberOfCuts_10(base.GetCppThis());
		}

		// Token: 0x0601A822 RID: 108578
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBSPCuts_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A823 RID: 108579 RVA: 0x0024D6DC File Offset: 0x0024B8DC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBSPCuts.vtkBSPCuts_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0601A824 RID: 108580
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBSPCuts_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A825 RID: 108581 RVA: 0x0024D6FC File Offset: 0x0024B8FC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBSPCuts.vtkBSPCuts_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0601A826 RID: 108582
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBSPCuts_Initialize_13(HandleRef pThis);

		/// <summary>
		/// Restore data object to initial state,
		/// </summary>
		// Token: 0x0601A827 RID: 108583 RVA: 0x0024D716 File Offset: 0x0024B916
		public override void Initialize()
		{
			vtkBSPCuts.vtkBSPCuts_Initialize_13(base.GetCppThis());
		}

		// Token: 0x0601A828 RID: 108584
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPCuts_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A829 RID: 108585 RVA: 0x0024D728 File Offset: 0x0024B928
		public override int IsA(string type)
		{
			return vtkBSPCuts.vtkBSPCuts_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x0601A82A RID: 108586
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPCuts_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A82B RID: 108587 RVA: 0x0024D748 File Offset: 0x0024B948
		public new static int IsTypeOf(string type)
		{
			return vtkBSPCuts.vtkBSPCuts_IsTypeOf_15(type);
		}

		// Token: 0x0601A82C RID: 108588
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBSPCuts_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A82D RID: 108589 RVA: 0x0024D764 File Offset: 0x0024B964
		public new vtkBSPCuts NewInstance()
		{
			vtkBSPCuts result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBSPCuts.vtkBSPCuts_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A82E RID: 108590
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBSPCuts_PrintArrays_18(HandleRef pThis);

		/// <summary>
		/// Compare these cuts with those of the other tree.  Returns true if
		/// the two trees are the same.
		/// </summary>
		// Token: 0x0601A82F RID: 108591 RVA: 0x0024D7BE File Offset: 0x0024B9BE
		public void PrintArrays()
		{
			vtkBSPCuts.vtkBSPCuts_PrintArrays_18(base.GetCppThis());
		}

		// Token: 0x0601A830 RID: 108592
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBSPCuts_PrintTree_19(HandleRef pThis);

		/// <summary>
		/// Compare these cuts with those of the other tree.  Returns true if
		/// the two trees are the same.
		/// </summary>
		// Token: 0x0601A831 RID: 108593 RVA: 0x0024D7CD File Offset: 0x0024B9CD
		public void PrintTree()
		{
			vtkBSPCuts.vtkBSPCuts_PrintTree_19(base.GetCppThis());
		}

		// Token: 0x0601A832 RID: 108594
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBSPCuts_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A833 RID: 108595 RVA: 0x0024D7DC File Offset: 0x0024B9DC
		public new static vtkBSPCuts SafeDownCast(vtkObjectBase o)
		{
			vtkBSPCuts vtkBSPCuts = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBSPCuts.vtkBSPCuts_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBSPCuts = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBSPCuts.Register(null);
				}
			}
			return vtkBSPCuts;
		}

		// Token: 0x0601A834 RID: 108596
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBSPCuts_ShallowCopy_21(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow copy.  These copy the data, but not any of the
		/// pipeline connections.
		/// </summary>
		// Token: 0x0601A835 RID: 108597 RVA: 0x0024D85C File Offset: 0x0024BA5C
		public override void ShallowCopy(vtkDataObject src)
		{
			vtkBSPCuts.vtkBSPCuts_ShallowCopy_21(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CCE RID: 7374
		public new const string MRFullTypeName = "Kitware.VTK.vtkBSPCuts";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CCF RID: 7375
		public new static readonly string MRClassNameKey = "class vtkBSPCuts";
	}
}
