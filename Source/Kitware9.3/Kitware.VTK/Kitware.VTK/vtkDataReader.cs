using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataReader
	/// </summary>
	/// <remarks>
	///    helper superclass for objects that read vtk data files
	///
	/// vtkDataReader is a helper superclass that reads the vtk data file header,
	/// dataset type, and attribute data (point and cell attributes such as
	/// scalars, vectors, normals, etc.) from a vtk data file.  See text for
	/// the format of the various vtk file types.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolyDataReader vtkStructuredPointsReader vtkStructuredGridReader
	/// vtkUnstructuredGridReader vtkRectilinearGridReader
	/// </seealso>
	// Token: 0x02000192 RID: 402
	public class vtkDataReader : vtkSimpleReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004E79 RID: 20089 RVA: 0x000721B7 File Offset: 0x000703B7
		static vtkDataReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004E7A RID: 20090 RVA: 0x000721DF File Offset: 0x000703DF
		public vtkDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004E7B RID: 20091
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E7C RID: 20092 RVA: 0x000721F0 File Offset: 0x000703F0
		public new static vtkDataReader New()
		{
			vtkDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataReader.vtkDataReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E7D RID: 20093 RVA: 0x00072244 File Offset: 0x00070444
		public vtkDataReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataReader.vtkDataReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004E7E RID: 20094 RVA: 0x00072288 File Offset: 0x00070488
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004E7F RID: 20095
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_CloseVTKFile_01(HandleRef pThis);

		/// <summary>
		/// Close the vtk file.
		/// </summary>
		// Token: 0x06004E80 RID: 20096 RVA: 0x00072293 File Offset: 0x00070493
		public void CloseVTKFile()
		{
			vtkDataReader.vtkDataReader_CloseVTKFile_01(base.GetCppThis());
		}

		// Token: 0x06004E81 RID: 20097
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_GetFieldDataName_02(HandleRef pThis);

		/// <summary>
		/// Set the name of the field data to extract. If not specified, uses
		/// first field data encountered in file.
		/// </summary>
		// Token: 0x06004E82 RID: 20098 RVA: 0x000722A4 File Offset: 0x000704A4
		public virtual string GetFieldDataName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetFieldDataName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004E83 RID: 20099
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_GetFieldDataNameInFile_03(HandleRef pThis, int i);

		/// <summary>
		/// What is the name of the ith attribute of a certain type
		/// in this file? This requires reading the file, so the filename
		/// must be set prior to invoking this operation.
		/// </summary>
		// Token: 0x06004E84 RID: 20100 RVA: 0x000722E0 File Offset: 0x000704E0
		public string GetFieldDataNameInFile(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetFieldDataNameInFile_03(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004E85 RID: 20101
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_GetFileMajorVersion_04(HandleRef pThis);

		/// <summary>
		/// Return the version of the file read; for example, VTK legacy readers
		/// will return the version of the VTK legacy file. (In the case of VTK
		/// legacy files, see vtkDataWriter.h for the enum types returned.) This
		/// method only returns useful information after a successful read is
		/// performed; and some derived classes may not return relevant
		/// information.) Note that for VTK legacy readers, the FileVersion is
		/// defined by the compositing the major version digits with the minor
		/// version digit. Extremely ancient VTK files (e.g., before version 4.2)
		/// will return a FileVersion of 3.0.
		/// </summary>
		// Token: 0x06004E86 RID: 20102 RVA: 0x0007231C File Offset: 0x0007051C
		public virtual int GetFileMajorVersion()
		{
			return vtkDataReader.vtkDataReader_GetFileMajorVersion_04(base.GetCppThis());
		}

		// Token: 0x06004E87 RID: 20103
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_GetFileMinorVersion_05(HandleRef pThis);

		/// <summary>
		/// Return the version of the file read; for example, VTK legacy readers
		/// will return the version of the VTK legacy file. (In the case of VTK
		/// legacy files, see vtkDataWriter.h for the enum types returned.) This
		/// method only returns useful information after a successful read is
		/// performed; and some derived classes may not return relevant
		/// information.) Note that for VTK legacy readers, the FileVersion is
		/// defined by the compositing the major version digits with the minor
		/// version digit. Extremely ancient VTK files (e.g., before version 4.2)
		/// will return a FileVersion of 3.0.
		/// </summary>
		// Token: 0x06004E88 RID: 20104 RVA: 0x0007233C File Offset: 0x0007053C
		public virtual int GetFileMinorVersion()
		{
			return vtkDataReader.vtkDataReader_GetFileMinorVersion_05(base.GetCppThis());
		}

		// Token: 0x06004E89 RID: 20105
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_GetFileName_06(HandleRef pThis);

		/// <summary>
		/// Specify file name of vtk data file to read. This is just
		/// a convenience method that calls the superclass' AddFileName
		/// method.
		/// </summary>
		// Token: 0x06004E8A RID: 20106 RVA: 0x0007235C File Offset: 0x0007055C
		public string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetFileName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004E8B RID: 20107
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_GetFileName_07(HandleRef pThis, int i);

		/// <summary>
		/// Specify file name of vtk data file to read. This is just
		/// a convenience method that calls the superclass' AddFileName
		/// method.
		/// </summary>
		// Token: 0x06004E8C RID: 20108 RVA: 0x00072398 File Offset: 0x00070598
		public new string GetFileName(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetFileName_07(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004E8D RID: 20109
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_GetFileType_08(HandleRef pThis);

		/// <summary>
		/// Get the type of file (ASCII or BINARY). Returned value only valid
		/// after file has been read.
		/// </summary>
		// Token: 0x06004E8E RID: 20110 RVA: 0x000723D4 File Offset: 0x000705D4
		public virtual int GetFileType()
		{
			return vtkDataReader.vtkDataReader_GetFileType_08(base.GetCppThis());
		}

		// Token: 0x06004E8F RID: 20111
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_GetFileVersion_09(HandleRef pThis);

		/// <summary>
		/// Return the version of the file read; for example, VTK legacy readers
		/// will return the version of the VTK legacy file. (In the case of VTK
		/// legacy files, see vtkDataWriter.h for the enum types returned.) This
		/// method only returns useful information after a successful read is
		/// performed; and some derived classes may not return relevant
		/// information.) Note that for VTK legacy readers, the FileVersion is
		/// defined by the compositing the major version digits with the minor
		/// version digit. Extremely ancient VTK files (e.g., before version 4.2)
		/// will return a FileVersion of 3.0.
		/// </summary>
		// Token: 0x06004E90 RID: 20112 RVA: 0x000723F4 File Offset: 0x000705F4
		public virtual int GetFileVersion()
		{
			return vtkDataReader.vtkDataReader_GetFileVersion_09(base.GetCppThis());
		}

		// Token: 0x06004E91 RID: 20113
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_GetHeader_10(HandleRef pThis);

		/// <summary>
		/// Get the header from the vtk data file.
		/// </summary>
		// Token: 0x06004E92 RID: 20114 RVA: 0x00072414 File Offset: 0x00070614
		public virtual string GetHeader()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetHeader_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004E93 RID: 20115
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_GetInputArray_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the vtkCharArray to be used  when reading from a string.
		/// If set, this array has precedence over InputString.
		/// Use this instead of InputString to avoid the extra memory copy.
		/// It should be noted that if the underlying char* is owned by the
		/// user ( vtkCharArray::SetArray(array, 1); ) and is deleted before
		/// the reader, bad things will happen during a pipeline update.
		/// </summary>
		// Token: 0x06004E94 RID: 20116 RVA: 0x00072450 File Offset: 0x00070650
		public virtual vtkCharArray GetInputArray()
		{
			vtkCharArray vtkCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataReader.vtkDataReader_GetInputArray_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCharArray = (vtkCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCharArray.Register(null);
				}
			}
			return vtkCharArray;
		}

		// Token: 0x06004E95 RID: 20117
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_GetInputString_12(HandleRef pThis);

		/// <summary>
		/// Specify the InputString for use when reading from a character array.
		/// Optionally include the length for binary strings. Note that a copy
		/// of the string is made and stored. If this causes exceedingly large
		/// memory consumption, consider using InputArray instead.
		/// </summary>
		// Token: 0x06004E96 RID: 20118 RVA: 0x000724C0 File Offset: 0x000706C0
		public virtual string GetInputString()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetInputString_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004E97 RID: 20119
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_GetInputStringLength_13(HandleRef pThis);

		/// <summary>
		/// Specify the InputString for use when reading from a character array.
		/// Optionally include the length for binary strings. Note that a copy
		/// of the string is made and stored. If this causes exceedingly large
		/// memory consumption, consider using InputArray instead.
		/// </summary>
		// Token: 0x06004E98 RID: 20120 RVA: 0x000724FC File Offset: 0x000706FC
		public virtual int GetInputStringLength()
		{
			return vtkDataReader.vtkDataReader_GetInputStringLength_13(base.GetCppThis());
		}

		// Token: 0x06004E99 RID: 20121
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_GetLookupTableName_14(HandleRef pThis);

		/// <summary>
		/// Set the name of the lookup table data to extract. If not specified, uses
		/// lookup table named by scalar. Otherwise, this specification supersedes.
		/// </summary>
		// Token: 0x06004E9A RID: 20122 RVA: 0x0007251C File Offset: 0x0007071C
		public virtual string GetLookupTableName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetLookupTableName_14(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004E9B RID: 20123
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_GetNormalsName_15(HandleRef pThis);

		/// <summary>
		/// Set the name of the normal data to extract. If not specified, first
		/// normal data encountered is extracted.
		/// </summary>
		// Token: 0x06004E9C RID: 20124 RVA: 0x00072558 File Offset: 0x00070758
		public virtual string GetNormalsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetNormalsName_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004E9D RID: 20125
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_GetNormalsNameInFile_16(HandleRef pThis, int i);

		/// <summary>
		/// What is the name of the ith attribute of a certain type
		/// in this file? This requires reading the file, so the filename
		/// must be set prior to invoking this operation.
		/// </summary>
		// Token: 0x06004E9E RID: 20126 RVA: 0x00072594 File Offset: 0x00070794
		public string GetNormalsNameInFile(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetNormalsNameInFile_16(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004E9F RID: 20127
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_GetNumberOfFieldDataInFile_17(HandleRef pThis);

		/// <summary>
		/// How many attributes of various types are in this file? This
		/// requires reading the file, so the filename must be set prior
		/// to invoking this operation. (Note: file characteristics are
		/// cached, so only a single read is necessary to return file
		/// characteristics.)
		/// </summary>
		// Token: 0x06004EA0 RID: 20128 RVA: 0x000725D0 File Offset: 0x000707D0
		public int GetNumberOfFieldDataInFile()
		{
			return vtkDataReader.vtkDataReader_GetNumberOfFieldDataInFile_17(base.GetCppThis());
		}

		// Token: 0x06004EA1 RID: 20129
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataReader_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004EA2 RID: 20130 RVA: 0x000725F0 File Offset: 0x000707F0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataReader.vtkDataReader_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x06004EA3 RID: 20131
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataReader_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004EA4 RID: 20132 RVA: 0x00072610 File Offset: 0x00070810
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataReader.vtkDataReader_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x06004EA5 RID: 20133
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_GetNumberOfNormalsInFile_20(HandleRef pThis);

		/// <summary>
		/// How many attributes of various types are in this file? This
		/// requires reading the file, so the filename must be set prior
		/// to invoking this operation. (Note: file characteristics are
		/// cached, so only a single read is necessary to return file
		/// characteristics.)
		/// </summary>
		// Token: 0x06004EA6 RID: 20134 RVA: 0x0007262C File Offset: 0x0007082C
		public int GetNumberOfNormalsInFile()
		{
			return vtkDataReader.vtkDataReader_GetNumberOfNormalsInFile_20(base.GetCppThis());
		}

		// Token: 0x06004EA7 RID: 20135
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_GetNumberOfScalarsInFile_21(HandleRef pThis);

		/// <summary>
		/// How many attributes of various types are in this file? This
		/// requires reading the file, so the filename must be set prior
		/// to invoking this operation. (Note: file characteristics are
		/// cached, so only a single read is necessary to return file
		/// characteristics.)
		/// </summary>
		// Token: 0x06004EA8 RID: 20136 RVA: 0x0007264C File Offset: 0x0007084C
		public int GetNumberOfScalarsInFile()
		{
			return vtkDataReader.vtkDataReader_GetNumberOfScalarsInFile_21(base.GetCppThis());
		}

		// Token: 0x06004EA9 RID: 20137
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_GetNumberOfTCoordsInFile_22(HandleRef pThis);

		/// <summary>
		/// How many attributes of various types are in this file? This
		/// requires reading the file, so the filename must be set prior
		/// to invoking this operation. (Note: file characteristics are
		/// cached, so only a single read is necessary to return file
		/// characteristics.)
		/// </summary>
		// Token: 0x06004EAA RID: 20138 RVA: 0x0007266C File Offset: 0x0007086C
		public int GetNumberOfTCoordsInFile()
		{
			return vtkDataReader.vtkDataReader_GetNumberOfTCoordsInFile_22(base.GetCppThis());
		}

		// Token: 0x06004EAB RID: 20139
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_GetNumberOfTensorsInFile_23(HandleRef pThis);

		/// <summary>
		/// How many attributes of various types are in this file? This
		/// requires reading the file, so the filename must be set prior
		/// to invoking this operation. (Note: file characteristics are
		/// cached, so only a single read is necessary to return file
		/// characteristics.)
		/// </summary>
		// Token: 0x06004EAC RID: 20140 RVA: 0x0007268C File Offset: 0x0007088C
		public int GetNumberOfTensorsInFile()
		{
			return vtkDataReader.vtkDataReader_GetNumberOfTensorsInFile_23(base.GetCppThis());
		}

		// Token: 0x06004EAD RID: 20141
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_GetNumberOfVectorsInFile_24(HandleRef pThis);

		/// <summary>
		/// How many attributes of various types are in this file? This
		/// requires reading the file, so the filename must be set prior
		/// to invoking this operation. (Note: file characteristics are
		/// cached, so only a single read is necessary to return file
		/// characteristics.)
		/// </summary>
		// Token: 0x06004EAE RID: 20142 RVA: 0x000726AC File Offset: 0x000708AC
		public int GetNumberOfVectorsInFile()
		{
			return vtkDataReader.vtkDataReader_GetNumberOfVectorsInFile_24(base.GetCppThis());
		}

		// Token: 0x06004EAF RID: 20143
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_GetReadAllColorScalars_25(HandleRef pThis);

		/// <summary>
		/// Enable reading all color scalars.
		/// </summary>
		// Token: 0x06004EB0 RID: 20144 RVA: 0x000726CC File Offset: 0x000708CC
		public virtual int GetReadAllColorScalars()
		{
			return vtkDataReader.vtkDataReader_GetReadAllColorScalars_25(base.GetCppThis());
		}

		// Token: 0x06004EB1 RID: 20145
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_GetReadAllFields_26(HandleRef pThis);

		/// <summary>
		/// Enable reading all fields.
		/// </summary>
		// Token: 0x06004EB2 RID: 20146 RVA: 0x000726EC File Offset: 0x000708EC
		public virtual int GetReadAllFields()
		{
			return vtkDataReader.vtkDataReader_GetReadAllFields_26(base.GetCppThis());
		}

		// Token: 0x06004EB3 RID: 20147
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_GetReadAllNormals_27(HandleRef pThis);

		/// <summary>
		/// Enable reading all normals.
		/// </summary>
		// Token: 0x06004EB4 RID: 20148 RVA: 0x0007270C File Offset: 0x0007090C
		public virtual int GetReadAllNormals()
		{
			return vtkDataReader.vtkDataReader_GetReadAllNormals_27(base.GetCppThis());
		}

		// Token: 0x06004EB5 RID: 20149
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_GetReadAllScalars_28(HandleRef pThis);

		/// <summary>
		/// Enable reading all scalars.
		/// </summary>
		// Token: 0x06004EB6 RID: 20150 RVA: 0x0007272C File Offset: 0x0007092C
		public virtual int GetReadAllScalars()
		{
			return vtkDataReader.vtkDataReader_GetReadAllScalars_28(base.GetCppThis());
		}

		// Token: 0x06004EB7 RID: 20151
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_GetReadAllTCoords_29(HandleRef pThis);

		/// <summary>
		/// Enable reading all tcoords.
		/// </summary>
		// Token: 0x06004EB8 RID: 20152 RVA: 0x0007274C File Offset: 0x0007094C
		public virtual int GetReadAllTCoords()
		{
			return vtkDataReader.vtkDataReader_GetReadAllTCoords_29(base.GetCppThis());
		}

		// Token: 0x06004EB9 RID: 20153
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_GetReadAllTensors_30(HandleRef pThis);

		/// <summary>
		/// Enable reading all tensors.
		/// </summary>
		// Token: 0x06004EBA RID: 20154 RVA: 0x0007276C File Offset: 0x0007096C
		public virtual int GetReadAllTensors()
		{
			return vtkDataReader.vtkDataReader_GetReadAllTensors_30(base.GetCppThis());
		}

		// Token: 0x06004EBB RID: 20155
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_GetReadAllVectors_31(HandleRef pThis);

		/// <summary>
		/// Enable reading all vectors.
		/// </summary>
		// Token: 0x06004EBC RID: 20156 RVA: 0x0007278C File Offset: 0x0007098C
		public virtual int GetReadAllVectors()
		{
			return vtkDataReader.vtkDataReader_GetReadAllVectors_31(base.GetCppThis());
		}

		// Token: 0x06004EBD RID: 20157
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_GetReadFromInputString_32(HandleRef pThis);

		/// <summary>
		/// Enable reading from an InputString or InputArray instead of the default,
		/// a file.
		/// </summary>
		// Token: 0x06004EBE RID: 20158 RVA: 0x000727AC File Offset: 0x000709AC
		public virtual int GetReadFromInputString()
		{
			return vtkDataReader.vtkDataReader_GetReadFromInputString_32(base.GetCppThis());
		}

		// Token: 0x06004EBF RID: 20159
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_GetScalarsName_33(HandleRef pThis);

		/// <summary>
		/// Set the name of the scalar data to extract. If not specified, first
		/// scalar data encountered is extracted.
		/// </summary>
		// Token: 0x06004EC0 RID: 20160 RVA: 0x000727CC File Offset: 0x000709CC
		public virtual string GetScalarsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetScalarsName_33(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004EC1 RID: 20161
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_GetScalarsNameInFile_34(HandleRef pThis, int i);

		/// <summary>
		/// What is the name of the ith attribute of a certain type
		/// in this file? This requires reading the file, so the filename
		/// must be set prior to invoking this operation.
		/// </summary>
		// Token: 0x06004EC2 RID: 20162 RVA: 0x00072808 File Offset: 0x00070A08
		public string GetScalarsNameInFile(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetScalarsNameInFile_34(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004EC3 RID: 20163
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_GetTCoordsName_35(HandleRef pThis);

		/// <summary>
		/// Set the name of the texture coordinate data to extract. If not specified,
		/// first texture coordinate data encountered is extracted.
		/// </summary>
		// Token: 0x06004EC4 RID: 20164 RVA: 0x00072844 File Offset: 0x00070A44
		public virtual string GetTCoordsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetTCoordsName_35(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004EC5 RID: 20165
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_GetTCoordsNameInFile_36(HandleRef pThis, int i);

		/// <summary>
		/// What is the name of the ith attribute of a certain type
		/// in this file? This requires reading the file, so the filename
		/// must be set prior to invoking this operation.
		/// </summary>
		// Token: 0x06004EC6 RID: 20166 RVA: 0x00072880 File Offset: 0x00070A80
		public string GetTCoordsNameInFile(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetTCoordsNameInFile_36(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004EC7 RID: 20167
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_GetTensorsName_37(HandleRef pThis);

		/// <summary>
		/// Set the name of the tensor data to extract. If not specified, first
		/// tensor data encountered is extracted.
		/// </summary>
		// Token: 0x06004EC8 RID: 20168 RVA: 0x000728BC File Offset: 0x00070ABC
		public virtual string GetTensorsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetTensorsName_37(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004EC9 RID: 20169
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_GetTensorsNameInFile_38(HandleRef pThis, int i);

		/// <summary>
		/// What is the name of the ith attribute of a certain type
		/// in this file? This requires reading the file, so the filename
		/// must be set prior to invoking this operation.
		/// </summary>
		// Token: 0x06004ECA RID: 20170 RVA: 0x000728F8 File Offset: 0x00070AF8
		public string GetTensorsNameInFile(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetTensorsNameInFile_38(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004ECB RID: 20171
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_GetVectorsName_39(HandleRef pThis);

		/// <summary>
		/// Set the name of the vector data to extract. If not specified, first
		/// vector data encountered is extracted.
		/// </summary>
		// Token: 0x06004ECC RID: 20172 RVA: 0x00072934 File Offset: 0x00070B34
		public virtual string GetVectorsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetVectorsName_39(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004ECD RID: 20173
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_GetVectorsNameInFile_40(HandleRef pThis, int i);

		/// <summary>
		/// What is the name of the ith attribute of a certain type
		/// in this file? This requires reading the file, so the filename
		/// must be set prior to invoking this operation.
		/// </summary>
		// Token: 0x06004ECE RID: 20174 RVA: 0x00072970 File Offset: 0x00070B70
		public string GetVectorsNameInFile(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetVectorsNameInFile_40(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004ECF RID: 20175
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_IsA_41(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004ED0 RID: 20176 RVA: 0x000729AC File Offset: 0x00070BAC
		public override int IsA(string type)
		{
			return vtkDataReader.vtkDataReader_IsA_41(base.GetCppThis(), type);
		}

		// Token: 0x06004ED1 RID: 20177
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_IsFilePolyData_42(HandleRef pThis);

		/// <summary>
		/// Is the file a valid vtk file of the passed dataset type ?
		/// The dataset type is passed as a lower case string.
		/// </summary>
		// Token: 0x06004ED2 RID: 20178 RVA: 0x000729CC File Offset: 0x00070BCC
		public int IsFilePolyData()
		{
			return vtkDataReader.vtkDataReader_IsFilePolyData_42(base.GetCppThis());
		}

		// Token: 0x06004ED3 RID: 20179
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_IsFileRectilinearGrid_43(HandleRef pThis);

		/// <summary>
		/// Is the file a valid vtk file of the passed dataset type ?
		/// The dataset type is passed as a lower case string.
		/// </summary>
		// Token: 0x06004ED4 RID: 20180 RVA: 0x000729EC File Offset: 0x00070BEC
		public int IsFileRectilinearGrid()
		{
			return vtkDataReader.vtkDataReader_IsFileRectilinearGrid_43(base.GetCppThis());
		}

		// Token: 0x06004ED5 RID: 20181
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_IsFileStructuredGrid_44(HandleRef pThis);

		/// <summary>
		/// Is the file a valid vtk file of the passed dataset type ?
		/// The dataset type is passed as a lower case string.
		/// </summary>
		// Token: 0x06004ED6 RID: 20182 RVA: 0x00072A0C File Offset: 0x00070C0C
		public int IsFileStructuredGrid()
		{
			return vtkDataReader.vtkDataReader_IsFileStructuredGrid_44(base.GetCppThis());
		}

		// Token: 0x06004ED7 RID: 20183
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_IsFileStructuredPoints_45(HandleRef pThis);

		/// <summary>
		/// Is the file a valid vtk file of the passed dataset type ?
		/// The dataset type is passed as a lower case string.
		/// </summary>
		// Token: 0x06004ED8 RID: 20184 RVA: 0x00072A2C File Offset: 0x00070C2C
		public int IsFileStructuredPoints()
		{
			return vtkDataReader.vtkDataReader_IsFileStructuredPoints_45(base.GetCppThis());
		}

		// Token: 0x06004ED9 RID: 20185
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_IsFileUnstructuredGrid_46(HandleRef pThis);

		/// <summary>
		/// Is the file a valid vtk file of the passed dataset type ?
		/// The dataset type is passed as a lower case string.
		/// </summary>
		// Token: 0x06004EDA RID: 20186 RVA: 0x00072A4C File Offset: 0x00070C4C
		public int IsFileUnstructuredGrid()
		{
			return vtkDataReader.vtkDataReader_IsFileUnstructuredGrid_46(base.GetCppThis());
		}

		// Token: 0x06004EDB RID: 20187
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_IsFileValid_47(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string dstype);

		/// <summary>
		/// Is the file a valid vtk file of the passed dataset type ?
		/// The dataset type is passed as a lower case string.
		/// </summary>
		// Token: 0x06004EDC RID: 20188 RVA: 0x00072A6C File Offset: 0x00070C6C
		public int IsFileValid(string dstype)
		{
			return vtkDataReader.vtkDataReader_IsFileValid_47(base.GetCppThis(), dstype);
		}

		// Token: 0x06004EDD RID: 20189
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_IsTypeOf_48([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004EDE RID: 20190 RVA: 0x00072A8C File Offset: 0x00070C8C
		public new static int IsTypeOf(string type)
		{
			return vtkDataReader.vtkDataReader_IsTypeOf_48(type);
		}

		// Token: 0x06004EDF RID: 20191
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_LowerCase_49(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, ulong len);

		/// <summary>
		/// Helper method for reading in data.
		/// </summary>
		// Token: 0x06004EE0 RID: 20192 RVA: 0x00072AA8 File Offset: 0x00070CA8
		public string LowerCase(string str, ulong len)
		{
			string s = Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_LowerCase_49(base.GetCppThis(), str, len));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004EE1 RID: 20193
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_NewInstance_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004EE2 RID: 20194 RVA: 0x00072AE4 File Offset: 0x00070CE4
		public new vtkDataReader NewInstance()
		{
			vtkDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataReader.vtkDataReader_NewInstance_51(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004EE3 RID: 20195
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_OpenVTKFile_52(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Open a vtk data file. Returns zero if error.
		/// </summary>
		// Token: 0x06004EE4 RID: 20196 RVA: 0x00072B40 File Offset: 0x00070D40
		public int OpenVTKFile(string fname)
		{
			return vtkDataReader.vtkDataReader_OpenVTKFile_52(base.GetCppThis(), fname);
		}

		// Token: 0x06004EE5 RID: 20197
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDataReader_Peek_53(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, ulong n);

		/// <summary>
		/// Read @a n character from the stream into @a str, then reset the stream
		/// position. Returns the number of characters actually read.
		/// </summary>
		// Token: 0x06004EE6 RID: 20198 RVA: 0x00072B60 File Offset: 0x00070D60
		public ulong Peek(string str, ulong n)
		{
			return vtkDataReader.vtkDataReader_Peek_53(base.GetCppThis(), str, n);
		}

		// Token: 0x06004EE7 RID: 20199
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_Read_54(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Internal function to read in a value.  Returns zero if there was an
		/// error.
		/// </summary>
		// Token: 0x06004EE8 RID: 20200 RVA: 0x00072B84 File Offset: 0x00070D84
		public int Read(string arg0)
		{
			return vtkDataReader.vtkDataReader_Read_54(base.GetCppThis(), arg0);
		}

		// Token: 0x06004EE9 RID: 20201
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_Read_55(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Internal function to read in a value.  Returns zero if there was an
		/// error.
		/// </summary>
		// Token: 0x06004EEA RID: 20202 RVA: 0x00072BA4 File Offset: 0x00070DA4
		public int Read(IntPtr arg0)
		{
			return vtkDataReader.vtkDataReader_Read_55(base.GetCppThis(), arg0);
		}

		// Token: 0x06004EEB RID: 20203
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_ReadAllColorScalarsOff_56(HandleRef pThis);

		/// <summary>
		/// Enable reading all color scalars.
		/// </summary>
		// Token: 0x06004EEC RID: 20204 RVA: 0x00072BC4 File Offset: 0x00070DC4
		public virtual void ReadAllColorScalarsOff()
		{
			vtkDataReader.vtkDataReader_ReadAllColorScalarsOff_56(base.GetCppThis());
		}

		// Token: 0x06004EED RID: 20205
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_ReadAllColorScalarsOn_57(HandleRef pThis);

		/// <summary>
		/// Enable reading all color scalars.
		/// </summary>
		// Token: 0x06004EEE RID: 20206 RVA: 0x00072BD3 File Offset: 0x00070DD3
		public virtual void ReadAllColorScalarsOn()
		{
			vtkDataReader.vtkDataReader_ReadAllColorScalarsOn_57(base.GetCppThis());
		}

		// Token: 0x06004EEF RID: 20207
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_ReadAllFieldsOff_58(HandleRef pThis);

		/// <summary>
		/// Enable reading all fields.
		/// </summary>
		// Token: 0x06004EF0 RID: 20208 RVA: 0x00072BE2 File Offset: 0x00070DE2
		public virtual void ReadAllFieldsOff()
		{
			vtkDataReader.vtkDataReader_ReadAllFieldsOff_58(base.GetCppThis());
		}

		// Token: 0x06004EF1 RID: 20209
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_ReadAllFieldsOn_59(HandleRef pThis);

		/// <summary>
		/// Enable reading all fields.
		/// </summary>
		// Token: 0x06004EF2 RID: 20210 RVA: 0x00072BF1 File Offset: 0x00070DF1
		public virtual void ReadAllFieldsOn()
		{
			vtkDataReader.vtkDataReader_ReadAllFieldsOn_59(base.GetCppThis());
		}

		// Token: 0x06004EF3 RID: 20211
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_ReadAllNormalsOff_60(HandleRef pThis);

		/// <summary>
		/// Enable reading all normals.
		/// </summary>
		// Token: 0x06004EF4 RID: 20212 RVA: 0x00072C00 File Offset: 0x00070E00
		public virtual void ReadAllNormalsOff()
		{
			vtkDataReader.vtkDataReader_ReadAllNormalsOff_60(base.GetCppThis());
		}

		// Token: 0x06004EF5 RID: 20213
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_ReadAllNormalsOn_61(HandleRef pThis);

		/// <summary>
		/// Enable reading all normals.
		/// </summary>
		// Token: 0x06004EF6 RID: 20214 RVA: 0x00072C0F File Offset: 0x00070E0F
		public virtual void ReadAllNormalsOn()
		{
			vtkDataReader.vtkDataReader_ReadAllNormalsOn_61(base.GetCppThis());
		}

		// Token: 0x06004EF7 RID: 20215
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_ReadAllScalarsOff_62(HandleRef pThis);

		/// <summary>
		/// Enable reading all scalars.
		/// </summary>
		// Token: 0x06004EF8 RID: 20216 RVA: 0x00072C1E File Offset: 0x00070E1E
		public virtual void ReadAllScalarsOff()
		{
			vtkDataReader.vtkDataReader_ReadAllScalarsOff_62(base.GetCppThis());
		}

		// Token: 0x06004EF9 RID: 20217
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_ReadAllScalarsOn_63(HandleRef pThis);

		/// <summary>
		/// Enable reading all scalars.
		/// </summary>
		// Token: 0x06004EFA RID: 20218 RVA: 0x00072C2D File Offset: 0x00070E2D
		public virtual void ReadAllScalarsOn()
		{
			vtkDataReader.vtkDataReader_ReadAllScalarsOn_63(base.GetCppThis());
		}

		// Token: 0x06004EFB RID: 20219
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_ReadAllTCoordsOff_64(HandleRef pThis);

		/// <summary>
		/// Enable reading all tcoords.
		/// </summary>
		// Token: 0x06004EFC RID: 20220 RVA: 0x00072C3C File Offset: 0x00070E3C
		public virtual void ReadAllTCoordsOff()
		{
			vtkDataReader.vtkDataReader_ReadAllTCoordsOff_64(base.GetCppThis());
		}

		// Token: 0x06004EFD RID: 20221
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_ReadAllTCoordsOn_65(HandleRef pThis);

		/// <summary>
		/// Enable reading all tcoords.
		/// </summary>
		// Token: 0x06004EFE RID: 20222 RVA: 0x00072C4B File Offset: 0x00070E4B
		public virtual void ReadAllTCoordsOn()
		{
			vtkDataReader.vtkDataReader_ReadAllTCoordsOn_65(base.GetCppThis());
		}

		// Token: 0x06004EFF RID: 20223
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_ReadAllTensorsOff_66(HandleRef pThis);

		/// <summary>
		/// Enable reading all tensors.
		/// </summary>
		// Token: 0x06004F00 RID: 20224 RVA: 0x00072C5A File Offset: 0x00070E5A
		public virtual void ReadAllTensorsOff()
		{
			vtkDataReader.vtkDataReader_ReadAllTensorsOff_66(base.GetCppThis());
		}

		// Token: 0x06004F01 RID: 20225
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_ReadAllTensorsOn_67(HandleRef pThis);

		/// <summary>
		/// Enable reading all tensors.
		/// </summary>
		// Token: 0x06004F02 RID: 20226 RVA: 0x00072C69 File Offset: 0x00070E69
		public virtual void ReadAllTensorsOn()
		{
			vtkDataReader.vtkDataReader_ReadAllTensorsOn_67(base.GetCppThis());
		}

		// Token: 0x06004F03 RID: 20227
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_ReadAllVectorsOff_68(HandleRef pThis);

		/// <summary>
		/// Enable reading all vectors.
		/// </summary>
		// Token: 0x06004F04 RID: 20228 RVA: 0x00072C78 File Offset: 0x00070E78
		public virtual void ReadAllVectorsOff()
		{
			vtkDataReader.vtkDataReader_ReadAllVectorsOff_68(base.GetCppThis());
		}

		// Token: 0x06004F05 RID: 20229
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_ReadAllVectorsOn_69(HandleRef pThis);

		/// <summary>
		/// Enable reading all vectors.
		/// </summary>
		// Token: 0x06004F06 RID: 20230 RVA: 0x00072C87 File Offset: 0x00070E87
		public virtual void ReadAllVectorsOn()
		{
			vtkDataReader.vtkDataReader_ReadAllVectorsOn_69(base.GetCppThis());
		}

		// Token: 0x06004F07 RID: 20231
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_ReadArray_70(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string dataType, long numTuples, long numComp, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Helper functions for reading data.
		/// </summary>
		// Token: 0x06004F08 RID: 20232 RVA: 0x00072C98 File Offset: 0x00070E98
		public vtkAbstractArray ReadArray(string dataType, long numTuples, long numComp)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataReader.vtkDataReader_ReadArray_70(base.GetCppThis(), dataType, numTuples, numComp, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		// Token: 0x06004F09 RID: 20233
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_ReadArrays_71(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, HandleRef arg4);

		/// <summary>
		/// Overridden to handle reading from a string. The
		/// superclass only knows about files.
		/// </summary>
		// Token: 0x06004F0A RID: 20234 RVA: 0x00072D0C File Offset: 0x00070F0C
		public override int ReadArrays(int arg0, int arg1, int arg2, int arg3, vtkDataObject arg4)
		{
			return vtkDataReader.vtkDataReader_ReadArrays_71(base.GetCppThis(), arg0, arg1, arg2, arg3, (arg4 == null) ? default(HandleRef) : arg4.GetCppThis());
		}

		// Token: 0x06004F0B RID: 20235
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_ReadArraysSimple_72(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, HandleRef arg1);

		/// <summary>
		/// Overridden with default implementation of doing nothing
		/// so that subclasses only override what is needed (usually
		/// only ReadMesh).
		/// </summary>
		// Token: 0x06004F0C RID: 20236 RVA: 0x00072D48 File Offset: 0x00070F48
		public override int ReadArraysSimple(string arg0, vtkDataObject arg1)
		{
			return vtkDataReader.vtkDataReader_ReadArraysSimple_72(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06004F0D RID: 20237
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_ReadCellData_73(HandleRef pThis, HandleRef ds, long numCells);

		/// <summary>
		/// Read the cell data of a vtk data file. The number of cells (from the
		/// dataset) must match the number of cells defined in cell attributes (unless
		/// no geometry was defined).
		/// </summary>
		// Token: 0x06004F0E RID: 20238 RVA: 0x00072D80 File Offset: 0x00070F80
		public int ReadCellData(vtkDataSet ds, long numCells)
		{
			return vtkDataReader.vtkDataReader_ReadCellData_73(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis(), numCells);
		}

		// Token: 0x06004F0F RID: 20239
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_ReadCellsLegacy_74(HandleRef pThis, long size, IntPtr data);

		/// <summary>
		/// Read a bunch of "cells". Return 0 if error.
		/// @note Legacy implementation for file versions &lt; 5.0.
		/// </summary>
		// Token: 0x06004F10 RID: 20240 RVA: 0x00072DB8 File Offset: 0x00070FB8
		public int ReadCellsLegacy(long size, IntPtr data)
		{
			return vtkDataReader.vtkDataReader_ReadCellsLegacy_74(base.GetCppThis(), size, data);
		}

		// Token: 0x06004F11 RID: 20241
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_ReadCellsLegacy_75(HandleRef pThis, long size, IntPtr data, int skip1, int read2, int skip3);

		/// <summary>
		/// Read a piece of the cells (for streaming compliance)
		/// </summary>
		// Token: 0x06004F12 RID: 20242 RVA: 0x00072DDC File Offset: 0x00070FDC
		public int ReadCellsLegacy(long size, IntPtr data, int skip1, int read2, int skip3)
		{
			return vtkDataReader.vtkDataReader_ReadCellsLegacy_75(base.GetCppThis(), size, data, skip1, read2, skip3);
		}

		// Token: 0x06004F13 RID: 20243
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_ReadCoordinates_76(HandleRef pThis, HandleRef rg, int axes, int numCoords);

		/// <summary>
		/// Read the coordinates for a rectilinear grid. The axes parameter specifies
		/// which coordinate axes (0,1,2) is being read.
		/// </summary>
		// Token: 0x06004F14 RID: 20244 RVA: 0x00072E04 File Offset: 0x00071004
		public int ReadCoordinates(vtkRectilinearGrid rg, int axes, int numCoords)
		{
			return vtkDataReader.vtkDataReader_ReadCoordinates_76(base.GetCppThis(), (rg == null) ? default(HandleRef) : rg.GetCppThis(), axes, numCoords);
		}

		// Token: 0x06004F15 RID: 20245
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_ReadEdgeData_77(HandleRef pThis, HandleRef g, long numEdges);

		/// <summary>
		/// Read the edge data of a vtk data file. The number of edges (from the
		/// graph) must match the number of edges defined in edge attributes
		/// (unless no geometry was defined).
		/// </summary>
		// Token: 0x06004F16 RID: 20246 RVA: 0x00072E3C File Offset: 0x0007103C
		public int ReadEdgeData(vtkGraph g, long numEdges)
		{
			return vtkDataReader.vtkDataReader_ReadEdgeData_77(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis(), numEdges);
		}

		// Token: 0x06004F17 RID: 20247
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_ReadFieldData_78(HandleRef pThis, vtkDataReader.FieldType fieldType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Helper functions for reading data.
		/// </summary>
		// Token: 0x06004F18 RID: 20248 RVA: 0x00072E74 File Offset: 0x00071074
		public vtkFieldData ReadFieldData(vtkDataReader.FieldType fieldType)
		{
			vtkFieldData vtkFieldData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataReader.vtkDataReader_ReadFieldData_78(base.GetCppThis(), fieldType, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFieldData = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFieldData.Register(null);
				}
			}
			return vtkFieldData;
		}

		// Token: 0x06004F19 RID: 20249
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_ReadFromInputStringOff_79(HandleRef pThis);

		/// <summary>
		/// Enable reading from an InputString or InputArray instead of the default,
		/// a file.
		/// </summary>
		// Token: 0x06004F1A RID: 20250 RVA: 0x00072EE4 File Offset: 0x000710E4
		public virtual void ReadFromInputStringOff()
		{
			vtkDataReader.vtkDataReader_ReadFromInputStringOff_79(base.GetCppThis());
		}

		// Token: 0x06004F1B RID: 20251
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_ReadFromInputStringOn_80(HandleRef pThis);

		/// <summary>
		/// Enable reading from an InputString or InputArray instead of the default,
		/// a file.
		/// </summary>
		// Token: 0x06004F1C RID: 20252 RVA: 0x00072EF3 File Offset: 0x000710F3
		public virtual void ReadFromInputStringOn()
		{
			vtkDataReader.vtkDataReader_ReadFromInputStringOn_80(base.GetCppThis());
		}

		// Token: 0x06004F1D RID: 20253
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_ReadHeader_81(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Read the header of a vtk data file. Returns 0 if error.
		/// </summary>
		// Token: 0x06004F1E RID: 20254 RVA: 0x00072F04 File Offset: 0x00071104
		public int ReadHeader(string fname)
		{
			return vtkDataReader.vtkDataReader_ReadHeader_81(base.GetCppThis(), fname);
		}

		// Token: 0x06004F1F RID: 20255
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_ReadLine_82(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string result);

		/// <summary>
		/// Internal function to read in a line up to 256 characters.
		/// Returns zero if there was an error.
		/// </summary>
		// Token: 0x06004F20 RID: 20256 RVA: 0x00072F24 File Offset: 0x00071124
		public int ReadLine(string result)
		{
			return vtkDataReader.vtkDataReader_ReadLine_82(base.GetCppThis(), result);
		}

		// Token: 0x06004F21 RID: 20257
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_ReadMesh_83(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

		/// <summary>
		/// Overridden to handle reading from a string. The
		/// superclass only knows about files.
		/// </summary>
		// Token: 0x06004F22 RID: 20258 RVA: 0x00072F44 File Offset: 0x00071144
		public override int ReadMesh(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
		{
			return vtkDataReader.vtkDataReader_ReadMesh_83(base.GetCppThis(), piece, npieces, nghosts, timestep, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06004F23 RID: 20259
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_ReadMeshSimple_84(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, HandleRef arg1);

		/// <summary>
		/// Overridden with default implementation of doing nothing
		/// so that subclasses only override what is needed (usually
		/// only ReadMesh).
		/// </summary>
		// Token: 0x06004F24 RID: 20260 RVA: 0x00072F80 File Offset: 0x00071180
		public override int ReadMeshSimple(string arg0, vtkDataObject arg1)
		{
			return vtkDataReader.vtkDataReader_ReadMeshSimple_84(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06004F25 RID: 20261
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_ReadPointCoordinates_85(HandleRef pThis, HandleRef ps, long numPts);

		/// <summary>
		/// Read point coordinates. Return 0 if error.
		/// </summary>
		// Token: 0x06004F26 RID: 20262 RVA: 0x00072FB8 File Offset: 0x000711B8
		public int ReadPointCoordinates(vtkPointSet ps, long numPts)
		{
			return vtkDataReader.vtkDataReader_ReadPointCoordinates_85(base.GetCppThis(), (ps == null) ? default(HandleRef) : ps.GetCppThis(), numPts);
		}

		// Token: 0x06004F27 RID: 20263
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_ReadPointCoordinates_86(HandleRef pThis, HandleRef g, long numPts);

		/// <summary>
		/// Read point coordinates. Return 0 if error.
		/// </summary>
		// Token: 0x06004F28 RID: 20264 RVA: 0x00072FF0 File Offset: 0x000711F0
		public int ReadPointCoordinates(vtkGraph g, long numPts)
		{
			return vtkDataReader.vtkDataReader_ReadPointCoordinates_86(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis(), numPts);
		}

		// Token: 0x06004F29 RID: 20265
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_ReadPointData_87(HandleRef pThis, HandleRef ds, long numPts);

		/// <summary>
		/// Read the point data of a vtk data file. The number of points (from the
		/// dataset) must match the number of points defined in point attributes
		/// (unless no geometry was defined).
		/// </summary>
		// Token: 0x06004F2A RID: 20266 RVA: 0x00073028 File Offset: 0x00071228
		public int ReadPointData(vtkDataSet ds, long numPts)
		{
			return vtkDataReader.vtkDataReader_ReadPointData_87(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis(), numPts);
		}

		// Token: 0x06004F2B RID: 20267
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_ReadPoints_88(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, HandleRef arg4);

		/// <summary>
		/// Overridden to handle reading from a string. The
		/// superclass only knows about files.
		/// </summary>
		// Token: 0x06004F2C RID: 20268 RVA: 0x00073060 File Offset: 0x00071260
		public override int ReadPoints(int arg0, int arg1, int arg2, int arg3, vtkDataObject arg4)
		{
			return vtkDataReader.vtkDataReader_ReadPoints_88(base.GetCppThis(), arg0, arg1, arg2, arg3, (arg4 == null) ? default(HandleRef) : arg4.GetCppThis());
		}

		// Token: 0x06004F2D RID: 20269
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_ReadPointsSimple_89(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, HandleRef arg1);

		/// <summary>
		/// Overridden with default implementation of doing nothing
		/// so that subclasses only override what is needed (usually
		/// only ReadMesh).
		/// </summary>
		// Token: 0x06004F2E RID: 20270 RVA: 0x0007309C File Offset: 0x0007129C
		public override int ReadPointsSimple(string arg0, vtkDataObject arg1)
		{
			return vtkDataReader.vtkDataReader_ReadPointsSimple_89(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06004F2F RID: 20271
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_ReadRowData_90(HandleRef pThis, HandleRef t, long numEdges);

		/// <summary>
		/// Read the row data of a vtk data file.
		/// </summary>
		// Token: 0x06004F30 RID: 20272 RVA: 0x000730D4 File Offset: 0x000712D4
		public int ReadRowData(vtkTable t, long numEdges)
		{
			return vtkDataReader.vtkDataReader_ReadRowData_90(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis(), numEdges);
		}

		// Token: 0x06004F31 RID: 20273
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_ReadTimeDependentMetaData_91(HandleRef pThis, int timestep, HandleRef metadata);

		/// <summary>
		/// Overridden to handle reading from a string. The
		/// superclass only knows about files.
		/// </summary>
		// Token: 0x06004F32 RID: 20274 RVA: 0x0007310C File Offset: 0x0007130C
		public override int ReadTimeDependentMetaData(int timestep, vtkInformation metadata)
		{
			return vtkDataReader.vtkDataReader_ReadTimeDependentMetaData_91(base.GetCppThis(), timestep, (metadata == null) ? default(HandleRef) : metadata.GetCppThis());
		}

		// Token: 0x06004F33 RID: 20275
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataReader_ReadVertexData_92(HandleRef pThis, HandleRef g, long numVertices);

		/// <summary>
		/// Read the vertex data of a vtk data file. The number of vertices (from the
		/// graph) must match the number of vertices defined in vertex attributes
		/// (unless no geometry was defined).
		/// </summary>
		// Token: 0x06004F34 RID: 20276 RVA: 0x00073144 File Offset: 0x00071344
		public int ReadVertexData(vtkGraph g, long numVertices)
		{
			return vtkDataReader.vtkDataReader_ReadVertexData_92(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis(), numVertices);
		}

		// Token: 0x06004F35 RID: 20277
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataReader_SafeDownCast_93(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F36 RID: 20278 RVA: 0x0007317C File Offset: 0x0007137C
		public new static vtkDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkDataReader vtkDataReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataReader.vtkDataReader_SafeDownCast_93((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataReader = (vtkDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataReader.Register(null);
				}
			}
			return vtkDataReader;
		}

		// Token: 0x06004F37 RID: 20279
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_SetBinaryInputString_94(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, int len);

		/// <summary>
		/// Specify the InputString for use when reading from a character array.
		/// Optionally include the length for binary strings. Note that a copy
		/// of the string is made and stored. If this causes exceedingly large
		/// memory consumption, consider using InputArray instead.
		/// </summary>
		// Token: 0x06004F38 RID: 20280 RVA: 0x000731FB File Offset: 0x000713FB
		public void SetBinaryInputString(string arg0, int len)
		{
			vtkDataReader.vtkDataReader_SetBinaryInputString_94(base.GetCppThis(), arg0, len);
		}

		// Token: 0x06004F39 RID: 20281
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_SetFieldDataName_95(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the name of the field data to extract. If not specified, uses
		/// first field data encountered in file.
		/// </summary>
		// Token: 0x06004F3A RID: 20282 RVA: 0x0007320C File Offset: 0x0007140C
		public virtual void SetFieldDataName(string _arg)
		{
			vtkDataReader.vtkDataReader_SetFieldDataName_95(base.GetCppThis(), _arg);
		}

		// Token: 0x06004F3B RID: 20283
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_SetFileName_96(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Specify file name of vtk data file to read. This is just
		/// a convenience method that calls the superclass' AddFileName
		/// method.
		/// </summary>
		// Token: 0x06004F3C RID: 20284 RVA: 0x0007321C File Offset: 0x0007141C
		public void SetFileName(string fname)
		{
			vtkDataReader.vtkDataReader_SetFileName_96(base.GetCppThis(), fname);
		}

		// Token: 0x06004F3D RID: 20285
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_SetInputArray_97(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the vtkCharArray to be used  when reading from a string.
		/// If set, this array has precedence over InputString.
		/// Use this instead of InputString to avoid the extra memory copy.
		/// It should be noted that if the underlying char* is owned by the
		/// user ( vtkCharArray::SetArray(array, 1); ) and is deleted before
		/// the reader, bad things will happen during a pipeline update.
		/// </summary>
		// Token: 0x06004F3E RID: 20286 RVA: 0x0007322C File Offset: 0x0007142C
		public virtual void SetInputArray(vtkCharArray arg0)
		{
			vtkDataReader.vtkDataReader_SetInputArray_97(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06004F3F RID: 20287
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_SetInputString_98(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Specify the InputString for use when reading from a character array.
		/// Optionally include the length for binary strings. Note that a copy
		/// of the string is made and stored. If this causes exceedingly large
		/// memory consumption, consider using InputArray instead.
		/// </summary>
		// Token: 0x06004F40 RID: 20288 RVA: 0x0007325B File Offset: 0x0007145B
		public void SetInputString(string arg0)
		{
			vtkDataReader.vtkDataReader_SetInputString_98(base.GetCppThis(), arg0);
		}

		// Token: 0x06004F41 RID: 20289
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_SetInputString_99(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, int len);

		/// <summary>
		/// Specify the InputString for use when reading from a character array.
		/// Optionally include the length for binary strings. Note that a copy
		/// of the string is made and stored. If this causes exceedingly large
		/// memory consumption, consider using InputArray instead.
		/// </summary>
		// Token: 0x06004F42 RID: 20290 RVA: 0x0007326B File Offset: 0x0007146B
		public void SetInputString(string arg0, int len)
		{
			vtkDataReader.vtkDataReader_SetInputString_99(base.GetCppThis(), arg0, len);
		}

		// Token: 0x06004F43 RID: 20291
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_SetLookupTableName_100(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the name of the lookup table data to extract. If not specified, uses
		/// lookup table named by scalar. Otherwise, this specification supersedes.
		/// </summary>
		// Token: 0x06004F44 RID: 20292 RVA: 0x0007327C File Offset: 0x0007147C
		public virtual void SetLookupTableName(string _arg)
		{
			vtkDataReader.vtkDataReader_SetLookupTableName_100(base.GetCppThis(), _arg);
		}

		// Token: 0x06004F45 RID: 20293
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_SetNormalsName_101(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the name of the normal data to extract. If not specified, first
		/// normal data encountered is extracted.
		/// </summary>
		// Token: 0x06004F46 RID: 20294 RVA: 0x0007328C File Offset: 0x0007148C
		public virtual void SetNormalsName(string _arg)
		{
			vtkDataReader.vtkDataReader_SetNormalsName_101(base.GetCppThis(), _arg);
		}

		// Token: 0x06004F47 RID: 20295
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_SetReadAllColorScalars_102(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable reading all color scalars.
		/// </summary>
		// Token: 0x06004F48 RID: 20296 RVA: 0x0007329C File Offset: 0x0007149C
		public virtual void SetReadAllColorScalars(int _arg)
		{
			vtkDataReader.vtkDataReader_SetReadAllColorScalars_102(base.GetCppThis(), _arg);
		}

		// Token: 0x06004F49 RID: 20297
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_SetReadAllFields_103(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable reading all fields.
		/// </summary>
		// Token: 0x06004F4A RID: 20298 RVA: 0x000732AC File Offset: 0x000714AC
		public virtual void SetReadAllFields(int _arg)
		{
			vtkDataReader.vtkDataReader_SetReadAllFields_103(base.GetCppThis(), _arg);
		}

		// Token: 0x06004F4B RID: 20299
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_SetReadAllNormals_104(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable reading all normals.
		/// </summary>
		// Token: 0x06004F4C RID: 20300 RVA: 0x000732BC File Offset: 0x000714BC
		public virtual void SetReadAllNormals(int _arg)
		{
			vtkDataReader.vtkDataReader_SetReadAllNormals_104(base.GetCppThis(), _arg);
		}

		// Token: 0x06004F4D RID: 20301
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_SetReadAllScalars_105(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable reading all scalars.
		/// </summary>
		// Token: 0x06004F4E RID: 20302 RVA: 0x000732CC File Offset: 0x000714CC
		public virtual void SetReadAllScalars(int _arg)
		{
			vtkDataReader.vtkDataReader_SetReadAllScalars_105(base.GetCppThis(), _arg);
		}

		// Token: 0x06004F4F RID: 20303
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_SetReadAllTCoords_106(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable reading all tcoords.
		/// </summary>
		// Token: 0x06004F50 RID: 20304 RVA: 0x000732DC File Offset: 0x000714DC
		public virtual void SetReadAllTCoords(int _arg)
		{
			vtkDataReader.vtkDataReader_SetReadAllTCoords_106(base.GetCppThis(), _arg);
		}

		// Token: 0x06004F51 RID: 20305
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_SetReadAllTensors_107(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable reading all tensors.
		/// </summary>
		// Token: 0x06004F52 RID: 20306 RVA: 0x000732EC File Offset: 0x000714EC
		public virtual void SetReadAllTensors(int _arg)
		{
			vtkDataReader.vtkDataReader_SetReadAllTensors_107(base.GetCppThis(), _arg);
		}

		// Token: 0x06004F53 RID: 20307
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_SetReadAllVectors_108(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable reading all vectors.
		/// </summary>
		// Token: 0x06004F54 RID: 20308 RVA: 0x000732FC File Offset: 0x000714FC
		public virtual void SetReadAllVectors(int _arg)
		{
			vtkDataReader.vtkDataReader_SetReadAllVectors_108(base.GetCppThis(), _arg);
		}

		// Token: 0x06004F55 RID: 20309
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_SetReadFromInputString_109(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable reading from an InputString or InputArray instead of the default,
		/// a file.
		/// </summary>
		// Token: 0x06004F56 RID: 20310 RVA: 0x0007330C File Offset: 0x0007150C
		public virtual void SetReadFromInputString(int _arg)
		{
			vtkDataReader.vtkDataReader_SetReadFromInputString_109(base.GetCppThis(), _arg);
		}

		// Token: 0x06004F57 RID: 20311
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_SetScalarsName_110(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the name of the scalar data to extract. If not specified, first
		/// scalar data encountered is extracted.
		/// </summary>
		// Token: 0x06004F58 RID: 20312 RVA: 0x0007331C File Offset: 0x0007151C
		public virtual void SetScalarsName(string _arg)
		{
			vtkDataReader.vtkDataReader_SetScalarsName_110(base.GetCppThis(), _arg);
		}

		// Token: 0x06004F59 RID: 20313
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_SetTCoordsName_111(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the name of the texture coordinate data to extract. If not specified,
		/// first texture coordinate data encountered is extracted.
		/// </summary>
		// Token: 0x06004F5A RID: 20314 RVA: 0x0007332C File Offset: 0x0007152C
		public virtual void SetTCoordsName(string _arg)
		{
			vtkDataReader.vtkDataReader_SetTCoordsName_111(base.GetCppThis(), _arg);
		}

		// Token: 0x06004F5B RID: 20315
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_SetTensorsName_112(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the name of the tensor data to extract. If not specified, first
		/// tensor data encountered is extracted.
		/// </summary>
		// Token: 0x06004F5C RID: 20316 RVA: 0x0007333C File Offset: 0x0007153C
		public virtual void SetTensorsName(string _arg)
		{
			vtkDataReader.vtkDataReader_SetTensorsName_112(base.GetCppThis(), _arg);
		}

		// Token: 0x06004F5D RID: 20317
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataReader_SetVectorsName_113(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the name of the vector data to extract. If not specified, first
		/// vector data encountered is extracted.
		/// </summary>
		// Token: 0x06004F5E RID: 20318 RVA: 0x0007334C File Offset: 0x0007154C
		public virtual void SetVectorsName(string _arg)
		{
			vtkDataReader.vtkDataReader_SetVectorsName_113(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000785 RID: 1925
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000786 RID: 1926
		public new static readonly string MRClassNameKey = "class vtkDataReader";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000193 RID: 403
		public enum FieldType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000788 RID: 1928
			CELL_DATA = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000789 RID: 1929
			FIELD_DATA,
			/// <summary>enum member</summary>
			// Token: 0x0400078A RID: 1930
			POINT_DATA = 0
		}
	}
}
