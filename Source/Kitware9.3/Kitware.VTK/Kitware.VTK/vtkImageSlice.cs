using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageSlice
	/// </summary>
	/// <remarks>
	///    represents an image in a 3D scene
	///
	/// vtkImageSlice is used to represent an image in a 3D scene.  It displays
	/// the image either as a slice or as a projection from the camera's
	/// perspective. Adjusting the position and orientation of the slice
	/// is done by adjusting the focal point and direction of the camera,
	/// or alternatively the slice can be set manually in vtkImageMapper3D.
	/// The lookup table and window/level are set in vtkImageProperty.
	/// Prop3D methods such as SetPosition() and RotateWXYZ() change the
	/// position and orientation of the data with respect to VTK world
	/// coordinates.
	/// @par Thanks:
	/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
	/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageMapper3D vtkImageProperty vtkProp3D
	/// </seealso>
	// Token: 0x02000114 RID: 276
	public class vtkImageSlice : vtkProp3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003832 RID: 14386 RVA: 0x00052136 File Offset: 0x00050336
		static vtkImageSlice()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageSlice.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSlice"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003833 RID: 14387 RVA: 0x0005215E File Offset: 0x0005035E
		public vtkImageSlice(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003834 RID: 14388
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSlice_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates an Image with the following defaults: origin(0,0,0)
		/// position=(0,0,0) scale=1 visibility=1 pickable=1 dragable=1
		/// orientation=(0,0,0).
		/// </summary>
		// Token: 0x06003835 RID: 14389 RVA: 0x0005216C File Offset: 0x0005036C
		public new static vtkImageSlice New()
		{
			vtkImageSlice result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSlice.vtkImageSlice_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSlice)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates an Image with the following defaults: origin(0,0,0)
		/// position=(0,0,0) scale=1 visibility=1 pickable=1 dragable=1
		/// orientation=(0,0,0).
		/// </summary>
		// Token: 0x06003836 RID: 14390 RVA: 0x000521C0 File Offset: 0x000503C0
		public vtkImageSlice() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageSlice.vtkImageSlice_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003837 RID: 14391 RVA: 0x00052204 File Offset: 0x00050404
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003838 RID: 14392
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlice_ForceTranslucentOff_01(HandleRef pThis);

		/// <summary>
		/// Force the actor to be treated as translucent.
		/// </summary>
		// Token: 0x06003839 RID: 14393 RVA: 0x0005220F File Offset: 0x0005040F
		public virtual void ForceTranslucentOff()
		{
			vtkImageSlice.vtkImageSlice_ForceTranslucentOff_01(base.GetCppThis());
		}

		// Token: 0x0600383A RID: 14394
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlice_ForceTranslucentOn_02(HandleRef pThis);

		/// <summary>
		/// Force the actor to be treated as translucent.
		/// </summary>
		// Token: 0x0600383B RID: 14395 RVA: 0x0005221E File Offset: 0x0005041E
		public virtual void ForceTranslucentOn()
		{
			vtkImageSlice.vtkImageSlice_ForceTranslucentOn_02(base.GetCppThis());
		}

		// Token: 0x0600383C RID: 14396
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSlice_GetBounds_03(HandleRef pThis);

		/// <summary>
		/// Get the bounds - either all six at once
		/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
		/// </summary>
		// Token: 0x0600383D RID: 14397 RVA: 0x00052230 File Offset: 0x00050430
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkImageSlice.vtkImageSlice_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600383E RID: 14398
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlice_GetBounds_04(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds - either all six at once
		/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
		/// </summary>
		// Token: 0x0600383F RID: 14399 RVA: 0x00052278 File Offset: 0x00050478
		public new void GetBounds(IntPtr bounds)
		{
			vtkImageSlice.vtkImageSlice_GetBounds_04(base.GetCppThis(), bounds);
		}

		// Token: 0x06003840 RID: 14400
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageSlice_GetForceTranslucent_05(HandleRef pThis);

		/// <summary>
		/// Force the actor to be treated as translucent.
		/// </summary>
		// Token: 0x06003841 RID: 14401 RVA: 0x00052288 File Offset: 0x00050488
		public virtual bool GetForceTranslucent()
		{
			return vtkImageSlice.vtkImageSlice_GetForceTranslucent_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06003842 RID: 14402
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlice_GetImages_06(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// For some exporters and other other operations we must be
		/// able to collect all the actors, volumes, and images. These
		/// methods are used in that process.
		/// </summary>
		// Token: 0x06003843 RID: 14403 RVA: 0x000522B0 File Offset: 0x000504B0
		public void GetImages(vtkPropCollection arg0)
		{
			vtkImageSlice.vtkImageSlice_GetImages_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003844 RID: 14404
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImageSlice_GetMTime_07(HandleRef pThis);

		/// <summary>
		/// Return the MTime also considering the property etc.
		/// </summary>
		// Token: 0x06003845 RID: 14405 RVA: 0x000522E0 File Offset: 0x000504E0
		public override ulong GetMTime()
		{
			return vtkImageSlice.vtkImageSlice_GetMTime_07(base.GetCppThis());
		}

		// Token: 0x06003846 RID: 14406
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSlice_GetMapper_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the mapper.
		/// </summary>
		// Token: 0x06003847 RID: 14407 RVA: 0x00052300 File Offset: 0x00050500
		public virtual vtkImageMapper3D GetMapper()
		{
			vtkImageMapper3D vtkImageMapper3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSlice.vtkImageSlice_GetMapper_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003848 RID: 14408
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageSlice_GetMaxXBound_09(HandleRef pThis);

		/// <summary>
		/// Get the bounds - either all six at once
		/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
		/// </summary>
		// Token: 0x06003849 RID: 14409 RVA: 0x00052370 File Offset: 0x00050570
		public double GetMaxXBound()
		{
			return vtkImageSlice.vtkImageSlice_GetMaxXBound_09(base.GetCppThis());
		}

		// Token: 0x0600384A RID: 14410
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageSlice_GetMaxYBound_10(HandleRef pThis);

		/// <summary>
		/// Get the bounds - either all six at once
		/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
		/// </summary>
		// Token: 0x0600384B RID: 14411 RVA: 0x00052390 File Offset: 0x00050590
		public double GetMaxYBound()
		{
			return vtkImageSlice.vtkImageSlice_GetMaxYBound_10(base.GetCppThis());
		}

		// Token: 0x0600384C RID: 14412
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageSlice_GetMaxZBound_11(HandleRef pThis);

		/// <summary>
		/// Get the bounds - either all six at once
		/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
		/// </summary>
		// Token: 0x0600384D RID: 14413 RVA: 0x000523B0 File Offset: 0x000505B0
		public double GetMaxZBound()
		{
			return vtkImageSlice.vtkImageSlice_GetMaxZBound_11(base.GetCppThis());
		}

		// Token: 0x0600384E RID: 14414
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageSlice_GetMinXBound_12(HandleRef pThis);

		/// <summary>
		/// Get the bounds - either all six at once
		/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
		/// </summary>
		// Token: 0x0600384F RID: 14415 RVA: 0x000523D0 File Offset: 0x000505D0
		public double GetMinXBound()
		{
			return vtkImageSlice.vtkImageSlice_GetMinXBound_12(base.GetCppThis());
		}

		// Token: 0x06003850 RID: 14416
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageSlice_GetMinYBound_13(HandleRef pThis);

		/// <summary>
		/// Get the bounds - either all six at once
		/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
		/// </summary>
		// Token: 0x06003851 RID: 14417 RVA: 0x000523F0 File Offset: 0x000505F0
		public double GetMinYBound()
		{
			return vtkImageSlice.vtkImageSlice_GetMinYBound_13(base.GetCppThis());
		}

		// Token: 0x06003852 RID: 14418
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageSlice_GetMinZBound_14(HandleRef pThis);

		/// <summary>
		/// Get the bounds - either all six at once
		/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
		/// </summary>
		// Token: 0x06003853 RID: 14419 RVA: 0x00052410 File Offset: 0x00050610
		public double GetMinZBound()
		{
			return vtkImageSlice.vtkImageSlice_GetMinZBound_14(base.GetCppThis());
		}

		// Token: 0x06003854 RID: 14420
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSlice_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003855 RID: 14421 RVA: 0x00052430 File Offset: 0x00050630
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageSlice.vtkImageSlice_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x06003856 RID: 14422
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSlice_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003857 RID: 14423 RVA: 0x00052450 File Offset: 0x00050650
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageSlice.vtkImageSlice_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x06003858 RID: 14424
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSlice_GetProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the image display properties.
		/// </summary>
		// Token: 0x06003859 RID: 14425 RVA: 0x0005246C File Offset: 0x0005066C
		public virtual vtkImageProperty GetProperty()
		{
			vtkImageProperty vtkImageProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSlice.vtkImageSlice_GetProperty_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600385A RID: 14426
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImageSlice_GetRedrawMTime_18(HandleRef pThis);

		/// <summary>
		/// Return the mtime of anything that would cause the rendered image to
		/// appear differently. Usually this involves checking the mtime of the
		/// prop plus anything else it depends on such as properties, mappers,
		/// etc.
		/// </summary>
		// Token: 0x0600385B RID: 14427 RVA: 0x000524DC File Offset: 0x000506DC
		public override ulong GetRedrawMTime()
		{
			return vtkImageSlice.vtkImageSlice_GetRedrawMTime_18(base.GetCppThis());
		}

		// Token: 0x0600385C RID: 14428
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlice_HasTranslucentPolygonalGeometry_19(HandleRef pThis);

		/// <summary>
		/// Internal method, should only be used by rendering.
		/// This method will always return 0 unless ForceTranslucent is On.
		/// </summary>
		// Token: 0x0600385D RID: 14429 RVA: 0x000524FC File Offset: 0x000506FC
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkImageSlice.vtkImageSlice_HasTranslucentPolygonalGeometry_19(base.GetCppThis());
		}

		// Token: 0x0600385E RID: 14430
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlice_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600385F RID: 14431 RVA: 0x0005251C File Offset: 0x0005071C
		public override int IsA(string type)
		{
			return vtkImageSlice.vtkImageSlice_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x06003860 RID: 14432
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlice_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003861 RID: 14433 RVA: 0x0005253C File Offset: 0x0005073C
		public new static int IsTypeOf(string type)
		{
			return vtkImageSlice.vtkImageSlice_IsTypeOf_21(type);
		}

		// Token: 0x06003862 RID: 14434
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSlice_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003863 RID: 14435 RVA: 0x00052558 File Offset: 0x00050758
		public new vtkImageSlice NewInstance()
		{
			vtkImageSlice result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSlice.vtkImageSlice_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSlice)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003864 RID: 14436
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlice_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef win);

		/// <summary>
		/// Release any resources held by this prop.
		/// </summary>
		// Token: 0x06003865 RID: 14437 RVA: 0x000525B4 File Offset: 0x000507B4
		public override void ReleaseGraphicsResources(vtkWindow win)
		{
			vtkImageSlice.vtkImageSlice_ReleaseGraphicsResources_24(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		// Token: 0x06003866 RID: 14438
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlice_Render_25(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// This causes the image and its mapper to be rendered. Note that a side
		/// effect of this method is that the pipeline will be updated.
		/// </summary>
		// Token: 0x06003867 RID: 14439 RVA: 0x000525E4 File Offset: 0x000507E4
		public virtual void Render(vtkRenderer arg0)
		{
			vtkImageSlice.vtkImageSlice_Render_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003868 RID: 14440
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlice_RenderOpaqueGeometry_26(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x06003869 RID: 14441 RVA: 0x00052614 File Offset: 0x00050814
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkImageSlice.vtkImageSlice_RenderOpaqueGeometry_26(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600386A RID: 14442
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlice_RenderOverlay_27(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x0600386B RID: 14443 RVA: 0x00052648 File Offset: 0x00050848
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkImageSlice.vtkImageSlice_RenderOverlay_27(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600386C RID: 14444
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlice_RenderTranslucentPolygonalGeometry_28(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x0600386D RID: 14445 RVA: 0x0005267C File Offset: 0x0005087C
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkImageSlice.vtkImageSlice_RenderTranslucentPolygonalGeometry_28(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600386E RID: 14446
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSlice_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600386F RID: 14447 RVA: 0x000526B0 File Offset: 0x000508B0
		public new static vtkImageSlice SafeDownCast(vtkObjectBase o)
		{
			vtkImageSlice vtkImageSlice = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSlice.vtkImageSlice_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003870 RID: 14448
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlice_SetForceTranslucent_30(HandleRef pThis, byte _arg);

		/// <summary>
		/// Force the actor to be treated as translucent.
		/// </summary>
		// Token: 0x06003871 RID: 14449 RVA: 0x0005272F File Offset: 0x0005092F
		public virtual void SetForceTranslucent(bool _arg)
		{
			vtkImageSlice.vtkImageSlice_SetForceTranslucent_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06003872 RID: 14450
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlice_SetMapper_31(HandleRef pThis, HandleRef mapper);

		/// <summary>
		/// Set/Get the mapper.
		/// </summary>
		// Token: 0x06003873 RID: 14451 RVA: 0x00052748 File Offset: 0x00050948
		public void SetMapper(vtkImageMapper3D mapper)
		{
			vtkImageSlice.vtkImageSlice_SetMapper_31(base.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		// Token: 0x06003874 RID: 14452
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlice_SetProperty_32(HandleRef pThis, HandleRef property);

		/// <summary>
		/// Set/Get the image display properties.
		/// </summary>
		// Token: 0x06003875 RID: 14453 RVA: 0x00052778 File Offset: 0x00050978
		public void SetProperty(vtkImageProperty property)
		{
			vtkImageSlice.vtkImageSlice_SetProperty_32(base.GetCppThis(), (property == null) ? default(HandleRef) : property.GetCppThis());
		}

		// Token: 0x06003876 RID: 14454
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlice_SetStackedImagePass_33(HandleRef pThis, int pass);

		/// <summary>
		/// For stacked image rendering, set the pass.  The first pass
		/// renders just the backing polygon, the second pass renders
		/// the image, and the third pass renders the depth buffer.
		/// Set to -1 to render all of these in the same pass.
		/// </summary>
		// Token: 0x06003877 RID: 14455 RVA: 0x000527A7 File Offset: 0x000509A7
		public void SetStackedImagePass(int pass)
		{
			vtkImageSlice.vtkImageSlice_SetStackedImagePass_33(base.GetCppThis(), pass);
		}

		// Token: 0x06003878 RID: 14456
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlice_ShallowCopy_34(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of this vtkImageSlice. Overloads the virtual vtkProp method.
		/// </summary>
		// Token: 0x06003879 RID: 14457 RVA: 0x000527B8 File Offset: 0x000509B8
		public override void ShallowCopy(vtkProp prop)
		{
			vtkImageSlice.vtkImageSlice_ShallowCopy_34(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x0600387A RID: 14458
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlice_Update_35(HandleRef pThis);

		/// <summary>
		/// Update the rendering pipeline by updating the ImageMapper
		/// </summary>
		// Token: 0x0600387B RID: 14459 RVA: 0x000527E7 File Offset: 0x000509E7
		public void Update()
		{
			vtkImageSlice.vtkImageSlice_Update_35(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000660 RID: 1632
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageSlice";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000661 RID: 1633
		public new static readonly string MRClassNameKey = "class vtkImageSlice";
	}
}
