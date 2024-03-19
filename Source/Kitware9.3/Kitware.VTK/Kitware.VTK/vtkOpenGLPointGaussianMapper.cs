using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLPointGaussianMapper
	/// </summary>
	/// <remarks>
	///    draw PointGaussians using imposters
	///
	/// An OpenGL mapper that uses imposters to draw PointGaussians. Supports
	/// transparency and picking as well.
	/// </remarks>
	// Token: 0x020005BF RID: 1471
	public class vtkOpenGLPointGaussianMapper : vtkPointGaussianMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010183 RID: 65923 RVA: 0x001669DF File Offset: 0x00164BDF
		static vtkOpenGLPointGaussianMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLPointGaussianMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLPointGaussianMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010184 RID: 65924 RVA: 0x00166A07 File Offset: 0x00164C07
		public vtkOpenGLPointGaussianMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010185 RID: 65925
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLPointGaussianMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010186 RID: 65926 RVA: 0x00166A18 File Offset: 0x00164C18
		public new static vtkOpenGLPointGaussianMapper New()
		{
			vtkOpenGLPointGaussianMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLPointGaussianMapper.vtkOpenGLPointGaussianMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLPointGaussianMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010187 RID: 65927 RVA: 0x00166A6C File Offset: 0x00164C6C
		public vtkOpenGLPointGaussianMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLPointGaussianMapper.vtkOpenGLPointGaussianMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010188 RID: 65928 RVA: 0x00166AB0 File Offset: 0x00164CB0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010189 RID: 65929
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLPointGaussianMapper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601018A RID: 65930 RVA: 0x00166ABC File Offset: 0x00164CBC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLPointGaussianMapper.vtkOpenGLPointGaussianMapper_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601018B RID: 65931
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLPointGaussianMapper_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601018C RID: 65932 RVA: 0x00166ADC File Offset: 0x00164CDC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLPointGaussianMapper.vtkOpenGLPointGaussianMapper_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601018D RID: 65933
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLPointGaussianMapper_HasTranslucentPolygonalGeometry_03(HandleRef pThis);

		/// <summary>
		/// Based on emissive setting
		/// </summary>
		// Token: 0x0601018E RID: 65934 RVA: 0x00166AF8 File Offset: 0x00164CF8
		public override bool HasTranslucentPolygonalGeometry()
		{
			return vtkOpenGLPointGaussianMapper.vtkOpenGLPointGaussianMapper_HasTranslucentPolygonalGeometry_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0601018F RID: 65935
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLPointGaussianMapper_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010190 RID: 65936 RVA: 0x00166B20 File Offset: 0x00164D20
		public override int IsA(string type)
		{
			return vtkOpenGLPointGaussianMapper.vtkOpenGLPointGaussianMapper_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06010191 RID: 65937
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLPointGaussianMapper_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010192 RID: 65938 RVA: 0x00166B40 File Offset: 0x00164D40
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLPointGaussianMapper.vtkOpenGLPointGaussianMapper_IsTypeOf_05(type);
		}

		// Token: 0x06010193 RID: 65939
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLPointGaussianMapper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010194 RID: 65940 RVA: 0x00166B5C File Offset: 0x00164D5C
		public new vtkOpenGLPointGaussianMapper NewInstance()
		{
			vtkOpenGLPointGaussianMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLPointGaussianMapper.vtkOpenGLPointGaussianMapper_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLPointGaussianMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010195 RID: 65941
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPointGaussianMapper_ReleaseGraphicsResources_08(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06010196 RID: 65942 RVA: 0x00166BB8 File Offset: 0x00164DB8
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkOpenGLPointGaussianMapper.vtkOpenGLPointGaussianMapper_ReleaseGraphicsResources_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010197 RID: 65943
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLPointGaussianMapper_Render_09(HandleRef pThis, HandleRef ren, HandleRef act);

		/// <summary>
		/// This calls RenderPiece (in a for loop if streaming is necessary).
		/// </summary>
		// Token: 0x06010198 RID: 65944 RVA: 0x00166BE8 File Offset: 0x00164DE8
		public override void Render(vtkRenderer ren, vtkActor act)
		{
			vtkOpenGLPointGaussianMapper.vtkOpenGLPointGaussianMapper_Render_09(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		// Token: 0x06010199 RID: 65945
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLPointGaussianMapper_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601019A RID: 65946 RVA: 0x00166C2C File Offset: 0x00164E2C
		public new static vtkOpenGLPointGaussianMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLPointGaussianMapper vtkOpenGLPointGaussianMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLPointGaussianMapper.vtkOpenGLPointGaussianMapper_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLPointGaussianMapper = (vtkOpenGLPointGaussianMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLPointGaussianMapper.Register(null);
				}
			}
			return vtkOpenGLPointGaussianMapper;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012C0 RID: 4800
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLPointGaussianMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012C1 RID: 4801
		public new static readonly string MRClassNameKey = "class vtkOpenGLPointGaussianMapper";
	}
}
