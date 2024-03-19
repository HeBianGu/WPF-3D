using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMapper2D
	/// </summary>
	/// <remarks>
	///    abstract class specifies interface for objects which render 2D actors
	///
	/// vtkMapper2D is an abstract class which defines the interface for objects
	/// which render two dimensional actors (vtkActor2D).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor2D
	/// </seealso>
	// Token: 0x020000E1 RID: 225
	public class vtkMapper2D : vtkAbstractMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002EF5 RID: 12021 RVA: 0x00044B53 File Offset: 0x00042D53
		static vtkMapper2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMapper2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMapper2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002EF6 RID: 12022 RVA: 0x00044B7B File Offset: 0x00042D7B
		public vtkMapper2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002EF7 RID: 12023 RVA: 0x00044B89 File Offset: 0x00042D89
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002EF8 RID: 12024
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMapper2D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002EF9 RID: 12025 RVA: 0x00044B94 File Offset: 0x00042D94
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMapper2D.vtkMapper2D_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06002EFA RID: 12026
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMapper2D_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002EFB RID: 12027 RVA: 0x00044BB4 File Offset: 0x00042DB4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMapper2D.vtkMapper2D_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06002EFC RID: 12028
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapper2D_HasTranslucentPolygonalGeometry_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002EFD RID: 12029 RVA: 0x00044BD0 File Offset: 0x00042DD0
		public virtual int HasTranslucentPolygonalGeometry()
		{
			return vtkMapper2D.vtkMapper2D_HasTranslucentPolygonalGeometry_03(base.GetCppThis());
		}

		// Token: 0x06002EFE RID: 12030
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapper2D_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002EFF RID: 12031 RVA: 0x00044BF0 File Offset: 0x00042DF0
		public override int IsA(string type)
		{
			return vtkMapper2D.vtkMapper2D_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06002F00 RID: 12032
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapper2D_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002F01 RID: 12033 RVA: 0x00044C10 File Offset: 0x00042E10
		public new static int IsTypeOf(string type)
		{
			return vtkMapper2D.vtkMapper2D_IsTypeOf_05(type);
		}

		// Token: 0x06002F02 RID: 12034
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapper2D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002F03 RID: 12035 RVA: 0x00044C2C File Offset: 0x00042E2C
		public new vtkMapper2D NewInstance()
		{
			vtkMapper2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapper2D.vtkMapper2D_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMapper2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002F04 RID: 12036
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper2D_RenderOpaqueGeometry_07(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002F05 RID: 12037 RVA: 0x00044C88 File Offset: 0x00042E88
		public virtual void RenderOpaqueGeometry(vtkViewport arg0, vtkActor2D arg1)
		{
			vtkMapper2D.vtkMapper2D_RenderOpaqueGeometry_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06002F06 RID: 12038
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper2D_RenderOverlay_08(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002F07 RID: 12039 RVA: 0x00044CCC File Offset: 0x00042ECC
		public virtual void RenderOverlay(vtkViewport arg0, vtkActor2D arg1)
		{
			vtkMapper2D.vtkMapper2D_RenderOverlay_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06002F08 RID: 12040
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapper2D_RenderTranslucentPolygonalGeometry_09(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002F09 RID: 12041 RVA: 0x00044D10 File Offset: 0x00042F10
		public virtual void RenderTranslucentPolygonalGeometry(vtkViewport arg0, vtkActor2D arg1)
		{
			vtkMapper2D.vtkMapper2D_RenderTranslucentPolygonalGeometry_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06002F0A RID: 12042
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapper2D_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002F0B RID: 12043 RVA: 0x00044D54 File Offset: 0x00042F54
		public new static vtkMapper2D SafeDownCast(vtkObjectBase o)
		{
			vtkMapper2D vtkMapper2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapper2D.vtkMapper2D_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMapper2D = (vtkMapper2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMapper2D.Register(null);
				}
			}
			return vtkMapper2D;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005C6 RID: 1478
		public new const string MRFullTypeName = "Kitware.VTK.vtkMapper2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005C7 RID: 1479
		public new static readonly string MRClassNameKey = "class vtkMapper2D";
	}
}
