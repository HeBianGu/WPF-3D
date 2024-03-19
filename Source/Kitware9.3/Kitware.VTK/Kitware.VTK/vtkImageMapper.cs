using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageMapper
	/// </summary>
	/// <remarks>
	///    2D image display
	///
	/// vtkImageMapper provides 2D image display support for vtk.
	/// It is a Mapper2D subclass that can be associated with an Actor2D
	/// and placed within a RenderWindow or ImageWindow.
	/// The vtkImageMapper is a 2D mapper, which means that it displays images
	/// in display coordinates. In display coordinates, one image pixel is
	/// always one screen pixel.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMapper2D vtkActor2D
	/// </seealso>
	// Token: 0x020005B6 RID: 1462
	public class vtkImageMapper : vtkMapper2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FFF5 RID: 65525 RVA: 0x00164427 File Offset: 0x00162627
		static vtkImageMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FFF6 RID: 65526 RVA: 0x0016444F File Offset: 0x0016264F
		public vtkImageMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FFF7 RID: 65527
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFF8 RID: 65528 RVA: 0x00164460 File Offset: 0x00162660
		public new static vtkImageMapper New()
		{
			vtkImageMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMapper.vtkImageMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFF9 RID: 65529 RVA: 0x001644B4 File Offset: 0x001626B4
		public vtkImageMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageMapper.vtkImageMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FFFA RID: 65530 RVA: 0x001644F8 File Offset: 0x001626F8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FFFB RID: 65531
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageMapper_GetColorLevel_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the level value for window/level
		/// </summary>
		// Token: 0x0600FFFC RID: 65532 RVA: 0x00164504 File Offset: 0x00162704
		public virtual double GetColorLevel()
		{
			return vtkImageMapper.vtkImageMapper_GetColorLevel_01(base.GetCppThis());
		}

		// Token: 0x0600FFFD RID: 65533
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageMapper_GetColorScale_02(HandleRef pThis);

		/// <summary>
		/// Methods used internally for performing the Window/Level mapping.
		/// </summary>
		// Token: 0x0600FFFE RID: 65534 RVA: 0x00164524 File Offset: 0x00162724
		public double GetColorScale()
		{
			return vtkImageMapper.vtkImageMapper_GetColorScale_02(base.GetCppThis());
		}

		// Token: 0x0600FFFF RID: 65535
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageMapper_GetColorShift_03(HandleRef pThis);

		/// <summary>
		/// Methods used internally for performing the Window/Level mapping.
		/// </summary>
		// Token: 0x06010000 RID: 65536 RVA: 0x00164544 File Offset: 0x00162744
		public double GetColorShift()
		{
			return vtkImageMapper.vtkImageMapper_GetColorShift_03(base.GetCppThis());
		}

		// Token: 0x06010001 RID: 65537
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageMapper_GetColorWindow_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the window value for window/level
		/// </summary>
		// Token: 0x06010002 RID: 65538 RVA: 0x00164564 File Offset: 0x00162764
		public virtual double GetColorWindow()
		{
			return vtkImageMapper.vtkImageMapper_GetColorWindow_04(base.GetCppThis());
		}

		// Token: 0x06010003 RID: 65539
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapper_GetCustomDisplayExtents_05(HandleRef pThis);

		/// <summary>
		/// The image extents which should be displayed with UseCustomExtents
		/// Note that the Custom extents are x,y only and the zslice is still
		/// applied
		/// </summary>
		// Token: 0x06010004 RID: 65540 RVA: 0x00164584 File Offset: 0x00162784
		public virtual int[] GetCustomDisplayExtents()
		{
			IntPtr intPtr = vtkImageMapper.vtkImageMapper_GetCustomDisplayExtents_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06010005 RID: 65541
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper_GetCustomDisplayExtents_06(HandleRef pThis, IntPtr data);

		/// <summary>
		/// The image extents which should be displayed with UseCustomExtents
		/// Note that the Custom extents are x,y only and the zslice is still
		/// applied
		/// </summary>
		// Token: 0x06010006 RID: 65542 RVA: 0x001645CC File Offset: 0x001627CC
		public virtual void GetCustomDisplayExtents(IntPtr data)
		{
			vtkImageMapper.vtkImageMapper_GetCustomDisplayExtents_06(base.GetCppThis(), data);
		}

		// Token: 0x06010007 RID: 65543
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapper_GetInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the Input of a filter.
		/// </summary>
		// Token: 0x06010008 RID: 65544 RVA: 0x001645DC File Offset: 0x001627DC
		public vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMapper.vtkImageMapper_GetInput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06010009 RID: 65545
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImageMapper_GetMTime_08(HandleRef pThis);

		/// <summary>
		/// Override Modifiedtime as we have added a lookuptable
		/// </summary>
		// Token: 0x0601000A RID: 65546 RVA: 0x0016464C File Offset: 0x0016284C
		public override ulong GetMTime()
		{
			return vtkImageMapper.vtkImageMapper_GetMTime_08(base.GetCppThis());
		}

		// Token: 0x0601000B RID: 65547
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMapper_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601000C RID: 65548 RVA: 0x0016466C File Offset: 0x0016286C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageMapper.vtkImageMapper_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0601000D RID: 65549
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMapper_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601000E RID: 65550 RVA: 0x0016468C File Offset: 0x0016288C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageMapper.vtkImageMapper_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0601000F RID: 65551
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapper_GetRenderToRectangle_11(HandleRef pThis);

		/// <summary>
		/// If RenderToRectangle is set (by default not), then the imagemapper
		/// will render the image into the rectangle supplied by the Actor2D's
		/// PositionCoordinate and Position2Coordinate
		/// </summary>
		// Token: 0x06010010 RID: 65552 RVA: 0x001646A8 File Offset: 0x001628A8
		public virtual int GetRenderToRectangle()
		{
			return vtkImageMapper.vtkImageMapper_GetRenderToRectangle_11(base.GetCppThis());
		}

		// Token: 0x06010011 RID: 65553
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapper_GetUseCustomExtents_12(HandleRef pThis);

		/// <summary>
		/// Usually, the entire image is displayed, if UseCustomExtents
		/// is set (by default not), then the region supplied in the
		/// CustomDisplayExtents is used in preference.
		/// Note that the Custom extents are x,y only and the zslice is still
		/// applied
		/// </summary>
		// Token: 0x06010012 RID: 65554 RVA: 0x001646C8 File Offset: 0x001628C8
		public virtual int GetUseCustomExtents()
		{
			return vtkImageMapper.vtkImageMapper_GetUseCustomExtents_12(base.GetCppThis());
		}

		// Token: 0x06010013 RID: 65555
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapper_GetWholeZMax_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the current slice number. The axis Z in ZSlice does not
		/// necessarily have any relation to the z axis of the data on disk.
		/// It is simply the axis orthogonal to the x,y, display plane.
		/// GetWholeZMax and Min are convenience methods for obtaining
		/// the number of slices that can be displayed. Again the number
		/// of slices is in reference to the display z axis, which is not
		/// necessarily the z axis on disk. (due to reformatting etc)
		/// </summary>
		// Token: 0x06010014 RID: 65556 RVA: 0x001646E8 File Offset: 0x001628E8
		public int GetWholeZMax()
		{
			return vtkImageMapper.vtkImageMapper_GetWholeZMax_13(base.GetCppThis());
		}

		// Token: 0x06010015 RID: 65557
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapper_GetWholeZMin_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the current slice number. The axis Z in ZSlice does not
		/// necessarily have any relation to the z axis of the data on disk.
		/// It is simply the axis orthogonal to the x,y, display plane.
		/// GetWholeZMax and Min are convenience methods for obtaining
		/// the number of slices that can be displayed. Again the number
		/// of slices is in reference to the display z axis, which is not
		/// necessarily the z axis on disk. (due to reformatting etc)
		/// </summary>
		// Token: 0x06010016 RID: 65558 RVA: 0x00164708 File Offset: 0x00162908
		public int GetWholeZMin()
		{
			return vtkImageMapper.vtkImageMapper_GetWholeZMin_14(base.GetCppThis());
		}

		// Token: 0x06010017 RID: 65559
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapper_GetZSlice_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the current slice number. The axis Z in ZSlice does not
		/// necessarily have any relation to the z axis of the data on disk.
		/// It is simply the axis orthogonal to the x,y, display plane.
		/// GetWholeZMax and Min are convenience methods for obtaining
		/// the number of slices that can be displayed. Again the number
		/// of slices is in reference to the display z axis, which is not
		/// necessarily the z axis on disk. (due to reformatting etc)
		/// </summary>
		// Token: 0x06010018 RID: 65560 RVA: 0x00164728 File Offset: 0x00162928
		public virtual int GetZSlice()
		{
			return vtkImageMapper.vtkImageMapper_GetZSlice_15(base.GetCppThis());
		}

		// Token: 0x06010019 RID: 65561
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapper_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601001A RID: 65562 RVA: 0x00164748 File Offset: 0x00162948
		public override int IsA(string type)
		{
			return vtkImageMapper.vtkImageMapper_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0601001B RID: 65563
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapper_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601001C RID: 65564 RVA: 0x00164768 File Offset: 0x00162968
		public new static int IsTypeOf(string type)
		{
			return vtkImageMapper.vtkImageMapper_IsTypeOf_17(type);
		}

		// Token: 0x0601001D RID: 65565
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapper_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601001E RID: 65566 RVA: 0x00164784 File Offset: 0x00162984
		public new vtkImageMapper NewInstance()
		{
			vtkImageMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMapper.vtkImageMapper_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601001F RID: 65567
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper_RenderData_20(HandleRef pThis, HandleRef arg0, HandleRef arg1, HandleRef arg2);

		/// <summary>
		/// Function called by Render to actually draw the image to to the screen
		/// </summary>
		// Token: 0x06010020 RID: 65568 RVA: 0x001647E0 File Offset: 0x001629E0
		public virtual void RenderData(vtkViewport arg0, vtkImageData arg1, vtkActor2D arg2)
		{
			vtkImageMapper.vtkImageMapper_RenderData_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), (arg2 == null) ? default(HandleRef) : arg2.GetCppThis());
		}

		// Token: 0x06010021 RID: 65569
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper_RenderStart_21(HandleRef pThis, HandleRef viewport, HandleRef actor);

		/// <summary>
		/// Draw the image to the screen.
		/// </summary>
		// Token: 0x06010022 RID: 65570 RVA: 0x0016483C File Offset: 0x00162A3C
		public void RenderStart(vtkViewport viewport, vtkActor2D actor)
		{
			vtkImageMapper.vtkImageMapper_RenderStart_21(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		// Token: 0x06010023 RID: 65571
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper_RenderToRectangleOff_22(HandleRef pThis);

		/// <summary>
		/// If RenderToRectangle is set (by default not), then the imagemapper
		/// will render the image into the rectangle supplied by the Actor2D's
		/// PositionCoordinate and Position2Coordinate
		/// </summary>
		// Token: 0x06010024 RID: 65572 RVA: 0x00164880 File Offset: 0x00162A80
		public virtual void RenderToRectangleOff()
		{
			vtkImageMapper.vtkImageMapper_RenderToRectangleOff_22(base.GetCppThis());
		}

		// Token: 0x06010025 RID: 65573
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper_RenderToRectangleOn_23(HandleRef pThis);

		/// <summary>
		/// If RenderToRectangle is set (by default not), then the imagemapper
		/// will render the image into the rectangle supplied by the Actor2D's
		/// PositionCoordinate and Position2Coordinate
		/// </summary>
		// Token: 0x06010026 RID: 65574 RVA: 0x0016488F File Offset: 0x00162A8F
		public virtual void RenderToRectangleOn()
		{
			vtkImageMapper.vtkImageMapper_RenderToRectangleOn_23(base.GetCppThis());
		}

		// Token: 0x06010027 RID: 65575
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapper_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010028 RID: 65576 RVA: 0x001648A0 File Offset: 0x00162AA0
		public new static vtkImageMapper SafeDownCast(vtkObjectBase o)
		{
			vtkImageMapper vtkImageMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMapper.vtkImageMapper_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMapper = (vtkImageMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMapper.Register(null);
				}
			}
			return vtkImageMapper;
		}

		// Token: 0x06010029 RID: 65577
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper_SetColorLevel_25(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the level value for window/level
		/// </summary>
		// Token: 0x0601002A RID: 65578 RVA: 0x0016491F File Offset: 0x00162B1F
		public virtual void SetColorLevel(double _arg)
		{
			vtkImageMapper.vtkImageMapper_SetColorLevel_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0601002B RID: 65579
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper_SetColorWindow_26(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the window value for window/level
		/// </summary>
		// Token: 0x0601002C RID: 65580 RVA: 0x0016492F File Offset: 0x00162B2F
		public virtual void SetColorWindow(double _arg)
		{
			vtkImageMapper.vtkImageMapper_SetColorWindow_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0601002D RID: 65581
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper_SetCustomDisplayExtents_27(HandleRef pThis, IntPtr data);

		/// <summary>
		/// The image extents which should be displayed with UseCustomExtents
		/// Note that the Custom extents are x,y only and the zslice is still
		/// applied
		/// </summary>
		// Token: 0x0601002E RID: 65582 RVA: 0x0016493F File Offset: 0x00162B3F
		public virtual void SetCustomDisplayExtents(IntPtr data)
		{
			vtkImageMapper.vtkImageMapper_SetCustomDisplayExtents_27(base.GetCppThis(), data);
		}

		// Token: 0x0601002F RID: 65583
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper_SetInputData_28(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set the Input of a filter.
		/// </summary>
		// Token: 0x06010030 RID: 65584 RVA: 0x00164950 File Offset: 0x00162B50
		public virtual void SetInputData(vtkImageData input)
		{
			vtkImageMapper.vtkImageMapper_SetInputData_28(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06010031 RID: 65585
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper_SetRenderToRectangle_29(HandleRef pThis, int _arg);

		/// <summary>
		/// If RenderToRectangle is set (by default not), then the imagemapper
		/// will render the image into the rectangle supplied by the Actor2D's
		/// PositionCoordinate and Position2Coordinate
		/// </summary>
		// Token: 0x06010032 RID: 65586 RVA: 0x0016497F File Offset: 0x00162B7F
		public virtual void SetRenderToRectangle(int _arg)
		{
			vtkImageMapper.vtkImageMapper_SetRenderToRectangle_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06010033 RID: 65587
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper_SetUseCustomExtents_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Usually, the entire image is displayed, if UseCustomExtents
		/// is set (by default not), then the region supplied in the
		/// CustomDisplayExtents is used in preference.
		/// Note that the Custom extents are x,y only and the zslice is still
		/// applied
		/// </summary>
		// Token: 0x06010034 RID: 65588 RVA: 0x0016498F File Offset: 0x00162B8F
		public virtual void SetUseCustomExtents(int _arg)
		{
			vtkImageMapper.vtkImageMapper_SetUseCustomExtents_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06010035 RID: 65589
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper_SetZSlice_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the current slice number. The axis Z in ZSlice does not
		/// necessarily have any relation to the z axis of the data on disk.
		/// It is simply the axis orthogonal to the x,y, display plane.
		/// GetWholeZMax and Min are convenience methods for obtaining
		/// the number of slices that can be displayed. Again the number
		/// of slices is in reference to the display z axis, which is not
		/// necessarily the z axis on disk. (due to reformatting etc)
		/// </summary>
		// Token: 0x06010036 RID: 65590 RVA: 0x0016499F File Offset: 0x00162B9F
		public virtual void SetZSlice(int _arg)
		{
			vtkImageMapper.vtkImageMapper_SetZSlice_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06010037 RID: 65591
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper_UseCustomExtentsOff_32(HandleRef pThis);

		/// <summary>
		/// Usually, the entire image is displayed, if UseCustomExtents
		/// is set (by default not), then the region supplied in the
		/// CustomDisplayExtents is used in preference.
		/// Note that the Custom extents are x,y only and the zslice is still
		/// applied
		/// </summary>
		// Token: 0x06010038 RID: 65592 RVA: 0x001649AF File Offset: 0x00162BAF
		public virtual void UseCustomExtentsOff()
		{
			vtkImageMapper.vtkImageMapper_UseCustomExtentsOff_32(base.GetCppThis());
		}

		// Token: 0x06010039 RID: 65593
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapper_UseCustomExtentsOn_33(HandleRef pThis);

		/// <summary>
		/// Usually, the entire image is displayed, if UseCustomExtents
		/// is set (by default not), then the region supplied in the
		/// CustomDisplayExtents is used in preference.
		/// Note that the Custom extents are x,y only and the zslice is still
		/// applied
		/// </summary>
		// Token: 0x0601003A RID: 65594 RVA: 0x001649BE File Offset: 0x00162BBE
		public virtual void UseCustomExtentsOn()
		{
			vtkImageMapper.vtkImageMapper_UseCustomExtentsOn_33(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012AE RID: 4782
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012AF RID: 4783
		public new static readonly string MRClassNameKey = "class vtkImageMapper";
	}
}
