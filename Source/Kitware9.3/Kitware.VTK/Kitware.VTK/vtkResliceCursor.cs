using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkResliceCursor
	/// </summary>
	/// <remarks>
	///    Geometry for a reslice cursor
	///
	/// This class represents a reslice cursor. It consists of two cross
	/// sectional hairs, with an optional thickness. The crosshairs
	/// hairs may have a hole in the center. These may be translated or rotated
	/// independent of each other in the view. The result is used to reslice
	/// the data along these cross sections. This allows the user to perform
	/// multi-planar thin or thick reformat of the data on an image view, rather
	/// than a 3D view.
	/// </remarks>
	/// <seealso>
	///
	/// vtkResliceCursorWidget vtkResliceCursor vtkResliceCursorPolyDataAlgorithm
	/// vtkResliceCursorRepresentation vtkResliceCursorThickLineRepresentation
	/// vtkResliceCursorActor vtkImagePlaneWidget
	/// </seealso>
	// Token: 0x02000362 RID: 866
	public class vtkResliceCursor : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009D60 RID: 40288 RVA: 0x000DF10B File Offset: 0x000DD30B
		static vtkResliceCursor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkResliceCursor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkResliceCursor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009D61 RID: 40289 RVA: 0x000DF133 File Offset: 0x000DD333
		public vtkResliceCursor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009D62 RID: 40290
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009D63 RID: 40291 RVA: 0x000DF144 File Offset: 0x000DD344
		public new static vtkResliceCursor New()
		{
			vtkResliceCursor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursor.vtkResliceCursor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResliceCursor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009D64 RID: 40292 RVA: 0x000DF198 File Offset: 0x000DD398
		public vtkResliceCursor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkResliceCursor.vtkResliceCursor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009D65 RID: 40293 RVA: 0x000DF1DC File Offset: 0x000DD3DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009D66 RID: 40294
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursor_GetAxis_01(HandleRef pThis, int i);

		/// <summary>
		/// Get the computed axes directions
		/// </summary>
		// Token: 0x06009D67 RID: 40295 RVA: 0x000DF1E8 File Offset: 0x000DD3E8
		public virtual IntPtr GetAxis(int i)
		{
			return vtkResliceCursor.vtkResliceCursor_GetAxis_01(base.GetCppThis(), i);
		}

		// Token: 0x06009D68 RID: 40296
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursor_GetCenter_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the cente of the reslice cursor.
		/// </summary>
		// Token: 0x06009D69 RID: 40297 RVA: 0x000DF208 File Offset: 0x000DD408
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkResliceCursor.vtkResliceCursor_GetCenter_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009D6A RID: 40298
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_GetCenter_03(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the cente of the reslice cursor.
		/// </summary>
		// Token: 0x06009D6B RID: 40299 RVA: 0x000DF250 File Offset: 0x000DD450
		public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkResliceCursor.vtkResliceCursor_GetCenter_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06009D6C RID: 40300
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_GetCenter_04(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the cente of the reslice cursor.
		/// </summary>
		// Token: 0x06009D6D RID: 40301 RVA: 0x000DF262 File Offset: 0x000DD462
		public virtual void GetCenter(IntPtr _arg)
		{
			vtkResliceCursor.vtkResliceCursor_GetCenter_04(base.GetCppThis(), _arg);
		}

		// Token: 0x06009D6E RID: 40302
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursor_GetCenterlineAxisPolyData_05(HandleRef pThis, int axis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the slab and centerline polydata along an axis
		/// </summary>
		// Token: 0x06009D6F RID: 40303 RVA: 0x000DF274 File Offset: 0x000DD474
		public virtual vtkPolyData GetCenterlineAxisPolyData(int axis)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursor.vtkResliceCursor_GetCenterlineAxisPolyData_05(base.GetCppThis(), axis, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009D70 RID: 40304
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursor_GetHole_06(HandleRef pThis);

		/// <summary>
		/// Show a hole in the center of the cursor, so its easy to see the pixels
		/// within the hole. ON by default
		/// </summary>
		// Token: 0x06009D71 RID: 40305 RVA: 0x000DF2E4 File Offset: 0x000DD4E4
		public virtual int GetHole()
		{
			return vtkResliceCursor.vtkResliceCursor_GetHole_06(base.GetCppThis());
		}

		// Token: 0x06009D72 RID: 40306
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkResliceCursor_GetHoleWidth_07(HandleRef pThis);

		/// <summary>
		/// Set the width of the hole in mm
		/// </summary>
		// Token: 0x06009D73 RID: 40307 RVA: 0x000DF304 File Offset: 0x000DD504
		public virtual double GetHoleWidth()
		{
			return vtkResliceCursor.vtkResliceCursor_GetHoleWidth_07(base.GetCppThis());
		}

		// Token: 0x06009D74 RID: 40308
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkResliceCursor_GetHoleWidthInPixels_08(HandleRef pThis);

		/// <summary>
		/// Set the width of the hole in pixels. If set, this will override the
		/// hole with in mm.
		/// </summary>
		// Token: 0x06009D75 RID: 40309 RVA: 0x000DF324 File Offset: 0x000DD524
		public virtual double GetHoleWidthInPixels()
		{
			return vtkResliceCursor.vtkResliceCursor_GetHoleWidthInPixels_08(base.GetCppThis());
		}

		// Token: 0x06009D76 RID: 40310
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursor_GetImage_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the image (3D) that we are slicing
		/// </summary>
		// Token: 0x06009D77 RID: 40311 RVA: 0x000DF344 File Offset: 0x000DD544
		public virtual vtkImageData GetImage()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursor.vtkResliceCursor_GetImage_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009D78 RID: 40312
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkResliceCursor_GetMTime_10(HandleRef pThis);

		/// <summary>
		/// Get the MTime. Check the MTime of the internal planes as well.
		/// </summary>
		// Token: 0x06009D79 RID: 40313 RVA: 0x000DF3B4 File Offset: 0x000DD5B4
		public override ulong GetMTime()
		{
			return vtkResliceCursor.vtkResliceCursor_GetMTime_10(base.GetCppThis());
		}

		// Token: 0x06009D7A RID: 40314
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResliceCursor_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009D7B RID: 40315 RVA: 0x000DF3D4 File Offset: 0x000DD5D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkResliceCursor.vtkResliceCursor_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x06009D7C RID: 40316
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResliceCursor_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009D7D RID: 40317 RVA: 0x000DF3F4 File Offset: 0x000DD5F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkResliceCursor.vtkResliceCursor_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x06009D7E RID: 40318
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursor_GetPlane_13(HandleRef pThis, int n, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the planes that represent normals along the X, Y and Z. The argument
		/// passed to this method must be an integer in the range 0-2 (corresponding
		/// to the X, Y and Z axes.
		/// </summary>
		// Token: 0x06009D7F RID: 40319 RVA: 0x000DF410 File Offset: 0x000DD610
		public virtual vtkPlane GetPlane(int n)
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursor.vtkResliceCursor_GetPlane_13(base.GetCppThis(), n, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009D80 RID: 40320
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursor_GetPolyData_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the 3D PolyData representation
		/// </summary>
		// Token: 0x06009D81 RID: 40321 RVA: 0x000DF480 File Offset: 0x000DD680
		public virtual vtkPolyData GetPolyData()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursor.vtkResliceCursor_GetPolyData_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009D82 RID: 40322
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursor_GetThickMode_15(HandleRef pThis);

		/// <summary>
		/// Enable disable thick mode. Default is to enable it.
		/// </summary>
		// Token: 0x06009D83 RID: 40323 RVA: 0x000DF4F0 File Offset: 0x000DD6F0
		public virtual int GetThickMode()
		{
			return vtkResliceCursor.vtkResliceCursor_GetThickMode_15(base.GetCppThis());
		}

		// Token: 0x06009D84 RID: 40324
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursor_GetThickness_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the thickness of the cursor
		/// </summary>
		// Token: 0x06009D85 RID: 40325 RVA: 0x000DF510 File Offset: 0x000DD710
		public virtual double[] GetThickness()
		{
			IntPtr intPtr = vtkResliceCursor.vtkResliceCursor_GetThickness_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009D86 RID: 40326
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_GetThickness_17(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the thickness of the cursor
		/// </summary>
		// Token: 0x06009D87 RID: 40327 RVA: 0x000DF558 File Offset: 0x000DD758
		public virtual void GetThickness(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkResliceCursor.vtkResliceCursor_GetThickness_17(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06009D88 RID: 40328
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_GetThickness_18(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the thickness of the cursor
		/// </summary>
		// Token: 0x06009D89 RID: 40329 RVA: 0x000DF56A File Offset: 0x000DD76A
		public virtual void GetThickness(IntPtr _arg)
		{
			vtkResliceCursor.vtkResliceCursor_GetThickness_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06009D8A RID: 40330
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursor_GetViewUp_19(HandleRef pThis, int i);

		/// <summary>
		/// Get/Set the view up
		/// </summary>
		// Token: 0x06009D8B RID: 40331 RVA: 0x000DF57C File Offset: 0x000DD77C
		public IntPtr GetViewUp(int i)
		{
			return vtkResliceCursor.vtkResliceCursor_GetViewUp_19(base.GetCppThis(), i);
		}

		// Token: 0x06009D8C RID: 40332
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursor_GetXAxis_20(HandleRef pThis);

		/// <summary>
		/// Get the computed axes directions
		/// </summary>
		// Token: 0x06009D8D RID: 40333 RVA: 0x000DF59C File Offset: 0x000DD79C
		public virtual double[] GetXAxis()
		{
			IntPtr intPtr = vtkResliceCursor.vtkResliceCursor_GetXAxis_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009D8E RID: 40334
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_GetXAxis_21(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get the computed axes directions
		/// </summary>
		// Token: 0x06009D8F RID: 40335 RVA: 0x000DF5E4 File Offset: 0x000DD7E4
		public virtual void GetXAxis(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkResliceCursor.vtkResliceCursor_GetXAxis_21(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06009D90 RID: 40336
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_GetXAxis_22(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the computed axes directions
		/// </summary>
		// Token: 0x06009D91 RID: 40337 RVA: 0x000DF5F6 File Offset: 0x000DD7F6
		public virtual void GetXAxis(IntPtr _arg)
		{
			vtkResliceCursor.vtkResliceCursor_GetXAxis_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06009D92 RID: 40338
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursor_GetXViewUp_23(HandleRef pThis);

		/// <summary>
		/// Get/Set the view up
		/// </summary>
		// Token: 0x06009D93 RID: 40339 RVA: 0x000DF608 File Offset: 0x000DD808
		public virtual double[] GetXViewUp()
		{
			IntPtr intPtr = vtkResliceCursor.vtkResliceCursor_GetXViewUp_23(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009D94 RID: 40340
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_GetXViewUp_24(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get/Set the view up
		/// </summary>
		// Token: 0x06009D95 RID: 40341 RVA: 0x000DF650 File Offset: 0x000DD850
		public virtual void GetXViewUp(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkResliceCursor.vtkResliceCursor_GetXViewUp_24(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06009D96 RID: 40342
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_GetXViewUp_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the view up
		/// </summary>
		// Token: 0x06009D97 RID: 40343 RVA: 0x000DF662 File Offset: 0x000DD862
		public virtual void GetXViewUp(IntPtr _arg)
		{
			vtkResliceCursor.vtkResliceCursor_GetXViewUp_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06009D98 RID: 40344
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursor_GetYAxis_26(HandleRef pThis);

		/// <summary>
		/// Get the computed axes directions
		/// </summary>
		// Token: 0x06009D99 RID: 40345 RVA: 0x000DF674 File Offset: 0x000DD874
		public virtual double[] GetYAxis()
		{
			IntPtr intPtr = vtkResliceCursor.vtkResliceCursor_GetYAxis_26(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009D9A RID: 40346
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_GetYAxis_27(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get the computed axes directions
		/// </summary>
		// Token: 0x06009D9B RID: 40347 RVA: 0x000DF6BC File Offset: 0x000DD8BC
		public virtual void GetYAxis(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkResliceCursor.vtkResliceCursor_GetYAxis_27(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06009D9C RID: 40348
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_GetYAxis_28(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the computed axes directions
		/// </summary>
		// Token: 0x06009D9D RID: 40349 RVA: 0x000DF6CE File Offset: 0x000DD8CE
		public virtual void GetYAxis(IntPtr _arg)
		{
			vtkResliceCursor.vtkResliceCursor_GetYAxis_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06009D9E RID: 40350
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursor_GetYViewUp_29(HandleRef pThis);

		/// <summary>
		/// Get/Set the view up
		/// </summary>
		// Token: 0x06009D9F RID: 40351 RVA: 0x000DF6E0 File Offset: 0x000DD8E0
		public virtual double[] GetYViewUp()
		{
			IntPtr intPtr = vtkResliceCursor.vtkResliceCursor_GetYViewUp_29(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009DA0 RID: 40352
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_GetYViewUp_30(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get/Set the view up
		/// </summary>
		// Token: 0x06009DA1 RID: 40353 RVA: 0x000DF728 File Offset: 0x000DD928
		public virtual void GetYViewUp(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkResliceCursor.vtkResliceCursor_GetYViewUp_30(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06009DA2 RID: 40354
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_GetYViewUp_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the view up
		/// </summary>
		// Token: 0x06009DA3 RID: 40355 RVA: 0x000DF73A File Offset: 0x000DD93A
		public virtual void GetYViewUp(IntPtr _arg)
		{
			vtkResliceCursor.vtkResliceCursor_GetYViewUp_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06009DA4 RID: 40356
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursor_GetZAxis_32(HandleRef pThis);

		/// <summary>
		/// Get the computed axes directions
		/// </summary>
		// Token: 0x06009DA5 RID: 40357 RVA: 0x000DF74C File Offset: 0x000DD94C
		public virtual double[] GetZAxis()
		{
			IntPtr intPtr = vtkResliceCursor.vtkResliceCursor_GetZAxis_32(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009DA6 RID: 40358
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_GetZAxis_33(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get the computed axes directions
		/// </summary>
		// Token: 0x06009DA7 RID: 40359 RVA: 0x000DF794 File Offset: 0x000DD994
		public virtual void GetZAxis(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkResliceCursor.vtkResliceCursor_GetZAxis_33(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06009DA8 RID: 40360
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_GetZAxis_34(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the computed axes directions
		/// </summary>
		// Token: 0x06009DA9 RID: 40361 RVA: 0x000DF7A6 File Offset: 0x000DD9A6
		public virtual void GetZAxis(IntPtr _arg)
		{
			vtkResliceCursor.vtkResliceCursor_GetZAxis_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06009DAA RID: 40362
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursor_GetZViewUp_35(HandleRef pThis);

		/// <summary>
		/// Get/Set the view up
		/// </summary>
		// Token: 0x06009DAB RID: 40363 RVA: 0x000DF7B8 File Offset: 0x000DD9B8
		public virtual double[] GetZViewUp()
		{
			IntPtr intPtr = vtkResliceCursor.vtkResliceCursor_GetZViewUp_35(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009DAC RID: 40364
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_GetZViewUp_36(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get/Set the view up
		/// </summary>
		// Token: 0x06009DAD RID: 40365 RVA: 0x000DF800 File Offset: 0x000DDA00
		public virtual void GetZViewUp(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkResliceCursor.vtkResliceCursor_GetZViewUp_36(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06009DAE RID: 40366
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_GetZViewUp_37(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the view up
		/// </summary>
		// Token: 0x06009DAF RID: 40367 RVA: 0x000DF812 File Offset: 0x000DDA12
		public virtual void GetZViewUp(IntPtr _arg)
		{
			vtkResliceCursor.vtkResliceCursor_GetZViewUp_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06009DB0 RID: 40368
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursor_IsA_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009DB1 RID: 40369 RVA: 0x000DF824 File Offset: 0x000DDA24
		public override int IsA(string type)
		{
			return vtkResliceCursor.vtkResliceCursor_IsA_38(base.GetCppThis(), type);
		}

		// Token: 0x06009DB2 RID: 40370
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursor_IsTypeOf_39([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009DB3 RID: 40371 RVA: 0x000DF844 File Offset: 0x000DDA44
		public new static int IsTypeOf(string type)
		{
			return vtkResliceCursor.vtkResliceCursor_IsTypeOf_39(type);
		}

		// Token: 0x06009DB4 RID: 40372
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursor_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009DB5 RID: 40373 RVA: 0x000DF860 File Offset: 0x000DDA60
		public new vtkResliceCursor NewInstance()
		{
			vtkResliceCursor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursor.vtkResliceCursor_NewInstance_41(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResliceCursor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009DB6 RID: 40374
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_Reset_42(HandleRef pThis);

		/// <summary>
		/// Reset the cursor to the default position, ie with the axes, normal
		/// to each other and axis aligned and with the cursor pointed at the
		/// center of the image.
		/// </summary>
		// Token: 0x06009DB7 RID: 40375 RVA: 0x000DF8BA File Offset: 0x000DDABA
		public virtual void Reset()
		{
			vtkResliceCursor.vtkResliceCursor_Reset_42(base.GetCppThis());
		}

		// Token: 0x06009DB8 RID: 40376
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursor_SafeDownCast_43(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009DB9 RID: 40377 RVA: 0x000DF8CC File Offset: 0x000DDACC
		public new static vtkResliceCursor SafeDownCast(vtkObjectBase o)
		{
			vtkResliceCursor vtkResliceCursor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursor.vtkResliceCursor_SafeDownCast_43((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009DBA RID: 40378
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetCenter_44(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set/Get the cente of the reslice cursor.
		/// </summary>
		// Token: 0x06009DBB RID: 40379 RVA: 0x000DF94B File Offset: 0x000DDB4B
		public virtual void SetCenter(double arg0, double arg1, double arg2)
		{
			vtkResliceCursor.vtkResliceCursor_SetCenter_44(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x06009DBC RID: 40380
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetCenter_45(HandleRef pThis, IntPtr center);

		/// <summary>
		/// Set/Get the cente of the reslice cursor.
		/// </summary>
		// Token: 0x06009DBD RID: 40381 RVA: 0x000DF95D File Offset: 0x000DDB5D
		public virtual void SetCenter(IntPtr center)
		{
			vtkResliceCursor.vtkResliceCursor_SetCenter_45(base.GetCppThis(), center);
		}

		// Token: 0x06009DBE RID: 40382
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetHole_46(HandleRef pThis, int _arg);

		/// <summary>
		/// Show a hole in the center of the cursor, so its easy to see the pixels
		/// within the hole. ON by default
		/// </summary>
		// Token: 0x06009DBF RID: 40383 RVA: 0x000DF96D File Offset: 0x000DDB6D
		public virtual void SetHole(int _arg)
		{
			vtkResliceCursor.vtkResliceCursor_SetHole_46(base.GetCppThis(), _arg);
		}

		// Token: 0x06009DC0 RID: 40384
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetHoleWidth_47(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the width of the hole in mm
		/// </summary>
		// Token: 0x06009DC1 RID: 40385 RVA: 0x000DF97D File Offset: 0x000DDB7D
		public virtual void SetHoleWidth(double _arg)
		{
			vtkResliceCursor.vtkResliceCursor_SetHoleWidth_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06009DC2 RID: 40386
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetHoleWidthInPixels_48(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the width of the hole in pixels. If set, this will override the
		/// hole with in mm.
		/// </summary>
		// Token: 0x06009DC3 RID: 40387 RVA: 0x000DF98D File Offset: 0x000DDB8D
		public virtual void SetHoleWidthInPixels(double _arg)
		{
			vtkResliceCursor.vtkResliceCursor_SetHoleWidthInPixels_48(base.GetCppThis(), _arg);
		}

		// Token: 0x06009DC4 RID: 40388
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetImage_49(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the image (3D) that we are slicing
		/// </summary>
		// Token: 0x06009DC5 RID: 40389 RVA: 0x000DF9A0 File Offset: 0x000DDBA0
		public virtual void SetImage(vtkImageData arg0)
		{
			vtkResliceCursor.vtkResliceCursor_SetImage_49(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009DC6 RID: 40390
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetThickMode_50(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable disable thick mode. Default is to enable it.
		/// </summary>
		// Token: 0x06009DC7 RID: 40391 RVA: 0x000DF9CF File Offset: 0x000DDBCF
		public virtual void SetThickMode(int _arg)
		{
			vtkResliceCursor.vtkResliceCursor_SetThickMode_50(base.GetCppThis(), _arg);
		}

		// Token: 0x06009DC8 RID: 40392
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetThickness_51(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the thickness of the cursor
		/// </summary>
		// Token: 0x06009DC9 RID: 40393 RVA: 0x000DF9DF File Offset: 0x000DDBDF
		public virtual void SetThickness(double _arg1, double _arg2, double _arg3)
		{
			vtkResliceCursor.vtkResliceCursor_SetThickness_51(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06009DCA RID: 40394
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetThickness_52(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the thickness of the cursor
		/// </summary>
		// Token: 0x06009DCB RID: 40395 RVA: 0x000DF9F1 File Offset: 0x000DDBF1
		public virtual void SetThickness(IntPtr _arg)
		{
			vtkResliceCursor.vtkResliceCursor_SetThickness_52(base.GetCppThis(), _arg);
		}

		// Token: 0x06009DCC RID: 40396
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetXAxis_53(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Get the computed axes directions
		/// </summary>
		// Token: 0x06009DCD RID: 40397 RVA: 0x000DFA01 File Offset: 0x000DDC01
		public virtual void SetXAxis(double _arg1, double _arg2, double _arg3)
		{
			vtkResliceCursor.vtkResliceCursor_SetXAxis_53(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06009DCE RID: 40398
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetXAxis_54(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the computed axes directions
		/// </summary>
		// Token: 0x06009DCF RID: 40399 RVA: 0x000DFA13 File Offset: 0x000DDC13
		public virtual void SetXAxis(IntPtr _arg)
		{
			vtkResliceCursor.vtkResliceCursor_SetXAxis_54(base.GetCppThis(), _arg);
		}

		// Token: 0x06009DD0 RID: 40400
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetXViewUp_55(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Get/Set the view up
		/// </summary>
		// Token: 0x06009DD1 RID: 40401 RVA: 0x000DFA23 File Offset: 0x000DDC23
		public virtual void SetXViewUp(double _arg1, double _arg2, double _arg3)
		{
			vtkResliceCursor.vtkResliceCursor_SetXViewUp_55(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06009DD2 RID: 40402
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetXViewUp_56(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the view up
		/// </summary>
		// Token: 0x06009DD3 RID: 40403 RVA: 0x000DFA35 File Offset: 0x000DDC35
		public virtual void SetXViewUp(IntPtr _arg)
		{
			vtkResliceCursor.vtkResliceCursor_SetXViewUp_56(base.GetCppThis(), _arg);
		}

		// Token: 0x06009DD4 RID: 40404
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetYAxis_57(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Get the computed axes directions
		/// </summary>
		// Token: 0x06009DD5 RID: 40405 RVA: 0x000DFA45 File Offset: 0x000DDC45
		public virtual void SetYAxis(double _arg1, double _arg2, double _arg3)
		{
			vtkResliceCursor.vtkResliceCursor_SetYAxis_57(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06009DD6 RID: 40406
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetYAxis_58(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the computed axes directions
		/// </summary>
		// Token: 0x06009DD7 RID: 40407 RVA: 0x000DFA57 File Offset: 0x000DDC57
		public virtual void SetYAxis(IntPtr _arg)
		{
			vtkResliceCursor.vtkResliceCursor_SetYAxis_58(base.GetCppThis(), _arg);
		}

		// Token: 0x06009DD8 RID: 40408
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetYViewUp_59(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Get/Set the view up
		/// </summary>
		// Token: 0x06009DD9 RID: 40409 RVA: 0x000DFA67 File Offset: 0x000DDC67
		public virtual void SetYViewUp(double _arg1, double _arg2, double _arg3)
		{
			vtkResliceCursor.vtkResliceCursor_SetYViewUp_59(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06009DDA RID: 40410
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetYViewUp_60(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the view up
		/// </summary>
		// Token: 0x06009DDB RID: 40411 RVA: 0x000DFA79 File Offset: 0x000DDC79
		public virtual void SetYViewUp(IntPtr _arg)
		{
			vtkResliceCursor.vtkResliceCursor_SetYViewUp_60(base.GetCppThis(), _arg);
		}

		// Token: 0x06009DDC RID: 40412
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetZAxis_61(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Get the computed axes directions
		/// </summary>
		// Token: 0x06009DDD RID: 40413 RVA: 0x000DFA89 File Offset: 0x000DDC89
		public virtual void SetZAxis(double _arg1, double _arg2, double _arg3)
		{
			vtkResliceCursor.vtkResliceCursor_SetZAxis_61(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06009DDE RID: 40414
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetZAxis_62(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the computed axes directions
		/// </summary>
		// Token: 0x06009DDF RID: 40415 RVA: 0x000DFA9B File Offset: 0x000DDC9B
		public virtual void SetZAxis(IntPtr _arg)
		{
			vtkResliceCursor.vtkResliceCursor_SetZAxis_62(base.GetCppThis(), _arg);
		}

		// Token: 0x06009DE0 RID: 40416
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetZViewUp_63(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Get/Set the view up
		/// </summary>
		// Token: 0x06009DE1 RID: 40417 RVA: 0x000DFAAB File Offset: 0x000DDCAB
		public virtual void SetZViewUp(double _arg1, double _arg2, double _arg3)
		{
			vtkResliceCursor.vtkResliceCursor_SetZViewUp_63(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06009DE2 RID: 40418
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_SetZViewUp_64(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the view up
		/// </summary>
		// Token: 0x06009DE3 RID: 40419 RVA: 0x000DFABD File Offset: 0x000DDCBD
		public virtual void SetZViewUp(IntPtr _arg)
		{
			vtkResliceCursor.vtkResliceCursor_SetZViewUp_64(base.GetCppThis(), _arg);
		}

		// Token: 0x06009DE4 RID: 40420
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_ThickModeOff_65(HandleRef pThis);

		/// <summary>
		/// Enable disable thick mode. Default is to enable it.
		/// </summary>
		// Token: 0x06009DE5 RID: 40421 RVA: 0x000DFACD File Offset: 0x000DDCCD
		public virtual void ThickModeOff()
		{
			vtkResliceCursor.vtkResliceCursor_ThickModeOff_65(base.GetCppThis());
		}

		// Token: 0x06009DE6 RID: 40422
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_ThickModeOn_66(HandleRef pThis);

		/// <summary>
		/// Enable disable thick mode. Default is to enable it.
		/// </summary>
		// Token: 0x06009DE7 RID: 40423 RVA: 0x000DFADC File Offset: 0x000DDCDC
		public virtual void ThickModeOn()
		{
			vtkResliceCursor.vtkResliceCursor_ThickModeOn_66(base.GetCppThis());
		}

		// Token: 0x06009DE8 RID: 40424
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursor_Update_67(HandleRef pThis);

		/// <summary>
		/// Build the polydata
		/// </summary>
		// Token: 0x06009DE9 RID: 40425 RVA: 0x000DFAEB File Offset: 0x000DDCEB
		public virtual void Update()
		{
			vtkResliceCursor.vtkResliceCursor_Update_67(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CBA RID: 3258
		public new const string MRFullTypeName = "Kitware.VTK.vtkResliceCursor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CBB RID: 3259
		public new static readonly string MRClassNameKey = "class vtkResliceCursor";
	}
}
