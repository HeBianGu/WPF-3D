using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// Struct used to return information about a pixel location.
	/// </summary>
	// Token: 0x020005AF RID: 1455
	public abstract class vtkHardwareSelector : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FF1A RID: 65306 RVA: 0x00162F6D File Offset: 0x0016116D
		static vtkHardwareSelector()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHardwareSelector.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHardwareSelector"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FF1B RID: 65307 RVA: 0x00162F95 File Offset: 0x00161195
		public vtkHardwareSelector(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FF1C RID: 65308
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwareSelector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Struct used to return information about a pixel location.
		/// </summary>
		// Token: 0x0600FF1D RID: 65309 RVA: 0x00162FA4 File Offset: 0x001611A4
		public new static vtkHardwareSelector New()
		{
			vtkHardwareSelector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHardwareSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Struct used to return information about a pixel location.
		/// </summary>
		// Token: 0x0600FF1E RID: 65310 RVA: 0x00162FF8 File Offset: 0x001611F8
		public vtkHardwareSelector() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHardwareSelector.vtkHardwareSelector_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FF1F RID: 65311 RVA: 0x0016303C File Offset: 0x0016123C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FF20 RID: 65312
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_BeginRenderProp_01(HandleRef pThis);

		/// <summary>
		/// Called by the mapper before and after rendering each prop.
		/// </summary>
		// Token: 0x0600FF21 RID: 65313 RVA: 0x00163047 File Offset: 0x00161247
		public virtual void BeginRenderProp()
		{
			vtkHardwareSelector.vtkHardwareSelector_BeginRenderProp_01(base.GetCppThis());
		}

		// Token: 0x0600FF22 RID: 65314
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHardwareSelector_CaptureBuffers_02(HandleRef pThis);

		/// <summary>
		/// It is possible to use the vtkHardwareSelector for a custom picking. (Look
		/// at vtkScenePicker). In that case instead of Select() on can use
		/// CaptureBuffers() to render the selection buffers and then get information
		/// about pixel locations suing GetPixelInformation(). Use ClearBuffers() to
		/// clear buffers after one's done with the scene.
		/// The optional final parameter maxDist will look for a cell within the specified
		/// number of pixels from display_position. When using the overload with the
		/// optional \c selected_position argument, selected_position is filled with
		/// the position for which the PixelInformation is being returned. This is
		/// useful when maxDist &gt; 0 to determine which position's pixel information is
		/// was returned.
		/// </summary>
		// Token: 0x0600FF23 RID: 65315 RVA: 0x00163058 File Offset: 0x00161258
		public virtual bool CaptureBuffers()
		{
			return vtkHardwareSelector.vtkHardwareSelector_CaptureBuffers_02(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FF24 RID: 65316
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_ClearBuffers_03(HandleRef pThis);

		/// <summary>
		/// It is possible to use the vtkHardwareSelector for a custom picking. (Look
		/// at vtkScenePicker). In that case instead of Select() on can use
		/// CaptureBuffers() to render the selection buffers and then get information
		/// about pixel locations suing GetPixelInformation(). Use ClearBuffers() to
		/// clear buffers after one's done with the scene.
		/// The optional final parameter maxDist will look for a cell within the specified
		/// number of pixels from display_position. When using the overload with the
		/// optional \c selected_position argument, selected_position is filled with
		/// the position for which the PixelInformation is being returned. This is
		/// useful when maxDist &gt; 0 to determine which position's pixel information is
		/// was returned.
		/// </summary>
		// Token: 0x0600FF25 RID: 65317 RVA: 0x0016307E File Offset: 0x0016127E
		public void ClearBuffers()
		{
			vtkHardwareSelector.vtkHardwareSelector_ClearBuffers_03(base.GetCppThis());
		}

		// Token: 0x0600FF26 RID: 65318
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_Convert_04(long id, IntPtr tcoord);

		/// <summary>
		/// Convert a PassTypes enum value to a human readable string.
		/// </summary>
		// Token: 0x0600FF27 RID: 65319 RVA: 0x0016308D File Offset: 0x0016128D
		public static void Convert(long id, IntPtr tcoord)
		{
			vtkHardwareSelector.vtkHardwareSelector_Convert_04(id, tcoord);
		}

		// Token: 0x0600FF28 RID: 65320
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_EndRenderProp_05(HandleRef pThis);

		/// <summary>
		/// Called by the mapper before and after rendering each prop.
		/// </summary>
		// Token: 0x0600FF29 RID: 65321 RVA: 0x00163098 File Offset: 0x00161298
		public virtual void EndRenderProp()
		{
			vtkHardwareSelector.vtkHardwareSelector_EndRenderProp_05(base.GetCppThis());
		}

		// Token: 0x0600FF2A RID: 65322
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwareSelector_GeneratePolygonSelection_06(HandleRef pThis, IntPtr polygonPoints, long count, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Generates the vtkSelection from pixel buffers.
		/// Same as GenerateSelection, except this one use a polygon, instead
		/// of a rectangle region, and select elements inside the polygon.
		/// NOTE: The CaptureBuffers() needs to be called first.
		/// </summary>
		// Token: 0x0600FF2B RID: 65323 RVA: 0x001630A8 File Offset: 0x001612A8
		public virtual vtkSelection GeneratePolygonSelection(IntPtr polygonPoints, long count)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_GeneratePolygonSelection_06(base.GetCppThis(), polygonPoints, count, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		// Token: 0x0600FF2C RID: 65324
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwareSelector_GenerateSelection_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Generates the vtkSelection from pixel buffers.
		/// Requires that CaptureBuffers() has already been called.
		/// Optionally you may pass a screen region (xmin, ymin, xmax, ymax)
		/// to generate a selection from. The region must be a subregion
		/// of the region specified by SetArea(), otherwise it will be
		/// clipped to that region.
		/// </summary>
		// Token: 0x0600FF2D RID: 65325 RVA: 0x0016311C File Offset: 0x0016131C
		public virtual vtkSelection GenerateSelection()
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_GenerateSelection_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		// Token: 0x0600FF2E RID: 65326
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwareSelector_GenerateSelection_08(HandleRef pThis, IntPtr r, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Generates the vtkSelection from pixel buffers.
		/// Requires that CaptureBuffers() has already been called.
		/// Optionally you may pass a screen region (xmin, ymin, xmax, ymax)
		/// to generate a selection from. The region must be a subregion
		/// of the region specified by SetArea(), otherwise it will be
		/// clipped to that region.
		/// </summary>
		// Token: 0x0600FF2F RID: 65327 RVA: 0x0016318C File Offset: 0x0016138C
		public virtual vtkSelection GenerateSelection(IntPtr r)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_GenerateSelection_08(base.GetCppThis(), r, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		// Token: 0x0600FF30 RID: 65328
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwareSelector_GenerateSelection_09(HandleRef pThis, uint x1, uint y1, uint x2, uint y2, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Generates the vtkSelection from pixel buffers.
		/// Requires that CaptureBuffers() has already been called.
		/// Optionally you may pass a screen region (xmin, ymin, xmax, ymax)
		/// to generate a selection from. The region must be a subregion
		/// of the region specified by SetArea(), otherwise it will be
		/// clipped to that region.
		/// </summary>
		// Token: 0x0600FF31 RID: 65329 RVA: 0x001631FC File Offset: 0x001613FC
		public virtual vtkSelection GenerateSelection(uint x1, uint y1, uint x2, uint y2)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_GenerateSelection_09(base.GetCppThis(), x1, y1, x2, y2, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		// Token: 0x0600FF32 RID: 65330
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHardwareSelector_GetActorPassOnly_10(HandleRef pThis);

		/// <summary>
		/// Get/Set to only do the actor pass. If true all other passes will be
		/// skipped resulting in a faster pick.
		/// </summary>
		// Token: 0x0600FF33 RID: 65331 RVA: 0x00163270 File Offset: 0x00161470
		public virtual bool GetActorPassOnly()
		{
			return vtkHardwareSelector.vtkHardwareSelector_GetActorPassOnly_10(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FF34 RID: 65332
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwareSelector_GetArea_11(HandleRef pThis);

		/// <summary>
		/// Get/Set the area to select as (xmin, ymin, xmax, ymax).
		/// </summary>
		// Token: 0x0600FF35 RID: 65333 RVA: 0x00163298 File Offset: 0x00161498
		public virtual uint[] GetArea()
		{
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_GetArea_11(base.GetCppThis());
			uint[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new uint[4];
				int[] array2 = new int[4];
				Marshal.Copy(intPtr, array2, 0, array.Length);
				for (int i = 0; i < 4; i++)
				{
					array[i] = (uint)array2[i];
				}
			}
			return array;
		}

		// Token: 0x0600FF36 RID: 65334
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_GetArea_12(HandleRef pThis, ref uint _arg1, ref uint _arg2, ref uint _arg3, ref uint _arg4);

		/// <summary>
		/// Get/Set the area to select as (xmin, ymin, xmax, ymax).
		/// </summary>
		// Token: 0x0600FF37 RID: 65335 RVA: 0x00163305 File Offset: 0x00161505
		public virtual void GetArea(ref uint _arg1, ref uint _arg2, ref uint _arg3, ref uint _arg4)
		{
			vtkHardwareSelector.vtkHardwareSelector_GetArea_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x0600FF38 RID: 65336
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_GetArea_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the area to select as (xmin, ymin, xmax, ymax).
		/// </summary>
		// Token: 0x0600FF39 RID: 65337 RVA: 0x00163319 File Offset: 0x00161519
		public virtual void GetArea(IntPtr _arg)
		{
			vtkHardwareSelector.vtkHardwareSelector_GetArea_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FF3A RID: 65338
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHardwareSelector_GetCaptureZValues_14(HandleRef pThis);

		/// <summary>
		/// Get/Set to capture the zvalue. If true the closest zvalue is
		/// stored for each prop that is in the selection. ZValue in this
		/// case is the value from the zbuffer which can be used in
		/// coordinate conversions
		/// </summary>
		// Token: 0x0600FF3B RID: 65339 RVA: 0x0016332C File Offset: 0x0016152C
		public virtual bool GetCaptureZValues()
		{
			return vtkHardwareSelector.vtkHardwareSelector_GetCaptureZValues_14(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FF3C RID: 65340
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHardwareSelector_GetCurrentPass_15(HandleRef pThis);

		/// <summary>
		/// Get the current pass number.
		/// </summary>
		// Token: 0x0600FF3D RID: 65341 RVA: 0x00163354 File Offset: 0x00161554
		public virtual int GetCurrentPass()
		{
			return vtkHardwareSelector.vtkHardwareSelector_GetCurrentPass_15(base.GetCppThis());
		}

		// Token: 0x0600FF3E RID: 65342
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHardwareSelector_GetFieldAssociation_16(HandleRef pThis);

		/// <summary>
		/// Set the field type to select. Valid values are
		/// \li vtkDataObject::FIELD_ASSOCIATION_POINTS
		/// \li vtkDataObject::FIELD_ASSOCIATION_CELLS
		/// \li vtkDataObject::FIELD_ASSOCIATION_VERTICES
		/// \li vtkDataObject::FIELD_ASSOCIATION_EDGES
		/// \li vtkDataObject::FIELD_ASSOCIATION_ROWS
		/// Currently only FIELD_ASSOCIATION_POINTS and FIELD_ASSOCIATION_CELLS are
		/// supported.
		/// </summary>
		// Token: 0x0600FF3F RID: 65343 RVA: 0x00163374 File Offset: 0x00161574
		public virtual int GetFieldAssociation()
		{
			return vtkHardwareSelector.vtkHardwareSelector_GetFieldAssociation_16(base.GetCppThis());
		}

		// Token: 0x0600FF40 RID: 65344
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHardwareSelector_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Struct used to return information about a pixel location.
		/// </summary>
		// Token: 0x0600FF41 RID: 65345 RVA: 0x00163394 File Offset: 0x00161594
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHardwareSelector.vtkHardwareSelector_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x0600FF42 RID: 65346
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHardwareSelector_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Struct used to return information about a pixel location.
		/// </summary>
		// Token: 0x0600FF43 RID: 65347 RVA: 0x001633B4 File Offset: 0x001615B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHardwareSelector.vtkHardwareSelector_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x0600FF44 RID: 65348
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwareSelector_GetPixelBuffer_19(HandleRef pThis, int passNo);

		/// <summary>
		/// It is possible to use the vtkHardwareSelector for a custom picking. (Look
		/// at vtkScenePicker). In that case instead of Select() on can use
		/// CaptureBuffers() to render the selection buffers and then get information
		/// about pixel locations suing GetPixelInformation(). Use ClearBuffers() to
		/// clear buffers after one's done with the scene.
		/// The optional final parameter maxDist will look for a cell within the specified
		/// number of pixels from display_position. When using the overload with the
		/// optional \c selected_position argument, selected_position is filled with
		/// the position for which the PixelInformation is being returned. This is
		/// useful when maxDist &gt; 0 to determine which position's pixel information is
		/// was returned.
		/// </summary>
		// Token: 0x0600FF45 RID: 65349 RVA: 0x001633D0 File Offset: 0x001615D0
		public IntPtr GetPixelBuffer(int passNo)
		{
			return vtkHardwareSelector.vtkHardwareSelector_GetPixelBuffer_19(base.GetCppThis(), passNo);
		}

		// Token: 0x0600FF46 RID: 65350
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHardwareSelector_GetProcessID_20(HandleRef pThis);

		/// <summary>
		/// Get/Set the process id. If process id &lt; 0 (default -1), then the
		/// PROCESS_PASS is not rendered.
		/// </summary>
		// Token: 0x0600FF47 RID: 65351 RVA: 0x001633F0 File Offset: 0x001615F0
		public virtual int GetProcessID()
		{
			return vtkHardwareSelector.vtkHardwareSelector_GetProcessID_20(base.GetCppThis());
		}

		// Token: 0x0600FF48 RID: 65352
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwareSelector_GetPropColorValue_21(HandleRef pThis);

		/// <summary>
		/// Get/Set the color to be used by the prop when drawing
		/// </summary>
		// Token: 0x0600FF49 RID: 65353 RVA: 0x00163410 File Offset: 0x00161610
		public virtual float[] GetPropColorValue()
		{
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_GetPropColorValue_21(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600FF4A RID: 65354
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_GetPropColorValue_22(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3);

		/// <summary>
		/// Get/Set the color to be used by the prop when drawing
		/// </summary>
		// Token: 0x0600FF4B RID: 65355 RVA: 0x00163458 File Offset: 0x00161658
		public virtual void GetPropColorValue(ref float _arg1, ref float _arg2, ref float _arg3)
		{
			vtkHardwareSelector.vtkHardwareSelector_GetPropColorValue_22(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600FF4C RID: 65356
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_GetPropColorValue_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the color to be used by the prop when drawing
		/// </summary>
		// Token: 0x0600FF4D RID: 65357 RVA: 0x0016346A File Offset: 0x0016166A
		public virtual void GetPropColorValue(IntPtr _arg)
		{
			vtkHardwareSelector.vtkHardwareSelector_GetPropColorValue_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FF4E RID: 65358
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwareSelector_GetPropFromID_24(HandleRef pThis, int id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// returns the prop associated with a ID. This is valid only until
		/// ReleasePixBuffers() gets called.
		/// </summary>
		// Token: 0x0600FF4F RID: 65359 RVA: 0x0016347C File Offset: 0x0016167C
		public vtkProp GetPropFromID(int id)
		{
			vtkProp vtkProp = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_GetPropFromID_24(base.GetCppThis(), id, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp = (vtkProp)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp.Register(null);
				}
			}
			return vtkProp;
		}

		// Token: 0x0600FF50 RID: 65360
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwareSelector_GetRawPixelBuffer_25(HandleRef pThis, int passNo);

		/// <summary>
		/// It is possible to use the vtkHardwareSelector for a custom picking. (Look
		/// at vtkScenePicker). In that case instead of Select() on can use
		/// CaptureBuffers() to render the selection buffers and then get information
		/// about pixel locations suing GetPixelInformation(). Use ClearBuffers() to
		/// clear buffers after one's done with the scene.
		/// The optional final parameter maxDist will look for a cell within the specified
		/// number of pixels from display_position. When using the overload with the
		/// optional \c selected_position argument, selected_position is filled with
		/// the position for which the PixelInformation is being returned. This is
		/// useful when maxDist &gt; 0 to determine which position's pixel information is
		/// was returned.
		/// </summary>
		// Token: 0x0600FF51 RID: 65361 RVA: 0x001634EC File Offset: 0x001616EC
		public IntPtr GetRawPixelBuffer(int passNo)
		{
			return vtkHardwareSelector.vtkHardwareSelector_GetRawPixelBuffer_25(base.GetCppThis(), passNo);
		}

		// Token: 0x0600FF52 RID: 65362
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwareSelector_GetRenderer_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the renderer to perform the selection on.
		/// </summary>
		// Token: 0x0600FF53 RID: 65363 RVA: 0x0016350C File Offset: 0x0016170C
		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_GetRenderer_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x0600FF54 RID: 65364
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHardwareSelector_GetUseProcessIdFromData_27(HandleRef pThis);

		/// <summary>
		/// In some parallel rendering setups, the process id for elements must be
		/// obtained from the data itself, rather than the rendering process' id. In
		/// that case, set this flag to ON (default OFF).
		/// </summary>
		// Token: 0x0600FF55 RID: 65365 RVA: 0x0016357C File Offset: 0x0016177C
		public virtual bool GetUseProcessIdFromData()
		{
			return vtkHardwareSelector.vtkHardwareSelector_GetUseProcessIdFromData_27(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FF56 RID: 65366
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHardwareSelector_HasHighCellIds_28(HandleRef pThis);

		/// <summary>
		/// Convert a PassTypes enum value to a human readable string.
		/// </summary>
		// Token: 0x0600FF57 RID: 65367 RVA: 0x001635A4 File Offset: 0x001617A4
		public bool HasHighCellIds()
		{
			return vtkHardwareSelector.vtkHardwareSelector_HasHighCellIds_28(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FF58 RID: 65368
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHardwareSelector_HasHighPointIds_29(HandleRef pThis);

		/// <summary>
		/// Convert a PassTypes enum value to a human readable string.
		/// </summary>
		// Token: 0x0600FF59 RID: 65369 RVA: 0x001635CC File Offset: 0x001617CC
		public bool HasHighPointIds()
		{
			return vtkHardwareSelector.vtkHardwareSelector_HasHighPointIds_29(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FF5A RID: 65370
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHardwareSelector_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Struct used to return information about a pixel location.
		/// </summary>
		// Token: 0x0600FF5B RID: 65371 RVA: 0x001635F4 File Offset: 0x001617F4
		public override int IsA(string type)
		{
			return vtkHardwareSelector.vtkHardwareSelector_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x0600FF5C RID: 65372
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHardwareSelector_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Struct used to return information about a pixel location.
		/// </summary>
		// Token: 0x0600FF5D RID: 65373 RVA: 0x00163614 File Offset: 0x00161814
		public new static int IsTypeOf(string type)
		{
			return vtkHardwareSelector.vtkHardwareSelector_IsTypeOf_31(type);
		}

		// Token: 0x0600FF5E RID: 65374
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwareSelector_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Struct used to return information about a pixel location.
		/// </summary>
		// Token: 0x0600FF5F RID: 65375 RVA: 0x00163630 File Offset: 0x00161830
		public new vtkHardwareSelector NewInstance()
		{
			vtkHardwareSelector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHardwareSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FF60 RID: 65376
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkHardwareSelector_PassTypeToString_34(HandleRef pThis, vtkHardwareSelector.PassTypes type);

		/// <summary>
		/// Convert a PassTypes enum value to a human readable string.
		/// </summary>
		// Token: 0x0600FF61 RID: 65377 RVA: 0x0016368C File Offset: 0x0016188C
		public string PassTypeToString(vtkHardwareSelector.PassTypes type)
		{
			return vtkHardwareSelector.vtkHardwareSelector_PassTypeToString_34(base.GetCppThis(), type);
		}

		// Token: 0x0600FF62 RID: 65378
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_RenderCompositeIndex_35(HandleRef pThis, uint index);

		/// <summary>
		/// Called by any vtkMapper or vtkProp subclass to render a composite-index.
		/// Currently indices &gt;= 0xffffff are not supported.
		/// </summary>
		// Token: 0x0600FF63 RID: 65379 RVA: 0x001636AC File Offset: 0x001618AC
		public virtual void RenderCompositeIndex(uint index)
		{
			vtkHardwareSelector.vtkHardwareSelector_RenderCompositeIndex_35(base.GetCppThis(), index);
		}

		// Token: 0x0600FF64 RID: 65380
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_RenderProcessId_36(HandleRef pThis, uint processid);

		/// <summary>
		/// Called by any vtkMapper or subclass to render process id. This has any
		/// effect when this-&gt;UseProcessIdFromData is true.
		/// </summary>
		// Token: 0x0600FF65 RID: 65381 RVA: 0x001636BC File Offset: 0x001618BC
		public virtual void RenderProcessId(uint processid)
		{
			vtkHardwareSelector.vtkHardwareSelector_RenderProcessId_36(base.GetCppThis(), processid);
		}

		// Token: 0x0600FF66 RID: 65382
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwareSelector_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Struct used to return information about a pixel location.
		/// </summary>
		// Token: 0x0600FF67 RID: 65383 RVA: 0x001636CC File Offset: 0x001618CC
		public new static vtkHardwareSelector SafeDownCast(vtkObjectBase o)
		{
			vtkHardwareSelector vtkHardwareSelector = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHardwareSelector = (vtkHardwareSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHardwareSelector.Register(null);
				}
			}
			return vtkHardwareSelector;
		}

		// Token: 0x0600FF68 RID: 65384
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_SavePixelBuffer_38(HandleRef pThis, int passNo);

		/// <summary>
		/// Convert a PassTypes enum value to a human readable string.
		/// </summary>
		// Token: 0x0600FF69 RID: 65385 RVA: 0x0016374B File Offset: 0x0016194B
		public virtual void SavePixelBuffer(int passNo)
		{
			vtkHardwareSelector.vtkHardwareSelector_SavePixelBuffer_38(base.GetCppThis(), passNo);
		}

		// Token: 0x0600FF6A RID: 65386
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwareSelector_Select_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Perform the selection. Returns a new instance of vtkSelection containing
		/// the selection on success.
		/// </summary>
		// Token: 0x0600FF6B RID: 65387 RVA: 0x0016375C File Offset: 0x0016195C
		public vtkSelection Select()
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_Select_39(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		// Token: 0x0600FF6C RID: 65388
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_SetActorPassOnly_40(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set to only do the actor pass. If true all other passes will be
		/// skipped resulting in a faster pick.
		/// </summary>
		// Token: 0x0600FF6D RID: 65389 RVA: 0x001637CB File Offset: 0x001619CB
		public virtual void SetActorPassOnly(bool _arg)
		{
			vtkHardwareSelector.vtkHardwareSelector_SetActorPassOnly_40(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FF6E RID: 65390
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_SetArea_41(HandleRef pThis, uint _arg1, uint _arg2, uint _arg3, uint _arg4);

		/// <summary>
		/// Get/Set the area to select as (xmin, ymin, xmax, ymax).
		/// </summary>
		// Token: 0x0600FF6F RID: 65391 RVA: 0x001637E3 File Offset: 0x001619E3
		public virtual void SetArea(uint _arg1, uint _arg2, uint _arg3, uint _arg4)
		{
			vtkHardwareSelector.vtkHardwareSelector_SetArea_41(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x0600FF70 RID: 65392
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_SetArea_42(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the area to select as (xmin, ymin, xmax, ymax).
		/// </summary>
		// Token: 0x0600FF71 RID: 65393 RVA: 0x001637F7 File Offset: 0x001619F7
		public virtual void SetArea(IntPtr _arg)
		{
			vtkHardwareSelector.vtkHardwareSelector_SetArea_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FF72 RID: 65394
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_SetCaptureZValues_43(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set to capture the zvalue. If true the closest zvalue is
		/// stored for each prop that is in the selection. ZValue in this
		/// case is the value from the zbuffer which can be used in
		/// coordinate conversions
		/// </summary>
		// Token: 0x0600FF73 RID: 65395 RVA: 0x00163807 File Offset: 0x00161A07
		public virtual void SetCaptureZValues(bool _arg)
		{
			vtkHardwareSelector.vtkHardwareSelector_SetCaptureZValues_43(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FF74 RID: 65396
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_SetFieldAssociation_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the field type to select. Valid values are
		/// \li vtkDataObject::FIELD_ASSOCIATION_POINTS
		/// \li vtkDataObject::FIELD_ASSOCIATION_CELLS
		/// \li vtkDataObject::FIELD_ASSOCIATION_VERTICES
		/// \li vtkDataObject::FIELD_ASSOCIATION_EDGES
		/// \li vtkDataObject::FIELD_ASSOCIATION_ROWS
		/// Currently only FIELD_ASSOCIATION_POINTS and FIELD_ASSOCIATION_CELLS are
		/// supported.
		/// </summary>
		// Token: 0x0600FF75 RID: 65397 RVA: 0x0016381F File Offset: 0x00161A1F
		public virtual void SetFieldAssociation(int _arg)
		{
			vtkHardwareSelector.vtkHardwareSelector_SetFieldAssociation_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FF76 RID: 65398
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_SetProcessID_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the process id. If process id &lt; 0 (default -1), then the
		/// PROCESS_PASS is not rendered.
		/// </summary>
		// Token: 0x0600FF77 RID: 65399 RVA: 0x0016382F File Offset: 0x00161A2F
		public virtual void SetProcessID(int _arg)
		{
			vtkHardwareSelector.vtkHardwareSelector_SetProcessID_45(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FF78 RID: 65400
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_SetPropColorValue_46(HandleRef pThis, float _arg1, float _arg2, float _arg3);

		/// <summary>
		/// Get/Set the color to be used by the prop when drawing
		/// </summary>
		// Token: 0x0600FF79 RID: 65401 RVA: 0x0016383F File Offset: 0x00161A3F
		public virtual void SetPropColorValue(float _arg1, float _arg2, float _arg3)
		{
			vtkHardwareSelector.vtkHardwareSelector_SetPropColorValue_46(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600FF7A RID: 65402
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_SetPropColorValue_47(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the color to be used by the prop when drawing
		/// </summary>
		// Token: 0x0600FF7B RID: 65403 RVA: 0x00163851 File Offset: 0x00161A51
		public virtual void SetPropColorValue(IntPtr _arg)
		{
			vtkHardwareSelector.vtkHardwareSelector_SetPropColorValue_47(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FF7C RID: 65404
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_SetPropColorValue_48(HandleRef pThis, long val);

		/// <summary>
		/// Get/Set the color to be used by the prop when drawing
		/// </summary>
		// Token: 0x0600FF7D RID: 65405 RVA: 0x00163861 File Offset: 0x00161A61
		public void SetPropColorValue(long val)
		{
			vtkHardwareSelector.vtkHardwareSelector_SetPropColorValue_48(base.GetCppThis(), val);
		}

		// Token: 0x0600FF7E RID: 65406
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_SetRenderer_49(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the renderer to perform the selection on.
		/// </summary>
		// Token: 0x0600FF7F RID: 65407 RVA: 0x00163874 File Offset: 0x00161A74
		public virtual void SetRenderer(vtkRenderer arg0)
		{
			vtkHardwareSelector.vtkHardwareSelector_SetRenderer_49(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600FF80 RID: 65408
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_SetUseProcessIdFromData_50(HandleRef pThis, byte _arg);

		/// <summary>
		/// In some parallel rendering setups, the process id for elements must be
		/// obtained from the data itself, rather than the rendering process' id. In
		/// that case, set this flag to ON (default OFF).
		/// </summary>
		// Token: 0x0600FF81 RID: 65409 RVA: 0x001638A3 File Offset: 0x00161AA3
		public virtual void SetUseProcessIdFromData(bool _arg)
		{
			vtkHardwareSelector.vtkHardwareSelector_SetUseProcessIdFromData_50(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FF82 RID: 65410
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_UpdateMaximumCellId_51(HandleRef pThis, long attribid);

		/// <summary>
		/// Called by any vtkMapper or vtkProp subclass to indicate the
		/// maximum cell or point attribute ID it uses. These values are
		/// used for determining if the POINT_ID_HIGH or CELL_ID_HIGH
		/// passes are required.
		/// </summary>
		// Token: 0x0600FF83 RID: 65411 RVA: 0x001638BB File Offset: 0x00161ABB
		public virtual void UpdateMaximumCellId(long attribid)
		{
			vtkHardwareSelector.vtkHardwareSelector_UpdateMaximumCellId_51(base.GetCppThis(), attribid);
		}

		// Token: 0x0600FF84 RID: 65412
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareSelector_UpdateMaximumPointId_52(HandleRef pThis, long attribid);

		/// <summary>
		/// Called by any vtkMapper or vtkProp subclass to indicate the
		/// maximum cell or point attribute ID it uses. These values are
		/// used for determining if the POINT_ID_HIGH or CELL_ID_HIGH
		/// passes are required.
		/// </summary>
		// Token: 0x0600FF85 RID: 65413 RVA: 0x001638CB File Offset: 0x00161ACB
		public virtual void UpdateMaximumPointId(long attribid)
		{
			vtkHardwareSelector.vtkHardwareSelector_UpdateMaximumPointId_52(base.GetCppThis(), attribid);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001298 RID: 4760
		public new const string MRFullTypeName = "Kitware.VTK.vtkHardwareSelector";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001299 RID: 4761
		public new static readonly string MRClassNameKey = "class vtkHardwareSelector";

		/// <summary>
		/// returns the prop associated with a ID. This is valid only until
		/// ReleasePixBuffers() gets called.
		/// </summary>
		// Token: 0x020005B0 RID: 1456
		public enum PassTypes
		{
			/// <summary>enum member</summary>
			// Token: 0x0400129B RID: 4763
			ACTOR_PASS,
			/// <summary>enum member</summary>
			// Token: 0x0400129C RID: 4764
			CELL_ID_HIGH24 = 6,
			/// <summary>enum member</summary>
			// Token: 0x0400129D RID: 4765
			CELL_ID_LOW24 = 5,
			/// <summary>enum member</summary>
			// Token: 0x0400129E RID: 4766
			COMPOSITE_INDEX_PASS = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400129F RID: 4767
			MAX_KNOWN_PASS = 6,
			/// <summary>enum member</summary>
			// Token: 0x040012A0 RID: 4768
			MIN_KNOWN_PASS = 0,
			/// <summary>enum member</summary>
			// Token: 0x040012A1 RID: 4769
			POINT_ID_HIGH24 = 3,
			/// <summary>enum member</summary>
			// Token: 0x040012A2 RID: 4770
			POINT_ID_LOW24 = 2,
			/// <summary>enum member</summary>
			// Token: 0x040012A3 RID: 4771
			PROCESS_PASS = 4
		}
	}
}
