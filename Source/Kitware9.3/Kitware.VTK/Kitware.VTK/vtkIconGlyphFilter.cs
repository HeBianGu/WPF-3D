using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkIconGlyphFilter
	/// </summary>
	/// <remarks>
	///    Filter that generates a polydata consisting of
	/// quads with texture coordinates referring to a set of icons within a sheet
	/// of icons.
	///
	/// vtkIconGlyphFilter takes in a vtkPointSet where each point corresponds to
	/// the center of an icon. Scalar integer data must also be set to give each
	/// point an icon index. This index is a zero based row major index into an
	/// image that contains a grid of icons (each icon is the same size). You must
	/// also specify 1) the size of the icon in the icon sheet (in pixels), 2) the
	/// size of the icon sheet (in pixels), and 3) the display size of each icon
	/// (again in display coordinates, or pixels).
	///
	/// Various other parameters are used to control how this data is combined. If
	/// UseIconSize is true then the DisplaySize is ignored. If PassScalars is true,
	/// then the scalar index information is passed to the output. Also, there is an
	/// optional IconScale array which, if UseIconScaling is on, will scale each icon
	/// independently.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolyDataAlgorithm vtkGlyph3D vtkGlyph2D
	/// </seealso>
	// Token: 0x020008AD RID: 2221
	public class vtkIconGlyphFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601705E RID: 94302 RVA: 0x002058C7 File Offset: 0x00203AC7
		static vtkIconGlyphFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIconGlyphFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIconGlyphFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601705F RID: 94303 RVA: 0x002058EF File Offset: 0x00203AEF
		public vtkIconGlyphFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017060 RID: 94304
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIconGlyphFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06017061 RID: 94305 RVA: 0x00205900 File Offset: 0x00203B00
		public new static vtkIconGlyphFilter New()
		{
			vtkIconGlyphFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIconGlyphFilter.vtkIconGlyphFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIconGlyphFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06017062 RID: 94306 RVA: 0x00205954 File Offset: 0x00203B54
		public vtkIconGlyphFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkIconGlyphFilter.vtkIconGlyphFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017063 RID: 94307 RVA: 0x00205998 File Offset: 0x00203B98
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017064 RID: 94308
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIconGlyphFilter_GetDisplaySize_01(HandleRef pThis);

		/// <summary>
		/// Specify the Width and Height, in pixels, of the size of the icon when it
		/// is rendered. By default, the IconSize is used to set the display size
		/// (i.e., UseIconSize is true by default). Note that assumes that
		/// IconScaling is disabled, or if enabled, the scale of a particular icon
		/// is 1.
		/// </summary>
		// Token: 0x06017065 RID: 94309 RVA: 0x002059A4 File Offset: 0x00203BA4
		public virtual int[] GetDisplaySize()
		{
			IntPtr intPtr = vtkIconGlyphFilter.vtkIconGlyphFilter_GetDisplaySize_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06017066 RID: 94310
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_GetDisplaySize_02(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the Width and Height, in pixels, of the size of the icon when it
		/// is rendered. By default, the IconSize is used to set the display size
		/// (i.e., UseIconSize is true by default). Note that assumes that
		/// IconScaling is disabled, or if enabled, the scale of a particular icon
		/// is 1.
		/// </summary>
		// Token: 0x06017067 RID: 94311 RVA: 0x002059EC File Offset: 0x00203BEC
		public virtual void GetDisplaySize(IntPtr data)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_GetDisplaySize_02(base.GetCppThis(), data);
		}

		// Token: 0x06017068 RID: 94312
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIconGlyphFilter_GetGravity_03(HandleRef pThis);

		/// <summary>
		/// Specify if the input points define the center of the icon quad or one of
		/// top right corner, top center, top left corner, center right, center, center
		/// center left, bottom right corner, bottom center or bottom left corner.
		/// </summary>
		// Token: 0x06017069 RID: 94313 RVA: 0x002059FC File Offset: 0x00203BFC
		public virtual int GetGravity()
		{
			return vtkIconGlyphFilter.vtkIconGlyphFilter_GetGravity_03(base.GetCppThis());
		}

		// Token: 0x0601706A RID: 94314
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIconGlyphFilter_GetIconScaling_04(HandleRef pThis);

		/// <summary>
		/// Specify how to specify individual icons. By default, icon scaling
		/// is off, but if it is on, then the filter looks for an array named
		/// "IconScale" to control individual icon size.
		/// </summary>
		// Token: 0x0601706B RID: 94315 RVA: 0x00205A1C File Offset: 0x00203C1C
		public virtual int GetIconScaling()
		{
			return vtkIconGlyphFilter.vtkIconGlyphFilter_GetIconScaling_04(base.GetCppThis());
		}

		// Token: 0x0601706C RID: 94316
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIconGlyphFilter_GetIconSheetSize_05(HandleRef pThis);

		/// <summary>
		/// Specify the Width and Height, in pixels, of an icon in the icon sheet.
		/// </summary>
		// Token: 0x0601706D RID: 94317 RVA: 0x00205A3C File Offset: 0x00203C3C
		public virtual int[] GetIconSheetSize()
		{
			IntPtr intPtr = vtkIconGlyphFilter.vtkIconGlyphFilter_GetIconSheetSize_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601706E RID: 94318
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_GetIconSheetSize_06(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the Width and Height, in pixels, of an icon in the icon sheet.
		/// </summary>
		// Token: 0x0601706F RID: 94319 RVA: 0x00205A84 File Offset: 0x00203C84
		public virtual void GetIconSheetSize(IntPtr data)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_GetIconSheetSize_06(base.GetCppThis(), data);
		}

		// Token: 0x06017070 RID: 94320
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIconGlyphFilter_GetIconSize_07(HandleRef pThis);

		/// <summary>
		/// Specify the Width and Height, in pixels, of an icon in the icon sheet.
		/// </summary>
		// Token: 0x06017071 RID: 94321 RVA: 0x00205A94 File Offset: 0x00203C94
		public virtual int[] GetIconSize()
		{
			IntPtr intPtr = vtkIconGlyphFilter.vtkIconGlyphFilter_GetIconSize_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06017072 RID: 94322
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_GetIconSize_08(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the Width and Height, in pixels, of an icon in the icon sheet.
		/// </summary>
		// Token: 0x06017073 RID: 94323 RVA: 0x00205ADC File Offset: 0x00203CDC
		public virtual void GetIconSize(IntPtr data)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_GetIconSize_08(base.GetCppThis(), data);
		}

		// Token: 0x06017074 RID: 94324
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIconGlyphFilter_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06017075 RID: 94325 RVA: 0x00205AEC File Offset: 0x00203CEC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkIconGlyphFilter.vtkIconGlyphFilter_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06017076 RID: 94326
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIconGlyphFilter_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06017077 RID: 94327 RVA: 0x00205B0C File Offset: 0x00203D0C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkIconGlyphFilter.vtkIconGlyphFilter_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06017078 RID: 94328
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIconGlyphFilter_GetOffset_11(HandleRef pThis);

		/// <summary>
		/// Specify an offset (in pixels or display coordinates) that offsets the icons
		/// from their generating points.
		/// </summary>
		// Token: 0x06017079 RID: 94329 RVA: 0x00205B28 File Offset: 0x00203D28
		public virtual int[] GetOffset()
		{
			IntPtr intPtr = vtkIconGlyphFilter.vtkIconGlyphFilter_GetOffset_11(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601707A RID: 94330
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_GetOffset_12(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify an offset (in pixels or display coordinates) that offsets the icons
		/// from their generating points.
		/// </summary>
		// Token: 0x0601707B RID: 94331 RVA: 0x00205B70 File Offset: 0x00203D70
		public virtual void GetOffset(IntPtr data)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_GetOffset_12(base.GetCppThis(), data);
		}

		// Token: 0x0601707C RID: 94332
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIconGlyphFilter_GetPassScalars_13(HandleRef pThis);

		/// <summary>
		/// Specify whether to pass the scalar icon index to the output. By
		/// default this is not passed since it can affect color during the
		/// rendering process. Note that all other point data is passed to
		/// the output regardless of the value of this flag.
		/// </summary>
		// Token: 0x0601707D RID: 94333 RVA: 0x00205B80 File Offset: 0x00203D80
		public virtual bool GetPassScalars()
		{
			return vtkIconGlyphFilter.vtkIconGlyphFilter_GetPassScalars_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0601707E RID: 94334
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIconGlyphFilter_GetUseIconSize_14(HandleRef pThis);

		/// <summary>
		/// Specify whether the Quad generated to place the icon on will be either
		/// the dimensions specified by IconSize or the DisplaySize.
		/// </summary>
		// Token: 0x0601707F RID: 94335 RVA: 0x00205BA8 File Offset: 0x00203DA8
		public virtual bool GetUseIconSize()
		{
			return vtkIconGlyphFilter.vtkIconGlyphFilter_GetUseIconSize_14(base.GetCppThis()) != 0;
		}

		// Token: 0x06017080 RID: 94336
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIconGlyphFilter_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06017081 RID: 94337 RVA: 0x00205BD0 File Offset: 0x00203DD0
		public override int IsA(string type)
		{
			return vtkIconGlyphFilter.vtkIconGlyphFilter_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x06017082 RID: 94338
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIconGlyphFilter_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06017083 RID: 94339 RVA: 0x00205BF0 File Offset: 0x00203DF0
		public new static int IsTypeOf(string type)
		{
			return vtkIconGlyphFilter.vtkIconGlyphFilter_IsTypeOf_16(type);
		}

		// Token: 0x06017084 RID: 94340
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIconGlyphFilter_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06017085 RID: 94341 RVA: 0x00205C0C File Offset: 0x00203E0C
		public new vtkIconGlyphFilter NewInstance()
		{
			vtkIconGlyphFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIconGlyphFilter.vtkIconGlyphFilter_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIconGlyphFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017086 RID: 94342
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_PassScalarsOff_19(HandleRef pThis);

		/// <summary>
		/// Specify whether to pass the scalar icon index to the output. By
		/// default this is not passed since it can affect color during the
		/// rendering process. Note that all other point data is passed to
		/// the output regardless of the value of this flag.
		/// </summary>
		// Token: 0x06017087 RID: 94343 RVA: 0x00205C66 File Offset: 0x00203E66
		public virtual void PassScalarsOff()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_PassScalarsOff_19(base.GetCppThis());
		}

		// Token: 0x06017088 RID: 94344
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_PassScalarsOn_20(HandleRef pThis);

		/// <summary>
		/// Specify whether to pass the scalar icon index to the output. By
		/// default this is not passed since it can affect color during the
		/// rendering process. Note that all other point data is passed to
		/// the output regardless of the value of this flag.
		/// </summary>
		// Token: 0x06017089 RID: 94345 RVA: 0x00205C75 File Offset: 0x00203E75
		public virtual void PassScalarsOn()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_PassScalarsOn_20(base.GetCppThis());
		}

		// Token: 0x0601708A RID: 94346
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIconGlyphFilter_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0601708B RID: 94347 RVA: 0x00205C84 File Offset: 0x00203E84
		public new static vtkIconGlyphFilter SafeDownCast(vtkObjectBase o)
		{
			vtkIconGlyphFilter vtkIconGlyphFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIconGlyphFilter.vtkIconGlyphFilter_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIconGlyphFilter = (vtkIconGlyphFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIconGlyphFilter.Register(null);
				}
			}
			return vtkIconGlyphFilter;
		}

		// Token: 0x0601708C RID: 94348
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetDisplaySize_22(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Specify the Width and Height, in pixels, of the size of the icon when it
		/// is rendered. By default, the IconSize is used to set the display size
		/// (i.e., UseIconSize is true by default). Note that assumes that
		/// IconScaling is disabled, or if enabled, the scale of a particular icon
		/// is 1.
		/// </summary>
		// Token: 0x0601708D RID: 94349 RVA: 0x00205D03 File Offset: 0x00203F03
		public virtual void SetDisplaySize(int _arg1, int _arg2)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetDisplaySize_22(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0601708E RID: 94350
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetDisplaySize_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the Width and Height, in pixels, of the size of the icon when it
		/// is rendered. By default, the IconSize is used to set the display size
		/// (i.e., UseIconSize is true by default). Note that assumes that
		/// IconScaling is disabled, or if enabled, the scale of a particular icon
		/// is 1.
		/// </summary>
		// Token: 0x0601708F RID: 94351 RVA: 0x00205D14 File Offset: 0x00203F14
		public void SetDisplaySize(IntPtr _arg)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetDisplaySize_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06017090 RID: 94352
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetGravity_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify if the input points define the center of the icon quad or one of
		/// top right corner, top center, top left corner, center right, center, center
		/// center left, bottom right corner, bottom center or bottom left corner.
		/// </summary>
		// Token: 0x06017091 RID: 94353 RVA: 0x00205D24 File Offset: 0x00203F24
		public virtual void SetGravity(int _arg)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetGravity_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06017092 RID: 94354
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetGravityToBottomCenter_25(HandleRef pThis);

		/// <summary>
		/// Specify if the input points define the center of the icon quad or one of
		/// top right corner, top center, top left corner, center right, center, center
		/// center left, bottom right corner, bottom center or bottom left corner.
		/// </summary>
		// Token: 0x06017093 RID: 94355 RVA: 0x00205D34 File Offset: 0x00203F34
		public void SetGravityToBottomCenter()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetGravityToBottomCenter_25(base.GetCppThis());
		}

		// Token: 0x06017094 RID: 94356
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetGravityToBottomLeft_26(HandleRef pThis);

		/// <summary>
		/// Specify if the input points define the center of the icon quad or one of
		/// top right corner, top center, top left corner, center right, center, center
		/// center left, bottom right corner, bottom center or bottom left corner.
		/// </summary>
		// Token: 0x06017095 RID: 94357 RVA: 0x00205D43 File Offset: 0x00203F43
		public void SetGravityToBottomLeft()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetGravityToBottomLeft_26(base.GetCppThis());
		}

		// Token: 0x06017096 RID: 94358
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetGravityToBottomRight_27(HandleRef pThis);

		/// <summary>
		/// Specify if the input points define the center of the icon quad or one of
		/// top right corner, top center, top left corner, center right, center, center
		/// center left, bottom right corner, bottom center or bottom left corner.
		/// </summary>
		// Token: 0x06017097 RID: 94359 RVA: 0x00205D52 File Offset: 0x00203F52
		public void SetGravityToBottomRight()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetGravityToBottomRight_27(base.GetCppThis());
		}

		// Token: 0x06017098 RID: 94360
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetGravityToCenterCenter_28(HandleRef pThis);

		/// <summary>
		/// Specify if the input points define the center of the icon quad or one of
		/// top right corner, top center, top left corner, center right, center, center
		/// center left, bottom right corner, bottom center or bottom left corner.
		/// </summary>
		// Token: 0x06017099 RID: 94361 RVA: 0x00205D61 File Offset: 0x00203F61
		public void SetGravityToCenterCenter()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetGravityToCenterCenter_28(base.GetCppThis());
		}

		// Token: 0x0601709A RID: 94362
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetGravityToCenterLeft_29(HandleRef pThis);

		/// <summary>
		/// Specify if the input points define the center of the icon quad or one of
		/// top right corner, top center, top left corner, center right, center, center
		/// center left, bottom right corner, bottom center or bottom left corner.
		/// </summary>
		// Token: 0x0601709B RID: 94363 RVA: 0x00205D70 File Offset: 0x00203F70
		public void SetGravityToCenterLeft()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetGravityToCenterLeft_29(base.GetCppThis());
		}

		// Token: 0x0601709C RID: 94364
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetGravityToCenterRight_30(HandleRef pThis);

		/// <summary>
		/// Specify if the input points define the center of the icon quad or one of
		/// top right corner, top center, top left corner, center right, center, center
		/// center left, bottom right corner, bottom center or bottom left corner.
		/// </summary>
		// Token: 0x0601709D RID: 94365 RVA: 0x00205D7F File Offset: 0x00203F7F
		public void SetGravityToCenterRight()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetGravityToCenterRight_30(base.GetCppThis());
		}

		// Token: 0x0601709E RID: 94366
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetGravityToTopCenter_31(HandleRef pThis);

		/// <summary>
		/// Specify if the input points define the center of the icon quad or one of
		/// top right corner, top center, top left corner, center right, center, center
		/// center left, bottom right corner, bottom center or bottom left corner.
		/// </summary>
		// Token: 0x0601709F RID: 94367 RVA: 0x00205D8E File Offset: 0x00203F8E
		public void SetGravityToTopCenter()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetGravityToTopCenter_31(base.GetCppThis());
		}

		// Token: 0x060170A0 RID: 94368
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetGravityToTopLeft_32(HandleRef pThis);

		/// <summary>
		/// Specify if the input points define the center of the icon quad or one of
		/// top right corner, top center, top left corner, center right, center, center
		/// center left, bottom right corner, bottom center or bottom left corner.
		/// </summary>
		// Token: 0x060170A1 RID: 94369 RVA: 0x00205D9D File Offset: 0x00203F9D
		public void SetGravityToTopLeft()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetGravityToTopLeft_32(base.GetCppThis());
		}

		// Token: 0x060170A2 RID: 94370
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetGravityToTopRight_33(HandleRef pThis);

		/// <summary>
		/// Specify if the input points define the center of the icon quad or one of
		/// top right corner, top center, top left corner, center right, center, center
		/// center left, bottom right corner, bottom center or bottom left corner.
		/// </summary>
		// Token: 0x060170A3 RID: 94371 RVA: 0x00205DAC File Offset: 0x00203FAC
		public void SetGravityToTopRight()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetGravityToTopRight_33(base.GetCppThis());
		}

		// Token: 0x060170A4 RID: 94372
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetIconScaling_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify how to specify individual icons. By default, icon scaling
		/// is off, but if it is on, then the filter looks for an array named
		/// "IconScale" to control individual icon size.
		/// </summary>
		// Token: 0x060170A5 RID: 94373 RVA: 0x00205DBB File Offset: 0x00203FBB
		public virtual void SetIconScaling(int _arg)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetIconScaling_34(base.GetCppThis(), _arg);
		}

		// Token: 0x060170A6 RID: 94374
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetIconScalingToScalingArray_35(HandleRef pThis);

		/// <summary>
		/// Specify how to specify individual icons. By default, icon scaling
		/// is off, but if it is on, then the filter looks for an array named
		/// "IconScale" to control individual icon size.
		/// </summary>
		// Token: 0x060170A7 RID: 94375 RVA: 0x00205DCB File Offset: 0x00203FCB
		public void SetIconScalingToScalingArray()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetIconScalingToScalingArray_35(base.GetCppThis());
		}

		// Token: 0x060170A8 RID: 94376
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetIconScalingToScalingOff_36(HandleRef pThis);

		/// <summary>
		/// Specify how to specify individual icons. By default, icon scaling
		/// is off, but if it is on, then the filter looks for an array named
		/// "IconScale" to control individual icon size.
		/// </summary>
		// Token: 0x060170A9 RID: 94377 RVA: 0x00205DDA File Offset: 0x00203FDA
		public void SetIconScalingToScalingOff()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetIconScalingToScalingOff_36(base.GetCppThis());
		}

		// Token: 0x060170AA RID: 94378
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetIconSheetSize_37(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Specify the Width and Height, in pixels, of an icon in the icon sheet.
		/// </summary>
		// Token: 0x060170AB RID: 94379 RVA: 0x00205DE9 File Offset: 0x00203FE9
		public virtual void SetIconSheetSize(int _arg1, int _arg2)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetIconSheetSize_37(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x060170AC RID: 94380
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetIconSheetSize_38(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the Width and Height, in pixels, of an icon in the icon sheet.
		/// </summary>
		// Token: 0x060170AD RID: 94381 RVA: 0x00205DFA File Offset: 0x00203FFA
		public void SetIconSheetSize(IntPtr _arg)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetIconSheetSize_38(base.GetCppThis(), _arg);
		}

		// Token: 0x060170AE RID: 94382
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetIconSize_39(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Specify the Width and Height, in pixels, of an icon in the icon sheet.
		/// </summary>
		// Token: 0x060170AF RID: 94383 RVA: 0x00205E0A File Offset: 0x0020400A
		public virtual void SetIconSize(int _arg1, int _arg2)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetIconSize_39(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x060170B0 RID: 94384
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetIconSize_40(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the Width and Height, in pixels, of an icon in the icon sheet.
		/// </summary>
		// Token: 0x060170B1 RID: 94385 RVA: 0x00205E1B File Offset: 0x0020401B
		public void SetIconSize(IntPtr _arg)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetIconSize_40(base.GetCppThis(), _arg);
		}

		// Token: 0x060170B2 RID: 94386
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetOffset_41(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Specify an offset (in pixels or display coordinates) that offsets the icons
		/// from their generating points.
		/// </summary>
		// Token: 0x060170B3 RID: 94387 RVA: 0x00205E2B File Offset: 0x0020402B
		public virtual void SetOffset(int _arg1, int _arg2)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetOffset_41(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x060170B4 RID: 94388
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetOffset_42(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify an offset (in pixels or display coordinates) that offsets the icons
		/// from their generating points.
		/// </summary>
		// Token: 0x060170B5 RID: 94389 RVA: 0x00205E3C File Offset: 0x0020403C
		public void SetOffset(IntPtr _arg)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetOffset_42(base.GetCppThis(), _arg);
		}

		// Token: 0x060170B6 RID: 94390
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetPassScalars_43(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether to pass the scalar icon index to the output. By
		/// default this is not passed since it can affect color during the
		/// rendering process. Note that all other point data is passed to
		/// the output regardless of the value of this flag.
		/// </summary>
		// Token: 0x060170B7 RID: 94391 RVA: 0x00205E4C File Offset: 0x0020404C
		public virtual void SetPassScalars(bool _arg)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetPassScalars_43(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060170B8 RID: 94392
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_SetUseIconSize_44(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether the Quad generated to place the icon on will be either
		/// the dimensions specified by IconSize or the DisplaySize.
		/// </summary>
		// Token: 0x060170B9 RID: 94393 RVA: 0x00205E64 File Offset: 0x00204064
		public virtual void SetUseIconSize(bool _arg)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetUseIconSize_44(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060170BA RID: 94394
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_UseIconSizeOff_45(HandleRef pThis);

		/// <summary>
		/// Specify whether the Quad generated to place the icon on will be either
		/// the dimensions specified by IconSize or the DisplaySize.
		/// </summary>
		// Token: 0x060170BB RID: 94395 RVA: 0x00205E7C File Offset: 0x0020407C
		public virtual void UseIconSizeOff()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_UseIconSizeOff_45(base.GetCppThis());
		}

		// Token: 0x060170BC RID: 94396
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIconGlyphFilter_UseIconSizeOn_46(HandleRef pThis);

		/// <summary>
		/// Specify whether the Quad generated to place the icon on will be either
		/// the dimensions specified by IconSize or the DisplaySize.
		/// </summary>
		// Token: 0x060170BD RID: 94397 RVA: 0x00205E8B File Offset: 0x0020408B
		public virtual void UseIconSizeOn()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_UseIconSizeOn_46(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019C0 RID: 6592
		public new const string MRFullTypeName = "Kitware.VTK.vtkIconGlyphFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019C1 RID: 6593
		public new static readonly string MRClassNameKey = "class vtkIconGlyphFilter";
	}
}
