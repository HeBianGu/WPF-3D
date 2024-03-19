using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVtkJSViewNodeFactory
	/// </summary>
	/// <remarks>
	///    Constructs view nodes for traversing a scene for vtk-js
	///
	/// vtkVtkJSViewNodeFactory constructs view nodes that are subsequently executed
	/// as a scene graph is traversed. The generated view nodes inherit from
	/// vtkViewNode and augment the synchronize and render traversal steps to
	/// construct Json representations of the scene elements and to update the
	/// pipelines associated with the datasets to render, respectively.
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkVtkJSSceneGraphSerializer
	/// </seealso>
	// Token: 0x020001F9 RID: 505
	public class vtkVtkJSViewNodeFactory : vtkViewNodeFactory
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600612C RID: 24876 RVA: 0x0008C073 File Offset: 0x0008A273
		static vtkVtkJSViewNodeFactory()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVtkJSViewNodeFactory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVtkJSViewNodeFactory"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600612D RID: 24877 RVA: 0x0008C09B File Offset: 0x0008A29B
		public vtkVtkJSViewNodeFactory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600612E RID: 24878
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVtkJSViewNodeFactory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600612F RID: 24879 RVA: 0x0008C0AC File Offset: 0x0008A2AC
		public new static vtkVtkJSViewNodeFactory New()
		{
			vtkVtkJSViewNodeFactory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVtkJSViewNodeFactory.vtkVtkJSViewNodeFactory_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVtkJSViewNodeFactory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006130 RID: 24880 RVA: 0x0008C100 File Offset: 0x0008A300
		public vtkVtkJSViewNodeFactory() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVtkJSViewNodeFactory.vtkVtkJSViewNodeFactory_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006131 RID: 24881 RVA: 0x0008C144 File Offset: 0x0008A344
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006132 RID: 24882
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVtkJSViewNodeFactory_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006133 RID: 24883 RVA: 0x0008C150 File Offset: 0x0008A350
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVtkJSViewNodeFactory.vtkVtkJSViewNodeFactory_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06006134 RID: 24884
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVtkJSViewNodeFactory_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006135 RID: 24885 RVA: 0x0008C170 File Offset: 0x0008A370
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVtkJSViewNodeFactory.vtkVtkJSViewNodeFactory_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06006136 RID: 24886
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVtkJSViewNodeFactory_GetSerializer_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the Serializer object
		/// </summary>
		// Token: 0x06006137 RID: 24887 RVA: 0x0008C18C File Offset: 0x0008A38C
		public virtual vtkVtkJSSceneGraphSerializer GetSerializer()
		{
			vtkVtkJSSceneGraphSerializer vtkVtkJSSceneGraphSerializer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVtkJSViewNodeFactory.vtkVtkJSViewNodeFactory_GetSerializer_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVtkJSSceneGraphSerializer = (vtkVtkJSSceneGraphSerializer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVtkJSSceneGraphSerializer.Register(null);
				}
			}
			return vtkVtkJSSceneGraphSerializer;
		}

		// Token: 0x06006138 RID: 24888
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVtkJSViewNodeFactory_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006139 RID: 24889 RVA: 0x0008C1FC File Offset: 0x0008A3FC
		public override int IsA(string type)
		{
			return vtkVtkJSViewNodeFactory.vtkVtkJSViewNodeFactory_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600613A RID: 24890
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVtkJSViewNodeFactory_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600613B RID: 24891 RVA: 0x0008C21C File Offset: 0x0008A41C
		public new static int IsTypeOf(string type)
		{
			return vtkVtkJSViewNodeFactory.vtkVtkJSViewNodeFactory_IsTypeOf_05(type);
		}

		// Token: 0x0600613C RID: 24892
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVtkJSViewNodeFactory_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600613D RID: 24893 RVA: 0x0008C238 File Offset: 0x0008A438
		public new vtkVtkJSViewNodeFactory NewInstance()
		{
			vtkVtkJSViewNodeFactory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVtkJSViewNodeFactory.vtkVtkJSViewNodeFactory_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVtkJSViewNodeFactory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600613E RID: 24894
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVtkJSViewNodeFactory_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600613F RID: 24895 RVA: 0x0008C294 File Offset: 0x0008A494
		public new static vtkVtkJSViewNodeFactory SafeDownCast(vtkObjectBase o)
		{
			vtkVtkJSViewNodeFactory vtkVtkJSViewNodeFactory = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVtkJSViewNodeFactory.vtkVtkJSViewNodeFactory_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVtkJSViewNodeFactory = (vtkVtkJSViewNodeFactory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVtkJSViewNodeFactory.Register(null);
				}
			}
			return vtkVtkJSViewNodeFactory;
		}

		// Token: 0x06006140 RID: 24896
		[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVtkJSViewNodeFactory_SetSerializer_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the Serializer object
		/// </summary>
		// Token: 0x06006141 RID: 24897 RVA: 0x0008C314 File Offset: 0x0008A514
		public void SetSerializer(vtkVtkJSSceneGraphSerializer arg0)
		{
			vtkVtkJSViewNodeFactory.vtkVtkJSViewNodeFactory_SetSerializer_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008BC RID: 2236
		public new const string MRFullTypeName = "Kitware.VTK.vtkVtkJSViewNodeFactory";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008BD RID: 2237
		public new static readonly string MRClassNameKey = "class vtkVtkJSViewNodeFactory";
	}
}
