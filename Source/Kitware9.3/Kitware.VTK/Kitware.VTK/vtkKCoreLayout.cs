using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkKCoreLayout
	/// </summary>
	/// <remarks>
	///    Produces a layout for a graph labeled with K-Core
	///                        information.
	///
	///
	/// vtkKCoreLayout creates coordinates for each vertex that can be used to
	/// perform a layout for a k-core view.
	/// Prerequisite:  Vertices must have an attribute array containing their
	///                k-core number.  This layout is based on the algorithm
	///                described in the paper: "k-core decomposition: a tool
	///                for the visualization of large scale networks", by
	///                Ignacio Alvarez-Hamelin et. al.
	///
	///                This graph algorithm appends either polar coordinates or cartesian coordinates
	///                as vertex attributes to the graph giving the position of the vertex in a layout.
	///                Input graphs must have the k-core number assigned to each vertex (default
	///                attribute array storing kcore numbers is "kcore").
	///
	///                Epsilon - this factor is used to adjust the amount vertices are 'pulled' out of
	///                          their default ring radius based on the number of neighbors in higher
	///                          cores.  Default=0.2
	///                UnitRadius - Tweaks the base unit radius value.  Default=1.0
	///
	///                Still TODO: Still need to work on the connected-components within each shell and
	///                            associated layout issues with that.
	///
	/// Input port 0: graph
	///
	/// @par Thanks:
	/// Thanks to William McLendon from Sandia National Laboratories for providing this
	/// implementation.
	/// </remarks>
	// Token: 0x02000293 RID: 659
	public class vtkKCoreLayout : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007754 RID: 30548 RVA: 0x000AC1F2 File Offset: 0x000AA3F2
		static vtkKCoreLayout()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkKCoreLayout.MRClassNameKey, Type.GetType("Kitware.VTK.vtkKCoreLayout"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007755 RID: 30549 RVA: 0x000AC21A File Offset: 0x000AA41A
		public vtkKCoreLayout(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007756 RID: 30550
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKCoreLayout_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007757 RID: 30551 RVA: 0x000AC228 File Offset: 0x000AA428
		public new static vtkKCoreLayout New()
		{
			vtkKCoreLayout result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKCoreLayout.vtkKCoreLayout_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKCoreLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007758 RID: 30552 RVA: 0x000AC27C File Offset: 0x000AA47C
		public vtkKCoreLayout() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkKCoreLayout.vtkKCoreLayout_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007759 RID: 30553 RVA: 0x000AC2C0 File Offset: 0x000AA4C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600775A RID: 30554
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreLayout_CartesianOff_01(HandleRef pThis);

		/// <summary>
		/// Set whether or not to convert output to cartesian coordinates.  If false, coordinates
		/// will be returned in polar coordinates (radius, angle).
		/// Default: True
		/// </summary>
		// Token: 0x0600775B RID: 30555 RVA: 0x000AC2CB File Offset: 0x000AA4CB
		public virtual void CartesianOff()
		{
			vtkKCoreLayout.vtkKCoreLayout_CartesianOff_01(base.GetCppThis());
		}

		// Token: 0x0600775C RID: 30556
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreLayout_CartesianOn_02(HandleRef pThis);

		/// <summary>
		/// Set whether or not to convert output to cartesian coordinates.  If false, coordinates
		/// will be returned in polar coordinates (radius, angle).
		/// Default: True
		/// </summary>
		// Token: 0x0600775D RID: 30557 RVA: 0x000AC2DA File Offset: 0x000AA4DA
		public virtual void CartesianOn()
		{
			vtkKCoreLayout.vtkKCoreLayout_CartesianOn_02(base.GetCppThis());
		}

		// Token: 0x0600775E RID: 30558
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKCoreLayout_FillInputPortInformation_03(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600775F RID: 30559 RVA: 0x000AC2EC File Offset: 0x000AA4EC
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkKCoreLayout.vtkKCoreLayout_FillInputPortInformation_03(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x06007760 RID: 30560
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkKCoreLayout_GetCartesian_04(HandleRef pThis);

		/// <summary>
		/// Set whether or not to convert output to cartesian coordinates.  If false, coordinates
		/// will be returned in polar coordinates (radius, angle).
		/// Default: True
		/// </summary>
		// Token: 0x06007761 RID: 30561 RVA: 0x000AC324 File Offset: 0x000AA524
		public virtual bool GetCartesian()
		{
			return vtkKCoreLayout.vtkKCoreLayout_GetCartesian_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06007762 RID: 30562
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKCoreLayout_GetCartesianCoordsXArrayName_05(HandleRef pThis);

		/// <summary>
		/// Cartesian coordinates array name for the X coordinates.
		/// This is only used if OutputCartesianCoordinates is True.
		/// Default: coord_x
		/// </summary>
		// Token: 0x06007763 RID: 30563 RVA: 0x000AC34C File Offset: 0x000AA54C
		public virtual string GetCartesianCoordsXArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkKCoreLayout.vtkKCoreLayout_GetCartesianCoordsXArrayName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007764 RID: 30564
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKCoreLayout_GetCartesianCoordsYArrayName_06(HandleRef pThis);

		/// <summary>
		/// Cartesian coordinates array name for the Y coordinates.
		/// This is only used if OutputCartesianCoordinates is True.
		/// Default: coord_y
		/// </summary>
		// Token: 0x06007765 RID: 30565 RVA: 0x000AC388 File Offset: 0x000AA588
		public virtual string GetCartesianCoordsYArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkKCoreLayout.vtkKCoreLayout_GetCartesianCoordsYArrayName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007766 RID: 30566
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkKCoreLayout_GetEpsilon_07(HandleRef pThis);

		/// <summary>
		/// Epsilon value used in the algorithm.
		/// Default = 0.2
		/// </summary>
		// Token: 0x06007767 RID: 30567 RVA: 0x000AC3C4 File Offset: 0x000AA5C4
		public virtual float GetEpsilon()
		{
			return vtkKCoreLayout.vtkKCoreLayout_GetEpsilon_07(base.GetCppThis());
		}

		// Token: 0x06007768 RID: 30568
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKCoreLayout_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007769 RID: 30569 RVA: 0x000AC3E4 File Offset: 0x000AA5E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkKCoreLayout.vtkKCoreLayout_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600776A RID: 30570
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKCoreLayout_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600776B RID: 30571 RVA: 0x000AC404 File Offset: 0x000AA604
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkKCoreLayout.vtkKCoreLayout_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600776C RID: 30572
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkKCoreLayout_GetPolar_10(HandleRef pThis);

		/// <summary>
		/// Output polar coordinates for vertices if True.  Default column names are
		/// coord_radius, coord_angle.
		/// Default: False
		/// </summary>
		// Token: 0x0600776D RID: 30573 RVA: 0x000AC420 File Offset: 0x000AA620
		public virtual bool GetPolar()
		{
			return vtkKCoreLayout.vtkKCoreLayout_GetPolar_10(base.GetCppThis()) != 0;
		}

		// Token: 0x0600776E RID: 30574
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKCoreLayout_GetPolarCoordsAngleArrayName_11(HandleRef pThis);

		/// <summary>
		/// Polar coordinates array name for angle values in radians.
		/// This is only used if OutputCartesianCoordinates is False.
		/// Default: coord_angle
		/// </summary>
		// Token: 0x0600776F RID: 30575 RVA: 0x000AC448 File Offset: 0x000AA648
		public virtual string GetPolarCoordsAngleArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkKCoreLayout.vtkKCoreLayout_GetPolarCoordsAngleArrayName_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007770 RID: 30576
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKCoreLayout_GetPolarCoordsRadiusArrayName_12(HandleRef pThis);

		/// <summary>
		/// Polar coordinates array name for radius values.
		/// This is only used if OutputCartesianCoordinates is False.
		/// Default: coord_radius
		/// </summary>
		// Token: 0x06007771 RID: 30577 RVA: 0x000AC484 File Offset: 0x000AA684
		public virtual string GetPolarCoordsRadiusArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkKCoreLayout.vtkKCoreLayout_GetPolarCoordsRadiusArrayName_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007772 RID: 30578
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkKCoreLayout_GetUnitRadius_13(HandleRef pThis);

		/// <summary>
		/// Unit Radius value used in the algorithm.
		/// Default = 1.0
		/// </summary>
		// Token: 0x06007773 RID: 30579 RVA: 0x000AC4C0 File Offset: 0x000AA6C0
		public virtual float GetUnitRadius()
		{
			return vtkKCoreLayout.vtkKCoreLayout_GetUnitRadius_13(base.GetCppThis());
		}

		// Token: 0x06007774 RID: 30580
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKCoreLayout_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007775 RID: 30581 RVA: 0x000AC4E0 File Offset: 0x000AA6E0
		public override int IsA(string type)
		{
			return vtkKCoreLayout.vtkKCoreLayout_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06007776 RID: 30582
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKCoreLayout_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007777 RID: 30583 RVA: 0x000AC500 File Offset: 0x000AA700
		public new static int IsTypeOf(string type)
		{
			return vtkKCoreLayout.vtkKCoreLayout_IsTypeOf_15(type);
		}

		// Token: 0x06007778 RID: 30584
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKCoreLayout_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007779 RID: 30585 RVA: 0x000AC51C File Offset: 0x000AA71C
		public new vtkKCoreLayout NewInstance()
		{
			vtkKCoreLayout result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKCoreLayout.vtkKCoreLayout_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKCoreLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600777A RID: 30586
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreLayout_PolarOff_18(HandleRef pThis);

		/// <summary>
		/// Output polar coordinates for vertices if True.  Default column names are
		/// coord_radius, coord_angle.
		/// Default: False
		/// </summary>
		// Token: 0x0600777B RID: 30587 RVA: 0x000AC576 File Offset: 0x000AA776
		public virtual void PolarOff()
		{
			vtkKCoreLayout.vtkKCoreLayout_PolarOff_18(base.GetCppThis());
		}

		// Token: 0x0600777C RID: 30588
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreLayout_PolarOn_19(HandleRef pThis);

		/// <summary>
		/// Output polar coordinates for vertices if True.  Default column names are
		/// coord_radius, coord_angle.
		/// Default: False
		/// </summary>
		// Token: 0x0600777D RID: 30589 RVA: 0x000AC585 File Offset: 0x000AA785
		public virtual void PolarOn()
		{
			vtkKCoreLayout.vtkKCoreLayout_PolarOn_19(base.GetCppThis());
		}

		// Token: 0x0600777E RID: 30590
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKCoreLayout_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600777F RID: 30591 RVA: 0x000AC594 File Offset: 0x000AA794
		public new static vtkKCoreLayout SafeDownCast(vtkObjectBase o)
		{
			vtkKCoreLayout vtkKCoreLayout = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKCoreLayout.vtkKCoreLayout_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKCoreLayout = (vtkKCoreLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKCoreLayout.Register(null);
				}
			}
			return vtkKCoreLayout;
		}

		// Token: 0x06007780 RID: 30592
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreLayout_SetCartesian_21(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set whether or not to convert output to cartesian coordinates.  If false, coordinates
		/// will be returned in polar coordinates (radius, angle).
		/// Default: True
		/// </summary>
		// Token: 0x06007781 RID: 30593 RVA: 0x000AC613 File Offset: 0x000AA813
		public virtual void SetCartesian(bool _arg)
		{
			vtkKCoreLayout.vtkKCoreLayout_SetCartesian_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06007782 RID: 30594
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreLayout_SetCartesianCoordsXArrayName_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Cartesian coordinates array name for the X coordinates.
		/// This is only used if OutputCartesianCoordinates is True.
		/// Default: coord_x
		/// </summary>
		// Token: 0x06007783 RID: 30595 RVA: 0x000AC62B File Offset: 0x000AA82B
		public virtual void SetCartesianCoordsXArrayName(string _arg)
		{
			vtkKCoreLayout.vtkKCoreLayout_SetCartesianCoordsXArrayName_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06007784 RID: 30596
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreLayout_SetCartesianCoordsYArrayName_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Cartesian coordinates array name for the Y coordinates.
		/// This is only used if OutputCartesianCoordinates is True.
		/// Default: coord_y
		/// </summary>
		// Token: 0x06007785 RID: 30597 RVA: 0x000AC63B File Offset: 0x000AA83B
		public virtual void SetCartesianCoordsYArrayName(string _arg)
		{
			vtkKCoreLayout.vtkKCoreLayout_SetCartesianCoordsYArrayName_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06007786 RID: 30598
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreLayout_SetEpsilon_24(HandleRef pThis, float _arg);

		/// <summary>
		/// Epsilon value used in the algorithm.
		/// Default = 0.2
		/// </summary>
		// Token: 0x06007787 RID: 30599 RVA: 0x000AC64B File Offset: 0x000AA84B
		public virtual void SetEpsilon(float _arg)
		{
			vtkKCoreLayout.vtkKCoreLayout_SetEpsilon_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06007788 RID: 30600
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreLayout_SetGraphConnection_25(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007789 RID: 30601 RVA: 0x000AC65C File Offset: 0x000AA85C
		public void SetGraphConnection(vtkAlgorithmOutput arg0)
		{
			vtkKCoreLayout.vtkKCoreLayout_SetGraphConnection_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600778A RID: 30602
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreLayout_SetKCoreLabelArrayName_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the name of the vertex attribute array storing k-core labels.
		/// Default: kcore
		/// </summary>
		// Token: 0x0600778B RID: 30603 RVA: 0x000AC68B File Offset: 0x000AA88B
		public virtual void SetKCoreLabelArrayName(string _arg)
		{
			vtkKCoreLayout.vtkKCoreLayout_SetKCoreLabelArrayName_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600778C RID: 30604
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreLayout_SetPolar_27(HandleRef pThis, byte _arg);

		/// <summary>
		/// Output polar coordinates for vertices if True.  Default column names are
		/// coord_radius, coord_angle.
		/// Default: False
		/// </summary>
		// Token: 0x0600778D RID: 30605 RVA: 0x000AC69B File Offset: 0x000AA89B
		public virtual void SetPolar(bool _arg)
		{
			vtkKCoreLayout.vtkKCoreLayout_SetPolar_27(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600778E RID: 30606
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreLayout_SetPolarCoordsAngleArrayName_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Polar coordinates array name for angle values in radians.
		/// This is only used if OutputCartesianCoordinates is False.
		/// Default: coord_angle
		/// </summary>
		// Token: 0x0600778F RID: 30607 RVA: 0x000AC6B3 File Offset: 0x000AA8B3
		public virtual void SetPolarCoordsAngleArrayName(string _arg)
		{
			vtkKCoreLayout.vtkKCoreLayout_SetPolarCoordsAngleArrayName_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06007790 RID: 30608
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreLayout_SetPolarCoordsRadiusArrayName_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Polar coordinates array name for radius values.
		/// This is only used if OutputCartesianCoordinates is False.
		/// Default: coord_radius
		/// </summary>
		// Token: 0x06007791 RID: 30609 RVA: 0x000AC6C3 File Offset: 0x000AA8C3
		public virtual void SetPolarCoordsRadiusArrayName(string _arg)
		{
			vtkKCoreLayout.vtkKCoreLayout_SetPolarCoordsRadiusArrayName_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06007792 RID: 30610
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreLayout_SetUnitRadius_30(HandleRef pThis, float _arg);

		/// <summary>
		/// Unit Radius value used in the algorithm.
		/// Default = 1.0
		/// </summary>
		// Token: 0x06007793 RID: 30611 RVA: 0x000AC6D3 File Offset: 0x000AA8D3
		public virtual void SetUnitRadius(float _arg)
		{
			vtkKCoreLayout.vtkKCoreLayout_SetUnitRadius_30(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A34 RID: 2612
		public new const string MRFullTypeName = "Kitware.VTK.vtkKCoreLayout";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A35 RID: 2613
		public new static readonly string MRClassNameKey = "class vtkKCoreLayout";
	}
}
