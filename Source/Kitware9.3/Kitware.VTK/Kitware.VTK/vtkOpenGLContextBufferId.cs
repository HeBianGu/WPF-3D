using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLContextBufferId
	/// </summary>
	/// <remarks>
	///    2D array of ids stored in VRAM.
	///
	///
	/// An 2D array where each element is the id of an entity drawn at the given
	/// pixel.
	/// </remarks>
	// Token: 0x02000121 RID: 289
	public class vtkOpenGLContextBufferId : vtkAbstractContextBufferId
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003AEB RID: 15083 RVA: 0x00055B68 File Offset: 0x00053D68
		static vtkOpenGLContextBufferId()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLContextBufferId.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLContextBufferId"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003AEC RID: 15084 RVA: 0x00055B90 File Offset: 0x00053D90
		public vtkOpenGLContextBufferId(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003AED RID: 15085
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLContextBufferId_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a 2D Painter object.
		/// </summary>
		// Token: 0x06003AEE RID: 15086 RVA: 0x00055BA0 File Offset: 0x00053DA0
		public new static vtkOpenGLContextBufferId New()
		{
			vtkOpenGLContextBufferId result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLContextBufferId.vtkOpenGLContextBufferId_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLContextBufferId)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a 2D Painter object.
		/// </summary>
		// Token: 0x06003AEF RID: 15087 RVA: 0x00055BF4 File Offset: 0x00053DF4
		public vtkOpenGLContextBufferId() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLContextBufferId.vtkOpenGLContextBufferId_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003AF0 RID: 15088 RVA: 0x00055C38 File Offset: 0x00053E38
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003AF1 RID: 15089
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextBufferId_Allocate_01(HandleRef pThis);

		/// <summary>
		/// Allocate the memory for at least Width*Height elements.
		/// \pre positive_width: GetWidth()&gt;0
		/// \pre positive_height: GetHeight()&gt;0
		/// \pre context_is_set: this-&gt;GetContext()!=0
		/// </summary>
		// Token: 0x06003AF2 RID: 15090 RVA: 0x00055C43 File Offset: 0x00053E43
		public override void Allocate()
		{
			vtkOpenGLContextBufferId.vtkOpenGLContextBufferId_Allocate_01(base.GetCppThis());
		}

		// Token: 0x06003AF3 RID: 15091
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLContextBufferId_GetContext_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the OpenGL context owning the texture object resource.
		/// </summary>
		// Token: 0x06003AF4 RID: 15092 RVA: 0x00055C54 File Offset: 0x00053E54
		public override vtkRenderWindow GetContext()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLContextBufferId.vtkOpenGLContextBufferId_GetContext_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		// Token: 0x06003AF5 RID: 15093
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLContextBufferId_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003AF6 RID: 15094 RVA: 0x00055CC4 File Offset: 0x00053EC4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLContextBufferId.vtkOpenGLContextBufferId_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06003AF7 RID: 15095
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLContextBufferId_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003AF8 RID: 15096 RVA: 0x00055CE4 File Offset: 0x00053EE4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLContextBufferId.vtkOpenGLContextBufferId_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06003AF9 RID: 15097
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLContextBufferId_GetPickedItem_05(HandleRef pThis, int x, int y);

		/// <summary>
		/// Return item under abscissa x and ordinate y.
		/// Abscissa go from left to right.
		/// Ordinate go from bottom to top.
		/// The return value is -1 if there is no item.
		/// \pre is_allocated: IsAllocated()
		/// \post valid_result: result&gt;=-1
		/// </summary>
		// Token: 0x06003AFA RID: 15098 RVA: 0x00055D00 File Offset: 0x00053F00
		public override long GetPickedItem(int x, int y)
		{
			return vtkOpenGLContextBufferId.vtkOpenGLContextBufferId_GetPickedItem_05(base.GetCppThis(), x, y);
		}

		// Token: 0x06003AFB RID: 15099
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLContextBufferId_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003AFC RID: 15100 RVA: 0x00055D24 File Offset: 0x00053F24
		public override int IsA(string type)
		{
			return vtkOpenGLContextBufferId.vtkOpenGLContextBufferId_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06003AFD RID: 15101
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLContextBufferId_IsAllocated_07(HandleRef pThis);

		/// <summary>
		/// Tell if the buffer has been allocated.
		/// </summary>
		// Token: 0x06003AFE RID: 15102 RVA: 0x00055D44 File Offset: 0x00053F44
		public override bool IsAllocated()
		{
			return vtkOpenGLContextBufferId.vtkOpenGLContextBufferId_IsAllocated_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06003AFF RID: 15103
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLContextBufferId_IsSupported_08(HandleRef pThis);

		/// <summary>
		/// Returns if the context supports the required extensions.
		/// \pre context_is_set: this-&gt;GetContext()!=0
		/// </summary>
		// Token: 0x06003B00 RID: 15104 RVA: 0x00055D6C File Offset: 0x00053F6C
		public override bool IsSupported()
		{
			return vtkOpenGLContextBufferId.vtkOpenGLContextBufferId_IsSupported_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06003B01 RID: 15105
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLContextBufferId_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003B02 RID: 15106 RVA: 0x00055D94 File Offset: 0x00053F94
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLContextBufferId.vtkOpenGLContextBufferId_IsTypeOf_09(type);
		}

		// Token: 0x06003B03 RID: 15107
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLContextBufferId_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003B04 RID: 15108 RVA: 0x00055DB0 File Offset: 0x00053FB0
		public new vtkOpenGLContextBufferId NewInstance()
		{
			vtkOpenGLContextBufferId result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLContextBufferId.vtkOpenGLContextBufferId_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLContextBufferId)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003B05 RID: 15109
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextBufferId_ReleaseGraphicsResources_12(HandleRef pThis);

		/// <summary>
		/// Release any graphics resources that are being consumed by this object.
		/// </summary>
		// Token: 0x06003B06 RID: 15110 RVA: 0x00055E0A File Offset: 0x0005400A
		public override void ReleaseGraphicsResources()
		{
			vtkOpenGLContextBufferId.vtkOpenGLContextBufferId_ReleaseGraphicsResources_12(base.GetCppThis());
		}

		// Token: 0x06003B07 RID: 15111
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLContextBufferId_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003B08 RID: 15112 RVA: 0x00055E1C File Offset: 0x0005401C
		public new static vtkOpenGLContextBufferId SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLContextBufferId vtkOpenGLContextBufferId = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLContextBufferId.vtkOpenGLContextBufferId_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLContextBufferId = (vtkOpenGLContextBufferId)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLContextBufferId.Register(null);
				}
			}
			return vtkOpenGLContextBufferId;
		}

		// Token: 0x06003B09 RID: 15113
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextBufferId_SetContext_14(HandleRef pThis, HandleRef context);

		/// <summary>
		/// Set/Get the OpenGL context owning the texture object resource.
		/// </summary>
		// Token: 0x06003B0A RID: 15114 RVA: 0x00055E9C File Offset: 0x0005409C
		public override void SetContext(vtkRenderWindow context)
		{
			vtkOpenGLContextBufferId.vtkOpenGLContextBufferId_SetContext_14(base.GetCppThis(), (context == null) ? default(HandleRef) : context.GetCppThis());
		}

		// Token: 0x06003B0B RID: 15115
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextBufferId_SetValues_15(HandleRef pThis, int srcXmin, int srcYmin);

		/// <summary>
		/// Copy the contents of the current read buffer to the internal texture
		/// starting at lower left corner of the framebuffer (srcXmin,srcYmin).
		/// \pre is_allocated: this-&gt;IsAllocated()
		/// </summary>
		// Token: 0x06003B0C RID: 15116 RVA: 0x00055ECB File Offset: 0x000540CB
		public override void SetValues(int srcXmin, int srcYmin)
		{
			vtkOpenGLContextBufferId.vtkOpenGLContextBufferId_SetValues_15(base.GetCppThis(), srcXmin, srcYmin);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400067B RID: 1659
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLContextBufferId";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400067C RID: 1660
		public new static readonly string MRClassNameKey = "class vtkOpenGLContextBufferId";
	}
}
