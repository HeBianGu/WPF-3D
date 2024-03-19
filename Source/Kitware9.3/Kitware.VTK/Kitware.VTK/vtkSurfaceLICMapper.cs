using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSurfaceLICMapper
	/// </summary>
	/// <remarks>
	///    mapper that performs LIC on the surface of
	///  arbitrary geometry.
	///
	///
	///  vtkSurfaceLICMapper performs LIC on the surface of arbitrary
	///  geometry. Point vectors are used as the vector field for generating the LIC.
	///  The implementation was originallu  based on "Image Space Based Visualization
	///  on Unsteady Flow on Surfaces" by Laramee, Jobard and Hauser appeared in
	///  proceedings of IEEE Visualization '03, pages 131-138.
	///
	///  Internal pipeline:
	/// &lt;pre&gt;
	/// noise
	///     |
	///     [ PROJ (GAT) (COMP) LIC2D (SCAT) SHADE (CCE) DEP]
	///     |                                               |
	/// vectors                                         surface LIC
	/// &lt;/pre&gt;
	/// PROj  - project vectors onto surface
	/// GAT   - gather data for compositing and guard pixel generation  (parallel only)
	/// COMP  - composite gathered data
	/// LIC2D - line intengral convolution, see vtkLineIntegralConvolution2D.
	/// SCAT  - scatter result (parallel only, not all compositors use it)
	/// SHADE - combine LIC and scalar colors
	/// CCE   - color contrast enhancement (optional)
	/// DEP   - depth test and copy to back buffer
	///
	/// The result of each stage is cached in a texture so that during interaction
	/// a stage may be skipped if the user has not modified its parameters or input
	/// data.
	///
	/// The parallel parts of algorithm are implemented in vtkPSurfaceLICMapper.
	/// Note that for MPI enabled builds this class will be automatically created
	/// by the object factory.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLineIntegralConvolution2D
	/// </seealso>
	// Token: 0x0200010C RID: 268
	public class vtkSurfaceLICMapper : vtkOpenGLPolyDataMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060036BE RID: 14014 RVA: 0x00050064 File Offset: 0x0004E264
		static vtkSurfaceLICMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSurfaceLICMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSurfaceLICMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060036BF RID: 14015 RVA: 0x0005008C File Offset: 0x0004E28C
		public vtkSurfaceLICMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060036C0 RID: 14016
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSurfaceLICMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060036C1 RID: 14017 RVA: 0x0005009C File Offset: 0x0004E29C
		public new static vtkSurfaceLICMapper New()
		{
			vtkSurfaceLICMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSurfaceLICMapper.vtkSurfaceLICMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSurfaceLICMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060036C2 RID: 14018 RVA: 0x000500F0 File Offset: 0x0004E2F0
		public vtkSurfaceLICMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSurfaceLICMapper.vtkSurfaceLICMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060036C3 RID: 14019 RVA: 0x00050134 File Offset: 0x0004E334
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060036C4 RID: 14020
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSurfaceLICMapper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060036C5 RID: 14021 RVA: 0x00050140 File Offset: 0x0004E340
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSurfaceLICMapper.vtkSurfaceLICMapper_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060036C6 RID: 14022
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSurfaceLICMapper_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060036C7 RID: 14023 RVA: 0x00050160 File Offset: 0x0004E360
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSurfaceLICMapper.vtkSurfaceLICMapper_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060036C8 RID: 14024
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceLICMapper_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060036C9 RID: 14025 RVA: 0x0005017C File Offset: 0x0004E37C
		public override int IsA(string type)
		{
			return vtkSurfaceLICMapper.vtkSurfaceLICMapper_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060036CA RID: 14026
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceLICMapper_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060036CB RID: 14027 RVA: 0x0005019C File Offset: 0x0004E39C
		public new static int IsTypeOf(string type)
		{
			return vtkSurfaceLICMapper.vtkSurfaceLICMapper_IsTypeOf_04(type);
		}

		// Token: 0x060036CC RID: 14028
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSurfaceLICMapper_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060036CD RID: 14029 RVA: 0x000501B8 File Offset: 0x0004E3B8
		public new vtkSurfaceLICMapper NewInstance()
		{
			vtkSurfaceLICMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSurfaceLICMapper.vtkSurfaceLICMapper_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSurfaceLICMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060036CE RID: 14030
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceLICMapper_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef win);

		/// <summary>
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release. In this case, releases the display lists.
		/// </summary>
		// Token: 0x060036CF RID: 14031 RVA: 0x00050214 File Offset: 0x0004E414
		public override void ReleaseGraphicsResources(vtkWindow win)
		{
			vtkSurfaceLICMapper.vtkSurfaceLICMapper_ReleaseGraphicsResources_07(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		// Token: 0x060036D0 RID: 14032
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceLICMapper_RenderPiece_08(HandleRef pThis, HandleRef ren, HandleRef act);

		/// <summary>
		/// Implemented by sub classes. Actual rendering is done here.
		/// </summary>
		// Token: 0x060036D1 RID: 14033 RVA: 0x00050244 File Offset: 0x0004E444
		public override void RenderPiece(vtkRenderer ren, vtkActor act)
		{
			vtkSurfaceLICMapper.vtkSurfaceLICMapper_RenderPiece_08(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		// Token: 0x060036D2 RID: 14034
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSurfaceLICMapper_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060036D3 RID: 14035 RVA: 0x00050288 File Offset: 0x0004E488
		public new static vtkSurfaceLICMapper SafeDownCast(vtkObjectBase o)
		{
			vtkSurfaceLICMapper vtkSurfaceLICMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSurfaceLICMapper.vtkSurfaceLICMapper_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSurfaceLICMapper = (vtkSurfaceLICMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSurfaceLICMapper.Register(null);
				}
			}
			return vtkSurfaceLICMapper;
		}

		// Token: 0x060036D4 RID: 14036
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceLICMapper_ShallowCopy_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Shallow copy of an actor.
		/// </summary>
		// Token: 0x060036D5 RID: 14037 RVA: 0x00050308 File Offset: 0x0004E508
		public override void ShallowCopy(vtkAbstractMapper arg0)
		{
			vtkSurfaceLICMapper.vtkSurfaceLICMapper_ShallowCopy_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000650 RID: 1616
		public new const string MRFullTypeName = "Kitware.VTK.vtkSurfaceLICMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000651 RID: 1617
		public new static readonly string MRClassNameKey = "class vtkSurfaceLICMapper";
	}
}
