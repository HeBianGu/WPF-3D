using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCoordinate
	/// </summary>
	/// <remarks>
	///    perform coordinate transformation, and represent position, in a variety of vtk
	/// coordinate systems
	///
	/// vtkCoordinate represents position in a variety of coordinate systems, and
	/// converts position to other coordinate systems. It also supports relative
	/// positioning, so you can create a cascade of vtkCoordinate objects (no loops
	/// please!) that refer to each other. The typical usage of this object is
	/// to set the coordinate system in which to represent a position (e.g.,
	/// SetCoordinateSystemToNormalizedDisplay()), set the value of the coordinate
	/// (e.g., SetValue()), and then invoke the appropriate method to convert to
	/// another coordinate system (e.g., GetComputedWorldValue()).
	///
	/// The coordinate systems in vtk are as follows:
	/// &lt;PRE&gt;
	///   DISPLAY -             x-y pixel values in window
	///      0, 0 is the lower left of the first pixel,
	///      size, size is the upper right of the last pixel
	///   NORMALIZED DISPLAY -  x-y (0,1) normalized values
	///      0, 0 is the lower left of the first pixel,
	///      1, 1 is the upper right of the last pixel
	///   VIEWPORT -            x-y pixel values in viewport
	///      0, 0 is the lower left of the first pixel,
	///      size, size is the upper right of the last pixel
	///   NORMALIZED VIEWPORT - x-y (0,1) normalized value in viewport
	///      0, 0 is the lower left of the first pixel,
	///      1, 1 is the upper right of the last pixel
	///   VIEW -                x-y-z (-1,1) values in pose coordinates. (z is depth)
	///   POSE -                world coords translated and rotated to the camera
	///                         position and view direction
	///   WORLD -               x-y-z global coordinate values
	///   USERDEFINED -         x-y-z in User defined space
	/// &lt;/PRE&gt;
	///
	/// If you cascade vtkCoordinate objects, you refer to another vtkCoordinate
	/// object which in turn can refer to others, and so on. This allows you to
	/// create composite groups of things like vtkActor2D that are positioned
	/// relative to one another. Note that in cascaded sequences, each
	/// vtkCoordinate object may be specified in different coordinate systems!
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor2D vtkScalarBarActor
	/// </seealso>
	// Token: 0x020007D6 RID: 2006
	public class vtkCoordinate : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601497D RID: 84349 RVA: 0x001D25BF File Offset: 0x001D07BF
		static vtkCoordinate()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCoordinate.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCoordinate"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601497E RID: 84350 RVA: 0x001D25E7 File Offset: 0x001D07E7
		public vtkCoordinate(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601497F RID: 84351
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinate_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates an instance of this class with the following defaults:
		/// value of  (0,0,0) in world coordinates.
		/// </summary>
		// Token: 0x06014980 RID: 84352 RVA: 0x001D25F8 File Offset: 0x001D07F8
		public new static vtkCoordinate New()
		{
			vtkCoordinate result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates an instance of this class with the following defaults:
		/// value of  (0,0,0) in world coordinates.
		/// </summary>
		// Token: 0x06014981 RID: 84353 RVA: 0x001D264C File Offset: 0x001D084C
		public vtkCoordinate() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCoordinate.vtkCoordinate_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014982 RID: 84354 RVA: 0x001D2690 File Offset: 0x001D0890
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014983 RID: 84355
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinate_GetComputedDisplayValue_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Return the computed value in a specified coordinate system.
		/// </summary>
		// Token: 0x06014984 RID: 84356 RVA: 0x001D269C File Offset: 0x001D089C
		public int[] GetComputedDisplayValue(vtkViewport arg0)
		{
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_GetComputedDisplayValue_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014985 RID: 84357
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinate_GetComputedDoubleDisplayValue_02(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Return the computed value in a specified coordinate system.
		/// </summary>
		// Token: 0x06014986 RID: 84358 RVA: 0x001D26FC File Offset: 0x001D08FC
		public double[] GetComputedDoubleDisplayValue(vtkViewport arg0)
		{
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_GetComputedDoubleDisplayValue_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014987 RID: 84359
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinate_GetComputedDoubleViewportValue_03(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Return the computed value in a specified coordinate system.
		/// </summary>
		// Token: 0x06014988 RID: 84360 RVA: 0x001D275C File Offset: 0x001D095C
		public double[] GetComputedDoubleViewportValue(vtkViewport arg0)
		{
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_GetComputedDoubleViewportValue_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014989 RID: 84361
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinate_GetComputedLocalDisplayValue_04(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Return the computed value in a specified coordinate system.
		/// </summary>
		// Token: 0x0601498A RID: 84362 RVA: 0x001D27BC File Offset: 0x001D09BC
		public int[] GetComputedLocalDisplayValue(vtkViewport arg0)
		{
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_GetComputedLocalDisplayValue_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601498B RID: 84363
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinate_GetComputedUserDefinedValue_05(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// GetComputedUserDefinedValue() is to be used only when
		/// the coordinate system is VTK_USERDEFINED. The user
		/// must subclass vtkCoordinate and override this function,
		/// when set as the TransformCoordinate in 2D-Mappers, the user
		/// can customize display of 2D polygons
		/// </summary>
		// Token: 0x0601498C RID: 84364 RVA: 0x001D281C File Offset: 0x001D0A1C
		public virtual IntPtr GetComputedUserDefinedValue(vtkViewport arg0)
		{
			return vtkCoordinate.vtkCoordinate_GetComputedUserDefinedValue_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601498D RID: 84365
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinate_GetComputedValue_06(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// GetComputedValue() will return either World, Viewport or
		/// Display based on what has been set as the coordinate system.
		/// This is good for objects like vtkLineSource, where the
		/// user might want to use them as World or Viewport coordinates.
		/// </summary>
		// Token: 0x0601498E RID: 84366 RVA: 0x001D2850 File Offset: 0x001D0A50
		public IntPtr GetComputedValue(vtkViewport arg0)
		{
			return vtkCoordinate.vtkCoordinate_GetComputedValue_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601498F RID: 84367
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinate_GetComputedViewportValue_07(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Return the computed value in a specified coordinate system.
		/// </summary>
		// Token: 0x06014990 RID: 84368 RVA: 0x001D2884 File Offset: 0x001D0A84
		public int[] GetComputedViewportValue(vtkViewport arg0)
		{
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_GetComputedViewportValue_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014991 RID: 84369
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinate_GetComputedWorldValue_08(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Return the computed value in a specified coordinate system.
		/// </summary>
		// Token: 0x06014992 RID: 84370 RVA: 0x001D28E4 File Offset: 0x001D0AE4
		public double[] GetComputedWorldValue(vtkViewport arg0)
		{
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_GetComputedWorldValue_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014993 RID: 84371
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCoordinate_GetCoordinateSystem_09(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system which this coordinate
		/// is defined in. The options are Display, Normalized Display,
		/// Viewport, Normalized Viewport, View, and World.
		/// </summary>
		// Token: 0x06014994 RID: 84372 RVA: 0x001D2944 File Offset: 0x001D0B44
		public virtual int GetCoordinateSystem()
		{
			return vtkCoordinate.vtkCoordinate_GetCoordinateSystem_09(base.GetCppThis());
		}

		// Token: 0x06014995 RID: 84373
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinate_GetCoordinateSystemAsString_10(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system which this coordinate
		/// is defined in. The options are Display, Normalized Display,
		/// Viewport, Normalized Viewport, View, and World.
		/// </summary>
		// Token: 0x06014996 RID: 84374 RVA: 0x001D2964 File Offset: 0x001D0B64
		public string GetCoordinateSystemAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkCoordinate.vtkCoordinate_GetCoordinateSystemAsString_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014997 RID: 84375
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCoordinate_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014998 RID: 84376 RVA: 0x001D29A0 File Offset: 0x001D0BA0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCoordinate.vtkCoordinate_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x06014999 RID: 84377
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCoordinate_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601499A RID: 84378 RVA: 0x001D29C0 File Offset: 0x001D0BC0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCoordinate.vtkCoordinate_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0601499B RID: 84379
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinate_GetReferenceCoordinate_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If this coordinate is relative to another coordinate,
		/// then specify that coordinate as the ReferenceCoordinate.
		/// If this is NULL the coordinate is assumed to be absolute.
		/// </summary>
		// Token: 0x0601499C RID: 84380 RVA: 0x001D29DC File Offset: 0x001D0BDC
		public virtual vtkCoordinate GetReferenceCoordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_GetReferenceCoordinate_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		// Token: 0x0601499D RID: 84381
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinate_GetValue_14(HandleRef pThis);

		/// <summary>
		/// Set/get the value of this coordinate. This can be thought of as
		/// the position of this coordinate in its coordinate system.
		/// </summary>
		// Token: 0x0601499E RID: 84382 RVA: 0x001D2A4C File Offset: 0x001D0C4C
		public virtual double[] GetValue()
		{
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_GetValue_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601499F RID: 84383
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinate_GetValue_15(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/get the value of this coordinate. This can be thought of as
		/// the position of this coordinate in its coordinate system.
		/// </summary>
		// Token: 0x060149A0 RID: 84384 RVA: 0x001D2A94 File Offset: 0x001D0C94
		public virtual void GetValue(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCoordinate.vtkCoordinate_GetValue_15(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060149A1 RID: 84385
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinate_GetValue_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the value of this coordinate. This can be thought of as
		/// the position of this coordinate in its coordinate system.
		/// </summary>
		// Token: 0x060149A2 RID: 84386 RVA: 0x001D2AA6 File Offset: 0x001D0CA6
		public virtual void GetValue(IntPtr _arg)
		{
			vtkCoordinate.vtkCoordinate_GetValue_16(base.GetCppThis(), _arg);
		}

		// Token: 0x060149A3 RID: 84387
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinate_GetViewport_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If you want this coordinate to be relative to a specific
		/// vtkViewport (vtkRenderer) then you can specify that here.
		/// NOTE: this is a raw pointer, not a weak pointer nor a reference counted
		/// object, to avoid reference cycle loop between rendering classes and filter
		/// classes.
		/// </summary>
		// Token: 0x060149A4 RID: 84388 RVA: 0x001D2AB8 File Offset: 0x001D0CB8
		public virtual vtkViewport GetViewport()
		{
			vtkViewport vtkViewport = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_GetViewport_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewport = (vtkViewport)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewport.Register(null);
				}
			}
			return vtkViewport;
		}

		// Token: 0x060149A5 RID: 84389
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCoordinate_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149A6 RID: 84390 RVA: 0x001D2B28 File Offset: 0x001D0D28
		public override int IsA(string type)
		{
			return vtkCoordinate.vtkCoordinate_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x060149A7 RID: 84391
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCoordinate_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149A8 RID: 84392 RVA: 0x001D2B48 File Offset: 0x001D0D48
		public new static int IsTypeOf(string type)
		{
			return vtkCoordinate.vtkCoordinate_IsTypeOf_19(type);
		}

		// Token: 0x060149A9 RID: 84393
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinate_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149AA RID: 84394 RVA: 0x001D2B64 File Offset: 0x001D0D64
		public new vtkCoordinate NewInstance()
		{
			vtkCoordinate result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060149AB RID: 84395
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinate_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149AC RID: 84396 RVA: 0x001D2BC0 File Offset: 0x001D0DC0
		public new static vtkCoordinate SafeDownCast(vtkObjectBase o)
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		// Token: 0x060149AD RID: 84397
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinate_SetCoordinateSystem_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the coordinate system which this coordinate
		/// is defined in. The options are Display, Normalized Display,
		/// Viewport, Normalized Viewport, View, and World.
		/// </summary>
		// Token: 0x060149AE RID: 84398 RVA: 0x001D2C3F File Offset: 0x001D0E3F
		public virtual void SetCoordinateSystem(int _arg)
		{
			vtkCoordinate.vtkCoordinate_SetCoordinateSystem_23(base.GetCppThis(), _arg);
		}

		// Token: 0x060149AF RID: 84399
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinate_SetCoordinateSystemToDisplay_24(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system which this coordinate
		/// is defined in. The options are Display, Normalized Display,
		/// Viewport, Normalized Viewport, View, and World.
		/// </summary>
		// Token: 0x060149B0 RID: 84400 RVA: 0x001D2C4F File Offset: 0x001D0E4F
		public void SetCoordinateSystemToDisplay()
		{
			vtkCoordinate.vtkCoordinate_SetCoordinateSystemToDisplay_24(base.GetCppThis());
		}

		// Token: 0x060149B1 RID: 84401
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinate_SetCoordinateSystemToNormalizedDisplay_25(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system which this coordinate
		/// is defined in. The options are Display, Normalized Display,
		/// Viewport, Normalized Viewport, View, and World.
		/// </summary>
		// Token: 0x060149B2 RID: 84402 RVA: 0x001D2C5E File Offset: 0x001D0E5E
		public void SetCoordinateSystemToNormalizedDisplay()
		{
			vtkCoordinate.vtkCoordinate_SetCoordinateSystemToNormalizedDisplay_25(base.GetCppThis());
		}

		// Token: 0x060149B3 RID: 84403
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinate_SetCoordinateSystemToNormalizedViewport_26(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system which this coordinate
		/// is defined in. The options are Display, Normalized Display,
		/// Viewport, Normalized Viewport, View, and World.
		/// </summary>
		// Token: 0x060149B4 RID: 84404 RVA: 0x001D2C6D File Offset: 0x001D0E6D
		public void SetCoordinateSystemToNormalizedViewport()
		{
			vtkCoordinate.vtkCoordinate_SetCoordinateSystemToNormalizedViewport_26(base.GetCppThis());
		}

		// Token: 0x060149B5 RID: 84405
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinate_SetCoordinateSystemToPose_27(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system which this coordinate
		/// is defined in. The options are Display, Normalized Display,
		/// Viewport, Normalized Viewport, View, and World.
		/// </summary>
		// Token: 0x060149B6 RID: 84406 RVA: 0x001D2C7C File Offset: 0x001D0E7C
		public void SetCoordinateSystemToPose()
		{
			vtkCoordinate.vtkCoordinate_SetCoordinateSystemToPose_27(base.GetCppThis());
		}

		// Token: 0x060149B7 RID: 84407
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinate_SetCoordinateSystemToView_28(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system which this coordinate
		/// is defined in. The options are Display, Normalized Display,
		/// Viewport, Normalized Viewport, View, and World.
		/// </summary>
		// Token: 0x060149B8 RID: 84408 RVA: 0x001D2C8B File Offset: 0x001D0E8B
		public void SetCoordinateSystemToView()
		{
			vtkCoordinate.vtkCoordinate_SetCoordinateSystemToView_28(base.GetCppThis());
		}

		// Token: 0x060149B9 RID: 84409
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinate_SetCoordinateSystemToViewport_29(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system which this coordinate
		/// is defined in. The options are Display, Normalized Display,
		/// Viewport, Normalized Viewport, View, and World.
		/// </summary>
		// Token: 0x060149BA RID: 84410 RVA: 0x001D2C9A File Offset: 0x001D0E9A
		public void SetCoordinateSystemToViewport()
		{
			vtkCoordinate.vtkCoordinate_SetCoordinateSystemToViewport_29(base.GetCppThis());
		}

		// Token: 0x060149BB RID: 84411
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinate_SetCoordinateSystemToWorld_30(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system which this coordinate
		/// is defined in. The options are Display, Normalized Display,
		/// Viewport, Normalized Viewport, View, and World.
		/// </summary>
		// Token: 0x060149BC RID: 84412 RVA: 0x001D2CA9 File Offset: 0x001D0EA9
		public void SetCoordinateSystemToWorld()
		{
			vtkCoordinate.vtkCoordinate_SetCoordinateSystemToWorld_30(base.GetCppThis());
		}

		// Token: 0x060149BD RID: 84413
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinate_SetReferenceCoordinate_31(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// If this coordinate is relative to another coordinate,
		/// then specify that coordinate as the ReferenceCoordinate.
		/// If this is NULL the coordinate is assumed to be absolute.
		/// </summary>
		// Token: 0x060149BE RID: 84414 RVA: 0x001D2CB8 File Offset: 0x001D0EB8
		public virtual void SetReferenceCoordinate(vtkCoordinate arg0)
		{
			vtkCoordinate.vtkCoordinate_SetReferenceCoordinate_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060149BF RID: 84415
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinate_SetValue_32(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/get the value of this coordinate. This can be thought of as
		/// the position of this coordinate in its coordinate system.
		/// </summary>
		// Token: 0x060149C0 RID: 84416 RVA: 0x001D2CE7 File Offset: 0x001D0EE7
		public virtual void SetValue(double _arg1, double _arg2, double _arg3)
		{
			vtkCoordinate.vtkCoordinate_SetValue_32(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060149C1 RID: 84417
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinate_SetValue_33(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the value of this coordinate. This can be thought of as
		/// the position of this coordinate in its coordinate system.
		/// </summary>
		// Token: 0x060149C2 RID: 84418 RVA: 0x001D2CF9 File Offset: 0x001D0EF9
		public virtual void SetValue(IntPtr _arg)
		{
			vtkCoordinate.vtkCoordinate_SetValue_33(base.GetCppThis(), _arg);
		}

		// Token: 0x060149C3 RID: 84419
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinate_SetValue_34(HandleRef pThis, double a, double b);

		/// <summary>
		/// Set/get the value of this coordinate. This can be thought of as
		/// the position of this coordinate in its coordinate system.
		/// </summary>
		// Token: 0x060149C4 RID: 84420 RVA: 0x001D2D09 File Offset: 0x001D0F09
		public void SetValue(double a, double b)
		{
			vtkCoordinate.vtkCoordinate_SetValue_34(base.GetCppThis(), a, b);
		}

		// Token: 0x060149C5 RID: 84421
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinate_SetViewport_35(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// If you want this coordinate to be relative to a specific
		/// vtkViewport (vtkRenderer) then you can specify that here.
		/// NOTE: this is a raw pointer, not a weak pointer nor a reference counted
		/// object, to avoid reference cycle loop between rendering classes and filter
		/// classes.
		/// </summary>
		// Token: 0x060149C6 RID: 84422 RVA: 0x001D2D1C File Offset: 0x001D0F1C
		public void SetViewport(vtkViewport viewport)
		{
			vtkCoordinate.vtkCoordinate_SetViewport_35(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017D2 RID: 6098
		public new const string MRFullTypeName = "Kitware.VTK.vtkCoordinate";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017D3 RID: 6099
		public new static readonly string MRClassNameKey = "class vtkCoordinate";
	}
}
