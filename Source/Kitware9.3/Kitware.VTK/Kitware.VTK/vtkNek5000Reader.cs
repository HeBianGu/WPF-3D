using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkNek5000Reader
	/// </summary>
	/// <remarks>
	///    Reads Nek5000 format data files.
	///
	/// @par Thanks:
	/// This class was developed by  Jean Favre (jfavre@cscs.ch) from
	/// the Swiss National Supercomputing Centre
	/// </remarks>
	// Token: 0x02000157 RID: 343
	public class vtkNek5000Reader : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600416A RID: 16746 RVA: 0x0005FFBB File Offset: 0x0005E1BB
		static vtkNek5000Reader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNek5000Reader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNek5000Reader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600416B RID: 16747 RVA: 0x0005FFE3 File Offset: 0x0005E1E3
		public vtkNek5000Reader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600416C RID: 16748
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNek5000Reader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600416D RID: 16749 RVA: 0x0005FFF4 File Offset: 0x0005E1F4
		public new static vtkNek5000Reader New()
		{
			vtkNek5000Reader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNek5000Reader.vtkNek5000Reader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNek5000Reader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600416E RID: 16750 RVA: 0x00060048 File Offset: 0x0005E248
		public vtkNek5000Reader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNek5000Reader.vtkNek5000Reader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600416F RID: 16751 RVA: 0x0006008C File Offset: 0x0005E28C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004170 RID: 16752
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNek5000Reader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Get the names of variables stored in the data
		/// </summary>
		// Token: 0x06004171 RID: 16753 RVA: 0x00060098 File Offset: 0x0005E298
		public int CanReadFile(string fname)
		{
			return vtkNek5000Reader.vtkNek5000Reader_CanReadFile_01(base.GetCppThis(), fname);
		}

		// Token: 0x06004172 RID: 16754
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNek5000Reader_CleanGridOff_02(HandleRef pThis);

		/// <summary>
		/// used for ParaView to decide if cleaning the grid to merge points
		/// </summary>
		// Token: 0x06004173 RID: 16755 RVA: 0x000600B8 File Offset: 0x0005E2B8
		public virtual void CleanGridOff()
		{
			vtkNek5000Reader.vtkNek5000Reader_CleanGridOff_02(base.GetCppThis());
		}

		// Token: 0x06004174 RID: 16756
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNek5000Reader_CleanGridOn_03(HandleRef pThis);

		/// <summary>
		/// used for ParaView to decide if cleaning the grid to merge points
		/// </summary>
		// Token: 0x06004175 RID: 16757 RVA: 0x000600C7 File Offset: 0x0005E2C7
		public virtual void CleanGridOn()
		{
			vtkNek5000Reader.vtkNek5000Reader_CleanGridOn_03(base.GetCppThis());
		}

		// Token: 0x06004176 RID: 16758
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNek5000Reader_DisableAllPointArrays_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off all point arrays.
		/// </summary>
		// Token: 0x06004177 RID: 16759 RVA: 0x000600D6 File Offset: 0x0005E2D6
		public void DisableAllPointArrays()
		{
			vtkNek5000Reader.vtkNek5000Reader_DisableAllPointArrays_04(base.GetCppThis());
		}

		// Token: 0x06004178 RID: 16760
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNek5000Reader_EnableAllPointArrays_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off all point arrays.
		/// </summary>
		// Token: 0x06004179 RID: 16761 RVA: 0x000600E5 File Offset: 0x0005E2E5
		public void EnableAllPointArrays()
		{
			vtkNek5000Reader.vtkNek5000Reader_EnableAllPointArrays_05(base.GetCppThis());
		}

		// Token: 0x0600417A RID: 16762
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNek5000Reader_GetCleanGrid_06(HandleRef pThis);

		/// <summary>
		/// used for ParaView to decide if cleaning the grid to merge points
		/// </summary>
		// Token: 0x0600417B RID: 16763 RVA: 0x000600F4 File Offset: 0x0005E2F4
		public virtual int GetCleanGrid()
		{
			return vtkNek5000Reader.vtkNek5000Reader_GetCleanGrid_06(base.GetCppThis());
		}

		// Token: 0x0600417C RID: 16764
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNek5000Reader_GetDataFileName_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600417D RID: 16765 RVA: 0x00060114 File Offset: 0x0005E314
		public virtual string GetDataFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkNek5000Reader.vtkNek5000Reader_GetDataFileName_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600417E RID: 16766
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNek5000Reader_GetFileName_08(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600417F RID: 16767 RVA: 0x00060150 File Offset: 0x0005E350
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkNek5000Reader.vtkNek5000Reader_GetFileName_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004180 RID: 16768
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkNek5000Reader_GetMTime_09(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004181 RID: 16769 RVA: 0x0006018C File Offset: 0x0005E38C
		public override ulong GetMTime()
		{
			return vtkNek5000Reader.vtkNek5000Reader_GetMTime_09(base.GetCppThis());
		}

		// Token: 0x06004182 RID: 16770
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNek5000Reader_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004183 RID: 16771 RVA: 0x000601AC File Offset: 0x0005E3AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNek5000Reader.vtkNek5000Reader_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06004184 RID: 16772
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNek5000Reader_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004185 RID: 16773 RVA: 0x000601CC File Offset: 0x0005E3CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNek5000Reader.vtkNek5000Reader_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06004186 RID: 16774
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNek5000Reader_GetNumberOfPointArrays_12(HandleRef pThis);

		/// <summary>
		/// Get the number of point arrays available in the input.
		/// </summary>
		// Token: 0x06004187 RID: 16775 RVA: 0x000601E8 File Offset: 0x0005E3E8
		public int GetNumberOfPointArrays()
		{
			return vtkNek5000Reader.vtkNek5000Reader_GetNumberOfPointArrays_12(base.GetCppThis());
		}

		// Token: 0x06004188 RID: 16776
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNek5000Reader_GetNumberOfTimeSteps_13(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004189 RID: 16777 RVA: 0x00060208 File Offset: 0x0005E408
		public virtual int GetNumberOfTimeSteps()
		{
			return vtkNek5000Reader.vtkNek5000Reader_GetNumberOfTimeSteps_13(base.GetCppThis());
		}

		// Token: 0x0600418A RID: 16778
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNek5000Reader_GetPointArrayName_14(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the  point array with the given index in
		/// the input.
		/// </summary>
		// Token: 0x0600418B RID: 16779 RVA: 0x00060228 File Offset: 0x0005E428
		public string GetPointArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkNek5000Reader.vtkNek5000Reader_GetPointArrayName_14(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600418C RID: 16780
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkNek5000Reader_GetPointArrayStatus_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set whether the point array with the given name or index is to be read.
		/// </summary>
		// Token: 0x0600418D RID: 16781 RVA: 0x00060264 File Offset: 0x0005E464
		public bool GetPointArrayStatus(string name)
		{
			return vtkNek5000Reader.vtkNek5000Reader_GetPointArrayStatus_15(base.GetCppThis(), name) != 0;
		}

		// Token: 0x0600418E RID: 16782
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkNek5000Reader_GetPointArrayStatus_16(HandleRef pThis, int index);

		/// <summary>
		/// Get/Set whether the point array with the given name or index is to be read.
		/// </summary>
		// Token: 0x0600418F RID: 16783 RVA: 0x0006028C File Offset: 0x0005E48C
		public bool GetPointArrayStatus(int index)
		{
			return vtkNek5000Reader.vtkNek5000Reader_GetPointArrayStatus_16(base.GetCppThis(), index) != 0;
		}

		// Token: 0x06004190 RID: 16784
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNek5000Reader_GetSpectralElementIds_17(HandleRef pThis);

		/// <summary>
		/// used for ParaView to decide if showing the spectral elements ids as cell-data
		/// </summary>
		// Token: 0x06004191 RID: 16785 RVA: 0x000602B4 File Offset: 0x0005E4B4
		public virtual int GetSpectralElementIds()
		{
			return vtkNek5000Reader.vtkNek5000Reader_GetSpectralElementIds_17(base.GetCppThis());
		}

		// Token: 0x06004192 RID: 16786
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNek5000Reader_GetTimeStepRange_18(HandleRef pThis);

		/// <summary>
		/// Returns the available range of valid integer time steps.
		/// </summary>
		// Token: 0x06004193 RID: 16787 RVA: 0x000602D4 File Offset: 0x0005E4D4
		public virtual int[] GetTimeStepRange()
		{
			IntPtr intPtr = vtkNek5000Reader.vtkNek5000Reader_GetTimeStepRange_18(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06004194 RID: 16788
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNek5000Reader_GetTimeStepRange_19(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Returns the available range of valid integer time steps.
		/// </summary>
		// Token: 0x06004195 RID: 16789 RVA: 0x0006031C File Offset: 0x0005E51C
		public virtual void GetTimeStepRange(ref int _arg1, ref int _arg2)
		{
			vtkNek5000Reader.vtkNek5000Reader_GetTimeStepRange_19(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06004196 RID: 16790
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNek5000Reader_GetTimeStepRange_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Returns the available range of valid integer time steps.
		/// </summary>
		// Token: 0x06004197 RID: 16791 RVA: 0x0006032D File Offset: 0x0005E52D
		public virtual void GetTimeStepRange(IntPtr _arg)
		{
			vtkNek5000Reader.vtkNek5000Reader_GetTimeStepRange_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06004198 RID: 16792
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkNek5000Reader_GetVariableNamesFromData_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string varTags);

		/// <summary>
		/// Get the names of variables stored in the data
		/// </summary>
		// Token: 0x06004199 RID: 16793 RVA: 0x00060340 File Offset: 0x0005E540
		public ulong GetVariableNamesFromData(string varTags)
		{
			return vtkNek5000Reader.vtkNek5000Reader_GetVariableNamesFromData_21(base.GetCppThis(), varTags);
		}

		// Token: 0x0600419A RID: 16794
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNek5000Reader_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600419B RID: 16795 RVA: 0x00060360 File Offset: 0x0005E560
		public override int IsA(string type)
		{
			return vtkNek5000Reader.vtkNek5000Reader_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0600419C RID: 16796
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNek5000Reader_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600419D RID: 16797 RVA: 0x00060380 File Offset: 0x0005E580
		public new static int IsTypeOf(string type)
		{
			return vtkNek5000Reader.vtkNek5000Reader_IsTypeOf_23(type);
		}

		// Token: 0x0600419E RID: 16798
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNek5000Reader_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600419F RID: 16799 RVA: 0x0006039C File Offset: 0x0005E59C
		public new vtkNek5000Reader NewInstance()
		{
			vtkNek5000Reader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNek5000Reader.vtkNek5000Reader_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNek5000Reader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060041A0 RID: 16800
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNek5000Reader_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060041A1 RID: 16801 RVA: 0x000603F8 File Offset: 0x0005E5F8
		public new static vtkNek5000Reader SafeDownCast(vtkObjectBase o)
		{
			vtkNek5000Reader vtkNek5000Reader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNek5000Reader.vtkNek5000Reader_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNek5000Reader = (vtkNek5000Reader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNek5000Reader.Register(null);
				}
			}
			return vtkNek5000Reader;
		}

		// Token: 0x060041A2 RID: 16802
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNek5000Reader_SetCleanGrid_27(HandleRef pThis, int _arg);

		/// <summary>
		/// used for ParaView to decide if cleaning the grid to merge points
		/// </summary>
		// Token: 0x060041A3 RID: 16803 RVA: 0x00060477 File Offset: 0x0005E677
		public virtual void SetCleanGrid(int _arg)
		{
			vtkNek5000Reader.vtkNek5000Reader_SetCleanGrid_27(base.GetCppThis(), _arg);
		}

		// Token: 0x060041A4 RID: 16804
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNek5000Reader_SetDataFileName_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060041A5 RID: 16805 RVA: 0x00060487 File Offset: 0x0005E687
		public virtual void SetDataFileName(string _arg)
		{
			vtkNek5000Reader.vtkNek5000Reader_SetDataFileName_28(base.GetCppThis(), _arg);
		}

		// Token: 0x060041A6 RID: 16806
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNek5000Reader_SetFileName_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060041A7 RID: 16807 RVA: 0x00060497 File Offset: 0x0005E697
		public virtual void SetFileName(string _arg)
		{
			vtkNek5000Reader.vtkNek5000Reader_SetFileName_29(base.GetCppThis(), _arg);
		}

		// Token: 0x060041A8 RID: 16808
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNek5000Reader_SetPointArrayStatus_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Get/Set whether the point array with the given name or index is to be read.
		/// </summary>
		// Token: 0x060041A9 RID: 16809 RVA: 0x000604A7 File Offset: 0x0005E6A7
		public void SetPointArrayStatus(string name, int status)
		{
			vtkNek5000Reader.vtkNek5000Reader_SetPointArrayStatus_30(base.GetCppThis(), name, status);
		}

		// Token: 0x060041AA RID: 16810
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNek5000Reader_SetSpectralElementIds_31(HandleRef pThis, int _arg);

		/// <summary>
		/// used for ParaView to decide if showing the spectral elements ids as cell-data
		/// </summary>
		// Token: 0x060041AB RID: 16811 RVA: 0x000604B8 File Offset: 0x0005E6B8
		public virtual void SetSpectralElementIds(int _arg)
		{
			vtkNek5000Reader.vtkNek5000Reader_SetSpectralElementIds_31(base.GetCppThis(), _arg);
		}

		// Token: 0x060041AC RID: 16812
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNek5000Reader_SetTimeStepRange_32(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Returns the available range of valid integer time steps.
		/// </summary>
		// Token: 0x060041AD RID: 16813 RVA: 0x000604C8 File Offset: 0x0005E6C8
		public virtual void SetTimeStepRange(int _arg1, int _arg2)
		{
			vtkNek5000Reader.vtkNek5000Reader_SetTimeStepRange_32(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x060041AE RID: 16814
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNek5000Reader_SetTimeStepRange_33(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Returns the available range of valid integer time steps.
		/// </summary>
		// Token: 0x060041AF RID: 16815 RVA: 0x000604D9 File Offset: 0x0005E6D9
		public void SetTimeStepRange(IntPtr _arg)
		{
			vtkNek5000Reader.vtkNek5000Reader_SetTimeStepRange_33(base.GetCppThis(), _arg);
		}

		// Token: 0x060041B0 RID: 16816
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNek5000Reader_SpectralElementIdsOff_34(HandleRef pThis);

		/// <summary>
		/// used for ParaView to decide if showing the spectral elements ids as cell-data
		/// </summary>
		// Token: 0x060041B1 RID: 16817 RVA: 0x000604E9 File Offset: 0x0005E6E9
		public virtual void SpectralElementIdsOff()
		{
			vtkNek5000Reader.vtkNek5000Reader_SpectralElementIdsOff_34(base.GetCppThis());
		}

		// Token: 0x060041B2 RID: 16818
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNek5000Reader_SpectralElementIdsOn_35(HandleRef pThis);

		/// <summary>
		/// used for ParaView to decide if showing the spectral elements ids as cell-data
		/// </summary>
		// Token: 0x060041B3 RID: 16819 RVA: 0x000604F8 File Offset: 0x0005E6F8
		public virtual void SpectralElementIdsOn()
		{
			vtkNek5000Reader.vtkNek5000Reader_SpectralElementIdsOn_35(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006F3 RID: 1779
		public new const string MRFullTypeName = "Kitware.VTK.vtkNek5000Reader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006F4 RID: 1780
		public new static readonly string MRClassNameKey = "class vtkNek5000Reader";
	}
}
