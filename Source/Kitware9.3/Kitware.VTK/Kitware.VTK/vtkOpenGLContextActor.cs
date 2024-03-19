using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLContextActor
	/// </summary>
	/// <remarks>
	///    provides a vtkProp derived object.
	///
	/// This object provides the entry point for the vtkContextScene to be rendered
	/// in a vtkRenderer. Uses the RenderOverlay pass to render the 2D
	/// vtkContextScene.
	/// </remarks>
	// Token: 0x0200011F RID: 287
	public class vtkOpenGLContextActor : vtkContextActor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003AAB RID: 15019 RVA: 0x000554FF File Offset: 0x000536FF
		static vtkOpenGLContextActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLContextActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLContextActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003AAC RID: 15020 RVA: 0x00055527 File Offset: 0x00053727
		public vtkOpenGLContextActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003AAD RID: 15021
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLContextActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003AAE RID: 15022 RVA: 0x00055538 File Offset: 0x00053738
		public new static vtkOpenGLContextActor New()
		{
			vtkOpenGLContextActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLContextActor.vtkOpenGLContextActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLContextActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003AAF RID: 15023 RVA: 0x0005558C File Offset: 0x0005378C
		public vtkOpenGLContextActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLContextActor.vtkOpenGLContextActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003AB0 RID: 15024 RVA: 0x000555D0 File Offset: 0x000537D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003AB1 RID: 15025
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLContextActor_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003AB2 RID: 15026 RVA: 0x000555DC File Offset: 0x000537DC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLContextActor.vtkOpenGLContextActor_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06003AB3 RID: 15027
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLContextActor_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003AB4 RID: 15028 RVA: 0x000555FC File Offset: 0x000537FC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLContextActor.vtkOpenGLContextActor_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06003AB5 RID: 15029
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLContextActor_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003AB6 RID: 15030 RVA: 0x00055618 File Offset: 0x00053818
		public override int IsA(string type)
		{
			return vtkOpenGLContextActor.vtkOpenGLContextActor_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06003AB7 RID: 15031
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLContextActor_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003AB8 RID: 15032 RVA: 0x00055638 File Offset: 0x00053838
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLContextActor.vtkOpenGLContextActor_IsTypeOf_04(type);
		}

		// Token: 0x06003AB9 RID: 15033
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLContextActor_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003ABA RID: 15034 RVA: 0x00055654 File Offset: 0x00053854
		public new vtkOpenGLContextActor NewInstance()
		{
			vtkOpenGLContextActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLContextActor.vtkOpenGLContextActor_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLContextActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003ABB RID: 15035
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextActor_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef window);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06003ABC RID: 15036 RVA: 0x000556B0 File Offset: 0x000538B0
		public override void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkOpenGLContextActor.vtkOpenGLContextActor_ReleaseGraphicsResources_07(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		// Token: 0x06003ABD RID: 15037
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLContextActor_RenderOverlay_08(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// We only render in the overlay for the context scene.
		/// </summary>
		// Token: 0x06003ABE RID: 15038 RVA: 0x000556E0 File Offset: 0x000538E0
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkOpenGLContextActor.vtkOpenGLContextActor_RenderOverlay_08(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06003ABF RID: 15039
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLContextActor_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003AC0 RID: 15040 RVA: 0x00055714 File Offset: 0x00053914
		public new static vtkOpenGLContextActor SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLContextActor vtkOpenGLContextActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLContextActor.vtkOpenGLContextActor_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLContextActor = (vtkOpenGLContextActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLContextActor.Register(null);
				}
			}
			return vtkOpenGLContextActor;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000677 RID: 1655
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLContextActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000678 RID: 1656
		public new static readonly string MRClassNameKey = "class vtkOpenGLContextActor";
	}
}
