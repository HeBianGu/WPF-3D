using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTreeMapLayoutStrategy
	/// </summary>
	/// <remarks>
	///    abstract superclass for all tree map layout strategies
	///
	///
	/// All subclasses of this class perform a tree map layout on a tree.
	/// This involves assigning a rectangular region to each vertex in the tree,
	/// and placing that information in a data array with four components per
	/// tuple representing (Xmin, Xmax, Ymin, Ymax).
	///
	/// Instances of subclasses of this class may be assigned as the layout
	/// strategy to vtkTreeMapLayout
	///
	/// @par Thanks:
	/// Thanks to Brian Wylie and Ken Moreland from Sandia National Laboratories
	/// for help developing this class.
	/// </remarks>
	// Token: 0x02000280 RID: 640
	public abstract class vtkTreeMapLayoutStrategy : vtkAreaLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007430 RID: 29744 RVA: 0x000A7E6F File Offset: 0x000A606F
		static vtkTreeMapLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeMapLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeMapLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007431 RID: 29745 RVA: 0x000A7E97 File Offset: 0x000A6097
		public vtkTreeMapLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007432 RID: 29746 RVA: 0x000A7EA5 File Offset: 0x000A60A5
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007433 RID: 29747
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeMapLayoutStrategy_FindVertex_01(HandleRef pThis, HandleRef tree, HandleRef areaArray, IntPtr pnt);

		/// <summary>
		/// Find the vertex at a certain location, or -1 if none found.
		/// </summary>
		// Token: 0x06007434 RID: 29748 RVA: 0x000A7EB0 File Offset: 0x000A60B0
		public override long FindVertex(vtkTree tree, vtkDataArray areaArray, IntPtr pnt)
		{
			return vtkTreeMapLayoutStrategy.vtkTreeMapLayoutStrategy_FindVertex_01(base.GetCppThis(), (tree == null) ? default(HandleRef) : tree.GetCppThis(), (areaArray == null) ? default(HandleRef) : areaArray.GetCppThis(), pnt);
		}

		// Token: 0x06007435 RID: 29749
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeMapLayoutStrategy_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007436 RID: 29750 RVA: 0x000A7EFC File Offset: 0x000A60FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTreeMapLayoutStrategy.vtkTreeMapLayoutStrategy_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06007437 RID: 29751
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeMapLayoutStrategy_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007438 RID: 29752 RVA: 0x000A7F1C File Offset: 0x000A611C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTreeMapLayoutStrategy.vtkTreeMapLayoutStrategy_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06007439 RID: 29753
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeMapLayoutStrategy_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600743A RID: 29754 RVA: 0x000A7F38 File Offset: 0x000A6138
		public override int IsA(string type)
		{
			return vtkTreeMapLayoutStrategy.vtkTreeMapLayoutStrategy_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600743B RID: 29755
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeMapLayoutStrategy_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600743C RID: 29756 RVA: 0x000A7F58 File Offset: 0x000A6158
		public new static int IsTypeOf(string type)
		{
			return vtkTreeMapLayoutStrategy.vtkTreeMapLayoutStrategy_IsTypeOf_05(type);
		}

		// Token: 0x0600743D RID: 29757
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeMapLayoutStrategy_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600743E RID: 29758 RVA: 0x000A7F74 File Offset: 0x000A6174
		public new vtkTreeMapLayoutStrategy NewInstance()
		{
			vtkTreeMapLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeMapLayoutStrategy.vtkTreeMapLayoutStrategy_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeMapLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600743F RID: 29759
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeMapLayoutStrategy_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007440 RID: 29760 RVA: 0x000A7FD0 File Offset: 0x000A61D0
		public new static vtkTreeMapLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkTreeMapLayoutStrategy vtkTreeMapLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeMapLayoutStrategy.vtkTreeMapLayoutStrategy_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeMapLayoutStrategy = (vtkTreeMapLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeMapLayoutStrategy.Register(null);
				}
			}
			return vtkTreeMapLayoutStrategy;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A0E RID: 2574
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeMapLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A0F RID: 2575
		public new static readonly string MRClassNameKey = "class vtkTreeMapLayoutStrategy";
	}
}
