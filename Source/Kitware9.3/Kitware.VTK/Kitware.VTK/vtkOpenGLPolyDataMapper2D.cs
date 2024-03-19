using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLPolyDataMapper2D
	/// </summary>
	/// <remarks>
	///    2D PolyData support for OpenGL
	///
	/// vtkOpenGLPolyDataMapper2D provides 2D PolyData annotation support for
	/// vtk under OpenGL.  Normally the user should use vtkPolyDataMapper2D
	/// which in turn will use this class.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolyDataMapper2D
	/// </seealso>
	// Token: 0x020005C1 RID: 1473
	public class vtkOpenGLPolyDataMapper2D : vtkPolyDataMapper2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010207 RID: 66055 RVA: 0x001674CF File Offset: 0x001656CF
		static vtkOpenGLPolyDataMapper2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLPolyDataMapper2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLPolyDataMapper2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010208 RID: 66056 RVA: 0x001674F7 File Offset: 0x001656F7
		public vtkOpenGLPolyDataMapper2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010209 RID: 66057
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLPolyDataMapper2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601020A RID: 66058 RVA: 0x00167508 File Offset: 0x00165708
		public new static vtkOpenGLPolyDataMapper2D New()
		{
			vtkOpenGLPolyDataMapper2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLPolyDataMapper2D.vtkOpenGLPolyDataMapper2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLPolyDataMapper2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601020B RID: 66059 RVA: 0x0016755C File Offset: 0x0016575C
		public vtkOpenGLPolyDataMapper2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLPolyDataMapper2D.vtkOpenGLPolyDataMapper2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601020C RID: 66060 RVA: 0x001675A0 File Offset: 0x001657A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601020D RID: 66061
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLPolyDataMapper2D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601020E RID: 66062 RVA: 0x001675AC File Offset: 0x001657AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLPolyDataMapper2D.vtkOpenGLPolyDataMapper2D_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601020F RID: 66063
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLPolyDataMapper2D_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010210 RID: 66064 RVA: 0x001675CC File Offset: 0x001657CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLPolyDataMapper2D.vtkOpenGLPolyDataMapper2D_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06010211 RID: 66065
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLPolyDataMapper2D_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010212 RID: 66066 RVA: 0x001675E8 File Offset: 0x001657E8
		public override int IsA(string type)
		{
			return vtkOpenGLPolyDataMapper2D.vtkOpenGLPolyDataMapper2D_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06010213 RID: 66067
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLPolyDataMapper2D_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010214 RID: 66068 RVA: 0x00167608 File Offset: 0x00165808
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLPolyDataMapper2D.vtkOpenGLPolyDataMapper2D_IsTypeOf_04(type);
		}

		// Token: 0x06010215 RID: 66069
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLPolyDataMapper2D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010216 RID: 66070 RVA: 0x00167624 File Offset: 0x00165824
		public new vtkOpenGLPolyDataMapper2D NewInstance()
		{
			vtkOpenGLPolyDataMapper2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLPolyDataMapper2D.vtkOpenGLPolyDataMapper2D_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLPolyDataMapper2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010217 RID: 66071
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper2D_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06010218 RID: 66072 RVA: 0x00167680 File Offset: 0x00165880
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkOpenGLPolyDataMapper2D.vtkOpenGLPolyDataMapper2D_ReleaseGraphicsResources_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010219 RID: 66073
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPolyDataMapper2D_RenderOverlay_08(HandleRef pThis, HandleRef viewport, HandleRef actor);

		/// <summary>
		/// Actually draw the poly data.
		/// </summary>
		// Token: 0x0601021A RID: 66074 RVA: 0x001676B0 File Offset: 0x001658B0
		public override void RenderOverlay(vtkViewport viewport, vtkActor2D actor)
		{
			vtkOpenGLPolyDataMapper2D.vtkOpenGLPolyDataMapper2D_RenderOverlay_08(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		// Token: 0x0601021B RID: 66075
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLPolyDataMapper2D_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601021C RID: 66076 RVA: 0x001676F4 File Offset: 0x001658F4
		public new static vtkOpenGLPolyDataMapper2D SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLPolyDataMapper2D vtkOpenGLPolyDataMapper2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLPolyDataMapper2D.vtkOpenGLPolyDataMapper2D_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLPolyDataMapper2D = (vtkOpenGLPolyDataMapper2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLPolyDataMapper2D.Register(null);
				}
			}
			return vtkOpenGLPolyDataMapper2D;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012C4 RID: 4804
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLPolyDataMapper2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012C5 RID: 4805
		public new static readonly string MRClassNameKey = "class vtkOpenGLPolyDataMapper2D";
	}
}
