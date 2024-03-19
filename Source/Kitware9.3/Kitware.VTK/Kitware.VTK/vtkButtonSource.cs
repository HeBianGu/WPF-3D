using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkButtonSource
	/// </summary>
	/// <remarks>
	///    abstract class for creating various button types
	///
	/// vtkButtonSource is an abstract class that defines an API for creating
	/// "button-like" objects in VTK. A button is a geometry with a rectangular
	/// region that can be textured. The button is divided into two regions: the
	/// texture region and the shoulder region. The points in both regions are
	/// assigned texture coordinates. The texture region has texture coordinates
	/// consistent with the image to be placed on it.  All points in the shoulder
	/// regions are assigned a texture coordinate specified by the user.  In this
	/// way the shoulder region can be colored by the texture.
	///
	/// Creating a vtkButtonSource requires specifying its center point.
	/// (Subclasses have other attributes that must be set to control
	/// the shape of the button.) You must also specify how to control
	/// the shape of the texture region; i.e., whether to size the
	/// texture region proportional to the texture dimensions or whether
	/// to size the texture region proportional to the button. Also, buttons
	/// can be created single sided are mirrored to create two-sided buttons.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkEllipticalButtonSource vtkRectangularButtonSource
	///
	/// @warning
	/// The button is defined in the x-y plane. Use vtkTransformPolyDataFilter
	/// or vtkGlyph3D to orient the button in a different direction.
	/// </seealso>
	// Token: 0x0200081F RID: 2079
	public class vtkButtonSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060156D7 RID: 87767 RVA: 0x001E51D5 File Offset: 0x001E33D5
		static vtkButtonSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkButtonSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkButtonSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060156D8 RID: 87768 RVA: 0x001E51FD File Offset: 0x001E33FD
		public vtkButtonSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060156D9 RID: 87769 RVA: 0x001E520B File Offset: 0x001E340B
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060156DA RID: 87770
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkButtonSource_GetCenter_01(HandleRef pThis);

		/// <summary>
		/// Specify a point defining the origin (center) of the button.
		/// </summary>
		// Token: 0x060156DB RID: 87771 RVA: 0x001E5218 File Offset: 0x001E3418
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkButtonSource.vtkButtonSource_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060156DC RID: 87772
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonSource_GetCenter_02(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify a point defining the origin (center) of the button.
		/// </summary>
		// Token: 0x060156DD RID: 87773 RVA: 0x001E5260 File Offset: 0x001E3460
		public virtual void GetCenter(IntPtr data)
		{
			vtkButtonSource.vtkButtonSource_GetCenter_02(base.GetCppThis(), data);
		}

		// Token: 0x060156DE RID: 87774
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkButtonSource_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060156DF RID: 87775 RVA: 0x001E5270 File Offset: 0x001E3470
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkButtonSource.vtkButtonSource_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060156E0 RID: 87776
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkButtonSource_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060156E1 RID: 87777 RVA: 0x001E5290 File Offset: 0x001E3490
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkButtonSource.vtkButtonSource_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060156E2 RID: 87778
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkButtonSource_GetShoulderTextureCoordinate_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the default texture coordinate to set the shoulder region to.
		/// </summary>
		// Token: 0x060156E3 RID: 87779 RVA: 0x001E52AC File Offset: 0x001E34AC
		public virtual double[] GetShoulderTextureCoordinate()
		{
			IntPtr intPtr = vtkButtonSource.vtkButtonSource_GetShoulderTextureCoordinate_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060156E4 RID: 87780
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonSource_GetShoulderTextureCoordinate_06(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set/Get the default texture coordinate to set the shoulder region to.
		/// </summary>
		// Token: 0x060156E5 RID: 87781 RVA: 0x001E52F4 File Offset: 0x001E34F4
		public virtual void GetShoulderTextureCoordinate(ref double _arg1, ref double _arg2)
		{
			vtkButtonSource.vtkButtonSource_GetShoulderTextureCoordinate_06(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x060156E6 RID: 87782
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonSource_GetShoulderTextureCoordinate_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the default texture coordinate to set the shoulder region to.
		/// </summary>
		// Token: 0x060156E7 RID: 87783 RVA: 0x001E5305 File Offset: 0x001E3505
		public virtual void GetShoulderTextureCoordinate(IntPtr _arg)
		{
			vtkButtonSource.vtkButtonSource_GetShoulderTextureCoordinate_07(base.GetCppThis(), _arg);
		}

		// Token: 0x060156E8 RID: 87784
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkButtonSource_GetTextureDimensions_08(HandleRef pThis);

		/// <summary>
		/// Set/get the texture dimension. This needs to be set if the texture
		/// style is set to fit the image.
		/// </summary>
		// Token: 0x060156E9 RID: 87785 RVA: 0x001E5318 File Offset: 0x001E3518
		public virtual int[] GetTextureDimensions()
		{
			IntPtr intPtr = vtkButtonSource.vtkButtonSource_GetTextureDimensions_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060156EA RID: 87786
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonSource_GetTextureDimensions_09(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Set/get the texture dimension. This needs to be set if the texture
		/// style is set to fit the image.
		/// </summary>
		// Token: 0x060156EB RID: 87787 RVA: 0x001E5360 File Offset: 0x001E3560
		public virtual void GetTextureDimensions(ref int _arg1, ref int _arg2)
		{
			vtkButtonSource.vtkButtonSource_GetTextureDimensions_09(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x060156EC RID: 87788
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonSource_GetTextureDimensions_10(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the texture dimension. This needs to be set if the texture
		/// style is set to fit the image.
		/// </summary>
		// Token: 0x060156ED RID: 87789 RVA: 0x001E5371 File Offset: 0x001E3571
		public virtual void GetTextureDimensions(IntPtr _arg)
		{
			vtkButtonSource.vtkButtonSource_GetTextureDimensions_10(base.GetCppThis(), _arg);
		}

		// Token: 0x060156EE RID: 87790
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkButtonSource_GetTextureStyle_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the style of the texture region: whether to size it
		/// according to the x-y dimensions of the texture, or whether to make
		/// the texture region proportional to the width/height of the button.
		/// </summary>
		// Token: 0x060156EF RID: 87791 RVA: 0x001E5384 File Offset: 0x001E3584
		public virtual int GetTextureStyle()
		{
			return vtkButtonSource.vtkButtonSource_GetTextureStyle_11(base.GetCppThis());
		}

		// Token: 0x060156F0 RID: 87792
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkButtonSource_GetTextureStyleMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the style of the texture region: whether to size it
		/// according to the x-y dimensions of the texture, or whether to make
		/// the texture region proportional to the width/height of the button.
		/// </summary>
		// Token: 0x060156F1 RID: 87793 RVA: 0x001E53A4 File Offset: 0x001E35A4
		public virtual int GetTextureStyleMaxValue()
		{
			return vtkButtonSource.vtkButtonSource_GetTextureStyleMaxValue_12(base.GetCppThis());
		}

		// Token: 0x060156F2 RID: 87794
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkButtonSource_GetTextureStyleMinValue_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the style of the texture region: whether to size it
		/// according to the x-y dimensions of the texture, or whether to make
		/// the texture region proportional to the width/height of the button.
		/// </summary>
		// Token: 0x060156F3 RID: 87795 RVA: 0x001E53C4 File Offset: 0x001E35C4
		public virtual int GetTextureStyleMinValue()
		{
			return vtkButtonSource.vtkButtonSource_GetTextureStyleMinValue_13(base.GetCppThis());
		}

		// Token: 0x060156F4 RID: 87796
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkButtonSource_GetTwoSided_14(HandleRef pThis);

		/// <summary>
		/// Indicate whether the button is single or double sided. A double sided
		/// button can be viewed from two sides...it looks sort of like a "pill."
		/// A single-sided button is meant to viewed from a single side; it looks
		/// like a "clam-shell."
		/// </summary>
		// Token: 0x060156F5 RID: 87797 RVA: 0x001E53E4 File Offset: 0x001E35E4
		public virtual int GetTwoSided()
		{
			return vtkButtonSource.vtkButtonSource_GetTwoSided_14(base.GetCppThis());
		}

		// Token: 0x060156F6 RID: 87798
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkButtonSource_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060156F7 RID: 87799 RVA: 0x001E5404 File Offset: 0x001E3604
		public override int IsA(string type)
		{
			return vtkButtonSource.vtkButtonSource_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x060156F8 RID: 87800
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkButtonSource_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060156F9 RID: 87801 RVA: 0x001E5424 File Offset: 0x001E3624
		public new static int IsTypeOf(string type)
		{
			return vtkButtonSource.vtkButtonSource_IsTypeOf_16(type);
		}

		// Token: 0x060156FA RID: 87802
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkButtonSource_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060156FB RID: 87803 RVA: 0x001E5440 File Offset: 0x001E3640
		public new vtkButtonSource NewInstance()
		{
			vtkButtonSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkButtonSource.vtkButtonSource_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkButtonSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060156FC RID: 87804
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkButtonSource_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060156FD RID: 87805 RVA: 0x001E549C File Offset: 0x001E369C
		public new static vtkButtonSource SafeDownCast(vtkObjectBase o)
		{
			vtkButtonSource vtkButtonSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkButtonSource.vtkButtonSource_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkButtonSource = (vtkButtonSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkButtonSource.Register(null);
				}
			}
			return vtkButtonSource;
		}

		// Token: 0x060156FE RID: 87806
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonSource_SetCenter_19(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify a point defining the origin (center) of the button.
		/// </summary>
		// Token: 0x060156FF RID: 87807 RVA: 0x001E551B File Offset: 0x001E371B
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkButtonSource.vtkButtonSource_SetCenter_19(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06015700 RID: 87808
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonSource_SetCenter_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a point defining the origin (center) of the button.
		/// </summary>
		// Token: 0x06015701 RID: 87809 RVA: 0x001E552D File Offset: 0x001E372D
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkButtonSource.vtkButtonSource_SetCenter_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06015702 RID: 87810
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonSource_SetShoulderTextureCoordinate_21(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set/Get the default texture coordinate to set the shoulder region to.
		/// </summary>
		// Token: 0x06015703 RID: 87811 RVA: 0x001E553D File Offset: 0x001E373D
		public virtual void SetShoulderTextureCoordinate(double _arg1, double _arg2)
		{
			vtkButtonSource.vtkButtonSource_SetShoulderTextureCoordinate_21(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06015704 RID: 87812
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonSource_SetShoulderTextureCoordinate_22(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the default texture coordinate to set the shoulder region to.
		/// </summary>
		// Token: 0x06015705 RID: 87813 RVA: 0x001E554E File Offset: 0x001E374E
		public void SetShoulderTextureCoordinate(IntPtr _arg)
		{
			vtkButtonSource.vtkButtonSource_SetShoulderTextureCoordinate_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06015706 RID: 87814
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonSource_SetTextureDimensions_23(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set/get the texture dimension. This needs to be set if the texture
		/// style is set to fit the image.
		/// </summary>
		// Token: 0x06015707 RID: 87815 RVA: 0x001E555E File Offset: 0x001E375E
		public virtual void SetTextureDimensions(int _arg1, int _arg2)
		{
			vtkButtonSource.vtkButtonSource_SetTextureDimensions_23(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06015708 RID: 87816
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonSource_SetTextureDimensions_24(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the texture dimension. This needs to be set if the texture
		/// style is set to fit the image.
		/// </summary>
		// Token: 0x06015709 RID: 87817 RVA: 0x001E556F File Offset: 0x001E376F
		public void SetTextureDimensions(IntPtr _arg)
		{
			vtkButtonSource.vtkButtonSource_SetTextureDimensions_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0601570A RID: 87818
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonSource_SetTextureStyle_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the style of the texture region: whether to size it
		/// according to the x-y dimensions of the texture, or whether to make
		/// the texture region proportional to the width/height of the button.
		/// </summary>
		// Token: 0x0601570B RID: 87819 RVA: 0x001E557F File Offset: 0x001E377F
		public virtual void SetTextureStyle(int _arg)
		{
			vtkButtonSource.vtkButtonSource_SetTextureStyle_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0601570C RID: 87820
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonSource_SetTextureStyleToFitImage_26(HandleRef pThis);

		/// <summary>
		/// Set/Get the style of the texture region: whether to size it
		/// according to the x-y dimensions of the texture, or whether to make
		/// the texture region proportional to the width/height of the button.
		/// </summary>
		// Token: 0x0601570D RID: 87821 RVA: 0x001E558F File Offset: 0x001E378F
		public void SetTextureStyleToFitImage()
		{
			vtkButtonSource.vtkButtonSource_SetTextureStyleToFitImage_26(base.GetCppThis());
		}

		// Token: 0x0601570E RID: 87822
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonSource_SetTextureStyleToProportional_27(HandleRef pThis);

		/// <summary>
		/// Set/Get the style of the texture region: whether to size it
		/// according to the x-y dimensions of the texture, or whether to make
		/// the texture region proportional to the width/height of the button.
		/// </summary>
		// Token: 0x0601570F RID: 87823 RVA: 0x001E559E File Offset: 0x001E379E
		public void SetTextureStyleToProportional()
		{
			vtkButtonSource.vtkButtonSource_SetTextureStyleToProportional_27(base.GetCppThis());
		}

		// Token: 0x06015710 RID: 87824
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonSource_SetTwoSided_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether the button is single or double sided. A double sided
		/// button can be viewed from two sides...it looks sort of like a "pill."
		/// A single-sided button is meant to viewed from a single side; it looks
		/// like a "clam-shell."
		/// </summary>
		// Token: 0x06015711 RID: 87825 RVA: 0x001E55AD File Offset: 0x001E37AD
		public virtual void SetTwoSided(int _arg)
		{
			vtkButtonSource.vtkButtonSource_SetTwoSided_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06015712 RID: 87826
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonSource_TwoSidedOff_29(HandleRef pThis);

		/// <summary>
		/// Indicate whether the button is single or double sided. A double sided
		/// button can be viewed from two sides...it looks sort of like a "pill."
		/// A single-sided button is meant to viewed from a single side; it looks
		/// like a "clam-shell."
		/// </summary>
		// Token: 0x06015713 RID: 87827 RVA: 0x001E55BD File Offset: 0x001E37BD
		public virtual void TwoSidedOff()
		{
			vtkButtonSource.vtkButtonSource_TwoSidedOff_29(base.GetCppThis());
		}

		// Token: 0x06015714 RID: 87828
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonSource_TwoSidedOn_30(HandleRef pThis);

		/// <summary>
		/// Indicate whether the button is single or double sided. A double sided
		/// button can be viewed from two sides...it looks sort of like a "pill."
		/// A single-sided button is meant to viewed from a single side; it looks
		/// like a "clam-shell."
		/// </summary>
		// Token: 0x06015715 RID: 87829 RVA: 0x001E55CC File Offset: 0x001E37CC
		public virtual void TwoSidedOn()
		{
			vtkButtonSource.vtkButtonSource_TwoSidedOn_30(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001887 RID: 6279
		public new const string MRFullTypeName = "Kitware.VTK.vtkButtonSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001888 RID: 6280
		public new static readonly string MRClassNameKey = "class vtkButtonSource";
	}
}
