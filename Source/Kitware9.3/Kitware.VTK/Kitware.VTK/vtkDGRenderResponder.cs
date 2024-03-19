using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDGRenderResponder
	/// </summary>
	/// <remarks>
	///    Rendering simple DG cells (i.e., those with a fixed reference shape).
	///
	/// This currently handles hexahedra, tetrahedra, quadrilaterals, and triangles.
	/// </remarks>
	// Token: 0x02000127 RID: 295
	public class vtkDGRenderResponder : vtkCellGridResponderBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003BF6 RID: 15350 RVA: 0x000574AB File Offset: 0x000556AB
		static vtkDGRenderResponder()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDGRenderResponder.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDGRenderResponder"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003BF7 RID: 15351 RVA: 0x000574D3 File Offset: 0x000556D3
		public vtkDGRenderResponder(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003BF8 RID: 15352
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGRenderResponder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BF9 RID: 15353 RVA: 0x000574E4 File Offset: 0x000556E4
		public new static vtkDGRenderResponder New()
		{
			vtkDGRenderResponder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGRenderResponder.vtkDGRenderResponder_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGRenderResponder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BFA RID: 15354 RVA: 0x00057538 File Offset: 0x00055738
		public vtkDGRenderResponder() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDGRenderResponder.vtkDGRenderResponder_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003BFB RID: 15355 RVA: 0x0005757C File Offset: 0x0005577C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003BFC RID: 15356
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDGRenderResponder_AddMod_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string className);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BFD RID: 15357 RVA: 0x00057587 File Offset: 0x00055787
		public void AddMod(string className)
		{
			vtkDGRenderResponder.vtkDGRenderResponder_AddMod_01(base.GetCppThis(), className);
		}

		// Token: 0x06003BFE RID: 15358
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGRenderResponder_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BFF RID: 15359 RVA: 0x00057598 File Offset: 0x00055798
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDGRenderResponder.vtkDGRenderResponder_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06003C00 RID: 15360
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGRenderResponder_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C01 RID: 15361 RVA: 0x000575B8 File Offset: 0x000557B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDGRenderResponder.vtkDGRenderResponder_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06003C02 RID: 15362
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGRenderResponder_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C03 RID: 15363 RVA: 0x000575D4 File Offset: 0x000557D4
		public override int IsA(string type)
		{
			return vtkDGRenderResponder.vtkDGRenderResponder_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06003C04 RID: 15364
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGRenderResponder_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C05 RID: 15365 RVA: 0x000575F4 File Offset: 0x000557F4
		public new static int IsTypeOf(string type)
		{
			return vtkDGRenderResponder.vtkDGRenderResponder_IsTypeOf_05(type);
		}

		// Token: 0x06003C06 RID: 15366
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGRenderResponder_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C07 RID: 15367 RVA: 0x00057610 File Offset: 0x00055810
		public new vtkDGRenderResponder NewInstance()
		{
			vtkDGRenderResponder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGRenderResponder.vtkDGRenderResponder_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGRenderResponder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003C08 RID: 15368
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDGRenderResponder_Query_08(HandleRef pThis, HandleRef request, HandleRef metadata, HandleRef caches);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C09 RID: 15369 RVA: 0x0005766C File Offset: 0x0005586C
		public virtual bool Query(vtkCellGridRenderRequest request, vtkCellMetadata metadata, vtkCellGridResponders caches)
		{
			return vtkDGRenderResponder.vtkDGRenderResponder_Query_08(base.GetCppThis(), (request == null) ? default(HandleRef) : request.GetCppThis(), (metadata == null) ? default(HandleRef) : metadata.GetCppThis(), (caches == null) ? default(HandleRef) : caches.GetCppThis()) != 0;
		}

		// Token: 0x06003C0A RID: 15370
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDGRenderResponder_RemoveAllMods_09(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C0B RID: 15371 RVA: 0x000576D1 File Offset: 0x000558D1
		public void RemoveAllMods()
		{
			vtkDGRenderResponder.vtkDGRenderResponder_RemoveAllMods_09(base.GetCppThis());
		}

		// Token: 0x06003C0C RID: 15372
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDGRenderResponder_RemoveMod_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string className);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C0D RID: 15373 RVA: 0x000576E0 File Offset: 0x000558E0
		public void RemoveMod(string className)
		{
			vtkDGRenderResponder.vtkDGRenderResponder_RemoveMod_10(base.GetCppThis(), className);
		}

		// Token: 0x06003C0E RID: 15374
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDGRenderResponder_ResetModsToDefault_11(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C0F RID: 15375 RVA: 0x000576F0 File Offset: 0x000558F0
		public void ResetModsToDefault()
		{
			vtkDGRenderResponder.vtkDGRenderResponder_ResetModsToDefault_11(base.GetCppThis());
		}

		// Token: 0x06003C10 RID: 15376
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGRenderResponder_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C11 RID: 15377 RVA: 0x00057700 File Offset: 0x00055900
		public new static vtkDGRenderResponder SafeDownCast(vtkObjectBase o)
		{
			vtkDGRenderResponder vtkDGRenderResponder = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGRenderResponder.vtkDGRenderResponder_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDGRenderResponder = (vtkDGRenderResponder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDGRenderResponder.Register(null);
				}
			}
			return vtkDGRenderResponder;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000687 RID: 1671
		public new const string MRFullTypeName = "Kitware.VTK.vtkDGRenderResponder";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000688 RID: 1672
		public new static readonly string MRClassNameKey = "class vtkDGRenderResponder";
	}
}
