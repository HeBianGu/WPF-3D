using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageMapper3D
	/// </summary>
	/// <remarks>
	///    abstract class for mapping images to the screen
	///
	/// vtkImageMapper3D is a mapper that will draw a 2D image, or a slice
	/// of a 3D image.  The slice plane can be set automatically follow the
	/// camera, so that it slices through the focal point and faces the camera.
	/// @par Thanks:
	/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
	/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImage vtkImageProperty vtkImageResliceMapper vtkImageSliceMapper
	/// </seealso>
	// Token: 0x0200010F RID: 271
	public abstract class vtkImageMapper3D : vtkAbstractMapper3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003715 RID: 14101 RVA: 0x0005080F File Offset: 0x0004EA0F
		static vtkImageMapper3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMapper3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMapper3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003716 RID: 14102 RVA: 0x00050837 File Offset: 0x0004EA37
		public vtkImageMapper3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003717 RID: 14103 RVA: 0x00050845 File Offset: 0x0004EA45
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003718 RID: 14104
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_BackgroundOff_01(HandleRef pThis);

		/// <summary>
		/// Instead of rendering only to the image border, render out
		/// to the viewport boundary with the background color.  The
		/// background color will be the lowest color on the lookup
		/// table that is being used for the image.
		/// </summary>
		// Token: 0x06003719 RID: 14105 RVA: 0x00050850 File Offset: 0x0004EA50
		public virtual void BackgroundOff()
		{
			vtkImageMapper3D.vtkImageMapper3D_BackgroundOff_01(base.GetCppThis());
		}

		// Token: 0x0600371A RID: 14106
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_BackgroundOn_02(HandleRef pThis);

		/// <summary>
		/// Instead of rendering only to the image border, render out
		/// to the viewport boundary with the background color.  The
		/// background color will be the lowest color on the lookup
		/// table that is being used for the image.
		/// </summary>
		// Token: 0x0600371B RID: 14107 RVA: 0x0005085F File Offset: 0x0004EA5F
		public virtual void BackgroundOn()
		{
			vtkImageMapper3D.vtkImageMapper3D_BackgroundOn_02(base.GetCppThis());
		}

		// Token: 0x0600371C RID: 14108
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_BorderOff_03(HandleRef pThis);

		/// <summary>
		/// Instead of displaying the image only out to the image
		/// bounds, include a half-voxel border around the image.
		/// Within this border, the image values will be extrapolated
		/// rather than interpolated.
		/// </summary>
		// Token: 0x0600371D RID: 14109 RVA: 0x0005086E File Offset: 0x0004EA6E
		public virtual void BorderOff()
		{
			vtkImageMapper3D.vtkImageMapper3D_BorderOff_03(base.GetCppThis());
		}

		// Token: 0x0600371E RID: 14110
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_BorderOn_04(HandleRef pThis);

		/// <summary>
		/// Instead of displaying the image only out to the image
		/// bounds, include a half-voxel border around the image.
		/// Within this border, the image values will be extrapolated
		/// rather than interpolated.
		/// </summary>
		// Token: 0x0600371F RID: 14111 RVA: 0x0005087D File Offset: 0x0004EA7D
		public virtual void BorderOn()
		{
			vtkImageMapper3D.vtkImageMapper3D_BorderOn_04(base.GetCppThis());
		}

		// Token: 0x06003720 RID: 14112
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapper3D_GetBackground_05(HandleRef pThis);

		/// <summary>
		/// Instead of rendering only to the image border, render out
		/// to the viewport boundary with the background color.  The
		/// background color will be the lowest color on the lookup
		/// table that is being used for the image.
		/// </summary>
		// Token: 0x06003721 RID: 14113 RVA: 0x0005088C File Offset: 0x0004EA8C
		public virtual int GetBackground()
		{
			return vtkImageMapper3D.vtkImageMapper3D_GetBackground_05(base.GetCppThis());
		}

		// Token: 0x06003722 RID: 14114
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapper3D_GetBorder_06(HandleRef pThis);

		/// <summary>
		/// Instead of displaying the image only out to the image
		/// bounds, include a half-voxel border around the image.
		/// Within this border, the image values will be extrapolated
		/// rather than interpolated.
		/// </summary>
		// Token: 0x06003723 RID: 14115 RVA: 0x000508AC File Offset: 0x0004EAAC
		public virtual int GetBorder()
		{
			return vtkImageMapper3D.vtkImageMapper3D_GetBorder_06(base.GetCppThis());
		}

		// Token: 0x06003724 RID: 14116
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapper3D_GetDataObjectInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The input data for this mapper.
		/// </summary>
		// Token: 0x06003725 RID: 14117 RVA: 0x000508CC File Offset: 0x0004EACC
		public vtkDataObject GetDataObjectInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMapper3D.vtkImageMapper3D_GetDataObjectInput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x06003726 RID: 14118
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapper3D_GetDataSetInput_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The input data for this mapper.
		/// </summary>
		// Token: 0x06003727 RID: 14119 RVA: 0x0005093C File Offset: 0x0004EB3C
		public vtkDataSet GetDataSetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMapper3D.vtkImageMapper3D_GetDataSetInput_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x06003728 RID: 14120
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_GetIndexBounds_09(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Turn on streaming, to pull the minimum amount of data from the input.
		/// Streaming decreases the memory required to display large images, since
		/// only one slice will be pulled through the input pipeline if only
		/// one slice is mapped to the screen.  The default behavior is to pull
		/// the full 3D input extent through the input pipeline, but to do this
		/// only when the input data changes.  The default behavior results in
		/// much faster follow-up renders when the input data is static.
		/// </summary>
		// Token: 0x06003729 RID: 14121 RVA: 0x000509AB File Offset: 0x0004EBAB
		public virtual void GetIndexBounds(IntPtr extent)
		{
			vtkImageMapper3D.vtkImageMapper3D_GetIndexBounds_09(base.GetCppThis(), extent);
		}

		// Token: 0x0600372A RID: 14122
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapper3D_GetInput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The input data for this mapper.
		/// </summary>
		// Token: 0x0600372B RID: 14123 RVA: 0x000509BC File Offset: 0x0004EBBC
		public vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMapper3D.vtkImageMapper3D_GetInput_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x0600372C RID: 14124
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMapper3D_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600372D RID: 14125 RVA: 0x00050A2C File Offset: 0x0004EC2C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageMapper3D.vtkImageMapper3D_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0600372E RID: 14126
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMapper3D_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600372F RID: 14127 RVA: 0x00050A4C File Offset: 0x0004EC4C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageMapper3D.vtkImageMapper3D_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x06003730 RID: 14128
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapper3D_GetNumberOfThreads_13(HandleRef pThis);

		/// <summary>
		/// The number of threads to create when rendering.
		/// </summary>
		// Token: 0x06003731 RID: 14129 RVA: 0x00050A68 File Offset: 0x0004EC68
		public virtual int GetNumberOfThreads()
		{
			return vtkImageMapper3D.vtkImageMapper3D_GetNumberOfThreads_13(base.GetCppThis());
		}

		// Token: 0x06003732 RID: 14130
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapper3D_GetNumberOfThreadsMaxValue_14(HandleRef pThis);

		/// <summary>
		/// The number of threads to create when rendering.
		/// </summary>
		// Token: 0x06003733 RID: 14131 RVA: 0x00050A88 File Offset: 0x0004EC88
		public virtual int GetNumberOfThreadsMaxValue()
		{
			return vtkImageMapper3D.vtkImageMapper3D_GetNumberOfThreadsMaxValue_14(base.GetCppThis());
		}

		// Token: 0x06003734 RID: 14132
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapper3D_GetNumberOfThreadsMinValue_15(HandleRef pThis);

		/// <summary>
		/// The number of threads to create when rendering.
		/// </summary>
		// Token: 0x06003735 RID: 14133 RVA: 0x00050AA8 File Offset: 0x0004ECA8
		public virtual int GetNumberOfThreadsMinValue()
		{
			return vtkImageMapper3D.vtkImageMapper3D_GetNumberOfThreadsMinValue_15(base.GetCppThis());
		}

		// Token: 0x06003736 RID: 14134
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapper3D_GetSliceAtFocalPoint_16(HandleRef pThis);

		/// <summary>
		/// Automatically set the slice position to the camera focal point.
		/// This provides a convenient way to interact with the image, since
		/// most Interactors directly control the camera.
		/// </summary>
		// Token: 0x06003737 RID: 14135 RVA: 0x00050AC8 File Offset: 0x0004ECC8
		public virtual int GetSliceAtFocalPoint()
		{
			return vtkImageMapper3D.vtkImageMapper3D_GetSliceAtFocalPoint_16(base.GetCppThis());
		}

		// Token: 0x06003738 RID: 14136
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapper3D_GetSliceFacesCamera_17(HandleRef pThis);

		/// <summary>
		/// Automatically set the slice orientation so that it faces the camera.
		/// This provides a convenient way to interact with the image, since
		/// most Interactors directly control the camera.
		/// </summary>
		// Token: 0x06003739 RID: 14137 RVA: 0x00050AE8 File Offset: 0x0004ECE8
		public virtual int GetSliceFacesCamera()
		{
			return vtkImageMapper3D.vtkImageMapper3D_GetSliceFacesCamera_17(base.GetCppThis());
		}

		// Token: 0x0600373A RID: 14138
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapper3D_GetSlicePlane_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A plane that describes what slice of the input is being
		/// rendered by the mapper.  This plane is in world coordinates,
		/// not data coordinates.  Before using this plane, call Update
		/// or UpdateInformation to make sure the plane is up-to-date.
		/// These methods are automatically called by Render.
		/// </summary>
		// Token: 0x0600373B RID: 14139 RVA: 0x00050B08 File Offset: 0x0004ED08
		public virtual vtkPlane GetSlicePlane()
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMapper3D.vtkImageMapper3D_GetSlicePlane_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlane = (vtkPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlane.Register(null);
				}
			}
			return vtkPlane;
		}

		// Token: 0x0600373C RID: 14140
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_GetSlicePlaneInDataCoords_19(HandleRef pThis, HandleRef propMatrix, IntPtr plane);

		/// <summary>
		/// Get the plane as a homogeneous 4-vector that gives the plane
		/// equation coefficients.  The prop3D matrix must be provided so
		/// that the plane can be converted to data coords.
		/// </summary>
		// Token: 0x0600373D RID: 14141 RVA: 0x00050B78 File Offset: 0x0004ED78
		public virtual void GetSlicePlaneInDataCoords(vtkMatrix4x4 propMatrix, IntPtr plane)
		{
			vtkImageMapper3D.vtkImageMapper3D_GetSlicePlaneInDataCoords_19(base.GetCppThis(), (propMatrix == null) ? default(HandleRef) : propMatrix.GetCppThis(), plane);
		}

		// Token: 0x0600373E RID: 14142
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapper3D_GetStreaming_20(HandleRef pThis);

		/// <summary>
		/// Turn on streaming, to pull the minimum amount of data from the input.
		/// Streaming decreases the memory required to display large images, since
		/// only one slice will be pulled through the input pipeline if only
		/// one slice is mapped to the screen.  The default behavior is to pull
		/// the full 3D input extent through the input pipeline, but to do this
		/// only when the input data changes.  The default behavior results in
		/// much faster follow-up renders when the input data is static.
		/// </summary>
		// Token: 0x0600373F RID: 14143 RVA: 0x00050BA8 File Offset: 0x0004EDA8
		public virtual int GetStreaming()
		{
			return vtkImageMapper3D.vtkImageMapper3D_GetStreaming_20(base.GetCppThis());
		}

		// Token: 0x06003740 RID: 14144
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapper3D_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003741 RID: 14145 RVA: 0x00050BC8 File Offset: 0x0004EDC8
		public override int IsA(string type)
		{
			return vtkImageMapper3D.vtkImageMapper3D_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x06003742 RID: 14146
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapper3D_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003743 RID: 14147 RVA: 0x00050BE8 File Offset: 0x0004EDE8
		public new static int IsTypeOf(string type)
		{
			return vtkImageMapper3D.vtkImageMapper3D_IsTypeOf_22(type);
		}

		// Token: 0x06003744 RID: 14148
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapper3D_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003745 RID: 14149 RVA: 0x00050C04 File Offset: 0x0004EE04
		public new vtkImageMapper3D NewInstance()
		{
			vtkImageMapper3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMapper3D.vtkImageMapper3D_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMapper3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003746 RID: 14150
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by
		/// this mapper.  The parameter window is used to determine
		/// which graphic resources to release.
		/// </summary>
		// Token: 0x06003747 RID: 14151 RVA: 0x00050C60 File Offset: 0x0004EE60
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkImageMapper3D.vtkImageMapper3D_ReleaseGraphicsResources_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003748 RID: 14152
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_Render_25(HandleRef pThis, HandleRef renderer, HandleRef prop);

		/// <summary>
		/// This should only be called by the renderer.
		/// </summary>
		// Token: 0x06003749 RID: 14153 RVA: 0x00050C90 File Offset: 0x0004EE90
		public virtual void Render(vtkRenderer renderer, vtkImageSlice prop)
		{
			vtkImageMapper3D.vtkImageMapper3D_Render_25(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x0600374A RID: 14154
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapper3D_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600374B RID: 14155 RVA: 0x00050CD4 File Offset: 0x0004EED4
		public new static vtkImageMapper3D SafeDownCast(vtkObjectBase o)
		{
			vtkImageMapper3D vtkImageMapper3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMapper3D.vtkImageMapper3D_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMapper3D = (vtkImageMapper3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMapper3D.Register(null);
				}
			}
			return vtkImageMapper3D;
		}

		// Token: 0x0600374C RID: 14156
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_SetBackground_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Instead of rendering only to the image border, render out
		/// to the viewport boundary with the background color.  The
		/// background color will be the lowest color on the lookup
		/// table that is being used for the image.
		/// </summary>
		// Token: 0x0600374D RID: 14157 RVA: 0x00050D53 File Offset: 0x0004EF53
		public virtual void SetBackground(int _arg)
		{
			vtkImageMapper3D.vtkImageMapper3D_SetBackground_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600374E RID: 14158
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_SetBorder_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Instead of displaying the image only out to the image
		/// bounds, include a half-voxel border around the image.
		/// Within this border, the image values will be extrapolated
		/// rather than interpolated.
		/// </summary>
		// Token: 0x0600374F RID: 14159 RVA: 0x00050D63 File Offset: 0x0004EF63
		public virtual void SetBorder(int _arg)
		{
			vtkImageMapper3D.vtkImageMapper3D_SetBorder_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06003750 RID: 14160
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_SetInputData_29(HandleRef pThis, HandleRef input);

		/// <summary>
		/// The input data for this mapper.
		/// </summary>
		// Token: 0x06003751 RID: 14161 RVA: 0x00050D74 File Offset: 0x0004EF74
		public void SetInputData(vtkImageData input)
		{
			vtkImageMapper3D.vtkImageMapper3D_SetInputData_29(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06003752 RID: 14162
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_SetNumberOfThreads_30(HandleRef pThis, int _arg);

		/// <summary>
		/// The number of threads to create when rendering.
		/// </summary>
		// Token: 0x06003753 RID: 14163 RVA: 0x00050DA3 File Offset: 0x0004EFA3
		public virtual void SetNumberOfThreads(int _arg)
		{
			vtkImageMapper3D.vtkImageMapper3D_SetNumberOfThreads_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06003754 RID: 14164
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_SetSliceAtFocalPoint_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Automatically set the slice position to the camera focal point.
		/// This provides a convenient way to interact with the image, since
		/// most Interactors directly control the camera.
		/// </summary>
		// Token: 0x06003755 RID: 14165 RVA: 0x00050DB3 File Offset: 0x0004EFB3
		public virtual void SetSliceAtFocalPoint(int _arg)
		{
			vtkImageMapper3D.vtkImageMapper3D_SetSliceAtFocalPoint_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06003756 RID: 14166
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_SetSliceFacesCamera_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Automatically set the slice orientation so that it faces the camera.
		/// This provides a convenient way to interact with the image, since
		/// most Interactors directly control the camera.
		/// </summary>
		// Token: 0x06003757 RID: 14167 RVA: 0x00050DC3 File Offset: 0x0004EFC3
		public virtual void SetSliceFacesCamera(int _arg)
		{
			vtkImageMapper3D.vtkImageMapper3D_SetSliceFacesCamera_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06003758 RID: 14168
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_SetStreaming_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on streaming, to pull the minimum amount of data from the input.
		/// Streaming decreases the memory required to display large images, since
		/// only one slice will be pulled through the input pipeline if only
		/// one slice is mapped to the screen.  The default behavior is to pull
		/// the full 3D input extent through the input pipeline, but to do this
		/// only when the input data changes.  The default behavior results in
		/// much faster follow-up renders when the input data is static.
		/// </summary>
		// Token: 0x06003759 RID: 14169 RVA: 0x00050DD3 File Offset: 0x0004EFD3
		public virtual void SetStreaming(int _arg)
		{
			vtkImageMapper3D.vtkImageMapper3D_SetStreaming_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600375A RID: 14170
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_SliceAtFocalPointOff_34(HandleRef pThis);

		/// <summary>
		/// Automatically set the slice position to the camera focal point.
		/// This provides a convenient way to interact with the image, since
		/// most Interactors directly control the camera.
		/// </summary>
		// Token: 0x0600375B RID: 14171 RVA: 0x00050DE3 File Offset: 0x0004EFE3
		public virtual void SliceAtFocalPointOff()
		{
			vtkImageMapper3D.vtkImageMapper3D_SliceAtFocalPointOff_34(base.GetCppThis());
		}

		// Token: 0x0600375C RID: 14172
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_SliceAtFocalPointOn_35(HandleRef pThis);

		/// <summary>
		/// Automatically set the slice position to the camera focal point.
		/// This provides a convenient way to interact with the image, since
		/// most Interactors directly control the camera.
		/// </summary>
		// Token: 0x0600375D RID: 14173 RVA: 0x00050DF2 File Offset: 0x0004EFF2
		public virtual void SliceAtFocalPointOn()
		{
			vtkImageMapper3D.vtkImageMapper3D_SliceAtFocalPointOn_35(base.GetCppThis());
		}

		// Token: 0x0600375E RID: 14174
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_SliceFacesCameraOff_36(HandleRef pThis);

		/// <summary>
		/// Automatically set the slice orientation so that it faces the camera.
		/// This provides a convenient way to interact with the image, since
		/// most Interactors directly control the camera.
		/// </summary>
		// Token: 0x0600375F RID: 14175 RVA: 0x00050E01 File Offset: 0x0004F001
		public virtual void SliceFacesCameraOff()
		{
			vtkImageMapper3D.vtkImageMapper3D_SliceFacesCameraOff_36(base.GetCppThis());
		}

		// Token: 0x06003760 RID: 14176
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_SliceFacesCameraOn_37(HandleRef pThis);

		/// <summary>
		/// Automatically set the slice orientation so that it faces the camera.
		/// This provides a convenient way to interact with the image, since
		/// most Interactors directly control the camera.
		/// </summary>
		// Token: 0x06003761 RID: 14177 RVA: 0x00050E10 File Offset: 0x0004F010
		public virtual void SliceFacesCameraOn()
		{
			vtkImageMapper3D.vtkImageMapper3D_SliceFacesCameraOn_37(base.GetCppThis());
		}

		// Token: 0x06003762 RID: 14178
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_StreamingOff_38(HandleRef pThis);

		/// <summary>
		/// Turn on streaming, to pull the minimum amount of data from the input.
		/// Streaming decreases the memory required to display large images, since
		/// only one slice will be pulled through the input pipeline if only
		/// one slice is mapped to the screen.  The default behavior is to pull
		/// the full 3D input extent through the input pipeline, but to do this
		/// only when the input data changes.  The default behavior results in
		/// much faster follow-up renders when the input data is static.
		/// </summary>
		// Token: 0x06003763 RID: 14179 RVA: 0x00050E1F File Offset: 0x0004F01F
		public virtual void StreamingOff()
		{
			vtkImageMapper3D.vtkImageMapper3D_StreamingOff_38(base.GetCppThis());
		}

		// Token: 0x06003764 RID: 14180
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper3D_StreamingOn_39(HandleRef pThis);

		/// <summary>
		/// Turn on streaming, to pull the minimum amount of data from the input.
		/// Streaming decreases the memory required to display large images, since
		/// only one slice will be pulled through the input pipeline if only
		/// one slice is mapped to the screen.  The default behavior is to pull
		/// the full 3D input extent through the input pipeline, but to do this
		/// only when the input data changes.  The default behavior results in
		/// much faster follow-up renders when the input data is static.
		/// </summary>
		// Token: 0x06003765 RID: 14181 RVA: 0x00050E2E File Offset: 0x0004F02E
		public virtual void StreamingOn()
		{
			vtkImageMapper3D.vtkImageMapper3D_StreamingOn_39(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000656 RID: 1622
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMapper3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000657 RID: 1623
		public new static readonly string MRClassNameKey = "class vtkImageMapper3D";
	}
}
