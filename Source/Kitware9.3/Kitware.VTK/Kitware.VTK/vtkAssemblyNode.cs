using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAssemblyNode
	/// </summary>
	/// <remarks>
	///    represent a node in an assembly
	///
	/// vtkAssemblyNode represents a node in an assembly. It is used by
	/// vtkAssemblyPath to create hierarchical assemblies of props. The
	/// props can be either 2D or 3D.
	///
	/// An assembly node refers to a vtkProp, and possibly a vtkMatrix4x4.
	/// Nodes are used by vtkAssemblyPath to build fully evaluated path
	/// (matrices are concatenated through the path) that is used by picking
	/// and other operations involving assemblies.
	///
	/// @warning
	/// The assembly node is guaranteed to contain a reference to an instance
	/// of vtkMatrix4x4 if the prop referred to by the node is of type
	/// vtkProp3D (or subclass). The matrix is evaluated through the assembly
	/// path, so the assembly node's matrix is a function of its location in
	/// the vtkAssemblyPath.
	///
	/// @warning
	/// vtkAssemblyNode does not reference count its association with vtkProp.
	/// Therefore, do not create an assembly node, associate a prop with it,
	/// delete the prop, and then try to dereference the prop. The program
	/// will break! (Reason: vtkAssemblyPath (which uses vtkAssemblyNode)
	/// create self-referencing loops that destroy reference counting.)
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAssemblyPath vtkProp vtkPicker vtkMatrix4x4
	/// </seealso>
	// Token: 0x0200080D RID: 2061
	public class vtkAssemblyNode : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601532C RID: 86828 RVA: 0x001DFF27 File Offset: 0x001DE127
		static vtkAssemblyNode()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAssemblyNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAssemblyNode"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601532D RID: 86829 RVA: 0x001DFF4F File Offset: 0x001DE14F
		public vtkAssemblyNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601532E RID: 86830
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssemblyNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create an assembly node.
		/// </summary>
		// Token: 0x0601532F RID: 86831 RVA: 0x001DFF60 File Offset: 0x001DE160
		public new static vtkAssemblyNode New()
		{
			vtkAssemblyNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssemblyNode.vtkAssemblyNode_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssemblyNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create an assembly node.
		/// </summary>
		// Token: 0x06015330 RID: 86832 RVA: 0x001DFFB4 File Offset: 0x001DE1B4
		public vtkAssemblyNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAssemblyNode.vtkAssemblyNode_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015331 RID: 86833 RVA: 0x001DFFF8 File Offset: 0x001DE1F8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015332 RID: 86834
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkAssemblyNode_GetMTime_01(HandleRef pThis);

		/// <summary>
		/// Override the standard GetMTime() to check for the modified times
		/// of the prop and matrix.
		/// </summary>
		// Token: 0x06015333 RID: 86835 RVA: 0x001E0004 File Offset: 0x001DE204
		public override ulong GetMTime()
		{
			return vtkAssemblyNode.vtkAssemblyNode_GetMTime_01(base.GetCppThis());
		}

		// Token: 0x06015334 RID: 86836
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssemblyNode_GetMatrix_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a transformation matrix associated with the prop.
		/// Note: if the prop is not a type of vtkProp3D, then the
		/// transformation matrix is ignored (and expected to be NULL).
		/// Also, internal to this object the matrix is copied because
		/// the matrix is used for computation by vtkAssemblyPath.
		/// </summary>
		// Token: 0x06015335 RID: 86837 RVA: 0x001E0024 File Offset: 0x001DE224
		public virtual vtkMatrix4x4 GetMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssemblyNode.vtkAssemblyNode_GetMatrix_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x06015336 RID: 86838
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAssemblyNode_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create an assembly node.
		/// </summary>
		// Token: 0x06015337 RID: 86839 RVA: 0x001E0094 File Offset: 0x001DE294
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAssemblyNode.vtkAssemblyNode_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06015338 RID: 86840
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAssemblyNode_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create an assembly node.
		/// </summary>
		// Token: 0x06015339 RID: 86841 RVA: 0x001E00B4 File Offset: 0x001DE2B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAssemblyNode.vtkAssemblyNode_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601533A RID: 86842
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssemblyNode_GetViewProp_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the prop that this assembly node refers to.
		/// </summary>
		// Token: 0x0601533B RID: 86843 RVA: 0x001E00D0 File Offset: 0x001DE2D0
		public virtual vtkProp GetViewProp()
		{
			vtkProp vtkProp = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssemblyNode.vtkAssemblyNode_GetViewProp_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp = (vtkProp)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp.Register(null);
				}
			}
			return vtkProp;
		}

		// Token: 0x0601533C RID: 86844
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAssemblyNode_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create an assembly node.
		/// </summary>
		// Token: 0x0601533D RID: 86845 RVA: 0x001E0140 File Offset: 0x001DE340
		public override int IsA(string type)
		{
			return vtkAssemblyNode.vtkAssemblyNode_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601533E RID: 86846
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAssemblyNode_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create an assembly node.
		/// </summary>
		// Token: 0x0601533F RID: 86847 RVA: 0x001E0160 File Offset: 0x001DE360
		public new static int IsTypeOf(string type)
		{
			return vtkAssemblyNode.vtkAssemblyNode_IsTypeOf_07(type);
		}

		// Token: 0x06015340 RID: 86848
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssemblyNode_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create an assembly node.
		/// </summary>
		// Token: 0x06015341 RID: 86849 RVA: 0x001E017C File Offset: 0x001DE37C
		public new vtkAssemblyNode NewInstance()
		{
			vtkAssemblyNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssemblyNode.vtkAssemblyNode_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssemblyNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015342 RID: 86850
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssemblyNode_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create an assembly node.
		/// </summary>
		// Token: 0x06015343 RID: 86851 RVA: 0x001E01D8 File Offset: 0x001DE3D8
		public new static vtkAssemblyNode SafeDownCast(vtkObjectBase o)
		{
			vtkAssemblyNode vtkAssemblyNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssemblyNode.vtkAssemblyNode_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06015344 RID: 86852
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssemblyNode_SetMatrix_11(HandleRef pThis, HandleRef matrix);

		/// <summary>
		/// Specify a transformation matrix associated with the prop.
		/// Note: if the prop is not a type of vtkProp3D, then the
		/// transformation matrix is ignored (and expected to be NULL).
		/// Also, internal to this object the matrix is copied because
		/// the matrix is used for computation by vtkAssemblyPath.
		/// </summary>
		// Token: 0x06015345 RID: 86853 RVA: 0x001E0258 File Offset: 0x001DE458
		public void SetMatrix(vtkMatrix4x4 matrix)
		{
			vtkAssemblyNode.vtkAssemblyNode_SetMatrix_11(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x06015346 RID: 86854
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssemblyNode_SetViewProp_12(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Set/Get the prop that this assembly node refers to.
		/// </summary>
		// Token: 0x06015347 RID: 86855 RVA: 0x001E0288 File Offset: 0x001DE488
		public virtual void SetViewProp(vtkProp prop)
		{
			vtkAssemblyNode.vtkAssemblyNode_SetViewProp_12(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001862 RID: 6242
		public new const string MRFullTypeName = "Kitware.VTK.vtkAssemblyNode";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001863 RID: 6243
		public new static readonly string MRClassNameKey = "class vtkAssemblyNode";
	}
}
