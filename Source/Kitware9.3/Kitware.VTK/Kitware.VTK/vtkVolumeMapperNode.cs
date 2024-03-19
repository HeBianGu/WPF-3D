using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVolumeMapperNode
	/// </summary>
	/// <remarks>
	///    vtkViewNode specialized for vtkVolumeMappers
	///
	/// State storage and graph traversal for vtkVolumeMapper/PolyDataMapper and Property
	/// Made a choice to merge PolyDataMapper, PolyDataMapper and property together. If there
	/// is a compelling reason to separate them we can.
	/// </remarks>
	// Token: 0x0200021E RID: 542
	public class vtkVolumeMapperNode : vtkMapperNode
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600667F RID: 26239 RVA: 0x00093B01 File Offset: 0x00091D01
		static vtkVolumeMapperNode()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeMapperNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeMapperNode"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006680 RID: 26240 RVA: 0x00093B29 File Offset: 0x00091D29
		public vtkVolumeMapperNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006681 RID: 26241
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeMapperNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006682 RID: 26242 RVA: 0x00093B38 File Offset: 0x00091D38
		public new static vtkVolumeMapperNode New()
		{
			vtkVolumeMapperNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeMapperNode.vtkVolumeMapperNode_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeMapperNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006683 RID: 26243 RVA: 0x00093B8C File Offset: 0x00091D8C
		public vtkVolumeMapperNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVolumeMapperNode.vtkVolumeMapperNode_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006684 RID: 26244 RVA: 0x00093BD0 File Offset: 0x00091DD0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006685 RID: 26245
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeMapperNode_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006686 RID: 26246 RVA: 0x00093BDC File Offset: 0x00091DDC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVolumeMapperNode.vtkVolumeMapperNode_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06006687 RID: 26247
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeMapperNode_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006688 RID: 26248 RVA: 0x00093BFC File Offset: 0x00091DFC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVolumeMapperNode.vtkVolumeMapperNode_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06006689 RID: 26249
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeMapperNode_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600668A RID: 26250 RVA: 0x00093C18 File Offset: 0x00091E18
		public override int IsA(string type)
		{
			return vtkVolumeMapperNode.vtkVolumeMapperNode_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600668B RID: 26251
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeMapperNode_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600668C RID: 26252 RVA: 0x00093C38 File Offset: 0x00091E38
		public new static int IsTypeOf(string type)
		{
			return vtkVolumeMapperNode.vtkVolumeMapperNode_IsTypeOf_04(type);
		}

		// Token: 0x0600668D RID: 26253
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeMapperNode_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600668E RID: 26254 RVA: 0x00093C54 File Offset: 0x00091E54
		public new vtkVolumeMapperNode NewInstance()
		{
			vtkVolumeMapperNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeMapperNode.vtkVolumeMapperNode_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeMapperNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600668F RID: 26255
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeMapperNode_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006690 RID: 26256 RVA: 0x00093CB0 File Offset: 0x00091EB0
		public new static vtkVolumeMapperNode SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeMapperNode vtkVolumeMapperNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeMapperNode.vtkVolumeMapperNode_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeMapperNode = (vtkVolumeMapperNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeMapperNode.Register(null);
				}
			}
			return vtkVolumeMapperNode;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000923 RID: 2339
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeMapperNode";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000924 RID: 2340
		public new static readonly string MRClassNameKey = "class vtkVolumeMapperNode";
	}
}
