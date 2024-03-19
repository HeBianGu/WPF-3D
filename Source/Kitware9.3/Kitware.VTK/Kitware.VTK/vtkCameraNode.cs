using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCameraNode
	/// </summary>
	/// <remarks>
	///    vtkViewNode specialized for vtkCameras
	///
	/// State storage and graph traversal for vtkCamera
	/// </remarks>
	// Token: 0x02000219 RID: 537
	public class vtkCameraNode : vtkViewNode
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006605 RID: 26117 RVA: 0x00092E4F File Offset: 0x0009104F
		static vtkCameraNode()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCameraNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraNode"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006606 RID: 26118 RVA: 0x00092E77 File Offset: 0x00091077
		public vtkCameraNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006607 RID: 26119
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006608 RID: 26120 RVA: 0x00092E88 File Offset: 0x00091088
		public new static vtkCameraNode New()
		{
			vtkCameraNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraNode.vtkCameraNode_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006609 RID: 26121 RVA: 0x00092EDC File Offset: 0x000910DC
		public vtkCameraNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCameraNode.vtkCameraNode_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600660A RID: 26122 RVA: 0x00092F20 File Offset: 0x00091120
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600660B RID: 26123
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraNode_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600660C RID: 26124 RVA: 0x00092F2C File Offset: 0x0009112C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCameraNode.vtkCameraNode_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600660D RID: 26125
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraNode_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600660E RID: 26126 RVA: 0x00092F4C File Offset: 0x0009114C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCameraNode.vtkCameraNode_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600660F RID: 26127
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraNode_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006610 RID: 26128 RVA: 0x00092F68 File Offset: 0x00091168
		public override int IsA(string type)
		{
			return vtkCameraNode.vtkCameraNode_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06006611 RID: 26129
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraNode_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006612 RID: 26130 RVA: 0x00092F88 File Offset: 0x00091188
		public new static int IsTypeOf(string type)
		{
			return vtkCameraNode.vtkCameraNode_IsTypeOf_04(type);
		}

		// Token: 0x06006613 RID: 26131
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraNode_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006614 RID: 26132 RVA: 0x00092FA4 File Offset: 0x000911A4
		public new vtkCameraNode NewInstance()
		{
			vtkCameraNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraNode.vtkCameraNode_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006615 RID: 26133
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraNode_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006616 RID: 26134 RVA: 0x00093000 File Offset: 0x00091200
		public new static vtkCameraNode SafeDownCast(vtkObjectBase o)
		{
			vtkCameraNode vtkCameraNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraNode.vtkCameraNode_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCameraNode = (vtkCameraNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCameraNode.Register(null);
				}
			}
			return vtkCameraNode;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000919 RID: 2329
		public new const string MRFullTypeName = "Kitware.VTK.vtkCameraNode";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400091A RID: 2330
		public new static readonly string MRClassNameKey = "class vtkCameraNode";
	}
}
