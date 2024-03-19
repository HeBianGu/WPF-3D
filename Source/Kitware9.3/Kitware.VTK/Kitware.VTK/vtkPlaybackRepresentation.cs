using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlaybackRepresentation
	/// </summary>
	/// <remarks>
	///    represent the vtkPlaybackWidget
	///
	/// This class is used to represent the vtkPlaybackWidget. Besides defining
	/// geometry, this class defines a series of virtual method stubs that are
	/// meant to be subclassed by applications for controlling playback.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPlaybackWidget
	/// </seealso>
	// Token: 0x0200034D RID: 845
	public class vtkPlaybackRepresentation : vtkBorderRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060099CD RID: 39373 RVA: 0x000D9F5E File Offset: 0x000D815E
		static vtkPlaybackRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlaybackRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlaybackRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060099CE RID: 39374 RVA: 0x000D9F86 File Offset: 0x000D8186
		public vtkPlaybackRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060099CF RID: 39375
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaybackRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x060099D0 RID: 39376 RVA: 0x000D9F94 File Offset: 0x000D8194
		public new static vtkPlaybackRepresentation New()
		{
			vtkPlaybackRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaybackRepresentation.vtkPlaybackRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlaybackRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x060099D1 RID: 39377 RVA: 0x000D9FE8 File Offset: 0x000D81E8
		public vtkPlaybackRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlaybackRepresentation.vtkPlaybackRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060099D2 RID: 39378 RVA: 0x000DA02C File Offset: 0x000D822C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060099D3 RID: 39379
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaybackRepresentation_BackwardOneFrame_01(HandleRef pThis);

		/// <summary>
		/// Virtual callbacks that subclasses should implement.
		/// </summary>
		// Token: 0x060099D4 RID: 39380 RVA: 0x000DA037 File Offset: 0x000D8237
		public virtual void BackwardOneFrame()
		{
			vtkPlaybackRepresentation.vtkPlaybackRepresentation_BackwardOneFrame_01(base.GetCppThis());
		}

		// Token: 0x060099D5 RID: 39381
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaybackRepresentation_BuildRepresentation_02(HandleRef pThis);

		/// <summary>
		/// Satisfy the superclasses' API.
		/// </summary>
		// Token: 0x060099D6 RID: 39382 RVA: 0x000DA046 File Offset: 0x000D8246
		public override void BuildRepresentation()
		{
			vtkPlaybackRepresentation.vtkPlaybackRepresentation_BuildRepresentation_02(base.GetCppThis());
		}

		// Token: 0x060099D7 RID: 39383
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaybackRepresentation_ForwardOneFrame_03(HandleRef pThis);

		/// <summary>
		/// Virtual callbacks that subclasses should implement.
		/// </summary>
		// Token: 0x060099D8 RID: 39384 RVA: 0x000DA055 File Offset: 0x000D8255
		public virtual void ForwardOneFrame()
		{
			vtkPlaybackRepresentation.vtkPlaybackRepresentation_ForwardOneFrame_03(base.GetCppThis());
		}

		// Token: 0x060099D9 RID: 39385
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaybackRepresentation_GetActors2D_04(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x060099DA RID: 39386 RVA: 0x000DA064 File Offset: 0x000D8264
		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkPlaybackRepresentation.vtkPlaybackRepresentation_GetActors2D_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060099DB RID: 39387
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlaybackRepresentation_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x060099DC RID: 39388 RVA: 0x000DA094 File Offset: 0x000D8294
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlaybackRepresentation.vtkPlaybackRepresentation_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060099DD RID: 39389
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlaybackRepresentation_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x060099DE RID: 39390 RVA: 0x000DA0B4 File Offset: 0x000D82B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlaybackRepresentation.vtkPlaybackRepresentation_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060099DF RID: 39391
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaybackRepresentation_GetProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// By obtaining this property you can specify the properties of the
		/// representation.
		/// </summary>
		// Token: 0x060099E0 RID: 39392 RVA: 0x000DA0D0 File Offset: 0x000D82D0
		public virtual vtkProperty2D GetProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaybackRepresentation.vtkPlaybackRepresentation_GetProperty_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060099E1 RID: 39393
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaybackRepresentation_GetSize_08(HandleRef pThis, IntPtr size);

		/// <summary>
		/// Satisfy the superclasses' API.
		/// </summary>
		// Token: 0x060099E2 RID: 39394 RVA: 0x000DA13F File Offset: 0x000D833F
		public override void GetSize(IntPtr size)
		{
			vtkPlaybackRepresentation.vtkPlaybackRepresentation_GetSize_08(base.GetCppThis(), size);
		}

		// Token: 0x060099E3 RID: 39395
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaybackRepresentation_HasTranslucentPolygonalGeometry_09(HandleRef pThis);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x060099E4 RID: 39396 RVA: 0x000DA150 File Offset: 0x000D8350
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkPlaybackRepresentation.vtkPlaybackRepresentation_HasTranslucentPolygonalGeometry_09(base.GetCppThis());
		}

		// Token: 0x060099E5 RID: 39397
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaybackRepresentation_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x060099E6 RID: 39398 RVA: 0x000DA170 File Offset: 0x000D8370
		public override int IsA(string type)
		{
			return vtkPlaybackRepresentation.vtkPlaybackRepresentation_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x060099E7 RID: 39399
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaybackRepresentation_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x060099E8 RID: 39400 RVA: 0x000DA190 File Offset: 0x000D8390
		public new static int IsTypeOf(string type)
		{
			return vtkPlaybackRepresentation.vtkPlaybackRepresentation_IsTypeOf_11(type);
		}

		// Token: 0x060099E9 RID: 39401
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaybackRepresentation_JumpToBeginning_12(HandleRef pThis);

		/// <summary>
		/// Virtual callbacks that subclasses should implement.
		/// </summary>
		// Token: 0x060099EA RID: 39402 RVA: 0x000DA1AA File Offset: 0x000D83AA
		public virtual void JumpToBeginning()
		{
			vtkPlaybackRepresentation.vtkPlaybackRepresentation_JumpToBeginning_12(base.GetCppThis());
		}

		// Token: 0x060099EB RID: 39403
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaybackRepresentation_JumpToEnd_13(HandleRef pThis);

		/// <summary>
		/// Virtual callbacks that subclasses should implement.
		/// </summary>
		// Token: 0x060099EC RID: 39404 RVA: 0x000DA1B9 File Offset: 0x000D83B9
		public virtual void JumpToEnd()
		{
			vtkPlaybackRepresentation.vtkPlaybackRepresentation_JumpToEnd_13(base.GetCppThis());
		}

		// Token: 0x060099ED RID: 39405
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaybackRepresentation_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x060099EE RID: 39406 RVA: 0x000DA1C8 File Offset: 0x000D83C8
		public new vtkPlaybackRepresentation NewInstance()
		{
			vtkPlaybackRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaybackRepresentation.vtkPlaybackRepresentation_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlaybackRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060099EF RID: 39407
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaybackRepresentation_Play_16(HandleRef pThis);

		/// <summary>
		/// Virtual callbacks that subclasses should implement.
		/// </summary>
		// Token: 0x060099F0 RID: 39408 RVA: 0x000DA222 File Offset: 0x000D8422
		public virtual void Play()
		{
			vtkPlaybackRepresentation.vtkPlaybackRepresentation_Play_16(base.GetCppThis());
		}

		// Token: 0x060099F1 RID: 39409
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaybackRepresentation_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x060099F2 RID: 39410 RVA: 0x000DA234 File Offset: 0x000D8434
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkPlaybackRepresentation.vtkPlaybackRepresentation_ReleaseGraphicsResources_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060099F3 RID: 39411
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaybackRepresentation_RenderOpaqueGeometry_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x060099F4 RID: 39412 RVA: 0x000DA264 File Offset: 0x000D8464
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkPlaybackRepresentation.vtkPlaybackRepresentation_RenderOpaqueGeometry_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060099F5 RID: 39413
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaybackRepresentation_RenderOverlay_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x060099F6 RID: 39414 RVA: 0x000DA298 File Offset: 0x000D8498
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkPlaybackRepresentation.vtkPlaybackRepresentation_RenderOverlay_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060099F7 RID: 39415
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaybackRepresentation_RenderTranslucentPolygonalGeometry_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x060099F8 RID: 39416 RVA: 0x000DA2CC File Offset: 0x000D84CC
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkPlaybackRepresentation.vtkPlaybackRepresentation_RenderTranslucentPolygonalGeometry_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060099F9 RID: 39417
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaybackRepresentation_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x060099FA RID: 39418 RVA: 0x000DA300 File Offset: 0x000D8500
		public new static vtkPlaybackRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkPlaybackRepresentation vtkPlaybackRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaybackRepresentation.vtkPlaybackRepresentation_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaybackRepresentation = (vtkPlaybackRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaybackRepresentation.Register(null);
				}
			}
			return vtkPlaybackRepresentation;
		}

		// Token: 0x060099FB RID: 39419
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaybackRepresentation_Stop_22(HandleRef pThis);

		/// <summary>
		/// Virtual callbacks that subclasses should implement.
		/// </summary>
		// Token: 0x060099FC RID: 39420 RVA: 0x000DA37F File Offset: 0x000D857F
		public virtual void Stop()
		{
			vtkPlaybackRepresentation.vtkPlaybackRepresentation_Stop_22(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C89 RID: 3209
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlaybackRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C8A RID: 3210
		public new static readonly string MRClassNameKey = "class vtkPlaybackRepresentation";
	}
}
