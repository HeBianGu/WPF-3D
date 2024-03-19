using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCursor3D
	/// </summary>
	/// <remarks>
	///    generate a 3D cursor representation
	///
	/// vtkCursor3D is an object that generates a 3D representation of a cursor.
	/// The cursor consists of a wireframe bounding box, three intersecting
	/// axes lines that meet at the cursor focus, and "shadows" or projections
	/// of the axes against the sides of the bounding box. Each of these
	/// components can be turned on/off.
	///
	/// This filter generates two output datasets. The first (Output) is just the
	/// geometric representation of the cursor. The second (Focus) is a single
	/// point at the focal point.
	/// </remarks>
	// Token: 0x0200088A RID: 2186
	public class vtkCursor3D : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016B44 RID: 92996 RVA: 0x001FEE61 File Offset: 0x001FD061
		static vtkCursor3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCursor3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCursor3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016B45 RID: 92997 RVA: 0x001FEE89 File Offset: 0x001FD089
		public vtkCursor3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016B46 RID: 92998
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCursor3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with model bounds = (-1,1,-1,1,-1,1), focal point = (0,0,0),
		/// all parts of cursor visible, and wrapping off.
		/// </summary>
		// Token: 0x06016B47 RID: 92999 RVA: 0x001FEE98 File Offset: 0x001FD098
		public new static vtkCursor3D New()
		{
			vtkCursor3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCursor3D.vtkCursor3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCursor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with model bounds = (-1,1,-1,1,-1,1), focal point = (0,0,0),
		/// all parts of cursor visible, and wrapping off.
		/// </summary>
		// Token: 0x06016B48 RID: 93000 RVA: 0x001FEEEC File Offset: 0x001FD0EC
		public vtkCursor3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCursor3D.vtkCursor3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016B49 RID: 93001 RVA: 0x001FEF30 File Offset: 0x001FD130
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016B4A RID: 93002
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_AllOff_01(HandleRef pThis);

		/// <summary>
		/// Turn every part of the 3D cursor on or off.
		/// </summary>
		// Token: 0x06016B4B RID: 93003 RVA: 0x001FEF3B File Offset: 0x001FD13B
		public void AllOff()
		{
			vtkCursor3D.vtkCursor3D_AllOff_01(base.GetCppThis());
		}

		// Token: 0x06016B4C RID: 93004
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_AllOn_02(HandleRef pThis);

		/// <summary>
		/// Turn every part of the 3D cursor on or off.
		/// </summary>
		// Token: 0x06016B4D RID: 93005 RVA: 0x001FEF4A File Offset: 0x001FD14A
		public void AllOn()
		{
			vtkCursor3D.vtkCursor3D_AllOn_02(base.GetCppThis());
		}

		// Token: 0x06016B4E RID: 93006
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_AxesOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe axes.
		/// </summary>
		// Token: 0x06016B4F RID: 93007 RVA: 0x001FEF59 File Offset: 0x001FD159
		public virtual void AxesOff()
		{
			vtkCursor3D.vtkCursor3D_AxesOff_03(base.GetCppThis());
		}

		// Token: 0x06016B50 RID: 93008
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_AxesOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe axes.
		/// </summary>
		// Token: 0x06016B51 RID: 93009 RVA: 0x001FEF68 File Offset: 0x001FD168
		public virtual void AxesOn()
		{
			vtkCursor3D.vtkCursor3D_AxesOn_04(base.GetCppThis());
		}

		// Token: 0x06016B52 RID: 93010
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCursor3D_GetAxes_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe axes.
		/// </summary>
		// Token: 0x06016B53 RID: 93011 RVA: 0x001FEF78 File Offset: 0x001FD178
		public virtual int GetAxes()
		{
			return vtkCursor3D.vtkCursor3D_GetAxes_05(base.GetCppThis());
		}

		// Token: 0x06016B54 RID: 93012
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCursor3D_GetFocalPoint_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of cursor focus. If translation mode is on,
		/// then the entire cursor (including bounding box, cursor, and shadows)
		/// is translated. Otherwise, the focal point will either be clamped to the
		/// bounding box, or wrapped, if Wrap is on. (Note: this behavior requires
		/// that the bounding box is set prior to the focal point.)
		/// </summary>
		// Token: 0x06016B55 RID: 93013 RVA: 0x001FEF98 File Offset: 0x001FD198
		public virtual double[] GetFocalPoint()
		{
			IntPtr intPtr = vtkCursor3D.vtkCursor3D_GetFocalPoint_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06016B56 RID: 93014
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_GetFocalPoint_07(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the position of cursor focus. If translation mode is on,
		/// then the entire cursor (including bounding box, cursor, and shadows)
		/// is translated. Otherwise, the focal point will either be clamped to the
		/// bounding box, or wrapped, if Wrap is on. (Note: this behavior requires
		/// that the bounding box is set prior to the focal point.)
		/// </summary>
		// Token: 0x06016B57 RID: 93015 RVA: 0x001FEFE0 File Offset: 0x001FD1E0
		public virtual void GetFocalPoint(IntPtr data)
		{
			vtkCursor3D.vtkCursor3D_GetFocalPoint_07(base.GetCppThis(), data);
		}

		// Token: 0x06016B58 RID: 93016
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCursor3D_GetFocus_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the focus for this filter.
		/// </summary>
		// Token: 0x06016B59 RID: 93017 RVA: 0x001FEFF0 File Offset: 0x001FD1F0
		public vtkPolyData GetFocus()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCursor3D.vtkCursor3D_GetFocus_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06016B5A RID: 93018
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCursor3D_GetModelBounds_09(HandleRef pThis);

		/// <summary>
		/// Set / get the boundary of the 3D cursor.
		/// </summary>
		// Token: 0x06016B5B RID: 93019 RVA: 0x001FF060 File Offset: 0x001FD260
		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkCursor3D.vtkCursor3D_GetModelBounds_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06016B5C RID: 93020
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_GetModelBounds_10(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / get the boundary of the 3D cursor.
		/// </summary>
		// Token: 0x06016B5D RID: 93021 RVA: 0x001FF0A8 File Offset: 0x001FD2A8
		public virtual void GetModelBounds(IntPtr data)
		{
			vtkCursor3D.vtkCursor3D_GetModelBounds_10(base.GetCppThis(), data);
		}

		// Token: 0x06016B5E RID: 93022
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCursor3D_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016B5F RID: 93023 RVA: 0x001FF0B8 File Offset: 0x001FD2B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCursor3D.vtkCursor3D_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x06016B60 RID: 93024
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCursor3D_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016B61 RID: 93025 RVA: 0x001FF0D8 File Offset: 0x001FD2D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCursor3D.vtkCursor3D_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x06016B62 RID: 93026
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCursor3D_GetOutline_13(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe bounding box.
		/// </summary>
		// Token: 0x06016B63 RID: 93027 RVA: 0x001FF0F4 File Offset: 0x001FD2F4
		public virtual int GetOutline()
		{
			return vtkCursor3D.vtkCursor3D_GetOutline_13(base.GetCppThis());
		}

		// Token: 0x06016B64 RID: 93028
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCursor3D_GetTranslationMode_14(HandleRef pThis);

		/// <summary>
		/// Enable/disable the translation mode. If on, changes in cursor position
		/// cause the entire widget to translate along with the cursor.
		/// By default, translation mode is off.
		/// </summary>
		// Token: 0x06016B65 RID: 93029 RVA: 0x001FF114 File Offset: 0x001FD314
		public virtual int GetTranslationMode()
		{
			return vtkCursor3D.vtkCursor3D_GetTranslationMode_14(base.GetCppThis());
		}

		// Token: 0x06016B66 RID: 93030
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCursor3D_GetWrap_15(HandleRef pThis);

		/// <summary>
		/// Turn on/off cursor wrapping. If the cursor focus moves outside the
		/// specified bounds, the cursor will either be restrained against the
		/// nearest "wall" (Wrap=off), or it will wrap around (Wrap=on).
		/// </summary>
		// Token: 0x06016B67 RID: 93031 RVA: 0x001FF134 File Offset: 0x001FD334
		public virtual int GetWrap()
		{
			return vtkCursor3D.vtkCursor3D_GetWrap_15(base.GetCppThis());
		}

		// Token: 0x06016B68 RID: 93032
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCursor3D_GetXShadows_16(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe x-shadows.
		/// </summary>
		// Token: 0x06016B69 RID: 93033 RVA: 0x001FF154 File Offset: 0x001FD354
		public virtual int GetXShadows()
		{
			return vtkCursor3D.vtkCursor3D_GetXShadows_16(base.GetCppThis());
		}

		// Token: 0x06016B6A RID: 93034
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCursor3D_GetYShadows_17(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe y-shadows.
		/// </summary>
		// Token: 0x06016B6B RID: 93035 RVA: 0x001FF174 File Offset: 0x001FD374
		public virtual int GetYShadows()
		{
			return vtkCursor3D.vtkCursor3D_GetYShadows_17(base.GetCppThis());
		}

		// Token: 0x06016B6C RID: 93036
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCursor3D_GetZShadows_18(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe z-shadows.
		/// </summary>
		// Token: 0x06016B6D RID: 93037 RVA: 0x001FF194 File Offset: 0x001FD394
		public virtual int GetZShadows()
		{
			return vtkCursor3D.vtkCursor3D_GetZShadows_18(base.GetCppThis());
		}

		// Token: 0x06016B6E RID: 93038
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCursor3D_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016B6F RID: 93039 RVA: 0x001FF1B4 File Offset: 0x001FD3B4
		public override int IsA(string type)
		{
			return vtkCursor3D.vtkCursor3D_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x06016B70 RID: 93040
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCursor3D_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016B71 RID: 93041 RVA: 0x001FF1D4 File Offset: 0x001FD3D4
		public new static int IsTypeOf(string type)
		{
			return vtkCursor3D.vtkCursor3D_IsTypeOf_20(type);
		}

		// Token: 0x06016B72 RID: 93042
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCursor3D_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016B73 RID: 93043 RVA: 0x001FF1F0 File Offset: 0x001FD3F0
		public new vtkCursor3D NewInstance()
		{
			vtkCursor3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCursor3D.vtkCursor3D_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCursor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016B74 RID: 93044
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_OutlineOff_23(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe bounding box.
		/// </summary>
		// Token: 0x06016B75 RID: 93045 RVA: 0x001FF24A File Offset: 0x001FD44A
		public virtual void OutlineOff()
		{
			vtkCursor3D.vtkCursor3D_OutlineOff_23(base.GetCppThis());
		}

		// Token: 0x06016B76 RID: 93046
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_OutlineOn_24(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe bounding box.
		/// </summary>
		// Token: 0x06016B77 RID: 93047 RVA: 0x001FF259 File Offset: 0x001FD459
		public virtual void OutlineOn()
		{
			vtkCursor3D.vtkCursor3D_OutlineOn_24(base.GetCppThis());
		}

		// Token: 0x06016B78 RID: 93048
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCursor3D_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016B79 RID: 93049 RVA: 0x001FF268 File Offset: 0x001FD468
		public new static vtkCursor3D SafeDownCast(vtkObjectBase o)
		{
			vtkCursor3D vtkCursor3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCursor3D.vtkCursor3D_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCursor3D = (vtkCursor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCursor3D.Register(null);
				}
			}
			return vtkCursor3D;
		}

		// Token: 0x06016B7A RID: 93050
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_SetAxes_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the wireframe axes.
		/// </summary>
		// Token: 0x06016B7B RID: 93051 RVA: 0x001FF2E7 File Offset: 0x001FD4E7
		public virtual void SetAxes(int _arg)
		{
			vtkCursor3D.vtkCursor3D_SetAxes_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06016B7C RID: 93052
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_SetFocalPoint_27(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Set/Get the position of cursor focus. If translation mode is on,
		/// then the entire cursor (including bounding box, cursor, and shadows)
		/// is translated. Otherwise, the focal point will either be clamped to the
		/// bounding box, or wrapped, if Wrap is on. (Note: this behavior requires
		/// that the bounding box is set prior to the focal point.)
		/// </summary>
		// Token: 0x06016B7D RID: 93053 RVA: 0x001FF2F7 File Offset: 0x001FD4F7
		public void SetFocalPoint(IntPtr x)
		{
			vtkCursor3D.vtkCursor3D_SetFocalPoint_27(base.GetCppThis(), x);
		}

		// Token: 0x06016B7E RID: 93054
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_SetFocalPoint_28(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the position of cursor focus. If translation mode is on,
		/// then the entire cursor (including bounding box, cursor, and shadows)
		/// is translated. Otherwise, the focal point will either be clamped to the
		/// bounding box, or wrapped, if Wrap is on. (Note: this behavior requires
		/// that the bounding box is set prior to the focal point.)
		/// </summary>
		// Token: 0x06016B7F RID: 93055 RVA: 0x001FF307 File Offset: 0x001FD507
		public void SetFocalPoint(double x, double y, double z)
		{
			vtkCursor3D.vtkCursor3D_SetFocalPoint_28(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06016B80 RID: 93056
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_SetModelBounds_29(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// Set / get the boundary of the 3D cursor.
		/// </summary>
		// Token: 0x06016B81 RID: 93057 RVA: 0x001FF319 File Offset: 0x001FD519
		public void SetModelBounds(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkCursor3D.vtkCursor3D_SetModelBounds_29(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		// Token: 0x06016B82 RID: 93058
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_SetModelBounds_30(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Set / get the boundary of the 3D cursor.
		/// </summary>
		// Token: 0x06016B83 RID: 93059 RVA: 0x001FF331 File Offset: 0x001FD531
		public void SetModelBounds(IntPtr bounds)
		{
			vtkCursor3D.vtkCursor3D_SetModelBounds_30(base.GetCppThis(), bounds);
		}

		// Token: 0x06016B84 RID: 93060
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_SetOutline_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the wireframe bounding box.
		/// </summary>
		// Token: 0x06016B85 RID: 93061 RVA: 0x001FF341 File Offset: 0x001FD541
		public virtual void SetOutline(int _arg)
		{
			vtkCursor3D.vtkCursor3D_SetOutline_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06016B86 RID: 93062
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_SetTranslationMode_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable the translation mode. If on, changes in cursor position
		/// cause the entire widget to translate along with the cursor.
		/// By default, translation mode is off.
		/// </summary>
		// Token: 0x06016B87 RID: 93063 RVA: 0x001FF351 File Offset: 0x001FD551
		public virtual void SetTranslationMode(int _arg)
		{
			vtkCursor3D.vtkCursor3D_SetTranslationMode_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06016B88 RID: 93064
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_SetWrap_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off cursor wrapping. If the cursor focus moves outside the
		/// specified bounds, the cursor will either be restrained against the
		/// nearest "wall" (Wrap=off), or it will wrap around (Wrap=on).
		/// </summary>
		// Token: 0x06016B89 RID: 93065 RVA: 0x001FF361 File Offset: 0x001FD561
		public virtual void SetWrap(int _arg)
		{
			vtkCursor3D.vtkCursor3D_SetWrap_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06016B8A RID: 93066
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_SetXShadows_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the wireframe x-shadows.
		/// </summary>
		// Token: 0x06016B8B RID: 93067 RVA: 0x001FF371 File Offset: 0x001FD571
		public virtual void SetXShadows(int _arg)
		{
			vtkCursor3D.vtkCursor3D_SetXShadows_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06016B8C RID: 93068
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_SetYShadows_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the wireframe y-shadows.
		/// </summary>
		// Token: 0x06016B8D RID: 93069 RVA: 0x001FF381 File Offset: 0x001FD581
		public virtual void SetYShadows(int _arg)
		{
			vtkCursor3D.vtkCursor3D_SetYShadows_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06016B8E RID: 93070
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_SetZShadows_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the wireframe z-shadows.
		/// </summary>
		// Token: 0x06016B8F RID: 93071 RVA: 0x001FF391 File Offset: 0x001FD591
		public virtual void SetZShadows(int _arg)
		{
			vtkCursor3D.vtkCursor3D_SetZShadows_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06016B90 RID: 93072
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_TranslationModeOff_37(HandleRef pThis);

		/// <summary>
		/// Enable/disable the translation mode. If on, changes in cursor position
		/// cause the entire widget to translate along with the cursor.
		/// By default, translation mode is off.
		/// </summary>
		// Token: 0x06016B91 RID: 93073 RVA: 0x001FF3A1 File Offset: 0x001FD5A1
		public virtual void TranslationModeOff()
		{
			vtkCursor3D.vtkCursor3D_TranslationModeOff_37(base.GetCppThis());
		}

		// Token: 0x06016B92 RID: 93074
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_TranslationModeOn_38(HandleRef pThis);

		/// <summary>
		/// Enable/disable the translation mode. If on, changes in cursor position
		/// cause the entire widget to translate along with the cursor.
		/// By default, translation mode is off.
		/// </summary>
		// Token: 0x06016B93 RID: 93075 RVA: 0x001FF3B0 File Offset: 0x001FD5B0
		public virtual void TranslationModeOn()
		{
			vtkCursor3D.vtkCursor3D_TranslationModeOn_38(base.GetCppThis());
		}

		// Token: 0x06016B94 RID: 93076
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_WrapOff_39(HandleRef pThis);

		/// <summary>
		/// Turn on/off cursor wrapping. If the cursor focus moves outside the
		/// specified bounds, the cursor will either be restrained against the
		/// nearest "wall" (Wrap=off), or it will wrap around (Wrap=on).
		/// </summary>
		// Token: 0x06016B95 RID: 93077 RVA: 0x001FF3BF File Offset: 0x001FD5BF
		public virtual void WrapOff()
		{
			vtkCursor3D.vtkCursor3D_WrapOff_39(base.GetCppThis());
		}

		// Token: 0x06016B96 RID: 93078
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_WrapOn_40(HandleRef pThis);

		/// <summary>
		/// Turn on/off cursor wrapping. If the cursor focus moves outside the
		/// specified bounds, the cursor will either be restrained against the
		/// nearest "wall" (Wrap=off), or it will wrap around (Wrap=on).
		/// </summary>
		// Token: 0x06016B97 RID: 93079 RVA: 0x001FF3CE File Offset: 0x001FD5CE
		public virtual void WrapOn()
		{
			vtkCursor3D.vtkCursor3D_WrapOn_40(base.GetCppThis());
		}

		// Token: 0x06016B98 RID: 93080
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_XShadowsOff_41(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe x-shadows.
		/// </summary>
		// Token: 0x06016B99 RID: 93081 RVA: 0x001FF3DD File Offset: 0x001FD5DD
		public virtual void XShadowsOff()
		{
			vtkCursor3D.vtkCursor3D_XShadowsOff_41(base.GetCppThis());
		}

		// Token: 0x06016B9A RID: 93082
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_XShadowsOn_42(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe x-shadows.
		/// </summary>
		// Token: 0x06016B9B RID: 93083 RVA: 0x001FF3EC File Offset: 0x001FD5EC
		public virtual void XShadowsOn()
		{
			vtkCursor3D.vtkCursor3D_XShadowsOn_42(base.GetCppThis());
		}

		// Token: 0x06016B9C RID: 93084
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_YShadowsOff_43(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe y-shadows.
		/// </summary>
		// Token: 0x06016B9D RID: 93085 RVA: 0x001FF3FB File Offset: 0x001FD5FB
		public virtual void YShadowsOff()
		{
			vtkCursor3D.vtkCursor3D_YShadowsOff_43(base.GetCppThis());
		}

		// Token: 0x06016B9E RID: 93086
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_YShadowsOn_44(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe y-shadows.
		/// </summary>
		// Token: 0x06016B9F RID: 93087 RVA: 0x001FF40A File Offset: 0x001FD60A
		public virtual void YShadowsOn()
		{
			vtkCursor3D.vtkCursor3D_YShadowsOn_44(base.GetCppThis());
		}

		// Token: 0x06016BA0 RID: 93088
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_ZShadowsOff_45(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe z-shadows.
		/// </summary>
		// Token: 0x06016BA1 RID: 93089 RVA: 0x001FF419 File Offset: 0x001FD619
		public virtual void ZShadowsOff()
		{
			vtkCursor3D.vtkCursor3D_ZShadowsOff_45(base.GetCppThis());
		}

		// Token: 0x06016BA2 RID: 93090
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCursor3D_ZShadowsOn_46(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe z-shadows.
		/// </summary>
		// Token: 0x06016BA3 RID: 93091 RVA: 0x001FF428 File Offset: 0x001FD628
		public virtual void ZShadowsOn()
		{
			vtkCursor3D.vtkCursor3D_ZShadowsOn_46(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001975 RID: 6517
		public new const string MRFullTypeName = "Kitware.VTK.vtkCursor3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001976 RID: 6518
		public new static readonly string MRClassNameKey = "class vtkCursor3D";
	}
}
