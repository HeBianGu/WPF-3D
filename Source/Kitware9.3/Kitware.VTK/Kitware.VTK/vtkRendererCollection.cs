using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRendererCollection
	/// </summary>
	/// <remarks>
	///    an ordered list of renderers
	///
	/// vtkRendererCollection represents and provides methods to manipulate a list
	/// of renderers (i.e., vtkRenderer and subclasses). The list is ordered and
	/// duplicate entries are not prevented.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderer vtkCollection
	/// </seealso>
	// Token: 0x020007FB RID: 2043
	public class vtkRendererCollection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014FCC RID: 85964 RVA: 0x001DB29B File Offset: 0x001D949B
		static vtkRendererCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRendererCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRendererCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014FCD RID: 85965 RVA: 0x001DB2C3 File Offset: 0x001D94C3
		public vtkRendererCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014FCE RID: 85966
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRendererCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FCF RID: 85967 RVA: 0x001DB2D4 File Offset: 0x001D94D4
		public new static vtkRendererCollection New()
		{
			vtkRendererCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRendererCollection.vtkRendererCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRendererCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FD0 RID: 85968 RVA: 0x001DB328 File Offset: 0x001D9528
		public vtkRendererCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRendererCollection.vtkRendererCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014FD1 RID: 85969 RVA: 0x001DB36C File Offset: 0x001D956C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014FD2 RID: 85970
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererCollection_AddItem_01(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Add a Renderer to the bottom of the list.
		/// </summary>
		// Token: 0x06014FD3 RID: 85971 RVA: 0x001DB378 File Offset: 0x001D9578
		public void AddItem(vtkRenderer a)
		{
			vtkRendererCollection.vtkRendererCollection_AddItem_01(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x06014FD4 RID: 85972
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRendererCollection_GetFirstRenderer_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the first Renderer in the list.
		/// Return NULL when at the end of the list.
		/// </summary>
		// Token: 0x06014FD5 RID: 85973 RVA: 0x001DB3A8 File Offset: 0x001D95A8
		public vtkRenderer GetFirstRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRendererCollection.vtkRendererCollection_GetFirstRenderer_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x06014FD6 RID: 85974
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRendererCollection_GetNextItem_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next Renderer in the list.
		/// Return NULL when at the end of the list.
		/// </summary>
		// Token: 0x06014FD7 RID: 85975 RVA: 0x001DB418 File Offset: 0x001D9618
		public vtkRenderer GetNextItem()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRendererCollection.vtkRendererCollection_GetNextItem_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x06014FD8 RID: 85976
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRendererCollection_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FD9 RID: 85977 RVA: 0x001DB488 File Offset: 0x001D9688
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRendererCollection.vtkRendererCollection_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06014FDA RID: 85978
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRendererCollection_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FDB RID: 85979 RVA: 0x001DB4A8 File Offset: 0x001D96A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRendererCollection.vtkRendererCollection_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06014FDC RID: 85980
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRendererCollection_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FDD RID: 85981 RVA: 0x001DB4C4 File Offset: 0x001D96C4
		public override int IsA(string type)
		{
			return vtkRendererCollection.vtkRendererCollection_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06014FDE RID: 85982
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRendererCollection_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FDF RID: 85983 RVA: 0x001DB4E4 File Offset: 0x001D96E4
		public new static int IsTypeOf(string type)
		{
			return vtkRendererCollection.vtkRendererCollection_IsTypeOf_07(type);
		}

		// Token: 0x06014FE0 RID: 85984
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRendererCollection_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FE1 RID: 85985 RVA: 0x001DB500 File Offset: 0x001D9700
		public new vtkRendererCollection NewInstance()
		{
			vtkRendererCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRendererCollection.vtkRendererCollection_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRendererCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014FE2 RID: 85986
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererCollection_Render_10(HandleRef pThis);

		/// <summary>
		/// Forward the Render() method to each renderer in the list.
		/// </summary>
		// Token: 0x06014FE3 RID: 85987 RVA: 0x001DB55A File Offset: 0x001D975A
		public void Render()
		{
			vtkRendererCollection.vtkRendererCollection_Render_10(base.GetCppThis());
		}

		// Token: 0x06014FE4 RID: 85988
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRendererCollection_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FE5 RID: 85989 RVA: 0x001DB56C File Offset: 0x001D976C
		public new static vtkRendererCollection SafeDownCast(vtkObjectBase o)
		{
			vtkRendererCollection vtkRendererCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRendererCollection.vtkRendererCollection_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRendererCollection = (vtkRendererCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRendererCollection.Register(null);
				}
			}
			return vtkRendererCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400183A RID: 6202
		public new const string MRFullTypeName = "Kitware.VTK.vtkRendererCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400183B RID: 6203
		public new static readonly string MRClassNameKey = "class vtkRendererCollection";
	}
}
