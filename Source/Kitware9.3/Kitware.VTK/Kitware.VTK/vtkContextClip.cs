using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContextClip
	/// </summary>
	/// <remarks>
	///    all children of this item are clipped
	/// by the specified area.
	///
	///
	/// This class can be used to clip the rendering of an item inside a rectangular
	/// area.
	/// </remarks>
	// Token: 0x020007AD RID: 1965
	public class vtkContextClip : vtkAbstractContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060142D1 RID: 82641 RVA: 0x001C817B File Offset: 0x001C637B
		static vtkContextClip()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContextClip.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextClip"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060142D2 RID: 82642 RVA: 0x001C81A3 File Offset: 0x001C63A3
		public vtkContextClip(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060142D3 RID: 82643
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextClip_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a vtkContextClip object.
		/// </summary>
		// Token: 0x060142D4 RID: 82644 RVA: 0x001C81B4 File Offset: 0x001C63B4
		public new static vtkContextClip New()
		{
			vtkContextClip result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextClip.vtkContextClip_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextClip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a vtkContextClip object.
		/// </summary>
		// Token: 0x060142D5 RID: 82645 RVA: 0x001C8208 File Offset: 0x001C6408
		public vtkContextClip() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkContextClip.vtkContextClip_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060142D6 RID: 82646 RVA: 0x001C824C File Offset: 0x001C644C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060142D7 RID: 82647
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkContextClip_GetHeight_01(HandleRef pThis);

		/// <summary>
		/// Get the clipping rectangle parameters in pixel coordinates:
		/// </summary>
		// Token: 0x060142D8 RID: 82648 RVA: 0x001C8258 File Offset: 0x001C6458
		public virtual float GetHeight()
		{
			return vtkContextClip.vtkContextClip_GetHeight_01(base.GetCppThis());
		}

		// Token: 0x060142D9 RID: 82649
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContextClip_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060142DA RID: 82650 RVA: 0x001C8278 File Offset: 0x001C6478
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContextClip.vtkContextClip_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060142DB RID: 82651
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContextClip_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060142DC RID: 82652 RVA: 0x001C8298 File Offset: 0x001C6498
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContextClip.vtkContextClip_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060142DD RID: 82653
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextClip_GetRect_04(HandleRef pThis, IntPtr rect);

		/// <summary>
		/// Get the clipping rectangle parameters in pixel coordinates:
		/// </summary>
		// Token: 0x060142DE RID: 82654 RVA: 0x001C82B2 File Offset: 0x001C64B2
		public virtual void GetRect(IntPtr rect)
		{
			vtkContextClip.vtkContextClip_GetRect_04(base.GetCppThis(), rect);
		}

		// Token: 0x060142DF RID: 82655
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkContextClip_GetWidth_05(HandleRef pThis);

		/// <summary>
		/// Get the clipping rectangle parameters in pixel coordinates:
		/// </summary>
		// Token: 0x060142E0 RID: 82656 RVA: 0x001C82C4 File Offset: 0x001C64C4
		public virtual float GetWidth()
		{
			return vtkContextClip.vtkContextClip_GetWidth_05(base.GetCppThis());
		}

		// Token: 0x060142E1 RID: 82657
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkContextClip_GetX_06(HandleRef pThis);

		/// <summary>
		/// Get the clipping rectangle parameters in pixel coordinates:
		/// </summary>
		// Token: 0x060142E2 RID: 82658 RVA: 0x001C82E4 File Offset: 0x001C64E4
		public virtual float GetX()
		{
			return vtkContextClip.vtkContextClip_GetX_06(base.GetCppThis());
		}

		// Token: 0x060142E3 RID: 82659
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkContextClip_GetY_07(HandleRef pThis);

		/// <summary>
		/// Get the clipping rectangle parameters in pixel coordinates:
		/// </summary>
		// Token: 0x060142E4 RID: 82660 RVA: 0x001C8304 File Offset: 0x001C6504
		public virtual float GetY()
		{
			return vtkContextClip.vtkContextClip_GetY_07(base.GetCppThis());
		}

		// Token: 0x060142E5 RID: 82661
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextClip_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060142E6 RID: 82662 RVA: 0x001C8324 File Offset: 0x001C6524
		public override int IsA(string type)
		{
			return vtkContextClip.vtkContextClip_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x060142E7 RID: 82663
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextClip_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060142E8 RID: 82664 RVA: 0x001C8344 File Offset: 0x001C6544
		public new static int IsTypeOf(string type)
		{
			return vtkContextClip.vtkContextClip_IsTypeOf_09(type);
		}

		// Token: 0x060142E9 RID: 82665
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextClip_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060142EA RID: 82666 RVA: 0x001C8360 File Offset: 0x001C6560
		public new vtkContextClip NewInstance()
		{
			vtkContextClip result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextClip.vtkContextClip_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextClip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060142EB RID: 82667
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContextClip_Paint_12(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the item, called whenever the item needs to be drawn.
		/// </summary>
		// Token: 0x060142EC RID: 82668 RVA: 0x001C83BC File Offset: 0x001C65BC
		public override bool Paint(vtkContext2D painter)
		{
			return vtkContextClip.vtkContextClip_Paint_12(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x060142ED RID: 82669
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextClip_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060142EE RID: 82670 RVA: 0x001C83F8 File Offset: 0x001C65F8
		public new static vtkContextClip SafeDownCast(vtkObjectBase o)
		{
			vtkContextClip vtkContextClip = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextClip.vtkContextClip_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContextClip = (vtkContextClip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContextClip.Register(null);
				}
			}
			return vtkContextClip;
		}

		// Token: 0x060142EF RID: 82671
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextClip_SetClip_14(HandleRef pThis, float x, float y, float width, float height);

		/// <summary>
		/// Set the origin, width and height of the clipping rectangle. These are in
		/// pixel coordinates.
		/// </summary>
		// Token: 0x060142F0 RID: 82672 RVA: 0x001C8477 File Offset: 0x001C6677
		public virtual void SetClip(float x, float y, float width, float height)
		{
			vtkContextClip.vtkContextClip_SetClip_14(base.GetCppThis(), x, y, width, height);
		}

		// Token: 0x060142F1 RID: 82673
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextClip_Update_15(HandleRef pThis);

		/// <summary>
		/// Perform any updates to the item that may be necessary before rendering.
		/// The scene should take care of calling this on all items before their
		/// Paint function is invoked.
		/// </summary>
		// Token: 0x060142F2 RID: 82674 RVA: 0x001C848B File Offset: 0x001C668B
		public override void Update()
		{
			vtkContextClip.vtkContextClip_Update_15(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001766 RID: 5990
		public new const string MRFullTypeName = "Kitware.VTK.vtkContextClip";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001767 RID: 5991
		public new static readonly string MRClassNameKey = "class vtkContextClip";
	}
}
