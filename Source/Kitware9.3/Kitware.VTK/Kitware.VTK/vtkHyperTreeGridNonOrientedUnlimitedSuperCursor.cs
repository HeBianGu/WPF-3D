using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHyperTreeGridNonOrientedUnlimitedSuperCursor
	/// </summary>
	/// <remarks>
	///    Objects for traversal a HyperTreeGrid.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHyperTreeGridNonOrientedSuperCursor vtkHyperTreeCursor vtkHyperTree vtkHyperTreeGrid
	/// </seealso>
	// Token: 0x02000A61 RID: 2657
	public abstract class vtkHyperTreeGridNonOrientedUnlimitedSuperCursor : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BC4B RID: 113739 RVA: 0x0026E2D1 File Offset: 0x0026C4D1
		static vtkHyperTreeGridNonOrientedUnlimitedSuperCursor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BC4C RID: 113740 RVA: 0x0026E2F9 File Offset: 0x0026C4F9
		public vtkHyperTreeGridNonOrientedUnlimitedSuperCursor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BC4D RID: 113741 RVA: 0x0026E307 File Offset: 0x0026C507
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BC4E RID: 113742
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_Clone_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a copy of `this'.
		/// \post results_exists:result!=0
		/// </summary>
		// Token: 0x0601BC4F RID: 113743 RVA: 0x0026E314 File Offset: 0x0026C514
		public virtual vtkHyperTreeGridNonOrientedUnlimitedSuperCursor Clone()
		{
			vtkHyperTreeGridNonOrientedUnlimitedSuperCursor vtkHyperTreeGridNonOrientedUnlimitedSuperCursor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_Clone_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperTreeGridNonOrientedUnlimitedSuperCursor = (vtkHyperTreeGridNonOrientedUnlimitedSuperCursor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.Register(null);
				}
			}
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor;
		}

		// Token: 0x0601BC50 RID: 113744
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetBounds_02(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// JB Coordonnees de la boite englobante
		/// </summary>
		// Token: 0x0601BC51 RID: 113745 RVA: 0x0026E383 File Offset: 0x0026C583
		public void GetBounds(IntPtr bounds)
		{
			vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetBounds_02(base.GetCppThis(), bounds);
		}

		// Token: 0x0601BC52 RID: 113746
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetBounds_03(HandleRef pThis, uint icursor, IntPtr bounds);

		/// <summary>
		/// JB Coordonnees de la boite englobante
		/// </summary>
		// Token: 0x0601BC53 RID: 113747 RVA: 0x0026E393 File Offset: 0x0026C593
		public void GetBounds(uint icursor, IntPtr bounds)
		{
			vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetBounds_03(base.GetCppThis(), icursor, bounds);
		}

		// Token: 0x0601BC54 RID: 113748
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetDimension_04(HandleRef pThis);

		/// <summary>
		/// Return the dimension of the tree.
		/// \post positive_result: result&gt;0
		/// </summary>
		// Token: 0x0601BC55 RID: 113749 RVA: 0x0026E3A4 File Offset: 0x0026C5A4
		public byte GetDimension()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetDimension_04(base.GetCppThis());
		}

		// Token: 0x0601BC56 RID: 113750
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetExtensivePropertyRatio_05(HandleRef pThis);

		/// <summary>
		/// returns the value of the ratio to be applied to extensive
		/// value for the current cursor, related to the last real
		/// value of the cell. Return 1 for real cells, otherwise
		/// return the portion of the area covered by the subdivieded cell.
		/// For intensive valued fields this ratio should not be used.
		/// </summary>
		// Token: 0x0601BC57 RID: 113751 RVA: 0x0026E3C4 File Offset: 0x0026C5C4
		public double GetExtensivePropertyRatio()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetExtensivePropertyRatio_05(base.GetCppThis());
		}

		// Token: 0x0601BC58 RID: 113752
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetExtensivePropertyRatio_06(HandleRef pThis, long index);

		/// <summary>
		/// returns the value of the ratio to be applied to extensive
		/// value for the current cursor, related to the last real
		/// value of the cell. Return 1 for real cells, otherwise
		/// return the portion of the area covered by the subdivieded cell.
		/// For intensive valued fields this ratio should not be used.
		/// </summary>
		// Token: 0x0601BC59 RID: 113753 RVA: 0x0026E3E4 File Offset: 0x0026C5E4
		public double GetExtensivePropertyRatio(long index)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetExtensivePropertyRatio_06(base.GetCppThis(), index);
		}

		// Token: 0x0601BC5A RID: 113754
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetGlobalNodeIndex_07(HandleRef pThis);

		/// <summary>
		/// Return the global index (relative to the grid) of the
		/// current vertex in the tree.
		/// </summary>
		// Token: 0x0601BC5B RID: 113755 RVA: 0x0026E404 File Offset: 0x0026C604
		public long GetGlobalNodeIndex()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetGlobalNodeIndex_07(base.GetCppThis());
		}

		// Token: 0x0601BC5C RID: 113756
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetGlobalNodeIndex_08(HandleRef pThis, uint icursor);

		/// <summary>
		/// JB Return the global index (relative to the grid) of the
		/// neighbor icursor current vertex in the tree.
		/// </summary>
		// Token: 0x0601BC5D RID: 113757 RVA: 0x0026E424 File Offset: 0x0026C624
		public long GetGlobalNodeIndex(uint icursor)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetGlobalNodeIndex_08(base.GetCppThis(), icursor);
		}

		// Token: 0x0601BC5E RID: 113758
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetInformation_09(HandleRef pThis, uint icursor, ref uint level, ref byte leaf, ref long id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// JB
		/// </summary>
		// Token: 0x0601BC5F RID: 113759 RVA: 0x0026E444 File Offset: 0x0026C644
		public vtkHyperTree GetInformation(uint icursor, ref uint level, ref byte leaf, ref long id)
		{
			vtkHyperTree vtkHyperTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetInformation_09(base.GetCppThis(), icursor, ref level, ref leaf, ref id, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperTree = (vtkHyperTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperTree.Register(null);
				}
			}
			return vtkHyperTree;
		}

		// Token: 0x0601BC60 RID: 113760
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetLastRealLevel_10(HandleRef pThis);

		/// <summary>
		/// Get the level of the tree vertex pointed by the cursor.
		/// </summary>
		// Token: 0x0601BC61 RID: 113761 RVA: 0x0026E4B8 File Offset: 0x0026C6B8
		public uint GetLastRealLevel()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetLastRealLevel_10(base.GetCppThis());
		}

		// Token: 0x0601BC62 RID: 113762
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetLastRealLevel_11(HandleRef pThis, uint icursor);

		/// <summary>
		/// Get the level of the tree vertex pointed by the cursor.
		/// </summary>
		// Token: 0x0601BC63 RID: 113763 RVA: 0x0026E4D8 File Offset: 0x0026C6D8
		public uint GetLastRealLevel(uint icursor)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetLastRealLevel_11(base.GetCppThis(), icursor);
		}

		// Token: 0x0601BC64 RID: 113764
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetLevel_12(HandleRef pThis);

		/// <summary>
		/// Get the level of the tree vertex pointed by the cursor.
		/// </summary>
		// Token: 0x0601BC65 RID: 113765 RVA: 0x0026E4F8 File Offset: 0x0026C6F8
		public uint GetLevel()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetLevel_12(base.GetCppThis());
		}

		// Token: 0x0601BC66 RID: 113766
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetLevel_13(HandleRef pThis, uint icursor);

		/// <summary>
		/// Get the level of the tree vertex pointed by the cursor.
		/// </summary>
		// Token: 0x0601BC67 RID: 113767 RVA: 0x0026E518 File Offset: 0x0026C718
		public uint GetLevel(uint icursor)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetLevel_13(base.GetCppThis(), icursor);
		}

		// Token: 0x0601BC68 RID: 113768
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetNumberOfChildren_14(HandleRef pThis);

		/// <summary>
		/// Return the number of children for each node (non-vertex leaf) of the tree.
		/// \post positive_number: result&gt;0
		/// </summary>
		// Token: 0x0601BC69 RID: 113769 RVA: 0x0026E538 File Offset: 0x0026C738
		public byte GetNumberOfChildren()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetNumberOfChildren_14(base.GetCppThis());
		}

		// Token: 0x0601BC6A RID: 113770
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetNumberOfCursors_15(HandleRef pThis);

		/// <summary>
		/// JB
		/// </summary>
		// Token: 0x0601BC6B RID: 113771 RVA: 0x0026E558 File Offset: 0x0026C758
		public uint GetNumberOfCursors()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetNumberOfCursors_15(base.GetCppThis());
		}

		// Token: 0x0601BC6C RID: 113772
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BC6D RID: 113773 RVA: 0x0026E578 File Offset: 0x0026C778
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x0601BC6E RID: 113774
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BC6F RID: 113775 RVA: 0x0026E598 File Offset: 0x0026C798
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x0601BC70 RID: 113776
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetOrigin_18(HandleRef pThis);

		/// <summary>
		/// JB
		/// </summary>
		// Token: 0x0601BC71 RID: 113777 RVA: 0x0026E5B4 File Offset: 0x0026C7B4
		public IntPtr GetOrigin()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetOrigin_18(base.GetCppThis());
		}

		// Token: 0x0601BC72 RID: 113778
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetPoint_19(HandleRef pThis, IntPtr point);

		/// <summary>
		/// JB Coordonnees du centre de la maille
		/// </summary>
		// Token: 0x0601BC73 RID: 113779 RVA: 0x0026E5D3 File Offset: 0x0026C7D3
		public void GetPoint(IntPtr point)
		{
			vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetPoint_19(base.GetCppThis(), point);
		}

		// Token: 0x0601BC74 RID: 113780
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetPoint_20(HandleRef pThis, uint icursor, IntPtr point);

		/// <summary>
		/// JB Coordonnees du centre de la maille
		/// </summary>
		// Token: 0x0601BC75 RID: 113781 RVA: 0x0026E5E3 File Offset: 0x0026C7E3
		public void GetPoint(uint icursor, IntPtr point)
		{
			vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetPoint_20(base.GetCppThis(), icursor, point);
		}

		// Token: 0x0601BC76 RID: 113782
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetSize_21(HandleRef pThis);

		/// <summary>
		/// JB
		/// </summary>
		// Token: 0x0601BC77 RID: 113783 RVA: 0x0026E5F4 File Offset: 0x0026C7F4
		public IntPtr GetSize()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetSize_21(base.GetCppThis());
		}

		// Token: 0x0601BC78 RID: 113784
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetTree_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the hyper tree to which the cursor is pointing.
		/// </summary>
		// Token: 0x0601BC79 RID: 113785 RVA: 0x0026E614 File Offset: 0x0026C814
		public vtkHyperTree GetTree()
		{
			vtkHyperTree vtkHyperTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetTree_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperTree = (vtkHyperTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperTree.Register(null);
				}
			}
			return vtkHyperTree;
		}

		// Token: 0x0601BC7A RID: 113786
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetTree_23(HandleRef pThis, uint icursor, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the hyper tree to which the cursor is pointing.
		/// </summary>
		// Token: 0x0601BC7B RID: 113787 RVA: 0x0026E684 File Offset: 0x0026C884
		public vtkHyperTree GetTree(uint icursor)
		{
			vtkHyperTree vtkHyperTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetTree_23(base.GetCppThis(), icursor, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperTree = (vtkHyperTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperTree.Register(null);
				}
			}
			return vtkHyperTree;
		}

		// Token: 0x0601BC7C RID: 113788
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetVertexId_24(HandleRef pThis);

		/// <summary>
		/// Return the index of the current vertex in the tree.
		/// </summary>
		// Token: 0x0601BC7D RID: 113789 RVA: 0x0026E6F4 File Offset: 0x0026C8F4
		public long GetVertexId()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetVertexId_24(base.GetCppThis());
		}

		// Token: 0x0601BC7E RID: 113790
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetVertexId_25(HandleRef pThis, uint icursor);

		/// <summary>
		/// Return the index of the current vertex in the tree.
		/// </summary>
		// Token: 0x0601BC7F RID: 113791 RVA: 0x0026E714 File Offset: 0x0026C914
		public long GetVertexId(uint icursor)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetVertexId_25(base.GetCppThis(), icursor);
		}

		// Token: 0x0601BC80 RID: 113792
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_HasTree_26(HandleRef pThis);

		/// <summary>
		/// Return if a Tree pointing exist
		/// </summary>
		// Token: 0x0601BC81 RID: 113793 RVA: 0x0026E734 File Offset: 0x0026C934
		public bool HasTree()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_HasTree_26(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BC82 RID: 113794
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_HasTree_27(HandleRef pThis, uint icursor);

		/// <summary>
		/// JB Return if a Tree pointing exist
		/// </summary>
		// Token: 0x0601BC83 RID: 113795 RVA: 0x0026E75C File Offset: 0x0026C95C
		public bool HasTree(uint icursor)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_HasTree_27(base.GetCppThis(), icursor) != 0;
		}

		// Token: 0x0601BC84 RID: 113796
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsA_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BC85 RID: 113797 RVA: 0x0026E784 File Offset: 0x0026C984
		public override int IsA(string type)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsA_28(base.GetCppThis(), type);
		}

		// Token: 0x0601BC86 RID: 113798
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsLeaf_29(HandleRef pThis);

		/// <summary>
		/// Is the cursor pointing to a leaf?
		/// </summary>
		// Token: 0x0601BC87 RID: 113799 RVA: 0x0026E7A4 File Offset: 0x0026C9A4
		public bool IsLeaf()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsLeaf_29(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BC88 RID: 113800
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsLeaf_30(HandleRef pThis, uint icursor);

		/// <summary>
		/// Is the cursor pointing to a leaf?
		/// </summary>
		// Token: 0x0601BC89 RID: 113801 RVA: 0x0026E7CC File Offset: 0x0026C9CC
		public bool IsLeaf(uint icursor)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsLeaf_30(base.GetCppThis(), icursor) != 0;
		}

		// Token: 0x0601BC8A RID: 113802
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsMasked_31(HandleRef pThis);

		/// <summary>
		/// Determine whether blanking mask is empty or not
		/// </summary>
		// Token: 0x0601BC8B RID: 113803 RVA: 0x0026E7F4 File Offset: 0x0026C9F4
		public bool IsMasked()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsMasked_31(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BC8C RID: 113804
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsMasked_32(HandleRef pThis, uint icursor);

		/// <summary>
		/// Determine whether blanking mask is empty or not
		/// </summary>
		// Token: 0x0601BC8D RID: 113805 RVA: 0x0026E81C File Offset: 0x0026CA1C
		public bool IsMasked(uint icursor)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsMasked_32(base.GetCppThis(), icursor) != 0;
		}

		// Token: 0x0601BC8E RID: 113806
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsRealLeaf_33(HandleRef pThis);

		/// <summary>
		/// Is the cursor pointing to a leaf?
		/// </summary>
		// Token: 0x0601BC8F RID: 113807 RVA: 0x0026E844 File Offset: 0x0026CA44
		public bool IsRealLeaf()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsRealLeaf_33(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BC90 RID: 113808
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsRealLeaf_34(HandleRef pThis, uint icursor);

		/// <summary>
		/// Is the cursor pointing to a leaf?
		/// </summary>
		// Token: 0x0601BC91 RID: 113809 RVA: 0x0026E86C File Offset: 0x0026CA6C
		public bool IsRealLeaf(uint icursor)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsRealLeaf_34(base.GetCppThis(), icursor) != 0;
		}

		// Token: 0x0601BC92 RID: 113810
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsRoot_35(HandleRef pThis);

		/// <summary>
		/// Is the cursor at tree root?
		/// </summary>
		// Token: 0x0601BC93 RID: 113811 RVA: 0x0026E894 File Offset: 0x0026CA94
		public bool IsRoot()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsRoot_35(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BC94 RID: 113812
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsTypeOf_36([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BC95 RID: 113813 RVA: 0x0026E8BC File Offset: 0x0026CABC
		public new static int IsTypeOf(string type)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsTypeOf_36(type);
		}

		// Token: 0x0601BC96 RID: 113814
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsVirtualLeaf_37(HandleRef pThis);

		/// <summary>
		/// Is the cursor pointing to a real node in the tree
		/// </summary>
		// Token: 0x0601BC97 RID: 113815 RVA: 0x0026E8D8 File Offset: 0x0026CAD8
		public bool IsVirtualLeaf()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsVirtualLeaf_37(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BC98 RID: 113816
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsVirtualLeaf_38(HandleRef pThis, uint icursor);

		/// <summary>
		/// Is the cursor pointing to a real node in the tree
		/// </summary>
		// Token: 0x0601BC99 RID: 113817 RVA: 0x0026E900 File Offset: 0x0026CB00
		public bool IsVirtualLeaf(uint icursor)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsVirtualLeaf_38(base.GetCppThis(), icursor) != 0;
		}

		// Token: 0x0601BC9A RID: 113818
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BC9B RID: 113819 RVA: 0x0026E928 File Offset: 0x0026CB28
		public new vtkHyperTreeGridNonOrientedUnlimitedSuperCursor NewInstance()
		{
			vtkHyperTreeGridNonOrientedUnlimitedSuperCursor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_NewInstance_39(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperTreeGridNonOrientedUnlimitedSuperCursor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BC9C RID: 113820
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_SafeDownCast_40(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BC9D RID: 113821 RVA: 0x0026E984 File Offset: 0x0026CB84
		public new static vtkHyperTreeGridNonOrientedUnlimitedSuperCursor SafeDownCast(vtkObjectBase o)
		{
			vtkHyperTreeGridNonOrientedUnlimitedSuperCursor vtkHyperTreeGridNonOrientedUnlimitedSuperCursor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_SafeDownCast_40((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperTreeGridNonOrientedUnlimitedSuperCursor = (vtkHyperTreeGridNonOrientedUnlimitedSuperCursor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.Register(null);
				}
			}
			return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor;
		}

		// Token: 0x0601BC9E RID: 113822
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_SetGlobalIndexFromLocal_41(HandleRef pThis, long index);

		/// <summary>
		/// JB
		/// </summary>
		// Token: 0x0601BC9F RID: 113823 RVA: 0x0026EA03 File Offset: 0x0026CC03
		public void SetGlobalIndexFromLocal(long index)
		{
			vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_SetGlobalIndexFromLocal_41(base.GetCppThis(), index);
		}

		// Token: 0x0601BCA0 RID: 113824
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_SetGlobalIndexStart_42(HandleRef pThis, long index);

		/// <summary>
		/// JB
		/// </summary>
		// Token: 0x0601BCA1 RID: 113825 RVA: 0x0026EA13 File Offset: 0x0026CC13
		public void SetGlobalIndexStart(long index)
		{
			vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_SetGlobalIndexStart_42(base.GetCppThis(), index);
		}

		// Token: 0x0601BCA2 RID: 113826
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_SetMask_43(HandleRef pThis, byte state);

		/// <summary>
		/// Set the blanking mask is empty or not
		/// \pre not_tree: tree
		/// </summary>
		// Token: 0x0601BCA3 RID: 113827 RVA: 0x0026EA23 File Offset: 0x0026CC23
		public void SetMask(bool state)
		{
			vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_SetMask_43(base.GetCppThis(), state ? (byte)1 : (byte)0);
		}

		// Token: 0x0601BCA4 RID: 113828
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_SetMask_44(HandleRef pThis, uint icursor, byte state);

		/// <summary>
		/// Set the blanking mask is empty or not
		/// \pre not_tree: tree
		/// </summary>
		// Token: 0x0601BCA5 RID: 113829 RVA: 0x0026EA3B File Offset: 0x0026CC3B
		public void SetMask(uint icursor, bool state)
		{
			vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_SetMask_44(base.GetCppThis(), icursor, state ? (byte)1 : (byte)0);
		}

		// Token: 0x0601BCA6 RID: 113830
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_ToChild_45(HandleRef pThis, byte ichild);

		/// <summary>
		/// Move the cursor to child `child' of the current vertex.
		/// \pre not_tree: HasTree()
		/// \pre not_leaf: !IsLeaf()
		/// \pre valid_child: ichild&gt;=0 &amp;&amp; ichild&lt;GetNumberOfChildren()
		/// \pre depth_limiter: GetLevel() &lt;= GetDepthLimiter()
		/// </summary>
		// Token: 0x0601BCA7 RID: 113831 RVA: 0x0026EA54 File Offset: 0x0026CC54
		public void ToChild(byte ichild)
		{
			vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_ToChild_45(base.GetCppThis(), ichild);
		}

		// Token: 0x0601BCA8 RID: 113832
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_ToParent_46(HandleRef pThis);

		/// <summary>
		/// Move the cursor to the parent of the current vertex.
		/// Authorized if HasHistory return true.
		/// \pre Non_root: !IsRoot()
		/// </summary>
		// Token: 0x0601BCA9 RID: 113833 RVA: 0x0026EA64 File Offset: 0x0026CC64
		public void ToParent()
		{
			vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_ToParent_46(base.GetCppThis());
		}

		// Token: 0x0601BCAA RID: 113834
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_ToRoot_47(HandleRef pThis);

		/// <summary>
		/// Move the cursor to the root vertex.
		/// \pre can be root
		/// \post is_root: IsRoot()
		/// </summary>
		// Token: 0x0601BCAB RID: 113835 RVA: 0x0026EA73 File Offset: 0x0026CC73
		public void ToRoot()
		{
			vtkHyperTreeGridNonOrientedUnlimitedSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_ToRoot_47(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DB6 RID: 7606
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DB7 RID: 7607
		public new static readonly string MRClassNameKey = "class vtkHyperTreeGridNonOrientedUnlimitedSuperCursor";
	}
}
