using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLogoRepresentation
	/// </summary>
	/// <remarks>
	///    represent the vtkLogoWidget
	///
	///
	/// This class provides support for interactively positioning a logo. A logo
	/// is defined by an instance of vtkImage. The properties of the image,
	/// including transparency, can be set with an instance of vtkProperty2D. To
	/// position the logo, use the superclass's Position and Position2 coordinates.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLogoWidget
	/// </seealso>
	// Token: 0x0200033B RID: 827
	public class vtkLogoRepresentation : vtkBorderRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009629 RID: 38441 RVA: 0x000D4AB3 File Offset: 0x000D2CB3
		static vtkLogoRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLogoRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLogoRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600962A RID: 38442 RVA: 0x000D4ADB File Offset: 0x000D2CDB
		public vtkLogoRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600962B RID: 38443
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLogoRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600962C RID: 38444 RVA: 0x000D4AEC File Offset: 0x000D2CEC
		public new static vtkLogoRepresentation New()
		{
			vtkLogoRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLogoRepresentation.vtkLogoRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLogoRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600962D RID: 38445 RVA: 0x000D4B40 File Offset: 0x000D2D40
		public vtkLogoRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLogoRepresentation.vtkLogoRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600962E RID: 38446 RVA: 0x000D4B84 File Offset: 0x000D2D84
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600962F RID: 38447
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLogoRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Satisfy the superclasses' API.
		/// </summary>
		// Token: 0x06009630 RID: 38448 RVA: 0x000D4B8F File Offset: 0x000D2D8F
		public override void BuildRepresentation()
		{
			vtkLogoRepresentation.vtkLogoRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009631 RID: 38449
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLogoRepresentation_GetActors2D_02(HandleRef pThis, HandleRef pc);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06009632 RID: 38450 RVA: 0x000D4BA0 File Offset: 0x000D2DA0
		public override void GetActors2D(vtkPropCollection pc)
		{
			vtkLogoRepresentation.vtkLogoRepresentation_GetActors2D_02(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		// Token: 0x06009633 RID: 38451
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLogoRepresentation_GetImage_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify/retrieve the image to display in the balloon.
		/// </summary>
		// Token: 0x06009634 RID: 38452 RVA: 0x000D4BD0 File Offset: 0x000D2DD0
		public virtual vtkImageData GetImage()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLogoRepresentation.vtkLogoRepresentation_GetImage_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x06009635 RID: 38453
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLogoRepresentation_GetImageProperty_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the image property (relevant only if an image is shown).
		/// </summary>
		// Token: 0x06009636 RID: 38454 RVA: 0x000D4C40 File Offset: 0x000D2E40
		public virtual vtkProperty2D GetImageProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLogoRepresentation.vtkLogoRepresentation_GetImageProperty_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		// Token: 0x06009637 RID: 38455
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLogoRepresentation_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009638 RID: 38456 RVA: 0x000D4CB0 File Offset: 0x000D2EB0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLogoRepresentation.vtkLogoRepresentation_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06009639 RID: 38457
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLogoRepresentation_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x0600963A RID: 38458 RVA: 0x000D4CD0 File Offset: 0x000D2ED0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLogoRepresentation.vtkLogoRepresentation_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600963B RID: 38459
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLogoRepresentation_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x0600963C RID: 38460 RVA: 0x000D4CEC File Offset: 0x000D2EEC
		public override int IsA(string type)
		{
			return vtkLogoRepresentation.vtkLogoRepresentation_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600963D RID: 38461
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLogoRepresentation_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x0600963E RID: 38462 RVA: 0x000D4D0C File Offset: 0x000D2F0C
		public new static int IsTypeOf(string type)
		{
			return vtkLogoRepresentation.vtkLogoRepresentation_IsTypeOf_08(type);
		}

		// Token: 0x0600963F RID: 38463
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLogoRepresentation_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009640 RID: 38464 RVA: 0x000D4D28 File Offset: 0x000D2F28
		public new vtkLogoRepresentation NewInstance()
		{
			vtkLogoRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLogoRepresentation.vtkLogoRepresentation_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLogoRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009641 RID: 38465
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLogoRepresentation_ReleaseGraphicsResources_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06009642 RID: 38466 RVA: 0x000D4D84 File Offset: 0x000D2F84
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLogoRepresentation.vtkLogoRepresentation_ReleaseGraphicsResources_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009643 RID: 38467
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLogoRepresentation_RenderOverlay_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06009644 RID: 38468 RVA: 0x000D4DB4 File Offset: 0x000D2FB4
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkLogoRepresentation.vtkLogoRepresentation_RenderOverlay_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009645 RID: 38469
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLogoRepresentation_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009646 RID: 38470 RVA: 0x000D4DE8 File Offset: 0x000D2FE8
		public new static vtkLogoRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkLogoRepresentation vtkLogoRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLogoRepresentation.vtkLogoRepresentation_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLogoRepresentation = (vtkLogoRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLogoRepresentation.Register(null);
				}
			}
			return vtkLogoRepresentation;
		}

		// Token: 0x06009647 RID: 38471
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLogoRepresentation_SetImage_14(HandleRef pThis, HandleRef img);

		/// <summary>
		/// Specify/retrieve the image to display in the balloon.
		/// </summary>
		// Token: 0x06009648 RID: 38472 RVA: 0x000D4E68 File Offset: 0x000D3068
		public virtual void SetImage(vtkImageData img)
		{
			vtkLogoRepresentation.vtkLogoRepresentation_SetImage_14(base.GetCppThis(), (img == null) ? default(HandleRef) : img.GetCppThis());
		}

		// Token: 0x06009649 RID: 38473
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLogoRepresentation_SetImageProperty_15(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/get the image property (relevant only if an image is shown).
		/// </summary>
		// Token: 0x0600964A RID: 38474 RVA: 0x000D4E98 File Offset: 0x000D3098
		public virtual void SetImageProperty(vtkProperty2D p)
		{
			vtkLogoRepresentation.vtkLogoRepresentation_SetImageProperty_15(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C52 RID: 3154
		public new const string MRFullTypeName = "Kitware.VTK.vtkLogoRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C53 RID: 3155
		public new static readonly string MRClassNameKey = "class vtkLogoRepresentation";
	}
}
