using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkOpenGLBatchedPolyDataMapper
	/// </summary>
	/// <remarks>
	///  An OpenGL mapper for batched rendering of vtkPolyData.
	///
	/// The parent class is determined at compile time.
	/// On OpenGL ES, the parent class is vtkOpenGLES30PolyDataMapper.
	/// Everywhere else, the parent class is vtkOpenGLPolyDataMapper.
	///
	/// </remarks>
	/// <seealso>
	///  vtkOpenGLPolyDataMapper vtkOpenGLES30PolyDataMapper vtkOpenGLCompositePolyDataMapperDelegator
	/// </seealso>
	// Token: 0x02000102 RID: 258
	public class vtkOpenGLBatchedPolyDataMapper : vtkOpenGLPolyDataMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003526 RID: 13606 RVA: 0x0004DB11 File Offset: 0x0004BD11
		static vtkOpenGLBatchedPolyDataMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLBatchedPolyDataMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLBatchedPolyDataMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003527 RID: 13607 RVA: 0x0004DB39 File Offset: 0x0004BD39
		public vtkOpenGLBatchedPolyDataMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003528 RID: 13608
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLBatchedPolyDataMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003529 RID: 13609 RVA: 0x0004DB48 File Offset: 0x0004BD48
		public new static vtkOpenGLBatchedPolyDataMapper New()
		{
			vtkOpenGLBatchedPolyDataMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLBatchedPolyDataMapper.vtkOpenGLBatchedPolyDataMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLBatchedPolyDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600352A RID: 13610 RVA: 0x0004DB9C File Offset: 0x0004BD9C
		public vtkOpenGLBatchedPolyDataMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLBatchedPolyDataMapper.vtkOpenGLBatchedPolyDataMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600352B RID: 13611 RVA: 0x0004DBE0 File Offset: 0x0004BDE0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600352C RID: 13612
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLBatchedPolyDataMapper_ClearBatchElements_01(HandleRef pThis);

		/// <summary>
		/// API to add and query a GLBatchElement instance per vtkPolyData.
		/// </summary>
		// Token: 0x0600352D RID: 13613 RVA: 0x0004DBEB File Offset: 0x0004BDEB
		public void ClearBatchElements()
		{
			vtkOpenGLBatchedPolyDataMapper.vtkOpenGLBatchedPolyDataMapper_ClearBatchElements_01(base.GetCppThis());
		}

		// Token: 0x0600352E RID: 13614
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLBatchedPolyDataMapper_ClearUnmarkedBatchElements_02(HandleRef pThis);

		/// <summary>
		/// Implemented by sub classes. Actual rendering is done here.
		/// </summary>
		// Token: 0x0600352F RID: 13615 RVA: 0x0004DBFA File Offset: 0x0004BDFA
		public void ClearUnmarkedBatchElements()
		{
			vtkOpenGLBatchedPolyDataMapper.vtkOpenGLBatchedPolyDataMapper_ClearUnmarkedBatchElements_02(base.GetCppThis());
		}

		// Token: 0x06003530 RID: 13616
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLBatchedPolyDataMapper_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003531 RID: 13617 RVA: 0x0004DC0C File Offset: 0x0004BE0C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLBatchedPolyDataMapper.vtkOpenGLBatchedPolyDataMapper_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06003532 RID: 13618
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLBatchedPolyDataMapper_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003533 RID: 13619 RVA: 0x0004DC2C File Offset: 0x0004BE2C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLBatchedPolyDataMapper.vtkOpenGLBatchedPolyDataMapper_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06003534 RID: 13620
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLBatchedPolyDataMapper_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003535 RID: 13621 RVA: 0x0004DC48 File Offset: 0x0004BE48
		public override int IsA(string type)
		{
			return vtkOpenGLBatchedPolyDataMapper.vtkOpenGLBatchedPolyDataMapper_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06003536 RID: 13622
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLBatchedPolyDataMapper_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003537 RID: 13623 RVA: 0x0004DC68 File Offset: 0x0004BE68
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLBatchedPolyDataMapper.vtkOpenGLBatchedPolyDataMapper_IsTypeOf_06(type);
		}

		// Token: 0x06003538 RID: 13624
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLBatchedPolyDataMapper_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003539 RID: 13625 RVA: 0x0004DC84 File Offset: 0x0004BE84
		public new vtkOpenGLBatchedPolyDataMapper NewInstance()
		{
			vtkOpenGLBatchedPolyDataMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLBatchedPolyDataMapper.vtkOpenGLBatchedPolyDataMapper_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLBatchedPolyDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600353A RID: 13626
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLBatchedPolyDataMapper_RenderPiece_09(HandleRef pThis, HandleRef renderer, HandleRef actor);

		/// <summary>
		/// Implemented by sub classes. Actual rendering is done here.
		/// </summary>
		// Token: 0x0600353B RID: 13627 RVA: 0x0004DCE0 File Offset: 0x0004BEE0
		public override void RenderPiece(vtkRenderer renderer, vtkActor actor)
		{
			vtkOpenGLBatchedPolyDataMapper.vtkOpenGLBatchedPolyDataMapper_RenderPiece_09(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		// Token: 0x0600353C RID: 13628
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLBatchedPolyDataMapper_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600353D RID: 13629 RVA: 0x0004DD24 File Offset: 0x0004BF24
		public new static vtkOpenGLBatchedPolyDataMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLBatchedPolyDataMapper vtkOpenGLBatchedPolyDataMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLBatchedPolyDataMapper.vtkOpenGLBatchedPolyDataMapper_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLBatchedPolyDataMapper = (vtkOpenGLBatchedPolyDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLBatchedPolyDataMapper.Register(null);
				}
			}
			return vtkOpenGLBatchedPolyDataMapper;
		}

		// Token: 0x0600353E RID: 13630
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLBatchedPolyDataMapper_SetParent_11(HandleRef pThis, HandleRef parent);

		/// <summary>
		/// Accessor to the ordered list of PolyData that we last drew.
		/// </summary>
		// Token: 0x0600353F RID: 13631 RVA: 0x0004DDA4 File Offset: 0x0004BFA4
		public void SetParent(vtkCompositePolyDataMapper parent)
		{
			vtkOpenGLBatchedPolyDataMapper.vtkOpenGLBatchedPolyDataMapper_SetParent_11(base.GetCppThis(), (parent == null) ? default(HandleRef) : parent.GetCppThis());
		}

		// Token: 0x06003540 RID: 13632
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLBatchedPolyDataMapper_UnmarkBatchElements_12(HandleRef pThis);

		/// <summary>
		/// Implemented by sub classes. Actual rendering is done here.
		/// </summary>
		// Token: 0x06003541 RID: 13633 RVA: 0x0004DDD3 File Offset: 0x0004BFD3
		public void UnmarkBatchElements()
		{
			vtkOpenGLBatchedPolyDataMapper.vtkOpenGLBatchedPolyDataMapper_UnmarkBatchElements_12(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400063C RID: 1596
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLBatchedPolyDataMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400063D RID: 1597
		public new static readonly string MRClassNameKey = "class vtkOpenGLBatchedPolyDataMapper";
	}
}
