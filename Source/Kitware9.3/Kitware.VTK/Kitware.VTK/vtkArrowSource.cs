using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkArrowSource
	/// </summary>
	/// <remarks>
	///    Appends a cylinder to a cone to form an arrow.
	///
	/// vtkArrowSource was intended to be used as the source for a glyph.
	/// The shaft base is always at (0,0,0). The arrow tip is always at (1,0,0). If
	/// "Invert" is true, then the ends are flipped i.e. tip is at (0,0,0) while
	/// base is at (1, 0, 0).
	/// The resolution of the cone and shaft can be set and default to 6.
	/// The radius of the cone and shaft can be set and default to 0.03 and 0.1.
	/// The length of the tip can also be set, and defaults to 0.35.
	/// </remarks>
	// Token: 0x0200081D RID: 2077
	public class vtkArrowSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601568B RID: 87691 RVA: 0x001E4CA7 File Offset: 0x001E2EA7
		static vtkArrowSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArrowSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrowSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601568C RID: 87692 RVA: 0x001E4CCF File Offset: 0x001E2ECF
		public vtkArrowSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601568D RID: 87693
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrowSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct cone with angle of 45 degrees.
		/// </summary>
		// Token: 0x0601568E RID: 87694 RVA: 0x001E4CE0 File Offset: 0x001E2EE0
		public new static vtkArrowSource New()
		{
			vtkArrowSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrowSource.vtkArrowSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrowSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct cone with angle of 45 degrees.
		/// </summary>
		// Token: 0x0601568F RID: 87695 RVA: 0x001E4D34 File Offset: 0x001E2F34
		public vtkArrowSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkArrowSource.vtkArrowSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015690 RID: 87696 RVA: 0x001E4D78 File Offset: 0x001E2F78
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015691 RID: 87697
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkArrowSource.ArrowOrigins vtkArrowSource_GetArrowOrigin_01(HandleRef pThis);

		/// <summary>
		/// Sets and Gets the location used for orienting and scaling the arrow.
		/// Default is set to Default.
		/// </summary>
		// Token: 0x06015692 RID: 87698 RVA: 0x001E4D84 File Offset: 0x001E2F84
		public virtual vtkArrowSource.ArrowOrigins GetArrowOrigin()
		{
			return vtkArrowSource.vtkArrowSource_GetArrowOrigin_01(base.GetCppThis());
		}

		// Token: 0x06015693 RID: 87699
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkArrowSource_GetArrowOriginAsString_02(HandleRef pThis);

		/// <summary>
		/// Sets and Gets the location used for orienting and scaling the arrow.
		/// Default is set to Default.
		/// </summary>
		// Token: 0x06015694 RID: 87700 RVA: 0x001E4DA4 File Offset: 0x001E2FA4
		public string GetArrowOriginAsString()
		{
			return vtkArrowSource.vtkArrowSource_GetArrowOriginAsString_02(base.GetCppThis());
		}

		// Token: 0x06015695 RID: 87701
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkArrowSource_GetInvert_03(HandleRef pThis);

		/// <summary>
		/// Inverts the arrow direction. When set to true, base is at (1, 0, 0) while the
		/// tip is at (0, 0, 0). The default is false, i.e. base at (0, 0, 0) and the tip
		/// at (1, 0, 0).
		/// </summary>
		// Token: 0x06015696 RID: 87702 RVA: 0x001E4DC4 File Offset: 0x001E2FC4
		public virtual bool GetInvert()
		{
			return vtkArrowSource.vtkArrowSource_GetInvert_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06015697 RID: 87703
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrowSource_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct cone with angle of 45 degrees.
		/// </summary>
		// Token: 0x06015698 RID: 87704 RVA: 0x001E4DEC File Offset: 0x001E2FEC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkArrowSource.vtkArrowSource_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06015699 RID: 87705
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrowSource_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct cone with angle of 45 degrees.
		/// </summary>
		// Token: 0x0601569A RID: 87706 RVA: 0x001E4E0C File Offset: 0x001E300C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkArrowSource.vtkArrowSource_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601569B RID: 87707
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArrowSource_GetShaftRadius_06(HandleRef pThis);

		/// <summary>
		/// Set the radius of the shaft.  Defaults to 0.03.
		/// </summary>
		// Token: 0x0601569C RID: 87708 RVA: 0x001E4E28 File Offset: 0x001E3028
		public virtual double GetShaftRadius()
		{
			return vtkArrowSource.vtkArrowSource_GetShaftRadius_06(base.GetCppThis());
		}

		// Token: 0x0601569D RID: 87709
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArrowSource_GetShaftRadiusMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Set the radius of the shaft.  Defaults to 0.03.
		/// </summary>
		// Token: 0x0601569E RID: 87710 RVA: 0x001E4E48 File Offset: 0x001E3048
		public virtual double GetShaftRadiusMaxValue()
		{
			return vtkArrowSource.vtkArrowSource_GetShaftRadiusMaxValue_07(base.GetCppThis());
		}

		// Token: 0x0601569F RID: 87711
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArrowSource_GetShaftRadiusMinValue_08(HandleRef pThis);

		/// <summary>
		/// Set the radius of the shaft.  Defaults to 0.03.
		/// </summary>
		// Token: 0x060156A0 RID: 87712 RVA: 0x001E4E68 File Offset: 0x001E3068
		public virtual double GetShaftRadiusMinValue()
		{
			return vtkArrowSource.vtkArrowSource_GetShaftRadiusMinValue_08(base.GetCppThis());
		}

		// Token: 0x060156A1 RID: 87713
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrowSource_GetShaftResolution_09(HandleRef pThis);

		/// <summary>
		/// Set the resolution of the shaft. Minimum is 3 for a triangular shaft.
		/// </summary>
		// Token: 0x060156A2 RID: 87714 RVA: 0x001E4E88 File Offset: 0x001E3088
		public virtual int GetShaftResolution()
		{
			return vtkArrowSource.vtkArrowSource_GetShaftResolution_09(base.GetCppThis());
		}

		// Token: 0x060156A3 RID: 87715
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrowSource_GetShaftResolutionMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Set the resolution of the shaft. Minimum is 3 for a triangular shaft.
		/// </summary>
		// Token: 0x060156A4 RID: 87716 RVA: 0x001E4EA8 File Offset: 0x001E30A8
		public virtual int GetShaftResolutionMaxValue()
		{
			return vtkArrowSource.vtkArrowSource_GetShaftResolutionMaxValue_10(base.GetCppThis());
		}

		// Token: 0x060156A5 RID: 87717
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrowSource_GetShaftResolutionMinValue_11(HandleRef pThis);

		/// <summary>
		/// Set the resolution of the shaft. Minimum is 3 for a triangular shaft.
		/// </summary>
		// Token: 0x060156A6 RID: 87718 RVA: 0x001E4EC8 File Offset: 0x001E30C8
		public virtual int GetShaftResolutionMinValue()
		{
			return vtkArrowSource.vtkArrowSource_GetShaftResolutionMinValue_11(base.GetCppThis());
		}

		// Token: 0x060156A7 RID: 87719
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArrowSource_GetTipLength_12(HandleRef pThis);

		/// <summary>
		/// Set the length, and radius of the tip.  They default to 0.35 and 0.1
		/// </summary>
		// Token: 0x060156A8 RID: 87720 RVA: 0x001E4EE8 File Offset: 0x001E30E8
		public virtual double GetTipLength()
		{
			return vtkArrowSource.vtkArrowSource_GetTipLength_12(base.GetCppThis());
		}

		// Token: 0x060156A9 RID: 87721
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArrowSource_GetTipLengthMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Set the length, and radius of the tip.  They default to 0.35 and 0.1
		/// </summary>
		// Token: 0x060156AA RID: 87722 RVA: 0x001E4F08 File Offset: 0x001E3108
		public virtual double GetTipLengthMaxValue()
		{
			return vtkArrowSource.vtkArrowSource_GetTipLengthMaxValue_13(base.GetCppThis());
		}

		// Token: 0x060156AB RID: 87723
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArrowSource_GetTipLengthMinValue_14(HandleRef pThis);

		/// <summary>
		/// Set the length, and radius of the tip.  They default to 0.35 and 0.1
		/// </summary>
		// Token: 0x060156AC RID: 87724 RVA: 0x001E4F28 File Offset: 0x001E3128
		public virtual double GetTipLengthMinValue()
		{
			return vtkArrowSource.vtkArrowSource_GetTipLengthMinValue_14(base.GetCppThis());
		}

		// Token: 0x060156AD RID: 87725
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArrowSource_GetTipRadius_15(HandleRef pThis);

		/// <summary>
		/// Set the length, and radius of the tip.  They default to 0.35 and 0.1
		/// </summary>
		// Token: 0x060156AE RID: 87726 RVA: 0x001E4F48 File Offset: 0x001E3148
		public virtual double GetTipRadius()
		{
			return vtkArrowSource.vtkArrowSource_GetTipRadius_15(base.GetCppThis());
		}

		// Token: 0x060156AF RID: 87727
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArrowSource_GetTipRadiusMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Set the length, and radius of the tip.  They default to 0.35 and 0.1
		/// </summary>
		// Token: 0x060156B0 RID: 87728 RVA: 0x001E4F68 File Offset: 0x001E3168
		public virtual double GetTipRadiusMaxValue()
		{
			return vtkArrowSource.vtkArrowSource_GetTipRadiusMaxValue_16(base.GetCppThis());
		}

		// Token: 0x060156B1 RID: 87729
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArrowSource_GetTipRadiusMinValue_17(HandleRef pThis);

		/// <summary>
		/// Set the length, and radius of the tip.  They default to 0.35 and 0.1
		/// </summary>
		// Token: 0x060156B2 RID: 87730 RVA: 0x001E4F88 File Offset: 0x001E3188
		public virtual double GetTipRadiusMinValue()
		{
			return vtkArrowSource.vtkArrowSource_GetTipRadiusMinValue_17(base.GetCppThis());
		}

		// Token: 0x060156B3 RID: 87731
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrowSource_GetTipResolution_18(HandleRef pThis);

		/// <summary>
		/// Set the resolution of the tip.  The tip behaves the same as a cone.
		/// Resolution 1 gives a single triangle, 2 gives two crossed triangles.
		/// </summary>
		// Token: 0x060156B4 RID: 87732 RVA: 0x001E4FA8 File Offset: 0x001E31A8
		public virtual int GetTipResolution()
		{
			return vtkArrowSource.vtkArrowSource_GetTipResolution_18(base.GetCppThis());
		}

		// Token: 0x060156B5 RID: 87733
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrowSource_GetTipResolutionMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Set the resolution of the tip.  The tip behaves the same as a cone.
		/// Resolution 1 gives a single triangle, 2 gives two crossed triangles.
		/// </summary>
		// Token: 0x060156B6 RID: 87734 RVA: 0x001E4FC8 File Offset: 0x001E31C8
		public virtual int GetTipResolutionMaxValue()
		{
			return vtkArrowSource.vtkArrowSource_GetTipResolutionMaxValue_19(base.GetCppThis());
		}

		// Token: 0x060156B7 RID: 87735
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrowSource_GetTipResolutionMinValue_20(HandleRef pThis);

		/// <summary>
		/// Set the resolution of the tip.  The tip behaves the same as a cone.
		/// Resolution 1 gives a single triangle, 2 gives two crossed triangles.
		/// </summary>
		// Token: 0x060156B8 RID: 87736 RVA: 0x001E4FE8 File Offset: 0x001E31E8
		public virtual int GetTipResolutionMinValue()
		{
			return vtkArrowSource.vtkArrowSource_GetTipResolutionMinValue_20(base.GetCppThis());
		}

		// Token: 0x060156B9 RID: 87737
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrowSource_InvertOff_21(HandleRef pThis);

		/// <summary>
		/// Inverts the arrow direction. When set to true, base is at (1, 0, 0) while the
		/// tip is at (0, 0, 0). The default is false, i.e. base at (0, 0, 0) and the tip
		/// at (1, 0, 0).
		/// </summary>
		// Token: 0x060156BA RID: 87738 RVA: 0x001E5007 File Offset: 0x001E3207
		public virtual void InvertOff()
		{
			vtkArrowSource.vtkArrowSource_InvertOff_21(base.GetCppThis());
		}

		// Token: 0x060156BB RID: 87739
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrowSource_InvertOn_22(HandleRef pThis);

		/// <summary>
		/// Inverts the arrow direction. When set to true, base is at (1, 0, 0) while the
		/// tip is at (0, 0, 0). The default is false, i.e. base at (0, 0, 0) and the tip
		/// at (1, 0, 0).
		/// </summary>
		// Token: 0x060156BC RID: 87740 RVA: 0x001E5016 File Offset: 0x001E3216
		public virtual void InvertOn()
		{
			vtkArrowSource.vtkArrowSource_InvertOn_22(base.GetCppThis());
		}

		// Token: 0x060156BD RID: 87741
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrowSource_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct cone with angle of 45 degrees.
		/// </summary>
		// Token: 0x060156BE RID: 87742 RVA: 0x001E5028 File Offset: 0x001E3228
		public override int IsA(string type)
		{
			return vtkArrowSource.vtkArrowSource_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x060156BF RID: 87743
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrowSource_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct cone with angle of 45 degrees.
		/// </summary>
		// Token: 0x060156C0 RID: 87744 RVA: 0x001E5048 File Offset: 0x001E3248
		public new static int IsTypeOf(string type)
		{
			return vtkArrowSource.vtkArrowSource_IsTypeOf_24(type);
		}

		// Token: 0x060156C1 RID: 87745
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrowSource_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct cone with angle of 45 degrees.
		/// </summary>
		// Token: 0x060156C2 RID: 87746 RVA: 0x001E5064 File Offset: 0x001E3264
		public new vtkArrowSource NewInstance()
		{
			vtkArrowSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrowSource.vtkArrowSource_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrowSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060156C3 RID: 87747
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrowSource_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct cone with angle of 45 degrees.
		/// </summary>
		// Token: 0x060156C4 RID: 87748 RVA: 0x001E50C0 File Offset: 0x001E32C0
		public new static vtkArrowSource SafeDownCast(vtkObjectBase o)
		{
			vtkArrowSource vtkArrowSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrowSource.vtkArrowSource_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrowSource = (vtkArrowSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrowSource.Register(null);
				}
			}
			return vtkArrowSource;
		}

		// Token: 0x060156C5 RID: 87749
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrowSource_SetArrowOrigin_28(HandleRef pThis, vtkArrowSource.ArrowOrigins _arg);

		/// <summary>
		/// Sets and Gets the location used for orienting and scaling the arrow.
		/// Default is set to Default.
		/// </summary>
		// Token: 0x060156C6 RID: 87750 RVA: 0x001E513F File Offset: 0x001E333F
		public virtual void SetArrowOrigin(vtkArrowSource.ArrowOrigins _arg)
		{
			vtkArrowSource.vtkArrowSource_SetArrowOrigin_28(base.GetCppThis(), _arg);
		}

		// Token: 0x060156C7 RID: 87751
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrowSource_SetArrowOriginToCenter_29(HandleRef pThis);

		/// <summary>
		/// Sets and Gets the location used for orienting and scaling the arrow.
		/// Default is set to Default.
		/// </summary>
		// Token: 0x060156C8 RID: 87752 RVA: 0x001E514F File Offset: 0x001E334F
		public void SetArrowOriginToCenter()
		{
			vtkArrowSource.vtkArrowSource_SetArrowOriginToCenter_29(base.GetCppThis());
		}

		// Token: 0x060156C9 RID: 87753
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrowSource_SetArrowOriginToDefault_30(HandleRef pThis);

		/// <summary>
		/// Sets and Gets the location used for orienting and scaling the arrow.
		/// Default is set to Default.
		/// </summary>
		// Token: 0x060156CA RID: 87754 RVA: 0x001E515E File Offset: 0x001E335E
		public void SetArrowOriginToDefault()
		{
			vtkArrowSource.vtkArrowSource_SetArrowOriginToDefault_30(base.GetCppThis());
		}

		// Token: 0x060156CB RID: 87755
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrowSource_SetInvert_31(HandleRef pThis, byte _arg);

		/// <summary>
		/// Inverts the arrow direction. When set to true, base is at (1, 0, 0) while the
		/// tip is at (0, 0, 0). The default is false, i.e. base at (0, 0, 0) and the tip
		/// at (1, 0, 0).
		/// </summary>
		// Token: 0x060156CC RID: 87756 RVA: 0x001E516D File Offset: 0x001E336D
		public virtual void SetInvert(bool _arg)
		{
			vtkArrowSource.vtkArrowSource_SetInvert_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060156CD RID: 87757
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrowSource_SetShaftRadius_32(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the radius of the shaft.  Defaults to 0.03.
		/// </summary>
		// Token: 0x060156CE RID: 87758 RVA: 0x001E5185 File Offset: 0x001E3385
		public virtual void SetShaftRadius(double _arg)
		{
			vtkArrowSource.vtkArrowSource_SetShaftRadius_32(base.GetCppThis(), _arg);
		}

		// Token: 0x060156CF RID: 87759
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrowSource_SetShaftResolution_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the resolution of the shaft. Minimum is 3 for a triangular shaft.
		/// </summary>
		// Token: 0x060156D0 RID: 87760 RVA: 0x001E5195 File Offset: 0x001E3395
		public virtual void SetShaftResolution(int _arg)
		{
			vtkArrowSource.vtkArrowSource_SetShaftResolution_33(base.GetCppThis(), _arg);
		}

		// Token: 0x060156D1 RID: 87761
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrowSource_SetTipLength_34(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the length, and radius of the tip.  They default to 0.35 and 0.1
		/// </summary>
		// Token: 0x060156D2 RID: 87762 RVA: 0x001E51A5 File Offset: 0x001E33A5
		public virtual void SetTipLength(double _arg)
		{
			vtkArrowSource.vtkArrowSource_SetTipLength_34(base.GetCppThis(), _arg);
		}

		// Token: 0x060156D3 RID: 87763
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrowSource_SetTipRadius_35(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the length, and radius of the tip.  They default to 0.35 and 0.1
		/// </summary>
		// Token: 0x060156D4 RID: 87764 RVA: 0x001E51B5 File Offset: 0x001E33B5
		public virtual void SetTipRadius(double _arg)
		{
			vtkArrowSource.vtkArrowSource_SetTipRadius_35(base.GetCppThis(), _arg);
		}

		// Token: 0x060156D5 RID: 87765
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrowSource_SetTipResolution_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the resolution of the tip.  The tip behaves the same as a cone.
		/// Resolution 1 gives a single triangle, 2 gives two crossed triangles.
		/// </summary>
		// Token: 0x060156D6 RID: 87766 RVA: 0x001E51C5 File Offset: 0x001E33C5
		public virtual void SetTipResolution(int _arg)
		{
			vtkArrowSource.vtkArrowSource_SetTipResolution_36(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001882 RID: 6274
		public new const string MRFullTypeName = "Kitware.VTK.vtkArrowSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001883 RID: 6275
		public new static readonly string MRClassNameKey = "class vtkArrowSource";

		/// <summary>
		/// Inverts the arrow direction. When set to true, base is at (1, 0, 0) while the
		/// tip is at (0, 0, 0). The default is false, i.e. base at (0, 0, 0) and the tip
		/// at (1, 0, 0).
		/// </summary>
		// Token: 0x0200081E RID: 2078
		public enum ArrowOrigins
		{
			/// <summary>enum member</summary>
			// Token: 0x04001885 RID: 6277
			Center = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001886 RID: 6278
			Default = 0
		}
	}
}
