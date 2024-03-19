using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkSEPReader
	/// </summary>
	/// <remarks>
	///  Stanford Exploration Project files reader.
	///
	/// This reader takes a .H file that points to a .H@ file and contains
	/// all the information to interpret the raw data in the  .H@ file.
	/// </remarks>
	// Token: 0x020007A1 RID: 1953
	public class vtkSEPReader : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060140A2 RID: 82082 RVA: 0x001C50D3 File Offset: 0x001C32D3
		static vtkSEPReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSEPReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSEPReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060140A3 RID: 82083 RVA: 0x001C50FB File Offset: 0x001C32FB
		public vtkSEPReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060140A4 RID: 82084
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSEPReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060140A5 RID: 82085 RVA: 0x001C510C File Offset: 0x001C330C
		public new static vtkSEPReader New()
		{
			vtkSEPReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSEPReader.vtkSEPReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSEPReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060140A6 RID: 82086 RVA: 0x001C5160 File Offset: 0x001C3360
		public vtkSEPReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSEPReader.vtkSEPReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060140A7 RID: 82087 RVA: 0x001C51A4 File Offset: 0x001C33A4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060140A8 RID: 82088
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSEPReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Specify the name for each spatial / fixed dimension.
		/// ZDimension is only used for 3D output.
		/// FixedDimension2 is only used for 2D output.
		/// </summary>
		// Token: 0x060140A9 RID: 82089 RVA: 0x001C51B0 File Offset: 0x001C33B0
		public bool CanReadFile(string arg0)
		{
			return vtkSEPReader.vtkSEPReader_CanReadFile_01(base.GetCppThis(), arg0) != 0;
		}

		// Token: 0x060140AA RID: 82090
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSEPReader_GetAllDimensions_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Array containing the name of all dimensions.
		/// Contains ESize elements.
		/// </summary>
		// Token: 0x060140AB RID: 82091 RVA: 0x001C51D8 File Offset: 0x001C33D8
		public virtual vtkStringArray GetAllDimensions()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSEPReader.vtkSEPReader_GetAllDimensions_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x060140AC RID: 82092
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSEPReader_GetAllRanges_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Array containing the name and the size of all dimensions.
		/// The two first entries are the header. Contains 2*ESize elements.
		/// </summary>
		// Token: 0x060140AD RID: 82093 RVA: 0x001C5248 File Offset: 0x001C3448
		public virtual vtkStringArray GetAllRanges()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSEPReader.vtkSEPReader_GetAllRanges_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x060140AE RID: 82094
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSEPReader_GetDataOrigin_04(HandleRef pThis);

		/// <summary>
		/// @brief Specify extent translator split mode.
		/// Default: vtkExtentTranslator::BLOCK_MODE
		/// </summary>
		// Token: 0x060140AF RID: 82095 RVA: 0x001C52B8 File Offset: 0x001C34B8
		public virtual IntPtr GetDataOrigin()
		{
			return vtkSEPReader.vtkSEPReader_GetDataOrigin_04(base.GetCppThis());
		}

		// Token: 0x060140B0 RID: 82096
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSEPReader_GetDataSpacing_05(HandleRef pThis);

		/// <summary>
		/// @brief Specify extent translator split mode.
		/// Default: vtkExtentTranslator::BLOCK_MODE
		/// </summary>
		// Token: 0x060140B1 RID: 82097 RVA: 0x001C52D8 File Offset: 0x001C34D8
		public virtual IntPtr GetDataSpacing()
		{
			return vtkSEPReader.vtkSEPReader_GetDataSpacing_05(base.GetCppThis());
		}

		// Token: 0x060140B2 RID: 82098
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSEPReader_GetExtentSplitMode_06(HandleRef pThis);

		/// <summary>
		/// @brief Specify extent translator split mode.
		/// Default: vtkExtentTranslator::BLOCK_MODE
		/// </summary>
		// Token: 0x060140B3 RID: 82099 RVA: 0x001C52F8 File Offset: 0x001C34F8
		public virtual int GetExtentSplitMode()
		{
			return vtkSEPReader.vtkSEPReader_GetExtentSplitMode_06(base.GetCppThis());
		}

		// Token: 0x060140B4 RID: 82100
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSEPReader_GetFileName_07(HandleRef pThis);

		/// <summary>
		/// @brief Specify file name for the SEP Header file.
		/// </summary>
		// Token: 0x060140B5 RID: 82101 RVA: 0x001C5318 File Offset: 0x001C3518
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSEPReader.vtkSEPReader_GetFileName_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060140B6 RID: 82102
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSEPReader_GetFixedDimRange_08(HandleRef pThis);

		/// <summary>
		/// Specify the name for each spatial / fixed dimension.
		/// ZDimension is only used for 3D output.
		/// FixedDimension2 is only used for 2D output.
		/// </summary>
		// Token: 0x060140B7 RID: 82103 RVA: 0x001C5354 File Offset: 0x001C3554
		public virtual int[] GetFixedDimRange()
		{
			IntPtr intPtr = vtkSEPReader.vtkSEPReader_GetFixedDimRange_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060140B8 RID: 82104
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSEPReader_GetFixedDimRange_09(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Specify the name for each spatial / fixed dimension.
		/// ZDimension is only used for 3D output.
		/// FixedDimension2 is only used for 2D output.
		/// </summary>
		// Token: 0x060140B9 RID: 82105 RVA: 0x001C539C File Offset: 0x001C359C
		public virtual void GetFixedDimRange(ref int _arg1, ref int _arg2)
		{
			vtkSEPReader.vtkSEPReader_GetFixedDimRange_09(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x060140BA RID: 82106
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSEPReader_GetFixedDimRange_10(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the name for each spatial / fixed dimension.
		/// ZDimension is only used for 3D output.
		/// FixedDimension2 is only used for 2D output.
		/// </summary>
		// Token: 0x060140BB RID: 82107 RVA: 0x001C53AD File Offset: 0x001C35AD
		public virtual void GetFixedDimRange(IntPtr _arg)
		{
			vtkSEPReader.vtkSEPReader_GetFixedDimRange_10(base.GetCppThis(), _arg);
		}

		// Token: 0x060140BC RID: 82108
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSEPReader_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060140BD RID: 82109 RVA: 0x001C53C0 File Offset: 0x001C35C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSEPReader.vtkSEPReader_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x060140BE RID: 82110
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSEPReader_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060140BF RID: 82111 RVA: 0x001C53E0 File Offset: 0x001C35E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSEPReader.vtkSEPReader_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x060140C0 RID: 82112
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSEPReader_GetOutputGridDimension_13(HandleRef pThis);

		/// <summary>
		/// @brief When 2D mode is true, the third dimension is
		/// ignored and the output is in 2D.
		/// </summary>
		// Token: 0x060140C1 RID: 82113 RVA: 0x001C53FC File Offset: 0x001C35FC
		public virtual int GetOutputGridDimension()
		{
			return vtkSEPReader.vtkSEPReader_GetOutputGridDimension_13(base.GetCppThis());
		}

		// Token: 0x060140C2 RID: 82114
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSEPReader_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060140C3 RID: 82115 RVA: 0x001C541C File Offset: 0x001C361C
		public override int IsA(string type)
		{
			return vtkSEPReader.vtkSEPReader_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x060140C4 RID: 82116
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSEPReader_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060140C5 RID: 82117 RVA: 0x001C543C File Offset: 0x001C363C
		public new static int IsTypeOf(string type)
		{
			return vtkSEPReader.vtkSEPReader_IsTypeOf_15(type);
		}

		// Token: 0x060140C6 RID: 82118
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSEPReader_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060140C7 RID: 82119 RVA: 0x001C5458 File Offset: 0x001C3658
		public new vtkSEPReader NewInstance()
		{
			vtkSEPReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSEPReader.vtkSEPReader_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSEPReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060140C8 RID: 82120
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSEPReader_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060140C9 RID: 82121 RVA: 0x001C54B4 File Offset: 0x001C36B4
		public new static vtkSEPReader SafeDownCast(vtkObjectBase o)
		{
			vtkSEPReader vtkSEPReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSEPReader.vtkSEPReader_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSEPReader = (vtkSEPReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSEPReader.Register(null);
				}
			}
			return vtkSEPReader;
		}

		// Token: 0x060140CA RID: 82122
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSEPReader_SetExtentSplitMode_19(HandleRef pThis, int _arg);

		/// <summary>
		/// @brief Specify extent translator split mode.
		/// Default: vtkExtentTranslator::BLOCK_MODE
		/// </summary>
		// Token: 0x060140CB RID: 82123 RVA: 0x001C5533 File Offset: 0x001C3733
		public virtual void SetExtentSplitMode(int _arg)
		{
			vtkSEPReader.vtkSEPReader_SetExtentSplitMode_19(base.GetCppThis(), _arg);
		}

		// Token: 0x060140CC RID: 82124
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSEPReader_SetFileName_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// @brief Specify file name for the SEP Header file.
		/// </summary>
		// Token: 0x060140CD RID: 82125 RVA: 0x001C5543 File Offset: 0x001C3743
		public virtual void SetFileName(string arg)
		{
			vtkSEPReader.vtkSEPReader_SetFileName_20(base.GetCppThis(), arg);
		}

		// Token: 0x060140CE RID: 82126
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSEPReader_SetFixedDimension1_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Specify the name for each spatial / fixed dimension.
		/// ZDimension is only used for 3D output.
		/// FixedDimension2 is only used for 2D output.
		/// </summary>
		// Token: 0x060140CF RID: 82127 RVA: 0x001C5553 File Offset: 0x001C3753
		public virtual void SetFixedDimension1(string arg)
		{
			vtkSEPReader.vtkSEPReader_SetFixedDimension1_21(base.GetCppThis(), arg);
		}

		// Token: 0x060140D0 RID: 82128
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSEPReader_SetFixedDimension2_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Specify the name for each spatial / fixed dimension.
		/// ZDimension is only used for 3D output.
		/// FixedDimension2 is only used for 2D output.
		/// </summary>
		// Token: 0x060140D1 RID: 82129 RVA: 0x001C5563 File Offset: 0x001C3763
		public virtual void SetFixedDimension2(string arg)
		{
			vtkSEPReader.vtkSEPReader_SetFixedDimension2_22(base.GetCppThis(), arg);
		}

		// Token: 0x060140D2 RID: 82130
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSEPReader_SetFixedDimensionValue1_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the name for each spatial / fixed dimension.
		/// ZDimension is only used for 3D output.
		/// FixedDimension2 is only used for 2D output.
		/// </summary>
		// Token: 0x060140D3 RID: 82131 RVA: 0x001C5573 File Offset: 0x001C3773
		public virtual void SetFixedDimensionValue1(int _arg)
		{
			vtkSEPReader.vtkSEPReader_SetFixedDimensionValue1_23(base.GetCppThis(), _arg);
		}

		// Token: 0x060140D4 RID: 82132
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSEPReader_SetFixedDimensionValue2_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the name for each spatial / fixed dimension.
		/// ZDimension is only used for 3D output.
		/// FixedDimension2 is only used for 2D output.
		/// </summary>
		// Token: 0x060140D5 RID: 82133 RVA: 0x001C5583 File Offset: 0x001C3783
		public virtual void SetFixedDimensionValue2(int _arg)
		{
			vtkSEPReader.vtkSEPReader_SetFixedDimensionValue2_24(base.GetCppThis(), _arg);
		}

		// Token: 0x060140D6 RID: 82134
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSEPReader_SetOutputGridDimension_25(HandleRef pThis, int _arg);

		/// <summary>
		/// @brief When 2D mode is true, the third dimension is
		/// ignored and the output is in 2D.
		/// </summary>
		// Token: 0x060140D7 RID: 82135 RVA: 0x001C5593 File Offset: 0x001C3793
		public virtual void SetOutputGridDimension(int _arg)
		{
			vtkSEPReader.vtkSEPReader_SetOutputGridDimension_25(base.GetCppThis(), _arg);
		}

		// Token: 0x060140D8 RID: 82136
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSEPReader_SetXDimension_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Specify the name for each spatial / fixed dimension.
		/// ZDimension is only used for 3D output.
		/// FixedDimension2 is only used for 2D output.
		/// </summary>
		// Token: 0x060140D9 RID: 82137 RVA: 0x001C55A3 File Offset: 0x001C37A3
		public virtual void SetXDimension(string arg)
		{
			vtkSEPReader.vtkSEPReader_SetXDimension_26(base.GetCppThis(), arg);
		}

		// Token: 0x060140DA RID: 82138
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSEPReader_SetYDimension_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Specify the name for each spatial / fixed dimension.
		/// ZDimension is only used for 3D output.
		/// FixedDimension2 is only used for 2D output.
		/// </summary>
		// Token: 0x060140DB RID: 82139 RVA: 0x001C55B3 File Offset: 0x001C37B3
		public virtual void SetYDimension(string arg)
		{
			vtkSEPReader.vtkSEPReader_SetYDimension_27(base.GetCppThis(), arg);
		}

		// Token: 0x060140DC RID: 82140
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSEPReader_SetZDimension_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Specify the name for each spatial / fixed dimension.
		/// ZDimension is only used for 3D output.
		/// FixedDimension2 is only used for 2D output.
		/// </summary>
		// Token: 0x060140DD RID: 82141 RVA: 0x001C55C3 File Offset: 0x001C37C3
		public virtual void SetZDimension(string arg)
		{
			vtkSEPReader.vtkSEPReader_SetZDimension_28(base.GetCppThis(), arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001742 RID: 5954
		public new const string MRFullTypeName = "Kitware.VTK.vtkSEPReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001743 RID: 5955
		public new static readonly string MRClassNameKey = "class vtkSEPReader";
	}
}
