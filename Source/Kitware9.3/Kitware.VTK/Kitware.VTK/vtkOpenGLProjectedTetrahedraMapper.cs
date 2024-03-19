using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLProjectedTetrahedraMapper
	/// </summary>
	/// <remarks>
	///    OpenGL implementation of PT
	///
	/// @bug
	/// This mapper relies highly on the implementation of the OpenGL pipeline.
	/// A typical hardware driver has lots of options and some settings can
	/// cause this mapper to produce artifacts.
	///
	/// </remarks>
	// Token: 0x020000D9 RID: 217
	public class vtkOpenGLProjectedTetrahedraMapper : vtkProjectedTetrahedraMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002DD9 RID: 11737 RVA: 0x000433E8 File Offset: 0x000415E8
		static vtkOpenGLProjectedTetrahedraMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLProjectedTetrahedraMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLProjectedTetrahedraMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002DDA RID: 11738 RVA: 0x00043410 File Offset: 0x00041610
		public vtkOpenGLProjectedTetrahedraMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002DDB RID: 11739
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLProjectedTetrahedraMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DDC RID: 11740 RVA: 0x00043420 File Offset: 0x00041620
		public new static vtkOpenGLProjectedTetrahedraMapper New()
		{
			vtkOpenGLProjectedTetrahedraMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLProjectedTetrahedraMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DDD RID: 11741 RVA: 0x00043474 File Offset: 0x00041674
		public vtkOpenGLProjectedTetrahedraMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002DDE RID: 11742 RVA: 0x000434B8 File Offset: 0x000416B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002DDF RID: 11743
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLProjectedTetrahedraMapper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DE0 RID: 11744 RVA: 0x000434C4 File Offset: 0x000416C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06002DE1 RID: 11745
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLProjectedTetrahedraMapper_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DE2 RID: 11746 RVA: 0x000434E4 File Offset: 0x000416E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06002DE3 RID: 11747
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLProjectedTetrahedraMapper_GetUseFloatingPointFrameBuffer_03(HandleRef pThis);

		/// <summary>
		/// Set/get whether to use floating-point rendering buffers rather
		/// than the default.
		/// </summary>
		// Token: 0x06002DE4 RID: 11748 RVA: 0x00043500 File Offset: 0x00041700
		public virtual bool GetUseFloatingPointFrameBuffer()
		{
			return vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_GetUseFloatingPointFrameBuffer_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06002DE5 RID: 11749
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLProjectedTetrahedraMapper_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DE6 RID: 11750 RVA: 0x00043528 File Offset: 0x00041728
		public override int IsA(string type)
		{
			return vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06002DE7 RID: 11751
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLProjectedTetrahedraMapper_IsSupported_05(HandleRef pThis, HandleRef context);

		/// <summary>
		/// Return true if the rendering context provides
		/// the nececessary functionality to use this class.
		/// </summary>
		// Token: 0x06002DE8 RID: 11752 RVA: 0x00043548 File Offset: 0x00041748
		public override bool IsSupported(vtkRenderWindow context)
		{
			return vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_IsSupported_05(base.GetCppThis(), (context == null) ? default(HandleRef) : context.GetCppThis()) != 0;
		}

		// Token: 0x06002DE9 RID: 11753
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLProjectedTetrahedraMapper_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DEA RID: 11754 RVA: 0x00043584 File Offset: 0x00041784
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_IsTypeOf_06(type);
		}

		// Token: 0x06002DEB RID: 11755
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLProjectedTetrahedraMapper_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DEC RID: 11756 RVA: 0x000435A0 File Offset: 0x000417A0
		public new vtkOpenGLProjectedTetrahedraMapper NewInstance()
		{
			vtkOpenGLProjectedTetrahedraMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLProjectedTetrahedraMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002DED RID: 11757
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLProjectedTetrahedraMapper_ReleaseGraphicsResources_09(HandleRef pThis, HandleRef window);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DEE RID: 11758 RVA: 0x000435FC File Offset: 0x000417FC
		public override void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_ReleaseGraphicsResources_09(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		// Token: 0x06002DEF RID: 11759
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLProjectedTetrahedraMapper_Render_10(HandleRef pThis, HandleRef renderer, HandleRef volume);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DF0 RID: 11760 RVA: 0x0004362C File Offset: 0x0004182C
		public override void Render(vtkRenderer renderer, vtkVolume volume)
		{
			vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_Render_10(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis());
		}

		// Token: 0x06002DF1 RID: 11761
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLProjectedTetrahedraMapper_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DF2 RID: 11762 RVA: 0x00043670 File Offset: 0x00041870
		public new static vtkOpenGLProjectedTetrahedraMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLProjectedTetrahedraMapper vtkOpenGLProjectedTetrahedraMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLProjectedTetrahedraMapper = (vtkOpenGLProjectedTetrahedraMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLProjectedTetrahedraMapper.Register(null);
				}
			}
			return vtkOpenGLProjectedTetrahedraMapper;
		}

		// Token: 0x06002DF3 RID: 11763
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLProjectedTetrahedraMapper_SetUseFloatingPointFrameBuffer_12(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/get whether to use floating-point rendering buffers rather
		/// than the default.
		/// </summary>
		// Token: 0x06002DF4 RID: 11764 RVA: 0x000436EF File Offset: 0x000418EF
		public virtual void SetUseFloatingPointFrameBuffer(bool _arg)
		{
			vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_SetUseFloatingPointFrameBuffer_12(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06002DF5 RID: 11765
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLProjectedTetrahedraMapper_UseFloatingPointFrameBufferOff_13(HandleRef pThis);

		/// <summary>
		/// Set/get whether to use floating-point rendering buffers rather
		/// than the default.
		/// </summary>
		// Token: 0x06002DF6 RID: 11766 RVA: 0x00043707 File Offset: 0x00041907
		public virtual void UseFloatingPointFrameBufferOff()
		{
			vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_UseFloatingPointFrameBufferOff_13(base.GetCppThis());
		}

		// Token: 0x06002DF7 RID: 11767
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLProjectedTetrahedraMapper_UseFloatingPointFrameBufferOn_14(HandleRef pThis);

		/// <summary>
		/// Set/get whether to use floating-point rendering buffers rather
		/// than the default.
		/// </summary>
		// Token: 0x06002DF8 RID: 11768 RVA: 0x00043716 File Offset: 0x00041916
		public virtual void UseFloatingPointFrameBufferOn()
		{
			vtkOpenGLProjectedTetrahedraMapper.vtkOpenGLProjectedTetrahedraMapper_UseFloatingPointFrameBufferOn_14(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005AE RID: 1454
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLProjectedTetrahedraMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005AF RID: 1455
		public new static readonly string MRClassNameKey = "class vtkOpenGLProjectedTetrahedraMapper";
	}
}
