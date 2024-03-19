using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyleDrawPolygon
	/// </summary>
	/// <remarks>
	///    draw polygon during mouse move
	///
	/// This interactor style allows the user to draw a polygon in the render
	/// window using the left mouse button while mouse is moving.
	/// When the mouse button is released, a SelectionChangedEvent will be fired.
	/// </remarks>
	// Token: 0x020003F8 RID: 1016
	public class vtkInteractorStyleDrawPolygon : vtkInteractorStyle
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C1DD RID: 49629 RVA: 0x0010E24B File Offset: 0x0010C44B
		static vtkInteractorStyleDrawPolygon()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleDrawPolygon.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleDrawPolygon"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C1DE RID: 49630 RVA: 0x0010E273 File Offset: 0x0010C473
		public vtkInteractorStyleDrawPolygon(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C1DF RID: 49631
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleDrawPolygon_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1E0 RID: 49632 RVA: 0x0010E284 File Offset: 0x0010C484
		public new static vtkInteractorStyleDrawPolygon New()
		{
			vtkInteractorStyleDrawPolygon result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleDrawPolygon.vtkInteractorStyleDrawPolygon_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleDrawPolygon)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1E1 RID: 49633 RVA: 0x0010E2D8 File Offset: 0x0010C4D8
		public vtkInteractorStyleDrawPolygon() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyleDrawPolygon.vtkInteractorStyleDrawPolygon_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C1E2 RID: 49634 RVA: 0x0010E31C File Offset: 0x0010C51C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C1E3 RID: 49635
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleDrawPolygon_DrawPolygonPixelsOff_01(HandleRef pThis);

		/// <summary>
		/// Whether to draw polygon in screen pixels. Default is ON
		/// </summary>
		// Token: 0x0600C1E4 RID: 49636 RVA: 0x0010E327 File Offset: 0x0010C527
		public virtual void DrawPolygonPixelsOff()
		{
			vtkInteractorStyleDrawPolygon.vtkInteractorStyleDrawPolygon_DrawPolygonPixelsOff_01(base.GetCppThis());
		}

		// Token: 0x0600C1E5 RID: 49637
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleDrawPolygon_DrawPolygonPixelsOn_02(HandleRef pThis);

		/// <summary>
		/// Whether to draw polygon in screen pixels. Default is ON
		/// </summary>
		// Token: 0x0600C1E6 RID: 49638 RVA: 0x0010E336 File Offset: 0x0010C536
		public virtual void DrawPolygonPixelsOn()
		{
			vtkInteractorStyleDrawPolygon.vtkInteractorStyleDrawPolygon_DrawPolygonPixelsOn_02(base.GetCppThis());
		}

		// Token: 0x0600C1E7 RID: 49639
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkInteractorStyleDrawPolygon_GetDrawPolygonPixels_03(HandleRef pThis);

		/// <summary>
		/// Whether to draw polygon in screen pixels. Default is ON
		/// </summary>
		// Token: 0x0600C1E8 RID: 49640 RVA: 0x0010E348 File Offset: 0x0010C548
		public virtual bool GetDrawPolygonPixels()
		{
			return vtkInteractorStyleDrawPolygon.vtkInteractorStyleDrawPolygon_GetDrawPolygonPixels_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600C1E9 RID: 49641
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleDrawPolygon_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1EA RID: 49642 RVA: 0x0010E370 File Offset: 0x0010C570
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyleDrawPolygon.vtkInteractorStyleDrawPolygon_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600C1EB RID: 49643
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleDrawPolygon_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1EC RID: 49644 RVA: 0x0010E390 File Offset: 0x0010C590
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyleDrawPolygon.vtkInteractorStyleDrawPolygon_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600C1ED RID: 49645
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleDrawPolygon_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1EE RID: 49646 RVA: 0x0010E3AC File Offset: 0x0010C5AC
		public override int IsA(string type)
		{
			return vtkInteractorStyleDrawPolygon.vtkInteractorStyleDrawPolygon_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600C1EF RID: 49647
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleDrawPolygon_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1F0 RID: 49648 RVA: 0x0010E3CC File Offset: 0x0010C5CC
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleDrawPolygon.vtkInteractorStyleDrawPolygon_IsTypeOf_07(type);
		}

		// Token: 0x0600C1F1 RID: 49649
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleDrawPolygon_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1F2 RID: 49650 RVA: 0x0010E3E8 File Offset: 0x0010C5E8
		public new vtkInteractorStyleDrawPolygon NewInstance()
		{
			vtkInteractorStyleDrawPolygon result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleDrawPolygon.vtkInteractorStyleDrawPolygon_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleDrawPolygon)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C1F3 RID: 49651
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleDrawPolygon_OnLeftButtonDown_10(HandleRef pThis);

		/// <summary>
		/// Event bindings
		/// </summary>
		// Token: 0x0600C1F4 RID: 49652 RVA: 0x0010E442 File Offset: 0x0010C642
		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleDrawPolygon.vtkInteractorStyleDrawPolygon_OnLeftButtonDown_10(base.GetCppThis());
		}

		// Token: 0x0600C1F5 RID: 49653
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleDrawPolygon_OnLeftButtonUp_11(HandleRef pThis);

		/// <summary>
		/// Event bindings
		/// </summary>
		// Token: 0x0600C1F6 RID: 49654 RVA: 0x0010E451 File Offset: 0x0010C651
		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleDrawPolygon.vtkInteractorStyleDrawPolygon_OnLeftButtonUp_11(base.GetCppThis());
		}

		// Token: 0x0600C1F7 RID: 49655
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleDrawPolygon_OnMouseMove_12(HandleRef pThis);

		/// <summary>
		/// Event bindings
		/// </summary>
		// Token: 0x0600C1F8 RID: 49656 RVA: 0x0010E460 File Offset: 0x0010C660
		public override void OnMouseMove()
		{
			vtkInteractorStyleDrawPolygon.vtkInteractorStyleDrawPolygon_OnMouseMove_12(base.GetCppThis());
		}

		// Token: 0x0600C1F9 RID: 49657
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleDrawPolygon_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1FA RID: 49658 RVA: 0x0010E470 File Offset: 0x0010C670
		public new static vtkInteractorStyleDrawPolygon SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleDrawPolygon vtkInteractorStyleDrawPolygon = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleDrawPolygon.vtkInteractorStyleDrawPolygon_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleDrawPolygon = (vtkInteractorStyleDrawPolygon)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleDrawPolygon.Register(null);
				}
			}
			return vtkInteractorStyleDrawPolygon;
		}

		// Token: 0x0600C1FB RID: 49659
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleDrawPolygon_SetDrawPolygonPixels_14(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to draw polygon in screen pixels. Default is ON
		/// </summary>
		// Token: 0x0600C1FC RID: 49660 RVA: 0x0010E4EF File Offset: 0x0010C6EF
		public virtual void SetDrawPolygonPixels(bool _arg)
		{
			vtkInteractorStyleDrawPolygon.vtkInteractorStyleDrawPolygon_SetDrawPolygonPixels_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E5D RID: 3677
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleDrawPolygon";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E5E RID: 3678
		public new static readonly string MRClassNameKey = "class vtkInteractorStyleDrawPolygon";
	}
}
