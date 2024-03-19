using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCheckerboardRepresentation
	/// </summary>
	/// <remarks>
	///    represent the vtkCheckerboardWidget
	///
	/// The vtkCheckerboardRepresentation is used to implement the representation of
	/// the vtkCheckerboardWidget. The user can adjust the number of divisions in
	/// each of the i-j directions in a 2D image. A frame appears around the
	/// vtkImageActor with sliders along each side of the frame. The user can
	/// interactively adjust the sliders to the desired number of checkerboard
	/// subdivisions. The representation uses four instances of
	/// vtkSliderRepresentation3D to implement itself.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCheckerboardWidget vtkImageCheckerboard vtkImageActor vtkSliderWidget
	/// vtkRectilinearWipeWidget
	/// </seealso>
	// Token: 0x020002F4 RID: 756
	public class vtkCheckerboardRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008792 RID: 34706 RVA: 0x000C198B File Offset: 0x000BFB8B
		static vtkCheckerboardRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCheckerboardRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCheckerboardRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008793 RID: 34707 RVA: 0x000C19B3 File Offset: 0x000BFBB3
		public vtkCheckerboardRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008794 RID: 34708
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCheckerboardRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate class.
		/// </summary>
		// Token: 0x06008795 RID: 34709 RVA: 0x000C19C4 File Offset: 0x000BFBC4
		public new static vtkCheckerboardRepresentation New()
		{
			vtkCheckerboardRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCheckerboardRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate class.
		/// </summary>
		// Token: 0x06008796 RID: 34710 RVA: 0x000C1A18 File Offset: 0x000BFC18
		public vtkCheckerboardRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008797 RID: 34711 RVA: 0x000C1A5C File Offset: 0x000BFC5C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008798 RID: 34712
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Methods required by superclass.
		/// </summary>
		// Token: 0x06008799 RID: 34713 RVA: 0x000C1A67 File Offset: 0x000BFC67
		public override void BuildRepresentation()
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600879A RID: 34714
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardRepresentation_GetActors_02(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods required by superclass.
		/// </summary>
		// Token: 0x0600879B RID: 34715 RVA: 0x000C1A78 File Offset: 0x000BFC78
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetActors_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600879C RID: 34716
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCheckerboardRepresentation_GetBottomRepresentation_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set and get the instances of vtkSliderRepresentation used to implement this
		/// representation. Normally default representations are created, but you can
		/// specify the ones you want to use.
		/// </summary>
		// Token: 0x0600879D RID: 34717 RVA: 0x000C1AA8 File Offset: 0x000BFCA8
		public virtual vtkSliderRepresentation3D GetBottomRepresentation()
		{
			vtkSliderRepresentation3D vtkSliderRepresentation3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetBottomRepresentation_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSliderRepresentation3D = (vtkSliderRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSliderRepresentation3D.Register(null);
				}
			}
			return vtkSliderRepresentation3D;
		}

		// Token: 0x0600879E RID: 34718
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCheckerboardRepresentation_GetCheckerboard_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify an instance of vtkImageCheckerboard to manipulate.
		/// </summary>
		// Token: 0x0600879F RID: 34719 RVA: 0x000C1B18 File Offset: 0x000BFD18
		public virtual vtkImageCheckerboard GetCheckerboard()
		{
			vtkImageCheckerboard vtkImageCheckerboard = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetCheckerboard_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageCheckerboard = (vtkImageCheckerboard)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageCheckerboard.Register(null);
				}
			}
			return vtkImageCheckerboard;
		}

		// Token: 0x060087A0 RID: 34720
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCheckerboardRepresentation_GetCornerOffset_05(HandleRef pThis);

		/// <summary>
		/// Specify the offset of the ends of the sliders (on the boundary edges of
		/// the image) from the corner of the image. The offset is expressed as a
		/// normalized fraction of the border edges.
		/// </summary>
		// Token: 0x060087A1 RID: 34721 RVA: 0x000C1B88 File Offset: 0x000BFD88
		public virtual double GetCornerOffset()
		{
			return vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetCornerOffset_05(base.GetCppThis());
		}

		// Token: 0x060087A2 RID: 34722
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCheckerboardRepresentation_GetCornerOffsetMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Specify the offset of the ends of the sliders (on the boundary edges of
		/// the image) from the corner of the image. The offset is expressed as a
		/// normalized fraction of the border edges.
		/// </summary>
		// Token: 0x060087A3 RID: 34723 RVA: 0x000C1BA8 File Offset: 0x000BFDA8
		public virtual double GetCornerOffsetMaxValue()
		{
			return vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetCornerOffsetMaxValue_06(base.GetCppThis());
		}

		// Token: 0x060087A4 RID: 34724
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCheckerboardRepresentation_GetCornerOffsetMinValue_07(HandleRef pThis);

		/// <summary>
		/// Specify the offset of the ends of the sliders (on the boundary edges of
		/// the image) from the corner of the image. The offset is expressed as a
		/// normalized fraction of the border edges.
		/// </summary>
		// Token: 0x060087A5 RID: 34725 RVA: 0x000C1BC8 File Offset: 0x000BFDC8
		public virtual double GetCornerOffsetMinValue()
		{
			return vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetCornerOffsetMinValue_07(base.GetCppThis());
		}

		// Token: 0x060087A6 RID: 34726
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCheckerboardRepresentation_GetImageActor_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify an instance of vtkImageActor to decorate.
		/// </summary>
		// Token: 0x060087A7 RID: 34727 RVA: 0x000C1BE8 File Offset: 0x000BFDE8
		public virtual vtkImageActor GetImageActor()
		{
			vtkImageActor vtkImageActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetImageActor_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageActor = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageActor.Register(null);
				}
			}
			return vtkImageActor;
		}

		// Token: 0x060087A8 RID: 34728
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCheckerboardRepresentation_GetLeftRepresentation_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set and get the instances of vtkSliderRepresentation used to implement this
		/// representation. Normally default representations are created, but you can
		/// specify the ones you want to use.
		/// </summary>
		// Token: 0x060087A9 RID: 34729 RVA: 0x000C1C58 File Offset: 0x000BFE58
		public virtual vtkSliderRepresentation3D GetLeftRepresentation()
		{
			vtkSliderRepresentation3D vtkSliderRepresentation3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetLeftRepresentation_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSliderRepresentation3D = (vtkSliderRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSliderRepresentation3D.Register(null);
				}
			}
			return vtkSliderRepresentation3D;
		}

		// Token: 0x060087AA RID: 34730
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCheckerboardRepresentation_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x060087AB RID: 34731 RVA: 0x000C1CC8 File Offset: 0x000BFEC8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x060087AC RID: 34732
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCheckerboardRepresentation_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x060087AD RID: 34733 RVA: 0x000C1CE8 File Offset: 0x000BFEE8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x060087AE RID: 34734
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCheckerboardRepresentation_GetRightRepresentation_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set and get the instances of vtkSliderRepresentation used to implement this
		/// representation. Normally default representations are created, but you can
		/// specify the ones you want to use.
		/// </summary>
		// Token: 0x060087AF RID: 34735 RVA: 0x000C1D04 File Offset: 0x000BFF04
		public virtual vtkSliderRepresentation3D GetRightRepresentation()
		{
			vtkSliderRepresentation3D vtkSliderRepresentation3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetRightRepresentation_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSliderRepresentation3D = (vtkSliderRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSliderRepresentation3D.Register(null);
				}
			}
			return vtkSliderRepresentation3D;
		}

		// Token: 0x060087B0 RID: 34736
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCheckerboardRepresentation_GetTopRepresentation_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set and get the instances of vtkSliderRepresentation used to implement this
		/// representation. Normally default representations are created, but you can
		/// specify the ones you want to use.
		/// </summary>
		// Token: 0x060087B1 RID: 34737 RVA: 0x000C1D74 File Offset: 0x000BFF74
		public virtual vtkSliderRepresentation3D GetTopRepresentation()
		{
			vtkSliderRepresentation3D vtkSliderRepresentation3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetTopRepresentation_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSliderRepresentation3D = (vtkSliderRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSliderRepresentation3D.Register(null);
				}
			}
			return vtkSliderRepresentation3D;
		}

		// Token: 0x060087B2 RID: 34738
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardRepresentation_HasTranslucentPolygonalGeometry_14(HandleRef pThis);

		/// <summary>
		/// Methods required by superclass.
		/// </summary>
		// Token: 0x060087B3 RID: 34739 RVA: 0x000C1DE4 File Offset: 0x000BFFE4
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_HasTranslucentPolygonalGeometry_14(base.GetCppThis());
		}

		// Token: 0x060087B4 RID: 34740
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardRepresentation_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x060087B5 RID: 34741 RVA: 0x000C1E04 File Offset: 0x000C0004
		public override int IsA(string type)
		{
			return vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x060087B6 RID: 34742
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardRepresentation_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x060087B7 RID: 34743 RVA: 0x000C1E24 File Offset: 0x000C0024
		public new static int IsTypeOf(string type)
		{
			return vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_IsTypeOf_16(type);
		}

		// Token: 0x060087B8 RID: 34744
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCheckerboardRepresentation_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x060087B9 RID: 34745 RVA: 0x000C1E40 File Offset: 0x000C0040
		public new vtkCheckerboardRepresentation NewInstance()
		{
			vtkCheckerboardRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCheckerboardRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060087BA RID: 34746
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardRepresentation_ReleaseGraphicsResources_19(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Methods required by superclass.
		/// </summary>
		// Token: 0x060087BB RID: 34747 RVA: 0x000C1E9C File Offset: 0x000C009C
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_ReleaseGraphicsResources_19(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x060087BC RID: 34748
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardRepresentation_RenderOpaqueGeometry_20(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by superclass.
		/// </summary>
		// Token: 0x060087BD RID: 34749 RVA: 0x000C1ECC File Offset: 0x000C00CC
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_RenderOpaqueGeometry_20(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060087BE RID: 34750
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardRepresentation_RenderOverlay_21(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by superclass.
		/// </summary>
		// Token: 0x060087BF RID: 34751 RVA: 0x000C1F00 File Offset: 0x000C0100
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_RenderOverlay_21(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060087C0 RID: 34752
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardRepresentation_RenderTranslucentPolygonalGeometry_22(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by superclass.
		/// </summary>
		// Token: 0x060087C1 RID: 34753 RVA: 0x000C1F34 File Offset: 0x000C0134
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_RenderTranslucentPolygonalGeometry_22(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060087C2 RID: 34754
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCheckerboardRepresentation_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x060087C3 RID: 34755 RVA: 0x000C1F68 File Offset: 0x000C0168
		public new static vtkCheckerboardRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkCheckerboardRepresentation vtkCheckerboardRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCheckerboardRepresentation = (vtkCheckerboardRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCheckerboardRepresentation.Register(null);
				}
			}
			return vtkCheckerboardRepresentation;
		}

		// Token: 0x060087C4 RID: 34756
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardRepresentation_SetBottomRepresentation_24(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set and get the instances of vtkSliderRepresentation used to implement this
		/// representation. Normally default representations are created, but you can
		/// specify the ones you want to use.
		/// </summary>
		// Token: 0x060087C5 RID: 34757 RVA: 0x000C1FE8 File Offset: 0x000C01E8
		public void SetBottomRepresentation(vtkSliderRepresentation3D arg0)
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_SetBottomRepresentation_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060087C6 RID: 34758
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardRepresentation_SetCheckerboard_25(HandleRef pThis, HandleRef chkrbrd);

		/// <summary>
		/// Specify an instance of vtkImageCheckerboard to manipulate.
		/// </summary>
		// Token: 0x060087C7 RID: 34759 RVA: 0x000C2018 File Offset: 0x000C0218
		public void SetCheckerboard(vtkImageCheckerboard chkrbrd)
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_SetCheckerboard_25(base.GetCppThis(), (chkrbrd == null) ? default(HandleRef) : chkrbrd.GetCppThis());
		}

		// Token: 0x060087C8 RID: 34760
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardRepresentation_SetCornerOffset_26(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the offset of the ends of the sliders (on the boundary edges of
		/// the image) from the corner of the image. The offset is expressed as a
		/// normalized fraction of the border edges.
		/// </summary>
		// Token: 0x060087C9 RID: 34761 RVA: 0x000C2047 File Offset: 0x000C0247
		public virtual void SetCornerOffset(double _arg)
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_SetCornerOffset_26(base.GetCppThis(), _arg);
		}

		// Token: 0x060087CA RID: 34762
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardRepresentation_SetImageActor_27(HandleRef pThis, HandleRef imageActor);

		/// <summary>
		/// Specify an instance of vtkImageActor to decorate.
		/// </summary>
		// Token: 0x060087CB RID: 34763 RVA: 0x000C2058 File Offset: 0x000C0258
		public void SetImageActor(vtkImageActor imageActor)
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_SetImageActor_27(base.GetCppThis(), (imageActor == null) ? default(HandleRef) : imageActor.GetCppThis());
		}

		// Token: 0x060087CC RID: 34764
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardRepresentation_SetLeftRepresentation_28(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set and get the instances of vtkSliderRepresentation used to implement this
		/// representation. Normally default representations are created, but you can
		/// specify the ones you want to use.
		/// </summary>
		// Token: 0x060087CD RID: 34765 RVA: 0x000C2088 File Offset: 0x000C0288
		public void SetLeftRepresentation(vtkSliderRepresentation3D arg0)
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_SetLeftRepresentation_28(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060087CE RID: 34766
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardRepresentation_SetRightRepresentation_29(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set and get the instances of vtkSliderRepresentation used to implement this
		/// representation. Normally default representations are created, but you can
		/// specify the ones you want to use.
		/// </summary>
		// Token: 0x060087CF RID: 34767 RVA: 0x000C20B8 File Offset: 0x000C02B8
		public void SetRightRepresentation(vtkSliderRepresentation3D arg0)
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_SetRightRepresentation_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060087D0 RID: 34768
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardRepresentation_SetTopRepresentation_30(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set and get the instances of vtkSliderRepresentation used to implement this
		/// representation. Normally default representations are created, but you can
		/// specify the ones you want to use.
		/// </summary>
		// Token: 0x060087D1 RID: 34769 RVA: 0x000C20E8 File Offset: 0x000C02E8
		public void SetTopRepresentation(vtkSliderRepresentation3D arg0)
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_SetTopRepresentation_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060087D2 RID: 34770
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardRepresentation_SliderValueChanged_31(HandleRef pThis, int sliderNum);

		/// <summary>
		/// This method is invoked by the vtkCheckerboardWidget() when a value of some
		/// slider has changed.
		/// </summary>
		// Token: 0x060087D3 RID: 34771 RVA: 0x000C2117 File Offset: 0x000C0317
		public void SliderValueChanged(int sliderNum)
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_SliderValueChanged_31(base.GetCppThis(), sliderNum);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B6F RID: 2927
		public new const string MRFullTypeName = "Kitware.VTK.vtkCheckerboardRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B70 RID: 2928
		public new static readonly string MRClassNameKey = "class vtkCheckerboardRepresentation";

		/// <summary>
		/// Specify the offset of the ends of the sliders (on the boundary edges of
		/// the image) from the corner of the image. The offset is expressed as a
		/// normalized fraction of the border edges.
		/// </summary>
		// Token: 0x020002F5 RID: 757
		public enum BottomSlider_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000B72 RID: 2930
			BottomSlider = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000B73 RID: 2931
			LeftSlider,
			/// <summary>enum member</summary>
			// Token: 0x04000B74 RID: 2932
			RightSlider = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000B75 RID: 2933
			TopSlider = 0
		}
	}
}
