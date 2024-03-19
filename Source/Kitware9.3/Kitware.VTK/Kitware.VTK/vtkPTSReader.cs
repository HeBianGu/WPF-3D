using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPTSReader
	/// </summary>
	/// <remarks>
	///    Read ASCII PTS Files.
	///
	/// vtkPTSReader reads either a text file of
	///  points. The first line is the number of points. Point information is
	///  either x y z intensity or x y z intensity r g b
	/// </remarks>
	// Token: 0x02000211 RID: 529
	public class vtkPTSReader : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060064B2 RID: 25778 RVA: 0x00090E7B File Offset: 0x0008F07B
		static vtkPTSReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPTSReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPTSReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060064B3 RID: 25779 RVA: 0x00090EA3 File Offset: 0x0008F0A3
		public vtkPTSReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060064B4 RID: 25780
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPTSReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060064B5 RID: 25781 RVA: 0x00090EB4 File Offset: 0x0008F0B4
		public new static vtkPTSReader New()
		{
			vtkPTSReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPTSReader.vtkPTSReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPTSReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060064B6 RID: 25782 RVA: 0x00090F08 File Offset: 0x0008F108
		public vtkPTSReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPTSReader.vtkPTSReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060064B7 RID: 25783 RVA: 0x00090F4C File Offset: 0x0008F14C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060064B8 RID: 25784
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_CreateCellsOff_01(HandleRef pThis);

		/// <summary>
		/// Boolean value indicates whether or not to create cells
		/// for this dataset. Otherwise only points and scalars
		/// are created. Defaults to true.
		/// </summary>
		// Token: 0x060064B9 RID: 25785 RVA: 0x00090F57 File Offset: 0x0008F157
		public virtual void CreateCellsOff()
		{
			vtkPTSReader.vtkPTSReader_CreateCellsOff_01(base.GetCppThis());
		}

		// Token: 0x060064BA RID: 25786
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_CreateCellsOn_02(HandleRef pThis);

		/// <summary>
		/// Boolean value indicates whether or not to create cells
		/// for this dataset. Otherwise only points and scalars
		/// are created. Defaults to true.
		/// </summary>
		// Token: 0x060064BB RID: 25787 RVA: 0x00090F66 File Offset: 0x0008F166
		public virtual void CreateCellsOn()
		{
			vtkPTSReader.vtkPTSReader_CreateCellsOn_02(base.GetCppThis());
		}

		// Token: 0x060064BC RID: 25788
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPTSReader_GetCreateCells_03(HandleRef pThis);

		/// <summary>
		/// Boolean value indicates whether or not to create cells
		/// for this dataset. Otherwise only points and scalars
		/// are created. Defaults to true.
		/// </summary>
		// Token: 0x060064BD RID: 25789 RVA: 0x00090F78 File Offset: 0x0008F178
		public virtual bool GetCreateCells()
		{
			return vtkPTSReader.vtkPTSReader_GetCreateCells_03(base.GetCppThis()) != 0;
		}

		// Token: 0x060064BE RID: 25790
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPTSReader_GetFileName_04(HandleRef pThis);

		/// <summary>
		/// Specify file name.
		/// </summary>
		// Token: 0x060064BF RID: 25791 RVA: 0x00090FA0 File Offset: 0x0008F1A0
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkPTSReader.vtkPTSReader_GetFileName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060064C0 RID: 25792
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPTSReader_GetIncludeColorAndLuminance_05(HandleRef pThis);

		/// <summary>
		/// Boolean value indicates when color values are present
		/// if luminance should be read in as well
		/// Defaults to true.
		/// </summary>
		// Token: 0x060064C1 RID: 25793 RVA: 0x00090FDC File Offset: 0x0008F1DC
		public virtual bool GetIncludeColorAndLuminance()
		{
			return vtkPTSReader.vtkPTSReader_GetIncludeColorAndLuminance_05(base.GetCppThis()) != 0;
		}

		// Token: 0x060064C2 RID: 25794
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPTSReader_GetLimitReadToBounds_06(HandleRef pThis);

		/// <summary>
		/// Boolean value indicates whether or not to limit points read to a specified
		/// (ReadBounds) region.
		/// </summary>
		// Token: 0x060064C3 RID: 25795 RVA: 0x00091004 File Offset: 0x0008F204
		public virtual bool GetLimitReadToBounds()
		{
			return vtkPTSReader.vtkPTSReader_GetLimitReadToBounds_06(base.GetCppThis()) != 0;
		}

		// Token: 0x060064C4 RID: 25796
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPTSReader_GetLimitToMaxNumberOfPoints_07(HandleRef pThis);

		/// <summary>
		/// Boolean value indicates whether or not to limit number of points read
		/// based on MaxNumbeOfPoints.
		/// </summary>
		// Token: 0x060064C5 RID: 25797 RVA: 0x0009102C File Offset: 0x0008F22C
		public virtual bool GetLimitToMaxNumberOfPoints()
		{
			return vtkPTSReader.vtkPTSReader_GetLimitToMaxNumberOfPoints_07(base.GetCppThis()) != 0;
		}

		// Token: 0x060064C6 RID: 25798
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPTSReader_GetMaxNumberOfPoints_08(HandleRef pThis);

		/// <summary>
		/// The maximum number of points to load if LimitToMaxNumberOfPoints is on/true.
		/// Sets a temporary onRatio.
		/// </summary>
		// Token: 0x060064C7 RID: 25799 RVA: 0x00091054 File Offset: 0x0008F254
		public virtual long GetMaxNumberOfPoints()
		{
			return vtkPTSReader.vtkPTSReader_GetMaxNumberOfPoints_08(base.GetCppThis());
		}

		// Token: 0x060064C8 RID: 25800
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPTSReader_GetMaxNumberOfPointsMaxValue_09(HandleRef pThis);

		/// <summary>
		/// The maximum number of points to load if LimitToMaxNumberOfPoints is on/true.
		/// Sets a temporary onRatio.
		/// </summary>
		// Token: 0x060064C9 RID: 25801 RVA: 0x00091074 File Offset: 0x0008F274
		public virtual long GetMaxNumberOfPointsMaxValue()
		{
			return vtkPTSReader.vtkPTSReader_GetMaxNumberOfPointsMaxValue_09(base.GetCppThis());
		}

		// Token: 0x060064CA RID: 25802
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPTSReader_GetMaxNumberOfPointsMinValue_10(HandleRef pThis);

		/// <summary>
		/// The maximum number of points to load if LimitToMaxNumberOfPoints is on/true.
		/// Sets a temporary onRatio.
		/// </summary>
		// Token: 0x060064CB RID: 25803 RVA: 0x00091094 File Offset: 0x0008F294
		public virtual long GetMaxNumberOfPointsMinValue()
		{
			return vtkPTSReader.vtkPTSReader_GetMaxNumberOfPointsMinValue_10(base.GetCppThis());
		}

		// Token: 0x060064CC RID: 25804
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPTSReader_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060064CD RID: 25805 RVA: 0x000910B4 File Offset: 0x0008F2B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPTSReader.vtkPTSReader_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x060064CE RID: 25806
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPTSReader_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060064CF RID: 25807 RVA: 0x000910D4 File Offset: 0x0008F2D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPTSReader.vtkPTSReader_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x060064D0 RID: 25808
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPTSReader_GetOutputDataTypeIsDouble_13(HandleRef pThis);

		/// <summary>
		/// The output type defaults to float, but can instead be double.
		/// </summary>
		// Token: 0x060064D1 RID: 25809 RVA: 0x000910F0 File Offset: 0x0008F2F0
		public virtual bool GetOutputDataTypeIsDouble()
		{
			return vtkPTSReader.vtkPTSReader_GetOutputDataTypeIsDouble_13(base.GetCppThis()) != 0;
		}

		// Token: 0x060064D2 RID: 25810
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPTSReader_GetReadBounds_14(HandleRef pThis);

		/// <summary>
		/// Bounds to use if LimitReadToBounds is On
		/// </summary>
		// Token: 0x060064D3 RID: 25811 RVA: 0x00091118 File Offset: 0x0008F318
		public virtual double[] GetReadBounds()
		{
			IntPtr intPtr = vtkPTSReader.vtkPTSReader_GetReadBounds_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060064D4 RID: 25812
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_GetReadBounds_15(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		/// <summary>
		/// Bounds to use if LimitReadToBounds is On
		/// </summary>
		// Token: 0x060064D5 RID: 25813 RVA: 0x00091160 File Offset: 0x0008F360
		public virtual void GetReadBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkPTSReader.vtkPTSReader_GetReadBounds_15(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x060064D6 RID: 25814
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_GetReadBounds_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Bounds to use if LimitReadToBounds is On
		/// </summary>
		// Token: 0x060064D7 RID: 25815 RVA: 0x00091178 File Offset: 0x0008F378
		public virtual void GetReadBounds(IntPtr _arg)
		{
			vtkPTSReader.vtkPTSReader_GetReadBounds_16(base.GetCppThis(), _arg);
		}

		// Token: 0x060064D8 RID: 25816
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_IncludeColorAndLuminanceOff_17(HandleRef pThis);

		/// <summary>
		/// Boolean value indicates when color values are present
		/// if luminance should be read in as well
		/// Defaults to true.
		/// </summary>
		// Token: 0x060064D9 RID: 25817 RVA: 0x00091188 File Offset: 0x0008F388
		public virtual void IncludeColorAndLuminanceOff()
		{
			vtkPTSReader.vtkPTSReader_IncludeColorAndLuminanceOff_17(base.GetCppThis());
		}

		// Token: 0x060064DA RID: 25818
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_IncludeColorAndLuminanceOn_18(HandleRef pThis);

		/// <summary>
		/// Boolean value indicates when color values are present
		/// if luminance should be read in as well
		/// Defaults to true.
		/// </summary>
		// Token: 0x060064DB RID: 25819 RVA: 0x00091197 File Offset: 0x0008F397
		public virtual void IncludeColorAndLuminanceOn()
		{
			vtkPTSReader.vtkPTSReader_IncludeColorAndLuminanceOn_18(base.GetCppThis());
		}

		// Token: 0x060064DC RID: 25820
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPTSReader_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060064DD RID: 25821 RVA: 0x000911A8 File Offset: 0x0008F3A8
		public override int IsA(string type)
		{
			return vtkPTSReader.vtkPTSReader_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x060064DE RID: 25822
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPTSReader_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060064DF RID: 25823 RVA: 0x000911C8 File Offset: 0x0008F3C8
		public new static int IsTypeOf(string type)
		{
			return vtkPTSReader.vtkPTSReader_IsTypeOf_20(type);
		}

		// Token: 0x060064E0 RID: 25824
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_LimitReadToBoundsOff_21(HandleRef pThis);

		/// <summary>
		/// Boolean value indicates whether or not to limit points read to a specified
		/// (ReadBounds) region.
		/// </summary>
		// Token: 0x060064E1 RID: 25825 RVA: 0x000911E2 File Offset: 0x0008F3E2
		public virtual void LimitReadToBoundsOff()
		{
			vtkPTSReader.vtkPTSReader_LimitReadToBoundsOff_21(base.GetCppThis());
		}

		// Token: 0x060064E2 RID: 25826
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_LimitReadToBoundsOn_22(HandleRef pThis);

		/// <summary>
		/// Boolean value indicates whether or not to limit points read to a specified
		/// (ReadBounds) region.
		/// </summary>
		// Token: 0x060064E3 RID: 25827 RVA: 0x000911F1 File Offset: 0x0008F3F1
		public virtual void LimitReadToBoundsOn()
		{
			vtkPTSReader.vtkPTSReader_LimitReadToBoundsOn_22(base.GetCppThis());
		}

		// Token: 0x060064E4 RID: 25828
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_LimitToMaxNumberOfPointsOff_23(HandleRef pThis);

		/// <summary>
		/// Boolean value indicates whether or not to limit number of points read
		/// based on MaxNumbeOfPoints.
		/// </summary>
		// Token: 0x060064E5 RID: 25829 RVA: 0x00091200 File Offset: 0x0008F400
		public virtual void LimitToMaxNumberOfPointsOff()
		{
			vtkPTSReader.vtkPTSReader_LimitToMaxNumberOfPointsOff_23(base.GetCppThis());
		}

		// Token: 0x060064E6 RID: 25830
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_LimitToMaxNumberOfPointsOn_24(HandleRef pThis);

		/// <summary>
		/// Boolean value indicates whether or not to limit number of points read
		/// based on MaxNumbeOfPoints.
		/// </summary>
		// Token: 0x060064E7 RID: 25831 RVA: 0x0009120F File Offset: 0x0008F40F
		public virtual void LimitToMaxNumberOfPointsOn()
		{
			vtkPTSReader.vtkPTSReader_LimitToMaxNumberOfPointsOn_24(base.GetCppThis());
		}

		// Token: 0x060064E8 RID: 25832
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPTSReader_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060064E9 RID: 25833 RVA: 0x00091220 File Offset: 0x0008F420
		public new vtkPTSReader NewInstance()
		{
			vtkPTSReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPTSReader.vtkPTSReader_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPTSReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060064EA RID: 25834
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_OutputDataTypeIsDoubleOff_27(HandleRef pThis);

		/// <summary>
		/// The output type defaults to float, but can instead be double.
		/// </summary>
		// Token: 0x060064EB RID: 25835 RVA: 0x0009127A File Offset: 0x0008F47A
		public virtual void OutputDataTypeIsDoubleOff()
		{
			vtkPTSReader.vtkPTSReader_OutputDataTypeIsDoubleOff_27(base.GetCppThis());
		}

		// Token: 0x060064EC RID: 25836
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_OutputDataTypeIsDoubleOn_28(HandleRef pThis);

		/// <summary>
		/// The output type defaults to float, but can instead be double.
		/// </summary>
		// Token: 0x060064ED RID: 25837 RVA: 0x00091289 File Offset: 0x0008F489
		public virtual void OutputDataTypeIsDoubleOn()
		{
			vtkPTSReader.vtkPTSReader_OutputDataTypeIsDoubleOn_28(base.GetCppThis());
		}

		// Token: 0x060064EE RID: 25838
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPTSReader_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060064EF RID: 25839 RVA: 0x00091298 File Offset: 0x0008F498
		public new static vtkPTSReader SafeDownCast(vtkObjectBase o)
		{
			vtkPTSReader vtkPTSReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPTSReader.vtkPTSReader_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPTSReader = (vtkPTSReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPTSReader.Register(null);
				}
			}
			return vtkPTSReader;
		}

		// Token: 0x060064F0 RID: 25840
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_SetCreateCells_30(HandleRef pThis, byte _arg);

		/// <summary>
		/// Boolean value indicates whether or not to create cells
		/// for this dataset. Otherwise only points and scalars
		/// are created. Defaults to true.
		/// </summary>
		// Token: 0x060064F1 RID: 25841 RVA: 0x00091317 File Offset: 0x0008F517
		public virtual void SetCreateCells(bool _arg)
		{
			vtkPTSReader.vtkPTSReader_SetCreateCells_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060064F2 RID: 25842
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_SetFileName_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		/// Specify file name.
		/// </summary>
		// Token: 0x060064F3 RID: 25843 RVA: 0x0009132F File Offset: 0x0008F52F
		public void SetFileName(string filename)
		{
			vtkPTSReader.vtkPTSReader_SetFileName_31(base.GetCppThis(), filename);
		}

		// Token: 0x060064F4 RID: 25844
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_SetIncludeColorAndLuminance_32(HandleRef pThis, byte _arg);

		/// <summary>
		/// Boolean value indicates when color values are present
		/// if luminance should be read in as well
		/// Defaults to true.
		/// </summary>
		// Token: 0x060064F5 RID: 25845 RVA: 0x0009133F File Offset: 0x0008F53F
		public virtual void SetIncludeColorAndLuminance(bool _arg)
		{
			vtkPTSReader.vtkPTSReader_SetIncludeColorAndLuminance_32(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060064F6 RID: 25846
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_SetLimitReadToBounds_33(HandleRef pThis, byte _arg);

		/// <summary>
		/// Boolean value indicates whether or not to limit points read to a specified
		/// (ReadBounds) region.
		/// </summary>
		// Token: 0x060064F7 RID: 25847 RVA: 0x00091357 File Offset: 0x0008F557
		public virtual void SetLimitReadToBounds(bool _arg)
		{
			vtkPTSReader.vtkPTSReader_SetLimitReadToBounds_33(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060064F8 RID: 25848
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_SetLimitToMaxNumberOfPoints_34(HandleRef pThis, byte _arg);

		/// <summary>
		/// Boolean value indicates whether or not to limit number of points read
		/// based on MaxNumbeOfPoints.
		/// </summary>
		// Token: 0x060064F9 RID: 25849 RVA: 0x0009136F File Offset: 0x0008F56F
		public virtual void SetLimitToMaxNumberOfPoints(bool _arg)
		{
			vtkPTSReader.vtkPTSReader_SetLimitToMaxNumberOfPoints_34(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060064FA RID: 25850
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_SetMaxNumberOfPoints_35(HandleRef pThis, long _arg);

		/// <summary>
		/// The maximum number of points to load if LimitToMaxNumberOfPoints is on/true.
		/// Sets a temporary onRatio.
		/// </summary>
		// Token: 0x060064FB RID: 25851 RVA: 0x00091387 File Offset: 0x0008F587
		public virtual void SetMaxNumberOfPoints(long _arg)
		{
			vtkPTSReader.vtkPTSReader_SetMaxNumberOfPoints_35(base.GetCppThis(), _arg);
		}

		// Token: 0x060064FC RID: 25852
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_SetOutputDataTypeIsDouble_36(HandleRef pThis, byte _arg);

		/// <summary>
		/// The output type defaults to float, but can instead be double.
		/// </summary>
		// Token: 0x060064FD RID: 25853 RVA: 0x00091397 File Offset: 0x0008F597
		public virtual void SetOutputDataTypeIsDouble(bool _arg)
		{
			vtkPTSReader.vtkPTSReader_SetOutputDataTypeIsDouble_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060064FE RID: 25854
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_SetReadBounds_37(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Bounds to use if LimitReadToBounds is On
		/// </summary>
		// Token: 0x060064FF RID: 25855 RVA: 0x000913AF File Offset: 0x0008F5AF
		public virtual void SetReadBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkPTSReader.vtkPTSReader_SetReadBounds_37(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06006500 RID: 25856
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPTSReader_SetReadBounds_38(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Bounds to use if LimitReadToBounds is On
		/// </summary>
		// Token: 0x06006501 RID: 25857 RVA: 0x000913C7 File Offset: 0x0008F5C7
		public virtual void SetReadBounds(IntPtr _arg)
		{
			vtkPTSReader.vtkPTSReader_SetReadBounds_38(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000905 RID: 2309
		public new const string MRFullTypeName = "Kitware.VTK.vtkPTSReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000906 RID: 2310
		public new static readonly string MRClassNameKey = "class vtkPTSReader";
	}
}
