using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor
	/// </summary>
	/// <remarks>
	///    Objects for traversal a HyperTreeGrid.
	///
	/// JB A REVOIR
	/// NonOriented ne peut pas remonter plus haut qu'a sa creation.
	/// Objects that can perform depth traversal of a hyper tree grid,
	/// take into account more parameters (related to the grid structure) than
	/// the compact hyper tree cursor implemented in vtkHyperTree can.
	/// This is an abstract class.
	/// Cursors are created by the HyperTreeGrid implementation.
	///
	/// Geometry cursors allow to retrieve origin, size, bounds
	/// and central points
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHyperTreeCursor vtkHyperTree vtkHyperTreeGrid
	///
	/// @par Thanks:
	/// This class was written by Guenole Harel and Jacques-Bernard Lekien, 2014.
	/// This class was re-written by Philippe Pebay, 2016.
	/// JB This class was re-written for more optimisation by Jacques-Bernard Lekien,
	/// Guenole Harel and Jerome Dubois, 2018.
	/// This work was supported by Commissariat a l'Energie Atomique
	/// CEA, DAM, DIF, F-91297 Arpajon, France.
	/// </seealso>
	// Token: 0x02000A60 RID: 2656
	public class vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BC07 RID: 113671 RVA: 0x0026DD1B File Offset: 0x0026BF1B
		static vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BC08 RID: 113672 RVA: 0x0026DD43 File Offset: 0x0026BF43
		public vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BC09 RID: 113673
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BC0A RID: 113674 RVA: 0x0026DD54 File Offset: 0x0026BF54
		public new static vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor New()
		{
			vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BC0B RID: 113675 RVA: 0x0026DDA8 File Offset: 0x0026BFA8
		public vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BC0C RID: 113676 RVA: 0x0026DDEC File Offset: 0x0026BFEC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BC0D RID: 113677
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_Clone_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a copy of `this'.
		/// \post results_exists:result!=0
		/// </summary>
		// Token: 0x0601BC0E RID: 113678 RVA: 0x0026DDF8 File Offset: 0x0026BFF8
		public virtual vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor Clone()
		{
			vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_Clone_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor = (vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.Register(null);
				}
			}
			return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor;
		}

		// Token: 0x0601BC0F RID: 113679
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetBounds_02(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// JB
		/// </summary>
		// Token: 0x0601BC10 RID: 113680 RVA: 0x0026DE67 File Offset: 0x0026C067
		public void GetBounds(IntPtr bounds)
		{
			vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetBounds_02(base.GetCppThis(), bounds);
		}

		// Token: 0x0601BC11 RID: 113681
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetDimension_03(HandleRef pThis);

		/// <summary>
		/// Return the dimension of the tree.
		/// \post positive_result: result&gt;0
		/// </summary>
		// Token: 0x0601BC12 RID: 113682 RVA: 0x0026DE78 File Offset: 0x0026C078
		public byte GetDimension()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetDimension_03(base.GetCppThis());
		}

		// Token: 0x0601BC13 RID: 113683
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetGlobalNodeIndex_04(HandleRef pThis);

		/// <summary>
		/// Return the global index (relative to the grid) of the
		/// current vertex in the tree.
		/// </summary>
		// Token: 0x0601BC14 RID: 113684 RVA: 0x0026DE98 File Offset: 0x0026C098
		public long GetGlobalNodeIndex()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetGlobalNodeIndex_04(base.GetCppThis());
		}

		// Token: 0x0601BC15 RID: 113685
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetLastRealLevel_05(HandleRef pThis);

		/// <summary>
		/// Get the level of the tree vertex pointed by the cursor.
		/// </summary>
		// Token: 0x0601BC16 RID: 113686 RVA: 0x0026DEB8 File Offset: 0x0026C0B8
		public uint GetLastRealLevel()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetLastRealLevel_05(base.GetCppThis());
		}

		// Token: 0x0601BC17 RID: 113687
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetLevel_06(HandleRef pThis);

		/// <summary>
		/// Get the level of the tree vertex pointed by the cursor.
		/// </summary>
		// Token: 0x0601BC18 RID: 113688 RVA: 0x0026DED8 File Offset: 0x0026C0D8
		public uint GetLevel()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetLevel_06(base.GetCppThis());
		}

		// Token: 0x0601BC19 RID: 113689
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetNumberOfChildren_07(HandleRef pThis);

		/// <summary>
		/// Return the number of children for each node (non-vertex leaf) of the tree.
		/// \post positive_number: result&gt;0
		/// </summary>
		// Token: 0x0601BC1A RID: 113690 RVA: 0x0026DEF8 File Offset: 0x0026C0F8
		public byte GetNumberOfChildren()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetNumberOfChildren_07(base.GetCppThis());
		}

		// Token: 0x0601BC1B RID: 113691
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BC1C RID: 113692 RVA: 0x0026DF18 File Offset: 0x0026C118
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0601BC1D RID: 113693
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BC1E RID: 113694 RVA: 0x0026DF38 File Offset: 0x0026C138
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0601BC1F RID: 113695
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetOrigin_10(HandleRef pThis);

		/// <summary>
		/// JB
		/// </summary>
		// Token: 0x0601BC20 RID: 113696 RVA: 0x0026DF54 File Offset: 0x0026C154
		public IntPtr GetOrigin()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetOrigin_10(base.GetCppThis());
		}

		// Token: 0x0601BC21 RID: 113697
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetPoint_11(HandleRef pThis, IntPtr point);

		/// <summary>
		/// JB
		/// </summary>
		// Token: 0x0601BC22 RID: 113698 RVA: 0x0026DF73 File Offset: 0x0026C173
		public void GetPoint(IntPtr point)
		{
			vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetPoint_11(base.GetCppThis(), point);
		}

		// Token: 0x0601BC23 RID: 113699
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetSize_12(HandleRef pThis);

		/// <summary>
		/// JB
		/// </summary>
		// Token: 0x0601BC24 RID: 113700 RVA: 0x0026DF84 File Offset: 0x0026C184
		public IntPtr GetSize()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetSize_12(base.GetCppThis());
		}

		// Token: 0x0601BC25 RID: 113701
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetTree_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the hyper tree to which the cursor is pointing.
		/// </summary>
		// Token: 0x0601BC26 RID: 113702 RVA: 0x0026DFA4 File Offset: 0x0026C1A4
		public vtkHyperTree GetTree()
		{
			vtkHyperTree vtkHyperTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetTree_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601BC27 RID: 113703
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetVertexId_14(HandleRef pThis);

		/// <summary>
		/// Return the index of the current vertex in the tree.
		/// </summary>
		// Token: 0x0601BC28 RID: 113704 RVA: 0x0026E014 File Offset: 0x0026C214
		public long GetVertexId()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetVertexId_14(base.GetCppThis());
		}

		// Token: 0x0601BC29 RID: 113705
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_HasTree_15(HandleRef pThis);

		/// <summary>
		/// Return if a Tree pointing exist
		/// </summary>
		// Token: 0x0601BC2A RID: 113706 RVA: 0x0026E034 File Offset: 0x0026C234
		public bool HasTree()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_HasTree_15(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BC2B RID: 113707
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_Initialize_16(HandleRef pThis, HandleRef cursor);

		/// <summary>
		/// JB
		/// </summary>
		// Token: 0x0601BC2C RID: 113708 RVA: 0x0026E05C File Offset: 0x0026C25C
		public void Initialize(vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor cursor)
		{
			vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_Initialize_16(base.GetCppThis(), (cursor == null) ? default(HandleRef) : cursor.GetCppThis());
		}

		// Token: 0x0601BC2D RID: 113709
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BC2E RID: 113710 RVA: 0x0026E08C File Offset: 0x0026C28C
		public override int IsA(string type)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x0601BC2F RID: 113711
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsLeaf_18(HandleRef pThis);

		/// <summary>
		/// Is the cursor pointing to a leaf?
		/// only respect depth limited, otherwise return false
		/// </summary>
		// Token: 0x0601BC30 RID: 113712 RVA: 0x0026E0AC File Offset: 0x0026C2AC
		public bool IsLeaf()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsLeaf_18(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BC31 RID: 113713
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsMasked_19(HandleRef pThis);

		/// <summary>
		/// Determine whether blanking mask is empty or not
		/// </summary>
		// Token: 0x0601BC32 RID: 113714 RVA: 0x0026E0D4 File Offset: 0x0026C2D4
		public bool IsMasked()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsMasked_19(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BC33 RID: 113715
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsRealLeaf_20(HandleRef pThis);

		/// <summary>
		/// Is the cursor pointing to a leaf in the original tree ?
		/// Return false if the leaf is virtual.
		/// </summary>
		// Token: 0x0601BC34 RID: 113716 RVA: 0x0026E0FC File Offset: 0x0026C2FC
		public bool IsRealLeaf()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsRealLeaf_20(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BC35 RID: 113717
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsRoot_21(HandleRef pThis);

		/// <summary>
		/// Is the cursor at tree root?
		/// </summary>
		// Token: 0x0601BC36 RID: 113718 RVA: 0x0026E124 File Offset: 0x0026C324
		public bool IsRoot()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsRoot_21(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BC37 RID: 113719
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BC38 RID: 113720 RVA: 0x0026E14C File Offset: 0x0026C34C
		public new static int IsTypeOf(string type)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsTypeOf_22(type);
		}

		// Token: 0x0601BC39 RID: 113721
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsVirtualLeaf_23(HandleRef pThis);

		/// <summary>
		/// Is the cursor pointing to a subdivided leaf ?
		/// Return false if the leaf is a real one.
		/// </summary>
		// Token: 0x0601BC3A RID: 113722 RVA: 0x0026E168 File Offset: 0x0026C368
		public bool IsVirtualLeaf()
		{
			return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsVirtualLeaf_23(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BC3B RID: 113723
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BC3C RID: 113724 RVA: 0x0026E190 File Offset: 0x0026C390
		public new vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor NewInstance()
		{
			vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BC3D RID: 113725
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BC3E RID: 113726 RVA: 0x0026E1EC File Offset: 0x0026C3EC
		public new static vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor SafeDownCast(vtkObjectBase o)
		{
			vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor = (vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.Register(null);
				}
			}
			return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor;
		}

		// Token: 0x0601BC3F RID: 113727
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_SetGlobalIndexFromLocal_27(HandleRef pThis, long index);

		/// <summary>
		/// JB
		/// </summary>
		// Token: 0x0601BC40 RID: 113728 RVA: 0x0026E26B File Offset: 0x0026C46B
		public void SetGlobalIndexFromLocal(long index)
		{
			vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_SetGlobalIndexFromLocal_27(base.GetCppThis(), index);
		}

		// Token: 0x0601BC41 RID: 113729
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_SetGlobalIndexStart_28(HandleRef pThis, long index);

		/// <summary>
		/// JB
		/// </summary>
		// Token: 0x0601BC42 RID: 113730 RVA: 0x0026E27B File Offset: 0x0026C47B
		public void SetGlobalIndexStart(long index)
		{
			vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_SetGlobalIndexStart_28(base.GetCppThis(), index);
		}

		// Token: 0x0601BC43 RID: 113731
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_SetMask_29(HandleRef pThis, byte state);

		/// <summary>
		/// Set the blanking mask is empty or not
		/// \pre not_tree: tree
		/// </summary>
		// Token: 0x0601BC44 RID: 113732 RVA: 0x0026E28B File Offset: 0x0026C48B
		public void SetMask(bool state)
		{
			vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_SetMask_29(base.GetCppThis(), state ? (byte)1 : (byte)0);
		}

		// Token: 0x0601BC45 RID: 113733
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_ToChild_30(HandleRef pThis, byte ichild);

		/// <summary>
		/// Move the cursor to child `child' of the current vertex.
		/// \pre not_tree: HasTree()
		/// \pre not_leaf: !IsLeaf()
		/// \pre valid_child: ichild&gt;=0 &amp;&amp; ichild&lt;GetNumberOfChildren()
		/// \pre depth_limiter: GetLevel() &lt;= GetDepthLimiter()
		/// </summary>
		// Token: 0x0601BC46 RID: 113734 RVA: 0x0026E2A3 File Offset: 0x0026C4A3
		public void ToChild(byte ichild)
		{
			vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_ToChild_30(base.GetCppThis(), ichild);
		}

		// Token: 0x0601BC47 RID: 113735
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_ToParent_31(HandleRef pThis);

		/// <summary>
		/// Move the cursor to the parent of the current vertex.
		/// Authorized if HasHistory return true.
		/// \pre Non_root: !IsRoot()
		/// </summary>
		// Token: 0x0601BC48 RID: 113736 RVA: 0x0026E2B3 File Offset: 0x0026C4B3
		public void ToParent()
		{
			vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_ToParent_31(base.GetCppThis());
		}

		// Token: 0x0601BC49 RID: 113737
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_ToRoot_32(HandleRef pThis);

		/// <summary>
		/// Move the cursor to the root vertex.
		/// \pre can be root
		/// \post is_root: IsRoot()
		/// </summary>
		// Token: 0x0601BC4A RID: 113738 RVA: 0x0026E2C2 File Offset: 0x0026C4C2
		public void ToRoot()
		{
			vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_ToRoot_32(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DB4 RID: 7604
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DB5 RID: 7605
		public new static readonly string MRClassNameKey = "class vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor";
	}
}
