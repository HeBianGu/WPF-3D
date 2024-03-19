using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCuller
	/// </summary>
	/// <remarks>
	///    a superclass for prop cullers
	///
	/// A culler has a cull method called by the vtkRenderer. The cull
	/// method is called before any rendering is performed,
	/// and it allows the culler to do some processing on the props and
	/// to modify their AllocatedRenderTime and re-order them in the prop list.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFrustumCoverageCuller
	/// </seealso>
	// Token: 0x020007D7 RID: 2007
	public abstract class vtkCuller : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060149C7 RID: 84423 RVA: 0x001D2D4B File Offset: 0x001D0F4B
		static vtkCuller()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCuller.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCuller"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060149C8 RID: 84424 RVA: 0x001D2D73 File Offset: 0x001D0F73
		public vtkCuller(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060149C9 RID: 84425 RVA: 0x001D2D81 File Offset: 0x001D0F81
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060149CA RID: 84426
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCuller_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149CB RID: 84427 RVA: 0x001D2D8C File Offset: 0x001D0F8C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCuller.vtkCuller_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060149CC RID: 84428
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCuller_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149CD RID: 84429 RVA: 0x001D2DAC File Offset: 0x001D0FAC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCuller.vtkCuller_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060149CE RID: 84430
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCuller_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149CF RID: 84431 RVA: 0x001D2DC8 File Offset: 0x001D0FC8
		public override int IsA(string type)
		{
			return vtkCuller.vtkCuller_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060149D0 RID: 84432
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCuller_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149D1 RID: 84433 RVA: 0x001D2DE8 File Offset: 0x001D0FE8
		public new static int IsTypeOf(string type)
		{
			return vtkCuller.vtkCuller_IsTypeOf_04(type);
		}

		// Token: 0x060149D2 RID: 84434
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCuller_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149D3 RID: 84435 RVA: 0x001D2E04 File Offset: 0x001D1004
		public new vtkCuller NewInstance()
		{
			vtkCuller result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCuller.vtkCuller_NewInstance_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCuller)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060149D4 RID: 84436
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCuller_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149D5 RID: 84437 RVA: 0x001D2E60 File Offset: 0x001D1060
		public new static vtkCuller SafeDownCast(vtkObjectBase o)
		{
			vtkCuller vtkCuller = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCuller.vtkCuller_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCuller = (vtkCuller)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCuller.Register(null);
				}
			}
			return vtkCuller;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017D4 RID: 6100
		public new const string MRFullTypeName = "Kitware.VTK.vtkCuller";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017D5 RID: 6101
		public new static readonly string MRClassNameKey = "class vtkCuller";
	}
}
