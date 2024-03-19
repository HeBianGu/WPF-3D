using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMapperNode
	/// </summary>
	/// <remarks>
	///    vtkViewNode specialized for vtkMappers
	///
	/// State storage and graph traversal for vtkMapper
	/// </remarks>
	// Token: 0x0200021B RID: 539
	public class vtkMapperNode : vtkViewNode
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006629 RID: 26153 RVA: 0x000932AF File Offset: 0x000914AF
		static vtkMapperNode()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMapperNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMapperNode"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600662A RID: 26154 RVA: 0x000932D7 File Offset: 0x000914D7
		public vtkMapperNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600662B RID: 26155
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapperNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600662C RID: 26156 RVA: 0x000932E8 File Offset: 0x000914E8
		public new static vtkMapperNode New()
		{
			vtkMapperNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapperNode.vtkMapperNode_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMapperNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600662D RID: 26157 RVA: 0x0009333C File Offset: 0x0009153C
		public vtkMapperNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMapperNode.vtkMapperNode_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600662E RID: 26158 RVA: 0x00093380 File Offset: 0x00091580
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600662F RID: 26159
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMapperNode_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006630 RID: 26160 RVA: 0x0009338C File Offset: 0x0009158C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMapperNode.vtkMapperNode_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06006631 RID: 26161
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMapperNode_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006632 RID: 26162 RVA: 0x000933AC File Offset: 0x000915AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMapperNode.vtkMapperNode_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06006633 RID: 26163
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapperNode_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006634 RID: 26164 RVA: 0x000933C8 File Offset: 0x000915C8
		public override int IsA(string type)
		{
			return vtkMapperNode.vtkMapperNode_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06006635 RID: 26165
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapperNode_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006636 RID: 26166 RVA: 0x000933E8 File Offset: 0x000915E8
		public new static int IsTypeOf(string type)
		{
			return vtkMapperNode.vtkMapperNode_IsTypeOf_04(type);
		}

		// Token: 0x06006637 RID: 26167
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapperNode_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006638 RID: 26168 RVA: 0x00093404 File Offset: 0x00091604
		public new vtkMapperNode NewInstance()
		{
			vtkMapperNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapperNode.vtkMapperNode_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMapperNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006639 RID: 26169
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapperNode_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600663A RID: 26170 RVA: 0x00093460 File Offset: 0x00091660
		public new static vtkMapperNode SafeDownCast(vtkObjectBase o)
		{
			vtkMapperNode vtkMapperNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapperNode.vtkMapperNode_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMapperNode = (vtkMapperNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMapperNode.Register(null);
				}
			}
			return vtkMapperNode;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400091D RID: 2333
		public new const string MRFullTypeName = "Kitware.VTK.vtkMapperNode";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400091E RID: 2334
		public new static readonly string MRClassNameKey = "class vtkMapperNode";
	}
}
