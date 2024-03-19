using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageReader2
	/// </summary>
	/// <remarks>
	///    Superclass of binary file readers.
	///
	/// vtkImageReader2 is a parent class for many VTK image readers.
	/// It was written to simplify the interface of vtkImageReader.
	/// It can also be used directly to read data without headers (raw).
	/// It is a good super class for streaming readers that do not require
	/// a mask or transform on the data. An example of reading a raw file is
	/// shown below:
	/// <code>
	///  vtkSmartPointer&lt;vtkImageReader2&gt; reader =
	///   vtkSmartPointer&lt;vtkImageReader2&gt;::New();
	/// reader-&gt;SetFilePrefix(argv[1]);
	/// reader-&gt;SetDataExtent(0, 63, 0, 63, 1, 93);
	/// reader-&gt;SetDataSpacing(3.2, 3.2, 1.5);
	/// reader-&gt;SetDataOrigin(0.0, 0.0, 0.0);
	/// reader-&gt;SetDataScalarTypeToUnsignedShort();
	/// reader-&gt;SetDataByteOrderToLittleEndian();
	/// reader-&gt;UpdateWholeExtent();
	/// </code>
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkJPEGReader vtkPNGReader vtkImageReader vtkGESignaReader
	/// </seealso>
	// Token: 0x0200002C RID: 44
	public class vtkImageReader2 : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060006A9 RID: 1705 RVA: 0x0001100B File Offset: 0x0000F20B
		static vtkImageReader2()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageReader2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageReader2"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060006AA RID: 1706 RVA: 0x00011033 File Offset: 0x0000F233
		public vtkImageReader2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060006AB RID: 1707
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060006AC RID: 1708 RVA: 0x00011044 File Offset: 0x0000F244
		public new static vtkImageReader2 New()
		{
			vtkImageReader2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReader2.vtkImageReader2_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReader2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060006AD RID: 1709 RVA: 0x00011098 File Offset: 0x0000F298
		public vtkImageReader2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageReader2.vtkImageReader2_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060006AE RID: 1710 RVA: 0x000110DC File Offset: 0x0000F2DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060006AF RID: 1711
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReader2_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Return non zero if the reader can read the given file name.
		/// Should be implemented by all sub-classes of vtkImageReader2.
		/// For non zero return values the following values are to be used
		/// 1 - I think I can read the file but I cannot prove it
		/// 2 - I definitely can read the file
		/// 3 - I can read the file and I have validated that I am the
		/// correct reader for this file
		/// </summary>
		// Token: 0x060006B0 RID: 1712 RVA: 0x000110E8 File Offset: 0x0000F2E8
		public virtual int CanReadFile(string arg0)
		{
			return vtkImageReader2.vtkImageReader2_CanReadFile_01(base.GetCppThis(), arg0);
		}

		// Token: 0x060006B1 RID: 1713
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_CloseFile_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the byte swapping to explicitly swap the bytes of a file.
		/// </summary>
		// Token: 0x060006B2 RID: 1714 RVA: 0x00011108 File Offset: 0x0000F308
		public void CloseFile()
		{
			vtkImageReader2.vtkImageReader2_CloseFile_02(base.GetCppThis());
		}

		// Token: 0x060006B3 RID: 1715
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_ComputeInternalFileName_03(HandleRef pThis, int slice);

		/// <summary>
		/// Set/Get the internal file name
		/// </summary>
		// Token: 0x060006B4 RID: 1716 RVA: 0x00011117 File Offset: 0x0000F317
		public virtual void ComputeInternalFileName(int slice)
		{
			vtkImageReader2.vtkImageReader2_ComputeInternalFileName_03(base.GetCppThis(), slice);
		}

		// Token: 0x060006B5 RID: 1717
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_FileLowerLeftOff_04(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the data comes from the file starting in the lower left
		/// corner or upper left corner.
		/// </summary>
		// Token: 0x060006B6 RID: 1718 RVA: 0x00011127 File Offset: 0x0000F327
		public virtual void FileLowerLeftOff()
		{
			vtkImageReader2.vtkImageReader2_FileLowerLeftOff_04(base.GetCppThis());
		}

		// Token: 0x060006B7 RID: 1719
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_FileLowerLeftOn_05(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the data comes from the file starting in the lower left
		/// corner or upper left corner.
		/// </summary>
		// Token: 0x060006B8 RID: 1720 RVA: 0x00011136 File Offset: 0x0000F336
		public virtual void FileLowerLeftOn()
		{
			vtkImageReader2.vtkImageReader2_FileLowerLeftOn_05(base.GetCppThis());
		}

		// Token: 0x060006B9 RID: 1721
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReader2_GetDataByteOrder_06(HandleRef pThis);

		/// <summary>
		/// These methods should be used instead of the SwapBytes methods.
		/// They indicate the byte ordering of the file you are trying
		/// to read in. These methods will then either swap or not swap
		/// the bytes depending on the byte ordering of the machine it is
		/// being run on. For example, reading in a BigEndian file on a
		/// BigEndian machine will result in no swapping. Trying to read
		/// the same file on a LittleEndian machine will result in swapping.
		/// As a quick note most UNIX machines are BigEndian while PC's
		/// and VAX tend to be LittleEndian. So if the file you are reading
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
		/// otherwise SetDataByteOrderToBigEndian.
		/// </summary>
		// Token: 0x060006BA RID: 1722 RVA: 0x00011148 File Offset: 0x0000F348
		public virtual int GetDataByteOrder()
		{
			return vtkImageReader2.vtkImageReader2_GetDataByteOrder_06(base.GetCppThis());
		}

		// Token: 0x060006BB RID: 1723
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2_GetDataByteOrderAsString_07(HandleRef pThis);

		/// <summary>
		/// These methods should be used instead of the SwapBytes methods.
		/// They indicate the byte ordering of the file you are trying
		/// to read in. These methods will then either swap or not swap
		/// the bytes depending on the byte ordering of the machine it is
		/// being run on. For example, reading in a BigEndian file on a
		/// BigEndian machine will result in no swapping. Trying to read
		/// the same file on a LittleEndian machine will result in swapping.
		/// As a quick note most UNIX machines are BigEndian while PC's
		/// and VAX tend to be LittleEndian. So if the file you are reading
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
		/// otherwise SetDataByteOrderToBigEndian.
		/// </summary>
		// Token: 0x060006BC RID: 1724 RVA: 0x00011168 File Offset: 0x0000F368
		public virtual string GetDataByteOrderAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageReader2.vtkImageReader2_GetDataByteOrderAsString_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060006BD RID: 1725
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2_GetDataDirection_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the direction of the data (9 elements: 3x3 matrix).
		/// </summary>
		// Token: 0x060006BE RID: 1726 RVA: 0x000111A4 File Offset: 0x0000F3A4
		public virtual double[] GetDataDirection()
		{
			IntPtr intPtr = vtkImageReader2.vtkImageReader2_GetDataDirection_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[9];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060006BF RID: 1727
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_GetDataDirection_09(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the direction of the data (9 elements: 3x3 matrix).
		/// </summary>
		// Token: 0x060006C0 RID: 1728 RVA: 0x000111ED File Offset: 0x0000F3ED
		public virtual void GetDataDirection(IntPtr data)
		{
			vtkImageReader2.vtkImageReader2_GetDataDirection_09(base.GetCppThis(), data);
		}

		// Token: 0x060006C1 RID: 1729
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2_GetDataExtent_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the extent of the data on disk.
		/// </summary>
		// Token: 0x060006C2 RID: 1730 RVA: 0x00011200 File Offset: 0x0000F400
		public virtual int[] GetDataExtent()
		{
			IntPtr intPtr = vtkImageReader2.vtkImageReader2_GetDataExtent_10(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060006C3 RID: 1731
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_GetDataExtent_11(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Get/Set the extent of the data on disk.
		/// </summary>
		// Token: 0x060006C4 RID: 1732 RVA: 0x00011248 File Offset: 0x0000F448
		public virtual void GetDataExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageReader2.vtkImageReader2_GetDataExtent_11(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x060006C5 RID: 1733
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_GetDataExtent_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the extent of the data on disk.
		/// </summary>
		// Token: 0x060006C6 RID: 1734 RVA: 0x00011260 File Offset: 0x0000F460
		public virtual void GetDataExtent(IntPtr _arg)
		{
			vtkImageReader2.vtkImageReader2_GetDataExtent_12(base.GetCppThis(), _arg);
		}

		// Token: 0x060006C7 RID: 1735
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2_GetDataIncrements_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the byte swapping to explicitly swap the bytes of a file.
		/// </summary>
		// Token: 0x060006C8 RID: 1736 RVA: 0x00011270 File Offset: 0x0000F470
		public virtual uint[] GetDataIncrements()
		{
			IntPtr intPtr = vtkImageReader2.vtkImageReader2_GetDataIncrements_13(base.GetCppThis());
			uint[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new uint[4];
				int[] array2 = new int[4];
				Marshal.Copy(intPtr, array2, 0, array.Length);
				for (int i = 0; i < 4; i++)
				{
					array[i] = (uint)array2[i];
				}
			}
			return array;
		}

		// Token: 0x060006C9 RID: 1737
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_GetDataIncrements_14(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the byte swapping to explicitly swap the bytes of a file.
		/// </summary>
		// Token: 0x060006CA RID: 1738 RVA: 0x000112DD File Offset: 0x0000F4DD
		public virtual void GetDataIncrements(IntPtr data)
		{
			vtkImageReader2.vtkImageReader2_GetDataIncrements_14(base.GetCppThis(), data);
		}

		// Token: 0x060006CB RID: 1739
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2_GetDataOrigin_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the origin of the data (location of first pixel in the file).
		/// </summary>
		// Token: 0x060006CC RID: 1740 RVA: 0x000112F0 File Offset: 0x0000F4F0
		public virtual double[] GetDataOrigin()
		{
			IntPtr intPtr = vtkImageReader2.vtkImageReader2_GetDataOrigin_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060006CD RID: 1741
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_GetDataOrigin_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the origin of the data (location of first pixel in the file).
		/// </summary>
		// Token: 0x060006CE RID: 1742 RVA: 0x00011338 File Offset: 0x0000F538
		public virtual void GetDataOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageReader2.vtkImageReader2_GetDataOrigin_16(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060006CF RID: 1743
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_GetDataOrigin_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the origin of the data (location of first pixel in the file).
		/// </summary>
		// Token: 0x060006D0 RID: 1744 RVA: 0x0001134A File Offset: 0x0000F54A
		public virtual void GetDataOrigin(IntPtr _arg)
		{
			vtkImageReader2.vtkImageReader2_GetDataOrigin_17(base.GetCppThis(), _arg);
		}

		// Token: 0x060006D1 RID: 1745
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReader2_GetDataScalarType_18(HandleRef pThis);

		/// <summary>
		/// Get the file format.  Pixels are this type in the file.
		/// </summary>
		// Token: 0x060006D2 RID: 1746 RVA: 0x0001135C File Offset: 0x0000F55C
		public virtual int GetDataScalarType()
		{
			return vtkImageReader2.vtkImageReader2_GetDataScalarType_18(base.GetCppThis());
		}

		// Token: 0x060006D3 RID: 1747
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2_GetDataSpacing_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the spacing of the data in the file.
		/// </summary>
		// Token: 0x060006D4 RID: 1748 RVA: 0x0001137C File Offset: 0x0000F57C
		public virtual double[] GetDataSpacing()
		{
			IntPtr intPtr = vtkImageReader2.vtkImageReader2_GetDataSpacing_19(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060006D5 RID: 1749
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_GetDataSpacing_20(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the spacing of the data in the file.
		/// </summary>
		// Token: 0x060006D6 RID: 1750 RVA: 0x000113C4 File Offset: 0x0000F5C4
		public virtual void GetDataSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageReader2.vtkImageReader2_GetDataSpacing_20(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060006D7 RID: 1751
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_GetDataSpacing_21(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the spacing of the data in the file.
		/// </summary>
		// Token: 0x060006D8 RID: 1752 RVA: 0x000113D6 File Offset: 0x0000F5D6
		public virtual void GetDataSpacing(IntPtr _arg)
		{
			vtkImageReader2.vtkImageReader2_GetDataSpacing_21(base.GetCppThis(), _arg);
		}

		// Token: 0x060006D9 RID: 1753
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2_GetDescriptiveName_22(HandleRef pThis);

		/// <summary>
		/// Return a descriptive name for the file format that might be useful in a GUI.
		/// </summary>
		// Token: 0x060006DA RID: 1754 RVA: 0x000113E8 File Offset: 0x0000F5E8
		public virtual string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageReader2.vtkImageReader2_GetDescriptiveName_22(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060006DB RID: 1755
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReader2_GetFileDimensionality_23(HandleRef pThis);

		/// <summary>
		/// The number of dimensions stored in a file. This defaults to two.
		/// </summary>
		// Token: 0x060006DC RID: 1756 RVA: 0x00011424 File Offset: 0x0000F624
		public int GetFileDimensionality()
		{
			return vtkImageReader2.vtkImageReader2_GetFileDimensionality_23(base.GetCppThis());
		}

		// Token: 0x060006DD RID: 1757
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2_GetFileExtensions_24(HandleRef pThis);

		/// <summary>
		/// Get the file extensions for this format.
		/// Returns a string with a space separated list of extensions in
		/// the format .extension
		/// </summary>
		// Token: 0x060006DE RID: 1758 RVA: 0x00011444 File Offset: 0x0000F644
		public virtual string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageReader2.vtkImageReader2_GetFileExtensions_24(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060006DF RID: 1759
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReader2_GetFileLowerLeft_25(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the data comes from the file starting in the lower left
		/// corner or upper left corner.
		/// </summary>
		// Token: 0x060006E0 RID: 1760 RVA: 0x00011480 File Offset: 0x0000F680
		public virtual int GetFileLowerLeft()
		{
			return vtkImageReader2.vtkImageReader2_GetFileLowerLeft_25(base.GetCppThis());
		}

		// Token: 0x060006E1 RID: 1761
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2_GetFileName_26(HandleRef pThis);

		/// <summary>
		/// Specify file name for the image file. If the data is stored in
		/// multiple files, then use SetFileNames or SetFilePrefix instead.
		/// </summary>
		// Token: 0x060006E2 RID: 1762 RVA: 0x000114A0 File Offset: 0x0000F6A0
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageReader2.vtkImageReader2_GetFileName_26(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060006E3 RID: 1763
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReader2_GetFileNameSliceOffset_27(HandleRef pThis);

		/// <summary>
		/// When reading files which start at an unusual index, this can be added
		/// to the slice number when generating the file name (default = 0)
		/// </summary>
		// Token: 0x060006E4 RID: 1764 RVA: 0x000114DC File Offset: 0x0000F6DC
		public virtual int GetFileNameSliceOffset()
		{
			return vtkImageReader2.vtkImageReader2_GetFileNameSliceOffset_27(base.GetCppThis());
		}

		// Token: 0x060006E5 RID: 1765
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReader2_GetFileNameSliceSpacing_28(HandleRef pThis);

		/// <summary>
		/// When reading files which have regular, but non contiguous slices
		/// (eg filename.1,filename.3,filename.5)
		/// a spacing can be specified to skip missing files (default = 1)
		/// </summary>
		// Token: 0x060006E6 RID: 1766 RVA: 0x000114FC File Offset: 0x0000F6FC
		public virtual int GetFileNameSliceSpacing()
		{
			return vtkImageReader2.vtkImageReader2_GetFileNameSliceSpacing_28(base.GetCppThis());
		}

		// Token: 0x060006E7 RID: 1767
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2_GetFileNames_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a list of file names.  Each file must be a single slice,
		/// and each slice must be of the same size. The files must be in the
		/// correct order.
		/// Use SetFileName when reading a volume (multiple slice), since
		/// DataExtent will be modified after a SetFileNames call.
		/// </summary>
		// Token: 0x060006E8 RID: 1768 RVA: 0x0001151C File Offset: 0x0000F71C
		public virtual vtkStringArray GetFileNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReader2.vtkImageReader2_GetFileNames_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060006E9 RID: 1769
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2_GetFilePattern_30(HandleRef pThis);

		/// <summary>
		/// The snprintf-style format string used to build filename from
		/// FilePrefix and slice number.
		/// </summary>
		// Token: 0x060006EA RID: 1770 RVA: 0x0001158C File Offset: 0x0000F78C
		public virtual string GetFilePattern()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageReader2.vtkImageReader2_GetFilePattern_30(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060006EB RID: 1771
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2_GetFilePrefix_31(HandleRef pThis);

		/// <summary>
		/// Specify file prefix for the image file or files.  This can be
		/// used in place of SetFileName or SetFileNames if the filenames
		/// follow a specific naming pattern, but you must explicitly set
		/// the DataExtent so that the reader will know what range of slices
		/// to load.
		/// </summary>
		// Token: 0x060006EC RID: 1772 RVA: 0x000115C8 File Offset: 0x0000F7C8
		public virtual string GetFilePrefix()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageReader2.vtkImageReader2_GetFilePrefix_31(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060006ED RID: 1773
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkImageReader2_GetHeaderSize_32(HandleRef pThis);

		/// <summary>
		/// Get the size of the header computed by this object.
		/// </summary>
		// Token: 0x060006EE RID: 1774 RVA: 0x00011604 File Offset: 0x0000F804
		public uint GetHeaderSize()
		{
			return vtkImageReader2.vtkImageReader2_GetHeaderSize_32(base.GetCppThis());
		}

		// Token: 0x060006EF RID: 1775
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkImageReader2_GetHeaderSize_33(HandleRef pThis, uint slice);

		/// <summary>
		/// Get the size of the header computed by this object.
		/// </summary>
		// Token: 0x060006F0 RID: 1776 RVA: 0x00011624 File Offset: 0x0000F824
		public uint GetHeaderSize(uint slice)
		{
			return vtkImageReader2.vtkImageReader2_GetHeaderSize_33(base.GetCppThis(), slice);
		}

		// Token: 0x060006F1 RID: 1777
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2_GetInternalFileName_34(HandleRef pThis);

		/// <summary>
		/// Set/Get the internal file name
		/// </summary>
		// Token: 0x060006F2 RID: 1778 RVA: 0x00011644 File Offset: 0x0000F844
		public virtual string GetInternalFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageReader2.vtkImageReader2_GetInternalFileName_34(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060006F3 RID: 1779
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2_GetMemoryBuffer_35(HandleRef pThis);

		/// <summary>
		/// Specify the in memory image buffer.
		/// May be used by a reader to allow the reading
		/// of an image from memory instead of from file.
		/// </summary>
		// Token: 0x060006F4 RID: 1780 RVA: 0x00011680 File Offset: 0x0000F880
		public virtual IntPtr GetMemoryBuffer()
		{
			return vtkImageReader2.vtkImageReader2_GetMemoryBuffer_35(base.GetCppThis());
		}

		// Token: 0x060006F5 RID: 1781
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageReader2_GetMemoryBufferLength_36(HandleRef pThis);

		/// <summary>
		/// Specify the in memory image buffer length.
		/// </summary>
		// Token: 0x060006F6 RID: 1782 RVA: 0x000116A0 File Offset: 0x0000F8A0
		public long GetMemoryBufferLength()
		{
			return vtkImageReader2.vtkImageReader2_GetMemoryBufferLength_36(base.GetCppThis());
		}

		// Token: 0x060006F7 RID: 1783
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageReader2_GetNumberOfGenerationsFromBase_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060006F8 RID: 1784 RVA: 0x000116C0 File Offset: 0x0000F8C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageReader2.vtkImageReader2_GetNumberOfGenerationsFromBase_37(base.GetCppThis(), type);
		}

		// Token: 0x060006F9 RID: 1785
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageReader2_GetNumberOfGenerationsFromBaseType_38([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060006FA RID: 1786 RVA: 0x000116E0 File Offset: 0x0000F8E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageReader2.vtkImageReader2_GetNumberOfGenerationsFromBaseType_38(type);
		}

		// Token: 0x060006FB RID: 1787
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReader2_GetNumberOfScalarComponents_39(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of scalar components
		/// </summary>
		// Token: 0x060006FC RID: 1788 RVA: 0x000116FC File Offset: 0x0000F8FC
		public virtual int GetNumberOfScalarComponents()
		{
			return vtkImageReader2.vtkImageReader2_GetNumberOfScalarComponents_39(base.GetCppThis());
		}

		// Token: 0x060006FD RID: 1789
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReader2_GetSwapBytes_40(HandleRef pThis);

		/// <summary>
		/// Set/Get the byte swapping to explicitly swap the bytes of a file.
		/// </summary>
		// Token: 0x060006FE RID: 1790 RVA: 0x0001171C File Offset: 0x0000F91C
		public virtual int GetSwapBytes()
		{
			return vtkImageReader2.vtkImageReader2_GetSwapBytes_40(base.GetCppThis());
		}

		// Token: 0x060006FF RID: 1791
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReader2_IsA_41(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000700 RID: 1792 RVA: 0x0001173C File Offset: 0x0000F93C
		public override int IsA(string type)
		{
			return vtkImageReader2.vtkImageReader2_IsA_41(base.GetCppThis(), type);
		}

		// Token: 0x06000701 RID: 1793
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReader2_IsTypeOf_42([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000702 RID: 1794 RVA: 0x0001175C File Offset: 0x0000F95C
		public new static int IsTypeOf(string type)
		{
			return vtkImageReader2.vtkImageReader2_IsTypeOf_42(type);
		}

		// Token: 0x06000703 RID: 1795
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2_NewInstance_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000704 RID: 1796 RVA: 0x00011778 File Offset: 0x0000F978
		public new vtkImageReader2 NewInstance()
		{
			vtkImageReader2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReader2.vtkImageReader2_NewInstance_44(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReader2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000705 RID: 1797
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReader2_OpenFile_45(HandleRef pThis);

		/// <summary>
		/// Set/Get the byte swapping to explicitly swap the bytes of a file.
		/// </summary>
		// Token: 0x06000706 RID: 1798 RVA: 0x000117D4 File Offset: 0x0000F9D4
		public virtual int OpenFile()
		{
			return vtkImageReader2.vtkImageReader2_OpenFile_45(base.GetCppThis());
		}

		// Token: 0x06000707 RID: 1799
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000708 RID: 1800 RVA: 0x000117F4 File Offset: 0x0000F9F4
		public new static vtkImageReader2 SafeDownCast(vtkObjectBase o)
		{
			vtkImageReader2 vtkImageReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReader2.vtkImageReader2_SafeDownCast_46((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageReader = (vtkImageReader2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageReader.Register(null);
				}
			}
			return vtkImageReader;
		}

		// Token: 0x06000709 RID: 1801
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SeekFile_47(HandleRef pThis, int i, int j, int k);

		/// <summary>
		/// Set/Get the byte swapping to explicitly swap the bytes of a file.
		/// </summary>
		// Token: 0x0600070A RID: 1802 RVA: 0x00011873 File Offset: 0x0000FA73
		public virtual void SeekFile(int i, int j, int k)
		{
			vtkImageReader2.vtkImageReader2_SeekFile_47(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0600070B RID: 1803
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetDataByteOrder_48(HandleRef pThis, int arg0);

		/// <summary>
		/// These methods should be used instead of the SwapBytes methods.
		/// They indicate the byte ordering of the file you are trying
		/// to read in. These methods will then either swap or not swap
		/// the bytes depending on the byte ordering of the machine it is
		/// being run on. For example, reading in a BigEndian file on a
		/// BigEndian machine will result in no swapping. Trying to read
		/// the same file on a LittleEndian machine will result in swapping.
		/// As a quick note most UNIX machines are BigEndian while PC's
		/// and VAX tend to be LittleEndian. So if the file you are reading
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
		/// otherwise SetDataByteOrderToBigEndian.
		/// </summary>
		// Token: 0x0600070C RID: 1804 RVA: 0x00011885 File Offset: 0x0000FA85
		public virtual void SetDataByteOrder(int arg0)
		{
			vtkImageReader2.vtkImageReader2_SetDataByteOrder_48(base.GetCppThis(), arg0);
		}

		// Token: 0x0600070D RID: 1805
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetDataByteOrderToBigEndian_49(HandleRef pThis);

		/// <summary>
		/// These methods should be used instead of the SwapBytes methods.
		/// They indicate the byte ordering of the file you are trying
		/// to read in. These methods will then either swap or not swap
		/// the bytes depending on the byte ordering of the machine it is
		/// being run on. For example, reading in a BigEndian file on a
		/// BigEndian machine will result in no swapping. Trying to read
		/// the same file on a LittleEndian machine will result in swapping.
		/// As a quick note most UNIX machines are BigEndian while PC's
		/// and VAX tend to be LittleEndian. So if the file you are reading
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
		/// otherwise SetDataByteOrderToBigEndian.
		/// </summary>
		// Token: 0x0600070E RID: 1806 RVA: 0x00011895 File Offset: 0x0000FA95
		public virtual void SetDataByteOrderToBigEndian()
		{
			vtkImageReader2.vtkImageReader2_SetDataByteOrderToBigEndian_49(base.GetCppThis());
		}

		// Token: 0x0600070F RID: 1807
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetDataByteOrderToLittleEndian_50(HandleRef pThis);

		/// <summary>
		/// These methods should be used instead of the SwapBytes methods.
		/// They indicate the byte ordering of the file you are trying
		/// to read in. These methods will then either swap or not swap
		/// the bytes depending on the byte ordering of the machine it is
		/// being run on. For example, reading in a BigEndian file on a
		/// BigEndian machine will result in no swapping. Trying to read
		/// the same file on a LittleEndian machine will result in swapping.
		/// As a quick note most UNIX machines are BigEndian while PC's
		/// and VAX tend to be LittleEndian. So if the file you are reading
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
		/// otherwise SetDataByteOrderToBigEndian.
		/// </summary>
		// Token: 0x06000710 RID: 1808 RVA: 0x000118A4 File Offset: 0x0000FAA4
		public virtual void SetDataByteOrderToLittleEndian()
		{
			vtkImageReader2.vtkImageReader2_SetDataByteOrderToLittleEndian_50(base.GetCppThis());
		}

		// Token: 0x06000711 RID: 1809
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetDataDirection_51(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the direction of the data (9 elements: 3x3 matrix).
		/// </summary>
		// Token: 0x06000712 RID: 1810 RVA: 0x000118B3 File Offset: 0x0000FAB3
		public virtual void SetDataDirection(IntPtr data)
		{
			vtkImageReader2.vtkImageReader2_SetDataDirection_51(base.GetCppThis(), data);
		}

		// Token: 0x06000713 RID: 1811
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetDataExtent_52(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Get/Set the extent of the data on disk.
		/// </summary>
		// Token: 0x06000714 RID: 1812 RVA: 0x000118C3 File Offset: 0x0000FAC3
		public virtual void SetDataExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkImageReader2.vtkImageReader2_SetDataExtent_52(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06000715 RID: 1813
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetDataExtent_53(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the extent of the data on disk.
		/// </summary>
		// Token: 0x06000716 RID: 1814 RVA: 0x000118DB File Offset: 0x0000FADB
		public virtual void SetDataExtent(IntPtr _arg)
		{
			vtkImageReader2.vtkImageReader2_SetDataExtent_53(base.GetCppThis(), _arg);
		}

		// Token: 0x06000717 RID: 1815
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetDataOrigin_54(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the origin of the data (location of first pixel in the file).
		/// </summary>
		// Token: 0x06000718 RID: 1816 RVA: 0x000118EB File Offset: 0x0000FAEB
		public virtual void SetDataOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkImageReader2.vtkImageReader2_SetDataOrigin_54(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06000719 RID: 1817
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetDataOrigin_55(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the origin of the data (location of first pixel in the file).
		/// </summary>
		// Token: 0x0600071A RID: 1818 RVA: 0x000118FD File Offset: 0x0000FAFD
		public virtual void SetDataOrigin(IntPtr _arg)
		{
			vtkImageReader2.vtkImageReader2_SetDataOrigin_55(base.GetCppThis(), _arg);
		}

		// Token: 0x0600071B RID: 1819
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetDataScalarType_56(HandleRef pThis, int type);

		/// <summary>
		/// Set the data type of pixels in the file.
		/// If you want the output scalar type to have a different value, set it
		/// after this method is called.
		/// </summary>
		// Token: 0x0600071C RID: 1820 RVA: 0x0001190D File Offset: 0x0000FB0D
		public virtual void SetDataScalarType(int type)
		{
			vtkImageReader2.vtkImageReader2_SetDataScalarType_56(base.GetCppThis(), type);
		}

		// Token: 0x0600071D RID: 1821
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetDataScalarTypeToChar_57(HandleRef pThis);

		/// <summary>
		/// Set the data type of pixels in the file.
		/// If you want the output scalar type to have a different value, set it
		/// after this method is called.
		/// </summary>
		// Token: 0x0600071E RID: 1822 RVA: 0x0001191D File Offset: 0x0000FB1D
		public virtual void SetDataScalarTypeToChar()
		{
			vtkImageReader2.vtkImageReader2_SetDataScalarTypeToChar_57(base.GetCppThis());
		}

		// Token: 0x0600071F RID: 1823
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetDataScalarTypeToDouble_58(HandleRef pThis);

		/// <summary>
		/// Set the data type of pixels in the file.
		/// If you want the output scalar type to have a different value, set it
		/// after this method is called.
		/// </summary>
		// Token: 0x06000720 RID: 1824 RVA: 0x0001192C File Offset: 0x0000FB2C
		public virtual void SetDataScalarTypeToDouble()
		{
			vtkImageReader2.vtkImageReader2_SetDataScalarTypeToDouble_58(base.GetCppThis());
		}

		// Token: 0x06000721 RID: 1825
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetDataScalarTypeToFloat_59(HandleRef pThis);

		/// <summary>
		/// Set the data type of pixels in the file.
		/// If you want the output scalar type to have a different value, set it
		/// after this method is called.
		/// </summary>
		// Token: 0x06000722 RID: 1826 RVA: 0x0001193B File Offset: 0x0000FB3B
		public virtual void SetDataScalarTypeToFloat()
		{
			vtkImageReader2.vtkImageReader2_SetDataScalarTypeToFloat_59(base.GetCppThis());
		}

		// Token: 0x06000723 RID: 1827
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetDataScalarTypeToInt_60(HandleRef pThis);

		/// <summary>
		/// Set the data type of pixels in the file.
		/// If you want the output scalar type to have a different value, set it
		/// after this method is called.
		/// </summary>
		// Token: 0x06000724 RID: 1828 RVA: 0x0001194A File Offset: 0x0000FB4A
		public virtual void SetDataScalarTypeToInt()
		{
			vtkImageReader2.vtkImageReader2_SetDataScalarTypeToInt_60(base.GetCppThis());
		}

		// Token: 0x06000725 RID: 1829
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetDataScalarTypeToShort_61(HandleRef pThis);

		/// <summary>
		/// Set the data type of pixels in the file.
		/// If you want the output scalar type to have a different value, set it
		/// after this method is called.
		/// </summary>
		// Token: 0x06000726 RID: 1830 RVA: 0x00011959 File Offset: 0x0000FB59
		public virtual void SetDataScalarTypeToShort()
		{
			vtkImageReader2.vtkImageReader2_SetDataScalarTypeToShort_61(base.GetCppThis());
		}

		// Token: 0x06000727 RID: 1831
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetDataScalarTypeToSignedChar_62(HandleRef pThis);

		/// <summary>
		/// Set the data type of pixels in the file.
		/// If you want the output scalar type to have a different value, set it
		/// after this method is called.
		/// </summary>
		// Token: 0x06000728 RID: 1832 RVA: 0x00011968 File Offset: 0x0000FB68
		public virtual void SetDataScalarTypeToSignedChar()
		{
			vtkImageReader2.vtkImageReader2_SetDataScalarTypeToSignedChar_62(base.GetCppThis());
		}

		// Token: 0x06000729 RID: 1833
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetDataScalarTypeToUnsignedChar_63(HandleRef pThis);

		/// <summary>
		/// Set the data type of pixels in the file.
		/// If you want the output scalar type to have a different value, set it
		/// after this method is called.
		/// </summary>
		// Token: 0x0600072A RID: 1834 RVA: 0x00011977 File Offset: 0x0000FB77
		public virtual void SetDataScalarTypeToUnsignedChar()
		{
			vtkImageReader2.vtkImageReader2_SetDataScalarTypeToUnsignedChar_63(base.GetCppThis());
		}

		// Token: 0x0600072B RID: 1835
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetDataScalarTypeToUnsignedInt_64(HandleRef pThis);

		/// <summary>
		/// Set the data type of pixels in the file.
		/// If you want the output scalar type to have a different value, set it
		/// after this method is called.
		/// </summary>
		// Token: 0x0600072C RID: 1836 RVA: 0x00011986 File Offset: 0x0000FB86
		public virtual void SetDataScalarTypeToUnsignedInt()
		{
			vtkImageReader2.vtkImageReader2_SetDataScalarTypeToUnsignedInt_64(base.GetCppThis());
		}

		// Token: 0x0600072D RID: 1837
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetDataScalarTypeToUnsignedShort_65(HandleRef pThis);

		/// <summary>
		/// Set the data type of pixels in the file.
		/// If you want the output scalar type to have a different value, set it
		/// after this method is called.
		/// </summary>
		// Token: 0x0600072E RID: 1838 RVA: 0x00011995 File Offset: 0x0000FB95
		public virtual void SetDataScalarTypeToUnsignedShort()
		{
			vtkImageReader2.vtkImageReader2_SetDataScalarTypeToUnsignedShort_65(base.GetCppThis());
		}

		// Token: 0x0600072F RID: 1839
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetDataSpacing_66(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the spacing of the data in the file.
		/// </summary>
		// Token: 0x06000730 RID: 1840 RVA: 0x000119A4 File Offset: 0x0000FBA4
		public virtual void SetDataSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkImageReader2.vtkImageReader2_SetDataSpacing_66(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06000731 RID: 1841
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetDataSpacing_67(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the spacing of the data in the file.
		/// </summary>
		// Token: 0x06000732 RID: 1842 RVA: 0x000119B6 File Offset: 0x0000FBB6
		public virtual void SetDataSpacing(IntPtr _arg)
		{
			vtkImageReader2.vtkImageReader2_SetDataSpacing_67(base.GetCppThis(), _arg);
		}

		// Token: 0x06000733 RID: 1843
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetFileDimensionality_68(HandleRef pThis, int _arg);

		/// <summary>
		/// The number of dimensions stored in a file. This defaults to two.
		/// </summary>
		// Token: 0x06000734 RID: 1844 RVA: 0x000119C6 File Offset: 0x0000FBC6
		public virtual void SetFileDimensionality(int _arg)
		{
			vtkImageReader2.vtkImageReader2_SetFileDimensionality_68(base.GetCppThis(), _arg);
		}

		// Token: 0x06000735 RID: 1845
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetFileLowerLeft_69(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether the data comes from the file starting in the lower left
		/// corner or upper left corner.
		/// </summary>
		// Token: 0x06000736 RID: 1846 RVA: 0x000119D6 File Offset: 0x0000FBD6
		public virtual void SetFileLowerLeft(int _arg)
		{
			vtkImageReader2.vtkImageReader2_SetFileLowerLeft_69(base.GetCppThis(), _arg);
		}

		// Token: 0x06000737 RID: 1847
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetFileName_70(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Specify file name for the image file. If the data is stored in
		/// multiple files, then use SetFileNames or SetFilePrefix instead.
		/// </summary>
		// Token: 0x06000738 RID: 1848 RVA: 0x000119E6 File Offset: 0x0000FBE6
		public virtual void SetFileName(string arg0)
		{
			vtkImageReader2.vtkImageReader2_SetFileName_70(base.GetCppThis(), arg0);
		}

		// Token: 0x06000739 RID: 1849
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetFileNameSliceOffset_71(HandleRef pThis, int _arg);

		/// <summary>
		/// When reading files which start at an unusual index, this can be added
		/// to the slice number when generating the file name (default = 0)
		/// </summary>
		// Token: 0x0600073A RID: 1850 RVA: 0x000119F6 File Offset: 0x0000FBF6
		public virtual void SetFileNameSliceOffset(int _arg)
		{
			vtkImageReader2.vtkImageReader2_SetFileNameSliceOffset_71(base.GetCppThis(), _arg);
		}

		// Token: 0x0600073B RID: 1851
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetFileNameSliceSpacing_72(HandleRef pThis, int _arg);

		/// <summary>
		/// When reading files which have regular, but non contiguous slices
		/// (eg filename.1,filename.3,filename.5)
		/// a spacing can be specified to skip missing files (default = 1)
		/// </summary>
		// Token: 0x0600073C RID: 1852 RVA: 0x00011A06 File Offset: 0x0000FC06
		public virtual void SetFileNameSliceSpacing(int _arg)
		{
			vtkImageReader2.vtkImageReader2_SetFileNameSliceSpacing_72(base.GetCppThis(), _arg);
		}

		// Token: 0x0600073D RID: 1853
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetFileNames_73(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify a list of file names.  Each file must be a single slice,
		/// and each slice must be of the same size. The files must be in the
		/// correct order.
		/// Use SetFileName when reading a volume (multiple slice), since
		/// DataExtent will be modified after a SetFileNames call.
		/// </summary>
		// Token: 0x0600073E RID: 1854 RVA: 0x00011A18 File Offset: 0x0000FC18
		public virtual void SetFileNames(vtkStringArray arg0)
		{
			vtkImageReader2.vtkImageReader2_SetFileNames_73(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600073F RID: 1855
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetFilePattern_74(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// The snprintf-style format string used to build filename from
		/// FilePrefix and slice number.
		/// </summary>
		// Token: 0x06000740 RID: 1856 RVA: 0x00011A47 File Offset: 0x0000FC47
		public virtual void SetFilePattern(string arg0)
		{
			vtkImageReader2.vtkImageReader2_SetFilePattern_74(base.GetCppThis(), arg0);
		}

		// Token: 0x06000741 RID: 1857
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetFilePrefix_75(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Specify file prefix for the image file or files.  This can be
		/// used in place of SetFileName or SetFileNames if the filenames
		/// follow a specific naming pattern, but you must explicitly set
		/// the DataExtent so that the reader will know what range of slices
		/// to load.
		/// </summary>
		// Token: 0x06000742 RID: 1858 RVA: 0x00011A57 File Offset: 0x0000FC57
		public virtual void SetFilePrefix(string arg0)
		{
			vtkImageReader2.vtkImageReader2_SetFilePrefix_75(base.GetCppThis(), arg0);
		}

		// Token: 0x06000743 RID: 1859
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetHeaderSize_76(HandleRef pThis, uint size);

		/// <summary>
		/// If there is a tail on the file, you want to explicitly set the
		/// header size.
		/// </summary>
		// Token: 0x06000744 RID: 1860 RVA: 0x00011A67 File Offset: 0x0000FC67
		public virtual void SetHeaderSize(uint size)
		{
			vtkImageReader2.vtkImageReader2_SetHeaderSize_76(base.GetCppThis(), size);
		}

		// Token: 0x06000745 RID: 1861
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetMemoryBuffer_77(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Specify the in memory image buffer.
		/// May be used by a reader to allow the reading
		/// of an image from memory instead of from file.
		/// </summary>
		// Token: 0x06000746 RID: 1862 RVA: 0x00011A77 File Offset: 0x0000FC77
		public virtual void SetMemoryBuffer(IntPtr arg0)
		{
			vtkImageReader2.vtkImageReader2_SetMemoryBuffer_77(base.GetCppThis(), arg0);
		}

		// Token: 0x06000747 RID: 1863
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetMemoryBufferLength_78(HandleRef pThis, long buflen);

		/// <summary>
		/// Specify the in memory image buffer length.
		/// </summary>
		// Token: 0x06000748 RID: 1864 RVA: 0x00011A87 File Offset: 0x0000FC87
		public virtual void SetMemoryBufferLength(long buflen)
		{
			vtkImageReader2.vtkImageReader2_SetMemoryBufferLength_78(base.GetCppThis(), buflen);
		}

		// Token: 0x06000749 RID: 1865
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetNumberOfScalarComponents_79(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of scalar components
		/// </summary>
		// Token: 0x0600074A RID: 1866 RVA: 0x00011A97 File Offset: 0x0000FC97
		public virtual void SetNumberOfScalarComponents(int _arg)
		{
			vtkImageReader2.vtkImageReader2_SetNumberOfScalarComponents_79(base.GetCppThis(), _arg);
		}

		// Token: 0x0600074B RID: 1867
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SetSwapBytes_80(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the byte swapping to explicitly swap the bytes of a file.
		/// </summary>
		// Token: 0x0600074C RID: 1868 RVA: 0x00011AA7 File Offset: 0x0000FCA7
		public virtual void SetSwapBytes(int _arg)
		{
			vtkImageReader2.vtkImageReader2_SetSwapBytes_80(base.GetCppThis(), _arg);
		}

		// Token: 0x0600074D RID: 1869
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SwapBytesOff_81(HandleRef pThis);

		/// <summary>
		/// Set/Get the byte swapping to explicitly swap the bytes of a file.
		/// </summary>
		// Token: 0x0600074E RID: 1870 RVA: 0x00011AB7 File Offset: 0x0000FCB7
		public virtual void SwapBytesOff()
		{
			vtkImageReader2.vtkImageReader2_SwapBytesOff_81(base.GetCppThis());
		}

		// Token: 0x0600074F RID: 1871
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2_SwapBytesOn_82(HandleRef pThis);

		/// <summary>
		/// Set/Get the byte swapping to explicitly swap the bytes of a file.
		/// </summary>
		// Token: 0x06000750 RID: 1872 RVA: 0x00011AC6 File Offset: 0x0000FCC6
		public virtual void SwapBytesOn()
		{
			vtkImageReader2.vtkImageReader2_SwapBytesOn_82(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000380 RID: 896
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageReader2";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000381 RID: 897
		public new static readonly string MRClassNameKey = "class vtkImageReader2";
	}
}
