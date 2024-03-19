using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAssemblyPath
	/// </summary>
	/// <remarks>
	///    a list of nodes that form an assembly path
	///
	/// vtkAssemblyPath represents an ordered list of assembly nodes that
	/// represent a fully evaluated assembly path. This class is used primarily
	/// for picking. Note that the use of this class is to add one or more
	/// assembly nodes to form the path. (An assembly node consists of an instance
	/// of vtkProp and vtkMatrix4x4, the matrix may be NULL.) As each node is
	/// added, the matrices are concatenated to create a final, evaluated matrix.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAssemblyNode vtkAssembly vtkActor vtkMatrix4x4 vtkProp vtkAbstractPicker
	/// </seealso>
	// Token: 0x0200080E RID: 2062
	public class vtkAssemblyPath : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015348 RID: 86856 RVA: 0x001E02B7 File Offset: 0x001DE4B7
		static vtkAssemblyPath()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAssemblyPath.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAssemblyPath"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015349 RID: 86857 RVA: 0x001E02DF File Offset: 0x001DE4DF
		public vtkAssemblyPath(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601534A RID: 86858
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssemblyPath_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate empty path with identify matrix.
		/// </summary>
		// Token: 0x0601534B RID: 86859 RVA: 0x001E02F0 File Offset: 0x001DE4F0
		public new static vtkAssemblyPath New()
		{
			vtkAssemblyPath result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssemblyPath.vtkAssemblyPath_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate empty path with identify matrix.
		/// </summary>
		// Token: 0x0601534C RID: 86860 RVA: 0x001E0344 File Offset: 0x001DE544
		public vtkAssemblyPath() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAssemblyPath.vtkAssemblyPath_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601534D RID: 86861 RVA: 0x001E0388 File Offset: 0x001DE588
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601534E RID: 86862
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssemblyPath_AddNode_01(HandleRef pThis, HandleRef p, HandleRef m);

		/// <summary>
		/// Convenience method adds a prop and matrix together,
		/// creating an assembly node transparently. The matrix
		/// pointer m may be NULL. Note: that matrix is the one,
		/// if any, associated with the prop.
		/// </summary>
		// Token: 0x0601534F RID: 86863 RVA: 0x001E0394 File Offset: 0x001DE594
		public void AddNode(vtkProp p, vtkMatrix4x4 m)
		{
			vtkAssemblyPath.vtkAssemblyPath_AddNode_01(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		// Token: 0x06015350 RID: 86864
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssemblyPath_DeleteLastNode_02(HandleRef pThis);

		/// <summary>
		/// Delete the last assembly node in the list. This is like
		/// a stack pop.
		/// </summary>
		// Token: 0x06015351 RID: 86865 RVA: 0x001E03D8 File Offset: 0x001DE5D8
		public void DeleteLastNode()
		{
			vtkAssemblyPath.vtkAssemblyPath_DeleteLastNode_02(base.GetCppThis());
		}

		// Token: 0x06015352 RID: 86866
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssemblyPath_GetFirstNode_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the first assembly node in the list. See the comments for
		/// GetNextNode() regarding the contents of the returned node. (Note: This
		/// node corresponds to the vtkProp associated with the vtkRenderer.
		/// </summary>
		// Token: 0x06015353 RID: 86867 RVA: 0x001E03E8 File Offset: 0x001DE5E8
		public vtkAssemblyNode GetFirstNode()
		{
			vtkAssemblyNode vtkAssemblyNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssemblyPath.vtkAssemblyPath_GetFirstNode_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyNode = (vtkAssemblyNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyNode.Register(null);
				}
			}
			return vtkAssemblyNode;
		}

		// Token: 0x06015354 RID: 86868
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssemblyPath_GetLastNode_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the last assembly node in the list. See the comments
		/// for GetNextNode() regarding the contents of the returned node.
		/// </summary>
		// Token: 0x06015355 RID: 86869 RVA: 0x001E0458 File Offset: 0x001DE658
		public vtkAssemblyNode GetLastNode()
		{
			vtkAssemblyNode vtkAssemblyNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssemblyPath.vtkAssemblyPath_GetLastNode_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyNode = (vtkAssemblyNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyNode.Register(null);
				}
			}
			return vtkAssemblyNode;
		}

		// Token: 0x06015356 RID: 86870
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkAssemblyPath_GetMTime_05(HandleRef pThis);

		/// <summary>
		/// Override the standard GetMTime() to check for the modified times
		/// of the nodes in this path.
		/// </summary>
		// Token: 0x06015357 RID: 86871 RVA: 0x001E04C8 File Offset: 0x001DE6C8
		public override ulong GetMTime()
		{
			return vtkAssemblyPath.vtkAssemblyPath_GetMTime_05(base.GetCppThis());
		}

		// Token: 0x06015358 RID: 86872
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssemblyPath_GetNextNode_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next assembly node in the list. The node returned
		/// contains a pointer to a prop and a 4x4 matrix. The matrix
		/// is evaluated based on the preceding assembly hierarchy
		/// (i.e., the matrix is not necessarily as the same as the
		/// one that was added with AddNode() because of the
		/// concatenation of matrices in the assembly hierarchy).
		/// </summary>
		// Token: 0x06015359 RID: 86873 RVA: 0x001E04E8 File Offset: 0x001DE6E8
		public vtkAssemblyNode GetNextNode()
		{
			vtkAssemblyNode vtkAssemblyNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssemblyPath.vtkAssemblyPath_GetNextNode_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyNode = (vtkAssemblyNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyNode.Register(null);
				}
			}
			return vtkAssemblyNode;
		}

		// Token: 0x0601535A RID: 86874
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAssemblyPath_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601535B RID: 86875 RVA: 0x001E0558 File Offset: 0x001DE758
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAssemblyPath.vtkAssemblyPath_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601535C RID: 86876
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAssemblyPath_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601535D RID: 86877 RVA: 0x001E0578 File Offset: 0x001DE778
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAssemblyPath.vtkAssemblyPath_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601535E RID: 86878
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAssemblyPath_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601535F RID: 86879 RVA: 0x001E0594 File Offset: 0x001DE794
		public override int IsA(string type)
		{
			return vtkAssemblyPath.vtkAssemblyPath_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06015360 RID: 86880
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAssemblyPath_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015361 RID: 86881 RVA: 0x001E05B4 File Offset: 0x001DE7B4
		public new static int IsTypeOf(string type)
		{
			return vtkAssemblyPath.vtkAssemblyPath_IsTypeOf_10(type);
		}

		// Token: 0x06015362 RID: 86882
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssemblyPath_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015363 RID: 86883 RVA: 0x001E05D0 File Offset: 0x001DE7D0
		public new vtkAssemblyPath NewInstance()
		{
			vtkAssemblyPath result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssemblyPath.vtkAssemblyPath_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015364 RID: 86884
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssemblyPath_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015365 RID: 86885 RVA: 0x001E062C File Offset: 0x001DE82C
		public new static vtkAssemblyPath SafeDownCast(vtkObjectBase o)
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssemblyPath.vtkAssemblyPath_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyPath = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyPath.Register(null);
				}
			}
			return vtkAssemblyPath;
		}

		// Token: 0x06015366 RID: 86886
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssemblyPath_ShallowCopy_14(HandleRef pThis, HandleRef path);

		/// <summary>
		/// Perform a shallow copy (reference counted) on the
		/// incoming path.
		/// </summary>
		// Token: 0x06015367 RID: 86887 RVA: 0x001E06AC File Offset: 0x001DE8AC
		public void ShallowCopy(vtkAssemblyPath path)
		{
			vtkAssemblyPath.vtkAssemblyPath_ShallowCopy_14(base.GetCppThis(), (path == null) ? default(HandleRef) : path.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001864 RID: 6244
		public new const string MRFullTypeName = "Kitware.VTK.vtkAssemblyPath";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001865 RID: 6245
		public new static readonly string MRClassNameKey = "class vtkAssemblyPath";
	}
}
