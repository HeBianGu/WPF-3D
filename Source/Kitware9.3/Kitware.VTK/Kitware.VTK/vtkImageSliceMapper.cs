using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageSliceMapper
	/// </summary>
	/// <remarks>
	///    map a slice of a vtkImageData to the screen
	///
	/// vtkImageSliceMapper is a mapper that will draw a 2D image, or a slice
	/// of a 3D image.  For 3D images, the slice may be oriented in the X, Y,
	/// or Z direction.  This mapper works via 2D textures with accelerated
	/// zoom and pan operations.
	/// @par Thanks:
	/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
	/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageSlice vtkImageProperty vtkImageResliceMapper
	/// </seealso>
	// Token: 0x020005B8 RID: 1464
	public class vtkImageSliceMapper : vtkImageMapper3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010055 RID: 65621 RVA: 0x00164D03 File Offset: 0x00162F03
		static vtkImageSliceMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageSliceMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSliceMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010056 RID: 65622 RVA: 0x00164D2B File Offset: 0x00162F2B
		public vtkImageSliceMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010057 RID: 65623
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSliceMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010058 RID: 65624 RVA: 0x00164D3C File Offset: 0x00162F3C
		public new static vtkImageSliceMapper New()
		{
			vtkImageSliceMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSliceMapper.vtkImageSliceMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSliceMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010059 RID: 65625 RVA: 0x00164D90 File Offset: 0x00162F90
		public vtkImageSliceMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageSliceMapper.vtkImageSliceMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601005A RID: 65626 RVA: 0x00164DD4 File Offset: 0x00162FD4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601005B RID: 65627
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_CroppingOff_01(HandleRef pThis);

		/// <summary>
		/// Use the specified CroppingRegion.  The default is to display
		/// the full slice.
		/// </summary>
		// Token: 0x0601005C RID: 65628 RVA: 0x00164DDF File Offset: 0x00162FDF
		public virtual void CroppingOff()
		{
			vtkImageSliceMapper.vtkImageSliceMapper_CroppingOff_01(base.GetCppThis());
		}

		// Token: 0x0601005D RID: 65629
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_CroppingOn_02(HandleRef pThis);

		/// <summary>
		/// Use the specified CroppingRegion.  The default is to display
		/// the full slice.
		/// </summary>
		// Token: 0x0601005E RID: 65630 RVA: 0x00164DEE File Offset: 0x00162FEE
		public virtual void CroppingOn()
		{
			vtkImageSliceMapper.vtkImageSliceMapper_CroppingOn_02(base.GetCppThis());
		}

		// Token: 0x0601005F RID: 65631
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSliceMapper_GetBounds_03(HandleRef pThis);

		/// <summary>
		/// The bounding box (array of six doubles) of data expressed as
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// </summary>
		// Token: 0x06010060 RID: 65632 RVA: 0x00164E00 File Offset: 0x00163000
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkImageSliceMapper.vtkImageSliceMapper_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06010061 RID: 65633
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_GetBounds_04(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// The bounding box (array of six doubles) of data expressed as
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// </summary>
		// Token: 0x06010062 RID: 65634 RVA: 0x00164E48 File Offset: 0x00163048
		public override void GetBounds(IntPtr bounds)
		{
			vtkImageSliceMapper.vtkImageSliceMapper_GetBounds_04(base.GetCppThis(), bounds);
		}

		// Token: 0x06010063 RID: 65635
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSliceMapper_GetCropping_05(HandleRef pThis);

		/// <summary>
		/// Use the specified CroppingRegion.  The default is to display
		/// the full slice.
		/// </summary>
		// Token: 0x06010064 RID: 65636 RVA: 0x00164E58 File Offset: 0x00163058
		public virtual int GetCropping()
		{
			return vtkImageSliceMapper.vtkImageSliceMapper_GetCropping_05(base.GetCppThis());
		}

		// Token: 0x06010065 RID: 65637
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSliceMapper_GetCroppingRegion_06(HandleRef pThis);

		/// <summary>
		/// Set the display extent.  This is ignored unless Cropping
		/// is set.
		/// </summary>
		// Token: 0x06010066 RID: 65638 RVA: 0x00164E78 File Offset: 0x00163078
		public virtual int[] GetCroppingRegion()
		{
			IntPtr intPtr = vtkImageSliceMapper.vtkImageSliceMapper_GetCroppingRegion_06(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06010067 RID: 65639
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_GetCroppingRegion_07(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Set the display extent.  This is ignored unless Cropping
		/// is set.
		/// </summary>
		// Token: 0x06010068 RID: 65640 RVA: 0x00164EC0 File Offset: 0x001630C0
		public virtual void GetCroppingRegion(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageSliceMapper.vtkImageSliceMapper_GetCroppingRegion_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06010069 RID: 65641
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_GetCroppingRegion_08(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the display extent.  This is ignored unless Cropping
		/// is set.
		/// </summary>
		// Token: 0x0601006A RID: 65642 RVA: 0x00164ED8 File Offset: 0x001630D8
		public virtual void GetCroppingRegion(IntPtr _arg)
		{
			vtkImageSliceMapper.vtkImageSliceMapper_GetCroppingRegion_08(base.GetCppThis(), _arg);
		}

		// Token: 0x0601006B RID: 65643
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_GetIndexBounds_09(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// The bounding box (array of six doubles) of data expressed as
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// </summary>
		// Token: 0x0601006C RID: 65644 RVA: 0x00164EE8 File Offset: 0x001630E8
		public override void GetIndexBounds(IntPtr extent)
		{
			vtkImageSliceMapper.vtkImageSliceMapper_GetIndexBounds_09(base.GetCppThis(), extent);
		}

		// Token: 0x0601006D RID: 65645
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImageSliceMapper_GetMTime_10(HandleRef pThis);

		/// <summary>
		/// Get the mtime for the mapper.
		/// </summary>
		// Token: 0x0601006E RID: 65646 RVA: 0x00164EF8 File Offset: 0x001630F8
		public override ulong GetMTime()
		{
			return vtkImageSliceMapper.vtkImageSliceMapper_GetMTime_10(base.GetCppThis());
		}

		// Token: 0x0601006F RID: 65647
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSliceMapper_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010070 RID: 65648 RVA: 0x00164F18 File Offset: 0x00163118
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageSliceMapper.vtkImageSliceMapper_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x06010071 RID: 65649
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSliceMapper_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010072 RID: 65650 RVA: 0x00164F38 File Offset: 0x00163138
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageSliceMapper.vtkImageSliceMapper_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x06010073 RID: 65651
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSliceMapper_GetOrientation_13(HandleRef pThis);

		/// <summary>
		/// Set the orientation of the slices to display.  The default
		/// orientation is 2, which is K. Not the orientaiton here
		/// is in index space. Not physical or world.
		/// </summary>
		// Token: 0x06010074 RID: 65652 RVA: 0x00164F54 File Offset: 0x00163154
		public virtual int GetOrientation()
		{
			return vtkImageSliceMapper.vtkImageSliceMapper_GetOrientation_13(base.GetCppThis());
		}

		// Token: 0x06010075 RID: 65653
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSliceMapper_GetOrientationMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Set the orientation of the slices to display.  The default
		/// orientation is 2, which is K. Not the orientaiton here
		/// is in index space. Not physical or world.
		/// </summary>
		// Token: 0x06010076 RID: 65654 RVA: 0x00164F74 File Offset: 0x00163174
		public virtual int GetOrientationMaxValue()
		{
			return vtkImageSliceMapper.vtkImageSliceMapper_GetOrientationMaxValue_14(base.GetCppThis());
		}

		// Token: 0x06010077 RID: 65655
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSliceMapper_GetOrientationMinValue_15(HandleRef pThis);

		/// <summary>
		/// Set the orientation of the slices to display.  The default
		/// orientation is 2, which is K. Not the orientaiton here
		/// is in index space. Not physical or world.
		/// </summary>
		// Token: 0x06010078 RID: 65656 RVA: 0x00164F94 File Offset: 0x00163194
		public virtual int GetOrientationMinValue()
		{
			return vtkImageSliceMapper.vtkImageSliceMapper_GetOrientationMinValue_15(base.GetCppThis());
		}

		// Token: 0x06010079 RID: 65657
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSliceMapper_GetSliceNumber_16(HandleRef pThis);

		/// <summary>
		/// The slice to display, if there are multiple slices.
		/// </summary>
		// Token: 0x0601007A RID: 65658 RVA: 0x00164FB4 File Offset: 0x001631B4
		public virtual int GetSliceNumber()
		{
			return vtkImageSliceMapper.vtkImageSliceMapper_GetSliceNumber_16(base.GetCppThis());
		}

		// Token: 0x0601007B RID: 65659
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSliceMapper_GetSliceNumberMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Use GetSliceNumberMinValue() and GetSliceNumberMaxValue()
		/// to get the range of allowed slices.  These methods call
		/// UpdateInformation as a side-effect.
		/// </summary>
		// Token: 0x0601007C RID: 65660 RVA: 0x00164FD4 File Offset: 0x001631D4
		public virtual int GetSliceNumberMaxValue()
		{
			return vtkImageSliceMapper.vtkImageSliceMapper_GetSliceNumberMaxValue_17(base.GetCppThis());
		}

		// Token: 0x0601007D RID: 65661
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSliceMapper_GetSliceNumberMinValue_18(HandleRef pThis);

		/// <summary>
		/// Use GetSliceNumberMinValue() and GetSliceNumberMaxValue()
		/// to get the range of allowed slices.  These methods call
		/// UpdateInformation as a side-effect.
		/// </summary>
		// Token: 0x0601007E RID: 65662 RVA: 0x00164FF4 File Offset: 0x001631F4
		public virtual int GetSliceNumberMinValue()
		{
			return vtkImageSliceMapper.vtkImageSliceMapper_GetSliceNumberMinValue_18(base.GetCppThis());
		}

		// Token: 0x0601007F RID: 65663
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_GetSlicePlaneInDataCoords_19(HandleRef pThis, HandleRef propMatrix, IntPtr plane);

		/// <summary>
		/// Get the plane as a homogeneous 4-vector that gives the plane
		/// equation coefficients.  It is computed from the Orientation
		/// and SliceNumber, the propMatrix is unused and can be zero.
		/// </summary>
		// Token: 0x06010080 RID: 65664 RVA: 0x00165014 File Offset: 0x00163214
		public override void GetSlicePlaneInDataCoords(vtkMatrix4x4 propMatrix, IntPtr plane)
		{
			vtkImageSliceMapper.vtkImageSliceMapper_GetSlicePlaneInDataCoords_19(base.GetCppThis(), (propMatrix == null) ? default(HandleRef) : propMatrix.GetCppThis(), plane);
		}

		// Token: 0x06010081 RID: 65665
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSliceMapper_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010082 RID: 65666 RVA: 0x00165044 File Offset: 0x00163244
		public override int IsA(string type)
		{
			return vtkImageSliceMapper.vtkImageSliceMapper_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x06010083 RID: 65667
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSliceMapper_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010084 RID: 65668 RVA: 0x00165064 File Offset: 0x00163264
		public new static int IsTypeOf(string type)
		{
			return vtkImageSliceMapper.vtkImageSliceMapper_IsTypeOf_21(type);
		}

		// Token: 0x06010085 RID: 65669
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSliceMapper_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010086 RID: 65670 RVA: 0x00165080 File Offset: 0x00163280
		public new vtkImageSliceMapper NewInstance()
		{
			vtkImageSliceMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSliceMapper.vtkImageSliceMapper_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSliceMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010087 RID: 65671
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by
		/// this mapper.  The parameter window is used to determine
		/// which graphic resources to release.
		/// </summary>
		// Token: 0x06010088 RID: 65672 RVA: 0x001650DC File Offset: 0x001632DC
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkImageSliceMapper.vtkImageSliceMapper_ReleaseGraphicsResources_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010089 RID: 65673
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_Render_25(HandleRef pThis, HandleRef renderer, HandleRef prop);

		/// <summary>
		/// This should only be called by the renderer.
		/// </summary>
		// Token: 0x0601008A RID: 65674 RVA: 0x0016510C File Offset: 0x0016330C
		public override void Render(vtkRenderer renderer, vtkImageSlice prop)
		{
			vtkImageSliceMapper.vtkImageSliceMapper_Render_25(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x0601008B RID: 65675
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSliceMapper_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601008C RID: 65676 RVA: 0x00165150 File Offset: 0x00163350
		public new static vtkImageSliceMapper SafeDownCast(vtkObjectBase o)
		{
			vtkImageSliceMapper vtkImageSliceMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSliceMapper.vtkImageSliceMapper_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSliceMapper = (vtkImageSliceMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSliceMapper.Register(null);
				}
			}
			return vtkImageSliceMapper;
		}

		// Token: 0x0601008D RID: 65677
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_SetCropping_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Use the specified CroppingRegion.  The default is to display
		/// the full slice.
		/// </summary>
		// Token: 0x0601008E RID: 65678 RVA: 0x001651CF File Offset: 0x001633CF
		public virtual void SetCropping(int _arg)
		{
			vtkImageSliceMapper.vtkImageSliceMapper_SetCropping_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0601008F RID: 65679
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_SetCroppingRegion_28(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Set the display extent.  This is ignored unless Cropping
		/// is set.
		/// </summary>
		// Token: 0x06010090 RID: 65680 RVA: 0x001651DF File Offset: 0x001633DF
		public virtual void SetCroppingRegion(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkImageSliceMapper.vtkImageSliceMapper_SetCroppingRegion_28(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06010091 RID: 65681
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_SetCroppingRegion_29(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the display extent.  This is ignored unless Cropping
		/// is set.
		/// </summary>
		// Token: 0x06010092 RID: 65682 RVA: 0x001651F7 File Offset: 0x001633F7
		public virtual void SetCroppingRegion(IntPtr _arg)
		{
			vtkImageSliceMapper.vtkImageSliceMapper_SetCroppingRegion_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06010093 RID: 65683
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_SetDisplayExtent_30(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Set the display extent.  For when this mapper is used as a helper
		/// class.
		/// </summary>
		// Token: 0x06010094 RID: 65684 RVA: 0x00165207 File Offset: 0x00163407
		public void SetDisplayExtent(IntPtr extent)
		{
			vtkImageSliceMapper.vtkImageSliceMapper_SetDisplayExtent_30(base.GetCppThis(), extent);
		}

		// Token: 0x06010095 RID: 65685
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_SetOrientation_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the orientation of the slices to display.  The default
		/// orientation is 2, which is K. Not the orientaiton here
		/// is in index space. Not physical or world.
		/// </summary>
		// Token: 0x06010096 RID: 65686 RVA: 0x00165217 File Offset: 0x00163417
		public virtual void SetOrientation(int _arg)
		{
			vtkImageSliceMapper.vtkImageSliceMapper_SetOrientation_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06010097 RID: 65687
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_SetOrientationToI_32(HandleRef pThis);

		/// <summary>
		/// Set the orientation of the slices to display.  The default
		/// orientation is 2, which is K. Not the orientaiton here
		/// is in index space. Not physical or world.
		/// </summary>
		// Token: 0x06010098 RID: 65688 RVA: 0x00165227 File Offset: 0x00163427
		public void SetOrientationToI()
		{
			vtkImageSliceMapper.vtkImageSliceMapper_SetOrientationToI_32(base.GetCppThis());
		}

		// Token: 0x06010099 RID: 65689
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_SetOrientationToJ_33(HandleRef pThis);

		/// <summary>
		/// Set the orientation of the slices to display.  The default
		/// orientation is 2, which is K. Not the orientaiton here
		/// is in index space. Not physical or world.
		/// </summary>
		// Token: 0x0601009A RID: 65690 RVA: 0x00165236 File Offset: 0x00163436
		public void SetOrientationToJ()
		{
			vtkImageSliceMapper.vtkImageSliceMapper_SetOrientationToJ_33(base.GetCppThis());
		}

		// Token: 0x0601009B RID: 65691
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_SetOrientationToK_34(HandleRef pThis);

		/// <summary>
		/// Set the orientation of the slices to display.  The default
		/// orientation is 2, which is K. Not the orientaiton here
		/// is in index space. Not physical or world.
		/// </summary>
		// Token: 0x0601009C RID: 65692 RVA: 0x00165245 File Offset: 0x00163445
		public void SetOrientationToK()
		{
			vtkImageSliceMapper.vtkImageSliceMapper_SetOrientationToK_34(base.GetCppThis());
		}

		// Token: 0x0601009D RID: 65693
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_SetOrientationToX_35(HandleRef pThis);

		/// <summary>
		/// Set the orientation of the slices to display.  The default
		/// orientation is 2, which is K. Not the orientaiton here
		/// is in index space. Not physical or world.
		/// </summary>
		// Token: 0x0601009E RID: 65694 RVA: 0x00165254 File Offset: 0x00163454
		public void SetOrientationToX()
		{
			vtkImageSliceMapper.vtkImageSliceMapper_SetOrientationToX_35(base.GetCppThis());
		}

		// Token: 0x0601009F RID: 65695
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_SetOrientationToY_36(HandleRef pThis);

		/// <summary>
		/// Set the orientation of the slices to display.  The default
		/// orientation is 2, which is K. Not the orientaiton here
		/// is in index space. Not physical or world.
		/// </summary>
		// Token: 0x060100A0 RID: 65696 RVA: 0x00165263 File Offset: 0x00163463
		public void SetOrientationToY()
		{
			vtkImageSliceMapper.vtkImageSliceMapper_SetOrientationToY_36(base.GetCppThis());
		}

		// Token: 0x060100A1 RID: 65697
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_SetOrientationToZ_37(HandleRef pThis);

		/// <summary>
		/// Set the orientation of the slices to display.  The default
		/// orientation is 2, which is K. Not the orientaiton here
		/// is in index space. Not physical or world.
		/// </summary>
		// Token: 0x060100A2 RID: 65698 RVA: 0x00165272 File Offset: 0x00163472
		public void SetOrientationToZ()
		{
			vtkImageSliceMapper.vtkImageSliceMapper_SetOrientationToZ_37(base.GetCppThis());
		}

		// Token: 0x060100A3 RID: 65699
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceMapper_SetSliceNumber_38(HandleRef pThis, int slice);

		/// <summary>
		/// The slice to display, if there are multiple slices.
		/// </summary>
		// Token: 0x060100A4 RID: 65700 RVA: 0x00165281 File Offset: 0x00163481
		public virtual void SetSliceNumber(int slice)
		{
			vtkImageSliceMapper.vtkImageSliceMapper_SetSliceNumber_38(base.GetCppThis(), slice);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012B2 RID: 4786
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageSliceMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012B3 RID: 4787
		public new static readonly string MRClassNameKey = "class vtkImageSliceMapper";
	}
}
