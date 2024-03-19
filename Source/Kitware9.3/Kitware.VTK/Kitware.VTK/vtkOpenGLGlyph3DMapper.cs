using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLGlyph3DMapper
	/// </summary>
	/// <remarks>
	///    vtkOpenGLGlyph3D on the GPU.
	///
	/// Do the same job than vtkGlyph3D but on the GPU. For this reason, it is
	/// a mapper not a vtkPolyDataAlgorithm. Also, some methods of vtkOpenGLGlyph3D
	/// don't make sense in vtkOpenGLGlyph3DMapper: GeneratePointIds, old-style
	/// SetSource, PointIdsName, IsPointVisible.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkOpenGLGlyph3D
	/// </seealso>
	// Token: 0x020005AE RID: 1454
	public class vtkOpenGLGlyph3DMapper : vtkGlyph3DMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FEFE RID: 65278 RVA: 0x00162C89 File Offset: 0x00160E89
		static vtkOpenGLGlyph3DMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLGlyph3DMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLGlyph3DMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FEFF RID: 65279 RVA: 0x00162CB1 File Offset: 0x00160EB1
		public vtkOpenGLGlyph3DMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FF00 RID: 65280
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLGlyph3DMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FF01 RID: 65281 RVA: 0x00162CC0 File Offset: 0x00160EC0
		public new static vtkOpenGLGlyph3DMapper New()
		{
			vtkOpenGLGlyph3DMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLGlyph3DMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FF02 RID: 65282 RVA: 0x00162D14 File Offset: 0x00160F14
		public vtkOpenGLGlyph3DMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FF03 RID: 65283 RVA: 0x00162D58 File Offset: 0x00160F58
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FF04 RID: 65284
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLGlyph3DMapper_GetMaxNumberOfLOD_01(HandleRef pThis);

		/// <summary>
		/// Get the maximum number of LOD. OpenGL context must be bound.
		/// The maximum number of LOD depends on GPU capabilities.
		/// </summary>
		// Token: 0x0600FF05 RID: 65285 RVA: 0x00162D64 File Offset: 0x00160F64
		public override long GetMaxNumberOfLOD()
		{
			return vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_GetMaxNumberOfLOD_01(base.GetCppThis());
		}

		// Token: 0x0600FF06 RID: 65286
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLGlyph3DMapper_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FF07 RID: 65287 RVA: 0x00162D84 File Offset: 0x00160F84
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600FF08 RID: 65288
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLGlyph3DMapper_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FF09 RID: 65289 RVA: 0x00162DA4 File Offset: 0x00160FA4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600FF0A RID: 65290
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLGlyph3DMapper_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FF0B RID: 65291 RVA: 0x00162DC0 File Offset: 0x00160FC0
		public override int IsA(string type)
		{
			return vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600FF0C RID: 65292
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLGlyph3DMapper_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FF0D RID: 65293 RVA: 0x00162DE0 File Offset: 0x00160FE0
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_IsTypeOf_05(type);
		}

		// Token: 0x0600FF0E RID: 65294
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLGlyph3DMapper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FF0F RID: 65295 RVA: 0x00162DFC File Offset: 0x00160FFC
		public new vtkOpenGLGlyph3DMapper NewInstance()
		{
			vtkOpenGLGlyph3DMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLGlyph3DMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FF10 RID: 65296
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLGlyph3DMapper_ReleaseGraphicsResources_08(HandleRef pThis, HandleRef window);

		/// <summary>
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600FF11 RID: 65297 RVA: 0x00162E58 File Offset: 0x00161058
		public override void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_ReleaseGraphicsResources_08(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		// Token: 0x0600FF12 RID: 65298
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLGlyph3DMapper_Render_09(HandleRef pThis, HandleRef ren, HandleRef a);

		/// <summary>
		/// Method initiates the mapping process. Generally sent by the actor
		/// as each frame is rendered.
		/// </summary>
		// Token: 0x0600FF13 RID: 65299 RVA: 0x00162E88 File Offset: 0x00161088
		public override void Render(vtkRenderer ren, vtkActor a)
		{
			vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_Render_09(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x0600FF14 RID: 65300
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLGlyph3DMapper_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FF15 RID: 65301 RVA: 0x00162ECC File Offset: 0x001610CC
		public new static vtkOpenGLGlyph3DMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLGlyph3DMapper vtkOpenGLGlyph3DMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLGlyph3DMapper = (vtkOpenGLGlyph3DMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLGlyph3DMapper.Register(null);
				}
			}
			return vtkOpenGLGlyph3DMapper;
		}

		// Token: 0x0600FF16 RID: 65302
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLGlyph3DMapper_SetLODDistanceAndTargetReduction_11(HandleRef pThis, long index, float distance, float targetReduction);

		/// <summary>
		/// Configure LODs. Culling must be enabled.
		/// distance have to be a positive value, it is the distance to the camera scaled by
		/// the instanced geometry bounding box.
		/// targetReduction have to be between 0 and 1, 0 disable decimation, 1 draw a point.
		///
		/// @sa vtkDecimatePro::SetTargetReduction
		/// </summary>
		// Token: 0x0600FF17 RID: 65303 RVA: 0x00162F4B File Offset: 0x0016114B
		public override void SetLODDistanceAndTargetReduction(long index, float distance, float targetReduction)
		{
			vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_SetLODDistanceAndTargetReduction_11(base.GetCppThis(), index, distance, targetReduction);
		}

		// Token: 0x0600FF18 RID: 65304
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLGlyph3DMapper_SetNumberOfLOD_12(HandleRef pThis, long nb);

		/// <summary>
		/// Set the number of LOD.
		/// </summary>
		// Token: 0x0600FF19 RID: 65305 RVA: 0x00162F5D File Offset: 0x0016115D
		public override void SetNumberOfLOD(long nb)
		{
			vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_SetNumberOfLOD_12(base.GetCppThis(), nb);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001296 RID: 4758
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLGlyph3DMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001297 RID: 4759
		public new static readonly string MRClassNameKey = "class vtkOpenGLGlyph3DMapper";
	}
}
