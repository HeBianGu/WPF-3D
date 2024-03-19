using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProgressBarRepresentation
	/// </summary>
	/// <remarks>
	///    represent a vtkProgressBarWidget
	///
	/// This class is used to represent a vtkProgressBarWidget.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkProgressBarWidget
	/// </seealso>
	// Token: 0x0200035C RID: 860
	public class vtkProgressBarRepresentation : vtkBorderRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009C6A RID: 40042 RVA: 0x000DDA47 File Offset: 0x000DBC47
		static vtkProgressBarRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProgressBarRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProgressBarRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009C6B RID: 40043 RVA: 0x000DDA6F File Offset: 0x000DBC6F
		public vtkProgressBarRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009C6C RID: 40044
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgressBarRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009C6D RID: 40045 RVA: 0x000DDA80 File Offset: 0x000DBC80
		public new static vtkProgressBarRepresentation New()
		{
			vtkProgressBarRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgressBarRepresentation.vtkProgressBarRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgressBarRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009C6E RID: 40046 RVA: 0x000DDAD4 File Offset: 0x000DBCD4
		public vtkProgressBarRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProgressBarRepresentation.vtkProgressBarRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009C6F RID: 40047 RVA: 0x000DDB18 File Offset: 0x000DBD18
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009C70 RID: 40048
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Satisfy the superclasses' API.
		/// </summary>
		// Token: 0x06009C71 RID: 40049 RVA: 0x000DDB23 File Offset: 0x000DBD23
		public override void BuildRepresentation()
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009C72 RID: 40050
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_DrawBackgroundOff_02(HandleRef pThis);

		/// <summary>
		/// Set/Get background visibility
		/// Default is off
		/// </summary>
		// Token: 0x06009C73 RID: 40051 RVA: 0x000DDB32 File Offset: 0x000DBD32
		public virtual void DrawBackgroundOff()
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_DrawBackgroundOff_02(base.GetCppThis());
		}

		// Token: 0x06009C74 RID: 40052
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_DrawBackgroundOn_03(HandleRef pThis);

		/// <summary>
		/// Set/Get background visibility
		/// Default is off
		/// </summary>
		// Token: 0x06009C75 RID: 40053 RVA: 0x000DDB41 File Offset: 0x000DBD41
		public virtual void DrawBackgroundOn()
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_DrawBackgroundOn_03(base.GetCppThis());
		}

		// Token: 0x06009C76 RID: 40054
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_DrawFrameOff_04(HandleRef pThis);

		/// <summary>
		/// Set/Get frame visibility
		/// default is on
		/// </summary>
		// Token: 0x06009C77 RID: 40055 RVA: 0x000DDB50 File Offset: 0x000DBD50
		public virtual void DrawFrameOff()
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_DrawFrameOff_04(base.GetCppThis());
		}

		// Token: 0x06009C78 RID: 40056
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_DrawFrameOn_05(HandleRef pThis);

		/// <summary>
		/// Set/Get frame visibility
		/// default is on
		/// </summary>
		// Token: 0x06009C79 RID: 40057 RVA: 0x000DDB5F File Offset: 0x000DBD5F
		public virtual void DrawFrameOn()
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_DrawFrameOn_05(base.GetCppThis());
		}

		// Token: 0x06009C7A RID: 40058
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_GetActors2D_06(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06009C7B RID: 40059 RVA: 0x000DDB70 File Offset: 0x000DBD70
		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_GetActors2D_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009C7C RID: 40060
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgressBarRepresentation_GetBackgroundColor_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the background color
		/// Default is white
		/// </summary>
		// Token: 0x06009C7D RID: 40061 RVA: 0x000DDBA0 File Offset: 0x000DBDA0
		public virtual double[] GetBackgroundColor()
		{
			IntPtr intPtr = vtkProgressBarRepresentation.vtkProgressBarRepresentation_GetBackgroundColor_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009C7E RID: 40062
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_GetBackgroundColor_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the background color
		/// Default is white
		/// </summary>
		// Token: 0x06009C7F RID: 40063 RVA: 0x000DDBE8 File Offset: 0x000DBDE8
		public virtual void GetBackgroundColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_GetBackgroundColor_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06009C80 RID: 40064
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_GetBackgroundColor_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the background color
		/// Default is white
		/// </summary>
		// Token: 0x06009C81 RID: 40065 RVA: 0x000DDBFA File Offset: 0x000DBDFA
		public virtual void GetBackgroundColor(IntPtr _arg)
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_GetBackgroundColor_09(base.GetCppThis(), _arg);
		}

		// Token: 0x06009C82 RID: 40066
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProgressBarRepresentation_GetDrawBackground_10(HandleRef pThis);

		/// <summary>
		/// Set/Get background visibility
		/// Default is off
		/// </summary>
		// Token: 0x06009C83 RID: 40067 RVA: 0x000DDC0C File Offset: 0x000DBE0C
		public virtual bool GetDrawBackground()
		{
			return vtkProgressBarRepresentation.vtkProgressBarRepresentation_GetDrawBackground_10(base.GetCppThis()) != 0;
		}

		// Token: 0x06009C84 RID: 40068
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProgressBarRepresentation_GetDrawFrame_11(HandleRef pThis);

		/// <summary>
		/// Set/Get frame visibility
		/// default is on
		/// </summary>
		// Token: 0x06009C85 RID: 40069 RVA: 0x000DDC34 File Offset: 0x000DBE34
		public virtual bool GetDrawFrame()
		{
			return vtkProgressBarRepresentation.vtkProgressBarRepresentation_GetDrawFrame_11(base.GetCppThis()) != 0;
		}

		// Token: 0x06009C86 RID: 40070
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgressBarRepresentation_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009C87 RID: 40071 RVA: 0x000DDC5C File Offset: 0x000DBE5C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProgressBarRepresentation.vtkProgressBarRepresentation_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x06009C88 RID: 40072
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgressBarRepresentation_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009C89 RID: 40073 RVA: 0x000DDC7C File Offset: 0x000DBE7C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProgressBarRepresentation.vtkProgressBarRepresentation_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x06009C8A RID: 40074
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgressBarRepresentation_GetPadding_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding between the border and the progressbar.
		/// The padding is expressed in percentage of the border box size
		/// default is 0.017,0.1
		/// </summary>
		// Token: 0x06009C8B RID: 40075 RVA: 0x000DDC98 File Offset: 0x000DBE98
		public virtual double[] GetPadding()
		{
			IntPtr intPtr = vtkProgressBarRepresentation.vtkProgressBarRepresentation_GetPadding_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009C8C RID: 40076
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_GetPadding_15(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set/Get the padding between the border and the progressbar.
		/// The padding is expressed in percentage of the border box size
		/// default is 0.017,0.1
		/// </summary>
		// Token: 0x06009C8D RID: 40077 RVA: 0x000DDCE0 File Offset: 0x000DBEE0
		public virtual void GetPadding(ref double _arg1, ref double _arg2)
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_GetPadding_15(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06009C8E RID: 40078
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_GetPadding_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the padding between the border and the progressbar.
		/// The padding is expressed in percentage of the border box size
		/// default is 0.017,0.1
		/// </summary>
		// Token: 0x06009C8F RID: 40079 RVA: 0x000DDCF1 File Offset: 0x000DBEF1
		public virtual void GetPadding(IntPtr _arg)
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_GetPadding_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06009C90 RID: 40080
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgressBarRepresentation_GetProgressBarColor_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the progress bar color
		/// Default is pure green
		/// </summary>
		// Token: 0x06009C91 RID: 40081 RVA: 0x000DDD04 File Offset: 0x000DBF04
		public virtual double[] GetProgressBarColor()
		{
			IntPtr intPtr = vtkProgressBarRepresentation.vtkProgressBarRepresentation_GetProgressBarColor_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009C92 RID: 40082
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_GetProgressBarColor_18(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the progress bar color
		/// Default is pure green
		/// </summary>
		// Token: 0x06009C93 RID: 40083 RVA: 0x000DDD4C File Offset: 0x000DBF4C
		public virtual void GetProgressBarColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_GetProgressBarColor_18(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06009C94 RID: 40084
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_GetProgressBarColor_19(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the progress bar color
		/// Default is pure green
		/// </summary>
		// Token: 0x06009C95 RID: 40085 RVA: 0x000DDD5E File Offset: 0x000DBF5E
		public virtual void GetProgressBarColor(IntPtr _arg)
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_GetProgressBarColor_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06009C96 RID: 40086
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProgressBarRepresentation_GetProgressRate_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the progress rate of the progress bar, between 0 and 1
		/// default is 0
		/// </summary>
		// Token: 0x06009C97 RID: 40087 RVA: 0x000DDD70 File Offset: 0x000DBF70
		public virtual double GetProgressRate()
		{
			return vtkProgressBarRepresentation.vtkProgressBarRepresentation_GetProgressRate_20(base.GetCppThis());
		}

		// Token: 0x06009C98 RID: 40088
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProgressBarRepresentation_GetProgressRateMaxValue_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the progress rate of the progress bar, between 0 and 1
		/// default is 0
		/// </summary>
		// Token: 0x06009C99 RID: 40089 RVA: 0x000DDD90 File Offset: 0x000DBF90
		public virtual double GetProgressRateMaxValue()
		{
			return vtkProgressBarRepresentation.vtkProgressBarRepresentation_GetProgressRateMaxValue_21(base.GetCppThis());
		}

		// Token: 0x06009C9A RID: 40090
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProgressBarRepresentation_GetProgressRateMinValue_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the progress rate of the progress bar, between 0 and 1
		/// default is 0
		/// </summary>
		// Token: 0x06009C9B RID: 40091 RVA: 0x000DDDB0 File Offset: 0x000DBFB0
		public virtual double GetProgressRateMinValue()
		{
			return vtkProgressBarRepresentation.vtkProgressBarRepresentation_GetProgressRateMinValue_22(base.GetCppThis());
		}

		// Token: 0x06009C9C RID: 40092
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgressBarRepresentation_GetProperty_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// By obtaining this property you can specify the properties of the
		/// representation.
		/// </summary>
		// Token: 0x06009C9D RID: 40093 RVA: 0x000DDDD0 File Offset: 0x000DBFD0
		public virtual vtkProperty2D GetProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgressBarRepresentation.vtkProgressBarRepresentation_GetProperty_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009C9E RID: 40094
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgressBarRepresentation_HasTranslucentPolygonalGeometry_24(HandleRef pThis);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06009C9F RID: 40095 RVA: 0x000DDE40 File Offset: 0x000DC040
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkProgressBarRepresentation.vtkProgressBarRepresentation_HasTranslucentPolygonalGeometry_24(base.GetCppThis());
		}

		// Token: 0x06009CA0 RID: 40096
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgressBarRepresentation_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009CA1 RID: 40097 RVA: 0x000DDE60 File Offset: 0x000DC060
		public override int IsA(string type)
		{
			return vtkProgressBarRepresentation.vtkProgressBarRepresentation_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x06009CA2 RID: 40098
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgressBarRepresentation_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009CA3 RID: 40099 RVA: 0x000DDE80 File Offset: 0x000DC080
		public new static int IsTypeOf(string type)
		{
			return vtkProgressBarRepresentation.vtkProgressBarRepresentation_IsTypeOf_26(type);
		}

		// Token: 0x06009CA4 RID: 40100
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgressBarRepresentation_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009CA5 RID: 40101 RVA: 0x000DDE9C File Offset: 0x000DC09C
		public new vtkProgressBarRepresentation NewInstance()
		{
			vtkProgressBarRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgressBarRepresentation.vtkProgressBarRepresentation_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgressBarRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009CA6 RID: 40102
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_ReleaseGraphicsResources_29(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06009CA7 RID: 40103 RVA: 0x000DDEF8 File Offset: 0x000DC0F8
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_ReleaseGraphicsResources_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009CA8 RID: 40104
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgressBarRepresentation_RenderOpaqueGeometry_30(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06009CA9 RID: 40105 RVA: 0x000DDF28 File Offset: 0x000DC128
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkProgressBarRepresentation.vtkProgressBarRepresentation_RenderOpaqueGeometry_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009CAA RID: 40106
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgressBarRepresentation_RenderOverlay_31(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06009CAB RID: 40107 RVA: 0x000DDF5C File Offset: 0x000DC15C
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkProgressBarRepresentation.vtkProgressBarRepresentation_RenderOverlay_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009CAC RID: 40108
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgressBarRepresentation_RenderTranslucentPolygonalGeometry_32(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06009CAD RID: 40109 RVA: 0x000DDF90 File Offset: 0x000DC190
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkProgressBarRepresentation.vtkProgressBarRepresentation_RenderTranslucentPolygonalGeometry_32(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009CAE RID: 40110
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgressBarRepresentation_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009CAF RID: 40111 RVA: 0x000DDFC4 File Offset: 0x000DC1C4
		public new static vtkProgressBarRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkProgressBarRepresentation vtkProgressBarRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgressBarRepresentation.vtkProgressBarRepresentation_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProgressBarRepresentation = (vtkProgressBarRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProgressBarRepresentation.Register(null);
				}
			}
			return vtkProgressBarRepresentation;
		}

		// Token: 0x06009CB0 RID: 40112
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_SetBackgroundColor_34(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the background color
		/// Default is white
		/// </summary>
		// Token: 0x06009CB1 RID: 40113 RVA: 0x000DE043 File Offset: 0x000DC243
		public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3)
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_SetBackgroundColor_34(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06009CB2 RID: 40114
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_SetBackgroundColor_35(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the background color
		/// Default is white
		/// </summary>
		// Token: 0x06009CB3 RID: 40115 RVA: 0x000DE055 File Offset: 0x000DC255
		public virtual void SetBackgroundColor(IntPtr _arg)
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_SetBackgroundColor_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06009CB4 RID: 40116
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_SetDrawBackground_36(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get background visibility
		/// Default is off
		/// </summary>
		// Token: 0x06009CB5 RID: 40117 RVA: 0x000DE065 File Offset: 0x000DC265
		public virtual void SetDrawBackground(bool _arg)
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_SetDrawBackground_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06009CB6 RID: 40118
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_SetDrawFrame_37(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get frame visibility
		/// default is on
		/// </summary>
		// Token: 0x06009CB7 RID: 40119 RVA: 0x000DE07D File Offset: 0x000DC27D
		public virtual void SetDrawFrame(bool _arg)
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_SetDrawFrame_37(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06009CB8 RID: 40120
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_SetPadding_38(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set/Get the padding between the border and the progressbar.
		/// The padding is expressed in percentage of the border box size
		/// default is 0.017,0.1
		/// </summary>
		// Token: 0x06009CB9 RID: 40121 RVA: 0x000DE095 File Offset: 0x000DC295
		public virtual void SetPadding(double _arg1, double _arg2)
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_SetPadding_38(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06009CBA RID: 40122
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_SetPadding_39(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the padding between the border and the progressbar.
		/// The padding is expressed in percentage of the border box size
		/// default is 0.017,0.1
		/// </summary>
		// Token: 0x06009CBB RID: 40123 RVA: 0x000DE0A6 File Offset: 0x000DC2A6
		public void SetPadding(IntPtr _arg)
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_SetPadding_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06009CBC RID: 40124
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_SetProgressBarColor_40(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the progress bar color
		/// Default is pure green
		/// </summary>
		// Token: 0x06009CBD RID: 40125 RVA: 0x000DE0B6 File Offset: 0x000DC2B6
		public virtual void SetProgressBarColor(double _arg1, double _arg2, double _arg3)
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_SetProgressBarColor_40(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06009CBE RID: 40126
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_SetProgressBarColor_41(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the progress bar color
		/// Default is pure green
		/// </summary>
		// Token: 0x06009CBF RID: 40127 RVA: 0x000DE0C8 File Offset: 0x000DC2C8
		public virtual void SetProgressBarColor(IntPtr _arg)
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_SetProgressBarColor_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06009CC0 RID: 40128
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarRepresentation_SetProgressRate_42(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the progress rate of the progress bar, between 0 and 1
		/// default is 0
		/// </summary>
		// Token: 0x06009CC1 RID: 40129 RVA: 0x000DE0D8 File Offset: 0x000DC2D8
		public virtual void SetProgressRate(double _arg)
		{
			vtkProgressBarRepresentation.vtkProgressBarRepresentation_SetProgressRate_42(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CAB RID: 3243
		public new const string MRFullTypeName = "Kitware.VTK.vtkProgressBarRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CAC RID: 3244
		public new static readonly string MRClassNameKey = "class vtkProgressBarRepresentation";
	}
}
