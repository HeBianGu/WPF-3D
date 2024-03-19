using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///     vtkOpenGLCellGridMapper
	/// </summary>
	/// <remarks>
	///     CellGrid mapper using OpenGL to render exotic finite element fields and cells.
	/// </remarks>
	// Token: 0x02000129 RID: 297
	public class vtkOpenGLCellGridMapper : vtkCellGridMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003C42 RID: 15426 RVA: 0x00057C30 File Offset: 0x00055E30
		static vtkOpenGLCellGridMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLCellGridMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLCellGridMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003C43 RID: 15427 RVA: 0x00057C58 File Offset: 0x00055E58
		public vtkOpenGLCellGridMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003C44 RID: 15428
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLCellGridMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C45 RID: 15429 RVA: 0x00057C68 File Offset: 0x00055E68
		public new static vtkOpenGLCellGridMapper New()
		{
			vtkOpenGLCellGridMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLCellGridMapper.vtkOpenGLCellGridMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLCellGridMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C46 RID: 15430 RVA: 0x00057CBC File Offset: 0x00055EBC
		public vtkOpenGLCellGridMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLCellGridMapper.vtkOpenGLCellGridMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003C47 RID: 15431 RVA: 0x00057D00 File Offset: 0x00055F00
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003C48 RID: 15432
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLCellGridMapper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C49 RID: 15433 RVA: 0x00057D0C File Offset: 0x00055F0C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLCellGridMapper.vtkOpenGLCellGridMapper_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06003C4A RID: 15434
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLCellGridMapper_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C4B RID: 15435 RVA: 0x00057D2C File Offset: 0x00055F2C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLCellGridMapper.vtkOpenGLCellGridMapper_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06003C4C RID: 15436
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLCellGridMapper_GetSupportsSelection_03(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Used by vtkHardwareSelector to determine if the prop supports hardware
		/// selection.
		/// </summary>
		// Token: 0x06003C4D RID: 15437 RVA: 0x00057D48 File Offset: 0x00055F48
		public override bool GetSupportsSelection()
		{
			return vtkOpenGLCellGridMapper.vtkOpenGLCellGridMapper_GetSupportsSelection_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06003C4E RID: 15438
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLCellGridMapper_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C4F RID: 15439 RVA: 0x00057D70 File Offset: 0x00055F70
		public override int IsA(string type)
		{
			return vtkOpenGLCellGridMapper.vtkOpenGLCellGridMapper_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06003C50 RID: 15440
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLCellGridMapper_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C51 RID: 15441 RVA: 0x00057D90 File Offset: 0x00055F90
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLCellGridMapper.vtkOpenGLCellGridMapper_IsTypeOf_05(type);
		}

		// Token: 0x06003C52 RID: 15442
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLCellGridMapper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C53 RID: 15443 RVA: 0x00057DAC File Offset: 0x00055FAC
		public new vtkOpenGLCellGridMapper NewInstance()
		{
			vtkOpenGLCellGridMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLCellGridMapper.vtkOpenGLCellGridMapper_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLCellGridMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003C54 RID: 15444
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLCellGridMapper_ReleaseGraphicsResources_08(HandleRef pThis, HandleRef window);

		/// <summary>
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06003C55 RID: 15445 RVA: 0x00057E08 File Offset: 0x00056008
		public override void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkOpenGLCellGridMapper.vtkOpenGLCellGridMapper_ReleaseGraphicsResources_08(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		// Token: 0x06003C56 RID: 15446
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLCellGridMapper_Render_09(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C57 RID: 15447 RVA: 0x00057E38 File Offset: 0x00056038
		public override void Render(vtkRenderer arg0, vtkActor arg1)
		{
			vtkOpenGLCellGridMapper.vtkOpenGLCellGridMapper_Render_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06003C58 RID: 15448
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLCellGridMapper_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C59 RID: 15449 RVA: 0x00057E7C File Offset: 0x0005607C
		public new static vtkOpenGLCellGridMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLCellGridMapper vtkOpenGLCellGridMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLCellGridMapper.vtkOpenGLCellGridMapper_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLCellGridMapper = (vtkOpenGLCellGridMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLCellGridMapper.Register(null);
				}
			}
			return vtkOpenGLCellGridMapper;
		}

		// Token: 0x06003C5A RID: 15450
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLCellGridMapper_ShallowCopy_11(HandleRef pThis, HandleRef m);

		/// <summary>
		/// Make a shallow copy of this mapper.
		/// </summary>
		// Token: 0x06003C5B RID: 15451 RVA: 0x00057EFC File Offset: 0x000560FC
		public override void ShallowCopy(vtkAbstractMapper m)
		{
			vtkOpenGLCellGridMapper.vtkOpenGLCellGridMapper_ShallowCopy_11(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400068B RID: 1675
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLCellGridMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400068C RID: 1676
		public new static readonly string MRClassNameKey = "class vtkOpenGLCellGridMapper";
	}
}
