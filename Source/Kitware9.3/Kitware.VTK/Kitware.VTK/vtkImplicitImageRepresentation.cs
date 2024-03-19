using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImplicitImageRepresentation
	/// </summary>
	/// <remarks>
	///    a representation for a vtkImplicitPlaneWidget2 which reslices a volume
	///
	/// This class is a specialization of the vtkImplicitPlaneRepresentation. It
	/// is specialized to resample volumes across a plane. It is similar to
	/// vtkImagePlaneWidget, except the combination of vtkImplicitPlaneWidget2 and
	/// vtkImplicitImageRepresentation is a second generation widget design, with
	/// a much simpler and intuitive plane manipulation.
	///
	/// See the documentation for vtkImplicitPlaneWidget2 and
	/// vtkImplicitPlaneRepresentation for usage information. One notable difference
	/// is that the methods PlaceImage() are preferred to the superclasses'
	/// PlaceWidget() method.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitPlaneWidget2 vtkImagePlaneWidget
	/// </seealso>
	// Token: 0x0200032F RID: 815
	public class vtkImplicitImageRepresentation : vtkImplicitPlaneRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060093BF RID: 37823 RVA: 0x000D151C File Offset: 0x000CF71C
		static vtkImplicitImageRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitImageRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitImageRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060093C0 RID: 37824 RVA: 0x000D1544 File Offset: 0x000CF744
		public vtkImplicitImageRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060093C1 RID: 37825
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitImageRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x060093C2 RID: 37826 RVA: 0x000D1554 File Offset: 0x000CF754
		public new static vtkImplicitImageRepresentation New()
		{
			vtkImplicitImageRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitImageRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x060093C3 RID: 37827 RVA: 0x000D15A8 File Offset: 0x000CF7A8
		public vtkImplicitImageRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060093C4 RID: 37828 RVA: 0x000D15EC File Offset: 0x000CF7EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060093C5 RID: 37829
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitImageRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Methods to interface with the vtkImplicitPlaneWidget2. Most of the required
		/// methods are implemented by this class's superclass.
		/// </summary>
		// Token: 0x060093C6 RID: 37830 RVA: 0x000D15F7 File Offset: 0x000CF7F7
		public override void BuildRepresentation()
		{
			vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x060093C7 RID: 37831
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitImageRepresentation_GetColorMap_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience method to get the vtkImageMapToColors filter used by this
		/// widget.  The user can properly render other transparent actors in a
		/// scene by calling the filter's SetOutputFormatToRGB and
		/// PassAlphaToOutputOff.
		/// </summary>
		// Token: 0x060093C8 RID: 37832 RVA: 0x000D1608 File Offset: 0x000CF808
		public virtual vtkImageMapToColors GetColorMap()
		{
			vtkImageMapToColors vtkImageMapToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_GetColorMap_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMapToColors = (vtkImageMapToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMapToColors.Register(null);
				}
			}
			return vtkImageMapToColors;
		}

		// Token: 0x060093C9 RID: 37833
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitImageRepresentation_GetLookupTable_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the internal lookuptable (lut) to one defined by the user, or,
		/// alternatively, to the lut of another representation or widget.  In this way,
		/// a set of three orthogonal planes can share the same lut so that
		/// window-levelling is performed uniformly among planes.  The default
		/// internal lut can be re- set/allocated by setting to nullptr.
		/// </summary>
		// Token: 0x060093CA RID: 37834 RVA: 0x000D1678 File Offset: 0x000CF878
		public virtual vtkLookupTable GetLookupTable()
		{
			vtkLookupTable vtkLookupTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_GetLookupTable_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTable = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTable.Register(null);
				}
			}
			return vtkLookupTable;
		}

		// Token: 0x060093CB RID: 37835
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitImageRepresentation_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x060093CC RID: 37836 RVA: 0x000D16E8 File Offset: 0x000CF8E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060093CD RID: 37837
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitImageRepresentation_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x060093CE RID: 37838 RVA: 0x000D1708 File Offset: 0x000CF908
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060093CF RID: 37839
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitImageRepresentation_GetReslice_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience method to get the vtkImageReslice filter used by this
		/// widget.
		/// </summary>
		// Token: 0x060093D0 RID: 37840 RVA: 0x000D1724 File Offset: 0x000CF924
		public virtual vtkImageReslice GetReslice()
		{
			vtkImageReslice vtkImageReslice = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_GetReslice_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageReslice = (vtkImageReslice)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageReslice.Register(null);
				}
			}
			return vtkImageReslice;
		}

		// Token: 0x060093D1 RID: 37841
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitImageRepresentation_GetResliceInterpolate_07(HandleRef pThis);

		/// <summary>
		/// Set the interpolation to use when texturing the plane.
		/// </summary>
		// Token: 0x060093D2 RID: 37842 RVA: 0x000D1794 File Offset: 0x000CF994
		public virtual int GetResliceInterpolate()
		{
			return vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_GetResliceInterpolate_07(base.GetCppThis());
		}

		// Token: 0x060093D3 RID: 37843
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImplicitImageRepresentation_GetTextureInterpolate_08(HandleRef pThis);

		/// <summary>
		/// Specify whether to interpolate the texture or not. When off, the
		/// reslice interpolation is nearest neighbour regardless of how the
		/// interpolation is set through the API. Set before setting the
		/// vtkImageData input. Default is On.
		/// </summary>
		// Token: 0x060093D4 RID: 37844 RVA: 0x000D17B4 File Offset: 0x000CF9B4
		public virtual bool GetTextureInterpolate()
		{
			return vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_GetTextureInterpolate_08(base.GetCppThis()) != 0;
		}

		// Token: 0x060093D5 RID: 37845
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImplicitImageRepresentation_GetUserControlledLookupTable_09(HandleRef pThis);

		/// <summary>
		/// Let the user control the lookup table. NOTE: apply this method BEFORE
		/// applying the SetLookupTable method. The default is Off.
		/// </summary>
		// Token: 0x060093D6 RID: 37846 RVA: 0x000D17DC File Offset: 0x000CF9DC
		public virtual bool GetUserControlledLookupTable()
		{
			return vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_GetUserControlledLookupTable_09(base.GetCppThis()) != 0;
		}

		// Token: 0x060093D7 RID: 37847
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitImageRepresentation_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x060093D8 RID: 37848 RVA: 0x000D1804 File Offset: 0x000CFA04
		public override int IsA(string type)
		{
			return vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x060093D9 RID: 37849
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitImageRepresentation_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x060093DA RID: 37850 RVA: 0x000D1824 File Offset: 0x000CFA24
		public new static int IsTypeOf(string type)
		{
			return vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_IsTypeOf_11(type);
		}

		// Token: 0x060093DB RID: 37851
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitImageRepresentation_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x060093DC RID: 37852 RVA: 0x000D1840 File Offset: 0x000CFA40
		public new vtkImplicitImageRepresentation NewInstance()
		{
			vtkImplicitImageRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitImageRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060093DD RID: 37853
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitImageRepresentation_PlaceImage_14(HandleRef pThis, HandleRef img);

		/// <summary>
		/// Various ways to specify the vtkImageData* input for the
		/// vtkImageReslice; and perform PlaceWidget().
		/// </summary>
		// Token: 0x060093DE RID: 37854 RVA: 0x000D189C File Offset: 0x000CFA9C
		public void PlaceImage(vtkImageData img)
		{
			vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_PlaceImage_14(base.GetCppThis(), (img == null) ? default(HandleRef) : img.GetCppThis());
		}

		// Token: 0x060093DF RID: 37855
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitImageRepresentation_PlaceImage_15(HandleRef pThis, HandleRef aout);

		/// <summary>
		/// Various ways to specify the vtkImageData* input for the
		/// vtkImageReslice; and perform PlaceWidget().
		/// </summary>
		// Token: 0x060093E0 RID: 37856 RVA: 0x000D18CC File Offset: 0x000CFACC
		public void PlaceImage(vtkAlgorithmOutput aout)
		{
			vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_PlaceImage_15(base.GetCppThis(), (aout == null) ? default(HandleRef) : aout.GetCppThis());
		}

		// Token: 0x060093E1 RID: 37857
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitImageRepresentation_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x060093E2 RID: 37858 RVA: 0x000D18FC File Offset: 0x000CFAFC
		public new static vtkImplicitImageRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitImageRepresentation vtkImplicitImageRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitImageRepresentation = (vtkImplicitImageRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitImageRepresentation.Register(null);
				}
			}
			return vtkImplicitImageRepresentation;
		}

		// Token: 0x060093E3 RID: 37859
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitImageRepresentation_SetColorMap_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Convenience method to get the vtkImageMapToColors filter used by this
		/// widget.  The user can properly render other transparent actors in a
		/// scene by calling the filter's SetOutputFormatToRGB and
		/// PassAlphaToOutputOff.
		/// </summary>
		// Token: 0x060093E4 RID: 37860 RVA: 0x000D197C File Offset: 0x000CFB7C
		public virtual void SetColorMap(vtkImageMapToColors arg0)
		{
			vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_SetColorMap_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060093E5 RID: 37861
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitImageRepresentation_SetCropPlaneToBoundingBox_18(HandleRef pThis, byte arg0);

		/// <summary>
		/// This method modifies the texture pipeline in order to generate texture
		/// coordinates.
		/// </summary>
		// Token: 0x060093E6 RID: 37862 RVA: 0x000D19AB File Offset: 0x000CFBAB
		public override void SetCropPlaneToBoundingBox(bool arg0)
		{
			vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_SetCropPlaneToBoundingBox_18(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		// Token: 0x060093E7 RID: 37863
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitImageRepresentation_SetLookupTable_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the internal lookuptable (lut) to one defined by the user, or,
		/// alternatively, to the lut of another representation or widget.  In this way,
		/// a set of three orthogonal planes can share the same lut so that
		/// window-levelling is performed uniformly among planes.  The default
		/// internal lut can be re- set/allocated by setting to nullptr.
		/// </summary>
		// Token: 0x060093E8 RID: 37864 RVA: 0x000D19C4 File Offset: 0x000CFBC4
		public virtual void SetLookupTable(vtkLookupTable arg0)
		{
			vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_SetLookupTable_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060093E9 RID: 37865
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitImageRepresentation_SetResliceInterpolate_20(HandleRef pThis, int arg0);

		/// <summary>
		/// Set the interpolation to use when texturing the plane.
		/// </summary>
		// Token: 0x060093EA RID: 37866 RVA: 0x000D19F3 File Offset: 0x000CFBF3
		public void SetResliceInterpolate(int arg0)
		{
			vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_SetResliceInterpolate_20(base.GetCppThis(), arg0);
		}

		// Token: 0x060093EB RID: 37867
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitImageRepresentation_SetResliceInterpolateToCubic_21(HandleRef pThis);

		/// <summary>
		/// Set the interpolation to use when texturing the plane.
		/// </summary>
		// Token: 0x060093EC RID: 37868 RVA: 0x000D1A03 File Offset: 0x000CFC03
		public void SetResliceInterpolateToCubic()
		{
			vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_SetResliceInterpolateToCubic_21(base.GetCppThis());
		}

		// Token: 0x060093ED RID: 37869
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitImageRepresentation_SetResliceInterpolateToLinear_22(HandleRef pThis);

		/// <summary>
		/// Set the interpolation to use when texturing the plane.
		/// </summary>
		// Token: 0x060093EE RID: 37870 RVA: 0x000D1A12 File Offset: 0x000CFC12
		public void SetResliceInterpolateToLinear()
		{
			vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_SetResliceInterpolateToLinear_22(base.GetCppThis());
		}

		// Token: 0x060093EF RID: 37871
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitImageRepresentation_SetResliceInterpolateToNearestNeighbour_23(HandleRef pThis);

		/// <summary>
		/// Set the interpolation to use when texturing the plane.
		/// </summary>
		// Token: 0x060093F0 RID: 37872 RVA: 0x000D1A21 File Offset: 0x000CFC21
		public void SetResliceInterpolateToNearestNeighbour()
		{
			vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_SetResliceInterpolateToNearestNeighbour_23(base.GetCppThis());
		}

		// Token: 0x060093F1 RID: 37873
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitImageRepresentation_SetTextureInterpolate_24(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether to interpolate the texture or not. When off, the
		/// reslice interpolation is nearest neighbour regardless of how the
		/// interpolation is set through the API. Set before setting the
		/// vtkImageData input. Default is On.
		/// </summary>
		// Token: 0x060093F2 RID: 37874 RVA: 0x000D1A30 File Offset: 0x000CFC30
		public virtual void SetTextureInterpolate(bool _arg)
		{
			vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_SetTextureInterpolate_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060093F3 RID: 37875
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitImageRepresentation_SetUserControlledLookupTable_25(HandleRef pThis, byte _arg);

		/// <summary>
		/// Let the user control the lookup table. NOTE: apply this method BEFORE
		/// applying the SetLookupTable method. The default is Off.
		/// </summary>
		// Token: 0x060093F4 RID: 37876 RVA: 0x000D1A48 File Offset: 0x000CFC48
		public virtual void SetUserControlledLookupTable(bool _arg)
		{
			vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_SetUserControlledLookupTable_25(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060093F5 RID: 37877
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitImageRepresentation_TextureInterpolateOff_26(HandleRef pThis);

		/// <summary>
		/// Specify whether to interpolate the texture or not. When off, the
		/// reslice interpolation is nearest neighbour regardless of how the
		/// interpolation is set through the API. Set before setting the
		/// vtkImageData input. Default is On.
		/// </summary>
		// Token: 0x060093F6 RID: 37878 RVA: 0x000D1A60 File Offset: 0x000CFC60
		public virtual void TextureInterpolateOff()
		{
			vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_TextureInterpolateOff_26(base.GetCppThis());
		}

		// Token: 0x060093F7 RID: 37879
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitImageRepresentation_TextureInterpolateOn_27(HandleRef pThis);

		/// <summary>
		/// Specify whether to interpolate the texture or not. When off, the
		/// reslice interpolation is nearest neighbour regardless of how the
		/// interpolation is set through the API. Set before setting the
		/// vtkImageData input. Default is On.
		/// </summary>
		// Token: 0x060093F8 RID: 37880 RVA: 0x000D1A6F File Offset: 0x000CFC6F
		public virtual void TextureInterpolateOn()
		{
			vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_TextureInterpolateOn_27(base.GetCppThis());
		}

		// Token: 0x060093F9 RID: 37881
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitImageRepresentation_UserControlledLookupTableOff_28(HandleRef pThis);

		/// <summary>
		/// Let the user control the lookup table. NOTE: apply this method BEFORE
		/// applying the SetLookupTable method. The default is Off.
		/// </summary>
		// Token: 0x060093FA RID: 37882 RVA: 0x000D1A7E File Offset: 0x000CFC7E
		public virtual void UserControlledLookupTableOff()
		{
			vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_UserControlledLookupTableOff_28(base.GetCppThis());
		}

		// Token: 0x060093FB RID: 37883
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitImageRepresentation_UserControlledLookupTableOn_29(HandleRef pThis);

		/// <summary>
		/// Let the user control the lookup table. NOTE: apply this method BEFORE
		/// applying the SetLookupTable method. The default is Off.
		/// </summary>
		// Token: 0x060093FC RID: 37884 RVA: 0x000D1A8D File Offset: 0x000CFC8D
		public virtual void UserControlledLookupTableOn()
		{
			vtkImplicitImageRepresentation.vtkImplicitImageRepresentation_UserControlledLookupTableOn_29(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C2D RID: 3117
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitImageRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C2E RID: 3118
		public new static readonly string MRClassNameKey = "class vtkImplicitImageRepresentation";
	}
}
