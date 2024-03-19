using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCursor2D
	/// </summary>
	/// <remarks>
	///    generate a 2D cursor representation
	///
	/// vtkCursor2D is a class that generates a 2D cursor representation.
	/// The cursor consists of two intersection axes lines that meet at the
	/// cursor focus. Several optional features are available as well. An
	/// optional 2D bounding box may be enabled. An inner radius, centered at
	/// the focal point, can be set that erases the intersecting lines (e.g.,
	/// it leaves a clear area under the focal point so you can see
	/// what you are selecting). And finally, an optional point can be
	/// enabled located at the focal point. All of these features can be turned
	/// on and off independently.
	///
	/// </remarks>
	// Token: 0x02000889 RID: 2185
	public class vtkCursor2D : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016AEE RID: 92910 RVA: 0x001FE923 File Offset: 0x001FCB23
		static vtkCursor2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCursor2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCursor2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016AEF RID: 92911 RVA: 0x001FE94B File Offset: 0x001FCB4B
		public vtkCursor2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016AF0 RID: 92912
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCursor2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with model bounds = (-10,10,-10,10), focal point = (0,0),
		/// radius=2, all parts of cursor visible, and wrapping off.
		/// </summary>
		// Token: 0x06016AF1 RID: 92913 RVA: 0x001FE95C File Offset: 0x001FCB5C
		public new static vtkCursor2D New()
		{
			vtkCursor2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCursor2D.vtkCursor2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCursor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with model bounds = (-10,10,-10,10), focal point = (0,0),
		/// radius=2, all parts of cursor visible, and wrapping off.
		/// </summary>
		// Token: 0x06016AF2 RID: 92914 RVA: 0x001FE9B0 File Offset: 0x001FCBB0
		public vtkCursor2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCursor2D.vtkCursor2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016AF3 RID: 92915 RVA: 0x001FE9F4 File Offset: 0x001FCBF4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016AF4 RID: 92916
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_AllOff_01(HandleRef pThis);

		/// <summary>
		/// Turn every part of the cursor on or off.
		/// </summary>
		// Token: 0x06016AF5 RID: 92917 RVA: 0x001FE9FF File Offset: 0x001FCBFF
		public void AllOff()
		{
			vtkCursor2D.vtkCursor2D_AllOff_01(base.GetCppThis());
		}

		// Token: 0x06016AF6 RID: 92918
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_AllOn_02(HandleRef pThis);

		/// <summary>
		/// Turn every part of the cursor on or off.
		/// </summary>
		// Token: 0x06016AF7 RID: 92919 RVA: 0x001FEA0E File Offset: 0x001FCC0E
		public void AllOn()
		{
			vtkCursor2D.vtkCursor2D_AllOn_02(base.GetCppThis());
		}

		// Token: 0x06016AF8 RID: 92920
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_AxesOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe axes.
		/// </summary>
		// Token: 0x06016AF9 RID: 92921 RVA: 0x001FEA1D File Offset: 0x001FCC1D
		public virtual void AxesOff()
		{
			vtkCursor2D.vtkCursor2D_AxesOff_03(base.GetCppThis());
		}

		// Token: 0x06016AFA RID: 92922
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_AxesOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe axes.
		/// </summary>
		// Token: 0x06016AFB RID: 92923 RVA: 0x001FEA2C File Offset: 0x001FCC2C
		public virtual void AxesOn()
		{
			vtkCursor2D.vtkCursor2D_AxesOn_04(base.GetCppThis());
		}

		// Token: 0x06016AFC RID: 92924
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCursor2D_GetAxes_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe axes.
		/// </summary>
		// Token: 0x06016AFD RID: 92925 RVA: 0x001FEA3C File Offset: 0x001FCC3C
		public virtual int GetAxes()
		{
			return vtkCursor2D.vtkCursor2D_GetAxes_05(base.GetCppThis());
		}

		// Token: 0x06016AFE RID: 92926
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCursor2D_GetFocalPoint_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of cursor focus. If translation mode is on,
		/// then the entire cursor (including bounding box, cursor, and shadows)
		/// is translated. Otherwise, the focal point will either be clamped to the
		/// bounding box, or wrapped, if Wrap is on. (Note: this behavior requires
		/// that the bounding box is set prior to the focal point.) Note that the
		/// method takes a 3D point but ignores the z-coordinate value.
		/// </summary>
		// Token: 0x06016AFF RID: 92927 RVA: 0x001FEA5C File Offset: 0x001FCC5C
		public virtual double[] GetFocalPoint()
		{
			IntPtr intPtr = vtkCursor2D.vtkCursor2D_GetFocalPoint_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06016B00 RID: 92928
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_GetFocalPoint_07(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the position of cursor focus. If translation mode is on,
		/// then the entire cursor (including bounding box, cursor, and shadows)
		/// is translated. Otherwise, the focal point will either be clamped to the
		/// bounding box, or wrapped, if Wrap is on. (Note: this behavior requires
		/// that the bounding box is set prior to the focal point.) Note that the
		/// method takes a 3D point but ignores the z-coordinate value.
		/// </summary>
		// Token: 0x06016B01 RID: 92929 RVA: 0x001FEAA4 File Offset: 0x001FCCA4
		public virtual void GetFocalPoint(IntPtr data)
		{
			vtkCursor2D.vtkCursor2D_GetFocalPoint_07(base.GetCppThis(), data);
		}

		// Token: 0x06016B02 RID: 92930
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCursor2D_GetModelBounds_08(HandleRef pThis);

		/// <summary>
		/// Set / get the bounding box of the 2D cursor. This defines the outline
		/// of the cursor, and where the focal point should lie.
		/// </summary>
		// Token: 0x06016B03 RID: 92931 RVA: 0x001FEAB4 File Offset: 0x001FCCB4
		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkCursor2D.vtkCursor2D_GetModelBounds_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06016B04 RID: 92932
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_GetModelBounds_09(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / get the bounding box of the 2D cursor. This defines the outline
		/// of the cursor, and where the focal point should lie.
		/// </summary>
		// Token: 0x06016B05 RID: 92933 RVA: 0x001FEAFC File Offset: 0x001FCCFC
		public virtual void GetModelBounds(IntPtr data)
		{
			vtkCursor2D.vtkCursor2D_GetModelBounds_09(base.GetCppThis(), data);
		}

		// Token: 0x06016B06 RID: 92934
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCursor2D_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016B07 RID: 92935 RVA: 0x001FEB0C File Offset: 0x001FCD0C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCursor2D.vtkCursor2D_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06016B08 RID: 92936
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCursor2D_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016B09 RID: 92937 RVA: 0x001FEB2C File Offset: 0x001FCD2C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCursor2D.vtkCursor2D_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06016B0A RID: 92938
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCursor2D_GetOutline_12(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe bounding box.
		/// </summary>
		// Token: 0x06016B0B RID: 92939 RVA: 0x001FEB48 File Offset: 0x001FCD48
		public virtual int GetOutline()
		{
			return vtkCursor2D.vtkCursor2D_GetOutline_12(base.GetCppThis());
		}

		// Token: 0x06016B0C RID: 92940
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCursor2D_GetPoint_13(HandleRef pThis);

		/// <summary>
		/// Turn on/off the point located at the cursor focus.
		/// </summary>
		// Token: 0x06016B0D RID: 92941 RVA: 0x001FEB68 File Offset: 0x001FCD68
		public virtual int GetPoint()
		{
			return vtkCursor2D.vtkCursor2D_GetPoint_13(base.GetCppThis());
		}

		// Token: 0x06016B0E RID: 92942
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCursor2D_GetRadius_14(HandleRef pThis);

		/// <summary>
		/// Specify a radius for a circle. This erases the cursor
		/// lines around the focal point.
		/// </summary>
		// Token: 0x06016B0F RID: 92943 RVA: 0x001FEB88 File Offset: 0x001FCD88
		public virtual double GetRadius()
		{
			return vtkCursor2D.vtkCursor2D_GetRadius_14(base.GetCppThis());
		}

		// Token: 0x06016B10 RID: 92944
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCursor2D_GetRadiusMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Specify a radius for a circle. This erases the cursor
		/// lines around the focal point.
		/// </summary>
		// Token: 0x06016B11 RID: 92945 RVA: 0x001FEBA8 File Offset: 0x001FCDA8
		public virtual double GetRadiusMaxValue()
		{
			return vtkCursor2D.vtkCursor2D_GetRadiusMaxValue_15(base.GetCppThis());
		}

		// Token: 0x06016B12 RID: 92946
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCursor2D_GetRadiusMinValue_16(HandleRef pThis);

		/// <summary>
		/// Specify a radius for a circle. This erases the cursor
		/// lines around the focal point.
		/// </summary>
		// Token: 0x06016B13 RID: 92947 RVA: 0x001FEBC8 File Offset: 0x001FCDC8
		public virtual double GetRadiusMinValue()
		{
			return vtkCursor2D.vtkCursor2D_GetRadiusMinValue_16(base.GetCppThis());
		}

		// Token: 0x06016B14 RID: 92948
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCursor2D_GetTranslationMode_17(HandleRef pThis);

		/// <summary>
		/// Enable/disable the translation mode. If on, changes in cursor position
		/// cause the entire widget to translate along with the cursor.
		/// By default, translation mode is off.
		/// </summary>
		// Token: 0x06016B15 RID: 92949 RVA: 0x001FEBE8 File Offset: 0x001FCDE8
		public virtual int GetTranslationMode()
		{
			return vtkCursor2D.vtkCursor2D_GetTranslationMode_17(base.GetCppThis());
		}

		// Token: 0x06016B16 RID: 92950
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCursor2D_GetWrap_18(HandleRef pThis);

		/// <summary>
		/// Turn on/off cursor wrapping. If the cursor focus moves outside the
		/// specified bounds, the cursor will either be restrained against the
		/// nearest "wall" (Wrap=off), or it will wrap around (Wrap=on).
		/// </summary>
		// Token: 0x06016B17 RID: 92951 RVA: 0x001FEC08 File Offset: 0x001FCE08
		public virtual int GetWrap()
		{
			return vtkCursor2D.vtkCursor2D_GetWrap_18(base.GetCppThis());
		}

		// Token: 0x06016B18 RID: 92952
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCursor2D_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016B19 RID: 92953 RVA: 0x001FEC28 File Offset: 0x001FCE28
		public override int IsA(string type)
		{
			return vtkCursor2D.vtkCursor2D_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x06016B1A RID: 92954
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCursor2D_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016B1B RID: 92955 RVA: 0x001FEC48 File Offset: 0x001FCE48
		public new static int IsTypeOf(string type)
		{
			return vtkCursor2D.vtkCursor2D_IsTypeOf_20(type);
		}

		// Token: 0x06016B1C RID: 92956
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCursor2D_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016B1D RID: 92957 RVA: 0x001FEC64 File Offset: 0x001FCE64
		public new vtkCursor2D NewInstance()
		{
			vtkCursor2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCursor2D.vtkCursor2D_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCursor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016B1E RID: 92958
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_OutlineOff_23(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe bounding box.
		/// </summary>
		// Token: 0x06016B1F RID: 92959 RVA: 0x001FECBE File Offset: 0x001FCEBE
		public virtual void OutlineOff()
		{
			vtkCursor2D.vtkCursor2D_OutlineOff_23(base.GetCppThis());
		}

		// Token: 0x06016B20 RID: 92960
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_OutlineOn_24(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe bounding box.
		/// </summary>
		// Token: 0x06016B21 RID: 92961 RVA: 0x001FECCD File Offset: 0x001FCECD
		public virtual void OutlineOn()
		{
			vtkCursor2D.vtkCursor2D_OutlineOn_24(base.GetCppThis());
		}

		// Token: 0x06016B22 RID: 92962
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_PointOff_25(HandleRef pThis);

		/// <summary>
		/// Turn on/off the point located at the cursor focus.
		/// </summary>
		// Token: 0x06016B23 RID: 92963 RVA: 0x001FECDC File Offset: 0x001FCEDC
		public virtual void PointOff()
		{
			vtkCursor2D.vtkCursor2D_PointOff_25(base.GetCppThis());
		}

		// Token: 0x06016B24 RID: 92964
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_PointOn_26(HandleRef pThis);

		/// <summary>
		/// Turn on/off the point located at the cursor focus.
		/// </summary>
		// Token: 0x06016B25 RID: 92965 RVA: 0x001FECEB File Offset: 0x001FCEEB
		public virtual void PointOn()
		{
			vtkCursor2D.vtkCursor2D_PointOn_26(base.GetCppThis());
		}

		// Token: 0x06016B26 RID: 92966
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCursor2D_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016B27 RID: 92967 RVA: 0x001FECFC File Offset: 0x001FCEFC
		public new static vtkCursor2D SafeDownCast(vtkObjectBase o)
		{
			vtkCursor2D vtkCursor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCursor2D.vtkCursor2D_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCursor2D = (vtkCursor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCursor2D.Register(null);
				}
			}
			return vtkCursor2D;
		}

		// Token: 0x06016B28 RID: 92968
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_SetAxes_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the wireframe axes.
		/// </summary>
		// Token: 0x06016B29 RID: 92969 RVA: 0x001FED7B File Offset: 0x001FCF7B
		public virtual void SetAxes(int _arg)
		{
			vtkCursor2D.vtkCursor2D_SetAxes_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06016B2A RID: 92970
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_SetFocalPoint_29(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Set/Get the position of cursor focus. If translation mode is on,
		/// then the entire cursor (including bounding box, cursor, and shadows)
		/// is translated. Otherwise, the focal point will either be clamped to the
		/// bounding box, or wrapped, if Wrap is on. (Note: this behavior requires
		/// that the bounding box is set prior to the focal point.) Note that the
		/// method takes a 3D point but ignores the z-coordinate value.
		/// </summary>
		// Token: 0x06016B2B RID: 92971 RVA: 0x001FED8B File Offset: 0x001FCF8B
		public void SetFocalPoint(IntPtr x)
		{
			vtkCursor2D.vtkCursor2D_SetFocalPoint_29(base.GetCppThis(), x);
		}

		// Token: 0x06016B2C RID: 92972
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_SetFocalPoint_30(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the position of cursor focus. If translation mode is on,
		/// then the entire cursor (including bounding box, cursor, and shadows)
		/// is translated. Otherwise, the focal point will either be clamped to the
		/// bounding box, or wrapped, if Wrap is on. (Note: this behavior requires
		/// that the bounding box is set prior to the focal point.) Note that the
		/// method takes a 3D point but ignores the z-coordinate value.
		/// </summary>
		// Token: 0x06016B2D RID: 92973 RVA: 0x001FED9B File Offset: 0x001FCF9B
		public void SetFocalPoint(double x, double y, double z)
		{
			vtkCursor2D.vtkCursor2D_SetFocalPoint_30(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06016B2E RID: 92974
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_SetModelBounds_31(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// Set / get the bounding box of the 2D cursor. This defines the outline
		/// of the cursor, and where the focal point should lie.
		/// </summary>
		// Token: 0x06016B2F RID: 92975 RVA: 0x001FEDAD File Offset: 0x001FCFAD
		public void SetModelBounds(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkCursor2D.vtkCursor2D_SetModelBounds_31(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		// Token: 0x06016B30 RID: 92976
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_SetModelBounds_32(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Set / get the bounding box of the 2D cursor. This defines the outline
		/// of the cursor, and where the focal point should lie.
		/// </summary>
		// Token: 0x06016B31 RID: 92977 RVA: 0x001FEDC5 File Offset: 0x001FCFC5
		public void SetModelBounds(IntPtr bounds)
		{
			vtkCursor2D.vtkCursor2D_SetModelBounds_32(base.GetCppThis(), bounds);
		}

		// Token: 0x06016B32 RID: 92978
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_SetOutline_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the wireframe bounding box.
		/// </summary>
		// Token: 0x06016B33 RID: 92979 RVA: 0x001FEDD5 File Offset: 0x001FCFD5
		public virtual void SetOutline(int _arg)
		{
			vtkCursor2D.vtkCursor2D_SetOutline_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06016B34 RID: 92980
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_SetPoint_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the point located at the cursor focus.
		/// </summary>
		// Token: 0x06016B35 RID: 92981 RVA: 0x001FEDE5 File Offset: 0x001FCFE5
		public virtual void SetPoint(int _arg)
		{
			vtkCursor2D.vtkCursor2D_SetPoint_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06016B36 RID: 92982
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_SetRadius_35(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify a radius for a circle. This erases the cursor
		/// lines around the focal point.
		/// </summary>
		// Token: 0x06016B37 RID: 92983 RVA: 0x001FEDF5 File Offset: 0x001FCFF5
		public virtual void SetRadius(double _arg)
		{
			vtkCursor2D.vtkCursor2D_SetRadius_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06016B38 RID: 92984
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_SetTranslationMode_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable the translation mode. If on, changes in cursor position
		/// cause the entire widget to translate along with the cursor.
		/// By default, translation mode is off.
		/// </summary>
		// Token: 0x06016B39 RID: 92985 RVA: 0x001FEE05 File Offset: 0x001FD005
		public virtual void SetTranslationMode(int _arg)
		{
			vtkCursor2D.vtkCursor2D_SetTranslationMode_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06016B3A RID: 92986
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_SetWrap_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off cursor wrapping. If the cursor focus moves outside the
		/// specified bounds, the cursor will either be restrained against the
		/// nearest "wall" (Wrap=off), or it will wrap around (Wrap=on).
		/// </summary>
		// Token: 0x06016B3B RID: 92987 RVA: 0x001FEE15 File Offset: 0x001FD015
		public virtual void SetWrap(int _arg)
		{
			vtkCursor2D.vtkCursor2D_SetWrap_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06016B3C RID: 92988
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_TranslationModeOff_38(HandleRef pThis);

		/// <summary>
		/// Enable/disable the translation mode. If on, changes in cursor position
		/// cause the entire widget to translate along with the cursor.
		/// By default, translation mode is off.
		/// </summary>
		// Token: 0x06016B3D RID: 92989 RVA: 0x001FEE25 File Offset: 0x001FD025
		public virtual void TranslationModeOff()
		{
			vtkCursor2D.vtkCursor2D_TranslationModeOff_38(base.GetCppThis());
		}

		// Token: 0x06016B3E RID: 92990
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_TranslationModeOn_39(HandleRef pThis);

		/// <summary>
		/// Enable/disable the translation mode. If on, changes in cursor position
		/// cause the entire widget to translate along with the cursor.
		/// By default, translation mode is off.
		/// </summary>
		// Token: 0x06016B3F RID: 92991 RVA: 0x001FEE34 File Offset: 0x001FD034
		public virtual void TranslationModeOn()
		{
			vtkCursor2D.vtkCursor2D_TranslationModeOn_39(base.GetCppThis());
		}

		// Token: 0x06016B40 RID: 92992
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_WrapOff_40(HandleRef pThis);

		/// <summary>
		/// Turn on/off cursor wrapping. If the cursor focus moves outside the
		/// specified bounds, the cursor will either be restrained against the
		/// nearest "wall" (Wrap=off), or it will wrap around (Wrap=on).
		/// </summary>
		// Token: 0x06016B41 RID: 92993 RVA: 0x001FEE43 File Offset: 0x001FD043
		public virtual void WrapOff()
		{
			vtkCursor2D.vtkCursor2D_WrapOff_40(base.GetCppThis());
		}

		// Token: 0x06016B42 RID: 92994
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor2D_WrapOn_41(HandleRef pThis);

		/// <summary>
		/// Turn on/off cursor wrapping. If the cursor focus moves outside the
		/// specified bounds, the cursor will either be restrained against the
		/// nearest "wall" (Wrap=off), or it will wrap around (Wrap=on).
		/// </summary>
		// Token: 0x06016B43 RID: 92995 RVA: 0x001FEE52 File Offset: 0x001FD052
		public virtual void WrapOn()
		{
			vtkCursor2D.vtkCursor2D_WrapOn_41(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001973 RID: 6515
		public new const string MRFullTypeName = "Kitware.VTK.vtkCursor2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001974 RID: 6516
		public new static readonly string MRClassNameKey = "class vtkCursor2D";
	}
}
