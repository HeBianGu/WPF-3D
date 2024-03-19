using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRendererDelegate
	/// </summary>
	/// <remarks>
	///    Render the props of a vtkRenderer
	///
	/// vtkRendererDelegate is an abstract class with a pure virtual method Render.
	/// This method replaces the Render method of vtkRenderer to allow custom
	/// rendering from an external project. A RendererDelegate is connected to
	/// a vtkRenderer with method SetDelegate(). An external project just
	/// has to provide a concrete implementation of vtkRendererDelegate.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderer
	/// </seealso>
	// Token: 0x020007FC RID: 2044
	public abstract class vtkRendererDelegate : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014FE6 RID: 85990 RVA: 0x001DB5EB File Offset: 0x001D97EB
		static vtkRendererDelegate()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRendererDelegate.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRendererDelegate"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014FE7 RID: 85991 RVA: 0x001DB613 File Offset: 0x001D9813
		public vtkRendererDelegate(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014FE8 RID: 85992 RVA: 0x001DB621 File Offset: 0x001D9821
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014FE9 RID: 85993
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRendererDelegate_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FEA RID: 85994 RVA: 0x001DB62C File Offset: 0x001D982C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRendererDelegate.vtkRendererDelegate_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06014FEB RID: 85995
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRendererDelegate_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FEC RID: 85996 RVA: 0x001DB64C File Offset: 0x001D984C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRendererDelegate.vtkRendererDelegate_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06014FED RID: 85997
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRendererDelegate_GetUsed_03(HandleRef pThis);

		/// <summary>
		/// Tells if the delegate has to be used by the renderer or not.
		/// Initial value is off.
		/// </summary>
		// Token: 0x06014FEE RID: 85998 RVA: 0x001DB668 File Offset: 0x001D9868
		public virtual bool GetUsed()
		{
			return vtkRendererDelegate.vtkRendererDelegate_GetUsed_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06014FEF RID: 85999
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRendererDelegate_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FF0 RID: 86000 RVA: 0x001DB690 File Offset: 0x001D9890
		public override int IsA(string type)
		{
			return vtkRendererDelegate.vtkRendererDelegate_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06014FF1 RID: 86001
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRendererDelegate_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FF2 RID: 86002 RVA: 0x001DB6B0 File Offset: 0x001D98B0
		public new static int IsTypeOf(string type)
		{
			return vtkRendererDelegate.vtkRendererDelegate_IsTypeOf_05(type);
		}

		// Token: 0x06014FF3 RID: 86003
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRendererDelegate_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FF4 RID: 86004 RVA: 0x001DB6CC File Offset: 0x001D98CC
		public new vtkRendererDelegate NewInstance()
		{
			vtkRendererDelegate result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRendererDelegate.vtkRendererDelegate_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRendererDelegate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014FF5 RID: 86005
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererDelegate_Render_07(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Render the props of vtkRenderer if Used is on.
		/// </summary>
		// Token: 0x06014FF6 RID: 86006 RVA: 0x001DB728 File Offset: 0x001D9928
		public virtual void Render(vtkRenderer r)
		{
			vtkRendererDelegate.vtkRendererDelegate_Render_07(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		// Token: 0x06014FF7 RID: 86007
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRendererDelegate_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FF8 RID: 86008 RVA: 0x001DB758 File Offset: 0x001D9958
		public new static vtkRendererDelegate SafeDownCast(vtkObjectBase o)
		{
			vtkRendererDelegate vtkRendererDelegate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRendererDelegate.vtkRendererDelegate_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRendererDelegate = (vtkRendererDelegate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRendererDelegate.Register(null);
				}
			}
			return vtkRendererDelegate;
		}

		// Token: 0x06014FF9 RID: 86009
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererDelegate_SetUsed_09(HandleRef pThis, byte _arg);

		/// <summary>
		/// Tells if the delegate has to be used by the renderer or not.
		/// Initial value is off.
		/// </summary>
		// Token: 0x06014FFA RID: 86010 RVA: 0x001DB7D7 File Offset: 0x001D99D7
		public virtual void SetUsed(bool _arg)
		{
			vtkRendererDelegate.vtkRendererDelegate_SetUsed_09(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06014FFB RID: 86011
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererDelegate_UsedOff_10(HandleRef pThis);

		/// <summary>
		/// Tells if the delegate has to be used by the renderer or not.
		/// Initial value is off.
		/// </summary>
		// Token: 0x06014FFC RID: 86012 RVA: 0x001DB7EF File Offset: 0x001D99EF
		public virtual void UsedOff()
		{
			vtkRendererDelegate.vtkRendererDelegate_UsedOff_10(base.GetCppThis());
		}

		// Token: 0x06014FFD RID: 86013
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererDelegate_UsedOn_11(HandleRef pThis);

		/// <summary>
		/// Tells if the delegate has to be used by the renderer or not.
		/// Initial value is off.
		/// </summary>
		// Token: 0x06014FFE RID: 86014 RVA: 0x001DB7FE File Offset: 0x001D99FE
		public virtual void UsedOn()
		{
			vtkRendererDelegate.vtkRendererDelegate_UsedOn_11(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400183C RID: 6204
		public new const string MRFullTypeName = "Kitware.VTK.vtkRendererDelegate";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400183D RID: 6205
		public new static readonly string MRClassNameKey = "class vtkRendererDelegate";
	}
}
