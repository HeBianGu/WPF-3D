using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWindowLevelLookupTable
	/// </summary>
	/// <remarks>
	///    map scalar values into colors or colors to scalars; generate color table
	///
	/// vtkWindowLevelLookupTable is an object that is used by mapper objects
	/// to map scalar values into rgba (red-green-blue-alpha transparency)
	/// color specification, or rgba into scalar values. The color table can
	/// be created by direct insertion of color values, or by specifying a
	/// window and level. Window / Level is used in medical imaging to specify
	/// a linear greyscale ramp. The Level is the center of the ramp.  The
	/// Window is the width of the ramp.
	///
	/// @warning
	/// vtkWindowLevelLookupTable is a reference counted object. Therefore, you
	/// should always use operator "new" to construct new objects. This procedure
	/// will avoid memory problems (see text).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLogLookupTable
	/// </seealso>
	// Token: 0x0200080B RID: 2059
	public class vtkWindowLevelLookupTable : vtkLookupTable
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060152A6 RID: 86694 RVA: 0x001DF568 File Offset: 0x001DD768
		static vtkWindowLevelLookupTable()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWindowLevelLookupTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWindowLevelLookupTable"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060152A7 RID: 86695 RVA: 0x001DF590 File Offset: 0x001DD790
		public vtkWindowLevelLookupTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060152A8 RID: 86696
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowLevelLookupTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060152A9 RID: 86697 RVA: 0x001DF5A0 File Offset: 0x001DD7A0
		public new static vtkWindowLevelLookupTable New()
		{
			vtkWindowLevelLookupTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWindowLevelLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060152AA RID: 86698 RVA: 0x001DF5F4 File Offset: 0x001DD7F4
		public vtkWindowLevelLookupTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060152AB RID: 86699 RVA: 0x001DF638 File Offset: 0x001DD838
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060152AC RID: 86700
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowLevelLookupTable_ForceBuild_01(HandleRef pThis);

		/// <summary>
		/// Generate lookup table as a linear ramp between MinimumTableValue
		/// and MaximumTableValue.
		/// </summary>
		// Token: 0x060152AD RID: 86701 RVA: 0x001DF643 File Offset: 0x001DD843
		public override void ForceBuild()
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_ForceBuild_01(base.GetCppThis());
		}

		// Token: 0x060152AE RID: 86702
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowLevelLookupTable_GetInverseVideo_02(HandleRef pThis);

		/// <summary>
		/// Set inverse video on or off.  You can achieve the same effect by
		/// switching the MinimumTableValue and the MaximumTableValue.
		/// </summary>
		// Token: 0x060152AF RID: 86703 RVA: 0x001DF654 File Offset: 0x001DD854
		public virtual int GetInverseVideo()
		{
			return vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_GetInverseVideo_02(base.GetCppThis());
		}

		// Token: 0x060152B0 RID: 86704
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWindowLevelLookupTable_GetLevel_03(HandleRef pThis);

		/// <summary>
		/// Set the Level for the lookup table.  The level is the average of
		/// TableRange[0] and TableRange[1].
		/// </summary>
		// Token: 0x060152B1 RID: 86705 RVA: 0x001DF674 File Offset: 0x001DD874
		public virtual double GetLevel()
		{
			return vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_GetLevel_03(base.GetCppThis());
		}

		// Token: 0x060152B2 RID: 86706
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowLevelLookupTable_GetMaximumTableValue_04(HandleRef pThis);

		/// <summary>
		/// Set the maximum table value. All lookup table entries above the
		/// end of the ramp will be set to this color.  After you change
		/// this value, you must re-build the lookup table.
		/// </summary>
		// Token: 0x060152B3 RID: 86707 RVA: 0x001DF694 File Offset: 0x001DD894
		public virtual double[] GetMaximumTableValue()
		{
			IntPtr intPtr = vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_GetMaximumTableValue_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060152B4 RID: 86708
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowLevelLookupTable_GetMaximumTableValue_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Set the maximum table value. All lookup table entries above the
		/// end of the ramp will be set to this color.  After you change
		/// this value, you must re-build the lookup table.
		/// </summary>
		// Token: 0x060152B5 RID: 86709 RVA: 0x001DF6DC File Offset: 0x001DD8DC
		public virtual void GetMaximumTableValue(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_GetMaximumTableValue_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x060152B6 RID: 86710
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowLevelLookupTable_GetMaximumTableValue_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the maximum table value. All lookup table entries above the
		/// end of the ramp will be set to this color.  After you change
		/// this value, you must re-build the lookup table.
		/// </summary>
		// Token: 0x060152B7 RID: 86711 RVA: 0x001DF6F0 File Offset: 0x001DD8F0
		public virtual void GetMaximumTableValue(IntPtr _arg)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_GetMaximumTableValue_06(base.GetCppThis(), _arg);
		}

		// Token: 0x060152B8 RID: 86712
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowLevelLookupTable_GetMinimumTableValue_07(HandleRef pThis);

		/// <summary>
		/// Set the minimum table value.  All lookup table entries below the
		/// start of the ramp will be set to this color.  After you change
		/// this value, you must re-build the lookup table.
		/// </summary>
		// Token: 0x060152B9 RID: 86713 RVA: 0x001DF700 File Offset: 0x001DD900
		public virtual double[] GetMinimumTableValue()
		{
			IntPtr intPtr = vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_GetMinimumTableValue_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060152BA RID: 86714
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowLevelLookupTable_GetMinimumTableValue_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Set the minimum table value.  All lookup table entries below the
		/// start of the ramp will be set to this color.  After you change
		/// this value, you must re-build the lookup table.
		/// </summary>
		// Token: 0x060152BB RID: 86715 RVA: 0x001DF748 File Offset: 0x001DD948
		public virtual void GetMinimumTableValue(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_GetMinimumTableValue_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x060152BC RID: 86716
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowLevelLookupTable_GetMinimumTableValue_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the minimum table value.  All lookup table entries below the
		/// start of the ramp will be set to this color.  After you change
		/// this value, you must re-build the lookup table.
		/// </summary>
		// Token: 0x060152BD RID: 86717 RVA: 0x001DF75C File Offset: 0x001DD95C
		public virtual void GetMinimumTableValue(IntPtr _arg)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_GetMinimumTableValue_09(base.GetCppThis(), _arg);
		}

		// Token: 0x060152BE RID: 86718
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWindowLevelLookupTable_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060152BF RID: 86719 RVA: 0x001DF76C File Offset: 0x001DD96C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x060152C0 RID: 86720
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWindowLevelLookupTable_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060152C1 RID: 86721 RVA: 0x001DF78C File Offset: 0x001DD98C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x060152C2 RID: 86722
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWindowLevelLookupTable_GetWindow_12(HandleRef pThis);

		/// <summary>
		/// Set the window for the lookup table.  The window is the difference
		/// between TableRange[0] and TableRange[1].
		/// </summary>
		// Token: 0x060152C3 RID: 86723 RVA: 0x001DF7A8 File Offset: 0x001DD9A8
		public virtual double GetWindow()
		{
			return vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_GetWindow_12(base.GetCppThis());
		}

		// Token: 0x060152C4 RID: 86724
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowLevelLookupTable_InverseVideoOff_13(HandleRef pThis);

		/// <summary>
		/// Set inverse video on or off.  You can achieve the same effect by
		/// switching the MinimumTableValue and the MaximumTableValue.
		/// </summary>
		// Token: 0x060152C5 RID: 86725 RVA: 0x001DF7C7 File Offset: 0x001DD9C7
		public virtual void InverseVideoOff()
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_InverseVideoOff_13(base.GetCppThis());
		}

		// Token: 0x060152C6 RID: 86726
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowLevelLookupTable_InverseVideoOn_14(HandleRef pThis);

		/// <summary>
		/// Set inverse video on or off.  You can achieve the same effect by
		/// switching the MinimumTableValue and the MaximumTableValue.
		/// </summary>
		// Token: 0x060152C7 RID: 86727 RVA: 0x001DF7D6 File Offset: 0x001DD9D6
		public virtual void InverseVideoOn()
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_InverseVideoOn_14(base.GetCppThis());
		}

		// Token: 0x060152C8 RID: 86728
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowLevelLookupTable_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060152C9 RID: 86729 RVA: 0x001DF7E8 File Offset: 0x001DD9E8
		public override int IsA(string type)
		{
			return vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x060152CA RID: 86730
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowLevelLookupTable_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060152CB RID: 86731 RVA: 0x001DF808 File Offset: 0x001DDA08
		public new static int IsTypeOf(string type)
		{
			return vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_IsTypeOf_16(type);
		}

		// Token: 0x060152CC RID: 86732
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowLevelLookupTable_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060152CD RID: 86733 RVA: 0x001DF824 File Offset: 0x001DDA24
		public new vtkWindowLevelLookupTable NewInstance()
		{
			vtkWindowLevelLookupTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWindowLevelLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060152CE RID: 86734
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowLevelLookupTable_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060152CF RID: 86735 RVA: 0x001DF880 File Offset: 0x001DDA80
		public new static vtkWindowLevelLookupTable SafeDownCast(vtkObjectBase o)
		{
			vtkWindowLevelLookupTable vtkWindowLevelLookupTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWindowLevelLookupTable = (vtkWindowLevelLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWindowLevelLookupTable.Register(null);
				}
			}
			return vtkWindowLevelLookupTable;
		}

		// Token: 0x060152D0 RID: 86736
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowLevelLookupTable_SetInverseVideo_20(HandleRef pThis, int iv);

		/// <summary>
		/// Set inverse video on or off.  You can achieve the same effect by
		/// switching the MinimumTableValue and the MaximumTableValue.
		/// </summary>
		// Token: 0x060152D1 RID: 86737 RVA: 0x001DF8FF File Offset: 0x001DDAFF
		public void SetInverseVideo(int iv)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_SetInverseVideo_20(base.GetCppThis(), iv);
		}

		// Token: 0x060152D2 RID: 86738
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowLevelLookupTable_SetLevel_21(HandleRef pThis, double level);

		/// <summary>
		/// Set the Level for the lookup table.  The level is the average of
		/// TableRange[0] and TableRange[1].
		/// </summary>
		// Token: 0x060152D3 RID: 86739 RVA: 0x001DF90F File Offset: 0x001DDB0F
		public void SetLevel(double level)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_SetLevel_21(base.GetCppThis(), level);
		}

		// Token: 0x060152D4 RID: 86740
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowLevelLookupTable_SetMaximumTableValue_22(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Set the maximum table value. All lookup table entries above the
		/// end of the ramp will be set to this color.  After you change
		/// this value, you must re-build the lookup table.
		/// </summary>
		// Token: 0x060152D5 RID: 86741 RVA: 0x001DF91F File Offset: 0x001DDB1F
		public virtual void SetMaximumTableValue(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_SetMaximumTableValue_22(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x060152D6 RID: 86742
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowLevelLookupTable_SetMaximumTableValue_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the maximum table value. All lookup table entries above the
		/// end of the ramp will be set to this color.  After you change
		/// this value, you must re-build the lookup table.
		/// </summary>
		// Token: 0x060152D7 RID: 86743 RVA: 0x001DF933 File Offset: 0x001DDB33
		public virtual void SetMaximumTableValue(IntPtr _arg)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_SetMaximumTableValue_23(base.GetCppThis(), _arg);
		}

		// Token: 0x060152D8 RID: 86744
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowLevelLookupTable_SetMinimumTableValue_24(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Set the minimum table value.  All lookup table entries below the
		/// start of the ramp will be set to this color.  After you change
		/// this value, you must re-build the lookup table.
		/// </summary>
		// Token: 0x060152D9 RID: 86745 RVA: 0x001DF943 File Offset: 0x001DDB43
		public virtual void SetMinimumTableValue(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_SetMinimumTableValue_24(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x060152DA RID: 86746
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowLevelLookupTable_SetMinimumTableValue_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the minimum table value.  All lookup table entries below the
		/// start of the ramp will be set to this color.  After you change
		/// this value, you must re-build the lookup table.
		/// </summary>
		// Token: 0x060152DB RID: 86747 RVA: 0x001DF957 File Offset: 0x001DDB57
		public virtual void SetMinimumTableValue(IntPtr _arg)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_SetMinimumTableValue_25(base.GetCppThis(), _arg);
		}

		// Token: 0x060152DC RID: 86748
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowLevelLookupTable_SetWindow_26(HandleRef pThis, double window);

		/// <summary>
		/// Set the window for the lookup table.  The window is the difference
		/// between TableRange[0] and TableRange[1].
		/// </summary>
		// Token: 0x060152DD RID: 86749 RVA: 0x001DF967 File Offset: 0x001DDB67
		public void SetWindow(double window)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_SetWindow_26(base.GetCppThis(), window);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400185E RID: 6238
		public new const string MRFullTypeName = "Kitware.VTK.vtkWindowLevelLookupTable";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400185F RID: 6239
		public new static readonly string MRClassNameKey = "class vtkWindowLevelLookupTable";
	}
}
