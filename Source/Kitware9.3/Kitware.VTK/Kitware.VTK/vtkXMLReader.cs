using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLReader
	/// </summary>
	/// <remarks>
	///    Superclass for VTK's XML format readers.
	///
	/// vtkXMLReader uses vtkXMLDataParser to parse a
	/// &lt;a href="http://www.vtk.org/Wiki/VTK_XML_Formats"&gt;VTK XML&lt;/a&gt; input file.
	/// Concrete subclasses then traverse the parsed file structure and extract data.
	/// </remarks>
	// Token: 0x020001A1 RID: 417
	public abstract class vtkXMLReader : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005149 RID: 20809 RVA: 0x0007649B File Offset: 0x0007469B
		static vtkXMLReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600514A RID: 20810 RVA: 0x000764C3 File Offset: 0x000746C3
		public vtkXMLReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600514B RID: 20811 RVA: 0x000764D1 File Offset: 0x000746D1
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600514C RID: 20812
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Test whether the file (type) with the given name can be read by this
		/// reader. If the file has a newer version than the reader, we still say
		/// we can read the file type and we fail later, when we try to read the file.
		/// This enables clients (ParaView) to distinguish between failures when we
		/// need to look for another reader and failures when we don't.
		/// </summary>
		// Token: 0x0600514D RID: 20813 RVA: 0x000764DC File Offset: 0x000746DC
		public virtual int CanReadFile(string name)
		{
			return vtkXMLReader.vtkXMLReader_CanReadFile_01(base.GetCppThis(), name);
		}

		// Token: 0x0600514E RID: 20814
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLReader_CopyOutputInformation_02(HandleRef pThis, HandleRef arg0, int arg1);

		/// <summary>
		/// Get/Set whether the point, cell, column or time array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x0600514F RID: 20815 RVA: 0x000764FC File Offset: 0x000746FC
		public virtual void CopyOutputInformation(vtkInformation arg0, int arg1)
		{
			vtkXMLReader.vtkXMLReader_CopyOutputInformation_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), arg1);
		}

		// Token: 0x06005150 RID: 20816
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLReader_GetActiveTimeDataArrayName_03(HandleRef pThis);

		/// <summary>
		/// Setter / Getter on ActiveTimeDataArrayName. This string
		/// holds the selected time array name. If set to `nullptr`,
		/// time values are the sequence of positive integers starting at zero.
		/// Default value is `TimeValue` for legacy reasons.
		/// </summary>
		// Token: 0x06005151 RID: 20817 RVA: 0x0007652C File Offset: 0x0007472C
		public virtual string GetActiveTimeDataArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLReader.vtkXMLReader_GetActiveTimeDataArrayName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005152 RID: 20818
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLReader_GetCellArrayName_04(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the point, cell, column or time array with the given index in
		/// the input.
		/// </summary>
		// Token: 0x06005153 RID: 20819 RVA: 0x00076568 File Offset: 0x00074768
		public string GetCellArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLReader.vtkXMLReader_GetCellArrayName_04(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005154 RID: 20820
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLReader_GetCellArrayStatus_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set whether the point, cell, column or time array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x06005155 RID: 20821 RVA: 0x000765A4 File Offset: 0x000747A4
		public int GetCellArrayStatus(string name)
		{
			return vtkXMLReader.vtkXMLReader_GetCellArrayStatus_05(base.GetCppThis(), name);
		}

		// Token: 0x06005156 RID: 20822
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLReader_GetCellDataArraySelection_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data array selection tables used to configure which data
		/// arrays are loaded by the reader.
		/// </summary>
		// Token: 0x06005157 RID: 20823 RVA: 0x000765C4 File Offset: 0x000747C4
		public virtual vtkDataArraySelection GetCellDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLReader.vtkXMLReader_GetCellDataArraySelection_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x06005158 RID: 20824
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLReader_GetColumnArrayName_07(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the point, cell, column or time array with the given index in
		/// the input.
		/// </summary>
		// Token: 0x06005159 RID: 20825 RVA: 0x00076634 File Offset: 0x00074834
		public string GetColumnArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLReader.vtkXMLReader_GetColumnArrayName_07(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600515A RID: 20826
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLReader_GetColumnArraySelection_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data array selection tables used to configure which data
		/// arrays are loaded by the reader.
		/// </summary>
		// Token: 0x0600515B RID: 20827 RVA: 0x00076670 File Offset: 0x00074870
		public virtual vtkDataArraySelection GetColumnArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLReader.vtkXMLReader_GetColumnArraySelection_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x0600515C RID: 20828
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLReader_GetColumnArrayStatus_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set whether the point, cell, column or time array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x0600515D RID: 20829 RVA: 0x000766E0 File Offset: 0x000748E0
		public int GetColumnArrayStatus(string name)
		{
			return vtkXMLReader.vtkXMLReader_GetColumnArrayStatus_09(base.GetCppThis(), name);
		}

		// Token: 0x0600515E RID: 20830
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLReader_GetFileName_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of the input file.
		/// </summary>
		// Token: 0x0600515F RID: 20831 RVA: 0x00076700 File Offset: 0x00074900
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLReader.vtkXMLReader_GetFileName_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005160 RID: 20832
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLReader_GetNumberOfCellArrays_11(HandleRef pThis);

		/// <summary>
		/// Get the number of point, cell or column arrays available in the input.
		/// </summary>
		// Token: 0x06005161 RID: 20833 RVA: 0x0007673C File Offset: 0x0007493C
		public int GetNumberOfCellArrays()
		{
			return vtkXMLReader.vtkXMLReader_GetNumberOfCellArrays_11(base.GetCppThis());
		}

		// Token: 0x06005162 RID: 20834
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLReader_GetNumberOfColumnArrays_12(HandleRef pThis);

		/// <summary>
		/// Get the number of point, cell or column arrays available in the input.
		/// </summary>
		// Token: 0x06005163 RID: 20835 RVA: 0x0007675C File Offset: 0x0007495C
		public int GetNumberOfColumnArrays()
		{
			return vtkXMLReader.vtkXMLReader_GetNumberOfColumnArrays_12(base.GetCppThis());
		}

		// Token: 0x06005164 RID: 20836
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLReader_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005165 RID: 20837 RVA: 0x0007677C File Offset: 0x0007497C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLReader.vtkXMLReader_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x06005166 RID: 20838
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLReader_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005167 RID: 20839 RVA: 0x0007679C File Offset: 0x0007499C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLReader.vtkXMLReader_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x06005168 RID: 20840
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLReader_GetNumberOfPointArrays_15(HandleRef pThis);

		/// <summary>
		/// Get the number of point, cell or column arrays available in the input.
		/// </summary>
		// Token: 0x06005169 RID: 20841 RVA: 0x000767B8 File Offset: 0x000749B8
		public int GetNumberOfPointArrays()
		{
			return vtkXMLReader.vtkXMLReader_GetNumberOfPointArrays_15(base.GetCppThis());
		}

		// Token: 0x0600516A RID: 20842
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLReader_GetNumberOfTimeDataArrays_16(HandleRef pThis);

		/// <summary>
		/// Getters for time data array candidates.
		/// </summary>
		// Token: 0x0600516B RID: 20843 RVA: 0x000767D8 File Offset: 0x000749D8
		public int GetNumberOfTimeDataArrays()
		{
			return vtkXMLReader.vtkXMLReader_GetNumberOfTimeDataArrays_16(base.GetCppThis());
		}

		// Token: 0x0600516C RID: 20844
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLReader_GetNumberOfTimeSteps_17(HandleRef pThis);

		/// <summary>
		/// Which TimeStep to read.
		/// </summary>
		// Token: 0x0600516D RID: 20845 RVA: 0x000767F8 File Offset: 0x000749F8
		public virtual int GetNumberOfTimeSteps()
		{
			return vtkXMLReader.vtkXMLReader_GetNumberOfTimeSteps_17(base.GetCppThis());
		}

		// Token: 0x0600516E RID: 20846
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLReader_GetOutputAsDataSet_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a vtkDataSet pointer.
		/// </summary>
		// Token: 0x0600516F RID: 20847 RVA: 0x00076818 File Offset: 0x00074A18
		public vtkDataSet GetOutputAsDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLReader.vtkXMLReader_GetOutputAsDataSet_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x06005170 RID: 20848
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLReader_GetOutputAsDataSet_19(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a vtkDataSet pointer.
		/// </summary>
		// Token: 0x06005171 RID: 20849 RVA: 0x00076888 File Offset: 0x00074A88
		public vtkDataSet GetOutputAsDataSet(int index)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLReader.vtkXMLReader_GetOutputAsDataSet_19(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x06005172 RID: 20850
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLReader_GetParserErrorObserver_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the ErrorObserver for the internal xml parser
		/// This is useful for applications that want to catch error messages.
		/// </summary>
		// Token: 0x06005173 RID: 20851 RVA: 0x000768F8 File Offset: 0x00074AF8
		public virtual vtkCommand GetParserErrorObserver()
		{
			vtkCommand vtkCommand = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLReader.vtkXMLReader_GetParserErrorObserver_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCommand = (vtkCommand)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCommand.Register(null);
				}
			}
			return vtkCommand;
		}

		// Token: 0x06005174 RID: 20852
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLReader_GetPointArrayName_21(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the point, cell, column or time array with the given index in
		/// the input.
		/// </summary>
		// Token: 0x06005175 RID: 20853 RVA: 0x00076968 File Offset: 0x00074B68
		public string GetPointArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLReader.vtkXMLReader_GetPointArrayName_21(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005176 RID: 20854
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLReader_GetPointArrayStatus_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set whether the point, cell, column or time array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x06005177 RID: 20855 RVA: 0x000769A4 File Offset: 0x00074BA4
		public int GetPointArrayStatus(string name)
		{
			return vtkXMLReader.vtkXMLReader_GetPointArrayStatus_22(base.GetCppThis(), name);
		}

		// Token: 0x06005178 RID: 20856
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLReader_GetPointDataArraySelection_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data array selection tables used to configure which data
		/// arrays are loaded by the reader.
		/// </summary>
		// Token: 0x06005179 RID: 20857 RVA: 0x000769C4 File Offset: 0x00074BC4
		public virtual vtkDataArraySelection GetPointDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLReader.vtkXMLReader_GetPointDataArraySelection_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x0600517A RID: 20858
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLReader_GetReadFromInputString_24(HandleRef pThis);

		/// <summary>
		/// Enable reading from an InputString instead of the default, a file.
		/// </summary>
		// Token: 0x0600517B RID: 20859 RVA: 0x00076A34 File Offset: 0x00074C34
		public virtual int GetReadFromInputString()
		{
			return vtkXMLReader.vtkXMLReader_GetReadFromInputString_24(base.GetCppThis());
		}

		// Token: 0x0600517C RID: 20860
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLReader_GetReaderErrorObserver_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the ErrorObserver for the internal reader
		/// This is useful for applications that want to catch error messages.
		/// </summary>
		// Token: 0x0600517D RID: 20861 RVA: 0x00076A54 File Offset: 0x00074C54
		public virtual vtkCommand GetReaderErrorObserver()
		{
			vtkCommand vtkCommand = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLReader.vtkXMLReader_GetReaderErrorObserver_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCommand = (vtkCommand)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCommand.Register(null);
				}
			}
			return vtkCommand;
		}

		// Token: 0x0600517E RID: 20862
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLReader_GetTimeDataArray_26(HandleRef pThis, int idx);

		/// <summary>
		/// Getters for time data array candidates.
		/// </summary>
		// Token: 0x0600517F RID: 20863 RVA: 0x00076AC4 File Offset: 0x00074CC4
		public string GetTimeDataArray(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLReader.vtkXMLReader_GetTimeDataArray_26(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005180 RID: 20864
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLReader_GetTimeDataStringArray_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Getters for time data array candidates.
		/// </summary>
		// Token: 0x06005181 RID: 20865 RVA: 0x00076B00 File Offset: 0x00074D00
		public virtual vtkStringArray GetTimeDataStringArray()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLReader.vtkXMLReader_GetTimeDataStringArray_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06005182 RID: 20866
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLReader_GetTimeStep_28(HandleRef pThis);

		/// <summary>
		/// Which TimeStep to read.
		/// </summary>
		// Token: 0x06005183 RID: 20867 RVA: 0x00076B70 File Offset: 0x00074D70
		public virtual int GetTimeStep()
		{
			return vtkXMLReader.vtkXMLReader_GetTimeStep_28(base.GetCppThis());
		}

		// Token: 0x06005184 RID: 20868
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLReader_GetTimeStepRange_29(HandleRef pThis);

		/// <summary>
		/// Which TimeStepRange to read
		/// </summary>
		// Token: 0x06005185 RID: 20869 RVA: 0x00076B90 File Offset: 0x00074D90
		public virtual int[] GetTimeStepRange()
		{
			IntPtr intPtr = vtkXMLReader.vtkXMLReader_GetTimeStepRange_29(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06005186 RID: 20870
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLReader_GetTimeStepRange_30(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Which TimeStepRange to read
		/// </summary>
		// Token: 0x06005187 RID: 20871 RVA: 0x00076BD8 File Offset: 0x00074DD8
		public virtual void GetTimeStepRange(ref int _arg1, ref int _arg2)
		{
			vtkXMLReader.vtkXMLReader_GetTimeStepRange_30(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06005188 RID: 20872
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLReader_GetTimeStepRange_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Which TimeStepRange to read
		/// </summary>
		// Token: 0x06005189 RID: 20873 RVA: 0x00076BE9 File Offset: 0x00074DE9
		public virtual void GetTimeStepRange(IntPtr _arg)
		{
			vtkXMLReader.vtkXMLReader_GetTimeStepRange_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600518A RID: 20874
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLReader_GetXMLParser_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the internal XML parser. This can be used to access
		/// the XML DOM after RequestInformation() was called.
		/// </summary>
		// Token: 0x0600518B RID: 20875 RVA: 0x00076BFC File Offset: 0x00074DFC
		public vtkXMLDataParser GetXMLParser()
		{
			vtkXMLDataParser vtkXMLDataParser = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLReader.vtkXMLReader_GetXMLParser_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataParser = (vtkXMLDataParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataParser.Register(null);
				}
			}
			return vtkXMLDataParser;
		}

		// Token: 0x0600518C RID: 20876
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLReader_IsA_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600518D RID: 20877 RVA: 0x00076C6C File Offset: 0x00074E6C
		public override int IsA(string type)
		{
			return vtkXMLReader.vtkXMLReader_IsA_33(base.GetCppThis(), type);
		}

		// Token: 0x0600518E RID: 20878
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLReader_IsTypeOf_34([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600518F RID: 20879 RVA: 0x00076C8C File Offset: 0x00074E8C
		public new static int IsTypeOf(string type)
		{
			return vtkXMLReader.vtkXMLReader_IsTypeOf_34(type);
		}

		// Token: 0x06005190 RID: 20880
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLReader_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005191 RID: 20881 RVA: 0x00076CA8 File Offset: 0x00074EA8
		public new vtkXMLReader NewInstance()
		{
			vtkXMLReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLReader.vtkXMLReader_NewInstance_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005192 RID: 20882
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLReader_ReadFromInputStringOff_36(HandleRef pThis);

		/// <summary>
		/// Enable reading from an InputString instead of the default, a file.
		/// </summary>
		// Token: 0x06005193 RID: 20883 RVA: 0x00076D02 File Offset: 0x00074F02
		public virtual void ReadFromInputStringOff()
		{
			vtkXMLReader.vtkXMLReader_ReadFromInputStringOff_36(base.GetCppThis());
		}

		// Token: 0x06005194 RID: 20884
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLReader_ReadFromInputStringOn_37(HandleRef pThis);

		/// <summary>
		/// Enable reading from an InputString instead of the default, a file.
		/// </summary>
		// Token: 0x06005195 RID: 20885 RVA: 0x00076D11 File Offset: 0x00074F11
		public virtual void ReadFromInputStringOn()
		{
			vtkXMLReader.vtkXMLReader_ReadFromInputStringOn_37(base.GetCppThis());
		}

		// Token: 0x06005196 RID: 20886
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLReader_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005197 RID: 20887 RVA: 0x00076D20 File Offset: 0x00074F20
		public new static vtkXMLReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLReader vtkXMLReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLReader.vtkXMLReader_SafeDownCast_38((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLReader = (vtkXMLReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLReader.Register(null);
				}
			}
			return vtkXMLReader;
		}

		// Token: 0x06005198 RID: 20888
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLReader_SetActiveTimeDataArrayName_39(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Setter / Getter on ActiveTimeDataArrayName. This string
		/// holds the selected time array name. If set to `nullptr`,
		/// time values are the sequence of positive integers starting at zero.
		/// Default value is `TimeValue` for legacy reasons.
		/// </summary>
		// Token: 0x06005199 RID: 20889 RVA: 0x00076D9F File Offset: 0x00074F9F
		public virtual void SetActiveTimeDataArrayName(string _arg)
		{
			vtkXMLReader.vtkXMLReader_SetActiveTimeDataArrayName_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0600519A RID: 20890
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLReader_SetCellArrayStatus_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Get/Set whether the point, cell, column or time array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x0600519B RID: 20891 RVA: 0x00076DAF File Offset: 0x00074FAF
		public void SetCellArrayStatus(string name, int status)
		{
			vtkXMLReader.vtkXMLReader_SetCellArrayStatus_40(base.GetCppThis(), name, status);
		}

		// Token: 0x0600519C RID: 20892
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLReader_SetColumnArrayStatus_41(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Get/Set whether the point, cell, column or time array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x0600519D RID: 20893 RVA: 0x00076DC0 File Offset: 0x00074FC0
		public void SetColumnArrayStatus(string name, int status)
		{
			vtkXMLReader.vtkXMLReader_SetColumnArrayStatus_41(base.GetCppThis(), name, status);
		}

		// Token: 0x0600519E RID: 20894
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLReader_SetFileName_42(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the name of the input file.
		/// </summary>
		// Token: 0x0600519F RID: 20895 RVA: 0x00076DD1 File Offset: 0x00074FD1
		public virtual void SetFileName(string _arg)
		{
			vtkXMLReader.vtkXMLReader_SetFileName_42(base.GetCppThis(), _arg);
		}

		// Token: 0x060051A0 RID: 20896
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLReader_SetInputString_43(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string s);

		/// <summary>
		/// Enable reading from an InputString instead of the default, a file.
		/// </summary>
		// Token: 0x060051A1 RID: 20897 RVA: 0x00076DE1 File Offset: 0x00074FE1
		public void SetInputString(string s)
		{
			vtkXMLReader.vtkXMLReader_SetInputString_43(base.GetCppThis(), s);
		}

		// Token: 0x060051A2 RID: 20898
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLReader_SetParserErrorObserver_44(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/get the ErrorObserver for the internal xml parser
		/// This is useful for applications that want to catch error messages.
		/// </summary>
		// Token: 0x060051A3 RID: 20899 RVA: 0x00076DF4 File Offset: 0x00074FF4
		public void SetParserErrorObserver(vtkCommand arg0)
		{
			vtkXMLReader.vtkXMLReader_SetParserErrorObserver_44(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060051A4 RID: 20900
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLReader_SetPointArrayStatus_45(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Get/Set whether the point, cell, column or time array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x060051A5 RID: 20901 RVA: 0x00076E23 File Offset: 0x00075023
		public void SetPointArrayStatus(string name, int status)
		{
			vtkXMLReader.vtkXMLReader_SetPointArrayStatus_45(base.GetCppThis(), name, status);
		}

		// Token: 0x060051A6 RID: 20902
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLReader_SetReadFromInputString_46(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable reading from an InputString instead of the default, a file.
		/// </summary>
		// Token: 0x060051A7 RID: 20903 RVA: 0x00076E34 File Offset: 0x00075034
		public virtual void SetReadFromInputString(int _arg)
		{
			vtkXMLReader.vtkXMLReader_SetReadFromInputString_46(base.GetCppThis(), _arg);
		}

		// Token: 0x060051A8 RID: 20904
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLReader_SetReaderErrorObserver_47(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/get the ErrorObserver for the internal reader
		/// This is useful for applications that want to catch error messages.
		/// </summary>
		// Token: 0x060051A9 RID: 20905 RVA: 0x00076E44 File Offset: 0x00075044
		public void SetReaderErrorObserver(vtkCommand arg0)
		{
			vtkXMLReader.vtkXMLReader_SetReaderErrorObserver_47(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060051AA RID: 20906
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLReader_SetTimeStep_48(HandleRef pThis, int _arg);

		/// <summary>
		/// Which TimeStep to read.
		/// </summary>
		// Token: 0x060051AB RID: 20907 RVA: 0x00076E73 File Offset: 0x00075073
		public virtual void SetTimeStep(int _arg)
		{
			vtkXMLReader.vtkXMLReader_SetTimeStep_48(base.GetCppThis(), _arg);
		}

		// Token: 0x060051AC RID: 20908
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLReader_SetTimeStepRange_49(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Which TimeStepRange to read
		/// </summary>
		// Token: 0x060051AD RID: 20909 RVA: 0x00076E83 File Offset: 0x00075083
		public virtual void SetTimeStepRange(int _arg1, int _arg2)
		{
			vtkXMLReader.vtkXMLReader_SetTimeStepRange_49(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x060051AE RID: 20910
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLReader_SetTimeStepRange_50(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Which TimeStepRange to read
		/// </summary>
		// Token: 0x060051AF RID: 20911 RVA: 0x00076E94 File Offset: 0x00075094
		public void SetTimeStepRange(IntPtr _arg)
		{
			vtkXMLReader.vtkXMLReader_SetTimeStepRange_50(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007A5 RID: 1957
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007A6 RID: 1958
		public new static readonly string MRClassNameKey = "class vtkXMLReader";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020001A2 RID: 418
		public enum FieldType
		{
			/// <summary>enum member</summary>
			// Token: 0x040007A8 RID: 1960
			CELL_DATA = 1,
			/// <summary>enum member</summary>
			// Token: 0x040007A9 RID: 1961
			OTHER,
			/// <summary>enum member</summary>
			// Token: 0x040007AA RID: 1962
			POINT_DATA = 0
		}
	}
}
