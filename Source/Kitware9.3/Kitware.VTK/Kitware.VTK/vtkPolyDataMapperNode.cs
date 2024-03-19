using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataMapperNode
	/// </summary>
	/// <remarks>
	///    vtkViewNode specialized for vtkPolyDataMappers
	///
	/// State storage and graph traversal for vtkPolyDataMapper/PolyDataMapper and Property
	/// Made a choice to merge PolyDataMapper, PolyDataMapper and property together. If there
	/// is a compelling reason to separate them we can.
	/// </remarks>
	// Token: 0x0200021C RID: 540
	public class vtkPolyDataMapperNode : vtkMapperNode
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600663B RID: 26171 RVA: 0x000934DF File Offset: 0x000916DF
		static vtkPolyDataMapperNode()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataMapperNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataMapperNode"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600663C RID: 26172 RVA: 0x00093507 File Offset: 0x00091707
		public vtkPolyDataMapperNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600663D RID: 26173
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataMapperNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600663E RID: 26174 RVA: 0x00093518 File Offset: 0x00091718
		public new static vtkPolyDataMapperNode New()
		{
			vtkPolyDataMapperNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataMapperNode.vtkPolyDataMapperNode_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataMapperNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600663F RID: 26175 RVA: 0x0009356C File Offset: 0x0009176C
		public vtkPolyDataMapperNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyDataMapperNode.vtkPolyDataMapperNode_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006640 RID: 26176 RVA: 0x000935B0 File Offset: 0x000917B0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006641 RID: 26177
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataMapperNode_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006642 RID: 26178 RVA: 0x000935BC File Offset: 0x000917BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataMapperNode.vtkPolyDataMapperNode_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06006643 RID: 26179
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataMapperNode_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006644 RID: 26180 RVA: 0x000935DC File Offset: 0x000917DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataMapperNode.vtkPolyDataMapperNode_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06006645 RID: 26181
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataMapperNode_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006646 RID: 26182 RVA: 0x000935F8 File Offset: 0x000917F8
		public override int IsA(string type)
		{
			return vtkPolyDataMapperNode.vtkPolyDataMapperNode_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06006647 RID: 26183
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataMapperNode_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006648 RID: 26184 RVA: 0x00093618 File Offset: 0x00091818
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataMapperNode.vtkPolyDataMapperNode_IsTypeOf_04(type);
		}

		// Token: 0x06006649 RID: 26185
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataMapperNode_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600664A RID: 26186 RVA: 0x00093634 File Offset: 0x00091834
		public new vtkPolyDataMapperNode NewInstance()
		{
			vtkPolyDataMapperNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataMapperNode.vtkPolyDataMapperNode_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataMapperNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600664B RID: 26187
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataMapperNode_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600664C RID: 26188 RVA: 0x00093690 File Offset: 0x00091890
		public new static vtkPolyDataMapperNode SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataMapperNode vtkPolyDataMapperNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataMapperNode.vtkPolyDataMapperNode_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataMapperNode = (vtkPolyDataMapperNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataMapperNode.Register(null);
				}
			}
			return vtkPolyDataMapperNode;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400091F RID: 2335
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataMapperNode";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000920 RID: 2336
		public new static readonly string MRClassNameKey = "class vtkPolyDataMapperNode";
	}
}
