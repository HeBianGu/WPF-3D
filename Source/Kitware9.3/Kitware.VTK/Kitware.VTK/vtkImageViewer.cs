using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageViewer
	/// </summary>
	/// <remarks>
	///    Display a 2d image.
	///
	/// vtkImageViewer is a convenience class for displaying a 2d image.  It
	/// packages up the functionality found in vtkRenderWindow, vtkRenderer,
	/// vtkActor2D and vtkImageMapper into a single easy to use class.  Behind the
	/// scenes these four classes are actually used to to provide the required
	/// functionality. vtkImageViewer is simply a wrapper around them.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderWindow vtkRenderer vtkImageMapper vtkActor2D
	/// </seealso>
	// Token: 0x0200022D RID: 557
	public class vtkImageViewer : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600683D RID: 26685 RVA: 0x00096ADF File Offset: 0x00094CDF
		static vtkImageViewer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageViewer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageViewer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600683E RID: 26686 RVA: 0x00096B07 File Offset: 0x00094D07
		public vtkImageViewer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600683F RID: 26687
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006840 RID: 26688 RVA: 0x00096B18 File Offset: 0x00094D18
		public new static vtkImageViewer New()
		{
			vtkImageViewer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageViewer.vtkImageViewer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageViewer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006841 RID: 26689 RVA: 0x00096B6C File Offset: 0x00094D6C
		public vtkImageViewer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageViewer.vtkImageViewer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006842 RID: 26690 RVA: 0x00096BB0 File Offset: 0x00094DB0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006843 RID: 26691
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer_GetActor2D_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the internal objects
		/// </summary>
		// Token: 0x06006844 RID: 26692 RVA: 0x00096BBC File Offset: 0x00094DBC
		public virtual vtkActor2D GetActor2D()
		{
			vtkActor2D vtkActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageViewer.vtkImageViewer_GetActor2D_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor2D = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor2D.Register(null);
				}
			}
			return vtkActor2D;
		}

		// Token: 0x06006845 RID: 26693
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageViewer_GetColorLevel_02(HandleRef pThis);

		/// <summary>
		/// Sets window/level for mapping pixels to colors.
		/// </summary>
		// Token: 0x06006846 RID: 26694 RVA: 0x00096C2C File Offset: 0x00094E2C
		public double GetColorLevel()
		{
			return vtkImageViewer.vtkImageViewer_GetColorLevel_02(base.GetCppThis());
		}

		// Token: 0x06006847 RID: 26695
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageViewer_GetColorWindow_03(HandleRef pThis);

		/// <summary>
		/// Sets window/level for mapping pixels to colors.
		/// </summary>
		// Token: 0x06006848 RID: 26696 RVA: 0x00096C4C File Offset: 0x00094E4C
		public double GetColorWindow()
		{
			return vtkImageViewer.vtkImageViewer_GetColorWindow_03(base.GetCppThis());
		}

		// Token: 0x06006849 RID: 26697
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer_GetImageMapper_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the internal objects
		/// </summary>
		// Token: 0x0600684A RID: 26698 RVA: 0x00096C6C File Offset: 0x00094E6C
		public virtual vtkImageMapper GetImageMapper()
		{
			vtkImageMapper vtkImageMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageViewer.vtkImageViewer_GetImageMapper_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600684B RID: 26699
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer_GetInput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the input to the viewer.
		/// </summary>
		// Token: 0x0600684C RID: 26700 RVA: 0x00096CDC File Offset: 0x00094EDC
		public vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageViewer.vtkImageViewer_GetInput_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600684D RID: 26701
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageViewer_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600684E RID: 26702 RVA: 0x00096D4C File Offset: 0x00094F4C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageViewer.vtkImageViewer_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600684F RID: 26703
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageViewer_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006850 RID: 26704 RVA: 0x00096D6C File Offset: 0x00094F6C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageViewer.vtkImageViewer_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06006851 RID: 26705
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageViewer_GetOffScreenRendering_08(HandleRef pThis);

		/// <summary>
		/// Create a window in memory instead of on the screen. This may not
		/// be supported for every type of window and on some windows you may
		/// need to invoke this prior to the first render.
		/// </summary>
		// Token: 0x06006852 RID: 26706 RVA: 0x00096D88 File Offset: 0x00094F88
		public int GetOffScreenRendering()
		{
			return vtkImageViewer.vtkImageViewer_GetOffScreenRendering_08(base.GetCppThis());
		}

		// Token: 0x06006853 RID: 26707
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer_GetPosition_09(HandleRef pThis);

		/// <summary>
		/// Get the position (x and y) of the rendering window in
		/// screen coordinates (in pixels).
		/// </summary>
		// Token: 0x06006854 RID: 26708 RVA: 0x00096DA8 File Offset: 0x00094FA8
		public int[] GetPosition()
		{
			IntPtr intPtr = vtkImageViewer.vtkImageViewer_GetPosition_09(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006855 RID: 26709
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer_GetRenderWindow_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the internal objects
		/// </summary>
		// Token: 0x06006856 RID: 26710 RVA: 0x00096DF0 File Offset: 0x00094FF0
		public virtual vtkRenderWindow GetRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageViewer.vtkImageViewer_GetRenderWindow_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		// Token: 0x06006857 RID: 26711
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer_GetRenderer_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the internal objects
		/// </summary>
		// Token: 0x06006858 RID: 26712 RVA: 0x00096E60 File Offset: 0x00095060
		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageViewer.vtkImageViewer_GetRenderer_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06006859 RID: 26713
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer_GetSize_12(HandleRef pThis);

		/// <summary>
		/// Get the size (width and height) of the rendering window in
		/// screen coordinates (in pixels).
		/// </summary>
		// Token: 0x0600685A RID: 26714 RVA: 0x00096ED0 File Offset: 0x000950D0
		public int[] GetSize()
		{
			IntPtr intPtr = vtkImageViewer.vtkImageViewer_GetSize_12(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600685B RID: 26715
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageViewer_GetWholeZMax_13(HandleRef pThis);

		/// <summary>
		/// What is the possible Min/ Max z slices available.
		/// </summary>
		// Token: 0x0600685C RID: 26716 RVA: 0x00096F18 File Offset: 0x00095118
		public int GetWholeZMax()
		{
			return vtkImageViewer.vtkImageViewer_GetWholeZMax_13(base.GetCppThis());
		}

		// Token: 0x0600685D RID: 26717
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageViewer_GetWholeZMin_14(HandleRef pThis);

		/// <summary>
		/// What is the possible Min/ Max z slices available.
		/// </summary>
		// Token: 0x0600685E RID: 26718 RVA: 0x00096F38 File Offset: 0x00095138
		public int GetWholeZMin()
		{
			return vtkImageViewer.vtkImageViewer_GetWholeZMin_14(base.GetCppThis());
		}

		// Token: 0x0600685F RID: 26719
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer_GetWindowName_15(HandleRef pThis);

		/// <summary>
		/// Get name of rendering window
		/// </summary>
		// Token: 0x06006860 RID: 26720 RVA: 0x00096F58 File Offset: 0x00095158
		public string GetWindowName()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageViewer.vtkImageViewer_GetWindowName_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006861 RID: 26721
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageViewer_GetZSlice_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the current Z Slice to display
		/// </summary>
		// Token: 0x06006862 RID: 26722 RVA: 0x00096F94 File Offset: 0x00095194
		public int GetZSlice()
		{
			return vtkImageViewer.vtkImageViewer_GetZSlice_16(base.GetCppThis());
		}

		// Token: 0x06006863 RID: 26723
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageViewer_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006864 RID: 26724 RVA: 0x00096FB4 File Offset: 0x000951B4
		public override int IsA(string type)
		{
			return vtkImageViewer.vtkImageViewer_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x06006865 RID: 26725
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageViewer_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006866 RID: 26726 RVA: 0x00096FD4 File Offset: 0x000951D4
		public new static int IsTypeOf(string type)
		{
			return vtkImageViewer.vtkImageViewer_IsTypeOf_18(type);
		}

		// Token: 0x06006867 RID: 26727
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006868 RID: 26728 RVA: 0x00096FF0 File Offset: 0x000951F0
		public new vtkImageViewer NewInstance()
		{
			vtkImageViewer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageViewer.vtkImageViewer_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageViewer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006869 RID: 26729
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer_OffScreenRenderingOff_21(HandleRef pThis);

		/// <summary>
		/// Create a window in memory instead of on the screen. This may not
		/// be supported for every type of window and on some windows you may
		/// need to invoke this prior to the first render.
		/// </summary>
		// Token: 0x0600686A RID: 26730 RVA: 0x0009704A File Offset: 0x0009524A
		public void OffScreenRenderingOff()
		{
			vtkImageViewer.vtkImageViewer_OffScreenRenderingOff_21(base.GetCppThis());
		}

		// Token: 0x0600686B RID: 26731
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer_OffScreenRenderingOn_22(HandleRef pThis);

		/// <summary>
		/// Create a window in memory instead of on the screen. This may not
		/// be supported for every type of window and on some windows you may
		/// need to invoke this prior to the first render.
		/// </summary>
		// Token: 0x0600686C RID: 26732 RVA: 0x00097059 File Offset: 0x00095259
		public void OffScreenRenderingOn()
		{
			vtkImageViewer.vtkImageViewer_OffScreenRenderingOn_22(base.GetCppThis());
		}

		// Token: 0x0600686D RID: 26733
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer_Render_23(HandleRef pThis);

		/// <summary>
		/// Render the resulting image.
		/// </summary>
		// Token: 0x0600686E RID: 26734 RVA: 0x00097068 File Offset: 0x00095268
		public virtual void Render()
		{
			vtkImageViewer.vtkImageViewer_Render_23(base.GetCppThis());
		}

		// Token: 0x0600686F RID: 26735
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006870 RID: 26736 RVA: 0x00097078 File Offset: 0x00095278
		public new static vtkImageViewer SafeDownCast(vtkObjectBase o)
		{
			vtkImageViewer vtkImageViewer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageViewer.vtkImageViewer_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageViewer = (vtkImageViewer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageViewer.Register(null);
				}
			}
			return vtkImageViewer;
		}

		// Token: 0x06006871 RID: 26737
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer_SetColorLevel_25(HandleRef pThis, double s);

		/// <summary>
		/// Sets window/level for mapping pixels to colors.
		/// </summary>
		// Token: 0x06006872 RID: 26738 RVA: 0x000970F7 File Offset: 0x000952F7
		public void SetColorLevel(double s)
		{
			vtkImageViewer.vtkImageViewer_SetColorLevel_25(base.GetCppThis(), s);
		}

		// Token: 0x06006873 RID: 26739
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer_SetColorWindow_26(HandleRef pThis, double s);

		/// <summary>
		/// Sets window/level for mapping pixels to colors.
		/// </summary>
		// Token: 0x06006874 RID: 26740 RVA: 0x00097107 File Offset: 0x00095307
		public void SetColorWindow(double s)
		{
			vtkImageViewer.vtkImageViewer_SetColorWindow_26(base.GetCppThis(), s);
		}

		// Token: 0x06006875 RID: 26741
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer_SetDisplayId_27(HandleRef pThis, IntPtr a);

		/// <summary>
		/// These are here for using a tk window.
		/// </summary>
		// Token: 0x06006876 RID: 26742 RVA: 0x00097117 File Offset: 0x00095317
		public void SetDisplayId(IntPtr a)
		{
			vtkImageViewer.vtkImageViewer_SetDisplayId_27(base.GetCppThis(), a);
		}

		// Token: 0x06006877 RID: 26743
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer_SetInputConnection_28(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set/Get the input to the viewer.
		/// </summary>
		// Token: 0x06006878 RID: 26744 RVA: 0x00097128 File Offset: 0x00095328
		public virtual void SetInputConnection(vtkAlgorithmOutput input)
		{
			vtkImageViewer.vtkImageViewer_SetInputConnection_28(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06006879 RID: 26745
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer_SetInputData_29(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the input to the viewer.
		/// </summary>
		// Token: 0x0600687A RID: 26746 RVA: 0x00097158 File Offset: 0x00095358
		public void SetInputData(vtkImageData arg0)
		{
			vtkImageViewer.vtkImageViewer_SetInputData_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600687B RID: 26747
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer_SetOffScreenRendering_30(HandleRef pThis, int arg0);

		/// <summary>
		/// Create a window in memory instead of on the screen. This may not
		/// be supported for every type of window and on some windows you may
		/// need to invoke this prior to the first render.
		/// </summary>
		// Token: 0x0600687C RID: 26748 RVA: 0x00097187 File Offset: 0x00095387
		public void SetOffScreenRendering(int arg0)
		{
			vtkImageViewer.vtkImageViewer_SetOffScreenRendering_30(base.GetCppThis(), arg0);
		}

		// Token: 0x0600687D RID: 26749
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer_SetParentId_31(HandleRef pThis, IntPtr a);

		/// <summary>
		/// These are here for using a tk window.
		/// </summary>
		// Token: 0x0600687E RID: 26750 RVA: 0x00097197 File Offset: 0x00095397
		public void SetParentId(IntPtr a)
		{
			vtkImageViewer.vtkImageViewer_SetParentId_31(base.GetCppThis(), a);
		}

		// Token: 0x0600687F RID: 26751
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer_SetPosition_32(HandleRef pThis, int x, int y);

		/// <summary>
		/// Set the position (x and y) of the rendering window in
		/// screen coordinates (in pixels). This resizes the operating
		/// system's view/window and redraws it.
		/// </summary>
		// Token: 0x06006880 RID: 26752 RVA: 0x000971A7 File Offset: 0x000953A7
		public void SetPosition(int x, int y)
		{
			vtkImageViewer.vtkImageViewer_SetPosition_32(base.GetCppThis(), x, y);
		}

		// Token: 0x06006881 RID: 26753
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer_SetPosition_33(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set the position (x and y) of the rendering window in
		/// screen coordinates (in pixels). This resizes the operating
		/// system's view/window and redraws it.
		/// </summary>
		// Token: 0x06006882 RID: 26754 RVA: 0x000971B8 File Offset: 0x000953B8
		public virtual void SetPosition(IntPtr a)
		{
			vtkImageViewer.vtkImageViewer_SetPosition_33(base.GetCppThis(), a);
		}

		// Token: 0x06006883 RID: 26755
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer_SetRenderWindow_34(HandleRef pThis, HandleRef renWin);

		/// <summary>
		/// Get the internal objects
		/// </summary>
		// Token: 0x06006884 RID: 26756 RVA: 0x000971C8 File Offset: 0x000953C8
		public void SetRenderWindow(vtkRenderWindow renWin)
		{
			vtkImageViewer.vtkImageViewer_SetRenderWindow_34(base.GetCppThis(), (renWin == null) ? default(HandleRef) : renWin.GetCppThis());
		}

		// Token: 0x06006885 RID: 26757
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer_SetSize_35(HandleRef pThis, int width, int height);

		/// <summary>
		/// Set the size (width and height) of the rendering window in
		/// screen coordinates (in pixels). This resizes the operating
		/// system's view/window and redraws it.
		///
		/// If the size has changed, this method will fire
		/// vtkCommand::WindowResizeEvent.
		/// </summary>
		// Token: 0x06006886 RID: 26758 RVA: 0x000971F7 File Offset: 0x000953F7
		public void SetSize(int width, int height)
		{
			vtkImageViewer.vtkImageViewer_SetSize_35(base.GetCppThis(), width, height);
		}

		// Token: 0x06006887 RID: 26759
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer_SetSize_36(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set the size (width and height) of the rendering window in
		/// screen coordinates (in pixels). This resizes the operating
		/// system's view/window and redraws it.
		///
		/// If the size has changed, this method will fire
		/// vtkCommand::WindowResizeEvent.
		/// </summary>
		// Token: 0x06006888 RID: 26760 RVA: 0x00097208 File Offset: 0x00095408
		public virtual void SetSize(IntPtr a)
		{
			vtkImageViewer.vtkImageViewer_SetSize_36(base.GetCppThis(), a);
		}

		// Token: 0x06006889 RID: 26761
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer_SetWindowId_37(HandleRef pThis, IntPtr a);

		/// <summary>
		/// These are here for using a tk window.
		/// </summary>
		// Token: 0x0600688A RID: 26762 RVA: 0x00097218 File Offset: 0x00095418
		public void SetWindowId(IntPtr a)
		{
			vtkImageViewer.vtkImageViewer_SetWindowId_37(base.GetCppThis(), a);
		}

		// Token: 0x0600688B RID: 26763
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer_SetZSlice_38(HandleRef pThis, int s);

		/// <summary>
		/// Set/Get the current Z Slice to display
		/// </summary>
		// Token: 0x0600688C RID: 26764 RVA: 0x00097228 File Offset: 0x00095428
		public void SetZSlice(int s)
		{
			vtkImageViewer.vtkImageViewer_SetZSlice_38(base.GetCppThis(), s);
		}

		// Token: 0x0600688D RID: 26765
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer_SetupInteractor_39(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Create and attach an interactor for this window
		/// </summary>
		// Token: 0x0600688E RID: 26766 RVA: 0x00097238 File Offset: 0x00095438
		public void SetupInteractor(vtkRenderWindowInteractor arg0)
		{
			vtkImageViewer.vtkImageViewer_SetupInteractor_39(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000941 RID: 2369
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageViewer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000942 RID: 2370
		public new static readonly string MRClassNameKey = "class vtkImageViewer";
	}
}
