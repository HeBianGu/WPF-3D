using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkViewNodeFactory
	/// </summary>
	/// <remarks>
	///    factory that chooses vtkViewNodes to create
	///
	/// Class tells VTK which specific vtkViewNode subclass to make when it is
	/// asked to make a vtkViewNode for a particular renderable. modules for
	/// different rendering backends are expected to use this to customize the
	/// set of instances for their own purposes
	/// </remarks>
	// Token: 0x020001F8 RID: 504
	public class vtkViewNodeFactory : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006118 RID: 24856 RVA: 0x0008BDBB File Offset: 0x00089FBB
		static vtkViewNodeFactory()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkViewNodeFactory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkViewNodeFactory"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006119 RID: 24857 RVA: 0x0008BDE3 File Offset: 0x00089FE3
		public vtkViewNodeFactory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600611A RID: 24858
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewNodeFactory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600611B RID: 24859 RVA: 0x0008BDF4 File Offset: 0x00089FF4
		public new static vtkViewNodeFactory New()
		{
			vtkViewNodeFactory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewNodeFactory.vtkViewNodeFactory_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkViewNodeFactory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600611C RID: 24860 RVA: 0x0008BE48 File Offset: 0x0008A048
		public vtkViewNodeFactory() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkViewNodeFactory.vtkViewNodeFactory_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600611D RID: 24861 RVA: 0x0008BE8C File Offset: 0x0008A08C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600611E RID: 24862
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewNodeFactory_CreateNode_01(HandleRef pThis, HandleRef arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates and returns a vtkViewNode for the provided renderable.
		/// </summary>
		// Token: 0x0600611F RID: 24863 RVA: 0x0008BE98 File Offset: 0x0008A098
		public vtkViewNode CreateNode(vtkObject arg0)
		{
			vtkViewNode vtkViewNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewNodeFactory.vtkViewNodeFactory_CreateNode_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewNode = (vtkViewNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewNode.Register(null);
				}
			}
			return vtkViewNode;
		}

		// Token: 0x06006120 RID: 24864
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkViewNodeFactory_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006121 RID: 24865 RVA: 0x0008BF20 File Offset: 0x0008A120
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkViewNodeFactory.vtkViewNodeFactory_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06006122 RID: 24866
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkViewNodeFactory_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006123 RID: 24867 RVA: 0x0008BF40 File Offset: 0x0008A140
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkViewNodeFactory.vtkViewNodeFactory_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06006124 RID: 24868
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkViewNodeFactory_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006125 RID: 24869 RVA: 0x0008BF5C File Offset: 0x0008A15C
		public override int IsA(string type)
		{
			return vtkViewNodeFactory.vtkViewNodeFactory_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06006126 RID: 24870
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkViewNodeFactory_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006127 RID: 24871 RVA: 0x0008BF7C File Offset: 0x0008A17C
		public new static int IsTypeOf(string type)
		{
			return vtkViewNodeFactory.vtkViewNodeFactory_IsTypeOf_05(type);
		}

		// Token: 0x06006128 RID: 24872
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewNodeFactory_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006129 RID: 24873 RVA: 0x0008BF98 File Offset: 0x0008A198
		public new vtkViewNodeFactory NewInstance()
		{
			vtkViewNodeFactory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewNodeFactory.vtkViewNodeFactory_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkViewNodeFactory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600612A RID: 24874
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewNodeFactory_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600612B RID: 24875 RVA: 0x0008BFF4 File Offset: 0x0008A1F4
		public new static vtkViewNodeFactory SafeDownCast(vtkObjectBase o)
		{
			vtkViewNodeFactory vtkViewNodeFactory = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewNodeFactory.vtkViewNodeFactory_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewNodeFactory = (vtkViewNodeFactory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewNodeFactory.Register(null);
				}
			}
			return vtkViewNodeFactory;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008BA RID: 2234
		public new const string MRFullTypeName = "Kitware.VTK.vtkViewNodeFactory";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008BB RID: 2235
		public new static readonly string MRClassNameKey = "class vtkViewNodeFactory";
	}
}
