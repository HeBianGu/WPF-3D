using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLRayCastImageDisplayHelper
	/// </summary>
	/// <remarks>
	///    OpenGL subclass that draws the image to the screen
	///
	/// This is the concrete implementation of a ray cast image display helper -
	/// a helper class responsible for drawing the image to the screen.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRayCastImageDisplayHelper
	/// </seealso>
	// Token: 0x020000DB RID: 219
	public class vtkOpenGLRayCastImageDisplayHelper : vtkRayCastImageDisplayHelper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002E21 RID: 11809 RVA: 0x00043AEB File Offset: 0x00041CEB
		static vtkOpenGLRayCastImageDisplayHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLRayCastImageDisplayHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLRayCastImageDisplayHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002E22 RID: 11810 RVA: 0x00043B13 File Offset: 0x00041D13
		public vtkOpenGLRayCastImageDisplayHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002E23 RID: 11811
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRayCastImageDisplayHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E24 RID: 11812 RVA: 0x00043B24 File Offset: 0x00041D24
		public new static vtkOpenGLRayCastImageDisplayHelper New()
		{
			vtkOpenGLRayCastImageDisplayHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRayCastImageDisplayHelper.vtkOpenGLRayCastImageDisplayHelper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLRayCastImageDisplayHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E25 RID: 11813 RVA: 0x00043B78 File Offset: 0x00041D78
		public vtkOpenGLRayCastImageDisplayHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLRayCastImageDisplayHelper.vtkOpenGLRayCastImageDisplayHelper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002E26 RID: 11814 RVA: 0x00043BBC File Offset: 0x00041DBC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002E27 RID: 11815
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLRayCastImageDisplayHelper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E28 RID: 11816 RVA: 0x00043BC8 File Offset: 0x00041DC8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLRayCastImageDisplayHelper.vtkOpenGLRayCastImageDisplayHelper_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06002E29 RID: 11817
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLRayCastImageDisplayHelper_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E2A RID: 11818 RVA: 0x00043BE8 File Offset: 0x00041DE8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLRayCastImageDisplayHelper.vtkOpenGLRayCastImageDisplayHelper_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06002E2B RID: 11819
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRayCastImageDisplayHelper_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E2C RID: 11820 RVA: 0x00043C04 File Offset: 0x00041E04
		public override int IsA(string type)
		{
			return vtkOpenGLRayCastImageDisplayHelper.vtkOpenGLRayCastImageDisplayHelper_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06002E2D RID: 11821
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRayCastImageDisplayHelper_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E2E RID: 11822 RVA: 0x00043C24 File Offset: 0x00041E24
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLRayCastImageDisplayHelper.vtkOpenGLRayCastImageDisplayHelper_IsTypeOf_04(type);
		}

		// Token: 0x06002E2F RID: 11823
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRayCastImageDisplayHelper_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E30 RID: 11824 RVA: 0x00043C40 File Offset: 0x00041E40
		public new vtkOpenGLRayCastImageDisplayHelper NewInstance()
		{
			vtkOpenGLRayCastImageDisplayHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRayCastImageDisplayHelper.vtkOpenGLRayCastImageDisplayHelper_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLRayCastImageDisplayHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002E31 RID: 11825
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRayCastImageDisplayHelper_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef win);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E32 RID: 11826 RVA: 0x00043C9C File Offset: 0x00041E9C
		public override void ReleaseGraphicsResources(vtkWindow win)
		{
			vtkOpenGLRayCastImageDisplayHelper.vtkOpenGLRayCastImageDisplayHelper_ReleaseGraphicsResources_07(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		// Token: 0x06002E33 RID: 11827
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRayCastImageDisplayHelper_RenderTexture_08(HandleRef pThis, HandleRef vol, HandleRef ren, IntPtr imageMemorySize, IntPtr imageViewportSize, IntPtr imageInUseSize, IntPtr imageOrigin, float requestedDepth, IntPtr image);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E34 RID: 11828 RVA: 0x00043CCC File Offset: 0x00041ECC
		public override void RenderTexture(vtkVolume vol, vtkRenderer ren, IntPtr imageMemorySize, IntPtr imageViewportSize, IntPtr imageInUseSize, IntPtr imageOrigin, float requestedDepth, IntPtr image)
		{
			vtkOpenGLRayCastImageDisplayHelper.vtkOpenGLRayCastImageDisplayHelper_RenderTexture_08(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), imageMemorySize, imageViewportSize, imageInUseSize, imageOrigin, requestedDepth, image);
		}

		// Token: 0x06002E35 RID: 11829
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRayCastImageDisplayHelper_RenderTexture_09(HandleRef pThis, HandleRef vol, HandleRef ren, HandleRef image, float requestedDepth);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E36 RID: 11830 RVA: 0x00043D1C File Offset: 0x00041F1C
		public override void RenderTexture(vtkVolume vol, vtkRenderer ren, vtkFixedPointRayCastImage image, float requestedDepth)
		{
			vtkOpenGLRayCastImageDisplayHelper.vtkOpenGLRayCastImageDisplayHelper_RenderTexture_09(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis(), requestedDepth);
		}

		// Token: 0x06002E37 RID: 11831
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRayCastImageDisplayHelper_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E38 RID: 11832 RVA: 0x00043D78 File Offset: 0x00041F78
		public new static vtkOpenGLRayCastImageDisplayHelper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLRayCastImageDisplayHelper vtkOpenGLRayCastImageDisplayHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRayCastImageDisplayHelper.vtkOpenGLRayCastImageDisplayHelper_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLRayCastImageDisplayHelper = (vtkOpenGLRayCastImageDisplayHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLRayCastImageDisplayHelper.Register(null);
				}
			}
			return vtkOpenGLRayCastImageDisplayHelper;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005B2 RID: 1458
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLRayCastImageDisplayHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005B3 RID: 1459
		public new static readonly string MRClassNameKey = "class vtkOpenGLRayCastImageDisplayHelper";
	}
}
