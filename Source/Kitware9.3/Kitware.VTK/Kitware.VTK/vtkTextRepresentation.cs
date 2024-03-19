using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTextRepresentation
	/// </summary>
	/// <remarks>
	///    represent text for vtkTextWidget
	///
	/// This class represents text for a vtkTextWidget.  This class provides
	/// support for interactively placing text on the 2D overlay plane. The text
	/// is defined by an instance of vtkTextActor.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTextRepresentation vtkBorderWidget vtkAbstractWidget vtkWidgetRepresentation
	/// </seealso>
	// Token: 0x02000386 RID: 902
	public class vtkTextRepresentation : vtkBorderRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A45D RID: 42077 RVA: 0x000E8FE5 File Offset: 0x000E71E5
		static vtkTextRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A45E RID: 42078 RVA: 0x000E900D File Offset: 0x000E720D
		public vtkTextRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A45F RID: 42079
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate class.
		/// </summary>
		// Token: 0x0600A460 RID: 42080 RVA: 0x000E901C File Offset: 0x000E721C
		public new static vtkTextRepresentation New()
		{
			vtkTextRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextRepresentation.vtkTextRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate class.
		/// </summary>
		// Token: 0x0600A461 RID: 42081 RVA: 0x000E9070 File Offset: 0x000E7270
		public vtkTextRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTextRepresentation.vtkTextRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A462 RID: 42082 RVA: 0x000E90B4 File Offset: 0x000E72B4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A463 RID: 42083
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Satisfy the superclasses API.
		/// </summary>
		// Token: 0x0600A464 RID: 42084 RVA: 0x000E90BF File Offset: 0x000E72BF
		public override void BuildRepresentation()
		{
			vtkTextRepresentation.vtkTextRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600A465 RID: 42085
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextRepresentation_ExecuteTextActorModifiedEvent_02(HandleRef pThis, HandleRef obj, uint enumEvent, IntPtr p);

		/// <summary>
		/// Internal. Execute events observed by internal observer
		/// </summary>
		// Token: 0x0600A466 RID: 42086 RVA: 0x000E90D0 File Offset: 0x000E72D0
		public void ExecuteTextActorModifiedEvent(vtkObject obj, uint enumEvent, IntPtr p)
		{
			vtkTextRepresentation.vtkTextRepresentation_ExecuteTextActorModifiedEvent_02(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis(), enumEvent, p);
		}

		// Token: 0x0600A467 RID: 42087
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextRepresentation_ExecuteTextPropertyModifiedEvent_03(HandleRef pThis, HandleRef obj, uint enumEvent, IntPtr p);

		/// <summary>
		/// Internal. Execute events observed by internal observer
		/// </summary>
		// Token: 0x0600A468 RID: 42088 RVA: 0x000E9104 File Offset: 0x000E7304
		public void ExecuteTextPropertyModifiedEvent(vtkObject obj, uint enumEvent, IntPtr p)
		{
			vtkTextRepresentation.vtkTextRepresentation_ExecuteTextPropertyModifiedEvent_03(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis(), enumEvent, p);
		}

		// Token: 0x0600A469 RID: 42089
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextRepresentation_GetActors2D_04(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x0600A46A RID: 42090 RVA: 0x000E9138 File Offset: 0x000E7338
		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkTextRepresentation.vtkTextRepresentation_GetActors2D_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A46B RID: 42091
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextRepresentation_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600A46C RID: 42092 RVA: 0x000E9168 File Offset: 0x000E7368
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTextRepresentation.vtkTextRepresentation_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600A46D RID: 42093
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextRepresentation_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600A46E RID: 42094 RVA: 0x000E9188 File Offset: 0x000E7388
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTextRepresentation.vtkTextRepresentation_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600A46F RID: 42095
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRepresentation_GetPaddingBottom_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding between the text and the bottom border,
		/// in pixels unit.
		/// Default is 0.
		/// </summary>
		// Token: 0x0600A470 RID: 42096 RVA: 0x000E91A4 File Offset: 0x000E73A4
		public virtual int GetPaddingBottom()
		{
			return vtkTextRepresentation.vtkTextRepresentation_GetPaddingBottom_07(base.GetCppThis());
		}

		// Token: 0x0600A471 RID: 42097
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRepresentation_GetPaddingBottomMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding between the text and the bottom border,
		/// in pixels unit.
		/// Default is 0.
		/// </summary>
		// Token: 0x0600A472 RID: 42098 RVA: 0x000E91C4 File Offset: 0x000E73C4
		public virtual int GetPaddingBottomMaxValue()
		{
			return vtkTextRepresentation.vtkTextRepresentation_GetPaddingBottomMaxValue_08(base.GetCppThis());
		}

		// Token: 0x0600A473 RID: 42099
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRepresentation_GetPaddingBottomMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding between the text and the bottom border,
		/// in pixels unit.
		/// Default is 0.
		/// </summary>
		// Token: 0x0600A474 RID: 42100 RVA: 0x000E91E4 File Offset: 0x000E73E4
		public virtual int GetPaddingBottomMinValue()
		{
			return vtkTextRepresentation.vtkTextRepresentation_GetPaddingBottomMinValue_09(base.GetCppThis());
		}

		// Token: 0x0600A475 RID: 42101
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRepresentation_GetPaddingLeft_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding between the text and the left border,
		/// in pixels unit.
		/// Default is 0.
		/// </summary>
		// Token: 0x0600A476 RID: 42102 RVA: 0x000E9204 File Offset: 0x000E7404
		public virtual int GetPaddingLeft()
		{
			return vtkTextRepresentation.vtkTextRepresentation_GetPaddingLeft_10(base.GetCppThis());
		}

		// Token: 0x0600A477 RID: 42103
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRepresentation_GetPaddingLeftMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding between the text and the left border,
		/// in pixels unit.
		/// Default is 0.
		/// </summary>
		// Token: 0x0600A478 RID: 42104 RVA: 0x000E9224 File Offset: 0x000E7424
		public virtual int GetPaddingLeftMaxValue()
		{
			return vtkTextRepresentation.vtkTextRepresentation_GetPaddingLeftMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0600A479 RID: 42105
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRepresentation_GetPaddingLeftMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding between the text and the left border,
		/// in pixels unit.
		/// Default is 0.
		/// </summary>
		// Token: 0x0600A47A RID: 42106 RVA: 0x000E9244 File Offset: 0x000E7444
		public virtual int GetPaddingLeftMinValue()
		{
			return vtkTextRepresentation.vtkTextRepresentation_GetPaddingLeftMinValue_12(base.GetCppThis());
		}

		// Token: 0x0600A47B RID: 42107
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRepresentation_GetPaddingRight_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding between the text and the right border,
		/// in pixels unit.
		/// Default is 0.
		/// </summary>
		// Token: 0x0600A47C RID: 42108 RVA: 0x000E9264 File Offset: 0x000E7464
		public virtual int GetPaddingRight()
		{
			return vtkTextRepresentation.vtkTextRepresentation_GetPaddingRight_13(base.GetCppThis());
		}

		// Token: 0x0600A47D RID: 42109
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRepresentation_GetPaddingRightMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding between the text and the right border,
		/// in pixels unit.
		/// Default is 0.
		/// </summary>
		// Token: 0x0600A47E RID: 42110 RVA: 0x000E9284 File Offset: 0x000E7484
		public virtual int GetPaddingRightMaxValue()
		{
			return vtkTextRepresentation.vtkTextRepresentation_GetPaddingRightMaxValue_14(base.GetCppThis());
		}

		// Token: 0x0600A47F RID: 42111
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRepresentation_GetPaddingRightMinValue_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding between the text and the right border,
		/// in pixels unit.
		/// Default is 0.
		/// </summary>
		// Token: 0x0600A480 RID: 42112 RVA: 0x000E92A4 File Offset: 0x000E74A4
		public virtual int GetPaddingRightMinValue()
		{
			return vtkTextRepresentation.vtkTextRepresentation_GetPaddingRightMinValue_15(base.GetCppThis());
		}

		// Token: 0x0600A481 RID: 42113
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRepresentation_GetPaddingTop_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding between the text and the top border,
		/// in pixels unit.
		/// Default is 0.
		/// </summary>
		// Token: 0x0600A482 RID: 42114 RVA: 0x000E92C4 File Offset: 0x000E74C4
		public virtual int GetPaddingTop()
		{
			return vtkTextRepresentation.vtkTextRepresentation_GetPaddingTop_16(base.GetCppThis());
		}

		// Token: 0x0600A483 RID: 42115
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRepresentation_GetPaddingTopMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding between the text and the top border,
		/// in pixels unit.
		/// Default is 0.
		/// </summary>
		// Token: 0x0600A484 RID: 42116 RVA: 0x000E92E4 File Offset: 0x000E74E4
		public virtual int GetPaddingTopMaxValue()
		{
			return vtkTextRepresentation.vtkTextRepresentation_GetPaddingTopMaxValue_17(base.GetCppThis());
		}

		// Token: 0x0600A485 RID: 42117
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRepresentation_GetPaddingTopMinValue_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding between the text and the top border,
		/// in pixels unit.
		/// Default is 0.
		/// </summary>
		// Token: 0x0600A486 RID: 42118 RVA: 0x000E9304 File Offset: 0x000E7504
		public virtual int GetPaddingTopMinValue()
		{
			return vtkTextRepresentation.vtkTextRepresentation_GetPaddingTopMinValue_18(base.GetCppThis());
		}

		// Token: 0x0600A487 RID: 42119
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextRepresentation_GetSize_19(HandleRef pThis, IntPtr size);

		/// <summary>
		/// Satisfy the superclasses API.
		/// </summary>
		// Token: 0x0600A488 RID: 42120 RVA: 0x000E9323 File Offset: 0x000E7523
		public override void GetSize(IntPtr size)
		{
			vtkTextRepresentation.vtkTextRepresentation_GetSize_19(base.GetCppThis(), size);
		}

		// Token: 0x0600A489 RID: 42121
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextRepresentation_GetText_20(HandleRef pThis);

		/// <summary>
		/// Get/Set the text string display by this representation.
		/// </summary>
		// Token: 0x0600A48A RID: 42122 RVA: 0x000E9334 File Offset: 0x000E7534
		public string GetText()
		{
			string s = Marshal.PtrToStringAnsi(vtkTextRepresentation.vtkTextRepresentation_GetText_20(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600A48B RID: 42123
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextRepresentation_GetTextActor_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the vtkTextActor to manage. If not specified, then one
		/// is automatically created.
		/// </summary>
		// Token: 0x0600A48C RID: 42124 RVA: 0x000E9370 File Offset: 0x000E7570
		public virtual vtkTextActor GetTextActor()
		{
			vtkTextActor vtkTextActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextRepresentation.vtkTextRepresentation_GetTextActor_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextActor = (vtkTextActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextActor.Register(null);
				}
			}
			return vtkTextActor;
		}

		// Token: 0x0600A48D RID: 42125
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRepresentation_HasTranslucentPolygonalGeometry_22(HandleRef pThis);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x0600A48E RID: 42126 RVA: 0x000E93E0 File Offset: 0x000E75E0
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkTextRepresentation.vtkTextRepresentation_HasTranslucentPolygonalGeometry_22(base.GetCppThis());
		}

		// Token: 0x0600A48F RID: 42127
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRepresentation_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600A490 RID: 42128 RVA: 0x000E9400 File Offset: 0x000E7600
		public override int IsA(string type)
		{
			return vtkTextRepresentation.vtkTextRepresentation_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x0600A491 RID: 42129
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRepresentation_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600A492 RID: 42130 RVA: 0x000E9420 File Offset: 0x000E7620
		public new static int IsTypeOf(string type)
		{
			return vtkTextRepresentation.vtkTextRepresentation_IsTypeOf_24(type);
		}

		// Token: 0x0600A493 RID: 42131
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextRepresentation_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600A494 RID: 42132 RVA: 0x000E943C File Offset: 0x000E763C
		public new vtkTextRepresentation NewInstance()
		{
			vtkTextRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextRepresentation.vtkTextRepresentation_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A495 RID: 42133
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextRepresentation_ReleaseGraphicsResources_27(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x0600A496 RID: 42134 RVA: 0x000E9498 File Offset: 0x000E7698
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkTextRepresentation.vtkTextRepresentation_ReleaseGraphicsResources_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A497 RID: 42135
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRepresentation_RenderOpaqueGeometry_28(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x0600A498 RID: 42136 RVA: 0x000E94C8 File Offset: 0x000E76C8
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkTextRepresentation.vtkTextRepresentation_RenderOpaqueGeometry_28(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A499 RID: 42137
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRepresentation_RenderOverlay_29(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x0600A49A RID: 42138 RVA: 0x000E94FC File Offset: 0x000E76FC
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkTextRepresentation.vtkTextRepresentation_RenderOverlay_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A49B RID: 42139
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRepresentation_RenderTranslucentPolygonalGeometry_30(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x0600A49C RID: 42140 RVA: 0x000E9530 File Offset: 0x000E7730
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkTextRepresentation.vtkTextRepresentation_RenderTranslucentPolygonalGeometry_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A49D RID: 42141
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextRepresentation_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600A49E RID: 42142 RVA: 0x000E9564 File Offset: 0x000E7764
		public new static vtkTextRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkTextRepresentation vtkTextRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextRepresentation.vtkTextRepresentation_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextRepresentation = (vtkTextRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextRepresentation.Register(null);
				}
			}
			return vtkTextRepresentation;
		}

		// Token: 0x0600A49F RID: 42143
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextRepresentation_SetPadding_32(HandleRef pThis, int padding);

		/// <summary>
		/// Set the padding between the text and the left/right/top/bottom
		/// border, in pixels unit.
		/// Default is 0.
		/// </summary>
		// Token: 0x0600A4A0 RID: 42144 RVA: 0x000E95E3 File Offset: 0x000E77E3
		public void SetPadding(int padding)
		{
			vtkTextRepresentation.vtkTextRepresentation_SetPadding_32(base.GetCppThis(), padding);
		}

		// Token: 0x0600A4A1 RID: 42145
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextRepresentation_SetPaddingBottom_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the padding between the text and the bottom border,
		/// in pixels unit.
		/// Default is 0.
		/// </summary>
		// Token: 0x0600A4A2 RID: 42146 RVA: 0x000E95F3 File Offset: 0x000E77F3
		public virtual void SetPaddingBottom(int _arg)
		{
			vtkTextRepresentation.vtkTextRepresentation_SetPaddingBottom_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A4A3 RID: 42147
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextRepresentation_SetPaddingLeft_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the padding between the text and the left border,
		/// in pixels unit.
		/// Default is 0.
		/// </summary>
		// Token: 0x0600A4A4 RID: 42148 RVA: 0x000E9603 File Offset: 0x000E7803
		public virtual void SetPaddingLeft(int _arg)
		{
			vtkTextRepresentation.vtkTextRepresentation_SetPaddingLeft_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A4A5 RID: 42149
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextRepresentation_SetPaddingRight_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the padding between the text and the right border,
		/// in pixels unit.
		/// Default is 0.
		/// </summary>
		// Token: 0x0600A4A6 RID: 42150 RVA: 0x000E9613 File Offset: 0x000E7813
		public virtual void SetPaddingRight(int _arg)
		{
			vtkTextRepresentation.vtkTextRepresentation_SetPaddingRight_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A4A7 RID: 42151
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextRepresentation_SetPaddingTop_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the padding between the text and the top border,
		/// in pixels unit.
		/// Default is 0.
		/// </summary>
		// Token: 0x0600A4A8 RID: 42152 RVA: 0x000E9623 File Offset: 0x000E7823
		public virtual void SetPaddingTop(int _arg)
		{
			vtkTextRepresentation.vtkTextRepresentation_SetPaddingTop_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A4A9 RID: 42153
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextRepresentation_SetPosition_37(HandleRef pThis, double x, double y);

		/// <summary>
		/// Set the text position, by overriding the same function of
		/// vtkBorderRepresentation so that the Modified() will be called.
		/// </summary>
		// Token: 0x0600A4AA RID: 42154 RVA: 0x000E9633 File Offset: 0x000E7833
		public override void SetPosition(double x, double y)
		{
			vtkTextRepresentation.vtkTextRepresentation_SetPosition_37(base.GetCppThis(), x, y);
		}

		// Token: 0x0600A4AB RID: 42155
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextRepresentation_SetPosition_38(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Set the text position, by overriding the same function of
		/// vtkBorderRepresentation so that the Modified() will be called.
		/// </summary>
		// Token: 0x0600A4AC RID: 42156 RVA: 0x000E9644 File Offset: 0x000E7844
		public override void SetPosition(IntPtr pos)
		{
			vtkTextRepresentation.vtkTextRepresentation_SetPosition_38(base.GetCppThis(), pos);
		}

		// Token: 0x0600A4AD RID: 42157
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextRepresentation_SetText_39(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string text);

		/// <summary>
		/// Get/Set the text string display by this representation.
		/// </summary>
		// Token: 0x0600A4AE RID: 42158 RVA: 0x000E9654 File Offset: 0x000E7854
		public void SetText(string text)
		{
			vtkTextRepresentation.vtkTextRepresentation_SetText_39(base.GetCppThis(), text);
		}

		// Token: 0x0600A4AF RID: 42159
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextRepresentation_SetTextActor_40(HandleRef pThis, HandleRef textActor);

		/// <summary>
		/// Specify the vtkTextActor to manage. If not specified, then one
		/// is automatically created.
		/// </summary>
		// Token: 0x0600A4B0 RID: 42160 RVA: 0x000E9664 File Offset: 0x000E7864
		public void SetTextActor(vtkTextActor textActor)
		{
			vtkTextRepresentation.vtkTextRepresentation_SetTextActor_40(base.GetCppThis(), (textActor == null) ? default(HandleRef) : textActor.GetCppThis());
		}

		// Token: 0x0600A4B1 RID: 42161
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextRepresentation_SetWindowLocation_41(HandleRef pThis, int enumLocation);

		/// <summary>
		/// Set the text position, by enumeration (
		/// vtkBorderRepresentation::AnyLocation = 0,
		/// vtkBorderRepresentation::LowerLeftCorner,
		/// vtkBorderRepresentation::LowerRightCorner,
		/// vtkBorderRepresentation::LowerCenter,
		/// vtkBorderRepresentation::UpperLeftCorner,
		/// vtkBorderRepresentation::UpperRightCorner,
		/// vtkBorderRepresentation::UpperCenter)
		/// related to the render window
		/// </summary>
		// Token: 0x0600A4B2 RID: 42162 RVA: 0x000E9693 File Offset: 0x000E7893
		public override void SetWindowLocation(int enumLocation)
		{
			vtkTextRepresentation.vtkTextRepresentation_SetWindowLocation_41(base.GetCppThis(), enumLocation);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D23 RID: 3363
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D24 RID: 3364
		public new static readonly string MRClassNameKey = "class vtkTextRepresentation";
	}
}
