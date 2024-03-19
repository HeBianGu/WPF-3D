using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkResliceCursorRepresentation
	/// </summary>
	/// <remarks>
	///    represent the vtkResliceCursorWidget
	///
	/// This class is the base class for the reslice cursor representation
	/// subclasses. It represents a cursor that may be interactively translated,
	/// rotated through an image and perform thick / thick reformats.
	/// </remarks>
	/// <seealso>
	///
	/// vtkResliceCursorLineRepresentation vtkResliceCursorThickLineRepresentation
	/// vtkResliceCursorWidget vtkResliceCursor
	/// </seealso>
	// Token: 0x02000364 RID: 868
	public abstract class vtkResliceCursorRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009E10 RID: 40464 RVA: 0x000E0003 File Offset: 0x000DE203
		static vtkResliceCursorRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkResliceCursorRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkResliceCursorRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009E11 RID: 40465 RVA: 0x000E002B File Offset: 0x000DE22B
		public vtkResliceCursorRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009E12 RID: 40466 RVA: 0x000E0039 File Offset: 0x000DE239
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009E13 RID: 40467
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_ActivateText_01(HandleRef pThis, int arg0);

		/// <summary>
		/// INTERNAL - Do not use.
		/// Internal methods used by the widget to manage text displays
		/// for annotations.
		/// </summary>
		// Token: 0x06009E14 RID: 40468 RVA: 0x000E0044 File Offset: 0x000DE244
		public void ActivateText(int arg0)
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_ActivateText_01(base.GetCppThis(), arg0);
		}

		// Token: 0x06009E15 RID: 40469
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorRepresentation_BoundPlane_02(IntPtr bounds, IntPtr origin, IntPtr p1, IntPtr p2);

		/// <summary>
		/// Fit the plane defined by origin, p1, p2 onto the bounds.
		/// Plane is untouched if does not intersect bounds.
		/// return 1 if the bounds is intersected, else 0
		/// </summary>
		// Token: 0x06009E16 RID: 40470 RVA: 0x000E0054 File Offset: 0x000DE254
		public static int BoundPlane(IntPtr bounds, IntPtr origin, IntPtr p1, IntPtr p2)
		{
			return vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_BoundPlane_02(bounds, origin, p1, p2);
		}

		// Token: 0x06009E17 RID: 40471
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_BuildRepresentation_03(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06009E18 RID: 40472 RVA: 0x000E0071 File Offset: 0x000DE271
		public override void BuildRepresentation()
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_BuildRepresentation_03(base.GetCppThis());
		}

		// Token: 0x06009E19 RID: 40473
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_DisplayTextOff_04(HandleRef pThis);

		/// <summary>
		/// Enable/disable text display of window-level, image coordinates and
		/// scalar values in a render window.
		/// </summary>
		// Token: 0x06009E1A RID: 40474 RVA: 0x000E0080 File Offset: 0x000DE280
		public virtual void DisplayTextOff()
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_DisplayTextOff_04(base.GetCppThis());
		}

		// Token: 0x06009E1B RID: 40475
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_DisplayTextOn_05(HandleRef pThis);

		/// <summary>
		/// Enable/disable text display of window-level, image coordinates and
		/// scalar values in a render window.
		/// </summary>
		// Token: 0x06009E1C RID: 40476 RVA: 0x000E008F File Offset: 0x000DE28F
		public virtual void DisplayTextOn()
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_DisplayTextOn_05(base.GetCppThis());
		}

		// Token: 0x06009E1D RID: 40477
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorRepresentation_GetColorMap_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience method to get the vtkImageMapToColors filter used by this
		/// widget.  The user can properly render other transparent actors in a
		/// scene by calling the filter's SetOutputFormatToRGB and
		/// PassAlphaToOutputOff.
		/// </summary>
		// Token: 0x06009E1E RID: 40478 RVA: 0x000E00A0 File Offset: 0x000DE2A0
		public virtual vtkImageMapToColors GetColorMap()
		{
			vtkImageMapToColors vtkImageMapToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetColorMap_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009E1F RID: 40479
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorRepresentation_GetCursorAlgorithm_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the underlying cursor source.
		/// </summary>
		// Token: 0x06009E20 RID: 40480 RVA: 0x000E0110 File Offset: 0x000DE310
		public virtual vtkResliceCursorPolyDataAlgorithm GetCursorAlgorithm()
		{
			vtkResliceCursorPolyDataAlgorithm vtkResliceCursorPolyDataAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetCursorAlgorithm_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResliceCursorPolyDataAlgorithm = (vtkResliceCursorPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResliceCursorPolyDataAlgorithm.Register(null);
				}
			}
			return vtkResliceCursorPolyDataAlgorithm;
		}

		// Token: 0x06009E21 RID: 40481
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorRepresentation_GetDisplayText_08(HandleRef pThis);

		/// <summary>
		/// Enable/disable text display of window-level, image coordinates and
		/// scalar values in a render window.
		/// </summary>
		// Token: 0x06009E22 RID: 40482 RVA: 0x000E0180 File Offset: 0x000DE380
		public virtual int GetDisplayText()
		{
			return vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetDisplayText_08(base.GetCppThis());
		}

		// Token: 0x06009E23 RID: 40483
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorRepresentation_GetImageActor_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the displayed image actor
		/// </summary>
		// Token: 0x06009E24 RID: 40484 RVA: 0x000E01A0 File Offset: 0x000DE3A0
		public virtual vtkImageActor GetImageActor()
		{
			vtkImageActor vtkImageActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetImageActor_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009E25 RID: 40485
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkResliceCursorRepresentation_GetLevel_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the current window and level values.  SetWindowLevel should
		/// only be called after SetInput.  If a shared lookup table is being used,
		/// a callback is required to update the window level values without having
		/// to update the lookup table again.
		/// </summary>
		// Token: 0x06009E26 RID: 40486 RVA: 0x000E0210 File Offset: 0x000DE410
		public double GetLevel()
		{
			return vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetLevel_10(base.GetCppThis());
		}

		// Token: 0x06009E27 RID: 40487
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorRepresentation_GetLookupTable_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the internal lookuptable (lut) to one defined by the user, or,
		/// alternatively, to the lut of another Reslice cusror widget.  In this way,
		/// a set of three orthogonal planes can share the same lut so that
		/// window-levelling is performed uniformly among planes.  The default
		/// internal lut can be re- set/allocated by setting to 0 (nullptr).
		/// </summary>
		// Token: 0x06009E28 RID: 40488 RVA: 0x000E0230 File Offset: 0x000DE430
		public virtual vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetLookupTable_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009E29 RID: 40489
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorRepresentation_GetManipulationMode_12(HandleRef pThis);

		/// <summary>
		/// INTERNAL - Do not use
		/// Set the manipulation mode. This is done by the widget
		/// </summary>
		// Token: 0x06009E2A RID: 40490 RVA: 0x000E02A0 File Offset: 0x000DE4A0
		public virtual int GetManipulationMode()
		{
			return vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetManipulationMode_12(base.GetCppThis());
		}

		// Token: 0x06009E2B RID: 40491
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResliceCursorRepresentation_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06009E2C RID: 40492 RVA: 0x000E02C0 File Offset: 0x000DE4C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x06009E2D RID: 40493
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResliceCursorRepresentation_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06009E2E RID: 40494 RVA: 0x000E02E0 File Offset: 0x000DE4E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x06009E2F RID: 40495
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorRepresentation_GetPlaneSource_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plane source on which the texture (the thin/thick resliced
		/// image is displayed)
		/// </summary>
		// Token: 0x06009E30 RID: 40496 RVA: 0x000E02FC File Offset: 0x000DE4FC
		public virtual vtkPlaneSource GetPlaneSource()
		{
			vtkPlaneSource vtkPlaneSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetPlaneSource_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaneSource = (vtkPlaneSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaneSource.Register(null);
				}
			}
			return vtkPlaneSource;
		}

		// Token: 0x06009E31 RID: 40497
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorRepresentation_GetReslice_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the current reslice class and reslice axes
		/// </summary>
		// Token: 0x06009E32 RID: 40498 RVA: 0x000E036C File Offset: 0x000DE56C
		public virtual vtkImageAlgorithm GetReslice()
		{
			vtkImageAlgorithm vtkImageAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetReslice_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageAlgorithm = (vtkImageAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageAlgorithm.Register(null);
				}
			}
			return vtkImageAlgorithm;
		}

		// Token: 0x06009E33 RID: 40499
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorRepresentation_GetResliceAxes_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the current reslice class and reslice axes
		/// </summary>
		// Token: 0x06009E34 RID: 40500 RVA: 0x000E03DC File Offset: 0x000DE5DC
		public virtual vtkMatrix4x4 GetResliceAxes()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetResliceAxes_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x06009E35 RID: 40501
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorRepresentation_GetResliceCursor_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the current window and level values.  SetWindowLevel should
		/// only be called after SetInput.  If a shared lookup table is being used,
		/// a callback is required to update the window level values without having
		/// to update the lookup table again.
		/// </summary>
		// Token: 0x06009E36 RID: 40502 RVA: 0x000E044C File Offset: 0x000DE64C
		public virtual vtkResliceCursor GetResliceCursor()
		{
			vtkResliceCursor vtkResliceCursor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetResliceCursor_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009E37 RID: 40503
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorRepresentation_GetRestrictPlaneToVolume_19(HandleRef pThis);

		/// <summary>
		/// Make sure that the resliced image remains within the volume.
		/// Default is On.
		/// </summary>
		// Token: 0x06009E38 RID: 40504 RVA: 0x000E04BC File Offset: 0x000DE6BC
		public virtual int GetRestrictPlaneToVolume()
		{
			return vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetRestrictPlaneToVolume_19(base.GetCppThis());
		}

		// Token: 0x06009E39 RID: 40505
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorRepresentation_GetShowReslicedImage_20(HandleRef pThis);

		/// <summary>
		/// Show the resliced image ?
		/// </summary>
		// Token: 0x06009E3A RID: 40506 RVA: 0x000E04DC File Offset: 0x000DE6DC
		public virtual int GetShowReslicedImage()
		{
			return vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetShowReslicedImage_20(base.GetCppThis());
		}

		// Token: 0x06009E3B RID: 40507
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorRepresentation_GetTextProperty_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the text property for the image data and window-level annotation.
		/// </summary>
		// Token: 0x06009E3C RID: 40508 RVA: 0x000E04FC File Offset: 0x000DE6FC
		public vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetTextProperty_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x06009E3D RID: 40509
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorRepresentation_GetThicknessLabelFormat_22(HandleRef pThis);

		/// <summary>
		/// Specify the format to use for labelling the distance. Note that an empty
		/// string results in no label, or a format string without a "%" character
		/// will not print the thickness value.
		/// </summary>
		// Token: 0x06009E3E RID: 40510 RVA: 0x000E056C File Offset: 0x000DE76C
		public virtual string GetThicknessLabelFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetThicknessLabelFormat_22(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06009E3F RID: 40511
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorRepresentation_GetThicknessLabelPosition_23(HandleRef pThis);

		/// <summary>
		/// Get the position of the widget's label in display coordinates.
		/// </summary>
		// Token: 0x06009E40 RID: 40512 RVA: 0x000E05A8 File Offset: 0x000DE7A8
		public virtual IntPtr GetThicknessLabelPosition()
		{
			return vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetThicknessLabelPosition_23(base.GetCppThis());
		}

		// Token: 0x06009E41 RID: 40513
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_GetThicknessLabelPosition_24(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Get the position of the widget's label in display coordinates.
		/// </summary>
		// Token: 0x06009E42 RID: 40514 RVA: 0x000E05C7 File Offset: 0x000DE7C7
		public virtual void GetThicknessLabelPosition(IntPtr pos)
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetThicknessLabelPosition_24(base.GetCppThis(), pos);
		}

		// Token: 0x06009E43 RID: 40515
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorRepresentation_GetThicknessLabelText_25(HandleRef pThis);

		/// <summary>
		/// Get the text shown in the widget's label.
		/// </summary>
		// Token: 0x06009E44 RID: 40516 RVA: 0x000E05D8 File Offset: 0x000DE7D8
		public virtual string GetThicknessLabelText()
		{
			string s = Marshal.PtrToStringAnsi(vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetThicknessLabelText_25(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06009E45 RID: 40517
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorRepresentation_GetTolerance_26(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the representation (in
		/// pixels) in which the cursor is considered near enough to the
		/// representation to be active.
		/// </summary>
		// Token: 0x06009E46 RID: 40518 RVA: 0x000E0614 File Offset: 0x000DE814
		public virtual int GetTolerance()
		{
			return vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetTolerance_26(base.GetCppThis());
		}

		// Token: 0x06009E47 RID: 40519
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorRepresentation_GetToleranceMaxValue_27(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the representation (in
		/// pixels) in which the cursor is considered near enough to the
		/// representation to be active.
		/// </summary>
		// Token: 0x06009E48 RID: 40520 RVA: 0x000E0634 File Offset: 0x000DE834
		public virtual int GetToleranceMaxValue()
		{
			return vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetToleranceMaxValue_27(base.GetCppThis());
		}

		// Token: 0x06009E49 RID: 40521
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorRepresentation_GetToleranceMinValue_28(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the representation (in
		/// pixels) in which the cursor is considered near enough to the
		/// representation to be active.
		/// </summary>
		// Token: 0x06009E4A RID: 40522 RVA: 0x000E0654 File Offset: 0x000DE854
		public virtual int GetToleranceMinValue()
		{
			return vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetToleranceMinValue_28(base.GetCppThis());
		}

		// Token: 0x06009E4B RID: 40523
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorRepresentation_GetUseImageActor_29(HandleRef pThis);

		/// <summary>
		/// Render as a 2D image, or render as a plane with a texture in physical
		/// space.
		/// </summary>
		// Token: 0x06009E4C RID: 40524 RVA: 0x000E0674 File Offset: 0x000DE874
		public virtual int GetUseImageActor()
		{
			return vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetUseImageActor_29(base.GetCppThis());
		}

		// Token: 0x06009E4D RID: 40525
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkResliceCursorRepresentation_GetWindow_30(HandleRef pThis);

		/// <summary>
		/// Set/Get the current window and level values.  SetWindowLevel should
		/// only be called after SetInput.  If a shared lookup table is being used,
		/// a callback is required to update the window level values without having
		/// to update the lookup table again.
		/// </summary>
		// Token: 0x06009E4E RID: 40526 RVA: 0x000E0694 File Offset: 0x000DE894
		public double GetWindow()
		{
			return vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetWindow_30(base.GetCppThis());
		}

		// Token: 0x06009E4F RID: 40527
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_GetWindowLevel_31(HandleRef pThis, IntPtr wl);

		/// <summary>
		/// Set/Get the current window and level values.  SetWindowLevel should
		/// only be called after SetInput.  If a shared lookup table is being used,
		/// a callback is required to update the window level values without having
		/// to update the lookup table again.
		/// </summary>
		// Token: 0x06009E50 RID: 40528 RVA: 0x000E06B3 File Offset: 0x000DE8B3
		public void GetWindowLevel(IntPtr wl)
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetWindowLevel_31(base.GetCppThis(), wl);
		}

		// Token: 0x06009E51 RID: 40529
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_GetWorldThicknessLabelPosition_32(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Get the position of the widget's label in display coordinates.
		/// </summary>
		// Token: 0x06009E52 RID: 40530 RVA: 0x000E06C3 File Offset: 0x000DE8C3
		public virtual void GetWorldThicknessLabelPosition(IntPtr pos)
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_GetWorldThicknessLabelPosition_32(base.GetCppThis(), pos);
		}

		// Token: 0x06009E53 RID: 40531
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_InitializeReslicePlane_33(HandleRef pThis);

		/// <summary>
		/// Initialize the reslice planes and the camera center. This is done
		/// automatically, the first time we render.
		/// </summary>
		// Token: 0x06009E54 RID: 40532 RVA: 0x000E06D3 File Offset: 0x000DE8D3
		public virtual void InitializeReslicePlane()
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_InitializeReslicePlane_33(base.GetCppThis());
		}

		// Token: 0x06009E55 RID: 40533
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorRepresentation_IsA_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06009E56 RID: 40534 RVA: 0x000E06E4 File Offset: 0x000DE8E4
		public override int IsA(string type)
		{
			return vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_IsA_34(base.GetCppThis(), type);
		}

		// Token: 0x06009E57 RID: 40535
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorRepresentation_IsTypeOf_35([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06009E58 RID: 40536 RVA: 0x000E0704 File Offset: 0x000DE904
		public new static int IsTypeOf(string type)
		{
			return vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_IsTypeOf_35(type);
		}

		// Token: 0x06009E59 RID: 40537
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_ManageTextDisplay_36(HandleRef pThis);

		/// <summary>
		/// INTERNAL - Do not use.
		/// Internal methods used by the widget to manage text displays
		/// for annotations.
		/// </summary>
		// Token: 0x06009E5A RID: 40538 RVA: 0x000E071E File Offset: 0x000DE91E
		public void ManageTextDisplay()
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_ManageTextDisplay_36(base.GetCppThis());
		}

		// Token: 0x06009E5B RID: 40539
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorRepresentation_NewInstance_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06009E5C RID: 40540 RVA: 0x000E0730 File Offset: 0x000DE930
		public new vtkResliceCursorRepresentation NewInstance()
		{
			vtkResliceCursorRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_NewInstance_37(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResliceCursorRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009E5D RID: 40541
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_ResetCamera_38(HandleRef pThis);

		/// <summary>
		/// Initialize the reslice planes and the camera center. This is done
		/// automatically, the first time we render.
		/// </summary>
		// Token: 0x06009E5E RID: 40542 RVA: 0x000E078A File Offset: 0x000DE98A
		public virtual void ResetCamera()
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_ResetCamera_38(base.GetCppThis());
		}

		// Token: 0x06009E5F RID: 40543
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_RestrictPlaneToVolumeOff_39(HandleRef pThis);

		/// <summary>
		/// Make sure that the resliced image remains within the volume.
		/// Default is On.
		/// </summary>
		// Token: 0x06009E60 RID: 40544 RVA: 0x000E0799 File Offset: 0x000DE999
		public virtual void RestrictPlaneToVolumeOff()
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_RestrictPlaneToVolumeOff_39(base.GetCppThis());
		}

		// Token: 0x06009E61 RID: 40545
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_RestrictPlaneToVolumeOn_40(HandleRef pThis);

		/// <summary>
		/// Make sure that the resliced image remains within the volume.
		/// Default is On.
		/// </summary>
		// Token: 0x06009E62 RID: 40546 RVA: 0x000E07A8 File Offset: 0x000DE9A8
		public virtual void RestrictPlaneToVolumeOn()
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_RestrictPlaneToVolumeOn_40(base.GetCppThis());
		}

		// Token: 0x06009E63 RID: 40547
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorRepresentation_SafeDownCast_41(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06009E64 RID: 40548 RVA: 0x000E07B8 File Offset: 0x000DE9B8
		public new static vtkResliceCursorRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkResliceCursorRepresentation vtkResliceCursorRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_SafeDownCast_41((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResliceCursorRepresentation = (vtkResliceCursorRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResliceCursorRepresentation.Register(null);
				}
			}
			return vtkResliceCursorRepresentation;
		}

		// Token: 0x06009E65 RID: 40549
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_SetColorMap_42(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Convenience method to get the vtkImageMapToColors filter used by this
		/// widget.  The user can properly render other transparent actors in a
		/// scene by calling the filter's SetOutputFormatToRGB and
		/// PassAlphaToOutputOff.
		/// </summary>
		// Token: 0x06009E66 RID: 40550 RVA: 0x000E0838 File Offset: 0x000DEA38
		public virtual void SetColorMap(vtkImageMapToColors arg0)
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_SetColorMap_42(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009E67 RID: 40551
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_SetDisplayText_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable text display of window-level, image coordinates and
		/// scalar values in a render window.
		/// </summary>
		// Token: 0x06009E68 RID: 40552 RVA: 0x000E0867 File Offset: 0x000DEA67
		public virtual void SetDisplayText(int _arg)
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_SetDisplayText_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06009E69 RID: 40553
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_SetLookupTable_44(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the internal lookuptable (lut) to one defined by the user, or,
		/// alternatively, to the lut of another Reslice cusror widget.  In this way,
		/// a set of three orthogonal planes can share the same lut so that
		/// window-levelling is performed uniformly among planes.  The default
		/// internal lut can be re- set/allocated by setting to 0 (nullptr).
		/// </summary>
		// Token: 0x06009E6A RID: 40554 RVA: 0x000E0878 File Offset: 0x000DEA78
		public virtual void SetLookupTable(vtkScalarsToColors arg0)
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_SetLookupTable_44(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009E6B RID: 40555
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_SetManipulationMode_45(HandleRef pThis, int m);

		/// <summary>
		/// INTERNAL - Do not use
		/// Set the manipulation mode. This is done by the widget
		/// </summary>
		// Token: 0x06009E6C RID: 40556 RVA: 0x000E08A7 File Offset: 0x000DEAA7
		public void SetManipulationMode(int m)
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_SetManipulationMode_45(base.GetCppThis(), m);
		}

		// Token: 0x06009E6D RID: 40557
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_SetRestrictPlaneToVolume_46(HandleRef pThis, int _arg);

		/// <summary>
		/// Make sure that the resliced image remains within the volume.
		/// Default is On.
		/// </summary>
		// Token: 0x06009E6E RID: 40558 RVA: 0x000E08B7 File Offset: 0x000DEAB7
		public virtual void SetRestrictPlaneToVolume(int _arg)
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_SetRestrictPlaneToVolume_46(base.GetCppThis(), _arg);
		}

		// Token: 0x06009E6F RID: 40559
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_SetShowReslicedImage_47(HandleRef pThis, int _arg);

		/// <summary>
		/// Show the resliced image ?
		/// </summary>
		// Token: 0x06009E70 RID: 40560 RVA: 0x000E08C7 File Offset: 0x000DEAC7
		public virtual void SetShowReslicedImage(int _arg)
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_SetShowReslicedImage_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06009E71 RID: 40561
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_SetTextProperty_48(HandleRef pThis, HandleRef tprop);

		/// <summary>
		/// Set/Get the text property for the image data and window-level annotation.
		/// </summary>
		// Token: 0x06009E72 RID: 40562 RVA: 0x000E08D8 File Offset: 0x000DEAD8
		public void SetTextProperty(vtkTextProperty tprop)
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_SetTextProperty_48(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis());
		}

		// Token: 0x06009E73 RID: 40563
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_SetThicknessLabelFormat_49(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the format to use for labelling the distance. Note that an empty
		/// string results in no label, or a format string without a "%" character
		/// will not print the thickness value.
		/// </summary>
		// Token: 0x06009E74 RID: 40564 RVA: 0x000E0907 File Offset: 0x000DEB07
		public virtual void SetThicknessLabelFormat(string _arg)
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_SetThicknessLabelFormat_49(base.GetCppThis(), _arg);
		}

		// Token: 0x06009E75 RID: 40565
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_SetTolerance_50(HandleRef pThis, int _arg);

		/// <summary>
		/// The tolerance representing the distance to the representation (in
		/// pixels) in which the cursor is considered near enough to the
		/// representation to be active.
		/// </summary>
		// Token: 0x06009E76 RID: 40566 RVA: 0x000E0917 File Offset: 0x000DEB17
		public virtual void SetTolerance(int _arg)
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_SetTolerance_50(base.GetCppThis(), _arg);
		}

		// Token: 0x06009E77 RID: 40567
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_SetUseImageActor_51(HandleRef pThis, int _arg);

		/// <summary>
		/// Render as a 2D image, or render as a plane with a texture in physical
		/// space.
		/// </summary>
		// Token: 0x06009E78 RID: 40568 RVA: 0x000E0927 File Offset: 0x000DEB27
		public virtual void SetUseImageActor(int _arg)
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_SetUseImageActor_51(base.GetCppThis(), _arg);
		}

		// Token: 0x06009E79 RID: 40569
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_SetWindowLevel_52(HandleRef pThis, double window, double level, int copy);

		/// <summary>
		/// Set/Get the current window and level values.  SetWindowLevel should
		/// only be called after SetInput.  If a shared lookup table is being used,
		/// a callback is required to update the window level values without having
		/// to update the lookup table again.
		/// </summary>
		// Token: 0x06009E7A RID: 40570 RVA: 0x000E0937 File Offset: 0x000DEB37
		public void SetWindowLevel(double window, double level, int copy)
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_SetWindowLevel_52(base.GetCppThis(), window, level, copy);
		}

		// Token: 0x06009E7B RID: 40571
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_ShowReslicedImageOff_53(HandleRef pThis);

		/// <summary>
		/// Show the resliced image ?
		/// </summary>
		// Token: 0x06009E7C RID: 40572 RVA: 0x000E0949 File Offset: 0x000DEB49
		public virtual void ShowReslicedImageOff()
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_ShowReslicedImageOff_53(base.GetCppThis());
		}

		// Token: 0x06009E7D RID: 40573
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_ShowReslicedImageOn_54(HandleRef pThis);

		/// <summary>
		/// Show the resliced image ?
		/// </summary>
		// Token: 0x06009E7E RID: 40574 RVA: 0x000E0958 File Offset: 0x000DEB58
		public virtual void ShowReslicedImageOn()
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_ShowReslicedImageOn_54(base.GetCppThis());
		}

		// Token: 0x06009E7F RID: 40575
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_TransformPlane_55(HandleRef planeToTransform, IntPtr targetCenter, IntPtr targetNormal, IntPtr targetViewUp);

		/// <summary>
		/// First rotate planeToTransform to match targetPlane normal.
		/// Then rotate around targetNormal to enforce targetViewUp "up" vector (i.e. Origin-&gt;p2 ).
		/// There is an infinite number of options to rotate a plane normal to another. Here we attempt to
		/// preserve Origin, P1 and P2 when rotating around targetPlane.
		/// </summary>
		// Token: 0x06009E80 RID: 40576 RVA: 0x000E0968 File Offset: 0x000DEB68
		public static void TransformPlane(vtkPlaneSource planeToTransform, IntPtr targetCenter, IntPtr targetNormal, IntPtr targetViewUp)
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_TransformPlane_55((planeToTransform == null) ? default(HandleRef) : planeToTransform.GetCppThis(), targetCenter, targetNormal, targetViewUp);
		}

		// Token: 0x06009E81 RID: 40577
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_UseImageActorOff_56(HandleRef pThis);

		/// <summary>
		/// Render as a 2D image, or render as a plane with a texture in physical
		/// space.
		/// </summary>
		// Token: 0x06009E82 RID: 40578 RVA: 0x000E0994 File Offset: 0x000DEB94
		public virtual void UseImageActorOff()
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_UseImageActorOff_56(base.GetCppThis());
		}

		// Token: 0x06009E83 RID: 40579
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorRepresentation_UseImageActorOn_57(HandleRef pThis);

		/// <summary>
		/// Render as a 2D image, or render as a plane with a texture in physical
		/// space.
		/// </summary>
		// Token: 0x06009E84 RID: 40580 RVA: 0x000E09A3 File Offset: 0x000DEBA3
		public virtual void UseImageActorOn()
		{
			vtkResliceCursorRepresentation.vtkResliceCursorRepresentation_UseImageActorOn_57(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CBE RID: 3262
		public new const string MRFullTypeName = "Kitware.VTK.vtkResliceCursorRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CBF RID: 3263
		public new static readonly string MRClassNameKey = "class vtkResliceCursorRepresentation";

		/// <summary>
		/// Specify the format to use for labelling the distance. Note that an empty
		/// string results in no label, or a format string without a "%" character
		/// will not print the thickness value.
		/// </summary>
		// Token: 0x02000365 RID: 869
		public enum NearAxis1_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000CC1 RID: 3265
			NearAxis1 = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000CC2 RID: 3266
			NearAxis2,
			/// <summary>enum member</summary>
			// Token: 0x04000CC3 RID: 3267
			NearCenter = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000CC4 RID: 3268
			OnAxis1 = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000CC5 RID: 3269
			OnAxis2,
			/// <summary>enum member</summary>
			// Token: 0x04000CC6 RID: 3270
			OnCenter = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000CC7 RID: 3271
			Outside = 0
		}

		/// <summary>
		/// Specify the format to use for labelling the distance. Note that an empty
		/// string results in no label, or a format string without a "%" character
		/// will not print the thickness value.
		/// </summary>
		// Token: 0x02000366 RID: 870
		public enum None_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000CC9 RID: 3273
			None,
			/// <summary>enum member</summary>
			// Token: 0x04000CCA RID: 3274
			PanAndRotate,
			/// <summary>enum member</summary>
			// Token: 0x04000CCB RID: 3275
			ResizeThickness = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000CCC RID: 3276
			RotateBothAxes = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000CCD RID: 3277
			TranslateSingleAxis = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000CCE RID: 3278
			WindowLevelling = 4
		}
	}
}
