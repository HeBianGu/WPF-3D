using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageCroppingRegionsWidget
	/// </summary>
	/// <remarks>
	///    widget for cropping an image
	///
	/// This widget displays a set of axis aligned lines that can be interactively
	/// manipulated to crop a volume. The region to be cropped away is displayed
	/// in a different highlight. Much like the vtkVolumeMapper, this widget
	/// supports 27 possible configurations of cropping planes. (See
	/// CroppingRegionFlags). If a volume mapper is set, the cropping planes
	/// are directly propagated to the volume mapper. The widget invokes a
	/// CroppingPlanesPositionChangedEvent when the position of any of the
	/// cropping planes is changed. The widget also invokes an InteractionEvent
	/// in response to user interaction.
	/// </remarks>
	// Token: 0x02000321 RID: 801
	public class vtkImageCroppingRegionsWidget : vtk3DWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008F6E RID: 36718 RVA: 0x000CC6CD File Offset: 0x000CA8CD
		static vtkImageCroppingRegionsWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageCroppingRegionsWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageCroppingRegionsWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008F6F RID: 36719 RVA: 0x000CC6F5 File Offset: 0x000CA8F5
		public vtkImageCroppingRegionsWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008F70 RID: 36720
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCroppingRegionsWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008F71 RID: 36721 RVA: 0x000CC704 File Offset: 0x000CA904
		public new static vtkImageCroppingRegionsWidget New()
		{
			vtkImageCroppingRegionsWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCroppingRegionsWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008F72 RID: 36722 RVA: 0x000CC758 File Offset: 0x000CA958
		public vtkImageCroppingRegionsWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008F73 RID: 36723 RVA: 0x000CC79C File Offset: 0x000CA99C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008F74 RID: 36724
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCroppingRegionsWidget_GetCroppingRegionFlags_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the cropping region flags
		/// </summary>
		// Token: 0x06008F75 RID: 36725 RVA: 0x000CC7A8 File Offset: 0x000CA9A8
		public virtual int GetCroppingRegionFlags()
		{
			return vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_GetCroppingRegionFlags_01(base.GetCppThis());
		}

		// Token: 0x06008F76 RID: 36726
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCroppingRegionsWidget_GetLine1Color_02(HandleRef pThis);

		/// <summary>
		/// Set/Get line 1 color
		/// </summary>
		// Token: 0x06008F77 RID: 36727 RVA: 0x000CC7C8 File Offset: 0x000CA9C8
		public virtual IntPtr GetLine1Color()
		{
			return vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_GetLine1Color_02(base.GetCppThis());
		}

		// Token: 0x06008F78 RID: 36728
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_GetLine1Color_03(HandleRef pThis, IntPtr rgb);

		/// <summary>
		/// Set/Get line 1 color
		/// </summary>
		// Token: 0x06008F79 RID: 36729 RVA: 0x000CC7E7 File Offset: 0x000CA9E7
		public virtual void GetLine1Color(IntPtr rgb)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_GetLine1Color_03(base.GetCppThis(), rgb);
		}

		// Token: 0x06008F7A RID: 36730
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCroppingRegionsWidget_GetLine2Color_04(HandleRef pThis);

		/// <summary>
		/// Set/Get line 2 color
		/// </summary>
		// Token: 0x06008F7B RID: 36731 RVA: 0x000CC7F8 File Offset: 0x000CA9F8
		public virtual IntPtr GetLine2Color()
		{
			return vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_GetLine2Color_04(base.GetCppThis());
		}

		// Token: 0x06008F7C RID: 36732
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_GetLine2Color_05(HandleRef pThis, IntPtr rgb);

		/// <summary>
		/// Set/Get line 2 color
		/// </summary>
		// Token: 0x06008F7D RID: 36733 RVA: 0x000CC817 File Offset: 0x000CAA17
		public virtual void GetLine2Color(IntPtr rgb)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_GetLine2Color_05(base.GetCppThis(), rgb);
		}

		// Token: 0x06008F7E RID: 36734
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCroppingRegionsWidget_GetLine3Color_06(HandleRef pThis);

		/// <summary>
		/// Set/Get line 3 color
		/// </summary>
		// Token: 0x06008F7F RID: 36735 RVA: 0x000CC828 File Offset: 0x000CAA28
		public virtual IntPtr GetLine3Color()
		{
			return vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_GetLine3Color_06(base.GetCppThis());
		}

		// Token: 0x06008F80 RID: 36736
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_GetLine3Color_07(HandleRef pThis, IntPtr rgb);

		/// <summary>
		/// Set/Get line 3 color
		/// </summary>
		// Token: 0x06008F81 RID: 36737 RVA: 0x000CC847 File Offset: 0x000CAA47
		public virtual void GetLine3Color(IntPtr rgb)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_GetLine3Color_07(base.GetCppThis(), rgb);
		}

		// Token: 0x06008F82 RID: 36738
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCroppingRegionsWidget_GetLine4Color_08(HandleRef pThis);

		/// <summary>
		/// Set/Get line 4 color
		/// </summary>
		// Token: 0x06008F83 RID: 36739 RVA: 0x000CC858 File Offset: 0x000CAA58
		public virtual IntPtr GetLine4Color()
		{
			return vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_GetLine4Color_08(base.GetCppThis());
		}

		// Token: 0x06008F84 RID: 36740
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_GetLine4Color_09(HandleRef pThis, IntPtr rgb);

		/// <summary>
		/// Set/Get line 4 color
		/// </summary>
		// Token: 0x06008F85 RID: 36741 RVA: 0x000CC877 File Offset: 0x000CAA77
		public virtual void GetLine4Color(IntPtr rgb)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_GetLine4Color_09(base.GetCppThis(), rgb);
		}

		// Token: 0x06008F86 RID: 36742
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageCroppingRegionsWidget_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008F87 RID: 36743 RVA: 0x000CC888 File Offset: 0x000CAA88
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06008F88 RID: 36744
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageCroppingRegionsWidget_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008F89 RID: 36745 RVA: 0x000CC8A8 File Offset: 0x000CAAA8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06008F8A RID: 36746
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCroppingRegionsWidget_GetPlanePositions_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the plane positions that represent the cropped region.
		/// </summary>
		// Token: 0x06008F8B RID: 36747 RVA: 0x000CC8C4 File Offset: 0x000CAAC4
		public virtual double[] GetPlanePositions()
		{
			IntPtr intPtr = vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_GetPlanePositions_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008F8C RID: 36748
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_GetPlanePositions_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		/// <summary>
		/// Set/Get the plane positions that represent the cropped region.
		/// </summary>
		// Token: 0x06008F8D RID: 36749 RVA: 0x000CC90C File Offset: 0x000CAB0C
		public virtual void GetPlanePositions(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_GetPlanePositions_13(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06008F8E RID: 36750
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_GetPlanePositions_14(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the plane positions that represent the cropped region.
		/// </summary>
		// Token: 0x06008F8F RID: 36751 RVA: 0x000CC924 File Offset: 0x000CAB24
		public virtual void GetPlanePositions(IntPtr _arg)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_GetPlanePositions_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06008F90 RID: 36752
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCroppingRegionsWidget_GetSlice_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the slice number
		/// </summary>
		// Token: 0x06008F91 RID: 36753 RVA: 0x000CC934 File Offset: 0x000CAB34
		public virtual int GetSlice()
		{
			return vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_GetSlice_15(base.GetCppThis());
		}

		// Token: 0x06008F92 RID: 36754
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCroppingRegionsWidget_GetSliceOrientation_16(HandleRef pThis);

		/// <summary>
		/// Set/get the slice orientation
		/// </summary>
		// Token: 0x06008F93 RID: 36755 RVA: 0x000CC954 File Offset: 0x000CAB54
		public virtual int GetSliceOrientation()
		{
			return vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_GetSliceOrientation_16(base.GetCppThis());
		}

		// Token: 0x06008F94 RID: 36756
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCroppingRegionsWidget_GetVolumeMapper_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the input volume mapper
		/// Update the widget according to its mapper
		/// </summary>
		// Token: 0x06008F95 RID: 36757 RVA: 0x000CC974 File Offset: 0x000CAB74
		public virtual vtkVolumeMapper GetVolumeMapper()
		{
			vtkVolumeMapper vtkVolumeMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_GetVolumeMapper_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeMapper = (vtkVolumeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeMapper.Register(null);
				}
			}
			return vtkVolumeMapper;
		}

		// Token: 0x06008F96 RID: 36758
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCroppingRegionsWidget_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008F97 RID: 36759 RVA: 0x000CC9E4 File Offset: 0x000CABE4
		public override int IsA(string type)
		{
			return vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x06008F98 RID: 36760
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCroppingRegionsWidget_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008F99 RID: 36761 RVA: 0x000CCA04 File Offset: 0x000CAC04
		public new static int IsTypeOf(string type)
		{
			return vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_IsTypeOf_19(type);
		}

		// Token: 0x06008F9A RID: 36762
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_MoveHorizontalLine_20(HandleRef pThis);

		/// <summary>
		/// Callbacks for user interaction.
		/// </summary>
		// Token: 0x06008F9B RID: 36763 RVA: 0x000CCA1E File Offset: 0x000CAC1E
		public void MoveHorizontalLine()
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_MoveHorizontalLine_20(base.GetCppThis());
		}

		// Token: 0x06008F9C RID: 36764
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_MoveIntersectingLines_21(HandleRef pThis);

		/// <summary>
		/// Callbacks for user interaction.
		/// </summary>
		// Token: 0x06008F9D RID: 36765 RVA: 0x000CCA2D File Offset: 0x000CAC2D
		public void MoveIntersectingLines()
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_MoveIntersectingLines_21(base.GetCppThis());
		}

		// Token: 0x06008F9E RID: 36766
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_MoveVerticalLine_22(HandleRef pThis);

		/// <summary>
		/// Callbacks for user interaction.
		/// </summary>
		// Token: 0x06008F9F RID: 36767 RVA: 0x000CCA3C File Offset: 0x000CAC3C
		public void MoveVerticalLine()
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_MoveVerticalLine_22(base.GetCppThis());
		}

		// Token: 0x06008FA0 RID: 36768
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCroppingRegionsWidget_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008FA1 RID: 36769 RVA: 0x000CCA4C File Offset: 0x000CAC4C
		public new vtkImageCroppingRegionsWidget NewInstance()
		{
			vtkImageCroppingRegionsWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCroppingRegionsWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008FA2 RID: 36770
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_OnButtonPress_25(HandleRef pThis);

		/// <summary>
		/// Callbacks for user interaction.
		/// </summary>
		// Token: 0x06008FA3 RID: 36771 RVA: 0x000CCAA6 File Offset: 0x000CACA6
		public void OnButtonPress()
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_OnButtonPress_25(base.GetCppThis());
		}

		// Token: 0x06008FA4 RID: 36772
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_OnButtonRelease_26(HandleRef pThis);

		/// <summary>
		/// Callbacks for user interaction.
		/// </summary>
		// Token: 0x06008FA5 RID: 36773 RVA: 0x000CCAB5 File Offset: 0x000CACB5
		public void OnButtonRelease()
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_OnButtonRelease_26(base.GetCppThis());
		}

		// Token: 0x06008FA6 RID: 36774
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_OnMouseMove_27(HandleRef pThis);

		/// <summary>
		/// Callbacks for user interaction.
		/// </summary>
		// Token: 0x06008FA7 RID: 36775 RVA: 0x000CCAC4 File Offset: 0x000CACC4
		public void OnMouseMove()
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_OnMouseMove_27(base.GetCppThis());
		}

		// Token: 0x06008FA8 RID: 36776
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_PlaceWidget_28(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Place/Adjust widget within bounds
		/// </summary>
		// Token: 0x06008FA9 RID: 36777 RVA: 0x000CCAD3 File Offset: 0x000CACD3
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_PlaceWidget_28(base.GetCppThis(), bounds);
		}

		// Token: 0x06008FAA RID: 36778
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCroppingRegionsWidget_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008FAB RID: 36779 RVA: 0x000CCAE4 File Offset: 0x000CACE4
		public new static vtkImageCroppingRegionsWidget SafeDownCast(vtkObjectBase o)
		{
			vtkImageCroppingRegionsWidget vtkImageCroppingRegionsWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageCroppingRegionsWidget = (vtkImageCroppingRegionsWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageCroppingRegionsWidget.Register(null);
				}
			}
			return vtkImageCroppingRegionsWidget;
		}

		// Token: 0x06008FAC RID: 36780
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_SetCroppingRegionFlags_30(HandleRef pThis, int flags);

		/// <summary>
		/// Set/Get the cropping region flags
		/// </summary>
		// Token: 0x06008FAD RID: 36781 RVA: 0x000CCB63 File Offset: 0x000CAD63
		public virtual void SetCroppingRegionFlags(int flags)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_SetCroppingRegionFlags_30(base.GetCppThis(), flags);
		}

		// Token: 0x06008FAE RID: 36782
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_SetEnabled_31(HandleRef pThis, int enabling);

		/// <summary>
		/// Enable/disable the widget
		/// </summary>
		// Token: 0x06008FAF RID: 36783 RVA: 0x000CCB73 File Offset: 0x000CAD73
		public override void SetEnabled(int enabling)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_SetEnabled_31(base.GetCppThis(), enabling);
		}

		// Token: 0x06008FB0 RID: 36784
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_SetLine1Color_32(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// Set/Get line 1 color
		/// </summary>
		// Token: 0x06008FB1 RID: 36785 RVA: 0x000CCB83 File Offset: 0x000CAD83
		public virtual void SetLine1Color(double r, double g, double b)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_SetLine1Color_32(base.GetCppThis(), r, g, b);
		}

		// Token: 0x06008FB2 RID: 36786
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_SetLine1Color_33(HandleRef pThis, IntPtr rgb);

		/// <summary>
		/// Set/Get line 1 color
		/// </summary>
		// Token: 0x06008FB3 RID: 36787 RVA: 0x000CCB95 File Offset: 0x000CAD95
		public virtual void SetLine1Color(IntPtr rgb)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_SetLine1Color_33(base.GetCppThis(), rgb);
		}

		// Token: 0x06008FB4 RID: 36788
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_SetLine2Color_34(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// Set/Get line 2 color
		/// </summary>
		// Token: 0x06008FB5 RID: 36789 RVA: 0x000CCBA5 File Offset: 0x000CADA5
		public virtual void SetLine2Color(double r, double g, double b)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_SetLine2Color_34(base.GetCppThis(), r, g, b);
		}

		// Token: 0x06008FB6 RID: 36790
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_SetLine2Color_35(HandleRef pThis, IntPtr rgb);

		/// <summary>
		/// Set/Get line 2 color
		/// </summary>
		// Token: 0x06008FB7 RID: 36791 RVA: 0x000CCBB7 File Offset: 0x000CADB7
		public virtual void SetLine2Color(IntPtr rgb)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_SetLine2Color_35(base.GetCppThis(), rgb);
		}

		// Token: 0x06008FB8 RID: 36792
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_SetLine3Color_36(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// Set/Get line 3 color
		/// </summary>
		// Token: 0x06008FB9 RID: 36793 RVA: 0x000CCBC7 File Offset: 0x000CADC7
		public virtual void SetLine3Color(double r, double g, double b)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_SetLine3Color_36(base.GetCppThis(), r, g, b);
		}

		// Token: 0x06008FBA RID: 36794
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_SetLine3Color_37(HandleRef pThis, IntPtr rgb);

		/// <summary>
		/// Set/Get line 3 color
		/// </summary>
		// Token: 0x06008FBB RID: 36795 RVA: 0x000CCBD9 File Offset: 0x000CADD9
		public virtual void SetLine3Color(IntPtr rgb)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_SetLine3Color_37(base.GetCppThis(), rgb);
		}

		// Token: 0x06008FBC RID: 36796
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_SetLine4Color_38(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// Set/Get line 4 color
		/// </summary>
		// Token: 0x06008FBD RID: 36797 RVA: 0x000CCBE9 File Offset: 0x000CADE9
		public virtual void SetLine4Color(double r, double g, double b)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_SetLine4Color_38(base.GetCppThis(), r, g, b);
		}

		// Token: 0x06008FBE RID: 36798
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_SetLine4Color_39(HandleRef pThis, IntPtr rgb);

		/// <summary>
		/// Set/Get line 4 color
		/// </summary>
		// Token: 0x06008FBF RID: 36799 RVA: 0x000CCBFB File Offset: 0x000CADFB
		public virtual void SetLine4Color(IntPtr rgb)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_SetLine4Color_39(base.GetCppThis(), rgb);
		}

		// Token: 0x06008FC0 RID: 36800
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_SetPlanePositions_40(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Set/Get the plane positions that represent the cropped region.
		/// </summary>
		// Token: 0x06008FC1 RID: 36801 RVA: 0x000CCC0B File Offset: 0x000CAE0B
		public virtual void SetPlanePositions(IntPtr pos)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_SetPlanePositions_40(base.GetCppThis(), pos);
		}

		// Token: 0x06008FC2 RID: 36802
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_SetPlanePositions_41(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

		/// <summary>
		/// Set/Get the plane positions that represent the cropped region.
		/// </summary>
		// Token: 0x06008FC3 RID: 36803 RVA: 0x000CCC1B File Offset: 0x000CAE1B
		public virtual void SetPlanePositions(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_SetPlanePositions_41(base.GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
		}

		// Token: 0x06008FC4 RID: 36804
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_SetSlice_42(HandleRef pThis, int num);

		/// <summary>
		/// Set/Get the slice number
		/// </summary>
		// Token: 0x06008FC5 RID: 36805 RVA: 0x000CCC33 File Offset: 0x000CAE33
		public virtual void SetSlice(int num)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_SetSlice_42(base.GetCppThis(), num);
		}

		// Token: 0x06008FC6 RID: 36806
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_SetSliceOrientation_43(HandleRef pThis, int orientation);

		/// <summary>
		/// Set/get the slice orientation
		/// </summary>
		// Token: 0x06008FC7 RID: 36807 RVA: 0x000CCC43 File Offset: 0x000CAE43
		public virtual void SetSliceOrientation(int orientation)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_SetSliceOrientation_43(base.GetCppThis(), orientation);
		}

		// Token: 0x06008FC8 RID: 36808
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_SetSliceOrientationToXY_44(HandleRef pThis);

		/// <summary>
		/// Set/get the slice orientation
		/// </summary>
		// Token: 0x06008FC9 RID: 36809 RVA: 0x000CCC53 File Offset: 0x000CAE53
		public virtual void SetSliceOrientationToXY()
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_SetSliceOrientationToXY_44(base.GetCppThis());
		}

		// Token: 0x06008FCA RID: 36810
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_SetSliceOrientationToXZ_45(HandleRef pThis);

		/// <summary>
		/// Set/get the slice orientation
		/// </summary>
		// Token: 0x06008FCB RID: 36811 RVA: 0x000CCC62 File Offset: 0x000CAE62
		public virtual void SetSliceOrientationToXZ()
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_SetSliceOrientationToXZ_45(base.GetCppThis());
		}

		// Token: 0x06008FCC RID: 36812
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_SetSliceOrientationToYZ_46(HandleRef pThis);

		/// <summary>
		/// Set/get the slice orientation
		/// </summary>
		// Token: 0x06008FCD RID: 36813 RVA: 0x000CCC71 File Offset: 0x000CAE71
		public virtual void SetSliceOrientationToYZ()
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_SetSliceOrientationToYZ_46(base.GetCppThis());
		}

		// Token: 0x06008FCE RID: 36814
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_SetVolumeMapper_47(HandleRef pThis, HandleRef mapper);

		/// <summary>
		/// Set/Get the input volume mapper
		/// Update the widget according to its mapper
		/// </summary>
		// Token: 0x06008FCF RID: 36815 RVA: 0x000CCC80 File Offset: 0x000CAE80
		public virtual void SetVolumeMapper(vtkVolumeMapper mapper)
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_SetVolumeMapper_47(base.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		// Token: 0x06008FD0 RID: 36816
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_UpdateAccordingToInput_48(HandleRef pThis);

		/// <summary>
		/// Set/Get the input volume mapper
		/// Update the widget according to its mapper
		/// </summary>
		// Token: 0x06008FD1 RID: 36817 RVA: 0x000CCCAF File Offset: 0x000CAEAF
		public virtual void UpdateAccordingToInput()
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_UpdateAccordingToInput_48(base.GetCppThis());
		}

		// Token: 0x06008FD2 RID: 36818
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCroppingRegionsWidget_UpdateCursorIcon_49(HandleRef pThis);

		/// <summary>
		/// Callbacks for user interaction.
		/// </summary>
		// Token: 0x06008FD3 RID: 36819 RVA: 0x000CCCBE File Offset: 0x000CAEBE
		public void UpdateCursorIcon()
		{
			vtkImageCroppingRegionsWidget.vtkImageCroppingRegionsWidget_UpdateCursorIcon_49(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BFE RID: 3070
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageCroppingRegionsWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BFF RID: 3071
		public new static readonly string MRClassNameKey = "class vtkImageCroppingRegionsWidget";

		/// <summary>
		/// Set/get the slice orientation
		/// </summary>
		// Token: 0x02000322 RID: 802
		public enum SLICE_ORIENTATION_XY_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000C01 RID: 3073
			SLICE_ORIENTATION_XY = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000C02 RID: 3074
			SLICE_ORIENTATION_XZ = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000C03 RID: 3075
			SLICE_ORIENTATION_YZ = 0
		}

		/// <summary>
		/// Events invoked by this widget
		/// </summary>
		// Token: 0x02000323 RID: 803
		public enum WidgetEventIds
		{
			/// <summary>enum member</summary>
			// Token: 0x04000C05 RID: 3077
			CroppingPlanesPositionChangedEvent = 10050
		}
	}
}
