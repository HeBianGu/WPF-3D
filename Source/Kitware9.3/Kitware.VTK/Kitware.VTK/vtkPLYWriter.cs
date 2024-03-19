using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPLYWriter
	/// </summary>
	/// <remarks>
	///    write Stanford PLY file format
	///
	/// vtkPLYWriter writes polygonal data in Stanford University PLY format
	/// (see http://graphics.stanford.edu/data/3Dscanrep/). The data can be
	/// written in either binary (little or big endian) or ASCII representation.
	/// As for PointData and CellData, vtkPLYWriter cannot handle normals or
	/// vectors. It only handles RGB PointData and CellData. You need to set the
	/// name of the array (using SetName for the array and SetArrayName for the
	/// writer). If the array is not a vtkUnsignedCharArray with 3 or 4 components,
	/// you need to specify a vtkLookupTable to map the scalars to RGB.
	///
	/// To enable saving out alpha (opacity) values, you must enable alpha using
	/// `vtkPLYWriter::SetEnableAlpha()`.
	///
	/// @warning
	/// PLY does not handle big endian versus little endian correctly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPLYReader
	/// </seealso>
	// Token: 0x02000167 RID: 359
	public class vtkPLYWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004449 RID: 17481 RVA: 0x00063C8B File Offset: 0x00061E8B
		static vtkPLYWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPLYWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPLYWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600444A RID: 17482 RVA: 0x00063CB3 File Offset: 0x00061EB3
		public vtkPLYWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600444B RID: 17483
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPLYWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600444C RID: 17484 RVA: 0x00063CC4 File Offset: 0x00061EC4
		public new static vtkPLYWriter New()
		{
			vtkPLYWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPLYWriter.vtkPLYWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPLYWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600444D RID: 17485 RVA: 0x00063D18 File Offset: 0x00061F18
		public vtkPLYWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPLYWriter.vtkPLYWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600444E RID: 17486 RVA: 0x00063D5C File Offset: 0x00061F5C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600444F RID: 17487
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_AddComment_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string comment);

		/// <summary>
		/// Add a comment in the header part.
		/// </summary>
		// Token: 0x06004450 RID: 17488 RVA: 0x00063D67 File Offset: 0x00061F67
		public void AddComment(string comment)
		{
			vtkPLYWriter.vtkPLYWriter_AddComment_01(base.GetCppThis(), comment);
		}

		// Token: 0x06004451 RID: 17489
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_EnableAlphaOff_02(HandleRef pThis);

		/// <summary>
		/// Enable alpha output. Default is off, i.e. only color values will be saved
		/// based on ColorMode.
		/// </summary>
		// Token: 0x06004452 RID: 17490 RVA: 0x00063D77 File Offset: 0x00061F77
		public virtual void EnableAlphaOff()
		{
			vtkPLYWriter.vtkPLYWriter_EnableAlphaOff_02(base.GetCppThis());
		}

		// Token: 0x06004453 RID: 17491
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_EnableAlphaOn_03(HandleRef pThis);

		/// <summary>
		/// Enable alpha output. Default is off, i.e. only color values will be saved
		/// based on ColorMode.
		/// </summary>
		// Token: 0x06004454 RID: 17492 RVA: 0x00063D86 File Offset: 0x00061F86
		public virtual void EnableAlphaOn()
		{
			vtkPLYWriter.vtkPLYWriter_EnableAlphaOn_03(base.GetCppThis());
		}

		// Token: 0x06004455 RID: 17493
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPLYWriter_GetAlpha_04(HandleRef pThis);

		/// <summary>
		///  both) and EnableAlpha is ON.
		/// </summary>
		// Token: 0x06004456 RID: 17494 RVA: 0x00063D98 File Offset: 0x00061F98
		public virtual byte GetAlpha()
		{
			return vtkPLYWriter.vtkPLYWriter_GetAlpha_04(base.GetCppThis());
		}

		// Token: 0x06004457 RID: 17495
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPLYWriter_GetArrayName_05(HandleRef pThis);

		/// <summary>
		/// Specify the array name to use to color the data.
		/// </summary>
		// Token: 0x06004458 RID: 17496 RVA: 0x00063DB8 File Offset: 0x00061FB8
		public virtual string GetArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkPLYWriter.vtkPLYWriter_GetArrayName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004459 RID: 17497
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPLYWriter_GetColor_06(HandleRef pThis);

		/// <summary>
		/// Set the color to use when using a uniform color (either point or cells,
		/// or both). The color is specified as a triplet of three unsigned chars
		/// between (0,255). This only takes effect when the ColorMode is set to
		/// uniform point, uniform cell, or uniform color.
		/// </summary>
		// Token: 0x0600445A RID: 17498 RVA: 0x00063DF4 File Offset: 0x00061FF4
		public virtual byte[] GetColor()
		{
			IntPtr intPtr = vtkPLYWriter.vtkPLYWriter_GetColor_06(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600445B RID: 17499
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_GetColor_07(HandleRef pThis, ref byte _arg1, ref byte _arg2, ref byte _arg3);

		/// <summary>
		/// Set the color to use when using a uniform color (either point or cells,
		/// or both). The color is specified as a triplet of three unsigned chars
		/// between (0,255). This only takes effect when the ColorMode is set to
		/// uniform point, uniform cell, or uniform color.
		/// </summary>
		// Token: 0x0600445C RID: 17500 RVA: 0x00063E3C File Offset: 0x0006203C
		public virtual void GetColor(ref byte _arg1, ref byte _arg2, ref byte _arg3)
		{
			vtkPLYWriter.vtkPLYWriter_GetColor_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600445D RID: 17501
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_GetColor_08(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color to use when using a uniform color (either point or cells,
		/// or both). The color is specified as a triplet of three unsigned chars
		/// between (0,255). This only takes effect when the ColorMode is set to
		/// uniform point, uniform cell, or uniform color.
		/// </summary>
		// Token: 0x0600445E RID: 17502 RVA: 0x00063E4E File Offset: 0x0006204E
		public virtual void GetColor(IntPtr _arg)
		{
			vtkPLYWriter.vtkPLYWriter_GetColor_08(base.GetCppThis(), _arg);
		}

		// Token: 0x0600445F RID: 17503
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLYWriter_GetColorMode_09(HandleRef pThis);

		/// <summary>
		/// These methods enable the user to control how to add color into the PLY
		/// output file. The default behavior is as follows. The user provides the
		/// name of an array and a component number. If the type of the array is
		/// three components, unsigned char, then the data is written as three
		/// separate "red", "green" and "blue" properties. If the type of the array is
		/// four components, unsigned char, then the data is written as three separate
		/// "red", "green" and "blue" properties, dropping the "alpha". If the type is not
		/// unsigned char, and a lookup table is provided, then the array/component
		/// are mapped through the table to generate three separate "red", "green"
		/// and "blue" properties in the PLY file. The user can also set the
		/// ColorMode to specify a uniform color for the whole part (on a vertex
		/// colors, face colors, or both. (Note: vertex colors or cell colors may be
		/// written, depending on where the named array is found. If points and
		/// cells have the arrays with the same name, then both colors will be
		/// written.)
		/// </summary>
		// Token: 0x06004460 RID: 17504 RVA: 0x00063E60 File Offset: 0x00062060
		public virtual int GetColorMode()
		{
			return vtkPLYWriter.vtkPLYWriter_GetColorMode_09(base.GetCppThis());
		}

		// Token: 0x06004461 RID: 17505
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLYWriter_GetComponent_10(HandleRef pThis);

		/// <summary>
		/// Specify the array component to use to color the data.
		/// </summary>
		// Token: 0x06004462 RID: 17506 RVA: 0x00063E80 File Offset: 0x00062080
		public virtual int GetComponent()
		{
			return vtkPLYWriter.vtkPLYWriter_GetComponent_10(base.GetCppThis());
		}

		// Token: 0x06004463 RID: 17507
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLYWriter_GetComponentMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Specify the array component to use to color the data.
		/// </summary>
		// Token: 0x06004464 RID: 17508 RVA: 0x00063EA0 File Offset: 0x000620A0
		public virtual int GetComponentMaxValue()
		{
			return vtkPLYWriter.vtkPLYWriter_GetComponentMaxValue_11(base.GetCppThis());
		}

		// Token: 0x06004465 RID: 17509
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLYWriter_GetComponentMinValue_12(HandleRef pThis);

		/// <summary>
		/// Specify the array component to use to color the data.
		/// </summary>
		// Token: 0x06004466 RID: 17510 RVA: 0x00063EC0 File Offset: 0x000620C0
		public virtual int GetComponentMinValue()
		{
			return vtkPLYWriter.vtkPLYWriter_GetComponentMinValue_12(base.GetCppThis());
		}

		// Token: 0x06004467 RID: 17511
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLYWriter_GetDataByteOrder_13(HandleRef pThis);

		/// <summary>
		/// If the file type is binary, then the user can specify which
		/// byte order to use (little versus big endian).
		/// </summary>
		// Token: 0x06004468 RID: 17512 RVA: 0x00063EE0 File Offset: 0x000620E0
		public virtual int GetDataByteOrder()
		{
			return vtkPLYWriter.vtkPLYWriter_GetDataByteOrder_13(base.GetCppThis());
		}

		// Token: 0x06004469 RID: 17513
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLYWriter_GetDataByteOrderMaxValue_14(HandleRef pThis);

		/// <summary>
		/// If the file type is binary, then the user can specify which
		/// byte order to use (little versus big endian).
		/// </summary>
		// Token: 0x0600446A RID: 17514 RVA: 0x00063F00 File Offset: 0x00062100
		public virtual int GetDataByteOrderMaxValue()
		{
			return vtkPLYWriter.vtkPLYWriter_GetDataByteOrderMaxValue_14(base.GetCppThis());
		}

		// Token: 0x0600446B RID: 17515
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLYWriter_GetDataByteOrderMinValue_15(HandleRef pThis);

		/// <summary>
		/// If the file type is binary, then the user can specify which
		/// byte order to use (little versus big endian).
		/// </summary>
		// Token: 0x0600446C RID: 17516 RVA: 0x00063F20 File Offset: 0x00062120
		public virtual int GetDataByteOrderMinValue()
		{
			return vtkPLYWriter.vtkPLYWriter_GetDataByteOrderMinValue_15(base.GetCppThis());
		}

		// Token: 0x0600446D RID: 17517
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPLYWriter_GetEnableAlpha_16(HandleRef pThis);

		/// <summary>
		/// Enable alpha output. Default is off, i.e. only color values will be saved
		/// based on ColorMode.
		/// </summary>
		// Token: 0x0600446E RID: 17518 RVA: 0x00063F40 File Offset: 0x00062140
		public virtual bool GetEnableAlpha()
		{
			return vtkPLYWriter.vtkPLYWriter_GetEnableAlpha_16(base.GetCppThis()) != 0;
		}

		// Token: 0x0600446F RID: 17519
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPLYWriter_GetFileName_17(HandleRef pThis);

		/// <summary>
		/// Specify file name of vtk polygon data file to write.
		/// </summary>
		// Token: 0x06004470 RID: 17520 RVA: 0x00063F68 File Offset: 0x00062168
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkPLYWriter.vtkPLYWriter_GetFileName_17(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004471 RID: 17521
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLYWriter_GetFileType_18(HandleRef pThis);

		/// <summary>
		/// Specify file type (ASCII or BINARY) for vtk data file.
		/// </summary>
		// Token: 0x06004472 RID: 17522 RVA: 0x00063FA4 File Offset: 0x000621A4
		public virtual int GetFileType()
		{
			return vtkPLYWriter.vtkPLYWriter_GetFileType_18(base.GetCppThis());
		}

		// Token: 0x06004473 RID: 17523
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLYWriter_GetFileTypeMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Specify file type (ASCII or BINARY) for vtk data file.
		/// </summary>
		// Token: 0x06004474 RID: 17524 RVA: 0x00063FC4 File Offset: 0x000621C4
		public virtual int GetFileTypeMaxValue()
		{
			return vtkPLYWriter.vtkPLYWriter_GetFileTypeMaxValue_19(base.GetCppThis());
		}

		// Token: 0x06004475 RID: 17525
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLYWriter_GetFileTypeMinValue_20(HandleRef pThis);

		/// <summary>
		/// Specify file type (ASCII or BINARY) for vtk data file.
		/// </summary>
		// Token: 0x06004476 RID: 17526 RVA: 0x00063FE4 File Offset: 0x000621E4
		public virtual int GetFileTypeMinValue()
		{
			return vtkPLYWriter.vtkPLYWriter_GetFileTypeMinValue_20(base.GetCppThis());
		}

		// Token: 0x06004477 RID: 17527
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPLYWriter_GetInput_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x06004478 RID: 17528 RVA: 0x00064004 File Offset: 0x00062204
		public new vtkPolyData GetInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPLYWriter.vtkPLYWriter_GetInput_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004479 RID: 17529
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPLYWriter_GetInput_22(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x0600447A RID: 17530 RVA: 0x00064074 File Offset: 0x00062274
		public new vtkPolyData GetInput(int port)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPLYWriter.vtkPLYWriter_GetInput_22(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600447B RID: 17531
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPLYWriter_GetLookupTable_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A lookup table can be specified in order to convert data arrays to
		/// RGBA colors.
		/// </summary>
		// Token: 0x0600447C RID: 17532 RVA: 0x000640E4 File Offset: 0x000622E4
		public virtual vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPLYWriter.vtkPLYWriter_GetLookupTable_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		// Token: 0x0600447D RID: 17533
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPLYWriter_GetNumberOfGenerationsFromBase_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600447E RID: 17534 RVA: 0x00064154 File Offset: 0x00062354
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPLYWriter.vtkPLYWriter_GetNumberOfGenerationsFromBase_24(base.GetCppThis(), type);
		}

		// Token: 0x0600447F RID: 17535
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPLYWriter_GetNumberOfGenerationsFromBaseType_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004480 RID: 17536 RVA: 0x00064174 File Offset: 0x00062374
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPLYWriter.vtkPLYWriter_GetNumberOfGenerationsFromBaseType_25(type);
		}

		// Token: 0x06004481 RID: 17537
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPLYWriter_GetOutputString_26(HandleRef pThis);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// Note that writing to an output stream would be more flexible (enabling
		/// other kind of streams) and possibly more efficient because we don't need
		/// to write the whole stream to a string. However a stream interface
		/// does not translate well to python and the string interface satisfies
		/// our current needs. So we leave the stream interface for future work.
		/// </summary>
		// Token: 0x06004482 RID: 17538 RVA: 0x00064190 File Offset: 0x00062390
		public string GetOutputString()
		{
			return vtkPLYWriter.vtkPLYWriter_GetOutputString_26(base.GetCppThis());
		}

		// Token: 0x06004483 RID: 17539
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLYWriter_GetTextureCoordinatesName_27(HandleRef pThis);

		/// <summary>
		/// Choose the name used for the texture coordinates.
		/// (u, v) or (texture_u, texture_v)
		/// </summary>
		// Token: 0x06004484 RID: 17540 RVA: 0x000641B0 File Offset: 0x000623B0
		public virtual int GetTextureCoordinatesName()
		{
			return vtkPLYWriter.vtkPLYWriter_GetTextureCoordinatesName_27(base.GetCppThis());
		}

		// Token: 0x06004485 RID: 17541
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLYWriter_GetTextureCoordinatesNameMaxValue_28(HandleRef pThis);

		/// <summary>
		/// Choose the name used for the texture coordinates.
		/// (u, v) or (texture_u, texture_v)
		/// </summary>
		// Token: 0x06004486 RID: 17542 RVA: 0x000641D0 File Offset: 0x000623D0
		public virtual int GetTextureCoordinatesNameMaxValue()
		{
			return vtkPLYWriter.vtkPLYWriter_GetTextureCoordinatesNameMaxValue_28(base.GetCppThis());
		}

		// Token: 0x06004487 RID: 17543
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLYWriter_GetTextureCoordinatesNameMinValue_29(HandleRef pThis);

		/// <summary>
		/// Choose the name used for the texture coordinates.
		/// (u, v) or (texture_u, texture_v)
		/// </summary>
		// Token: 0x06004488 RID: 17544 RVA: 0x000641F0 File Offset: 0x000623F0
		public virtual int GetTextureCoordinatesNameMinValue()
		{
			return vtkPLYWriter.vtkPLYWriter_GetTextureCoordinatesNameMinValue_29(base.GetCppThis());
		}

		// Token: 0x06004489 RID: 17545
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPLYWriter_GetWriteObjectInformation_30(HandleRef pThis);

		/// <summary>
		/// Enable writing the 'obj_info' in the header. Default is on.
		/// Note that some software is unable to read ply files with the 'obj_info' included.
		/// </summary>
		// Token: 0x0600448A RID: 17546 RVA: 0x00064210 File Offset: 0x00062410
		public virtual bool GetWriteObjectInformation()
		{
			return vtkPLYWriter.vtkPLYWriter_GetWriteObjectInformation_30(base.GetCppThis()) != 0;
		}

		// Token: 0x0600448B RID: 17547
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPLYWriter_GetWriteToOutputString_31(HandleRef pThis);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// Note that writing to an output stream would be more flexible (enabling
		/// other kind of streams) and possibly more efficient because we don't need
		/// to write the whole stream to a string. However a stream interface
		/// does not translate well to python and the string interface satisfies
		/// our current needs. So we leave the stream interface for future work.
		/// </summary>
		// Token: 0x0600448C RID: 17548 RVA: 0x00064238 File Offset: 0x00062438
		public virtual bool GetWriteToOutputString()
		{
			return vtkPLYWriter.vtkPLYWriter_GetWriteToOutputString_31(base.GetCppThis()) != 0;
		}

		// Token: 0x0600448D RID: 17549
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLYWriter_IsA_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600448E RID: 17550 RVA: 0x00064260 File Offset: 0x00062460
		public override int IsA(string type)
		{
			return vtkPLYWriter.vtkPLYWriter_IsA_32(base.GetCppThis(), type);
		}

		// Token: 0x0600448F RID: 17551
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLYWriter_IsTypeOf_33([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004490 RID: 17552 RVA: 0x00064280 File Offset: 0x00062480
		public new static int IsTypeOf(string type)
		{
			return vtkPLYWriter.vtkPLYWriter_IsTypeOf_33(type);
		}

		// Token: 0x06004491 RID: 17553
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPLYWriter_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004492 RID: 17554 RVA: 0x0006429C File Offset: 0x0006249C
		public new vtkPLYWriter NewInstance()
		{
			vtkPLYWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPLYWriter.vtkPLYWriter_NewInstance_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPLYWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004493 RID: 17555
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPLYWriter_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004494 RID: 17556 RVA: 0x000642F8 File Offset: 0x000624F8
		public new static vtkPLYWriter SafeDownCast(vtkObjectBase o)
		{
			vtkPLYWriter vtkPLYWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPLYWriter.vtkPLYWriter_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPLYWriter = (vtkPLYWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPLYWriter.Register(null);
				}
			}
			return vtkPLYWriter;
		}

		// Token: 0x06004495 RID: 17557
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetAlpha_37(HandleRef pThis, byte _arg);

		/// <summary>
		///  both) and EnableAlpha is ON.
		/// </summary>
		// Token: 0x06004496 RID: 17558 RVA: 0x00064377 File Offset: 0x00062577
		public virtual void SetAlpha(byte _arg)
		{
			vtkPLYWriter.vtkPLYWriter_SetAlpha_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06004497 RID: 17559
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetArrayName_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the array name to use to color the data.
		/// </summary>
		// Token: 0x06004498 RID: 17560 RVA: 0x00064387 File Offset: 0x00062587
		public virtual void SetArrayName(string _arg)
		{
			vtkPLYWriter.vtkPLYWriter_SetArrayName_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06004499 RID: 17561
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetColor_39(HandleRef pThis, byte _arg1, byte _arg2, byte _arg3);

		/// <summary>
		/// Set the color to use when using a uniform color (either point or cells,
		/// or both). The color is specified as a triplet of three unsigned chars
		/// between (0,255). This only takes effect when the ColorMode is set to
		/// uniform point, uniform cell, or uniform color.
		/// </summary>
		// Token: 0x0600449A RID: 17562 RVA: 0x00064397 File Offset: 0x00062597
		public virtual void SetColor(byte _arg1, byte _arg2, byte _arg3)
		{
			vtkPLYWriter.vtkPLYWriter_SetColor_39(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600449B RID: 17563
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetColor_40(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color to use when using a uniform color (either point or cells,
		/// or both). The color is specified as a triplet of three unsigned chars
		/// between (0,255). This only takes effect when the ColorMode is set to
		/// uniform point, uniform cell, or uniform color.
		/// </summary>
		// Token: 0x0600449C RID: 17564 RVA: 0x000643A9 File Offset: 0x000625A9
		public virtual void SetColor(IntPtr _arg)
		{
			vtkPLYWriter.vtkPLYWriter_SetColor_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0600449D RID: 17565
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetColorMode_41(HandleRef pThis, int _arg);

		/// <summary>
		/// These methods enable the user to control how to add color into the PLY
		/// output file. The default behavior is as follows. The user provides the
		/// name of an array and a component number. If the type of the array is
		/// three components, unsigned char, then the data is written as three
		/// separate "red", "green" and "blue" properties. If the type of the array is
		/// four components, unsigned char, then the data is written as three separate
		/// "red", "green" and "blue" properties, dropping the "alpha". If the type is not
		/// unsigned char, and a lookup table is provided, then the array/component
		/// are mapped through the table to generate three separate "red", "green"
		/// and "blue" properties in the PLY file. The user can also set the
		/// ColorMode to specify a uniform color for the whole part (on a vertex
		/// colors, face colors, or both. (Note: vertex colors or cell colors may be
		/// written, depending on where the named array is found. If points and
		/// cells have the arrays with the same name, then both colors will be
		/// written.)
		/// </summary>
		// Token: 0x0600449E RID: 17566 RVA: 0x000643B9 File Offset: 0x000625B9
		public virtual void SetColorMode(int _arg)
		{
			vtkPLYWriter.vtkPLYWriter_SetColorMode_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600449F RID: 17567
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetColorModeToDefault_42(HandleRef pThis);

		/// <summary>
		/// These methods enable the user to control how to add color into the PLY
		/// output file. The default behavior is as follows. The user provides the
		/// name of an array and a component number. If the type of the array is
		/// three components, unsigned char, then the data is written as three
		/// separate "red", "green" and "blue" properties. If the type of the array is
		/// four components, unsigned char, then the data is written as three separate
		/// "red", "green" and "blue" properties, dropping the "alpha". If the type is not
		/// unsigned char, and a lookup table is provided, then the array/component
		/// are mapped through the table to generate three separate "red", "green"
		/// and "blue" properties in the PLY file. The user can also set the
		/// ColorMode to specify a uniform color for the whole part (on a vertex
		/// colors, face colors, or both. (Note: vertex colors or cell colors may be
		/// written, depending on where the named array is found. If points and
		/// cells have the arrays with the same name, then both colors will be
		/// written.)
		/// </summary>
		// Token: 0x060044A0 RID: 17568 RVA: 0x000643C9 File Offset: 0x000625C9
		public void SetColorModeToDefault()
		{
			vtkPLYWriter.vtkPLYWriter_SetColorModeToDefault_42(base.GetCppThis());
		}

		// Token: 0x060044A1 RID: 17569
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetColorModeToOff_43(HandleRef pThis);

		/// <summary>
		/// These methods enable the user to control how to add color into the PLY
		/// output file. The default behavior is as follows. The user provides the
		/// name of an array and a component number. If the type of the array is
		/// three components, unsigned char, then the data is written as three
		/// separate "red", "green" and "blue" properties. If the type of the array is
		/// four components, unsigned char, then the data is written as three separate
		/// "red", "green" and "blue" properties, dropping the "alpha". If the type is not
		/// unsigned char, and a lookup table is provided, then the array/component
		/// are mapped through the table to generate three separate "red", "green"
		/// and "blue" properties in the PLY file. The user can also set the
		/// ColorMode to specify a uniform color for the whole part (on a vertex
		/// colors, face colors, or both. (Note: vertex colors or cell colors may be
		/// written, depending on where the named array is found. If points and
		/// cells have the arrays with the same name, then both colors will be
		/// written.)
		/// </summary>
		// Token: 0x060044A2 RID: 17570 RVA: 0x000643D8 File Offset: 0x000625D8
		public void SetColorModeToOff()
		{
			vtkPLYWriter.vtkPLYWriter_SetColorModeToOff_43(base.GetCppThis());
		}

		// Token: 0x060044A3 RID: 17571
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetColorModeToUniformCellColor_44(HandleRef pThis);

		/// <summary>
		/// These methods enable the user to control how to add color into the PLY
		/// output file. The default behavior is as follows. The user provides the
		/// name of an array and a component number. If the type of the array is
		/// three components, unsigned char, then the data is written as three
		/// separate "red", "green" and "blue" properties. If the type of the array is
		/// four components, unsigned char, then the data is written as three separate
		/// "red", "green" and "blue" properties, dropping the "alpha". If the type is not
		/// unsigned char, and a lookup table is provided, then the array/component
		/// are mapped through the table to generate three separate "red", "green"
		/// and "blue" properties in the PLY file. The user can also set the
		/// ColorMode to specify a uniform color for the whole part (on a vertex
		/// colors, face colors, or both. (Note: vertex colors or cell colors may be
		/// written, depending on where the named array is found. If points and
		/// cells have the arrays with the same name, then both colors will be
		/// written.)
		/// </summary>
		// Token: 0x060044A4 RID: 17572 RVA: 0x000643E7 File Offset: 0x000625E7
		public void SetColorModeToUniformCellColor()
		{
			vtkPLYWriter.vtkPLYWriter_SetColorModeToUniformCellColor_44(base.GetCppThis());
		}

		// Token: 0x060044A5 RID: 17573
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetColorModeToUniformColor_45(HandleRef pThis);

		/// <summary>
		/// These methods enable the user to control how to add color into the PLY
		/// output file. The default behavior is as follows. The user provides the
		/// name of an array and a component number. If the type of the array is
		/// three components, unsigned char, then the data is written as three
		/// separate "red", "green" and "blue" properties. If the type of the array is
		/// four components, unsigned char, then the data is written as three separate
		/// "red", "green" and "blue" properties, dropping the "alpha". If the type is not
		/// unsigned char, and a lookup table is provided, then the array/component
		/// are mapped through the table to generate three separate "red", "green"
		/// and "blue" properties in the PLY file. The user can also set the
		/// ColorMode to specify a uniform color for the whole part (on a vertex
		/// colors, face colors, or both. (Note: vertex colors or cell colors may be
		/// written, depending on where the named array is found. If points and
		/// cells have the arrays with the same name, then both colors will be
		/// written.)
		/// </summary>
		// Token: 0x060044A6 RID: 17574 RVA: 0x000643F6 File Offset: 0x000625F6
		public void SetColorModeToUniformColor()
		{
			vtkPLYWriter.vtkPLYWriter_SetColorModeToUniformColor_45(base.GetCppThis());
		}

		// Token: 0x060044A7 RID: 17575
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetColorModeToUniformPointColor_46(HandleRef pThis);

		/// <summary>
		/// These methods enable the user to control how to add color into the PLY
		/// output file. The default behavior is as follows. The user provides the
		/// name of an array and a component number. If the type of the array is
		/// three components, unsigned char, then the data is written as three
		/// separate "red", "green" and "blue" properties. If the type of the array is
		/// four components, unsigned char, then the data is written as three separate
		/// "red", "green" and "blue" properties, dropping the "alpha". If the type is not
		/// unsigned char, and a lookup table is provided, then the array/component
		/// are mapped through the table to generate three separate "red", "green"
		/// and "blue" properties in the PLY file. The user can also set the
		/// ColorMode to specify a uniform color for the whole part (on a vertex
		/// colors, face colors, or both. (Note: vertex colors or cell colors may be
		/// written, depending on where the named array is found. If points and
		/// cells have the arrays with the same name, then both colors will be
		/// written.)
		/// </summary>
		// Token: 0x060044A8 RID: 17576 RVA: 0x00064405 File Offset: 0x00062605
		public void SetColorModeToUniformPointColor()
		{
			vtkPLYWriter.vtkPLYWriter_SetColorModeToUniformPointColor_46(base.GetCppThis());
		}

		// Token: 0x060044A9 RID: 17577
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetComponent_47(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the array component to use to color the data.
		/// </summary>
		// Token: 0x060044AA RID: 17578 RVA: 0x00064414 File Offset: 0x00062614
		public virtual void SetComponent(int _arg)
		{
			vtkPLYWriter.vtkPLYWriter_SetComponent_47(base.GetCppThis(), _arg);
		}

		// Token: 0x060044AB RID: 17579
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetDataByteOrder_48(HandleRef pThis, int _arg);

		/// <summary>
		/// If the file type is binary, then the user can specify which
		/// byte order to use (little versus big endian).
		/// </summary>
		// Token: 0x060044AC RID: 17580 RVA: 0x00064424 File Offset: 0x00062624
		public virtual void SetDataByteOrder(int _arg)
		{
			vtkPLYWriter.vtkPLYWriter_SetDataByteOrder_48(base.GetCppThis(), _arg);
		}

		// Token: 0x060044AD RID: 17581
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetDataByteOrderToBigEndian_49(HandleRef pThis);

		/// <summary>
		/// If the file type is binary, then the user can specify which
		/// byte order to use (little versus big endian).
		/// </summary>
		// Token: 0x060044AE RID: 17582 RVA: 0x00064434 File Offset: 0x00062634
		public void SetDataByteOrderToBigEndian()
		{
			vtkPLYWriter.vtkPLYWriter_SetDataByteOrderToBigEndian_49(base.GetCppThis());
		}

		// Token: 0x060044AF RID: 17583
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetDataByteOrderToLittleEndian_50(HandleRef pThis);

		/// <summary>
		/// If the file type is binary, then the user can specify which
		/// byte order to use (little versus big endian).
		/// </summary>
		// Token: 0x060044B0 RID: 17584 RVA: 0x00064443 File Offset: 0x00062643
		public void SetDataByteOrderToLittleEndian()
		{
			vtkPLYWriter.vtkPLYWriter_SetDataByteOrderToLittleEndian_50(base.GetCppThis());
		}

		// Token: 0x060044B1 RID: 17585
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetEnableAlpha_51(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable alpha output. Default is off, i.e. only color values will be saved
		/// based on ColorMode.
		/// </summary>
		// Token: 0x060044B2 RID: 17586 RVA: 0x00064452 File Offset: 0x00062652
		public virtual void SetEnableAlpha(bool _arg)
		{
			vtkPLYWriter.vtkPLYWriter_SetEnableAlpha_51(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060044B3 RID: 17587
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetFileName_52(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name of vtk polygon data file to write.
		/// </summary>
		// Token: 0x060044B4 RID: 17588 RVA: 0x0006446A File Offset: 0x0006266A
		public virtual void SetFileName(string _arg)
		{
			vtkPLYWriter.vtkPLYWriter_SetFileName_52(base.GetCppThis(), _arg);
		}

		// Token: 0x060044B5 RID: 17589
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetFileType_53(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify file type (ASCII or BINARY) for vtk data file.
		/// </summary>
		// Token: 0x060044B6 RID: 17590 RVA: 0x0006447A File Offset: 0x0006267A
		public virtual void SetFileType(int _arg)
		{
			vtkPLYWriter.vtkPLYWriter_SetFileType_53(base.GetCppThis(), _arg);
		}

		// Token: 0x060044B7 RID: 17591
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetFileTypeToASCII_54(HandleRef pThis);

		/// <summary>
		/// Specify file type (ASCII or BINARY) for vtk data file.
		/// </summary>
		// Token: 0x060044B8 RID: 17592 RVA: 0x0006448A File Offset: 0x0006268A
		public void SetFileTypeToASCII()
		{
			vtkPLYWriter.vtkPLYWriter_SetFileTypeToASCII_54(base.GetCppThis());
		}

		// Token: 0x060044B9 RID: 17593
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetFileTypeToBinary_55(HandleRef pThis);

		/// <summary>
		/// Specify file type (ASCII or BINARY) for vtk data file.
		/// </summary>
		// Token: 0x060044BA RID: 17594 RVA: 0x00064499 File Offset: 0x00062699
		public void SetFileTypeToBinary()
		{
			vtkPLYWriter.vtkPLYWriter_SetFileTypeToBinary_55(base.GetCppThis());
		}

		// Token: 0x060044BB RID: 17595
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetLookupTable_56(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// A lookup table can be specified in order to convert data arrays to
		/// RGBA colors.
		/// </summary>
		// Token: 0x060044BC RID: 17596 RVA: 0x000644A8 File Offset: 0x000626A8
		public virtual void SetLookupTable(vtkScalarsToColors arg0)
		{
			vtkPLYWriter.vtkPLYWriter_SetLookupTable_56(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060044BD RID: 17597
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetTextureCoordinatesName_57(HandleRef pThis, int _arg);

		/// <summary>
		/// Choose the name used for the texture coordinates.
		/// (u, v) or (texture_u, texture_v)
		/// </summary>
		// Token: 0x060044BE RID: 17598 RVA: 0x000644D7 File Offset: 0x000626D7
		public virtual void SetTextureCoordinatesName(int _arg)
		{
			vtkPLYWriter.vtkPLYWriter_SetTextureCoordinatesName_57(base.GetCppThis(), _arg);
		}

		// Token: 0x060044BF RID: 17599
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetTextureCoordinatesNameToTextureUV_58(HandleRef pThis);

		/// <summary>
		/// Choose the name used for the texture coordinates.
		/// (u, v) or (texture_u, texture_v)
		/// </summary>
		// Token: 0x060044C0 RID: 17600 RVA: 0x000644E7 File Offset: 0x000626E7
		public void SetTextureCoordinatesNameToTextureUV()
		{
			vtkPLYWriter.vtkPLYWriter_SetTextureCoordinatesNameToTextureUV_58(base.GetCppThis());
		}

		// Token: 0x060044C1 RID: 17601
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetTextureCoordinatesNameToUV_59(HandleRef pThis);

		/// <summary>
		/// Choose the name used for the texture coordinates.
		/// (u, v) or (texture_u, texture_v)
		/// </summary>
		// Token: 0x060044C2 RID: 17602 RVA: 0x000644F6 File Offset: 0x000626F6
		public void SetTextureCoordinatesNameToUV()
		{
			vtkPLYWriter.vtkPLYWriter_SetTextureCoordinatesNameToUV_59(base.GetCppThis());
		}

		// Token: 0x060044C3 RID: 17603
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetWriteObjectInformation_60(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable writing the 'obj_info' in the header. Default is on.
		/// Note that some software is unable to read ply files with the 'obj_info' included.
		/// </summary>
		// Token: 0x060044C4 RID: 17604 RVA: 0x00064505 File Offset: 0x00062705
		public virtual void SetWriteObjectInformation(bool _arg)
		{
			vtkPLYWriter.vtkPLYWriter_SetWriteObjectInformation_60(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060044C5 RID: 17605
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_SetWriteToOutputString_61(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// Note that writing to an output stream would be more flexible (enabling
		/// other kind of streams) and possibly more efficient because we don't need
		/// to write the whole stream to a string. However a stream interface
		/// does not translate well to python and the string interface satisfies
		/// our current needs. So we leave the stream interface for future work.
		/// </summary>
		// Token: 0x060044C6 RID: 17606 RVA: 0x0006451D File Offset: 0x0006271D
		public virtual void SetWriteToOutputString(bool _arg)
		{
			vtkPLYWriter.vtkPLYWriter_SetWriteToOutputString_61(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060044C7 RID: 17607
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_WriteObjectInformationOff_62(HandleRef pThis);

		/// <summary>
		/// Enable writing the 'obj_info' in the header. Default is on.
		/// Note that some software is unable to read ply files with the 'obj_info' included.
		/// </summary>
		// Token: 0x060044C8 RID: 17608 RVA: 0x00064535 File Offset: 0x00062735
		public virtual void WriteObjectInformationOff()
		{
			vtkPLYWriter.vtkPLYWriter_WriteObjectInformationOff_62(base.GetCppThis());
		}

		// Token: 0x060044C9 RID: 17609
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_WriteObjectInformationOn_63(HandleRef pThis);

		/// <summary>
		/// Enable writing the 'obj_info' in the header. Default is on.
		/// Note that some software is unable to read ply files with the 'obj_info' included.
		/// </summary>
		// Token: 0x060044CA RID: 17610 RVA: 0x00064544 File Offset: 0x00062744
		public virtual void WriteObjectInformationOn()
		{
			vtkPLYWriter.vtkPLYWriter_WriteObjectInformationOn_63(base.GetCppThis());
		}

		// Token: 0x060044CB RID: 17611
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_WriteToOutputStringOff_64(HandleRef pThis);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// Note that writing to an output stream would be more flexible (enabling
		/// other kind of streams) and possibly more efficient because we don't need
		/// to write the whole stream to a string. However a stream interface
		/// does not translate well to python and the string interface satisfies
		/// our current needs. So we leave the stream interface for future work.
		/// </summary>
		// Token: 0x060044CC RID: 17612 RVA: 0x00064553 File Offset: 0x00062753
		public virtual void WriteToOutputStringOff()
		{
			vtkPLYWriter.vtkPLYWriter_WriteToOutputStringOff_64(base.GetCppThis());
		}

		// Token: 0x060044CD RID: 17613
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYWriter_WriteToOutputStringOn_65(HandleRef pThis);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// Note that writing to an output stream would be more flexible (enabling
		/// other kind of streams) and possibly more efficient because we don't need
		/// to write the whole stream to a string. However a stream interface
		/// does not translate well to python and the string interface satisfies
		/// our current needs. So we leave the stream interface for future work.
		/// </summary>
		// Token: 0x060044CE RID: 17614 RVA: 0x00064562 File Offset: 0x00062762
		public virtual void WriteToOutputStringOn()
		{
			vtkPLYWriter.vtkPLYWriter_WriteToOutputStringOn_65(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000715 RID: 1813
		public new const string MRFullTypeName = "Kitware.VTK.vtkPLYWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000716 RID: 1814
		public new static readonly string MRClassNameKey = "class vtkPLYWriter";
	}
}
