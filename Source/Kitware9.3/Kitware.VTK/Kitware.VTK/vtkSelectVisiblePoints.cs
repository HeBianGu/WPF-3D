using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSelectVisiblePoints
	/// </summary>
	/// <remarks>
	///    extract points that are visible (based on z-buffer calculation)
	///
	/// vtkSelectVisiblePoints is a filter that selects points based on
	/// whether they are visible or not. Visibility is determined by
	/// accessing the z-buffer of a rendering window. (The position of each
	/// input point is converted into display coordinates, and then the
	/// z-value at that point is obtained. If within the user-specified
	/// tolerance, the point is considered visible.)
	///
	/// Points that are visible (or if the ivar SelectInvisible is on,
	/// invisible points) are passed to the output. Associated data
	/// attributes are passed to the output as well.
	///
	/// This filter also allows you to specify a rectangular window in display
	/// (pixel) coordinates in which the visible points must lie. This can be
	/// used as a sort of local "brushing" operation to select just data within
	/// a window.
	///
	///
	/// @warning
	/// You must carefully synchronize the execution of this filter. The
	/// filter refers to a renderer, which is modified every time a render
	/// occurs. Therefore, the filter is always out of date, and always
	/// executes. You may have to perform two rendering passes, or if you
	/// are using this filter in conjunction with vtkLabeledDataMapper,
	/// things work out because 2D rendering occurs after the 3D rendering.
	/// </remarks>
	// Token: 0x020007FF RID: 2047
	public class vtkSelectVisiblePoints : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015071 RID: 86129 RVA: 0x001DC149 File Offset: 0x001DA349
		static vtkSelectVisiblePoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSelectVisiblePoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSelectVisiblePoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015072 RID: 86130 RVA: 0x001DC171 File Offset: 0x001DA371
		public vtkSelectVisiblePoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015073 RID: 86131
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectVisiblePoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with no renderer; window selection turned off;
		/// tolerance set to 0.01; and select invisible off.
		/// </summary>
		// Token: 0x06015074 RID: 86132 RVA: 0x001DC180 File Offset: 0x001DA380
		public new static vtkSelectVisiblePoints New()
		{
			vtkSelectVisiblePoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectVisiblePoints.vtkSelectVisiblePoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelectVisiblePoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object with no renderer; window selection turned off;
		/// tolerance set to 0.01; and select invisible off.
		/// </summary>
		// Token: 0x06015075 RID: 86133 RVA: 0x001DC1D4 File Offset: 0x001DA3D4
		public vtkSelectVisiblePoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSelectVisiblePoints.vtkSelectVisiblePoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015076 RID: 86134 RVA: 0x001DC218 File Offset: 0x001DA418
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015077 RID: 86135
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkSelectVisiblePoints_GetMTime_01(HandleRef pThis);

		/// <summary>
		/// Return MTime also considering the renderer.
		/// </summary>
		// Token: 0x06015078 RID: 86136 RVA: 0x001DC224 File Offset: 0x001DA424
		public override ulong GetMTime()
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetMTime_01(base.GetCppThis());
		}

		// Token: 0x06015079 RID: 86137
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSelectVisiblePoints_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601507A RID: 86138 RVA: 0x001DC244 File Offset: 0x001DA444
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601507B RID: 86139
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSelectVisiblePoints_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601507C RID: 86140 RVA: 0x001DC264 File Offset: 0x001DA464
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601507D RID: 86141
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectVisiblePoints_GetRenderer_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the renderer in which the visibility computation is to be
		/// performed.
		/// </summary>
		// Token: 0x0601507E RID: 86142 RVA: 0x001DC280 File Offset: 0x001DA480
		public vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetRenderer_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601507F RID: 86143
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectVisiblePoints_GetSelectInvisible_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which enables inverse selection; i.e., invisible points
		/// are selected.
		/// </summary>
		// Token: 0x06015080 RID: 86144 RVA: 0x001DC2F0 File Offset: 0x001DA4F0
		public virtual int GetSelectInvisible()
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetSelectInvisible_05(base.GetCppThis());
		}

		// Token: 0x06015081 RID: 86145
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectVisiblePoints_GetSelection_06(HandleRef pThis);

		/// <summary>
		/// Specify the selection window in display coordinates. You must specify
		/// a rectangular region using (xmin,xmax,ymin,ymax).
		/// </summary>
		// Token: 0x06015082 RID: 86146 RVA: 0x001DC310 File Offset: 0x001DA510
		public virtual int[] GetSelection()
		{
			IntPtr intPtr = vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetSelection_06(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015083 RID: 86147
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectVisiblePoints_GetSelection_07(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the selection window in display coordinates. You must specify
		/// a rectangular region using (xmin,xmax,ymin,ymax).
		/// </summary>
		// Token: 0x06015084 RID: 86148 RVA: 0x001DC358 File Offset: 0x001DA558
		public virtual void GetSelection(IntPtr data)
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetSelection_07(base.GetCppThis(), data);
		}

		// Token: 0x06015085 RID: 86149
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectVisiblePoints_GetSelectionWindow_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which enables selection in a rectangular display
		/// region.
		/// </summary>
		// Token: 0x06015086 RID: 86150 RVA: 0x001DC368 File Offset: 0x001DA568
		public virtual int GetSelectionWindow()
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetSelectionWindow_08(base.GetCppThis());
		}

		// Token: 0x06015087 RID: 86151
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSelectVisiblePoints_GetTolerance_09(HandleRef pThis);

		/// <summary>
		/// Set/Get a tolerance in normalized display coordinate system
		/// to use to determine whether a point is visible. A
		/// tolerance is usually required because the conversion from world space
		/// to display space during rendering introduces numerical round-off.
		/// </summary>
		// Token: 0x06015088 RID: 86152 RVA: 0x001DC388 File Offset: 0x001DA588
		public virtual double GetTolerance()
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetTolerance_09(base.GetCppThis());
		}

		// Token: 0x06015089 RID: 86153
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSelectVisiblePoints_GetToleranceMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Set/Get a tolerance in normalized display coordinate system
		/// to use to determine whether a point is visible. A
		/// tolerance is usually required because the conversion from world space
		/// to display space during rendering introduces numerical round-off.
		/// </summary>
		// Token: 0x0601508A RID: 86154 RVA: 0x001DC3A8 File Offset: 0x001DA5A8
		public virtual double GetToleranceMaxValue()
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetToleranceMaxValue_10(base.GetCppThis());
		}

		// Token: 0x0601508B RID: 86155
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSelectVisiblePoints_GetToleranceMinValue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get a tolerance in normalized display coordinate system
		/// to use to determine whether a point is visible. A
		/// tolerance is usually required because the conversion from world space
		/// to display space during rendering introduces numerical round-off.
		/// </summary>
		// Token: 0x0601508C RID: 86156 RVA: 0x001DC3C8 File Offset: 0x001DA5C8
		public virtual double GetToleranceMinValue()
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetToleranceMinValue_11(base.GetCppThis());
		}

		// Token: 0x0601508D RID: 86157
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSelectVisiblePoints_GetToleranceWorld_12(HandleRef pThis);

		/// <summary>
		/// Set/Get a tolerance in world coordinate system
		/// to use to determine whether a point is visible.
		/// This allows determining visibility of small spheroid objects
		/// (such as glyphs) with known size in world coordinates.
		/// By default it is set to 0.
		/// </summary>
		// Token: 0x0601508E RID: 86158 RVA: 0x001DC3E8 File Offset: 0x001DA5E8
		public virtual double GetToleranceWorld()
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetToleranceWorld_12(base.GetCppThis());
		}

		// Token: 0x0601508F RID: 86159
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSelectVisiblePoints_GetToleranceWorldMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Set/Get a tolerance in world coordinate system
		/// to use to determine whether a point is visible.
		/// This allows determining visibility of small spheroid objects
		/// (such as glyphs) with known size in world coordinates.
		/// By default it is set to 0.
		/// </summary>
		// Token: 0x06015090 RID: 86160 RVA: 0x001DC408 File Offset: 0x001DA608
		public virtual double GetToleranceWorldMaxValue()
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetToleranceWorldMaxValue_13(base.GetCppThis());
		}

		// Token: 0x06015091 RID: 86161
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSelectVisiblePoints_GetToleranceWorldMinValue_14(HandleRef pThis);

		/// <summary>
		/// Set/Get a tolerance in world coordinate system
		/// to use to determine whether a point is visible.
		/// This allows determining visibility of small spheroid objects
		/// (such as glyphs) with known size in world coordinates.
		/// By default it is set to 0.
		/// </summary>
		// Token: 0x06015092 RID: 86162 RVA: 0x001DC428 File Offset: 0x001DA628
		public virtual double GetToleranceWorldMinValue()
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetToleranceWorldMinValue_14(base.GetCppThis());
		}

		// Token: 0x06015093 RID: 86163
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectVisiblePoints_Initialize_15(HandleRef pThis, byte getZbuff);

		/// <summary>
		/// Requires the renderer to be set. Populates the composite perspective transform
		/// and returns a pointer to the Z-buffer (that must be deleted) if getZbuff is set.
		/// </summary>
		// Token: 0x06015094 RID: 86164 RVA: 0x001DC448 File Offset: 0x001DA648
		public IntPtr Initialize(bool getZbuff)
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_Initialize_15(base.GetCppThis(), getZbuff ? (byte)1 : (byte)0);
		}

		// Token: 0x06015095 RID: 86165
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectVisiblePoints_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015096 RID: 86166 RVA: 0x001DC470 File Offset: 0x001DA670
		public override int IsA(string type)
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06015097 RID: 86167
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSelectVisiblePoints_IsPointOccluded_17(HandleRef pThis, IntPtr x, IntPtr zPtr);

		/// <summary>
		/// Tests if a point x is being occluded or not against the Z-Buffer array passed in by
		/// zPtr. Call Initialize before calling this method.
		/// </summary>
		// Token: 0x06015098 RID: 86168 RVA: 0x001DC490 File Offset: 0x001DA690
		public bool IsPointOccluded(IntPtr x, IntPtr zPtr)
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_IsPointOccluded_17(base.GetCppThis(), x, zPtr) != 0;
		}

		// Token: 0x06015099 RID: 86169
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectVisiblePoints_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601509A RID: 86170 RVA: 0x001DC4B8 File Offset: 0x001DA6B8
		public new static int IsTypeOf(string type)
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_IsTypeOf_18(type);
		}

		// Token: 0x0601509B RID: 86171
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectVisiblePoints_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601509C RID: 86172 RVA: 0x001DC4D4 File Offset: 0x001DA6D4
		public new vtkSelectVisiblePoints NewInstance()
		{
			vtkSelectVisiblePoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectVisiblePoints.vtkSelectVisiblePoints_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelectVisiblePoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601509D RID: 86173
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectVisiblePoints_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601509E RID: 86174 RVA: 0x001DC530 File Offset: 0x001DA730
		public new static vtkSelectVisiblePoints SafeDownCast(vtkObjectBase o)
		{
			vtkSelectVisiblePoints vtkSelectVisiblePoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectVisiblePoints.vtkSelectVisiblePoints_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelectVisiblePoints = (vtkSelectVisiblePoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelectVisiblePoints.Register(null);
				}
			}
			return vtkSelectVisiblePoints;
		}

		// Token: 0x0601509F RID: 86175
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectVisiblePoints_SelectInvisibleOff_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which enables inverse selection; i.e., invisible points
		/// are selected.
		/// </summary>
		// Token: 0x060150A0 RID: 86176 RVA: 0x001DC5AF File Offset: 0x001DA7AF
		public virtual void SelectInvisibleOff()
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SelectInvisibleOff_22(base.GetCppThis());
		}

		// Token: 0x060150A1 RID: 86177
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectVisiblePoints_SelectInvisibleOn_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which enables inverse selection; i.e., invisible points
		/// are selected.
		/// </summary>
		// Token: 0x060150A2 RID: 86178 RVA: 0x001DC5BE File Offset: 0x001DA7BE
		public virtual void SelectInvisibleOn()
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SelectInvisibleOn_23(base.GetCppThis());
		}

		// Token: 0x060150A3 RID: 86179
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectVisiblePoints_SelectionWindowOff_24(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which enables selection in a rectangular display
		/// region.
		/// </summary>
		// Token: 0x060150A4 RID: 86180 RVA: 0x001DC5CD File Offset: 0x001DA7CD
		public virtual void SelectionWindowOff()
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SelectionWindowOff_24(base.GetCppThis());
		}

		// Token: 0x060150A5 RID: 86181
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectVisiblePoints_SelectionWindowOn_25(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which enables selection in a rectangular display
		/// region.
		/// </summary>
		// Token: 0x060150A6 RID: 86182 RVA: 0x001DC5DC File Offset: 0x001DA7DC
		public virtual void SelectionWindowOn()
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SelectionWindowOn_25(base.GetCppThis());
		}

		// Token: 0x060150A7 RID: 86183
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectVisiblePoints_SetRenderer_26(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Specify the renderer in which the visibility computation is to be
		/// performed.
		/// </summary>
		// Token: 0x060150A8 RID: 86184 RVA: 0x001DC5EC File Offset: 0x001DA7EC
		public void SetRenderer(vtkRenderer ren)
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SetRenderer_26(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x060150A9 RID: 86185
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectVisiblePoints_SetSelectInvisible_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flag which enables inverse selection; i.e., invisible points
		/// are selected.
		/// </summary>
		// Token: 0x060150AA RID: 86186 RVA: 0x001DC61B File Offset: 0x001DA81B
		public virtual void SetSelectInvisible(int _arg)
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SetSelectInvisible_27(base.GetCppThis(), _arg);
		}

		// Token: 0x060150AB RID: 86187
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectVisiblePoints_SetSelection_28(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4);

		/// <summary>
		/// Specify the selection window in display coordinates. You must specify
		/// a rectangular region using (xmin,xmax,ymin,ymax).
		/// </summary>
		// Token: 0x060150AC RID: 86188 RVA: 0x001DC62B File Offset: 0x001DA82B
		public virtual void SetSelection(int _arg1, int _arg2, int _arg3, int _arg4)
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SetSelection_28(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x060150AD RID: 86189
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectVisiblePoints_SetSelection_29(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the selection window in display coordinates. You must specify
		/// a rectangular region using (xmin,xmax,ymin,ymax).
		/// </summary>
		// Token: 0x060150AE RID: 86190 RVA: 0x001DC63F File Offset: 0x001DA83F
		public virtual void SetSelection(IntPtr _arg)
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SetSelection_29(base.GetCppThis(), _arg);
		}

		// Token: 0x060150AF RID: 86191
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectVisiblePoints_SetSelectionWindow_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flag which enables selection in a rectangular display
		/// region.
		/// </summary>
		// Token: 0x060150B0 RID: 86192 RVA: 0x001DC64F File Offset: 0x001DA84F
		public virtual void SetSelectionWindow(int _arg)
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SetSelectionWindow_30(base.GetCppThis(), _arg);
		}

		// Token: 0x060150B1 RID: 86193
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectVisiblePoints_SetTolerance_31(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get a tolerance in normalized display coordinate system
		/// to use to determine whether a point is visible. A
		/// tolerance is usually required because the conversion from world space
		/// to display space during rendering introduces numerical round-off.
		/// </summary>
		// Token: 0x060150B2 RID: 86194 RVA: 0x001DC65F File Offset: 0x001DA85F
		public virtual void SetTolerance(double _arg)
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SetTolerance_31(base.GetCppThis(), _arg);
		}

		// Token: 0x060150B3 RID: 86195
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectVisiblePoints_SetToleranceWorld_32(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get a tolerance in world coordinate system
		/// to use to determine whether a point is visible.
		/// This allows determining visibility of small spheroid objects
		/// (such as glyphs) with known size in world coordinates.
		/// By default it is set to 0.
		/// </summary>
		// Token: 0x060150B4 RID: 86196 RVA: 0x001DC66F File Offset: 0x001DA86F
		public virtual void SetToleranceWorld(double _arg)
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SetToleranceWorld_32(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001842 RID: 6210
		public new const string MRFullTypeName = "Kitware.VTK.vtkSelectVisiblePoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001843 RID: 6211
		public new static readonly string MRClassNameKey = "class vtkSelectVisiblePoints";
	}
}
