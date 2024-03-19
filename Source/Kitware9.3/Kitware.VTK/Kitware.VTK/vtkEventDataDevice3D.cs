using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <remarks>
	///    platform-independent event data structures
	/// </remarks>
	// Token: 0x0200040F RID: 1039
	public class vtkEventDataDevice3D : vtkEventDataForDevice
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C4F6 RID: 50422 RVA: 0x00111DC3 File Offset: 0x0010FFC3
		static vtkEventDataDevice3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEventDataDevice3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEventDataDevice3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C4F7 RID: 50423 RVA: 0x00111DEB File Offset: 0x0010FFEB
		public vtkEventDataDevice3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C4F8 RID: 50424
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEventDataDevice3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4F9 RID: 50425 RVA: 0x00111DFC File Offset: 0x0010FFFC
		public new static vtkEventDataDevice3D New()
		{
			vtkEventDataDevice3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEventDataDevice3D.vtkEventDataDevice3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEventDataDevice3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4FA RID: 50426 RVA: 0x00111E50 File Offset: 0x00110050
		public vtkEventDataDevice3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEventDataDevice3D.vtkEventDataDevice3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C4FB RID: 50427 RVA: 0x00111E94 File Offset: 0x00110094
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C4FC RID: 50428
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEventDataDevice3D_GetAsEventDataDevice3D_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4FD RID: 50429 RVA: 0x00111EA0 File Offset: 0x001100A0
		public override vtkEventDataDevice3D GetAsEventDataDevice3D()
		{
			vtkEventDataDevice3D vtkEventDataDevice3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEventDataDevice3D.vtkEventDataDevice3D_GetAsEventDataDevice3D_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEventDataDevice3D = (vtkEventDataDevice3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEventDataDevice3D.Register(null);
				}
			}
			return vtkEventDataDevice3D;
		}

		// Token: 0x0600C4FE RID: 50430
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEventDataDevice3D_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4FF RID: 50431 RVA: 0x00111F10 File Offset: 0x00110110
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEventDataDevice3D.vtkEventDataDevice3D_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600C500 RID: 50432
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEventDataDevice3D_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C501 RID: 50433 RVA: 0x00111F30 File Offset: 0x00110130
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEventDataDevice3D.vtkEventDataDevice3D_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600C502 RID: 50434
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEventDataDevice3D_GetTrackPadPosition_04(HandleRef pThis, IntPtr v);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C503 RID: 50435 RVA: 0x00111F4A File Offset: 0x0011014A
		public void GetTrackPadPosition(IntPtr v)
		{
			vtkEventDataDevice3D.vtkEventDataDevice3D_GetTrackPadPosition_04(base.GetCppThis(), v);
		}

		// Token: 0x0600C504 RID: 50436
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEventDataDevice3D_GetTrackPadPosition_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C505 RID: 50437 RVA: 0x00111F5C File Offset: 0x0011015C
		public IntPtr GetTrackPadPosition()
		{
			return vtkEventDataDevice3D.vtkEventDataDevice3D_GetTrackPadPosition_05(base.GetCppThis());
		}

		// Token: 0x0600C506 RID: 50438
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEventDataDevice3D_GetWorldDirection_06(HandleRef pThis, IntPtr v);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C507 RID: 50439 RVA: 0x00111F7B File Offset: 0x0011017B
		public void GetWorldDirection(IntPtr v)
		{
			vtkEventDataDevice3D.vtkEventDataDevice3D_GetWorldDirection_06(base.GetCppThis(), v);
		}

		// Token: 0x0600C508 RID: 50440
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEventDataDevice3D_GetWorldDirection_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C509 RID: 50441 RVA: 0x00111F8C File Offset: 0x0011018C
		public IntPtr GetWorldDirection()
		{
			return vtkEventDataDevice3D.vtkEventDataDevice3D_GetWorldDirection_07(base.GetCppThis());
		}

		// Token: 0x0600C50A RID: 50442
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEventDataDevice3D_GetWorldOrientation_08(HandleRef pThis, IntPtr v);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C50B RID: 50443 RVA: 0x00111FAB File Offset: 0x001101AB
		public void GetWorldOrientation(IntPtr v)
		{
			vtkEventDataDevice3D.vtkEventDataDevice3D_GetWorldOrientation_08(base.GetCppThis(), v);
		}

		// Token: 0x0600C50C RID: 50444
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEventDataDevice3D_GetWorldOrientation_09(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C50D RID: 50445 RVA: 0x00111FBC File Offset: 0x001101BC
		public IntPtr GetWorldOrientation()
		{
			return vtkEventDataDevice3D.vtkEventDataDevice3D_GetWorldOrientation_09(base.GetCppThis());
		}

		// Token: 0x0600C50E RID: 50446
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEventDataDevice3D_GetWorldPosition_10(HandleRef pThis, IntPtr v);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C50F RID: 50447 RVA: 0x00111FDB File Offset: 0x001101DB
		public void GetWorldPosition(IntPtr v)
		{
			vtkEventDataDevice3D.vtkEventDataDevice3D_GetWorldPosition_10(base.GetCppThis(), v);
		}

		// Token: 0x0600C510 RID: 50448
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEventDataDevice3D_GetWorldPosition_11(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C511 RID: 50449 RVA: 0x00111FEC File Offset: 0x001101EC
		public IntPtr GetWorldPosition()
		{
			return vtkEventDataDevice3D.vtkEventDataDevice3D_GetWorldPosition_11(base.GetCppThis());
		}

		// Token: 0x0600C512 RID: 50450
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEventDataDevice3D_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C513 RID: 50451 RVA: 0x0011200C File Offset: 0x0011020C
		public override int IsA(string type)
		{
			return vtkEventDataDevice3D.vtkEventDataDevice3D_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0600C514 RID: 50452
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEventDataDevice3D_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C515 RID: 50453 RVA: 0x0011202C File Offset: 0x0011022C
		public new static int IsTypeOf(string type)
		{
			return vtkEventDataDevice3D.vtkEventDataDevice3D_IsTypeOf_13(type);
		}

		// Token: 0x0600C516 RID: 50454
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEventDataDevice3D_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C517 RID: 50455 RVA: 0x00112048 File Offset: 0x00110248
		public new vtkEventDataDevice3D NewInstance()
		{
			vtkEventDataDevice3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEventDataDevice3D.vtkEventDataDevice3D_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEventDataDevice3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C518 RID: 50456
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEventDataDevice3D_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C519 RID: 50457 RVA: 0x001120A4 File Offset: 0x001102A4
		public new static vtkEventDataDevice3D SafeDownCast(vtkObjectBase o)
		{
			vtkEventDataDevice3D vtkEventDataDevice3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEventDataDevice3D.vtkEventDataDevice3D_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEventDataDevice3D = (vtkEventDataDevice3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEventDataDevice3D.Register(null);
				}
			}
			return vtkEventDataDevice3D;
		}

		// Token: 0x0600C51A RID: 50458
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEventDataDevice3D_SetTrackPadPosition_17(HandleRef pThis, IntPtr p);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C51B RID: 50459 RVA: 0x00112123 File Offset: 0x00110323
		public void SetTrackPadPosition(IntPtr p)
		{
			vtkEventDataDevice3D.vtkEventDataDevice3D_SetTrackPadPosition_17(base.GetCppThis(), p);
		}

		// Token: 0x0600C51C RID: 50460
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEventDataDevice3D_SetTrackPadPosition_18(HandleRef pThis, double x, double y);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C51D RID: 50461 RVA: 0x00112133 File Offset: 0x00110333
		public void SetTrackPadPosition(double x, double y)
		{
			vtkEventDataDevice3D.vtkEventDataDevice3D_SetTrackPadPosition_18(base.GetCppThis(), x, y);
		}

		// Token: 0x0600C51E RID: 50462
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEventDataDevice3D_SetWorldDirection_19(HandleRef pThis, IntPtr p);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C51F RID: 50463 RVA: 0x00112144 File Offset: 0x00110344
		public void SetWorldDirection(IntPtr p)
		{
			vtkEventDataDevice3D.vtkEventDataDevice3D_SetWorldDirection_19(base.GetCppThis(), p);
		}

		// Token: 0x0600C520 RID: 50464
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEventDataDevice3D_SetWorldOrientation_20(HandleRef pThis, IntPtr p);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C521 RID: 50465 RVA: 0x00112154 File Offset: 0x00110354
		public void SetWorldOrientation(IntPtr p)
		{
			vtkEventDataDevice3D.vtkEventDataDevice3D_SetWorldOrientation_20(base.GetCppThis(), p);
		}

		// Token: 0x0600C522 RID: 50466
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEventDataDevice3D_SetWorldPosition_21(HandleRef pThis, IntPtr p);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C523 RID: 50467 RVA: 0x00112164 File Offset: 0x00110364
		public void SetWorldPosition(IntPtr p)
		{
			vtkEventDataDevice3D.vtkEventDataDevice3D_SetWorldPosition_21(base.GetCppThis(), p);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E99 RID: 3737
		public new const string MRFullTypeName = "Kitware.VTK.vtkEventDataDevice3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E9A RID: 3738
		public new static readonly string MRClassNameKey = "class vtkEventDataDevice3D";
	}
}
