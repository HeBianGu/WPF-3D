using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLImageSliceMapper
	/// </summary>
	/// <remarks>
	///    OpenGL mapper for image slice display
	///
	/// vtkOpenGLImageSliceMapper is a concrete implementation of the abstract
	/// class vtkImageSliceMapper that interfaces to the OpenGL library.
	/// @par Thanks:
	/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
	/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
	/// </remarks>
	// Token: 0x020005B9 RID: 1465
	public class vtkOpenGLImageSliceMapper : vtkImageSliceMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060100A5 RID: 65701 RVA: 0x00165291 File Offset: 0x00163491
		static vtkOpenGLImageSliceMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLImageSliceMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLImageSliceMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060100A6 RID: 65702 RVA: 0x001652B9 File Offset: 0x001634B9
		public vtkOpenGLImageSliceMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060100A7 RID: 65703
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLImageSliceMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100A8 RID: 65704 RVA: 0x001652C8 File Offset: 0x001634C8
		public new static vtkOpenGLImageSliceMapper New()
		{
			vtkOpenGLImageSliceMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLImageSliceMapper.vtkOpenGLImageSliceMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLImageSliceMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100A9 RID: 65705 RVA: 0x0016531C File Offset: 0x0016351C
		public vtkOpenGLImageSliceMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLImageSliceMapper.vtkOpenGLImageSliceMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060100AA RID: 65706 RVA: 0x00165360 File Offset: 0x00163560
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060100AB RID: 65707
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLImageSliceMapper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100AC RID: 65708 RVA: 0x0016536C File Offset: 0x0016356C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLImageSliceMapper.vtkOpenGLImageSliceMapper_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060100AD RID: 65709
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLImageSliceMapper_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100AE RID: 65710 RVA: 0x0016538C File Offset: 0x0016358C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLImageSliceMapper.vtkOpenGLImageSliceMapper_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060100AF RID: 65711
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLImageSliceMapper_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100B0 RID: 65712 RVA: 0x001653A8 File Offset: 0x001635A8
		public override int IsA(string type)
		{
			return vtkOpenGLImageSliceMapper.vtkOpenGLImageSliceMapper_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060100B1 RID: 65713
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLImageSliceMapper_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100B2 RID: 65714 RVA: 0x001653C8 File Offset: 0x001635C8
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLImageSliceMapper.vtkOpenGLImageSliceMapper_IsTypeOf_04(type);
		}

		// Token: 0x060100B3 RID: 65715
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLImageSliceMapper_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100B4 RID: 65716 RVA: 0x001653E4 File Offset: 0x001635E4
		public new vtkOpenGLImageSliceMapper NewInstance()
		{
			vtkOpenGLImageSliceMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLImageSliceMapper.vtkOpenGLImageSliceMapper_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLImageSliceMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060100B5 RID: 65717
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLImageSliceMapper_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this
		/// mapper, the image texture in particular. Using the same texture
		/// in multiple render windows is NOT currently supported.
		/// </summary>
		// Token: 0x060100B6 RID: 65718 RVA: 0x00165440 File Offset: 0x00163640
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkOpenGLImageSliceMapper.vtkOpenGLImageSliceMapper_ReleaseGraphicsResources_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060100B7 RID: 65719
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLImageSliceMapper_Render_08(HandleRef pThis, HandleRef ren, HandleRef prop);

		/// <summary>
		/// Implement base class method.  Perform the render.
		/// </summary>
		// Token: 0x060100B8 RID: 65720 RVA: 0x00165470 File Offset: 0x00163670
		public override void Render(vtkRenderer ren, vtkImageSlice prop)
		{
			vtkOpenGLImageSliceMapper.vtkOpenGLImageSliceMapper_Render_08(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x060100B9 RID: 65721
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLImageSliceMapper_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100BA RID: 65722 RVA: 0x001654B4 File Offset: 0x001636B4
		public new static vtkOpenGLImageSliceMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLImageSliceMapper vtkOpenGLImageSliceMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLImageSliceMapper.vtkOpenGLImageSliceMapper_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLImageSliceMapper = (vtkOpenGLImageSliceMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLImageSliceMapper.Register(null);
				}
			}
			return vtkOpenGLImageSliceMapper;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012B4 RID: 4788
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLImageSliceMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012B5 RID: 4789
		public new static readonly string MRClassNameKey = "class vtkOpenGLImageSliceMapper";
	}
}
