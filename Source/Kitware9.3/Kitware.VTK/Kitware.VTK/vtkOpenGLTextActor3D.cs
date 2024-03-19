using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLTextActor3D
	/// </summary>
	/// <remarks>
	///    OpenGL2 override for vtkTextActor3D.
	/// </remarks>
	// Token: 0x020005D3 RID: 1491
	public class vtkOpenGLTextActor3D : vtkTextActor3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601047D RID: 66685 RVA: 0x0016AE0B File Offset: 0x0016900B
		static vtkOpenGLTextActor3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLTextActor3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLTextActor3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601047E RID: 66686 RVA: 0x0016AE33 File Offset: 0x00169033
		public vtkOpenGLTextActor3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601047F RID: 66687
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLTextActor3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010480 RID: 66688 RVA: 0x0016AE44 File Offset: 0x00169044
		public new static vtkOpenGLTextActor3D New()
		{
			vtkOpenGLTextActor3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLTextActor3D.vtkOpenGLTextActor3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLTextActor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010481 RID: 66689 RVA: 0x0016AE98 File Offset: 0x00169098
		public vtkOpenGLTextActor3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLTextActor3D.vtkOpenGLTextActor3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010482 RID: 66690 RVA: 0x0016AEDC File Offset: 0x001690DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010483 RID: 66691
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLTextActor3D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010484 RID: 66692 RVA: 0x0016AEE8 File Offset: 0x001690E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLTextActor3D.vtkOpenGLTextActor3D_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06010485 RID: 66693
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLTextActor3D_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010486 RID: 66694 RVA: 0x0016AF08 File Offset: 0x00169108
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLTextActor3D.vtkOpenGLTextActor3D_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06010487 RID: 66695
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLTextActor3D_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010488 RID: 66696 RVA: 0x0016AF24 File Offset: 0x00169124
		public override int IsA(string type)
		{
			return vtkOpenGLTextActor3D.vtkOpenGLTextActor3D_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06010489 RID: 66697
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLTextActor3D_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601048A RID: 66698 RVA: 0x0016AF44 File Offset: 0x00169144
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLTextActor3D.vtkOpenGLTextActor3D_IsTypeOf_04(type);
		}

		// Token: 0x0601048B RID: 66699
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLTextActor3D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601048C RID: 66700 RVA: 0x0016AF60 File Offset: 0x00169160
		public new vtkOpenGLTextActor3D NewInstance()
		{
			vtkOpenGLTextActor3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLTextActor3D.vtkOpenGLTextActor3D_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLTextActor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601048D RID: 66701
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLTextActor3D_RenderTranslucentPolygonalGeometry_07(HandleRef pThis, HandleRef viewport);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601048E RID: 66702 RVA: 0x0016AFBC File Offset: 0x001691BC
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkOpenGLTextActor3D.vtkOpenGLTextActor3D_RenderTranslucentPolygonalGeometry_07(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0601048F RID: 66703
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLTextActor3D_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010490 RID: 66704 RVA: 0x0016AFF0 File Offset: 0x001691F0
		public new static vtkOpenGLTextActor3D SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLTextActor3D vtkOpenGLTextActor3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLTextActor3D.vtkOpenGLTextActor3D_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLTextActor3D = (vtkOpenGLTextActor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLTextActor3D.Register(null);
				}
			}
			return vtkOpenGLTextActor3D;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012ED RID: 4845
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLTextActor3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012EE RID: 4846
		public new static readonly string MRClassNameKey = "class vtkOpenGLTextActor3D";
	}
}
