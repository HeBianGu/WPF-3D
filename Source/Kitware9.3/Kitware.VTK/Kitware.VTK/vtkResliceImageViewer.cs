using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkResliceImageViewer
	/// </summary>
	/// <remarks>
	///    Display an image along with a reslice cursor
	///
	/// This class is similar to vtkImageViewer2. It displays the image along with
	/// a two cross hairs for reslicing. The cross hairs may be interactively
	/// manipulated and are typically used to reslice two other views of
	/// vtkResliceImageViewer. See QtVTKRenderWindows for an example. The reslice
	/// cursor is used to perform thin or thick MPR through data. The class can
	/// also default to the behaviour of vtkImageViewer2 if the Reslice mode is
	/// set to RESLICE_AXIS_ALIGNED.
	/// </remarks>
	/// <seealso>
	///
	/// vtkResliceCursor vtkResliceCursorWidget vtkResliceCursorRepresentation
	/// </seealso>
	// Token: 0x02000230 RID: 560
	public class vtkResliceImageViewer : vtkImageViewer2
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060068F7 RID: 26871 RVA: 0x00097AEE File Offset: 0x00095CEE
		static vtkResliceImageViewer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkResliceImageViewer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkResliceImageViewer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060068F8 RID: 26872 RVA: 0x00097B16 File Offset: 0x00095D16
		public vtkResliceImageViewer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060068F9 RID: 26873
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceImageViewer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x060068FA RID: 26874 RVA: 0x00097B24 File Offset: 0x00095D24
		public new static vtkResliceImageViewer New()
		{
			vtkResliceImageViewer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceImageViewer.vtkResliceImageViewer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResliceImageViewer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x060068FB RID: 26875 RVA: 0x00097B78 File Offset: 0x00095D78
		public vtkResliceImageViewer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkResliceImageViewer.vtkResliceImageViewer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060068FC RID: 26876 RVA: 0x00097BBC File Offset: 0x00095DBC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060068FD RID: 26877
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceImageViewer_GetInteractor_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the render window interactor
		/// </summary>
		// Token: 0x060068FE RID: 26878 RVA: 0x00097BC8 File Offset: 0x00095DC8
		public virtual vtkRenderWindowInteractor GetInteractor()
		{
			vtkRenderWindowInteractor vtkRenderWindowInteractor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceImageViewer.vtkResliceImageViewer_GetInteractor_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindowInteractor = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindowInteractor.Register(null);
				}
			}
			return vtkRenderWindowInteractor;
		}

		// Token: 0x060068FF RID: 26879
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceImageViewer_GetLookupTable_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the lookup table
		/// </summary>
		// Token: 0x06006900 RID: 26880 RVA: 0x00097C38 File Offset: 0x00095E38
		public vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceImageViewer.vtkResliceImageViewer_GetLookupTable_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		// Token: 0x06006901 RID: 26881
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceImageViewer_GetMeasurements_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the measurements manager
		/// </summary>
		// Token: 0x06006902 RID: 26882 RVA: 0x00097CA8 File Offset: 0x00095EA8
		public virtual vtkResliceImageViewerMeasurements GetMeasurements()
		{
			vtkResliceImageViewerMeasurements vtkResliceImageViewerMeasurements = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceImageViewer.vtkResliceImageViewer_GetMeasurements_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResliceImageViewerMeasurements = (vtkResliceImageViewerMeasurements)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResliceImageViewerMeasurements.Register(null);
				}
			}
			return vtkResliceImageViewerMeasurements;
		}

		// Token: 0x06006903 RID: 26883
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResliceImageViewer_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06006904 RID: 26884 RVA: 0x00097D18 File Offset: 0x00095F18
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkResliceImageViewer.vtkResliceImageViewer_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06006905 RID: 26885
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResliceImageViewer_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06006906 RID: 26886 RVA: 0x00097D38 File Offset: 0x00095F38
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkResliceImageViewer.vtkResliceImageViewer_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06006907 RID: 26887
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceImageViewer_GetPointPlacer_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the point placer.
		/// </summary>
		// Token: 0x06006908 RID: 26888 RVA: 0x00097D54 File Offset: 0x00095F54
		public virtual vtkBoundedPlanePointPlacer GetPointPlacer()
		{
			vtkBoundedPlanePointPlacer vtkBoundedPlanePointPlacer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceImageViewer.vtkResliceImageViewer_GetPointPlacer_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBoundedPlanePointPlacer = (vtkBoundedPlanePointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBoundedPlanePointPlacer.Register(null);
				}
			}
			return vtkBoundedPlanePointPlacer;
		}

		// Token: 0x06006909 RID: 26889
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceImageViewer_GetResliceCursor_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the reslice cursor.
		/// </summary>
		// Token: 0x0600690A RID: 26890 RVA: 0x00097DC4 File Offset: 0x00095FC4
		public vtkResliceCursor GetResliceCursor()
		{
			vtkResliceCursor vtkResliceCursor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceImageViewer.vtkResliceImageViewer_GetResliceCursor_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResliceCursor = (vtkResliceCursor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResliceCursor.Register(null);
				}
			}
			return vtkResliceCursor;
		}

		// Token: 0x0600690B RID: 26891
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceImageViewer_GetResliceCursorWidget_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the internal render window, renderer, image actor, and
		/// image map instances.
		/// </summary>
		// Token: 0x0600690C RID: 26892 RVA: 0x00097E34 File Offset: 0x00096034
		public virtual vtkResliceCursorWidget GetResliceCursorWidget()
		{
			vtkResliceCursorWidget vtkResliceCursorWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceImageViewer.vtkResliceImageViewer_GetResliceCursorWidget_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResliceCursorWidget = (vtkResliceCursorWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResliceCursorWidget.Register(null);
				}
			}
			return vtkResliceCursorWidget;
		}

		// Token: 0x0600690D RID: 26893
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceImageViewer_GetResliceMode_09(HandleRef pThis);

		/// <summary>
		/// Set/get the slice orientation
		/// </summary>
		// Token: 0x0600690E RID: 26894 RVA: 0x00097EA4 File Offset: 0x000960A4
		public virtual int GetResliceMode()
		{
			return vtkResliceImageViewer.vtkResliceImageViewer_GetResliceMode_09(base.GetCppThis());
		}

		// Token: 0x0600690F RID: 26895
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkResliceImageViewer_GetSliceScrollFactor_10(HandleRef pThis);

		/// <summary>
		/// Define a factor that will be applied in addition to the inter slice spacing when scrolling
		/// image. When the view is in axis aligned ResliceMode, and the factor is not an integer,
		/// then the new value of the slice will be rounded. Otherwise, the factor is applied
		/// normally. Default value is 1.0.
		/// Note that in axis aligned ResliceMode, the factor is applied in local coordinate (i, j, k),
		/// whereas in oblique ResliceMode, the factor is applied in world coordinate (x, y, z)
		/// </summary>
		// Token: 0x06006910 RID: 26896 RVA: 0x00097EC4 File Offset: 0x000960C4
		public virtual double GetSliceScrollFactor()
		{
			return vtkResliceImageViewer.vtkResliceImageViewer_GetSliceScrollFactor_10(base.GetCppThis());
		}

		// Token: 0x06006911 RID: 26897
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceImageViewer_GetSliceScrollOnMouseWheel_11(HandleRef pThis);

		/// <summary>
		/// Scroll slices on the mouse wheel ? In the case of MPR
		/// view, it moves one "normalized spacing" in the direction of the normal to
		/// the resliced plane, provided the new center will continue to lie within
		/// the volume.
		/// </summary>
		// Token: 0x06006912 RID: 26898 RVA: 0x00097EE4 File Offset: 0x000960E4
		public virtual int GetSliceScrollOnMouseWheel()
		{
			return vtkResliceImageViewer.vtkResliceImageViewer_GetSliceScrollOnMouseWheel_11(base.GetCppThis());
		}

		// Token: 0x06006913 RID: 26899
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceImageViewer_GetThickMode_12(HandleRef pThis);

		/// <summary>
		/// Switch to / from thick mode
		/// </summary>
		// Token: 0x06006914 RID: 26900 RVA: 0x00097F04 File Offset: 0x00096104
		public virtual int GetThickMode()
		{
			return vtkResliceImageViewer.vtkResliceImageViewer_GetThickMode_12(base.GetCppThis());
		}

		// Token: 0x06006915 RID: 26901
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewer_IncrementSlice_13(HandleRef pThis, int inc);

		/// <summary>
		/// Increment/Decrement slice by 'inc' slices
		/// </summary>
		// Token: 0x06006916 RID: 26902 RVA: 0x00097F23 File Offset: 0x00096123
		public virtual void IncrementSlice(int inc)
		{
			vtkResliceImageViewer.vtkResliceImageViewer_IncrementSlice_13(base.GetCppThis(), inc);
		}

		// Token: 0x06006917 RID: 26903
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceImageViewer_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06006918 RID: 26904 RVA: 0x00097F34 File Offset: 0x00096134
		public override int IsA(string type)
		{
			return vtkResliceImageViewer.vtkResliceImageViewer_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06006919 RID: 26905
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceImageViewer_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600691A RID: 26906 RVA: 0x00097F54 File Offset: 0x00096154
		public new static int IsTypeOf(string type)
		{
			return vtkResliceImageViewer.vtkResliceImageViewer_IsTypeOf_15(type);
		}

		// Token: 0x0600691B RID: 26907
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceImageViewer_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600691C RID: 26908 RVA: 0x00097F70 File Offset: 0x00096170
		public new vtkResliceImageViewer NewInstance()
		{
			vtkResliceImageViewer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceImageViewer.vtkResliceImageViewer_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResliceImageViewer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600691D RID: 26909
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewer_Render_18(HandleRef pThis);

		/// <summary>
		/// Render the resulting image.
		/// </summary>
		// Token: 0x0600691E RID: 26910 RVA: 0x00097FCA File Offset: 0x000961CA
		public override void Render()
		{
			vtkResliceImageViewer.vtkResliceImageViewer_Render_18(base.GetCppThis());
		}

		// Token: 0x0600691F RID: 26911
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewer_Reset_19(HandleRef pThis);

		/// <summary>
		/// Reset all views back to initial state
		/// </summary>
		// Token: 0x06006920 RID: 26912 RVA: 0x00097FD9 File Offset: 0x000961D9
		public virtual void Reset()
		{
			vtkResliceImageViewer.vtkResliceImageViewer_Reset_19(base.GetCppThis());
		}

		// Token: 0x06006921 RID: 26913
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceImageViewer_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06006922 RID: 26914 RVA: 0x00097FE8 File Offset: 0x000961E8
		public new static vtkResliceImageViewer SafeDownCast(vtkObjectBase o)
		{
			vtkResliceImageViewer vtkResliceImageViewer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceImageViewer.vtkResliceImageViewer_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResliceImageViewer = (vtkResliceImageViewer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResliceImageViewer.Register(null);
				}
			}
			return vtkResliceImageViewer;
		}

		// Token: 0x06006923 RID: 26915
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewer_SetColorLevel_21(HandleRef pThis, double s);

		/// <summary>
		/// Set window and level for mapping pixels to colors.
		/// </summary>
		// Token: 0x06006924 RID: 26916 RVA: 0x00098067 File Offset: 0x00096267
		public override void SetColorLevel(double s)
		{
			vtkResliceImageViewer.vtkResliceImageViewer_SetColorLevel_21(base.GetCppThis(), s);
		}

		// Token: 0x06006925 RID: 26917
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewer_SetColorWindow_22(HandleRef pThis, double s);

		/// <summary>
		/// Set window and level for mapping pixels to colors.
		/// </summary>
		// Token: 0x06006926 RID: 26918 RVA: 0x00098077 File Offset: 0x00096277
		public override void SetColorWindow(double s)
		{
			vtkResliceImageViewer.vtkResliceImageViewer_SetColorWindow_22(base.GetCppThis(), s);
		}

		// Token: 0x06006927 RID: 26919
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewer_SetInputConnection_23(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set/Get the input image to the viewer.
		/// </summary>
		// Token: 0x06006928 RID: 26920 RVA: 0x00098088 File Offset: 0x00096288
		public override void SetInputConnection(vtkAlgorithmOutput input)
		{
			vtkResliceImageViewer.vtkResliceImageViewer_SetInputConnection_23(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06006929 RID: 26921
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewer_SetInputData_24(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the input image to the viewer.
		/// </summary>
		// Token: 0x0600692A RID: 26922 RVA: 0x000980B8 File Offset: 0x000962B8
		public override void SetInputData(vtkImageData arg0)
		{
			vtkResliceImageViewer.vtkResliceImageViewer_SetInputData_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600692B RID: 26923
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewer_SetLookupTable_25(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the lookup table
		/// </summary>
		// Token: 0x0600692C RID: 26924 RVA: 0x000980E8 File Offset: 0x000962E8
		public virtual void SetLookupTable(vtkScalarsToColors arg0)
		{
			vtkResliceImageViewer.vtkResliceImageViewer_SetLookupTable_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600692D RID: 26925
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewer_SetResliceCursor_26(HandleRef pThis, HandleRef rc);

		/// <summary>
		/// Set/Get the reslice cursor.
		/// </summary>
		// Token: 0x0600692E RID: 26926 RVA: 0x00098118 File Offset: 0x00096318
		public void SetResliceCursor(vtkResliceCursor rc)
		{
			vtkResliceImageViewer.vtkResliceImageViewer_SetResliceCursor_26(base.GetCppThis(), (rc == null) ? default(HandleRef) : rc.GetCppThis());
		}

		// Token: 0x0600692F RID: 26927
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewer_SetResliceMode_27(HandleRef pThis, int resliceMode);

		/// <summary>
		/// Set/get the slice orientation
		/// </summary>
		// Token: 0x06006930 RID: 26928 RVA: 0x00098147 File Offset: 0x00096347
		public virtual void SetResliceMode(int resliceMode)
		{
			vtkResliceImageViewer.vtkResliceImageViewer_SetResliceMode_27(base.GetCppThis(), resliceMode);
		}

		// Token: 0x06006931 RID: 26929
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewer_SetResliceModeToAxisAligned_28(HandleRef pThis);

		/// <summary>
		/// Set/get the slice orientation
		/// </summary>
		// Token: 0x06006932 RID: 26930 RVA: 0x00098157 File Offset: 0x00096357
		public virtual void SetResliceModeToAxisAligned()
		{
			vtkResliceImageViewer.vtkResliceImageViewer_SetResliceModeToAxisAligned_28(base.GetCppThis());
		}

		// Token: 0x06006933 RID: 26931
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewer_SetResliceModeToOblique_29(HandleRef pThis);

		/// <summary>
		/// Set/get the slice orientation
		/// </summary>
		// Token: 0x06006934 RID: 26932 RVA: 0x00098166 File Offset: 0x00096366
		public virtual void SetResliceModeToOblique()
		{
			vtkResliceImageViewer.vtkResliceImageViewer_SetResliceModeToOblique_29(base.GetCppThis());
		}

		// Token: 0x06006935 RID: 26933
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewer_SetSliceScrollFactor_30(HandleRef pThis, double _arg);

		/// <summary>
		/// Define a factor that will be applied in addition to the inter slice spacing when scrolling
		/// image. When the view is in axis aligned ResliceMode, and the factor is not an integer,
		/// then the new value of the slice will be rounded. Otherwise, the factor is applied
		/// normally. Default value is 1.0.
		/// Note that in axis aligned ResliceMode, the factor is applied in local coordinate (i, j, k),
		/// whereas in oblique ResliceMode, the factor is applied in world coordinate (x, y, z)
		/// </summary>
		// Token: 0x06006936 RID: 26934 RVA: 0x00098175 File Offset: 0x00096375
		public virtual void SetSliceScrollFactor(double _arg)
		{
			vtkResliceImageViewer.vtkResliceImageViewer_SetSliceScrollFactor_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06006937 RID: 26935
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewer_SetSliceScrollOnMouseWheel_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Scroll slices on the mouse wheel ? In the case of MPR
		/// view, it moves one "normalized spacing" in the direction of the normal to
		/// the resliced plane, provided the new center will continue to lie within
		/// the volume.
		/// </summary>
		// Token: 0x06006938 RID: 26936 RVA: 0x00098185 File Offset: 0x00096385
		public virtual void SetSliceScrollOnMouseWheel(int _arg)
		{
			vtkResliceImageViewer.vtkResliceImageViewer_SetSliceScrollOnMouseWheel_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06006939 RID: 26937
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewer_SetThickMode_32(HandleRef pThis, int arg0);

		/// <summary>
		/// Switch to / from thick mode
		/// </summary>
		// Token: 0x0600693A RID: 26938 RVA: 0x00098195 File Offset: 0x00096395
		public virtual void SetThickMode(int arg0)
		{
			vtkResliceImageViewer.vtkResliceImageViewer_SetThickMode_32(base.GetCppThis(), arg0);
		}

		// Token: 0x0600693B RID: 26939
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewer_SliceScrollOnMouseWheelOff_33(HandleRef pThis);

		/// <summary>
		/// Scroll slices on the mouse wheel ? In the case of MPR
		/// view, it moves one "normalized spacing" in the direction of the normal to
		/// the resliced plane, provided the new center will continue to lie within
		/// the volume.
		/// </summary>
		// Token: 0x0600693C RID: 26940 RVA: 0x000981A5 File Offset: 0x000963A5
		public virtual void SliceScrollOnMouseWheelOff()
		{
			vtkResliceImageViewer.vtkResliceImageViewer_SliceScrollOnMouseWheelOff_33(base.GetCppThis());
		}

		// Token: 0x0600693D RID: 26941
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewer_SliceScrollOnMouseWheelOn_34(HandleRef pThis);

		/// <summary>
		/// Scroll slices on the mouse wheel ? In the case of MPR
		/// view, it moves one "normalized spacing" in the direction of the normal to
		/// the resliced plane, provided the new center will continue to lie within
		/// the volume.
		/// </summary>
		// Token: 0x0600693E RID: 26942 RVA: 0x000981B4 File Offset: 0x000963B4
		public virtual void SliceScrollOnMouseWheelOn()
		{
			vtkResliceImageViewer.vtkResliceImageViewer_SliceScrollOnMouseWheelOn_34(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000949 RID: 2377
		public new const string MRFullTypeName = "Kitware.VTK.vtkResliceImageViewer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400094A RID: 2378
		public new static readonly string MRClassNameKey = "class vtkResliceImageViewer";

		/// <summary>
		/// Set/get the slice orientation
		/// </summary>
		// Token: 0x02000231 RID: 561
		public enum RESLICE_AXIS_ALIGNED_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400094C RID: 2380
			RESLICE_AXIS_ALIGNED,
			/// <summary>enum member</summary>
			// Token: 0x0400094D RID: 2381
			RESLICE_OBLIQUE
		}

		/// <summary>
		/// Increment/Decrement slice by 'inc' slices
		/// </summary>
		// Token: 0x02000232 RID: 562
		public enum SliceChangedEvent_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400094F RID: 2383
			SliceChangedEvent = 1001
		}
	}
}
