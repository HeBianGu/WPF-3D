using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageStack
	/// </summary>
	/// <remarks>
	///    manages a stack of composited images
	///
	/// vtkImageStack manages the compositing of a set of images. Each image
	/// is assigned a layer number through its property object, and it is
	/// this layer number that determines the compositing order: images with
	/// a higher layer number are drawn over top of images with a lower layer
	/// number.  The image stack has a SetActiveLayer method for controlling
	/// which layer to use for interaction and picking.
	/// @par Thanks:
	/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
	/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageMapper3D vtkImageProperty vtkProp3D
	/// </seealso>
	// Token: 0x02000115 RID: 277
	public class vtkImageStack : vtkImageSlice
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600387C RID: 14460 RVA: 0x000527F6 File Offset: 0x000509F6
		static vtkImageStack()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageStack.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageStack"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600387D RID: 14461 RVA: 0x0005281E File Offset: 0x00050A1E
		public vtkImageStack(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600387E RID: 14462
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStack_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600387F RID: 14463 RVA: 0x0005282C File Offset: 0x00050A2C
		public new static vtkImageStack New()
		{
			vtkImageStack result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStack.vtkImageStack_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageStack)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003880 RID: 14464 RVA: 0x00052880 File Offset: 0x00050A80
		public vtkImageStack() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageStack.vtkImageStack_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003881 RID: 14465 RVA: 0x000528C4 File Offset: 0x00050AC4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003882 RID: 14466
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStack_AddImage_01(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Add an image to the stack.  If the image is already present, then
		/// this method will do nothing.
		/// </summary>
		// Token: 0x06003883 RID: 14467 RVA: 0x000528D0 File Offset: 0x00050AD0
		public void AddImage(vtkImageSlice prop)
		{
			vtkImageStack.vtkImageStack_AddImage_01(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x06003884 RID: 14468
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStack_BuildPaths_02(HandleRef pThis, HandleRef paths, HandleRef path);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Used to construct assembly paths and perform part traversal.
		/// </summary>
		// Token: 0x06003885 RID: 14469 RVA: 0x00052900 File Offset: 0x00050B00
		public override void BuildPaths(vtkAssemblyPaths paths, vtkAssemblyPath path)
		{
			vtkImageStack.vtkImageStack_BuildPaths_02(base.GetCppThis(), (paths == null) ? default(HandleRef) : paths.GetCppThis(), (path == null) ? default(HandleRef) : path.GetCppThis());
		}

		// Token: 0x06003886 RID: 14470
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStack_GetActiveImage_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the active image.  This will be the topmost image whose
		/// LayerNumber is the ActiveLayer.  If no image matches, then NULL
		/// will be returned.
		/// </summary>
		// Token: 0x06003887 RID: 14471 RVA: 0x00052944 File Offset: 0x00050B44
		public vtkImageSlice GetActiveImage()
		{
			vtkImageSlice vtkImageSlice = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStack.vtkImageStack_GetActiveImage_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSlice = (vtkImageSlice)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSlice.Register(null);
				}
			}
			return vtkImageSlice;
		}

		// Token: 0x06003888 RID: 14472
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStack_GetActiveLayer_04(HandleRef pThis);

		/// <summary>
		/// Set the active layer number.  This is the layer that will be
		/// used for picking and interaction.
		/// </summary>
		// Token: 0x06003889 RID: 14473 RVA: 0x000529B4 File Offset: 0x00050BB4
		public int GetActiveLayer()
		{
			return vtkImageStack.vtkImageStack_GetActiveLayer_04(base.GetCppThis());
		}

		// Token: 0x0600388A RID: 14474
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStack_GetBounds_05(HandleRef pThis);

		/// <summary>
		/// Get the combined bounds of all of the images.
		/// </summary>
		// Token: 0x0600388B RID: 14475 RVA: 0x000529D4 File Offset: 0x00050BD4
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkImageStack.vtkImageStack_GetBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600388C RID: 14476
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStack_GetBounds_06(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the combined bounds of all of the images.
		/// </summary>
		// Token: 0x0600388D RID: 14477 RVA: 0x00052A1C File Offset: 0x00050C1C
		public new void GetBounds(IntPtr bounds)
		{
			vtkImageStack.vtkImageStack_GetBounds_06(base.GetCppThis(), bounds);
		}

		// Token: 0x0600388E RID: 14478
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStack_GetImages_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the list of images as a vtkImageSliceCollection.
		/// </summary>
		// Token: 0x0600388F RID: 14479 RVA: 0x00052A2C File Offset: 0x00050C2C
		public vtkImageSliceCollection GetImages()
		{
			vtkImageSliceCollection vtkImageSliceCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStack.vtkImageStack_GetImages_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSliceCollection = (vtkImageSliceCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSliceCollection.Register(null);
				}
			}
			return vtkImageSliceCollection;
		}

		// Token: 0x06003890 RID: 14480
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStack_GetImages_08(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// For some exporters and other other operations we must be
		/// able to collect all the actors, volumes, and images. These
		/// methods are used in that process.
		/// </summary>
		// Token: 0x06003891 RID: 14481 RVA: 0x00052A9C File Offset: 0x00050C9C
		public new void GetImages(vtkPropCollection arg0)
		{
			vtkImageStack.vtkImageStack_GetImages_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003892 RID: 14482
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImageStack_GetMTime_09(HandleRef pThis);

		/// <summary>
		/// Return the max MTime of all the images.
		/// </summary>
		// Token: 0x06003893 RID: 14483 RVA: 0x00052ACC File Offset: 0x00050CCC
		public override ulong GetMTime()
		{
			return vtkImageStack.vtkImageStack_GetMTime_09(base.GetCppThis());
		}

		// Token: 0x06003894 RID: 14484
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStack_GetMapper_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the mapper for the currently active image.
		/// </summary>
		// Token: 0x06003895 RID: 14485 RVA: 0x00052AEC File Offset: 0x00050CEC
		public override vtkImageMapper3D GetMapper()
		{
			vtkImageMapper3D vtkImageMapper3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStack.vtkImageStack_GetMapper_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003896 RID: 14486
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStack_GetNextPath_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Methods for traversing the stack as if it was an assembly.
		/// The traversal only gives the view prop for the active layer.
		/// </summary>
		// Token: 0x06003897 RID: 14487 RVA: 0x00052B5C File Offset: 0x00050D5C
		public override vtkAssemblyPath GetNextPath()
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStack.vtkImageStack_GetNextPath_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyPath = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyPath.Register(null);
				}
			}
			return vtkAssemblyPath;
		}

		// Token: 0x06003898 RID: 14488
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageStack_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003899 RID: 14489 RVA: 0x00052BCC File Offset: 0x00050DCC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageStack.vtkImageStack_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x0600389A RID: 14490
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageStack_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600389B RID: 14491 RVA: 0x00052BEC File Offset: 0x00050DEC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageStack.vtkImageStack_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x0600389C RID: 14492
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStack_GetNumberOfPaths_14(HandleRef pThis);

		/// <summary>
		/// Methods for traversing the stack as if it was an assembly.
		/// The traversal only gives the view prop for the active layer.
		/// </summary>
		// Token: 0x0600389D RID: 14493 RVA: 0x00052C08 File Offset: 0x00050E08
		public override int GetNumberOfPaths()
		{
			return vtkImageStack.vtkImageStack_GetNumberOfPaths_14(base.GetCppThis());
		}

		// Token: 0x0600389E RID: 14494
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStack_GetProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the property for the currently active image.
		/// </summary>
		// Token: 0x0600389F RID: 14495 RVA: 0x00052C28 File Offset: 0x00050E28
		public override vtkImageProperty GetProperty()
		{
			vtkImageProperty vtkImageProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStack.vtkImageStack_GetProperty_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageProperty = (vtkImageProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageProperty.Register(null);
				}
			}
			return vtkImageProperty;
		}

		// Token: 0x060038A0 RID: 14496
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImageStack_GetRedrawMTime_16(HandleRef pThis);

		/// <summary>
		/// Return the mtime of anything that would cause the rendered image to
		/// appear differently. Usually this involves checking the mtime of the
		/// prop plus anything else it depends on such as properties, mappers,
		/// etc.
		/// </summary>
		// Token: 0x060038A1 RID: 14497 RVA: 0x00052C98 File Offset: 0x00050E98
		public override ulong GetRedrawMTime()
		{
			return vtkImageStack.vtkImageStack_GetRedrawMTime_16(base.GetCppThis());
		}

		// Token: 0x060038A2 RID: 14498
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStack_HasImage_17(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Check if an image is present.  The returned value is one or zero.
		/// </summary>
		// Token: 0x060038A3 RID: 14499 RVA: 0x00052CB8 File Offset: 0x00050EB8
		public int HasImage(vtkImageSlice prop)
		{
			return vtkImageStack.vtkImageStack_HasImage_17(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x060038A4 RID: 14500
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStack_HasTranslucentPolygonalGeometry_18(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x060038A5 RID: 14501 RVA: 0x00052CEC File Offset: 0x00050EEC
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkImageStack.vtkImageStack_HasTranslucentPolygonalGeometry_18(base.GetCppThis());
		}

		// Token: 0x060038A6 RID: 14502
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStack_InitPathTraversal_19(HandleRef pThis);

		/// <summary>
		/// Methods for traversing the stack as if it was an assembly.
		/// The traversal only gives the view prop for the active layer.
		/// </summary>
		// Token: 0x060038A7 RID: 14503 RVA: 0x00052D0B File Offset: 0x00050F0B
		public override void InitPathTraversal()
		{
			vtkImageStack.vtkImageStack_InitPathTraversal_19(base.GetCppThis());
		}

		// Token: 0x060038A8 RID: 14504
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStack_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060038A9 RID: 14505 RVA: 0x00052D1C File Offset: 0x00050F1C
		public override int IsA(string type)
		{
			return vtkImageStack.vtkImageStack_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x060038AA RID: 14506
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStack_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060038AB RID: 14507 RVA: 0x00052D3C File Offset: 0x00050F3C
		public new static int IsTypeOf(string type)
		{
			return vtkImageStack.vtkImageStack_IsTypeOf_21(type);
		}

		// Token: 0x060038AC RID: 14508
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStack_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060038AD RID: 14509 RVA: 0x00052D58 File Offset: 0x00050F58
		public new vtkImageStack NewInstance()
		{
			vtkImageStack result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStack.vtkImageStack_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageStack)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060038AE RID: 14510
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStack_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef win);

		/// <summary>
		/// Release any resources held by this prop.
		/// </summary>
		// Token: 0x060038AF RID: 14511 RVA: 0x00052DB4 File Offset: 0x00050FB4
		public override void ReleaseGraphicsResources(vtkWindow win)
		{
			vtkImageStack.vtkImageStack_ReleaseGraphicsResources_24(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		// Token: 0x060038B0 RID: 14512
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStack_RemoveImage_25(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Remove an image from the stack.  If the image is not present, then
		/// this method will do nothing.
		/// </summary>
		// Token: 0x060038B1 RID: 14513 RVA: 0x00052DE4 File Offset: 0x00050FE4
		public void RemoveImage(vtkImageSlice prop)
		{
			vtkImageStack.vtkImageStack_RemoveImage_25(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x060038B2 RID: 14514
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStack_RenderOpaqueGeometry_26(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x060038B3 RID: 14515 RVA: 0x00052E14 File Offset: 0x00051014
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkImageStack.vtkImageStack_RenderOpaqueGeometry_26(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060038B4 RID: 14516
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStack_RenderOverlay_27(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x060038B5 RID: 14517 RVA: 0x00052E48 File Offset: 0x00051048
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkImageStack.vtkImageStack_RenderOverlay_27(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060038B6 RID: 14518
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStack_RenderTranslucentPolygonalGeometry_28(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x060038B7 RID: 14519 RVA: 0x00052E7C File Offset: 0x0005107C
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkImageStack.vtkImageStack_RenderTranslucentPolygonalGeometry_28(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060038B8 RID: 14520
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStack_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060038B9 RID: 14521 RVA: 0x00052EB0 File Offset: 0x000510B0
		public new static vtkImageStack SafeDownCast(vtkObjectBase o)
		{
			vtkImageStack vtkImageStack = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStack.vtkImageStack_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStack = (vtkImageStack)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStack.Register(null);
				}
			}
			return vtkImageStack;
		}

		// Token: 0x060038BA RID: 14522
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStack_SetActiveLayer_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the active layer number.  This is the layer that will be
		/// used for picking and interaction.
		/// </summary>
		// Token: 0x060038BB RID: 14523 RVA: 0x00052F2F File Offset: 0x0005112F
		public virtual void SetActiveLayer(int _arg)
		{
			vtkImageStack.vtkImageStack_SetActiveLayer_30(base.GetCppThis(), _arg);
		}

		// Token: 0x060038BC RID: 14524
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStack_ShallowCopy_31(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of this prop. Overloads the virtual vtkProp method.
		/// </summary>
		// Token: 0x060038BD RID: 14525 RVA: 0x00052F40 File Offset: 0x00051140
		public override void ShallowCopy(vtkProp prop)
		{
			vtkImageStack.vtkImageStack_ShallowCopy_31(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000662 RID: 1634
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageStack";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000663 RID: 1635
		public new static readonly string MRClassNameKey = "class vtkImageStack";
	}
}
