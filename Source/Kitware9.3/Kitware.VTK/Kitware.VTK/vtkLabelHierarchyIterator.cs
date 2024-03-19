using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLabelHierarchyIterator
	/// </summary>
	/// <remarks>
	///    iterator over vtkLabelHierarchy
	///
	///
	/// Abstract superclass for iterators over vtkLabelHierarchy.
	/// </remarks>
	// Token: 0x020000EE RID: 238
	public abstract class vtkLabelHierarchyIterator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003176 RID: 12662 RVA: 0x00048F3B File Offset: 0x0004713B
		static vtkLabelHierarchyIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabelHierarchyIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelHierarchyIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003177 RID: 12663 RVA: 0x00048F63 File Offset: 0x00047163
		public vtkLabelHierarchyIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003178 RID: 12664 RVA: 0x00048F71 File Offset: 0x00047171
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003179 RID: 12665
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyIterator_Begin_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Initializes the iterator. lastLabels is an array holding labels
		/// which should be traversed before any other labels in the hierarchy.
		/// This could include labels placed during a previous rendering or
		/// a label located under the mouse pointer. You may pass a null pointer.
		/// </summary>
		// Token: 0x0600317A RID: 12666 RVA: 0x00048F7C File Offset: 0x0004717C
		public virtual void Begin(vtkIdTypeArray arg0)
		{
			vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_Begin_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600317B RID: 12667
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyIterator_BoxAllNodes_02(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add a representation for all existing octree nodes to the specified polydata.
		/// This is equivalent to setting TraversedBounds, iterating over the entire hierarchy,
		/// and then resetting TraversedBounds to its original value.
		/// </summary>
		// Token: 0x0600317C RID: 12668 RVA: 0x00048FAC File Offset: 0x000471AC
		public virtual void BoxAllNodes(vtkPolyData arg0)
		{
			vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_BoxAllNodes_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600317D RID: 12669
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyIterator_BoxNode_03(HandleRef pThis);

		/// <summary>
		/// Add a representation to TraversedBounds for the current octree node.
		/// This should be called by subclasses inside Next().
		/// Does nothing if TraversedBounds is NULL.
		/// </summary>
		// Token: 0x0600317E RID: 12670 RVA: 0x00048FDB File Offset: 0x000471DB
		public virtual void BoxNode()
		{
			vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_BoxNode_03(base.GetCppThis());
		}

		// Token: 0x0600317F RID: 12671
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelHierarchyIterator_GetAllBounds_04(HandleRef pThis);

		/// <summary>
		/// Set/get whether all nodes in the hierarchy should be added to the TraversedBounds
		/// polydata or only those traversed.
		/// When non-zero, all nodes will be added.
		/// By default, AllBounds is 0.
		/// </summary>
		// Token: 0x06003180 RID: 12672 RVA: 0x00048FEC File Offset: 0x000471EC
		public virtual int GetAllBounds()
		{
			return vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetAllBounds_04(base.GetCppThis());
		}

		// Token: 0x06003181 RID: 12673
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyIterator_GetBoundedSize_05(HandleRef pThis, IntPtr sz);

		/// <summary>
		/// Retrieves the current label maximum width in world coordinates.
		/// </summary>
		// Token: 0x06003182 RID: 12674 RVA: 0x0004900B File Offset: 0x0004720B
		public virtual void GetBoundedSize(IntPtr sz)
		{
			vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetBoundedSize_05(base.GetCppThis(), sz);
		}

		// Token: 0x06003183 RID: 12675
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchyIterator_GetHierarchy_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the label hierarchy associated with the current label.
		/// </summary>
		// Token: 0x06003184 RID: 12676 RVA: 0x0004901C File Offset: 0x0004721C
		public virtual vtkLabelHierarchy GetHierarchy()
		{
			vtkLabelHierarchy vtkLabelHierarchy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetHierarchy_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelHierarchy = (vtkLabelHierarchy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelHierarchy.Register(null);
				}
			}
			return vtkLabelHierarchy;
		}

		// Token: 0x06003185 RID: 12677
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkLabelHierarchyIterator_GetLabel_07(HandleRef pThis);

		/// <summary>
		/// Retrieves the current label string.
		/// </summary>
		// Token: 0x06003186 RID: 12678 RVA: 0x0004908C File Offset: 0x0004728C
		public virtual string GetLabel()
		{
			return vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetLabel_07(base.GetCppThis());
		}

		// Token: 0x06003187 RID: 12679
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelHierarchyIterator_GetLabelId_08(HandleRef pThis);

		/// <summary>
		/// Retrieves the current label id.
		/// </summary>
		// Token: 0x06003188 RID: 12680 RVA: 0x000490AC File Offset: 0x000472AC
		public virtual long GetLabelId()
		{
			return vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetLabelId_08(base.GetCppThis());
		}

		// Token: 0x06003189 RID: 12681
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyIterator_GetNodeGeometry_09(HandleRef pThis, IntPtr ctr, ref double size);

		/// <summary>
		/// Retrieve the coordinates of the center of the current hierarchy node
		/// and the size of the node.
		/// Nodes are n-cubes, so the size is the length of any edge of the cube.
		/// This is used by BoxNode().
		/// </summary>
		// Token: 0x0600318A RID: 12682 RVA: 0x000490CB File Offset: 0x000472CB
		public virtual void GetNodeGeometry(IntPtr ctr, ref double size)
		{
			vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetNodeGeometry_09(base.GetCppThis(), ctr, ref size);
		}

		// Token: 0x0600318B RID: 12683
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelHierarchyIterator_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600318C RID: 12684 RVA: 0x000490DC File Offset: 0x000472DC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0600318D RID: 12685
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelHierarchyIterator_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600318E RID: 12686 RVA: 0x000490FC File Offset: 0x000472FC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0600318F RID: 12687
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLabelHierarchyIterator_GetOrientation_12(HandleRef pThis);

		/// <summary>
		/// Retrieves the current label orientation.
		/// </summary>
		// Token: 0x06003190 RID: 12688 RVA: 0x00049118 File Offset: 0x00047318
		public virtual double GetOrientation()
		{
			return vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetOrientation_12(base.GetCppThis());
		}

		// Token: 0x06003191 RID: 12689
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyIterator_GetPoint_13(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Retrieves the current label location.
		/// </summary>
		// Token: 0x06003192 RID: 12690 RVA: 0x00049137 File Offset: 0x00047337
		public virtual void GetPoint(IntPtr x)
		{
			vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetPoint_13(base.GetCppThis(), x);
		}

		// Token: 0x06003193 RID: 12691
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyIterator_GetSize_14(HandleRef pThis, IntPtr sz);

		/// <summary>
		/// Retrieves the current label size.
		/// </summary>
		// Token: 0x06003194 RID: 12692 RVA: 0x00049147 File Offset: 0x00047347
		public virtual void GetSize(IntPtr sz)
		{
			vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetSize_14(base.GetCppThis(), sz);
		}

		// Token: 0x06003195 RID: 12693
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelHierarchyIterator_GetType_15(HandleRef pThis);

		/// <summary>
		/// Retrieves the current label type.
		/// </summary>
		// Token: 0x06003196 RID: 12694 RVA: 0x00049158 File Offset: 0x00047358
		public virtual int GetTypeWrapper()
		{
			return vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_GetType_15(base.GetCppThis());
		}

		// Token: 0x06003197 RID: 12695
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelHierarchyIterator_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003198 RID: 12696 RVA: 0x00049178 File Offset: 0x00047378
		public override int IsA(string type)
		{
			return vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06003199 RID: 12697
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLabelHierarchyIterator_IsAtEnd_17(HandleRef pThis);

		/// <summary>
		/// Returns true if the iterator is at the end.
		/// </summary>
		// Token: 0x0600319A RID: 12698 RVA: 0x00049198 File Offset: 0x00047398
		public virtual bool IsAtEnd()
		{
			return vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_IsAtEnd_17(base.GetCppThis()) != 0;
		}

		// Token: 0x0600319B RID: 12699
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelHierarchyIterator_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600319C RID: 12700 RVA: 0x000491C0 File Offset: 0x000473C0
		public new static int IsTypeOf(string type)
		{
			return vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_IsTypeOf_18(type);
		}

		// Token: 0x0600319D RID: 12701
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchyIterator_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600319E RID: 12702 RVA: 0x000491DC File Offset: 0x000473DC
		public new vtkLabelHierarchyIterator NewInstance()
		{
			vtkLabelHierarchyIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelHierarchyIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600319F RID: 12703
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyIterator_Next_20(HandleRef pThis);

		/// <summary>
		/// Advance the iterator.
		/// </summary>
		// Token: 0x060031A0 RID: 12704 RVA: 0x00049236 File Offset: 0x00047436
		public virtual void Next()
		{
			vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_Next_20(base.GetCppThis());
		}

		// Token: 0x060031A1 RID: 12705
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchyIterator_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060031A2 RID: 12706 RVA: 0x00049248 File Offset: 0x00047448
		public new static vtkLabelHierarchyIterator SafeDownCast(vtkObjectBase o)
		{
			vtkLabelHierarchyIterator vtkLabelHierarchyIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelHierarchyIterator = (vtkLabelHierarchyIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelHierarchyIterator.Register(null);
				}
			}
			return vtkLabelHierarchyIterator;
		}

		// Token: 0x060031A3 RID: 12707
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyIterator_SetAllBounds_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get whether all nodes in the hierarchy should be added to the TraversedBounds
		/// polydata or only those traversed.
		/// When non-zero, all nodes will be added.
		/// By default, AllBounds is 0.
		/// </summary>
		// Token: 0x060031A4 RID: 12708 RVA: 0x000492C7 File Offset: 0x000474C7
		public virtual void SetAllBounds(int _arg)
		{
			vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_SetAllBounds_22(base.GetCppThis(), _arg);
		}

		// Token: 0x060031A5 RID: 12709
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyIterator_SetTraversedBounds_23(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Sets a polydata to fill with geometry representing
		/// the bounding boxes of the traversed octree nodes.
		/// </summary>
		// Token: 0x060031A6 RID: 12710 RVA: 0x000492D8 File Offset: 0x000474D8
		public virtual void SetTraversedBounds(vtkPolyData arg0)
		{
			vtkLabelHierarchyIterator.vtkLabelHierarchyIterator_SetTraversedBounds_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005E6 RID: 1510
		public new const string MRFullTypeName = "Kitware.VTK.vtkLabelHierarchyIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005E7 RID: 1511
		public new static readonly string MRClassNameKey = "class vtkLabelHierarchyIterator";
	}
}
