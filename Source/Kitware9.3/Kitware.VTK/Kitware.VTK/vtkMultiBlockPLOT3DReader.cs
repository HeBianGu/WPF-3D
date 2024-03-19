using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMultiBlockPLOT3DReader
	/// </summary>
	/// <remarks>
	///    read PLOT3D data files
	///
	/// vtkMultiBlockPLOT3DReader is a reader object that reads PLOT3D formatted
	/// files and generates structured grid(s) on output. PLOT3D is a computer
	/// graphics program designed to visualize the grids and solutions of
	/// computational fluid dynamics. This reader also supports the variant
	/// of the PLOT3D format used by NASA's OVERFLOW CFD software, including
	/// full support for all Q variables. Please see the "PLOT3D User's Manual"
	/// available from NASA Ames Research Center, Moffett Field CA.
	///
	/// PLOT3D files consist of a grid file (also known as XYZ file), an
	/// optional solution file (also known as a Q file), and an optional function
	/// file that contains user created data (currently unsupported). The Q file
	/// contains solution information as follows: the four parameters free stream
	/// mach number (Fsmach), angle of attack (Alpha), Reynolds number (Re), and
	/// total integration time (Time). This information is stored in an array
	/// called Properties in the FieldData of each output (tuple 0: fsmach, tuple 1:
	/// alpha, tuple 2: re, tuple 3: time). In addition, the solution file contains
	/// the flow density (scalar), flow momentum (vector), and flow energy (scalar).
	///
	/// This reader supports a limited form of time series data which are stored
	/// as a series of Q files. Using the AddFileName() method provided by the
	/// superclass, one can define a file series. For other cases, for example where
	/// the XYZ or function files vary over time, use vtkPlot3DMetaReader.
	///
	/// The reader can generate additional scalars and vectors (or "functions")
	/// from this information. To use vtkMultiBlockPLOT3DReader, you must specify the
	/// particular function number for the scalar and vector you want to visualize.
	/// This implementation of the reader provides the following functions. The
	/// scalar functions are:
	///    -1  - don't read or compute any scalars
	///    100 - density
	///    110 - pressure
	///    111 - pressure coefficient (requires Overflow file with Gamma)
	///    112 - mach number (requires Overflow file with Gamma)
	///    113 - sounds speed (requires Overflow file with Gamma)
	///    120 - temperature
	///    130 - enthalpy
	///    140 - internal energy
	///    144 - kinetic energy
	///    153 - velocity magnitude
	///    163 - stagnation energy
	///    170 - entropy
	///    184 - swirl
	///    211 - vorticity magnitude
	///
	/// The vector functions are:
	///    -1  - don't read or compute any vectors
	///    200 - velocity
	///    201 - vorticity
	///    202 - momentum
	///    210 - pressure gradient.
	///    212 - strain rate
	///
	/// (Other functions are described in the PLOT3D spec, but only those listed are
	/// implemented here.) Note that by default, this reader creates the density
	/// scalar (100), stagnation energy (163) and momentum vector (202) as output.
	/// (These are just read in from the solution file.) Please note that the validity
	/// of computation is a function of this class's gas constants (R, Gamma) and the
	/// equations used. They may not be suitable for your computational domain.
	///
	/// Additionally, you can read other data and associate it as a vtkDataArray
	/// into the output's point attribute data. Use the method AddFunction()
	/// to list all the functions that you'd like to read. AddFunction() accepts
	/// an integer parameter that defines the function number.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMultiBlockDataSet vtkStructuredGrid vtkPlot3DMetaReader
	/// </seealso>
	// Token: 0x02000154 RID: 340
	public class vtkMultiBlockPLOT3DReader : vtkParallelReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060040A4 RID: 16548 RVA: 0x0005EFF3 File Offset: 0x0005D1F3
		static vtkMultiBlockPLOT3DReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiBlockPLOT3DReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiBlockPLOT3DReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060040A5 RID: 16549 RVA: 0x0005F01B File Offset: 0x0005D21B
		public vtkMultiBlockPLOT3DReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060040A6 RID: 16550
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockPLOT3DReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060040A7 RID: 16551 RVA: 0x0005F02C File Offset: 0x0005D22C
		public new static vtkMultiBlockPLOT3DReader New()
		{
			vtkMultiBlockPLOT3DReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockPLOT3DReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060040A8 RID: 16552 RVA: 0x0005F080 File Offset: 0x0005D280
		public vtkMultiBlockPLOT3DReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060040A9 RID: 16553 RVA: 0x0005F0C4 File Offset: 0x0005D2C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060040AA RID: 16554
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_AddFunction_01(HandleRef pThis, int functionNumber);

		/// <summary>
		/// Specify additional functions to read. These are placed into the
		/// point data as data arrays. Later on they can be used by labeling
		/// them as scalars, etc.
		/// </summary>
		// Token: 0x060040AB RID: 16555 RVA: 0x0005F0CF File Offset: 0x0005D2CF
		public void AddFunction(int functionNumber)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_AddFunction_01(base.GetCppThis(), functionNumber);
		}

		// Token: 0x060040AC RID: 16556
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_AddFunctionName_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/Get the communicator object (we'll use global World controller
		/// if you don't set a different one).
		/// </summary>
		// Token: 0x060040AD RID: 16557 RVA: 0x0005F0DF File Offset: 0x0005D2DF
		public void AddFunctionName(string name)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_AddFunctionName_02(base.GetCppThis(), name);
		}

		// Token: 0x060040AE RID: 16558
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_AutoDetectFormatOff_03(HandleRef pThis);

		/// <summary>
		/// When this option is turned on, the reader will try to figure
		/// out the values of various options such as byte order, byte
		/// count etc. automatically. This options works only for binary
		/// files. When it is turned on, the reader should be able to read
		/// most Plot3D files automatically. The default is OFF for backwards
		/// compatibility reasons. For binary files, it is strongly recommended
		/// that you turn on AutoDetectFormat and leave the other file format
		/// related options untouched.
		/// </summary>
		// Token: 0x060040AF RID: 16559 RVA: 0x0005F0EF File Offset: 0x0005D2EF
		public virtual void AutoDetectFormatOff()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_AutoDetectFormatOff_03(base.GetCppThis());
		}

		// Token: 0x060040B0 RID: 16560
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_AutoDetectFormatOn_04(HandleRef pThis);

		/// <summary>
		/// When this option is turned on, the reader will try to figure
		/// out the values of various options such as byte order, byte
		/// count etc. automatically. This options works only for binary
		/// files. When it is turned on, the reader should be able to read
		/// most Plot3D files automatically. The default is OFF for backwards
		/// compatibility reasons. For binary files, it is strongly recommended
		/// that you turn on AutoDetectFormat and leave the other file format
		/// related options untouched.
		/// </summary>
		// Token: 0x060040B1 RID: 16561 RVA: 0x0005F0FE File Offset: 0x0005D2FE
		public virtual void AutoDetectFormatOn()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_AutoDetectFormatOn_04(base.GetCppThis());
		}

		// Token: 0x060040B2 RID: 16562
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_BinaryFileOff_05(HandleRef pThis);

		/// <summary>
		/// Is the file to be read written in binary format (as opposed
		/// to ascii).
		/// </summary>
		// Token: 0x060040B3 RID: 16563 RVA: 0x0005F10D File Offset: 0x0005D30D
		public virtual void BinaryFileOff()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_BinaryFileOff_05(base.GetCppThis());
		}

		// Token: 0x060040B4 RID: 16564
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_BinaryFileOn_06(HandleRef pThis);

		/// <summary>
		/// Is the file to be read written in binary format (as opposed
		/// to ascii).
		/// </summary>
		// Token: 0x060040B5 RID: 16565 RVA: 0x0005F11C File Offset: 0x0005D31C
		public virtual void BinaryFileOn()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_BinaryFileOn_06(base.GetCppThis());
		}

		// Token: 0x060040B6 RID: 16566
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockPLOT3DReader_CanReadBinaryFile_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Return 1 if the reader can read the given file name. Only meaningful
		/// for binary files.
		/// </summary>
		// Token: 0x060040B7 RID: 16567 RVA: 0x0005F12C File Offset: 0x0005D32C
		public virtual int CanReadBinaryFile(string fname)
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_CanReadBinaryFile_07(base.GetCppThis(), fname);
		}

		// Token: 0x060040B8 RID: 16568
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_DoublePrecisionOff_08(HandleRef pThis);

		/// <summary>
		/// Is this file in double precision or single precision.
		/// This only matters for binary files.
		/// Default is single.
		/// </summary>
		// Token: 0x060040B9 RID: 16569 RVA: 0x0005F14C File Offset: 0x0005D34C
		public virtual void DoublePrecisionOff()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_DoublePrecisionOff_08(base.GetCppThis());
		}

		// Token: 0x060040BA RID: 16570
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_DoublePrecisionOn_09(HandleRef pThis);

		/// <summary>
		/// Is this file in double precision or single precision.
		/// This only matters for binary files.
		/// Default is single.
		/// </summary>
		// Token: 0x060040BB RID: 16571 RVA: 0x0005F15B File Offset: 0x0005D35B
		public virtual void DoublePrecisionOn()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_DoublePrecisionOn_09(base.GetCppThis());
		}

		// Token: 0x060040BC RID: 16572
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_ForceReadOff_10(HandleRef pThis);

		/// <summary>
		/// Try to read a binary file even if the file length seems to be
		/// inconsistent with the header information. Use this with caution,
		/// if the file length is not the same as calculated from the header.
		/// either the file is corrupt or the settings are wrong.
		/// </summary>
		// Token: 0x060040BD RID: 16573 RVA: 0x0005F16A File Offset: 0x0005D36A
		public virtual void ForceReadOff()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_ForceReadOff_10(base.GetCppThis());
		}

		// Token: 0x060040BE RID: 16574
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_ForceReadOn_11(HandleRef pThis);

		/// <summary>
		/// Try to read a binary file even if the file length seems to be
		/// inconsistent with the header information. Use this with caution,
		/// if the file length is not the same as calculated from the header.
		/// either the file is corrupt or the settings are wrong.
		/// </summary>
		// Token: 0x060040BF RID: 16575 RVA: 0x0005F179 File Offset: 0x0005D379
		public virtual void ForceReadOn()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_ForceReadOn_11(base.GetCppThis());
		}

		// Token: 0x060040C0 RID: 16576
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockPLOT3DReader_GetAutoDetectFormat_12(HandleRef pThis);

		/// <summary>
		/// When this option is turned on, the reader will try to figure
		/// out the values of various options such as byte order, byte
		/// count etc. automatically. This options works only for binary
		/// files. When it is turned on, the reader should be able to read
		/// most Plot3D files automatically. The default is OFF for backwards
		/// compatibility reasons. For binary files, it is strongly recommended
		/// that you turn on AutoDetectFormat and leave the other file format
		/// related options untouched.
		/// </summary>
		// Token: 0x060040C1 RID: 16577 RVA: 0x0005F188 File Offset: 0x0005D388
		public virtual int GetAutoDetectFormat()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetAutoDetectFormat_12(base.GetCppThis());
		}

		// Token: 0x060040C2 RID: 16578
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockPLOT3DReader_GetBinaryFile_13(HandleRef pThis);

		/// <summary>
		/// Is the file to be read written in binary format (as opposed
		/// to ascii).
		/// </summary>
		// Token: 0x060040C3 RID: 16579 RVA: 0x0005F1A8 File Offset: 0x0005D3A8
		public virtual int GetBinaryFile()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetBinaryFile_13(base.GetCppThis());
		}

		// Token: 0x060040C4 RID: 16580
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockPLOT3DReader_GetByteOrder_14(HandleRef pThis);

		/// <summary>
		/// Set the byte order of the file (remember, more Unix workstations
		/// write big endian whereas PCs write little endian). Default is
		/// big endian (since most older PLOT3D files were written by
		/// workstations).
		/// </summary>
		// Token: 0x060040C5 RID: 16581 RVA: 0x0005F1C8 File Offset: 0x0005D3C8
		public virtual int GetByteOrder()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetByteOrder_14(base.GetCppThis());
		}

		// Token: 0x060040C6 RID: 16582
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetByteOrderAsString_15(HandleRef pThis);

		/// <summary>
		/// Set the byte order of the file (remember, more Unix workstations
		/// write big endian whereas PCs write little endian). Default is
		/// big endian (since most older PLOT3D files were written by
		/// workstations).
		/// </summary>
		// Token: 0x060040C7 RID: 16583 RVA: 0x0005F1E8 File Offset: 0x0005D3E8
		public string GetByteOrderAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetByteOrderAsString_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060040C8 RID: 16584
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetController_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the communicator object (we'll use global World controller
		/// if you don't set a different one).
		/// </summary>
		// Token: 0x060040C9 RID: 16585 RVA: 0x0005F224 File Offset: 0x0005D424
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetController_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x060040CA RID: 16586
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockPLOT3DReader_GetDoublePrecision_17(HandleRef pThis);

		/// <summary>
		/// Is this file in double precision or single precision.
		/// This only matters for binary files.
		/// Default is single.
		/// </summary>
		// Token: 0x060040CB RID: 16587 RVA: 0x0005F294 File Offset: 0x0005D494
		public virtual int GetDoublePrecision()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetDoublePrecision_17(base.GetCppThis());
		}

		// Token: 0x060040CC RID: 16588
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetFileName_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the PLOT3D geometry filename.
		/// </summary>
		// Token: 0x060040CD RID: 16589 RVA: 0x0005F2B4 File Offset: 0x0005D4B4
		public string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetFileName_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060040CE RID: 16590
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetFileName_19(HandleRef pThis, int i);

		/// <summary>
		/// Set/Get the PLOT3D geometry filename.
		/// </summary>
		// Token: 0x060040CF RID: 16591 RVA: 0x0005F2F0 File Offset: 0x0005D4F0
		public new string GetFileName(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetFileName_19(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060040D0 RID: 16592
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockPLOT3DReader_GetForceRead_20(HandleRef pThis);

		/// <summary>
		/// Try to read a binary file even if the file length seems to be
		/// inconsistent with the header information. Use this with caution,
		/// if the file length is not the same as calculated from the header.
		/// either the file is corrupt or the settings are wrong.
		/// </summary>
		// Token: 0x060040D1 RID: 16593 RVA: 0x0005F32C File Offset: 0x0005D52C
		public virtual int GetForceRead()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetForceRead_20(base.GetCppThis());
		}

		// Token: 0x060040D2 RID: 16594
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetFunctionFileName_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the PLOT3D function filename.
		/// </summary>
		// Token: 0x060040D3 RID: 16595 RVA: 0x0005F34C File Offset: 0x0005D54C
		public virtual string GetFunctionFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetFunctionFileName_21(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060040D4 RID: 16596
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMultiBlockPLOT3DReader_GetGamma_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the ratio of specific heats. Default is 1.4.
		/// </summary>
		// Token: 0x060040D5 RID: 16597 RVA: 0x0005F388 File Offset: 0x0005D588
		public virtual double GetGamma()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetGamma_22(base.GetCppThis());
		}

		// Token: 0x060040D6 RID: 16598
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockPLOT3DReader_GetHasByteCount_23(HandleRef pThis);

		/// <summary>
		/// Were the arrays written with leading and trailing byte counts ?
		/// Usually, files written by a fortran program will contain these
		/// byte counts whereas the ones written by C/C++ won't.
		/// </summary>
		// Token: 0x060040D7 RID: 16599 RVA: 0x0005F3A8 File Offset: 0x0005D5A8
		public virtual int GetHasByteCount()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetHasByteCount_23(base.GetCppThis());
		}

		// Token: 0x060040D8 RID: 16600
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockPLOT3DReader_GetIBlanking_24(HandleRef pThis);

		/// <summary>
		/// Is there iblanking (point visibility) information in the file.
		/// If there is iblanking arrays, these will be read and assigned
		/// to the PointVisibility array of the output.
		/// </summary>
		// Token: 0x060040D9 RID: 16601 RVA: 0x0005F3C8 File Offset: 0x0005D5C8
		public virtual int GetIBlanking()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetIBlanking_24(base.GetCppThis());
		}

		// Token: 0x060040DA RID: 16602
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockPLOT3DReader_GetMultiGrid_25(HandleRef pThis);

		/// <summary>
		/// Does the file to be read contain information about number of
		/// grids. In some PLOT3D files, the first value contains the number
		/// of grids (even if there is only 1). If reading such a file,
		/// set this to true.
		/// </summary>
		// Token: 0x060040DB RID: 16603 RVA: 0x0005F3E8 File Offset: 0x0005D5E8
		public virtual int GetMultiGrid()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetMultiGrid_25(base.GetCppThis());
		}

		// Token: 0x060040DC RID: 16604
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiBlockPLOT3DReader_GetNumberOfGenerationsFromBase_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060040DD RID: 16605 RVA: 0x0005F408 File Offset: 0x0005D608
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetNumberOfGenerationsFromBase_26(base.GetCppThis(), type);
		}

		// Token: 0x060040DE RID: 16606
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiBlockPLOT3DReader_GetNumberOfGenerationsFromBaseType_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060040DF RID: 16607 RVA: 0x0005F428 File Offset: 0x0005D628
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetNumberOfGenerationsFromBaseType_27(type);
		}

		// Token: 0x060040E0 RID: 16608
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetOutput_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x060040E1 RID: 16609 RVA: 0x0005F444 File Offset: 0x0005D644
		public vtkMultiBlockDataSet GetOutput()
		{
			vtkMultiBlockDataSet vtkMultiBlockDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetOutput_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiBlockDataSet = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiBlockDataSet.Register(null);
				}
			}
			return vtkMultiBlockDataSet;
		}

		// Token: 0x060040E2 RID: 16610
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetOutput_29(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x060040E3 RID: 16611 RVA: 0x0005F4B4 File Offset: 0x0005D6B4
		public vtkMultiBlockDataSet GetOutput(int arg0)
		{
			vtkMultiBlockDataSet vtkMultiBlockDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetOutput_29(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiBlockDataSet = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiBlockDataSet.Register(null);
				}
			}
			return vtkMultiBlockDataSet;
		}

		// Token: 0x060040E4 RID: 16612
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMultiBlockPLOT3DReader_GetPreserveIntermediateFunctions_30(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the reader will preserve intermediate computed
		/// quantities that were not explicitly requested e.g. if `VelocityMagnitude` is
		/// enabled, but not `Velocity`, the reader still needs to compute `Velocity`.
		/// If `PreserveIntermediateFunctions` if false, then the output will not have
		/// `Velocity` array, only the requested `VelocityMagnitude`. This is useful to
		/// avoid using up memory for arrays that are not relevant for the analysis.
		/// </summary>
		// Token: 0x060040E5 RID: 16613 RVA: 0x0005F524 File Offset: 0x0005D724
		public virtual bool GetPreserveIntermediateFunctions()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetPreserveIntermediateFunctions_30(base.GetCppThis()) != 0;
		}

		// Token: 0x060040E6 RID: 16614
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetQFileName_31(HandleRef pThis);

		/// <summary>
		/// Set/Get the PLOT3D solution filename. This adds a filename
		/// using the superclass' AddFileName() method. To read a series
		/// of q files, use the AddFileName() interface directly to add
		/// multiple q filenames in the appropriate order. If the files
		/// are of Overflow format, the reader will read the time values
		/// from the files. Otherwise, it will use an integer sequence.
		/// Use a meta reader to support time values for non-Overflow file
		/// sequences.
		/// </summary>
		// Token: 0x060040E7 RID: 16615 RVA: 0x0005F54C File Offset: 0x0005D74C
		public string GetQFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetQFileName_31(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060040E8 RID: 16616
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMultiBlockPLOT3DReader_GetR_32(HandleRef pThis);

		/// <summary>
		/// Set/Get the gas constant. Default is 1.0.
		/// </summary>
		// Token: 0x060040E9 RID: 16617 RVA: 0x0005F588 File Offset: 0x0005D788
		public virtual double GetR()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetR_32(base.GetCppThis());
		}

		// Token: 0x060040EA RID: 16618
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockPLOT3DReader_GetScalarFunctionNumber_33(HandleRef pThis);

		/// <summary>
		/// Specify the scalar function to extract. If ==(-1), then no scalar
		/// function is extracted.
		/// </summary>
		// Token: 0x060040EB RID: 16619 RVA: 0x0005F5A8 File Offset: 0x0005D7A8
		public virtual int GetScalarFunctionNumber()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetScalarFunctionNumber_33(base.GetCppThis());
		}

		// Token: 0x060040EC RID: 16620
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockPLOT3DReader_GetTwoDimensionalGeometry_34(HandleRef pThis);

		/// <summary>
		/// If only two-dimensional data was written to the file,
		/// turn this on.
		/// </summary>
		// Token: 0x060040ED RID: 16621 RVA: 0x0005F5C8 File Offset: 0x0005D7C8
		public virtual int GetTwoDimensionalGeometry()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetTwoDimensionalGeometry_34(base.GetCppThis());
		}

		// Token: 0x060040EE RID: 16622
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockPLOT3DReader_GetVectorFunctionNumber_35(HandleRef pThis);

		/// <summary>
		/// Specify the vector function to extract. If ==(-1), then no vector
		/// function is extracted.
		/// </summary>
		// Token: 0x060040EF RID: 16623 RVA: 0x0005F5E8 File Offset: 0x0005D7E8
		public virtual int GetVectorFunctionNumber()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetVectorFunctionNumber_35(base.GetCppThis());
		}

		// Token: 0x060040F0 RID: 16624
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetXYZFileName_36(HandleRef pThis);

		/// <summary>
		/// Set/Get the PLOT3D geometry filename.
		/// </summary>
		// Token: 0x060040F1 RID: 16625 RVA: 0x0005F608 File Offset: 0x0005D808
		public virtual string GetXYZFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetXYZFileName_36(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060040F2 RID: 16626
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_HasByteCountOff_37(HandleRef pThis);

		/// <summary>
		/// Were the arrays written with leading and trailing byte counts ?
		/// Usually, files written by a fortran program will contain these
		/// byte counts whereas the ones written by C/C++ won't.
		/// </summary>
		// Token: 0x060040F3 RID: 16627 RVA: 0x0005F642 File Offset: 0x0005D842
		public virtual void HasByteCountOff()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_HasByteCountOff_37(base.GetCppThis());
		}

		// Token: 0x060040F4 RID: 16628
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_HasByteCountOn_38(HandleRef pThis);

		/// <summary>
		/// Were the arrays written with leading and trailing byte counts ?
		/// Usually, files written by a fortran program will contain these
		/// byte counts whereas the ones written by C/C++ won't.
		/// </summary>
		// Token: 0x060040F5 RID: 16629 RVA: 0x0005F651 File Offset: 0x0005D851
		public virtual void HasByteCountOn()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_HasByteCountOn_38(base.GetCppThis());
		}

		// Token: 0x060040F6 RID: 16630
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_IBlankingOff_39(HandleRef pThis);

		/// <summary>
		/// Is there iblanking (point visibility) information in the file.
		/// If there is iblanking arrays, these will be read and assigned
		/// to the PointVisibility array of the output.
		/// </summary>
		// Token: 0x060040F7 RID: 16631 RVA: 0x0005F660 File Offset: 0x0005D860
		public virtual void IBlankingOff()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_IBlankingOff_39(base.GetCppThis());
		}

		// Token: 0x060040F8 RID: 16632
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_IBlankingOn_40(HandleRef pThis);

		/// <summary>
		/// Is there iblanking (point visibility) information in the file.
		/// If there is iblanking arrays, these will be read and assigned
		/// to the PointVisibility array of the output.
		/// </summary>
		// Token: 0x060040F9 RID: 16633 RVA: 0x0005F66F File Offset: 0x0005D86F
		public virtual void IBlankingOn()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_IBlankingOn_40(base.GetCppThis());
		}

		// Token: 0x060040FA RID: 16634
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockPLOT3DReader_IsA_41(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060040FB RID: 16635 RVA: 0x0005F680 File Offset: 0x0005D880
		public override int IsA(string type)
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_IsA_41(base.GetCppThis(), type);
		}

		// Token: 0x060040FC RID: 16636
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockPLOT3DReader_IsTypeOf_42([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060040FD RID: 16637 RVA: 0x0005F6A0 File Offset: 0x0005D8A0
		public new static int IsTypeOf(string type)
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_IsTypeOf_42(type);
		}

		// Token: 0x060040FE RID: 16638
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_MultiGridOff_43(HandleRef pThis);

		/// <summary>
		/// Does the file to be read contain information about number of
		/// grids. In some PLOT3D files, the first value contains the number
		/// of grids (even if there is only 1). If reading such a file,
		/// set this to true.
		/// </summary>
		// Token: 0x060040FF RID: 16639 RVA: 0x0005F6BA File Offset: 0x0005D8BA
		public virtual void MultiGridOff()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_MultiGridOff_43(base.GetCppThis());
		}

		// Token: 0x06004100 RID: 16640
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_MultiGridOn_44(HandleRef pThis);

		/// <summary>
		/// Does the file to be read contain information about number of
		/// grids. In some PLOT3D files, the first value contains the number
		/// of grids (even if there is only 1). If reading such a file,
		/// set this to true.
		/// </summary>
		// Token: 0x06004101 RID: 16641 RVA: 0x0005F6C9 File Offset: 0x0005D8C9
		public virtual void MultiGridOn()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_MultiGridOn_44(base.GetCppThis());
		}

		// Token: 0x06004102 RID: 16642
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockPLOT3DReader_NewInstance_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004103 RID: 16643 RVA: 0x0005F6D8 File Offset: 0x0005D8D8
		public new vtkMultiBlockPLOT3DReader NewInstance()
		{
			vtkMultiBlockPLOT3DReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_NewInstance_46(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockPLOT3DReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004104 RID: 16644
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_PreserveIntermediateFunctionsOff_47(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the reader will preserve intermediate computed
		/// quantities that were not explicitly requested e.g. if `VelocityMagnitude` is
		/// enabled, but not `Velocity`, the reader still needs to compute `Velocity`.
		/// If `PreserveIntermediateFunctions` if false, then the output will not have
		/// `Velocity` array, only the requested `VelocityMagnitude`. This is useful to
		/// avoid using up memory for arrays that are not relevant for the analysis.
		/// </summary>
		// Token: 0x06004105 RID: 16645 RVA: 0x0005F732 File Offset: 0x0005D932
		public virtual void PreserveIntermediateFunctionsOff()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_PreserveIntermediateFunctionsOff_47(base.GetCppThis());
		}

		// Token: 0x06004106 RID: 16646
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_PreserveIntermediateFunctionsOn_48(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the reader will preserve intermediate computed
		/// quantities that were not explicitly requested e.g. if `VelocityMagnitude` is
		/// enabled, but not `Velocity`, the reader still needs to compute `Velocity`.
		/// If `PreserveIntermediateFunctions` if false, then the output will not have
		/// `Velocity` array, only the requested `VelocityMagnitude`. This is useful to
		/// avoid using up memory for arrays that are not relevant for the analysis.
		/// </summary>
		// Token: 0x06004107 RID: 16647 RVA: 0x0005F741 File Offset: 0x0005D941
		public virtual void PreserveIntermediateFunctionsOn()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_PreserveIntermediateFunctionsOn_48(base.GetCppThis());
		}

		// Token: 0x06004108 RID: 16648
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockPLOT3DReader_ReadArrays_49(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

		/// <summary>
		/// These methods have to be overwritten from superclass
		/// because Plot3D actually uses the XYZ file to read these.
		/// This is not recognized by the superclass which returns
		/// an error when a filename (Q filename) is not set.
		/// </summary>
		// Token: 0x06004109 RID: 16649 RVA: 0x0005F750 File Offset: 0x0005D950
		public override int ReadArrays(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_ReadArrays_49(base.GetCppThis(), piece, npieces, nghosts, timestep, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x0600410A RID: 16650
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockPLOT3DReader_ReadMesh_50(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

		/// <summary>
		/// These methods have to be overwritten from superclass
		/// because Plot3D actually uses the XYZ file to read these.
		/// This is not recognized by the superclass which returns
		/// an error when a filename (Q filename) is not set.
		/// </summary>
		// Token: 0x0600410B RID: 16651 RVA: 0x0005F78C File Offset: 0x0005D98C
		public override int ReadMesh(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_ReadMesh_50(base.GetCppThis(), piece, npieces, nghosts, timestep, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x0600410C RID: 16652
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockPLOT3DReader_ReadMetaData_51(HandleRef pThis, HandleRef metadata);

		/// <summary>
		/// These methods have to be overwritten from superclass
		/// because Plot3D actually uses the XYZ file to read these.
		/// This is not recognized by the superclass which returns
		/// an error when a filename (Q filename) is not set.
		/// </summary>
		// Token: 0x0600410D RID: 16653 RVA: 0x0005F7C8 File Offset: 0x0005D9C8
		public override int ReadMetaData(vtkInformation metadata)
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_ReadMetaData_51(base.GetCppThis(), (metadata == null) ? default(HandleRef) : metadata.GetCppThis());
		}

		// Token: 0x0600410E RID: 16654
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockPLOT3DReader_ReadPoints_52(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

		/// <summary>
		/// These methods have to be overwritten from superclass
		/// because Plot3D actually uses the XYZ file to read these.
		/// This is not recognized by the superclass which returns
		/// an error when a filename (Q filename) is not set.
		/// </summary>
		// Token: 0x0600410F RID: 16655 RVA: 0x0005F7FC File Offset: 0x0005D9FC
		public override int ReadPoints(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_ReadPoints_52(base.GetCppThis(), piece, npieces, nghosts, timestep, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06004110 RID: 16656
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_RemoveAllFunctions_53(HandleRef pThis);

		/// <summary>
		/// Specify additional functions to read. These are placed into the
		/// point data as data arrays. Later on they can be used by labeling
		/// them as scalars, etc.
		/// </summary>
		// Token: 0x06004111 RID: 16657 RVA: 0x0005F837 File Offset: 0x0005DA37
		public void RemoveAllFunctions()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_RemoveAllFunctions_53(base.GetCppThis());
		}

		// Token: 0x06004112 RID: 16658
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_RemoveFunction_54(HandleRef pThis, int arg0);

		/// <summary>
		/// Specify additional functions to read. These are placed into the
		/// point data as data arrays. Later on they can be used by labeling
		/// them as scalars, etc.
		/// </summary>
		// Token: 0x06004113 RID: 16659 RVA: 0x0005F846 File Offset: 0x0005DA46
		public void RemoveFunction(int arg0)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_RemoveFunction_54(base.GetCppThis(), arg0);
		}

		// Token: 0x06004114 RID: 16660
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockPLOT3DReader_SafeDownCast_55(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004115 RID: 16661 RVA: 0x0005F858 File Offset: 0x0005DA58
		public new static vtkMultiBlockPLOT3DReader SafeDownCast(vtkObjectBase o)
		{
			vtkMultiBlockPLOT3DReader vtkMultiBlockPLOT3DReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SafeDownCast_55((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiBlockPLOT3DReader = (vtkMultiBlockPLOT3DReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiBlockPLOT3DReader.Register(null);
				}
			}
			return vtkMultiBlockPLOT3DReader;
		}

		// Token: 0x06004116 RID: 16662
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetAutoDetectFormat_56(HandleRef pThis, int _arg);

		/// <summary>
		/// When this option is turned on, the reader will try to figure
		/// out the values of various options such as byte order, byte
		/// count etc. automatically. This options works only for binary
		/// files. When it is turned on, the reader should be able to read
		/// most Plot3D files automatically. The default is OFF for backwards
		/// compatibility reasons. For binary files, it is strongly recommended
		/// that you turn on AutoDetectFormat and leave the other file format
		/// related options untouched.
		/// </summary>
		// Token: 0x06004117 RID: 16663 RVA: 0x0005F8D7 File Offset: 0x0005DAD7
		public virtual void SetAutoDetectFormat(int _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetAutoDetectFormat_56(base.GetCppThis(), _arg);
		}

		// Token: 0x06004118 RID: 16664
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetBinaryFile_57(HandleRef pThis, int _arg);

		/// <summary>
		/// Is the file to be read written in binary format (as opposed
		/// to ascii).
		/// </summary>
		// Token: 0x06004119 RID: 16665 RVA: 0x0005F8E7 File Offset: 0x0005DAE7
		public virtual void SetBinaryFile(int _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetBinaryFile_57(base.GetCppThis(), _arg);
		}

		// Token: 0x0600411A RID: 16666
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetByteOrder_58(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the byte order of the file (remember, more Unix workstations
		/// write big endian whereas PCs write little endian). Default is
		/// big endian (since most older PLOT3D files were written by
		/// workstations).
		/// </summary>
		// Token: 0x0600411B RID: 16667 RVA: 0x0005F8F7 File Offset: 0x0005DAF7
		public virtual void SetByteOrder(int _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetByteOrder_58(base.GetCppThis(), _arg);
		}

		// Token: 0x0600411C RID: 16668
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetByteOrderToBigEndian_59(HandleRef pThis);

		/// <summary>
		/// Set the byte order of the file (remember, more Unix workstations
		/// write big endian whereas PCs write little endian). Default is
		/// big endian (since most older PLOT3D files were written by
		/// workstations).
		/// </summary>
		// Token: 0x0600411D RID: 16669 RVA: 0x0005F907 File Offset: 0x0005DB07
		public void SetByteOrderToBigEndian()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetByteOrderToBigEndian_59(base.GetCppThis());
		}

		// Token: 0x0600411E RID: 16670
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetByteOrderToLittleEndian_60(HandleRef pThis);

		/// <summary>
		/// Set the byte order of the file (remember, more Unix workstations
		/// write big endian whereas PCs write little endian). Default is
		/// big endian (since most older PLOT3D files were written by
		/// workstations).
		/// </summary>
		// Token: 0x0600411F RID: 16671 RVA: 0x0005F916 File Offset: 0x0005DB16
		public void SetByteOrderToLittleEndian()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetByteOrderToLittleEndian_60(base.GetCppThis());
		}

		// Token: 0x06004120 RID: 16672
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetController_61(HandleRef pThis, HandleRef c);

		/// <summary>
		/// Set/Get the communicator object (we'll use global World controller
		/// if you don't set a different one).
		/// </summary>
		// Token: 0x06004121 RID: 16673 RVA: 0x0005F928 File Offset: 0x0005DB28
		public void SetController(vtkMultiProcessController c)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetController_61(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		// Token: 0x06004122 RID: 16674
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetDoublePrecision_62(HandleRef pThis, int _arg);

		/// <summary>
		/// Is this file in double precision or single precision.
		/// This only matters for binary files.
		/// Default is single.
		/// </summary>
		// Token: 0x06004123 RID: 16675 RVA: 0x0005F957 File Offset: 0x0005DB57
		public virtual void SetDoublePrecision(int _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetDoublePrecision_62(base.GetCppThis(), _arg);
		}

		// Token: 0x06004124 RID: 16676
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetFileName_63(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/Get the PLOT3D geometry filename.
		/// </summary>
		// Token: 0x06004125 RID: 16677 RVA: 0x0005F967 File Offset: 0x0005DB67
		public void SetFileName(string name)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetFileName_63(base.GetCppThis(), name);
		}

		// Token: 0x06004126 RID: 16678
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetForceRead_64(HandleRef pThis, int _arg);

		/// <summary>
		/// Try to read a binary file even if the file length seems to be
		/// inconsistent with the header information. Use this with caution,
		/// if the file length is not the same as calculated from the header.
		/// either the file is corrupt or the settings are wrong.
		/// </summary>
		// Token: 0x06004127 RID: 16679 RVA: 0x0005F977 File Offset: 0x0005DB77
		public virtual void SetForceRead(int _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetForceRead_64(base.GetCppThis(), _arg);
		}

		// Token: 0x06004128 RID: 16680
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetFunctionFileName_65(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the PLOT3D function filename.
		/// </summary>
		// Token: 0x06004129 RID: 16681 RVA: 0x0005F987 File Offset: 0x0005DB87
		public virtual void SetFunctionFileName(string _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetFunctionFileName_65(base.GetCppThis(), _arg);
		}

		// Token: 0x0600412A RID: 16682
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetGamma_66(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the ratio of specific heats. Default is 1.4.
		/// </summary>
		// Token: 0x0600412B RID: 16683 RVA: 0x0005F997 File Offset: 0x0005DB97
		public virtual void SetGamma(double _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetGamma_66(base.GetCppThis(), _arg);
		}

		// Token: 0x0600412C RID: 16684
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetHasByteCount_67(HandleRef pThis, int _arg);

		/// <summary>
		/// Were the arrays written with leading and trailing byte counts ?
		/// Usually, files written by a fortran program will contain these
		/// byte counts whereas the ones written by C/C++ won't.
		/// </summary>
		// Token: 0x0600412D RID: 16685 RVA: 0x0005F9A7 File Offset: 0x0005DBA7
		public virtual void SetHasByteCount(int _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetHasByteCount_67(base.GetCppThis(), _arg);
		}

		// Token: 0x0600412E RID: 16686
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetIBlanking_68(HandleRef pThis, int _arg);

		/// <summary>
		/// Is there iblanking (point visibility) information in the file.
		/// If there is iblanking arrays, these will be read and assigned
		/// to the PointVisibility array of the output.
		/// </summary>
		// Token: 0x0600412F RID: 16687 RVA: 0x0005F9B7 File Offset: 0x0005DBB7
		public virtual void SetIBlanking(int _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetIBlanking_68(base.GetCppThis(), _arg);
		}

		// Token: 0x06004130 RID: 16688
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetMultiGrid_69(HandleRef pThis, int _arg);

		/// <summary>
		/// Does the file to be read contain information about number of
		/// grids. In some PLOT3D files, the first value contains the number
		/// of grids (even if there is only 1). If reading such a file,
		/// set this to true.
		/// </summary>
		// Token: 0x06004131 RID: 16689 RVA: 0x0005F9C7 File Offset: 0x0005DBC7
		public virtual void SetMultiGrid(int _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetMultiGrid_69(base.GetCppThis(), _arg);
		}

		// Token: 0x06004132 RID: 16690
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetPreserveIntermediateFunctions_70(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true (default), the reader will preserve intermediate computed
		/// quantities that were not explicitly requested e.g. if `VelocityMagnitude` is
		/// enabled, but not `Velocity`, the reader still needs to compute `Velocity`.
		/// If `PreserveIntermediateFunctions` if false, then the output will not have
		/// `Velocity` array, only the requested `VelocityMagnitude`. This is useful to
		/// avoid using up memory for arrays that are not relevant for the analysis.
		/// </summary>
		// Token: 0x06004133 RID: 16691 RVA: 0x0005F9D7 File Offset: 0x0005DBD7
		public virtual void SetPreserveIntermediateFunctions(bool _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetPreserveIntermediateFunctions_70(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06004134 RID: 16692
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetQFileName_71(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/Get the PLOT3D solution filename. This adds a filename
		/// using the superclass' AddFileName() method. To read a series
		/// of q files, use the AddFileName() interface directly to add
		/// multiple q filenames in the appropriate order. If the files
		/// are of Overflow format, the reader will read the time values
		/// from the files. Otherwise, it will use an integer sequence.
		/// Use a meta reader to support time values for non-Overflow file
		/// sequences.
		/// </summary>
		// Token: 0x06004135 RID: 16693 RVA: 0x0005F9EF File Offset: 0x0005DBEF
		public void SetQFileName(string name)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetQFileName_71(base.GetCppThis(), name);
		}

		// Token: 0x06004136 RID: 16694
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetR_72(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the gas constant. Default is 1.0.
		/// </summary>
		// Token: 0x06004137 RID: 16695 RVA: 0x0005F9FF File Offset: 0x0005DBFF
		public virtual void SetR(double _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetR_72(base.GetCppThis(), _arg);
		}

		// Token: 0x06004138 RID: 16696
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetScalarFunctionNumber_73(HandleRef pThis, int num);

		/// <summary>
		/// Specify the scalar function to extract. If ==(-1), then no scalar
		/// function is extracted.
		/// </summary>
		// Token: 0x06004139 RID: 16697 RVA: 0x0005FA0F File Offset: 0x0005DC0F
		public void SetScalarFunctionNumber(int num)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetScalarFunctionNumber_73(base.GetCppThis(), num);
		}

		// Token: 0x0600413A RID: 16698
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetTwoDimensionalGeometry_74(HandleRef pThis, int _arg);

		/// <summary>
		/// If only two-dimensional data was written to the file,
		/// turn this on.
		/// </summary>
		// Token: 0x0600413B RID: 16699 RVA: 0x0005FA1F File Offset: 0x0005DC1F
		public virtual void SetTwoDimensionalGeometry(int _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetTwoDimensionalGeometry_74(base.GetCppThis(), _arg);
		}

		// Token: 0x0600413C RID: 16700
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetVectorFunctionNumber_75(HandleRef pThis, int num);

		/// <summary>
		/// Specify the vector function to extract. If ==(-1), then no vector
		/// function is extracted.
		/// </summary>
		// Token: 0x0600413D RID: 16701 RVA: 0x0005FA2F File Offset: 0x0005DC2F
		public void SetVectorFunctionNumber(int num)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetVectorFunctionNumber_75(base.GetCppThis(), num);
		}

		// Token: 0x0600413E RID: 16702
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_SetXYZFileName_76(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Set/Get the PLOT3D geometry filename.
		/// </summary>
		// Token: 0x0600413F RID: 16703 RVA: 0x0005FA3F File Offset: 0x0005DC3F
		public virtual void SetXYZFileName(string arg0)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetXYZFileName_76(base.GetCppThis(), arg0);
		}

		// Token: 0x06004140 RID: 16704
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_TwoDimensionalGeometryOff_77(HandleRef pThis);

		/// <summary>
		/// If only two-dimensional data was written to the file,
		/// turn this on.
		/// </summary>
		// Token: 0x06004141 RID: 16705 RVA: 0x0005FA4F File Offset: 0x0005DC4F
		public virtual void TwoDimensionalGeometryOff()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_TwoDimensionalGeometryOff_77(base.GetCppThis());
		}

		// Token: 0x06004142 RID: 16706
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockPLOT3DReader_TwoDimensionalGeometryOn_78(HandleRef pThis);

		/// <summary>
		/// If only two-dimensional data was written to the file,
		/// turn this on.
		/// </summary>
		// Token: 0x06004143 RID: 16707 RVA: 0x0005FA5E File Offset: 0x0005DC5E
		public virtual void TwoDimensionalGeometryOn()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_TwoDimensionalGeometryOn_78(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006EC RID: 1772
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiBlockPLOT3DReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006ED RID: 1773
		public new static readonly string MRClassNameKey = "class vtkMultiBlockPLOT3DReader";

		/// <summary>
		/// Set/Get the communicator object (we'll use global World controller
		/// if you don't set a different one).
		/// </summary>
		// Token: 0x02000155 RID: 341
		public enum FILE_BIG_ENDIAN_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040006EF RID: 1775
			FILE_BIG_ENDIAN,
			/// <summary>enum member</summary>
			// Token: 0x040006F0 RID: 1776
			FILE_LITTLE_ENDIAN
		}
	}
}
